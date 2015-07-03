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

#define TestForUnsupportedDocuments

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using DocumentFormat.OpenXml.Packaging;

namespace OpenXmlPowerTools
{
    public partial class WmlDocument : OpenXmlPowerToolsDocument
    {
        public IEnumerable<WmlDocument> SplitOnSections()
        {
            return DocumentBuilder.SplitOnSections(this);
        }
    }

    public class Source
    {
        public WmlDocument WmlDocument { get; set; }
        public int Start { get; set; }
        public int Count { get; set; }
        public bool KeepSections { get; set; }
        public string InsertId { get; set; }

        public Source(string fileName)
        {
            WmlDocument = new WmlDocument(fileName);
            Start = 0;
            Count = Int32.MaxValue;
            KeepSections = false;
            InsertId = null;
        }

        public Source(WmlDocument source)
        {
            WmlDocument = source;
            Start = 0;
            Count = Int32.MaxValue;
            KeepSections = false;
            InsertId = null;
        }

        public Source(string fileName, bool keepSections)
        {
            WmlDocument = new WmlDocument(fileName);
            Start = 0;
            Count = Int32.MaxValue;
            KeepSections = keepSections;
            InsertId = null;
        }

        public Source(WmlDocument source, bool keepSections)
        {
            WmlDocument = source;
            Start = 0;
            Count = Int32.MaxValue;
            KeepSections = keepSections;
            InsertId = null;
        }

        public Source(string fileName, string insertId)
        {
            WmlDocument = new WmlDocument(fileName);
            Start = 0;
            Count = Int32.MaxValue;
            KeepSections = false;
            InsertId = insertId;
        }

        public Source(WmlDocument source, string insertId)
        {
            WmlDocument = source;
            Start = 0;
            Count = Int32.MaxValue;
            KeepSections = false;
            InsertId = insertId;
        }

        public Source(string fileName, int start, bool keepSections)
        {
            WmlDocument = new WmlDocument(fileName);
            Start = start;
            Count = Int32.MaxValue;
            KeepSections = keepSections;
            InsertId = null;
        }

        public Source(WmlDocument source, int start, bool keepSections)
        {
            WmlDocument = source;
            Start = start;
            Count = Int32.MaxValue;
            KeepSections = keepSections;
            InsertId = null;
        }

        public Source(string fileName, int start, string insertId)
        {
            WmlDocument = new WmlDocument(fileName);
            Start = start;
            Count = Int32.MaxValue;
            KeepSections = false;
            InsertId = insertId;
        }

        public Source(WmlDocument source, int start, string insertId)
        {
            WmlDocument = source;
            Start = start;
            Count = Int32.MaxValue;
            KeepSections = false;
            InsertId = insertId;
        }

        public Source(string fileName, int start, int count, bool keepSections)
        {
            WmlDocument = new WmlDocument(fileName);
            Start = start;
            Count = count;
            KeepSections = keepSections;
            InsertId = null;
        }

        public Source(WmlDocument source, int start, int count, bool keepSections)
        {
            WmlDocument = source;
            Start = start;
            Count = count;
            KeepSections = keepSections;
            InsertId = null;
        }

        public Source(string fileName, int start, int count, string insertId)
        {
            WmlDocument = new WmlDocument(fileName);
            Start = start;
            Count = count;
            KeepSections = false;
            InsertId = insertId;
        }

        public Source(WmlDocument source, int start, int count, string insertId)
        {
            WmlDocument = source;
            Start = start;
            Count = count;
            KeepSections = false;
            InsertId = insertId;
        }
    }

    public static class DocumentBuilder
    {
        public static void BuildDocument(List<Source> sources, string fileName)
        {
            using (OpenXmlMemoryStreamDocument streamDoc = OpenXmlMemoryStreamDocument.CreateWordprocessingDocument())
            {
                using (WordprocessingDocument output = streamDoc.GetWordprocessingDocument())
                {
                    BuildDocument(sources, output);
                    output.Close();
                }
                streamDoc.GetModifiedDocument().SaveAs(fileName);
            }
        }

        public static WmlDocument BuildDocument(List<Source> sources)
        {
            using (OpenXmlMemoryStreamDocument streamDoc = OpenXmlMemoryStreamDocument.CreateWordprocessingDocument())
            {
                using (WordprocessingDocument output = streamDoc.GetWordprocessingDocument())
                {
                    BuildDocument(sources, output);
                    output.Close();
                }
                return streamDoc.GetModifiedWmlDocument();
            }
        }

        private struct TempSource
        {
            public int Start;
            public int Count;
        };

        private class Atbi
        {
            public XElement BlockLevelContent;
            public int Index;
        }

        private class Atbid
        {
            public XElement BlockLevelContent;
            public int Index;
            public int Div;
        }

        public static IEnumerable<WmlDocument> SplitOnSections(WmlDocument doc)
        {
            List<TempSource> tempSourceList;
            using (OpenXmlMemoryStreamDocument streamDoc = new OpenXmlMemoryStreamDocument(doc))
            using (WordprocessingDocument document = streamDoc.GetWordprocessingDocument())
            {
                XDocument mainDocument = document.MainDocumentPart.GetXDocument();
                var divs = mainDocument
                    .Root
                    .Element(W.body)
                    .Elements()
                    .Select((p, i) => new Atbi
                    {
                        BlockLevelContent = p,
                        Index = i,
                    })
                    .Rollup(new Atbid
                        {
                            BlockLevelContent = (XElement)null,
                            Index = -1,
                            Div = 0,
                        },
                        (b, p) =>
                        {
                            XElement elementBefore = b.BlockLevelContent
                                .SiblingsBeforeSelfReverseDocumentOrder()
                                .FirstOrDefault();
                            if (elementBefore != null && elementBefore.Descendants(W.sectPr).Any())
                                return new Atbid
                                {
                                    BlockLevelContent = b.BlockLevelContent,
                                    Index = b.Index,
                                    Div = p.Div + 1,
                                };
                            return new Atbid
                            {
                                BlockLevelContent = b.BlockLevelContent,
                                Index = b.Index,
                                Div = p.Div,
                            };
                        });
                var groups = divs
                    .GroupAdjacent(b => b.Div);
                tempSourceList = groups
                    .Select(g => new TempSource
                    {
                        Start = g.First().Index,
                        Count = g.Count(),
                    })
                    .ToList();
                foreach (var ts in tempSourceList)
                {
                    List<Source> sources = new List<Source>()
                    {
                        new Source(doc, ts.Start, ts.Count, true)
                    };
                    WmlDocument newDoc = DocumentBuilder.BuildDocument(sources);
                    newDoc = AdjustSectionBreak(newDoc);
                    yield return newDoc;
                }
            }
        }

        private static WmlDocument AdjustSectionBreak(WmlDocument doc)
        {
            using (OpenXmlMemoryStreamDocument streamDoc = new OpenXmlMemoryStreamDocument(doc))
            {
                using (WordprocessingDocument document = streamDoc.GetWordprocessingDocument())
                {
                    XDocument mainXDoc = document.MainDocumentPart.GetXDocument();
                    XElement lastElement = mainXDoc.Root
                        .Element(W.body)
                        .Elements()
                        .LastOrDefault();
                    if (lastElement != null)
                    {
                        if (lastElement.Name != W.sectPr &&
                            lastElement.Descendants(W.sectPr).Any())
                        {
                            mainXDoc.Root.Element(W.body).Add(lastElement.Descendants(W.sectPr).First());
                            lastElement.Descendants(W.sectPr).Remove();
                            if (!lastElement.Elements()
                                .Where(e => e.Name != W.pPr)
                                .Any())
                                lastElement.Remove();
                            document.MainDocumentPart.PutXDocument();
                        }
                    }
                }
                return streamDoc.GetModifiedWmlDocument();
            }
        }

        private static void BuildDocument(List<Source> sources, WordprocessingDocument output)
        {
            if (RelationshipMarkup == null)
                RelationshipMarkup = new Dictionary<XName, XName[]>()
                {
                    //{ button,           new [] { image }},
                    { A.blip,             new [] { R.embed, R.link }},
                    { A.hlinkClick,       new [] { R.id }},
                    { A.relIds,           new [] { R.cs, R.dm, R.lo, R.qs }},
                    //{ a14:imgLayer,     new [] { R.embed }},
                    //{ ax:ocx,           new [] { R.id }},
                    { C.chart,            new [] { R.id }},
                    { C.externalData,     new [] { R.id }},
                    { C.userShapes,       new [] { R.id }},
                    { DGM.relIds,         new [] { R.cs, R.dm, R.lo, R.qs }},
                    { O.OLEObject,        new [] { R.id }},
                    { VML.fill,           new [] { R.id }},
                    { VML.imagedata,      new [] { R.href, R.id, R.pict }},
                    { VML.stroke,         new [] { R.id }},
                    { W.altChunk,         new [] { R.id }},
                    { W.attachedTemplate, new [] { R.id }},
                    { W.control,          new [] { R.id }},
                    { W.dataSource,       new [] { R.id }},
                    { W.embedBold,        new [] { R.id }},
                    { W.embedBoldItalic,  new [] { R.id }},
                    { W.embedItalic,      new [] { R.id }},
                    { W.embedRegular,     new [] { R.id }},
                    { W.footerReference,  new [] { R.id }},
                    { W.headerReference,  new [] { R.id }},
                    { W.headerSource,     new [] { R.id }},
                    { W.hyperlink,        new [] { R.id }},
                    { W.printerSettings,  new [] { R.id }},
                    { W.recipientData,    new [] { R.id }},  // Mail merge, not required
                    { W.saveThroughXslt,  new [] { R.id }},
                    { W.sourceFileName,   new [] { R.id }},  // Framesets, not required
                    { W.src,              new [] { R.id }},  // Mail merge, not required
                    { W.subDoc,           new [] { R.id }},  // Sub documents, not required
                    //{ w14:contentPart,  new [] { R.id }},
                    { WNE.toolbarData,    new [] { R.id }},
                };


            // This list is used to eliminate duplicate images
            List<ImageData> images = new List<ImageData>();
            XDocument mainPart = output.MainDocumentPart.GetXDocument();
            mainPart.Declaration.Standalone = "yes";
            mainPart.Declaration.Encoding = "UTF-8";
            mainPart.Root.ReplaceWith(
                new XElement(W.document, NamespaceAttributes,
                    new XElement(W.body)));
            if (sources.Count > 0)
            {
                using (OpenXmlMemoryStreamDocument streamDoc = new OpenXmlMemoryStreamDocument(sources[0].WmlDocument))
                using (WordprocessingDocument doc = streamDoc.GetWordprocessingDocument())
                {
                    CopyStartingParts(doc, output, images);
                }

                int sourceNum = 0;
                foreach (Source source in sources)
                {
                    if (source.InsertId != null)
                    {
                        while (true)
                        {
                            XDocument mainXDoc = output.MainDocumentPart.GetXDocument();
                            if (!mainXDoc.Descendants(PtOpenXml.Insert).Any(d => (string)d.Attribute(PtOpenXml.Id) == source.InsertId))
                                break;
                            using (OpenXmlMemoryStreamDocument streamDoc = new OpenXmlMemoryStreamDocument(source.WmlDocument))
                            using (WordprocessingDocument doc = streamDoc.GetWordprocessingDocument())
                            {
#if TestForUnsupportedDocuments
                                // throws exceptions if a document contains unsupported content
                                TestForUnsupportedDocument(doc, sources.IndexOf(source));
#endif
                                List<XElement> contents = doc.MainDocumentPart.GetXDocument()
                                    .Root
                                    .Element(W.body)
                                    .Elements()
                                    .Skip(source.Start)
                                    .Take(source.Count)
                                    .ToList();
                                try
                                {
                                    AppendDocument(doc, output, contents, source.KeepSections, source.InsertId, images);
                                }
                                catch (DocumentBuilderInternalException dbie)
                                {
                                    if (dbie.Message.Contains("{0}"))
                                        throw new DocumentBuilderException(string.Format(dbie.Message, sourceNum));
                                    else
                                        throw dbie;
                                }
                            }
                        }
                    }
                    else
                    {
                        using (OpenXmlMemoryStreamDocument streamDoc = new OpenXmlMemoryStreamDocument(source.WmlDocument))
                        using (WordprocessingDocument doc = streamDoc.GetWordprocessingDocument())
                        {
#if TestForUnsupportedDocuments
                            // throws exceptions if a document contains unsupported content
                            TestForUnsupportedDocument(doc, sources.IndexOf(source));
#endif
                            List<XElement> contents = doc.MainDocumentPart.GetXDocument()
                                .Root
                                .Element(W.body)
                                .Elements()
                                .Skip(source.Start)
                                .Take(source.Count)
                                .ToList();
                            try
                            {
                                AppendDocument(doc, output, contents, source.KeepSections, null, images);
                            }
                            catch (DocumentBuilderInternalException dbie)
                            {
                                if (dbie.Message.Contains("{0}"))
                                    throw new DocumentBuilderException(string.Format(dbie.Message, sourceNum));
                                else
                                    throw dbie;
                            }
                        }
                    }
                    ++sourceNum;
                }
                if (!sources.Any(s => s.KeepSections))
                {
                    using (OpenXmlMemoryStreamDocument streamDoc = new OpenXmlMemoryStreamDocument(sources[0].WmlDocument))
                    using (WordprocessingDocument doc = streamDoc.GetWordprocessingDocument())
                    {
                        var sectPr = doc.MainDocumentPart.GetXDocument().Root.Element(W.body)
                            .Elements().Last();
                        if (sectPr.Name == W.sectPr)
                        {
                            AddSectionAndDependencies(doc, output, sectPr, images);
                            output.MainDocumentPart.GetXDocument().Root.Element(W.body).Add(sectPr);
                        }
                    }
                }
                else
                    FixUpSectionProperties(output);
            }
            foreach (var part in output.GetAllParts())
                if (part.Annotation<XDocument>() != null)
                    part.PutXDocument();
        }

