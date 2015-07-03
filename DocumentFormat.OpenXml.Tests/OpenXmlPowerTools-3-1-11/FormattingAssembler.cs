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

Version: 2.7.03
 * Support for RTL languages

Version: 2.6.00
 * Enhance to support the HtmlConverter

***************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DocumentFormat.OpenXml.Packaging;
using System.Drawing;

namespace OpenXmlPowerTools
{
    public class FormattingAssemblerSettings
    {
        public bool RemoveStyleNamesFromParagraphAndRunProperties;
        public bool ClearStyles;
        public bool OrderElementsPerStandard;
        public bool CreateHtmlConverterAnnotationAttributes;
        public bool RestrictToSupportedNumberingFormats;
        public bool RestrictToSupportedLanguages;
        public ListItemRetrieverSettings ListItemRetrieverSettings;

        public FormattingAssemblerSettings()
        {
            RemoveStyleNamesFromParagraphAndRunProperties = true;
            ClearStyles = true;
            OrderElementsPerStandard = true;
            CreateHtmlConverterAnnotationAttributes = true;
            RestrictToSupportedNumberingFormats = false;
            RestrictToSupportedLanguages = false;
            ListItemRetrieverSettings = new ListItemRetrieverSettings();
        }
    }

    public static class FormattingAssembler
    {
        public static WmlDocument AssembleFormatting(WmlDocument document, FormattingAssemblerSettings settings)
        {
            using (OpenXmlMemoryStreamDocument streamDoc = new OpenXmlMemoryStreamDocument(document))
            {
                using (WordprocessingDocument doc = streamDoc.GetWordprocessingDocument())
                {
                    AssembleFormatting(doc, settings);
                }
                return streamDoc.GetModifiedWmlDocument();
            }
        }

        public static void AssembleFormatting(WordprocessingDocument wDoc, FormattingAssemblerSettings settings)
        {
            FormattingAssemblerInfo fai = new FormattingAssemblerInfo();
            XDocument sXDoc = wDoc.MainDocumentPart.StyleDefinitionsPart.GetXDocument();
            XElement defaultParagraphStyle = sXDoc
                .Root
                .Elements(W.style)
                .FirstOrDefault(st => st.Attribute(W._default).ToBoolean() == true &&
                    (string)st.Attribute(W.type) == "paragraph");
            if (defaultParagraphStyle != null)
                fai.DefaultParagraphStyleName = (string)defaultParagraphStyle.Attribute(W.styleId);
            XElement defaultCharacterStyle = sXDoc
                .Root
                .Elements(W.style)
                .FirstOrDefault(st => st.Attribute(W._default).ToBoolean() == true &&
                    (string)st.Attribute(W.type) == "character");
            if (defaultCharacterStyle != null)
                fai.DefaultCharacterStyleName = (string)defaultCharacterStyle.Attribute(W.styleId);
            XElement defaultTableStyle = sXDoc
                .Root
                .Elements(W.style)
                .FirstOrDefault(st => st.Attribute(W._default).ToBoolean() == true &&
                    (string)st.Attribute(W.type) == "table");
            if (defaultTableStyle != null)
                fai.DefaultTableStyleName = (string)defaultTableStyle.Attribute(W.styleId);
            ListItemRetrieverSettings listItemRetrieverSettings = new ListItemRetrieverSettings();
            AssembleListItemInformation(wDoc, settings.ListItemRetrieverSettings);
            foreach (var part in wDoc.ContentParts())
            {
                var pxd = part.GetXDocument();
                FixNonconformantHexValues(pxd.Root);
                AnnotateWithGlobalDefaults(wDoc, pxd.Root, settings);
                AnnotateTablesWithTableStyles(wDoc, pxd.Root);
                AnnotateParagraphs(fai, wDoc, pxd.Root, settings);
                AnnotateRuns(fai, wDoc, pxd.Root, settings);
            }
            NormalizeListItems(fai, wDoc, settings);
            if (settings.ClearStyles)
                ClearStyles(wDoc);
            foreach (var part in wDoc.ContentParts())
            {
                var pxd = part.GetXDocument();
                pxd.Root.Descendants().Attributes().Where(a => a.IsNamespaceDeclaration).Remove();
                FormattingAssembler.NormalizePropsForPart(pxd, settings);
                var newRoot = (XElement)CleanupTransform(pxd.Root);
                pxd.Root.ReplaceWith(newRoot);
                part.PutXDocument();
            }
        }

        private static void FixNonconformantHexValues(XElement root)
        {
            foreach (var tblLook in root.Descendants(W.tblLook))
            {
                if (tblLook.Attributes().Any(a => a.Name != W.val))
                    continue;
                if (tblLook.Attribute(W.val) == null)
                    continue;
                string hexValue = tblLook.Attribute(W.val).Value;
                int val = int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);
                tblLook.Add(new XAttribute(W.firstRow, (val & 0x0020) != 0 ? "1" : "0"));
                tblLook.Add(new XAttribute(W.lastRow, (val & 0x0040) != 0 ? "1" : "0"));
                tblLook.Add(new XAttribute(W.firstColumn, (val & 0x0080) != 0 ? "1" : "0"));
                tblLook.Add(new XAttribute(W.lastColumn, (val & 0x0100) != 0 ? "1" : "0"));
                tblLook.Add(new XAttribute(W.noHBand, (val & 0x0200) != 0 ? "1" : "0"));
                tblLook.Add(new XAttribute(W.noVBand, (val & 0x0400) != 0 ? "1" : "0"));
            }
            foreach (var cnfStyle in root.Descendants(W.cnfStyle))
            {
                if (cnfStyle.Attributes().Any(a => a.Name != W.val))
                    continue;
                if (cnfStyle.Attribute(W.val) == null)
                    continue;
                var va = cnfStyle.Attribute(W.val).Value.ToArray();
                cnfStyle.Add(new XAttribute(W.firstRow, va[0]));
                cnfStyle.Add(new XAttribute(W.lastRow, va[1]));
                cnfStyle.Add(new XAttribute(W.firstColumn, va[2]));
                cnfStyle.Add(new XAttribute(W.lastColumn, va[3]));
                cnfStyle.Add(new XAttribute(W.oddVBand, va[4]));
                cnfStyle.Add(new XAttribute(W.evenVBand, va[5]));
                cnfStyle.Add(new XAttribute(W.oddHBand, va[6]));
                cnfStyle.Add(new XAttribute(W.evenHBand, va[7]));
                cnfStyle.Add(new XAttribute(W.firstRowLastColumn, va[8]));
                cnfStyle.Add(new XAttribute(W.firstRowFirstColumn, va[9]));
                cnfStyle.Add(new XAttribute(W.lastRowLastColumn, va[10]));
                cnfStyle.Add(new XAttribute(W.lastRowFirstColumn, va[11]));
            }
        }

        private static object CleanupTransform(XNode node)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                if (element.Name == W.tabs && element.Element(W.tab) == null)
                    return null;

                if (element.Name == W.tblStyleRowBandSize || element.Name == W.tblStyleColBandSize)
                    return null;

                // a cleaner solution would be to not include the w:ins and w:del elements when rolling up the paragraph run properties into
                // the run properties.
                if ((element.Name == W.ins || element.Name == W.del) && element.Parent.Name == W.rPr)
                {
                    if (element.Parent.Parent.Name == W.r || element.Parent.Parent.Name == W.rPrChange)
                        return null;
                }

