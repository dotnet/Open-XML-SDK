// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

#pragma warning disable CA1822

namespace DocumentFormat.OpenXml.Validation
{
    /// <summary>
    /// DocumentValidator - defines a base class for document validator.
    /// </summary>
    internal sealed class DocumentValidator
    {
        private readonly ValidationCache _cache;

        /// <summary>
        /// Initializes a new instance of the DocumentValidator.
        /// </summary>
        /// <param name="cache">The shared validation cache.</param>
        public DocumentValidator(ValidationCache cache)
        {
            _cache = cache;
        }

        /// <summary>
        /// Validate the specified document.
        /// </summary>
        /// <param name="document">The document to be validated.</param>
        /// <param name="settings">The settings to be used during validation.</param>
        /// <param name="token"></param>
        /// <returns>Return results in ValidationResult.</returns>
        public List<ValidationErrorInfo> Validate(OpenXmlPackage document, ValidationSettings settings, CancellationToken token)
        {
            var context = new ValidationContext(settings, _cache, token);

            using (context.Stack.Push(document))
            {
                // integrate the package validation.
                ValidatePackageStructure(document, context);

                foreach (var part in PartsToBeValidated(document))
                {
                    // traverse from the part root element (by DOM or by Reader) in post-order
                    // that means validate the children first, then validate the parent
                    // the validation engine call bookkeep information
                    ValidatePart(part, context);
                }
            }

            return context.Errors;
        }

        /// <summary>
        /// Validate the specified part.
        /// </summary>
        /// <param name="part">The OpenXmlPart to be validated.</param>
        /// <param name="settings">The settings to be used during validation.</param>
        /// <param name="token"></param>
        /// <returns></returns>
        public List<ValidationErrorInfo> Validate(OpenXmlPart part, ValidationSettings settings, CancellationToken token)
        {
            var context = new ValidationContext(settings, _cache, token);

            ValidatePart(part, context);

            return context.Errors;
        }

        private void ValidatePart(OpenXmlPart part, ValidationContext context)
        {
            // if the part is not defined in the specified version, then do not validate the content.
            if (!part.IsInVersion(_cache.Version))
            {
                return;
            }

            try
            {
                // Must be called before the call to PartRootElement { get; }
                bool partRootElementLoaded = part.IsRootElementLoaded;

                // Schema validation
                using (context.Stack.Push(part: part, element: part.PartRootElement))
                {
                    var lastErrorCount = context.Errors.Count;

                    if (part.PartRootElement != null)
                    {
                        Validate(context);
                    }

                    if (!partRootElementLoaded && context.Errors.Count == lastErrorCount)
                    {
                        // No new errors in this part. Release the DOM to GC memory.
                        part.SetPartRootElementToNull();
                    }
                }
            }
            catch (System.Xml.XmlException e)
            {
                var errorInfo = new ValidationErrorInfo
                {
                    ErrorType = ValidationErrorType.Schema,
                    Id = "ExceptionError",
                    Part = part,
                    Description = SR.Format(ValidationResources.ExceptionError, e.Message),
                };

                context.AddError(errorInfo);
            }
        }

        public void Validate(ValidationContext validationContext)
        {
            Debug.Assert(validationContext != null);
            Debug.Assert(validationContext.Stack.Current.Element != null);

            var openxmlElement = validationContext.Stack.Current.Element;

            Debug.Assert(!(openxmlElement is OpenXmlUnknownElement || openxmlElement is OpenXmlMiscNode));

            // Can not just validate AlternateContent / Choice / Fallback
            // Debug.Assert(!(openxmlElement is AlternateContent))
            Debug.Assert(!(openxmlElement is AlternateContentChoice || openxmlElement is AlternateContentFallback));

            ValidationTraverser.ValidatingTraverse(validationContext, SchemaTypeValidator.Validate);

            ValidationTraverser.ValidatingTraverse(validationContext, context =>
            {
                foreach (var constraint in context.Stack.Current.Element.Metadata.Constraints)
                {
                    constraint.Validate(context);
                }
            });
        }