        private static void TestPartForUnsupportedContent(OpenXmlPart part, int sourceNumber)
        {
            XNamespace[] obsoleteNamespaces = new[]
                {
                    XNamespace.Get("http://schemas.microsoft.com/office/word/2007/5/30/wordml"),
                    XNamespace.Get("http://schemas.microsoft.com/office/word/2008/9/16/wordprocessingDrawing"),
                    XNamespace.Get("http://schemas.microsoft.com/office/word/2009/2/wordml"),
                };
            XDocument xDoc = part.GetXDocument();
            XElement invalidElement = xDoc.Descendants()
                .FirstOrDefault(d =>
                    {
                        bool b = d.Name == W.subDoc ||
                            d.Name == W.control ||
                            d.Name == W.altChunk ||
                            d.Name.LocalName == "contentPart" ||
                            obsoleteNamespaces.Contains(d.Name.Namespace);
                        bool b2 = b ||
                            d.Attributes().Any(a => obsoleteNamespaces.Contains(a.Name.Namespace));
                        return b2;
                    });
            if (invalidElement != null)
            {
                if (invalidElement.Name == W.subDoc)
                    throw new DocumentBuilderException(String.Format("Source {0} is unsupported document - contains sub document",
                        sourceNumber));
                if (invalidElement.Name == W.control)
                    throw new DocumentBuilderException(String.Format("Source {0} is unsupported document - contains ActiveX controls",
                        sourceNumber));
                if (invalidElement.Name == W.altChunk)
                    throw new DocumentBuilderException(String.Format("Source {0} is unsupported document - contains altChunk",
                        sourceNumber));
                if (invalidElement.Name.LocalName == "contentPart")
                    throw new DocumentBuilderException(String.Format("Source {0} is unsupported document - contains contentPart content",
                        sourceNumber));
                if (obsoleteNamespaces.Contains(invalidElement.Name.Namespace) ||
                    invalidElement.Attributes().Any(a => obsoleteNamespaces.Contains(a.Name.Namespace)))
                    throw new DocumentBuilderException(String.Format("Source {0} is unsupported document - contains obsolete namespace",
                        sourceNumber));
            }
        }

        //What does not work:
        //- sub docs
        //- bidi text appears to work but has not been tested
        //- languages other than en-us appear to work but have not been tested
        //- documents with activex controls
        //- mail merge source documents (look for dataSource in settings)
        //- documents with ink
        //- documents with frame sets and frames
        private static void TestForUnsupportedDocument(WordprocessingDocument doc, int sourceNumber)
        {
            TestPartForUnsupportedContent(doc.MainDocumentPart, sourceNumber);
            foreach (var hdr in doc.MainDocumentPart.HeaderParts)
                TestPartForUnsupportedContent(hdr, sourceNumber);
            foreach (var ftr in doc.MainDocumentPart.FooterParts)
                TestPartForUnsupportedContent(ftr, sourceNumber);
            if (doc.MainDocumentPart.FootnotesPart != null)
                TestPartForUnsupportedContent(doc.MainDocumentPart.FootnotesPart, sourceNumber);
            if (doc.MainDocumentPart.EndnotesPart != null)
                TestPartForUnsupportedContent(doc.MainDocumentPart.EndnotesPart, sourceNumber);

            if (doc.MainDocumentPart.DocumentSettingsPart != null &&
                doc.MainDocumentPart.DocumentSettingsPart.GetXDocument().Descendants().Any(d => d.Name == W.src ||
                d.Name == W.recipientData || d.Name == W.mailMerge))
                throw new DocumentBuilderException(String.Format("Source {0} is unsupported document - contains Mail Merge content",
                    sourceNumber));
            if (doc.MainDocumentPart.WebSettingsPart != null &&
                doc.MainDocumentPart.WebSettingsPart.GetXDocument().Descendants().Any(d => d.Name == W.frameset))
                throw new DocumentBuilderException(String.Format("Source {0} is unsupported document - contains a frameset", sourceNumber));
            var numberingElements = doc.MainDocumentPart
                .GetXDocument()
                .Descendants(W.numPr)
                .Where(n =>
                    {
                        bool zeroId = (int?)n.Attribute(W.id) == 0;
                        bool hasChildInsId = n.Elements(W.ins).Any();
                        if (zeroId || hasChildInsId)
                            return false;
                        return true;
                    })
                .ToList();
            if (numberingElements.Any() &&
                doc.MainDocumentPart.NumberingDefinitionsPart == null)
                throw new DocumentBuilderException(String.Format(
                    "Source {0} is invalid document - contains numbering markup but no numbering part", sourceNumber));
        }

        private static void FixUpSectionProperties(WordprocessingDocument newDocument)
        {
            XDocument mainDocumentXDoc = newDocument.MainDocumentPart.GetXDocument();
            mainDocumentXDoc.Declaration.Standalone = "yes";
            mainDocumentXDoc.Declaration.Encoding = "UTF-8";
            XElement body = mainDocumentXDoc.Root.Element(W.body);
            var sectionPropertiesToMove = body
                .Elements()
                .Take(body.Elements().Count() - 1)
                .Where(e => e.Name == W.sectPr)
                .ToList();
            foreach (var s in sectionPropertiesToMove)
            {
                var p = s.SiblingsBeforeSelfReverseDocumentOrder().First();
                if (p.Element(W.pPr) == null)
                    p.AddFirst(new XElement(W.pPr));
                p.Element(W.pPr).Add(s);
            }
            foreach (var s in sectionPropertiesToMove)
                s.Remove();
        }

        private static void AddSectionAndDependencies(WordprocessingDocument sourceDocument, WordprocessingDocument newDocument,
            XElement sectionMarkup, List<ImageData> images)
        {
            var headerReferences = sectionMarkup.Descendants(W.headerReference);
            foreach (var headerReference in headerReferences)
            {
                string oldRid = headerReference.Attribute(R.id).Value;
                HeaderPart oldHeaderPart = (HeaderPart)sourceDocument.MainDocumentPart.GetPartById(oldRid);
                XDocument oldHeaderXDoc = oldHeaderPart.GetXDocument();
                if (oldHeaderXDoc != null && oldHeaderXDoc.Root != null)
                    CopyNumbering(sourceDocument, newDocument, new[] { oldHeaderXDoc.Root }, images);
                HeaderPart newHeaderPart = newDocument.MainDocumentPart.AddNewPart<HeaderPart>();
                XDocument newHeaderXDoc = newHeaderPart.GetXDocument();
                newHeaderXDoc.Declaration.Standalone = "yes";
                newHeaderXDoc.Declaration.Encoding = "UTF-8";
                newHeaderXDoc.Add(oldHeaderXDoc.Root);
                headerReference.Attribute(R.id).Value = newDocument.MainDocumentPart.GetIdOfPart(newHeaderPart);
                AddRelationships(oldHeaderPart, newHeaderPart, new[] { newHeaderXDoc.Root });
                CopyRelatedPartsForContentParts(oldHeaderPart, newHeaderPart, new[] { newHeaderXDoc.Root }, images);
            }

            var footerReferences = sectionMarkup.Descendants(W.footerReference);
            foreach (var footerReference in footerReferences)
            {
                string oldRid = footerReference.Attribute(R.id).Value;
                FooterPart oldFooterPart = (FooterPart)sourceDocument.MainDocumentPart.GetPartById(oldRid);
                XDocument oldFooterXDoc = oldFooterPart.GetXDocument();
                if (oldFooterXDoc != null && oldFooterXDoc.Root != null)
                    CopyNumbering(sourceDocument, newDocument, new[] { oldFooterXDoc.Root }, images);
                FooterPart newFooterPart = newDocument.MainDocumentPart.AddNewPart<FooterPart>();
                XDocument newFooterXDoc = newFooterPart.GetXDocument();
                newFooterXDoc.Declaration.Standalone = "yes";
                newFooterXDoc.Declaration.Encoding = "UTF-8";
                newFooterXDoc.Add(oldFooterXDoc.Root);
                footerReference.Attribute(R.id).Value = newDocument.MainDocumentPart.GetIdOfPart(newFooterPart);
                AddRelationships(oldFooterPart, newFooterPart, new[] { newFooterXDoc.Root });
                CopyRelatedPartsForContentParts(oldFooterPart, newFooterPart, new[] { newFooterXDoc.Root }, images);
            }
        }

