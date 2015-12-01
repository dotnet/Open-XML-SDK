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

Version: 2.7.00
 * Complete re-write - new architecture enables much more accurate rendering of list items.

Version: 2.6.03
 * Fixed: Empty paragraphs were not counted properly
 * Fixed: Numbered styles were not processed properly if they derived from another style
 * Now has a dependency on FormattingAssembler.cs

Version: 2.6.00
 * Enhancements to support HtmlConverter.cs

Relevant Screen-Casts
 * https://www.youtube.com/watch?v=w9h1VQ3eR_Q

***************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using DocumentFormat.OpenXml.Packaging;

namespace OpenXmlPowerTools
{
    public class ListItemRetrieverSettings
    {
        public static Dictionary<string, Func<string, int, string, string>> DefaultListItemTextImplementations =
            new Dictionary<string, Func<string, int, string, string>>()
            {
                {"fr-FR", ListItemTextGetter_fr_FR.GetListItemText},
                {"tr-TR", ListItemTextGetter_tr_TR.GetListItemText},
                {"ru-RU", ListItemTextGetter_ru_RU.GetListItemText}, 
                {"sv-SE", ListItemTextGetter_sv_SE.GetListItemText},
                {"zh-CN", ListItemTextGetter_zh_CN.GetListItemText},
            };
        public Dictionary<string, Func<string, int, string, string>> ListItemTextImplementations;
        public ListItemRetrieverSettings()
        {
            ListItemTextImplementations = DefaultListItemTextImplementations;
        }
    }

    public class ListItemRetriever
    {
        public class ListItemSourceSet
        {
            public int NumId;                          // numId from the paragraph or style
            public XElement Num;                       // num element from the numbering part
            public int AbstractNumId;                  // abstract numId
            public XElement AbstractNum;               // abstractNum element

            public ListItemSourceSet(XDocument numXDoc, XDocument styleXDoc, int numId)
            {
                NumId = numId;

                Num = numXDoc
                    .Root
                    .Elements(W.num)
                    .FirstOrDefault(n => (int)n.Attribute(W.numId) == numId);

                AbstractNumId = (int)Num
                    .Elements(W.abstractNumId)
                    .Attributes(W.val)
                    .FirstOrDefault();

                AbstractNum = numXDoc
                    .Root
                    .Elements(W.abstractNum)
                    .Where(e => (int)e.Attribute(W.abstractNumId) == AbstractNumId)
                    .FirstOrDefault();
            }

            public int? StartOverride(int ilvl)
            {
                var lvlOverride = Num
                    .Elements(W.lvlOverride)
                    .FirstOrDefault(nlo => (int)nlo.Attribute(W.ilvl) == ilvl);
                if (lvlOverride != null)
                    return (int?)lvlOverride
                        .Elements(W.startOverride)
                        .Attributes(W.val)
                        .FirstOrDefault();
                return null;
            }

            public XElement OverrideLvl(int ilvl)
            {
                var lvlOverride = Num
                    .Elements(W.lvlOverride)
                    .FirstOrDefault(nlo => (int)nlo.Attribute(W.ilvl) == ilvl);
                if (lvlOverride != null)
                    return lvlOverride.Element(W.lvl);
                return null;
            }

            public XElement AbstractLvl(int ilvl)
            {
                return AbstractNum
                    .Elements(W.lvl)
                    .FirstOrDefault(al => (int)al.Attribute(W.ilvl) == ilvl);
            }

            public XElement Lvl(int ilvl)
            {
                var overrideLvl = OverrideLvl(ilvl);
                if (overrideLvl != null)
                    return overrideLvl;
                return AbstractLvl(ilvl);
            }
        }

        public class ListItemSource
        {
            public ListItemSourceSet Main;
            public string NumStyleLinkName;
            public ListItemSourceSet NumStyleLink;
            public int Style_ilvl;

            // for list item sources that use numStyleLink, there are two abstractId values.
            // The abstractId that is use is in num->abstractNum->numStyleLink->style->num->abstractNum

            public ListItemSource(XDocument numXDoc, XDocument stylesXDoc, int numId)
            {
                Main = new ListItemSourceSet(numXDoc, stylesXDoc, numId);

                NumStyleLinkName = (string)Main
                    .AbstractNum
                    .Elements(W.numStyleLink)
                    .Attributes(W.val)
                    .FirstOrDefault();

                if (NumStyleLinkName != null)
                {
                    var numStyleLinkNumId = (int?)stylesXDoc
                        .Root
                        .Elements(W.style)
                        .Where(s => (string)s.Attribute(W.styleId) == NumStyleLinkName)
                        .Elements(W.pPr)
                        .Elements(W.numPr)
                        .Elements(W.numId)
                        .Attributes(W.val)
                        .FirstOrDefault();

                    if (numStyleLinkNumId != null)
                        NumStyleLink = new ListItemSourceSet(numXDoc, stylesXDoc, (int)numStyleLinkNumId);
                }
            }

