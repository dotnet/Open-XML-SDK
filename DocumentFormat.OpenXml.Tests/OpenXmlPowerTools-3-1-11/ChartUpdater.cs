using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DocumentFormat.OpenXml.Packaging;
using OpenXmlPowerTools;

namespace OpenXmlPowerTools
{
    public enum ChartDataType
    {
        Number,
        String,
        DateTime,
    }

    // Format Codes
    // 0 - general
    // 1 - 0
    // 2 - 0.00
    // 3 - #,##0
    // 4 - #,##0.00
    // 9 - 0%
    // 10 - 0.00%
    // 11 - 0.00E+00
    // 12 - # ?/?
    // 13 - # ??/??
    // 14 - mm-dd-yy
    // 15 - d-mmm-yy
    // 16 - d-mmm
    // 17 - mmm-yy
    // 18 - h:mm AM/PM
    // 19 - h:mm:ss AM/PM
    // 20 - h:mm
    // 21 - h:mm:ss
    // 22 - m/d/yy h:mm
    // 37 - #,##0 ;(#,##0)
    // 38 - #,##0 ;[Red](#,##0)
    // 39 - #,##0.00;(#,##0.00)
    // 40 - #,##0.00;[Red](#,##0.00)
    // 45 - mm:ss
    // 46 - [h]:mm:ss
    // 47 - mmss.0
    // 48 - ##0.0E+0
    // 49 - @

    public class ChartData
    {
        public string[] SeriesNames;

        public ChartDataType CategoryDataType;
        public int CategoryFormatCode;
        public string[] CategoryNames;

        public double[][] Values;
    }

    public class ChartUpdater
    {
        public static bool UpdateChart(WordprocessingDocument wDoc, string contentControlTag, ChartData chartData)
        {
            var mainDocumentPart = wDoc.MainDocumentPart;
            var mdXDoc = mainDocumentPart.GetXDocument();
            var cc = mdXDoc.Descendants(W.sdt)
                .FirstOrDefault(sdt => (string)sdt.Elements(W.sdtPr).Elements(W.tag).Attributes(W.val).FirstOrDefault() == contentControlTag);
            if (cc != null)
            {
                var chartRid = (string)cc.Descendants(C.chart).Attributes(R.id).FirstOrDefault();
                if (chartRid != null)
                {
                    ChartPart chartPart = (ChartPart)mainDocumentPart.GetPartById(chartRid);
                    UpdateChart(chartPart, chartData);
                    var newContent = cc.Elements(W.sdtContent).Elements().Select(e => new XElement(e));
                    cc.ReplaceWith(newContent);
                    mainDocumentPart.PutXDocument();
                    return true;
                }
            }
            return false;
        }

        public static void UpdateChart(ChartPart chartPart, ChartData chartData)
        {
            if (chartData.Values.Length != chartData.SeriesNames.Length)
                throw new ArgumentException("Invalid chart data");
            foreach (var ser in chartData.Values)
            {
                if (ser.Length != chartData.CategoryNames.Length)
                    throw new ArgumentException("Invalid chart data");
            }

            UpdateSeries(chartPart, chartData);
        }

        private static Dictionary<int, string> FormatCodes = new Dictionary<int, string>()
        {
            { 0, "general" },
            { 1, "0" },
            { 2, "0.00" },
            { 3, "#,##0" },
            { 4, "#,##0.00" },
            { 9, "0%" },
            { 10, "0.00%" },
            { 11, "0.00E+00" },
            { 12, "# ?/?" },
            { 13, "# ??/??" },
            { 14, "mm-dd-yy" },
            { 15, "d-mmm-yy" },
            { 16, "d-mmm" },
            { 17, "mmm-yy" },
            { 18, "h:mm AM/PM" },
            { 19, "h:mm:ss AM/PM" },
            { 20, "h:mm" },
            { 21, "h:mm:ss" },
            { 22, "m/d/yy h:mm" },
            { 37, "#,##0 ;(#,##0)" },
            { 38, "#,##0 ;[Red](#,##0)" },
            { 39, "#,##0.00;(#,##0.00)" },
            { 40, "#,##0.00;[Red](#,##0.00)" },
            { 45, "mm:ss" },
            { 46, "[h]:mm:ss" },
            { 47, "mmss.0" },
            { 48, "##0.0E+0" },
            { 49, "@" },
        };

