// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Tests
{
    public static partial class OpenXmlPartExtensions
    {
        /// <summary>
        /// Check if current <paramref name="part"/> is main part of the package.
        /// </summary>
        /// <param name="part">Current Part</param>
        /// <returns>Return true if <paramref name="part"/> is main part of the package.</returns>
        public static bool IsMainPart(this OpenXmlPartContainer part)
        {
            if (part is MainDocumentPart || part is WorkbookPart || part is PresentationPart)
                return true;
            return false;
        }

        public static Boolean IsBibliographyPart(this OpenXmlPart part)
        {
            if (part is CustomXmlPart)
            {
                XElement PartRoot = null;
                using (var stream = part.GetStream())
                using (var reader = XmlReader.Create(stream))
                    PartRoot = XElement.Load(reader);

                if (PartRoot.Name.LocalName == "Sources")
                    return true;
            }
            return false;
        }

        public static Boolean IsAdditionalCharacteristicsPart(this OpenXmlPart part)
        {
            if (part is CustomXmlPart)
            {
                XElement PartRoot = null;
                using (var stream = part.GetStream())
                using (var reader = XmlReader.Create(stream))
                    PartRoot = XElement.Load(reader);

                if (PartRoot.Name.LocalName == "additionalCharacteristics")
                    return true;
            }
            return false;
        }

        public static Boolean IsInkPart(this OpenXmlPart part)
        {
            if (part is CustomXmlPart)
            {
                XElement PartRoot = null;
                using (var stream = part.GetStream())
                using (var reader = XmlReader.Create(stream))
                    PartRoot = XElement.Load(reader);

                if (PartRoot.Name.LocalName == "ink")
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Get All Parts of the specified package/part in depth-first pre-order.
        /// </summary>
        /// <param name="root">package or part which can contain parts.</param>
        /// <returns>IEnumerable<OpenXmlPart> of parts in the pass-in <paramref name="root"/>.</returns>
        public static IEnumerable<OpenXmlPart> DescendantParts(this OpenXmlPartContainer root)
        {
            if (null == root)
                throw new ArgumentNullException(nameof(root));

            var parts = new List<OpenXmlPart>();
            var uriList = new List<string>();

            addChildParts(parts, uriList, root);

            return parts;
        }

        private static void addChildParts(IList<OpenXmlPart> list, List<string> uriList, OpenXmlPartContainer root)
        {
            foreach (var ip in root.Parts)
            {
                if (!uriList.Contains(ip.OpenXmlPart.Uri.ToString()))
                {
                    list.Add(ip.OpenXmlPart);
                    uriList.Add(ip.OpenXmlPart.Uri.ToString());
                    addChildParts(list, uriList, ip.OpenXmlPart);
                }
            }
        }

        private static void addChildIdPartPairs(IList<IdPartPair> list, OpenXmlPartContainer root)
        {
            foreach (var idPartPair in root.Parts)
            {
                if (list.Where(i => i.RelationshipId == idPartPair.RelationshipId && object.ReferenceEquals(i.OpenXmlPart, idPartPair.OpenXmlPart)).Count() == 0)
                {
                    list.Add(idPartPair);
                    addChildIdPartPairs(list, idPartPair.OpenXmlPart);
                }
            }
        }

        /// <summary>
        /// Check if current part is reflectable (with xml content).
        /// </summary>
        /// <param name="part">Current part</param>
        /// <returns>return true if it has non-null root element, otherwise rturn false.</returns>
        public static bool IsReflectable(this OpenXmlPart part)
        {
            if (null == part)
                throw new ArgumentNullException(nameof(part));

            if (part.IsBibliographyPart() || part.IsAdditionalCharacteristicsPart() || part.IsInkPart())
            {
                return true;
            }

            var flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy;
            var property = part.GetType().GetProperties(flag)
                .Where(p => p.PropertyType.IsSubclassOf(typeof(OpenXmlPartRootElement)))
                .FirstOrDefault();
            return null != property;
        }

        /// <summary>
        /// Get RootElement of the current part.
        /// </summary>
        /// <param name="part">Current Part</param>
        /// <returns>Return Root element of the pass-in part</returns>
        public static OpenXmlPartRootElement RootElement(this OpenXmlPart part)
        {
            if (null == part)
                throw new ArgumentNullException(nameof(part));

            if (part is CustomXmlPart)
            {
                XmlDocument xmlDoc = new XmlDocument();
                using (var stream = part.GetStream())
                    xmlDoc.Load(stream);
                if (part.IsBibliographyPart())
                    return new Sources(xmlDoc.DocumentElement.OuterXml);

                else if (part.IsInkPart())
                {
                    return new DocumentFormat.OpenXml.InkML.Ink(xmlDoc.DocumentElement.OuterXml);
                }
            }

            var flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy;
            var properties = part.GetType().GetProperties(flag)
                .Where(p => p.PropertyType.IsSubclassOf(typeof(OpenXmlPartRootElement)));

            return null == properties.FirstOrDefault() ?
                null : properties.First().GetValue(part, null) as OpenXmlPartRootElement;
        }

        /// <summary>
        /// compare two OpenXmlParts
        /// </summary>
        /// <param name="sourcePart">the soruce part for comparison</param>
        /// <param name="targetPart">the target part for comparison</param>
        /// <returns>TRUE, if two parts contains the same content. FALSE, if not</returns>
        public static Boolean Compare(this OpenXmlPart sourcePart, OpenXmlPart targetPart)
        {
            HashSet<Uri> ComparedParts = new HashSet<Uri>();

            return sourcePart.CompareDescendentsAndSelf(targetPart, ComparedParts);
        }

        private static Boolean CompareDescendentsAndSelf(this OpenXmlPart sourcePart, OpenXmlPart targetPart, HashSet<Uri> ComparedPart)
        {
            #region compare content of two parts
            // if two parts have the same reference, return true;
            if (sourcePart == targetPart)
                return true;
            // if there is only one part is null, return false
            if ((targetPart == null && sourcePart != null) || (sourcePart == null && targetPart != null))
                return false;
            //if two parts have different contenttype, return false
            if (sourcePart.ContentType != targetPart.ContentType)
                return false;
            //if two parts have different number of externalrelationships, return false
            if (sourcePart.ExternalRelationships.Count() != targetPart.ExternalRelationships.Count())
                return false;
            // if two parts have different number of hyperlinkrelationships, return false
            if (sourcePart.HyperlinkRelationships.Count() != targetPart.HyperlinkRelationships.Count())
                return false;
            // if two parts have diffent relationship type, return false
            if (sourcePart.RelationshipType != targetPart.RelationshipType)
                return false;
            //// if two parts have different URI, return false
            //if (sourcePart.Uri != targetPart.Uri)
            //    return false;
            // if two parts contains different number of parts, return false;
            if (sourcePart.Parts.Count() != targetPart.Parts.Count())
                return false;
            //compare each externalrelationship
            foreach (var id in sourcePart.ExternalRelationships)
            {
                if (targetPart.ExternalRelationships.Where(i => i.Id == id.Id && i.RelationshipType == id.RelationshipType && i.Uri == id.Uri).Count() != 1)
                    return false;
            }
            //compare each hyperlinkrelationship
            foreach (var id in sourcePart.HyperlinkRelationships)
            {
                if (targetPart.HyperlinkRelationships.Where(i => i.Id == id.Id && i.IsExternal == id.IsExternal && i.Uri == id.Uri).Count() != 1)
                    return false;
            }

            if (sourcePart.RootElement == null)
            {
                // if the part is binary part, compare binary
                bool xmlCompareSuccess = false;
                using (var sourceStm = sourcePart.GetStream())
                using (var targetStm = targetPart.GetStream())
                {
                    try
                    {
                        var xsource = XElement.Load(XmlReader.Create(sourceStm));
                        var xtarget = XElement.Load(XmlReader.Create(targetStm));

                        if (xsource.Compare(xtarget) == false)
                            return false;
                        xmlCompareSuccess = true;
                    }
                    catch (XmlException)
                    {
                        xmlCompareSuccess = false;
                    }
                }
                // else need to do binary compare
                if (!xmlCompareSuccess)
                {
                    using (var sourceStm = sourcePart.GetStream())
                    using (var targetStm = targetPart.GetStream())
                    {
                        if (sourceStm.Length != targetStm.Length)
                            return false;

                        int i; int j;

                        do
                        {
                            i = sourceStm.ReadByte();
                            j = targetStm.ReadByte();
                            if (i != j) return false;
                        } while (i != -1 && j != -1);
                    }
                }
            }
            else
            {
                // if the part contains OpenXml Elements, compare their root elements
                if (sourcePart.RootElement.ToXElement().Compare(targetPart.RootElement.ToXElement()) == false)
                    return false;
            }
            #endregion

            ComparedPart.Add(sourcePart.Uri);

            foreach (var part in sourcePart.Parts)
            {
                if (!ComparedPart.Contains(part.OpenXmlPart.Uri))
                {
                    if (part.OpenXmlPart.CompareDescendentsAndSelf(targetPart.Parts.Single(p => p.RelationshipId == part.RelationshipId).OpenXmlPart, ComparedPart) == false)
                        return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Lets the given part's RootElement produce the XML string.
        /// </summary>
        /// <param name="part"></param>
        /// <returns></returns>
        public static string GetXmlString(this OpenXmlPart part)
        {
            var sb = new StringBuilder();
            using (var xw = XmlWriter.Create(sb))
            {
                if (part.RootElement != null)
                    part.RootElement.WriteTo(xw);
                else
                    sb.Append(string.Empty);
            }
            return sb.ToString();
        }
    }
}
