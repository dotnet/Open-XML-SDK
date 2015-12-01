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
 * Modifications to support deleting paragraphs between tables

***************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using DocumentFormat.OpenXml.Packaging;

namespace OpenXmlPowerTools
{
    public class RevisionAccepter
    {
        public static WmlDocument AcceptRevisions(WmlDocument document)
        {
            using (OpenXmlMemoryStreamDocument streamDoc = new OpenXmlMemoryStreamDocument(document))
            {
                using (WordprocessingDocument doc = streamDoc.GetWordprocessingDocument())
                {
                    AcceptRevisions(doc);
                }
                return streamDoc.GetModifiedWmlDocument();
            }
        }

        public static void AcceptRevisions(WordprocessingDocument doc)
        {
            AcceptRevisionsForPart(doc.MainDocumentPart);
            foreach (var part in doc.MainDocumentPart.HeaderParts)
                AcceptRevisionsForPart(part);
            foreach (var part in doc.MainDocumentPart.FooterParts)
                AcceptRevisionsForPart(part);
            if (doc.MainDocumentPart.EndnotesPart != null)
                AcceptRevisionsForPart(doc.MainDocumentPart.EndnotesPart);
            if (doc.MainDocumentPart.FootnotesPart != null)
                AcceptRevisionsForPart(doc.MainDocumentPart.FootnotesPart);
            if (doc.MainDocumentPart.StyleDefinitionsPart != null)
                AcceptRevisionsForStylesDefinitionPart(doc.MainDocumentPart.StyleDefinitionsPart);
        }

        private static void AcceptRevisionsForStylesDefinitionPart(StyleDefinitionsPart stylesDefinitionsPart)
        {
            var xDoc = stylesDefinitionsPart.GetXDocument();
            var newRoot = AcceptRevisionsForStylesTransform(xDoc.Root);
            xDoc.Root.ReplaceWith(newRoot);
            stylesDefinitionsPart.PutXDocument();
        }