        private static void MergeStyles(WordprocessingDocument sourceDocument, WordprocessingDocument newDocument,
            XDocument fromStyles, XDocument toStyles)
        {
            foreach (XElement style in fromStyles.Root.Elements(W.style))
            {
                string name = style.Attribute(W.styleId).Value;
                if (toStyles
                    .Root
                    .Elements(W.style)
                    .Where(o => o.Attribute(W.styleId).Value == name)
                    .Count() == 0)
                {
                    int number = 1;
                    int abstractNumber = 0;
                    XDocument oldNumbering = null;
                    XDocument newNumbering = null;
                    foreach (XElement numReference in style.Descendants(W.numPr))
                    {
                        XElement idElement = numReference.Descendants(W.numId).FirstOrDefault();
                        if (idElement != null)
                        {
                            if (oldNumbering == null)
                                oldNumbering = sourceDocument.MainDocumentPart.NumberingDefinitionsPart.GetXDocument();
                            if (newNumbering == null)
                            {
                                if (newDocument.MainDocumentPart.NumberingDefinitionsPart != null)
                                {
                                    newNumbering = newDocument.MainDocumentPart.NumberingDefinitionsPart.GetXDocument();
                                    newNumbering.Declaration.Standalone = "yes";
                                    newNumbering.Declaration.Encoding = "UTF-8";
                                    var numIds = newNumbering
                                        .Root
                                        .Elements(W.num)
                                        .Select(f => (int)f.Attribute(W.numId));
                                    if (numIds.Any())
                                        number = numIds.Max() + 1;
                                    numIds = newNumbering
                                        .Root
                                        .Elements(W.abstractNum)
                                        .Select(f => (int)f.Attribute(W.abstractNumId));
                                    if (numIds.Any())
                                        abstractNumber = numIds.Max() + 1;
                                }
                                else
                                {
                                    newDocument.MainDocumentPart.AddNewPart<NumberingDefinitionsPart>();
                                    newNumbering = newDocument.MainDocumentPart.NumberingDefinitionsPart.GetXDocument();
                                    newNumbering.Declaration.Standalone = "yes";
                                    newNumbering.Declaration.Encoding = "UTF-8";
                                    newNumbering.Add(new XElement(W.numbering, NamespaceAttributes));
                                }
                            }
                            string numId = idElement.Attribute(W.val).Value;
                            if (numId != "0")
                            {
                                XElement element = oldNumbering
                                    .Descendants()
                                    .Elements(W.num)
                                    .Where(p => ((string)p.Attribute(W.numId)) == numId)
                                    .FirstOrDefault();

                                // Copy abstract numbering element, if necessary (use matching NSID)
                                string abstractNumId = string.Empty;
                                if (element != null)
                                {
                                    abstractNumId = element
                                       .Elements(W.abstractNumId)
                                       .First()
                                       .Attribute(W.val)
                                       .Value;

                                    XElement abstractElement = oldNumbering
                                        .Descendants()
                                        .Elements(W.abstractNum)
                                        .Where(p => ((string)p.Attribute(W.abstractNumId)) == abstractNumId)
                                        .FirstOrDefault();
                                    string abstractNSID = string.Empty;
                                    if (abstractElement != null)
                                    {
                                        abstractNSID = abstractElement
                                         .Elements(W.nsid)
                                         .First()
                                         .Attribute(W.val)
                                         .Value;

                                        XElement newAbstractElement = newNumbering
                                            .Descendants()
                                            .Elements(W.abstractNum)
                                            .Where(p => ((string)p.Elements(W.nsid).First().Attribute(W.val)) == abstractNSID)
                                            .FirstOrDefault();
                                        if (newAbstractElement == null)
                                        {
                                            newAbstractElement = new XElement(abstractElement);
                                            newAbstractElement.Attribute(W.abstractNumId).Value = abstractNumber.ToString();
                                            abstractNumber++;
                                            if (newNumbering.Root.Elements(W.abstractNum).Any())
                                                newNumbering.Root.Elements(W.abstractNum).Last().AddAfterSelf(newAbstractElement);
                                            else
                                                newNumbering.Root.Add(newAbstractElement);

                                            foreach (XElement pictId in newAbstractElement.Descendants(W.lvlPicBulletId))
                                            {
                                                string bulletId = (string)pictId.Attribute(W.val);
                                                XElement numPicBullet = oldNumbering
                                                    .Descendants(W.numPicBullet)
                                                    .FirstOrDefault(d => (string)d.Attribute(W.numPicBulletId) == bulletId);
                                                int maxNumPicBulletId = new int[] { -1 }.Concat(
                                                    newNumbering.Descendants(W.numPicBullet)
                                                    .Attributes(W.numPicBulletId)
                                                    .Select(a => (int)a))
                                                    .Max() + 1;
                                                XElement newNumPicBullet = new XElement(numPicBullet);
                                                newNumPicBullet.Attribute(W.numPicBulletId).Value = maxNumPicBulletId.ToString();
                                                pictId.Attribute(W.val).Value = maxNumPicBulletId.ToString();
                                                newNumbering.Root.AddFirst(newNumPicBullet);
                                            }
                                        }
                                        string newAbstractId = newAbstractElement.Attribute(W.abstractNumId).Value;

                                        // Copy numbering element, if necessary (use matching element with no overrides)
                                        XElement newElement = null;
                                        if (!element.Elements(W.lvlOverride).Any())
                                            newElement = newNumbering
                                                .Descendants()
                                                .Elements(W.num)
                                                .Where(p => !p.Elements(W.lvlOverride).Any() &&
                                                    ((string)p.Elements(W.abstractNumId).First().Attribute(W.val)) == newAbstractId)
                                                .FirstOrDefault();
                                        if (newElement == null)
                                        {
                                            newElement = new XElement(element);
                                            newElement
                                                .Elements(W.abstractNumId)
                                                .First()
                                                .Attribute(W.val).Value = newAbstractId;
                                            newElement.Attribute(W.numId).Value = number.ToString();
                                            number++;
                                            newNumbering.Root.Add(newElement);
                                        }
                                        idElement.Attribute(W.val).Value = newElement.Attribute(W.numId).Value;
                                    }
                                }
                            }
                        }
                    }

                    var newStyle = new XElement(style);
                    // get rid of anything not in the w: namespace
                    newStyle.Descendants().Where(d => d.Name.NamespaceName != W.w).Remove();
                    newStyle.Descendants().Attributes().Where(d => d.Name.NamespaceName != W.w).Remove();
                    toStyles.Root.Add(newStyle);
                }
            }
        }

        private static void MergeFontTables(XDocument fromFontTable, XDocument toFontTable)
        {
            foreach (XElement font in fromFontTable.Root.Elements(W.font))
            {
                string name = font.Attribute(W.name).Value;
                if (toFontTable
                    .Root
                    .Elements(W.font)
                    .Where(o => o.Attribute(W.name).Value == name)
                    .Count() == 0)
                    toFontTable.Root.Add(new XElement(font));
            }
        }

        private static void CopyStylesAndFonts(WordprocessingDocument sourceDocument, WordprocessingDocument newDocument,
            IEnumerable<XElement> newContent)
        {
            // Copy all styles to the new document
            if (sourceDocument.MainDocumentPart.StyleDefinitionsPart != null)
            {
                XDocument oldStyles = sourceDocument.MainDocumentPart.StyleDefinitionsPart.GetXDocument();
                if (newDocument.MainDocumentPart.StyleDefinitionsPart == null)
                {
                    newDocument.MainDocumentPart.AddNewPart<StyleDefinitionsPart>();
                    XDocument newStyles = newDocument.MainDocumentPart.StyleDefinitionsPart.GetXDocument();
                    newStyles.Declaration.Standalone = "yes";
                    newStyles.Declaration.Encoding = "UTF-8";
                    newStyles.Add(oldStyles.Root);
                }
                else
                {
                    XDocument newStyles = newDocument.MainDocumentPart.StyleDefinitionsPart.GetXDocument();
                    MergeStyles(sourceDocument, newDocument, oldStyles, newStyles);
                }
            }

            // Copy all styles with effects to the new document
            if (sourceDocument.MainDocumentPart.StylesWithEffectsPart != null)
            {
                XDocument oldStyles = sourceDocument.MainDocumentPart.StylesWithEffectsPart.GetXDocument();
                if (newDocument.MainDocumentPart.StylesWithEffectsPart == null)
                {
                    newDocument.MainDocumentPart.AddNewPart<StylesWithEffectsPart>();
                    XDocument newStyles = newDocument.MainDocumentPart.StylesWithEffectsPart.GetXDocument();
                    newStyles.Declaration.Standalone = "yes";
                    newStyles.Declaration.Encoding = "UTF-8";
                    newStyles.Add(oldStyles.Root);
                }
                else
                {
                    XDocument newStyles = newDocument.MainDocumentPart.StylesWithEffectsPart.GetXDocument();
                    MergeStyles(sourceDocument, newDocument, oldStyles, newStyles);
                }
            }

            // Copy fontTable to the new document
            if (sourceDocument.MainDocumentPart.FontTablePart != null)
            {
                XDocument oldFontTable = sourceDocument.MainDocumentPart.FontTablePart.GetXDocument();
                if (newDocument.MainDocumentPart.FontTablePart == null)
                {
                    newDocument.MainDocumentPart.AddNewPart<FontTablePart>();
                    XDocument newFontTable = newDocument.MainDocumentPart.FontTablePart.GetXDocument();
                    newFontTable.Declaration.Standalone = "yes";
                    newFontTable.Declaration.Encoding = "UTF-8";
                    newFontTable.Add(oldFontTable.Root);
                }
                else
                {
                    XDocument newFontTable = newDocument.MainDocumentPart.FontTablePart.GetXDocument();
                    MergeFontTables(oldFontTable, newFontTable);
                }
            }
        }

        private static void CopyComments(WordprocessingDocument sourceDocument, WordprocessingDocument newDocument,
            IEnumerable<XElement> newContent, List<ImageData> images)
        {
            Dictionary<int, int> commentIdMap = new Dictionary<int, int>();
            int number = 0;
            XDocument oldComments = null;
            XDocument newComments = null;
            foreach (XElement comment in newContent.DescendantsAndSelf(W.commentReference))
            {
                if (oldComments == null)
                    oldComments = sourceDocument.MainDocumentPart.WordprocessingCommentsPart.GetXDocument();
                if (newComments == null)
                {
                    if (newDocument.MainDocumentPart.WordprocessingCommentsPart != null)
                    {
                        newComments = newDocument.MainDocumentPart.WordprocessingCommentsPart.GetXDocument();
                        newComments.Declaration.Standalone = "yes";
                        newComments.Declaration.Encoding = "UTF-8";
                        var ids = newComments.Root.Elements(W.comment).Select(f => (int)f.Attribute(W.id));
                        if (ids.Any())
                            number = ids.Max() + 1;
                    }
                    else
                    {
                        newDocument.MainDocumentPart.AddNewPart<WordprocessingCommentsPart>();
                        newComments = newDocument.MainDocumentPart.WordprocessingCommentsPart.GetXDocument();
                        newComments.Declaration.Standalone = "yes";
                        newComments.Declaration.Encoding = "UTF-8";
                        newComments.Add(new XElement(W.comments, NamespaceAttributes));
                    }
                }
                int id = (int)comment.Attribute(W.id);
                XElement element = oldComments
                    .Descendants()
                    .Elements(W.comment)
                    .Where(p => ((int)p.Attribute(W.id)) == id)
                    .First();
                XElement newElement = new XElement(element);
                newElement.Attribute(W.id).Value = number.ToString();
                newComments.Root.Add(newElement);
                commentIdMap.Add(id, number);
                number++;
            }
            foreach (var item in newContent.DescendantsAndSelf()
                .Where(d => d.Name == W.commentReference ||
                            d.Name == W.commentRangeStart ||
                            d.Name == W.commentRangeEnd))
                item.Attribute(W.id).Value = commentIdMap[(int)item.Attribute(W.id)].ToString();
            if (sourceDocument.MainDocumentPart.WordprocessingCommentsPart != null &&
                newDocument.MainDocumentPart.WordprocessingCommentsPart != null)
            {
                AddRelationships(sourceDocument.MainDocumentPart.WordprocessingCommentsPart,
                    newDocument.MainDocumentPart.WordprocessingCommentsPart,
                    new[] { newDocument.MainDocumentPart.WordprocessingCommentsPart.GetXDocument().Root });
                CopyRelatedPartsForContentParts(sourceDocument.MainDocumentPart.WordprocessingCommentsPart,
                    newDocument.MainDocumentPart.WordprocessingCommentsPart,
                    new[] { newDocument.MainDocumentPart.WordprocessingCommentsPart.GetXDocument().Root },
                    images);
            }
        }

        private static void AdjustUniqueIds(WordprocessingDocument sourceDocument,
            WordprocessingDocument newDocument, IEnumerable<XElement> newContent)
        {
            // adjust bookmark unique ids
            int maxId = 0;
            if (newDocument.MainDocumentPart.GetXDocument().Descendants(W.bookmarkStart).Any())
                maxId = newDocument.MainDocumentPart.GetXDocument().Descendants(W.bookmarkStart)
                    .Select(d => (int)d.Attribute(W.id)).Max();
            Dictionary<int, int> bookmarkIdMap = new Dictionary<int, int>();
            foreach (var item in newContent.DescendantsAndSelf().Where(bm => bm.Name == W.bookmarkStart ||
                bm.Name == W.bookmarkEnd))
            {
                int id = (int)item.Attribute(W.id);
                if (!bookmarkIdMap.ContainsKey(id))
                    bookmarkIdMap.Add(id, ++maxId);
            }
            foreach (var bookmarkElement in newContent.DescendantsAndSelf().Where(e => e.Name == W.bookmarkStart ||
                e.Name == W.bookmarkEnd))
                bookmarkElement.Attribute(W.id).Value = bookmarkIdMap[(int)bookmarkElement.Attribute(W.id)].ToString();

            // adjust shape unique ids
            // This doesn't work because OLEObjects refer to shapes by ID.
            // Punting on this, because sooner or later, this will be a non-issue.
            //foreach (var item in newContent.DescendantsAndSelf(VML.shape))
            //{
            //    Guid g = Guid.NewGuid();
            //    string s = "R" + g.ToString().Replace("-", "");
            //    item.Attribute(NoNamespace.id).Value = s;
            //}
        }

