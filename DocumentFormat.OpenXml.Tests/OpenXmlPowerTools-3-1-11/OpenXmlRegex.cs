/***************************************************************************

Copyright (c) Microsoft Corporation 2012-2014.

This code is licensed using the Microsoft Public License (Ms-PL).  The text of the license can be found here:

http://www.microsoft.com/resources/sharedsource/licensingbasics/publiclicense.mspx

Published at http://OpenXmlDeveloper.org
Resource Center and Documentation: http://openxmldeveloper.org/wiki/w/wiki/powertools-for-open-xml.aspx

Developer: Eric White
Blog: http://www.ericwhite.com
Twitter: @EricWhiteDev
Email: eric@ericwhite.com

***************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using DocumentFormat.OpenXml.Packaging;

namespace OpenXmlPowerTools
{
    public class OpenXmlRegex
    {
        public static int Match(IEnumerable<XElement> content, Regex regex)
        {
            return ReplaceInternal(content, regex, null, null, false, null);
        }

        /*
         * If callback == null
         *     Then returns count of matches in the content
         * If callback != null
         *     Then Match calls Found for each match
         */
        public static int Match(IEnumerable<XElement> content, Regex regex, Action<XElement, Match> found)
        {
            return ReplaceInternal(content, regex, null,
                (x, m) =>
                    {
                        if (found != null)
                            found(x, m);
                        return true;
                    },
                false, null);
        }

        /*
         * If replacement == "new content" && callback == null
         *     Then replaces all matches
         * If replacement == "" && callback == null)
         *     Then deletes all matches
         * If replacement == "new content" && callback != null)
         *     Then the callback can return true / false to indicate whether to replace or not
         *     If the callback returns true once, and false on all subsequent calls, then this method replaces only the first found.
         * If replacement == "" && callback != null)
         *     Then the callback can return true / false to indicate whether to delete or not
         */
        public static int Replace(IEnumerable<XElement> content, Regex regex, string replacement, Func<XElement, Match, bool> doReplacement)
        {
            return ReplaceInternal(content, regex, replacement, doReplacement, false, null);
        }

        /*
         * If replacement == "new content" && callback == null
         *     Then replaces all matches
         * If replacement == "" && callback == null)
         *     Then deletes all matches
         * If replacement == "new content" && callback != null)
         *     Then the callback can return true / false to indicate whether to replace or not
         *     If the callback returns true once, and false on all subsequent calls, then this method replaces only the first found.
         * If replacement == "" && callback != null)
         *     Then the callback can return true / false to indicate whether to delete or not
         * If trackRevisions == true
         *     Then replacement is done using revision tracking markup, with author as the revision tracking author
         * If trackRevisions == true for a PPTX
         *     Then code throws an exception
         */
        public static int Replace(IEnumerable<XElement> content, Regex regex, string replacement, Func<XElement, Match, bool> doReplacement, 
            bool trackRevisions, string author)
        {
            return ReplaceInternal(content, regex, replacement, doReplacement, trackRevisions, author);
        }

        private class ReplaceInternalInfo
        {
            public int Count;
        }

        private static HashSet<XName> RevTrackMarkupWithId = new HashSet<XName>()
        {
            W.cellDel,
            W.cellIns,
            W.cellMerge,
            W.customXmlDelRangeEnd,
            W.customXmlDelRangeStart,
            W.customXmlInsRangeEnd,
            W.customXmlInsRangeStart,
            W.customXmlMoveFromRangeEnd,
            W.customXmlMoveFromRangeStart,
            W.customXmlMoveToRangeEnd,
            W.customXmlMoveToRangeStart,
            W.del,
            W.ins,
            W.moveFrom,
            W.moveFromRangeEnd,
            W.moveFromRangeStart,
            W.moveTo,
            W.moveToRangeEnd,
            W.moveToRangeStart,
            W.pPrChange,
            W.rPrChange,
            W.sectPrChange,
            W.tblGridChange,
            W.tblPrChange,
            W.tblPrExChange,
            W.tcPrChange,
        };

        private static int ReplaceInternal(IEnumerable<XElement> content,
            Regex regex, string replacement, Func<XElement, Match, bool> callback,
            bool trackRevisions, string revisionTrackingAuthor)
        {
            var first = content.FirstOrDefault();
            if (first == null)
                return 0;
            if (first.Name.Namespace == W.w)
            {
                if (! content.Any())
                    return 0;
                var replInfo = new ReplaceInternalInfo() {
                    Count = 0,
                };
                foreach (var c in content)
                {
                    var newC = (XElement)WmlSearchAndReplaceTransform(c, regex, replacement, callback, trackRevisions, revisionTrackingAuthor, replInfo);
                    c.ReplaceNodes(newC.Nodes());
                }
                var root = content.First().AncestorsAndSelf().Last();
                var nextId = (new[] { 0 })
                    .Concat(root.Descendants()
                        .Where(d => RevTrackMarkupWithId.Contains(d.Name))
                        .Attributes(W.id)
                        .Select(a => (int)a)
                    ).Max() + 1;
                var revTrackingWithoutId = root
                    .DescendantsAndSelf()
                    .Where(d => RevTrackMarkupWithId.Contains(d.Name) && d.Attribute(W.id) == null);
                foreach (var item in revTrackingWithoutId)
                    item.Add(new XAttribute(W.id, nextId++));
                var revTrackingWithDuplicateIds = root
                    .DescendantsAndSelf()
                    .Where(d => RevTrackMarkupWithId.Contains(d.Name))
                    .GroupBy(d => (int)d.Attribute(W.id))
                    .Where(g => g.Count() > 1)
                    .ToList();
                foreach (var group in revTrackingWithDuplicateIds)
                {
                    foreach (var gc in group.Skip(1))
                    {
                        gc.Attribute(W.id).Value = nextId.ToString();
                        nextId++;
                    }
                }
                return replInfo.Count;
            }
            else if (first.Name.Namespace == P.p ||
                     first.Name.Namespace == A.a)
            {
                if (trackRevisions)
                    throw new OpenXmlPowerToolsException("PPTX does not support revision tracking");
                var counter = new ReplaceInternalInfo() { Count = 0 };
                foreach (var c in content)
                {
                    var newC = (XElement)PmlSearchAndReplaceTransform(c, regex, replacement, callback, counter);
                    c.ReplaceNodes(newC.Nodes());
                }
                return counter.Count;
            }
            return 0;
        }

        private static object WmlSearchAndReplaceTransform(XNode node, Regex regex, string replacement,
            Func<XElement, Match, bool> callback, bool trackRevisions, string revisionTrackingAuthor, ReplaceInternalInfo replInfo)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                if (element.Name == W.p)
                {
                    var paragraph = element;
                    string contents = element
                        .DescendantsTrimmed(W.txbxContent)
                        .Where(d => d.Name == W.t)
                        .Select(t => (string)t)
                        .StringConcatenate();
                    if (regex.IsMatch(contents))
                    {
                        contents = element
                            .DescendantsTrimmed(W.txbxContent)
                            .Where(d => d.Name == W.t)
                            .Select(t => (string)t)
                            .StringConcatenate();
                        if (regex.IsMatch(contents))
                        {
                            XElement paragraphWithSplitRuns = new XElement(W.p,
                                paragraph.Attributes(),
                                paragraph.Nodes().Select(n => WmlSearchAndReplaceTransform(n, regex, replacement, callback,
                                    trackRevisions, revisionTrackingAuthor, replInfo)));

                            var runsTrimmed = paragraphWithSplitRuns
                                .DescendantsTrimmed(W.txbxContent)
                                .Where(d => d.Name == W.r)
                                .ToList();

                            var charsAndRuns = runsTrimmed
                                .Select(r =>
                                {
                                    if (r.Element(W.t) != null)
                                        return new
                                        {
                                            Ch = r.Element(W.t).Value,
                                            r,
                                        };
                                    else
                                        return new
                                        {
                                            Ch = "\x01",
                                            r,
                                        };
                                })
                                .ToList();

                            var content = charsAndRuns.Select(t => t.Ch).StringConcatenate();
                            var alignedRuns = charsAndRuns.Select(t => t.r).ToArray();

                            var matchCollection = regex.Matches(content);
                            replInfo.Count += matchCollection.Count;
                            if (replacement == null)
                            {
                                if (callback != null)
                                {
                                    foreach (var match in matchCollection.Cast<Match>())
                                        callback(paragraph, match);
                                }
                            }
                            else
                            {
                                foreach (var match in matchCollection.Cast<Match>())
                                {
                                    if (match.Length == 0)
                                        continue;
                                    if (callback == null || callback(paragraph, match))
                                    {
                                        var runCollection = alignedRuns
                                            .Skip(match.Index)
                                            .Take(match.Length)
                                            .ToList(); // uses the Skip / Take special semantics of array to implement efficient finding of sub array

                                        var firstRun = runCollection.First();
                                        var firstRunProperties = firstRun.Elements(W.rPr).FirstOrDefault(); // save away first run properties

                                        if (trackRevisions)
                                        {
                                            if (replacement != null && replacement != "")
                                            {
                                                var newIns = new XElement(W.ins,
                                                    new XAttribute(W.author, revisionTrackingAuthor),
                                                    new XAttribute(W.date, DateTime.Now.ToString("s") + "Z"),
                                                    new XElement(W.r,
                                                        firstRunProperties,
                                                        new XElement(W.t, replacement)));
                                                if (firstRun.Parent.Name == W.ins)
                                                    firstRun.Parent.AddBeforeSelf(newIns);
                                                else
                                                    firstRun.AddBeforeSelf(newIns);
                                            }

                                            foreach (var run in runCollection)
                                            {
                                                var isInIns = run.Parent.Name == W.ins;
                                                if (isInIns)
                                                {
                                                    var parentIns = run.Parent;
                                                    if ((string)parentIns.Attributes(W.author).FirstOrDefault() == revisionTrackingAuthor)
                                                    {
                                                        var parentInsSiblings = parentIns
                                                            .Parent
                                                            .Elements()
                                                            .Where(c => c != parentIns)
                                                            .ToList();
                                                        parentIns.Parent.ReplaceNodes(parentInsSiblings);
                                                    }
                                                    else
                                                    {
                                                        var parentInsSiblings = parentIns
                                                            .Parent
                                                            .Elements()
                                                            .Select(c =>
                                                            {
                                                                if (c == parentIns)
                                                                {
                                                                    var newIns = new XElement(W.ins,
                                                                        parentIns.Attributes(),
                                                                        new XElement(W.del,
                                                                            new XAttribute(W.author, revisionTrackingAuthor),
                                                                            new XAttribute(W.date, DateTime.Now.ToString("s") + "Z"),
                                                                            parentIns.Elements().Select(r => TransformToDelText(r))));
                                                                    return newIns;
                                                                }
                                                                else
                                                                {
                                                                    return c;
                                                                }
                                                            })
                                                            .ToList();
                                                        parentIns.Parent.ReplaceNodes(parentInsSiblings);
                                                    }
                                                }
                                                else
                                                {
                                                    var delRun = new XElement(W.del,
                                                        new XAttribute(W.author, revisionTrackingAuthor),
                                                        new XAttribute(W.date, DateTime.Now.ToString("s") + "Z"),
                                                        TransformToDelText(run));
                                                    run.ReplaceWith(delRun);
                                                }
                                            }
                                        }
                                        else // not tracked revisions
                                        {
                                            foreach (var runToDelete in runCollection.Skip(1).ToList())
                                            {
                                                if (runToDelete.Parent.Name == W.ins)
                                                    runToDelete.Parent.Remove();
                                                else
                                                    runToDelete.Remove();
                                            }

                                            XAttribute xs = null;
                                            if (replacement.Length > 0 && (replacement[0] == ' ' || replacement[replacement.Length - 1] == ' '))
                                                xs = new XAttribute(XNamespace.Xml + "space", "preserve");

                                            var newFirstRun = new XElement(W.r,
                                                firstRun.Element(W.rPr),
                                                new XElement(W.t,
                                                    xs,
                                                    replacement)); // creates a new run with proper run properties

                                            if (firstRun.Parent.Name == W.ins)
                                                firstRun.Parent.ReplaceWith(newFirstRun);
                                            else
                                                firstRun.ReplaceWith(newFirstRun);  // finds firstRun in its parent's list of children, unparents firstRun,
                                            // sets newFirstRun's parent to firstRuns old parent, and inserts in the list
                                            // of children at the right place.
                                        }
                                    }
                                }

                                paragraph = CoalesceContent(paragraphWithSplitRuns);
                            }
                        }
                        return paragraph;
                    }
                    var newEle = new XElement(element.Name,
                        element.Attributes(),
                        element.Nodes().Select(n =>
                        {
                            var e = n as XElement;
                            if (e != null)
                            {
                                if (e.Name == W.pPr || e.Name == W.rPr)
                                    return e;
                                if (e.Name == W.r && (e.Element(W.t) != null) || e.Element(W.tab) != null)
                                    return e;
                                if (e.Name == W.ins && e.Element(W.r) != null && e.Element(W.r).Element(W.t) != null)
                                    return e;
                                var newContent = WmlSearchAndReplaceTransform(e, regex, replacement, callback, trackRevisions, revisionTrackingAuthor, replInfo);
                                return newContent;
                            }
                            return n;
                        }));
                    if (newEle.Name == W.p)
                    {
                        //if (newEle.Descendants(W.ins).Any())
                        //    Console.WriteLine();
                        var newPara = CoalesceContent(newEle);
                        return newPara;
                    }
                    else
                    {
                        return newEle;
                    }
                }
                if (element.Name == W.ins && element.Elements(W.r).Any())
                {
                    var collectionOfCollections = element
                        .Elements()
                        .Select(n => WmlSearchAndReplaceTransform(n, regex, replacement, callback, trackRevisions, revisionTrackingAuthor, replInfo))
                        .ToList();
                    var collectionOfIns = collectionOfCollections
                        .Select(c =>
                        {
                            if (c is IEnumerable<XElement>)
                            {
                                var ix = (IEnumerable<XElement>)c;
                                var collectionOfNewIns = ix
                                    .Select(ixc =>
                                    {
                                        var newIns = new XElement(W.ins,
                                            element.Attributes(),
                                            ixc);
                                        return newIns;
                                    });
                                return collectionOfNewIns;
                            }
                            return c;
                        })
                        .ToList();
                    return collectionOfIns;
                }
                if (element.Name == W.r && element.Elements(W.t).Any())
                {
                    var collectionOfCollections = element.Elements()
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
                                return collectionOfSubRuns;
                            }
                            else
                            {
                                XElement newRun = new XElement(W.r,
                                    element.Elements(W.rPr),
                                    e);
                                return new [] { newRun };
                            }
                        })
                        .ToList();
                    var collectionOfRuns = collectionOfCollections.SelectMany(t => t);
                    return collectionOfRuns;
                }
                return new XElement(element.Name,
                    element.Attributes(),
                    element.Nodes().Select(n => WmlSearchAndReplaceTransform(n, regex, replacement, callback, trackRevisions,
                        revisionTrackingAuthor, replInfo)));
            }
            return node;
        }

        private static XElement CoalesceContent(XElement paragraphWithReplacedRuns)
        {
            var groupedAdjacentRunsWithIdenticalFormatting =
                paragraphWithReplacedRuns
                .Elements()
                .GroupAdjacent(ce =>
                {
                    if (ce.Name != W.r && ce.Name != W.ins && ce.Name != W.del)
                        return "DontConsolidate";
                    if (ce.Name == W.r)
                    {
                        if (ce.Elements().Where(e => e.Name != W.rPr).Count() != 1 ||
                            ce.Element(W.t) == null)
                            return "DontConsolidate";
                        if (ce.Element(W.rPr) == null)
                            return "";
                        return ce.Element(W.rPr).ToString(SaveOptions.None);
                    }
                    if (ce.Name == W.ins)
                    {
                        if (ce.Elements(W.del).Any())
                        {
                            // for w:ins/w:del/w:r/w:delText
                            if (ce.Elements(W.del).Elements(W.r).Elements().Where(e => e.Name != W.rPr).Count() != 1 ||
                                !ce.Elements().Elements().Elements(W.delText).Any())
                                return "DontConsolidate";

                            var authorIns = (string)ce.Attribute(W.author);
                            if (authorIns == null)
                                authorIns = "";

                            var dateInsString = "";
                            var dateIns = ce.Attribute(W.date);
                            if (dateIns != null)
                                dateInsString = ((DateTime)dateIns).ToString("s");

                            var authorDel = (string)ce.Element(W.del).Attribute(W.author);
                            if (authorDel == null)
                                authorDel = "";

                            var dateDelString = "";
                            var dateDel = ce.Element(W.del).Attribute(W.date);
                            if (dateDel != null)
                                dateDelString = ((DateTime)dateDel).ToString("s");

                            return "Wins" +
                                authorIns +
                                dateInsString +
                                authorDel +
                                dateDelString +
                                ce.Elements(W.del).Elements(W.r).Elements(W.rPr).Select(rPr => rPr.ToString(SaveOptions.None)).StringConcatenate();
                        }
                        // w:ins/w:r/w:t
                        if (ce.Elements().Elements().Where(e => e.Name != W.rPr).Count() != 1 ||
                            !ce.Elements().Elements(W.t).Any())
                            return "DontConsolidate";

                        var authorIns2 = (string)ce.Attribute(W.author);
                        if (authorIns2 == null)
                            authorIns2 = "";

                        var dateInsString2 = "";
                        var dateIns2 = ce.Attribute(W.date);
                        if (dateIns2 != null)
                            dateInsString2 = ((DateTime)dateIns2).ToString("s");

                        string key = "Wins2" +
                            authorIns2 +
                            dateIns2 +
                            ce.Elements().Elements(W.rPr).Select(rPr => rPr.ToString(SaveOptions.None)).StringConcatenate();
                        return key;
                    }
                    // else ce.Name == W.del
                    if (ce.Elements(W.r).Elements().Where(e => e.Name != W.rPr).Count() != 1 ||
                        !ce.Elements().Elements(W.delText).Any())
                        return "DontConsolidate";

                    var authorDel2 = (string)ce.Attribute(W.author);
                    if (authorDel2 == null)
                        authorDel2 = "";

                    var dateDelString2 = "";
                    var dateDel2 = ce.Attribute(W.date);
                    if (dateDel2 != null)
                        dateDelString2 = ((DateTime)dateDel2).ToString("s");

                    return "Wdel" +
                        authorDel2 +
                        dateDel2 +
                        ce.Elements(W.r).Elements(W.rPr).Select(rPr => rPr.ToString(SaveOptions.None)).StringConcatenate();

                });
            XElement paragraphWithConsolidatedRuns = new XElement(W.p,
                groupedAdjacentRunsWithIdenticalFormatting.Select(g =>
                {
                    if (g.Key == "DontConsolidate")
                        return (object)g;
                    string textValue = g.Select(r => r.Descendants().Where(d => d.Name == W.t || d.Name == W.delText).Select(t => t.Value).StringConcatenate()).StringConcatenate();
                    XAttribute xs = null;
                    if (textValue.Length > 0 && (textValue[0] == ' ' || textValue[textValue.Length - 1] == ' '))
                        xs = new XAttribute(XNamespace.Xml + "space", "preserve");
                    if (g.First().Name == W.r)
                    {
                        var newRun = new XElement(W.r,
                            g.First().Elements(W.rPr),
                            new XElement(W.t, xs, textValue));
                        return newRun;
                    }
                    else if (g.First().Name == W.ins)
                    {
                        if (g.First().Elements(W.del).Any())
                        {
                            var newIns2 = new XElement(W.ins,
                                g.First().Attributes(),
                                new XElement(W.del,
                                    g.First().Elements(W.del).Attributes(),
                                    new XElement(W.r,
                                        g.First().Elements(W.del).Elements(W.r).Elements(W.rPr),
                                        new XElement(W.delText, xs, textValue))));
                            return newIns2;
                        }
                        var newIns = new XElement(W.ins,
                            g.First().Attributes(),
                            new XElement(W.r,
                                g.First().Elements(W.r).Elements(W.rPr),
                                new XElement(W.t, xs, textValue)));
                        return newIns;
                    }
                    else // g.First().Name == W.del
                    {
                        var newDel = new XElement(W.del,
                            g.First().Attributes(),
                            new XElement(W.r,
                                g.First().Elements(W.r).Elements(W.rPr),
                                new XElement(W.delText, xs, textValue)));
                        return newDel;
                    }
                }));
            return paragraphWithConsolidatedRuns;
        }

        private static object TransformToDelText(XNode node)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                var delTextValue = element.Value;
                XAttribute spaceAtt = null;
                if (delTextValue.Length > 0 && (delTextValue[0] == ' ' || delTextValue[delTextValue.Length - 1] == ' '))
                    spaceAtt = new XAttribute(XNamespace.Xml + "space", "preserve");
                if (element.Name == W.t)
                    return new XElement(W.delText,
                        spaceAtt,
                        delTextValue);
                return new XElement(element.Name,
                    element.Attributes(),
                    element.Nodes().Select(n => TransformToDelText(n)));
            }
            return node;
        }

        private static object PmlSearchAndReplaceTransform(XNode node, Regex regex, string replacement,
            Func<XElement, Match, bool> callback, ReplaceInternalInfo counter)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                if (element.Name == A.p)
                {
                    var paragraph = element;
                    string contents = element.Descendants(A.t).Select(t => (string)t).StringConcatenate();
                    if (regex.IsMatch(contents))
                    {
                        contents = element.Descendants(A.t).Select(t => (string)t).StringConcatenate();
                        if (regex.IsMatch(contents))
                        {
                            XElement paragraphWithSplitRuns = new XElement(A.p,
                                paragraph.Attributes(),
                                paragraph.Nodes().Select(n => PmlSearchAndReplaceTransform(n, regex, replacement, callback, counter)));

                            var runsTrimmed = paragraphWithSplitRuns
                                .Descendants(A.r)
                                .ToList();

                            var charsAndRuns = runsTrimmed
                                .Select(r =>
                                {
                                    if (r.Element(A.t) != null)
                                        return new
                                        {
                                            Ch = r.Element(A.t).Value,
                                            r,
                                        };
                                    else
                                        return new
                                        {
                                            Ch = "\x01",
                                            r,
                                        };
                                })
                                .ToList();

                            var content = charsAndRuns.Select(t => t.Ch).StringConcatenate();
                            var alignedRuns = charsAndRuns.Select(t => t.r).ToArray();

                            var matchCollection = regex.Matches(content);
                            counter.Count += matchCollection.Count;
                            if (replacement == null)
                            {
                                foreach (var match in matchCollection.Cast<Match>())
                                    callback(paragraph, match);
                            }
                            else
                            {
                                foreach (var match in matchCollection.Cast<Match>())
                                {
                                    if (callback == null || callback(paragraph, match))
                                    {
                                        var runCollection = alignedRuns
                                            .Skip(match.Index)
                                            .Take(match.Length)
                                            .ToList(); // uses the Skip / Take special semantics of array to implement efficient finding of sub array

                                        var firstRun = runCollection.First(); // save away first run because we want the run properties

                                        runCollection.Skip(1).Remove(); // binds to Remove(this IEnumerable<XElement> elements), which is an extension
                                                                        // in LINQ to XML that uses snapshot semantics and removes every element from
                                                                        // its parent.

                                        var newFirstRun = new XElement(A.r,
                                            firstRun.Element(A.rPr),
                                            new XElement(A.t, replacement)); // creates a new run with proper run properties

                                        firstRun.ReplaceWith(newFirstRun);  // finds firstRun in its parent's list of children, unparents firstRun,
                                                                            // sets newFirstRun's parent to firstRuns old parent, and inserts in the list
                                                                            // of children at the right place.
                                    }
                                }

                                var paragraphWithReplacedRuns = paragraphWithSplitRuns;

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
                                        XAttribute xs = null;
                                        if (textValue.Length > 0 && (textValue[0] == ' ' || textValue[textValue.Length - 1] == ' '))
                                            xs = new XAttribute(XNamespace.Xml + "space", "preserve");
                                        return new XElement(A.r,
                                            g.First().Elements(A.rPr),
                                            new XElement(A.t, xs, textValue));
                                    }));
                                paragraph = paragraphWithConsolidatedRuns;
                            }
                        }
                        return paragraph;
                    }
                    return new XElement(element.Name,
                        element.Attributes(),
                        element.Nodes());
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
                                        new XElement(A.t,
                                            c == ' ' ?
                                            new XAttribute(XNamespace.Xml + "space", "preserve") :
                                            null, c));
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
                    element.Nodes().Select(n => PmlSearchAndReplaceTransform(n, regex, replacement, callback, counter)));
            }
            return node;
        }
    }
}