        private static object AcceptRevisionsForStylesTransform(XNode node)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                if (element.Name == W.pPrChange || element.Name == W.rPrChange)
                    return null;
                return new XElement(element.Name,
                    element.Attributes(),
                    element.Nodes().Select(n => AcceptRevisionsForStylesTransform(n)));
            }
            return node;
        }

        public static void AcceptRevisionsForPart(OpenXmlPart part)
        {
            XElement documentElement = part.GetXDocument().Root;
            documentElement = (XElement)AcceptMoveFromMoveToTransform(documentElement);
            documentElement = AcceptMoveFromRanges(documentElement);
            // AcceptParagraphEndTagsInMoveFromTransform needs rewritten similar to AcceptDeletedAndMoveFromParagraphMarks
            documentElement = (XElement)AcceptParagraphEndTagsInMoveFromTransform(documentElement);
            documentElement = AcceptDeletedAndMovedFromContentControls(documentElement);
            documentElement = AcceptDeletedAndMoveFromParagraphMarks(documentElement);
            documentElement = (XElement)RemoveRowsLeftEmptyByMoveFrom(documentElement);
            documentElement = (XElement)AcceptAllOtherRevisionsTransform(documentElement);
            documentElement = (XElement)AcceptDeletedCellsTransform(documentElement);
            documentElement = (XElement)MergeAdjacentTablesTransform(documentElement);
            documentElement.Descendants().Attributes().Where(a => a.Name == PT.UniqueId || a.Name == PT.RunIds).Remove();
            documentElement.Descendants(W.numPr).Where(np => !np.HasElements).Remove();
            XDocument newXDoc = new XDocument(documentElement);
            part.PutXDocument(newXDoc);
        }

        private static object MergeAdjacentTablesTransform(XNode node)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                if (element.Element(W.tbl) != null)
                {
                    var grouped = element
                        .Elements()
                        .GroupAdjacent(e =>
                        {
                            if (e.Name != W.tbl)
                                return "";
                            var bidiVisual = e.Elements(W.tblPr).Elements(W.bidiVisual).FirstOrDefault();
                            var bidiVisString = bidiVisual == null ? "" : "|bidiVisual";
                            var key = "tbl" + bidiVisString;
                            return key;
                        });

                    var newContent = grouped
                        .Select(g =>
                        {
                            if (g.Key == "" || g.Count() == 1)
                                return (object)g;
                            var rolled = g
                                .Select(tbl =>
                                {
                                    var gridCols = tbl
                                        .Elements(W.tblGrid)
                                        .Elements(W.gridCol)
                                        .Attributes(W._w)
                                        .Select(a => (int)a)
                                        .Rollup(0, (s, i) => s + i);
                                    return gridCols;
                                })
                                .SelectMany(m => m)
                                .Distinct()
                                .OrderBy(w => w)
                                .ToArray();
                            var newTable = new XElement(W.tbl,
                                g.First().Elements(W.tblPr),
                                new XElement(W.tblGrid,
                                    rolled.Select((r, i) =>
                                    {
                                        int v;
                                        if (i == 0)
                                            v = r;
                                        else
                                            v = r - rolled[i - 1];
                                        return new XElement(W.gridCol,
                                            new XAttribute(W._w, v));
                                    })),
                                g.Select(tbl =>
                                {
                                    var fixedWidthsTbl = FixWidths(tbl);
                                    var newRows = fixedWidthsTbl.Elements(W.tr)
                                        .Select(tr =>
                                        {
                                            XElement newRow = new XElement(W.tr,
                                                tr.Attributes(),
                                                tr.Elements().Where(e => e.Name != W.tc),
                                                tr.Elements(W.tc).Select(tc =>
                                                {
                                                    int? w = (int?)tc
                                                        .Elements(W.tcPr)
                                                        .Elements(W.tcW)
                                                        .Attributes(W._w)
                                                        .FirstOrDefault();
                                                    if (w == null)
                                                        return tc;
                                                    var cellsToLeft = tc
                                                        .Parent
                                                        .Elements(W.tc)
                                                        .TakeWhile(btc => btc != tc);
                                                    int widthToLeft = 0;
                                                    if (cellsToLeft.Any())
                                                        widthToLeft = cellsToLeft
                                                        .Elements(W.tcPr)
                                                        .Elements(W.tcW)
                                                        .Attributes(W._w)
                                                        .Select(wi => (int)wi)
                                                        .Sum();
                                                    var rolledPairs = new [] { new
                                                        {
                                                            GridValue = 0,
                                                            Index = 0,
                                                        }}
                                                        .Concat(
                                                            rolled
                                                            .Select((r, i) => new
                                                            {
                                                                GridValue = r,
                                                                Index = i + 1,
                                                            }));
                                                    var start = rolledPairs
                                                        .FirstOrDefault(t => t.GridValue >= widthToLeft);
                                                    if (start != null)
                                                    {
                                                        var gridsRequired = rolledPairs
                                                            .Skip(start.Index)
                                                            .TakeWhile(rp => rp.GridValue - start.GridValue < w)
                                                            .Count();
                                                        var tcPr = new XElement(W.tcPr,
                                                                tc.Elements(W.tcPr).Elements().Where(e => e.Name != W.gridSpan),
                                                                gridsRequired != 1 ?
                                                                    new XElement(W.gridSpan,
                                                                        new XAttribute(W.val, gridsRequired)) :
                                                                    null);
                                                        var orderedTcPr = new XElement(W.tcPr,
                                                            tcPr.Elements().OrderBy(e =>
                                                            {
                                                                if (Order_tcPr.ContainsKey(e.Name))
                                                                    return Order_tcPr[e.Name];
                                                                return 999;
                                                            }));
                                                        var newCell = new XElement(W.tc,
                                                            orderedTcPr,
                                                            tc.Elements().Where(e => e.Name != W.tcPr));
                                                        return newCell;
                                                    }
                                                    return tc;
                                                }));
                                            return newRow;
                                        });
                                    return newRows;
                                }));
                            return newTable;
                        });
                    return new XElement(element.Name,
                        element.Attributes(),
                        newContent);
                }

                return new XElement(element.Name,
                    element.Attributes(),
                    element.Nodes().Select(n => MergeAdjacentTablesTransform(n)));
            }
            return node;
        }

        private static Dictionary<XName, int> Order_tcPr = new Dictionary<XName, int>
        {
            { W.cnfStyle, 10 },
            { W.tcW, 20 },
            { W.gridSpan, 30 },
            { W.hMerge, 40 },
            { W.vMerge, 50 },
            { W.tcBorders, 60 },
            { W.shd, 70 },
            { W.noWrap, 80 },
            { W.tcMar, 90 },
            { W.textDirection, 100 },
            { W.tcFitText, 110 },
            { W.vAlign, 120 },
            { W.hideMark, 130 },
            { W.headers, 140 },
        };

        private static XElement FixWidths(XElement tbl)
        {
            var newTbl = new XElement(tbl);
            var gridLines = tbl.Elements(W.tblGrid).Elements(W.gridCol).Attributes(W._w).Select(w => (int)w).ToArray();
            foreach (var tr in newTbl.Elements(W.tr))
            {
                int used = 0;
                int lastUsed = -1;
                foreach (var tc in tr.Elements(W.tc))
                {
                    var tcW = tc.Elements(W.tcPr).Elements(W.tcW).Attributes(W._w).FirstOrDefault();
                    if (tcW != null)
                    {
                        int? gridSpan = (int?)tc.Elements(W.tcPr).Elements(W.gridSpan).Attributes(W.val).FirstOrDefault();

                        if (gridSpan == null)
                            gridSpan = 1;
                        
                        var z = Math.Min(gridLines.Length - 1, lastUsed + (int)gridSpan);
                        int w = gridLines.Where((g, i) => i > lastUsed && i <= z).Sum();
                        tcW.Value = w.ToString();

                        lastUsed += (int)gridSpan;
                        used += (int)gridSpan;
                    }
                }
            }
            return newTbl;
        }

        private static object AcceptMoveFromMoveToTransform(XNode node)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                if (element.Name == W.moveTo)
                    return element.Nodes().Select(n => AcceptMoveFromMoveToTransform(n));
                if (element.Name == W.moveFrom)
                    return null;
                return new XElement(element.Name,
                    element.Attributes(),
                    element.Nodes().Select(n => AcceptMoveFromMoveToTransform(n)));
            }
            return node;
        }

        private static XElement AcceptMoveFromRanges(XElement document)
        {
            string wordProcessingNamespacePrefix = document.GetPrefixOfNamespace(W.w);

            // The following lists contain the elements that are between start/end elements.
            List<XElement> startElementTagsInMoveFromRange = new List<XElement>();
            List<XElement> endElementTagsInMoveFromRange = new List<XElement>();

            // Following are the elements that *may* be in a range that has both start and end
            // elements.
            Dictionary<string, PotentialInRangeElements> potentialDeletedElements =
                new Dictionary<string, PotentialInRangeElements>();

            foreach (var tag in DescendantAndSelfTags(document))
            {
                if (tag.Element.Name == W.moveFromRangeStart)
                {
                    string id = tag.Element.Attribute(W.id).Value;
                    potentialDeletedElements.Add(id, new PotentialInRangeElements());
                    continue;
                }
                if (tag.Element.Name == W.moveFromRangeEnd)
                {
                    string id = tag.Element.Attribute(W.id).Value;
                    if (potentialDeletedElements.ContainsKey(id))
                    {
                        startElementTagsInMoveFromRange.AddRange(
                            potentialDeletedElements[id].PotentialStartElementTagsInRange);
                        endElementTagsInMoveFromRange.AddRange(
                            potentialDeletedElements[id].PotentialEndElementTagsInRange);
                        potentialDeletedElements.Remove(id);
                    }
                    continue;
                }
                if (potentialDeletedElements.Count > 0)
                {
                    if (tag.TagType == TagTypeEnum.Element &&
                        (tag.Element.Name != W.moveFromRangeStart &&
                         tag.Element.Name != W.moveFromRangeEnd))
                    {
                        foreach (var id in potentialDeletedElements)
                            id.Value.PotentialStartElementTagsInRange.Add(tag.Element);
                        continue;
                    }
                    if (tag.TagType == TagTypeEnum.EmptyElement &&
                        (tag.Element.Name != W.moveFromRangeStart &&
                         tag.Element.Name != W.moveFromRangeEnd))
                    {
                        foreach (var id in potentialDeletedElements)
                        {
                            id.Value.PotentialStartElementTagsInRange.Add(tag.Element);
                            id.Value.PotentialEndElementTagsInRange.Add(tag.Element);
                        }
                        continue;
                    }
                    if (tag.TagType == TagTypeEnum.EndElement &&
                        (tag.Element.Name != W.moveFromRangeStart &&
                        tag.Element.Name != W.moveFromRangeEnd))
                    {
                        foreach (var id in potentialDeletedElements)
                            id.Value.PotentialEndElementTagsInRange.Add(tag.Element);
                        continue;
                    }
                }
            }
            var moveFromElementsToDelete = startElementTagsInMoveFromRange
                .Intersect(endElementTagsInMoveFromRange)
                .ToArray();
            if (moveFromElementsToDelete.Count() > 0)
                return (XElement)AcceptMoveFromRangesTransform(
                    document, moveFromElementsToDelete);
            return document;
        }

        private enum MoveFromCollectionType
        {
            ParagraphEndTagInMoveFromRange,
            Other
        };

        private static object AcceptParagraphEndTagsInMoveFromTransform(XNode node)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                if (W.BlockLevelContentContainers.Contains(element.Name))
                {
                    var groupedBodyChildren = element
                        .Elements()
                        .GroupAdjacent(c =>
                        {
                            BlockContentInfo pi = c.GetParagraphInfo();
                            if (pi.ThisBlockContentElement != null)
                            {
                                bool paragraphMarkIsInMoveFromRange =
                                    pi.ThisBlockContentElement.Elements(W.moveFromRangeStart).Any() &&
                                    !pi.ThisBlockContentElement.Elements(W.moveFromRangeEnd).Any();
                                if (paragraphMarkIsInMoveFromRange)
                                    return MoveFromCollectionType.ParagraphEndTagInMoveFromRange;
                            }
                            XElement previousContentElement = c.ContentElementsBeforeSelf()
                                .Where(e => e.GetParagraphInfo().ThisBlockContentElement != null)
                                .FirstOrDefault();
                            if (previousContentElement != null)
                            {
                                BlockContentInfo pi2 = previousContentElement.GetParagraphInfo();
                                if (c.Name == W.p &&
                                    pi2.ThisBlockContentElement.Elements(W.moveFromRangeStart).Any() &&
                                    !pi2.ThisBlockContentElement.Elements(W.moveFromRangeEnd).Any())
                                    return MoveFromCollectionType.ParagraphEndTagInMoveFromRange;
                            }
                            return MoveFromCollectionType.Other;
                        })
                        .ToList();

                    // If there is only one group, and it's key is MoveFromCollectionType.Other
                    // then there is nothing to do.
                    if (groupedBodyChildren.Count() == 1 &&
                        groupedBodyChildren.First().Key == MoveFromCollectionType.Other)
                    {
                        XElement newElement = new XElement(element.Name,
                            element.Attributes(),
                            groupedBodyChildren.Select(g =>
                            {
                                if (g.Key == MoveFromCollectionType.Other)
                                    return (object)g;

                                // This is a transform that produces the first element in the
                                // collection, except that the paragraph in the descendents is
                                // replaced with a new paragraph that contains all contents of the
                                // existing paragraph, plus subsequent elements in the group
                                // collection, where the paragraph in each of those groups is
                                // collapsed.
                                return CoalesqueParagraphEndTagsInMoveFromTransform(g.First(), g);
                            }));
                        return newElement;
                    }
                    else
                        return new XElement(element.Name,
                            element.Attributes(),
                            element.Nodes().Select(n =>
                                AcceptParagraphEndTagsInMoveFromTransform(n)));
                }
                return new XElement(element.Name,
                    element.Attributes(),
                    element.Nodes().Select(n => AcceptParagraphEndTagsInMoveFromTransform(n)));
            }
            return node;
        }

        private static object AcceptAllOtherRevisionsTransform(XNode node)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                /// Accept inserted text, inserted paragraph marks, etc.
                /// Collapse all w:ins elements.

                if (element.Name == W.ins)
                    return element
                        .Nodes()
                        .Select(n => AcceptAllOtherRevisionsTransform(n));

                /// Remove all of the following elements.  These elements are processed in:
                ///   AcceptDeletedAndMovedFromContentControls
                ///   AcceptMoveFromMoveToTransform
                ///   AcceptDeletedAndMoveFromParagraphMarksTransform
                ///   AcceptParagraphEndTagsInMoveFromTransform
                ///   AcceptMoveFromRanges

                if (element.Name == W.customXmlDelRangeStart ||
                    element.Name == W.customXmlDelRangeEnd ||
                    element.Name == W.customXmlInsRangeStart ||
                    element.Name == W.customXmlInsRangeEnd ||
                    element.Name == W.customXmlMoveFromRangeStart ||
                    element.Name == W.customXmlMoveFromRangeEnd ||
                    element.Name == W.customXmlMoveToRangeStart ||
                    element.Name == W.customXmlMoveToRangeEnd ||
                    element.Name == W.moveFromRangeStart ||
                    element.Name == W.moveFromRangeEnd ||
                    element.Name == W.moveToRangeStart ||
                    element.Name == W.moveToRangeEnd)
                    return null;

                /// Accept revisions in formatting on paragraphs.
                /// Accept revisions in formatting on runs.
                /// Accept revisions for applied styles to a table.
                /// Accept revisions for grid revisions to a table.
                /// Accept revisions for column properties.
                /// Accept revisions for row properties.
                /// Accept revisions for table level property exceptions.
                /// Accept revisions for section properties.
                /// Accept numbering revision in fields.
                /// Accept deleted field code text.
                /// Accept deleted literal text.
                /// Accept inserted cell.

                if (element.Name == W.pPrChange ||
                    element.Name == W.rPrChange ||
                    element.Name == W.tblPrChange ||
                    element.Name == W.tblGridChange ||
                    element.Name == W.tcPrChange ||
                    element.Name == W.trPrChange ||
                    element.Name == W.tblPrExChange ||
                    element.Name == W.sectPrChange ||
                    element.Name == W.numberingChange ||
                    element.Name == W.delInstrText ||
                    element.Name == W.delText ||
                    element.Name == W.cellIns)
                    return null;

                // Accept revisions for deleted math control character.
                // Match m:f/m:fPr/m:ctrlPr/w:del, remove m:f.

                if (element.Name == M.f &&
                    element.Elements(M.fPr).Elements(M.ctrlPr).Elements(W.del).Any())
                    return null;

                // Accept revisions for deleted rows in tables.
                // Match w:tr/w:trPr/w:del, remove w:tr.

                if (element.Name == W.tr &&
                    element.Elements(W.trPr).Elements(W.del).Any())
                    return null;

                // Accept deleted text in paragraphs.

                if (element.Name == W.del)
                    return null;

                // Accept revisions for vertically merged cells.
                //   cellMerge with a parent of tcPr, with attribute w:vMerge="rest" transformed
                //     to <w:vMerge w:val="restart"/>
                //   cellMerge with a parent of tcPr, with attribute w:vMerge="cont" transformed
                //     to <w:vMerge w:val="continue"/>

                if (element.Name == W.cellMerge &&
                    element.Parent.Name == W.tcPr &&
                    (string)element.Attribute(W.vMerge) == "rest")
                    return new XElement(W.vMerge,
                        new XAttribute(W.val, "restart"));
                if (element.Name == W.cellMerge &&
                    element.Parent.Name == W.tcPr &&
                    (string)element.Attribute(W.vMerge) == "cont")
                    return new XElement(W.vMerge,
                        new XAttribute(W.val, "continue"));

                // Otherwise do identity clone.
                return new XElement(element.Name,
                    element.Attributes(),
                    element.Nodes().Select(n => AcceptAllOtherRevisionsTransform(n)));
            }
            return node;
        }

        private static object CollapseParagraphTransform(XNode node)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                if (element.Name == W.p)
                    return element.Elements().Where(e => e.Name != W.pPr);
                return new XElement(element.Name,
                    element.Attributes(),
                    element.Nodes().Select(n => CollapseParagraphTransform(n)));
            }
            return node;
        }

        private enum DeletedParagraphCollectionType
        {
            DeletedParagraphMarkContent,
            ParagraphFollowing,
            Other
        };

        private static XElement CoalesqueParagraphDeletedAndMoveFromParagraphMarksTransform(
            IGrouping<DeletedParagraphCollectionType, BlockContentInfo> g,
            IGrouping<DeletedParagraphCollectionType, BlockContentInfo> nextGroup)
        {
            // This function constructs a paragraph.
            XElement newParagraph = new XElement(W.p,
                nextGroup.First().ThisBlockContentElement.Elements(W.pPr),
                g.Select(z => CollapseParagraphTransform(z.ThisBlockContentElement)),
                nextGroup.Select(z => CollapseParagraphTransform(z.ThisBlockContentElement)));

            return newParagraph;
        }

        private static XElement AssembleWithBlockLevelContentControlTransform(XElement element)
        {
            return new XElement(element.Name,
                element.Attributes(),
                element.Elements().Select(e => AcceptDeletedAndMoveFromParagraphMarksTransform(e)));
        }

        /// Accept deleted paragraphs.
        ///
        /// Group together all paragraphs that contain w:p/w:pPr/w:rPr/w:del elements.  Make a
        /// second group for the content element immediately following a paragraph that contains
        /// a w:del element.  The code uses the approach of dealing with paragraph content at
        /// 'levels', ignoring paragraph content at other levels.  Form a new paragraph that
        /// contains the content of the grouped paragraphs with deleted paragraph marks, and the
        /// content of the paragraph immediately following a paragraph that contains a deleted
        /// paragraph mark.  Include in the new paragraph the paragraph properties from the
        /// paragraph following.  When assembling the new paragraph, use a transform that collapses
        /// the paragraph nodes when adding content, thereby preserving custom XML and content
        /// controls.

        private static void AnnotateBlockContentElements(XElement contentContainer)
        {
            // For convenience, there is a ParagraphInfo annotation on the contentContainer.
            // It contains the same information as the ParagraphInfo annotation on the first
            //   paragraph.
            if (contentContainer.Annotation<BlockContentInfo>() != null)
                return;
            XElement firstContentElement = contentContainer
                .Elements()
                .DescendantsAndSelf()
                .FirstOrDefault(e => e.Name == W.p || e.Name == W.tbl);
            if (firstContentElement == null)
                return;

            // Add the annotation on the contentContainer.
            BlockContentInfo currentContentInfo = new BlockContentInfo()
            {
                PreviousBlockContentElement = null,
                ThisBlockContentElement = firstContentElement,
                NextBlockContentElement = null
            };
            // Add as annotation even though NextParagraph is not set yet.
            contentContainer.AddAnnotation(currentContentInfo);
            while (true)
            {
                currentContentInfo.ThisBlockContentElement.AddAnnotation(currentContentInfo);
                // Find next sibling content element.
                XElement nextContentElement = null;
                XElement current = currentContentInfo.ThisBlockContentElement;
                while (true)
                {
                    nextContentElement = current
                        .ElementsAfterSelf()
                        .DescendantsAndSelf()
                        .FirstOrDefault(e => e.Name == W.p || e.Name == W.tbl);
                    if (nextContentElement != null)
                    {
                        currentContentInfo.NextBlockContentElement = nextContentElement;
                        break;
                    }
                    current = current.Parent;
                    // When we've backed up the tree to the contentContainer, we're done.
                    if (current == contentContainer)
                        return;
                }
                currentContentInfo = new BlockContentInfo()
                {
                    PreviousBlockContentElement = currentContentInfo.ThisBlockContentElement,
                    ThisBlockContentElement = nextContentElement,
                    NextBlockContentElement = null
                };
            }
        }

        private static IEnumerable<BlockContentInfo> IterateBlockContentElements(XElement element)
        {
            XElement current = element.Elements().FirstOrDefault();
            if (current == null)
                yield break;
            AnnotateBlockContentElements(element);
            BlockContentInfo currentBlockContentInfo = element.Annotation<BlockContentInfo>();
            if (currentBlockContentInfo != null)
            {
                while (true)
                {
                    yield return currentBlockContentInfo;
                    if (currentBlockContentInfo.NextBlockContentElement == null)
                        yield break;
                    currentBlockContentInfo = currentBlockContentInfo.NextBlockContentElement.Annotation<BlockContentInfo>();
                }
            }
        }

        public static class PT
        {
            public static XNamespace pt = "http://www.codeplex.com/PowerTools/2009/RevisionAccepter";
            public static XName UniqueId = pt + "UniqueId";
            public static XName RunIds = pt + "RunIds";
        }

        private static void AnnotateRunElementsWithId(XElement element)
        {
            int runId = 0;
            foreach (XElement e in element.Descendants().Where(e => e.Name == W.r))
            {
                if (e.Name == W.r)
                    e.Add(new XAttribute(PT.UniqueId, runId++));
            }
        }

        // TODO - Need to test, need to trim so that Descendants doesn't see runs under text boxes.
        private static void AnnotateContentControlsWithRunIds(XElement element)
        {
            int sdtId = 0;
            foreach (XElement e in element.Descendants(W.sdt))
            {
                // old version
                //e.Add(new XAttribute(PT.RunIds,
                //    e.Descendants(W.r).Select(r => r.Attribute(PT.UniqueId).Value).StringConcatenate(s => s + ",").Trim(',')),
                //    new XAttribute(PT.UniqueId, sdtId++));
                e.Add(new XAttribute(PT.RunIds,
                    e.DescendantsTrimmed(W.txbxContent)
                     .Where(d => d.Name == W.r)
                     .Select(r => r.Attribute(PT.UniqueId).Value)
                     .StringConcatenate(s => s + ",")
                     .Trim(',')),
                    new XAttribute(PT.UniqueId, sdtId++));
            }
        }

        private static XElement AddBlockLevelContentControls(XElement newDocument, XElement original)
        {
            var originalContentControls = original.Descendants(W.sdt).ToList();
            var existingContentControls = newDocument.Descendants(W.sdt).ToList();
            var contentControlsToAdd = originalContentControls
                .Select(occ => occ.Attribute(PT.UniqueId).Value)
                .Except(existingContentControls
                    .Select(ecc => ecc.Attribute(PT.UniqueId).Value));
            foreach (var contentControl in originalContentControls
                .Where(occ => contentControlsToAdd.Contains(occ.Attribute(PT.UniqueId).Value)))
            {
                // TODO - Need a slight modification here.  If there is a paragraph
                // in the content control that contains no runs, then the paragraph isn't included in the
                // content control, because the following triggers off of runs.
                // To see an example of this, see example document "NumberingParagraphPropertiesChange.docxs"

                // find list of runs to surround
                var runIds = contentControl.Attribute(PT.RunIds).Value.Split(',');
                var runs = contentControl.Descendants(W.r).Where(r => runIds.Contains(r.Attribute(PT.UniqueId).Value));
                // find the runs in the new document

                var runsInNewDocument = runs.Select(r => newDocument.Descendants(W.r).First(z => z.Attribute(PT.UniqueId).Value == r.Attribute(PT.UniqueId).Value)).ToList();

                // find common ancestor
                List<XElement> runAncestorIntersection = null;
                foreach (var run in runsInNewDocument)
                {
                    if (runAncestorIntersection == null)
                        runAncestorIntersection = run.Ancestors().ToList();
                    else
                        runAncestorIntersection = run.Ancestors().Intersect(runAncestorIntersection).ToList();
                }
                if (runAncestorIntersection == null)
                    continue;
                XElement commonAncestor = runAncestorIntersection.InDocumentOrder().Last();
                // find child of common ancestor that contains first run
                // find child of common ancestor that contains last run
                // create new common ancestor:
                //   elements before first run child
                //   add content control, and runs from first run child to last run child
                //   elements after last run child
                var firstRunChild = commonAncestor
                    .Elements()
                    .First(c => c.DescendantsAndSelf()
                        .Any(z => z.Name == W.r &&
                             z.Attribute(PT.UniqueId).Value == runsInNewDocument.First().Attribute(PT.UniqueId).Value));
                var lastRunChild = commonAncestor
                    .Elements()
                    .First(c => c.DescendantsAndSelf()
                        .Any(z => z.Name == W.r &&
                             z.Attribute(PT.UniqueId).Value == runsInNewDocument.Last().Attribute(PT.UniqueId).Value));

                /// If the list of runs for the content control is exactly the list of runs for the paragraph, then
                /// create the content control surrounding the paragraph, not surrounding the runs.

                if (commonAncestor.Name == W.p &&
                    commonAncestor.Elements()
                        .Where(e => e.Name != W.pPr &&
                            e.Name != W.commentRangeStart &&
                            e.Name != W.commentRangeEnd)
                        .FirstOrDefault() == firstRunChild &&
                    commonAncestor.Elements()
                        .Where(e => e.Name != W.pPr &&
                            e.Name != W.commentRangeStart &&
                            e.Name != W.commentRangeEnd)
                        .LastOrDefault() == lastRunChild)
                {
                    // replace commonAncestor with content control containing commonAncestor
                    XElement newContentControl = new XElement(contentControl.Name,
                        contentControl.Attributes(),
                        contentControl.Elements().Where(e => e.Name != W.sdtContent),
                        new XElement(W.sdtContent, commonAncestor));

                    XElement newContentControlOrdered = new XElement(contentControl.Name,
                        contentControl.Attributes(),
                        contentControl.Elements().OrderBy(e =>
                        {
                            if (Order_sdt.ContainsKey(e.Name))
                                return Order_sdt[e.Name];
                            return 999;
                        }));

                    commonAncestor.ReplaceWith(newContentControlOrdered);
                    continue;
                }

                List<XElement> elementsBeforeRange = commonAncestor
                    .Elements()
                    .TakeWhile(e => e != firstRunChild)
                    .ToList();
                List<XElement> elementsInRange = commonAncestor
                    .Elements()
                    .SkipWhile(e => e != firstRunChild)
                    .TakeWhile(e => e != lastRunChild.ElementsAfterSelf().FirstOrDefault())
                    .ToList();
                List<XElement> elementsAfterRange = commonAncestor
                    .Elements()
                    .SkipWhile(e => e != lastRunChild.ElementsAfterSelf().FirstOrDefault())
                    .ToList();

                // detatch from current parent
                commonAncestor.Elements().Remove();

                XElement newContentControl2 = new XElement(contentControl.Name,
                    contentControl.Attributes(),
                    contentControl.Elements().Where(e => e.Name != W.sdtContent),
                    new XElement(W.sdtContent, elementsInRange));

                XElement newContentControlOrdered2 = new XElement(newContentControl2.Name,
                    newContentControl2.Attributes(),
                    newContentControl2.Elements().OrderBy(e =>
                    {
                        if (Order_sdt.ContainsKey(e.Name))
                            return Order_sdt[e.Name];
                        return 999;
                    }));

                commonAncestor.Add(
                    elementsBeforeRange,
                    newContentControlOrdered2,
                    elementsAfterRange);
            }
            return newDocument;
        }

        private static Dictionary<XName, int> Order_sdt = new Dictionary<XName, int>
        {
            { W.sdtPr, 10 },
            { W.sdtEndPr, 20 },
            { W.sdtContent, 30 },
            { W.bookmarkStart, 40 },
            { W.bookmarkEnd, 50 },
        };

        private static XElement AcceptDeletedAndMoveFromParagraphMarks(XElement element)
        {
            AnnotateRunElementsWithId(element);
            AnnotateContentControlsWithRunIds(element);
            XElement newElement = (XElement)AcceptDeletedAndMoveFromParagraphMarksTransform(element);
            XElement withBlockLevelContentControls = AddBlockLevelContentControls(newElement, element);
            return withBlockLevelContentControls;
        }

        private static object AcceptDeletedAndMoveFromParagraphMarksTransform(XNode node)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                if (W.BlockLevelContentContainers.Contains(element.Name))
                {
                    var groupedParagraphSiblings = IterateBlockContentElements(element)
                        .GroupAdjacent(c =>
                        {
                            bool paragraphMarkIsDeletedOrMovedFrom = c
                                .ThisBlockContentElement
                                .Elements(W.pPr)
                                .Elements(W.rPr)
                                .Elements()
                                .Where(e => e.Name == W.del || e.Name == W.moveFrom)
                                .Any();
                            if (paragraphMarkIsDeletedOrMovedFrom)
                                return DeletedParagraphCollectionType.DeletedParagraphMarkContent;
                            if (c.PreviousBlockContentElement != null)
                            {
                                paragraphMarkIsDeletedOrMovedFrom = c
                                    .PreviousBlockContentElement
                                    .Elements(W.pPr)
                                    .Elements(W.rPr)
                                    .Elements()
                                    .Where(e => e.Name == W.del || e.Name == W.moveFrom)
                                    .Any();
                                if (c.ThisBlockContentElement.Name == W.p && paragraphMarkIsDeletedOrMovedFrom)
                                    return DeletedParagraphCollectionType.ParagraphFollowing;
                            }
                            return DeletedParagraphCollectionType.Other;
                        })
                        .ToList();

                    // Create a new block level content container.
                    XElement newParagraphParentElement = new XElement(element.Name,
                        element.Attributes(),
                        element.Elements().Where(e => e.Name == W.tcPr),
                        groupedParagraphSiblings.Select((g, i) =>
                        {
                            // THIS IS THE OLD CODE
                            //if (g.Key == DeletedParagraphCollectionType.Other)
                            //    return g.Select(n =>
                            //        AcceptDeletedAndMoveFromParagraphMarksTransform(n.ThisBlockContentElement));
                            if (g.Key == DeletedParagraphCollectionType.Other)
                                return g.Select(n =>
                                    AssembleWithBlockLevelContentControlTransform(n.ThisBlockContentElement));

                            // This is a transform that produces the first element in the
                            // collection; the paragraph in the descendents is replaced with a
                            // new paragraph that contains all contents of the existing paragraph,
                            // plus subsequent elements in the group collection, where the
                            // paragraph in each of those groups is collapsed.

                            if (g.Key ==
                                DeletedParagraphCollectionType.DeletedParagraphMarkContent)
                            {
                                if (i < groupedParagraphSiblings.Count() - 1)
                                {
                                    var nextG = groupedParagraphSiblings.ElementAt(i + 1);
                                    if (nextG.Key ==
                                        DeletedParagraphCollectionType.ParagraphFollowing)
                                    {
                                        XElement newParagraph = (XElement)
                                            CoalesqueParagraphDeletedAndMoveFromParagraphMarksTransform(
                                                g, nextG);
                                        return (object)newParagraph;
                                    }
                                    if (AllContentDeleted(g))
                                        return null;
                                    // todo need to handle if not all content is deleted
                                }
                                return g.Select(n =>
                                    AcceptDeletedAndMoveFromParagraphMarksTransform(n.ThisBlockContentElement));
                            }

                            // Groups with DeletedParagraphCollectionType.ParagraphFollowing
                            // have their content incorporated when processing
                            // DeletedParagraphCollectionType.DeletedParagraphMarkContent.

                            return null;
                        }),
                        element.Elements().Where(e => e.Name == W.sectPr)
                    );
                    return newParagraphParentElement;
                }

                // Otherwise, identity clone.
                return new XElement(element.Name,
                    element.Attributes(),
                    element.Nodes().Select(n => AcceptDeletedAndMoveFromParagraphMarksTransform(n)));
            }
            return node;
        }

        private static bool AllContentDeleted(IGrouping<DeletedParagraphCollectionType, BlockContentInfo> g)
        {
            var someNotDeleted = g.Any(b => ! AllParaContentIsDeleted(b.ThisBlockContentElement));
            return ! someNotDeleted;
        }

        // Determine if the paragraph contains any content that is not deleted.
        private static bool AllParaContentIsDeleted(XElement p)
        {
            // needs collapse
            // dir, bdo, sdt, ins, moveTo, smartTag
            var testP = (XElement)CollapseTransform(p);

            var childElements = testP.Elements();
            var contentElements = childElements
                .Where(ce =>
                {
                    var b = IsRunContent(ce.Name);
                    if (b != null)
                        return (bool)b;
                    throw new Exception("Internal error 20, found element " + ce.Name.ToString());
                });
            if (contentElements.Any())
                return false;
            return true;
        }

        // dir, bdo, sdt, ins, moveTo, smartTag
        private static object CollapseTransform(XNode node)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                if (element.Name == W.dir ||
                    element.Name == W.bdr ||
                    element.Name == W.ins ||
                    element.Name == W.moveTo ||
                    element.Name == W.smartTag)
                    return element.Elements();

                if (element.Name == W.sdt)
                    return element.Elements(W.sdtContent).Elements();

                if (element.Name == W.pPr)
                    return null;

                return new XElement(element.Name,
                    element.Attributes(),
                    element.Nodes().Select(n => CollapseTransform(n)));
            }
            return node;
        }

        private static bool? IsRunContent(XName ceName)
        {
            // is content
            // r, fldSimple, hyperlink, oMath, oMathPara, subDoc
            if (ceName == W.r ||
                ceName == W.fldSimple ||
                ceName == W.hyperlink ||
                ceName == W.oMath ||
                ceName == W.subDoc)
                return true;

            // not content
            // bookmarkStart, bookmarkEnd, commentRangeStart, commentRangeEnd, del, moveFrom, proofErr
            if (ceName == W.bookmarkStart ||
                ceName == W.bookmarkEnd ||
                ceName == W.commentRangeStart ||
                ceName == W.commentRangeEnd ||
                ceName == W.del ||
                ceName == W.moveFrom ||
                ceName == W.proofErr)
                return false;

            return null;
        }

        private static IEnumerable<Tag> DescendantAndSelfTags(XElement element)
        {
            yield return new Tag
            {
                Element = element,
                TagType = TagTypeEnum.Element
            };
            Stack<IEnumerator<XElement>> iteratorStack = new Stack<IEnumerator<XElement>>();
            iteratorStack.Push(element.Elements().GetEnumerator());
            while (iteratorStack.Count > 0)
            {
                if (iteratorStack.Peek().MoveNext())
                {
                    XElement currentXElement = iteratorStack.Peek().Current;
                    if (!currentXElement.Nodes().Any())
                    {
                        yield return new Tag()
                        {
                            Element = currentXElement,
                            TagType = TagTypeEnum.EmptyElement
                        };
                        continue;
                    }
                    yield return new Tag()
                    {
                        Element = currentXElement,
                        TagType = TagTypeEnum.Element
                    };
                    iteratorStack.Push(currentXElement.Elements().GetEnumerator());
                    continue;
                }
                iteratorStack.Pop();
                if (iteratorStack.Count > 0)
                    yield return new Tag()
                    {
                        Element = iteratorStack.Peek().Current,
                        TagType = TagTypeEnum.EndElement
                    };
            }
            yield return new Tag
            {
                Element = element,
                TagType = TagTypeEnum.EndElement
            };
        }

        private class PotentialInRangeElements
        {
            public List<XElement> PotentialStartElementTagsInRange;
            public List<XElement> PotentialEndElementTagsInRange;

            public PotentialInRangeElements()
            {
                PotentialStartElementTagsInRange = new List<XElement>();
                PotentialEndElementTagsInRange = new List<XElement>();
            }
        }

        private enum TagTypeEnum
        {
            Element,
            EndElement,
            EmptyElement
        }

        private class Tag
        {
            public XElement Element;
            public TagTypeEnum TagType;
        }

        private static object AcceptDeletedAndMovedFromContentControlsTransform(XNode node,
            XElement[] contentControlElementsToCollapse,
            XElement[] moveFromElementsToDelete)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                if (element.Name == W.sdt && contentControlElementsToCollapse.Contains(element))
                    return element
                        .Element(W.sdtContent)
                        .Nodes()
                        .Select(n => AcceptDeletedAndMovedFromContentControlsTransform(
                            n, contentControlElementsToCollapse, moveFromElementsToDelete));
                if (moveFromElementsToDelete.Contains(element))
                    return null;
                return new XElement(element.Name,
                    element.Attributes(),
                    element.Nodes().Select(n => AcceptDeletedAndMovedFromContentControlsTransform(
                        n, contentControlElementsToCollapse, moveFromElementsToDelete)));
            }
            return node;
        }

        private static XElement AcceptDeletedAndMovedFromContentControls(XElement documentRootElement)
        {
            string wordProcessingNamespacePrefix = documentRootElement.GetPrefixOfNamespace(W.w);

            // The following lists contain the elements that are between start/end elements.
            List<XElement> startElementTagsInDeleteRange = new List<XElement>();
            List<XElement> endElementTagsInDeleteRange = new List<XElement>();
            List<XElement> startElementTagsInMoveFromRange = new List<XElement>();
            List<XElement> endElementTagsInMoveFromRange = new List<XElement>();

            // Following are the elements that *may* be in a range that has both start and end
            // elements.
            Dictionary<string, PotentialInRangeElements> potentialDeletedElements =
                new Dictionary<string, PotentialInRangeElements>();
            Dictionary<string, PotentialInRangeElements> potentialMoveFromElements =
                new Dictionary<string, PotentialInRangeElements>();

            foreach (var tag in DescendantAndSelfTags(documentRootElement))
            {
                if (tag.Element.Name == W.customXmlDelRangeStart)
                {
                    string id = tag.Element.Attribute(W.id).Value;
                    potentialDeletedElements.Add(id, new PotentialInRangeElements());
                    continue;
                }
                if (tag.Element.Name == W.customXmlDelRangeEnd)
                {
                    string id = tag.Element.Attribute(W.id).Value;
                    if (potentialDeletedElements.ContainsKey(id))
                    {
                        startElementTagsInDeleteRange.AddRange(
                            potentialDeletedElements[id].PotentialStartElementTagsInRange);
                        endElementTagsInDeleteRange.AddRange(
                            potentialDeletedElements[id].PotentialEndElementTagsInRange);
                        potentialDeletedElements.Remove(id);
                    }
                    continue;
                }
                if (tag.Element.Name == W.customXmlMoveFromRangeStart)
                {
                    string id = tag.Element.Attribute(W.id).Value;
                    potentialMoveFromElements.Add(id, new PotentialInRangeElements());
                    continue;
                }
                if (tag.Element.Name == W.customXmlMoveFromRangeEnd)
                {
                    string id = tag.Element.Attribute(W.id).Value;
                    if (potentialMoveFromElements.ContainsKey(id))
                    {
                        startElementTagsInMoveFromRange.AddRange(
                            potentialMoveFromElements[id].PotentialStartElementTagsInRange);
                        endElementTagsInMoveFromRange.AddRange(
                            potentialMoveFromElements[id].PotentialEndElementTagsInRange);
                        potentialMoveFromElements.Remove(id);
                    }
                    continue;
                }
                if (tag.Element.Name == W.sdt)
                {
                    if (tag.TagType == TagTypeEnum.Element)
                    {
                        foreach (var id in potentialDeletedElements)
                            id.Value.PotentialStartElementTagsInRange.Add(tag.Element);
                        foreach (var id in potentialMoveFromElements)
                            id.Value.PotentialStartElementTagsInRange.Add(tag.Element);
                        continue;
                    }
                    if (tag.TagType == TagTypeEnum.EmptyElement)
                    {
                        foreach (var id in potentialDeletedElements)
                        {
                            id.Value.PotentialStartElementTagsInRange.Add(tag.Element);
                            id.Value.PotentialEndElementTagsInRange.Add(tag.Element);
                        }
                        foreach (var id in potentialMoveFromElements)
                        {
                            id.Value.PotentialStartElementTagsInRange.Add(tag.Element);
                            id.Value.PotentialEndElementTagsInRange.Add(tag.Element);
                        }
                        continue;
                    }
                    if (tag.TagType == TagTypeEnum.EndElement)
                    {
                        foreach (var id in potentialDeletedElements)
                            id.Value.PotentialEndElementTagsInRange.Add(tag.Element);
                        foreach (var id in potentialMoveFromElements)
                            id.Value.PotentialEndElementTagsInRange.Add(tag.Element);
                        continue;
                    }
                    throw new PowerToolsInvalidDataException("Should not have reached this point.");
                }
                if (potentialMoveFromElements.Count() > 0 &&
                    tag.Element.Name != W.moveFromRangeStart &&
                    tag.Element.Name != W.moveFromRangeEnd &&
                    tag.Element.Name != W.customXmlMoveFromRangeStart &&
                    tag.Element.Name != W.customXmlMoveFromRangeEnd)
                {
                    if (tag.TagType == TagTypeEnum.Element)
                    {
                        foreach (var id in potentialMoveFromElements)
                            id.Value.PotentialStartElementTagsInRange.Add(tag.Element);
                        continue;
                    }
                    if (tag.TagType == TagTypeEnum.EmptyElement)
                    {
                        foreach (var id in potentialMoveFromElements)
                        {
                            id.Value.PotentialStartElementTagsInRange.Add(tag.Element);
                            id.Value.PotentialEndElementTagsInRange.Add(tag.Element);
                        }
                        continue;
                    }
                    if (tag.TagType == TagTypeEnum.EndElement)
                    {
                        foreach (var id in potentialMoveFromElements)
                            id.Value.PotentialEndElementTagsInRange.Add(tag.Element);
                        continue;
                    }
                }
            }

            var contentControlElementsToCollapse = startElementTagsInDeleteRange
                .Intersect(endElementTagsInDeleteRange)
                .ToArray();
            var elementsToDeleteBecauseMovedFrom = startElementTagsInMoveFromRange
                .Intersect(endElementTagsInMoveFromRange)
                .ToArray();
            if (contentControlElementsToCollapse.Length > 0 ||
                elementsToDeleteBecauseMovedFrom.Length > 0)
            {
                var newDoc = AcceptDeletedAndMovedFromContentControlsTransform(documentRootElement,
                    contentControlElementsToCollapse, elementsToDeleteBecauseMovedFrom);
                return newDoc as XElement;
            }
            else
                return documentRootElement;
        }

        private static object AcceptMoveFromRangesTransform(XNode node,
            XElement[] elementsToDelete)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                if (elementsToDelete.Contains(element))
                    return null;
                return new XElement(element.Name,
                    element.Attributes(),
                    element.Nodes().Select(n =>
                        AcceptMoveFromRangesTransform(n, elementsToDelete)));
            }
            return node;
        }

        private static object CoalesqueParagraphEndTagsInMoveFromTransform(XNode node,
            IGrouping<MoveFromCollectionType, XElement> g)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                if (element.Name == W.p)
                    return new XElement(W.p,
                        element.Attributes(),
                        element.Elements(),
                        g.Skip(1).Select(p => CollapseParagraphTransform(p)));
                else
                    return new XElement(element.Name,
                        element.Attributes(),
                        element.Nodes().Select(n =>
                            CoalesqueParagraphEndTagsInMoveFromTransform(n, g)));
            }
            return node;
        }

        private enum DeletedCellCollectionType
        {
            DeletedCell,
            Other
        };

        // For each table row, group deleted cells plus the cell before any deleted cell.
        // Produce a new cell that has gridSpan set appropriately for group, and clone everything
        // else.
        private static object AcceptDeletedCellsTransform(XNode node)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                if (element.Name == W.tr)
                {
                    var groupedCells = element
                        .Elements()
                        .GroupAdjacent(e =>
                        {
                            XElement cellAfter = e.ElementsAfterSelf(W.tc).FirstOrDefault();
                            bool cellAfterIsDeleted = cellAfter != null &&
                                cellAfter.Descendants(W.cellDel).Any();
                            if (e.Name == W.tc &&
                                (cellAfterIsDeleted || e.Descendants(W.cellDel).Any()))
                            {
                                var a = new
                                {
                                    CollectionType = DeletedCellCollectionType.DeletedCell,
                                    Disambiguator = new[] { e }
                                        .Concat(e.SiblingsBeforeSelfReverseDocumentOrder())
                                        .Where(z => z.Name == W.tc &&
                                            !z.Descendants(W.cellDel).Any())
                                        .FirstOrDefault()
                                };
                                return a;
                            }
                            var a2 = new
                            {
                                CollectionType = DeletedCellCollectionType.Other,
                                Disambiguator = e
                            };
                            return a2;
                        });
                    var tr = new XElement(W.tr,
                        groupedCells.Select(g =>
                        {
                            if (g.Key.CollectionType == DeletedCellCollectionType.DeletedCell
                                && g.First().Descendants(W.cellDel).Any())
                                return null;
                            if (g.Key.CollectionType == DeletedCellCollectionType.Other)
                                return (object)g;
                            XElement gridSpanElement = g
                                .First()
                                .Elements(W.tcPr)
                                .Elements(W.gridSpan)
                                .FirstOrDefault();
                            int gridSpan = gridSpanElement != null ?
                                (int)gridSpanElement.Attribute(W.val) :
                                1;
                            int newGridSpan = gridSpan + g.Count() - 1;
                            XElement currentTcPr = g.First().Elements(W.tcPr).FirstOrDefault();
                            XElement newTcPr = new XElement(W.tcPr,
                                currentTcPr != null ? currentTcPr.Attributes() : null,
                                new XElement(W.gridSpan,
                                    new XAttribute(W.val, newGridSpan)),
                                currentTcPr.Elements().Where(e => e.Name != W.gridSpan));
                            var orderedTcPr = new XElement(W.tcPr,
                                newTcPr.Elements().OrderBy(e =>
                                {
                                    if (Order_tcPr.ContainsKey(e.Name))
                                        return Order_tcPr[e.Name];
                                    return 999;
                                }));
                            XElement newTc = new XElement(W.tc,
                                orderedTcPr,
                                g.First().Elements().Where(e => e.Name != W.tcPr));
                            return (object)newTc;
                        }));
                    return tr;
                }

                // Identity clone
                return new XElement(element.Name,
                    element.Attributes(),
                    element.Nodes().Select(n => AcceptDeletedCellsTransform(n)));
            }
            return node;
        }