            public XElement Lvl(int ilvl)
            {
                if (NumStyleLink != null)
                {
                    var lvl = NumStyleLink.Lvl(ilvl);
                    if (lvl == null)
                    {
                        for (int i = ilvl - 1; i >= 0; i--)
                        {
                            lvl = NumStyleLink.Lvl(i);
                            if (lvl != null)
                                break;
                        }
                    }
                    return lvl;
                }
                var lvl2 = Main.Lvl(ilvl);
                if (lvl2 == null)
                {
                    for (int i = ilvl - 1; i >= 0; i--)
                    {
                        lvl2 = Main.Lvl(i);
                        if (lvl2 != null)
                            break;
                    }
                }
                return lvl2;
            }

            public int? StartOverride(int ilvl)
            {
                if (NumStyleLink != null)
                {
                    var startOverride = NumStyleLink.StartOverride(ilvl);
                    if (startOverride != null)
                        return startOverride;
                }
                return Main.StartOverride(ilvl);
            }

            public int Start(int ilvl)
            {
                var lvl = Lvl(ilvl);
                var start = (int?)lvl.Elements(W.start).Attributes(W.val).FirstOrDefault();
                if (start != null)
                    return (int)start;
                return 0;
            }

            public int AbstractNumId
            {
                get
                {
                    return Main.AbstractNumId;
                }
            }
        }

        public class ListItemInfo
        {
            public bool IsListItem;
            public bool IsZeroNumId;

            public ListItemSource FromStyle;
            public ListItemSource FromParagraph;

            private int? mAbstractNumId = null;

            public int? AbstractNumId
            {
                get
                {
                    // note: this property does not get NumStyleLinkAbstractNumId
                    // it presumes that we are only interested in AbstractNumId
                    // however, it is easy enough to change if necessary

                    if (mAbstractNumId != null)
                        return mAbstractNumId;
                    if (FromParagraph != null)
                        mAbstractNumId = FromParagraph.AbstractNumId;
                    else if (FromStyle != null)
                        mAbstractNumId = FromStyle.AbstractNumId;
                    return mAbstractNumId;
                }
            }

            public XElement Lvl(int ilvl)
            {
                if (FromParagraph != null)
                {
                    var lvl = FromParagraph.Lvl(ilvl);
                    if (lvl == null)
                    {
                        for (int i = ilvl - 1; i >= 0; i--)
                        {
                            lvl = FromParagraph.Lvl(i);
                            if (lvl != null)
                                break;
                        }
                    }
                    return lvl;
                }
                var lvl2 = FromStyle.Lvl(ilvl);
                if (lvl2 == null)
                {
                    for (int i = ilvl - 1; i >= 0; i--)
                    {
                        lvl2 = FromParagraph.Lvl(i);
                        if (lvl2 != null)
                            break;
                    }
                }
                return lvl2;
            }

            public int Start(int ilvl)
            {
                if (FromParagraph != null)
                    return FromParagraph.Start(ilvl);
                return FromStyle.Start(ilvl);
            }

            public int Start(int ilvl, bool takeOverride, out bool isOverride)
            {
                if (FromParagraph != null)
                {
                    if (takeOverride)
                    {
                        var startOverride = FromParagraph.StartOverride(ilvl);
                        if (startOverride != null)
                        {
                            isOverride = true;
                            return (int)startOverride;
                        }
                    }
                    isOverride = false;
                    return FromParagraph.Start(ilvl);
                }
                else if (this.FromStyle != null)
                {
                    if (takeOverride)
                    {
                        var startOverride = FromStyle.StartOverride(ilvl);
                        if (startOverride != null)
                        {
                            isOverride = true;
                            return (int)startOverride;
                        }
                    }
                    isOverride = false;
                    return FromStyle.Start(ilvl);
                }
                isOverride = false;
                return 0;
            }

            public int? StartOverride(int ilvl)
            {
                if (FromParagraph != null)
                {
                    var startOverride = FromParagraph.StartOverride(ilvl);
                    if (startOverride != null)
                        return (int)startOverride;
                    return null;
                }
                else if (this.FromStyle != null)
                {
                    var startOverride = FromStyle.StartOverride(ilvl);
                    if (startOverride != null)
                        return (int)startOverride;
                    return null;
                }
                return null;
            }

            private int? mNumId;

            public int NumId
            {
                get
                {
                    if (mNumId != null)
                        return (int)mNumId;
                    if (FromParagraph != null)
                        mNumId = FromParagraph.Main.NumId;
                    else if (FromStyle != null)
                        mNumId = FromStyle.Main.NumId;
                    return (int)mNumId;
                }
            }

