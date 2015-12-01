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
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using DocumentFormat.OpenXml.Packaging;

namespace OpenXmlPowerTools
{
    public partial class WmlDocument : OpenXmlPowerToolsDocument
    {
        public WmlDocument SearchAndReplace(string search, string replace, bool matchCase)
        {
            return TextReplacer.SearchAndReplace(this, search, replace, matchCase);
        }
    }

    public partial class PmlDocument : OpenXmlPowerToolsDocument
    {
        public PmlDocument SearchAndReplace(string search, string replace, bool matchCase)
        {
            return TextReplacer.SearchAndReplace(this, search, replace, matchCase);
        }
    }

    public class TextReplacer
    {
        private class MatchSemaphore
        {
            public int MatchId;
            public MatchSemaphore(int matchId)
            {
                MatchId = matchId;
            }
        }

        private static XObject CloneWithAnnotation(XNode node)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                XElement newElement = new XElement(element.Name,
                    element.Attributes(),
                    element.Nodes().Select(n => CloneWithAnnotation(n)));
                if (element.Annotation<MatchSemaphore>() != null)
                    newElement.AddAnnotation(element.Annotation<MatchSemaphore>());
            }
            return node;
        }

        private static object WmlSearchAndReplaceTransform(XNode node,
            string search, string replace, bool matchCase)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                if (element.Name == W.p)
                {
                    string contents = element.Descendants(W.t).Select(t => (string)t).StringConcatenate();
                    if (contents.Contains(search) ||
                        (!matchCase && contents.ToUpper().Contains(search.ToUpper())))
                    {
                        XElement paragraphWithSplitRuns = new XElement(W.p,
                            element.Attributes(),
                            element.Nodes().Select(n => WmlSearchAndReplaceTransform(n, search,
                                replace, matchCase)));
                        XElement[] subRunArray = paragraphWithSplitRuns
                            .Elements(W.r)
                            .Where(e => {
                                XElement subRunElement = e.Elements().FirstOrDefault(el => el.Name != W.rPr);
                                if (subRunElement == null)
                                    return false;
                                return W.SubRunLevelContent.Contains(subRunElement.Name);
                            })
                            .ToArray();
                        int paragraphChildrenCount = subRunArray.Length;
                        int matchId = 1;
                        foreach (var pc in subRunArray
                            .Take(paragraphChildrenCount - (search.Length - 1))
                            .Select((c, i) => new { Child = c, Index = i, }))
                        {
                            var subSequence = subRunArray.SequenceAt(pc.Index).Take(search.Length);
                            var zipped = subSequence.Zip(search, (pcp, c) => new
                            {
                                ParagraphChildProjection = pcp,
                                CharacterToCompare = c,
                            });
                            bool dontMatch = zipped.Any(z => {
                                if (z.ParagraphChildProjection.Annotation<MatchSemaphore>() != null)
                                    return true;
                                bool b;
                                if (matchCase)
                                    b = z.ParagraphChildProjection.Value != z.CharacterToCompare.ToString();
                                else
                                    b = z.ParagraphChildProjection.Value.ToUpper() != z.CharacterToCompare.ToString().ToUpper();
                                return b;
                            });
                            bool match = !dontMatch;
                            if (match)
                            {
                                foreach (var item in subSequence)
                                    item.AddAnnotation(new MatchSemaphore(matchId));
                                ++matchId;
                            }
                        }

                        // The following code is locally impure, as this is the most expressive way to write it.
                        XElement paragraphWithReplacedRuns = (XElement)CloneWithAnnotation(paragraphWithSplitRuns);
                        for (int id = 1; id < matchId; ++id)
                        {
                            List<XElement> elementsToReplace = paragraphWithReplacedRuns
                                .Elements()
                                .Where(e => {
                                    var sem = e.Annotation<MatchSemaphore>();
                                    if (sem == null)
                                        return false;
                                    return sem.MatchId == id;
                                })
                                .ToList();
                            elementsToReplace.First().AddBeforeSelf(
                                new XElement(W.r,
                                    elementsToReplace.First().Elements(W.rPr),
                                    new XElement(W.t, replace)));
                            elementsToReplace.Remove();
                        }
                        var groupedAdjacentRunsWithIdenticalFormatting =
                            paragraphWithReplacedRuns
                            .Elements()
                            .GroupAdjacent(ce =>
                            {
                                if (ce.Name != W.r)
                                    return "DontConsolidate";
                                if (ce.Elements().Where(e => e.Name != W.rPr).Count() != 1 ||
                                    ce.Element(W.t) == null)
                                    return "DontConsolidate";
                                if (ce.Element(W.rPr) == null)
                                    return "";
                                return ce.Element(W.rPr).ToString(SaveOptions.None);
                            });
                        XElement paragraphWithConsolidatedRuns = new XElement(W.p,
                            groupedAdjacentRunsWithIdenticalFormatting.Select(g =>
                                {
                                    if (g.Key == "DontConsolidate")
                                        return (object)g;
                                    string textValue = g.Select(r => r.Element(W.t).Value).StringConcatenate();
                                    XAttribute xs = null;
                                    if (textValue[0] == ' ' || textValue[textValue.Length - 1] == ' ')
                                        xs = new XAttribute(XNamespace.Xml + "space", "preserve");
                                    return new XElement(W.r,
                                        g.First().Elements(W.rPr),
                                        new XElement(W.t, xs, textValue));
                                }));
                        return paragraphWithConsolidatedRuns;
                    }
                    return element;
                }
                if (element.Name == W.r && element.Elements(W.t).Any())
                {
                    var collectionOfRuns = element.Elements()
                        .Where(e => e.Name != W.rPr)
                        .Select(e =>
                            {
                                if (e.Name == W.t)
                                {
                                    string s = (string)e;
                                    IEnumerable<XElement> collectionOfSubRuns = s.Select(c =>
                                    {
                                        XElement newRun = new XElement(W.r,
                                            element.Elements(W.rPr),
                                            new XElement(W.t,
                                                c == ' ' ?
                                                new XAttribute(XNamespace.Xml + "space", "preserve") :
                                                null, c));
                                        return newRun;
                                    });
                                    return (object)collectionOfSubRuns;
                                }
                                else
                                {
                                    XElement newRun = new XElement(W.r,
                                        element.Elements(W.rPr),
                                        e);
                                    return newRun;
                                }
                            });
                    return collectionOfRuns;
                }
                return new XElement(element.Name,
                    element.Attributes(),
                    element.Nodes().Select(n => WmlSearchAndReplaceTransform(n,
                        search, replace, matchCase)));
            }
            return node;
        }

        private static void WmlSearchAndReplaceInXDocument(XDocument xDocument, string search,
            string replace, bool matchCase)
        {
            XElement newRoot = (XElement)WmlSearchAndReplaceTransform(xDocument.Root,
                search, replace, matchCase);
            xDocument.Elements().First().ReplaceWith(newRoot);
        }

        public static WmlDocument SearchAndReplace(WmlDocument doc, string search, string replace, bool matchCase)
        {
            using (OpenXmlMemoryStreamDocument streamDoc = new OpenXmlMemoryStreamDocument(doc))
            {
                using (WordprocessingDocument document = streamDoc.GetWordprocessingDocument())
                {
                    SearchAndReplace(document, search, replace, matchCase);
                }
                return streamDoc.GetModifiedWmlDocument();
            }
        }

        public static void SearchAndReplace(WordprocessingDocument wordDoc, string search,
            string replace, bool matchCase)
        {
            if (RevisionAccepter.HasTrackedRevisions(wordDoc))
                throw new InvalidDataException(
                    "Search and replace will not work with documents " +
                    "that contain revision tracking.");
            XDocument xDoc;
            xDoc = wordDoc.MainDocumentPart.DocumentSettingsPart.GetXDocument();
            if (xDoc.Descendants(W.trackRevisions).Any())
                throw new InvalidDataException("Revision tracking is turned on for document.");

            xDoc = wordDoc.MainDocumentPart.GetXDocument();
            WmlSearchAndReplaceInXDocument(xDoc, search, replace, matchCase);
            wordDoc.MainDocumentPart.PutXDocument();
            foreach (var part in wordDoc.MainDocumentPart.HeaderParts)
            {
                xDoc = part.GetXDocument();
                WmlSearchAndReplaceInXDocument(xDoc, search, replace, matchCase);
                part.PutXDocument();
            }
            foreach (var part in wordDoc.MainDocumentPart.FooterParts)
            {
                xDoc = part.GetXDocument();
                WmlSearchAndReplaceInXDocument(xDoc, search, replace, matchCase);
                part.PutXDocument();
            }
            if (wordDoc.MainDocumentPart.EndnotesPart != null)
            {
                xDoc = wordDoc.MainDocumentPart.EndnotesPart.GetXDocument();
                WmlSearchAndReplaceInXDocument(xDoc, search, replace, matchCase);
                wordDoc.MainDocumentPart.EndnotesPart.PutXDocument();
            }
            if (wordDoc.MainDocumentPart.FootnotesPart != null)
            {
                xDoc = wordDoc.MainDocumentPart.FootnotesPart.GetXDocument();
                WmlSearchAndReplaceInXDocument(xDoc, search, replace, matchCase);
                wordDoc.MainDocumentPart.FootnotesPart.PutXDocument();
            }
        }

        private static object PmlReplaceTextTransform(XNode node, string search, string replace,
            bool matchCase)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                if (element.Name == A.p)
                {
                    string contents = element.Descendants(A.t).Select(t => (string)t).StringConcatenate();
                    if (contents.Contains(search) ||
                        (!matchCase && contents.ToUpper().Contains(search.ToUpper())))
                    {
                        XElement paragraphWithSplitRuns = new XElement(A.p,
                            element.Attributes(),
                            element.Nodes().Select(n => PmlReplaceTextTransform(n, search,
                                replace, matchCase)));
                        XElement[] subRunArray = paragraphWithSplitRuns
                            .Elements(A.r)
                            .Where(e =>
                            {
                                XElement subRunElement = e.Elements().FirstOrDefault(el => el.Name != A.rPr);
                                if (subRunElement == null)
                                    return false;
                                return subRunElement.Name == A.t;
                            })
                            .ToArray();
                        int paragraphChildrenCount = subRunArray.Length;
                        int matchId = 1;
                        foreach (var pc in subRunArray
                            .Take(paragraphChildrenCount - (search.Length - 1))
                            .Select((c, i) => new { Child = c, Index = i, }))
                        {
                            var subSequence = subRunArray.SequenceAt(pc.Index).Take(search.Length);
                            var zipped = subSequence.Zip(search, (pcp, c) => new
                            {
                                ParagraphChildProjection = pcp,
                                CharacterToCompare = c,
                            });
                            bool dontMatch = zipped.Any(z =>
                            {
                                if (z.ParagraphChildProjection.Annotation<MatchSemaphore>() != null)
                                    return true;
                                bool b;
                                if (matchCase)
                                    b = z.ParagraphChildProjection.Value != z.CharacterToCompare.ToString();
                                else
                                    b = z.ParagraphChildProjection.Value.ToUpper() != z.CharacterToCompare.ToString().ToUpper();
                                return b;
                            });
                            bool match = !dontMatch;
                            if (match)
                            {
                                foreach (var item in subSequence)
                                    item.AddAnnotation(new MatchSemaphore(matchId));
                                ++matchId;
                            }
                        }

                        // The following code is locally impure, as this is the most expressive way to write it.
                        XElement paragraphWithReplacedRuns = (XElement)CloneWithAnnotation(paragraphWithSplitRuns);
                        for (int id = 1; id < matchId; ++id)
                        {
                            List<XElement> elementsToReplace = paragraphWithReplacedRuns
                                .Elements()
                                .Where(e =>
                                {
                                    var sem = e.Annotation<MatchSemaphore>();
                                    if (sem == null)
                                        return false;
                                    return sem.MatchId == id;
                                })
                                .ToList();
                            elementsToReplace.First().AddBeforeSelf(
                                new XElement(A.r,
                                    elementsToReplace.First().Elements(A.rPr),
                                    new XElement(A.t, replace)));
                            elementsToReplace.Remove();
                        }

                        var groupedAdjacentRunsWithIdenticalFormatting =
                            paragraphWithReplacedRuns
                            .Elements()
                            .GroupAdjacent(ce =>
                            {
                                if (ce.Name != A.r)
                                    return "DontConsolidate";
                                if (ce.Elements().Where(e => e.Name != A.rPr).Count() != 1 ||
                                    ce.Element(A.t) == null)
                                    return "DontConsolidate";
                                if (ce.Element(A.rPr) == null)
                                    return "";
                                return ce.Element(A.rPr).ToString(SaveOptions.None);
                            });
                        XElement paragraphWithConsolidatedRuns = new XElement(A.p,
                            groupedAdjacentRunsWithIdenticalFormatting.Select(g =>
                            {
                                if (g.Key == "DontConsolidate")
                                    return (object)g;
                                string textValue = g.Select(r => r.Element(A.t).Value).StringConcatenate();
                                return new XElement(A.r,
                                    g.First().Elements(A.rPr),
                                    new XElement(A.t, textValue));
                            }));
                        return paragraphWithConsolidatedRuns;
                    }
                }
                if (element.Name == A.r && element.Elements(A.t).Any())
                {
                    var collectionOfRuns = element.Elements()
                        .Where(e => e.Name != A.rPr)
                        .Select(e =>
                        {
                            if (e.Name == A.t)
                            {
                                string s = (string)e;
                                IEnumerable<XElement> collectionOfSubRuns = s.Select(c =>
                                {
                                    XElement newRun = new XElement(A.r,
                                        element.Elements(A.rPr),
                                        new XElement(A.t, c));
                                    return newRun;
                                });
                                return (object)collectionOfSubRuns;
                            }
                            else
                            {
                                XElement newRun = new XElement(A.r,
                                    element.Elements(A.rPr),
                                    e);
                                return newRun;
                            }
                        });
                    return collectionOfRuns;
                }
                return new XElement(element.Name,
                    element.Attributes(),
                    element.Nodes().Select(n => PmlReplaceTextTransform(n, search, replace, matchCase)));
            }
            return node;
        }

        public static PmlDocument SearchAndReplace(PmlDocument doc, string search, string replace, bool matchCase)
        {
            using (OpenXmlMemoryStreamDocument streamDoc = new OpenXmlMemoryStreamDocument(doc))
            {
                using (PresentationDocument document = streamDoc.GetPresentationDocument())
                {
                    SearchAndReplace(document, search, replace, matchCase);
                }
                return streamDoc.GetModifiedPmlDocument();
            }
        }

        public static void SearchAndReplace(PresentationDocument pDoc, string search,
            string replace, bool matchCase)
        {
            PresentationPart presentationPart = pDoc.PresentationPart;
            foreach (var slidePart in presentationPart.SlideParts)
            {
                XDocument slideXDoc = slidePart.GetXDocument();
                XElement root = slideXDoc.Root;
                XElement newRoot = (XElement)PmlReplaceTextTransform(root, search, replace, matchCase);
                slidePart.PutXDocument(new XDocument(newRoot));
            }
        }
    }
}
