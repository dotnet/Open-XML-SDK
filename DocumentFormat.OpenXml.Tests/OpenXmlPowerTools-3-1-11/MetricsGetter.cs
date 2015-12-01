/***************************************************************************
 
Copyright (c) Microsoft Corporation 2014.
 
This code is licensed using the Microsoft Public License (Ms-PL).  The text of the license can be found here:
 
http://www.microsoft.com/resources/sharedsource/licensingbasics/publiclicense.mspx
 
Published at http://OpenXmlDeveloper.org
Resource Center and Documentation: http://openxmldeveloper.org/wiki/w/wiki/powertools-for-open-xml.aspx
 
***************************************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation;
using System.Globalization;

namespace OpenXmlPowerTools
{
    public class MetricsGetterSettings
    {
        public bool IncludeTextInContentControls;
        public bool IncludeXlsxTableCellData;
    }

    public class MetricsGetter
    {
        public static XElement GetMetrics(string fileName, MetricsGetterSettings settings)
        {
            FileInfo fi = new FileInfo(fileName);
            if (!fi.Exists)
                throw new FileNotFoundException("{0} does not exist.", fi.FullName);
            if (Util.IsWordprocessingML(fi.Extension))
            {
                WmlDocument wmlDoc = new WmlDocument(fi.FullName, true);
                return GetDocxMetrics(wmlDoc, settings);
            }
            if (Util.IsSpreadsheetML(fi.Extension))
            {
                SmlDocument smlDoc = new SmlDocument(fi.FullName, true);
                return GetXlsxMetrics(smlDoc, settings);
            }
            if (Util.IsPresentationML(fi.Extension))
            {
                PmlDocument pmlDoc = new PmlDocument(fi.FullName, true);
                return GetPptxMetrics(pmlDoc, settings);
            }
            return null;
        }

        public static XElement GetDocxMetrics(WmlDocument wmlDoc, MetricsGetterSettings settings)
        {
            WmlDocument converted = new WmlDocument(wmlDoc, true);
            WmlDocument noTrackedRevisions = new WmlDocument(converted);

            try
            {
                using (OpenXmlMemoryStreamDocument noTrackedStreamDoc = new OpenXmlMemoryStreamDocument(noTrackedRevisions))
                using (WordprocessingDocument noTrackedDocument = noTrackedStreamDoc.GetWordprocessingDocument())
                using (OpenXmlMemoryStreamDocument streamDoc = new OpenXmlMemoryStreamDocument(converted))
                using (WordprocessingDocument document = streamDoc.GetWordprocessingDocument())
                {
                    if (RevisionAccepter.HasTrackedRevisions(noTrackedDocument))
                        RevisionAccepter.AcceptRevisions(noTrackedDocument);
                    return GetWmlMetrics(converted.FileName, false, document, noTrackedDocument, settings);
                }
            }
            catch (OpenXmlPowerToolsException e)
            {
                if (e.ToString().Contains("Invalid Hyperlink"))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        WmlDocument fixedWmlDoc = new WmlDocument(converted);
                        ms.Write(converted.DocumentByteArray, 0, converted.DocumentByteArray.Length);
                        UriFixer.FixInvalidUri(ms, brokenUri => FixUri(brokenUri));
                        converted = new WmlDocument("dummy.docx", ms.ToArray());
                    }
                    noTrackedRevisions = new WmlDocument(converted);
                    using (OpenXmlMemoryStreamDocument noTrackedStreamDoc = new OpenXmlMemoryStreamDocument(noTrackedRevisions))
                    using (WordprocessingDocument noTrackedDocument = noTrackedStreamDoc.GetWordprocessingDocument())
                    using (OpenXmlMemoryStreamDocument streamDoc = new OpenXmlMemoryStreamDocument(converted))
                    using (WordprocessingDocument document = streamDoc.GetWordprocessingDocument())
                    {
                        if (RevisionAccepter.HasTrackedRevisions(noTrackedDocument))
                            RevisionAccepter.AcceptRevisions(noTrackedDocument);
                        return GetWmlMetrics(converted.FileName, true, document, noTrackedDocument, settings);
                    }
                }
            }
            var metrics = new XElement(H.Metrics,
                new XAttribute(H.FileName, converted.FileName),
                new XAttribute(H.FileType, "WordprocessingML"),
                new XAttribute(H.Error, "Unknown error, metrics not determined"));
            return metrics;
        }

        private static Uri FixUri(string brokenUri)
        {
            return new Uri("http://broken-link/");
        }

        private static XElement GetWmlMetrics(string fileName, bool invalidHyperlink, WordprocessingDocument document, WordprocessingDocument noTrackedDocument, MetricsGetterSettings settings)
        {
            var parts = new XElement(H.Parts,
                document.GetAllParts().Select(part =>
                {
                    return GetMetricsForWmlPart(noTrackedDocument, part, settings);
                }));
            if (!parts.HasElements)
                parts = null;
            var metrics = new XElement(H.Metrics,
                new XAttribute(H.FileName, fileName),
                new XAttribute(H.FileType, "WordprocessingML"),
                GetStyleHierarchy(document),
                GetMiscWmlMetrics(document, noTrackedDocument, invalidHyperlink),
                parts);
            return metrics;
        }

        private static List<XElement> GetMiscWmlMetrics(WordprocessingDocument document, WordprocessingDocument noTrackedDocument, bool invalidHyperlink)
        {
            List<XElement> metrics = new List<XElement>();
            List<string> notes = new List<string>();
            Dictionary<XName, int> elementCountDictionary = new Dictionary<XName, int>();

            if (invalidHyperlink)
                metrics.Add(new XElement(H.InvalidHyperlink, new XAttribute(H.Val, invalidHyperlink)));

            bool valid = ValidateWordprocessingDocument(document, metrics, notes, elementCountDictionary);
            if (invalidHyperlink)
                valid = false;

            return metrics;
        }

        private static bool ValidateWordprocessingDocument(WordprocessingDocument wDoc, List<XElement> metrics, List<string> notes, Dictionary<XName, int> metricCountDictionary)
        {
            bool valid = ValidateAgainstSpecificVersion(wDoc, metrics, DocumentFormat.OpenXml.FileFormatVersions.Office2007, H.SdkValidationError2007);
            valid |= ValidateAgainstSpecificVersion(wDoc, metrics, DocumentFormat.OpenXml.FileFormatVersions.Office2010, H.SdkValidationError2010);
            valid |= ValidateAgainstSpecificVersion(wDoc, metrics, DocumentFormat.OpenXml.FileFormatVersions.Office2013, H.SdkValidationError2013);

            int elementCount = 0;
            int paragraphCount = 0;
            int textCount = 0;
            foreach (var part in wDoc.ContentParts())
            {
                XDocument xDoc = part.GetXDocument();
                foreach (var e in xDoc.Descendants())
                {
                    if (e.Name == W.txbxContent)
                        IncrementMetric(metricCountDictionary, H.TextBox);
                    else if (e.Name == W.sdt)
                        IncrementMetric(metricCountDictionary, H.ContentControl);
                    else if (e.Name == W.customXml)
                        IncrementMetric(metricCountDictionary, H.CustomXmlMarkup);
                    else if (e.Name == W.fldChar)
                        IncrementMetric(metricCountDictionary, H.ComplexField);
                    else if (e.Name == W.fldSimple)
                        IncrementMetric(metricCountDictionary, H.SimpleField);
                    else if (e.Name == W.altChunk)
                        IncrementMetric(metricCountDictionary, H.AltChunk);
                    else if (e.Name == W.tbl)
                        IncrementMetric(metricCountDictionary, H.Table);
                    else if (e.Name == W.hyperlink)
                        IncrementMetric(metricCountDictionary, H.Hyperlink);
                    else if (e.Name == W.framePr)
                        IncrementMetric(metricCountDictionary, H.LegacyFrame);
                    else if (e.Name == W.control)
                        IncrementMetric(metricCountDictionary, H.ActiveX);
                    else if (e.Name == W.subDoc)
                        IncrementMetric(metricCountDictionary, H.SubDocument);
                    else if (e.Name == VML.imagedata || e.Name == VML.fill || e.Name == VML.stroke || e.Name == A.blip)
                    {
                        var relId = (string)e.Attribute(R.embed);
                        if (relId != null)
                            ValidateImageExists(part, relId, metricCountDictionary);
                        relId = (string)e.Attribute(R.pict);
                        if (relId != null)
                            ValidateImageExists(part, relId, metricCountDictionary);
                        relId = (string)e.Attribute(R.id);
                        if (relId != null)
                            ValidateImageExists(part, relId, metricCountDictionary);
                    }

                    if (part.Uri == wDoc.MainDocumentPart.Uri)
                    {
                        elementCount++;
                        if (e.Name == W.p)
                            paragraphCount++;
                        if (e.Name == W.t)
                            textCount += ((string)e).Length;
                    }
                }
            }

            foreach (var item in metricCountDictionary)
            {
                metrics.Add(
                    new XElement(item.Key, new XAttribute(H.Val, item.Value)));
            }

            metrics.Add(new XElement(H.ElementCount, new XAttribute(H.Val, elementCount)));
            metrics.Add(new XElement(H.AverageParagraphLength, new XAttribute(H.Val, (int)((double)textCount / (double)paragraphCount))));

            if (RevisionAccepter.HasTrackedRevisions(wDoc))
                metrics.Add(new XElement(H.RevisionTracking, new XAttribute(H.Val, true)));

            if (wDoc.GetAllParts().Any(part => part.ContentType == "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"))
                metrics.Add(new XElement(H.EmbeddedXlsx, new XAttribute(H.Val, true)));

            NumberingFormatListAssembly(wDoc, metrics);

            XDocument wxDoc = wDoc.MainDocumentPart.GetXDocument();

            foreach (var d in wxDoc.Descendants())
            {
                if (d.Name == W.saveThroughXslt)
                {
                    string rid = (string)d.Attribute(R.id);
                    var tempExternalRelationship = wDoc
                        .MainDocumentPart
                        .DocumentSettingsPart
                        .ExternalRelationships
                        .FirstOrDefault(h => h.Id == rid);
                    if (tempExternalRelationship == null)
                        metrics.Add(new XElement(H.InvalidSaveThroughXslt, new XAttribute(H.Val, true)));
                    valid = false;
                }
                else if (d.Name == W.trackRevisions)
                    metrics.Add(new XElement(H.TrackRevisionsEnabled, new XAttribute(H.Val, true)));
                else if (d.Name == W.documentProtection)
                    metrics.Add(new XElement(H.DocumentProtection, new XAttribute(H.Val, true)));
            }

            FontAndCharSetAnalysis(wDoc, metrics, notes);

            return valid;
        }

        private static bool ValidateAgainstSpecificVersion(WordprocessingDocument wDoc, List<XElement> metrics, DocumentFormat.OpenXml.FileFormatVersions versionToValidateAgainst, XName versionSpecificMetricName)
        {
            OpenXmlValidator validator = new OpenXmlValidator(versionToValidateAgainst);
            var errors = validator.Validate(wDoc);
            bool valid = errors.Count() == 0;
            if (!valid)
            {
                if (!metrics.Any(e => e.Name == H.SdkValidationError))
                    metrics.Add(new XElement(H.SdkValidationError, new XAttribute(H.Val, true)));
                metrics.Add(new XElement(versionSpecificMetricName, new XAttribute(H.Val, true),
                    errors.Take(3).Select(err =>
                    {
                        StringBuilder sb = new StringBuilder();
                        if (err.Description.Length > 300)
                            sb.Append(PtUtils.MakeValidXml(err.Description.Substring(0, 300) + " ... elided ...") + Environment.NewLine);
                        else
                            sb.Append(PtUtils.MakeValidXml(err.Description) + Environment.NewLine);
                        sb.Append("  in part " + PtUtils.MakeValidXml(err.Part.Uri.ToString()) + Environment.NewLine);
                        sb.Append("  at " + PtUtils.MakeValidXml(err.Path.XPath) + Environment.NewLine);
                        return sb.ToString();
                    })));
            }
            return valid;
        }

        private static bool ValidateAgainstSpecificVersion(SpreadsheetDocument sDoc, List<XElement> metrics, DocumentFormat.OpenXml.FileFormatVersions versionToValidateAgainst, XName versionSpecificMetricName)
        {
            OpenXmlValidator validator = new OpenXmlValidator(versionToValidateAgainst);
            var errors = validator.Validate(sDoc);
            bool valid = errors.Count() == 0;
            if (!valid)
            {
                if (!metrics.Any(e => e.Name == H.SdkValidationError))
                    metrics.Add(new XElement(H.SdkValidationError, new XAttribute(H.Val, true)));
                metrics.Add(new XElement(versionSpecificMetricName, new XAttribute(H.Val, true),
                    errors.Take(3).Select(err =>
                    {
                        StringBuilder sb = new StringBuilder();
                        if (err.Description.Length > 300)
                            sb.Append(PtUtils.MakeValidXml(err.Description.Substring(0, 300) + " ... elided ...") + Environment.NewLine);
                        else
                            sb.Append(PtUtils.MakeValidXml(err.Description) + Environment.NewLine);
                        sb.Append("  in part " + PtUtils.MakeValidXml(err.Part.Uri.ToString()) + Environment.NewLine);
                        sb.Append("  at " + PtUtils.MakeValidXml(err.Path.XPath) + Environment.NewLine);
                        return sb.ToString();
                    })));
            }
            return valid;
        }

        private static bool ValidateAgainstSpecificVersion(PresentationDocument pDoc, List<XElement> metrics, DocumentFormat.OpenXml.FileFormatVersions versionToValidateAgainst, XName versionSpecificMetricName)
        {
            OpenXmlValidator validator = new OpenXmlValidator(versionToValidateAgainst);
            var errors = validator.Validate(pDoc);
            bool valid = errors.Count() == 0;
            if (!valid)
            {
                if (!metrics.Any(e => e.Name == H.SdkValidationError))
                    metrics.Add(new XElement(H.SdkValidationError, new XAttribute(H.Val, true)));
                metrics.Add(new XElement(versionSpecificMetricName, new XAttribute(H.Val, true),
                    errors.Take(3).Select(err =>
                    {
                        StringBuilder sb = new StringBuilder();
                        if (err.Description.Length > 300)
                            sb.Append(PtUtils.MakeValidXml(err.Description.Substring(0, 300) + " ... elided ...") + Environment.NewLine);
                        else
                            sb.Append(PtUtils.MakeValidXml(err.Description) + Environment.NewLine);
                        sb.Append("  in part " + PtUtils.MakeValidXml(err.Part.Uri.ToString()) + Environment.NewLine);
                        sb.Append("  at " + PtUtils.MakeValidXml(err.Path.XPath) + Environment.NewLine);
                        return sb.ToString();
                    })));
            }
            return valid;
        }

        private static void IncrementMetric(Dictionary<XName, int> metricCountDictionary, XName xName)
        {
            if (metricCountDictionary.ContainsKey(xName))
                metricCountDictionary[xName] = metricCountDictionary[xName] + 1;
            else
                metricCountDictionary.Add(xName, 1);
        }

        private static void ValidateImageExists(OpenXmlPart part, string relId, Dictionary<XName, int> metrics)
        {
            var imagePart = part.Parts.FirstOrDefault(ipp => ipp.RelationshipId == relId);
            if (imagePart == null)
                IncrementMetric(metrics, H.ReferenceToNullImage);
        }


        private static void NumberingFormatListAssembly(WordprocessingDocument wDoc, List<XElement> metrics)
        {
            List<string> numFmtList = new List<string>();
            foreach (var part in wDoc.ContentParts())
            {
                var xDoc = part.GetXDocument();
                numFmtList = numFmtList.Concat(xDoc
                    .Descendants(W.p)
                    .Select(p =>
                    {
                        ListItemRetriever.RetrieveListItem(wDoc, p, null);
                        ListItemRetriever.ListItemInfo lif = p.Annotation<ListItemRetriever.ListItemInfo>();
                        if (lif != null && lif.IsListItem && lif.Lvl(ListItemRetriever.GetParagraphLevel(p)) != null)
                        {
                            string numFmtForLevel = (string)lif.Lvl(ListItemRetriever.GetParagraphLevel(p)).Elements(W.numFmt).Attributes(W.val).FirstOrDefault();
                            if (numFmtForLevel == null)
                            {
                                var numFmtElement = lif.Lvl(ListItemRetriever.GetParagraphLevel(p)).Elements(MC.AlternateContent).Elements(MC.Choice).Elements(W.numFmt).FirstOrDefault();
                                if (numFmtElement != null && (string)numFmtElement.Attribute(W.val) == "custom")
                                    numFmtForLevel = (string)numFmtElement.Attribute(W.format);
                            }
                            return numFmtForLevel;
                        }
                        return null;
                    })
                    .Where(s => s != null)
                    .Distinct())
                    .ToList();
            }
            if (numFmtList.Any())
            {
                var nfls = numFmtList.StringConcatenate(s => s + ",").TrimEnd(',');
                metrics.Add(new XElement(H.NumberingFormatList, new XAttribute(H.Val, PtUtils.MakeValidXml(nfls))));
            }
        }

        class FormattingMetrics
        {
            public int RunCount;
            public int RunWithoutRprCount;
            public int ZeroLengthText;
            public int MultiFontRun;

            public int AsciiCharCount;
            public int CSCharCount;
            public int EastAsiaCharCount;
            public int HAnsiCharCount;

            public int AsciiRunCount;
            public int CSRunCount;
            public int EastAsiaRunCount;
            public int HAnsiRunCount;

            public List<string> Languages;

            public FormattingMetrics()
            {
                Languages = new List<string>();
            }
        }

        private static void FontAndCharSetAnalysis(WordprocessingDocument wDoc, List<XElement> metrics, List<string> notes)
        {
            FormattingAssemblerSettings settings = new FormattingAssemblerSettings
            {
                RemoveStyleNamesFromParagraphAndRunProperties = false,
                ClearStyles = true,
                RestrictToSupportedNumberingFormats = false,
                RestrictToSupportedLanguages = false,
            };
            FormattingAssembler.AssembleFormatting(wDoc, settings);
            var formattingMetrics = new FormattingMetrics();

            foreach (var part in wDoc.ContentParts())
            {
                var xDoc = part.GetXDocument();
                foreach (var run in xDoc.Descendants(W.r))
                {
                    formattingMetrics.RunCount++;
                    AnalyzeRun(run, metrics, notes, formattingMetrics, part.Uri.ToString());
                }
            }

            metrics.Add(new XElement(H.RunCount, new XAttribute(H.Val, formattingMetrics.RunCount)));
            if (formattingMetrics.RunWithoutRprCount > 0)
                metrics.Add(new XElement(H.RunWithoutRprCount, new XAttribute(H.Val, formattingMetrics.RunWithoutRprCount)));
            if (formattingMetrics.ZeroLengthText > 0)
                metrics.Add(new XElement(H.ZeroLengthText, new XAttribute(H.Val, formattingMetrics.ZeroLengthText)));
            if (formattingMetrics.MultiFontRun > 0)
                metrics.Add(new XElement(H.MultiFontRun, new XAttribute(H.Val, formattingMetrics.MultiFontRun)));
            if (formattingMetrics.AsciiCharCount > 0)
                metrics.Add(new XElement(H.AsciiCharCount, new XAttribute(H.Val, formattingMetrics.AsciiCharCount)));
            if (formattingMetrics.CSCharCount > 0)
                metrics.Add(new XElement(H.CSCharCount, new XAttribute(H.Val, formattingMetrics.CSCharCount)));
            if (formattingMetrics.EastAsiaCharCount > 0)
                metrics.Add(new XElement(H.EastAsiaCharCount, new XAttribute(H.Val, formattingMetrics.EastAsiaCharCount)));
            if (formattingMetrics.HAnsiCharCount > 0)
                metrics.Add(new XElement(H.HAnsiCharCount, new XAttribute(H.Val, formattingMetrics.HAnsiCharCount)));
            if (formattingMetrics.AsciiRunCount > 0)
                metrics.Add(new XElement(H.AsciiRunCount, new XAttribute(H.Val, formattingMetrics.AsciiRunCount)));
            if (formattingMetrics.CSRunCount > 0)
                metrics.Add(new XElement(H.CSRunCount, new XAttribute(H.Val, formattingMetrics.CSRunCount)));
            if (formattingMetrics.EastAsiaRunCount > 0)
                metrics.Add(new XElement(H.EastAsiaRunCount, new XAttribute(H.Val, formattingMetrics.EastAsiaRunCount)));
            if (formattingMetrics.HAnsiRunCount > 0)
                metrics.Add(new XElement(H.HAnsiRunCount, new XAttribute(H.Val, formattingMetrics.HAnsiRunCount)));

            if (formattingMetrics.Languages.Any())
            {
                var uls = formattingMetrics.Languages.StringConcatenate(s => s + ",").TrimEnd(',');
                metrics.Add(new XElement(H.Languages, new XAttribute(H.Val, PtUtils.MakeValidXml(uls))));
            }
        }

        private static void AnalyzeRun(XElement run, List<XElement> attList, List<string> notes, FormattingMetrics formattingMetrics, string uri)
        {
            var runText = run.Elements()
                .Where(e => e.Name == W.t || e.Name == W.delText)
                .Select(t => (string)t)
                .StringConcatenate();
            if (runText.Length == 0)
            {
                formattingMetrics.ZeroLengthText++;
                return;
            }
            var rPr = run.Element(W.rPr);
            if (rPr == null)
            {
                formattingMetrics.RunWithoutRprCount++;
                notes.Add(PtUtils.MakeValidXml(string.Format("Error in part {0}: run without rPr at {1}", uri, run.GetXPath())));
                rPr = new XElement(W.rPr);
            }
            FormattingAssembler.CharStyleAttributes csa = new FormattingAssembler.CharStyleAttributes(null, rPr);
            var fontTypeArray = runText
                .Select(ch => FormattingAssembler.DetermineFontTypeFromCharacter(ch, csa))
                .ToArray();
            var distinctFontTypeArray = fontTypeArray
                .Distinct()
                .ToArray();
            var distinctFonts = distinctFontTypeArray
                .Select(ft =>
                {
                    return GetFontFromFontType(csa, ft);
                })
                .Distinct();
            var languages = distinctFontTypeArray
                .Select(ft =>
                {
                    if (ft == FormattingAssembler.FontType.Ascii)
                        return csa.LatinLang;
                    if (ft == FormattingAssembler.FontType.CS)
                        return csa.BidiLang;
                    if (ft == FormattingAssembler.FontType.EastAsia)
                        return csa.EastAsiaLang;
                    //if (ft == FormattingAssembler.FontType.HAnsi)
                    return csa.LatinLang;
                })
                .Select(l =>
                {
                    if (l == "" || l == null)
                        return /* "Dflt:" + */ CultureInfo.CurrentCulture.Name;
                    return l;
                })
                //.Where(l => l != null && l != "")
                .Distinct();
            if (languages.Any(l => !formattingMetrics.Languages.Contains(l)))
                formattingMetrics.Languages = formattingMetrics.Languages.Concat(languages).Distinct().ToList();
            var multiFontRun = distinctFonts.Count() > 1;
            if (multiFontRun)
            {
                formattingMetrics.MultiFontRun++;

                formattingMetrics.AsciiCharCount += fontTypeArray.Where(ft => ft == FormattingAssembler.FontType.Ascii).Count();
                formattingMetrics.CSCharCount += fontTypeArray.Where(ft => ft == FormattingAssembler.FontType.CS).Count();
                formattingMetrics.EastAsiaCharCount += fontTypeArray.Where(ft => ft == FormattingAssembler.FontType.EastAsia).Count();
                formattingMetrics.HAnsiCharCount += fontTypeArray.Where(ft => ft == FormattingAssembler.FontType.HAnsi).Count();
            }
            else
            {
                switch (fontTypeArray[0])
                {
                    case FormattingAssembler.FontType.Ascii:
                        formattingMetrics.AsciiCharCount += runText.Length;
                        formattingMetrics.AsciiRunCount++;
                        break;
                    case FormattingAssembler.FontType.CS:
                        formattingMetrics.CSCharCount += runText.Length;
                        formattingMetrics.CSRunCount++;
                        break;
                    case FormattingAssembler.FontType.EastAsia:
                        formattingMetrics.EastAsiaCharCount += runText.Length;
                        formattingMetrics.EastAsiaRunCount++;
                        break;
                    case FormattingAssembler.FontType.HAnsi:
                        formattingMetrics.HAnsiCharCount += runText.Length;
                        formattingMetrics.HAnsiRunCount++;
                        break;
                }
            }
        }

        private static string GetFontFromFontType(FormattingAssembler.CharStyleAttributes csa, FormattingAssembler.FontType ft)
        {
            switch (ft)
            {
                case FormattingAssembler.FontType.Ascii:
                    return csa.AsciiFont;
                case FormattingAssembler.FontType.CS:
                    return csa.CsFont;
                case FormattingAssembler.FontType.EastAsia:
                    return csa.EastAsiaFont;
                case FormattingAssembler.FontType.HAnsi:
                    return csa.HAnsiFont;
                default: // dummy
                    return csa.AsciiFont;
            }
        }

        public static XElement GetXlsxMetrics(SmlDocument smlDoc, MetricsGetterSettings settings)
        {
            using (OpenXmlMemoryStreamDocument streamDoc = new OpenXmlMemoryStreamDocument(smlDoc))
            {
                using (SpreadsheetDocument sDoc = streamDoc.GetSpreadsheetDocument())
                {
                    List<XElement> metrics = new List<XElement>();

                    bool valid = ValidateAgainstSpecificVersion(sDoc, metrics, DocumentFormat.OpenXml.FileFormatVersions.Office2007, H.SdkValidationError2007);
                    valid |= ValidateAgainstSpecificVersion(sDoc, metrics, DocumentFormat.OpenXml.FileFormatVersions.Office2010, H.SdkValidationError2010);
                    valid |= ValidateAgainstSpecificVersion(sDoc, metrics, DocumentFormat.OpenXml.FileFormatVersions.Office2013, H.SdkValidationError2013);

                    return new XElement(H.Metrics,
                        new XAttribute(H.FileName, smlDoc.FileName),
                        new XAttribute(H.FileType, "SpreadsheetML"),
                        metrics,
                        GetTableInfoForWorkbook(sDoc, settings));
                }
            }
        }

        private static XElement GetTableInfoForWorkbook(SpreadsheetDocument spreadsheet, MetricsGetterSettings settings)
        {
            var workbookPart = spreadsheet.WorkbookPart;
            var xd = workbookPart.GetXDocument();
            var partInformation =
                new XElement(H.Sheets,
                    xd.Root
                    .Element(S.sheets)
                    .Elements(S.sheet)
                    .Select(sh =>
                    {
                        var rid = (string)sh.Attribute(R.id);
                        var sheetName = (string)sh.Attribute("name");
                        WorksheetPart worksheetPart = (WorksheetPart)workbookPart.GetPartById(rid);
                        return GetTableInfoForSheet(spreadsheet, worksheetPart, sheetName, settings);
                    }));
            return partInformation;
        }

        public static XElement GetTableInfoForSheet(SpreadsheetDocument spreadsheetDocument, WorksheetPart sheetPart, string sheetName,
            MetricsGetterSettings settings)
        {
            var xd = sheetPart.GetXDocument();
            XElement sheetInformation = new XElement(H.Sheet,
                    new XAttribute(H.Name, sheetName),
                    xd.Root.Elements(S.tableParts).Elements(S.tablePart).Select(tp =>
                    {
                        string rId = (string)tp.Attribute(R.id);
                        TableDefinitionPart tablePart = (TableDefinitionPart)sheetPart.GetPartById(rId);
                        var txd = tablePart.GetXDocument();
                        var tableName = (string)txd.Root.Attribute("displayName");
                        XElement tableCellData = null;
                        if (settings.IncludeXlsxTableCellData)
                        {
                            var xlsxTable = spreadsheetDocument.Table(tableName);
                            tableCellData = new XElement(H.TableData,
                                xlsxTable.TableRows()
                                    .Select(row =>
                                    {
                                        var rowElement = new XElement(H.Row,
                                            xlsxTable.TableColumns().Select(col =>
                                            {
                                                var cellElement = new XElement(H.Cell,
                                                    new XAttribute(H.Name, col.Name),
                                                    new XAttribute(H.Val, (string)row[col.Name]));
                                                return cellElement;
                                            }));
                                        return rowElement;
                                    }));
                        }
                        var table = new XElement(H.Table,
                            new XAttribute(H.Name, (string)txd.Root.Attribute("name")),
                            new XAttribute(H.DisplayName, tableName),
                            new XElement(H.Columns,
                                txd.Root.Element(S.tableColumns).Elements(S.tableColumn)
                                .Select(tc => new XElement(H.Column,
                                    new XAttribute(H.Name, (string)tc.Attribute("name"))))),
                                    tableCellData
                            );
                        return table;
                    })
                );
            if (!sheetInformation.HasElements)
                return null;
            return sheetInformation;
        }

        public static XElement GetPptxMetrics(PmlDocument pmlDoc, MetricsGetterSettings settings)
        {
            using (OpenXmlMemoryStreamDocument streamDoc = new OpenXmlMemoryStreamDocument(pmlDoc))
            {
                using (PresentationDocument pDoc = streamDoc.GetPresentationDocument())
                {
                    List<XElement> metrics = new List<XElement>();

                    bool valid = ValidateAgainstSpecificVersion(pDoc, metrics, DocumentFormat.OpenXml.FileFormatVersions.Office2007, H.SdkValidationError2007);
                    valid |= ValidateAgainstSpecificVersion(pDoc, metrics, DocumentFormat.OpenXml.FileFormatVersions.Office2010, H.SdkValidationError2010);
                    valid |= ValidateAgainstSpecificVersion(pDoc, metrics, DocumentFormat.OpenXml.FileFormatVersions.Office2013, H.SdkValidationError2013);

                    return new XElement(H.Metrics,
                        new XAttribute(H.FileName, pmlDoc.FileName),
                        new XAttribute(H.FileType, "PresentationML"),
                        metrics);
                }
            }
        }

        private static object GetStyleHierarchy(WordprocessingDocument document)
        {
            var stylePart = document.MainDocumentPart.StyleDefinitionsPart;
            if (stylePart == null)
                return null;
            var xd = stylePart.GetXDocument();
            var stylesWithPath = xd.Root
                .Elements(W.style)
                .Select(s =>
                {
                    var styleString = (string)s.Attribute(W.styleId);
                    var thisStyle = s;
                    while (true)
                    {
                        var baseStyle = (string)thisStyle.Elements(W.basedOn).Attributes(W.val).FirstOrDefault();
                        if (baseStyle == null)
                            break;
                        styleString = baseStyle + "/" + styleString;
                        thisStyle = xd.Root.Elements(W.style).FirstOrDefault(ts => ts.Attribute(W.styleId).Value == baseStyle);
                        if (thisStyle == null)
                            break;
                    }
                    return styleString;
                })
                .OrderBy(n => n)
                .ToList();
            XElement styleHierarchy = new XElement(H.StyleHierarchy);
            foreach (var item in stylesWithPath)
            {
                var styleChain = item.Split('/');
                XElement elementToAddTo = styleHierarchy;
                foreach (var inChain in styleChain.SkipLast(1))
                    elementToAddTo = elementToAddTo.Elements(H.Style).FirstOrDefault(z => z.Attribute(H.Id).Value == inChain);
                var styleToAdd = styleChain.Last();
                elementToAddTo.Add(
                    new XElement(H.Style,
                        new XAttribute(H.Id, styleChain.Last()),
                        new XAttribute(H.Type, (string)xd.Root.Elements(W.style).First(z => z.Attribute(W.styleId).Value == styleToAdd).Attribute(W.type))));
            }
            return styleHierarchy;
        }

        private static XElement GetMetricsForWmlPart(WordprocessingDocument noTrackedDocument, OpenXmlPart part, MetricsGetterSettings settings)
        {
            XElement contentControls = null;
            if (part is MainDocumentPart ||
                part is HeaderPart ||
                part is FooterPart ||
                part is FootnotesPart ||
                part is EndnotesPart)
            {
                var noTrackedPart = noTrackedDocument.GetAllParts().FirstOrDefault(p => p.Uri == part.Uri);
                if (noTrackedPart == null)
                    throw new OpenXmlPowerToolsException("Internal error");
                var xd = noTrackedPart.GetXDocument();
                contentControls = (XElement)GetContentControlsTransform(xd.Root, settings);
                if (!contentControls.HasElements)
                    contentControls = null;
            }
            var partMetrics = new XElement(H.Part,
                new XAttribute(H.ContentType, part.ContentType),
                new XAttribute(H.Uri, part.Uri.ToString()),
                contentControls);
            if (partMetrics.HasElements)
                return partMetrics;
            return null;
        }

        private static object GetContentControlsTransform(XNode node, MetricsGetterSettings settings)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                if (element == element.Document.Root)
                    return new XElement(H.ContentControls,
                        element.Nodes().Select(n => GetContentControlsTransform(n, settings)));

                if (element.Name == W.sdt)
                {
                    var tag = (string)element.Elements(W.sdtPr).Elements(W.tag).Attributes(W.val).FirstOrDefault();
                    XAttribute tagAttr = tag != null ? new XAttribute(H.Tag, tag) : null;

                    var alias = (string)element.Elements(W.sdtPr).Elements(W.alias).Attributes(W.val).FirstOrDefault();
                    XAttribute aliasAttr = alias != null ? new XAttribute(H.Alias, alias) : null;

                    var xPathAttr = new XAttribute(H.XPath, element.GetXPath());

                    var isText = element.Elements(W.sdtPr).Elements(W.text).Any();
                    var isBibliography = element.Elements(W.sdtPr).Elements(W.bibliography).Any();
                    var isCitation = element.Elements(W.sdtPr).Elements(W.citation).Any();
                    var isComboBox = element.Elements(W.sdtPr).Elements(W.comboBox).Any();
                    var isDate = element.Elements(W.sdtPr).Elements(W.date).Any();
                    var isDocPartList = element.Elements(W.sdtPr).Elements(W.docPartList).Any();
                    var isDocPartObj = element.Elements(W.sdtPr).Elements(W.docPartObj).Any();
                    var isDropDownList = element.Elements(W.sdtPr).Elements(W.dropDownList).Any();
                    var isEquation = element.Elements(W.sdtPr).Elements(W.equation).Any();
                    var isGroup = element.Elements(W.sdtPr).Elements(W.group).Any();
                    var isPicture = element.Elements(W.sdtPr).Elements(W.picture).Any();
                    var isRichText = element.Elements(W.sdtPr).Elements(W.richText).Any() ||
                        (! isText && 
                        ! isBibliography && 
                        ! isCitation && 
                        ! isComboBox && 
                        ! isDate && 
                        ! isDocPartList && 
                        ! isDocPartObj && 
                        ! isDropDownList && 
                        ! isEquation && 
                        ! isGroup && 
                        ! isPicture);
                    string type = null;
                    if (isText        ) type = "Text";
                    if (isBibliography) type = "Bibliography";
                    if (isCitation    ) type = "Citation";
                    if (isComboBox    ) type = "ComboBox";
                    if (isDate        ) type = "Date";
                    if (isDocPartList ) type = "DocPartList";
                    if (isDocPartObj  ) type = "DocPartObj";
                    if (isDropDownList) type = "DropDownList";
                    if (isEquation    ) type = "Equation";
                    if (isGroup       ) type = "Group";
                    if (isPicture     ) type = "Picture";
                    if (isRichText    ) type = "RichText";
                    var typeAttr = new XAttribute(H.Type, type);

                    return new XElement(H.ContentControl,
                        typeAttr,
                        tagAttr,
                        aliasAttr,
                        xPathAttr,
                        element.Nodes().Select(n => GetContentControlsTransform(n, settings)));
                }

                return element.Nodes().Select(n => GetContentControlsTransform(n, settings));
            }
            if (settings.IncludeTextInContentControls)
                return node;
            return null;
        }
    }

    public static class H
    {
        public static XName ActiveX = "ActiveX";
        public static XName Alias = "Alias";
        public static XName AltChunk = "AltChunk";
        public static XName Arguments = "Arguments";
        public static XName AsciiCharCount = "AsciiCharCount";
        public static XName AsciiRunCount = "AsciiRunCount";
        public static XName AverageParagraphLength = "AverageParagraphLength";
        public static XName BaselineReport = "BaselineReport";
        public static XName Batch = "Batch";
        public static XName BatchName = "BatchName";
        public static XName BatchSelector = "BatchSelector";
        public static XName CSCharCount = "CSCharCount";
        public static XName CSRunCount = "CSRunCount";
        public static XName Catalog = "Catalog";
        public static XName CatalogList = "CatalogList";
        public static XName CatalogListFile = "CatalogListFile";
        public static XName CaughtException = "CaughtException";
        public static XName Cell = "Cell";
        public static XName Column = "Column";
        public static XName Columns = "Columns";
        public static XName ComplexField = "ComplexField";
        public static XName Computer = "Computer";
        public static XName Computers = "Computers";
        public static XName ContentControl = "ContentControl";
        public static XName ContentControls = "ContentControls";
        public static XName ContentType = "ContentType";
        public static XName CustomXmlMarkup = "CustomXmlMarkup";
        public static XName DLL = "DLL";
        public static XName DefaultDialogValuesFile = "DefaultDialogValuesFile";
        public static XName DefaultValues = "DefaultValues";
        public static XName Dependencies = "Dependencies";
        public static XName DestinationDir = "DestinationDir";
        public static XName Directory = "Directory";
        public static XName DirectoryPattern = "DirectoryPattern";
        public static XName DisplayName = "DisplayName";
        public static XName DoJobQueueName = "DoJobQueueName";
        public static XName Document = "Document";
        public static XName DocumentProtection = "DocumentProtection";
        public static XName DocumentSelector = "DocumentSelector";
        public static XName DocumentType = "DocumentType";
        public static XName Documents = "Documents";
        public static XName EastAsiaCharCount = "EastAsiaCharCount";
        public static XName EastAsiaRunCount = "EastAsiaRunCount";
        public static XName ElementCount = "ElementCount";
        public static XName EmbeddedXlsx = "EmbeddedXlsx";
        public static XName Error = "Error";
        public static XName Exception = "Exception";
        public static XName Exe = "Exe";
        public static XName ExeRoot = "ExeRoot";
        public static XName Extension = "Extension";
        public static XName File = "File";
        public static XName FileLength = "FileLength";
        public static XName FileName = "FileName";
        public static XName FilePattern = "FilePattern";
        public static XName FileType = "FileType";
        public static XName Guid = "Guid";
        public static XName HAnsiCharCount = "HAnsiCharCount";
        public static XName HAnsiRunCount = "HAnsiRunCount";
        public static XName RevisionTracking = "RevisionTracking";
        public static XName Hyperlink = "Hyperlink";
        public static XName IPAddress = "IPAddress";
        public static XName Id = "Id";
        public static XName Invalid = "Invalid";
        public static XName InvalidHyperlink = "InvalidHyperlink";
        public static XName InvalidHyperlinkException = "InvalidHyperlinkException";
        public static XName InvalidSaveThroughXslt = "InvalidSaveThroughXslt";
        public static XName JobComplete = "JobComplete";
        public static XName JobExe = "JobExe";
        public static XName JobName = "JobName";
        public static XName JobSpec = "JobSpec";
        public static XName Languages = "Languages";
        public static XName LegacyFrame = "LegacyFrame";
        public static XName LocalDoJobQueue = "LocalDoJobQueue";
        public static XName MachineName = "MachineName";
        public static XName MaxConcurrentJobs = "MaxConcurrentJobs";
        public static XName MaxDocumentsInJob = "MaxDocumentsInJob";
        public static XName MaxParagraphLength = "MaxParagraphLength";
        public static XName Message = "Message";
        public static XName Metrics = "Metrics";
        public static XName MultiDirectory = "MultiDirectory";
        public static XName MultiFontRun = "MultiFontRun";
        public static XName MultiServerQueue = "MultiServerQueue";
        public static XName Name = "Name";
        public static XName Note = "Note";
        public static XName NumberingFormatList = "NumberingFormatList";
        public static XName ObjectDisposedException = "ObjectDisposedException";
        public static XName ParagraphCount = "ParagraphCount";
        public static XName Part = "Part";
        public static XName Parts = "Parts";
        public static XName PassedDocuments = "PassedDocuments";
        public static XName Path = "Path";
        public static XName ProduceCatalog = "ProduceCatalog";
        public static XName ReferenceToNullImage = "ReferenceToNullImage";
        public static XName Report = "Report";
        public static XName Root = "Root";
        public static XName RootDirectory = "RootDirectory";
        public static XName Row = "Row";
        public static XName RunCount = "RunCount";
        public static XName RunWithoutRprCount = "RunWithoutRprCount";
        public static XName SdkValidationError = "SdkValidationError";
        public static XName SdkValidationError2007 = "SdkValidationError2007";
        public static XName SdkValidationError2010 = "SdkValidationError2010";
        public static XName SdkValidationError2013 = "SdkValidationError2013";
        public static XName Sheet = "Sheet";
        public static XName Sheets = "Sheets";
        public static XName SimpleField = "SimpleField";
        public static XName Skip = "Skip";
        public static XName SmartTag = "SmartTag";
        public static XName SourceRootDir = "SourceRootDir";
        public static XName SpawnerJobExeLocation = "SpawnerJobExeLocation";
        public static XName SpawnerReady = "SpawnerReady";
        public static XName Style = "Style";
        public static XName StyleHierarchy = "StyleHierarchy";
        public static XName SubDocument = "SubDocument";
        public static XName Table = "Table";
        public static XName TableData = "TableData";
        public static XName Tag = "Tag";
        public static XName Take = "Take";
        public static XName TextBox = "TextBox";
        public static XName TrackRevisionsEnabled = "TrackRevisionsEnabled";
        public static XName Type = "Type";
        public static XName Uri = "Uri";
        public static XName Val = "Val";
        public static XName Valid = "Valid";
        public static XName WindowStyle = "WindowStyle";
        public static XName XPath = "XPath";
        public static XName ZeroLengthText = "ZeroLengthText";
        public static XName custDataLst = "custDataLst";
        public static XName custShowLst = "custShowLst";
        public static XName kinsoku = "kinsoku";
        public static XName modifyVerifier = "modifyVerifier";
        public static XName photoAlbum = "photoAlbum";
    }
}
