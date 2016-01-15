// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using P = DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml;
using A = DocumentFormat.OpenXml.Drawing;
using P15 = DocumentFormat.OpenXml.Office2013.PowerPoint;
using P14 = DocumentFormat.OpenXml.Office2010.PowerPoint;
using Thm15 = DocumentFormat.OpenXml.Office2013.Theme;
using Ap = DocumentFormat.OpenXml.ExtendedProperties;
using Vt = DocumentFormat.OpenXml.VariantTypes;

namespace DocumentFormat.OpenXml.Tests.PresetTransitionClass
{
    public class GeneratedDocument
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

            SlideLayoutPart slideLayoutPart1 = slidePart1.AddNewPart<SlideLayoutPart>("rId1");
            GenerateSlideLayoutPart1Content(slideLayoutPart1);

            SlideMasterPart slideMasterPart1 = slideLayoutPart1.AddNewPart<SlideMasterPart>("rId1");
            GenerateSlideMasterPart1Content(slideMasterPart1);

            SlideLayoutPart slideLayoutPart2 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId8");
            GenerateSlideLayoutPart2Content(slideLayoutPart2);

            slideLayoutPart2.AddPart(slideMasterPart1, "rId1");

            SlideLayoutPart slideLayoutPart3 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId13");
            GenerateSlideLayoutPart3Content(slideLayoutPart3);

            slideLayoutPart3.AddPart(slideMasterPart1, "rId1");

            ThemePart themePart1 = slideMasterPart1.AddNewPart<ThemePart>("rId18");
            GenerateThemePart1Content(themePart1);

            SlideLayoutPart slideLayoutPart4 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId3");
            GenerateSlideLayoutPart4Content(slideLayoutPart4);

            slideLayoutPart4.AddPart(slideMasterPart1, "rId1");

            SlideLayoutPart slideLayoutPart5 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId7");
            GenerateSlideLayoutPart5Content(slideLayoutPart5);

            slideLayoutPart5.AddPart(slideMasterPart1, "rId1");

            SlideLayoutPart slideLayoutPart6 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId12");
            GenerateSlideLayoutPart6Content(slideLayoutPart6);

            slideLayoutPart6.AddPart(slideMasterPart1, "rId1");

            SlideLayoutPart slideLayoutPart7 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId17");
            GenerateSlideLayoutPart7Content(slideLayoutPart7);

            slideLayoutPart7.AddPart(slideMasterPart1, "rId1");

            SlideLayoutPart slideLayoutPart8 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId2");
            GenerateSlideLayoutPart8Content(slideLayoutPart8);

            slideLayoutPart8.AddPart(slideMasterPart1, "rId1");

            SlideLayoutPart slideLayoutPart9 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId16");
            GenerateSlideLayoutPart9Content(slideLayoutPart9);

            slideLayoutPart9.AddPart(slideMasterPart1, "rId1");

            slideMasterPart1.AddPart(slideLayoutPart1, "rId1");

            SlideLayoutPart slideLayoutPart10 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId6");
            GenerateSlideLayoutPart10Content(slideLayoutPart10);

            slideLayoutPart10.AddPart(slideMasterPart1, "rId1");

            SlideLayoutPart slideLayoutPart11 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId11");
            GenerateSlideLayoutPart11Content(slideLayoutPart11);

            slideLayoutPart11.AddPart(slideMasterPart1, "rId1");

            SlideLayoutPart slideLayoutPart12 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId5");
            GenerateSlideLayoutPart12Content(slideLayoutPart12);

            slideLayoutPart12.AddPart(slideMasterPart1, "rId1");

            SlideLayoutPart slideLayoutPart13 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId15");
            GenerateSlideLayoutPart13Content(slideLayoutPart13);

            slideLayoutPart13.AddPart(slideMasterPart1, "rId1");

            SlideLayoutPart slideLayoutPart14 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId10");
            GenerateSlideLayoutPart14Content(slideLayoutPart14);

            slideLayoutPart14.AddPart(slideMasterPart1, "rId1");

            SlideLayoutPart slideLayoutPart15 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId4");
            GenerateSlideLayoutPart15Content(slideLayoutPart15);

            slideLayoutPart15.AddPart(slideMasterPart1, "rId1");

            SlideLayoutPart slideLayoutPart16 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId9");
            GenerateSlideLayoutPart16Content(slideLayoutPart16);

            slideLayoutPart16.AddPart(slideMasterPart1, "rId1");

            SlideLayoutPart slideLayoutPart17 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId14");
            GenerateSlideLayoutPart17Content(slideLayoutPart17);

            slideLayoutPart17.AddPart(slideMasterPart1, "rId1");

            presentationPart1.AddPart(slideMasterPart1, "rId1");

            TableStylesPart tableStylesPart1 = presentationPart1.AddNewPart<TableStylesPart>("rId6");
            GenerateTableStylesPart1Content(tableStylesPart1);

            presentationPart1.AddPart(themePart1, "rId5");

            ViewPropertiesPart viewPropertiesPart1 = presentationPart1.AddNewPart<ViewPropertiesPart>("rId4");
            GenerateViewPropertiesPart1Content(viewPropertiesPart1);

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

        // Generates content of presentationPart1.
        private void GeneratePresentationPart1Content(PresentationPart presentationPart1)
        {
            P.Presentation presentation1 = new P.Presentation(){ SaveSubsetFonts = true };
            presentation1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            presentation1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            presentation1.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            SlideMasterIdList slideMasterIdList1 = new SlideMasterIdList();
            SlideMasterId slideMasterId1 = new SlideMasterId(){ Id = (UInt32Value)2147483753U, RelationshipId = "rId1" };

            slideMasterIdList1.Append(slideMasterId1);

            SlideIdList slideIdList1 = new SlideIdList();
            SlideId slideId1 = new SlideId(){ Id = (UInt32Value)256U, RelationshipId = "rId2" };

            slideIdList1.Append(slideId1);
            SlideSize slideSize1 = new SlideSize(){ Cx = 12192000, Cy = 6858000 };
            NotesSize notesSize1 = new NotesSize(){ Cx = 6858000L, Cy = 9144000L };

            DefaultTextStyle defaultTextStyle1 = new DefaultTextStyle();

            A.DefaultParagraphProperties defaultParagraphProperties1 = new A.DefaultParagraphProperties();
            A.DefaultRunProperties defaultRunProperties1 = new A.DefaultRunProperties(){ Language = "ja-JP" };

            defaultParagraphProperties1.Append(defaultRunProperties1);

            A.Level1ParagraphProperties level1ParagraphProperties1 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties2 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 1800, Kerning = 1200 };

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

            A.DefaultRunProperties defaultRunProperties3 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 1800, Kerning = 1200 };

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

            A.DefaultRunProperties defaultRunProperties4 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 1800, Kerning = 1200 };

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

            A.DefaultRunProperties defaultRunProperties5 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 1800, Kerning = 1200 };

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

            A.DefaultRunProperties defaultRunProperties6 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 1800, Kerning = 1200 };

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

            A.DefaultRunProperties defaultRunProperties7 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 1800, Kerning = 1200 };

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

            A.DefaultRunProperties defaultRunProperties8 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 1800, Kerning = 1200 };

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

            A.DefaultRunProperties defaultRunProperties9 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 1800, Kerning = 1200 };

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

            A.DefaultRunProperties defaultRunProperties10 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 1800, Kerning = 1200 };

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

            P14.DefaultImageDpi defaultImageDpi1 = new P14.DefaultImageDpi(){ Val = (UInt32Value)220U };
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

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties1 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties1 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties1 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties1 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties1.Append(nonVisualDrawingProperties1);
            nonVisualGroupShapeProperties1.Append(nonVisualGroupShapeDrawingProperties1);
            nonVisualGroupShapeProperties1.Append(applicationNonVisualDrawingProperties1);

            GroupShapeProperties groupShapeProperties1 = new GroupShapeProperties();

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

            Shape shape1 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties1 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties2 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "タイトル 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties1 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks1 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties1.Append(shapeLocks1);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties2 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape1 = new PlaceholderShape(){ Type = PlaceholderValues.CenteredTitle };

            applicationNonVisualDrawingProperties2.Append(placeholderShape1);

            nonVisualShapeProperties1.Append(nonVisualDrawingProperties2);
            nonVisualShapeProperties1.Append(nonVisualShapeDrawingProperties1);
            nonVisualShapeProperties1.Append(applicationNonVisualDrawingProperties2);
            ShapeProperties shapeProperties1 = new ShapeProperties();

            TextBody textBody1 = new TextBody();
            A.BodyProperties bodyProperties1 = new A.BodyProperties();
            A.ListStyle listStyle1 = new A.ListStyle();

            A.Paragraph paragraph1 = new A.Paragraph();

            A.Run run1 = new A.Run();

            A.RunProperties runProperties1 = new A.RunProperties(){ Kumimoji = true, Language = "en-US", AlternativeLanguage = "ja-JP", Dirty = false };
            runProperties1.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text1 = new A.Text();
            text1.Text = "TEST";

            run1.Append(runProperties1);
            run1.Append(text1);
            A.EndParagraphRunProperties endParagraphRunProperties1 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US", Dirty = false };

            paragraph1.Append(run1);
            paragraph1.Append(endParagraphRunProperties1);

            textBody1.Append(bodyProperties1);
            textBody1.Append(listStyle1);
            textBody1.Append(paragraph1);

            shape1.Append(nonVisualShapeProperties1);
            shape1.Append(shapeProperties1);
            shape1.Append(textBody1);

            Shape shape2 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties2 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties3 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "サブタイトル 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties2 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks2 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties2.Append(shapeLocks2);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties3 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape2 = new PlaceholderShape(){ Type = PlaceholderValues.SubTitle, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties3.Append(placeholderShape2);

            nonVisualShapeProperties2.Append(nonVisualDrawingProperties3);
            nonVisualShapeProperties2.Append(nonVisualShapeDrawingProperties2);
            nonVisualShapeProperties2.Append(applicationNonVisualDrawingProperties3);
            ShapeProperties shapeProperties2 = new ShapeProperties();

            TextBody textBody2 = new TextBody();
            A.BodyProperties bodyProperties2 = new A.BodyProperties();
            A.ListStyle listStyle2 = new A.ListStyle();

            A.Paragraph paragraph2 = new A.Paragraph();

            A.Run run2 = new A.Run();

            A.RunProperties runProperties2 = new A.RunProperties(){ Kumimoji = true, Language = "en-US", AlternativeLanguage = "ja-JP", Dirty = false };
            runProperties2.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text2 = new A.Text();
            text2.Text = "Preset ";

            run2.Append(runProperties2);
            run2.Append(text2);

            A.Run run3 = new A.Run();

            A.RunProperties runProperties3 = new A.RunProperties(){ Kumimoji = true, Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties3.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text3 = new A.Text();
            text3.Text = "Transition Element…";

            run3.Append(runProperties3);
            run3.Append(text3);
            A.EndParagraphRunProperties endParagraphRunProperties2 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US", Dirty = false };

            paragraph2.Append(run2);
            paragraph2.Append(run3);
            paragraph2.Append(endParagraphRunProperties2);

            textBody2.Append(bodyProperties2);
            textBody2.Append(listStyle2);
            textBody2.Append(paragraph2);

            shape2.Append(nonVisualShapeProperties2);
            shape2.Append(shapeProperties2);
            shape2.Append(textBody2);

            shapeTree1.Append(nonVisualGroupShapeProperties1);
            shapeTree1.Append(groupShapeProperties1);
            shapeTree1.Append(shape1);
            shapeTree1.Append(shape2);

            CommonSlideDataExtensionList commonSlideDataExtensionList1 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension1 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId1 = new P14.CreationId(){ Val = (UInt32Value)392542647U };
            creationId1.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension1.Append(creationId1);

            commonSlideDataExtensionList1.Append(commonSlideDataExtension1);

            commonSlideData1.Append(shapeTree1);
            commonSlideData1.Append(commonSlideDataExtensionList1);

            ColorMapOverride colorMapOverride1 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping1 = new A.MasterColorMapping();

            colorMapOverride1.Append(masterColorMapping1);

            AlternateContent alternateContent1 = new AlternateContent();
            alternateContent1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            alternateContent1.AddNamespaceDeclaration("p15", "http://schemas.microsoft.com/office/powerpoint/2012/main");

            AlternateContentChoice alternateContentChoice1 = new AlternateContentChoice(){ Requires = "p15" };

            Transition transition1 = new Transition(){ Speed = TransitionSpeedValues.Slow, Duration = "1250" };
            transition1.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");
            P15.PresetTransition presetTransition1 = new P15.PresetTransition(){ Preset = "pageCurlDouble", InvX = true };

            transition1.Append(presetTransition1);

            alternateContentChoice1.Append(transition1);

            AlternateContentFallback alternateContentFallback1 = new AlternateContentFallback();

            Transition transition2 = new Transition(){ Speed = TransitionSpeedValues.Slow };
            FadeTransition fadeTransition1 = new FadeTransition();

            transition2.Append(fadeTransition1);

            alternateContentFallback1.Append(transition2);

            alternateContent1.Append(alternateContentChoice1);
            alternateContent1.Append(alternateContentFallback1);

            Timing timing1 = new Timing();

            TimeNodeList timeNodeList1 = new TimeNodeList();

            ParallelTimeNode parallelTimeNode1 = new ParallelTimeNode();
            CommonTimeNode commonTimeNode1 = new CommonTimeNode(){ Id = (UInt32Value)1U, Duration = "indefinite", Restart = TimeNodeRestartValues.Never, NodeType = TimeNodeValues.TmingRoot };

            parallelTimeNode1.Append(commonTimeNode1);

            timeNodeList1.Append(parallelTimeNode1);

            timing1.Append(timeNodeList1);

            slide1.Append(commonSlideData1);
            slide1.Append(colorMapOverride1);
            slide1.Append(alternateContent1);
            slide1.Append(timing1);

            slidePart1.Slide = slide1;
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

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties2 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties4 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties2 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties4 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties2.Append(nonVisualDrawingProperties4);
            nonVisualGroupShapeProperties2.Append(nonVisualGroupShapeDrawingProperties2);
            nonVisualGroupShapeProperties2.Append(applicationNonVisualDrawingProperties4);

            GroupShapeProperties groupShapeProperties2 = new GroupShapeProperties();

            A.TransformGroup transformGroup2 = new A.TransformGroup();
            A.Offset offset2 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents2 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset2 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents2 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup2.Append(offset2);
            transformGroup2.Append(extents2);
            transformGroup2.Append(childOffset2);
            transformGroup2.Append(childExtents2);

            groupShapeProperties2.Append(transformGroup2);

            Shape shape3 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties3 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties5 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties3 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks3 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties3.Append(shapeLocks3);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties5 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape3 = new PlaceholderShape(){ Type = PlaceholderValues.CenteredTitle };

            applicationNonVisualDrawingProperties5.Append(placeholderShape3);

            nonVisualShapeProperties3.Append(nonVisualDrawingProperties5);
            nonVisualShapeProperties3.Append(nonVisualShapeDrawingProperties3);
            nonVisualShapeProperties3.Append(applicationNonVisualDrawingProperties5);

            ShapeProperties shapeProperties3 = new ShapeProperties();

            A.Transform2D transform2D1 = new A.Transform2D();
            A.Offset offset3 = new A.Offset(){ X = 684390L, Y = 685800L };
            A.Extents extents3 = new A.Extents(){ Cx = 8003084L, Cy = 2971801L };

            transform2D1.Append(offset3);
            transform2D1.Append(extents3);

            shapeProperties3.Append(transform2D1);

            TextBody textBody3 = new TextBody();

            A.BodyProperties bodyProperties3 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Bottom };
            A.NormalAutoFit normalAutoFit1 = new A.NormalAutoFit();

            bodyProperties3.Append(normalAutoFit1);

            A.ListStyle listStyle3 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties2 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Left };

            A.DefaultRunProperties defaultRunProperties11 = new A.DefaultRunProperties(){ FontSize = 4800 };
            A.EffectList effectList1 = new A.EffectList();

            defaultRunProperties11.Append(effectList1);

            level1ParagraphProperties2.Append(defaultRunProperties11);

            listStyle3.Append(level1ParagraphProperties2);

            A.Paragraph paragraph3 = new A.Paragraph();

            A.Run run4 = new A.Run();

            A.RunProperties runProperties4 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties4.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text4 = new A.Text();
            text4.Text = "Click to edit Master title style";

            run4.Append(runProperties4);
            run4.Append(text4);
            A.EndParagraphRunProperties endParagraphRunProperties3 = new A.EndParagraphRunProperties(){ Language = "en-US", Dirty = false };

            paragraph3.Append(run4);
            paragraph3.Append(endParagraphRunProperties3);

            textBody3.Append(bodyProperties3);
            textBody3.Append(listStyle3);
            textBody3.Append(paragraph3);

            shape3.Append(nonVisualShapeProperties3);
            shape3.Append(shapeProperties3);
            shape3.Append(textBody3);

            Shape shape4 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties4 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties6 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Subtitle 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties4 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks4 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties4.Append(shapeLocks4);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties6 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape4 = new PlaceholderShape(){ Type = PlaceholderValues.SubTitle, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties6.Append(placeholderShape4);

            nonVisualShapeProperties4.Append(nonVisualDrawingProperties6);
            nonVisualShapeProperties4.Append(nonVisualShapeDrawingProperties4);
            nonVisualShapeProperties4.Append(applicationNonVisualDrawingProperties6);

            ShapeProperties shapeProperties4 = new ShapeProperties();

            A.Transform2D transform2D2 = new A.Transform2D();
            A.Offset offset4 = new A.Offset(){ X = 684390L, Y = 3843868L };
            A.Extents extents4 = new A.Extents(){ Cx = 6402467L, Cy = 1947333L };

            transform2D2.Append(offset4);
            transform2D2.Append(extents4);

            shapeProperties4.Append(transform2D2);

            TextBody textBody4 = new TextBody();

            A.BodyProperties bodyProperties4 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Top };
            A.NormalAutoFit normalAutoFit2 = new A.NormalAutoFit();

            bodyProperties4.Append(normalAutoFit2);

            A.ListStyle listStyle4 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties3 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0, Alignment = A.TextAlignmentTypeValues.Left };
            A.NoBullet noBullet1 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties12 = new A.DefaultRunProperties(){ FontSize = 2100 };

            A.SolidFill solidFill10 = new A.SolidFill();

            A.SchemeColor schemeColor10 = new A.SchemeColor(){ Val = A.SchemeColorValues.Background2 };
            A.LuminanceModulation luminanceModulation1 = new A.LuminanceModulation(){ Val = 75000 };

            schemeColor10.Append(luminanceModulation1);

            solidFill10.Append(schemeColor10);

            defaultRunProperties12.Append(solidFill10);

            level1ParagraphProperties3.Append(noBullet1);
            level1ParagraphProperties3.Append(defaultRunProperties12);

            A.Level2ParagraphProperties level2ParagraphProperties2 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet2 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties13 = new A.DefaultRunProperties();

            A.SolidFill solidFill11 = new A.SolidFill();

            A.SchemeColor schemeColor11 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint1 = new A.Tint(){ Val = 75000 };

            schemeColor11.Append(tint1);

            solidFill11.Append(schemeColor11);

            defaultRunProperties13.Append(solidFill11);

            level2ParagraphProperties2.Append(noBullet2);
            level2ParagraphProperties2.Append(defaultRunProperties13);

            A.Level3ParagraphProperties level3ParagraphProperties2 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet3 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties14 = new A.DefaultRunProperties();

            A.SolidFill solidFill12 = new A.SolidFill();

            A.SchemeColor schemeColor12 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint2 = new A.Tint(){ Val = 75000 };

            schemeColor12.Append(tint2);

            solidFill12.Append(schemeColor12);

            defaultRunProperties14.Append(solidFill12);

            level3ParagraphProperties2.Append(noBullet3);
            level3ParagraphProperties2.Append(defaultRunProperties14);

            A.Level4ParagraphProperties level4ParagraphProperties2 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet4 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties15 = new A.DefaultRunProperties();

            A.SolidFill solidFill13 = new A.SolidFill();

            A.SchemeColor schemeColor13 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint3 = new A.Tint(){ Val = 75000 };

            schemeColor13.Append(tint3);

            solidFill13.Append(schemeColor13);

            defaultRunProperties15.Append(solidFill13);

            level4ParagraphProperties2.Append(noBullet4);
            level4ParagraphProperties2.Append(defaultRunProperties15);

            A.Level5ParagraphProperties level5ParagraphProperties2 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet5 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties16 = new A.DefaultRunProperties();

            A.SolidFill solidFill14 = new A.SolidFill();

            A.SchemeColor schemeColor14 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint4 = new A.Tint(){ Val = 75000 };

            schemeColor14.Append(tint4);

            solidFill14.Append(schemeColor14);

            defaultRunProperties16.Append(solidFill14);

            level5ParagraphProperties2.Append(noBullet5);
            level5ParagraphProperties2.Append(defaultRunProperties16);

            A.Level6ParagraphProperties level6ParagraphProperties2 = new A.Level6ParagraphProperties(){ LeftMargin = 2286000, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet6 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties17 = new A.DefaultRunProperties();

            A.SolidFill solidFill15 = new A.SolidFill();

            A.SchemeColor schemeColor15 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint5 = new A.Tint(){ Val = 75000 };

            schemeColor15.Append(tint5);

            solidFill15.Append(schemeColor15);

            defaultRunProperties17.Append(solidFill15);

            level6ParagraphProperties2.Append(noBullet6);
            level6ParagraphProperties2.Append(defaultRunProperties17);

            A.Level7ParagraphProperties level7ParagraphProperties2 = new A.Level7ParagraphProperties(){ LeftMargin = 2743200, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet7 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties18 = new A.DefaultRunProperties();

            A.SolidFill solidFill16 = new A.SolidFill();

            A.SchemeColor schemeColor16 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint6 = new A.Tint(){ Val = 75000 };

            schemeColor16.Append(tint6);

            solidFill16.Append(schemeColor16);

            defaultRunProperties18.Append(solidFill16);

            level7ParagraphProperties2.Append(noBullet7);
            level7ParagraphProperties2.Append(defaultRunProperties18);

            A.Level8ParagraphProperties level8ParagraphProperties2 = new A.Level8ParagraphProperties(){ LeftMargin = 3200400, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet8 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties19 = new A.DefaultRunProperties();

            A.SolidFill solidFill17 = new A.SolidFill();

            A.SchemeColor schemeColor17 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint7 = new A.Tint(){ Val = 75000 };

            schemeColor17.Append(tint7);

            solidFill17.Append(schemeColor17);

            defaultRunProperties19.Append(solidFill17);

            level8ParagraphProperties2.Append(noBullet8);
            level8ParagraphProperties2.Append(defaultRunProperties19);

            A.Level9ParagraphProperties level9ParagraphProperties2 = new A.Level9ParagraphProperties(){ LeftMargin = 3657600, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet9 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties20 = new A.DefaultRunProperties();

            A.SolidFill solidFill18 = new A.SolidFill();

            A.SchemeColor schemeColor18 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint8 = new A.Tint(){ Val = 75000 };

            schemeColor18.Append(tint8);

            solidFill18.Append(schemeColor18);

            defaultRunProperties20.Append(solidFill18);

            level9ParagraphProperties2.Append(noBullet9);
            level9ParagraphProperties2.Append(defaultRunProperties20);

            listStyle4.Append(level1ParagraphProperties3);
            listStyle4.Append(level2ParagraphProperties2);
            listStyle4.Append(level3ParagraphProperties2);
            listStyle4.Append(level4ParagraphProperties2);
            listStyle4.Append(level5ParagraphProperties2);
            listStyle4.Append(level6ParagraphProperties2);
            listStyle4.Append(level7ParagraphProperties2);
            listStyle4.Append(level8ParagraphProperties2);
            listStyle4.Append(level9ParagraphProperties2);

            A.Paragraph paragraph4 = new A.Paragraph();

            A.Run run5 = new A.Run();

            A.RunProperties runProperties5 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties5.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text5 = new A.Text();
            text5.Text = "Click to edit Master subtitle style";

            run5.Append(runProperties5);
            run5.Append(text5);
            A.EndParagraphRunProperties endParagraphRunProperties4 = new A.EndParagraphRunProperties(){ Language = "en-US", Dirty = false };

            paragraph4.Append(run5);
            paragraph4.Append(endParagraphRunProperties4);

            textBody4.Append(bodyProperties4);
            textBody4.Append(listStyle4);
            textBody4.Append(paragraph4);

            shape4.Append(nonVisualShapeProperties4);
            shape4.Append(shapeProperties4);
            shape4.Append(textBody4);

            Shape shape5 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties5 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties7 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Date Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties5 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks5 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties5.Append(shapeLocks5);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties7 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape5 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties7.Append(placeholderShape5);

            nonVisualShapeProperties5.Append(nonVisualDrawingProperties7);
            nonVisualShapeProperties5.Append(nonVisualShapeDrawingProperties5);
            nonVisualShapeProperties5.Append(applicationNonVisualDrawingProperties7);
            ShapeProperties shapeProperties5 = new ShapeProperties();

            TextBody textBody5 = new TextBody();
            A.BodyProperties bodyProperties5 = new A.BodyProperties();
            A.ListStyle listStyle5 = new A.ListStyle();

            A.Paragraph paragraph5 = new A.Paragraph();

            A.Field field1 = new A.Field(){ Id = "{CE1A2D98-1BBD-4706-A118-AAC2A16BEAD3}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties6 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties6.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text6 = new A.Text();
            text6.Text = "2012/10/3";

            field1.Append(runProperties6);
            field1.Append(text6);
            A.EndParagraphRunProperties endParagraphRunProperties5 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph5.Append(field1);
            paragraph5.Append(endParagraphRunProperties5);

            textBody5.Append(bodyProperties5);
            textBody5.Append(listStyle5);
            textBody5.Append(paragraph5);

            shape5.Append(nonVisualShapeProperties5);
            shape5.Append(shapeProperties5);
            shape5.Append(textBody5);

            Shape shape6 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties6 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties8 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Footer Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties6 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks6 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties6.Append(shapeLocks6);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties8 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape6 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties8.Append(placeholderShape6);

            nonVisualShapeProperties6.Append(nonVisualDrawingProperties8);
            nonVisualShapeProperties6.Append(nonVisualShapeDrawingProperties6);
            nonVisualShapeProperties6.Append(applicationNonVisualDrawingProperties8);
            ShapeProperties shapeProperties6 = new ShapeProperties();

            TextBody textBody6 = new TextBody();
            A.BodyProperties bodyProperties6 = new A.BodyProperties();
            A.ListStyle listStyle6 = new A.ListStyle();

            A.Paragraph paragraph6 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties6 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph6.Append(endParagraphRunProperties6);

            textBody6.Append(bodyProperties6);
            textBody6.Append(listStyle6);
            textBody6.Append(paragraph6);

            shape6.Append(nonVisualShapeProperties6);
            shape6.Append(shapeProperties6);
            shape6.Append(textBody6);

            Shape shape7 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties7 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties9 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Slide Number Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties7 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks7 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties7.Append(shapeLocks7);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties9 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape7 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties9.Append(placeholderShape7);

            nonVisualShapeProperties7.Append(nonVisualDrawingProperties9);
            nonVisualShapeProperties7.Append(nonVisualShapeDrawingProperties7);
            nonVisualShapeProperties7.Append(applicationNonVisualDrawingProperties9);
            ShapeProperties shapeProperties7 = new ShapeProperties();

            TextBody textBody7 = new TextBody();
            A.BodyProperties bodyProperties7 = new A.BodyProperties();
            A.ListStyle listStyle7 = new A.ListStyle();

            A.Paragraph paragraph7 = new A.Paragraph();

            A.Field field2 = new A.Field(){ Id = "{D107CD50-7081-433F-A1F2-156B4E14F4F4}", Type = "slidenum" };

            A.RunProperties runProperties7 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties7.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text7 = new A.Text();
            text7.Text = "‹#›";

            field2.Append(runProperties7);
            field2.Append(text7);
            A.EndParagraphRunProperties endParagraphRunProperties7 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph7.Append(field2);
            paragraph7.Append(endParagraphRunProperties7);

            textBody7.Append(bodyProperties7);
            textBody7.Append(listStyle7);
            textBody7.Append(paragraph7);

            shape7.Append(nonVisualShapeProperties7);
            shape7.Append(shapeProperties7);
            shape7.Append(textBody7);

            ConnectionShape connectionShape1 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties1 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties10 = new NonVisualDrawingProperties(){ Id = (UInt32Value)16U, Name = "Straight Connector 15" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties1 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties10 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties1.Append(nonVisualDrawingProperties10);
            nonVisualConnectionShapeProperties1.Append(nonVisualConnectorShapeDrawingProperties1);
            nonVisualConnectionShapeProperties1.Append(applicationNonVisualDrawingProperties10);

            ShapeProperties shapeProperties8 = new ShapeProperties();

            A.Transform2D transform2D3 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset5 = new A.Offset(){ X = 8230155L, Y = 8467L };
            A.Extents extents5 = new A.Extents(){ Cx = 3810992L, Cy = 3810000L };

            transform2D3.Append(offset5);
            transform2D3.Append(extents5);

            A.PresetGeometry presetGeometry1 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList1 = new A.AdjustValueList();

            presetGeometry1.Append(adjustValueList1);

            A.Outline outline1 = new A.Outline(){ Width = 12700 };

            A.SolidFill solidFill19 = new A.SolidFill();
            A.SchemeColor schemeColor19 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill19.Append(schemeColor19);

            outline1.Append(solidFill19);

            shapeProperties8.Append(transform2D3);
            shapeProperties8.Append(presetGeometry1);
            shapeProperties8.Append(outline1);

            ShapeStyle shapeStyle1 = new ShapeStyle();

            A.LineReference lineReference1 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor20 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference1.Append(schemeColor20);

            A.FillReference fillReference1 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor21 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference1.Append(schemeColor21);

            A.EffectReference effectReference1 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor22 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference1.Append(schemeColor22);

            A.FontReference fontReference1 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor23 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference1.Append(schemeColor23);

            shapeStyle1.Append(lineReference1);
            shapeStyle1.Append(fillReference1);
            shapeStyle1.Append(effectReference1);
            shapeStyle1.Append(fontReference1);

            connectionShape1.Append(nonVisualConnectionShapeProperties1);
            connectionShape1.Append(shapeProperties8);
            connectionShape1.Append(shapeStyle1);

            ConnectionShape connectionShape2 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties2 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties11 = new NonVisualDrawingProperties(){ Id = (UInt32Value)17U, Name = "Straight Connector 16" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties2 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties11 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties2.Append(nonVisualDrawingProperties11);
            nonVisualConnectionShapeProperties2.Append(nonVisualConnectorShapeDrawingProperties2);
            nonVisualConnectionShapeProperties2.Append(applicationNonVisualDrawingProperties11);

            ShapeProperties shapeProperties9 = new ShapeProperties();

            A.Transform2D transform2D4 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset6 = new A.Offset(){ X = 6109762L, Y = 91546L };
            A.Extents extents6 = new A.Extents(){ Cx = 6082239L, Cy = 6080655L };

            transform2D4.Append(offset6);
            transform2D4.Append(extents6);

            A.PresetGeometry presetGeometry2 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList2 = new A.AdjustValueList();

            presetGeometry2.Append(adjustValueList2);

            A.Outline outline2 = new A.Outline(){ Width = 12700 };

            A.SolidFill solidFill20 = new A.SolidFill();
            A.SchemeColor schemeColor24 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill20.Append(schemeColor24);

            outline2.Append(solidFill20);

            shapeProperties9.Append(transform2D4);
            shapeProperties9.Append(presetGeometry2);
            shapeProperties9.Append(outline2);

            ShapeStyle shapeStyle2 = new ShapeStyle();

            A.LineReference lineReference2 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor25 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference2.Append(schemeColor25);

            A.FillReference fillReference2 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor26 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference2.Append(schemeColor26);

            A.EffectReference effectReference2 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor27 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference2.Append(schemeColor27);

            A.FontReference fontReference2 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor28 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference2.Append(schemeColor28);

            shapeStyle2.Append(lineReference2);
            shapeStyle2.Append(fillReference2);
            shapeStyle2.Append(effectReference2);
            shapeStyle2.Append(fontReference2);

            connectionShape2.Append(nonVisualConnectionShapeProperties2);
            connectionShape2.Append(shapeProperties9);
            connectionShape2.Append(shapeStyle2);

            ConnectionShape connectionShape3 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties3 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties12 = new NonVisualDrawingProperties(){ Id = (UInt32Value)19U, Name = "Straight Connector 18" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties3 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties12 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties3.Append(nonVisualDrawingProperties12);
            nonVisualConnectionShapeProperties3.Append(nonVisualConnectorShapeDrawingProperties3);
            nonVisualConnectionShapeProperties3.Append(applicationNonVisualDrawingProperties12);

            ShapeProperties shapeProperties10 = new ShapeProperties();

            A.Transform2D transform2D5 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset7 = new A.Offset(){ X = 7237710L, Y = 228600L };
            A.Extents extents7 = new A.Extents(){ Cx = 4954290L, Cy = 4953000L };

            transform2D5.Append(offset7);
            transform2D5.Append(extents7);

            A.PresetGeometry presetGeometry3 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList3 = new A.AdjustValueList();

            presetGeometry3.Append(adjustValueList3);

            A.Outline outline3 = new A.Outline(){ Width = 12700 };

            A.SolidFill solidFill21 = new A.SolidFill();
            A.SchemeColor schemeColor29 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill21.Append(schemeColor29);

            outline3.Append(solidFill21);

            shapeProperties10.Append(transform2D5);
            shapeProperties10.Append(presetGeometry3);
            shapeProperties10.Append(outline3);

            ShapeStyle shapeStyle3 = new ShapeStyle();

            A.LineReference lineReference3 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor30 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference3.Append(schemeColor30);

            A.FillReference fillReference3 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor31 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference3.Append(schemeColor31);

            A.EffectReference effectReference3 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor32 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference3.Append(schemeColor32);

            A.FontReference fontReference3 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor33 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference3.Append(schemeColor33);

            shapeStyle3.Append(lineReference3);
            shapeStyle3.Append(fillReference3);
            shapeStyle3.Append(effectReference3);
            shapeStyle3.Append(fontReference3);

            connectionShape3.Append(nonVisualConnectionShapeProperties3);
            connectionShape3.Append(shapeProperties10);
            connectionShape3.Append(shapeStyle3);

            ConnectionShape connectionShape4 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties4 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties13 = new NonVisualDrawingProperties(){ Id = (UInt32Value)21U, Name = "Straight Connector 20" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties4 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties13 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties4.Append(nonVisualDrawingProperties13);
            nonVisualConnectionShapeProperties4.Append(nonVisualConnectorShapeDrawingProperties4);
            nonVisualConnectionShapeProperties4.Append(applicationNonVisualDrawingProperties13);

            ShapeProperties shapeProperties11 = new ShapeProperties();

            A.Transform2D transform2D6 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset8 = new A.Offset(){ X = 7337748L, Y = 32279L };
            A.Extents extents8 = new A.Extents(){ Cx = 4854253L, Cy = 4852989L };

            transform2D6.Append(offset8);
            transform2D6.Append(extents8);

            A.PresetGeometry presetGeometry4 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList4 = new A.AdjustValueList();

            presetGeometry4.Append(adjustValueList4);

            A.Outline outline4 = new A.Outline(){ Width = 31750 };

            A.SolidFill solidFill22 = new A.SolidFill();
            A.SchemeColor schemeColor34 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill22.Append(schemeColor34);

            outline4.Append(solidFill22);

            shapeProperties11.Append(transform2D6);
            shapeProperties11.Append(presetGeometry4);
            shapeProperties11.Append(outline4);

            ShapeStyle shapeStyle4 = new ShapeStyle();

            A.LineReference lineReference4 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor35 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference4.Append(schemeColor35);

            A.FillReference fillReference4 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor36 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference4.Append(schemeColor36);

            A.EffectReference effectReference4 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor37 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference4.Append(schemeColor37);

            A.FontReference fontReference4 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor38 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference4.Append(schemeColor38);

            shapeStyle4.Append(lineReference4);
            shapeStyle4.Append(fillReference4);
            shapeStyle4.Append(effectReference4);
            shapeStyle4.Append(fontReference4);

            connectionShape4.Append(nonVisualConnectionShapeProperties4);
            connectionShape4.Append(shapeProperties11);
            connectionShape4.Append(shapeStyle4);

            ConnectionShape connectionShape5 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties5 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties14 = new NonVisualDrawingProperties(){ Id = (UInt32Value)23U, Name = "Straight Connector 22" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties5 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties14 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties5.Append(nonVisualDrawingProperties14);
            nonVisualConnectionShapeProperties5.Append(nonVisualConnectorShapeDrawingProperties5);
            nonVisualConnectionShapeProperties5.Append(applicationNonVisualDrawingProperties14);

            ShapeProperties shapeProperties12 = new ShapeProperties();

            A.Transform2D transform2D7 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset9 = new A.Offset(){ X = 7847470L, Y = 609602L };
            A.Extents extents9 = new A.Extents(){ Cx = 4344530L, Cy = 4343399L };

            transform2D7.Append(offset9);
            transform2D7.Append(extents9);

            A.PresetGeometry presetGeometry5 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList5 = new A.AdjustValueList();

            presetGeometry5.Append(adjustValueList5);

            A.Outline outline5 = new A.Outline(){ Width = 31750 };

            A.SolidFill solidFill23 = new A.SolidFill();
            A.SchemeColor schemeColor39 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill23.Append(schemeColor39);

            outline5.Append(solidFill23);

            shapeProperties12.Append(transform2D7);
            shapeProperties12.Append(presetGeometry5);
            shapeProperties12.Append(outline5);

            ShapeStyle shapeStyle5 = new ShapeStyle();

            A.LineReference lineReference5 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor40 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference5.Append(schemeColor40);

            A.FillReference fillReference5 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor41 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference5.Append(schemeColor41);

            A.EffectReference effectReference5 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor42 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference5.Append(schemeColor42);

            A.FontReference fontReference5 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor43 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference5.Append(schemeColor43);

            shapeStyle5.Append(lineReference5);
            shapeStyle5.Append(fillReference5);
            shapeStyle5.Append(effectReference5);
            shapeStyle5.Append(fontReference5);

            connectionShape5.Append(nonVisualConnectionShapeProperties5);
            connectionShape5.Append(shapeProperties12);
            connectionShape5.Append(shapeStyle5);

            shapeTree2.Append(nonVisualGroupShapeProperties2);
            shapeTree2.Append(groupShapeProperties2);
            shapeTree2.Append(shape3);
            shapeTree2.Append(shape4);
            shapeTree2.Append(shape5);
            shapeTree2.Append(shape6);
            shapeTree2.Append(shape7);
            shapeTree2.Append(connectionShape1);
            shapeTree2.Append(connectionShape2);
            shapeTree2.Append(connectionShape3);
            shapeTree2.Append(connectionShape4);
            shapeTree2.Append(connectionShape5);

            CommonSlideDataExtensionList commonSlideDataExtensionList2 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension2 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId2 = new P14.CreationId(){ Val = (UInt32Value)1103893286U };
            creationId2.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension2.Append(creationId2);

            commonSlideDataExtensionList2.Append(commonSlideDataExtension2);

            commonSlideData2.Append(shapeTree2);
            commonSlideData2.Append(commonSlideDataExtensionList2);

            ColorMapOverride colorMapOverride2 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping2 = new A.MasterColorMapping();

            colorMapOverride2.Append(masterColorMapping2);

            Timing timing2 = new Timing();

            TimeNodeList timeNodeList2 = new TimeNodeList();

            ParallelTimeNode parallelTimeNode2 = new ParallelTimeNode();
            CommonTimeNode commonTimeNode2 = new CommonTimeNode(){ Id = (UInt32Value)1U, Duration = "indefinite", Restart = TimeNodeRestartValues.Never, NodeType = TimeNodeValues.TmingRoot };

            parallelTimeNode2.Append(commonTimeNode2);

            timeNodeList2.Append(parallelTimeNode2);

            timing2.Append(timeNodeList2);

            slideLayout1.Append(commonSlideData2);
            slideLayout1.Append(colorMapOverride2);
            slideLayout1.Append(timing2);

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

            BackgroundStyleReference backgroundStyleReference1 = new BackgroundStyleReference(){ Index = (UInt32Value)1002U };
            A.SchemeColor schemeColor44 = new A.SchemeColor(){ Val = A.SchemeColorValues.Background2 };

            backgroundStyleReference1.Append(schemeColor44);

            background1.Append(backgroundStyleReference1);

            ShapeTree shapeTree3 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties3 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties15 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties3 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties15 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties3.Append(nonVisualDrawingProperties15);
            nonVisualGroupShapeProperties3.Append(nonVisualGroupShapeDrawingProperties3);
            nonVisualGroupShapeProperties3.Append(applicationNonVisualDrawingProperties15);

            GroupShapeProperties groupShapeProperties3 = new GroupShapeProperties();

            A.TransformGroup transformGroup3 = new A.TransformGroup();
            A.Offset offset10 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents10 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset3 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents3 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup3.Append(offset10);
            transformGroup3.Append(extents10);
            transformGroup3.Append(childOffset3);
            transformGroup3.Append(childExtents3);

            groupShapeProperties3.Append(transformGroup3);

            Shape shape8 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties8 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties16 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title Placeholder 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties8 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks8 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties8.Append(shapeLocks8);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties16 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape8 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties16.Append(placeholderShape8);

            nonVisualShapeProperties8.Append(nonVisualDrawingProperties16);
            nonVisualShapeProperties8.Append(nonVisualShapeDrawingProperties8);
            nonVisualShapeProperties8.Append(applicationNonVisualDrawingProperties16);

            ShapeProperties shapeProperties13 = new ShapeProperties();

            A.Transform2D transform2D8 = new A.Transform2D();
            A.Offset offset11 = new A.Offset(){ X = 684390L, Y = 4487333L };
            A.Extents extents11 = new A.Extents(){ Cx = 8536623L, Cy = 1507067L };

            transform2D8.Append(offset11);
            transform2D8.Append(extents11);

            A.PresetGeometry presetGeometry6 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList6 = new A.AdjustValueList();

            presetGeometry6.Append(adjustValueList6);
            A.EffectList effectList2 = new A.EffectList();

            shapeProperties13.Append(transform2D8);
            shapeProperties13.Append(presetGeometry6);
            shapeProperties13.Append(effectList2);

            TextBody textBody8 = new TextBody();

            A.BodyProperties bodyProperties8 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal, LeftInset = 91440, TopInset = 45720, RightInset = 91440, BottomInset = 45720, RightToLeftColumns = false, Anchor = A.TextAnchoringTypeValues.Center };
            A.NormalAutoFit normalAutoFit3 = new A.NormalAutoFit();

            bodyProperties8.Append(normalAutoFit3);
            A.ListStyle listStyle8 = new A.ListStyle();

            A.Paragraph paragraph8 = new A.Paragraph();

            A.Run run6 = new A.Run();

            A.RunProperties runProperties8 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties8.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text8 = new A.Text();
            text8.Text = "Click to edit Master title style";

            run6.Append(runProperties8);
            run6.Append(text8);
            A.EndParagraphRunProperties endParagraphRunProperties8 = new A.EndParagraphRunProperties(){ Language = "en-US", Dirty = false };

            paragraph8.Append(run6);
            paragraph8.Append(endParagraphRunProperties8);

            textBody8.Append(bodyProperties8);
            textBody8.Append(listStyle8);
            textBody8.Append(paragraph8);

            shape8.Append(nonVisualShapeProperties8);
            shape8.Append(shapeProperties13);
            shape8.Append(textBody8);

            Shape shape9 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties9 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties17 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Text Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties9 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks9 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties9.Append(shapeLocks9);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties17 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape9 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties17.Append(placeholderShape9);

            nonVisualShapeProperties9.Append(nonVisualDrawingProperties17);
            nonVisualShapeProperties9.Append(nonVisualShapeDrawingProperties9);
            nonVisualShapeProperties9.Append(applicationNonVisualDrawingProperties17);

            ShapeProperties shapeProperties14 = new ShapeProperties();

            A.Transform2D transform2D9 = new A.Transform2D();
            A.Offset offset12 = new A.Offset(){ X = 684390L, Y = 685801L };
            A.Extents extents12 = new A.Extents(){ Cx = 8536623L, Cy = 3615267L };

            transform2D9.Append(offset12);
            transform2D9.Append(extents12);

            A.PresetGeometry presetGeometry7 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList7 = new A.AdjustValueList();

            presetGeometry7.Append(adjustValueList7);

            shapeProperties14.Append(transform2D9);
            shapeProperties14.Append(presetGeometry7);

            TextBody textBody9 = new TextBody();

            A.BodyProperties bodyProperties9 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal, LeftInset = 91440, TopInset = 45720, RightInset = 91440, BottomInset = 45720, RightToLeftColumns = false, Anchor = A.TextAnchoringTypeValues.Center };
            A.NormalAutoFit normalAutoFit4 = new A.NormalAutoFit();

            bodyProperties9.Append(normalAutoFit4);
            A.ListStyle listStyle9 = new A.ListStyle();

            A.Paragraph paragraph9 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties1 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run7 = new A.Run();

            A.RunProperties runProperties9 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties9.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text9 = new A.Text();
            text9.Text = "Click to edit Master text styles";

            run7.Append(runProperties9);
            run7.Append(text9);

            paragraph9.Append(paragraphProperties1);
            paragraph9.Append(run7);

            A.Paragraph paragraph10 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties2 = new A.ParagraphProperties(){ Level = 1 };

            A.Run run8 = new A.Run();

            A.RunProperties runProperties10 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties10.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text10 = new A.Text();
            text10.Text = "Second level";

            run8.Append(runProperties10);
            run8.Append(text10);

            paragraph10.Append(paragraphProperties2);
            paragraph10.Append(run8);

            A.Paragraph paragraph11 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties3 = new A.ParagraphProperties(){ Level = 2 };

            A.Run run9 = new A.Run();

            A.RunProperties runProperties11 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties11.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text11 = new A.Text();
            text11.Text = "Third level";

            run9.Append(runProperties11);
            run9.Append(text11);

            paragraph11.Append(paragraphProperties3);
            paragraph11.Append(run9);

            A.Paragraph paragraph12 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties4 = new A.ParagraphProperties(){ Level = 3 };

            A.Run run10 = new A.Run();

            A.RunProperties runProperties12 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties12.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text12 = new A.Text();
            text12.Text = "Fourth level";

            run10.Append(runProperties12);
            run10.Append(text12);

            paragraph12.Append(paragraphProperties4);
            paragraph12.Append(run10);

            A.Paragraph paragraph13 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties5 = new A.ParagraphProperties(){ Level = 4 };

            A.Run run11 = new A.Run();

            A.RunProperties runProperties13 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties13.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text13 = new A.Text();
            text13.Text = "Fifth level";

            run11.Append(runProperties13);
            run11.Append(text13);
            A.EndParagraphRunProperties endParagraphRunProperties9 = new A.EndParagraphRunProperties(){ Language = "en-US", Dirty = false };

            paragraph13.Append(paragraphProperties5);
            paragraph13.Append(run11);
            paragraph13.Append(endParagraphRunProperties9);

            textBody9.Append(bodyProperties9);
            textBody9.Append(listStyle9);
            textBody9.Append(paragraph9);
            textBody9.Append(paragraph10);
            textBody9.Append(paragraph11);
            textBody9.Append(paragraph12);
            textBody9.Append(paragraph13);

            shape9.Append(nonVisualShapeProperties9);
            shape9.Append(shapeProperties14);
            shape9.Append(textBody9);

            Shape shape10 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties10 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties18 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Date Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties10 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks10 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties10.Append(shapeLocks10);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties18 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape10 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)2U };

            applicationNonVisualDrawingProperties18.Append(placeholderShape10);

            nonVisualShapeProperties10.Append(nonVisualDrawingProperties18);
            nonVisualShapeProperties10.Append(nonVisualShapeDrawingProperties10);
            nonVisualShapeProperties10.Append(applicationNonVisualDrawingProperties18);

            ShapeProperties shapeProperties15 = new ShapeProperties();

            A.Transform2D transform2D10 = new A.Transform2D();
            A.Offset offset13 = new A.Offset(){ X = 9906992L, Y = 6172201L };
            A.Extents extents13 = new A.Extents(){ Cx = 1600617L, Cy = 365125L };

            transform2D10.Append(offset13);
            transform2D10.Append(extents13);

            A.PresetGeometry presetGeometry8 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList8 = new A.AdjustValueList();

            presetGeometry8.Append(adjustValueList8);

            shapeProperties15.Append(transform2D10);
            shapeProperties15.Append(presetGeometry8);

            TextBody textBody10 = new TextBody();
            A.BodyProperties bodyProperties10 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal, LeftInset = 91440, TopInset = 45720, RightInset = 91440, BottomInset = 45720, RightToLeftColumns = false, Anchor = A.TextAnchoringTypeValues.Top };

            A.ListStyle listStyle10 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties4 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Right };

            A.DefaultRunProperties defaultRunProperties21 = new A.DefaultRunProperties(){ FontSize = 1000, Bold = false, Italic = false };

            A.SolidFill solidFill24 = new A.SolidFill();

            A.SchemeColor schemeColor45 = new A.SchemeColor(){ Val = A.SchemeColorValues.Background2 };
            A.LuminanceModulation luminanceModulation2 = new A.LuminanceModulation(){ Val = 50000 };

            schemeColor45.Append(luminanceModulation2);

            solidFill24.Append(schemeColor45);
            A.EffectList effectList3 = new A.EffectList();
            A.LatinFont latinFont10 = new A.LatinFont(){ Typeface = "+mn-lt" };

            defaultRunProperties21.Append(solidFill24);
            defaultRunProperties21.Append(effectList3);
            defaultRunProperties21.Append(latinFont10);

            level1ParagraphProperties4.Append(defaultRunProperties21);

            listStyle10.Append(level1ParagraphProperties4);

            A.Paragraph paragraph14 = new A.Paragraph();

            A.Field field3 = new A.Field(){ Id = "{CE1A2D98-1BBD-4706-A118-AAC2A16BEAD3}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties14 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties14.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text14 = new A.Text();
            text14.Text = "2012/10/3";

            field3.Append(runProperties14);
            field3.Append(text14);
            A.EndParagraphRunProperties endParagraphRunProperties10 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph14.Append(field3);
            paragraph14.Append(endParagraphRunProperties10);

            textBody10.Append(bodyProperties10);
            textBody10.Append(listStyle10);
            textBody10.Append(paragraph14);

            shape10.Append(nonVisualShapeProperties10);
            shape10.Append(shapeProperties15);
            shape10.Append(textBody10);

            Shape shape11 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties11 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties19 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Footer Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties11 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks11 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties11.Append(shapeLocks11);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties19 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape11 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)3U };

            applicationNonVisualDrawingProperties19.Append(placeholderShape11);

            nonVisualShapeProperties11.Append(nonVisualDrawingProperties19);
            nonVisualShapeProperties11.Append(nonVisualShapeDrawingProperties11);
            nonVisualShapeProperties11.Append(applicationNonVisualDrawingProperties19);

            ShapeProperties shapeProperties16 = new ShapeProperties();

            A.Transform2D transform2D11 = new A.Transform2D();
            A.Offset offset14 = new A.Offset(){ X = 684390L, Y = 6172201L };
            A.Extents extents14 = new A.Extents(){ Cx = 7545765L, Cy = 365125L };

            transform2D11.Append(offset14);
            transform2D11.Append(extents14);

            A.PresetGeometry presetGeometry9 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList9 = new A.AdjustValueList();

            presetGeometry9.Append(adjustValueList9);

            shapeProperties16.Append(transform2D11);
            shapeProperties16.Append(presetGeometry9);

            TextBody textBody11 = new TextBody();
            A.BodyProperties bodyProperties11 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal, LeftInset = 91440, TopInset = 45720, RightInset = 91440, BottomInset = 45720, RightToLeftColumns = false, Anchor = A.TextAnchoringTypeValues.Top };

            A.ListStyle listStyle11 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties5 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Left };

            A.DefaultRunProperties defaultRunProperties22 = new A.DefaultRunProperties(){ FontSize = 1000, Bold = false, Italic = false };

            A.SolidFill solidFill25 = new A.SolidFill();

            A.SchemeColor schemeColor46 = new A.SchemeColor(){ Val = A.SchemeColorValues.Background2 };
            A.LuminanceModulation luminanceModulation3 = new A.LuminanceModulation(){ Val = 50000 };

            schemeColor46.Append(luminanceModulation3);

            solidFill25.Append(schemeColor46);
            A.EffectList effectList4 = new A.EffectList();
            A.LatinFont latinFont11 = new A.LatinFont(){ Typeface = "+mn-lt" };

            defaultRunProperties22.Append(solidFill25);
            defaultRunProperties22.Append(effectList4);
            defaultRunProperties22.Append(latinFont11);

            level1ParagraphProperties5.Append(defaultRunProperties22);

            listStyle11.Append(level1ParagraphProperties5);

            A.Paragraph paragraph15 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties11 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph15.Append(endParagraphRunProperties11);

            textBody11.Append(bodyProperties11);
            textBody11.Append(listStyle11);
            textBody11.Append(paragraph15);

            shape11.Append(nonVisualShapeProperties11);
            shape11.Append(shapeProperties16);
            shape11.Append(textBody11);

            Shape shape12 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties12 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties20 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Slide Number Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties12 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks12 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties12.Append(shapeLocks12);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties20 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape12 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)4U };

            applicationNonVisualDrawingProperties20.Append(placeholderShape12);

            nonVisualShapeProperties12.Append(nonVisualDrawingProperties20);
            nonVisualShapeProperties12.Append(nonVisualShapeDrawingProperties12);
            nonVisualShapeProperties12.Append(applicationNonVisualDrawingProperties20);

            ShapeProperties shapeProperties17 = new ShapeProperties();

            A.Transform2D transform2D12 = new A.Transform2D();
            A.Offset offset15 = new A.Offset(){ X = 10365900L, Y = 5578476L };
            A.Extents extents15 = new A.Extents(){ Cx = 1142543L, Cy = 669925L };

            transform2D12.Append(offset15);
            transform2D12.Append(extents15);

            A.PresetGeometry presetGeometry10 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList10 = new A.AdjustValueList();

            presetGeometry10.Append(adjustValueList10);

            shapeProperties17.Append(transform2D12);
            shapeProperties17.Append(presetGeometry10);

            TextBody textBody12 = new TextBody();
            A.BodyProperties bodyProperties12 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal, LeftInset = 91440, TopInset = 45720, RightInset = 91440, BottomInset = 45720, RightToLeftColumns = false, Anchor = A.TextAnchoringTypeValues.Bottom };

            A.ListStyle listStyle12 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties6 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Right };

            A.DefaultRunProperties defaultRunProperties23 = new A.DefaultRunProperties(){ FontSize = 3200, Bold = false, Italic = false };

            A.SolidFill solidFill26 = new A.SolidFill();

            A.SchemeColor schemeColor47 = new A.SchemeColor(){ Val = A.SchemeColorValues.Background2 };
            A.LuminanceModulation luminanceModulation4 = new A.LuminanceModulation(){ Val = 50000 };

            schemeColor47.Append(luminanceModulation4);

            solidFill26.Append(schemeColor47);
            A.EffectList effectList5 = new A.EffectList();
            A.LatinFont latinFont12 = new A.LatinFont(){ Typeface = "+mn-lt" };

            defaultRunProperties23.Append(solidFill26);
            defaultRunProperties23.Append(effectList5);
            defaultRunProperties23.Append(latinFont12);

            level1ParagraphProperties6.Append(defaultRunProperties23);

            listStyle12.Append(level1ParagraphProperties6);

            A.Paragraph paragraph16 = new A.Paragraph();

            A.Field field4 = new A.Field(){ Id = "{D107CD50-7081-433F-A1F2-156B4E14F4F4}", Type = "slidenum" };

            A.RunProperties runProperties15 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties15.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text15 = new A.Text();
            text15.Text = "‹#›";

            field4.Append(runProperties15);
            field4.Append(text15);
            A.EndParagraphRunProperties endParagraphRunProperties12 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph16.Append(field4);
            paragraph16.Append(endParagraphRunProperties12);

            textBody12.Append(bodyProperties12);
            textBody12.Append(listStyle12);
            textBody12.Append(paragraph16);

            shape12.Append(nonVisualShapeProperties12);
            shape12.Append(shapeProperties17);
            shape12.Append(textBody12);

            shapeTree3.Append(nonVisualGroupShapeProperties3);
            shapeTree3.Append(groupShapeProperties3);
            shapeTree3.Append(shape8);
            shapeTree3.Append(shape9);
            shapeTree3.Append(shape10);
            shapeTree3.Append(shape11);
            shapeTree3.Append(shape12);

            CommonSlideDataExtensionList commonSlideDataExtensionList3 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension3 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId3 = new P14.CreationId(){ Val = (UInt32Value)1057398551U };
            creationId3.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension3.Append(creationId3);

            commonSlideDataExtensionList3.Append(commonSlideDataExtension3);

            commonSlideData3.Append(background1);
            commonSlideData3.Append(shapeTree3);
            commonSlideData3.Append(commonSlideDataExtensionList3);
            ColorMap colorMap1 = new ColorMap(){ Background1 = A.ColorSchemeIndexValues.Dark1, Text1 = A.ColorSchemeIndexValues.Light1, Background2 = A.ColorSchemeIndexValues.Dark2, Text2 = A.ColorSchemeIndexValues.Light2, Accent1 = A.ColorSchemeIndexValues.Accent1, Accent2 = A.ColorSchemeIndexValues.Accent2, Accent3 = A.ColorSchemeIndexValues.Accent3, Accent4 = A.ColorSchemeIndexValues.Accent4, Accent5 = A.ColorSchemeIndexValues.Accent5, Accent6 = A.ColorSchemeIndexValues.Accent6, Hyperlink = A.ColorSchemeIndexValues.Hyperlink, FollowedHyperlink = A.ColorSchemeIndexValues.FollowedHyperlink };

            SlideLayoutIdList slideLayoutIdList1 = new SlideLayoutIdList();
            SlideLayoutId slideLayoutId1 = new SlideLayoutId(){ Id = (UInt32Value)2147483754U, RelationshipId = "rId1" };
            SlideLayoutId slideLayoutId2 = new SlideLayoutId(){ Id = (UInt32Value)2147483755U, RelationshipId = "rId2" };
            SlideLayoutId slideLayoutId3 = new SlideLayoutId(){ Id = (UInt32Value)2147483756U, RelationshipId = "rId3" };
            SlideLayoutId slideLayoutId4 = new SlideLayoutId(){ Id = (UInt32Value)2147483757U, RelationshipId = "rId4" };
            SlideLayoutId slideLayoutId5 = new SlideLayoutId(){ Id = (UInt32Value)2147483758U, RelationshipId = "rId5" };
            SlideLayoutId slideLayoutId6 = new SlideLayoutId(){ Id = (UInt32Value)2147483759U, RelationshipId = "rId6" };
            SlideLayoutId slideLayoutId7 = new SlideLayoutId(){ Id = (UInt32Value)2147483760U, RelationshipId = "rId7" };
            SlideLayoutId slideLayoutId8 = new SlideLayoutId(){ Id = (UInt32Value)2147483761U, RelationshipId = "rId8" };
            SlideLayoutId slideLayoutId9 = new SlideLayoutId(){ Id = (UInt32Value)2147483762U, RelationshipId = "rId9" };
            SlideLayoutId slideLayoutId10 = new SlideLayoutId(){ Id = (UInt32Value)2147483763U, RelationshipId = "rId10" };
            SlideLayoutId slideLayoutId11 = new SlideLayoutId(){ Id = (UInt32Value)2147483764U, RelationshipId = "rId11" };
            SlideLayoutId slideLayoutId12 = new SlideLayoutId(){ Id = (UInt32Value)2147483765U, RelationshipId = "rId12" };
            SlideLayoutId slideLayoutId13 = new SlideLayoutId(){ Id = (UInt32Value)2147483766U, RelationshipId = "rId13" };
            SlideLayoutId slideLayoutId14 = new SlideLayoutId(){ Id = (UInt32Value)2147483767U, RelationshipId = "rId14" };
            SlideLayoutId slideLayoutId15 = new SlideLayoutId(){ Id = (UInt32Value)2147483768U, RelationshipId = "rId15" };
            SlideLayoutId slideLayoutId16 = new SlideLayoutId(){ Id = (UInt32Value)2147483769U, RelationshipId = "rId16" };
            SlideLayoutId slideLayoutId17 = new SlideLayoutId(){ Id = (UInt32Value)2147483770U, RelationshipId = "rId17" };

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
            slideLayoutIdList1.Append(slideLayoutId12);
            slideLayoutIdList1.Append(slideLayoutId13);
            slideLayoutIdList1.Append(slideLayoutId14);
            slideLayoutIdList1.Append(slideLayoutId15);
            slideLayoutIdList1.Append(slideLayoutId16);
            slideLayoutIdList1.Append(slideLayoutId17);

            AlternateContent alternateContent2 = new AlternateContent();
            alternateContent2.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            alternateContent2.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            AlternateContentChoice alternateContentChoice2 = new AlternateContentChoice(){ Requires = "p14" };

            Transition transition3 = new Transition(){ Speed = TransitionSpeedValues.Slow, Duration = "1500" };
            SplitTransition splitTransition1 = new SplitTransition(){ Orientation = DirectionValues.Vertical };

            transition3.Append(splitTransition1);

            alternateContentChoice2.Append(transition3);

            AlternateContentFallback alternateContentFallback2 = new AlternateContentFallback();

            Transition transition4 = new Transition(){ Speed = TransitionSpeedValues.Slow };
            SplitTransition splitTransition2 = new SplitTransition(){ Orientation = DirectionValues.Vertical };

            transition4.Append(splitTransition2);

            alternateContentFallback2.Append(transition4);

            alternateContent2.Append(alternateContentChoice2);
            alternateContent2.Append(alternateContentFallback2);

            Timing timing3 = new Timing();

            TimeNodeList timeNodeList3 = new TimeNodeList();

            ParallelTimeNode parallelTimeNode3 = new ParallelTimeNode();
            CommonTimeNode commonTimeNode3 = new CommonTimeNode(){ Id = (UInt32Value)1U, Duration = "indefinite", Restart = TimeNodeRestartValues.Never, NodeType = TimeNodeValues.TmingRoot };

            parallelTimeNode3.Append(commonTimeNode3);

            timeNodeList3.Append(parallelTimeNode3);

            timing3.Append(timeNodeList3);

            TextStyles textStyles1 = new TextStyles();

            TitleStyle titleStyle1 = new TitleStyle();

            A.Level1ParagraphProperties level1ParagraphProperties7 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 457200, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.SpaceBefore spaceBefore1 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent1 = new A.SpacingPercent(){ Val = 0 };

            spaceBefore1.Append(spacingPercent1);
            A.NoBullet noBullet10 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties24 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 3600, Kerning = 1200, Capital = A.TextCapsValues.All };

            A.Outline outline6 = new A.Outline(){ Width = 3175, CompoundLineType = A.CompoundLineValues.Single };
            A.NoFill noFill1 = new A.NoFill();

            outline6.Append(noFill1);

            A.SolidFill solidFill27 = new A.SolidFill();
            A.SchemeColor schemeColor48 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill27.Append(schemeColor48);
            A.EffectList effectList6 = new A.EffectList();
            A.LatinFont latinFont13 = new A.LatinFont(){ Typeface = "+mj-lt" };
            A.EastAsianFont eastAsianFont10 = new A.EastAsianFont(){ Typeface = "+mj-ea" };
            A.ComplexScriptFont complexScriptFont10 = new A.ComplexScriptFont(){ Typeface = "Trebuchet MS" };

            defaultRunProperties24.Append(outline6);
            defaultRunProperties24.Append(solidFill27);
            defaultRunProperties24.Append(effectList6);
            defaultRunProperties24.Append(latinFont13);
            defaultRunProperties24.Append(eastAsianFont10);
            defaultRunProperties24.Append(complexScriptFont10);

            level1ParagraphProperties7.Append(spaceBefore1);
            level1ParagraphProperties7.Append(noBullet10);
            level1ParagraphProperties7.Append(defaultRunProperties24);

            A.Level2ParagraphProperties level2ParagraphProperties3 = new A.Level2ParagraphProperties(){ EastAsianLineBreak = true, Height = true };

            A.DefaultRunProperties defaultRunProperties25 = new A.DefaultRunProperties(){ Kumimoji = true };

            A.SolidFill solidFill28 = new A.SolidFill();
            A.SchemeColor schemeColor49 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill28.Append(schemeColor49);

            defaultRunProperties25.Append(solidFill28);

            level2ParagraphProperties3.Append(defaultRunProperties25);

            A.Level3ParagraphProperties level3ParagraphProperties3 = new A.Level3ParagraphProperties(){ EastAsianLineBreak = true, Height = true };

            A.DefaultRunProperties defaultRunProperties26 = new A.DefaultRunProperties(){ Kumimoji = true };

            A.SolidFill solidFill29 = new A.SolidFill();
            A.SchemeColor schemeColor50 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill29.Append(schemeColor50);

            defaultRunProperties26.Append(solidFill29);

            level3ParagraphProperties3.Append(defaultRunProperties26);

            A.Level4ParagraphProperties level4ParagraphProperties3 = new A.Level4ParagraphProperties(){ EastAsianLineBreak = true, Height = true };

            A.DefaultRunProperties defaultRunProperties27 = new A.DefaultRunProperties(){ Kumimoji = true };

            A.SolidFill solidFill30 = new A.SolidFill();
            A.SchemeColor schemeColor51 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill30.Append(schemeColor51);

            defaultRunProperties27.Append(solidFill30);

            level4ParagraphProperties3.Append(defaultRunProperties27);

            A.Level5ParagraphProperties level5ParagraphProperties3 = new A.Level5ParagraphProperties(){ EastAsianLineBreak = true, Height = true };

            A.DefaultRunProperties defaultRunProperties28 = new A.DefaultRunProperties(){ Kumimoji = true };

            A.SolidFill solidFill31 = new A.SolidFill();
            A.SchemeColor schemeColor52 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill31.Append(schemeColor52);

            defaultRunProperties28.Append(solidFill31);

            level5ParagraphProperties3.Append(defaultRunProperties28);

            A.Level6ParagraphProperties level6ParagraphProperties3 = new A.Level6ParagraphProperties(){ EastAsianLineBreak = true, Height = true };

            A.DefaultRunProperties defaultRunProperties29 = new A.DefaultRunProperties(){ Kumimoji = true };

            A.SolidFill solidFill32 = new A.SolidFill();
            A.SchemeColor schemeColor53 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill32.Append(schemeColor53);

            defaultRunProperties29.Append(solidFill32);

            level6ParagraphProperties3.Append(defaultRunProperties29);

            A.Level7ParagraphProperties level7ParagraphProperties3 = new A.Level7ParagraphProperties(){ EastAsianLineBreak = true, Height = true };

            A.DefaultRunProperties defaultRunProperties30 = new A.DefaultRunProperties(){ Kumimoji = true };

            A.SolidFill solidFill33 = new A.SolidFill();
            A.SchemeColor schemeColor54 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill33.Append(schemeColor54);

            defaultRunProperties30.Append(solidFill33);

            level7ParagraphProperties3.Append(defaultRunProperties30);

            A.Level8ParagraphProperties level8ParagraphProperties3 = new A.Level8ParagraphProperties(){ EastAsianLineBreak = true, Height = true };

            A.DefaultRunProperties defaultRunProperties31 = new A.DefaultRunProperties(){ Kumimoji = true };

            A.SolidFill solidFill34 = new A.SolidFill();
            A.SchemeColor schemeColor55 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill34.Append(schemeColor55);

            defaultRunProperties31.Append(solidFill34);

            level8ParagraphProperties3.Append(defaultRunProperties31);

            A.Level9ParagraphProperties level9ParagraphProperties3 = new A.Level9ParagraphProperties(){ EastAsianLineBreak = true, Height = true };

            A.DefaultRunProperties defaultRunProperties32 = new A.DefaultRunProperties(){ Kumimoji = true };

            A.SolidFill solidFill35 = new A.SolidFill();
            A.SchemeColor schemeColor56 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill35.Append(schemeColor56);

            defaultRunProperties32.Append(solidFill35);

            level9ParagraphProperties3.Append(defaultRunProperties32);

            titleStyle1.Append(level1ParagraphProperties7);
            titleStyle1.Append(level2ParagraphProperties3);
            titleStyle1.Append(level3ParagraphProperties3);
            titleStyle1.Append(level4ParagraphProperties3);
            titleStyle1.Append(level5ParagraphProperties3);
            titleStyle1.Append(level6ParagraphProperties3);
            titleStyle1.Append(level7ParagraphProperties3);
            titleStyle1.Append(level8ParagraphProperties3);
            titleStyle1.Append(level9ParagraphProperties3);

            BodyStyle bodyStyle1 = new BodyStyle();

            A.Level1ParagraphProperties level1ParagraphProperties8 = new A.Level1ParagraphProperties(){ LeftMargin = 285750, Indent = -285750, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 457200, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.SpaceBefore spaceBefore2 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent2 = new A.SpacingPercent(){ Val = 20000 };

            spaceBefore2.Append(spacingPercent2);

            A.SpaceAfter spaceAfter1 = new A.SpaceAfter();
            A.SpacingPoints spacingPoints1 = new A.SpacingPoints(){ Val = 600 };

            spaceAfter1.Append(spacingPoints1);

            A.BulletColor bulletColor1 = new A.BulletColor();
            A.SchemeColor schemeColor57 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            bulletColor1.Append(schemeColor57);
            A.BulletSizePercentage bulletSizePercentage1 = new A.BulletSizePercentage(){ Val = 70000 };
            A.BulletFont bulletFont1 = new A.BulletFont(){ Typeface = "Lucida Grande" };
            A.CharacterBullet characterBullet1 = new A.CharacterBullet(){ Char = "►" };

            A.DefaultRunProperties defaultRunProperties33 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 1800, Kerning = 1200, Capital = A.TextCapsValues.None };

            A.SolidFill solidFill36 = new A.SolidFill();

            A.SchemeColor schemeColor58 = new A.SchemeColor(){ Val = A.SchemeColorValues.Background2 };
            A.LuminanceModulation luminanceModulation5 = new A.LuminanceModulation(){ Val = 75000 };

            schemeColor58.Append(luminanceModulation5);

            solidFill36.Append(schemeColor58);
            A.EffectList effectList7 = new A.EffectList();
            A.LatinFont latinFont14 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont11 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont11 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties33.Append(solidFill36);
            defaultRunProperties33.Append(effectList7);
            defaultRunProperties33.Append(latinFont14);
            defaultRunProperties33.Append(eastAsianFont11);
            defaultRunProperties33.Append(complexScriptFont11);

            level1ParagraphProperties8.Append(spaceBefore2);
            level1ParagraphProperties8.Append(spaceAfter1);
            level1ParagraphProperties8.Append(bulletColor1);
            level1ParagraphProperties8.Append(bulletSizePercentage1);
            level1ParagraphProperties8.Append(bulletFont1);
            level1ParagraphProperties8.Append(characterBullet1);
            level1ParagraphProperties8.Append(defaultRunProperties33);

            A.Level2ParagraphProperties level2ParagraphProperties4 = new A.Level2ParagraphProperties(){ LeftMargin = 742950, Indent = -285750, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 457200, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.SpaceBefore spaceBefore3 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent3 = new A.SpacingPercent(){ Val = 20000 };

            spaceBefore3.Append(spacingPercent3);

            A.SpaceAfter spaceAfter2 = new A.SpaceAfter();
            A.SpacingPoints spacingPoints2 = new A.SpacingPoints(){ Val = 600 };

            spaceAfter2.Append(spacingPoints2);

            A.BulletColor bulletColor2 = new A.BulletColor();
            A.SchemeColor schemeColor59 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            bulletColor2.Append(schemeColor59);
            A.BulletSizePercentage bulletSizePercentage2 = new A.BulletSizePercentage(){ Val = 70000 };
            A.BulletFont bulletFont2 = new A.BulletFont(){ Typeface = "Lucida Grande" };
            A.CharacterBullet characterBullet2 = new A.CharacterBullet(){ Char = "►" };

            A.DefaultRunProperties defaultRunProperties34 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 1600, Kerning = 1200, Capital = A.TextCapsValues.None };

            A.SolidFill solidFill37 = new A.SolidFill();

            A.SchemeColor schemeColor60 = new A.SchemeColor(){ Val = A.SchemeColorValues.Background2 };
            A.LuminanceModulation luminanceModulation6 = new A.LuminanceModulation(){ Val = 75000 };

            schemeColor60.Append(luminanceModulation6);

            solidFill37.Append(schemeColor60);
            A.EffectList effectList8 = new A.EffectList();
            A.LatinFont latinFont15 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont12 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont12 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties34.Append(solidFill37);
            defaultRunProperties34.Append(effectList8);
            defaultRunProperties34.Append(latinFont15);
            defaultRunProperties34.Append(eastAsianFont12);
            defaultRunProperties34.Append(complexScriptFont12);

            level2ParagraphProperties4.Append(spaceBefore3);
            level2ParagraphProperties4.Append(spaceAfter2);
            level2ParagraphProperties4.Append(bulletColor2);
            level2ParagraphProperties4.Append(bulletSizePercentage2);
            level2ParagraphProperties4.Append(bulletFont2);
            level2ParagraphProperties4.Append(characterBullet2);
            level2ParagraphProperties4.Append(defaultRunProperties34);

            A.Level3ParagraphProperties level3ParagraphProperties4 = new A.Level3ParagraphProperties(){ LeftMargin = 1200150, Indent = -285750, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 457200, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.SpaceBefore spaceBefore4 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent4 = new A.SpacingPercent(){ Val = 20000 };

            spaceBefore4.Append(spacingPercent4);

            A.SpaceAfter spaceAfter3 = new A.SpaceAfter();
            A.SpacingPoints spacingPoints3 = new A.SpacingPoints(){ Val = 600 };

            spaceAfter3.Append(spacingPoints3);

            A.BulletColor bulletColor3 = new A.BulletColor();
            A.SchemeColor schemeColor61 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            bulletColor3.Append(schemeColor61);
            A.BulletSizePercentage bulletSizePercentage3 = new A.BulletSizePercentage(){ Val = 70000 };
            A.BulletFont bulletFont3 = new A.BulletFont(){ Typeface = "Lucida Grande" };
            A.CharacterBullet characterBullet3 = new A.CharacterBullet(){ Char = "►" };

            A.DefaultRunProperties defaultRunProperties35 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 1400, Kerning = 1200, Capital = A.TextCapsValues.None };

            A.SolidFill solidFill38 = new A.SolidFill();

            A.SchemeColor schemeColor62 = new A.SchemeColor(){ Val = A.SchemeColorValues.Background2 };
            A.LuminanceModulation luminanceModulation7 = new A.LuminanceModulation(){ Val = 75000 };

            schemeColor62.Append(luminanceModulation7);

            solidFill38.Append(schemeColor62);
            A.EffectList effectList9 = new A.EffectList();
            A.LatinFont latinFont16 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont13 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont13 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties35.Append(solidFill38);
            defaultRunProperties35.Append(effectList9);
            defaultRunProperties35.Append(latinFont16);
            defaultRunProperties35.Append(eastAsianFont13);
            defaultRunProperties35.Append(complexScriptFont13);

            level3ParagraphProperties4.Append(spaceBefore4);
            level3ParagraphProperties4.Append(spaceAfter3);
            level3ParagraphProperties4.Append(bulletColor3);
            level3ParagraphProperties4.Append(bulletSizePercentage3);
            level3ParagraphProperties4.Append(bulletFont3);
            level3ParagraphProperties4.Append(characterBullet3);
            level3ParagraphProperties4.Append(defaultRunProperties35);

            A.Level4ParagraphProperties level4ParagraphProperties4 = new A.Level4ParagraphProperties(){ LeftMargin = 1543050, Indent = -171450, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 457200, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.SpaceBefore spaceBefore5 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent5 = new A.SpacingPercent(){ Val = 20000 };

            spaceBefore5.Append(spacingPercent5);

            A.SpaceAfter spaceAfter4 = new A.SpaceAfter();
            A.SpacingPoints spacingPoints4 = new A.SpacingPoints(){ Val = 600 };

            spaceAfter4.Append(spacingPoints4);

            A.BulletColor bulletColor4 = new A.BulletColor();
            A.SchemeColor schemeColor63 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            bulletColor4.Append(schemeColor63);
            A.BulletSizePercentage bulletSizePercentage4 = new A.BulletSizePercentage(){ Val = 70000 };
            A.BulletFont bulletFont4 = new A.BulletFont(){ Typeface = "Lucida Grande" };
            A.CharacterBullet characterBullet4 = new A.CharacterBullet(){ Char = "►" };

            A.DefaultRunProperties defaultRunProperties36 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 1200, Kerning = 1200, Capital = A.TextCapsValues.None };

            A.SolidFill solidFill39 = new A.SolidFill();

            A.SchemeColor schemeColor64 = new A.SchemeColor(){ Val = A.SchemeColorValues.Background2 };
            A.LuminanceModulation luminanceModulation8 = new A.LuminanceModulation(){ Val = 75000 };

            schemeColor64.Append(luminanceModulation8);

            solidFill39.Append(schemeColor64);
            A.EffectList effectList10 = new A.EffectList();
            A.LatinFont latinFont17 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont14 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont14 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties36.Append(solidFill39);
            defaultRunProperties36.Append(effectList10);
            defaultRunProperties36.Append(latinFont17);
            defaultRunProperties36.Append(eastAsianFont14);
            defaultRunProperties36.Append(complexScriptFont14);

            level4ParagraphProperties4.Append(spaceBefore5);
            level4ParagraphProperties4.Append(spaceAfter4);
            level4ParagraphProperties4.Append(bulletColor4);
            level4ParagraphProperties4.Append(bulletSizePercentage4);
            level4ParagraphProperties4.Append(bulletFont4);
            level4ParagraphProperties4.Append(characterBullet4);
            level4ParagraphProperties4.Append(defaultRunProperties36);

            A.Level5ParagraphProperties level5ParagraphProperties4 = new A.Level5ParagraphProperties(){ LeftMargin = 2000250, Indent = -171450, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 457200, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.SpaceBefore spaceBefore6 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent6 = new A.SpacingPercent(){ Val = 20000 };

            spaceBefore6.Append(spacingPercent6);

            A.SpaceAfter spaceAfter5 = new A.SpaceAfter();
            A.SpacingPoints spacingPoints5 = new A.SpacingPoints(){ Val = 600 };

            spaceAfter5.Append(spacingPoints5);

            A.BulletColor bulletColor5 = new A.BulletColor();
            A.SchemeColor schemeColor65 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            bulletColor5.Append(schemeColor65);
            A.BulletSizePercentage bulletSizePercentage5 = new A.BulletSizePercentage(){ Val = 70000 };
            A.BulletFont bulletFont5 = new A.BulletFont(){ Typeface = "Lucida Grande" };
            A.CharacterBullet characterBullet5 = new A.CharacterBullet(){ Char = "►" };

            A.DefaultRunProperties defaultRunProperties37 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 1200, Kerning = 1200, Capital = A.TextCapsValues.None };

            A.SolidFill solidFill40 = new A.SolidFill();

            A.SchemeColor schemeColor66 = new A.SchemeColor(){ Val = A.SchemeColorValues.Background2 };
            A.LuminanceModulation luminanceModulation9 = new A.LuminanceModulation(){ Val = 75000 };

            schemeColor66.Append(luminanceModulation9);

            solidFill40.Append(schemeColor66);
            A.EffectList effectList11 = new A.EffectList();
            A.LatinFont latinFont18 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont15 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont15 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties37.Append(solidFill40);
            defaultRunProperties37.Append(effectList11);
            defaultRunProperties37.Append(latinFont18);
            defaultRunProperties37.Append(eastAsianFont15);
            defaultRunProperties37.Append(complexScriptFont15);

            level5ParagraphProperties4.Append(spaceBefore6);
            level5ParagraphProperties4.Append(spaceAfter5);
            level5ParagraphProperties4.Append(bulletColor5);
            level5ParagraphProperties4.Append(bulletSizePercentage5);
            level5ParagraphProperties4.Append(bulletFont5);
            level5ParagraphProperties4.Append(characterBullet5);
            level5ParagraphProperties4.Append(defaultRunProperties37);

            A.Level6ParagraphProperties level6ParagraphProperties4 = new A.Level6ParagraphProperties(){ LeftMargin = 2514600, Indent = -228600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 457200, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.SpaceBefore spaceBefore7 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent7 = new A.SpacingPercent(){ Val = 20000 };

            spaceBefore7.Append(spacingPercent7);
            A.BulletFont bulletFont6 = new A.BulletFont(){ Typeface = "Arial" };
            A.CharacterBullet characterBullet6 = new A.CharacterBullet(){ Char = "•" };

            A.DefaultRunProperties defaultRunProperties38 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 2000, Kerning = 1200 };

            A.SolidFill solidFill41 = new A.SolidFill();
            A.SchemeColor schemeColor67 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill41.Append(schemeColor67);
            A.LatinFont latinFont19 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont16 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont16 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties38.Append(solidFill41);
            defaultRunProperties38.Append(latinFont19);
            defaultRunProperties38.Append(eastAsianFont16);
            defaultRunProperties38.Append(complexScriptFont16);

            level6ParagraphProperties4.Append(spaceBefore7);
            level6ParagraphProperties4.Append(bulletFont6);
            level6ParagraphProperties4.Append(characterBullet6);
            level6ParagraphProperties4.Append(defaultRunProperties38);

            A.Level7ParagraphProperties level7ParagraphProperties4 = new A.Level7ParagraphProperties(){ LeftMargin = 2971800, Indent = -228600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 457200, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.SpaceBefore spaceBefore8 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent8 = new A.SpacingPercent(){ Val = 20000 };

            spaceBefore8.Append(spacingPercent8);
            A.BulletFont bulletFont7 = new A.BulletFont(){ Typeface = "Arial" };
            A.CharacterBullet characterBullet7 = new A.CharacterBullet(){ Char = "•" };

            A.DefaultRunProperties defaultRunProperties39 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 2000, Kerning = 1200 };

            A.SolidFill solidFill42 = new A.SolidFill();
            A.SchemeColor schemeColor68 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill42.Append(schemeColor68);
            A.LatinFont latinFont20 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont17 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont17 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties39.Append(solidFill42);
            defaultRunProperties39.Append(latinFont20);
            defaultRunProperties39.Append(eastAsianFont17);
            defaultRunProperties39.Append(complexScriptFont17);

            level7ParagraphProperties4.Append(spaceBefore8);
            level7ParagraphProperties4.Append(bulletFont7);
            level7ParagraphProperties4.Append(characterBullet7);
            level7ParagraphProperties4.Append(defaultRunProperties39);

            A.Level8ParagraphProperties level8ParagraphProperties4 = new A.Level8ParagraphProperties(){ LeftMargin = 3429000, Indent = -228600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 457200, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.SpaceBefore spaceBefore9 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent9 = new A.SpacingPercent(){ Val = 20000 };

            spaceBefore9.Append(spacingPercent9);
            A.BulletFont bulletFont8 = new A.BulletFont(){ Typeface = "Arial" };
            A.CharacterBullet characterBullet8 = new A.CharacterBullet(){ Char = "•" };

            A.DefaultRunProperties defaultRunProperties40 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 2000, Kerning = 1200 };

            A.SolidFill solidFill43 = new A.SolidFill();
            A.SchemeColor schemeColor69 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill43.Append(schemeColor69);
            A.LatinFont latinFont21 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont18 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont18 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties40.Append(solidFill43);
            defaultRunProperties40.Append(latinFont21);
            defaultRunProperties40.Append(eastAsianFont18);
            defaultRunProperties40.Append(complexScriptFont18);

            level8ParagraphProperties4.Append(spaceBefore9);
            level8ParagraphProperties4.Append(bulletFont8);
            level8ParagraphProperties4.Append(characterBullet8);
            level8ParagraphProperties4.Append(defaultRunProperties40);

            A.Level9ParagraphProperties level9ParagraphProperties4 = new A.Level9ParagraphProperties(){ LeftMargin = 3886200, Indent = -228600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 457200, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.SpaceBefore spaceBefore10 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent10 = new A.SpacingPercent(){ Val = 20000 };

            spaceBefore10.Append(spacingPercent10);
            A.BulletFont bulletFont9 = new A.BulletFont(){ Typeface = "Arial" };
            A.CharacterBullet characterBullet9 = new A.CharacterBullet(){ Char = "•" };

            A.DefaultRunProperties defaultRunProperties41 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 2000, Kerning = 1200 };

            A.SolidFill solidFill44 = new A.SolidFill();
            A.SchemeColor schemeColor70 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill44.Append(schemeColor70);
            A.LatinFont latinFont22 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont19 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont19 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties41.Append(solidFill44);
            defaultRunProperties41.Append(latinFont22);
            defaultRunProperties41.Append(eastAsianFont19);
            defaultRunProperties41.Append(complexScriptFont19);

            level9ParagraphProperties4.Append(spaceBefore10);
            level9ParagraphProperties4.Append(bulletFont9);
            level9ParagraphProperties4.Append(characterBullet9);
            level9ParagraphProperties4.Append(defaultRunProperties41);

            bodyStyle1.Append(level1ParagraphProperties8);
            bodyStyle1.Append(level2ParagraphProperties4);
            bodyStyle1.Append(level3ParagraphProperties4);
            bodyStyle1.Append(level4ParagraphProperties4);
            bodyStyle1.Append(level5ParagraphProperties4);
            bodyStyle1.Append(level6ParagraphProperties4);
            bodyStyle1.Append(level7ParagraphProperties4);
            bodyStyle1.Append(level8ParagraphProperties4);
            bodyStyle1.Append(level9ParagraphProperties4);

            OtherStyle otherStyle1 = new OtherStyle();

            A.DefaultParagraphProperties defaultParagraphProperties2 = new A.DefaultParagraphProperties();
            A.DefaultRunProperties defaultRunProperties42 = new A.DefaultRunProperties(){ Language = "en-US" };

            defaultParagraphProperties2.Append(defaultRunProperties42);

            A.Level1ParagraphProperties level1ParagraphProperties9 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 457200, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties43 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill45 = new A.SolidFill();
            A.SchemeColor schemeColor71 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill45.Append(schemeColor71);
            A.LatinFont latinFont23 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont20 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont20 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties43.Append(solidFill45);
            defaultRunProperties43.Append(latinFont23);
            defaultRunProperties43.Append(eastAsianFont20);
            defaultRunProperties43.Append(complexScriptFont20);

            level1ParagraphProperties9.Append(defaultRunProperties43);

            A.Level2ParagraphProperties level2ParagraphProperties5 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 457200, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties44 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill46 = new A.SolidFill();
            A.SchemeColor schemeColor72 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill46.Append(schemeColor72);
            A.LatinFont latinFont24 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont21 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont21 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties44.Append(solidFill46);
            defaultRunProperties44.Append(latinFont24);
            defaultRunProperties44.Append(eastAsianFont21);
            defaultRunProperties44.Append(complexScriptFont21);

            level2ParagraphProperties5.Append(defaultRunProperties44);

            A.Level3ParagraphProperties level3ParagraphProperties5 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 457200, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties45 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill47 = new A.SolidFill();
            A.SchemeColor schemeColor73 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill47.Append(schemeColor73);
            A.LatinFont latinFont25 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont22 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont22 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties45.Append(solidFill47);
            defaultRunProperties45.Append(latinFont25);
            defaultRunProperties45.Append(eastAsianFont22);
            defaultRunProperties45.Append(complexScriptFont22);

            level3ParagraphProperties5.Append(defaultRunProperties45);

            A.Level4ParagraphProperties level4ParagraphProperties5 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 457200, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties46 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill48 = new A.SolidFill();
            A.SchemeColor schemeColor74 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill48.Append(schemeColor74);
            A.LatinFont latinFont26 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont23 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont23 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties46.Append(solidFill48);
            defaultRunProperties46.Append(latinFont26);
            defaultRunProperties46.Append(eastAsianFont23);
            defaultRunProperties46.Append(complexScriptFont23);

            level4ParagraphProperties5.Append(defaultRunProperties46);

            A.Level5ParagraphProperties level5ParagraphProperties5 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 457200, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties47 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill49 = new A.SolidFill();
            A.SchemeColor schemeColor75 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill49.Append(schemeColor75);
            A.LatinFont latinFont27 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont24 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont24 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties47.Append(solidFill49);
            defaultRunProperties47.Append(latinFont27);
            defaultRunProperties47.Append(eastAsianFont24);
            defaultRunProperties47.Append(complexScriptFont24);

            level5ParagraphProperties5.Append(defaultRunProperties47);

            A.Level6ParagraphProperties level6ParagraphProperties5 = new A.Level6ParagraphProperties(){ LeftMargin = 2286000, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 457200, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties48 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill50 = new A.SolidFill();
            A.SchemeColor schemeColor76 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill50.Append(schemeColor76);
            A.LatinFont latinFont28 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont25 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont25 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties48.Append(solidFill50);
            defaultRunProperties48.Append(latinFont28);
            defaultRunProperties48.Append(eastAsianFont25);
            defaultRunProperties48.Append(complexScriptFont25);

            level6ParagraphProperties5.Append(defaultRunProperties48);

            A.Level7ParagraphProperties level7ParagraphProperties5 = new A.Level7ParagraphProperties(){ LeftMargin = 2743200, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 457200, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties49 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill51 = new A.SolidFill();
            A.SchemeColor schemeColor77 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill51.Append(schemeColor77);
            A.LatinFont latinFont29 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont26 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont26 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties49.Append(solidFill51);
            defaultRunProperties49.Append(latinFont29);
            defaultRunProperties49.Append(eastAsianFont26);
            defaultRunProperties49.Append(complexScriptFont26);

            level7ParagraphProperties5.Append(defaultRunProperties49);

            A.Level8ParagraphProperties level8ParagraphProperties5 = new A.Level8ParagraphProperties(){ LeftMargin = 3200400, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 457200, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties50 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill52 = new A.SolidFill();
            A.SchemeColor schemeColor78 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill52.Append(schemeColor78);
            A.LatinFont latinFont30 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont27 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont27 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties50.Append(solidFill52);
            defaultRunProperties50.Append(latinFont30);
            defaultRunProperties50.Append(eastAsianFont27);
            defaultRunProperties50.Append(complexScriptFont27);

            level8ParagraphProperties5.Append(defaultRunProperties50);

            A.Level9ParagraphProperties level9ParagraphProperties5 = new A.Level9ParagraphProperties(){ LeftMargin = 3657600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 457200, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties51 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill53 = new A.SolidFill();
            A.SchemeColor schemeColor79 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill53.Append(schemeColor79);
            A.LatinFont latinFont31 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont28 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont28 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties51.Append(solidFill53);
            defaultRunProperties51.Append(latinFont31);
            defaultRunProperties51.Append(eastAsianFont28);
            defaultRunProperties51.Append(complexScriptFont28);

            level9ParagraphProperties5.Append(defaultRunProperties51);

            otherStyle1.Append(defaultParagraphProperties2);
            otherStyle1.Append(level1ParagraphProperties9);
            otherStyle1.Append(level2ParagraphProperties5);
            otherStyle1.Append(level3ParagraphProperties5);
            otherStyle1.Append(level4ParagraphProperties5);
            otherStyle1.Append(level5ParagraphProperties5);
            otherStyle1.Append(level6ParagraphProperties5);
            otherStyle1.Append(level7ParagraphProperties5);
            otherStyle1.Append(level8ParagraphProperties5);
            otherStyle1.Append(level9ParagraphProperties5);

            textStyles1.Append(titleStyle1);
            textStyles1.Append(bodyStyle1);
            textStyles1.Append(otherStyle1);

            slideMaster1.Append(commonSlideData3);
            slideMaster1.Append(colorMap1);
            slideMaster1.Append(slideLayoutIdList1);
            slideMaster1.Append(alternateContent2);
            slideMaster1.Append(timing3);
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
            NonVisualDrawingProperties nonVisualDrawingProperties21 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties4 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties21 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties4.Append(nonVisualDrawingProperties21);
            nonVisualGroupShapeProperties4.Append(nonVisualGroupShapeDrawingProperties4);
            nonVisualGroupShapeProperties4.Append(applicationNonVisualDrawingProperties21);

            GroupShapeProperties groupShapeProperties4 = new GroupShapeProperties();

            A.TransformGroup transformGroup4 = new A.TransformGroup();
            A.Offset offset16 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents16 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset4 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents4 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup4.Append(offset16);
            transformGroup4.Append(extents16);
            transformGroup4.Append(childOffset4);
            transformGroup4.Append(childExtents4);

            groupShapeProperties4.Append(transformGroup4);

            Shape shape13 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties13 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties22 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties13 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks13 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties13.Append(shapeLocks13);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties22 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape13 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties22.Append(placeholderShape13);

            nonVisualShapeProperties13.Append(nonVisualDrawingProperties22);
            nonVisualShapeProperties13.Append(nonVisualShapeDrawingProperties13);
            nonVisualShapeProperties13.Append(applicationNonVisualDrawingProperties22);

            ShapeProperties shapeProperties18 = new ShapeProperties();

            A.Transform2D transform2D13 = new A.Transform2D();
            A.Offset offset17 = new A.Offset(){ X = 7086857L, Y = 685800L };
            A.Extents extents17 = new A.Extents(){ Cx = 3658553L, Cy = 1371600L };

            transform2D13.Append(offset17);
            transform2D13.Append(extents17);

            shapeProperties18.Append(transform2D13);

            TextBody textBody13 = new TextBody();

            A.BodyProperties bodyProperties13 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Bottom };
            A.NormalAutoFit normalAutoFit5 = new A.NormalAutoFit();

            bodyProperties13.Append(normalAutoFit5);

            A.ListStyle listStyle13 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties10 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Left };
            A.DefaultRunProperties defaultRunProperties52 = new A.DefaultRunProperties(){ FontSize = 2400, Bold = false };

            level1ParagraphProperties10.Append(defaultRunProperties52);

            listStyle13.Append(level1ParagraphProperties10);

            A.Paragraph paragraph17 = new A.Paragraph();

            A.Run run12 = new A.Run();

            A.RunProperties runProperties16 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties16.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text16 = new A.Text();
            text16.Text = "Click to edit Master title style";

            run12.Append(runProperties16);
            run12.Append(text16);
            A.EndParagraphRunProperties endParagraphRunProperties13 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph17.Append(run12);
            paragraph17.Append(endParagraphRunProperties13);

            textBody13.Append(bodyProperties13);
            textBody13.Append(listStyle13);
            textBody13.Append(paragraph17);

            shape13.Append(nonVisualShapeProperties13);
            shape13.Append(shapeProperties18);
            shape13.Append(textBody13);

            Shape shape14 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties14 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties23 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Content Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties14 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks14 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties14.Append(shapeLocks14);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties23 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape14 = new PlaceholderShape(){ Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties23.Append(placeholderShape14);

            nonVisualShapeProperties14.Append(nonVisualDrawingProperties23);
            nonVisualShapeProperties14.Append(nonVisualShapeDrawingProperties14);
            nonVisualShapeProperties14.Append(applicationNonVisualDrawingProperties23);

            ShapeProperties shapeProperties19 = new ShapeProperties();

            A.Transform2D transform2D14 = new A.Transform2D();
            A.Offset offset18 = new A.Offset(){ X = 684391L, Y = 685800L };
            A.Extents extents18 = new A.Extents(){ Cx = 5945149L, Cy = 5308600L };

            transform2D14.Append(offset18);
            transform2D14.Append(extents18);

            shapeProperties19.Append(transform2D14);

            TextBody textBody14 = new TextBody();

            A.BodyProperties bodyProperties14 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Center };
            A.NormalAutoFit normalAutoFit6 = new A.NormalAutoFit();

            bodyProperties14.Append(normalAutoFit6);

            A.ListStyle listStyle14 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties11 = new A.Level1ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties53 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level1ParagraphProperties11.Append(defaultRunProperties53);

            A.Level2ParagraphProperties level2ParagraphProperties6 = new A.Level2ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties54 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level2ParagraphProperties6.Append(defaultRunProperties54);

            A.Level3ParagraphProperties level3ParagraphProperties6 = new A.Level3ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties55 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level3ParagraphProperties6.Append(defaultRunProperties55);

            A.Level4ParagraphProperties level4ParagraphProperties6 = new A.Level4ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties56 = new A.DefaultRunProperties(){ FontSize = 1400 };

            level4ParagraphProperties6.Append(defaultRunProperties56);

            A.Level5ParagraphProperties level5ParagraphProperties6 = new A.Level5ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties57 = new A.DefaultRunProperties(){ FontSize = 1400 };

            level5ParagraphProperties6.Append(defaultRunProperties57);

            A.Level6ParagraphProperties level6ParagraphProperties6 = new A.Level6ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties58 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level6ParagraphProperties6.Append(defaultRunProperties58);

            A.Level7ParagraphProperties level7ParagraphProperties6 = new A.Level7ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties59 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level7ParagraphProperties6.Append(defaultRunProperties59);

            A.Level8ParagraphProperties level8ParagraphProperties6 = new A.Level8ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties60 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level8ParagraphProperties6.Append(defaultRunProperties60);

            A.Level9ParagraphProperties level9ParagraphProperties6 = new A.Level9ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties61 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level9ParagraphProperties6.Append(defaultRunProperties61);

            listStyle14.Append(level1ParagraphProperties11);
            listStyle14.Append(level2ParagraphProperties6);
            listStyle14.Append(level3ParagraphProperties6);
            listStyle14.Append(level4ParagraphProperties6);
            listStyle14.Append(level5ParagraphProperties6);
            listStyle14.Append(level6ParagraphProperties6);
            listStyle14.Append(level7ParagraphProperties6);
            listStyle14.Append(level8ParagraphProperties6);
            listStyle14.Append(level9ParagraphProperties6);

            A.Paragraph paragraph18 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties6 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run13 = new A.Run();

            A.RunProperties runProperties17 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties17.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text17 = new A.Text();
            text17.Text = "Click to edit Master text styles";

            run13.Append(runProperties17);
            run13.Append(text17);

            paragraph18.Append(paragraphProperties6);
            paragraph18.Append(run13);

            A.Paragraph paragraph19 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties7 = new A.ParagraphProperties(){ Level = 1 };

            A.Run run14 = new A.Run();

            A.RunProperties runProperties18 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties18.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text18 = new A.Text();
            text18.Text = "Second level";

            run14.Append(runProperties18);
            run14.Append(text18);

            paragraph19.Append(paragraphProperties7);
            paragraph19.Append(run14);

            A.Paragraph paragraph20 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties8 = new A.ParagraphProperties(){ Level = 2 };

            A.Run run15 = new A.Run();

            A.RunProperties runProperties19 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties19.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text19 = new A.Text();
            text19.Text = "Third level";

            run15.Append(runProperties19);
            run15.Append(text19);

            paragraph20.Append(paragraphProperties8);
            paragraph20.Append(run15);

            A.Paragraph paragraph21 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties9 = new A.ParagraphProperties(){ Level = 3 };

            A.Run run16 = new A.Run();

            A.RunProperties runProperties20 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties20.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text20 = new A.Text();
            text20.Text = "Fourth level";

            run16.Append(runProperties20);
            run16.Append(text20);

            paragraph21.Append(paragraphProperties9);
            paragraph21.Append(run16);

            A.Paragraph paragraph22 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties10 = new A.ParagraphProperties(){ Level = 4 };

            A.Run run17 = new A.Run();

            A.RunProperties runProperties21 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties21.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text21 = new A.Text();
            text21.Text = "Fifth level";

            run17.Append(runProperties21);
            run17.Append(text21);
            A.EndParagraphRunProperties endParagraphRunProperties14 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph22.Append(paragraphProperties10);
            paragraph22.Append(run17);
            paragraph22.Append(endParagraphRunProperties14);

            textBody14.Append(bodyProperties14);
            textBody14.Append(listStyle14);
            textBody14.Append(paragraph18);
            textBody14.Append(paragraph19);
            textBody14.Append(paragraph20);
            textBody14.Append(paragraph21);
            textBody14.Append(paragraph22);

            shape14.Append(nonVisualShapeProperties14);
            shape14.Append(shapeProperties19);
            shape14.Append(textBody14);

            Shape shape15 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties15 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties24 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Text Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties15 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks15 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties15.Append(shapeLocks15);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties24 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape15 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)2U };

            applicationNonVisualDrawingProperties24.Append(placeholderShape15);

            nonVisualShapeProperties15.Append(nonVisualDrawingProperties24);
            nonVisualShapeProperties15.Append(nonVisualShapeDrawingProperties15);
            nonVisualShapeProperties15.Append(applicationNonVisualDrawingProperties24);

            ShapeProperties shapeProperties20 = new ShapeProperties();

            A.Transform2D transform2D15 = new A.Transform2D();
            A.Offset offset19 = new A.Offset(){ X = 7086857L, Y = 2209800L };
            A.Extents extents19 = new A.Extents(){ Cx = 3658553L, Cy = 2091267L };

            transform2D15.Append(offset19);
            transform2D15.Append(extents19);

            shapeProperties20.Append(transform2D15);

            TextBody textBody15 = new TextBody();

            A.BodyProperties bodyProperties15 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Top };
            A.NormalAutoFit normalAutoFit7 = new A.NormalAutoFit();

            bodyProperties15.Append(normalAutoFit7);

            A.ListStyle listStyle15 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties12 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0 };
            A.NoBullet noBullet11 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties62 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level1ParagraphProperties12.Append(noBullet11);
            level1ParagraphProperties12.Append(defaultRunProperties62);

            A.Level2ParagraphProperties level2ParagraphProperties7 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Indent = 0 };
            A.NoBullet noBullet12 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties63 = new A.DefaultRunProperties(){ FontSize = 1200 };

            level2ParagraphProperties7.Append(noBullet12);
            level2ParagraphProperties7.Append(defaultRunProperties63);

            A.Level3ParagraphProperties level3ParagraphProperties7 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Indent = 0 };
            A.NoBullet noBullet13 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties64 = new A.DefaultRunProperties(){ FontSize = 1000 };

            level3ParagraphProperties7.Append(noBullet13);
            level3ParagraphProperties7.Append(defaultRunProperties64);

            A.Level4ParagraphProperties level4ParagraphProperties7 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Indent = 0 };
            A.NoBullet noBullet14 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties65 = new A.DefaultRunProperties(){ FontSize = 900 };

            level4ParagraphProperties7.Append(noBullet14);
            level4ParagraphProperties7.Append(defaultRunProperties65);

            A.Level5ParagraphProperties level5ParagraphProperties7 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Indent = 0 };
            A.NoBullet noBullet15 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties66 = new A.DefaultRunProperties(){ FontSize = 900 };

            level5ParagraphProperties7.Append(noBullet15);
            level5ParagraphProperties7.Append(defaultRunProperties66);

            A.Level6ParagraphProperties level6ParagraphProperties7 = new A.Level6ParagraphProperties(){ LeftMargin = 2286000, Indent = 0 };
            A.NoBullet noBullet16 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties67 = new A.DefaultRunProperties(){ FontSize = 900 };

            level6ParagraphProperties7.Append(noBullet16);
            level6ParagraphProperties7.Append(defaultRunProperties67);

            A.Level7ParagraphProperties level7ParagraphProperties7 = new A.Level7ParagraphProperties(){ LeftMargin = 2743200, Indent = 0 };
            A.NoBullet noBullet17 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties68 = new A.DefaultRunProperties(){ FontSize = 900 };

            level7ParagraphProperties7.Append(noBullet17);
            level7ParagraphProperties7.Append(defaultRunProperties68);

            A.Level8ParagraphProperties level8ParagraphProperties7 = new A.Level8ParagraphProperties(){ LeftMargin = 3200400, Indent = 0 };
            A.NoBullet noBullet18 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties69 = new A.DefaultRunProperties(){ FontSize = 900 };

            level8ParagraphProperties7.Append(noBullet18);
            level8ParagraphProperties7.Append(defaultRunProperties69);

            A.Level9ParagraphProperties level9ParagraphProperties7 = new A.Level9ParagraphProperties(){ LeftMargin = 3657600, Indent = 0 };
            A.NoBullet noBullet19 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties70 = new A.DefaultRunProperties(){ FontSize = 900 };

            level9ParagraphProperties7.Append(noBullet19);
            level9ParagraphProperties7.Append(defaultRunProperties70);

            listStyle15.Append(level1ParagraphProperties12);
            listStyle15.Append(level2ParagraphProperties7);
            listStyle15.Append(level3ParagraphProperties7);
            listStyle15.Append(level4ParagraphProperties7);
            listStyle15.Append(level5ParagraphProperties7);
            listStyle15.Append(level6ParagraphProperties7);
            listStyle15.Append(level7ParagraphProperties7);
            listStyle15.Append(level8ParagraphProperties7);
            listStyle15.Append(level9ParagraphProperties7);

            A.Paragraph paragraph23 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties11 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run18 = new A.Run();

            A.RunProperties runProperties22 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties22.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text22 = new A.Text();
            text22.Text = "Click to edit Master text styles";

            run18.Append(runProperties22);
            run18.Append(text22);

            paragraph23.Append(paragraphProperties11);
            paragraph23.Append(run18);

            textBody15.Append(bodyProperties15);
            textBody15.Append(listStyle15);
            textBody15.Append(paragraph23);

            shape15.Append(nonVisualShapeProperties15);
            shape15.Append(shapeProperties20);
            shape15.Append(textBody15);

            Shape shape16 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties16 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties25 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Date Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties16 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks16 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties16.Append(shapeLocks16);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties25 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape16 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties25.Append(placeholderShape16);

            nonVisualShapeProperties16.Append(nonVisualDrawingProperties25);
            nonVisualShapeProperties16.Append(nonVisualShapeDrawingProperties16);
            nonVisualShapeProperties16.Append(applicationNonVisualDrawingProperties25);
            ShapeProperties shapeProperties21 = new ShapeProperties();

            TextBody textBody16 = new TextBody();
            A.BodyProperties bodyProperties16 = new A.BodyProperties();
            A.ListStyle listStyle16 = new A.ListStyle();

            A.Paragraph paragraph24 = new A.Paragraph();

            A.Field field5 = new A.Field(){ Id = "{CE1A2D98-1BBD-4706-A118-AAC2A16BEAD3}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties23 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties23.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text23 = new A.Text();
            text23.Text = "2012/10/3";

            field5.Append(runProperties23);
            field5.Append(text23);
            A.EndParagraphRunProperties endParagraphRunProperties15 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph24.Append(field5);
            paragraph24.Append(endParagraphRunProperties15);

            textBody16.Append(bodyProperties16);
            textBody16.Append(listStyle16);
            textBody16.Append(paragraph24);

            shape16.Append(nonVisualShapeProperties16);
            shape16.Append(shapeProperties21);
            shape16.Append(textBody16);

            Shape shape17 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties17 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties26 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Footer Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties17 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks17 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties17.Append(shapeLocks17);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties26 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape17 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties26.Append(placeholderShape17);

            nonVisualShapeProperties17.Append(nonVisualDrawingProperties26);
            nonVisualShapeProperties17.Append(nonVisualShapeDrawingProperties17);
            nonVisualShapeProperties17.Append(applicationNonVisualDrawingProperties26);
            ShapeProperties shapeProperties22 = new ShapeProperties();

            TextBody textBody17 = new TextBody();
            A.BodyProperties bodyProperties17 = new A.BodyProperties();
            A.ListStyle listStyle17 = new A.ListStyle();

            A.Paragraph paragraph25 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties16 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph25.Append(endParagraphRunProperties16);

            textBody17.Append(bodyProperties17);
            textBody17.Append(listStyle17);
            textBody17.Append(paragraph25);

            shape17.Append(nonVisualShapeProperties17);
            shape17.Append(shapeProperties22);
            shape17.Append(textBody17);

            Shape shape18 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties18 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties27 = new NonVisualDrawingProperties(){ Id = (UInt32Value)7U, Name = "Slide Number Placeholder 6" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties18 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks18 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties18.Append(shapeLocks18);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties27 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape18 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties27.Append(placeholderShape18);

            nonVisualShapeProperties18.Append(nonVisualDrawingProperties27);
            nonVisualShapeProperties18.Append(nonVisualShapeDrawingProperties18);
            nonVisualShapeProperties18.Append(applicationNonVisualDrawingProperties27);
            ShapeProperties shapeProperties23 = new ShapeProperties();

            TextBody textBody18 = new TextBody();
            A.BodyProperties bodyProperties18 = new A.BodyProperties();
            A.ListStyle listStyle18 = new A.ListStyle();

            A.Paragraph paragraph26 = new A.Paragraph();

            A.Field field6 = new A.Field(){ Id = "{D107CD50-7081-433F-A1F2-156B4E14F4F4}", Type = "slidenum" };

            A.RunProperties runProperties24 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties24.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text24 = new A.Text();
            text24.Text = "‹#›";

            field6.Append(runProperties24);
            field6.Append(text24);
            A.EndParagraphRunProperties endParagraphRunProperties17 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph26.Append(field6);
            paragraph26.Append(endParagraphRunProperties17);

            textBody18.Append(bodyProperties18);
            textBody18.Append(listStyle18);
            textBody18.Append(paragraph26);

            shape18.Append(nonVisualShapeProperties18);
            shape18.Append(shapeProperties23);
            shape18.Append(textBody18);

            ConnectionShape connectionShape6 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties6 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties28 = new NonVisualDrawingProperties(){ Id = (UInt32Value)8U, Name = "Straight Connector 7" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties6 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties28 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties6.Append(nonVisualDrawingProperties28);
            nonVisualConnectionShapeProperties6.Append(nonVisualConnectorShapeDrawingProperties6);
            nonVisualConnectionShapeProperties6.Append(applicationNonVisualDrawingProperties28);

            ShapeProperties shapeProperties24 = new ShapeProperties();

            A.Transform2D transform2D16 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset20 = new A.Offset(){ X = 11278949L, Y = 2963333L };
            A.Extents extents20 = new A.Extents(){ Cx = 913052L, Cy = 912812L };

            transform2D16.Append(offset20);
            transform2D16.Append(extents20);

            A.PresetGeometry presetGeometry11 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList11 = new A.AdjustValueList();

            presetGeometry11.Append(adjustValueList11);

            A.Outline outline7 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill54 = new A.SolidFill();
            A.SchemeColor schemeColor80 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill54.Append(schemeColor80);

            outline7.Append(solidFill54);

            shapeProperties24.Append(transform2D16);
            shapeProperties24.Append(presetGeometry11);
            shapeProperties24.Append(outline7);

            ShapeStyle shapeStyle6 = new ShapeStyle();

            A.LineReference lineReference6 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor81 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference6.Append(schemeColor81);

            A.FillReference fillReference6 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor82 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference6.Append(schemeColor82);

            A.EffectReference effectReference6 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor83 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference6.Append(schemeColor83);

            A.FontReference fontReference6 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor84 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference6.Append(schemeColor84);

            shapeStyle6.Append(lineReference6);
            shapeStyle6.Append(fillReference6);
            shapeStyle6.Append(effectReference6);
            shapeStyle6.Append(fontReference6);

            connectionShape6.Append(nonVisualConnectionShapeProperties6);
            connectionShape6.Append(shapeProperties24);
            connectionShape6.Append(shapeStyle6);

            ConnectionShape connectionShape7 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties7 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties29 = new NonVisualDrawingProperties(){ Id = (UInt32Value)9U, Name = "Straight Connector 8" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties7 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties29 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties7.Append(nonVisualDrawingProperties29);
            nonVisualConnectionShapeProperties7.Append(nonVisualConnectorShapeDrawingProperties7);
            nonVisualConnectionShapeProperties7.Append(applicationNonVisualDrawingProperties29);

            ShapeProperties shapeProperties25 = new ShapeProperties();

            A.Transform2D transform2D17 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset21 = new A.Offset(){ X = 9209368L, Y = 3190344L };
            A.Extents extents21 = new A.Extents(){ Cx = 2982634L, Cy = 2981856L };

            transform2D17.Append(offset21);
            transform2D17.Append(extents21);

            A.PresetGeometry presetGeometry12 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList12 = new A.AdjustValueList();

            presetGeometry12.Append(adjustValueList12);

            A.Outline outline8 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill55 = new A.SolidFill();
            A.SchemeColor schemeColor85 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill55.Append(schemeColor85);

            outline8.Append(solidFill55);

            shapeProperties25.Append(transform2D17);
            shapeProperties25.Append(presetGeometry12);
            shapeProperties25.Append(outline8);

            ShapeStyle shapeStyle7 = new ShapeStyle();

            A.LineReference lineReference7 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor86 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference7.Append(schemeColor86);

            A.FillReference fillReference7 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor87 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference7.Append(schemeColor87);

            A.EffectReference effectReference7 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor88 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference7.Append(schemeColor88);

            A.FontReference fontReference7 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor89 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference7.Append(schemeColor89);

            shapeStyle7.Append(lineReference7);
            shapeStyle7.Append(fillReference7);
            shapeStyle7.Append(effectReference7);
            shapeStyle7.Append(fontReference7);

            connectionShape7.Append(nonVisualConnectionShapeProperties7);
            connectionShape7.Append(shapeProperties25);
            connectionShape7.Append(shapeStyle7);

            ConnectionShape connectionShape8 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties8 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties30 = new NonVisualDrawingProperties(){ Id = (UInt32Value)10U, Name = "Straight Connector 9" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties8 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties30 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties8.Append(nonVisualDrawingProperties30);
            nonVisualConnectionShapeProperties8.Append(nonVisualConnectorShapeDrawingProperties8);
            nonVisualConnectionShapeProperties8.Append(applicationNonVisualDrawingProperties30);

            ShapeProperties shapeProperties26 = new ShapeProperties();

            A.Transform2D transform2D18 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset22 = new A.Offset(){ X = 10294973L, Y = 3285068L };
            A.Extents extents22 = new A.Extents(){ Cx = 1897028L, Cy = 1896533L };

            transform2D18.Append(offset22);
            transform2D18.Append(extents22);

            A.PresetGeometry presetGeometry13 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList13 = new A.AdjustValueList();

            presetGeometry13.Append(adjustValueList13);

            A.Outline outline9 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill56 = new A.SolidFill();
            A.SchemeColor schemeColor90 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill56.Append(schemeColor90);

            outline9.Append(solidFill56);

            shapeProperties26.Append(transform2D18);
            shapeProperties26.Append(presetGeometry13);
            shapeProperties26.Append(outline9);

            ShapeStyle shapeStyle8 = new ShapeStyle();

            A.LineReference lineReference8 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor91 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference8.Append(schemeColor91);

            A.FillReference fillReference8 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor92 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference8.Append(schemeColor92);

            A.EffectReference effectReference8 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor93 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference8.Append(schemeColor93);

            A.FontReference fontReference8 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor94 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference8.Append(schemeColor94);

            shapeStyle8.Append(lineReference8);
            shapeStyle8.Append(fillReference8);
            shapeStyle8.Append(effectReference8);
            shapeStyle8.Append(fontReference8);

            connectionShape8.Append(nonVisualConnectionShapeProperties8);
            connectionShape8.Append(shapeProperties26);
            connectionShape8.Append(shapeStyle8);

            ConnectionShape connectionShape9 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties9 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties31 = new NonVisualDrawingProperties(){ Id = (UInt32Value)11U, Name = "Straight Connector 10" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties9 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties31 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties9.Append(nonVisualDrawingProperties31);
            nonVisualConnectionShapeProperties9.Append(nonVisualConnectorShapeDrawingProperties9);
            nonVisualConnectionShapeProperties9.Append(applicationNonVisualDrawingProperties31);

            ShapeProperties shapeProperties27 = new ShapeProperties();

            A.Transform2D transform2D19 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset23 = new A.Offset(){ X = 10445823L, Y = 3131080L };
            A.Extents extents23 = new A.Extents(){ Cx = 1746177L, Cy = 1745720L };

            transform2D19.Append(offset23);
            transform2D19.Append(extents23);

            A.PresetGeometry presetGeometry14 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList14 = new A.AdjustValueList();

            presetGeometry14.Append(adjustValueList14);

            A.Outline outline10 = new A.Outline(){ Width = 28575 };

            A.SolidFill solidFill57 = new A.SolidFill();
            A.SchemeColor schemeColor95 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill57.Append(schemeColor95);

            outline10.Append(solidFill57);

            shapeProperties27.Append(transform2D19);
            shapeProperties27.Append(presetGeometry14);
            shapeProperties27.Append(outline10);

            ShapeStyle shapeStyle9 = new ShapeStyle();

            A.LineReference lineReference9 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor96 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference9.Append(schemeColor96);

            A.FillReference fillReference9 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor97 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference9.Append(schemeColor97);

            A.EffectReference effectReference9 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor98 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference9.Append(schemeColor98);

            A.FontReference fontReference9 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor99 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference9.Append(schemeColor99);

            shapeStyle9.Append(lineReference9);
            shapeStyle9.Append(fillReference9);
            shapeStyle9.Append(effectReference9);
            shapeStyle9.Append(fontReference9);

            connectionShape9.Append(nonVisualConnectionShapeProperties9);
            connectionShape9.Append(shapeProperties27);
            connectionShape9.Append(shapeStyle9);

            ConnectionShape connectionShape10 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties10 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties32 = new NonVisualDrawingProperties(){ Id = (UInt32Value)12U, Name = "Straight Connector 11" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties10 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties32 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties10.Append(nonVisualDrawingProperties32);
            nonVisualConnectionShapeProperties10.Append(nonVisualConnectorShapeDrawingProperties10);
            nonVisualConnectionShapeProperties10.Append(applicationNonVisualDrawingProperties32);

            ShapeProperties shapeProperties28 = new ShapeProperties();

            A.Transform2D transform2D20 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset24 = new A.Offset(){ X = 10921671L, Y = 3683002L };
            A.Extents extents24 = new A.Extents(){ Cx = 1270332L, Cy = 1269999L };

            transform2D20.Append(offset24);
            transform2D20.Append(extents24);

            A.PresetGeometry presetGeometry15 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList15 = new A.AdjustValueList();

            presetGeometry15.Append(adjustValueList15);

            A.Outline outline11 = new A.Outline(){ Width = 28575 };

            A.SolidFill solidFill58 = new A.SolidFill();
            A.SchemeColor schemeColor100 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill58.Append(schemeColor100);

            outline11.Append(solidFill58);

            shapeProperties28.Append(transform2D20);
            shapeProperties28.Append(presetGeometry15);
            shapeProperties28.Append(outline11);

            ShapeStyle shapeStyle10 = new ShapeStyle();

            A.LineReference lineReference10 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor101 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference10.Append(schemeColor101);

            A.FillReference fillReference10 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor102 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference10.Append(schemeColor102);

            A.EffectReference effectReference10 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor103 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference10.Append(schemeColor103);

            A.FontReference fontReference10 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor104 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference10.Append(schemeColor104);

            shapeStyle10.Append(lineReference10);
            shapeStyle10.Append(fillReference10);
            shapeStyle10.Append(effectReference10);
            shapeStyle10.Append(fontReference10);

            connectionShape10.Append(nonVisualConnectionShapeProperties10);
            connectionShape10.Append(shapeProperties28);
            connectionShape10.Append(shapeStyle10);

            shapeTree4.Append(nonVisualGroupShapeProperties4);
            shapeTree4.Append(groupShapeProperties4);
            shapeTree4.Append(shape13);
            shapeTree4.Append(shape14);
            shapeTree4.Append(shape15);
            shapeTree4.Append(shape16);
            shapeTree4.Append(shape17);
            shapeTree4.Append(shape18);
            shapeTree4.Append(connectionShape6);
            shapeTree4.Append(connectionShape7);
            shapeTree4.Append(connectionShape8);
            shapeTree4.Append(connectionShape9);
            shapeTree4.Append(connectionShape10);

            CommonSlideDataExtensionList commonSlideDataExtensionList4 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension4 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId4 = new P14.CreationId(){ Val = (UInt32Value)2943676450U };
            creationId4.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension4.Append(creationId4);

            commonSlideDataExtensionList4.Append(commonSlideDataExtension4);

            commonSlideData4.Append(shapeTree4);
            commonSlideData4.Append(commonSlideDataExtensionList4);

            ColorMapOverride colorMapOverride3 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping3 = new A.MasterColorMapping();

            colorMapOverride3.Append(masterColorMapping3);

            Timing timing4 = new Timing();

            TimeNodeList timeNodeList4 = new TimeNodeList();

            ParallelTimeNode parallelTimeNode4 = new ParallelTimeNode();
            CommonTimeNode commonTimeNode4 = new CommonTimeNode(){ Id = (UInt32Value)1U, Duration = "indefinite", Restart = TimeNodeRestartValues.Never, NodeType = TimeNodeValues.TmingRoot };

            parallelTimeNode4.Append(commonTimeNode4);

            timeNodeList4.Append(parallelTimeNode4);

            timing4.Append(timeNodeList4);

            slideLayout2.Append(commonSlideData4);
            slideLayout2.Append(colorMapOverride3);
            slideLayout2.Append(timing4);

            slideLayoutPart2.SlideLayout = slideLayout2;
        }

        // Generates content of slideLayoutPart3.
        private void GenerateSlideLayoutPart3Content(SlideLayoutPart slideLayoutPart3)
        {
            SlideLayout slideLayout3 = new SlideLayout(){ Type = SlideLayoutValues.SectionHeader, Preserve = true };
            slideLayout3.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout3.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout3.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData5 = new CommonSlideData(){ Name = "Name Card" };

            ShapeTree shapeTree5 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties5 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties33 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties5 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties33 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties5.Append(nonVisualDrawingProperties33);
            nonVisualGroupShapeProperties5.Append(nonVisualGroupShapeDrawingProperties5);
            nonVisualGroupShapeProperties5.Append(applicationNonVisualDrawingProperties33);

            GroupShapeProperties groupShapeProperties5 = new GroupShapeProperties();

            A.TransformGroup transformGroup5 = new A.TransformGroup();
            A.Offset offset25 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents25 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset5 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents5 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup5.Append(offset25);
            transformGroup5.Append(extents25);
            transformGroup5.Append(childOffset5);
            transformGroup5.Append(childExtents5);

            groupShapeProperties5.Append(transformGroup5);

            Shape shape19 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties19 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties34 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties19 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks19 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties19.Append(shapeLocks19);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties34 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape19 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties34.Append(placeholderShape19);

            nonVisualShapeProperties19.Append(nonVisualDrawingProperties34);
            nonVisualShapeProperties19.Append(nonVisualShapeDrawingProperties19);
            nonVisualShapeProperties19.Append(applicationNonVisualDrawingProperties34);

            ShapeProperties shapeProperties29 = new ShapeProperties();

            A.Transform2D transform2D21 = new A.Transform2D();
            A.Offset offset26 = new A.Offset(){ X = 684390L, Y = 3429000L };
            A.Extents extents26 = new A.Extents(){ Cx = 8536623L, Cy = 1697400L };

            transform2D21.Append(offset26);
            transform2D21.Append(extents26);

            shapeProperties29.Append(transform2D21);

            TextBody textBody19 = new TextBody();

            A.BodyProperties bodyProperties19 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Bottom };
            A.NormalAutoFit normalAutoFit8 = new A.NormalAutoFit();

            bodyProperties19.Append(normalAutoFit8);

            A.ListStyle listStyle19 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties13 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Left };
            A.DefaultRunProperties defaultRunProperties71 = new A.DefaultRunProperties(){ FontSize = 3200, Bold = false, Capital = A.TextCapsValues.All };

            level1ParagraphProperties13.Append(defaultRunProperties71);

            listStyle19.Append(level1ParagraphProperties13);

            A.Paragraph paragraph27 = new A.Paragraph();

            A.Run run19 = new A.Run();

            A.RunProperties runProperties25 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties25.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text25 = new A.Text();
            text25.Text = "Click to edit Master title style";

            run19.Append(runProperties25);
            run19.Append(text25);
            A.EndParagraphRunProperties endParagraphRunProperties18 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph27.Append(run19);
            paragraph27.Append(endParagraphRunProperties18);

            textBody19.Append(bodyProperties19);
            textBody19.Append(listStyle19);
            textBody19.Append(paragraph27);

            shape19.Append(nonVisualShapeProperties19);
            shape19.Append(shapeProperties29);
            shape19.Append(textBody19);

            Shape shape20 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties20 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties35 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Text Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties20 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks20 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties20.Append(shapeLocks20);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties35 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape20 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties35.Append(placeholderShape20);

            nonVisualShapeProperties20.Append(nonVisualDrawingProperties35);
            nonVisualShapeProperties20.Append(nonVisualShapeDrawingProperties20);
            nonVisualShapeProperties20.Append(applicationNonVisualDrawingProperties35);

            ShapeProperties shapeProperties30 = new ShapeProperties();

            A.Transform2D transform2D22 = new A.Transform2D();
            A.Offset offset27 = new A.Offset(){ X = 684389L, Y = 5132981L };
            A.Extents extents27 = new A.Extents(){ Cx = 8538213L, Cy = 860400L };

            transform2D22.Append(offset27);
            transform2D22.Append(extents27);

            shapeProperties30.Append(transform2D22);

            TextBody textBody20 = new TextBody();

            A.BodyProperties bodyProperties20 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Top };
            A.NormalAutoFit normalAutoFit9 = new A.NormalAutoFit();

            bodyProperties20.Append(normalAutoFit9);

            A.ListStyle listStyle20 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties14 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0, Alignment = A.TextAlignmentTypeValues.Left };
            A.NoBullet noBullet20 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties72 = new A.DefaultRunProperties(){ FontSize = 2000 };

            A.SolidFill solidFill59 = new A.SolidFill();

            A.SchemeColor schemeColor105 = new A.SchemeColor(){ Val = A.SchemeColorValues.Background2 };
            A.LuminanceModulation luminanceModulation10 = new A.LuminanceModulation(){ Val = 75000 };

            schemeColor105.Append(luminanceModulation10);

            solidFill59.Append(schemeColor105);

            defaultRunProperties72.Append(solidFill59);

            level1ParagraphProperties14.Append(noBullet20);
            level1ParagraphProperties14.Append(defaultRunProperties72);

            A.Level2ParagraphProperties level2ParagraphProperties8 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Indent = 0 };
            A.NoBullet noBullet21 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties73 = new A.DefaultRunProperties(){ FontSize = 1800 };

            A.SolidFill solidFill60 = new A.SolidFill();

            A.SchemeColor schemeColor106 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint9 = new A.Tint(){ Val = 75000 };

            schemeColor106.Append(tint9);

            solidFill60.Append(schemeColor106);

            defaultRunProperties73.Append(solidFill60);

            level2ParagraphProperties8.Append(noBullet21);
            level2ParagraphProperties8.Append(defaultRunProperties73);

            A.Level3ParagraphProperties level3ParagraphProperties8 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Indent = 0 };
            A.NoBullet noBullet22 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties74 = new A.DefaultRunProperties(){ FontSize = 1600 };

            A.SolidFill solidFill61 = new A.SolidFill();

            A.SchemeColor schemeColor107 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint10 = new A.Tint(){ Val = 75000 };

            schemeColor107.Append(tint10);

            solidFill61.Append(schemeColor107);

            defaultRunProperties74.Append(solidFill61);

            level3ParagraphProperties8.Append(noBullet22);
            level3ParagraphProperties8.Append(defaultRunProperties74);

            A.Level4ParagraphProperties level4ParagraphProperties8 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Indent = 0 };
            A.NoBullet noBullet23 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties75 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill62 = new A.SolidFill();

            A.SchemeColor schemeColor108 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint11 = new A.Tint(){ Val = 75000 };

            schemeColor108.Append(tint11);

            solidFill62.Append(schemeColor108);

            defaultRunProperties75.Append(solidFill62);

            level4ParagraphProperties8.Append(noBullet23);
            level4ParagraphProperties8.Append(defaultRunProperties75);

            A.Level5ParagraphProperties level5ParagraphProperties8 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Indent = 0 };
            A.NoBullet noBullet24 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties76 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill63 = new A.SolidFill();

            A.SchemeColor schemeColor109 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint12 = new A.Tint(){ Val = 75000 };

            schemeColor109.Append(tint12);

            solidFill63.Append(schemeColor109);

            defaultRunProperties76.Append(solidFill63);

            level5ParagraphProperties8.Append(noBullet24);
            level5ParagraphProperties8.Append(defaultRunProperties76);

            A.Level6ParagraphProperties level6ParagraphProperties8 = new A.Level6ParagraphProperties(){ LeftMargin = 2286000, Indent = 0 };
            A.NoBullet noBullet25 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties77 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill64 = new A.SolidFill();

            A.SchemeColor schemeColor110 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint13 = new A.Tint(){ Val = 75000 };

            schemeColor110.Append(tint13);

            solidFill64.Append(schemeColor110);

            defaultRunProperties77.Append(solidFill64);

            level6ParagraphProperties8.Append(noBullet25);
            level6ParagraphProperties8.Append(defaultRunProperties77);

            A.Level7ParagraphProperties level7ParagraphProperties8 = new A.Level7ParagraphProperties(){ LeftMargin = 2743200, Indent = 0 };
            A.NoBullet noBullet26 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties78 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill65 = new A.SolidFill();

            A.SchemeColor schemeColor111 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint14 = new A.Tint(){ Val = 75000 };

            schemeColor111.Append(tint14);

            solidFill65.Append(schemeColor111);

            defaultRunProperties78.Append(solidFill65);

            level7ParagraphProperties8.Append(noBullet26);
            level7ParagraphProperties8.Append(defaultRunProperties78);

            A.Level8ParagraphProperties level8ParagraphProperties8 = new A.Level8ParagraphProperties(){ LeftMargin = 3200400, Indent = 0 };
            A.NoBullet noBullet27 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties79 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill66 = new A.SolidFill();

            A.SchemeColor schemeColor112 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint15 = new A.Tint(){ Val = 75000 };

            schemeColor112.Append(tint15);

            solidFill66.Append(schemeColor112);

            defaultRunProperties79.Append(solidFill66);

            level8ParagraphProperties8.Append(noBullet27);
            level8ParagraphProperties8.Append(defaultRunProperties79);

            A.Level9ParagraphProperties level9ParagraphProperties8 = new A.Level9ParagraphProperties(){ LeftMargin = 3657600, Indent = 0 };
            A.NoBullet noBullet28 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties80 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill67 = new A.SolidFill();

            A.SchemeColor schemeColor113 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint16 = new A.Tint(){ Val = 75000 };

            schemeColor113.Append(tint16);

            solidFill67.Append(schemeColor113);

            defaultRunProperties80.Append(solidFill67);

            level9ParagraphProperties8.Append(noBullet28);
            level9ParagraphProperties8.Append(defaultRunProperties80);

            listStyle20.Append(level1ParagraphProperties14);
            listStyle20.Append(level2ParagraphProperties8);
            listStyle20.Append(level3ParagraphProperties8);
            listStyle20.Append(level4ParagraphProperties8);
            listStyle20.Append(level5ParagraphProperties8);
            listStyle20.Append(level6ParagraphProperties8);
            listStyle20.Append(level7ParagraphProperties8);
            listStyle20.Append(level8ParagraphProperties8);
            listStyle20.Append(level9ParagraphProperties8);

            A.Paragraph paragraph28 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties12 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run20 = new A.Run();

            A.RunProperties runProperties26 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties26.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text26 = new A.Text();
            text26.Text = "Click to edit Master text styles";

            run20.Append(runProperties26);
            run20.Append(text26);

            paragraph28.Append(paragraphProperties12);
            paragraph28.Append(run20);

            textBody20.Append(bodyProperties20);
            textBody20.Append(listStyle20);
            textBody20.Append(paragraph28);

            shape20.Append(nonVisualShapeProperties20);
            shape20.Append(shapeProperties30);
            shape20.Append(textBody20);

            Shape shape21 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties21 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties36 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Date Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties21 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks21 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties21.Append(shapeLocks21);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties36 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape21 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties36.Append(placeholderShape21);

            nonVisualShapeProperties21.Append(nonVisualDrawingProperties36);
            nonVisualShapeProperties21.Append(nonVisualShapeDrawingProperties21);
            nonVisualShapeProperties21.Append(applicationNonVisualDrawingProperties36);
            ShapeProperties shapeProperties31 = new ShapeProperties();

            TextBody textBody21 = new TextBody();
            A.BodyProperties bodyProperties21 = new A.BodyProperties();
            A.ListStyle listStyle21 = new A.ListStyle();

            A.Paragraph paragraph29 = new A.Paragraph();

            A.Field field7 = new A.Field(){ Id = "{CE1A2D98-1BBD-4706-A118-AAC2A16BEAD3}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties27 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties27.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text27 = new A.Text();
            text27.Text = "2012/10/3";

            field7.Append(runProperties27);
            field7.Append(text27);
            A.EndParagraphRunProperties endParagraphRunProperties19 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph29.Append(field7);
            paragraph29.Append(endParagraphRunProperties19);

            textBody21.Append(bodyProperties21);
            textBody21.Append(listStyle21);
            textBody21.Append(paragraph29);

            shape21.Append(nonVisualShapeProperties21);
            shape21.Append(shapeProperties31);
            shape21.Append(textBody21);

            Shape shape22 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties22 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties37 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Footer Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties22 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks22 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties22.Append(shapeLocks22);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties37 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape22 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties37.Append(placeholderShape22);

            nonVisualShapeProperties22.Append(nonVisualDrawingProperties37);
            nonVisualShapeProperties22.Append(nonVisualShapeDrawingProperties22);
            nonVisualShapeProperties22.Append(applicationNonVisualDrawingProperties37);
            ShapeProperties shapeProperties32 = new ShapeProperties();

            TextBody textBody22 = new TextBody();
            A.BodyProperties bodyProperties22 = new A.BodyProperties();
            A.ListStyle listStyle22 = new A.ListStyle();

            A.Paragraph paragraph30 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties20 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph30.Append(endParagraphRunProperties20);

            textBody22.Append(bodyProperties22);
            textBody22.Append(listStyle22);
            textBody22.Append(paragraph30);

            shape22.Append(nonVisualShapeProperties22);
            shape22.Append(shapeProperties32);
            shape22.Append(textBody22);

            Shape shape23 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties23 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties38 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Slide Number Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties23 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks23 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties23.Append(shapeLocks23);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties38 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape23 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties38.Append(placeholderShape23);

            nonVisualShapeProperties23.Append(nonVisualDrawingProperties38);
            nonVisualShapeProperties23.Append(nonVisualShapeDrawingProperties23);
            nonVisualShapeProperties23.Append(applicationNonVisualDrawingProperties38);
            ShapeProperties shapeProperties33 = new ShapeProperties();

            TextBody textBody23 = new TextBody();
            A.BodyProperties bodyProperties23 = new A.BodyProperties();
            A.ListStyle listStyle23 = new A.ListStyle();

            A.Paragraph paragraph31 = new A.Paragraph();

            A.Field field8 = new A.Field(){ Id = "{D107CD50-7081-433F-A1F2-156B4E14F4F4}", Type = "slidenum" };

            A.RunProperties runProperties28 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties28.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text28 = new A.Text();
            text28.Text = "‹#›";

            field8.Append(runProperties28);
            field8.Append(text28);
            A.EndParagraphRunProperties endParagraphRunProperties21 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph31.Append(field8);
            paragraph31.Append(endParagraphRunProperties21);

            textBody23.Append(bodyProperties23);
            textBody23.Append(listStyle23);
            textBody23.Append(paragraph31);

            shape23.Append(nonVisualShapeProperties23);
            shape23.Append(shapeProperties33);
            shape23.Append(textBody23);

            ConnectionShape connectionShape11 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties11 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties39 = new NonVisualDrawingProperties(){ Id = (UInt32Value)7U, Name = "Straight Connector 6" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties11 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties39 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties11.Append(nonVisualDrawingProperties39);
            nonVisualConnectionShapeProperties11.Append(nonVisualConnectorShapeDrawingProperties11);
            nonVisualConnectionShapeProperties11.Append(applicationNonVisualDrawingProperties39);

            ShapeProperties shapeProperties34 = new ShapeProperties();

            A.Transform2D transform2D23 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset28 = new A.Offset(){ X = 11278949L, Y = 2963333L };
            A.Extents extents28 = new A.Extents(){ Cx = 913052L, Cy = 912812L };

            transform2D23.Append(offset28);
            transform2D23.Append(extents28);

            A.PresetGeometry presetGeometry16 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList16 = new A.AdjustValueList();

            presetGeometry16.Append(adjustValueList16);

            A.Outline outline12 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill68 = new A.SolidFill();
            A.SchemeColor schemeColor114 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill68.Append(schemeColor114);

            outline12.Append(solidFill68);

            shapeProperties34.Append(transform2D23);
            shapeProperties34.Append(presetGeometry16);
            shapeProperties34.Append(outline12);

            ShapeStyle shapeStyle11 = new ShapeStyle();

            A.LineReference lineReference11 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor115 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference11.Append(schemeColor115);

            A.FillReference fillReference11 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor116 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference11.Append(schemeColor116);

            A.EffectReference effectReference11 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor117 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference11.Append(schemeColor117);

            A.FontReference fontReference11 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor118 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference11.Append(schemeColor118);

            shapeStyle11.Append(lineReference11);
            shapeStyle11.Append(fillReference11);
            shapeStyle11.Append(effectReference11);
            shapeStyle11.Append(fontReference11);

            connectionShape11.Append(nonVisualConnectionShapeProperties11);
            connectionShape11.Append(shapeProperties34);
            connectionShape11.Append(shapeStyle11);

            ConnectionShape connectionShape12 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties12 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties40 = new NonVisualDrawingProperties(){ Id = (UInt32Value)8U, Name = "Straight Connector 7" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties12 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties40 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties12.Append(nonVisualDrawingProperties40);
            nonVisualConnectionShapeProperties12.Append(nonVisualConnectorShapeDrawingProperties12);
            nonVisualConnectionShapeProperties12.Append(applicationNonVisualDrawingProperties40);

            ShapeProperties shapeProperties35 = new ShapeProperties();

            A.Transform2D transform2D24 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset29 = new A.Offset(){ X = 9209368L, Y = 3190344L };
            A.Extents extents29 = new A.Extents(){ Cx = 2982634L, Cy = 2981856L };

            transform2D24.Append(offset29);
            transform2D24.Append(extents29);

            A.PresetGeometry presetGeometry17 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList17 = new A.AdjustValueList();

            presetGeometry17.Append(adjustValueList17);

            A.Outline outline13 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill69 = new A.SolidFill();
            A.SchemeColor schemeColor119 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill69.Append(schemeColor119);

            outline13.Append(solidFill69);

            shapeProperties35.Append(transform2D24);
            shapeProperties35.Append(presetGeometry17);
            shapeProperties35.Append(outline13);

            ShapeStyle shapeStyle12 = new ShapeStyle();

            A.LineReference lineReference12 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor120 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference12.Append(schemeColor120);

            A.FillReference fillReference12 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor121 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference12.Append(schemeColor121);

            A.EffectReference effectReference12 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor122 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference12.Append(schemeColor122);

            A.FontReference fontReference12 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor123 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference12.Append(schemeColor123);

            shapeStyle12.Append(lineReference12);
            shapeStyle12.Append(fillReference12);
            shapeStyle12.Append(effectReference12);
            shapeStyle12.Append(fontReference12);

            connectionShape12.Append(nonVisualConnectionShapeProperties12);
            connectionShape12.Append(shapeProperties35);
            connectionShape12.Append(shapeStyle12);

            ConnectionShape connectionShape13 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties13 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties41 = new NonVisualDrawingProperties(){ Id = (UInt32Value)9U, Name = "Straight Connector 8" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties13 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties41 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties13.Append(nonVisualDrawingProperties41);
            nonVisualConnectionShapeProperties13.Append(nonVisualConnectorShapeDrawingProperties13);
            nonVisualConnectionShapeProperties13.Append(applicationNonVisualDrawingProperties41);

            ShapeProperties shapeProperties36 = new ShapeProperties();

            A.Transform2D transform2D25 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset30 = new A.Offset(){ X = 10294973L, Y = 3285068L };
            A.Extents extents30 = new A.Extents(){ Cx = 1897028L, Cy = 1896533L };

            transform2D25.Append(offset30);
            transform2D25.Append(extents30);

            A.PresetGeometry presetGeometry18 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList18 = new A.AdjustValueList();

            presetGeometry18.Append(adjustValueList18);

            A.Outline outline14 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill70 = new A.SolidFill();
            A.SchemeColor schemeColor124 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill70.Append(schemeColor124);

            outline14.Append(solidFill70);

            shapeProperties36.Append(transform2D25);
            shapeProperties36.Append(presetGeometry18);
            shapeProperties36.Append(outline14);

            ShapeStyle shapeStyle13 = new ShapeStyle();

            A.LineReference lineReference13 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor125 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference13.Append(schemeColor125);

            A.FillReference fillReference13 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor126 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference13.Append(schemeColor126);

            A.EffectReference effectReference13 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor127 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference13.Append(schemeColor127);

            A.FontReference fontReference13 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor128 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference13.Append(schemeColor128);

            shapeStyle13.Append(lineReference13);
            shapeStyle13.Append(fillReference13);
            shapeStyle13.Append(effectReference13);
            shapeStyle13.Append(fontReference13);

            connectionShape13.Append(nonVisualConnectionShapeProperties13);
            connectionShape13.Append(shapeProperties36);
            connectionShape13.Append(shapeStyle13);

            ConnectionShape connectionShape14 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties14 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties42 = new NonVisualDrawingProperties(){ Id = (UInt32Value)10U, Name = "Straight Connector 9" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties14 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties42 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties14.Append(nonVisualDrawingProperties42);
            nonVisualConnectionShapeProperties14.Append(nonVisualConnectorShapeDrawingProperties14);
            nonVisualConnectionShapeProperties14.Append(applicationNonVisualDrawingProperties42);

            ShapeProperties shapeProperties37 = new ShapeProperties();

            A.Transform2D transform2D26 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset31 = new A.Offset(){ X = 10445823L, Y = 3131080L };
            A.Extents extents31 = new A.Extents(){ Cx = 1746177L, Cy = 1745720L };

            transform2D26.Append(offset31);
            transform2D26.Append(extents31);

            A.PresetGeometry presetGeometry19 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList19 = new A.AdjustValueList();

            presetGeometry19.Append(adjustValueList19);

            A.Outline outline15 = new A.Outline(){ Width = 28575 };

            A.SolidFill solidFill71 = new A.SolidFill();
            A.SchemeColor schemeColor129 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill71.Append(schemeColor129);

            outline15.Append(solidFill71);

            shapeProperties37.Append(transform2D26);
            shapeProperties37.Append(presetGeometry19);
            shapeProperties37.Append(outline15);

            ShapeStyle shapeStyle14 = new ShapeStyle();

            A.LineReference lineReference14 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor130 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference14.Append(schemeColor130);

            A.FillReference fillReference14 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor131 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference14.Append(schemeColor131);

            A.EffectReference effectReference14 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor132 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference14.Append(schemeColor132);

            A.FontReference fontReference14 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor133 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference14.Append(schemeColor133);

            shapeStyle14.Append(lineReference14);
            shapeStyle14.Append(fillReference14);
            shapeStyle14.Append(effectReference14);
            shapeStyle14.Append(fontReference14);

            connectionShape14.Append(nonVisualConnectionShapeProperties14);
            connectionShape14.Append(shapeProperties37);
            connectionShape14.Append(shapeStyle14);

            ConnectionShape connectionShape15 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties15 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties43 = new NonVisualDrawingProperties(){ Id = (UInt32Value)11U, Name = "Straight Connector 10" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties15 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties43 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties15.Append(nonVisualDrawingProperties43);
            nonVisualConnectionShapeProperties15.Append(nonVisualConnectorShapeDrawingProperties15);
            nonVisualConnectionShapeProperties15.Append(applicationNonVisualDrawingProperties43);

            ShapeProperties shapeProperties38 = new ShapeProperties();

            A.Transform2D transform2D27 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset32 = new A.Offset(){ X = 10921671L, Y = 3683002L };
            A.Extents extents32 = new A.Extents(){ Cx = 1270332L, Cy = 1269999L };

            transform2D27.Append(offset32);
            transform2D27.Append(extents32);

            A.PresetGeometry presetGeometry20 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList20 = new A.AdjustValueList();

            presetGeometry20.Append(adjustValueList20);

            A.Outline outline16 = new A.Outline(){ Width = 28575 };

            A.SolidFill solidFill72 = new A.SolidFill();
            A.SchemeColor schemeColor134 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill72.Append(schemeColor134);

            outline16.Append(solidFill72);

            shapeProperties38.Append(transform2D27);
            shapeProperties38.Append(presetGeometry20);
            shapeProperties38.Append(outline16);

            ShapeStyle shapeStyle15 = new ShapeStyle();

            A.LineReference lineReference15 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor135 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference15.Append(schemeColor135);

            A.FillReference fillReference15 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor136 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference15.Append(schemeColor136);

            A.EffectReference effectReference15 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor137 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference15.Append(schemeColor137);

            A.FontReference fontReference15 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor138 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference15.Append(schemeColor138);

            shapeStyle15.Append(lineReference15);
            shapeStyle15.Append(fillReference15);
            shapeStyle15.Append(effectReference15);
            shapeStyle15.Append(fontReference15);

            connectionShape15.Append(nonVisualConnectionShapeProperties15);
            connectionShape15.Append(shapeProperties38);
            connectionShape15.Append(shapeStyle15);

            shapeTree5.Append(nonVisualGroupShapeProperties5);
            shapeTree5.Append(groupShapeProperties5);
            shapeTree5.Append(shape19);
            shapeTree5.Append(shape20);
            shapeTree5.Append(shape21);
            shapeTree5.Append(shape22);
            shapeTree5.Append(shape23);
            shapeTree5.Append(connectionShape11);
            shapeTree5.Append(connectionShape12);
            shapeTree5.Append(connectionShape13);
            shapeTree5.Append(connectionShape14);
            shapeTree5.Append(connectionShape15);

            CommonSlideDataExtensionList commonSlideDataExtensionList5 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension5 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId5 = new P14.CreationId(){ Val = (UInt32Value)283821911U };
            creationId5.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension5.Append(creationId5);

            commonSlideDataExtensionList5.Append(commonSlideDataExtension5);

            commonSlideData5.Append(shapeTree5);
            commonSlideData5.Append(commonSlideDataExtensionList5);

            ColorMapOverride colorMapOverride4 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping4 = new A.MasterColorMapping();

            colorMapOverride4.Append(masterColorMapping4);

            Timing timing5 = new Timing();

            TimeNodeList timeNodeList5 = new TimeNodeList();

            ParallelTimeNode parallelTimeNode5 = new ParallelTimeNode();
            CommonTimeNode commonTimeNode5 = new CommonTimeNode(){ Id = (UInt32Value)1U, Duration = "indefinite", Restart = TimeNodeRestartValues.Never, NodeType = TimeNodeValues.TmingRoot };

            parallelTimeNode5.Append(commonTimeNode5);

            timeNodeList5.Append(parallelTimeNode5);

            timing5.Append(timeNodeList5);

            slideLayout3.Append(commonSlideData5);
            slideLayout3.Append(colorMapOverride4);
            slideLayout3.Append(timing5);

            slideLayoutPart3.SlideLayout = slideLayout3;
        }

        // Generates content of themePart1.
        private void GenerateThemePart1Content(ThemePart themePart1)
        {
            A.Theme theme1 = new A.Theme(){ Name = "Slice" };
            theme1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            A.ThemeElements themeElements1 = new A.ThemeElements();

            A.ColorScheme colorScheme1 = new A.ColorScheme(){ Name = "Slice HD-RCA" };

            A.Dark1Color dark1Color1 = new A.Dark1Color();
            A.SystemColor systemColor1 = new A.SystemColor(){ Val = A.SystemColorValues.WindowText, LastColor = "000000" };

            dark1Color1.Append(systemColor1);

            A.Light1Color light1Color1 = new A.Light1Color();
            A.SystemColor systemColor2 = new A.SystemColor(){ Val = A.SystemColorValues.Window, LastColor = "FFFFFF" };

            light1Color1.Append(systemColor2);

            A.Dark2Color dark2Color1 = new A.Dark2Color();
            A.RgbColorModelHex rgbColorModelHex1 = new A.RgbColorModelHex(){ Val = "537D0B" };

            dark2Color1.Append(rgbColorModelHex1);

            A.Light2Color light2Color1 = new A.Light2Color();
            A.RgbColorModelHex rgbColorModelHex2 = new A.RgbColorModelHex(){ Val = "A9E257" };

            light2Color1.Append(rgbColorModelHex2);

            A.Accent1Color accent1Color1 = new A.Accent1Color();
            A.RgbColorModelHex rgbColorModelHex3 = new A.RgbColorModelHex(){ Val = "38540A" };

            accent1Color1.Append(rgbColorModelHex3);

            A.Accent2Color accent2Color1 = new A.Accent2Color();
            A.RgbColorModelHex rgbColorModelHex4 = new A.RgbColorModelHex(){ Val = "31A274" };

            accent2Color1.Append(rgbColorModelHex4);

            A.Accent3Color accent3Color1 = new A.Accent3Color();
            A.RgbColorModelHex rgbColorModelHex5 = new A.RgbColorModelHex(){ Val = "236073" };

            accent3Color1.Append(rgbColorModelHex5);

            A.Accent4Color accent4Color1 = new A.Accent4Color();
            A.RgbColorModelHex rgbColorModelHex6 = new A.RgbColorModelHex(){ Val = "6C4D90" };

            accent4Color1.Append(rgbColorModelHex6);

            A.Accent5Color accent5Color1 = new A.Accent5Color();
            A.RgbColorModelHex rgbColorModelHex7 = new A.RgbColorModelHex(){ Val = "983C27" };

            accent5Color1.Append(rgbColorModelHex7);

            A.Accent6Color accent6Color1 = new A.Accent6Color();
            A.RgbColorModelHex rgbColorModelHex8 = new A.RgbColorModelHex(){ Val = "CD811F" };

            accent6Color1.Append(rgbColorModelHex8);

            A.Hyperlink hyperlink1 = new A.Hyperlink();
            A.RgbColorModelHex rgbColorModelHex9 = new A.RgbColorModelHex(){ Val = "293F06" };

            hyperlink1.Append(rgbColorModelHex9);

            A.FollowedHyperlinkColor followedHyperlinkColor1 = new A.FollowedHyperlinkColor();
            A.RgbColorModelHex rgbColorModelHex10 = new A.RgbColorModelHex(){ Val = "68883A" };

            followedHyperlinkColor1.Append(rgbColorModelHex10);

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

            A.FontScheme fontScheme1 = new A.FontScheme(){ Name = "Slice HD-RCA" };

            A.MajorFont majorFont1 = new A.MajorFont();
            A.LatinFont latinFont32 = new A.LatinFont(){ Typeface = "Century Gothic", Panose = "020B0502020202020204" };
            A.EastAsianFont eastAsianFont29 = new A.EastAsianFont(){ Typeface = "" };
            A.ComplexScriptFont complexScriptFont29 = new A.ComplexScriptFont(){ Typeface = "" };

            majorFont1.Append(latinFont32);
            majorFont1.Append(eastAsianFont29);
            majorFont1.Append(complexScriptFont29);

            A.MinorFont minorFont1 = new A.MinorFont();
            A.LatinFont latinFont33 = new A.LatinFont(){ Typeface = "Century Gothic", Panose = "020B0502020202020204" };
            A.EastAsianFont eastAsianFont30 = new A.EastAsianFont(){ Typeface = "" };
            A.ComplexScriptFont complexScriptFont30 = new A.ComplexScriptFont(){ Typeface = "" };

            minorFont1.Append(latinFont33);
            minorFont1.Append(eastAsianFont30);
            minorFont1.Append(complexScriptFont30);

            fontScheme1.Append(majorFont1);
            fontScheme1.Append(minorFont1);

            A.FormatScheme formatScheme1 = new A.FormatScheme(){ Name = "Slice HD-RCA" };

            A.FillStyleList fillStyleList1 = new A.FillStyleList();

            A.SolidFill solidFill73 = new A.SolidFill();
            A.SchemeColor schemeColor139 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill73.Append(schemeColor139);

            A.GradientFill gradientFill1 = new A.GradientFill(){ RotateWithShape = true };

            A.GradientStopList gradientStopList1 = new A.GradientStopList();

            A.GradientStop gradientStop1 = new A.GradientStop(){ Position = 0 };

            A.SchemeColor schemeColor140 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint17 = new A.Tint(){ Val = 62000 };
            A.HueModulation hueModulation1 = new A.HueModulation(){ Val = 94000 };
            A.SaturationModulation saturationModulation1 = new A.SaturationModulation(){ Val = 140000 };
            A.LuminanceModulation luminanceModulation11 = new A.LuminanceModulation(){ Val = 110000 };

            schemeColor140.Append(tint17);
            schemeColor140.Append(hueModulation1);
            schemeColor140.Append(saturationModulation1);
            schemeColor140.Append(luminanceModulation11);

            gradientStop1.Append(schemeColor140);

            A.GradientStop gradientStop2 = new A.GradientStop(){ Position = 100000 };

            A.SchemeColor schemeColor141 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint18 = new A.Tint(){ Val = 84000 };
            A.SaturationModulation saturationModulation2 = new A.SaturationModulation(){ Val = 160000 };

            schemeColor141.Append(tint18);
            schemeColor141.Append(saturationModulation2);

            gradientStop2.Append(schemeColor141);

            gradientStopList1.Append(gradientStop1);
            gradientStopList1.Append(gradientStop2);
            A.LinearGradientFill linearGradientFill1 = new A.LinearGradientFill(){ Angle = 5400000, Scaled = false };

            gradientFill1.Append(gradientStopList1);
            gradientFill1.Append(linearGradientFill1);

            A.GradientFill gradientFill2 = new A.GradientFill(){ RotateWithShape = true };

            A.GradientStopList gradientStopList2 = new A.GradientStopList();

            A.GradientStop gradientStop3 = new A.GradientStop(){ Position = 0 };

            A.SchemeColor schemeColor142 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint19 = new A.Tint(){ Val = 98000 };
            A.HueModulation hueModulation2 = new A.HueModulation(){ Val = 94000 };
            A.SaturationModulation saturationModulation3 = new A.SaturationModulation(){ Val = 130000 };
            A.LuminanceModulation luminanceModulation12 = new A.LuminanceModulation(){ Val = 128000 };

            schemeColor142.Append(tint19);
            schemeColor142.Append(hueModulation2);
            schemeColor142.Append(saturationModulation3);
            schemeColor142.Append(luminanceModulation12);

            gradientStop3.Append(schemeColor142);

            A.GradientStop gradientStop4 = new A.GradientStop(){ Position = 100000 };

            A.SchemeColor schemeColor143 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Shade shade1 = new A.Shade(){ Val = 94000 };
            A.LuminanceModulation luminanceModulation13 = new A.LuminanceModulation(){ Val = 88000 };

            schemeColor143.Append(shade1);
            schemeColor143.Append(luminanceModulation13);

            gradientStop4.Append(schemeColor143);

            gradientStopList2.Append(gradientStop3);
            gradientStopList2.Append(gradientStop4);
            A.LinearGradientFill linearGradientFill2 = new A.LinearGradientFill(){ Angle = 5400000, Scaled = false };

            gradientFill2.Append(gradientStopList2);
            gradientFill2.Append(linearGradientFill2);

            fillStyleList1.Append(solidFill73);
            fillStyleList1.Append(gradientFill1);
            fillStyleList1.Append(gradientFill2);

            A.LineStyleList lineStyleList1 = new A.LineStyleList();

            A.Outline outline17 = new A.Outline(){ Width = 9525, CapType = A.LineCapValues.Round, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill74 = new A.SolidFill();

            A.SchemeColor schemeColor144 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint20 = new A.Tint(){ Val = 76000 };
            A.Alpha alpha1 = new A.Alpha(){ Val = 60000 };
            A.HueModulation hueModulation3 = new A.HueModulation(){ Val = 94000 };

            schemeColor144.Append(tint20);
            schemeColor144.Append(alpha1);
            schemeColor144.Append(hueModulation3);

            solidFill74.Append(schemeColor144);
            A.PresetDash presetDash1 = new A.PresetDash(){ Val = A.PresetLineDashValues.Solid };

            outline17.Append(solidFill74);
            outline17.Append(presetDash1);

            A.Outline outline18 = new A.Outline(){ Width = 15875, CapType = A.LineCapValues.Round, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill75 = new A.SolidFill();

            A.SchemeColor schemeColor145 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.HueModulation hueModulation4 = new A.HueModulation(){ Val = 94000 };

            schemeColor145.Append(hueModulation4);

            solidFill75.Append(schemeColor145);
            A.PresetDash presetDash2 = new A.PresetDash(){ Val = A.PresetLineDashValues.Solid };

            outline18.Append(solidFill75);
            outline18.Append(presetDash2);

            A.Outline outline19 = new A.Outline(){ Width = 28575, CapType = A.LineCapValues.Round, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill76 = new A.SolidFill();
            A.SchemeColor schemeColor146 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill76.Append(schemeColor146);
            A.PresetDash presetDash3 = new A.PresetDash(){ Val = A.PresetLineDashValues.Solid };

            outline19.Append(solidFill76);
            outline19.Append(presetDash3);

            lineStyleList1.Append(outline17);
            lineStyleList1.Append(outline18);
            lineStyleList1.Append(outline19);

            A.EffectStyleList effectStyleList1 = new A.EffectStyleList();

            A.EffectStyle effectStyle1 = new A.EffectStyle();
            A.EffectList effectList12 = new A.EffectList();

            effectStyle1.Append(effectList12);

            A.EffectStyle effectStyle2 = new A.EffectStyle();

            A.EffectList effectList13 = new A.EffectList();

            A.InnerShadow innerShadow1 = new A.InnerShadow(){ BlurRadius = 25400L, Distance = 12700L, Direction = 13500000 };

            A.RgbColorModelHex rgbColorModelHex11 = new A.RgbColorModelHex(){ Val = "000000" };
            A.Alpha alpha2 = new A.Alpha(){ Val = 45000 };

            rgbColorModelHex11.Append(alpha2);

            innerShadow1.Append(rgbColorModelHex11);

            effectList13.Append(innerShadow1);

            effectStyle2.Append(effectList13);

            A.EffectStyle effectStyle3 = new A.EffectStyle();

            A.EffectList effectList14 = new A.EffectList();

            A.OuterShadow outerShadow1 = new A.OuterShadow(){ BlurRadius = 50800L, Distance = 38100L, Direction = 5400000, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex12 = new A.RgbColorModelHex(){ Val = "000000" };
            A.Alpha alpha3 = new A.Alpha(){ Val = 46000 };

            rgbColorModelHex12.Append(alpha3);

            outerShadow1.Append(rgbColorModelHex12);

            effectList14.Append(outerShadow1);

            A.Scene3DType scene3DType1 = new A.Scene3DType();

            A.Camera camera1 = new A.Camera(){ Preset = A.PresetCameraValues.OrthographicFront };
            A.Rotation rotation1 = new A.Rotation(){ Latitude = 0, Longitude = 0, Revolution = 0 };

            camera1.Append(rotation1);
            A.LightRig lightRig1 = new A.LightRig(){ Rig = A.LightRigValues.ThreePoints, Direction = A.LightRigDirectionValues.Top };

            scene3DType1.Append(camera1);
            scene3DType1.Append(lightRig1);

            A.Shape3DType shape3DType1 = new A.Shape3DType(){ PresetMaterial = A.PresetMaterialTypeValues.Plastic };
            A.BevelTop bevelTop1 = new A.BevelTop(){ Width = 25400L, Height = 25400L };

            shape3DType1.Append(bevelTop1);

            effectStyle3.Append(effectList14);
            effectStyle3.Append(scene3DType1);
            effectStyle3.Append(shape3DType1);

            effectStyleList1.Append(effectStyle1);
            effectStyleList1.Append(effectStyle2);
            effectStyleList1.Append(effectStyle3);

            A.BackgroundFillStyleList backgroundFillStyleList1 = new A.BackgroundFillStyleList();

            A.SolidFill solidFill77 = new A.SolidFill();
            A.SchemeColor schemeColor147 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill77.Append(schemeColor147);

            A.GradientFill gradientFill3 = new A.GradientFill(){ RotateWithShape = true };

            A.GradientStopList gradientStopList3 = new A.GradientStopList();

            A.GradientStop gradientStop5 = new A.GradientStop(){ Position = 10000 };

            A.SchemeColor schemeColor148 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint21 = new A.Tint(){ Val = 97000 };
            A.HueModulation hueModulation5 = new A.HueModulation(){ Val = 92000 };
            A.SaturationModulation saturationModulation4 = new A.SaturationModulation(){ Val = 169000 };
            A.LuminanceModulation luminanceModulation14 = new A.LuminanceModulation(){ Val = 164000 };

            schemeColor148.Append(tint21);
            schemeColor148.Append(hueModulation5);
            schemeColor148.Append(saturationModulation4);
            schemeColor148.Append(luminanceModulation14);

            gradientStop5.Append(schemeColor148);

            A.GradientStop gradientStop6 = new A.GradientStop(){ Position = 100000 };

            A.SchemeColor schemeColor149 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Shade shade2 = new A.Shade(){ Val = 96000 };
            A.SaturationModulation saturationModulation5 = new A.SaturationModulation(){ Val = 120000 };
            A.LuminanceModulation luminanceModulation15 = new A.LuminanceModulation(){ Val = 90000 };

            schemeColor149.Append(shade2);
            schemeColor149.Append(saturationModulation5);
            schemeColor149.Append(luminanceModulation15);

            gradientStop6.Append(schemeColor149);

            gradientStopList3.Append(gradientStop5);
            gradientStopList3.Append(gradientStop6);
            A.LinearGradientFill linearGradientFill3 = new A.LinearGradientFill(){ Angle = 6120000, Scaled = true };

            gradientFill3.Append(gradientStopList3);
            gradientFill3.Append(linearGradientFill3);

            A.GradientFill gradientFill4 = new A.GradientFill(){ RotateWithShape = true };

            A.GradientStopList gradientStopList4 = new A.GradientStopList();

            A.GradientStop gradientStop7 = new A.GradientStop(){ Position = 0 };

            A.SchemeColor schemeColor150 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint22 = new A.Tint(){ Val = 97000 };
            A.HueModulation hueModulation6 = new A.HueModulation(){ Val = 92000 };
            A.SaturationModulation saturationModulation6 = new A.SaturationModulation(){ Val = 169000 };
            A.LuminanceModulation luminanceModulation16 = new A.LuminanceModulation(){ Val = 164000 };

            schemeColor150.Append(tint22);
            schemeColor150.Append(hueModulation6);
            schemeColor150.Append(saturationModulation6);
            schemeColor150.Append(luminanceModulation16);

            gradientStop7.Append(schemeColor150);

            A.GradientStop gradientStop8 = new A.GradientStop(){ Position = 100000 };

            A.SchemeColor schemeColor151 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Shade shade3 = new A.Shade(){ Val = 96000 };
            A.SaturationModulation saturationModulation7 = new A.SaturationModulation(){ Val = 120000 };
            A.LuminanceModulation luminanceModulation17 = new A.LuminanceModulation(){ Val = 90000 };

            schemeColor151.Append(shade3);
            schemeColor151.Append(saturationModulation7);
            schemeColor151.Append(luminanceModulation17);

            gradientStop8.Append(schemeColor151);

            gradientStopList4.Append(gradientStop7);
            gradientStopList4.Append(gradientStop8);

            A.PathGradientFill pathGradientFill1 = new A.PathGradientFill(){ Path = A.PathShadeValues.Circle };
            A.FillToRectangle fillToRectangle1 = new A.FillToRectangle(){ Bottom = 100000 };

            pathGradientFill1.Append(fillToRectangle1);

            gradientFill4.Append(gradientStopList4);
            gradientFill4.Append(pathGradientFill1);

            backgroundFillStyleList1.Append(solidFill77);
            backgroundFillStyleList1.Append(gradientFill3);
            backgroundFillStyleList1.Append(gradientFill4);

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

            Thm15.ThemeFamily themeFamily1 = new Thm15.ThemeFamily(){ Name = "Slice", Id = "{0507925B-6AC9-4358-8E18-C330545D08F8}", Vid = "{24C90B2D-6D41-4755-90A4-ED86E7EA9F03}" };
            themeFamily1.AddNamespaceDeclaration("thm15", "http://schemas.microsoft.com/office/thememl/2012/main");

            officeStyleSheetExtension1.Append(themeFamily1);

            officeStyleSheetExtensionList1.Append(officeStyleSheetExtension1);

            theme1.Append(themeElements1);
            theme1.Append(objectDefaults1);
            theme1.Append(extraColorSchemeList1);
            theme1.Append(officeStyleSheetExtensionList1);

            themePart1.Theme = theme1;
        }

        // Generates content of slideLayoutPart4.
        private void GenerateSlideLayoutPart4Content(SlideLayoutPart slideLayoutPart4)
        {
            SlideLayout slideLayout4 = new SlideLayout(){ Type = SlideLayoutValues.SectionHeader, Preserve = true };
            slideLayout4.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout4.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout4.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData6 = new CommonSlideData(){ Name = "Section Header" };

            ShapeTree shapeTree6 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties6 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties44 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties6 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties44 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties6.Append(nonVisualDrawingProperties44);
            nonVisualGroupShapeProperties6.Append(nonVisualGroupShapeDrawingProperties6);
            nonVisualGroupShapeProperties6.Append(applicationNonVisualDrawingProperties44);

            GroupShapeProperties groupShapeProperties6 = new GroupShapeProperties();

            A.TransformGroup transformGroup6 = new A.TransformGroup();
            A.Offset offset33 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents33 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset6 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents6 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup6.Append(offset33);
            transformGroup6.Append(extents33);
            transformGroup6.Append(childOffset6);
            transformGroup6.Append(childExtents6);

            groupShapeProperties6.Append(transformGroup6);

            Shape shape24 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties24 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties45 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties24 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks24 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties24.Append(shapeLocks24);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties45 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape24 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties45.Append(placeholderShape24);

            nonVisualShapeProperties24.Append(nonVisualDrawingProperties45);
            nonVisualShapeProperties24.Append(nonVisualShapeDrawingProperties24);
            nonVisualShapeProperties24.Append(applicationNonVisualDrawingProperties45);

            ShapeProperties shapeProperties39 = new ShapeProperties();

            A.Transform2D transform2D28 = new A.Transform2D();
            A.Offset offset34 = new A.Offset(){ X = 684390L, Y = 2006600L };
            A.Extents extents34 = new A.Extents(){ Cx = 8536624L, Cy = 2281600L };

            transform2D28.Append(offset34);
            transform2D28.Append(extents34);

            shapeProperties39.Append(transform2D28);

            TextBody textBody24 = new TextBody();

            A.BodyProperties bodyProperties24 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Bottom };
            A.NormalAutoFit normalAutoFit10 = new A.NormalAutoFit();

            bodyProperties24.Append(normalAutoFit10);

            A.ListStyle listStyle24 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties15 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Left };
            A.DefaultRunProperties defaultRunProperties81 = new A.DefaultRunProperties(){ FontSize = 3600, Bold = false, Capital = A.TextCapsValues.All };

            level1ParagraphProperties15.Append(defaultRunProperties81);

            listStyle24.Append(level1ParagraphProperties15);

            A.Paragraph paragraph32 = new A.Paragraph();

            A.Run run21 = new A.Run();

            A.RunProperties runProperties29 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties29.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text29 = new A.Text();
            text29.Text = "Click to edit Master title style";

            run21.Append(runProperties29);
            run21.Append(text29);
            A.EndParagraphRunProperties endParagraphRunProperties22 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph32.Append(run21);
            paragraph32.Append(endParagraphRunProperties22);

            textBody24.Append(bodyProperties24);
            textBody24.Append(listStyle24);
            textBody24.Append(paragraph32);

            shape24.Append(nonVisualShapeProperties24);
            shape24.Append(shapeProperties39);
            shape24.Append(textBody24);

            Shape shape25 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties25 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties46 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Text Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties25 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks25 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties25.Append(shapeLocks25);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties46 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape25 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties46.Append(placeholderShape25);

            nonVisualShapeProperties25.Append(nonVisualDrawingProperties46);
            nonVisualShapeProperties25.Append(nonVisualShapeDrawingProperties25);
            nonVisualShapeProperties25.Append(applicationNonVisualDrawingProperties46);

            ShapeProperties shapeProperties40 = new ShapeProperties();

            A.Transform2D transform2D29 = new A.Transform2D();
            A.Offset offset35 = new A.Offset(){ X = 684391L, Y = 4495800L };
            A.Extents extents35 = new A.Extents(){ Cx = 8536623L, Cy = 1498600L };

            transform2D29.Append(offset35);
            transform2D29.Append(extents35);

            shapeProperties40.Append(transform2D29);

            TextBody textBody25 = new TextBody();

            A.BodyProperties bodyProperties25 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Top };
            A.NormalAutoFit normalAutoFit11 = new A.NormalAutoFit();

            bodyProperties25.Append(normalAutoFit11);

            A.ListStyle listStyle25 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties16 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0, Alignment = A.TextAlignmentTypeValues.Left };
            A.NoBullet noBullet29 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties82 = new A.DefaultRunProperties(){ FontSize = 1800 };

            A.SolidFill solidFill78 = new A.SolidFill();

            A.SchemeColor schemeColor152 = new A.SchemeColor(){ Val = A.SchemeColorValues.Background2 };
            A.LuminanceModulation luminanceModulation18 = new A.LuminanceModulation(){ Val = 75000 };

            schemeColor152.Append(luminanceModulation18);

            solidFill78.Append(schemeColor152);

            defaultRunProperties82.Append(solidFill78);

            level1ParagraphProperties16.Append(noBullet29);
            level1ParagraphProperties16.Append(defaultRunProperties82);

            A.Level2ParagraphProperties level2ParagraphProperties9 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Indent = 0 };
            A.NoBullet noBullet30 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties83 = new A.DefaultRunProperties(){ FontSize = 1800 };

            A.SolidFill solidFill79 = new A.SolidFill();

            A.SchemeColor schemeColor153 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint23 = new A.Tint(){ Val = 75000 };

            schemeColor153.Append(tint23);

            solidFill79.Append(schemeColor153);

            defaultRunProperties83.Append(solidFill79);

            level2ParagraphProperties9.Append(noBullet30);
            level2ParagraphProperties9.Append(defaultRunProperties83);

            A.Level3ParagraphProperties level3ParagraphProperties9 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Indent = 0 };
            A.NoBullet noBullet31 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties84 = new A.DefaultRunProperties(){ FontSize = 1600 };

            A.SolidFill solidFill80 = new A.SolidFill();

            A.SchemeColor schemeColor154 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint24 = new A.Tint(){ Val = 75000 };

            schemeColor154.Append(tint24);

            solidFill80.Append(schemeColor154);

            defaultRunProperties84.Append(solidFill80);

            level3ParagraphProperties9.Append(noBullet31);
            level3ParagraphProperties9.Append(defaultRunProperties84);

            A.Level4ParagraphProperties level4ParagraphProperties9 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Indent = 0 };
            A.NoBullet noBullet32 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties85 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill81 = new A.SolidFill();

            A.SchemeColor schemeColor155 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint25 = new A.Tint(){ Val = 75000 };

            schemeColor155.Append(tint25);

            solidFill81.Append(schemeColor155);

            defaultRunProperties85.Append(solidFill81);

            level4ParagraphProperties9.Append(noBullet32);
            level4ParagraphProperties9.Append(defaultRunProperties85);

            A.Level5ParagraphProperties level5ParagraphProperties9 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Indent = 0 };
            A.NoBullet noBullet33 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties86 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill82 = new A.SolidFill();

            A.SchemeColor schemeColor156 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint26 = new A.Tint(){ Val = 75000 };

            schemeColor156.Append(tint26);

            solidFill82.Append(schemeColor156);

            defaultRunProperties86.Append(solidFill82);

            level5ParagraphProperties9.Append(noBullet33);
            level5ParagraphProperties9.Append(defaultRunProperties86);

            A.Level6ParagraphProperties level6ParagraphProperties9 = new A.Level6ParagraphProperties(){ LeftMargin = 2286000, Indent = 0 };
            A.NoBullet noBullet34 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties87 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill83 = new A.SolidFill();

            A.SchemeColor schemeColor157 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint27 = new A.Tint(){ Val = 75000 };

            schemeColor157.Append(tint27);

            solidFill83.Append(schemeColor157);

            defaultRunProperties87.Append(solidFill83);

            level6ParagraphProperties9.Append(noBullet34);
            level6ParagraphProperties9.Append(defaultRunProperties87);

            A.Level7ParagraphProperties level7ParagraphProperties9 = new A.Level7ParagraphProperties(){ LeftMargin = 2743200, Indent = 0 };
            A.NoBullet noBullet35 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties88 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill84 = new A.SolidFill();

            A.SchemeColor schemeColor158 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint28 = new A.Tint(){ Val = 75000 };

            schemeColor158.Append(tint28);

            solidFill84.Append(schemeColor158);

            defaultRunProperties88.Append(solidFill84);

            level7ParagraphProperties9.Append(noBullet35);
            level7ParagraphProperties9.Append(defaultRunProperties88);

            A.Level8ParagraphProperties level8ParagraphProperties9 = new A.Level8ParagraphProperties(){ LeftMargin = 3200400, Indent = 0 };
            A.NoBullet noBullet36 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties89 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill85 = new A.SolidFill();

            A.SchemeColor schemeColor159 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint29 = new A.Tint(){ Val = 75000 };

            schemeColor159.Append(tint29);

            solidFill85.Append(schemeColor159);

            defaultRunProperties89.Append(solidFill85);

            level8ParagraphProperties9.Append(noBullet36);
            level8ParagraphProperties9.Append(defaultRunProperties89);

            A.Level9ParagraphProperties level9ParagraphProperties9 = new A.Level9ParagraphProperties(){ LeftMargin = 3657600, Indent = 0 };
            A.NoBullet noBullet37 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties90 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill86 = new A.SolidFill();

            A.SchemeColor schemeColor160 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint30 = new A.Tint(){ Val = 75000 };

            schemeColor160.Append(tint30);

            solidFill86.Append(schemeColor160);

            defaultRunProperties90.Append(solidFill86);

            level9ParagraphProperties9.Append(noBullet37);
            level9ParagraphProperties9.Append(defaultRunProperties90);

            listStyle25.Append(level1ParagraphProperties16);
            listStyle25.Append(level2ParagraphProperties9);
            listStyle25.Append(level3ParagraphProperties9);
            listStyle25.Append(level4ParagraphProperties9);
            listStyle25.Append(level5ParagraphProperties9);
            listStyle25.Append(level6ParagraphProperties9);
            listStyle25.Append(level7ParagraphProperties9);
            listStyle25.Append(level8ParagraphProperties9);
            listStyle25.Append(level9ParagraphProperties9);

            A.Paragraph paragraph33 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties13 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run22 = new A.Run();

            A.RunProperties runProperties30 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties30.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text30 = new A.Text();
            text30.Text = "Click to edit Master text styles";

            run22.Append(runProperties30);
            run22.Append(text30);

            paragraph33.Append(paragraphProperties13);
            paragraph33.Append(run22);

            textBody25.Append(bodyProperties25);
            textBody25.Append(listStyle25);
            textBody25.Append(paragraph33);

            shape25.Append(nonVisualShapeProperties25);
            shape25.Append(shapeProperties40);
            shape25.Append(textBody25);

            Shape shape26 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties26 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties47 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Date Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties26 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks26 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties26.Append(shapeLocks26);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties47 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape26 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties47.Append(placeholderShape26);

            nonVisualShapeProperties26.Append(nonVisualDrawingProperties47);
            nonVisualShapeProperties26.Append(nonVisualShapeDrawingProperties26);
            nonVisualShapeProperties26.Append(applicationNonVisualDrawingProperties47);
            ShapeProperties shapeProperties41 = new ShapeProperties();

            TextBody textBody26 = new TextBody();
            A.BodyProperties bodyProperties26 = new A.BodyProperties();
            A.ListStyle listStyle26 = new A.ListStyle();

            A.Paragraph paragraph34 = new A.Paragraph();

            A.Field field9 = new A.Field(){ Id = "{CE1A2D98-1BBD-4706-A118-AAC2A16BEAD3}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties31 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties31.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text31 = new A.Text();
            text31.Text = "2012/10/3";

            field9.Append(runProperties31);
            field9.Append(text31);
            A.EndParagraphRunProperties endParagraphRunProperties23 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph34.Append(field9);
            paragraph34.Append(endParagraphRunProperties23);

            textBody26.Append(bodyProperties26);
            textBody26.Append(listStyle26);
            textBody26.Append(paragraph34);

            shape26.Append(nonVisualShapeProperties26);
            shape26.Append(shapeProperties41);
            shape26.Append(textBody26);

            Shape shape27 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties27 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties48 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Footer Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties27 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks27 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties27.Append(shapeLocks27);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties48 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape27 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties48.Append(placeholderShape27);

            nonVisualShapeProperties27.Append(nonVisualDrawingProperties48);
            nonVisualShapeProperties27.Append(nonVisualShapeDrawingProperties27);
            nonVisualShapeProperties27.Append(applicationNonVisualDrawingProperties48);
            ShapeProperties shapeProperties42 = new ShapeProperties();

            TextBody textBody27 = new TextBody();
            A.BodyProperties bodyProperties27 = new A.BodyProperties();
            A.ListStyle listStyle27 = new A.ListStyle();

            A.Paragraph paragraph35 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties24 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph35.Append(endParagraphRunProperties24);

            textBody27.Append(bodyProperties27);
            textBody27.Append(listStyle27);
            textBody27.Append(paragraph35);

            shape27.Append(nonVisualShapeProperties27);
            shape27.Append(shapeProperties42);
            shape27.Append(textBody27);

            Shape shape28 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties28 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties49 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Slide Number Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties28 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks28 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties28.Append(shapeLocks28);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties49 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape28 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties49.Append(placeholderShape28);

            nonVisualShapeProperties28.Append(nonVisualDrawingProperties49);
            nonVisualShapeProperties28.Append(nonVisualShapeDrawingProperties28);
            nonVisualShapeProperties28.Append(applicationNonVisualDrawingProperties49);
            ShapeProperties shapeProperties43 = new ShapeProperties();

            TextBody textBody28 = new TextBody();
            A.BodyProperties bodyProperties28 = new A.BodyProperties();
            A.ListStyle listStyle28 = new A.ListStyle();

            A.Paragraph paragraph36 = new A.Paragraph();

            A.Field field10 = new A.Field(){ Id = "{D107CD50-7081-433F-A1F2-156B4E14F4F4}", Type = "slidenum" };

            A.RunProperties runProperties32 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties32.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text32 = new A.Text();
            text32.Text = "‹#›";

            field10.Append(runProperties32);
            field10.Append(text32);
            A.EndParagraphRunProperties endParagraphRunProperties25 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph36.Append(field10);
            paragraph36.Append(endParagraphRunProperties25);

            textBody28.Append(bodyProperties28);
            textBody28.Append(listStyle28);
            textBody28.Append(paragraph36);

            shape28.Append(nonVisualShapeProperties28);
            shape28.Append(shapeProperties43);
            shape28.Append(textBody28);

            ConnectionShape connectionShape16 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties16 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties50 = new NonVisualDrawingProperties(){ Id = (UInt32Value)7U, Name = "Straight Connector 6" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties16 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties50 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties16.Append(nonVisualDrawingProperties50);
            nonVisualConnectionShapeProperties16.Append(nonVisualConnectorShapeDrawingProperties16);
            nonVisualConnectionShapeProperties16.Append(applicationNonVisualDrawingProperties50);

            ShapeProperties shapeProperties44 = new ShapeProperties();

            A.Transform2D transform2D30 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset36 = new A.Offset(){ X = 11278949L, Y = 2963333L };
            A.Extents extents36 = new A.Extents(){ Cx = 913052L, Cy = 912812L };

            transform2D30.Append(offset36);
            transform2D30.Append(extents36);

            A.PresetGeometry presetGeometry21 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList21 = new A.AdjustValueList();

            presetGeometry21.Append(adjustValueList21);

            A.Outline outline20 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill87 = new A.SolidFill();
            A.SchemeColor schemeColor161 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill87.Append(schemeColor161);

            outline20.Append(solidFill87);

            shapeProperties44.Append(transform2D30);
            shapeProperties44.Append(presetGeometry21);
            shapeProperties44.Append(outline20);

            ShapeStyle shapeStyle16 = new ShapeStyle();

            A.LineReference lineReference16 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor162 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference16.Append(schemeColor162);

            A.FillReference fillReference16 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor163 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference16.Append(schemeColor163);

            A.EffectReference effectReference16 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor164 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference16.Append(schemeColor164);

            A.FontReference fontReference16 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor165 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference16.Append(schemeColor165);

            shapeStyle16.Append(lineReference16);
            shapeStyle16.Append(fillReference16);
            shapeStyle16.Append(effectReference16);
            shapeStyle16.Append(fontReference16);

            connectionShape16.Append(nonVisualConnectionShapeProperties16);
            connectionShape16.Append(shapeProperties44);
            connectionShape16.Append(shapeStyle16);

            ConnectionShape connectionShape17 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties17 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties51 = new NonVisualDrawingProperties(){ Id = (UInt32Value)8U, Name = "Straight Connector 7" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties17 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties51 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties17.Append(nonVisualDrawingProperties51);
            nonVisualConnectionShapeProperties17.Append(nonVisualConnectorShapeDrawingProperties17);
            nonVisualConnectionShapeProperties17.Append(applicationNonVisualDrawingProperties51);

            ShapeProperties shapeProperties45 = new ShapeProperties();

            A.Transform2D transform2D31 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset37 = new A.Offset(){ X = 9209368L, Y = 3190344L };
            A.Extents extents37 = new A.Extents(){ Cx = 2982634L, Cy = 2981856L };

            transform2D31.Append(offset37);
            transform2D31.Append(extents37);

            A.PresetGeometry presetGeometry22 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList22 = new A.AdjustValueList();

            presetGeometry22.Append(adjustValueList22);

            A.Outline outline21 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill88 = new A.SolidFill();
            A.SchemeColor schemeColor166 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill88.Append(schemeColor166);

            outline21.Append(solidFill88);

            shapeProperties45.Append(transform2D31);
            shapeProperties45.Append(presetGeometry22);
            shapeProperties45.Append(outline21);

            ShapeStyle shapeStyle17 = new ShapeStyle();

            A.LineReference lineReference17 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor167 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference17.Append(schemeColor167);

            A.FillReference fillReference17 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor168 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference17.Append(schemeColor168);

            A.EffectReference effectReference17 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor169 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference17.Append(schemeColor169);

            A.FontReference fontReference17 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor170 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference17.Append(schemeColor170);

            shapeStyle17.Append(lineReference17);
            shapeStyle17.Append(fillReference17);
            shapeStyle17.Append(effectReference17);
            shapeStyle17.Append(fontReference17);

            connectionShape17.Append(nonVisualConnectionShapeProperties17);
            connectionShape17.Append(shapeProperties45);
            connectionShape17.Append(shapeStyle17);

            ConnectionShape connectionShape18 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties18 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties52 = new NonVisualDrawingProperties(){ Id = (UInt32Value)9U, Name = "Straight Connector 8" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties18 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties52 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties18.Append(nonVisualDrawingProperties52);
            nonVisualConnectionShapeProperties18.Append(nonVisualConnectorShapeDrawingProperties18);
            nonVisualConnectionShapeProperties18.Append(applicationNonVisualDrawingProperties52);

            ShapeProperties shapeProperties46 = new ShapeProperties();

            A.Transform2D transform2D32 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset38 = new A.Offset(){ X = 10294973L, Y = 3285068L };
            A.Extents extents38 = new A.Extents(){ Cx = 1897028L, Cy = 1896533L };

            transform2D32.Append(offset38);
            transform2D32.Append(extents38);

            A.PresetGeometry presetGeometry23 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList23 = new A.AdjustValueList();

            presetGeometry23.Append(adjustValueList23);

            A.Outline outline22 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill89 = new A.SolidFill();
            A.SchemeColor schemeColor171 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill89.Append(schemeColor171);

            outline22.Append(solidFill89);

            shapeProperties46.Append(transform2D32);
            shapeProperties46.Append(presetGeometry23);
            shapeProperties46.Append(outline22);

            ShapeStyle shapeStyle18 = new ShapeStyle();

            A.LineReference lineReference18 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor172 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference18.Append(schemeColor172);

            A.FillReference fillReference18 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor173 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference18.Append(schemeColor173);

            A.EffectReference effectReference18 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor174 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference18.Append(schemeColor174);

            A.FontReference fontReference18 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor175 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference18.Append(schemeColor175);

            shapeStyle18.Append(lineReference18);
            shapeStyle18.Append(fillReference18);
            shapeStyle18.Append(effectReference18);
            shapeStyle18.Append(fontReference18);

            connectionShape18.Append(nonVisualConnectionShapeProperties18);
            connectionShape18.Append(shapeProperties46);
            connectionShape18.Append(shapeStyle18);

            ConnectionShape connectionShape19 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties19 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties53 = new NonVisualDrawingProperties(){ Id = (UInt32Value)10U, Name = "Straight Connector 9" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties19 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties53 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties19.Append(nonVisualDrawingProperties53);
            nonVisualConnectionShapeProperties19.Append(nonVisualConnectorShapeDrawingProperties19);
            nonVisualConnectionShapeProperties19.Append(applicationNonVisualDrawingProperties53);

            ShapeProperties shapeProperties47 = new ShapeProperties();

            A.Transform2D transform2D33 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset39 = new A.Offset(){ X = 10445823L, Y = 3131080L };
            A.Extents extents39 = new A.Extents(){ Cx = 1746177L, Cy = 1745720L };

            transform2D33.Append(offset39);
            transform2D33.Append(extents39);

            A.PresetGeometry presetGeometry24 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList24 = new A.AdjustValueList();

            presetGeometry24.Append(adjustValueList24);

            A.Outline outline23 = new A.Outline(){ Width = 28575 };

            A.SolidFill solidFill90 = new A.SolidFill();
            A.SchemeColor schemeColor176 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill90.Append(schemeColor176);

            outline23.Append(solidFill90);

            shapeProperties47.Append(transform2D33);
            shapeProperties47.Append(presetGeometry24);
            shapeProperties47.Append(outline23);

            ShapeStyle shapeStyle19 = new ShapeStyle();

            A.LineReference lineReference19 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor177 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference19.Append(schemeColor177);

            A.FillReference fillReference19 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor178 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference19.Append(schemeColor178);

            A.EffectReference effectReference19 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor179 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference19.Append(schemeColor179);

            A.FontReference fontReference19 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor180 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference19.Append(schemeColor180);

            shapeStyle19.Append(lineReference19);
            shapeStyle19.Append(fillReference19);
            shapeStyle19.Append(effectReference19);
            shapeStyle19.Append(fontReference19);

            connectionShape19.Append(nonVisualConnectionShapeProperties19);
            connectionShape19.Append(shapeProperties47);
            connectionShape19.Append(shapeStyle19);

            ConnectionShape connectionShape20 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties20 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties54 = new NonVisualDrawingProperties(){ Id = (UInt32Value)11U, Name = "Straight Connector 10" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties20 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties54 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties20.Append(nonVisualDrawingProperties54);
            nonVisualConnectionShapeProperties20.Append(nonVisualConnectorShapeDrawingProperties20);
            nonVisualConnectionShapeProperties20.Append(applicationNonVisualDrawingProperties54);

            ShapeProperties shapeProperties48 = new ShapeProperties();

            A.Transform2D transform2D34 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset40 = new A.Offset(){ X = 10921671L, Y = 3683002L };
            A.Extents extents40 = new A.Extents(){ Cx = 1270332L, Cy = 1269999L };

            transform2D34.Append(offset40);
            transform2D34.Append(extents40);

            A.PresetGeometry presetGeometry25 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList25 = new A.AdjustValueList();

            presetGeometry25.Append(adjustValueList25);

            A.Outline outline24 = new A.Outline(){ Width = 28575 };

            A.SolidFill solidFill91 = new A.SolidFill();
            A.SchemeColor schemeColor181 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill91.Append(schemeColor181);

            outline24.Append(solidFill91);

            shapeProperties48.Append(transform2D34);
            shapeProperties48.Append(presetGeometry25);
            shapeProperties48.Append(outline24);

            ShapeStyle shapeStyle20 = new ShapeStyle();

            A.LineReference lineReference20 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor182 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference20.Append(schemeColor182);

            A.FillReference fillReference20 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor183 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference20.Append(schemeColor183);

            A.EffectReference effectReference20 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor184 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference20.Append(schemeColor184);

            A.FontReference fontReference20 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor185 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference20.Append(schemeColor185);

            shapeStyle20.Append(lineReference20);
            shapeStyle20.Append(fillReference20);
            shapeStyle20.Append(effectReference20);
            shapeStyle20.Append(fontReference20);

            connectionShape20.Append(nonVisualConnectionShapeProperties20);
            connectionShape20.Append(shapeProperties48);
            connectionShape20.Append(shapeStyle20);

            shapeTree6.Append(nonVisualGroupShapeProperties6);
            shapeTree6.Append(groupShapeProperties6);
            shapeTree6.Append(shape24);
            shapeTree6.Append(shape25);
            shapeTree6.Append(shape26);
            shapeTree6.Append(shape27);
            shapeTree6.Append(shape28);
            shapeTree6.Append(connectionShape16);
            shapeTree6.Append(connectionShape17);
            shapeTree6.Append(connectionShape18);
            shapeTree6.Append(connectionShape19);
            shapeTree6.Append(connectionShape20);

            CommonSlideDataExtensionList commonSlideDataExtensionList6 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension6 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId6 = new P14.CreationId(){ Val = (UInt32Value)4286813543U };
            creationId6.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension6.Append(creationId6);

            commonSlideDataExtensionList6.Append(commonSlideDataExtension6);

            commonSlideData6.Append(shapeTree6);
            commonSlideData6.Append(commonSlideDataExtensionList6);

            ColorMapOverride colorMapOverride5 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping5 = new A.MasterColorMapping();

            colorMapOverride5.Append(masterColorMapping5);

            Timing timing6 = new Timing();

            TimeNodeList timeNodeList6 = new TimeNodeList();

            ParallelTimeNode parallelTimeNode6 = new ParallelTimeNode();
            CommonTimeNode commonTimeNode6 = new CommonTimeNode(){ Id = (UInt32Value)1U, Duration = "indefinite", Restart = TimeNodeRestartValues.Never, NodeType = TimeNodeValues.TmingRoot };

            parallelTimeNode6.Append(commonTimeNode6);

            timeNodeList6.Append(parallelTimeNode6);

            timing6.Append(timeNodeList6);

            slideLayout4.Append(commonSlideData6);
            slideLayout4.Append(colorMapOverride5);
            slideLayout4.Append(timing6);

            slideLayoutPart4.SlideLayout = slideLayout4;
        }

        // Generates content of slideLayoutPart5.
        private void GenerateSlideLayoutPart5Content(SlideLayoutPart slideLayoutPart5)
        {
            SlideLayout slideLayout5 = new SlideLayout(){ Type = SlideLayoutValues.Blank, Preserve = true };
            slideLayout5.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout5.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout5.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData7 = new CommonSlideData(){ Name = "Blank" };

            ShapeTree shapeTree7 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties7 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties55 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties7 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties55 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties7.Append(nonVisualDrawingProperties55);
            nonVisualGroupShapeProperties7.Append(nonVisualGroupShapeDrawingProperties7);
            nonVisualGroupShapeProperties7.Append(applicationNonVisualDrawingProperties55);

            GroupShapeProperties groupShapeProperties7 = new GroupShapeProperties();

            A.TransformGroup transformGroup7 = new A.TransformGroup();
            A.Offset offset41 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents41 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset7 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents7 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup7.Append(offset41);
            transformGroup7.Append(extents41);
            transformGroup7.Append(childOffset7);
            transformGroup7.Append(childExtents7);

            groupShapeProperties7.Append(transformGroup7);

            Shape shape29 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties29 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties56 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Date Placeholder 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties29 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks29 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties29.Append(shapeLocks29);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties56 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape29 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties56.Append(placeholderShape29);

            nonVisualShapeProperties29.Append(nonVisualDrawingProperties56);
            nonVisualShapeProperties29.Append(nonVisualShapeDrawingProperties29);
            nonVisualShapeProperties29.Append(applicationNonVisualDrawingProperties56);
            ShapeProperties shapeProperties49 = new ShapeProperties();

            TextBody textBody29 = new TextBody();
            A.BodyProperties bodyProperties29 = new A.BodyProperties();
            A.ListStyle listStyle29 = new A.ListStyle();

            A.Paragraph paragraph37 = new A.Paragraph();

            A.Field field11 = new A.Field(){ Id = "{CE1A2D98-1BBD-4706-A118-AAC2A16BEAD3}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties33 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties33.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text33 = new A.Text();
            text33.Text = "2012/10/3";

            field11.Append(runProperties33);
            field11.Append(text33);
            A.EndParagraphRunProperties endParagraphRunProperties26 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph37.Append(field11);
            paragraph37.Append(endParagraphRunProperties26);

            textBody29.Append(bodyProperties29);
            textBody29.Append(listStyle29);
            textBody29.Append(paragraph37);

            shape29.Append(nonVisualShapeProperties29);
            shape29.Append(shapeProperties49);
            shape29.Append(textBody29);

            Shape shape30 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties30 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties57 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Footer Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties30 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks30 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties30.Append(shapeLocks30);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties57 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape30 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties57.Append(placeholderShape30);

            nonVisualShapeProperties30.Append(nonVisualDrawingProperties57);
            nonVisualShapeProperties30.Append(nonVisualShapeDrawingProperties30);
            nonVisualShapeProperties30.Append(applicationNonVisualDrawingProperties57);
            ShapeProperties shapeProperties50 = new ShapeProperties();

            TextBody textBody30 = new TextBody();
            A.BodyProperties bodyProperties30 = new A.BodyProperties();
            A.ListStyle listStyle30 = new A.ListStyle();

            A.Paragraph paragraph38 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties27 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph38.Append(endParagraphRunProperties27);

            textBody30.Append(bodyProperties30);
            textBody30.Append(listStyle30);
            textBody30.Append(paragraph38);

            shape30.Append(nonVisualShapeProperties30);
            shape30.Append(shapeProperties50);
            shape30.Append(textBody30);

            Shape shape31 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties31 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties58 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Slide Number Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties31 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks31 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties31.Append(shapeLocks31);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties58 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape31 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties58.Append(placeholderShape31);

            nonVisualShapeProperties31.Append(nonVisualDrawingProperties58);
            nonVisualShapeProperties31.Append(nonVisualShapeDrawingProperties31);
            nonVisualShapeProperties31.Append(applicationNonVisualDrawingProperties58);
            ShapeProperties shapeProperties51 = new ShapeProperties();

            TextBody textBody31 = new TextBody();
            A.BodyProperties bodyProperties31 = new A.BodyProperties();
            A.ListStyle listStyle31 = new A.ListStyle();

            A.Paragraph paragraph39 = new A.Paragraph();

            A.Field field12 = new A.Field(){ Id = "{D107CD50-7081-433F-A1F2-156B4E14F4F4}", Type = "slidenum" };

            A.RunProperties runProperties34 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties34.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text34 = new A.Text();
            text34.Text = "‹#›";

            field12.Append(runProperties34);
            field12.Append(text34);
            A.EndParagraphRunProperties endParagraphRunProperties28 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph39.Append(field12);
            paragraph39.Append(endParagraphRunProperties28);

            textBody31.Append(bodyProperties31);
            textBody31.Append(listStyle31);
            textBody31.Append(paragraph39);

            shape31.Append(nonVisualShapeProperties31);
            shape31.Append(shapeProperties51);
            shape31.Append(textBody31);

            ConnectionShape connectionShape21 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties21 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties59 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Straight Connector 4" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties21 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties59 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties21.Append(nonVisualDrawingProperties59);
            nonVisualConnectionShapeProperties21.Append(nonVisualConnectorShapeDrawingProperties21);
            nonVisualConnectionShapeProperties21.Append(applicationNonVisualDrawingProperties59);

            ShapeProperties shapeProperties52 = new ShapeProperties();

            A.Transform2D transform2D35 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset42 = new A.Offset(){ X = 11278949L, Y = 2963333L };
            A.Extents extents42 = new A.Extents(){ Cx = 913052L, Cy = 912812L };

            transform2D35.Append(offset42);
            transform2D35.Append(extents42);

            A.PresetGeometry presetGeometry26 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList26 = new A.AdjustValueList();

            presetGeometry26.Append(adjustValueList26);

            A.Outline outline25 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill92 = new A.SolidFill();
            A.SchemeColor schemeColor186 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill92.Append(schemeColor186);

            outline25.Append(solidFill92);

            shapeProperties52.Append(transform2D35);
            shapeProperties52.Append(presetGeometry26);
            shapeProperties52.Append(outline25);

            ShapeStyle shapeStyle21 = new ShapeStyle();

            A.LineReference lineReference21 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor187 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference21.Append(schemeColor187);

            A.FillReference fillReference21 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor188 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference21.Append(schemeColor188);

            A.EffectReference effectReference21 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor189 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference21.Append(schemeColor189);

            A.FontReference fontReference21 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor190 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference21.Append(schemeColor190);

            shapeStyle21.Append(lineReference21);
            shapeStyle21.Append(fillReference21);
            shapeStyle21.Append(effectReference21);
            shapeStyle21.Append(fontReference21);

            connectionShape21.Append(nonVisualConnectionShapeProperties21);
            connectionShape21.Append(shapeProperties52);
            connectionShape21.Append(shapeStyle21);

            ConnectionShape connectionShape22 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties22 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties60 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Straight Connector 5" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties22 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties60 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties22.Append(nonVisualDrawingProperties60);
            nonVisualConnectionShapeProperties22.Append(nonVisualConnectorShapeDrawingProperties22);
            nonVisualConnectionShapeProperties22.Append(applicationNonVisualDrawingProperties60);

            ShapeProperties shapeProperties53 = new ShapeProperties();

            A.Transform2D transform2D36 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset43 = new A.Offset(){ X = 9209368L, Y = 3190344L };
            A.Extents extents43 = new A.Extents(){ Cx = 2982634L, Cy = 2981856L };

            transform2D36.Append(offset43);
            transform2D36.Append(extents43);

            A.PresetGeometry presetGeometry27 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList27 = new A.AdjustValueList();

            presetGeometry27.Append(adjustValueList27);

            A.Outline outline26 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill93 = new A.SolidFill();
            A.SchemeColor schemeColor191 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill93.Append(schemeColor191);

            outline26.Append(solidFill93);

            shapeProperties53.Append(transform2D36);
            shapeProperties53.Append(presetGeometry27);
            shapeProperties53.Append(outline26);

            ShapeStyle shapeStyle22 = new ShapeStyle();

            A.LineReference lineReference22 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor192 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference22.Append(schemeColor192);

            A.FillReference fillReference22 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor193 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference22.Append(schemeColor193);

            A.EffectReference effectReference22 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor194 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference22.Append(schemeColor194);

            A.FontReference fontReference22 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor195 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference22.Append(schemeColor195);

            shapeStyle22.Append(lineReference22);
            shapeStyle22.Append(fillReference22);
            shapeStyle22.Append(effectReference22);
            shapeStyle22.Append(fontReference22);

            connectionShape22.Append(nonVisualConnectionShapeProperties22);
            connectionShape22.Append(shapeProperties53);
            connectionShape22.Append(shapeStyle22);

            ConnectionShape connectionShape23 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties23 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties61 = new NonVisualDrawingProperties(){ Id = (UInt32Value)7U, Name = "Straight Connector 6" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties23 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties61 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties23.Append(nonVisualDrawingProperties61);
            nonVisualConnectionShapeProperties23.Append(nonVisualConnectorShapeDrawingProperties23);
            nonVisualConnectionShapeProperties23.Append(applicationNonVisualDrawingProperties61);

            ShapeProperties shapeProperties54 = new ShapeProperties();

            A.Transform2D transform2D37 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset44 = new A.Offset(){ X = 10294973L, Y = 3285068L };
            A.Extents extents44 = new A.Extents(){ Cx = 1897028L, Cy = 1896533L };

            transform2D37.Append(offset44);
            transform2D37.Append(extents44);

            A.PresetGeometry presetGeometry28 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList28 = new A.AdjustValueList();

            presetGeometry28.Append(adjustValueList28);

            A.Outline outline27 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill94 = new A.SolidFill();
            A.SchemeColor schemeColor196 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill94.Append(schemeColor196);

            outline27.Append(solidFill94);

            shapeProperties54.Append(transform2D37);
            shapeProperties54.Append(presetGeometry28);
            shapeProperties54.Append(outline27);

            ShapeStyle shapeStyle23 = new ShapeStyle();

            A.LineReference lineReference23 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor197 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference23.Append(schemeColor197);

            A.FillReference fillReference23 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor198 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference23.Append(schemeColor198);

            A.EffectReference effectReference23 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor199 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference23.Append(schemeColor199);

            A.FontReference fontReference23 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor200 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference23.Append(schemeColor200);

            shapeStyle23.Append(lineReference23);
            shapeStyle23.Append(fillReference23);
            shapeStyle23.Append(effectReference23);
            shapeStyle23.Append(fontReference23);

            connectionShape23.Append(nonVisualConnectionShapeProperties23);
            connectionShape23.Append(shapeProperties54);
            connectionShape23.Append(shapeStyle23);

            ConnectionShape connectionShape24 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties24 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties62 = new NonVisualDrawingProperties(){ Id = (UInt32Value)8U, Name = "Straight Connector 7" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties24 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties62 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties24.Append(nonVisualDrawingProperties62);
            nonVisualConnectionShapeProperties24.Append(nonVisualConnectorShapeDrawingProperties24);
            nonVisualConnectionShapeProperties24.Append(applicationNonVisualDrawingProperties62);

            ShapeProperties shapeProperties55 = new ShapeProperties();

            A.Transform2D transform2D38 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset45 = new A.Offset(){ X = 10445823L, Y = 3131080L };
            A.Extents extents45 = new A.Extents(){ Cx = 1746177L, Cy = 1745720L };

            transform2D38.Append(offset45);
            transform2D38.Append(extents45);

            A.PresetGeometry presetGeometry29 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList29 = new A.AdjustValueList();

            presetGeometry29.Append(adjustValueList29);

            A.Outline outline28 = new A.Outline(){ Width = 28575 };

            A.SolidFill solidFill95 = new A.SolidFill();
            A.SchemeColor schemeColor201 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill95.Append(schemeColor201);

            outline28.Append(solidFill95);

            shapeProperties55.Append(transform2D38);
            shapeProperties55.Append(presetGeometry29);
            shapeProperties55.Append(outline28);

            ShapeStyle shapeStyle24 = new ShapeStyle();

            A.LineReference lineReference24 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor202 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference24.Append(schemeColor202);

            A.FillReference fillReference24 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor203 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference24.Append(schemeColor203);

            A.EffectReference effectReference24 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor204 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference24.Append(schemeColor204);

            A.FontReference fontReference24 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor205 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference24.Append(schemeColor205);

            shapeStyle24.Append(lineReference24);
            shapeStyle24.Append(fillReference24);
            shapeStyle24.Append(effectReference24);
            shapeStyle24.Append(fontReference24);

            connectionShape24.Append(nonVisualConnectionShapeProperties24);
            connectionShape24.Append(shapeProperties55);
            connectionShape24.Append(shapeStyle24);

            ConnectionShape connectionShape25 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties25 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties63 = new NonVisualDrawingProperties(){ Id = (UInt32Value)9U, Name = "Straight Connector 8" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties25 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties63 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties25.Append(nonVisualDrawingProperties63);
            nonVisualConnectionShapeProperties25.Append(nonVisualConnectorShapeDrawingProperties25);
            nonVisualConnectionShapeProperties25.Append(applicationNonVisualDrawingProperties63);

            ShapeProperties shapeProperties56 = new ShapeProperties();

            A.Transform2D transform2D39 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset46 = new A.Offset(){ X = 10921671L, Y = 3683002L };
            A.Extents extents46 = new A.Extents(){ Cx = 1270332L, Cy = 1269999L };

            transform2D39.Append(offset46);
            transform2D39.Append(extents46);

            A.PresetGeometry presetGeometry30 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList30 = new A.AdjustValueList();

            presetGeometry30.Append(adjustValueList30);

            A.Outline outline29 = new A.Outline(){ Width = 28575 };

            A.SolidFill solidFill96 = new A.SolidFill();
            A.SchemeColor schemeColor206 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill96.Append(schemeColor206);

            outline29.Append(solidFill96);

            shapeProperties56.Append(transform2D39);
            shapeProperties56.Append(presetGeometry30);
            shapeProperties56.Append(outline29);

            ShapeStyle shapeStyle25 = new ShapeStyle();

            A.LineReference lineReference25 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor207 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference25.Append(schemeColor207);

            A.FillReference fillReference25 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor208 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference25.Append(schemeColor208);

            A.EffectReference effectReference25 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor209 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference25.Append(schemeColor209);

            A.FontReference fontReference25 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor210 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference25.Append(schemeColor210);

            shapeStyle25.Append(lineReference25);
            shapeStyle25.Append(fillReference25);
            shapeStyle25.Append(effectReference25);
            shapeStyle25.Append(fontReference25);

            connectionShape25.Append(nonVisualConnectionShapeProperties25);
            connectionShape25.Append(shapeProperties56);
            connectionShape25.Append(shapeStyle25);

            shapeTree7.Append(nonVisualGroupShapeProperties7);
            shapeTree7.Append(groupShapeProperties7);
            shapeTree7.Append(shape29);
            shapeTree7.Append(shape30);
            shapeTree7.Append(shape31);
            shapeTree7.Append(connectionShape21);
            shapeTree7.Append(connectionShape22);
            shapeTree7.Append(connectionShape23);
            shapeTree7.Append(connectionShape24);
            shapeTree7.Append(connectionShape25);

            CommonSlideDataExtensionList commonSlideDataExtensionList7 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension7 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId7 = new P14.CreationId(){ Val = (UInt32Value)2634761331U };
            creationId7.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension7.Append(creationId7);

            commonSlideDataExtensionList7.Append(commonSlideDataExtension7);

            commonSlideData7.Append(shapeTree7);
            commonSlideData7.Append(commonSlideDataExtensionList7);

            ColorMapOverride colorMapOverride6 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping6 = new A.MasterColorMapping();

            colorMapOverride6.Append(masterColorMapping6);

            Timing timing7 = new Timing();

            TimeNodeList timeNodeList7 = new TimeNodeList();

            ParallelTimeNode parallelTimeNode7 = new ParallelTimeNode();
            CommonTimeNode commonTimeNode7 = new CommonTimeNode(){ Id = (UInt32Value)1U, Duration = "indefinite", Restart = TimeNodeRestartValues.Never, NodeType = TimeNodeValues.TmingRoot };

            parallelTimeNode7.Append(commonTimeNode7);

            timeNodeList7.Append(parallelTimeNode7);

            timing7.Append(timeNodeList7);

            slideLayout5.Append(commonSlideData7);
            slideLayout5.Append(colorMapOverride6);
            slideLayout5.Append(timing7);

            slideLayoutPart5.SlideLayout = slideLayout5;
        }

        // Generates content of slideLayoutPart6.
        private void GenerateSlideLayoutPart6Content(SlideLayoutPart slideLayoutPart6)
        {
            SlideLayout slideLayout6 = new SlideLayout(){ Preserve = true };
            slideLayout6.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout6.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout6.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData8 = new CommonSlideData(){ Name = "Quote with Caption" };

            ShapeTree shapeTree8 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties8 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties64 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties8 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties64 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties8.Append(nonVisualDrawingProperties64);
            nonVisualGroupShapeProperties8.Append(nonVisualGroupShapeDrawingProperties8);
            nonVisualGroupShapeProperties8.Append(applicationNonVisualDrawingProperties64);

            GroupShapeProperties groupShapeProperties8 = new GroupShapeProperties();

            A.TransformGroup transformGroup8 = new A.TransformGroup();
            A.Offset offset47 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents47 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset8 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents8 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup8.Append(offset47);
            transformGroup8.Append(extents47);
            transformGroup8.Append(childOffset8);
            transformGroup8.Append(childExtents8);

            groupShapeProperties8.Append(transformGroup8);

            Shape shape32 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties32 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties65 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties32 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks32 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties32.Append(shapeLocks32);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties65 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape32 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties65.Append(placeholderShape32);

            nonVisualShapeProperties32.Append(nonVisualDrawingProperties65);
            nonVisualShapeProperties32.Append(nonVisualShapeDrawingProperties32);
            nonVisualShapeProperties32.Append(applicationNonVisualDrawingProperties65);

            ShapeProperties shapeProperties57 = new ShapeProperties();

            A.Transform2D transform2D40 = new A.Transform2D();
            A.Offset offset48 = new A.Offset(){ X = 1141709L, Y = 685800L };
            A.Extents extents48 = new A.Extents(){ Cx = 9146383L, Cy = 2743200L };

            transform2D40.Append(offset48);
            transform2D40.Append(extents48);

            shapeProperties57.Append(transform2D40);

            TextBody textBody32 = new TextBody();

            A.BodyProperties bodyProperties32 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Center };
            A.NormalAutoFit normalAutoFit12 = new A.NormalAutoFit();

            bodyProperties32.Append(normalAutoFit12);

            A.ListStyle listStyle32 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties17 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Left };

            A.DefaultRunProperties defaultRunProperties91 = new A.DefaultRunProperties(){ FontSize = 3200, Bold = false, Capital = A.TextCapsValues.All };

            A.SolidFill solidFill97 = new A.SolidFill();
            A.SchemeColor schemeColor211 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill97.Append(schemeColor211);

            defaultRunProperties91.Append(solidFill97);

            level1ParagraphProperties17.Append(defaultRunProperties91);

            listStyle32.Append(level1ParagraphProperties17);

            A.Paragraph paragraph40 = new A.Paragraph();

            A.Run run23 = new A.Run();

            A.RunProperties runProperties35 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties35.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text35 = new A.Text();
            text35.Text = "Click to edit Master title style";

            run23.Append(runProperties35);
            run23.Append(text35);
            A.EndParagraphRunProperties endParagraphRunProperties29 = new A.EndParagraphRunProperties(){ Language = "en-US", Dirty = false };

            paragraph40.Append(run23);
            paragraph40.Append(endParagraphRunProperties29);

            textBody32.Append(bodyProperties32);
            textBody32.Append(listStyle32);
            textBody32.Append(paragraph40);

            shape32.Append(nonVisualShapeProperties32);
            shape32.Append(shapeProperties57);
            shape32.Append(textBody32);

            Shape shape33 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties33 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties66 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Text Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties33 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks33 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties33.Append(shapeLocks33);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties66 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape33 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties66.Append(placeholderShape33);

            nonVisualShapeProperties33.Append(nonVisualDrawingProperties66);
            nonVisualShapeProperties33.Append(nonVisualShapeDrawingProperties33);
            nonVisualShapeProperties33.Append(applicationNonVisualDrawingProperties66);

            ShapeProperties shapeProperties58 = new ShapeProperties();

            A.Transform2D transform2D41 = new A.Transform2D();
            A.Offset offset49 = new A.Offset(){ X = 684391L, Y = 4301068L };
            A.Extents extents49 = new A.Extents(){ Cx = 8536623L, Cy = 1684865L };

            transform2D41.Append(offset49);
            transform2D41.Append(extents49);

            shapeProperties58.Append(transform2D41);

            TextBody textBody33 = new TextBody();

            A.BodyProperties bodyProperties33 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Center };
            A.NormalAutoFit normalAutoFit13 = new A.NormalAutoFit();

            bodyProperties33.Append(normalAutoFit13);

            A.ListStyle listStyle33 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties18 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0, Alignment = A.TextAlignmentTypeValues.Left };
            A.NoBullet noBullet38 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties92 = new A.DefaultRunProperties(){ FontSize = 2000 };

            A.SolidFill solidFill98 = new A.SolidFill();

            A.SchemeColor schemeColor212 = new A.SchemeColor(){ Val = A.SchemeColorValues.Background2 };
            A.LuminanceModulation luminanceModulation19 = new A.LuminanceModulation(){ Val = 75000 };

            schemeColor212.Append(luminanceModulation19);

            solidFill98.Append(schemeColor212);

            defaultRunProperties92.Append(solidFill98);

            level1ParagraphProperties18.Append(noBullet38);
            level1ParagraphProperties18.Append(defaultRunProperties92);

            A.Level2ParagraphProperties level2ParagraphProperties10 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Indent = 0 };
            A.NoBullet noBullet39 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties93 = new A.DefaultRunProperties(){ FontSize = 1800 };

            A.SolidFill solidFill99 = new A.SolidFill();

            A.SchemeColor schemeColor213 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint31 = new A.Tint(){ Val = 75000 };

            schemeColor213.Append(tint31);

            solidFill99.Append(schemeColor213);

            defaultRunProperties93.Append(solidFill99);

            level2ParagraphProperties10.Append(noBullet39);
            level2ParagraphProperties10.Append(defaultRunProperties93);

            A.Level3ParagraphProperties level3ParagraphProperties10 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Indent = 0 };
            A.NoBullet noBullet40 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties94 = new A.DefaultRunProperties(){ FontSize = 1600 };

            A.SolidFill solidFill100 = new A.SolidFill();

            A.SchemeColor schemeColor214 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint32 = new A.Tint(){ Val = 75000 };

            schemeColor214.Append(tint32);

            solidFill100.Append(schemeColor214);

            defaultRunProperties94.Append(solidFill100);

            level3ParagraphProperties10.Append(noBullet40);
            level3ParagraphProperties10.Append(defaultRunProperties94);

            A.Level4ParagraphProperties level4ParagraphProperties10 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Indent = 0 };
            A.NoBullet noBullet41 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties95 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill101 = new A.SolidFill();

            A.SchemeColor schemeColor215 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint33 = new A.Tint(){ Val = 75000 };

            schemeColor215.Append(tint33);

            solidFill101.Append(schemeColor215);

            defaultRunProperties95.Append(solidFill101);

            level4ParagraphProperties10.Append(noBullet41);
            level4ParagraphProperties10.Append(defaultRunProperties95);

            A.Level5ParagraphProperties level5ParagraphProperties10 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Indent = 0 };
            A.NoBullet noBullet42 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties96 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill102 = new A.SolidFill();

            A.SchemeColor schemeColor216 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint34 = new A.Tint(){ Val = 75000 };

            schemeColor216.Append(tint34);

            solidFill102.Append(schemeColor216);

            defaultRunProperties96.Append(solidFill102);

            level5ParagraphProperties10.Append(noBullet42);
            level5ParagraphProperties10.Append(defaultRunProperties96);

            A.Level6ParagraphProperties level6ParagraphProperties10 = new A.Level6ParagraphProperties(){ LeftMargin = 2286000, Indent = 0 };
            A.NoBullet noBullet43 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties97 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill103 = new A.SolidFill();

            A.SchemeColor schemeColor217 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint35 = new A.Tint(){ Val = 75000 };

            schemeColor217.Append(tint35);

            solidFill103.Append(schemeColor217);

            defaultRunProperties97.Append(solidFill103);

            level6ParagraphProperties10.Append(noBullet43);
            level6ParagraphProperties10.Append(defaultRunProperties97);

            A.Level7ParagraphProperties level7ParagraphProperties10 = new A.Level7ParagraphProperties(){ LeftMargin = 2743200, Indent = 0 };
            A.NoBullet noBullet44 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties98 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill104 = new A.SolidFill();

            A.SchemeColor schemeColor218 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint36 = new A.Tint(){ Val = 75000 };

            schemeColor218.Append(tint36);

            solidFill104.Append(schemeColor218);

            defaultRunProperties98.Append(solidFill104);

            level7ParagraphProperties10.Append(noBullet44);
            level7ParagraphProperties10.Append(defaultRunProperties98);

            A.Level8ParagraphProperties level8ParagraphProperties10 = new A.Level8ParagraphProperties(){ LeftMargin = 3200400, Indent = 0 };
            A.NoBullet noBullet45 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties99 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill105 = new A.SolidFill();

            A.SchemeColor schemeColor219 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint37 = new A.Tint(){ Val = 75000 };

            schemeColor219.Append(tint37);

            solidFill105.Append(schemeColor219);

            defaultRunProperties99.Append(solidFill105);

            level8ParagraphProperties10.Append(noBullet45);
            level8ParagraphProperties10.Append(defaultRunProperties99);

            A.Level9ParagraphProperties level9ParagraphProperties10 = new A.Level9ParagraphProperties(){ LeftMargin = 3657600, Indent = 0 };
            A.NoBullet noBullet46 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties100 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill106 = new A.SolidFill();

            A.SchemeColor schemeColor220 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint38 = new A.Tint(){ Val = 75000 };

            schemeColor220.Append(tint38);

            solidFill106.Append(schemeColor220);

            defaultRunProperties100.Append(solidFill106);

            level9ParagraphProperties10.Append(noBullet46);
            level9ParagraphProperties10.Append(defaultRunProperties100);

            listStyle33.Append(level1ParagraphProperties18);
            listStyle33.Append(level2ParagraphProperties10);
            listStyle33.Append(level3ParagraphProperties10);
            listStyle33.Append(level4ParagraphProperties10);
            listStyle33.Append(level5ParagraphProperties10);
            listStyle33.Append(level6ParagraphProperties10);
            listStyle33.Append(level7ParagraphProperties10);
            listStyle33.Append(level8ParagraphProperties10);
            listStyle33.Append(level9ParagraphProperties10);

            A.Paragraph paragraph41 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties14 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run24 = new A.Run();

            A.RunProperties runProperties36 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties36.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text36 = new A.Text();
            text36.Text = "Click to edit Master text styles";

            run24.Append(runProperties36);
            run24.Append(text36);

            paragraph41.Append(paragraphProperties14);
            paragraph41.Append(run24);

            textBody33.Append(bodyProperties33);
            textBody33.Append(listStyle33);
            textBody33.Append(paragraph41);

            shape33.Append(nonVisualShapeProperties33);
            shape33.Append(shapeProperties58);
            shape33.Append(textBody33);

            Shape shape34 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties34 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties67 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Date Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties34 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks34 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties34.Append(shapeLocks34);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties67 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape34 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties67.Append(placeholderShape34);

            nonVisualShapeProperties34.Append(nonVisualDrawingProperties67);
            nonVisualShapeProperties34.Append(nonVisualShapeDrawingProperties34);
            nonVisualShapeProperties34.Append(applicationNonVisualDrawingProperties67);
            ShapeProperties shapeProperties59 = new ShapeProperties();

            TextBody textBody34 = new TextBody();
            A.BodyProperties bodyProperties34 = new A.BodyProperties();
            A.ListStyle listStyle34 = new A.ListStyle();

            A.Paragraph paragraph42 = new A.Paragraph();

            A.Field field13 = new A.Field(){ Id = "{CE1A2D98-1BBD-4706-A118-AAC2A16BEAD3}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties37 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties37.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text37 = new A.Text();
            text37.Text = "2012/10/3";

            field13.Append(runProperties37);
            field13.Append(text37);
            A.EndParagraphRunProperties endParagraphRunProperties30 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph42.Append(field13);
            paragraph42.Append(endParagraphRunProperties30);

            textBody34.Append(bodyProperties34);
            textBody34.Append(listStyle34);
            textBody34.Append(paragraph42);

            shape34.Append(nonVisualShapeProperties34);
            shape34.Append(shapeProperties59);
            shape34.Append(textBody34);

            Shape shape35 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties35 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties68 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Footer Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties35 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks35 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties35.Append(shapeLocks35);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties68 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape35 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties68.Append(placeholderShape35);

            nonVisualShapeProperties35.Append(nonVisualDrawingProperties68);
            nonVisualShapeProperties35.Append(nonVisualShapeDrawingProperties35);
            nonVisualShapeProperties35.Append(applicationNonVisualDrawingProperties68);
            ShapeProperties shapeProperties60 = new ShapeProperties();

            TextBody textBody35 = new TextBody();
            A.BodyProperties bodyProperties35 = new A.BodyProperties();
            A.ListStyle listStyle35 = new A.ListStyle();

            A.Paragraph paragraph43 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties31 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph43.Append(endParagraphRunProperties31);

            textBody35.Append(bodyProperties35);
            textBody35.Append(listStyle35);
            textBody35.Append(paragraph43);

            shape35.Append(nonVisualShapeProperties35);
            shape35.Append(shapeProperties60);
            shape35.Append(textBody35);

            Shape shape36 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties36 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties69 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Slide Number Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties36 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks36 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties36.Append(shapeLocks36);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties69 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape36 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties69.Append(placeholderShape36);

            nonVisualShapeProperties36.Append(nonVisualDrawingProperties69);
            nonVisualShapeProperties36.Append(nonVisualShapeDrawingProperties36);
            nonVisualShapeProperties36.Append(applicationNonVisualDrawingProperties69);
            ShapeProperties shapeProperties61 = new ShapeProperties();

            TextBody textBody36 = new TextBody();
            A.BodyProperties bodyProperties36 = new A.BodyProperties();
            A.ListStyle listStyle36 = new A.ListStyle();

            A.Paragraph paragraph44 = new A.Paragraph();

            A.Field field14 = new A.Field(){ Id = "{D107CD50-7081-433F-A1F2-156B4E14F4F4}", Type = "slidenum" };

            A.RunProperties runProperties38 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties38.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text38 = new A.Text();
            text38.Text = "‹#›";

            field14.Append(runProperties38);
            field14.Append(text38);
            A.EndParagraphRunProperties endParagraphRunProperties32 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph44.Append(field14);
            paragraph44.Append(endParagraphRunProperties32);

            textBody36.Append(bodyProperties36);
            textBody36.Append(listStyle36);
            textBody36.Append(paragraph44);

            shape36.Append(nonVisualShapeProperties36);
            shape36.Append(shapeProperties61);
            shape36.Append(textBody36);

            Shape shape37 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties37 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties70 = new NonVisualDrawingProperties(){ Id = (UInt32Value)10U, Name = "Text Placeholder 9" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties37 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks37 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties37.Append(shapeLocks37);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties70 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape37 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)13U };

            applicationNonVisualDrawingProperties70.Append(placeholderShape37);

            nonVisualShapeProperties37.Append(nonVisualDrawingProperties70);
            nonVisualShapeProperties37.Append(nonVisualShapeDrawingProperties37);
            nonVisualShapeProperties37.Append(applicationNonVisualDrawingProperties70);

            ShapeProperties shapeProperties62 = new ShapeProperties();

            A.Transform2D transform2D42 = new A.Transform2D();
            A.Offset offset50 = new A.Offset(){ X = 1446589L, Y = 3429000L };
            A.Extents extents50 = new A.Extents(){ Cx = 8536623L, Cy = 381000L };

            transform2D42.Append(offset50);
            transform2D42.Append(extents50);

            shapeProperties62.Append(transform2D42);

            TextBody textBody37 = new TextBody();
            A.BodyProperties bodyProperties37 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Center };

            A.ListStyle listStyle37 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties19 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0 };
            A.BulletFontText bulletFontText1 = new A.BulletFontText();
            A.NoBullet noBullet47 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties101 = new A.DefaultRunProperties();

            level1ParagraphProperties19.Append(bulletFontText1);
            level1ParagraphProperties19.Append(noBullet47);
            level1ParagraphProperties19.Append(defaultRunProperties101);

            A.Level2ParagraphProperties level2ParagraphProperties11 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Indent = 0 };
            A.BulletFontText bulletFontText2 = new A.BulletFontText();
            A.NoBullet noBullet48 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties102 = new A.DefaultRunProperties();

            level2ParagraphProperties11.Append(bulletFontText2);
            level2ParagraphProperties11.Append(noBullet48);
            level2ParagraphProperties11.Append(defaultRunProperties102);

            A.Level3ParagraphProperties level3ParagraphProperties11 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Indent = 0 };
            A.BulletFontText bulletFontText3 = new A.BulletFontText();
            A.NoBullet noBullet49 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties103 = new A.DefaultRunProperties();

            level3ParagraphProperties11.Append(bulletFontText3);
            level3ParagraphProperties11.Append(noBullet49);
            level3ParagraphProperties11.Append(defaultRunProperties103);

            A.Level4ParagraphProperties level4ParagraphProperties11 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Indent = 0 };
            A.BulletFontText bulletFontText4 = new A.BulletFontText();
            A.NoBullet noBullet50 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties104 = new A.DefaultRunProperties();

            level4ParagraphProperties11.Append(bulletFontText4);
            level4ParagraphProperties11.Append(noBullet50);
            level4ParagraphProperties11.Append(defaultRunProperties104);

            A.Level5ParagraphProperties level5ParagraphProperties11 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Indent = 0 };
            A.BulletFontText bulletFontText5 = new A.BulletFontText();
            A.NoBullet noBullet51 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties105 = new A.DefaultRunProperties();

            level5ParagraphProperties11.Append(bulletFontText5);
            level5ParagraphProperties11.Append(noBullet51);
            level5ParagraphProperties11.Append(defaultRunProperties105);

            listStyle37.Append(level1ParagraphProperties19);
            listStyle37.Append(level2ParagraphProperties11);
            listStyle37.Append(level3ParagraphProperties11);
            listStyle37.Append(level4ParagraphProperties11);
            listStyle37.Append(level5ParagraphProperties11);

            A.Paragraph paragraph45 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties15 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run25 = new A.Run();

            A.RunProperties runProperties39 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties39.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text39 = new A.Text();
            text39.Text = "Click to edit Master text styles";

            run25.Append(runProperties39);
            run25.Append(text39);

            paragraph45.Append(paragraphProperties15);
            paragraph45.Append(run25);

            textBody37.Append(bodyProperties37);
            textBody37.Append(listStyle37);
            textBody37.Append(paragraph45);

            shape37.Append(nonVisualShapeProperties37);
            shape37.Append(shapeProperties62);
            shape37.Append(textBody37);

            Shape shape38 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties38 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties71 = new NonVisualDrawingProperties(){ Id = (UInt32Value)14U, Name = "TextBox 13" };
            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties38 = new NonVisualShapeDrawingProperties(){ TextBox = true };
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties71 = new ApplicationNonVisualDrawingProperties();

            nonVisualShapeProperties38.Append(nonVisualDrawingProperties71);
            nonVisualShapeProperties38.Append(nonVisualShapeDrawingProperties38);
            nonVisualShapeProperties38.Append(applicationNonVisualDrawingProperties71);

            ShapeProperties shapeProperties63 = new ShapeProperties();

            A.Transform2D transform2D43 = new A.Transform2D();
            A.Offset offset51 = new A.Offset(){ X = 531950L, Y = 812222L };
            A.Extents extents51 = new A.Extents(){ Cx = 609759L, Cy = 584776L };

            transform2D43.Append(offset51);
            transform2D43.Append(extents51);

            A.PresetGeometry presetGeometry31 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList31 = new A.AdjustValueList();

            presetGeometry31.Append(adjustValueList31);

            shapeProperties63.Append(transform2D43);
            shapeProperties63.Append(presetGeometry31);

            TextBody textBody38 = new TextBody();

            A.BodyProperties bodyProperties38 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal, LeftInset = 91440, TopInset = 45720, RightInset = 91440, BottomInset = 45720, RightToLeftColumns = false, Anchor = A.TextAnchoringTypeValues.Center };
            A.NoAutoFit noAutoFit1 = new A.NoAutoFit();

            bodyProperties38.Append(noAutoFit1);

            A.ListStyle listStyle38 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties20 = new A.Level1ParagraphProperties();

            A.SpaceBefore spaceBefore11 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent11 = new A.SpacingPercent(){ Val = 0 };

            spaceBefore11.Append(spacingPercent11);
            A.NoBullet noBullet52 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties106 = new A.DefaultRunProperties(){ FontSize = 3200, Bold = false, Capital = A.TextCapsValues.All };

            A.Outline outline30 = new A.Outline(){ Width = 3175, CompoundLineType = A.CompoundLineValues.Single };
            A.NoFill noFill2 = new A.NoFill();

            outline30.Append(noFill2);

            A.EffectList effectList15 = new A.EffectList();

            A.Glow glow1 = new A.Glow(){ Radius = 38100L };

            A.SchemeColor schemeColor221 = new A.SchemeColor(){ Val = A.SchemeColorValues.Background1 };
            A.LuminanceModulation luminanceModulation20 = new A.LuminanceModulation(){ Val = 65000 };
            A.LuminanceOffset luminanceOffset1 = new A.LuminanceOffset(){ Val = 35000 };
            A.Alpha alpha4 = new A.Alpha(){ Val = 40000 };

            schemeColor221.Append(luminanceModulation20);
            schemeColor221.Append(luminanceOffset1);
            schemeColor221.Append(alpha4);

            glow1.Append(schemeColor221);

            A.OuterShadow outerShadow2 = new A.OuterShadow(){ BlurRadius = 28575L, Distance = 38100L, Direction = 14040000, Alignment = A.RectangleAlignmentValues.TopLeft, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex13 = new A.RgbColorModelHex(){ Val = "000000" };
            A.Alpha alpha5 = new A.Alpha(){ Val = 25000 };

            rgbColorModelHex13.Append(alpha5);

            outerShadow2.Append(rgbColorModelHex13);

            effectList15.Append(glow1);
            effectList15.Append(outerShadow2);
            A.LatinFont latinFont34 = new A.LatinFont(){ Typeface = "+mj-lt" };
            A.EastAsianFont eastAsianFont31 = new A.EastAsianFont(){ Typeface = "+mj-ea" };
            A.ComplexScriptFont complexScriptFont31 = new A.ComplexScriptFont(){ Typeface = "Trebuchet MS" };

            defaultRunProperties106.Append(outline30);
            defaultRunProperties106.Append(effectList15);
            defaultRunProperties106.Append(latinFont34);
            defaultRunProperties106.Append(eastAsianFont31);
            defaultRunProperties106.Append(complexScriptFont31);

            level1ParagraphProperties20.Append(spaceBefore11);
            level1ParagraphProperties20.Append(noBullet52);
            level1ParagraphProperties20.Append(defaultRunProperties106);

            A.Level2ParagraphProperties level2ParagraphProperties12 = new A.Level2ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties107 = new A.DefaultRunProperties();

            A.SolidFill solidFill107 = new A.SolidFill();
            A.SchemeColor schemeColor222 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill107.Append(schemeColor222);

            defaultRunProperties107.Append(solidFill107);

            level2ParagraphProperties12.Append(defaultRunProperties107);

            A.Level3ParagraphProperties level3ParagraphProperties12 = new A.Level3ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties108 = new A.DefaultRunProperties();

            A.SolidFill solidFill108 = new A.SolidFill();
            A.SchemeColor schemeColor223 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill108.Append(schemeColor223);

            defaultRunProperties108.Append(solidFill108);

            level3ParagraphProperties12.Append(defaultRunProperties108);

            A.Level4ParagraphProperties level4ParagraphProperties12 = new A.Level4ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties109 = new A.DefaultRunProperties();

            A.SolidFill solidFill109 = new A.SolidFill();
            A.SchemeColor schemeColor224 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill109.Append(schemeColor224);

            defaultRunProperties109.Append(solidFill109);

            level4ParagraphProperties12.Append(defaultRunProperties109);

            A.Level5ParagraphProperties level5ParagraphProperties12 = new A.Level5ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties110 = new A.DefaultRunProperties();

            A.SolidFill solidFill110 = new A.SolidFill();
            A.SchemeColor schemeColor225 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill110.Append(schemeColor225);

            defaultRunProperties110.Append(solidFill110);

            level5ParagraphProperties12.Append(defaultRunProperties110);

            A.Level6ParagraphProperties level6ParagraphProperties11 = new A.Level6ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties111 = new A.DefaultRunProperties();

            A.SolidFill solidFill111 = new A.SolidFill();
            A.SchemeColor schemeColor226 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill111.Append(schemeColor226);

            defaultRunProperties111.Append(solidFill111);

            level6ParagraphProperties11.Append(defaultRunProperties111);

            A.Level7ParagraphProperties level7ParagraphProperties11 = new A.Level7ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties112 = new A.DefaultRunProperties();

            A.SolidFill solidFill112 = new A.SolidFill();
            A.SchemeColor schemeColor227 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill112.Append(schemeColor227);

            defaultRunProperties112.Append(solidFill112);

            level7ParagraphProperties11.Append(defaultRunProperties112);

            A.Level8ParagraphProperties level8ParagraphProperties11 = new A.Level8ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties113 = new A.DefaultRunProperties();

            A.SolidFill solidFill113 = new A.SolidFill();
            A.SchemeColor schemeColor228 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill113.Append(schemeColor228);

            defaultRunProperties113.Append(solidFill113);

            level8ParagraphProperties11.Append(defaultRunProperties113);

            A.Level9ParagraphProperties level9ParagraphProperties11 = new A.Level9ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties114 = new A.DefaultRunProperties();

            A.SolidFill solidFill114 = new A.SolidFill();
            A.SchemeColor schemeColor229 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill114.Append(schemeColor229);

            defaultRunProperties114.Append(solidFill114);

            level9ParagraphProperties11.Append(defaultRunProperties114);

            listStyle38.Append(level1ParagraphProperties20);
            listStyle38.Append(level2ParagraphProperties12);
            listStyle38.Append(level3ParagraphProperties12);
            listStyle38.Append(level4ParagraphProperties12);
            listStyle38.Append(level5ParagraphProperties12);
            listStyle38.Append(level6ParagraphProperties11);
            listStyle38.Append(level7ParagraphProperties11);
            listStyle38.Append(level8ParagraphProperties11);
            listStyle38.Append(level9ParagraphProperties11);

            A.Paragraph paragraph46 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties16 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run26 = new A.Run();

            A.RunProperties runProperties40 = new A.RunProperties(){ Language = "en-US", FontSize = 8000, Dirty = false };
            runProperties40.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));

            A.SolidFill solidFill115 = new A.SolidFill();
            A.SchemeColor schemeColor230 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill115.Append(schemeColor230);
            A.EffectList effectList16 = new A.EffectList();

            runProperties40.Append(solidFill115);
            runProperties40.Append(effectList16);
            A.Text text40 = new A.Text();
            text40.Text = "“";

            run26.Append(runProperties40);
            run26.Append(text40);

            A.EndParagraphRunProperties endParagraphRunProperties33 = new A.EndParagraphRunProperties(){ Language = "en-US", FontSize = 8000, Dirty = false };

            A.SolidFill solidFill116 = new A.SolidFill();
            A.SchemeColor schemeColor231 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill116.Append(schemeColor231);
            A.EffectList effectList17 = new A.EffectList();

            endParagraphRunProperties33.Append(solidFill116);
            endParagraphRunProperties33.Append(effectList17);

            paragraph46.Append(paragraphProperties16);
            paragraph46.Append(run26);
            paragraph46.Append(endParagraphRunProperties33);

            textBody38.Append(bodyProperties38);
            textBody38.Append(listStyle38);
            textBody38.Append(paragraph46);

            shape38.Append(nonVisualShapeProperties38);
            shape38.Append(shapeProperties63);
            shape38.Append(textBody38);

            Shape shape39 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties39 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties72 = new NonVisualDrawingProperties(){ Id = (UInt32Value)15U, Name = "TextBox 14" };
            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties39 = new NonVisualShapeDrawingProperties(){ TextBox = true };
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties72 = new ApplicationNonVisualDrawingProperties();

            nonVisualShapeProperties39.Append(nonVisualDrawingProperties72);
            nonVisualShapeProperties39.Append(nonVisualShapeDrawingProperties39);
            nonVisualShapeProperties39.Append(applicationNonVisualDrawingProperties72);

            ShapeProperties shapeProperties64 = new ShapeProperties();

            A.Transform2D transform2D44 = new A.Transform2D();
            A.Offset offset52 = new A.Offset(){ X = 10288091L, Y = 2768601L };
            A.Extents extents52 = new A.Extents(){ Cx = 609759L, Cy = 584776L };

            transform2D44.Append(offset52);
            transform2D44.Append(extents52);

            A.PresetGeometry presetGeometry32 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList32 = new A.AdjustValueList();

            presetGeometry32.Append(adjustValueList32);

            shapeProperties64.Append(transform2D44);
            shapeProperties64.Append(presetGeometry32);

            TextBody textBody39 = new TextBody();

            A.BodyProperties bodyProperties39 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal, LeftInset = 91440, TopInset = 45720, RightInset = 91440, BottomInset = 45720, RightToLeftColumns = false, Anchor = A.TextAnchoringTypeValues.Center };
            A.NoAutoFit noAutoFit2 = new A.NoAutoFit();

            bodyProperties39.Append(noAutoFit2);

            A.ListStyle listStyle39 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties21 = new A.Level1ParagraphProperties();

            A.SpaceBefore spaceBefore12 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent12 = new A.SpacingPercent(){ Val = 0 };

            spaceBefore12.Append(spacingPercent12);
            A.NoBullet noBullet53 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties115 = new A.DefaultRunProperties(){ FontSize = 3200, Bold = false, Capital = A.TextCapsValues.All };

            A.Outline outline31 = new A.Outline(){ Width = 3175, CompoundLineType = A.CompoundLineValues.Single };
            A.NoFill noFill3 = new A.NoFill();

            outline31.Append(noFill3);

            A.EffectList effectList18 = new A.EffectList();

            A.Glow glow2 = new A.Glow(){ Radius = 38100L };

            A.SchemeColor schemeColor232 = new A.SchemeColor(){ Val = A.SchemeColorValues.Background1 };
            A.LuminanceModulation luminanceModulation21 = new A.LuminanceModulation(){ Val = 65000 };
            A.LuminanceOffset luminanceOffset2 = new A.LuminanceOffset(){ Val = 35000 };
            A.Alpha alpha6 = new A.Alpha(){ Val = 40000 };

            schemeColor232.Append(luminanceModulation21);
            schemeColor232.Append(luminanceOffset2);
            schemeColor232.Append(alpha6);

            glow2.Append(schemeColor232);

            A.OuterShadow outerShadow3 = new A.OuterShadow(){ BlurRadius = 28575L, Distance = 38100L, Direction = 14040000, Alignment = A.RectangleAlignmentValues.TopLeft, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex14 = new A.RgbColorModelHex(){ Val = "000000" };
            A.Alpha alpha7 = new A.Alpha(){ Val = 25000 };

            rgbColorModelHex14.Append(alpha7);

            outerShadow3.Append(rgbColorModelHex14);

            effectList18.Append(glow2);
            effectList18.Append(outerShadow3);
            A.LatinFont latinFont35 = new A.LatinFont(){ Typeface = "+mj-lt" };
            A.EastAsianFont eastAsianFont32 = new A.EastAsianFont(){ Typeface = "+mj-ea" };
            A.ComplexScriptFont complexScriptFont32 = new A.ComplexScriptFont(){ Typeface = "Trebuchet MS" };

            defaultRunProperties115.Append(outline31);
            defaultRunProperties115.Append(effectList18);
            defaultRunProperties115.Append(latinFont35);
            defaultRunProperties115.Append(eastAsianFont32);
            defaultRunProperties115.Append(complexScriptFont32);

            level1ParagraphProperties21.Append(spaceBefore12);
            level1ParagraphProperties21.Append(noBullet53);
            level1ParagraphProperties21.Append(defaultRunProperties115);

            A.Level2ParagraphProperties level2ParagraphProperties13 = new A.Level2ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties116 = new A.DefaultRunProperties();

            A.SolidFill solidFill117 = new A.SolidFill();
            A.SchemeColor schemeColor233 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill117.Append(schemeColor233);

            defaultRunProperties116.Append(solidFill117);

            level2ParagraphProperties13.Append(defaultRunProperties116);

            A.Level3ParagraphProperties level3ParagraphProperties13 = new A.Level3ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties117 = new A.DefaultRunProperties();

            A.SolidFill solidFill118 = new A.SolidFill();
            A.SchemeColor schemeColor234 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill118.Append(schemeColor234);

            defaultRunProperties117.Append(solidFill118);

            level3ParagraphProperties13.Append(defaultRunProperties117);

            A.Level4ParagraphProperties level4ParagraphProperties13 = new A.Level4ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties118 = new A.DefaultRunProperties();

            A.SolidFill solidFill119 = new A.SolidFill();
            A.SchemeColor schemeColor235 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill119.Append(schemeColor235);

            defaultRunProperties118.Append(solidFill119);

            level4ParagraphProperties13.Append(defaultRunProperties118);

            A.Level5ParagraphProperties level5ParagraphProperties13 = new A.Level5ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties119 = new A.DefaultRunProperties();

            A.SolidFill solidFill120 = new A.SolidFill();
            A.SchemeColor schemeColor236 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill120.Append(schemeColor236);

            defaultRunProperties119.Append(solidFill120);

            level5ParagraphProperties13.Append(defaultRunProperties119);

            A.Level6ParagraphProperties level6ParagraphProperties12 = new A.Level6ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties120 = new A.DefaultRunProperties();

            A.SolidFill solidFill121 = new A.SolidFill();
            A.SchemeColor schemeColor237 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill121.Append(schemeColor237);

            defaultRunProperties120.Append(solidFill121);

            level6ParagraphProperties12.Append(defaultRunProperties120);

            A.Level7ParagraphProperties level7ParagraphProperties12 = new A.Level7ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties121 = new A.DefaultRunProperties();

            A.SolidFill solidFill122 = new A.SolidFill();
            A.SchemeColor schemeColor238 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill122.Append(schemeColor238);

            defaultRunProperties121.Append(solidFill122);

            level7ParagraphProperties12.Append(defaultRunProperties121);

            A.Level8ParagraphProperties level8ParagraphProperties12 = new A.Level8ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties122 = new A.DefaultRunProperties();

            A.SolidFill solidFill123 = new A.SolidFill();
            A.SchemeColor schemeColor239 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill123.Append(schemeColor239);

            defaultRunProperties122.Append(solidFill123);

            level8ParagraphProperties12.Append(defaultRunProperties122);

            A.Level9ParagraphProperties level9ParagraphProperties12 = new A.Level9ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties123 = new A.DefaultRunProperties();

            A.SolidFill solidFill124 = new A.SolidFill();
            A.SchemeColor schemeColor240 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill124.Append(schemeColor240);

            defaultRunProperties123.Append(solidFill124);

            level9ParagraphProperties12.Append(defaultRunProperties123);

            listStyle39.Append(level1ParagraphProperties21);
            listStyle39.Append(level2ParagraphProperties13);
            listStyle39.Append(level3ParagraphProperties13);
            listStyle39.Append(level4ParagraphProperties13);
            listStyle39.Append(level5ParagraphProperties13);
            listStyle39.Append(level6ParagraphProperties12);
            listStyle39.Append(level7ParagraphProperties12);
            listStyle39.Append(level8ParagraphProperties12);
            listStyle39.Append(level9ParagraphProperties12);

            A.Paragraph paragraph47 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties17 = new A.ParagraphProperties(){ Level = 0, Alignment = A.TextAlignmentTypeValues.Right };

            A.Run run27 = new A.Run();

            A.RunProperties runProperties41 = new A.RunProperties(){ Language = "en-US", FontSize = 8000, Dirty = false };
            runProperties41.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));

            A.SolidFill solidFill125 = new A.SolidFill();
            A.SchemeColor schemeColor241 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill125.Append(schemeColor241);
            A.EffectList effectList19 = new A.EffectList();

            runProperties41.Append(solidFill125);
            runProperties41.Append(effectList19);
            A.Text text41 = new A.Text();
            text41.Text = "”";

            run27.Append(runProperties41);
            run27.Append(text41);

            A.EndParagraphRunProperties endParagraphRunProperties34 = new A.EndParagraphRunProperties(){ Language = "en-US", FontSize = 8000, Dirty = false };

            A.SolidFill solidFill126 = new A.SolidFill();
            A.SchemeColor schemeColor242 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill126.Append(schemeColor242);
            A.EffectList effectList20 = new A.EffectList();

            endParagraphRunProperties34.Append(solidFill126);
            endParagraphRunProperties34.Append(effectList20);

            paragraph47.Append(paragraphProperties17);
            paragraph47.Append(run27);
            paragraph47.Append(endParagraphRunProperties34);

            textBody39.Append(bodyProperties39);
            textBody39.Append(listStyle39);
            textBody39.Append(paragraph47);

            shape39.Append(nonVisualShapeProperties39);
            shape39.Append(shapeProperties64);
            shape39.Append(textBody39);

            ConnectionShape connectionShape26 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties26 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties73 = new NonVisualDrawingProperties(){ Id = (UInt32Value)23U, Name = "Straight Connector 22" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties26 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties73 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties26.Append(nonVisualDrawingProperties73);
            nonVisualConnectionShapeProperties26.Append(nonVisualConnectorShapeDrawingProperties26);
            nonVisualConnectionShapeProperties26.Append(applicationNonVisualDrawingProperties73);

            ShapeProperties shapeProperties65 = new ShapeProperties();

            A.Transform2D transform2D45 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset53 = new A.Offset(){ X = 11278949L, Y = 2963333L };
            A.Extents extents53 = new A.Extents(){ Cx = 913052L, Cy = 912812L };

            transform2D45.Append(offset53);
            transform2D45.Append(extents53);

            A.PresetGeometry presetGeometry33 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList33 = new A.AdjustValueList();

            presetGeometry33.Append(adjustValueList33);

            A.Outline outline32 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill127 = new A.SolidFill();
            A.SchemeColor schemeColor243 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill127.Append(schemeColor243);

            outline32.Append(solidFill127);

            shapeProperties65.Append(transform2D45);
            shapeProperties65.Append(presetGeometry33);
            shapeProperties65.Append(outline32);

            ShapeStyle shapeStyle26 = new ShapeStyle();

            A.LineReference lineReference26 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor244 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference26.Append(schemeColor244);

            A.FillReference fillReference26 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor245 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference26.Append(schemeColor245);

            A.EffectReference effectReference26 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor246 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference26.Append(schemeColor246);

            A.FontReference fontReference26 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor247 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference26.Append(schemeColor247);

            shapeStyle26.Append(lineReference26);
            shapeStyle26.Append(fillReference26);
            shapeStyle26.Append(effectReference26);
            shapeStyle26.Append(fontReference26);

            connectionShape26.Append(nonVisualConnectionShapeProperties26);
            connectionShape26.Append(shapeProperties65);
            connectionShape26.Append(shapeStyle26);

            ConnectionShape connectionShape27 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties27 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties74 = new NonVisualDrawingProperties(){ Id = (UInt32Value)24U, Name = "Straight Connector 23" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties27 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties74 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties27.Append(nonVisualDrawingProperties74);
            nonVisualConnectionShapeProperties27.Append(nonVisualConnectorShapeDrawingProperties27);
            nonVisualConnectionShapeProperties27.Append(applicationNonVisualDrawingProperties74);

            ShapeProperties shapeProperties66 = new ShapeProperties();

            A.Transform2D transform2D46 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset54 = new A.Offset(){ X = 9209368L, Y = 3190344L };
            A.Extents extents54 = new A.Extents(){ Cx = 2982634L, Cy = 2981856L };

            transform2D46.Append(offset54);
            transform2D46.Append(extents54);

            A.PresetGeometry presetGeometry34 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList34 = new A.AdjustValueList();

            presetGeometry34.Append(adjustValueList34);

            A.Outline outline33 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill128 = new A.SolidFill();
            A.SchemeColor schemeColor248 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill128.Append(schemeColor248);

            outline33.Append(solidFill128);

            shapeProperties66.Append(transform2D46);
            shapeProperties66.Append(presetGeometry34);
            shapeProperties66.Append(outline33);

            ShapeStyle shapeStyle27 = new ShapeStyle();

            A.LineReference lineReference27 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor249 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference27.Append(schemeColor249);

            A.FillReference fillReference27 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor250 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference27.Append(schemeColor250);

            A.EffectReference effectReference27 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor251 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference27.Append(schemeColor251);

            A.FontReference fontReference27 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor252 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference27.Append(schemeColor252);

            shapeStyle27.Append(lineReference27);
            shapeStyle27.Append(fillReference27);
            shapeStyle27.Append(effectReference27);
            shapeStyle27.Append(fontReference27);

            connectionShape27.Append(nonVisualConnectionShapeProperties27);
            connectionShape27.Append(shapeProperties66);
            connectionShape27.Append(shapeStyle27);

            ConnectionShape connectionShape28 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties28 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties75 = new NonVisualDrawingProperties(){ Id = (UInt32Value)25U, Name = "Straight Connector 24" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties28 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties75 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties28.Append(nonVisualDrawingProperties75);
            nonVisualConnectionShapeProperties28.Append(nonVisualConnectorShapeDrawingProperties28);
            nonVisualConnectionShapeProperties28.Append(applicationNonVisualDrawingProperties75);

            ShapeProperties shapeProperties67 = new ShapeProperties();

            A.Transform2D transform2D47 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset55 = new A.Offset(){ X = 10294973L, Y = 3285068L };
            A.Extents extents55 = new A.Extents(){ Cx = 1897028L, Cy = 1896533L };

            transform2D47.Append(offset55);
            transform2D47.Append(extents55);

            A.PresetGeometry presetGeometry35 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList35 = new A.AdjustValueList();

            presetGeometry35.Append(adjustValueList35);

            A.Outline outline34 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill129 = new A.SolidFill();
            A.SchemeColor schemeColor253 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill129.Append(schemeColor253);

            outline34.Append(solidFill129);

            shapeProperties67.Append(transform2D47);
            shapeProperties67.Append(presetGeometry35);
            shapeProperties67.Append(outline34);

            ShapeStyle shapeStyle28 = new ShapeStyle();

            A.LineReference lineReference28 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor254 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference28.Append(schemeColor254);

            A.FillReference fillReference28 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor255 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference28.Append(schemeColor255);

            A.EffectReference effectReference28 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor256 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference28.Append(schemeColor256);

            A.FontReference fontReference28 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor257 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference28.Append(schemeColor257);

            shapeStyle28.Append(lineReference28);
            shapeStyle28.Append(fillReference28);
            shapeStyle28.Append(effectReference28);
            shapeStyle28.Append(fontReference28);

            connectionShape28.Append(nonVisualConnectionShapeProperties28);
            connectionShape28.Append(shapeProperties67);
            connectionShape28.Append(shapeStyle28);

            ConnectionShape connectionShape29 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties29 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties76 = new NonVisualDrawingProperties(){ Id = (UInt32Value)26U, Name = "Straight Connector 25" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties29 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties76 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties29.Append(nonVisualDrawingProperties76);
            nonVisualConnectionShapeProperties29.Append(nonVisualConnectorShapeDrawingProperties29);
            nonVisualConnectionShapeProperties29.Append(applicationNonVisualDrawingProperties76);

            ShapeProperties shapeProperties68 = new ShapeProperties();

            A.Transform2D transform2D48 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset56 = new A.Offset(){ X = 10445823L, Y = 3131080L };
            A.Extents extents56 = new A.Extents(){ Cx = 1746177L, Cy = 1745720L };

            transform2D48.Append(offset56);
            transform2D48.Append(extents56);

            A.PresetGeometry presetGeometry36 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList36 = new A.AdjustValueList();

            presetGeometry36.Append(adjustValueList36);

            A.Outline outline35 = new A.Outline(){ Width = 28575 };

            A.SolidFill solidFill130 = new A.SolidFill();
            A.SchemeColor schemeColor258 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill130.Append(schemeColor258);

            outline35.Append(solidFill130);

            shapeProperties68.Append(transform2D48);
            shapeProperties68.Append(presetGeometry36);
            shapeProperties68.Append(outline35);

            ShapeStyle shapeStyle29 = new ShapeStyle();

            A.LineReference lineReference29 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor259 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference29.Append(schemeColor259);

            A.FillReference fillReference29 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor260 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference29.Append(schemeColor260);

            A.EffectReference effectReference29 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor261 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference29.Append(schemeColor261);

            A.FontReference fontReference29 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor262 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference29.Append(schemeColor262);

            shapeStyle29.Append(lineReference29);
            shapeStyle29.Append(fillReference29);
            shapeStyle29.Append(effectReference29);
            shapeStyle29.Append(fontReference29);

            connectionShape29.Append(nonVisualConnectionShapeProperties29);
            connectionShape29.Append(shapeProperties68);
            connectionShape29.Append(shapeStyle29);

            ConnectionShape connectionShape30 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties30 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties77 = new NonVisualDrawingProperties(){ Id = (UInt32Value)27U, Name = "Straight Connector 26" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties30 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties77 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties30.Append(nonVisualDrawingProperties77);
            nonVisualConnectionShapeProperties30.Append(nonVisualConnectorShapeDrawingProperties30);
            nonVisualConnectionShapeProperties30.Append(applicationNonVisualDrawingProperties77);

            ShapeProperties shapeProperties69 = new ShapeProperties();

            A.Transform2D transform2D49 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset57 = new A.Offset(){ X = 10921671L, Y = 3683002L };
            A.Extents extents57 = new A.Extents(){ Cx = 1270332L, Cy = 1269999L };

            transform2D49.Append(offset57);
            transform2D49.Append(extents57);

            A.PresetGeometry presetGeometry37 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList37 = new A.AdjustValueList();

            presetGeometry37.Append(adjustValueList37);

            A.Outline outline36 = new A.Outline(){ Width = 28575 };

            A.SolidFill solidFill131 = new A.SolidFill();
            A.SchemeColor schemeColor263 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill131.Append(schemeColor263);

            outline36.Append(solidFill131);

            shapeProperties69.Append(transform2D49);
            shapeProperties69.Append(presetGeometry37);
            shapeProperties69.Append(outline36);

            ShapeStyle shapeStyle30 = new ShapeStyle();

            A.LineReference lineReference30 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor264 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference30.Append(schemeColor264);

            A.FillReference fillReference30 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor265 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference30.Append(schemeColor265);

            A.EffectReference effectReference30 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor266 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference30.Append(schemeColor266);

            A.FontReference fontReference30 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor267 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference30.Append(schemeColor267);

            shapeStyle30.Append(lineReference30);
            shapeStyle30.Append(fillReference30);
            shapeStyle30.Append(effectReference30);
            shapeStyle30.Append(fontReference30);

            connectionShape30.Append(nonVisualConnectionShapeProperties30);
            connectionShape30.Append(shapeProperties69);
            connectionShape30.Append(shapeStyle30);

            shapeTree8.Append(nonVisualGroupShapeProperties8);
            shapeTree8.Append(groupShapeProperties8);
            shapeTree8.Append(shape32);
            shapeTree8.Append(shape33);
            shapeTree8.Append(shape34);
            shapeTree8.Append(shape35);
            shapeTree8.Append(shape36);
            shapeTree8.Append(shape37);
            shapeTree8.Append(shape38);
            shapeTree8.Append(shape39);
            shapeTree8.Append(connectionShape26);
            shapeTree8.Append(connectionShape27);
            shapeTree8.Append(connectionShape28);
            shapeTree8.Append(connectionShape29);
            shapeTree8.Append(connectionShape30);

            CommonSlideDataExtensionList commonSlideDataExtensionList8 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension8 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId8 = new P14.CreationId(){ Val = (UInt32Value)629197057U };
            creationId8.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension8.Append(creationId8);

            commonSlideDataExtensionList8.Append(commonSlideDataExtension8);

            commonSlideData8.Append(shapeTree8);
            commonSlideData8.Append(commonSlideDataExtensionList8);

            ColorMapOverride colorMapOverride7 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping7 = new A.MasterColorMapping();

            colorMapOverride7.Append(masterColorMapping7);

            Timing timing8 = new Timing();

            TimeNodeList timeNodeList8 = new TimeNodeList();

            ParallelTimeNode parallelTimeNode8 = new ParallelTimeNode();
            CommonTimeNode commonTimeNode8 = new CommonTimeNode(){ Id = (UInt32Value)1U, Duration = "indefinite", Restart = TimeNodeRestartValues.Never, NodeType = TimeNodeValues.TmingRoot };

            parallelTimeNode8.Append(commonTimeNode8);

            timeNodeList8.Append(parallelTimeNode8);

            timing8.Append(timeNodeList8);

            slideLayout6.Append(commonSlideData8);
            slideLayout6.Append(colorMapOverride7);
            slideLayout6.Append(timing8);

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
            NonVisualDrawingProperties nonVisualDrawingProperties78 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties9 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties78 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties9.Append(nonVisualDrawingProperties78);
            nonVisualGroupShapeProperties9.Append(nonVisualGroupShapeDrawingProperties9);
            nonVisualGroupShapeProperties9.Append(applicationNonVisualDrawingProperties78);

            GroupShapeProperties groupShapeProperties9 = new GroupShapeProperties();

            A.TransformGroup transformGroup9 = new A.TransformGroup();
            A.Offset offset58 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents58 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset9 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents9 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup9.Append(offset58);
            transformGroup9.Append(extents58);
            transformGroup9.Append(childOffset9);
            transformGroup9.Append(childExtents9);

            groupShapeProperties9.Append(transformGroup9);

            Shape shape40 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties40 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties79 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Vertical Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties40 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks38 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties40.Append(shapeLocks38);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties79 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape38 = new PlaceholderShape(){ Type = PlaceholderValues.Title, Orientation = DirectionValues.Vertical };

            applicationNonVisualDrawingProperties79.Append(placeholderShape38);

            nonVisualShapeProperties40.Append(nonVisualDrawingProperties79);
            nonVisualShapeProperties40.Append(nonVisualShapeDrawingProperties40);
            nonVisualShapeProperties40.Append(applicationNonVisualDrawingProperties79);

            ShapeProperties shapeProperties70 = new ShapeProperties();

            A.Transform2D transform2D50 = new A.Transform2D();
            A.Offset offset59 = new A.Offset(){ X = 8687474L, Y = 685800L };
            A.Extents extents59 = new A.Extents(){ Cx = 2057936L, Cy = 4572000L };

            transform2D50.Append(offset59);
            transform2D50.Append(extents59);

            shapeProperties70.Append(transform2D50);

            TextBody textBody40 = new TextBody();
            A.BodyProperties bodyProperties40 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.EastAsianVetical };
            A.ListStyle listStyle40 = new A.ListStyle();

            A.Paragraph paragraph48 = new A.Paragraph();

            A.Run run28 = new A.Run();

            A.RunProperties runProperties42 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties42.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text42 = new A.Text();
            text42.Text = "Click to edit Master title style";

            run28.Append(runProperties42);
            run28.Append(text42);
            A.EndParagraphRunProperties endParagraphRunProperties35 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph48.Append(run28);
            paragraph48.Append(endParagraphRunProperties35);

            textBody40.Append(bodyProperties40);
            textBody40.Append(listStyle40);
            textBody40.Append(paragraph48);

            shape40.Append(nonVisualShapeProperties40);
            shape40.Append(shapeProperties70);
            shape40.Append(textBody40);

            Shape shape41 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties41 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties80 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Vertical Text Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties41 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks39 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties41.Append(shapeLocks39);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties80 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape39 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Orientation = DirectionValues.Vertical, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties80.Append(placeholderShape39);

            nonVisualShapeProperties41.Append(nonVisualDrawingProperties80);
            nonVisualShapeProperties41.Append(nonVisualShapeDrawingProperties41);
            nonVisualShapeProperties41.Append(applicationNonVisualDrawingProperties80);

            ShapeProperties shapeProperties71 = new ShapeProperties();

            A.Transform2D transform2D51 = new A.Transform2D();
            A.Offset offset60 = new A.Offset(){ X = 685979L, Y = 685800L };
            A.Extents extents60 = new A.Extents(){ Cx = 7825238L, Cy = 5308600L };

            transform2D51.Append(offset60);
            transform2D51.Append(extents60);

            shapeProperties71.Append(transform2D51);

            TextBody textBody41 = new TextBody();
            A.BodyProperties bodyProperties41 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.EastAsianVetical, Anchor = A.TextAnchoringTypeValues.Top };
            A.ListStyle listStyle41 = new A.ListStyle();

            A.Paragraph paragraph49 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties18 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run29 = new A.Run();

            A.RunProperties runProperties43 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties43.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text43 = new A.Text();
            text43.Text = "Click to edit Master text styles";

            run29.Append(runProperties43);
            run29.Append(text43);

            paragraph49.Append(paragraphProperties18);
            paragraph49.Append(run29);

            A.Paragraph paragraph50 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties19 = new A.ParagraphProperties(){ Level = 1 };

            A.Run run30 = new A.Run();

            A.RunProperties runProperties44 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties44.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text44 = new A.Text();
            text44.Text = "Second level";

            run30.Append(runProperties44);
            run30.Append(text44);

            paragraph50.Append(paragraphProperties19);
            paragraph50.Append(run30);

            A.Paragraph paragraph51 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties20 = new A.ParagraphProperties(){ Level = 2 };

            A.Run run31 = new A.Run();

            A.RunProperties runProperties45 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties45.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text45 = new A.Text();
            text45.Text = "Third level";

            run31.Append(runProperties45);
            run31.Append(text45);

            paragraph51.Append(paragraphProperties20);
            paragraph51.Append(run31);

            A.Paragraph paragraph52 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties21 = new A.ParagraphProperties(){ Level = 3 };

            A.Run run32 = new A.Run();

            A.RunProperties runProperties46 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties46.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text46 = new A.Text();
            text46.Text = "Fourth level";

            run32.Append(runProperties46);
            run32.Append(text46);

            paragraph52.Append(paragraphProperties21);
            paragraph52.Append(run32);

            A.Paragraph paragraph53 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties22 = new A.ParagraphProperties(){ Level = 4 };

            A.Run run33 = new A.Run();

            A.RunProperties runProperties47 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties47.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text47 = new A.Text();
            text47.Text = "Fifth level";

            run33.Append(runProperties47);
            run33.Append(text47);
            A.EndParagraphRunProperties endParagraphRunProperties36 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph53.Append(paragraphProperties22);
            paragraph53.Append(run33);
            paragraph53.Append(endParagraphRunProperties36);

            textBody41.Append(bodyProperties41);
            textBody41.Append(listStyle41);
            textBody41.Append(paragraph49);
            textBody41.Append(paragraph50);
            textBody41.Append(paragraph51);
            textBody41.Append(paragraph52);
            textBody41.Append(paragraph53);

            shape41.Append(nonVisualShapeProperties41);
            shape41.Append(shapeProperties71);
            shape41.Append(textBody41);

            Shape shape42 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties42 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties81 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Date Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties42 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks40 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties42.Append(shapeLocks40);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties81 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape40 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties81.Append(placeholderShape40);

            nonVisualShapeProperties42.Append(nonVisualDrawingProperties81);
            nonVisualShapeProperties42.Append(nonVisualShapeDrawingProperties42);
            nonVisualShapeProperties42.Append(applicationNonVisualDrawingProperties81);
            ShapeProperties shapeProperties72 = new ShapeProperties();

            TextBody textBody42 = new TextBody();
            A.BodyProperties bodyProperties42 = new A.BodyProperties();
            A.ListStyle listStyle42 = new A.ListStyle();

            A.Paragraph paragraph54 = new A.Paragraph();

            A.Field field15 = new A.Field(){ Id = "{CE1A2D98-1BBD-4706-A118-AAC2A16BEAD3}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties48 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties48.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text48 = new A.Text();
            text48.Text = "2012/10/3";

            field15.Append(runProperties48);
            field15.Append(text48);
            A.EndParagraphRunProperties endParagraphRunProperties37 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph54.Append(field15);
            paragraph54.Append(endParagraphRunProperties37);

            textBody42.Append(bodyProperties42);
            textBody42.Append(listStyle42);
            textBody42.Append(paragraph54);

            shape42.Append(nonVisualShapeProperties42);
            shape42.Append(shapeProperties72);
            shape42.Append(textBody42);

            Shape shape43 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties43 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties82 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Footer Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties43 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks41 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties43.Append(shapeLocks41);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties82 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape41 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties82.Append(placeholderShape41);

            nonVisualShapeProperties43.Append(nonVisualDrawingProperties82);
            nonVisualShapeProperties43.Append(nonVisualShapeDrawingProperties43);
            nonVisualShapeProperties43.Append(applicationNonVisualDrawingProperties82);
            ShapeProperties shapeProperties73 = new ShapeProperties();

            TextBody textBody43 = new TextBody();
            A.BodyProperties bodyProperties43 = new A.BodyProperties();
            A.ListStyle listStyle43 = new A.ListStyle();

            A.Paragraph paragraph55 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties38 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph55.Append(endParagraphRunProperties38);

            textBody43.Append(bodyProperties43);
            textBody43.Append(listStyle43);
            textBody43.Append(paragraph55);

            shape43.Append(nonVisualShapeProperties43);
            shape43.Append(shapeProperties73);
            shape43.Append(textBody43);

            Shape shape44 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties44 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties83 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Slide Number Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties44 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks42 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties44.Append(shapeLocks42);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties83 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape42 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties83.Append(placeholderShape42);

            nonVisualShapeProperties44.Append(nonVisualDrawingProperties83);
            nonVisualShapeProperties44.Append(nonVisualShapeDrawingProperties44);
            nonVisualShapeProperties44.Append(applicationNonVisualDrawingProperties83);
            ShapeProperties shapeProperties74 = new ShapeProperties();

            TextBody textBody44 = new TextBody();
            A.BodyProperties bodyProperties44 = new A.BodyProperties();
            A.ListStyle listStyle44 = new A.ListStyle();

            A.Paragraph paragraph56 = new A.Paragraph();

            A.Field field16 = new A.Field(){ Id = "{D107CD50-7081-433F-A1F2-156B4E14F4F4}", Type = "slidenum" };

            A.RunProperties runProperties49 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties49.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text49 = new A.Text();
            text49.Text = "‹#›";

            field16.Append(runProperties49);
            field16.Append(text49);
            A.EndParagraphRunProperties endParagraphRunProperties39 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph56.Append(field16);
            paragraph56.Append(endParagraphRunProperties39);

            textBody44.Append(bodyProperties44);
            textBody44.Append(listStyle44);
            textBody44.Append(paragraph56);

            shape44.Append(nonVisualShapeProperties44);
            shape44.Append(shapeProperties74);
            shape44.Append(textBody44);

            ConnectionShape connectionShape31 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties31 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties84 = new NonVisualDrawingProperties(){ Id = (UInt32Value)7U, Name = "Straight Connector 6" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties31 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties84 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties31.Append(nonVisualDrawingProperties84);
            nonVisualConnectionShapeProperties31.Append(nonVisualConnectorShapeDrawingProperties31);
            nonVisualConnectionShapeProperties31.Append(applicationNonVisualDrawingProperties84);

            ShapeProperties shapeProperties75 = new ShapeProperties();

            A.Transform2D transform2D52 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset61 = new A.Offset(){ X = 11278949L, Y = 2963333L };
            A.Extents extents61 = new A.Extents(){ Cx = 913052L, Cy = 912812L };

            transform2D52.Append(offset61);
            transform2D52.Append(extents61);

            A.PresetGeometry presetGeometry38 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList38 = new A.AdjustValueList();

            presetGeometry38.Append(adjustValueList38);

            A.Outline outline37 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill132 = new A.SolidFill();
            A.SchemeColor schemeColor268 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill132.Append(schemeColor268);

            outline37.Append(solidFill132);

            shapeProperties75.Append(transform2D52);
            shapeProperties75.Append(presetGeometry38);
            shapeProperties75.Append(outline37);

            ShapeStyle shapeStyle31 = new ShapeStyle();

            A.LineReference lineReference31 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor269 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference31.Append(schemeColor269);

            A.FillReference fillReference31 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor270 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference31.Append(schemeColor270);

            A.EffectReference effectReference31 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor271 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference31.Append(schemeColor271);

            A.FontReference fontReference31 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor272 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference31.Append(schemeColor272);

            shapeStyle31.Append(lineReference31);
            shapeStyle31.Append(fillReference31);
            shapeStyle31.Append(effectReference31);
            shapeStyle31.Append(fontReference31);

            connectionShape31.Append(nonVisualConnectionShapeProperties31);
            connectionShape31.Append(shapeProperties75);
            connectionShape31.Append(shapeStyle31);

            ConnectionShape connectionShape32 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties32 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties85 = new NonVisualDrawingProperties(){ Id = (UInt32Value)8U, Name = "Straight Connector 7" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties32 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties85 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties32.Append(nonVisualDrawingProperties85);
            nonVisualConnectionShapeProperties32.Append(nonVisualConnectorShapeDrawingProperties32);
            nonVisualConnectionShapeProperties32.Append(applicationNonVisualDrawingProperties85);

            ShapeProperties shapeProperties76 = new ShapeProperties();

            A.Transform2D transform2D53 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset62 = new A.Offset(){ X = 9209368L, Y = 3190344L };
            A.Extents extents62 = new A.Extents(){ Cx = 2982634L, Cy = 2981856L };

            transform2D53.Append(offset62);
            transform2D53.Append(extents62);

            A.PresetGeometry presetGeometry39 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList39 = new A.AdjustValueList();

            presetGeometry39.Append(adjustValueList39);

            A.Outline outline38 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill133 = new A.SolidFill();
            A.SchemeColor schemeColor273 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill133.Append(schemeColor273);

            outline38.Append(solidFill133);

            shapeProperties76.Append(transform2D53);
            shapeProperties76.Append(presetGeometry39);
            shapeProperties76.Append(outline38);

            ShapeStyle shapeStyle32 = new ShapeStyle();

            A.LineReference lineReference32 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor274 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference32.Append(schemeColor274);

            A.FillReference fillReference32 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor275 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference32.Append(schemeColor275);

            A.EffectReference effectReference32 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor276 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference32.Append(schemeColor276);

            A.FontReference fontReference32 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor277 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference32.Append(schemeColor277);

            shapeStyle32.Append(lineReference32);
            shapeStyle32.Append(fillReference32);
            shapeStyle32.Append(effectReference32);
            shapeStyle32.Append(fontReference32);

            connectionShape32.Append(nonVisualConnectionShapeProperties32);
            connectionShape32.Append(shapeProperties76);
            connectionShape32.Append(shapeStyle32);

            ConnectionShape connectionShape33 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties33 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties86 = new NonVisualDrawingProperties(){ Id = (UInt32Value)9U, Name = "Straight Connector 8" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties33 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties86 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties33.Append(nonVisualDrawingProperties86);
            nonVisualConnectionShapeProperties33.Append(nonVisualConnectorShapeDrawingProperties33);
            nonVisualConnectionShapeProperties33.Append(applicationNonVisualDrawingProperties86);

            ShapeProperties shapeProperties77 = new ShapeProperties();

            A.Transform2D transform2D54 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset63 = new A.Offset(){ X = 10294973L, Y = 3285068L };
            A.Extents extents63 = new A.Extents(){ Cx = 1897028L, Cy = 1896533L };

            transform2D54.Append(offset63);
            transform2D54.Append(extents63);

            A.PresetGeometry presetGeometry40 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList40 = new A.AdjustValueList();

            presetGeometry40.Append(adjustValueList40);

            A.Outline outline39 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill134 = new A.SolidFill();
            A.SchemeColor schemeColor278 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill134.Append(schemeColor278);

            outline39.Append(solidFill134);

            shapeProperties77.Append(transform2D54);
            shapeProperties77.Append(presetGeometry40);
            shapeProperties77.Append(outline39);

            ShapeStyle shapeStyle33 = new ShapeStyle();

            A.LineReference lineReference33 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor279 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference33.Append(schemeColor279);

            A.FillReference fillReference33 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor280 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference33.Append(schemeColor280);

            A.EffectReference effectReference33 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor281 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference33.Append(schemeColor281);

            A.FontReference fontReference33 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor282 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference33.Append(schemeColor282);

            shapeStyle33.Append(lineReference33);
            shapeStyle33.Append(fillReference33);
            shapeStyle33.Append(effectReference33);
            shapeStyle33.Append(fontReference33);

            connectionShape33.Append(nonVisualConnectionShapeProperties33);
            connectionShape33.Append(shapeProperties77);
            connectionShape33.Append(shapeStyle33);

            ConnectionShape connectionShape34 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties34 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties87 = new NonVisualDrawingProperties(){ Id = (UInt32Value)10U, Name = "Straight Connector 9" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties34 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties87 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties34.Append(nonVisualDrawingProperties87);
            nonVisualConnectionShapeProperties34.Append(nonVisualConnectorShapeDrawingProperties34);
            nonVisualConnectionShapeProperties34.Append(applicationNonVisualDrawingProperties87);

            ShapeProperties shapeProperties78 = new ShapeProperties();

            A.Transform2D transform2D55 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset64 = new A.Offset(){ X = 10445823L, Y = 3131080L };
            A.Extents extents64 = new A.Extents(){ Cx = 1746177L, Cy = 1745720L };

            transform2D55.Append(offset64);
            transform2D55.Append(extents64);

            A.PresetGeometry presetGeometry41 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList41 = new A.AdjustValueList();

            presetGeometry41.Append(adjustValueList41);

            A.Outline outline40 = new A.Outline(){ Width = 28575 };

            A.SolidFill solidFill135 = new A.SolidFill();
            A.SchemeColor schemeColor283 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill135.Append(schemeColor283);

            outline40.Append(solidFill135);

            shapeProperties78.Append(transform2D55);
            shapeProperties78.Append(presetGeometry41);
            shapeProperties78.Append(outline40);

            ShapeStyle shapeStyle34 = new ShapeStyle();

            A.LineReference lineReference34 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor284 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference34.Append(schemeColor284);

            A.FillReference fillReference34 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor285 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference34.Append(schemeColor285);

            A.EffectReference effectReference34 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor286 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference34.Append(schemeColor286);

            A.FontReference fontReference34 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor287 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference34.Append(schemeColor287);

            shapeStyle34.Append(lineReference34);
            shapeStyle34.Append(fillReference34);
            shapeStyle34.Append(effectReference34);
            shapeStyle34.Append(fontReference34);

            connectionShape34.Append(nonVisualConnectionShapeProperties34);
            connectionShape34.Append(shapeProperties78);
            connectionShape34.Append(shapeStyle34);

            ConnectionShape connectionShape35 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties35 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties88 = new NonVisualDrawingProperties(){ Id = (UInt32Value)11U, Name = "Straight Connector 10" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties35 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties88 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties35.Append(nonVisualDrawingProperties88);
            nonVisualConnectionShapeProperties35.Append(nonVisualConnectorShapeDrawingProperties35);
            nonVisualConnectionShapeProperties35.Append(applicationNonVisualDrawingProperties88);

            ShapeProperties shapeProperties79 = new ShapeProperties();

            A.Transform2D transform2D56 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset65 = new A.Offset(){ X = 10921671L, Y = 3683002L };
            A.Extents extents65 = new A.Extents(){ Cx = 1270332L, Cy = 1269999L };

            transform2D56.Append(offset65);
            transform2D56.Append(extents65);

            A.PresetGeometry presetGeometry42 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList42 = new A.AdjustValueList();

            presetGeometry42.Append(adjustValueList42);

            A.Outline outline41 = new A.Outline(){ Width = 28575 };

            A.SolidFill solidFill136 = new A.SolidFill();
            A.SchemeColor schemeColor288 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill136.Append(schemeColor288);

            outline41.Append(solidFill136);

            shapeProperties79.Append(transform2D56);
            shapeProperties79.Append(presetGeometry42);
            shapeProperties79.Append(outline41);

            ShapeStyle shapeStyle35 = new ShapeStyle();

            A.LineReference lineReference35 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor289 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference35.Append(schemeColor289);

            A.FillReference fillReference35 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor290 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference35.Append(schemeColor290);

            A.EffectReference effectReference35 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor291 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference35.Append(schemeColor291);

            A.FontReference fontReference35 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor292 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference35.Append(schemeColor292);

            shapeStyle35.Append(lineReference35);
            shapeStyle35.Append(fillReference35);
            shapeStyle35.Append(effectReference35);
            shapeStyle35.Append(fontReference35);

            connectionShape35.Append(nonVisualConnectionShapeProperties35);
            connectionShape35.Append(shapeProperties79);
            connectionShape35.Append(shapeStyle35);

            shapeTree9.Append(nonVisualGroupShapeProperties9);
            shapeTree9.Append(groupShapeProperties9);
            shapeTree9.Append(shape40);
            shapeTree9.Append(shape41);
            shapeTree9.Append(shape42);
            shapeTree9.Append(shape43);
            shapeTree9.Append(shape44);
            shapeTree9.Append(connectionShape31);
            shapeTree9.Append(connectionShape32);
            shapeTree9.Append(connectionShape33);
            shapeTree9.Append(connectionShape34);
            shapeTree9.Append(connectionShape35);

            CommonSlideDataExtensionList commonSlideDataExtensionList9 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension9 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId9 = new P14.CreationId(){ Val = (UInt32Value)2545892363U };
            creationId9.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension9.Append(creationId9);

            commonSlideDataExtensionList9.Append(commonSlideDataExtension9);

            commonSlideData9.Append(shapeTree9);
            commonSlideData9.Append(commonSlideDataExtensionList9);

            ColorMapOverride colorMapOverride8 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping8 = new A.MasterColorMapping();

            colorMapOverride8.Append(masterColorMapping8);

            Timing timing9 = new Timing();

            TimeNodeList timeNodeList9 = new TimeNodeList();

            ParallelTimeNode parallelTimeNode9 = new ParallelTimeNode();
            CommonTimeNode commonTimeNode9 = new CommonTimeNode(){ Id = (UInt32Value)1U, Duration = "indefinite", Restart = TimeNodeRestartValues.Never, NodeType = TimeNodeValues.TmingRoot };

            parallelTimeNode9.Append(commonTimeNode9);

            timeNodeList9.Append(parallelTimeNode9);

            timing9.Append(timeNodeList9);

            slideLayout7.Append(commonSlideData9);
            slideLayout7.Append(colorMapOverride8);
            slideLayout7.Append(timing9);

            slideLayoutPart7.SlideLayout = slideLayout7;
        }

        // Generates content of slideLayoutPart8.
        private void GenerateSlideLayoutPart8Content(SlideLayoutPart slideLayoutPart8)
        {
            SlideLayout slideLayout8 = new SlideLayout(){ Type = SlideLayoutValues.Object, Preserve = true };
            slideLayout8.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout8.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout8.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData10 = new CommonSlideData(){ Name = "Title and Content" };

            ShapeTree shapeTree10 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties10 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties89 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties10 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties89 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties10.Append(nonVisualDrawingProperties89);
            nonVisualGroupShapeProperties10.Append(nonVisualGroupShapeDrawingProperties10);
            nonVisualGroupShapeProperties10.Append(applicationNonVisualDrawingProperties89);

            GroupShapeProperties groupShapeProperties10 = new GroupShapeProperties();

            A.TransformGroup transformGroup10 = new A.TransformGroup();
            A.Offset offset66 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents66 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset10 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents10 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup10.Append(offset66);
            transformGroup10.Append(extents66);
            transformGroup10.Append(childOffset10);
            transformGroup10.Append(childExtents10);

            groupShapeProperties10.Append(transformGroup10);

            Shape shape45 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties45 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties90 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties45 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks43 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties45.Append(shapeLocks43);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties90 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape43 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties90.Append(placeholderShape43);

            nonVisualShapeProperties45.Append(nonVisualDrawingProperties90);
            nonVisualShapeProperties45.Append(nonVisualShapeDrawingProperties45);
            nonVisualShapeProperties45.Append(applicationNonVisualDrawingProperties90);
            ShapeProperties shapeProperties80 = new ShapeProperties();

            TextBody textBody45 = new TextBody();
            A.BodyProperties bodyProperties45 = new A.BodyProperties();
            A.ListStyle listStyle45 = new A.ListStyle();

            A.Paragraph paragraph57 = new A.Paragraph();

            A.Run run34 = new A.Run();

            A.RunProperties runProperties50 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties50.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text50 = new A.Text();
            text50.Text = "Click to edit Master title style";

            run34.Append(runProperties50);
            run34.Append(text50);
            A.EndParagraphRunProperties endParagraphRunProperties40 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph57.Append(run34);
            paragraph57.Append(endParagraphRunProperties40);

            textBody45.Append(bodyProperties45);
            textBody45.Append(listStyle45);
            textBody45.Append(paragraph57);

            shape45.Append(nonVisualShapeProperties45);
            shape45.Append(shapeProperties80);
            shape45.Append(textBody45);

            Shape shape46 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties46 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties91 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Content Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties46 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks44 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties46.Append(shapeLocks44);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties91 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape44 = new PlaceholderShape(){ Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties91.Append(placeholderShape44);

            nonVisualShapeProperties46.Append(nonVisualDrawingProperties91);
            nonVisualShapeProperties46.Append(nonVisualShapeDrawingProperties46);
            nonVisualShapeProperties46.Append(applicationNonVisualDrawingProperties91);
            ShapeProperties shapeProperties81 = new ShapeProperties();

            TextBody textBody46 = new TextBody();
            A.BodyProperties bodyProperties46 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Center };
            A.ListStyle listStyle46 = new A.ListStyle();

            A.Paragraph paragraph58 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties23 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run35 = new A.Run();

            A.RunProperties runProperties51 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties51.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text51 = new A.Text();
            text51.Text = "Click to edit Master text styles";

            run35.Append(runProperties51);
            run35.Append(text51);

            paragraph58.Append(paragraphProperties23);
            paragraph58.Append(run35);

            A.Paragraph paragraph59 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties24 = new A.ParagraphProperties(){ Level = 1 };

            A.Run run36 = new A.Run();

            A.RunProperties runProperties52 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties52.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text52 = new A.Text();
            text52.Text = "Second level";

            run36.Append(runProperties52);
            run36.Append(text52);

            paragraph59.Append(paragraphProperties24);
            paragraph59.Append(run36);

            A.Paragraph paragraph60 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties25 = new A.ParagraphProperties(){ Level = 2 };

            A.Run run37 = new A.Run();

            A.RunProperties runProperties53 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties53.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text53 = new A.Text();
            text53.Text = "Third level";

            run37.Append(runProperties53);
            run37.Append(text53);

            paragraph60.Append(paragraphProperties25);
            paragraph60.Append(run37);

            A.Paragraph paragraph61 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties26 = new A.ParagraphProperties(){ Level = 3 };

            A.Run run38 = new A.Run();

            A.RunProperties runProperties54 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties54.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text54 = new A.Text();
            text54.Text = "Fourth level";

            run38.Append(runProperties54);
            run38.Append(text54);

            paragraph61.Append(paragraphProperties26);
            paragraph61.Append(run38);

            A.Paragraph paragraph62 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties27 = new A.ParagraphProperties(){ Level = 4 };

            A.Run run39 = new A.Run();

            A.RunProperties runProperties55 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties55.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text55 = new A.Text();
            text55.Text = "Fifth level";

            run39.Append(runProperties55);
            run39.Append(text55);
            A.EndParagraphRunProperties endParagraphRunProperties41 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph62.Append(paragraphProperties27);
            paragraph62.Append(run39);
            paragraph62.Append(endParagraphRunProperties41);

            textBody46.Append(bodyProperties46);
            textBody46.Append(listStyle46);
            textBody46.Append(paragraph58);
            textBody46.Append(paragraph59);
            textBody46.Append(paragraph60);
            textBody46.Append(paragraph61);
            textBody46.Append(paragraph62);

            shape46.Append(nonVisualShapeProperties46);
            shape46.Append(shapeProperties81);
            shape46.Append(textBody46);

            Shape shape47 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties47 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties92 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Date Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties47 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks45 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties47.Append(shapeLocks45);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties92 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape45 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties92.Append(placeholderShape45);

            nonVisualShapeProperties47.Append(nonVisualDrawingProperties92);
            nonVisualShapeProperties47.Append(nonVisualShapeDrawingProperties47);
            nonVisualShapeProperties47.Append(applicationNonVisualDrawingProperties92);
            ShapeProperties shapeProperties82 = new ShapeProperties();

            TextBody textBody47 = new TextBody();
            A.BodyProperties bodyProperties47 = new A.BodyProperties();
            A.ListStyle listStyle47 = new A.ListStyle();

            A.Paragraph paragraph63 = new A.Paragraph();

            A.Field field17 = new A.Field(){ Id = "{CE1A2D98-1BBD-4706-A118-AAC2A16BEAD3}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties56 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties56.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text56 = new A.Text();
            text56.Text = "2012/10/3";

            field17.Append(runProperties56);
            field17.Append(text56);
            A.EndParagraphRunProperties endParagraphRunProperties42 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph63.Append(field17);
            paragraph63.Append(endParagraphRunProperties42);

            textBody47.Append(bodyProperties47);
            textBody47.Append(listStyle47);
            textBody47.Append(paragraph63);

            shape47.Append(nonVisualShapeProperties47);
            shape47.Append(shapeProperties82);
            shape47.Append(textBody47);

            Shape shape48 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties48 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties93 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Footer Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties48 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks46 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties48.Append(shapeLocks46);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties93 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape46 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties93.Append(placeholderShape46);

            nonVisualShapeProperties48.Append(nonVisualDrawingProperties93);
            nonVisualShapeProperties48.Append(nonVisualShapeDrawingProperties48);
            nonVisualShapeProperties48.Append(applicationNonVisualDrawingProperties93);
            ShapeProperties shapeProperties83 = new ShapeProperties();

            TextBody textBody48 = new TextBody();
            A.BodyProperties bodyProperties48 = new A.BodyProperties();
            A.ListStyle listStyle48 = new A.ListStyle();

            A.Paragraph paragraph64 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties43 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph64.Append(endParagraphRunProperties43);

            textBody48.Append(bodyProperties48);
            textBody48.Append(listStyle48);
            textBody48.Append(paragraph64);

            shape48.Append(nonVisualShapeProperties48);
            shape48.Append(shapeProperties83);
            shape48.Append(textBody48);

            Shape shape49 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties49 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties94 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Slide Number Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties49 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks47 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties49.Append(shapeLocks47);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties94 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape47 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties94.Append(placeholderShape47);

            nonVisualShapeProperties49.Append(nonVisualDrawingProperties94);
            nonVisualShapeProperties49.Append(nonVisualShapeDrawingProperties49);
            nonVisualShapeProperties49.Append(applicationNonVisualDrawingProperties94);
            ShapeProperties shapeProperties84 = new ShapeProperties();

            TextBody textBody49 = new TextBody();
            A.BodyProperties bodyProperties49 = new A.BodyProperties();
            A.ListStyle listStyle49 = new A.ListStyle();

            A.Paragraph paragraph65 = new A.Paragraph();

            A.Field field18 = new A.Field(){ Id = "{D107CD50-7081-433F-A1F2-156B4E14F4F4}", Type = "slidenum" };

            A.RunProperties runProperties57 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties57.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text57 = new A.Text();
            text57.Text = "‹#›";

            field18.Append(runProperties57);
            field18.Append(text57);
            A.EndParagraphRunProperties endParagraphRunProperties44 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph65.Append(field18);
            paragraph65.Append(endParagraphRunProperties44);

            textBody49.Append(bodyProperties49);
            textBody49.Append(listStyle49);
            textBody49.Append(paragraph65);

            shape49.Append(nonVisualShapeProperties49);
            shape49.Append(shapeProperties84);
            shape49.Append(textBody49);

            ConnectionShape connectionShape36 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties36 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties95 = new NonVisualDrawingProperties(){ Id = (UInt32Value)7U, Name = "Straight Connector 6" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties36 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties95 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties36.Append(nonVisualDrawingProperties95);
            nonVisualConnectionShapeProperties36.Append(nonVisualConnectorShapeDrawingProperties36);
            nonVisualConnectionShapeProperties36.Append(applicationNonVisualDrawingProperties95);

            ShapeProperties shapeProperties85 = new ShapeProperties();

            A.Transform2D transform2D57 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset67 = new A.Offset(){ X = 11278949L, Y = 2963333L };
            A.Extents extents67 = new A.Extents(){ Cx = 913052L, Cy = 912812L };

            transform2D57.Append(offset67);
            transform2D57.Append(extents67);

            A.PresetGeometry presetGeometry43 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList43 = new A.AdjustValueList();

            presetGeometry43.Append(adjustValueList43);

            A.Outline outline42 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill137 = new A.SolidFill();
            A.SchemeColor schemeColor293 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill137.Append(schemeColor293);

            outline42.Append(solidFill137);

            shapeProperties85.Append(transform2D57);
            shapeProperties85.Append(presetGeometry43);
            shapeProperties85.Append(outline42);

            ShapeStyle shapeStyle36 = new ShapeStyle();

            A.LineReference lineReference36 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor294 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference36.Append(schemeColor294);

            A.FillReference fillReference36 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor295 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference36.Append(schemeColor295);

            A.EffectReference effectReference36 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor296 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference36.Append(schemeColor296);

            A.FontReference fontReference36 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor297 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference36.Append(schemeColor297);

            shapeStyle36.Append(lineReference36);
            shapeStyle36.Append(fillReference36);
            shapeStyle36.Append(effectReference36);
            shapeStyle36.Append(fontReference36);

            connectionShape36.Append(nonVisualConnectionShapeProperties36);
            connectionShape36.Append(shapeProperties85);
            connectionShape36.Append(shapeStyle36);

            ConnectionShape connectionShape37 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties37 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties96 = new NonVisualDrawingProperties(){ Id = (UInt32Value)8U, Name = "Straight Connector 7" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties37 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties96 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties37.Append(nonVisualDrawingProperties96);
            nonVisualConnectionShapeProperties37.Append(nonVisualConnectorShapeDrawingProperties37);
            nonVisualConnectionShapeProperties37.Append(applicationNonVisualDrawingProperties96);

            ShapeProperties shapeProperties86 = new ShapeProperties();

            A.Transform2D transform2D58 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset68 = new A.Offset(){ X = 9209368L, Y = 3190344L };
            A.Extents extents68 = new A.Extents(){ Cx = 2982634L, Cy = 2981856L };

            transform2D58.Append(offset68);
            transform2D58.Append(extents68);

            A.PresetGeometry presetGeometry44 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList44 = new A.AdjustValueList();

            presetGeometry44.Append(adjustValueList44);

            A.Outline outline43 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill138 = new A.SolidFill();
            A.SchemeColor schemeColor298 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill138.Append(schemeColor298);

            outline43.Append(solidFill138);

            shapeProperties86.Append(transform2D58);
            shapeProperties86.Append(presetGeometry44);
            shapeProperties86.Append(outline43);

            ShapeStyle shapeStyle37 = new ShapeStyle();

            A.LineReference lineReference37 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor299 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference37.Append(schemeColor299);

            A.FillReference fillReference37 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor300 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference37.Append(schemeColor300);

            A.EffectReference effectReference37 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor301 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference37.Append(schemeColor301);

            A.FontReference fontReference37 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor302 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference37.Append(schemeColor302);

            shapeStyle37.Append(lineReference37);
            shapeStyle37.Append(fillReference37);
            shapeStyle37.Append(effectReference37);
            shapeStyle37.Append(fontReference37);

            connectionShape37.Append(nonVisualConnectionShapeProperties37);
            connectionShape37.Append(shapeProperties86);
            connectionShape37.Append(shapeStyle37);

            ConnectionShape connectionShape38 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties38 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties97 = new NonVisualDrawingProperties(){ Id = (UInt32Value)9U, Name = "Straight Connector 8" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties38 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties97 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties38.Append(nonVisualDrawingProperties97);
            nonVisualConnectionShapeProperties38.Append(nonVisualConnectorShapeDrawingProperties38);
            nonVisualConnectionShapeProperties38.Append(applicationNonVisualDrawingProperties97);

            ShapeProperties shapeProperties87 = new ShapeProperties();

            A.Transform2D transform2D59 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset69 = new A.Offset(){ X = 10294973L, Y = 3285068L };
            A.Extents extents69 = new A.Extents(){ Cx = 1897028L, Cy = 1896533L };

            transform2D59.Append(offset69);
            transform2D59.Append(extents69);

            A.PresetGeometry presetGeometry45 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList45 = new A.AdjustValueList();

            presetGeometry45.Append(adjustValueList45);

            A.Outline outline44 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill139 = new A.SolidFill();
            A.SchemeColor schemeColor303 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill139.Append(schemeColor303);

            outline44.Append(solidFill139);

            shapeProperties87.Append(transform2D59);
            shapeProperties87.Append(presetGeometry45);
            shapeProperties87.Append(outline44);

            ShapeStyle shapeStyle38 = new ShapeStyle();

            A.LineReference lineReference38 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor304 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference38.Append(schemeColor304);

            A.FillReference fillReference38 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor305 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference38.Append(schemeColor305);

            A.EffectReference effectReference38 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor306 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference38.Append(schemeColor306);

            A.FontReference fontReference38 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor307 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference38.Append(schemeColor307);

            shapeStyle38.Append(lineReference38);
            shapeStyle38.Append(fillReference38);
            shapeStyle38.Append(effectReference38);
            shapeStyle38.Append(fontReference38);

            connectionShape38.Append(nonVisualConnectionShapeProperties38);
            connectionShape38.Append(shapeProperties87);
            connectionShape38.Append(shapeStyle38);

            ConnectionShape connectionShape39 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties39 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties98 = new NonVisualDrawingProperties(){ Id = (UInt32Value)10U, Name = "Straight Connector 9" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties39 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties98 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties39.Append(nonVisualDrawingProperties98);
            nonVisualConnectionShapeProperties39.Append(nonVisualConnectorShapeDrawingProperties39);
            nonVisualConnectionShapeProperties39.Append(applicationNonVisualDrawingProperties98);

            ShapeProperties shapeProperties88 = new ShapeProperties();

            A.Transform2D transform2D60 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset70 = new A.Offset(){ X = 10445823L, Y = 3131080L };
            A.Extents extents70 = new A.Extents(){ Cx = 1746177L, Cy = 1745720L };

            transform2D60.Append(offset70);
            transform2D60.Append(extents70);

            A.PresetGeometry presetGeometry46 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList46 = new A.AdjustValueList();

            presetGeometry46.Append(adjustValueList46);

            A.Outline outline45 = new A.Outline(){ Width = 28575 };

            A.SolidFill solidFill140 = new A.SolidFill();
            A.SchemeColor schemeColor308 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill140.Append(schemeColor308);

            outline45.Append(solidFill140);

            shapeProperties88.Append(transform2D60);
            shapeProperties88.Append(presetGeometry46);
            shapeProperties88.Append(outline45);

            ShapeStyle shapeStyle39 = new ShapeStyle();

            A.LineReference lineReference39 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor309 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference39.Append(schemeColor309);

            A.FillReference fillReference39 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor310 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference39.Append(schemeColor310);

            A.EffectReference effectReference39 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor311 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference39.Append(schemeColor311);

            A.FontReference fontReference39 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor312 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference39.Append(schemeColor312);

            shapeStyle39.Append(lineReference39);
            shapeStyle39.Append(fillReference39);
            shapeStyle39.Append(effectReference39);
            shapeStyle39.Append(fontReference39);

            connectionShape39.Append(nonVisualConnectionShapeProperties39);
            connectionShape39.Append(shapeProperties88);
            connectionShape39.Append(shapeStyle39);

            ConnectionShape connectionShape40 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties40 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties99 = new NonVisualDrawingProperties(){ Id = (UInt32Value)11U, Name = "Straight Connector 10" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties40 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties99 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties40.Append(nonVisualDrawingProperties99);
            nonVisualConnectionShapeProperties40.Append(nonVisualConnectorShapeDrawingProperties40);
            nonVisualConnectionShapeProperties40.Append(applicationNonVisualDrawingProperties99);

            ShapeProperties shapeProperties89 = new ShapeProperties();

            A.Transform2D transform2D61 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset71 = new A.Offset(){ X = 10921671L, Y = 3683002L };
            A.Extents extents71 = new A.Extents(){ Cx = 1270332L, Cy = 1269999L };

            transform2D61.Append(offset71);
            transform2D61.Append(extents71);

            A.PresetGeometry presetGeometry47 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList47 = new A.AdjustValueList();

            presetGeometry47.Append(adjustValueList47);

            A.Outline outline46 = new A.Outline(){ Width = 28575 };

            A.SolidFill solidFill141 = new A.SolidFill();
            A.SchemeColor schemeColor313 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill141.Append(schemeColor313);

            outline46.Append(solidFill141);

            shapeProperties89.Append(transform2D61);
            shapeProperties89.Append(presetGeometry47);
            shapeProperties89.Append(outline46);

            ShapeStyle shapeStyle40 = new ShapeStyle();

            A.LineReference lineReference40 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor314 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference40.Append(schemeColor314);

            A.FillReference fillReference40 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor315 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference40.Append(schemeColor315);

            A.EffectReference effectReference40 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor316 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference40.Append(schemeColor316);

            A.FontReference fontReference40 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor317 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference40.Append(schemeColor317);

            shapeStyle40.Append(lineReference40);
            shapeStyle40.Append(fillReference40);
            shapeStyle40.Append(effectReference40);
            shapeStyle40.Append(fontReference40);

            connectionShape40.Append(nonVisualConnectionShapeProperties40);
            connectionShape40.Append(shapeProperties89);
            connectionShape40.Append(shapeStyle40);

            shapeTree10.Append(nonVisualGroupShapeProperties10);
            shapeTree10.Append(groupShapeProperties10);
            shapeTree10.Append(shape45);
            shapeTree10.Append(shape46);
            shapeTree10.Append(shape47);
            shapeTree10.Append(shape48);
            shapeTree10.Append(shape49);
            shapeTree10.Append(connectionShape36);
            shapeTree10.Append(connectionShape37);
            shapeTree10.Append(connectionShape38);
            shapeTree10.Append(connectionShape39);
            shapeTree10.Append(connectionShape40);

            CommonSlideDataExtensionList commonSlideDataExtensionList10 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension10 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId10 = new P14.CreationId(){ Val = (UInt32Value)1115643822U };
            creationId10.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension10.Append(creationId10);

            commonSlideDataExtensionList10.Append(commonSlideDataExtension10);

            commonSlideData10.Append(shapeTree10);
            commonSlideData10.Append(commonSlideDataExtensionList10);

            ColorMapOverride colorMapOverride9 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping9 = new A.MasterColorMapping();

            colorMapOverride9.Append(masterColorMapping9);

            Timing timing10 = new Timing();

            TimeNodeList timeNodeList10 = new TimeNodeList();

            ParallelTimeNode parallelTimeNode10 = new ParallelTimeNode();
            CommonTimeNode commonTimeNode10 = new CommonTimeNode(){ Id = (UInt32Value)1U, Duration = "indefinite", Restart = TimeNodeRestartValues.Never, NodeType = TimeNodeValues.TmingRoot };

            parallelTimeNode10.Append(commonTimeNode10);

            timeNodeList10.Append(parallelTimeNode10);

            timing10.Append(timeNodeList10);

            slideLayout8.Append(commonSlideData10);
            slideLayout8.Append(colorMapOverride9);
            slideLayout8.Append(timing10);

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
            NonVisualDrawingProperties nonVisualDrawingProperties100 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties11 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties100 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties11.Append(nonVisualDrawingProperties100);
            nonVisualGroupShapeProperties11.Append(nonVisualGroupShapeDrawingProperties11);
            nonVisualGroupShapeProperties11.Append(applicationNonVisualDrawingProperties100);

            GroupShapeProperties groupShapeProperties11 = new GroupShapeProperties();

            A.TransformGroup transformGroup11 = new A.TransformGroup();
            A.Offset offset72 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents72 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset11 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents11 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup11.Append(offset72);
            transformGroup11.Append(extents72);
            transformGroup11.Append(childOffset11);
            transformGroup11.Append(childExtents11);

            groupShapeProperties11.Append(transformGroup11);

            Shape shape50 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties50 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties101 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties50 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks48 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties50.Append(shapeLocks48);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties101 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape48 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties101.Append(placeholderShape48);

            nonVisualShapeProperties50.Append(nonVisualDrawingProperties101);
            nonVisualShapeProperties50.Append(nonVisualShapeDrawingProperties50);
            nonVisualShapeProperties50.Append(applicationNonVisualDrawingProperties101);
            ShapeProperties shapeProperties90 = new ShapeProperties();

            TextBody textBody50 = new TextBody();
            A.BodyProperties bodyProperties50 = new A.BodyProperties();

            A.ListStyle listStyle50 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties22 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Left };
            A.DefaultRunProperties defaultRunProperties124 = new A.DefaultRunProperties();

            level1ParagraphProperties22.Append(defaultRunProperties124);

            listStyle50.Append(level1ParagraphProperties22);

            A.Paragraph paragraph66 = new A.Paragraph();

            A.Run run40 = new A.Run();

            A.RunProperties runProperties58 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties58.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text58 = new A.Text();
            text58.Text = "Click to edit Master title style";

            run40.Append(runProperties58);
            run40.Append(text58);
            A.EndParagraphRunProperties endParagraphRunProperties45 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph66.Append(run40);
            paragraph66.Append(endParagraphRunProperties45);

            textBody50.Append(bodyProperties50);
            textBody50.Append(listStyle50);
            textBody50.Append(paragraph66);

            shape50.Append(nonVisualShapeProperties50);
            shape50.Append(shapeProperties90);
            shape50.Append(textBody50);

            Shape shape51 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties51 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties102 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Vertical Text Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties51 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks49 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties51.Append(shapeLocks49);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties102 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape49 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Orientation = DirectionValues.Vertical, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties102.Append(placeholderShape49);

            nonVisualShapeProperties51.Append(nonVisualDrawingProperties102);
            nonVisualShapeProperties51.Append(nonVisualShapeDrawingProperties51);
            nonVisualShapeProperties51.Append(applicationNonVisualDrawingProperties102);
            ShapeProperties shapeProperties91 = new ShapeProperties();

            TextBody textBody51 = new TextBody();
            A.BodyProperties bodyProperties51 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.EastAsianVetical, Anchor = A.TextAnchoringTypeValues.Bottom };

            A.ListStyle listStyle51 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties23 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Left };
            A.DefaultRunProperties defaultRunProperties125 = new A.DefaultRunProperties();

            level1ParagraphProperties23.Append(defaultRunProperties125);

            A.Level2ParagraphProperties level2ParagraphProperties14 = new A.Level2ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Left };
            A.DefaultRunProperties defaultRunProperties126 = new A.DefaultRunProperties();

            level2ParagraphProperties14.Append(defaultRunProperties126);

            A.Level3ParagraphProperties level3ParagraphProperties14 = new A.Level3ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Left };
            A.DefaultRunProperties defaultRunProperties127 = new A.DefaultRunProperties();

            level3ParagraphProperties14.Append(defaultRunProperties127);

            A.Level4ParagraphProperties level4ParagraphProperties14 = new A.Level4ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Left };
            A.DefaultRunProperties defaultRunProperties128 = new A.DefaultRunProperties();

            level4ParagraphProperties14.Append(defaultRunProperties128);

            A.Level5ParagraphProperties level5ParagraphProperties14 = new A.Level5ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Left };
            A.DefaultRunProperties defaultRunProperties129 = new A.DefaultRunProperties();

            level5ParagraphProperties14.Append(defaultRunProperties129);

            listStyle51.Append(level1ParagraphProperties23);
            listStyle51.Append(level2ParagraphProperties14);
            listStyle51.Append(level3ParagraphProperties14);
            listStyle51.Append(level4ParagraphProperties14);
            listStyle51.Append(level5ParagraphProperties14);

            A.Paragraph paragraph67 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties28 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run41 = new A.Run();

            A.RunProperties runProperties59 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties59.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text59 = new A.Text();
            text59.Text = "Click to edit Master text styles";

            run41.Append(runProperties59);
            run41.Append(text59);

            paragraph67.Append(paragraphProperties28);
            paragraph67.Append(run41);

            A.Paragraph paragraph68 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties29 = new A.ParagraphProperties(){ Level = 1 };

            A.Run run42 = new A.Run();

            A.RunProperties runProperties60 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties60.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text60 = new A.Text();
            text60.Text = "Second level";

            run42.Append(runProperties60);
            run42.Append(text60);

            paragraph68.Append(paragraphProperties29);
            paragraph68.Append(run42);

            A.Paragraph paragraph69 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties30 = new A.ParagraphProperties(){ Level = 2 };

            A.Run run43 = new A.Run();

            A.RunProperties runProperties61 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties61.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text61 = new A.Text();
            text61.Text = "Third level";

            run43.Append(runProperties61);
            run43.Append(text61);

            paragraph69.Append(paragraphProperties30);
            paragraph69.Append(run43);

            A.Paragraph paragraph70 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties31 = new A.ParagraphProperties(){ Level = 3 };

            A.Run run44 = new A.Run();

            A.RunProperties runProperties62 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties62.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text62 = new A.Text();
            text62.Text = "Fourth level";

            run44.Append(runProperties62);
            run44.Append(text62);

            paragraph70.Append(paragraphProperties31);
            paragraph70.Append(run44);

            A.Paragraph paragraph71 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties32 = new A.ParagraphProperties(){ Level = 4 };

            A.Run run45 = new A.Run();

            A.RunProperties runProperties63 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties63.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text63 = new A.Text();
            text63.Text = "Fifth level";

            run45.Append(runProperties63);
            run45.Append(text63);
            A.EndParagraphRunProperties endParagraphRunProperties46 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph71.Append(paragraphProperties32);
            paragraph71.Append(run45);
            paragraph71.Append(endParagraphRunProperties46);

            textBody51.Append(bodyProperties51);
            textBody51.Append(listStyle51);
            textBody51.Append(paragraph67);
            textBody51.Append(paragraph68);
            textBody51.Append(paragraph69);
            textBody51.Append(paragraph70);
            textBody51.Append(paragraph71);

            shape51.Append(nonVisualShapeProperties51);
            shape51.Append(shapeProperties91);
            shape51.Append(textBody51);

            Shape shape52 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties52 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties103 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Date Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties52 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks50 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties52.Append(shapeLocks50);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties103 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape50 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties103.Append(placeholderShape50);

            nonVisualShapeProperties52.Append(nonVisualDrawingProperties103);
            nonVisualShapeProperties52.Append(nonVisualShapeDrawingProperties52);
            nonVisualShapeProperties52.Append(applicationNonVisualDrawingProperties103);
            ShapeProperties shapeProperties92 = new ShapeProperties();

            TextBody textBody52 = new TextBody();
            A.BodyProperties bodyProperties52 = new A.BodyProperties();
            A.ListStyle listStyle52 = new A.ListStyle();

            A.Paragraph paragraph72 = new A.Paragraph();

            A.Field field19 = new A.Field(){ Id = "{CE1A2D98-1BBD-4706-A118-AAC2A16BEAD3}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties64 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties64.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text64 = new A.Text();
            text64.Text = "2012/10/3";

            field19.Append(runProperties64);
            field19.Append(text64);
            A.EndParagraphRunProperties endParagraphRunProperties47 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph72.Append(field19);
            paragraph72.Append(endParagraphRunProperties47);

            textBody52.Append(bodyProperties52);
            textBody52.Append(listStyle52);
            textBody52.Append(paragraph72);

            shape52.Append(nonVisualShapeProperties52);
            shape52.Append(shapeProperties92);
            shape52.Append(textBody52);

            Shape shape53 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties53 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties104 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Footer Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties53 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks51 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties53.Append(shapeLocks51);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties104 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape51 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties104.Append(placeholderShape51);

            nonVisualShapeProperties53.Append(nonVisualDrawingProperties104);
            nonVisualShapeProperties53.Append(nonVisualShapeDrawingProperties53);
            nonVisualShapeProperties53.Append(applicationNonVisualDrawingProperties104);
            ShapeProperties shapeProperties93 = new ShapeProperties();

            TextBody textBody53 = new TextBody();
            A.BodyProperties bodyProperties53 = new A.BodyProperties();
            A.ListStyle listStyle53 = new A.ListStyle();

            A.Paragraph paragraph73 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties48 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph73.Append(endParagraphRunProperties48);

            textBody53.Append(bodyProperties53);
            textBody53.Append(listStyle53);
            textBody53.Append(paragraph73);

            shape53.Append(nonVisualShapeProperties53);
            shape53.Append(shapeProperties93);
            shape53.Append(textBody53);

            Shape shape54 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties54 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties105 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Slide Number Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties54 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks52 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties54.Append(shapeLocks52);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties105 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape52 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties105.Append(placeholderShape52);

            nonVisualShapeProperties54.Append(nonVisualDrawingProperties105);
            nonVisualShapeProperties54.Append(nonVisualShapeDrawingProperties54);
            nonVisualShapeProperties54.Append(applicationNonVisualDrawingProperties105);
            ShapeProperties shapeProperties94 = new ShapeProperties();

            TextBody textBody54 = new TextBody();
            A.BodyProperties bodyProperties54 = new A.BodyProperties();
            A.ListStyle listStyle54 = new A.ListStyle();

            A.Paragraph paragraph74 = new A.Paragraph();

            A.Field field20 = new A.Field(){ Id = "{D107CD50-7081-433F-A1F2-156B4E14F4F4}", Type = "slidenum" };

            A.RunProperties runProperties65 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties65.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text65 = new A.Text();
            text65.Text = "‹#›";

            field20.Append(runProperties65);
            field20.Append(text65);
            A.EndParagraphRunProperties endParagraphRunProperties49 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph74.Append(field20);
            paragraph74.Append(endParagraphRunProperties49);

            textBody54.Append(bodyProperties54);
            textBody54.Append(listStyle54);
            textBody54.Append(paragraph74);

            shape54.Append(nonVisualShapeProperties54);
            shape54.Append(shapeProperties94);
            shape54.Append(textBody54);

            ConnectionShape connectionShape41 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties41 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties106 = new NonVisualDrawingProperties(){ Id = (UInt32Value)7U, Name = "Straight Connector 6" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties41 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties106 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties41.Append(nonVisualDrawingProperties106);
            nonVisualConnectionShapeProperties41.Append(nonVisualConnectorShapeDrawingProperties41);
            nonVisualConnectionShapeProperties41.Append(applicationNonVisualDrawingProperties106);

            ShapeProperties shapeProperties95 = new ShapeProperties();

            A.Transform2D transform2D62 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset73 = new A.Offset(){ X = 11278949L, Y = 2963333L };
            A.Extents extents73 = new A.Extents(){ Cx = 913052L, Cy = 912812L };

            transform2D62.Append(offset73);
            transform2D62.Append(extents73);

            A.PresetGeometry presetGeometry48 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList48 = new A.AdjustValueList();

            presetGeometry48.Append(adjustValueList48);

            A.Outline outline47 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill142 = new A.SolidFill();
            A.SchemeColor schemeColor318 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill142.Append(schemeColor318);

            outline47.Append(solidFill142);

            shapeProperties95.Append(transform2D62);
            shapeProperties95.Append(presetGeometry48);
            shapeProperties95.Append(outline47);

            ShapeStyle shapeStyle41 = new ShapeStyle();

            A.LineReference lineReference41 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor319 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference41.Append(schemeColor319);

            A.FillReference fillReference41 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor320 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference41.Append(schemeColor320);

            A.EffectReference effectReference41 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor321 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference41.Append(schemeColor321);

            A.FontReference fontReference41 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor322 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference41.Append(schemeColor322);

            shapeStyle41.Append(lineReference41);
            shapeStyle41.Append(fillReference41);
            shapeStyle41.Append(effectReference41);
            shapeStyle41.Append(fontReference41);

            connectionShape41.Append(nonVisualConnectionShapeProperties41);
            connectionShape41.Append(shapeProperties95);
            connectionShape41.Append(shapeStyle41);

            ConnectionShape connectionShape42 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties42 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties107 = new NonVisualDrawingProperties(){ Id = (UInt32Value)8U, Name = "Straight Connector 7" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties42 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties107 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties42.Append(nonVisualDrawingProperties107);
            nonVisualConnectionShapeProperties42.Append(nonVisualConnectorShapeDrawingProperties42);
            nonVisualConnectionShapeProperties42.Append(applicationNonVisualDrawingProperties107);

            ShapeProperties shapeProperties96 = new ShapeProperties();

            A.Transform2D transform2D63 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset74 = new A.Offset(){ X = 9209368L, Y = 3190344L };
            A.Extents extents74 = new A.Extents(){ Cx = 2982634L, Cy = 2981856L };

            transform2D63.Append(offset74);
            transform2D63.Append(extents74);

            A.PresetGeometry presetGeometry49 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList49 = new A.AdjustValueList();

            presetGeometry49.Append(adjustValueList49);

            A.Outline outline48 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill143 = new A.SolidFill();
            A.SchemeColor schemeColor323 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill143.Append(schemeColor323);

            outline48.Append(solidFill143);

            shapeProperties96.Append(transform2D63);
            shapeProperties96.Append(presetGeometry49);
            shapeProperties96.Append(outline48);

            ShapeStyle shapeStyle42 = new ShapeStyle();

            A.LineReference lineReference42 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor324 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference42.Append(schemeColor324);

            A.FillReference fillReference42 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor325 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference42.Append(schemeColor325);

            A.EffectReference effectReference42 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor326 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference42.Append(schemeColor326);

            A.FontReference fontReference42 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor327 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference42.Append(schemeColor327);

            shapeStyle42.Append(lineReference42);
            shapeStyle42.Append(fillReference42);
            shapeStyle42.Append(effectReference42);
            shapeStyle42.Append(fontReference42);

            connectionShape42.Append(nonVisualConnectionShapeProperties42);
            connectionShape42.Append(shapeProperties96);
            connectionShape42.Append(shapeStyle42);

            ConnectionShape connectionShape43 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties43 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties108 = new NonVisualDrawingProperties(){ Id = (UInt32Value)9U, Name = "Straight Connector 8" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties43 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties108 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties43.Append(nonVisualDrawingProperties108);
            nonVisualConnectionShapeProperties43.Append(nonVisualConnectorShapeDrawingProperties43);
            nonVisualConnectionShapeProperties43.Append(applicationNonVisualDrawingProperties108);

            ShapeProperties shapeProperties97 = new ShapeProperties();

            A.Transform2D transform2D64 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset75 = new A.Offset(){ X = 10294973L, Y = 3285068L };
            A.Extents extents75 = new A.Extents(){ Cx = 1897028L, Cy = 1896533L };

            transform2D64.Append(offset75);
            transform2D64.Append(extents75);

            A.PresetGeometry presetGeometry50 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList50 = new A.AdjustValueList();

            presetGeometry50.Append(adjustValueList50);

            A.Outline outline49 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill144 = new A.SolidFill();
            A.SchemeColor schemeColor328 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill144.Append(schemeColor328);

            outline49.Append(solidFill144);

            shapeProperties97.Append(transform2D64);
            shapeProperties97.Append(presetGeometry50);
            shapeProperties97.Append(outline49);

            ShapeStyle shapeStyle43 = new ShapeStyle();

            A.LineReference lineReference43 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor329 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference43.Append(schemeColor329);

            A.FillReference fillReference43 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor330 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference43.Append(schemeColor330);

            A.EffectReference effectReference43 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor331 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference43.Append(schemeColor331);

            A.FontReference fontReference43 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor332 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference43.Append(schemeColor332);

            shapeStyle43.Append(lineReference43);
            shapeStyle43.Append(fillReference43);
            shapeStyle43.Append(effectReference43);
            shapeStyle43.Append(fontReference43);

            connectionShape43.Append(nonVisualConnectionShapeProperties43);
            connectionShape43.Append(shapeProperties97);
            connectionShape43.Append(shapeStyle43);

            ConnectionShape connectionShape44 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties44 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties109 = new NonVisualDrawingProperties(){ Id = (UInt32Value)10U, Name = "Straight Connector 9" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties44 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties109 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties44.Append(nonVisualDrawingProperties109);
            nonVisualConnectionShapeProperties44.Append(nonVisualConnectorShapeDrawingProperties44);
            nonVisualConnectionShapeProperties44.Append(applicationNonVisualDrawingProperties109);

            ShapeProperties shapeProperties98 = new ShapeProperties();

            A.Transform2D transform2D65 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset76 = new A.Offset(){ X = 10445823L, Y = 3131080L };
            A.Extents extents76 = new A.Extents(){ Cx = 1746177L, Cy = 1745720L };

            transform2D65.Append(offset76);
            transform2D65.Append(extents76);

            A.PresetGeometry presetGeometry51 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList51 = new A.AdjustValueList();

            presetGeometry51.Append(adjustValueList51);

            A.Outline outline50 = new A.Outline(){ Width = 28575 };

            A.SolidFill solidFill145 = new A.SolidFill();
            A.SchemeColor schemeColor333 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill145.Append(schemeColor333);

            outline50.Append(solidFill145);

            shapeProperties98.Append(transform2D65);
            shapeProperties98.Append(presetGeometry51);
            shapeProperties98.Append(outline50);

            ShapeStyle shapeStyle44 = new ShapeStyle();

            A.LineReference lineReference44 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor334 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference44.Append(schemeColor334);

            A.FillReference fillReference44 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor335 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference44.Append(schemeColor335);

            A.EffectReference effectReference44 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor336 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference44.Append(schemeColor336);

            A.FontReference fontReference44 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor337 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference44.Append(schemeColor337);

            shapeStyle44.Append(lineReference44);
            shapeStyle44.Append(fillReference44);
            shapeStyle44.Append(effectReference44);
            shapeStyle44.Append(fontReference44);

            connectionShape44.Append(nonVisualConnectionShapeProperties44);
            connectionShape44.Append(shapeProperties98);
            connectionShape44.Append(shapeStyle44);

            ConnectionShape connectionShape45 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties45 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties110 = new NonVisualDrawingProperties(){ Id = (UInt32Value)11U, Name = "Straight Connector 10" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties45 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties110 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties45.Append(nonVisualDrawingProperties110);
            nonVisualConnectionShapeProperties45.Append(nonVisualConnectorShapeDrawingProperties45);
            nonVisualConnectionShapeProperties45.Append(applicationNonVisualDrawingProperties110);

            ShapeProperties shapeProperties99 = new ShapeProperties();

            A.Transform2D transform2D66 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset77 = new A.Offset(){ X = 10921671L, Y = 3683002L };
            A.Extents extents77 = new A.Extents(){ Cx = 1270332L, Cy = 1269999L };

            transform2D66.Append(offset77);
            transform2D66.Append(extents77);

            A.PresetGeometry presetGeometry52 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList52 = new A.AdjustValueList();

            presetGeometry52.Append(adjustValueList52);

            A.Outline outline51 = new A.Outline(){ Width = 28575 };

            A.SolidFill solidFill146 = new A.SolidFill();
            A.SchemeColor schemeColor338 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill146.Append(schemeColor338);

            outline51.Append(solidFill146);

            shapeProperties99.Append(transform2D66);
            shapeProperties99.Append(presetGeometry52);
            shapeProperties99.Append(outline51);

            ShapeStyle shapeStyle45 = new ShapeStyle();

            A.LineReference lineReference45 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor339 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference45.Append(schemeColor339);

            A.FillReference fillReference45 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor340 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference45.Append(schemeColor340);

            A.EffectReference effectReference45 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor341 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference45.Append(schemeColor341);

            A.FontReference fontReference45 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor342 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference45.Append(schemeColor342);

            shapeStyle45.Append(lineReference45);
            shapeStyle45.Append(fillReference45);
            shapeStyle45.Append(effectReference45);
            shapeStyle45.Append(fontReference45);

            connectionShape45.Append(nonVisualConnectionShapeProperties45);
            connectionShape45.Append(shapeProperties99);
            connectionShape45.Append(shapeStyle45);

            shapeTree11.Append(nonVisualGroupShapeProperties11);
            shapeTree11.Append(groupShapeProperties11);
            shapeTree11.Append(shape50);
            shapeTree11.Append(shape51);
            shapeTree11.Append(shape52);
            shapeTree11.Append(shape53);
            shapeTree11.Append(shape54);
            shapeTree11.Append(connectionShape41);
            shapeTree11.Append(connectionShape42);
            shapeTree11.Append(connectionShape43);
            shapeTree11.Append(connectionShape44);
            shapeTree11.Append(connectionShape45);

            CommonSlideDataExtensionList commonSlideDataExtensionList11 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension11 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId11 = new P14.CreationId(){ Val = (UInt32Value)829018732U };
            creationId11.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension11.Append(creationId11);

            commonSlideDataExtensionList11.Append(commonSlideDataExtension11);

            commonSlideData11.Append(shapeTree11);
            commonSlideData11.Append(commonSlideDataExtensionList11);

            ColorMapOverride colorMapOverride10 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping10 = new A.MasterColorMapping();

            colorMapOverride10.Append(masterColorMapping10);

            Timing timing11 = new Timing();

            TimeNodeList timeNodeList11 = new TimeNodeList();

            ParallelTimeNode parallelTimeNode11 = new ParallelTimeNode();
            CommonTimeNode commonTimeNode11 = new CommonTimeNode(){ Id = (UInt32Value)1U, Duration = "indefinite", Restart = TimeNodeRestartValues.Never, NodeType = TimeNodeValues.TmingRoot };

            parallelTimeNode11.Append(commonTimeNode11);

            timeNodeList11.Append(parallelTimeNode11);

            timing11.Append(timeNodeList11);

            slideLayout9.Append(commonSlideData11);
            slideLayout9.Append(colorMapOverride10);
            slideLayout9.Append(timing11);

            slideLayoutPart9.SlideLayout = slideLayout9;
        }

        // Generates content of slideLayoutPart10.
        private void GenerateSlideLayoutPart10Content(SlideLayoutPart slideLayoutPart10)
        {
            SlideLayout slideLayout10 = new SlideLayout(){ Type = SlideLayoutValues.TitleOnly, Preserve = true };
            slideLayout10.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout10.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout10.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData12 = new CommonSlideData(){ Name = "Title Only" };

            ShapeTree shapeTree12 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties12 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties111 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties12 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties111 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties12.Append(nonVisualDrawingProperties111);
            nonVisualGroupShapeProperties12.Append(nonVisualGroupShapeDrawingProperties12);
            nonVisualGroupShapeProperties12.Append(applicationNonVisualDrawingProperties111);

            GroupShapeProperties groupShapeProperties12 = new GroupShapeProperties();

            A.TransformGroup transformGroup12 = new A.TransformGroup();
            A.Offset offset78 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents78 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset12 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents12 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup12.Append(offset78);
            transformGroup12.Append(extents78);
            transformGroup12.Append(childOffset12);
            transformGroup12.Append(childExtents12);

            groupShapeProperties12.Append(transformGroup12);

            Shape shape55 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties55 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties112 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties55 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks53 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties55.Append(shapeLocks53);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties112 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape53 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties112.Append(placeholderShape53);

            nonVisualShapeProperties55.Append(nonVisualDrawingProperties112);
            nonVisualShapeProperties55.Append(nonVisualShapeDrawingProperties55);
            nonVisualShapeProperties55.Append(applicationNonVisualDrawingProperties112);
            ShapeProperties shapeProperties100 = new ShapeProperties();

            TextBody textBody55 = new TextBody();
            A.BodyProperties bodyProperties55 = new A.BodyProperties();
            A.ListStyle listStyle55 = new A.ListStyle();

            A.Paragraph paragraph75 = new A.Paragraph();

            A.Run run46 = new A.Run();

            A.RunProperties runProperties66 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties66.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text66 = new A.Text();
            text66.Text = "Click to edit Master title style";

            run46.Append(runProperties66);
            run46.Append(text66);
            A.EndParagraphRunProperties endParagraphRunProperties50 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph75.Append(run46);
            paragraph75.Append(endParagraphRunProperties50);

            textBody55.Append(bodyProperties55);
            textBody55.Append(listStyle55);
            textBody55.Append(paragraph75);

            shape55.Append(nonVisualShapeProperties55);
            shape55.Append(shapeProperties100);
            shape55.Append(textBody55);

            Shape shape56 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties56 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties113 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Date Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties56 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks54 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties56.Append(shapeLocks54);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties113 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape54 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties113.Append(placeholderShape54);

            nonVisualShapeProperties56.Append(nonVisualDrawingProperties113);
            nonVisualShapeProperties56.Append(nonVisualShapeDrawingProperties56);
            nonVisualShapeProperties56.Append(applicationNonVisualDrawingProperties113);
            ShapeProperties shapeProperties101 = new ShapeProperties();

            TextBody textBody56 = new TextBody();
            A.BodyProperties bodyProperties56 = new A.BodyProperties();
            A.ListStyle listStyle56 = new A.ListStyle();

            A.Paragraph paragraph76 = new A.Paragraph();

            A.Field field21 = new A.Field(){ Id = "{CE1A2D98-1BBD-4706-A118-AAC2A16BEAD3}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties67 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties67.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text67 = new A.Text();
            text67.Text = "2012/10/3";

            field21.Append(runProperties67);
            field21.Append(text67);
            A.EndParagraphRunProperties endParagraphRunProperties51 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph76.Append(field21);
            paragraph76.Append(endParagraphRunProperties51);

            textBody56.Append(bodyProperties56);
            textBody56.Append(listStyle56);
            textBody56.Append(paragraph76);

            shape56.Append(nonVisualShapeProperties56);
            shape56.Append(shapeProperties101);
            shape56.Append(textBody56);

            Shape shape57 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties57 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties114 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Footer Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties57 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks55 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties57.Append(shapeLocks55);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties114 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape55 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties114.Append(placeholderShape55);

            nonVisualShapeProperties57.Append(nonVisualDrawingProperties114);
            nonVisualShapeProperties57.Append(nonVisualShapeDrawingProperties57);
            nonVisualShapeProperties57.Append(applicationNonVisualDrawingProperties114);
            ShapeProperties shapeProperties102 = new ShapeProperties();

            TextBody textBody57 = new TextBody();
            A.BodyProperties bodyProperties57 = new A.BodyProperties();
            A.ListStyle listStyle57 = new A.ListStyle();

            A.Paragraph paragraph77 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties52 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph77.Append(endParagraphRunProperties52);

            textBody57.Append(bodyProperties57);
            textBody57.Append(listStyle57);
            textBody57.Append(paragraph77);

            shape57.Append(nonVisualShapeProperties57);
            shape57.Append(shapeProperties102);
            shape57.Append(textBody57);

            Shape shape58 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties58 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties115 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Slide Number Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties58 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks56 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties58.Append(shapeLocks56);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties115 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape56 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties115.Append(placeholderShape56);

            nonVisualShapeProperties58.Append(nonVisualDrawingProperties115);
            nonVisualShapeProperties58.Append(nonVisualShapeDrawingProperties58);
            nonVisualShapeProperties58.Append(applicationNonVisualDrawingProperties115);
            ShapeProperties shapeProperties103 = new ShapeProperties();

            TextBody textBody58 = new TextBody();
            A.BodyProperties bodyProperties58 = new A.BodyProperties();
            A.ListStyle listStyle58 = new A.ListStyle();

            A.Paragraph paragraph78 = new A.Paragraph();

            A.Field field22 = new A.Field(){ Id = "{D107CD50-7081-433F-A1F2-156B4E14F4F4}", Type = "slidenum" };

            A.RunProperties runProperties68 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties68.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text68 = new A.Text();
            text68.Text = "‹#›";

            field22.Append(runProperties68);
            field22.Append(text68);
            A.EndParagraphRunProperties endParagraphRunProperties53 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph78.Append(field22);
            paragraph78.Append(endParagraphRunProperties53);

            textBody58.Append(bodyProperties58);
            textBody58.Append(listStyle58);
            textBody58.Append(paragraph78);

            shape58.Append(nonVisualShapeProperties58);
            shape58.Append(shapeProperties103);
            shape58.Append(textBody58);

            ConnectionShape connectionShape46 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties46 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties116 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Straight Connector 5" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties46 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties116 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties46.Append(nonVisualDrawingProperties116);
            nonVisualConnectionShapeProperties46.Append(nonVisualConnectorShapeDrawingProperties46);
            nonVisualConnectionShapeProperties46.Append(applicationNonVisualDrawingProperties116);

            ShapeProperties shapeProperties104 = new ShapeProperties();

            A.Transform2D transform2D67 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset79 = new A.Offset(){ X = 11278949L, Y = 2963333L };
            A.Extents extents79 = new A.Extents(){ Cx = 913052L, Cy = 912812L };

            transform2D67.Append(offset79);
            transform2D67.Append(extents79);

            A.PresetGeometry presetGeometry53 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList53 = new A.AdjustValueList();

            presetGeometry53.Append(adjustValueList53);

            A.Outline outline52 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill147 = new A.SolidFill();
            A.SchemeColor schemeColor343 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill147.Append(schemeColor343);

            outline52.Append(solidFill147);

            shapeProperties104.Append(transform2D67);
            shapeProperties104.Append(presetGeometry53);
            shapeProperties104.Append(outline52);

            ShapeStyle shapeStyle46 = new ShapeStyle();

            A.LineReference lineReference46 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor344 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference46.Append(schemeColor344);

            A.FillReference fillReference46 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor345 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference46.Append(schemeColor345);

            A.EffectReference effectReference46 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor346 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference46.Append(schemeColor346);

            A.FontReference fontReference46 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor347 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference46.Append(schemeColor347);

            shapeStyle46.Append(lineReference46);
            shapeStyle46.Append(fillReference46);
            shapeStyle46.Append(effectReference46);
            shapeStyle46.Append(fontReference46);

            connectionShape46.Append(nonVisualConnectionShapeProperties46);
            connectionShape46.Append(shapeProperties104);
            connectionShape46.Append(shapeStyle46);

            ConnectionShape connectionShape47 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties47 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties117 = new NonVisualDrawingProperties(){ Id = (UInt32Value)7U, Name = "Straight Connector 6" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties47 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties117 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties47.Append(nonVisualDrawingProperties117);
            nonVisualConnectionShapeProperties47.Append(nonVisualConnectorShapeDrawingProperties47);
            nonVisualConnectionShapeProperties47.Append(applicationNonVisualDrawingProperties117);

            ShapeProperties shapeProperties105 = new ShapeProperties();

            A.Transform2D transform2D68 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset80 = new A.Offset(){ X = 9209368L, Y = 3190344L };
            A.Extents extents80 = new A.Extents(){ Cx = 2982634L, Cy = 2981856L };

            transform2D68.Append(offset80);
            transform2D68.Append(extents80);

            A.PresetGeometry presetGeometry54 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList54 = new A.AdjustValueList();

            presetGeometry54.Append(adjustValueList54);

            A.Outline outline53 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill148 = new A.SolidFill();
            A.SchemeColor schemeColor348 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill148.Append(schemeColor348);

            outline53.Append(solidFill148);

            shapeProperties105.Append(transform2D68);
            shapeProperties105.Append(presetGeometry54);
            shapeProperties105.Append(outline53);

            ShapeStyle shapeStyle47 = new ShapeStyle();

            A.LineReference lineReference47 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor349 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference47.Append(schemeColor349);

            A.FillReference fillReference47 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor350 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference47.Append(schemeColor350);

            A.EffectReference effectReference47 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor351 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference47.Append(schemeColor351);

            A.FontReference fontReference47 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor352 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference47.Append(schemeColor352);

            shapeStyle47.Append(lineReference47);
            shapeStyle47.Append(fillReference47);
            shapeStyle47.Append(effectReference47);
            shapeStyle47.Append(fontReference47);

            connectionShape47.Append(nonVisualConnectionShapeProperties47);
            connectionShape47.Append(shapeProperties105);
            connectionShape47.Append(shapeStyle47);

            ConnectionShape connectionShape48 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties48 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties118 = new NonVisualDrawingProperties(){ Id = (UInt32Value)8U, Name = "Straight Connector 7" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties48 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties118 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties48.Append(nonVisualDrawingProperties118);
            nonVisualConnectionShapeProperties48.Append(nonVisualConnectorShapeDrawingProperties48);
            nonVisualConnectionShapeProperties48.Append(applicationNonVisualDrawingProperties118);

            ShapeProperties shapeProperties106 = new ShapeProperties();

            A.Transform2D transform2D69 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset81 = new A.Offset(){ X = 10294973L, Y = 3285068L };
            A.Extents extents81 = new A.Extents(){ Cx = 1897028L, Cy = 1896533L };

            transform2D69.Append(offset81);
            transform2D69.Append(extents81);

            A.PresetGeometry presetGeometry55 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList55 = new A.AdjustValueList();

            presetGeometry55.Append(adjustValueList55);

            A.Outline outline54 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill149 = new A.SolidFill();
            A.SchemeColor schemeColor353 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill149.Append(schemeColor353);

            outline54.Append(solidFill149);

            shapeProperties106.Append(transform2D69);
            shapeProperties106.Append(presetGeometry55);
            shapeProperties106.Append(outline54);

            ShapeStyle shapeStyle48 = new ShapeStyle();

            A.LineReference lineReference48 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor354 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference48.Append(schemeColor354);

            A.FillReference fillReference48 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor355 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference48.Append(schemeColor355);

            A.EffectReference effectReference48 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor356 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference48.Append(schemeColor356);

            A.FontReference fontReference48 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor357 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference48.Append(schemeColor357);

            shapeStyle48.Append(lineReference48);
            shapeStyle48.Append(fillReference48);
            shapeStyle48.Append(effectReference48);
            shapeStyle48.Append(fontReference48);

            connectionShape48.Append(nonVisualConnectionShapeProperties48);
            connectionShape48.Append(shapeProperties106);
            connectionShape48.Append(shapeStyle48);

            ConnectionShape connectionShape49 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties49 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties119 = new NonVisualDrawingProperties(){ Id = (UInt32Value)9U, Name = "Straight Connector 8" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties49 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties119 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties49.Append(nonVisualDrawingProperties119);
            nonVisualConnectionShapeProperties49.Append(nonVisualConnectorShapeDrawingProperties49);
            nonVisualConnectionShapeProperties49.Append(applicationNonVisualDrawingProperties119);

            ShapeProperties shapeProperties107 = new ShapeProperties();

            A.Transform2D transform2D70 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset82 = new A.Offset(){ X = 10445823L, Y = 3131080L };
            A.Extents extents82 = new A.Extents(){ Cx = 1746177L, Cy = 1745720L };

            transform2D70.Append(offset82);
            transform2D70.Append(extents82);

            A.PresetGeometry presetGeometry56 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList56 = new A.AdjustValueList();

            presetGeometry56.Append(adjustValueList56);

            A.Outline outline55 = new A.Outline(){ Width = 28575 };

            A.SolidFill solidFill150 = new A.SolidFill();
            A.SchemeColor schemeColor358 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill150.Append(schemeColor358);

            outline55.Append(solidFill150);

            shapeProperties107.Append(transform2D70);
            shapeProperties107.Append(presetGeometry56);
            shapeProperties107.Append(outline55);

            ShapeStyle shapeStyle49 = new ShapeStyle();

            A.LineReference lineReference49 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor359 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference49.Append(schemeColor359);

            A.FillReference fillReference49 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor360 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference49.Append(schemeColor360);

            A.EffectReference effectReference49 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor361 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference49.Append(schemeColor361);

            A.FontReference fontReference49 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor362 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference49.Append(schemeColor362);

            shapeStyle49.Append(lineReference49);
            shapeStyle49.Append(fillReference49);
            shapeStyle49.Append(effectReference49);
            shapeStyle49.Append(fontReference49);

            connectionShape49.Append(nonVisualConnectionShapeProperties49);
            connectionShape49.Append(shapeProperties107);
            connectionShape49.Append(shapeStyle49);

            ConnectionShape connectionShape50 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties50 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties120 = new NonVisualDrawingProperties(){ Id = (UInt32Value)10U, Name = "Straight Connector 9" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties50 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties120 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties50.Append(nonVisualDrawingProperties120);
            nonVisualConnectionShapeProperties50.Append(nonVisualConnectorShapeDrawingProperties50);
            nonVisualConnectionShapeProperties50.Append(applicationNonVisualDrawingProperties120);

            ShapeProperties shapeProperties108 = new ShapeProperties();

            A.Transform2D transform2D71 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset83 = new A.Offset(){ X = 10921671L, Y = 3683002L };
            A.Extents extents83 = new A.Extents(){ Cx = 1270332L, Cy = 1269999L };

            transform2D71.Append(offset83);
            transform2D71.Append(extents83);

            A.PresetGeometry presetGeometry57 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList57 = new A.AdjustValueList();

            presetGeometry57.Append(adjustValueList57);

            A.Outline outline56 = new A.Outline(){ Width = 28575 };

            A.SolidFill solidFill151 = new A.SolidFill();
            A.SchemeColor schemeColor363 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill151.Append(schemeColor363);

            outline56.Append(solidFill151);

            shapeProperties108.Append(transform2D71);
            shapeProperties108.Append(presetGeometry57);
            shapeProperties108.Append(outline56);

            ShapeStyle shapeStyle50 = new ShapeStyle();

            A.LineReference lineReference50 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor364 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference50.Append(schemeColor364);

            A.FillReference fillReference50 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor365 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference50.Append(schemeColor365);

            A.EffectReference effectReference50 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor366 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference50.Append(schemeColor366);

            A.FontReference fontReference50 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor367 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference50.Append(schemeColor367);

            shapeStyle50.Append(lineReference50);
            shapeStyle50.Append(fillReference50);
            shapeStyle50.Append(effectReference50);
            shapeStyle50.Append(fontReference50);

            connectionShape50.Append(nonVisualConnectionShapeProperties50);
            connectionShape50.Append(shapeProperties108);
            connectionShape50.Append(shapeStyle50);

            shapeTree12.Append(nonVisualGroupShapeProperties12);
            shapeTree12.Append(groupShapeProperties12);
            shapeTree12.Append(shape55);
            shapeTree12.Append(shape56);
            shapeTree12.Append(shape57);
            shapeTree12.Append(shape58);
            shapeTree12.Append(connectionShape46);
            shapeTree12.Append(connectionShape47);
            shapeTree12.Append(connectionShape48);
            shapeTree12.Append(connectionShape49);
            shapeTree12.Append(connectionShape50);

            CommonSlideDataExtensionList commonSlideDataExtensionList12 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension12 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId12 = new P14.CreationId(){ Val = (UInt32Value)1621865369U };
            creationId12.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension12.Append(creationId12);

            commonSlideDataExtensionList12.Append(commonSlideDataExtension12);

            commonSlideData12.Append(shapeTree12);
            commonSlideData12.Append(commonSlideDataExtensionList12);

            ColorMapOverride colorMapOverride11 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping11 = new A.MasterColorMapping();

            colorMapOverride11.Append(masterColorMapping11);

            Timing timing12 = new Timing();

            TimeNodeList timeNodeList12 = new TimeNodeList();

            ParallelTimeNode parallelTimeNode12 = new ParallelTimeNode();
            CommonTimeNode commonTimeNode12 = new CommonTimeNode(){ Id = (UInt32Value)1U, Duration = "indefinite", Restart = TimeNodeRestartValues.Never, NodeType = TimeNodeValues.TmingRoot };

            parallelTimeNode12.Append(commonTimeNode12);

            timeNodeList12.Append(parallelTimeNode12);

            timing12.Append(timeNodeList12);

            slideLayout10.Append(commonSlideData12);
            slideLayout10.Append(colorMapOverride11);
            slideLayout10.Append(timing12);

            slideLayoutPart10.SlideLayout = slideLayout10;
        }

        // Generates content of slideLayoutPart11.
        private void GenerateSlideLayoutPart11Content(SlideLayoutPart slideLayoutPart11)
        {
            SlideLayout slideLayout11 = new SlideLayout(){ Type = SlideLayoutValues.SectionHeader, Preserve = true };
            slideLayout11.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout11.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout11.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData13 = new CommonSlideData(){ Name = "Title and Caption" };

            ShapeTree shapeTree13 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties13 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties121 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties13 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties121 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties13.Append(nonVisualDrawingProperties121);
            nonVisualGroupShapeProperties13.Append(nonVisualGroupShapeDrawingProperties13);
            nonVisualGroupShapeProperties13.Append(applicationNonVisualDrawingProperties121);

            GroupShapeProperties groupShapeProperties13 = new GroupShapeProperties();

            A.TransformGroup transformGroup13 = new A.TransformGroup();
            A.Offset offset84 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents84 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset13 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents13 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup13.Append(offset84);
            transformGroup13.Append(extents84);
            transformGroup13.Append(childOffset13);
            transformGroup13.Append(childExtents13);

            groupShapeProperties13.Append(transformGroup13);

            Shape shape59 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties59 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties122 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties59 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks57 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties59.Append(shapeLocks57);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties122 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape57 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties122.Append(placeholderShape57);

            nonVisualShapeProperties59.Append(nonVisualDrawingProperties122);
            nonVisualShapeProperties59.Append(nonVisualShapeDrawingProperties59);
            nonVisualShapeProperties59.Append(applicationNonVisualDrawingProperties122);

            ShapeProperties shapeProperties109 = new ShapeProperties();

            A.Transform2D transform2D72 = new A.Transform2D();
            A.Offset offset85 = new A.Offset(){ X = 684391L, Y = 685800L };
            A.Extents extents85 = new A.Extents(){ Cx = 10061020L, Cy = 2743200L };

            transform2D72.Append(offset85);
            transform2D72.Append(extents85);

            shapeProperties109.Append(transform2D72);

            TextBody textBody59 = new TextBody();

            A.BodyProperties bodyProperties59 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Center };
            A.NormalAutoFit normalAutoFit14 = new A.NormalAutoFit();

            bodyProperties59.Append(normalAutoFit14);

            A.ListStyle listStyle59 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties24 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Left };
            A.DefaultRunProperties defaultRunProperties130 = new A.DefaultRunProperties(){ FontSize = 3200, Bold = false, Capital = A.TextCapsValues.All };

            level1ParagraphProperties24.Append(defaultRunProperties130);

            listStyle59.Append(level1ParagraphProperties24);

            A.Paragraph paragraph79 = new A.Paragraph();

            A.Run run47 = new A.Run();

            A.RunProperties runProperties69 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties69.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text69 = new A.Text();
            text69.Text = "Click to edit Master title style";

            run47.Append(runProperties69);
            run47.Append(text69);
            A.EndParagraphRunProperties endParagraphRunProperties54 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph79.Append(run47);
            paragraph79.Append(endParagraphRunProperties54);

            textBody59.Append(bodyProperties59);
            textBody59.Append(listStyle59);
            textBody59.Append(paragraph79);

            shape59.Append(nonVisualShapeProperties59);
            shape59.Append(shapeProperties109);
            shape59.Append(textBody59);

            Shape shape60 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties60 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties123 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Text Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties60 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks58 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties60.Append(shapeLocks58);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties123 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape58 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties123.Append(placeholderShape58);

            nonVisualShapeProperties60.Append(nonVisualDrawingProperties123);
            nonVisualShapeProperties60.Append(nonVisualShapeDrawingProperties60);
            nonVisualShapeProperties60.Append(applicationNonVisualDrawingProperties123);

            ShapeProperties shapeProperties110 = new ShapeProperties();

            A.Transform2D transform2D73 = new A.Transform2D();
            A.Offset offset86 = new A.Offset(){ X = 684390L, Y = 4114800L };
            A.Extents extents86 = new A.Extents(){ Cx = 8538211L, Cy = 1879600L };

            transform2D73.Append(offset86);
            transform2D73.Append(extents86);

            shapeProperties110.Append(transform2D73);

            TextBody textBody60 = new TextBody();

            A.BodyProperties bodyProperties60 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Center };
            A.NormalAutoFit normalAutoFit15 = new A.NormalAutoFit();

            bodyProperties60.Append(normalAutoFit15);

            A.ListStyle listStyle60 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties25 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0, Alignment = A.TextAlignmentTypeValues.Left };
            A.NoBullet noBullet54 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties131 = new A.DefaultRunProperties(){ FontSize = 2000 };

            A.SolidFill solidFill152 = new A.SolidFill();

            A.SchemeColor schemeColor368 = new A.SchemeColor(){ Val = A.SchemeColorValues.Background2 };
            A.LuminanceModulation luminanceModulation22 = new A.LuminanceModulation(){ Val = 75000 };

            schemeColor368.Append(luminanceModulation22);

            solidFill152.Append(schemeColor368);

            defaultRunProperties131.Append(solidFill152);

            level1ParagraphProperties25.Append(noBullet54);
            level1ParagraphProperties25.Append(defaultRunProperties131);

            A.Level2ParagraphProperties level2ParagraphProperties15 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Indent = 0 };
            A.NoBullet noBullet55 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties132 = new A.DefaultRunProperties(){ FontSize = 1800 };

            A.SolidFill solidFill153 = new A.SolidFill();

            A.SchemeColor schemeColor369 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint39 = new A.Tint(){ Val = 75000 };

            schemeColor369.Append(tint39);

            solidFill153.Append(schemeColor369);

            defaultRunProperties132.Append(solidFill153);

            level2ParagraphProperties15.Append(noBullet55);
            level2ParagraphProperties15.Append(defaultRunProperties132);

            A.Level3ParagraphProperties level3ParagraphProperties15 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Indent = 0 };
            A.NoBullet noBullet56 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties133 = new A.DefaultRunProperties(){ FontSize = 1600 };

            A.SolidFill solidFill154 = new A.SolidFill();

            A.SchemeColor schemeColor370 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint40 = new A.Tint(){ Val = 75000 };

            schemeColor370.Append(tint40);

            solidFill154.Append(schemeColor370);

            defaultRunProperties133.Append(solidFill154);

            level3ParagraphProperties15.Append(noBullet56);
            level3ParagraphProperties15.Append(defaultRunProperties133);

            A.Level4ParagraphProperties level4ParagraphProperties15 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Indent = 0 };
            A.NoBullet noBullet57 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties134 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill155 = new A.SolidFill();

            A.SchemeColor schemeColor371 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint41 = new A.Tint(){ Val = 75000 };

            schemeColor371.Append(tint41);

            solidFill155.Append(schemeColor371);

            defaultRunProperties134.Append(solidFill155);

            level4ParagraphProperties15.Append(noBullet57);
            level4ParagraphProperties15.Append(defaultRunProperties134);

            A.Level5ParagraphProperties level5ParagraphProperties15 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Indent = 0 };
            A.NoBullet noBullet58 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties135 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill156 = new A.SolidFill();

            A.SchemeColor schemeColor372 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint42 = new A.Tint(){ Val = 75000 };

            schemeColor372.Append(tint42);

            solidFill156.Append(schemeColor372);

            defaultRunProperties135.Append(solidFill156);

            level5ParagraphProperties15.Append(noBullet58);
            level5ParagraphProperties15.Append(defaultRunProperties135);

            A.Level6ParagraphProperties level6ParagraphProperties13 = new A.Level6ParagraphProperties(){ LeftMargin = 2286000, Indent = 0 };
            A.NoBullet noBullet59 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties136 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill157 = new A.SolidFill();

            A.SchemeColor schemeColor373 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint43 = new A.Tint(){ Val = 75000 };

            schemeColor373.Append(tint43);

            solidFill157.Append(schemeColor373);

            defaultRunProperties136.Append(solidFill157);

            level6ParagraphProperties13.Append(noBullet59);
            level6ParagraphProperties13.Append(defaultRunProperties136);

            A.Level7ParagraphProperties level7ParagraphProperties13 = new A.Level7ParagraphProperties(){ LeftMargin = 2743200, Indent = 0 };
            A.NoBullet noBullet60 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties137 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill158 = new A.SolidFill();

            A.SchemeColor schemeColor374 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint44 = new A.Tint(){ Val = 75000 };

            schemeColor374.Append(tint44);

            solidFill158.Append(schemeColor374);

            defaultRunProperties137.Append(solidFill158);

            level7ParagraphProperties13.Append(noBullet60);
            level7ParagraphProperties13.Append(defaultRunProperties137);

            A.Level8ParagraphProperties level8ParagraphProperties13 = new A.Level8ParagraphProperties(){ LeftMargin = 3200400, Indent = 0 };
            A.NoBullet noBullet61 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties138 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill159 = new A.SolidFill();

            A.SchemeColor schemeColor375 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint45 = new A.Tint(){ Val = 75000 };

            schemeColor375.Append(tint45);

            solidFill159.Append(schemeColor375);

            defaultRunProperties138.Append(solidFill159);

            level8ParagraphProperties13.Append(noBullet61);
            level8ParagraphProperties13.Append(defaultRunProperties138);

            A.Level9ParagraphProperties level9ParagraphProperties13 = new A.Level9ParagraphProperties(){ LeftMargin = 3657600, Indent = 0 };
            A.NoBullet noBullet62 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties139 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill160 = new A.SolidFill();

            A.SchemeColor schemeColor376 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint46 = new A.Tint(){ Val = 75000 };

            schemeColor376.Append(tint46);

            solidFill160.Append(schemeColor376);

            defaultRunProperties139.Append(solidFill160);

            level9ParagraphProperties13.Append(noBullet62);
            level9ParagraphProperties13.Append(defaultRunProperties139);

            listStyle60.Append(level1ParagraphProperties25);
            listStyle60.Append(level2ParagraphProperties15);
            listStyle60.Append(level3ParagraphProperties15);
            listStyle60.Append(level4ParagraphProperties15);
            listStyle60.Append(level5ParagraphProperties15);
            listStyle60.Append(level6ParagraphProperties13);
            listStyle60.Append(level7ParagraphProperties13);
            listStyle60.Append(level8ParagraphProperties13);
            listStyle60.Append(level9ParagraphProperties13);

            A.Paragraph paragraph80 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties33 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run48 = new A.Run();

            A.RunProperties runProperties70 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties70.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text70 = new A.Text();
            text70.Text = "Click to edit Master text styles";

            run48.Append(runProperties70);
            run48.Append(text70);

            paragraph80.Append(paragraphProperties33);
            paragraph80.Append(run48);

            textBody60.Append(bodyProperties60);
            textBody60.Append(listStyle60);
            textBody60.Append(paragraph80);

            shape60.Append(nonVisualShapeProperties60);
            shape60.Append(shapeProperties110);
            shape60.Append(textBody60);

            Shape shape61 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties61 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties124 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Date Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties61 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks59 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties61.Append(shapeLocks59);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties124 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape59 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties124.Append(placeholderShape59);

            nonVisualShapeProperties61.Append(nonVisualDrawingProperties124);
            nonVisualShapeProperties61.Append(nonVisualShapeDrawingProperties61);
            nonVisualShapeProperties61.Append(applicationNonVisualDrawingProperties124);
            ShapeProperties shapeProperties111 = new ShapeProperties();

            TextBody textBody61 = new TextBody();
            A.BodyProperties bodyProperties61 = new A.BodyProperties();
            A.ListStyle listStyle61 = new A.ListStyle();

            A.Paragraph paragraph81 = new A.Paragraph();

            A.Field field23 = new A.Field(){ Id = "{CE1A2D98-1BBD-4706-A118-AAC2A16BEAD3}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties71 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties71.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text71 = new A.Text();
            text71.Text = "2012/10/3";

            field23.Append(runProperties71);
            field23.Append(text71);
            A.EndParagraphRunProperties endParagraphRunProperties55 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph81.Append(field23);
            paragraph81.Append(endParagraphRunProperties55);

            textBody61.Append(bodyProperties61);
            textBody61.Append(listStyle61);
            textBody61.Append(paragraph81);

            shape61.Append(nonVisualShapeProperties61);
            shape61.Append(shapeProperties111);
            shape61.Append(textBody61);

            Shape shape62 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties62 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties125 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Footer Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties62 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks60 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties62.Append(shapeLocks60);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties125 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape60 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties125.Append(placeholderShape60);

            nonVisualShapeProperties62.Append(nonVisualDrawingProperties125);
            nonVisualShapeProperties62.Append(nonVisualShapeDrawingProperties62);
            nonVisualShapeProperties62.Append(applicationNonVisualDrawingProperties125);
            ShapeProperties shapeProperties112 = new ShapeProperties();

            TextBody textBody62 = new TextBody();
            A.BodyProperties bodyProperties62 = new A.BodyProperties();
            A.ListStyle listStyle62 = new A.ListStyle();

            A.Paragraph paragraph82 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties56 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph82.Append(endParagraphRunProperties56);

            textBody62.Append(bodyProperties62);
            textBody62.Append(listStyle62);
            textBody62.Append(paragraph82);

            shape62.Append(nonVisualShapeProperties62);
            shape62.Append(shapeProperties112);
            shape62.Append(textBody62);

            Shape shape63 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties63 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties126 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Slide Number Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties63 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks61 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties63.Append(shapeLocks61);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties126 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape61 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties126.Append(placeholderShape61);

            nonVisualShapeProperties63.Append(nonVisualDrawingProperties126);
            nonVisualShapeProperties63.Append(nonVisualShapeDrawingProperties63);
            nonVisualShapeProperties63.Append(applicationNonVisualDrawingProperties126);
            ShapeProperties shapeProperties113 = new ShapeProperties();

            TextBody textBody63 = new TextBody();
            A.BodyProperties bodyProperties63 = new A.BodyProperties();
            A.ListStyle listStyle63 = new A.ListStyle();

            A.Paragraph paragraph83 = new A.Paragraph();

            A.Field field24 = new A.Field(){ Id = "{D107CD50-7081-433F-A1F2-156B4E14F4F4}", Type = "slidenum" };

            A.RunProperties runProperties72 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties72.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text72 = new A.Text();
            text72.Text = "‹#›";

            field24.Append(runProperties72);
            field24.Append(text72);
            A.EndParagraphRunProperties endParagraphRunProperties57 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph83.Append(field24);
            paragraph83.Append(endParagraphRunProperties57);

            textBody63.Append(bodyProperties63);
            textBody63.Append(listStyle63);
            textBody63.Append(paragraph83);

            shape63.Append(nonVisualShapeProperties63);
            shape63.Append(shapeProperties113);
            shape63.Append(textBody63);

            ConnectionShape connectionShape51 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties51 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties127 = new NonVisualDrawingProperties(){ Id = (UInt32Value)17U, Name = "Straight Connector 16" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties51 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties127 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties51.Append(nonVisualDrawingProperties127);
            nonVisualConnectionShapeProperties51.Append(nonVisualConnectorShapeDrawingProperties51);
            nonVisualConnectionShapeProperties51.Append(applicationNonVisualDrawingProperties127);

            ShapeProperties shapeProperties114 = new ShapeProperties();

            A.Transform2D transform2D74 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset87 = new A.Offset(){ X = 11278949L, Y = 2963333L };
            A.Extents extents87 = new A.Extents(){ Cx = 913052L, Cy = 912812L };

            transform2D74.Append(offset87);
            transform2D74.Append(extents87);

            A.PresetGeometry presetGeometry58 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList58 = new A.AdjustValueList();

            presetGeometry58.Append(adjustValueList58);

            A.Outline outline57 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill161 = new A.SolidFill();
            A.SchemeColor schemeColor377 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill161.Append(schemeColor377);

            outline57.Append(solidFill161);

            shapeProperties114.Append(transform2D74);
            shapeProperties114.Append(presetGeometry58);
            shapeProperties114.Append(outline57);

            ShapeStyle shapeStyle51 = new ShapeStyle();

            A.LineReference lineReference51 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor378 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference51.Append(schemeColor378);

            A.FillReference fillReference51 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor379 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference51.Append(schemeColor379);

            A.EffectReference effectReference51 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor380 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference51.Append(schemeColor380);

            A.FontReference fontReference51 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor381 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference51.Append(schemeColor381);

            shapeStyle51.Append(lineReference51);
            shapeStyle51.Append(fillReference51);
            shapeStyle51.Append(effectReference51);
            shapeStyle51.Append(fontReference51);

            connectionShape51.Append(nonVisualConnectionShapeProperties51);
            connectionShape51.Append(shapeProperties114);
            connectionShape51.Append(shapeStyle51);

            ConnectionShape connectionShape52 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties52 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties128 = new NonVisualDrawingProperties(){ Id = (UInt32Value)18U, Name = "Straight Connector 17" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties52 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties128 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties52.Append(nonVisualDrawingProperties128);
            nonVisualConnectionShapeProperties52.Append(nonVisualConnectorShapeDrawingProperties52);
            nonVisualConnectionShapeProperties52.Append(applicationNonVisualDrawingProperties128);

            ShapeProperties shapeProperties115 = new ShapeProperties();

            A.Transform2D transform2D75 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset88 = new A.Offset(){ X = 9209368L, Y = 3190344L };
            A.Extents extents88 = new A.Extents(){ Cx = 2982634L, Cy = 2981856L };

            transform2D75.Append(offset88);
            transform2D75.Append(extents88);

            A.PresetGeometry presetGeometry59 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList59 = new A.AdjustValueList();

            presetGeometry59.Append(adjustValueList59);

            A.Outline outline58 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill162 = new A.SolidFill();
            A.SchemeColor schemeColor382 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill162.Append(schemeColor382);

            outline58.Append(solidFill162);

            shapeProperties115.Append(transform2D75);
            shapeProperties115.Append(presetGeometry59);
            shapeProperties115.Append(outline58);

            ShapeStyle shapeStyle52 = new ShapeStyle();

            A.LineReference lineReference52 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor383 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference52.Append(schemeColor383);

            A.FillReference fillReference52 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor384 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference52.Append(schemeColor384);

            A.EffectReference effectReference52 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor385 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference52.Append(schemeColor385);

            A.FontReference fontReference52 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor386 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference52.Append(schemeColor386);

            shapeStyle52.Append(lineReference52);
            shapeStyle52.Append(fillReference52);
            shapeStyle52.Append(effectReference52);
            shapeStyle52.Append(fontReference52);

            connectionShape52.Append(nonVisualConnectionShapeProperties52);
            connectionShape52.Append(shapeProperties115);
            connectionShape52.Append(shapeStyle52);

            ConnectionShape connectionShape53 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties53 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties129 = new NonVisualDrawingProperties(){ Id = (UInt32Value)19U, Name = "Straight Connector 18" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties53 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties129 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties53.Append(nonVisualDrawingProperties129);
            nonVisualConnectionShapeProperties53.Append(nonVisualConnectorShapeDrawingProperties53);
            nonVisualConnectionShapeProperties53.Append(applicationNonVisualDrawingProperties129);

            ShapeProperties shapeProperties116 = new ShapeProperties();

            A.Transform2D transform2D76 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset89 = new A.Offset(){ X = 10294973L, Y = 3285068L };
            A.Extents extents89 = new A.Extents(){ Cx = 1897028L, Cy = 1896533L };

            transform2D76.Append(offset89);
            transform2D76.Append(extents89);

            A.PresetGeometry presetGeometry60 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList60 = new A.AdjustValueList();

            presetGeometry60.Append(adjustValueList60);

            A.Outline outline59 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill163 = new A.SolidFill();
            A.SchemeColor schemeColor387 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill163.Append(schemeColor387);

            outline59.Append(solidFill163);

            shapeProperties116.Append(transform2D76);
            shapeProperties116.Append(presetGeometry60);
            shapeProperties116.Append(outline59);

            ShapeStyle shapeStyle53 = new ShapeStyle();

            A.LineReference lineReference53 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor388 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference53.Append(schemeColor388);

            A.FillReference fillReference53 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor389 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference53.Append(schemeColor389);

            A.EffectReference effectReference53 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor390 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference53.Append(schemeColor390);

            A.FontReference fontReference53 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor391 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference53.Append(schemeColor391);

            shapeStyle53.Append(lineReference53);
            shapeStyle53.Append(fillReference53);
            shapeStyle53.Append(effectReference53);
            shapeStyle53.Append(fontReference53);

            connectionShape53.Append(nonVisualConnectionShapeProperties53);
            connectionShape53.Append(shapeProperties116);
            connectionShape53.Append(shapeStyle53);

            ConnectionShape connectionShape54 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties54 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties130 = new NonVisualDrawingProperties(){ Id = (UInt32Value)20U, Name = "Straight Connector 19" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties54 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties130 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties54.Append(nonVisualDrawingProperties130);
            nonVisualConnectionShapeProperties54.Append(nonVisualConnectorShapeDrawingProperties54);
            nonVisualConnectionShapeProperties54.Append(applicationNonVisualDrawingProperties130);

            ShapeProperties shapeProperties117 = new ShapeProperties();

            A.Transform2D transform2D77 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset90 = new A.Offset(){ X = 10445823L, Y = 3131080L };
            A.Extents extents90 = new A.Extents(){ Cx = 1746177L, Cy = 1745720L };

            transform2D77.Append(offset90);
            transform2D77.Append(extents90);

            A.PresetGeometry presetGeometry61 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList61 = new A.AdjustValueList();

            presetGeometry61.Append(adjustValueList61);

            A.Outline outline60 = new A.Outline(){ Width = 28575 };

            A.SolidFill solidFill164 = new A.SolidFill();
            A.SchemeColor schemeColor392 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill164.Append(schemeColor392);

            outline60.Append(solidFill164);

            shapeProperties117.Append(transform2D77);
            shapeProperties117.Append(presetGeometry61);
            shapeProperties117.Append(outline60);

            ShapeStyle shapeStyle54 = new ShapeStyle();

            A.LineReference lineReference54 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor393 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference54.Append(schemeColor393);

            A.FillReference fillReference54 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor394 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference54.Append(schemeColor394);

            A.EffectReference effectReference54 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor395 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference54.Append(schemeColor395);

            A.FontReference fontReference54 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor396 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference54.Append(schemeColor396);

            shapeStyle54.Append(lineReference54);
            shapeStyle54.Append(fillReference54);
            shapeStyle54.Append(effectReference54);
            shapeStyle54.Append(fontReference54);

            connectionShape54.Append(nonVisualConnectionShapeProperties54);
            connectionShape54.Append(shapeProperties117);
            connectionShape54.Append(shapeStyle54);

            ConnectionShape connectionShape55 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties55 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties131 = new NonVisualDrawingProperties(){ Id = (UInt32Value)21U, Name = "Straight Connector 20" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties55 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties131 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties55.Append(nonVisualDrawingProperties131);
            nonVisualConnectionShapeProperties55.Append(nonVisualConnectorShapeDrawingProperties55);
            nonVisualConnectionShapeProperties55.Append(applicationNonVisualDrawingProperties131);

            ShapeProperties shapeProperties118 = new ShapeProperties();

            A.Transform2D transform2D78 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset91 = new A.Offset(){ X = 10921671L, Y = 3683002L };
            A.Extents extents91 = new A.Extents(){ Cx = 1270332L, Cy = 1269999L };

            transform2D78.Append(offset91);
            transform2D78.Append(extents91);

            A.PresetGeometry presetGeometry62 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList62 = new A.AdjustValueList();

            presetGeometry62.Append(adjustValueList62);

            A.Outline outline61 = new A.Outline(){ Width = 28575 };

            A.SolidFill solidFill165 = new A.SolidFill();
            A.SchemeColor schemeColor397 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill165.Append(schemeColor397);

            outline61.Append(solidFill165);

            shapeProperties118.Append(transform2D78);
            shapeProperties118.Append(presetGeometry62);
            shapeProperties118.Append(outline61);

            ShapeStyle shapeStyle55 = new ShapeStyle();

            A.LineReference lineReference55 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor398 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference55.Append(schemeColor398);

            A.FillReference fillReference55 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor399 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference55.Append(schemeColor399);

            A.EffectReference effectReference55 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor400 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference55.Append(schemeColor400);

            A.FontReference fontReference55 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor401 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference55.Append(schemeColor401);

            shapeStyle55.Append(lineReference55);
            shapeStyle55.Append(fillReference55);
            shapeStyle55.Append(effectReference55);
            shapeStyle55.Append(fontReference55);

            connectionShape55.Append(nonVisualConnectionShapeProperties55);
            connectionShape55.Append(shapeProperties118);
            connectionShape55.Append(shapeStyle55);

            shapeTree13.Append(nonVisualGroupShapeProperties13);
            shapeTree13.Append(groupShapeProperties13);
            shapeTree13.Append(shape59);
            shapeTree13.Append(shape60);
            shapeTree13.Append(shape61);
            shapeTree13.Append(shape62);
            shapeTree13.Append(shape63);
            shapeTree13.Append(connectionShape51);
            shapeTree13.Append(connectionShape52);
            shapeTree13.Append(connectionShape53);
            shapeTree13.Append(connectionShape54);
            shapeTree13.Append(connectionShape55);

            CommonSlideDataExtensionList commonSlideDataExtensionList13 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension13 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId13 = new P14.CreationId(){ Val = (UInt32Value)940985444U };
            creationId13.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension13.Append(creationId13);

            commonSlideDataExtensionList13.Append(commonSlideDataExtension13);

            commonSlideData13.Append(shapeTree13);
            commonSlideData13.Append(commonSlideDataExtensionList13);

            ColorMapOverride colorMapOverride12 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping12 = new A.MasterColorMapping();

            colorMapOverride12.Append(masterColorMapping12);

            Timing timing13 = new Timing();

            TimeNodeList timeNodeList13 = new TimeNodeList();

            ParallelTimeNode parallelTimeNode13 = new ParallelTimeNode();
            CommonTimeNode commonTimeNode13 = new CommonTimeNode(){ Id = (UInt32Value)1U, Duration = "indefinite", Restart = TimeNodeRestartValues.Never, NodeType = TimeNodeValues.TmingRoot };

            parallelTimeNode13.Append(commonTimeNode13);

            timeNodeList13.Append(parallelTimeNode13);

            timing13.Append(timeNodeList13);

            slideLayout11.Append(commonSlideData13);
            slideLayout11.Append(colorMapOverride12);
            slideLayout11.Append(timing13);

            slideLayoutPart11.SlideLayout = slideLayout11;
        }

        // Generates content of slideLayoutPart12.
        private void GenerateSlideLayoutPart12Content(SlideLayoutPart slideLayoutPart12)
        {
            SlideLayout slideLayout12 = new SlideLayout(){ Type = SlideLayoutValues.TwoTextAndTwoObjects, Preserve = true };
            slideLayout12.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout12.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout12.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData14 = new CommonSlideData(){ Name = "Comparison" };

            ShapeTree shapeTree14 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties14 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties132 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties14 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties132 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties14.Append(nonVisualDrawingProperties132);
            nonVisualGroupShapeProperties14.Append(nonVisualGroupShapeDrawingProperties14);
            nonVisualGroupShapeProperties14.Append(applicationNonVisualDrawingProperties132);

            GroupShapeProperties groupShapeProperties14 = new GroupShapeProperties();

            A.TransformGroup transformGroup14 = new A.TransformGroup();
            A.Offset offset92 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents92 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset14 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents14 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup14.Append(offset92);
            transformGroup14.Append(extents92);
            transformGroup14.Append(childOffset14);
            transformGroup14.Append(childExtents14);

            groupShapeProperties14.Append(transformGroup14);

            Shape shape64 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties64 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties133 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties64 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks62 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties64.Append(shapeLocks62);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties133 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape62 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties133.Append(placeholderShape62);

            nonVisualShapeProperties64.Append(nonVisualDrawingProperties133);
            nonVisualShapeProperties64.Append(nonVisualShapeDrawingProperties64);
            nonVisualShapeProperties64.Append(applicationNonVisualDrawingProperties133);
            ShapeProperties shapeProperties119 = new ShapeProperties();

            TextBody textBody64 = new TextBody();
            A.BodyProperties bodyProperties64 = new A.BodyProperties();

            A.ListStyle listStyle64 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties26 = new A.Level1ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties140 = new A.DefaultRunProperties();

            level1ParagraphProperties26.Append(defaultRunProperties140);

            listStyle64.Append(level1ParagraphProperties26);

            A.Paragraph paragraph84 = new A.Paragraph();

            A.Run run49 = new A.Run();

            A.RunProperties runProperties73 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties73.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text73 = new A.Text();
            text73.Text = "Click to edit Master title style";

            run49.Append(runProperties73);
            run49.Append(text73);
            A.EndParagraphRunProperties endParagraphRunProperties58 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph84.Append(run49);
            paragraph84.Append(endParagraphRunProperties58);

            textBody64.Append(bodyProperties64);
            textBody64.Append(listStyle64);
            textBody64.Append(paragraph84);

            shape64.Append(nonVisualShapeProperties64);
            shape64.Append(shapeProperties119);
            shape64.Append(textBody64);

            Shape shape65 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties65 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties134 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Text Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties65 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks63 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties65.Append(shapeLocks63);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties134 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape63 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties134.Append(placeholderShape63);

            nonVisualShapeProperties65.Append(nonVisualDrawingProperties134);
            nonVisualShapeProperties65.Append(nonVisualShapeDrawingProperties65);
            nonVisualShapeProperties65.Append(applicationNonVisualDrawingProperties134);

            ShapeProperties shapeProperties120 = new ShapeProperties();

            A.Transform2D transform2D79 = new A.Transform2D();
            A.Offset offset93 = new A.Offset(){ X = 972334L, Y = 685800L };
            A.Extents extents93 = new A.Extents(){ Cx = 4650998L, Cy = 576262L };

            transform2D79.Append(offset93);
            transform2D79.Append(extents93);

            shapeProperties120.Append(transform2D79);

            TextBody textBody65 = new TextBody();

            A.BodyProperties bodyProperties65 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Bottom };
            A.NoAutoFit noAutoFit3 = new A.NoAutoFit();

            bodyProperties65.Append(noAutoFit3);

            A.ListStyle listStyle65 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties27 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0 };
            A.NoBullet noBullet63 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties141 = new A.DefaultRunProperties(){ FontSize = 2800, Bold = false };

            A.SolidFill solidFill166 = new A.SolidFill();
            A.SchemeColor schemeColor402 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill166.Append(schemeColor402);

            defaultRunProperties141.Append(solidFill166);

            level1ParagraphProperties27.Append(noBullet63);
            level1ParagraphProperties27.Append(defaultRunProperties141);

            A.Level2ParagraphProperties level2ParagraphProperties16 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Indent = 0 };
            A.NoBullet noBullet64 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties142 = new A.DefaultRunProperties(){ FontSize = 2000, Bold = true };

            level2ParagraphProperties16.Append(noBullet64);
            level2ParagraphProperties16.Append(defaultRunProperties142);

            A.Level3ParagraphProperties level3ParagraphProperties16 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Indent = 0 };
            A.NoBullet noBullet65 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties143 = new A.DefaultRunProperties(){ FontSize = 1800, Bold = true };

            level3ParagraphProperties16.Append(noBullet65);
            level3ParagraphProperties16.Append(defaultRunProperties143);

            A.Level4ParagraphProperties level4ParagraphProperties16 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Indent = 0 };
            A.NoBullet noBullet66 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties144 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level4ParagraphProperties16.Append(noBullet66);
            level4ParagraphProperties16.Append(defaultRunProperties144);

            A.Level5ParagraphProperties level5ParagraphProperties16 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Indent = 0 };
            A.NoBullet noBullet67 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties145 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level5ParagraphProperties16.Append(noBullet67);
            level5ParagraphProperties16.Append(defaultRunProperties145);

            A.Level6ParagraphProperties level6ParagraphProperties14 = new A.Level6ParagraphProperties(){ LeftMargin = 2286000, Indent = 0 };
            A.NoBullet noBullet68 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties146 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level6ParagraphProperties14.Append(noBullet68);
            level6ParagraphProperties14.Append(defaultRunProperties146);

            A.Level7ParagraphProperties level7ParagraphProperties14 = new A.Level7ParagraphProperties(){ LeftMargin = 2743200, Indent = 0 };
            A.NoBullet noBullet69 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties147 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level7ParagraphProperties14.Append(noBullet69);
            level7ParagraphProperties14.Append(defaultRunProperties147);

            A.Level8ParagraphProperties level8ParagraphProperties14 = new A.Level8ParagraphProperties(){ LeftMargin = 3200400, Indent = 0 };
            A.NoBullet noBullet70 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties148 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level8ParagraphProperties14.Append(noBullet70);
            level8ParagraphProperties14.Append(defaultRunProperties148);

            A.Level9ParagraphProperties level9ParagraphProperties14 = new A.Level9ParagraphProperties(){ LeftMargin = 3657600, Indent = 0 };
            A.NoBullet noBullet71 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties149 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level9ParagraphProperties14.Append(noBullet71);
            level9ParagraphProperties14.Append(defaultRunProperties149);

            listStyle65.Append(level1ParagraphProperties27);
            listStyle65.Append(level2ParagraphProperties16);
            listStyle65.Append(level3ParagraphProperties16);
            listStyle65.Append(level4ParagraphProperties16);
            listStyle65.Append(level5ParagraphProperties16);
            listStyle65.Append(level6ParagraphProperties14);
            listStyle65.Append(level7ParagraphProperties14);
            listStyle65.Append(level8ParagraphProperties14);
            listStyle65.Append(level9ParagraphProperties14);

            A.Paragraph paragraph85 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties34 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run50 = new A.Run();

            A.RunProperties runProperties74 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties74.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text74 = new A.Text();
            text74.Text = "Click to edit Master text styles";

            run50.Append(runProperties74);
            run50.Append(text74);

            paragraph85.Append(paragraphProperties34);
            paragraph85.Append(run50);

            textBody65.Append(bodyProperties65);
            textBody65.Append(listStyle65);
            textBody65.Append(paragraph85);

            shape65.Append(nonVisualShapeProperties65);
            shape65.Append(shapeProperties120);
            shape65.Append(textBody65);

            Shape shape66 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties66 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties135 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Content Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties66 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks64 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties66.Append(shapeLocks64);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties135 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape64 = new PlaceholderShape(){ Size = PlaceholderSizeValues.Half, Index = (UInt32Value)2U };

            applicationNonVisualDrawingProperties135.Append(placeholderShape64);

            nonVisualShapeProperties66.Append(nonVisualDrawingProperties135);
            nonVisualShapeProperties66.Append(nonVisualShapeDrawingProperties66);
            nonVisualShapeProperties66.Append(applicationNonVisualDrawingProperties135);

            ShapeProperties shapeProperties121 = new ShapeProperties();

            A.Transform2D transform2D80 = new A.Transform2D();
            A.Offset offset94 = new A.Offset(){ X = 684390L, Y = 1270529L };
            A.Extents extents94 = new A.Extents(){ Cx = 4938941L, Cy = 3030538L };

            transform2D80.Append(offset94);
            transform2D80.Append(extents94);

            shapeProperties121.Append(transform2D80);

            TextBody textBody66 = new TextBody();

            A.BodyProperties bodyProperties66 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Top };
            A.NormalAutoFit normalAutoFit16 = new A.NormalAutoFit();

            bodyProperties66.Append(normalAutoFit16);

            A.ListStyle listStyle66 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties28 = new A.Level1ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties150 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level1ParagraphProperties28.Append(defaultRunProperties150);

            A.Level2ParagraphProperties level2ParagraphProperties17 = new A.Level2ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties151 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level2ParagraphProperties17.Append(defaultRunProperties151);

            A.Level3ParagraphProperties level3ParagraphProperties17 = new A.Level3ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties152 = new A.DefaultRunProperties(){ FontSize = 1400 };

            level3ParagraphProperties17.Append(defaultRunProperties152);

            A.Level4ParagraphProperties level4ParagraphProperties17 = new A.Level4ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties153 = new A.DefaultRunProperties(){ FontSize = 1200 };

            level4ParagraphProperties17.Append(defaultRunProperties153);

            A.Level5ParagraphProperties level5ParagraphProperties17 = new A.Level5ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties154 = new A.DefaultRunProperties(){ FontSize = 1200 };

            level5ParagraphProperties17.Append(defaultRunProperties154);

            A.Level6ParagraphProperties level6ParagraphProperties15 = new A.Level6ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties155 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level6ParagraphProperties15.Append(defaultRunProperties155);

            A.Level7ParagraphProperties level7ParagraphProperties15 = new A.Level7ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties156 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level7ParagraphProperties15.Append(defaultRunProperties156);

            A.Level8ParagraphProperties level8ParagraphProperties15 = new A.Level8ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties157 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level8ParagraphProperties15.Append(defaultRunProperties157);

            A.Level9ParagraphProperties level9ParagraphProperties15 = new A.Level9ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties158 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level9ParagraphProperties15.Append(defaultRunProperties158);

            listStyle66.Append(level1ParagraphProperties28);
            listStyle66.Append(level2ParagraphProperties17);
            listStyle66.Append(level3ParagraphProperties17);
            listStyle66.Append(level4ParagraphProperties17);
            listStyle66.Append(level5ParagraphProperties17);
            listStyle66.Append(level6ParagraphProperties15);
            listStyle66.Append(level7ParagraphProperties15);
            listStyle66.Append(level8ParagraphProperties15);
            listStyle66.Append(level9ParagraphProperties15);

            A.Paragraph paragraph86 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties35 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run51 = new A.Run();

            A.RunProperties runProperties75 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties75.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text75 = new A.Text();
            text75.Text = "Click to edit Master text styles";

            run51.Append(runProperties75);
            run51.Append(text75);

            paragraph86.Append(paragraphProperties35);
            paragraph86.Append(run51);

            A.Paragraph paragraph87 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties36 = new A.ParagraphProperties(){ Level = 1 };

            A.Run run52 = new A.Run();

            A.RunProperties runProperties76 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties76.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text76 = new A.Text();
            text76.Text = "Second level";

            run52.Append(runProperties76);
            run52.Append(text76);

            paragraph87.Append(paragraphProperties36);
            paragraph87.Append(run52);

            A.Paragraph paragraph88 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties37 = new A.ParagraphProperties(){ Level = 2 };

            A.Run run53 = new A.Run();

            A.RunProperties runProperties77 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties77.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text77 = new A.Text();
            text77.Text = "Third level";

            run53.Append(runProperties77);
            run53.Append(text77);

            paragraph88.Append(paragraphProperties37);
            paragraph88.Append(run53);

            A.Paragraph paragraph89 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties38 = new A.ParagraphProperties(){ Level = 3 };

            A.Run run54 = new A.Run();

            A.RunProperties runProperties78 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties78.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text78 = new A.Text();
            text78.Text = "Fourth level";

            run54.Append(runProperties78);
            run54.Append(text78);

            paragraph89.Append(paragraphProperties38);
            paragraph89.Append(run54);

            A.Paragraph paragraph90 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties39 = new A.ParagraphProperties(){ Level = 4 };

            A.Run run55 = new A.Run();

            A.RunProperties runProperties79 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties79.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text79 = new A.Text();
            text79.Text = "Fifth level";

            run55.Append(runProperties79);
            run55.Append(text79);
            A.EndParagraphRunProperties endParagraphRunProperties59 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph90.Append(paragraphProperties39);
            paragraph90.Append(run55);
            paragraph90.Append(endParagraphRunProperties59);

            textBody66.Append(bodyProperties66);
            textBody66.Append(listStyle66);
            textBody66.Append(paragraph86);
            textBody66.Append(paragraph87);
            textBody66.Append(paragraph88);
            textBody66.Append(paragraph89);
            textBody66.Append(paragraph90);

            shape66.Append(nonVisualShapeProperties66);
            shape66.Append(shapeProperties121);
            shape66.Append(textBody66);

            Shape shape67 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties67 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties136 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Text Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties67 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks65 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties67.Append(shapeLocks65);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties136 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape65 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)3U };

            applicationNonVisualDrawingProperties136.Append(placeholderShape65);

            nonVisualShapeProperties67.Append(nonVisualDrawingProperties136);
            nonVisualShapeProperties67.Append(nonVisualShapeDrawingProperties67);
            nonVisualShapeProperties67.Append(applicationNonVisualDrawingProperties136);

            ShapeProperties shapeProperties122 = new ShapeProperties();

            A.Transform2D transform2D81 = new A.Transform2D();
            A.Offset offset95 = new A.Offset(){ X = 6080650L, Y = 685800L };
            A.Extents extents95 = new A.Extents(){ Cx = 4666349L, Cy = 576262L };

            transform2D81.Append(offset95);
            transform2D81.Append(extents95);

            shapeProperties122.Append(transform2D81);

            TextBody textBody67 = new TextBody();

            A.BodyProperties bodyProperties67 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Bottom };
            A.NoAutoFit noAutoFit4 = new A.NoAutoFit();

            bodyProperties67.Append(noAutoFit4);

            A.ListStyle listStyle67 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties29 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0 };
            A.NoBullet noBullet72 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties159 = new A.DefaultRunProperties(){ FontSize = 2800, Bold = false };

            A.SolidFill solidFill167 = new A.SolidFill();
            A.SchemeColor schemeColor403 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill167.Append(schemeColor403);

            defaultRunProperties159.Append(solidFill167);

            level1ParagraphProperties29.Append(noBullet72);
            level1ParagraphProperties29.Append(defaultRunProperties159);

            A.Level2ParagraphProperties level2ParagraphProperties18 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Indent = 0 };
            A.NoBullet noBullet73 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties160 = new A.DefaultRunProperties(){ FontSize = 2000, Bold = true };

            level2ParagraphProperties18.Append(noBullet73);
            level2ParagraphProperties18.Append(defaultRunProperties160);

            A.Level3ParagraphProperties level3ParagraphProperties18 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Indent = 0 };
            A.NoBullet noBullet74 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties161 = new A.DefaultRunProperties(){ FontSize = 1800, Bold = true };

            level3ParagraphProperties18.Append(noBullet74);
            level3ParagraphProperties18.Append(defaultRunProperties161);

            A.Level4ParagraphProperties level4ParagraphProperties18 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Indent = 0 };
            A.NoBullet noBullet75 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties162 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level4ParagraphProperties18.Append(noBullet75);
            level4ParagraphProperties18.Append(defaultRunProperties162);

            A.Level5ParagraphProperties level5ParagraphProperties18 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Indent = 0 };
            A.NoBullet noBullet76 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties163 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level5ParagraphProperties18.Append(noBullet76);
            level5ParagraphProperties18.Append(defaultRunProperties163);

            A.Level6ParagraphProperties level6ParagraphProperties16 = new A.Level6ParagraphProperties(){ LeftMargin = 2286000, Indent = 0 };
            A.NoBullet noBullet77 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties164 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level6ParagraphProperties16.Append(noBullet77);
            level6ParagraphProperties16.Append(defaultRunProperties164);

            A.Level7ParagraphProperties level7ParagraphProperties16 = new A.Level7ParagraphProperties(){ LeftMargin = 2743200, Indent = 0 };
            A.NoBullet noBullet78 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties165 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level7ParagraphProperties16.Append(noBullet78);
            level7ParagraphProperties16.Append(defaultRunProperties165);

            A.Level8ParagraphProperties level8ParagraphProperties16 = new A.Level8ParagraphProperties(){ LeftMargin = 3200400, Indent = 0 };
            A.NoBullet noBullet79 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties166 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level8ParagraphProperties16.Append(noBullet79);
            level8ParagraphProperties16.Append(defaultRunProperties166);

            A.Level9ParagraphProperties level9ParagraphProperties16 = new A.Level9ParagraphProperties(){ LeftMargin = 3657600, Indent = 0 };
            A.NoBullet noBullet80 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties167 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level9ParagraphProperties16.Append(noBullet80);
            level9ParagraphProperties16.Append(defaultRunProperties167);

            listStyle67.Append(level1ParagraphProperties29);
            listStyle67.Append(level2ParagraphProperties18);
            listStyle67.Append(level3ParagraphProperties18);
            listStyle67.Append(level4ParagraphProperties18);
            listStyle67.Append(level5ParagraphProperties18);
            listStyle67.Append(level6ParagraphProperties16);
            listStyle67.Append(level7ParagraphProperties16);
            listStyle67.Append(level8ParagraphProperties16);
            listStyle67.Append(level9ParagraphProperties16);

            A.Paragraph paragraph91 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties40 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run56 = new A.Run();

            A.RunProperties runProperties80 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties80.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text80 = new A.Text();
            text80.Text = "Click to edit Master text styles";

            run56.Append(runProperties80);
            run56.Append(text80);

            paragraph91.Append(paragraphProperties40);
            paragraph91.Append(run56);

            textBody67.Append(bodyProperties67);
            textBody67.Append(listStyle67);
            textBody67.Append(paragraph91);

            shape67.Append(nonVisualShapeProperties67);
            shape67.Append(shapeProperties122);
            shape67.Append(textBody67);

            Shape shape68 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties68 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties137 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Content Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties68 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks66 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties68.Append(shapeLocks66);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties137 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape66 = new PlaceholderShape(){ Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)4U };

            applicationNonVisualDrawingProperties137.Append(placeholderShape66);

            nonVisualShapeProperties68.Append(nonVisualDrawingProperties137);
            nonVisualShapeProperties68.Append(nonVisualShapeDrawingProperties68);
            nonVisualShapeProperties68.Append(applicationNonVisualDrawingProperties137);

            ShapeProperties shapeProperties123 = new ShapeProperties();

            A.Transform2D transform2D82 = new A.Transform2D();
            A.Offset offset96 = new A.Offset(){ X = 5808058L, Y = 1262062L };
            A.Extents extents96 = new A.Extents(){ Cx = 4930472L, Cy = 3030538L };

            transform2D82.Append(offset96);
            transform2D82.Append(extents96);

            shapeProperties123.Append(transform2D82);

            TextBody textBody68 = new TextBody();

            A.BodyProperties bodyProperties68 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Top };
            A.NormalAutoFit normalAutoFit17 = new A.NormalAutoFit();

            bodyProperties68.Append(normalAutoFit17);

            A.ListStyle listStyle68 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties30 = new A.Level1ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties168 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level1ParagraphProperties30.Append(defaultRunProperties168);

            A.Level2ParagraphProperties level2ParagraphProperties19 = new A.Level2ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties169 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level2ParagraphProperties19.Append(defaultRunProperties169);

            A.Level3ParagraphProperties level3ParagraphProperties19 = new A.Level3ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties170 = new A.DefaultRunProperties(){ FontSize = 1400 };

            level3ParagraphProperties19.Append(defaultRunProperties170);

            A.Level4ParagraphProperties level4ParagraphProperties19 = new A.Level4ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties171 = new A.DefaultRunProperties(){ FontSize = 1200 };

            level4ParagraphProperties19.Append(defaultRunProperties171);

            A.Level5ParagraphProperties level5ParagraphProperties19 = new A.Level5ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties172 = new A.DefaultRunProperties(){ FontSize = 1200 };

            level5ParagraphProperties19.Append(defaultRunProperties172);

            A.Level6ParagraphProperties level6ParagraphProperties17 = new A.Level6ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties173 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level6ParagraphProperties17.Append(defaultRunProperties173);

            A.Level7ParagraphProperties level7ParagraphProperties17 = new A.Level7ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties174 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level7ParagraphProperties17.Append(defaultRunProperties174);

            A.Level8ParagraphProperties level8ParagraphProperties17 = new A.Level8ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties175 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level8ParagraphProperties17.Append(defaultRunProperties175);

            A.Level9ParagraphProperties level9ParagraphProperties17 = new A.Level9ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties176 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level9ParagraphProperties17.Append(defaultRunProperties176);

            listStyle68.Append(level1ParagraphProperties30);
            listStyle68.Append(level2ParagraphProperties19);
            listStyle68.Append(level3ParagraphProperties19);
            listStyle68.Append(level4ParagraphProperties19);
            listStyle68.Append(level5ParagraphProperties19);
            listStyle68.Append(level6ParagraphProperties17);
            listStyle68.Append(level7ParagraphProperties17);
            listStyle68.Append(level8ParagraphProperties17);
            listStyle68.Append(level9ParagraphProperties17);

            A.Paragraph paragraph92 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties41 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run57 = new A.Run();

            A.RunProperties runProperties81 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties81.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text81 = new A.Text();
            text81.Text = "Click to edit Master text styles";

            run57.Append(runProperties81);
            run57.Append(text81);

            paragraph92.Append(paragraphProperties41);
            paragraph92.Append(run57);

            A.Paragraph paragraph93 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties42 = new A.ParagraphProperties(){ Level = 1 };

            A.Run run58 = new A.Run();

            A.RunProperties runProperties82 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties82.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text82 = new A.Text();
            text82.Text = "Second level";

            run58.Append(runProperties82);
            run58.Append(text82);

            paragraph93.Append(paragraphProperties42);
            paragraph93.Append(run58);

            A.Paragraph paragraph94 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties43 = new A.ParagraphProperties(){ Level = 2 };

            A.Run run59 = new A.Run();

            A.RunProperties runProperties83 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties83.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text83 = new A.Text();
            text83.Text = "Third level";

            run59.Append(runProperties83);
            run59.Append(text83);

            paragraph94.Append(paragraphProperties43);
            paragraph94.Append(run59);

            A.Paragraph paragraph95 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties44 = new A.ParagraphProperties(){ Level = 3 };

            A.Run run60 = new A.Run();

            A.RunProperties runProperties84 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties84.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text84 = new A.Text();
            text84.Text = "Fourth level";

            run60.Append(runProperties84);
            run60.Append(text84);

            paragraph95.Append(paragraphProperties44);
            paragraph95.Append(run60);

            A.Paragraph paragraph96 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties45 = new A.ParagraphProperties(){ Level = 4 };

            A.Run run61 = new A.Run();

            A.RunProperties runProperties85 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties85.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text85 = new A.Text();
            text85.Text = "Fifth level";

            run61.Append(runProperties85);
            run61.Append(text85);
            A.EndParagraphRunProperties endParagraphRunProperties60 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph96.Append(paragraphProperties45);
            paragraph96.Append(run61);
            paragraph96.Append(endParagraphRunProperties60);

            textBody68.Append(bodyProperties68);
            textBody68.Append(listStyle68);
            textBody68.Append(paragraph92);
            textBody68.Append(paragraph93);
            textBody68.Append(paragraph94);
            textBody68.Append(paragraph95);
            textBody68.Append(paragraph96);

            shape68.Append(nonVisualShapeProperties68);
            shape68.Append(shapeProperties123);
            shape68.Append(textBody68);

            Shape shape69 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties69 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties138 = new NonVisualDrawingProperties(){ Id = (UInt32Value)7U, Name = "Date Placeholder 6" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties69 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks67 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties69.Append(shapeLocks67);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties138 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape67 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties138.Append(placeholderShape67);

            nonVisualShapeProperties69.Append(nonVisualDrawingProperties138);
            nonVisualShapeProperties69.Append(nonVisualShapeDrawingProperties69);
            nonVisualShapeProperties69.Append(applicationNonVisualDrawingProperties138);
            ShapeProperties shapeProperties124 = new ShapeProperties();

            TextBody textBody69 = new TextBody();
            A.BodyProperties bodyProperties69 = new A.BodyProperties();
            A.ListStyle listStyle69 = new A.ListStyle();

            A.Paragraph paragraph97 = new A.Paragraph();

            A.Field field25 = new A.Field(){ Id = "{CE1A2D98-1BBD-4706-A118-AAC2A16BEAD3}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties86 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties86.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text86 = new A.Text();
            text86.Text = "2012/10/3";

            field25.Append(runProperties86);
            field25.Append(text86);
            A.EndParagraphRunProperties endParagraphRunProperties61 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph97.Append(field25);
            paragraph97.Append(endParagraphRunProperties61);

            textBody69.Append(bodyProperties69);
            textBody69.Append(listStyle69);
            textBody69.Append(paragraph97);

            shape69.Append(nonVisualShapeProperties69);
            shape69.Append(shapeProperties124);
            shape69.Append(textBody69);

            Shape shape70 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties70 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties139 = new NonVisualDrawingProperties(){ Id = (UInt32Value)8U, Name = "Footer Placeholder 7" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties70 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks68 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties70.Append(shapeLocks68);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties139 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape68 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties139.Append(placeholderShape68);

            nonVisualShapeProperties70.Append(nonVisualDrawingProperties139);
            nonVisualShapeProperties70.Append(nonVisualShapeDrawingProperties70);
            nonVisualShapeProperties70.Append(applicationNonVisualDrawingProperties139);
            ShapeProperties shapeProperties125 = new ShapeProperties();

            TextBody textBody70 = new TextBody();
            A.BodyProperties bodyProperties70 = new A.BodyProperties();
            A.ListStyle listStyle70 = new A.ListStyle();

            A.Paragraph paragraph98 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties62 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph98.Append(endParagraphRunProperties62);

            textBody70.Append(bodyProperties70);
            textBody70.Append(listStyle70);
            textBody70.Append(paragraph98);

            shape70.Append(nonVisualShapeProperties70);
            shape70.Append(shapeProperties125);
            shape70.Append(textBody70);

            Shape shape71 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties71 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties140 = new NonVisualDrawingProperties(){ Id = (UInt32Value)9U, Name = "Slide Number Placeholder 8" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties71 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks69 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties71.Append(shapeLocks69);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties140 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape69 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties140.Append(placeholderShape69);

            nonVisualShapeProperties71.Append(nonVisualDrawingProperties140);
            nonVisualShapeProperties71.Append(nonVisualShapeDrawingProperties71);
            nonVisualShapeProperties71.Append(applicationNonVisualDrawingProperties140);
            ShapeProperties shapeProperties126 = new ShapeProperties();

            TextBody textBody71 = new TextBody();
            A.BodyProperties bodyProperties71 = new A.BodyProperties();
            A.ListStyle listStyle71 = new A.ListStyle();

            A.Paragraph paragraph99 = new A.Paragraph();

            A.Field field26 = new A.Field(){ Id = "{D107CD50-7081-433F-A1F2-156B4E14F4F4}", Type = "slidenum" };

            A.RunProperties runProperties87 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties87.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text87 = new A.Text();
            text87.Text = "‹#›";

            field26.Append(runProperties87);
            field26.Append(text87);
            A.EndParagraphRunProperties endParagraphRunProperties63 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph99.Append(field26);
            paragraph99.Append(endParagraphRunProperties63);

            textBody71.Append(bodyProperties71);
            textBody71.Append(listStyle71);
            textBody71.Append(paragraph99);

            shape71.Append(nonVisualShapeProperties71);
            shape71.Append(shapeProperties126);
            shape71.Append(textBody71);

            ConnectionShape connectionShape56 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties56 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties141 = new NonVisualDrawingProperties(){ Id = (UInt32Value)10U, Name = "Straight Connector 9" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties56 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties141 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties56.Append(nonVisualDrawingProperties141);
            nonVisualConnectionShapeProperties56.Append(nonVisualConnectorShapeDrawingProperties56);
            nonVisualConnectionShapeProperties56.Append(applicationNonVisualDrawingProperties141);

            ShapeProperties shapeProperties127 = new ShapeProperties();

            A.Transform2D transform2D83 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset97 = new A.Offset(){ X = 11278949L, Y = 2963333L };
            A.Extents extents97 = new A.Extents(){ Cx = 913052L, Cy = 912812L };

            transform2D83.Append(offset97);
            transform2D83.Append(extents97);

            A.PresetGeometry presetGeometry63 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList63 = new A.AdjustValueList();

            presetGeometry63.Append(adjustValueList63);

            A.Outline outline62 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill168 = new A.SolidFill();
            A.SchemeColor schemeColor404 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill168.Append(schemeColor404);

            outline62.Append(solidFill168);

            shapeProperties127.Append(transform2D83);
            shapeProperties127.Append(presetGeometry63);
            shapeProperties127.Append(outline62);

            ShapeStyle shapeStyle56 = new ShapeStyle();

            A.LineReference lineReference56 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor405 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference56.Append(schemeColor405);

            A.FillReference fillReference56 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor406 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference56.Append(schemeColor406);

            A.EffectReference effectReference56 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor407 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference56.Append(schemeColor407);

            A.FontReference fontReference56 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor408 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference56.Append(schemeColor408);

            shapeStyle56.Append(lineReference56);
            shapeStyle56.Append(fillReference56);
            shapeStyle56.Append(effectReference56);
            shapeStyle56.Append(fontReference56);

            connectionShape56.Append(nonVisualConnectionShapeProperties56);
            connectionShape56.Append(shapeProperties127);
            connectionShape56.Append(shapeStyle56);

            ConnectionShape connectionShape57 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties57 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties142 = new NonVisualDrawingProperties(){ Id = (UInt32Value)11U, Name = "Straight Connector 10" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties57 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties142 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties57.Append(nonVisualDrawingProperties142);
            nonVisualConnectionShapeProperties57.Append(nonVisualConnectorShapeDrawingProperties57);
            nonVisualConnectionShapeProperties57.Append(applicationNonVisualDrawingProperties142);

            ShapeProperties shapeProperties128 = new ShapeProperties();

            A.Transform2D transform2D84 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset98 = new A.Offset(){ X = 9209368L, Y = 3190344L };
            A.Extents extents98 = new A.Extents(){ Cx = 2982634L, Cy = 2981856L };

            transform2D84.Append(offset98);
            transform2D84.Append(extents98);

            A.PresetGeometry presetGeometry64 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList64 = new A.AdjustValueList();

            presetGeometry64.Append(adjustValueList64);

            A.Outline outline63 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill169 = new A.SolidFill();
            A.SchemeColor schemeColor409 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill169.Append(schemeColor409);

            outline63.Append(solidFill169);

            shapeProperties128.Append(transform2D84);
            shapeProperties128.Append(presetGeometry64);
            shapeProperties128.Append(outline63);

            ShapeStyle shapeStyle57 = new ShapeStyle();

            A.LineReference lineReference57 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor410 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference57.Append(schemeColor410);

            A.FillReference fillReference57 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor411 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference57.Append(schemeColor411);

            A.EffectReference effectReference57 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor412 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference57.Append(schemeColor412);

            A.FontReference fontReference57 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor413 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference57.Append(schemeColor413);

            shapeStyle57.Append(lineReference57);
            shapeStyle57.Append(fillReference57);
            shapeStyle57.Append(effectReference57);
            shapeStyle57.Append(fontReference57);

            connectionShape57.Append(nonVisualConnectionShapeProperties57);
            connectionShape57.Append(shapeProperties128);
            connectionShape57.Append(shapeStyle57);

            ConnectionShape connectionShape58 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties58 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties143 = new NonVisualDrawingProperties(){ Id = (UInt32Value)12U, Name = "Straight Connector 11" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties58 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties143 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties58.Append(nonVisualDrawingProperties143);
            nonVisualConnectionShapeProperties58.Append(nonVisualConnectorShapeDrawingProperties58);
            nonVisualConnectionShapeProperties58.Append(applicationNonVisualDrawingProperties143);

            ShapeProperties shapeProperties129 = new ShapeProperties();

            A.Transform2D transform2D85 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset99 = new A.Offset(){ X = 10294973L, Y = 3285068L };
            A.Extents extents99 = new A.Extents(){ Cx = 1897028L, Cy = 1896533L };

            transform2D85.Append(offset99);
            transform2D85.Append(extents99);

            A.PresetGeometry presetGeometry65 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList65 = new A.AdjustValueList();

            presetGeometry65.Append(adjustValueList65);

            A.Outline outline64 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill170 = new A.SolidFill();
            A.SchemeColor schemeColor414 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill170.Append(schemeColor414);

            outline64.Append(solidFill170);

            shapeProperties129.Append(transform2D85);
            shapeProperties129.Append(presetGeometry65);
            shapeProperties129.Append(outline64);

            ShapeStyle shapeStyle58 = new ShapeStyle();

            A.LineReference lineReference58 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor415 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference58.Append(schemeColor415);

            A.FillReference fillReference58 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor416 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference58.Append(schemeColor416);

            A.EffectReference effectReference58 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor417 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference58.Append(schemeColor417);

            A.FontReference fontReference58 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor418 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference58.Append(schemeColor418);

            shapeStyle58.Append(lineReference58);
            shapeStyle58.Append(fillReference58);
            shapeStyle58.Append(effectReference58);
            shapeStyle58.Append(fontReference58);

            connectionShape58.Append(nonVisualConnectionShapeProperties58);
            connectionShape58.Append(shapeProperties129);
            connectionShape58.Append(shapeStyle58);

            ConnectionShape connectionShape59 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties59 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties144 = new NonVisualDrawingProperties(){ Id = (UInt32Value)13U, Name = "Straight Connector 12" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties59 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties144 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties59.Append(nonVisualDrawingProperties144);
            nonVisualConnectionShapeProperties59.Append(nonVisualConnectorShapeDrawingProperties59);
            nonVisualConnectionShapeProperties59.Append(applicationNonVisualDrawingProperties144);

            ShapeProperties shapeProperties130 = new ShapeProperties();

            A.Transform2D transform2D86 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset100 = new A.Offset(){ X = 10445823L, Y = 3131080L };
            A.Extents extents100 = new A.Extents(){ Cx = 1746177L, Cy = 1745720L };

            transform2D86.Append(offset100);
            transform2D86.Append(extents100);

            A.PresetGeometry presetGeometry66 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList66 = new A.AdjustValueList();

            presetGeometry66.Append(adjustValueList66);

            A.Outline outline65 = new A.Outline(){ Width = 28575 };

            A.SolidFill solidFill171 = new A.SolidFill();
            A.SchemeColor schemeColor419 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill171.Append(schemeColor419);

            outline65.Append(solidFill171);

            shapeProperties130.Append(transform2D86);
            shapeProperties130.Append(presetGeometry66);
            shapeProperties130.Append(outline65);

            ShapeStyle shapeStyle59 = new ShapeStyle();

            A.LineReference lineReference59 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor420 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference59.Append(schemeColor420);

            A.FillReference fillReference59 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor421 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference59.Append(schemeColor421);

            A.EffectReference effectReference59 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor422 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference59.Append(schemeColor422);

            A.FontReference fontReference59 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor423 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference59.Append(schemeColor423);

            shapeStyle59.Append(lineReference59);
            shapeStyle59.Append(fillReference59);
            shapeStyle59.Append(effectReference59);
            shapeStyle59.Append(fontReference59);

            connectionShape59.Append(nonVisualConnectionShapeProperties59);
            connectionShape59.Append(shapeProperties130);
            connectionShape59.Append(shapeStyle59);

            ConnectionShape connectionShape60 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties60 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties145 = new NonVisualDrawingProperties(){ Id = (UInt32Value)14U, Name = "Straight Connector 13" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties60 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties145 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties60.Append(nonVisualDrawingProperties145);
            nonVisualConnectionShapeProperties60.Append(nonVisualConnectorShapeDrawingProperties60);
            nonVisualConnectionShapeProperties60.Append(applicationNonVisualDrawingProperties145);

            ShapeProperties shapeProperties131 = new ShapeProperties();

            A.Transform2D transform2D87 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset101 = new A.Offset(){ X = 10921671L, Y = 3683002L };
            A.Extents extents101 = new A.Extents(){ Cx = 1270332L, Cy = 1269999L };

            transform2D87.Append(offset101);
            transform2D87.Append(extents101);

            A.PresetGeometry presetGeometry67 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList67 = new A.AdjustValueList();

            presetGeometry67.Append(adjustValueList67);

            A.Outline outline66 = new A.Outline(){ Width = 28575 };

            A.SolidFill solidFill172 = new A.SolidFill();
            A.SchemeColor schemeColor424 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill172.Append(schemeColor424);

            outline66.Append(solidFill172);

            shapeProperties131.Append(transform2D87);
            shapeProperties131.Append(presetGeometry67);
            shapeProperties131.Append(outline66);

            ShapeStyle shapeStyle60 = new ShapeStyle();

            A.LineReference lineReference60 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor425 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference60.Append(schemeColor425);

            A.FillReference fillReference60 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor426 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference60.Append(schemeColor426);

            A.EffectReference effectReference60 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor427 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference60.Append(schemeColor427);

            A.FontReference fontReference60 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor428 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference60.Append(schemeColor428);

            shapeStyle60.Append(lineReference60);
            shapeStyle60.Append(fillReference60);
            shapeStyle60.Append(effectReference60);
            shapeStyle60.Append(fontReference60);

            connectionShape60.Append(nonVisualConnectionShapeProperties60);
            connectionShape60.Append(shapeProperties131);
            connectionShape60.Append(shapeStyle60);

            shapeTree14.Append(nonVisualGroupShapeProperties14);
            shapeTree14.Append(groupShapeProperties14);
            shapeTree14.Append(shape64);
            shapeTree14.Append(shape65);
            shapeTree14.Append(shape66);
            shapeTree14.Append(shape67);
            shapeTree14.Append(shape68);
            shapeTree14.Append(shape69);
            shapeTree14.Append(shape70);
            shapeTree14.Append(shape71);
            shapeTree14.Append(connectionShape56);
            shapeTree14.Append(connectionShape57);
            shapeTree14.Append(connectionShape58);
            shapeTree14.Append(connectionShape59);
            shapeTree14.Append(connectionShape60);

            CommonSlideDataExtensionList commonSlideDataExtensionList14 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension14 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId14 = new P14.CreationId(){ Val = (UInt32Value)705703276U };
            creationId14.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension14.Append(creationId14);

            commonSlideDataExtensionList14.Append(commonSlideDataExtension14);

            commonSlideData14.Append(shapeTree14);
            commonSlideData14.Append(commonSlideDataExtensionList14);

            ColorMapOverride colorMapOverride13 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping13 = new A.MasterColorMapping();

            colorMapOverride13.Append(masterColorMapping13);

            Timing timing14 = new Timing();

            TimeNodeList timeNodeList14 = new TimeNodeList();

            ParallelTimeNode parallelTimeNode14 = new ParallelTimeNode();
            CommonTimeNode commonTimeNode14 = new CommonTimeNode(){ Id = (UInt32Value)1U, Duration = "indefinite", Restart = TimeNodeRestartValues.Never, NodeType = TimeNodeValues.TmingRoot };

            parallelTimeNode14.Append(commonTimeNode14);

            timeNodeList14.Append(parallelTimeNode14);

            timing14.Append(timeNodeList14);

            slideLayout12.Append(commonSlideData14);
            slideLayout12.Append(colorMapOverride13);
            slideLayout12.Append(timing14);

            slideLayoutPart12.SlideLayout = slideLayout12;
        }

        // Generates content of slideLayoutPart13.
        private void GenerateSlideLayoutPart13Content(SlideLayoutPart slideLayoutPart13)
        {
            SlideLayout slideLayout13 = new SlideLayout(){ Preserve = true };
            slideLayout13.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout13.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout13.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData15 = new CommonSlideData(){ Name = "True or False" };

            ShapeTree shapeTree15 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties15 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties146 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties15 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties146 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties15.Append(nonVisualDrawingProperties146);
            nonVisualGroupShapeProperties15.Append(nonVisualGroupShapeDrawingProperties15);
            nonVisualGroupShapeProperties15.Append(applicationNonVisualDrawingProperties146);

            GroupShapeProperties groupShapeProperties15 = new GroupShapeProperties();

            A.TransformGroup transformGroup15 = new A.TransformGroup();
            A.Offset offset102 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents102 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset15 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents15 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup15.Append(offset102);
            transformGroup15.Append(extents102);
            transformGroup15.Append(childOffset15);
            transformGroup15.Append(childExtents15);

            groupShapeProperties15.Append(transformGroup15);

            Shape shape72 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties72 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties147 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties72 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks70 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties72.Append(shapeLocks70);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties147 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape70 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties147.Append(placeholderShape70);

            nonVisualShapeProperties72.Append(nonVisualDrawingProperties147);
            nonVisualShapeProperties72.Append(nonVisualShapeDrawingProperties72);
            nonVisualShapeProperties72.Append(applicationNonVisualDrawingProperties147);

            ShapeProperties shapeProperties132 = new ShapeProperties();

            A.Transform2D transform2D88 = new A.Transform2D();
            A.Offset offset103 = new A.Offset(){ X = 684391L, Y = 685800L };
            A.Extents extents103 = new A.Extents(){ Cx = 10061020L, Cy = 2743200L };

            transform2D88.Append(offset103);
            transform2D88.Append(extents103);

            shapeProperties132.Append(transform2D88);

            TextBody textBody72 = new TextBody();

            A.BodyProperties bodyProperties72 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal, LeftInset = 91440, TopInset = 45720, RightInset = 91440, BottomInset = 45720, RightToLeftColumns = false, Anchor = A.TextAnchoringTypeValues.Center };
            A.NormalAutoFit normalAutoFit18 = new A.NormalAutoFit();

            bodyProperties72.Append(normalAutoFit18);

            A.ListStyle listStyle72 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties31 = new A.Level1ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties177 = new A.DefaultRunProperties(){ Language = "en-US", Bold = false, Dirty = false };

            level1ParagraphProperties31.Append(defaultRunProperties177);

            listStyle72.Append(level1ParagraphProperties31);

            A.Paragraph paragraph100 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties46 = new A.ParagraphProperties(){ LeftMargin = 0, Level = 0 };

            A.Run run62 = new A.Run();

            A.RunProperties runProperties88 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties88.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text88 = new A.Text();
            text88.Text = "Click to edit Master title style";

            run62.Append(runProperties88);
            run62.Append(text88);
            A.EndParagraphRunProperties endParagraphRunProperties64 = new A.EndParagraphRunProperties(){ Language = "en-US", Dirty = false };

            paragraph100.Append(paragraphProperties46);
            paragraph100.Append(run62);
            paragraph100.Append(endParagraphRunProperties64);

            textBody72.Append(bodyProperties72);
            textBody72.Append(listStyle72);
            textBody72.Append(paragraph100);

            shape72.Append(nonVisualShapeProperties72);
            shape72.Append(shapeProperties132);
            shape72.Append(textBody72);

            Shape shape73 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties73 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties148 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Text Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties73 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks71 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties73.Append(shapeLocks71);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties148 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape71 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties148.Append(placeholderShape71);

            nonVisualShapeProperties73.Append(nonVisualDrawingProperties148);
            nonVisualShapeProperties73.Append(nonVisualShapeDrawingProperties73);
            nonVisualShapeProperties73.Append(applicationNonVisualDrawingProperties148);

            ShapeProperties shapeProperties133 = new ShapeProperties();

            A.Transform2D transform2D89 = new A.Transform2D();
            A.Offset offset104 = new A.Offset(){ X = 684390L, Y = 4766733L };
            A.Extents extents104 = new A.Extents(){ Cx = 8536624L, Cy = 1227667L };

            transform2D89.Append(offset104);
            transform2D89.Append(extents104);

            shapeProperties133.Append(transform2D89);

            TextBody textBody73 = new TextBody();

            A.BodyProperties bodyProperties73 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Top };
            A.NormalAutoFit normalAutoFit19 = new A.NormalAutoFit();

            bodyProperties73.Append(normalAutoFit19);

            A.ListStyle listStyle73 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties32 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0, Alignment = A.TextAlignmentTypeValues.Left };
            A.NoBullet noBullet81 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties178 = new A.DefaultRunProperties(){ FontSize = 1800 };

            A.SolidFill solidFill173 = new A.SolidFill();

            A.SchemeColor schemeColor429 = new A.SchemeColor(){ Val = A.SchemeColorValues.Background2 };
            A.LuminanceModulation luminanceModulation23 = new A.LuminanceModulation(){ Val = 75000 };

            schemeColor429.Append(luminanceModulation23);

            solidFill173.Append(schemeColor429);

            defaultRunProperties178.Append(solidFill173);

            level1ParagraphProperties32.Append(noBullet81);
            level1ParagraphProperties32.Append(defaultRunProperties178);

            A.Level2ParagraphProperties level2ParagraphProperties20 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Indent = 0 };
            A.NoBullet noBullet82 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties179 = new A.DefaultRunProperties(){ FontSize = 1800 };

            A.SolidFill solidFill174 = new A.SolidFill();

            A.SchemeColor schemeColor430 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint47 = new A.Tint(){ Val = 75000 };

            schemeColor430.Append(tint47);

            solidFill174.Append(schemeColor430);

            defaultRunProperties179.Append(solidFill174);

            level2ParagraphProperties20.Append(noBullet82);
            level2ParagraphProperties20.Append(defaultRunProperties179);

            A.Level3ParagraphProperties level3ParagraphProperties20 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Indent = 0 };
            A.NoBullet noBullet83 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties180 = new A.DefaultRunProperties(){ FontSize = 1600 };

            A.SolidFill solidFill175 = new A.SolidFill();

            A.SchemeColor schemeColor431 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint48 = new A.Tint(){ Val = 75000 };

            schemeColor431.Append(tint48);

            solidFill175.Append(schemeColor431);

            defaultRunProperties180.Append(solidFill175);

            level3ParagraphProperties20.Append(noBullet83);
            level3ParagraphProperties20.Append(defaultRunProperties180);

            A.Level4ParagraphProperties level4ParagraphProperties20 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Indent = 0 };
            A.NoBullet noBullet84 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties181 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill176 = new A.SolidFill();

            A.SchemeColor schemeColor432 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint49 = new A.Tint(){ Val = 75000 };

            schemeColor432.Append(tint49);

            solidFill176.Append(schemeColor432);

            defaultRunProperties181.Append(solidFill176);

            level4ParagraphProperties20.Append(noBullet84);
            level4ParagraphProperties20.Append(defaultRunProperties181);

            A.Level5ParagraphProperties level5ParagraphProperties20 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Indent = 0 };
            A.NoBullet noBullet85 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties182 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill177 = new A.SolidFill();

            A.SchemeColor schemeColor433 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint50 = new A.Tint(){ Val = 75000 };

            schemeColor433.Append(tint50);

            solidFill177.Append(schemeColor433);

            defaultRunProperties182.Append(solidFill177);

            level5ParagraphProperties20.Append(noBullet85);
            level5ParagraphProperties20.Append(defaultRunProperties182);

            A.Level6ParagraphProperties level6ParagraphProperties18 = new A.Level6ParagraphProperties(){ LeftMargin = 2286000, Indent = 0 };
            A.NoBullet noBullet86 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties183 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill178 = new A.SolidFill();

            A.SchemeColor schemeColor434 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint51 = new A.Tint(){ Val = 75000 };

            schemeColor434.Append(tint51);

            solidFill178.Append(schemeColor434);

            defaultRunProperties183.Append(solidFill178);

            level6ParagraphProperties18.Append(noBullet86);
            level6ParagraphProperties18.Append(defaultRunProperties183);

            A.Level7ParagraphProperties level7ParagraphProperties18 = new A.Level7ParagraphProperties(){ LeftMargin = 2743200, Indent = 0 };
            A.NoBullet noBullet87 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties184 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill179 = new A.SolidFill();

            A.SchemeColor schemeColor435 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint52 = new A.Tint(){ Val = 75000 };

            schemeColor435.Append(tint52);

            solidFill179.Append(schemeColor435);

            defaultRunProperties184.Append(solidFill179);

            level7ParagraphProperties18.Append(noBullet87);
            level7ParagraphProperties18.Append(defaultRunProperties184);

            A.Level8ParagraphProperties level8ParagraphProperties18 = new A.Level8ParagraphProperties(){ LeftMargin = 3200400, Indent = 0 };
            A.NoBullet noBullet88 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties185 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill180 = new A.SolidFill();

            A.SchemeColor schemeColor436 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint53 = new A.Tint(){ Val = 75000 };

            schemeColor436.Append(tint53);

            solidFill180.Append(schemeColor436);

            defaultRunProperties185.Append(solidFill180);

            level8ParagraphProperties18.Append(noBullet88);
            level8ParagraphProperties18.Append(defaultRunProperties185);

            A.Level9ParagraphProperties level9ParagraphProperties18 = new A.Level9ParagraphProperties(){ LeftMargin = 3657600, Indent = 0 };
            A.NoBullet noBullet89 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties186 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill181 = new A.SolidFill();

            A.SchemeColor schemeColor437 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint54 = new A.Tint(){ Val = 75000 };

            schemeColor437.Append(tint54);

            solidFill181.Append(schemeColor437);

            defaultRunProperties186.Append(solidFill181);

            level9ParagraphProperties18.Append(noBullet89);
            level9ParagraphProperties18.Append(defaultRunProperties186);

            listStyle73.Append(level1ParagraphProperties32);
            listStyle73.Append(level2ParagraphProperties20);
            listStyle73.Append(level3ParagraphProperties20);
            listStyle73.Append(level4ParagraphProperties20);
            listStyle73.Append(level5ParagraphProperties20);
            listStyle73.Append(level6ParagraphProperties18);
            listStyle73.Append(level7ParagraphProperties18);
            listStyle73.Append(level8ParagraphProperties18);
            listStyle73.Append(level9ParagraphProperties18);

            A.Paragraph paragraph101 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties47 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run63 = new A.Run();

            A.RunProperties runProperties89 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties89.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text89 = new A.Text();
            text89.Text = "Click to edit Master text styles";

            run63.Append(runProperties89);
            run63.Append(text89);

            paragraph101.Append(paragraphProperties47);
            paragraph101.Append(run63);

            textBody73.Append(bodyProperties73);
            textBody73.Append(listStyle73);
            textBody73.Append(paragraph101);

            shape73.Append(nonVisualShapeProperties73);
            shape73.Append(shapeProperties133);
            shape73.Append(textBody73);

            Shape shape74 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties74 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties149 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Date Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties74 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks72 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties74.Append(shapeLocks72);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties149 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape72 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties149.Append(placeholderShape72);

            nonVisualShapeProperties74.Append(nonVisualDrawingProperties149);
            nonVisualShapeProperties74.Append(nonVisualShapeDrawingProperties74);
            nonVisualShapeProperties74.Append(applicationNonVisualDrawingProperties149);
            ShapeProperties shapeProperties134 = new ShapeProperties();

            TextBody textBody74 = new TextBody();
            A.BodyProperties bodyProperties74 = new A.BodyProperties();
            A.ListStyle listStyle74 = new A.ListStyle();

            A.Paragraph paragraph102 = new A.Paragraph();

            A.Field field27 = new A.Field(){ Id = "{CE1A2D98-1BBD-4706-A118-AAC2A16BEAD3}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties90 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties90.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text90 = new A.Text();
            text90.Text = "2012/10/3";

            field27.Append(runProperties90);
            field27.Append(text90);
            A.EndParagraphRunProperties endParagraphRunProperties65 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph102.Append(field27);
            paragraph102.Append(endParagraphRunProperties65);

            textBody74.Append(bodyProperties74);
            textBody74.Append(listStyle74);
            textBody74.Append(paragraph102);

            shape74.Append(nonVisualShapeProperties74);
            shape74.Append(shapeProperties134);
            shape74.Append(textBody74);

            Shape shape75 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties75 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties150 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Footer Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties75 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks73 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties75.Append(shapeLocks73);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties150 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape73 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties150.Append(placeholderShape73);

            nonVisualShapeProperties75.Append(nonVisualDrawingProperties150);
            nonVisualShapeProperties75.Append(nonVisualShapeDrawingProperties75);
            nonVisualShapeProperties75.Append(applicationNonVisualDrawingProperties150);
            ShapeProperties shapeProperties135 = new ShapeProperties();

            TextBody textBody75 = new TextBody();
            A.BodyProperties bodyProperties75 = new A.BodyProperties();
            A.ListStyle listStyle75 = new A.ListStyle();

            A.Paragraph paragraph103 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties66 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph103.Append(endParagraphRunProperties66);

            textBody75.Append(bodyProperties75);
            textBody75.Append(listStyle75);
            textBody75.Append(paragraph103);

            shape75.Append(nonVisualShapeProperties75);
            shape75.Append(shapeProperties135);
            shape75.Append(textBody75);

            Shape shape76 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties76 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties151 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Slide Number Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties76 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks74 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties76.Append(shapeLocks74);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties151 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape74 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties151.Append(placeholderShape74);

            nonVisualShapeProperties76.Append(nonVisualDrawingProperties151);
            nonVisualShapeProperties76.Append(nonVisualShapeDrawingProperties76);
            nonVisualShapeProperties76.Append(applicationNonVisualDrawingProperties151);
            ShapeProperties shapeProperties136 = new ShapeProperties();

            TextBody textBody76 = new TextBody();
            A.BodyProperties bodyProperties76 = new A.BodyProperties();
            A.ListStyle listStyle76 = new A.ListStyle();

            A.Paragraph paragraph104 = new A.Paragraph();

            A.Field field28 = new A.Field(){ Id = "{D107CD50-7081-433F-A1F2-156B4E14F4F4}", Type = "slidenum" };

            A.RunProperties runProperties91 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties91.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text91 = new A.Text();
            text91.Text = "‹#›";

            field28.Append(runProperties91);
            field28.Append(text91);
            A.EndParagraphRunProperties endParagraphRunProperties67 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph104.Append(field28);
            paragraph104.Append(endParagraphRunProperties67);

            textBody76.Append(bodyProperties76);
            textBody76.Append(listStyle76);
            textBody76.Append(paragraph104);

            shape76.Append(nonVisualShapeProperties76);
            shape76.Append(shapeProperties136);
            shape76.Append(textBody76);

            Shape shape77 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties77 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties152 = new NonVisualDrawingProperties(){ Id = (UInt32Value)10U, Name = "Text Placeholder 9" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties77 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks75 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties77.Append(shapeLocks75);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties152 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape75 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)13U };

            applicationNonVisualDrawingProperties152.Append(placeholderShape75);

            nonVisualShapeProperties77.Append(nonVisualDrawingProperties152);
            nonVisualShapeProperties77.Append(nonVisualShapeDrawingProperties77);
            nonVisualShapeProperties77.Append(applicationNonVisualDrawingProperties152);

            ShapeProperties shapeProperties137 = new ShapeProperties();

            A.Transform2D transform2D90 = new A.Transform2D();
            A.Offset offset105 = new A.Offset(){ X = 684390L, Y = 3928534L };
            A.Extents extents105 = new A.Extents(){ Cx = 8536623L, Cy = 838200L };

            transform2D90.Append(offset105);
            transform2D90.Append(extents105);

            shapeProperties137.Append(transform2D90);

            TextBody textBody77 = new TextBody();

            A.BodyProperties bodyProperties77 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal, LeftInset = 91440, TopInset = 45720, RightInset = 91440, BottomInset = 45720, RightToLeftColumns = false, Anchor = A.TextAnchoringTypeValues.Bottom };
            A.NormalAutoFit normalAutoFit20 = new A.NormalAutoFit();

            bodyProperties77.Append(normalAutoFit20);

            A.ListStyle listStyle77 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties33 = new A.Level1ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties187 = new A.DefaultRunProperties(){ Language = "en-US", FontSize = 2400, Bold = false, Capital = A.TextCapsValues.All, Dirty = false };
            defaultRunProperties187.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));

            A.Outline outline67 = new A.Outline(){ Width = 3175, CompoundLineType = A.CompoundLineValues.Single };
            A.NoFill noFill4 = new A.NoFill();

            outline67.Append(noFill4);

            A.SolidFill solidFill182 = new A.SolidFill();
            A.SchemeColor schemeColor438 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill182.Append(schemeColor438);
            A.EffectList effectList21 = new A.EffectList();
            A.LatinFont latinFont36 = new A.LatinFont(){ Typeface = "+mj-lt" };
            A.EastAsianFont eastAsianFont33 = new A.EastAsianFont(){ Typeface = "+mj-ea" };
            A.ComplexScriptFont complexScriptFont33 = new A.ComplexScriptFont(){ Typeface = "Trebuchet MS" };

            defaultRunProperties187.Append(outline67);
            defaultRunProperties187.Append(solidFill182);
            defaultRunProperties187.Append(effectList21);
            defaultRunProperties187.Append(latinFont36);
            defaultRunProperties187.Append(eastAsianFont33);
            defaultRunProperties187.Append(complexScriptFont33);

            level1ParagraphProperties33.Append(defaultRunProperties187);

            listStyle77.Append(level1ParagraphProperties33);

            A.Paragraph paragraph105 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties48 = new A.ParagraphProperties(){ LeftMargin = 0, Level = 0 };

            A.SpaceBefore spaceBefore13 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent13 = new A.SpacingPercent(){ Val = 0 };

            spaceBefore13.Append(spacingPercent13);
            A.NoBullet noBullet90 = new A.NoBullet();

            paragraphProperties48.Append(spaceBefore13);
            paragraphProperties48.Append(noBullet90);

            A.Run run64 = new A.Run();

            A.RunProperties runProperties92 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties92.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text92 = new A.Text();
            text92.Text = "Click to edit Master text styles";

            run64.Append(runProperties92);
            run64.Append(text92);

            paragraph105.Append(paragraphProperties48);
            paragraph105.Append(run64);

            textBody77.Append(bodyProperties77);
            textBody77.Append(listStyle77);
            textBody77.Append(paragraph105);

            shape77.Append(nonVisualShapeProperties77);
            shape77.Append(shapeProperties137);
            shape77.Append(textBody77);

            ConnectionShape connectionShape61 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties61 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties153 = new NonVisualDrawingProperties(){ Id = (UInt32Value)8U, Name = "Straight Connector 7" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties61 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties153 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties61.Append(nonVisualDrawingProperties153);
            nonVisualConnectionShapeProperties61.Append(nonVisualConnectorShapeDrawingProperties61);
            nonVisualConnectionShapeProperties61.Append(applicationNonVisualDrawingProperties153);

            ShapeProperties shapeProperties138 = new ShapeProperties();

            A.Transform2D transform2D91 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset106 = new A.Offset(){ X = 11278949L, Y = 2963333L };
            A.Extents extents106 = new A.Extents(){ Cx = 913052L, Cy = 912812L };

            transform2D91.Append(offset106);
            transform2D91.Append(extents106);

            A.PresetGeometry presetGeometry68 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList68 = new A.AdjustValueList();

            presetGeometry68.Append(adjustValueList68);

            A.Outline outline68 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill183 = new A.SolidFill();
            A.SchemeColor schemeColor439 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill183.Append(schemeColor439);

            outline68.Append(solidFill183);

            shapeProperties138.Append(transform2D91);
            shapeProperties138.Append(presetGeometry68);
            shapeProperties138.Append(outline68);

            ShapeStyle shapeStyle61 = new ShapeStyle();

            A.LineReference lineReference61 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor440 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference61.Append(schemeColor440);

            A.FillReference fillReference61 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor441 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference61.Append(schemeColor441);

            A.EffectReference effectReference61 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor442 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference61.Append(schemeColor442);

            A.FontReference fontReference61 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor443 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference61.Append(schemeColor443);

            shapeStyle61.Append(lineReference61);
            shapeStyle61.Append(fillReference61);
            shapeStyle61.Append(effectReference61);
            shapeStyle61.Append(fontReference61);

            connectionShape61.Append(nonVisualConnectionShapeProperties61);
            connectionShape61.Append(shapeProperties138);
            connectionShape61.Append(shapeStyle61);

            ConnectionShape connectionShape62 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties62 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties154 = new NonVisualDrawingProperties(){ Id = (UInt32Value)9U, Name = "Straight Connector 8" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties62 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties154 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties62.Append(nonVisualDrawingProperties154);
            nonVisualConnectionShapeProperties62.Append(nonVisualConnectorShapeDrawingProperties62);
            nonVisualConnectionShapeProperties62.Append(applicationNonVisualDrawingProperties154);

            ShapeProperties shapeProperties139 = new ShapeProperties();

            A.Transform2D transform2D92 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset107 = new A.Offset(){ X = 9209368L, Y = 3190344L };
            A.Extents extents107 = new A.Extents(){ Cx = 2982634L, Cy = 2981856L };

            transform2D92.Append(offset107);
            transform2D92.Append(extents107);

            A.PresetGeometry presetGeometry69 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList69 = new A.AdjustValueList();

            presetGeometry69.Append(adjustValueList69);

            A.Outline outline69 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill184 = new A.SolidFill();
            A.SchemeColor schemeColor444 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill184.Append(schemeColor444);

            outline69.Append(solidFill184);

            shapeProperties139.Append(transform2D92);
            shapeProperties139.Append(presetGeometry69);
            shapeProperties139.Append(outline69);

            ShapeStyle shapeStyle62 = new ShapeStyle();

            A.LineReference lineReference62 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor445 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference62.Append(schemeColor445);

            A.FillReference fillReference62 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor446 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference62.Append(schemeColor446);

            A.EffectReference effectReference62 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor447 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference62.Append(schemeColor447);

            A.FontReference fontReference62 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor448 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference62.Append(schemeColor448);

            shapeStyle62.Append(lineReference62);
            shapeStyle62.Append(fillReference62);
            shapeStyle62.Append(effectReference62);
            shapeStyle62.Append(fontReference62);

            connectionShape62.Append(nonVisualConnectionShapeProperties62);
            connectionShape62.Append(shapeProperties139);
            connectionShape62.Append(shapeStyle62);

            ConnectionShape connectionShape63 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties63 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties155 = new NonVisualDrawingProperties(){ Id = (UInt32Value)11U, Name = "Straight Connector 10" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties63 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties155 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties63.Append(nonVisualDrawingProperties155);
            nonVisualConnectionShapeProperties63.Append(nonVisualConnectorShapeDrawingProperties63);
            nonVisualConnectionShapeProperties63.Append(applicationNonVisualDrawingProperties155);

            ShapeProperties shapeProperties140 = new ShapeProperties();

            A.Transform2D transform2D93 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset108 = new A.Offset(){ X = 10294973L, Y = 3285068L };
            A.Extents extents108 = new A.Extents(){ Cx = 1897028L, Cy = 1896533L };

            transform2D93.Append(offset108);
            transform2D93.Append(extents108);

            A.PresetGeometry presetGeometry70 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList70 = new A.AdjustValueList();

            presetGeometry70.Append(adjustValueList70);

            A.Outline outline70 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill185 = new A.SolidFill();
            A.SchemeColor schemeColor449 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill185.Append(schemeColor449);

            outline70.Append(solidFill185);

            shapeProperties140.Append(transform2D93);
            shapeProperties140.Append(presetGeometry70);
            shapeProperties140.Append(outline70);

            ShapeStyle shapeStyle63 = new ShapeStyle();

            A.LineReference lineReference63 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor450 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference63.Append(schemeColor450);

            A.FillReference fillReference63 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor451 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference63.Append(schemeColor451);

            A.EffectReference effectReference63 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor452 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference63.Append(schemeColor452);

            A.FontReference fontReference63 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor453 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference63.Append(schemeColor453);

            shapeStyle63.Append(lineReference63);
            shapeStyle63.Append(fillReference63);
            shapeStyle63.Append(effectReference63);
            shapeStyle63.Append(fontReference63);

            connectionShape63.Append(nonVisualConnectionShapeProperties63);
            connectionShape63.Append(shapeProperties140);
            connectionShape63.Append(shapeStyle63);

            ConnectionShape connectionShape64 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties64 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties156 = new NonVisualDrawingProperties(){ Id = (UInt32Value)12U, Name = "Straight Connector 11" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties64 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties156 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties64.Append(nonVisualDrawingProperties156);
            nonVisualConnectionShapeProperties64.Append(nonVisualConnectorShapeDrawingProperties64);
            nonVisualConnectionShapeProperties64.Append(applicationNonVisualDrawingProperties156);

            ShapeProperties shapeProperties141 = new ShapeProperties();

            A.Transform2D transform2D94 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset109 = new A.Offset(){ X = 10445823L, Y = 3131080L };
            A.Extents extents109 = new A.Extents(){ Cx = 1746177L, Cy = 1745720L };

            transform2D94.Append(offset109);
            transform2D94.Append(extents109);

            A.PresetGeometry presetGeometry71 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList71 = new A.AdjustValueList();

            presetGeometry71.Append(adjustValueList71);

            A.Outline outline71 = new A.Outline(){ Width = 28575 };

            A.SolidFill solidFill186 = new A.SolidFill();
            A.SchemeColor schemeColor454 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill186.Append(schemeColor454);

            outline71.Append(solidFill186);

            shapeProperties141.Append(transform2D94);
            shapeProperties141.Append(presetGeometry71);
            shapeProperties141.Append(outline71);

            ShapeStyle shapeStyle64 = new ShapeStyle();

            A.LineReference lineReference64 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor455 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference64.Append(schemeColor455);

            A.FillReference fillReference64 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor456 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference64.Append(schemeColor456);

            A.EffectReference effectReference64 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor457 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference64.Append(schemeColor457);

            A.FontReference fontReference64 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor458 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference64.Append(schemeColor458);

            shapeStyle64.Append(lineReference64);
            shapeStyle64.Append(fillReference64);
            shapeStyle64.Append(effectReference64);
            shapeStyle64.Append(fontReference64);

            connectionShape64.Append(nonVisualConnectionShapeProperties64);
            connectionShape64.Append(shapeProperties141);
            connectionShape64.Append(shapeStyle64);

            ConnectionShape connectionShape65 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties65 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties157 = new NonVisualDrawingProperties(){ Id = (UInt32Value)13U, Name = "Straight Connector 12" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties65 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties157 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties65.Append(nonVisualDrawingProperties157);
            nonVisualConnectionShapeProperties65.Append(nonVisualConnectorShapeDrawingProperties65);
            nonVisualConnectionShapeProperties65.Append(applicationNonVisualDrawingProperties157);

            ShapeProperties shapeProperties142 = new ShapeProperties();

            A.Transform2D transform2D95 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset110 = new A.Offset(){ X = 10921671L, Y = 3683002L };
            A.Extents extents110 = new A.Extents(){ Cx = 1270332L, Cy = 1269999L };

            transform2D95.Append(offset110);
            transform2D95.Append(extents110);

            A.PresetGeometry presetGeometry72 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList72 = new A.AdjustValueList();

            presetGeometry72.Append(adjustValueList72);

            A.Outline outline72 = new A.Outline(){ Width = 28575 };

            A.SolidFill solidFill187 = new A.SolidFill();
            A.SchemeColor schemeColor459 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill187.Append(schemeColor459);

            outline72.Append(solidFill187);

            shapeProperties142.Append(transform2D95);
            shapeProperties142.Append(presetGeometry72);
            shapeProperties142.Append(outline72);

            ShapeStyle shapeStyle65 = new ShapeStyle();

            A.LineReference lineReference65 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor460 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference65.Append(schemeColor460);

            A.FillReference fillReference65 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor461 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference65.Append(schemeColor461);

            A.EffectReference effectReference65 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor462 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference65.Append(schemeColor462);

            A.FontReference fontReference65 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor463 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference65.Append(schemeColor463);

            shapeStyle65.Append(lineReference65);
            shapeStyle65.Append(fillReference65);
            shapeStyle65.Append(effectReference65);
            shapeStyle65.Append(fontReference65);

            connectionShape65.Append(nonVisualConnectionShapeProperties65);
            connectionShape65.Append(shapeProperties142);
            connectionShape65.Append(shapeStyle65);

            shapeTree15.Append(nonVisualGroupShapeProperties15);
            shapeTree15.Append(groupShapeProperties15);
            shapeTree15.Append(shape72);
            shapeTree15.Append(shape73);
            shapeTree15.Append(shape74);
            shapeTree15.Append(shape75);
            shapeTree15.Append(shape76);
            shapeTree15.Append(shape77);
            shapeTree15.Append(connectionShape61);
            shapeTree15.Append(connectionShape62);
            shapeTree15.Append(connectionShape63);
            shapeTree15.Append(connectionShape64);
            shapeTree15.Append(connectionShape65);

            CommonSlideDataExtensionList commonSlideDataExtensionList15 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension15 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId15 = new P14.CreationId(){ Val = (UInt32Value)3352052714U };
            creationId15.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension15.Append(creationId15);

            commonSlideDataExtensionList15.Append(commonSlideDataExtension15);

            commonSlideData15.Append(shapeTree15);
            commonSlideData15.Append(commonSlideDataExtensionList15);

            ColorMapOverride colorMapOverride14 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping14 = new A.MasterColorMapping();

            colorMapOverride14.Append(masterColorMapping14);

            Timing timing15 = new Timing();

            TimeNodeList timeNodeList15 = new TimeNodeList();

            ParallelTimeNode parallelTimeNode15 = new ParallelTimeNode();
            CommonTimeNode commonTimeNode15 = new CommonTimeNode(){ Id = (UInt32Value)1U, Duration = "indefinite", Restart = TimeNodeRestartValues.Never, NodeType = TimeNodeValues.TmingRoot };

            parallelTimeNode15.Append(commonTimeNode15);

            timeNodeList15.Append(parallelTimeNode15);

            timing15.Append(timeNodeList15);

            slideLayout13.Append(commonSlideData15);
            slideLayout13.Append(colorMapOverride14);
            slideLayout13.Append(timing15);

            slideLayoutPart13.SlideLayout = slideLayout13;
        }

        // Generates content of slideLayoutPart14.
        private void GenerateSlideLayoutPart14Content(SlideLayoutPart slideLayoutPart14)
        {
            SlideLayout slideLayout14 = new SlideLayout(){ Preserve = true };
            slideLayout14.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout14.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout14.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData16 = new CommonSlideData(){ Name = "Panoramic Picture with Caption" };

            ShapeTree shapeTree16 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties16 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties158 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties16 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties158 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties16.Append(nonVisualDrawingProperties158);
            nonVisualGroupShapeProperties16.Append(nonVisualGroupShapeDrawingProperties16);
            nonVisualGroupShapeProperties16.Append(applicationNonVisualDrawingProperties158);

            GroupShapeProperties groupShapeProperties16 = new GroupShapeProperties();

            A.TransformGroup transformGroup16 = new A.TransformGroup();
            A.Offset offset111 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents111 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset16 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents16 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup16.Append(offset111);
            transformGroup16.Append(extents111);
            transformGroup16.Append(childOffset16);
            transformGroup16.Append(childExtents16);

            groupShapeProperties16.Append(transformGroup16);

            Shape shape78 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties78 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties159 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties78 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks76 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties78.Append(shapeLocks76);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties159 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape76 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties159.Append(placeholderShape76);

            nonVisualShapeProperties78.Append(nonVisualDrawingProperties159);
            nonVisualShapeProperties78.Append(nonVisualShapeDrawingProperties78);
            nonVisualShapeProperties78.Append(applicationNonVisualDrawingProperties159);
            ShapeProperties shapeProperties143 = new ShapeProperties();

            TextBody textBody78 = new TextBody();
            A.BodyProperties bodyProperties78 = new A.BodyProperties();
            A.ListStyle listStyle78 = new A.ListStyle();

            A.Paragraph paragraph106 = new A.Paragraph();

            A.Run run65 = new A.Run();

            A.RunProperties runProperties93 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties93.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text93 = new A.Text();
            text93.Text = "Click to edit Master title style";

            run65.Append(runProperties93);
            run65.Append(text93);
            A.EndParagraphRunProperties endParagraphRunProperties68 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph106.Append(run65);
            paragraph106.Append(endParagraphRunProperties68);

            textBody78.Append(bodyProperties78);
            textBody78.Append(listStyle78);
            textBody78.Append(paragraph106);

            shape78.Append(nonVisualShapeProperties78);
            shape78.Append(shapeProperties143);
            shape78.Append(textBody78);

            Shape shape79 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties79 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties160 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Date Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties79 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks77 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties79.Append(shapeLocks77);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties160 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape77 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties160.Append(placeholderShape77);

            nonVisualShapeProperties79.Append(nonVisualDrawingProperties160);
            nonVisualShapeProperties79.Append(nonVisualShapeDrawingProperties79);
            nonVisualShapeProperties79.Append(applicationNonVisualDrawingProperties160);
            ShapeProperties shapeProperties144 = new ShapeProperties();

            TextBody textBody79 = new TextBody();
            A.BodyProperties bodyProperties79 = new A.BodyProperties();
            A.ListStyle listStyle79 = new A.ListStyle();

            A.Paragraph paragraph107 = new A.Paragraph();

            A.Field field29 = new A.Field(){ Id = "{CE1A2D98-1BBD-4706-A118-AAC2A16BEAD3}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties94 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties94.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text94 = new A.Text();
            text94.Text = "2012/10/3";

            field29.Append(runProperties94);
            field29.Append(text94);
            A.EndParagraphRunProperties endParagraphRunProperties69 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph107.Append(field29);
            paragraph107.Append(endParagraphRunProperties69);

            textBody79.Append(bodyProperties79);
            textBody79.Append(listStyle79);
            textBody79.Append(paragraph107);

            shape79.Append(nonVisualShapeProperties79);
            shape79.Append(shapeProperties144);
            shape79.Append(textBody79);

            Shape shape80 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties80 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties161 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Footer Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties80 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks78 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties80.Append(shapeLocks78);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties161 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape78 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties161.Append(placeholderShape78);

            nonVisualShapeProperties80.Append(nonVisualDrawingProperties161);
            nonVisualShapeProperties80.Append(nonVisualShapeDrawingProperties80);
            nonVisualShapeProperties80.Append(applicationNonVisualDrawingProperties161);
            ShapeProperties shapeProperties145 = new ShapeProperties();

            TextBody textBody80 = new TextBody();
            A.BodyProperties bodyProperties80 = new A.BodyProperties();
            A.ListStyle listStyle80 = new A.ListStyle();

            A.Paragraph paragraph108 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties70 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph108.Append(endParagraphRunProperties70);

            textBody80.Append(bodyProperties80);
            textBody80.Append(listStyle80);
            textBody80.Append(paragraph108);

            shape80.Append(nonVisualShapeProperties80);
            shape80.Append(shapeProperties145);
            shape80.Append(textBody80);

            Shape shape81 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties81 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties162 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Slide Number Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties81 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks79 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties81.Append(shapeLocks79);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties162 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape79 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties162.Append(placeholderShape79);

            nonVisualShapeProperties81.Append(nonVisualDrawingProperties162);
            nonVisualShapeProperties81.Append(nonVisualShapeDrawingProperties81);
            nonVisualShapeProperties81.Append(applicationNonVisualDrawingProperties162);
            ShapeProperties shapeProperties146 = new ShapeProperties();

            TextBody textBody81 = new TextBody();
            A.BodyProperties bodyProperties81 = new A.BodyProperties();
            A.ListStyle listStyle81 = new A.ListStyle();

            A.Paragraph paragraph109 = new A.Paragraph();

            A.Field field30 = new A.Field(){ Id = "{D107CD50-7081-433F-A1F2-156B4E14F4F4}", Type = "slidenum" };

            A.RunProperties runProperties95 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties95.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text95 = new A.Text();
            text95.Text = "‹#›";

            field30.Append(runProperties95);
            field30.Append(text95);
            A.EndParagraphRunProperties endParagraphRunProperties71 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph109.Append(field30);
            paragraph109.Append(endParagraphRunProperties71);

            textBody81.Append(bodyProperties81);
            textBody81.Append(listStyle81);
            textBody81.Append(paragraph109);

            shape81.Append(nonVisualShapeProperties81);
            shape81.Append(shapeProperties146);
            shape81.Append(textBody81);

            ConnectionShape connectionShape66 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties66 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties163 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Straight Connector 5" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties66 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties163 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties66.Append(nonVisualDrawingProperties163);
            nonVisualConnectionShapeProperties66.Append(nonVisualConnectorShapeDrawingProperties66);
            nonVisualConnectionShapeProperties66.Append(applicationNonVisualDrawingProperties163);

            ShapeProperties shapeProperties147 = new ShapeProperties();

            A.Transform2D transform2D96 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset112 = new A.Offset(){ X = 11278949L, Y = 2963333L };
            A.Extents extents112 = new A.Extents(){ Cx = 913052L, Cy = 912812L };

            transform2D96.Append(offset112);
            transform2D96.Append(extents112);

            A.PresetGeometry presetGeometry73 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList73 = new A.AdjustValueList();

            presetGeometry73.Append(adjustValueList73);

            A.Outline outline73 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill188 = new A.SolidFill();
            A.SchemeColor schemeColor464 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill188.Append(schemeColor464);

            outline73.Append(solidFill188);

            shapeProperties147.Append(transform2D96);
            shapeProperties147.Append(presetGeometry73);
            shapeProperties147.Append(outline73);

            ShapeStyle shapeStyle66 = new ShapeStyle();

            A.LineReference lineReference66 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor465 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference66.Append(schemeColor465);

            A.FillReference fillReference66 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor466 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference66.Append(schemeColor466);

            A.EffectReference effectReference66 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor467 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference66.Append(schemeColor467);

            A.FontReference fontReference66 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor468 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference66.Append(schemeColor468);

            shapeStyle66.Append(lineReference66);
            shapeStyle66.Append(fillReference66);
            shapeStyle66.Append(effectReference66);
            shapeStyle66.Append(fontReference66);

            connectionShape66.Append(nonVisualConnectionShapeProperties66);
            connectionShape66.Append(shapeProperties147);
            connectionShape66.Append(shapeStyle66);

            ConnectionShape connectionShape67 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties67 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties164 = new NonVisualDrawingProperties(){ Id = (UInt32Value)7U, Name = "Straight Connector 6" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties67 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties164 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties67.Append(nonVisualDrawingProperties164);
            nonVisualConnectionShapeProperties67.Append(nonVisualConnectorShapeDrawingProperties67);
            nonVisualConnectionShapeProperties67.Append(applicationNonVisualDrawingProperties164);

            ShapeProperties shapeProperties148 = new ShapeProperties();

            A.Transform2D transform2D97 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset113 = new A.Offset(){ X = 9209368L, Y = 3190344L };
            A.Extents extents113 = new A.Extents(){ Cx = 2982634L, Cy = 2981856L };

            transform2D97.Append(offset113);
            transform2D97.Append(extents113);

            A.PresetGeometry presetGeometry74 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList74 = new A.AdjustValueList();

            presetGeometry74.Append(adjustValueList74);

            A.Outline outline74 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill189 = new A.SolidFill();
            A.SchemeColor schemeColor469 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill189.Append(schemeColor469);

            outline74.Append(solidFill189);

            shapeProperties148.Append(transform2D97);
            shapeProperties148.Append(presetGeometry74);
            shapeProperties148.Append(outline74);

            ShapeStyle shapeStyle67 = new ShapeStyle();

            A.LineReference lineReference67 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor470 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference67.Append(schemeColor470);

            A.FillReference fillReference67 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor471 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference67.Append(schemeColor471);

            A.EffectReference effectReference67 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor472 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference67.Append(schemeColor472);

            A.FontReference fontReference67 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor473 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference67.Append(schemeColor473);

            shapeStyle67.Append(lineReference67);
            shapeStyle67.Append(fillReference67);
            shapeStyle67.Append(effectReference67);
            shapeStyle67.Append(fontReference67);

            connectionShape67.Append(nonVisualConnectionShapeProperties67);
            connectionShape67.Append(shapeProperties148);
            connectionShape67.Append(shapeStyle67);

            ConnectionShape connectionShape68 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties68 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties165 = new NonVisualDrawingProperties(){ Id = (UInt32Value)8U, Name = "Straight Connector 7" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties68 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties165 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties68.Append(nonVisualDrawingProperties165);
            nonVisualConnectionShapeProperties68.Append(nonVisualConnectorShapeDrawingProperties68);
            nonVisualConnectionShapeProperties68.Append(applicationNonVisualDrawingProperties165);

            ShapeProperties shapeProperties149 = new ShapeProperties();

            A.Transform2D transform2D98 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset114 = new A.Offset(){ X = 10294973L, Y = 3285068L };
            A.Extents extents114 = new A.Extents(){ Cx = 1897028L, Cy = 1896533L };

            transform2D98.Append(offset114);
            transform2D98.Append(extents114);

            A.PresetGeometry presetGeometry75 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList75 = new A.AdjustValueList();

            presetGeometry75.Append(adjustValueList75);

            A.Outline outline75 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill190 = new A.SolidFill();
            A.SchemeColor schemeColor474 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill190.Append(schemeColor474);

            outline75.Append(solidFill190);

            shapeProperties149.Append(transform2D98);
            shapeProperties149.Append(presetGeometry75);
            shapeProperties149.Append(outline75);

            ShapeStyle shapeStyle68 = new ShapeStyle();

            A.LineReference lineReference68 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor475 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference68.Append(schemeColor475);

            A.FillReference fillReference68 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor476 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference68.Append(schemeColor476);

            A.EffectReference effectReference68 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor477 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference68.Append(schemeColor477);

            A.FontReference fontReference68 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor478 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference68.Append(schemeColor478);

            shapeStyle68.Append(lineReference68);
            shapeStyle68.Append(fillReference68);
            shapeStyle68.Append(effectReference68);
            shapeStyle68.Append(fontReference68);

            connectionShape68.Append(nonVisualConnectionShapeProperties68);
            connectionShape68.Append(shapeProperties149);
            connectionShape68.Append(shapeStyle68);

            ConnectionShape connectionShape69 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties69 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties166 = new NonVisualDrawingProperties(){ Id = (UInt32Value)9U, Name = "Straight Connector 8" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties69 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties166 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties69.Append(nonVisualDrawingProperties166);
            nonVisualConnectionShapeProperties69.Append(nonVisualConnectorShapeDrawingProperties69);
            nonVisualConnectionShapeProperties69.Append(applicationNonVisualDrawingProperties166);

            ShapeProperties shapeProperties150 = new ShapeProperties();

            A.Transform2D transform2D99 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset115 = new A.Offset(){ X = 10445823L, Y = 3131080L };
            A.Extents extents115 = new A.Extents(){ Cx = 1746177L, Cy = 1745720L };

            transform2D99.Append(offset115);
            transform2D99.Append(extents115);

            A.PresetGeometry presetGeometry76 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList76 = new A.AdjustValueList();

            presetGeometry76.Append(adjustValueList76);

            A.Outline outline76 = new A.Outline(){ Width = 28575 };

            A.SolidFill solidFill191 = new A.SolidFill();
            A.SchemeColor schemeColor479 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill191.Append(schemeColor479);

            outline76.Append(solidFill191);

            shapeProperties150.Append(transform2D99);
            shapeProperties150.Append(presetGeometry76);
            shapeProperties150.Append(outline76);

            ShapeStyle shapeStyle69 = new ShapeStyle();

            A.LineReference lineReference69 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor480 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference69.Append(schemeColor480);

            A.FillReference fillReference69 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor481 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference69.Append(schemeColor481);

            A.EffectReference effectReference69 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor482 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference69.Append(schemeColor482);

            A.FontReference fontReference69 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor483 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference69.Append(schemeColor483);

            shapeStyle69.Append(lineReference69);
            shapeStyle69.Append(fillReference69);
            shapeStyle69.Append(effectReference69);
            shapeStyle69.Append(fontReference69);

            connectionShape69.Append(nonVisualConnectionShapeProperties69);
            connectionShape69.Append(shapeProperties150);
            connectionShape69.Append(shapeStyle69);

            ConnectionShape connectionShape70 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties70 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties167 = new NonVisualDrawingProperties(){ Id = (UInt32Value)10U, Name = "Straight Connector 9" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties70 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties167 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties70.Append(nonVisualDrawingProperties167);
            nonVisualConnectionShapeProperties70.Append(nonVisualConnectorShapeDrawingProperties70);
            nonVisualConnectionShapeProperties70.Append(applicationNonVisualDrawingProperties167);

            ShapeProperties shapeProperties151 = new ShapeProperties();

            A.Transform2D transform2D100 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset116 = new A.Offset(){ X = 10921671L, Y = 3683002L };
            A.Extents extents116 = new A.Extents(){ Cx = 1270332L, Cy = 1269999L };

            transform2D100.Append(offset116);
            transform2D100.Append(extents116);

            A.PresetGeometry presetGeometry77 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList77 = new A.AdjustValueList();

            presetGeometry77.Append(adjustValueList77);

            A.Outline outline77 = new A.Outline(){ Width = 28575 };

            A.SolidFill solidFill192 = new A.SolidFill();
            A.SchemeColor schemeColor484 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill192.Append(schemeColor484);

            outline77.Append(solidFill192);

            shapeProperties151.Append(transform2D100);
            shapeProperties151.Append(presetGeometry77);
            shapeProperties151.Append(outline77);

            ShapeStyle shapeStyle70 = new ShapeStyle();

            A.LineReference lineReference70 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor485 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference70.Append(schemeColor485);

            A.FillReference fillReference70 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor486 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference70.Append(schemeColor486);

            A.EffectReference effectReference70 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor487 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference70.Append(schemeColor487);

            A.FontReference fontReference70 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor488 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference70.Append(schemeColor488);

            shapeStyle70.Append(lineReference70);
            shapeStyle70.Append(fillReference70);
            shapeStyle70.Append(effectReference70);
            shapeStyle70.Append(fontReference70);

            connectionShape70.Append(nonVisualConnectionShapeProperties70);
            connectionShape70.Append(shapeProperties151);
            connectionShape70.Append(shapeStyle70);

            Shape shape82 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties82 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties168 = new NonVisualDrawingProperties(){ Id = (UInt32Value)16U, Name = "Text Placeholder 9" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties82 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks80 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties82.Append(shapeLocks80);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties168 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape80 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)14U };

            applicationNonVisualDrawingProperties168.Append(placeholderShape80);

            nonVisualShapeProperties82.Append(nonVisualDrawingProperties168);
            nonVisualShapeProperties82.Append(nonVisualShapeDrawingProperties82);
            nonVisualShapeProperties82.Append(applicationNonVisualDrawingProperties168);

            ShapeProperties shapeProperties152 = new ShapeProperties();

            A.Transform2D transform2D101 = new A.Transform2D();
            A.Offset offset117 = new A.Offset(){ X = 914640L, Y = 3843867L };
            A.Extents extents117 = new A.Extents(){ Cx = 8306373L, Cy = 457200L };

            transform2D101.Append(offset117);
            transform2D101.Append(extents117);

            shapeProperties152.Append(transform2D101);

            TextBody textBody82 = new TextBody();

            A.BodyProperties bodyProperties82 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Top };
            A.NormalAutoFit normalAutoFit21 = new A.NormalAutoFit();

            bodyProperties82.Append(normalAutoFit21);

            A.ListStyle listStyle82 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties34 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0 };
            A.BulletFontText bulletFontText6 = new A.BulletFontText();
            A.NoBullet noBullet91 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties188 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level1ParagraphProperties34.Append(bulletFontText6);
            level1ParagraphProperties34.Append(noBullet91);
            level1ParagraphProperties34.Append(defaultRunProperties188);

            A.Level2ParagraphProperties level2ParagraphProperties21 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Indent = 0 };
            A.BulletFontText bulletFontText7 = new A.BulletFontText();
            A.NoBullet noBullet92 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties189 = new A.DefaultRunProperties();

            level2ParagraphProperties21.Append(bulletFontText7);
            level2ParagraphProperties21.Append(noBullet92);
            level2ParagraphProperties21.Append(defaultRunProperties189);

            A.Level3ParagraphProperties level3ParagraphProperties21 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Indent = 0 };
            A.BulletFontText bulletFontText8 = new A.BulletFontText();
            A.NoBullet noBullet93 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties190 = new A.DefaultRunProperties();

            level3ParagraphProperties21.Append(bulletFontText8);
            level3ParagraphProperties21.Append(noBullet93);
            level3ParagraphProperties21.Append(defaultRunProperties190);

            A.Level4ParagraphProperties level4ParagraphProperties21 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Indent = 0 };
            A.BulletFontText bulletFontText9 = new A.BulletFontText();
            A.NoBullet noBullet94 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties191 = new A.DefaultRunProperties();

            level4ParagraphProperties21.Append(bulletFontText9);
            level4ParagraphProperties21.Append(noBullet94);
            level4ParagraphProperties21.Append(defaultRunProperties191);

            A.Level5ParagraphProperties level5ParagraphProperties21 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Indent = 0 };
            A.BulletFontText bulletFontText10 = new A.BulletFontText();
            A.NoBullet noBullet95 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties192 = new A.DefaultRunProperties();

            level5ParagraphProperties21.Append(bulletFontText10);
            level5ParagraphProperties21.Append(noBullet95);
            level5ParagraphProperties21.Append(defaultRunProperties192);

            listStyle82.Append(level1ParagraphProperties34);
            listStyle82.Append(level2ParagraphProperties21);
            listStyle82.Append(level3ParagraphProperties21);
            listStyle82.Append(level4ParagraphProperties21);
            listStyle82.Append(level5ParagraphProperties21);

            A.Paragraph paragraph110 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties49 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run66 = new A.Run();

            A.RunProperties runProperties96 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties96.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text96 = new A.Text();
            text96.Text = "Click to edit Master text styles";

            run66.Append(runProperties96);
            run66.Append(text96);

            paragraph110.Append(paragraphProperties49);
            paragraph110.Append(run66);

            textBody82.Append(bodyProperties82);
            textBody82.Append(listStyle82);
            textBody82.Append(paragraph110);

            shape82.Append(nonVisualShapeProperties82);
            shape82.Append(shapeProperties152);
            shape82.Append(textBody82);

            Shape shape83 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties83 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties169 = new NonVisualDrawingProperties(){ Id = (UInt32Value)17U, Name = "Picture Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties83 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks81 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties83.Append(shapeLocks81);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties169 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape81 = new PlaceholderShape(){ Type = PlaceholderValues.Picture, Index = (UInt32Value)13U };

            applicationNonVisualDrawingProperties169.Append(placeholderShape81);

            nonVisualShapeProperties83.Append(nonVisualDrawingProperties169);
            nonVisualShapeProperties83.Append(nonVisualShapeDrawingProperties83);
            nonVisualShapeProperties83.Append(applicationNonVisualDrawingProperties169);

            ShapeProperties shapeProperties153 = new ShapeProperties();

            A.Transform2D transform2D102 = new A.Transform2D();
            A.Offset offset118 = new A.Offset(){ X = 685979L, Y = 533400L };
            A.Extents extents118 = new A.Extents(){ Cx = 10821630L, Cy = 3124200L };

            transform2D102.Append(offset118);
            transform2D102.Append(extents118);

            A.PresetGeometry presetGeometry78 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Snip2DiagonalRectangle };

            A.AdjustValueList adjustValueList78 = new A.AdjustValueList();
            A.ShapeGuide shapeGuide1 = new A.ShapeGuide(){ Name = "adj1", Formula = "val 10815" };
            A.ShapeGuide shapeGuide2 = new A.ShapeGuide(){ Name = "adj2", Formula = "val 0" };

            adjustValueList78.Append(shapeGuide1);
            adjustValueList78.Append(shapeGuide2);

            presetGeometry78.Append(adjustValueList78);

            A.Outline outline78 = new A.Outline(){ Width = 15875 };

            A.SolidFill solidFill193 = new A.SolidFill();

            A.SchemeColor schemeColor489 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Alpha alpha8 = new A.Alpha(){ Val = 40000 };

            schemeColor489.Append(alpha8);

            solidFill193.Append(schemeColor489);

            outline78.Append(solidFill193);

            A.EffectList effectList22 = new A.EffectList();

            A.InnerShadow innerShadow2 = new A.InnerShadow(){ BlurRadius = 57150L, Distance = 38100L, Direction = 14460000 };

            A.RgbColorModelHex rgbColorModelHex15 = new A.RgbColorModelHex(){ Val = "000000" };
            A.Alpha alpha9 = new A.Alpha(){ Val = 70000 };

            rgbColorModelHex15.Append(alpha9);

            innerShadow2.Append(rgbColorModelHex15);

            effectList22.Append(innerShadow2);

            shapeProperties153.Append(transform2D102);
            shapeProperties153.Append(presetGeometry78);
            shapeProperties153.Append(outline78);
            shapeProperties153.Append(effectList22);

            TextBody textBody83 = new TextBody();

            A.BodyProperties bodyProperties83 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Center };
            A.NormalAutoFit normalAutoFit22 = new A.NormalAutoFit();

            bodyProperties83.Append(normalAutoFit22);

            A.ListStyle listStyle83 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties35 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet96 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties193 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level1ParagraphProperties35.Append(noBullet96);
            level1ParagraphProperties35.Append(defaultRunProperties193);

            A.Level2ParagraphProperties level2ParagraphProperties22 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Indent = 0 };
            A.NoBullet noBullet97 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties194 = new A.DefaultRunProperties(){ FontSize = 2800 };

            level2ParagraphProperties22.Append(noBullet97);
            level2ParagraphProperties22.Append(defaultRunProperties194);

            A.Level3ParagraphProperties level3ParagraphProperties22 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Indent = 0 };
            A.NoBullet noBullet98 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties195 = new A.DefaultRunProperties(){ FontSize = 2400 };

            level3ParagraphProperties22.Append(noBullet98);
            level3ParagraphProperties22.Append(defaultRunProperties195);

            A.Level4ParagraphProperties level4ParagraphProperties22 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Indent = 0 };
            A.NoBullet noBullet99 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties196 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level4ParagraphProperties22.Append(noBullet99);
            level4ParagraphProperties22.Append(defaultRunProperties196);

            A.Level5ParagraphProperties level5ParagraphProperties22 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Indent = 0 };
            A.NoBullet noBullet100 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties197 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level5ParagraphProperties22.Append(noBullet100);
            level5ParagraphProperties22.Append(defaultRunProperties197);

            A.Level6ParagraphProperties level6ParagraphProperties19 = new A.Level6ParagraphProperties(){ LeftMargin = 2286000, Indent = 0 };
            A.NoBullet noBullet101 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties198 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level6ParagraphProperties19.Append(noBullet101);
            level6ParagraphProperties19.Append(defaultRunProperties198);

            A.Level7ParagraphProperties level7ParagraphProperties19 = new A.Level7ParagraphProperties(){ LeftMargin = 2743200, Indent = 0 };
            A.NoBullet noBullet102 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties199 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level7ParagraphProperties19.Append(noBullet102);
            level7ParagraphProperties19.Append(defaultRunProperties199);

            A.Level8ParagraphProperties level8ParagraphProperties19 = new A.Level8ParagraphProperties(){ LeftMargin = 3200400, Indent = 0 };
            A.NoBullet noBullet103 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties200 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level8ParagraphProperties19.Append(noBullet103);
            level8ParagraphProperties19.Append(defaultRunProperties200);

            A.Level9ParagraphProperties level9ParagraphProperties19 = new A.Level9ParagraphProperties(){ LeftMargin = 3657600, Indent = 0 };
            A.NoBullet noBullet104 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties201 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level9ParagraphProperties19.Append(noBullet104);
            level9ParagraphProperties19.Append(defaultRunProperties201);

            listStyle83.Append(level1ParagraphProperties35);
            listStyle83.Append(level2ParagraphProperties22);
            listStyle83.Append(level3ParagraphProperties22);
            listStyle83.Append(level4ParagraphProperties22);
            listStyle83.Append(level5ParagraphProperties22);
            listStyle83.Append(level6ParagraphProperties19);
            listStyle83.Append(level7ParagraphProperties19);
            listStyle83.Append(level8ParagraphProperties19);
            listStyle83.Append(level9ParagraphProperties19);

            A.Paragraph paragraph111 = new A.Paragraph();

            A.Run run67 = new A.Run();

            A.RunProperties runProperties97 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties97.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text97 = new A.Text();
            text97.Text = "Click icon to add picture";

            run67.Append(runProperties97);
            run67.Append(text97);
            A.EndParagraphRunProperties endParagraphRunProperties72 = new A.EndParagraphRunProperties(){ Language = "en-US", Dirty = false };

            paragraph111.Append(run67);
            paragraph111.Append(endParagraphRunProperties72);

            textBody83.Append(bodyProperties83);
            textBody83.Append(listStyle83);
            textBody83.Append(paragraph111);

            shape83.Append(nonVisualShapeProperties83);
            shape83.Append(shapeProperties153);
            shape83.Append(textBody83);

            shapeTree16.Append(nonVisualGroupShapeProperties16);
            shapeTree16.Append(groupShapeProperties16);
            shapeTree16.Append(shape78);
            shapeTree16.Append(shape79);
            shapeTree16.Append(shape80);
            shapeTree16.Append(shape81);
            shapeTree16.Append(connectionShape66);
            shapeTree16.Append(connectionShape67);
            shapeTree16.Append(connectionShape68);
            shapeTree16.Append(connectionShape69);
            shapeTree16.Append(connectionShape70);
            shapeTree16.Append(shape82);
            shapeTree16.Append(shape83);

            CommonSlideDataExtensionList commonSlideDataExtensionList16 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension16 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId16 = new P14.CreationId(){ Val = (UInt32Value)1306565808U };
            creationId16.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension16.Append(creationId16);

            commonSlideDataExtensionList16.Append(commonSlideDataExtension16);

            commonSlideData16.Append(shapeTree16);
            commonSlideData16.Append(commonSlideDataExtensionList16);

            ColorMapOverride colorMapOverride15 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping15 = new A.MasterColorMapping();

            colorMapOverride15.Append(masterColorMapping15);

            Timing timing16 = new Timing();

            TimeNodeList timeNodeList16 = new TimeNodeList();

            ParallelTimeNode parallelTimeNode16 = new ParallelTimeNode();
            CommonTimeNode commonTimeNode16 = new CommonTimeNode(){ Id = (UInt32Value)1U, Duration = "indefinite", Restart = TimeNodeRestartValues.Never, NodeType = TimeNodeValues.TmingRoot };

            parallelTimeNode16.Append(commonTimeNode16);

            timeNodeList16.Append(parallelTimeNode16);

            timing16.Append(timeNodeList16);

            slideLayout14.Append(commonSlideData16);
            slideLayout14.Append(colorMapOverride15);
            slideLayout14.Append(timing16);

            slideLayoutPart14.SlideLayout = slideLayout14;
        }

        // Generates content of slideLayoutPart15.
        private void GenerateSlideLayoutPart15Content(SlideLayoutPart slideLayoutPart15)
        {
            SlideLayout slideLayout15 = new SlideLayout(){ Type = SlideLayoutValues.TwoObjects, Preserve = true };
            slideLayout15.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout15.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout15.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData17 = new CommonSlideData(){ Name = "Two Content" };

            ShapeTree shapeTree17 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties17 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties170 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties17 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties170 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties17.Append(nonVisualDrawingProperties170);
            nonVisualGroupShapeProperties17.Append(nonVisualGroupShapeDrawingProperties17);
            nonVisualGroupShapeProperties17.Append(applicationNonVisualDrawingProperties170);

            GroupShapeProperties groupShapeProperties17 = new GroupShapeProperties();

            A.TransformGroup transformGroup17 = new A.TransformGroup();
            A.Offset offset119 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents119 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset17 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents17 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup17.Append(offset119);
            transformGroup17.Append(extents119);
            transformGroup17.Append(childOffset17);
            transformGroup17.Append(childExtents17);

            groupShapeProperties17.Append(transformGroup17);

            Shape shape84 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties84 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties171 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties84 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks82 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties84.Append(shapeLocks82);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties171 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape82 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties171.Append(placeholderShape82);

            nonVisualShapeProperties84.Append(nonVisualDrawingProperties171);
            nonVisualShapeProperties84.Append(nonVisualShapeDrawingProperties84);
            nonVisualShapeProperties84.Append(applicationNonVisualDrawingProperties171);
            ShapeProperties shapeProperties154 = new ShapeProperties();

            TextBody textBody84 = new TextBody();
            A.BodyProperties bodyProperties84 = new A.BodyProperties();
            A.ListStyle listStyle84 = new A.ListStyle();

            A.Paragraph paragraph112 = new A.Paragraph();

            A.Run run68 = new A.Run();

            A.RunProperties runProperties98 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties98.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text98 = new A.Text();
            text98.Text = "Click to edit Master title style";

            run68.Append(runProperties98);
            run68.Append(text98);
            A.EndParagraphRunProperties endParagraphRunProperties73 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph112.Append(run68);
            paragraph112.Append(endParagraphRunProperties73);

            textBody84.Append(bodyProperties84);
            textBody84.Append(listStyle84);
            textBody84.Append(paragraph112);

            shape84.Append(nonVisualShapeProperties84);
            shape84.Append(shapeProperties154);
            shape84.Append(textBody84);

            Shape shape85 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties85 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties172 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Content Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties85 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks83 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties85.Append(shapeLocks83);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties172 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape83 = new PlaceholderShape(){ Size = PlaceholderSizeValues.Half, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties172.Append(placeholderShape83);

            nonVisualShapeProperties85.Append(nonVisualDrawingProperties172);
            nonVisualShapeProperties85.Append(nonVisualShapeDrawingProperties85);
            nonVisualShapeProperties85.Append(applicationNonVisualDrawingProperties172);

            ShapeProperties shapeProperties155 = new ShapeProperties();

            A.Transform2D transform2D103 = new A.Transform2D();
            A.Offset offset120 = new A.Offset(){ X = 684390L, Y = 685801L };
            A.Extents extents120 = new A.Extents(){ Cx = 4938941L, Cy = 3615267L };

            transform2D103.Append(offset120);
            transform2D103.Append(extents120);

            shapeProperties155.Append(transform2D103);

            TextBody textBody85 = new TextBody();

            A.BodyProperties bodyProperties85 = new A.BodyProperties();
            A.NormalAutoFit normalAutoFit23 = new A.NormalAutoFit();

            bodyProperties85.Append(normalAutoFit23);

            A.ListStyle listStyle85 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties36 = new A.Level1ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties202 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level1ParagraphProperties36.Append(defaultRunProperties202);

            A.Level2ParagraphProperties level2ParagraphProperties23 = new A.Level2ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties203 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level2ParagraphProperties23.Append(defaultRunProperties203);

            A.Level3ParagraphProperties level3ParagraphProperties23 = new A.Level3ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties204 = new A.DefaultRunProperties(){ FontSize = 1400 };

            level3ParagraphProperties23.Append(defaultRunProperties204);

            A.Level4ParagraphProperties level4ParagraphProperties23 = new A.Level4ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties205 = new A.DefaultRunProperties(){ FontSize = 1200 };

            level4ParagraphProperties23.Append(defaultRunProperties205);

            A.Level5ParagraphProperties level5ParagraphProperties23 = new A.Level5ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties206 = new A.DefaultRunProperties(){ FontSize = 1200 };

            level5ParagraphProperties23.Append(defaultRunProperties206);

            A.Level6ParagraphProperties level6ParagraphProperties20 = new A.Level6ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties207 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level6ParagraphProperties20.Append(defaultRunProperties207);

            A.Level7ParagraphProperties level7ParagraphProperties20 = new A.Level7ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties208 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level7ParagraphProperties20.Append(defaultRunProperties208);

            A.Level8ParagraphProperties level8ParagraphProperties20 = new A.Level8ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties209 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level8ParagraphProperties20.Append(defaultRunProperties209);

            A.Level9ParagraphProperties level9ParagraphProperties20 = new A.Level9ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties210 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level9ParagraphProperties20.Append(defaultRunProperties210);

            listStyle85.Append(level1ParagraphProperties36);
            listStyle85.Append(level2ParagraphProperties23);
            listStyle85.Append(level3ParagraphProperties23);
            listStyle85.Append(level4ParagraphProperties23);
            listStyle85.Append(level5ParagraphProperties23);
            listStyle85.Append(level6ParagraphProperties20);
            listStyle85.Append(level7ParagraphProperties20);
            listStyle85.Append(level8ParagraphProperties20);
            listStyle85.Append(level9ParagraphProperties20);

            A.Paragraph paragraph113 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties50 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run69 = new A.Run();

            A.RunProperties runProperties99 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties99.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text99 = new A.Text();
            text99.Text = "Click to edit Master text styles";

            run69.Append(runProperties99);
            run69.Append(text99);

            paragraph113.Append(paragraphProperties50);
            paragraph113.Append(run69);

            A.Paragraph paragraph114 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties51 = new A.ParagraphProperties(){ Level = 1 };

            A.Run run70 = new A.Run();

            A.RunProperties runProperties100 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties100.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text100 = new A.Text();
            text100.Text = "Second level";

            run70.Append(runProperties100);
            run70.Append(text100);

            paragraph114.Append(paragraphProperties51);
            paragraph114.Append(run70);

            A.Paragraph paragraph115 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties52 = new A.ParagraphProperties(){ Level = 2 };

            A.Run run71 = new A.Run();

            A.RunProperties runProperties101 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties101.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text101 = new A.Text();
            text101.Text = "Third level";

            run71.Append(runProperties101);
            run71.Append(text101);

            paragraph115.Append(paragraphProperties52);
            paragraph115.Append(run71);

            A.Paragraph paragraph116 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties53 = new A.ParagraphProperties(){ Level = 3 };

            A.Run run72 = new A.Run();

            A.RunProperties runProperties102 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties102.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text102 = new A.Text();
            text102.Text = "Fourth level";

            run72.Append(runProperties102);
            run72.Append(text102);

            paragraph116.Append(paragraphProperties53);
            paragraph116.Append(run72);

            A.Paragraph paragraph117 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties54 = new A.ParagraphProperties(){ Level = 4 };

            A.Run run73 = new A.Run();

            A.RunProperties runProperties103 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties103.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text103 = new A.Text();
            text103.Text = "Fifth level";

            run73.Append(runProperties103);
            run73.Append(text103);
            A.EndParagraphRunProperties endParagraphRunProperties74 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph117.Append(paragraphProperties54);
            paragraph117.Append(run73);
            paragraph117.Append(endParagraphRunProperties74);

            textBody85.Append(bodyProperties85);
            textBody85.Append(listStyle85);
            textBody85.Append(paragraph113);
            textBody85.Append(paragraph114);
            textBody85.Append(paragraph115);
            textBody85.Append(paragraph116);
            textBody85.Append(paragraph117);

            shape85.Append(nonVisualShapeProperties85);
            shape85.Append(shapeProperties155);
            shape85.Append(textBody85);

            Shape shape86 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties86 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties173 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Content Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties86 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks84 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties86.Append(shapeLocks84);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties173 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape84 = new PlaceholderShape(){ Size = PlaceholderSizeValues.Half, Index = (UInt32Value)2U };

            applicationNonVisualDrawingProperties173.Append(placeholderShape84);

            nonVisualShapeProperties86.Append(nonVisualDrawingProperties173);
            nonVisualShapeProperties86.Append(nonVisualShapeDrawingProperties86);
            nonVisualShapeProperties86.Append(applicationNonVisualDrawingProperties173);

            ShapeProperties shapeProperties156 = new ShapeProperties();

            A.Transform2D transform2D104 = new A.Transform2D();
            A.Offset offset121 = new A.Offset(){ X = 5809647L, Y = 685801L };
            A.Extents extents121 = new A.Extents(){ Cx = 4935764L, Cy = 3615266L };

            transform2D104.Append(offset121);
            transform2D104.Append(extents121);

            shapeProperties156.Append(transform2D104);

            TextBody textBody86 = new TextBody();

            A.BodyProperties bodyProperties86 = new A.BodyProperties();
            A.NormalAutoFit normalAutoFit24 = new A.NormalAutoFit();

            bodyProperties86.Append(normalAutoFit24);

            A.ListStyle listStyle86 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties37 = new A.Level1ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties211 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level1ParagraphProperties37.Append(defaultRunProperties211);

            A.Level2ParagraphProperties level2ParagraphProperties24 = new A.Level2ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties212 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level2ParagraphProperties24.Append(defaultRunProperties212);

            A.Level3ParagraphProperties level3ParagraphProperties24 = new A.Level3ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties213 = new A.DefaultRunProperties(){ FontSize = 1400 };

            level3ParagraphProperties24.Append(defaultRunProperties213);

            A.Level4ParagraphProperties level4ParagraphProperties24 = new A.Level4ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties214 = new A.DefaultRunProperties(){ FontSize = 1200 };

            level4ParagraphProperties24.Append(defaultRunProperties214);

            A.Level5ParagraphProperties level5ParagraphProperties24 = new A.Level5ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties215 = new A.DefaultRunProperties(){ FontSize = 1200 };

            level5ParagraphProperties24.Append(defaultRunProperties215);

            A.Level6ParagraphProperties level6ParagraphProperties21 = new A.Level6ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties216 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level6ParagraphProperties21.Append(defaultRunProperties216);

            A.Level7ParagraphProperties level7ParagraphProperties21 = new A.Level7ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties217 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level7ParagraphProperties21.Append(defaultRunProperties217);

            A.Level8ParagraphProperties level8ParagraphProperties21 = new A.Level8ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties218 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level8ParagraphProperties21.Append(defaultRunProperties218);

            A.Level9ParagraphProperties level9ParagraphProperties21 = new A.Level9ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties219 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level9ParagraphProperties21.Append(defaultRunProperties219);

            listStyle86.Append(level1ParagraphProperties37);
            listStyle86.Append(level2ParagraphProperties24);
            listStyle86.Append(level3ParagraphProperties24);
            listStyle86.Append(level4ParagraphProperties24);
            listStyle86.Append(level5ParagraphProperties24);
            listStyle86.Append(level6ParagraphProperties21);
            listStyle86.Append(level7ParagraphProperties21);
            listStyle86.Append(level8ParagraphProperties21);
            listStyle86.Append(level9ParagraphProperties21);

            A.Paragraph paragraph118 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties55 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run74 = new A.Run();

            A.RunProperties runProperties104 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties104.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text104 = new A.Text();
            text104.Text = "Click to edit Master text styles";

            run74.Append(runProperties104);
            run74.Append(text104);

            paragraph118.Append(paragraphProperties55);
            paragraph118.Append(run74);

            A.Paragraph paragraph119 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties56 = new A.ParagraphProperties(){ Level = 1 };

            A.Run run75 = new A.Run();

            A.RunProperties runProperties105 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties105.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text105 = new A.Text();
            text105.Text = "Second level";

            run75.Append(runProperties105);
            run75.Append(text105);

            paragraph119.Append(paragraphProperties56);
            paragraph119.Append(run75);

            A.Paragraph paragraph120 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties57 = new A.ParagraphProperties(){ Level = 2 };

            A.Run run76 = new A.Run();

            A.RunProperties runProperties106 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties106.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text106 = new A.Text();
            text106.Text = "Third level";

            run76.Append(runProperties106);
            run76.Append(text106);

            paragraph120.Append(paragraphProperties57);
            paragraph120.Append(run76);

            A.Paragraph paragraph121 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties58 = new A.ParagraphProperties(){ Level = 3 };

            A.Run run77 = new A.Run();

            A.RunProperties runProperties107 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties107.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text107 = new A.Text();
            text107.Text = "Fourth level";

            run77.Append(runProperties107);
            run77.Append(text107);

            paragraph121.Append(paragraphProperties58);
            paragraph121.Append(run77);

            A.Paragraph paragraph122 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties59 = new A.ParagraphProperties(){ Level = 4 };

            A.Run run78 = new A.Run();

            A.RunProperties runProperties108 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties108.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text108 = new A.Text();
            text108.Text = "Fifth level";

            run78.Append(runProperties108);
            run78.Append(text108);
            A.EndParagraphRunProperties endParagraphRunProperties75 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph122.Append(paragraphProperties59);
            paragraph122.Append(run78);
            paragraph122.Append(endParagraphRunProperties75);

            textBody86.Append(bodyProperties86);
            textBody86.Append(listStyle86);
            textBody86.Append(paragraph118);
            textBody86.Append(paragraph119);
            textBody86.Append(paragraph120);
            textBody86.Append(paragraph121);
            textBody86.Append(paragraph122);

            shape86.Append(nonVisualShapeProperties86);
            shape86.Append(shapeProperties156);
            shape86.Append(textBody86);

            Shape shape87 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties87 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties174 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Date Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties87 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks85 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties87.Append(shapeLocks85);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties174 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape85 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties174.Append(placeholderShape85);

            nonVisualShapeProperties87.Append(nonVisualDrawingProperties174);
            nonVisualShapeProperties87.Append(nonVisualShapeDrawingProperties87);
            nonVisualShapeProperties87.Append(applicationNonVisualDrawingProperties174);
            ShapeProperties shapeProperties157 = new ShapeProperties();

            TextBody textBody87 = new TextBody();
            A.BodyProperties bodyProperties87 = new A.BodyProperties();
            A.ListStyle listStyle87 = new A.ListStyle();

            A.Paragraph paragraph123 = new A.Paragraph();

            A.Field field31 = new A.Field(){ Id = "{CE1A2D98-1BBD-4706-A118-AAC2A16BEAD3}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties109 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties109.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text109 = new A.Text();
            text109.Text = "2012/10/3";

            field31.Append(runProperties109);
            field31.Append(text109);
            A.EndParagraphRunProperties endParagraphRunProperties76 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph123.Append(field31);
            paragraph123.Append(endParagraphRunProperties76);

            textBody87.Append(bodyProperties87);
            textBody87.Append(listStyle87);
            textBody87.Append(paragraph123);

            shape87.Append(nonVisualShapeProperties87);
            shape87.Append(shapeProperties157);
            shape87.Append(textBody87);

            Shape shape88 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties88 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties175 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Footer Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties88 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks86 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties88.Append(shapeLocks86);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties175 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape86 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties175.Append(placeholderShape86);

            nonVisualShapeProperties88.Append(nonVisualDrawingProperties175);
            nonVisualShapeProperties88.Append(nonVisualShapeDrawingProperties88);
            nonVisualShapeProperties88.Append(applicationNonVisualDrawingProperties175);
            ShapeProperties shapeProperties158 = new ShapeProperties();

            TextBody textBody88 = new TextBody();
            A.BodyProperties bodyProperties88 = new A.BodyProperties();
            A.ListStyle listStyle88 = new A.ListStyle();

            A.Paragraph paragraph124 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties77 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph124.Append(endParagraphRunProperties77);

            textBody88.Append(bodyProperties88);
            textBody88.Append(listStyle88);
            textBody88.Append(paragraph124);

            shape88.Append(nonVisualShapeProperties88);
            shape88.Append(shapeProperties158);
            shape88.Append(textBody88);

            Shape shape89 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties89 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties176 = new NonVisualDrawingProperties(){ Id = (UInt32Value)7U, Name = "Slide Number Placeholder 6" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties89 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks87 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties89.Append(shapeLocks87);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties176 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape87 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties176.Append(placeholderShape87);

            nonVisualShapeProperties89.Append(nonVisualDrawingProperties176);
            nonVisualShapeProperties89.Append(nonVisualShapeDrawingProperties89);
            nonVisualShapeProperties89.Append(applicationNonVisualDrawingProperties176);
            ShapeProperties shapeProperties159 = new ShapeProperties();

            TextBody textBody89 = new TextBody();
            A.BodyProperties bodyProperties89 = new A.BodyProperties();
            A.ListStyle listStyle89 = new A.ListStyle();

            A.Paragraph paragraph125 = new A.Paragraph();

            A.Field field32 = new A.Field(){ Id = "{D107CD50-7081-433F-A1F2-156B4E14F4F4}", Type = "slidenum" };

            A.RunProperties runProperties110 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties110.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text110 = new A.Text();
            text110.Text = "‹#›";

            field32.Append(runProperties110);
            field32.Append(text110);
            A.EndParagraphRunProperties endParagraphRunProperties78 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph125.Append(field32);
            paragraph125.Append(endParagraphRunProperties78);

            textBody89.Append(bodyProperties89);
            textBody89.Append(listStyle89);
            textBody89.Append(paragraph125);

            shape89.Append(nonVisualShapeProperties89);
            shape89.Append(shapeProperties159);
            shape89.Append(textBody89);

            ConnectionShape connectionShape71 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties71 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties177 = new NonVisualDrawingProperties(){ Id = (UInt32Value)8U, Name = "Straight Connector 7" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties71 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties177 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties71.Append(nonVisualDrawingProperties177);
            nonVisualConnectionShapeProperties71.Append(nonVisualConnectorShapeDrawingProperties71);
            nonVisualConnectionShapeProperties71.Append(applicationNonVisualDrawingProperties177);

            ShapeProperties shapeProperties160 = new ShapeProperties();

            A.Transform2D transform2D105 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset122 = new A.Offset(){ X = 11278949L, Y = 2963333L };
            A.Extents extents122 = new A.Extents(){ Cx = 913052L, Cy = 912812L };

            transform2D105.Append(offset122);
            transform2D105.Append(extents122);

            A.PresetGeometry presetGeometry79 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList79 = new A.AdjustValueList();

            presetGeometry79.Append(adjustValueList79);

            A.Outline outline79 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill194 = new A.SolidFill();
            A.SchemeColor schemeColor490 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill194.Append(schemeColor490);

            outline79.Append(solidFill194);

            shapeProperties160.Append(transform2D105);
            shapeProperties160.Append(presetGeometry79);
            shapeProperties160.Append(outline79);

            ShapeStyle shapeStyle71 = new ShapeStyle();

            A.LineReference lineReference71 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor491 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference71.Append(schemeColor491);

            A.FillReference fillReference71 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor492 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference71.Append(schemeColor492);

            A.EffectReference effectReference71 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor493 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference71.Append(schemeColor493);

            A.FontReference fontReference71 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor494 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference71.Append(schemeColor494);

            shapeStyle71.Append(lineReference71);
            shapeStyle71.Append(fillReference71);
            shapeStyle71.Append(effectReference71);
            shapeStyle71.Append(fontReference71);

            connectionShape71.Append(nonVisualConnectionShapeProperties71);
            connectionShape71.Append(shapeProperties160);
            connectionShape71.Append(shapeStyle71);

            ConnectionShape connectionShape72 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties72 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties178 = new NonVisualDrawingProperties(){ Id = (UInt32Value)9U, Name = "Straight Connector 8" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties72 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties178 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties72.Append(nonVisualDrawingProperties178);
            nonVisualConnectionShapeProperties72.Append(nonVisualConnectorShapeDrawingProperties72);
            nonVisualConnectionShapeProperties72.Append(applicationNonVisualDrawingProperties178);

            ShapeProperties shapeProperties161 = new ShapeProperties();

            A.Transform2D transform2D106 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset123 = new A.Offset(){ X = 9209368L, Y = 3190344L };
            A.Extents extents123 = new A.Extents(){ Cx = 2982634L, Cy = 2981856L };

            transform2D106.Append(offset123);
            transform2D106.Append(extents123);

            A.PresetGeometry presetGeometry80 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList80 = new A.AdjustValueList();

            presetGeometry80.Append(adjustValueList80);

            A.Outline outline80 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill195 = new A.SolidFill();
            A.SchemeColor schemeColor495 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill195.Append(schemeColor495);

            outline80.Append(solidFill195);

            shapeProperties161.Append(transform2D106);
            shapeProperties161.Append(presetGeometry80);
            shapeProperties161.Append(outline80);

            ShapeStyle shapeStyle72 = new ShapeStyle();

            A.LineReference lineReference72 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor496 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference72.Append(schemeColor496);

            A.FillReference fillReference72 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor497 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference72.Append(schemeColor497);

            A.EffectReference effectReference72 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor498 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference72.Append(schemeColor498);

            A.FontReference fontReference72 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor499 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference72.Append(schemeColor499);

            shapeStyle72.Append(lineReference72);
            shapeStyle72.Append(fillReference72);
            shapeStyle72.Append(effectReference72);
            shapeStyle72.Append(fontReference72);

            connectionShape72.Append(nonVisualConnectionShapeProperties72);
            connectionShape72.Append(shapeProperties161);
            connectionShape72.Append(shapeStyle72);

            ConnectionShape connectionShape73 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties73 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties179 = new NonVisualDrawingProperties(){ Id = (UInt32Value)10U, Name = "Straight Connector 9" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties73 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties179 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties73.Append(nonVisualDrawingProperties179);
            nonVisualConnectionShapeProperties73.Append(nonVisualConnectorShapeDrawingProperties73);
            nonVisualConnectionShapeProperties73.Append(applicationNonVisualDrawingProperties179);

            ShapeProperties shapeProperties162 = new ShapeProperties();

            A.Transform2D transform2D107 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset124 = new A.Offset(){ X = 10294973L, Y = 3285068L };
            A.Extents extents124 = new A.Extents(){ Cx = 1897028L, Cy = 1896533L };

            transform2D107.Append(offset124);
            transform2D107.Append(extents124);

            A.PresetGeometry presetGeometry81 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList81 = new A.AdjustValueList();

            presetGeometry81.Append(adjustValueList81);

            A.Outline outline81 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill196 = new A.SolidFill();
            A.SchemeColor schemeColor500 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill196.Append(schemeColor500);

            outline81.Append(solidFill196);

            shapeProperties162.Append(transform2D107);
            shapeProperties162.Append(presetGeometry81);
            shapeProperties162.Append(outline81);

            ShapeStyle shapeStyle73 = new ShapeStyle();

            A.LineReference lineReference73 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor501 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference73.Append(schemeColor501);

            A.FillReference fillReference73 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor502 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference73.Append(schemeColor502);

            A.EffectReference effectReference73 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor503 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference73.Append(schemeColor503);

            A.FontReference fontReference73 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor504 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference73.Append(schemeColor504);

            shapeStyle73.Append(lineReference73);
            shapeStyle73.Append(fillReference73);
            shapeStyle73.Append(effectReference73);
            shapeStyle73.Append(fontReference73);

            connectionShape73.Append(nonVisualConnectionShapeProperties73);
            connectionShape73.Append(shapeProperties162);
            connectionShape73.Append(shapeStyle73);

            ConnectionShape connectionShape74 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties74 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties180 = new NonVisualDrawingProperties(){ Id = (UInt32Value)11U, Name = "Straight Connector 10" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties74 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties180 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties74.Append(nonVisualDrawingProperties180);
            nonVisualConnectionShapeProperties74.Append(nonVisualConnectorShapeDrawingProperties74);
            nonVisualConnectionShapeProperties74.Append(applicationNonVisualDrawingProperties180);

            ShapeProperties shapeProperties163 = new ShapeProperties();

            A.Transform2D transform2D108 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset125 = new A.Offset(){ X = 10445823L, Y = 3131080L };
            A.Extents extents125 = new A.Extents(){ Cx = 1746177L, Cy = 1745720L };

            transform2D108.Append(offset125);
            transform2D108.Append(extents125);

            A.PresetGeometry presetGeometry82 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList82 = new A.AdjustValueList();

            presetGeometry82.Append(adjustValueList82);

            A.Outline outline82 = new A.Outline(){ Width = 28575 };

            A.SolidFill solidFill197 = new A.SolidFill();
            A.SchemeColor schemeColor505 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill197.Append(schemeColor505);

            outline82.Append(solidFill197);

            shapeProperties163.Append(transform2D108);
            shapeProperties163.Append(presetGeometry82);
            shapeProperties163.Append(outline82);

            ShapeStyle shapeStyle74 = new ShapeStyle();

            A.LineReference lineReference74 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor506 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference74.Append(schemeColor506);

            A.FillReference fillReference74 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor507 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference74.Append(schemeColor507);

            A.EffectReference effectReference74 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor508 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference74.Append(schemeColor508);

            A.FontReference fontReference74 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor509 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference74.Append(schemeColor509);

            shapeStyle74.Append(lineReference74);
            shapeStyle74.Append(fillReference74);
            shapeStyle74.Append(effectReference74);
            shapeStyle74.Append(fontReference74);

            connectionShape74.Append(nonVisualConnectionShapeProperties74);
            connectionShape74.Append(shapeProperties163);
            connectionShape74.Append(shapeStyle74);

            ConnectionShape connectionShape75 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties75 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties181 = new NonVisualDrawingProperties(){ Id = (UInt32Value)12U, Name = "Straight Connector 11" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties75 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties181 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties75.Append(nonVisualDrawingProperties181);
            nonVisualConnectionShapeProperties75.Append(nonVisualConnectorShapeDrawingProperties75);
            nonVisualConnectionShapeProperties75.Append(applicationNonVisualDrawingProperties181);

            ShapeProperties shapeProperties164 = new ShapeProperties();

            A.Transform2D transform2D109 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset126 = new A.Offset(){ X = 10921671L, Y = 3683002L };
            A.Extents extents126 = new A.Extents(){ Cx = 1270332L, Cy = 1269999L };

            transform2D109.Append(offset126);
            transform2D109.Append(extents126);

            A.PresetGeometry presetGeometry83 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList83 = new A.AdjustValueList();

            presetGeometry83.Append(adjustValueList83);

            A.Outline outline83 = new A.Outline(){ Width = 28575 };

            A.SolidFill solidFill198 = new A.SolidFill();
            A.SchemeColor schemeColor510 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill198.Append(schemeColor510);

            outline83.Append(solidFill198);

            shapeProperties164.Append(transform2D109);
            shapeProperties164.Append(presetGeometry83);
            shapeProperties164.Append(outline83);

            ShapeStyle shapeStyle75 = new ShapeStyle();

            A.LineReference lineReference75 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor511 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference75.Append(schemeColor511);

            A.FillReference fillReference75 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor512 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference75.Append(schemeColor512);

            A.EffectReference effectReference75 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor513 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference75.Append(schemeColor513);

            A.FontReference fontReference75 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor514 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference75.Append(schemeColor514);

            shapeStyle75.Append(lineReference75);
            shapeStyle75.Append(fillReference75);
            shapeStyle75.Append(effectReference75);
            shapeStyle75.Append(fontReference75);

            connectionShape75.Append(nonVisualConnectionShapeProperties75);
            connectionShape75.Append(shapeProperties164);
            connectionShape75.Append(shapeStyle75);

            shapeTree17.Append(nonVisualGroupShapeProperties17);
            shapeTree17.Append(groupShapeProperties17);
            shapeTree17.Append(shape84);
            shapeTree17.Append(shape85);
            shapeTree17.Append(shape86);
            shapeTree17.Append(shape87);
            shapeTree17.Append(shape88);
            shapeTree17.Append(shape89);
            shapeTree17.Append(connectionShape71);
            shapeTree17.Append(connectionShape72);
            shapeTree17.Append(connectionShape73);
            shapeTree17.Append(connectionShape74);
            shapeTree17.Append(connectionShape75);

            CommonSlideDataExtensionList commonSlideDataExtensionList17 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension17 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId17 = new P14.CreationId(){ Val = (UInt32Value)681784127U };
            creationId17.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension17.Append(creationId17);

            commonSlideDataExtensionList17.Append(commonSlideDataExtension17);

            commonSlideData17.Append(shapeTree17);
            commonSlideData17.Append(commonSlideDataExtensionList17);

            ColorMapOverride colorMapOverride16 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping16 = new A.MasterColorMapping();

            colorMapOverride16.Append(masterColorMapping16);

            Timing timing17 = new Timing();

            TimeNodeList timeNodeList17 = new TimeNodeList();

            ParallelTimeNode parallelTimeNode17 = new ParallelTimeNode();
            CommonTimeNode commonTimeNode17 = new CommonTimeNode(){ Id = (UInt32Value)1U, Duration = "indefinite", Restart = TimeNodeRestartValues.Never, NodeType = TimeNodeValues.TmingRoot };

            parallelTimeNode17.Append(commonTimeNode17);

            timeNodeList17.Append(parallelTimeNode17);

            timing17.Append(timeNodeList17);

            slideLayout15.Append(commonSlideData17);
            slideLayout15.Append(colorMapOverride16);
            slideLayout15.Append(timing17);

            slideLayoutPart15.SlideLayout = slideLayout15;
        }

        // Generates content of slideLayoutPart16.
        private void GenerateSlideLayoutPart16Content(SlideLayoutPart slideLayoutPart16)
        {
            SlideLayout slideLayout16 = new SlideLayout(){ Preserve = true };
            slideLayout16.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout16.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout16.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData18 = new CommonSlideData(){ Name = "Picture with Caption" };

            ShapeTree shapeTree18 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties18 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties182 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties18 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties182 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties18.Append(nonVisualDrawingProperties182);
            nonVisualGroupShapeProperties18.Append(nonVisualGroupShapeDrawingProperties18);
            nonVisualGroupShapeProperties18.Append(applicationNonVisualDrawingProperties182);

            GroupShapeProperties groupShapeProperties18 = new GroupShapeProperties();

            A.TransformGroup transformGroup18 = new A.TransformGroup();
            A.Offset offset127 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents127 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset18 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents18 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup18.Append(offset127);
            transformGroup18.Append(extents127);
            transformGroup18.Append(childOffset18);
            transformGroup18.Append(childExtents18);

            groupShapeProperties18.Append(transformGroup18);

            Shape shape90 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties90 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties183 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties90 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks88 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties90.Append(shapeLocks88);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties183 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape88 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties183.Append(placeholderShape88);

            nonVisualShapeProperties90.Append(nonVisualDrawingProperties183);
            nonVisualShapeProperties90.Append(nonVisualShapeDrawingProperties90);
            nonVisualShapeProperties90.Append(applicationNonVisualDrawingProperties183);

            ShapeProperties shapeProperties165 = new ShapeProperties();

            A.Transform2D transform2D110 = new A.Transform2D();
            A.Offset offset128 = new A.Offset(){ X = 4724042L, Y = 1447800L };
            A.Extents extents128 = new A.Extents(){ Cx = 6021368L, Cy = 1143000L };

            transform2D110.Append(offset128);
            transform2D110.Append(extents128);

            shapeProperties165.Append(transform2D110);

            TextBody textBody90 = new TextBody();

            A.BodyProperties bodyProperties90 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Bottom };
            A.NormalAutoFit normalAutoFit25 = new A.NormalAutoFit();

            bodyProperties90.Append(normalAutoFit25);

            A.ListStyle listStyle90 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties38 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Left };
            A.DefaultRunProperties defaultRunProperties220 = new A.DefaultRunProperties(){ FontSize = 2800, Bold = false };

            level1ParagraphProperties38.Append(defaultRunProperties220);

            listStyle90.Append(level1ParagraphProperties38);

            A.Paragraph paragraph126 = new A.Paragraph();

            A.Run run79 = new A.Run();

            A.RunProperties runProperties111 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties111.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text111 = new A.Text();
            text111.Text = "Click to edit Master title style";

            run79.Append(runProperties111);
            run79.Append(text111);
            A.EndParagraphRunProperties endParagraphRunProperties79 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph126.Append(run79);
            paragraph126.Append(endParagraphRunProperties79);

            textBody90.Append(bodyProperties90);
            textBody90.Append(listStyle90);
            textBody90.Append(paragraph126);

            shape90.Append(nonVisualShapeProperties90);
            shape90.Append(shapeProperties165);
            shape90.Append(textBody90);

            Shape shape91 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties91 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties184 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Text Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties91 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks89 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties91.Append(shapeLocks89);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties184 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape89 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)2U };

            applicationNonVisualDrawingProperties184.Append(placeholderShape89);

            nonVisualShapeProperties91.Append(nonVisualDrawingProperties184);
            nonVisualShapeProperties91.Append(nonVisualShapeDrawingProperties91);
            nonVisualShapeProperties91.Append(applicationNonVisualDrawingProperties184);

            ShapeProperties shapeProperties166 = new ShapeProperties();

            A.Transform2D transform2D111 = new A.Transform2D();
            A.Offset offset129 = new A.Offset(){ X = 4724042L, Y = 2777067L };
            A.Extents extents129 = new A.Extents(){ Cx = 6022956L, Cy = 2048933L };

            transform2D111.Append(offset129);
            transform2D111.Append(extents129);

            shapeProperties166.Append(transform2D111);

            TextBody textBody91 = new TextBody();

            A.BodyProperties bodyProperties91 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Top };
            A.NormalAutoFit normalAutoFit26 = new A.NormalAutoFit();

            bodyProperties91.Append(normalAutoFit26);

            A.ListStyle listStyle91 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties39 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0 };
            A.NoBullet noBullet105 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties221 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level1ParagraphProperties39.Append(noBullet105);
            level1ParagraphProperties39.Append(defaultRunProperties221);

            A.Level2ParagraphProperties level2ParagraphProperties25 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Indent = 0 };
            A.NoBullet noBullet106 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties222 = new A.DefaultRunProperties(){ FontSize = 1200 };

            level2ParagraphProperties25.Append(noBullet106);
            level2ParagraphProperties25.Append(defaultRunProperties222);

            A.Level3ParagraphProperties level3ParagraphProperties25 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Indent = 0 };
            A.NoBullet noBullet107 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties223 = new A.DefaultRunProperties(){ FontSize = 1000 };

            level3ParagraphProperties25.Append(noBullet107);
            level3ParagraphProperties25.Append(defaultRunProperties223);

            A.Level4ParagraphProperties level4ParagraphProperties25 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Indent = 0 };
            A.NoBullet noBullet108 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties224 = new A.DefaultRunProperties(){ FontSize = 900 };

            level4ParagraphProperties25.Append(noBullet108);
            level4ParagraphProperties25.Append(defaultRunProperties224);

            A.Level5ParagraphProperties level5ParagraphProperties25 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Indent = 0 };
            A.NoBullet noBullet109 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties225 = new A.DefaultRunProperties(){ FontSize = 900 };

            level5ParagraphProperties25.Append(noBullet109);
            level5ParagraphProperties25.Append(defaultRunProperties225);

            A.Level6ParagraphProperties level6ParagraphProperties22 = new A.Level6ParagraphProperties(){ LeftMargin = 2286000, Indent = 0 };
            A.NoBullet noBullet110 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties226 = new A.DefaultRunProperties(){ FontSize = 900 };

            level6ParagraphProperties22.Append(noBullet110);
            level6ParagraphProperties22.Append(defaultRunProperties226);

            A.Level7ParagraphProperties level7ParagraphProperties22 = new A.Level7ParagraphProperties(){ LeftMargin = 2743200, Indent = 0 };
            A.NoBullet noBullet111 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties227 = new A.DefaultRunProperties(){ FontSize = 900 };

            level7ParagraphProperties22.Append(noBullet111);
            level7ParagraphProperties22.Append(defaultRunProperties227);

            A.Level8ParagraphProperties level8ParagraphProperties22 = new A.Level8ParagraphProperties(){ LeftMargin = 3200400, Indent = 0 };
            A.NoBullet noBullet112 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties228 = new A.DefaultRunProperties(){ FontSize = 900 };

            level8ParagraphProperties22.Append(noBullet112);
            level8ParagraphProperties22.Append(defaultRunProperties228);

            A.Level9ParagraphProperties level9ParagraphProperties22 = new A.Level9ParagraphProperties(){ LeftMargin = 3657600, Indent = 0 };
            A.NoBullet noBullet113 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties229 = new A.DefaultRunProperties(){ FontSize = 900 };

            level9ParagraphProperties22.Append(noBullet113);
            level9ParagraphProperties22.Append(defaultRunProperties229);

            listStyle91.Append(level1ParagraphProperties39);
            listStyle91.Append(level2ParagraphProperties25);
            listStyle91.Append(level3ParagraphProperties25);
            listStyle91.Append(level4ParagraphProperties25);
            listStyle91.Append(level5ParagraphProperties25);
            listStyle91.Append(level6ParagraphProperties22);
            listStyle91.Append(level7ParagraphProperties22);
            listStyle91.Append(level8ParagraphProperties22);
            listStyle91.Append(level9ParagraphProperties22);

            A.Paragraph paragraph127 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties60 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run80 = new A.Run();

            A.RunProperties runProperties112 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties112.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text112 = new A.Text();
            text112.Text = "Click to edit Master text styles";

            run80.Append(runProperties112);
            run80.Append(text112);

            paragraph127.Append(paragraphProperties60);
            paragraph127.Append(run80);

            textBody91.Append(bodyProperties91);
            textBody91.Append(listStyle91);
            textBody91.Append(paragraph127);

            shape91.Append(nonVisualShapeProperties91);
            shape91.Append(shapeProperties166);
            shape91.Append(textBody91);

            Shape shape92 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties92 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties185 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Date Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties92 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks90 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties92.Append(shapeLocks90);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties185 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape90 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties185.Append(placeholderShape90);

            nonVisualShapeProperties92.Append(nonVisualDrawingProperties185);
            nonVisualShapeProperties92.Append(nonVisualShapeDrawingProperties92);
            nonVisualShapeProperties92.Append(applicationNonVisualDrawingProperties185);
            ShapeProperties shapeProperties167 = new ShapeProperties();

            TextBody textBody92 = new TextBody();
            A.BodyProperties bodyProperties92 = new A.BodyProperties();
            A.ListStyle listStyle92 = new A.ListStyle();

            A.Paragraph paragraph128 = new A.Paragraph();

            A.Field field33 = new A.Field(){ Id = "{CE1A2D98-1BBD-4706-A118-AAC2A16BEAD3}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties113 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties113.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text113 = new A.Text();
            text113.Text = "2012/10/3";

            field33.Append(runProperties113);
            field33.Append(text113);
            A.EndParagraphRunProperties endParagraphRunProperties80 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph128.Append(field33);
            paragraph128.Append(endParagraphRunProperties80);

            textBody92.Append(bodyProperties92);
            textBody92.Append(listStyle92);
            textBody92.Append(paragraph128);

            shape92.Append(nonVisualShapeProperties92);
            shape92.Append(shapeProperties167);
            shape92.Append(textBody92);

            Shape shape93 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties93 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties186 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Footer Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties93 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks91 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties93.Append(shapeLocks91);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties186 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape91 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties186.Append(placeholderShape91);

            nonVisualShapeProperties93.Append(nonVisualDrawingProperties186);
            nonVisualShapeProperties93.Append(nonVisualShapeDrawingProperties93);
            nonVisualShapeProperties93.Append(applicationNonVisualDrawingProperties186);
            ShapeProperties shapeProperties168 = new ShapeProperties();

            TextBody textBody93 = new TextBody();
            A.BodyProperties bodyProperties93 = new A.BodyProperties();
            A.ListStyle listStyle93 = new A.ListStyle();

            A.Paragraph paragraph129 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties81 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph129.Append(endParagraphRunProperties81);

            textBody93.Append(bodyProperties93);
            textBody93.Append(listStyle93);
            textBody93.Append(paragraph129);

            shape93.Append(nonVisualShapeProperties93);
            shape93.Append(shapeProperties168);
            shape93.Append(textBody93);

            Shape shape94 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties94 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties187 = new NonVisualDrawingProperties(){ Id = (UInt32Value)7U, Name = "Slide Number Placeholder 6" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties94 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks92 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties94.Append(shapeLocks92);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties187 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape92 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties187.Append(placeholderShape92);

            nonVisualShapeProperties94.Append(nonVisualDrawingProperties187);
            nonVisualShapeProperties94.Append(nonVisualShapeDrawingProperties94);
            nonVisualShapeProperties94.Append(applicationNonVisualDrawingProperties187);
            ShapeProperties shapeProperties169 = new ShapeProperties();

            TextBody textBody94 = new TextBody();
            A.BodyProperties bodyProperties94 = new A.BodyProperties();
            A.ListStyle listStyle94 = new A.ListStyle();

            A.Paragraph paragraph130 = new A.Paragraph();

            A.Field field34 = new A.Field(){ Id = "{D107CD50-7081-433F-A1F2-156B4E14F4F4}", Type = "slidenum" };

            A.RunProperties runProperties114 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties114.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text114 = new A.Text();
            text114.Text = "‹#›";

            field34.Append(runProperties114);
            field34.Append(text114);
            A.EndParagraphRunProperties endParagraphRunProperties82 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph130.Append(field34);
            paragraph130.Append(endParagraphRunProperties82);

            textBody94.Append(bodyProperties94);
            textBody94.Append(listStyle94);
            textBody94.Append(paragraph130);

            shape94.Append(nonVisualShapeProperties94);
            shape94.Append(shapeProperties169);
            shape94.Append(textBody94);

            Shape shape95 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties95 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties188 = new NonVisualDrawingProperties(){ Id = (UInt32Value)14U, Name = "Picture Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties95 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks93 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties95.Append(shapeLocks93);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties188 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape93 = new PlaceholderShape(){ Type = PlaceholderValues.Picture, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties188.Append(placeholderShape93);

            nonVisualShapeProperties95.Append(nonVisualDrawingProperties188);
            nonVisualShapeProperties95.Append(nonVisualShapeDrawingProperties95);
            nonVisualShapeProperties95.Append(applicationNonVisualDrawingProperties188);

            ShapeProperties shapeProperties170 = new ShapeProperties();

            A.Transform2D transform2D112 = new A.Transform2D();
            A.Offset offset130 = new A.Offset(){ X = 989269L, Y = 914400L };
            A.Extents extents130 = new A.Extents(){ Cx = 3281829L, Cy = 4572000L };

            transform2D112.Append(offset130);
            transform2D112.Append(extents130);

            A.PresetGeometry presetGeometry84 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Snip2DiagonalRectangle };

            A.AdjustValueList adjustValueList84 = new A.AdjustValueList();
            A.ShapeGuide shapeGuide3 = new A.ShapeGuide(){ Name = "adj1", Formula = "val 10815" };
            A.ShapeGuide shapeGuide4 = new A.ShapeGuide(){ Name = "adj2", Formula = "val 0" };

            adjustValueList84.Append(shapeGuide3);
            adjustValueList84.Append(shapeGuide4);

            presetGeometry84.Append(adjustValueList84);

            A.Outline outline84 = new A.Outline(){ Width = 15875 };

            A.SolidFill solidFill199 = new A.SolidFill();

            A.SchemeColor schemeColor515 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Alpha alpha10 = new A.Alpha(){ Val = 40000 };

            schemeColor515.Append(alpha10);

            solidFill199.Append(schemeColor515);

            outline84.Append(solidFill199);

            A.EffectList effectList23 = new A.EffectList();

            A.InnerShadow innerShadow3 = new A.InnerShadow(){ BlurRadius = 57150L, Distance = 38100L, Direction = 14460000 };

            A.RgbColorModelHex rgbColorModelHex16 = new A.RgbColorModelHex(){ Val = "000000" };
            A.Alpha alpha11 = new A.Alpha(){ Val = 70000 };

            rgbColorModelHex16.Append(alpha11);

            innerShadow3.Append(rgbColorModelHex16);

            effectList23.Append(innerShadow3);

            shapeProperties170.Append(transform2D112);
            shapeProperties170.Append(presetGeometry84);
            shapeProperties170.Append(outline84);
            shapeProperties170.Append(effectList23);

            TextBody textBody95 = new TextBody();

            A.BodyProperties bodyProperties95 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Center };
            A.NormalAutoFit normalAutoFit27 = new A.NormalAutoFit();

            bodyProperties95.Append(normalAutoFit27);

            A.ListStyle listStyle95 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties40 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet114 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties230 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level1ParagraphProperties40.Append(noBullet114);
            level1ParagraphProperties40.Append(defaultRunProperties230);

            A.Level2ParagraphProperties level2ParagraphProperties26 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Indent = 0 };
            A.NoBullet noBullet115 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties231 = new A.DefaultRunProperties(){ FontSize = 2800 };

            level2ParagraphProperties26.Append(noBullet115);
            level2ParagraphProperties26.Append(defaultRunProperties231);

            A.Level3ParagraphProperties level3ParagraphProperties26 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Indent = 0 };
            A.NoBullet noBullet116 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties232 = new A.DefaultRunProperties(){ FontSize = 2400 };

            level3ParagraphProperties26.Append(noBullet116);
            level3ParagraphProperties26.Append(defaultRunProperties232);

            A.Level4ParagraphProperties level4ParagraphProperties26 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Indent = 0 };
            A.NoBullet noBullet117 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties233 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level4ParagraphProperties26.Append(noBullet117);
            level4ParagraphProperties26.Append(defaultRunProperties233);

            A.Level5ParagraphProperties level5ParagraphProperties26 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Indent = 0 };
            A.NoBullet noBullet118 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties234 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level5ParagraphProperties26.Append(noBullet118);
            level5ParagraphProperties26.Append(defaultRunProperties234);

            A.Level6ParagraphProperties level6ParagraphProperties23 = new A.Level6ParagraphProperties(){ LeftMargin = 2286000, Indent = 0 };
            A.NoBullet noBullet119 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties235 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level6ParagraphProperties23.Append(noBullet119);
            level6ParagraphProperties23.Append(defaultRunProperties235);

            A.Level7ParagraphProperties level7ParagraphProperties23 = new A.Level7ParagraphProperties(){ LeftMargin = 2743200, Indent = 0 };
            A.NoBullet noBullet120 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties236 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level7ParagraphProperties23.Append(noBullet120);
            level7ParagraphProperties23.Append(defaultRunProperties236);

            A.Level8ParagraphProperties level8ParagraphProperties23 = new A.Level8ParagraphProperties(){ LeftMargin = 3200400, Indent = 0 };
            A.NoBullet noBullet121 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties237 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level8ParagraphProperties23.Append(noBullet121);
            level8ParagraphProperties23.Append(defaultRunProperties237);

            A.Level9ParagraphProperties level9ParagraphProperties23 = new A.Level9ParagraphProperties(){ LeftMargin = 3657600, Indent = 0 };
            A.NoBullet noBullet122 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties238 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level9ParagraphProperties23.Append(noBullet122);
            level9ParagraphProperties23.Append(defaultRunProperties238);

            listStyle95.Append(level1ParagraphProperties40);
            listStyle95.Append(level2ParagraphProperties26);
            listStyle95.Append(level3ParagraphProperties26);
            listStyle95.Append(level4ParagraphProperties26);
            listStyle95.Append(level5ParagraphProperties26);
            listStyle95.Append(level6ParagraphProperties23);
            listStyle95.Append(level7ParagraphProperties23);
            listStyle95.Append(level8ParagraphProperties23);
            listStyle95.Append(level9ParagraphProperties23);

            A.Paragraph paragraph131 = new A.Paragraph();

            A.Run run81 = new A.Run();

            A.RunProperties runProperties115 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties115.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text115 = new A.Text();
            text115.Text = "Click icon to add picture";

            run81.Append(runProperties115);
            run81.Append(text115);
            A.EndParagraphRunProperties endParagraphRunProperties83 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph131.Append(run81);
            paragraph131.Append(endParagraphRunProperties83);

            textBody95.Append(bodyProperties95);
            textBody95.Append(listStyle95);
            textBody95.Append(paragraph131);

            shape95.Append(nonVisualShapeProperties95);
            shape95.Append(shapeProperties170);
            shape95.Append(textBody95);

            ConnectionShape connectionShape76 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties76 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties189 = new NonVisualDrawingProperties(){ Id = (UInt32Value)8U, Name = "Straight Connector 7" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties76 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties189 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties76.Append(nonVisualDrawingProperties189);
            nonVisualConnectionShapeProperties76.Append(nonVisualConnectorShapeDrawingProperties76);
            nonVisualConnectionShapeProperties76.Append(applicationNonVisualDrawingProperties189);

            ShapeProperties shapeProperties171 = new ShapeProperties();

            A.Transform2D transform2D113 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset131 = new A.Offset(){ X = 11278949L, Y = 2963333L };
            A.Extents extents131 = new A.Extents(){ Cx = 913052L, Cy = 912812L };

            transform2D113.Append(offset131);
            transform2D113.Append(extents131);

            A.PresetGeometry presetGeometry85 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList85 = new A.AdjustValueList();

            presetGeometry85.Append(adjustValueList85);

            A.Outline outline85 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill200 = new A.SolidFill();
            A.SchemeColor schemeColor516 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill200.Append(schemeColor516);

            outline85.Append(solidFill200);

            shapeProperties171.Append(transform2D113);
            shapeProperties171.Append(presetGeometry85);
            shapeProperties171.Append(outline85);

            ShapeStyle shapeStyle76 = new ShapeStyle();

            A.LineReference lineReference76 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor517 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference76.Append(schemeColor517);

            A.FillReference fillReference76 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor518 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference76.Append(schemeColor518);

            A.EffectReference effectReference76 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor519 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference76.Append(schemeColor519);

            A.FontReference fontReference76 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor520 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference76.Append(schemeColor520);

            shapeStyle76.Append(lineReference76);
            shapeStyle76.Append(fillReference76);
            shapeStyle76.Append(effectReference76);
            shapeStyle76.Append(fontReference76);

            connectionShape76.Append(nonVisualConnectionShapeProperties76);
            connectionShape76.Append(shapeProperties171);
            connectionShape76.Append(shapeStyle76);

            ConnectionShape connectionShape77 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties77 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties190 = new NonVisualDrawingProperties(){ Id = (UInt32Value)9U, Name = "Straight Connector 8" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties77 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties190 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties77.Append(nonVisualDrawingProperties190);
            nonVisualConnectionShapeProperties77.Append(nonVisualConnectorShapeDrawingProperties77);
            nonVisualConnectionShapeProperties77.Append(applicationNonVisualDrawingProperties190);

            ShapeProperties shapeProperties172 = new ShapeProperties();

            A.Transform2D transform2D114 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset132 = new A.Offset(){ X = 9209368L, Y = 3190344L };
            A.Extents extents132 = new A.Extents(){ Cx = 2982634L, Cy = 2981856L };

            transform2D114.Append(offset132);
            transform2D114.Append(extents132);

            A.PresetGeometry presetGeometry86 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList86 = new A.AdjustValueList();

            presetGeometry86.Append(adjustValueList86);

            A.Outline outline86 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill201 = new A.SolidFill();
            A.SchemeColor schemeColor521 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill201.Append(schemeColor521);

            outline86.Append(solidFill201);

            shapeProperties172.Append(transform2D114);
            shapeProperties172.Append(presetGeometry86);
            shapeProperties172.Append(outline86);

            ShapeStyle shapeStyle77 = new ShapeStyle();

            A.LineReference lineReference77 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor522 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference77.Append(schemeColor522);

            A.FillReference fillReference77 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor523 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference77.Append(schemeColor523);

            A.EffectReference effectReference77 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor524 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference77.Append(schemeColor524);

            A.FontReference fontReference77 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor525 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference77.Append(schemeColor525);

            shapeStyle77.Append(lineReference77);
            shapeStyle77.Append(fillReference77);
            shapeStyle77.Append(effectReference77);
            shapeStyle77.Append(fontReference77);

            connectionShape77.Append(nonVisualConnectionShapeProperties77);
            connectionShape77.Append(shapeProperties172);
            connectionShape77.Append(shapeStyle77);

            ConnectionShape connectionShape78 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties78 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties191 = new NonVisualDrawingProperties(){ Id = (UInt32Value)10U, Name = "Straight Connector 9" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties78 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties191 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties78.Append(nonVisualDrawingProperties191);
            nonVisualConnectionShapeProperties78.Append(nonVisualConnectorShapeDrawingProperties78);
            nonVisualConnectionShapeProperties78.Append(applicationNonVisualDrawingProperties191);

            ShapeProperties shapeProperties173 = new ShapeProperties();

            A.Transform2D transform2D115 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset133 = new A.Offset(){ X = 10294973L, Y = 3285068L };
            A.Extents extents133 = new A.Extents(){ Cx = 1897028L, Cy = 1896533L };

            transform2D115.Append(offset133);
            transform2D115.Append(extents133);

            A.PresetGeometry presetGeometry87 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList87 = new A.AdjustValueList();

            presetGeometry87.Append(adjustValueList87);

            A.Outline outline87 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill202 = new A.SolidFill();
            A.SchemeColor schemeColor526 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill202.Append(schemeColor526);

            outline87.Append(solidFill202);

            shapeProperties173.Append(transform2D115);
            shapeProperties173.Append(presetGeometry87);
            shapeProperties173.Append(outline87);

            ShapeStyle shapeStyle78 = new ShapeStyle();

            A.LineReference lineReference78 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor527 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference78.Append(schemeColor527);

            A.FillReference fillReference78 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor528 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference78.Append(schemeColor528);

            A.EffectReference effectReference78 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor529 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference78.Append(schemeColor529);

            A.FontReference fontReference78 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor530 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference78.Append(schemeColor530);

            shapeStyle78.Append(lineReference78);
            shapeStyle78.Append(fillReference78);
            shapeStyle78.Append(effectReference78);
            shapeStyle78.Append(fontReference78);

            connectionShape78.Append(nonVisualConnectionShapeProperties78);
            connectionShape78.Append(shapeProperties173);
            connectionShape78.Append(shapeStyle78);

            ConnectionShape connectionShape79 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties79 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties192 = new NonVisualDrawingProperties(){ Id = (UInt32Value)11U, Name = "Straight Connector 10" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties79 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties192 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties79.Append(nonVisualDrawingProperties192);
            nonVisualConnectionShapeProperties79.Append(nonVisualConnectorShapeDrawingProperties79);
            nonVisualConnectionShapeProperties79.Append(applicationNonVisualDrawingProperties192);

            ShapeProperties shapeProperties174 = new ShapeProperties();

            A.Transform2D transform2D116 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset134 = new A.Offset(){ X = 10445823L, Y = 3131080L };
            A.Extents extents134 = new A.Extents(){ Cx = 1746177L, Cy = 1745720L };

            transform2D116.Append(offset134);
            transform2D116.Append(extents134);

            A.PresetGeometry presetGeometry88 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList88 = new A.AdjustValueList();

            presetGeometry88.Append(adjustValueList88);

            A.Outline outline88 = new A.Outline(){ Width = 28575 };

            A.SolidFill solidFill203 = new A.SolidFill();
            A.SchemeColor schemeColor531 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill203.Append(schemeColor531);

            outline88.Append(solidFill203);

            shapeProperties174.Append(transform2D116);
            shapeProperties174.Append(presetGeometry88);
            shapeProperties174.Append(outline88);

            ShapeStyle shapeStyle79 = new ShapeStyle();

            A.LineReference lineReference79 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor532 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference79.Append(schemeColor532);

            A.FillReference fillReference79 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor533 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference79.Append(schemeColor533);

            A.EffectReference effectReference79 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor534 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference79.Append(schemeColor534);

            A.FontReference fontReference79 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor535 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference79.Append(schemeColor535);

            shapeStyle79.Append(lineReference79);
            shapeStyle79.Append(fillReference79);
            shapeStyle79.Append(effectReference79);
            shapeStyle79.Append(fontReference79);

            connectionShape79.Append(nonVisualConnectionShapeProperties79);
            connectionShape79.Append(shapeProperties174);
            connectionShape79.Append(shapeStyle79);

            ConnectionShape connectionShape80 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties80 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties193 = new NonVisualDrawingProperties(){ Id = (UInt32Value)12U, Name = "Straight Connector 11" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties80 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties193 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties80.Append(nonVisualDrawingProperties193);
            nonVisualConnectionShapeProperties80.Append(nonVisualConnectorShapeDrawingProperties80);
            nonVisualConnectionShapeProperties80.Append(applicationNonVisualDrawingProperties193);

            ShapeProperties shapeProperties175 = new ShapeProperties();

            A.Transform2D transform2D117 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset135 = new A.Offset(){ X = 10921671L, Y = 3683002L };
            A.Extents extents135 = new A.Extents(){ Cx = 1270332L, Cy = 1269999L };

            transform2D117.Append(offset135);
            transform2D117.Append(extents135);

            A.PresetGeometry presetGeometry89 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList89 = new A.AdjustValueList();

            presetGeometry89.Append(adjustValueList89);

            A.Outline outline89 = new A.Outline(){ Width = 28575 };

            A.SolidFill solidFill204 = new A.SolidFill();
            A.SchemeColor schemeColor536 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill204.Append(schemeColor536);

            outline89.Append(solidFill204);

            shapeProperties175.Append(transform2D117);
            shapeProperties175.Append(presetGeometry89);
            shapeProperties175.Append(outline89);

            ShapeStyle shapeStyle80 = new ShapeStyle();

            A.LineReference lineReference80 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor537 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference80.Append(schemeColor537);

            A.FillReference fillReference80 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor538 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference80.Append(schemeColor538);

            A.EffectReference effectReference80 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor539 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference80.Append(schemeColor539);

            A.FontReference fontReference80 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor540 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference80.Append(schemeColor540);

            shapeStyle80.Append(lineReference80);
            shapeStyle80.Append(fillReference80);
            shapeStyle80.Append(effectReference80);
            shapeStyle80.Append(fontReference80);

            connectionShape80.Append(nonVisualConnectionShapeProperties80);
            connectionShape80.Append(shapeProperties175);
            connectionShape80.Append(shapeStyle80);

            shapeTree18.Append(nonVisualGroupShapeProperties18);
            shapeTree18.Append(groupShapeProperties18);
            shapeTree18.Append(shape90);
            shapeTree18.Append(shape91);
            shapeTree18.Append(shape92);
            shapeTree18.Append(shape93);
            shapeTree18.Append(shape94);
            shapeTree18.Append(shape95);
            shapeTree18.Append(connectionShape76);
            shapeTree18.Append(connectionShape77);
            shapeTree18.Append(connectionShape78);
            shapeTree18.Append(connectionShape79);
            shapeTree18.Append(connectionShape80);

            CommonSlideDataExtensionList commonSlideDataExtensionList18 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension18 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId18 = new P14.CreationId(){ Val = (UInt32Value)1479597387U };
            creationId18.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension18.Append(creationId18);

            commonSlideDataExtensionList18.Append(commonSlideDataExtension18);

            commonSlideData18.Append(shapeTree18);
            commonSlideData18.Append(commonSlideDataExtensionList18);

            ColorMapOverride colorMapOverride17 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping17 = new A.MasterColorMapping();

            colorMapOverride17.Append(masterColorMapping17);

            Timing timing18 = new Timing();

            TimeNodeList timeNodeList18 = new TimeNodeList();

            ParallelTimeNode parallelTimeNode18 = new ParallelTimeNode();
            CommonTimeNode commonTimeNode18 = new CommonTimeNode(){ Id = (UInt32Value)1U, Duration = "indefinite", Restart = TimeNodeRestartValues.Never, NodeType = TimeNodeValues.TmingRoot };

            parallelTimeNode18.Append(commonTimeNode18);

            timeNodeList18.Append(parallelTimeNode18);

            timing18.Append(timeNodeList18);

            slideLayout16.Append(commonSlideData18);
            slideLayout16.Append(colorMapOverride17);
            slideLayout16.Append(timing18);

            slideLayoutPart16.SlideLayout = slideLayout16;
        }

        // Generates content of slideLayoutPart17.
        private void GenerateSlideLayoutPart17Content(SlideLayoutPart slideLayoutPart17)
        {
            SlideLayout slideLayout17 = new SlideLayout(){ Preserve = true };
            slideLayout17.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout17.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout17.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData19 = new CommonSlideData(){ Name = "Quote Name Card" };

            ShapeTree shapeTree19 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties19 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties194 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties19 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties194 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties19.Append(nonVisualDrawingProperties194);
            nonVisualGroupShapeProperties19.Append(nonVisualGroupShapeDrawingProperties19);
            nonVisualGroupShapeProperties19.Append(applicationNonVisualDrawingProperties194);

            GroupShapeProperties groupShapeProperties19 = new GroupShapeProperties();

            A.TransformGroup transformGroup19 = new A.TransformGroup();
            A.Offset offset136 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents136 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset19 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents19 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup19.Append(offset136);
            transformGroup19.Append(extents136);
            transformGroup19.Append(childOffset19);
            transformGroup19.Append(childExtents19);

            groupShapeProperties19.Append(transformGroup19);

            Shape shape96 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties96 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties195 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties96 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks94 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties96.Append(shapeLocks94);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties195 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape94 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties195.Append(placeholderShape94);

            nonVisualShapeProperties96.Append(nonVisualDrawingProperties195);
            nonVisualShapeProperties96.Append(nonVisualShapeDrawingProperties96);
            nonVisualShapeProperties96.Append(applicationNonVisualDrawingProperties195);

            ShapeProperties shapeProperties176 = new ShapeProperties();

            A.Transform2D transform2D118 = new A.Transform2D();
            A.Offset offset137 = new A.Offset(){ X = 1141710L, Y = 685800L };
            A.Extents extents137 = new A.Extents(){ Cx = 9146382L, Cy = 2743200L };

            transform2D118.Append(offset137);
            transform2D118.Append(extents137);

            shapeProperties176.Append(transform2D118);

            TextBody textBody96 = new TextBody();

            A.BodyProperties bodyProperties96 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Center };
            A.NormalAutoFit normalAutoFit28 = new A.NormalAutoFit();

            bodyProperties96.Append(normalAutoFit28);

            A.ListStyle listStyle96 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties41 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Left };

            A.DefaultRunProperties defaultRunProperties239 = new A.DefaultRunProperties(){ FontSize = 3200, Bold = false, Capital = A.TextCapsValues.All };

            A.SolidFill solidFill205 = new A.SolidFill();
            A.SchemeColor schemeColor541 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill205.Append(schemeColor541);

            defaultRunProperties239.Append(solidFill205);

            level1ParagraphProperties41.Append(defaultRunProperties239);

            listStyle96.Append(level1ParagraphProperties41);

            A.Paragraph paragraph132 = new A.Paragraph();

            A.Run run82 = new A.Run();

            A.RunProperties runProperties116 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties116.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text116 = new A.Text();
            text116.Text = "Click to edit Master title style";

            run82.Append(runProperties116);
            run82.Append(text116);
            A.EndParagraphRunProperties endParagraphRunProperties84 = new A.EndParagraphRunProperties(){ Language = "en-US", Dirty = false };

            paragraph132.Append(run82);
            paragraph132.Append(endParagraphRunProperties84);

            textBody96.Append(bodyProperties96);
            textBody96.Append(listStyle96);
            textBody96.Append(paragraph132);

            shape96.Append(nonVisualShapeProperties96);
            shape96.Append(shapeProperties176);
            shape96.Append(textBody96);

            Shape shape97 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties97 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties196 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Text Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties97 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks95 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties97.Append(shapeLocks95);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties196 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape95 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties196.Append(placeholderShape95);

            nonVisualShapeProperties97.Append(nonVisualDrawingProperties196);
            nonVisualShapeProperties97.Append(nonVisualShapeDrawingProperties97);
            nonVisualShapeProperties97.Append(applicationNonVisualDrawingProperties196);

            ShapeProperties shapeProperties177 = new ShapeProperties();

            A.Transform2D transform2D119 = new A.Transform2D();
            A.Offset offset138 = new A.Offset(){ X = 684390L, Y = 4978400L };
            A.Extents extents138 = new A.Extents(){ Cx = 8536624L, Cy = 1016000L };

            transform2D119.Append(offset138);
            transform2D119.Append(extents138);

            shapeProperties177.Append(transform2D119);

            TextBody textBody97 = new TextBody();

            A.BodyProperties bodyProperties97 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Top };
            A.NormalAutoFit normalAutoFit29 = new A.NormalAutoFit();

            bodyProperties97.Append(normalAutoFit29);

            A.ListStyle listStyle97 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties42 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0, Alignment = A.TextAlignmentTypeValues.Left };
            A.NoBullet noBullet123 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties240 = new A.DefaultRunProperties(){ FontSize = 1800 };

            A.SolidFill solidFill206 = new A.SolidFill();

            A.SchemeColor schemeColor542 = new A.SchemeColor(){ Val = A.SchemeColorValues.Background2 };
            A.LuminanceModulation luminanceModulation24 = new A.LuminanceModulation(){ Val = 75000 };

            schemeColor542.Append(luminanceModulation24);

            solidFill206.Append(schemeColor542);

            defaultRunProperties240.Append(solidFill206);

            level1ParagraphProperties42.Append(noBullet123);
            level1ParagraphProperties42.Append(defaultRunProperties240);

            A.Level2ParagraphProperties level2ParagraphProperties27 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Indent = 0 };
            A.NoBullet noBullet124 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties241 = new A.DefaultRunProperties(){ FontSize = 1800 };

            A.SolidFill solidFill207 = new A.SolidFill();

            A.SchemeColor schemeColor543 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint55 = new A.Tint(){ Val = 75000 };

            schemeColor543.Append(tint55);

            solidFill207.Append(schemeColor543);

            defaultRunProperties241.Append(solidFill207);

            level2ParagraphProperties27.Append(noBullet124);
            level2ParagraphProperties27.Append(defaultRunProperties241);

            A.Level3ParagraphProperties level3ParagraphProperties27 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Indent = 0 };
            A.NoBullet noBullet125 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties242 = new A.DefaultRunProperties(){ FontSize = 1600 };

            A.SolidFill solidFill208 = new A.SolidFill();

            A.SchemeColor schemeColor544 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint56 = new A.Tint(){ Val = 75000 };

            schemeColor544.Append(tint56);

            solidFill208.Append(schemeColor544);

            defaultRunProperties242.Append(solidFill208);

            level3ParagraphProperties27.Append(noBullet125);
            level3ParagraphProperties27.Append(defaultRunProperties242);

            A.Level4ParagraphProperties level4ParagraphProperties27 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Indent = 0 };
            A.NoBullet noBullet126 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties243 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill209 = new A.SolidFill();

            A.SchemeColor schemeColor545 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint57 = new A.Tint(){ Val = 75000 };

            schemeColor545.Append(tint57);

            solidFill209.Append(schemeColor545);

            defaultRunProperties243.Append(solidFill209);

            level4ParagraphProperties27.Append(noBullet126);
            level4ParagraphProperties27.Append(defaultRunProperties243);

            A.Level5ParagraphProperties level5ParagraphProperties27 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Indent = 0 };
            A.NoBullet noBullet127 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties244 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill210 = new A.SolidFill();

            A.SchemeColor schemeColor546 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint58 = new A.Tint(){ Val = 75000 };

            schemeColor546.Append(tint58);

            solidFill210.Append(schemeColor546);

            defaultRunProperties244.Append(solidFill210);

            level5ParagraphProperties27.Append(noBullet127);
            level5ParagraphProperties27.Append(defaultRunProperties244);

            A.Level6ParagraphProperties level6ParagraphProperties24 = new A.Level6ParagraphProperties(){ LeftMargin = 2286000, Indent = 0 };
            A.NoBullet noBullet128 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties245 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill211 = new A.SolidFill();

            A.SchemeColor schemeColor547 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint59 = new A.Tint(){ Val = 75000 };

            schemeColor547.Append(tint59);

            solidFill211.Append(schemeColor547);

            defaultRunProperties245.Append(solidFill211);

            level6ParagraphProperties24.Append(noBullet128);
            level6ParagraphProperties24.Append(defaultRunProperties245);

            A.Level7ParagraphProperties level7ParagraphProperties24 = new A.Level7ParagraphProperties(){ LeftMargin = 2743200, Indent = 0 };
            A.NoBullet noBullet129 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties246 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill212 = new A.SolidFill();

            A.SchemeColor schemeColor548 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint60 = new A.Tint(){ Val = 75000 };

            schemeColor548.Append(tint60);

            solidFill212.Append(schemeColor548);

            defaultRunProperties246.Append(solidFill212);

            level7ParagraphProperties24.Append(noBullet129);
            level7ParagraphProperties24.Append(defaultRunProperties246);

            A.Level8ParagraphProperties level8ParagraphProperties24 = new A.Level8ParagraphProperties(){ LeftMargin = 3200400, Indent = 0 };
            A.NoBullet noBullet130 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties247 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill213 = new A.SolidFill();

            A.SchemeColor schemeColor549 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint61 = new A.Tint(){ Val = 75000 };

            schemeColor549.Append(tint61);

            solidFill213.Append(schemeColor549);

            defaultRunProperties247.Append(solidFill213);

            level8ParagraphProperties24.Append(noBullet130);
            level8ParagraphProperties24.Append(defaultRunProperties247);

            A.Level9ParagraphProperties level9ParagraphProperties24 = new A.Level9ParagraphProperties(){ LeftMargin = 3657600, Indent = 0 };
            A.NoBullet noBullet131 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties248 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill214 = new A.SolidFill();

            A.SchemeColor schemeColor550 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint62 = new A.Tint(){ Val = 75000 };

            schemeColor550.Append(tint62);

            solidFill214.Append(schemeColor550);

            defaultRunProperties248.Append(solidFill214);

            level9ParagraphProperties24.Append(noBullet131);
            level9ParagraphProperties24.Append(defaultRunProperties248);

            listStyle97.Append(level1ParagraphProperties42);
            listStyle97.Append(level2ParagraphProperties27);
            listStyle97.Append(level3ParagraphProperties27);
            listStyle97.Append(level4ParagraphProperties27);
            listStyle97.Append(level5ParagraphProperties27);
            listStyle97.Append(level6ParagraphProperties24);
            listStyle97.Append(level7ParagraphProperties24);
            listStyle97.Append(level8ParagraphProperties24);
            listStyle97.Append(level9ParagraphProperties24);

            A.Paragraph paragraph133 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties61 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run83 = new A.Run();

            A.RunProperties runProperties117 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties117.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text117 = new A.Text();
            text117.Text = "Click to edit Master text styles";

            run83.Append(runProperties117);
            run83.Append(text117);

            paragraph133.Append(paragraphProperties61);
            paragraph133.Append(run83);

            textBody97.Append(bodyProperties97);
            textBody97.Append(listStyle97);
            textBody97.Append(paragraph133);

            shape97.Append(nonVisualShapeProperties97);
            shape97.Append(shapeProperties177);
            shape97.Append(textBody97);

            Shape shape98 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties98 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties197 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Date Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties98 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks96 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties98.Append(shapeLocks96);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties197 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape96 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties197.Append(placeholderShape96);

            nonVisualShapeProperties98.Append(nonVisualDrawingProperties197);
            nonVisualShapeProperties98.Append(nonVisualShapeDrawingProperties98);
            nonVisualShapeProperties98.Append(applicationNonVisualDrawingProperties197);
            ShapeProperties shapeProperties178 = new ShapeProperties();

            TextBody textBody98 = new TextBody();
            A.BodyProperties bodyProperties98 = new A.BodyProperties();
            A.ListStyle listStyle98 = new A.ListStyle();

            A.Paragraph paragraph134 = new A.Paragraph();

            A.Field field35 = new A.Field(){ Id = "{CE1A2D98-1BBD-4706-A118-AAC2A16BEAD3}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties118 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties118.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text118 = new A.Text();
            text118.Text = "2012/10/3";

            field35.Append(runProperties118);
            field35.Append(text118);
            A.EndParagraphRunProperties endParagraphRunProperties85 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph134.Append(field35);
            paragraph134.Append(endParagraphRunProperties85);

            textBody98.Append(bodyProperties98);
            textBody98.Append(listStyle98);
            textBody98.Append(paragraph134);

            shape98.Append(nonVisualShapeProperties98);
            shape98.Append(shapeProperties178);
            shape98.Append(textBody98);

            Shape shape99 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties99 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties198 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Footer Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties99 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks97 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties99.Append(shapeLocks97);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties198 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape97 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties198.Append(placeholderShape97);

            nonVisualShapeProperties99.Append(nonVisualDrawingProperties198);
            nonVisualShapeProperties99.Append(nonVisualShapeDrawingProperties99);
            nonVisualShapeProperties99.Append(applicationNonVisualDrawingProperties198);
            ShapeProperties shapeProperties179 = new ShapeProperties();

            TextBody textBody99 = new TextBody();
            A.BodyProperties bodyProperties99 = new A.BodyProperties();
            A.ListStyle listStyle99 = new A.ListStyle();

            A.Paragraph paragraph135 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties86 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph135.Append(endParagraphRunProperties86);

            textBody99.Append(bodyProperties99);
            textBody99.Append(listStyle99);
            textBody99.Append(paragraph135);

            shape99.Append(nonVisualShapeProperties99);
            shape99.Append(shapeProperties179);
            shape99.Append(textBody99);

            Shape shape100 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties100 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties199 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Slide Number Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties100 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks98 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties100.Append(shapeLocks98);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties199 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape98 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties199.Append(placeholderShape98);

            nonVisualShapeProperties100.Append(nonVisualDrawingProperties199);
            nonVisualShapeProperties100.Append(nonVisualShapeDrawingProperties100);
            nonVisualShapeProperties100.Append(applicationNonVisualDrawingProperties199);
            ShapeProperties shapeProperties180 = new ShapeProperties();

            TextBody textBody100 = new TextBody();
            A.BodyProperties bodyProperties100 = new A.BodyProperties();
            A.ListStyle listStyle100 = new A.ListStyle();

            A.Paragraph paragraph136 = new A.Paragraph();

            A.Field field36 = new A.Field(){ Id = "{D107CD50-7081-433F-A1F2-156B4E14F4F4}", Type = "slidenum" };

            A.RunProperties runProperties119 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties119.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text119 = new A.Text();
            text119.Text = "‹#›";

            field36.Append(runProperties119);
            field36.Append(text119);
            A.EndParagraphRunProperties endParagraphRunProperties87 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph136.Append(field36);
            paragraph136.Append(endParagraphRunProperties87);

            textBody100.Append(bodyProperties100);
            textBody100.Append(listStyle100);
            textBody100.Append(paragraph136);

            shape100.Append(nonVisualShapeProperties100);
            shape100.Append(shapeProperties180);
            shape100.Append(textBody100);

            Shape shape101 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties101 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties200 = new NonVisualDrawingProperties(){ Id = (UInt32Value)10U, Name = "Text Placeholder 9" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties101 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks99 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties101.Append(shapeLocks99);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties200 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape99 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)13U };

            applicationNonVisualDrawingProperties200.Append(placeholderShape99);

            nonVisualShapeProperties101.Append(nonVisualDrawingProperties200);
            nonVisualShapeProperties101.Append(nonVisualShapeDrawingProperties101);
            nonVisualShapeProperties101.Append(applicationNonVisualDrawingProperties200);

            ShapeProperties shapeProperties181 = new ShapeProperties();

            A.Transform2D transform2D120 = new A.Transform2D();
            A.Offset offset139 = new A.Offset(){ X = 684391L, Y = 3928534L };
            A.Extents extents139 = new A.Extents(){ Cx = 8536624L, Cy = 1049866L };

            transform2D120.Append(offset139);
            transform2D120.Append(extents139);

            shapeProperties181.Append(transform2D120);

            TextBody textBody101 = new TextBody();

            A.BodyProperties bodyProperties101 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal, LeftInset = 91440, TopInset = 45720, RightInset = 91440, BottomInset = 45720, RightToLeftColumns = false, Anchor = A.TextAnchoringTypeValues.Bottom };
            A.NormalAutoFit normalAutoFit30 = new A.NormalAutoFit();

            bodyProperties101.Append(normalAutoFit30);

            A.ListStyle listStyle101 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties43 = new A.Level1ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties249 = new A.DefaultRunProperties(){ Language = "en-US", FontSize = 2400, Bold = false, Capital = A.TextCapsValues.All, Dirty = false };
            defaultRunProperties249.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));

            A.Outline outline90 = new A.Outline(){ Width = 3175, CompoundLineType = A.CompoundLineValues.Single };
            A.NoFill noFill5 = new A.NoFill();

            outline90.Append(noFill5);

            A.SolidFill solidFill215 = new A.SolidFill();
            A.SchemeColor schemeColor551 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill215.Append(schemeColor551);
            A.EffectList effectList24 = new A.EffectList();
            A.LatinFont latinFont37 = new A.LatinFont(){ Typeface = "+mj-lt" };
            A.EastAsianFont eastAsianFont34 = new A.EastAsianFont(){ Typeface = "+mj-ea" };
            A.ComplexScriptFont complexScriptFont34 = new A.ComplexScriptFont(){ Typeface = "Trebuchet MS" };

            defaultRunProperties249.Append(outline90);
            defaultRunProperties249.Append(solidFill215);
            defaultRunProperties249.Append(effectList24);
            defaultRunProperties249.Append(latinFont37);
            defaultRunProperties249.Append(eastAsianFont34);
            defaultRunProperties249.Append(complexScriptFont34);

            level1ParagraphProperties43.Append(defaultRunProperties249);

            listStyle101.Append(level1ParagraphProperties43);

            A.Paragraph paragraph137 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties62 = new A.ParagraphProperties(){ LeftMargin = 0, Level = 0 };

            A.SpaceBefore spaceBefore14 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent14 = new A.SpacingPercent(){ Val = 0 };

            spaceBefore14.Append(spacingPercent14);
            A.NoBullet noBullet132 = new A.NoBullet();

            paragraphProperties62.Append(spaceBefore14);
            paragraphProperties62.Append(noBullet132);

            A.Run run84 = new A.Run();

            A.RunProperties runProperties120 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties120.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text120 = new A.Text();
            text120.Text = "Click to edit Master text styles";

            run84.Append(runProperties120);
            run84.Append(text120);

            paragraph137.Append(paragraphProperties62);
            paragraph137.Append(run84);

            textBody101.Append(bodyProperties101);
            textBody101.Append(listStyle101);
            textBody101.Append(paragraph137);

            shape101.Append(nonVisualShapeProperties101);
            shape101.Append(shapeProperties181);
            shape101.Append(textBody101);

            Shape shape102 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties102 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties201 = new NonVisualDrawingProperties(){ Id = (UInt32Value)11U, Name = "TextBox 10" };
            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties102 = new NonVisualShapeDrawingProperties(){ TextBox = true };
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties201 = new ApplicationNonVisualDrawingProperties();

            nonVisualShapeProperties102.Append(nonVisualDrawingProperties201);
            nonVisualShapeProperties102.Append(nonVisualShapeDrawingProperties102);
            nonVisualShapeProperties102.Append(applicationNonVisualDrawingProperties201);

            ShapeProperties shapeProperties182 = new ShapeProperties();

            A.Transform2D transform2D121 = new A.Transform2D();
            A.Offset offset140 = new A.Offset(){ X = 531950L, Y = 812222L };
            A.Extents extents140 = new A.Extents(){ Cx = 609759L, Cy = 584776L };

            transform2D121.Append(offset140);
            transform2D121.Append(extents140);

            A.PresetGeometry presetGeometry90 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList90 = new A.AdjustValueList();

            presetGeometry90.Append(adjustValueList90);

            shapeProperties182.Append(transform2D121);
            shapeProperties182.Append(presetGeometry90);

            TextBody textBody102 = new TextBody();

            A.BodyProperties bodyProperties102 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal, LeftInset = 91440, TopInset = 45720, RightInset = 91440, BottomInset = 45720, RightToLeftColumns = false, Anchor = A.TextAnchoringTypeValues.Center };
            A.NoAutoFit noAutoFit5 = new A.NoAutoFit();

            bodyProperties102.Append(noAutoFit5);

            A.ListStyle listStyle102 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties44 = new A.Level1ParagraphProperties();

            A.SpaceBefore spaceBefore15 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent15 = new A.SpacingPercent(){ Val = 0 };

            spaceBefore15.Append(spacingPercent15);
            A.NoBullet noBullet133 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties250 = new A.DefaultRunProperties(){ FontSize = 3200, Bold = false, Capital = A.TextCapsValues.All };

            A.Outline outline91 = new A.Outline(){ Width = 3175, CompoundLineType = A.CompoundLineValues.Single };
            A.NoFill noFill6 = new A.NoFill();

            outline91.Append(noFill6);

            A.EffectList effectList25 = new A.EffectList();

            A.Glow glow3 = new A.Glow(){ Radius = 38100L };

            A.SchemeColor schemeColor552 = new A.SchemeColor(){ Val = A.SchemeColorValues.Background1 };
            A.LuminanceModulation luminanceModulation25 = new A.LuminanceModulation(){ Val = 65000 };
            A.LuminanceOffset luminanceOffset3 = new A.LuminanceOffset(){ Val = 35000 };
            A.Alpha alpha12 = new A.Alpha(){ Val = 40000 };

            schemeColor552.Append(luminanceModulation25);
            schemeColor552.Append(luminanceOffset3);
            schemeColor552.Append(alpha12);

            glow3.Append(schemeColor552);

            A.OuterShadow outerShadow4 = new A.OuterShadow(){ BlurRadius = 28575L, Distance = 38100L, Direction = 14040000, Alignment = A.RectangleAlignmentValues.TopLeft, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex17 = new A.RgbColorModelHex(){ Val = "000000" };
            A.Alpha alpha13 = new A.Alpha(){ Val = 25000 };

            rgbColorModelHex17.Append(alpha13);

            outerShadow4.Append(rgbColorModelHex17);

            effectList25.Append(glow3);
            effectList25.Append(outerShadow4);
            A.LatinFont latinFont38 = new A.LatinFont(){ Typeface = "+mj-lt" };
            A.EastAsianFont eastAsianFont35 = new A.EastAsianFont(){ Typeface = "+mj-ea" };
            A.ComplexScriptFont complexScriptFont35 = new A.ComplexScriptFont(){ Typeface = "Trebuchet MS" };

            defaultRunProperties250.Append(outline91);
            defaultRunProperties250.Append(effectList25);
            defaultRunProperties250.Append(latinFont38);
            defaultRunProperties250.Append(eastAsianFont35);
            defaultRunProperties250.Append(complexScriptFont35);

            level1ParagraphProperties44.Append(spaceBefore15);
            level1ParagraphProperties44.Append(noBullet133);
            level1ParagraphProperties44.Append(defaultRunProperties250);

            A.Level2ParagraphProperties level2ParagraphProperties28 = new A.Level2ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties251 = new A.DefaultRunProperties();

            A.SolidFill solidFill216 = new A.SolidFill();
            A.SchemeColor schemeColor553 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill216.Append(schemeColor553);

            defaultRunProperties251.Append(solidFill216);

            level2ParagraphProperties28.Append(defaultRunProperties251);

            A.Level3ParagraphProperties level3ParagraphProperties28 = new A.Level3ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties252 = new A.DefaultRunProperties();

            A.SolidFill solidFill217 = new A.SolidFill();
            A.SchemeColor schemeColor554 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill217.Append(schemeColor554);

            defaultRunProperties252.Append(solidFill217);

            level3ParagraphProperties28.Append(defaultRunProperties252);

            A.Level4ParagraphProperties level4ParagraphProperties28 = new A.Level4ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties253 = new A.DefaultRunProperties();

            A.SolidFill solidFill218 = new A.SolidFill();
            A.SchemeColor schemeColor555 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill218.Append(schemeColor555);

            defaultRunProperties253.Append(solidFill218);

            level4ParagraphProperties28.Append(defaultRunProperties253);

            A.Level5ParagraphProperties level5ParagraphProperties28 = new A.Level5ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties254 = new A.DefaultRunProperties();

            A.SolidFill solidFill219 = new A.SolidFill();
            A.SchemeColor schemeColor556 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill219.Append(schemeColor556);

            defaultRunProperties254.Append(solidFill219);

            level5ParagraphProperties28.Append(defaultRunProperties254);

            A.Level6ParagraphProperties level6ParagraphProperties25 = new A.Level6ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties255 = new A.DefaultRunProperties();

            A.SolidFill solidFill220 = new A.SolidFill();
            A.SchemeColor schemeColor557 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill220.Append(schemeColor557);

            defaultRunProperties255.Append(solidFill220);

            level6ParagraphProperties25.Append(defaultRunProperties255);

            A.Level7ParagraphProperties level7ParagraphProperties25 = new A.Level7ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties256 = new A.DefaultRunProperties();

            A.SolidFill solidFill221 = new A.SolidFill();
            A.SchemeColor schemeColor558 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill221.Append(schemeColor558);

            defaultRunProperties256.Append(solidFill221);

            level7ParagraphProperties25.Append(defaultRunProperties256);

            A.Level8ParagraphProperties level8ParagraphProperties25 = new A.Level8ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties257 = new A.DefaultRunProperties();

            A.SolidFill solidFill222 = new A.SolidFill();
            A.SchemeColor schemeColor559 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill222.Append(schemeColor559);

            defaultRunProperties257.Append(solidFill222);

            level8ParagraphProperties25.Append(defaultRunProperties257);

            A.Level9ParagraphProperties level9ParagraphProperties25 = new A.Level9ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties258 = new A.DefaultRunProperties();

            A.SolidFill solidFill223 = new A.SolidFill();
            A.SchemeColor schemeColor560 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill223.Append(schemeColor560);

            defaultRunProperties258.Append(solidFill223);

            level9ParagraphProperties25.Append(defaultRunProperties258);

            listStyle102.Append(level1ParagraphProperties44);
            listStyle102.Append(level2ParagraphProperties28);
            listStyle102.Append(level3ParagraphProperties28);
            listStyle102.Append(level4ParagraphProperties28);
            listStyle102.Append(level5ParagraphProperties28);
            listStyle102.Append(level6ParagraphProperties25);
            listStyle102.Append(level7ParagraphProperties25);
            listStyle102.Append(level8ParagraphProperties25);
            listStyle102.Append(level9ParagraphProperties25);

            A.Paragraph paragraph138 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties63 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run85 = new A.Run();

            A.RunProperties runProperties121 = new A.RunProperties(){ Language = "en-US", FontSize = 8000, Dirty = false };
            runProperties121.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));

            A.SolidFill solidFill224 = new A.SolidFill();
            A.SchemeColor schemeColor561 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill224.Append(schemeColor561);
            A.EffectList effectList26 = new A.EffectList();

            runProperties121.Append(solidFill224);
            runProperties121.Append(effectList26);
            A.Text text121 = new A.Text();
            text121.Text = "“";

            run85.Append(runProperties121);
            run85.Append(text121);

            A.EndParagraphRunProperties endParagraphRunProperties88 = new A.EndParagraphRunProperties(){ Language = "en-US", FontSize = 8000, Dirty = false };

            A.SolidFill solidFill225 = new A.SolidFill();
            A.SchemeColor schemeColor562 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill225.Append(schemeColor562);
            A.EffectList effectList27 = new A.EffectList();

            endParagraphRunProperties88.Append(solidFill225);
            endParagraphRunProperties88.Append(effectList27);

            paragraph138.Append(paragraphProperties63);
            paragraph138.Append(run85);
            paragraph138.Append(endParagraphRunProperties88);

            textBody102.Append(bodyProperties102);
            textBody102.Append(listStyle102);
            textBody102.Append(paragraph138);

            shape102.Append(nonVisualShapeProperties102);
            shape102.Append(shapeProperties182);
            shape102.Append(textBody102);

            Shape shape103 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties103 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties202 = new NonVisualDrawingProperties(){ Id = (UInt32Value)12U, Name = "TextBox 11" };
            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties103 = new NonVisualShapeDrawingProperties(){ TextBox = true };
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties202 = new ApplicationNonVisualDrawingProperties();

            nonVisualShapeProperties103.Append(nonVisualDrawingProperties202);
            nonVisualShapeProperties103.Append(nonVisualShapeDrawingProperties103);
            nonVisualShapeProperties103.Append(applicationNonVisualDrawingProperties202);

            ShapeProperties shapeProperties183 = new ShapeProperties();

            A.Transform2D transform2D122 = new A.Transform2D();
            A.Offset offset141 = new A.Offset(){ X = 10288091L, Y = 2768601L };
            A.Extents extents141 = new A.Extents(){ Cx = 609759L, Cy = 584776L };

            transform2D122.Append(offset141);
            transform2D122.Append(extents141);

            A.PresetGeometry presetGeometry91 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList91 = new A.AdjustValueList();

            presetGeometry91.Append(adjustValueList91);

            shapeProperties183.Append(transform2D122);
            shapeProperties183.Append(presetGeometry91);

            TextBody textBody103 = new TextBody();

            A.BodyProperties bodyProperties103 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal, LeftInset = 91440, TopInset = 45720, RightInset = 91440, BottomInset = 45720, RightToLeftColumns = false, Anchor = A.TextAnchoringTypeValues.Center };
            A.NoAutoFit noAutoFit6 = new A.NoAutoFit();

            bodyProperties103.Append(noAutoFit6);

            A.ListStyle listStyle103 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties45 = new A.Level1ParagraphProperties();

            A.SpaceBefore spaceBefore16 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent16 = new A.SpacingPercent(){ Val = 0 };

            spaceBefore16.Append(spacingPercent16);
            A.NoBullet noBullet134 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties259 = new A.DefaultRunProperties(){ FontSize = 3200, Bold = false, Capital = A.TextCapsValues.All };

            A.Outline outline92 = new A.Outline(){ Width = 3175, CompoundLineType = A.CompoundLineValues.Single };
            A.NoFill noFill7 = new A.NoFill();

            outline92.Append(noFill7);

            A.EffectList effectList28 = new A.EffectList();

            A.Glow glow4 = new A.Glow(){ Radius = 38100L };

            A.SchemeColor schemeColor563 = new A.SchemeColor(){ Val = A.SchemeColorValues.Background1 };
            A.LuminanceModulation luminanceModulation26 = new A.LuminanceModulation(){ Val = 65000 };
            A.LuminanceOffset luminanceOffset4 = new A.LuminanceOffset(){ Val = 35000 };
            A.Alpha alpha14 = new A.Alpha(){ Val = 40000 };

            schemeColor563.Append(luminanceModulation26);
            schemeColor563.Append(luminanceOffset4);
            schemeColor563.Append(alpha14);

            glow4.Append(schemeColor563);

            A.OuterShadow outerShadow5 = new A.OuterShadow(){ BlurRadius = 28575L, Distance = 38100L, Direction = 14040000, Alignment = A.RectangleAlignmentValues.TopLeft, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex18 = new A.RgbColorModelHex(){ Val = "000000" };
            A.Alpha alpha15 = new A.Alpha(){ Val = 25000 };

            rgbColorModelHex18.Append(alpha15);

            outerShadow5.Append(rgbColorModelHex18);

            effectList28.Append(glow4);
            effectList28.Append(outerShadow5);
            A.LatinFont latinFont39 = new A.LatinFont(){ Typeface = "+mj-lt" };
            A.EastAsianFont eastAsianFont36 = new A.EastAsianFont(){ Typeface = "+mj-ea" };
            A.ComplexScriptFont complexScriptFont36 = new A.ComplexScriptFont(){ Typeface = "Trebuchet MS" };

            defaultRunProperties259.Append(outline92);
            defaultRunProperties259.Append(effectList28);
            defaultRunProperties259.Append(latinFont39);
            defaultRunProperties259.Append(eastAsianFont36);
            defaultRunProperties259.Append(complexScriptFont36);

            level1ParagraphProperties45.Append(spaceBefore16);
            level1ParagraphProperties45.Append(noBullet134);
            level1ParagraphProperties45.Append(defaultRunProperties259);

            A.Level2ParagraphProperties level2ParagraphProperties29 = new A.Level2ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties260 = new A.DefaultRunProperties();

            A.SolidFill solidFill226 = new A.SolidFill();
            A.SchemeColor schemeColor564 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill226.Append(schemeColor564);

            defaultRunProperties260.Append(solidFill226);

            level2ParagraphProperties29.Append(defaultRunProperties260);

            A.Level3ParagraphProperties level3ParagraphProperties29 = new A.Level3ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties261 = new A.DefaultRunProperties();

            A.SolidFill solidFill227 = new A.SolidFill();
            A.SchemeColor schemeColor565 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill227.Append(schemeColor565);

            defaultRunProperties261.Append(solidFill227);

            level3ParagraphProperties29.Append(defaultRunProperties261);

            A.Level4ParagraphProperties level4ParagraphProperties29 = new A.Level4ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties262 = new A.DefaultRunProperties();

            A.SolidFill solidFill228 = new A.SolidFill();
            A.SchemeColor schemeColor566 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill228.Append(schemeColor566);

            defaultRunProperties262.Append(solidFill228);

            level4ParagraphProperties29.Append(defaultRunProperties262);

            A.Level5ParagraphProperties level5ParagraphProperties29 = new A.Level5ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties263 = new A.DefaultRunProperties();

            A.SolidFill solidFill229 = new A.SolidFill();
            A.SchemeColor schemeColor567 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill229.Append(schemeColor567);

            defaultRunProperties263.Append(solidFill229);

            level5ParagraphProperties29.Append(defaultRunProperties263);

            A.Level6ParagraphProperties level6ParagraphProperties26 = new A.Level6ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties264 = new A.DefaultRunProperties();

            A.SolidFill solidFill230 = new A.SolidFill();
            A.SchemeColor schemeColor568 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill230.Append(schemeColor568);

            defaultRunProperties264.Append(solidFill230);

            level6ParagraphProperties26.Append(defaultRunProperties264);

            A.Level7ParagraphProperties level7ParagraphProperties26 = new A.Level7ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties265 = new A.DefaultRunProperties();

            A.SolidFill solidFill231 = new A.SolidFill();
            A.SchemeColor schemeColor569 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill231.Append(schemeColor569);

            defaultRunProperties265.Append(solidFill231);

            level7ParagraphProperties26.Append(defaultRunProperties265);

            A.Level8ParagraphProperties level8ParagraphProperties26 = new A.Level8ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties266 = new A.DefaultRunProperties();

            A.SolidFill solidFill232 = new A.SolidFill();
            A.SchemeColor schemeColor570 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill232.Append(schemeColor570);

            defaultRunProperties266.Append(solidFill232);

            level8ParagraphProperties26.Append(defaultRunProperties266);

            A.Level9ParagraphProperties level9ParagraphProperties26 = new A.Level9ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties267 = new A.DefaultRunProperties();

            A.SolidFill solidFill233 = new A.SolidFill();
            A.SchemeColor schemeColor571 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };

            solidFill233.Append(schemeColor571);

            defaultRunProperties267.Append(solidFill233);

            level9ParagraphProperties26.Append(defaultRunProperties267);

            listStyle103.Append(level1ParagraphProperties45);
            listStyle103.Append(level2ParagraphProperties29);
            listStyle103.Append(level3ParagraphProperties29);
            listStyle103.Append(level4ParagraphProperties29);
            listStyle103.Append(level5ParagraphProperties29);
            listStyle103.Append(level6ParagraphProperties26);
            listStyle103.Append(level7ParagraphProperties26);
            listStyle103.Append(level8ParagraphProperties26);
            listStyle103.Append(level9ParagraphProperties26);

            A.Paragraph paragraph139 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties64 = new A.ParagraphProperties(){ Level = 0, Alignment = A.TextAlignmentTypeValues.Right };

            A.Run run86 = new A.Run();

            A.RunProperties runProperties122 = new A.RunProperties(){ Language = "en-US", FontSize = 8000, Dirty = false };
            runProperties122.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));

            A.SolidFill solidFill234 = new A.SolidFill();
            A.SchemeColor schemeColor572 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill234.Append(schemeColor572);
            A.EffectList effectList29 = new A.EffectList();

            runProperties122.Append(solidFill234);
            runProperties122.Append(effectList29);
            A.Text text122 = new A.Text();
            text122.Text = "”";

            run86.Append(runProperties122);
            run86.Append(text122);

            A.EndParagraphRunProperties endParagraphRunProperties89 = new A.EndParagraphRunProperties(){ Language = "en-US", FontSize = 8000, Dirty = false };

            A.SolidFill solidFill235 = new A.SolidFill();
            A.SchemeColor schemeColor573 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill235.Append(schemeColor573);
            A.EffectList effectList30 = new A.EffectList();

            endParagraphRunProperties89.Append(solidFill235);
            endParagraphRunProperties89.Append(effectList30);

            paragraph139.Append(paragraphProperties64);
            paragraph139.Append(run86);
            paragraph139.Append(endParagraphRunProperties89);

            textBody103.Append(bodyProperties103);
            textBody103.Append(listStyle103);
            textBody103.Append(paragraph139);

            shape103.Append(nonVisualShapeProperties103);
            shape103.Append(shapeProperties183);
            shape103.Append(textBody103);

            ConnectionShape connectionShape81 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties81 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties203 = new NonVisualDrawingProperties(){ Id = (UInt32Value)13U, Name = "Straight Connector 12" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties81 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties203 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties81.Append(nonVisualDrawingProperties203);
            nonVisualConnectionShapeProperties81.Append(nonVisualConnectorShapeDrawingProperties81);
            nonVisualConnectionShapeProperties81.Append(applicationNonVisualDrawingProperties203);

            ShapeProperties shapeProperties184 = new ShapeProperties();

            A.Transform2D transform2D123 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset142 = new A.Offset(){ X = 11278949L, Y = 2963333L };
            A.Extents extents142 = new A.Extents(){ Cx = 913052L, Cy = 912812L };

            transform2D123.Append(offset142);
            transform2D123.Append(extents142);

            A.PresetGeometry presetGeometry92 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList92 = new A.AdjustValueList();

            presetGeometry92.Append(adjustValueList92);

            A.Outline outline93 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill236 = new A.SolidFill();
            A.SchemeColor schemeColor574 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill236.Append(schemeColor574);

            outline93.Append(solidFill236);

            shapeProperties184.Append(transform2D123);
            shapeProperties184.Append(presetGeometry92);
            shapeProperties184.Append(outline93);

            ShapeStyle shapeStyle81 = new ShapeStyle();

            A.LineReference lineReference81 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor575 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference81.Append(schemeColor575);

            A.FillReference fillReference81 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor576 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference81.Append(schemeColor576);

            A.EffectReference effectReference81 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor577 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference81.Append(schemeColor577);

            A.FontReference fontReference81 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor578 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference81.Append(schemeColor578);

            shapeStyle81.Append(lineReference81);
            shapeStyle81.Append(fillReference81);
            shapeStyle81.Append(effectReference81);
            shapeStyle81.Append(fontReference81);

            connectionShape81.Append(nonVisualConnectionShapeProperties81);
            connectionShape81.Append(shapeProperties184);
            connectionShape81.Append(shapeStyle81);

            ConnectionShape connectionShape82 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties82 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties204 = new NonVisualDrawingProperties(){ Id = (UInt32Value)16U, Name = "Straight Connector 15" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties82 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties204 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties82.Append(nonVisualDrawingProperties204);
            nonVisualConnectionShapeProperties82.Append(nonVisualConnectorShapeDrawingProperties82);
            nonVisualConnectionShapeProperties82.Append(applicationNonVisualDrawingProperties204);

            ShapeProperties shapeProperties185 = new ShapeProperties();

            A.Transform2D transform2D124 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset143 = new A.Offset(){ X = 9209368L, Y = 3190344L };
            A.Extents extents143 = new A.Extents(){ Cx = 2982634L, Cy = 2981856L };

            transform2D124.Append(offset143);
            transform2D124.Append(extents143);

            A.PresetGeometry presetGeometry93 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList93 = new A.AdjustValueList();

            presetGeometry93.Append(adjustValueList93);

            A.Outline outline94 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill237 = new A.SolidFill();
            A.SchemeColor schemeColor579 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill237.Append(schemeColor579);

            outline94.Append(solidFill237);

            shapeProperties185.Append(transform2D124);
            shapeProperties185.Append(presetGeometry93);
            shapeProperties185.Append(outline94);

            ShapeStyle shapeStyle82 = new ShapeStyle();

            A.LineReference lineReference82 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor580 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference82.Append(schemeColor580);

            A.FillReference fillReference82 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor581 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference82.Append(schemeColor581);

            A.EffectReference effectReference82 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor582 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference82.Append(schemeColor582);

            A.FontReference fontReference82 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor583 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference82.Append(schemeColor583);

            shapeStyle82.Append(lineReference82);
            shapeStyle82.Append(fillReference82);
            shapeStyle82.Append(effectReference82);
            shapeStyle82.Append(fontReference82);

            connectionShape82.Append(nonVisualConnectionShapeProperties82);
            connectionShape82.Append(shapeProperties185);
            connectionShape82.Append(shapeStyle82);

            ConnectionShape connectionShape83 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties83 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties205 = new NonVisualDrawingProperties(){ Id = (UInt32Value)17U, Name = "Straight Connector 16" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties83 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties205 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties83.Append(nonVisualDrawingProperties205);
            nonVisualConnectionShapeProperties83.Append(nonVisualConnectorShapeDrawingProperties83);
            nonVisualConnectionShapeProperties83.Append(applicationNonVisualDrawingProperties205);

            ShapeProperties shapeProperties186 = new ShapeProperties();

            A.Transform2D transform2D125 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset144 = new A.Offset(){ X = 10294973L, Y = 3285068L };
            A.Extents extents144 = new A.Extents(){ Cx = 1897028L, Cy = 1896533L };

            transform2D125.Append(offset144);
            transform2D125.Append(extents144);

            A.PresetGeometry presetGeometry94 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList94 = new A.AdjustValueList();

            presetGeometry94.Append(adjustValueList94);

            A.Outline outline95 = new A.Outline(){ Width = 9525 };

            A.SolidFill solidFill238 = new A.SolidFill();
            A.SchemeColor schemeColor584 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill238.Append(schemeColor584);

            outline95.Append(solidFill238);

            shapeProperties186.Append(transform2D125);
            shapeProperties186.Append(presetGeometry94);
            shapeProperties186.Append(outline95);

            ShapeStyle shapeStyle83 = new ShapeStyle();

            A.LineReference lineReference83 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor585 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference83.Append(schemeColor585);

            A.FillReference fillReference83 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor586 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference83.Append(schemeColor586);

            A.EffectReference effectReference83 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor587 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference83.Append(schemeColor587);

            A.FontReference fontReference83 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor588 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference83.Append(schemeColor588);

            shapeStyle83.Append(lineReference83);
            shapeStyle83.Append(fillReference83);
            shapeStyle83.Append(effectReference83);
            shapeStyle83.Append(fontReference83);

            connectionShape83.Append(nonVisualConnectionShapeProperties83);
            connectionShape83.Append(shapeProperties186);
            connectionShape83.Append(shapeStyle83);

            ConnectionShape connectionShape84 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties84 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties206 = new NonVisualDrawingProperties(){ Id = (UInt32Value)18U, Name = "Straight Connector 17" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties84 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties206 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties84.Append(nonVisualDrawingProperties206);
            nonVisualConnectionShapeProperties84.Append(nonVisualConnectorShapeDrawingProperties84);
            nonVisualConnectionShapeProperties84.Append(applicationNonVisualDrawingProperties206);

            ShapeProperties shapeProperties187 = new ShapeProperties();

            A.Transform2D transform2D126 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset145 = new A.Offset(){ X = 10445823L, Y = 3131080L };
            A.Extents extents145 = new A.Extents(){ Cx = 1746177L, Cy = 1745720L };

            transform2D126.Append(offset145);
            transform2D126.Append(extents145);

            A.PresetGeometry presetGeometry95 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList95 = new A.AdjustValueList();

            presetGeometry95.Append(adjustValueList95);

            A.Outline outline96 = new A.Outline(){ Width = 28575 };

            A.SolidFill solidFill239 = new A.SolidFill();
            A.SchemeColor schemeColor589 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill239.Append(schemeColor589);

            outline96.Append(solidFill239);

            shapeProperties187.Append(transform2D126);
            shapeProperties187.Append(presetGeometry95);
            shapeProperties187.Append(outline96);

            ShapeStyle shapeStyle84 = new ShapeStyle();

            A.LineReference lineReference84 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor590 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference84.Append(schemeColor590);

            A.FillReference fillReference84 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor591 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference84.Append(schemeColor591);

            A.EffectReference effectReference84 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor592 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference84.Append(schemeColor592);

            A.FontReference fontReference84 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor593 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference84.Append(schemeColor593);

            shapeStyle84.Append(lineReference84);
            shapeStyle84.Append(fillReference84);
            shapeStyle84.Append(effectReference84);
            shapeStyle84.Append(fontReference84);

            connectionShape84.Append(nonVisualConnectionShapeProperties84);
            connectionShape84.Append(shapeProperties187);
            connectionShape84.Append(shapeStyle84);

            ConnectionShape connectionShape85 = new ConnectionShape();

            NonVisualConnectionShapeProperties nonVisualConnectionShapeProperties85 = new NonVisualConnectionShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties207 = new NonVisualDrawingProperties(){ Id = (UInt32Value)19U, Name = "Straight Connector 18" };
            NonVisualConnectorShapeDrawingProperties nonVisualConnectorShapeDrawingProperties85 = new NonVisualConnectorShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties207 = new ApplicationNonVisualDrawingProperties();

            nonVisualConnectionShapeProperties85.Append(nonVisualDrawingProperties207);
            nonVisualConnectionShapeProperties85.Append(nonVisualConnectorShapeDrawingProperties85);
            nonVisualConnectionShapeProperties85.Append(applicationNonVisualDrawingProperties207);

            ShapeProperties shapeProperties188 = new ShapeProperties();

            A.Transform2D transform2D127 = new A.Transform2D(){ HorizontalFlip = true };
            A.Offset offset146 = new A.Offset(){ X = 10921671L, Y = 3683002L };
            A.Extents extents146 = new A.Extents(){ Cx = 1270332L, Cy = 1269999L };

            transform2D127.Append(offset146);
            transform2D127.Append(extents146);

            A.PresetGeometry presetGeometry96 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Line };
            A.AdjustValueList adjustValueList96 = new A.AdjustValueList();

            presetGeometry96.Append(adjustValueList96);

            A.Outline outline97 = new A.Outline(){ Width = 28575 };

            A.SolidFill solidFill240 = new A.SolidFill();
            A.SchemeColor schemeColor594 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill240.Append(schemeColor594);

            outline97.Append(solidFill240);

            shapeProperties188.Append(transform2D127);
            shapeProperties188.Append(presetGeometry96);
            shapeProperties188.Append(outline97);

            ShapeStyle shapeStyle85 = new ShapeStyle();

            A.LineReference lineReference85 = new A.LineReference(){ Index = (UInt32Value)2U };
            A.SchemeColor schemeColor595 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            lineReference85.Append(schemeColor595);

            A.FillReference fillReference85 = new A.FillReference(){ Index = (UInt32Value)0U };
            A.SchemeColor schemeColor596 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference85.Append(schemeColor596);

            A.EffectReference effectReference85 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor597 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference85.Append(schemeColor597);

            A.FontReference fontReference85 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor598 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            fontReference85.Append(schemeColor598);

            shapeStyle85.Append(lineReference85);
            shapeStyle85.Append(fillReference85);
            shapeStyle85.Append(effectReference85);
            shapeStyle85.Append(fontReference85);

            connectionShape85.Append(nonVisualConnectionShapeProperties85);
            connectionShape85.Append(shapeProperties188);
            connectionShape85.Append(shapeStyle85);

            shapeTree19.Append(nonVisualGroupShapeProperties19);
            shapeTree19.Append(groupShapeProperties19);
            shapeTree19.Append(shape96);
            shapeTree19.Append(shape97);
            shapeTree19.Append(shape98);
            shapeTree19.Append(shape99);
            shapeTree19.Append(shape100);
            shapeTree19.Append(shape101);
            shapeTree19.Append(shape102);
            shapeTree19.Append(shape103);
            shapeTree19.Append(connectionShape81);
            shapeTree19.Append(connectionShape82);
            shapeTree19.Append(connectionShape83);
            shapeTree19.Append(connectionShape84);
            shapeTree19.Append(connectionShape85);

            CommonSlideDataExtensionList commonSlideDataExtensionList19 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension19 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId19 = new P14.CreationId(){ Val = (UInt32Value)493948837U };
            creationId19.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension19.Append(creationId19);

            commonSlideDataExtensionList19.Append(commonSlideDataExtension19);

            commonSlideData19.Append(shapeTree19);
            commonSlideData19.Append(commonSlideDataExtensionList19);

            ColorMapOverride colorMapOverride18 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping18 = new A.MasterColorMapping();

            colorMapOverride18.Append(masterColorMapping18);

            Timing timing19 = new Timing();

            TimeNodeList timeNodeList19 = new TimeNodeList();

            ParallelTimeNode parallelTimeNode19 = new ParallelTimeNode();
            CommonTimeNode commonTimeNode19 = new CommonTimeNode(){ Id = (UInt32Value)1U, Duration = "indefinite", Restart = TimeNodeRestartValues.Never, NodeType = TimeNodeValues.TmingRoot };

            parallelTimeNode19.Append(commonTimeNode19);

            timeNodeList19.Append(parallelTimeNode19);

            timing19.Append(timeNodeList19);

            slideLayout17.Append(commonSlideData19);
            slideLayout17.Append(colorMapOverride18);
            slideLayout17.Append(timing19);

            slideLayoutPart17.SlideLayout = slideLayout17;
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

            NormalViewProperties normalViewProperties1 = new NormalViewProperties();
            RestoredLeft restoredLeft1 = new RestoredLeft(){ Size = 20016, AutoAdjust = false };
            RestoredTop restoredTop1 = new RestoredTop(){ Size = 91045, AutoAdjust = false };

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
            Origin origin1 = new Origin(){ X = 324L, Y = 72L };

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
            GridSpacing gridSpacing1 = new GridSpacing(){ Cx = 72008L, Cy = 72008L };

            viewProperties1.Append(normalViewProperties1);
            viewProperties1.Append(slideViewProperties1);
            viewProperties1.Append(notesTextViewProperties1);
            viewProperties1.Append(gridSpacing1);

            viewPropertiesPart1.ViewProperties = viewProperties1;
        }

        // Generates content of extendedFilePropertiesPart1.
        private void GenerateExtendedFilePropertiesPart1Content(ExtendedFilePropertiesPart extendedFilePropertiesPart1)
        {
            Ap.Properties properties1 = new Ap.Properties();
            properties1.AddNamespaceDeclaration("vt", "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes");
            Ap.Template template1 = new Ap.Template();
            template1.Text = "slice";
            Ap.TotalTime totalTime1 = new Ap.TotalTime();
            totalTime1.Text = "20";
            Ap.Words words1 = new Ap.Words();
            words1.Text = "5";
            Ap.Application application1 = new Ap.Application();
            application1.Text = "Microsoft Office PowerPoint";
            Ap.PresentationFormat presentationFormat1 = new Ap.PresentationFormat();
            presentationFormat1.Text = "Widescreen";
            Ap.Paragraphs paragraphs1 = new Ap.Paragraphs();
            paragraphs1.Text = "2";
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
            vTInt321.Text = "4";

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

            Vt.VTVector vTVector2 = new Vt.VTVector(){ BaseType = Vt.VectorBaseValues.Lpstr, Size = (UInt32Value)6U };
            Vt.VTLPSTR vTLPSTR4 = new Vt.VTLPSTR();
            vTLPSTR4.Text = "Lucida Grande";
            Vt.VTLPSTR vTLPSTR5 = new Vt.VTLPSTR();
            vTLPSTR5.Text = "Arial";
            Vt.VTLPSTR vTLPSTR6 = new Vt.VTLPSTR();
            vTLPSTR6.Text = "Century Gothic";
            Vt.VTLPSTR vTLPSTR7 = new Vt.VTLPSTR();
            vTLPSTR7.Text = "Trebuchet MS";
            Vt.VTLPSTR vTLPSTR8 = new Vt.VTLPSTR();
            vTLPSTR8.Text = "Slice";
            Vt.VTLPSTR vTLPSTR9 = new Vt.VTLPSTR();
            vTLPSTR9.Text = "TEST";

            vTVector2.Append(vTLPSTR4);
            vTVector2.Append(vTLPSTR5);
            vTVector2.Append(vTLPSTR6);
            vTVector2.Append(vTLPSTR7);
            vTVector2.Append(vTLPSTR8);
            vTVector2.Append(vTLPSTR9);

            titlesOfParts1.Append(vTVector2);
            Ap.LinksUpToDate linksUpToDate1 = new Ap.LinksUpToDate();
            linksUpToDate1.Text = "false";
            Ap.SharedDocument sharedDocument1 = new Ap.SharedDocument();
            sharedDocument1.Text = "false";
            Ap.HyperlinksChanged hyperlinksChanged1 = new Ap.HyperlinksChanged();
            hyperlinksChanged1.Text = "false";
            Ap.ApplicationVersion applicationVersion1 = new Ap.ApplicationVersion();
            applicationVersion1.Text = "15.0000";

            properties1.Append(template1);
            properties1.Append(totalTime1);
            properties1.Append(words1);
            properties1.Append(application1);
            properties1.Append(presentationFormat1);
            properties1.Append(paragraphs1);
            properties1.Append(slides1);
            properties1.Append(notes1);
            properties1.Append(hiddenSlides1);
            properties1.Append(multimediaClips1);
            properties1.Append(scaleCrop1);
            properties1.Append(headingPairs1);
            properties1.Append(titlesOfParts1);
            properties1.Append(linksUpToDate1);
            properties1.Append(sharedDocument1);
            properties1.Append(hyperlinksChanged1);
            properties1.Append(applicationVersion1);

            extendedFilePropertiesPart1.Properties = properties1;
        }

        private void SetPackageProperties(OpenXmlPackage document)
        {
            document.PackageProperties.Creator = "Dan Ito";
            document.PackageProperties.Title = "PowerPoint プレゼンテーション";
            document.PackageProperties.Revision = "15";
            document.PackageProperties.Created = System.Xml.XmlConvert.ToDateTime("2012-01-27T09:12:05Z", System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
            document.PackageProperties.Modified = System.Xml.XmlConvert.ToDateTime("2012-10-03T08:43:44Z", System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
            document.PackageProperties.LastModifiedBy = "Dan Ito";
        }

        #region Binary Data
        private string thumbnailPart1Data = "/9j/4AAQSkZJRgABAQEAYABgAAD/2wBDAAMCAgMCAgMDAwMEAwMEBQgFBQQEBQoHBwYIDAoMDAsKCwsNDhIQDQ4RDgsLEBYQERMUFRUVDA8XGBYUGBIUFRT/2wBDAQMEBAUEBQkFBQkUDQsNFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBT/wAARCACQAQADASIAAhEBAxEB/8QAHwAAAQUBAQEBAQEAAAAAAAAAAAECAwQFBgcICQoL/8QAtRAAAgEDAwIEAwUFBAQAAAF9AQIDAAQRBRIhMUEGE1FhByJxFDKBkaEII0KxwRVS0fAkM2JyggkKFhcYGRolJicoKSo0NTY3ODk6Q0RFRkdISUpTVFVWV1hZWmNkZWZnaGlqc3R1dnd4eXqDhIWGh4iJipKTlJWWl5iZmqKjpKWmp6ipqrKztLW2t7i5usLDxMXGx8jJytLT1NXW19jZ2uHi4+Tl5ufo6erx8vP09fb3+Pn6/8QAHwEAAwEBAQEBAQEBAQAAAAAAAAECAwQFBgcICQoL/8QAtREAAgECBAQDBAcFBAQAAQJ3AAECAxEEBSExBhJBUQdhcRMiMoEIFEKRobHBCSMzUvAVYnLRChYkNOEl8RcYGRomJygpKjU2Nzg5OkNERUZHSElKU1RVVldYWVpjZGVmZ2hpanN0dXZ3eHl6goOEhYaHiImKkpOUlZaXmJmaoqOkpaanqKmqsrO0tba3uLm6wsPExcbHyMnK0tPU1dbX2Nna4uPk5ebn6Onq8vP09fb3+Pn6/9oADAMBAAIRAxEAPwD6UE1OE1Z4mpwmr+S7HzRfE1OE2KoCb3pRNRYDQE1KJveqAmpRNSsO5oCalE2aoCbFOE9FguXxNSiaqAmpwmpWAvib3pwmqgJvelE1KwF8TZpwmqgJs04TUWAvCanCaqAmpwmpWFYvCUUokBqiJqcJqLBYuhwaAQapib3pwmpWCxbzRVYTUompWAsUVCJs96UTUWAlopglzSiQGiwDqKaHFKGB70ALRRmnRoZGwMepJ6AUJX0AI4zI2BgY5JPQCtiCCPTYlllUNMRvjikHCj/no/8ARf8AJIIE02JZZVDTEb44nHAH/PR/6L/k0gJdUuH+f5fvyTSHgDuzH+Q98DJPPpwh9Xtpeb2Xb+v+CaJcvqedib3pwmrPE1KJq57EmgJqcJqzxNThNRYC+JqcJveqAm96UTUrAaAmpRNVATU4TUWCxfE1KJs1QE1OE1KwWL4mx3pwmqgJsUompWFYvianCaqAmpRNRYLF8TU4T1QE1OE2KVhWL4mpRNVATU4TUWAvianCbNZ4mpwm96Vhl8TU4TVQE2O9KJuaLAaAm96UTe9UBNzSialYLmgJqUTVQE1OE1Kwi+JqUTVRE1SRMZWwCBjkk9APU0KN9Bl6JjI2Bxjkk9APWtuBY9LhWWVQZiN8cL9FH/PRx/Jf8mlAsekwpLKoadhvihk6KO0kg/kv+TSWSbVrl/3h2jMks0p4A7sx/HAHvgZJ59KFP2FtLzey7f1/w5aVvUvLLLqtw/z4UfvJZpTwB3Zj+PA98DJPKXWoIYxb24K2ynOW4aRv7zf0Hb8yaN3qKNGLa2BS1U5y33pW/vN/Qdvckk1RNXLUna6i7t7v9F5fmJs8+833pwl461QE1OE9XYReEtOE1UBNThNmiwF4TU4TVRE1KJqVgL4npRP71REtKJaLAXxNThPVAS+9KJaVgNATUomqgJaUTUWA0BN704TVnialE1KwGgJqcJqzxNThP70WA0BNSib3rPE1OE1KwXNATU4TVnianCaiwF8TU4TVnianCalYDQE1KJqoCbFOE1FgsXxNSiaqAmqSFjK2AQAOST0A9TQo32CxfiJlbAwMcknoB6mt+2SPSIUllVWnI3xQyDhR2kkH8l/yaVukejwJNMqtcMPMigkHCjtLIPT+6v8AjzQWSbWrqTEmEGZJp5jwB3dj+OAPcAZJ59CFP2FtLzey7FpcvqXlkm1i5fEhCcyTTyngDu7H8cAe+Bknlt5qSNELW1DJaqc5b70rf3m/oOgB7kkmje6nGYha2gZLRDkluGlb++39B0APckk0xNXNUla6Tu3u/wBF5fmSy+JsU4TVQE3vThNXLYmx56J6cJqoCWlE1dthmgJ6cJ6qGG4UAmGQA4AJQ85p4t7gSInkS73OFXYcsfQetPkfYZZE1OE1VEhncsFhkYqdrAITg+hpgmweaTi0BoCb3pwmrOE1OE1TYRoCanCes8TU4TUWA0BNThNWcJ6cJqVgNATU4TVnialE1FgNATU4S1nianCalYC+JfenCXmqAmpRNSsBfEtOE2KoCanCaiwF4TU4TVRE2aUTZpWAvCanCeqImzUkOZmwpAAGSx6KPU0KN9gL8LNM2AQAOSx6Aepro7aOLRYEmmRWuWAkhglHCjtLIPT+6v8APPNK1ii0O3SadFa5YCSG3lHCjtLKPT+6v8885yyT67dyASkIMyz3E5wAO7ufxwAM9QBknn0YU/YW0vN7LsWlb1Lqyz63dyYkwgzLNcTHgDu7n8cAc9QBknlL7VI2hFpaBks0O4luGmb++364HQA9ySTQv9UjaEWdmGjskO4luHmbpvf9cL0UHuSSaIl4rmnO10ndvd/ovL8xN2NATUom96oCalE1ctiTQE1OE1Z4mpRNRYDgBPSias8TU4TV22A9m8Ka7f3V38NY5r65lifU23I8zMDtnTbwT27Viab4xWO/NzHJrmp2sdtLHdvPPmS3ik2p5kbDOw5IGTwcgHrXAW+t3tq9q8N5cQtaP5lu0crKYWzncmD8pyAcj0rRbx34gluYbiTXdRlnhDCOSS6kYoGGGAJPAIGCO9ex9evFJtpq3nsorv5X8/I25z0KO+1bRL7xbH/bV3dCTR4ruK5EjRtIrtbGN2GeH2MoPU9eT1PmpnLsWLEseST1NRTa7fXNzdTy3txJPdArcSPKxaYZBwxz8wyAefQelVhNXFia3tmrXsr7u+7bIlK5fEtOEtUBNSiauKxBfEtOE1UBNThNRYC8JsU4TVRE1KJqVgLwmpwmqiJs0olosBfE1KJ6oiXjrSiX3pWAvianCeqAlpRLSsBoCelE1Z4mpwmzRYDQE1OE1Z4mqWDdO+1SAAMlj0UepoSuBoQFpnwpAAGSx6KPU109rFFoVuk86K10yiSG3lHCjtNKPT+6vv3zzRtIotAto57hFe6ZRJBbTDhB2mlHpz8qe/fPOYklx4hvZQJSEGZri6nOAB0Mjnn1wAM9QBknn0IU/YW0vN7LsaJWLySXGv3kuJTsGZZ7mc4AHd3PPrgAZ6gDJPLdQ1aNoRZWQaOxRtxLDDzP03v+ZwvRQe5JJoajrETQCxsQ0dijbiXGHnfpvf8AM4XooPckk54nrmnK10ndvd/ovL8yWzRE9KJqzxP704TVy2JNATU4TVnielE1FgNATU4S1nianCb3pWA8+E1KJs96oCanCau2wETarfQIWe0EwJOBHkEDIAyMH/PaiTXLsh1TT5N2GwxzjIGR2/z71OJqUTVpeP8AKO4641C6t5zthE0e0HC5BB+bPIznoOMd+/So49aumQsbFgofaMFsnkDOCo4wc/hUgmpRNU3XYCC31m8Ij82zbLDPG7j5iMfd64wecD3qaTVLwwQMtusUjSBXUhnAUpuyMAd8DJGKeJqcJqG12C5Bb63ezfKdPdWBALOxUHnGR8p+tPTW7t5vLGnuDgHc7EL93J52+vH+FSianCai8f5QuTWl/I8JaaNo33NhVUn5cnHb0H+cirYmrPE1OE1Q1fYRfE1OE1UBNSiapsBoCenCas8TU4TUWAvianCas8TU4Te9KwGgJqcJqzhNThNRYDQE1dRp1pH4egS8vUV7+RRJBay/diXtLKP/AEFe/HsDS0yyj8OwR3t8iSag6+Zb2ko+WFe00o9P7q9+PYGgklz4kvpQJiIxma4urg8KOhkkPPrgAZ6gDJPPbCn7KzavJ7Lt5/1sWlb1LySXPiK9lAmIQZmuLq4PAHeRzz64AGeoAyTyzUtXiaAWNiGjsEbcS4w879N74+pwvRQe5LE0dT1mJoFsLANFp8bbiX4e4cceY+PqcL0UHuSxOaJqxnK10ndvd/p6fmJsviWlEtURNThN71zWJLwmpRNVETU4TUrAXhNThNVATU4TZosBeE1OE1UBL704S+9KwHnwmpwmqgJqcJsV22GXhNThPVAS04S0rAXxNSiaqAl96cJfeiwF8T04TVniXmnCalYDQE1KJqzxNThNiiwGgJqcJqzxNSialYDQE1OE1Z4n96cJ6VgL4m96cJqoCalE1FgNATZpRNVATe9OE1Kwi+Jq6fQktNIso9TnMN1eyAtbWzHMcIBwZZfoRwvc/gDycGyKMTzjKH7keeZD/Rffv0Hch95qZuDtUkRgg8gAsQMAkDpgcADgD8Sd6bVP3mten+ZSdtTeSS68TX8wExEYzPc3dycBR0Mkh59cADPUAAk8s1TWont10/Tw8WnRtuJfiS4cceY+PqcL0UHuSzNzq3BCkBiFPUA8GgTe9S6jafd7sLl8TU4TVQE1KJqxsSXxN704TVQE2KcJqVgL4mpwmrPE3vThNRYC+JqcJ6zxNThNRYDQE1KJqoCalE3vSsB5+JqcJqzhNThNXbYqxoialE1Z4mpwn96VgsaAmpwmrOE9OE9FhWNETYpRNWeJqcJ6VgsaAmpRNVAT0omosBoCbNKJc1QE9OE1KwF8S0ol96oCanCb3pWAviWlEvFURNThNRYC8JsVagCRRCecZQ/cjzzIfX2X379B3IowbIoxPOMof9XFnBkPr7L79+g7kRzXj3Ehdzlj7YAHYD0HtT5basC9LePcSF3bLH8AB2AHYe1IJqoCanCWpauBeE9OE9UBLThL70rAXxNThNWeJfenCWlYC+JqcJqzxNThNmiwGgJqUTVnianCelYDQE1OE1Z4npwmpWAvianCas8TU4TUWEef+dSiWqAmpRPXbYs0BLS+b71QE9OE1FgL4l460olqiJqcJqVgLwmpRNVETU4TUWAvCanCeqAmpwlpWAvCanCaqAlpwlosBfE9OE1Z4lpwlpWAvianCas8TU4TUWFY05bx55C7tuY4HpgDoB6D2pBNWcJqcJqGrhY0BPThNWeJ/elE9KwWNETU4TVnCenCalYVjQE2acJqzxPSialYLGiJqUTVnifnrThPRYDQE2KUS1QE1KJqVgNAS80olqgJqcJqVgL4l96US1RE1KJqLAf/2Q==";

        private System.IO.Stream GetBinaryDataStream(string base64String)
        {
            return new System.IO.MemoryStream(System.Convert.FromBase64String(base64String));
        }

        #endregion

    }
}