        private static void AdjustDocPrIds(WordprocessingDocument newDocument)
        {
            int docPrId = 0;
            foreach (var item in newDocument.MainDocumentPart.GetXDocument().Descendants(WP.docPr))
                item.Attribute(NoNamespace.id).Value = (++docPrId).ToString();
            foreach (var header in newDocument.MainDocumentPart.HeaderParts)
                foreach (var item in header.GetXDocument().Descendants(WP.docPr))
                    item.Attribute(NoNamespace.id).Value = (++docPrId).ToString();
            foreach (var footer in newDocument.MainDocumentPart.FooterParts)
                foreach (var item in footer.GetXDocument().Descendants(WP.docPr))
                    item.Attribute(NoNamespace.id).Value = (++docPrId).ToString();
            if (newDocument.MainDocumentPart.FootnotesPart != null)
                foreach (var item in newDocument.MainDocumentPart.FootnotesPart.GetXDocument().Descendants(WP.docPr))
                    item.Attribute(NoNamespace.id).Value = (++docPrId).ToString();
            if (newDocument.MainDocumentPart.EndnotesPart != null)
                foreach (var item in newDocument.MainDocumentPart.EndnotesPart.GetXDocument().Descendants(WP.docPr))
                    item.Attribute(NoNamespace.id).Value = (++docPrId).ToString();
        }

        // This probably doesn't need to be done, except that the Open XML SDK will not validate
        // documents that contain the o:gfxdata attribute.
        private static void RemoveGfxdata(IEnumerable<XElement> newContent)
        {
            newContent.DescendantsAndSelf().Attributes(O.gfxdata).Remove();
        }