            public ListItemInfo() { }

            public ListItemInfo(bool isListItem, bool isZeroNumId)
            {
                IsListItem = isListItem;
                IsZeroNumId = isZeroNumId;
            }
        }
        
        public static void SetParagraphLevel(XElement paragraph, int ilvl)
        {
            var pi = paragraph.Annotation<ParagraphInfo>();
            if (pi == null)
            {
                pi = new ParagraphInfo()
                {
                    Ilvl = ilvl,
                };
                paragraph.AddAnnotation(pi);
                return;
            }
            throw new OpenXmlPowerToolsException("Internal error - should never set ilvl more than once.");
        }

        public static int GetParagraphLevel(XElement paragraph)
        {
            var pi = paragraph.Annotation<ParagraphInfo>();
            if (pi != null)
                return pi.Ilvl;
            throw new OpenXmlPowerToolsException("Internal error - should never ask for ilvl without it first being set.");
        }

        public static ListItemInfo GetListItemInfo(XDocument numXDoc, XDocument stylesXDoc, XElement paragraph)
        {
            // The following is an optimization - only determine ListItemInfo once for a
            // paragraph.
            ListItemInfo listItemInfo = paragraph.Annotation<ListItemInfo>();
            if (listItemInfo != null)
                return listItemInfo;
            throw new OpenXmlPowerToolsException("Attempting to retrieve ListItemInfo before initialization");
        }

        private static ListItemInfo NotAListItem = new ListItemInfo(false, true);
        private static ListItemInfo ZeroNumId = new ListItemInfo(false, false);

        public static void InitListItemInfo(XDocument numXDoc, XDocument stylesXDoc, XElement paragraph)
        {
            if (FirstRunIsEmptySectionBreak(paragraph))
            {
                paragraph.AddAnnotation(NotAListItem);
                return;
            }

            int? paragraphNumId = null;

            XElement paragraphNumberingProperties = paragraph
                .Elements(W.pPr)
                .Elements(W.numPr)
                .FirstOrDefault();

            if (paragraphNumberingProperties != null)
            {
                paragraphNumId = (int?)paragraphNumberingProperties
                    .Elements(W.numId)
                    .Attributes(W.val)
                    .FirstOrDefault();

                // if numPr of paragraph does not contain numId, then it is not a list item.
                // if numId of paragraph == 0, then this is not a list item, regardless of the markup in the style.
                if (paragraphNumId == null || paragraphNumId == 0)
                {
                    paragraph.AddAnnotation(NotAListItem);
                    return;
                }
            }

            string paragraphStyleName = GetParagraphStyleName(stylesXDoc, paragraph);

            var listItemInfo = GetListItemInfoFromCache(numXDoc, paragraphStyleName, paragraphNumId);
            if (listItemInfo != null)
            {
                paragraph.AddAnnotation(listItemInfo);

                if (listItemInfo.FromParagraph != null)
                {
                    var para_ilvl = (int?)paragraphNumberingProperties
                        .Elements(W.ilvl)
                        .Attributes(W.val)
                        .FirstOrDefault();

                    if (para_ilvl == null)
                        para_ilvl = 0;

                    var abstractNum = listItemInfo.FromParagraph.Main.AbstractNum;
                    var multiLevelType = (string)abstractNum.Elements(W.multiLevelType).Attributes(W.val).FirstOrDefault();
                    if (multiLevelType == "singleLevel")
                        para_ilvl = 0;

                    SetParagraphLevel(paragraph, (int)para_ilvl);
                }
                else if (listItemInfo.FromStyle != null)
                {
                    int this_ilvl = listItemInfo.FromStyle.Style_ilvl;
                    var abstractNum = listItemInfo.FromStyle.Main.AbstractNum;
                    var multiLevelType = (string)abstractNum.Elements(W.multiLevelType).Attributes(W.val).FirstOrDefault();
                    if (multiLevelType == "singleLevel")
                        this_ilvl = 0;

                    SetParagraphLevel(paragraph, this_ilvl);
                }
                return;
            }

            listItemInfo = new ListItemInfo();

            int? style_ilvl = null;
            bool? styleZeroNumId = null;

            if (paragraphStyleName != null)
            {
                listItemInfo.FromStyle = InitializeStyleListItemSource(numXDoc, stylesXDoc, paragraph, paragraphStyleName,
                        out style_ilvl, out styleZeroNumId);
            }

            int? paragraph_ilvl = null;
            bool? paragraphZeroNumId = null;

            if (paragraphNumberingProperties != null && paragraphNumberingProperties.Element(W.numId) != null)
            {
                listItemInfo.FromParagraph = InitializeParagraphListItemSource(numXDoc, stylesXDoc, paragraph, paragraphNumberingProperties, out paragraph_ilvl, out paragraphZeroNumId);
            }

            if (styleZeroNumId == true && paragraphZeroNumId == null ||
                paragraphZeroNumId == true)
            {
                paragraph.AddAnnotation(NotAListItem);
                AddListItemInfoIntoCache(numXDoc, paragraphStyleName, paragraphNumId, NotAListItem);
                return;
            }

            int ilvlToSet = 0;
            if (paragraph_ilvl != null)
                ilvlToSet = (int)paragraph_ilvl;
            else if (style_ilvl != null)
                ilvlToSet = (int)style_ilvl;

            if (listItemInfo.FromParagraph != null)
            {
                var abstractNum = listItemInfo.FromParagraph.Main.AbstractNum;
                var multiLevelType = (string)abstractNum.Elements(W.multiLevelType).Attributes(W.val).FirstOrDefault();
                if (multiLevelType == "singleLevel")
                    ilvlToSet = 0;
            }
            else if (listItemInfo.FromStyle != null)
            {
                var abstractNum = listItemInfo.FromStyle.Main.AbstractNum;
                var multiLevelType = (string)abstractNum.Elements(W.multiLevelType).Attributes(W.val).FirstOrDefault();
                if (multiLevelType == "singleLevel")
                    ilvlToSet = 0;
            }

            SetParagraphLevel(paragraph, ilvlToSet);

            listItemInfo.IsListItem = listItemInfo.FromStyle != null || listItemInfo.FromParagraph != null;
            paragraph.AddAnnotation(listItemInfo);
            AddListItemInfoIntoCache(numXDoc, paragraphStyleName, paragraphNumId, listItemInfo);
        }