        /// <summary>
        /// Gets all the parts needs to be validated.
        /// </summary>
        private IEnumerable<OpenXmlPart> PartsToBeValidated(OpenXmlPackage package)
        {
            var mainPart = package.RootPart;
            if (mainPart != null)
            {
                var parts = new Dictionary<OpenXmlPart, bool>();
                package.FindAllReachableParts(parts);

                foreach (var part in parts.Keys)
                {
                    // Only validate the parts defined in the specified version.
                    // Example: do not validate new Office2010 parts if the FileFormat is Office2007.
                    if (part.IsInVersion(_cache.Version))
                    {
                        yield return part;
                    }
                }
            }
        }

        private static void ValidatePackageStructure(OpenXmlPackage document, ValidationContext context)
        {
            var documentName = document.GetType().Name;

            var errors = new PackageValidator(document).Validate(context.FileFormat)
                .Select(e =>
                {
                    var errorInfo = new ValidationErrorInfo
                    {
                        ErrorType = ValidationErrorType.Package,
                        Id = "Pkg_" + e.MessageId,
                    };

                    string name;

                    switch (errorInfo.Id)
                    {
                        case "Pkg_PartIsNotAllowed":
                            Debug.Assert(e.SubPart != null);
                            name = e.Part != null ? GetPartNameAndUri(e.Part) : documentName;
                            errorInfo.Description = SR.Format(ValidationResources.Pkg_PartIsNotAllowed, name, GetPartNameAndUri(e.SubPart));
                            break;

                        case "Pkg_RequiredPartDoNotExist":
                            errorInfo.Description = SR.Format(ValidationResources.Pkg_RequiredPartDoNotExist, e.PartClassName);
                            break;

                        case "Pkg_OnlyOnePartAllowed":
                            name = e.Part != null ? GetPartNameAndUri(e.Part) : documentName;
                            errorInfo.Description = SR.Format(ValidationResources.Pkg_OnlyOnePartAllowed, name, e.PartClassName);
#if DEBUG
                            Debug.Assert(e.SubPart != null);
                            errorInfo.RelatedPart = e.SubPart;
#endif
                            break;

                        case "Pkg_ExtendedPartIsOpenXmlPart":
                            Debug.Assert(e.SubPart != null);
                            errorInfo.Description = SR.Format(ValidationResources.Pkg_ExtendedPartIsOpenXmlPart, GetPartUri(e.SubPart));
                            break;

                        case "Pkg_DataPartReferenceIsNotAllowed":
                            Debug.Assert(e.DataPartReferenceRelationship != null);
                            name = e.Part != null ? GetPartNameAndUri(e.Part) : documentName;
                            errorInfo.Description = SR.Format(ValidationResources.Pkg_PartIsNotAllowed, name, e.DataPartReferenceRelationship.Uri);
                            break;

                        case "Pkg_InvalidContentTypePart":  // won't get this error.
                        default:
                            Debug.Assert(false, "Invalid package validation event.");
                            break;
                    }

                    if (e.Part != null)
                    {
                        errorInfo.Part = e.Part;
                    }

                    errorInfo.RelatedPart = e.SubPart;

                    return errorInfo;
                });

            context.Errors.AddRange(errors);
        }

        private static string GetPartNameAndUri(OpenXmlPart part)
        {
            Debug.Assert(part != null);
            string partClassName = part.GetType().Name;

            // Example: WordprocessingCommentsPart{/word/comments.xml}
            return SR.Format("{0}{1}{2}{3}", partClassName, '{', part.Uri, '}');
        }

        private static string GetPartUri(OpenXmlPart part)
        {
            Debug.Assert(part != null);

            // Example: WordprocessingCommentsPart{/word/comments.xml}
            return SR.Format("{0}{1}{2}", '{', part.Uri, '}');
        }
    }
}