        private static void UpdateSeries(ChartPart chartPart, ChartData chartData)
        {
            UpdateEmbeddedWorkbook(chartPart, chartData);

            XDocument cpXDoc = chartPart.GetXDocument();
            XElement root = cpXDoc.Root;
            var firstSeries = root.Descendants(C.ser).FirstOrDefault();
            var numRef = firstSeries.Elements(C.val).Elements(C.numRef).FirstOrDefault();
            string sheetName = null;
            var f = (string)firstSeries.Descendants(C.f).FirstOrDefault();
            if (f != null)
                sheetName = f.Split('!')[0];

            // remove all but first series
            XName chartType = firstSeries.Parent.Name;
            firstSeries.Parent.Elements(C.ser).Skip(1).Remove();

            var newSetOfSeries = chartData.SeriesNames
                .Select((string sn, int si) =>
                {
                    XElement cat = null;

                    var oldCat = firstSeries.Elements(C.cat).FirstOrDefault();
                    if (oldCat == null)
                        throw new OpenXmlPowerToolsException("Invalid chart markup");

                    var catHasFormula = oldCat.Descendants(C.f).Any();
                    if (catHasFormula)
                    {
                        XElement newFormula = null;
                        if (sheetName != null)
                            newFormula = new XElement(C.f, string.Format("{0}!$A$2:$A${1}", sheetName, chartData.CategoryNames.Length + 1));
                        if (chartData.CategoryDataType == ChartDataType.String)
                        {
                            cat = new XElement(C.cat,
                                new XElement(C.strRef,
                                    newFormula,
                                    new XElement(C.strCache,
                                        new XElement(C.ptCount, new XAttribute("val", chartData.CategoryNames.Length)),
                                        chartData.CategoryNames.Select((string cn, int ci) =>
                                        {
                                            var newPt = new XElement(C.pt,
                                                new XAttribute("idx", ci),
                                                new XElement(C.v, chartData.CategoryNames[ci]));
                                            return newPt;
                                        }))));
                        }
                        else
                        {
                            cat = new XElement(C.cat,
                                new XElement(C.numRef,
                                    newFormula,
                                    new XElement(C.numCache,
                                        new XElement(C.formatCode, FormatCodes[chartData.CategoryFormatCode]),
                                        new XElement(C.ptCount, new XAttribute("val", chartData.CategoryNames.Length)),
                                        chartData.CategoryNames.Select((string cn, int ci) =>
                                        {
                                            var newPt = new XElement(C.pt,
                                                new XAttribute("idx", ci),
                                                new XElement(C.v, chartData.CategoryNames[ci]));
                                            return newPt;
                                        }))));
                        }
                    }
                    else
                    {
                        if (chartData.CategoryDataType == ChartDataType.String)
                        {
                            cat = new XElement(C.cat,
                                new XElement(C.strLit,
                                    new XElement(C.ptCount, new XAttribute("val", chartData.CategoryNames.Length)),
                                    chartData.CategoryNames.Select((string cn, int ci) =>
                                    {
                                        var newPt = new XElement(C.pt,
                                            new XAttribute("idx", ci),
                                            new XElement(C.v, chartData.CategoryNames[ci]));
                                        return newPt;
                                    })));
                        }
                        else
                        {
                            cat = new XElement(C.cat,
                                new XElement(C.numLit,
                                    new XElement(C.ptCount, new XAttribute("val", chartData.CategoryNames.Length)),
                                    chartData.CategoryNames.Select((string cn, int ci) =>
                                    {
                                        var newPt = new XElement(C.pt,
                                            new XAttribute("idx", ci),
                                            new XElement(C.v, chartData.CategoryNames[ci]));
                                        return newPt;
                                    })));
                        }
                    }

                    XElement newCval = null;

                    if (sheetName == null)
                    {
                        newCval = new XElement(C.val,
                                new XElement(C.numLit,
                                    new XElement(C.ptCount, new XAttribute("val", chartData.CategoryNames.Length)),
                                    chartData.CategoryNames.Select((string cn, int ci) =>
                                    {
                                        var newPt = new XElement(C.pt,
                                            new XAttribute("idx", ci),
                                            new XElement(C.v, chartData.Values[si][ci]));
                                        return newPt;
                                    })));
                    }
                    else
                    {
                        newCval = new XElement(C.val,
                                new XElement(C.numRef,
                                    sheetName != null ?
                                        new XElement(C.f, string.Format("{0}!${2}$2:${2}${1}", sheetName, chartData.CategoryNames.Length + 1, SpreadsheetMLUtil.IntToColumnId(si + 1))) : null,
                                    new XElement(C.numCache,
                                        sheetName != null ? numRef.Descendants(C.formatCode) : null,
                                        new XElement(C.ptCount, new XAttribute("val", chartData.CategoryNames.Length)),
                                        chartData.CategoryNames.Select((string cn, int ci) =>
                                        {
                                            var newPt = new XElement(C.pt,
                                                new XAttribute("idx", ci),
                                                new XElement(C.v, chartData.Values[si][ci]));
                                            return newPt;
                                        }))));
                    }

                    var serHasFormula = firstSeries.Descendants(C.f).Any();
                    XElement tx = null;
                    if (serHasFormula)
                    {
                        XElement newFormula = null;
                        if (sheetName != null)
                            newFormula = new XElement(C.f, string.Format("{0}!${1}$1", sheetName, SpreadsheetMLUtil.IntToColumnId(si + 1)));
                        tx = new XElement(C.tx,
                            new XElement(C.strRef,
                                newFormula,
                                new XElement(C.strCache,
                                    new XElement(C.ptCount, new XAttribute("val", 1)),
                                    new XElement(C.pt,
                                        new XAttribute("idx", 0),
                                        new XElement(C.v, chartData.SeriesNames[si])))));
                    }
                    else
                    {
                        tx = new XElement(C.tx,
                            new XElement(C.v, chartData.SeriesNames[si]));
                    }

                    XElement newSer = null;

                    if (chartType == C.area3DChart || chartType == C.areaChart)
                    {
                        newSer = new XElement(C.ser,
                            // common
                            new XElement(C.idx, new XAttribute("val", si)),
                            new XElement(C.order, new XAttribute("val", si)),
                            tx,
                            firstSeries.Elements(C.spPr),

                            // CT_AreaSer
                            firstSeries.Elements(C.pictureOptions),
                            firstSeries.Elements(C.dPt),
                            firstSeries.Elements(C.dLbls),
                            firstSeries.Elements(C.trendline),
                            firstSeries.Elements(C.errBars),
                            cat,
                            newCval,
                            firstSeries.Elements(C.extLst));
                    }
                    else if (chartType == C.bar3DChart || chartType == C.barChart)
                    {
                        newSer = new XElement(C.ser,
                            // common
                            new XElement(C.idx, new XAttribute("val", si)),
                            new XElement(C.order, new XAttribute("val", si)),
                            tx,
                            firstSeries.Elements(C.spPr),

                            // CT_BarSer
                            firstSeries.Elements(C.invertIfNegative),
                            firstSeries.Elements(C.pictureOptions),
                            firstSeries.Elements(C.dPt),
                            firstSeries.Elements(C.dLbls),
                            firstSeries.Elements(C.trendline),
                            firstSeries.Elements(C.errBars),
                            cat,
                            newCval,
                            firstSeries.Elements(C.shape),
                            firstSeries.Elements(C.extLst));
                    }
                    else if (chartType == C.line3DChart || chartType == C.lineChart || chartType == C.stockChart)
                    {
                        newSer = new XElement(C.ser,
                            // common
                            new XElement(C.idx, new XAttribute("val", si)),
                            new XElement(C.order, new XAttribute("val", si)),
                            tx,
                            firstSeries.Elements(C.spPr),

                            // CT_LineSer
                            firstSeries.Elements(C.marker),
                            firstSeries.Elements(C.dPt),
                            firstSeries.Elements(C.dLbls),
                            firstSeries.Elements(C.trendline),
                            firstSeries.Elements(C.errBars),
                            cat,
                            newCval,
                            firstSeries.Elements(C.smooth),
                            firstSeries.Elements(C.extLst));
                    }
                    else if (chartType == C.doughnutChart || chartType == C.ofPieChart || chartType == C.pie3DChart || chartType == C.pieChart)
                    {
                        newSer = new XElement(C.ser,
                            // common
                            new XElement(C.idx, new XAttribute("val", si)),
                            new XElement(C.order, new XAttribute("val", si)),
                            tx,
                            firstSeries.Elements(C.spPr),

                            // CT_PieSer
                            firstSeries.Elements(C.explosion),
                            firstSeries.Elements(C.dPt),
                            firstSeries.Elements(C.dLbls),
                            cat,
                            newCval,
                            firstSeries.Elements(C.extLst));
                    }
                    else if (chartType == C.surface3DChart || chartType == C.surfaceChart)
                    {
                        newSer = new XElement(C.ser,
                            // common
                            new XElement(C.idx, new XAttribute("val", si)),
                            new XElement(C.order, new XAttribute("val", si)),
                            tx,
                            firstSeries.Elements(C.spPr),

                            // CT_SurfaceSer
                            cat,
                            newCval,
                            firstSeries.Elements(C.extLst));
                    }

                    if (newSer == null)
                        throw new OpenXmlPowerToolsException("Unsupported chart type");

                    int accentNumber = (si % 6) + 1;
                    newSer = (XElement)UpdateAccentTransform(newSer, accentNumber);
                    return newSer;
                });
            firstSeries.ReplaceWith(newSetOfSeries);
            chartPart.PutXDocument();
        }