        private static string GetParagraphStyleName(XDocument stylesXDoc, XElement paragraph)
        {
            var paragraphStyleName = (string)paragraph
                 .Elements(W.pPr)
                 .Elements(W.pStyle)
                 .Attributes(W.val)
                 .FirstOrDefault();

            if (paragraphStyleName == null)
                paragraphStyleName = GetDefaultParagraphStyleName(stylesXDoc);

            return paragraphStyleName;
        }

        private static bool FirstRunIsEmptySectionBreak(XElement paragraph)
        {
            var firstRun = paragraph
                .DescendantsTrimmed(W.txbxContent)
                .Where(d => d.Name == W.r)
                .FirstOrDefault();

            var hasTextElement = paragraph
                .DescendantsTrimmed(W.txbxContent)
                .Where(d => d.Name == W.r)
                .Elements(W.t)
                .Any();

            if (firstRun == null || !hasTextElement)
            {
                if (paragraph
                    .Elements(W.pPr)
                    .Elements(W.sectPr)
                    .Any())
                    return true;
            }
            return false;
        }

        private static ListItemSource InitializeParagraphListItemSource(XDocument numXDoc, XDocument stylesXDoc, XElement paragraph, XElement paragraphNumberingProperties, out int? ilvl, out bool? zeroNumId)
        {
            zeroNumId = null;

            // Paragraph numbering properties must contain a numId.
            int? numId = (int?)paragraphNumberingProperties
                .Elements(W.numId)
                .Attributes(W.val)
                .FirstOrDefault();

            ilvl = (int?)paragraphNumberingProperties
                .Elements(W.ilvl)
                .Attributes(W.val)
                .FirstOrDefault();

            if (numId == null)
            {
                zeroNumId = true;
                return null;
            }

            var num = numXDoc
                .Root
                .Elements(W.num)
                .FirstOrDefault(n => (int)n.Attribute(W.numId) == numId);
            if (num == null)
            {
                zeroNumId = true;
                return null;
            }

            zeroNumId = false;

            if (ilvl == null)
                ilvl = 0;

            ListItemSource listItemSource = new ListItemSource(numXDoc, stylesXDoc, (int)numId);

            return listItemSource;
        }

        private static ListItemSource InitializeStyleListItemSource(XDocument numXDoc, XDocument stylesXDoc, XElement paragraph, string paragraphStyleName, 
            out int? ilvl, out bool? zeroNumId)
        {
            zeroNumId = null;
            XElement pPr = FormattingAssembler.ParagraphStyleRollup(paragraph, stylesXDoc, GetDefaultParagraphStyleName(stylesXDoc));
            if (pPr != null)
            {
                XElement styleNumberingProperties = pPr
                    .Elements(W.numPr)
                    .FirstOrDefault();

                if (styleNumberingProperties != null && styleNumberingProperties.Element(W.numId) != null)
                {
                    int numId = (int)styleNumberingProperties
                        .Elements(W.numId)
                        .Attributes(W.val)
                        .FirstOrDefault();

                    ilvl = (int?)styleNumberingProperties
                        .Elements(W.ilvl)
                        .Attributes(W.val)
                        .FirstOrDefault();

                    if (ilvl == null)
                        ilvl = 0;

                    if (numId == 0)
                    {
                        zeroNumId = true;
                        return null;
                    }

                    // make sure that the numId is valid
                    XElement num = numXDoc
                        .Root
                        .Elements(W.num)
                        .Where(e => (int)e.Attribute(W.numId) == numId)
                        .FirstOrDefault();

                    if (num == null)
                    {
                        zeroNumId = true;
                        return null;
                    }

                    ListItemSource listItemSource = new ListItemSource(numXDoc, stylesXDoc, numId);
                    listItemSource.Style_ilvl = (int)ilvl;

                    zeroNumId = false;
                    return listItemSource;
                }
            }
            ilvl = null;
            return null;
        }

