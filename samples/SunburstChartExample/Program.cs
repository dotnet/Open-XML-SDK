using System;
using System.IO.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using A = DocumentFormat.OpenXml.Drawing;
using P15 = DocumentFormat.OpenXml.Office2013.PowerPoint;
using P14 = DocumentFormat.OpenXml.Office2010.PowerPoint;
using C = DocumentFormat.OpenXml.Drawing.Charts;
using C14 = DocumentFormat.OpenXml.Office2010.Drawing.Charts;
using C15 = DocumentFormat.OpenXml.Office2013.Drawing.Chart;
using C16 = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Cs = DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
using Thm15 = DocumentFormat.OpenXml.Office2013.Theme;
using Op = DocumentFormat.OpenXml.CustomProperties;
using Vt = DocumentFormat.OpenXml.VariantTypes;
using Ap = DocumentFormat.OpenXml.ExtendedProperties;

namespace sunburstppt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Building document {0}.", args[0]);
            ChartPackageCreator cpc = new ChartPackageCreator();
            cpc.CreatePackage(args[0]);
        }
    }

    class ChartPackageCreator
    { 
        // Creates a PresentationDocument.
        public void CreatePackage(string filePath)
        {
            using(PresentationDocument package = PresentationDocument.Create(filePath, PresentationDocumentType.Presentation))
            {
                CreateParts(package);
            }
        }

        // Adds child parts and generates content of the specified part.
        private void CreateParts(PresentationDocument document)
        {
            ThumbnailPart thumbnailPart1 = document.AddNewPart<ThumbnailPart>("image/jpeg", "rId2");
            GenerateThumbnailPart1Content(thumbnailPart1);

            PresentationPart presentationPart1 = document.AddPresentationPart();
            GeneratePresentationPart1Content(presentationPart1);

            PresentationPropertiesPart presentationPropertiesPart1 = presentationPart1.AddNewPart<PresentationPropertiesPart>("rId3");
            GeneratePresentationPropertiesPart1Content(presentationPropertiesPart1);

            SlidePart slidePart1 = presentationPart1.AddNewPart<SlidePart>("rId2");
            GenerateSlidePart1Content(slidePart1);

            ImagePart imagePart1 = slidePart1.AddNewPart<ImagePart>("image/png", "rId3");
            GenerateImagePart1Content(imagePart1);

            // This is the generation of the new Sunburst ChartPart
            ExtendedChartPart chartPart1 = slidePart1.AddNewPart<ExtendedChartPart>("rId2");
            GenerateExtendedChartPart1Content(chartPart1);

            EmbeddedPackagePart embeddedPackagePart1 = chartPart1.AddNewPart<EmbeddedPackagePart>("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "rId3");
            GenerateEmbeddedPackagePart1Content(embeddedPackagePart1);

            ChartColorStylePart chartColorStylePart1 = chartPart1.AddNewPart<ChartColorStylePart>("rId2");
            GenerateChartColorStylePart1Content(chartColorStylePart1);

            ChartStylePart chartStylePart1 = chartPart1.AddNewPart<ChartStylePart>("rId1");
            GenerateChartStylePart1Content(chartStylePart1);

            SlideLayoutPart slideLayoutPart1 = slidePart1.AddNewPart<SlideLayoutPart>("rId1");
            GenerateSlideLayoutPart1Content(slideLayoutPart1);

            SlideMasterPart slideMasterPart1 = slideLayoutPart1.AddNewPart<SlideMasterPart>("rId1");
            GenerateSlideMasterPart1Content(slideMasterPart1);

            SlideLayoutPart slideLayoutPart2 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId8");
            GenerateSlideLayoutPart2Content(slideLayoutPart2);

            slideLayoutPart2.AddPart(slideMasterPart1, "rId1");

            SlideLayoutPart slideLayoutPart3 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId3");
            GenerateSlideLayoutPart3Content(slideLayoutPart3);

            slideLayoutPart3.AddPart(slideMasterPart1, "rId1");

            SlideLayoutPart slideLayoutPart4 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId7");
            GenerateSlideLayoutPart4Content(slideLayoutPart4);

            slideLayoutPart4.AddPart(slideMasterPart1, "rId1");

            ThemePart themePart1 = slideMasterPart1.AddNewPart<ThemePart>("rId12");
            GenerateThemePart1Content(themePart1);

            SlideLayoutPart slideLayoutPart5 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId2");
            GenerateSlideLayoutPart5Content(slideLayoutPart5);

            slideLayoutPart5.AddPart(slideMasterPart1, "rId1");

            slideMasterPart1.AddPart(slideLayoutPart1, "rId1");

            SlideLayoutPart slideLayoutPart6 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId6");
            GenerateSlideLayoutPart6Content(slideLayoutPart6);

            slideLayoutPart6.AddPart(slideMasterPart1, "rId1");

            SlideLayoutPart slideLayoutPart7 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId11");
            GenerateSlideLayoutPart7Content(slideLayoutPart7);

            slideLayoutPart7.AddPart(slideMasterPart1, "rId1");

            SlideLayoutPart slideLayoutPart8 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId5");
            GenerateSlideLayoutPart8Content(slideLayoutPart8);

            slideLayoutPart8.AddPart(slideMasterPart1, "rId1");

            SlideLayoutPart slideLayoutPart9 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId10");
            GenerateSlideLayoutPart9Content(slideLayoutPart9);

            slideLayoutPart9.AddPart(slideMasterPart1, "rId1");

            SlideLayoutPart slideLayoutPart10 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId4");
            GenerateSlideLayoutPart10Content(slideLayoutPart10);

            slideLayoutPart10.AddPart(slideMasterPart1, "rId1");

            SlideLayoutPart slideLayoutPart11 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId9");
            GenerateSlideLayoutPart11Content(slideLayoutPart11);

            slideLayoutPart11.AddPart(slideMasterPart1, "rId1");

            presentationPart1.AddPart(slideMasterPart1, "rId1");

            TableStylesPart tableStylesPart1 = presentationPart1.AddNewPart<TableStylesPart>("rId6");
            GenerateTableStylesPart1Content(tableStylesPart1);

            presentationPart1.AddPart(themePart1, "rId5");

            ViewPropertiesPart viewPropertiesPart1 = presentationPart1.AddNewPart<ViewPropertiesPart>("rId4");
            GenerateViewPropertiesPart1Content(viewPropertiesPart1);

            CustomFilePropertiesPart customFilePropertiesPart1 = document.AddNewPart<CustomFilePropertiesPart>("rId5");
            GenerateCustomFilePropertiesPart1Content(customFilePropertiesPart1);

            ExtendedFilePropertiesPart extendedFilePropertiesPart1 = document.AddNewPart<ExtendedFilePropertiesPart>("rId4");
            GenerateExtendedFilePropertiesPart1Content(extendedFilePropertiesPart1);

            SetPackageProperties(document);
        }

        // Generates content of thumbnailPart1.
        private void GenerateThumbnailPart1Content(ThumbnailPart thumbnailPart1)
        {
            System.IO.Stream data = GetBinaryDataStream(thumbnailPart1Data);
            thumbnailPart1.FeedData(data);
            data.Close();
        }

        // Generates the content of imagePart1
        private void GenerateImagePart1Content(ImagePart imagePart1)
        {
            System.IO.Stream data = GetBinaryDataStream(imagePart1Data);
            imagePart1.FeedData(data);
            data.Close();
        }

        // Generates content of presentationPart1.
        private void GeneratePresentationPart1Content(PresentationPart presentationPart1)
        {
            Presentation presentation1 = new Presentation(){ SaveSubsetFonts = true };
            presentation1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            presentation1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            presentation1.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            SlideMasterIdList slideMasterIdList1 = new SlideMasterIdList();
            SlideMasterId slideMasterId1 = new SlideMasterId(){ Id = (UInt32Value)2147483648U, RelationshipId = "rId1" };

            slideMasterIdList1.Append(slideMasterId1);

            SlideIdList slideIdList1 = new SlideIdList();
            SlideId slideId1 = new SlideId(){ Id = (UInt32Value)256U, RelationshipId = "rId2" };

            slideIdList1.Append(slideId1);
            SlideSize slideSize1 = new SlideSize(){ Cx = 12192000, Cy = 6858000 };
            NotesSize notesSize1 = new NotesSize(){ Cx = 6858000L, Cy = 9144000L };

            DefaultTextStyle defaultTextStyle1 = new DefaultTextStyle();

            A.DefaultParagraphProperties defaultParagraphProperties1 = new A.DefaultParagraphProperties();
            A.DefaultRunProperties defaultRunProperties1 = new A.DefaultRunProperties(){ Language = "en-US" };

            defaultParagraphProperties1.Append(defaultRunProperties1);

            A.Level1ParagraphProperties level1ParagraphProperties1 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties2 = new A.DefaultRunProperties(){ FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill1 = new A.SolidFill();
            A.SchemeColor schemeColor1 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill1.Append(schemeColor1);
            A.LatinFont latinFont1 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont1 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont1 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties2.Append(solidFill1);
            defaultRunProperties2.Append(latinFont1);
            defaultRunProperties2.Append(eastAsianFont1);
            defaultRunProperties2.Append(complexScriptFont1);

            level1ParagraphProperties1.Append(defaultRunProperties2);

            A.Level2ParagraphProperties level2ParagraphProperties1 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties3 = new A.DefaultRunProperties(){ FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill2 = new A.SolidFill();
            A.SchemeColor schemeColor2 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill2.Append(schemeColor2);
            A.LatinFont latinFont2 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont2 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont2 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties3.Append(solidFill2);
            defaultRunProperties3.Append(latinFont2);
            defaultRunProperties3.Append(eastAsianFont2);
            defaultRunProperties3.Append(complexScriptFont2);

            level2ParagraphProperties1.Append(defaultRunProperties3);

            A.Level3ParagraphProperties level3ParagraphProperties1 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties4 = new A.DefaultRunProperties(){ FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill3 = new A.SolidFill();
            A.SchemeColor schemeColor3 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill3.Append(schemeColor3);
            A.LatinFont latinFont3 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont3 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont3 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties4.Append(solidFill3);
            defaultRunProperties4.Append(latinFont3);
            defaultRunProperties4.Append(eastAsianFont3);
            defaultRunProperties4.Append(complexScriptFont3);

            level3ParagraphProperties1.Append(defaultRunProperties4);

            A.Level4ParagraphProperties level4ParagraphProperties1 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties5 = new A.DefaultRunProperties(){ FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill4 = new A.SolidFill();
            A.SchemeColor schemeColor4 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill4.Append(schemeColor4);
            A.LatinFont latinFont4 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont4 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont4 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties5.Append(solidFill4);
            defaultRunProperties5.Append(latinFont4);
            defaultRunProperties5.Append(eastAsianFont4);
            defaultRunProperties5.Append(complexScriptFont4);

            level4ParagraphProperties1.Append(defaultRunProperties5);

            A.Level5ParagraphProperties level5ParagraphProperties1 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties6 = new A.DefaultRunProperties(){ FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill5 = new A.SolidFill();
            A.SchemeColor schemeColor5 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill5.Append(schemeColor5);
            A.LatinFont latinFont5 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont5 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont5 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties6.Append(solidFill5);
            defaultRunProperties6.Append(latinFont5);
            defaultRunProperties6.Append(eastAsianFont5);
            defaultRunProperties6.Append(complexScriptFont5);

            level5ParagraphProperties1.Append(defaultRunProperties6);

            A.Level6ParagraphProperties level6ParagraphProperties1 = new A.Level6ParagraphProperties(){ LeftMargin = 2286000, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties7 = new A.DefaultRunProperties(){ FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill6 = new A.SolidFill();
            A.SchemeColor schemeColor6 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill6.Append(schemeColor6);
            A.LatinFont latinFont6 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont6 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont6 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties7.Append(solidFill6);
            defaultRunProperties7.Append(latinFont6);
            defaultRunProperties7.Append(eastAsianFont6);
            defaultRunProperties7.Append(complexScriptFont6);

            level6ParagraphProperties1.Append(defaultRunProperties7);

            A.Level7ParagraphProperties level7ParagraphProperties1 = new A.Level7ParagraphProperties(){ LeftMargin = 2743200, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties8 = new A.DefaultRunProperties(){ FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill7 = new A.SolidFill();
            A.SchemeColor schemeColor7 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill7.Append(schemeColor7);
            A.LatinFont latinFont7 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont7 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont7 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties8.Append(solidFill7);
            defaultRunProperties8.Append(latinFont7);
            defaultRunProperties8.Append(eastAsianFont7);
            defaultRunProperties8.Append(complexScriptFont7);

            level7ParagraphProperties1.Append(defaultRunProperties8);

            A.Level8ParagraphProperties level8ParagraphProperties1 = new A.Level8ParagraphProperties(){ LeftMargin = 3200400, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties9 = new A.DefaultRunProperties(){ FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill8 = new A.SolidFill();
            A.SchemeColor schemeColor8 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill8.Append(schemeColor8);
            A.LatinFont latinFont8 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont8 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont8 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties9.Append(solidFill8);
            defaultRunProperties9.Append(latinFont8);
            defaultRunProperties9.Append(eastAsianFont8);
            defaultRunProperties9.Append(complexScriptFont8);

            level8ParagraphProperties1.Append(defaultRunProperties9);

            A.Level9ParagraphProperties level9ParagraphProperties1 = new A.Level9ParagraphProperties(){ LeftMargin = 3657600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties10 = new A.DefaultRunProperties(){ FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill9 = new A.SolidFill();
            A.SchemeColor schemeColor9 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill9.Append(schemeColor9);
            A.LatinFont latinFont9 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont9 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont9 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties10.Append(solidFill9);
            defaultRunProperties10.Append(latinFont9);
            defaultRunProperties10.Append(eastAsianFont9);
            defaultRunProperties10.Append(complexScriptFont9);

            level9ParagraphProperties1.Append(defaultRunProperties10);

            defaultTextStyle1.Append(defaultParagraphProperties1);
            defaultTextStyle1.Append(level1ParagraphProperties1);
            defaultTextStyle1.Append(level2ParagraphProperties1);
            defaultTextStyle1.Append(level3ParagraphProperties1);
            defaultTextStyle1.Append(level4ParagraphProperties1);
            defaultTextStyle1.Append(level5ParagraphProperties1);
            defaultTextStyle1.Append(level6ParagraphProperties1);
            defaultTextStyle1.Append(level7ParagraphProperties1);
            defaultTextStyle1.Append(level8ParagraphProperties1);
            defaultTextStyle1.Append(level9ParagraphProperties1);

            PresentationExtensionList presentationExtensionList1 = new PresentationExtensionList();

            PresentationExtension presentationExtension1 = new PresentationExtension(){ Uri = "{EFAFB233-063F-42B5-8137-9DF3F51BA10A}" };

            P15.SlideGuideList slideGuideList1 = new P15.SlideGuideList();
            slideGuideList1.AddNamespaceDeclaration("p15", "http://schemas.microsoft.com/office/powerpoint/2012/main");

            presentationExtension1.Append(slideGuideList1);

            presentationExtensionList1.Append(presentationExtension1);

            presentation1.Append(slideMasterIdList1);
            presentation1.Append(slideIdList1);
            presentation1.Append(slideSize1);
            presentation1.Append(notesSize1);
            presentation1.Append(defaultTextStyle1);
            presentation1.Append(presentationExtensionList1);

            presentationPart1.Presentation = presentation1;
        }

        // Generates content of presentationPropertiesPart1.
        private void GeneratePresentationPropertiesPart1Content(PresentationPropertiesPart presentationPropertiesPart1)
        {
            PresentationProperties presentationProperties1 = new PresentationProperties();
            presentationProperties1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            presentationProperties1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            presentationProperties1.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            PresentationPropertiesExtensionList presentationPropertiesExtensionList1 = new PresentationPropertiesExtensionList();

            PresentationPropertiesExtension presentationPropertiesExtension1 = new PresentationPropertiesExtension(){ Uri = "{E76CE94A-603C-4142-B9EB-6D1370010A27}" };

            P14.DiscardImageEditData discardImageEditData1 = new P14.DiscardImageEditData(){ Val = false };
            discardImageEditData1.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            presentationPropertiesExtension1.Append(discardImageEditData1);

            PresentationPropertiesExtension presentationPropertiesExtension2 = new PresentationPropertiesExtension(){ Uri = "{D31A062A-798A-4329-ABDD-BBA856620510}" };

            P14.DefaultImageDpi defaultImageDpi1 = new P14.DefaultImageDpi(){ Val = (UInt32Value)32767U };
            defaultImageDpi1.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            presentationPropertiesExtension2.Append(defaultImageDpi1);

            PresentationPropertiesExtension presentationPropertiesExtension3 = new PresentationPropertiesExtension(){ Uri = "{FD5EFAAD-0ECE-453E-9831-46B23BE46B34}" };

            P15.ChartTrackingReferenceBased chartTrackingReferenceBased1 = new P15.ChartTrackingReferenceBased(){ Val = true };
            chartTrackingReferenceBased1.AddNamespaceDeclaration("p15", "http://schemas.microsoft.com/office/powerpoint/2012/main");

            presentationPropertiesExtension3.Append(chartTrackingReferenceBased1);

            presentationPropertiesExtensionList1.Append(presentationPropertiesExtension1);
            presentationPropertiesExtensionList1.Append(presentationPropertiesExtension2);
            presentationPropertiesExtensionList1.Append(presentationPropertiesExtension3);

            presentationProperties1.Append(presentationPropertiesExtensionList1);

            presentationPropertiesPart1.PresentationProperties = presentationProperties1;
        }

        // Generates content of slidePart1.
        private void GenerateSlidePart1Content(SlidePart slidePart1)
        {
            Slide slide1 = new Slide();
            slide1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slide1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slide1.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData1 = new CommonSlideData();

            ShapeTree shapeTree1 = new ShapeTree();

            DocumentFormat.OpenXml.Presentation.NonVisualGroupShapeProperties nonVisualGroupShapeProperties1 = new DocumentFormat.OpenXml.Presentation.NonVisualGroupShapeProperties();
            DocumentFormat.OpenXml.Presentation.NonVisualDrawingProperties nonVisualDrawingProperties1 = new DocumentFormat.OpenXml.Presentation.NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            DocumentFormat.OpenXml.Presentation.NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties1 = new DocumentFormat.OpenXml.Presentation.NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties1 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties1.Append(nonVisualDrawingProperties1);
            nonVisualGroupShapeProperties1.Append(nonVisualGroupShapeDrawingProperties1);
            nonVisualGroupShapeProperties1.Append(applicationNonVisualDrawingProperties1);

            DocumentFormat.OpenXml.Presentation.GroupShapeProperties groupShapeProperties1 = new DocumentFormat.OpenXml.Presentation.GroupShapeProperties();

            A.TransformGroup transformGroup1 = new A.TransformGroup();
            A.Offset offset1 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents1 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset1 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents1 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup1.Append(offset1);
            transformGroup1.Append(extents1);
            transformGroup1.Append(childOffset1);
            transformGroup1.Append(childExtents1);

            groupShapeProperties1.Append(transformGroup1);

            AlternateContent ac = new AlternateContent();
            AlternateContentChoice choice = new AlternateContentChoice();
            choice.AddNamespaceDeclaration("cx1", "http://schemas.microsoft.com/office/drawing/2015/9/8/chartex");
            choice.Requires = "cx1";
            AlternateContentFallback fallback = new AlternateContentFallback();
            
            // This section is for the AlternateContent:Choice block

            DocumentFormat.OpenXml.Presentation.GraphicFrame graphicFrame1 = new DocumentFormat.OpenXml.Presentation.GraphicFrame();

            DocumentFormat.OpenXml.Presentation.NonVisualGraphicFrameProperties nonVisualGraphicFrameProperties1 = new DocumentFormat.OpenXml.Presentation.NonVisualGraphicFrameProperties();

            DocumentFormat.OpenXml.Presentation.NonVisualDrawingProperties nonVisualDrawingProperties2 = new DocumentFormat.OpenXml.Presentation.NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Chart 5" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList1 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension1 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement1 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{B96E1E96-E2AE-4140-AF58-A89F56E09DD3}\" />");

            nonVisualDrawingPropertiesExtension1.Append(openXmlUnknownElement1);

            nonVisualDrawingPropertiesExtensionList1.Append(nonVisualDrawingPropertiesExtension1);

            nonVisualDrawingProperties2.Append(nonVisualDrawingPropertiesExtensionList1);
            DocumentFormat.OpenXml.Presentation.NonVisualGraphicFrameDrawingProperties nonVisualGraphicFrameDrawingProperties1 = new DocumentFormat.OpenXml.Presentation.NonVisualGraphicFrameDrawingProperties();

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties2 = new ApplicationNonVisualDrawingProperties();

            ApplicationNonVisualDrawingPropertiesExtensionList applicationNonVisualDrawingPropertiesExtensionList1 = new ApplicationNonVisualDrawingPropertiesExtensionList();

            ApplicationNonVisualDrawingPropertiesExtension applicationNonVisualDrawingPropertiesExtension1 = new ApplicationNonVisualDrawingPropertiesExtension(){ Uri = "{D42A27DB-BD31-4B8C-83A1-F6EECF244321}" };

            P14.ModificationId modificationId1 = new P14.ModificationId(){ Val = (UInt32Value)4121318566U };
            modificationId1.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            applicationNonVisualDrawingPropertiesExtension1.Append(modificationId1);

            applicationNonVisualDrawingPropertiesExtensionList1.Append(applicationNonVisualDrawingPropertiesExtension1);

            applicationNonVisualDrawingProperties2.Append(applicationNonVisualDrawingPropertiesExtensionList1);

            nonVisualGraphicFrameProperties1.Append(nonVisualDrawingProperties2);
            nonVisualGraphicFrameProperties1.Append(nonVisualGraphicFrameDrawingProperties1);
            nonVisualGraphicFrameProperties1.Append(applicationNonVisualDrawingProperties2);

            DocumentFormat.OpenXml.Presentation.Transform transform1 = new DocumentFormat.OpenXml.Presentation.Transform();
            A.Offset offset2 = new A.Offset(){ X = 2032000L, Y = 719666L };
            A.Extents extents2 = new A.Extents(){ Cx = 8128000L, Cy = 5418667L };

            transform1.Append(offset2);
            transform1.Append(extents2);

            A.Graphic graphic1 = new A.Graphic();

            //A.GraphicData graphicData1 = new A.GraphicData(){ Uri = "http://schemas.openxmlformats.org/drawingml/2006/chart" };
            A.GraphicData graphicData1 = new A.GraphicData(){ Uri = "http://schemas.microsoft.com/office/drawing/2014/chartex" };

            C.ChartReference chartReference1 = new C.ChartReference(){ Id = "rId2" };
            chartReference1.AddNamespaceDeclaration("cx", "http://schemas.microsoft.com/office/drawing/2014/chartex");
            chartReference1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");

            graphicData1.Append(chartReference1);

            graphic1.Append(graphicData1);

            graphicFrame1.Append(nonVisualGraphicFrameProperties1);
            graphicFrame1.Append(transform1);
            graphicFrame1.Append(graphic1);
            choice.Append(graphicFrame1);

            // This section is for the AlternateContent:Fallback block
            DocumentFormat.OpenXml.Presentation.Picture pic = new DocumentFormat.OpenXml.Presentation.Picture();
            DocumentFormat.OpenXml.Presentation.NonVisualPictureProperties nvPicPr1 = new DocumentFormat.OpenXml.Presentation.NonVisualPictureProperties();
            DocumentFormat.OpenXml.Presentation.NonVisualDrawingProperties nonVisualDrawingProperties3 = new DocumentFormat.OpenXml.Presentation.NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Chart 5" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList2 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension2 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement2 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{B96E1E96-E2AE-4140-AF58-A89F56E09DD3}\" />");

            nonVisualDrawingPropertiesExtension2.Append(openXmlUnknownElement2);

            nonVisualDrawingPropertiesExtensionList2.Append(nonVisualDrawingPropertiesExtension2);

            nonVisualDrawingProperties3.Append(nonVisualDrawingPropertiesExtensionList2);

            DocumentFormat.OpenXml.Presentation.NonVisualPictureDrawingProperties nonVisualPictureDrawingProperties1 = new DocumentFormat.OpenXml.Presentation.NonVisualPictureDrawingProperties();
            A.PictureLocks picLocks1 = new A.PictureLocks
            {
                NoGrouping = true,
                NoRotation = true,
                NoChangeAspect = true,
                NoMove = true,
                NoResize = true,
                NoEditPoints = true,
                NoAdjustHandles = true,
                NoChangeArrowheads = true,
                NoChangeShapeType = true
            };

            nonVisualPictureDrawingProperties1.Append(picLocks1);
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties3 = new ApplicationNonVisualDrawingProperties();
            nvPicPr1.Append(nonVisualDrawingProperties3);
            nvPicPr1.Append(nonVisualPictureDrawingProperties1);
            nvPicPr1.Append(applicationNonVisualDrawingProperties3);

            DocumentFormat.OpenXml.Presentation.BlipFill blipFill = new DocumentFormat.OpenXml.Presentation.BlipFill();
            A.Blip blip = new A.Blip { Embed = "rId3" };
            A.Stretch stretch = new A.Stretch(new A.FillRectangle());
            blipFill.Append(blip);
            blipFill.Append(stretch);
            DocumentFormat.OpenXml.Presentation.ShapeProperties spPr = new DocumentFormat.OpenXml.Presentation.ShapeProperties();
            A.Transform2D tform1 = new A.Transform2D();
            A.Offset toff1 = new A.Offset { X = 2032000, Y = 719666 };
            A.Extents extents3 = new A.Extents { Cx = 8128000, Cy = 5418667 };
            tform1.Append(toff1);
            tform1.Append(extents3);
            A.PresetGeometry prstGeom1 = new A.PresetGeometry { Preset = DocumentFormat.OpenXml.Drawing.ShapeTypeValues.Rectangle };
            A.AdjustValueList avLst1 = new A.AdjustValueList();
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

            CommonSlideDataExtensionList commonSlideDataExtensionList1 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension1 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId1 = new P14.CreationId(){ Val = (UInt32Value)2744850084U };
            creationId1.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension1.Append(creationId1);

            commonSlideDataExtensionList1.Append(commonSlideDataExtension1);

            commonSlideData1.Append(shapeTree1);
            commonSlideData1.Append(commonSlideDataExtensionList1);

            ColorMapOverride colorMapOverride1 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping1 = new A.MasterColorMapping();

            colorMapOverride1.Append(masterColorMapping1);

            slide1.Append(commonSlideData1);
            slide1.Append(colorMapOverride1);

            slidePart1.Slide = slide1;
        }

        // Generates content of chartPart1.
        private void GenerateChartPart1Content(ChartPart chartPart1)
        {
            C.ChartSpace chartSpace1 = new C.ChartSpace();
            chartSpace1.AddNamespaceDeclaration("c", "http://schemas.openxmlformats.org/drawingml/2006/chart");
            chartSpace1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            chartSpace1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            chartSpace1.AddNamespaceDeclaration("c16r2", "http://schemas.microsoft.com/office/drawing/2015/06/chart");
            C.Date1904 date19041 = new C.Date1904(){ Val = false };
            C.EditingLanguage editingLanguage1 = new C.EditingLanguage(){ Val = "en-US" };
            C.RoundedCorners roundedCorners1 = new C.RoundedCorners(){ Val = false };

            AlternateContent alternateContent1 = new AlternateContent();
            alternateContent1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");

            AlternateContentChoice alternateContentChoice1 = new AlternateContentChoice(){ Requires = "c14" };
            alternateContentChoice1.AddNamespaceDeclaration("c14", "http://schemas.microsoft.com/office/drawing/2007/8/2/chart");
            C14.Style style1 = new C14.Style(){ Val = 102 };

            alternateContentChoice1.Append(style1);

            AlternateContentFallback alternateContentFallback1 = new AlternateContentFallback();
            C.Style style2 = new C.Style(){ Val = 2 };

            alternateContentFallback1.Append(style2);

            alternateContent1.Append(alternateContentChoice1);
            alternateContent1.Append(alternateContentFallback1);

            C.Chart chart1 = new C.Chart();

            C.Title title1 = new C.Title();
            C.Overlay overlay1 = new C.Overlay(){ Val = false };

            C.ChartShapeProperties chartShapeProperties1 = new C.ChartShapeProperties();
            A.NoFill noFill1 = new A.NoFill();

            A.Outline outline1 = new A.Outline();
            A.NoFill noFill2 = new A.NoFill();

            outline1.Append(noFill2);
            A.EffectList effectList1 = new A.EffectList();

            chartShapeProperties1.Append(noFill1);
            chartShapeProperties1.Append(outline1);
            chartShapeProperties1.Append(effectList1);

            C.TextProperties textProperties1 = new C.TextProperties();
            A.BodyProperties bodyProperties1 = new A.BodyProperties(){ Rotation = 0, UseParagraphSpacing = true, VerticalOverflow = A.TextVerticalOverflowValues.Ellipsis, Vertical = A.TextVerticalValues.Horizontal, Wrap = A.TextWrappingValues.Square, Anchor = A.TextAnchoringTypeValues.Center, AnchorCenter = true };
            A.ListStyle listStyle1 = new A.ListStyle();

            A.Paragraph paragraph1 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties1 = new A.ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties11 = new A.DefaultRunProperties(){ FontSize = 1862, Bold = false, Italic = false, Underline = A.TextUnderlineValues.None, Strike = A.TextStrikeValues.NoStrike, Baseline = 0 };

            A.SolidFill solidFill10 = new A.SolidFill();

            A.SchemeColor schemeColor10 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.LuminanceModulation luminanceModulation1 = new A.LuminanceModulation(){ Val = 65000 };
            A.LuminanceOffset luminanceOffset1 = new A.LuminanceOffset(){ Val = 35000 };

            schemeColor10.Append(luminanceModulation1);
            schemeColor10.Append(luminanceOffset1);

            solidFill10.Append(schemeColor10);
            A.LatinFont latinFont10 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont10 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont10 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties11.Append(solidFill10);
            defaultRunProperties11.Append(latinFont10);
            defaultRunProperties11.Append(eastAsianFont10);
            defaultRunProperties11.Append(complexScriptFont10);

            paragraphProperties1.Append(defaultRunProperties11);
            A.EndParagraphRunProperties endParagraphRunProperties1 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph1.Append(paragraphProperties1);
            paragraph1.Append(endParagraphRunProperties1);

            textProperties1.Append(bodyProperties1);
            textProperties1.Append(listStyle1);
            textProperties1.Append(paragraph1);

            title1.Append(overlay1);
            title1.Append(chartShapeProperties1);
            title1.Append(textProperties1);
            C.AutoTitleDeleted autoTitleDeleted1 = new C.AutoTitleDeleted(){ Val = false };

            C.PlotArea plotArea1 = new C.PlotArea();
            C.Layout layout1 = new C.Layout();

            C.BarChart barChart1 = new C.BarChart();
            C.BarDirection barDirection1 = new C.BarDirection(){ Val = C.BarDirectionValues.Column };
            C.BarGrouping barGrouping1 = new C.BarGrouping(){ Val = C.BarGroupingValues.Clustered };
            C.VaryColors varyColors1 = new C.VaryColors(){ Val = false };

            C.BarChartSeries barChartSeries1 = new C.BarChartSeries();
            C.Index index1 = new C.Index(){ Val = (UInt32Value)0U };
            C.Order order1 = new C.Order(){ Val = (UInt32Value)0U };

            C.SeriesText seriesText1 = new C.SeriesText();

            C.StringReference stringReference1 = new C.StringReference();
            C.Formula formula1 = new C.Formula();
            formula1.Text = "Sheet1!$D$1";

            C.StringCache stringCache1 = new C.StringCache();
            C.PointCount pointCount1 = new C.PointCount(){ Val = (UInt32Value)1U };

            C.StringPoint stringPoint1 = new C.StringPoint(){ Index = (UInt32Value)0U };
            C.NumericValue numericValue1 = new C.NumericValue();
            numericValue1.Text = "Series1";

            stringPoint1.Append(numericValue1);

            stringCache1.Append(pointCount1);
            stringCache1.Append(stringPoint1);

            stringReference1.Append(formula1);
            stringReference1.Append(stringCache1);

            seriesText1.Append(stringReference1);

            C.ChartShapeProperties chartShapeProperties2 = new C.ChartShapeProperties();

            A.SolidFill solidFill11 = new A.SolidFill();
            A.SchemeColor schemeColor11 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            solidFill11.Append(schemeColor11);

            A.Outline outline2 = new A.Outline(){ Width = 19050 };

            A.SolidFill solidFill12 = new A.SolidFill();
            A.SchemeColor schemeColor12 = new A.SchemeColor(){ Val = A.SchemeColorValues.Light1 };

            solidFill12.Append(schemeColor12);

            outline2.Append(solidFill12);
            A.EffectList effectList2 = new A.EffectList();

            chartShapeProperties2.Append(solidFill11);
            chartShapeProperties2.Append(outline2);
            chartShapeProperties2.Append(effectList2);
            C.InvertIfNegative invertIfNegative1 = new C.InvertIfNegative(){ Val = false };

            C.DataLabels dataLabels1 = new C.DataLabels();

            C.ChartShapeProperties chartShapeProperties3 = new C.ChartShapeProperties();
            A.NoFill noFill3 = new A.NoFill();

            A.Outline outline3 = new A.Outline();
            A.NoFill noFill4 = new A.NoFill();

            outline3.Append(noFill4);
            A.EffectList effectList3 = new A.EffectList();

            chartShapeProperties3.Append(noFill3);
            chartShapeProperties3.Append(outline3);
            chartShapeProperties3.Append(effectList3);

            C.TextProperties textProperties2 = new C.TextProperties();

            A.BodyProperties bodyProperties2 = new A.BodyProperties(){ Rotation = 0, UseParagraphSpacing = true, VerticalOverflow = A.TextVerticalOverflowValues.Ellipsis, Vertical = A.TextVerticalValues.Horizontal, Wrap = A.TextWrappingValues.Square, LeftInset = 38100, TopInset = 19050, RightInset = 38100, BottomInset = 19050, Anchor = A.TextAnchoringTypeValues.Center, AnchorCenter = true };
            A.ShapeAutoFit shapeAutoFit1 = new A.ShapeAutoFit();

            bodyProperties2.Append(shapeAutoFit1);
            A.ListStyle listStyle2 = new A.ListStyle();

            A.Paragraph paragraph2 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties2 = new A.ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties12 = new A.DefaultRunProperties(){ FontSize = 1197, Bold = false, Italic = false, Underline = A.TextUnderlineValues.None, Strike = A.TextStrikeValues.NoStrike, Baseline = 0 };

            A.SolidFill solidFill13 = new A.SolidFill();
            A.SchemeColor schemeColor13 = new A.SchemeColor(){ Val = A.SchemeColorValues.Light1 };

            solidFill13.Append(schemeColor13);
            A.LatinFont latinFont11 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont11 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont11 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties12.Append(solidFill13);
            defaultRunProperties12.Append(latinFont11);
            defaultRunProperties12.Append(eastAsianFont11);
            defaultRunProperties12.Append(complexScriptFont11);

            paragraphProperties2.Append(defaultRunProperties12);
            A.EndParagraphRunProperties endParagraphRunProperties2 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph2.Append(paragraphProperties2);
            paragraph2.Append(endParagraphRunProperties2);

            textProperties2.Append(bodyProperties2);
            textProperties2.Append(listStyle2);
            textProperties2.Append(paragraph2);
            C.ShowLegendKey showLegendKey1 = new C.ShowLegendKey(){ Val = false };
            C.ShowValue showValue1 = new C.ShowValue(){ Val = true };
            C.ShowCategoryName showCategoryName1 = new C.ShowCategoryName(){ Val = true };
            C.ShowSeriesName showSeriesName1 = new C.ShowSeriesName(){ Val = false };
            C.ShowPercent showPercent1 = new C.ShowPercent(){ Val = false };
            C.ShowBubbleSize showBubbleSize1 = new C.ShowBubbleSize(){ Val = false };
            C.ShowLeaderLines showLeaderLines1 = new C.ShowLeaderLines(){ Val = false };

            C.DLblsExtensionList dLblsExtensionList1 = new C.DLblsExtensionList();

            C.DLblsExtension dLblsExtension1 = new C.DLblsExtension(){ Uri = "{CE6537A1-D6FC-4f65-9D91-7224C49458BB}" };
            dLblsExtension1.AddNamespaceDeclaration("c15", "http://schemas.microsoft.com/office/drawing/2012/chart");
            C15.ShowLeaderLines showLeaderLines2 = new C15.ShowLeaderLines(){ Val = true };

            C15.LeaderLines leaderLines1 = new C15.LeaderLines();

            C.ChartShapeProperties chartShapeProperties4 = new C.ChartShapeProperties();

            A.Outline outline4 = new A.Outline(){ Width = 9525, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill14 = new A.SolidFill();

            A.SchemeColor schemeColor14 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.LuminanceModulation luminanceModulation2 = new A.LuminanceModulation(){ Val = 35000 };
            A.LuminanceOffset luminanceOffset2 = new A.LuminanceOffset(){ Val = 65000 };

            schemeColor14.Append(luminanceModulation2);
            schemeColor14.Append(luminanceOffset2);

            solidFill14.Append(schemeColor14);
            A.Round round1 = new A.Round();

            outline4.Append(solidFill14);
            outline4.Append(round1);
            A.EffectList effectList4 = new A.EffectList();

            chartShapeProperties4.Append(outline4);
            chartShapeProperties4.Append(effectList4);

            leaderLines1.Append(chartShapeProperties4);

            dLblsExtension1.Append(showLeaderLines2);
            dLblsExtension1.Append(leaderLines1);

            dLblsExtensionList1.Append(dLblsExtension1);

            dataLabels1.Append(chartShapeProperties3);
            dataLabels1.Append(textProperties2);
            dataLabels1.Append(showLegendKey1);
            dataLabels1.Append(showValue1);
            dataLabels1.Append(showCategoryName1);
            dataLabels1.Append(showSeriesName1);
            dataLabels1.Append(showPercent1);
            dataLabels1.Append(showBubbleSize1);
            dataLabels1.Append(showLeaderLines1);
            dataLabels1.Append(dLblsExtensionList1);

            C.CategoryAxisData categoryAxisData1 = new C.CategoryAxisData();

            C.MultiLevelStringReference multiLevelStringReference1 = new C.MultiLevelStringReference();
            C.Formula formula2 = new C.Formula();
            formula2.Text = "Sheet1!$A$2:$C$17";

            C.MultiLevelStringCache multiLevelStringCache1 = new C.MultiLevelStringCache();
            C.PointCount pointCount2 = new C.PointCount(){ Val = (UInt32Value)16U };

            C.Level level1 = new C.Level();

            C.StringPoint stringPoint2 = new C.StringPoint(){ Index = (UInt32Value)0U };
            C.NumericValue numericValue2 = new C.NumericValue();
            numericValue2.Text = "Leaf 1";

            stringPoint2.Append(numericValue2);

            C.StringPoint stringPoint3 = new C.StringPoint(){ Index = (UInt32Value)1U };
            C.NumericValue numericValue3 = new C.NumericValue();
            numericValue3.Text = "Leaf 2";

            stringPoint3.Append(numericValue3);

            C.StringPoint stringPoint4 = new C.StringPoint(){ Index = (UInt32Value)2U };
            C.NumericValue numericValue4 = new C.NumericValue();
            numericValue4.Text = "Leaf 3";

            stringPoint4.Append(numericValue4);

            C.StringPoint stringPoint5 = new C.StringPoint(){ Index = (UInt32Value)3U };
            C.NumericValue numericValue5 = new C.NumericValue();
            numericValue5.Text = "Leaf 4";

            stringPoint5.Append(numericValue5);

            C.StringPoint stringPoint6 = new C.StringPoint(){ Index = (UInt32Value)4U };
            C.NumericValue numericValue6 = new C.NumericValue();
            numericValue6.Text = "Leaf 5";

            stringPoint6.Append(numericValue6);

            C.StringPoint stringPoint7 = new C.StringPoint(){ Index = (UInt32Value)7U };
            C.NumericValue numericValue7 = new C.NumericValue();
            numericValue7.Text = "Leaf 8";

            stringPoint7.Append(numericValue7);

            C.StringPoint stringPoint8 = new C.StringPoint(){ Index = (UInt32Value)9U };
            C.NumericValue numericValue8 = new C.NumericValue();
            numericValue8.Text = "Leaf 10";

            stringPoint8.Append(numericValue8);

            C.StringPoint stringPoint9 = new C.StringPoint(){ Index = (UInt32Value)10U };
            C.NumericValue numericValue9 = new C.NumericValue();
            numericValue9.Text = "Leaf 11";

            stringPoint9.Append(numericValue9);

            C.StringPoint stringPoint10 = new C.StringPoint(){ Index = (UInt32Value)11U };
            C.NumericValue numericValue10 = new C.NumericValue();
            numericValue10.Text = "Leaf 12";

            stringPoint10.Append(numericValue10);

            C.StringPoint stringPoint11 = new C.StringPoint(){ Index = (UInt32Value)12U };
            C.NumericValue numericValue11 = new C.NumericValue();
            numericValue11.Text = "Leaf 13";

            stringPoint11.Append(numericValue11);

            C.StringPoint stringPoint12 = new C.StringPoint(){ Index = (UInt32Value)13U };
            C.NumericValue numericValue12 = new C.NumericValue();
            numericValue12.Text = "Leaf 14";

            stringPoint12.Append(numericValue12);

            C.StringPoint stringPoint13 = new C.StringPoint(){ Index = (UInt32Value)14U };
            C.NumericValue numericValue13 = new C.NumericValue();
            numericValue13.Text = "Leaf 15";

            stringPoint13.Append(numericValue13);

            level1.Append(stringPoint2);
            level1.Append(stringPoint3);
            level1.Append(stringPoint4);
            level1.Append(stringPoint5);
            level1.Append(stringPoint6);
            level1.Append(stringPoint7);
            level1.Append(stringPoint8);
            level1.Append(stringPoint9);
            level1.Append(stringPoint10);
            level1.Append(stringPoint11);
            level1.Append(stringPoint12);
            level1.Append(stringPoint13);

            C.Level level2 = new C.Level();

            C.StringPoint stringPoint14 = new C.StringPoint(){ Index = (UInt32Value)0U };
            C.NumericValue numericValue14 = new C.NumericValue();
            numericValue14.Text = "Stem 1";

            stringPoint14.Append(numericValue14);

            C.StringPoint stringPoint15 = new C.StringPoint(){ Index = (UInt32Value)1U };
            C.NumericValue numericValue15 = new C.NumericValue();
            numericValue15.Text = "Stem 1";

            stringPoint15.Append(numericValue15);

            C.StringPoint stringPoint16 = new C.StringPoint(){ Index = (UInt32Value)2U };
            C.NumericValue numericValue16 = new C.NumericValue();
            numericValue16.Text = "Stem 1";

            stringPoint16.Append(numericValue16);

            C.StringPoint stringPoint17 = new C.StringPoint(){ Index = (UInt32Value)3U };
            C.NumericValue numericValue17 = new C.NumericValue();
            numericValue17.Text = "Stem 2";

            stringPoint17.Append(numericValue17);

            C.StringPoint stringPoint18 = new C.StringPoint(){ Index = (UInt32Value)4U };
            C.NumericValue numericValue18 = new C.NumericValue();
            numericValue18.Text = "Stem 2";

            stringPoint18.Append(numericValue18);

            C.StringPoint stringPoint19 = new C.StringPoint(){ Index = (UInt32Value)5U };
            C.NumericValue numericValue19 = new C.NumericValue();
            numericValue19.Text = "Leaf 6";

            stringPoint19.Append(numericValue19);

            C.StringPoint stringPoint20 = new C.StringPoint(){ Index = (UInt32Value)6U };
            C.NumericValue numericValue20 = new C.NumericValue();
            numericValue20.Text = "Leaf 7";

            stringPoint20.Append(numericValue20);

            C.StringPoint stringPoint21 = new C.StringPoint(){ Index = (UInt32Value)7U };
            C.NumericValue numericValue21 = new C.NumericValue();
            numericValue21.Text = "Stem 3";

            stringPoint21.Append(numericValue21);

            C.StringPoint stringPoint22 = new C.StringPoint(){ Index = (UInt32Value)8U };
            C.NumericValue numericValue22 = new C.NumericValue();
            numericValue22.Text = "Leaf 9";

            stringPoint22.Append(numericValue22);

            C.StringPoint stringPoint23 = new C.StringPoint(){ Index = (UInt32Value)9U };
            C.NumericValue numericValue23 = new C.NumericValue();
            numericValue23.Text = "Stem 4";

            stringPoint23.Append(numericValue23);

            C.StringPoint stringPoint24 = new C.StringPoint(){ Index = (UInt32Value)10U };
            C.NumericValue numericValue24 = new C.NumericValue();
            numericValue24.Text = "Stem 4";

            stringPoint24.Append(numericValue24);

            C.StringPoint stringPoint25 = new C.StringPoint(){ Index = (UInt32Value)11U };
            C.NumericValue numericValue25 = new C.NumericValue();
            numericValue25.Text = "Stem 5";

            stringPoint25.Append(numericValue25);

            C.StringPoint stringPoint26 = new C.StringPoint(){ Index = (UInt32Value)12U };
            C.NumericValue numericValue26 = new C.NumericValue();
            numericValue26.Text = "Stem 5";

            stringPoint26.Append(numericValue26);

            C.StringPoint stringPoint27 = new C.StringPoint(){ Index = (UInt32Value)13U };
            C.NumericValue numericValue27 = new C.NumericValue();
            numericValue27.Text = "Stem 6";

            stringPoint27.Append(numericValue27);

            C.StringPoint stringPoint28 = new C.StringPoint(){ Index = (UInt32Value)14U };
            C.NumericValue numericValue28 = new C.NumericValue();
            numericValue28.Text = "Stem 6";

            stringPoint28.Append(numericValue28);

            C.StringPoint stringPoint29 = new C.StringPoint(){ Index = (UInt32Value)15U };
            C.NumericValue numericValue29 = new C.NumericValue();
            numericValue29.Text = "Leaf 16";

            stringPoint29.Append(numericValue29);

            level2.Append(stringPoint14);
            level2.Append(stringPoint15);
            level2.Append(stringPoint16);
            level2.Append(stringPoint17);
            level2.Append(stringPoint18);
            level2.Append(stringPoint19);
            level2.Append(stringPoint20);
            level2.Append(stringPoint21);
            level2.Append(stringPoint22);
            level2.Append(stringPoint23);
            level2.Append(stringPoint24);
            level2.Append(stringPoint25);
            level2.Append(stringPoint26);
            level2.Append(stringPoint27);
            level2.Append(stringPoint28);
            level2.Append(stringPoint29);

            C.Level level3 = new C.Level();

            C.StringPoint stringPoint30 = new C.StringPoint(){ Index = (UInt32Value)0U };
            C.NumericValue numericValue30 = new C.NumericValue();
            numericValue30.Text = "Branch 1";

            stringPoint30.Append(numericValue30);

            C.StringPoint stringPoint31 = new C.StringPoint(){ Index = (UInt32Value)1U };
            C.NumericValue numericValue31 = new C.NumericValue();
            numericValue31.Text = "Branch 1";

            stringPoint31.Append(numericValue31);

            C.StringPoint stringPoint32 = new C.StringPoint(){ Index = (UInt32Value)2U };
            C.NumericValue numericValue32 = new C.NumericValue();
            numericValue32.Text = "Branch 1";

            stringPoint32.Append(numericValue32);

            C.StringPoint stringPoint33 = new C.StringPoint(){ Index = (UInt32Value)3U };
            C.NumericValue numericValue33 = new C.NumericValue();
            numericValue33.Text = "Branch 1";

            stringPoint33.Append(numericValue33);

            C.StringPoint stringPoint34 = new C.StringPoint(){ Index = (UInt32Value)4U };
            C.NumericValue numericValue34 = new C.NumericValue();
            numericValue34.Text = "Branch 1";

            stringPoint34.Append(numericValue34);

            C.StringPoint stringPoint35 = new C.StringPoint(){ Index = (UInt32Value)5U };
            C.NumericValue numericValue35 = new C.NumericValue();
            numericValue35.Text = "Branch 1";

            stringPoint35.Append(numericValue35);

            C.StringPoint stringPoint36 = new C.StringPoint(){ Index = (UInt32Value)6U };
            C.NumericValue numericValue36 = new C.NumericValue();
            numericValue36.Text = "Branch 1";

            stringPoint36.Append(numericValue36);

            C.StringPoint stringPoint37 = new C.StringPoint(){ Index = (UInt32Value)7U };
            C.NumericValue numericValue37 = new C.NumericValue();
            numericValue37.Text = "Branch 2";

            stringPoint37.Append(numericValue37);

            C.StringPoint stringPoint38 = new C.StringPoint(){ Index = (UInt32Value)8U };
            C.NumericValue numericValue38 = new C.NumericValue();
            numericValue38.Text = "Branch 2";

            stringPoint38.Append(numericValue38);

            C.StringPoint stringPoint39 = new C.StringPoint(){ Index = (UInt32Value)9U };
            C.NumericValue numericValue39 = new C.NumericValue();
            numericValue39.Text = "Branch 2";

            stringPoint39.Append(numericValue39);

            C.StringPoint stringPoint40 = new C.StringPoint(){ Index = (UInt32Value)10U };
            C.NumericValue numericValue40 = new C.NumericValue();
            numericValue40.Text = "Branch 2";

            stringPoint40.Append(numericValue40);

            C.StringPoint stringPoint41 = new C.StringPoint(){ Index = (UInt32Value)11U };
            C.NumericValue numericValue41 = new C.NumericValue();
            numericValue41.Text = "Branch 3";

            stringPoint41.Append(numericValue41);

            C.StringPoint stringPoint42 = new C.StringPoint(){ Index = (UInt32Value)12U };
            C.NumericValue numericValue42 = new C.NumericValue();
            numericValue42.Text = "Branch 3";

            stringPoint42.Append(numericValue42);

            C.StringPoint stringPoint43 = new C.StringPoint(){ Index = (UInt32Value)13U };
            C.NumericValue numericValue43 = new C.NumericValue();
            numericValue43.Text = "Branch 3";

            stringPoint43.Append(numericValue43);

            C.StringPoint stringPoint44 = new C.StringPoint(){ Index = (UInt32Value)14U };
            C.NumericValue numericValue44 = new C.NumericValue();
            numericValue44.Text = "Branch 3";

            stringPoint44.Append(numericValue44);

            C.StringPoint stringPoint45 = new C.StringPoint(){ Index = (UInt32Value)15U };
            C.NumericValue numericValue45 = new C.NumericValue();
            numericValue45.Text = "Branch 3";

            stringPoint45.Append(numericValue45);

            level3.Append(stringPoint30);
            level3.Append(stringPoint31);
            level3.Append(stringPoint32);
            level3.Append(stringPoint33);
            level3.Append(stringPoint34);
            level3.Append(stringPoint35);
            level3.Append(stringPoint36);
            level3.Append(stringPoint37);
            level3.Append(stringPoint38);
            level3.Append(stringPoint39);
            level3.Append(stringPoint40);
            level3.Append(stringPoint41);
            level3.Append(stringPoint42);
            level3.Append(stringPoint43);
            level3.Append(stringPoint44);
            level3.Append(stringPoint45);

            multiLevelStringCache1.Append(pointCount2);
            multiLevelStringCache1.Append(level1);
            multiLevelStringCache1.Append(level2);
            multiLevelStringCache1.Append(level3);

            multiLevelStringReference1.Append(formula2);
            multiLevelStringReference1.Append(multiLevelStringCache1);

            categoryAxisData1.Append(multiLevelStringReference1);

            C.Values values1 = new C.Values();

            C.NumberReference numberReference1 = new C.NumberReference();
            C.Formula formula3 = new C.Formula();
            formula3.Text = "Sheet1!$D$2:$D$17";

            C.NumberingCache numberingCache1 = new C.NumberingCache();
            C.FormatCode formatCode1 = new C.FormatCode();
            formatCode1.Text = "General";
            C.PointCount pointCount3 = new C.PointCount(){ Val = (UInt32Value)16U };

            C.NumericPoint numericPoint1 = new C.NumericPoint(){ Index = (UInt32Value)0U };
            C.NumericValue numericValue46 = new C.NumericValue();
            numericValue46.Text = "22";

            numericPoint1.Append(numericValue46);

            C.NumericPoint numericPoint2 = new C.NumericPoint(){ Index = (UInt32Value)1U };
            C.NumericValue numericValue47 = new C.NumericValue();
            numericValue47.Text = "12";

            numericPoint2.Append(numericValue47);

            C.NumericPoint numericPoint3 = new C.NumericPoint(){ Index = (UInt32Value)2U };
            C.NumericValue numericValue48 = new C.NumericValue();
            numericValue48.Text = "18";

            numericPoint3.Append(numericValue48);

            C.NumericPoint numericPoint4 = new C.NumericPoint(){ Index = (UInt32Value)3U };
            C.NumericValue numericValue49 = new C.NumericValue();
            numericValue49.Text = "87";

            numericPoint4.Append(numericValue49);

            C.NumericPoint numericPoint5 = new C.NumericPoint(){ Index = (UInt32Value)4U };
            C.NumericValue numericValue50 = new C.NumericValue();
            numericValue50.Text = "88";

            numericPoint5.Append(numericValue50);

            C.NumericPoint numericPoint6 = new C.NumericPoint(){ Index = (UInt32Value)5U };
            C.NumericValue numericValue51 = new C.NumericValue();
            numericValue51.Text = "17";

            numericPoint6.Append(numericValue51);

            C.NumericPoint numericPoint7 = new C.NumericPoint(){ Index = (UInt32Value)6U };
            C.NumericValue numericValue52 = new C.NumericValue();
            numericValue52.Text = "14";

            numericPoint7.Append(numericValue52);

            C.NumericPoint numericPoint8 = new C.NumericPoint(){ Index = (UInt32Value)7U };
            C.NumericValue numericValue53 = new C.NumericValue();
            numericValue53.Text = "25";

            numericPoint8.Append(numericValue53);

            C.NumericPoint numericPoint9 = new C.NumericPoint(){ Index = (UInt32Value)8U };
            C.NumericValue numericValue54 = new C.NumericValue();
            numericValue54.Text = "16";

            numericPoint9.Append(numericValue54);

            C.NumericPoint numericPoint10 = new C.NumericPoint(){ Index = (UInt32Value)9U };
            C.NumericValue numericValue55 = new C.NumericValue();
            numericValue55.Text = "24";

            numericPoint10.Append(numericValue55);

            C.NumericPoint numericPoint11 = new C.NumericPoint(){ Index = (UInt32Value)10U };
            C.NumericValue numericValue56 = new C.NumericValue();
            numericValue56.Text = "89";

            numericPoint11.Append(numericValue56);

            C.NumericPoint numericPoint12 = new C.NumericPoint(){ Index = (UInt32Value)11U };
            C.NumericValue numericValue57 = new C.NumericValue();
            numericValue57.Text = "16";

            numericPoint12.Append(numericValue57);

            C.NumericPoint numericPoint13 = new C.NumericPoint(){ Index = (UInt32Value)12U };
            C.NumericValue numericValue58 = new C.NumericValue();
            numericValue58.Text = "19";

            numericPoint13.Append(numericValue58);

            C.NumericPoint numericPoint14 = new C.NumericPoint(){ Index = (UInt32Value)13U };
            C.NumericValue numericValue59 = new C.NumericValue();
            numericValue59.Text = "86";

            numericPoint14.Append(numericValue59);

            C.NumericPoint numericPoint15 = new C.NumericPoint(){ Index = (UInt32Value)14U };
            C.NumericValue numericValue60 = new C.NumericValue();
            numericValue60.Text = "23";

            numericPoint15.Append(numericValue60);

            C.NumericPoint numericPoint16 = new C.NumericPoint(){ Index = (UInt32Value)15U };
            C.NumericValue numericValue61 = new C.NumericValue();
            numericValue61.Text = "21";

            numericPoint16.Append(numericValue61);

            numberingCache1.Append(formatCode1);
            numberingCache1.Append(pointCount3);
            numberingCache1.Append(numericPoint1);
            numberingCache1.Append(numericPoint2);
            numberingCache1.Append(numericPoint3);
            numberingCache1.Append(numericPoint4);
            numberingCache1.Append(numericPoint5);
            numberingCache1.Append(numericPoint6);
            numberingCache1.Append(numericPoint7);
            numberingCache1.Append(numericPoint8);
            numberingCache1.Append(numericPoint9);
            numberingCache1.Append(numericPoint10);
            numberingCache1.Append(numericPoint11);
            numberingCache1.Append(numericPoint12);
            numberingCache1.Append(numericPoint13);
            numberingCache1.Append(numericPoint14);
            numberingCache1.Append(numericPoint15);
            numberingCache1.Append(numericPoint16);

            numberReference1.Append(formula3);
            numberReference1.Append(numberingCache1);

            values1.Append(numberReference1);

            C.BarSerExtensionList barSerExtensionList1 = new C.BarSerExtensionList();

            C.BarSerExtension barSerExtension1 = new C.BarSerExtension(){ Uri = "{C3380CC4-5D6E-409C-BE32-E72D297353CC}" };
            barSerExtension1.AddNamespaceDeclaration("c16", "http://schemas.microsoft.com/office/drawing/2014/chart");

            OpenXmlUnknownElement openXmlUnknownElement2 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<c16:uniqueId val=\"{00000000-25A4-4189-806F-758BA9F4A164}\" xmlns:c16=\"http://schemas.microsoft.com/office/drawing/2014/chart\" />");

            barSerExtension1.Append(openXmlUnknownElement2);

            barSerExtensionList1.Append(barSerExtension1);

            barChartSeries1.Append(index1);
            barChartSeries1.Append(order1);
            barChartSeries1.Append(seriesText1);
            barChartSeries1.Append(chartShapeProperties2);
            barChartSeries1.Append(invertIfNegative1);
            barChartSeries1.Append(dataLabels1);
            barChartSeries1.Append(categoryAxisData1);
            barChartSeries1.Append(values1);
            barChartSeries1.Append(barSerExtensionList1);

            C.DataLabels dataLabels2 = new C.DataLabels();
            C.ShowLegendKey showLegendKey2 = new C.ShowLegendKey(){ Val = false };
            C.ShowValue showValue2 = new C.ShowValue(){ Val = false };
            C.ShowCategoryName showCategoryName2 = new C.ShowCategoryName(){ Val = true };
            C.ShowSeriesName showSeriesName2 = new C.ShowSeriesName(){ Val = false };
            C.ShowPercent showPercent2 = new C.ShowPercent(){ Val = true };
            C.ShowBubbleSize showBubbleSize2 = new C.ShowBubbleSize(){ Val = false };

            dataLabels2.Append(showLegendKey2);
            dataLabels2.Append(showValue2);
            dataLabels2.Append(showCategoryName2);
            dataLabels2.Append(showSeriesName2);
            dataLabels2.Append(showPercent2);
            dataLabels2.Append(showBubbleSize2);
            C.GapWidth gapWidth1 = new C.GapWidth(){ Val = (UInt16Value)100U };
            C.AxisId axisId1 = new C.AxisId(){ Val = (UInt32Value)1653052736U };
            C.AxisId axisId2 = new C.AxisId(){ Val = (UInt32Value)2093276144U };

            barChart1.Append(barDirection1);
            barChart1.Append(barGrouping1);
            barChart1.Append(varyColors1);
            barChart1.Append(barChartSeries1);
            barChart1.Append(dataLabels2);
            barChart1.Append(gapWidth1);
            barChart1.Append(axisId1);
            barChart1.Append(axisId2);

            C.CategoryAxis categoryAxis1 = new C.CategoryAxis();
            C.AxisId axisId3 = new C.AxisId(){ Val = (UInt32Value)1653052736U };

            C.Scaling scaling1 = new C.Scaling();
            C.Orientation orientation1 = new C.Orientation(){ Val = C.OrientationValues.MinMax };

            scaling1.Append(orientation1);
            C.Delete delete1 = new C.Delete(){ Val = false };
            C.AxisPosition axisPosition1 = new C.AxisPosition(){ Val = C.AxisPositionValues.Bottom };
            C.NumberingFormat numberingFormat1 = new C.NumberingFormat(){ FormatCode = "General", SourceLinked = true };
            C.MajorTickMark majorTickMark1 = new C.MajorTickMark(){ Val = C.TickMarkValues.Outside };
            C.MinorTickMark minorTickMark1 = new C.MinorTickMark(){ Val = C.TickMarkValues.None };
            C.TickLabelPosition tickLabelPosition1 = new C.TickLabelPosition(){ Val = C.TickLabelPositionValues.NextTo };

            C.ChartShapeProperties chartShapeProperties5 = new C.ChartShapeProperties();
            A.NoFill noFill5 = new A.NoFill();

            A.Outline outline5 = new A.Outline(){ Width = 9525, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill15 = new A.SolidFill();

            A.SchemeColor schemeColor15 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.LuminanceModulation luminanceModulation3 = new A.LuminanceModulation(){ Val = 15000 };
            A.LuminanceOffset luminanceOffset3 = new A.LuminanceOffset(){ Val = 85000 };

            schemeColor15.Append(luminanceModulation3);
            schemeColor15.Append(luminanceOffset3);

            solidFill15.Append(schemeColor15);
            A.Round round2 = new A.Round();

            outline5.Append(solidFill15);
            outline5.Append(round2);
            A.EffectList effectList5 = new A.EffectList();

            chartShapeProperties5.Append(noFill5);
            chartShapeProperties5.Append(outline5);
            chartShapeProperties5.Append(effectList5);

            C.TextProperties textProperties3 = new C.TextProperties();
            A.BodyProperties bodyProperties3 = new A.BodyProperties(){ Rotation = -60000000, UseParagraphSpacing = true, VerticalOverflow = A.TextVerticalOverflowValues.Ellipsis, Vertical = A.TextVerticalValues.Horizontal, Wrap = A.TextWrappingValues.Square, Anchor = A.TextAnchoringTypeValues.Center, AnchorCenter = true };
            A.ListStyle listStyle3 = new A.ListStyle();

            A.Paragraph paragraph3 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties3 = new A.ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties13 = new A.DefaultRunProperties(){ FontSize = 1197, Bold = false, Italic = false, Underline = A.TextUnderlineValues.None, Strike = A.TextStrikeValues.NoStrike, Baseline = 0 };

            A.SolidFill solidFill16 = new A.SolidFill();

            A.SchemeColor schemeColor16 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.LuminanceModulation luminanceModulation4 = new A.LuminanceModulation(){ Val = 65000 };
            A.LuminanceOffset luminanceOffset4 = new A.LuminanceOffset(){ Val = 35000 };

            schemeColor16.Append(luminanceModulation4);
            schemeColor16.Append(luminanceOffset4);

            solidFill16.Append(schemeColor16);
            A.LatinFont latinFont12 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont12 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont12 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties13.Append(solidFill16);
            defaultRunProperties13.Append(latinFont12);
            defaultRunProperties13.Append(eastAsianFont12);
            defaultRunProperties13.Append(complexScriptFont12);

            paragraphProperties3.Append(defaultRunProperties13);
            A.EndParagraphRunProperties endParagraphRunProperties3 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph3.Append(paragraphProperties3);
            paragraph3.Append(endParagraphRunProperties3);

            textProperties3.Append(bodyProperties3);
            textProperties3.Append(listStyle3);
            textProperties3.Append(paragraph3);
            C.CrossingAxis crossingAxis1 = new C.CrossingAxis(){ Val = (UInt32Value)2093276144U };
            C.Crosses crosses1 = new C.Crosses(){ Val = C.CrossesValues.AutoZero };
            C.AutoLabeled autoLabeled1 = new C.AutoLabeled(){ Val = true };
            C.LabelAlignment labelAlignment1 = new C.LabelAlignment(){ Val = C.LabelAlignmentValues.Center };
            C.LabelOffset labelOffset1 = new C.LabelOffset(){ Val = (UInt16Value)100U };
            C.NoMultiLevelLabels noMultiLevelLabels1 = new C.NoMultiLevelLabels(){ Val = false };

            categoryAxis1.Append(axisId3);
            categoryAxis1.Append(scaling1);
            categoryAxis1.Append(delete1);
            categoryAxis1.Append(axisPosition1);
            categoryAxis1.Append(numberingFormat1);
            categoryAxis1.Append(majorTickMark1);
            categoryAxis1.Append(minorTickMark1);
            categoryAxis1.Append(tickLabelPosition1);
            categoryAxis1.Append(chartShapeProperties5);
            categoryAxis1.Append(textProperties3);
            categoryAxis1.Append(crossingAxis1);
            categoryAxis1.Append(crosses1);
            categoryAxis1.Append(autoLabeled1);
            categoryAxis1.Append(labelAlignment1);
            categoryAxis1.Append(labelOffset1);
            categoryAxis1.Append(noMultiLevelLabels1);

            C.ValueAxis valueAxis1 = new C.ValueAxis();
            C.AxisId axisId4 = new C.AxisId(){ Val = (UInt32Value)2093276144U };

            C.Scaling scaling2 = new C.Scaling();
            C.Orientation orientation2 = new C.Orientation(){ Val = C.OrientationValues.MinMax };

            scaling2.Append(orientation2);
            C.Delete delete2 = new C.Delete(){ Val = false };
            C.AxisPosition axisPosition2 = new C.AxisPosition(){ Val = C.AxisPositionValues.Left };

            C.MajorGridlines majorGridlines1 = new C.MajorGridlines();

            C.ChartShapeProperties chartShapeProperties6 = new C.ChartShapeProperties();

            A.Outline outline6 = new A.Outline(){ Width = 9525, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill17 = new A.SolidFill();

            A.SchemeColor schemeColor17 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.LuminanceModulation luminanceModulation5 = new A.LuminanceModulation(){ Val = 15000 };
            A.LuminanceOffset luminanceOffset5 = new A.LuminanceOffset(){ Val = 85000 };

            schemeColor17.Append(luminanceModulation5);
            schemeColor17.Append(luminanceOffset5);

            solidFill17.Append(schemeColor17);
            A.Round round3 = new A.Round();

            outline6.Append(solidFill17);
            outline6.Append(round3);
            A.EffectList effectList6 = new A.EffectList();

            chartShapeProperties6.Append(outline6);
            chartShapeProperties6.Append(effectList6);

            majorGridlines1.Append(chartShapeProperties6);
            C.NumberingFormat numberingFormat2 = new C.NumberingFormat(){ FormatCode = "General", SourceLinked = true };
            C.MajorTickMark majorTickMark2 = new C.MajorTickMark(){ Val = C.TickMarkValues.Outside };
            C.MinorTickMark minorTickMark2 = new C.MinorTickMark(){ Val = C.TickMarkValues.None };
            C.TickLabelPosition tickLabelPosition2 = new C.TickLabelPosition(){ Val = C.TickLabelPositionValues.NextTo };

            C.ChartShapeProperties chartShapeProperties7 = new C.ChartShapeProperties();
            A.NoFill noFill6 = new A.NoFill();

            A.Outline outline7 = new A.Outline();
            A.NoFill noFill7 = new A.NoFill();

            outline7.Append(noFill7);
            A.EffectList effectList7 = new A.EffectList();

            chartShapeProperties7.Append(noFill6);
            chartShapeProperties7.Append(outline7);
            chartShapeProperties7.Append(effectList7);

            C.TextProperties textProperties4 = new C.TextProperties();
            A.BodyProperties bodyProperties4 = new A.BodyProperties(){ Rotation = -60000000, UseParagraphSpacing = true, VerticalOverflow = A.TextVerticalOverflowValues.Ellipsis, Vertical = A.TextVerticalValues.Horizontal, Wrap = A.TextWrappingValues.Square, Anchor = A.TextAnchoringTypeValues.Center, AnchorCenter = true };
            A.ListStyle listStyle4 = new A.ListStyle();

            A.Paragraph paragraph4 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties4 = new A.ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties14 = new A.DefaultRunProperties(){ FontSize = 1197, Bold = false, Italic = false, Underline = A.TextUnderlineValues.None, Strike = A.TextStrikeValues.NoStrike, Baseline = 0 };

            A.SolidFill solidFill18 = new A.SolidFill();

            A.SchemeColor schemeColor18 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.LuminanceModulation luminanceModulation6 = new A.LuminanceModulation(){ Val = 65000 };
            A.LuminanceOffset luminanceOffset6 = new A.LuminanceOffset(){ Val = 35000 };

            schemeColor18.Append(luminanceModulation6);
            schemeColor18.Append(luminanceOffset6);

            solidFill18.Append(schemeColor18);
            A.LatinFont latinFont13 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont13 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont13 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties14.Append(solidFill18);
            defaultRunProperties14.Append(latinFont13);
            defaultRunProperties14.Append(eastAsianFont13);
            defaultRunProperties14.Append(complexScriptFont13);

            paragraphProperties4.Append(defaultRunProperties14);
            A.EndParagraphRunProperties endParagraphRunProperties4 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph4.Append(paragraphProperties4);
            paragraph4.Append(endParagraphRunProperties4);

            textProperties4.Append(bodyProperties4);
            textProperties4.Append(listStyle4);
            textProperties4.Append(paragraph4);
            C.CrossingAxis crossingAxis2 = new C.CrossingAxis(){ Val = (UInt32Value)1653052736U };
            C.Crosses crosses2 = new C.Crosses(){ Val = C.CrossesValues.AutoZero };
            C.CrossBetween crossBetween1 = new C.CrossBetween(){ Val = C.CrossBetweenValues.Between };

            valueAxis1.Append(axisId4);
            valueAxis1.Append(scaling2);
            valueAxis1.Append(delete2);
            valueAxis1.Append(axisPosition2);
            valueAxis1.Append(majorGridlines1);
            valueAxis1.Append(numberingFormat2);
            valueAxis1.Append(majorTickMark2);
            valueAxis1.Append(minorTickMark2);
            valueAxis1.Append(tickLabelPosition2);
            valueAxis1.Append(chartShapeProperties7);
            valueAxis1.Append(textProperties4);
            valueAxis1.Append(crossingAxis2);
            valueAxis1.Append(crosses2);
            valueAxis1.Append(crossBetween1);

            C.ShapeProperties shapeProperties1 = new C.ShapeProperties();
            A.NoFill noFill8 = new A.NoFill();

            A.Outline outline8 = new A.Outline();
            A.NoFill noFill9 = new A.NoFill();

            outline8.Append(noFill9);
            A.EffectList effectList8 = new A.EffectList();

            shapeProperties1.Append(noFill8);
            shapeProperties1.Append(outline8);
            shapeProperties1.Append(effectList8);

            plotArea1.Append(layout1);
            plotArea1.Append(barChart1);
            plotArea1.Append(categoryAxis1);
            plotArea1.Append(valueAxis1);
            plotArea1.Append(shapeProperties1);
            C.PlotVisibleOnly plotVisibleOnly1 = new C.PlotVisibleOnly(){ Val = true };
            C.DisplayBlanksAs displayBlanksAs1 = new C.DisplayBlanksAs(){ Val = C.DisplayBlanksAsValues.Gap };

            C.ExtensionList extensionList1 = new C.ExtensionList();

            C.Extension extension1 = new C.Extension(){ Uri = "{56B9EC1D-385E-4148-901F-78D8002777C0}" };
            extension1.AddNamespaceDeclaration("c16r3", "http://schemas.microsoft.com/office/drawing/2017/03/chart");

            OpenXmlUnknownElement openXmlUnknownElement3 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<c16r3:dataDisplayOptions16 xmlns:c16r3=\"http://schemas.microsoft.com/office/drawing/2017/03/chart\"><c16r3:dispNaAsBlank val=\"1\" /></c16r3:dataDisplayOptions16>");

            extension1.Append(openXmlUnknownElement3);

            extensionList1.Append(extension1);
            C.ShowDataLabelsOverMaximum showDataLabelsOverMaximum1 = new C.ShowDataLabelsOverMaximum(){ Val = false };

            chart1.Append(title1);
            chart1.Append(autoTitleDeleted1);
            chart1.Append(plotArea1);
            chart1.Append(plotVisibleOnly1);
            chart1.Append(displayBlanksAs1);
            chart1.Append(extensionList1);
            chart1.Append(showDataLabelsOverMaximum1);

            C.ShapeProperties shapeProperties2 = new C.ShapeProperties();
            A.NoFill noFill10 = new A.NoFill();

            A.Outline outline9 = new A.Outline();
            A.NoFill noFill11 = new A.NoFill();

            outline9.Append(noFill11);
            A.EffectList effectList9 = new A.EffectList();

            shapeProperties2.Append(noFill10);
            shapeProperties2.Append(outline9);
            shapeProperties2.Append(effectList9);

            C.TextProperties textProperties5 = new C.TextProperties();
            A.BodyProperties bodyProperties5 = new A.BodyProperties();
            A.ListStyle listStyle5 = new A.ListStyle();

            A.Paragraph paragraph5 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties5 = new A.ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties15 = new A.DefaultRunProperties();

            paragraphProperties5.Append(defaultRunProperties15);
            A.EndParagraphRunProperties endParagraphRunProperties5 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph5.Append(paragraphProperties5);
            paragraph5.Append(endParagraphRunProperties5);

            textProperties5.Append(bodyProperties5);
            textProperties5.Append(listStyle5);
            textProperties5.Append(paragraph5);

            C.ExternalData externalData1 = new C.ExternalData(){ Id = "rId1"};
            C.AutoUpdate autoUpdate1 = new C.AutoUpdate() { Val = false };

            externalData1.Append(autoUpdate1);

            chartSpace1.Append(externalData1);
            chartSpace1.Append(date19041);
            chartSpace1.Append(editingLanguage1);
            chartSpace1.Append(roundedCorners1);
            chartSpace1.Append(alternateContent1);
            chartSpace1.Append(chart1);
            chartSpace1.Append(shapeProperties2);
            chartSpace1.Append(textProperties5);

            chartPart1.ChartSpace = chartSpace1;
        }

        private void GenerateExtendedChartPart1Content(ExtendedChartPart chartPart1)
        {
            C16.ChartSpace chartSpace1 = new C16.ChartSpace();
            chartSpace1.AddNamespaceDeclaration("cx", "http://schemas.microsoft.com/office/drawing/2014/chartex");
            chartSpace1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            chartSpace1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");

            C16.ChartData chartdata1 = new C16.ChartData();
            C16.ExternalData externalData1 = new C16.ExternalData(){ Id = "rId3", AutoUpdate = false};
            chartdata1.Append(externalData1);
            C16.Data data1 = new C16.Data { Id = 0 };
            C16.StringDimension strDim1 = new C16.StringDimension { Type = C16.StringDimensionType.Cat };
            C16.NumericLevel lvl1 = new C16.NumericLevel { PtCount = 16 };
            lvl1.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue("Leaf 1") { Index = 0 });
            lvl1.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Leaf 2"){ Index = 1 });
            lvl1.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Leaf 3"){ Index = 2 });
            lvl1.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Leaf 4"){ Index = 3 });
            lvl1.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Leaf 5"){ Index = 4 });
            lvl1.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Leaf 8"){ Index = 7 });
            lvl1.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Leaf 10"){ Index = 9 });
            lvl1.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Leaf 11"){ Index = 10 });
            lvl1.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Leaf 12"){ Index = 11 });
            lvl1.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Leaf 13"){ Index = 12 });
            lvl1.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Leaf 14"){ Index = 13 });
            lvl1.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Leaf 15"){ Index = 14 });

            C16.NumericLevel lvl2 = new C16.NumericLevel { PtCount = 16 };
            lvl2.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue("Stem 1") { Index = 0 });
            lvl2.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Stem 1"){ Index = 1 });
            lvl2.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Stem 1"){ Index = 2 });
            lvl2.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Stem 2"){ Index = 3 });
            lvl2.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Stem 2"){ Index = 4 });
            lvl2.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Stem 6"){ Index = 5 });
            lvl2.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Stem 7"){ Index = 6 });
            lvl2.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Stem 3"){ Index = 7 });
            lvl2.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Stem 9"){ Index = 8 });
            lvl2.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Stem 4"){ Index = 9 });
            lvl2.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Stem 4"){ Index = 10 });
            lvl2.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Stem 5"){ Index = 11 });
            lvl2.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Stem 5"){ Index = 12 });
            lvl2.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Stem 6"){ Index = 13 });
            lvl2.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Stem 6"){ Index = 14 });
            lvl2.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Stem 16"){ Index = 15 });

            C16.NumericLevel lvl3 = new C16.NumericLevel { PtCount = 16 };
            lvl3.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue("Branch 1") { Index = 0 });
            lvl3.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Branch 1"){ Index = 1 });
            lvl3.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Branch 1"){ Index = 2 });
            lvl3.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Branch 1"){ Index = 3 });
            lvl3.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Branch 1"){ Index = 4 });
            lvl3.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Branch 1"){ Index = 5 });
            lvl3.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Branch 1"){ Index = 6 });
            lvl3.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Branch 2"){ Index = 7 });
            lvl3.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Branch 2"){ Index = 8 });
            lvl3.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Branch 2"){ Index = 9 });
            lvl3.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Branch 2"){ Index = 10 });
            lvl3.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Branch 3"){ Index = 11 });
            lvl3.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Branch 3"){ Index = 12 });
            lvl3.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Branch 3"){ Index = 13 });
            lvl3.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Branch 3"){ Index = 14 });
            lvl3.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("Branch 5"){ Index = 15 });
            strDim1.AppendChild<C16.Formula>(new C16.Formula("Sheet1!$A$2:$C$17"));
            strDim1.AppendChild<C16.NumericLevel>(lvl1);
            strDim1.AppendChild<C16.NumericLevel>(lvl2);
            strDim1.AppendChild<C16.NumericLevel>(lvl3);

            C16.NumericDimension numDim1 = new C16.NumericDimension { Type = C16.NumericDimensionType.Size };
            C16.NumericLevel lvl4 = new C16.NumericLevel { PtCount = 16, FormatCode = "General" };
            lvl4.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue("22") { Index = 0 });
            lvl4.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("12"){ Index = 1 });
            lvl4.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("18"){ Index = 2 });
            lvl4.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("87"){ Index = 3 });
            lvl4.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("88"){ Index = 4 });
            lvl4.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("17"){ Index = 5 });
            lvl4.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("14"){ Index = 6 });
            lvl4.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("25"){ Index = 7 });
            lvl4.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("16"){ Index = 8 });
            lvl4.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("24"){ Index = 9 });
            lvl4.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("89"){ Index = 10 });
            lvl4.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("16"){ Index = 11 });
            lvl4.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("19"){ Index = 12 });
            lvl4.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("86"){ Index = 13 });
            lvl4.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("23"){ Index = 14 });
            lvl4.AppendChild<C16.ChartStringValue>(new C16.ChartStringValue ("21"){ Index = 15 });
            numDim1.AppendChild<C16.Formula>(new C16.Formula("Sheet1!$D$2:$D$17"));
            numDim1.AppendChild<C16.NumericLevel>(lvl4);
            data1.AppendChild<C16.StringDimension>(strDim1);
            data1.AppendChild<C16.NumericDimension>(numDim1);
            chartdata1.AppendChild<C16.Data>(data1);

            C16.Chart chart1 = new C16.Chart();

            C16.ChartTitle title1 = new C16.ChartTitle {  Overlay = false, Align = C16.PosAlign.Ctr, Pos = C16.SidePos.T };
            chart1.AppendChild<C16.ChartTitle>(title1);

            C16.PlotArea plotArea1 = new C16.PlotArea();
            C16.PlotAreaRegion plotAreaRegion1 = new C16.PlotAreaRegion();
            C16.Series series1 = new C16.Series { LayoutId = C16.SeriesLayout.Sunburst };
            C16.Text text1 = new C16.Text();
            C16.TextData textData1 = new C16.TextData();
            C16.Formula formula1 = new C16.Formula("Sheet1!$D$1");
            C16.VXsdstring vxsdstring1 = new C16.VXsdstring("Series1");
            textData1.AppendChild<C16.Formula>(formula1);
            textData1.AppendChild<C16.VXsdstring>(vxsdstring1);
            text1.AppendChild<C16.TextData>(textData1);

            C16.DataLabels dataLabels1 = new C16.DataLabels { Pos = C16.DataLabelPos.Ctr };
            C16.DataLabelVisibilities dlvisibilities1 = new C16.DataLabelVisibilities { SeriesName = false, CategoryName = true, Value = false };
            C16.DataId dataId1 = new C16.DataId { Val = 0 };
            dataLabels1.AppendChild<C16.DataLabelVisibilities>(dlvisibilities1);
            series1.AppendChild<C16.Text>(text1);
            series1.AppendChild<C16.DataLabels>(dataLabels1);
            series1.AppendChild<C16.DataId>(dataId1);
            plotAreaRegion1.AppendChild<C16.Series>(series1);
            plotArea1.AppendChild<C16.PlotAreaRegion>(plotAreaRegion1);
            chart1.AppendChild<C16.PlotArea>(plotArea1);
            chartSpace1.AppendChild<C16.ChartData>(chartdata1);
            chartSpace1.AppendChild<C16.Chart>(chart1);

            chartPart1.ChartSpace = chartSpace1;
        }

        // Generates content of embeddedPackagePart1.
        private void GenerateEmbeddedPackagePart1Content(EmbeddedPackagePart embeddedPackagePart1)
        {
            System.IO.Stream data = GetBinaryDataStream(embeddedPackagePart1Data);
            embeddedPackagePart1.FeedData(data);
            data.Close();
        }

        // Generates content of chartColorStylePart1.
        private void GenerateChartColorStylePart1Content(ChartColorStylePart chartColorStylePart1)
        {
            Cs.ColorStyle colorStyle1 = new Cs.ColorStyle(){ Method = "cycle", Id = (UInt32Value)10U };
            colorStyle1.AddNamespaceDeclaration("cs", "http://schemas.microsoft.com/office/drawing/2012/chartStyle");
            colorStyle1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            A.SchemeColor schemeColor19 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };
            A.SchemeColor schemeColor20 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent2 };
            A.SchemeColor schemeColor21 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent3 };
            A.SchemeColor schemeColor22 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent4 };
            A.SchemeColor schemeColor23 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent5 };
            A.SchemeColor schemeColor24 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent6 };
            Cs.ColorStyleVariation colorStyleVariation1 = new Cs.ColorStyleVariation();

            Cs.ColorStyleVariation colorStyleVariation2 = new Cs.ColorStyleVariation();
            A.LuminanceModulation luminanceModulation7 = new A.LuminanceModulation(){ Val = 60000 };

            colorStyleVariation2.Append(luminanceModulation7);

            Cs.ColorStyleVariation colorStyleVariation3 = new Cs.ColorStyleVariation();
            A.LuminanceModulation luminanceModulation8 = new A.LuminanceModulation(){ Val = 80000 };
            A.LuminanceOffset luminanceOffset7 = new A.LuminanceOffset(){ Val = 20000 };

            colorStyleVariation3.Append(luminanceModulation8);
            colorStyleVariation3.Append(luminanceOffset7);

            Cs.ColorStyleVariation colorStyleVariation4 = new Cs.ColorStyleVariation();
            A.LuminanceModulation luminanceModulation9 = new A.LuminanceModulation(){ Val = 80000 };

            colorStyleVariation4.Append(luminanceModulation9);

            Cs.ColorStyleVariation colorStyleVariation5 = new Cs.ColorStyleVariation();
            A.LuminanceModulation luminanceModulation10 = new A.LuminanceModulation(){ Val = 60000 };
            A.LuminanceOffset luminanceOffset8 = new A.LuminanceOffset(){ Val = 40000 };

            colorStyleVariation5.Append(luminanceModulation10);
            colorStyleVariation5.Append(luminanceOffset8);

            Cs.ColorStyleVariation colorStyleVariation6 = new Cs.ColorStyleVariation();
            A.LuminanceModulation luminanceModulation11 = new A.LuminanceModulation(){ Val = 50000 };

            colorStyleVariation6.Append(luminanceModulation11);

            Cs.ColorStyleVariation colorStyleVariation7 = new Cs.ColorStyleVariation();
            A.LuminanceModulation luminanceModulation12 = new A.LuminanceModulation(){ Val = 70000 };
            A.LuminanceOffset luminanceOffset9 = new A.LuminanceOffset(){ Val = 30000 };

            colorStyleVariation7.Append(luminanceModulation12);
            colorStyleVariation7.Append(luminanceOffset9);

            Cs.ColorStyleVariation colorStyleVariation8 = new Cs.ColorStyleVariation();
            A.LuminanceModulation luminanceModulation13 = new A.LuminanceModulation(){ Val = 70000 };

            colorStyleVariation8.Append(luminanceModulation13);

            Cs.ColorStyleVariation colorStyleVariation9 = new Cs.ColorStyleVariation();
            A.LuminanceModulation luminanceModulation14 = new A.LuminanceModulation(){ Val = 50000 };
            A.LuminanceOffset luminanceOffset10 = new A.LuminanceOffset(){ Val = 50000 };

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

        // Generates content of chartStylePart1.
        private void GenerateChartStylePart1Content(ChartStylePart chartStylePart1)
        {
            Cs.ChartStyle chartStyle1 = new Cs.ChartStyle(){ Id = (UInt32Value)381U };
            chartStyle1.AddNamespaceDeclaration("cs", "http://schemas.microsoft.com/office/drawing/2012/chartStyle");
            chartStyle1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            Cs.AxisTitle axisTitle1 = new Cs.AxisTitle();
            Cs.LineReference lineReference1 = new Cs.LineReference(){ Index = (UInt32Value)0U };
            Cs.FillReference fillReference1 = new Cs.FillReference(){ Index = (UInt32Value)0U };
            Cs.EffectReference effectReference1 = new Cs.EffectReference(){ Index = (UInt32Value)0U };

            Cs.FontReference fontReference1 = new Cs.FontReference(){ Index = A.FontCollectionIndexValues.Minor };

            A.SchemeColor schemeColor25 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.LuminanceModulation luminanceModulation15 = new A.LuminanceModulation(){ Val = 65000 };
            A.LuminanceOffset luminanceOffset11 = new A.LuminanceOffset(){ Val = 35000 };

            schemeColor25.Append(luminanceModulation15);
            schemeColor25.Append(luminanceOffset11);

            fontReference1.Append(schemeColor25);
            Cs.TextCharacterPropertiesType textCharacterPropertiesType1 = new Cs.TextCharacterPropertiesType(){ FontSize = 1197 };

            axisTitle1.Append(lineReference1);
            axisTitle1.Append(fillReference1);
            axisTitle1.Append(effectReference1);
            axisTitle1.Append(fontReference1);
            axisTitle1.Append(textCharacterPropertiesType1);

            Cs.CategoryAxis categoryAxis2 = new Cs.CategoryAxis();
            Cs.LineReference lineReference2 = new Cs.LineReference(){ Index = (UInt32Value)0U };
            Cs.FillReference fillReference2 = new Cs.FillReference(){ Index = (UInt32Value)0U };
            Cs.EffectReference effectReference2 = new Cs.EffectReference(){ Index = (UInt32Value)0U };

            Cs.FontReference fontReference2 = new Cs.FontReference(){ Index = A.FontCollectionIndexValues.Minor };

            A.SchemeColor schemeColor26 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.LuminanceModulation luminanceModulation16 = new A.LuminanceModulation(){ Val = 65000 };
            A.LuminanceOffset luminanceOffset12 = new A.LuminanceOffset(){ Val = 35000 };

            schemeColor26.Append(luminanceModulation16);
            schemeColor26.Append(luminanceOffset12);

            fontReference2.Append(schemeColor26);

            Cs.ShapeProperties shapeProperties3 = new Cs.ShapeProperties();

            A.Outline outline10 = new A.Outline(){ Width = 9525, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill19 = new A.SolidFill();

            A.SchemeColor schemeColor27 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.LuminanceModulation luminanceModulation17 = new A.LuminanceModulation(){ Val = 15000 };
            A.LuminanceOffset luminanceOffset13 = new A.LuminanceOffset(){ Val = 85000 };

            schemeColor27.Append(luminanceModulation17);
            schemeColor27.Append(luminanceOffset13);

            solidFill19.Append(schemeColor27);
            A.Round round4 = new A.Round();

            outline10.Append(solidFill19);
            outline10.Append(round4);

            shapeProperties3.Append(outline10);
            Cs.TextCharacterPropertiesType textCharacterPropertiesType2 = new Cs.TextCharacterPropertiesType(){ FontSize = 1197 };

            categoryAxis2.Append(lineReference2);
            categoryAxis2.Append(fillReference2);
            categoryAxis2.Append(effectReference2);
            categoryAxis2.Append(fontReference2);
            categoryAxis2.Append(shapeProperties3);
            categoryAxis2.Append(textCharacterPropertiesType2);

            Cs.ChartArea chartArea1 = new Cs.ChartArea(){ Modifiers = new ListValue<StringValue>() { InnerText = "allowNoFillOverride allowNoLineOverride" } };
            Cs.LineReference lineReference3 = new Cs.LineReference(){ Index = (UInt32Value)0U };
            Cs.FillReference fillReference3 = new Cs.FillReference(){ Index = (UInt32Value)0U };
            Cs.EffectReference effectReference3 = new Cs.EffectReference(){ Index = (UInt32Value)0U };

            Cs.FontReference fontReference3 = new Cs.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor28 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference3.Append(schemeColor28);

            Cs.ShapeProperties shapeProperties4 = new Cs.ShapeProperties();

            A.SolidFill solidFill20 = new A.SolidFill();
            A.SchemeColor schemeColor29 = new A.SchemeColor(){ Val = A.SchemeColorValues.Background1 };

            solidFill20.Append(schemeColor29);

            A.Outline outline11 = new A.Outline(){ Width = 9525, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill21 = new A.SolidFill();

            A.SchemeColor schemeColor30 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.LuminanceModulation luminanceModulation18 = new A.LuminanceModulation(){ Val = 15000 };
            A.LuminanceOffset luminanceOffset14 = new A.LuminanceOffset(){ Val = 85000 };

            schemeColor30.Append(luminanceModulation18);
            schemeColor30.Append(luminanceOffset14);

            solidFill21.Append(schemeColor30);
            A.Round round5 = new A.Round();

            outline11.Append(solidFill21);
            outline11.Append(round5);

            shapeProperties4.Append(solidFill20);
            shapeProperties4.Append(outline11);
            Cs.TextCharacterPropertiesType textCharacterPropertiesType3 = new Cs.TextCharacterPropertiesType(){ FontSize = 1330 };

            chartArea1.Append(lineReference3);
            chartArea1.Append(fillReference3);
            chartArea1.Append(effectReference3);
            chartArea1.Append(fontReference3);
            chartArea1.Append(shapeProperties4);
            chartArea1.Append(textCharacterPropertiesType3);

            Cs.DataLabel dataLabel1 = new Cs.DataLabel();
            Cs.LineReference lineReference4 = new Cs.LineReference(){ Index = (UInt32Value)0U };
            Cs.FillReference fillReference4 = new Cs.FillReference(){ Index = (UInt32Value)0U };
            Cs.EffectReference effectReference4 = new Cs.EffectReference(){ Index = (UInt32Value)0U };

            Cs.FontReference fontReference4 = new Cs.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor31 = new A.SchemeColor(){ Val = A.SchemeColorValues.Light1 };

            fontReference4.Append(schemeColor31);
            Cs.TextCharacterPropertiesType textCharacterPropertiesType4 = new Cs.TextCharacterPropertiesType(){ FontSize = 1197 };

            dataLabel1.Append(lineReference4);
            dataLabel1.Append(fillReference4);
            dataLabel1.Append(effectReference4);
            dataLabel1.Append(fontReference4);
            dataLabel1.Append(textCharacterPropertiesType4);

            Cs.DataLabelCallout dataLabelCallout1 = new Cs.DataLabelCallout();
            Cs.LineReference lineReference5 = new Cs.LineReference(){ Index = (UInt32Value)0U };
            Cs.FillReference fillReference5 = new Cs.FillReference(){ Index = (UInt32Value)0U };
            Cs.EffectReference effectReference5 = new Cs.EffectReference(){ Index = (UInt32Value)0U };

            Cs.FontReference fontReference5 = new Cs.FontReference(){ Index = A.FontCollectionIndexValues.Minor };

            A.SchemeColor schemeColor32 = new A.SchemeColor(){ Val = A.SchemeColorValues.Dark1 };
            A.LuminanceModulation luminanceModulation19 = new A.LuminanceModulation(){ Val = 65000 };
            A.LuminanceOffset luminanceOffset15 = new A.LuminanceOffset(){ Val = 35000 };

            schemeColor32.Append(luminanceModulation19);
            schemeColor32.Append(luminanceOffset15);

            fontReference5.Append(schemeColor32);

            Cs.ShapeProperties shapeProperties5 = new Cs.ShapeProperties();

            A.SolidFill solidFill22 = new A.SolidFill();
            A.SchemeColor schemeColor33 = new A.SchemeColor(){ Val = A.SchemeColorValues.Light1 };

            solidFill22.Append(schemeColor33);

            A.Outline outline12 = new A.Outline();

            A.SolidFill solidFill23 = new A.SolidFill();

            A.SchemeColor schemeColor34 = new A.SchemeColor(){ Val = A.SchemeColorValues.Dark1 };
            A.LuminanceModulation luminanceModulation20 = new A.LuminanceModulation(){ Val = 25000 };
            A.LuminanceOffset luminanceOffset16 = new A.LuminanceOffset(){ Val = 75000 };

            schemeColor34.Append(luminanceModulation20);
            schemeColor34.Append(luminanceOffset16);

            solidFill23.Append(schemeColor34);

            outline12.Append(solidFill23);

            shapeProperties5.Append(solidFill22);
            shapeProperties5.Append(outline12);
            Cs.TextCharacterPropertiesType textCharacterPropertiesType5 = new Cs.TextCharacterPropertiesType(){ FontSize = 1197 };

            Cs.TextBodyProperties textBodyProperties1 = new Cs.TextBodyProperties(){ Rotation = 0, UseParagraphSpacing = true, VerticalOverflow = A.TextVerticalOverflowValues.Clip, HorizontalOverflow = A.TextHorizontalOverflowValues.Clip, Vertical = A.TextVerticalValues.Horizontal, Wrap = A.TextWrappingValues.Square, LeftInset = 36576, TopInset = 18288, RightInset = 36576, BottomInset = 18288, Anchor = A.TextAnchoringTypeValues.Center, AnchorCenter = true };
            A.ShapeAutoFit shapeAutoFit2 = new A.ShapeAutoFit();

            textBodyProperties1.Append(shapeAutoFit2);

            dataLabelCallout1.Append(lineReference5);
            dataLabelCallout1.Append(fillReference5);
            dataLabelCallout1.Append(effectReference5);
            dataLabelCallout1.Append(fontReference5);
            dataLabelCallout1.Append(shapeProperties5);
            dataLabelCallout1.Append(textCharacterPropertiesType5);
            dataLabelCallout1.Append(textBodyProperties1);

            Cs.DataPoint dataPoint1 = new Cs.DataPoint();
            Cs.LineReference lineReference6 = new Cs.LineReference(){ Index = (UInt32Value)0U };

            Cs.FillReference fillReference6 = new Cs.FillReference(){ Index = (UInt32Value)0U };
            Cs.StyleColor styleColor1 = new Cs.StyleColor(){ Val = "auto" };

            fillReference6.Append(styleColor1);
            Cs.EffectReference effectReference6 = new Cs.EffectReference(){ Index = (UInt32Value)0U };

            Cs.FontReference fontReference6 = new Cs.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor35 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference6.Append(schemeColor35);

            Cs.ShapeProperties shapeProperties6 = new Cs.ShapeProperties();

            A.SolidFill solidFill24 = new A.SolidFill();
            A.SchemeColor schemeColor36 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill24.Append(schemeColor36);

            A.Outline outline13 = new A.Outline(){ Width = 19050 };

            A.SolidFill solidFill25 = new A.SolidFill();
            A.SchemeColor schemeColor37 = new A.SchemeColor(){ Val = A.SchemeColorValues.Light1 };

            solidFill25.Append(schemeColor37);

            outline13.Append(solidFill25);

            shapeProperties6.Append(solidFill24);
            shapeProperties6.Append(outline13);

            dataPoint1.Append(lineReference6);
            dataPoint1.Append(fillReference6);
            dataPoint1.Append(effectReference6);
            dataPoint1.Append(fontReference6);
            dataPoint1.Append(shapeProperties6);

            Cs.DataPoint3D dataPoint3D1 = new Cs.DataPoint3D();
            Cs.LineReference lineReference7 = new Cs.LineReference(){ Index = (UInt32Value)0U };

            Cs.FillReference fillReference7 = new Cs.FillReference(){ Index = (UInt32Value)0U };
            Cs.StyleColor styleColor2 = new Cs.StyleColor(){ Val = "auto" };

            fillReference7.Append(styleColor2);
            Cs.EffectReference effectReference7 = new Cs.EffectReference(){ Index = (UInt32Value)0U };

            Cs.FontReference fontReference7 = new Cs.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor38 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference7.Append(schemeColor38);

            Cs.ShapeProperties shapeProperties7 = new Cs.ShapeProperties();

            A.SolidFill solidFill26 = new A.SolidFill();
            A.SchemeColor schemeColor39 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill26.Append(schemeColor39);

            shapeProperties7.Append(solidFill26);

            dataPoint3D1.Append(lineReference7);
            dataPoint3D1.Append(fillReference7);
            dataPoint3D1.Append(effectReference7);
            dataPoint3D1.Append(fontReference7);
            dataPoint3D1.Append(shapeProperties7);

            Cs.DataPointLine dataPointLine1 = new Cs.DataPointLine();

            Cs.LineReference lineReference8 = new Cs.LineReference(){ Index = (UInt32Value)0U };
            Cs.StyleColor styleColor3 = new Cs.StyleColor(){ Val = "auto" };

            lineReference8.Append(styleColor3);
            Cs.FillReference fillReference8 = new Cs.FillReference(){ Index = (UInt32Value)0U };
            Cs.EffectReference effectReference8 = new Cs.EffectReference(){ Index = (UInt32Value)0U };

            Cs.FontReference fontReference8 = new Cs.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor40 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference8.Append(schemeColor40);

            Cs.ShapeProperties shapeProperties8 = new Cs.ShapeProperties();

            A.Outline outline14 = new A.Outline(){ Width = 28575, CapType = A.LineCapValues.Round };

            A.SolidFill solidFill27 = new A.SolidFill();
            A.SchemeColor schemeColor41 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill27.Append(schemeColor41);
            A.Round round6 = new A.Round();

            outline14.Append(solidFill27);
            outline14.Append(round6);

            shapeProperties8.Append(outline14);

            dataPointLine1.Append(lineReference8);
            dataPointLine1.Append(fillReference8);
            dataPointLine1.Append(effectReference8);
            dataPointLine1.Append(fontReference8);
            dataPointLine1.Append(shapeProperties8);

            Cs.DataPointMarker dataPointMarker1 = new Cs.DataPointMarker();
            Cs.LineReference lineReference9 = new Cs.LineReference(){ Index = (UInt32Value)0U };

            Cs.FillReference fillReference9 = new Cs.FillReference(){ Index = (UInt32Value)0U };
            Cs.StyleColor styleColor4 = new Cs.StyleColor(){ Val = "auto" };

            fillReference9.Append(styleColor4);
            Cs.EffectReference effectReference9 = new Cs.EffectReference(){ Index = (UInt32Value)0U };

            Cs.FontReference fontReference9 = new Cs.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor42 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference9.Append(schemeColor42);

            Cs.ShapeProperties shapeProperties9 = new Cs.ShapeProperties();

            A.SolidFill solidFill28 = new A.SolidFill();
            A.SchemeColor schemeColor43 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill28.Append(schemeColor43);

            A.Outline outline15 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill29 = new A.SolidFill();
            A.SchemeColor schemeColor44 = new A.SchemeColor(){ Val = A.SchemeColorValues.Light1 };

            solidFill29.Append(schemeColor44);

            outline15.Append(solidFill29);

            shapeProperties9.Append(solidFill28);
            shapeProperties9.Append(outline15);

            dataPointMarker1.Append(lineReference9);
            dataPointMarker1.Append(fillReference9);
            dataPointMarker1.Append(effectReference9);
            dataPointMarker1.Append(fontReference9);
            dataPointMarker1.Append(shapeProperties9);
            Cs.MarkerLayoutProperties markerLayoutProperties1 = new Cs.MarkerLayoutProperties(){ Symbol = Cs.MarkerStyle.Circle, Size = 5 };

            Cs.DataPointWireframe dataPointWireframe1 = new Cs.DataPointWireframe();

            Cs.LineReference lineReference10 = new Cs.LineReference(){ Index = (UInt32Value)0U };
            Cs.StyleColor styleColor5 = new Cs.StyleColor(){ Val = "auto" };

            lineReference10.Append(styleColor5);
            Cs.FillReference fillReference10 = new Cs.FillReference(){ Index = (UInt32Value)0U };
            Cs.EffectReference effectReference10 = new Cs.EffectReference(){ Index = (UInt32Value)0U };

            Cs.FontReference fontReference10 = new Cs.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor45 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference10.Append(schemeColor45);

            Cs.ShapeProperties shapeProperties10 = new Cs.ShapeProperties();

            A.Outline outline16 = new A.Outline(){ Width = 28575, CapType = A.LineCapValues.Round };

            A.SolidFill solidFill30 = new A.SolidFill();
            A.SchemeColor schemeColor46 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill30.Append(schemeColor46);
            A.Round round7 = new A.Round();

            outline16.Append(solidFill30);
            outline16.Append(round7);

            shapeProperties10.Append(outline16);

            dataPointWireframe1.Append(lineReference10);
            dataPointWireframe1.Append(fillReference10);
            dataPointWireframe1.Append(effectReference10);
            dataPointWireframe1.Append(fontReference10);
            dataPointWireframe1.Append(shapeProperties10);

            Cs.DataTableStyle dataTableStyle1 = new Cs.DataTableStyle();
            Cs.LineReference lineReference11 = new Cs.LineReference(){ Index = (UInt32Value)0U };
            Cs.FillReference fillReference11 = new Cs.FillReference(){ Index = (UInt32Value)0U };
            Cs.EffectReference effectReference11 = new Cs.EffectReference(){ Index = (UInt32Value)0U };

            Cs.FontReference fontReference11 = new Cs.FontReference(){ Index = A.FontCollectionIndexValues.Minor };

            A.SchemeColor schemeColor47 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.LuminanceModulation luminanceModulation21 = new A.LuminanceModulation(){ Val = 65000 };
            A.LuminanceOffset luminanceOffset17 = new A.LuminanceOffset(){ Val = 35000 };

            schemeColor47.Append(luminanceModulation21);
            schemeColor47.Append(luminanceOffset17);

            fontReference11.Append(schemeColor47);

            Cs.ShapeProperties shapeProperties11 = new Cs.ShapeProperties();

            A.Outline outline17 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill31 = new A.SolidFill();

            A.SchemeColor schemeColor48 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.LuminanceModulation luminanceModulation22 = new A.LuminanceModulation(){ Val = 15000 };
            A.LuminanceOffset luminanceOffset18 = new A.LuminanceOffset(){ Val = 85000 };

            schemeColor48.Append(luminanceModulation22);
            schemeColor48.Append(luminanceOffset18);

            solidFill31.Append(schemeColor48);

            outline17.Append(solidFill31);

            shapeProperties11.Append(outline17);
            Cs.TextCharacterPropertiesType textCharacterPropertiesType6 = new Cs.TextCharacterPropertiesType(){ FontSize = 1197 };

            dataTableStyle1.Append(lineReference11);
            dataTableStyle1.Append(fillReference11);
            dataTableStyle1.Append(effectReference11);
            dataTableStyle1.Append(fontReference11);
            dataTableStyle1.Append(shapeProperties11);
            dataTableStyle1.Append(textCharacterPropertiesType6);

            Cs.DownBar downBar1 = new Cs.DownBar();
            Cs.LineReference lineReference12 = new Cs.LineReference(){ Index = (UInt32Value)0U };
            Cs.FillReference fillReference12 = new Cs.FillReference(){ Index = (UInt32Value)0U };
            Cs.EffectReference effectReference12 = new Cs.EffectReference(){ Index = (UInt32Value)0U };

            Cs.FontReference fontReference12 = new Cs.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor49 = new A.SchemeColor(){ Val = A.SchemeColorValues.Dark1 };

            fontReference12.Append(schemeColor49);

            Cs.ShapeProperties shapeProperties12 = new Cs.ShapeProperties();

            A.SolidFill solidFill32 = new A.SolidFill();

            A.SchemeColor schemeColor50 = new A.SchemeColor(){ Val = A.SchemeColorValues.Dark1 };
            A.LuminanceModulation luminanceModulation23 = new A.LuminanceModulation(){ Val = 65000 };
            A.LuminanceOffset luminanceOffset19 = new A.LuminanceOffset(){ Val = 35000 };

            schemeColor50.Append(luminanceModulation23);
            schemeColor50.Append(luminanceOffset19);

            solidFill32.Append(schemeColor50);

            A.Outline outline18 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill33 = new A.SolidFill();

            A.SchemeColor schemeColor51 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.LuminanceModulation luminanceModulation24 = new A.LuminanceModulation(){ Val = 65000 };
            A.LuminanceOffset luminanceOffset20 = new A.LuminanceOffset(){ Val = 35000 };

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

            Cs.DropLine dropLine1 = new Cs.DropLine();
            Cs.LineReference lineReference13 = new Cs.LineReference(){ Index = (UInt32Value)0U };
            Cs.FillReference fillReference13 = new Cs.FillReference(){ Index = (UInt32Value)0U };
            Cs.EffectReference effectReference13 = new Cs.EffectReference(){ Index = (UInt32Value)0U };

            Cs.FontReference fontReference13 = new Cs.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor52 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference13.Append(schemeColor52);

            Cs.ShapeProperties shapeProperties13 = new Cs.ShapeProperties();

            A.Outline outline19 = new A.Outline(){ Width = 9525, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill34 = new A.SolidFill();

            A.SchemeColor schemeColor53 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.LuminanceModulation luminanceModulation25 = new A.LuminanceModulation(){ Val = 35000 };
            A.LuminanceOffset luminanceOffset21 = new A.LuminanceOffset(){ Val = 65000 };

            schemeColor53.Append(luminanceModulation25);
            schemeColor53.Append(luminanceOffset21);

            solidFill34.Append(schemeColor53);
            A.Round round8 = new A.Round();

            outline19.Append(solidFill34);
            outline19.Append(round8);

            shapeProperties13.Append(outline19);

            dropLine1.Append(lineReference13);
            dropLine1.Append(fillReference13);
            dropLine1.Append(effectReference13);
            dropLine1.Append(fontReference13);
            dropLine1.Append(shapeProperties13);

            Cs.ErrorBar errorBar1 = new Cs.ErrorBar();
            Cs.LineReference lineReference14 = new Cs.LineReference(){ Index = (UInt32Value)0U };
            Cs.FillReference fillReference14 = new Cs.FillReference(){ Index = (UInt32Value)0U };
            Cs.EffectReference effectReference14 = new Cs.EffectReference(){ Index = (UInt32Value)0U };

            Cs.FontReference fontReference14 = new Cs.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor54 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference14.Append(schemeColor54);

            Cs.ShapeProperties shapeProperties14 = new Cs.ShapeProperties();

            A.Outline outline20 = new A.Outline(){ Width = 9525, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill35 = new A.SolidFill();

            A.SchemeColor schemeColor55 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.LuminanceModulation luminanceModulation26 = new A.LuminanceModulation(){ Val = 65000 };
            A.LuminanceOffset luminanceOffset22 = new A.LuminanceOffset(){ Val = 35000 };

            schemeColor55.Append(luminanceModulation26);
            schemeColor55.Append(luminanceOffset22);

            solidFill35.Append(schemeColor55);
            A.Round round9 = new A.Round();

            outline20.Append(solidFill35);
            outline20.Append(round9);

            shapeProperties14.Append(outline20);

            errorBar1.Append(lineReference14);
            errorBar1.Append(fillReference14);
            errorBar1.Append(effectReference14);
            errorBar1.Append(fontReference14);
            errorBar1.Append(shapeProperties14);

            Cs.Floor floor1 = new Cs.Floor();
            Cs.LineReference lineReference15 = new Cs.LineReference(){ Index = (UInt32Value)0U };
            Cs.FillReference fillReference15 = new Cs.FillReference(){ Index = (UInt32Value)0U };
            Cs.EffectReference effectReference15 = new Cs.EffectReference(){ Index = (UInt32Value)0U };

            Cs.FontReference fontReference15 = new Cs.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor56 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference15.Append(schemeColor56);

            floor1.Append(lineReference15);
            floor1.Append(fillReference15);
            floor1.Append(effectReference15);
            floor1.Append(fontReference15);

            Cs.GridlineMajor gridlineMajor1 = new Cs.GridlineMajor();
            Cs.LineReference lineReference16 = new Cs.LineReference(){ Index = (UInt32Value)0U };
            Cs.FillReference fillReference16 = new Cs.FillReference(){ Index = (UInt32Value)0U };
            Cs.EffectReference effectReference16 = new Cs.EffectReference(){ Index = (UInt32Value)0U };

            Cs.FontReference fontReference16 = new Cs.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor57 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference16.Append(schemeColor57);

            Cs.ShapeProperties shapeProperties15 = new Cs.ShapeProperties();

            A.Outline outline21 = new A.Outline(){ Width = 9525, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill36 = new A.SolidFill();

            A.SchemeColor schemeColor58 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.LuminanceModulation luminanceModulation27 = new A.LuminanceModulation(){ Val = 15000 };
            A.LuminanceOffset luminanceOffset23 = new A.LuminanceOffset(){ Val = 85000 };

            schemeColor58.Append(luminanceModulation27);
            schemeColor58.Append(luminanceOffset23);

            solidFill36.Append(schemeColor58);
            A.Round round10 = new A.Round();

            outline21.Append(solidFill36);
            outline21.Append(round10);

            shapeProperties15.Append(outline21);

            gridlineMajor1.Append(lineReference16);
            gridlineMajor1.Append(fillReference16);
            gridlineMajor1.Append(effectReference16);
            gridlineMajor1.Append(fontReference16);
            gridlineMajor1.Append(shapeProperties15);

            Cs.GridlineMinor gridlineMinor1 = new Cs.GridlineMinor();
            Cs.LineReference lineReference17 = new Cs.LineReference(){ Index = (UInt32Value)0U };
            Cs.FillReference fillReference17 = new Cs.FillReference(){ Index = (UInt32Value)0U };
            Cs.EffectReference effectReference17 = new Cs.EffectReference(){ Index = (UInt32Value)0U };

            Cs.FontReference fontReference17 = new Cs.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor59 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference17.Append(schemeColor59);

            Cs.ShapeProperties shapeProperties16 = new Cs.ShapeProperties();

            A.Outline outline22 = new A.Outline(){ Width = 9525, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill37 = new A.SolidFill();

            A.SchemeColor schemeColor60 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.LuminanceModulation luminanceModulation28 = new A.LuminanceModulation(){ Val = 15000 };
            A.LuminanceOffset luminanceOffset24 = new A.LuminanceOffset(){ Val = 85000 };

            schemeColor60.Append(luminanceModulation28);
            schemeColor60.Append(luminanceOffset24);

            solidFill37.Append(schemeColor60);
            A.Round round11 = new A.Round();

            outline22.Append(solidFill37);
            outline22.Append(round11);

            shapeProperties16.Append(outline22);

            gridlineMinor1.Append(lineReference17);
            gridlineMinor1.Append(fillReference17);
            gridlineMinor1.Append(effectReference17);
            gridlineMinor1.Append(fontReference17);
            gridlineMinor1.Append(shapeProperties16);

            Cs.HiLoLine hiLoLine1 = new Cs.HiLoLine();
            Cs.LineReference lineReference18 = new Cs.LineReference(){ Index = (UInt32Value)0U };
            Cs.FillReference fillReference18 = new Cs.FillReference(){ Index = (UInt32Value)0U };
            Cs.EffectReference effectReference18 = new Cs.EffectReference(){ Index = (UInt32Value)0U };

            Cs.FontReference fontReference18 = new Cs.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor61 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference18.Append(schemeColor61);

            Cs.ShapeProperties shapeProperties17 = new Cs.ShapeProperties();

            A.Outline outline23 = new A.Outline(){ Width = 9525, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill38 = new A.SolidFill();

            A.SchemeColor schemeColor62 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.LuminanceModulation luminanceModulation29 = new A.LuminanceModulation(){ Val = 75000 };
            A.LuminanceOffset luminanceOffset25 = new A.LuminanceOffset(){ Val = 25000 };

            schemeColor62.Append(luminanceModulation29);
            schemeColor62.Append(luminanceOffset25);

            solidFill38.Append(schemeColor62);
            A.Round round12 = new A.Round();

            outline23.Append(solidFill38);
            outline23.Append(round12);

            shapeProperties17.Append(outline23);

            hiLoLine1.Append(lineReference18);
            hiLoLine1.Append(fillReference18);
            hiLoLine1.Append(effectReference18);
            hiLoLine1.Append(fontReference18);
            hiLoLine1.Append(shapeProperties17);

            Cs.LeaderLine leaderLine1 = new Cs.LeaderLine();
            Cs.LineReference lineReference19 = new Cs.LineReference(){ Index = (UInt32Value)0U };
            Cs.FillReference fillReference19 = new Cs.FillReference(){ Index = (UInt32Value)0U };
            Cs.EffectReference effectReference19 = new Cs.EffectReference(){ Index = (UInt32Value)0U };

            Cs.FontReference fontReference19 = new Cs.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor63 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference19.Append(schemeColor63);

            Cs.ShapeProperties shapeProperties18 = new Cs.ShapeProperties();

            A.Outline outline24 = new A.Outline(){ Width = 9525, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill39 = new A.SolidFill();

            A.SchemeColor schemeColor64 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.LuminanceModulation luminanceModulation30 = new A.LuminanceModulation(){ Val = 35000 };
            A.LuminanceOffset luminanceOffset26 = new A.LuminanceOffset(){ Val = 65000 };

            schemeColor64.Append(luminanceModulation30);
            schemeColor64.Append(luminanceOffset26);

            solidFill39.Append(schemeColor64);
            A.Round round13 = new A.Round();

            outline24.Append(solidFill39);
            outline24.Append(round13);

            shapeProperties18.Append(outline24);

            leaderLine1.Append(lineReference19);
            leaderLine1.Append(fillReference19);
            leaderLine1.Append(effectReference19);
            leaderLine1.Append(fontReference19);
            leaderLine1.Append(shapeProperties18);

            Cs.LegendStyle legendStyle1 = new Cs.LegendStyle();
            Cs.LineReference lineReference20 = new Cs.LineReference(){ Index = (UInt32Value)0U };
            Cs.FillReference fillReference20 = new Cs.FillReference(){ Index = (UInt32Value)0U };
            Cs.EffectReference effectReference20 = new Cs.EffectReference(){ Index = (UInt32Value)0U };

            Cs.FontReference fontReference20 = new Cs.FontReference(){ Index = A.FontCollectionIndexValues.Minor };

            A.SchemeColor schemeColor65 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.LuminanceModulation luminanceModulation31 = new A.LuminanceModulation(){ Val = 65000 };
            A.LuminanceOffset luminanceOffset27 = new A.LuminanceOffset(){ Val = 35000 };

            schemeColor65.Append(luminanceModulation31);
            schemeColor65.Append(luminanceOffset27);

            fontReference20.Append(schemeColor65);
            Cs.TextCharacterPropertiesType textCharacterPropertiesType7 = new Cs.TextCharacterPropertiesType(){ FontSize = 1197 };

            legendStyle1.Append(lineReference20);
            legendStyle1.Append(fillReference20);
            legendStyle1.Append(effectReference20);
            legendStyle1.Append(fontReference20);
            legendStyle1.Append(textCharacterPropertiesType7);

            Cs.PlotArea plotArea2 = new Cs.PlotArea(){ Modifiers = new ListValue<StringValue>() { InnerText = "allowNoFillOverride allowNoLineOverride" } };
            Cs.LineReference lineReference21 = new Cs.LineReference(){ Index = (UInt32Value)0U };
            Cs.FillReference fillReference21 = new Cs.FillReference(){ Index = (UInt32Value)0U };
            Cs.EffectReference effectReference21 = new Cs.EffectReference(){ Index = (UInt32Value)0U };

            Cs.FontReference fontReference21 = new Cs.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor66 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference21.Append(schemeColor66);

            plotArea2.Append(lineReference21);
            plotArea2.Append(fillReference21);
            plotArea2.Append(effectReference21);
            plotArea2.Append(fontReference21);

            Cs.PlotArea3D plotArea3D1 = new Cs.PlotArea3D(){ Modifiers = new ListValue<StringValue>() { InnerText = "allowNoFillOverride allowNoLineOverride" } };
            Cs.LineReference lineReference22 = new Cs.LineReference(){ Index = (UInt32Value)0U };
            Cs.FillReference fillReference22 = new Cs.FillReference(){ Index = (UInt32Value)0U };
            Cs.EffectReference effectReference22 = new Cs.EffectReference(){ Index = (UInt32Value)0U };

            Cs.FontReference fontReference22 = new Cs.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor67 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference22.Append(schemeColor67);

            plotArea3D1.Append(lineReference22);
            plotArea3D1.Append(fillReference22);
            plotArea3D1.Append(effectReference22);
            plotArea3D1.Append(fontReference22);

            Cs.SeriesAxis seriesAxis1 = new Cs.SeriesAxis();
            Cs.LineReference lineReference23 = new Cs.LineReference(){ Index = (UInt32Value)0U };
            Cs.FillReference fillReference23 = new Cs.FillReference(){ Index = (UInt32Value)0U };
            Cs.EffectReference effectReference23 = new Cs.EffectReference(){ Index = (UInt32Value)0U };

            Cs.FontReference fontReference23 = new Cs.FontReference(){ Index = A.FontCollectionIndexValues.Minor };

            A.SchemeColor schemeColor68 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.LuminanceModulation luminanceModulation32 = new A.LuminanceModulation(){ Val = 65000 };
            A.LuminanceOffset luminanceOffset28 = new A.LuminanceOffset(){ Val = 35000 };

            schemeColor68.Append(luminanceModulation32);
            schemeColor68.Append(luminanceOffset28);

            fontReference23.Append(schemeColor68);

            Cs.ShapeProperties shapeProperties19 = new Cs.ShapeProperties();

            A.Outline outline25 = new A.Outline(){ Width = 9525, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill40 = new A.SolidFill();

            A.SchemeColor schemeColor69 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.LuminanceModulation luminanceModulation33 = new A.LuminanceModulation(){ Val = 15000 };
            A.LuminanceOffset luminanceOffset29 = new A.LuminanceOffset(){ Val = 85000 };

            schemeColor69.Append(luminanceModulation33);
            schemeColor69.Append(luminanceOffset29);

            solidFill40.Append(schemeColor69);
            A.Round round14 = new A.Round();

            outline25.Append(solidFill40);
            outline25.Append(round14);

            shapeProperties19.Append(outline25);
            Cs.TextCharacterPropertiesType textCharacterPropertiesType8 = new Cs.TextCharacterPropertiesType(){ FontSize = 1197 };

            seriesAxis1.Append(lineReference23);
            seriesAxis1.Append(fillReference23);
            seriesAxis1.Append(effectReference23);
            seriesAxis1.Append(fontReference23);
            seriesAxis1.Append(shapeProperties19);
            seriesAxis1.Append(textCharacterPropertiesType8);

            Cs.SeriesLine seriesLine1 = new Cs.SeriesLine();
            Cs.LineReference lineReference24 = new Cs.LineReference(){ Index = (UInt32Value)0U };
            Cs.FillReference fillReference24 = new Cs.FillReference(){ Index = (UInt32Value)0U };
            Cs.EffectReference effectReference24 = new Cs.EffectReference(){ Index = (UInt32Value)0U };

            Cs.FontReference fontReference24 = new Cs.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor70 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference24.Append(schemeColor70);

            Cs.ShapeProperties shapeProperties20 = new Cs.ShapeProperties();

            A.Outline outline26 = new A.Outline(){ Width = 9525, CapType = A.LineCapValues.Flat };

            A.SolidFill solidFill41 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex1 = new A.RgbColorModelHex(){ Val = "D9D9D9" };

            solidFill41.Append(rgbColorModelHex1);
            A.Round round15 = new A.Round();

            outline26.Append(solidFill41);
            outline26.Append(round15);

            shapeProperties20.Append(outline26);

            seriesLine1.Append(lineReference24);
            seriesLine1.Append(fillReference24);
            seriesLine1.Append(effectReference24);
            seriesLine1.Append(fontReference24);
            seriesLine1.Append(shapeProperties20);

            Cs.TitleStyle titleStyle1 = new Cs.TitleStyle();
            Cs.LineReference lineReference25 = new Cs.LineReference(){ Index = (UInt32Value)0U };
            Cs.FillReference fillReference25 = new Cs.FillReference(){ Index = (UInt32Value)0U };
            Cs.EffectReference effectReference25 = new Cs.EffectReference(){ Index = (UInt32Value)0U };

            Cs.FontReference fontReference25 = new Cs.FontReference(){ Index = A.FontCollectionIndexValues.Minor };

            A.SchemeColor schemeColor71 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.LuminanceModulation luminanceModulation34 = new A.LuminanceModulation(){ Val = 65000 };
            A.LuminanceOffset luminanceOffset30 = new A.LuminanceOffset(){ Val = 35000 };

            schemeColor71.Append(luminanceModulation34);
            schemeColor71.Append(luminanceOffset30);

            fontReference25.Append(schemeColor71);
            Cs.TextCharacterPropertiesType textCharacterPropertiesType9 = new Cs.TextCharacterPropertiesType(){ FontSize = 1862 };

            titleStyle1.Append(lineReference25);
            titleStyle1.Append(fillReference25);
            titleStyle1.Append(effectReference25);
            titleStyle1.Append(fontReference25);
            titleStyle1.Append(textCharacterPropertiesType9);

            Cs.TrendlineStyle trendlineStyle1 = new Cs.TrendlineStyle();

            Cs.LineReference lineReference26 = new Cs.LineReference(){ Index = (UInt32Value)0U };
            Cs.StyleColor styleColor6 = new Cs.StyleColor(){ Val = "auto" };

            lineReference26.Append(styleColor6);
            Cs.FillReference fillReference26 = new Cs.FillReference(){ Index = (UInt32Value)0U };
            Cs.EffectReference effectReference26 = new Cs.EffectReference(){ Index = (UInt32Value)0U };

            Cs.FontReference fontReference26 = new Cs.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor72 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference26.Append(schemeColor72);

            Cs.ShapeProperties shapeProperties21 = new Cs.ShapeProperties();

            A.Outline outline27 = new A.Outline(){ Width = 19050, CapType = A.LineCapValues.Round };

            A.SolidFill solidFill42 = new A.SolidFill();
            A.SchemeColor schemeColor73 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill42.Append(schemeColor73);
            A.PresetDash presetDash1 = new A.PresetDash(){ Val = A.PresetLineDashValues.SystemDash };

            outline27.Append(solidFill42);
            outline27.Append(presetDash1);

            shapeProperties21.Append(outline27);

            trendlineStyle1.Append(lineReference26);
            trendlineStyle1.Append(fillReference26);
            trendlineStyle1.Append(effectReference26);
            trendlineStyle1.Append(fontReference26);
            trendlineStyle1.Append(shapeProperties21);

            Cs.TrendlineLabel trendlineLabel1 = new Cs.TrendlineLabel();
            Cs.LineReference lineReference27 = new Cs.LineReference(){ Index = (UInt32Value)0U };
            Cs.FillReference fillReference27 = new Cs.FillReference(){ Index = (UInt32Value)0U };
            Cs.EffectReference effectReference27 = new Cs.EffectReference(){ Index = (UInt32Value)0U };

            Cs.FontReference fontReference27 = new Cs.FontReference(){ Index = A.FontCollectionIndexValues.Minor };

            A.SchemeColor schemeColor74 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.LuminanceModulation luminanceModulation35 = new A.LuminanceModulation(){ Val = 65000 };
            A.LuminanceOffset luminanceOffset31 = new A.LuminanceOffset(){ Val = 35000 };

            schemeColor74.Append(luminanceModulation35);
            schemeColor74.Append(luminanceOffset31);

            fontReference27.Append(schemeColor74);
            Cs.TextCharacterPropertiesType textCharacterPropertiesType10 = new Cs.TextCharacterPropertiesType(){ FontSize = 1197 };

            trendlineLabel1.Append(lineReference27);
            trendlineLabel1.Append(fillReference27);
            trendlineLabel1.Append(effectReference27);
            trendlineLabel1.Append(fontReference27);
            trendlineLabel1.Append(textCharacterPropertiesType10);

            Cs.UpBar upBar1 = new Cs.UpBar();
            Cs.LineReference lineReference28 = new Cs.LineReference(){ Index = (UInt32Value)0U };
            Cs.FillReference fillReference28 = new Cs.FillReference(){ Index = (UInt32Value)0U };
            Cs.EffectReference effectReference28 = new Cs.EffectReference(){ Index = (UInt32Value)0U };

            Cs.FontReference fontReference28 = new Cs.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor75 = new A.SchemeColor(){ Val = A.SchemeColorValues.Dark1 };

            fontReference28.Append(schemeColor75);

            Cs.ShapeProperties shapeProperties22 = new Cs.ShapeProperties();

            A.SolidFill solidFill43 = new A.SolidFill();
            A.SchemeColor schemeColor76 = new A.SchemeColor(){ Val = A.SchemeColorValues.Light1 };

            solidFill43.Append(schemeColor76);

            A.Outline outline28 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill44 = new A.SolidFill();

            A.SchemeColor schemeColor77 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.LuminanceModulation luminanceModulation36 = new A.LuminanceModulation(){ Val = 15000 };
            A.LuminanceOffset luminanceOffset32 = new A.LuminanceOffset(){ Val = 85000 };

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

            Cs.ValueAxis valueAxis2 = new Cs.ValueAxis();
            Cs.LineReference lineReference29 = new Cs.LineReference(){ Index = (UInt32Value)0U };
            Cs.FillReference fillReference29 = new Cs.FillReference(){ Index = (UInt32Value)0U };
            Cs.EffectReference effectReference29 = new Cs.EffectReference(){ Index = (UInt32Value)0U };

            Cs.FontReference fontReference29 = new Cs.FontReference(){ Index = A.FontCollectionIndexValues.Minor };

            A.SchemeColor schemeColor78 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.LuminanceModulation luminanceModulation37 = new A.LuminanceModulation(){ Val = 65000 };
            A.LuminanceOffset luminanceOffset33 = new A.LuminanceOffset(){ Val = 35000 };

            schemeColor78.Append(luminanceModulation37);
            schemeColor78.Append(luminanceOffset33);

            fontReference29.Append(schemeColor78);
            Cs.TextCharacterPropertiesType textCharacterPropertiesType11 = new Cs.TextCharacterPropertiesType(){ FontSize = 1197 };

            valueAxis2.Append(lineReference29);
            valueAxis2.Append(fillReference29);
            valueAxis2.Append(effectReference29);
            valueAxis2.Append(fontReference29);
            valueAxis2.Append(textCharacterPropertiesType11);

            Cs.Wall wall1 = new Cs.Wall();
            Cs.LineReference lineReference30 = new Cs.LineReference(){ Index = (UInt32Value)0U };
            Cs.FillReference fillReference30 = new Cs.FillReference(){ Index = (UInt32Value)0U };
            Cs.EffectReference effectReference30 = new Cs.EffectReference(){ Index = (UInt32Value)0U };

            Cs.FontReference fontReference30 = new Cs.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor79 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

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

        // Generates content of slideLayoutPart1.
        private void GenerateSlideLayoutPart1Content(SlideLayoutPart slideLayoutPart1)
        {
            SlideLayout slideLayout1 = new SlideLayout(){ Type = SlideLayoutValues.Title, Preserve = true };
            slideLayout1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout1.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData2 = new CommonSlideData(){ Name = "Title Slide" };

            ShapeTree shapeTree2 = new ShapeTree();

            DocumentFormat.OpenXml.Presentation.NonVisualGroupShapeProperties nonVisualGroupShapeProperties2 = new DocumentFormat.OpenXml.Presentation.NonVisualGroupShapeProperties();
            DocumentFormat.OpenXml.Presentation.NonVisualDrawingProperties nonVisualDrawingProperties3 = new DocumentFormat.OpenXml.Presentation.NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            DocumentFormat.OpenXml.Presentation.NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties2 = new DocumentFormat.OpenXml.Presentation.NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties3 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties2.Append(nonVisualDrawingProperties3);
            nonVisualGroupShapeProperties2.Append(nonVisualGroupShapeDrawingProperties2);
            nonVisualGroupShapeProperties2.Append(applicationNonVisualDrawingProperties3);

            DocumentFormat.OpenXml.Presentation.GroupShapeProperties groupShapeProperties2 = new DocumentFormat.OpenXml.Presentation.GroupShapeProperties();

            A.TransformGroup transformGroup2 = new A.TransformGroup();
            A.Offset offset3 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents3 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset2 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents2 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup2.Append(offset3);
            transformGroup2.Append(extents3);
            transformGroup2.Append(childOffset2);
            transformGroup2.Append(childExtents2);

            groupShapeProperties2.Append(transformGroup2);

            Shape shape1 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties1 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties4 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList2 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension2 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement4 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{8E933230-3255-4169-9C55-C6FB927EDDA0}\" />");

            nonVisualDrawingPropertiesExtension2.Append(openXmlUnknownElement4);

            nonVisualDrawingPropertiesExtensionList2.Append(nonVisualDrawingPropertiesExtension2);

            nonVisualDrawingProperties4.Append(nonVisualDrawingPropertiesExtensionList2);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties1 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks1 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties1.Append(shapeLocks1);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties4 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape1 = new PlaceholderShape(){ Type = PlaceholderValues.CenteredTitle };

            applicationNonVisualDrawingProperties4.Append(placeholderShape1);

            nonVisualShapeProperties1.Append(nonVisualDrawingProperties4);
            nonVisualShapeProperties1.Append(nonVisualShapeDrawingProperties1);
            nonVisualShapeProperties1.Append(applicationNonVisualDrawingProperties4);

            ShapeProperties shapeProperties23 = new ShapeProperties();

            A.Transform2D transform2D1 = new A.Transform2D();
            A.Offset offset4 = new A.Offset(){ X = 1524000L, Y = 1122363L };
            A.Extents extents4 = new A.Extents(){ Cx = 9144000L, Cy = 2387600L };

            transform2D1.Append(offset4);
            transform2D1.Append(extents4);

            shapeProperties23.Append(transform2D1);

            TextBody textBody1 = new TextBody();
            A.BodyProperties bodyProperties6 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Bottom };

            A.ListStyle listStyle6 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties2 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Center };
            A.DefaultRunProperties defaultRunProperties16 = new A.DefaultRunProperties(){ FontSize = 6000 };

            level1ParagraphProperties2.Append(defaultRunProperties16);

            listStyle6.Append(level1ParagraphProperties2);

            A.Paragraph paragraph6 = new A.Paragraph();

            A.Run run1 = new A.Run();
            A.RunProperties runProperties1 = new A.RunProperties(){ Language = "en-US" };
            A.Text text1 = new A.Text();
            text1.Text = "Click to edit Master title style";

            run1.Append(runProperties1);
            run1.Append(text1);

            paragraph6.Append(run1);

            textBody1.Append(bodyProperties6);
            textBody1.Append(listStyle6);
            textBody1.Append(paragraph6);

            shape1.Append(nonVisualShapeProperties1);
            shape1.Append(shapeProperties23);
            shape1.Append(textBody1);

            Shape shape2 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties2 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties5 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Subtitle 2" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList3 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension3 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement5 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{D0DABBB4-04E2-409C-8F8E-75F18B02832B}\" />");

            nonVisualDrawingPropertiesExtension3.Append(openXmlUnknownElement5);

            nonVisualDrawingPropertiesExtensionList3.Append(nonVisualDrawingPropertiesExtension3);

            nonVisualDrawingProperties5.Append(nonVisualDrawingPropertiesExtensionList3);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties2 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks2 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties2.Append(shapeLocks2);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties5 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape2 = new PlaceholderShape(){ Type = PlaceholderValues.SubTitle, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties5.Append(placeholderShape2);

            nonVisualShapeProperties2.Append(nonVisualDrawingProperties5);
            nonVisualShapeProperties2.Append(nonVisualShapeDrawingProperties2);
            nonVisualShapeProperties2.Append(applicationNonVisualDrawingProperties5);

            ShapeProperties shapeProperties24 = new ShapeProperties();

            A.Transform2D transform2D2 = new A.Transform2D();
            A.Offset offset5 = new A.Offset(){ X = 1524000L, Y = 3602038L };
            A.Extents extents5 = new A.Extents(){ Cx = 9144000L, Cy = 1655762L };

            transform2D2.Append(offset5);
            transform2D2.Append(extents5);

            shapeProperties24.Append(transform2D2);

            TextBody textBody2 = new TextBody();
            A.BodyProperties bodyProperties7 = new A.BodyProperties();

            A.ListStyle listStyle7 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties3 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet1 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties17 = new A.DefaultRunProperties(){ FontSize = 2400 };

            level1ParagraphProperties3.Append(noBullet1);
            level1ParagraphProperties3.Append(defaultRunProperties17);

            A.Level2ParagraphProperties level2ParagraphProperties2 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet2 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties18 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level2ParagraphProperties2.Append(noBullet2);
            level2ParagraphProperties2.Append(defaultRunProperties18);

            A.Level3ParagraphProperties level3ParagraphProperties2 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet3 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties19 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level3ParagraphProperties2.Append(noBullet3);
            level3ParagraphProperties2.Append(defaultRunProperties19);

            A.Level4ParagraphProperties level4ParagraphProperties2 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet4 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties20 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level4ParagraphProperties2.Append(noBullet4);
            level4ParagraphProperties2.Append(defaultRunProperties20);

            A.Level5ParagraphProperties level5ParagraphProperties2 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet5 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties21 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level5ParagraphProperties2.Append(noBullet5);
            level5ParagraphProperties2.Append(defaultRunProperties21);

            A.Level6ParagraphProperties level6ParagraphProperties2 = new A.Level6ParagraphProperties(){ LeftMargin = 2286000, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet6 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties22 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level6ParagraphProperties2.Append(noBullet6);
            level6ParagraphProperties2.Append(defaultRunProperties22);

            A.Level7ParagraphProperties level7ParagraphProperties2 = new A.Level7ParagraphProperties(){ LeftMargin = 2743200, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet7 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties23 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level7ParagraphProperties2.Append(noBullet7);
            level7ParagraphProperties2.Append(defaultRunProperties23);

            A.Level8ParagraphProperties level8ParagraphProperties2 = new A.Level8ParagraphProperties(){ LeftMargin = 3200400, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet8 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties24 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level8ParagraphProperties2.Append(noBullet8);
            level8ParagraphProperties2.Append(defaultRunProperties24);

            A.Level9ParagraphProperties level9ParagraphProperties2 = new A.Level9ParagraphProperties(){ LeftMargin = 3657600, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet9 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties25 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level9ParagraphProperties2.Append(noBullet9);
            level9ParagraphProperties2.Append(defaultRunProperties25);

            listStyle7.Append(level1ParagraphProperties3);
            listStyle7.Append(level2ParagraphProperties2);
            listStyle7.Append(level3ParagraphProperties2);
            listStyle7.Append(level4ParagraphProperties2);
            listStyle7.Append(level5ParagraphProperties2);
            listStyle7.Append(level6ParagraphProperties2);
            listStyle7.Append(level7ParagraphProperties2);
            listStyle7.Append(level8ParagraphProperties2);
            listStyle7.Append(level9ParagraphProperties2);

            A.Paragraph paragraph7 = new A.Paragraph();

            A.Run run2 = new A.Run();
            A.RunProperties runProperties2 = new A.RunProperties(){ Language = "en-US" };
            A.Text text2 = new A.Text();
            text2.Text = "Click to edit Master subtitle style";

            run2.Append(runProperties2);
            run2.Append(text2);

            paragraph7.Append(run2);

            textBody2.Append(bodyProperties7);
            textBody2.Append(listStyle7);
            textBody2.Append(paragraph7);

            shape2.Append(nonVisualShapeProperties2);
            shape2.Append(shapeProperties24);
            shape2.Append(textBody2);

            Shape shape3 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties3 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties6 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Date Placeholder 3" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList4 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension4 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement6 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{55CE9FE6-4C88-46EC-93C9-73AF5916E3EE}\" />");

            nonVisualDrawingPropertiesExtension4.Append(openXmlUnknownElement6);

            nonVisualDrawingPropertiesExtensionList4.Append(nonVisualDrawingPropertiesExtension4);

            nonVisualDrawingProperties6.Append(nonVisualDrawingPropertiesExtensionList4);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties3 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks3 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties3.Append(shapeLocks3);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties6 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape3 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties6.Append(placeholderShape3);

            nonVisualShapeProperties3.Append(nonVisualDrawingProperties6);
            nonVisualShapeProperties3.Append(nonVisualShapeDrawingProperties3);
            nonVisualShapeProperties3.Append(applicationNonVisualDrawingProperties6);
            ShapeProperties shapeProperties25 = new ShapeProperties();

            TextBody textBody3 = new TextBody();
            A.BodyProperties bodyProperties8 = new A.BodyProperties();
            A.ListStyle listStyle8 = new A.ListStyle();

            A.Paragraph paragraph8 = new A.Paragraph();

            A.Field field1 = new A.Field(){ Id = "{9BEF4A3D-57C8-4DC0-86D0-95A05287C467}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties3 = new A.RunProperties(){ Language = "en-US" };
            runProperties3.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text3 = new A.Text();
            text3.Text = "1/29/2020";

            field1.Append(runProperties3);
            field1.Append(text3);
            A.EndParagraphRunProperties endParagraphRunProperties6 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph8.Append(field1);
            paragraph8.Append(endParagraphRunProperties6);

            textBody3.Append(bodyProperties8);
            textBody3.Append(listStyle8);
            textBody3.Append(paragraph8);

            shape3.Append(nonVisualShapeProperties3);
            shape3.Append(shapeProperties25);
            shape3.Append(textBody3);

            Shape shape4 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties4 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties7 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Footer Placeholder 4" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList5 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension5 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement7 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{A8D78224-AB64-493C-8151-1C23BCC10EEF}\" />");

            nonVisualDrawingPropertiesExtension5.Append(openXmlUnknownElement7);

            nonVisualDrawingPropertiesExtensionList5.Append(nonVisualDrawingPropertiesExtension5);

            nonVisualDrawingProperties7.Append(nonVisualDrawingPropertiesExtensionList5);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties4 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks4 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties4.Append(shapeLocks4);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties7 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape4 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties7.Append(placeholderShape4);

            nonVisualShapeProperties4.Append(nonVisualDrawingProperties7);
            nonVisualShapeProperties4.Append(nonVisualShapeDrawingProperties4);
            nonVisualShapeProperties4.Append(applicationNonVisualDrawingProperties7);
            ShapeProperties shapeProperties26 = new ShapeProperties();

            TextBody textBody4 = new TextBody();
            A.BodyProperties bodyProperties9 = new A.BodyProperties();
            A.ListStyle listStyle9 = new A.ListStyle();

            A.Paragraph paragraph9 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties7 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph9.Append(endParagraphRunProperties7);

            textBody4.Append(bodyProperties9);
            textBody4.Append(listStyle9);
            textBody4.Append(paragraph9);

            shape4.Append(nonVisualShapeProperties4);
            shape4.Append(shapeProperties26);
            shape4.Append(textBody4);

            Shape shape5 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties5 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties8 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Slide Number Placeholder 5" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList6 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension6 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement8 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{4507A2D3-C064-4A93-B5B9-C43D0245C258}\" />");

            nonVisualDrawingPropertiesExtension6.Append(openXmlUnknownElement8);

            nonVisualDrawingPropertiesExtensionList6.Append(nonVisualDrawingPropertiesExtension6);

            nonVisualDrawingProperties8.Append(nonVisualDrawingPropertiesExtensionList6);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties5 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks5 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties5.Append(shapeLocks5);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties8 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape5 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties8.Append(placeholderShape5);

            nonVisualShapeProperties5.Append(nonVisualDrawingProperties8);
            nonVisualShapeProperties5.Append(nonVisualShapeDrawingProperties5);
            nonVisualShapeProperties5.Append(applicationNonVisualDrawingProperties8);
            ShapeProperties shapeProperties27 = new ShapeProperties();

            TextBody textBody5 = new TextBody();
            A.BodyProperties bodyProperties10 = new A.BodyProperties();
            A.ListStyle listStyle10 = new A.ListStyle();

            A.Paragraph paragraph10 = new A.Paragraph();

            A.Field field2 = new A.Field(){ Id = "{1BF20D12-B4E9-4886-A78D-768EA8FF95DD}", Type = "slidenum" };

            A.RunProperties runProperties4 = new A.RunProperties(){ Language = "en-US" };
            runProperties4.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text4 = new A.Text();
            text4.Text = "‹#›";

            field2.Append(runProperties4);
            field2.Append(text4);
            A.EndParagraphRunProperties endParagraphRunProperties8 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph10.Append(field2);
            paragraph10.Append(endParagraphRunProperties8);

            textBody5.Append(bodyProperties10);
            textBody5.Append(listStyle10);
            textBody5.Append(paragraph10);

            shape5.Append(nonVisualShapeProperties5);
            shape5.Append(shapeProperties27);
            shape5.Append(textBody5);

            shapeTree2.Append(nonVisualGroupShapeProperties2);
            shapeTree2.Append(groupShapeProperties2);
            shapeTree2.Append(shape1);
            shapeTree2.Append(shape2);
            shapeTree2.Append(shape3);
            shapeTree2.Append(shape4);
            shapeTree2.Append(shape5);

            CommonSlideDataExtensionList commonSlideDataExtensionList2 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension2 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId2 = new P14.CreationId(){ Val = (UInt32Value)1082829135U };
            creationId2.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension2.Append(creationId2);

            commonSlideDataExtensionList2.Append(commonSlideDataExtension2);

            commonSlideData2.Append(shapeTree2);
            commonSlideData2.Append(commonSlideDataExtensionList2);

            ColorMapOverride colorMapOverride2 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping2 = new A.MasterColorMapping();

            colorMapOverride2.Append(masterColorMapping2);

            slideLayout1.Append(commonSlideData2);
            slideLayout1.Append(colorMapOverride2);

            slideLayoutPart1.SlideLayout = slideLayout1;
        }

        // Generates content of slideMasterPart1.
        private void GenerateSlideMasterPart1Content(SlideMasterPart slideMasterPart1)
        {
            SlideMaster slideMaster1 = new SlideMaster();
            slideMaster1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideMaster1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideMaster1.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData3 = new CommonSlideData();

            Background background1 = new Background();

            BackgroundStyleReference backgroundStyleReference1 = new BackgroundStyleReference(){ Index = (UInt32Value)1001U };
            A.SchemeColor schemeColor80 = new A.SchemeColor(){ Val = A.SchemeColorValues.Background1 };

            backgroundStyleReference1.Append(schemeColor80);

            background1.Append(backgroundStyleReference1);

            ShapeTree shapeTree3 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties3 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties9 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties3 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties9 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties3.Append(nonVisualDrawingProperties9);
            nonVisualGroupShapeProperties3.Append(nonVisualGroupShapeDrawingProperties3);
            nonVisualGroupShapeProperties3.Append(applicationNonVisualDrawingProperties9);

            GroupShapeProperties groupShapeProperties3 = new GroupShapeProperties();

            A.TransformGroup transformGroup3 = new A.TransformGroup();
            A.Offset offset6 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents6 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset3 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents3 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup3.Append(offset6);
            transformGroup3.Append(extents6);
            transformGroup3.Append(childOffset3);
            transformGroup3.Append(childExtents3);

            groupShapeProperties3.Append(transformGroup3);

            Shape shape6 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties6 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties10 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title Placeholder 1" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList7 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension7 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement9 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{27973478-3021-498F-B89D-4062DB878F6E}\" />");

            nonVisualDrawingPropertiesExtension7.Append(openXmlUnknownElement9);

            nonVisualDrawingPropertiesExtensionList7.Append(nonVisualDrawingPropertiesExtension7);

            nonVisualDrawingProperties10.Append(nonVisualDrawingPropertiesExtensionList7);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties6 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks6 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties6.Append(shapeLocks6);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties10 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape6 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties10.Append(placeholderShape6);

            nonVisualShapeProperties6.Append(nonVisualDrawingProperties10);
            nonVisualShapeProperties6.Append(nonVisualShapeDrawingProperties6);
            nonVisualShapeProperties6.Append(applicationNonVisualDrawingProperties10);

            ShapeProperties shapeProperties28 = new ShapeProperties();

            A.Transform2D transform2D3 = new A.Transform2D();
            A.Offset offset7 = new A.Offset(){ X = 838200L, Y = 365125L };
            A.Extents extents7 = new A.Extents(){ Cx = 10515600L, Cy = 1325563L };

            transform2D3.Append(offset7);
            transform2D3.Append(extents7);

            A.PresetGeometry presetGeometry1 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList1 = new A.AdjustValueList();

            presetGeometry1.Append(adjustValueList1);

            shapeProperties28.Append(transform2D3);
            shapeProperties28.Append(presetGeometry1);

            TextBody textBody6 = new TextBody();

            A.BodyProperties bodyProperties11 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal, LeftInset = 91440, TopInset = 45720, RightInset = 91440, BottomInset = 45720, RightToLeftColumns = false, Anchor = A.TextAnchoringTypeValues.Center };
            A.NormalAutoFit normalAutoFit1 = new A.NormalAutoFit();

            bodyProperties11.Append(normalAutoFit1);
            A.ListStyle listStyle11 = new A.ListStyle();

            A.Paragraph paragraph11 = new A.Paragraph();

            A.Run run3 = new A.Run();
            A.RunProperties runProperties5 = new A.RunProperties(){ Language = "en-US" };
            A.Text text5 = new A.Text();
            text5.Text = "Click to edit Master title style";

            run3.Append(runProperties5);
            run3.Append(text5);

            paragraph11.Append(run3);

            textBody6.Append(bodyProperties11);
            textBody6.Append(listStyle11);
            textBody6.Append(paragraph11);

            shape6.Append(nonVisualShapeProperties6);
            shape6.Append(shapeProperties28);
            shape6.Append(textBody6);

            Shape shape7 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties7 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties11 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Text Placeholder 2" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList8 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension8 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement10 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{8D5F0156-74A9-4220-9168-A9D4D7FDFEB5}\" />");

            nonVisualDrawingPropertiesExtension8.Append(openXmlUnknownElement10);

            nonVisualDrawingPropertiesExtensionList8.Append(nonVisualDrawingPropertiesExtension8);

            nonVisualDrawingProperties11.Append(nonVisualDrawingPropertiesExtensionList8);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties7 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks7 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties7.Append(shapeLocks7);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties11 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape7 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties11.Append(placeholderShape7);

            nonVisualShapeProperties7.Append(nonVisualDrawingProperties11);
            nonVisualShapeProperties7.Append(nonVisualShapeDrawingProperties7);
            nonVisualShapeProperties7.Append(applicationNonVisualDrawingProperties11);

            ShapeProperties shapeProperties29 = new ShapeProperties();

            A.Transform2D transform2D4 = new A.Transform2D();
            A.Offset offset8 = new A.Offset(){ X = 838200L, Y = 1825625L };
            A.Extents extents8 = new A.Extents(){ Cx = 10515600L, Cy = 4351338L };

            transform2D4.Append(offset8);
            transform2D4.Append(extents8);

            A.PresetGeometry presetGeometry2 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList2 = new A.AdjustValueList();

            presetGeometry2.Append(adjustValueList2);

            shapeProperties29.Append(transform2D4);
            shapeProperties29.Append(presetGeometry2);

            TextBody textBody7 = new TextBody();

            A.BodyProperties bodyProperties12 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal, LeftInset = 91440, TopInset = 45720, RightInset = 91440, BottomInset = 45720, RightToLeftColumns = false };
            A.NormalAutoFit normalAutoFit2 = new A.NormalAutoFit();

            bodyProperties12.Append(normalAutoFit2);
            A.ListStyle listStyle12 = new A.ListStyle();

            A.Paragraph paragraph12 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties6 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run4 = new A.Run();
            A.RunProperties runProperties6 = new A.RunProperties(){ Language = "en-US" };
            A.Text text6 = new A.Text();
            text6.Text = "Click to edit Master text styles";

            run4.Append(runProperties6);
            run4.Append(text6);

            paragraph12.Append(paragraphProperties6);
            paragraph12.Append(run4);

            A.Paragraph paragraph13 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties7 = new A.ParagraphProperties(){ Level = 1 };

            A.Run run5 = new A.Run();
            A.RunProperties runProperties7 = new A.RunProperties(){ Language = "en-US" };
            A.Text text7 = new A.Text();
            text7.Text = "Second level";

            run5.Append(runProperties7);
            run5.Append(text7);

            paragraph13.Append(paragraphProperties7);
            paragraph13.Append(run5);

            A.Paragraph paragraph14 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties8 = new A.ParagraphProperties(){ Level = 2 };

            A.Run run6 = new A.Run();
            A.RunProperties runProperties8 = new A.RunProperties(){ Language = "en-US" };
            A.Text text8 = new A.Text();
            text8.Text = "Third level";

            run6.Append(runProperties8);
            run6.Append(text8);

            paragraph14.Append(paragraphProperties8);
            paragraph14.Append(run6);

            A.Paragraph paragraph15 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties9 = new A.ParagraphProperties(){ Level = 3 };

            A.Run run7 = new A.Run();
            A.RunProperties runProperties9 = new A.RunProperties(){ Language = "en-US" };
            A.Text text9 = new A.Text();
            text9.Text = "Fourth level";

            run7.Append(runProperties9);
            run7.Append(text9);

            paragraph15.Append(paragraphProperties9);
            paragraph15.Append(run7);

            A.Paragraph paragraph16 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties10 = new A.ParagraphProperties(){ Level = 4 };

            A.Run run8 = new A.Run();
            A.RunProperties runProperties10 = new A.RunProperties(){ Language = "en-US" };
            A.Text text10 = new A.Text();
            text10.Text = "Fifth level";

            run8.Append(runProperties10);
            run8.Append(text10);

            paragraph16.Append(paragraphProperties10);
            paragraph16.Append(run8);

            textBody7.Append(bodyProperties12);
            textBody7.Append(listStyle12);
            textBody7.Append(paragraph12);
            textBody7.Append(paragraph13);
            textBody7.Append(paragraph14);
            textBody7.Append(paragraph15);
            textBody7.Append(paragraph16);

            shape7.Append(nonVisualShapeProperties7);
            shape7.Append(shapeProperties29);
            shape7.Append(textBody7);

            Shape shape8 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties8 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties12 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Date Placeholder 3" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList9 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension9 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement11 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{7B3D64DF-583A-446E-8EF3-8F86E65B552B}\" />");

            nonVisualDrawingPropertiesExtension9.Append(openXmlUnknownElement11);

            nonVisualDrawingPropertiesExtensionList9.Append(nonVisualDrawingPropertiesExtension9);

            nonVisualDrawingProperties12.Append(nonVisualDrawingPropertiesExtensionList9);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties8 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks8 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties8.Append(shapeLocks8);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties12 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape8 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)2U };

            applicationNonVisualDrawingProperties12.Append(placeholderShape8);

            nonVisualShapeProperties8.Append(nonVisualDrawingProperties12);
            nonVisualShapeProperties8.Append(nonVisualShapeDrawingProperties8);
            nonVisualShapeProperties8.Append(applicationNonVisualDrawingProperties12);

            ShapeProperties shapeProperties30 = new ShapeProperties();

            A.Transform2D transform2D5 = new A.Transform2D();
            A.Offset offset9 = new A.Offset(){ X = 838200L, Y = 6356350L };
            A.Extents extents9 = new A.Extents(){ Cx = 2743200L, Cy = 365125L };

            transform2D5.Append(offset9);
            transform2D5.Append(extents9);

            A.PresetGeometry presetGeometry3 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList3 = new A.AdjustValueList();

            presetGeometry3.Append(adjustValueList3);

            shapeProperties30.Append(transform2D5);
            shapeProperties30.Append(presetGeometry3);

            TextBody textBody8 = new TextBody();
            A.BodyProperties bodyProperties13 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal, LeftInset = 91440, TopInset = 45720, RightInset = 91440, BottomInset = 45720, RightToLeftColumns = false, Anchor = A.TextAnchoringTypeValues.Center };

            A.ListStyle listStyle13 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties4 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Left };

            A.DefaultRunProperties defaultRunProperties26 = new A.DefaultRunProperties(){ FontSize = 1200 };

            A.SolidFill solidFill45 = new A.SolidFill();

            A.SchemeColor schemeColor81 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint1 = new A.Tint(){ Val = 75000 };

            schemeColor81.Append(tint1);

            solidFill45.Append(schemeColor81);

            defaultRunProperties26.Append(solidFill45);

            level1ParagraphProperties4.Append(defaultRunProperties26);

            listStyle13.Append(level1ParagraphProperties4);

            A.Paragraph paragraph17 = new A.Paragraph();

            A.Field field3 = new A.Field(){ Id = "{9BEF4A3D-57C8-4DC0-86D0-95A05287C467}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties11 = new A.RunProperties(){ Language = "en-US" };
            runProperties11.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text11 = new A.Text();
            text11.Text = "1/29/2020";

            field3.Append(runProperties11);
            field3.Append(text11);
            A.EndParagraphRunProperties endParagraphRunProperties9 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph17.Append(field3);
            paragraph17.Append(endParagraphRunProperties9);

            textBody8.Append(bodyProperties13);
            textBody8.Append(listStyle13);
            textBody8.Append(paragraph17);

            shape8.Append(nonVisualShapeProperties8);
            shape8.Append(shapeProperties30);
            shape8.Append(textBody8);

            Shape shape9 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties9 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties13 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Footer Placeholder 4" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList10 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension10 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement12 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{9BC9A2C0-60AA-497C-8BD9-3042324AB4B2}\" />");

            nonVisualDrawingPropertiesExtension10.Append(openXmlUnknownElement12);

            nonVisualDrawingPropertiesExtensionList10.Append(nonVisualDrawingPropertiesExtension10);

            nonVisualDrawingProperties13.Append(nonVisualDrawingPropertiesExtensionList10);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties9 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks9 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties9.Append(shapeLocks9);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties13 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape9 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)3U };

            applicationNonVisualDrawingProperties13.Append(placeholderShape9);

            nonVisualShapeProperties9.Append(nonVisualDrawingProperties13);
            nonVisualShapeProperties9.Append(nonVisualShapeDrawingProperties9);
            nonVisualShapeProperties9.Append(applicationNonVisualDrawingProperties13);

            ShapeProperties shapeProperties31 = new ShapeProperties();

            A.Transform2D transform2D6 = new A.Transform2D();
            A.Offset offset10 = new A.Offset(){ X = 4038600L, Y = 6356350L };
            A.Extents extents10 = new A.Extents(){ Cx = 4114800L, Cy = 365125L };

            transform2D6.Append(offset10);
            transform2D6.Append(extents10);

            A.PresetGeometry presetGeometry4 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList4 = new A.AdjustValueList();

            presetGeometry4.Append(adjustValueList4);

            shapeProperties31.Append(transform2D6);
            shapeProperties31.Append(presetGeometry4);

            TextBody textBody9 = new TextBody();
            A.BodyProperties bodyProperties14 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal, LeftInset = 91440, TopInset = 45720, RightInset = 91440, BottomInset = 45720, RightToLeftColumns = false, Anchor = A.TextAnchoringTypeValues.Center };

            A.ListStyle listStyle14 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties5 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Center };

            A.DefaultRunProperties defaultRunProperties27 = new A.DefaultRunProperties(){ FontSize = 1200 };

            A.SolidFill solidFill46 = new A.SolidFill();

            A.SchemeColor schemeColor82 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint2 = new A.Tint(){ Val = 75000 };

            schemeColor82.Append(tint2);

            solidFill46.Append(schemeColor82);

            defaultRunProperties27.Append(solidFill46);

            level1ParagraphProperties5.Append(defaultRunProperties27);

            listStyle14.Append(level1ParagraphProperties5);

            A.Paragraph paragraph18 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties10 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph18.Append(endParagraphRunProperties10);

            textBody9.Append(bodyProperties14);
            textBody9.Append(listStyle14);
            textBody9.Append(paragraph18);

            shape9.Append(nonVisualShapeProperties9);
            shape9.Append(shapeProperties31);
            shape9.Append(textBody9);

            Shape shape10 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties10 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties14 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Slide Number Placeholder 5" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList11 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension11 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement13 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{37FDB6A0-B769-463C-834E-F73E73E20CF2}\" />");

            nonVisualDrawingPropertiesExtension11.Append(openXmlUnknownElement13);

            nonVisualDrawingPropertiesExtensionList11.Append(nonVisualDrawingPropertiesExtension11);

            nonVisualDrawingProperties14.Append(nonVisualDrawingPropertiesExtensionList11);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties10 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks10 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties10.Append(shapeLocks10);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties14 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape10 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)4U };

            applicationNonVisualDrawingProperties14.Append(placeholderShape10);

            nonVisualShapeProperties10.Append(nonVisualDrawingProperties14);
            nonVisualShapeProperties10.Append(nonVisualShapeDrawingProperties10);
            nonVisualShapeProperties10.Append(applicationNonVisualDrawingProperties14);

            ShapeProperties shapeProperties32 = new ShapeProperties();

            A.Transform2D transform2D7 = new A.Transform2D();
            A.Offset offset11 = new A.Offset(){ X = 8610600L, Y = 6356350L };
            A.Extents extents11 = new A.Extents(){ Cx = 2743200L, Cy = 365125L };

            transform2D7.Append(offset11);
            transform2D7.Append(extents11);

            A.PresetGeometry presetGeometry5 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList5 = new A.AdjustValueList();

            presetGeometry5.Append(adjustValueList5);

            shapeProperties32.Append(transform2D7);
            shapeProperties32.Append(presetGeometry5);

            TextBody textBody10 = new TextBody();
            A.BodyProperties bodyProperties15 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal, LeftInset = 91440, TopInset = 45720, RightInset = 91440, BottomInset = 45720, RightToLeftColumns = false, Anchor = A.TextAnchoringTypeValues.Center };

            A.ListStyle listStyle15 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties6 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Right };

            A.DefaultRunProperties defaultRunProperties28 = new A.DefaultRunProperties(){ FontSize = 1200 };

            A.SolidFill solidFill47 = new A.SolidFill();

            A.SchemeColor schemeColor83 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint3 = new A.Tint(){ Val = 75000 };

            schemeColor83.Append(tint3);

            solidFill47.Append(schemeColor83);

            defaultRunProperties28.Append(solidFill47);

            level1ParagraphProperties6.Append(defaultRunProperties28);

            listStyle15.Append(level1ParagraphProperties6);

            A.Paragraph paragraph19 = new A.Paragraph();

            A.Field field4 = new A.Field(){ Id = "{1BF20D12-B4E9-4886-A78D-768EA8FF95DD}", Type = "slidenum" };

            A.RunProperties runProperties12 = new A.RunProperties(){ Language = "en-US" };
            runProperties12.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text12 = new A.Text();
            text12.Text = "‹#›";

            field4.Append(runProperties12);
            field4.Append(text12);
            A.EndParagraphRunProperties endParagraphRunProperties11 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph19.Append(field4);
            paragraph19.Append(endParagraphRunProperties11);

            textBody10.Append(bodyProperties15);
            textBody10.Append(listStyle15);
            textBody10.Append(paragraph19);

            shape10.Append(nonVisualShapeProperties10);
            shape10.Append(shapeProperties32);
            shape10.Append(textBody10);

            shapeTree3.Append(nonVisualGroupShapeProperties3);
            shapeTree3.Append(groupShapeProperties3);
            shapeTree3.Append(shape6);
            shapeTree3.Append(shape7);
            shapeTree3.Append(shape8);
            shapeTree3.Append(shape9);
            shapeTree3.Append(shape10);

            CommonSlideDataExtensionList commonSlideDataExtensionList3 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension3 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId3 = new P14.CreationId(){ Val = (UInt32Value)3438814910U };
            creationId3.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension3.Append(creationId3);

            commonSlideDataExtensionList3.Append(commonSlideDataExtension3);

            commonSlideData3.Append(background1);
            commonSlideData3.Append(shapeTree3);
            commonSlideData3.Append(commonSlideDataExtensionList3);
            ColorMap colorMap1 = new ColorMap(){ Background1 = A.ColorSchemeIndexValues.Light1, Text1 = A.ColorSchemeIndexValues.Dark1, Background2 = A.ColorSchemeIndexValues.Light2, Text2 = A.ColorSchemeIndexValues.Dark2, Accent1 = A.ColorSchemeIndexValues.Accent1, Accent2 = A.ColorSchemeIndexValues.Accent2, Accent3 = A.ColorSchemeIndexValues.Accent3, Accent4 = A.ColorSchemeIndexValues.Accent4, Accent5 = A.ColorSchemeIndexValues.Accent5, Accent6 = A.ColorSchemeIndexValues.Accent6, Hyperlink = A.ColorSchemeIndexValues.Hyperlink, FollowedHyperlink = A.ColorSchemeIndexValues.FollowedHyperlink };

            SlideLayoutIdList slideLayoutIdList1 = new SlideLayoutIdList();
            SlideLayoutId slideLayoutId1 = new SlideLayoutId(){ Id = (UInt32Value)2147483649U, RelationshipId = "rId1" };
            SlideLayoutId slideLayoutId2 = new SlideLayoutId(){ Id = (UInt32Value)2147483650U, RelationshipId = "rId2" };
            SlideLayoutId slideLayoutId3 = new SlideLayoutId(){ Id = (UInt32Value)2147483651U, RelationshipId = "rId3" };
            SlideLayoutId slideLayoutId4 = new SlideLayoutId(){ Id = (UInt32Value)2147483652U, RelationshipId = "rId4" };
            SlideLayoutId slideLayoutId5 = new SlideLayoutId(){ Id = (UInt32Value)2147483653U, RelationshipId = "rId5" };
            SlideLayoutId slideLayoutId6 = new SlideLayoutId(){ Id = (UInt32Value)2147483654U, RelationshipId = "rId6" };
            SlideLayoutId slideLayoutId7 = new SlideLayoutId(){ Id = (UInt32Value)2147483655U, RelationshipId = "rId7" };
            SlideLayoutId slideLayoutId8 = new SlideLayoutId(){ Id = (UInt32Value)2147483656U, RelationshipId = "rId8" };
            SlideLayoutId slideLayoutId9 = new SlideLayoutId(){ Id = (UInt32Value)2147483657U, RelationshipId = "rId9" };
            SlideLayoutId slideLayoutId10 = new SlideLayoutId(){ Id = (UInt32Value)2147483658U, RelationshipId = "rId10" };
            SlideLayoutId slideLayoutId11 = new SlideLayoutId(){ Id = (UInt32Value)2147483659U, RelationshipId = "rId11" };

            slideLayoutIdList1.Append(slideLayoutId1);
            slideLayoutIdList1.Append(slideLayoutId2);
            slideLayoutIdList1.Append(slideLayoutId3);
            slideLayoutIdList1.Append(slideLayoutId4);
            slideLayoutIdList1.Append(slideLayoutId5);
            slideLayoutIdList1.Append(slideLayoutId6);
            slideLayoutIdList1.Append(slideLayoutId7);
            slideLayoutIdList1.Append(slideLayoutId8);
            slideLayoutIdList1.Append(slideLayoutId9);
            slideLayoutIdList1.Append(slideLayoutId10);
            slideLayoutIdList1.Append(slideLayoutId11);

            TextStyles textStyles1 = new TextStyles();

            TitleStyle titleStyle2 = new TitleStyle();

            A.Level1ParagraphProperties level1ParagraphProperties7 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.LineSpacing lineSpacing1 = new A.LineSpacing();
            A.SpacingPercent spacingPercent1 = new A.SpacingPercent(){ Val = 90000 };

            lineSpacing1.Append(spacingPercent1);

            A.SpaceBefore spaceBefore1 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent2 = new A.SpacingPercent(){ Val = 0 };

            spaceBefore1.Append(spacingPercent2);
            A.NoBullet noBullet10 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties29 = new A.DefaultRunProperties(){ FontSize = 4400, Kerning = 1200 };

            A.SolidFill solidFill48 = new A.SolidFill();
            A.SchemeColor schemeColor84 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill48.Append(schemeColor84);
            A.LatinFont latinFont14 = new A.LatinFont(){ Typeface = "+mj-lt" };
            A.EastAsianFont eastAsianFont14 = new A.EastAsianFont(){ Typeface = "+mj-ea" };
            A.ComplexScriptFont complexScriptFont14 = new A.ComplexScriptFont(){ Typeface = "+mj-cs" };

            defaultRunProperties29.Append(solidFill48);
            defaultRunProperties29.Append(latinFont14);
            defaultRunProperties29.Append(eastAsianFont14);
            defaultRunProperties29.Append(complexScriptFont14);

            level1ParagraphProperties7.Append(lineSpacing1);
            level1ParagraphProperties7.Append(spaceBefore1);
            level1ParagraphProperties7.Append(noBullet10);
            level1ParagraphProperties7.Append(defaultRunProperties29);

            titleStyle2.Append(level1ParagraphProperties7);

            BodyStyle bodyStyle1 = new BodyStyle();

            A.Level1ParagraphProperties level1ParagraphProperties8 = new A.Level1ParagraphProperties(){ LeftMargin = 228600, Indent = -228600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.LineSpacing lineSpacing2 = new A.LineSpacing();
            A.SpacingPercent spacingPercent3 = new A.SpacingPercent(){ Val = 90000 };

            lineSpacing2.Append(spacingPercent3);

            A.SpaceBefore spaceBefore2 = new A.SpaceBefore();
            A.SpacingPoints spacingPoints1 = new A.SpacingPoints(){ Val = 1000 };

            spaceBefore2.Append(spacingPoints1);
            A.BulletFont bulletFont1 = new A.BulletFont(){ Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.CharacterBullet characterBullet1 = new A.CharacterBullet(){ Char = "•" };

            A.DefaultRunProperties defaultRunProperties30 = new A.DefaultRunProperties(){ FontSize = 2800, Kerning = 1200 };

            A.SolidFill solidFill49 = new A.SolidFill();
            A.SchemeColor schemeColor85 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill49.Append(schemeColor85);
            A.LatinFont latinFont15 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont15 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont15 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties30.Append(solidFill49);
            defaultRunProperties30.Append(latinFont15);
            defaultRunProperties30.Append(eastAsianFont15);
            defaultRunProperties30.Append(complexScriptFont15);

            level1ParagraphProperties8.Append(lineSpacing2);
            level1ParagraphProperties8.Append(spaceBefore2);
            level1ParagraphProperties8.Append(bulletFont1);
            level1ParagraphProperties8.Append(characterBullet1);
            level1ParagraphProperties8.Append(defaultRunProperties30);

            A.Level2ParagraphProperties level2ParagraphProperties3 = new A.Level2ParagraphProperties(){ LeftMargin = 685800, Indent = -228600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.LineSpacing lineSpacing3 = new A.LineSpacing();
            A.SpacingPercent spacingPercent4 = new A.SpacingPercent(){ Val = 90000 };

            lineSpacing3.Append(spacingPercent4);

            A.SpaceBefore spaceBefore3 = new A.SpaceBefore();
            A.SpacingPoints spacingPoints2 = new A.SpacingPoints(){ Val = 500 };

            spaceBefore3.Append(spacingPoints2);
            A.BulletFont bulletFont2 = new A.BulletFont(){ Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.CharacterBullet characterBullet2 = new A.CharacterBullet(){ Char = "•" };

            A.DefaultRunProperties defaultRunProperties31 = new A.DefaultRunProperties(){ FontSize = 2400, Kerning = 1200 };

            A.SolidFill solidFill50 = new A.SolidFill();
            A.SchemeColor schemeColor86 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill50.Append(schemeColor86);
            A.LatinFont latinFont16 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont16 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont16 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties31.Append(solidFill50);
            defaultRunProperties31.Append(latinFont16);
            defaultRunProperties31.Append(eastAsianFont16);
            defaultRunProperties31.Append(complexScriptFont16);

            level2ParagraphProperties3.Append(lineSpacing3);
            level2ParagraphProperties3.Append(spaceBefore3);
            level2ParagraphProperties3.Append(bulletFont2);
            level2ParagraphProperties3.Append(characterBullet2);
            level2ParagraphProperties3.Append(defaultRunProperties31);

            A.Level3ParagraphProperties level3ParagraphProperties3 = new A.Level3ParagraphProperties(){ LeftMargin = 1143000, Indent = -228600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.LineSpacing lineSpacing4 = new A.LineSpacing();
            A.SpacingPercent spacingPercent5 = new A.SpacingPercent(){ Val = 90000 };

            lineSpacing4.Append(spacingPercent5);

            A.SpaceBefore spaceBefore4 = new A.SpaceBefore();
            A.SpacingPoints spacingPoints3 = new A.SpacingPoints(){ Val = 500 };

            spaceBefore4.Append(spacingPoints3);
            A.BulletFont bulletFont3 = new A.BulletFont(){ Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.CharacterBullet characterBullet3 = new A.CharacterBullet(){ Char = "•" };

            A.DefaultRunProperties defaultRunProperties32 = new A.DefaultRunProperties(){ FontSize = 2000, Kerning = 1200 };

            A.SolidFill solidFill51 = new A.SolidFill();
            A.SchemeColor schemeColor87 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill51.Append(schemeColor87);
            A.LatinFont latinFont17 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont17 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont17 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties32.Append(solidFill51);
            defaultRunProperties32.Append(latinFont17);
            defaultRunProperties32.Append(eastAsianFont17);
            defaultRunProperties32.Append(complexScriptFont17);

            level3ParagraphProperties3.Append(lineSpacing4);
            level3ParagraphProperties3.Append(spaceBefore4);
            level3ParagraphProperties3.Append(bulletFont3);
            level3ParagraphProperties3.Append(characterBullet3);
            level3ParagraphProperties3.Append(defaultRunProperties32);

            A.Level4ParagraphProperties level4ParagraphProperties3 = new A.Level4ParagraphProperties(){ LeftMargin = 1600200, Indent = -228600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.LineSpacing lineSpacing5 = new A.LineSpacing();
            A.SpacingPercent spacingPercent6 = new A.SpacingPercent(){ Val = 90000 };

            lineSpacing5.Append(spacingPercent6);

            A.SpaceBefore spaceBefore5 = new A.SpaceBefore();
            A.SpacingPoints spacingPoints4 = new A.SpacingPoints(){ Val = 500 };

            spaceBefore5.Append(spacingPoints4);
            A.BulletFont bulletFont4 = new A.BulletFont(){ Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.CharacterBullet characterBullet4 = new A.CharacterBullet(){ Char = "•" };

            A.DefaultRunProperties defaultRunProperties33 = new A.DefaultRunProperties(){ FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill52 = new A.SolidFill();
            A.SchemeColor schemeColor88 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill52.Append(schemeColor88);
            A.LatinFont latinFont18 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont18 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont18 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties33.Append(solidFill52);
            defaultRunProperties33.Append(latinFont18);
            defaultRunProperties33.Append(eastAsianFont18);
            defaultRunProperties33.Append(complexScriptFont18);

            level4ParagraphProperties3.Append(lineSpacing5);
            level4ParagraphProperties3.Append(spaceBefore5);
            level4ParagraphProperties3.Append(bulletFont4);
            level4ParagraphProperties3.Append(characterBullet4);
            level4ParagraphProperties3.Append(defaultRunProperties33);

            A.Level5ParagraphProperties level5ParagraphProperties3 = new A.Level5ParagraphProperties(){ LeftMargin = 2057400, Indent = -228600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.LineSpacing lineSpacing6 = new A.LineSpacing();
            A.SpacingPercent spacingPercent7 = new A.SpacingPercent(){ Val = 90000 };

            lineSpacing6.Append(spacingPercent7);

            A.SpaceBefore spaceBefore6 = new A.SpaceBefore();
            A.SpacingPoints spacingPoints5 = new A.SpacingPoints(){ Val = 500 };

            spaceBefore6.Append(spacingPoints5);
            A.BulletFont bulletFont5 = new A.BulletFont(){ Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.CharacterBullet characterBullet5 = new A.CharacterBullet(){ Char = "•" };

            A.DefaultRunProperties defaultRunProperties34 = new A.DefaultRunProperties(){ FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill53 = new A.SolidFill();
            A.SchemeColor schemeColor89 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill53.Append(schemeColor89);
            A.LatinFont latinFont19 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont19 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont19 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties34.Append(solidFill53);
            defaultRunProperties34.Append(latinFont19);
            defaultRunProperties34.Append(eastAsianFont19);
            defaultRunProperties34.Append(complexScriptFont19);

            level5ParagraphProperties3.Append(lineSpacing6);
            level5ParagraphProperties3.Append(spaceBefore6);
            level5ParagraphProperties3.Append(bulletFont5);
            level5ParagraphProperties3.Append(characterBullet5);
            level5ParagraphProperties3.Append(defaultRunProperties34);

            A.Level6ParagraphProperties level6ParagraphProperties3 = new A.Level6ParagraphProperties(){ LeftMargin = 2514600, Indent = -228600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.LineSpacing lineSpacing7 = new A.LineSpacing();
            A.SpacingPercent spacingPercent8 = new A.SpacingPercent(){ Val = 90000 };

            lineSpacing7.Append(spacingPercent8);

            A.SpaceBefore spaceBefore7 = new A.SpaceBefore();
            A.SpacingPoints spacingPoints6 = new A.SpacingPoints(){ Val = 500 };

            spaceBefore7.Append(spacingPoints6);
            A.BulletFont bulletFont6 = new A.BulletFont(){ Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.CharacterBullet characterBullet6 = new A.CharacterBullet(){ Char = "•" };

            A.DefaultRunProperties defaultRunProperties35 = new A.DefaultRunProperties(){ FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill54 = new A.SolidFill();
            A.SchemeColor schemeColor90 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill54.Append(schemeColor90);
            A.LatinFont latinFont20 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont20 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont20 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties35.Append(solidFill54);
            defaultRunProperties35.Append(latinFont20);
            defaultRunProperties35.Append(eastAsianFont20);
            defaultRunProperties35.Append(complexScriptFont20);

            level6ParagraphProperties3.Append(lineSpacing7);
            level6ParagraphProperties3.Append(spaceBefore7);
            level6ParagraphProperties3.Append(bulletFont6);
            level6ParagraphProperties3.Append(characterBullet6);
            level6ParagraphProperties3.Append(defaultRunProperties35);

            A.Level7ParagraphProperties level7ParagraphProperties3 = new A.Level7ParagraphProperties(){ LeftMargin = 2971800, Indent = -228600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.LineSpacing lineSpacing8 = new A.LineSpacing();
            A.SpacingPercent spacingPercent9 = new A.SpacingPercent(){ Val = 90000 };

            lineSpacing8.Append(spacingPercent9);

            A.SpaceBefore spaceBefore8 = new A.SpaceBefore();
            A.SpacingPoints spacingPoints7 = new A.SpacingPoints(){ Val = 500 };

            spaceBefore8.Append(spacingPoints7);
            A.BulletFont bulletFont7 = new A.BulletFont(){ Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.CharacterBullet characterBullet7 = new A.CharacterBullet(){ Char = "•" };

            A.DefaultRunProperties defaultRunProperties36 = new A.DefaultRunProperties(){ FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill55 = new A.SolidFill();
            A.SchemeColor schemeColor91 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill55.Append(schemeColor91);
            A.LatinFont latinFont21 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont21 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont21 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties36.Append(solidFill55);
            defaultRunProperties36.Append(latinFont21);
            defaultRunProperties36.Append(eastAsianFont21);
            defaultRunProperties36.Append(complexScriptFont21);

            level7ParagraphProperties3.Append(lineSpacing8);
            level7ParagraphProperties3.Append(spaceBefore8);
            level7ParagraphProperties3.Append(bulletFont7);
            level7ParagraphProperties3.Append(characterBullet7);
            level7ParagraphProperties3.Append(defaultRunProperties36);

            A.Level8ParagraphProperties level8ParagraphProperties3 = new A.Level8ParagraphProperties(){ LeftMargin = 3429000, Indent = -228600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.LineSpacing lineSpacing9 = new A.LineSpacing();
            A.SpacingPercent spacingPercent10 = new A.SpacingPercent(){ Val = 90000 };

            lineSpacing9.Append(spacingPercent10);

            A.SpaceBefore spaceBefore9 = new A.SpaceBefore();
            A.SpacingPoints spacingPoints8 = new A.SpacingPoints(){ Val = 500 };

            spaceBefore9.Append(spacingPoints8);
            A.BulletFont bulletFont8 = new A.BulletFont(){ Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.CharacterBullet characterBullet8 = new A.CharacterBullet(){ Char = "•" };

            A.DefaultRunProperties defaultRunProperties37 = new A.DefaultRunProperties(){ FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill56 = new A.SolidFill();
            A.SchemeColor schemeColor92 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill56.Append(schemeColor92);
            A.LatinFont latinFont22 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont22 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont22 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties37.Append(solidFill56);
            defaultRunProperties37.Append(latinFont22);
            defaultRunProperties37.Append(eastAsianFont22);
            defaultRunProperties37.Append(complexScriptFont22);

            level8ParagraphProperties3.Append(lineSpacing9);
            level8ParagraphProperties3.Append(spaceBefore9);
            level8ParagraphProperties3.Append(bulletFont8);
            level8ParagraphProperties3.Append(characterBullet8);
            level8ParagraphProperties3.Append(defaultRunProperties37);

            A.Level9ParagraphProperties level9ParagraphProperties3 = new A.Level9ParagraphProperties(){ LeftMargin = 3886200, Indent = -228600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.LineSpacing lineSpacing10 = new A.LineSpacing();
            A.SpacingPercent spacingPercent11 = new A.SpacingPercent(){ Val = 90000 };

            lineSpacing10.Append(spacingPercent11);

            A.SpaceBefore spaceBefore10 = new A.SpaceBefore();
            A.SpacingPoints spacingPoints9 = new A.SpacingPoints(){ Val = 500 };

            spaceBefore10.Append(spacingPoints9);
            A.BulletFont bulletFont9 = new A.BulletFont(){ Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.CharacterBullet characterBullet9 = new A.CharacterBullet(){ Char = "•" };

            A.DefaultRunProperties defaultRunProperties38 = new A.DefaultRunProperties(){ FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill57 = new A.SolidFill();
            A.SchemeColor schemeColor93 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill57.Append(schemeColor93);
            A.LatinFont latinFont23 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont23 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont23 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties38.Append(solidFill57);
            defaultRunProperties38.Append(latinFont23);
            defaultRunProperties38.Append(eastAsianFont23);
            defaultRunProperties38.Append(complexScriptFont23);

            level9ParagraphProperties3.Append(lineSpacing10);
            level9ParagraphProperties3.Append(spaceBefore10);
            level9ParagraphProperties3.Append(bulletFont9);
            level9ParagraphProperties3.Append(characterBullet9);
            level9ParagraphProperties3.Append(defaultRunProperties38);

            bodyStyle1.Append(level1ParagraphProperties8);
            bodyStyle1.Append(level2ParagraphProperties3);
            bodyStyle1.Append(level3ParagraphProperties3);
            bodyStyle1.Append(level4ParagraphProperties3);
            bodyStyle1.Append(level5ParagraphProperties3);
            bodyStyle1.Append(level6ParagraphProperties3);
            bodyStyle1.Append(level7ParagraphProperties3);
            bodyStyle1.Append(level8ParagraphProperties3);
            bodyStyle1.Append(level9ParagraphProperties3);

            OtherStyle otherStyle1 = new OtherStyle();

            A.DefaultParagraphProperties defaultParagraphProperties2 = new A.DefaultParagraphProperties();
            A.DefaultRunProperties defaultRunProperties39 = new A.DefaultRunProperties(){ Language = "en-US" };

            defaultParagraphProperties2.Append(defaultRunProperties39);

            A.Level1ParagraphProperties level1ParagraphProperties9 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties40 = new A.DefaultRunProperties(){ FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill58 = new A.SolidFill();
            A.SchemeColor schemeColor94 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill58.Append(schemeColor94);
            A.LatinFont latinFont24 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont24 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont24 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties40.Append(solidFill58);
            defaultRunProperties40.Append(latinFont24);
            defaultRunProperties40.Append(eastAsianFont24);
            defaultRunProperties40.Append(complexScriptFont24);

            level1ParagraphProperties9.Append(defaultRunProperties40);

            A.Level2ParagraphProperties level2ParagraphProperties4 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties41 = new A.DefaultRunProperties(){ FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill59 = new A.SolidFill();
            A.SchemeColor schemeColor95 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill59.Append(schemeColor95);
            A.LatinFont latinFont25 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont25 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont25 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties41.Append(solidFill59);
            defaultRunProperties41.Append(latinFont25);
            defaultRunProperties41.Append(eastAsianFont25);
            defaultRunProperties41.Append(complexScriptFont25);

            level2ParagraphProperties4.Append(defaultRunProperties41);

            A.Level3ParagraphProperties level3ParagraphProperties4 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties42 = new A.DefaultRunProperties(){ FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill60 = new A.SolidFill();
            A.SchemeColor schemeColor96 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill60.Append(schemeColor96);
            A.LatinFont latinFont26 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont26 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont26 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties42.Append(solidFill60);
            defaultRunProperties42.Append(latinFont26);
            defaultRunProperties42.Append(eastAsianFont26);
            defaultRunProperties42.Append(complexScriptFont26);

            level3ParagraphProperties4.Append(defaultRunProperties42);

            A.Level4ParagraphProperties level4ParagraphProperties4 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties43 = new A.DefaultRunProperties(){ FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill61 = new A.SolidFill();
            A.SchemeColor schemeColor97 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill61.Append(schemeColor97);
            A.LatinFont latinFont27 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont27 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont27 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties43.Append(solidFill61);
            defaultRunProperties43.Append(latinFont27);
            defaultRunProperties43.Append(eastAsianFont27);
            defaultRunProperties43.Append(complexScriptFont27);

            level4ParagraphProperties4.Append(defaultRunProperties43);

            A.Level5ParagraphProperties level5ParagraphProperties4 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties44 = new A.DefaultRunProperties(){ FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill62 = new A.SolidFill();
            A.SchemeColor schemeColor98 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill62.Append(schemeColor98);
            A.LatinFont latinFont28 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont28 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont28 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties44.Append(solidFill62);
            defaultRunProperties44.Append(latinFont28);
            defaultRunProperties44.Append(eastAsianFont28);
            defaultRunProperties44.Append(complexScriptFont28);

            level5ParagraphProperties4.Append(defaultRunProperties44);

            A.Level6ParagraphProperties level6ParagraphProperties4 = new A.Level6ParagraphProperties(){ LeftMargin = 2286000, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties45 = new A.DefaultRunProperties(){ FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill63 = new A.SolidFill();
            A.SchemeColor schemeColor99 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill63.Append(schemeColor99);
            A.LatinFont latinFont29 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont29 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont29 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties45.Append(solidFill63);
            defaultRunProperties45.Append(latinFont29);
            defaultRunProperties45.Append(eastAsianFont29);
            defaultRunProperties45.Append(complexScriptFont29);

            level6ParagraphProperties4.Append(defaultRunProperties45);

            A.Level7ParagraphProperties level7ParagraphProperties4 = new A.Level7ParagraphProperties(){ LeftMargin = 2743200, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties46 = new A.DefaultRunProperties(){ FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill64 = new A.SolidFill();
            A.SchemeColor schemeColor100 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill64.Append(schemeColor100);
            A.LatinFont latinFont30 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont30 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont30 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties46.Append(solidFill64);
            defaultRunProperties46.Append(latinFont30);
            defaultRunProperties46.Append(eastAsianFont30);
            defaultRunProperties46.Append(complexScriptFont30);

            level7ParagraphProperties4.Append(defaultRunProperties46);

            A.Level8ParagraphProperties level8ParagraphProperties4 = new A.Level8ParagraphProperties(){ LeftMargin = 3200400, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties47 = new A.DefaultRunProperties(){ FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill65 = new A.SolidFill();
            A.SchemeColor schemeColor101 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill65.Append(schemeColor101);
            A.LatinFont latinFont31 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont31 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont31 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties47.Append(solidFill65);
            defaultRunProperties47.Append(latinFont31);
            defaultRunProperties47.Append(eastAsianFont31);
            defaultRunProperties47.Append(complexScriptFont31);

            level8ParagraphProperties4.Append(defaultRunProperties47);

            A.Level9ParagraphProperties level9ParagraphProperties4 = new A.Level9ParagraphProperties(){ LeftMargin = 3657600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties48 = new A.DefaultRunProperties(){ FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill66 = new A.SolidFill();
            A.SchemeColor schemeColor102 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill66.Append(schemeColor102);
            A.LatinFont latinFont32 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont32 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont32 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties48.Append(solidFill66);
            defaultRunProperties48.Append(latinFont32);
            defaultRunProperties48.Append(eastAsianFont32);
            defaultRunProperties48.Append(complexScriptFont32);

            level9ParagraphProperties4.Append(defaultRunProperties48);

            otherStyle1.Append(defaultParagraphProperties2);
            otherStyle1.Append(level1ParagraphProperties9);
            otherStyle1.Append(level2ParagraphProperties4);
            otherStyle1.Append(level3ParagraphProperties4);
            otherStyle1.Append(level4ParagraphProperties4);
            otherStyle1.Append(level5ParagraphProperties4);
            otherStyle1.Append(level6ParagraphProperties4);
            otherStyle1.Append(level7ParagraphProperties4);
            otherStyle1.Append(level8ParagraphProperties4);
            otherStyle1.Append(level9ParagraphProperties4);

            textStyles1.Append(titleStyle2);
            textStyles1.Append(bodyStyle1);
            textStyles1.Append(otherStyle1);

            slideMaster1.Append(commonSlideData3);
            slideMaster1.Append(colorMap1);
            slideMaster1.Append(slideLayoutIdList1);
            slideMaster1.Append(textStyles1);

            slideMasterPart1.SlideMaster = slideMaster1;
        }

        // Generates content of slideLayoutPart2.
        private void GenerateSlideLayoutPart2Content(SlideLayoutPart slideLayoutPart2)
        {
            SlideLayout slideLayout2 = new SlideLayout(){ Type = SlideLayoutValues.ObjectText, Preserve = true };
            slideLayout2.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout2.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout2.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData4 = new CommonSlideData(){ Name = "Content with Caption" };

            ShapeTree shapeTree4 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties4 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties15 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties4 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties15 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties4.Append(nonVisualDrawingProperties15);
            nonVisualGroupShapeProperties4.Append(nonVisualGroupShapeDrawingProperties4);
            nonVisualGroupShapeProperties4.Append(applicationNonVisualDrawingProperties15);

            GroupShapeProperties groupShapeProperties4 = new GroupShapeProperties();

            A.TransformGroup transformGroup4 = new A.TransformGroup();
            A.Offset offset12 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents12 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset4 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents4 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup4.Append(offset12);
            transformGroup4.Append(extents12);
            transformGroup4.Append(childOffset4);
            transformGroup4.Append(childExtents4);

            groupShapeProperties4.Append(transformGroup4);

            Shape shape11 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties11 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties16 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList12 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension12 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement14 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{A2D3AA41-1ADE-4971-9D0C-D4AF929FC580}\" />");

            nonVisualDrawingPropertiesExtension12.Append(openXmlUnknownElement14);

            nonVisualDrawingPropertiesExtensionList12.Append(nonVisualDrawingPropertiesExtension12);

            nonVisualDrawingProperties16.Append(nonVisualDrawingPropertiesExtensionList12);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties11 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks11 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties11.Append(shapeLocks11);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties16 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape11 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties16.Append(placeholderShape11);

            nonVisualShapeProperties11.Append(nonVisualDrawingProperties16);
            nonVisualShapeProperties11.Append(nonVisualShapeDrawingProperties11);
            nonVisualShapeProperties11.Append(applicationNonVisualDrawingProperties16);

            ShapeProperties shapeProperties33 = new ShapeProperties();

            A.Transform2D transform2D8 = new A.Transform2D();
            A.Offset offset13 = new A.Offset(){ X = 839788L, Y = 457200L };
            A.Extents extents13 = new A.Extents(){ Cx = 3932237L, Cy = 1600200L };

            transform2D8.Append(offset13);
            transform2D8.Append(extents13);

            shapeProperties33.Append(transform2D8);

            TextBody textBody11 = new TextBody();
            A.BodyProperties bodyProperties16 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Bottom };

            A.ListStyle listStyle16 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties10 = new A.Level1ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties49 = new A.DefaultRunProperties(){ FontSize = 3200 };

            level1ParagraphProperties10.Append(defaultRunProperties49);

            listStyle16.Append(level1ParagraphProperties10);

            A.Paragraph paragraph20 = new A.Paragraph();

            A.Run run9 = new A.Run();
            A.RunProperties runProperties13 = new A.RunProperties(){ Language = "en-US" };
            A.Text text13 = new A.Text();
            text13.Text = "Click to edit Master title style";

            run9.Append(runProperties13);
            run9.Append(text13);

            paragraph20.Append(run9);

            textBody11.Append(bodyProperties16);
            textBody11.Append(listStyle16);
            textBody11.Append(paragraph20);

            shape11.Append(nonVisualShapeProperties11);
            shape11.Append(shapeProperties33);
            shape11.Append(textBody11);

            Shape shape12 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties12 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties17 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Content Placeholder 2" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList13 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension13 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement15 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{8A391229-CF22-400D-AA26-E8ADA975DD3E}\" />");

            nonVisualDrawingPropertiesExtension13.Append(openXmlUnknownElement15);

            nonVisualDrawingPropertiesExtensionList13.Append(nonVisualDrawingPropertiesExtension13);

            nonVisualDrawingProperties17.Append(nonVisualDrawingPropertiesExtensionList13);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties12 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks12 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties12.Append(shapeLocks12);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties17 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape12 = new PlaceholderShape(){ Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties17.Append(placeholderShape12);

            nonVisualShapeProperties12.Append(nonVisualDrawingProperties17);
            nonVisualShapeProperties12.Append(nonVisualShapeDrawingProperties12);
            nonVisualShapeProperties12.Append(applicationNonVisualDrawingProperties17);

            ShapeProperties shapeProperties34 = new ShapeProperties();

            A.Transform2D transform2D9 = new A.Transform2D();
            A.Offset offset14 = new A.Offset(){ X = 5183188L, Y = 987425L };
            A.Extents extents14 = new A.Extents(){ Cx = 6172200L, Cy = 4873625L };

            transform2D9.Append(offset14);
            transform2D9.Append(extents14);

            shapeProperties34.Append(transform2D9);

            TextBody textBody12 = new TextBody();
            A.BodyProperties bodyProperties17 = new A.BodyProperties();

            A.ListStyle listStyle17 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties11 = new A.Level1ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties50 = new A.DefaultRunProperties(){ FontSize = 3200 };

            level1ParagraphProperties11.Append(defaultRunProperties50);

            A.Level2ParagraphProperties level2ParagraphProperties5 = new A.Level2ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties51 = new A.DefaultRunProperties(){ FontSize = 2800 };

            level2ParagraphProperties5.Append(defaultRunProperties51);

            A.Level3ParagraphProperties level3ParagraphProperties5 = new A.Level3ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties52 = new A.DefaultRunProperties(){ FontSize = 2400 };

            level3ParagraphProperties5.Append(defaultRunProperties52);

            A.Level4ParagraphProperties level4ParagraphProperties5 = new A.Level4ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties53 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level4ParagraphProperties5.Append(defaultRunProperties53);

            A.Level5ParagraphProperties level5ParagraphProperties5 = new A.Level5ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties54 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level5ParagraphProperties5.Append(defaultRunProperties54);

            A.Level6ParagraphProperties level6ParagraphProperties5 = new A.Level6ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties55 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level6ParagraphProperties5.Append(defaultRunProperties55);

            A.Level7ParagraphProperties level7ParagraphProperties5 = new A.Level7ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties56 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level7ParagraphProperties5.Append(defaultRunProperties56);

            A.Level8ParagraphProperties level8ParagraphProperties5 = new A.Level8ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties57 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level8ParagraphProperties5.Append(defaultRunProperties57);

            A.Level9ParagraphProperties level9ParagraphProperties5 = new A.Level9ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties58 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level9ParagraphProperties5.Append(defaultRunProperties58);

            listStyle17.Append(level1ParagraphProperties11);
            listStyle17.Append(level2ParagraphProperties5);
            listStyle17.Append(level3ParagraphProperties5);
            listStyle17.Append(level4ParagraphProperties5);
            listStyle17.Append(level5ParagraphProperties5);
            listStyle17.Append(level6ParagraphProperties5);
            listStyle17.Append(level7ParagraphProperties5);
            listStyle17.Append(level8ParagraphProperties5);
            listStyle17.Append(level9ParagraphProperties5);

            A.Paragraph paragraph21 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties11 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run10 = new A.Run();
            A.RunProperties runProperties14 = new A.RunProperties(){ Language = "en-US" };
            A.Text text14 = new A.Text();
            text14.Text = "Click to edit Master text styles";

            run10.Append(runProperties14);
            run10.Append(text14);

            paragraph21.Append(paragraphProperties11);
            paragraph21.Append(run10);

            A.Paragraph paragraph22 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties12 = new A.ParagraphProperties(){ Level = 1 };

            A.Run run11 = new A.Run();
            A.RunProperties runProperties15 = new A.RunProperties(){ Language = "en-US" };
            A.Text text15 = new A.Text();
            text15.Text = "Second level";

            run11.Append(runProperties15);
            run11.Append(text15);

            paragraph22.Append(paragraphProperties12);
            paragraph22.Append(run11);

            A.Paragraph paragraph23 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties13 = new A.ParagraphProperties(){ Level = 2 };

            A.Run run12 = new A.Run();
            A.RunProperties runProperties16 = new A.RunProperties(){ Language = "en-US" };
            A.Text text16 = new A.Text();
            text16.Text = "Third level";

            run12.Append(runProperties16);
            run12.Append(text16);

            paragraph23.Append(paragraphProperties13);
            paragraph23.Append(run12);

            A.Paragraph paragraph24 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties14 = new A.ParagraphProperties(){ Level = 3 };

            A.Run run13 = new A.Run();
            A.RunProperties runProperties17 = new A.RunProperties(){ Language = "en-US" };
            A.Text text17 = new A.Text();
            text17.Text = "Fourth level";

            run13.Append(runProperties17);
            run13.Append(text17);

            paragraph24.Append(paragraphProperties14);
            paragraph24.Append(run13);

            A.Paragraph paragraph25 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties15 = new A.ParagraphProperties(){ Level = 4 };

            A.Run run14 = new A.Run();
            A.RunProperties runProperties18 = new A.RunProperties(){ Language = "en-US" };
            A.Text text18 = new A.Text();
            text18.Text = "Fifth level";

            run14.Append(runProperties18);
            run14.Append(text18);

            paragraph25.Append(paragraphProperties15);
            paragraph25.Append(run14);

            textBody12.Append(bodyProperties17);
            textBody12.Append(listStyle17);
            textBody12.Append(paragraph21);
            textBody12.Append(paragraph22);
            textBody12.Append(paragraph23);
            textBody12.Append(paragraph24);
            textBody12.Append(paragraph25);

            shape12.Append(nonVisualShapeProperties12);
            shape12.Append(shapeProperties34);
            shape12.Append(textBody12);

            Shape shape13 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties13 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties18 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Text Placeholder 3" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList14 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension14 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement16 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{7DACECB6-0AC4-48C6-A491-4F7CC00CFF5E}\" />");

            nonVisualDrawingPropertiesExtension14.Append(openXmlUnknownElement16);

            nonVisualDrawingPropertiesExtensionList14.Append(nonVisualDrawingPropertiesExtension14);

            nonVisualDrawingProperties18.Append(nonVisualDrawingPropertiesExtensionList14);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties13 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks13 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties13.Append(shapeLocks13);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties18 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape13 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)2U };

            applicationNonVisualDrawingProperties18.Append(placeholderShape13);

            nonVisualShapeProperties13.Append(nonVisualDrawingProperties18);
            nonVisualShapeProperties13.Append(nonVisualShapeDrawingProperties13);
            nonVisualShapeProperties13.Append(applicationNonVisualDrawingProperties18);

            ShapeProperties shapeProperties35 = new ShapeProperties();

            A.Transform2D transform2D10 = new A.Transform2D();
            A.Offset offset15 = new A.Offset(){ X = 839788L, Y = 2057400L };
            A.Extents extents15 = new A.Extents(){ Cx = 3932237L, Cy = 3811588L };

            transform2D10.Append(offset15);
            transform2D10.Append(extents15);

            shapeProperties35.Append(transform2D10);

            TextBody textBody13 = new TextBody();
            A.BodyProperties bodyProperties18 = new A.BodyProperties();

            A.ListStyle listStyle18 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties12 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0 };
            A.NoBullet noBullet11 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties59 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level1ParagraphProperties12.Append(noBullet11);
            level1ParagraphProperties12.Append(defaultRunProperties59);

            A.Level2ParagraphProperties level2ParagraphProperties6 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Indent = 0 };
            A.NoBullet noBullet12 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties60 = new A.DefaultRunProperties(){ FontSize = 1400 };

            level2ParagraphProperties6.Append(noBullet12);
            level2ParagraphProperties6.Append(defaultRunProperties60);

            A.Level3ParagraphProperties level3ParagraphProperties6 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Indent = 0 };
            A.NoBullet noBullet13 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties61 = new A.DefaultRunProperties(){ FontSize = 1200 };

            level3ParagraphProperties6.Append(noBullet13);
            level3ParagraphProperties6.Append(defaultRunProperties61);

            A.Level4ParagraphProperties level4ParagraphProperties6 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Indent = 0 };
            A.NoBullet noBullet14 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties62 = new A.DefaultRunProperties(){ FontSize = 1000 };

            level4ParagraphProperties6.Append(noBullet14);
            level4ParagraphProperties6.Append(defaultRunProperties62);

            A.Level5ParagraphProperties level5ParagraphProperties6 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Indent = 0 };
            A.NoBullet noBullet15 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties63 = new A.DefaultRunProperties(){ FontSize = 1000 };

            level5ParagraphProperties6.Append(noBullet15);
            level5ParagraphProperties6.Append(defaultRunProperties63);

            A.Level6ParagraphProperties level6ParagraphProperties6 = new A.Level6ParagraphProperties(){ LeftMargin = 2286000, Indent = 0 };
            A.NoBullet noBullet16 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties64 = new A.DefaultRunProperties(){ FontSize = 1000 };

            level6ParagraphProperties6.Append(noBullet16);
            level6ParagraphProperties6.Append(defaultRunProperties64);

            A.Level7ParagraphProperties level7ParagraphProperties6 = new A.Level7ParagraphProperties(){ LeftMargin = 2743200, Indent = 0 };
            A.NoBullet noBullet17 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties65 = new A.DefaultRunProperties(){ FontSize = 1000 };

            level7ParagraphProperties6.Append(noBullet17);
            level7ParagraphProperties6.Append(defaultRunProperties65);

            A.Level8ParagraphProperties level8ParagraphProperties6 = new A.Level8ParagraphProperties(){ LeftMargin = 3200400, Indent = 0 };
            A.NoBullet noBullet18 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties66 = new A.DefaultRunProperties(){ FontSize = 1000 };

            level8ParagraphProperties6.Append(noBullet18);
            level8ParagraphProperties6.Append(defaultRunProperties66);

            A.Level9ParagraphProperties level9ParagraphProperties6 = new A.Level9ParagraphProperties(){ LeftMargin = 3657600, Indent = 0 };
            A.NoBullet noBullet19 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties67 = new A.DefaultRunProperties(){ FontSize = 1000 };

            level9ParagraphProperties6.Append(noBullet19);
            level9ParagraphProperties6.Append(defaultRunProperties67);

            listStyle18.Append(level1ParagraphProperties12);
            listStyle18.Append(level2ParagraphProperties6);
            listStyle18.Append(level3ParagraphProperties6);
            listStyle18.Append(level4ParagraphProperties6);
            listStyle18.Append(level5ParagraphProperties6);
            listStyle18.Append(level6ParagraphProperties6);
            listStyle18.Append(level7ParagraphProperties6);
            listStyle18.Append(level8ParagraphProperties6);
            listStyle18.Append(level9ParagraphProperties6);

            A.Paragraph paragraph26 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties16 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run15 = new A.Run();
            A.RunProperties runProperties19 = new A.RunProperties(){ Language = "en-US" };
            A.Text text19 = new A.Text();
            text19.Text = "Click to edit Master text styles";

            run15.Append(runProperties19);
            run15.Append(text19);

            paragraph26.Append(paragraphProperties16);
            paragraph26.Append(run15);

            textBody13.Append(bodyProperties18);
            textBody13.Append(listStyle18);
            textBody13.Append(paragraph26);

            shape13.Append(nonVisualShapeProperties13);
            shape13.Append(shapeProperties35);
            shape13.Append(textBody13);

            Shape shape14 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties14 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties19 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Date Placeholder 4" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList15 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension15 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement17 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{8CA9310A-C2C2-4734-8F40-D693024B8803}\" />");

            nonVisualDrawingPropertiesExtension15.Append(openXmlUnknownElement17);

            nonVisualDrawingPropertiesExtensionList15.Append(nonVisualDrawingPropertiesExtension15);

            nonVisualDrawingProperties19.Append(nonVisualDrawingPropertiesExtensionList15);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties14 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks14 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties14.Append(shapeLocks14);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties19 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape14 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties19.Append(placeholderShape14);

            nonVisualShapeProperties14.Append(nonVisualDrawingProperties19);
            nonVisualShapeProperties14.Append(nonVisualShapeDrawingProperties14);
            nonVisualShapeProperties14.Append(applicationNonVisualDrawingProperties19);
            ShapeProperties shapeProperties36 = new ShapeProperties();

            TextBody textBody14 = new TextBody();
            A.BodyProperties bodyProperties19 = new A.BodyProperties();
            A.ListStyle listStyle19 = new A.ListStyle();

            A.Paragraph paragraph27 = new A.Paragraph();

            A.Field field5 = new A.Field(){ Id = "{9BEF4A3D-57C8-4DC0-86D0-95A05287C467}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties20 = new A.RunProperties(){ Language = "en-US" };
            runProperties20.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text20 = new A.Text();
            text20.Text = "1/29/2020";

            field5.Append(runProperties20);
            field5.Append(text20);
            A.EndParagraphRunProperties endParagraphRunProperties12 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph27.Append(field5);
            paragraph27.Append(endParagraphRunProperties12);

            textBody14.Append(bodyProperties19);
            textBody14.Append(listStyle19);
            textBody14.Append(paragraph27);

            shape14.Append(nonVisualShapeProperties14);
            shape14.Append(shapeProperties36);
            shape14.Append(textBody14);

            Shape shape15 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties15 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties20 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Footer Placeholder 5" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList16 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension16 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement18 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{CF6BD412-7644-4B49-B187-D62ED54DC7F6}\" />");

            nonVisualDrawingPropertiesExtension16.Append(openXmlUnknownElement18);

            nonVisualDrawingPropertiesExtensionList16.Append(nonVisualDrawingPropertiesExtension16);

            nonVisualDrawingProperties20.Append(nonVisualDrawingPropertiesExtensionList16);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties15 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks15 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties15.Append(shapeLocks15);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties20 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape15 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties20.Append(placeholderShape15);

            nonVisualShapeProperties15.Append(nonVisualDrawingProperties20);
            nonVisualShapeProperties15.Append(nonVisualShapeDrawingProperties15);
            nonVisualShapeProperties15.Append(applicationNonVisualDrawingProperties20);
            ShapeProperties shapeProperties37 = new ShapeProperties();

            TextBody textBody15 = new TextBody();
            A.BodyProperties bodyProperties20 = new A.BodyProperties();
            A.ListStyle listStyle20 = new A.ListStyle();

            A.Paragraph paragraph28 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties13 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph28.Append(endParagraphRunProperties13);

            textBody15.Append(bodyProperties20);
            textBody15.Append(listStyle20);
            textBody15.Append(paragraph28);

            shape15.Append(nonVisualShapeProperties15);
            shape15.Append(shapeProperties37);
            shape15.Append(textBody15);

            Shape shape16 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties16 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties21 = new NonVisualDrawingProperties(){ Id = (UInt32Value)7U, Name = "Slide Number Placeholder 6" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList17 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension17 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement19 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{2768FC7D-3B78-4BB8-811C-57DA4166D160}\" />");

            nonVisualDrawingPropertiesExtension17.Append(openXmlUnknownElement19);

            nonVisualDrawingPropertiesExtensionList17.Append(nonVisualDrawingPropertiesExtension17);

            nonVisualDrawingProperties21.Append(nonVisualDrawingPropertiesExtensionList17);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties16 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks16 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties16.Append(shapeLocks16);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties21 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape16 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties21.Append(placeholderShape16);

            nonVisualShapeProperties16.Append(nonVisualDrawingProperties21);
            nonVisualShapeProperties16.Append(nonVisualShapeDrawingProperties16);
            nonVisualShapeProperties16.Append(applicationNonVisualDrawingProperties21);
            ShapeProperties shapeProperties38 = new ShapeProperties();

            TextBody textBody16 = new TextBody();
            A.BodyProperties bodyProperties21 = new A.BodyProperties();
            A.ListStyle listStyle21 = new A.ListStyle();

            A.Paragraph paragraph29 = new A.Paragraph();

            A.Field field6 = new A.Field(){ Id = "{1BF20D12-B4E9-4886-A78D-768EA8FF95DD}", Type = "slidenum" };

            A.RunProperties runProperties21 = new A.RunProperties(){ Language = "en-US" };
            runProperties21.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text21 = new A.Text();
            text21.Text = "‹#›";

            field6.Append(runProperties21);
            field6.Append(text21);
            A.EndParagraphRunProperties endParagraphRunProperties14 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph29.Append(field6);
            paragraph29.Append(endParagraphRunProperties14);

            textBody16.Append(bodyProperties21);
            textBody16.Append(listStyle21);
            textBody16.Append(paragraph29);

            shape16.Append(nonVisualShapeProperties16);
            shape16.Append(shapeProperties38);
            shape16.Append(textBody16);

            shapeTree4.Append(nonVisualGroupShapeProperties4);
            shapeTree4.Append(groupShapeProperties4);
            shapeTree4.Append(shape11);
            shapeTree4.Append(shape12);
            shapeTree4.Append(shape13);
            shapeTree4.Append(shape14);
            shapeTree4.Append(shape15);
            shapeTree4.Append(shape16);

            CommonSlideDataExtensionList commonSlideDataExtensionList4 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension4 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId4 = new P14.CreationId(){ Val = (UInt32Value)1681221299U };
            creationId4.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension4.Append(creationId4);

            commonSlideDataExtensionList4.Append(commonSlideDataExtension4);

            commonSlideData4.Append(shapeTree4);
            commonSlideData4.Append(commonSlideDataExtensionList4);

            ColorMapOverride colorMapOverride3 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping3 = new A.MasterColorMapping();

            colorMapOverride3.Append(masterColorMapping3);

            slideLayout2.Append(commonSlideData4);
            slideLayout2.Append(colorMapOverride3);

            slideLayoutPart2.SlideLayout = slideLayout2;
        }

        // Generates content of slideLayoutPart3.
        private void GenerateSlideLayoutPart3Content(SlideLayoutPart slideLayoutPart3)
        {
            SlideLayout slideLayout3 = new SlideLayout(){ Type = SlideLayoutValues.SectionHeader, Preserve = true };
            slideLayout3.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout3.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout3.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData5 = new CommonSlideData(){ Name = "Section Header" };

            ShapeTree shapeTree5 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties5 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties22 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties5 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties22 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties5.Append(nonVisualDrawingProperties22);
            nonVisualGroupShapeProperties5.Append(nonVisualGroupShapeDrawingProperties5);
            nonVisualGroupShapeProperties5.Append(applicationNonVisualDrawingProperties22);

            GroupShapeProperties groupShapeProperties5 = new GroupShapeProperties();

            A.TransformGroup transformGroup5 = new A.TransformGroup();
            A.Offset offset16 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents16 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset5 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents5 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup5.Append(offset16);
            transformGroup5.Append(extents16);
            transformGroup5.Append(childOffset5);
            transformGroup5.Append(childExtents5);

            groupShapeProperties5.Append(transformGroup5);

            Shape shape17 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties17 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties23 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList18 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension18 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement20 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{06E125AB-E2BE-414F-B9BF-2E6084EA4641}\" />");

            nonVisualDrawingPropertiesExtension18.Append(openXmlUnknownElement20);

            nonVisualDrawingPropertiesExtensionList18.Append(nonVisualDrawingPropertiesExtension18);

            nonVisualDrawingProperties23.Append(nonVisualDrawingPropertiesExtensionList18);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties17 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks17 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties17.Append(shapeLocks17);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties23 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape17 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties23.Append(placeholderShape17);

            nonVisualShapeProperties17.Append(nonVisualDrawingProperties23);
            nonVisualShapeProperties17.Append(nonVisualShapeDrawingProperties17);
            nonVisualShapeProperties17.Append(applicationNonVisualDrawingProperties23);

            ShapeProperties shapeProperties39 = new ShapeProperties();

            A.Transform2D transform2D11 = new A.Transform2D();
            A.Offset offset17 = new A.Offset(){ X = 831850L, Y = 1709738L };
            A.Extents extents17 = new A.Extents(){ Cx = 10515600L, Cy = 2852737L };

            transform2D11.Append(offset17);
            transform2D11.Append(extents17);

            shapeProperties39.Append(transform2D11);

            TextBody textBody17 = new TextBody();
            A.BodyProperties bodyProperties22 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Bottom };

            A.ListStyle listStyle22 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties13 = new A.Level1ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties68 = new A.DefaultRunProperties(){ FontSize = 6000 };

            level1ParagraphProperties13.Append(defaultRunProperties68);

            listStyle22.Append(level1ParagraphProperties13);

            A.Paragraph paragraph30 = new A.Paragraph();

            A.Run run16 = new A.Run();
            A.RunProperties runProperties22 = new A.RunProperties(){ Language = "en-US" };
            A.Text text22 = new A.Text();
            text22.Text = "Click to edit Master title style";

            run16.Append(runProperties22);
            run16.Append(text22);

            paragraph30.Append(run16);

            textBody17.Append(bodyProperties22);
            textBody17.Append(listStyle22);
            textBody17.Append(paragraph30);

            shape17.Append(nonVisualShapeProperties17);
            shape17.Append(shapeProperties39);
            shape17.Append(textBody17);

            Shape shape18 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties18 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties24 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Text Placeholder 2" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList19 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension19 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement21 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{89105584-5CCB-4A96-BB66-369A9CEA72BB}\" />");

            nonVisualDrawingPropertiesExtension19.Append(openXmlUnknownElement21);

            nonVisualDrawingPropertiesExtensionList19.Append(nonVisualDrawingPropertiesExtension19);

            nonVisualDrawingProperties24.Append(nonVisualDrawingPropertiesExtensionList19);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties18 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks18 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties18.Append(shapeLocks18);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties24 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape18 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties24.Append(placeholderShape18);

            nonVisualShapeProperties18.Append(nonVisualDrawingProperties24);
            nonVisualShapeProperties18.Append(nonVisualShapeDrawingProperties18);
            nonVisualShapeProperties18.Append(applicationNonVisualDrawingProperties24);

            ShapeProperties shapeProperties40 = new ShapeProperties();

            A.Transform2D transform2D12 = new A.Transform2D();
            A.Offset offset18 = new A.Offset(){ X = 831850L, Y = 4589463L };
            A.Extents extents18 = new A.Extents(){ Cx = 10515600L, Cy = 1500187L };

            transform2D12.Append(offset18);
            transform2D12.Append(extents18);

            shapeProperties40.Append(transform2D12);

            TextBody textBody18 = new TextBody();
            A.BodyProperties bodyProperties23 = new A.BodyProperties();

            A.ListStyle listStyle23 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties14 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0 };
            A.NoBullet noBullet20 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties69 = new A.DefaultRunProperties(){ FontSize = 2400 };

            A.SolidFill solidFill67 = new A.SolidFill();

            A.SchemeColor schemeColor103 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint4 = new A.Tint(){ Val = 75000 };

            schemeColor103.Append(tint4);

            solidFill67.Append(schemeColor103);

            defaultRunProperties69.Append(solidFill67);

            level1ParagraphProperties14.Append(noBullet20);
            level1ParagraphProperties14.Append(defaultRunProperties69);

            A.Level2ParagraphProperties level2ParagraphProperties7 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Indent = 0 };
            A.NoBullet noBullet21 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties70 = new A.DefaultRunProperties(){ FontSize = 2000 };

            A.SolidFill solidFill68 = new A.SolidFill();

            A.SchemeColor schemeColor104 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint5 = new A.Tint(){ Val = 75000 };

            schemeColor104.Append(tint5);

            solidFill68.Append(schemeColor104);

            defaultRunProperties70.Append(solidFill68);

            level2ParagraphProperties7.Append(noBullet21);
            level2ParagraphProperties7.Append(defaultRunProperties70);

            A.Level3ParagraphProperties level3ParagraphProperties7 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Indent = 0 };
            A.NoBullet noBullet22 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties71 = new A.DefaultRunProperties(){ FontSize = 1800 };

            A.SolidFill solidFill69 = new A.SolidFill();

            A.SchemeColor schemeColor105 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint6 = new A.Tint(){ Val = 75000 };

            schemeColor105.Append(tint6);

            solidFill69.Append(schemeColor105);

            defaultRunProperties71.Append(solidFill69);

            level3ParagraphProperties7.Append(noBullet22);
            level3ParagraphProperties7.Append(defaultRunProperties71);

            A.Level4ParagraphProperties level4ParagraphProperties7 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Indent = 0 };
            A.NoBullet noBullet23 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties72 = new A.DefaultRunProperties(){ FontSize = 1600 };

            A.SolidFill solidFill70 = new A.SolidFill();

            A.SchemeColor schemeColor106 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint7 = new A.Tint(){ Val = 75000 };

            schemeColor106.Append(tint7);

            solidFill70.Append(schemeColor106);

            defaultRunProperties72.Append(solidFill70);

            level4ParagraphProperties7.Append(noBullet23);
            level4ParagraphProperties7.Append(defaultRunProperties72);

            A.Level5ParagraphProperties level5ParagraphProperties7 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Indent = 0 };
            A.NoBullet noBullet24 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties73 = new A.DefaultRunProperties(){ FontSize = 1600 };

            A.SolidFill solidFill71 = new A.SolidFill();

            A.SchemeColor schemeColor107 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint8 = new A.Tint(){ Val = 75000 };

            schemeColor107.Append(tint8);

            solidFill71.Append(schemeColor107);

            defaultRunProperties73.Append(solidFill71);

            level5ParagraphProperties7.Append(noBullet24);
            level5ParagraphProperties7.Append(defaultRunProperties73);

            A.Level6ParagraphProperties level6ParagraphProperties7 = new A.Level6ParagraphProperties(){ LeftMargin = 2286000, Indent = 0 };
            A.NoBullet noBullet25 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties74 = new A.DefaultRunProperties(){ FontSize = 1600 };

            A.SolidFill solidFill72 = new A.SolidFill();

            A.SchemeColor schemeColor108 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint9 = new A.Tint(){ Val = 75000 };

            schemeColor108.Append(tint9);

            solidFill72.Append(schemeColor108);

            defaultRunProperties74.Append(solidFill72);

            level6ParagraphProperties7.Append(noBullet25);
            level6ParagraphProperties7.Append(defaultRunProperties74);

            A.Level7ParagraphProperties level7ParagraphProperties7 = new A.Level7ParagraphProperties(){ LeftMargin = 2743200, Indent = 0 };
            A.NoBullet noBullet26 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties75 = new A.DefaultRunProperties(){ FontSize = 1600 };

            A.SolidFill solidFill73 = new A.SolidFill();

            A.SchemeColor schemeColor109 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint10 = new A.Tint(){ Val = 75000 };

            schemeColor109.Append(tint10);

            solidFill73.Append(schemeColor109);

            defaultRunProperties75.Append(solidFill73);

            level7ParagraphProperties7.Append(noBullet26);
            level7ParagraphProperties7.Append(defaultRunProperties75);

            A.Level8ParagraphProperties level8ParagraphProperties7 = new A.Level8ParagraphProperties(){ LeftMargin = 3200400, Indent = 0 };
            A.NoBullet noBullet27 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties76 = new A.DefaultRunProperties(){ FontSize = 1600 };

            A.SolidFill solidFill74 = new A.SolidFill();

            A.SchemeColor schemeColor110 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint11 = new A.Tint(){ Val = 75000 };

            schemeColor110.Append(tint11);

            solidFill74.Append(schemeColor110);

            defaultRunProperties76.Append(solidFill74);

            level8ParagraphProperties7.Append(noBullet27);
            level8ParagraphProperties7.Append(defaultRunProperties76);

            A.Level9ParagraphProperties level9ParagraphProperties7 = new A.Level9ParagraphProperties(){ LeftMargin = 3657600, Indent = 0 };
            A.NoBullet noBullet28 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties77 = new A.DefaultRunProperties(){ FontSize = 1600 };

            A.SolidFill solidFill75 = new A.SolidFill();

            A.SchemeColor schemeColor111 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint12 = new A.Tint(){ Val = 75000 };

            schemeColor111.Append(tint12);

            solidFill75.Append(schemeColor111);

            defaultRunProperties77.Append(solidFill75);

            level9ParagraphProperties7.Append(noBullet28);
            level9ParagraphProperties7.Append(defaultRunProperties77);

            listStyle23.Append(level1ParagraphProperties14);
            listStyle23.Append(level2ParagraphProperties7);
            listStyle23.Append(level3ParagraphProperties7);
            listStyle23.Append(level4ParagraphProperties7);
            listStyle23.Append(level5ParagraphProperties7);
            listStyle23.Append(level6ParagraphProperties7);
            listStyle23.Append(level7ParagraphProperties7);
            listStyle23.Append(level8ParagraphProperties7);
            listStyle23.Append(level9ParagraphProperties7);

            A.Paragraph paragraph31 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties17 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run17 = new A.Run();
            A.RunProperties runProperties23 = new A.RunProperties(){ Language = "en-US" };
            A.Text text23 = new A.Text();
            text23.Text = "Click to edit Master text styles";

            run17.Append(runProperties23);
            run17.Append(text23);

            paragraph31.Append(paragraphProperties17);
            paragraph31.Append(run17);

            textBody18.Append(bodyProperties23);
            textBody18.Append(listStyle23);
            textBody18.Append(paragraph31);

            shape18.Append(nonVisualShapeProperties18);
            shape18.Append(shapeProperties40);
            shape18.Append(textBody18);

            Shape shape19 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties19 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties25 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Date Placeholder 3" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList20 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension20 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement22 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{D602A195-E2CF-492E-AE9C-101F02C3E78B}\" />");

            nonVisualDrawingPropertiesExtension20.Append(openXmlUnknownElement22);

            nonVisualDrawingPropertiesExtensionList20.Append(nonVisualDrawingPropertiesExtension20);

            nonVisualDrawingProperties25.Append(nonVisualDrawingPropertiesExtensionList20);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties19 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks19 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties19.Append(shapeLocks19);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties25 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape19 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties25.Append(placeholderShape19);

            nonVisualShapeProperties19.Append(nonVisualDrawingProperties25);
            nonVisualShapeProperties19.Append(nonVisualShapeDrawingProperties19);
            nonVisualShapeProperties19.Append(applicationNonVisualDrawingProperties25);
            ShapeProperties shapeProperties41 = new ShapeProperties();

            TextBody textBody19 = new TextBody();
            A.BodyProperties bodyProperties24 = new A.BodyProperties();
            A.ListStyle listStyle24 = new A.ListStyle();

            A.Paragraph paragraph32 = new A.Paragraph();

            A.Field field7 = new A.Field(){ Id = "{9BEF4A3D-57C8-4DC0-86D0-95A05287C467}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties24 = new A.RunProperties(){ Language = "en-US" };
            runProperties24.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text24 = new A.Text();
            text24.Text = "1/29/2020";

            field7.Append(runProperties24);
            field7.Append(text24);
            A.EndParagraphRunProperties endParagraphRunProperties15 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph32.Append(field7);
            paragraph32.Append(endParagraphRunProperties15);

            textBody19.Append(bodyProperties24);
            textBody19.Append(listStyle24);
            textBody19.Append(paragraph32);

            shape19.Append(nonVisualShapeProperties19);
            shape19.Append(shapeProperties41);
            shape19.Append(textBody19);

            Shape shape20 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties20 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties26 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Footer Placeholder 4" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList21 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension21 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement23 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{9B92D951-43EA-4340-A2DF-42F5133E4E4C}\" />");

            nonVisualDrawingPropertiesExtension21.Append(openXmlUnknownElement23);

            nonVisualDrawingPropertiesExtensionList21.Append(nonVisualDrawingPropertiesExtension21);

            nonVisualDrawingProperties26.Append(nonVisualDrawingPropertiesExtensionList21);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties20 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks20 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties20.Append(shapeLocks20);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties26 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape20 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties26.Append(placeholderShape20);

            nonVisualShapeProperties20.Append(nonVisualDrawingProperties26);
            nonVisualShapeProperties20.Append(nonVisualShapeDrawingProperties20);
            nonVisualShapeProperties20.Append(applicationNonVisualDrawingProperties26);
            ShapeProperties shapeProperties42 = new ShapeProperties();

            TextBody textBody20 = new TextBody();
            A.BodyProperties bodyProperties25 = new A.BodyProperties();
            A.ListStyle listStyle25 = new A.ListStyle();

            A.Paragraph paragraph33 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties16 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph33.Append(endParagraphRunProperties16);

            textBody20.Append(bodyProperties25);
            textBody20.Append(listStyle25);
            textBody20.Append(paragraph33);

            shape20.Append(nonVisualShapeProperties20);
            shape20.Append(shapeProperties42);
            shape20.Append(textBody20);

            Shape shape21 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties21 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties27 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Slide Number Placeholder 5" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList22 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension22 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement24 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{ACC6C732-E2CE-4D16-856C-225FA7C41DBA}\" />");

            nonVisualDrawingPropertiesExtension22.Append(openXmlUnknownElement24);

            nonVisualDrawingPropertiesExtensionList22.Append(nonVisualDrawingPropertiesExtension22);

            nonVisualDrawingProperties27.Append(nonVisualDrawingPropertiesExtensionList22);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties21 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks21 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties21.Append(shapeLocks21);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties27 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape21 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties27.Append(placeholderShape21);

            nonVisualShapeProperties21.Append(nonVisualDrawingProperties27);
            nonVisualShapeProperties21.Append(nonVisualShapeDrawingProperties21);
            nonVisualShapeProperties21.Append(applicationNonVisualDrawingProperties27);
            ShapeProperties shapeProperties43 = new ShapeProperties();

            TextBody textBody21 = new TextBody();
            A.BodyProperties bodyProperties26 = new A.BodyProperties();
            A.ListStyle listStyle26 = new A.ListStyle();

            A.Paragraph paragraph34 = new A.Paragraph();

            A.Field field8 = new A.Field(){ Id = "{1BF20D12-B4E9-4886-A78D-768EA8FF95DD}", Type = "slidenum" };

            A.RunProperties runProperties25 = new A.RunProperties(){ Language = "en-US" };
            runProperties25.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text25 = new A.Text();
            text25.Text = "‹#›";

            field8.Append(runProperties25);
            field8.Append(text25);
            A.EndParagraphRunProperties endParagraphRunProperties17 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph34.Append(field8);
            paragraph34.Append(endParagraphRunProperties17);

            textBody21.Append(bodyProperties26);
            textBody21.Append(listStyle26);
            textBody21.Append(paragraph34);

            shape21.Append(nonVisualShapeProperties21);
            shape21.Append(shapeProperties43);
            shape21.Append(textBody21);

            shapeTree5.Append(nonVisualGroupShapeProperties5);
            shapeTree5.Append(groupShapeProperties5);
            shapeTree5.Append(shape17);
            shapeTree5.Append(shape18);
            shapeTree5.Append(shape19);
            shapeTree5.Append(shape20);
            shapeTree5.Append(shape21);

            CommonSlideDataExtensionList commonSlideDataExtensionList5 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension5 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId5 = new P14.CreationId(){ Val = (UInt32Value)3157874084U };
            creationId5.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension5.Append(creationId5);

            commonSlideDataExtensionList5.Append(commonSlideDataExtension5);

            commonSlideData5.Append(shapeTree5);
            commonSlideData5.Append(commonSlideDataExtensionList5);

            ColorMapOverride colorMapOverride4 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping4 = new A.MasterColorMapping();

            colorMapOverride4.Append(masterColorMapping4);

            slideLayout3.Append(commonSlideData5);
            slideLayout3.Append(colorMapOverride4);

            slideLayoutPart3.SlideLayout = slideLayout3;
        }

        // Generates content of slideLayoutPart4.
        private void GenerateSlideLayoutPart4Content(SlideLayoutPart slideLayoutPart4)
        {
            SlideLayout slideLayout4 = new SlideLayout(){ Type = SlideLayoutValues.Blank, Preserve = true };
            slideLayout4.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout4.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout4.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData6 = new CommonSlideData(){ Name = "Blank" };

            ShapeTree shapeTree6 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties6 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties28 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties6 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties28 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties6.Append(nonVisualDrawingProperties28);
            nonVisualGroupShapeProperties6.Append(nonVisualGroupShapeDrawingProperties6);
            nonVisualGroupShapeProperties6.Append(applicationNonVisualDrawingProperties28);

            GroupShapeProperties groupShapeProperties6 = new GroupShapeProperties();

            A.TransformGroup transformGroup6 = new A.TransformGroup();
            A.Offset offset19 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents19 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset6 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents6 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup6.Append(offset19);
            transformGroup6.Append(extents19);
            transformGroup6.Append(childOffset6);
            transformGroup6.Append(childExtents6);

            groupShapeProperties6.Append(transformGroup6);

            Shape shape22 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties22 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties29 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Date Placeholder 1" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList23 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension23 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement25 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{F657ADBA-A04A-4276-9101-AF9AC73CED4D}\" />");

            nonVisualDrawingPropertiesExtension23.Append(openXmlUnknownElement25);

            nonVisualDrawingPropertiesExtensionList23.Append(nonVisualDrawingPropertiesExtension23);

            nonVisualDrawingProperties29.Append(nonVisualDrawingPropertiesExtensionList23);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties22 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks22 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties22.Append(shapeLocks22);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties29 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape22 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties29.Append(placeholderShape22);

            nonVisualShapeProperties22.Append(nonVisualDrawingProperties29);
            nonVisualShapeProperties22.Append(nonVisualShapeDrawingProperties22);
            nonVisualShapeProperties22.Append(applicationNonVisualDrawingProperties29);
            ShapeProperties shapeProperties44 = new ShapeProperties();

            TextBody textBody22 = new TextBody();
            A.BodyProperties bodyProperties27 = new A.BodyProperties();
            A.ListStyle listStyle27 = new A.ListStyle();

            A.Paragraph paragraph35 = new A.Paragraph();

            A.Field field9 = new A.Field(){ Id = "{9BEF4A3D-57C8-4DC0-86D0-95A05287C467}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties26 = new A.RunProperties(){ Language = "en-US" };
            runProperties26.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text26 = new A.Text();
            text26.Text = "1/29/2020";

            field9.Append(runProperties26);
            field9.Append(text26);
            A.EndParagraphRunProperties endParagraphRunProperties18 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph35.Append(field9);
            paragraph35.Append(endParagraphRunProperties18);

            textBody22.Append(bodyProperties27);
            textBody22.Append(listStyle27);
            textBody22.Append(paragraph35);

            shape22.Append(nonVisualShapeProperties22);
            shape22.Append(shapeProperties44);
            shape22.Append(textBody22);

            Shape shape23 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties23 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties30 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Footer Placeholder 2" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList24 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension24 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement26 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{4DC06C0B-4245-430F-81C2-C0826CB349E4}\" />");

            nonVisualDrawingPropertiesExtension24.Append(openXmlUnknownElement26);

            nonVisualDrawingPropertiesExtensionList24.Append(nonVisualDrawingPropertiesExtension24);

            nonVisualDrawingProperties30.Append(nonVisualDrawingPropertiesExtensionList24);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties23 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks23 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties23.Append(shapeLocks23);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties30 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape23 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties30.Append(placeholderShape23);

            nonVisualShapeProperties23.Append(nonVisualDrawingProperties30);
            nonVisualShapeProperties23.Append(nonVisualShapeDrawingProperties23);
            nonVisualShapeProperties23.Append(applicationNonVisualDrawingProperties30);
            ShapeProperties shapeProperties45 = new ShapeProperties();

            TextBody textBody23 = new TextBody();
            A.BodyProperties bodyProperties28 = new A.BodyProperties();
            A.ListStyle listStyle28 = new A.ListStyle();

            A.Paragraph paragraph36 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties19 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph36.Append(endParagraphRunProperties19);

            textBody23.Append(bodyProperties28);
            textBody23.Append(listStyle28);
            textBody23.Append(paragraph36);

            shape23.Append(nonVisualShapeProperties23);
            shape23.Append(shapeProperties45);
            shape23.Append(textBody23);

            Shape shape24 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties24 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties31 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Slide Number Placeholder 3" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList25 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension25 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement27 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{48D86CEF-D876-4011-ACF0-BAF797A89B03}\" />");

            nonVisualDrawingPropertiesExtension25.Append(openXmlUnknownElement27);

            nonVisualDrawingPropertiesExtensionList25.Append(nonVisualDrawingPropertiesExtension25);

            nonVisualDrawingProperties31.Append(nonVisualDrawingPropertiesExtensionList25);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties24 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks24 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties24.Append(shapeLocks24);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties31 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape24 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties31.Append(placeholderShape24);

            nonVisualShapeProperties24.Append(nonVisualDrawingProperties31);
            nonVisualShapeProperties24.Append(nonVisualShapeDrawingProperties24);
            nonVisualShapeProperties24.Append(applicationNonVisualDrawingProperties31);
            ShapeProperties shapeProperties46 = new ShapeProperties();

            TextBody textBody24 = new TextBody();
            A.BodyProperties bodyProperties29 = new A.BodyProperties();
            A.ListStyle listStyle29 = new A.ListStyle();

            A.Paragraph paragraph37 = new A.Paragraph();

            A.Field field10 = new A.Field(){ Id = "{1BF20D12-B4E9-4886-A78D-768EA8FF95DD}", Type = "slidenum" };

            A.RunProperties runProperties27 = new A.RunProperties(){ Language = "en-US" };
            runProperties27.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text27 = new A.Text();
            text27.Text = "‹#›";

            field10.Append(runProperties27);
            field10.Append(text27);
            A.EndParagraphRunProperties endParagraphRunProperties20 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph37.Append(field10);
            paragraph37.Append(endParagraphRunProperties20);

            textBody24.Append(bodyProperties29);
            textBody24.Append(listStyle29);
            textBody24.Append(paragraph37);

            shape24.Append(nonVisualShapeProperties24);
            shape24.Append(shapeProperties46);
            shape24.Append(textBody24);

            shapeTree6.Append(nonVisualGroupShapeProperties6);
            shapeTree6.Append(groupShapeProperties6);
            shapeTree6.Append(shape22);
            shapeTree6.Append(shape23);
            shapeTree6.Append(shape24);

            CommonSlideDataExtensionList commonSlideDataExtensionList6 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension6 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId6 = new P14.CreationId(){ Val = (UInt32Value)2840660232U };
            creationId6.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension6.Append(creationId6);

            commonSlideDataExtensionList6.Append(commonSlideDataExtension6);

            commonSlideData6.Append(shapeTree6);
            commonSlideData6.Append(commonSlideDataExtensionList6);

            ColorMapOverride colorMapOverride5 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping5 = new A.MasterColorMapping();

            colorMapOverride5.Append(masterColorMapping5);

            slideLayout4.Append(commonSlideData6);
            slideLayout4.Append(colorMapOverride5);

            slideLayoutPart4.SlideLayout = slideLayout4;
        }

        // Generates content of themePart1.
        private void GenerateThemePart1Content(ThemePart themePart1)
        {
            A.Theme theme1 = new A.Theme(){ Name = "Office Theme" };
            theme1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            A.ThemeElements themeElements1 = new A.ThemeElements();

            A.ColorScheme colorScheme1 = new A.ColorScheme(){ Name = "Office" };

            A.Dark1Color dark1Color1 = new A.Dark1Color();
            A.SystemColor systemColor1 = new A.SystemColor(){ Val = A.SystemColorValues.WindowText, LastColor = "000000" };

            dark1Color1.Append(systemColor1);

            A.Light1Color light1Color1 = new A.Light1Color();
            A.SystemColor systemColor2 = new A.SystemColor(){ Val = A.SystemColorValues.Window, LastColor = "FFFFFF" };

            light1Color1.Append(systemColor2);

            A.Dark2Color dark2Color1 = new A.Dark2Color();
            A.RgbColorModelHex rgbColorModelHex2 = new A.RgbColorModelHex(){ Val = "44546A" };

            dark2Color1.Append(rgbColorModelHex2);

            A.Light2Color light2Color1 = new A.Light2Color();
            A.RgbColorModelHex rgbColorModelHex3 = new A.RgbColorModelHex(){ Val = "E7E6E6" };

            light2Color1.Append(rgbColorModelHex3);

            A.Accent1Color accent1Color1 = new A.Accent1Color();
            A.RgbColorModelHex rgbColorModelHex4 = new A.RgbColorModelHex(){ Val = "4472C4" };

            accent1Color1.Append(rgbColorModelHex4);

            A.Accent2Color accent2Color1 = new A.Accent2Color();
            A.RgbColorModelHex rgbColorModelHex5 = new A.RgbColorModelHex(){ Val = "ED7D31" };

            accent2Color1.Append(rgbColorModelHex5);

            A.Accent3Color accent3Color1 = new A.Accent3Color();
            A.RgbColorModelHex rgbColorModelHex6 = new A.RgbColorModelHex(){ Val = "A5A5A5" };

            accent3Color1.Append(rgbColorModelHex6);

            A.Accent4Color accent4Color1 = new A.Accent4Color();
            A.RgbColorModelHex rgbColorModelHex7 = new A.RgbColorModelHex(){ Val = "FFC000" };

            accent4Color1.Append(rgbColorModelHex7);

            A.Accent5Color accent5Color1 = new A.Accent5Color();
            A.RgbColorModelHex rgbColorModelHex8 = new A.RgbColorModelHex(){ Val = "5B9BD5" };

            accent5Color1.Append(rgbColorModelHex8);

            A.Accent6Color accent6Color1 = new A.Accent6Color();
            A.RgbColorModelHex rgbColorModelHex9 = new A.RgbColorModelHex(){ Val = "70AD47" };

            accent6Color1.Append(rgbColorModelHex9);

            A.Hyperlink hyperlink1 = new A.Hyperlink();
            A.RgbColorModelHex rgbColorModelHex10 = new A.RgbColorModelHex(){ Val = "0563C1" };

            hyperlink1.Append(rgbColorModelHex10);

            A.FollowedHyperlinkColor followedHyperlinkColor1 = new A.FollowedHyperlinkColor();
            A.RgbColorModelHex rgbColorModelHex11 = new A.RgbColorModelHex(){ Val = "954F72" };

            followedHyperlinkColor1.Append(rgbColorModelHex11);

            colorScheme1.Append(dark1Color1);
            colorScheme1.Append(light1Color1);
            colorScheme1.Append(dark2Color1);
            colorScheme1.Append(light2Color1);
            colorScheme1.Append(accent1Color1);
            colorScheme1.Append(accent2Color1);
            colorScheme1.Append(accent3Color1);
            colorScheme1.Append(accent4Color1);
            colorScheme1.Append(accent5Color1);
            colorScheme1.Append(accent6Color1);
            colorScheme1.Append(hyperlink1);
            colorScheme1.Append(followedHyperlinkColor1);

            A.FontScheme fontScheme1 = new A.FontScheme(){ Name = "Office" };

            A.MajorFont majorFont1 = new A.MajorFont();
            A.LatinFont latinFont33 = new A.LatinFont(){ Typeface = "Calibri Light", Panose = "020F0302020204030204" };
            A.EastAsianFont eastAsianFont33 = new A.EastAsianFont(){ Typeface = "" };
            A.ComplexScriptFont complexScriptFont33 = new A.ComplexScriptFont(){ Typeface = "" };
            A.SupplementalFont supplementalFont1 = new A.SupplementalFont(){ Script = "Jpan", Typeface = "游ゴシック Light" };
            A.SupplementalFont supplementalFont2 = new A.SupplementalFont(){ Script = "Hang", Typeface = "맑은 고딕" };
            A.SupplementalFont supplementalFont3 = new A.SupplementalFont(){ Script = "Hans", Typeface = "等线 Light" };
            A.SupplementalFont supplementalFont4 = new A.SupplementalFont(){ Script = "Hant", Typeface = "新細明體" };
            A.SupplementalFont supplementalFont5 = new A.SupplementalFont(){ Script = "Arab", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont6 = new A.SupplementalFont(){ Script = "Hebr", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont7 = new A.SupplementalFont(){ Script = "Thai", Typeface = "Angsana New" };
            A.SupplementalFont supplementalFont8 = new A.SupplementalFont(){ Script = "Ethi", Typeface = "Nyala" };
            A.SupplementalFont supplementalFont9 = new A.SupplementalFont(){ Script = "Beng", Typeface = "Vrinda" };
            A.SupplementalFont supplementalFont10 = new A.SupplementalFont(){ Script = "Gujr", Typeface = "Shruti" };
            A.SupplementalFont supplementalFont11 = new A.SupplementalFont(){ Script = "Khmr", Typeface = "MoolBoran" };
            A.SupplementalFont supplementalFont12 = new A.SupplementalFont(){ Script = "Knda", Typeface = "Tunga" };
            A.SupplementalFont supplementalFont13 = new A.SupplementalFont(){ Script = "Guru", Typeface = "Raavi" };
            A.SupplementalFont supplementalFont14 = new A.SupplementalFont(){ Script = "Cans", Typeface = "Euphemia" };
            A.SupplementalFont supplementalFont15 = new A.SupplementalFont(){ Script = "Cher", Typeface = "Plantagenet Cherokee" };
            A.SupplementalFont supplementalFont16 = new A.SupplementalFont(){ Script = "Yiii", Typeface = "Microsoft Yi Baiti" };
            A.SupplementalFont supplementalFont17 = new A.SupplementalFont(){ Script = "Tibt", Typeface = "Microsoft Himalaya" };
            A.SupplementalFont supplementalFont18 = new A.SupplementalFont(){ Script = "Thaa", Typeface = "MV Boli" };
            A.SupplementalFont supplementalFont19 = new A.SupplementalFont(){ Script = "Deva", Typeface = "Mangal" };
            A.SupplementalFont supplementalFont20 = new A.SupplementalFont(){ Script = "Telu", Typeface = "Gautami" };
            A.SupplementalFont supplementalFont21 = new A.SupplementalFont(){ Script = "Taml", Typeface = "Latha" };
            A.SupplementalFont supplementalFont22 = new A.SupplementalFont(){ Script = "Syrc", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont23 = new A.SupplementalFont(){ Script = "Orya", Typeface = "Kalinga" };
            A.SupplementalFont supplementalFont24 = new A.SupplementalFont(){ Script = "Mlym", Typeface = "Kartika" };
            A.SupplementalFont supplementalFont25 = new A.SupplementalFont(){ Script = "Laoo", Typeface = "DokChampa" };
            A.SupplementalFont supplementalFont26 = new A.SupplementalFont(){ Script = "Sinh", Typeface = "Iskoola Pota" };
            A.SupplementalFont supplementalFont27 = new A.SupplementalFont(){ Script = "Mong", Typeface = "Mongolian Baiti" };
            A.SupplementalFont supplementalFont28 = new A.SupplementalFont(){ Script = "Viet", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont29 = new A.SupplementalFont(){ Script = "Uigh", Typeface = "Microsoft Uighur" };
            A.SupplementalFont supplementalFont30 = new A.SupplementalFont(){ Script = "Geor", Typeface = "Sylfaen" };
            A.SupplementalFont supplementalFont31 = new A.SupplementalFont(){ Script = "Armn", Typeface = "Arial" };
            A.SupplementalFont supplementalFont32 = new A.SupplementalFont(){ Script = "Bugi", Typeface = "Leelawadee UI" };
            A.SupplementalFont supplementalFont33 = new A.SupplementalFont(){ Script = "Bopo", Typeface = "Microsoft JhengHei" };
            A.SupplementalFont supplementalFont34 = new A.SupplementalFont(){ Script = "Java", Typeface = "Javanese Text" };
            A.SupplementalFont supplementalFont35 = new A.SupplementalFont(){ Script = "Lisu", Typeface = "Segoe UI" };
            A.SupplementalFont supplementalFont36 = new A.SupplementalFont(){ Script = "Mymr", Typeface = "Myanmar Text" };
            A.SupplementalFont supplementalFont37 = new A.SupplementalFont(){ Script = "Nkoo", Typeface = "Ebrima" };
            A.SupplementalFont supplementalFont38 = new A.SupplementalFont(){ Script = "Olck", Typeface = "Nirmala UI" };
            A.SupplementalFont supplementalFont39 = new A.SupplementalFont(){ Script = "Osma", Typeface = "Ebrima" };
            A.SupplementalFont supplementalFont40 = new A.SupplementalFont(){ Script = "Phag", Typeface = "Phagspa" };
            A.SupplementalFont supplementalFont41 = new A.SupplementalFont(){ Script = "Syrn", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont42 = new A.SupplementalFont(){ Script = "Syrj", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont43 = new A.SupplementalFont(){ Script = "Syre", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont44 = new A.SupplementalFont(){ Script = "Sora", Typeface = "Nirmala UI" };
            A.SupplementalFont supplementalFont45 = new A.SupplementalFont(){ Script = "Tale", Typeface = "Microsoft Tai Le" };
            A.SupplementalFont supplementalFont46 = new A.SupplementalFont(){ Script = "Talu", Typeface = "Microsoft New Tai Lue" };
            A.SupplementalFont supplementalFont47 = new A.SupplementalFont(){ Script = "Tfng", Typeface = "Ebrima" };

            majorFont1.Append(latinFont33);
            majorFont1.Append(eastAsianFont33);
            majorFont1.Append(complexScriptFont33);
            majorFont1.Append(supplementalFont1);
            majorFont1.Append(supplementalFont2);
            majorFont1.Append(supplementalFont3);
            majorFont1.Append(supplementalFont4);
            majorFont1.Append(supplementalFont5);
            majorFont1.Append(supplementalFont6);
            majorFont1.Append(supplementalFont7);
            majorFont1.Append(supplementalFont8);
            majorFont1.Append(supplementalFont9);
            majorFont1.Append(supplementalFont10);
            majorFont1.Append(supplementalFont11);
            majorFont1.Append(supplementalFont12);
            majorFont1.Append(supplementalFont13);
            majorFont1.Append(supplementalFont14);
            majorFont1.Append(supplementalFont15);
            majorFont1.Append(supplementalFont16);
            majorFont1.Append(supplementalFont17);
            majorFont1.Append(supplementalFont18);
            majorFont1.Append(supplementalFont19);
            majorFont1.Append(supplementalFont20);
            majorFont1.Append(supplementalFont21);
            majorFont1.Append(supplementalFont22);
            majorFont1.Append(supplementalFont23);
            majorFont1.Append(supplementalFont24);
            majorFont1.Append(supplementalFont25);
            majorFont1.Append(supplementalFont26);
            majorFont1.Append(supplementalFont27);
            majorFont1.Append(supplementalFont28);
            majorFont1.Append(supplementalFont29);
            majorFont1.Append(supplementalFont30);
            majorFont1.Append(supplementalFont31);
            majorFont1.Append(supplementalFont32);
            majorFont1.Append(supplementalFont33);
            majorFont1.Append(supplementalFont34);
            majorFont1.Append(supplementalFont35);
            majorFont1.Append(supplementalFont36);
            majorFont1.Append(supplementalFont37);
            majorFont1.Append(supplementalFont38);
            majorFont1.Append(supplementalFont39);
            majorFont1.Append(supplementalFont40);
            majorFont1.Append(supplementalFont41);
            majorFont1.Append(supplementalFont42);
            majorFont1.Append(supplementalFont43);
            majorFont1.Append(supplementalFont44);
            majorFont1.Append(supplementalFont45);
            majorFont1.Append(supplementalFont46);
            majorFont1.Append(supplementalFont47);

            A.MinorFont minorFont1 = new A.MinorFont();
            A.LatinFont latinFont34 = new A.LatinFont(){ Typeface = "Calibri", Panose = "020F0502020204030204" };
            A.EastAsianFont eastAsianFont34 = new A.EastAsianFont(){ Typeface = "" };
            A.ComplexScriptFont complexScriptFont34 = new A.ComplexScriptFont(){ Typeface = "" };
            A.SupplementalFont supplementalFont48 = new A.SupplementalFont(){ Script = "Jpan", Typeface = "游ゴシック" };
            A.SupplementalFont supplementalFont49 = new A.SupplementalFont(){ Script = "Hang", Typeface = "맑은 고딕" };
            A.SupplementalFont supplementalFont50 = new A.SupplementalFont(){ Script = "Hans", Typeface = "等线" };
            A.SupplementalFont supplementalFont51 = new A.SupplementalFont(){ Script = "Hant", Typeface = "新細明體" };
            A.SupplementalFont supplementalFont52 = new A.SupplementalFont(){ Script = "Arab", Typeface = "Arial" };
            A.SupplementalFont supplementalFont53 = new A.SupplementalFont(){ Script = "Hebr", Typeface = "Arial" };
            A.SupplementalFont supplementalFont54 = new A.SupplementalFont(){ Script = "Thai", Typeface = "Cordia New" };
            A.SupplementalFont supplementalFont55 = new A.SupplementalFont(){ Script = "Ethi", Typeface = "Nyala" };
            A.SupplementalFont supplementalFont56 = new A.SupplementalFont(){ Script = "Beng", Typeface = "Vrinda" };
            A.SupplementalFont supplementalFont57 = new A.SupplementalFont(){ Script = "Gujr", Typeface = "Shruti" };
            A.SupplementalFont supplementalFont58 = new A.SupplementalFont(){ Script = "Khmr", Typeface = "DaunPenh" };
            A.SupplementalFont supplementalFont59 = new A.SupplementalFont(){ Script = "Knda", Typeface = "Tunga" };
            A.SupplementalFont supplementalFont60 = new A.SupplementalFont(){ Script = "Guru", Typeface = "Raavi" };
            A.SupplementalFont supplementalFont61 = new A.SupplementalFont(){ Script = "Cans", Typeface = "Euphemia" };
            A.SupplementalFont supplementalFont62 = new A.SupplementalFont(){ Script = "Cher", Typeface = "Plantagenet Cherokee" };
            A.SupplementalFont supplementalFont63 = new A.SupplementalFont(){ Script = "Yiii", Typeface = "Microsoft Yi Baiti" };
            A.SupplementalFont supplementalFont64 = new A.SupplementalFont(){ Script = "Tibt", Typeface = "Microsoft Himalaya" };
            A.SupplementalFont supplementalFont65 = new A.SupplementalFont(){ Script = "Thaa", Typeface = "MV Boli" };
            A.SupplementalFont supplementalFont66 = new A.SupplementalFont(){ Script = "Deva", Typeface = "Mangal" };
            A.SupplementalFont supplementalFont67 = new A.SupplementalFont(){ Script = "Telu", Typeface = "Gautami" };
            A.SupplementalFont supplementalFont68 = new A.SupplementalFont(){ Script = "Taml", Typeface = "Latha" };
            A.SupplementalFont supplementalFont69 = new A.SupplementalFont(){ Script = "Syrc", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont70 = new A.SupplementalFont(){ Script = "Orya", Typeface = "Kalinga" };
            A.SupplementalFont supplementalFont71 = new A.SupplementalFont(){ Script = "Mlym", Typeface = "Kartika" };
            A.SupplementalFont supplementalFont72 = new A.SupplementalFont(){ Script = "Laoo", Typeface = "DokChampa" };
            A.SupplementalFont supplementalFont73 = new A.SupplementalFont(){ Script = "Sinh", Typeface = "Iskoola Pota" };
            A.SupplementalFont supplementalFont74 = new A.SupplementalFont(){ Script = "Mong", Typeface = "Mongolian Baiti" };
            A.SupplementalFont supplementalFont75 = new A.SupplementalFont(){ Script = "Viet", Typeface = "Arial" };
            A.SupplementalFont supplementalFont76 = new A.SupplementalFont(){ Script = "Uigh", Typeface = "Microsoft Uighur" };
            A.SupplementalFont supplementalFont77 = new A.SupplementalFont(){ Script = "Geor", Typeface = "Sylfaen" };
            A.SupplementalFont supplementalFont78 = new A.SupplementalFont(){ Script = "Armn", Typeface = "Arial" };
            A.SupplementalFont supplementalFont79 = new A.SupplementalFont(){ Script = "Bugi", Typeface = "Leelawadee UI" };
            A.SupplementalFont supplementalFont80 = new A.SupplementalFont(){ Script = "Bopo", Typeface = "Microsoft JhengHei" };
            A.SupplementalFont supplementalFont81 = new A.SupplementalFont(){ Script = "Java", Typeface = "Javanese Text" };
            A.SupplementalFont supplementalFont82 = new A.SupplementalFont(){ Script = "Lisu", Typeface = "Segoe UI" };
            A.SupplementalFont supplementalFont83 = new A.SupplementalFont(){ Script = "Mymr", Typeface = "Myanmar Text" };
            A.SupplementalFont supplementalFont84 = new A.SupplementalFont(){ Script = "Nkoo", Typeface = "Ebrima" };
            A.SupplementalFont supplementalFont85 = new A.SupplementalFont(){ Script = "Olck", Typeface = "Nirmala UI" };
            A.SupplementalFont supplementalFont86 = new A.SupplementalFont(){ Script = "Osma", Typeface = "Ebrima" };
            A.SupplementalFont supplementalFont87 = new A.SupplementalFont(){ Script = "Phag", Typeface = "Phagspa" };
            A.SupplementalFont supplementalFont88 = new A.SupplementalFont(){ Script = "Syrn", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont89 = new A.SupplementalFont(){ Script = "Syrj", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont90 = new A.SupplementalFont(){ Script = "Syre", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont91 = new A.SupplementalFont(){ Script = "Sora", Typeface = "Nirmala UI" };
            A.SupplementalFont supplementalFont92 = new A.SupplementalFont(){ Script = "Tale", Typeface = "Microsoft Tai Le" };
            A.SupplementalFont supplementalFont93 = new A.SupplementalFont(){ Script = "Talu", Typeface = "Microsoft New Tai Lue" };
            A.SupplementalFont supplementalFont94 = new A.SupplementalFont(){ Script = "Tfng", Typeface = "Ebrima" };

            minorFont1.Append(latinFont34);
            minorFont1.Append(eastAsianFont34);
            minorFont1.Append(complexScriptFont34);
            minorFont1.Append(supplementalFont48);
            minorFont1.Append(supplementalFont49);
            minorFont1.Append(supplementalFont50);
            minorFont1.Append(supplementalFont51);
            minorFont1.Append(supplementalFont52);
            minorFont1.Append(supplementalFont53);
            minorFont1.Append(supplementalFont54);
            minorFont1.Append(supplementalFont55);
            minorFont1.Append(supplementalFont56);
            minorFont1.Append(supplementalFont57);
            minorFont1.Append(supplementalFont58);
            minorFont1.Append(supplementalFont59);
            minorFont1.Append(supplementalFont60);
            minorFont1.Append(supplementalFont61);
            minorFont1.Append(supplementalFont62);
            minorFont1.Append(supplementalFont63);
            minorFont1.Append(supplementalFont64);
            minorFont1.Append(supplementalFont65);
            minorFont1.Append(supplementalFont66);
            minorFont1.Append(supplementalFont67);
            minorFont1.Append(supplementalFont68);
            minorFont1.Append(supplementalFont69);
            minorFont1.Append(supplementalFont70);
            minorFont1.Append(supplementalFont71);
            minorFont1.Append(supplementalFont72);
            minorFont1.Append(supplementalFont73);
            minorFont1.Append(supplementalFont74);
            minorFont1.Append(supplementalFont75);
            minorFont1.Append(supplementalFont76);
            minorFont1.Append(supplementalFont77);
            minorFont1.Append(supplementalFont78);
            minorFont1.Append(supplementalFont79);
            minorFont1.Append(supplementalFont80);
            minorFont1.Append(supplementalFont81);
            minorFont1.Append(supplementalFont82);
            minorFont1.Append(supplementalFont83);
            minorFont1.Append(supplementalFont84);
            minorFont1.Append(supplementalFont85);
            minorFont1.Append(supplementalFont86);
            minorFont1.Append(supplementalFont87);
            minorFont1.Append(supplementalFont88);
            minorFont1.Append(supplementalFont89);
            minorFont1.Append(supplementalFont90);
            minorFont1.Append(supplementalFont91);
            minorFont1.Append(supplementalFont92);
            minorFont1.Append(supplementalFont93);
            minorFont1.Append(supplementalFont94);

            fontScheme1.Append(majorFont1);
            fontScheme1.Append(minorFont1);

            A.FormatScheme formatScheme1 = new A.FormatScheme(){ Name = "Office" };

            A.FillStyleList fillStyleList1 = new A.FillStyleList();

            A.SolidFill solidFill76 = new A.SolidFill();
            A.SchemeColor schemeColor112 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill76.Append(schemeColor112);

            A.GradientFill gradientFill1 = new A.GradientFill(){ RotateWithShape = true };

            A.GradientStopList gradientStopList1 = new A.GradientStopList();

            A.GradientStop gradientStop1 = new A.GradientStop(){ Position = 0 };

            A.SchemeColor schemeColor113 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.LuminanceModulation luminanceModulation38 = new A.LuminanceModulation(){ Val = 110000 };
            A.SaturationModulation saturationModulation1 = new A.SaturationModulation(){ Val = 105000 };
            A.Tint tint13 = new A.Tint(){ Val = 67000 };

            schemeColor113.Append(luminanceModulation38);
            schemeColor113.Append(saturationModulation1);
            schemeColor113.Append(tint13);

            gradientStop1.Append(schemeColor113);

            A.GradientStop gradientStop2 = new A.GradientStop(){ Position = 50000 };

            A.SchemeColor schemeColor114 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.LuminanceModulation luminanceModulation39 = new A.LuminanceModulation(){ Val = 105000 };
            A.SaturationModulation saturationModulation2 = new A.SaturationModulation(){ Val = 103000 };
            A.Tint tint14 = new A.Tint(){ Val = 73000 };

            schemeColor114.Append(luminanceModulation39);
            schemeColor114.Append(saturationModulation2);
            schemeColor114.Append(tint14);

            gradientStop2.Append(schemeColor114);

            A.GradientStop gradientStop3 = new A.GradientStop(){ Position = 100000 };

            A.SchemeColor schemeColor115 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.LuminanceModulation luminanceModulation40 = new A.LuminanceModulation(){ Val = 105000 };
            A.SaturationModulation saturationModulation3 = new A.SaturationModulation(){ Val = 109000 };
            A.Tint tint15 = new A.Tint(){ Val = 81000 };

            schemeColor115.Append(luminanceModulation40);
            schemeColor115.Append(saturationModulation3);
            schemeColor115.Append(tint15);

            gradientStop3.Append(schemeColor115);

            gradientStopList1.Append(gradientStop1);
            gradientStopList1.Append(gradientStop2);
            gradientStopList1.Append(gradientStop3);
            A.LinearGradientFill linearGradientFill1 = new A.LinearGradientFill(){ Angle = 5400000, Scaled = false };

            gradientFill1.Append(gradientStopList1);
            gradientFill1.Append(linearGradientFill1);

            A.GradientFill gradientFill2 = new A.GradientFill(){ RotateWithShape = true };

            A.GradientStopList gradientStopList2 = new A.GradientStopList();

            A.GradientStop gradientStop4 = new A.GradientStop(){ Position = 0 };

            A.SchemeColor schemeColor116 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.SaturationModulation saturationModulation4 = new A.SaturationModulation(){ Val = 103000 };
            A.LuminanceModulation luminanceModulation41 = new A.LuminanceModulation(){ Val = 102000 };
            A.Tint tint16 = new A.Tint(){ Val = 94000 };

            schemeColor116.Append(saturationModulation4);
            schemeColor116.Append(luminanceModulation41);
            schemeColor116.Append(tint16);

            gradientStop4.Append(schemeColor116);

            A.GradientStop gradientStop5 = new A.GradientStop(){ Position = 50000 };

            A.SchemeColor schemeColor117 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.SaturationModulation saturationModulation5 = new A.SaturationModulation(){ Val = 110000 };
            A.LuminanceModulation luminanceModulation42 = new A.LuminanceModulation(){ Val = 100000 };
            A.Shade shade1 = new A.Shade(){ Val = 100000 };

            schemeColor117.Append(saturationModulation5);
            schemeColor117.Append(luminanceModulation42);
            schemeColor117.Append(shade1);

            gradientStop5.Append(schemeColor117);

            A.GradientStop gradientStop6 = new A.GradientStop(){ Position = 100000 };

            A.SchemeColor schemeColor118 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.LuminanceModulation luminanceModulation43 = new A.LuminanceModulation(){ Val = 99000 };
            A.SaturationModulation saturationModulation6 = new A.SaturationModulation(){ Val = 120000 };
            A.Shade shade2 = new A.Shade(){ Val = 78000 };

            schemeColor118.Append(luminanceModulation43);
            schemeColor118.Append(saturationModulation6);
            schemeColor118.Append(shade2);

            gradientStop6.Append(schemeColor118);

            gradientStopList2.Append(gradientStop4);
            gradientStopList2.Append(gradientStop5);
            gradientStopList2.Append(gradientStop6);
            A.LinearGradientFill linearGradientFill2 = new A.LinearGradientFill(){ Angle = 5400000, Scaled = false };

            gradientFill2.Append(gradientStopList2);
            gradientFill2.Append(linearGradientFill2);

            fillStyleList1.Append(solidFill76);
            fillStyleList1.Append(gradientFill1);
            fillStyleList1.Append(gradientFill2);

            A.LineStyleList lineStyleList1 = new A.LineStyleList();

            A.Outline outline29 = new A.Outline(){ Width = 6350, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill77 = new A.SolidFill();
            A.SchemeColor schemeColor119 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill77.Append(schemeColor119);
            A.PresetDash presetDash2 = new A.PresetDash(){ Val = A.PresetLineDashValues.Solid };
            A.Miter miter1 = new A.Miter(){ Limit = 800000 };

            outline29.Append(solidFill77);
            outline29.Append(presetDash2);
            outline29.Append(miter1);

            A.Outline outline30 = new A.Outline(){ Width = 12700, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill78 = new A.SolidFill();
            A.SchemeColor schemeColor120 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill78.Append(schemeColor120);
            A.PresetDash presetDash3 = new A.PresetDash(){ Val = A.PresetLineDashValues.Solid };
            A.Miter miter2 = new A.Miter(){ Limit = 800000 };

            outline30.Append(solidFill78);
            outline30.Append(presetDash3);
            outline30.Append(miter2);

            A.Outline outline31 = new A.Outline(){ Width = 19050, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill79 = new A.SolidFill();
            A.SchemeColor schemeColor121 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill79.Append(schemeColor121);
            A.PresetDash presetDash4 = new A.PresetDash(){ Val = A.PresetLineDashValues.Solid };
            A.Miter miter3 = new A.Miter(){ Limit = 800000 };

            outline31.Append(solidFill79);
            outline31.Append(presetDash4);
            outline31.Append(miter3);

            lineStyleList1.Append(outline29);
            lineStyleList1.Append(outline30);
            lineStyleList1.Append(outline31);

            A.EffectStyleList effectStyleList1 = new A.EffectStyleList();

            A.EffectStyle effectStyle1 = new A.EffectStyle();
            A.EffectList effectList10 = new A.EffectList();

            effectStyle1.Append(effectList10);

            A.EffectStyle effectStyle2 = new A.EffectStyle();
            A.EffectList effectList11 = new A.EffectList();

            effectStyle2.Append(effectList11);

            A.EffectStyle effectStyle3 = new A.EffectStyle();

            A.EffectList effectList12 = new A.EffectList();

            A.OuterShadow outerShadow1 = new A.OuterShadow(){ BlurRadius = 57150L, Distance = 19050L, Direction = 5400000, Alignment = A.RectangleAlignmentValues.Center, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex12 = new A.RgbColorModelHex(){ Val = "000000" };
            A.Alpha alpha1 = new A.Alpha(){ Val = 63000 };

            rgbColorModelHex12.Append(alpha1);

            outerShadow1.Append(rgbColorModelHex12);

            effectList12.Append(outerShadow1);

            effectStyle3.Append(effectList12);

            effectStyleList1.Append(effectStyle1);
            effectStyleList1.Append(effectStyle2);
            effectStyleList1.Append(effectStyle3);

            A.BackgroundFillStyleList backgroundFillStyleList1 = new A.BackgroundFillStyleList();

            A.SolidFill solidFill80 = new A.SolidFill();
            A.SchemeColor schemeColor122 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill80.Append(schemeColor122);

            A.SolidFill solidFill81 = new A.SolidFill();

            A.SchemeColor schemeColor123 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint17 = new A.Tint(){ Val = 95000 };
            A.SaturationModulation saturationModulation7 = new A.SaturationModulation(){ Val = 170000 };

            schemeColor123.Append(tint17);
            schemeColor123.Append(saturationModulation7);

            solidFill81.Append(schemeColor123);

            A.GradientFill gradientFill3 = new A.GradientFill(){ RotateWithShape = true };

            A.GradientStopList gradientStopList3 = new A.GradientStopList();

            A.GradientStop gradientStop7 = new A.GradientStop(){ Position = 0 };

            A.SchemeColor schemeColor124 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint18 = new A.Tint(){ Val = 93000 };
            A.SaturationModulation saturationModulation8 = new A.SaturationModulation(){ Val = 150000 };
            A.Shade shade3 = new A.Shade(){ Val = 98000 };
            A.LuminanceModulation luminanceModulation44 = new A.LuminanceModulation(){ Val = 102000 };

            schemeColor124.Append(tint18);
            schemeColor124.Append(saturationModulation8);
            schemeColor124.Append(shade3);
            schemeColor124.Append(luminanceModulation44);

            gradientStop7.Append(schemeColor124);

            A.GradientStop gradientStop8 = new A.GradientStop(){ Position = 50000 };

            A.SchemeColor schemeColor125 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint19 = new A.Tint(){ Val = 98000 };
            A.SaturationModulation saturationModulation9 = new A.SaturationModulation(){ Val = 130000 };
            A.Shade shade4 = new A.Shade(){ Val = 90000 };
            A.LuminanceModulation luminanceModulation45 = new A.LuminanceModulation(){ Val = 103000 };

            schemeColor125.Append(tint19);
            schemeColor125.Append(saturationModulation9);
            schemeColor125.Append(shade4);
            schemeColor125.Append(luminanceModulation45);

            gradientStop8.Append(schemeColor125);

            A.GradientStop gradientStop9 = new A.GradientStop(){ Position = 100000 };

            A.SchemeColor schemeColor126 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Shade shade5 = new A.Shade(){ Val = 63000 };
            A.SaturationModulation saturationModulation10 = new A.SaturationModulation(){ Val = 120000 };

            schemeColor126.Append(shade5);
            schemeColor126.Append(saturationModulation10);

            gradientStop9.Append(schemeColor126);

            gradientStopList3.Append(gradientStop7);
            gradientStopList3.Append(gradientStop8);
            gradientStopList3.Append(gradientStop9);
            A.LinearGradientFill linearGradientFill3 = new A.LinearGradientFill(){ Angle = 5400000, Scaled = false };

            gradientFill3.Append(gradientStopList3);
            gradientFill3.Append(linearGradientFill3);

            backgroundFillStyleList1.Append(solidFill80);
            backgroundFillStyleList1.Append(solidFill81);
            backgroundFillStyleList1.Append(gradientFill3);

            formatScheme1.Append(fillStyleList1);
            formatScheme1.Append(lineStyleList1);
            formatScheme1.Append(effectStyleList1);
            formatScheme1.Append(backgroundFillStyleList1);

            themeElements1.Append(colorScheme1);
            themeElements1.Append(fontScheme1);
            themeElements1.Append(formatScheme1);
            A.ObjectDefaults objectDefaults1 = new A.ObjectDefaults();
            A.ExtraColorSchemeList extraColorSchemeList1 = new A.ExtraColorSchemeList();

            A.OfficeStyleSheetExtensionList officeStyleSheetExtensionList1 = new A.OfficeStyleSheetExtensionList();

            A.OfficeStyleSheetExtension officeStyleSheetExtension1 = new A.OfficeStyleSheetExtension(){ Uri = "{05A4C25C-085E-4340-85A3-A5531E510DB2}" };

            Thm15.ThemeFamily themeFamily1 = new Thm15.ThemeFamily(){ Name = "Office Theme", Id = "{62F939B6-93AF-4DB8-9C6B-D6C7DFDC589F}", Vid = "{4A3C46E8-61CC-4603-A589-7422A47A8E4A}" };
            themeFamily1.AddNamespaceDeclaration("thm15", "http://schemas.microsoft.com/office/thememl/2012/main");

            officeStyleSheetExtension1.Append(themeFamily1);

            officeStyleSheetExtensionList1.Append(officeStyleSheetExtension1);

            theme1.Append(themeElements1);
            theme1.Append(objectDefaults1);
            theme1.Append(extraColorSchemeList1);
            theme1.Append(officeStyleSheetExtensionList1);

            themePart1.Theme = theme1;
        }

        // Generates content of slideLayoutPart5.
        private void GenerateSlideLayoutPart5Content(SlideLayoutPart slideLayoutPart5)
        {
            SlideLayout slideLayout5 = new SlideLayout(){ Type = SlideLayoutValues.Object, Preserve = true };
            slideLayout5.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout5.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout5.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData7 = new CommonSlideData(){ Name = "Title and Content" };

            ShapeTree shapeTree7 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties7 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties32 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties7 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties32 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties7.Append(nonVisualDrawingProperties32);
            nonVisualGroupShapeProperties7.Append(nonVisualGroupShapeDrawingProperties7);
            nonVisualGroupShapeProperties7.Append(applicationNonVisualDrawingProperties32);

            GroupShapeProperties groupShapeProperties7 = new GroupShapeProperties();

            A.TransformGroup transformGroup7 = new A.TransformGroup();
            A.Offset offset20 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents20 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset7 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents7 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup7.Append(offset20);
            transformGroup7.Append(extents20);
            transformGroup7.Append(childOffset7);
            transformGroup7.Append(childExtents7);

            groupShapeProperties7.Append(transformGroup7);

            Shape shape25 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties25 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties33 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList26 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension26 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement28 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{9CD92466-A55D-4565-BBE9-33D174829F6B}\" />");

            nonVisualDrawingPropertiesExtension26.Append(openXmlUnknownElement28);

            nonVisualDrawingPropertiesExtensionList26.Append(nonVisualDrawingPropertiesExtension26);

            nonVisualDrawingProperties33.Append(nonVisualDrawingPropertiesExtensionList26);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties25 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks25 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties25.Append(shapeLocks25);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties33 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape25 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties33.Append(placeholderShape25);

            nonVisualShapeProperties25.Append(nonVisualDrawingProperties33);
            nonVisualShapeProperties25.Append(nonVisualShapeDrawingProperties25);
            nonVisualShapeProperties25.Append(applicationNonVisualDrawingProperties33);
            ShapeProperties shapeProperties47 = new ShapeProperties();

            TextBody textBody25 = new TextBody();
            A.BodyProperties bodyProperties30 = new A.BodyProperties();
            A.ListStyle listStyle30 = new A.ListStyle();

            A.Paragraph paragraph38 = new A.Paragraph();

            A.Run run18 = new A.Run();
            A.RunProperties runProperties28 = new A.RunProperties(){ Language = "en-US" };
            A.Text text28 = new A.Text();
            text28.Text = "Click to edit Master title style";

            run18.Append(runProperties28);
            run18.Append(text28);

            paragraph38.Append(run18);

            textBody25.Append(bodyProperties30);
            textBody25.Append(listStyle30);
            textBody25.Append(paragraph38);

            shape25.Append(nonVisualShapeProperties25);
            shape25.Append(shapeProperties47);
            shape25.Append(textBody25);

            Shape shape26 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties26 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties34 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Content Placeholder 2" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList27 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension27 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement29 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{707FE0CC-FF3B-4A21-AB04-05A313B840CC}\" />");

            nonVisualDrawingPropertiesExtension27.Append(openXmlUnknownElement29);

            nonVisualDrawingPropertiesExtensionList27.Append(nonVisualDrawingPropertiesExtension27);

            nonVisualDrawingProperties34.Append(nonVisualDrawingPropertiesExtensionList27);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties26 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks26 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties26.Append(shapeLocks26);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties34 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape26 = new PlaceholderShape(){ Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties34.Append(placeholderShape26);

            nonVisualShapeProperties26.Append(nonVisualDrawingProperties34);
            nonVisualShapeProperties26.Append(nonVisualShapeDrawingProperties26);
            nonVisualShapeProperties26.Append(applicationNonVisualDrawingProperties34);
            ShapeProperties shapeProperties48 = new ShapeProperties();

            TextBody textBody26 = new TextBody();
            A.BodyProperties bodyProperties31 = new A.BodyProperties();
            A.ListStyle listStyle31 = new A.ListStyle();

            A.Paragraph paragraph39 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties18 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run19 = new A.Run();
            A.RunProperties runProperties29 = new A.RunProperties(){ Language = "en-US" };
            A.Text text29 = new A.Text();
            text29.Text = "Click to edit Master text styles";

            run19.Append(runProperties29);
            run19.Append(text29);

            paragraph39.Append(paragraphProperties18);
            paragraph39.Append(run19);

            A.Paragraph paragraph40 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties19 = new A.ParagraphProperties(){ Level = 1 };

            A.Run run20 = new A.Run();
            A.RunProperties runProperties30 = new A.RunProperties(){ Language = "en-US" };
            A.Text text30 = new A.Text();
            text30.Text = "Second level";

            run20.Append(runProperties30);
            run20.Append(text30);

            paragraph40.Append(paragraphProperties19);
            paragraph40.Append(run20);

            A.Paragraph paragraph41 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties20 = new A.ParagraphProperties(){ Level = 2 };

            A.Run run21 = new A.Run();
            A.RunProperties runProperties31 = new A.RunProperties(){ Language = "en-US" };
            A.Text text31 = new A.Text();
            text31.Text = "Third level";

            run21.Append(runProperties31);
            run21.Append(text31);

            paragraph41.Append(paragraphProperties20);
            paragraph41.Append(run21);

            A.Paragraph paragraph42 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties21 = new A.ParagraphProperties(){ Level = 3 };

            A.Run run22 = new A.Run();
            A.RunProperties runProperties32 = new A.RunProperties(){ Language = "en-US" };
            A.Text text32 = new A.Text();
            text32.Text = "Fourth level";

            run22.Append(runProperties32);
            run22.Append(text32);

            paragraph42.Append(paragraphProperties21);
            paragraph42.Append(run22);

            A.Paragraph paragraph43 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties22 = new A.ParagraphProperties(){ Level = 4 };

            A.Run run23 = new A.Run();
            A.RunProperties runProperties33 = new A.RunProperties(){ Language = "en-US" };
            A.Text text33 = new A.Text();
            text33.Text = "Fifth level";

            run23.Append(runProperties33);
            run23.Append(text33);

            paragraph43.Append(paragraphProperties22);
            paragraph43.Append(run23);

            textBody26.Append(bodyProperties31);
            textBody26.Append(listStyle31);
            textBody26.Append(paragraph39);
            textBody26.Append(paragraph40);
            textBody26.Append(paragraph41);
            textBody26.Append(paragraph42);
            textBody26.Append(paragraph43);

            shape26.Append(nonVisualShapeProperties26);
            shape26.Append(shapeProperties48);
            shape26.Append(textBody26);

            Shape shape27 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties27 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties35 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Date Placeholder 3" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList28 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension28 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement30 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{5C74EF9F-798F-4AD4-94A6-14948474CA97}\" />");

            nonVisualDrawingPropertiesExtension28.Append(openXmlUnknownElement30);

            nonVisualDrawingPropertiesExtensionList28.Append(nonVisualDrawingPropertiesExtension28);

            nonVisualDrawingProperties35.Append(nonVisualDrawingPropertiesExtensionList28);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties27 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks27 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties27.Append(shapeLocks27);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties35 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape27 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties35.Append(placeholderShape27);

            nonVisualShapeProperties27.Append(nonVisualDrawingProperties35);
            nonVisualShapeProperties27.Append(nonVisualShapeDrawingProperties27);
            nonVisualShapeProperties27.Append(applicationNonVisualDrawingProperties35);
            ShapeProperties shapeProperties49 = new ShapeProperties();

            TextBody textBody27 = new TextBody();
            A.BodyProperties bodyProperties32 = new A.BodyProperties();
            A.ListStyle listStyle32 = new A.ListStyle();

            A.Paragraph paragraph44 = new A.Paragraph();

            A.Field field11 = new A.Field(){ Id = "{9BEF4A3D-57C8-4DC0-86D0-95A05287C467}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties34 = new A.RunProperties(){ Language = "en-US" };
            runProperties34.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text34 = new A.Text();
            text34.Text = "1/29/2020";

            field11.Append(runProperties34);
            field11.Append(text34);
            A.EndParagraphRunProperties endParagraphRunProperties21 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph44.Append(field11);
            paragraph44.Append(endParagraphRunProperties21);

            textBody27.Append(bodyProperties32);
            textBody27.Append(listStyle32);
            textBody27.Append(paragraph44);

            shape27.Append(nonVisualShapeProperties27);
            shape27.Append(shapeProperties49);
            shape27.Append(textBody27);

            Shape shape28 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties28 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties36 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Footer Placeholder 4" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList29 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension29 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement31 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{69790088-52DF-46CD-9095-0ADCFAE06C78}\" />");

            nonVisualDrawingPropertiesExtension29.Append(openXmlUnknownElement31);

            nonVisualDrawingPropertiesExtensionList29.Append(nonVisualDrawingPropertiesExtension29);

            nonVisualDrawingProperties36.Append(nonVisualDrawingPropertiesExtensionList29);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties28 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks28 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties28.Append(shapeLocks28);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties36 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape28 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties36.Append(placeholderShape28);

            nonVisualShapeProperties28.Append(nonVisualDrawingProperties36);
            nonVisualShapeProperties28.Append(nonVisualShapeDrawingProperties28);
            nonVisualShapeProperties28.Append(applicationNonVisualDrawingProperties36);
            ShapeProperties shapeProperties50 = new ShapeProperties();

            TextBody textBody28 = new TextBody();
            A.BodyProperties bodyProperties33 = new A.BodyProperties();
            A.ListStyle listStyle33 = new A.ListStyle();

            A.Paragraph paragraph45 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties22 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph45.Append(endParagraphRunProperties22);

            textBody28.Append(bodyProperties33);
            textBody28.Append(listStyle33);
            textBody28.Append(paragraph45);

            shape28.Append(nonVisualShapeProperties28);
            shape28.Append(shapeProperties50);
            shape28.Append(textBody28);

            Shape shape29 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties29 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties37 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Slide Number Placeholder 5" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList30 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension30 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement32 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{73211790-AE77-4556-89C6-0BA4AC8FDB26}\" />");

            nonVisualDrawingPropertiesExtension30.Append(openXmlUnknownElement32);

            nonVisualDrawingPropertiesExtensionList30.Append(nonVisualDrawingPropertiesExtension30);

            nonVisualDrawingProperties37.Append(nonVisualDrawingPropertiesExtensionList30);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties29 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks29 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties29.Append(shapeLocks29);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties37 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape29 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties37.Append(placeholderShape29);

            nonVisualShapeProperties29.Append(nonVisualDrawingProperties37);
            nonVisualShapeProperties29.Append(nonVisualShapeDrawingProperties29);
            nonVisualShapeProperties29.Append(applicationNonVisualDrawingProperties37);
            ShapeProperties shapeProperties51 = new ShapeProperties();

            TextBody textBody29 = new TextBody();
            A.BodyProperties bodyProperties34 = new A.BodyProperties();
            A.ListStyle listStyle34 = new A.ListStyle();

            A.Paragraph paragraph46 = new A.Paragraph();

            A.Field field12 = new A.Field(){ Id = "{1BF20D12-B4E9-4886-A78D-768EA8FF95DD}", Type = "slidenum" };

            A.RunProperties runProperties35 = new A.RunProperties(){ Language = "en-US" };
            runProperties35.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text35 = new A.Text();
            text35.Text = "‹#›";

            field12.Append(runProperties35);
            field12.Append(text35);
            A.EndParagraphRunProperties endParagraphRunProperties23 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph46.Append(field12);
            paragraph46.Append(endParagraphRunProperties23);

            textBody29.Append(bodyProperties34);
            textBody29.Append(listStyle34);
            textBody29.Append(paragraph46);

            shape29.Append(nonVisualShapeProperties29);
            shape29.Append(shapeProperties51);
            shape29.Append(textBody29);

            shapeTree7.Append(nonVisualGroupShapeProperties7);
            shapeTree7.Append(groupShapeProperties7);
            shapeTree7.Append(shape25);
            shapeTree7.Append(shape26);
            shapeTree7.Append(shape27);
            shapeTree7.Append(shape28);
            shapeTree7.Append(shape29);

            CommonSlideDataExtensionList commonSlideDataExtensionList7 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension7 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId7 = new P14.CreationId(){ Val = (UInt32Value)1702811811U };
            creationId7.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension7.Append(creationId7);

            commonSlideDataExtensionList7.Append(commonSlideDataExtension7);

            commonSlideData7.Append(shapeTree7);
            commonSlideData7.Append(commonSlideDataExtensionList7);

            ColorMapOverride colorMapOverride6 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping6 = new A.MasterColorMapping();

            colorMapOverride6.Append(masterColorMapping6);

            slideLayout5.Append(commonSlideData7);
            slideLayout5.Append(colorMapOverride6);

            slideLayoutPart5.SlideLayout = slideLayout5;
        }

        // Generates content of slideLayoutPart6.
        private void GenerateSlideLayoutPart6Content(SlideLayoutPart slideLayoutPart6)
        {
            SlideLayout slideLayout6 = new SlideLayout(){ Type = SlideLayoutValues.TitleOnly, Preserve = true };
            slideLayout6.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout6.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout6.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData8 = new CommonSlideData(){ Name = "Title Only" };

            ShapeTree shapeTree8 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties8 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties38 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties8 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties38 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties8.Append(nonVisualDrawingProperties38);
            nonVisualGroupShapeProperties8.Append(nonVisualGroupShapeDrawingProperties8);
            nonVisualGroupShapeProperties8.Append(applicationNonVisualDrawingProperties38);

            GroupShapeProperties groupShapeProperties8 = new GroupShapeProperties();

            A.TransformGroup transformGroup8 = new A.TransformGroup();
            A.Offset offset21 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents21 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset8 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents8 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup8.Append(offset21);
            transformGroup8.Append(extents21);
            transformGroup8.Append(childOffset8);
            transformGroup8.Append(childExtents8);

            groupShapeProperties8.Append(transformGroup8);

            Shape shape30 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties30 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties39 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList31 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension31 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement33 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{741F9FE2-69A9-486C-A87D-3A2F589ED5A8}\" />");

            nonVisualDrawingPropertiesExtension31.Append(openXmlUnknownElement33);

            nonVisualDrawingPropertiesExtensionList31.Append(nonVisualDrawingPropertiesExtension31);

            nonVisualDrawingProperties39.Append(nonVisualDrawingPropertiesExtensionList31);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties30 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks30 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties30.Append(shapeLocks30);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties39 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape30 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties39.Append(placeholderShape30);

            nonVisualShapeProperties30.Append(nonVisualDrawingProperties39);
            nonVisualShapeProperties30.Append(nonVisualShapeDrawingProperties30);
            nonVisualShapeProperties30.Append(applicationNonVisualDrawingProperties39);
            ShapeProperties shapeProperties52 = new ShapeProperties();

            TextBody textBody30 = new TextBody();
            A.BodyProperties bodyProperties35 = new A.BodyProperties();
            A.ListStyle listStyle35 = new A.ListStyle();

            A.Paragraph paragraph47 = new A.Paragraph();

            A.Run run24 = new A.Run();
            A.RunProperties runProperties36 = new A.RunProperties(){ Language = "en-US" };
            A.Text text36 = new A.Text();
            text36.Text = "Click to edit Master title style";

            run24.Append(runProperties36);
            run24.Append(text36);

            paragraph47.Append(run24);

            textBody30.Append(bodyProperties35);
            textBody30.Append(listStyle35);
            textBody30.Append(paragraph47);

            shape30.Append(nonVisualShapeProperties30);
            shape30.Append(shapeProperties52);
            shape30.Append(textBody30);

            Shape shape31 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties31 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties40 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Date Placeholder 2" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList32 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension32 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement34 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{7F476267-D168-4646-8770-58817362904F}\" />");

            nonVisualDrawingPropertiesExtension32.Append(openXmlUnknownElement34);

            nonVisualDrawingPropertiesExtensionList32.Append(nonVisualDrawingPropertiesExtension32);

            nonVisualDrawingProperties40.Append(nonVisualDrawingPropertiesExtensionList32);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties31 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks31 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties31.Append(shapeLocks31);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties40 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape31 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties40.Append(placeholderShape31);

            nonVisualShapeProperties31.Append(nonVisualDrawingProperties40);
            nonVisualShapeProperties31.Append(nonVisualShapeDrawingProperties31);
            nonVisualShapeProperties31.Append(applicationNonVisualDrawingProperties40);
            ShapeProperties shapeProperties53 = new ShapeProperties();

            TextBody textBody31 = new TextBody();
            A.BodyProperties bodyProperties36 = new A.BodyProperties();
            A.ListStyle listStyle36 = new A.ListStyle();

            A.Paragraph paragraph48 = new A.Paragraph();

            A.Field field13 = new A.Field(){ Id = "{9BEF4A3D-57C8-4DC0-86D0-95A05287C467}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties37 = new A.RunProperties(){ Language = "en-US" };
            runProperties37.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text37 = new A.Text();
            text37.Text = "1/29/2020";

            field13.Append(runProperties37);
            field13.Append(text37);
            A.EndParagraphRunProperties endParagraphRunProperties24 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph48.Append(field13);
            paragraph48.Append(endParagraphRunProperties24);

            textBody31.Append(bodyProperties36);
            textBody31.Append(listStyle36);
            textBody31.Append(paragraph48);

            shape31.Append(nonVisualShapeProperties31);
            shape31.Append(shapeProperties53);
            shape31.Append(textBody31);

            Shape shape32 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties32 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties41 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Footer Placeholder 3" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList33 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension33 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement35 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{0C9E177A-3A85-421C-803A-2791E3F810FD}\" />");

            nonVisualDrawingPropertiesExtension33.Append(openXmlUnknownElement35);

            nonVisualDrawingPropertiesExtensionList33.Append(nonVisualDrawingPropertiesExtension33);

            nonVisualDrawingProperties41.Append(nonVisualDrawingPropertiesExtensionList33);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties32 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks32 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties32.Append(shapeLocks32);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties41 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape32 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties41.Append(placeholderShape32);

            nonVisualShapeProperties32.Append(nonVisualDrawingProperties41);
            nonVisualShapeProperties32.Append(nonVisualShapeDrawingProperties32);
            nonVisualShapeProperties32.Append(applicationNonVisualDrawingProperties41);
            ShapeProperties shapeProperties54 = new ShapeProperties();

            TextBody textBody32 = new TextBody();
            A.BodyProperties bodyProperties37 = new A.BodyProperties();
            A.ListStyle listStyle37 = new A.ListStyle();

            A.Paragraph paragraph49 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties25 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph49.Append(endParagraphRunProperties25);

            textBody32.Append(bodyProperties37);
            textBody32.Append(listStyle37);
            textBody32.Append(paragraph49);

            shape32.Append(nonVisualShapeProperties32);
            shape32.Append(shapeProperties54);
            shape32.Append(textBody32);

            Shape shape33 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties33 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties42 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Slide Number Placeholder 4" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList34 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension34 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement36 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{E199800C-B9A8-4119-9CCE-4C363A658D22}\" />");

            nonVisualDrawingPropertiesExtension34.Append(openXmlUnknownElement36);

            nonVisualDrawingPropertiesExtensionList34.Append(nonVisualDrawingPropertiesExtension34);

            nonVisualDrawingProperties42.Append(nonVisualDrawingPropertiesExtensionList34);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties33 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks33 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties33.Append(shapeLocks33);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties42 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape33 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties42.Append(placeholderShape33);

            nonVisualShapeProperties33.Append(nonVisualDrawingProperties42);
            nonVisualShapeProperties33.Append(nonVisualShapeDrawingProperties33);
            nonVisualShapeProperties33.Append(applicationNonVisualDrawingProperties42);
            ShapeProperties shapeProperties55 = new ShapeProperties();

            TextBody textBody33 = new TextBody();
            A.BodyProperties bodyProperties38 = new A.BodyProperties();
            A.ListStyle listStyle38 = new A.ListStyle();

            A.Paragraph paragraph50 = new A.Paragraph();

            A.Field field14 = new A.Field(){ Id = "{1BF20D12-B4E9-4886-A78D-768EA8FF95DD}", Type = "slidenum" };

            A.RunProperties runProperties38 = new A.RunProperties(){ Language = "en-US" };
            runProperties38.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text38 = new A.Text();
            text38.Text = "‹#›";

            field14.Append(runProperties38);
            field14.Append(text38);
            A.EndParagraphRunProperties endParagraphRunProperties26 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph50.Append(field14);
            paragraph50.Append(endParagraphRunProperties26);

            textBody33.Append(bodyProperties38);
            textBody33.Append(listStyle38);
            textBody33.Append(paragraph50);

            shape33.Append(nonVisualShapeProperties33);
            shape33.Append(shapeProperties55);
            shape33.Append(textBody33);

            shapeTree8.Append(nonVisualGroupShapeProperties8);
            shapeTree8.Append(groupShapeProperties8);
            shapeTree8.Append(shape30);
            shapeTree8.Append(shape31);
            shapeTree8.Append(shape32);
            shapeTree8.Append(shape33);

            CommonSlideDataExtensionList commonSlideDataExtensionList8 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension8 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId8 = new P14.CreationId(){ Val = (UInt32Value)3580377629U };
            creationId8.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension8.Append(creationId8);

            commonSlideDataExtensionList8.Append(commonSlideDataExtension8);

            commonSlideData8.Append(shapeTree8);
            commonSlideData8.Append(commonSlideDataExtensionList8);

            ColorMapOverride colorMapOverride7 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping7 = new A.MasterColorMapping();

            colorMapOverride7.Append(masterColorMapping7);

            slideLayout6.Append(commonSlideData8);
            slideLayout6.Append(colorMapOverride7);

            slideLayoutPart6.SlideLayout = slideLayout6;
        }

        // Generates content of slideLayoutPart7.
        private void GenerateSlideLayoutPart7Content(SlideLayoutPart slideLayoutPart7)
        {
            SlideLayout slideLayout7 = new SlideLayout(){ Type = SlideLayoutValues.VerticalTitleAndText, Preserve = true };
            slideLayout7.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout7.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout7.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData9 = new CommonSlideData(){ Name = "Vertical Title and Text" };

            ShapeTree shapeTree9 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties9 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties43 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties9 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties43 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties9.Append(nonVisualDrawingProperties43);
            nonVisualGroupShapeProperties9.Append(nonVisualGroupShapeDrawingProperties9);
            nonVisualGroupShapeProperties9.Append(applicationNonVisualDrawingProperties43);

            GroupShapeProperties groupShapeProperties9 = new GroupShapeProperties();

            A.TransformGroup transformGroup9 = new A.TransformGroup();
            A.Offset offset22 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents22 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset9 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents9 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup9.Append(offset22);
            transformGroup9.Append(extents22);
            transformGroup9.Append(childOffset9);
            transformGroup9.Append(childExtents9);

            groupShapeProperties9.Append(transformGroup9);

            Shape shape34 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties34 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties44 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Vertical Title 1" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList35 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension35 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement37 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{B74669AD-3838-4673-A782-8E74DF0A7FF6}\" />");

            nonVisualDrawingPropertiesExtension35.Append(openXmlUnknownElement37);

            nonVisualDrawingPropertiesExtensionList35.Append(nonVisualDrawingPropertiesExtension35);

            nonVisualDrawingProperties44.Append(nonVisualDrawingPropertiesExtensionList35);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties34 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks34 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties34.Append(shapeLocks34);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties44 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape34 = new PlaceholderShape(){ Type = PlaceholderValues.Title, Orientation = DirectionValues.Vertical };

            applicationNonVisualDrawingProperties44.Append(placeholderShape34);

            nonVisualShapeProperties34.Append(nonVisualDrawingProperties44);
            nonVisualShapeProperties34.Append(nonVisualShapeDrawingProperties34);
            nonVisualShapeProperties34.Append(applicationNonVisualDrawingProperties44);

            ShapeProperties shapeProperties56 = new ShapeProperties();

            A.Transform2D transform2D13 = new A.Transform2D();
            A.Offset offset23 = new A.Offset(){ X = 8724900L, Y = 365125L };
            A.Extents extents23 = new A.Extents(){ Cx = 2628900L, Cy = 5811838L };

            transform2D13.Append(offset23);
            transform2D13.Append(extents23);

            shapeProperties56.Append(transform2D13);

            TextBody textBody34 = new TextBody();
            A.BodyProperties bodyProperties39 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.EastAsianVetical };
            A.ListStyle listStyle39 = new A.ListStyle();

            A.Paragraph paragraph51 = new A.Paragraph();

            A.Run run25 = new A.Run();
            A.RunProperties runProperties39 = new A.RunProperties(){ Language = "en-US" };
            A.Text text39 = new A.Text();
            text39.Text = "Click to edit Master title style";

            run25.Append(runProperties39);
            run25.Append(text39);

            paragraph51.Append(run25);

            textBody34.Append(bodyProperties39);
            textBody34.Append(listStyle39);
            textBody34.Append(paragraph51);

            shape34.Append(nonVisualShapeProperties34);
            shape34.Append(shapeProperties56);
            shape34.Append(textBody34);

            Shape shape35 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties35 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties45 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Vertical Text Placeholder 2" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList36 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension36 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement38 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{7510780C-3B92-4202-ABB4-015BC8297BE3}\" />");

            nonVisualDrawingPropertiesExtension36.Append(openXmlUnknownElement38);

            nonVisualDrawingPropertiesExtensionList36.Append(nonVisualDrawingPropertiesExtension36);

            nonVisualDrawingProperties45.Append(nonVisualDrawingPropertiesExtensionList36);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties35 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks35 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties35.Append(shapeLocks35);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties45 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape35 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Orientation = DirectionValues.Vertical, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties45.Append(placeholderShape35);

            nonVisualShapeProperties35.Append(nonVisualDrawingProperties45);
            nonVisualShapeProperties35.Append(nonVisualShapeDrawingProperties35);
            nonVisualShapeProperties35.Append(applicationNonVisualDrawingProperties45);

            ShapeProperties shapeProperties57 = new ShapeProperties();

            A.Transform2D transform2D14 = new A.Transform2D();
            A.Offset offset24 = new A.Offset(){ X = 838200L, Y = 365125L };
            A.Extents extents24 = new A.Extents(){ Cx = 7734300L, Cy = 5811838L };

            transform2D14.Append(offset24);
            transform2D14.Append(extents24);

            shapeProperties57.Append(transform2D14);

            TextBody textBody35 = new TextBody();
            A.BodyProperties bodyProperties40 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.EastAsianVetical };
            A.ListStyle listStyle40 = new A.ListStyle();

            A.Paragraph paragraph52 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties23 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run26 = new A.Run();
            A.RunProperties runProperties40 = new A.RunProperties(){ Language = "en-US" };
            A.Text text40 = new A.Text();
            text40.Text = "Click to edit Master text styles";

            run26.Append(runProperties40);
            run26.Append(text40);

            paragraph52.Append(paragraphProperties23);
            paragraph52.Append(run26);

            A.Paragraph paragraph53 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties24 = new A.ParagraphProperties(){ Level = 1 };

            A.Run run27 = new A.Run();
            A.RunProperties runProperties41 = new A.RunProperties(){ Language = "en-US" };
            A.Text text41 = new A.Text();
            text41.Text = "Second level";

            run27.Append(runProperties41);
            run27.Append(text41);

            paragraph53.Append(paragraphProperties24);
            paragraph53.Append(run27);

            A.Paragraph paragraph54 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties25 = new A.ParagraphProperties(){ Level = 2 };

            A.Run run28 = new A.Run();
            A.RunProperties runProperties42 = new A.RunProperties(){ Language = "en-US" };
            A.Text text42 = new A.Text();
            text42.Text = "Third level";

            run28.Append(runProperties42);
            run28.Append(text42);

            paragraph54.Append(paragraphProperties25);
            paragraph54.Append(run28);

            A.Paragraph paragraph55 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties26 = new A.ParagraphProperties(){ Level = 3 };

            A.Run run29 = new A.Run();
            A.RunProperties runProperties43 = new A.RunProperties(){ Language = "en-US" };
            A.Text text43 = new A.Text();
            text43.Text = "Fourth level";

            run29.Append(runProperties43);
            run29.Append(text43);

            paragraph55.Append(paragraphProperties26);
            paragraph55.Append(run29);

            A.Paragraph paragraph56 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties27 = new A.ParagraphProperties(){ Level = 4 };

            A.Run run30 = new A.Run();
            A.RunProperties runProperties44 = new A.RunProperties(){ Language = "en-US" };
            A.Text text44 = new A.Text();
            text44.Text = "Fifth level";

            run30.Append(runProperties44);
            run30.Append(text44);

            paragraph56.Append(paragraphProperties27);
            paragraph56.Append(run30);

            textBody35.Append(bodyProperties40);
            textBody35.Append(listStyle40);
            textBody35.Append(paragraph52);
            textBody35.Append(paragraph53);
            textBody35.Append(paragraph54);
            textBody35.Append(paragraph55);
            textBody35.Append(paragraph56);

            shape35.Append(nonVisualShapeProperties35);
            shape35.Append(shapeProperties57);
            shape35.Append(textBody35);

            Shape shape36 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties36 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties46 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Date Placeholder 3" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList37 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension37 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement39 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{F58E00E0-FF2D-4BBB-84A9-844F17E8057C}\" />");

            nonVisualDrawingPropertiesExtension37.Append(openXmlUnknownElement39);

            nonVisualDrawingPropertiesExtensionList37.Append(nonVisualDrawingPropertiesExtension37);

            nonVisualDrawingProperties46.Append(nonVisualDrawingPropertiesExtensionList37);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties36 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks36 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties36.Append(shapeLocks36);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties46 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape36 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties46.Append(placeholderShape36);

            nonVisualShapeProperties36.Append(nonVisualDrawingProperties46);
            nonVisualShapeProperties36.Append(nonVisualShapeDrawingProperties36);
            nonVisualShapeProperties36.Append(applicationNonVisualDrawingProperties46);
            ShapeProperties shapeProperties58 = new ShapeProperties();

            TextBody textBody36 = new TextBody();
            A.BodyProperties bodyProperties41 = new A.BodyProperties();
            A.ListStyle listStyle41 = new A.ListStyle();

            A.Paragraph paragraph57 = new A.Paragraph();

            A.Field field15 = new A.Field(){ Id = "{9BEF4A3D-57C8-4DC0-86D0-95A05287C467}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties45 = new A.RunProperties(){ Language = "en-US" };
            runProperties45.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text45 = new A.Text();
            text45.Text = "1/29/2020";

            field15.Append(runProperties45);
            field15.Append(text45);
            A.EndParagraphRunProperties endParagraphRunProperties27 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph57.Append(field15);
            paragraph57.Append(endParagraphRunProperties27);

            textBody36.Append(bodyProperties41);
            textBody36.Append(listStyle41);
            textBody36.Append(paragraph57);

            shape36.Append(nonVisualShapeProperties36);
            shape36.Append(shapeProperties58);
            shape36.Append(textBody36);

            Shape shape37 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties37 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties47 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Footer Placeholder 4" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList38 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension38 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement40 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{9F4F4E2D-65F3-4CE0-974D-8A47199E0EC8}\" />");

            nonVisualDrawingPropertiesExtension38.Append(openXmlUnknownElement40);

            nonVisualDrawingPropertiesExtensionList38.Append(nonVisualDrawingPropertiesExtension38);

            nonVisualDrawingProperties47.Append(nonVisualDrawingPropertiesExtensionList38);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties37 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks37 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties37.Append(shapeLocks37);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties47 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape37 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties47.Append(placeholderShape37);

            nonVisualShapeProperties37.Append(nonVisualDrawingProperties47);
            nonVisualShapeProperties37.Append(nonVisualShapeDrawingProperties37);
            nonVisualShapeProperties37.Append(applicationNonVisualDrawingProperties47);
            ShapeProperties shapeProperties59 = new ShapeProperties();

            TextBody textBody37 = new TextBody();
            A.BodyProperties bodyProperties42 = new A.BodyProperties();
            A.ListStyle listStyle42 = new A.ListStyle();

            A.Paragraph paragraph58 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties28 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph58.Append(endParagraphRunProperties28);

            textBody37.Append(bodyProperties42);
            textBody37.Append(listStyle42);
            textBody37.Append(paragraph58);

            shape37.Append(nonVisualShapeProperties37);
            shape37.Append(shapeProperties59);
            shape37.Append(textBody37);

            Shape shape38 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties38 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties48 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Slide Number Placeholder 5" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList39 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension39 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement41 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{96DE9298-8A1C-479B-A63A-66F5670F4E5C}\" />");

            nonVisualDrawingPropertiesExtension39.Append(openXmlUnknownElement41);

            nonVisualDrawingPropertiesExtensionList39.Append(nonVisualDrawingPropertiesExtension39);

            nonVisualDrawingProperties48.Append(nonVisualDrawingPropertiesExtensionList39);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties38 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks38 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties38.Append(shapeLocks38);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties48 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape38 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties48.Append(placeholderShape38);

            nonVisualShapeProperties38.Append(nonVisualDrawingProperties48);
            nonVisualShapeProperties38.Append(nonVisualShapeDrawingProperties38);
            nonVisualShapeProperties38.Append(applicationNonVisualDrawingProperties48);
            ShapeProperties shapeProperties60 = new ShapeProperties();

            TextBody textBody38 = new TextBody();
            A.BodyProperties bodyProperties43 = new A.BodyProperties();
            A.ListStyle listStyle43 = new A.ListStyle();

            A.Paragraph paragraph59 = new A.Paragraph();

            A.Field field16 = new A.Field(){ Id = "{1BF20D12-B4E9-4886-A78D-768EA8FF95DD}", Type = "slidenum" };

            A.RunProperties runProperties46 = new A.RunProperties(){ Language = "en-US" };
            runProperties46.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text46 = new A.Text();
            text46.Text = "‹#›";

            field16.Append(runProperties46);
            field16.Append(text46);
            A.EndParagraphRunProperties endParagraphRunProperties29 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph59.Append(field16);
            paragraph59.Append(endParagraphRunProperties29);

            textBody38.Append(bodyProperties43);
            textBody38.Append(listStyle43);
            textBody38.Append(paragraph59);

            shape38.Append(nonVisualShapeProperties38);
            shape38.Append(shapeProperties60);
            shape38.Append(textBody38);

            shapeTree9.Append(nonVisualGroupShapeProperties9);
            shapeTree9.Append(groupShapeProperties9);
            shapeTree9.Append(shape34);
            shapeTree9.Append(shape35);
            shapeTree9.Append(shape36);
            shapeTree9.Append(shape37);
            shapeTree9.Append(shape38);

            CommonSlideDataExtensionList commonSlideDataExtensionList9 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension9 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId9 = new P14.CreationId(){ Val = (UInt32Value)1826574203U };
            creationId9.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension9.Append(creationId9);

            commonSlideDataExtensionList9.Append(commonSlideDataExtension9);

            commonSlideData9.Append(shapeTree9);
            commonSlideData9.Append(commonSlideDataExtensionList9);

            ColorMapOverride colorMapOverride8 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping8 = new A.MasterColorMapping();

            colorMapOverride8.Append(masterColorMapping8);

            slideLayout7.Append(commonSlideData9);
            slideLayout7.Append(colorMapOverride8);

            slideLayoutPart7.SlideLayout = slideLayout7;
        }

        // Generates content of slideLayoutPart8.
        private void GenerateSlideLayoutPart8Content(SlideLayoutPart slideLayoutPart8)
        {
            SlideLayout slideLayout8 = new SlideLayout(){ Type = SlideLayoutValues.TwoTextAndTwoObjects, Preserve = true };
            slideLayout8.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout8.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout8.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData10 = new CommonSlideData(){ Name = "Comparison" };

            ShapeTree shapeTree10 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties10 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties49 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties10 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties49 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties10.Append(nonVisualDrawingProperties49);
            nonVisualGroupShapeProperties10.Append(nonVisualGroupShapeDrawingProperties10);
            nonVisualGroupShapeProperties10.Append(applicationNonVisualDrawingProperties49);

            GroupShapeProperties groupShapeProperties10 = new GroupShapeProperties();

            A.TransformGroup transformGroup10 = new A.TransformGroup();
            A.Offset offset25 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents25 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset10 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents10 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup10.Append(offset25);
            transformGroup10.Append(extents25);
            transformGroup10.Append(childOffset10);
            transformGroup10.Append(childExtents10);

            groupShapeProperties10.Append(transformGroup10);

            Shape shape39 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties39 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties50 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList40 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension40 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement42 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{BA33AB16-6B73-406A-BD87-61359CF7535A}\" />");

            nonVisualDrawingPropertiesExtension40.Append(openXmlUnknownElement42);

            nonVisualDrawingPropertiesExtensionList40.Append(nonVisualDrawingPropertiesExtension40);

            nonVisualDrawingProperties50.Append(nonVisualDrawingPropertiesExtensionList40);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties39 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks39 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties39.Append(shapeLocks39);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties50 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape39 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties50.Append(placeholderShape39);

            nonVisualShapeProperties39.Append(nonVisualDrawingProperties50);
            nonVisualShapeProperties39.Append(nonVisualShapeDrawingProperties39);
            nonVisualShapeProperties39.Append(applicationNonVisualDrawingProperties50);

            ShapeProperties shapeProperties61 = new ShapeProperties();

            A.Transform2D transform2D15 = new A.Transform2D();
            A.Offset offset26 = new A.Offset(){ X = 839788L, Y = 365125L };
            A.Extents extents26 = new A.Extents(){ Cx = 10515600L, Cy = 1325563L };

            transform2D15.Append(offset26);
            transform2D15.Append(extents26);

            shapeProperties61.Append(transform2D15);

            TextBody textBody39 = new TextBody();
            A.BodyProperties bodyProperties44 = new A.BodyProperties();
            A.ListStyle listStyle44 = new A.ListStyle();

            A.Paragraph paragraph60 = new A.Paragraph();

            A.Run run31 = new A.Run();
            A.RunProperties runProperties47 = new A.RunProperties(){ Language = "en-US" };
            A.Text text47 = new A.Text();
            text47.Text = "Click to edit Master title style";

            run31.Append(runProperties47);
            run31.Append(text47);

            paragraph60.Append(run31);

            textBody39.Append(bodyProperties44);
            textBody39.Append(listStyle44);
            textBody39.Append(paragraph60);

            shape39.Append(nonVisualShapeProperties39);
            shape39.Append(shapeProperties61);
            shape39.Append(textBody39);

            Shape shape40 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties40 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties51 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Text Placeholder 2" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList41 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension41 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement43 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{52E6CF8B-6814-4CAD-8684-D12DE57A3308}\" />");

            nonVisualDrawingPropertiesExtension41.Append(openXmlUnknownElement43);

            nonVisualDrawingPropertiesExtensionList41.Append(nonVisualDrawingPropertiesExtension41);

            nonVisualDrawingProperties51.Append(nonVisualDrawingPropertiesExtensionList41);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties40 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks40 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties40.Append(shapeLocks40);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties51 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape40 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties51.Append(placeholderShape40);

            nonVisualShapeProperties40.Append(nonVisualDrawingProperties51);
            nonVisualShapeProperties40.Append(nonVisualShapeDrawingProperties40);
            nonVisualShapeProperties40.Append(applicationNonVisualDrawingProperties51);

            ShapeProperties shapeProperties62 = new ShapeProperties();

            A.Transform2D transform2D16 = new A.Transform2D();
            A.Offset offset27 = new A.Offset(){ X = 839788L, Y = 1681163L };
            A.Extents extents27 = new A.Extents(){ Cx = 5157787L, Cy = 823912L };

            transform2D16.Append(offset27);
            transform2D16.Append(extents27);

            shapeProperties62.Append(transform2D16);

            TextBody textBody40 = new TextBody();
            A.BodyProperties bodyProperties45 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Bottom };

            A.ListStyle listStyle45 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties15 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0 };
            A.NoBullet noBullet29 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties78 = new A.DefaultRunProperties(){ FontSize = 2400, Bold = true };

            level1ParagraphProperties15.Append(noBullet29);
            level1ParagraphProperties15.Append(defaultRunProperties78);

            A.Level2ParagraphProperties level2ParagraphProperties8 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Indent = 0 };
            A.NoBullet noBullet30 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties79 = new A.DefaultRunProperties(){ FontSize = 2000, Bold = true };

            level2ParagraphProperties8.Append(noBullet30);
            level2ParagraphProperties8.Append(defaultRunProperties79);

            A.Level3ParagraphProperties level3ParagraphProperties8 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Indent = 0 };
            A.NoBullet noBullet31 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties80 = new A.DefaultRunProperties(){ FontSize = 1800, Bold = true };

            level3ParagraphProperties8.Append(noBullet31);
            level3ParagraphProperties8.Append(defaultRunProperties80);

            A.Level4ParagraphProperties level4ParagraphProperties8 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Indent = 0 };
            A.NoBullet noBullet32 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties81 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level4ParagraphProperties8.Append(noBullet32);
            level4ParagraphProperties8.Append(defaultRunProperties81);

            A.Level5ParagraphProperties level5ParagraphProperties8 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Indent = 0 };
            A.NoBullet noBullet33 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties82 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level5ParagraphProperties8.Append(noBullet33);
            level5ParagraphProperties8.Append(defaultRunProperties82);

            A.Level6ParagraphProperties level6ParagraphProperties8 = new A.Level6ParagraphProperties(){ LeftMargin = 2286000, Indent = 0 };
            A.NoBullet noBullet34 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties83 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level6ParagraphProperties8.Append(noBullet34);
            level6ParagraphProperties8.Append(defaultRunProperties83);

            A.Level7ParagraphProperties level7ParagraphProperties8 = new A.Level7ParagraphProperties(){ LeftMargin = 2743200, Indent = 0 };
            A.NoBullet noBullet35 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties84 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level7ParagraphProperties8.Append(noBullet35);
            level7ParagraphProperties8.Append(defaultRunProperties84);

            A.Level8ParagraphProperties level8ParagraphProperties8 = new A.Level8ParagraphProperties(){ LeftMargin = 3200400, Indent = 0 };
            A.NoBullet noBullet36 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties85 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level8ParagraphProperties8.Append(noBullet36);
            level8ParagraphProperties8.Append(defaultRunProperties85);

            A.Level9ParagraphProperties level9ParagraphProperties8 = new A.Level9ParagraphProperties(){ LeftMargin = 3657600, Indent = 0 };
            A.NoBullet noBullet37 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties86 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level9ParagraphProperties8.Append(noBullet37);
            level9ParagraphProperties8.Append(defaultRunProperties86);

            listStyle45.Append(level1ParagraphProperties15);
            listStyle45.Append(level2ParagraphProperties8);
            listStyle45.Append(level3ParagraphProperties8);
            listStyle45.Append(level4ParagraphProperties8);
            listStyle45.Append(level5ParagraphProperties8);
            listStyle45.Append(level6ParagraphProperties8);
            listStyle45.Append(level7ParagraphProperties8);
            listStyle45.Append(level8ParagraphProperties8);
            listStyle45.Append(level9ParagraphProperties8);

            A.Paragraph paragraph61 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties28 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run32 = new A.Run();
            A.RunProperties runProperties48 = new A.RunProperties(){ Language = "en-US" };
            A.Text text48 = new A.Text();
            text48.Text = "Click to edit Master text styles";

            run32.Append(runProperties48);
            run32.Append(text48);

            paragraph61.Append(paragraphProperties28);
            paragraph61.Append(run32);

            textBody40.Append(bodyProperties45);
            textBody40.Append(listStyle45);
            textBody40.Append(paragraph61);

            shape40.Append(nonVisualShapeProperties40);
            shape40.Append(shapeProperties62);
            shape40.Append(textBody40);

            Shape shape41 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties41 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties52 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Content Placeholder 3" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList42 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension42 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement44 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{CCB9C4A5-D023-4288-8C47-E0D0AF25951D}\" />");

            nonVisualDrawingPropertiesExtension42.Append(openXmlUnknownElement44);

            nonVisualDrawingPropertiesExtensionList42.Append(nonVisualDrawingPropertiesExtension42);

            nonVisualDrawingProperties52.Append(nonVisualDrawingPropertiesExtensionList42);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties41 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks41 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties41.Append(shapeLocks41);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties52 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape41 = new PlaceholderShape(){ Size = PlaceholderSizeValues.Half, Index = (UInt32Value)2U };

            applicationNonVisualDrawingProperties52.Append(placeholderShape41);

            nonVisualShapeProperties41.Append(nonVisualDrawingProperties52);
            nonVisualShapeProperties41.Append(nonVisualShapeDrawingProperties41);
            nonVisualShapeProperties41.Append(applicationNonVisualDrawingProperties52);

            ShapeProperties shapeProperties63 = new ShapeProperties();

            A.Transform2D transform2D17 = new A.Transform2D();
            A.Offset offset28 = new A.Offset(){ X = 839788L, Y = 2505075L };
            A.Extents extents28 = new A.Extents(){ Cx = 5157787L, Cy = 3684588L };

            transform2D17.Append(offset28);
            transform2D17.Append(extents28);

            shapeProperties63.Append(transform2D17);

            TextBody textBody41 = new TextBody();
            A.BodyProperties bodyProperties46 = new A.BodyProperties();
            A.ListStyle listStyle46 = new A.ListStyle();

            A.Paragraph paragraph62 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties29 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run33 = new A.Run();
            A.RunProperties runProperties49 = new A.RunProperties(){ Language = "en-US" };
            A.Text text49 = new A.Text();
            text49.Text = "Click to edit Master text styles";

            run33.Append(runProperties49);
            run33.Append(text49);

            paragraph62.Append(paragraphProperties29);
            paragraph62.Append(run33);

            A.Paragraph paragraph63 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties30 = new A.ParagraphProperties(){ Level = 1 };

            A.Run run34 = new A.Run();
            A.RunProperties runProperties50 = new A.RunProperties(){ Language = "en-US" };
            A.Text text50 = new A.Text();
            text50.Text = "Second level";

            run34.Append(runProperties50);
            run34.Append(text50);

            paragraph63.Append(paragraphProperties30);
            paragraph63.Append(run34);

            A.Paragraph paragraph64 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties31 = new A.ParagraphProperties(){ Level = 2 };

            A.Run run35 = new A.Run();
            A.RunProperties runProperties51 = new A.RunProperties(){ Language = "en-US" };
            A.Text text51 = new A.Text();
            text51.Text = "Third level";

            run35.Append(runProperties51);
            run35.Append(text51);

            paragraph64.Append(paragraphProperties31);
            paragraph64.Append(run35);

            A.Paragraph paragraph65 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties32 = new A.ParagraphProperties(){ Level = 3 };

            A.Run run36 = new A.Run();
            A.RunProperties runProperties52 = new A.RunProperties(){ Language = "en-US" };
            A.Text text52 = new A.Text();
            text52.Text = "Fourth level";

            run36.Append(runProperties52);
            run36.Append(text52);

            paragraph65.Append(paragraphProperties32);
            paragraph65.Append(run36);

            A.Paragraph paragraph66 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties33 = new A.ParagraphProperties(){ Level = 4 };

            A.Run run37 = new A.Run();
            A.RunProperties runProperties53 = new A.RunProperties(){ Language = "en-US" };
            A.Text text53 = new A.Text();
            text53.Text = "Fifth level";

            run37.Append(runProperties53);
            run37.Append(text53);

            paragraph66.Append(paragraphProperties33);
            paragraph66.Append(run37);

            textBody41.Append(bodyProperties46);
            textBody41.Append(listStyle46);
            textBody41.Append(paragraph62);
            textBody41.Append(paragraph63);
            textBody41.Append(paragraph64);
            textBody41.Append(paragraph65);
            textBody41.Append(paragraph66);

            shape41.Append(nonVisualShapeProperties41);
            shape41.Append(shapeProperties63);
            shape41.Append(textBody41);

            Shape shape42 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties42 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties53 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Text Placeholder 4" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList43 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension43 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement45 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{2DAFFDD9-489D-4135-832E-225EB3A25342}\" />");

            nonVisualDrawingPropertiesExtension43.Append(openXmlUnknownElement45);

            nonVisualDrawingPropertiesExtensionList43.Append(nonVisualDrawingPropertiesExtension43);

            nonVisualDrawingProperties53.Append(nonVisualDrawingPropertiesExtensionList43);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties42 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks42 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties42.Append(shapeLocks42);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties53 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape42 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)3U };

            applicationNonVisualDrawingProperties53.Append(placeholderShape42);

            nonVisualShapeProperties42.Append(nonVisualDrawingProperties53);
            nonVisualShapeProperties42.Append(nonVisualShapeDrawingProperties42);
            nonVisualShapeProperties42.Append(applicationNonVisualDrawingProperties53);

            ShapeProperties shapeProperties64 = new ShapeProperties();

            A.Transform2D transform2D18 = new A.Transform2D();
            A.Offset offset29 = new A.Offset(){ X = 6172200L, Y = 1681163L };
            A.Extents extents29 = new A.Extents(){ Cx = 5183188L, Cy = 823912L };

            transform2D18.Append(offset29);
            transform2D18.Append(extents29);

            shapeProperties64.Append(transform2D18);

            TextBody textBody42 = new TextBody();
            A.BodyProperties bodyProperties47 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Bottom };

            A.ListStyle listStyle47 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties16 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0 };
            A.NoBullet noBullet38 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties87 = new A.DefaultRunProperties(){ FontSize = 2400, Bold = true };

            level1ParagraphProperties16.Append(noBullet38);
            level1ParagraphProperties16.Append(defaultRunProperties87);

            A.Level2ParagraphProperties level2ParagraphProperties9 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Indent = 0 };
            A.NoBullet noBullet39 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties88 = new A.DefaultRunProperties(){ FontSize = 2000, Bold = true };

            level2ParagraphProperties9.Append(noBullet39);
            level2ParagraphProperties9.Append(defaultRunProperties88);

            A.Level3ParagraphProperties level3ParagraphProperties9 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Indent = 0 };
            A.NoBullet noBullet40 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties89 = new A.DefaultRunProperties(){ FontSize = 1800, Bold = true };

            level3ParagraphProperties9.Append(noBullet40);
            level3ParagraphProperties9.Append(defaultRunProperties89);

            A.Level4ParagraphProperties level4ParagraphProperties9 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Indent = 0 };
            A.NoBullet noBullet41 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties90 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level4ParagraphProperties9.Append(noBullet41);
            level4ParagraphProperties9.Append(defaultRunProperties90);

            A.Level5ParagraphProperties level5ParagraphProperties9 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Indent = 0 };
            A.NoBullet noBullet42 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties91 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level5ParagraphProperties9.Append(noBullet42);
            level5ParagraphProperties9.Append(defaultRunProperties91);

            A.Level6ParagraphProperties level6ParagraphProperties9 = new A.Level6ParagraphProperties(){ LeftMargin = 2286000, Indent = 0 };
            A.NoBullet noBullet43 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties92 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level6ParagraphProperties9.Append(noBullet43);
            level6ParagraphProperties9.Append(defaultRunProperties92);

            A.Level7ParagraphProperties level7ParagraphProperties9 = new A.Level7ParagraphProperties(){ LeftMargin = 2743200, Indent = 0 };
            A.NoBullet noBullet44 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties93 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level7ParagraphProperties9.Append(noBullet44);
            level7ParagraphProperties9.Append(defaultRunProperties93);

            A.Level8ParagraphProperties level8ParagraphProperties9 = new A.Level8ParagraphProperties(){ LeftMargin = 3200400, Indent = 0 };
            A.NoBullet noBullet45 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties94 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level8ParagraphProperties9.Append(noBullet45);
            level8ParagraphProperties9.Append(defaultRunProperties94);

            A.Level9ParagraphProperties level9ParagraphProperties9 = new A.Level9ParagraphProperties(){ LeftMargin = 3657600, Indent = 0 };
            A.NoBullet noBullet46 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties95 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level9ParagraphProperties9.Append(noBullet46);
            level9ParagraphProperties9.Append(defaultRunProperties95);

            listStyle47.Append(level1ParagraphProperties16);
            listStyle47.Append(level2ParagraphProperties9);
            listStyle47.Append(level3ParagraphProperties9);
            listStyle47.Append(level4ParagraphProperties9);
            listStyle47.Append(level5ParagraphProperties9);
            listStyle47.Append(level6ParagraphProperties9);
            listStyle47.Append(level7ParagraphProperties9);
            listStyle47.Append(level8ParagraphProperties9);
            listStyle47.Append(level9ParagraphProperties9);

            A.Paragraph paragraph67 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties34 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run38 = new A.Run();
            A.RunProperties runProperties54 = new A.RunProperties(){ Language = "en-US" };
            A.Text text54 = new A.Text();
            text54.Text = "Click to edit Master text styles";

            run38.Append(runProperties54);
            run38.Append(text54);

            paragraph67.Append(paragraphProperties34);
            paragraph67.Append(run38);

            textBody42.Append(bodyProperties47);
            textBody42.Append(listStyle47);
            textBody42.Append(paragraph67);

            shape42.Append(nonVisualShapeProperties42);
            shape42.Append(shapeProperties64);
            shape42.Append(textBody42);

            Shape shape43 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties43 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties54 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Content Placeholder 5" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList44 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension44 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement46 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{4EB4E153-D4CF-4249-80A4-669AE4529B01}\" />");

            nonVisualDrawingPropertiesExtension44.Append(openXmlUnknownElement46);

            nonVisualDrawingPropertiesExtensionList44.Append(nonVisualDrawingPropertiesExtension44);

            nonVisualDrawingProperties54.Append(nonVisualDrawingPropertiesExtensionList44);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties43 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks43 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties43.Append(shapeLocks43);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties54 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape43 = new PlaceholderShape(){ Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)4U };

            applicationNonVisualDrawingProperties54.Append(placeholderShape43);

            nonVisualShapeProperties43.Append(nonVisualDrawingProperties54);
            nonVisualShapeProperties43.Append(nonVisualShapeDrawingProperties43);
            nonVisualShapeProperties43.Append(applicationNonVisualDrawingProperties54);

            ShapeProperties shapeProperties65 = new ShapeProperties();

            A.Transform2D transform2D19 = new A.Transform2D();
            A.Offset offset30 = new A.Offset(){ X = 6172200L, Y = 2505075L };
            A.Extents extents30 = new A.Extents(){ Cx = 5183188L, Cy = 3684588L };

            transform2D19.Append(offset30);
            transform2D19.Append(extents30);

            shapeProperties65.Append(transform2D19);

            TextBody textBody43 = new TextBody();
            A.BodyProperties bodyProperties48 = new A.BodyProperties();
            A.ListStyle listStyle48 = new A.ListStyle();

            A.Paragraph paragraph68 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties35 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run39 = new A.Run();
            A.RunProperties runProperties55 = new A.RunProperties(){ Language = "en-US" };
            A.Text text55 = new A.Text();
            text55.Text = "Click to edit Master text styles";

            run39.Append(runProperties55);
            run39.Append(text55);

            paragraph68.Append(paragraphProperties35);
            paragraph68.Append(run39);

            A.Paragraph paragraph69 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties36 = new A.ParagraphProperties(){ Level = 1 };

            A.Run run40 = new A.Run();
            A.RunProperties runProperties56 = new A.RunProperties(){ Language = "en-US" };
            A.Text text56 = new A.Text();
            text56.Text = "Second level";

            run40.Append(runProperties56);
            run40.Append(text56);

            paragraph69.Append(paragraphProperties36);
            paragraph69.Append(run40);

            A.Paragraph paragraph70 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties37 = new A.ParagraphProperties(){ Level = 2 };

            A.Run run41 = new A.Run();
            A.RunProperties runProperties57 = new A.RunProperties(){ Language = "en-US" };
            A.Text text57 = new A.Text();
            text57.Text = "Third level";

            run41.Append(runProperties57);
            run41.Append(text57);

            paragraph70.Append(paragraphProperties37);
            paragraph70.Append(run41);

            A.Paragraph paragraph71 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties38 = new A.ParagraphProperties(){ Level = 3 };

            A.Run run42 = new A.Run();
            A.RunProperties runProperties58 = new A.RunProperties(){ Language = "en-US" };
            A.Text text58 = new A.Text();
            text58.Text = "Fourth level";

            run42.Append(runProperties58);
            run42.Append(text58);

            paragraph71.Append(paragraphProperties38);
            paragraph71.Append(run42);

            A.Paragraph paragraph72 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties39 = new A.ParagraphProperties(){ Level = 4 };

            A.Run run43 = new A.Run();
            A.RunProperties runProperties59 = new A.RunProperties(){ Language = "en-US" };
            A.Text text59 = new A.Text();
            text59.Text = "Fifth level";

            run43.Append(runProperties59);
            run43.Append(text59);

            paragraph72.Append(paragraphProperties39);
            paragraph72.Append(run43);

            textBody43.Append(bodyProperties48);
            textBody43.Append(listStyle48);
            textBody43.Append(paragraph68);
            textBody43.Append(paragraph69);
            textBody43.Append(paragraph70);
            textBody43.Append(paragraph71);
            textBody43.Append(paragraph72);

            shape43.Append(nonVisualShapeProperties43);
            shape43.Append(shapeProperties65);
            shape43.Append(textBody43);

            Shape shape44 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties44 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties55 = new NonVisualDrawingProperties(){ Id = (UInt32Value)7U, Name = "Date Placeholder 6" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList45 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension45 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement47 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{6718D1AF-5832-4ABF-9FCF-A47D68C353D5}\" />");

            nonVisualDrawingPropertiesExtension45.Append(openXmlUnknownElement47);

            nonVisualDrawingPropertiesExtensionList45.Append(nonVisualDrawingPropertiesExtension45);

            nonVisualDrawingProperties55.Append(nonVisualDrawingPropertiesExtensionList45);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties44 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks44 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties44.Append(shapeLocks44);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties55 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape44 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties55.Append(placeholderShape44);

            nonVisualShapeProperties44.Append(nonVisualDrawingProperties55);
            nonVisualShapeProperties44.Append(nonVisualShapeDrawingProperties44);
            nonVisualShapeProperties44.Append(applicationNonVisualDrawingProperties55);
            ShapeProperties shapeProperties66 = new ShapeProperties();

            TextBody textBody44 = new TextBody();
            A.BodyProperties bodyProperties49 = new A.BodyProperties();
            A.ListStyle listStyle49 = new A.ListStyle();

            A.Paragraph paragraph73 = new A.Paragraph();

            A.Field field17 = new A.Field(){ Id = "{9BEF4A3D-57C8-4DC0-86D0-95A05287C467}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties60 = new A.RunProperties(){ Language = "en-US" };
            runProperties60.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text60 = new A.Text();
            text60.Text = "1/29/2020";

            field17.Append(runProperties60);
            field17.Append(text60);
            A.EndParagraphRunProperties endParagraphRunProperties30 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph73.Append(field17);
            paragraph73.Append(endParagraphRunProperties30);

            textBody44.Append(bodyProperties49);
            textBody44.Append(listStyle49);
            textBody44.Append(paragraph73);

            shape44.Append(nonVisualShapeProperties44);
            shape44.Append(shapeProperties66);
            shape44.Append(textBody44);

            Shape shape45 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties45 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties56 = new NonVisualDrawingProperties(){ Id = (UInt32Value)8U, Name = "Footer Placeholder 7" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList46 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension46 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement48 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{5CD8C608-AA5E-462B-825E-F47F8C4C8AA9}\" />");

            nonVisualDrawingPropertiesExtension46.Append(openXmlUnknownElement48);

            nonVisualDrawingPropertiesExtensionList46.Append(nonVisualDrawingPropertiesExtension46);

            nonVisualDrawingProperties56.Append(nonVisualDrawingPropertiesExtensionList46);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties45 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks45 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties45.Append(shapeLocks45);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties56 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape45 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties56.Append(placeholderShape45);

            nonVisualShapeProperties45.Append(nonVisualDrawingProperties56);
            nonVisualShapeProperties45.Append(nonVisualShapeDrawingProperties45);
            nonVisualShapeProperties45.Append(applicationNonVisualDrawingProperties56);
            ShapeProperties shapeProperties67 = new ShapeProperties();

            TextBody textBody45 = new TextBody();
            A.BodyProperties bodyProperties50 = new A.BodyProperties();
            A.ListStyle listStyle50 = new A.ListStyle();

            A.Paragraph paragraph74 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties31 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph74.Append(endParagraphRunProperties31);

            textBody45.Append(bodyProperties50);
            textBody45.Append(listStyle50);
            textBody45.Append(paragraph74);

            shape45.Append(nonVisualShapeProperties45);
            shape45.Append(shapeProperties67);
            shape45.Append(textBody45);

            Shape shape46 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties46 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties57 = new NonVisualDrawingProperties(){ Id = (UInt32Value)9U, Name = "Slide Number Placeholder 8" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList47 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension47 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement49 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{6E8188ED-A461-4CA7-B718-C319DA7958F9}\" />");

            nonVisualDrawingPropertiesExtension47.Append(openXmlUnknownElement49);

            nonVisualDrawingPropertiesExtensionList47.Append(nonVisualDrawingPropertiesExtension47);

            nonVisualDrawingProperties57.Append(nonVisualDrawingPropertiesExtensionList47);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties46 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks46 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties46.Append(shapeLocks46);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties57 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape46 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties57.Append(placeholderShape46);

            nonVisualShapeProperties46.Append(nonVisualDrawingProperties57);
            nonVisualShapeProperties46.Append(nonVisualShapeDrawingProperties46);
            nonVisualShapeProperties46.Append(applicationNonVisualDrawingProperties57);
            ShapeProperties shapeProperties68 = new ShapeProperties();

            TextBody textBody46 = new TextBody();
            A.BodyProperties bodyProperties51 = new A.BodyProperties();
            A.ListStyle listStyle51 = new A.ListStyle();

            A.Paragraph paragraph75 = new A.Paragraph();

            A.Field field18 = new A.Field(){ Id = "{1BF20D12-B4E9-4886-A78D-768EA8FF95DD}", Type = "slidenum" };

            A.RunProperties runProperties61 = new A.RunProperties(){ Language = "en-US" };
            runProperties61.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text61 = new A.Text();
            text61.Text = "‹#›";

            field18.Append(runProperties61);
            field18.Append(text61);
            A.EndParagraphRunProperties endParagraphRunProperties32 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph75.Append(field18);
            paragraph75.Append(endParagraphRunProperties32);

            textBody46.Append(bodyProperties51);
            textBody46.Append(listStyle51);
            textBody46.Append(paragraph75);

            shape46.Append(nonVisualShapeProperties46);
            shape46.Append(shapeProperties68);
            shape46.Append(textBody46);

            shapeTree10.Append(nonVisualGroupShapeProperties10);
            shapeTree10.Append(groupShapeProperties10);
            shapeTree10.Append(shape39);
            shapeTree10.Append(shape40);
            shapeTree10.Append(shape41);
            shapeTree10.Append(shape42);
            shapeTree10.Append(shape43);
            shapeTree10.Append(shape44);
            shapeTree10.Append(shape45);
            shapeTree10.Append(shape46);

            CommonSlideDataExtensionList commonSlideDataExtensionList10 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension10 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId10 = new P14.CreationId(){ Val = (UInt32Value)3154233081U };
            creationId10.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension10.Append(creationId10);

            commonSlideDataExtensionList10.Append(commonSlideDataExtension10);

            commonSlideData10.Append(shapeTree10);
            commonSlideData10.Append(commonSlideDataExtensionList10);

            ColorMapOverride colorMapOverride9 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping9 = new A.MasterColorMapping();

            colorMapOverride9.Append(masterColorMapping9);

            slideLayout8.Append(commonSlideData10);
            slideLayout8.Append(colorMapOverride9);

            slideLayoutPart8.SlideLayout = slideLayout8;
        }

        // Generates content of slideLayoutPart9.
        private void GenerateSlideLayoutPart9Content(SlideLayoutPart slideLayoutPart9)
        {
            SlideLayout slideLayout9 = new SlideLayout(){ Type = SlideLayoutValues.VerticalText, Preserve = true };
            slideLayout9.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout9.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout9.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData11 = new CommonSlideData(){ Name = "Title and Vertical Text" };

            ShapeTree shapeTree11 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties11 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties58 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties11 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties58 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties11.Append(nonVisualDrawingProperties58);
            nonVisualGroupShapeProperties11.Append(nonVisualGroupShapeDrawingProperties11);
            nonVisualGroupShapeProperties11.Append(applicationNonVisualDrawingProperties58);

            GroupShapeProperties groupShapeProperties11 = new GroupShapeProperties();

            A.TransformGroup transformGroup11 = new A.TransformGroup();
            A.Offset offset31 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents31 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset11 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents11 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup11.Append(offset31);
            transformGroup11.Append(extents31);
            transformGroup11.Append(childOffset11);
            transformGroup11.Append(childExtents11);

            groupShapeProperties11.Append(transformGroup11);

            Shape shape47 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties47 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties59 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList48 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension48 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement50 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{943B1E66-6B0C-4DB4-A88D-A2A2600E6636}\" />");

            nonVisualDrawingPropertiesExtension48.Append(openXmlUnknownElement50);

            nonVisualDrawingPropertiesExtensionList48.Append(nonVisualDrawingPropertiesExtension48);

            nonVisualDrawingProperties59.Append(nonVisualDrawingPropertiesExtensionList48);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties47 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks47 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties47.Append(shapeLocks47);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties59 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape47 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties59.Append(placeholderShape47);

            nonVisualShapeProperties47.Append(nonVisualDrawingProperties59);
            nonVisualShapeProperties47.Append(nonVisualShapeDrawingProperties47);
            nonVisualShapeProperties47.Append(applicationNonVisualDrawingProperties59);
            ShapeProperties shapeProperties69 = new ShapeProperties();

            TextBody textBody47 = new TextBody();
            A.BodyProperties bodyProperties52 = new A.BodyProperties();
            A.ListStyle listStyle52 = new A.ListStyle();

            A.Paragraph paragraph76 = new A.Paragraph();

            A.Run run44 = new A.Run();
            A.RunProperties runProperties62 = new A.RunProperties(){ Language = "en-US" };
            A.Text text62 = new A.Text();
            text62.Text = "Click to edit Master title style";

            run44.Append(runProperties62);
            run44.Append(text62);

            paragraph76.Append(run44);

            textBody47.Append(bodyProperties52);
            textBody47.Append(listStyle52);
            textBody47.Append(paragraph76);

            shape47.Append(nonVisualShapeProperties47);
            shape47.Append(shapeProperties69);
            shape47.Append(textBody47);

            Shape shape48 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties48 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties60 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Vertical Text Placeholder 2" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList49 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension49 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement51 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{736C31D5-9C91-4B9D-A0E0-5291E337E483}\" />");

            nonVisualDrawingPropertiesExtension49.Append(openXmlUnknownElement51);

            nonVisualDrawingPropertiesExtensionList49.Append(nonVisualDrawingPropertiesExtension49);

            nonVisualDrawingProperties60.Append(nonVisualDrawingPropertiesExtensionList49);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties48 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks48 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties48.Append(shapeLocks48);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties60 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape48 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Orientation = DirectionValues.Vertical, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties60.Append(placeholderShape48);

            nonVisualShapeProperties48.Append(nonVisualDrawingProperties60);
            nonVisualShapeProperties48.Append(nonVisualShapeDrawingProperties48);
            nonVisualShapeProperties48.Append(applicationNonVisualDrawingProperties60);
            ShapeProperties shapeProperties70 = new ShapeProperties();

            TextBody textBody48 = new TextBody();
            A.BodyProperties bodyProperties53 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.EastAsianVetical };
            A.ListStyle listStyle53 = new A.ListStyle();

            A.Paragraph paragraph77 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties40 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run45 = new A.Run();
            A.RunProperties runProperties63 = new A.RunProperties(){ Language = "en-US" };
            A.Text text63 = new A.Text();
            text63.Text = "Click to edit Master text styles";

            run45.Append(runProperties63);
            run45.Append(text63);

            paragraph77.Append(paragraphProperties40);
            paragraph77.Append(run45);

            A.Paragraph paragraph78 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties41 = new A.ParagraphProperties(){ Level = 1 };

            A.Run run46 = new A.Run();
            A.RunProperties runProperties64 = new A.RunProperties(){ Language = "en-US" };
            A.Text text64 = new A.Text();
            text64.Text = "Second level";

            run46.Append(runProperties64);
            run46.Append(text64);

            paragraph78.Append(paragraphProperties41);
            paragraph78.Append(run46);

            A.Paragraph paragraph79 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties42 = new A.ParagraphProperties(){ Level = 2 };

            A.Run run47 = new A.Run();
            A.RunProperties runProperties65 = new A.RunProperties(){ Language = "en-US" };
            A.Text text65 = new A.Text();
            text65.Text = "Third level";

            run47.Append(runProperties65);
            run47.Append(text65);

            paragraph79.Append(paragraphProperties42);
            paragraph79.Append(run47);

            A.Paragraph paragraph80 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties43 = new A.ParagraphProperties(){ Level = 3 };

            A.Run run48 = new A.Run();
            A.RunProperties runProperties66 = new A.RunProperties(){ Language = "en-US" };
            A.Text text66 = new A.Text();
            text66.Text = "Fourth level";

            run48.Append(runProperties66);
            run48.Append(text66);

            paragraph80.Append(paragraphProperties43);
            paragraph80.Append(run48);

            A.Paragraph paragraph81 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties44 = new A.ParagraphProperties(){ Level = 4 };

            A.Run run49 = new A.Run();
            A.RunProperties runProperties67 = new A.RunProperties(){ Language = "en-US" };
            A.Text text67 = new A.Text();
            text67.Text = "Fifth level";

            run49.Append(runProperties67);
            run49.Append(text67);

            paragraph81.Append(paragraphProperties44);
            paragraph81.Append(run49);

            textBody48.Append(bodyProperties53);
            textBody48.Append(listStyle53);
            textBody48.Append(paragraph77);
            textBody48.Append(paragraph78);
            textBody48.Append(paragraph79);
            textBody48.Append(paragraph80);
            textBody48.Append(paragraph81);

            shape48.Append(nonVisualShapeProperties48);
            shape48.Append(shapeProperties70);
            shape48.Append(textBody48);

            Shape shape49 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties49 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties61 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Date Placeholder 3" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList50 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension50 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement52 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{46C086D9-732D-4B8B-9E07-0F437F20A7DC}\" />");

            nonVisualDrawingPropertiesExtension50.Append(openXmlUnknownElement52);

            nonVisualDrawingPropertiesExtensionList50.Append(nonVisualDrawingPropertiesExtension50);

            nonVisualDrawingProperties61.Append(nonVisualDrawingPropertiesExtensionList50);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties49 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks49 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties49.Append(shapeLocks49);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties61 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape49 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties61.Append(placeholderShape49);

            nonVisualShapeProperties49.Append(nonVisualDrawingProperties61);
            nonVisualShapeProperties49.Append(nonVisualShapeDrawingProperties49);
            nonVisualShapeProperties49.Append(applicationNonVisualDrawingProperties61);
            ShapeProperties shapeProperties71 = new ShapeProperties();

            TextBody textBody49 = new TextBody();
            A.BodyProperties bodyProperties54 = new A.BodyProperties();
            A.ListStyle listStyle54 = new A.ListStyle();

            A.Paragraph paragraph82 = new A.Paragraph();

            A.Field field19 = new A.Field(){ Id = "{9BEF4A3D-57C8-4DC0-86D0-95A05287C467}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties68 = new A.RunProperties(){ Language = "en-US" };
            runProperties68.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text68 = new A.Text();
            text68.Text = "1/29/2020";

            field19.Append(runProperties68);
            field19.Append(text68);
            A.EndParagraphRunProperties endParagraphRunProperties33 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph82.Append(field19);
            paragraph82.Append(endParagraphRunProperties33);

            textBody49.Append(bodyProperties54);
            textBody49.Append(listStyle54);
            textBody49.Append(paragraph82);

            shape49.Append(nonVisualShapeProperties49);
            shape49.Append(shapeProperties71);
            shape49.Append(textBody49);

            Shape shape50 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties50 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties62 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Footer Placeholder 4" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList51 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension51 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement53 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{25AA885F-AF66-4187-A088-264388058A33}\" />");

            nonVisualDrawingPropertiesExtension51.Append(openXmlUnknownElement53);

            nonVisualDrawingPropertiesExtensionList51.Append(nonVisualDrawingPropertiesExtension51);

            nonVisualDrawingProperties62.Append(nonVisualDrawingPropertiesExtensionList51);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties50 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks50 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties50.Append(shapeLocks50);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties62 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape50 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties62.Append(placeholderShape50);

            nonVisualShapeProperties50.Append(nonVisualDrawingProperties62);
            nonVisualShapeProperties50.Append(nonVisualShapeDrawingProperties50);
            nonVisualShapeProperties50.Append(applicationNonVisualDrawingProperties62);
            ShapeProperties shapeProperties72 = new ShapeProperties();

            TextBody textBody50 = new TextBody();
            A.BodyProperties bodyProperties55 = new A.BodyProperties();
            A.ListStyle listStyle55 = new A.ListStyle();

            A.Paragraph paragraph83 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties34 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph83.Append(endParagraphRunProperties34);

            textBody50.Append(bodyProperties55);
            textBody50.Append(listStyle55);
            textBody50.Append(paragraph83);

            shape50.Append(nonVisualShapeProperties50);
            shape50.Append(shapeProperties72);
            shape50.Append(textBody50);

            Shape shape51 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties51 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties63 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Slide Number Placeholder 5" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList52 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension52 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement54 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{211A1558-C76D-4811-9FF6-2BDDC52513A6}\" />");

            nonVisualDrawingPropertiesExtension52.Append(openXmlUnknownElement54);

            nonVisualDrawingPropertiesExtensionList52.Append(nonVisualDrawingPropertiesExtension52);

            nonVisualDrawingProperties63.Append(nonVisualDrawingPropertiesExtensionList52);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties51 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks51 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties51.Append(shapeLocks51);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties63 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape51 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties63.Append(placeholderShape51);

            nonVisualShapeProperties51.Append(nonVisualDrawingProperties63);
            nonVisualShapeProperties51.Append(nonVisualShapeDrawingProperties51);
            nonVisualShapeProperties51.Append(applicationNonVisualDrawingProperties63);
            ShapeProperties shapeProperties73 = new ShapeProperties();

            TextBody textBody51 = new TextBody();
            A.BodyProperties bodyProperties56 = new A.BodyProperties();
            A.ListStyle listStyle56 = new A.ListStyle();

            A.Paragraph paragraph84 = new A.Paragraph();

            A.Field field20 = new A.Field(){ Id = "{1BF20D12-B4E9-4886-A78D-768EA8FF95DD}", Type = "slidenum" };

            A.RunProperties runProperties69 = new A.RunProperties(){ Language = "en-US" };
            runProperties69.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text69 = new A.Text();
            text69.Text = "‹#›";

            field20.Append(runProperties69);
            field20.Append(text69);
            A.EndParagraphRunProperties endParagraphRunProperties35 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph84.Append(field20);
            paragraph84.Append(endParagraphRunProperties35);

            textBody51.Append(bodyProperties56);
            textBody51.Append(listStyle56);
            textBody51.Append(paragraph84);

            shape51.Append(nonVisualShapeProperties51);
            shape51.Append(shapeProperties73);
            shape51.Append(textBody51);

            shapeTree11.Append(nonVisualGroupShapeProperties11);
            shapeTree11.Append(groupShapeProperties11);
            shapeTree11.Append(shape47);
            shapeTree11.Append(shape48);
            shapeTree11.Append(shape49);
            shapeTree11.Append(shape50);
            shapeTree11.Append(shape51);

            CommonSlideDataExtensionList commonSlideDataExtensionList11 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension11 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId11 = new P14.CreationId(){ Val = (UInt32Value)3795350559U };
            creationId11.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension11.Append(creationId11);

            commonSlideDataExtensionList11.Append(commonSlideDataExtension11);

            commonSlideData11.Append(shapeTree11);
            commonSlideData11.Append(commonSlideDataExtensionList11);

            ColorMapOverride colorMapOverride10 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping10 = new A.MasterColorMapping();

            colorMapOverride10.Append(masterColorMapping10);

            slideLayout9.Append(commonSlideData11);
            slideLayout9.Append(colorMapOverride10);

            slideLayoutPart9.SlideLayout = slideLayout9;
        }

        // Generates content of slideLayoutPart10.
        private void GenerateSlideLayoutPart10Content(SlideLayoutPart slideLayoutPart10)
        {
            SlideLayout slideLayout10 = new SlideLayout(){ Type = SlideLayoutValues.TwoObjects, Preserve = true };
            slideLayout10.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout10.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout10.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData12 = new CommonSlideData(){ Name = "Two Content" };

            ShapeTree shapeTree12 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties12 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties64 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties12 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties64 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties12.Append(nonVisualDrawingProperties64);
            nonVisualGroupShapeProperties12.Append(nonVisualGroupShapeDrawingProperties12);
            nonVisualGroupShapeProperties12.Append(applicationNonVisualDrawingProperties64);

            GroupShapeProperties groupShapeProperties12 = new GroupShapeProperties();

            A.TransformGroup transformGroup12 = new A.TransformGroup();
            A.Offset offset32 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents32 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset12 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents12 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup12.Append(offset32);
            transformGroup12.Append(extents32);
            transformGroup12.Append(childOffset12);
            transformGroup12.Append(childExtents12);

            groupShapeProperties12.Append(transformGroup12);

            Shape shape52 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties52 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties65 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList53 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension53 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement55 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{57707553-3656-46FB-8CCF-EAF45BD5703A}\" />");

            nonVisualDrawingPropertiesExtension53.Append(openXmlUnknownElement55);

            nonVisualDrawingPropertiesExtensionList53.Append(nonVisualDrawingPropertiesExtension53);

            nonVisualDrawingProperties65.Append(nonVisualDrawingPropertiesExtensionList53);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties52 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks52 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties52.Append(shapeLocks52);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties65 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape52 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties65.Append(placeholderShape52);

            nonVisualShapeProperties52.Append(nonVisualDrawingProperties65);
            nonVisualShapeProperties52.Append(nonVisualShapeDrawingProperties52);
            nonVisualShapeProperties52.Append(applicationNonVisualDrawingProperties65);
            ShapeProperties shapeProperties74 = new ShapeProperties();

            TextBody textBody52 = new TextBody();
            A.BodyProperties bodyProperties57 = new A.BodyProperties();
            A.ListStyle listStyle57 = new A.ListStyle();

            A.Paragraph paragraph85 = new A.Paragraph();

            A.Run run50 = new A.Run();
            A.RunProperties runProperties70 = new A.RunProperties(){ Language = "en-US" };
            A.Text text70 = new A.Text();
            text70.Text = "Click to edit Master title style";

            run50.Append(runProperties70);
            run50.Append(text70);

            paragraph85.Append(run50);

            textBody52.Append(bodyProperties57);
            textBody52.Append(listStyle57);
            textBody52.Append(paragraph85);

            shape52.Append(nonVisualShapeProperties52);
            shape52.Append(shapeProperties74);
            shape52.Append(textBody52);

            Shape shape53 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties53 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties66 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Content Placeholder 2" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList54 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension54 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement56 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{B5073DBB-E700-4463-B080-5FC9847757E1}\" />");

            nonVisualDrawingPropertiesExtension54.Append(openXmlUnknownElement56);

            nonVisualDrawingPropertiesExtensionList54.Append(nonVisualDrawingPropertiesExtension54);

            nonVisualDrawingProperties66.Append(nonVisualDrawingPropertiesExtensionList54);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties53 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks53 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties53.Append(shapeLocks53);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties66 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape53 = new PlaceholderShape(){ Size = PlaceholderSizeValues.Half, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties66.Append(placeholderShape53);

            nonVisualShapeProperties53.Append(nonVisualDrawingProperties66);
            nonVisualShapeProperties53.Append(nonVisualShapeDrawingProperties53);
            nonVisualShapeProperties53.Append(applicationNonVisualDrawingProperties66);

            ShapeProperties shapeProperties75 = new ShapeProperties();

            A.Transform2D transform2D20 = new A.Transform2D();
            A.Offset offset33 = new A.Offset(){ X = 838200L, Y = 1825625L };
            A.Extents extents33 = new A.Extents(){ Cx = 5181600L, Cy = 4351338L };

            transform2D20.Append(offset33);
            transform2D20.Append(extents33);

            shapeProperties75.Append(transform2D20);

            TextBody textBody53 = new TextBody();
            A.BodyProperties bodyProperties58 = new A.BodyProperties();
            A.ListStyle listStyle58 = new A.ListStyle();

            A.Paragraph paragraph86 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties45 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run51 = new A.Run();
            A.RunProperties runProperties71 = new A.RunProperties(){ Language = "en-US" };
            A.Text text71 = new A.Text();
            text71.Text = "Click to edit Master text styles";

            run51.Append(runProperties71);
            run51.Append(text71);

            paragraph86.Append(paragraphProperties45);
            paragraph86.Append(run51);

            A.Paragraph paragraph87 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties46 = new A.ParagraphProperties(){ Level = 1 };

            A.Run run52 = new A.Run();
            A.RunProperties runProperties72 = new A.RunProperties(){ Language = "en-US" };
            A.Text text72 = new A.Text();
            text72.Text = "Second level";

            run52.Append(runProperties72);
            run52.Append(text72);

            paragraph87.Append(paragraphProperties46);
            paragraph87.Append(run52);

            A.Paragraph paragraph88 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties47 = new A.ParagraphProperties(){ Level = 2 };

            A.Run run53 = new A.Run();
            A.RunProperties runProperties73 = new A.RunProperties(){ Language = "en-US" };
            A.Text text73 = new A.Text();
            text73.Text = "Third level";

            run53.Append(runProperties73);
            run53.Append(text73);

            paragraph88.Append(paragraphProperties47);
            paragraph88.Append(run53);

            A.Paragraph paragraph89 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties48 = new A.ParagraphProperties(){ Level = 3 };

            A.Run run54 = new A.Run();
            A.RunProperties runProperties74 = new A.RunProperties(){ Language = "en-US" };
            A.Text text74 = new A.Text();
            text74.Text = "Fourth level";

            run54.Append(runProperties74);
            run54.Append(text74);

            paragraph89.Append(paragraphProperties48);
            paragraph89.Append(run54);

            A.Paragraph paragraph90 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties49 = new A.ParagraphProperties(){ Level = 4 };

            A.Run run55 = new A.Run();
            A.RunProperties runProperties75 = new A.RunProperties(){ Language = "en-US" };
            A.Text text75 = new A.Text();
            text75.Text = "Fifth level";

            run55.Append(runProperties75);
            run55.Append(text75);

            paragraph90.Append(paragraphProperties49);
            paragraph90.Append(run55);

            textBody53.Append(bodyProperties58);
            textBody53.Append(listStyle58);
            textBody53.Append(paragraph86);
            textBody53.Append(paragraph87);
            textBody53.Append(paragraph88);
            textBody53.Append(paragraph89);
            textBody53.Append(paragraph90);

            shape53.Append(nonVisualShapeProperties53);
            shape53.Append(shapeProperties75);
            shape53.Append(textBody53);

            Shape shape54 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties54 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties67 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Content Placeholder 3" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList55 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension55 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement57 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{A3795A3C-FD7D-4B7B-A82A-0217387EF1E1}\" />");

            nonVisualDrawingPropertiesExtension55.Append(openXmlUnknownElement57);

            nonVisualDrawingPropertiesExtensionList55.Append(nonVisualDrawingPropertiesExtension55);

            nonVisualDrawingProperties67.Append(nonVisualDrawingPropertiesExtensionList55);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties54 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks54 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties54.Append(shapeLocks54);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties67 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape54 = new PlaceholderShape(){ Size = PlaceholderSizeValues.Half, Index = (UInt32Value)2U };

            applicationNonVisualDrawingProperties67.Append(placeholderShape54);

            nonVisualShapeProperties54.Append(nonVisualDrawingProperties67);
            nonVisualShapeProperties54.Append(nonVisualShapeDrawingProperties54);
            nonVisualShapeProperties54.Append(applicationNonVisualDrawingProperties67);

            ShapeProperties shapeProperties76 = new ShapeProperties();

            A.Transform2D transform2D21 = new A.Transform2D();
            A.Offset offset34 = new A.Offset(){ X = 6172200L, Y = 1825625L };
            A.Extents extents34 = new A.Extents(){ Cx = 5181600L, Cy = 4351338L };

            transform2D21.Append(offset34);
            transform2D21.Append(extents34);

            shapeProperties76.Append(transform2D21);

            TextBody textBody54 = new TextBody();
            A.BodyProperties bodyProperties59 = new A.BodyProperties();
            A.ListStyle listStyle59 = new A.ListStyle();

            A.Paragraph paragraph91 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties50 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run56 = new A.Run();
            A.RunProperties runProperties76 = new A.RunProperties(){ Language = "en-US" };
            A.Text text76 = new A.Text();
            text76.Text = "Click to edit Master text styles";

            run56.Append(runProperties76);
            run56.Append(text76);

            paragraph91.Append(paragraphProperties50);
            paragraph91.Append(run56);

            A.Paragraph paragraph92 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties51 = new A.ParagraphProperties(){ Level = 1 };

            A.Run run57 = new A.Run();
            A.RunProperties runProperties77 = new A.RunProperties(){ Language = "en-US" };
            A.Text text77 = new A.Text();
            text77.Text = "Second level";

            run57.Append(runProperties77);
            run57.Append(text77);

            paragraph92.Append(paragraphProperties51);
            paragraph92.Append(run57);

            A.Paragraph paragraph93 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties52 = new A.ParagraphProperties(){ Level = 2 };

            A.Run run58 = new A.Run();
            A.RunProperties runProperties78 = new A.RunProperties(){ Language = "en-US" };
            A.Text text78 = new A.Text();
            text78.Text = "Third level";

            run58.Append(runProperties78);
            run58.Append(text78);

            paragraph93.Append(paragraphProperties52);
            paragraph93.Append(run58);

            A.Paragraph paragraph94 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties53 = new A.ParagraphProperties(){ Level = 3 };

            A.Run run59 = new A.Run();
            A.RunProperties runProperties79 = new A.RunProperties(){ Language = "en-US" };
            A.Text text79 = new A.Text();
            text79.Text = "Fourth level";

            run59.Append(runProperties79);
            run59.Append(text79);

            paragraph94.Append(paragraphProperties53);
            paragraph94.Append(run59);

            A.Paragraph paragraph95 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties54 = new A.ParagraphProperties(){ Level = 4 };

            A.Run run60 = new A.Run();
            A.RunProperties runProperties80 = new A.RunProperties(){ Language = "en-US" };
            A.Text text80 = new A.Text();
            text80.Text = "Fifth level";

            run60.Append(runProperties80);
            run60.Append(text80);

            paragraph95.Append(paragraphProperties54);
            paragraph95.Append(run60);

            textBody54.Append(bodyProperties59);
            textBody54.Append(listStyle59);
            textBody54.Append(paragraph91);
            textBody54.Append(paragraph92);
            textBody54.Append(paragraph93);
            textBody54.Append(paragraph94);
            textBody54.Append(paragraph95);

            shape54.Append(nonVisualShapeProperties54);
            shape54.Append(shapeProperties76);
            shape54.Append(textBody54);

            Shape shape55 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties55 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties68 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Date Placeholder 4" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList56 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension56 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement58 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{0E2C3D03-DCBD-4543-92EE-6CD52A28E59D}\" />");

            nonVisualDrawingPropertiesExtension56.Append(openXmlUnknownElement58);

            nonVisualDrawingPropertiesExtensionList56.Append(nonVisualDrawingPropertiesExtension56);

            nonVisualDrawingProperties68.Append(nonVisualDrawingPropertiesExtensionList56);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties55 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks55 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties55.Append(shapeLocks55);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties68 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape55 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties68.Append(placeholderShape55);

            nonVisualShapeProperties55.Append(nonVisualDrawingProperties68);
            nonVisualShapeProperties55.Append(nonVisualShapeDrawingProperties55);
            nonVisualShapeProperties55.Append(applicationNonVisualDrawingProperties68);
            ShapeProperties shapeProperties77 = new ShapeProperties();

            TextBody textBody55 = new TextBody();
            A.BodyProperties bodyProperties60 = new A.BodyProperties();
            A.ListStyle listStyle60 = new A.ListStyle();

            A.Paragraph paragraph96 = new A.Paragraph();

            A.Field field21 = new A.Field(){ Id = "{9BEF4A3D-57C8-4DC0-86D0-95A05287C467}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties81 = new A.RunProperties(){ Language = "en-US" };
            runProperties81.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text81 = new A.Text();
            text81.Text = "1/29/2020";

            field21.Append(runProperties81);
            field21.Append(text81);
            A.EndParagraphRunProperties endParagraphRunProperties36 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph96.Append(field21);
            paragraph96.Append(endParagraphRunProperties36);

            textBody55.Append(bodyProperties60);
            textBody55.Append(listStyle60);
            textBody55.Append(paragraph96);

            shape55.Append(nonVisualShapeProperties55);
            shape55.Append(shapeProperties77);
            shape55.Append(textBody55);

            Shape shape56 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties56 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties69 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Footer Placeholder 5" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList57 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension57 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement59 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{86B27DA0-AB90-4077-8EF1-F950B9BAFC01}\" />");

            nonVisualDrawingPropertiesExtension57.Append(openXmlUnknownElement59);

            nonVisualDrawingPropertiesExtensionList57.Append(nonVisualDrawingPropertiesExtension57);

            nonVisualDrawingProperties69.Append(nonVisualDrawingPropertiesExtensionList57);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties56 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks56 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties56.Append(shapeLocks56);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties69 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape56 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties69.Append(placeholderShape56);

            nonVisualShapeProperties56.Append(nonVisualDrawingProperties69);
            nonVisualShapeProperties56.Append(nonVisualShapeDrawingProperties56);
            nonVisualShapeProperties56.Append(applicationNonVisualDrawingProperties69);
            ShapeProperties shapeProperties78 = new ShapeProperties();

            TextBody textBody56 = new TextBody();
            A.BodyProperties bodyProperties61 = new A.BodyProperties();
            A.ListStyle listStyle61 = new A.ListStyle();

            A.Paragraph paragraph97 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties37 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph97.Append(endParagraphRunProperties37);

            textBody56.Append(bodyProperties61);
            textBody56.Append(listStyle61);
            textBody56.Append(paragraph97);

            shape56.Append(nonVisualShapeProperties56);
            shape56.Append(shapeProperties78);
            shape56.Append(textBody56);

            Shape shape57 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties57 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties70 = new NonVisualDrawingProperties(){ Id = (UInt32Value)7U, Name = "Slide Number Placeholder 6" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList58 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension58 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement60 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{CDFC9041-9D02-4561-BF3F-1504ED31BF98}\" />");

            nonVisualDrawingPropertiesExtension58.Append(openXmlUnknownElement60);

            nonVisualDrawingPropertiesExtensionList58.Append(nonVisualDrawingPropertiesExtension58);

            nonVisualDrawingProperties70.Append(nonVisualDrawingPropertiesExtensionList58);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties57 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks57 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties57.Append(shapeLocks57);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties70 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape57 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties70.Append(placeholderShape57);

            nonVisualShapeProperties57.Append(nonVisualDrawingProperties70);
            nonVisualShapeProperties57.Append(nonVisualShapeDrawingProperties57);
            nonVisualShapeProperties57.Append(applicationNonVisualDrawingProperties70);
            ShapeProperties shapeProperties79 = new ShapeProperties();

            TextBody textBody57 = new TextBody();
            A.BodyProperties bodyProperties62 = new A.BodyProperties();
            A.ListStyle listStyle62 = new A.ListStyle();

            A.Paragraph paragraph98 = new A.Paragraph();

            A.Field field22 = new A.Field(){ Id = "{1BF20D12-B4E9-4886-A78D-768EA8FF95DD}", Type = "slidenum" };

            A.RunProperties runProperties82 = new A.RunProperties(){ Language = "en-US" };
            runProperties82.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text82 = new A.Text();
            text82.Text = "‹#›";

            field22.Append(runProperties82);
            field22.Append(text82);
            A.EndParagraphRunProperties endParagraphRunProperties38 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph98.Append(field22);
            paragraph98.Append(endParagraphRunProperties38);

            textBody57.Append(bodyProperties62);
            textBody57.Append(listStyle62);
            textBody57.Append(paragraph98);

            shape57.Append(nonVisualShapeProperties57);
            shape57.Append(shapeProperties79);
            shape57.Append(textBody57);

            shapeTree12.Append(nonVisualGroupShapeProperties12);
            shapeTree12.Append(groupShapeProperties12);
            shapeTree12.Append(shape52);
            shapeTree12.Append(shape53);
            shapeTree12.Append(shape54);
            shapeTree12.Append(shape55);
            shapeTree12.Append(shape56);
            shapeTree12.Append(shape57);

            CommonSlideDataExtensionList commonSlideDataExtensionList12 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension12 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId12 = new P14.CreationId(){ Val = (UInt32Value)1193241634U };
            creationId12.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension12.Append(creationId12);

            commonSlideDataExtensionList12.Append(commonSlideDataExtension12);

            commonSlideData12.Append(shapeTree12);
            commonSlideData12.Append(commonSlideDataExtensionList12);

            ColorMapOverride colorMapOverride11 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping11 = new A.MasterColorMapping();

            colorMapOverride11.Append(masterColorMapping11);

            slideLayout10.Append(commonSlideData12);
            slideLayout10.Append(colorMapOverride11);

            slideLayoutPart10.SlideLayout = slideLayout10;
        }

        // Generates content of slideLayoutPart11.
        private void GenerateSlideLayoutPart11Content(SlideLayoutPart slideLayoutPart11)
        {
            SlideLayout slideLayout11 = new SlideLayout(){ Type = SlideLayoutValues.PictureText, Preserve = true };
            slideLayout11.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout11.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout11.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData13 = new CommonSlideData(){ Name = "Picture with Caption" };

            ShapeTree shapeTree13 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties13 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties71 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties13 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties71 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties13.Append(nonVisualDrawingProperties71);
            nonVisualGroupShapeProperties13.Append(nonVisualGroupShapeDrawingProperties13);
            nonVisualGroupShapeProperties13.Append(applicationNonVisualDrawingProperties71);

            GroupShapeProperties groupShapeProperties13 = new GroupShapeProperties();

            A.TransformGroup transformGroup13 = new A.TransformGroup();
            A.Offset offset35 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents35 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset13 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents13 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup13.Append(offset35);
            transformGroup13.Append(extents35);
            transformGroup13.Append(childOffset13);
            transformGroup13.Append(childExtents13);

            groupShapeProperties13.Append(transformGroup13);

            Shape shape58 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties58 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties72 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList59 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension59 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement61 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{1EA39E7E-0F5D-46B0-9A77-67DB99D5FE6D}\" />");

            nonVisualDrawingPropertiesExtension59.Append(openXmlUnknownElement61);

            nonVisualDrawingPropertiesExtensionList59.Append(nonVisualDrawingPropertiesExtension59);

            nonVisualDrawingProperties72.Append(nonVisualDrawingPropertiesExtensionList59);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties58 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks58 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties58.Append(shapeLocks58);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties72 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape58 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties72.Append(placeholderShape58);

            nonVisualShapeProperties58.Append(nonVisualDrawingProperties72);
            nonVisualShapeProperties58.Append(nonVisualShapeDrawingProperties58);
            nonVisualShapeProperties58.Append(applicationNonVisualDrawingProperties72);

            ShapeProperties shapeProperties80 = new ShapeProperties();

            A.Transform2D transform2D22 = new A.Transform2D();
            A.Offset offset36 = new A.Offset(){ X = 839788L, Y = 457200L };
            A.Extents extents36 = new A.Extents(){ Cx = 3932237L, Cy = 1600200L };

            transform2D22.Append(offset36);
            transform2D22.Append(extents36);

            shapeProperties80.Append(transform2D22);

            TextBody textBody58 = new TextBody();
            A.BodyProperties bodyProperties63 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Bottom };

            A.ListStyle listStyle63 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties17 = new A.Level1ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties96 = new A.DefaultRunProperties(){ FontSize = 3200 };

            level1ParagraphProperties17.Append(defaultRunProperties96);

            listStyle63.Append(level1ParagraphProperties17);

            A.Paragraph paragraph99 = new A.Paragraph();

            A.Run run61 = new A.Run();
            A.RunProperties runProperties83 = new A.RunProperties(){ Language = "en-US" };
            A.Text text83 = new A.Text();
            text83.Text = "Click to edit Master title style";

            run61.Append(runProperties83);
            run61.Append(text83);

            paragraph99.Append(run61);

            textBody58.Append(bodyProperties63);
            textBody58.Append(listStyle63);
            textBody58.Append(paragraph99);

            shape58.Append(nonVisualShapeProperties58);
            shape58.Append(shapeProperties80);
            shape58.Append(textBody58);

            Shape shape59 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties59 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties73 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Picture Placeholder 2" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList60 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension60 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement62 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{C19BEB9F-E89D-4C5D-9E91-51BF229BA586}\" />");

            nonVisualDrawingPropertiesExtension60.Append(openXmlUnknownElement62);

            nonVisualDrawingPropertiesExtensionList60.Append(nonVisualDrawingPropertiesExtension60);

            nonVisualDrawingProperties73.Append(nonVisualDrawingPropertiesExtensionList60);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties59 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks59 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties59.Append(shapeLocks59);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties73 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape59 = new PlaceholderShape(){ Type = PlaceholderValues.Picture, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties73.Append(placeholderShape59);

            nonVisualShapeProperties59.Append(nonVisualDrawingProperties73);
            nonVisualShapeProperties59.Append(nonVisualShapeDrawingProperties59);
            nonVisualShapeProperties59.Append(applicationNonVisualDrawingProperties73);

            ShapeProperties shapeProperties81 = new ShapeProperties();

            A.Transform2D transform2D23 = new A.Transform2D();
            A.Offset offset37 = new A.Offset(){ X = 5183188L, Y = 987425L };
            A.Extents extents37 = new A.Extents(){ Cx = 6172200L, Cy = 4873625L };

            transform2D23.Append(offset37);
            transform2D23.Append(extents37);

            shapeProperties81.Append(transform2D23);

            TextBody textBody59 = new TextBody();
            A.BodyProperties bodyProperties64 = new A.BodyProperties();

            A.ListStyle listStyle64 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties18 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0 };
            A.NoBullet noBullet47 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties97 = new A.DefaultRunProperties(){ FontSize = 3200 };

            level1ParagraphProperties18.Append(noBullet47);
            level1ParagraphProperties18.Append(defaultRunProperties97);

            A.Level2ParagraphProperties level2ParagraphProperties10 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Indent = 0 };
            A.NoBullet noBullet48 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties98 = new A.DefaultRunProperties(){ FontSize = 2800 };

            level2ParagraphProperties10.Append(noBullet48);
            level2ParagraphProperties10.Append(defaultRunProperties98);

            A.Level3ParagraphProperties level3ParagraphProperties10 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Indent = 0 };
            A.NoBullet noBullet49 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties99 = new A.DefaultRunProperties(){ FontSize = 2400 };

            level3ParagraphProperties10.Append(noBullet49);
            level3ParagraphProperties10.Append(defaultRunProperties99);

            A.Level4ParagraphProperties level4ParagraphProperties10 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Indent = 0 };
            A.NoBullet noBullet50 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties100 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level4ParagraphProperties10.Append(noBullet50);
            level4ParagraphProperties10.Append(defaultRunProperties100);

            A.Level5ParagraphProperties level5ParagraphProperties10 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Indent = 0 };
            A.NoBullet noBullet51 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties101 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level5ParagraphProperties10.Append(noBullet51);
            level5ParagraphProperties10.Append(defaultRunProperties101);

            A.Level6ParagraphProperties level6ParagraphProperties10 = new A.Level6ParagraphProperties(){ LeftMargin = 2286000, Indent = 0 };
            A.NoBullet noBullet52 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties102 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level6ParagraphProperties10.Append(noBullet52);
            level6ParagraphProperties10.Append(defaultRunProperties102);

            A.Level7ParagraphProperties level7ParagraphProperties10 = new A.Level7ParagraphProperties(){ LeftMargin = 2743200, Indent = 0 };
            A.NoBullet noBullet53 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties103 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level7ParagraphProperties10.Append(noBullet53);
            level7ParagraphProperties10.Append(defaultRunProperties103);

            A.Level8ParagraphProperties level8ParagraphProperties10 = new A.Level8ParagraphProperties(){ LeftMargin = 3200400, Indent = 0 };
            A.NoBullet noBullet54 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties104 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level8ParagraphProperties10.Append(noBullet54);
            level8ParagraphProperties10.Append(defaultRunProperties104);

            A.Level9ParagraphProperties level9ParagraphProperties10 = new A.Level9ParagraphProperties(){ LeftMargin = 3657600, Indent = 0 };
            A.NoBullet noBullet55 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties105 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level9ParagraphProperties10.Append(noBullet55);
            level9ParagraphProperties10.Append(defaultRunProperties105);

            listStyle64.Append(level1ParagraphProperties18);
            listStyle64.Append(level2ParagraphProperties10);
            listStyle64.Append(level3ParagraphProperties10);
            listStyle64.Append(level4ParagraphProperties10);
            listStyle64.Append(level5ParagraphProperties10);
            listStyle64.Append(level6ParagraphProperties10);
            listStyle64.Append(level7ParagraphProperties10);
            listStyle64.Append(level8ParagraphProperties10);
            listStyle64.Append(level9ParagraphProperties10);

            A.Paragraph paragraph100 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties39 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph100.Append(endParagraphRunProperties39);

            textBody59.Append(bodyProperties64);
            textBody59.Append(listStyle64);
            textBody59.Append(paragraph100);

            shape59.Append(nonVisualShapeProperties59);
            shape59.Append(shapeProperties81);
            shape59.Append(textBody59);

            Shape shape60 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties60 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties74 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Text Placeholder 3" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList61 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension61 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement63 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{ED0F28C7-571C-4D8B-960E-D49DD6FB8296}\" />");

            nonVisualDrawingPropertiesExtension61.Append(openXmlUnknownElement63);

            nonVisualDrawingPropertiesExtensionList61.Append(nonVisualDrawingPropertiesExtension61);

            nonVisualDrawingProperties74.Append(nonVisualDrawingPropertiesExtensionList61);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties60 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks60 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties60.Append(shapeLocks60);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties74 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape60 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)2U };

            applicationNonVisualDrawingProperties74.Append(placeholderShape60);

            nonVisualShapeProperties60.Append(nonVisualDrawingProperties74);
            nonVisualShapeProperties60.Append(nonVisualShapeDrawingProperties60);
            nonVisualShapeProperties60.Append(applicationNonVisualDrawingProperties74);

            ShapeProperties shapeProperties82 = new ShapeProperties();

            A.Transform2D transform2D24 = new A.Transform2D();
            A.Offset offset38 = new A.Offset(){ X = 839788L, Y = 2057400L };
            A.Extents extents38 = new A.Extents(){ Cx = 3932237L, Cy = 3811588L };

            transform2D24.Append(offset38);
            transform2D24.Append(extents38);

            shapeProperties82.Append(transform2D24);

            TextBody textBody60 = new TextBody();
            A.BodyProperties bodyProperties65 = new A.BodyProperties();

            A.ListStyle listStyle65 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties19 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0 };
            A.NoBullet noBullet56 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties106 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level1ParagraphProperties19.Append(noBullet56);
            level1ParagraphProperties19.Append(defaultRunProperties106);

            A.Level2ParagraphProperties level2ParagraphProperties11 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Indent = 0 };
            A.NoBullet noBullet57 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties107 = new A.DefaultRunProperties(){ FontSize = 1400 };

            level2ParagraphProperties11.Append(noBullet57);
            level2ParagraphProperties11.Append(defaultRunProperties107);

            A.Level3ParagraphProperties level3ParagraphProperties11 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Indent = 0 };
            A.NoBullet noBullet58 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties108 = new A.DefaultRunProperties(){ FontSize = 1200 };

            level3ParagraphProperties11.Append(noBullet58);
            level3ParagraphProperties11.Append(defaultRunProperties108);

            A.Level4ParagraphProperties level4ParagraphProperties11 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Indent = 0 };
            A.NoBullet noBullet59 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties109 = new A.DefaultRunProperties(){ FontSize = 1000 };

            level4ParagraphProperties11.Append(noBullet59);
            level4ParagraphProperties11.Append(defaultRunProperties109);

            A.Level5ParagraphProperties level5ParagraphProperties11 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Indent = 0 };
            A.NoBullet noBullet60 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties110 = new A.DefaultRunProperties(){ FontSize = 1000 };

            level5ParagraphProperties11.Append(noBullet60);
            level5ParagraphProperties11.Append(defaultRunProperties110);

            A.Level6ParagraphProperties level6ParagraphProperties11 = new A.Level6ParagraphProperties(){ LeftMargin = 2286000, Indent = 0 };
            A.NoBullet noBullet61 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties111 = new A.DefaultRunProperties(){ FontSize = 1000 };

            level6ParagraphProperties11.Append(noBullet61);
            level6ParagraphProperties11.Append(defaultRunProperties111);

            A.Level7ParagraphProperties level7ParagraphProperties11 = new A.Level7ParagraphProperties(){ LeftMargin = 2743200, Indent = 0 };
            A.NoBullet noBullet62 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties112 = new A.DefaultRunProperties(){ FontSize = 1000 };

            level7ParagraphProperties11.Append(noBullet62);
            level7ParagraphProperties11.Append(defaultRunProperties112);

            A.Level8ParagraphProperties level8ParagraphProperties11 = new A.Level8ParagraphProperties(){ LeftMargin = 3200400, Indent = 0 };
            A.NoBullet noBullet63 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties113 = new A.DefaultRunProperties(){ FontSize = 1000 };

            level8ParagraphProperties11.Append(noBullet63);
            level8ParagraphProperties11.Append(defaultRunProperties113);

            A.Level9ParagraphProperties level9ParagraphProperties11 = new A.Level9ParagraphProperties(){ LeftMargin = 3657600, Indent = 0 };
            A.NoBullet noBullet64 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties114 = new A.DefaultRunProperties(){ FontSize = 1000 };

            level9ParagraphProperties11.Append(noBullet64);
            level9ParagraphProperties11.Append(defaultRunProperties114);

            listStyle65.Append(level1ParagraphProperties19);
            listStyle65.Append(level2ParagraphProperties11);
            listStyle65.Append(level3ParagraphProperties11);
            listStyle65.Append(level4ParagraphProperties11);
            listStyle65.Append(level5ParagraphProperties11);
            listStyle65.Append(level6ParagraphProperties11);
            listStyle65.Append(level7ParagraphProperties11);
            listStyle65.Append(level8ParagraphProperties11);
            listStyle65.Append(level9ParagraphProperties11);

            A.Paragraph paragraph101 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties55 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run62 = new A.Run();
            A.RunProperties runProperties84 = new A.RunProperties(){ Language = "en-US" };
            A.Text text84 = new A.Text();
            text84.Text = "Click to edit Master text styles";

            run62.Append(runProperties84);
            run62.Append(text84);

            paragraph101.Append(paragraphProperties55);
            paragraph101.Append(run62);

            textBody60.Append(bodyProperties65);
            textBody60.Append(listStyle65);
            textBody60.Append(paragraph101);

            shape60.Append(nonVisualShapeProperties60);
            shape60.Append(shapeProperties82);
            shape60.Append(textBody60);

            Shape shape61 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties61 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties75 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Date Placeholder 4" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList62 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension62 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement64 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{BAEF919C-843B-4F18-B41E-DA433306DAC4}\" />");

            nonVisualDrawingPropertiesExtension62.Append(openXmlUnknownElement64);

            nonVisualDrawingPropertiesExtensionList62.Append(nonVisualDrawingPropertiesExtension62);

            nonVisualDrawingProperties75.Append(nonVisualDrawingPropertiesExtensionList62);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties61 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks61 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties61.Append(shapeLocks61);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties75 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape61 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties75.Append(placeholderShape61);

            nonVisualShapeProperties61.Append(nonVisualDrawingProperties75);
            nonVisualShapeProperties61.Append(nonVisualShapeDrawingProperties61);
            nonVisualShapeProperties61.Append(applicationNonVisualDrawingProperties75);
            ShapeProperties shapeProperties83 = new ShapeProperties();

            TextBody textBody61 = new TextBody();
            A.BodyProperties bodyProperties66 = new A.BodyProperties();
            A.ListStyle listStyle66 = new A.ListStyle();

            A.Paragraph paragraph102 = new A.Paragraph();

            A.Field field23 = new A.Field(){ Id = "{9BEF4A3D-57C8-4DC0-86D0-95A05287C467}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties85 = new A.RunProperties(){ Language = "en-US" };
            runProperties85.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text85 = new A.Text();
            text85.Text = "1/29/2020";

            field23.Append(runProperties85);
            field23.Append(text85);
            A.EndParagraphRunProperties endParagraphRunProperties40 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph102.Append(field23);
            paragraph102.Append(endParagraphRunProperties40);

            textBody61.Append(bodyProperties66);
            textBody61.Append(listStyle66);
            textBody61.Append(paragraph102);

            shape61.Append(nonVisualShapeProperties61);
            shape61.Append(shapeProperties83);
            shape61.Append(textBody61);

            Shape shape62 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties62 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties76 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Footer Placeholder 5" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList63 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension63 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement65 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{D5969B6A-23EB-457A-BAD3-5C8A11CCC250}\" />");

            nonVisualDrawingPropertiesExtension63.Append(openXmlUnknownElement65);

            nonVisualDrawingPropertiesExtensionList63.Append(nonVisualDrawingPropertiesExtension63);

            nonVisualDrawingProperties76.Append(nonVisualDrawingPropertiesExtensionList63);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties62 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks62 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties62.Append(shapeLocks62);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties76 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape62 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties76.Append(placeholderShape62);

            nonVisualShapeProperties62.Append(nonVisualDrawingProperties76);
            nonVisualShapeProperties62.Append(nonVisualShapeDrawingProperties62);
            nonVisualShapeProperties62.Append(applicationNonVisualDrawingProperties76);
            ShapeProperties shapeProperties84 = new ShapeProperties();

            TextBody textBody62 = new TextBody();
            A.BodyProperties bodyProperties67 = new A.BodyProperties();
            A.ListStyle listStyle67 = new A.ListStyle();

            A.Paragraph paragraph103 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties41 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph103.Append(endParagraphRunProperties41);

            textBody62.Append(bodyProperties67);
            textBody62.Append(listStyle67);
            textBody62.Append(paragraph103);

            shape62.Append(nonVisualShapeProperties62);
            shape62.Append(shapeProperties84);
            shape62.Append(textBody62);

            Shape shape63 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties63 = new NonVisualShapeProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties77 = new NonVisualDrawingProperties(){ Id = (UInt32Value)7U, Name = "Slide Number Placeholder 6" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList64 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension64 = new A.NonVisualDrawingPropertiesExtension(){ Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement66 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{5B926805-3EF6-45A2-A931-C1B0FA0C62F7}\" />");

            nonVisualDrawingPropertiesExtension64.Append(openXmlUnknownElement66);

            nonVisualDrawingPropertiesExtensionList64.Append(nonVisualDrawingPropertiesExtension64);

            nonVisualDrawingProperties77.Append(nonVisualDrawingPropertiesExtensionList64);

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties63 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks63 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties63.Append(shapeLocks63);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties77 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape63 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties77.Append(placeholderShape63);

            nonVisualShapeProperties63.Append(nonVisualDrawingProperties77);
            nonVisualShapeProperties63.Append(nonVisualShapeDrawingProperties63);
            nonVisualShapeProperties63.Append(applicationNonVisualDrawingProperties77);
            ShapeProperties shapeProperties85 = new ShapeProperties();

            TextBody textBody63 = new TextBody();
            A.BodyProperties bodyProperties68 = new A.BodyProperties();
            A.ListStyle listStyle68 = new A.ListStyle();

            A.Paragraph paragraph104 = new A.Paragraph();

            A.Field field24 = new A.Field(){ Id = "{1BF20D12-B4E9-4886-A78D-768EA8FF95DD}", Type = "slidenum" };

            A.RunProperties runProperties86 = new A.RunProperties(){ Language = "en-US" };
            runProperties86.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text86 = new A.Text();
            text86.Text = "‹#›";

            field24.Append(runProperties86);
            field24.Append(text86);
            A.EndParagraphRunProperties endParagraphRunProperties42 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph104.Append(field24);
            paragraph104.Append(endParagraphRunProperties42);

            textBody63.Append(bodyProperties68);
            textBody63.Append(listStyle68);
            textBody63.Append(paragraph104);

            shape63.Append(nonVisualShapeProperties63);
            shape63.Append(shapeProperties85);
            shape63.Append(textBody63);

            shapeTree13.Append(nonVisualGroupShapeProperties13);
            shapeTree13.Append(groupShapeProperties13);
            shapeTree13.Append(shape58);
            shapeTree13.Append(shape59);
            shapeTree13.Append(shape60);
            shapeTree13.Append(shape61);
            shapeTree13.Append(shape62);
            shapeTree13.Append(shape63);

            CommonSlideDataExtensionList commonSlideDataExtensionList13 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension13 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId13 = new P14.CreationId(){ Val = (UInt32Value)3536847863U };
            creationId13.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension13.Append(creationId13);

            commonSlideDataExtensionList13.Append(commonSlideDataExtension13);

            commonSlideData13.Append(shapeTree13);
            commonSlideData13.Append(commonSlideDataExtensionList13);

            ColorMapOverride colorMapOverride12 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping12 = new A.MasterColorMapping();

            colorMapOverride12.Append(masterColorMapping12);

            slideLayout11.Append(commonSlideData13);
            slideLayout11.Append(colorMapOverride12);

            slideLayoutPart11.SlideLayout = slideLayout11;
        }

        // Generates content of tableStylesPart1.
        private void GenerateTableStylesPart1Content(TableStylesPart tableStylesPart1)
        {
            A.TableStyleList tableStyleList1 = new A.TableStyleList(){ Default = "{5C22544A-7EE6-4342-B048-85BDC9FD1C3A}" };
            tableStyleList1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            tableStylesPart1.TableStyleList = tableStyleList1;
        }

        // Generates content of viewPropertiesPart1.
        private void GenerateViewPropertiesPart1Content(ViewPropertiesPart viewPropertiesPart1)
        {
            ViewProperties viewProperties1 = new ViewProperties();
            viewProperties1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            viewProperties1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            viewProperties1.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            NormalViewProperties normalViewProperties1 = new NormalViewProperties(){ HorizontalBarState = SplitterBarStateValues.Maximized };
            RestoredLeft restoredLeft1 = new RestoredLeft(){ Size = 14993, AutoAdjust = false };
            RestoredTop restoredTop1 = new RestoredTop(){ Size = 94660 };

            normalViewProperties1.Append(restoredLeft1);
            normalViewProperties1.Append(restoredTop1);

            SlideViewProperties slideViewProperties1 = new SlideViewProperties();

            CommonSlideViewProperties commonSlideViewProperties1 = new CommonSlideViewProperties(){ SnapToGrid = false };

            CommonViewProperties commonViewProperties1 = new CommonViewProperties(){ VariableScale = true };

            ScaleFactor scaleFactor1 = new ScaleFactor();
            A.ScaleX scaleX1 = new A.ScaleX(){ Numerator = 74, Denominator = 100 };
            A.ScaleY scaleY1 = new A.ScaleY(){ Numerator = 74, Denominator = 100 };

            scaleFactor1.Append(scaleX1);
            scaleFactor1.Append(scaleY1);
            Origin origin1 = new Origin(){ X = 60L, Y = 96L };

            commonViewProperties1.Append(scaleFactor1);
            commonViewProperties1.Append(origin1);
            GuideList guideList1 = new GuideList();

            commonSlideViewProperties1.Append(commonViewProperties1);
            commonSlideViewProperties1.Append(guideList1);

            slideViewProperties1.Append(commonSlideViewProperties1);

            NotesTextViewProperties notesTextViewProperties1 = new NotesTextViewProperties();

            CommonViewProperties commonViewProperties2 = new CommonViewProperties();

            ScaleFactor scaleFactor2 = new ScaleFactor();
            A.ScaleX scaleX2 = new A.ScaleX(){ Numerator = 1, Denominator = 1 };
            A.ScaleY scaleY2 = new A.ScaleY(){ Numerator = 1, Denominator = 1 };

            scaleFactor2.Append(scaleX2);
            scaleFactor2.Append(scaleY2);
            Origin origin2 = new Origin(){ X = 0L, Y = 0L };

            commonViewProperties2.Append(scaleFactor2);
            commonViewProperties2.Append(origin2);

            notesTextViewProperties1.Append(commonViewProperties2);
            GridSpacing gridSpacing1 = new GridSpacing(){ Cx = 76200L, Cy = 76200L };

            viewProperties1.Append(normalViewProperties1);
            viewProperties1.Append(slideViewProperties1);
            viewProperties1.Append(notesTextViewProperties1);
            viewProperties1.Append(gridSpacing1);

            viewPropertiesPart1.ViewProperties = viewProperties1;
        }

        // Generates content of customFilePropertiesPart1.
        private void GenerateCustomFilePropertiesPart1Content(CustomFilePropertiesPart customFilePropertiesPart1)
        {
            Op.Properties properties1 = new Op.Properties();
            properties1.AddNamespaceDeclaration("vt", "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes");

            Op.CustomDocumentProperty customDocumentProperty1 = new Op.CustomDocumentProperty(){ FormatId = "{D5CDD505-2E9C-101B-9397-08002B2CF9AE}", PropertyId = 2, Name = "MSIP_Label_f42aa342-8706-4288-bd11-ebb85995028c_Enabled" };
            Vt.VTLPWSTR vTLPWSTR1 = new Vt.VTLPWSTR();
            vTLPWSTR1.Text = "True";

            customDocumentProperty1.Append(vTLPWSTR1);

            Op.CustomDocumentProperty customDocumentProperty2 = new Op.CustomDocumentProperty(){ FormatId = "{D5CDD505-2E9C-101B-9397-08002B2CF9AE}", PropertyId = 3, Name = "MSIP_Label_f42aa342-8706-4288-bd11-ebb85995028c_SiteId" };
            Vt.VTLPWSTR vTLPWSTR2 = new Vt.VTLPWSTR();
            vTLPWSTR2.Text = "72f988bf-86f1-41af-91ab-2d7cd011db47";

            customDocumentProperty2.Append(vTLPWSTR2);

            Op.CustomDocumentProperty customDocumentProperty3 = new Op.CustomDocumentProperty(){ FormatId = "{D5CDD505-2E9C-101B-9397-08002B2CF9AE}", PropertyId = 4, Name = "MSIP_Label_f42aa342-8706-4288-bd11-ebb85995028c_Owner" };
            Vt.VTLPWSTR vTLPWSTR3 = new Vt.VTLPWSTR();
            vTLPWSTR3.Text = "tomjebo@microsoft.com";

            customDocumentProperty3.Append(vTLPWSTR3);

            Op.CustomDocumentProperty customDocumentProperty4 = new Op.CustomDocumentProperty(){ FormatId = "{D5CDD505-2E9C-101B-9397-08002B2CF9AE}", PropertyId = 5, Name = "MSIP_Label_f42aa342-8706-4288-bd11-ebb85995028c_SetDate" };
            Vt.VTLPWSTR vTLPWSTR4 = new Vt.VTLPWSTR();
            vTLPWSTR4.Text = "2020-01-30T01:36:53.1127729Z";

            customDocumentProperty4.Append(vTLPWSTR4);

            Op.CustomDocumentProperty customDocumentProperty5 = new Op.CustomDocumentProperty(){ FormatId = "{D5CDD505-2E9C-101B-9397-08002B2CF9AE}", PropertyId = 6, Name = "MSIP_Label_f42aa342-8706-4288-bd11-ebb85995028c_Name" };
            Vt.VTLPWSTR vTLPWSTR5 = new Vt.VTLPWSTR();
            vTLPWSTR5.Text = "General";

            customDocumentProperty5.Append(vTLPWSTR5);

            Op.CustomDocumentProperty customDocumentProperty6 = new Op.CustomDocumentProperty(){ FormatId = "{D5CDD505-2E9C-101B-9397-08002B2CF9AE}", PropertyId = 7, Name = "MSIP_Label_f42aa342-8706-4288-bd11-ebb85995028c_Application" };
            Vt.VTLPWSTR vTLPWSTR6 = new Vt.VTLPWSTR();
            vTLPWSTR6.Text = "Microsoft Azure Information Protection";

            customDocumentProperty6.Append(vTLPWSTR6);

            Op.CustomDocumentProperty customDocumentProperty7 = new Op.CustomDocumentProperty(){ FormatId = "{D5CDD505-2E9C-101B-9397-08002B2CF9AE}", PropertyId = 8, Name = "MSIP_Label_f42aa342-8706-4288-bd11-ebb85995028c_ActionId" };
            Vt.VTLPWSTR vTLPWSTR7 = new Vt.VTLPWSTR();
            vTLPWSTR7.Text = "e8fae3d5-043f-453a-9c2c-29d837150092";

            customDocumentProperty7.Append(vTLPWSTR7);

            Op.CustomDocumentProperty customDocumentProperty8 = new Op.CustomDocumentProperty(){ FormatId = "{D5CDD505-2E9C-101B-9397-08002B2CF9AE}", PropertyId = 9, Name = "MSIP_Label_f42aa342-8706-4288-bd11-ebb85995028c_Extended_MSFT_Method" };
            Vt.VTLPWSTR vTLPWSTR8 = new Vt.VTLPWSTR();
            vTLPWSTR8.Text = "Automatic";

            customDocumentProperty8.Append(vTLPWSTR8);

            Op.CustomDocumentProperty customDocumentProperty9 = new Op.CustomDocumentProperty(){ FormatId = "{D5CDD505-2E9C-101B-9397-08002B2CF9AE}", PropertyId = 10, Name = "Sensitivity" };
            Vt.VTLPWSTR vTLPWSTR9 = new Vt.VTLPWSTR();
            vTLPWSTR9.Text = "General";

            customDocumentProperty9.Append(vTLPWSTR9);

            properties1.Append(customDocumentProperty1);
            properties1.Append(customDocumentProperty2);
            properties1.Append(customDocumentProperty3);
            properties1.Append(customDocumentProperty4);
            properties1.Append(customDocumentProperty5);
            properties1.Append(customDocumentProperty6);
            properties1.Append(customDocumentProperty7);
            properties1.Append(customDocumentProperty8);
            properties1.Append(customDocumentProperty9);

            customFilePropertiesPart1.Properties = properties1;
        }

        // Generates content of extendedFilePropertiesPart1.
        private void GenerateExtendedFilePropertiesPart1Content(ExtendedFilePropertiesPart extendedFilePropertiesPart1)
        {
            Ap.Properties properties2 = new Ap.Properties();
            properties2.AddNamespaceDeclaration("vt", "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes");
            Ap.TotalTime totalTime1 = new Ap.TotalTime();
            totalTime1.Text = "1";
            Ap.Words words1 = new Ap.Words();
            words1.Text = "1";
            Ap.Application application1 = new Ap.Application();
            application1.Text = "Microsoft Office PowerPoint";
            Ap.PresentationFormat presentationFormat1 = new Ap.PresentationFormat();
            presentationFormat1.Text = "Widescreen";
            Ap.Paragraphs paragraphs1 = new Ap.Paragraphs();
            paragraphs1.Text = "1";
            Ap.Slides slides1 = new Ap.Slides();
            slides1.Text = "1";
            Ap.Notes notes1 = new Ap.Notes();
            notes1.Text = "0";
            Ap.HiddenSlides hiddenSlides1 = new Ap.HiddenSlides();
            hiddenSlides1.Text = "0";
            Ap.MultimediaClips multimediaClips1 = new Ap.MultimediaClips();
            multimediaClips1.Text = "0";
            Ap.ScaleCrop scaleCrop1 = new Ap.ScaleCrop();
            scaleCrop1.Text = "false";

            Ap.HeadingPairs headingPairs1 = new Ap.HeadingPairs();

            Vt.VTVector vTVector1 = new Vt.VTVector(){ BaseType = Vt.VectorBaseValues.Variant, Size = (UInt32Value)6U };

            Vt.Variant variant1 = new Vt.Variant();
            Vt.VTLPSTR vTLPSTR1 = new Vt.VTLPSTR();
            vTLPSTR1.Text = "Fonts Used";

            variant1.Append(vTLPSTR1);

            Vt.Variant variant2 = new Vt.Variant();
            Vt.VTInt32 vTInt321 = new Vt.VTInt32();
            vTInt321.Text = "3";

            variant2.Append(vTInt321);

            Vt.Variant variant3 = new Vt.Variant();
            Vt.VTLPSTR vTLPSTR2 = new Vt.VTLPSTR();
            vTLPSTR2.Text = "Theme";

            variant3.Append(vTLPSTR2);

            Vt.Variant variant4 = new Vt.Variant();
            Vt.VTInt32 vTInt322 = new Vt.VTInt32();
            vTInt322.Text = "1";

            variant4.Append(vTInt322);

            Vt.Variant variant5 = new Vt.Variant();
            Vt.VTLPSTR vTLPSTR3 = new Vt.VTLPSTR();
            vTLPSTR3.Text = "Slide Titles";

            variant5.Append(vTLPSTR3);

            Vt.Variant variant6 = new Vt.Variant();
            Vt.VTInt32 vTInt323 = new Vt.VTInt32();
            vTInt323.Text = "1";

            variant6.Append(vTInt323);

            vTVector1.Append(variant1);
            vTVector1.Append(variant2);
            vTVector1.Append(variant3);
            vTVector1.Append(variant4);
            vTVector1.Append(variant5);
            vTVector1.Append(variant6);

            headingPairs1.Append(vTVector1);

            Ap.TitlesOfParts titlesOfParts1 = new Ap.TitlesOfParts();

            Vt.VTVector vTVector2 = new Vt.VTVector(){ BaseType = Vt.VectorBaseValues.Lpstr, Size = (UInt32Value)5U };
            Vt.VTLPSTR vTLPSTR4 = new Vt.VTLPSTR();
            vTLPSTR4.Text = "Arial";
            Vt.VTLPSTR vTLPSTR5 = new Vt.VTLPSTR();
            vTLPSTR5.Text = "Calibri";
            Vt.VTLPSTR vTLPSTR6 = new Vt.VTLPSTR();
            vTLPSTR6.Text = "Calibri Light";
            Vt.VTLPSTR vTLPSTR7 = new Vt.VTLPSTR();
            vTLPSTR7.Text = "Office Theme";
            Vt.VTLPSTR vTLPSTR8 = new Vt.VTLPSTR();
            vTLPSTR8.Text = "PowerPoint Presentation";

            vTVector2.Append(vTLPSTR4);
            vTVector2.Append(vTLPSTR5);
            vTVector2.Append(vTLPSTR6);
            vTVector2.Append(vTLPSTR7);
            vTVector2.Append(vTLPSTR8);

            titlesOfParts1.Append(vTVector2);
            Ap.LinksUpToDate linksUpToDate1 = new Ap.LinksUpToDate();
            linksUpToDate1.Text = "false";
            Ap.SharedDocument sharedDocument1 = new Ap.SharedDocument();
            sharedDocument1.Text = "false";
            Ap.HyperlinksChanged hyperlinksChanged1 = new Ap.HyperlinksChanged();
            hyperlinksChanged1.Text = "false";
            Ap.ApplicationVersion applicationVersion1 = new Ap.ApplicationVersion();
            applicationVersion1.Text = "16.0000";

            properties2.Append(totalTime1);
            properties2.Append(words1);
            properties2.Append(application1);
            properties2.Append(presentationFormat1);
            properties2.Append(paragraphs1);
            properties2.Append(slides1);
            properties2.Append(notes1);
            properties2.Append(hiddenSlides1);
            properties2.Append(multimediaClips1);
            properties2.Append(scaleCrop1);
            properties2.Append(headingPairs1);
            properties2.Append(titlesOfParts1);
            properties2.Append(linksUpToDate1);
            properties2.Append(sharedDocument1);
            properties2.Append(hyperlinksChanged1);
            properties2.Append(applicationVersion1);

            extendedFilePropertiesPart1.Properties = properties2;
        }

        private void SetPackageProperties(OpenXmlPackage document)
        {
            document.PackageProperties.Creator = "Tom Jebo";
            document.PackageProperties.Title = "PowerPoint Presentation";
            document.PackageProperties.Revision = "2";
            document.PackageProperties.Created = System.Xml.XmlConvert.ToDateTime("2020-01-30T01:35:58Z", System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
            document.PackageProperties.Modified = System.Xml.XmlConvert.ToDateTime("2020-01-30T01:52:32Z", System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
            document.PackageProperties.LastModifiedBy = "Tom Jebo";
        }

        #region Binary Data
        private string thumbnailPart1Data = "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";
        private string imagePart1Data = "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";

        private string embeddedPackagePart1Data = "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";

        private System.IO.Stream GetBinaryDataStream(string base64String)
        {
            return new System.IO.MemoryStream(System.Convert.FromBase64String(base64String));
        }

        #endregion

    }
}