        private static void UpdateEmbeddedWorkbook(ChartPart chartPart, ChartData chartData)
        {
            XDocument cpXDoc = chartPart.GetXDocument();
            XElement root = cpXDoc.Root;
            var firstSeries = root.Descendants(C.ser).FirstOrDefault();
            if (firstSeries == null)
                return;
            var firstFormula = (string)firstSeries.Descendants(C.f).FirstOrDefault();
            if (firstFormula == null)
                return;
            var sheet = firstFormula.Split('!')[0];
            var embeddedSpreadsheetRid = (string)root.Descendants(C.externalData).Attributes(R.id).FirstOrDefault();
            if (embeddedSpreadsheetRid == null)
                return;
            var embeddedSpreadsheet = chartPart.GetPartById(embeddedSpreadsheetRid);
            if (embeddedSpreadsheet != null)
            {
                using (SpreadsheetDocument sDoc = SpreadsheetDocument.Open(embeddedSpreadsheet.GetStream(), true))
                {
                    var workbookPart = sDoc.WorkbookPart;
                    var wbRoot = workbookPart.GetXDocument().Root;
                    var sheetRid = (string)wbRoot
                        .Elements(S.sheets)
                        .Elements(S.sheet)
                        .Where(s => (string)s.Attribute("name") == sheet)
                        .Attributes(R.id)
                        .FirstOrDefault();
                    if (sheetRid != null)
                    {
                        var sheetPart = workbookPart.GetPartById(sheetRid);
                        var xdSheet = sheetPart.GetXDocument();
                        var sheetData = xdSheet.Descendants(S.sheetData).FirstOrDefault();

                        var stylePart = workbookPart.WorkbookStylesPart;
                        var xdStyle = stylePart.GetXDocument();

                        int categoryStyleId = 0;
                        if (chartData.CategoryFormatCode != 0)
                            categoryStyleId = AddDxfToDxfs(xdSheet, xdStyle, chartData.CategoryFormatCode);
                        stylePart.PutXDocument();

                        var firstRow = new XElement(S.row,
                            new XAttribute("r", "1"),
                            new XAttribute("spans", string.Format("1:{0}", chartData.SeriesNames.Length + 1)),
                            new [] { new XElement(S.c,
                                new XAttribute("r", "A1"),
                                new XAttribute("t", "str"),
                                new XElement(S.v,
                                    new XAttribute(XNamespace.Xml + "space", "preserve"),
                                    " "))}
                                .Concat(
                                    chartData.SeriesNames
                                        .Select((sn, i) => new XElement(S.c,
                                            new XAttribute("r", RowColToString(0, i + 1)),
                                            new XAttribute("t", "str"),
                                            new XElement(S.v, sn)))));
                        var otherRows = chartData
                            .CategoryNames
                            .Select((cn, r) =>
                            {
                                var row = new XElement(S.row,
                                    new XAttribute("r", r + 2),
                                    new XAttribute("spans", string.Format("1:{0}", chartData.SeriesNames.Length + 1)),
                                    new[] {
                                        new XElement(S.c,
                                            new XAttribute("r", RowColToString(r + 1, 0)),
                                            categoryStyleId != 0 ? new XAttribute("s", categoryStyleId) : null,
                                            chartData.CategoryDataType == ChartDataType.String ? new XAttribute("t", "str") : null,
                                            new XElement(S.v, cn))
                                    }.Concat(
                                        Enumerable.Range(0, chartData.Values.Length)
                                            .Select((c, ci) =>
                                            {
                                                var cell = new XElement(S.c,
                                                    new XAttribute("r", RowColToString(r + 1, ci + 1)),
                                                    new XElement(S.v, chartData.Values[ci][r]));
                                                return cell;
                                            })));
                                return row;
                            });
                        var allRows = new[] {
                            firstRow
                        }.Concat(otherRows);
                        var newSheetData = new XElement(S.sheetData,
                            allRows);
                        sheetData.ReplaceWith(newSheetData);
                        sheetPart.PutXDocument();

                        var tablePartRid = (string)xdSheet
                            .Root
                            .Elements(S.tableParts)
                            .Elements(S.tablePart)
                            .Attributes(R.id)
                            .FirstOrDefault();
                        if (tablePartRid != null)
                        {
                            var partTable = sheetPart.GetPartById(tablePartRid);
                            var xdTablePart = partTable.GetXDocument();
                            var xaRef = xdTablePart.Root.Attribute("ref");
                            xaRef.Value = string.Format("A1:{0}", RowColToString(chartData.CategoryNames.Length - 1, chartData.SeriesNames.Length));
                            var xeNewTableColumns = new XElement(S.tableColumns,
                                new XAttribute("count", chartData.SeriesNames.Count() + 1),
                                new[] {
                                    new XElement(S.tableColumn,
                                        new XAttribute("id", 1),
                                        new XAttribute("name", " "))
                                }.Concat(
                                    chartData.SeriesNames.Select((cn, ci) =>
                                        new XElement(S.tableColumn,
                                            new XAttribute("id", ci + 2),
                                            new XAttribute("name", cn)))));
                            var xeExistingTableColumns = xdTablePart.Root.Element(S.tableColumns);
                            if (xeExistingTableColumns != null)
                                xeExistingTableColumns.ReplaceWith(xeNewTableColumns);
                            partTable.PutXDocument();
                        }
                    }
                }
            }
        }

