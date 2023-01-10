// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;

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
        /// Validate against a given version
        /// </summary>
        /// <param name="version">Version to validate against</param>
        /// <returns>The validation errors</returns>
        public IEnumerable<OpenXmlPackageValidationResult> Validate(FileFormatVersions version)
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
        private IEnumerable<OpenXmlPackageValidationResult> ValidateInternal(OpenXmlPartContainer container, FileFormatVersions version, Dictionary<OpenXmlPart, bool> processedParts)
        {
            var containerConstraints = container.Features.GetRequired<IPartConstraintFeature>();

            foreach (var result in ValidateDataPartReferenceRelationships(container, version))
            {
                yield return result;
            }

            // count all parts of same type
            var partOccurs = new Dictionary<string, int>(StringComparer.Ordinal);

            foreach (var part in container.ChildrenRelationshipParts.Parts)
            {
                if (partOccurs.TryGetValue(part.RelationshipType, out int occurs))
                {
                    partOccurs[part.RelationshipType] = occurs + 1;
                }
                else
                {
                    partOccurs.Add(part.RelationshipType, 1);
                }

                if (container is not ExtendedPart && !containerConstraints.TryGetRule(part.RelationshipType, out _) && part.IsInVersion(version))
                {
                    yield return new OpenXmlPackageValidationResult
                    {
                        MessageId = "PartIsNotAllowed",
                        RelationshipType = part.RelationshipType,
                        Part = container.ThisOpenXmlPart,
                        SubPart = part,
                    };
                }

                // if the part is not defined in this version, then should not report error, just treat it as ExtendedPart.
            }

            foreach (var constraintRule in containerConstraints.Rules)
            {
                // validate the required parts
                if (constraintRule.MinOccursIsNonZero

                    // only check rules apply to the specified version.
                    && version.AtLeast(constraintRule.FileFormat))
                {
                    // must have one
                    if (container.GetSubPart(constraintRule.RelationshipType) is null)
                    {
                        yield return new OpenXmlPackageValidationResult
                        {
                            MessageId = "RequiredPartDoNotExist",
                            RelationshipType = constraintRule.RelationshipType,
                            Part = container.ThisOpenXmlPart,
                        };
                    }
                }

                // check for parts MaxOccursGreatThanOne=false, but do have multiple instance
                if (!constraintRule.MaxOccursGreatThanOne

                    // only check rules apply to the specified version.
                    && version.AtLeast(constraintRule.FileFormat))
                {
                    if (partOccurs.TryGetValue(constraintRule.RelationshipType, out int occurs))
                    {
                        if (occurs > 1)
                        {
                            yield return new OpenXmlPackageValidationResult
                            {
                                MessageId = "OnlyOnePartAllowed",
                                RelationshipType = constraintRule.RelationshipType,
                                Part = container.ThisOpenXmlPart,
#if DEBUG
                                SubPart = container.GetSubPart(constraintRule.RelationshipType),
#endif
                            };
                        }
                    }
                }
            }

            foreach (var part in container.ChildrenRelationshipParts.Parts)
            {
                if (!processedParts.ContainsKey(part))
                {
                    if (part is not ExtendedPart)
                    {
                        if (containerConstraints.TryGetRule(part.RelationshipType, out var rule))
                        {
                            if (version.AtLeast(rule.FileFormat))
                            {
                                // validate content type
                                if (rule.ContentType is not null && part.ContentType != rule.ContentType)
                                {
                                    var message = SR.Format(ExceptionMessages.InvalidContentTypePart, rule.ContentType);

                                    yield return new OpenXmlPackageValidationResult
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
                            yield return new OpenXmlPackageValidationResult
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

        private static IEnumerable<OpenXmlPackageValidationResult> ValidateDataPartReferenceRelationships(OpenXmlPartContainer container, FileFormatVersions version)
        {
            var knownDataParts = container.Features.GetRequired<IKnownDataPartFeature>();

            // At current, only media / audio / video reference. There are all [0, unbounded].
            // So just check whether the reference is allowed.
            foreach (var dataPartReference in container.DataPartReferenceRelationships)
            {
                if (!knownDataParts.IsKnown(dataPartReference.RelationshipType))
                {
                    yield return new OpenXmlPackageValidationResult
                    {
                        MessageId = "DataPartReferenceIsNotAllowed",
                        RelationshipType = dataPartReference.RelationshipType,
                        Part = container.ThisOpenXmlPart,
                        SubPart = null,
                        DataPartReferenceRelationship = dataPartReference,
                    };
                }
            }
        }
    }
}