        private static string GetDefaultParagraphStyleName(XDocument stylesXDoc)
        {
            XElement defaultParagraphStyle;
            string defaultParagraphStyleName = null;

            StylesInfo stylesInfo = stylesXDoc.Annotation<StylesInfo>();

            if (stylesInfo != null)
                defaultParagraphStyleName = stylesInfo.DefaultParagraphStyleName;
            else
            {
                defaultParagraphStyle = stylesXDoc
                    .Root
                    .Elements(W.style)
                    .FirstOrDefault(s =>
                    {
                        if ((string)s.Attribute(W.type) != "paragraph")
                            return false;
                        var defaultAttribute = s.Attribute(W._default);
                        var isDefault = false;
                        if (defaultAttribute != null &&
                            (bool)s.Attribute(W._default).ToBoolean())
                            isDefault = true;
                        return isDefault;
                    });
                defaultParagraphStyleName = null;
                if (defaultParagraphStyle != null)
                    defaultParagraphStyleName = (string)defaultParagraphStyle.Attribute(W.styleId);
                stylesInfo = new StylesInfo()
                {
                    DefaultParagraphStyleName = defaultParagraphStyleName,
                };
                stylesXDoc.AddAnnotation(stylesInfo);
            }
            return defaultParagraphStyleName;
        }

        private static ListItemInfo GetListItemInfoFromCache(XDocument numXDoc, string styleName, int? numId)
        {
            string key =
                (styleName == null ? "" : styleName) +
                "|" +
                (numId == null ? "" : numId.ToString());

            var numXDocRoot = numXDoc.Root;
            Dictionary<string, ListItemInfo> listItemInfoCache =
                numXDocRoot.Annotation<Dictionary<string, ListItemInfo>>();
            if (listItemInfoCache == null)
            {
                listItemInfoCache = new Dictionary<string, ListItemInfo>();
                numXDocRoot.AddAnnotation(listItemInfoCache);
            }
            if (listItemInfoCache.ContainsKey(key))
                return listItemInfoCache[key];
            return null;
        }

        private static void AddListItemInfoIntoCache(XDocument numXDoc, string styleName, int? numId, ListItemInfo listItemInfo)
        {
            string key =
                (styleName == null ? "" : styleName) +
                "|" +
                (numId == null ? "" : numId.ToString());

            var numXDocRoot = numXDoc.Root;
            Dictionary<string, ListItemInfo> listItemInfoCache =
                numXDocRoot.Annotation<Dictionary<string, ListItemInfo>>();
            if (listItemInfoCache == null)
            {
                listItemInfoCache = new Dictionary<string, ListItemInfo>();
                numXDocRoot.AddAnnotation(listItemInfoCache);
            }
            if (!listItemInfoCache.ContainsKey(key))
                listItemInfoCache.Add(key, listItemInfo);
        }

        public class LevelNumbers
        {
            public int[] LevelNumbersArray;
        }

        private class StylesInfo
        {
            public string DefaultParagraphStyleName;
        }

        private class ParagraphInfo
        {
            public int Ilvl;
        }

        private class ReverseAxis
        {
            public XElement PreviousParagraph;
        }

        public static string RetrieveListItem(WordprocessingDocument wordDoc, XElement paragraph)
        {
            return RetrieveListItem(wordDoc, paragraph, null);
        }

