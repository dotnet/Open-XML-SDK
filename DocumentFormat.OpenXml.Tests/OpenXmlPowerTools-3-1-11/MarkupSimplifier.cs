/***************************************************************************

Copyright (c) Microsoft Corporation 2012-2013.

This code is licensed using the Microsoft Public License (Ms-PL).  The text of the license can be found here:

http://www.microsoft.com/resources/sharedsource/licensingbasics/publiclicense.mspx

Published at http://OpenXmlDeveloper.org
Resource Center and Documentation: http://openxmldeveloper.org/wiki/w/wiki/powertools-for-open-xml.aspx

Developer: Eric White
Blog: http://www.ericwhite.com
Twitter: @EricWhiteDev
Email: eric@ericwhite.com

Version: 2.6.00

***************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;
using System.Xml.Linq;
using DocumentFormat.OpenXml.Packaging;

namespace OpenXmlPowerTools
{
    public partial class WmlDocument : OpenXmlPowerToolsDocument
    {
        public WmlDocument SimplifyMarkup(SimplifyMarkupSettings settings)
        {
            return MarkupSimplifier.SimplifyMarkup(this, settings);
        }
    }

    public class SimplifyMarkupSettings
    {
        public bool AcceptRevisions;
        public bool RemoveContentControls;
        public bool RemoveSmartTags;
        public bool RemoveRsidInfo;
        public bool RemoveComments;
        public bool RemoveEndAndFootNotes;
        public bool ReplaceTabsWithSpaces;
        public bool RemoveFieldCodes;
        public bool RemovePermissions;
        public bool RemoveProof;
        public bool RemoveSoftHyphens;
        public bool RemoveLastRenderedPageBreak;
        public bool RemoveBookmarks;
        public bool RemoveWebHidden;
        public bool RemoveGoBackBookmark;
        public bool RemoveMarkupForDocumentComparison;
        public bool NormalizeXml;
    }

    public static class MarkupSimplifier
    {
        public static WmlDocument SimplifyMarkup(WmlDocument doc, SimplifyMarkupSettings settings)
        {
            using (OpenXmlMemoryStreamDocument streamDoc = new OpenXmlMemoryStreamDocument(doc))
            {
                using (WordprocessingDocument document = streamDoc.GetWordprocessingDocument())
                {
                    SimplifyMarkup(document, settings);
                }
                return streamDoc.GetModifiedWmlDocument();
            }
        }

        public static void SimplifyMarkup(WordprocessingDocument doc,
            SimplifyMarkupSettings settings)
        {
            if (settings.RemoveMarkupForDocumentComparison)
            {
                settings.RemoveRsidInfo = true;
                RemoveElementsForDocumentComparison(doc);
            }
            if (settings.RemoveRsidInfo)
                RemoveRsidInfoInSettings(doc);
            if (settings.AcceptRevisions)
                RevisionAccepter.AcceptRevisions(doc);
            foreach (var part in doc.ContentParts())
                SimplifyMarkupForPart(part, settings);
            if (doc.MainDocumentPart.StyleDefinitionsPart != null)
                SimplifyMarkupForPart(doc.MainDocumentPart.StyleDefinitionsPart, settings);
            if (doc.MainDocumentPart.StylesWithEffectsPart != null)
                SimplifyMarkupForPart(doc.MainDocumentPart.StylesWithEffectsPart, settings);
        }

        private static void RemoveRsidInfoInSettings(WordprocessingDocument doc)
        {
            XDocument settingsXDoc = doc.MainDocumentPart.DocumentSettingsPart.GetXDocument();
            settingsXDoc.Root.Elements(W.rsids).Remove();
            doc.MainDocumentPart.DocumentSettingsPart.PutXDocument();
        }

        private static void RemoveElementsForDocumentComparison(WordprocessingDocument doc)
        {
            XDocument appPropsXDoc = doc.ExtendedFilePropertiesPart.GetXDocument();
            appPropsXDoc.Root.Elements(EP.TotalTime).Remove();
            doc.ExtendedFilePropertiesPart.PutXDocument();

            XDocument corePropsXDoc = doc.CoreFilePropertiesPart.GetXDocument();
            corePropsXDoc.Root.Elements(CP.revision).Remove();
            corePropsXDoc.Root.Elements(DCTERMS.created).Remove();
            corePropsXDoc.Root.Elements(DCTERMS.modified).Remove();
            doc.CoreFilePropertiesPart.PutXDocument();

            XDocument mainXDoc = doc.MainDocumentPart.GetXDocument();
            var bookmarkStart = mainXDoc.Descendants(W.bookmarkStart).Where(b => (string)b.Attribute(W.name) == "_GoBack");
            foreach (var item in bookmarkStart)
            {
                var bookmarkEnd = mainXDoc.Descendants(W.bookmarkEnd).Where(be => (int)be.Attribute(W.id) == (int)item.Attribute(W.id));
                bookmarkEnd.Remove();
            }
            bookmarkStart.Remove();
            doc.MainDocumentPart.PutXDocument();
        }

        public static XElement MergeAdjacentSuperfluousRuns(XElement element)
        {
            return (XElement)MergeAdjacentRunsTransform(element);
        }

        public static XElement TransformElementToSingleCharacterRuns(XElement element)
        {
            return (XElement)SingleCharacterRunTransform(element);
        }

        public static void TransformPartToSingleCharacterRuns(OpenXmlPart part)
        {
            // After transforming to single character runs, Rsid info will be invalid, so
            // remove from the part.
            XDocument xDoc = part.GetXDocument();
            XElement newRoot = (XElement)RemoveRsidTransform(xDoc.Root);
            newRoot = (XElement)SingleCharacterRunTransform(newRoot);
            xDoc.Elements().First().ReplaceWith(newRoot);
            part.PutXDocument();
        }

        public static void TransformToSingleCharacterRuns(WordprocessingDocument doc)
        {
            if (RevisionAccepter.HasTrackedRevisions(doc))
                throw new OpenXmlPowerToolsException(
                    "Transforming a document to single character runs is not supported for " +
                    "a document with tracked revisions.");
            foreach (var part in doc.ContentParts())
                TransformPartToSingleCharacterRuns(part);
        }

        private static object RemoveCustomXmlAndContentControlsTransform(
            XNode node, SimplifyMarkupSettings simplifyMarkupSettings)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                if (simplifyMarkupSettings.RemoveSmartTags &&
                    element.Name == W.smartTag)
                    return element
                        .Elements()
                        .Select(e =>
                            RemoveCustomXmlAndContentControlsTransform(e,
                                simplifyMarkupSettings));

                if (simplifyMarkupSettings.RemoveContentControls &&
                    element.Name == W.sdt)
                    return element
                        .Element(W.sdtContent)
                        .Elements()
                        .Select(e =>
                            RemoveCustomXmlAndContentControlsTransform(e,
                                simplifyMarkupSettings));
            }
            return node;
        }

        private static object RemoveRsidTransform(XNode node)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                if (element.Name == W.rsid)
                    return null;
                return new XElement(element.Name,
                    element.Attributes().Where(a => a.Name != W.rsid &&
                        a.Name != W.rsidDel &&
                        a.Name != W.rsidP &&
                        a.Name != W.rsidR &&
                        a.Name != W.rsidRDefault &&
                        a.Name != W.rsidRPr &&
                        a.Name != W.rsidSect &&
                        a.Name != W.rsidTr),
                    element.Nodes().Select(n => RemoveRsidTransform(n)));
            }
            return node;
        }

        private static XAttribute GetXmlSpaceAttribute(
            string textElementValue)
        {
            if (textElementValue.Length > 0 &&
                (textElementValue[0] == ' ' ||
                textElementValue[textElementValue.Length - 1] == ' '))
                return new XAttribute(XNamespace.Xml + "space",
                    "preserve");
            return null;
        }

        private static object MergeAdjacentRunsTransform(XNode node)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                if (element.Name == W.p)
                {
                    XElement paragraph = element;
                    var runGroups = paragraph
                        .Elements()
                        .GroupAdjacent(r =>
                        {
                            if (r.Name != W.r)
                                return "NotRuns";
                            XElement rPr = r.Element(W.rPr);
                            if (rPr == null)
                                return "NoRunProperties";
                            return rPr.ToString(
                                SaveOptions.DisableFormatting);
                        });
                    XElement newParagraph = new XElement(W.p,
                        paragraph.Attributes(),
                        runGroups.Select(g =>
                        {
                            if (g.Key == "NotRuns")
                                return (object)g;
                            if (g.Key == "NoRunProperties")
                            {
                                XElement newRun = new XElement(W.r,
                                    g.First().Attributes(),
                                    g.Elements()
                                        .GroupAdjacent(c => c.Name)
                                        .Select(gc =>
                                        {
                                            if (gc.Key != W.t)
                                                return (object)gc;
                                            string textElementValue =
                                                gc.Select(t => (string)t)
                                                  .StringConcatenate();
                                            return new XElement(W.t,
                                                GetXmlSpaceAttribute(
                                                    textElementValue),
                                                    textElementValue);
                                        }));
                                return newRun;
                            }
                            XElement runPropertyElement = XElement.Parse(
                                g.Key);
                            runPropertyElement.Attributes()
                                .Where(a => a.IsNamespaceDeclaration)
                                .Remove();
                            XElement newRunWithProperties = new XElement(
                                W.r,
                                g.First().Attributes(),
                                runPropertyElement,
                                g.Elements()
                                    .Where(e => e.Name != W.rPr)
                                    .GroupAdjacent(c => c.Name)
                                    .Select(gc =>
                                    {
                                        if (gc.Key != W.t)
                                            return (object)gc;
                                        string textElementValue = gc
                                            .Select(t => (string)t)
                                            .StringConcatenate();
                                        return new XElement(W.t,
                                            GetXmlSpaceAttribute(
                                                textElementValue),
                                                textElementValue);
                                    }));
                            return newRunWithProperties;
                        }
                        ));
                    return newParagraph;
                }
                return new XElement(element.Name,
                    element.Attributes(),
                    element.Nodes().Select(n =>
                        MergeAdjacentRunsTransform(n)));
            }
            return node;
        }

        private static object RemoveEmptyRunsAndRunPropertiesTransform(
            XNode node)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                if ((element.Name == W.r || element.Name == W.rPr || element.Name == W.pPr) &&
                    !element.Elements().Any())
                    return null;
                return new XElement(element.Name,
                    element.Attributes(),
                    element.Nodes()
                        .Select(n =>
                            RemoveEmptyRunsAndRunPropertiesTransform(n)));
            }
            return node;
        }

        private static object MergeAdjacentInstrText(
            XNode node)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                if (element.Name == W.r && element.Elements(W.instrText).Any())
                {
                    var grouped = element.Elements().GroupAdjacent(e => e.Name == W.instrText);
                    return new XElement(W.r,
                        grouped.Select(g =>
                        {
                            if (g.Key == false) 
                                return (object)g;
                            string newInstrText = g.Select(i => (string)i).StringConcatenate();
                            return new XElement(W.instrText,
                                newInstrText[0] == ' ' || newInstrText[newInstrText.Length - 1] == ' ' ?
                                new XAttribute(XNamespace.Xml + "space", "preserve") : null,
                                newInstrText);
                        }));
                }
                return new XElement(element.Name,
                    element.Attributes(),
                    element.Nodes()
                        .Select(n =>
                            MergeAdjacentInstrText(n)));
            }
            return node;
        }

        // lastRenderedPageBreak, permEnd, permStart, proofErr, noProof
        // softHyphen:
        // Remove when simplifying.

        // fldSimple, fldData, fldChar, instrText:
        // For hyperlinks, generate same in XHtml.  Other than hyperlinks, do the following:
        // - collapse fldSimple
        // - remove fldSimple, fldData, fldChar, instrText.

        private static object SimplifyMarkupTransform(
            XNode node,
            SimplifyMarkupSettings settings,
            SimplifyMarkupParameters parameters)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                if (settings.RemovePermissions &&
                    (element.Name == W.permEnd ||
                    element.Name == W.permStart))
                    return null;

                if (settings.RemoveProof &&
                    (element.Name == W.proofErr ||
                    element.Name == W.noProof))
                    return null;

                if (settings.RemoveSoftHyphens &&
                    element.Name == W.softHyphen)
                    return null;

                if (settings.RemoveLastRenderedPageBreak &&
                    element.Name == W.lastRenderedPageBreak)
                    return null;

                if (settings.RemoveBookmarks &&
                    (element.Name == W.bookmarkStart ||
                     element.Name == W.bookmarkEnd))
                    return null;

                if (settings.RemoveGoBackBookmark &&
                    ((element.Name == W.bookmarkStart && (int)element.Attribute(W.id) == parameters.GoBackId) ||
                    (element.Name == W.bookmarkEnd && (int)element.Attribute(W.id) == parameters.GoBackId)))
                    return null;

                if (settings.RemoveWebHidden &&
                    element.Name == W.webHidden)
                    return null;

                if (settings.ReplaceTabsWithSpaces && element.Name == W.tab &&
                    element.Parent.Name == W.r)
                    return new XElement(W.t,
                        new XAttribute(XNamespace.Xml + "space", "preserve"),
                        " ");

                if (settings.RemoveComments &&
                    (element.Name == W.commentRangeStart ||
                    element.Name == W.commentRangeEnd ||
                    element.Name == W.commentReference ||
                    element.Name == W.annotationRef))
                    return null;

                if (settings.RemoveComments &&
                    element.Name == W.rStyle &&
                    element.Attribute(W.val).Value == "CommentReference")
                    return null;

                if (settings.RemoveEndAndFootNotes &&
                    (element.Name == W.endnoteReference ||
                    element.Name == W.footnoteReference))
                    return null;

                if (settings.RemoveFieldCodes)
                {
                    if (element.Name == W.fldSimple)
                        return element.Elements().Select(e =>
                            SimplifyMarkupTransform(e, settings, parameters));
                    if (element.Name == W.fldData ||
                        element.Name == W.fldChar ||
                        element.Name == W.instrText)
                        return null;
                }

                return new XElement(element.Name,
                    element.Attributes(),
                    element.Nodes().Select(n =>
                        SimplifyMarkupTransform(n, settings, parameters)));
            }
            return node;
        }

        private static class Xsi
        {
            public static XNamespace xsi = "http://www.w3.org/2001/XMLSchema-instance";

            public static XName schemaLocation = xsi + "schemaLocation";
            public static XName noNamespaceSchemaLocation = xsi + "noNamespaceSchemaLocation";
        }

        private static XDocument Normalize(XDocument source, XmlSchemaSet schema)
        {
            bool havePSVI = false;
            // validate, throw errors, add PSVI information
            if (schema != null)
            {
                source.Validate(schema, null, true);
                havePSVI = true;
            }
            return new XDocument(
                source.Declaration,
                source.Nodes().Select(n =>
                {
                    // Remove comments, processing instructions, and text nodes that are
                    // children of XDocument.  Only white space text nodes are allowed as
                    // children of a document, so we can remove all text nodes.
                    if (n is XComment || n is XProcessingInstruction || n is XText)
                        return null;
                    XElement e = n as XElement;
                    if (e != null)
                        return NormalizeElement(e, havePSVI);
                    return n;
                }
                )
            );
        }

        private static bool DeepEqualsWithNormalization(XDocument doc1, XDocument doc2,
            XmlSchemaSet schemaSet)
        {
            XDocument d1 = Normalize(doc1, schemaSet);
            XDocument d2 = Normalize(doc2, schemaSet);
            return XNode.DeepEquals(d1, d2);
        }

        private static IEnumerable<XAttribute> NormalizeAttributes(XElement element,
            bool havePSVI)
        {
            return element.Attributes()
                    .Where(a => !a.IsNamespaceDeclaration &&
                        a.Name != Xsi.schemaLocation &&
                        a.Name != Xsi.noNamespaceSchemaLocation)
                    .OrderBy(a => a.Name.NamespaceName)
                    .ThenBy(a => a.Name.LocalName)
                    .Select(
                        a =>
                        {
                            if (havePSVI)
                            {
                                var dt = a.GetSchemaInfo().SchemaType.TypeCode;
                                switch (dt)
                                {
                                    case XmlTypeCode.Boolean:
                                        return new XAttribute(a.Name, (bool)a);
                                    case XmlTypeCode.DateTime:
                                        return new XAttribute(a.Name, (DateTime)a);
                                    case XmlTypeCode.Decimal:
                                        return new XAttribute(a.Name, (decimal)a);
                                    case XmlTypeCode.Double:
                                        return new XAttribute(a.Name, (double)a);
                                    case XmlTypeCode.Float:
                                        return new XAttribute(a.Name, (float)a);
                                    case XmlTypeCode.HexBinary:
                                    case XmlTypeCode.Language:
                                        return new XAttribute(a.Name,
                                            ((string)a).ToLower());
                                }
                            }
                            return a;
                        }
                    );
        }

        private static XNode NormalizeNode(XNode node, bool havePSVI)
        {
            // trim comments and processing instructions from normalized tree
            if (node is XComment || node is XProcessingInstruction)
                return null;
            XElement e = node as XElement;
            if (e != null)
                return NormalizeElement(e, havePSVI);
            // Only thing left is XCData and XText, so clone them
            return node;
        }

        private static XElement NormalizeElement(XElement element, bool havePSVI)
        {
            if (havePSVI)
            {
                var dt = element.GetSchemaInfo();
                switch (dt.SchemaType.TypeCode)
                {
                    case XmlTypeCode.Boolean:
                        return new XElement(element.Name,
                            NormalizeAttributes(element, havePSVI),
                            (bool)element);
                    case XmlTypeCode.DateTime:
                        return new XElement(element.Name,
                            NormalizeAttributes(element, havePSVI),
                            (DateTime)element);
                    case XmlTypeCode.Decimal:
                        return new XElement(element.Name,
                            NormalizeAttributes(element, havePSVI),
                            (decimal)element);
                    case XmlTypeCode.Double:
                        return new XElement(element.Name,
                            NormalizeAttributes(element, havePSVI),
                            (double)element);
                    case XmlTypeCode.Float:
                        return new XElement(element.Name,
                            NormalizeAttributes(element, havePSVI),
                            (float)element);
                    case XmlTypeCode.HexBinary:
                    case XmlTypeCode.Language:
                        return new XElement(element.Name,
                            NormalizeAttributes(element, havePSVI),
                            ((string)element).ToLower());
                    default:
                        return new XElement(element.Name,
                            NormalizeAttributes(element, havePSVI),
                            element.Nodes().Select(n => NormalizeNode(n, havePSVI))
                        );
                }
            }
            else
            {
                return new XElement(element.Name,
                    NormalizeAttributes(element, havePSVI),
                    element.Nodes().Select(n => NormalizeNode(n, havePSVI))
                );
            }
        }

        private static void SimplifyMarkupForPart(
            OpenXmlPart part,
            SimplifyMarkupSettings settings)
        {
            SimplifyMarkupParameters parameters = new SimplifyMarkupParameters();
            if (part.ContentType == "application/vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml")
            {
                WordprocessingDocument doc = (WordprocessingDocument)part.OpenXmlPackage;
                if (settings.RemoveGoBackBookmark == true)
                {
                    var goBackBookmark = doc
                        .MainDocumentPart
                        .GetXDocument()
                        .Root
                        .Descendants(W.bookmarkStart)
                        .FirstOrDefault(bm => (string)bm.Attribute(W.name) == "_GoBack");
                    if (goBackBookmark != null)
                        parameters.GoBackId = (int)goBackBookmark.Attribute(W.id);
                }
            }

            
            XDocument xdoc = part.GetXDocument();
            XElement newRoot = xdoc.Root;

            // Need to do this first to enable simplifying hyperlinks.
            if (settings.RemoveContentControls ||
                settings.RemoveSmartTags)
                newRoot = (XElement)
                    RemoveCustomXmlAndContentControlsTransform(
                        newRoot, settings);

            // This may touch many elements, so needs to be its own
            // transform.
            if (settings.RemoveRsidInfo)
                newRoot = (XElement)RemoveRsidTransform(newRoot);

            XDocument prevNewRoot = new XDocument(newRoot);
            while (true)
            {
                if (settings.RemoveComments ||
                    settings.RemoveEndAndFootNotes ||
                    settings.ReplaceTabsWithSpaces ||
                    settings.RemoveFieldCodes ||
                    settings.RemovePermissions ||
                    settings.RemoveProof ||
                    settings.RemoveBookmarks ||
                    settings.RemoveWebHidden ||
                    settings.RemoveGoBackBookmark)
                    newRoot = (XElement)SimplifyMarkupTransform(newRoot,
                        settings, parameters);

                // Remove runs and run properties that have become empty due to previous
                // transforms.
                newRoot = (XElement)
                    RemoveEmptyRunsAndRunPropertiesTransform(newRoot);

                // Merge adjacent runs that have identical run properties.
                newRoot = (XElement)MergeAdjacentRunsTransform(newRoot);

                // Merge adjacent instrText elements.
                newRoot = (XElement)MergeAdjacentInstrText(newRoot);

                // Separate run children into separate runs
                newRoot = (XElement)SeparateRunChildrenIntoSeparateRuns(newRoot);

                if (XNode.DeepEquals(prevNewRoot.Root, newRoot))
                    break;

                prevNewRoot = new XDocument(newRoot);
            }

            if (settings.NormalizeXml)
            {
                XAttribute[] ns_attrs =
                {
                    new XAttribute(XNamespace.Xmlns + "wpc", WPC.wpc),
                    new XAttribute(XNamespace.Xmlns + "mc", MC.mc),
                    new XAttribute(XNamespace.Xmlns + "o", O.o),
                    new XAttribute(XNamespace.Xmlns + "r", R.r),
                    new XAttribute(XNamespace.Xmlns + "m", M.m),
                    new XAttribute(XNamespace.Xmlns + "v", VML.vml),
                    new XAttribute(XNamespace.Xmlns + "wp14", WP14.wp14),
                    new XAttribute(XNamespace.Xmlns + "wp", WP.wp),
                    new XAttribute(XNamespace.Xmlns + "w10", W10.w10),
                    new XAttribute(XNamespace.Xmlns + "w", W.w),
                    new XAttribute(XNamespace.Xmlns + "w14", W14.w14),
                    new XAttribute(XNamespace.Xmlns + "wpg", WPG.wpg),
                    new XAttribute(XNamespace.Xmlns + "wpi", WPI.wpi),
                    new XAttribute(XNamespace.Xmlns + "wne", WNE.wne),
                    new XAttribute(XNamespace.Xmlns + "wps", WPS.wps),
                    new XAttribute(MC.Ignorable, "w14 wp14"),
                };

                XDocument newXDoc = Normalize(new XDocument(newRoot), null);
                foreach (var nsatt in ns_attrs)
                {
                    if (newXDoc.Root.Attribute(nsatt.Name) == null)
                        newXDoc.Root.Add(nsatt);
                }
                part.PutXDocument(newXDoc);
            }
            else
            {
                part.PutXDocument(new XDocument(newRoot));
            }
        }

        private static object SeparateRunChildrenIntoSeparateRuns(XNode node)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                if (element.Name == W.r)
                {
                    var runChildren = element.Elements().Where(e => e.Name != W.rPr);
                    var rPr = element.Element(W.rPr);
                    var newRuns = runChildren.Select(rc => new XElement(W.r,
                        rPr,
                        rc));
                    return newRuns;
                }
                return new XElement(element.Name,
                    element.Attributes(),
                    element.Nodes().Select(n => SeparateRunChildrenIntoSeparateRuns(n)));
            }
            return node;
        }

        private static object SingleCharacterRunTransform(XNode node)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                if (element.Name == W.r)
                {
                    var replacementRuns = element.Elements()
                        .Where(e => e.Name != W.rPr)
                        .GroupAdjacent(sr => sr.Name == W.t)
                        .Select(g =>
                            {
                                if (g.Key)
                                {
                                    string s = g.Select(t => (string)t).StringConcatenate();
                                    var newTextRuns = s.Select(c =>
                                        new XElement(W.r,
                                            element.Elements(W.rPr),
                                            new XElement(W.t,
                                                c == ' ' ? new XAttribute(XNamespace.Xml + "space", "preserve") : null,
                                                c)));
                                    return newTextRuns;
                                }
                                var newNonTextRuns = g.Select(sr =>
                                    new XElement(W.r,
                                        element.Elements(W.rPr),
                                        new XElement(sr.Name,
                                            sr.Attributes(),
                                            sr.Nodes().Select(n => SingleCharacterRunTransform(n)))));
                                return newNonTextRuns;
                            });
                    return replacementRuns;
                }
                return new XElement(element.Name,
                    element.Attributes(),
                    element.Nodes().Select(n => SingleCharacterRunTransform(n)));
            }
            return node;
        }

        public class InternalException : Exception
        {
            public InternalException(string message) : base(message) { }
        }

        public class InvalidSettingsException : Exception
        {
            public InvalidSettingsException(string message) : base(message) { }
        }

        private class SimplifyMarkupParameters
        {
            public int? GoBackId { get; set; }
        }
    }
}
