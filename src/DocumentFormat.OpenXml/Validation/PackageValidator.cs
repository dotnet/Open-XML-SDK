// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Globalization;

#pragma warning disable 0618 // CS0618: A class member was marked with the Obsolete attribute, such that a warning will be issued when the class member is referenced.

namespace DocumentFormat.OpenXml.Validation
{
    /// <summary>
    /// Defines the base class for OpenXmlPackage and OpenXmlPart.
    /// </summary>
    internal struct PackageValidator
    {
        private readonly OpenXmlPackage _package;

        public PackageValidator(OpenXmlPackage package)
        {
            _package = package;
        }

        /// <summary>
        /// Validates the package. This method does not validate the XML content in each part.
        /// </summary>
        /// <param name="validationSettings">The OpenXmlPackageValidationSettings for validation events.</param>
        public void Validate(OpenXmlPackageValidationSettings validationSettings)
        {
            if (validationSettings == null)
            {
                throw new ArgumentNullException(nameof(validationSettings));
            }

            if (validationSettings.GetEventHandler() == null)
            {
                throw new ArgumentNullException(nameof(validationSettings.EventHandler));
            }

            if (!validationSettings.FileFormat.Any())
            {
                throw new ArgumentOutOfRangeException(nameof(validationSettings.FileFormat));
            }

            var handler = validationSettings.GetEventHandler();

            foreach (var result in Validate(validationSettings.FileFormat))
            {
                handler(result.Sender, result);
            }
        }

        /// <summary>
        /// Validate against a given version
        /// </summary>
        /// <param name="version">Version to validate against</param>
        /// <returns>The validation errors</returns>
        public IEnumerable<OpenXmlPackageValidationEventArgs> Validate(FileFormatVersions version)
        {
            // for cycle defense
            var processedParts = new Dictionary<OpenXmlPart, bool>();

            return ValidateInternal(_package, version, processedParts);
        }

        /// <summary>
        /// Validates the package (do not validate the xml content in each part).
        /// </summary>
        /// <param name="container">The Open XML container to validate</param>
        /// <param name="version">Version to validate against</param>
        /// <param name="processedParts">Parts already processed.</param>
        private IEnumerable<OpenXmlPackageValidationEventArgs> ValidateInternal(OpenXmlPartContainer container, FileFormatVersions version, Dictionary<OpenXmlPart, bool> processedParts)
        {
            foreach (var result in ValidateDataPartReferenceRelationships(container, version))
            {
                yield return result;
            }

            // count all parts of same type
            var partOccurs = new Dictionary<string, int>(StringComparer.Ordinal);

            foreach (var part in container.ChildrenRelationshipParts.Values)
            {
                if (partOccurs.TryGetValue(part.RelationshipType, out int occurs))
                {
                    partOccurs[part.RelationshipType] = occurs + 1;
                }
                else
                {
                    partOccurs.Add(part.RelationshipType, 1);
                }

                if (!(container is ExtendedPart) &&
                    !container.PartConstraints.ContainsRelationship(part.RelationshipType) &&
                    part.IsInVersion(version))
                {
                    yield return new OpenXmlPackageValidationEventArgs(container)
                    {
                        MessageId = "PartIsNotAllowed",
                        PartClassName = part.RelationshipType,
                        Part = container.ThisOpenXmlPart,
                        SubPart = part,
                    };
                }

                // if the part is not defined in this version, then should not report error, just treat it as ExtendedPart.
            }

            foreach (var constraintRulePair in container.PartConstraints)
            {
                var relatinshipType = constraintRulePair.Key;
                var constraintRule = constraintRulePair.Value;

                // validate the required parts
                if (constraintRule.MinOccursIsNonZero

                    // only check rules apply to the specified version.
                    && version.AtLeast(constraintRule.FileFormat))
                {
                    // must have one
                    if (null == container.GetSubPart(relatinshipType))
                    {
                        yield return new OpenXmlPackageValidationEventArgs(container)
                        {
                            MessageId = "RequiredPartDoNotExist",
                            PartClassName = constraintRule.PartClassName,
                            Part = container.ThisOpenXmlPart,
                        };
                    }
                }

                // check for parts MaxOccursGreatThanOne=false, but do have multiple instance
                if (!constraintRule.MaxOccursGreatThanOne

                    // only check rules apply to the specified version.
                    && version.AtLeast(constraintRule.FileFormat))
                {
                    if (partOccurs.TryGetValue(relatinshipType, out int occurs))
                    {
                        if (occurs > 1)
                        {
                            yield return new OpenXmlPackageValidationEventArgs(container)
                            {
                                MessageId = "OnlyOnePartAllowed",
                                PartClassName = constraintRule.PartClassName,
                                Part = container.ThisOpenXmlPart,
#if DEBUG
                                SubPart = container.GetSubPart(relatinshipType),
#endif
                            };
                        }
                    }
                }
            }

            foreach (var part in container.ChildrenRelationshipParts.Values)
            {
                if (!processedParts.ContainsKey(part))
                {
                    if (!(part is ExtendedPart))
                    {
                        if (container.PartConstraints.TryGetValue(part.RelationshipType, out var rule))
                        {
                            if (version.AtLeast(rule.FileFormat))
                            {
                                // validate content type
                                if (rule.PartContentType != null && part.ContentType != rule.PartContentType)
                                {
                                    var message = SR.Format(ExceptionMessages.InvalidContentTypePart, rule.PartContentType);

                                    yield return new OpenXmlPackageValidationEventArgs(container)
                                    {
                                        Message = message,
                                        MessageId = "InvalidContentTypePart",
                                        SubPart = part,
                                        Part = container.ThisOpenXmlPart,
                                    };
                                }
                            }
                            else
                            {
                                // if the part is not defined in this version, then should not report error, just treat it as ExtendedPart.
                            }
                        }
                    }
#if DEBUG
                    else
                    {
                        // check the relationship type
                        if (part.RelationshipType.StartsWith(@"http://schemas.openxmlformats.org", StringComparison.OrdinalIgnoreCase))
                        {
                            yield return new OpenXmlPackageValidationEventArgs(container)
                            {
                                MessageId = "ExtendedPartIsOpenXmlPart",
                                SubPart = part,
                                Part = container.ThisOpenXmlPart,
                            };
                        }
                    }
#endif
                    processedParts.Add(part, true);

                    foreach (var result in ValidateInternal(part, version, processedParts))
                    {
                        yield return result;
                    }
                }
            }
        }

        private IEnumerable<OpenXmlPackageValidationEventArgs> ValidateDataPartReferenceRelationships(OpenXmlPartContainer container, FileFormatVersions version)
        {
            // At current, only media / audio / video reference. There are all [0, unbounded].
            // So just check whether the reference is allowed.
            foreach (var dataPartReference in container.DataPartReferenceRelationships)
            {
                if (!container.DataPartReferenceConstraints.TryGetValue(dataPartReference.RelationshipType, out var constraintRule))
                {
                    yield return new OpenXmlPackageValidationEventArgs(container)
                    {
                        MessageId = "DataPartReferenceIsNotAllowed",
                        PartClassName = dataPartReference.RelationshipType,
                        Part = container.ThisOpenXmlPart,
                        SubPart = null,
                        DataPartReferenceRelationship = dataPartReference,
                    };
                }
            }
        }
    }
}