        private static int AddDxfToDxfs(XDocument xdSheet, XDocument xdStyle, int formatCodeToAdd)
        {
            // add xf to cellXfs
            var cellXfs = xdStyle
                .Root
                .Element(S.cellXfs);
            if (cellXfs == null)
            {
                var cellStyleXfs = xdStyle
                    .Root
                    .Element(S.cellStyleXfs);
                if (cellStyleXfs != null)
                {
                    cellStyleXfs.AddAfterSelf(
                        new XElement(S.cellXfs,
                            new XAttribute("count", 0)));
                    cellXfs = xdSheet
                        .Root
                        .Element(S.cellXfs);
                }
            }
            if (cellXfs == null)
            {
                var borders = xdStyle
                    .Root
                    .Element(S.borders);
                if (borders != null)
                {
                    borders.AddAfterSelf(
                        new XElement(S.cellXfs,
                            new XAttribute("count", 0)));
                    cellXfs = xdSheet
                        .Root
                        .Element(S.cellXfs);
                }
            }
            if (cellXfs == null)
                throw new OpenXmlPowerToolsException("Internal error");

            var cnt = (int)cellXfs.Attribute("count");
            cnt++;
            cellXfs.Attribute("count").Value = cnt.ToString();
            cellXfs.Add(
                new XElement(S.xf,
                    new XAttribute("numFmtId", formatCodeToAdd),
                    new XAttribute("fontId", 0),
                    new XAttribute("fillId", 0),
                    new XAttribute("borderId", 0),
                    new XAttribute("applyNumberFormat", 1)));
            return cnt - 1;
        }

