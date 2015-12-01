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

Version: 2.7.03
 * Support for RTL languages.
 
Version: 2.7.00
 * Uses new ListItemRetriever.
 * Better support for RTL languages.

Version: 2.6.01
 * Add languageCultureName parameter to GetListItemText methods.  This enables a single implementation to handle
   more than one language/culture where appropriate.

Version: 2.6.00
 * Re-write to support styles and rich content

***************************************************************************/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using DocumentFormat.OpenXml.Packaging;

// 200e lrm - LTR
// 200f rlm - RTL

// todo need to set the HTTP "Content-Language" header, for instance:
// Content-Language: en-US
// Content-Language: fr-FR

namespace OpenXmlPowerTools
{
    public partial class WmlDocument : OpenXmlPowerToolsDocument
    {
        public XElement ConvertToHtml(HtmlConverterSettings htmlConverterSettings)
        {
            return HtmlConverter.ConvertToHtml(this, htmlConverterSettings);
        }
    }

    public class HtmlConverterSettings
    {
        public string PageTitle;
        public string CssClassPrefix;
        public bool FabricateCssClasses;
        public string AdditionalCss;
        public bool RestrictToSupportedLanguages;
        public bool RestrictToSupportedNumberingFormats;
        public Dictionary<string, Func<string, int, string, string>> ListItemImplementations;
        public Func<ImageInfo, XElement> ImageHandler;

        public HtmlConverterSettings()
        {
            PageTitle = "";
            CssClassPrefix = "pt-";
            FabricateCssClasses = true;
            RestrictToSupportedLanguages = false;
            RestrictToSupportedNumberingFormats = false;
            ListItemImplementations = ListItemRetrieverSettings.DefaultListItemTextImplementations;
        }
    }

    public class ImageInfo
    {
        public Bitmap Bitmap;
        public XAttribute ImgStyleAttribute;
        public string ContentType;
        public XElement DrawingElement;
        public string AltText;

        public static int EmusPerInch = 914400;
        public static int EmusPerCm = 360000;
    }

    public static class HtmlConverter
    {
        public static XElement ConvertToHtml(WmlDocument doc, HtmlConverterSettings htmlConverterSettings)
        {
            using (OpenXmlMemoryStreamDocument streamDoc = new OpenXmlMemoryStreamDocument(doc))
            {
                using (WordprocessingDocument document = streamDoc.GetWordprocessingDocument())
                {
                    return ConvertToHtml(document, htmlConverterSettings);
                }
            }
        }

        public static XElement ConvertToHtml(WordprocessingDocument wordDoc, HtmlConverterSettings htmlConverterSettings)
        {
            InitEntityMap();
            RevisionAccepter.AcceptRevisions(wordDoc);
            SimplifyMarkupSettings simplifyMarkupSettings = new SimplifyMarkupSettings
            {
                RemoveComments = true,
                RemoveContentControls = true,
                RemoveEndAndFootNotes = true,
                RemoveFieldCodes = false,
                RemoveLastRenderedPageBreak = true,
                RemovePermissions = true,
                RemoveProof = true,
                RemoveRsidInfo = true,
                RemoveSmartTags = true,
                RemoveSoftHyphens = true,
                RemoveGoBackBookmark = true,
                ReplaceTabsWithSpaces = false,
            };
            MarkupSimplifier.SimplifyMarkup(wordDoc, simplifyMarkupSettings);

            FormattingAssemblerSettings formattingAssemblerSettings = new FormattingAssemblerSettings
            {
                RemoveStyleNamesFromParagraphAndRunProperties = false,
                ClearStyles = false,
                RestrictToSupportedLanguages = htmlConverterSettings.RestrictToSupportedLanguages,
                RestrictToSupportedNumberingFormats = htmlConverterSettings.RestrictToSupportedNumberingFormats,
                CreateHtmlConverterAnnotationAttributes = true,
                OrderElementsPerStandard = false,
                ListItemRetrieverSettings = 
                    htmlConverterSettings.ListItemImplementations == null ?
                    new ListItemRetrieverSettings()
                    {
                        ListItemTextImplementations = ListItemRetrieverSettings.DefaultListItemTextImplementations,
                    } :
                    new ListItemRetrieverSettings()
                    {
                        ListItemTextImplementations = htmlConverterSettings.ListItemImplementations,
                    },
            };

            FormattingAssembler.AssembleFormatting(wordDoc, formattingAssemblerSettings);

            InsertAppropriateNonbreakingSpaces(wordDoc);
            CalculateSpanWidthForTabs(wordDoc);
            ReverseTableBordersForRtlTables(wordDoc);
            AdjustTableBorders(wordDoc);
            XElement rootElement = wordDoc.MainDocumentPart.GetXDocument().Root;
            FieldRetriever.AnnotateWithFieldInfo(wordDoc.MainDocumentPart);
            AnnotateForSections(wordDoc);
            XElement xhtml = (XElement)ConvertToHtmlTransform(wordDoc, htmlConverterSettings,
                rootElement, false, 0m);

            ReifyStylesAndClasses(htmlConverterSettings, xhtml);

            // Note: the xhtml returned by ConvertToHtmlTransform contains objects of type
            // XEntity.  PtOpenXmlUtil.cs define the XEntity class.  See
            // http://blogs.msdn.com/ericwhite/archive/2010/01/21/writing-entity-references-using-linq-to-xml.aspx
            // for detailed explanation.
            //
            // If you further transform the XML tree returned by ConvertToHtmlTransform, you
            // must do it correctly, or entities will not be serialized properly.

            return xhtml;
        }

        private static void ReverseTableBordersForRtlTables(WordprocessingDocument wordDoc)
        {
            XDocument xd = wordDoc.MainDocumentPart.GetXDocument();
            foreach (var tbl in xd.Descendants(W.tbl))
            {
                var bidiVisual = tbl.Elements(W.tblPr).Elements(W.bidiVisual).FirstOrDefault();
                if (bidiVisual == null)
                    continue;
                var tblBorders = tbl.Elements(W.tblPr).Elements(W.tblBorders).FirstOrDefault();
                if (tblBorders != null)
                {
                    XElement left = null;
                    XElement right = null;
                    if (tblBorders.Element(W.left) != null)
                        left = new XElement(W.right,
                            tblBorders.Element(W.left).Attributes());
                    if (tblBorders.Element(W.right) != null)
                        right = new XElement(W.left,
                            tblBorders.Element(W.right).Attributes());
                    var newTblBorders = new XElement(W.tblBorders,
                        tblBorders.Element(W.top),
                        left,
                        tblBorders.Element(W.bottom),
                        right);
                    tblBorders.ReplaceWith(newTblBorders);
                }
                foreach (var tc in tbl.Elements(W.tr).Elements(W.tc))
                {
                    var tcBorders = tc.Elements(W.tcPr).Elements(W.tcBorders).FirstOrDefault();
                    if (tcBorders != null)
                    {
                        XElement left = null;
                        XElement right = null;
                        if (tcBorders.Element(W.left) != null)
                            left = new XElement(W.right,
                                tcBorders.Element(W.left).Attributes());
                        if (tcBorders.Element(W.right) != null)
                            right = new XElement(W.left,
                                tcBorders.Element(W.right).Attributes());
                        var newtcBorders = new XElement(W.tcBorders,
                            tcBorders.Element(W.top),
                            left,
                            tcBorders.Element(W.bottom),
                            right);
                        tcBorders.ReplaceWith(newtcBorders);
                    }
                }
            }
        }

        private static void ReifyStylesAndClasses(HtmlConverterSettings htmlConverterSettings, XElement xhtml)
        {
            if (htmlConverterSettings.FabricateCssClasses)
            {
                var usedCssClassNames = new HashSet<string>();
                var elementsThatNeedClasses = xhtml
                    .DescendantsAndSelf()
                    .Select(d => new
                    {
                        Element = d,
                        Styles = d.Annotation<Dictionary<string, string>>(),
                    })
                    .Where(z => z.Styles != null);
                var augmented = elementsThatNeedClasses
                    .Select(p => new
                    {
                        Element = p.Element,
                        Styles = p.Styles,
                        StylesString = p.Element.Name.LocalName + "|" + p.Styles.OrderBy(k => k.Key).Select(s => string.Format("{0}:{1};", s.Key, s.Value)).StringConcatenate(),
                    })
                    .GroupBy(p => p.StylesString)
                    .ToList();
                int classCounter = 1000000;
                var sb = new StringBuilder();
                sb.Append(Environment.NewLine);
                foreach (var grp in augmented)
                {
                    string classNameToUse;
                    var firstOne = grp.First();
                    var styles = firstOne.Styles;
                    if (styles.ContainsKey("PtStyleName"))
                    {
                        classNameToUse = htmlConverterSettings.CssClassPrefix + styles["PtStyleName"];
                        if (usedCssClassNames.Contains(classNameToUse))
                        {
                            classNameToUse = htmlConverterSettings.CssClassPrefix +
                                styles["PtStyleName"] + "-" +
                                classCounter.ToString().Substring(1);
                            classCounter++;
                        }
                    }
                    else
                    {
                        classNameToUse = htmlConverterSettings.CssClassPrefix +
                            classCounter.ToString().Substring(1);
                        classCounter++;
                    }
                    usedCssClassNames.Add(classNameToUse);
                    sb.Append(firstOne.Element.Name.LocalName + "." + classNameToUse + " {" + Environment.NewLine);
                    foreach (var st in firstOne.Styles.Where(s => s.Key != "PtStyleName"))
                    {
                        var s = "    " + st.Key + ":" + st.Value + ";" + Environment.NewLine;
                        sb.Append(s);
                    }
                    sb.Append("}" + Environment.NewLine);
                    var classAtt = new XAttribute("class", classNameToUse);
                    foreach (var gc in grp)
                        gc.Element.Add(classAtt);
                }
                var styleElement = xhtml
                    .Descendants(Xhtml.style)
                    .FirstOrDefault();
                if (styleElement != null)
                    styleElement.Value = sb.ToString() + htmlConverterSettings.AdditionalCss;
                else
                {
                    styleElement = new XElement(Xhtml.style, sb.ToString() + htmlConverterSettings.AdditionalCss);
                    var head = xhtml.Element(Xhtml.head);
                    if (head != null)
                        head.Add(styleElement);
                }
            }
            else
            {
                foreach (var d in xhtml.DescendantsAndSelf())
                {
                    var style = d.Annotation<Dictionary<string, string>>();
                    if (style == null)
                        continue;
                    var styleValue =
                        style
                        .Where(p => p.Key != "PtStyleName")
                        .OrderBy(p => p.Key)
                        .Select(e => string.Format("{0}: {1};", e.Key, e.Value))
                        .StringConcatenate();
                    XAttribute st = new XAttribute("style", styleValue);
                    if (d.Attribute("style") != null)
                        d.Attribute("style").Value += styleValue;
                    else
                        d.Add(st);
                }
            }
        }

        private static object ConvertToHtmlTransform(WordprocessingDocument wordDoc,
            HtmlConverterSettings settings, XNode node,
            bool suppressTrailingWhiteSpace,
            decimal currentMarginLeft)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                if (element.Name == W.document)
                    return new XElement(Xhtml.html,
                        new XElement(Xhtml.head,
                            new XElement(Xhtml.meta,
                                new XAttribute("http-equiv", "Content-Type"),
                                new XAttribute("content", "text/html; charset=utf-8")),
                            new XElement(Xhtml.meta,
                                new XAttribute("name", "Generator"),
                                new XAttribute("content", "PowerTools for Open XML")),
                            settings.PageTitle != null ? new XElement(Xhtml.title,
                                new XText(settings.PageTitle)) : null
                        ),
                        element.Elements().Select(e => ConvertToHtmlTransform(wordDoc, settings, e, false, currentMarginLeft))
                    );

                // Transform the w:body element to the XHTML h:body element.
                if (element.Name == W.body)
                {
                    var sectionDivContent = new XElement(Xhtml.body,
                        CreateSectionDivs(wordDoc, settings, element));
                    return sectionDivContent;
                }

                if (element.Name == W.p)
                {
                    var bidi = element
                        .Elements(W.pPr)
                        .Elements(W.bidi)
                        .Where(b => b.Attribute(W.val) == null || b.Attribute(W.val).ToBoolean() == true)
                        .FirstOrDefault();
                    var isBidi = bidi != null;
                    string styleId = (string)element.Elements(W.pPr).Elements(W.pStyle)
                        .Attributes(W.val).FirstOrDefault();
                    if (styleId != null)
                    {
                        XElement style = wordDoc.MainDocumentPart.StyleDefinitionsPart
                            .GetXDocument().Root.Elements(W.style)
                            .Where(s => (string)s.Attribute(W.styleId) == styleId)
                            .FirstOrDefault();
                        if (style != null)
                        {
                            int? outlineLevel = (int?)style.Elements(W.pPr)
                                .Elements(W.outlineLvl).Attributes(W.val).FirstOrDefault();
                            if (outlineLevel != null && outlineLevel <= 5)
                            {
                                XName elementName = Xhtml.xhtml + string.Format("h{0}",
                                    outlineLevel + 1);
                                return ConvertParagraph(wordDoc, settings, element, elementName, suppressTrailingWhiteSpace, currentMarginLeft, isBidi);
                            }
                            else
                            {
                                XName elementName = Xhtml.p;
                                var o = ConvertParagraph(wordDoc, settings, element, elementName, suppressTrailingWhiteSpace, currentMarginLeft, isBidi);
                                return o;
                            }
                        }
                    }
                    else
                    {
                        XName elementName = Xhtml.p;
                        var o = ConvertParagraph(wordDoc, settings, element, elementName, suppressTrailingWhiteSpace, currentMarginLeft, isBidi);
                        return o;
                    }
                }

                // Transform hyperlinks to the XHTML h:A element.
                if (element.Name == W.hyperlink && element.Attribute(R.id) != null)
                {
                    try
                    {
                        return new XElement(Xhtml.A,
                            new XAttribute("href",
                                wordDoc.MainDocumentPart
                                    .HyperlinkRelationships
                                    .Where(x => x.Id == (string)element.Attribute(R.id))
                                    .First()
                                    .Uri
                            ),
                            element.Elements(W.r).Select(run => ConvertRun(wordDoc, settings, run))
                        );
                    }
                    catch (UriFormatException)
                    {
                        return element.Elements().Select(e => ConvertToHtmlTransform(wordDoc, settings, e, false, currentMarginLeft));
                    }
                }

                // Transform hyperlinks to bookmarks to the XHTML h:A element.
                if (element.Name == W.hyperlink && element.Attribute(W.anchor) != null)
                {
                    var style = new Dictionary<string, string>();
                    var a = new XElement(Xhtml.A,
                        new XAttribute("href", "#" + (string)element.Attribute(W.anchor)),
                        element
                            .Elements(W.r)
                            .Select(run => ConvertRun(wordDoc, settings, run)));
                    style.Add("text-decoration", "none");
                    a.AddAnnotation(style);
                    return a;
                }

                // Transform contents of runs.
                if (element.Name == W.r)
                    return ConvertRun(wordDoc, settings, element);

                // Transform w:bookmarkStart into anchor
                if (element.Name == W.bookmarkStart)
                {
                    var name = (string)element.Attribute(W.name);
                    if (name != null)
                    {
                        var style = new Dictionary<string, string>();
                        var a = new XElement(Xhtml.A,
                            new XAttribute("id", name),
                            new XText(""));
                        style.Add("text-decoration", "none");
                        a.AddAnnotation(style);
                        return a;
                    }
                }