        public static string RetrieveListItem(WordprocessingDocument wordDoc, XElement paragraph, ListItemRetrieverSettings settings)
        {
            if (wordDoc.MainDocumentPart.NumberingDefinitionsPart == null)
                return null;

            var listItemInfo = paragraph.Annotation<ListItemInfo>();
            if (listItemInfo == null)
                InitializeListItemRetriever(wordDoc, settings);

            listItemInfo = paragraph.Annotation<ListItemInfo>();
            if (!listItemInfo.IsListItem)
                return null;

            var numberingDefinitionsPart = wordDoc
                .MainDocumentPart
                .NumberingDefinitionsPart;

            if (numberingDefinitionsPart == null)
                return null;

            StyleDefinitionsPart styleDefinitionsPart = wordDoc
                .MainDocumentPart
                .StyleDefinitionsPart;

            if (styleDefinitionsPart == null)
                return null;

            var numXDoc = numberingDefinitionsPart.GetXDocument();
            var stylesXDoc = styleDefinitionsPart.GetXDocument();

            var lvl = listItemInfo.Lvl(GetParagraphLevel(paragraph));

            string lvlText = (string)lvl.Elements(W.lvlText).Attributes(W.val).FirstOrDefault();
            if (lvlText == null)
                return null;

            var levelNumbersAnnotation = paragraph.Annotation<LevelNumbers>();
            if (levelNumbersAnnotation == null)
                throw new OpenXmlPowerToolsException("Internal error");

            int[] levelNumbers = levelNumbersAnnotation.LevelNumbersArray;
            string languageIdentifier = GetLanguageIdentifier(paragraph, stylesXDoc);
            string listItem = FormatListItem(listItemInfo, levelNumbers, GetParagraphLevel(paragraph), 
                lvlText, stylesXDoc, languageIdentifier, settings);
            return listItem;
        }

        private static string GetLanguageIdentifier(XElement paragraph, XDocument stylesXDoc)
        {
            var languageType = (string)paragraph
                .DescendantsTrimmed(W.txbxContent)
                .Where(d => d.Name == W.r)
                .Attributes(PtOpenXml.LanguageType)
                .FirstOrDefault();

            string languageIdentifier = null;

            if (languageType == null || languageType == "western")
            {
                languageIdentifier = (string)paragraph
                    .Elements(W.r)
                    .Elements(W.rPr)
                    .Elements(W.lang)
                    .Attributes(W.val)
                    .FirstOrDefault();

                if (languageIdentifier == null)
                    languageIdentifier = (string)stylesXDoc
                        .Root
                        .Elements(W.docDefaults)
                        .Elements(W.rPrDefault)
                        .Elements(W.rPr)
                        .Elements(W.lang)
                        .Attributes(W.val)
                        .FirstOrDefault();
            }
            else if (languageType == "eastAsia")
            {
                languageIdentifier = (string)paragraph
                    .Elements(W.r)
                    .Elements(W.rPr)
                    .Elements(W.lang)
                    .Attributes(W.eastAsia)
                    .FirstOrDefault();

                if (languageIdentifier == null)
                    languageIdentifier = (string)stylesXDoc
                        .Root
                        .Elements(W.docDefaults)
                        .Elements(W.rPrDefault)
                        .Elements(W.rPr)
                        .Elements(W.lang)
                        .Attributes(W.eastAsia)
                        .FirstOrDefault();
            }
            else if (languageType == "bidi")
            {
                languageIdentifier = (string)paragraph
                    .Elements(W.r)
                    .Elements(W.rPr)
                    .Elements(W.lang)
                    .Attributes(W.bidi)
                    .FirstOrDefault();

                if (languageIdentifier == null)
                    languageIdentifier = (string)stylesXDoc
                        .Root
                        .Elements(W.docDefaults)
                        .Elements(W.rPrDefault)
                        .Elements(W.rPr)
                        .Elements(W.lang)
                        .Attributes(W.bidi)
                        .FirstOrDefault();
            }


            if (languageIdentifier == null)
                languageIdentifier = "en-US";
            return languageIdentifier;
        }

        private static void InitializeListItemRetriever(WordprocessingDocument wordDoc, ListItemRetrieverSettings settings)
        {
            foreach (var part in wordDoc.ContentParts())
                InitializeListItemRetrieverForPart(wordDoc, part, settings);

#if false
            foreach (var part in wordDoc.ContentParts())
	        {
                var xDoc = part.GetXDocument();
                var paras = xDoc
                    .Descendants(W.p)
                    .Where(p =>
                        p.Annotation<ListItemInfo>() == null);
                if (paras.Any())
                    Console.WriteLine("Error");
	        }
#endif
        }

        private static void InitializeListItemRetrieverForPart(WordprocessingDocument wordDoc, OpenXmlPart part, ListItemRetrieverSettings settings)
        {
            var mainXDoc = part.GetXDocument();
            
            var numPart = wordDoc.MainDocumentPart.NumberingDefinitionsPart;
            if (numPart == null)
                return;
            var numXDoc = numPart.GetXDocument();

            var stylesPart = wordDoc.MainDocumentPart.StyleDefinitionsPart;
            if (stylesPart == null)
                return;
            var stylesXDoc = stylesPart.GetXDocument();

            var rootNode = mainXDoc.Root;

            InitializeListItemRetrieverForStory(numXDoc, stylesXDoc, rootNode);

            var textBoxes = mainXDoc
                .Root
                .Descendants(W.txbxContent);

            foreach (var textBox in textBoxes)
                InitializeListItemRetrieverForStory(numXDoc, stylesXDoc, textBox);
        }