                return new XElement(element.Name,
                    element.Attributes(),
                    element.Nodes().Select(n => CleanupTransform(n)));
            }
            return node;
        }

        private static void ClearStyles(WordprocessingDocument wDoc)
        {
            var stylePart = wDoc.MainDocumentPart.StyleDefinitionsPart;
            var sXDoc = stylePart.GetXDocument();

            var newRoot = new XElement(sXDoc.Root.Name,
                sXDoc.Root.Attributes(),
                sXDoc.Root.Elements().Select(e =>
                {
                    if (e.Name != W.style)
                        return e;
                    return new XElement(e.Name,
                        e.Attributes(),
                        e.Element(W.name),
                        new XElement(W.pPr),
                        new XElement(W.rPr));
                }));

            var globalrPr = newRoot
                .Elements(W.docDefaults)
                .Elements(W.rPrDefault)
                .Elements(W.rPr)
                .FirstOrDefault();
            if (globalrPr != null)
                globalrPr.ReplaceWith(new XElement(W.rPr));

            var globalpPr = newRoot
                .Elements(W.docDefaults)
                .Elements(W.pPrDefault)
                .Elements(W.pPr)
                .FirstOrDefault();
            if (globalpPr != null)
                globalpPr.ReplaceWith(new XElement(W.pPr));

            sXDoc.Root.ReplaceWith(newRoot);

            stylePart.PutXDocument();
        }

        private static void NormalizeListItems(FormattingAssemblerInfo fai, WordprocessingDocument wDoc, FormattingAssemblerSettings settings)
        {
            foreach (var part in wDoc.ContentParts())
            {
                var pxd = part.GetXDocument();
                XElement newRoot = (XElement)NormalizeListItemsTransform(fai, wDoc, pxd.Root, settings);
                if (newRoot.Attribute(XNamespace.Xmlns + "pt14") == null)
                    newRoot.Add(new XAttribute(XNamespace.Xmlns + "pt14", PtOpenXml.pt.NamespaceName));
                if (newRoot.Attribute(XNamespace.Xmlns + "mc") == null)
                    newRoot.Add(new XAttribute(XNamespace.Xmlns + "mc", MC.mc.NamespaceName));
                pxd.Root.ReplaceWith(newRoot);
            }
        }

        private static object NormalizeListItemsTransform(FormattingAssemblerInfo fai, WordprocessingDocument wDoc, XNode node, FormattingAssemblerSettings settings)
        {
            var element = node as XElement;
            if (element != null)
            {
                if (element.Name == W.p)
                {
                    var li = ListItemRetriever.RetrieveListItem(wDoc, element, settings.ListItemRetrieverSettings);
                    if (li != null)
                    {
                        ListItemRetriever.ListItemInfo listItemInfo = element.Annotation<ListItemRetriever.ListItemInfo>();

                        var newParaProps = new XElement(W.pPr,
                            element.Elements(W.pPr).Elements().Where(e => e.Name != W.numPr)
                        );

                        XElement listItemRunProps = null;
                        int? abstractNumId = null;
                        if (listItemInfo != null)
                        {
                            abstractNumId = listItemInfo.AbstractNumId;

                            var paraStyleRunProps = CharStyleRollup(fai, wDoc, element);

                            var paragraphStyleName = (string)element
                                .Elements(W.pPr)
                                .Elements(W.pStyle)
                                .Attributes(W.val)
                                .FirstOrDefault();

                            string defaultStyleName = (string)wDoc
                                    .MainDocumentPart
                                    .StyleDefinitionsPart
                                    .GetXDocument()
                                    .Root
                                    .Elements(W.style)
                                    .Where(s => (string)s.Attribute(W.type) == "paragraph" && s.Attribute(W._default).ToBoolean() == true)
                                    .Attributes(W.styleId)
                                    .FirstOrDefault();

                            if (paragraphStyleName == null)
                                paragraphStyleName = defaultStyleName;

                            XDocument stylesXDoc = wDoc
                                .MainDocumentPart
                                .StyleDefinitionsPart
                                .GetXDocument();

                            // put together run props for list item.

                            XElement lvlStyleRpr = ParaStyleRunPropsStack(wDoc, paragraphStyleName)
                                .Aggregate(new XElement(W.rPr),
                                    (r, s) =>
                                    {
                                        var newCharStyleRunProps = MergeStyleElement(s, r);
                                        return newCharStyleRunProps;
                                    });

                            var mergedRunProps = MergeStyleElement(lvlStyleRpr, paraStyleRunProps);

                            var accumulatedRunProps = element.Elements(PtOpenXml.pPr).Elements(W.rPr).FirstOrDefault();
                            if (accumulatedRunProps != null)
                                mergedRunProps = MergeStyleElement(accumulatedRunProps, mergedRunProps);

                            var listItemLvl = listItemInfo.Lvl(ListItemRetriever.GetParagraphLevel(element));
                            var listItemLvlRunProps = listItemLvl.Elements(W.rPr).FirstOrDefault();
                            listItemRunProps = MergeStyleElement(listItemLvlRunProps, mergedRunProps);

                            if ((string)listItemLvl.Elements(W.numFmt).Attributes(W.val).FirstOrDefault() == "bullet")
                            {
                                listItemRunProps.Elements(W.rtl).Remove();
                            }
                            else
                            {
                                var pPr = element.Element(PtOpenXml.pPr);
                                if (pPr != null)
                                {
                                    XElement bidiel = pPr.Element(W.bidi);
                                    bool bidi = bidiel != null && (bidiel.Attribute(W.val) == null || bidiel.Attribute(W.val).ToBoolean() == true);
                                    if (bidi)
                                    {
                                        listItemRunProps = MergeStyleElement(new XElement(W.rPr,
                                            new XElement(W.rtl)), listItemRunProps);
                                    }
                                }
                            }
                        }

                        var listItemRun = new XElement(W.r,
                            element.Attribute(PtOpenXml.FontName),
                            element.Attribute(PtOpenXml.LanguageType),
                            listItemRunProps,
                            new XElement(W.t,
                                new XAttribute(XNamespace.Xml + "space", "preserve"),
                                li));

                        AdjustFontAttributes(wDoc, listItemRun, null, listItemRunProps, settings);

                        var lvl = listItemInfo.Lvl(ListItemRetriever.GetParagraphLevel(element));
                        XElement suffix = new XElement(W.tab);
                        var su = (string)lvl.Elements(W.suff).Attributes(W.val).FirstOrDefault();
                        if (su == "space")
                            suffix = new XElement(W.t,
                                new XAttribute(XNamespace.Xml + "space", "preserve"),
                                " ");
                        else if (su == "nothing")
                            suffix = null;

                        var jc = (string)lvl.Elements(W.lvlJc).Attributes(W.val).FirstOrDefault();
                        if (jc == "right")
                        {
                            var accumulatedParaProps = element.Element(PtOpenXml.pPr);

                            var hangingAtt = accumulatedParaProps.Elements(W.ind).Attributes(W.hanging).FirstOrDefault();
                            if (hangingAtt == null)
                            {
                                var listItemRunLength = WordprocessingMLUtil.CalcWidthOfRunInTwips(listItemRun);
                                var ind = accumulatedParaProps.Element(W.ind);
                                if (ind == null)
                                {
                                    ind = new XElement(W.ind);
                                    accumulatedParaProps.Add(ind);
                                }
                                ind.Add(new XAttribute(W.hanging, listItemRunLength.ToString()));
                            }
                            else
                            {
                                var hanging = (int)hangingAtt;
                                var listItemRunLength = WordprocessingMLUtil.CalcWidthOfRunInTwips(listItemRun);
                                hanging += listItemRunLength; // should be width of list item, in twips
                                hangingAtt.Value = hanging.ToString();
                            }
                        }
                        else if (jc == "center")
                        {
                            var accumulatedParaProps = element.Element(PtOpenXml.pPr);

                            var hangingAtt = accumulatedParaProps.Elements(W.ind).Attributes(W.hanging).FirstOrDefault();
                            if (hangingAtt == null)
                            {
                                var listItemRunLength = WordprocessingMLUtil.CalcWidthOfRunInTwips(listItemRun);
                                var ind = accumulatedParaProps.Element(W.ind);
                                if (ind == null)
                                {
                                    ind = new XElement(W.ind);
                                    accumulatedParaProps.Add(ind);
                                }
                                ind.Add(new XAttribute(W.hanging, (listItemRunLength / 2).ToString()));
                            }
                            else
                            {
                                var hanging = (int)hangingAtt;
                                var listItemRunLength = WordprocessingMLUtil.CalcWidthOfRunInTwips(listItemRun);
                                hanging += (listItemRunLength / 2); // should be half of width of list item, in twips
                                hangingAtt.Value = hanging.ToString();
                            }
                        }
                        AddTabAtLeftIndent(element.Element(PtOpenXml.pPr));

                        XElement newPara = new XElement(W.p,
                            element.Attribute(PtOpenXml.FontName),
                            element.Attribute(PtOpenXml.LanguageType),
                            new XAttribute(PtOpenXml.AbstractNumId, abstractNumId),
                            newParaProps,
                            listItemRun,
                            suffix != null ?
                                new XElement(W.r,
                                    listItemRunProps,
                                    suffix) : null,
                            element.Elements().Where(e => e.Name != W.pPr).Select(n => NormalizeListItemsTransform(fai, wDoc, n, settings)));
                        return newPara;

                    }
                }

                return new XElement(element.Name,
                    element.Attributes(),
                    element.Nodes().Select(n => NormalizeListItemsTransform(fai, wDoc, n, settings)));
            }
            return node;
        }

        private static void AddTabAtLeftIndent(XElement pPr)
        {
            int left = 0;
            var ind = pPr.Element(W.ind);

            // todo need to handle W.start
            if (pPr.Attribute(W.left) != null)
                left = (int)pPr.Attribute(W.left);
            var tabs = pPr.Element(W.tabs);
            if (tabs == null)
            {
                tabs = new XElement(W.tabs);
                pPr.Add(tabs);
            }
            var tabAtLeft = tabs.Elements(W.tab).FirstOrDefault(t => (int)t.Attribute(W.pos) == left);
            if (tabAtLeft == null)
            {
                tabs.Add(
                    new XElement(W.tab,
                        new XAttribute(W.val, "left"),
                        new XAttribute(W.pos, left)));
            }
        }

        public static XName[] PtNamesToKeep = new[] {
            PtOpenXml.FontName,
            PtOpenXml.AbstractNumId,
            PtOpenXml.StyleName,
            PtOpenXml.LanguageType,
        };

        public static void NormalizePropsForPart(XDocument pxd, FormattingAssemblerSettings settings)
        {
            if (settings.CreateHtmlConverterAnnotationAttributes)
            {
                pxd.Root.Descendants().Attributes().Where(d => d.Name.Namespace == PtOpenXml.pt &&
                    !PtNamesToKeep.Contains(d.Name)).Remove();
                if (pxd.Root.Attribute(XNamespace.Xmlns + "pt14") == null)
                    pxd.Root.Add(new XAttribute(XNamespace.Xmlns + "pt14", PtOpenXml.pt.NamespaceName));
                if (pxd.Root.Attribute(XNamespace.Xmlns + "mc") == null)
                    pxd.Root.Add(new XAttribute(XNamespace.Xmlns + "mc", MC.mc.NamespaceName));
                XAttribute mci = pxd.Root.Attribute(MC.Ignorable);
                if (mci != null)
                {
                    if (!pxd.Root.Attribute(MC.Ignorable).Value.Contains("pt14"))
                    {
                        var ig = pxd.Root.Attribute(MC.Ignorable).Value + " pt14";
                        mci.Value = ig;
                    }
                }
                else
                {
                    pxd.Root.Add(new XAttribute(MC.Ignorable, "pt14"));
                }
            }
            else
            {
                pxd.Root.Descendants().Attributes().Where(d => d.Name.Namespace == PtOpenXml.pt).Remove();
            }
            var runProps = pxd.Root.Descendants(PtOpenXml.rPr).ToList();
            foreach (var item in runProps)
            {
                XElement newRunProps = new XElement(W.rPr,
                    item.Attributes(),
                    item.Elements());
                XElement parent = item.Parent;
                if (parent.Name == W.p)
                {
                    XElement existingParaProps = parent.Element(W.pPr);
                    if (existingParaProps == null)
                    {
                        existingParaProps = new XElement(W.pPr);
                        parent.Add(existingParaProps);
                    }
                    XElement existingRunProps = existingParaProps.Element(W.rPr);
                    if (existingRunProps != null)
                    {
                        if (!settings.RemoveStyleNamesFromParagraphAndRunProperties)
                        {
                            if (newRunProps.Element(W.rStyle) == null)
                                newRunProps.Add(existingRunProps.Element(W.rStyle));
                        }
                        existingRunProps.ReplaceWith(newRunProps);
                    }
                    else
                        existingParaProps.Add(newRunProps);
                }
                else
                {
                    XElement existingRunProps = parent.Element(W.rPr);
                    if (existingRunProps != null)
                    {
                        if (!settings.RemoveStyleNamesFromParagraphAndRunProperties)
                        {
                            if (newRunProps.Element(W.rStyle) == null)
                                newRunProps.Add(existingRunProps.Element(W.rStyle));
                        }
                        existingRunProps.ReplaceWith(newRunProps);
                    }
                    else
                        parent.Add(newRunProps);
                }
            }
            var paraProps = pxd.Root.Descendants(PtOpenXml.pPr).ToList();
            foreach (var item in paraProps)
            {
                var paraRunProps = item.Parent.Elements(W.pPr).Elements(W.rPr).FirstOrDefault();
                var merged = MergeStyleElement(item.Element(W.rPr), paraRunProps);
                if (!settings.RemoveStyleNamesFromParagraphAndRunProperties)
                {
                    if (merged.Element(W.rStyle) == null)
                    {
                        merged.Add(paraRunProps.Element(W.rStyle));
                    }
                }

                XElement newParaProps = new XElement(W.pPr,
                    item.Attributes(),
                    item.Elements().Where(e => e.Name != W.rPr),
                    merged);
                XElement para = item.Parent;
                XElement existingParaProps = para.Element(W.pPr);
                if (existingParaProps != null)
                {
                    if (!settings.RemoveStyleNamesFromParagraphAndRunProperties)
                    {
                        if (newParaProps.Element(W.pStyle) == null)
                            newParaProps.Add(existingParaProps.Element(W.pStyle));
                    }
                    existingParaProps.ReplaceWith(newParaProps);
                }
                else
                    para.Add(newParaProps);
            }
            var tblProps = pxd.Root.Descendants(PtOpenXml.tblPr).ToList();
            foreach (var item in tblProps)
            {
                XElement newTblProps = new XElement(item);
                newTblProps.Name = W.tblPr;
                XElement table = item.Parent;
                XElement existingTableProps = table.Element(W.tblPr);
                if (existingTableProps != null)
                    existingTableProps.ReplaceWith(newTblProps);
                else
                    table.AddFirst(newTblProps);
            }
            var trProps = pxd.Root.Descendants(PtOpenXml.trPr).ToList();
            foreach (var item in trProps)
            {
                XElement newTrProps = new XElement(item);
                newTrProps.Name = W.trPr;
                XElement row = item.Parent;
                XElement existingRowProps = row.Element(W.trPr);
                if (existingRowProps != null)
                    existingRowProps.ReplaceWith(newTrProps);
                else
                    row.AddFirst(newTrProps);
            }
            var tcProps = pxd.Root.Descendants(PtOpenXml.tcPr).ToList();
            foreach (var item in tcProps)
            {
                XElement newTcProps = new XElement(item);
                newTcProps.Name = W.tcPr;
                XElement row = item.Parent;
                XElement existingRowProps = row.Element(W.tcPr);
                if (existingRowProps != null)
                    existingRowProps.ReplaceWith(newTcProps);
                else
                    row.AddFirst(newTcProps);
            }
            pxd.Root.Descendants(W.numPr).Remove();
            if (settings.RemoveStyleNamesFromParagraphAndRunProperties)
            {
                pxd.Root.Descendants(W.pStyle).Where(ps => ps.Parent.Name == W.pPr).Remove();
                pxd.Root.Descendants(W.rStyle).Where(ps => ps.Parent.Name == W.rPr).Remove();
            }
            pxd.Root.Descendants(W.tblStyle).Where(ps => ps.Parent.Name == W.tblPr).Remove();
            pxd.Root.Descendants().Where(d => d.Name.Namespace == PtOpenXml.pt).Remove();
            if (settings.OrderElementsPerStandard)
            {
                XElement newRoot = (XElement)TransformAndOrderElements(pxd.Root);
                pxd.Root.ReplaceWith(newRoot);
            }
        }

        private static Dictionary<XName, int> Order_pPr = new Dictionary<XName, int>
        {
            { W.pStyle, 10 },
            { W.keepNext, 20 },
            { W.keepLines, 30 },
            { W.pageBreakBefore, 40 },
            { W.framePr, 50 },
            { W.widowControl, 60 },
            { W.numPr, 70 },
            { W.suppressLineNumbers, 80 },
            { W.pBdr, 90 },
            { W.shd, 100 },
            { W.tabs, 120 },
            { W.suppressAutoHyphens, 130 },
            { W.kinsoku, 140 },
            { W.wordWrap, 150 },
            { W.overflowPunct, 160 },
            { W.topLinePunct, 170 },
            { W.autoSpaceDE, 180 },
            { W.autoSpaceDN, 190 },
            { W.bidi, 200 },
            { W.adjustRightInd, 210 },
            { W.snapToGrid, 220 },
            { W.spacing, 230 },
            { W.ind, 240 },
            { W.contextualSpacing, 250 },
            { W.mirrorIndents, 260 },
            { W.suppressOverlap, 270 },
            { W.jc, 280 },
            { W.textDirection, 290 },
            { W.textAlignment, 300 },
            { W.textboxTightWrap, 310 },
            { W.outlineLvl, 320 },
            { W.divId, 330 },
            { W.cnfStyle, 340 },
            { W.rPr, 350 },
            { W.sectPr, 360 },
            { W.pPrChange, 370 },
        };

        private static Dictionary<XName, int> Order_rPr = new Dictionary<XName, int>
        {
            { W.ins, 10 },
            { W.del, 20 },
            { W.rStyle, 30 },
            { W.rFonts, 40 },
            { W.b, 50 },
            { W.bCs, 60 },
            { W.i, 70 },
            { W.iCs, 80 },
            { W.caps, 90 },
            { W.smallCaps, 100 },
            { W.strike, 110 },
            { W.dstrike, 120 },
            { W.outline, 130 },
            { W.shadow, 140 },
            { W.emboss, 150 },
            { W.imprint, 160 },
            { W.noProof, 170 },
            { W.snapToGrid, 180 },
            { W.vanish, 190 },
            { W.webHidden, 200 },
            { W.color, 210 },
            { W.spacing, 220 },
            { W._w, 230 },
            { W.kern, 240 },
            { W.position, 250 },
            { W.sz, 260 },
            { W14.wShadow, 270 },
            { W14.wTextOutline, 280 },
            { W14.wTextFill, 290 },
            { W14.wScene3d, 300 },
            { W14.wProps3d, 310 },
            { W.szCs, 320 },
            { W.highlight, 330 },
            { W.u, 340 },
            { W.effect, 350 },
            { W.bdr, 360 },
            { W.shd, 370 },
            { W.fitText, 380 },
            { W.vertAlign, 390 },
            { W.rtl, 400 },
            { W.cs, 410 },
            { W.em, 420 },
            { W.lang, 430 },
            { W.eastAsianLayout, 440 },
            { W.specVanish, 450 },
            { W.oMath, 460 },
        };

        private static Dictionary<XName, int> Order_tblPr = new Dictionary<XName, int>
        {
            { W.tblStyle, 10 },
            { W.tblpPr, 20 },
            { W.tblOverlap, 30 },
            { W.bidiVisual, 40 },
            { W.tblStyleRowBandSize, 50 },
            { W.tblStyleColBandSize, 60 },
            { W.tblW, 70 },
            { W.jc, 80 },
            { W.tblCellSpacing, 90 },
            { W.tblInd, 100 },
            { W.tblBorders, 110 },
            { W.shd, 120 },
            { W.tblLayout, 130 },
            { W.tblCellMar, 140 },
            { W.tblLook, 150 },
            { W.tblCaption, 160 },
            { W.tblDescription, 170 },
        };

        private static Dictionary<XName, int> Order_tblBorders = new Dictionary<XName, int>
        {
            { W.top, 10 },
            { W.left, 20 },
            { W.start, 30 },
            { W.bottom, 40 },
            { W.right, 50 },
            { W.end, 60 },
            { W.insideH, 70 },
            { W.insideV, 80 },
        };

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

        private static Dictionary<XName, int> Order_tcBorders = new Dictionary<XName, int>
        {
            { W.top, 10 },
            { W.start, 20 },
            { W.left, 30 },
            { W.bottom, 40 },
            { W.right, 50 },
            { W.end, 60 },
            { W.insideH, 70 },
            { W.insideV, 80 },
            { W.tl2br, 90 },
            { W.tr2bl, 100 },
        };

        private static Dictionary<XName, int> Order_pBdr = new Dictionary<XName, int>
        {
            { W.top, 10 },
            { W.left, 20 },
            { W.bottom, 30 },
            { W.right, 40 },
            { W.between, 50 },
            { W.bar, 60 },
        };

        private static object TransformAndOrderElements(XNode node)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                if (element.Name == W.pPr)
                    return new XElement(element.Name,
                        element.Attributes(),
                        element.Elements().Select(e => (XElement)TransformAndOrderElements(e)).OrderBy(e =>
                        {
                            if (Order_pPr.ContainsKey(e.Name))
                                return Order_pPr[e.Name];
                            return 999;
                        }));

                if (element.Name == W.rPr)
                    return new XElement(element.Name,
                        element.Attributes(),
                        element.Elements().Select(e => (XElement)TransformAndOrderElements(e)).OrderBy(e =>
                        {
                            if (Order_rPr.ContainsKey(e.Name))
                                return Order_rPr[e.Name];
                            return 999;
                        }));

                if (element.Name == W.tblPr)
                    return new XElement(element.Name,
                        element.Attributes(),
                        element.Elements().Select(e => (XElement)TransformAndOrderElements(e)).OrderBy(e =>
                        {
                            if (Order_tblPr.ContainsKey(e.Name))
                                return Order_tblPr[e.Name];
                            return 999;
                        }));

                if (element.Name == W.tcPr)
                    return new XElement(element.Name,
                        element.Attributes(),
                        element.Elements().Select(e => (XElement)TransformAndOrderElements(e)).OrderBy(e =>
                        {
                            if (Order_tcPr.ContainsKey(e.Name))
                                return Order_tcPr[e.Name];
                            return 999;
                        }));

                if (element.Name == W.tcBorders)
                    return new XElement(element.Name,
                        element.Attributes(),
                        element.Elements().Select(e => (XElement)TransformAndOrderElements(e)).OrderBy(e =>
                        {
                            if (Order_tcBorders.ContainsKey(e.Name))
                                return Order_tcBorders[e.Name];
                            return 999;
                        }));

                if (element.Name == W.tblBorders)
                    return new XElement(element.Name,
                        element.Attributes(),
                        element.Elements().Select(e => (XElement)TransformAndOrderElements(e)).OrderBy(e =>
                        {
                            if (Order_tblBorders.ContainsKey(e.Name))
                                return Order_tblBorders[e.Name];
                            return 999;
                        }));

                if (element.Name == W.pBdr)
                    return new XElement(element.Name,
                        element.Attributes(),
                        element.Elements().Select(e => (XElement)TransformAndOrderElements(e)).OrderBy(e =>
                        {
                            if (Order_pBdr.ContainsKey(e.Name))
                                return Order_pBdr[e.Name];
                            return 999;
                        }));

                if (element.Name == W.p)
                    return new XElement(element.Name,
                        element.Attributes(),
                        element.Elements(W.pPr).Select(e => (XElement)TransformAndOrderElements(e)),
                        element.Elements().Where(e => e.Name != W.pPr).Select(e => (XElement)TransformAndOrderElements(e)));

                if (element.Name == W.r)
                    return new XElement(element.Name,
                        element.Attributes(),
                        element.Elements(W.rPr).Select(e => (XElement)TransformAndOrderElements(e)),
                        element.Elements().Where(e => e.Name != W.rPr).Select(e => (XElement)TransformAndOrderElements(e)));

                return new XElement(element.Name,
                    element.Attributes(),
                    element.Nodes().Select(n => TransformAndOrderElements(n)));
            }
            return node;
        }

        private static void AssembleListItemInformation(WordprocessingDocument wordDoc, ListItemRetrieverSettings settings)
        {
            foreach (var part in wordDoc.ContentParts())
            {
                XDocument xDoc = part.GetXDocument();
                foreach (var para in xDoc.Descendants(W.p))
                {
                    ListItemRetriever.RetrieveListItem(wordDoc, para, settings);
                }
            }
        }

        private static void AnnotateWithGlobalDefaults(WordprocessingDocument wDoc, XElement rootElement, FormattingAssemblerSettings settings)
        {
            XElement globalDefaultParaProps = null;
            XElement globalDefaultParaPropsAsDefined = null;
            XElement globalDefaultRunProps = null;
            XElement globalDefaultRunPropsAsDefined = null;
            XDocument sXDoc = wDoc.MainDocumentPart.StyleDefinitionsPart.GetXDocument();
            var defaultParaStyleName = (string)sXDoc
                .Root
                .Elements(W.style)
                .Where(st => (string)st.Attribute(W.type) == "paragraph" && st.Attribute(W._default).ToBoolean() == true)
                .Attributes(W.styleId)
                .FirstOrDefault();
            var defaultCharStyleName = (string)sXDoc
                .Root
                .Elements(W.style)
                .Where(st => (string)st.Attribute(W.type) == "character" && st.Attribute(W._default).ToBoolean() == true)
                .Attributes(W.styleId)
                .FirstOrDefault();
            XElement docDefaults = sXDoc.Root.Element(W.docDefaults);
            if (docDefaults != null)
            {
                globalDefaultParaPropsAsDefined = docDefaults.Elements(W.pPrDefault).Elements(W.pPr)
                    .FirstOrDefault();
                if (globalDefaultParaPropsAsDefined == null)
                    globalDefaultParaPropsAsDefined = new XElement(W.pPr,
                        new XElement(W.rPr));
                globalDefaultRunPropsAsDefined = docDefaults.Elements(W.rPrDefault).Elements(W.rPr)
                    .FirstOrDefault();
                if (globalDefaultRunPropsAsDefined == null)
                    globalDefaultRunPropsAsDefined = new XElement(W.rPr);
                if (globalDefaultRunPropsAsDefined.Element(W.rFonts) == null)
                    globalDefaultRunPropsAsDefined.Add(
                        new XElement(W.rFonts,
                            new XAttribute(W.ascii, "Times New Roman"),
                            new XAttribute(W.hAnsi, "Times New Roman"),
                            new XAttribute(W.cs, "Times New Roman")));
                if (globalDefaultRunPropsAsDefined.Element(W.sz) == null)
                    globalDefaultRunPropsAsDefined.Add(
                        new XElement(W.sz,
                            new XAttribute(W.val, "20")));
                if (globalDefaultRunPropsAsDefined.Element(W.szCs) == null)
                    globalDefaultRunPropsAsDefined.Add(
                        new XElement(W.szCs,
                            new XAttribute(W.val, "20")));

                var runPropsForGlobalDefaultParaProps = MergeStyleElement(globalDefaultRunPropsAsDefined, globalDefaultParaPropsAsDefined.Element(W.rPr));
                globalDefaultParaProps = new XElement(globalDefaultParaPropsAsDefined.Name,
                    globalDefaultParaPropsAsDefined.Attributes(),
                    globalDefaultParaPropsAsDefined.Elements().Where(e => e.Name != W.rPr),
                    runPropsForGlobalDefaultParaProps);
                globalDefaultRunProps = MergeStyleElement(globalDefaultParaPropsAsDefined.Element(W.rPr), globalDefaultRunPropsAsDefined);
            }
            var rPr = new XElement(W.rPr,
                        new XElement(W.rFonts,
                                new XAttribute(W.ascii, "Times New Roman"),
                                new XAttribute(W.hAnsi, "Times New Roman"),
                                new XAttribute(W.cs, "Times New Roman")),
                            new XElement(W.sz,
                                new XAttribute(W.val, "20")),
                            new XElement(W.szCs,
                                new XAttribute(W.val, "20")));

            if (globalDefaultParaProps == null)
                globalDefaultParaProps = new XElement(W.pPr, rPr);

            if (globalDefaultRunProps == null)
                globalDefaultRunProps = rPr;

            XElement ptGlobalDefaultParaProps = new XElement(globalDefaultParaProps);
            XElement ptGlobalDefaultRunProps = new XElement(globalDefaultRunProps);
            ptGlobalDefaultParaProps.Name = PtOpenXml.pPr;
            ptGlobalDefaultRunProps.Name = PtOpenXml.rPr;
            var parasAndRuns = rootElement.Descendants().Where(d =>
            {
                return d.Name == W.p || d.Name == W.r;
            });
            if (settings.CreateHtmlConverterAnnotationAttributes)
            {
                foreach (var d in parasAndRuns)
                {
                    if (d.Name == W.p)
                    {
                        var pStyle = (string)d.Elements(W.pPr).Elements(W.pStyle).Attributes(W.val).FirstOrDefault();
                        if (pStyle == null)
                            pStyle = defaultParaStyleName;
                        if (pStyle != null)
                        {
                            if (d.Attribute(PtOpenXml.StyleName) != null)
                                d.Attribute(PtOpenXml.StyleName).Value = pStyle;
                            else
                                d.Add(new XAttribute(PtOpenXml.StyleName, pStyle));
                        }
                        d.Add(ptGlobalDefaultParaProps);
                    }
                    else
                    {
                        var rStyle = (string)d.Elements(W.rPr).Elements(W.rStyle).Attributes(W.val).FirstOrDefault();
                        if (rStyle == null)
                            rStyle = defaultCharStyleName;
                        if (rStyle != null)
                        {
                            if (d.Attribute(PtOpenXml.StyleName) != null)
                                d.Attribute(PtOpenXml.StyleName).Value = rStyle;
                            else
                                d.Add(new XAttribute(PtOpenXml.StyleName, rStyle));
                        }
                        d.Add(ptGlobalDefaultRunProps);
                    }
                }
            }
            else
            {
                foreach (var d in parasAndRuns)
                {
                    if (d.Name == W.p)
                    {
                        d.Add(ptGlobalDefaultParaProps);
                    }
                    else
                    {
                        d.Add(ptGlobalDefaultRunProps);
                    }
                }
            }
        }

        private static XElement BlankTcBorders = new XElement(W.tcBorders,
            new XElement(W.top, new XAttribute(W.val, "nil")),
            new XElement(W.left, new XAttribute(W.val, "nil")),
            new XElement(W.bottom, new XAttribute(W.val, "nil")),
            new XElement(W.right, new XAttribute(W.val, "nil")));

        private static void AnnotateTablesWithTableStyles(WordprocessingDocument wDoc, XElement rootElement)
        {
            XDocument sXDoc = wDoc.MainDocumentPart.StyleDefinitionsPart.GetXDocument();
            foreach (var tbl in rootElement.Descendants(W.tbl))
            {
                string tblStyleName = (string)tbl.Elements(W.tblPr).Elements(W.tblStyle).Attributes(W.val).FirstOrDefault();
                if (tblStyleName != null)
                {
                    XElement style = TableStyleRollup(wDoc, tblStyleName);

                    // annotate table with table style, in PowerTools namespace
                    style.Name = PtOpenXml.style;
                    tbl.Add(style);

                    // merge tblPr in table style with tblPr of the table
                    // annnotate in PowerTools namespace
                    XElement tblPr2 = style.Element(W.tblPr);
                    XElement tblPr3 = MergeStyleElement(tbl.Element(W.tblPr), tblPr2, true);
                    if (tblPr3 != null)
                    {
                        XElement newTblPr = new XElement(tblPr3);
                        newTblPr.Name = PtOpenXml.pt + "tblPr";
                        tbl.Add(newTblPr);
                    }

                    AddTcPrPtToEveryCell(tbl);
                    AddOuterBorders(tbl, style);

                    var tableTcPr = style.Element(W.tcPr);
                    if (tableTcPr != null)
                    {
                        foreach (var row in tbl.Elements(W.tr))
                        {
                            foreach (var cell in row.Elements(W.tc))
                            {
                                bool tcPrPtExists = false;
                                var tcPrPt = cell.Element(PtOpenXml.pt + "tcPr");
                                if (tcPrPt != null)
                                    tcPrPtExists = true;
                                else
                                    tcPrPt = new XElement(W.tcPr);
                                tcPrPt = MergeStyleElement(tableTcPr, tcPrPt);
                                var newTcPrPt = new XElement(tcPrPt);
                                newTcPrPt.Name = PtOpenXml.tcPr;
                                if (tcPrPtExists)
                                    cell.Element(PtOpenXml.tcPr).ReplaceWith(newTcPrPt);
                                else
                                    cell.Add(newTcPrPt);
                            }
                        }
                    }

                    // Iterate through every row and cell in the table, rolling up row properties and cell properties
                    // as appropriate per the cnfStyle element, then replacing the row and cell properties
                    foreach (var row in tbl.Elements(W.tr))
                    {
                        XElement trPr2 = null;
                        trPr2 = style.Element(W.trPr);
                        if (trPr2 == null)
                            trPr2 = new XElement(W.trPr);
                        XElement rowCnf = row.Elements(W.trPr).Elements(W.cnfStyle).FirstOrDefault();
                        if (rowCnf != null)
                        {
                            foreach (var ot in TableStyleOverrideTypes)
                            {
                                XName attName = TableStyleOverrideXNameMap[ot];
                                if (rowCnf != null && rowCnf.Attribute(attName).ToBoolean() == true)
                                {
                                    XElement o = style
                                        .Elements(W.tblStylePr)
                                        .Where(tsp => (string)tsp.Attribute(W.type) == ot)
                                        .FirstOrDefault();
                                    if (o != null)
                                    {
                                        XElement ottrPr = o.Element(W.trPr);
                                        trPr2 = MergeStyleElement(ottrPr, trPr2);
                                    }
                                }
                            }
                        }
                        trPr2 = MergeStyleElement(row.Element(W.trPr), trPr2);
                        if (trPr2.HasElements)
                        {
                            trPr2.Name = PtOpenXml.pt + "trPr";
                            row.Add(trPr2);
                        }
                    }

                    foreach (var ot in TableStyleOverrideTypes)
                    {
                        XName attName = TableStyleOverrideXNameMap[ot];
                        if (attName == W.oddHBand ||
                            attName == W.evenHBand ||
                            attName == W.firstRow ||
                            attName == W.lastRow)
                        {
                            foreach (var row in tbl.Elements(W.tr))
                            {
                                XElement rowCnf = row.Elements(W.trPr).Elements(W.cnfStyle).FirstOrDefault();
                                if (rowCnf != null && rowCnf.Attribute(attName).ToBoolean() == true)
                                {
                                    XElement o = style
                                        .Elements(W.tblStylePr)
                                        .Where(tsp => (string)tsp.Attribute(W.type) == ot)
                                        .FirstOrDefault();
                                    if (o != null)
                                    {
                                        foreach (var cell in row.Elements(W.tc))
                                        {
                                            bool tcPrPtExists = false;
                                            var tcPrPt = cell.Element(PtOpenXml.pt + "tcPr");
                                            if (tcPrPt != null)
                                                tcPrPtExists = true;
                                            else
                                                tcPrPt = new XElement(W.tcPr);
                                            tcPrPt = MergeStyleElement(o.Element(W.tcPr), tcPrPt);
                                            var newTcPrPt = new XElement(tcPrPt);
                                            newTcPrPt.Name = PtOpenXml.pt + "tcPr";
                                            if (tcPrPtExists)
                                                cell.Element(PtOpenXml.pt + "tcPr").ReplaceWith(newTcPrPt);
                                            else
                                                cell.Add(newTcPrPt);
                                        }
                                    }
                                }
                            }
                        }
                        else if (attName == W.firstColumn ||
                            attName == W.lastColumn ||
                            attName == W.oddVBand ||
                            attName == W.evenVBand)
                        {
                            foreach (var row in tbl.Elements(W.tr))
                            {
                                foreach (var cell in row.Elements(W.tc))
                                {
                                    ApplyCndFmtToCell(style, ot, attName, cell);
                                }
                            }
                        }
                        else if (attName == W.firstRowLastColumn)
                        {
                            var row = tbl.Elements(W.tr).FirstOrDefault();
                            if (row != null)
                            {
                                var cell = row.Elements(W.tc).LastOrDefault();
                                if (cell != null)
                                    ApplyCndFmtToCell(style, ot, attName, cell);
                            }
                        }
                        else if (attName == W.firstRowFirstColumn)
                        {
                            var row = tbl.Elements(W.tr).FirstOrDefault();
                            if (row != null)
                            {
                                var cell = row.Elements(W.tc).FirstOrDefault();
                                if (cell != null)
                                    ApplyCndFmtToCell(style, ot, attName, cell);
                            }
                        }
                        else if (attName == W.lastRowLastColumn)
                        {
                            var row = tbl.Elements(W.tr).LastOrDefault();
                            if (row != null)
                            {
                                var cell = row.Elements(W.tc).LastOrDefault();
                                if (cell != null)
                                    ApplyCndFmtToCell(style, ot, attName, cell);
                            }
                        }
                        else if (attName == W.lastRowFirstColumn)
                        {
                            var row = tbl.Elements(W.tr).LastOrDefault();
                            if (row != null)
                            {
                                var cell = row.Elements(W.tc).FirstOrDefault();
                                if (cell != null)
                                    ApplyCndFmtToCell(style, ot, attName, cell);
                            }
                        }
                    }
                    ProcessInnerBorders(tbl, style);
                }
                else
                {
                    var tblPr = new XElement(W.tblPr);
                    XElement tblPr3 = MergeStyleElement(tbl.Element(W.tblPr), tblPr, true);
                    if (tblPr3 != null)
                    {
                        XElement newTblPr = new XElement(tblPr3);
                        newTblPr.Name = PtOpenXml.pt + "tblPr";
                        tbl.Add(newTblPr);
                    }

                    AddTcPrPtToEveryCell(tbl);
                }
                RollInDirectFormatting(tbl); // it is important that this is last.  This merges in direct formatting.
            }
        }

        private static void AddTcPrPtToEveryCell(XElement tbl)
        {
            foreach (var row in tbl.Elements(W.tr))
            {
                foreach (var cell in row.Elements(W.tc))
                {
                    var tcPrPt = cell.Element(PtOpenXml.pt + "tcPr");
                    if (tcPrPt != null)
                        continue;
                    tcPrPt = new XElement(PtOpenXml.pt + "tcPr",
                        new XElement(W.tcBorders));
                    cell.Add(tcPrPt);
                }
            }
        }

        private static void ApplyCndFmtToCell(XElement style, string ot, XName attName, XElement cell)
        {
            XElement cellCnf = cell.Elements(W.tcPr).Elements(W.cnfStyle).FirstOrDefault();
            if (cellCnf != null && cellCnf.Attribute(attName).ToBoolean() == true)
            {
                XElement o = style
                    .Elements(W.tblStylePr)
                    .Where(tsp => (string)tsp.Attribute(W.type) == ot)
                    .FirstOrDefault();
                if (o != null)
                {
                    bool tcPrPtExists = false;
                    var tcPrPt = cell.Element(PtOpenXml.pt + "tcPr");
                    if (tcPrPt != null)
                        tcPrPtExists = true;
                    else
                        tcPrPt = new XElement(W.tcPr);
                    tcPrPt = MergeStyleElement(o.Element(W.tcPr), tcPrPt);
                    var newTcPrPt = new XElement(tcPrPt);
                    newTcPrPt.Name = PtOpenXml.pt + "tcPr";
                    if (tcPrPtExists)
                        cell.Element(PtOpenXml.pt + "tcPr").ReplaceWith(newTcPrPt);
                    else
                        cell.Add(newTcPrPt);
                }
            }
        }

        private static void RollInDirectFormatting(XElement tbl)
        {
            foreach (var row in tbl.Elements(W.tr))
            {
                foreach (var cell in row.Elements(W.tc))
                {
                    var ptTcPr = cell.Element(PtOpenXml.pt + "tcPr");
                    var tcPr = cell.Element(W.tcPr);
                    var mTcPr = MergeStyleElement(tcPr, ptTcPr);
                    if (mTcPr == null)
                    {
                        mTcPr = new XElement(PtOpenXml.pt + "tcPr");
                        cell.Add(tcPr);
                    }
                    var newTcPr = new XElement(mTcPr);
                    newTcPr.Name = PtOpenXml.pt + "tcPr";
                    var existing = cell.Element(PtOpenXml.pt + "tcPr");
                    if (existing != null)
                        existing.ReplaceWith(newTcPr);
                    else
                        cell.Add(newTcPr);
                }
            }
            var tblBorders = tbl.Elements(PtOpenXml.pt + "tblPr").Elements(W.tblBorders).FirstOrDefault();
            if (tblBorders != null && tblBorders.Attribute(PtOpenXml.pt + "fromDirect") != null)
            {
                ApplyTblBordersToTable(tbl, tblBorders);
                ProcessInnerBordersPerTblBorders(tbl, tblBorders);
            }
        }

        private static void ApplyTblBordersToTable(XElement tbl, XElement tblBorders)
        {
            var top = tblBorders.Element(W.top);
            if (top != null)
            {
                var firstRow = tbl.Elements(W.tr).FirstOrDefault();
                if (firstRow != null)
                {
                    foreach (var cell in firstRow.Elements(W.tc))
                    {
                        var cellTcBorders = cell.Elements(PtOpenXml.pt + "tcPr").Elements(W.tcBorders).FirstOrDefault();
                        if (cellTcBorders != null)
                        {
                            var cellTop = cellTcBorders.Element(W.top);
                            if (cellTop == null)
                                cellTcBorders.Add(top);
                            else
                                cellTop.ReplaceAttributes(top.Attributes());
                        }
                    }
                }
            }
            var bottom = tblBorders.Element(W.bottom);
            if (bottom != null)
            {
                var lastRow = tbl.Elements(W.tr).LastOrDefault();
                if (lastRow != null)
                {
                    foreach (var cell in lastRow.Elements(W.tc))
                    {
                        var cellTcBorders = cell.Elements(PtOpenXml.pt + "tcPr").Elements(W.tcBorders).FirstOrDefault();
                        if (cellTcBorders != null)
                        {
                            var cellBottom = cellTcBorders.Element(W.bottom);
                            if (cellBottom == null)
                                cellTcBorders.Add(bottom);
                            else
                                cellBottom.ReplaceAttributes(bottom.Attributes());
                        }
                    }
                }
            }
            foreach (var row in tbl.Elements(W.tr))
            {
                var left = tblBorders.Element(W.left);
                if (left != null)
                {
                    var firstCell = row.Elements(W.tc).FirstOrDefault();
                    if (firstCell != null)
                    {
                        var cellTcBorders = firstCell.Elements(PtOpenXml.pt + "tcPr").Elements(W.tcBorders).FirstOrDefault();
                        if (cellTcBorders != null)
                        {
                            var firstCellLeft = cellTcBorders.Element(W.left);
                            if (firstCellLeft == null)
                                cellTcBorders.Add(left);
                            else
                                firstCellLeft.ReplaceAttributes(left.Attributes());
                        }
                    }
                }
                var right = tblBorders.Element(W.right);
                if (right != null)
                {
                    var lastCell = row.Elements(W.tc).LastOrDefault();
                    if (lastCell != null)
                    {
                        var cellTcBorders = lastCell.Elements(PtOpenXml.pt + "tcPr").Elements(W.tcBorders).FirstOrDefault();
                        if (cellTcBorders != null)
                        {
                            var lastCellRight = cellTcBorders.Element(W.right);
                            if (lastCellRight == null)
                                cellTcBorders.Add(right);
                            else
                                lastCellRight.ReplaceAttributes(right.Attributes());
                        }
                    }
                }
            }
        }

        private static void AddOuterBorders(XElement tbl, XElement style)
        {
            var tblBorders = tbl.Elements(PtOpenXml.pt + "tblPr").Elements(W.tblBorders).FirstOrDefault();
            if (tblBorders != null)
                ApplyTblBordersToTable(tbl, tblBorders);
        }

        private static void ProcessInnerBorders(XElement tbl, XElement style)
        {
            var tblBorders = tbl.Elements(PtOpenXml.pt + "tblPr").Elements(W.tblBorders).FirstOrDefault();
            if (tblBorders != null)
                ProcessInnerBordersPerTblBorders(tbl, tblBorders);

            foreach (var attName in new[] { W.oddHBand, W.evenHBand, W.firstRow, W.lastRow })
            {
                int rowCount = tbl.Elements(W.tr).Count();
                int lastRow = rowCount - 1;
                XElement insideV = null;
                foreach (var row in tbl.Elements(W.tr))
                {
                    var rowCnfStyle = row.Elements(W.trPr).Elements(W.cnfStyle).FirstOrDefault();
                    if (rowCnfStyle != null)
                    {
                        var shouldApply = rowCnfStyle.Attribute(attName).ToBoolean();
                        if (shouldApply == true)
                        {
                            var cndType = TableStyleOverrideXNameRevMap[attName];
                            var cndStyle = style
                                .Elements(W.tblStylePr)
                                .FirstOrDefault(tsp => (string)tsp.Attribute(W.type) == cndType);
                            if (cndStyle != null)
                            {
                                var styleTcBorders = cndStyle.Elements(W.tcPr).Elements(W.tcBorders).FirstOrDefault();
                                if (styleTcBorders != null)
                                {
                                    var top = styleTcBorders.Element(W.top);
                                    var left = styleTcBorders.Element(W.left);
                                    var bottom = styleTcBorders.Element(W.bottom);
                                    var right = styleTcBorders.Element(W.right);
                                    insideV = cndStyle.Elements(W.tcPr).Elements(W.tcBorders).Elements(W.insideV).FirstOrDefault();
                                    if (insideV != null)
                                    {
                                        int lastCol = row.Elements(W.tc).Count() - 1;
                                        int colIdx = 0;
                                        foreach (var cell in row.Elements(W.tc))
                                        {
                                            var tcBorders = cell.Elements(PtOpenXml.pt + "tcPr").Elements(W.tcBorders).FirstOrDefault();
                                            if (colIdx == 0)
                                            {
                                                ResolveInsideWithExisting(tcBorders, insideV, W.right);
                                            }
                                            else if (colIdx == lastCol)
                                            {
                                                ResolveInsideWithExisting(tcBorders, insideV, W.left);
                                            }
                                            else
                                            {
                                                ResolveInsideWithExisting(tcBorders, insideV, W.left);
                                                ResolveInsideWithExisting(tcBorders, insideV, W.right);
                                            }
                                            colIdx++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            foreach (var attName in new[] { W.oddVBand, W.evenVBand, W.firstColumn, W.lastColumn })
            {
                int rowIdx = 0;
                int lastRow = tbl.Elements(W.tr).Count() - 1;
                foreach (var row in tbl.Elements(W.tr))
                {
                    foreach (var cell in row.Elements(W.tc))
                    {
                        var cellCnfStyle = cell.Elements(W.tcPr).Elements(W.cnfStyle).FirstOrDefault();
                        if (cellCnfStyle != null)
                        {
                            var shouldApply = cellCnfStyle.Attribute(attName).ToBoolean();
                            if (shouldApply == true)
                            {
                                var cndType = TableStyleOverrideXNameRevMap[attName];
                                var cndStyle = style
                                    .Elements(W.tblStylePr)
                                    .FirstOrDefault(tsp => (string)tsp.Attribute(W.type) == cndType);
                                if (cndStyle != null)
                                {
                                    var insideH = cndStyle.Elements(W.tcPr).Elements(W.tcBorders).Elements(W.insideH).FirstOrDefault();
                                    if (insideH != null)
                                    {
                                        var tcBorders = cell.Elements(PtOpenXml.pt + "tcPr").Elements(W.tcBorders).FirstOrDefault();
                                        if (rowIdx == 0)
                                        {
                                            ResolveInsideWithExisting(tcBorders, insideH, W.bottom);
                                        }
                                        else if (rowIdx == lastRow)
                                        {
                                            ResolveInsideWithExisting(tcBorders, insideH, W.top);
                                        }
                                        else
                                        {
                                            ResolveInsideWithExisting(tcBorders, insideH, W.bottom);
                                            ResolveInsideWithExisting(tcBorders, insideH, W.top);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    rowIdx++;
                }
            }
        }

        private static void ProcessInnerBordersPerTblBorders(XElement tbl, XElement tblBorders)
        {
            var tblInsideV = tblBorders.Elements(W.insideV).FirstOrDefault();
            if (tblInsideV != null)
            {
                foreach (var row in tbl.Elements(W.tr))
                {
                    var lastCell = row.Elements(W.tc).Count() - 1;
                    int cellIdx = 0;
                    foreach (var cell in row.Elements(W.tc))
                    {
                        var tcPr = cell.Element(PtOpenXml.pt + "tcPr");
                        if (tcPr == null)
                        {
                            tcPr = new XElement(PtOpenXml.pt + "tcPr");
                            cell.Add(tcPr);
                        }
                        var tcBorders = tcPr.Element(W.tcBorders);
                        if (tcBorders == null)
                        {
                            tcBorders = new XElement(W.tcBorders);
                            tcPr.Add(tcBorders);
                        }
                        if (cellIdx == 0)
                        {
                            ResolveInsideWithExisting(tcBorders, tblInsideV, W.right);
                        }
                        else if (cellIdx == lastCell)
                        {
                            ResolveInsideWithExisting(tcBorders, tblInsideV, W.left);
                        }
                        else
                        {
                            ResolveInsideWithExisting(tcBorders, tblInsideV, W.left);
                            ResolveInsideWithExisting(tcBorders, tblInsideV, W.right);
                        }
                        cellIdx++;
                    }
                }
            }
            var tblInsideH = tblBorders.Elements(W.insideH).FirstOrDefault();
            if (tblInsideH != null)
            {
                int rowIdx1 = 0;
                int lastRow1 = tbl.Elements(W.tr).Count() - 1;
                foreach (var row in tbl.Elements(W.tr))
                {
                    if (rowIdx1 == 0)
                    {
                        foreach (var cell in row.Elements(W.tc))
                        {
                            var tcBorders = cell.Elements(PtOpenXml.pt + "tcPr").Elements(W.tcBorders).FirstOrDefault();
                            ResolveInsideWithExisting(tcBorders, tblInsideH, W.bottom);
                        }
                    }
                    else if (rowIdx1 == lastRow1)
                    {
                        foreach (var cell in row.Elements(W.tc))
                        {
                            var tcBorders = cell.Elements(PtOpenXml.pt + "tcPr").Elements(W.tcBorders).FirstOrDefault();
                            ResolveInsideWithExisting(tcBorders, tblInsideH, W.top);
                        }
                    }
                    else
                    {
                        foreach (var cell in row.Elements(W.tc))
                        {
                            var tcBorders = cell.Elements(PtOpenXml.pt + "tcPr").Elements(W.tcBorders).FirstOrDefault();
                            ResolveInsideWithExisting(tcBorders, tblInsideH, W.top);
                            ResolveInsideWithExisting(tcBorders, tblInsideH, W.bottom);
                        }
                    }
                    rowIdx1++;
                }
            }
        }

        private static void ResolveInsideWithExisting(XElement tcBorders, XElement inside, XName whichSide)
        {
            if (tcBorders.Element(whichSide) != null)
            {
                var newInsideH = ResolveInsideBorder(inside, tcBorders.Element(whichSide));
                tcBorders.Element(whichSide).ReplaceAttributes(
                    newInsideH.Attributes());
            }
            else
            {
                tcBorders.Add(
                    new XElement(whichSide,
                        inside.Attributes()));
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
            {"dotDash", 6 },
            {"dotDotDash", 7 },
            {"triple", 8 },
            {"thinThickSmallGap", 9 },
            {"thickThinSmallGap", 10 },
            {"thinThickThinSmallGap", 11 },
            {"thinThickMediumGap", 12 },
            {"thickThinMediumGap", 13 },
            {"thinThickThinMediumGap", 14 },
            {"thinThickLargeGap", 15 },
            {"thickThinLargeGap", 16 },
            {"thinThickThinLargeGap", 17 },
            {"wave", 18 },
            {"doubleWave", 19 },
            {"dashSmallGap", 20 },
            {"dashDotStroked", 21 },
            {"threeDEmboss", 22 },
            {"threeDEngrave", 23 },
            {"outset", 24 },
            {"inset", 25 },
        };

        private static XElement ResolveInsideBorder(XElement inside1, XElement sideToReplace)
        {
            if (inside1 == null && sideToReplace == null)
                return null;
            if (inside1 == null)
                return sideToReplace;
            if (sideToReplace == null)
                return inside1;

            // The following handles the situation where
            // if table innerV is set, and cnd format for first row specifies nill border, then nil border wins.
            // if table innerH is set, and cnd format for first columns specifies nil border, then table innerH wins.
            if (sideToReplace.Name == W.left ||
                sideToReplace.Name == W.right)
            {
                if ((string)inside1.Attribute(W.val) == "nil")
                    return inside1;
                if ((string)sideToReplace.Attribute(W.val) == "nil")
                    return sideToReplace;
            }
            else
            {
                if ((string)inside1.Attribute(W.val) == "nil")
                    return sideToReplace;
                if ((string)sideToReplace.Attribute(W.val) == "nil")
                    return inside1;
            }

            var inside1Val = (string)inside1.Attribute(W.val);
            var border1Weight = 1;
            if (BorderNumber.ContainsKey(inside1Val))
                border1Weight = BorderNumber[inside1Val];

            var sideToReplaceVal = (string)sideToReplace.Attribute(W.val);
            var sideToReplaceWeight = 1;
            if (BorderNumber.ContainsKey(sideToReplaceVal))
                sideToReplaceWeight = BorderNumber[sideToReplaceVal];

            if (border1Weight != sideToReplaceWeight)
            {
                if (border1Weight < sideToReplaceWeight)
                    return sideToReplace;
                else
                    return inside1;
            }

            if ((int)inside1.Attribute(W.sz) > (int)sideToReplace.Attribute(W.sz))
                return inside1;

            if ((int)sideToReplace.Attribute(W.sz) > (int)inside1.Attribute(W.sz))
                return sideToReplace;

            if (BorderTypePriority.ContainsKey(inside1Val) &&
                BorderTypePriority.ContainsKey(sideToReplaceVal))
            {
                var inside1Pri = BorderTypePriority[inside1Val];
                var inside2Pri = BorderTypePriority[sideToReplaceVal];
                if (inside1Pri > inside2Pri)
                    return inside1;
                if (inside2Pri > inside1Pri)
                    return sideToReplace;
            }

            if ((int)inside1.Attribute(W.sz) > (int)sideToReplace.Attribute(W.sz))
                return inside1;

            if ((int)sideToReplace.Attribute(W.sz) > (int)inside1.Attribute(W.sz))
                return sideToReplace;

            var color1str = (string)inside1.Attribute(W.color);
            if (color1str == "auto")
                color1str = "000000";
            var color2str = (string)sideToReplace.Attribute(W.color);
            if (color2str == "auto")
                color2str = "000000";
            if (color1str != null && color2str != null && color1str != color2str)
            {
                Int32 color1;
                Int32 color2;
                try
                {
                    color1 = Convert.ToInt32(color1str, 16);
                }
                // if the above throws ArgumentException, FormatException, or OverflowException, then abort
                catch (Exception) 
                {
                    return sideToReplace;
                }
                try
                {
                    color2 = Convert.ToInt32(color2str, 16);
                }
                // if the above throws ArgumentException, FormatException, or OverflowException, then abort
                catch (Exception)
                {
                    return inside1;
                }
                if (color1 < color2)
                    return inside1;
                if (color2 < color1)
                    return sideToReplace;
                return inside1;
            }
            return inside1;
        }

        private static XElement TableStyleRollup(WordprocessingDocument wDoc, string tblStyleName)
        {
            var tblStyleChain = TableStyleStack(wDoc, tblStyleName)
                .Reverse();
            XElement rolledStyle = new XElement(W.style);
            foreach (var style in tblStyleChain)
            {
                rolledStyle = MergeStyleElement(style, rolledStyle);
            }
            return rolledStyle;
        }

        private static XName[] SpecialCaseChildProperties =
        {
            W.tblPr,
            W.trPr,
            W.tcPr,
            W.pPr,
            W.rPr,
            W.pBdr,
            W.tabs,
            W.rFonts,
            W.ind,
            W.spacing,
            W.tblStylePr,
            W.tcBorders,
            W.tblBorders,
            W.lang,
            W.numPr,
        };

        private static XName[] MergeChildProperties =
        {
            W.tblPr,
            W.trPr,
            W.tcPr,
            W.pPr,
            W.rPr,
            W.pBdr,
            W.tcBorders,
            W.tblBorders,
            W.numPr,
        };

        private static string[] TableStyleOverrideTypes =
        {
            "band1Vert",
            "band2Vert",
            "band1Horz",
            "band2Horz",
            "firstCol",
            "lastCol",
            "firstRow",
            "lastRow",
            "neCell",
            "nwCell",
            "seCell",
            "swCell",
        };

        private static Dictionary<string, XName> TableStyleOverrideXNameMap = new Dictionary<string, XName>
        {
            {"band1Vert", W.oddVBand},
            {"band2Vert", W.evenVBand},
            {"band1Horz", W.oddHBand},
            {"band2Horz", W.evenHBand},
            {"firstCol", W.firstColumn},
            {"lastCol", W.lastColumn},
            {"firstRow", W.firstRow},
            {"lastRow", W.lastRow},
            {"neCell", W.firstRowLastColumn},
            {"nwCell", W.firstRowFirstColumn},
            {"seCell", W.lastRowLastColumn},
            {"swCell", W.lastRowFirstColumn},
        };

        private static Dictionary<XName, string> TableStyleOverrideXNameRevMap = new Dictionary<XName, string>
        {
            {W.oddVBand, "band1Vert"},
            {W.evenVBand, "band2Vert"},
            {W.oddHBand, "band1Horz"},
            {W.evenHBand, "band2Horz"},
            {W.firstColumn, "firstCol"},
            {W.lastColumn, "lastCol"},
            {W.firstRow, "firstRow"},
            {W.lastRow, "lastRow"},
        };

        private static XElement MergeStyleElement(XElement higherPriorityElement, XElement lowerPriorityElement)
        {
            return MergeStyleElement(higherPriorityElement, lowerPriorityElement, null);
        }

        private static XElement MergeStyleElement(XElement higherPriorityElement, XElement lowerPriorityElement, bool? highPriIsDirectFormatting)
        {
            // If, when in the process of merging, the source element doesn't have a
            // corresponding element in the merged element, then include the source element
            // in the merged element.
            if (lowerPriorityElement == null)
                return higherPriorityElement;
            if (higherPriorityElement == null)
                return lowerPriorityElement;

            var hpe = higherPriorityElement
                .Elements()
                .Where(e => !SpecialCaseChildProperties.Contains(e.Name))
                .ToArray();
            if (highPriIsDirectFormatting == true)
            {
                hpe = hpe
                    .Select(e =>
                        new XElement(e.Name,
                            e.Attributes(),
                            new XAttribute(PtOpenXml.pt + "fromDirect", true),
                            e.Elements()))
                    .ToArray();
            }
            var lpe = lowerPriorityElement
                .Elements()
                .Where(e => !SpecialCaseChildProperties.Contains(e.Name) && !hpe.Select(z => z.Name).Contains(e.Name))
                .ToArray();
            var ma = SpacingMerge(higherPriorityElement.Element(W.spacing), lowerPriorityElement.Element(W.spacing));
            var rFonts = FontMerge(higherPriorityElement.Element(W.rFonts), lowerPriorityElement.Element(W.rFonts));
            var tabs = TabsMerge(higherPriorityElement.Element(W.tabs), lowerPriorityElement.Element(W.tabs));
            var ind = IndMerge(higherPriorityElement.Element(W.ind), lowerPriorityElement.Element(W.ind));
            var lang = LangMerge(higherPriorityElement.Element(W.lang), lowerPriorityElement.Element(W.lang));
            var mcp = MergeChildProperties
                .Select(e =>
                {
                    // test is here to prevent unnecessary recursion to make debugging easier
                    var h = higherPriorityElement.Element(e);
                    var l = lowerPriorityElement.Element(e);
                    if (h == null && l == null)
                        return null;
                    if (h == null && l != null)
                        return l;
                    if (h != null && l == null)
                    {
                        var newH = new XElement(h.Name,
                            h.Attributes(),
                            highPriIsDirectFormatting == true ? new XAttribute(PtOpenXml.pt + "fromDirect", true) : null,
                            h.Elements());
                        return newH;
                    }
                    return MergeStyleElement(h, l, highPriIsDirectFormatting);
                })
                .Where(m => m != null)
                .ToArray();
            var tsor = TableStyleOverrideTypes
                .Select(e =>
                {
                    // test is here to prevent unnecessary recursion to make debugging easier
                    var h = higherPriorityElement.Elements(W.tblStylePr).FirstOrDefault(tsp => (string)tsp.Attribute(W.type) == e);
                    var l = lowerPriorityElement.Elements(W.tblStylePr).FirstOrDefault(tsp => (string)tsp.Attribute(W.type) == e);
                    if (h == null && l == null)
                        return null;
                    if (h == null && l != null)
                        return l;
                    if (h != null && l == null)
                        return h;
                    return MergeStyleElement(h, l);
                })
                .Where(m => m != null)
                .ToArray();

            XElement newMergedElement = new XElement(higherPriorityElement.Name,
                new XAttribute(XNamespace.Xmlns + "w", W.w),
                higherPriorityElement.Attributes().Where(a => !a.IsNamespaceDeclaration),
                hpe,  // higher priority elements
                lpe,  // lower priority elements where there is not a higher priority element of same name
                ind,  // w:ind has very special rules
                ma,   // elements that require merged attributes
                lang,
                rFonts,  // font merge is special case
                tabs,    // tabs merge is special case
                mcp,  // elements that need child properties to be merged
                tsor // merged table style override elements
            );

            return newMergedElement;
        }

        private static XElement LangMerge(XElement hLang, XElement lLang)
        {
            if (hLang == null && lLang == null)
                return null;
            if (hLang != null && lLang == null)
                return hLang;
            if (lLang != null && hLang == null)
                return lLang;
            return new XElement(W.lang,
                hLang.Attribute(W.val) != null ? hLang.Attribute(W.val) : lLang.Attribute(W.val),
                hLang.Attribute(W.bidi) != null ? hLang.Attribute(W.bidi) : lLang.Attribute(W.bidi),
                hLang.Attribute(W.eastAsia) != null ? hLang.Attribute(W.eastAsia) : lLang.Attribute(W.eastAsia));
        }

        private enum IndAttType
        {
            End,
            FirstLineOrHanging,
            Start,
            Left,
            Right,
            None,
        };

        private static XElement IndMerge(XElement higherPriorityElement, XElement lowerPriorityElement)
        {
            if (higherPriorityElement == null && lowerPriorityElement == null)
                return null;
            if (higherPriorityElement != null && lowerPriorityElement == null)
                return higherPriorityElement;
            if (lowerPriorityElement != null && higherPriorityElement == null)
                return lowerPriorityElement;

            XElement hpe = new XElement(higherPriorityElement);
            XElement lpe = new XElement(lowerPriorityElement);

            if (hpe.Attribute(W.firstLine) != null)
                lpe.Attributes(W.hanging).Remove();

            if (hpe.Attribute(W.firstLineChars) != null)
                lpe.Attributes(W.hangingChars).Remove();

            if (hpe.Attribute(W.hanging) != null)
                lpe.Attributes(W.firstLine).Remove();

            if (hpe.Attribute(W.hangingChars) != null)
                lpe.Attributes(W.firstLineChars).Remove();

            var highPriAtts = hpe
                .Attributes()
                .Where(a => !a.IsNamespaceDeclaration)
                .ToList();

            var highPriAttNames = highPriAtts
                .Select(a => a.Name);

            var lowPriAtts = lpe
                .Attributes()
                .Where(a => !a.IsNamespaceDeclaration)
                .Where(a => !highPriAttNames.Contains(a.Name))
                .ToList();

            var mergedElement = new XElement(higherPriorityElement.Name,
                highPriAtts,
                lowPriAtts);

            return mergedElement;
        }

        // merge child tab elements
        // they are additive, with the exception that if there are two elements at the same location,
        // we need to take the higher, and not take the lower.
        private static XElement TabsMerge(XElement higherPriorityElement, XElement lowerPriorityElement)
        {
            if (higherPriorityElement != null && lowerPriorityElement == null)
                return higherPriorityElement;
            if (higherPriorityElement == null && lowerPriorityElement != null)
                return lowerPriorityElement;
            if (higherPriorityElement == null && lowerPriorityElement == null)
                return null;
            var hps = higherPriorityElement.Elements().Select(e =>
                new
                {
                    Pos = (int)e.Attribute(W.pos),
                    Pri = 1,
                    Element = e,
                }
            );
            var lps = lowerPriorityElement.Elements().Select(e =>
                new
                {
                    Pos = (int)e.Attribute(W.pos),
                    Pri = 2,
                    Element = e,
                }
            );
            var newTabElements = hps.Concat(lps)
                .GroupBy(s => s.Pos)
                .Select(g => g.OrderBy(s => s.Pri).First().Element)
                .Where(e => (string)e.Attribute(W.val) != "clear")
                .OrderBy(e => (int)e.Attribute(W.pos));
            var newTabs = new XElement(W.tabs, newTabElements);
            return newTabs;
        }

        private static XElement SpacingMerge(XElement hn, XElement ln)
        {
            if (hn == null && ln == null)
                return null;
            if (hn != null && ln == null)
                return hn;
            if (hn == null && ln != null)
                return ln;
            var mn1 = new XElement(W.spacing,
                hn.Attributes(),
                ln.Attributes().Where(a => hn.Attribute(a.Name) == null));
            return mn1;
        }

        private static IEnumerable<XElement> TableStyleStack(WordprocessingDocument wDoc, string tblStyleName)
        {
            XDocument sXDoc = wDoc.MainDocumentPart.StyleDefinitionsPart.GetXDocument();
            string currentStyle = tblStyleName;
            while (true)
            {
                XElement style = sXDoc
                    .Root
                    .Elements(W.style).Where(s => (string)s.Attribute(W.type) == "table" &&
                        (string)s.Attribute(W.styleId) == currentStyle)
                    .FirstOrDefault();
                if (style == null)
                    yield break;
                yield return style;
                currentStyle = (string)style.Elements(W.basedOn).Attributes(W.val).FirstOrDefault();
                if (currentStyle == null)
                    yield break;
            }
        }

        private static XElement FontMerge(XElement higherPriorityFont, XElement lowerPriorityFont)
        {
            XElement rFonts;

            if (higherPriorityFont == null)
                return lowerPriorityFont;
            if (lowerPriorityFont == null)
                return higherPriorityFont;
            if (higherPriorityFont == null && lowerPriorityFont == null)
                return null;

            rFonts = new XElement(W.rFonts,
                (higherPriorityFont.Attribute(W.ascii) != null || higherPriorityFont.Attribute(W.asciiTheme) != null) ?
                    new[] { higherPriorityFont.Attribute(W.ascii), higherPriorityFont.Attribute(W.asciiTheme) } :
                    new[] { lowerPriorityFont.Attribute(W.ascii), lowerPriorityFont.Attribute(W.asciiTheme) },
                (higherPriorityFont.Attribute(W.hAnsi) != null || higherPriorityFont.Attribute(W.hAnsiTheme) != null) ?
                    new[] { higherPriorityFont.Attribute(W.hAnsi), higherPriorityFont.Attribute(W.hAnsiTheme) } :
                    new[] { lowerPriorityFont.Attribute(W.hAnsi), lowerPriorityFont.Attribute(W.hAnsiTheme) },
                (higherPriorityFont.Attribute(W.eastAsia) != null || higherPriorityFont.Attribute(W.eastAsiaTheme) != null) ?
                    new[] { higherPriorityFont.Attribute(W.eastAsia), higherPriorityFont.Attribute(W.eastAsiaTheme) } :
                    new[] { lowerPriorityFont.Attribute(W.eastAsia), lowerPriorityFont.Attribute(W.eastAsiaTheme) },
                (higherPriorityFont.Attribute(W.cs) != null || higherPriorityFont.Attribute(W.cstheme) != null) ?
                    new[] { higherPriorityFont.Attribute(W.cs), higherPriorityFont.Attribute(W.cstheme) } :
                    new[] { lowerPriorityFont.Attribute(W.cs), lowerPriorityFont.Attribute(W.cstheme) },
                (higherPriorityFont.Attribute(W.hint) != null ? higherPriorityFont.Attribute(W.hint) :
                    lowerPriorityFont.Attribute(W.hint))
            );

            return rFonts;
        }

        private static void AnnotateParagraphs(FormattingAssemblerInfo fai, WordprocessingDocument wDoc, XElement root, FormattingAssemblerSettings settings)
        {
            foreach (var para in root.Descendants(W.p))
            {
                AnnotateParagraph(fai, wDoc, para, settings);
            }
        }

        private static void AnnotateParagraph(FormattingAssemblerInfo fai, WordprocessingDocument wDoc, XElement para, FormattingAssemblerSettings settings)
        {
            XElement localParaProps = para.Element(W.pPr);
            if (localParaProps == null)
            {
                localParaProps = new XElement(W.pPr);
            }

            // get para table props, to be merged.
            XElement tablepPr = null;

            var blockLevelContentContainer = para
                .Ancestors()
                .FirstOrDefault(a => a.Name == W.body ||
                    a.Name == W.tbl ||
                    a.Name == W.txbxContent ||
                    a.Name == W.ftr ||
                    a.Name == W.hdr ||
                    a.Name == W.footnote ||
                    a.Name == W.endnote);
            if (blockLevelContentContainer.Name == W.tbl)
            {
                XElement tbl = blockLevelContentContainer;
                XElement style = tbl.Element(PtOpenXml.pt + "style");
                XElement cellCnf = para.Ancestors(W.tc).Take(1).Elements(W.tcPr).Elements(W.cnfStyle).FirstOrDefault();
                XElement rowCnf = para.Ancestors(W.tr).Take(1).Elements(W.trPr).Elements(W.cnfStyle).FirstOrDefault();

                if (style != null)
                {
                    // roll up tblPr, trPr, and tcPr from within a specific style.
                    // add each of these to the table, in PowerTools namespace.
                    tablepPr = style.Element(W.pPr);
                    if (tablepPr == null)
                        tablepPr = new XElement(W.pPr);

                    foreach (var ot in TableStyleOverrideTypes)
                    {
                        XName attName = TableStyleOverrideXNameMap[ot];
                        if ((cellCnf != null && cellCnf.Attribute(attName).ToBoolean() == true) ||
                            (rowCnf != null && rowCnf.Attribute(attName).ToBoolean() == true))
                        {
                            XElement o = style
                                .Elements(W.tblStylePr)
                                .Where(tsp => (string)tsp.Attribute(W.type) == ot)
                                .FirstOrDefault();
                            if (o != null)
                            {
                                XElement otpPr = o.Element(W.pPr);
                                tablepPr = MergeStyleElement(otpPr, tablepPr);
                            }
                        }
                    }
                }
            }
            var stylesPart = wDoc.MainDocumentPart.StyleDefinitionsPart;
            XDocument sXDoc = null;
            if (stylesPart != null)
                sXDoc = stylesPart.GetXDocument();

            ListItemRetriever.ListItemInfo lif = para.Annotation<ListItemRetriever.ListItemInfo>();

            XElement rolledParaProps = ParagraphStyleRollup(para, sXDoc, fai.DefaultParagraphStyleName);
            if (lif != null && lif.IsZeroNumId)
                rolledParaProps.Elements(W.ind).Remove();
            XElement toggledParaProps = MergeStyleElement(rolledParaProps, tablepPr);
            XElement mergedParaProps = MergeStyleElement(localParaProps, toggledParaProps);

            string li = ListItemRetriever.RetrieveListItem(wDoc, para, settings.ListItemRetrieverSettings);
            if (lif != null && lif.IsListItem)
            {
                if (settings.RestrictToSupportedNumberingFormats)
                {
                    string numFmtForLevel = (string)lif.Lvl(ListItemRetriever.GetParagraphLevel(para)).Elements(W.numFmt).Attributes(W.val).FirstOrDefault();
                    if (numFmtForLevel == null)
                    {
                        var numFmtElement = lif.Lvl(ListItemRetriever.GetParagraphLevel(para)).Elements(MC.AlternateContent).Elements(MC.Choice).Elements(W.numFmt).FirstOrDefault();
                        if (numFmtElement != null && (string)numFmtElement.Attribute(W.val) == "custom")
                            numFmtForLevel = (string)numFmtElement.Attribute(W.format);
                    }
                    bool isLgl = lif.Lvl(ListItemRetriever.GetParagraphLevel(para)).Elements(W.isLgl).Any();
                    if (isLgl && numFmtForLevel != "decimalZero")
                        numFmtForLevel = "decimal";
                    if (!AcceptableNumFormats.Contains(numFmtForLevel))
                        throw new UnsupportedNumberingFormatException(numFmtForLevel + " is not a supported numbering format");
                }

                int paragraphLevel = ListItemRetriever.GetParagraphLevel(para);
                var numberingParaProps = lif
                    .Lvl(paragraphLevel)
                    .Elements(W.pPr)
                    .FirstOrDefault();
                if (numberingParaProps == null)
                {
                    numberingParaProps = new XElement(W.pPr);
                }
                else
                {
                    numberingParaProps
                        .Elements()
                        .Where(e => e.Name != W.ind)
                        .Remove();
                }

                // have:
                // - localParaProps
                // - toggledParaProps
                // - numberingParaProps

                // if a paragraph contains a numPr with a numId=0, in other words, it is NOT a numbered item, then the indentation from the style
                // hierarchy is ignored.

                ListItemRetriever.ListItemInfo lii = para.Annotation<ListItemRetriever.ListItemInfo>();
                if (lii.FromParagraph != null)
                {
                    // order
                    // - toggledParaProps
                    // - numberingParaProps
                    // - localParaProps

                    mergedParaProps = MergeStyleElement(numberingParaProps, toggledParaProps);
                    mergedParaProps = MergeStyleElement(localParaProps, mergedParaProps);
                }
                else if (lii.FromStyle != null)
                {
                    // order
                    // - numberingParaProps
                    // - toggledParaProps
                    // - localParaProps
                    mergedParaProps = MergeStyleElement(toggledParaProps, numberingParaProps);
                    mergedParaProps = MergeStyleElement(localParaProps, mergedParaProps);
                }
            }
            else
            {
                mergedParaProps = MergeStyleElement(localParaProps, toggledParaProps);
            }

            // merge mergedParaProps with existing accumulatedParaProps, with mergedParaProps as high pri
            // replace accumulatedParaProps with newly merged

            XElement accumulatedParaProps = para.Element(PtOpenXml.pt + "pPr");
            XElement newAccumulatedParaProps = MergeStyleElement(mergedParaProps, accumulatedParaProps);

            AdjustFontAttributes(wDoc, para, newAccumulatedParaProps, newAccumulatedParaProps.Element(W.rPr), settings);
            newAccumulatedParaProps.Name = PtOpenXml.pt + "pPr";
            if (accumulatedParaProps != null)
            {
                accumulatedParaProps.ReplaceWith(newAccumulatedParaProps);
            }
            else
            {
                para.Add(newAccumulatedParaProps);
            }
        }

        private static string[] AcceptableNumFormats = new[] {
            "decimal",
            "decimalZero",
            "upperRoman",
            "lowerRoman",
            "upperLetter",
            "lowerLetter",
            "ordinal",
            "cardinalText",
            "ordinalText",
            "bullet",
            "0001, 0002, 0003, ...",
            "none",
        };

        public static XElement ParagraphStyleRollup(XElement paragraph, XDocument stylesXDoc, string defaultParagraphStyleName)
        {
            var paraStyle = (string)paragraph
                .Elements(W.pPr)
                .Elements(W.pStyle)
                .Attributes(W.val)
                .FirstOrDefault();
            if (paraStyle == null)
                paraStyle = defaultParagraphStyleName;
            var rolledUpParaStyleParaProps = new XElement(W.pPr);
            if (stylesXDoc == null)
                return rolledUpParaStyleParaProps;
            if (paraStyle != null)
            {
                rolledUpParaStyleParaProps = ParaStyleParaPropsStack(stylesXDoc, paraStyle, paragraph)
                    .Reverse()
                    .Aggregate(new XElement(W.pPr),
                        (r, s) =>
                        {
                            var newParaProps = MergeStyleElement(s, r);
                            return newParaProps;
                        });
            }
            return rolledUpParaStyleParaProps;
        }

        private static IEnumerable<XElement> ParaStyleParaPropsStack(XDocument stylesXDoc, string paraStyleName, XElement para)
        {
            if (stylesXDoc == null)
                yield break;
            var localParaStyleName = paraStyleName;
            while (localParaStyleName != null)
            {
                XElement paraStyle = stylesXDoc.Root.Elements(W.style).FirstOrDefault(s =>
                    s.Attribute(W.type).Value == "paragraph" &&
                    s.Attribute(W.styleId).Value == localParaStyleName);
                if (paraStyle == null)
                {
                    yield break;
                }
                if (paraStyle.Element(W.pPr) == null)
                {
                    if (paraStyle.Element(W.rPr) != null)
                    {
                        var elementToYield2 = new XElement(W.pPr,
                            paraStyle.Element(W.rPr));
                        yield return elementToYield2;
                    }
                    localParaStyleName = (string)(paraStyle
                        .Elements(W.basedOn)
                        .Attributes(W.val)
                        .FirstOrDefault());
                    continue;
                }

                var elementToYield = new XElement(W.pPr,
                    paraStyle.Element(W.pPr).Attributes(),
                    paraStyle.Element(W.pPr).Elements(),
                    paraStyle.Element(W.rPr));
                yield return (elementToYield);

                var listItemInfo = para.Annotation<ListItemRetriever.ListItemInfo>();
                if (listItemInfo != null)
                {
                    if (listItemInfo.IsListItem)
                    {
                        XElement lipPr = listItemInfo.Lvl(ListItemRetriever.GetParagraphLevel(para)).Element(W.pPr);
                        if (lipPr == null)
                            lipPr = new XElement(W.pPr);
                        XElement lirPr = listItemInfo.Lvl(ListItemRetriever.GetParagraphLevel(para)).Element(W.rPr);
                        var elementToYield2 = new XElement(W.pPr,
                            lipPr.Attributes(),
                            lipPr.Elements(),
                            lirPr);
                        yield return (elementToYield2);
                    }
                }

                localParaStyleName = (string)paraStyle
                    .Elements(W.basedOn)
                    .Attributes(W.val)
                    .FirstOrDefault();
            }
            yield break;
        }

        private static void AnnotateRuns(FormattingAssemblerInfo fai, WordprocessingDocument wDoc, XElement root, FormattingAssemblerSettings settings)
        {
            var runsOrParas = root.Descendants()
                .Where(rp =>
                {
                    return rp.Name == W.r || rp.Name == W.p;
                });
            foreach (var runOrPara in runsOrParas)
            {
                AnnotateRunProperties(fai, wDoc, runOrPara, settings);
            }
        }

        private static void AnnotateRunProperties(FormattingAssemblerInfo fai, WordprocessingDocument wDoc, XElement runOrPara, FormattingAssemblerSettings settings)
        {
            XElement localRunProps = null;
            if (runOrPara.Name == W.p)
            {
                var rPr = runOrPara.Elements(W.pPr).Elements(W.rPr).FirstOrDefault();
                if (rPr != null)
                {
                    localRunProps = rPr;
                }
            }
            else
            {
                localRunProps = runOrPara.Element(W.rPr);
            }
            if (localRunProps == null)
            {
                localRunProps = new XElement(W.rPr);
            }

            // get run table props, to be merged.
            XElement tablerPr = null;
            var blockLevelContentContainer = runOrPara
                .Ancestors()
                .FirstOrDefault(a => a.Name == W.body ||
                    a.Name == W.tbl ||
                    a.Name == W.txbxContent ||
                    a.Name == W.ftr ||
                    a.Name == W.hdr ||
                    a.Name == W.footnote ||
                    a.Name == W.endnote);
            if (blockLevelContentContainer.Name == W.tbl)
            {
                XElement tbl = blockLevelContentContainer;
                XElement style = tbl.Element(PtOpenXml.pt + "style");
                XElement cellCnf = runOrPara.Ancestors(W.tc).Take(1).Elements(W.tcPr).Elements(W.cnfStyle).FirstOrDefault();
                XElement rowCnf = runOrPara.Ancestors(W.tr).Take(1).Elements(W.trPr).Elements(W.cnfStyle).FirstOrDefault();

                if (style != null)
                {
                    tablerPr = style.Element(W.rPr);
                    if (tablerPr == null)
                        tablerPr = new XElement(W.rPr);

                    foreach (var ot in TableStyleOverrideTypes)
                    {
                        XName attName = TableStyleOverrideXNameMap[ot];
                        if ((cellCnf != null && cellCnf.Attribute(attName).ToBoolean() == true) ||
                            (rowCnf != null && rowCnf.Attribute(attName).ToBoolean() == true))
                        {
                            XElement o = style
                                .Elements(W.tblStylePr)
                                .Where(tsp => (string)tsp.Attribute(W.type) == ot)
                                .FirstOrDefault();
                            if (o != null)
                            {
                                XElement otrPr = o.Element(W.rPr);
                                tablerPr = MergeStyleElement(otrPr, tablerPr);
                            }
                        }
                    }
                }
            }
            XElement rolledRunProps = CharStyleRollup(fai, wDoc, runOrPara);
            var toggledRunProps = ToggleMergeRunProps(rolledRunProps, tablerPr);
            var currentRunProps = runOrPara.Element(PtOpenXml.rPr); // this is already stored on the run from previous aggregation of props
            var mergedRunProps = MergeStyleElement(toggledRunProps, currentRunProps);
            var newMergedRunProps = MergeStyleElement(localRunProps, mergedRunProps);
            XElement pPr = null;
            if (runOrPara.Name == W.p)
                pPr = runOrPara.Element(PtOpenXml.pPr);
            AdjustFontAttributes(wDoc, runOrPara, pPr, newMergedRunProps, settings);

            newMergedRunProps.Name = PtOpenXml.rPr;
            if (currentRunProps != null)
            {
                currentRunProps.ReplaceWith(newMergedRunProps);
            }
            else
            {
                runOrPara.Add(newMergedRunProps);
            }
        }

        private static XElement CharStyleRollup(FormattingAssemblerInfo fai, WordprocessingDocument wDoc, XElement runOrPara)
        {
            var sXDoc = wDoc.MainDocumentPart.StyleDefinitionsPart.GetXDocument();

            string charStyle = null;
            string paraStyle = null;
            XElement rPr = null;
            XElement pPr = null;
            XElement pStyle = null;
            XElement rStyle = null;
            CachedParaInfo cpi = null; // CachedParaInfo is an optimization for the case where a paragraph contains thousands of runs.

            if (runOrPara.Name == W.p)
            {
                cpi = runOrPara.Annotation<CachedParaInfo>();
                if (cpi != null)
                    pPr = cpi.ParagraphProperties;
                else
                {
                    pPr = runOrPara.Element(W.pPr);
                    if (pPr != null)
                    {
                        paraStyle = (string)pPr.Elements(W.pStyle).Attributes(W.val).FirstOrDefault();
                    }
                    else
                    {
                        paraStyle = fai.DefaultParagraphStyleName;
                    }
                    cpi = new CachedParaInfo
                    {
                        ParagraphProperties = pPr,
                        ParagraphStyleName = paraStyle,
                    };
                    runOrPara.AddAnnotation(cpi);
                }
                if (pPr != null)
                {
                    rPr = pPr.Element(W.rPr);
                }
            }
            else
            {
                rPr = runOrPara.Element(W.rPr);
            }
            if (rPr != null)
            {
                rStyle = rPr.Element(W.rStyle);
                if (rStyle != null)
                {
                    charStyle = (string)rStyle.Attribute(W.val);
                }
                else
                {
                    if (runOrPara.Name == W.r)
                        charStyle = (string)runOrPara
                            .Ancestors(W.p)
                            .Take(1)
                            .Elements(W.pPr)
                            .Elements(W.pStyle)
                            .Attributes(W.val)
                            .FirstOrDefault();
                    else
                        charStyle = (string)runOrPara
                            .Elements(W.pPr)
                            .Elements(W.pStyle)
                            .Attributes(W.val)
                            .FirstOrDefault();
                }
            }

            if (charStyle == null)
            {
                if (runOrPara.Name == W.r)
                {
                    var ancestorPara = runOrPara.Ancestors(W.p).First();
                    cpi = ancestorPara.Annotation<CachedParaInfo>();
                    if (cpi != null)
                        charStyle = cpi.ParagraphStyleName;
                    else
                        charStyle = (string)runOrPara.Ancestors(W.p).First().Elements(W.pPr).Elements(W.pStyle).Attributes(W.val).FirstOrDefault();
                }
                if (charStyle == null)
                {
                    charStyle = fai.DefaultParagraphStyleName;
                }
            }

            // A run always must have an ancestor paragraph.
            XElement para = null;
            var rolledUpParaStyleRunProps = new XElement(W.rPr);
            if (runOrPara.Name == W.r)
            {
                para = runOrPara.Ancestors(W.p).FirstOrDefault();
            }
            else
            {
                para = runOrPara;
            }

            cpi = para.Annotation<CachedParaInfo>();
            if (cpi != null)
            {
                pPr = cpi.ParagraphProperties;
            }
            else
            {
                pPr = para.Element(W.pPr);
            }
            if (pPr != null)
            {
                pStyle = pPr.Element(W.pStyle);
                if (pStyle != null)
                {
                    paraStyle = (string)pStyle.Attribute(W.val);
                }
                else
                {
                    paraStyle = fai.DefaultParagraphStyleName;
                }
            }
            else
                paraStyle = fai.DefaultParagraphStyleName;

            string key = (paraStyle == null ? "[null]" : paraStyle) + "~|~" +
                (charStyle == null ? "[null]" : charStyle);
            XElement rolledRunProps = null;

            if (fai.RolledCharacterStyles.ContainsKey(key))
                rolledRunProps = fai.RolledCharacterStyles[key];
            else
            {
                XElement rolledUpCharStyleRunProps = new XElement(W.rPr);
                if (charStyle != null)
                {
                    rolledUpCharStyleRunProps =
                        CharStyleStack(wDoc, charStyle)
                            .Aggregate(new XElement(W.rPr),
                                (r, s) =>
                                {
                                    var newRunProps = MergeStyleElement(s, r);
                                    return newRunProps;
                                });
                }

                if (paraStyle != null)
                {
                    rolledUpParaStyleRunProps = ParaStyleRunPropsStack(wDoc, paraStyle)
                        .Aggregate(new XElement(W.rPr),
                            (r, s) =>
                            {
                                var newCharStyleRunProps = MergeStyleElement(s, r);
                                return newCharStyleRunProps;
                            });
                }
                rolledRunProps = MergeStyleElement(rolledUpCharStyleRunProps, rolledUpParaStyleRunProps);
                fai.RolledCharacterStyles.Add(key, rolledRunProps);
            }

            return rolledRunProps;
        }

        private static IEnumerable<XElement> ParaStyleRunPropsStack(WordprocessingDocument wDoc, string paraStyleName)
        {
            var localParaStyleName = paraStyleName;
            var sXDoc = wDoc.MainDocumentPart.StyleDefinitionsPart.GetXDocument();
            var rValue = new Stack<XElement>();
            while (localParaStyleName != null)
            {
                var paraStyle = sXDoc.Root.Elements(W.style).FirstOrDefault(s =>
                {
                    return (string)s.Attribute(W.type) == "paragraph" &&
                        (string)s.Attribute(W.styleId) == localParaStyleName;
                });
                if (paraStyle == null)
                {
                    return rValue;
                }
                if (paraStyle.Element(W.rPr) != null)
                {
                    rValue.Push(paraStyle.Element(W.rPr));
                }
                localParaStyleName = (string)paraStyle
                    .Elements(W.basedOn)
                    .Attributes(W.val)
                    .FirstOrDefault();
            }
            return rValue;
        }

        // returns collection of run properties
        private static IEnumerable<XElement> CharStyleStack(WordprocessingDocument wDoc, string charStyleName)
        {
            var localCharStyleName = charStyleName;
            var sXDoc = wDoc.MainDocumentPart.StyleDefinitionsPart.GetXDocument();
            var rValue = new Stack<XElement>();
            while (localCharStyleName != null)
            {
                XElement basedOn = null;
                // first look for character style
                var charStyle = sXDoc.Root.Elements(W.style).FirstOrDefault(s =>
                {
                    return (string)s.Attribute(W.type) == "character" &&
                        (string)s.Attribute(W.styleId) == localCharStyleName;
                });
                // if not found, look for paragraph style
                if (charStyle == null)
                {
                    charStyle = sXDoc.Root.Elements(W.style).FirstOrDefault(s =>
                    {
                        return (string)s.Attribute(W.styleId) == localCharStyleName;
                    });
                }
                if (charStyle == null)
                {
                    return rValue;
                }
                if (charStyle.Element(W.rPr) == null)
                {
                    basedOn = charStyle.Element(W.basedOn);
                    if (basedOn != null)
                    {
                        localCharStyleName = (string)basedOn.Attribute(W.val);
                    }
                    else
                    {
                        return rValue;
                    }
                }
                rValue.Push(charStyle.Element(W.rPr));
                localCharStyleName = null;
                basedOn = charStyle.Element(W.basedOn);
                if (basedOn != null)
                {
                    localCharStyleName = (string)basedOn.Attribute(W.val);
                }
            }
            return rValue;
        }

        private static XElement ToggleMergeRunProps(XElement higherPriorityElement, XElement lowerPriorityElement)
        {
            if (lowerPriorityElement == null)
                return higherPriorityElement;
            if (higherPriorityElement == null)
                return lowerPriorityElement;

            var hpe = higherPriorityElement.Elements().Select(e => e.Name).ToArray();

            var newMergedElement = new XElement(higherPriorityElement.Name,
                higherPriorityElement.Attributes(),

                // process toggle properties
                higherPriorityElement.Elements()
                    .Where(e => { return e.Name != W.rFonts; })
                    .Select(higherChildElement =>
                    {
                        if (TogglePropertyNames.Contains(higherChildElement.Name))
                        {
                            var lowerChildElement = lowerPriorityElement.Element(higherChildElement.Name);
                            if (lowerChildElement == null)
                            {
                                return higherChildElement;
                            }

                            var bHigher = higherChildElement.Attribute(W.val) == null || higherChildElement.Attribute(W.val).ToBoolean() == true;

                            var bLower = lowerChildElement.Attribute(W.val) == null || lowerChildElement.Attribute(W.val).ToBoolean() == true;

                            // if higher is true and lower is false, then return true element
                            if (bHigher && !bLower)
                            {
                                return higherChildElement;
                            }

                            // if higher is false and lower is true, then return false element
                            if (!bHigher && bLower)
                            {
                                return higherChildElement;
                            }

                            // if higher and lower are both true, then return false
                            if (bHigher && bLower)
                            {
                                return new XElement(higherChildElement.Name,
                                    new XAttribute(W.val, "0"));
                            }

                            // otherwise, both higher and lower are false so can return higher element.
                            return higherChildElement;
                        }
                        return higherChildElement;
                    }),

                    FontMerge(higherPriorityElement.Element(W.rFonts), lowerPriorityElement.Element(W.rFonts)),

                    // take lower priority elements where there is not a higher priority element of same name
                    lowerPriorityElement.Elements()
                        .Where(e =>
                        {
                            return e.Name != W.rFonts && !hpe.Contains(e.Name);
                        }));

            return newMergedElement;
        }

        private static XName[] TogglePropertyNames = new[] {
            W.b,
            W.bCs,
            W.caps,
            W.emboss,
            W.i,
            W.iCs,
            W.imprint,
            W.outline,
            W.shadow,
            W.smallCaps,
            W.strike,
            W.vanish
        };

        private static XName[] PropertyNames = new[] {
            W.cs,
            W.rtl,
            W.u,
            W.color,
            W.highlight,
            W.shd
        };

        public class CharStyleAttributes
        {
            public string AsciiFont;
            public string HAnsiFont;
            public string EastAsiaFont;
            public string CsFont;
            public string Hint;
            public bool Rtl;

            public string LatinLang;
            public string BidiLang;
            public string EastAsiaLang;

            public Dictionary<XName, bool?> ToggleProperties;
            public Dictionary<XName, XElement> Properties;

            public CharStyleAttributes(XElement pPr, XElement rPr)
            {
                ToggleProperties = new Dictionary<XName, bool?>();
                Properties = new Dictionary<XName, XElement>();

                if (rPr == null)
                    return;
                foreach (XName xn in TogglePropertyNames)
                {
                    ToggleProperties[xn] = GetBoolProperty(rPr, xn);
                }
                foreach (XName xn in PropertyNames)
                {
                    Properties[xn] = GetXmlProperty(rPr, xn);
                }
                var rFonts = rPr.Element(W.rFonts);
                if (rFonts == null)
                {
                    this.AsciiFont = null;
                    this.HAnsiFont = null;
                    this.EastAsiaFont = null;
                    this.CsFont = null;
                    this.Hint = null;
                }
                else
                {
                    this.AsciiFont = (string)(rFonts.Attribute(W.ascii));
                    this.HAnsiFont = (string)(rFonts.Attribute(W.hAnsi));
                    this.EastAsiaFont = (string)(rFonts.Attribute(W.eastAsia));
                    this.CsFont = (string)(rFonts.Attribute(W.cs));
                    this.Hint = (string)(rFonts.Attribute(W.hint));
                }
                XElement csel = this.Properties[W.cs];
                bool cs = csel != null && (csel.Attribute(W.val) == null || csel.Attribute(W.val).ToBoolean() == true);
                XElement rtlel = this.Properties[W.rtl];
                bool rtl = rtlel != null && (rtlel.Attribute(W.val) == null || rtlel.Attribute(W.val).ToBoolean() == true);
                var bidi = false;
                if (pPr != null)
                {
                    XElement bidiel = pPr.Element(W.bidi);
                    bidi = bidiel != null && (bidiel.Attribute(W.val) == null || bidiel.Attribute(W.val).ToBoolean() == true);
                }
                Rtl = cs || rtl || bidi;
                var lang = rPr.Element(W.lang);
                if (lang != null)
                {
                    LatinLang = (string)lang.Attribute(W.val);
                    BidiLang = (string)lang.Attribute(W.bidi);
                    EastAsiaLang = (string)lang.Attribute(W.eastAsia);
                }
            }

            private static bool? GetBoolProperty(XElement rPr, XName propertyName)
            {
                if (rPr.Element(propertyName) == null)
                    return null;
                var s = (string)rPr.Element(propertyName).Attribute(W.val);
                if (s == null)
                    return true;
                if (s == "1")
                    return true;
                if (s == "0")
                    return false;
                if (s == "true")
                    return true;
                if (s == "false")
                    return false;
                if (s == "on")
                    return true;
                if (s == "off")
                    return false;
                return (bool)(rPr.Element(propertyName).Attribute(W.val));
            }

            private static XElement GetXmlProperty(XElement rPr, XName propertyName)
            {
                return rPr.Element(propertyName);
            }

            private static XName[] TogglePropertyNames = new[] {
                W.b,
                W.bCs,
                W.caps,
                W.emboss,
                W.i,
                W.iCs,
                W.imprint,
                W.outline,
                W.shadow,
                W.smallCaps,
                W.strike,
                W.vanish
            };

            private static XName[] PropertyNames = new[] {
                W.cs,
                W.rtl,
                W.u,
                W.color,
                W.highlight,
                W.shd
            };

        }

        private static HashSet<char> WeakAndNeutralDirectionalCharacters = new HashSet<char>() {
            '0',
            '1',
            '2',
            '3',
            '4',
            '5',
            '6',
            '7',
            '8',
            '9',
            '+',
            '-',
            ':',
            ',',
            '.',
            '|',
            '\t',
            '\r',
            '\n',
            ' ',
            '\x00A0', // non breaking space

            '\x00B0', // degree sign
            '\x066B', // arabic decimal separator
            '\x066C', // arabic thousands separator

            '\x0627', // arabic pipe 

            '\x20A0', // start currency symbols
            '\x20A1',
            '\x20A2',
            '\x20A3',
            '\x20A4',
            '\x20A5',
            '\x20A6',
            '\x20A7',
            '\x20A8',
            '\x20A9',
            '\x20AA',
            '\x20AB',
            '\x20AC',
            '\x20AD',
            '\x20AE',
            '\x20AF',
            '\x20B0',
            '\x20B1',
            '\x20B2',
            '\x20B3',
            '\x20B4',
            '\x20B5',
            '\x20B6',
            '\x20B7',
            '\x20B8',
            '\x20B9',
            '\x20BA',
            '\x20BB',
            '\x20BC',
            '\x20BD',
            '\x20BE',
            '\x20BF',
            '\x20C0',
            '\x20C1',
            '\x20C2',
            '\x20C3',
            '\x20C4',
            '\x20C5',
            '\x20C6',
            '\x20C7',
            '\x20C8',
            '\x20C9',
            '\x20CA',
            '\x20CB',
            '\x20CC',
            '\x20CD',
            '\x20CE',
            '\x20CF',  // end currency symbols

            '\x0660', // "Arabic" Indic Numeral Forms Iraq and West
            '\x0661',
            '\x0662',
            '\x0663',
            '\x0664',
            '\x0665',
            '\x0666',
            '\x0667',
            '\x0668',
            '\x0669',

            '\x06F0', // "Arabic" Indic Numberal Forms Iran and East
            '\x06F1',
            '\x06F2',
            '\x06F3',
            '\x06F4',
            '\x06F5',
            '\x06F6',
            '\x06F7',
            '\x06F8',
            '\x06F9',
        };

        private static void AdjustFontAttributes(WordprocessingDocument wDoc, XElement paraOrRun, XElement pPr,
            XElement rPr, FormattingAssemblerSettings settings)
        {
            XDocument themeXDoc = null;
            if (wDoc.MainDocumentPart.ThemePart != null)
                themeXDoc = wDoc.MainDocumentPart.ThemePart.GetXDocument();

            XElement fontScheme = null;
            XElement majorFont = null;
            XElement minorFont = null;
            if (themeXDoc != null)
            {
                fontScheme = themeXDoc.Root.Element(A.themeElements).Element(A.fontScheme);
                majorFont = fontScheme.Element(A.majorFont);
                minorFont = fontScheme.Element(A.minorFont);
            }
            var rFonts = rPr.Element(W.rFonts);
            if (rFonts == null)
            {
                return;
            }
            var asciiTheme = (string)rFonts.Attribute(W.asciiTheme);
            var hAnsiTheme = (string)rFonts.Attribute(W.hAnsiTheme);
            var eastAsiaTheme = (string)rFonts.Attribute(W.eastAsiaTheme);
            var cstheme = (string)rFonts.Attribute(W.cstheme);
            string ascii = null;
            string hAnsi = null;
            string eastAsia = null;
            string cs = null;

            XElement minorLatin = null;
            string minorLatinTypeface = null;
            XElement majorLatin = null;
            string majorLatinTypeface = null;

            if (minorFont != null)
            {
                minorLatin = minorFont.Element(A.latin);
                minorLatinTypeface = (string)minorLatin.Attribute("typeface");
            }

            if (majorFont != null)
            {
                majorLatin = majorFont.Element(A.latin);
                majorLatinTypeface = (string)majorLatin.Attribute("typeface");
            }
            if (asciiTheme != null)
            {
                if (asciiTheme.StartsWith("minor") && minorLatinTypeface != null)
                {
                    ascii = minorLatinTypeface;
                }
                else if (asciiTheme.StartsWith("major") && majorLatinTypeface != null)
                {
                    ascii = majorLatinTypeface;
                }
            }
            if (hAnsiTheme != null)
            {
                if (hAnsiTheme.StartsWith("minor") && minorLatinTypeface != null)
                {
                    hAnsi = minorLatinTypeface;
                }
                else if (hAnsiTheme.StartsWith("major") && majorLatinTypeface != null)
                {
                    hAnsi = majorLatinTypeface;
                }
            }
            if (eastAsiaTheme != null)
            {
                if (eastAsiaTheme.StartsWith("minor") && minorLatinTypeface != null)
                {
                    eastAsia = minorLatinTypeface;
                }
                else if (eastAsiaTheme.StartsWith("major") && majorLatinTypeface != null)
                {
                    eastAsia = majorLatinTypeface;
                }
            }
            if (cstheme != null)
            {
                if (cstheme.StartsWith("minor") && minorFont != null)
                {
                    cs = (string)minorFont.Element(A.cs).Attribute("typeface");
                }
                else if (cstheme.StartsWith("major") && majorFont != null)
                {
                    cs = (string)majorFont.Element(A.cs).Attribute("typeface");
                }
            }

            if (ascii != null)
            {
                rFonts.SetAttributeValue(W.ascii, ascii);
            }
            if (hAnsi != null)
            {
                rFonts.SetAttributeValue(W.hAnsi, hAnsi);
            }
            if (eastAsia != null)
            {
                rFonts.SetAttributeValue(W.eastAsia, eastAsia);
            }
            if (cs != null)
            {
                rFonts.SetAttributeValue(W.cs, cs);
            }

            var firstTextNode = paraOrRun.Descendants(W.t).FirstOrDefault(t => t.Value.Length > 0);
            string str = " ";

            // if there is a run with no text in it, then no need to do any of the rest of this method.
            if (firstTextNode == null && paraOrRun.Name == W.r)
                return;

            if (firstTextNode != null)
                str = firstTextNode.Value;

            var csa = new CharStyleAttributes(pPr, rPr);

            // This module determines the font based on just the first character.
            // Technically, a run can contain characters from different Unicode code blocks, and hence should be rendered with different fonts.
            // However, Word breaks up runs that use more than one font into multiple runs.  Other producers of WordprocessingML may not, so in
            // that case, this routine may need to be augmented to look at all characters in a run.

            /*
            old code
            var fontFamilies = str.select(function (c) {
                var ft = Pav.DetermineFontTypeFromCharacter(c, csa);
                switch (ft) {
                    case Pav.FontType.Ascii:
                        return cast(rFonts.attribute(W.ascii));
                    case Pav.FontType.HAnsi:
                        return cast(rFonts.attribute(W.hAnsi));
                    case Pav.FontType.EastAsia:
                        return cast(rFonts.attribute(W.eastAsia));
                    case Pav.FontType.CS:
                        return cast(rFonts.attribute(W.cs));
                    default:
                        return null;
                }
            })
                .where(function (f) { return f != null && f != ""; })
                .distinct()
                .select(function (f) { return new Pav.FontFamily(f); })
                .toArray();
            */

            var charToExamine = str.FirstOrDefault(c => ! WeakAndNeutralDirectionalCharacters.Contains(c));
            if (charToExamine == '\0')
                charToExamine = str[0];

            var ft = DetermineFontTypeFromCharacter(charToExamine, csa);
            string fontType = null;
            string languageType = null;
            switch (ft)
            {
                case FontType.Ascii:
                    fontType = (string)rFonts.Attribute(W.ascii);
                    languageType = "western";
                    break;
                case FontType.HAnsi:
                    fontType = (string)rFonts.Attribute(W.hAnsi);
                    languageType = "western";
                    break;
                case FontType.EastAsia:
                    if (settings.RestrictToSupportedLanguages)
                        throw new UnsupportedLanguageException("EastAsia languages are not supported");
                    fontType = (string)rFonts.Attribute(W.eastAsia);
                    languageType = "eastAsia";
                    break;
                case FontType.CS:
                    if (settings.RestrictToSupportedLanguages)
                        throw new UnsupportedLanguageException("Complex script (RTL) languages are not supported");
                    fontType = (string)rFonts.Attribute(W.cs);
                    languageType = "bidi";
                    break;
            }

            if (fontType != null)
            {
                if (paraOrRun.Attribute(PtOpenXml.FontName) == null)
                {
                    XAttribute fta = new XAttribute(PtOpenXml.FontName, fontType.ToString());
                    paraOrRun.Add(fta);
                }
                else
                {
                    paraOrRun.Attribute(PtOpenXml.FontName).Value = fontType.ToString();
                }
            }
            if (languageType != null)
            {
                if (paraOrRun.Attribute(PtOpenXml.LanguageType) == null)
                {
                    XAttribute lta = new XAttribute(PtOpenXml.LanguageType, languageType);
                    paraOrRun.Add(lta);
                }
                else
                {
                    paraOrRun.Attribute(PtOpenXml.LanguageType).Value = languageType;
                }
            }
        }

        public enum FontType
        {
            Ascii,
            HAnsi,
            EastAsia,
            CS
        };

        // The algorithm for this method comes from the implementer notes in [MS-OI29500].pdf
        // section 2.1.87

        // The implementer notes are at:
        // http://msdn.microsoft.com/en-us/library/ee908652.aspx

        public static FontType DetermineFontTypeFromCharacter(char ch, CharStyleAttributes csa)
        {
            // If the run has the cs element ("[ISO/IEC-29500-1] §17.3.2.7; cs") or the rtl element ("[ISO/IEC-29500-1] §17.3.2.30; rtl"),
            // then the cs (or cstheme if defined) font is used, regardless of the Unicode character values of the run’s content.
            if (csa.Rtl)
            {
                return FontType.CS;
            }

            // A large percentage of characters will fall in the following rule.

            // Unicode Block: Basic Latin
            if (ch >= 0x00 && ch <= 0x7f)
            {
                return FontType.Ascii;
            }

            // If the eastAsia (or eastAsiaTheme if defined) attribute’s value is “Times New Roman” and the ascii (or asciiTheme if defined)
            // and hAnsi (or hAnsiTheme if defined) attributes are equal, then the ascii (or asciiTheme if defined) font is used.
            if (csa.EastAsiaFont == "Times New Roman" &&
                csa.AsciiFont == csa.HAnsiFont)
            {
                return FontType.Ascii;
            }

            // Unicode BLock: Latin-1 Supplement
            if (ch >= 0xA0 && ch <= 0xFF)
            {
                if (csa.Hint == "eastAsia")
                {
                    if (ch == 0xA1 ||
                        ch == 0xA4 ||
                        ch == 0xA7 ||
                        ch == 0xA8 ||
                        ch == 0xAA ||
                        ch == 0xAD ||
                        ch == 0xAF ||
                        (ch >= 0xB0 && ch <= 0xB4) ||
                        (ch >= 0xB6 && ch <= 0xBA) ||
                        (ch >= 0xBC && ch <= 0xBF) ||
                        ch == 0xD7 ||
                        ch == 0xF7)
                    {
                        return FontType.EastAsia;
                    }
                    if (csa.EastAsiaLang == "zh-hant" ||
                        csa.EastAsiaLang == "zh-hans")
                    {
                        if (ch == 0xE0 ||
                            ch == 0xE1 ||
                            (ch >= 0xE8 && ch <= 0xEA) ||
                            (ch >= 0xEC && ch <= 0xED) ||
                            (ch >= 0xF2 && ch <= 0xF3) ||
                            (ch >= 0xF9 && ch <= 0xFA) ||
                            ch == 0xFC)
                        {
                            return FontType.EastAsia;
                        }
                    }
                }
                return FontType.HAnsi;
            }

            // Unicode Block: Latin Extended-A
            if (ch >= 0x0100 && ch <= 0x017F)
            {
                if (csa.Hint == "eastAsia")
                {
                    if (csa.EastAsiaLang == "zh-hant" ||
                        csa.EastAsiaLang == "zh-hans"
                        /* || the character set of the east Asia (or east Asia theme) font is Chinese5 || GB2312 todo */)
                    {
                        return FontType.EastAsia;
                    }
                }
                return FontType.HAnsi;
            }

            // Unicode Block: Latin Extended-B
            if (ch >= 0x0180 && ch <= 0x024F)
            {
                if (csa.Hint == "eastAsia")
                {
                    if (csa.EastAsiaLang == "zh-hant" ||
                        csa.EastAsiaLang == "zh-hans"
                        /* || the character set of the east Asia (or east Asia theme) font is Chinese5 || GB2312 todo */)
                    {
                        return FontType.EastAsia;
                    }
                }
                return FontType.HAnsi;
            }

            // Unicode Block: IPA Extensions
            if (ch >= 0x0250 && ch <= 0x02AF)
            {
                if (csa.Hint == "eastAsia")
                {
                    if (csa.EastAsiaLang == "zh-hant" ||
                        csa.EastAsiaLang == "zh-hans"
                        /* || the character set of the east Asia (or east Asia theme) font is Chinese5 || GB2312 todo */)
                    {
                        return FontType.EastAsia;
                    }
                }
                return FontType.HAnsi;
            }

            // Unicode Block: Spacing Modifier Letters
            if (ch >= 0x02B0 && ch <= 0x02FF)
            {
                if (csa.Hint == "eastAsia")
                {
                    return FontType.EastAsia;
                }
                return FontType.HAnsi;
            }

            // Unicode Block: Combining Diacritic Marks
            if (ch >= 0x0300 && ch <= 0x036F)
            {
                if (csa.Hint == "eastAsia")
                {
                    return FontType.EastAsia;
                }
                return FontType.HAnsi;
            }

            // Unicode Block: Greek
            if (ch >= 0x0370 && ch <= 0x03CF)
            {
                if (csa.Hint == "eastAsia")
                {
                    return FontType.EastAsia;
                }
                return FontType.HAnsi;
            }

            // Unicode Block: Cyrillic
            if (ch >= 0x0400 && ch <= 0x04FF)
            {
                if (csa.Hint == "eastAsia")
                {
                    return FontType.EastAsia;
                }
                return FontType.HAnsi;
            }

            // Unicode Block: Hebrew
            if (ch >= 0x0590 && ch <= 0x05FF)
            {
                return FontType.Ascii;
            }

            // Unicode Block: Arabic
            if (ch >= 0x0600 && ch <= 0x06FF)
            {
                return FontType.Ascii;
            }

            // Unicode Block: Syriac
            if (ch >= 0x0700 && ch <= 0x074F)
            {
                return FontType.Ascii;
            }

            // Unicode Block: Arabic Supplement
            if (ch >= 0x0750 && ch <= 0x077F)
            {
                return FontType.Ascii;
            }

            // Unicode Block: Thanna
            if (ch >= 0x0780 && ch <= 0x07BF)
            {
                return FontType.Ascii;
            }

            // Unicode Block: Hangul Jamo
            if (ch >= 0x1100 && ch <= 0x11FF)
            {
                return FontType.EastAsia;
            }

            // Unicode Block: Latin Extended Additional
            if (ch >= 0x1E00 && ch <= 0x1EFF)
            {
                if (csa.Hint == "eastAsia" &&
                    (csa.EastAsiaLang == "zh-hant" ||
                    csa.EastAsiaLang == "zh-hans"))
                {
                    return FontType.EastAsia;
                }
                return FontType.HAnsi;
            }

            // Unicode Block: General Punctuation
            if (ch >= 0x2000 && ch <= 0x206F)
            {
                if (csa.Hint == "eastAsia")
                {
                    return FontType.EastAsia;
                }
                return FontType.HAnsi;
            }

            // Unicode Block: Superscripts and Subscripts
            if (ch >= 0x2070 && ch <= 0x209F)
            {
                if (csa.Hint == "eastAsia")
                {
                    return FontType.EastAsia;
                }
                return FontType.HAnsi;
            }

            // Unicode Block: Currency Symbols
            if (ch >= 0x20A0 && ch <= 0x20CF)
            {
                if (csa.Hint == "eastAsia")
                {
                    return FontType.EastAsia;
                }
                return FontType.HAnsi;
            }

            // Unicode Block: Combining Diacritical Marks for Symbols
            if (ch >= 0x20D0 && ch <= 0x20FF)
            {
                if (csa.Hint == "eastAsia")
                {
                    return FontType.EastAsia;
                }
                return FontType.HAnsi;
            }

            // Unicode Block: Letter-like Symbols
            if (ch >= 0x2100 && ch <= 0x214F)
            {
                if (csa.Hint == "eastAsia")
                {
                    return FontType.EastAsia;
                }
                return FontType.HAnsi;
            }

            // Unicode Block: Number Forms
            if (ch >= 0x2150 && ch <= 0x218F)
            {
                if (csa.Hint == "eastAsia")
                {
                    return FontType.EastAsia;
                }
                return FontType.HAnsi;
            }

            // Unicode Block: Arrows
            if (ch >= 0x2190 && ch <= 0x21FF)
            {
                if (csa.Hint == "eastAsia")
                {
                    return FontType.EastAsia;
                }
                return FontType.HAnsi;
            }

            // Unicode Block: Mathematical Operators
            if (ch >= 0x2200 && ch <= 0x22FF)
            {
                if (csa.Hint == "eastAsia")
                {
                    return FontType.EastAsia;
                }
                return FontType.HAnsi;
            }

            // Unicode Block: Miscellaneous Technical
            if (ch >= 0x2300 && ch <= 0x23FF)
            {
                if (csa.Hint == "eastAsia")
                {
                    return FontType.EastAsia;
                }
                return FontType.HAnsi;
            }

            // Unicode Block: Control Pictures
            if (ch >= 0x2400 && ch <= 0x243F)
            {
                if (csa.Hint == "eastAsia")
                {
                    return FontType.EastAsia;
                }
                return FontType.HAnsi;
            }

            // Unicode Block: Optical Character Recognition
            if (ch >= 0x2440 && ch <= 0x245F)
            {
                if (csa.Hint == "eastAsia")
                {
                    return FontType.EastAsia;
                }
                return FontType.HAnsi;
            }

            // Unicode Block: Enclosed Alphanumerics
            if (ch >= 0x2460 && ch <= 0x24FF)
            {
                if (csa.Hint == "eastAsia")
                {
                    return FontType.EastAsia;
                }
                return FontType.HAnsi;
            }

            // Unicode Block: Box Drawing
            if (ch >= 0x2500 && ch <= 0x257F)
            {
                if (csa.Hint == "eastAsia")
                {
                    return FontType.EastAsia;
                }
                return FontType.HAnsi;
            }

            // Unicode Block: Block Elements
            if (ch >= 0x2580 && ch <= 0x259F)
            {
                if (csa.Hint == "eastAsia")
                {
                    return FontType.EastAsia;
                }
                return FontType.HAnsi;
            }

            // Unicode Block: Geometric Shapes
            if (ch >= 0x25A0 && ch <= 0x25FF)
            {
                if (csa.Hint == "eastAsia")
                {
                    return FontType.EastAsia;
                }
                return FontType.HAnsi;
            }

            // Unicode Block: Miscellaneous Symbols
            if (ch >= 0x2600 && ch <= 0x26FF)
            {
                if (csa.Hint == "eastAsia")
                {
                    return FontType.EastAsia;
                }
                return FontType.HAnsi;
            }

            // Unicode Block: Dingbats
            if (ch >= 0x2700 && ch <= 0x27BF)
            {
                if (csa.Hint == "eastAsia")
                {
                    return FontType.EastAsia;
                }
                return FontType.HAnsi;
            }

            // Unicode Block: CJK Radicals Supplement
            if (ch >= 0x2E80 && ch <= 0x2EFF)
            {
                if (csa.Hint == "eastAsia")
                {
                    return FontType.EastAsia;
                }
                return FontType.HAnsi;
            }

            // Unicode Block: Kangxi Radicals
            if (ch >= 0x2F00 && ch <= 0x2FDF)
            {
                return FontType.EastAsia;
            }

            // Unicode Block: Ideographic Description Characters
            if (ch >= 0x2FF0 && ch <= 0x2FFF)
            {
                return FontType.EastAsia;
            }

            // Unicode Block: CJK Symbols and Punctuation
            if (ch >= 0x3000 && ch <= 0x303F)
            {
                return FontType.EastAsia;
            }

            // Unicode Block: Hiragana
            if (ch >= 0x3040 && ch <= 0x309F)
            {
                return FontType.EastAsia;
            }

            // Unicode Block: Katakana
            if (ch >= 0x30A0 && ch <= 0x30FF)
            {
                return FontType.EastAsia;
            }

            // Unicode Block: Bopomofo
            if (ch >= 0x3100 && ch <= 0x312F)
            {
                return FontType.EastAsia;
            }

            // Unicode Block: Hangul Compatibility Jamo
            if (ch >= 0x3130 && ch <= 0x318F)
            {
                return FontType.EastAsia;
            }

            // Unicode Block: Kanbun
            if (ch >= 0x3190 && ch <= 0x319F)
            {
                return FontType.EastAsia;
            }

            // Unicode Block: Enclosed CJK Letters and Months
            if (ch >= 0x3200 && ch <= 0x32FF)
            {
                return FontType.EastAsia;
            }

            // Unicode Block: CJK Compatibility
            if (ch >= 0x3300 && ch <= 0x33FF)
            {
                return FontType.EastAsia;
            }

            // Unicode Block: CJK Unified Ideographs Extension A
            if (ch >= 0x3400 && ch <= 0x4DBF)
            {
                return FontType.EastAsia;
            }

            // Unicode Block: CJK Unified Ideographs
            if (ch >= 0x4E00 && ch <= 0x9FAF)
            {
                return FontType.EastAsia;
            }

            // Unicode Block: Yi Syllables
            if (ch >= 0xA000 && ch <= 0xA48F)
            {
                return FontType.EastAsia;
            }

            // Unicode Block: Yi Radicals
            if (ch >= 0xA490 && ch <= 0xA4CF)
            {
                return FontType.EastAsia;
            }

            // Unicode Block: Hangul Syllables
            if (ch >= 0xAC00 && ch <= 0xD7AF)
            {
                return FontType.EastAsia;
            }

            // Unicode Block: High Surrogates
            if (ch >= 0xD800 && ch <= 0xDB7F)
            {
                return FontType.EastAsia;
            }

            // Unicode Block: High Private Use Surrogates
            if (ch >= 0xDB80 && ch <= 0xDBFF)
            {
                return FontType.EastAsia;
            }

            // Unicode Block: Low Surrogates
            if (ch >= 0xDC00 && ch <= 0xDFFF)
            {
                return FontType.EastAsia;
            }

            // Unicode Block: Private Use Area
            if (ch >= 0xE000 && ch <= 0xF8FF)
            {
                if (csa.Hint == "eastAsia")
                {
                    return FontType.EastAsia;
                }
                return FontType.HAnsi;
            }

            // Unicode Block: CJK Compatibility Ideographs
            if (ch >= 0xF900 && ch <= 0xFAFF)
            {
                return FontType.EastAsia;
            }

            // Unicode Block: Alphabetic Presentation Forms
            if (ch >= 0xFB00 && ch <= 0xFB4F)
            {
                if (csa.Hint == "eastAsia")
                {
                    if (ch >= 0xFB00 && ch <= 0xFB1C)
                        return FontType.EastAsia;
                    if (ch >= 0xFB1D && ch <= 0xFB4F)
                        return FontType.Ascii;
                }
                return FontType.HAnsi;
            }

            // Unicode Block: Arabic Presentation Forms-A
            if (ch >= 0xFB50 && ch <= 0xFDFF)
            {
                return FontType.Ascii;
            }

            // Unicode Block: CJK Compatibility Forms
            if (ch >= 0xFE30 && ch <= 0xFE4F)
            {
                return FontType.EastAsia;
            }

            // Unicode Block: Small Form Variants
            if (ch >= 0xFE50 && ch <= 0xFE6F)
            {
                return FontType.EastAsia;
            }

            // Unicode Block: Arabic Presentation Forms-B
            if (ch >= 0xFE70 && ch <= 0xFEFE)
            {
                return FontType.Ascii;
            }

            // Unicode Block: Halfwidth and Fullwidth Forms
            if (ch >= 0xFF00 && ch <= 0xFFEF)
            {
                return FontType.EastAsia;
            }
            return FontType.HAnsi;
        }

        private class FormattingAssemblerInfo
        {
            public string DefaultParagraphStyleName;
            public string DefaultCharacterStyleName;
            public string DefaultTableStyleName;
            public Dictionary<string, XElement> RolledCharacterStyles;
            public FormattingAssemblerInfo()
            {
                RolledCharacterStyles = new Dictionary<string, XElement>();
            }
        }

        // CachedParaInfo is an optimization for the case where a paragraph contains thousands of runs.
        private class CachedParaInfo
        {
            public string ParagraphStyleName;
            public XElement ParagraphProperties;
        }

        public class UnsupportedNumberingFormatException : Exception
        {
            public UnsupportedNumberingFormatException(string message) : base(message) { }
        }

        public class UnsupportedLanguageException : Exception
        {
            public UnsupportedLanguageException(string message) : base(message) { }
        }
    }
}