                // Transform every w:t element to a text node.
                if (element.Name == W.t)
                {
                    var textWithEntities = ConvertEntities(element.Value);
                    return textWithEntities;
                }

                // Transform symbols to spans
                if (element.Name == W.sym)
                {
                    var cs = (string)element.Attribute(W._char);
                    var c = Convert.ToInt32(cs, 16);
                    var symbolSpan = new XElement(Xhtml.span, new XEntity(string.Format("#{0}", ((int)c).ToString())));
                    return symbolSpan;
                }

                // Transform tabs that have the pt:TabWidth attribute set
                if (element.Name == W.tab)
                {
                    var tabWidthAtt = element.Attribute(PtOpenXml.TabWidth);
                    if (tabWidthAtt != null)
                    {
                        var leader = (string)element.Attribute(PtOpenXml.Leader);
                        var tabWidth = (decimal)tabWidthAtt;
                        var style = new Dictionary<string, string>();
                        XElement span;
                        if (leader != null)
                        {
                            var leaderChar = ".";
                            if (leader == "hyphen")
                                leaderChar = "-";
                            else if (leader == "dot")
                                leaderChar = ".";
                            else if (leader == "underscore")
                                leaderChar = "_";

                            var runContainingTabToReplace = element.Ancestors(W.r).First();
                            var fontNameAtt = runContainingTabToReplace.Attribute(PtOpenXml.pt + "FontName");
                            if (fontNameAtt == null)
                                fontNameAtt = runContainingTabToReplace.Ancestors(W.p).First()
                                    .Attribute(PtOpenXml.pt + "FontName");

                            var dummyRun = new XElement(W.r,
                                fontNameAtt,
                                runContainingTabToReplace.Elements(W.rPr),
                                new XElement(W.t, leaderChar));

                            var widthOfLeaderChar = CalcWidthOfRunInTwips(dummyRun);

                            bool forceArial = false;
                            if (widthOfLeaderChar == 0)
                            {
                                dummyRun = new XElement(W.r,
                                    new XAttribute(PtOpenXml.FontName, "Arial"),
                                    runContainingTabToReplace.Elements(W.rPr),
                                    new XElement(W.t, leaderChar));
                                widthOfLeaderChar = CalcWidthOfRunInTwips(dummyRun);
                                forceArial = true;
                            }

                            if (widthOfLeaderChar != 0)
                            {
                                var numberOfLeaderChars = (int)(Math.Floor((tabWidth * 1440) / widthOfLeaderChar));
                                if (numberOfLeaderChars < 0)
                                    numberOfLeaderChars = 0;
                                span = new XElement(Xhtml.span,
                                    " " + "".PadRight(numberOfLeaderChars, leaderChar[0]) + " ");
                                style.Add("margin", "0 0 0 0");
                                style.Add("padding", "0 0 0 0");
                                style.Add("width", string.Format("{0:0.00}in", tabWidth));
                                style.Add("text-align", "center");
                                if (forceArial)
                                    style.Add("font-family", "Arial");
                            }
                            else
                            {
                                span = new XElement(Xhtml.span, " ");
                                style.Add("margin", "0 0 0 0");
                                style.Add("padding", "0 0 0 0");
                                style.Add("width", string.Format("{0:0.00}in", tabWidth));
                                style.Add("text-align", "center");
                                if (leader == "underscore")
                                {
                                    style.Add("text-decoration", "underline");
                                }
                            }
                        }
                        else
                        {
#if false
                            var bidi = element
                                .Ancestors(W.p)
                                .Take(1)
                                .Elements(W.pPr)
                                .Elements(W.bidi)
                                .Where(b => b.Attribute(W.val) == null || b.Attribute(W.val).ToBoolean() == true)
                                .FirstOrDefault();
                            var isBidi = bidi != null;
                            if (isBidi)
                                span = new XElement(Xhtml.span, new XEntity("#x200f")); // RLM
                            else
                                span = new XElement(Xhtml.span, new XEntity("#x200e")); // LRM
#else
                            span = new XElement(Xhtml.span, new XEntity("nbsp"));
#endif
                            style.Add("margin", string.Format("0 0 0 {0:0.00}in", tabWidth));
                            style.Add("padding", "0 0 0 0");
                        }
                        span.AddAnnotation(style);
                        return span;
                    }
                }

                // Transform w:br to h:br.
                if (element.Name == W.br || element.Name == W.cr)
                {
                    XElement span = null;
                    var tabWidth = (decimal?)element.Attribute(PtOpenXml.TabWidth);
                    if (tabWidth != null)
                    {
                        span = new XElement(Xhtml.span);
                        var style = new Dictionary<string, string>();
                        style.Add("margin", string.Format("0 0 0 {0:0.00}in", tabWidth));
                        style.Add("padding", "0 0 0 0");
                        span.AddAnnotation(style);
                    }
                    var paragraph = element.Ancestors(W.p).FirstOrDefault();
                    bool isBidi = false;
                    if (paragraph != null)
                    {
                        var bidi = paragraph
                            .Elements(W.pPr)
                            .Elements(W.bidi)
                            .Where(b => b.Attribute(W.val) == null || b.Attribute(W.val).ToBoolean() == true)
                            .FirstOrDefault();
                        isBidi = bidi != null;
                    }
                    var br = new XElement(Xhtml.br);
                    XEntity zeroWidthChar = null;
                    if (isBidi)
                        zeroWidthChar = new XEntity("#x200f"); // RLM
                    else
                        zeroWidthChar = new XEntity("#x200e"); // LRM
                    return new object[] {
                        br,
                        zeroWidthChar,
                        span,
                    };
                }

                // Transform w:noBreakHyphen to '-'
                if (element.Name == W.noBreakHyphen)
                    return new XText("-");

                // Transform w:tbl to h:tbl.
                if (element.Name == W.tbl)
                {
                    var style = new Dictionary<string, string>();
                    style.AddIfMissing("border-collapse", "collapse");
                    style.AddIfMissing("border", "none");
                    var bidiVisual = element.Elements(W.tblPr).Elements(W.bidiVisual).FirstOrDefault();
                    var tblW = element.Elements(W.tblPr).Elements(W.tblW).FirstOrDefault();
                    if (tblW != null)
                    {
                        var type = (string)tblW.Attribute(W.type);
                        if (type != null && type == "pct")
                        {
                            var w = (int)tblW.Attribute(W._w);
                            style.AddIfMissing("width", (w / 50).ToString() + "%");
                        }
                    }
                    var tblInd = element.Elements(W.tblPr).Elements(W.tblInd).FirstOrDefault();
                    if (tblInd != null)
                    {
                        var tblIndType = (string)tblInd.Attribute(W.type);
                        if (tblIndType != null)
                        {
                            if (tblIndType == "dxa")
                            {
                                var width = (decimal?)tblInd.Attribute(W._w);
                                if (width != null)
                                {
                                    style.AddIfMissing("margin-left", string.Format("{0}pt", width / 20m));
                                }
                            }
                        }
                    }
                    XAttribute tableDirection = null;
                    if (bidiVisual != null)
                    {
                        tableDirection = new XAttribute("dir", "rtl");
                    }
                    else
                    {
                        tableDirection = new XAttribute("dir", "ltr");
                    }
                    style.AddIfMissing("margin-bottom", ".001pt");
                    var table = new XElement(Xhtml.table,
                        new XAttribute("border", "1"),
                        new XAttribute("cellspacing", 0),
                        new XAttribute("cellpadding", 0),
                        tableDirection,
                        element.Elements().Select(e => ConvertToHtmlTransform(wordDoc, settings, e, false, currentMarginLeft)));
                    table.AddAnnotation(style);
                    var jc = (string)element.Elements(W.tblPr).Elements(W.jc).Attributes(W.val).FirstOrDefault();
                    if (jc == null)
                        jc = "left";
                    XAttribute dir = null;
                    XAttribute jcToUse = null;
                    if (bidiVisual != null)
                    {
                        dir = new XAttribute("dir", "rtl");
                        if (jc == "left")
                            jcToUse = new XAttribute("align", "right");
                        else if (jc == "right")
                            jcToUse = new XAttribute("align", "left");
                        else if (jc == "center")
                            jcToUse = new XAttribute("align", "center");
                    }
                    else
                    {
                        jcToUse = new XAttribute("align", jc);
                    }
                    var tableDiv = new XElement(Xhtml.div,
                        dir,
                        jcToUse,
                        table);
                    return tableDiv;
                }

                // Transform w:tr to h:tr.
                if (element.Name == W.tr)
                {
                    var style = new Dictionary<string, string>();
                    int? trHeight = (int?)element.Elements(W.trPr).Elements(W.trHeight).Attributes(W.val).FirstOrDefault();
                    if (trHeight != null)
                        style.AddIfMissing("height", string.Format("{0}in", (decimal)trHeight / 1440m));
                    var htmlRow = new XElement(Xhtml.tr,
                        element.Elements().Select(e => ConvertToHtmlTransform(wordDoc, settings, e, false, currentMarginLeft)));
                    if (style.Any())
                        htmlRow.AddAnnotation(style);
                    return htmlRow;
                }

                // Transform w:tc to h:td.
                if (element.Name == W.tc)
                {
                    var style = new Dictionary<string, string>();
                    XAttribute colSpan = null;
                    XAttribute rowSpan = null;

                    var tcPr = element.Element(W.tcPr);
                    if (tcPr != null)
                    {
                        if ((string)tcPr.Elements(W.vMerge).Attributes(W.val).FirstOrDefault() == "restart")
                        {
                            var currentRow = element.Parent.ElementsBeforeSelf(W.tr).Count();
                            var currentCell = element.ElementsBeforeSelf(W.tc).Count();
                            var tbl = element.Parent.Parent;
                            int rowSpanCount = 1;
                            currentRow += 1;
                            while (true)
                            {
                                var row = tbl.Elements(W.tr).Skip(currentRow).FirstOrDefault();
                                if (row == null)
                                    break;
                                var cell2 = row.Elements(W.tc).Skip(currentCell).FirstOrDefault();
                                if (cell2 == null)
                                    break;
                                if (cell2.Elements(W.tcPr).Elements(W.vMerge).FirstOrDefault() == null)
                                    break;
                                if ((string)cell2.Elements(W.tcPr).Elements(W.vMerge).Attributes(W.val).FirstOrDefault() == "restart")
                                    break;
                                currentRow += 1;
                                rowSpanCount += 1;
                            }
                            rowSpan = new XAttribute("rowspan", rowSpanCount);
                        }

                        if (tcPr.Element(W.vMerge) != null && (string)tcPr.Elements(W.vMerge).Attributes(W.val).FirstOrDefault() != "restart")
                            return null;

                        if (tcPr.Element(W.vAlign) != null)
                        {
                            var vAlignVal = (string)tcPr.Elements(W.vAlign).Attributes(W.val).FirstOrDefault();
                            if (vAlignVal == "top")
                                style.AddIfMissing("vertical-align", "top");
                            else if (vAlignVal == "center")
                                style.AddIfMissing("vertical-align", "middle");
                            else if (vAlignVal == "bottom")
                                style.AddIfMissing("vertical-align", "bottom");
                            else
                                style.AddIfMissing("vertical-align", "middle");
                        }
                        style.AddIfMissing("vertical-align", "top");

                        if ((string)tcPr.Elements(W.tcW).Attributes(W.type).FirstOrDefault() == "dxa")
                        {
                            decimal width = (int)tcPr.Elements(W.tcW).Attributes(W._w).FirstOrDefault();
                            style.AddIfMissing("width", string.Format("{0}pt", width / 20m));
                        }
                        if ((string)tcPr.Elements(W.tcW).Attributes(W.type).FirstOrDefault() == "pct")
                        {
                            decimal width = (int)tcPr.Elements(W.tcW).Attributes(W._w).FirstOrDefault();
                            style.AddIfMissing("width", string.Format("{0:0.0}%", width / 50m));
                        }

                        var tcBorders = tcPr.Element(W.tcBorders);
                        GenerateBorderStyle(tcBorders, W.top, style, BorderType.Cell);
                        GenerateBorderStyle(tcBorders, W.right, style, BorderType.Cell);
                        GenerateBorderStyle(tcBorders, W.bottom, style, BorderType.Cell);
                        GenerateBorderStyle(tcBorders, W.left, style, BorderType.Cell);

                        CreateStyleFromShd(style, tcPr.Element(W.shd));

                        var gridSpan = (int?)tcPr.Elements(W.gridSpan).Attributes(W.val).Select(a => (int?)a).FirstOrDefault();
                        if (gridSpan != null)
                            colSpan = new XAttribute("colspan", (int)gridSpan);
                    }
                    style.AddIfMissing("padding-top", "0in");
                    style.AddIfMissing("padding-bottom", "0in");

                    var cell = new XElement(Xhtml.td,
                        rowSpan,
                        colSpan,
                        CreateBorderDivs(wordDoc, settings, element.Elements()));
                    cell.AddAnnotation(style);
                    return cell;
                }

                // Transform images
                if (element.Name == W.drawing || element.Name == W.pict || element.Name == W._object)
                {
                    if (settings.ImageHandler == null)
                        return null;
                    return ProcessImage(wordDoc, element, settings.ImageHandler);
                }

                if (element.Name == W.sdt)
                {
                    var relevantAncestors = element.Ancestors().TakeWhile(a => a.Name != W.txbxContent);
                    var isRunLevelContentControl = relevantAncestors.Any(a => a.Name == W.p);
                    if (isRunLevelContentControl)
                    {
                        var o = element.Element(W.sdtContent).Elements().Select(e => ConvertToHtmlTransform(wordDoc, settings, e, false, currentMarginLeft))
                            .ToList();
                        return o;
                    }
                    else
                    {
                        var o = CreateBorderDivs(wordDoc, settings, element.Element(W.sdtContent).Elements());
                        return o;
                    }
                }

                if (element.Name == W.smartTag || element.Name == W.fldSimple)
                {
                    var o = CreateBorderDivs(wordDoc, settings, element.Elements());
                    return o;
                }