        private static void InitializeListItemRetrieverForStory(XDocument numXDoc, XDocument stylesXDoc, XElement rootNode)
        {
            var paragraphs = rootNode
                .DescendantsTrimmed(W.txbxContent)
                .Where(p => p.Name == W.p);

            foreach (var paragraph in paragraphs)
                InitListItemInfo(numXDoc, stylesXDoc, paragraph);

            var abstractNumIds = paragraphs
                .Select(paragraph =>
                {
                    ListItemInfo listItemInfo = paragraph.Annotation<ListItemInfo>();
                    if (!listItemInfo.IsListItem)
                        return (int?)null;
                    return listItemInfo.AbstractNumId;
                })
                .Where(a => a != null)
                .Distinct()
                .ToList();

            // when debugging, it is sometimes useful to cause processing of a specific abstractNumId first.
            // the following code enables this.
            //int? abstractIdToProcessFirst = null;
            //if (abstractIdToProcessFirst != null)
            //{
            //    abstractNumIds = (new[] { abstractIdToProcessFirst })
            //        .Concat(abstractNumIds.Where(ani => ani != abstractIdToProcessFirst))
            //        .ToList();
            //}

            foreach (var abstractNumId in abstractNumIds)
            {
                var listItems = paragraphs
                    .Where(paragraph =>
                    {
                        var listItemInfo = paragraph.Annotation<ListItemInfo>();
                        if (!listItemInfo.IsListItem)
                            return false;
                        return listItemInfo.AbstractNumId == abstractNumId;
                    })
                    .ToList();

                // annotate paragraphs with previous paragraphs so that we can look backwards with good perf
                XElement prevParagraph = null;
                foreach (var paragraph in listItems)
                {
                    ReverseAxis reverse = new ReverseAxis()
                    {
                        PreviousParagraph = prevParagraph,
                    };
                    paragraph.AddAnnotation(reverse);
                    prevParagraph = paragraph;
                }

                var startOverrideAlreadyUsed = new List<int>();
                List<int> previous = null;
                ListItemInfo[] listItemInfoInEffectForStartOverride = new ListItemInfo[] {
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                };
                foreach (var paragraph in listItems)
                {
                    var listItemInfo = paragraph.Annotation<ListItemInfo>();
                    var ilvl = GetParagraphLevel(paragraph);
                    listItemInfoInEffectForStartOverride[ilvl] = listItemInfo;
                    ListItemInfo listItemInfoInEffect = null;
                    if (ilvl > 0)
                        listItemInfoInEffect = listItemInfoInEffectForStartOverride[ilvl - 1];
                    var levelNumbers = new List<int>();

                    for (int level = 0; level <= ilvl; level++)
                    {
                        var numId = listItemInfo.NumId;
                        var startOverride = listItemInfo.StartOverride(level);
                        int? inEffectStartOverride = null;
                        if (listItemInfoInEffect != null)
                            inEffectStartOverride = listItemInfoInEffect.StartOverride(level);

                        if (level == ilvl)
                        {
                            var lvl = listItemInfo.Lvl(ilvl);
                            var lvlRestart = (int?)lvl.Elements(W.lvlRestart).Attributes(W.val).FirstOrDefault();
                            if (lvlRestart != null)
                            {
                                var previousPara = PreviousParagraphsForLvlRestart(paragraph, (int)lvlRestart)
                                    .FirstOrDefault(p =>
                                    {
                                        var plvl = GetParagraphLevel(p);
                                        return plvl == ilvl;
                                    });
                                if (previousPara != null)
                                    previous = previousPara.Annotation<LevelNumbers>().LevelNumbersArray.ToList();
                            }
                        }

                        if (previous == null ||
                            level >= previous.Count() ||
                            (level == ilvl && startOverride != null && !startOverrideAlreadyUsed.Contains(numId)))
                        {
                            if (previous == null || level >= previous.Count())
                            {
                                var start = listItemInfo.Start(level);
                                // only look at startOverride if the level that we're examining is same as the paragraph's level.
                                if (level == ilvl)
                                {
                                    if (startOverride != null && !startOverrideAlreadyUsed.Contains(numId))
                                    {
                                        startOverrideAlreadyUsed.Add(numId);
                                        start = (int)startOverride;
                                    }
                                    else
                                    {
                                        if (startOverride != null)
                                            start = (int)startOverride;
                                        if (inEffectStartOverride != null && inEffectStartOverride > start)
                                            start = (int)inEffectStartOverride;
                                    }
                                }
                                levelNumbers.Add(start);
                            }
                            else
                            {
                                var start = listItemInfo.Start(level);
                                // only look at startOverride if the level that we're examining is same as the paragraph's level.
                                if (level == ilvl)
                                {
                                    if (startOverride != null)
                                    {
                                        if (!startOverrideAlreadyUsed.Contains(numId))
                                        {
                                            startOverrideAlreadyUsed.Add(numId);
                                            start = (int)startOverride;
                                        }
                                    }
                                }
                                levelNumbers.Add(start);
                            }
                        }
                        else
                        {
                            int? thisNumber = null;
                            if (level == ilvl)
                            {
                                if (startOverride != null)
                                {
                                    if (!startOverrideAlreadyUsed.Contains(numId))
                                    {
                                        startOverrideAlreadyUsed.Add(numId);
                                        thisNumber = (int)startOverride;
                                    }
                                    thisNumber = previous.ElementAt(level) + 1;
                                }
                                else
                                {
                                    thisNumber = previous.ElementAt(level) + 1;
                                }
                            }
                            else
                            {
                                thisNumber = previous.ElementAt(level);
                            }
                            levelNumbers.Add((int)thisNumber);
                        }
                    }
                    var levelNumbersAnno = new LevelNumbers()
                    {
                        LevelNumbersArray = levelNumbers.ToArray()
                    };
                    paragraph.AddAnnotation(levelNumbersAnno);
                    previous = levelNumbers;
                }
            }
        }