        private static string RowColToString(int row, int col)
        {
            var str = SpreadsheetMLUtil.IntToColumnId(col) + (row + 1).ToString();
            return str;
        }

        private static object UpdateAccentTransform(XNode node, int accentNumber)
        {
            XElement element = node as XElement;
            if (element != null)
            {
                if (element.Name == A.schemeClr && (string)element.Attribute("val") == "accent1")
                    return new XElement(A.schemeClr, new XAttribute("val", "accent" + accentNumber));

                return new XElement(element.Name,
                    element.Attributes(),
                    element.Nodes().Select(n => UpdateAccentTransform(n, accentNumber)));
            }
            return node;
        }

        public static bool UpdateChart(PresentationDocument pDoc, int slideNumber, ChartData chartData)
        {
            var presentationPart = pDoc.PresentationPart;
            var pXDoc = presentationPart.GetXDocument();
            var sldIdElement = pXDoc.Root.Elements(P.sldIdLst).Elements(P.sldId).Skip(slideNumber - 1).FirstOrDefault();
            if (sldIdElement != null)
            {
                var rId = (string)sldIdElement.Attribute(R.id);
                var slidePart = presentationPart.GetPartById(rId);
                var sXDoc = slidePart.GetXDocument();
                var chartRid = (string)sXDoc.Descendants(C.chart).Attributes(R.id).FirstOrDefault();
                if (chartRid != null)
                {
                    ChartPart chartPart = (ChartPart)slidePart.GetPartById(chartRid);
                    UpdateChart(chartPart, chartData);
                    return true;
                }
                return true;
            }
            return false;
        }
    }
}