                return null;
            }
            return null;
        }

        private static object CreateSectionDivs(WordprocessingDocument wordDoc, HtmlConverterSettings settings, XElement element)
        {
            // note: when building a paging html converter, need to attend to new sections with page breaks here.
            // This code conflates adjacent sections if they have identical formatting, which is not an issue
            // for the non-paging transform.
            var groupedIntoDivs = element
                .Elements()
                .GroupAdjacent(e => {
                    var sectAnnotation = e.Annotation<SectionAnnotation>();
                    return sectAnnotation != null ? sectAnnotation.SectionElement.ToString() : "";
                });

            // note: when creating a paging html converter, need to pay attention to w:rtlGutter element.
            var divList = groupedIntoDivs
                .Select(g =>
                {
                    var sectPr = g.First().Annotation<SectionAnnotation>();
                    XElement bidi = null;
                    if (sectPr != null)
                    {
                        bidi = sectPr
                            .SectionElement
                            .Elements(W.bidi)
                            .Where(b => b.Attribute(W.val) == null || b.Attribute(W.val).ToBoolean() == true)
                            .FirstOrDefault();
                    }
                    if (sectPr == null || bidi == null)
                    {
                        var div = new XElement(Xhtml.div, CreateBorderDivs(wordDoc, settings, g));
                        return div;
                    }
                    else
                    {
                        var div = new XElement(Xhtml.div,
                            new XAttribute("dir", "rtl"),
                            CreateBorderDivs(wordDoc, settings, g));
                        return div;
                    }
                });
            return divList;
        }

        private enum BorderType
        {
            Paragraph,
            Cell,
        };

        /*
         * Notes on line spacing
         * 
         * the w:line and w:lineRule attributes control spacing between lines - including between lines within a paragraph
         * 
         * If w:spacing w:lineRule="auto" then
         *   w:spacing w:line is a percentage where 240 == 100%
         *   
         *   (line value / 240) * 100 = percentage of line 
         *   
         * If w:spacing w:lineRule="exact" or w:lineRule="atLeast" then
         *   w:spacing w:line is in twips
         *   1440 = exactly one inch from line to line
         *
         * Handle
         * - ind
         * - jc
         * - numPr
         * - pBdr
         * - shd
         * - spacing
         * - textAlignment
         *  
         * Don't Handle (yet)
         * - adjustRightInd?
         * - autoSpaceDE
         * - autoSpaceDN
         * - bidi
         * - contextualSpacing
         * - divId
         * - framePr
         * - keepLines
         * - keepNext
         * - kinsoku
         * - mirrorIndents
         * - overflowPunct
         * - pageBreakBefore
         * - snapToGrid
         * - suppressAutoHyphens
         * - suppressLineNumbers
         * - suppressOverlap
         * - tabs
         * - textBoxTightWrap
         * - textDirection
         * - topLinePunct
         * - widowControl
         * - wordWrap
         * 
         */

        private static object ConvertParagraph(WordprocessingDocument wordDoc, HtmlConverterSettings settings,
            XElement paragraph, XName elementName, bool suppressTrailingWhiteSpace, decimal currentMarginLeft, bool isBidi)
        {
            var style = new Dictionary<string, string>();
            var sn = (string)paragraph.Attribute(PtOpenXml.StyleName);
            if (sn != null)
                style.Add("PtStyleName", sn);

            XElement pPr = paragraph.Element(W.pPr);
            if (pPr != null)
            {
                var spacing = pPr.Element(W.spacing);
                if (spacing != null)
                {
                    var spacingBefore = (decimal?)spacing.Attribute(W.before);
                    if (spacingBefore != null)
                        style.AddIfMissing("margin-top", string.Format("{0}pt", spacingBefore / 20.0m));

                    var lineRule = (string)spacing.Attribute(W.lineRule);
                    if (lineRule == "auto")
                    {
                        var line = (decimal)spacing.Attribute(W.line);
                        if (line != 240m)
                        {
                            var pct = (line / 240m) * 100m;
                            style.Add("line-height", string.Format("{0:0.0}%", pct));
                        }
                    }
                    if (lineRule == "exact")
                    {
                        var line = (decimal)spacing.Attribute(W.line);
                        var points = line / 20m;
                        style.Add("line-height", string.Format("{0:0.0}pt", points));
                    }
                    if (lineRule == "atLeast")
                    {
                        var line = (decimal)spacing.Attribute(W.line);
                        var points = line / 20m;
                        if (points >= 14m)
                            style.Add("line-height", string.Format("{0:0.0}pt", points));
                    }

                    decimal? spacingAfter;
                    if (suppressTrailingWhiteSpace)
                        spacingAfter = 0;
                    else
                        spacingAfter = (decimal?)spacing.Attribute(W.after) /*+ addToSpacing*/;

                    if (spacingAfter != null)
                        style.AddIfMissing("margin-bottom", string.Format("{0}pt", spacingAfter / 20.0m));

                }

                var ind = pPr.Element(W.ind);
                if (ind != null)
                {
                    decimal? left = (decimal?)ind.Attribute(W.left);
                    if (left != null)
                    {
                        decimal leftInInches = (decimal)left / 1440 - currentMarginLeft;
                        style.AddIfMissing(isBidi ? "margin-right" : "margin-left", 
                            string.Format("{0:0.00}in", leftInInches));
                    }

                    decimal? right = (decimal?)ind.Attribute(W.right);
                    if (right != null)
                    {
                        decimal rightInInches = (decimal)right / 1440;
                        style.AddIfMissing(isBidi ? "margin-left" : "margin-right",
                            string.Format("{0:0.00}in", rightInInches));
                    }

                    decimal? firstLine = (decimal?)ind.Attribute(W.firstLine);
                    if (firstLine != null)
                    {
                        decimal firstLineInInches = (decimal)firstLine / 1440m;
                        style.AddIfMissing("text-indent", string.Format("{0:0.00}in", firstLineInInches));
                    }
                    decimal? hanging = (decimal?)ind.Attribute(W.hanging);
                    if (hanging != null)
                    {
                        decimal hangingInInches = (decimal)-hanging / 1440m;
                        style.AddIfMissing("text-indent", string.Format("{0:0.00}in", hangingInInches));
                    }
                }

                // todo need to handle
                // - both
                // - mediumKashida
                // - distribute
                // - numTab
                // - highKashida
                // - lowKashida
                // - thaiDistribute

                var jcVal = (string)pPr.Elements(W.jc).Attributes(W.val).FirstOrDefault();
                if (jcVal == null)
                {
                    jcVal = "left";
                }
                if (jcVal == "left")
                {
                    if (isBidi)
                        style.AddIfMissing("text-align", "right");
                    else
                        style.AddIfMissing("text-align", "left");
                }
                else if (jcVal == "right")
                {
                    if (isBidi)
                        style.AddIfMissing("text-align", "left");
                    else
                        style.AddIfMissing("text-align", "right");
                }
                else if (jcVal == "center")
                    style.AddIfMissing("text-align", "center");
                else if (jcVal == "both")
                    style.AddIfMissing("text-align", "justify");

                CreateStyleFromShd(style, pPr.Element(W.shd));

                // Pt.FontName
                string font = (string)paragraph.Attributes(PtOpenXml.FontName).FirstOrDefault();
                if (font != null)
                    CreateFontCssProperty(font, style);

                // W.sz
                decimal? sz = null;

                var languageType = (string)paragraph.Attribute(PtOpenXml.LanguageType);
                if (languageType == "bidi")
                    sz = (decimal?)pPr.Elements(W.rPr).Elements(W.szCs).Attributes(W.val).FirstOrDefault();
                else
                    sz = (decimal?)pPr.Elements(W.rPr).Elements(W.sz).Attributes(W.val).FirstOrDefault();

                var sizesOfAllRunsInParagraph = paragraph
                    .DescendantsTrimmed(W.txbxContent)
                    .Select(run =>
                    {
                        if (run.Name != W.r)
                            return null;
                        var runLanguageType = (string)run.Attribute(PtOpenXml.LanguageType);
                        if (runLanguageType == "bidi")
                        {
                            var runCsSz = (decimal?)run
                                .Elements(W.rPr)
                                .Elements(W.szCs)
                                .Attributes(W.val)
                                .FirstOrDefault();
                            return runCsSz;
                        }
                        else
                        {
                            var runSz = (decimal?)run
                                .Elements(W.rPr)
                                .Elements(W.sz)
                                .Attributes(W.val)
                                .FirstOrDefault();
                            return runSz;
                        }
                    })
                    .Where(runSz => runSz != null);

                if (sizesOfAllRunsInParagraph.Any())
                    sz = sizesOfAllRunsInParagraph.Cast<decimal>().Max();

                if (sz != null)
                    style.AddIfMissing("font-size", string.Format("{0}pt", sz / 2.0m));

                var languageTypeOfAllRunsInParagraph = paragraph
                    .DescendantsTrimmed(W.txbxContent)
                    .Select(run =>
                    {
                        if (run.Name != W.r)
                            return null;
                        var runLanguageType = (string)run.Attribute(PtOpenXml.LanguageType);
                        return runLanguageType;
                    })
                    .Where(runSz => runSz != null);

                if (!languageTypeOfAllRunsInParagraph.Any(lt => lt == "bidi"))
                    style.AddIfMissing("line-height", "108%");

                // vertical text alignment as of December 2013 does not work in any major browsers.
                var verticalTextAlignment = (string)pPr.Elements(W.textAlignment).Attributes(W.val).FirstOrDefault();
                if (verticalTextAlignment != null && verticalTextAlignment != "auto")
                {
                    if (verticalTextAlignment == "top")
                        style.AddIfMissing("vertical-align", "top");
                    else if (verticalTextAlignment == "center")
                        style.AddIfMissing("vertical-align", "middle");
                    else if (verticalTextAlignment == "baseline")
                        style.AddIfMissing("vertical-align", "baseline");
                    else if (verticalTextAlignment == "bottom")
                        style.AddIfMissing("vertical-align", "bottom");
                }

                style.AddIfMissing("margin-top", "0pt");
                style.AddIfMissing("margin-left", "0pt");
                style.AddIfMissing("margin-right", "0pt");
                style.AddIfMissing("margin-bottom", ".001pt");

            }
            XAttribute rtl = null;
            XEntity firstMark = null;
            if (isBidi)
            {
                rtl = new XAttribute("dir", "rtl");
                firstMark = new XEntity("#x200f"); // RLM
            }
            else
            {
                rtl = new XAttribute("dir", "ltr");
            }
            var paraElement = new XElement(elementName,
                rtl,
                firstMark,
                ConvertContentThatCanContainFields(wordDoc, settings, paragraph.Elements()));
            paraElement.AddAnnotation(style);
            return paraElement;
        }

        /*
         * Handle:
         * - b
         * - bdr
         * - caps
         * - color
         * - dstrike
         * - highlight
         * - i
         * - position
         * - rFonts
         * - shd
         * - smallCaps
         * - spacing
         * - strike
         * - sz
         * - u
         * - vanish
         * - vertAlign
         *
         * Don't handle:
         * - em
         * - emboss
         * - fitText
         * - imprint
         * - kern
         * - outline
         * - shadow
         * - w
         * 
         */

        private static object ConvertRun(WordprocessingDocument wordDoc, HtmlConverterSettings settings, XElement run)
        {
            var style = new Dictionary<string, string>();
            var sn = (string)run.Attribute(PtOpenXml.StyleName);
            if (sn != null)
                style.Add("PtStyleName", sn);

            var rPr = run.Element(W.rPr);

            if (rPr == null)
            {
                object content2 = run.Elements().Select(e => ConvertToHtmlTransform(wordDoc, settings, e, false, 0m));
                return content2;
            }

            // hide all content that contains the w:rPr/w:webHidden element
            if (rPr.Element(W.webHidden) != null)
                return null;

            // W.bdr
            if (rPr.Element(W.bdr) != null && (string)rPr.Elements(W.bdr).Attributes(W.val).FirstOrDefault() != "none")
            {
                style.AddIfMissing("border", "solid windowtext 1.0pt");
                style.AddIfMissing("padding", "0in");
            }

            // W.color
            string color = (string)rPr.Elements(W.color).Attributes(W.val).FirstOrDefault();
            if (color != null)
                CreateColorProperty("color", color, style);

            // W.highlight
            string highlight = (string)rPr.Elements(W.highlight).Attributes(W.val).FirstOrDefault();
            if (highlight != null)
                CreateColorProperty("background", highlight, style);

            // W.shd
            string shade = (string)rPr.Elements(W.shd).Attributes(W.fill).FirstOrDefault();
            if (shade != null)
                CreateColorProperty("background", shade, style);

            // Pt.FontName
            string font = null;
            if (run.Element(W.sym) != null)
                font = (string)run.Elements(W.sym).Attributes(W.font).FirstOrDefault();
            else
                font = (string)run.Attributes(PtOpenXml.FontName).FirstOrDefault();
            if (font != null)
                CreateFontCssProperty(font, style);

            // W.sz
            var languageType = (string)run.Attribute(PtOpenXml.LanguageType);
            decimal? sz = null;
            if (languageType == "bidi")
                sz = (decimal?)rPr.Elements(W.szCs).Attributes(W.val).FirstOrDefault();
            else
                sz = (decimal?)rPr.Elements(W.sz).Attributes(W.val).FirstOrDefault();
            if (sz != null)
                style.AddIfMissing("font-size", string.Format("{0}pt", sz / 2.0m));

            // W.caps
            if (getBoolProp(rPr, W.caps))
                style.AddIfMissing("text-transform", "uppercase");

            // W.smallCaps
            if (getBoolProp(rPr, W.smallCaps))
                style.AddIfMissing("font-variant", "small-caps");

            // W.spacing
            decimal? spacingInTwips = (decimal?)rPr.Elements(W.spacing).Attributes(W.val).FirstOrDefault();
            if (spacingInTwips != null)
                style.AddIfMissing("letter-spacing", string.Format("{0}pt", spacingInTwips / 20));

            // W.position
            decimal? position = (decimal?)rPr.Elements(W.position).Attributes(W.val).FirstOrDefault();
            if (position != null)
            {
                style.AddIfMissing("position", "relative");
                style.AddIfMissing("top", string.Format("{0}pt", -(position / 2)));
            }

            // W.vanish
            if (getBoolProp(rPr, W.vanish))
                style.AddIfMissing("display", "none");

            object content = run.Elements().Select(e => ConvertToHtmlTransform(wordDoc, settings, e, false, 0m));

            // W.u
            if (rPr.Element(W.u) != null && (string)rPr.Elements(W.u).Attributes(W.val).FirstOrDefault() != "none")
            {
                var newContent = new XElement(Xhtml.u, content);
                if (newContent.Nodes().Any())
                    content = newContent;
                style.AddIfMissing("text-decoration", "underline");
            }

            // W.i
            if (getBoolProp(rPr, W.i))
            {
                var newContent = new XElement(Xhtml.i, content);
                if (newContent.Nodes().Any())
                    content = newContent;
                style.AddIfMissing("font-style", "italic");
            }

            // W.b
            if (getBoolProp(rPr, W.b))
            {
                var newContent = new XElement(Xhtml.b, content);
                if (newContent.Nodes().Any())
                    content = newContent;
                style.AddIfMissing("font-weight", "bold");
            }
            else
            {
                style.AddIfMissing("font-weight", "normal");
            }

            // W.strike
            if (getBoolProp(rPr, W.strike) || getBoolProp(rPr, W.dstrike))
            {
                var newContent = new XElement(Xhtml.s, content);
                if (newContent.Nodes().Any())
                    content = newContent;
                style.AddIfMissing("text-decoration", "line-through");
            }

            // W.vertAlign
            if (rPr.Element(W.vertAlign) != null && (string)rPr.Elements(W.vertAlign).Attributes(W.val).FirstOrDefault() == "superscript")
            {
                var newContent = new XElement(Xhtml.sup, content);
                if (newContent.Nodes().Any())
                    content = newContent;
            }

            if (rPr.Element(W.vertAlign) != null && (string)rPr.Elements(W.vertAlign).Attributes(W.val).FirstOrDefault() == "subscript")
            {
                var newContent = new XElement(Xhtml.sub, content);
                if (newContent.Nodes().Any())
                    content = newContent;
            }

            var rtl = rPr.Element(W.rtl);
            var isRtl = rtl != null;

            var paragraph = run.Ancestors(W.p).FirstOrDefault();
            var paraBidi = paragraph
                .Elements(W.pPr)
                .Elements(W.bidi)
                .Where(b => b.Attribute(W.val) == null || b.Attribute(W.val).ToBoolean() == true)
                .FirstOrDefault();
            var paraIsBidi = paraBidi != null;

            string lang = null;
            if (languageType == "western")
                lang = (string)rPr.Elements(W.lang).Attributes(W.val).FirstOrDefault();
            else if (languageType == "bidi")
                lang = (string)rPr.Elements(W.lang).Attributes(W.bidi).FirstOrDefault();
            else if (languageType == "eastAsia")
                lang = (string)rPr.Elements(W.lang).Attributes(W.eastAsia).FirstOrDefault();

            // only do the following for text runs.
            XEntity runStartMark = null;
            XEntity runEndMark = null;

            // Can't add directional marks if the font-family is symbol - they are visible, and display as a ?
            bool addDirectionalMarks = true;
            if (style.ContainsKey("font-family"))
            {
                if (style["font-family"].ToLower() == "symbol")
                    addDirectionalMarks = false;
            }
            if (addDirectionalMarks)
            {
                if (run.Element(W.t) != null)
                {
                    if (isRtl)
                    {
                        runStartMark = new XEntity("#x200f"); // RLM
                        runEndMark = new XEntity("#x200f"); // RLM
                    }
                    else
                    {
                        if (paraIsBidi)
                        {
                            runStartMark = new XEntity("#x200e"); // LRM
                            runEndMark = new XEntity("#x200e"); // LRM
                        }
                    }
                }
            }

            string defaultLanguage = "en-US"; // todo need to get defaultLanguage
            if (lang == null)
                lang = defaultLanguage;
            XAttribute langAttribute = new XAttribute("lang", lang);
            if (lang == defaultLanguage)
                langAttribute = null;

            if (style.Any() || isRtl || langAttribute != null)
            {
                style.AddIfMissing("margin", "0in");
                style.AddIfMissing("padding", "0in");
                var xe = new XElement(Xhtml.span,
                    langAttribute,
                    runStartMark,
                    content,
                    runEndMark);

                xe.AddAnnotation(style);
                content = xe;
            }
            return content;
        }

        private static void AdjustTableBorders(WordprocessingDocument wordDoc)
        {
            // Note: when implementing a paging version of the HTML transform, this needs to be done
            // for all content parts, not just the main document part.

            var xd = wordDoc.MainDocumentPart.GetXDocument();
            foreach (var tbl in xd.Descendants(W.tbl))
                AdjustTableBorders(tbl);
            wordDoc.MainDocumentPart.PutXDocument();
        }

        private static void AdjustTableBorders(XElement tbl)
        {
            var ta = tbl
                .Elements(W.tr)
                .Select(r => r
                    .Elements(W.tc)
                    .Select(c =>
                    {
                        int? gridSpan = (int?)c.Elements(W.tcPr).Elements(W.gridSpan).Attributes(W.val).FirstOrDefault();
                        if (gridSpan != null)
                        {
                            if (gridSpan < 1)
                                gridSpan = 1;
                            return Enumerable.Repeat(c, (int)gridSpan);
                        }
                        return new[] { c };
                    })
                    .SelectMany(m => m)
                    .ToArray())
                .ToArray();

            for (int y = 0; y < ta.Length; y++)
            {
                for (int x = 0; x < ta[y].Length; x++)
                {
                    var thisCell = ta[y][x];
                    FixTopBorder(ta, thisCell, x, y);
                    FixLeftBorder(ta, thisCell, x, y);
                    FixBottomBorder(ta, thisCell, x, y);
                    FixRightBorder(ta, thisCell, x, y);
                }
            }
        }

        private static void FixTopBorder(XElement[][] ta, XElement thisCell, int x, int y)
        {
            if (y > 0)
            {
                var rowAbove = ta[y - 1];
                if (x < rowAbove.Length - 1)
                {
                    XElement cellAbove = ta[y - 1][x];
                    if (cellAbove != null &&
                        thisCell.Elements(W.tcPr).Elements(W.tcBorders).FirstOrDefault() != null &&
                        cellAbove.Elements(W.tcPr).Elements(W.tcBorders).FirstOrDefault() != null)
                    {
                        ResolveCellBorder(thisCell.Element(W.tcPr).Element(W.tcBorders).Element(W.top), cellAbove.Element(W.tcPr).Element(W.tcBorders).Element(W.bottom));
                    }
                }
            }
        }

        private static void FixLeftBorder(XElement[][] ta, XElement thisCell, int x, int y)
        {
            if (x > 0)
            {
                XElement cellLeft = ta[y][x - 1];
                if (cellLeft != null &&
                    thisCell.Elements(W.tcPr).Elements(W.tcBorders).FirstOrDefault() != null &&
                    cellLeft.Elements(W.tcPr).Elements(W.tcBorders).FirstOrDefault() != null)
                {
                    ResolveCellBorder(thisCell.Element(W.tcPr).Element(W.tcBorders).Element(W.left), cellLeft.Element(W.tcPr).Element(W.tcBorders).Element(W.right));
                }
            }
        }

        private static void FixBottomBorder(XElement[][] ta, XElement thisCell, int x, int y)
        {
            if (y < ta.Length - 1)
            {
                var rowBelow = ta[y + 1];
                if (x < rowBelow.Length - 1)
                {
                    XElement cellBelow = ta[y + 1][x];
                    if (cellBelow != null &&
                        thisCell.Elements(W.tcPr).Elements(W.tcBorders).FirstOrDefault() != null &&
                        cellBelow.Elements(W.tcPr).Elements(W.tcBorders).FirstOrDefault() != null)
                    {
                        ResolveCellBorder(thisCell.Element(W.tcPr).Element(W.tcBorders).Element(W.bottom), cellBelow.Element(W.tcPr).Element(W.tcBorders).Element(W.top));
                    }
                }
            }
        }

        private static void FixRightBorder(XElement[][] ta, XElement thisCell, int x, int y)
        {
            if (x < ta[y].Length - 1)
            {
                XElement cellRight = ta[y][x + 1];
                if (cellRight != null &&
                    thisCell.Elements(W.tcPr).Elements(W.tcBorders).FirstOrDefault() != null &&
                    cellRight.Elements(W.tcPr).Elements(W.tcBorders).FirstOrDefault() != null)
                {
                    ResolveCellBorder(thisCell.Element(W.tcPr).Element(W.tcBorders).Element(W.right), cellRight.Element(W.tcPr).Element(W.tcBorders).Element(W.left));
                }
            }
        }

        private static Dictionary<string, int> BorderTypePriority = new Dictionary<string, int>()
        {
            { "single", 1 },
            { "thick", 2 },
            { "double", 3 },
            { "dotted", 4 },
        };

        private static Dictionary<string, int> BorderNumber = new Dictionary<string, int>()
        {
            {"single", 1 },
            {"thick", 2 },
            {"double", 3 },
            {"dotted", 4 },
            {"dashed", 5 },
            {"dotDash", 5 },
            {"dotDotDash", 5 },
            {"triple", 6 },
            {"thinThickSmallGap", 6 },
            {"thickThinSmallGap", 6 },
            {"thinThickThinSmallGap", 6 },
            {"thinThickMediumGap", 6 },
            {"thickThinMediumGap", 6 },
            {"thinThickThinMediumGap", 6 },
            {"thinThickLargeGap", 6 },
            {"thickThinLargeGap", 6 },
            {"thinThickThinLargeGap", 6 },
            {"wave", 7 },
            {"doubleWave", 7 },
            {"dashSmallGap", 5 },
            {"dashDotStroked", 5 },
            {"threeDEmboss", 7 },
            {"threeDEngrave", 7 },
            {"outset", 7 },
            {"inset", 7 },
        };

        private static void ResolveCellBorder(XElement border1, XElement border2)
        {
            if (border1 == null || border2 == null)
                return;
            if ((string)border1.Attribute(W.val) == "nil" || (string)border2.Attribute(W.val) == "nil")
                return;
            if ((string)border1.Attribute(W.sz) == "nil" || (string)border2.Attribute(W.sz) == "nil")
                return;

            var border1Val = (string)border1.Attribute(W.val);
            var border1Weight = 1;
            if (BorderNumber.ContainsKey(border1Val))
                border1Weight = BorderNumber[border1Val];

            var border2Val = (string)border2.Attribute(W.val);
            var border2Weight = 1;
            if (BorderNumber.ContainsKey(border2Val))
                border2Weight = BorderNumber[border2Val];

            if (border1Weight != border2Weight)
            {
                if (border1Weight < border2Weight)
                    BorderOverride(border2, border1);
                else
                    BorderOverride(border1, border2);
            }

            if ((decimal)border1.Attribute(W.sz) > (decimal)border2.Attribute(W.sz))
            {
                BorderOverride(border1, border2);
                return;
            }

            if ((decimal)border1.Attribute(W.sz) < (decimal)border2.Attribute(W.sz))
            {
                BorderOverride(border2, border1);
                return;
            }

            var border1Type = (string)border1.Attribute(W.val);
            var border2Type = (string)border2.Attribute(W.val);
            if (BorderTypePriority.ContainsKey(border1Type) &&
                BorderTypePriority.ContainsKey(border2Type))
            {
                var border1Pri = BorderTypePriority[border1Type];
                var border2Pri = BorderTypePriority[border2Type];
                if (border1Pri < border2Pri)
                {
                    BorderOverride(border2, border1);
                    return;
                }
                if (border2Pri < border1Pri)
                {
                    BorderOverride(border1, border2);
                    return;
                }
            }

            var color1str = (string)border1.Attribute(W.color);
            if (color1str == "auto")
                color1str = "000000";
            var color2str = (string)border2.Attribute(W.color);
            if (color2str == "auto")
                color2str = "000000";
            if (color1str != null && color2str != null && color1str != color2str)
            {
                try
                {
                    var color1 = Convert.ToInt32(color1str, 16);
                    var color2 = Convert.ToInt32(color2str, 16);
                    if (color1 < color2)
                    {
                        BorderOverride(border1, border2);
                        return;
                    }
                    if (color2 < color1)
                    {
                        BorderOverride(border2, border1);
                        return;
                    }
                }
                // if the above throws ArgumentException, FormatException, or OverflowException, then abort
                catch (Exception)
                {
                    return;
                }
            }
        }

        private static void BorderOverride(XElement fromBorder, XElement toBorder)
        {
            toBorder.Attribute(W.val).Value = fromBorder.Attribute(W.val).Value;
            if (fromBorder.Attribute(W.color) != null)
                toBorder.SetAttributeValue(W.color, fromBorder.Attribute(W.color).Value);
            if (fromBorder.Attribute(W.sz) != null)
                toBorder.SetAttributeValue(W.sz, fromBorder.Attribute(W.sz).Value);
            if (fromBorder.Attribute(W.themeColor) != null)
                toBorder.SetAttributeValue(W.themeColor, fromBorder.Attribute(W.themeColor).Value);
            if (fromBorder.Attribute(W.themeTint) != null)
                toBorder.SetAttributeValue(W.themeTint, fromBorder.Attribute(W.themeTint).Value);
        }

        private static void CalculateSpanWidthForTabs(WordprocessingDocument wordDoc)
        {
            // Note: when implementing a paging version of the HTML transform, this needs to be done
            // for all content parts, not just the main document part.

            // w:defaultTabStop in settings
            var defaultTabStop = (int?)wordDoc.MainDocumentPart.DocumentSettingsPart.GetXDocument().Descendants(W.defaultTabStop).Attributes(W.val).FirstOrDefault();
            if (defaultTabStop == null)
                defaultTabStop = 720;

            XDocument pxd = wordDoc.MainDocumentPart.GetXDocument();
            XElement newRoot = (XElement)CalculateSpanWidthTransform(pxd.Root, (int)defaultTabStop);
            pxd.Root.ReplaceWith(newRoot);
            wordDoc.MainDocumentPart.PutXDocument();
        }

        private static object CalculateSpanWidthTransform(XNode node, int defaultTabStop)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                // if there are no tabs in the paragraph, then no need to continue processing for the paragraph.
                if (element.Name == W.p)
                {
                    if (element.DescendantsTrimmed(W.txbxContent).Where(d => d.Name == W.r).Elements(W.tab).Any())
                    {
                        var clonedPara = new XElement(element);

                        var leftInTwips = 0;
                        var firstInTwips = 0;

                        var ind = clonedPara.Elements(W.pPr).Elements(W.ind).FirstOrDefault();
                        if (ind != null)
                        {
                            // todo need to handle start and end attributes

                            var left = (int?)ind.Attribute(W.left);
                            if (left != null)
                                leftInTwips = (int)left;

                            var firstLine = 0;
                            var firstLineAtt = (int?)ind.Attribute(W.firstLine);
                            if (firstLineAtt != null)
                                firstLine = (int)firstLineAtt;

                            var hangingAtt = (int?)ind.Attribute(W.hanging);
                            if (hangingAtt != null)
                                firstLine = -(int)hangingAtt;

                            firstInTwips = leftInTwips + firstLine;
                        }

                        // calculate the tab stops, in twips
                        var tabs = clonedPara
                            .Elements(W.pPr)
                            .Elements(W.tabs)
                            .FirstOrDefault();

                        if (tabs == null)
                        {
                            if (leftInTwips == 0)
                            {
                                tabs = new XElement(W.tabs,
                                    Enumerable.Range(1, 100)
                                        .Select(r => new XElement(W.tab,
                                            new XAttribute(W.val, "left"),
                                            new XAttribute(W.pos, r * defaultTabStop))));
                            }
                            else
                            {
                                tabs = new XElement(W.tabs,
                                    new XElement(W.tab,
                                        new XAttribute(W.val, "left"),
                                        new XAttribute(W.pos, leftInTwips)));
                                tabs = AddDefaultTabsAfterLastTab(tabs, defaultTabStop);
                            }
                        }
                        else
                        {
                            if (leftInTwips != 0)
                            {
                                tabs.Add(
                                    new XElement(W.tab,
                                        new XAttribute(W.val, "left"),
                                        new XAttribute(W.pos, leftInTwips)));
                            }
                            tabs = AddDefaultTabsAfterLastTab(tabs, defaultTabStop);
                        }

                        var twipCounter = firstInTwips;
                        var contentToMeasure = element.DescendantsTrimmed(z => z.Name == W.txbxContent || z.Name == W.pPr || z.Name == W.rPr).ToArray();
                        var currentElementIdx = 0;
                        while (true)
                        {
                            var currentElement = contentToMeasure[currentElementIdx];

                            if (currentElement.Name == W.br)
                            {
                                twipCounter = leftInTwips;

                                currentElement.Add(
                                    new XAttribute(PtOpenXml.TabWidth, string.Format("{0:0.00}", (decimal)firstInTwips / 1440m)));

                                currentElementIdx++;
                                if (currentElementIdx >= contentToMeasure.Length)
                                    break; // we're done
                            }

                            if (currentElement.Name == W.tab)
                            {
                                var runContainingTabToReplace = currentElement.Parent;
                                var fontNameAtt = runContainingTabToReplace.Attribute(PtOpenXml.pt + "FontName");
                                if (fontNameAtt == null)
                                    fontNameAtt = runContainingTabToReplace.Ancestors(W.p).First()
                                        .Attribute(PtOpenXml.pt + "FontName");

                                var testAmount = twipCounter;

                                var tabAfterText = tabs
                                    .Elements(W.tab)
                                    .FirstOrDefault(t => (int)t.Attribute(W.pos) > testAmount);

                                if (tabAfterText == null)
                                {
                                    // something has gone wrong, so put 1/2 inch in
                                    if (currentElement.Attribute(PtOpenXml.TabWidth) == null)
                                        currentElement.Add(
                                            new XAttribute(PtOpenXml.TabWidth, 720m));
                                    break;
                                }

                                var tabVal = (string)tabAfterText.Attribute(W.val);
                                if (tabVal == "right" || tabVal == "end")
                                {
                                    var textAfterElements = contentToMeasure
                                        .Skip(currentElementIdx + 1);

                                    // take all the content until another tab, br, or cr
                                    var textElementsToMeasure = textAfterElements
                                        .TakeWhile(z =>
                                            z.Name != W.tab &&
                                            z.Name != W.br &&
                                            z.Name != W.cr)
                                        .ToList();

                                    var textAfterTab = textElementsToMeasure
                                        .Where(z => z.Name == W.t)
                                        .Select(t => (string)t)
                                        .StringConcatenate();

                                    var dummyRun2 = new XElement(W.r,
                                        fontNameAtt,
                                        runContainingTabToReplace.Elements(W.rPr),
                                        new XElement(W.t, textAfterTab));

                                    var widthOfTextAfterTab = CalcWidthOfRunInTwips(dummyRun2);
                                    var delta2 = (int)tabAfterText.Attribute(W.pos) - widthOfTextAfterTab - twipCounter;
                                    if (delta2 < 0)
                                        delta2 = 0;
                                    currentElement.Add(new XAttribute(PtOpenXml.TabWidth, string.Format("{0:0.00}", (decimal)delta2 / 1440m)),
                                        GetLeader(tabAfterText));
                                    twipCounter = Math.Max((int)tabAfterText.Attribute(W.pos), twipCounter + widthOfTextAfterTab);
                                    var lastElement = textElementsToMeasure.LastOrDefault();
                                    if (lastElement == null)
                                        break; // we're done
                                    currentElementIdx = Array.IndexOf(contentToMeasure, lastElement) + 1;
                                    if (currentElementIdx >= contentToMeasure.Length)
                                        break; // we're done
                                    continue;
                                }
                                else if (tabVal == "decimal")
                                {
                                    var textAfterElements = contentToMeasure
                                        .Skip(currentElementIdx + 1);

                                    // take all the content until another tab, br, or cr
                                    var textElementsToMeasure = textAfterElements
                                        .TakeWhile(z =>
                                            z.Name != W.tab &&
                                            z.Name != W.br &&
                                            z.Name != W.cr)
                                        .ToList();

                                    var textAfterTab = textElementsToMeasure
                                        .Where(z => z.Name == W.t)
                                        .Select(t => (string)t)
                                        .StringConcatenate();

                                    if (textAfterTab.Contains("."))
                                    {
                                        var mantissa = textAfterTab.Split('.')[0];

                                        var dummyRun4 = new XElement(W.r,
                                            fontNameAtt,
                                            runContainingTabToReplace.Elements(W.rPr),
                                            new XElement(W.t, mantissa));

                                        var widthOfMantissa = CalcWidthOfRunInTwips(dummyRun4);
                                        var delta2 = (int)tabAfterText.Attribute(W.pos) - widthOfMantissa - twipCounter;
                                        if (delta2 < 0)
                                            delta2 = 0;
                                        currentElement.Add(
                                            new XAttribute(PtOpenXml.TabWidth, string.Format("{0:0.00}", (decimal)delta2 / 1440m)),
                                            GetLeader(tabAfterText)
                                        );

                                        var decims = textAfterTab.Substring(textAfterTab.IndexOf('.'));
                                        dummyRun4 = new XElement(W.r,
                                            fontNameAtt,
                                            runContainingTabToReplace.Elements(W.rPr),
                                            new XElement(W.t, decims));

                                        var widthOfDecims = CalcWidthOfRunInTwips(dummyRun4);

                                        twipCounter = Math.Max((int)tabAfterText.Attribute(W.pos) + widthOfDecims, twipCounter + widthOfMantissa + widthOfDecims);

                                        var lastElement = textElementsToMeasure.LastOrDefault();
                                        if (lastElement == null)
                                            break; // we're done
                                        currentElementIdx = Array.IndexOf(contentToMeasure, lastElement) + 1;
                                        if (currentElementIdx >= contentToMeasure.Length)
                                            break; // we're done
                                        continue;
                                    }
                                    else
                                    {
                                        var dummyRun2 = new XElement(W.r,
                                            fontNameAtt,
                                            runContainingTabToReplace.Elements(W.rPr),
                                            new XElement(W.t, textAfterTab));

                                        var widthOfTextAfterTab = CalcWidthOfRunInTwips(dummyRun2);
                                        var delta2 = (int)tabAfterText.Attribute(W.pos) - widthOfTextAfterTab - twipCounter;
                                        if (delta2 < 0)
                                            delta2 = 0;
                                        currentElement.Add(
                                            new XAttribute(PtOpenXml.TabWidth, string.Format("{0:0.00}", (decimal)delta2 / 1440m)),
                                            GetLeader(tabAfterText)
                                        );

                                        twipCounter = Math.Max((int)tabAfterText.Attribute(W.pos), twipCounter + widthOfTextAfterTab);

                                        var lastElement = textElementsToMeasure.LastOrDefault();
                                        if (lastElement == null)
                                            break; // we're done
                                        currentElementIdx = Array.IndexOf(contentToMeasure, lastElement) + 1;
                                        if (currentElementIdx >= contentToMeasure.Length)
                                            break; // we're done
                                        continue;
                                    }
                                }
                                else if ((string)tabAfterText.Attribute(W.val) == "center")
                                {
                                    var textAfterElements = contentToMeasure
                                        .Skip(currentElementIdx + 1);

                                    // take all the content until another tab, br, or cr
                                    var textElementsToMeasure = textAfterElements
                                        .TakeWhile(z =>
                                            z.Name != W.tab &&
                                            z.Name != W.br &&
                                            z.Name != W.cr)
                                        .ToList();

                                    var textAfterTab = textElementsToMeasure
                                        .Where(z => z.Name == W.t)
                                        .Select(t => (string)t)
                                        .StringConcatenate();

                                    var dummyRun4 = new XElement(W.r,
                                        fontNameAtt,
                                        runContainingTabToReplace.Elements(W.rPr),
                                        new XElement(W.t, textAfterTab));

                                    var widthOfText = CalcWidthOfRunInTwips(dummyRun4);
                                    var delta2 = (int)tabAfterText.Attribute(W.pos) - (widthOfText / 2) - twipCounter;
                                    if (delta2 < 0)
                                        delta2 = 0;
                                    currentElement.Add(
                                        new XAttribute(PtOpenXml.TabWidth, string.Format("{0:0.00}", (decimal)delta2 / 1440m)),
                                        GetLeader(tabAfterText)
                                    );

                                    twipCounter = Math.Max((int)tabAfterText.Attribute(W.pos) + widthOfText / 2, twipCounter + widthOfText);

                                    var lastElement = textElementsToMeasure.LastOrDefault();
                                    if (lastElement == null)
                                        break; // we're done
                                    currentElementIdx = Array.IndexOf(contentToMeasure, lastElement) + 1;
                                    if (currentElementIdx >= contentToMeasure.Length)
                                        break; // we're done
                                    continue;
                                }
                                if (tabVal == "left" || tabVal == "start" || tabVal == "num")
                                {
                                    var delta = (int)tabAfterText.Attribute(W.pos) - twipCounter;
                                    currentElement.Add(
                                        new XAttribute(PtOpenXml.TabWidth, string.Format("{0:0.00}", (decimal)delta / 1440m)),
                                        GetLeader(tabAfterText)
                                    );
                                    twipCounter = (int)tabAfterText.Attribute(W.pos);
                                    currentElementIdx++;
                                    if (currentElementIdx >= contentToMeasure.Length)
                                        break; // we're done
                                    continue;
                                }
                            }

                            if (currentElement.Name == W.t)
                            {
                                var runContainingTabToReplace = currentElement.Parent;
                                var paragraphForRun = runContainingTabToReplace.Ancestors(W.p).First();
                                var fontNameAtt = runContainingTabToReplace.Attribute(PtOpenXml.FontName);
                                if (fontNameAtt == null)
                                    fontNameAtt = paragraphForRun.Attribute(PtOpenXml.FontName);
                                var languageTypeAtt = runContainingTabToReplace.Attribute(PtOpenXml.LanguageType);
                                if (languageTypeAtt == null)
                                    languageTypeAtt = paragraphForRun.Attribute(PtOpenXml.LanguageType);

                                var dummyRun3 = new XElement(W.r,
                                    fontNameAtt,
                                    languageTypeAtt,
                                    runContainingTabToReplace.Elements(W.rPr),
                                    currentElement);
                                var widthOfText = CalcWidthOfRunInTwips(dummyRun3);
                                twipCounter += widthOfText;
                                currentElementIdx++;
                                if (currentElementIdx >= contentToMeasure.Length)
                                    break; // we're done
                                continue;
                            }

                            currentElementIdx++;
                            if (currentElementIdx >= contentToMeasure.Length)
                                break; // we're done
                        }

                    }
                    else
                    {
                        return new XElement(element.Name,
                            element.Attributes(),
                            element.Nodes().Select(n => CalculateSpanWidthTransform(n, defaultTabStop)));
                    }
                }

                return new XElement(element.Name,
                    element.Attributes(),
                    element.Nodes().Select(n => CalculateSpanWidthTransform(n, defaultTabStop)));
            }
            return node;
        }

        private static XAttribute GetLeader(XElement tabAfterText)
        {
            var leader = (string)tabAfterText.Attribute(W.leader);
            if (leader == null)
                return null;
            return new XAttribute(PtOpenXml.Leader, leader);
        }

        private static XElement AddDefaultTabsAfterLastTab(XElement tabs, int defaultTabStop)
        {
            var lastTabElement = tabs
                .Elements(W.tab)
                .Where(t => (string)t.Attribute(W.val) != "clear" && (string)t.Attribute(W.val) != "bar")
                .OrderBy(t => (int)t.Attribute(W.pos))
                .LastOrDefault();
            int rangeStart = 1;
            if (lastTabElement != null)
            {
                if (defaultTabStop == 0)
                    defaultTabStop = 720;
                rangeStart = (int)lastTabElement.Attribute(W.pos) / defaultTabStop + 1;
                var tempTabs = new XElement(W.tabs,
                    tabs.Elements().Where(t => (string)t.Attribute(W.val) != "clear" && (string)t.Attribute(W.val) != "bar"),
                    Enumerable.Range(rangeStart, 100)
                    .Select(r => new XElement(W.tab,
                        new XAttribute(W.val, "left"),
                        new XAttribute(W.pos, r * defaultTabStop))));
                tempTabs = new XElement(W.tabs,
                    tempTabs.Elements().OrderBy(t => (int)t.Attribute(W.pos)));
                return tempTabs;
            }
            else
            {
                tabs = new XElement(W.tabs,
                    Enumerable.Range(1, 100)
                    .Select(r => new XElement(W.tab,
                        new XAttribute(W.val, "left"),
                        new XAttribute(W.pos, r * defaultTabStop))));
            }
            return tabs;
        }

        private static HashSet<string> UnknownFonts = new HashSet<string>();
        private static HashSet<string> KnownFamilies = null;

        private static int CalcWidthOfRunInTwips(XElement r)
        {
            if (KnownFamilies == null)
            {
                KnownFamilies = new HashSet<string>();
                var families = FontFamily.Families;
                foreach (var fam in families)
                    KnownFamilies.Add(fam.Name);
            }

            var fontName = (string)r.Attribute(PtOpenXml.pt + "FontName");
            if (fontName == null)
                fontName = (string)r.Ancestors(W.p).First().Attribute(PtOpenXml.pt + "FontName");
            if (fontName == null)
                throw new OpenXmlPowerToolsException("Internal Error, should have FontName attribute");
            if (UnknownFonts.Contains(fontName))
                return 0;

            var rPr = r.Element(W.rPr);
            if (rPr == null)
                throw new OpenXmlPowerToolsException("Internal Error, should have run properties");

            var languageType = (string)r.Attribute(PtOpenXml.LanguageType);
            decimal? sz = null;
            if (languageType == "bidi")
                sz = (decimal?)rPr.Elements(W.szCs).Attributes(W.val).FirstOrDefault();
            else
                sz = (decimal?)rPr.Elements(W.sz).Attributes(W.val).FirstOrDefault();
            if (sz == null)
                sz = 22m;

            // unknown font families will throw ArgumentException, in which case just return 0
            if (!KnownFamilies.Contains(fontName))
                return 0;

            // in theory, all unknown fonts are found by the above test, but if not...
            FontFamily ff;
            try
            {
                ff = new FontFamily(fontName);
            }
            catch (ArgumentException)
            {
                UnknownFonts.Add(fontName);

                return 0;
            }
            FontStyle fs = FontStyle.Regular;
            var bold = getBoolProp(rPr, W.b) || getBoolProp(rPr, W.bCs);
            var italic = getBoolProp(rPr, W.i) || getBoolProp(rPr, W.iCs);
            if (bold && !italic)
                fs = FontStyle.Bold;
            if (italic && !bold)
                fs = FontStyle.Italic;
            if (bold && italic)
                fs = FontStyle.Bold | FontStyle.Italic;

            var runText = r.DescendantsTrimmed(W.txbxContent)
                .Where(e => e.Name == W.t)
                .Select(t => (string)t)
                .StringConcatenate();

            var tabLength = r.DescendantsTrimmed(W.txbxContent)
                .Where(e => e.Name == W.tab)
                .Select(t => (decimal)t.Attribute(PtOpenXml.TabWidth))
                .Sum();

            if (runText.Length == 0 && tabLength == 0)
                return 0;

            int multiplier = 1;
            if (runText.Length <= 2)
                multiplier = 100;
            else if (runText.Length <= 4)
                multiplier = 50;
            else if (runText.Length <= 8)
                multiplier = 25;
            else if (runText.Length <= 16)
                multiplier = 12;
            else if (runText.Length <= 32)
                multiplier = 6;
            if (multiplier != 1)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < multiplier; i++)
                    sb.Append(runText);
                runText = sb.ToString();
            }

            try
            {
                using (Font f = new Font(ff, (float)sz / 2f, fs))
                {
                    System.Windows.Forms.TextFormatFlags tff = System.Windows.Forms.TextFormatFlags.NoPadding;
                    Size proposedSize = new Size(int.MaxValue, int.MaxValue);
                    var sf = System.Windows.Forms.TextRenderer.MeasureText(runText, f, proposedSize, tff); // sf returns size in pixels
                    var dpi = 96m;
                    var twip = (int)(((sf.Width / dpi) * 1440m) / multiplier + tabLength * 1440m);
                    return twip;
                }
            }
            catch (ArgumentException)
            {
                try
                {
                    var fs2 = FontStyle.Regular;
                    using (Font f = new Font(ff, (float)sz / 2f, fs2))
                    {
                        System.Windows.Forms.TextFormatFlags tff = System.Windows.Forms.TextFormatFlags.NoPadding;
                        Size proposedSize = new Size(int.MaxValue, int.MaxValue);
                        var sf = System.Windows.Forms.TextRenderer.MeasureText(runText, f, proposedSize, tff); // sf returns size in pixels
                        var dpi = 96m;
                        var twip = (int)(((sf.Width / dpi) * 1440m) / multiplier + tabLength * 1440m);
                        return twip;
                    }
                }
                catch (ArgumentException)
                {
                    var fs2 = FontStyle.Bold;
                    try
                    {
                        using (Font f = new Font(ff, (float)sz / 2f, fs2))
                        {
                            System.Windows.Forms.TextFormatFlags tff = System.Windows.Forms.TextFormatFlags.NoPadding;
                            Size proposedSize = new Size(int.MaxValue, int.MaxValue);
                            var sf = System.Windows.Forms.TextRenderer.MeasureText(runText, f, proposedSize, tff); // sf returns size in pixels
                            var dpi = 96m;
                            var twip = (int)(((sf.Width / dpi) * 1440m) / multiplier + tabLength * 1440m);
                            return twip;
                        }
                    }
                    catch (ArgumentException)
                    {
                        // if both regular and bold fail, then get metrics for Times New Roman
                        // use the original FontStyle (in fs)
                        FontFamily ff2;
                        ff2 = new FontFamily("Times New Roman");
                        using (Font f = new Font(ff2, (float)sz / 2f, fs))
                        {
                            System.Windows.Forms.TextFormatFlags tff = System.Windows.Forms.TextFormatFlags.NoPadding;
                            Size proposedSize = new Size(int.MaxValue, int.MaxValue);
                            var sf = System.Windows.Forms.TextRenderer.MeasureText(runText, f, proposedSize, tff); // sf returns size in pixels
                            var dpi = 96m;
                            var twip = (int)(((sf.Width / dpi) * 1440m) / multiplier + tabLength * 1440m);
                            return twip;
                        }
                    }
                }
            }
        }

        private static void InsertAppropriateNonbreakingSpaces(WordprocessingDocument wordDoc)
        {
            foreach (var part in wordDoc.ContentParts())
            {
                XDocument pxd = part.GetXDocument();
                XElement newRoot = (XElement)InsertAppropriateNonbreakingSpacesTransform(pxd.Root);
                pxd.Root.ReplaceWith(newRoot);
                part.PutXDocument();
            }
        }

        private static object InsertAppropriateNonbreakingSpacesTransform(XNode node)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                // child content of run to look for
                // W.br
                // W.cr
                // W.dayLong
                // W.dayShort
                // W.drawing
                // W.monthLong
                // W.monthShort
                // W.noBreakHyphen
                // W.object
                // W.pgNum
                // W.pTab
                // W.separator
                // W.softHyphen
                // W.sym
                // W.t
                // W.tab
                // W.yearLong
                // W.yearShort
                if (element.Name == W.p)
                {
                    bool hasContent = element
                        .Elements()
                        .Where(e => e.Name != W.pPr)
                        .DescendantsAndSelf()
                        .Any(e =>
                            e.Name == W.dayLong ||
                            e.Name == W.dayShort ||
                            e.Name == W.drawing ||
                            e.Name == W.monthLong ||
                            e.Name == W.monthShort ||
                            e.Name == W.noBreakHyphen ||
                            e.Name == W._object ||
                            e.Name == W.pgNum ||
                            e.Name == W.ptab ||
                            e.Name == W.separator ||
                            e.Name == W.softHyphen ||
                            e.Name == W.sym ||
                            e.Name == W.t ||
                            e.Name == W.tab ||
                            e.Name == W.yearLong ||
                            e.Name == W.yearShort
                        );
                    if (hasContent == false)
                        return new XElement(element.Name,
                            element.Attributes(),
                            element.Nodes().Select(n => InsertAppropriateNonbreakingSpacesTransform(n)),
                            new XElement(W.r,
                                element.Elements(W.pPr).Elements(W.rPr),
                                new XElement(W.t,
                                    "\x00A0")));
                }

                if (element.Name == W.t)
                {
                    var val = element.Value;
                    if (val.Contains("  "))
                    {
                        while (val.Contains("  "))
                            val = val.Replace("  ", " \x00A0");
                        element.Value = val;
                    }
                }

                return new XElement(element.Name,
                    element.Attributes(),
                    element.Nodes().Select(n => InsertAppropriateNonbreakingSpacesTransform(n)));
            }
            return node;
        }

        private class SectionAnnotation
        {
            public XElement SectionElement;
        }

        private static void AnnotateForSections(WordprocessingDocument wordDoc)
        {
            var xd = wordDoc.MainDocumentPart.GetXDocument();

            // move last sectPr into last paragraph
            var lastSectPr = xd.Root.Element(W.body).Elements(W.sectPr).LastOrDefault();
            if (lastSectPr != null)
            {
                // if the last thing in the document is a table, Word will always insert a paragraph following that.
                var lastPara = xd
                    .Root
                    .Element(W.body)
                    .DescendantsTrimmed(W.txbxContent)
                    .Where(p => p.Name == W.p)
                    .LastOrDefault();

                if (lastPara != null)
                {
                    var lastParaProps = lastPara.Element(W.pPr);
                    if (lastParaProps != null)
                        lastParaProps.Add(lastSectPr);
                    else
                        lastParaProps.Add(new XElement(W.pPr,
                            lastSectPr));
                    lastSectPr.Remove();
                }
            }

            var reverseDescendants = xd
                .Descendants()
                .Reverse()
                .ToList();
            var currentSection = new SectionAnnotation()
            {
                SectionElement = reverseDescendants.Where(e => e.Name == W.sectPr).FirstOrDefault()
            };
            if (currentSection.SectionElement != null &&
                currentSection.SectionElement.Attribute(XNamespace.Xmlns + "w") == null)
                currentSection.SectionElement.Add(new XAttribute(XNamespace.Xmlns + "w", W.w));

            // todo what should the default section props be?
            if (currentSection == null || currentSection.SectionElement == null)
                currentSection = new SectionAnnotation()
                {
                    SectionElement = new XElement(W.sectPr,
                        new XAttribute(XNamespace.Xmlns + "w", W.w),
                        new XElement(W.pgSz,
                            new XAttribute(W._w, 12240),
                            new XAttribute(W.h, 15840)),
                        new XElement(W.pgMar,
                            new XAttribute(W.top, 1440),
                            new XAttribute(W.right, 1440),
                            new XAttribute(W.bottom, 1440),
                            new XAttribute(W.left, 1440),
                            new XAttribute(W.header, 720),
                            new XAttribute(W.footer, 720),
                            new XAttribute(W.gutter, 0)),
                        new XElement(W.cols,
                            new XAttribute(W.space, 720)),
                        new XElement(W.docGrid,
                            new XAttribute(W.linePitch, 360)))
                };

            foreach (var d in reverseDescendants)
            {
                if (d.Name == W.sectPr)
                {
                    if (d.Attribute(XNamespace.Xmlns + "w") == null)
                        d.Add(new XAttribute(XNamespace.Xmlns + "w", W.w));

                    currentSection = new SectionAnnotation()
                    {
                        SectionElement = d
                    };
                }
                else
                    d.AddAnnotation(currentSection);
            }
        }

        private static object CreateBorderDivs(WordprocessingDocument wordDoc, HtmlConverterSettings settings, IEnumerable<XElement> elements)
        {
            return elements.GroupAdjacent(e =>
                {
                    if (e.Elements(W.pPr).Elements(W.pBdr).Any())
                    {
                        var pBdr = e.Element(W.pPr).Element(W.pBdr);
                        var indStr = "";
                        var ind = e.Element(W.pPr).Element(W.ind);
                        if (ind != null)
                            indStr = ind.ToString(SaveOptions.DisableFormatting);
                        return pBdr.ToString(SaveOptions.DisableFormatting) + indStr;
                    }
                    else if (e.Name == W.tbl)
                    {
                        return "table";
                    }
                    else
                    {
                        return ""; // empty string means no pBdr
                    }
                })
                .Select(g =>
                {
                    if (g.Key == "")
                    {
                        var o = GroupAndVerticallySpaceNumberedParagraphs(wordDoc, settings, g, 0m);
                        return (object)o;
                    }
                    if (g.Key == "table")
                    {
                        var o = g.Select(gc => ConvertToHtmlTransform(wordDoc,
                            settings, gc, false, 0));
                        return o;
                    }
                    var pPr = g.First().Element(W.pPr);
                    var pBdr = pPr.Element(W.pBdr);
                    Dictionary<string, string> style = new Dictionary<string, string>();
                    GenerateBorderStyle(pBdr, W.top, style, BorderType.Paragraph);
                    GenerateBorderStyle(pBdr, W.right, style, BorderType.Paragraph);
                    GenerateBorderStyle(pBdr, W.bottom, style, BorderType.Paragraph);
                    GenerateBorderStyle(pBdr, W.left, style, BorderType.Paragraph);
                    var ind = pPr.Element(W.ind);
                    decimal currentMarginLeft = 0m;
                    if (ind != null)
                    {
                        decimal? left = (decimal?)ind.Attribute(W.left);
                        decimal leftInInches = 0;
                        if (left != null)
                            leftInInches = (decimal)left / 1440;
                        decimal? hanging = (decimal?)ind.Attribute(W.hanging);
                        decimal hangingInInches = 0;
                        if (hanging != null)
                            hangingInInches = -(decimal)hanging / 1440;
                        currentMarginLeft = leftInInches + hangingInInches;
                        style.AddIfMissing("margin-left", string.Format("{0:0.00}in", currentMarginLeft));
                    }

                    var div = new XElement(Xhtml.div,
                        GroupAndVerticallySpaceNumberedParagraphs(wordDoc, settings, g, currentMarginLeft));

                    div.AddAnnotation(style);
                    return div;
                })
            .ToList();
        }

        private static IEnumerable<object> GroupAndVerticallySpaceNumberedParagraphs(WordprocessingDocument wordDoc, HtmlConverterSettings settings,
            IEnumerable<XElement> elements, decimal currentMarginLeft)
        {
            var grouped = elements
                .GroupAdjacent(e =>
                {
                    var abstractNumId = (string)e.Attribute(PtOpenXml.pt + "AbstractNumId");
                    if (abstractNumId != null)
                        return "num:" + abstractNumId;
                    var contextualSpacing = e.Elements(W.pPr).Elements(W.contextualSpacing).FirstOrDefault();
                    if (contextualSpacing != null)
                    {
                        var styleName = (string)e.Elements(W.pPr).Elements(W.pStyle).Attributes(W.val).FirstOrDefault();
                        if (styleName == null)
                            return "";
                        return "sty:" + styleName;
                    }
                    return "";
                })
                .ToList();
            var newContent = grouped
                .Select(g =>
                {
                    if (g.Key == "")
                        return g.Select(e =>
                        {
                            return ConvertToHtmlTransform(wordDoc, settings, e, false, currentMarginLeft);
                        });
                    var last = g.Count() - 1;
                    var content = g
                        .Select((e, i) =>
                        {
                            if (i == last)
                                return ConvertToHtmlTransform(wordDoc, settings, e, false, currentMarginLeft);
                            else
                                return ConvertToHtmlTransform(wordDoc, settings, e, true, currentMarginLeft);
                        });
                    return content;
                });
            return newContent;
        }

        private class BorderMappingInfo
        {
            public string CssName;
            public decimal CssSize;
        }

        private static Dictionary<string, BorderMappingInfo> BorderStyleMap = new Dictionary<string, BorderMappingInfo>()
        {
            { "single", new BorderMappingInfo() { CssName = "solid", CssSize = 1.0m }},
            { "dotted", new BorderMappingInfo() { CssName = "dotted", CssSize = 1.0m }},
            { "dashSmallGap", new BorderMappingInfo() { CssName = "dashed", CssSize = 1.0m }},
            { "dashed", new BorderMappingInfo() { CssName = "dashed", CssSize = 1.0m }},
            { "dotDash", new BorderMappingInfo() { CssName = "dashed", CssSize = 1.0m }},
            { "dotDotDash", new BorderMappingInfo() { CssName = "dashed", CssSize = 1.0m }},
            { "double", new BorderMappingInfo() { CssName = "double", CssSize = 2.5m }},
            { "triple", new BorderMappingInfo() { CssName = "double", CssSize = 2.5m }},
            { "thinThickSmallGap", new BorderMappingInfo() { CssName = "double", CssSize = 4.5m }},
            { "thickThinSmallGap", new BorderMappingInfo() { CssName = "double", CssSize = 4.5m }},
            { "thinThickThinSmallGap", new BorderMappingInfo() { CssName = "double", CssSize = 6.0m }},
            { "thickThinMediumGap", new BorderMappingInfo() { CssName = "double", CssSize = 6.0m }},
            { "thinThickMediumGap", new BorderMappingInfo() { CssName = "double", CssSize = 6.0m }},
            { "thinThickThinMediumGap", new BorderMappingInfo() { CssName = "double", CssSize = 9.0m }},
            { "thinThickLargeGap", new BorderMappingInfo() { CssName = "double", CssSize = 5.25m }},
            { "thickThinLargeGap", new BorderMappingInfo() { CssName = "double", CssSize = 5.25m }},
            { "thinThickThinLargeGap", new BorderMappingInfo() { CssName = "double", CssSize = 9.0m }},
            { "wave", new BorderMappingInfo() { CssName = "solid", CssSize = 3.0m }},
            { "doubleWave", new BorderMappingInfo() { CssName = "double", CssSize = 5.25m }},
            { "dashDotStroked", new BorderMappingInfo() { CssName = "solid", CssSize = 3.0m }},
            { "threeDEmboss", new BorderMappingInfo() { CssName = "ridge", CssSize = 6.0m }},
            { "threeDEngrave", new BorderMappingInfo() { CssName = "groove", CssSize = 6.0m }},
            { "outset", new BorderMappingInfo() { CssName = "outset", CssSize = 4.5m }},
            { "inset", new BorderMappingInfo() { CssName = "inset", CssSize = 4.5m }},
        };

        private static void GenerateBorderStyle(XElement pBdr, XName sideXName, Dictionary<string, string> style, BorderType borderType)
        {
            string whichSide;
            if (sideXName == W.top)
                whichSide = "top";
            else if (sideXName == W.right)
                whichSide = "right";
            else if (sideXName == W.bottom)
                whichSide = "bottom";
            else
                whichSide = "left";
            if (pBdr == null)
            {
                style.Add("border-" + whichSide, "none");
                if (borderType == BorderType.Cell &&
                    (whichSide == "left" || whichSide == "right"))
                    style.Add("padding-" + whichSide, "5.4pt");
                return;
            }

            var side = pBdr.Element(sideXName);
            if (side == null)
            {
                style.Add("border-" + whichSide, "none");
                if (borderType == BorderType.Cell &&
                    (whichSide == "left" || whichSide == "right"))
                    style.Add("padding-" + whichSide, "5.4pt");
                return;
            }
            var type = (string)side.Attribute(W.val);
            if (type == "nil" || type == "none")
            {
                style.Add("border-" + whichSide + "-style", "none");

                var space = (decimal?)side.Attribute(W.space);
                if (space == null)
                    space = 0;
                if (borderType == BorderType.Cell &&
                    (whichSide == "left" || whichSide == "right"))
                    if (space < 5.4m)
                        space = 5.4m;
                style.Add("padding-" + whichSide, space == 0 ? "0in" : space.ToString() + "pt");
            }
            else
            {
                var sz = (int)side.Attribute(W.sz);
                var space = (decimal?)side.Attribute(W.space);
                if (space == null)
                    space = 0;
                var color = (string)side.Attribute(W.color);
                if (color == null || color == "auto")
                    color = "windowtext";
                else
                    color = ConvertColor(color);

                decimal borderWidthInPoints = Math.Max(1m, Math.Min(96m, Math.Max(2m, sz)) / 8m);

                var borderStyle = "solid";
                if (BorderStyleMap.ContainsKey(type))
                {
                    var borderInfo = BorderStyleMap[type];
                    borderStyle = borderInfo.CssName;
                    if (type == "double")
                    {
                        if (sz <= 8)
                            borderWidthInPoints = 2.5m;
                        else if (sz <= 18)
                            borderWidthInPoints = 6.75m;
                        else
                            borderWidthInPoints = sz / 3m;
                    }
                    else if (type == "triple")
                    {
                        if (sz <= 8)
                            borderWidthInPoints = 8m;
                        else if (sz <= 18)
                            borderWidthInPoints = 11.25m;
                        else
                            borderWidthInPoints = 11.25m;
                    }
                    else if (type.ToLower().Contains("dash"))
                    {
                        if (sz <= 4)
                            borderWidthInPoints = 1m;
                        else if (sz <= 12)
                            borderWidthInPoints = 1.5m;
                        else
                            borderWidthInPoints = 2m;
                    }
                    else if (type != "single")
                        borderWidthInPoints = borderInfo.CssSize;
                }
                if (type == "outset" || type == "inset")
                    color = "";
                var borderWidth = string.Format("{0:0.0}pt", borderWidthInPoints);

                style.Add("border-" + whichSide, borderStyle + " " + color + " " + borderWidth);
                if (borderType == BorderType.Cell &&
                    (whichSide == "left" || whichSide == "right"))
                    if (space < 5.4m)
                        space = 5.4m;

                style.Add("padding-" + whichSide, space == 0 ? "0in" : space.ToString() + "pt");
            }
        }

        private static Dictionary<string, Func<string, string, string>> ShadeMapper = new Dictionary<string,Func<string, string, string>>()
        {
            { "auto", (c, f) => c },
            { "clear", (c, f) => f },
            { "nil", (c, f) => f },
            { "solid", (c, f) => c },
            { "diagCross", (c, f) => ConvertColorFillPct(c, f, .75) },
            { "diagStripe", (c, f) => ConvertColorFillPct(c, f, .75) },
            { "horzCross", (c, f) => ConvertColorFillPct(c, f, .5) },
            { "horzStripe", (c, f) => ConvertColorFillPct(c, f, .5) },
            { "pct10", (c, f) => ConvertColorFillPct(c, f, .1) },
            { "pct12", (c, f) => ConvertColorFillPct(c, f, .125) },
            { "pct15", (c, f) => ConvertColorFillPct(c, f, .15) },
            { "pct20", (c, f) => ConvertColorFillPct(c, f, .2) },
            { "pct25", (c, f) => ConvertColorFillPct(c, f, .25) },
            { "pct30", (c, f) => ConvertColorFillPct(c, f, .3) },
            { "pct35", (c, f) => ConvertColorFillPct(c, f, .35) },
            { "pct37", (c, f) => ConvertColorFillPct(c, f, .375) },
            { "pct40", (c, f) => ConvertColorFillPct(c, f, .4) },
            { "pct45", (c, f) => ConvertColorFillPct(c, f, .45) },
            { "pct50", (c, f) => ConvertColorFillPct(c, f, .50) },
            { "pct55", (c, f) => ConvertColorFillPct(c, f, .55) },
            { "pct60", (c, f) => ConvertColorFillPct(c, f, .60) },
            { "pct62", (c, f) => ConvertColorFillPct(c, f, .625) },
            { "pct65", (c, f) => ConvertColorFillPct(c, f, .65) },
            { "pct70", (c, f) => ConvertColorFillPct(c, f, .7) },
            { "pct75", (c, f) => ConvertColorFillPct(c, f, .75) },
            { "pct80", (c, f) => ConvertColorFillPct(c, f, .8) },
            { "pct85", (c, f) => ConvertColorFillPct(c, f, .85) },
            { "pct87", (c, f) => ConvertColorFillPct(c, f, .875) },
            { "pct90", (c, f) => ConvertColorFillPct(c, f, .9) },
            { "pct95", (c, f) => ConvertColorFillPct(c, f, .95) },
            { "reverseDiagStripe", (c, f) => ConvertColorFillPct(c, f, .5) },
            { "thinDiagCross", (c, f) => ConvertColorFillPct(c, f, .5) },
            { "thinDiagStripe", (c, f) => ConvertColorFillPct(c, f, .25) },
            { "thinHorzCross", (c, f) => ConvertColorFillPct(c, f, .3) },
            { "thinHorzStripe", (c, f) => ConvertColorFillPct(c, f, .25) },
            { "thinReverseDiagStripe", (c, f) => ConvertColorFillPct(c, f, .25) },
            { "thinVertStripe", (c, f) => ConvertColorFillPct(c, f, .25) },
        };

        private static Dictionary<string, string> ShadeCache = new Dictionary<string, string>();

        // fill is the background, color is the foreground
        private static string ConvertColorFillPct(string color, string fill, double pct)
        {
            if (color == "auto")
                color = "000000";
            if (fill == "auto")
                fill = "ffffff";
            var key = color + fill + pct.ToString();
            if (ShadeCache.ContainsKey(key))
                return ShadeCache[key];
            var fillRed = Convert.ToInt32(fill.Substring(0, 2), 16);
            var fillGreen = Convert.ToInt32(fill.Substring(2, 2), 16);
            var fillBlue = Convert.ToInt32(fill.Substring(4, 2), 16);
            var colorRed = Convert.ToInt32(color.Substring(0, 2), 16);
            var colorGreen = Convert.ToInt32(color.Substring(2, 2), 16);
            var colorBlue = Convert.ToInt32(color.Substring(4, 2), 16);
            var finalRed = (int)(fillRed - (fillRed - colorRed) * pct);
            var finalGreen = (int)(fillGreen - (fillGreen - colorGreen) * pct);
            var finalBlue = (int)(fillBlue - (fillBlue - colorBlue) * pct);
            var returnValue = string.Format("{0:x2}{1:x2}{2:x2}", finalRed, finalGreen, finalBlue);
            ShadeCache.Add(key, returnValue);
            return returnValue;
        }

        private static void CreateStyleFromShd(Dictionary<string, string> style, XElement shd)
        {
            if (shd == null)
                return;
            var shadeType = (string)shd.Attribute(W.val);
            var color = (string)shd.Attribute(W.color);
            var fill = (string)shd.Attribute(W.fill);
            if (ShadeMapper.ContainsKey(shadeType))
            {
                color = ShadeMapper[shadeType](color, fill);
            }
            if (color != null)
            {
                var cvtColor = ConvertColor(color);
                if (cvtColor != null && cvtColor != "")
                    style.AddIfMissing("background", cvtColor);
            }
        }

        private static Dictionary<string, string> namedColors = new Dictionary<string, string>()
        {
            {"black", "black"},
            {"blue", "blue" },
            {"cyan", "aqua" },
            {"green", "green" },
            {"magenta", "fuchsia" },
            {"red", "red" },
            {"yellow", "yellow" },
            {"white", "white" },
            {"darkBlue", "#00008B" },
            {"darkCyan", "#008B8B" },
            {"darkGreen", "#006400" },
            {"darkMagenta", "#800080" },
            {"darkRed", "#8B0000" },
            {"darkYellow", "#808000" },
            {"darkGray", "#A9A9A9" },
            {"lightGray", "#D3D3D3" },
            {"none", "" },
        };

        private static void CreateColorProperty(string propertyName, string color, Dictionary<string, string> style)
        {
            if (color == null)
                return;
            if (namedColors.ContainsKey(color))
            {
                var lc = namedColors[color];
                if (lc == "")
                    return;
                style.AddIfMissing(propertyName, lc);
                return;
            }
            style.AddIfMissing(propertyName, "#" + color);
        }

        private static string ConvertColor(string color)
        {
            if (namedColors.ContainsKey(color))
            {
                var lc = namedColors[color];
                if (lc == "")
                    return "black";
                return lc;
            }
            return "#" + color;
        }

        private static Dictionary<string, string> FontFallback = new Dictionary<string, string>()
        {
            { "Arial", @"'{0}', 'sans-serif'" },
            { "Arial Narrow", @"'{0}', 'sans-serif'" },
            { "Arial Rounded MT Bold", @"'{0}', 'sans-serif'" },
            { "Arial Unicode MS", @"'{0}', 'sans-serif'" },
            { "Baskerville Old Face", @"'{0}', 'serif'" },
            { "Berlin Sans FB", @"'{0}', 'sans-serif'" },
            { "Berlin Sans FB Demi", @"'{0}', 'sans-serif'" },
            { "Calibri Light", @"'{0}', 'sans-serif'" },
            { "Gill Sans MT", @"'{0}', 'sans-serif'" },
            { "Gill Sans MT Condensed", @"'{0}', 'sans-serif'" },
            { "Lucida Sans", @"'{0}', 'sans-serif'" },
            { "Lucida Sans Unicode", @"'{0}', 'sans-serif'" },
            { "Segoe UI", @"'{0}', 'sans-serif'" },
            { "Segoe UI Light", @"'{0}', 'sans-serif'" },
            { "Segoe UI Semibold", @"'{0}', 'sans-serif'" },
            { "Tahoma", @"'{0}', 'sans-serif'" },
            { "Trebuchet MS", @"'{0}', 'sans-serif'" },
            { "Verdana", @"'{0}', 'sans-serif'" },
            { "Book Antiqua", @"'{0}', 'serif'" },
            { "Bookman Old Style", @"'{0}', 'serif'" },
            { "Californian FB", @"'{0}', 'serif'" },
            { "Cambria", @"'{0}', 'serif'" },
            { "Constantia", @"'{0}', 'serif'" },
            { "Garamond", @"'{0}', 'serif'" },
            { "Lucida Bright", @"'{0}', 'serif'" },
            { "Lucida Fax", @"'{0}', 'serif'" },
            { "Palatino Linotype", @"'{0}', 'serif'" },
            { "Times New Roman", @"'{0}', 'serif'" },
            { "Wide Latin", @"'{0}', 'serif'" },
            { "Courier New", @"'{0}'" },
            { "Lucida Console", @"'{0}'" },
        };

        private static void CreateFontCssProperty(string font, Dictionary<string, string> style)
        {
            if (FontFallback.ContainsKey(font))
            {
                style.AddIfMissing("font-family", string.Format(FontFallback[font], font));
                return;
            }
            style.AddIfMissing("font-family", font);
        }

        private static bool getBoolProp(XElement runProps, XName xName)
        {
            var p = runProps.Element(xName);
            if (p == null)
                return false;
            var v = p.Attribute(W.val);
            if (v == null)
                return true;
            var s = v.Value.ToLower();
            if (s == "0" || s == "false")
                return false;
            if (s == "1" || s == "true")
                return true;
            return false;
        }

        private static object ConvertContentThatCanContainFields(WordprocessingDocument wordDoc, HtmlConverterSettings settings,
            IEnumerable<XElement> elements)
        {
            var grouped = elements
                .GroupAdjacent(e =>
                {
                    Stack<FieldRetriever.FieldElementTypeInfo> stack = e.Annotation<Stack<FieldRetriever.FieldElementTypeInfo>>();
                    if (stack == null || !stack.Any())
                        return (int?)null;
                    int lowestId = stack.Select(st => st.Id).Min();
                    return lowestId;
                })
                .ToList();
            var txformed = grouped
                .Select(g =>
                {
                    if (g.Key == null)
                    {
                        var o = (object)g.
                            Select(n =>
                            {
                                var o2 = ConvertToHtmlTransform(wordDoc, settings, n, false, 0m);
                                return o2;
                            })
                            .ToList();
                        return o;
                    }

                    var instrText = FieldRetriever.InstrText(g.First().Ancestors().Last(), (int)g.Key).TrimStart('{').TrimEnd('}');

                    var parsed = FieldRetriever.ParseField(instrText);
                    if (parsed.FieldType != "HYPERLINK")
                        return g.Select(n => ConvertToHtmlTransform(wordDoc, settings, n, false, 0m));
                    if (parsed.Arguments.Length > 0)
                    {
                        var a = new XElement(Xhtml.A,
                            new XAttribute("href", parsed.Arguments[0]),
                            g.DescendantsAndSelf(W.r).Select(run => ConvertRun(wordDoc, settings, run)));
                        return a;
                    }
                    else
                    {
                        var a = new XElement(Xhtml.A,
                            g.DescendantsAndSelf(W.r).Select(run => ConvertRun(wordDoc, settings, run)));
                        return a;
                    }
                })
                .ToList();

            return txformed;
        }

        private static object ConvertEntities(string text)
        {
            if (text == null)
                return null;
            if (text.Length == 0)
                return null;
            string textToUse = text;
            var spacesAtBeginning = 0;
            var spacesAtEnd = 0;
            if (text[0] == ' ' || text[text.Length - 1] == ' ')
            {
                spacesAtBeginning = textToUse.TakeWhile(c => c == ' ').Count();
                var leftOverText = textToUse.Substring(spacesAtBeginning);
                if (leftOverText.Length > 1)
                    spacesAtEnd = leftOverText.Reverse().TakeWhile(c => c == ' ').Count();
                textToUse = textToUse.Substring(spacesAtBeginning, textToUse.Length - spacesAtEnd - spacesAtBeginning);
            }
            object o = textToUse.ToCharArray()
                .GroupAdjacent((char c) =>
                {
                    if (c == 0xf0b7 ||
                        c == 0xf0a7 ||
                        c == 0xf076 ||
                        c == 0xf0d8 ||
                        c == 0xf0a8 ||
                        c == 0xf0fc ||
                        c == 0xf0e0 ||
                        c == 0xf0b2)
                        return "-";
                    if (c >= 128)
                    {
                        string entity;
                        if (EntityMap.TryGetValue(c, out entity))
                            return entity;
                    }
                    return "-";
                })
                .Select(g =>
                {
                    if (g.Key != "-")
                        return (object)(g.Select(c => new XEntity(g.Key)));
                    var xt = new XText(g.Aggregate(new StringBuilder(),
                            (s, i) => s.Append(i),
                            s => s.ToString()));
                    return xt;
                });
            if (spacesAtBeginning == 0 && spacesAtEnd == 0)
                return o;
            else
            {
                var atBeginning = Enumerable.Repeat(new XEntity("nbsp"), spacesAtBeginning);
                var atEnding = Enumerable.Repeat(new XEntity("nbsp"), spacesAtEnd);
                return new object[] {
                    atBeginning,
                    o,
                    atEnding,
                };
            }
        }

        private static Dictionary<char, string> EntityMap = null;

        private static void InitEntityMap()
        {
            EntityMap = new Dictionary<char, string>()
            {
                { (char)160, "nbsp" },
                { (char)161, "iexcl" },
                { (char)162, "cent" },
                { (char)163, "pound" },
                { (char)164, "curren" },
                { (char)165, "yen" },
                { (char)166, "brvbar" },
                { (char)167, "sect" },
                { (char)168, "uml" },
                { (char)169, "copy" },
                { (char)170, "ordf" },
                { (char)171, "laquo" },
                { (char)172, "not" },
                { (char)173, "shy" },
                { (char)174, "reg" },
                { (char)175, "macr" },
                { (char)176, "deg" },
                { (char)177, "plusmn" },
                { (char)178, "sup2" },
                { (char)179, "sup3" },
                { (char)180, "acute" },
                { (char)181, "micro" },
                { (char)182, "para" },
                { (char)183, "middot" },
                { (char)184, "cedil" },
                { (char)185, "sup1" },
                { (char)186, "ordm" },
                { (char)187, "raquo" },
                { (char)188, "frac14" },
                { (char)189, "frac12" },
                { (char)190, "frac34" },
                { (char)191, "iquest" },
                { (char)192, "Agrave" },
                { (char)193, "Aacute" },
                { (char)194, "Acirc" },
                { (char)195, "Atilde" },
                { (char)196, "Auml" },
                { (char)197, "Aring" },
                { (char)198, "AElig" },
                { (char)199, "Ccedil" },
                { (char)200, "Egrave" },
                { (char)201, "Eacute" },
                { (char)202, "Ecirc" },
                { (char)203, "Euml" },
                { (char)204, "Igrave" },
                { (char)205, "Iacute" },
                { (char)206, "Icirc" },
                { (char)207, "Iuml" },
                { (char)208, "ETH" },
                { (char)209, "Ntilde" },
                { (char)210, "Ograve" },
                { (char)211, "Oacute" },
                { (char)212, "Ocirc" },
                { (char)213, "Otilde" },
                { (char)214, "Ouml" },
                { (char)215, "times" },
                { (char)216, "Oslash" },
                { (char)217, "Ugrave" },
                { (char)218, "Uacute" },
                { (char)219, "Ucirc" },
                { (char)220, "Uuml" },
                { (char)221, "Yacute" },
                { (char)222, "THORN" },
                { (char)223, "szlig" },
                { (char)224, "agrave" },
                { (char)225, "aacute" },
                { (char)226, "acirc" },
                { (char)227, "atilde" },
                { (char)228, "auml" },
                { (char)229, "aring" },
                { (char)230, "aelig" },
                { (char)231, "ccedil" },
                { (char)232, "egrave" },
                { (char)233, "eacute" },
                { (char)234, "ecirc" },
                { (char)235, "euml" },
                { (char)236, "igrave" },
                { (char)237, "iacute" },
                { (char)238, "icirc" },
                { (char)239, "iuml" },
                { (char)240, "eth" },
                { (char)241, "ntilde" },
                { (char)242, "ograve" },
                { (char)243, "oacute" },
                { (char)244, "ocirc" },
                { (char)245, "otilde" },
                { (char)246, "ouml" },
                { (char)247, "divide" },
                { (char)248, "oslash" },
                { (char)249, "ugrave" },
                { (char)250, "uacute" },
                { (char)251, "ucirc" },
                { (char)252, "uuml" },
                { (char)253, "yacute" },
                { (char)254, "thorn" },
                { (char)255, "yuml" },
                { (char)338, "OElig" },
                { (char)339, "oelig" },
                { (char)352, "Scaron" },
                { (char)353, "scaron" },
                { (char)376, "Yuml" },
                { (char)402, "fnof" },
                { (char)710, "circ" },
                { (char)732, "tilde" },
                { (char)913, "Alpha" },
                { (char)914, "Beta" },
                { (char)915, "Gamma" },
                { (char)916, "Delta" },
                { (char)917, "Epsilon" },
                { (char)918, "Zeta" },
                { (char)919, "Eta" },
                { (char)920, "Theta" },
                { (char)921, "Iota" },
                { (char)922, "Kappa" },
                { (char)923, "Lambda" },
                { (char)924, "Mu" },
                { (char)925, "Nu" },
                { (char)926, "Xi" },
                { (char)927, "Omicron" },
                { (char)928, "Pi" },
                { (char)929, "Rho" },
                { (char)931, "Sigma" },
                { (char)932, "Tau" },
                { (char)933, "Upsilon" },
                { (char)934, "Phi" },
                { (char)935, "Chi" },
                { (char)936, "Psi" },
                { (char)937, "Omega" },
                { (char)945, "alpha" },
                { (char)946, "beta" },
                { (char)947, "gamma" },
                { (char)948, "delta" },
                { (char)949, "epsilon" },
                { (char)950, "zeta" },
                { (char)951, "eta" },
                { (char)952, "theta" },
                { (char)953, "iota" },
                { (char)954, "kappa" },
                { (char)955, "lambda" },
                { (char)956, "mu" },
                { (char)957, "nu" },
                { (char)958, "xi" },
                { (char)959, "omicron" },
                { (char)960, "pi" },
                { (char)961, "rho" },
                { (char)962, "sigmaf" },
                { (char)963, "sigma" },
                { (char)964, "tau" },
                { (char)965, "upsilon" },
                { (char)966, "phi" },
                { (char)967, "chi" },
                { (char)968, "psi" },
                { (char)969, "omega" },
                { (char)977, "thetasym" },
                { (char)978, "upsih" },
                { (char)982, "piv" },
                { (char)8194, "ensp" },
                { (char)8195, "emsp" },
                { (char)8201, "thinsp" },
                { (char)8204, "zwnj" },
                { (char)8205, "zwj" },
                { (char)8206, "lrm" },
                { (char)8207, "rlm" },
                { (char)8211, "ndash" },
                { (char)8212, "mdash" },
                { (char)8216, "lsquo" },
                { (char)8217, "rsquo" },
                { (char)8218, "sbquo" },
                { (char)8220, "ldquo" },
                { (char)8221, "rdquo" },
                { (char)8222, "bdquo" },
                { (char)8224, "dagger" },
                { (char)8225, "Dagger" },
                { (char)8226, "bull" },
                { (char)8230, "hellip" },
                { (char)8240, "permil" },
                { (char)8242, "prime" },
                { (char)8243, "Prime" },
                { (char)8249, "lsaquo" },
                { (char)8250, "rsaquo" },
                { (char)8254, "oline" },
                { (char)8260, "frasl" },
                { (char)8364, "euro" },
                { (char)8465, "image" },
                { (char)8472, "weierp" },
                { (char)8476, "real" },
                { (char)8482, "trade" },
                { (char)8501, "alefsym" },
                { (char)8592, "larr" },
                { (char)8593, "uarr" },
                { (char)8594, "rarr" },
                { (char)8595, "darr" },
                { (char)8596, "harr" },
                { (char)8629, "crarr" },
                { (char)8656, "lArr" },
                { (char)8657, "uArr" },
                { (char)8658, "rArr" },
                { (char)8659, "dArr" },
                { (char)8660, "hArr" },
                { (char)8704, "forall" },
                { (char)8706, "part" },
                { (char)8707, "exist" },
                { (char)8709, "empty" },
                { (char)8711, "nabla" },
                { (char)8712, "isin" },
                { (char)8713, "notin" },
                { (char)8715, "ni" },
                { (char)8719, "prod" },
                { (char)8721, "sum" },
                { (char)8722, "minus" },
                { (char)8727, "lowast" },
                { (char)8730, "radic" },
                { (char)8733, "prop" },
                { (char)8734, "infin" },
                { (char)8736, "ang" },
                { (char)8743, "and" },
                { (char)8744, "or" },
                { (char)8745, "cap" },
                { (char)8746, "cup" },
                { (char)8747, "int" },
                { (char)8756, "there4" },
                { (char)8764, "sim" },
                { (char)8773, "cong" },
                { (char)8776, "asymp" },
                { (char)8800, "ne" },
                { (char)8801, "equiv" },
                { (char)8804, "le" },
                { (char)8805, "ge" },
                { (char)8834, "sub" },
                { (char)8835, "sup" },
                { (char)8836, "nsub" },
                { (char)8838, "sube" },
                { (char)8839, "supe" },
                { (char)8853, "oplus" },
                { (char)8855, "otimes" },
                { (char)8869, "perp" },
                { (char)8901, "sdot" },
                { (char)8968, "lceil" },
                { (char)8969, "rceil" },
                { (char)8970, "lfloor" },
                { (char)8971, "rfloor" },
                { (char)9001, "lang" },
                { (char)9002, "rang" },
                { (char)9674, "loz" },
                { (char)9824, "spades" },
                { (char)9827, "clubs" },
                { (char)9829, "hearts" },
                { (char)9830, "diams" },
            };
        }

        public class InvalidSettingsException : Exception
        {
            public InvalidSettingsException(string message) : base(message) { }
        }

        private class Atnv
        {
            public string Name;
            public string Value;
        }

        private static XElement ProcessImage(WordprocessingDocument wordDoc,
            XElement element, Func<ImageInfo, XElement> imageHandler)
        {
            if (element.Name == W.drawing)
            {
                XElement containerElement = element.Elements()
                    .Where(e => e.Name == WP.inline || e.Name == WP.anchor)
                    .FirstOrDefault();
                if (containerElement != null)
                {
                    int? extentCx = (int?)containerElement.Elements(WP.extent)
                        .Attributes(NoNamespace.cx).FirstOrDefault();
                    int? extentCy = (int?)containerElement.Elements(WP.extent)
                        .Attributes(NoNamespace.cy).FirstOrDefault();
                    string altText = (string)containerElement.Elements(WP.docPr)
                        .Attributes(NoNamespace.descr).FirstOrDefault();
                    if (altText == null)
                        altText = (string)containerElement.Elements(WP.docPr)
                            .Attributes(NoNamespace.name).FirstOrDefault();
                    if (altText == null)
                        altText = "";

                    XElement blipFill = containerElement.Elements(A.graphic)
                        .Elements(A.graphicData)
                        .Elements(Pic._pic).Elements(Pic.blipFill).FirstOrDefault();
                    if (blipFill != null)
                    {
                        string imageRid = (string)blipFill.Elements(A.blip).Attributes(R.embed)
                            .FirstOrDefault();
                        if (imageRid != null)
                        {
                            var pp3 = wordDoc.MainDocumentPart.Parts.FirstOrDefault(pp => pp.RelationshipId == imageRid);
                            if (pp3 == null)
                                return null;
                            ImagePart imagePart = (ImagePart)pp3.OpenXmlPart;
                            if (imagePart == null)
                                return null;
                            // if the image markup points to a NULL image, then following will throw an ArgumentOutOfRangeException
                            try
                            {
                                imagePart = (ImagePart)wordDoc.MainDocumentPart
                                    .GetPartById(imageRid);
                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                return null;
                            }
                            string contentType = imagePart.ContentType;
                            if (contentType == "image/png" ||
                                contentType == "image/gif" ||
                                contentType == "image/tiff" ||
                                contentType == "image/jpeg")
                            {
                                using (Stream partStream = imagePart.GetStream())
                                using (Bitmap bitmap = new Bitmap(partStream))
                                {
                                    if (extentCx != null && extentCy != null)
                                    {
                                        ImageInfo imageInfo = new ImageInfo()
                                        {
                                            Bitmap = bitmap,
                                            ImgStyleAttribute = new XAttribute("style",
                                                string.Format("width: {0}in; height: {1}in",
                                                    (float)extentCx / (float)ImageInfo.EmusPerInch,
                                                    (float)extentCy / (float)ImageInfo.EmusPerInch)),
                                            ContentType = contentType,
                                            DrawingElement = element,
                                            AltText = altText,
                                        };
                                        return imageHandler(imageInfo);
                                    }
                                    ImageInfo imageInfo2 = new ImageInfo()
                                    {
                                        Bitmap = bitmap,
                                        ContentType = contentType,
                                        DrawingElement = element,
                                        AltText = altText,
                                    };
                                    return imageHandler(imageInfo2);
                                };
                            }
                        }
                    }
                }
            }
            if (element.Name == W.pict || element.Name == W._object)
            {
                string imageRid = (string)element.Elements(VML.shape)
                    .Elements(VML.imagedata).Attributes(R.id).FirstOrDefault();
                string style = (string)element.Elements(VML.shape)
                    .Attributes("style").FirstOrDefault();
                if (imageRid != null)
                {
                    try
                    {
                        var pp = wordDoc.MainDocumentPart.Parts.FirstOrDefault(pp2 => pp2.RelationshipId == imageRid);
                        if (pp == null)
                            return null;
                        ImagePart imagePart = (ImagePart)pp.OpenXmlPart;
                        if (imagePart == null)
                            return null;
                        string contentType = imagePart.ContentType;
                        if (contentType == "image/png"
                            || contentType == "image/gif"
                            || contentType == "image/tiff"
                            || contentType == "image/jpeg"
                            // don't process wmf files because GDI consumes huge amounts of memory when dealing with wmf
                            // perhaps because it loads a DLL to do the rendering?
                            // it actually works, but is not recommended
                            //  || contentType == "image/x-wmf"
                        )
                        {
                            //string style = element.
                            using (Stream partStream = imagePart.GetStream())
                                try
                                {
                                    using (Bitmap bitmap = new Bitmap(partStream))
                                    {
                                        ImageInfo imageInfo = new ImageInfo()
                                        {
                                            Bitmap = bitmap,
                                            ContentType = contentType,
                                            DrawingElement = element,
                                        };
                                        if (style != null)
                                        {
                                            float? widthInPoints = null;
                                            float? heightInPoints = null;
                                            string[] tokens = style.Split(';');
                                            var widthString = tokens
                                                .Select(t => new Atnv
                                                {
                                                    Name = t.Split(':').First(),
                                                    Value = t.Split(':').Skip(1)
                                                        .Take(1).FirstOrDefault(),
                                                })
                                                .Where(p => p.Name == "width")
                                                .Select(p => p.Value)
                                                .FirstOrDefault();
                                            if (widthString != null &&
                                                widthString.Length > 2 &&
                                                widthString.Substring(widthString.Length - 2) == "pt")
                                            {
                                                float w;
                                                if (float.TryParse(widthString.Substring(0,
                                                    widthString.Length - 2), out w))
                                                    widthInPoints = w;
                                            }
                                            var heightString = tokens
                                                .Select(t => new Atnv
                                                {
                                                    Name = t.Split(':').First(),
                                                    Value = t.Split(':').Skip(1).Take(1).FirstOrDefault(),
                                                })
                                                .Where(p => p.Name == "height")
                                                .Select(p => p.Value)
                                                .FirstOrDefault();
                                            if (heightString != null &&
                                                heightString.Substring(heightString.Length - 2) == "pt")
                                            {
                                                float h;
                                                if (float.TryParse(heightString.Substring(0,
                                                    heightString.Length - 2), out h))
                                                    heightInPoints = h;
                                            }
                                            if (widthInPoints != null && heightInPoints != null)
                                                imageInfo.ImgStyleAttribute = new XAttribute(
                                                    "style", string.Format(
                                                        "width: {0}pt; height: {1}pt",
                                                        widthInPoints, heightInPoints));
                                        }
                                        return imageHandler(imageInfo);
                                    };
                                }
                                // the Bitmap class can throw OutOfMemoryException, which means the bitmap is messed up, so punt.
                                catch (OutOfMemoryException)
                                {
                                    return null;
                                }
                                catch (ArgumentException)
                                {
                                    return null;
                                }
                        }
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        return null;
                    }
                }
            }
            return null;
        }
    }

    public static class Xhtml
    {
        public static XNamespace xhtml = "http://www.w3.org/1999/xhtml";
        public static XName A = xhtml + "A";
        public static XName b = xhtml + "b";
        public static XName body = xhtml + "body";
        public static XName br = xhtml + "br";
        public static XName div = xhtml + "div";
        public static XName h1 = xhtml + "h1";
        public static XName h2 = xhtml + "h2";
        public static XName head = xhtml + "head";
        public static XName html = xhtml + "html";
        public static XName i = xhtml + "i";
        public static XName img = xhtml + "img";
        public static XName meta = xhtml + "meta";
        public static XName p = xhtml + "p";
        public static XName s = xhtml + "s";
        public static XName span = xhtml + "span";
        public static XName style = xhtml + "style";
        public static XName sub = xhtml + "sub";
        public static XName sup = xhtml + "sup";
        public static XName table = xhtml + "table";
        public static XName td = xhtml + "td";
        public static XName title = xhtml + "title";
        public static XName tr = xhtml + "tr";
        public static XName u = xhtml + "u";
    }

    public static class HtmlConverterExtensions
    {
        public static void AddIfMissing(this Dictionary<string, string> style, string propName, string value)
        {
            if (style.ContainsKey(propName))
                return;
            style.Add(propName, value);
        }
    }
}
