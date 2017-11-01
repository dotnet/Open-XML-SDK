// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DocumentFormat.OpenXml.Tests
{
    public static partial class OpenXmlDomTestExtensions
    {
        /// <summary>
        /// Get Main Part of current package
        /// </summary>
        /// <param name="package">current package</param>
        /// <returns>Return main part of current package, null if not exist.</returns>
        public static OpenXmlPart MainPart(this OpenXmlPackage package)
        {
            if (null == package)
            {
                throw new ArgumentNullException(nameof(package));
            }

            if (package is WordprocessingDocument word)
            {
                return word.MainDocumentPart;
            }
            else if (package is SpreadsheetDocument spreadsheet)
            {
                return spreadsheet.WorkbookPart;
            }
            else if (package is PresentationDocument presentation)
            {
                return presentation.PresentationPart;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Get Non-Main Part of current package
        /// </summary>
        /// <param name="package">current package</param>
        /// <returns>Return non-main part of current package, null if not exist.</returns>
        public static IEnumerable<OpenXmlPart> NonMainParts(this OpenXmlPackage package)
        {
            return package.DescendantParts()
                .Where(p => p.IsReflectable() && !p.IsMainPart());
        }

        /// <summary>
        /// Get All Parts of the specified package/part in depth-first pre-order.
        /// </summary>
        /// <param name="root">package or part which can contain parts.</param>
        /// <returns>IEnumerable<OpenXmlPart> of parts in the pass-in <paramref name="root"/>.</returns>
        public static IEnumerable<OpenXmlPart> DescendantParts(this OpenXmlPartContainer root)
        {
            if (null == root)
                throw new ArgumentNullException("root");

            IList<OpenXmlPart> parts = new List<OpenXmlPart>();
            List<string> uriList = new List<string>();
            addChildParts(parts, uriList, root);
            return parts;
        }

        public static IEnumerable<IdPartPair> DescendantIdPartPairs(this OpenXmlPartContainer root)
        {
            if (null == root)
                throw new ArgumentException("root");

            IList<IdPartPair> idPartPairs = new List<IdPartPair>();
            addChildIdPartPairs(idPartPairs, root);
            return idPartPairs;
        }

        /// <summary>
        /// Compare two OpenXmlPackages
        /// </summary>
        /// <param name="sourcePackage">the source package for comparison</param>
        /// <param name="targetPackage">the target package for comparison</param>
        /// <returns>TRUE, if two packages contains the same contents. FALSE, if not</returns>
        public static Boolean Compare(this OpenXmlPackage sourcePackage, OpenXmlPackage targetPackage)
        {
            //if two packages have the same reference, return true
            if (sourcePackage == targetPackage)
                return true;

            // if only one of the them is null, return false
            if ((targetPackage == null && sourcePackage != null) || (sourcePackage == null && targetPackage != null))
                return false;

            // if they contains different number of externalrelationships, return false
            if (sourcePackage.ExternalRelationships.Count() != targetPackage.ExternalRelationships.Count())
                return false;

            // if they contains different number of hyperlinkrelationships, return false
            if (sourcePackage.HyperlinkRelationships.Count() != targetPackage.HyperlinkRelationships.Count())
                return false;

            // if they contains different number of parts, return false
            if (sourcePackage.Parts.Count() != targetPackage.Parts.Count())
                return false;

            // if they contains different number of descendent parts, return false
            if (sourcePackage.DescendantParts().Count() != targetPackage.DescendantParts().Count())
                return false;

            // compare each extenalrelationship
            foreach (var id in sourcePackage.ExternalRelationships)
            {
                if (targetPackage.ExternalRelationships.Where(i => i.Id == id.Id && i.RelationshipType == id.RelationshipType && i.Uri == id.Uri).Count() != 1)
                    return false;
            }
            //compare each hyperlinkrelationship
            foreach (var id in sourcePackage.HyperlinkRelationships)
            {
                if (targetPackage.HyperlinkRelationships.Where(i => i.Id == id.Id && i.IsExternal == id.IsExternal && i.Uri == id.Uri).Count() != 1)
                    return false;
            }

            // compare each parts contains in the package
            foreach (var part in sourcePackage.Parts)
            {
                if (part.OpenXmlPart.IsMainPart())
                {
                    if (!part.OpenXmlPart.Compare(targetPackage.Parts.Single(p => p.OpenXmlPart is MainDocumentPart || p.OpenXmlPart is WorkbookPart || p.OpenXmlPart is PresentationPart).OpenXmlPart))
                        return false;
                }
                else if (part.OpenXmlPart is CoreFilePropertiesPart)
                {
                    var sourcePackPr = sourcePackage.PackageProperties;
                    var targetPackPr = targetPackage.PackageProperties;

                    if (sourcePackPr.Category != targetPackPr.Category)
                        return false;

                    if (sourcePackPr.ContentStatus != targetPackPr.ContentStatus)
                        return false;

                    if (sourcePackPr.ContentType != targetPackPr.ContentType)
                        return false;

                    if (sourcePackPr.Created.HasValue && sourcePackPr.Created.Value.CompareTo(targetPackPr.Created.Value) != 0)
                        return false;

                    if (sourcePackPr.Creator != targetPackPr.Creator)
                        return false;

                    if (sourcePackPr.Description != targetPackPr.Description)
                        return false;

                    if (sourcePackPr.Identifier != targetPackPr.Identifier)
                        return false;

                    if (sourcePackPr.Keywords != targetPackPr.Keywords)
                        return false;

                    if (sourcePackPr.Language != targetPackPr.Language)
                        return false;

                    if (sourcePackPr.LastModifiedBy != targetPackPr.LastModifiedBy)
                        return false;

                    if (sourcePackPr.LastPrinted.HasValue && sourcePackPr.LastPrinted.Value.CompareTo(targetPackPr.LastPrinted.Value) != 0)
                        return false;

                    if (sourcePackPr.Modified.HasValue && sourcePackPr.Modified.Value.CompareTo(targetPackPr.Modified.Value) != 0)
                        return false;

                    if (sourcePackPr.Revision != targetPackPr.Revision)
                        return false;

                    if (sourcePackPr.Subject != targetPackPr.Subject)
                        return false;

                    if (sourcePackPr.Title != targetPackPr.Title)
                        return false;

                    if (sourcePackPr.Version != targetPackPr.Version)
                        return false;
                }
                else if (!part.OpenXmlPart.Compare(targetPackage.Parts.Single(p => p.RelationshipId == part.RelationshipId).OpenXmlPart))
                    return false;
            }
            return true;
        }
    }
}
