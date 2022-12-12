// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;

using A = DocumentFormat.OpenXml.Drawing;
using C = DocumentFormat.OpenXml.Drawing.Charts;
using C16 = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Cs = DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
using P14 = DocumentFormat.OpenXml.Office2010.PowerPoint;

#pragma warning disable CA1303 // Do not pass literals as localized parameters

namespace CreatePresentationDocument
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var filepath = @"./sunburst_presentation.pptx";
            CreatePresentation(filepath);
        }

        public static void CreatePresentation(string filepath)
        {
            // Create a presentation at a specified file path. The presentation document type is pptx, by default.
            var presentationDoc = PresentationDocument.Create(filepath, PresentationDocumentType.Presentation);
            var presentationPart = presentationDoc.AddPresentationPart();
            presentationPart.Presentation = new Presentation();

            CreatePresentationParts(presentationPart);

            // Close the presentation handle
            presentationDoc.Close();
        }

        private static void CreatePresentationParts(PresentationPart presentationPart)
        {
            var slideMasterIdList1 = new SlideMasterIdList(new SlideMasterId() { Id = (UInt32Value)2147483648U, RelationshipId = "rId1" });
            var slideIdList1 = new SlideIdList(new SlideId() { Id = (UInt32Value)256U, RelationshipId = "rId2" });
            var slideSize1 = new SlideSize() { Cx = 9144000, Cy = 6858000, Type = SlideSizeValues.Screen4x3 };
            var notesSize1 = new NotesSize() { Cx = 6858000, Cy = 9144000 };
            var defaultTextStyle1 = new DefaultTextStyle();

            presentationPart.Presentation.Append(slideMasterIdList1, slideIdList1, slideSize1, notesSize1, defaultTextStyle1);

            SlidePart slidePart1;
            SlideLayoutPart slideLayoutPart1;
            SlideMasterPart slideMasterPart1;
            ThemePart themePart1;

            slidePart1 = CreateSlidePart(presentationPart);
            slideLayoutPart1 = CreateSlideLayoutPart(slidePart1);
            slideMasterPart1 = CreateSlideMasterPart(slideLayoutPart1);
            themePart1 = CreateTheme(slideMasterPart1);

            slideMasterPart1.AddPart(slideLayoutPart1, "rId1");
            presentationPart.AddPart(slideMasterPart1, "rId1");
            presentationPart.AddPart(themePart1, "rId5");

            var imagePart1 = slidePart1.AddNewPart<ImagePart>("image/png", "rId3");
            GenerateImagePart1Content(imagePart1);

            // This is the generation of the new Sunburst ChartPart
            var chartPart1 = slidePart1.AddNewPart<ExtendedChartPart>("rId2");
            GenerateExtendedChartPart1Content(chartPart1);

            var embeddedPackagePart1 = chartPart1.AddNewPart<EmbeddedPackagePart>("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "rId3");
            GenerateEmbeddedPackagePart1Content(embeddedPackagePart1);

            var chartColorStylePart1 = chartPart1.AddNewPart<ChartColorStylePart>("rId2");
            GenerateChartColorStylePart1Content(chartColorStylePart1);

            var chartStylePart1 = chartPart1.AddNewPart<ChartStylePart>("rId1");
            GenerateChartStylePart1Content(chartStylePart1);
        }

        private static void GenerateExtendedChartPart1Content(ExtendedChartPart chartPart1)
        {
            var chartSpace1 = new C16.ChartSpace();
            chartSpace1.AddNamespaceDeclaration("cx", "http://schemas.microsoft.com/office/drawing/2014/chartex");
            chartSpace1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            chartSpace1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");

            var chartdata1 = new C16.ChartData();
            var externalData1 = new C16.ExternalData() { Id = "rId3", AutoUpdate = false };
            chartdata1.Append(externalData1);
            var data1 = new C16.Data { Id = 0 };
            var strDim1 = new C16.StringDimension { Type = C16.StringDimensionType.Cat };
            var lvl1 = new C16.NumericLevel { PtCount = 16 };
            lvl1.AppendChild(new C16.ChartStringValue("Leaf 1") { Index = 0 });
            lvl1.AppendChild(new C16.ChartStringValue("Leaf 2") { Index = 1 });
            lvl1.AppendChild(new C16.ChartStringValue("Leaf 3") { Index = 2 });
            lvl1.AppendChild(new C16.ChartStringValue("Leaf 4") { Index = 3 });
            lvl1.AppendChild(new C16.ChartStringValue("Leaf 5") { Index = 4 });
            lvl1.AppendChild(new C16.ChartStringValue("Leaf 8") { Index = 7 });
            lvl1.AppendChild(new C16.ChartStringValue("Leaf 10") { Index = 9 });
            lvl1.AppendChild(new C16.ChartStringValue("Leaf 11") { Index = 10 });
            lvl1.AppendChild(new C16.ChartStringValue("Leaf 12") { Index = 11 });
            lvl1.AppendChild(new C16.ChartStringValue("Leaf 13") { Index = 12 });
            lvl1.AppendChild(new C16.ChartStringValue("Leaf 14") { Index = 13 });
            lvl1.AppendChild(new C16.ChartStringValue("Leaf 15") { Index = 14 });

            var lvl2 = new C16.NumericLevel { PtCount = 16 };
            lvl2.AppendChild(new C16.ChartStringValue("Stem 1") { Index = 0 });
            lvl2.AppendChild(new C16.ChartStringValue("Stem 1") { Index = 1 });
            lvl2.AppendChild(new C16.ChartStringValue("Stem 1") { Index = 2 });
            lvl2.AppendChild(new C16.ChartStringValue("Stem 2") { Index = 3 });
            lvl2.AppendChild(new C16.ChartStringValue("Stem 2") { Index = 4 });
            lvl2.AppendChild(new C16.ChartStringValue("Stem 6") { Index = 5 });
            lvl2.AppendChild(new C16.ChartStringValue("Stem 7") { Index = 6 });
            lvl2.AppendChild(new C16.ChartStringValue("Stem 3") { Index = 7 });
            lvl2.AppendChild(new C16.ChartStringValue("Stem 9") { Index = 8 });
            lvl2.AppendChild(new C16.ChartStringValue("Stem 4") { Index = 9 });
            lvl2.AppendChild(new C16.ChartStringValue("Stem 4") { Index = 10 });
            lvl2.AppendChild(new C16.ChartStringValue("Stem 5") { Index = 11 });
            lvl2.AppendChild(new C16.ChartStringValue("Stem 5") { Index = 12 });
            lvl2.AppendChild(new C16.ChartStringValue("Stem 6") { Index = 13 });
            lvl2.AppendChild(new C16.ChartStringValue("Stem 6") { Index = 14 });
            lvl2.AppendChild(new C16.ChartStringValue("Stem 16") { Index = 15 });

            var lvl3 = new C16.NumericLevel { PtCount = 16 };
            lvl3.AppendChild(new C16.ChartStringValue("Branch 1") { Index = 0 });
            lvl3.AppendChild(new C16.ChartStringValue("Branch 1") { Index = 1 });
            lvl3.AppendChild(new C16.ChartStringValue("Branch 1") { Index = 2 });
            lvl3.AppendChild(new C16.ChartStringValue("Branch 1") { Index = 3 });
            lvl3.AppendChild(new C16.ChartStringValue("Branch 1") { Index = 4 });
            lvl3.AppendChild(new C16.ChartStringValue("Branch 1") { Index = 5 });
            lvl3.AppendChild(new C16.ChartStringValue("Branch 1") { Index = 6 });
            lvl3.AppendChild(new C16.ChartStringValue("Branch 2") { Index = 7 });
            lvl3.AppendChild(new C16.ChartStringValue("Branch 2") { Index = 8 });
            lvl3.AppendChild(new C16.ChartStringValue("Branch 2") { Index = 9 });
            lvl3.AppendChild(new C16.ChartStringValue("Branch 2") { Index = 10 });
            lvl3.AppendChild(new C16.ChartStringValue("Branch 3") { Index = 11 });
            lvl3.AppendChild(new C16.ChartStringValue("Branch 3") { Index = 12 });
            lvl3.AppendChild(new C16.ChartStringValue("Branch 3") { Index = 13 });
            lvl3.AppendChild(new C16.ChartStringValue("Branch 3") { Index = 14 });
            lvl3.AppendChild(new C16.ChartStringValue("Branch 5") { Index = 15 });
            strDim1.AppendChild(new C16.Formula("Sheet1!$A$2:$C$17"));
            strDim1.AppendChild(lvl1);
            strDim1.AppendChild(lvl2);
            strDim1.AppendChild(lvl3);

            var numDim1 = new C16.NumericDimension { Type = C16.NumericDimensionType.Size };
            var lvl4 = new C16.NumericLevel { PtCount = 16, FormatCode = "General" };
            lvl4.AppendChild(new C16.ChartStringValue("22") { Index = 0 });
            lvl4.AppendChild(new C16.ChartStringValue("12") { Index = 1 });
            lvl4.AppendChild(new C16.ChartStringValue("18") { Index = 2 });
            lvl4.AppendChild(new C16.ChartStringValue("87") { Index = 3 });
            lvl4.AppendChild(new C16.ChartStringValue("88") { Index = 4 });
            lvl4.AppendChild(new C16.ChartStringValue("17") { Index = 5 });
            lvl4.AppendChild(new C16.ChartStringValue("14") { Index = 6 });
            lvl4.AppendChild(new C16.ChartStringValue("25") { Index = 7 });
            lvl4.AppendChild(new C16.ChartStringValue("16") { Index = 8 });
            lvl4.AppendChild(new C16.ChartStringValue("24") { Index = 9 });
            lvl4.AppendChild(new C16.ChartStringValue("89") { Index = 10 });
            lvl4.AppendChild(new C16.ChartStringValue("16") { Index = 11 });
            lvl4.AppendChild(new C16.ChartStringValue("19") { Index = 12 });
            lvl4.AppendChild(new C16.ChartStringValue("86") { Index = 13 });
            lvl4.AppendChild(new C16.ChartStringValue("23") { Index = 14 });
            lvl4.AppendChild(new C16.ChartStringValue("21") { Index = 15 });
            numDim1.AppendChild(new C16.Formula("Sheet1!$D$2:$D$17"));
            numDim1.AppendChild(lvl4);
            data1.AppendChild(strDim1);
            data1.AppendChild(numDim1);
            chartdata1.AppendChild(data1);

            var chart1 = new C16.Chart();

            var title1 = new C16.ChartTitle { Overlay = false, Align = C16.PosAlign.Ctr, Pos = C16.SidePos.T };
            chart1.AppendChild(title1);

            var plotArea1 = new C16.PlotArea();
            var plotAreaRegion1 = new C16.PlotAreaRegion();
            var series1 = new C16.Series { LayoutId = C16.SeriesLayout.Sunburst };
            var text1 = new C16.Text();
            var textData1 = new C16.TextData();
            var formula1 = new C16.Formula("Sheet1!$D$1");
            var vxsdstring1 = new C16.VXsdstring("Series1");
            textData1.AppendChild(formula1);
            textData1.AppendChild(vxsdstring1);
            text1.AppendChild(textData1);

            var dataLabels1 = new C16.DataLabels { Pos = C16.DataLabelPos.Ctr };
            var dlvisibilities1 = new C16.DataLabelVisibilities { SeriesName = false, CategoryName = true, Value = false };
            var dataId1 = new C16.DataId { Val = 0 };
            dataLabels1.AppendChild(dlvisibilities1);
            series1.AppendChild(text1);
            series1.AppendChild(dataLabels1);
            series1.AppendChild(dataId1);
            plotAreaRegion1.AppendChild(series1);
            plotArea1.AppendChild(plotAreaRegion1);
            chart1.AppendChild(plotArea1);
            chartSpace1.AppendChild(chartdata1);
            chartSpace1.AppendChild(chart1);

            chartPart1.ChartSpace = chartSpace1;
        }

        // Generates content of embeddedPackagePart1.
        private static void GenerateEmbeddedPackagePart1Content(EmbeddedPackagePart embeddedPackagePart1)
        {
            using (var data = GetBinaryDataStream(embeddedPackagePart1Data))
            {
                embeddedPackagePart1.FeedData(data);
            }
        }

        // Generates content of chartStylePart1.
        private static void GenerateChartStylePart1Content(ChartStylePart chartStylePart1)
        {
            var chartStyle1 = new Cs.ChartStyle() { Id = (UInt32Value)381U };
            chartStyle1.AddNamespaceDeclaration("cs", "http://schemas.microsoft.com/office/drawing/2012/chartStyle");
            chartStyle1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            var axisTitle1 = new Cs.AxisTitle();
            var lineReference1 = new Cs.LineReference() { Index = (UInt32Value)0U };
            var fillReference1 = new Cs.FillReference() { Index = (UInt32Value)0U };
            var effectReference1 = new Cs.EffectReference() { Index = (UInt32Value)0U };

            var fontReference1 = new Cs.FontReference() { Index = A.FontCollectionIndexValues.Minor };

            var schemeColor25 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };
            var luminanceModulation15 = new A.LuminanceModulation() { Val = 65000 };
            var luminanceOffset11 = new A.LuminanceOffset() { Val = 35000 };

            schemeColor25.Append(luminanceModulation15);
            schemeColor25.Append(luminanceOffset11);

            fontReference1.Append(schemeColor25);
            var textCharacterPropertiesType1 = new Cs.TextCharacterPropertiesType() { FontSize = 1197 };

            axisTitle1.Append(lineReference1);
            axisTitle1.Append(fillReference1);
            axisTitle1.Append(effectReference1);
            axisTitle1.Append(fontReference1);
            axisTitle1.Append(textCharacterPropertiesType1);

            var categoryAxis2 = new Cs.CategoryAxis();
            var lineReference2 = new Cs.LineReference() { Index = (UInt32Value)0U };
            var fillReference2 = new Cs.FillReference() { Index = (UInt32Value)0U };
            var effectReference2 = new Cs.EffectReference() { Index = (UInt32Value)0U };

            var fontReference2 = new Cs.FontReference() { Index = A.FontCollectionIndexValues.Minor };

            var schemeColor26 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };
            var luminanceModulation16 = new A.LuminanceModulation() { Val = 65000 };
            var luminanceOffset12 = new A.LuminanceOffset() { Val = 35000 };

            schemeColor26.Append(luminanceModulation16);
            schemeColor26.Append(luminanceOffset12);

            fontReference2.Append(schemeColor26);

            var shapeProperties3 = new Cs.ShapeProperties();

            var outline10 = new A.Outline() { Width = 9525, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            var solidFill19 = new A.SolidFill();

            var schemeColor27 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };
            var luminanceModulation17 = new A.LuminanceModulation() { Val = 15000 };
            var luminanceOffset13 = new A.LuminanceOffset() { Val = 85000 };

            schemeColor27.Append(luminanceModulation17);
            schemeColor27.Append(luminanceOffset13);

            solidFill19.Append(schemeColor27);
            var round4 = new A.Round();

            outline10.Append(solidFill19);
            outline10.Append(round4);

            shapeProperties3.Append(outline10);
            var textCharacterPropertiesType2 = new Cs.TextCharacterPropertiesType() { FontSize = 1197 };

            categoryAxis2.Append(lineReference2);
            categoryAxis2.Append(fillReference2);
            categoryAxis2.Append(effectReference2);
            categoryAxis2.Append(fontReference2);
            categoryAxis2.Append(shapeProperties3);
            categoryAxis2.Append(textCharacterPropertiesType2);

            var chartArea1 = new Cs.ChartArea() { Modifiers = new ListValue<StringValue>() { InnerText = "allowNoFillOverride allowNoLineOverride" } };
            var lineReference3 = new Cs.LineReference() { Index = (UInt32Value)0U };
            var fillReference3 = new Cs.FillReference() { Index = (UInt32Value)0U };
            var effectReference3 = new Cs.EffectReference() { Index = (UInt32Value)0U };

            var fontReference3 = new Cs.FontReference() { Index = A.FontCollectionIndexValues.Minor };
            var schemeColor28 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            fontReference3.Append(schemeColor28);

            var shapeProperties4 = new Cs.ShapeProperties();

            var solidFill20 = new A.SolidFill();
            var schemeColor29 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            solidFill20.Append(schemeColor29);

            var outline11 = new A.Outline() { Width = 9525, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            var solidFill21 = new A.SolidFill();

            var schemeColor30 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };
            var luminanceModulation18 = new A.LuminanceModulation() { Val = 15000 };
            var luminanceOffset14 = new A.LuminanceOffset() { Val = 85000 };

            schemeColor30.Append(luminanceModulation18);
            schemeColor30.Append(luminanceOffset14);

            solidFill21.Append(schemeColor30);
            var round5 = new A.Round();

            outline11.Append(solidFill21);
            outline11.Append(round5);

            shapeProperties4.Append(solidFill20);
            shapeProperties4.Append(outline11);
            var textCharacterPropertiesType3 = new Cs.TextCharacterPropertiesType() { FontSize = 1330 };

            chartArea1.Append(lineReference3);
            chartArea1.Append(fillReference3);
            chartArea1.Append(effectReference3);
            chartArea1.Append(fontReference3);
            chartArea1.Append(shapeProperties4);
            chartArea1.Append(textCharacterPropertiesType3);

            var dataLabel1 = new Cs.DataLabel();
            var lineReference4 = new Cs.LineReference() { Index = (UInt32Value)0U };
            var fillReference4 = new Cs.FillReference() { Index = (UInt32Value)0U };
            var effectReference4 = new Cs.EffectReference() { Index = (UInt32Value)0U };

            var fontReference4 = new Cs.FontReference() { Index = A.FontCollectionIndexValues.Minor };
            var schemeColor31 = new A.SchemeColor() { Val = A.SchemeColorValues.Light1 };

            fontReference4.Append(schemeColor31);
            var textCharacterPropertiesType4 = new Cs.TextCharacterPropertiesType() { FontSize = 1197 };

            dataLabel1.Append(lineReference4);
            dataLabel1.Append(fillReference4);
            dataLabel1.Append(effectReference4);
            dataLabel1.Append(fontReference4);
            dataLabel1.Append(textCharacterPropertiesType4);

            var dataLabelCallout1 = new Cs.DataLabelCallout();
            var lineReference5 = new Cs.LineReference() { Index = (UInt32Value)0U };
            var fillReference5 = new Cs.FillReference() { Index = (UInt32Value)0U };
            var effectReference5 = new Cs.EffectReference() { Index = (UInt32Value)0U };

            var fontReference5 = new Cs.FontReference() { Index = A.FontCollectionIndexValues.Minor };

            var schemeColor32 = new A.SchemeColor() { Val = A.SchemeColorValues.Dark1 };
            var luminanceModulation19 = new A.LuminanceModulation() { Val = 65000 };
            var luminanceOffset15 = new A.LuminanceOffset() { Val = 35000 };

            schemeColor32.Append(luminanceModulation19);
            schemeColor32.Append(luminanceOffset15);

            fontReference5.Append(schemeColor32);

            var shapeProperties5 = new Cs.ShapeProperties();

            var solidFill22 = new A.SolidFill();
            var schemeColor33 = new A.SchemeColor() { Val = A.SchemeColorValues.Light1 };

            solidFill22.Append(schemeColor33);

            var outline12 = new A.Outline();

            var solidFill23 = new A.SolidFill();

            var schemeColor34 = new A.SchemeColor() { Val = A.SchemeColorValues.Dark1 };
            var luminanceModulation20 = new A.LuminanceModulation() { Val = 25000 };
            var luminanceOffset16 = new A.LuminanceOffset() { Val = 75000 };

            schemeColor34.Append(luminanceModulation20);
            schemeColor34.Append(luminanceOffset16);

            solidFill23.Append(schemeColor34);

            outline12.Append(solidFill23);

            shapeProperties5.Append(solidFill22);
            shapeProperties5.Append(outline12);
            var textCharacterPropertiesType5 = new Cs.TextCharacterPropertiesType() { FontSize = 1197 };

            var textBodyProperties1 = new Cs.TextBodyProperties() { Rotation = 0, UseParagraphSpacing = true, VerticalOverflow = A.TextVerticalOverflowValues.Clip, HorizontalOverflow = A.TextHorizontalOverflowValues.Clip, Vertical = A.TextVerticalValues.Horizontal, Wrap = A.TextWrappingValues.Square, LeftInset = 36576, TopInset = 18288, RightInset = 36576, BottomInset = 18288, Anchor = A.TextAnchoringTypeValues.Center, AnchorCenter = true };
            var shapeAutoFit2 = new A.ShapeAutoFit();

            textBodyProperties1.Append(shapeAutoFit2);

            dataLabelCallout1.Append(lineReference5);
            dataLabelCallout1.Append(fillReference5);
            dataLabelCallout1.Append(effectReference5);
            dataLabelCallout1.Append(fontReference5);
            dataLabelCallout1.Append(shapeProperties5);
            dataLabelCallout1.Append(textCharacterPropertiesType5);
            dataLabelCallout1.Append(textBodyProperties1);

            var dataPoint1 = new Cs.DataPoint();
            var lineReference6 = new Cs.LineReference() { Index = (UInt32Value)0U };

            var fillReference6 = new Cs.FillReference() { Index = (UInt32Value)0U };
            var styleColor1 = new Cs.StyleColor() { Val = "auto" };

            fillReference6.Append(styleColor1);
            var effectReference6 = new Cs.EffectReference() { Index = (UInt32Value)0U };

            var fontReference6 = new Cs.FontReference() { Index = A.FontCollectionIndexValues.Minor };
            var schemeColor35 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            fontReference6.Append(schemeColor35);

            var shapeProperties6 = new Cs.ShapeProperties();

            var solidFill24 = new A.SolidFill();
            var schemeColor36 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill24.Append(schemeColor36);

            var outline13 = new A.Outline() { Width = 19050 };

            var solidFill25 = new A.SolidFill();
            var schemeColor37 = new A.SchemeColor() { Val = A.SchemeColorValues.Light1 };

            solidFill25.Append(schemeColor37);

            outline13.Append(solidFill25);

            shapeProperties6.Append(solidFill24);
            shapeProperties6.Append(outline13);

            dataPoint1.Append(lineReference6);
            dataPoint1.Append(fillReference6);
            dataPoint1.Append(effectReference6);
            dataPoint1.Append(fontReference6);
            dataPoint1.Append(shapeProperties6);

            var dataPoint3D1 = new Cs.DataPoint3D();
            var lineReference7 = new Cs.LineReference() { Index = (UInt32Value)0U };

            var fillReference7 = new Cs.FillReference() { Index = (UInt32Value)0U };
            var styleColor2 = new Cs.StyleColor() { Val = "auto" };

            fillReference7.Append(styleColor2);
            var effectReference7 = new Cs.EffectReference() { Index = (UInt32Value)0U };

            var fontReference7 = new Cs.FontReference() { Index = A.FontCollectionIndexValues.Minor };
            var schemeColor38 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            fontReference7.Append(schemeColor38);

            var shapeProperties7 = new Cs.ShapeProperties();

            var solidFill26 = new A.SolidFill();
            var schemeColor39 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill26.Append(schemeColor39);

            shapeProperties7.Append(solidFill26);

            dataPoint3D1.Append(lineReference7);
            dataPoint3D1.Append(fillReference7);
            dataPoint3D1.Append(effectReference7);
            dataPoint3D1.Append(fontReference7);
            dataPoint3D1.Append(shapeProperties7);

            var dataPointLine1 = new Cs.DataPointLine();

            var lineReference8 = new Cs.LineReference() { Index = (UInt32Value)0U };
            var styleColor3 = new Cs.StyleColor() { Val = "auto" };

            lineReference8.Append(styleColor3);
            var fillReference8 = new Cs.FillReference() { Index = (UInt32Value)0U };
            var effectReference8 = new Cs.EffectReference() { Index = (UInt32Value)0U };

            var fontReference8 = new Cs.FontReference() { Index = A.FontCollectionIndexValues.Minor };
            var schemeColor40 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            fontReference8.Append(schemeColor40);

            var shapeProperties8 = new Cs.ShapeProperties();

            var outline14 = new A.Outline() { Width = 28575, CapType = A.LineCapValues.Round };

            var solidFill27 = new A.SolidFill();
            var schemeColor41 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill27.Append(schemeColor41);
            var round6 = new A.Round();

            outline14.Append(solidFill27);
            outline14.Append(round6);

            shapeProperties8.Append(outline14);

            dataPointLine1.Append(lineReference8);
            dataPointLine1.Append(fillReference8);
            dataPointLine1.Append(effectReference8);
            dataPointLine1.Append(fontReference8);
            dataPointLine1.Append(shapeProperties8);

            var dataPointMarker1 = new Cs.DataPointMarker();
            var lineReference9 = new Cs.LineReference() { Index = (UInt32Value)0U };

            var fillReference9 = new Cs.FillReference() { Index = (UInt32Value)0U };
            var styleColor4 = new Cs.StyleColor() { Val = "auto" };

            fillReference9.Append(styleColor4);
            var effectReference9 = new Cs.EffectReference() { Index = (UInt32Value)0U };

            var fontReference9 = new Cs.FontReference() { Index = A.FontCollectionIndexValues.Minor };
            var schemeColor42 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            fontReference9.Append(schemeColor42);

            var shapeProperties9 = new Cs.ShapeProperties();

            var solidFill28 = new A.SolidFill();
            var schemeColor43 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill28.Append(schemeColor43);

            var outline15 = new A.Outline() { Width = 9525 };

            var solidFill29 = new A.SolidFill();
            var schemeColor44 = new A.SchemeColor() { Val = A.SchemeColorValues.Light1 };

            solidFill29.Append(schemeColor44);

            outline15.Append(solidFill29);

            shapeProperties9.Append(solidFill28);
            shapeProperties9.Append(outline15);

            dataPointMarker1.Append(lineReference9);
            dataPointMarker1.Append(fillReference9);
            dataPointMarker1.Append(effectReference9);
            dataPointMarker1.Append(fontReference9);
            dataPointMarker1.Append(shapeProperties9);
            var markerLayoutProperties1 = new Cs.MarkerLayoutProperties() { Symbol = Cs.MarkerStyle.Circle, Size = 5 };

            var dataPointWireframe1 = new Cs.DataPointWireframe();

            var lineReference10 = new Cs.LineReference() { Index = (UInt32Value)0U };
            var styleColor5 = new Cs.StyleColor() { Val = "auto" };

            lineReference10.Append(styleColor5);
            var fillReference10 = new Cs.FillReference() { Index = (UInt32Value)0U };
            var effectReference10 = new Cs.EffectReference() { Index = (UInt32Value)0U };

            var fontReference10 = new Cs.FontReference() { Index = A.FontCollectionIndexValues.Minor };
            var schemeColor45 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            fontReference10.Append(schemeColor45);

            var shapeProperties10 = new Cs.ShapeProperties();

            var outline16 = new A.Outline() { Width = 28575, CapType = A.LineCapValues.Round };

            var solidFill30 = new A.SolidFill();
            var schemeColor46 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill30.Append(schemeColor46);
            var round7 = new A.Round();

            outline16.Append(solidFill30);
            outline16.Append(round7);

            shapeProperties10.Append(outline16);

            dataPointWireframe1.Append(lineReference10);
            dataPointWireframe1.Append(fillReference10);
            dataPointWireframe1.Append(effectReference10);
            dataPointWireframe1.Append(fontReference10);
            dataPointWireframe1.Append(shapeProperties10);

            var dataTableStyle1 = new Cs.DataTableStyle();
            var lineReference11 = new Cs.LineReference() { Index = (UInt32Value)0U };
            var fillReference11 = new Cs.FillReference() { Index = (UInt32Value)0U };
            var effectReference11 = new Cs.EffectReference() { Index = (UInt32Value)0U };

            var fontReference11 = new Cs.FontReference() { Index = A.FontCollectionIndexValues.Minor };

            var schemeColor47 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };
            var luminanceModulation21 = new A.LuminanceModulation() { Val = 65000 };
            var luminanceOffset17 = new A.LuminanceOffset() { Val = 35000 };

            schemeColor47.Append(luminanceModulation21);
            schemeColor47.Append(luminanceOffset17);

            fontReference11.Append(schemeColor47);

            var shapeProperties11 = new Cs.ShapeProperties();

            var outline17 = new A.Outline() { Width = 9525 };

            var solidFill31 = new A.SolidFill();

            var schemeColor48 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };
            var luminanceModulation22 = new A.LuminanceModulation() { Val = 15000 };
            var luminanceOffset18 = new A.LuminanceOffset() { Val = 85000 };

            schemeColor48.Append(luminanceModulation22);
            schemeColor48.Append(luminanceOffset18);

            solidFill31.Append(schemeColor48);

            outline17.Append(solidFill31);

            shapeProperties11.Append(outline17);
            var textCharacterPropertiesType6 = new Cs.TextCharacterPropertiesType() { FontSize = 1197 };

            dataTableStyle1.Append(lineReference11);
            dataTableStyle1.Append(fillReference11);
            dataTableStyle1.Append(effectReference11);
            dataTableStyle1.Append(fontReference11);
            dataTableStyle1.Append(shapeProperties11);
            dataTableStyle1.Append(textCharacterPropertiesType6);

            var downBar1 = new Cs.DownBar();
            var lineReference12 = new Cs.LineReference() { Index = (UInt32Value)0U };
            var fillReference12 = new Cs.FillReference() { Index = (UInt32Value)0U };
            var effectReference12 = new Cs.EffectReference() { Index = (UInt32Value)0U };

            var fontReference12 = new Cs.FontReference() { Index = A.FontCollectionIndexValues.Minor };
            var schemeColor49 = new A.SchemeColor() { Val = A.SchemeColorValues.Dark1 };

            fontReference12.Append(schemeColor49);

            var shapeProperties12 = new Cs.ShapeProperties();

            var solidFill32 = new A.SolidFill();

            var schemeColor50 = new A.SchemeColor() { Val = A.SchemeColorValues.Dark1 };
            var luminanceModulation23 = new A.LuminanceModulation() { Val = 65000 };
            var luminanceOffset19 = new A.LuminanceOffset() { Val = 35000 };

            schemeColor50.Append(luminanceModulation23);
            schemeColor50.Append(luminanceOffset19);

            solidFill32.Append(schemeColor50);

            var outline18 = new A.Outline() { Width = 9525 };

            var solidFill33 = new A.SolidFill();

            var schemeColor51 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };
            var luminanceModulation24 = new A.LuminanceModulation() { Val = 65000 };
            var luminanceOffset20 = new A.LuminanceOffset() { Val = 35000 };

            schemeColor51.Append(luminanceModulation24);
            schemeColor51.Append(luminanceOffset20);

            solidFill33.Append(schemeColor51);

            outline18.Append(solidFill33);

            shapeProperties12.Append(solidFill32);
            shapeProperties12.Append(outline18);

            downBar1.Append(lineReference12);
            downBar1.Append(fillReference12);
            downBar1.Append(effectReference12);
            downBar1.Append(fontReference12);
            downBar1.Append(shapeProperties12);

            var dropLine1 = new Cs.DropLine();
            var lineReference13 = new Cs.LineReference() { Index = (UInt32Value)0U };
            var fillReference13 = new Cs.FillReference() { Index = (UInt32Value)0U };
            var effectReference13 = new Cs.EffectReference() { Index = (UInt32Value)0U };

            var fontReference13 = new Cs.FontReference() { Index = A.FontCollectionIndexValues.Minor };
            var schemeColor52 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            fontReference13.Append(schemeColor52);

            var shapeProperties13 = new Cs.ShapeProperties();

            var outline19 = new A.Outline() { Width = 9525, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            var solidFill34 = new A.SolidFill();

            var schemeColor53 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };
            var luminanceModulation25 = new A.LuminanceModulation() { Val = 35000 };
            var luminanceOffset21 = new A.LuminanceOffset() { Val = 65000 };

            schemeColor53.Append(luminanceModulation25);
            schemeColor53.Append(luminanceOffset21);

            solidFill34.Append(schemeColor53);
            var round8 = new A.Round();

            outline19.Append(solidFill34);
            outline19.Append(round8);

            shapeProperties13.Append(outline19);

            dropLine1.Append(lineReference13);
            dropLine1.Append(fillReference13);
            dropLine1.Append(effectReference13);
            dropLine1.Append(fontReference13);
            dropLine1.Append(shapeProperties13);

            var errorBar1 = new Cs.ErrorBar();
            var lineReference14 = new Cs.LineReference() { Index = (UInt32Value)0U };
            var fillReference14 = new Cs.FillReference() { Index = (UInt32Value)0U };
            var effectReference14 = new Cs.EffectReference() { Index = (UInt32Value)0U };

            var fontReference14 = new Cs.FontReference() { Index = A.FontCollectionIndexValues.Minor };
            var schemeColor54 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            fontReference14.Append(schemeColor54);

            var shapeProperties14 = new Cs.ShapeProperties();

            var outline20 = new A.Outline() { Width = 9525, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            var solidFill35 = new A.SolidFill();

            var schemeColor55 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };
            var luminanceModulation26 = new A.LuminanceModulation() { Val = 65000 };
            var luminanceOffset22 = new A.LuminanceOffset() { Val = 35000 };

            schemeColor55.Append(luminanceModulation26);
            schemeColor55.Append(luminanceOffset22);

            solidFill35.Append(schemeColor55);
            var round9 = new A.Round();

            outline20.Append(solidFill35);
            outline20.Append(round9);

            shapeProperties14.Append(outline20);

            errorBar1.Append(lineReference14);
            errorBar1.Append(fillReference14);
            errorBar1.Append(effectReference14);
            errorBar1.Append(fontReference14);
            errorBar1.Append(shapeProperties14);

            var floor1 = new Cs.Floor();
            var lineReference15 = new Cs.LineReference() { Index = (UInt32Value)0U };
            var fillReference15 = new Cs.FillReference() { Index = (UInt32Value)0U };
            var effectReference15 = new Cs.EffectReference() { Index = (UInt32Value)0U };

            var fontReference15 = new Cs.FontReference() { Index = A.FontCollectionIndexValues.Minor };
            var schemeColor56 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            fontReference15.Append(schemeColor56);

            floor1.Append(lineReference15);
            floor1.Append(fillReference15);
            floor1.Append(effectReference15);
            floor1.Append(fontReference15);

            var gridlineMajor1 = new Cs.GridlineMajor();
            var lineReference16 = new Cs.LineReference() { Index = (UInt32Value)0U };
            var fillReference16 = new Cs.FillReference() { Index = (UInt32Value)0U };
            var effectReference16 = new Cs.EffectReference() { Index = (UInt32Value)0U };

            var fontReference16 = new Cs.FontReference() { Index = A.FontCollectionIndexValues.Minor };
            var schemeColor57 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            fontReference16.Append(schemeColor57);

            var shapeProperties15 = new Cs.ShapeProperties();

            var outline21 = new A.Outline() { Width = 9525, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            var solidFill36 = new A.SolidFill();

            var schemeColor58 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };
            var luminanceModulation27 = new A.LuminanceModulation() { Val = 15000 };
            var luminanceOffset23 = new A.LuminanceOffset() { Val = 85000 };

            schemeColor58.Append(luminanceModulation27);
            schemeColor58.Append(luminanceOffset23);

            solidFill36.Append(schemeColor58);
            var round10 = new A.Round();

            outline21.Append(solidFill36);
            outline21.Append(round10);

            shapeProperties15.Append(outline21);

            gridlineMajor1.Append(lineReference16);
            gridlineMajor1.Append(fillReference16);
            gridlineMajor1.Append(effectReference16);
            gridlineMajor1.Append(fontReference16);
            gridlineMajor1.Append(shapeProperties15);

            var gridlineMinor1 = new Cs.GridlineMinor();
            var lineReference17 = new Cs.LineReference() { Index = (UInt32Value)0U };
            var fillReference17 = new Cs.FillReference() { Index = (UInt32Value)0U };
            var effectReference17 = new Cs.EffectReference() { Index = (UInt32Value)0U };

            var fontReference17 = new Cs.FontReference() { Index = A.FontCollectionIndexValues.Minor };
            var schemeColor59 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            fontReference17.Append(schemeColor59);

            var shapeProperties16 = new Cs.ShapeProperties();

            var outline22 = new A.Outline() { Width = 9525, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            var solidFill37 = new A.SolidFill();

            var schemeColor60 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };
            var luminanceModulation28 = new A.LuminanceModulation() { Val = 15000 };
            var luminanceOffset24 = new A.LuminanceOffset() { Val = 85000 };

            schemeColor60.Append(luminanceModulation28);
            schemeColor60.Append(luminanceOffset24);

            solidFill37.Append(schemeColor60);
            var round11 = new A.Round();

            outline22.Append(solidFill37);
            outline22.Append(round11);

            shapeProperties16.Append(outline22);

            gridlineMinor1.Append(lineReference17);
            gridlineMinor1.Append(fillReference17);
            gridlineMinor1.Append(effectReference17);
            gridlineMinor1.Append(fontReference17);
            gridlineMinor1.Append(shapeProperties16);

            var hiLoLine1 = new Cs.HiLoLine();
            var lineReference18 = new Cs.LineReference() { Index = (UInt32Value)0U };
            var fillReference18 = new Cs.FillReference() { Index = (UInt32Value)0U };
            var effectReference18 = new Cs.EffectReference() { Index = (UInt32Value)0U };

            var fontReference18 = new Cs.FontReference() { Index = A.FontCollectionIndexValues.Minor };
            var schemeColor61 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            fontReference18.Append(schemeColor61);

            var shapeProperties17 = new Cs.ShapeProperties();

            var outline23 = new A.Outline() { Width = 9525, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            var solidFill38 = new A.SolidFill();

            var schemeColor62 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };
            var luminanceModulation29 = new A.LuminanceModulation() { Val = 75000 };
            var luminanceOffset25 = new A.LuminanceOffset() { Val = 25000 };

            schemeColor62.Append(luminanceModulation29);
            schemeColor62.Append(luminanceOffset25);

            solidFill38.Append(schemeColor62);
            var round12 = new A.Round();

            outline23.Append(solidFill38);
            outline23.Append(round12);

            shapeProperties17.Append(outline23);

            hiLoLine1.Append(lineReference18);
            hiLoLine1.Append(fillReference18);
            hiLoLine1.Append(effectReference18);
            hiLoLine1.Append(fontReference18);
            hiLoLine1.Append(shapeProperties17);

            var leaderLine1 = new Cs.LeaderLine();
            var lineReference19 = new Cs.LineReference() { Index = (UInt32Value)0U };
            var fillReference19 = new Cs.FillReference() { Index = (UInt32Value)0U };
            var effectReference19 = new Cs.EffectReference() { Index = (UInt32Value)0U };

            var fontReference19 = new Cs.FontReference() { Index = A.FontCollectionIndexValues.Minor };
            var schemeColor63 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            fontReference19.Append(schemeColor63);

            var shapeProperties18 = new Cs.ShapeProperties();

            var outline24 = new A.Outline() { Width = 9525, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            var solidFill39 = new A.SolidFill();

            var schemeColor64 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };
            var luminanceModulation30 = new A.LuminanceModulation() { Val = 35000 };
            var luminanceOffset26 = new A.LuminanceOffset() { Val = 65000 };

            schemeColor64.Append(luminanceModulation30);
            schemeColor64.Append(luminanceOffset26);

            solidFill39.Append(schemeColor64);
            var round13 = new A.Round();

            outline24.Append(solidFill39);
            outline24.Append(round13);

            shapeProperties18.Append(outline24);

            leaderLine1.Append(lineReference19);
            leaderLine1.Append(fillReference19);
            leaderLine1.Append(effectReference19);
            leaderLine1.Append(fontReference19);
            leaderLine1.Append(shapeProperties18);

            var legendStyle1 = new Cs.LegendStyle();
            var lineReference20 = new Cs.LineReference() { Index = (UInt32Value)0U };
            var fillReference20 = new Cs.FillReference() { Index = (UInt32Value)0U };
            var effectReference20 = new Cs.EffectReference() { Index = (UInt32Value)0U };

            var fontReference20 = new Cs.FontReference() { Index = A.FontCollectionIndexValues.Minor };

            var schemeColor65 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };
            var luminanceModulation31 = new A.LuminanceModulation() { Val = 65000 };
            var luminanceOffset27 = new A.LuminanceOffset() { Val = 35000 };

            schemeColor65.Append(luminanceModulation31);
            schemeColor65.Append(luminanceOffset27);

            fontReference20.Append(schemeColor65);
            var textCharacterPropertiesType7 = new Cs.TextCharacterPropertiesType() { FontSize = 1197 };

            legendStyle1.Append(lineReference20);
            legendStyle1.Append(fillReference20);
            legendStyle1.Append(effectReference20);
            legendStyle1.Append(fontReference20);
            legendStyle1.Append(textCharacterPropertiesType7);

            var plotArea2 = new Cs.PlotArea() { Modifiers = new ListValue<StringValue>() { InnerText = "allowNoFillOverride allowNoLineOverride" } };
            var lineReference21 = new Cs.LineReference() { Index = (UInt32Value)0U };
            var fillReference21 = new Cs.FillReference() { Index = (UInt32Value)0U };
            var effectReference21 = new Cs.EffectReference() { Index = (UInt32Value)0U };

            var fontReference21 = new Cs.FontReference() { Index = A.FontCollectionIndexValues.Minor };
            var schemeColor66 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            fontReference21.Append(schemeColor66);

            plotArea2.Append(lineReference21);
            plotArea2.Append(fillReference21);
            plotArea2.Append(effectReference21);
            plotArea2.Append(fontReference21);

            var plotArea3D1 = new Cs.PlotArea3D() { Modifiers = new ListValue<StringValue>() { InnerText = "allowNoFillOverride allowNoLineOverride" } };
            var lineReference22 = new Cs.LineReference() { Index = (UInt32Value)0U };
            var fillReference22 = new Cs.FillReference() { Index = (UInt32Value)0U };
            var effectReference22 = new Cs.EffectReference() { Index = (UInt32Value)0U };

            var fontReference22 = new Cs.FontReference() { Index = A.FontCollectionIndexValues.Minor };
            var schemeColor67 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            fontReference22.Append(schemeColor67);

            plotArea3D1.Append(lineReference22);
            plotArea3D1.Append(fillReference22);
            plotArea3D1.Append(effectReference22);
            plotArea3D1.Append(fontReference22);

            var seriesAxis1 = new Cs.SeriesAxis();
            var lineReference23 = new Cs.LineReference() { Index = (UInt32Value)0U };
            var fillReference23 = new Cs.FillReference() { Index = (UInt32Value)0U };
            var effectReference23 = new Cs.EffectReference() { Index = (UInt32Value)0U };

            var fontReference23 = new Cs.FontReference() { Index = A.FontCollectionIndexValues.Minor };

            var schemeColor68 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };
            var luminanceModulation32 = new A.LuminanceModulation() { Val = 65000 };
            var luminanceOffset28 = new A.LuminanceOffset() { Val = 35000 };

            schemeColor68.Append(luminanceModulation32);
            schemeColor68.Append(luminanceOffset28);

            fontReference23.Append(schemeColor68);

            var shapeProperties19 = new Cs.ShapeProperties();

            var outline25 = new A.Outline() { Width = 9525, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            var solidFill40 = new A.SolidFill();

            var schemeColor69 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };
            var luminanceModulation33 = new A.LuminanceModulation() { Val = 15000 };
            var luminanceOffset29 = new A.LuminanceOffset() { Val = 85000 };

            schemeColor69.Append(luminanceModulation33);
            schemeColor69.Append(luminanceOffset29);

            solidFill40.Append(schemeColor69);
            var round14 = new A.Round();

            outline25.Append(solidFill40);
            outline25.Append(round14);

            shapeProperties19.Append(outline25);
            var textCharacterPropertiesType8 = new Cs.TextCharacterPropertiesType() { FontSize = 1197 };

            seriesAxis1.Append(lineReference23);
            seriesAxis1.Append(fillReference23);
            seriesAxis1.Append(effectReference23);
            seriesAxis1.Append(fontReference23);
            seriesAxis1.Append(shapeProperties19);
            seriesAxis1.Append(textCharacterPropertiesType8);

            var seriesLine1 = new Cs.SeriesLine();
            var lineReference24 = new Cs.LineReference() { Index = (UInt32Value)0U };
            var fillReference24 = new Cs.FillReference() { Index = (UInt32Value)0U };
            var effectReference24 = new Cs.EffectReference() { Index = (UInt32Value)0U };

            var fontReference24 = new Cs.FontReference() { Index = A.FontCollectionIndexValues.Minor };
            var schemeColor70 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            fontReference24.Append(schemeColor70);

            var shapeProperties20 = new Cs.ShapeProperties();

            var outline26 = new A.Outline() { Width = 9525, CapType = A.LineCapValues.Flat };

            var solidFill41 = new A.SolidFill();
            var rgbColorModelHex1 = new A.RgbColorModelHex() { Val = "D9D9D9" };

            solidFill41.Append(rgbColorModelHex1);
            var round15 = new A.Round();

            outline26.Append(solidFill41);
            outline26.Append(round15);

            shapeProperties20.Append(outline26);

            seriesLine1.Append(lineReference24);
            seriesLine1.Append(fillReference24);
            seriesLine1.Append(effectReference24);
            seriesLine1.Append(fontReference24);
            seriesLine1.Append(shapeProperties20);

            var titleStyle1 = new Cs.TitleStyle();
            var lineReference25 = new Cs.LineReference() { Index = (UInt32Value)0U };
            var fillReference25 = new Cs.FillReference() { Index = (UInt32Value)0U };
            var effectReference25 = new Cs.EffectReference() { Index = (UInt32Value)0U };

            var fontReference25 = new Cs.FontReference() { Index = A.FontCollectionIndexValues.Minor };

            var schemeColor71 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };
            var luminanceModulation34 = new A.LuminanceModulation() { Val = 65000 };
            var luminanceOffset30 = new A.LuminanceOffset() { Val = 35000 };

            schemeColor71.Append(luminanceModulation34);
            schemeColor71.Append(luminanceOffset30);

            fontReference25.Append(schemeColor71);
            var textCharacterPropertiesType9 = new Cs.TextCharacterPropertiesType() { FontSize = 1862 };

            titleStyle1.Append(lineReference25);
            titleStyle1.Append(fillReference25);
            titleStyle1.Append(effectReference25);
            titleStyle1.Append(fontReference25);
            titleStyle1.Append(textCharacterPropertiesType9);

            var trendlineStyle1 = new Cs.TrendlineStyle();

            var lineReference26 = new Cs.LineReference() { Index = (UInt32Value)0U };
            var styleColor6 = new Cs.StyleColor() { Val = "auto" };

            lineReference26.Append(styleColor6);
            var fillReference26 = new Cs.FillReference() { Index = (UInt32Value)0U };
            var effectReference26 = new Cs.EffectReference() { Index = (UInt32Value)0U };

            var fontReference26 = new Cs.FontReference() { Index = A.FontCollectionIndexValues.Minor };
            var schemeColor72 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            fontReference26.Append(schemeColor72);

            var shapeProperties21 = new Cs.ShapeProperties();

            var outline27 = new A.Outline() { Width = 19050, CapType = A.LineCapValues.Round };

            var solidFill42 = new A.SolidFill();
            var schemeColor73 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill42.Append(schemeColor73);
            var presetDash1 = new A.PresetDash() { Val = A.PresetLineDashValues.SystemDash };

            outline27.Append(solidFill42);
            outline27.Append(presetDash1);

            shapeProperties21.Append(outline27);

            trendlineStyle1.Append(lineReference26);
            trendlineStyle1.Append(fillReference26);
            trendlineStyle1.Append(effectReference26);
            trendlineStyle1.Append(fontReference26);
            trendlineStyle1.Append(shapeProperties21);

            var trendlineLabel1 = new Cs.TrendlineLabel();
            var lineReference27 = new Cs.LineReference() { Index = (UInt32Value)0U };
            var fillReference27 = new Cs.FillReference() { Index = (UInt32Value)0U };
            var effectReference27 = new Cs.EffectReference() { Index = (UInt32Value)0U };

            var fontReference27 = new Cs.FontReference() { Index = A.FontCollectionIndexValues.Minor };

            var schemeColor74 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };
            var luminanceModulation35 = new A.LuminanceModulation() { Val = 65000 };
            var luminanceOffset31 = new A.LuminanceOffset() { Val = 35000 };

            schemeColor74.Append(luminanceModulation35);
            schemeColor74.Append(luminanceOffset31);

            fontReference27.Append(schemeColor74);
            var textCharacterPropertiesType10 = new Cs.TextCharacterPropertiesType() { FontSize = 1197 };

            trendlineLabel1.Append(lineReference27);
            trendlineLabel1.Append(fillReference27);
            trendlineLabel1.Append(effectReference27);
            trendlineLabel1.Append(fontReference27);
            trendlineLabel1.Append(textCharacterPropertiesType10);

            var upBar1 = new Cs.UpBar();
            var lineReference28 = new Cs.LineReference() { Index = (UInt32Value)0U };
            var fillReference28 = new Cs.FillReference() { Index = (UInt32Value)0U };
            var effectReference28 = new Cs.EffectReference() { Index = (UInt32Value)0U };

            var fontReference28 = new Cs.FontReference() { Index = A.FontCollectionIndexValues.Minor };
            var schemeColor75 = new A.SchemeColor() { Val = A.SchemeColorValues.Dark1 };

            fontReference28.Append(schemeColor75);

            var shapeProperties22 = new Cs.ShapeProperties();

            var solidFill43 = new A.SolidFill();
            var schemeColor76 = new A.SchemeColor() { Val = A.SchemeColorValues.Light1 };

            solidFill43.Append(schemeColor76);

            var outline28 = new A.Outline() { Width = 9525 };

            var solidFill44 = new A.SolidFill();

            var schemeColor77 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };
            var luminanceModulation36 = new A.LuminanceModulation() { Val = 15000 };
            var luminanceOffset32 = new A.LuminanceOffset() { Val = 85000 };

            schemeColor77.Append(luminanceModulation36);
            schemeColor77.Append(luminanceOffset32);

            solidFill44.Append(schemeColor77);

            outline28.Append(solidFill44);

            shapeProperties22.Append(solidFill43);
            shapeProperties22.Append(outline28);

            upBar1.Append(lineReference28);
            upBar1.Append(fillReference28);
            upBar1.Append(effectReference28);
            upBar1.Append(fontReference28);
            upBar1.Append(shapeProperties22);

            var valueAxis2 = new Cs.ValueAxis();
            var lineReference29 = new Cs.LineReference() { Index = (UInt32Value)0U };
            var fillReference29 = new Cs.FillReference() { Index = (UInt32Value)0U };
            var effectReference29 = new Cs.EffectReference() { Index = (UInt32Value)0U };

            var fontReference29 = new Cs.FontReference() { Index = A.FontCollectionIndexValues.Minor };

            var schemeColor78 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };
            var luminanceModulation37 = new A.LuminanceModulation() { Val = 65000 };
            var luminanceOffset33 = new A.LuminanceOffset() { Val = 35000 };

            schemeColor78.Append(luminanceModulation37);
            schemeColor78.Append(luminanceOffset33);

            fontReference29.Append(schemeColor78);
            var textCharacterPropertiesType11 = new Cs.TextCharacterPropertiesType() { FontSize = 1197 };

            valueAxis2.Append(lineReference29);
            valueAxis2.Append(fillReference29);
            valueAxis2.Append(effectReference29);
            valueAxis2.Append(fontReference29);
            valueAxis2.Append(textCharacterPropertiesType11);

            var wall1 = new Cs.Wall();
            var lineReference30 = new Cs.LineReference() { Index = (UInt32Value)0U };
            var fillReference30 = new Cs.FillReference() { Index = (UInt32Value)0U };
            var effectReference30 = new Cs.EffectReference() { Index = (UInt32Value)0U };

            var fontReference30 = new Cs.FontReference() { Index = A.FontCollectionIndexValues.Minor };
            var schemeColor79 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            fontReference30.Append(schemeColor79);

            wall1.Append(lineReference30);
            wall1.Append(fillReference30);
            wall1.Append(effectReference30);
            wall1.Append(fontReference30);

            chartStyle1.Append(axisTitle1);
            chartStyle1.Append(categoryAxis2);
            chartStyle1.Append(chartArea1);
            chartStyle1.Append(dataLabel1);
            chartStyle1.Append(dataLabelCallout1);
            chartStyle1.Append(dataPoint1);
            chartStyle1.Append(dataPoint3D1);
            chartStyle1.Append(dataPointLine1);
            chartStyle1.Append(dataPointMarker1);
            chartStyle1.Append(markerLayoutProperties1);
            chartStyle1.Append(dataPointWireframe1);
            chartStyle1.Append(dataTableStyle1);
            chartStyle1.Append(downBar1);
            chartStyle1.Append(dropLine1);
            chartStyle1.Append(errorBar1);
            chartStyle1.Append(floor1);
            chartStyle1.Append(gridlineMajor1);
            chartStyle1.Append(gridlineMinor1);
            chartStyle1.Append(hiLoLine1);
            chartStyle1.Append(leaderLine1);
            chartStyle1.Append(legendStyle1);
            chartStyle1.Append(plotArea2);
            chartStyle1.Append(plotArea3D1);
            chartStyle1.Append(seriesAxis1);
            chartStyle1.Append(seriesLine1);
            chartStyle1.Append(titleStyle1);
            chartStyle1.Append(trendlineStyle1);
            chartStyle1.Append(trendlineLabel1);
            chartStyle1.Append(upBar1);
            chartStyle1.Append(valueAxis2);
            chartStyle1.Append(wall1);

            chartStylePart1.ChartStyle = chartStyle1;
        }

        // Generates content of chartColorStylePart1.
        private static void GenerateChartColorStylePart1Content(ChartColorStylePart chartColorStylePart1)
        {
            var colorStyle1 = new Cs.ColorStyle() { Method = "cycle", Id = (UInt32Value)10U };
            colorStyle1.AddNamespaceDeclaration("cs", "http://schemas.microsoft.com/office/drawing/2012/chartStyle");
            colorStyle1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            var schemeColor19 = new A.SchemeColor() { Val = A.SchemeColorValues.Accent1 };
            var schemeColor20 = new A.SchemeColor() { Val = A.SchemeColorValues.Accent2 };
            var schemeColor21 = new A.SchemeColor() { Val = A.SchemeColorValues.Accent3 };
            var schemeColor22 = new A.SchemeColor() { Val = A.SchemeColorValues.Accent4 };
            var schemeColor23 = new A.SchemeColor() { Val = A.SchemeColorValues.Accent5 };
            var schemeColor24 = new A.SchemeColor() { Val = A.SchemeColorValues.Accent6 };
            var colorStyleVariation1 = new Cs.ColorStyleVariation();

            var colorStyleVariation2 = new Cs.ColorStyleVariation();
            var luminanceModulation7 = new A.LuminanceModulation() { Val = 60000 };

            colorStyleVariation2.Append(luminanceModulation7);

            var colorStyleVariation3 = new Cs.ColorStyleVariation();
            var luminanceModulation8 = new A.LuminanceModulation() { Val = 80000 };
            var luminanceOffset7 = new A.LuminanceOffset() { Val = 20000 };

            colorStyleVariation3.Append(luminanceModulation8);
            colorStyleVariation3.Append(luminanceOffset7);

            var colorStyleVariation4 = new Cs.ColorStyleVariation();
            var luminanceModulation9 = new A.LuminanceModulation() { Val = 80000 };

            colorStyleVariation4.Append(luminanceModulation9);

            var colorStyleVariation5 = new Cs.ColorStyleVariation();
            var luminanceModulation10 = new A.LuminanceModulation() { Val = 60000 };
            var luminanceOffset8 = new A.LuminanceOffset() { Val = 40000 };

            colorStyleVariation5.Append(luminanceModulation10);
            colorStyleVariation5.Append(luminanceOffset8);

            var colorStyleVariation6 = new Cs.ColorStyleVariation();
            var luminanceModulation11 = new A.LuminanceModulation() { Val = 50000 };

            colorStyleVariation6.Append(luminanceModulation11);

            var colorStyleVariation7 = new Cs.ColorStyleVariation();
            var luminanceModulation12 = new A.LuminanceModulation() { Val = 70000 };
            var luminanceOffset9 = new A.LuminanceOffset() { Val = 30000 };

            colorStyleVariation7.Append(luminanceModulation12);
            colorStyleVariation7.Append(luminanceOffset9);

            var colorStyleVariation8 = new Cs.ColorStyleVariation();
            var luminanceModulation13 = new A.LuminanceModulation() { Val = 70000 };

            colorStyleVariation8.Append(luminanceModulation13);

            var colorStyleVariation9 = new Cs.ColorStyleVariation();
            var luminanceModulation14 = new A.LuminanceModulation() { Val = 50000 };
            var luminanceOffset10 = new A.LuminanceOffset() { Val = 50000 };

            colorStyleVariation9.Append(luminanceModulation14);
            colorStyleVariation9.Append(luminanceOffset10);

            colorStyle1.Append(schemeColor19);
            colorStyle1.Append(schemeColor20);
            colorStyle1.Append(schemeColor21);
            colorStyle1.Append(schemeColor22);
            colorStyle1.Append(schemeColor23);
            colorStyle1.Append(schemeColor24);
            colorStyle1.Append(colorStyleVariation1);
            colorStyle1.Append(colorStyleVariation2);
            colorStyle1.Append(colorStyleVariation3);
            colorStyle1.Append(colorStyleVariation4);
            colorStyle1.Append(colorStyleVariation5);
            colorStyle1.Append(colorStyleVariation6);
            colorStyle1.Append(colorStyleVariation7);
            colorStyle1.Append(colorStyleVariation8);
            colorStyle1.Append(colorStyleVariation9);

            chartColorStylePart1.ColorStyle = colorStyle1;
        }

        // Generates the content of imagePart1
        private static void GenerateImagePart1Content(ImagePart imagePart1)
        {
            using (var data = GetBinaryDataStream(imagePart1Data))
            {
                imagePart1.FeedData(data);
            }
        }

        #region Binary Data
        private static string imagePart1Data = "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";

        private static string embeddedPackagePart1Data = "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";

        private static System.IO.Stream GetBinaryDataStream(string base64String)
        {
            return new System.IO.MemoryStream(System.Convert.FromBase64String(base64String));
        }

        #endregion

        private static SlidePart CreateSlidePart(PresentationPart presentationPart)
        {
            var slidePart1 = presentationPart.AddNewPart<SlidePart>("rId2");
            GenerateSlidePart1Content(slidePart1);
            return slidePart1;
        }

        // Generates content of slidePart1.
        private static void GenerateSlidePart1Content(SlidePart slidePart1)
        {
            var slide1 = new Slide();
            slide1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slide1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slide1.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            var commonSlideData1 = new CommonSlideData();

            var shapeTree1 = new ShapeTree();

            var nonVisualGroupShapeProperties1 = new NonVisualGroupShapeProperties();
            var nonVisualDrawingProperties1 = new NonVisualDrawingProperties() { Id = (UInt32Value)1U, Name = string.Empty };
            var nonVisualGroupShapeDrawingProperties1 = new NonVisualGroupShapeDrawingProperties();
            var applicationNonVisualDrawingProperties1 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties1.Append(nonVisualDrawingProperties1);
            nonVisualGroupShapeProperties1.Append(nonVisualGroupShapeDrawingProperties1);
            nonVisualGroupShapeProperties1.Append(applicationNonVisualDrawingProperties1);

            var groupShapeProperties1 = new GroupShapeProperties();

            var transformGroup1 = new A.TransformGroup();
            var offset1 = new A.Offset() { X = 0L, Y = 0L };
            var extents1 = new A.Extents() { Cx = 0L, Cy = 0L };
            var childOffset1 = new A.ChildOffset() { X = 0L, Y = 0L };
            var childExtents1 = new A.ChildExtents() { Cx = 0L, Cy = 0L };

            transformGroup1.Append(offset1);
            transformGroup1.Append(extents1);
            transformGroup1.Append(childOffset1);
            transformGroup1.Append(childExtents1);

            groupShapeProperties1.Append(transformGroup1);

            var ac = new AlternateContent();
            var choice = new AlternateContentChoice();
            choice.AddNamespaceDeclaration("cx1", "http://schemas.microsoft.com/office/drawing/2015/9/8/chartex");
            choice.Requires = "cx1";
            var fallback = new AlternateContentFallback();

            // This section is for the AlternateContent:Choice block
            var graphicFrame1 = new GraphicFrame();

            var nonVisualGraphicFrameProperties1 = new NonVisualGraphicFrameProperties();

            var nonVisualDrawingProperties2 = new NonVisualDrawingProperties() { Id = (UInt32Value)6U, Name = "Chart 5" };

            var nonVisualDrawingPropertiesExtensionList1 = new A.NonVisualDrawingPropertiesExtensionList();

            var nonVisualDrawingPropertiesExtension1 = new A.NonVisualDrawingPropertiesExtension() { Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            var openXmlUnknownElement1 = slidePart1.CreateUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{B96E1E96-E2AE-4140-AF58-A89F56E09DD3}\" />");

            nonVisualDrawingPropertiesExtension1.Append(openXmlUnknownElement1);

            nonVisualDrawingPropertiesExtensionList1.Append(nonVisualDrawingPropertiesExtension1);

            nonVisualDrawingProperties2.Append(nonVisualDrawingPropertiesExtensionList1);
            var nonVisualGraphicFrameDrawingProperties1 = new NonVisualGraphicFrameDrawingProperties();

            var applicationNonVisualDrawingProperties2 = new ApplicationNonVisualDrawingProperties();

            var applicationNonVisualDrawingPropertiesExtensionList1 = new ApplicationNonVisualDrawingPropertiesExtensionList();

            var applicationNonVisualDrawingPropertiesExtension1 = new ApplicationNonVisualDrawingPropertiesExtension() { Uri = "{D42A27DB-BD31-4B8C-83A1-F6EECF244321}" };

            var modificationId1 = new P14.ModificationId() { Val = (UInt32Value)4121318566U };
            modificationId1.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            applicationNonVisualDrawingPropertiesExtension1.Append(modificationId1);

            applicationNonVisualDrawingPropertiesExtensionList1.Append(applicationNonVisualDrawingPropertiesExtension1);

            applicationNonVisualDrawingProperties2.Append(applicationNonVisualDrawingPropertiesExtensionList1);

            nonVisualGraphicFrameProperties1.Append(nonVisualDrawingProperties2);
            nonVisualGraphicFrameProperties1.Append(nonVisualGraphicFrameDrawingProperties1);
            nonVisualGraphicFrameProperties1.Append(applicationNonVisualDrawingProperties2);

            var transform1 = new Transform();
            var offset2 = new A.Offset() { X = 2032000L, Y = 719666L };
            var extents2 = new A.Extents() { Cx = 8128000L, Cy = 5418667L };

            transform1.Append(offset2);
            transform1.Append(extents2);

            var graphic1 = new A.Graphic();

            // A.GraphicData graphicData1 = new A.GraphicData(){ Uri = "http://schemas.openxmlformats.org/drawingml/2006/chart" };
            var graphicData1 = new A.GraphicData() { Uri = "http://schemas.microsoft.com/office/drawing/2014/chartex" };

            var chartReference1 = new C.ChartReference() { Id = "rId2" };
            chartReference1.AddNamespaceDeclaration("cx", "http://schemas.microsoft.com/office/drawing/2014/chartex");
            chartReference1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");

            graphicData1.Append(chartReference1);

            graphic1.Append(graphicData1);

            graphicFrame1.Append(nonVisualGraphicFrameProperties1);
            graphicFrame1.Append(transform1);
            graphicFrame1.Append(graphic1);
            choice.Append(graphicFrame1);

            // This section is for the AlternateContent:Fallback block
            var pic = new Picture();
            var nvPicPr1 = new NonVisualPictureProperties();
            var nonVisualDrawingProperties3 = new NonVisualDrawingProperties() { Id = (UInt32Value)6U, Name = "Chart 5" };

            var nonVisualDrawingPropertiesExtensionList2 = new A.NonVisualDrawingPropertiesExtensionList();

            var nonVisualDrawingPropertiesExtension2 = new A.NonVisualDrawingPropertiesExtension() { Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            var openXmlUnknownElement2 = slidePart1.CreateUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{B96E1E96-E2AE-4140-AF58-A89F56E09DD3}\" />");

            nonVisualDrawingPropertiesExtension2.Append(openXmlUnknownElement2);

            nonVisualDrawingPropertiesExtensionList2.Append(nonVisualDrawingPropertiesExtension2);

            nonVisualDrawingProperties3.Append(nonVisualDrawingPropertiesExtensionList2);

            var nonVisualPictureDrawingProperties1 = new NonVisualPictureDrawingProperties();
            var picLocks1 = new A.PictureLocks
            {
                NoGrouping = true,
                NoRotation = true,
                NoChangeAspect = true,
                NoMove = true,
                NoResize = true,
                NoEditPoints = true,
                NoAdjustHandles = true,
                NoChangeArrowheads = true,
                NoChangeShapeType = true,
            };

            nonVisualPictureDrawingProperties1.Append(picLocks1);
            var applicationNonVisualDrawingProperties3 = new ApplicationNonVisualDrawingProperties();
            nvPicPr1.Append(nonVisualDrawingProperties3);
            nvPicPr1.Append(nonVisualPictureDrawingProperties1);
            nvPicPr1.Append(applicationNonVisualDrawingProperties3);

            var blipFill = new BlipFill();
            var blip = new A.Blip { Embed = "rId3" };
            var stretch = new A.Stretch(new A.FillRectangle());
            blipFill.Append(blip);
            blipFill.Append(stretch);
            var spPr = new ShapeProperties();
            var tform1 = new A.Transform2D();
            var toff1 = new A.Offset { X = 2032000, Y = 719666 };
            var extents3 = new A.Extents { Cx = 8128000, Cy = 5418667 };
            tform1.Append(toff1);
            tform1.Append(extents3);
            var prstGeom1 = new A.PresetGeometry { Preset = DocumentFormat.OpenXml.Drawing.ShapeTypeValues.Rectangle };
            var avLst1 = new A.AdjustValueList();
            prstGeom1.Append(avLst1);
            spPr.Append(tform1);
            spPr.Append(prstGeom1);
            pic.Append(nvPicPr1);
            pic.Append(blipFill);
            pic.Append(spPr);
            fallback.Append(pic);

            // Put the choice and fallback pieces into place in the AlternateConent block
            ac.Append(choice);
            ac.Append(fallback);

            shapeTree1.Append(nonVisualGroupShapeProperties1);
            shapeTree1.Append(groupShapeProperties1);
            shapeTree1.Append(ac);

            var commonSlideDataExtensionList1 = new CommonSlideDataExtensionList();

            var commonSlideDataExtension1 = new CommonSlideDataExtension() { Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            var creationId1 = new P14.CreationId() { Val = (UInt32Value)2744850084U };
            creationId1.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension1.Append(creationId1);

            commonSlideDataExtensionList1.Append(commonSlideDataExtension1);

            commonSlideData1.Append(shapeTree1);
            commonSlideData1.Append(commonSlideDataExtensionList1);

            var colorMapOverride1 = new ColorMapOverride();
            var masterColorMapping1 = new A.MasterColorMapping();

            colorMapOverride1.Append(masterColorMapping1);

            slide1.Append(commonSlideData1);
            slide1.Append(colorMapOverride1);

            slidePart1.Slide = slide1;
        }

        private static SlideLayoutPart CreateSlideLayoutPart(SlidePart slidePart1)
        {
            var slideLayoutPart1 = slidePart1.AddNewPart<SlideLayoutPart>("rId1");
            var slideLayout = new SlideLayout(
            new CommonSlideData(new ShapeTree(
              new NonVisualGroupShapeProperties(
              new NonVisualDrawingProperties() { Id = (UInt32Value)1U, Name = string.Empty },
              new NonVisualGroupShapeDrawingProperties(),
              new ApplicationNonVisualDrawingProperties()),
              new GroupShapeProperties(new A.TransformGroup()),
              new Shape(
              new NonVisualShapeProperties(
                new NonVisualDrawingProperties() { Id = (UInt32Value)2U, Name = string.Empty },
                new NonVisualShapeDrawingProperties(new A.ShapeLocks() { NoGrouping = true }),
                new ApplicationNonVisualDrawingProperties(new PlaceholderShape())),
              new ShapeProperties(),
              new TextBody(
                new A.BodyProperties(),
                new A.ListStyle(),
                new A.Paragraph(new A.EndParagraphRunProperties()))))),
            new ColorMapOverride(new A.MasterColorMapping()));
            slideLayoutPart1.SlideLayout = slideLayout;
            return slideLayoutPart1;
        }

        private static SlideMasterPart CreateSlideMasterPart(SlideLayoutPart slideLayoutPart1)
        {
            var slideMasterPart1 = slideLayoutPart1.AddNewPart<SlideMasterPart>("rId1");
            var slideMaster = new SlideMaster(
            new CommonSlideData(new ShapeTree(
              new NonVisualGroupShapeProperties(
              new NonVisualDrawingProperties() { Id = (UInt32Value)1U, Name = string.Empty },
              new NonVisualGroupShapeDrawingProperties(),
              new ApplicationNonVisualDrawingProperties()),
              new GroupShapeProperties(new A.TransformGroup()),
              new Shape(
              new NonVisualShapeProperties(
                new NonVisualDrawingProperties() { Id = (UInt32Value)2U, Name = "Title Placeholder 1" },
                new NonVisualShapeDrawingProperties(new A.ShapeLocks() { NoGrouping = true }),
                new ApplicationNonVisualDrawingProperties(new PlaceholderShape() { Type = PlaceholderValues.Title })),
              new ShapeProperties(),
              new TextBody(
                new A.BodyProperties(),
                new A.ListStyle(),
                new A.Paragraph())))),
            new ColorMap() { Background1 = A.ColorSchemeIndexValues.Light1, Text1 = A.ColorSchemeIndexValues.Dark1, Background2 = A.ColorSchemeIndexValues.Light2, Text2 = A.ColorSchemeIndexValues.Dark2, Accent1 = A.ColorSchemeIndexValues.Accent1, Accent2 = A.ColorSchemeIndexValues.Accent2, Accent3 = A.ColorSchemeIndexValues.Accent3, Accent4 = A.ColorSchemeIndexValues.Accent4, Accent5 = A.ColorSchemeIndexValues.Accent5, Accent6 = A.ColorSchemeIndexValues.Accent6, Hyperlink = A.ColorSchemeIndexValues.Hyperlink, FollowedHyperlink = A.ColorSchemeIndexValues.FollowedHyperlink },
            new SlideLayoutIdList(new SlideLayoutId() { Id = (UInt32Value)2147483649U, RelationshipId = "rId1" }),
            new TextStyles(new TitleStyle(), new BodyStyle(), new OtherStyle()));
            slideMasterPart1.SlideMaster = slideMaster;

            return slideMasterPart1;
        }

        private static ThemePart CreateTheme(SlideMasterPart slideMasterPart1)
        {
            var themePart1 = slideMasterPart1.AddNewPart<ThemePart>("rId5");
            var theme1 = new A.Theme() { Name = "Office Theme" };

            var themeElements1 = new A.ThemeElements(
            new A.ColorScheme(
              new A.Dark1Color(new A.SystemColor() { Val = A.SystemColorValues.WindowText, LastColor = "000000" }),
              new A.Light1Color(new A.SystemColor() { Val = A.SystemColorValues.Window, LastColor = "FFFFFF" }),
              new A.Dark2Color(new A.RgbColorModelHex() { Val = "1F497D" }),
              new A.Light2Color(new A.RgbColorModelHex() { Val = "EEECE1" }),
              new A.Accent1Color(new A.RgbColorModelHex() { Val = "4F81BD" }),
              new A.Accent2Color(new A.RgbColorModelHex() { Val = "C0504D" }),
              new A.Accent3Color(new A.RgbColorModelHex() { Val = "9BBB59" }),
              new A.Accent4Color(new A.RgbColorModelHex() { Val = "8064A2" }),
              new A.Accent5Color(new A.RgbColorModelHex() { Val = "4BACC6" }),
              new A.Accent6Color(new A.RgbColorModelHex() { Val = "F79646" }),
              new A.Hyperlink(new A.RgbColorModelHex() { Val = "0000FF" }),
              new A.FollowedHyperlinkColor(new A.RgbColorModelHex() { Val = "800080" }))
            { Name = "Office" },
            new A.FontScheme(
              new A.MajorFont(
              new A.LatinFont() { Typeface = "Calibri" },
              new A.EastAsianFont() { Typeface = string.Empty },
              new A.ComplexScriptFont() { Typeface = string.Empty }),
              new A.MinorFont(
              new A.LatinFont() { Typeface = "Calibri" },
              new A.EastAsianFont() { Typeface = string.Empty },
              new A.ComplexScriptFont() { Typeface = string.Empty }))
            { Name = "Office" },
            new A.FormatScheme(
              new A.FillStyleList(
              new A.SolidFill(new A.SchemeColor() { Val = A.SchemeColorValues.PhColor }),
              new A.GradientFill(
                new A.GradientStopList(
                new A.GradientStop(new A.SchemeColor(
                    new A.Tint() { Val = 50000 },
                    new A.SaturationModulation() { Val = 300000 })
                { Val = A.SchemeColorValues.PhColor })
                { Position = 0 },
                new A.GradientStop(new A.SchemeColor(
                    new A.Tint() { Val = 37000 },
                    new A.SaturationModulation() { Val = 300000 })
                { Val = A.SchemeColorValues.PhColor })
                { Position = 35000 },
                new A.GradientStop(new A.SchemeColor(
                    new A.Tint() { Val = 15000 },
                    new A.SaturationModulation() { Val = 350000 })
                { Val = A.SchemeColorValues.PhColor })
                { Position = 100000 }),
                new A.LinearGradientFill() { Angle = 16200000, Scaled = true }),
              new A.NoFill(),
              new A.PatternFill(),
              new A.GroupFill()),
              new A.LineStyleList(
              new A.Outline(
                new A.SolidFill(
                new A.SchemeColor(
                  new A.Shade() { Val = 95000 },
                  new A.SaturationModulation() { Val = 105000 })
                { Val = A.SchemeColorValues.PhColor }),
                new A.PresetDash() { Val = A.PresetLineDashValues.Solid })
              {
                  Width = 9525,
                  CapType = A.LineCapValues.Flat,
                  CompoundLineType = A.CompoundLineValues.Single,
                  Alignment = A.PenAlignmentValues.Center,
              },
              new A.Outline(
                new A.SolidFill(
                new A.SchemeColor(
                  new A.Shade() { Val = 95000 },
                  new A.SaturationModulation() { Val = 105000 })
                { Val = A.SchemeColorValues.PhColor }),
                new A.PresetDash() { Val = A.PresetLineDashValues.Solid })
              {
                  Width = 9525,
                  CapType = A.LineCapValues.Flat,
                  CompoundLineType = A.CompoundLineValues.Single,
                  Alignment = A.PenAlignmentValues.Center,
              },
              new A.Outline(
                new A.SolidFill(
                new A.SchemeColor(
                  new A.Shade() { Val = 95000 },
                  new A.SaturationModulation() { Val = 105000 })
                { Val = A.SchemeColorValues.PhColor }),
                new A.PresetDash() { Val = A.PresetLineDashValues.Solid })
              {
                  Width = 9525,
                  CapType = A.LineCapValues.Flat,
                  CompoundLineType = A.CompoundLineValues.Single,
                  Alignment = A.PenAlignmentValues.Center,
              }),
              new A.EffectStyleList(
              new A.EffectStyle(
                new A.EffectList(
                new A.OuterShadow(
                  new A.RgbColorModelHex(
                  new A.Alpha() { Val = 38000 })
                  { Val = "000000" })
                { BlurRadius = 40000L, Distance = 20000L, Direction = 5400000, RotateWithShape = false })),
              new A.EffectStyle(
                new A.EffectList(
                new A.OuterShadow(
                  new A.RgbColorModelHex(
                  new A.Alpha() { Val = 38000 })
                  { Val = "000000" })
                { BlurRadius = 40000L, Distance = 20000L, Direction = 5400000, RotateWithShape = false })),
              new A.EffectStyle(
                new A.EffectList(
                new A.OuterShadow(
                  new A.RgbColorModelHex(
                  new A.Alpha() { Val = 38000 })
                  { Val = "000000" })
                { BlurRadius = 40000L, Distance = 20000L, Direction = 5400000, RotateWithShape = false }))),
              new A.BackgroundFillStyleList(
              new A.SolidFill(new A.SchemeColor() { Val = A.SchemeColorValues.PhColor }),
              new A.GradientFill(
                new A.GradientStopList(
                new A.GradientStop(
                  new A.SchemeColor(
                      new A.Tint() { Val = 50000 },
                      new A.SaturationModulation() { Val = 300000 })
                  { Val = A.SchemeColorValues.PhColor })
                { Position = 0 },
                new A.GradientStop(
                  new A.SchemeColor(
                      new A.Tint() { Val = 50000 },
                      new A.SaturationModulation() { Val = 300000 })
                  { Val = A.SchemeColorValues.PhColor })
                { Position = 0 },
                new A.GradientStop(
                  new A.SchemeColor(
                      new A.Tint() { Val = 50000 },
                      new A.SaturationModulation() { Val = 300000 })
                  { Val = A.SchemeColorValues.PhColor })
                { Position = 0 }),
                new A.LinearGradientFill() { Angle = 16200000, Scaled = true }),
              new A.GradientFill(
                new A.GradientStopList(
                new A.GradientStop(
                  new A.SchemeColor(
                      new A.Tint() { Val = 50000 },
                      new A.SaturationModulation() { Val = 300000 })
                  { Val = A.SchemeColorValues.PhColor })
                { Position = 0 },
                new A.GradientStop(
                  new A.SchemeColor(
                      new A.Tint() { Val = 50000 },
                      new A.SaturationModulation() { Val = 300000 })
                  { Val = A.SchemeColorValues.PhColor })
                { Position = 0 }),
                new A.LinearGradientFill() { Angle = 16200000, Scaled = true })))
            { Name = "Office" });

            theme1.Append(themeElements1);
            theme1.Append(new A.ObjectDefaults());
            theme1.Append(new A.ExtraColorSchemeList());

            themePart1.Theme = theme1;
            return themePart1;
        }
    }
}