#if false
      <w:tr>
        <w:tc>
          <w:tcPr>
            <w:tcW w:w="5016"
                   w:type="dxa" />
          </w:tcPr>
        </w:tc>
      </w:tr>
#endif
        private static XName[] BlockLevelElements = new[] {
            W.p,
            W.tbl,
            W.sdt,
            W.del,
            W.ins,
            M.oMath,
            M.oMathPara,
            W.moveTo,
        };

        private static object RemoveRowsLeftEmptyByMoveFrom(XNode node)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                if (element.Name == W.tr)
                {
                    var nonEmptyCells = element.Elements(W.tc).Any(tc => tc.Elements().Any(tcc => BlockLevelElements.Contains(tcc.Name)));
                    if (nonEmptyCells)
                    {
                        return new XElement(element.Name,
                            element.Attributes(),
                            element.Nodes().Select(n => RemoveRowsLeftEmptyByMoveFrom(n)));
                    }
                    return null;
                }

                return new XElement(element.Name,
                    element.Attributes(),
                    element.Nodes().Select(n => RemoveRowsLeftEmptyByMoveFrom(n)));
            }
            return node;
        }

        public static XName[] TrackedRevisionsElements = new[]
        {
            W.cellDel,
            W.cellIns,
            W.cellMerge,
            W.customXmlDelRangeEnd,
            W.customXmlDelRangeStart,
            W.customXmlInsRangeEnd,
            W.customXmlInsRangeStart,
            W.del,
            W.delInstrText,
            W.delText,
            W.ins,
            W.moveFrom,
            W.moveFromRangeEnd,
            W.moveFromRangeStart,
            W.moveTo,
            W.moveToRangeEnd,
            W.moveToRangeStart,
            W.numberingChange,
            W.pPrChange,
            W.rPrChange,
            W.sectPrChange,
            W.tblGridChange,
            W.tblPrChange,
            W.tblPrExChange,
            W.tcPrChange,
            W.trPrChange,
        };

        public static bool PartHasTrackedRevisions(OpenXmlPart part)
        {
            return part.GetXDocument()
                .Descendants()
                .Any(e => TrackedRevisionsElements.Contains(e.Name));
        }

        public static bool HasTrackedRevisions(WmlDocument document)
        {
            using (OpenXmlMemoryStreamDocument streamDoc = new OpenXmlMemoryStreamDocument(document))
            {
                using (WordprocessingDocument wdoc = streamDoc.GetWordprocessingDocument())
                {
                    return RevisionAccepter.HasTrackedRevisions(wdoc);
                }
            }
        }

        public static bool HasTrackedRevisions(WordprocessingDocument doc)
        {
            if (PartHasTrackedRevisions(doc.MainDocumentPart))
                return true;
            foreach (var part in doc.MainDocumentPart.HeaderParts)
                if (PartHasTrackedRevisions(part))
                    return true;
            foreach (var part in doc.MainDocumentPart.FooterParts)
                if (PartHasTrackedRevisions(part))
                    return true;
            if (doc.MainDocumentPart.EndnotesPart != null)
                if (PartHasTrackedRevisions(doc.MainDocumentPart.EndnotesPart))
                    return true;
            if (doc.MainDocumentPart.FootnotesPart != null)
                if (PartHasTrackedRevisions(doc.MainDocumentPart.FootnotesPart))
                    return true;
            return false;
        }
    }

    public partial class WmlDocument : OpenXmlPowerToolsDocument
    {
        public WmlDocument AcceptRevisions(WmlDocument document)
        {
            return RevisionAccepter.AcceptRevisions(document);
        }
        public bool HasTrackedRevisions(WmlDocument document)
        {
            return RevisionAccepter.HasTrackedRevisions(document);
        }
    }

    public class BlockContentInfo
    {
        public XElement PreviousBlockContentElement;
        public XElement ThisBlockContentElement;
        public XElement NextBlockContentElement;
    }

    public static class RevisionAccepterExtensions
    {
        private static void InitializeParagraphInfo(XElement contentContext)
        {
            if (!(W.BlockLevelContentContainers.Contains(contentContext.Name)))
                throw new ArgumentException(
                    "GetParagraphInfo called for element that is not child of content container");
            XElement prev = null;
            foreach (var content in contentContext.Elements())
            {
                // This may return null, indicating that there is no descendant paragraph.  For
                // example, comment elements have no descendant elements.
                XElement paragraph = content
                    .DescendantsAndSelf()
                    .Where(e => e.Name == W.p || e.Name == W.tc || e.Name == W.txbxContent)
                    .FirstOrDefault();
                if (paragraph != null &&
                    (paragraph.Name == W.tc || paragraph.Name == W.txbxContent))
                    paragraph = null;
                BlockContentInfo pi = new BlockContentInfo()
                {
                    PreviousBlockContentElement = prev,
                    ThisBlockContentElement = paragraph
                };
                content.AddAnnotation(pi);
                prev = content;
            }
        }

        public static BlockContentInfo GetParagraphInfo(this XElement contentElement)
        {
            BlockContentInfo paragraphInfo = contentElement.Annotation<BlockContentInfo>();
            if (paragraphInfo != null)
                return paragraphInfo;
            InitializeParagraphInfo(contentElement.Parent);
            return contentElement.Annotation<BlockContentInfo>();
        }

        public static IEnumerable<XElement> ContentElementsBeforeSelf(this XElement element)
        {
            XElement current = element;
            while (true)
            {
                BlockContentInfo pi = current.GetParagraphInfo();
                if (pi.PreviousBlockContentElement == null)
                    yield break;
                yield return pi.PreviousBlockContentElement;
                current = pi.PreviousBlockContentElement;
            }
        }
    }
}