        private static IEnumerable<XElement> PreviousParagraphsForLvlRestart(XElement paragraph, int ilvl)
        {
            var current = paragraph;
            while (true)
            {
                var ra = current.Annotation<ReverseAxis>();
                if (ra == null || ra.PreviousParagraph == null)
                    yield break;
                var raLvl = GetParagraphLevel(ra.PreviousParagraph);
                if (raLvl < ilvl)
                    yield break;
                yield return ra.PreviousParagraph;
                current = ra.PreviousParagraph;
            }
        }

        private static string FormatListItem(ListItemInfo lii, int[] levelNumbers, int ilvl,
            string lvlText, XDocument styles, string languageCultureName, ListItemRetrieverSettings settings)
        {
            string[] formatTokens = GetFormatTokens(lvlText).ToArray();
            XElement lvl = lii.Lvl(ilvl);
            bool isLgl = lvl.Elements(W.isLgl).Any();
            string listItem = formatTokens.Select((t, l) =>
            {
                if (t.Substring(0, 1) != "%")
                    return t;
                int indentationLevel;
                if (!Int32.TryParse(t.Substring(1), out indentationLevel))
                    return t;
                indentationLevel -= 1;
                if (indentationLevel >= levelNumbers.Length)
                    indentationLevel = levelNumbers.Length - 1;
                int levelNumber = levelNumbers[indentationLevel];
                string levelText = null;
                XElement rlvl = lii.Lvl(indentationLevel);
                string numFmtForLevel = (string)rlvl.Elements(W.numFmt).Attributes(W.val).FirstOrDefault();
                if (numFmtForLevel == null)
                {
                    var numFmtElement = rlvl.Elements(MC.AlternateContent).Elements(MC.Choice).Elements(W.numFmt).FirstOrDefault();
                    if (numFmtElement != null && (string)numFmtElement.Attribute(W.val) == "custom")
                        numFmtForLevel = (string)numFmtElement.Attribute(W.format);
                }
                if (numFmtForLevel != "none")
                {
                    if (isLgl && numFmtForLevel != "decimalZero")
                        numFmtForLevel = "decimal";
                }
                if (languageCultureName != null && settings != null)
                {
                    if (settings.ListItemTextImplementations.ContainsKey(languageCultureName))
                    {
                        var impl = settings.ListItemTextImplementations[languageCultureName];
                        levelText = impl(languageCultureName, levelNumber, numFmtForLevel);
                    }
                }
                if (levelText == null)
                    levelText = ListItemTextGetter_Default.GetListItemText(languageCultureName, levelNumber, numFmtForLevel);
                return levelText;
            }).StringConcatenate();
            return listItem;
        }

        private static IEnumerable<string> GetFormatTokens(string lvlText)
        {
            int i = 0;
            while (true)
            {
                if (i >= lvlText.Length)
                    yield break;
                if (lvlText[i] == '%' && i <= lvlText.Length - 2)
                {
                    yield return lvlText.Substring(i, 2);
                    i += 2;
                    continue;
                }
                int percentIndex = lvlText.IndexOf('%', i);
                if (percentIndex == -1 || percentIndex > lvlText.Length - 2)
                {
                    yield return lvlText.Substring(i);
                    yield break;
                }
                yield return lvlText.Substring(i, percentIndex - i);
                yield return lvlText.Substring(percentIndex, 2);
                i = percentIndex + 2;
            }
        }

    }
}