        private static object InsertTransform(XNode node, List<XElement> newContent)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                if (element.Annotation<ReplaceSemaphore>() != null)
                    return newContent;
                return new XElement(element.Name,
                    element.Attributes(),
                    element.Nodes().Select(n => InsertTransform(n, newContent)));
            }
            return node;
        }

        private class ReplaceSemaphore { }

        // Rules for sections
        // - if KeepSections for all documents in the source collection are false, then it takes the section
        //   from the first document.
        // - if you specify true for any document, and if the last section is part of the specified content,
        //   then that section is copied.  If any paragraph in the content has a section, then that section
        //   is copied.
        // - if you specify true for any document, and there are no sections for any paragraphs, then no
        //   sections are copied.
        private static void AppendDocument(WordprocessingDocument sourceDocument, WordprocessingDocument newDocument,
            List<XElement> newContent, bool keepSection, string insertId, List<ImageData> images)
        {
            FixRanges(sourceDocument.MainDocumentPart.GetXDocument(), newContent);
            AddRelationships(sourceDocument.MainDocumentPart, newDocument.MainDocumentPart, newContent);
            CopyRelatedPartsForContentParts(sourceDocument.MainDocumentPart, newDocument.MainDocumentPart,
                newContent, images);

            // Append contents
            XDocument newMainXDoc = newDocument.MainDocumentPart.GetXDocument();
            newMainXDoc.Declaration.Standalone = "yes";
            newMainXDoc.Declaration.Encoding = "UTF-8";
            if (keepSection == false)
            {
                List<XElement> adjustedContents = newContent.Where(e => e.Name != W.sectPr).ToList();
                adjustedContents.DescendantsAndSelf(W.sectPr).Remove();
                newContent = adjustedContents;
            }
            foreach (var sectPr in newContent.DescendantsAndSelf(W.sectPr))
                AddSectionAndDependencies(sourceDocument, newDocument, sectPr, images);
            CopyStylesAndFonts(sourceDocument, newDocument, newContent);
            CopyNumbering(sourceDocument, newDocument, newContent, images);
            CopyComments(sourceDocument, newDocument, newContent, images);
            CopyFootnotes(sourceDocument, newDocument, newContent, images);
            CopyEndnotes(sourceDocument, newDocument, newContent, images);
            AdjustUniqueIds(sourceDocument, newDocument, newContent);
            RemoveGfxdata(newContent);
            CopyCustomXml(sourceDocument, newDocument, newContent);
            if (insertId != null)
            {
                XElement insertElementToReplace = newMainXDoc
                    .Descendants(PtOpenXml.Insert)
                    .FirstOrDefault(i => (string)i.Attribute(PtOpenXml.Id) == insertId);
                if (insertElementToReplace != null)
                    insertElementToReplace.AddAnnotation(new ReplaceSemaphore());
                newMainXDoc.Element(W.document).ReplaceWith((XElement)InsertTransform(newMainXDoc.Root, newContent));
            }
            else
                newMainXDoc.Root.Element(W.body).Add(newContent);
            AdjustDocPrIds(newDocument);
        }

        private static void CopyCustomXml(WordprocessingDocument sourceDocument, WordprocessingDocument newDocument,
            IEnumerable<XElement> newContent)
        {
            List<string> itemList = new List<string>();
            foreach (string itemId in newContent
                .Descendants(W.dataBinding)
                .Select(e => e.Attribute(W.storeItemID).Value))
                if (!itemList.Contains(itemId))
                    itemList.Add(itemId);
            foreach (CustomXmlPart customXmlPart in sourceDocument.MainDocumentPart.CustomXmlParts)
            {
                OpenXmlPart propertyPart = customXmlPart
                    .Parts
                    .Select(p => p.OpenXmlPart)
                    .Where(p => p.ContentType == "application/vnd.openxmlformats-officedocument.customXmlProperties+xml")
                    .First();
                XDocument propertyPartDoc = propertyPart.GetXDocument();
                if (itemList.Contains(propertyPartDoc.Root.Attribute(DS.itemID).Value))
                {
                    CustomXmlPart newPart = newDocument.MainDocumentPart.AddCustomXmlPart(customXmlPart.ContentType);
                    newPart.GetXDocument().Add(customXmlPart.GetXDocument().Root);
                    foreach (OpenXmlPart propPart in customXmlPart.Parts.Select(p => p.OpenXmlPart))
                    {
                        CustomXmlPropertiesPart newPropPart = newPart.AddNewPart<CustomXmlPropertiesPart>();
                        newPropPart.GetXDocument().Add(propPart.GetXDocument().Root);
                    }
                }
            }
        }

        private static Dictionary<XName, XName[]> RelationshipMarkup = null;

        private static void UpdateContent(IEnumerable<XElement> newContent, XName elementToModify, string oldRid, string newRid)
        {
            foreach (var attributeName in RelationshipMarkup[elementToModify])
            {
                var elementsToUpdate = newContent
                    .Descendants(elementToModify)
                    .Where(e => (string)e.Attribute(attributeName) == oldRid);
                foreach (var element in elementsToUpdate)
                    element.Attribute(attributeName).Value = newRid;
            }
        }

        private static void AddRelationships(OpenXmlPart oldPart, OpenXmlPart newPart, IEnumerable<XElement> newContent)
        {
            var relevantElements = newContent.DescendantsAndSelf()
                .Where(d => RelationshipMarkup.ContainsKey(d.Name) &&
                    d.Attributes().Any(a => RelationshipMarkup[d.Name].Contains(a.Name)))
                .ToList();
            foreach (var e in relevantElements)
            {
                if (e.Name == W.hyperlink)
                {
                    string relId = (string)e.Attribute(R.id);
                    if (string.IsNullOrEmpty(relId))
                        continue;
                    var tempHyperlink = newPart.HyperlinkRelationships.FirstOrDefault(h => h.Id == relId);
                    if (tempHyperlink != null)
                        continue;
                    Guid g = Guid.NewGuid();
                    string newRid = "R" + g.ToString().Replace("-", "");
                    var oldHyperlink = oldPart.HyperlinkRelationships.FirstOrDefault(h => h.Id == relId);
                    if (oldHyperlink == null)
                        continue;
                    //throw new DocumentBuilderInternalException("Internal Error 0002");
                    newPart.AddHyperlinkRelationship(oldHyperlink.Uri, oldHyperlink.IsExternal, newRid);
                    UpdateContent(newContent, e.Name, relId, newRid);
                }
                if (e.Name == W.attachedTemplate || e.Name == W.saveThroughXslt)
                {
                    string relId = (string)e.Attribute(R.id);
                    if (string.IsNullOrEmpty(relId))
                        continue;
                    var tempExternalRelationship = newPart.ExternalRelationships.FirstOrDefault(h => h.Id == relId);
                    if (tempExternalRelationship != null)
                        continue;
                    Guid g = Guid.NewGuid();
                    string newRid = "R" + g.ToString().Replace("-", "");
                    var oldRel = oldPart.ExternalRelationships.FirstOrDefault(h => h.Id == relId);
                    if (oldRel == null)
                        throw new DocumentBuilderInternalException("Source {0} is invalid document - hyperlink contains invalid references");
                    newPart.AddExternalRelationship(oldRel.RelationshipType, oldRel.Uri, newRid);
                    UpdateContent(newContent, e.Name, relId, newRid);
                }
                if (e.Name == A.hlinkClick || e.Name == A.hlinkHover || e.Name == A.hlinkMouseOver)
                {
                    string relId = (string)e.Attribute(R.id);
                    if (string.IsNullOrEmpty(relId))
                        continue;
                    var tempHyperlink = newPart.HyperlinkRelationships.FirstOrDefault(h => h.Id == relId);
                    if (tempHyperlink != null)
                        continue;
                    Guid g = Guid.NewGuid();
                    string newRid = "R" + g.ToString().Replace("-", "");
                    var oldHyperlink = oldPart.HyperlinkRelationships.FirstOrDefault(h => h.Id == relId);
                    if (oldHyperlink == null)
                        continue;
                    newPart.AddHyperlinkRelationship(oldHyperlink.Uri, oldHyperlink.IsExternal, newRid);
                    UpdateContent(newContent, e.Name, relId, newRid);
                }
                if (e.Name == VML.imagedata)
                {
                    string relId = (string)e.Attribute(R.href);
                    if (string.IsNullOrEmpty(relId))
                        continue;
                    var tempExternalRelationship = newPart.ExternalRelationships.FirstOrDefault(h => h.Id == relId);
                    if (tempExternalRelationship != null)
                        continue;
                    Guid g = Guid.NewGuid();
                    string newRid = "R" + g.ToString().Replace("-", "");
                    var oldRel = oldPart.ExternalRelationships.FirstOrDefault(h => h.Id == relId);
                    if (oldRel == null)
                        throw new DocumentBuilderInternalException("Internal Error 0006");
                    newPart.AddExternalRelationship(oldRel.RelationshipType, oldRel.Uri, newRid);
                    UpdateContent(newContent, e.Name, relId, newRid);
                }
                if (e.Name == A.blip)
                {
                    string relId = (string)e.Attribute(R.link);
                    if (string.IsNullOrEmpty(relId))
                        continue;
                    var tempExternalRelationship = newPart.ExternalRelationships.FirstOrDefault(h => h.Id == relId);
                    if (tempExternalRelationship != null)
                        continue;
                    Guid g = Guid.NewGuid();
                    string newRid = "R" + g.ToString().Replace("-", "");
                    var oldRel = oldPart.ExternalRelationships.FirstOrDefault(h => h.Id == relId);
                    if (oldRel == null)
                        continue;
                    newPart.AddExternalRelationship(oldRel.RelationshipType, oldRel.Uri, newRid);
                    UpdateContent(newContent, e.Name, relId, newRid);
                }
            }
        }

        private class FromPreviousSourceSemaphore { };

        private static void CopyNumbering(WordprocessingDocument sourceDocument, WordprocessingDocument newDocument,
            IEnumerable<XElement> newContent, List<ImageData> images)
        {
            // Note that this does not need to use a map as CopyComments method does, as it needs to update only
            // a single attribute value.  The problem in the CopyComments method is that there are multiple elements
            // for which we need to update attribute values.  Searching for those elements in the paragraphs collection
            // causes the problem that must be solved by first creating a map, and then wholesale updating all
            // attributes appropriately using the map.
            int number = 1;
            int abstractNumber = 0;
            XDocument oldNumbering = null;
            XDocument newNumbering = null;

            foreach (XElement numReference in newContent.DescendantsAndSelf(W.numPr))
            {
                XElement idElement = numReference.Descendants(W.numId).FirstOrDefault();
                if (idElement != null)
                {
                    if (oldNumbering == null)
                        oldNumbering = sourceDocument.MainDocumentPart.NumberingDefinitionsPart.GetXDocument();
                    if (newNumbering == null)
                    {
                        if (newDocument.MainDocumentPart.NumberingDefinitionsPart != null)
                        {
                            newNumbering = newDocument.MainDocumentPart.NumberingDefinitionsPart.GetXDocument();
                            var numIds = newNumbering
                                .Root
                                .Elements(W.num)
                                .Select(f => (int)f.Attribute(W.numId));
                            if (numIds.Any())
                                number = numIds.Max() + 1;
                            numIds = newNumbering
                                .Root
                                .Elements(W.abstractNum)
                                .Select(f => (int)f.Attribute(W.abstractNumId));
                            if (numIds.Any())
                                abstractNumber = numIds.Max() + 1;
                        }
                        else
                        {
                            newDocument.MainDocumentPart.AddNewPart<NumberingDefinitionsPart>();
                            newNumbering = newDocument.MainDocumentPart.NumberingDefinitionsPart.GetXDocument();
                            newNumbering.Declaration.Standalone = "yes";
                            newNumbering.Declaration.Encoding = "UTF-8";
                            newNumbering.Add(new XElement(W.numbering, NamespaceAttributes));
                        }
                    }
                    string numId = idElement.Attribute(W.val).Value;
                    if (numId != "0")
                    {
                        XElement element = oldNumbering
                            .Descendants(W.num)
                            .Where(p => ((string)p.Attribute(W.numId)) == numId)
                            .FirstOrDefault();
                        if (element == null)
                            continue;

                        // Copy abstract numbering element, if necessary (use matching NSID)
                        string abstractNumId = element
                            .Elements(W.abstractNumId)
                            .First()
                            .Attribute(W.val)
                            .Value;
                        XElement abstractElement = oldNumbering
                            .Descendants()
                            .Elements(W.abstractNum)
                            .Where(p => ((string)p.Attribute(W.abstractNumId)) == abstractNumId)
                            .First();
                        string abstractNSID = abstractElement
                            .Elements(W.nsid)
                            .First()
                            .Attribute(W.val)
                            .Value;
                        XElement newAbstractElement = newNumbering
                            .Descendants()
                            .Elements(W.abstractNum)
                            .Where(e => e.Annotation<FromPreviousSourceSemaphore>() == null)
                            .Where(p => ((string)p.Elements(W.nsid).First().Attribute(W.val)) == abstractNSID)
                            .FirstOrDefault();
                        if (newAbstractElement == null)
                        {
                            newAbstractElement = new XElement(abstractElement);
                            newAbstractElement.Attribute(W.abstractNumId).Value = abstractNumber.ToString();
                            abstractNumber++;
                            if (newNumbering.Root.Elements(W.abstractNum).Any())
                                newNumbering.Root.Elements(W.abstractNum).Last().AddAfterSelf(newAbstractElement);
                            else
                                newNumbering.Root.Add(newAbstractElement);

                            foreach (XElement pictId in newAbstractElement.Descendants(W.lvlPicBulletId))
                            {
                                string bulletId = (string)pictId.Attribute(W.val);
                                XElement numPicBullet = oldNumbering
                                    .Descendants(W.numPicBullet)
                                    .FirstOrDefault(d => (string)d.Attribute(W.numPicBulletId) == bulletId);
                                int maxNumPicBulletId = new int[] { -1 }.Concat(
                                    newNumbering.Descendants(W.numPicBullet)
                                    .Attributes(W.numPicBulletId)
                                    .Select(a => (int)a))
                                    .Max() + 1;
                                XElement newNumPicBullet = new XElement(numPicBullet);
                                newNumPicBullet.Attribute(W.numPicBulletId).Value = maxNumPicBulletId.ToString();
                                pictId.Attribute(W.val).Value = maxNumPicBulletId.ToString();
                                newNumbering.Root.AddFirst(newNumPicBullet);
                            }
                        }
                        string newAbstractId = newAbstractElement.Attribute(W.abstractNumId).Value;

                        // Copy numbering element, if necessary (use matching element with no overrides)
                        XElement newElement = newNumbering
                                .Descendants()
                                .Elements(W.num)
                                .Where(e => e.Annotation<FromPreviousSourceSemaphore>() == null)
                                .Where(p => ((string)p.Elements(W.abstractNumId).First().Attribute(W.val)) == newAbstractId)
                                .FirstOrDefault();
                        if (newElement == null)
                        {
                            newElement = new XElement(element);
                            newElement
                                .Elements(W.abstractNumId)
                                .First()
                                .Attribute(W.val).Value = newAbstractId;
                            newElement.Attribute(W.numId).Value = number.ToString();
                            number++;
                            newNumbering.Root.Add(newElement);
                        }
                        idElement.Attribute(W.val).Value = newElement.Attribute(W.numId).Value;
                    }
                }
            }
            if (newNumbering != null)
            {
                foreach (var abstractNum in newNumbering.Descendants(W.abstractNum))
                    abstractNum.AddAnnotation(new FromPreviousSourceSemaphore());
                foreach (var num in newNumbering.Descendants(W.num))
                    num.AddAnnotation(new FromPreviousSourceSemaphore());
            }

            if (newDocument.MainDocumentPart.NumberingDefinitionsPart != null &&
                sourceDocument.MainDocumentPart.NumberingDefinitionsPart != null)
            {
                AddRelationships(sourceDocument.MainDocumentPart.NumberingDefinitionsPart,
                    newDocument.MainDocumentPart.NumberingDefinitionsPart,
                    new[] { newDocument.MainDocumentPart.NumberingDefinitionsPart.GetXDocument().Root });
                CopyRelatedPartsForContentParts(sourceDocument.MainDocumentPart.NumberingDefinitionsPart,
                    newDocument.MainDocumentPart.NumberingDefinitionsPart,
                    new[] { newDocument.MainDocumentPart.NumberingDefinitionsPart.GetXDocument().Root }, images);
            }
        }

        private static void CopyRelatedImage(OpenXmlPart oldContentPart, OpenXmlPart newContentPart, XElement imageReference, XName attributeName,
            List<ImageData> images)
        {
            string relId = (string)imageReference.Attribute(attributeName);
            if (string.IsNullOrEmpty(relId))
                return;

            // First look to see if this relId has already been added to the new document.
            // This is necessary for those parts that get processed with both old and new ids, such as the comments
            // part.  This is not necessary for parts such as the main document part, but this code won't malfunction
            // in that case.
            var tempPartIdPair5 = newContentPart.Parts.FirstOrDefault(p => p.RelationshipId == relId);
            if (tempPartIdPair5 != null)
                return;

            ExternalRelationship tempEr5 = newContentPart.ExternalRelationships.FirstOrDefault(er => er.Id == relId);
            if (tempEr5 != null)
                return;

            var ipp2 = oldContentPart.Parts.FirstOrDefault(ipp => ipp.RelationshipId == relId);
            if (ipp2 != null)
            {
                ImagePart oldPart = (ImagePart)ipp2.OpenXmlPart;
                ImageData temp = ManageImageCopy(oldPart, newContentPart, images);
                if (temp.ImagePart == null)
                {
                    ImagePart newPart = null;
                    if (newContentPart is MainDocumentPart)
                        newPart = ((MainDocumentPart)newContentPart).AddImagePart(oldPart.ContentType);
                    if (newContentPart is HeaderPart)
                        newPart = ((HeaderPart)newContentPart).AddImagePart(oldPart.ContentType);
                    if (newContentPart is FooterPart)
                        newPart = ((FooterPart)newContentPart).AddImagePart(oldPart.ContentType);
                    if (newContentPart is EndnotesPart)
                        newPart = ((EndnotesPart)newContentPart).AddImagePart(oldPart.ContentType);
                    if (newContentPart is FootnotesPart)
                        newPart = ((FootnotesPart)newContentPart).AddImagePart(oldPart.ContentType);
                    if (newContentPart is ThemePart)
                        newPart = ((ThemePart)newContentPart).AddImagePart(oldPart.ContentType);
                    if (newContentPart is WordprocessingCommentsPart)
                        newPart = ((WordprocessingCommentsPart)newContentPart).AddImagePart(oldPart.ContentType);
                    if (newContentPart is DocumentSettingsPart)
                        newPart = ((DocumentSettingsPart)newContentPart).AddImagePart(oldPart.ContentType);
                    if (newContentPart is ChartPart)
                        newPart = ((ChartPart)newContentPart).AddImagePart(oldPart.ContentType);
                    if (newContentPart is NumberingDefinitionsPart)
                        newPart = ((NumberingDefinitionsPart)newContentPart).AddImagePart(oldPart.ContentType);
                    if (newContentPart is DiagramDataPart)
                        newPart = ((DiagramDataPart)newContentPart).AddImagePart(oldPart.ContentType);
                    if (newContentPart is ChartDrawingPart)
                        newPart = ((ChartDrawingPart)newContentPart).AddImagePart(oldPart.ContentType);
                    temp.ImagePart = newPart;
                    var id = newContentPart.GetIdOfPart(newPart);
                    temp.AddContentPartRelTypeResourceIdTupple(newContentPart, newPart.RelationshipType, id);
                    imageReference.Attribute(attributeName).Value = id;
                    temp.WriteImage(newPart);
                }
                else
                {
                    var refRel = newContentPart.Parts.FirstOrDefault(pip =>
                    {
                        var rel = temp.ContentPartRelTypeIdList.FirstOrDefault(cpr =>
                        {
                            var found = cpr.ContentPart == newContentPart;
                            return found;
                        });
                        return rel != null;
                    });
                    if (refRel != null)
                    {
                        imageReference.Attribute(attributeName).Value = temp.ContentPartRelTypeIdList.First(cpr =>
                        {
                            var found = cpr.ContentPart == newContentPart;
                            return found;
                        }).RelationshipId;
                        return;
                    }
                    var newId = "R" + Guid.NewGuid().ToString().Replace("-", "").Substring(0, 16);
                    newContentPart.CreateRelationshipToPart(temp.ImagePart, newId);
                    imageReference.Attribute(R.id).Value = newId;
                }
            }
            else
            {
                ExternalRelationship er = oldContentPart.ExternalRelationships.FirstOrDefault(er1 => er1.Id == relId);
                if (er != null)
                {
                    ExternalRelationship newEr = newContentPart.AddExternalRelationship(er.RelationshipType, er.Uri);
                    imageReference.Attribute(R.id).Value = newEr.Id;
                }
                throw new DocumentBuilderInternalException("Source {0} is unsupported document - contains reference to NULL image");
            }
        }

        private static void CopyRelatedPartsForContentParts(OpenXmlPart oldContentPart, OpenXmlPart newContentPart,
            IEnumerable<XElement> newContent, List<ImageData> images)
        {
            var relevantElements = newContent.DescendantsAndSelf()
                .Where(d => d.Name == VML.imagedata || d.Name == VML.fill || d.Name == VML.stroke || d.Name == A.blip)
                .ToList();
            foreach (XElement imageReference in relevantElements)
            {
                CopyRelatedImage(oldContentPart, newContentPart, imageReference, R.embed, images);
                CopyRelatedImage(oldContentPart, newContentPart, imageReference, R.pict, images);
                CopyRelatedImage(oldContentPart, newContentPart, imageReference, R.id, images);
            }

            foreach (XElement diagramReference in newContent.DescendantsAndSelf().Where(d => d.Name == DGM.relIds || d.Name == A.relIds))
            {
                // dm attribute
                string relId = diagramReference.Attribute(R.dm).Value;
                var ipp = newContentPart.Parts.FirstOrDefault(p => p.RelationshipId == relId);
                if (ipp != null)
                {
                    OpenXmlPart tempPart = ipp.OpenXmlPart;
                    continue;
                }

                ExternalRelationship tempEr = newContentPart.ExternalRelationships.FirstOrDefault(er2 => er2.Id == relId);
                if (tempEr != null)
                    continue;

                OpenXmlPart oldPart = oldContentPart.GetPartById(relId);
                OpenXmlPart newPart = newContentPart.AddNewPart<DiagramDataPart>();
                newPart.GetXDocument().Add(oldPart.GetXDocument().Root);
                diagramReference.Attribute(R.dm).Value = newContentPart.GetIdOfPart(newPart);
                AddRelationships(oldPart, newPart, new[] { newPart.GetXDocument().Root });
                CopyRelatedPartsForContentParts(oldPart, newPart, new[] { newPart.GetXDocument().Root }, images);

                // lo attribute
                relId = diagramReference.Attribute(R.lo).Value;
                var ipp2 = newContentPart.Parts.FirstOrDefault(z => z.RelationshipId == relId);
                if (ipp2 != null)
                {
                    OpenXmlPart tempPart = ipp2.OpenXmlPart;
                    continue;
                }


                ExternalRelationship tempEr4 = newContentPart.ExternalRelationships.FirstOrDefault(er3 => er3.Id == relId);
                if (tempEr4 != null)
                    continue;

                oldPart = oldContentPart.GetPartById(relId);
                newPart = newContentPart.AddNewPart<DiagramLayoutDefinitionPart>();
                newPart.GetXDocument().Add(oldPart.GetXDocument().Root);
                diagramReference.Attribute(R.lo).Value = newContentPart.GetIdOfPart(newPart);
                AddRelationships(oldPart, newPart, new[] { newPart.GetXDocument().Root });
                CopyRelatedPartsForContentParts(oldPart, newPart, new[] { newPart.GetXDocument().Root }, images);

                // qs attribute
                relId = diagramReference.Attribute(R.qs).Value;
                var ipp5 = newContentPart.Parts.FirstOrDefault(z => z.RelationshipId == relId);
                if (ipp5 != null)
                {
                    OpenXmlPart tempPart = ipp5.OpenXmlPart;
                    continue;
                }

                ExternalRelationship tempEr5 = newContentPart.ExternalRelationships.FirstOrDefault(z => z.Id == relId);
                if (tempEr5 != null)
                    continue;

                oldPart = oldContentPart.GetPartById(relId);
                newPart = newContentPart.AddNewPart<DiagramStylePart>();
                newPart.GetXDocument().Add(oldPart.GetXDocument().Root);
                diagramReference.Attribute(R.qs).Value = newContentPart.GetIdOfPart(newPart);
                AddRelationships(oldPart, newPart, new[] { newPart.GetXDocument().Root });
                CopyRelatedPartsForContentParts(oldPart, newPart, new[] { newPart.GetXDocument().Root }, images);

                // cs attribute
                relId = diagramReference.Attribute(R.cs).Value;
                var ipp6 = newContentPart.Parts.FirstOrDefault(z => z.RelationshipId == relId);
                if (ipp6 != null)
                {
                    OpenXmlPart tempPart = ipp6.OpenXmlPart;
                    continue;
                }

                ExternalRelationship tempEr6 = newContentPart.ExternalRelationships.FirstOrDefault(z => z.Id == relId);
                if (tempEr6 != null)
                    continue;

                oldPart = oldContentPart.GetPartById(relId);
                newPart = newContentPart.AddNewPart<DiagramColorsPart>();
                newPart.GetXDocument().Add(oldPart.GetXDocument().Root);
                diagramReference.Attribute(R.cs).Value = newContentPart.GetIdOfPart(newPart);
                AddRelationships(oldPart, newPart, new[] { newPart.GetXDocument().Root });
                CopyRelatedPartsForContentParts(oldPart, newPart, new[] { newPart.GetXDocument().Root }, images);
            }

            foreach (XElement oleReference in newContent.DescendantsAndSelf(O.OLEObject))
            {
                string relId = oleReference.Attribute(R.id).Value;

                // First look to see if this relId has already been added to the new document.
                // This is necessary for those parts that get processed with both old and new ids, such as the comments
                // part.  This is not necessary for parts such as the main document part, but this code won't malfunction
                // in that case.
                var ipp1 = newContentPart.Parts.FirstOrDefault(p => p.RelationshipId == relId);
                if (ipp1 != null)
                {
                    OpenXmlPart tempPart = ipp1.OpenXmlPart;
                    continue;
                }

                ExternalRelationship tempEr1 = newContentPart.ExternalRelationships.FirstOrDefault(z => z.Id == relId);
                if (tempEr1 != null)
                    continue;

                var ipp4 = oldContentPart.Parts.FirstOrDefault(z => z.RelationshipId == relId);
                if (ipp4 != null)
                {
                    OpenXmlPart oldPart = oldContentPart.GetPartById(relId);
                    OpenXmlPart newPart = null;
                    if (oldPart is EmbeddedObjectPart)
                    {
                        if (newContentPart is HeaderPart)
                            newPart = ((HeaderPart)newContentPart).AddEmbeddedObjectPart(oldPart.ContentType);
                        if (newContentPart is FooterPart)
                            newPart = ((FooterPart)newContentPart).AddEmbeddedObjectPart(oldPart.ContentType);
                        if (newContentPart is MainDocumentPart)
                            newPart = ((MainDocumentPart)newContentPart).AddEmbeddedObjectPart(oldPart.ContentType);
                        if (newContentPart is FootnotesPart)
                            newPart = ((FootnotesPart)newContentPart).AddEmbeddedObjectPart(oldPart.ContentType);
                        if (newContentPart is EndnotesPart)
                            newPart = ((EndnotesPart)newContentPart).AddEmbeddedObjectPart(oldPart.ContentType);
                        if (newContentPart is WordprocessingCommentsPart)
                            newPart = ((WordprocessingCommentsPart)newContentPart).AddEmbeddedObjectPart(oldPart.ContentType);
                    }
                    else if (oldPart is EmbeddedPackagePart)
                    {
                        if (newContentPart is HeaderPart)
                            newPart = ((HeaderPart)newContentPart).AddEmbeddedPackagePart(oldPart.ContentType);
                        if (newContentPart is FooterPart)
                            newPart = ((FooterPart)newContentPart).AddEmbeddedPackagePart(oldPart.ContentType);
                        if (newContentPart is MainDocumentPart)
                            newPart = ((MainDocumentPart)newContentPart).AddEmbeddedPackagePart(oldPart.ContentType);
                        if (newContentPart is FootnotesPart)
                            newPart = ((FootnotesPart)newContentPart).AddEmbeddedPackagePart(oldPart.ContentType);
                        if (newContentPart is EndnotesPart)
                            newPart = ((EndnotesPart)newContentPart).AddEmbeddedPackagePart(oldPart.ContentType);
                        if (newContentPart is WordprocessingCommentsPart)
                            newPart = ((WordprocessingCommentsPart)newContentPart).AddEmbeddedPackagePart(oldPart.ContentType);
                        if (newContentPart is ChartPart)
                            newPart = ((ChartPart)newContentPart).AddEmbeddedPackagePart(oldPart.ContentType);
                    }
                    using (Stream oldObject = oldPart.GetStream(FileMode.Open, FileAccess.Read))
                    using (Stream newObject = newPart.GetStream(FileMode.Create, FileAccess.ReadWrite))
                    {
                        int byteCount;
                        byte[] buffer = new byte[65536];
                        while ((byteCount = oldObject.Read(buffer, 0, 65536)) != 0)
                            newObject.Write(buffer, 0, byteCount);
                    }
                    oleReference.Attribute(R.id).Value = newContentPart.GetIdOfPart(newPart);
                }
                else
                {
                    ExternalRelationship er = oldContentPart.GetExternalRelationship(relId);
                    ExternalRelationship newEr = newContentPart.AddExternalRelationship(er.RelationshipType, er.Uri);
                    oleReference.Attribute(R.id).Value = newEr.Id;
                }
            }

            foreach (XElement chartReference in newContent.DescendantsAndSelf(C.chart))
            {
                string relId = (string)chartReference.Attribute(R.id);
                if (string.IsNullOrEmpty(relId))
                    continue;
                var ipp2 = newContentPart.Parts.FirstOrDefault(z => z.RelationshipId == relId);
                if (ipp2 != null)
                {
                    OpenXmlPart tempPart = ipp2.OpenXmlPart;
                    continue;
                }

                ExternalRelationship tempEr2 = newContentPart.ExternalRelationships.FirstOrDefault(z => z.Id == relId);
                if (tempEr2 != null)
                    continue;

                var ipp3 = oldContentPart.Parts.FirstOrDefault(p => p.RelationshipId == relId);
                if (ipp3 == null)
                    continue;
                ChartPart oldPart = (ChartPart)ipp3.OpenXmlPart;
                XDocument oldChart = oldPart.GetXDocument();
                ChartPart newPart = newContentPart.AddNewPart<ChartPart>();
                XDocument newChart = newPart.GetXDocument();
                newChart.Add(oldChart.Root);
                chartReference.Attribute(R.id).Value = newContentPart.GetIdOfPart(newPart);
                CopyChartObjects(oldPart, newPart);
                CopyRelatedPartsForContentParts(oldPart, newPart, new[] { newChart.Root }, images);
            }

            foreach (XElement userShape in newContent.DescendantsAndSelf(C.userShapes))
            {
                string relId = (string)userShape.Attribute(R.id);
                if (string.IsNullOrEmpty(relId))
                    continue;

                var ipp4 = newContentPart.Parts.FirstOrDefault(p => p.RelationshipId == relId);
                if (ipp4 != null)
                {
                    OpenXmlPart tempPart = ipp4.OpenXmlPart;
                    continue;
                }

                ExternalRelationship tempEr4 = newContentPart.ExternalRelationships.FirstOrDefault(z => z.Id == relId);
                if (tempEr4 != null)
                    continue;

                var ipp5 = oldContentPart.Parts.FirstOrDefault(p => p.RelationshipId == relId);
                if (ipp5 != null)
                {
                    ChartDrawingPart oldPart = (ChartDrawingPart)ipp5.OpenXmlPart;
                    XDocument oldXDoc = oldPart.GetXDocument();
                    ChartDrawingPart newPart = newContentPart.AddNewPart<ChartDrawingPart>();
                    XDocument newXDoc = newPart.GetXDocument();
                    newXDoc.Add(oldXDoc.Root);
                    userShape.Attribute(R.id).Value = newContentPart.GetIdOfPart(newPart);
                    AddRelationships(oldPart, newPart, newContent);
                    CopyRelatedPartsForContentParts(oldPart, newPart, new[] { newXDoc.Root }, images);
                }
            }
        }

        private static void CopyFontTable(FontTablePart oldFontTablePart, FontTablePart newFontTablePart)
        {
            var relevantElements = oldFontTablePart.GetXDocument().Descendants().Where(d => d.Name == W.embedRegular ||
                d.Name == W.embedBold || d.Name == W.embedItalic || d.Name == W.embedBoldItalic).ToList();
            foreach (XElement fontReference in relevantElements)
            {
                string relId = (string)fontReference.Attribute(R.id);
                if (string.IsNullOrEmpty(relId))
                    continue;

                var ipp1 = newFontTablePart.Parts.FirstOrDefault(z => z.RelationshipId == relId);
                if (ipp1 != null)
                {
                    OpenXmlPart tempPart = ipp1.OpenXmlPart;
                    continue;
                }

                ExternalRelationship tempEr1 = newFontTablePart.ExternalRelationships.FirstOrDefault(z => z.Id == relId);
                if (tempEr1 != null)
                    continue;

                FontPart oldPart = (FontPart)oldFontTablePart.GetPartById(relId);
                FontPart newPart = newFontTablePart.AddFontPart(oldPart.ContentType);
                var ResourceID = newFontTablePart.GetIdOfPart(newPart);
                using (Stream oldFont = oldPart.GetStream(FileMode.Open, FileAccess.Read))
                using (Stream newFont = newPart.GetStream(FileMode.Create, FileAccess.ReadWrite))
                {
                    int byteCount;
                    byte[] buffer = new byte[65536];
                    while ((byteCount = oldFont.Read(buffer, 0, 65536)) != 0)
                        newFont.Write(buffer, 0, byteCount);
                }
                fontReference.Attribute(R.id).Value = ResourceID;
            }
        }

        private static void CopyChartObjects(ChartPart oldChart, ChartPart newChart)
        {
            foreach (XElement dataReference in newChart.GetXDocument().Descendants(C.externalData))
            {
                string relId = dataReference.Attribute(R.id).Value;

                var ipp1 = oldChart.Parts.FirstOrDefault(z => z.RelationshipId == relId);
                if (ipp1 != null)
                {
                    EmbeddedPackagePart oldPart = (EmbeddedPackagePart)ipp1.OpenXmlPart;
                    EmbeddedPackagePart newPart = newChart.AddEmbeddedPackagePart(oldPart.ContentType);
                    using (Stream oldObject = oldPart.GetStream(FileMode.Open, FileAccess.Read))
                    using (Stream newObject = newPart.GetStream(FileMode.Create, FileAccess.ReadWrite))
                    {
                        int byteCount;
                        byte[] buffer = new byte[65536];
                        while ((byteCount = oldObject.Read(buffer, 0, 65536)) != 0)
                            newObject.Write(buffer, 0, byteCount);
                    }
                    dataReference.Attribute(R.id).Value = newChart.GetIdOfPart(newPart);
                }
                else
                {
                    ExternalRelationship oldRelationship = oldChart.GetExternalRelationship(relId);
                    Guid g = Guid.NewGuid();
                    string newRid = "R" + g.ToString().Replace("-", "");
                    var oldRel = oldChart.ExternalRelationships.FirstOrDefault(h => h.Id == relId);
                    if (oldRel == null)
                        throw new DocumentBuilderInternalException("Internal Error 0007");
                    newChart.AddExternalRelationship(oldRel.RelationshipType, oldRel.Uri, newRid);
                    dataReference.Attribute(R.id).Value = newRid;
                }
            }
        }

        private static void CopyStartingParts(WordprocessingDocument sourceDocument, WordprocessingDocument newDocument,
            List<ImageData> images)
        {
            // A Core File Properties part does not have implicit or explicit relationships to other parts.
            CoreFilePropertiesPart corePart = sourceDocument.CoreFilePropertiesPart;
            if (corePart != null && corePart.GetXDocument().Root != null)
            {
                newDocument.AddCoreFilePropertiesPart();
                XDocument newXDoc = newDocument.CoreFilePropertiesPart.GetXDocument();
                newXDoc.Declaration.Standalone = "yes";
                newXDoc.Declaration.Encoding = "UTF-8";
                XDocument sourceXDoc = corePart.GetXDocument();
                newXDoc.Add(sourceXDoc.Root);
            }

            // An application attributes part does not have implicit or explicit relationships to other parts.
            ExtendedFilePropertiesPart extPart = sourceDocument.ExtendedFilePropertiesPart;
            if (extPart != null)
            {
                OpenXmlPart newPart = newDocument.AddExtendedFilePropertiesPart();
                XDocument newXDoc = newDocument.ExtendedFilePropertiesPart.GetXDocument();
                newXDoc.Declaration.Standalone = "yes";
                newXDoc.Declaration.Encoding = "UTF-8";
                newXDoc.Add(extPart.GetXDocument().Root);
            }

            // An custom file properties part does not have implicit or explicit relationships to other parts.
            CustomFilePropertiesPart customPart = sourceDocument.CustomFilePropertiesPart;
            if (customPart != null)
            {
                newDocument.AddCustomFilePropertiesPart();
                XDocument newXDoc = newDocument.CustomFilePropertiesPart.GetXDocument();
                newXDoc.Declaration.Standalone = "yes";
                newXDoc.Declaration.Encoding = "UTF-8";
                newXDoc.Add(customPart.GetXDocument().Root);
            }

            DocumentSettingsPart oldSettingsPart = sourceDocument.MainDocumentPart.DocumentSettingsPart;
            if (oldSettingsPart != null)
            {
                DocumentSettingsPart newSettingsPart = newDocument.MainDocumentPart.AddNewPart<DocumentSettingsPart>();
                XDocument settingsXDoc = oldSettingsPart.GetXDocument();
                AddRelationships(oldSettingsPart, newSettingsPart, new[] { settingsXDoc.Root });
                CopyFootnotesPart(sourceDocument, newDocument, settingsXDoc, images);
                CopyEndnotesPart(sourceDocument, newDocument, settingsXDoc, images);
                XDocument newXDoc = newDocument.MainDocumentPart.DocumentSettingsPart.GetXDocument();
                newXDoc.Declaration.Standalone = "yes";
                newXDoc.Declaration.Encoding = "UTF-8";
                newXDoc.Add(settingsXDoc.Root);
                CopyRelatedPartsForContentParts(oldSettingsPart, newSettingsPart, new[] { newXDoc.Root }, images);
            }

            WebSettingsPart oldWebSettingsPart = sourceDocument.MainDocumentPart.WebSettingsPart;
            if (oldWebSettingsPart != null)
            {
                WebSettingsPart newWebSettingsPart = newDocument.MainDocumentPart.AddNewPart<WebSettingsPart>();
                XDocument settingsXDoc = oldWebSettingsPart.GetXDocument();
                AddRelationships(oldWebSettingsPart, newWebSettingsPart, new[] { settingsXDoc.Root });
                XDocument newXDoc = newDocument.MainDocumentPart.WebSettingsPart.GetXDocument();
                newXDoc.Declaration.Standalone = "yes";
                newXDoc.Declaration.Encoding = "UTF-8";
                newXDoc.Add(settingsXDoc.Root);
            }

            ThemePart themePart = sourceDocument.MainDocumentPart.ThemePart;
            if (themePart != null)
            {
                ThemePart newThemePart = newDocument.MainDocumentPart.AddNewPart<ThemePart>();
                XDocument newXDoc = newDocument.MainDocumentPart.ThemePart.GetXDocument();
                newXDoc.Declaration.Standalone = "yes";
                newXDoc.Declaration.Encoding = "UTF-8";
                newXDoc.Add(themePart.GetXDocument().Root);
                CopyRelatedPartsForContentParts(themePart, newThemePart, new[] { newThemePart.GetXDocument().Root }, images);
            }

            // If needed to handle GlossaryDocumentPart in the future, then
            // this code should handle the following parts:
            //   MainDocumentPart.GlossaryDocumentPart.StyleDefinitionsPart
            //   MainDocumentPart.GlossaryDocumentPart.StylesWithEffectsPart

            // A Style Definitions part shall not have implicit or explicit relationships to any other part.
            StyleDefinitionsPart stylesPart = sourceDocument.MainDocumentPart.StyleDefinitionsPart;
            if (stylesPart != null)
            {
                newDocument.MainDocumentPart.AddNewPart<StyleDefinitionsPart>();
                XDocument newXDoc = newDocument.MainDocumentPart.StyleDefinitionsPart.GetXDocument();
                newXDoc.Declaration.Standalone = "yes";
                newXDoc.Declaration.Encoding = "UTF-8";
                newXDoc.Add(new XElement(W.styles,
                    new XAttribute(XNamespace.Xmlns + "w", W.w),
                    stylesPart.GetXDocument().Descendants(W.docDefaults)));
                MergeStyles(sourceDocument, newDocument, stylesPart.GetXDocument(), newXDoc);
            }

            //// A StylesWithEffects part shall not have implicit or explicit relationships to any other part.
            //StylesWithEffectsPart stylesWithEffectsPart = sourceDocument.MainDocumentPart.StylesWithEffectsPart;
            //if (stylesWithEffectsPart != null)
            //{
            //    newDocument.MainDocumentPart.AddNewPart<StylesWithEffectsPart>();
            //    XDocument newXDoc = newDocument.MainDocumentPart.StylesWithEffectsPart.GetXDocument();
            //    newXDoc.Declaration.Standalone = "yes";
            //    newXDoc.Declaration.Encoding = "UTF-8";
            //    newXDoc.Add(stylesWithEffectsPart.GetXDocument().Root);
            //}



            // Note: Do not copy the numbering part.  For every source, create new numbering definitions from
            // scratch.
            //NumberingDefinitionsPart numberingPart = sourceDocument.MainDocumentPart.NumberingDefinitionsPart;
            //if (numberingPart != null)
            //{
            //    newDocument.MainDocumentPart.AddNewPart<NumberingDefinitionsPart>();
            //    XDocument newXDoc = newDocument.MainDocumentPart.NumberingDefinitionsPart.GetXDocument();
            //    newXDoc.Declaration.Standalone = "yes";
            //    newXDoc.Declaration.Encoding = "UTF-8";
            //    newXDoc.Add(numberingPart.GetXDocument().Root);
            //    newXDoc.Descendants(W.numIdMacAtCleanup).Remove();
            //}

            // A Font Table part shall not have any implicit or explicit relationships to any other part.
            FontTablePart fontTablePart = sourceDocument.MainDocumentPart.FontTablePart;
            if (fontTablePart != null)
            {
                newDocument.MainDocumentPart.AddNewPart<FontTablePart>();
                XDocument newXDoc = newDocument.MainDocumentPart.FontTablePart.GetXDocument();
                newXDoc.Declaration.Standalone = "yes";
                newXDoc.Declaration.Encoding = "UTF-8";
                CopyFontTable(sourceDocument.MainDocumentPart.FontTablePart, newDocument.MainDocumentPart.FontTablePart);
                newXDoc.Add(fontTablePart.GetXDocument().Root);
            }
        }

        private static void CopyFootnotesPart(WordprocessingDocument sourceDocument, WordprocessingDocument newDocument,
            XDocument settingsXDoc, List<ImageData> images)
        {
            int number = 0;
            XDocument oldFootnotes = null;
            XDocument newFootnotes = null;
            XElement footnotePr = settingsXDoc.Root.Element(W.footnotePr);
            if (footnotePr == null)
                return;
            foreach (XElement footnote in footnotePr.Elements(W.footnote))
            {
                if (oldFootnotes == null)
                    oldFootnotes = sourceDocument.MainDocumentPart.FootnotesPart.GetXDocument();
                if (newFootnotes == null)
                {
                    if (newDocument.MainDocumentPart.FootnotesPart != null)
                    {
                        newFootnotes = newDocument.MainDocumentPart.FootnotesPart.GetXDocument();
                        newFootnotes.Declaration.Standalone = "yes";
                        newFootnotes.Declaration.Encoding = "UTF-8";
                        var ids = newFootnotes.Root.Elements(W.footnote).Select(f => (int)f.Attribute(W.id));
                        if (ids.Any())
                            number = ids.Max() + 1;
                    }
                    else
                    {
                        newDocument.MainDocumentPart.AddNewPart<FootnotesPart>();
                        newFootnotes = newDocument.MainDocumentPart.FootnotesPart.GetXDocument();
                        newFootnotes.Declaration.Standalone = "yes";
                        newFootnotes.Declaration.Encoding = "UTF-8";
                        newFootnotes.Add(new XElement(W.footnotes, NamespaceAttributes));
                    }
                }
                string id = (string)footnote.Attribute(W.id);
                XElement element = oldFootnotes.Descendants()
                    .Elements(W.footnote)
                    .Where(p => ((string)p.Attribute(W.id)) == id)
                    .First();
                XElement newElement = new XElement(element);
                // the following adds the footnote into the new settings part
                newElement.Attribute(W.id).Value = number.ToString();
                newFootnotes.Root.Add(newElement);
                footnote.Attribute(W.id).Value = number.ToString();
                number++;
            }
        }

        private static void CopyEndnotesPart(WordprocessingDocument sourceDocument, WordprocessingDocument newDocument,
            XDocument settingsXDoc, List<ImageData> images)
        {
            int number = 0;
            XDocument oldEndnotes = null;
            XDocument newEndnotes = null;
            XElement endnotePr = settingsXDoc.Root.Element(W.endnotePr);
            if (endnotePr == null)
                return;
            foreach (XElement endnote in endnotePr.Elements(W.endnote))
            {
                if (oldEndnotes == null)
                    oldEndnotes = sourceDocument.MainDocumentPart.EndnotesPart.GetXDocument();
                if (newEndnotes == null)
                {
                    if (newDocument.MainDocumentPart.EndnotesPart != null)
                    {
                        newEndnotes = newDocument.MainDocumentPart.EndnotesPart.GetXDocument();
                        newEndnotes.Declaration.Standalone = "yes";
                        newEndnotes.Declaration.Encoding = "UTF-8";
                        var ids = newEndnotes.Root
                            .Elements(W.endnote)
                            .Select(f => (int)f.Attribute(W.id));
                        if (ids.Any())
                            number = ids.Max() + 1;
                    }
                    else
                    {
                        newDocument.MainDocumentPart.AddNewPart<EndnotesPart>();
                        newEndnotes = newDocument.MainDocumentPart.EndnotesPart.GetXDocument();
                        newEndnotes.Declaration.Standalone = "yes";
                        newEndnotes.Declaration.Encoding = "UTF-8";
                        newEndnotes.Add(new XElement(W.endnotes, NamespaceAttributes));
                    }
                }
                string id = (string)endnote.Attribute(W.id);
                XElement element = oldEndnotes.Descendants()
                    .Elements(W.endnote)
                    .Where(p => ((string)p.Attribute(W.id)) == id)
                    .First();
                XElement newElement = new XElement(element);
                newElement.Attribute(W.id).Value = number.ToString();
                newEndnotes.Root.Add(newElement);
                endnote.Attribute(W.id).Value = number.ToString();
                number++;
            }
        }

        public static void FixRanges(XDocument sourceDocument, IEnumerable<XElement> newContent)
        {
            FixRange(sourceDocument,
                newContent,
                W.commentRangeStart,
                W.commentRangeEnd,
                W.id,
                W.commentReference);
            FixRange(sourceDocument,
                newContent,
                W.bookmarkStart,
                W.bookmarkEnd,
                W.id,
                null);
            FixRange(sourceDocument,
                newContent,
                W.permStart,
                W.permEnd,
                W.id,
                null);
            FixRange(sourceDocument,
                newContent,
                W.moveFromRangeStart,
                W.moveFromRangeEnd,
                W.id,
                null);
            FixRange(sourceDocument,
                newContent,
                W.moveToRangeStart,
                W.moveToRangeEnd,
                W.id,
                null);
            DeleteUnmatchedRange(sourceDocument,
                newContent,
                W.moveFromRangeStart,
                W.moveFromRangeEnd,
                W.moveToRangeStart,
                W.name,
                W.id);
            DeleteUnmatchedRange(sourceDocument,
                newContent,
                W.moveToRangeStart,
                W.moveToRangeEnd,
                W.moveFromRangeStart,
                W.name,
                W.id);
        }

        private static void AddAtBeginning(IEnumerable<XElement> newContent, XElement contentToAdd)
        {
            if (newContent.First().Element(W.pPr) != null)
                newContent.First().Element(W.pPr).AddAfterSelf(contentToAdd);
            else
                newContent.First().AddFirst(new XElement(contentToAdd));
        }

        private static void AddAtEnd(IEnumerable<XElement> newContent, XElement contentToAdd)
        {
            if (newContent.Last().Element(W.pPr) != null)
                newContent.Last().Element(W.pPr).AddAfterSelf(new XElement(contentToAdd));
            else
                newContent.Last().Add(new XElement(contentToAdd));
        }

        // If the set of paragraphs from sourceDocument don't have a complete start/end for bookmarks,
        // comments, etc., then this adds them to the paragraph.  Note that this adds them to
        // sourceDocument, and is impure.
        private static void FixRange(XDocument sourceDocument, IEnumerable<XElement> newContent,
            XName startElement, XName endElement, XName idAttribute, XName refElement)
        {
            foreach (XElement start in newContent.DescendantsAndSelf(startElement))
            {
                string rangeId = start.Attribute(idAttribute).Value;
                if (newContent
                    .DescendantsAndSelf(endElement)
                    .Where(e => e.Attribute(idAttribute).Value == rangeId)
                    .Count() == 0)
                {
                    XElement end = sourceDocument
                        .Descendants(endElement)
                        .Where(o => o.Attribute(idAttribute).Value == rangeId)
                        .FirstOrDefault();
                    if (end != null)
                    {
                        AddAtEnd(newContent, new XElement(end));
                        if (refElement != null)
                        {
                            XElement newRef = new XElement(refElement, new XAttribute(idAttribute, rangeId));
                            AddAtEnd(newContent, new XElement(newRef));
                        }
                    }
                }
            }
            foreach (XElement end in newContent.Elements(endElement))
            {
                string rangeId = end.Attribute(idAttribute).Value;
                if (newContent
                    .DescendantsAndSelf(startElement)
                    .Where(s => s.Attribute(idAttribute).Value == rangeId)
                    .Count() == 0)
                {
                    XElement start = sourceDocument
                        .Descendants(startElement)
                        .Where(o => o.Attribute(idAttribute).Value == rangeId)
                        .FirstOrDefault();
                    if (start != null)
                        AddAtBeginning(newContent, new XElement(start));
                }
            }
        }

        private static void DeleteUnmatchedRange(XDocument sourceDocument, IEnumerable<XElement> newContent,
            XName startElement, XName endElement, XName matchTo, XName matchAttr, XName idAttr)
        {
            List<string> deleteList = new List<string>();
            foreach (XElement start in newContent.Elements(startElement))
            {
                string id = start.Attribute(matchAttr).Value;
                if (!newContent.Elements(matchTo).Where(n => n.Attribute(matchAttr).Value == id).Any())
                    deleteList.Add(start.Attribute(idAttr).Value);
            }
            foreach (string item in deleteList)
            {
                newContent.Elements(startElement).Where(n => n.Attribute(idAttr).Value == item).Remove();
                newContent.Elements(endElement).Where(n => n.Attribute(idAttr).Value == item).Remove();
                newContent.Where(p => p.Name == startElement && p.Attribute(idAttr).Value == item).Remove();
                newContent.Where(p => p.Name == endElement && p.Attribute(idAttr).Value == item).Remove();
            }
        }

        private static void CopyFootnotes(WordprocessingDocument sourceDocument, WordprocessingDocument newDocument,
            IEnumerable<XElement> newContent, List<ImageData> images)
        {
            int number = 0;
            XDocument oldFootnotes = null;
            XDocument newFootnotes = null;
            foreach (XElement footnote in newContent.DescendantsAndSelf(W.footnoteReference))
            {
                if (oldFootnotes == null)
                    oldFootnotes = sourceDocument.MainDocumentPart.FootnotesPart.GetXDocument();
                if (newFootnotes == null)
                {
                    if (newDocument.MainDocumentPart.FootnotesPart != null)
                    {
                        newFootnotes = newDocument.MainDocumentPart.FootnotesPart.GetXDocument();
                        var ids = newFootnotes
                            .Root
                            .Elements(W.footnote)
                            .Select(f => (int)f.Attribute(W.id));
                        if (ids.Any())
                            number = ids.Max() + 1;
                    }
                    else
                    {
                        newDocument.MainDocumentPart.AddNewPart<FootnotesPart>();
                        newFootnotes = newDocument.MainDocumentPart.FootnotesPart.GetXDocument();
                        newFootnotes.Declaration.Standalone = "yes";
                        newFootnotes.Declaration.Encoding = "UTF-8";
                        newFootnotes.Add(new XElement(W.footnotes, NamespaceAttributes));
                    }
                }
                string id = (string)footnote.Attribute(W.id);
                XElement element = oldFootnotes
                    .Descendants()
                    .Elements(W.footnote)
                    .Where(p => ((string)p.Attribute(W.id)) == id)
                    .First();
                XElement newElement = new XElement(element);
                newElement.Attribute(W.id).Value = number.ToString();
                newFootnotes.Root.Add(newElement);
                footnote.Attribute(W.id).Value = number.ToString();
                number++;
            }
            if (sourceDocument.MainDocumentPart.FootnotesPart != null &&
                newDocument.MainDocumentPart.FootnotesPart != null)
            {
                AddRelationships(sourceDocument.MainDocumentPart.FootnotesPart,
                    newDocument.MainDocumentPart.FootnotesPart,
                    new[] { newDocument.MainDocumentPart.FootnotesPart.GetXDocument().Root });
                CopyRelatedPartsForContentParts(sourceDocument.MainDocumentPart.FootnotesPart,
                    newDocument.MainDocumentPart.FootnotesPart,
                    new[] { newDocument.MainDocumentPart.FootnotesPart.GetXDocument().Root }, images);
            }
        }

        private static void CopyEndnotes(WordprocessingDocument sourceDocument, WordprocessingDocument newDocument,
            IEnumerable<XElement> newContent, List<ImageData> images)
        {
            int number = 0;
            XDocument oldEndnotes = null;
            XDocument newEndnotes = null;
            foreach (XElement endnote in newContent.DescendantsAndSelf(W.endnoteReference))
            {
                if (oldEndnotes == null)
                    oldEndnotes = sourceDocument.MainDocumentPart.EndnotesPart.GetXDocument();
                if (newEndnotes == null)
                {
                    if (newDocument.MainDocumentPart.EndnotesPart != null)
                    {
                        newEndnotes = newDocument
                            .MainDocumentPart
                            .EndnotesPart
                            .GetXDocument();
                        var ids = newEndnotes
                            .Root
                            .Elements(W.endnote)
                            .Select(f => (int)f.Attribute(W.id));
                        if (ids.Any())
                            number = ids.Max() + 1;
                    }
                    else
                    {
                        newDocument.MainDocumentPart.AddNewPart<EndnotesPart>();
                        newEndnotes = newDocument.MainDocumentPart.EndnotesPart.GetXDocument();
                        newEndnotes.Declaration.Standalone = "yes";
                        newEndnotes.Declaration.Encoding = "UTF-8";
                        newEndnotes.Add(new XElement(W.endnotes, NamespaceAttributes));
                    }
                }
                string id = (string)endnote.Attribute(W.id);
                XElement element = oldEndnotes
                    .Descendants()
                    .Elements(W.endnote)
                    .Where(p => ((string)p.Attribute(W.id)) == id)
                    .First();
                XElement newElement = new XElement(element);
                newElement.Attribute(W.id).Value = number.ToString();
                newEndnotes.Root.Add(newElement);
                endnote.Attribute(W.id).Value = number.ToString();
                number++;
            }
            if (sourceDocument.MainDocumentPart.EndnotesPart != null &&
                newDocument.MainDocumentPart.EndnotesPart != null)
            {
                AddRelationships(sourceDocument.MainDocumentPart.EndnotesPart,
                    newDocument.MainDocumentPart.EndnotesPart,
                    new[] { newDocument.MainDocumentPart.EndnotesPart.GetXDocument().Root });
                CopyRelatedPartsForContentParts(sourceDocument.MainDocumentPart.EndnotesPart,
                    newDocument.MainDocumentPart.EndnotesPart,
                    new[] { newDocument.MainDocumentPart.EndnotesPart.GetXDocument().Root }, images);
            }
        }

        // General function for handling images that tries to use an existing image if they are the same
        private static ImageData ManageImageCopy(ImagePart oldImage, OpenXmlPart newContentPart, List<ImageData> images)
        {
            ImageData oldImageData = new ImageData(oldImage);
            foreach (ImageData item in images)
            {
                if (newContentPart != item.ImagePart)
                    continue;
                if (item.Compare(oldImageData))
                    return item;
            }
            images.Add(oldImageData);
            return oldImageData;
        }

        private static XAttribute[] NamespaceAttributes =
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
    }

    public class DocumentBuilderException : Exception
    {
        public DocumentBuilderException(string message) : base(message) { }
    }

    public class DocumentBuilderInternalException : Exception
    {
        public DocumentBuilderInternalException(string message) : base(message) { }
    }
}