/// Markup that this code processes:
/// 
/// celDel
///   Method: AcceptDeletedCellsTransform
///   Sample document: HorizontallyMergedCells.docx
///   Semantics:
///     Group consecutive deleted cells, and remove them.
///     Adjust the cell before deleted cells:
///       Increase gridSpan by the number of deleted cells that are removed.
///   
/// celIns
///   Method: AcceptAllOtherRevisionsTransform
///   Sample document: HorizontallyMergedCells11.docx
///   Semantics:
///     Remove these elements.
///   
/// cellMerge
///   Method: AcceptAllOtherRevisionsTransform
///   Sample document: MergedCell.docx
///   Semantics:
///     Transform cellMerge with a parent of tcPr, with attribute w:vMerge="rest"
///       to <w:vMerge w:val="restart"/>.
///     Transform cellMerge with a parent of tcPr, with attribute w:vMerge="cont"
///       to <w:vMerge w:val="continue"/>
/// 
/// customXmlDelRangeStart
/// customXmlDelRangeEnd
/// customXmlMoveFromRangeStart
/// customXmlMoveFromRangeEnd
///   Method: AcceptDeletedAndMovedFromContentControls
///   Reviewed: tristan and zeyad ****************************************
///   Semantics:
///     Find pairs of start/end elements, matching id attributes.  Collapse sdt
///       elements that have both start and end tags in a range.
///   
/// customXmlInsRangeStart
/// customXmlInsRangeEnd
/// customXmlMoveToRangeStart
/// customXmlMoveToRangeEnd
///   Method: AcceptAllOtherRevisionsTransform
///   Reviewed: tristan and zeyad ****************************************
///   Semantics:
///     Remove these elements.
///   
/// del (deleted math control character)
///   Method: AcceptAllOtherRevisionsTransform
///   Sample document: DeletedMathControlCharacter.docx
///   Reviewed: zeyad ***************************
///   Semantics:
///     Match m:f/m:fPr/m:ctrlPr/w:del, remove m:f.
/// 
/// del (deleted run content)
///   Method: AcceptAllOtherRevisionsTransform
///   Reviewed: zeyad ***************************
///   Semantics:
///     Remove these elements and descendant elements.
///   
/// del (deleted paragraph mark)
///   Method: AcceptDeletedAndMoveFromParagraphMarksTransform
///   Sample document: VariousTableRevisions.docx (deleted paragraph mark in paragraph in
///     content control)
///   Reviewed: tristan and zeyad ****************************************
///   Semantics:
///     Find all adjacent paragraps that have this element.
///     Group adjacent paragraphs plus the paragraph following paragraph that has this element.
///     Replace grouped paragraphs with a new paragraph containing the content from all grouped
///       paragraphs.  Use the paragraph properties from the first paragraph in the group.
/// 
/// del (deleted table row)
///   Method: AcceptAllOtherRevisionsTransform
///   Sample document: VariousTableRevisions.docx 
///   Reviewed: zeyad ***************************
///   Semantics:
///     Match w:tr/w:trPr/w:del, remove w:tr.
/// 
/// delText
///   Method: AcceptAllOtherRevisionsTransform
///   Sample document: MovedText.docx
///   Reviewed: zeyad ***************************
///   Semantics:
///     Remove these elements.
/// 
/// delInstrText (deleted field code)
///   Method: AcceptAllOtherRevisionsTransform
///   Sample document: NumberingParagraphPropertiesChange.docx
///   Reviewed: zeyad ***************************
///   Semantics:
///     Remove these elements.
/// 
/// ins (inserted math control character)
///   Method: AcceptAllOtherRevisionsTransform
///   Sample document: InsertedMathControlCharacter.docx
///   Reviewed: zeyad ***************************
///   Semantics:
///     Remove these elements.
///   
/// ins (inserted numbering properties)
///   Method: AcceptAllOtherRevisionsTransform
///   Sample document: InsertedNumberingProperties.docx
///   Reviewed: zeyad ***************************
///   Semantics:
///     Remove these elements.
/// 
/// ins (inserted paragraph)
///   Method: AcceptAllOtherRevisionsTransform
///   Sample document: InsertedParagraphsAndRuns.docx
///   Reviewed: zeyad ***************************
///   Semantics:
///     Remove these elements.
///   
/// ins (inserted run content)
///   Method: AcceptAllOtherRevisionsTransform
///   Sample document: InsertedParagraphsAndRuns.docx
///   Reviewed: zeyad ***************************
///   Semantics:
///     Collapse these elements.
/// 
/// ins (inserted table row)
///   Method: AcceptAllOtherRevisionsTransform
///   Sample document: VariousTableRevisions.docx
///   Reviewed: zeyad ***************************
///   Semantics:
///     Remove these elements.
/// 
/// moveTo (move destination paragraph mark)
///   Method: AcceptMoveFromMoveToTransform
///   Sample document: MovedText.docx
///   Reviewed: zeyad ***************************
///   Semantics:
///     Remove these elements.
///   
/// moveTo (move destination run content)
///   Method: AcceptMoveFromMoveToTransform
///   Sample document: MovedText.docx
///   Reviewed: zeyad ***************************
///   Semantics:
///     Collapse these elements.
/// 
/// moveFrom (move source paragraph mark)
///   Methods: AcceptDeletedAndMoveFromParagraphMarksTransform, AcceptParagraphEndTagsInMoveFromTransform
///   Sample document: MovedText.docx
///   Reviewed: tristan and zeyad ****************************************
///   Semantics:
///     Find all adjacent paragraps that have this element or deleted paragraph mark.
///     Group adjacent paragraphs plus the paragraph following paragraph that has this element.
///     Replace grouped paragraphs with a new paragraph containing the content from all grouped
///       paragraphs.
///     This is handled in the same code that handles del (deleted paragraph mark).
/// 
/// moveFrom (move source run content)
///   Method: AcceptMoveFromMoveToTransform
///   Sample document: MovedText.docx
///   Reviewed: zeyad ***************************
///   Semantics:
///     Remove these elements.
/// 
/// moveFromRangeStart
/// moveFromRangeEnd
///   Method: AcceptMoveFromRanges
///   Sample document: MovedText.docx
///   Semantics:
///     Find pairs of elements.  Remove all elements that have both start and end tags in a
///       range.
/// 
/// moveToRangeStart
/// moveToRangeEnd
///   Method: AcceptAllOtherRevisionsTransform
///   Sample document: MovedText.docx
///   Reviewed: zeyad ***************************
///   Semantics:
///     Remove these elements.
/// 
/// numberingChange (previous numbering field properties)
///   Method: AcceptAllOtherRevisionsTransform
///   Sample document: NumberingFieldPropertiesChange.docx 
///   Semantics:
///     Remove these elements.
/// 
/// numberingChange (previous paragraph numbering properties)
///   Method: AcceptAllOtherRevisionsTransform
///   Sample document: NumberingFieldPropertiesChange.docx 
///   Semantics:
///     Remove these elements.
/// 
/// pPrChange (revision information for paragraph properties)
///   Method: AcceptAllOtherRevisionsTransform
///   Sample document: ParagraphAndRunPropertyRevisions.docx 
///   Reviewed: zeyad ***************************
///   Semantics:
///     Remove these elements.
/// 
/// rPrChange (revision information for run properties)
///   Method: AcceptAllOtherRevisionsTransform
///   Sample document: ParagraphAndRunPropertyRevisions.docx
///   Sample document: VariousTableRevisions.docx
///   Reviewed: zeyad ***************************
///   Semantics:
///     Remove these elements.
///   
/// rPrChange (revision information for run properties on the paragraph mark)
///   Method: AcceptAllOtherRevisionsTransform
///   Sample document: ParagraphAndRunPropertyRevisions.docx 
///   Reviewed: zeyad ***************************
///   Semantics:
///     Remove these elements.
///   
/// sectPrChange
///   Method: AcceptAllOtherRevisionsTransform
///   Sample document: SectionPropertiesChange.docx
///   Reviewed: zeyad ***************************
///   Semantics:
///     Remove these elements.
///   
/// tblGridChange
///   Method: AcceptAllOtherRevisionsTransform
///   Sample document: TableGridChange.docx
///   Sample document: VariousTableRevisions.docx
///   Reviewed: zeyad ***************************
///   Semantics:
///     Remove these elements.
///   
/// tblPrChange
///   Method: AcceptAllOtherRevisionsTransform
///   Sample document: TableGridChange.docx
///   Sample document: VariousTableRevisions.docx
///   Reviewed: zeyad ***************************
///   Semantics:
///     Remove these elements.
///   
/// tblPrExChange
///   Method: AcceptAllOtherRevisionsTransform
///   Sample document: VariousTableRevisions.docx
///   Reviewed: zeyad ***************************
///   Semantics:
///     Remove these elements.
///   
/// tcPrChange
///   Method: AcceptAllOtherRevisionsTransform
///   Sample document: TableGridChange.docx
///   Sample document: VariousTableRevisions.docx
///   Reviewed: zeyad ***************************
///   Semantics:
///     Remove these elements.
///   
/// trPrChange
///   Method: AcceptAllOtherRevisionsTransform
///   Sample document: VariousTableRevisions.docx
///   Reviewed: zeyad ***************************
///   Semantics:
///     Remove these elements.
/// 
/// The following items need to be addressed in a future release:
/// - inserted run inside deleted paragraph - moveTo is same as insert
/// - must increase w:val attribute of the w:gridSpan element of the
///   cell immediately preceding the group of deleted cells by the
///   ***sum*** of the values of the w:val attributes of w:gridSpan
///   elements of each of the deleted cells.

