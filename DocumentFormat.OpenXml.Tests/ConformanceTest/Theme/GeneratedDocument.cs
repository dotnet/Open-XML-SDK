// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using P = DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml;
using A = DocumentFormat.OpenXml.Drawing;
using P15 = DocumentFormat.OpenXml.Office2013.PowerPoint;
using P14 = DocumentFormat.OpenXml.Office2010.PowerPoint;
using Ap = DocumentFormat.OpenXml.ExtendedProperties;
using Vt = DocumentFormat.OpenXml.VariantTypes;

namespace DocumentFormat.OpenXml.Tests.ThemeClass
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

            SlideLayoutPart slideLayoutPart3 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId3");
            GenerateSlideLayoutPart3Content(slideLayoutPart3);

            slideLayoutPart3.AddPart(slideMasterPart1, "rId1");

            SlideLayoutPart slideLayoutPart4 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId7");
            GenerateSlideLayoutPart4Content(slideLayoutPart4);

            slideLayoutPart4.AddPart(slideMasterPart1, "rId1");

            ThemePart themePart1 = slideMasterPart1.AddNewPart<ThemePart>("rId12");
            GenerateThemePart1Content(themePart1);

            ImagePart imagePart1 = themePart1.AddNewPart<ImagePart>("image/jpeg", "rId1");
            GenerateImagePart1Content(imagePart1);

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
            SlideMasterId slideMasterId1 = new SlideMasterId(){ Id = (UInt32Value)2147483660U, RelationshipId = "rId1" };

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
            NonVisualDrawingProperties nonVisualDrawingProperties2 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

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
            A.EndParagraphRunProperties endParagraphRunProperties1 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph1.Append(endParagraphRunProperties1);

            textBody1.Append(bodyProperties1);
            textBody1.Append(listStyle1);
            textBody1.Append(paragraph1);

            shape1.Append(nonVisualShapeProperties1);
            shape1.Append(shapeProperties1);
            shape1.Append(textBody1);

            Shape shape2 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties2 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties3 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Subtitle 2" };

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
            A.EndParagraphRunProperties endParagraphRunProperties2 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

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

            P14.CreationId creationId1 = new P14.CreationId(){ Val = (UInt32Value)3945659514U };
            creationId1.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension1.Append(creationId1);

            commonSlideDataExtensionList1.Append(commonSlideDataExtension1);

            commonSlideData1.Append(shapeTree1);
            commonSlideData1.Append(commonSlideDataExtensionList1);

            ColorMapOverride colorMapOverride1 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping1 = new A.MasterColorMapping();

            colorMapOverride1.Append(masterColorMapping1);

            Timing timing1 = new Timing();

            TimeNodeList timeNodeList1 = new TimeNodeList();

            ParallelTimeNode parallelTimeNode1 = new ParallelTimeNode();
            CommonTimeNode commonTimeNode1 = new CommonTimeNode(){ Id = (UInt32Value)1U, Duration = "indefinite", Restart = TimeNodeRestartValues.Never, NodeType = TimeNodeValues.TmingRoot };

            parallelTimeNode1.Append(commonTimeNode1);

            timeNodeList1.Append(parallelTimeNode1);

            timing1.Append(timeNodeList1);

            slide1.Append(commonSlideData1);
            slide1.Append(colorMapOverride1);
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
            NonVisualDrawingProperties nonVisualDrawingProperties5 = new NonVisualDrawingProperties(){ Id = (UInt32Value)8U, Name = "Title 7" };

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
            A.Offset offset3 = new A.Offset(){ X = 562707L, Y = 1371600L };
            A.Extents extents3 = new A.Extents(){ Cx = 10972800L, Cy = 1828800L };

            transform2D1.Append(offset3);
            transform2D1.Append(extents3);

            shapeProperties3.Append(transform2D1);

            TextBody textBody3 = new TextBody();

            A.BodyProperties bodyProperties3 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal, LeftInset = 45720, TopInset = 0, RightInset = 45720, BottomInset = 0, Anchor = A.TextAnchoringTypeValues.Bottom };
            A.NormalAutoFit normalAutoFit1 = new A.NormalAutoFit();

            A.Scene3DType scene3DType1 = new A.Scene3DType();
            A.Camera camera1 = new A.Camera(){ Preset = A.PresetCameraValues.OrthographicFront };

            A.LightRig lightRig1 = new A.LightRig(){ Rig = A.LightRigValues.Soft, Direction = A.LightRigDirectionValues.Top };
            A.Rotation rotation1 = new A.Rotation(){ Latitude = 0, Longitude = 0, Revolution = 17220000 };

            lightRig1.Append(rotation1);

            scene3DType1.Append(camera1);
            scene3DType1.Append(lightRig1);

            A.Shape3DType shape3DType1 = new A.Shape3DType(){ PresetMaterial = A.PresetMaterialTypeValues.SoftEdge };
            A.BevelTop bevelTop1 = new A.BevelTop(){ Width = 38100L, Height = 38100L };

            shape3DType1.Append(bevelTop1);

            bodyProperties3.Append(normalAutoFit1);
            bodyProperties3.Append(scene3DType1);
            bodyProperties3.Append(shape3DType1);

            A.ListStyle listStyle3 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties2 = new A.Level1ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties11 = new A.DefaultRunProperties(){ FontSize = 4800, Bold = true, Capital = A.TextCapsValues.All, Baseline = 0 };

            A.Outline outline1 = new A.Outline(){ Width = 6350 };
            A.NoFill noFill1 = new A.NoFill();

            outline1.Append(noFill1);

            A.GradientFill gradientFill1 = new A.GradientFill();

            A.GradientStopList gradientStopList1 = new A.GradientStopList();

            A.GradientStop gradientStop1 = new A.GradientStop(){ Position = 0 };

            A.SchemeColor schemeColor10 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };
            A.Tint tint1 = new A.Tint(){ Val = 73000 };
            A.SaturationModulation saturationModulation1 = new A.SaturationModulation(){ Val = 145000 };

            schemeColor10.Append(tint1);
            schemeColor10.Append(saturationModulation1);

            gradientStop1.Append(schemeColor10);

            A.GradientStop gradientStop2 = new A.GradientStop(){ Position = 73000 };

            A.SchemeColor schemeColor11 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };
            A.Tint tint2 = new A.Tint(){ Val = 73000 };
            A.SaturationModulation saturationModulation2 = new A.SaturationModulation(){ Val = 145000 };

            schemeColor11.Append(tint2);
            schemeColor11.Append(saturationModulation2);

            gradientStop2.Append(schemeColor11);

            A.GradientStop gradientStop3 = new A.GradientStop(){ Position = 100000 };

            A.SchemeColor schemeColor12 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };
            A.Tint tint3 = new A.Tint(){ Val = 83000 };
            A.SaturationModulation saturationModulation3 = new A.SaturationModulation(){ Val = 143000 };

            schemeColor12.Append(tint3);
            schemeColor12.Append(saturationModulation3);

            gradientStop3.Append(schemeColor12);

            gradientStopList1.Append(gradientStop1);
            gradientStopList1.Append(gradientStop2);
            gradientStopList1.Append(gradientStop3);
            A.LinearGradientFill linearGradientFill1 = new A.LinearGradientFill(){ Angle = 4800000, Scaled = true };

            gradientFill1.Append(gradientStopList1);
            gradientFill1.Append(linearGradientFill1);

            A.EffectList effectList1 = new A.EffectList();

            A.OuterShadow outerShadow1 = new A.OuterShadow(){ BlurRadius = 127000L, Distance = 200000L, Direction = 2700000, Alignment = A.RectangleAlignmentValues.TopLeft, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex1 = new A.RgbColorModelHex(){ Val = "000000" };
            A.Alpha alpha1 = new A.Alpha(){ Val = 30000 };

            rgbColorModelHex1.Append(alpha1);

            outerShadow1.Append(rgbColorModelHex1);

            effectList1.Append(outerShadow1);

            defaultRunProperties11.Append(outline1);
            defaultRunProperties11.Append(gradientFill1);
            defaultRunProperties11.Append(effectList1);

            level1ParagraphProperties2.Append(defaultRunProperties11);

            listStyle3.Append(level1ParagraphProperties2);

            A.Paragraph paragraph3 = new A.Paragraph();

            A.Run run1 = new A.Run();

            A.RunProperties runProperties1 = new A.RunProperties(){ Kumimoji = false, Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties1.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text1 = new A.Text();
            text1.Text = "Click to edit Master title style";

            run1.Append(runProperties1);
            run1.Append(text1);
            A.EndParagraphRunProperties endParagraphRunProperties3 = new A.EndParagraphRunProperties(){ Kumimoji = false, Language = "en-US" };

            paragraph3.Append(run1);
            paragraph3.Append(endParagraphRunProperties3);

            textBody3.Append(bodyProperties3);
            textBody3.Append(listStyle3);
            textBody3.Append(paragraph3);

            shape3.Append(nonVisualShapeProperties3);
            shape3.Append(shapeProperties3);
            shape3.Append(textBody3);

            Shape shape4 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties4 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties6 = new NonVisualDrawingProperties(){ Id = (UInt32Value)28U, Name = "Date Placeholder 27" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties4 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks4 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties4.Append(shapeLocks4);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties6 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape4 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties6.Append(placeholderShape4);

            nonVisualShapeProperties4.Append(nonVisualDrawingProperties6);
            nonVisualShapeProperties4.Append(nonVisualShapeDrawingProperties4);
            nonVisualShapeProperties4.Append(applicationNonVisualDrawingProperties6);
            ShapeProperties shapeProperties4 = new ShapeProperties();

            TextBody textBody4 = new TextBody();
            A.BodyProperties bodyProperties4 = new A.BodyProperties();
            A.ListStyle listStyle4 = new A.ListStyle();

            A.Paragraph paragraph4 = new A.Paragraph();

            A.Field field1 = new A.Field(){ Id = "{8263865E-5382-4BDD-A09E-2B63F38BCE59}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties2 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties2.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text2 = new A.Text();
            text2.Text = "2012/10/3";

            field1.Append(runProperties2);
            field1.Append(text2);
            A.EndParagraphRunProperties endParagraphRunProperties4 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph4.Append(field1);
            paragraph4.Append(endParagraphRunProperties4);

            textBody4.Append(bodyProperties4);
            textBody4.Append(listStyle4);
            textBody4.Append(paragraph4);

            shape4.Append(nonVisualShapeProperties4);
            shape4.Append(shapeProperties4);
            shape4.Append(textBody4);

            Shape shape5 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties5 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties7 = new NonVisualDrawingProperties(){ Id = (UInt32Value)17U, Name = "Footer Placeholder 16" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties5 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks5 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties5.Append(shapeLocks5);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties7 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape5 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties7.Append(placeholderShape5);

            nonVisualShapeProperties5.Append(nonVisualDrawingProperties7);
            nonVisualShapeProperties5.Append(nonVisualShapeDrawingProperties5);
            nonVisualShapeProperties5.Append(applicationNonVisualDrawingProperties7);
            ShapeProperties shapeProperties5 = new ShapeProperties();

            TextBody textBody5 = new TextBody();
            A.BodyProperties bodyProperties5 = new A.BodyProperties();
            A.ListStyle listStyle5 = new A.ListStyle();

            A.Paragraph paragraph5 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties5 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph5.Append(endParagraphRunProperties5);

            textBody5.Append(bodyProperties5);
            textBody5.Append(listStyle5);
            textBody5.Append(paragraph5);

            shape5.Append(nonVisualShapeProperties5);
            shape5.Append(shapeProperties5);
            shape5.Append(textBody5);

            Shape shape6 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties6 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties8 = new NonVisualDrawingProperties(){ Id = (UInt32Value)29U, Name = "Slide Number Placeholder 28" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties6 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks6 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties6.Append(shapeLocks6);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties8 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape6 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties8.Append(placeholderShape6);

            nonVisualShapeProperties6.Append(nonVisualDrawingProperties8);
            nonVisualShapeProperties6.Append(nonVisualShapeDrawingProperties6);
            nonVisualShapeProperties6.Append(applicationNonVisualDrawingProperties8);
            ShapeProperties shapeProperties6 = new ShapeProperties();

            TextBody textBody6 = new TextBody();
            A.BodyProperties bodyProperties6 = new A.BodyProperties();
            A.ListStyle listStyle6 = new A.ListStyle();

            A.Paragraph paragraph6 = new A.Paragraph();

            A.Field field2 = new A.Field(){ Id = "{DF0B8B9E-EDC2-479A-B980-EDD8632819B1}", Type = "slidenum" };

            A.RunProperties runProperties3 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties3.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text3 = new A.Text();
            text3.Text = "‹#›";

            field2.Append(runProperties3);
            field2.Append(text3);
            A.EndParagraphRunProperties endParagraphRunProperties6 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph6.Append(field2);
            paragraph6.Append(endParagraphRunProperties6);

            textBody6.Append(bodyProperties6);
            textBody6.Append(listStyle6);
            textBody6.Append(paragraph6);

            shape6.Append(nonVisualShapeProperties6);
            shape6.Append(shapeProperties6);
            shape6.Append(textBody6);

            Shape shape7 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties7 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties9 = new NonVisualDrawingProperties(){ Id = (UInt32Value)9U, Name = "Subtitle 8" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties7 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks7 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties7.Append(shapeLocks7);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties9 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape7 = new PlaceholderShape(){ Type = PlaceholderValues.SubTitle, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties9.Append(placeholderShape7);

            nonVisualShapeProperties7.Append(nonVisualDrawingProperties9);
            nonVisualShapeProperties7.Append(nonVisualShapeDrawingProperties7);
            nonVisualShapeProperties7.Append(applicationNonVisualDrawingProperties9);

            ShapeProperties shapeProperties7 = new ShapeProperties();

            A.Transform2D transform2D2 = new A.Transform2D();
            A.Offset offset4 = new A.Offset(){ X = 1828800L, Y = 3331698L };
            A.Extents extents4 = new A.Extents(){ Cx = 8534400L, Cy = 1752600L };

            transform2D2.Append(offset4);
            transform2D2.Append(extents4);

            shapeProperties7.Append(transform2D2);

            TextBody textBody7 = new TextBody();
            A.BodyProperties bodyProperties7 = new A.BodyProperties();

            A.ListStyle listStyle7 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties3 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet1 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties12 = new A.DefaultRunProperties();

            A.SolidFill solidFill10 = new A.SolidFill();
            A.SchemeColor schemeColor13 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill10.Append(schemeColor13);

            defaultRunProperties12.Append(solidFill10);

            level1ParagraphProperties3.Append(noBullet1);
            level1ParagraphProperties3.Append(defaultRunProperties12);

            A.Level2ParagraphProperties level2ParagraphProperties2 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet2 = new A.NoBullet();

            level2ParagraphProperties2.Append(noBullet2);

            A.Level3ParagraphProperties level3ParagraphProperties2 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet3 = new A.NoBullet();

            level3ParagraphProperties2.Append(noBullet3);

            A.Level4ParagraphProperties level4ParagraphProperties2 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet4 = new A.NoBullet();

            level4ParagraphProperties2.Append(noBullet4);

            A.Level5ParagraphProperties level5ParagraphProperties2 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet5 = new A.NoBullet();

            level5ParagraphProperties2.Append(noBullet5);

            A.Level6ParagraphProperties level6ParagraphProperties2 = new A.Level6ParagraphProperties(){ LeftMargin = 2286000, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet6 = new A.NoBullet();

            level6ParagraphProperties2.Append(noBullet6);

            A.Level7ParagraphProperties level7ParagraphProperties2 = new A.Level7ParagraphProperties(){ LeftMargin = 2743200, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet7 = new A.NoBullet();

            level7ParagraphProperties2.Append(noBullet7);

            A.Level8ParagraphProperties level8ParagraphProperties2 = new A.Level8ParagraphProperties(){ LeftMargin = 3200400, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet8 = new A.NoBullet();

            level8ParagraphProperties2.Append(noBullet8);

            A.Level9ParagraphProperties level9ParagraphProperties2 = new A.Level9ParagraphProperties(){ LeftMargin = 3657600, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet9 = new A.NoBullet();

            level9ParagraphProperties2.Append(noBullet9);

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

            A.RunProperties runProperties4 = new A.RunProperties(){ Kumimoji = false, Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties4.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text4 = new A.Text();
            text4.Text = "Click to edit Master subtitle style";

            run2.Append(runProperties4);
            run2.Append(text4);
            A.EndParagraphRunProperties endParagraphRunProperties7 = new A.EndParagraphRunProperties(){ Kumimoji = false, Language = "en-US" };

            paragraph7.Append(run2);
            paragraph7.Append(endParagraphRunProperties7);

            textBody7.Append(bodyProperties7);
            textBody7.Append(listStyle7);
            textBody7.Append(paragraph7);

            shape7.Append(nonVisualShapeProperties7);
            shape7.Append(shapeProperties7);
            shape7.Append(textBody7);

            shapeTree2.Append(nonVisualGroupShapeProperties2);
            shapeTree2.Append(groupShapeProperties2);
            shapeTree2.Append(shape3);
            shapeTree2.Append(shape4);
            shapeTree2.Append(shape5);
            shapeTree2.Append(shape6);
            shapeTree2.Append(shape7);

            CommonSlideDataExtensionList commonSlideDataExtensionList2 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension2 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId2 = new P14.CreationId(){ Val = (UInt32Value)1153735895U };
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

            BackgroundStyleReference backgroundStyleReference1 = new BackgroundStyleReference(){ Index = (UInt32Value)1003U };
            A.SchemeColor schemeColor14 = new A.SchemeColor(){ Val = A.SchemeColorValues.Background2 };

            backgroundStyleReference1.Append(schemeColor14);

            background1.Append(backgroundStyleReference1);

            ShapeTree shapeTree3 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties3 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties10 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties3 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties10 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties3.Append(nonVisualDrawingProperties10);
            nonVisualGroupShapeProperties3.Append(nonVisualGroupShapeDrawingProperties3);
            nonVisualGroupShapeProperties3.Append(applicationNonVisualDrawingProperties10);

            GroupShapeProperties groupShapeProperties3 = new GroupShapeProperties();

            A.TransformGroup transformGroup3 = new A.TransformGroup();
            A.Offset offset5 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents5 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset3 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents3 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup3.Append(offset5);
            transformGroup3.Append(extents5);
            transformGroup3.Append(childOffset3);
            transformGroup3.Append(childExtents3);

            groupShapeProperties3.Append(transformGroup3);

            Shape shape8 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties8 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties11 = new NonVisualDrawingProperties(){ Id = (UInt32Value)22U, Name = "Title Placeholder 21" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties8 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks8 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties8.Append(shapeLocks8);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties11 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape8 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties11.Append(placeholderShape8);

            nonVisualShapeProperties8.Append(nonVisualDrawingProperties11);
            nonVisualShapeProperties8.Append(nonVisualShapeDrawingProperties8);
            nonVisualShapeProperties8.Append(applicationNonVisualDrawingProperties11);

            ShapeProperties shapeProperties8 = new ShapeProperties();

            A.Transform2D transform2D3 = new A.Transform2D();
            A.Offset offset6 = new A.Offset(){ X = 609600L, Y = 274638L };
            A.Extents extents6 = new A.Extents(){ Cx = 10972800L, Cy = 1143000L };

            transform2D3.Append(offset6);
            transform2D3.Append(extents6);

            A.PresetGeometry presetGeometry1 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList1 = new A.AdjustValueList();

            presetGeometry1.Append(adjustValueList1);

            shapeProperties8.Append(transform2D3);
            shapeProperties8.Append(presetGeometry1);

            TextBody textBody8 = new TextBody();

            A.BodyProperties bodyProperties8 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal, Anchor = A.TextAnchoringTypeValues.Center };
            A.NormalAutoFit normalAutoFit2 = new A.NormalAutoFit();

            A.Scene3DType scene3DType2 = new A.Scene3DType();
            A.Camera camera2 = new A.Camera(){ Preset = A.PresetCameraValues.OrthographicFront };

            A.LightRig lightRig2 = new A.LightRig(){ Rig = A.LightRigValues.Soft, Direction = A.LightRigDirectionValues.Top };
            A.Rotation rotation2 = new A.Rotation(){ Latitude = 0, Longitude = 0, Revolution = 16800000 };

            lightRig2.Append(rotation2);

            scene3DType2.Append(camera2);
            scene3DType2.Append(lightRig2);

            A.Shape3DType shape3DType2 = new A.Shape3DType(){ PresetMaterial = A.PresetMaterialTypeValues.SoftEdge };
            A.BevelTop bevelTop2 = new A.BevelTop(){ Width = 38100L, Height = 38100L };

            shape3DType2.Append(bevelTop2);

            bodyProperties8.Append(normalAutoFit2);
            bodyProperties8.Append(scene3DType2);
            bodyProperties8.Append(shape3DType2);
            A.ListStyle listStyle8 = new A.ListStyle();

            A.Paragraph paragraph8 = new A.Paragraph();

            A.Run run3 = new A.Run();

            A.RunProperties runProperties5 = new A.RunProperties(){ Kumimoji = false, Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties5.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text5 = new A.Text();
            text5.Text = "Click to edit Master title style";

            run3.Append(runProperties5);
            run3.Append(text5);
            A.EndParagraphRunProperties endParagraphRunProperties8 = new A.EndParagraphRunProperties(){ Kumimoji = false, Language = "en-US" };

            paragraph8.Append(run3);
            paragraph8.Append(endParagraphRunProperties8);

            textBody8.Append(bodyProperties8);
            textBody8.Append(listStyle8);
            textBody8.Append(paragraph8);

            shape8.Append(nonVisualShapeProperties8);
            shape8.Append(shapeProperties8);
            shape8.Append(textBody8);

            Shape shape9 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties9 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties12 = new NonVisualDrawingProperties(){ Id = (UInt32Value)13U, Name = "Text Placeholder 12" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties9 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks9 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties9.Append(shapeLocks9);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties12 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape9 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties12.Append(placeholderShape9);

            nonVisualShapeProperties9.Append(nonVisualDrawingProperties12);
            nonVisualShapeProperties9.Append(nonVisualShapeDrawingProperties9);
            nonVisualShapeProperties9.Append(applicationNonVisualDrawingProperties12);

            ShapeProperties shapeProperties9 = new ShapeProperties();

            A.Transform2D transform2D4 = new A.Transform2D();
            A.Offset offset7 = new A.Offset(){ X = 609600L, Y = 1600200L };
            A.Extents extents7 = new A.Extents(){ Cx = 10972800L, Cy = 4709160L };

            transform2D4.Append(offset7);
            transform2D4.Append(extents7);

            A.PresetGeometry presetGeometry2 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList2 = new A.AdjustValueList();

            presetGeometry2.Append(adjustValueList2);

            shapeProperties9.Append(transform2D4);
            shapeProperties9.Append(presetGeometry2);

            TextBody textBody9 = new TextBody();

            A.BodyProperties bodyProperties9 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal };
            A.NormalAutoFit normalAutoFit3 = new A.NormalAutoFit();

            bodyProperties9.Append(normalAutoFit3);
            A.ListStyle listStyle9 = new A.ListStyle();

            A.Paragraph paragraph9 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties1 = new A.ParagraphProperties(){ Level = 0, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run4 = new A.Run();

            A.RunProperties runProperties6 = new A.RunProperties(){ Kumimoji = false, Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties6.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text6 = new A.Text();
            text6.Text = "Click to edit Master text styles";

            run4.Append(runProperties6);
            run4.Append(text6);

            paragraph9.Append(paragraphProperties1);
            paragraph9.Append(run4);

            A.Paragraph paragraph10 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties2 = new A.ParagraphProperties(){ Level = 1, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run5 = new A.Run();

            A.RunProperties runProperties7 = new A.RunProperties(){ Kumimoji = false, Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties7.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text7 = new A.Text();
            text7.Text = "Second level";

            run5.Append(runProperties7);
            run5.Append(text7);

            paragraph10.Append(paragraphProperties2);
            paragraph10.Append(run5);

            A.Paragraph paragraph11 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties3 = new A.ParagraphProperties(){ Level = 2, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run6 = new A.Run();

            A.RunProperties runProperties8 = new A.RunProperties(){ Kumimoji = false, Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties8.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text8 = new A.Text();
            text8.Text = "Third level";

            run6.Append(runProperties8);
            run6.Append(text8);

            paragraph11.Append(paragraphProperties3);
            paragraph11.Append(run6);

            A.Paragraph paragraph12 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties4 = new A.ParagraphProperties(){ Level = 3, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run7 = new A.Run();

            A.RunProperties runProperties9 = new A.RunProperties(){ Kumimoji = false, Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties9.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text9 = new A.Text();
            text9.Text = "Fourth level";

            run7.Append(runProperties9);
            run7.Append(text9);

            paragraph12.Append(paragraphProperties4);
            paragraph12.Append(run7);

            A.Paragraph paragraph13 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties5 = new A.ParagraphProperties(){ Level = 4, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run8 = new A.Run();

            A.RunProperties runProperties10 = new A.RunProperties(){ Kumimoji = false, Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties10.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text10 = new A.Text();
            text10.Text = "Fifth level";

            run8.Append(runProperties10);
            run8.Append(text10);
            A.EndParagraphRunProperties endParagraphRunProperties9 = new A.EndParagraphRunProperties(){ Kumimoji = false, Language = "en-US" };

            paragraph13.Append(paragraphProperties5);
            paragraph13.Append(run8);
            paragraph13.Append(endParagraphRunProperties9);

            textBody9.Append(bodyProperties9);
            textBody9.Append(listStyle9);
            textBody9.Append(paragraph9);
            textBody9.Append(paragraph10);
            textBody9.Append(paragraph11);
            textBody9.Append(paragraph12);
            textBody9.Append(paragraph13);

            shape9.Append(nonVisualShapeProperties9);
            shape9.Append(shapeProperties9);
            shape9.Append(textBody9);

            Shape shape10 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties10 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties13 = new NonVisualDrawingProperties(){ Id = (UInt32Value)14U, Name = "Date Placeholder 13" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties10 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks10 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties10.Append(shapeLocks10);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties13 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape10 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)2U };

            applicationNonVisualDrawingProperties13.Append(placeholderShape10);

            nonVisualShapeProperties10.Append(nonVisualDrawingProperties13);
            nonVisualShapeProperties10.Append(nonVisualShapeDrawingProperties10);
            nonVisualShapeProperties10.Append(applicationNonVisualDrawingProperties13);

            ShapeProperties shapeProperties10 = new ShapeProperties();

            A.Transform2D transform2D5 = new A.Transform2D();
            A.Offset offset8 = new A.Offset(){ X = 609600L, Y = 6416676L };
            A.Extents extents8 = new A.Extents(){ Cx = 2844800L, Cy = 365125L };

            transform2D5.Append(offset8);
            transform2D5.Append(extents8);

            A.PresetGeometry presetGeometry3 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList3 = new A.AdjustValueList();

            presetGeometry3.Append(adjustValueList3);

            shapeProperties10.Append(transform2D5);
            shapeProperties10.Append(presetGeometry3);

            TextBody textBody10 = new TextBody();
            A.BodyProperties bodyProperties10 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal, Anchor = A.TextAnchoringTypeValues.Bottom };

            A.ListStyle listStyle10 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties4 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Left, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties13 = new A.DefaultRunProperties(){ Kumimoji = false, FontSize = 1200 };

            A.SolidFill solidFill11 = new A.SolidFill();

            A.SchemeColor schemeColor15 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Shade shade1 = new A.Shade(){ Val = 50000 };

            schemeColor15.Append(shade1);

            solidFill11.Append(schemeColor15);

            defaultRunProperties13.Append(solidFill11);

            level1ParagraphProperties4.Append(defaultRunProperties13);

            listStyle10.Append(level1ParagraphProperties4);

            A.Paragraph paragraph14 = new A.Paragraph();

            A.Field field3 = new A.Field(){ Id = "{8263865E-5382-4BDD-A09E-2B63F38BCE59}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties11 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties11.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text11 = new A.Text();
            text11.Text = "2012/10/3";

            field3.Append(runProperties11);
            field3.Append(text11);
            A.EndParagraphRunProperties endParagraphRunProperties10 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph14.Append(field3);
            paragraph14.Append(endParagraphRunProperties10);

            textBody10.Append(bodyProperties10);
            textBody10.Append(listStyle10);
            textBody10.Append(paragraph14);

            shape10.Append(nonVisualShapeProperties10);
            shape10.Append(shapeProperties10);
            shape10.Append(textBody10);

            Shape shape11 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties11 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties14 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Footer Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties11 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks11 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties11.Append(shapeLocks11);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties14 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape11 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)3U };

            applicationNonVisualDrawingProperties14.Append(placeholderShape11);

            nonVisualShapeProperties11.Append(nonVisualDrawingProperties14);
            nonVisualShapeProperties11.Append(nonVisualShapeDrawingProperties11);
            nonVisualShapeProperties11.Append(applicationNonVisualDrawingProperties14);

            ShapeProperties shapeProperties11 = new ShapeProperties();

            A.Transform2D transform2D6 = new A.Transform2D();
            A.Offset offset9 = new A.Offset(){ X = 4165600L, Y = 6416676L };
            A.Extents extents9 = new A.Extents(){ Cx = 3860800L, Cy = 365125L };

            transform2D6.Append(offset9);
            transform2D6.Append(extents9);

            A.PresetGeometry presetGeometry4 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList4 = new A.AdjustValueList();

            presetGeometry4.Append(adjustValueList4);

            shapeProperties11.Append(transform2D6);
            shapeProperties11.Append(presetGeometry4);

            TextBody textBody11 = new TextBody();
            A.BodyProperties bodyProperties11 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal, Anchor = A.TextAnchoringTypeValues.Bottom };

            A.ListStyle listStyle11 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties5 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Center, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties14 = new A.DefaultRunProperties(){ Kumimoji = false, FontSize = 1200 };

            A.SolidFill solidFill12 = new A.SolidFill();

            A.SchemeColor schemeColor16 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Shade shade2 = new A.Shade(){ Val = 50000 };

            schemeColor16.Append(shade2);

            solidFill12.Append(schemeColor16);

            defaultRunProperties14.Append(solidFill12);

            level1ParagraphProperties5.Append(defaultRunProperties14);

            listStyle11.Append(level1ParagraphProperties5);

            A.Paragraph paragraph15 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties11 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph15.Append(endParagraphRunProperties11);

            textBody11.Append(bodyProperties11);
            textBody11.Append(listStyle11);
            textBody11.Append(paragraph15);

            shape11.Append(nonVisualShapeProperties11);
            shape11.Append(shapeProperties11);
            shape11.Append(textBody11);

            Shape shape12 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties12 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties15 = new NonVisualDrawingProperties(){ Id = (UInt32Value)23U, Name = "Slide Number Placeholder 22" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties12 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks12 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties12.Append(shapeLocks12);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties15 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape12 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)4U };

            applicationNonVisualDrawingProperties15.Append(placeholderShape12);

            nonVisualShapeProperties12.Append(nonVisualDrawingProperties15);
            nonVisualShapeProperties12.Append(nonVisualShapeDrawingProperties12);
            nonVisualShapeProperties12.Append(applicationNonVisualDrawingProperties15);

            ShapeProperties shapeProperties12 = new ShapeProperties();

            A.Transform2D transform2D7 = new A.Transform2D();
            A.Offset offset10 = new A.Offset(){ X = 10566400L, Y = 6416676L };
            A.Extents extents10 = new A.Extents(){ Cx = 1016000L, Cy = 365125L };

            transform2D7.Append(offset10);
            transform2D7.Append(extents10);

            A.PresetGeometry presetGeometry5 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList5 = new A.AdjustValueList();

            presetGeometry5.Append(adjustValueList5);

            shapeProperties12.Append(transform2D7);
            shapeProperties12.Append(presetGeometry5);

            TextBody textBody12 = new TextBody();
            A.BodyProperties bodyProperties12 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal, LeftInset = 0, RightInset = 0, Anchor = A.TextAnchoringTypeValues.Bottom };

            A.ListStyle listStyle12 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties6 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Right, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties15 = new A.DefaultRunProperties(){ Kumimoji = false, FontSize = 1200 };

            A.SolidFill solidFill13 = new A.SolidFill();

            A.SchemeColor schemeColor17 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Shade shade3 = new A.Shade(){ Val = 50000 };

            schemeColor17.Append(shade3);

            solidFill13.Append(schemeColor17);

            defaultRunProperties15.Append(solidFill13);

            level1ParagraphProperties6.Append(defaultRunProperties15);

            listStyle12.Append(level1ParagraphProperties6);

            A.Paragraph paragraph16 = new A.Paragraph();

            A.Field field4 = new A.Field(){ Id = "{DF0B8B9E-EDC2-479A-B980-EDD8632819B1}", Type = "slidenum" };

            A.RunProperties runProperties12 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties12.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text12 = new A.Text();
            text12.Text = "‹#›";

            field4.Append(runProperties12);
            field4.Append(text12);
            A.EndParagraphRunProperties endParagraphRunProperties12 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph16.Append(field4);
            paragraph16.Append(endParagraphRunProperties12);

            textBody12.Append(bodyProperties12);
            textBody12.Append(listStyle12);
            textBody12.Append(paragraph16);

            shape12.Append(nonVisualShapeProperties12);
            shape12.Append(shapeProperties12);
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

            P14.CreationId creationId3 = new P14.CreationId(){ Val = (UInt32Value)2409212196U };
            creationId3.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension3.Append(creationId3);

            commonSlideDataExtensionList3.Append(commonSlideDataExtension3);

            commonSlideData3.Append(background1);
            commonSlideData3.Append(shapeTree3);
            commonSlideData3.Append(commonSlideDataExtensionList3);
            ColorMap colorMap1 = new ColorMap(){ Background1 = A.ColorSchemeIndexValues.Dark1, Text1 = A.ColorSchemeIndexValues.Light1, Background2 = A.ColorSchemeIndexValues.Dark2, Text2 = A.ColorSchemeIndexValues.Light2, Accent1 = A.ColorSchemeIndexValues.Accent1, Accent2 = A.ColorSchemeIndexValues.Accent2, Accent3 = A.ColorSchemeIndexValues.Accent3, Accent4 = A.ColorSchemeIndexValues.Accent4, Accent5 = A.ColorSchemeIndexValues.Accent5, Accent6 = A.ColorSchemeIndexValues.Accent6, Hyperlink = A.ColorSchemeIndexValues.Hyperlink, FollowedHyperlink = A.ColorSchemeIndexValues.FollowedHyperlink };

            SlideLayoutIdList slideLayoutIdList1 = new SlideLayoutIdList();
            SlideLayoutId slideLayoutId1 = new SlideLayoutId(){ Id = (UInt32Value)2147483661U, RelationshipId = "rId1" };
            SlideLayoutId slideLayoutId2 = new SlideLayoutId(){ Id = (UInt32Value)2147483662U, RelationshipId = "rId2" };
            SlideLayoutId slideLayoutId3 = new SlideLayoutId(){ Id = (UInt32Value)2147483663U, RelationshipId = "rId3" };
            SlideLayoutId slideLayoutId4 = new SlideLayoutId(){ Id = (UInt32Value)2147483664U, RelationshipId = "rId4" };
            SlideLayoutId slideLayoutId5 = new SlideLayoutId(){ Id = (UInt32Value)2147483665U, RelationshipId = "rId5" };
            SlideLayoutId slideLayoutId6 = new SlideLayoutId(){ Id = (UInt32Value)2147483666U, RelationshipId = "rId6" };
            SlideLayoutId slideLayoutId7 = new SlideLayoutId(){ Id = (UInt32Value)2147483667U, RelationshipId = "rId7" };
            SlideLayoutId slideLayoutId8 = new SlideLayoutId(){ Id = (UInt32Value)2147483668U, RelationshipId = "rId8" };
            SlideLayoutId slideLayoutId9 = new SlideLayoutId(){ Id = (UInt32Value)2147483669U, RelationshipId = "rId9" };
            SlideLayoutId slideLayoutId10 = new SlideLayoutId(){ Id = (UInt32Value)2147483670U, RelationshipId = "rId10" };
            SlideLayoutId slideLayoutId11 = new SlideLayoutId(){ Id = (UInt32Value)2147483671U, RelationshipId = "rId11" };

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

            TitleStyle titleStyle1 = new TitleStyle();

            A.Level1ParagraphProperties level1ParagraphProperties7 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Center, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.SpaceBefore spaceBefore1 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent1 = new A.SpacingPercent(){ Val = 0 };

            spaceBefore1.Append(spacingPercent1);
            A.NoBullet noBullet10 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties16 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 4100, Bold = true, Kerning = 1200, Capital = A.TextCapsValues.None, Baseline = 0 };

            A.Outline outline2 = new A.Outline(){ Width = 6350 };
            A.NoFill noFill2 = new A.NoFill();

            outline2.Append(noFill2);

            A.GradientFill gradientFill2 = new A.GradientFill();

            A.GradientStopList gradientStopList2 = new A.GradientStopList();

            A.GradientStop gradientStop4 = new A.GradientStop(){ Position = 0 };

            A.SchemeColor schemeColor18 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };
            A.Tint tint4 = new A.Tint(){ Val = 73000 };
            A.SaturationModulation saturationModulation4 = new A.SaturationModulation(){ Val = 145000 };

            schemeColor18.Append(tint4);
            schemeColor18.Append(saturationModulation4);

            gradientStop4.Append(schemeColor18);

            A.GradientStop gradientStop5 = new A.GradientStop(){ Position = 73000 };

            A.SchemeColor schemeColor19 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };
            A.Tint tint5 = new A.Tint(){ Val = 73000 };
            A.SaturationModulation saturationModulation5 = new A.SaturationModulation(){ Val = 145000 };

            schemeColor19.Append(tint5);
            schemeColor19.Append(saturationModulation5);

            gradientStop5.Append(schemeColor19);

            A.GradientStop gradientStop6 = new A.GradientStop(){ Position = 100000 };

            A.SchemeColor schemeColor20 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };
            A.Tint tint6 = new A.Tint(){ Val = 83000 };
            A.SaturationModulation saturationModulation6 = new A.SaturationModulation(){ Val = 143000 };

            schemeColor20.Append(tint6);
            schemeColor20.Append(saturationModulation6);

            gradientStop6.Append(schemeColor20);

            gradientStopList2.Append(gradientStop4);
            gradientStopList2.Append(gradientStop5);
            gradientStopList2.Append(gradientStop6);
            A.LinearGradientFill linearGradientFill2 = new A.LinearGradientFill(){ Angle = 4800000, Scaled = true };

            gradientFill2.Append(gradientStopList2);
            gradientFill2.Append(linearGradientFill2);

            A.EffectList effectList2 = new A.EffectList();

            A.OuterShadow outerShadow2 = new A.OuterShadow(){ BlurRadius = 114300L, Distance = 101600L, Direction = 2700000, Alignment = A.RectangleAlignmentValues.TopLeft, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex2 = new A.RgbColorModelHex(){ Val = "000000" };
            A.Alpha alpha2 = new A.Alpha(){ Val = 40000 };

            rgbColorModelHex2.Append(alpha2);

            outerShadow2.Append(rgbColorModelHex2);

            effectList2.Append(outerShadow2);
            A.LatinFont latinFont10 = new A.LatinFont(){ Typeface = "+mj-lt" };
            A.EastAsianFont eastAsianFont10 = new A.EastAsianFont(){ Typeface = "+mj-ea" };
            A.ComplexScriptFont complexScriptFont10 = new A.ComplexScriptFont(){ Typeface = "+mj-cs" };

            defaultRunProperties16.Append(outline2);
            defaultRunProperties16.Append(gradientFill2);
            defaultRunProperties16.Append(effectList2);
            defaultRunProperties16.Append(latinFont10);
            defaultRunProperties16.Append(eastAsianFont10);
            defaultRunProperties16.Append(complexScriptFont10);

            level1ParagraphProperties7.Append(spaceBefore1);
            level1ParagraphProperties7.Append(noBullet10);
            level1ParagraphProperties7.Append(defaultRunProperties16);

            titleStyle1.Append(level1ParagraphProperties7);

            BodyStyle bodyStyle1 = new BodyStyle();

            A.Level1ParagraphProperties level1ParagraphProperties8 = new A.Level1ParagraphProperties(){ LeftMargin = 548640, Indent = -411480, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.SpaceBefore spaceBefore2 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent2 = new A.SpacingPercent(){ Val = 20000 };

            spaceBefore2.Append(spacingPercent2);

            A.BulletColor bulletColor1 = new A.BulletColor();

            A.SchemeColor schemeColor21 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Shade shade4 = new A.Shade(){ Val = 95000 };

            schemeColor21.Append(shade4);

            bulletColor1.Append(schemeColor21);
            A.BulletSizePercentage bulletSizePercentage1 = new A.BulletSizePercentage(){ Val = 65000 };
            A.BulletFont bulletFont1 = new A.BulletFont(){ Typeface = "Wingdings 2" };
            A.CharacterBullet characterBullet1 = new A.CharacterBullet(){ Char = "" };

            A.DefaultRunProperties defaultRunProperties17 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 2800, Kerning = 1200 };

            A.SolidFill solidFill14 = new A.SolidFill();
            A.SchemeColor schemeColor22 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill14.Append(schemeColor22);
            A.LatinFont latinFont11 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont11 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont11 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties17.Append(solidFill14);
            defaultRunProperties17.Append(latinFont11);
            defaultRunProperties17.Append(eastAsianFont11);
            defaultRunProperties17.Append(complexScriptFont11);

            level1ParagraphProperties8.Append(spaceBefore2);
            level1ParagraphProperties8.Append(bulletColor1);
            level1ParagraphProperties8.Append(bulletSizePercentage1);
            level1ParagraphProperties8.Append(bulletFont1);
            level1ParagraphProperties8.Append(characterBullet1);
            level1ParagraphProperties8.Append(defaultRunProperties17);

            A.Level2ParagraphProperties level2ParagraphProperties3 = new A.Level2ParagraphProperties(){ LeftMargin = 868680, Indent = -283464, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.SpaceBefore spaceBefore3 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent3 = new A.SpacingPercent(){ Val = 20000 };

            spaceBefore3.Append(spacingPercent3);

            A.BulletColor bulletColor2 = new A.BulletColor();
            A.SchemeColor schemeColor23 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            bulletColor2.Append(schemeColor23);
            A.BulletSizePercentage bulletSizePercentage2 = new A.BulletSizePercentage(){ Val = 80000 };
            A.BulletFont bulletFont2 = new A.BulletFont(){ Typeface = "Wingdings 2" };
            A.CharacterBullet characterBullet2 = new A.CharacterBullet(){ Char = "" };

            A.DefaultRunProperties defaultRunProperties18 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 2400, Kerning = 1200 };

            A.SolidFill solidFill15 = new A.SolidFill();
            A.SchemeColor schemeColor24 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill15.Append(schemeColor24);
            A.LatinFont latinFont12 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont12 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont12 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties18.Append(solidFill15);
            defaultRunProperties18.Append(latinFont12);
            defaultRunProperties18.Append(eastAsianFont12);
            defaultRunProperties18.Append(complexScriptFont12);

            level2ParagraphProperties3.Append(spaceBefore3);
            level2ParagraphProperties3.Append(bulletColor2);
            level2ParagraphProperties3.Append(bulletSizePercentage2);
            level2ParagraphProperties3.Append(bulletFont2);
            level2ParagraphProperties3.Append(characterBullet2);
            level2ParagraphProperties3.Append(defaultRunProperties18);

            A.Level3ParagraphProperties level3ParagraphProperties3 = new A.Level3ParagraphProperties(){ LeftMargin = 1133856, Indent = -228600, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.SpaceBefore spaceBefore4 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent4 = new A.SpacingPercent(){ Val = 20000 };

            spaceBefore4.Append(spacingPercent4);

            A.BulletColor bulletColor3 = new A.BulletColor();
            A.SchemeColor schemeColor25 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            bulletColor3.Append(schemeColor25);
            A.BulletSizePercentage bulletSizePercentage3 = new A.BulletSizePercentage(){ Val = 95000 };
            A.BulletFont bulletFont3 = new A.BulletFont(){ Typeface = "Wingdings" };
            A.CharacterBullet characterBullet3 = new A.CharacterBullet(){ Char = "" };

            A.DefaultRunProperties defaultRunProperties19 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 2200, Kerning = 1200 };

            A.SolidFill solidFill16 = new A.SolidFill();
            A.SchemeColor schemeColor26 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill16.Append(schemeColor26);
            A.LatinFont latinFont13 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont13 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont13 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties19.Append(solidFill16);
            defaultRunProperties19.Append(latinFont13);
            defaultRunProperties19.Append(eastAsianFont13);
            defaultRunProperties19.Append(complexScriptFont13);

            level3ParagraphProperties3.Append(spaceBefore4);
            level3ParagraphProperties3.Append(bulletColor3);
            level3ParagraphProperties3.Append(bulletSizePercentage3);
            level3ParagraphProperties3.Append(bulletFont3);
            level3ParagraphProperties3.Append(characterBullet3);
            level3ParagraphProperties3.Append(defaultRunProperties19);

            A.Level4ParagraphProperties level4ParagraphProperties3 = new A.Level4ParagraphProperties(){ LeftMargin = 1353312, Indent = -182880, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.SpaceBefore spaceBefore5 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent5 = new A.SpacingPercent(){ Val = 20000 };

            spaceBefore5.Append(spacingPercent5);

            A.BulletColor bulletColor4 = new A.BulletColor();
            A.SchemeColor schemeColor27 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            bulletColor4.Append(schemeColor27);
            A.BulletSizePercentage bulletSizePercentage4 = new A.BulletSizePercentage(){ Val = 100000 };
            A.BulletFont bulletFont4 = new A.BulletFont(){ Typeface = "Wingdings 3" };
            A.CharacterBullet characterBullet4 = new A.CharacterBullet(){ Char = "" };

            A.DefaultRunProperties defaultRunProperties20 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 2000, Kerning = 1200 };

            A.SolidFill solidFill17 = new A.SolidFill();
            A.SchemeColor schemeColor28 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill17.Append(schemeColor28);
            A.LatinFont latinFont14 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont14 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont14 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties20.Append(solidFill17);
            defaultRunProperties20.Append(latinFont14);
            defaultRunProperties20.Append(eastAsianFont14);
            defaultRunProperties20.Append(complexScriptFont14);

            level4ParagraphProperties3.Append(spaceBefore5);
            level4ParagraphProperties3.Append(bulletColor4);
            level4ParagraphProperties3.Append(bulletSizePercentage4);
            level4ParagraphProperties3.Append(bulletFont4);
            level4ParagraphProperties3.Append(characterBullet4);
            level4ParagraphProperties3.Append(defaultRunProperties20);

            A.Level5ParagraphProperties level5ParagraphProperties3 = new A.Level5ParagraphProperties(){ LeftMargin = 1545336, Indent = -182880, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.SpaceBefore spaceBefore6 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent6 = new A.SpacingPercent(){ Val = 20000 };

            spaceBefore6.Append(spacingPercent6);

            A.BulletColor bulletColor5 = new A.BulletColor();
            A.SchemeColor schemeColor29 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            bulletColor5.Append(schemeColor29);
            A.BulletFont bulletFont5 = new A.BulletFont(){ Typeface = "Wingdings 2" };
            A.CharacterBullet characterBullet5 = new A.CharacterBullet(){ Char = "" };

            A.DefaultRunProperties defaultRunProperties21 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 2000, Kerning = 1200 };

            A.SolidFill solidFill18 = new A.SolidFill();
            A.SchemeColor schemeColor30 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill18.Append(schemeColor30);
            A.LatinFont latinFont15 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont15 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont15 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties21.Append(solidFill18);
            defaultRunProperties21.Append(latinFont15);
            defaultRunProperties21.Append(eastAsianFont15);
            defaultRunProperties21.Append(complexScriptFont15);

            level5ParagraphProperties3.Append(spaceBefore6);
            level5ParagraphProperties3.Append(bulletColor5);
            level5ParagraphProperties3.Append(bulletFont5);
            level5ParagraphProperties3.Append(characterBullet5);
            level5ParagraphProperties3.Append(defaultRunProperties21);

            A.Level6ParagraphProperties level6ParagraphProperties3 = new A.Level6ParagraphProperties(){ LeftMargin = 1764792, Indent = -182880, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.SpaceBefore spaceBefore7 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent7 = new A.SpacingPercent(){ Val = 20000 };

            spaceBefore7.Append(spacingPercent7);

            A.BulletColor bulletColor6 = new A.BulletColor();
            A.SchemeColor schemeColor31 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            bulletColor6.Append(schemeColor31);
            A.BulletFont bulletFont6 = new A.BulletFont(){ Typeface = "Wingdings 3" };
            A.CharacterBullet characterBullet6 = new A.CharacterBullet(){ Char = "" };

            A.DefaultRunProperties defaultRunProperties22 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill19 = new A.SolidFill();
            A.SchemeColor schemeColor32 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill19.Append(schemeColor32);
            A.LatinFont latinFont16 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont16 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont16 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties22.Append(solidFill19);
            defaultRunProperties22.Append(latinFont16);
            defaultRunProperties22.Append(eastAsianFont16);
            defaultRunProperties22.Append(complexScriptFont16);

            level6ParagraphProperties3.Append(spaceBefore7);
            level6ParagraphProperties3.Append(bulletColor6);
            level6ParagraphProperties3.Append(bulletFont6);
            level6ParagraphProperties3.Append(characterBullet6);
            level6ParagraphProperties3.Append(defaultRunProperties22);

            A.Level7ParagraphProperties level7ParagraphProperties3 = new A.Level7ParagraphProperties(){ LeftMargin = 1965960, Indent = -182880, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.SpaceBefore spaceBefore8 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent8 = new A.SpacingPercent(){ Val = 20000 };

            spaceBefore8.Append(spacingPercent8);

            A.BulletColor bulletColor7 = new A.BulletColor();
            A.SchemeColor schemeColor33 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            bulletColor7.Append(schemeColor33);
            A.BulletFont bulletFont7 = new A.BulletFont(){ Typeface = "Wingdings 2" };
            A.CharacterBullet characterBullet7 = new A.CharacterBullet(){ Char = "" };

            A.DefaultRunProperties defaultRunProperties23 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 1600, Kerning = 1200 };

            A.SolidFill solidFill20 = new A.SolidFill();
            A.SchemeColor schemeColor34 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill20.Append(schemeColor34);
            A.LatinFont latinFont17 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont17 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont17 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties23.Append(solidFill20);
            defaultRunProperties23.Append(latinFont17);
            defaultRunProperties23.Append(eastAsianFont17);
            defaultRunProperties23.Append(complexScriptFont17);

            level7ParagraphProperties3.Append(spaceBefore8);
            level7ParagraphProperties3.Append(bulletColor7);
            level7ParagraphProperties3.Append(bulletFont7);
            level7ParagraphProperties3.Append(characterBullet7);
            level7ParagraphProperties3.Append(defaultRunProperties23);

            A.Level8ParagraphProperties level8ParagraphProperties3 = new A.Level8ParagraphProperties(){ LeftMargin = 2167128, Indent = -182880, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.SpaceBefore spaceBefore9 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent9 = new A.SpacingPercent(){ Val = 20000 };

            spaceBefore9.Append(spacingPercent9);

            A.BulletColor bulletColor8 = new A.BulletColor();
            A.SchemeColor schemeColor35 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            bulletColor8.Append(schemeColor35);
            A.BulletFont bulletFont8 = new A.BulletFont(){ Typeface = "Wingdings 2" };
            A.CharacterBullet characterBullet8 = new A.CharacterBullet(){ Char = "" };

            A.DefaultRunProperties defaultRunProperties24 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 1400, Kerning = 1200 };

            A.SolidFill solidFill21 = new A.SolidFill();
            A.SchemeColor schemeColor36 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill21.Append(schemeColor36);
            A.LatinFont latinFont18 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont18 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont18 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties24.Append(solidFill21);
            defaultRunProperties24.Append(latinFont18);
            defaultRunProperties24.Append(eastAsianFont18);
            defaultRunProperties24.Append(complexScriptFont18);

            level8ParagraphProperties3.Append(spaceBefore9);
            level8ParagraphProperties3.Append(bulletColor8);
            level8ParagraphProperties3.Append(bulletFont8);
            level8ParagraphProperties3.Append(characterBullet8);
            level8ParagraphProperties3.Append(defaultRunProperties24);

            A.Level9ParagraphProperties level9ParagraphProperties3 = new A.Level9ParagraphProperties(){ LeftMargin = 2368296, Indent = -182880, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.SpaceBefore spaceBefore10 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent10 = new A.SpacingPercent(){ Val = 20000 };

            spaceBefore10.Append(spacingPercent10);

            A.BulletColor bulletColor9 = new A.BulletColor();
            A.SchemeColor schemeColor37 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            bulletColor9.Append(schemeColor37);
            A.BulletFont bulletFont9 = new A.BulletFont(){ Typeface = "Wingdings 2" };
            A.CharacterBullet characterBullet9 = new A.CharacterBullet(){ Char = "" };

            A.DefaultRunProperties defaultRunProperties25 = new A.DefaultRunProperties(){ Kumimoji = true, FontSize = 1400, Kerning = 1200, Baseline = 0 };

            A.SolidFill solidFill22 = new A.SolidFill();
            A.SchemeColor schemeColor38 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill22.Append(schemeColor38);
            A.LatinFont latinFont19 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont19 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont19 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties25.Append(solidFill22);
            defaultRunProperties25.Append(latinFont19);
            defaultRunProperties25.Append(eastAsianFont19);
            defaultRunProperties25.Append(complexScriptFont19);

            level9ParagraphProperties3.Append(spaceBefore10);
            level9ParagraphProperties3.Append(bulletColor9);
            level9ParagraphProperties3.Append(bulletFont9);
            level9ParagraphProperties3.Append(characterBullet9);
            level9ParagraphProperties3.Append(defaultRunProperties25);

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

            A.Level1ParagraphProperties level1ParagraphProperties9 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties26 = new A.DefaultRunProperties(){ Kumimoji = true, Kerning = 1200 };

            A.SolidFill solidFill23 = new A.SolidFill();
            A.SchemeColor schemeColor39 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill23.Append(schemeColor39);
            A.LatinFont latinFont20 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont20 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont20 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties26.Append(solidFill23);
            defaultRunProperties26.Append(latinFont20);
            defaultRunProperties26.Append(eastAsianFont20);
            defaultRunProperties26.Append(complexScriptFont20);

            level1ParagraphProperties9.Append(defaultRunProperties26);

            A.Level2ParagraphProperties level2ParagraphProperties4 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties27 = new A.DefaultRunProperties(){ Kumimoji = true, Kerning = 1200 };

            A.SolidFill solidFill24 = new A.SolidFill();
            A.SchemeColor schemeColor40 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill24.Append(schemeColor40);
            A.LatinFont latinFont21 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont21 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont21 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties27.Append(solidFill24);
            defaultRunProperties27.Append(latinFont21);
            defaultRunProperties27.Append(eastAsianFont21);
            defaultRunProperties27.Append(complexScriptFont21);

            level2ParagraphProperties4.Append(defaultRunProperties27);

            A.Level3ParagraphProperties level3ParagraphProperties4 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties28 = new A.DefaultRunProperties(){ Kumimoji = true, Kerning = 1200 };

            A.SolidFill solidFill25 = new A.SolidFill();
            A.SchemeColor schemeColor41 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill25.Append(schemeColor41);
            A.LatinFont latinFont22 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont22 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont22 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties28.Append(solidFill25);
            defaultRunProperties28.Append(latinFont22);
            defaultRunProperties28.Append(eastAsianFont22);
            defaultRunProperties28.Append(complexScriptFont22);

            level3ParagraphProperties4.Append(defaultRunProperties28);

            A.Level4ParagraphProperties level4ParagraphProperties4 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties29 = new A.DefaultRunProperties(){ Kumimoji = true, Kerning = 1200 };

            A.SolidFill solidFill26 = new A.SolidFill();
            A.SchemeColor schemeColor42 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill26.Append(schemeColor42);
            A.LatinFont latinFont23 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont23 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont23 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties29.Append(solidFill26);
            defaultRunProperties29.Append(latinFont23);
            defaultRunProperties29.Append(eastAsianFont23);
            defaultRunProperties29.Append(complexScriptFont23);

            level4ParagraphProperties4.Append(defaultRunProperties29);

            A.Level5ParagraphProperties level5ParagraphProperties4 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties30 = new A.DefaultRunProperties(){ Kumimoji = true, Kerning = 1200 };

            A.SolidFill solidFill27 = new A.SolidFill();
            A.SchemeColor schemeColor43 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill27.Append(schemeColor43);
            A.LatinFont latinFont24 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont24 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont24 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties30.Append(solidFill27);
            defaultRunProperties30.Append(latinFont24);
            defaultRunProperties30.Append(eastAsianFont24);
            defaultRunProperties30.Append(complexScriptFont24);

            level5ParagraphProperties4.Append(defaultRunProperties30);

            A.Level6ParagraphProperties level6ParagraphProperties4 = new A.Level6ParagraphProperties(){ LeftMargin = 2286000, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties31 = new A.DefaultRunProperties(){ Kumimoji = true, Kerning = 1200 };

            A.SolidFill solidFill28 = new A.SolidFill();
            A.SchemeColor schemeColor44 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill28.Append(schemeColor44);
            A.LatinFont latinFont25 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont25 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont25 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties31.Append(solidFill28);
            defaultRunProperties31.Append(latinFont25);
            defaultRunProperties31.Append(eastAsianFont25);
            defaultRunProperties31.Append(complexScriptFont25);

            level6ParagraphProperties4.Append(defaultRunProperties31);

            A.Level7ParagraphProperties level7ParagraphProperties4 = new A.Level7ParagraphProperties(){ LeftMargin = 2743200, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties32 = new A.DefaultRunProperties(){ Kumimoji = true, Kerning = 1200 };

            A.SolidFill solidFill29 = new A.SolidFill();
            A.SchemeColor schemeColor45 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill29.Append(schemeColor45);
            A.LatinFont latinFont26 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont26 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont26 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties32.Append(solidFill29);
            defaultRunProperties32.Append(latinFont26);
            defaultRunProperties32.Append(eastAsianFont26);
            defaultRunProperties32.Append(complexScriptFont26);

            level7ParagraphProperties4.Append(defaultRunProperties32);

            A.Level8ParagraphProperties level8ParagraphProperties4 = new A.Level8ParagraphProperties(){ LeftMargin = 3200400, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties33 = new A.DefaultRunProperties(){ Kumimoji = true, Kerning = 1200 };

            A.SolidFill solidFill30 = new A.SolidFill();
            A.SchemeColor schemeColor46 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill30.Append(schemeColor46);
            A.LatinFont latinFont27 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont27 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont27 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties33.Append(solidFill30);
            defaultRunProperties33.Append(latinFont27);
            defaultRunProperties33.Append(eastAsianFont27);
            defaultRunProperties33.Append(complexScriptFont27);

            level8ParagraphProperties4.Append(defaultRunProperties33);

            A.Level9ParagraphProperties level9ParagraphProperties4 = new A.Level9ParagraphProperties(){ LeftMargin = 3657600, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties34 = new A.DefaultRunProperties(){ Kumimoji = true, Kerning = 1200 };

            A.SolidFill solidFill31 = new A.SolidFill();
            A.SchemeColor schemeColor47 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill31.Append(schemeColor47);
            A.LatinFont latinFont28 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont28 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont28 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties34.Append(solidFill31);
            defaultRunProperties34.Append(latinFont28);
            defaultRunProperties34.Append(eastAsianFont28);
            defaultRunProperties34.Append(complexScriptFont28);

            level9ParagraphProperties4.Append(defaultRunProperties34);

            otherStyle1.Append(level1ParagraphProperties9);
            otherStyle1.Append(level2ParagraphProperties4);
            otherStyle1.Append(level3ParagraphProperties4);
            otherStyle1.Append(level4ParagraphProperties4);
            otherStyle1.Append(level5ParagraphProperties4);
            otherStyle1.Append(level6ParagraphProperties4);
            otherStyle1.Append(level7ParagraphProperties4);
            otherStyle1.Append(level8ParagraphProperties4);
            otherStyle1.Append(level9ParagraphProperties4);

            textStyles1.Append(titleStyle1);
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
            NonVisualDrawingProperties nonVisualDrawingProperties16 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties4 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties16 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties4.Append(nonVisualDrawingProperties16);
            nonVisualGroupShapeProperties4.Append(nonVisualGroupShapeDrawingProperties4);
            nonVisualGroupShapeProperties4.Append(applicationNonVisualDrawingProperties16);

            GroupShapeProperties groupShapeProperties4 = new GroupShapeProperties();

            A.TransformGroup transformGroup4 = new A.TransformGroup();
            A.Offset offset11 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents11 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset4 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents4 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup4.Append(offset11);
            transformGroup4.Append(extents11);
            transformGroup4.Append(childOffset4);
            transformGroup4.Append(childExtents4);

            groupShapeProperties4.Append(transformGroup4);

            Shape shape13 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties13 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties17 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties13 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks13 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties13.Append(shapeLocks13);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties17 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape13 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties17.Append(placeholderShape13);

            nonVisualShapeProperties13.Append(nonVisualDrawingProperties17);
            nonVisualShapeProperties13.Append(nonVisualShapeDrawingProperties13);
            nonVisualShapeProperties13.Append(applicationNonVisualDrawingProperties17);

            ShapeProperties shapeProperties13 = new ShapeProperties();

            A.Transform2D transform2D8 = new A.Transform2D();
            A.Offset offset12 = new A.Offset(){ X = 609601L, Y = 273050L };
            A.Extents extents12 = new A.Extents(){ Cx = 4011084L, Cy = 1162050L };

            transform2D8.Append(offset12);
            transform2D8.Append(extents12);

            shapeProperties13.Append(transform2D8);

            TextBody textBody13 = new TextBody();

            A.BodyProperties bodyProperties13 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal, Anchor = A.TextAnchoringTypeValues.Bottom };
            A.NormalAutoFit normalAutoFit4 = new A.NormalAutoFit();
            A.Shape3DType shape3DType3 = new A.Shape3DType(){ PresetMaterial = A.PresetMaterialTypeValues.SoftEdge };

            bodyProperties13.Append(normalAutoFit4);
            bodyProperties13.Append(shape3DType3);

            A.ListStyle listStyle13 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties10 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Left };
            A.NoBullet noBullet11 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties35 = new A.DefaultRunProperties(){ FontSize = 2200, Bold = false };

            A.Outline outline3 = new A.Outline(){ Width = 6350 };
            A.NoFill noFill3 = new A.NoFill();

            outline3.Append(noFill3);

            A.SolidFill solidFill32 = new A.SolidFill();

            A.SchemeColor schemeColor48 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };
            A.Tint tint7 = new A.Tint(){ Val = 73000 };
            A.SaturationModulation saturationModulation7 = new A.SaturationModulation(){ Val = 180000 };

            schemeColor48.Append(tint7);
            schemeColor48.Append(saturationModulation7);

            solidFill32.Append(schemeColor48);

            defaultRunProperties35.Append(outline3);
            defaultRunProperties35.Append(solidFill32);

            level1ParagraphProperties10.Append(noBullet11);
            level1ParagraphProperties10.Append(defaultRunProperties35);

            listStyle13.Append(level1ParagraphProperties10);

            A.Paragraph paragraph17 = new A.Paragraph();

            A.Run run9 = new A.Run();

            A.RunProperties runProperties13 = new A.RunProperties(){ Kumimoji = false, Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties13.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text13 = new A.Text();
            text13.Text = "Click to edit Master title style";

            run9.Append(runProperties13);
            run9.Append(text13);
            A.EndParagraphRunProperties endParagraphRunProperties13 = new A.EndParagraphRunProperties(){ Kumimoji = false, Language = "en-US" };

            paragraph17.Append(run9);
            paragraph17.Append(endParagraphRunProperties13);

            textBody13.Append(bodyProperties13);
            textBody13.Append(listStyle13);
            textBody13.Append(paragraph17);

            shape13.Append(nonVisualShapeProperties13);
            shape13.Append(shapeProperties13);
            shape13.Append(textBody13);

            Shape shape14 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties14 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties18 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Text Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties14 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks14 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties14.Append(shapeLocks14);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties18 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape14 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Index = (UInt32Value)2U };

            applicationNonVisualDrawingProperties18.Append(placeholderShape14);

            nonVisualShapeProperties14.Append(nonVisualDrawingProperties18);
            nonVisualShapeProperties14.Append(nonVisualShapeDrawingProperties14);
            nonVisualShapeProperties14.Append(applicationNonVisualDrawingProperties18);

            ShapeProperties shapeProperties14 = new ShapeProperties();

            A.Transform2D transform2D9 = new A.Transform2D();
            A.Offset offset13 = new A.Offset(){ X = 609601L, Y = 1524001L };
            A.Extents extents13 = new A.Extents(){ Cx = 4011084L, Cy = 4602163L };

            transform2D9.Append(offset13);
            transform2D9.Append(extents13);

            shapeProperties14.Append(transform2D9);

            TextBody textBody14 = new TextBody();
            A.BodyProperties bodyProperties14 = new A.BodyProperties();

            A.ListStyle listStyle14 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties11 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0 };
            A.NoBullet noBullet12 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties36 = new A.DefaultRunProperties(){ FontSize = 1400 };

            level1ParagraphProperties11.Append(noBullet12);
            level1ParagraphProperties11.Append(defaultRunProperties36);

            A.Level2ParagraphProperties level2ParagraphProperties5 = new A.Level2ParagraphProperties();
            A.NoBullet noBullet13 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties37 = new A.DefaultRunProperties(){ FontSize = 1200 };

            level2ParagraphProperties5.Append(noBullet13);
            level2ParagraphProperties5.Append(defaultRunProperties37);

            A.Level3ParagraphProperties level3ParagraphProperties5 = new A.Level3ParagraphProperties();
            A.NoBullet noBullet14 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties38 = new A.DefaultRunProperties(){ FontSize = 1000 };

            level3ParagraphProperties5.Append(noBullet14);
            level3ParagraphProperties5.Append(defaultRunProperties38);

            A.Level4ParagraphProperties level4ParagraphProperties5 = new A.Level4ParagraphProperties();
            A.NoBullet noBullet15 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties39 = new A.DefaultRunProperties(){ FontSize = 900 };

            level4ParagraphProperties5.Append(noBullet15);
            level4ParagraphProperties5.Append(defaultRunProperties39);

            A.Level5ParagraphProperties level5ParagraphProperties5 = new A.Level5ParagraphProperties();
            A.NoBullet noBullet16 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties40 = new A.DefaultRunProperties(){ FontSize = 900 };

            level5ParagraphProperties5.Append(noBullet16);
            level5ParagraphProperties5.Append(defaultRunProperties40);

            listStyle14.Append(level1ParagraphProperties11);
            listStyle14.Append(level2ParagraphProperties5);
            listStyle14.Append(level3ParagraphProperties5);
            listStyle14.Append(level4ParagraphProperties5);
            listStyle14.Append(level5ParagraphProperties5);

            A.Paragraph paragraph18 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties6 = new A.ParagraphProperties(){ Level = 0, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run10 = new A.Run();

            A.RunProperties runProperties14 = new A.RunProperties(){ Kumimoji = false, Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties14.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text14 = new A.Text();
            text14.Text = "Click to edit Master text styles";

            run10.Append(runProperties14);
            run10.Append(text14);

            paragraph18.Append(paragraphProperties6);
            paragraph18.Append(run10);

            textBody14.Append(bodyProperties14);
            textBody14.Append(listStyle14);
            textBody14.Append(paragraph18);

            shape14.Append(nonVisualShapeProperties14);
            shape14.Append(shapeProperties14);
            shape14.Append(textBody14);

            Shape shape15 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties15 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties19 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Content Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties15 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks15 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties15.Append(shapeLocks15);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties19 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape15 = new PlaceholderShape(){ Size = PlaceholderSizeValues.Half, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties19.Append(placeholderShape15);

            nonVisualShapeProperties15.Append(nonVisualDrawingProperties19);
            nonVisualShapeProperties15.Append(nonVisualShapeDrawingProperties15);
            nonVisualShapeProperties15.Append(applicationNonVisualDrawingProperties19);

            ShapeProperties shapeProperties15 = new ShapeProperties();

            A.Transform2D transform2D10 = new A.Transform2D();
            A.Offset offset14 = new A.Offset(){ X = 4766733L, Y = 273051L };
            A.Extents extents14 = new A.Extents(){ Cx = 6815667L, Cy = 5853113L };

            transform2D10.Append(offset14);
            transform2D10.Append(extents14);

            shapeProperties15.Append(transform2D10);

            TextBody textBody15 = new TextBody();
            A.BodyProperties bodyProperties15 = new A.BodyProperties();

            A.ListStyle listStyle15 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties12 = new A.Level1ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties41 = new A.DefaultRunProperties(){ FontSize = 2600 };

            level1ParagraphProperties12.Append(defaultRunProperties41);

            A.Level2ParagraphProperties level2ParagraphProperties6 = new A.Level2ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties42 = new A.DefaultRunProperties(){ FontSize = 2400 };

            level2ParagraphProperties6.Append(defaultRunProperties42);

            A.Level3ParagraphProperties level3ParagraphProperties6 = new A.Level3ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties43 = new A.DefaultRunProperties(){ FontSize = 2200 };

            level3ParagraphProperties6.Append(defaultRunProperties43);

            A.Level4ParagraphProperties level4ParagraphProperties6 = new A.Level4ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties44 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level4ParagraphProperties6.Append(defaultRunProperties44);

            A.Level5ParagraphProperties level5ParagraphProperties6 = new A.Level5ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties45 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level5ParagraphProperties6.Append(defaultRunProperties45);

            listStyle15.Append(level1ParagraphProperties12);
            listStyle15.Append(level2ParagraphProperties6);
            listStyle15.Append(level3ParagraphProperties6);
            listStyle15.Append(level4ParagraphProperties6);
            listStyle15.Append(level5ParagraphProperties6);

            A.Paragraph paragraph19 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties7 = new A.ParagraphProperties(){ Level = 0, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run11 = new A.Run();

            A.RunProperties runProperties15 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties15.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text15 = new A.Text();
            text15.Text = "Click to edit Master text styles";

            run11.Append(runProperties15);
            run11.Append(text15);

            paragraph19.Append(paragraphProperties7);
            paragraph19.Append(run11);

            A.Paragraph paragraph20 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties8 = new A.ParagraphProperties(){ Level = 1, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run12 = new A.Run();

            A.RunProperties runProperties16 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties16.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text16 = new A.Text();
            text16.Text = "Second level";

            run12.Append(runProperties16);
            run12.Append(text16);

            paragraph20.Append(paragraphProperties8);
            paragraph20.Append(run12);

            A.Paragraph paragraph21 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties9 = new A.ParagraphProperties(){ Level = 2, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run13 = new A.Run();

            A.RunProperties runProperties17 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties17.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text17 = new A.Text();
            text17.Text = "Third level";

            run13.Append(runProperties17);
            run13.Append(text17);

            paragraph21.Append(paragraphProperties9);
            paragraph21.Append(run13);

            A.Paragraph paragraph22 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties10 = new A.ParagraphProperties(){ Level = 3, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run14 = new A.Run();

            A.RunProperties runProperties18 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties18.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text18 = new A.Text();
            text18.Text = "Fourth level";

            run14.Append(runProperties18);
            run14.Append(text18);

            paragraph22.Append(paragraphProperties10);
            paragraph22.Append(run14);

            A.Paragraph paragraph23 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties11 = new A.ParagraphProperties(){ Level = 4, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run15 = new A.Run();

            A.RunProperties runProperties19 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties19.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text19 = new A.Text();
            text19.Text = "Fifth level";

            run15.Append(runProperties19);
            run15.Append(text19);
            A.EndParagraphRunProperties endParagraphRunProperties14 = new A.EndParagraphRunProperties(){ Kumimoji = false, Language = "en-US" };

            paragraph23.Append(paragraphProperties11);
            paragraph23.Append(run15);
            paragraph23.Append(endParagraphRunProperties14);

            textBody15.Append(bodyProperties15);
            textBody15.Append(listStyle15);
            textBody15.Append(paragraph19);
            textBody15.Append(paragraph20);
            textBody15.Append(paragraph21);
            textBody15.Append(paragraph22);
            textBody15.Append(paragraph23);

            shape15.Append(nonVisualShapeProperties15);
            shape15.Append(shapeProperties15);
            shape15.Append(textBody15);

            Shape shape16 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties16 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties20 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Date Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties16 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks16 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties16.Append(shapeLocks16);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties20 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape16 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties20.Append(placeholderShape16);

            nonVisualShapeProperties16.Append(nonVisualDrawingProperties20);
            nonVisualShapeProperties16.Append(nonVisualShapeDrawingProperties16);
            nonVisualShapeProperties16.Append(applicationNonVisualDrawingProperties20);
            ShapeProperties shapeProperties16 = new ShapeProperties();

            TextBody textBody16 = new TextBody();
            A.BodyProperties bodyProperties16 = new A.BodyProperties();
            A.ListStyle listStyle16 = new A.ListStyle();

            A.Paragraph paragraph24 = new A.Paragraph();

            A.Field field5 = new A.Field(){ Id = "{8263865E-5382-4BDD-A09E-2B63F38BCE59}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties20 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties20.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text20 = new A.Text();
            text20.Text = "2012/10/3";

            field5.Append(runProperties20);
            field5.Append(text20);
            A.EndParagraphRunProperties endParagraphRunProperties15 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph24.Append(field5);
            paragraph24.Append(endParagraphRunProperties15);

            textBody16.Append(bodyProperties16);
            textBody16.Append(listStyle16);
            textBody16.Append(paragraph24);

            shape16.Append(nonVisualShapeProperties16);
            shape16.Append(shapeProperties16);
            shape16.Append(textBody16);

            Shape shape17 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties17 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties21 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Footer Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties17 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks17 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties17.Append(shapeLocks17);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties21 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape17 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties21.Append(placeholderShape17);

            nonVisualShapeProperties17.Append(nonVisualDrawingProperties21);
            nonVisualShapeProperties17.Append(nonVisualShapeDrawingProperties17);
            nonVisualShapeProperties17.Append(applicationNonVisualDrawingProperties21);
            ShapeProperties shapeProperties17 = new ShapeProperties();

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
            shape17.Append(shapeProperties17);
            shape17.Append(textBody17);

            Shape shape18 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties18 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties22 = new NonVisualDrawingProperties(){ Id = (UInt32Value)7U, Name = "Slide Number Placeholder 6" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties18 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks18 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties18.Append(shapeLocks18);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties22 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape18 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties22.Append(placeholderShape18);

            nonVisualShapeProperties18.Append(nonVisualDrawingProperties22);
            nonVisualShapeProperties18.Append(nonVisualShapeDrawingProperties18);
            nonVisualShapeProperties18.Append(applicationNonVisualDrawingProperties22);
            ShapeProperties shapeProperties18 = new ShapeProperties();

            TextBody textBody18 = new TextBody();
            A.BodyProperties bodyProperties18 = new A.BodyProperties();
            A.ListStyle listStyle18 = new A.ListStyle();

            A.Paragraph paragraph26 = new A.Paragraph();

            A.Field field6 = new A.Field(){ Id = "{DF0B8B9E-EDC2-479A-B980-EDD8632819B1}", Type = "slidenum" };

            A.RunProperties runProperties21 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties21.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text21 = new A.Text();
            text21.Text = "‹#›";

            field6.Append(runProperties21);
            field6.Append(text21);
            A.EndParagraphRunProperties endParagraphRunProperties17 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph26.Append(field6);
            paragraph26.Append(endParagraphRunProperties17);

            textBody18.Append(bodyProperties18);
            textBody18.Append(listStyle18);
            textBody18.Append(paragraph26);

            shape18.Append(nonVisualShapeProperties18);
            shape18.Append(shapeProperties18);
            shape18.Append(textBody18);

            shapeTree4.Append(nonVisualGroupShapeProperties4);
            shapeTree4.Append(groupShapeProperties4);
            shapeTree4.Append(shape13);
            shapeTree4.Append(shape14);
            shapeTree4.Append(shape15);
            shapeTree4.Append(shape16);
            shapeTree4.Append(shape17);
            shapeTree4.Append(shape18);

            CommonSlideDataExtensionList commonSlideDataExtensionList4 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension4 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId4 = new P14.CreationId(){ Val = (UInt32Value)1118340530U };
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

            Background background2 = new Background();

            BackgroundStyleReference backgroundStyleReference2 = new BackgroundStyleReference(){ Index = (UInt32Value)1003U };
            A.SchemeColor schemeColor49 = new A.SchemeColor(){ Val = A.SchemeColorValues.Background2 };

            backgroundStyleReference2.Append(schemeColor49);

            background2.Append(backgroundStyleReference2);

            ShapeTree shapeTree5 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties5 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties23 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties5 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties23 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties5.Append(nonVisualDrawingProperties23);
            nonVisualGroupShapeProperties5.Append(nonVisualGroupShapeDrawingProperties5);
            nonVisualGroupShapeProperties5.Append(applicationNonVisualDrawingProperties23);

            GroupShapeProperties groupShapeProperties5 = new GroupShapeProperties();

            A.TransformGroup transformGroup5 = new A.TransformGroup();
            A.Offset offset15 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents15 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset5 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents5 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup5.Append(offset15);
            transformGroup5.Append(extents15);
            transformGroup5.Append(childOffset5);
            transformGroup5.Append(childExtents5);

            groupShapeProperties5.Append(transformGroup5);

            Shape shape19 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties19 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties24 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties19 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks19 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties19.Append(shapeLocks19);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties24 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape19 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties24.Append(placeholderShape19);

            nonVisualShapeProperties19.Append(nonVisualDrawingProperties24);
            nonVisualShapeProperties19.Append(nonVisualShapeDrawingProperties19);
            nonVisualShapeProperties19.Append(applicationNonVisualDrawingProperties24);

            ShapeProperties shapeProperties19 = new ShapeProperties();

            A.Transform2D transform2D11 = new A.Transform2D();
            A.Offset offset16 = new A.Offset(){ X = 2133600L, Y = 609600L };
            A.Extents extents16 = new A.Extents(){ Cx = 9448800L, Cy = 1828800L };

            transform2D11.Append(offset16);
            transform2D11.Append(extents16);

            shapeProperties19.Append(transform2D11);

            TextBody textBody19 = new TextBody();

            A.BodyProperties bodyProperties19 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal, BottomInset = 0, Anchor = A.TextAnchoringTypeValues.Bottom };
            A.NoAutoFit noAutoFit1 = new A.NoAutoFit();

            A.Scene3DType scene3DType3 = new A.Scene3DType();
            A.Camera camera3 = new A.Camera(){ Preset = A.PresetCameraValues.OrthographicFront };

            A.LightRig lightRig3 = new A.LightRig(){ Rig = A.LightRigValues.Soft, Direction = A.LightRigDirectionValues.Top };
            A.Rotation rotation3 = new A.Rotation(){ Latitude = 0, Longitude = 0, Revolution = 17220000 };

            lightRig3.Append(rotation3);

            scene3DType3.Append(camera3);
            scene3DType3.Append(lightRig3);

            A.Shape3DType shape3DType4 = new A.Shape3DType(){ PresetMaterial = A.PresetMaterialTypeValues.SoftEdge };
            A.BevelTop bevelTop3 = new A.BevelTop(){ Width = 38100L, Height = 38100L };

            A.ContourColor contourColor1 = new A.ContourColor();

            A.SchemeColor schemeColor50 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };
            A.Shade shade5 = new A.Shade(){ Val = 50000 };

            schemeColor50.Append(shade5);

            contourColor1.Append(schemeColor50);

            shape3DType4.Append(bevelTop3);
            shape3DType4.Append(contourColor1);

            bodyProperties19.Append(noAutoFit1);
            bodyProperties19.Append(scene3DType3);
            bodyProperties19.Append(shape3DType4);

            A.ListStyle listStyle19 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties13 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false };

            A.SpaceBefore spaceBefore11 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent11 = new A.SpacingPercent(){ Val = 0 };

            spaceBefore11.Append(spacingPercent11);
            A.NoBullet noBullet17 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties46 = new A.DefaultRunProperties(){ FontSize = 4800, Bold = true, Capital = A.TextCapsValues.None, Baseline = 0 };

            A.Outline outline4 = new A.Outline(){ Width = 6350 };
            A.NoFill noFill4 = new A.NoFill();

            outline4.Append(noFill4);

            A.SolidFill solidFill33 = new A.SolidFill();

            A.SchemeColor schemeColor51 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };
            A.Tint tint8 = new A.Tint(){ Val = 90000 };
            A.SaturationModulation saturationModulation8 = new A.SaturationModulation(){ Val = 120000 };

            schemeColor51.Append(tint8);
            schemeColor51.Append(saturationModulation8);

            solidFill33.Append(schemeColor51);

            A.EffectList effectList3 = new A.EffectList();

            A.OuterShadow outerShadow3 = new A.OuterShadow(){ BlurRadius = 114300L, Distance = 101600L, Direction = 2700000, Alignment = A.RectangleAlignmentValues.TopLeft, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex3 = new A.RgbColorModelHex(){ Val = "000000" };
            A.Alpha alpha3 = new A.Alpha(){ Val = 40000 };

            rgbColorModelHex3.Append(alpha3);

            outerShadow3.Append(rgbColorModelHex3);

            effectList3.Append(outerShadow3);
            A.LatinFont latinFont29 = new A.LatinFont(){ Typeface = "+mj-lt" };
            A.EastAsianFont eastAsianFont29 = new A.EastAsianFont(){ Typeface = "+mj-ea" };
            A.ComplexScriptFont complexScriptFont29 = new A.ComplexScriptFont(){ Typeface = "+mj-cs" };

            defaultRunProperties46.Append(outline4);
            defaultRunProperties46.Append(solidFill33);
            defaultRunProperties46.Append(effectList3);
            defaultRunProperties46.Append(latinFont29);
            defaultRunProperties46.Append(eastAsianFont29);
            defaultRunProperties46.Append(complexScriptFont29);

            level1ParagraphProperties13.Append(spaceBefore11);
            level1ParagraphProperties13.Append(noBullet17);
            level1ParagraphProperties13.Append(defaultRunProperties46);

            listStyle19.Append(level1ParagraphProperties13);

            A.Paragraph paragraph27 = new A.Paragraph();

            A.Run run16 = new A.Run();

            A.RunProperties runProperties22 = new A.RunProperties(){ Kumimoji = false, Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties22.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text22 = new A.Text();
            text22.Text = "Click to edit Master title style";

            run16.Append(runProperties22);
            run16.Append(text22);
            A.EndParagraphRunProperties endParagraphRunProperties18 = new A.EndParagraphRunProperties(){ Kumimoji = false, Language = "en-US" };

            paragraph27.Append(run16);
            paragraph27.Append(endParagraphRunProperties18);

            textBody19.Append(bodyProperties19);
            textBody19.Append(listStyle19);
            textBody19.Append(paragraph27);

            shape19.Append(nonVisualShapeProperties19);
            shape19.Append(shapeProperties19);
            shape19.Append(textBody19);

            Shape shape20 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties20 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties25 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Text Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties20 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks20 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties20.Append(shapeLocks20);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties25 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape20 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties25.Append(placeholderShape20);

            nonVisualShapeProperties20.Append(nonVisualDrawingProperties25);
            nonVisualShapeProperties20.Append(nonVisualShapeDrawingProperties20);
            nonVisualShapeProperties20.Append(applicationNonVisualDrawingProperties25);

            ShapeProperties shapeProperties20 = new ShapeProperties();

            A.Transform2D transform2D12 = new A.Transform2D();
            A.Offset offset17 = new A.Offset(){ X = 2133600L, Y = 2507786L };
            A.Extents extents17 = new A.Extents(){ Cx = 9448800L, Cy = 1509712L };

            transform2D12.Append(offset17);
            transform2D12.Append(extents17);

            shapeProperties20.Append(transform2D12);

            TextBody textBody20 = new TextBody();
            A.BodyProperties bodyProperties20 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Top };

            A.ListStyle listStyle20 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties14 = new A.Level1ParagraphProperties(){ LeftMargin = 73152, Indent = 0, Alignment = A.TextAlignmentTypeValues.Left };
            A.NoBullet noBullet18 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties47 = new A.DefaultRunProperties(){ FontSize = 2000 };

            A.SolidFill solidFill34 = new A.SolidFill();
            A.SchemeColor schemeColor52 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill34.Append(schemeColor52);

            defaultRunProperties47.Append(solidFill34);

            level1ParagraphProperties14.Append(noBullet18);
            level1ParagraphProperties14.Append(defaultRunProperties47);

            A.Level2ParagraphProperties level2ParagraphProperties7 = new A.Level2ParagraphProperties();
            A.NoBullet noBullet19 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties48 = new A.DefaultRunProperties(){ FontSize = 1800 };

            A.SolidFill solidFill35 = new A.SolidFill();

            A.SchemeColor schemeColor53 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint9 = new A.Tint(){ Val = 75000 };

            schemeColor53.Append(tint9);

            solidFill35.Append(schemeColor53);

            defaultRunProperties48.Append(solidFill35);

            level2ParagraphProperties7.Append(noBullet19);
            level2ParagraphProperties7.Append(defaultRunProperties48);

            A.Level3ParagraphProperties level3ParagraphProperties7 = new A.Level3ParagraphProperties();
            A.NoBullet noBullet20 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties49 = new A.DefaultRunProperties(){ FontSize = 1600 };

            A.SolidFill solidFill36 = new A.SolidFill();

            A.SchemeColor schemeColor54 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint10 = new A.Tint(){ Val = 75000 };

            schemeColor54.Append(tint10);

            solidFill36.Append(schemeColor54);

            defaultRunProperties49.Append(solidFill36);

            level3ParagraphProperties7.Append(noBullet20);
            level3ParagraphProperties7.Append(defaultRunProperties49);

            A.Level4ParagraphProperties level4ParagraphProperties7 = new A.Level4ParagraphProperties();
            A.NoBullet noBullet21 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties50 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill37 = new A.SolidFill();

            A.SchemeColor schemeColor55 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint11 = new A.Tint(){ Val = 75000 };

            schemeColor55.Append(tint11);

            solidFill37.Append(schemeColor55);

            defaultRunProperties50.Append(solidFill37);

            level4ParagraphProperties7.Append(noBullet21);
            level4ParagraphProperties7.Append(defaultRunProperties50);

            A.Level5ParagraphProperties level5ParagraphProperties7 = new A.Level5ParagraphProperties();
            A.NoBullet noBullet22 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties51 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill38 = new A.SolidFill();

            A.SchemeColor schemeColor56 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint12 = new A.Tint(){ Val = 75000 };

            schemeColor56.Append(tint12);

            solidFill38.Append(schemeColor56);

            defaultRunProperties51.Append(solidFill38);

            level5ParagraphProperties7.Append(noBullet22);
            level5ParagraphProperties7.Append(defaultRunProperties51);

            listStyle20.Append(level1ParagraphProperties14);
            listStyle20.Append(level2ParagraphProperties7);
            listStyle20.Append(level3ParagraphProperties7);
            listStyle20.Append(level4ParagraphProperties7);
            listStyle20.Append(level5ParagraphProperties7);

            A.Paragraph paragraph28 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties12 = new A.ParagraphProperties(){ Level = 0, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run17 = new A.Run();

            A.RunProperties runProperties23 = new A.RunProperties(){ Kumimoji = false, Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties23.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text23 = new A.Text();
            text23.Text = "Click to edit Master text styles";

            run17.Append(runProperties23);
            run17.Append(text23);

            paragraph28.Append(paragraphProperties12);
            paragraph28.Append(run17);

            textBody20.Append(bodyProperties20);
            textBody20.Append(listStyle20);
            textBody20.Append(paragraph28);

            shape20.Append(nonVisualShapeProperties20);
            shape20.Append(shapeProperties20);
            shape20.Append(textBody20);

            Shape shape21 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties21 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties26 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Date Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties21 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks21 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties21.Append(shapeLocks21);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties26 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape21 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties26.Append(placeholderShape21);

            nonVisualShapeProperties21.Append(nonVisualDrawingProperties26);
            nonVisualShapeProperties21.Append(nonVisualShapeDrawingProperties21);
            nonVisualShapeProperties21.Append(applicationNonVisualDrawingProperties26);
            ShapeProperties shapeProperties21 = new ShapeProperties();

            TextBody textBody21 = new TextBody();
            A.BodyProperties bodyProperties21 = new A.BodyProperties();
            A.ListStyle listStyle21 = new A.ListStyle();

            A.Paragraph paragraph29 = new A.Paragraph();

            A.Field field7 = new A.Field(){ Id = "{8263865E-5382-4BDD-A09E-2B63F38BCE59}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties24 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties24.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text24 = new A.Text();
            text24.Text = "2012/10/3";

            field7.Append(runProperties24);
            field7.Append(text24);
            A.EndParagraphRunProperties endParagraphRunProperties19 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph29.Append(field7);
            paragraph29.Append(endParagraphRunProperties19);

            textBody21.Append(bodyProperties21);
            textBody21.Append(listStyle21);
            textBody21.Append(paragraph29);

            shape21.Append(nonVisualShapeProperties21);
            shape21.Append(shapeProperties21);
            shape21.Append(textBody21);

            Shape shape22 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties22 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties27 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Footer Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties22 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks22 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties22.Append(shapeLocks22);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties27 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape22 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties27.Append(placeholderShape22);

            nonVisualShapeProperties22.Append(nonVisualDrawingProperties27);
            nonVisualShapeProperties22.Append(nonVisualShapeDrawingProperties22);
            nonVisualShapeProperties22.Append(applicationNonVisualDrawingProperties27);
            ShapeProperties shapeProperties22 = new ShapeProperties();

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
            shape22.Append(shapeProperties22);
            shape22.Append(textBody22);

            Shape shape23 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties23 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties28 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Slide Number Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties23 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks23 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties23.Append(shapeLocks23);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties28 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape23 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties28.Append(placeholderShape23);

            nonVisualShapeProperties23.Append(nonVisualDrawingProperties28);
            nonVisualShapeProperties23.Append(nonVisualShapeDrawingProperties23);
            nonVisualShapeProperties23.Append(applicationNonVisualDrawingProperties28);

            ShapeProperties shapeProperties23 = new ShapeProperties();

            A.Transform2D transform2D13 = new A.Transform2D();
            A.Offset offset18 = new A.Offset(){ X = 10566400L, Y = 6416676L };
            A.Extents extents18 = new A.Extents(){ Cx = 1016000L, Cy = 365125L };

            transform2D13.Append(offset18);
            transform2D13.Append(extents18);

            shapeProperties23.Append(transform2D13);

            TextBody textBody23 = new TextBody();
            A.BodyProperties bodyProperties23 = new A.BodyProperties();
            A.ListStyle listStyle23 = new A.ListStyle();

            A.Paragraph paragraph31 = new A.Paragraph();

            A.Field field8 = new A.Field(){ Id = "{DF0B8B9E-EDC2-479A-B980-EDD8632819B1}", Type = "slidenum" };

            A.RunProperties runProperties25 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties25.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text25 = new A.Text();
            text25.Text = "‹#›";

            field8.Append(runProperties25);
            field8.Append(text25);
            A.EndParagraphRunProperties endParagraphRunProperties21 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph31.Append(field8);
            paragraph31.Append(endParagraphRunProperties21);

            textBody23.Append(bodyProperties23);
            textBody23.Append(listStyle23);
            textBody23.Append(paragraph31);

            shape23.Append(nonVisualShapeProperties23);
            shape23.Append(shapeProperties23);
            shape23.Append(textBody23);

            shapeTree5.Append(nonVisualGroupShapeProperties5);
            shapeTree5.Append(groupShapeProperties5);
            shapeTree5.Append(shape19);
            shapeTree5.Append(shape20);
            shapeTree5.Append(shape21);
            shapeTree5.Append(shape22);
            shapeTree5.Append(shape23);

            CommonSlideDataExtensionList commonSlideDataExtensionList5 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension5 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId5 = new P14.CreationId(){ Val = (UInt32Value)3491605924U };
            creationId5.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension5.Append(creationId5);

            commonSlideDataExtensionList5.Append(commonSlideDataExtension5);

            commonSlideData5.Append(background2);
            commonSlideData5.Append(shapeTree5);
            commonSlideData5.Append(commonSlideDataExtensionList5);

            ColorMapOverride colorMapOverride4 = new ColorMapOverride();
            A.OverrideColorMapping overrideColorMapping1 = new A.OverrideColorMapping(){ Background1 = A.ColorSchemeIndexValues.Dark1, Text1 = A.ColorSchemeIndexValues.Light1, Background2 = A.ColorSchemeIndexValues.Dark2, Text2 = A.ColorSchemeIndexValues.Light2, Accent1 = A.ColorSchemeIndexValues.Accent1, Accent2 = A.ColorSchemeIndexValues.Accent2, Accent3 = A.ColorSchemeIndexValues.Accent3, Accent4 = A.ColorSchemeIndexValues.Accent4, Accent5 = A.ColorSchemeIndexValues.Accent5, Accent6 = A.ColorSchemeIndexValues.Accent6, Hyperlink = A.ColorSchemeIndexValues.Hyperlink, FollowedHyperlink = A.ColorSchemeIndexValues.FollowedHyperlink };

            colorMapOverride4.Append(overrideColorMapping1);

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
            NonVisualDrawingProperties nonVisualDrawingProperties29 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties6 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties29 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties6.Append(nonVisualDrawingProperties29);
            nonVisualGroupShapeProperties6.Append(nonVisualGroupShapeDrawingProperties6);
            nonVisualGroupShapeProperties6.Append(applicationNonVisualDrawingProperties29);

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

            Shape shape24 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties24 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties30 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Date Placeholder 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties24 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks24 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties24.Append(shapeLocks24);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties30 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape24 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties30.Append(placeholderShape24);

            nonVisualShapeProperties24.Append(nonVisualDrawingProperties30);
            nonVisualShapeProperties24.Append(nonVisualShapeDrawingProperties24);
            nonVisualShapeProperties24.Append(applicationNonVisualDrawingProperties30);
            ShapeProperties shapeProperties24 = new ShapeProperties();

            TextBody textBody24 = new TextBody();
            A.BodyProperties bodyProperties24 = new A.BodyProperties();
            A.ListStyle listStyle24 = new A.ListStyle();

            A.Paragraph paragraph32 = new A.Paragraph();

            A.Field field9 = new A.Field(){ Id = "{8263865E-5382-4BDD-A09E-2B63F38BCE59}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties26 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties26.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text26 = new A.Text();
            text26.Text = "2012/10/3";

            field9.Append(runProperties26);
            field9.Append(text26);
            A.EndParagraphRunProperties endParagraphRunProperties22 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph32.Append(field9);
            paragraph32.Append(endParagraphRunProperties22);

            textBody24.Append(bodyProperties24);
            textBody24.Append(listStyle24);
            textBody24.Append(paragraph32);

            shape24.Append(nonVisualShapeProperties24);
            shape24.Append(shapeProperties24);
            shape24.Append(textBody24);

            Shape shape25 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties25 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties31 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Footer Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties25 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks25 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties25.Append(shapeLocks25);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties31 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape25 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties31.Append(placeholderShape25);

            nonVisualShapeProperties25.Append(nonVisualDrawingProperties31);
            nonVisualShapeProperties25.Append(nonVisualShapeDrawingProperties25);
            nonVisualShapeProperties25.Append(applicationNonVisualDrawingProperties31);
            ShapeProperties shapeProperties25 = new ShapeProperties();

            TextBody textBody25 = new TextBody();
            A.BodyProperties bodyProperties25 = new A.BodyProperties();
            A.ListStyle listStyle25 = new A.ListStyle();

            A.Paragraph paragraph33 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties23 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph33.Append(endParagraphRunProperties23);

            textBody25.Append(bodyProperties25);
            textBody25.Append(listStyle25);
            textBody25.Append(paragraph33);

            shape25.Append(nonVisualShapeProperties25);
            shape25.Append(shapeProperties25);
            shape25.Append(textBody25);

            Shape shape26 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties26 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties32 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Slide Number Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties26 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks26 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties26.Append(shapeLocks26);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties32 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape26 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties32.Append(placeholderShape26);

            nonVisualShapeProperties26.Append(nonVisualDrawingProperties32);
            nonVisualShapeProperties26.Append(nonVisualShapeDrawingProperties26);
            nonVisualShapeProperties26.Append(applicationNonVisualDrawingProperties32);
            ShapeProperties shapeProperties26 = new ShapeProperties();

            TextBody textBody26 = new TextBody();
            A.BodyProperties bodyProperties26 = new A.BodyProperties();
            A.ListStyle listStyle26 = new A.ListStyle();

            A.Paragraph paragraph34 = new A.Paragraph();

            A.Field field10 = new A.Field(){ Id = "{DF0B8B9E-EDC2-479A-B980-EDD8632819B1}", Type = "slidenum" };

            A.RunProperties runProperties27 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties27.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text27 = new A.Text();
            text27.Text = "‹#›";

            field10.Append(runProperties27);
            field10.Append(text27);
            A.EndParagraphRunProperties endParagraphRunProperties24 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph34.Append(field10);
            paragraph34.Append(endParagraphRunProperties24);

            textBody26.Append(bodyProperties26);
            textBody26.Append(listStyle26);
            textBody26.Append(paragraph34);

            shape26.Append(nonVisualShapeProperties26);
            shape26.Append(shapeProperties26);
            shape26.Append(textBody26);

            shapeTree6.Append(nonVisualGroupShapeProperties6);
            shapeTree6.Append(groupShapeProperties6);
            shapeTree6.Append(shape24);
            shapeTree6.Append(shape25);
            shapeTree6.Append(shape26);

            CommonSlideDataExtensionList commonSlideDataExtensionList6 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension6 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId6 = new P14.CreationId(){ Val = (UInt32Value)4239097355U };
            creationId6.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension6.Append(creationId6);

            commonSlideDataExtensionList6.Append(commonSlideDataExtension6);

            commonSlideData6.Append(shapeTree6);
            commonSlideData6.Append(commonSlideDataExtensionList6);

            ColorMapOverride colorMapOverride5 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping4 = new A.MasterColorMapping();

            colorMapOverride5.Append(masterColorMapping4);

            slideLayout4.Append(commonSlideData6);
            slideLayout4.Append(colorMapOverride5);

            slideLayoutPart4.SlideLayout = slideLayout4;
        }

        // Generates content of themePart1.
        private void GenerateThemePart1Content(ThemePart themePart1)
        {
            A.Theme theme1 = new A.Theme(){ Name = "Apex" };
            theme1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            A.ThemeElements themeElements1 = new A.ThemeElements();

            A.ColorScheme colorScheme1 = new A.ColorScheme(){ Name = "Apex" };

            A.Dark1Color dark1Color1 = new A.Dark1Color();
            A.SystemColor systemColor1 = new A.SystemColor(){ Val = A.SystemColorValues.WindowText, LastColor = "000000" };

            dark1Color1.Append(systemColor1);

            A.Light1Color light1Color1 = new A.Light1Color();
            A.SystemColor systemColor2 = new A.SystemColor(){ Val = A.SystemColorValues.Window, LastColor = "FFFFFF" };

            light1Color1.Append(systemColor2);

            A.Dark2Color dark2Color1 = new A.Dark2Color();
            A.RgbColorModelHex rgbColorModelHex4 = new A.RgbColorModelHex(){ Val = "69676D" };

            dark2Color1.Append(rgbColorModelHex4);

            A.Light2Color light2Color1 = new A.Light2Color();
            A.RgbColorModelHex rgbColorModelHex5 = new A.RgbColorModelHex(){ Val = "C9C2D1" };

            light2Color1.Append(rgbColorModelHex5);

            A.Accent1Color accent1Color1 = new A.Accent1Color();
            A.RgbColorModelHex rgbColorModelHex6 = new A.RgbColorModelHex(){ Val = "CEB966" };

            accent1Color1.Append(rgbColorModelHex6);

            A.Accent2Color accent2Color1 = new A.Accent2Color();
            A.RgbColorModelHex rgbColorModelHex7 = new A.RgbColorModelHex(){ Val = "9CB084" };

            accent2Color1.Append(rgbColorModelHex7);

            A.Accent3Color accent3Color1 = new A.Accent3Color();
            A.RgbColorModelHex rgbColorModelHex8 = new A.RgbColorModelHex(){ Val = "6BB1C9" };

            accent3Color1.Append(rgbColorModelHex8);

            A.Accent4Color accent4Color1 = new A.Accent4Color();
            A.RgbColorModelHex rgbColorModelHex9 = new A.RgbColorModelHex(){ Val = "6585CF" };

            accent4Color1.Append(rgbColorModelHex9);

            A.Accent5Color accent5Color1 = new A.Accent5Color();
            A.RgbColorModelHex rgbColorModelHex10 = new A.RgbColorModelHex(){ Val = "7E6BC9" };

            accent5Color1.Append(rgbColorModelHex10);

            A.Accent6Color accent6Color1 = new A.Accent6Color();
            A.RgbColorModelHex rgbColorModelHex11 = new A.RgbColorModelHex(){ Val = "A379BB" };

            accent6Color1.Append(rgbColorModelHex11);

            A.Hyperlink hyperlink1 = new A.Hyperlink();
            A.RgbColorModelHex rgbColorModelHex12 = new A.RgbColorModelHex(){ Val = "410082" };

            hyperlink1.Append(rgbColorModelHex12);

            A.FollowedHyperlinkColor followedHyperlinkColor1 = new A.FollowedHyperlinkColor();
            A.RgbColorModelHex rgbColorModelHex13 = new A.RgbColorModelHex(){ Val = "932968" };

            followedHyperlinkColor1.Append(rgbColorModelHex13);

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

            A.FontScheme fontScheme1 = new A.FontScheme(){ Name = "Apex" };

            A.MajorFont majorFont1 = new A.MajorFont();
            A.LatinFont latinFont30 = new A.LatinFont(){ Typeface = "Lucida Sans" };
            A.EastAsianFont eastAsianFont30 = new A.EastAsianFont(){ Typeface = "" };
            A.ComplexScriptFont complexScriptFont30 = new A.ComplexScriptFont(){ Typeface = "" };
            A.SupplementalFont supplementalFont1 = new A.SupplementalFont(){ Script = "Grek", Typeface = "Arial" };
            A.SupplementalFont supplementalFont2 = new A.SupplementalFont(){ Script = "Cyrl", Typeface = "Arial" };
            A.SupplementalFont supplementalFont3 = new A.SupplementalFont(){ Script = "Jpan", Typeface = "HG丸ｺﾞｼｯｸM-PRO" };
            A.SupplementalFont supplementalFont4 = new A.SupplementalFont(){ Script = "Hang", Typeface = "휴먼옛체" };
            A.SupplementalFont supplementalFont5 = new A.SupplementalFont(){ Script = "Hans", Typeface = "黑体" };
            A.SupplementalFont supplementalFont6 = new A.SupplementalFont(){ Script = "Hant", Typeface = "微軟正黑體" };
            A.SupplementalFont supplementalFont7 = new A.SupplementalFont(){ Script = "Arab", Typeface = "Tahoma" };
            A.SupplementalFont supplementalFont8 = new A.SupplementalFont(){ Script = "Hebr", Typeface = "Levenim MT" };
            A.SupplementalFont supplementalFont9 = new A.SupplementalFont(){ Script = "Thai", Typeface = "FreesiaUPC" };
            A.SupplementalFont supplementalFont10 = new A.SupplementalFont(){ Script = "Ethi", Typeface = "Nyala" };
            A.SupplementalFont supplementalFont11 = new A.SupplementalFont(){ Script = "Beng", Typeface = "Vrinda" };
            A.SupplementalFont supplementalFont12 = new A.SupplementalFont(){ Script = "Gujr", Typeface = "Shruti" };
            A.SupplementalFont supplementalFont13 = new A.SupplementalFont(){ Script = "Khmr", Typeface = "DaunPenh" };
            A.SupplementalFont supplementalFont14 = new A.SupplementalFont(){ Script = "Knda", Typeface = "Tunga" };
            A.SupplementalFont supplementalFont15 = new A.SupplementalFont(){ Script = "Guru", Typeface = "Raavi" };
            A.SupplementalFont supplementalFont16 = new A.SupplementalFont(){ Script = "Cans", Typeface = "Euphemia" };
            A.SupplementalFont supplementalFont17 = new A.SupplementalFont(){ Script = "Cher", Typeface = "Plantagenet Cherokee" };
            A.SupplementalFont supplementalFont18 = new A.SupplementalFont(){ Script = "Yiii", Typeface = "Microsoft Yi Baiti" };
            A.SupplementalFont supplementalFont19 = new A.SupplementalFont(){ Script = "Tibt", Typeface = "Microsoft Himalaya" };
            A.SupplementalFont supplementalFont20 = new A.SupplementalFont(){ Script = "Thaa", Typeface = "MV Boli" };
            A.SupplementalFont supplementalFont21 = new A.SupplementalFont(){ Script = "Deva", Typeface = "Mangal" };
            A.SupplementalFont supplementalFont22 = new A.SupplementalFont(){ Script = "Telu", Typeface = "Gautami" };
            A.SupplementalFont supplementalFont23 = new A.SupplementalFont(){ Script = "Taml", Typeface = "Latha" };
            A.SupplementalFont supplementalFont24 = new A.SupplementalFont(){ Script = "Syrc", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont25 = new A.SupplementalFont(){ Script = "Orya", Typeface = "Kalinga" };
            A.SupplementalFont supplementalFont26 = new A.SupplementalFont(){ Script = "Mlym", Typeface = "Kartika" };
            A.SupplementalFont supplementalFont27 = new A.SupplementalFont(){ Script = "Laoo", Typeface = "DokChampa" };
            A.SupplementalFont supplementalFont28 = new A.SupplementalFont(){ Script = "Sinh", Typeface = "Iskoola Pota" };
            A.SupplementalFont supplementalFont29 = new A.SupplementalFont(){ Script = "Mong", Typeface = "Mongolian Baiti" };
            A.SupplementalFont supplementalFont30 = new A.SupplementalFont(){ Script = "Viet", Typeface = "Tahoma" };
            A.SupplementalFont supplementalFont31 = new A.SupplementalFont(){ Script = "Uigh", Typeface = "Microsoft Uighur" };
            A.SupplementalFont supplementalFont32 = new A.SupplementalFont(){ Script = "Geor", Typeface = "Sylfaen" };

            majorFont1.Append(latinFont30);
            majorFont1.Append(eastAsianFont30);
            majorFont1.Append(complexScriptFont30);
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

            A.MinorFont minorFont1 = new A.MinorFont();
            A.LatinFont latinFont31 = new A.LatinFont(){ Typeface = "Book Antiqua" };
            A.EastAsianFont eastAsianFont31 = new A.EastAsianFont(){ Typeface = "" };
            A.ComplexScriptFont complexScriptFont31 = new A.ComplexScriptFont(){ Typeface = "" };
            A.SupplementalFont supplementalFont33 = new A.SupplementalFont(){ Script = "Grek", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont34 = new A.SupplementalFont(){ Script = "Cyrl", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont35 = new A.SupplementalFont(){ Script = "Jpan", Typeface = "HG明朝B" };
            A.SupplementalFont supplementalFont36 = new A.SupplementalFont(){ Script = "Hang", Typeface = "돋움" };
            A.SupplementalFont supplementalFont37 = new A.SupplementalFont(){ Script = "Hans", Typeface = "宋体" };
            A.SupplementalFont supplementalFont38 = new A.SupplementalFont(){ Script = "Hant", Typeface = "新細明體" };
            A.SupplementalFont supplementalFont39 = new A.SupplementalFont(){ Script = "Arab", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont40 = new A.SupplementalFont(){ Script = "Hebr", Typeface = "David" };
            A.SupplementalFont supplementalFont41 = new A.SupplementalFont(){ Script = "Thai", Typeface = "EucrosiaUPC" };
            A.SupplementalFont supplementalFont42 = new A.SupplementalFont(){ Script = "Ethi", Typeface = "Nyala" };
            A.SupplementalFont supplementalFont43 = new A.SupplementalFont(){ Script = "Beng", Typeface = "Vrinda" };
            A.SupplementalFont supplementalFont44 = new A.SupplementalFont(){ Script = "Gujr", Typeface = "Shruti" };
            A.SupplementalFont supplementalFont45 = new A.SupplementalFont(){ Script = "Khmr", Typeface = "MoolBoran" };
            A.SupplementalFont supplementalFont46 = new A.SupplementalFont(){ Script = "Knda", Typeface = "Tunga" };
            A.SupplementalFont supplementalFont47 = new A.SupplementalFont(){ Script = "Guru", Typeface = "Raavi" };
            A.SupplementalFont supplementalFont48 = new A.SupplementalFont(){ Script = "Cans", Typeface = "Euphemia" };
            A.SupplementalFont supplementalFont49 = new A.SupplementalFont(){ Script = "Cher", Typeface = "Plantagenet Cherokee" };
            A.SupplementalFont supplementalFont50 = new A.SupplementalFont(){ Script = "Yiii", Typeface = "Microsoft Yi Baiti" };
            A.SupplementalFont supplementalFont51 = new A.SupplementalFont(){ Script = "Tibt", Typeface = "Microsoft Himalaya" };
            A.SupplementalFont supplementalFont52 = new A.SupplementalFont(){ Script = "Thaa", Typeface = "MV Boli" };
            A.SupplementalFont supplementalFont53 = new A.SupplementalFont(){ Script = "Deva", Typeface = "Mangal" };
            A.SupplementalFont supplementalFont54 = new A.SupplementalFont(){ Script = "Telu", Typeface = "Gautami" };
            A.SupplementalFont supplementalFont55 = new A.SupplementalFont(){ Script = "Taml", Typeface = "Latha" };
            A.SupplementalFont supplementalFont56 = new A.SupplementalFont(){ Script = "Syrc", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont57 = new A.SupplementalFont(){ Script = "Orya", Typeface = "Kalinga" };
            A.SupplementalFont supplementalFont58 = new A.SupplementalFont(){ Script = "Mlym", Typeface = "Kartika" };
            A.SupplementalFont supplementalFont59 = new A.SupplementalFont(){ Script = "Laoo", Typeface = "DokChampa" };
            A.SupplementalFont supplementalFont60 = new A.SupplementalFont(){ Script = "Sinh", Typeface = "Iskoola Pota" };
            A.SupplementalFont supplementalFont61 = new A.SupplementalFont(){ Script = "Mong", Typeface = "Mongolian Baiti" };
            A.SupplementalFont supplementalFont62 = new A.SupplementalFont(){ Script = "Viet", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont63 = new A.SupplementalFont(){ Script = "Uigh", Typeface = "Microsoft Uighur" };
            A.SupplementalFont supplementalFont64 = new A.SupplementalFont(){ Script = "Geor", Typeface = "Sylfaen" };

            minorFont1.Append(latinFont31);
            minorFont1.Append(eastAsianFont31);
            minorFont1.Append(complexScriptFont31);
            minorFont1.Append(supplementalFont33);
            minorFont1.Append(supplementalFont34);
            minorFont1.Append(supplementalFont35);
            minorFont1.Append(supplementalFont36);
            minorFont1.Append(supplementalFont37);
            minorFont1.Append(supplementalFont38);
            minorFont1.Append(supplementalFont39);
            minorFont1.Append(supplementalFont40);
            minorFont1.Append(supplementalFont41);
            minorFont1.Append(supplementalFont42);
            minorFont1.Append(supplementalFont43);
            minorFont1.Append(supplementalFont44);
            minorFont1.Append(supplementalFont45);
            minorFont1.Append(supplementalFont46);
            minorFont1.Append(supplementalFont47);
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

            fontScheme1.Append(majorFont1);
            fontScheme1.Append(minorFont1);

            A.FormatScheme formatScheme1 = new A.FormatScheme(){ Name = "Apex" };

            A.FillStyleList fillStyleList1 = new A.FillStyleList();

            A.SolidFill solidFill39 = new A.SolidFill();
            A.SchemeColor schemeColor57 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill39.Append(schemeColor57);

            A.GradientFill gradientFill3 = new A.GradientFill(){ RotateWithShape = true };

            A.GradientStopList gradientStopList3 = new A.GradientStopList();

            A.GradientStop gradientStop7 = new A.GradientStop(){ Position = 20000 };

            A.SchemeColor schemeColor58 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint13 = new A.Tint(){ Val = 9000 };

            schemeColor58.Append(tint13);

            gradientStop7.Append(schemeColor58);

            A.GradientStop gradientStop8 = new A.GradientStop(){ Position = 100000 };

            A.SchemeColor schemeColor59 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint14 = new A.Tint(){ Val = 70000 };
            A.SaturationModulation saturationModulation9 = new A.SaturationModulation(){ Val = 100000 };

            schemeColor59.Append(tint14);
            schemeColor59.Append(saturationModulation9);

            gradientStop8.Append(schemeColor59);

            gradientStopList3.Append(gradientStop7);
            gradientStopList3.Append(gradientStop8);

            A.PathGradientFill pathGradientFill1 = new A.PathGradientFill(){ Path = A.PathShadeValues.Circle };
            A.FillToRectangle fillToRectangle1 = new A.FillToRectangle(){ Left = -15000, Top = -15000, Right = 115000, Bottom = 115000 };

            pathGradientFill1.Append(fillToRectangle1);

            gradientFill3.Append(gradientStopList3);
            gradientFill3.Append(pathGradientFill1);

            A.GradientFill gradientFill4 = new A.GradientFill(){ RotateWithShape = true };

            A.GradientStopList gradientStopList4 = new A.GradientStopList();

            A.GradientStop gradientStop9 = new A.GradientStop(){ Position = 0 };

            A.SchemeColor schemeColor60 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Shade shade6 = new A.Shade(){ Val = 60000 };

            schemeColor60.Append(shade6);

            gradientStop9.Append(schemeColor60);

            A.GradientStop gradientStop10 = new A.GradientStop(){ Position = 33000 };

            A.SchemeColor schemeColor61 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint15 = new A.Tint(){ Val = 86500 };

            schemeColor61.Append(tint15);

            gradientStop10.Append(schemeColor61);

            A.GradientStop gradientStop11 = new A.GradientStop(){ Position = 46750 };

            A.SchemeColor schemeColor62 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint16 = new A.Tint(){ Val = 71000 };
            A.SaturationModulation saturationModulation10 = new A.SaturationModulation(){ Val = 112000 };

            schemeColor62.Append(tint16);
            schemeColor62.Append(saturationModulation10);

            gradientStop11.Append(schemeColor62);

            A.GradientStop gradientStop12 = new A.GradientStop(){ Position = 53000 };

            A.SchemeColor schemeColor63 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint17 = new A.Tint(){ Val = 71000 };
            A.SaturationModulation saturationModulation11 = new A.SaturationModulation(){ Val = 112000 };

            schemeColor63.Append(tint17);
            schemeColor63.Append(saturationModulation11);

            gradientStop12.Append(schemeColor63);

            A.GradientStop gradientStop13 = new A.GradientStop(){ Position = 68000 };

            A.SchemeColor schemeColor64 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint18 = new A.Tint(){ Val = 86000 };

            schemeColor64.Append(tint18);

            gradientStop13.Append(schemeColor64);

            A.GradientStop gradientStop14 = new A.GradientStop(){ Position = 100000 };

            A.SchemeColor schemeColor65 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Shade shade7 = new A.Shade(){ Val = 60000 };

            schemeColor65.Append(shade7);

            gradientStop14.Append(schemeColor65);

            gradientStopList4.Append(gradientStop9);
            gradientStopList4.Append(gradientStop10);
            gradientStopList4.Append(gradientStop11);
            gradientStopList4.Append(gradientStop12);
            gradientStopList4.Append(gradientStop13);
            gradientStopList4.Append(gradientStop14);
            A.LinearGradientFill linearGradientFill3 = new A.LinearGradientFill(){ Angle = 8350000, Scaled = true };

            gradientFill4.Append(gradientStopList4);
            gradientFill4.Append(linearGradientFill3);

            fillStyleList1.Append(solidFill39);
            fillStyleList1.Append(gradientFill3);
            fillStyleList1.Append(gradientFill4);

            A.LineStyleList lineStyleList1 = new A.LineStyleList();

            A.Outline outline5 = new A.Outline(){ Width = 9525, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill40 = new A.SolidFill();

            A.SchemeColor schemeColor66 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Shade shade8 = new A.Shade(){ Val = 48000 };
            A.SaturationModulation saturationModulation12 = new A.SaturationModulation(){ Val = 110000 };

            schemeColor66.Append(shade8);
            schemeColor66.Append(saturationModulation12);

            solidFill40.Append(schemeColor66);
            A.PresetDash presetDash1 = new A.PresetDash(){ Val = A.PresetLineDashValues.Solid };

            outline5.Append(solidFill40);
            outline5.Append(presetDash1);

            A.Outline outline6 = new A.Outline(){ Width = 25400, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill41 = new A.SolidFill();
            A.SchemeColor schemeColor67 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill41.Append(schemeColor67);
            A.PresetDash presetDash2 = new A.PresetDash(){ Val = A.PresetLineDashValues.Solid };

            outline6.Append(solidFill41);
            outline6.Append(presetDash2);

            A.Outline outline7 = new A.Outline(){ Width = 38100, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill42 = new A.SolidFill();
            A.SchemeColor schemeColor68 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill42.Append(schemeColor68);
            A.PresetDash presetDash3 = new A.PresetDash(){ Val = A.PresetLineDashValues.Solid };

            outline7.Append(solidFill42);
            outline7.Append(presetDash3);

            lineStyleList1.Append(outline5);
            lineStyleList1.Append(outline6);
            lineStyleList1.Append(outline7);

            A.EffectStyleList effectStyleList1 = new A.EffectStyleList();

            A.EffectStyle effectStyle1 = new A.EffectStyle();

            A.EffectList effectList4 = new A.EffectList();

            A.OuterShadow outerShadow4 = new A.OuterShadow(){ BlurRadius = 130000L, Distance = 101600L, Direction = 2700000, Alignment = A.RectangleAlignmentValues.TopLeft, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex14 = new A.RgbColorModelHex(){ Val = "000000" };
            A.Alpha alpha4 = new A.Alpha(){ Val = 35000 };

            rgbColorModelHex14.Append(alpha4);

            outerShadow4.Append(rgbColorModelHex14);

            effectList4.Append(outerShadow4);

            effectStyle1.Append(effectList4);

            A.EffectStyle effectStyle2 = new A.EffectStyle();

            A.EffectList effectList5 = new A.EffectList();

            A.OuterShadow outerShadow5 = new A.OuterShadow(){ BlurRadius = 190500L, Distance = 228600L, Direction = 2700000, VerticalRatio = 90000, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex15 = new A.RgbColorModelHex(){ Val = "000000" };
            A.Alpha alpha5 = new A.Alpha(){ Val = 25500 };

            rgbColorModelHex15.Append(alpha5);

            outerShadow5.Append(rgbColorModelHex15);

            effectList5.Append(outerShadow5);

            effectStyle2.Append(effectList5);

            A.EffectStyle effectStyle3 = new A.EffectStyle();

            A.EffectList effectList6 = new A.EffectList();

            A.OuterShadow outerShadow6 = new A.OuterShadow(){ BlurRadius = 190500L, Distance = 228600L, Direction = 2700000, VerticalRatio = 90000, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex16 = new A.RgbColorModelHex(){ Val = "000000" };
            A.Alpha alpha6 = new A.Alpha(){ Val = 25500 };

            rgbColorModelHex16.Append(alpha6);

            outerShadow6.Append(rgbColorModelHex16);

            effectList6.Append(outerShadow6);

            A.Scene3DType scene3DType4 = new A.Scene3DType();

            A.Camera camera4 = new A.Camera(){ Preset = A.PresetCameraValues.OrthographicFront, FieldOfView = 0 };
            A.Rotation rotation4 = new A.Rotation(){ Latitude = 0, Longitude = 0, Revolution = 0 };

            camera4.Append(rotation4);

            A.LightRig lightRig4 = new A.LightRig(){ Rig = A.LightRigValues.Soft, Direction = A.LightRigDirectionValues.TopLeft };
            A.Rotation rotation5 = new A.Rotation(){ Latitude = 0, Longitude = 0, Revolution = 20100000 };

            lightRig4.Append(rotation5);

            scene3DType4.Append(camera4);
            scene3DType4.Append(lightRig4);

            A.Shape3DType shape3DType5 = new A.Shape3DType();
            A.BevelTop bevelTop4 = new A.BevelTop(){ Width = 50800L, Height = 50800L };

            shape3DType5.Append(bevelTop4);

            effectStyle3.Append(effectList6);
            effectStyle3.Append(scene3DType4);
            effectStyle3.Append(shape3DType5);

            effectStyleList1.Append(effectStyle1);
            effectStyleList1.Append(effectStyle2);
            effectStyleList1.Append(effectStyle3);

            A.BackgroundFillStyleList backgroundFillStyleList1 = new A.BackgroundFillStyleList();

            A.SolidFill solidFill43 = new A.SolidFill();
            A.SchemeColor schemeColor69 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill43.Append(schemeColor69);

            A.GradientFill gradientFill5 = new A.GradientFill(){ RotateWithShape = true };

            A.GradientStopList gradientStopList5 = new A.GradientStopList();

            A.GradientStop gradientStop15 = new A.GradientStop(){ Position = 0 };

            A.SchemeColor schemeColor70 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint19 = new A.Tint(){ Val = 50000 };
            A.SaturationModulation saturationModulation13 = new A.SaturationModulation(){ Val = 180000 };

            schemeColor70.Append(tint19);
            schemeColor70.Append(saturationModulation13);

            gradientStop15.Append(schemeColor70);

            A.GradientStop gradientStop16 = new A.GradientStop(){ Position = 100000 };

            A.SchemeColor schemeColor71 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Shade shade9 = new A.Shade(){ Val = 45000 };
            A.SaturationModulation saturationModulation14 = new A.SaturationModulation(){ Val = 120000 };

            schemeColor71.Append(shade9);
            schemeColor71.Append(saturationModulation14);

            gradientStop16.Append(schemeColor71);

            gradientStopList5.Append(gradientStop15);
            gradientStopList5.Append(gradientStop16);

            A.PathGradientFill pathGradientFill2 = new A.PathGradientFill(){ Path = A.PathShadeValues.Circle };
            A.FillToRectangle fillToRectangle2 = new A.FillToRectangle(){ Right = 100000, Bottom = 100000 };

            pathGradientFill2.Append(fillToRectangle2);

            gradientFill5.Append(gradientStopList5);
            gradientFill5.Append(pathGradientFill2);

            A.BlipFill blipFill1 = new A.BlipFill();

            A.Blip blip1 = new A.Blip(){ Embed = "rId1" };
            blip1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");

            A.Duotone duotone1 = new A.Duotone();

            A.SchemeColor schemeColor72 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Shade shade10 = new A.Shade(){ Val = 3000 };
            A.SaturationModulation saturationModulation15 = new A.SaturationModulation(){ Val = 110000 };

            schemeColor72.Append(shade10);
            schemeColor72.Append(saturationModulation15);

            A.SchemeColor schemeColor73 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint20 = new A.Tint(){ Val = 60000 };
            A.SaturationModulation saturationModulation16 = new A.SaturationModulation(){ Val = 425000 };

            schemeColor73.Append(tint20);
            schemeColor73.Append(saturationModulation16);

            duotone1.Append(schemeColor72);
            duotone1.Append(schemeColor73);

            blip1.Append(duotone1);

            A.Stretch stretch1 = new A.Stretch();
            A.FillRectangle fillRectangle1 = new A.FillRectangle();

            stretch1.Append(fillRectangle1);

            blipFill1.Append(blip1);
            blipFill1.Append(stretch1);

            backgroundFillStyleList1.Append(solidFill43);
            backgroundFillStyleList1.Append(gradientFill5);
            backgroundFillStyleList1.Append(blipFill1);

            formatScheme1.Append(fillStyleList1);
            formatScheme1.Append(lineStyleList1);
            formatScheme1.Append(effectStyleList1);
            formatScheme1.Append(backgroundFillStyleList1);

            themeElements1.Append(colorScheme1);
            themeElements1.Append(fontScheme1);
            themeElements1.Append(formatScheme1);
            A.ObjectDefaults objectDefaults1 = new A.ObjectDefaults();
            A.ExtraColorSchemeList extraColorSchemeList1 = new A.ExtraColorSchemeList();

            theme1.Append(themeElements1);
            theme1.Append(objectDefaults1);
            theme1.Append(extraColorSchemeList1);

            themePart1.Theme = theme1;
        }

        // Generates content of imagePart1.
        private void GenerateImagePart1Content(ImagePart imagePart1)
        {
            System.IO.Stream data = GetBinaryDataStream(imagePart1Data);
            imagePart1.FeedData(data);
            data.Close();
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
            NonVisualDrawingProperties nonVisualDrawingProperties33 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties7 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties33 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties7.Append(nonVisualDrawingProperties33);
            nonVisualGroupShapeProperties7.Append(nonVisualGroupShapeDrawingProperties7);
            nonVisualGroupShapeProperties7.Append(applicationNonVisualDrawingProperties33);

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

            Shape shape27 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties27 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties34 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties27 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks27 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties27.Append(shapeLocks27);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties34 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape27 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties34.Append(placeholderShape27);

            nonVisualShapeProperties27.Append(nonVisualDrawingProperties34);
            nonVisualShapeProperties27.Append(nonVisualShapeDrawingProperties27);
            nonVisualShapeProperties27.Append(applicationNonVisualDrawingProperties34);
            ShapeProperties shapeProperties27 = new ShapeProperties();

            TextBody textBody27 = new TextBody();
            A.BodyProperties bodyProperties27 = new A.BodyProperties();
            A.ListStyle listStyle27 = new A.ListStyle();

            A.Paragraph paragraph35 = new A.Paragraph();

            A.Run run18 = new A.Run();

            A.RunProperties runProperties28 = new A.RunProperties(){ Kumimoji = false, Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties28.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text28 = new A.Text();
            text28.Text = "Click to edit Master title style";

            run18.Append(runProperties28);
            run18.Append(text28);
            A.EndParagraphRunProperties endParagraphRunProperties25 = new A.EndParagraphRunProperties(){ Kumimoji = false, Language = "en-US" };

            paragraph35.Append(run18);
            paragraph35.Append(endParagraphRunProperties25);

            textBody27.Append(bodyProperties27);
            textBody27.Append(listStyle27);
            textBody27.Append(paragraph35);

            shape27.Append(nonVisualShapeProperties27);
            shape27.Append(shapeProperties27);
            shape27.Append(textBody27);

            Shape shape28 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties28 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties35 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Content Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties28 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks28 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties28.Append(shapeLocks28);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties35 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape28 = new PlaceholderShape(){ Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties35.Append(placeholderShape28);

            nonVisualShapeProperties28.Append(nonVisualDrawingProperties35);
            nonVisualShapeProperties28.Append(nonVisualShapeDrawingProperties28);
            nonVisualShapeProperties28.Append(applicationNonVisualDrawingProperties35);
            ShapeProperties shapeProperties28 = new ShapeProperties();

            TextBody textBody28 = new TextBody();
            A.BodyProperties bodyProperties28 = new A.BodyProperties();
            A.ListStyle listStyle28 = new A.ListStyle();

            A.Paragraph paragraph36 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties13 = new A.ParagraphProperties(){ Level = 0, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run19 = new A.Run();

            A.RunProperties runProperties29 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties29.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text29 = new A.Text();
            text29.Text = "Click to edit Master text styles";

            run19.Append(runProperties29);
            run19.Append(text29);

            paragraph36.Append(paragraphProperties13);
            paragraph36.Append(run19);

            A.Paragraph paragraph37 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties14 = new A.ParagraphProperties(){ Level = 1, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run20 = new A.Run();

            A.RunProperties runProperties30 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties30.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text30 = new A.Text();
            text30.Text = "Second level";

            run20.Append(runProperties30);
            run20.Append(text30);

            paragraph37.Append(paragraphProperties14);
            paragraph37.Append(run20);

            A.Paragraph paragraph38 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties15 = new A.ParagraphProperties(){ Level = 2, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run21 = new A.Run();

            A.RunProperties runProperties31 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties31.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text31 = new A.Text();
            text31.Text = "Third level";

            run21.Append(runProperties31);
            run21.Append(text31);

            paragraph38.Append(paragraphProperties15);
            paragraph38.Append(run21);

            A.Paragraph paragraph39 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties16 = new A.ParagraphProperties(){ Level = 3, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run22 = new A.Run();

            A.RunProperties runProperties32 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties32.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text32 = new A.Text();
            text32.Text = "Fourth level";

            run22.Append(runProperties32);
            run22.Append(text32);

            paragraph39.Append(paragraphProperties16);
            paragraph39.Append(run22);

            A.Paragraph paragraph40 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties17 = new A.ParagraphProperties(){ Level = 4, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run23 = new A.Run();

            A.RunProperties runProperties33 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties33.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text33 = new A.Text();
            text33.Text = "Fifth level";

            run23.Append(runProperties33);
            run23.Append(text33);
            A.EndParagraphRunProperties endParagraphRunProperties26 = new A.EndParagraphRunProperties(){ Kumimoji = false, Language = "en-US" };

            paragraph40.Append(paragraphProperties17);
            paragraph40.Append(run23);
            paragraph40.Append(endParagraphRunProperties26);

            textBody28.Append(bodyProperties28);
            textBody28.Append(listStyle28);
            textBody28.Append(paragraph36);
            textBody28.Append(paragraph37);
            textBody28.Append(paragraph38);
            textBody28.Append(paragraph39);
            textBody28.Append(paragraph40);

            shape28.Append(nonVisualShapeProperties28);
            shape28.Append(shapeProperties28);
            shape28.Append(textBody28);

            Shape shape29 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties29 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties36 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Date Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties29 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks29 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties29.Append(shapeLocks29);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties36 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape29 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties36.Append(placeholderShape29);

            nonVisualShapeProperties29.Append(nonVisualDrawingProperties36);
            nonVisualShapeProperties29.Append(nonVisualShapeDrawingProperties29);
            nonVisualShapeProperties29.Append(applicationNonVisualDrawingProperties36);
            ShapeProperties shapeProperties29 = new ShapeProperties();

            TextBody textBody29 = new TextBody();
            A.BodyProperties bodyProperties29 = new A.BodyProperties();
            A.ListStyle listStyle29 = new A.ListStyle();

            A.Paragraph paragraph41 = new A.Paragraph();

            A.Field field11 = new A.Field(){ Id = "{8263865E-5382-4BDD-A09E-2B63F38BCE59}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties34 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties34.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text34 = new A.Text();
            text34.Text = "2012/10/3";

            field11.Append(runProperties34);
            field11.Append(text34);
            A.EndParagraphRunProperties endParagraphRunProperties27 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph41.Append(field11);
            paragraph41.Append(endParagraphRunProperties27);

            textBody29.Append(bodyProperties29);
            textBody29.Append(listStyle29);
            textBody29.Append(paragraph41);

            shape29.Append(nonVisualShapeProperties29);
            shape29.Append(shapeProperties29);
            shape29.Append(textBody29);

            Shape shape30 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties30 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties37 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Footer Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties30 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks30 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties30.Append(shapeLocks30);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties37 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape30 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties37.Append(placeholderShape30);

            nonVisualShapeProperties30.Append(nonVisualDrawingProperties37);
            nonVisualShapeProperties30.Append(nonVisualShapeDrawingProperties30);
            nonVisualShapeProperties30.Append(applicationNonVisualDrawingProperties37);
            ShapeProperties shapeProperties30 = new ShapeProperties();

            TextBody textBody30 = new TextBody();
            A.BodyProperties bodyProperties30 = new A.BodyProperties();
            A.ListStyle listStyle30 = new A.ListStyle();

            A.Paragraph paragraph42 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties28 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph42.Append(endParagraphRunProperties28);

            textBody30.Append(bodyProperties30);
            textBody30.Append(listStyle30);
            textBody30.Append(paragraph42);

            shape30.Append(nonVisualShapeProperties30);
            shape30.Append(shapeProperties30);
            shape30.Append(textBody30);

            Shape shape31 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties31 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties38 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Slide Number Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties31 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks31 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties31.Append(shapeLocks31);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties38 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape31 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties38.Append(placeholderShape31);

            nonVisualShapeProperties31.Append(nonVisualDrawingProperties38);
            nonVisualShapeProperties31.Append(nonVisualShapeDrawingProperties31);
            nonVisualShapeProperties31.Append(applicationNonVisualDrawingProperties38);
            ShapeProperties shapeProperties31 = new ShapeProperties();

            TextBody textBody31 = new TextBody();
            A.BodyProperties bodyProperties31 = new A.BodyProperties();
            A.ListStyle listStyle31 = new A.ListStyle();

            A.Paragraph paragraph43 = new A.Paragraph();

            A.Field field12 = new A.Field(){ Id = "{DF0B8B9E-EDC2-479A-B980-EDD8632819B1}", Type = "slidenum" };

            A.RunProperties runProperties35 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties35.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text35 = new A.Text();
            text35.Text = "‹#›";

            field12.Append(runProperties35);
            field12.Append(text35);
            A.EndParagraphRunProperties endParagraphRunProperties29 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph43.Append(field12);
            paragraph43.Append(endParagraphRunProperties29);

            textBody31.Append(bodyProperties31);
            textBody31.Append(listStyle31);
            textBody31.Append(paragraph43);

            shape31.Append(nonVisualShapeProperties31);
            shape31.Append(shapeProperties31);
            shape31.Append(textBody31);

            shapeTree7.Append(nonVisualGroupShapeProperties7);
            shapeTree7.Append(groupShapeProperties7);
            shapeTree7.Append(shape27);
            shapeTree7.Append(shape28);
            shapeTree7.Append(shape29);
            shapeTree7.Append(shape30);
            shapeTree7.Append(shape31);

            CommonSlideDataExtensionList commonSlideDataExtensionList7 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension7 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId7 = new P14.CreationId(){ Val = (UInt32Value)2139364334U };
            creationId7.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension7.Append(creationId7);

            commonSlideDataExtensionList7.Append(commonSlideDataExtension7);

            commonSlideData7.Append(shapeTree7);
            commonSlideData7.Append(commonSlideDataExtensionList7);

            ColorMapOverride colorMapOverride6 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping5 = new A.MasterColorMapping();

            colorMapOverride6.Append(masterColorMapping5);

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
            NonVisualDrawingProperties nonVisualDrawingProperties39 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties8 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties39 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties8.Append(nonVisualDrawingProperties39);
            nonVisualGroupShapeProperties8.Append(nonVisualGroupShapeDrawingProperties8);
            nonVisualGroupShapeProperties8.Append(applicationNonVisualDrawingProperties39);

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

            Shape shape32 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties32 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties40 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties32 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks32 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties32.Append(shapeLocks32);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties40 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape32 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties40.Append(placeholderShape32);

            nonVisualShapeProperties32.Append(nonVisualDrawingProperties40);
            nonVisualShapeProperties32.Append(nonVisualShapeDrawingProperties32);
            nonVisualShapeProperties32.Append(applicationNonVisualDrawingProperties40);
            ShapeProperties shapeProperties32 = new ShapeProperties();

            TextBody textBody32 = new TextBody();
            A.BodyProperties bodyProperties32 = new A.BodyProperties();
            A.ListStyle listStyle32 = new A.ListStyle();

            A.Paragraph paragraph44 = new A.Paragraph();

            A.Run run24 = new A.Run();

            A.RunProperties runProperties36 = new A.RunProperties(){ Kumimoji = false, Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties36.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text36 = new A.Text();
            text36.Text = "Click to edit Master title style";

            run24.Append(runProperties36);
            run24.Append(text36);
            A.EndParagraphRunProperties endParagraphRunProperties30 = new A.EndParagraphRunProperties(){ Kumimoji = false, Language = "en-US" };

            paragraph44.Append(run24);
            paragraph44.Append(endParagraphRunProperties30);

            textBody32.Append(bodyProperties32);
            textBody32.Append(listStyle32);
            textBody32.Append(paragraph44);

            shape32.Append(nonVisualShapeProperties32);
            shape32.Append(shapeProperties32);
            shape32.Append(textBody32);

            Shape shape33 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties33 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties41 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Date Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties33 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks33 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties33.Append(shapeLocks33);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties41 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape33 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties41.Append(placeholderShape33);

            nonVisualShapeProperties33.Append(nonVisualDrawingProperties41);
            nonVisualShapeProperties33.Append(nonVisualShapeDrawingProperties33);
            nonVisualShapeProperties33.Append(applicationNonVisualDrawingProperties41);
            ShapeProperties shapeProperties33 = new ShapeProperties();

            TextBody textBody33 = new TextBody();
            A.BodyProperties bodyProperties33 = new A.BodyProperties();
            A.ListStyle listStyle33 = new A.ListStyle();

            A.Paragraph paragraph45 = new A.Paragraph();

            A.Field field13 = new A.Field(){ Id = "{8263865E-5382-4BDD-A09E-2B63F38BCE59}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties37 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties37.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text37 = new A.Text();
            text37.Text = "2012/10/3";

            field13.Append(runProperties37);
            field13.Append(text37);
            A.EndParagraphRunProperties endParagraphRunProperties31 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph45.Append(field13);
            paragraph45.Append(endParagraphRunProperties31);

            textBody33.Append(bodyProperties33);
            textBody33.Append(listStyle33);
            textBody33.Append(paragraph45);

            shape33.Append(nonVisualShapeProperties33);
            shape33.Append(shapeProperties33);
            shape33.Append(textBody33);

            Shape shape34 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties34 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties42 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Footer Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties34 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks34 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties34.Append(shapeLocks34);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties42 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape34 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties42.Append(placeholderShape34);

            nonVisualShapeProperties34.Append(nonVisualDrawingProperties42);
            nonVisualShapeProperties34.Append(nonVisualShapeDrawingProperties34);
            nonVisualShapeProperties34.Append(applicationNonVisualDrawingProperties42);
            ShapeProperties shapeProperties34 = new ShapeProperties();

            TextBody textBody34 = new TextBody();
            A.BodyProperties bodyProperties34 = new A.BodyProperties();
            A.ListStyle listStyle34 = new A.ListStyle();

            A.Paragraph paragraph46 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties32 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph46.Append(endParagraphRunProperties32);

            textBody34.Append(bodyProperties34);
            textBody34.Append(listStyle34);
            textBody34.Append(paragraph46);

            shape34.Append(nonVisualShapeProperties34);
            shape34.Append(shapeProperties34);
            shape34.Append(textBody34);

            Shape shape35 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties35 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties43 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Slide Number Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties35 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks35 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties35.Append(shapeLocks35);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties43 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape35 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties43.Append(placeholderShape35);

            nonVisualShapeProperties35.Append(nonVisualDrawingProperties43);
            nonVisualShapeProperties35.Append(nonVisualShapeDrawingProperties35);
            nonVisualShapeProperties35.Append(applicationNonVisualDrawingProperties43);
            ShapeProperties shapeProperties35 = new ShapeProperties();

            TextBody textBody35 = new TextBody();
            A.BodyProperties bodyProperties35 = new A.BodyProperties();
            A.ListStyle listStyle35 = new A.ListStyle();

            A.Paragraph paragraph47 = new A.Paragraph();

            A.Field field14 = new A.Field(){ Id = "{DF0B8B9E-EDC2-479A-B980-EDD8632819B1}", Type = "slidenum" };

            A.RunProperties runProperties38 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties38.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text38 = new A.Text();
            text38.Text = "‹#›";

            field14.Append(runProperties38);
            field14.Append(text38);
            A.EndParagraphRunProperties endParagraphRunProperties33 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph47.Append(field14);
            paragraph47.Append(endParagraphRunProperties33);

            textBody35.Append(bodyProperties35);
            textBody35.Append(listStyle35);
            textBody35.Append(paragraph47);

            shape35.Append(nonVisualShapeProperties35);
            shape35.Append(shapeProperties35);
            shape35.Append(textBody35);

            shapeTree8.Append(nonVisualGroupShapeProperties8);
            shapeTree8.Append(groupShapeProperties8);
            shapeTree8.Append(shape32);
            shapeTree8.Append(shape33);
            shapeTree8.Append(shape34);
            shapeTree8.Append(shape35);

            CommonSlideDataExtensionList commonSlideDataExtensionList8 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension8 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId8 = new P14.CreationId(){ Val = (UInt32Value)1031808600U };
            creationId8.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension8.Append(creationId8);

            commonSlideDataExtensionList8.Append(commonSlideDataExtension8);

            commonSlideData8.Append(shapeTree8);
            commonSlideData8.Append(commonSlideDataExtensionList8);

            ColorMapOverride colorMapOverride7 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping6 = new A.MasterColorMapping();

            colorMapOverride7.Append(masterColorMapping6);

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
            NonVisualDrawingProperties nonVisualDrawingProperties44 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties9 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties44 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties9.Append(nonVisualDrawingProperties44);
            nonVisualGroupShapeProperties9.Append(nonVisualGroupShapeDrawingProperties9);
            nonVisualGroupShapeProperties9.Append(applicationNonVisualDrawingProperties44);

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

            Shape shape36 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties36 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties45 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Vertical Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties36 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks36 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties36.Append(shapeLocks36);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties45 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape36 = new PlaceholderShape(){ Type = PlaceholderValues.Title, Orientation = DirectionValues.Vertical };

            applicationNonVisualDrawingProperties45.Append(placeholderShape36);

            nonVisualShapeProperties36.Append(nonVisualDrawingProperties45);
            nonVisualShapeProperties36.Append(nonVisualShapeDrawingProperties36);
            nonVisualShapeProperties36.Append(applicationNonVisualDrawingProperties45);

            ShapeProperties shapeProperties36 = new ShapeProperties();

            A.Transform2D transform2D14 = new A.Transform2D();
            A.Offset offset23 = new A.Offset(){ X = 8839200L, Y = 274639L };
            A.Extents extents23 = new A.Extents(){ Cx = 2743200L, Cy = 5851525L };

            transform2D14.Append(offset23);
            transform2D14.Append(extents23);

            shapeProperties36.Append(transform2D14);

            TextBody textBody36 = new TextBody();
            A.BodyProperties bodyProperties36 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.EastAsianVetical };
            A.ListStyle listStyle36 = new A.ListStyle();

            A.Paragraph paragraph48 = new A.Paragraph();

            A.Run run25 = new A.Run();

            A.RunProperties runProperties39 = new A.RunProperties(){ Kumimoji = false, Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties39.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text39 = new A.Text();
            text39.Text = "Click to edit Master title style";

            run25.Append(runProperties39);
            run25.Append(text39);
            A.EndParagraphRunProperties endParagraphRunProperties34 = new A.EndParagraphRunProperties(){ Kumimoji = false, Language = "en-US" };

            paragraph48.Append(run25);
            paragraph48.Append(endParagraphRunProperties34);

            textBody36.Append(bodyProperties36);
            textBody36.Append(listStyle36);
            textBody36.Append(paragraph48);

            shape36.Append(nonVisualShapeProperties36);
            shape36.Append(shapeProperties36);
            shape36.Append(textBody36);

            Shape shape37 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties37 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties46 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Vertical Text Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties37 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks37 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties37.Append(shapeLocks37);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties46 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape37 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Orientation = DirectionValues.Vertical, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties46.Append(placeholderShape37);

            nonVisualShapeProperties37.Append(nonVisualDrawingProperties46);
            nonVisualShapeProperties37.Append(nonVisualShapeDrawingProperties37);
            nonVisualShapeProperties37.Append(applicationNonVisualDrawingProperties46);

            ShapeProperties shapeProperties37 = new ShapeProperties();

            A.Transform2D transform2D15 = new A.Transform2D();
            A.Offset offset24 = new A.Offset(){ X = 609600L, Y = 274639L };
            A.Extents extents24 = new A.Extents(){ Cx = 8026400L, Cy = 5851525L };

            transform2D15.Append(offset24);
            transform2D15.Append(extents24);

            shapeProperties37.Append(transform2D15);

            TextBody textBody37 = new TextBody();
            A.BodyProperties bodyProperties37 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.EastAsianVetical };
            A.ListStyle listStyle37 = new A.ListStyle();

            A.Paragraph paragraph49 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties18 = new A.ParagraphProperties(){ Level = 0, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run26 = new A.Run();

            A.RunProperties runProperties40 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties40.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text40 = new A.Text();
            text40.Text = "Click to edit Master text styles";

            run26.Append(runProperties40);
            run26.Append(text40);

            paragraph49.Append(paragraphProperties18);
            paragraph49.Append(run26);

            A.Paragraph paragraph50 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties19 = new A.ParagraphProperties(){ Level = 1, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run27 = new A.Run();

            A.RunProperties runProperties41 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties41.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text41 = new A.Text();
            text41.Text = "Second level";

            run27.Append(runProperties41);
            run27.Append(text41);

            paragraph50.Append(paragraphProperties19);
            paragraph50.Append(run27);

            A.Paragraph paragraph51 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties20 = new A.ParagraphProperties(){ Level = 2, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run28 = new A.Run();

            A.RunProperties runProperties42 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties42.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text42 = new A.Text();
            text42.Text = "Third level";

            run28.Append(runProperties42);
            run28.Append(text42);

            paragraph51.Append(paragraphProperties20);
            paragraph51.Append(run28);

            A.Paragraph paragraph52 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties21 = new A.ParagraphProperties(){ Level = 3, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run29 = new A.Run();

            A.RunProperties runProperties43 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties43.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text43 = new A.Text();
            text43.Text = "Fourth level";

            run29.Append(runProperties43);
            run29.Append(text43);

            paragraph52.Append(paragraphProperties21);
            paragraph52.Append(run29);

            A.Paragraph paragraph53 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties22 = new A.ParagraphProperties(){ Level = 4, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run30 = new A.Run();

            A.RunProperties runProperties44 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties44.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text44 = new A.Text();
            text44.Text = "Fifth level";

            run30.Append(runProperties44);
            run30.Append(text44);
            A.EndParagraphRunProperties endParagraphRunProperties35 = new A.EndParagraphRunProperties(){ Kumimoji = false, Language = "en-US" };

            paragraph53.Append(paragraphProperties22);
            paragraph53.Append(run30);
            paragraph53.Append(endParagraphRunProperties35);

            textBody37.Append(bodyProperties37);
            textBody37.Append(listStyle37);
            textBody37.Append(paragraph49);
            textBody37.Append(paragraph50);
            textBody37.Append(paragraph51);
            textBody37.Append(paragraph52);
            textBody37.Append(paragraph53);

            shape37.Append(nonVisualShapeProperties37);
            shape37.Append(shapeProperties37);
            shape37.Append(textBody37);

            Shape shape38 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties38 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties47 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Date Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties38 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks38 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties38.Append(shapeLocks38);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties47 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape38 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties47.Append(placeholderShape38);

            nonVisualShapeProperties38.Append(nonVisualDrawingProperties47);
            nonVisualShapeProperties38.Append(nonVisualShapeDrawingProperties38);
            nonVisualShapeProperties38.Append(applicationNonVisualDrawingProperties47);
            ShapeProperties shapeProperties38 = new ShapeProperties();

            TextBody textBody38 = new TextBody();
            A.BodyProperties bodyProperties38 = new A.BodyProperties();
            A.ListStyle listStyle38 = new A.ListStyle();

            A.Paragraph paragraph54 = new A.Paragraph();

            A.Field field15 = new A.Field(){ Id = "{8263865E-5382-4BDD-A09E-2B63F38BCE59}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties45 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties45.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text45 = new A.Text();
            text45.Text = "2012/10/3";

            field15.Append(runProperties45);
            field15.Append(text45);
            A.EndParagraphRunProperties endParagraphRunProperties36 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph54.Append(field15);
            paragraph54.Append(endParagraphRunProperties36);

            textBody38.Append(bodyProperties38);
            textBody38.Append(listStyle38);
            textBody38.Append(paragraph54);

            shape38.Append(nonVisualShapeProperties38);
            shape38.Append(shapeProperties38);
            shape38.Append(textBody38);

            Shape shape39 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties39 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties48 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Footer Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties39 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks39 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties39.Append(shapeLocks39);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties48 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape39 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties48.Append(placeholderShape39);

            nonVisualShapeProperties39.Append(nonVisualDrawingProperties48);
            nonVisualShapeProperties39.Append(nonVisualShapeDrawingProperties39);
            nonVisualShapeProperties39.Append(applicationNonVisualDrawingProperties48);
            ShapeProperties shapeProperties39 = new ShapeProperties();

            TextBody textBody39 = new TextBody();
            A.BodyProperties bodyProperties39 = new A.BodyProperties();
            A.ListStyle listStyle39 = new A.ListStyle();

            A.Paragraph paragraph55 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties37 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph55.Append(endParagraphRunProperties37);

            textBody39.Append(bodyProperties39);
            textBody39.Append(listStyle39);
            textBody39.Append(paragraph55);

            shape39.Append(nonVisualShapeProperties39);
            shape39.Append(shapeProperties39);
            shape39.Append(textBody39);

            Shape shape40 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties40 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties49 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Slide Number Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties40 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks40 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties40.Append(shapeLocks40);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties49 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape40 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties49.Append(placeholderShape40);

            nonVisualShapeProperties40.Append(nonVisualDrawingProperties49);
            nonVisualShapeProperties40.Append(nonVisualShapeDrawingProperties40);
            nonVisualShapeProperties40.Append(applicationNonVisualDrawingProperties49);
            ShapeProperties shapeProperties40 = new ShapeProperties();

            TextBody textBody40 = new TextBody();
            A.BodyProperties bodyProperties40 = new A.BodyProperties();
            A.ListStyle listStyle40 = new A.ListStyle();

            A.Paragraph paragraph56 = new A.Paragraph();

            A.Field field16 = new A.Field(){ Id = "{DF0B8B9E-EDC2-479A-B980-EDD8632819B1}", Type = "slidenum" };

            A.RunProperties runProperties46 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties46.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text46 = new A.Text();
            text46.Text = "‹#›";

            field16.Append(runProperties46);
            field16.Append(text46);
            A.EndParagraphRunProperties endParagraphRunProperties38 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph56.Append(field16);
            paragraph56.Append(endParagraphRunProperties38);

            textBody40.Append(bodyProperties40);
            textBody40.Append(listStyle40);
            textBody40.Append(paragraph56);

            shape40.Append(nonVisualShapeProperties40);
            shape40.Append(shapeProperties40);
            shape40.Append(textBody40);

            shapeTree9.Append(nonVisualGroupShapeProperties9);
            shapeTree9.Append(groupShapeProperties9);
            shapeTree9.Append(shape36);
            shapeTree9.Append(shape37);
            shapeTree9.Append(shape38);
            shapeTree9.Append(shape39);
            shapeTree9.Append(shape40);

            CommonSlideDataExtensionList commonSlideDataExtensionList9 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension9 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId9 = new P14.CreationId(){ Val = (UInt32Value)944580023U };
            creationId9.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension9.Append(creationId9);

            commonSlideDataExtensionList9.Append(commonSlideDataExtension9);

            commonSlideData9.Append(shapeTree9);
            commonSlideData9.Append(commonSlideDataExtensionList9);

            ColorMapOverride colorMapOverride8 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping7 = new A.MasterColorMapping();

            colorMapOverride8.Append(masterColorMapping7);

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
            NonVisualDrawingProperties nonVisualDrawingProperties50 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties10 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties50 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties10.Append(nonVisualDrawingProperties50);
            nonVisualGroupShapeProperties10.Append(nonVisualGroupShapeDrawingProperties10);
            nonVisualGroupShapeProperties10.Append(applicationNonVisualDrawingProperties50);

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

            Shape shape41 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties41 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties51 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties41 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks41 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties41.Append(shapeLocks41);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties51 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape41 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties51.Append(placeholderShape41);

            nonVisualShapeProperties41.Append(nonVisualDrawingProperties51);
            nonVisualShapeProperties41.Append(nonVisualShapeDrawingProperties41);
            nonVisualShapeProperties41.Append(applicationNonVisualDrawingProperties51);

            ShapeProperties shapeProperties41 = new ShapeProperties();

            A.Transform2D transform2D16 = new A.Transform2D();
            A.Offset offset26 = new A.Offset(){ X = 609600L, Y = 273050L };
            A.Extents extents26 = new A.Extents(){ Cx = 10972800L, Cy = 1143000L };

            transform2D16.Append(offset26);
            transform2D16.Append(extents26);

            shapeProperties41.Append(transform2D16);

            TextBody textBody41 = new TextBody();
            A.BodyProperties bodyProperties41 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Center };

            A.ListStyle listStyle41 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties15 = new A.Level1ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties52 = new A.DefaultRunProperties();

            level1ParagraphProperties15.Append(defaultRunProperties52);

            listStyle41.Append(level1ParagraphProperties15);

            A.Paragraph paragraph57 = new A.Paragraph();

            A.Run run31 = new A.Run();

            A.RunProperties runProperties47 = new A.RunProperties(){ Kumimoji = false, Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties47.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text47 = new A.Text();
            text47.Text = "Click to edit Master title style";

            run31.Append(runProperties47);
            run31.Append(text47);
            A.EndParagraphRunProperties endParagraphRunProperties39 = new A.EndParagraphRunProperties(){ Kumimoji = false, Language = "en-US" };

            paragraph57.Append(run31);
            paragraph57.Append(endParagraphRunProperties39);

            textBody41.Append(bodyProperties41);
            textBody41.Append(listStyle41);
            textBody41.Append(paragraph57);

            shape41.Append(nonVisualShapeProperties41);
            shape41.Append(shapeProperties41);
            shape41.Append(textBody41);

            Shape shape42 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties42 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties52 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Text Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties42 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks42 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties42.Append(shapeLocks42);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties52 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape42 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties52.Append(placeholderShape42);

            nonVisualShapeProperties42.Append(nonVisualDrawingProperties52);
            nonVisualShapeProperties42.Append(nonVisualShapeDrawingProperties42);
            nonVisualShapeProperties42.Append(applicationNonVisualDrawingProperties52);

            ShapeProperties shapeProperties42 = new ShapeProperties();

            A.Transform2D transform2D17 = new A.Transform2D();
            A.Offset offset27 = new A.Offset(){ X = 609600L, Y = 1535113L };
            A.Extents extents27 = new A.Extents(){ Cx = 5386917L, Cy = 750887L };

            transform2D17.Append(offset27);
            transform2D17.Append(extents27);

            shapeProperties42.Append(transform2D17);

            TextBody textBody42 = new TextBody();
            A.BodyProperties bodyProperties42 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Center };

            A.ListStyle listStyle42 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties16 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0 };
            A.NoBullet noBullet23 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties53 = new A.DefaultRunProperties(){ FontSize = 2400, Bold = false, Capital = A.TextCapsValues.All, Baseline = 0 };

            A.SolidFill solidFill44 = new A.SolidFill();
            A.SchemeColor schemeColor74 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill44.Append(schemeColor74);

            defaultRunProperties53.Append(solidFill44);

            level1ParagraphProperties16.Append(noBullet23);
            level1ParagraphProperties16.Append(defaultRunProperties53);

            A.Level2ParagraphProperties level2ParagraphProperties8 = new A.Level2ParagraphProperties();
            A.NoBullet noBullet24 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties54 = new A.DefaultRunProperties(){ FontSize = 2000, Bold = true };

            level2ParagraphProperties8.Append(noBullet24);
            level2ParagraphProperties8.Append(defaultRunProperties54);

            A.Level3ParagraphProperties level3ParagraphProperties8 = new A.Level3ParagraphProperties();
            A.NoBullet noBullet25 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties55 = new A.DefaultRunProperties(){ FontSize = 1800, Bold = true };

            level3ParagraphProperties8.Append(noBullet25);
            level3ParagraphProperties8.Append(defaultRunProperties55);

            A.Level4ParagraphProperties level4ParagraphProperties8 = new A.Level4ParagraphProperties();
            A.NoBullet noBullet26 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties56 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level4ParagraphProperties8.Append(noBullet26);
            level4ParagraphProperties8.Append(defaultRunProperties56);

            A.Level5ParagraphProperties level5ParagraphProperties8 = new A.Level5ParagraphProperties();
            A.NoBullet noBullet27 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties57 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level5ParagraphProperties8.Append(noBullet27);
            level5ParagraphProperties8.Append(defaultRunProperties57);

            listStyle42.Append(level1ParagraphProperties16);
            listStyle42.Append(level2ParagraphProperties8);
            listStyle42.Append(level3ParagraphProperties8);
            listStyle42.Append(level4ParagraphProperties8);
            listStyle42.Append(level5ParagraphProperties8);

            A.Paragraph paragraph58 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties23 = new A.ParagraphProperties(){ Level = 0, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run32 = new A.Run();

            A.RunProperties runProperties48 = new A.RunProperties(){ Kumimoji = false, Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties48.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text48 = new A.Text();
            text48.Text = "Click to edit Master text styles";

            run32.Append(runProperties48);
            run32.Append(text48);

            paragraph58.Append(paragraphProperties23);
            paragraph58.Append(run32);

            textBody42.Append(bodyProperties42);
            textBody42.Append(listStyle42);
            textBody42.Append(paragraph58);

            shape42.Append(nonVisualShapeProperties42);
            shape42.Append(shapeProperties42);
            shape42.Append(textBody42);

            Shape shape43 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties43 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties53 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Text Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties43 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks43 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties43.Append(shapeLocks43);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties53 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape43 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)3U };

            applicationNonVisualDrawingProperties53.Append(placeholderShape43);

            nonVisualShapeProperties43.Append(nonVisualDrawingProperties53);
            nonVisualShapeProperties43.Append(nonVisualShapeDrawingProperties43);
            nonVisualShapeProperties43.Append(applicationNonVisualDrawingProperties53);

            ShapeProperties shapeProperties43 = new ShapeProperties();

            A.Transform2D transform2D18 = new A.Transform2D();
            A.Offset offset28 = new A.Offset(){ X = 6193368L, Y = 1535113L };
            A.Extents extents28 = new A.Extents(){ Cx = 5389033L, Cy = 750887L };

            transform2D18.Append(offset28);
            transform2D18.Append(extents28);

            shapeProperties43.Append(transform2D18);

            TextBody textBody43 = new TextBody();
            A.BodyProperties bodyProperties43 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Center };

            A.ListStyle listStyle43 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties17 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0 };
            A.NoBullet noBullet28 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties58 = new A.DefaultRunProperties(){ FontSize = 2400, Bold = false, Capital = A.TextCapsValues.All, Baseline = 0 };

            A.SolidFill solidFill45 = new A.SolidFill();
            A.SchemeColor schemeColor75 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill45.Append(schemeColor75);

            defaultRunProperties58.Append(solidFill45);

            level1ParagraphProperties17.Append(noBullet28);
            level1ParagraphProperties17.Append(defaultRunProperties58);

            A.Level2ParagraphProperties level2ParagraphProperties9 = new A.Level2ParagraphProperties();
            A.NoBullet noBullet29 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties59 = new A.DefaultRunProperties(){ FontSize = 2000, Bold = true };

            level2ParagraphProperties9.Append(noBullet29);
            level2ParagraphProperties9.Append(defaultRunProperties59);

            A.Level3ParagraphProperties level3ParagraphProperties9 = new A.Level3ParagraphProperties();
            A.NoBullet noBullet30 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties60 = new A.DefaultRunProperties(){ FontSize = 1800, Bold = true };

            level3ParagraphProperties9.Append(noBullet30);
            level3ParagraphProperties9.Append(defaultRunProperties60);

            A.Level4ParagraphProperties level4ParagraphProperties9 = new A.Level4ParagraphProperties();
            A.NoBullet noBullet31 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties61 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level4ParagraphProperties9.Append(noBullet31);
            level4ParagraphProperties9.Append(defaultRunProperties61);

            A.Level5ParagraphProperties level5ParagraphProperties9 = new A.Level5ParagraphProperties();
            A.NoBullet noBullet32 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties62 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level5ParagraphProperties9.Append(noBullet32);
            level5ParagraphProperties9.Append(defaultRunProperties62);

            listStyle43.Append(level1ParagraphProperties17);
            listStyle43.Append(level2ParagraphProperties9);
            listStyle43.Append(level3ParagraphProperties9);
            listStyle43.Append(level4ParagraphProperties9);
            listStyle43.Append(level5ParagraphProperties9);

            A.Paragraph paragraph59 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties24 = new A.ParagraphProperties(){ Level = 0, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run33 = new A.Run();

            A.RunProperties runProperties49 = new A.RunProperties(){ Kumimoji = false, Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties49.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text49 = new A.Text();
            text49.Text = "Click to edit Master text styles";

            run33.Append(runProperties49);
            run33.Append(text49);

            paragraph59.Append(paragraphProperties24);
            paragraph59.Append(run33);

            textBody43.Append(bodyProperties43);
            textBody43.Append(listStyle43);
            textBody43.Append(paragraph59);

            shape43.Append(nonVisualShapeProperties43);
            shape43.Append(shapeProperties43);
            shape43.Append(textBody43);

            Shape shape44 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties44 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties54 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Content Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties44 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks44 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties44.Append(shapeLocks44);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties54 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape44 = new PlaceholderShape(){ Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)2U };

            applicationNonVisualDrawingProperties54.Append(placeholderShape44);

            nonVisualShapeProperties44.Append(nonVisualDrawingProperties54);
            nonVisualShapeProperties44.Append(nonVisualShapeDrawingProperties44);
            nonVisualShapeProperties44.Append(applicationNonVisualDrawingProperties54);

            ShapeProperties shapeProperties44 = new ShapeProperties();

            A.Transform2D transform2D19 = new A.Transform2D();
            A.Offset offset29 = new A.Offset(){ X = 609600L, Y = 2362201L };
            A.Extents extents29 = new A.Extents(){ Cx = 5386917L, Cy = 3763963L };

            transform2D19.Append(offset29);
            transform2D19.Append(extents29);

            shapeProperties44.Append(transform2D19);

            TextBody textBody44 = new TextBody();
            A.BodyProperties bodyProperties44 = new A.BodyProperties();

            A.ListStyle listStyle44 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties18 = new A.Level1ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties63 = new A.DefaultRunProperties(){ FontSize = 2400 };

            level1ParagraphProperties18.Append(defaultRunProperties63);

            A.Level2ParagraphProperties level2ParagraphProperties10 = new A.Level2ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties64 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level2ParagraphProperties10.Append(defaultRunProperties64);

            A.Level3ParagraphProperties level3ParagraphProperties10 = new A.Level3ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties65 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level3ParagraphProperties10.Append(defaultRunProperties65);

            A.Level4ParagraphProperties level4ParagraphProperties10 = new A.Level4ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties66 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level4ParagraphProperties10.Append(defaultRunProperties66);

            A.Level5ParagraphProperties level5ParagraphProperties10 = new A.Level5ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties67 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level5ParagraphProperties10.Append(defaultRunProperties67);

            listStyle44.Append(level1ParagraphProperties18);
            listStyle44.Append(level2ParagraphProperties10);
            listStyle44.Append(level3ParagraphProperties10);
            listStyle44.Append(level4ParagraphProperties10);
            listStyle44.Append(level5ParagraphProperties10);

            A.Paragraph paragraph60 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties25 = new A.ParagraphProperties(){ Level = 0, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run34 = new A.Run();

            A.RunProperties runProperties50 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties50.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text50 = new A.Text();
            text50.Text = "Click to edit Master text styles";

            run34.Append(runProperties50);
            run34.Append(text50);

            paragraph60.Append(paragraphProperties25);
            paragraph60.Append(run34);

            A.Paragraph paragraph61 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties26 = new A.ParagraphProperties(){ Level = 1, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run35 = new A.Run();

            A.RunProperties runProperties51 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties51.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text51 = new A.Text();
            text51.Text = "Second level";

            run35.Append(runProperties51);
            run35.Append(text51);

            paragraph61.Append(paragraphProperties26);
            paragraph61.Append(run35);

            A.Paragraph paragraph62 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties27 = new A.ParagraphProperties(){ Level = 2, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run36 = new A.Run();

            A.RunProperties runProperties52 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties52.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text52 = new A.Text();
            text52.Text = "Third level";

            run36.Append(runProperties52);
            run36.Append(text52);

            paragraph62.Append(paragraphProperties27);
            paragraph62.Append(run36);

            A.Paragraph paragraph63 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties28 = new A.ParagraphProperties(){ Level = 3, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run37 = new A.Run();

            A.RunProperties runProperties53 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties53.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text53 = new A.Text();
            text53.Text = "Fourth level";

            run37.Append(runProperties53);
            run37.Append(text53);

            paragraph63.Append(paragraphProperties28);
            paragraph63.Append(run37);

            A.Paragraph paragraph64 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties29 = new A.ParagraphProperties(){ Level = 4, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run38 = new A.Run();

            A.RunProperties runProperties54 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties54.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text54 = new A.Text();
            text54.Text = "Fifth level";

            run38.Append(runProperties54);
            run38.Append(text54);
            A.EndParagraphRunProperties endParagraphRunProperties40 = new A.EndParagraphRunProperties(){ Kumimoji = false, Language = "en-US" };

            paragraph64.Append(paragraphProperties29);
            paragraph64.Append(run38);
            paragraph64.Append(endParagraphRunProperties40);

            textBody44.Append(bodyProperties44);
            textBody44.Append(listStyle44);
            textBody44.Append(paragraph60);
            textBody44.Append(paragraph61);
            textBody44.Append(paragraph62);
            textBody44.Append(paragraph63);
            textBody44.Append(paragraph64);

            shape44.Append(nonVisualShapeProperties44);
            shape44.Append(shapeProperties44);
            shape44.Append(textBody44);

            Shape shape45 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties45 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties55 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Content Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties45 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks45 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties45.Append(shapeLocks45);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties55 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape45 = new PlaceholderShape(){ Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)4U };

            applicationNonVisualDrawingProperties55.Append(placeholderShape45);

            nonVisualShapeProperties45.Append(nonVisualDrawingProperties55);
            nonVisualShapeProperties45.Append(nonVisualShapeDrawingProperties45);
            nonVisualShapeProperties45.Append(applicationNonVisualDrawingProperties55);

            ShapeProperties shapeProperties45 = new ShapeProperties();

            A.Transform2D transform2D20 = new A.Transform2D();
            A.Offset offset30 = new A.Offset(){ X = 6193368L, Y = 2362201L };
            A.Extents extents30 = new A.Extents(){ Cx = 5389033L, Cy = 3763963L };

            transform2D20.Append(offset30);
            transform2D20.Append(extents30);

            shapeProperties45.Append(transform2D20);

            TextBody textBody45 = new TextBody();
            A.BodyProperties bodyProperties45 = new A.BodyProperties();

            A.ListStyle listStyle45 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties19 = new A.Level1ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties68 = new A.DefaultRunProperties(){ FontSize = 2400 };

            level1ParagraphProperties19.Append(defaultRunProperties68);

            A.Level2ParagraphProperties level2ParagraphProperties11 = new A.Level2ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties69 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level2ParagraphProperties11.Append(defaultRunProperties69);

            A.Level3ParagraphProperties level3ParagraphProperties11 = new A.Level3ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties70 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level3ParagraphProperties11.Append(defaultRunProperties70);

            A.Level4ParagraphProperties level4ParagraphProperties11 = new A.Level4ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties71 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level4ParagraphProperties11.Append(defaultRunProperties71);

            A.Level5ParagraphProperties level5ParagraphProperties11 = new A.Level5ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties72 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level5ParagraphProperties11.Append(defaultRunProperties72);

            listStyle45.Append(level1ParagraphProperties19);
            listStyle45.Append(level2ParagraphProperties11);
            listStyle45.Append(level3ParagraphProperties11);
            listStyle45.Append(level4ParagraphProperties11);
            listStyle45.Append(level5ParagraphProperties11);

            A.Paragraph paragraph65 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties30 = new A.ParagraphProperties(){ Level = 0, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run39 = new A.Run();

            A.RunProperties runProperties55 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties55.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text55 = new A.Text();
            text55.Text = "Click to edit Master text styles";

            run39.Append(runProperties55);
            run39.Append(text55);

            paragraph65.Append(paragraphProperties30);
            paragraph65.Append(run39);

            A.Paragraph paragraph66 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties31 = new A.ParagraphProperties(){ Level = 1, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run40 = new A.Run();

            A.RunProperties runProperties56 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties56.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text56 = new A.Text();
            text56.Text = "Second level";

            run40.Append(runProperties56);
            run40.Append(text56);

            paragraph66.Append(paragraphProperties31);
            paragraph66.Append(run40);

            A.Paragraph paragraph67 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties32 = new A.ParagraphProperties(){ Level = 2, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run41 = new A.Run();

            A.RunProperties runProperties57 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties57.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text57 = new A.Text();
            text57.Text = "Third level";

            run41.Append(runProperties57);
            run41.Append(text57);

            paragraph67.Append(paragraphProperties32);
            paragraph67.Append(run41);

            A.Paragraph paragraph68 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties33 = new A.ParagraphProperties(){ Level = 3, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run42 = new A.Run();

            A.RunProperties runProperties58 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties58.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text58 = new A.Text();
            text58.Text = "Fourth level";

            run42.Append(runProperties58);
            run42.Append(text58);

            paragraph68.Append(paragraphProperties33);
            paragraph68.Append(run42);

            A.Paragraph paragraph69 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties34 = new A.ParagraphProperties(){ Level = 4, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run43 = new A.Run();

            A.RunProperties runProperties59 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties59.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text59 = new A.Text();
            text59.Text = "Fifth level";

            run43.Append(runProperties59);
            run43.Append(text59);
            A.EndParagraphRunProperties endParagraphRunProperties41 = new A.EndParagraphRunProperties(){ Kumimoji = false, Language = "en-US" };

            paragraph69.Append(paragraphProperties34);
            paragraph69.Append(run43);
            paragraph69.Append(endParagraphRunProperties41);

            textBody45.Append(bodyProperties45);
            textBody45.Append(listStyle45);
            textBody45.Append(paragraph65);
            textBody45.Append(paragraph66);
            textBody45.Append(paragraph67);
            textBody45.Append(paragraph68);
            textBody45.Append(paragraph69);

            shape45.Append(nonVisualShapeProperties45);
            shape45.Append(shapeProperties45);
            shape45.Append(textBody45);

            Shape shape46 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties46 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties56 = new NonVisualDrawingProperties(){ Id = (UInt32Value)7U, Name = "Date Placeholder 6" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties46 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks46 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties46.Append(shapeLocks46);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties56 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape46 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties56.Append(placeholderShape46);

            nonVisualShapeProperties46.Append(nonVisualDrawingProperties56);
            nonVisualShapeProperties46.Append(nonVisualShapeDrawingProperties46);
            nonVisualShapeProperties46.Append(applicationNonVisualDrawingProperties56);
            ShapeProperties shapeProperties46 = new ShapeProperties();

            TextBody textBody46 = new TextBody();
            A.BodyProperties bodyProperties46 = new A.BodyProperties();
            A.ListStyle listStyle46 = new A.ListStyle();

            A.Paragraph paragraph70 = new A.Paragraph();

            A.Field field17 = new A.Field(){ Id = "{8263865E-5382-4BDD-A09E-2B63F38BCE59}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties60 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties60.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text60 = new A.Text();
            text60.Text = "2012/10/3";

            field17.Append(runProperties60);
            field17.Append(text60);
            A.EndParagraphRunProperties endParagraphRunProperties42 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph70.Append(field17);
            paragraph70.Append(endParagraphRunProperties42);

            textBody46.Append(bodyProperties46);
            textBody46.Append(listStyle46);
            textBody46.Append(paragraph70);

            shape46.Append(nonVisualShapeProperties46);
            shape46.Append(shapeProperties46);
            shape46.Append(textBody46);

            Shape shape47 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties47 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties57 = new NonVisualDrawingProperties(){ Id = (UInt32Value)8U, Name = "Footer Placeholder 7" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties47 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks47 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties47.Append(shapeLocks47);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties57 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape47 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties57.Append(placeholderShape47);

            nonVisualShapeProperties47.Append(nonVisualDrawingProperties57);
            nonVisualShapeProperties47.Append(nonVisualShapeDrawingProperties47);
            nonVisualShapeProperties47.Append(applicationNonVisualDrawingProperties57);
            ShapeProperties shapeProperties47 = new ShapeProperties();

            TextBody textBody47 = new TextBody();
            A.BodyProperties bodyProperties47 = new A.BodyProperties();
            A.ListStyle listStyle47 = new A.ListStyle();

            A.Paragraph paragraph71 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties43 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph71.Append(endParagraphRunProperties43);

            textBody47.Append(bodyProperties47);
            textBody47.Append(listStyle47);
            textBody47.Append(paragraph71);

            shape47.Append(nonVisualShapeProperties47);
            shape47.Append(shapeProperties47);
            shape47.Append(textBody47);

            Shape shape48 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties48 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties58 = new NonVisualDrawingProperties(){ Id = (UInt32Value)9U, Name = "Slide Number Placeholder 8" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties48 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks48 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties48.Append(shapeLocks48);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties58 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape48 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties58.Append(placeholderShape48);

            nonVisualShapeProperties48.Append(nonVisualDrawingProperties58);
            nonVisualShapeProperties48.Append(nonVisualShapeDrawingProperties48);
            nonVisualShapeProperties48.Append(applicationNonVisualDrawingProperties58);
            ShapeProperties shapeProperties48 = new ShapeProperties();

            TextBody textBody48 = new TextBody();
            A.BodyProperties bodyProperties48 = new A.BodyProperties();
            A.ListStyle listStyle48 = new A.ListStyle();

            A.Paragraph paragraph72 = new A.Paragraph();

            A.Field field18 = new A.Field(){ Id = "{DF0B8B9E-EDC2-479A-B980-EDD8632819B1}", Type = "slidenum" };

            A.RunProperties runProperties61 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties61.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text61 = new A.Text();
            text61.Text = "‹#›";

            field18.Append(runProperties61);
            field18.Append(text61);
            A.EndParagraphRunProperties endParagraphRunProperties44 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph72.Append(field18);
            paragraph72.Append(endParagraphRunProperties44);

            textBody48.Append(bodyProperties48);
            textBody48.Append(listStyle48);
            textBody48.Append(paragraph72);

            shape48.Append(nonVisualShapeProperties48);
            shape48.Append(shapeProperties48);
            shape48.Append(textBody48);

            shapeTree10.Append(nonVisualGroupShapeProperties10);
            shapeTree10.Append(groupShapeProperties10);
            shapeTree10.Append(shape41);
            shapeTree10.Append(shape42);
            shapeTree10.Append(shape43);
            shapeTree10.Append(shape44);
            shapeTree10.Append(shape45);
            shapeTree10.Append(shape46);
            shapeTree10.Append(shape47);
            shapeTree10.Append(shape48);

            CommonSlideDataExtensionList commonSlideDataExtensionList10 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension10 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId10 = new P14.CreationId(){ Val = (UInt32Value)1934770651U };
            creationId10.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension10.Append(creationId10);

            commonSlideDataExtensionList10.Append(commonSlideDataExtension10);

            commonSlideData10.Append(shapeTree10);
            commonSlideData10.Append(commonSlideDataExtensionList10);

            ColorMapOverride colorMapOverride9 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping8 = new A.MasterColorMapping();

            colorMapOverride9.Append(masterColorMapping8);

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
            NonVisualDrawingProperties nonVisualDrawingProperties59 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties11 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties59 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties11.Append(nonVisualDrawingProperties59);
            nonVisualGroupShapeProperties11.Append(nonVisualGroupShapeDrawingProperties11);
            nonVisualGroupShapeProperties11.Append(applicationNonVisualDrawingProperties59);

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

            Shape shape49 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties49 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties60 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties49 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks49 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties49.Append(shapeLocks49);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties60 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape49 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties60.Append(placeholderShape49);

            nonVisualShapeProperties49.Append(nonVisualDrawingProperties60);
            nonVisualShapeProperties49.Append(nonVisualShapeDrawingProperties49);
            nonVisualShapeProperties49.Append(applicationNonVisualDrawingProperties60);
            ShapeProperties shapeProperties49 = new ShapeProperties();

            TextBody textBody49 = new TextBody();
            A.BodyProperties bodyProperties49 = new A.BodyProperties();
            A.ListStyle listStyle49 = new A.ListStyle();

            A.Paragraph paragraph73 = new A.Paragraph();

            A.Run run44 = new A.Run();

            A.RunProperties runProperties62 = new A.RunProperties(){ Kumimoji = false, Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties62.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text62 = new A.Text();
            text62.Text = "Click to edit Master title style";

            run44.Append(runProperties62);
            run44.Append(text62);
            A.EndParagraphRunProperties endParagraphRunProperties45 = new A.EndParagraphRunProperties(){ Kumimoji = false, Language = "en-US" };

            paragraph73.Append(run44);
            paragraph73.Append(endParagraphRunProperties45);

            textBody49.Append(bodyProperties49);
            textBody49.Append(listStyle49);
            textBody49.Append(paragraph73);

            shape49.Append(nonVisualShapeProperties49);
            shape49.Append(shapeProperties49);
            shape49.Append(textBody49);

            Shape shape50 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties50 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties61 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Vertical Text Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties50 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks50 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties50.Append(shapeLocks50);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties61 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape50 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Orientation = DirectionValues.Vertical, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties61.Append(placeholderShape50);

            nonVisualShapeProperties50.Append(nonVisualDrawingProperties61);
            nonVisualShapeProperties50.Append(nonVisualShapeDrawingProperties50);
            nonVisualShapeProperties50.Append(applicationNonVisualDrawingProperties61);
            ShapeProperties shapeProperties50 = new ShapeProperties();

            TextBody textBody50 = new TextBody();
            A.BodyProperties bodyProperties50 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.EastAsianVetical };
            A.ListStyle listStyle50 = new A.ListStyle();

            A.Paragraph paragraph74 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties35 = new A.ParagraphProperties(){ Level = 0, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run45 = new A.Run();

            A.RunProperties runProperties63 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties63.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text63 = new A.Text();
            text63.Text = "Click to edit Master text styles";

            run45.Append(runProperties63);
            run45.Append(text63);

            paragraph74.Append(paragraphProperties35);
            paragraph74.Append(run45);

            A.Paragraph paragraph75 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties36 = new A.ParagraphProperties(){ Level = 1, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run46 = new A.Run();

            A.RunProperties runProperties64 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties64.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text64 = new A.Text();
            text64.Text = "Second level";

            run46.Append(runProperties64);
            run46.Append(text64);

            paragraph75.Append(paragraphProperties36);
            paragraph75.Append(run46);

            A.Paragraph paragraph76 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties37 = new A.ParagraphProperties(){ Level = 2, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run47 = new A.Run();

            A.RunProperties runProperties65 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties65.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text65 = new A.Text();
            text65.Text = "Third level";

            run47.Append(runProperties65);
            run47.Append(text65);

            paragraph76.Append(paragraphProperties37);
            paragraph76.Append(run47);

            A.Paragraph paragraph77 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties38 = new A.ParagraphProperties(){ Level = 3, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run48 = new A.Run();

            A.RunProperties runProperties66 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties66.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text66 = new A.Text();
            text66.Text = "Fourth level";

            run48.Append(runProperties66);
            run48.Append(text66);

            paragraph77.Append(paragraphProperties38);
            paragraph77.Append(run48);

            A.Paragraph paragraph78 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties39 = new A.ParagraphProperties(){ Level = 4, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run49 = new A.Run();

            A.RunProperties runProperties67 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties67.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text67 = new A.Text();
            text67.Text = "Fifth level";

            run49.Append(runProperties67);
            run49.Append(text67);
            A.EndParagraphRunProperties endParagraphRunProperties46 = new A.EndParagraphRunProperties(){ Kumimoji = false, Language = "en-US" };

            paragraph78.Append(paragraphProperties39);
            paragraph78.Append(run49);
            paragraph78.Append(endParagraphRunProperties46);

            textBody50.Append(bodyProperties50);
            textBody50.Append(listStyle50);
            textBody50.Append(paragraph74);
            textBody50.Append(paragraph75);
            textBody50.Append(paragraph76);
            textBody50.Append(paragraph77);
            textBody50.Append(paragraph78);

            shape50.Append(nonVisualShapeProperties50);
            shape50.Append(shapeProperties50);
            shape50.Append(textBody50);

            Shape shape51 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties51 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties62 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Date Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties51 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks51 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties51.Append(shapeLocks51);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties62 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape51 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties62.Append(placeholderShape51);

            nonVisualShapeProperties51.Append(nonVisualDrawingProperties62);
            nonVisualShapeProperties51.Append(nonVisualShapeDrawingProperties51);
            nonVisualShapeProperties51.Append(applicationNonVisualDrawingProperties62);
            ShapeProperties shapeProperties51 = new ShapeProperties();

            TextBody textBody51 = new TextBody();
            A.BodyProperties bodyProperties51 = new A.BodyProperties();
            A.ListStyle listStyle51 = new A.ListStyle();

            A.Paragraph paragraph79 = new A.Paragraph();

            A.Field field19 = new A.Field(){ Id = "{8263865E-5382-4BDD-A09E-2B63F38BCE59}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties68 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties68.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text68 = new A.Text();
            text68.Text = "2012/10/3";

            field19.Append(runProperties68);
            field19.Append(text68);
            A.EndParagraphRunProperties endParagraphRunProperties47 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph79.Append(field19);
            paragraph79.Append(endParagraphRunProperties47);

            textBody51.Append(bodyProperties51);
            textBody51.Append(listStyle51);
            textBody51.Append(paragraph79);

            shape51.Append(nonVisualShapeProperties51);
            shape51.Append(shapeProperties51);
            shape51.Append(textBody51);

            Shape shape52 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties52 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties63 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Footer Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties52 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks52 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties52.Append(shapeLocks52);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties63 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape52 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties63.Append(placeholderShape52);

            nonVisualShapeProperties52.Append(nonVisualDrawingProperties63);
            nonVisualShapeProperties52.Append(nonVisualShapeDrawingProperties52);
            nonVisualShapeProperties52.Append(applicationNonVisualDrawingProperties63);
            ShapeProperties shapeProperties52 = new ShapeProperties();

            TextBody textBody52 = new TextBody();
            A.BodyProperties bodyProperties52 = new A.BodyProperties();
            A.ListStyle listStyle52 = new A.ListStyle();

            A.Paragraph paragraph80 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties48 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph80.Append(endParagraphRunProperties48);

            textBody52.Append(bodyProperties52);
            textBody52.Append(listStyle52);
            textBody52.Append(paragraph80);

            shape52.Append(nonVisualShapeProperties52);
            shape52.Append(shapeProperties52);
            shape52.Append(textBody52);

            Shape shape53 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties53 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties64 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Slide Number Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties53 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks53 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties53.Append(shapeLocks53);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties64 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape53 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties64.Append(placeholderShape53);

            nonVisualShapeProperties53.Append(nonVisualDrawingProperties64);
            nonVisualShapeProperties53.Append(nonVisualShapeDrawingProperties53);
            nonVisualShapeProperties53.Append(applicationNonVisualDrawingProperties64);
            ShapeProperties shapeProperties53 = new ShapeProperties();

            TextBody textBody53 = new TextBody();
            A.BodyProperties bodyProperties53 = new A.BodyProperties();
            A.ListStyle listStyle53 = new A.ListStyle();

            A.Paragraph paragraph81 = new A.Paragraph();

            A.Field field20 = new A.Field(){ Id = "{DF0B8B9E-EDC2-479A-B980-EDD8632819B1}", Type = "slidenum" };

            A.RunProperties runProperties69 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties69.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text69 = new A.Text();
            text69.Text = "‹#›";

            field20.Append(runProperties69);
            field20.Append(text69);
            A.EndParagraphRunProperties endParagraphRunProperties49 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph81.Append(field20);
            paragraph81.Append(endParagraphRunProperties49);

            textBody53.Append(bodyProperties53);
            textBody53.Append(listStyle53);
            textBody53.Append(paragraph81);

            shape53.Append(nonVisualShapeProperties53);
            shape53.Append(shapeProperties53);
            shape53.Append(textBody53);

            shapeTree11.Append(nonVisualGroupShapeProperties11);
            shapeTree11.Append(groupShapeProperties11);
            shapeTree11.Append(shape49);
            shapeTree11.Append(shape50);
            shapeTree11.Append(shape51);
            shapeTree11.Append(shape52);
            shapeTree11.Append(shape53);

            CommonSlideDataExtensionList commonSlideDataExtensionList11 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension11 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId11 = new P14.CreationId(){ Val = (UInt32Value)1297641645U };
            creationId11.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension11.Append(creationId11);

            commonSlideDataExtensionList11.Append(commonSlideDataExtension11);

            commonSlideData11.Append(shapeTree11);
            commonSlideData11.Append(commonSlideDataExtensionList11);

            ColorMapOverride colorMapOverride10 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping9 = new A.MasterColorMapping();

            colorMapOverride10.Append(masterColorMapping9);

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
            NonVisualDrawingProperties nonVisualDrawingProperties65 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties12 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties65 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties12.Append(nonVisualDrawingProperties65);
            nonVisualGroupShapeProperties12.Append(nonVisualGroupShapeDrawingProperties12);
            nonVisualGroupShapeProperties12.Append(applicationNonVisualDrawingProperties65);

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

            Shape shape54 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties54 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties66 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties54 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks54 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties54.Append(shapeLocks54);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties66 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape54 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties66.Append(placeholderShape54);

            nonVisualShapeProperties54.Append(nonVisualDrawingProperties66);
            nonVisualShapeProperties54.Append(nonVisualShapeDrawingProperties54);
            nonVisualShapeProperties54.Append(applicationNonVisualDrawingProperties66);
            ShapeProperties shapeProperties54 = new ShapeProperties();

            TextBody textBody54 = new TextBody();
            A.BodyProperties bodyProperties54 = new A.BodyProperties();
            A.ListStyle listStyle54 = new A.ListStyle();

            A.Paragraph paragraph82 = new A.Paragraph();

            A.Run run50 = new A.Run();

            A.RunProperties runProperties70 = new A.RunProperties(){ Kumimoji = false, Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties70.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text70 = new A.Text();
            text70.Text = "Click to edit Master title style";

            run50.Append(runProperties70);
            run50.Append(text70);
            A.EndParagraphRunProperties endParagraphRunProperties50 = new A.EndParagraphRunProperties(){ Kumimoji = false, Language = "en-US" };

            paragraph82.Append(run50);
            paragraph82.Append(endParagraphRunProperties50);

            textBody54.Append(bodyProperties54);
            textBody54.Append(listStyle54);
            textBody54.Append(paragraph82);

            shape54.Append(nonVisualShapeProperties54);
            shape54.Append(shapeProperties54);
            shape54.Append(textBody54);

            Shape shape55 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties55 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties67 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Content Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties55 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks55 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties55.Append(shapeLocks55);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties67 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape55 = new PlaceholderShape(){ Size = PlaceholderSizeValues.Half, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties67.Append(placeholderShape55);

            nonVisualShapeProperties55.Append(nonVisualDrawingProperties67);
            nonVisualShapeProperties55.Append(nonVisualShapeDrawingProperties55);
            nonVisualShapeProperties55.Append(applicationNonVisualDrawingProperties67);

            ShapeProperties shapeProperties55 = new ShapeProperties();

            A.Transform2D transform2D21 = new A.Transform2D();
            A.Offset offset33 = new A.Offset(){ X = 609600L, Y = 1600201L };
            A.Extents extents33 = new A.Extents(){ Cx = 5384800L, Cy = 4525963L };

            transform2D21.Append(offset33);
            transform2D21.Append(extents33);

            shapeProperties55.Append(transform2D21);

            TextBody textBody55 = new TextBody();
            A.BodyProperties bodyProperties55 = new A.BodyProperties();

            A.ListStyle listStyle55 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties20 = new A.Level1ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties73 = new A.DefaultRunProperties(){ FontSize = 2600 };

            level1ParagraphProperties20.Append(defaultRunProperties73);

            A.Level2ParagraphProperties level2ParagraphProperties12 = new A.Level2ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties74 = new A.DefaultRunProperties(){ FontSize = 2400 };

            level2ParagraphProperties12.Append(defaultRunProperties74);

            A.Level3ParagraphProperties level3ParagraphProperties12 = new A.Level3ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties75 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level3ParagraphProperties12.Append(defaultRunProperties75);

            A.Level4ParagraphProperties level4ParagraphProperties12 = new A.Level4ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties76 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level4ParagraphProperties12.Append(defaultRunProperties76);

            A.Level5ParagraphProperties level5ParagraphProperties12 = new A.Level5ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties77 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level5ParagraphProperties12.Append(defaultRunProperties77);

            listStyle55.Append(level1ParagraphProperties20);
            listStyle55.Append(level2ParagraphProperties12);
            listStyle55.Append(level3ParagraphProperties12);
            listStyle55.Append(level4ParagraphProperties12);
            listStyle55.Append(level5ParagraphProperties12);

            A.Paragraph paragraph83 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties40 = new A.ParagraphProperties(){ Level = 0, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run51 = new A.Run();

            A.RunProperties runProperties71 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties71.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text71 = new A.Text();
            text71.Text = "Click to edit Master text styles";

            run51.Append(runProperties71);
            run51.Append(text71);

            paragraph83.Append(paragraphProperties40);
            paragraph83.Append(run51);

            A.Paragraph paragraph84 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties41 = new A.ParagraphProperties(){ Level = 1, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run52 = new A.Run();

            A.RunProperties runProperties72 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties72.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text72 = new A.Text();
            text72.Text = "Second level";

            run52.Append(runProperties72);
            run52.Append(text72);

            paragraph84.Append(paragraphProperties41);
            paragraph84.Append(run52);

            A.Paragraph paragraph85 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties42 = new A.ParagraphProperties(){ Level = 2, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run53 = new A.Run();

            A.RunProperties runProperties73 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties73.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text73 = new A.Text();
            text73.Text = "Third level";

            run53.Append(runProperties73);
            run53.Append(text73);

            paragraph85.Append(paragraphProperties42);
            paragraph85.Append(run53);

            A.Paragraph paragraph86 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties43 = new A.ParagraphProperties(){ Level = 3, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run54 = new A.Run();

            A.RunProperties runProperties74 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties74.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text74 = new A.Text();
            text74.Text = "Fourth level";

            run54.Append(runProperties74);
            run54.Append(text74);

            paragraph86.Append(paragraphProperties43);
            paragraph86.Append(run54);

            A.Paragraph paragraph87 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties44 = new A.ParagraphProperties(){ Level = 4, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run55 = new A.Run();

            A.RunProperties runProperties75 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties75.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text75 = new A.Text();
            text75.Text = "Fifth level";

            run55.Append(runProperties75);
            run55.Append(text75);
            A.EndParagraphRunProperties endParagraphRunProperties51 = new A.EndParagraphRunProperties(){ Kumimoji = false, Language = "en-US" };

            paragraph87.Append(paragraphProperties44);
            paragraph87.Append(run55);
            paragraph87.Append(endParagraphRunProperties51);

            textBody55.Append(bodyProperties55);
            textBody55.Append(listStyle55);
            textBody55.Append(paragraph83);
            textBody55.Append(paragraph84);
            textBody55.Append(paragraph85);
            textBody55.Append(paragraph86);
            textBody55.Append(paragraph87);

            shape55.Append(nonVisualShapeProperties55);
            shape55.Append(shapeProperties55);
            shape55.Append(textBody55);

            Shape shape56 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties56 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties68 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Content Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties56 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks56 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties56.Append(shapeLocks56);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties68 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape56 = new PlaceholderShape(){ Size = PlaceholderSizeValues.Half, Index = (UInt32Value)2U };

            applicationNonVisualDrawingProperties68.Append(placeholderShape56);

            nonVisualShapeProperties56.Append(nonVisualDrawingProperties68);
            nonVisualShapeProperties56.Append(nonVisualShapeDrawingProperties56);
            nonVisualShapeProperties56.Append(applicationNonVisualDrawingProperties68);

            ShapeProperties shapeProperties56 = new ShapeProperties();

            A.Transform2D transform2D22 = new A.Transform2D();
            A.Offset offset34 = new A.Offset(){ X = 6197600L, Y = 1600201L };
            A.Extents extents34 = new A.Extents(){ Cx = 5384800L, Cy = 4525963L };

            transform2D22.Append(offset34);
            transform2D22.Append(extents34);

            shapeProperties56.Append(transform2D22);

            TextBody textBody56 = new TextBody();
            A.BodyProperties bodyProperties56 = new A.BodyProperties();

            A.ListStyle listStyle56 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties21 = new A.Level1ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties78 = new A.DefaultRunProperties(){ FontSize = 2600 };

            level1ParagraphProperties21.Append(defaultRunProperties78);

            A.Level2ParagraphProperties level2ParagraphProperties13 = new A.Level2ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties79 = new A.DefaultRunProperties(){ FontSize = 2400 };

            level2ParagraphProperties13.Append(defaultRunProperties79);

            A.Level3ParagraphProperties level3ParagraphProperties13 = new A.Level3ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties80 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level3ParagraphProperties13.Append(defaultRunProperties80);

            A.Level4ParagraphProperties level4ParagraphProperties13 = new A.Level4ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties81 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level4ParagraphProperties13.Append(defaultRunProperties81);

            A.Level5ParagraphProperties level5ParagraphProperties13 = new A.Level5ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties82 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level5ParagraphProperties13.Append(defaultRunProperties82);

            listStyle56.Append(level1ParagraphProperties21);
            listStyle56.Append(level2ParagraphProperties13);
            listStyle56.Append(level3ParagraphProperties13);
            listStyle56.Append(level4ParagraphProperties13);
            listStyle56.Append(level5ParagraphProperties13);

            A.Paragraph paragraph88 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties45 = new A.ParagraphProperties(){ Level = 0, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run56 = new A.Run();

            A.RunProperties runProperties76 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties76.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text76 = new A.Text();
            text76.Text = "Click to edit Master text styles";

            run56.Append(runProperties76);
            run56.Append(text76);

            paragraph88.Append(paragraphProperties45);
            paragraph88.Append(run56);

            A.Paragraph paragraph89 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties46 = new A.ParagraphProperties(){ Level = 1, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run57 = new A.Run();

            A.RunProperties runProperties77 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties77.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text77 = new A.Text();
            text77.Text = "Second level";

            run57.Append(runProperties77);
            run57.Append(text77);

            paragraph89.Append(paragraphProperties46);
            paragraph89.Append(run57);

            A.Paragraph paragraph90 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties47 = new A.ParagraphProperties(){ Level = 2, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run58 = new A.Run();

            A.RunProperties runProperties78 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties78.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text78 = new A.Text();
            text78.Text = "Third level";

            run58.Append(runProperties78);
            run58.Append(text78);

            paragraph90.Append(paragraphProperties47);
            paragraph90.Append(run58);

            A.Paragraph paragraph91 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties48 = new A.ParagraphProperties(){ Level = 3, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run59 = new A.Run();

            A.RunProperties runProperties79 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties79.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text79 = new A.Text();
            text79.Text = "Fourth level";

            run59.Append(runProperties79);
            run59.Append(text79);

            paragraph91.Append(paragraphProperties48);
            paragraph91.Append(run59);

            A.Paragraph paragraph92 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties49 = new A.ParagraphProperties(){ Level = 4, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run60 = new A.Run();

            A.RunProperties runProperties80 = new A.RunProperties(){ Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties80.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text80 = new A.Text();
            text80.Text = "Fifth level";

            run60.Append(runProperties80);
            run60.Append(text80);
            A.EndParagraphRunProperties endParagraphRunProperties52 = new A.EndParagraphRunProperties(){ Kumimoji = false, Language = "en-US" };

            paragraph92.Append(paragraphProperties49);
            paragraph92.Append(run60);
            paragraph92.Append(endParagraphRunProperties52);

            textBody56.Append(bodyProperties56);
            textBody56.Append(listStyle56);
            textBody56.Append(paragraph88);
            textBody56.Append(paragraph89);
            textBody56.Append(paragraph90);
            textBody56.Append(paragraph91);
            textBody56.Append(paragraph92);

            shape56.Append(nonVisualShapeProperties56);
            shape56.Append(shapeProperties56);
            shape56.Append(textBody56);

            Shape shape57 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties57 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties69 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Date Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties57 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks57 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties57.Append(shapeLocks57);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties69 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape57 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties69.Append(placeholderShape57);

            nonVisualShapeProperties57.Append(nonVisualDrawingProperties69);
            nonVisualShapeProperties57.Append(nonVisualShapeDrawingProperties57);
            nonVisualShapeProperties57.Append(applicationNonVisualDrawingProperties69);
            ShapeProperties shapeProperties57 = new ShapeProperties();

            TextBody textBody57 = new TextBody();
            A.BodyProperties bodyProperties57 = new A.BodyProperties();
            A.ListStyle listStyle57 = new A.ListStyle();

            A.Paragraph paragraph93 = new A.Paragraph();

            A.Field field21 = new A.Field(){ Id = "{8263865E-5382-4BDD-A09E-2B63F38BCE59}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties81 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties81.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text81 = new A.Text();
            text81.Text = "2012/10/3";

            field21.Append(runProperties81);
            field21.Append(text81);
            A.EndParagraphRunProperties endParagraphRunProperties53 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph93.Append(field21);
            paragraph93.Append(endParagraphRunProperties53);

            textBody57.Append(bodyProperties57);
            textBody57.Append(listStyle57);
            textBody57.Append(paragraph93);

            shape57.Append(nonVisualShapeProperties57);
            shape57.Append(shapeProperties57);
            shape57.Append(textBody57);

            Shape shape58 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties58 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties70 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Footer Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties58 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks58 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties58.Append(shapeLocks58);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties70 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape58 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties70.Append(placeholderShape58);

            nonVisualShapeProperties58.Append(nonVisualDrawingProperties70);
            nonVisualShapeProperties58.Append(nonVisualShapeDrawingProperties58);
            nonVisualShapeProperties58.Append(applicationNonVisualDrawingProperties70);
            ShapeProperties shapeProperties58 = new ShapeProperties();

            TextBody textBody58 = new TextBody();
            A.BodyProperties bodyProperties58 = new A.BodyProperties();
            A.ListStyle listStyle58 = new A.ListStyle();

            A.Paragraph paragraph94 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties54 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph94.Append(endParagraphRunProperties54);

            textBody58.Append(bodyProperties58);
            textBody58.Append(listStyle58);
            textBody58.Append(paragraph94);

            shape58.Append(nonVisualShapeProperties58);
            shape58.Append(shapeProperties58);
            shape58.Append(textBody58);

            Shape shape59 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties59 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties71 = new NonVisualDrawingProperties(){ Id = (UInt32Value)7U, Name = "Slide Number Placeholder 6" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties59 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks59 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties59.Append(shapeLocks59);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties71 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape59 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties71.Append(placeholderShape59);

            nonVisualShapeProperties59.Append(nonVisualDrawingProperties71);
            nonVisualShapeProperties59.Append(nonVisualShapeDrawingProperties59);
            nonVisualShapeProperties59.Append(applicationNonVisualDrawingProperties71);
            ShapeProperties shapeProperties59 = new ShapeProperties();

            TextBody textBody59 = new TextBody();
            A.BodyProperties bodyProperties59 = new A.BodyProperties();
            A.ListStyle listStyle59 = new A.ListStyle();

            A.Paragraph paragraph95 = new A.Paragraph();

            A.Field field22 = new A.Field(){ Id = "{DF0B8B9E-EDC2-479A-B980-EDD8632819B1}", Type = "slidenum" };

            A.RunProperties runProperties82 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties82.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text82 = new A.Text();
            text82.Text = "‹#›";

            field22.Append(runProperties82);
            field22.Append(text82);
            A.EndParagraphRunProperties endParagraphRunProperties55 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph95.Append(field22);
            paragraph95.Append(endParagraphRunProperties55);

            textBody59.Append(bodyProperties59);
            textBody59.Append(listStyle59);
            textBody59.Append(paragraph95);

            shape59.Append(nonVisualShapeProperties59);
            shape59.Append(shapeProperties59);
            shape59.Append(textBody59);

            shapeTree12.Append(nonVisualGroupShapeProperties12);
            shapeTree12.Append(groupShapeProperties12);
            shapeTree12.Append(shape54);
            shapeTree12.Append(shape55);
            shapeTree12.Append(shape56);
            shapeTree12.Append(shape57);
            shapeTree12.Append(shape58);
            shapeTree12.Append(shape59);

            CommonSlideDataExtensionList commonSlideDataExtensionList12 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension12 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId12 = new P14.CreationId(){ Val = (UInt32Value)3688300528U };
            creationId12.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension12.Append(creationId12);

            commonSlideDataExtensionList12.Append(commonSlideDataExtension12);

            commonSlideData12.Append(shapeTree12);
            commonSlideData12.Append(commonSlideDataExtensionList12);

            ColorMapOverride colorMapOverride11 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping10 = new A.MasterColorMapping();

            colorMapOverride11.Append(masterColorMapping10);

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
            NonVisualDrawingProperties nonVisualDrawingProperties72 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties13 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties72 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties13.Append(nonVisualDrawingProperties72);
            nonVisualGroupShapeProperties13.Append(nonVisualGroupShapeDrawingProperties13);
            nonVisualGroupShapeProperties13.Append(applicationNonVisualDrawingProperties72);

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

            Shape shape60 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties60 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties73 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties60 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks60 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties60.Append(shapeLocks60);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties73 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape60 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties73.Append(placeholderShape60);

            nonVisualShapeProperties60.Append(nonVisualDrawingProperties73);
            nonVisualShapeProperties60.Append(nonVisualShapeDrawingProperties60);
            nonVisualShapeProperties60.Append(applicationNonVisualDrawingProperties73);

            ShapeProperties shapeProperties60 = new ShapeProperties();

            A.Transform2D transform2D23 = new A.Transform2D();
            A.Offset offset36 = new A.Offset(){ X = 2438400L, Y = 609600L };
            A.Extents extents36 = new A.Extents(){ Cx = 7315200L, Cy = 522288L };

            transform2D23.Append(offset36);
            transform2D23.Append(extents36);

            shapeProperties60.Append(transform2D23);

            TextBody textBody60 = new TextBody();

            A.BodyProperties bodyProperties60 = new A.BodyProperties(){ LeftInset = 45720, RightInset = 45720, BottomInset = 0, Anchor = A.TextAnchoringTypeValues.Bottom };
            A.Shape3DType shape3DType6 = new A.Shape3DType(){ PresetMaterial = A.PresetMaterialTypeValues.SoftEdge };

            bodyProperties60.Append(shape3DType6);

            A.ListStyle listStyle60 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties22 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet33 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties83 = new A.DefaultRunProperties(){ FontSize = 2000, Bold = true };

            level1ParagraphProperties22.Append(noBullet33);
            level1ParagraphProperties22.Append(defaultRunProperties83);

            listStyle60.Append(level1ParagraphProperties22);

            A.Paragraph paragraph96 = new A.Paragraph();

            A.Run run61 = new A.Run();

            A.RunProperties runProperties83 = new A.RunProperties(){ Kumimoji = false, Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties83.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text83 = new A.Text();
            text83.Text = "Click to edit Master title style";

            run61.Append(runProperties83);
            run61.Append(text83);
            A.EndParagraphRunProperties endParagraphRunProperties56 = new A.EndParagraphRunProperties(){ Kumimoji = false, Language = "en-US" };

            paragraph96.Append(run61);
            paragraph96.Append(endParagraphRunProperties56);

            textBody60.Append(bodyProperties60);
            textBody60.Append(listStyle60);
            textBody60.Append(paragraph96);

            shape60.Append(nonVisualShapeProperties60);
            shape60.Append(shapeProperties60);
            shape60.Append(textBody60);

            Shape shape61 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties61 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties74 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Picture Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties61 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks61 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties61.Append(shapeLocks61);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties74 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape61 = new PlaceholderShape(){ Type = PlaceholderValues.Picture, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties74.Append(placeholderShape61);

            nonVisualShapeProperties61.Append(nonVisualDrawingProperties74);
            nonVisualShapeProperties61.Append(nonVisualShapeDrawingProperties61);
            nonVisualShapeProperties61.Append(applicationNonVisualDrawingProperties74);

            ShapeProperties shapeProperties61 = new ShapeProperties();

            A.Transform2D transform2D24 = new A.Transform2D();
            A.Offset offset37 = new A.Offset(){ X = 2438400L, Y = 1831975L };
            A.Extents extents37 = new A.Extents(){ Cx = 7315200L, Cy = 3962400L };

            transform2D24.Append(offset37);
            transform2D24.Append(extents37);

            A.SolidFill solidFill46 = new A.SolidFill();
            A.SchemeColor schemeColor76 = new A.SchemeColor(){ Val = A.SchemeColorValues.Background2 };

            solidFill46.Append(schemeColor76);

            A.Outline outline8 = new A.Outline(){ Width = 44450, CapType = A.LineCapValues.Square, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill47 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex17 = new A.RgbColorModelHex(){ Val = "FFFFFF" };

            solidFill47.Append(rgbColorModelHex17);
            A.PresetDash presetDash4 = new A.PresetDash(){ Val = A.PresetLineDashValues.Solid };
            A.Miter miter1 = new A.Miter(){ Limit = 800000 };

            outline8.Append(solidFill47);
            outline8.Append(presetDash4);
            outline8.Append(miter1);

            A.EffectList effectList7 = new A.EffectList();

            A.OuterShadow outerShadow7 = new A.OuterShadow(){ BlurRadius = 190500L, Distance = 228600L, Direction = 2700000, VerticalRatio = 90000 };

            A.RgbColorModelHex rgbColorModelHex18 = new A.RgbColorModelHex(){ Val = "000000" };
            A.Alpha alpha7 = new A.Alpha(){ Val = 25000 };

            rgbColorModelHex18.Append(alpha7);

            outerShadow7.Append(rgbColorModelHex18);

            effectList7.Append(outerShadow7);

            A.Scene3DType scene3DType5 = new A.Scene3DType();

            A.Camera camera5 = new A.Camera(){ Preset = A.PresetCameraValues.OrthographicFront };
            A.Rotation rotation6 = new A.Rotation(){ Latitude = 0, Longitude = 0, Revolution = 0 };

            camera5.Append(rotation6);

            A.LightRig lightRig5 = new A.LightRig(){ Rig = A.LightRigValues.Balanced, Direction = A.LightRigDirectionValues.TopRight };
            A.Rotation rotation7 = new A.Rotation(){ Latitude = 0, Longitude = 0, Revolution = 2700000 };

            lightRig5.Append(rotation7);

            scene3DType5.Append(camera5);
            scene3DType5.Append(lightRig5);

            A.Shape3DType shape3DType7 = new A.Shape3DType(){ PresetMaterial = A.PresetMaterialTypeValues.Matte };

            A.ContourColor contourColor2 = new A.ContourColor();

            A.SchemeColor schemeColor77 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text2 };
            A.Shade shade11 = new A.Shade(){ Val = 50000 };

            schemeColor77.Append(shade11);

            contourColor2.Append(schemeColor77);

            shape3DType7.Append(contourColor2);

            shapeProperties61.Append(transform2D24);
            shapeProperties61.Append(solidFill46);
            shapeProperties61.Append(outline8);
            shapeProperties61.Append(effectList7);
            shapeProperties61.Append(scene3DType5);
            shapeProperties61.Append(shape3DType7);

            ShapeStyle shapeStyle1 = new ShapeStyle();

            A.LineReference lineReference1 = new A.LineReference(){ Index = (UInt32Value)3U };
            A.SchemeColor schemeColor78 = new A.SchemeColor(){ Val = A.SchemeColorValues.Light1 };

            lineReference1.Append(schemeColor78);

            A.FillReference fillReference1 = new A.FillReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor79 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            fillReference1.Append(schemeColor79);

            A.EffectReference effectReference1 = new A.EffectReference(){ Index = (UInt32Value)1U };
            A.SchemeColor schemeColor80 = new A.SchemeColor(){ Val = A.SchemeColorValues.Accent1 };

            effectReference1.Append(schemeColor80);

            A.FontReference fontReference1 = new A.FontReference(){ Index = A.FontCollectionIndexValues.Minor };
            A.SchemeColor schemeColor81 = new A.SchemeColor(){ Val = A.SchemeColorValues.Light1 };

            fontReference1.Append(schemeColor81);

            shapeStyle1.Append(lineReference1);
            shapeStyle1.Append(fillReference1);
            shapeStyle1.Append(effectReference1);
            shapeStyle1.Append(fontReference1);

            TextBody textBody61 = new TextBody();
            A.BodyProperties bodyProperties61 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Top };

            A.ListStyle listStyle61 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties23 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };
            A.NoBullet noBullet34 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties84 = new A.DefaultRunProperties(){ FontSize = 3200 };

            level1ParagraphProperties23.Append(noBullet34);
            level1ParagraphProperties23.Append(defaultRunProperties84);

            listStyle61.Append(level1ParagraphProperties23);

            A.Paragraph paragraph97 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties50 = new A.ParagraphProperties(){ LeftMargin = 0, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run62 = new A.Run();

            A.RunProperties runProperties84 = new A.RunProperties(){ Kumimoji = false, Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties84.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));

            A.SolidFill solidFill48 = new A.SolidFill();
            A.SchemeColor schemeColor82 = new A.SchemeColor(){ Val = A.SchemeColorValues.Light1 };

            solidFill48.Append(schemeColor82);
            A.LatinFont latinFont32 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont32 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont32 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            runProperties84.Append(solidFill48);
            runProperties84.Append(latinFont32);
            runProperties84.Append(eastAsianFont32);
            runProperties84.Append(complexScriptFont32);
            A.Text text84 = new A.Text();
            text84.Text = "Click icon to add picture";

            run62.Append(runProperties84);
            run62.Append(text84);

            A.EndParagraphRunProperties endParagraphRunProperties57 = new A.EndParagraphRunProperties(){ Kumimoji = false, Language = "en-US", Dirty = false };

            A.SolidFill solidFill49 = new A.SolidFill();
            A.SchemeColor schemeColor83 = new A.SchemeColor(){ Val = A.SchemeColorValues.Light1 };

            solidFill49.Append(schemeColor83);
            A.LatinFont latinFont33 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont33 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont33 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            endParagraphRunProperties57.Append(solidFill49);
            endParagraphRunProperties57.Append(latinFont33);
            endParagraphRunProperties57.Append(eastAsianFont33);
            endParagraphRunProperties57.Append(complexScriptFont33);

            paragraph97.Append(paragraphProperties50);
            paragraph97.Append(run62);
            paragraph97.Append(endParagraphRunProperties57);

            textBody61.Append(bodyProperties61);
            textBody61.Append(listStyle61);
            textBody61.Append(paragraph97);

            shape61.Append(nonVisualShapeProperties61);
            shape61.Append(shapeProperties61);
            shape61.Append(shapeStyle1);
            shape61.Append(textBody61);

            Shape shape62 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties62 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties75 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Text Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties62 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks62 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties62.Append(shapeLocks62);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties75 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape62 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)2U };

            applicationNonVisualDrawingProperties75.Append(placeholderShape62);

            nonVisualShapeProperties62.Append(nonVisualDrawingProperties75);
            nonVisualShapeProperties62.Append(nonVisualShapeDrawingProperties62);
            nonVisualShapeProperties62.Append(applicationNonVisualDrawingProperties75);

            ShapeProperties shapeProperties62 = new ShapeProperties();

            A.Transform2D transform2D25 = new A.Transform2D();
            A.Offset offset38 = new A.Offset(){ X = 2438400L, Y = 1166787L };
            A.Extents extents38 = new A.Extents(){ Cx = 7315200L, Cy = 530352L };

            transform2D25.Append(offset38);
            transform2D25.Append(extents38);

            shapeProperties62.Append(transform2D25);

            TextBody textBody62 = new TextBody();
            A.BodyProperties bodyProperties62 = new A.BodyProperties(){ LeftInset = 45720, TopInset = 45720, RightInset = 45720, Anchor = A.TextAnchoringTypeValues.Top };

            A.ListStyle listStyle62 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties24 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet35 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties85 = new A.DefaultRunProperties(){ FontSize = 1400 };

            level1ParagraphProperties24.Append(noBullet35);
            level1ParagraphProperties24.Append(defaultRunProperties85);

            A.Level2ParagraphProperties level2ParagraphProperties14 = new A.Level2ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties86 = new A.DefaultRunProperties(){ FontSize = 1200 };

            level2ParagraphProperties14.Append(defaultRunProperties86);

            A.Level3ParagraphProperties level3ParagraphProperties14 = new A.Level3ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties87 = new A.DefaultRunProperties(){ FontSize = 1000 };

            level3ParagraphProperties14.Append(defaultRunProperties87);

            A.Level4ParagraphProperties level4ParagraphProperties14 = new A.Level4ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties88 = new A.DefaultRunProperties(){ FontSize = 900 };

            level4ParagraphProperties14.Append(defaultRunProperties88);

            A.Level5ParagraphProperties level5ParagraphProperties14 = new A.Level5ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties89 = new A.DefaultRunProperties(){ FontSize = 900 };

            level5ParagraphProperties14.Append(defaultRunProperties89);

            listStyle62.Append(level1ParagraphProperties24);
            listStyle62.Append(level2ParagraphProperties14);
            listStyle62.Append(level3ParagraphProperties14);
            listStyle62.Append(level4ParagraphProperties14);
            listStyle62.Append(level5ParagraphProperties14);

            A.Paragraph paragraph98 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties51 = new A.ParagraphProperties(){ Level = 0, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.Run run63 = new A.Run();

            A.RunProperties runProperties85 = new A.RunProperties(){ Kumimoji = false, Language = "en-US", AlternativeLanguage = "ja-JP" };
            runProperties85.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text85 = new A.Text();
            text85.Text = "Click to edit Master text styles";

            run63.Append(runProperties85);
            run63.Append(text85);

            paragraph98.Append(paragraphProperties51);
            paragraph98.Append(run63);

            textBody62.Append(bodyProperties62);
            textBody62.Append(listStyle62);
            textBody62.Append(paragraph98);

            shape62.Append(nonVisualShapeProperties62);
            shape62.Append(shapeProperties62);
            shape62.Append(textBody62);

            Shape shape63 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties63 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties76 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Date Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties63 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks63 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties63.Append(shapeLocks63);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties76 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape63 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties76.Append(placeholderShape63);

            nonVisualShapeProperties63.Append(nonVisualDrawingProperties76);
            nonVisualShapeProperties63.Append(nonVisualShapeDrawingProperties63);
            nonVisualShapeProperties63.Append(applicationNonVisualDrawingProperties76);
            ShapeProperties shapeProperties63 = new ShapeProperties();

            TextBody textBody63 = new TextBody();
            A.BodyProperties bodyProperties63 = new A.BodyProperties();
            A.ListStyle listStyle63 = new A.ListStyle();

            A.Paragraph paragraph99 = new A.Paragraph();

            A.Field field23 = new A.Field(){ Id = "{8263865E-5382-4BDD-A09E-2B63F38BCE59}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties86 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties86.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text86 = new A.Text();
            text86.Text = "2012/10/3";

            field23.Append(runProperties86);
            field23.Append(text86);
            A.EndParagraphRunProperties endParagraphRunProperties58 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph99.Append(field23);
            paragraph99.Append(endParagraphRunProperties58);

            textBody63.Append(bodyProperties63);
            textBody63.Append(listStyle63);
            textBody63.Append(paragraph99);

            shape63.Append(nonVisualShapeProperties63);
            shape63.Append(shapeProperties63);
            shape63.Append(textBody63);

            Shape shape64 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties64 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties77 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Footer Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties64 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks64 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties64.Append(shapeLocks64);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties77 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape64 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties77.Append(placeholderShape64);

            nonVisualShapeProperties64.Append(nonVisualDrawingProperties77);
            nonVisualShapeProperties64.Append(nonVisualShapeDrawingProperties64);
            nonVisualShapeProperties64.Append(applicationNonVisualDrawingProperties77);
            ShapeProperties shapeProperties64 = new ShapeProperties();

            TextBody textBody64 = new TextBody();
            A.BodyProperties bodyProperties64 = new A.BodyProperties();
            A.ListStyle listStyle64 = new A.ListStyle();

            A.Paragraph paragraph100 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties59 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph100.Append(endParagraphRunProperties59);

            textBody64.Append(bodyProperties64);
            textBody64.Append(listStyle64);
            textBody64.Append(paragraph100);

            shape64.Append(nonVisualShapeProperties64);
            shape64.Append(shapeProperties64);
            shape64.Append(textBody64);

            Shape shape65 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties65 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties78 = new NonVisualDrawingProperties(){ Id = (UInt32Value)7U, Name = "Slide Number Placeholder 6" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties65 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks65 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties65.Append(shapeLocks65);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties78 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape65 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties78.Append(placeholderShape65);

            nonVisualShapeProperties65.Append(nonVisualDrawingProperties78);
            nonVisualShapeProperties65.Append(nonVisualShapeDrawingProperties65);
            nonVisualShapeProperties65.Append(applicationNonVisualDrawingProperties78);
            ShapeProperties shapeProperties65 = new ShapeProperties();

            TextBody textBody65 = new TextBody();
            A.BodyProperties bodyProperties65 = new A.BodyProperties();
            A.ListStyle listStyle65 = new A.ListStyle();

            A.Paragraph paragraph101 = new A.Paragraph();

            A.Field field24 = new A.Field(){ Id = "{DF0B8B9E-EDC2-479A-B980-EDD8632819B1}", Type = "slidenum" };

            A.RunProperties runProperties87 = new A.RunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };
            runProperties87.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text87 = new A.Text();
            text87.Text = "‹#›";

            field24.Append(runProperties87);
            field24.Append(text87);
            A.EndParagraphRunProperties endParagraphRunProperties60 = new A.EndParagraphRunProperties(){ Kumimoji = true, Language = "ja-JP", AlternativeLanguage = "en-US" };

            paragraph101.Append(field24);
            paragraph101.Append(endParagraphRunProperties60);

            textBody65.Append(bodyProperties65);
            textBody65.Append(listStyle65);
            textBody65.Append(paragraph101);

            shape65.Append(nonVisualShapeProperties65);
            shape65.Append(shapeProperties65);
            shape65.Append(textBody65);

            shapeTree13.Append(nonVisualGroupShapeProperties13);
            shapeTree13.Append(groupShapeProperties13);
            shapeTree13.Append(shape60);
            shapeTree13.Append(shape61);
            shapeTree13.Append(shape62);
            shapeTree13.Append(shape63);
            shapeTree13.Append(shape64);
            shapeTree13.Append(shape65);

            CommonSlideDataExtensionList commonSlideDataExtensionList13 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension13 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId13 = new P14.CreationId(){ Val = (UInt32Value)1836910191U };
            creationId13.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension13.Append(creationId13);

            commonSlideDataExtensionList13.Append(commonSlideDataExtension13);

            commonSlideData13.Append(shapeTree13);
            commonSlideData13.Append(commonSlideDataExtensionList13);

            ColorMapOverride colorMapOverride12 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping11 = new A.MasterColorMapping();

            colorMapOverride12.Append(masterColorMapping11);

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
            RestoredLeft restoredLeft1 = new RestoredLeft(){ Size = 19972, AutoAdjust = false };
            RestoredTop restoredTop1 = new RestoredTop(){ Size = 94660 };

            normalViewProperties1.Append(restoredLeft1);
            normalViewProperties1.Append(restoredTop1);

            SlideViewProperties slideViewProperties1 = new SlideViewProperties();

            CommonSlideViewProperties commonSlideViewProperties1 = new CommonSlideViewProperties(){ SnapToGrid = false };

            CommonViewProperties commonViewProperties1 = new CommonViewProperties(){ VariableScale = true };

            ScaleFactor scaleFactor1 = new ScaleFactor();
            A.ScaleX scaleX1 = new A.ScaleX(){ Numerator = 80, Denominator = 100 };
            A.ScaleY scaleY1 = new A.ScaleY(){ Numerator = 80, Denominator = 100 };

            scaleFactor1.Append(scaleX1);
            scaleFactor1.Append(scaleY1);
            Origin origin1 = new Origin(){ X = 90L, Y = 102L };

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
            template1.Text = "Apex";
            Ap.TotalTime totalTime1 = new Ap.TotalTime();
            totalTime1.Text = "0";
            Ap.Words words1 = new Ap.Words();
            words1.Text = "0";
            Ap.Application application1 = new Ap.Application();
            application1.Text = "Microsoft Office PowerPoint";
            Ap.PresentationFormat presentationFormat1 = new Ap.PresentationFormat();
            presentationFormat1.Text = "Widescreen";
            Ap.Paragraphs paragraphs1 = new Ap.Paragraphs();
            paragraphs1.Text = "0";
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
            vTInt321.Text = "7";

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

            Vt.VTVector vTVector2 = new Vt.VTVector(){ BaseType = Vt.VectorBaseValues.Lpstr, Size = (UInt32Value)9U };
            Vt.VTLPSTR vTLPSTR4 = new Vt.VTLPSTR();
            vTLPSTR4.Text = "HG丸ｺﾞｼｯｸM-PRO";
            Vt.VTLPSTR vTLPSTR5 = new Vt.VTLPSTR();
            vTLPSTR5.Text = "HG明朝B";
            Vt.VTLPSTR vTLPSTR6 = new Vt.VTLPSTR();
            vTLPSTR6.Text = "Book Antiqua";
            Vt.VTLPSTR vTLPSTR7 = new Vt.VTLPSTR();
            vTLPSTR7.Text = "Lucida Sans";
            Vt.VTLPSTR vTLPSTR8 = new Vt.VTLPSTR();
            vTLPSTR8.Text = "Wingdings";
            Vt.VTLPSTR vTLPSTR9 = new Vt.VTLPSTR();
            vTLPSTR9.Text = "Wingdings 2";
            Vt.VTLPSTR vTLPSTR10 = new Vt.VTLPSTR();
            vTLPSTR10.Text = "Wingdings 3";
            Vt.VTLPSTR vTLPSTR11 = new Vt.VTLPSTR();
            vTLPSTR11.Text = "Apex";
            Vt.VTLPSTR vTLPSTR12 = new Vt.VTLPSTR();
            vTLPSTR12.Text = "PowerPoint Presentation";

            vTVector2.Append(vTLPSTR4);
            vTVector2.Append(vTLPSTR5);
            vTVector2.Append(vTLPSTR6);
            vTVector2.Append(vTLPSTR7);
            vTVector2.Append(vTLPSTR8);
            vTVector2.Append(vTLPSTR9);
            vTVector2.Append(vTLPSTR10);
            vTVector2.Append(vTLPSTR11);
            vTVector2.Append(vTLPSTR12);

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
            document.PackageProperties.Creator = "Masaki Tamura (Pasona Tech)";
            document.PackageProperties.Title = "PowerPoint Presentation";
            document.PackageProperties.Revision = "2";
            document.PackageProperties.Created = System.Xml.XmlConvert.ToDateTime("2012-01-27T07:18:02Z", System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
            document.PackageProperties.Modified = System.Xml.XmlConvert.ToDateTime("2012-10-03T08:46:12Z", System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
            document.PackageProperties.LastModifiedBy = "Dan Ito";
        }

        #region Binary Data
        private string thumbnailPart1Data = "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";

        private string imagePart1Data = "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AAAAAAQAAAAeOEJJTQPzAAAAAAAJAAAAAAAAAAABADhCSU0ECgAAAAAAAQAAOEJJTScQAAAAAAAKAAEAAAAAAAAAAjhCSU0D9QAAAAAASAAvZmYAAQBsZmYABgAAAAAAAQAvZmYAAQChmZoABgAAAAAAAQAyAAAAAQBaAAAABgAAAAAAAQA1AAAAAQAtAAAABgAAAAAAAThCSU0D+AAAAAAAcAAA/////////////////////////////wPoAAAAAP////////////////////////////8D6AAAAAD/////////////////////////////A+gAAAAA/////////////////////////////wPoAAA4QklNBAAAAAAAAAIAADhCSU0EAgAAAAAAIAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAOEJJTQQIAAAAAAAQAAAAAQAAAkAAAAJAAAAAADhCSU0EHgAAAAAABAAAAAA4QklNBBoAAAAAA0UAAAAGAAAAAAAAAAAAAAMAAAAEAAAAAAgAcABsAGEAdABvAF8AQgBHAAAAAQAAAAAAAAAAAAAAAAAAAAAAAAABAAAAAAAAAAAAAAQAAAADAAAAAAAAAAAAAAAAAAAAAAABAAAAAAAAAAAAAAAAAAAAAAAAABAAAAABAAAAAAAAbnVsbAAAAAIAAAAGYm91bmRzT2JqYwAAAAEAAAAAAABSY3QxAAAABAAAAABUb3AgbG9uZwAAAAAAAAAATGVmdGxvbmcAAAAAAAAAAEJ0b21sb25nAAADAAAAAABSZ2h0bG9uZwAABAAAAAAGc2xpY2VzVmxMcwAAAAFPYmpjAAAAAQAAAAAABXNsaWNlAAAAEgAAAAdzbGljZUlEbG9uZwAAAAAAAAAHZ3JvdXBJRGxvbmcAAAAAAAAABm9yaWdpbmVudW0AAAAMRVNsaWNlT3JpZ2luAAAADWF1dG9HZW5lcmF0ZWQAAAAAVHlwZWVudW0AAAAKRVNsaWNlVHlwZQAAAABJbWcgAAAABmJvdW5kc09iamMAAAABAAAAAAAAUmN0MQAAAAQAAAAAVG9wIGxvbmcAAAAAAAAAAExlZnRsb25nAAAAAAAAAABCdG9tbG9uZwAAAwAAAAAAUmdodGxvbmcAAAQAAAAAA3VybFRFWFQAAAABAAAAAAAAbnVs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MTFkYS1iMGU4LTg1ZDljZDQxNTQyNycKICB4bWxuczpleGlmPSdodHRwOi8vbnMuYWRvYmUuY29tL2V4aWYvMS4wLyc+CiAgPGV4aWY6UGl4ZWxYRGltZW5zaW9uPjEwMjQ8L2V4aWY6UGl4ZWxYRGltZW5zaW9uPgogIDxleGlmOlBpeGVsWURpbWVuc2lvbj43Njg8L2V4aWY6UGl4ZWxZRGltZW5zaW9uPgogIDxleGlmOkNvbG9yU3BhY2U+MTwvZXhpZjpDb2xvclNwYWNlPgogIDxleGlmOk5hdGl2ZURpZ2VzdD4zNjg2NCw0MDk2MCw0MDk2MSwzNzEyMSwzNzEyMiw0MDk2Miw0MDk2MywzNzUxMCw0MDk2NCwzNjg2NywzNjg2OCwzMzQzNCwzMzQzNywzNDg1MCwzNDg1MiwzNDg1NSwzNDg1NiwzNzM3NywzNzM3OCwzNzM3OSwzNzM4MCwzNzM4MSwzNzM4MiwzNzM4MywzNzM4NCwzNzM4NSwzNzM4NiwzNzM5Niw0MTQ4Myw0MTQ4NCw0MTQ4Niw0MTQ4Nyw0MTQ4OCw0MTQ5Miw0MTQ5Myw0MTQ5NSw0MTcyOCw0MTcyOSw0MTczMCw0MTk4NSw0MTk4Niw0MTk4Nyw0MTk4OCw0MTk4OSw0MTk5MCw0MTk5MSw0MTk5Miw0MTk5Myw0MTk5NCw0MTk5NSw0MTk5Niw0MjAxNiwwLDIsNCw1LDYsNyw4LDksMTAsMTEsMTIsMTMsMTQsMTUsMTYsMTcsMTgsMjAsMjIsMjMsMjQsMjUsMjYsMjcsMjgsMzA7NDVGRUQwQUY1NEUxNDMzMzQwRjAwNzUyRDZBM0Q2MzU8L2V4aWY6TmF0aXZlRGlnZXN0PgogPC9yZGY6RGVzY3JpcHRpb24+CgogPHJkZjpEZXNjcmlwdGlvbiBhYm91dD0ndXVpZDpkMjhjZjI1Zi1jNGM0LTExZGEtYjBlOC04NWQ5Y2Q0MTU0MjcnCiAgeG1sbnM6cGRmPSdodHRwOi8vbnMuYWRvYmUuY29tL3BkZi8xLjMvJz4KICA8IS0tIHBkZjpDcmVhdG9yIGlzIGFsaWFzZWQgLS0+CiAgPCEtLSBwZGY6Q3JlYXRpb25EYXRlIGlzIGFsaWFzZWQgLS0+CiAgPCEtLSBwZGY6TW9kRGF0ZSBpcyBhbGlhc2VkIC0tPgogPC9yZGY6RGVzY3JpcHRpb24+CgogPHJkZjpEZXNjcmlwdGlvbiBhYm91dD0ndXVpZDpkMjhjZjI1Zi1jNGM0LTExZGEtYjBlOC04NWQ5Y2Q0MTU0MjcnCiAgeG1sbnM6cGhvdG9zaG9wPSdodHRwOi8vbnMuYWRvYmUuY29tL3Bob3Rvc2hvcC8xLjAvJz4KICA8cGhvdG9zaG9wOkNvbG9yTW9kZT4zPC9waG90b3Nob3A6Q29sb3JNb2RlPgogIDxwaG90b3Nob3A6SUNDUHJvZmlsZT5zUkdCIElFQzYxOTY2LTIuMTwvcGhvdG9zaG9wOklDQ1Byb2ZpbGU+CiAgPHBob3Rvc2hvcDpIaXN0b3J5PjwvcGhvdG9zaG9wOkhpc3Rvcnk+CiA8L3JkZjpEZXNjcmlwdGlvbj4KCiA8cmRmOkRlc2NyaXB0aW9uIGFib3V0PSd1dWlkOmQyOGNmMjVmLWM0YzQtMTFkYS1iMGU4LTg1ZDljZDQxNTQyNycKICB4bWxuczp0aWZmPSdodHRwOi8vbnMuYWRvYmUuY29tL3RpZmYvMS4wLyc+CiAgPHRpZmY6T3JpZW50YXRpb24+MTwvdGlmZjpPcmllbnRhdGlvbj4KICA8dGlmZjpYUmVzb2x1dGlvbj43MjAwMDAvMTAwMDA8L3RpZmY6WFJlc29sdXRpb24+CiAgPHRpZmY6WVJlc29sdXRpb24+NzIwMDAwLzEwMDAwPC90aWZmOllSZXNvbHV0aW9uPgogIDx0aWZmOlJlc29sdXRpb25Vbml0PjI8L3RpZmY6UmVzb2x1dGlvblVuaXQ+CiAgPHRpZmY6TmF0aXZlRGlnZXN0PjI1NiwyNTcsMjU4LDI1OSwyNjIsMjc0LDI3NywyODQsNTMwLDUzMSwyODIsMjgzLDI5NiwzMDEsMzE4LDMxOSw1MjksNTMyLDMwNiwyNzAsMjcxLDI3MiwzMDUsMzE1LDMzNDMyOzdERDUwQTBDMkEzQjg1RjU1NEJCRDY2MEQ1Qjk2RDg0PC90aWZmOk5hdGl2ZURpZ2VzdD4KIDwvcmRmOkRlc2NyaXB0aW9uPgoKIDxyZGY6RGVzY3JpcHRpb24gYWJvdXQ9J3V1aWQ6ZDI4Y2YyNWYtYzRjNC0xMWRhLWIwZTgtODVkOWNkNDE1NDI3JwogIHhtbG5zOnhhcD0naHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wLyc+CiAgPHhhcDpDcmVhdG9yVG9vbD5BZG9iZSBQaG90b3Nob3AgQ1MyIFdpbmRvd3M8L3hhcDpDcmVhdG9yVG9vbD4KICA8eGFwOkNyZWF0ZURhdGU+MjAwNS0xMi0xNlQxNToxMDo1Ny0wODowMDwveGFwOkNyZWF0ZURhdGU+CiAgPHhhcDpNb2RpZnlEYXRlPjIwMDUtMTItMjBUMTc6MDE6MzAtMDg6MDA8L3hhcDpNb2RpZnlEYXRlPgogIDx4YXA6TWV0YWRhdGFEYXRlPjIwMDUtMTItMjBUMTc6MDE6MzAtMDg6MDA8L3hhcDpNZXRhZGF0YURhdGU+CiAgPCEtLSB4YXA6Rm9ybWF0IGlzIGFsaWFzZWQgLS0+CiA8L3JkZjpEZXNjcmlwdGlvbj4KCiA8cmRmOkRlc2NyaXB0aW9uIGFib3V0PSd1dWlkOmQyOGNmMjVmLWM0YzQtMTFkYS1iMGU4LTg1ZDljZDQxNTQyNycKICB4bWxuczp4YXBNTT0naHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wL21tLyc+CiAgPHhhcE1NOkRvY3VtZW50SUQ+dXVpZDpBQTAzMDVFQTg4NkVEQTExQTNENzhCQTZEQzk5NzQ1RjwveGFwTU06RG9jdW1lbnRJRD4KICA8eGFwTU06SW5zdGFuY2VJRD51dWlkOjMyM0U4QTE5QkQ3MURBMTFBNjI3QTQ0ODYyQzJGRDUxPC94YXBNTTpJbnN0YW5jZUlEPgogPC9yZGY6RGVzY3JpcHRpb24+CgogPHJkZjpEZXNjcmlwdGlvbiBhYm91dD0ndXVpZDpkMjhjZjI1Zi1jNGM0LTExZGEtYjBlOC04NWQ5Y2Q0MTU0MjcnCiAgeG1sbnM6ZGM9J2h0dHA6Ly9wdXJsLm9yZy9kYy9lbGVtZW50cy8xLjEvJz4KICA8ZGM6Zm9ybWF0PmFwcGxpY2F0aW9uL3ZuZC5hZG9iZS5waG90b3Nob3A8L2RjOmZvcm1hdD4KIDwvcmRmOkRlc2NyaXB0aW9uPgoKPC9yZGY6UkRGPgo8L3g6eGFwbWV0YT4KICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAKICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIAogICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgCjw/eHBhY2tldCBlbmQ9J3cnPz7/4gxYSUNDX1BST0ZJTEUAAQEAAAxITGlubwIQAABtbnRyUkdCIFhZWiAHzgACAAkABgAxAABhY3NwTVNGVAAAAABJRUMgc1JHQgAAAAAAAAAAAAAAAQAA9tYAAQAAAADTLUhQICAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAABFjcHJ0AAABUAAAADNkZXNjAAABhAAAAGx3dHB0AAAB8AAAABRia3B0AAACBAAAABRyWFlaAAACGAAAABRnWFlaAAACLAAAABRiWFlaAAACQAAAABRkbW5kAAACVAAAAHBkbWRkAAACxAAAAIh2dWVkAAADTAAAAIZ2aWV3AAAD1AAAACRsdW1pAAAD+AAAABRtZWFzAAAEDAAAACR0ZWNoAAAEMAAAAAxyVFJDAAAEPAAACAxnVFJDAAAEPAAACAxiVFJDAAAEPAAACAx0ZXh0AAAAAENvcHlyaWdodCAoYykgMTk5OCBIZXdsZXR0LVBhY2thcmQgQ29tcGFueQAAZGVzYwAAAAAAAAASc1JHQiBJRUM2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/wAi/wCK349+698+sRP++/3349+615Y6xE/6/wDsf99b37rY4dYyf99/vvpx7969e/PrCT7917rGx/5H/vh7117/AA9YiRx/vufe+vdYmP8Avv8Aitx+T795dez1jJ+oP++Hv3oevdYSf9f/AGxP/Feffqde6wMR+CQeNR/qbWswuAfp/sPe+HEf6v8AVjrVSOP+r/V/sdR2a5P+J/pa/wDT+o+nvVOt+X2dYSf99/tv9hY+/de6xE/776f7b37r3WMn/ePz795de9OsRNv99/t/9t7917rGT/j/ALb/AB9+9evdYif+JH9B/j9ffq8evZ6xk/7x791706x3/H+88i9v+Ke/dezjrEx/33Pv3XusZP8AvP8Avj/r+/de9fXrGT/vv944/wAffuHXusZP9P8AfH/ePe+vV6xE/wCt/vv8L/4+9deGesZJ5/330449+691gY8c2txcXI/3sAD/AH39Pe/UHr3AgV6wMf8AXH1IFxax/pY/Q+9VPXscesJP++/41795/Pr3WMn/AB/w/wBf37r2OsZ5/wB9/h7917h1jY/73/vj7917rGT7917/AAdf/9Lf49+691737r3Xvfuvde9+691737r3Xvfuvdde6kde66Kg/wCv/X3XrfWBk/B/2B9+691Elhv/ALH/AGx/1/6e9g9bB6bJqcG/H+w/4n3vqw6ZaqjDAgrcf8V/4n3YHq3H7ekpXYy1yBcfX+pH+v8A19uBurA049JCsoPr6f8AbfT26D04D0lquh+vH9f8fdwenK9JuppLX4/33+8+3K169518umKoprX4/wB4/wB6978h177OmaaHk8f8a96p1qlemyWL/D+o/wAPz/vfvRHWqGvTdKn1/rf6+60/Z1o+vUN1/wAP9hz/AMV9660RXh1DcEe/UBqetHPHiOo5Y/8AGx9f9j/h79j8uvHHXHy24v8A8jv/ALx71T9vVfnTrkJfp/xB/wCR/ge9fn14Eddeb/GxFrH/AFv9b8i/v3Drf5Vx1yEwP1PP++/Pv1ader+zrIJT+CLfS1/r9P8AW97x1uo9Ou/LfggW/wBj/vj731v7OsTD8ofpyRz/AL372Dx631j8pF/9jcH/AGP1/PvYI4dbr1yE9v8AkfvYPp1uoP29SUqvoLn/AI1/xse/edetGvn1Mjq7fn37rfUyOrP9f6f63++t79+XWupiVQJH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bpFuD/vjzb/e/fuHHr3A56aKuminQpKgdf6/2lI/obGw9760MZ6Q+TwbrqaD91ProtdwOb8cmw/3ke/A8K9WB4dIiqpbFgQRYm40gWv9fyeePe68OvVrx6YainsSbH+n0/3v+tre/EV61T06ZpobX4/33+8e6EU60c9Nssf++/33+HvWOFOqkV6a5o7G4H+BH/E+9fbw61w49QZFB/rf/eP99b3qmfl17PUN1Nz9Pp+P9f3oitAeqkA8MHqI455/33/FfdDjPl1Thx6iMCDxf/iP9596I9Ovep8usDgEEf77/efp718+q0occeoDgg2+v+w/1/qf9b3bq4NeIz1Fcf090YZ6qV9OsBPuv+DqnWB7H/iv++P197Hp5dWr68Oor8X/ANt/sb2A/r78Rx61Th6dRpDc88Wvwosebm/PH4v7rj4utVxx7uo7G5J/r/xN/wDY+99e9esLH/fc+/de6xMf6fX+n+w59+4VqeveeOsZPv3XusTH/Dn37169x+zrCT/vvr/h7917rExv/vv+Re/U691jY/8AI/8Afc/7b3719Ovfn1iJ+v8Avv8AW9+691iY83vb6/8AIvrbn37r3WJj/vvzb829++zr3HrEx/33+P8AxPv3XusRJ+v+H/I/fsde8usLsALnkAj/AF/8Px9feuPXhxp1Fcjm/wDU2sRYcj+nHP8AX8+/CuPTr3njj1gJ/wCK/n6j/kXvfXusRP8Avvp/tvfuvdYSf949+631jb/ff7b/AB49+4da6xMf6f4C3/EH/Y+/de6wsb+/D59e6xsT/wAj9++zr3DrEx5/437917/B1ib+t/8Aff74+/V691iY/wC+/wB49+4cevfb1iY/gf737917rET9f9t79/h691iY/wDG/rb/AF+f6D37rw6jO3+PIHHPIvxyLW/2Fvz79x44HXjxxXqOTz9b/wC+/wAeffuvZOfPrCT/AL7/AG59+691iY/71/xUe/de6xE/T/bf8j59+691jY/4/wDFP6f7fn37P5deHWI83/3w/wCK+/deJ6xMf97/AONf7x796CvXvn1iJ+v1/wBh/rH8e/cM9e6xMf8AffT/AJF7914dYif96+t/pz+f99+ffuHXusbH63/33++v791416xE/wC+/p/T37r3WIn/AI1f/fW9+6959Yif99/yP37rw6xE/X/Ef43/AN69+p59e6wu34vb/ihH1tbn/Ye/ZxTrYBPlUdR2b86jcf4f1F+P9Y/8a9+4Ejr3Dhw/1f5OsBP+P+++n/E+/V+XWuPWNj/vX5/2/wDvXv3Xq+vWJjx/j/vv6ce/fn17HWIn6/7H/be/de48esRPP+9/T37yz14dYyRz9f8AYe99eHWMn6/8T7117GD1iJ/xt/vrf72ffuveXWMn/ev6f4/6/v3XusZP1/r+f99z79w8uvdYiffq9e6xkj/iB/vvz799nXusZPv3r16vWIni/wDxP++4Pv3y691jJ/330/2559+Py69jzPUdje5/I+lr/WwBFuObn/ivHvVaDhnrxz549OsDn8cm3H9Rf6X/ANaw97HDr3r1iJ/1v+I/x9+8+vfLrGSfp/if98f9t79/g69jrHf/AI0L/wCx9+/w9ePrXrgT9f8AiffuvdYif9b8/wDG/wCvv3W+uBN/99/vr+/da6//1N/j37r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde96I9Ovdde6db64Ml+Rx/h/vvp7917qO6Bv8D/vf+v7914GnUCWH6ix/p/vv6j3bqwNemmopgb8cc+7A9XB6TtZQK4PH+F7f737uG6sPlx6R9djSt7r/AF5/B/1vboPV1bpIVlBa50/1/wB7/wB49uA/Pp0HpLVdCeeP9h/vv6+3ARx6tUfn0nKilK34+nu/Hr329MdRT2vYf77/AHn3rj1rpnni+tx/vufeqdaI6apoiL8cf8i/3v3rrRFcHpukS31+h91Ip1ojA6b5Usf9j9P6/wDEf8b91Pn6dVbhw6b3JBIP4J/3n/E82/3j36g8jjqpAGacesDEf8R/xr3Q1r16nWPX/jb/AB/3r+vv3WqHrryEXseP6f1/4n36vy63T16yCYH8/wC83P8AxW3vf2da/Lrn5PpY/wCw/wCNfj36p8x17rsTH6En/X5t+f8AH3vB4cet9cvLx+CP97/2HvfXh1hdb+qP625XgfX8j/be/A9WDU48OsHltwSQb/1+nveet1zw65ifn6g2+g/P4/I5+vvYNOPW6nrKtSR+f6fXn/efr72Ot46lJVW/Nuf+Kfn/AF/futZ/LqYlX/iP6/7xxb/be9de+3qStT9Of9v+f9j/AK/v3Wvz6yGZXFiR/h/yP37j5Y62Pn1FlS3Km4/w+o96PWjw6bZP9hb/AHn/AH1/e+tH7c9Nsq/0P15/I+hI+hv9ffuB68R59J2vxlPVhiyiOX8SILG/41fgj/Ye9cOt16QuRxM1MW1LqTm0ij0kfi4/sm3u1a/b17j0lqin+th9frx/vXvRz17plnhIv/sb8f6/HutOtfLpqmi/w5/4j/b8/X3rrRA49Nc0NrkX/wBf/fD3rrWem+RbcEf7f/ePeqfs61Tzr1CkUf77/W/3q3vXDj1qmrB49RHH+xHupFMjqhBU/LqG44uL/wDEf6/uoycda88dRXAP++/2H5+vv1fXr3HqI6kX4454/I+vP9be91+fWwfXqKwB5v8A4f63/IveioPXioPUZ+OT/vR+nP0/wA90Iz02QRx6iyn/AA5sR/Qj+hv/AIkf7x78OOOvKfLz6hP/ALa345t79Tz62QBw6wN/sb/7Y/8AIvevl1XrET7916vWIn/ff77/AFveuvfn1iJv/vX9ef6+9n063wFesRP++/5EPfutfb1iJ/w/2J9+/Pr3WJv+NW/41/T37r3WJj/vv9b37r3WJj/vv9j/AE9+698usZP/ABT/AIp7917rCT/j+f8AfH37y69w6xMf99/rf7b378+vdYmPH+P+P/I/fuvY6iu/NuQL/nkcfj6m4v8AX36nxZ60Dkn/AFf5KdYGNyb3+v8Avvzf377Ot/n1iY2/P/ED37rXEdYW/wBt/j/vre/db6xMf99/sPfvt68T1jJ/31/+N+/de4dYm/2/+w/5F9ffvt696dYWP5+vv3XusRPH++/31uffuvdYmP8Aj/vh79+XXsnrGx/p/vv969+4de6wk/763+9fj375db9R1jY/778c+/fZ1rrCx/3v37r3DrAzA/X6G/JItYD+gJJsfes+X+r/AFf6vloimKZ6jM3J/Fz/ALx+B/sPfhwHW6k9YCf8ef68/wC++vvfl17rGx/3v8/T37r3WIn/AH3+H/Gve+vdYif9j/vufeuvdYif9h/re/de4dY2PH/E2P8AvB59+69+XWEn/if99/T6+/etevYpnrGTx+f98ffvPr3WIm3++/5F79x4dez6dYWP+3t7917rGT/sfp799nXusRP++5/1/wDD37r35dYif6/7H/ffT37r1f2dYyfx/X/fH/be/fPr3z6wuwtyRb6c83J/qPqSffuGade6wSMbWNvwfyfpx9bcEn3oef2fy68BUV8uoxP9f9b3s9e6xE/8b/PP/E+/deHGvWIn/fX/AN7/AKe/der1jJ/339Pp/tvfuvHrGx4/1/8AY+/Dz691iY/77/X9+xXr3qesRJ/4jn/D/Y+/da8+sZJ9+x1vrGT/AI/77/jfv3Xv8PWMkn/ff8R715de6xE/776/7b+nvfXuuBP1/wB9/vXvR691iJ/33+2/HvfDr3WNif8AD/ff4f4+/Y/Lr3WIm1+P+J+nPHv3Xvn1gdx+P6H6WuPpyCfx/vfvxGOHWvsPUdmJ+v8Ahxe4/wBcc8e/dbzk16xE/wDEf6/9T791416xk+/de6xsf99/xP8AT6+/Dy691jJ/31x/T37rw6xsePfuvdYz79WvXvt64N/T/fX+vv3XvQ9f/9Xf49+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde96Ir9vXuuvdOt9cWUN/r/wBffuvdYHS/BH+sf+Ke/de6hSw/Xj6/T/H/AIofdgerA9Nc9N9bDj/Yce7V6vXpiqqJXDXW/wDhb3YGnW68OkjX4y1yBcf61yP9f+vt1W6cVvXj0ja3H/Wy/wC8f7429uhvn06D0layh/V6f6/j/jXtwN69X49JiqoyCbD/AIn6fX3etc161Sg+XTBUU/1uP6j/AA/4p71/h699nTLPAR+Pof8AivFvx799vWqA9NE0Vr8fX8fTkf0/HvR+3rWfPppmTT+B9PpYf48+60DfLrRHGnTZKv8AW3+8C3+w96oa9Vp5dQJFKk8cf7x/t/dTnHn1XqM3196GOvHgOsJJ/wBbj/ff7172eq9cdZH/ABP/ABr3XHW+uQm/33++4/PvXWj6dcxN/rf7b+vHv1RwI69mvy65Cb/Yf7z/AKxP+Hv3lg9b/wAHXLzKef8Aff4+91PXuHl105V/qb/0P5/P+3HvYPy68DTqI+pOfqv9bn/ef8fewxpx6sDwr1jExW3PAv7tUHy63XrItR/jb/Y/8V9769k9Z1qiLXP+2/3v/H34de+3qStV/Q/8U/3n6e/fbx63Q9Skqv8AH6j8fT6+/ccda6kCq/Fxc/S/5+n5/B9+/wAHXvmSadY5GWQfX1c/T/bXPP8Avr+9dex5DptlBU8j8CxA/wB99ffvLr3HqFJY/wCI/rb/AB96/LrXy6bZkDBgRqU/qUj+v+B4Pv3p17pJ5HCxylnpyI35Jjb9Df4g/UE2/HHv1fXrfSJraJ4mKSIyH+hHBvxwbEe/U9D1rpgnpyL8f8b/AN596698umieH/iT/vf+Hv3n1o8OmqaL/X/1z9f8f9f6+608+q0I6bJFtwOfqD9ePwbe9Ur17j9nUJ1/p/sR9Lj/AAHv3DrR4UPDqG6/X8/8a91Kg8MHqhUjI6iSC30/1/8AH3Xjg1r17jw49RXF72/33/Ivehg0PWh6HqG6kfT/AHnj/X97xx63Wh6huTyOD9LA3ufqLD6c3HvdKjPWzpYUNeoUmpSL/wCpt9Af6g/1t7aK5PTTfPhXqM/P/Ff+K/15PvQPXgaY6jP+f6/1/wCK3/1/djnPW6A9R2/3n8+9fLrXDrET71/h6r1iJ/4p/T/er+/db6xMf+Nfn/ilvfq9e/LrEzf77/ffX37rxr5dYyf9b/ff7x799nXusJP5t/vv+N+/de4dYifz7917rETz/sP99zb377evefWNj9T/AL7/AHj37r3WIn/C1zf37/B17qO7cnn/AFuL83Fza4uR71UCuM9ezwAz/q/1eXUVj9Lf73/vXHuxPE+XXusRNr+9flnr2cdYif8Abf6/+8e/fl17rET/AL7/AG34/H09+691iJ/33/GvfuvD1p1iY/71/r+98evefDrE3++/4p/sPeuvdYmP+P8AsOP+K/09+49e6xM3/E/8j9+691iJ+vvXz69TrET/AK3++/4p7317rET7917rEx4/pf8A23v3XvUdYHYAW/r/AMjuOD/T3uvWuIxx6jOx4F+Bxa44sAPwBzb36tfLq1acDXrAT/X/AGH/ABu/1968+tVp1iY/X37r3WNj798+vcOsLH/er/0t/tvfuvdYyffuvCnWIn/YfX/ff097691iY+9Z63TrExP09+HDrX59Yif99/vvzz7917rEx/33+8D37rXWJj9PoP8AfG3+HvfW69Yyf99/vv6+9de6xE/77/ivv359e/wdYj+ffuvdYyeP969+z17qO55A5F+f9Yg2B/I5t79UCv2f6v8AV/sda4Akf6v9X+rz6juwsP8AD+n+P9foL/4+/f4etj59YSeP+Kf717917rET/wAb/wB8PfuvcOPWMn+n++v+PfuvdYmP/E+/cT16vWMn/ffn/Y39+691iJB+v/E/63HHv2evdYj79x691jJ/33+9e/fn17rGT/vv979+691iP++/33+Hvx69X06xk/77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I6iuOb/T/ffj3Vh1Vl8wOozH6j/jf9Pdeq1IyOsDC3+t/wAi497B62D69R2/r/r/AO+B96I8uvEcKdYGP9R/t/8AfWvf3rhjqvWJj/vv9fj37r3p1jb6f71x791759Yief8AYf8AEe/cR17HDrEx+v8At/8AG/v3XusLH/Hn/ff7b37y691iZrWH/G/6f7ADn37rwz59RXbk8fQnn/bAi1ha/wCT73wpUdaOcV6jk/7Y/wCx+n196631iJ4/1v8Aff097OevdYif9f8AH/G72t716de/wdY2P+9/8R/sPfuvdYmP++/334Pv359e/wAHWFj/AL7/AH3+Hv3XusRPv3+Hr3WMn/ff4Xt/xHv3Wz1iJ/r+f96/4p79x4da6xMf99/xJ59+691iJ9+x1rrEx/1+b/n37y631hJ/33/Ivfvl17rA7cgcj6H88j+nAI+pHvRHn8v9R61UZx1FY/0+g4+t/wDebD8+9/4et9YmP++4P++/4n37r3WJif8AfX9+696dYif99/sf9b37r3WIn/Y/4/776e/Z69jz6xk/8U9+r17rET/xvn8/X+l/fuvcadYifr/vv979+z1716xE/wCPv3XusRb+lvfv8HXv8PWIm3vx9OvDrETa/wDyOwHv1fTr3WJr/wC8+/efXuPWMn/ff7f/AG/19+691iJ/33+8fT/X9+691iZhwLgE/wCPP9Tb6+9H0z17GSeozEDnkn+vNhzyOSbg24979COHXjxp1HJv+fqf6/8AE+/de6xk8f76/wCbe/de8+sTHn3r5de8j1iJ/wB9/rf8R7t17rGTx/vv6n3rr3DrET/t/wDbf8i9+/wde4fZ1jY/X/bjn377OvGv5dYyfr/vv629+691iJ/33/FPfuvY6xk/7H/ff7H+nv3Xv8PWMn/X/ryffutdYyf97/2/H+tz791vy6xE/j+nv3XusZP++/5F79x691jJ/wBjf6/Tj/H377etV6juT/Q2H+N734Fr3928uNP9X+r+XW6ilCM9YCf8Of8Aefz9f8efda9e+zh1hJ/xP+Hv3XuuBP8At/6+/evXvTrGT+f98ffvl1vrGf8Ajfv3WusZP5vx/vv9b6+/fKnXusZP+x9+4V691wP0P+9f737917rGT/xP+8/7f37r3WM3/p/vv8P9b37rf+Hr/9Df49+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde96Ir17rr3QinW+uiLi3vR+XXusDLa4/3xHvYPXuorpb/W926v1DliDX/wB4P/FfexjrwNOmmenve4/33/G/dq9XB8+mGrolcMCoI/x/33BHu4PDrYPSMyGLI1EKWXn8cj/XsL+3Qa9Oq3SKrsd+o6R/tvpz/h+fbqvw6cB+XSNrKEgnj/ePp/vre3ger/b0l6ujIJsv+2/3x928uvdJ2ppvrxY/63vRx9nXqdMdTT/Xj+v/ABHvRHHPWvOvTLPFb/iv9f8AifdadVIr9vTXNF9Tb/Yf8SPdSKYPDqtaY6bZY7c/j/ff7z7rSv29VI6b5FP1H+9f8V9186HrVKGnUN/98fz/AK9/dD02cfZ1HZiL/wCP+uD/ALH3WnXqVoesBksfr9OP8PdtPXvy64iUEn1AHj/ffW/196oevH59c/KR9fp/j/vuPeq+o61X065Cb+h/31/x9D73+fVvn1zEv+J/2/vdfUY69UevXjKeR/Sw/wB9z73UdbBr9nUeUAjUhsfyPpf/ABvf36vl16vr03PKy8MCCL/X6n/W/wBj/vHvdAQD1YHHHrry3/I/3j3vPXqj168JyPyRz/sP+K+914db+fWUVP0vz/re9V9DTr1Osy1J/wBV/vP9R/j72a+nXsjqQtSP634/P/I7W9+/wda/Lrn572/3wt/xoe/Y9OvYPn1gcq3I9Lf7b/Yfn+vvXDHXvz6hSEg2YG344/x/2PvfXvQ9RJOb2sf9f8+9de+fTfMqsCGsQeCGFwb/AIP+v71xPWukzX4hH1PT2VvqY2PpNv6H8fX6D3uvl17/AAdJCqpniLLIjKR9QwI/2P8Are9Ur17pkni+p49+I9emz9nTRPEebXsf+J/23PvRHVgRSh49NEymxFrj/YX/ADyQfxYe9cBWnVqVr6/Z03Sj882PPP8AiAP8ARx71SmOPVeODx6gSJ9SP98P8feqfs6oR8sdRG/2A90I6rQ/l1HcX/2H/E/U+9da48Oobqefrfn6fQ/j/D3scM9bB416huPr/X6/63vRGB1ogcR1Hb/ff7x7rnqnDrAw/wB4/wB9x79XrYPUduf6X/5F/wAT72R1YjqOxt/X/D/fW96II8sdUIPWIm3+9f77n+vvXHr3HrEx/wAf9h/tvfv8PXs+fWIm4+v+HP4/2/v3XqdYmNgf+N/Un/AE+/U62B5dR3a4vxwSD/Uc/T6Hn/Y/j3r8X5dV8xQ9Rma9z/vH9P8AAf4e9/LrfnjrCT/vv96+nv3XusRP++/31vp7959e+Xn1hY/77/fW9+631jJ9+/LrXDrEx/3j36vWuHWJj9f+I9+631iJ+v5v/vHv3XvTPWIn37j17rEx/wB65/1v8f8AH375de6xEjn/AH3/ABN/fuvD16xMf9v7917rEx/33+9+/Yp17PDqPI1rf0uvN+Pre/AJ4t72P59e6js35/1z9fpf+vH9Px71nh/qx17gBQ9YCfz/AL634P19+9R17rGx/P8Axv8AH0/r7917rET/ALfjn/if8Pfvz69x6wk/77/W/wCN+/fn17rGT/vv999Pfsde6xE/X/ff6/4+vv3XvLrETb37j17rET/jx/xv/H6e/de6xE8/8a/w/wCN+/de9esZP1/2/v3XusRI/wB9/jz/AK49+691iY/776+/Dr3WIn/kR9+69/g6xk/Uf74fT37r3+DrCSB/xQf8R7917rAxt/UfqP0+htfi355/P+Pv2r5/6vn1rz8qj/V/q4+XUZmJ5P8AxH+uf6X9+pTrYHWEn/ef9f8A2/8Ar+9nr3XAn/W/x/H++PvXXuOesRP/ABP5/wB99PfuvY6xFvfuvccdYyePfuvdY2P9Lfg/7b/H37r3WIn37r3WMn/ff4fT/X9+8x17rET/AL7/AF/fuvDrGT/vuf6f737917HWMn/ilv8Aff6/vx691iJH5/rz+f8AY8+/cevZ6xk/8b/5H7917rGT/vv95/1vfuvDrEzW/wBh/sOf6f4g396oD1o4p6f6v9X+rMZmJvz9bf7H+v8AseB/tvexUD/V/q/b1s+VOHWE/wCv/t+P959+69/h6xn/AH3/ACP37r3WMn/W97691jJ96+fXusZPvw9fLr3DrgT/ALD6cf6x/wBj7917rET/AL4j37rePPrgT9f9jz/xF/zx791rz6xk/wDEe/de6xn/AFv955t9P9t798uvcOv/0d/j37r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3XXuvHr3Xvdet9YW+p9+691jIv72Otg9R2W3+t/vXu3VuoskYI/w/r/T/AI17917prnp73492B6uD0x1NLf8AH+F7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cWN78/Q88+/Zwf8AV+3rxGCD/q/1f6uPUdjf/Y/X/fXv9ffs+vW/s6wsf6/776+/efWseXWMn+v++/P+39++zr3ljrCT/vv9v+ffuvdYyfrc/wDE/wCHHv3XvX16xM3++/x49+p17rEx/wCI/wB9/T37r329Yifz/vv+I9+69/g6xH37r3HrExv/AL7/AB/wPv3XusZP+P8Aj/j798uvdYif99/vdv8AY+/Hr3p1iJ/r/wAj/wAffuvdYif6fkf6w9++3r3WIk/0/wB9b/be/da49YmP4v8AW/B/3njj6gf19+Pr1s4yeorki/P+wB/178f4/wCHv3Edex5dYSf9b6/n/iffuvfPrESef6+/de/wdYifr/xP++/w9++XXvn1jJ9+691jJ+v0/wB9/wAUHv3XusRP++/1uffqeXXusRP+8f77/Hj3s9e+zrGT9bf77+v4t7117rET/vv8PfuvdYyf9649+/Lr3z6xk/77/W/r7917rGTxz/sPfuvZ6xk+/evXusRP/Ix/tvfvs49e9MdYmNv8Tx9Pr+T+f8B72OHXgOsLMOQeOeb/AOxP1/s/8V96/wBnr1MAHh/q8uo7Nf8A33+x/wBgb+/f4OvU9OsRIH++/wBb37j178sdYyffuvdYyf8AeP8Afcf7D37z6369Yyf9j791719euBPH+wP+35/23v3WvPrGf+R+/de6xnn/AH3/ABX37r3A9Yyf6/W//FPfuvUz1wb/AHvj/G/v3XvXrgf6H/jXv32deHWIn37r3X//09/j37r3Xvfuvde9+691737r3XvpyffuvdYWa/8Are/de64+/de697917r3vXXuve/fl17r3v1evdeufwffsHr3Xdz/vv9t/vHvfXuvX/px/re/de69qP0v71Qde669769117oePW+uJ/wB7/wB7H09+HWx1jIuLe7dW6wkfg+/de6wSIDfjg/7x7117pvlh/qP9Y/1/4ofdhnq46Z6im+vHu4PW+k9WUKuGDLcf717uD1sHpE5LElQSBdf8ByB/jb8e3Vbp5X6Qtfjf1en/AHj8/T28rfPHTlekbW0FtXBt/X/ivH9fboNerV+XSVqqO1+L/Xj3sj59bPp0mqmlIJ/1/wDff7371/h60RUdMNRTkXNuDf8Aw/5H70R+3rWOmaeH68f8T7bp+3qrCmR00zRWNx+Pr+f95/I91I9eqHpqlTk8c/7171SnHrWOm6VLX/4r/viPp7qQD1Wnp1AkH4/p/wAQP6fX8e6EUPVfl1AkFj/yP/C1j+ffj5HquRWvUYt9Tf8A1v8AYD/W5969BTrY9a46xGY/kAfg3IPP9b/j/iPe+qkVoQTXrvzf1/3n/Yfn/Ye9Up171p12ZbfQ/wCvfn/ePeuOOvYzXrmJzx/X6Hn/AI0ffvtHXj8+HXfnBueb/wCw/wCNe/cOBx1unoeuLur/AKhf/D3vr1fXqBKjLcqCR+PyR7sCPPqwNPs6hGQ35/2Pu2OIPVga1p10ZD+Df/Y/7D3odaNfMZ668xFiCf8Aff73b3vPWuuQqRbkkEf77/H8e/ft63xHEHrmJ/obg/054/1rf4X96BPWvlnrvzm55/2H+H+wPv1a9b8uu/uARyf9v9P9te/59++zr1fljrhJpYXUgEfj8H+n09+rw69U+mOoMjleDc8/nnni35/31vfqfPPVfOlc9QpCL/Wx4seRe3H+8+9cet+XDHUCVdQKsFYH6ggWtf8A2Hv3XvTPSdrcYkgZ4OGJJKEmx55IP4t799vDr3yPSUqaZ4yyspU3+hFvpxcf639fp719vWumeaO1/wDff7f37rdOFR02yJ/gf9b6/n/efevl1U56b5E54/33H9P9j78QCM9VINaUz1EcXB/B/B9t5HljqvUR7jjj/iPr9ffqDj1rqK6g/wCP+H+w+o/2PvwPVqg06iOLfQf8U4/Av+T79/g69XyPURvr/rf77/X9+IB60RTI4dYHH++tx7qVNcdVpTI49RX4/IH1/wB4/wBf3quc9erQ59eoch/PH4seLgW/p+P+K+9kCuk9bpinUVr/AF/3n/eefr7rSn2dVIp1hY+/da6xMf8AX/1/95H0P49+631iY/74e/da6xMf9hY+/de6xMf95/31/wDYe/de9esRP++/1v8Ab+/de/w9Yif99/xHv3XvXPWIn/ivv3XusTH/AH3/ABT37HXvs6xE/wDFPpf36nXusTH/AH359+/wde6xMfr9T79jHXvT16ju1r8/Qiwvb/iL6uf9h78M0xjrWP8AV/q/1U6jMw/1vqPr/U/S30H+w96+dOt9YSeP9v7359e8+sbH/Yf8R7917rEx/wCK/wC+H9ffutcesJP++/4ofe8dbIHWNj/vXvXWq+vWJj/sP+J/p79XrfWNj/vP59+/Lr3WIn/H37j171B6wsf+R/4f8i9+691jJ/334/3w9+691iJ/1v8AXvf/AHk+/de9OsZP++/1vfuvdYWP4J9++zr3WO/55H++/wBf+vv1PMde6xE/63+HP+8fn37hSvXvs4dRpDz9eB/h9LmxuOPqD79nOetV4ileo5b/AH3/ABP19+NT1vrET/rf7b/X9+/wde8+sTH/AB97zxp17jw6xk2/33+t9R71k9e6xk/X/iv+9j8e/Dr3WIn/AH3++sB7917rGTyf99/hb8f19+z17rET/vv98ffuvdYyffuvV6xk/wC+/Pv3Xh59Yif9t/sPryf+J9+691jJ/wBb/D/D8+/fZ14+fWMn6/7b/kXv3XusRJt/j/vv95Hvw49e4/Z1wJ+v++/417917rA7D+um1wf9fm30N7C1/wDWPvWPPj1v8uo7t9P8B/Un8WPP1/HvdcnrQBH29YTzz/vv9iPr9ffievV6xk/19++zr3XA3/H/ACP/AHv37r2MdYif+Ke/de64E/8AEf74+/fPr3lXrET/AI/7x7917rgT/wAR/vJ9+691jJ/Pv3D7evdcCffuvdYyef8Aff7fj8j37r2OsZ9+/Pr3XAn/AFv6f8j/AB79177ev//U3+Pfuvde9+691737r3XvfuvdYWa5/wAB/vr+/de64+/de697917r3v3Xuve9H7evdde6/l17r3v1evdd+9/4Ovde97r17r3vfXuve/de697917r3up691xP0/wBbn3rgadbHXAjk+9jqw6xOPz/X3vrfWMi4sffuvdR3T6qf9v7917qFJF+D/wAj/wAD7t1fpqnphY8f8a92B62D0w1VIOeLj3cHrfSQyOJDhmRbHk6bcH6/T+n+t7cVunFb1PSAyGMI1XWxF7i3P0tz7eVungekXXY8i/p/2Fv999PboavVq9JGsoiLkL/yP/b+7U630mKqltew96Pz69Tj69J+op7Hgf76/vRBpnqp6ZJ4T/T/AH3+v7qR1Ur5jpnni/Fv99/xS/upx1Sgz01zRkXuP9fj3Qj060R01yx/0/33/Gh71xweq0r8Qz02yi39Pyf9b/jXPutOPWqYNeoEo0/T8/4f7ckke26E/Z03TjXpvc8n3YcOvGuOsWu3+H+x/wBa/vVetUr14S/4/wCtz/xT3rHXqkfMde8vP1/P+tY/8R78KcAet1HAjrIJf6nn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AN5/5Fz79k561jiD1k8quOT/ALz/ALH/AF+PfuHEdbz656wSalF19Q+p/J9+BHn1rqKZAeDxew/r/vre9Y49eIqOsEh/qB/vvr/X3r88dV+XUGeJJlIkF/6N/aF/6H8W96IB4daxkdJ2roZEuyetR/tx/rgf6/vY+XWvz6YZk0hv8AeD9fpc+9H1HDrXE0r02TJwTb8nn/YEA/QC5H+3HHuuRgH8uveVSK9Nsinn+vP+396/mOtHFOob8cH8f77/AGPv3W+Hn1FkUG5H+wt9b8/6/v35derTh1Da44/5F/vh72OrAg8Oo7H/AB/335/p731Uj9nWFhf6f8a/417qy+fn1Ur8uori9/wf99/r+6ZXB60KjB6jsSPe8Hq2DTrA/wBP94/2Nvfqdap1gY2/2J/3kf7fi3uufPqtOsTH6/X8/wDI/fuvD7OsRP8Avif6+/Zz17rGT/vh/rc/n37r3+DrA7Ef6/P0/wAOL88Ec8/09+rn5de6iuxvYgD6345555P5969OvYrUHrCT/vv63/3j6e99b/LrCx/2H++/r791rrET/vv9h7917rET/vv8f+Ne/fn17rGx+v8AxT/iP6+/f4OvdYSf97Nrf8V9+691jY/U/wCPv3oPPr3pXrET7917rET/AL4/7f8A23v3XusZP+w/5Fz7917rET/vvwffvLr3WIn/AH3+29+691iJ/wBf+v8Aj/Tj377evdYifx/tv9gffuvHrExsCT9Bc8W/3349+HXuo7vf6D6EXN+SSLjjgXNvfjWlDwp140406jsf99/rf7b37r35dYif9tz/ALz/AMa9+6959Yif9v799vXusZP1/wBc8c/7f/X9+691iY/77/fH37r1OsZP++/3r6/6/v1OvdYz/rn88f4/737916vWIn/fD+nH+x9+68Pt6xE/X/kf+8+99erTrGT/AF/33HvX2cevcesZP++/3v8A23v3XusRP+9+9/Z178+sZ/4r7117rGT/AL7/AG3v3Xh1iJA/3m9/969+/wAHXuPWFje/PP44PP8AUD8kgfX37PHy61TyPDqOzfn6/wCvYH/X/ob+/AeVcdbBI4HPWIm4/r/vre/der1iP/E/776+/de64E/77/Ye/fPr3n1jJ/Hv3XusZP8Atv8AivH+8e/de6xk/X/Y/wC+/p79jy691wJ9+691iJ/3n/ff737917/D1wJ9+691jJt/xv8A3xHPv3XqdcCffuvE9cCffutdYyf99/xX37rfy64E/wC+/wB5/wBf37r3z8+sZ/P1/wB9+f8Abe/fb17B8uv/0N+W/u3TVR13711vrsMw/N/9f/fX9+691zEn9R7916vWQMD9D791avXfvXW69cGP/FP9v7916vHrH791vr3vXXusDG5/3r3U9e64+9db66LAf8U9+691w8n+H+8/8a9+6911rP8Avr/8Qffuvde8n+H+8f8AFfe+vddeT/Dn/b/71x79/g6313rH9f8Aiv8Arf4e9jr3XIN/Q/0+n4/2H9fdut9cxIfzz/vv95PvfXuuYcfT6f77n/D37rXXdwfp/wAR/wARb36nW+ve6nrfWKT8f7H/AIj37r3WP37r3UV/r/vv6n3scOrDrgfp72etnqOR9R7917qJLH9fewa9bH8+mqenBuf94/33492B63wFOmKppQb8fg8e7g9br0lMjjEmU3Fmtw1uf+Qv6j3cNTpxWp0HeUxDRswKfW9iOVPH49vqwPTysD59IPIY8jUQv9eP6f8AGre3Aerj0PSKr6Ei9hb/AHn/ABH+v7sM9boDw6SNXSEFrjnn/G/+xI9+9B17h0nKimIv/tv9h70QDxHVSD0x1EP14/33+I/1/dSOmyPMcemWeG1/97/339Px7oRXjx61QEY49NE8d/x9Pobf737oRTFOqevTVKhuf683/ofdSKfZ1ojptmjuP99/vP0/PvXD7Otfb02yL/t/8f6j6391Ip59UpTPUFwRf/eP+J/2PutPTqpHn1HY2v8A77/fce2+HTdKYPWFmA/31/6fjn3vPW6V6xF7cj+n9bX+vH+sffqnz4de68JSOD+P9h/iP9797qOvV65ib/bi3+w/3v6+/VPXgR9h67M3HDDj6/6/9CR9D72CK0PHqwPkesbSDkfX8/1N72vxyOPoPeyeOadeYEH59RZUSX68N/Uf1/xH0PutfIHrQPlTppmR4jyOP6/g/wCxA97GerinDqKzXB+lvoLH/ebX97oRUjqh446jFuD/AMRf8e/ZPVusLSAEj+v5/wCK397zTj17H59YWe30PH5+h/4n8+/Dy62PLHXDzEW/Nv8Aff63vfCvW6Hj1yFQP6lfp9D+fof969+r8+vZHEdZlqfxqH+9f8j9+/LqtQeB68zq44sD/X/iL+/enWzXPUR3K2BFvyeeCP8AYf6/v3Hzx14Dzr1haQH/AAP+v+P9f3r/AAdbPl1HZvr+f+K/7H8H3qnD16rTzHHpqq6aKQEj0P8AhlAIJ4uCLH+v19641619vDpM1VO8Zsy/8hfUEcD6i45/p71Q5zjrVP5npplT62H5/wB9b34eRr1rh1AdODbn6/6496/w9a6guLcj6f776+/DP29b6iyKD/vv+Nfj37r1fsr1BcEcf8a/2H+v731cGp6wMf8AeB7317rC9j/vuR70QDx60RX7eoz8f7768+2yKHpogg/LqOw+tv8Abc/76/HvwPW6+R6wMf6+98cdb6wN/h/jf3o+fp1UinDh1gJ/31/9f8+9da8+sTN/vf8AsPzf8+/f4etHA6iuw/H+P1/p+OOP635Hv2fxD/V/qx1s/aa9YGP9fz9f68n/AB/r799nXusTH/Y/77/D37r1esLG/wDvv+N+9/4evcOsZP8Avv8AiLe9de6xE/63++/3r37r3WJj9f8AY/778j37r1OsZPv3+Hr3p1hJ+v8Avr/8i97/AC691jJ/1v8Aff7x7117rCT/AMT/AL4n3vh17rGx/wBtyD/r8e9de889Yyf99/sP949+691hJ+v+H45/P5+n+P09+68f5dYyef8Aef8AeffuvdYif99/rfXj6+/Vr17rCW+oN/8ADi4tbkWHP0/PvRGK9e+zif8AV/q/2OorGxIvwebcC/8AiB+L+98cnj177OsLH/b/AI/3w9+69jy6xE/04/3r37r3y6xk/j8f8V/r9Pfvn178usV/r/h/sP8Ab+/de6xk+/de6xsf68/8j9++Y631iJ9+611iY/j/AG/+H/Ffp799nXusZPv3XvSnWMn/AHv/AGH++t73x696dYyfeuvdYyf625/33/E+/Dz9Ovfn1iJ/33++49+691jJ/wBh/h/yK3vfl17j1iZrWH9Twf8Afcnm3vXzHWxX0x1HduT9L8cg8X/rz9TY/wCwHvVAaenWq4II6wE8/wC2/wB9+Pe+HHr3mesZP+3B/wB9z7917h59Yz/vvqP959+691jv9f8Aff7H/D37r32dYyb/ANf959+691jJ/pz/AL1/vh78ePXv8HWMn/ffj/ePfuvfZ1wJ+trW/P8AiffvTr3WMm/1/wBb37h17rGT/wAV/wBt/j799nXuOD1wJPv3XusZP++4/wCKe/de+XXAk/7f/H/be/de49cCf98ffuvdYyf+Nj+n1/2B9+691wJ/339Pfv8AD17r/9HfjJA+vu/SfrGX/oP9v7917r3kb/ff74+9U63U9diT+o9+6tqHWQMD9D/sPz711vrmGI/J/wCI9+p1utOvEk/U+/U69Xr3++/1vfutg9cXNh/r/wC9e9db6w+6nrfXFmsP8fdT17rD7917riWA/wCKe/de64mT+g/33+t791vrhr/wH+xJH+9+99bHXvJ/h/tv+Nge99b69rH+t791vrsMPwfe69a65hz/AFv/ALz731vrmHH5Fv8AW97691zDA/Q/7b6+/de65am/r/xP+9+9de66+vJ9669117917qPICG/wPI/4p72OrDrCxsD/ALD/AHv34+nW+sPvfXusTgfX3oHPXq56hyKPd/l1vpunhB+g97HW+GOmSopr3493B63X9nSaraFJFKutwf6/jjgj+h92B9Orgny6D7LYbQGZRqTnkDkfn1W+nH59vK37enlauD0HeRxxBb0/k/63+w9ug9XB6RNfjyL+n/jX+2/p7vWuOrdJGsoyoPp+n/G+P9f36metU+fSZqqUi/H+8f19+PWqU8umGeG17j/ff0590YdUI8xx6ZJ4bX491z59aOemieK//EH/AIj8+6EU88dUIpXHTRNGwvxz/rDn3UqPLqpGPl02zR3+n155t9f9f/W91p+zqv8Ag6bJE/24t/h/hxf3WmOq/PqDILH8/wCt9P6f7wfdStePHqrCoqOob/X/AHr3Th1UEUp59RmJF/8AW5/2H9f6e7HqtOsHlt9eP8b/AE/2H596Pp1utDTr3lH1v/sebf65sOPfqHy69TA9OummIBsbi9uAfr/iTe/HuoJrkdaFPTiOuhUfW97/ANSfqfqfqPdseXW/WnXITKf8Dz/xr/be/EV4HrwzjrGzhr/m/BB+h4+vvYxx63w6bp4PqYvpz6T9f9geL/63v1Rw69XPTa9xwR+eQeDfm59+Hy6utD9vUVjcW/2H+v7sePWvPqMzEfT36vWx5nrCzn+v+x4/3w97+fXqKfLrEZiDa9/98f8AYX96PqR144zXr3mt+P8AeQT/ALH375jrxFfPrkKi39r888/8i9+qRjrXWYVF+GFx/vv639+69T0OesTEWJU3F/pb8/1/IIv79Wvl1vI+3qK8gsRe3/G/68cDj3446rU1zjqK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AEP0Yf7H+nvx9D1XpkqaRkBZPWo/p9R/rj/D3WnmetAft6Z5F/w/2P8AT/C/vVK9eoDjqDIv+8/Q/wDEe/euMdeBxTy6hSLb8fXn/e/949++zh1vhw4dQnX8/T/ef96+vvwzWh695Yz1Fbj/AH3+8f7D3uvVvs6xMfx9P6/T+pv7917jjrA4v9P9t/vvyfdSvp1Rl9Oorfm9/wDerD+v+x914Y6pkGnUSQn6fTki/N+fpxa44979c562MkDqI51fX+n+2/P+259+p1ug4U6wN/xv8/7f3Ujj1UilK9YGP+t/Tn37rQ6xMeD7917rGTz9f9f+n++59+691iJ/33+39++XXvs6xE/74/8AFPx791716xMTb/fH/evfuvdYif8Aiv8Avv8AY+/de/PrEx/p/U+/eeeveXWMn37r3n1iJ/2H9PfuvdYifr9f+R+/da6xk8fX8f76/v3n1v16xE/635/33+t79+3r3y6ws1rX/P8AsPfvXr3Ud2H+BPIB4/oBc/2T79/g69nIr/qPUcn6n/ffn/eB79+fXusR/wB9/sf979+/Pr3z8usZP++/437917rET/sPfj17rEx/w/2P++/HvfXusZPvXXvn1iJ5+o/3x/2Pv3XusZP++/Pv3r16vWMn/WP+3/3j36vXqefWIn6/7H/ff7x7917rGeP99/vX+39+69XrET/vXH+x/Pv3kevdcD/vP59++Xl1vrGSPz795jrXWK/++/33+v79149YGf8A3sW5/wB5tf8A4nn375+XXvI1P+r/AFfn1HY8kg/X/YfX+vP19+zwPl14eXqOsZ/339f99f37rx6xE/0+nv3+Hr3WMkc3/P8Aj/h/xHv3XuuBP/E/74e/de9esZ/P/G/fvMde9esZPP1/3n37/B175+fWMn+n++/4r79178+sZI4/4r/yL37rXXA/77/jX9effut+lesZPJ/330P5+nv359e+XWMn/ff77n37r3XAn/fcf8b9+691jJ9+691wJ/3j/ff8T78PXz698uuBP+x/x/5Hf37r329Yyf8AH37r3XA2P1v/AMb97/w9ep+3r//T32fbnSPrixsPfutj16xX96p1vUeuLPb6fX36nW69cPIfeqfPr2oenXYkP+Hv359W+fWVJv8AH/iR/t/eqdWB8j1mD/1H+29+6t1y1r/X/ff71791rrpm/A9662KDrH7116vWBjcn3o9b6xO1uB7117rEWA+vv3XusJcn/ef9h/sTf/inv3W+uBYj83/w5B/4obe99bB646/8QP8AY39+p1bP5dd6z+G9+636dcvIf8Pe+vdcvJ/h/vv949+631kEv+1f7f37r3WQSf8AIx7317rIJP6H/b/76/v3Wusmv+o966313rH+Pv3Xusbtxx/vv99f3sdbGeo7Akce99W6wH34nr3z6is1/ewKdXHr1jJA9+rXr3y6wNyD+PezwHXuoMqg3H192638z001EFwSBcfkfn6e7A/t68PMdMFTTXv/AI3936tXpJ5PFR1AYldL24e31/wb+o92VqdXViPs6DXK4h4yyulvrYj9LD+oPHt4N6Hp4GvA9ILIY79Xp/rz/vh/T24DTrfSLrqAgtx9T/yL3brdekrV0lrgg8H62/41/X375+fWiPTpOVNPpuLfn/ffX3UivDj1U549MVRCRf8AI5554v8Ai39PdSAfLPWqeXTLNFb8X/w/4kf7H3QqeNemyvr00zQ/X6/1H/IvdT6U6rTPz6aJo+Sfz9b/AI/2H591I/Z1r8umyVPr/vr+6kUr6dVK+vTfIp5+v0sf99z7oRw6aYEZ6gS2v/T+lwfyDza34v7r5H161g4rnpvdiABcfk8AcfQfUD+g96xVsZ63g5p1Ec2H/Ef4c/7H3qnp1oDrAZQPqDb+v++/w974cetBvl10JVP0P+wJ4H+t71jy63x+zrl5bW5uD9b2/H15/wAb+/U61p9D12Jv999R/wAV9+r6jr3XITKfz/vv8L8+/f4Ot1p5dcZHUix/pz/Sx+v+t7sOBz1rjw6bpoAeY/r9dJ/6JP4+vupz17pqkBueCCPqGt+f+Iv72PMV68fLqI/+H1H++/r70DQ9bB4V6iMxsf8AY/71/sfdycD16150Jx1GYkC/+wt/vv6H3qp4dWFK06xeW35NuB/xF/fiD+fW9J9euPn+vN7/AI/tLbg2H+A/29/e60rXj1rNBUZ64+cgnnj/AF+T+L/7H37y4U68OGOPWUVHFr8fm/8AxX37GQet8Kg8OsbP+VP+wv8AX+v1v73xwOtdp8+sLTf1HP8Ath/xPutD69eCDybrBqv+f8P+J+n+ufeyfI9eI9OsbN/Un/X/AMR+De/HvVP2da49Ns9PHKWNtD/1twR9bW/Hvx8qnHW8Ux0yTwvGbMLfW3Fwf6H/AFveiP8Ai+q0znpukT6/70f6/Tj3WlOtZHUF04PH/EWP+P0P497rX7etj5HqE4/B/wBv/Tj/AG/PvdOrfZx6iOLX+v8Asf8Aff19+Hp14dYCf9sf99/r+99b6wPyLD6/g8XH5/Nhb/be9EV6qQDx49QZD/WxuP8Abf6wP5J/2PuhFKZz01QjGadRG/Nv8f8AH8/7H6+/A9Wr5nrAT731vrC3+F/9Y/73/h7rT061TzHWAn+v++v/AF/PvXz6r606xEj/AH1/9v8A7H37r3WIn68f8T/xri/v3XusTHj/AIj/AHv/AHv37rfz6xlv99/vXv3z8+tdYif999f94+vv3XusRP8Avv8AiffuvV6xk/77/W/3v37rXGvr1iY/77/ePfut9YmP+P8At/8AY+/efDr3WJifr/vvr79175dYibc/4cn/AFhyT/tvfvl17rA7fjj62/P9b/X/AGH+xv79StetAkZ8uozN/r/65/w/Jt/Qe/DreB1hY/7D/fD/AG3v3Xs9Yybn/if9b37r32dYif6cD/W/2A/Hv3Xs9Yyf99b37r3D7esZP/I/8P8AH37r3WJj/wAV/wB9/W/vw69+XWMn/bf77/D37r3WIn/H/bD/AHv+vv3W6fLrGT791rrGTx/th/h79XPXs9YyffuvYHWIn/eb/wCt/vPv3XusbH/ff4/63vw69/g6xk/19+4cOvenWBmvYC97/j/XH4Nrj3vh16vHjw6wOxBPFv8Aeebcn883/p7rWop16tR/q/1U6wH/AH3++/x97zx691jP1v8A77kfX37r3p1wJ/H5P++/x9+69jrESLcf8U/3j/H37r3r1wJ/2Hv3XusbG9/999P9549+691jJ/x9++wdewOuBI/3n/ff63vXzp17rGf8P6+99e6xk/77/D8+/de4HrGT/vv99f37r3WMn88D/e/99x73175V64k/T/ff8R711rrGT/rf7f34db64E/1/5H+f8Le/U6959cCffuvU64H/AFuP9v8A7f377OvH7esZP++/31vfuvdf/9TfYuP6+3OkfHrExuffutn064E2F/futdYCfz7917j1hZif9b37rZ9OsesD/H3rrYJHXISj/H37qwNfPrMk9uCf9j/xX+vvXVgT1JEt/wCh/wBbj3rq3z656x7917rxYfj3rrfWH/H3759e8+sBPJ919Ot9YGNz7917rCzfgf7f37rfWFmH+uf999D+D791vrgX/wAOP6/X/b/Q+/dbz5ddaxb6jj/YXt7316px115P8OP9f37q3z65CX/E+/de/LrmJf8AH/bj37r3XNZf98D7317rKsv+P+3/AOK+9de6zLL/AK/+9j3vr3WQSA/0P+t711vrkXH++/5GPfutjrGXH++/41731uvy6wt6gfxf3vrfUOT08H/ffU+98cdW8uo5N/fuHW+HWJ3A4/33++t78Knrwz1GY392x1Y4FOo0gv736da9Om2eEG5A/wBf6e7DrfDHTHU0454/5H/xB92H8+tjpN11BHMrI6Bgb/X6g/W4P1B92Bp1YEjPn0HOXwjR6nVS8fJv/aX/AIOB+L/n28rV6eDA48+g8yONtf03Ht0Hq/SJrqDTf08e7cevdJKso7XuvH/IvfuPWqVHSaqaUjVxx/rcf7b8W96Ir5Z6r55HTBU09r2H0/oP9691+3r329Ms8P14/wBh/vvp7oRXqhXzHTRPDcH+oP190I6b8qdNM0dvr/sP+KH/AGHuvDrX+DppmT6i3+t/xH0/HupXhTqpBpUcOmqZRY/S5P5F/wAWBvfk8cf6/upFMfLqhWhB9emyRSDz/sf99/j7rTy6r5/PqI68G3+v/j/sPeq0OevAgHPUF/8Aif8AD+n+w96YZr14j9vWBif99/rf1914dU/w9Y2Y/wCt/rH/AH39Pfvy63XrrzEfUj/jX+Hvw9OvVPXMSqfoQP8AYjn36p61Xrl5Le9162D17yX/ANb62+n1t/sffj17Pn1gkVJRZhc/hvza3+9e/A9b+zj00TxPET9WU/Q/W3/G/fsGh61x6guP7Q+n5/w9+rXB60ftz1Efkcfj/fW9+HWxUVHUCS45Fhf/AF/wC1ze35H093LAYPW6g4rnqEWt+f6fS/8AW3+29+118ut1p1xEpH0P/Ivp79g8OvYPHj1zE/1+v+w+v+Hv2Rjj1vPCteuYn/1j/vf/ACK/v1AeB60R6jPXIyq3BIH+x+n0/P0/Pv3cOPXuB6xtcAkG4+pP9P8AivvdQePXtRHl1iMh/P8AyP8A41792+uOtEcR1iZgw+v+sPpf/kXulSOIx17PUdyGBDjUOeDzb37/AAdexQdNU9L9TH+fopIP+2Nrnge/U/Z17/B0zzJYnUCCP6jn/Y2969Oq8OoEsYP1Bv8Aj/Ye/A062P5dQXUre/8AXk/09749bweI6huv10nmx/33596Jpx4db4ceHUOQ8fj82H04IHP4/B97/LrecdRW5+v5/wCRn/D36gp1oiv29RnBH+IH+8e6EU+zpsqePl1Hbnn/AG3+w+n4PJ91HDrQP7OsDG3Hu3lXq3+DrA3P+v8A7768+/H+fXiMdYG4+v8AvHutOqH59YiffuvdYief+N/7H/be/de8usZP1Pvw691iJ/xPH0P++Pv3qevZ6xMf+Nf7b/iPfuvY6xE2/wALf7f37r3WIn/iP999ffuvZ6xE+/de6xk/77/jX+F/fuvdYHNuT/rD/fXsLH8n6e/VzSvXq0p1GLf69/8AEC3NrEf049+NK4GOvUHADHWFje/++44v79170x1iZvqffuvdYifx/j/tre/fPrfp1jJ/4n/iv+w9+616dYif99z+f6fX37r3DrGT/j/vv+R+/de+XWMn/ef99/t7e/de6xE/W30/33+396691jJ/3w97691jJH1/1v8Ab/n/AGHv3XusRP8Avv8Affn37r3WMn/ff1+oPv3XusZP++/p7917rGT/AF4J/wBh/wAb97NOvH06xMR/t7/7wP8AYEm3vX5de8jnrAzfW4A+lx/sQOSOf96+nv1NNAPL/V/q+09b4UoTnqOWv9T/AL7/AHj+nv3DrVT1jJ+v0/4p71UenXusRPvfXusZP+2/p/Q8e9deHz49Yyfx/r+99e/wdcCT/vv999D79x+3r1OsZP8Avv8AeffuvdY7/X8f71+f97uffvs68euBP++/5F7917rGT/vvx/r3/wAffuvdYyf99/hz7917rgT/AMb/AMP+J59+691jJ/w/2Fx791qnXAn37q3WM/8AFf8Aeh+P8ffgada/LrgT7917rh/tuef9Yfn+l/fuvf4euJ/r/vuf6+/cOvV6xMf9f888fg2P+xBPvx4fPrw+zr//1d8zWf6+36DpF1yv/wAi+vvVOq58+sbPfj3qnVq06xueP9f3rrYPn1HdrD37rQPn1HZrf6/v3WwQePWMvb6n/e/eurAnyHXQm/x/2/v3W68OHWdKi35BH9Pp/tr+9dWBpw6mJOCPr/t+f+Nj3rq9a9ZRJf8AAP8ArH37r3Xi9/8AD37reOsLGwP+PvVOvdYGNh/vv99x71Tr3UZmtx/xX36nW+sLNb/X96631HeQA8m5/p/v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n3uvy60D115x9fyLng24sRwQL3H/ABX37j55635gHr33F+Tb/X/33++HvVPtr1oCmBw65eS/54tx/vX+2v7917riz2/x/wBYf7x/Q+/dboTnrGZgbj6cHgj68/X8+9UpSnVc0HUdn5uP99/T34HyPWwcUPXEuG/w/wB5sPexjPWx8uoU8Ctew0m55H0P+wH9ffvXrw+XTPNEyH/fW/2/9PfuvD+XUF1+tuD/AE5t/U/X/H/Ye99b+fl1Ddb/AOBH+H+8ke/D1699vUV73sR/xT37rx6isD+P+K8/71z7pQ5PVCp9Oo7Ef7H+n+++nvXDqlSK9YHFvpyP9j73Xq9a8ePWFj/vufr/AMR73TrxHD16wsf8Rf6+6keg60Vx2jqIzWJFr/4H6/2SQb/m35/PvRyAeqkeVM1PUdmP+8/T8X/w/wBt79178usbH/ff77jj378+vf4esRP5+vvx9OvdYif+K/74H+nvx69/h6xk8/X6fU/8U9+69/h6xE/717917PWIkf74cf1/21/fs9e6xk/7xb/ff7f3vrw6xk/1v/T/AA/x96x17rESf9b/AH3+x+nv3Xj1jJ/334/r/vfv3Xv8HWMn/X/5H/X37jw691jJ/wBv/vr/AE9+691iJ5/1uf8AfH37r3+HrGT/AL76e/fLr3WBn+n54/qBf6cWFyD9P8fej59eGPt6js1/6fj6cfQcf72fe+HDy69+3rET/vv6/T/Xt79x6959Yyfz/vv+Re/de6xk/wC+4/r/AIn378utcM9Yyf8AY/74+/db+fWNj/xH+35/3n37r3l1jJ/33+t79+XXuuBPP1tb/evfuvfPrGeP99/vvr7916vWM8/77/itvfuvdcCf6/73z79178+uBPv3Xvz6xn/iLDn/AGHv1evV4564E/77/ev949+691jJ5t/th/X/AH1vfh17rgT/AL3f6f04/wBt7917rgfp7917rGT/ALH/AG9/+K8+/cPt691wP59+6959YGIv+QbAk2JHDD6XAB0m3+397xn0691jLW+n4t+D+Ljn68kn3r+X+r/V/s9eOadYifrbj+g+vv3Xvt64X/2I/P8At/8Ajfv3XsZ6/9LfqI59369TrC6fkfT8j/ffj3vh1rqJIlgT9V/3r3vqpHp03Sx/7f8A3v8Aw9268R02yx/77/iD79XqhHn02TR/kf48f7372D02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n1iJ/wB6/wB8ffuvdcCf99/vv6H37r3WMn+n/FffsY696dYyf8ffuvdYyfr798uvdYyf99/vvr7917rG3+w/r/r+/de64E/77/fc+/de6xk/X6H/AGH1/wAf8Pe6de+3j1wP++/3x96691jP+v8An/iTxwffuvefWM+/fn17rifz/vXv3XusZP8Avr/8i9+69wPXAkfn37r32dcDfg/7Y/6/+Pv3XhTrgTb/AH35/p791759YWYAc/nkfX6Hg8j8AG/49++zj1sjiOsLnmxuLWNvrY2+n1t9f949+/y9VAA4DrCT/T/fW/H+v738+t9cSf8AbH/D8f4e9H59e+zriT9P99/rf4396+XWusZPvZ631xNvr/vv9v79wx59e6//1t/j37r3XFhce9j062PTqMxv/r/n3sdbH8uuJ9768R1GkWx/33+2/wBh731UGnUN1/2x+v8Ar+99X6bpo/rx/vH4/HvwPXumeoivc/7H/iAfdx17HTHUQ3vYe7DqpHTBVQ3vx/W//I/9b3sdUI8+k1VRMhJF7An/AGH492+3qhX06a3kIuPof94P/G/eiOq0p5dRncN9Prf6H/ffS/uhHVTXpvla97/7b/Ye9U8utHptk/3r/ev8fdfXrVD02Tf1/wB9bj/ifeut9NsjEfm3+++nvR69QdQzLpJF/ej1fy67WpINr/7f6/6/v3Wx8unClyTwNdG4P6lJOlv+N/4/j3rq/SopsjHULdGseNSk+oG/+2I/x96691JM9x+b/wCv+Pxb6e9dbr1id7j62H+8/wC+B9+63Xz6b5mFr3v/ALDk/U8c25Pvfy63Wv29NMp4/wBuAf8Aff6/vZyT1rptkJF7/wC2/wB6/wBv798ut9N8khB/w/3v3vrwPUZ5Pzf8f4f763v3yA63XqM0v+P++/2J/p7317rC09vz/vPvwPW+uAqQPqeP9fkf7zz7tnreeuX3HH1v/r/778+/eo62B1yFTz9f99/vHvdet565iq/x+n+w/wBgPdut58+pKVf+1f7f3vq2AcdTYqwf1t/vX59++fl17I6cY6z/AB/17f8AEe/dWB6nx1V7c/77/D37q9epqVI/J/4r/X+vvf2db65tIkilWFwbcX5H+II+h9+z69bB6aplaE3BLJfhhzb+gYC1v+J926cBB64LPb/D/e/e+PW6fPqTHU/S5/oPdSKdeI6m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/jXP096611iY/wDG/wDW9+4de6xMfr+Pxx7917rAZNBA+o45vyP8Pp/h791v/D1kEgP0bn/eef629+61Trvyfgn/AGP9ffuvddiSxt9R9P8AW+n5/wAPfuHXsjj1hlSOUWbg/QH8/wC297r5jqw6aKiB473F1+uofj+l/wCnv3zHWvmOm5xb6f7D/H/jfv1K/b1uleHHqK/+Fv8AW5/2Fve6+vXgfXrAx/PvfW/l1jZv+I/JP++59+69w6wGQg3/ABay82v9P96I/wB99ffs/n5/s68DnhX/AFf6uHXHz3sG/wAfzb/XtY2t/re/fl1v8s9d6xcEH/ff8R79T069Trl5fwxP+HH/ACO3v1TT168CfWvXZkU/U/X6W/3nk3v9P949+qOtagesLcfQ3H1uOeP8f6c+/U636enWJj/vj791rz6xliP+K3/Pv2eHXvl1hL2H++5PvVa0r1qo6jyBHFjx/Q/n6X5+vvfHz63So+fTdLEVNxyD9D/vX+PuvDB61kVHUJhxf/iP9t/r+/HrxFRg9YGF/wDA/wCx96r1oE9YWF+D7916tesB4Nj791rrGw/I/wCN+/de6juwsbi9r3t9Ppbm5/xt79Q8K0696jrAzcHm5tyLf1+vH9m9ubfn34j/AFfy68DXNM/6v9X/ABfUcn83+l/fuvGvWMm/v3r17rGT79177OPWMn/ff71+ffv8PXs9cD799nXusZJ/335/4p791r16xk/77/e/8ePfut9Yz/xT/YfT6e/V4Y69/g6xk/X/AIj/AI17917z64E8Hj377D178+sZ9+691wJ/x/3g/wC9f7H36o69/g6xk/77/jf59+691wJ/33+8+/de64E/639f96Pvx691jJ/33++49+691wP/ACLn/iv59++fXuuB9+691iYix/qPz9bcE/6/0Hv32cOt4FKnHWJibG5FyL/4fgcA+q/+v71UE468PX/V5+fWEn/G/wDvv+J9761T06xk/wDFPyef+Re/de+fn1wPH+3/AOKe/de64k+/de64H/e/8P8Aef8Abe/der5dcSffvLr35dcCffuvdcCf99f/AIn37rRH7Ov/0t+v3fq/Xvfuvde9+691737r3XvfuvdeIuCP6+/de6jEe/DrR6hutiR/sPdqdeHUCVPr/h/vv8Peurg9N8yXF/6/737sD1v5dNM8f1/31j/xv3ev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AA/r79g8OvED7eui5ufof8P68+/EAjrVKjB64lh9ef8AePeqHrVOsTSD+l/x/h/sPftJ/LrwHrw6wMf95/3n/D3vh1f06wuefr/vP++5HvWf29UOPPqO7Agg/ji39b2+n+vf34V68K1+XUJ1/pwf6Wt9OB/rce/efWuHlnqO1wbH/ff8U9669n8uo8gH1/3r+n+8jj37r2PLqOT9f99/vh79178+uBP++/I/pz7917rET/xv+n++Pv3XusZt9f8AYD6/776+/VPXuuB9+691jJ/w/wB9x/sfz79+fXs164E/77/W9+691jJ+v+++v49++fXvz64E3/330/3r8e/de64E/wDIv959+4/Z17rGfp/UH/ivvx6159cCf99/vrD37rf+DrGf6/0+n+8W/B9+698vPrgT/vv94/2PHv3XscesT8XN+LWI/Nr8W/PN7e/V4Dr2eA49YmYk3/1rCw4vY/n+v9Pp78KUJr1sceJqP9X+rz6wsb/71/xr6nge9/n1rHl1wJ/re35/3n3rr3y64E/T/ff7378KU69w8uuB9+691wJ+vF/99/vXv359e8qDrgT/AI/m/wDvuP8AD378utnriT791rrhf/fcf7f34168R8/LriSfz/rj/fcce/dex+XXE+/de49cSf8Aff7b37r3X//W36/d+r9Y3HN/6/737917rH/xr37rfWFjYX/23u3V+sHvXXuvXt/h7917rj5bfS5/33+Pv2OtUHXvKf6D/b+/U61TrizE/U/776/63+9e/da6wvwPr/xPH/Ive69aPUR1uL/7f/W9+Pr17ptlFtV+f9f/AG3v35dWHDptmQEcj/jXuwPVwc9Ms6EXB/1x7uD1sGlOmSoQc/76/wDX34eXVx/Lphqoxzcf71/xX3cdbHHpN1cXB/33P+Pu46tx6TFZBcNx/X/Eg/63v32cevDpIV1NfVxxz+P98bH3sdepwPSMr6S+rj1DkH/iv596x14jpI1UTRsRa3+H4sPof9j70RXqpHn03CdojdbkE3ZTci3J+nupHn59Nlc8Os6zpMupbA/2lP1H9fz9PbbDPz6bK9RZT/vP++591016oR69QZLfj+n/ABX3Rh59ap5dQJRxcf8AFOf8PdTXz615U6bn/wB5/wB9/sffjjPWqV+3qG0mk/W3vWT177euHmt/Uf61z/vHvXp175dSabIvA11N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6rSo4dNkqWv/AE5BH4/417qV6ppII6bJUI5/H+9f8a96x58evfKnUCRAb3+v+tb3Ujh1UjqE4tww4/3u3/FPdCMdVIx1DcWuPqD/ALHj/fD37j1r5U6gyJa5HI+n1+g/x91yKHy6pShB6hP/AE/P4F/qB/xA9+8ut8R1CckE3P14vZbc/wCsCT9P9496BFMf6v8AV/qr1qo/PrAx/P1/J/2/v3Xh5dYibHj/AH3+x9+8ut9cfIQOeeD/AK/0/Hv3WuvB78qbG309+691yEhvzxb6W/x/w9+69135SPrz/vH0+vvYNOthvl1xYq4I+t/weCBe3B/wsPevy611CkiIuVuVuf8AYfn/AB+nv1fPr3UJwRyP6/T/AFv8fz73x8s9bweHHqMx/B/33H+PvXWs9YGH9L/77/be7A+vVq148esR9+J691xJt/T3o8etHrgSf9496HWvs64FgOeP8SeP+Re91Pp1up6wO/B/5JP1tz/UgfUE82v72COPW9RrSgz1gZ7jkcj68k/8i9+19aBoKdYSx5+lv999PfiScV61X59Yif8AY/6/4/1ufdfPr3XAk/4j/ff7D6e98PPHXvs6xsf9v79XyHWyesTH/Y/4/wCPPvXz61TrGeRb37r3UVrgkf0v+bf63v3Xvy6xE/7f8/74+/f4OvZ/LrGT/vv6/X/iffuvfb1wJ/41/wAV9+69wx1jJ/33++59+691wJt/vPP+9fT/AB9+p17rgffuvcOsZP8AyP8A33149+691wJ/23+H+++nHv3XusZP+8e/de64En/H/D/ib/X3v8+vY64H6f8AFPr/ALzf3qvXvPrCx4/VyBa//E2/Gq/+29788jHXjU+WOsJa/P04/H+JJsLf77/Ye9ZAPXvUj/Vw6xH/AIr/AL17917ri3++/wBjx9be/de+fXAk/wDG/fuvdcL/APFffuvdcD/vH9P99/h79/h69/h64E/8R9f8B7917rj/AL7/AH3Hv3XuuJ/23++/23v359e9K8euBt/vuf6/n37r3XEn/fW9+691x/331/2/HI49++zr2PPrgf6f4f8AE39+63Xr/9DfsI/43/vv6e7dXHXXvfXusLCxP+39+691icXB97HVh1F9+6t1gP1P+ufdevdYGPJ9+691gZj9B731rj1iLj+t/e6+nXuuIk/Nre98etUr9vXjJe/Fv8Pp/h/t/fs+vVesLMLkk/77/W9++zr3USYB+foR9P8AH3rh14GnTRMCLg/j6j/kfvY9enB69Nc6g3/33+393B69WlPTpiqY7C/4/wAfx/r/AO2926uDXj0wVC/X/ef6i/u3n04D0nqlOT/tv8PbnWx0nKuK+ogc+/Vp1ccOkxVxfW/0/wAP6e7fPrdP29JWtpxybcc/8T79x+3rdOkjWU36rjji3+8f05496OR8+tFflnpI1tOVuQOL/wCxB/x96/PPVaenTHISp+tiD6SPr/W/+391I49NsnXKOu50Tcc2Dn6c/TVz+f6+6EGnTZXh1lduPwQQD9B9P8Le2yOmqUrnqDIw/wBh/vfupU+nVc16bpR/h/vr+9U49aOM06bplsb/AI/3x/2P19161XzHTfL/ALz70BWtetGo4dRDLYn/AA44v9fz9ffiKefXh6064Go08h/oT+bEG31B+o9+OOtiv5dOVNlg1kmYAkjTIT9eLAPbjV/j/X3rj9nXuPU5pL+rVxf/ABP+P1twD798uvdQpHDXFx+bf737917prm9XH++Hv3XvLh00zfkf1/41/tr+7eY6901TH68m4/qfofe8Z63ginTdIx+t7/0/3n/iPdR8x17gKDqG7kfnn3sZ6rwNTw6jNNcEGwN/8Rf/AI2R73ivWwa5HUZpytxfjn6n/ipHvYI6t86dcDUX/Ite4/r/AMa97FR14Gg4ddpWFTwfrxbk8c/7f3fiOr1r1NirdX0Nj/r8fj3uuM9b86+fU2OtN7X+h/3v8/69h72PXrdeFepsdeOPV/UfW1zYX/x/PuwP7erAk0p04w5A8eo2/wB6/wBtb+vvY+yh6t07QZD6Wa/04/I/Av8A192B62K9PENeD+f+Ke7D5Hq4OMjp0hrr25Bvbn6/8R73Tqw+XThHVjjn6/UX/wBa/vY6uDXj16Tn1w2BIuU/st/Ur+F/1ve68K9XVqddwVpUgXIN+b3+vII/qOR73x8unKg1r0+U2Q5HNj/vB/PH9Peqft690o6XI8j1c2/2P+39660fn0o6XIXt6v6f763vRHWun+nrb2uf9f6/8V/ofeqdVIHTrHOGHB/33/EX966r1zax+lgf6fg+/fb1rqHIgIIsP6W44/4r7t1v7emappgwPH++/wAP6c+9g/Pr3SEz22qfIBmCiKoH6ZQvDfgLKvGr/X+o/wB493VyPs6sGI+zoEs3gZ6SR4poih5INvS4/wBUjWswP+8fnn28CDmvTwOroN8li7Xsp4B+gI92rWtet1/Z0hq6hIJOn+o/r9Pfqdep0lKulIvx/wAVF/dCKnPHqhAPDpO1NP8AWw/1/wDiP9Y+9EevVT0xVEFx/jzY8f7Y+2yKY6oeND0yzxHn/Y8f778+6lem2GeGemeeK9+ObcWH1/23tsjqlKdNM0Z/P1N/9j/vPuhFK+nVCPljpslS1+L2+oP/ABIHuhUf6v8AJ1Qj9vTbKn1t/wAi/P8AtvdfPrVfXqBIo+h/2B/1/daU+zrRHUCQW4Iv/vXuhHp1Qjh1DcEf4j/D/be9Hh1qvTfKLcqPqP8AYagbcAmw/wCKe68Cc9aOKAH/AFf6vy+3ptkv/sRcAm/+2Nyfp73imAOvcR1HJI/3r/iv+8f7D3rHVesRI/33++/p791o9Yyf9b6/77/C/vXW+sRP/Ff98fe+vdcfIR9bn6f6/wDvuPfvy6969d+X6c3t+Da9vp7917165awfp/Q3/wBb/bc39++Z6917yf6q/wBfr/h/tvfut9Y5ER7sDY/1/wBb+ov79nHWvLpuljINiLH8c8N/j791v7eohv8AT37rXWI/7D/YW/4r79/g691Hf9X++/3319+691x9+691jc8E8cfT6G/0/wADz79Th1sV8uo7H+n5uWv9CTfjjj+v+39+NDXHWjk9YSfqT/X/AG/v3y691jJ4H++/w9+691jP9P8Ab8e/de8usZP++/4n6C/v3z69TrgT7917rGT79170PWMn/ff7f+nv3Xuortc8WNvST/Xn/be/de/wdYTx7917rgT/AL7/AH3+v79178+sZI/3w9+691wv/vuP9t79nrRxw6xk/wDI/wDfce/de64Ej+tvfut/4euBP+vza1/fs9a/LrgT791vrGT/AK34/wCR+/fZ17z64H/iv++/1re/de6wtyPrwDbk6b2tf86W+n+t78PiHXvXHWJjweTYm9voAebgfi4/w/r+ffq1yeNOvDFARk9YmP1/xsT+f9f/AFuffs+vXiM9YzyOfp/vv8D9PfutdcD/AL78/wBePfvs691wJ9+HW+uJ/wB9+Lf8U9++zreOuBP+9/61/fvz6169cSffuvdcDx9f99/iffh5deHXE/8AFeT/AK4t/re/A/Pr3XAn370691xP+98e/dePXG/++/A/1v6e/Hyr1uleuJ/3vn+n++Pv3Wuv/9HfvP8AX/YH/W97HWx1wPHvfVuuDi4/1v8AfH3vr3WH37rfURxpYj/fW976sOo7j1H/AG/vR631Fb8+9da/D1Fc2Hv3W/TqM7W/1/e+tHrCZOfrf3vrXXDyc/n6/k/4+9n06rSp66Mg549+z69ePWJnv9T79j8+tdRZgHB/wHB964dbB9emSdSpP++B/wBb3YHq/Hpqm5B+l/6H/fc+7j062PTphqoh6iP9t/vv8Pex04p6T1Sv1/33Fv8Ae/dwerjy6T1Slr/6x5/3j3vq4z0nauP6/wBf9a31/wBh/h7uOrjpNVUf14v/AIW/33PvfXjnpMVlODfi9/z/AE+v++HvfVukpWU/J4/339P9j70R8+qkdJOtpbaiovySR9f9tz7r6dVoMV6Tkw0XBFxzb83+tvr/AK/vRHVCv8uscVY0R0v6k/1xdL/kX+g9tkY+fTTKOpZdXUMp1A2IYfj+gP8Aj7bNemtNOosn+Fr/ANP99+fdeBFeHWj6dN8vH9Pz/vP+9e9H16pTj02yj6/S9/8Ain1/w91/wdapTpsmNr2H1udQ+l+f9v8AT3qgJ69njTHTc8n1Fv6c3+nFuBxe3vZFPPr3oeo3mH9f94I/5H71w61Th1Op8mYj43a8f04HqQH+nHK/1HvXW+nTzq6hlYMLfUH6jn6fQ/8AG/futdRZX/P5/J4/4qTx798ut9QJLMOf6H/C3H9efe6nr1OmmfnV/sf+K/6/09769w6aprgf7H/b8H3Xj1rptlbk8H6fW39fp/U8e7DgOvEDptlcE8H/AGFjxb/kXvxFPt69kAjqI01rgkW/r+f+Iv7sD1tfmM9YWlPBDA/7EfT/AJH79QdWFD69YGmP5/33+x+vu3AdbrTicddCqIsSSB/W/wBP9j/rj3sHrdR1KTIfQMeT9Dc2P4HNrfX3utPs/wBVerDjnh1MSstb1XB+hP8AQH/Wtz/vfu1et18656nxV1req1v99/tre916sCQenOKvB/P+HH+9/wBbe7A0+zq1f29O8NfyPV/tjfj3YU9Otio6eIMh9Of+KH/X5v7tX59WB6doq76c/wC+/wBv7tx4dXB6c4q0H6m3+2t9T/r/AE9++zq/WdmWUXBCyAcH8H6WDf1/3se9j+XVweuEdW0TaG4I/F7i39QfyP8AY+7cePV61z5dPVNkfp6v6fkX/wBtf6c+9EHq3Sipcj+n1X/3x969a9a6U1Jkfp6r/n/ff7f3or1qnSjpq8G3P9PdePVSOnuKrDCxP++/w+vv1Oq0r59Zi6tyDx/X68fkH34deHUeRQfr+f8Affn3avXvy6bZ6dWvcfW/v3+HrXSVymJp62JoqiIOp5BvZkP0DI31Vh72CQajrYJHDoFNxbVmoi0iqZack2kA5TnhZgP0n/H6H/ePb6uG6eDBsefQT5LFkavT9L82/r/r+3Bk9WHSGyGPK6vT/vuf9b8e9EDrVMYGekdWUZW/p+l/+RH3U8KHh1o0PDj0mqqn/IHP9P8Aif8AePdSCOPDqh+fTFUQ/W/H1/234/x91I9OqEfLpkqIiOLc3P8Asf8AH/X9tkDj1Qjpnmj/AARe/wBD/vv9f22RThw6bIpnpnljtf8Arf8A29v+Jt7oR5+XVadNkqfm3+P+3/2HuhHHPVStcefTdLHfkce6nBoem60wem6Rb3B/H0/4p/Tn3UjhTh1qnDpvlHBB/HI/xsLg8fj3U+o4dUx86Hpufjj8f1/rzcX/AMRf3o8etnJ6hyoD/vh9R9L/ANP+Ke68BUdUoRny6b3BuR9D/vrc+/cet0rnrAT/ALx/vv8AePfvt6r1iY/7G/vXXusTH/evr/rf48e/efXusRYfg/19+8uvHrgSRyD/AI/kf4ce/de668pHB5+ouOD/AI/T34fy699vXPzX54I/21vfuvdd67cj6/Q/T/fH37r1McevFlYWax+n1/3r377OvdQpofqVuR/vI/3nke9U9evdQGBBsf8AfW97691hYH8/T/euffuvYr1iYi3Jt+f8eOT9P8PfuvUr1gYgfQcf7yTweTYCx/wv72Mj7P8AV/qr14UwesBPH+t/xs+9cT8+vcOsRPH++/2/v3Xv83WMn/Y/19+69jrGWHHNvz9f97/xv7917rCZFH+P++/3n37r3WFpP6W/2/8AxT37r1B1jMh/w/4n/e/fuvdYmdj+f9txx/xIt79j06959Yif99/X37r3WMn/AIm3/G/9b37r3l1jJ/33+3/w9+p17rgT/wAU/wB69+69nrgTz9f9h/sf8D791rj1jJ/p/h791sdY/wDYfi/+2/23vx691wJ9+691xP0/33/GvfuvdYzf/Y/8V+vv3+Dr359Y2P8ArC3NyeOOP95v79x+3rflWuOsJPHH4Jubjm9rgC5tzb/iPfhkAk9aNKlSP9X+rh8usJN/pwP6D/Xvz/sT79w68MDrGSf95/5F/sffuveteuDf7x+P98PfuvdcSf8Aff8AFfeuvdYz/vr/AOP+t9R7317HXEn/AFvr/iB/xT37h1s164e/daPXE/63+29+691wv/t/+KG/v3W+uJ/3r/ffT37rX59cSfr796de64n+v9L/AOtz/T+p96qevevXG9v8P6fX+vB597wevdcT7917r//S37b3/wCND/jfvdOrU66Jufex1sY669+691hIsffuvdYZFuL/ANP96/5H72Otg9Q5B9D791fqI45P+Pvx4YHWvI9QZPx/sffgD1vqDIfqf68e/Ux1ry6is1uB72OtHrA0n9ST79XrVePWPyW+nv2oevWsD7eveUf4f7f3uvXusbSA/n/YD3Unr3USazg3HB+n9eR72D8+t+XTDUqyH/C/1/H/ABr3cHq3TTNze45v/rf192B6sD0x1UQJJAN73/5F7t1cHpN1S/X+o/1/9592B9Org549J6pX6/778/8AFfdq06cB6T1Wl72H9efdh1cU6TlSn1P0/wCJ5/4n3vq3Scq4A2qwH+I/2/0Hv3XsnpKVkFiSAeb34+n+P5/Pvxp1Uj14dJatpgbkDn+n+x/w/PvVOqkfLpNVCWv+P9fjnn/ePdPP5dUI6hR1EkDG3K/2lJtf/W/x91YV+zptlFK9T0nSddStz+R9CP8AYf6/uhFOmSvHrDINX+v/AIn8e6HHDqlKCh4V6gzC9z+R/vv9790p14jy6aZxcH6g3/x/rzcEgn3rjQdVIpwP5dNM17/8jtc/6/8AX3sio6r03S+k3F73/HH0/wBh71x+zr3UZpfzcE/T6/73cD6e9UPp17rJBXSQHg3Q21Ix9J/1jzY/4+9db6eEq0mXUjH/ABH103H5HIF/9t791r7OsTv/ALEE/j6/7G/9ffut9QpT/W1jf8D/AHv/AGHv3p1709emqe5B4vbkEfj6fX37r3TROOL2v/T/AAP/ABP197rjrx416aZTYkfmx/40Pp/h7sc068OFTx6bpXtcD6/T+v8AT/e/fqfs61TPUNpSL/8AE/iw/wCKn34ep4db+zqO8in/AF+eLfX/AB/4379Xz6tnqO0pANv9v+Ba/J5N7W/2/u1eFeHWxxHr1iNSL/W5/rf/AAH9Lgj8/U+95/Lr3kB1kjrShHJIv9CTa3H5+gHvYPrx6tQ+nTlFXDghv95/2P0+nu9fXrYJ9enCKu+gv/r/APIv9j72OPVq06c4a8G3qt/sb/ge71pnq4Pn07wV/wBAW/p/xsfn8n3sH0638+nmCv8Ap6v95/Fzb3avVuneGu+hv9P8bf4/T3fyoerA9OsNd9Lnj6fX/Yf42Iv79g8OnAR5dOHmSZbNyRYqw4Zf9Y/ke/Vpx6sDTrEJngYXN14sw+h/4oR7v04G49OtNkLW9X1/HH9f9v71Tq3Sipcl9Dqtb6/7x/sfeqU618qZ6U9Jkgbc88fn3o8OvHpR02Rvb1fXjk8W/wAP8fdfkeq0r9vT7BXBgLm/+v8A8T79SnVSOnBZAw4PHBt/xI96rw611we1iRz/AK/+HveD178+oE8YYHj/AIofexjrQ6YK2jV1YFQysCCCAQQR9CDwQeffh1vz6CXce0A4eehT8Fnpv6/1MJP9P9T/ALb8D26snkenFfyPQK5PFMpcFCrKSCpFiCDYgg8gg+36j16v0gcjjiCfSb8/776fn3X/AAdbI8xx6RdbRlWPH9f9a39Ofp711WlR0l6qn+v4/wBYfT+v9PdSKdUI+XTBUw2+o/4p/T3UjzHDqjDB6Y54rX44P+xP/I/bZHVPt6Z54Rzf8/7Af8aPtsj9nVSCOmiaO1/99e3+P9fdWAp8umyD02Sr/vv99f3QjyPVGUH7emyZAfwbk24/2N/9490NR9nVMjBGOmmVSRz9B+Da9+D9B/re9EADHWjjINR03OPqD9P8R7pT06o3UNxY8/T8f8U/1/eut+XDqLIoI5/2B/I/2P8AsPdeBPVMjqA4IJv/AF/2/wDxX3s5+3rdKgevUcn6/T/ff8Tb3XhTrXHrC97f0/P5/wB6H+J97HXhx+fURj+P+Kf8R/U+9Z61/h64+Qjg8j/H/e/8ffvs68Ou9QP0P1/H5/1v9h79175dYyT9QSPzcf71798uvV68JWH+P/G/9t9Pfuvf4OuYlDD6j/ef9v8A7z79w699p65B7H/A/j/il/fqde64SIkgJ+h55/x4+v8AsffuvefUCRCoIb6c2P8AsPr795gde6gSXFv9SeQ1jx+SPoP9h79UCoHHrY+Q+0dR2a/H0t/xQDkf7D377OHWhiucdYiePr/tv9j/AMU9649e4dRGYkkn/iP9fj377OvdYif8f9t/t/e+OKde/wAPWMn/AH3/ACPn37r3WMn/AJH/AMb59+PWqkHrGf8Aff4e/db6xn/ff6x5/wAP6e/efXusZP8Avvx78evf4OuDG3+8/wC9ce/de6xn/XJ/4j37r3z6xkn8f7H/AHw9+691wb/ePx9P96t7917rgf8Aef8Aff4e/de6xn/X+nv359e/w9cD/j/vv98ffuvfl1wJ/wBjx/vv969+691wJ/33+uef9f37r1M564MbHn/Xv/vv6+/H169k0x1gZh9PqbD6nggDkH/Hjm/PveMH5/6v8PWskrWn+r/V8+sTNxb8fX/bgWv+b8e6+da563g0xn/Vw6xE+99e+3rgT/xH++/Hv355639g64H/AH3++/w9+611x/x/33/IvfuHXv8AB1wP+8/776f7f37rw9OuB/4i3v3XuuB/33++sb+/evXvLrif9jf/AHx4/wBh7914dcT/AL7+v++Pv3XuuB9+691xJA/xP+v/AL76n377eHXs9cT/AMR/vP55/wBj79X0691xP++/417917rr37r3X//T35w/9R/tvd+r9ZAQfoffuvde9+691wccf77/AGPvXn1rz6xe99b6iyJ9R731YHqDIPz/AE4Pv3VuoMo+v+Bv/t/euvdN0v5/pf3sda6gSH6n37rXl1Bd7X/3n3rqvUZpD/rf7yffuvdcDL/iT/vv8ffvz6917zcf77/iPfsZznrWeuDSX9+9Ot/n1El0sCG5B+o9762D6dMNXEUufqv4b/iD/iPdwetg+nTLMfqD/t/99/re7A9XB6ZKuMG5H6v97/Puw4dXB6TNUh5B+o/H544/x/r7tXq4PSdql+pH/G/8Pdh8+nAfLpP1SDn+hHHu3V1OKdJ6oT/ff0/x926t6jpiqog1/wDVc2txe/8AXnj3r7eHXuHSXrILE8fT/D/bfj37h1o1HSVraf8AVwfeuqkdJmojKk3Fvp/vr+9U6qR8+m0SyRPqQkMP9ex/1/6/X22w6aZep8VYswt+mQfVSbAn+q/i3+8+6Efs6aIPXpCf9h9L88XH+2P090IqRnqhz02yi/H++v8A73/T3orivWiNJzw6bJkvwbH/AHkf8R/T3Xh1QqQag9NUq2/x/p/j/wAT795/LrXHHTbItrkD/bcf8Re3up9et9Q3Ok3HBPJ5PP0/Fvr78ATWg60euMdS8La1JUj+nII/owPBHvw6907wVqTcH0yWNx/X/Ff8P8PeuvenXORr3HFj/t/9jf8A1vfuvdN8n5/PH9P97v8A09+6901TrwR9b/S3+9Wve/v3n8+vY6aJ04B+v+P++/p73x6900TAqTf8/m35/P8Asfe64FOvdN7/AF/1r/n8/wBPfievVz1CdiOf6W/Nvz72TTHn1pj+zqDJPz9eTx+Lcjm34/p73k/Z1YcCaCleojyEXIJ/3g+7A+vW9Q8usRnI/INueOP9vxb3uo62G4V65pVlD+qx/P8Asf8AeD9PewQa9br8+nCKuvYX5/p9P+NEn/X97FOPVg3Dpxir/wAX54+p/Nv9b/D3YVGerD1HDp1hr+RZv6cX/wB797r1auOHTxBX/Tn/AHq/+t7sD1b7OnqCv4Fzf+vP+v8A717sD1YH59O8Fd/Q/wCw5H/EX93r1YEHp2grvp6j9f8Aff4fX3bpwN69OkdWrqVazA8Ef7E2/wAePfurV9D15naL1ISyfW/1ZP8AXt9R/j7sPTq4PU2nr7fn/Y/T/if8Pfur8elBS5O1vV/QcG1vz/xHvRGOvU/wdKWkyn09X+88W+n0968s9aPSmpMkDa7c/wC+/wCJ91p14jzHDpRU1fe3q/5F9P8Ae/fqDy6pTp3SpVx9ef8AffUe9cOq0I68zA/74/0/HvfXuA6hSqGH454P/Ff9f37rZ6Zaqnvfj3vj17oPtwbap8iruAIam3EoHDWHCygcsLcX/UP8fp7srkdbVqfZ0BmcwM1HI8dREyNyQbXVwP7SNaxX/ffX28rV4Hp0GvA9Bvksb+qwI/2Hvf2jrVaVI6RFdQkXOnkDnj3rzp5daOfLpKVVKeeD9D/sB/j9eOfeuFeq9J2og+otz/vv9490I4ny6ow86dMdRFa/9P8AbW/Ptvh1TjUHj0zzxXB4/wBb/ivIPupFMgY6pTND0zToRe/B+n+9/n8e6FfTh1WlDgVHTXOlwR/UHkcD6n8X+l+PbbfMdUYVz506Z5VNzYG4/wCN/W3unDqgqOm+Vfqf+R2H9b+9EenVSo4jh1BcX4P0/wB6/wBifp7pwz1Uj546hvxcfj/W+v8Aj71TrVMZ6iyKCCD/AE/23/FPr7rwI9Oq8KenTfIpW/8Avf8AxUfj34jgetkeY6jn/W/H+P5/PvXVT5dRXFr/AJ+v+2/x+n497+fW+Ix1gJ/3j8f4/wCt711r59Yybc/717917164+Qjg88f8R+OPfuvddeRT9eP9j/sPx7917riT+f8AYj/Y/n37y691zWVvydQ/r9T/ALz7917/AA9ZBJ+Qf8bf7H+n+x9+691wLh7o4tzwDfn68WFvyBb6+9mgFfL/AFfb1sgenUOSP6lebm9iOef9vwf9f3rPn17hQ/6v9X+r06bnUi/9Pra3/G/fv8PWusBP/G/9h/yP37r3Ud1ubj6/Q/73/t/e+vZ49Rz9f6f4e9eXXusZP++/qP8Ainv3Xv8AB1jJ/wB99ePx/vHv3XuuBPv3XusZPH0/33+8W+vv2evfPrGffq9er1jJ/wCR2/p79Tr2OuBP++/29j7917rGT9fx9P8AbD/jfv359e64E/77/iOffuvefWMnj+h/x/3309+691wJ/wCJ9+691wPv3XuuBP8Aj/rD/ff4e/Y49bOft6xsQOTx/vv+N+/DrXl1iNwD+ef9f+nIt9OP8PfsEgcB1uvqfL8v9n/Vx6wNzzwTa/1+nAtxf/iB79XiKY618q4r1jJ/2P8AsP8AiffuvdcCQf8AW+v9P9v79ny69XHXAm/+H++/2Pv3Xvl1wJ/3o+/de64E/n+v4/2P+8H36n7Ot9cf9cDn/fD375da64H37r3XE/Q/7z/xv37z+XXvTrif9f8A3j/fW9+691w9+691w/4j/Y+/f4evddH/AA/4p79w69XjjHXE/wCx/H+29+691x9+691737r3X//U310n/F7j/H/ff4+706dK9SlcN9DY/wC8+/dV4ceswf8Ar/tx7917rkTcce9HrRz1iP19+631jkFxf/b/AO+/1/e+t9QJV5I/B5Hvfl1YZHz6b5V/3q3v3Xum6UfX/W/3ke/de6bJha/+++vv3XumuUm/+xP+8cD/AHj3rqnUJ25uf9h71177OorSW97pXrXWIzAe9/KnXqfPrvz3/wB8R79wFKde64tKD+ffsjy631FkIIIIuG+t/p78PLrfTBWQlLleV/3lefof6j3cHrfDpgmNrgji/wBbfQf8Ut7tXq4J6ZatAwJ/2xH+3/3n3sdWB6TFWhUkEf8AFD/t/bgNenVOB6dJ2pX68cC/P++/w97B6urDpP1Ivf8A3n/X/wBj7v5npwE9MdQt7j36vn1uo9emOpQN9fwDYj/b/T3vj16nSbq4LX44/Fuf9j/re9U/b1oj16S1ZTjnj+t7fX/X9661TpNVMJX6j+oB/r/tvdSOqEevTTKSpBFwQbg/Qg/4f4+608+mimSfLqTDkNYEc5Ck8LIPo30/V7b00+zpvTxPWd7Hg2+n1v8AUf4e6n5DqjDFfLqFItr/AFt9f8Px/r+6nqtSem6aO9+P8f8Aff091z+XVSop8umqaMrcj3qmPl1U+nTZMl7lR9Px/vJ/23vwxUdb+XTc+oE2v+Tb6/7D/W96PAda9RXrD5Te/wBDf6ji35Fv9Y+/Y6905QV+oeOY6WPAkvbV9bBvoAf94Pvxp17qRJcj63H+9/6/vXXuob83BHv3XumuZeSD9Pp9P68/T3vr3TNUR8n6Cx4NuD/he39PfuvdM8vBJ/H5/wBf/iPfsnr1aZ6aZmKkgEkfUfkW5Nrc82/1/p7tx7qdbIzk0bpskYnjm/8Atx/h9fpb6e/E0GOtH4iT1EeQ/Q8j+n+xH5A+t/fhT8+t4H29RmcD+n+sOf8Aife8cRw69Unh1h8wva5H+3sefx9R9Pe64r5dbzTh15an8Bvz/Xn6/kfS3+w926uMZHHqbHXfgnkfT/jfJsfdgfXrYJ8+nKKu+nP+83t/h+Px/re7VHVgRXp0gr/oNVv9v9OD/T8X92B/Z1evT1BkPp6rjj/eR/vPvdfn1sdPNPX2tZuLDj/Y/n3aowerVx08wV97c/4WB5/p+P8AD3auOrDp4hrhxz9D/j+fz/Uf4fX3YdXBr07Q1v0ub/4H+lh/sCPdurg/s6zMw/zkJH9THfjj/Uf0P+HvYPr1YN9teucVcQf1fTg/gi3+H197H8+nAfM8On2lyVrAtb6fn/ffX3qnW+lNSZO1vV/T8m/+2t/h/sfdadap0qKPKA29X5HJ96I+XWulJTZIG3q/p/vj70R1qnCvT3FWqwFzx/vH+3+ot71TqpHWcuGH1/1j791ry6iSG9wf8f8Aff7H3vr1PTpqqYgwPF/6/wCt7917pI5bFU9bE0VREHQ3sfo0bH+2jfVT/vH9fdgSKkHr1aEEdAfuTa09CZJEUzU5PEoBul+Aso/snn6/Q/4Hj28rg0rx6cB1fI9BRkccRqBU35+g/wCNH3fr1MY6Q1fQ2LWX6/8AG/z7r9vXqV4ceklWUtr/AF/1xcfk+6nHVDw6TdRD9QQL8/77n8e6EU6qRXh0x1EWm5/HHFv8D+f6e6HHVKVx59MdQlxxcjn1D8D/AB4IuB/X8H3X7OqMKYYfz6Y5kIJBvyf9f/Y+6EY6qR59N0yA3+gP9f6/8V9tkfs6bK9NcouTccgn/Y/7c+60pjrVKdNsq3uR/tvxb/ifp70QRmnVSP2dQX/p/wAa90I+WOqHGD1Ea4JH/Ef71f3Ugfl1rqJILj/iP8P8ePx70MV9OqjBp5dN72B/2PvRHEjrZB6wMQRY/wC8f4+9Co611FYWPvZ9evEefl1hJv8A63+2/wB79660OsZP4/33+P8AT37r3WIn8X/33/FPfuvdcQSPp7917rlrPv3n17r3lHFzYn/Yf6x5Ita3v3D7evenXvJcWvqF7835sPpz+P6/n37gajj1759cS5B4P9eCbj37jx68fPHXB1STn882+t7f7x+Pfs9e6gSxEE/j/H8f719ffvy69x6hte9jf/Y+/de+XWFwCOf9v9D/ALe3v3Xuo7i34v8An6WH/FffuvZ6xH34nr3WIn/jf/E+9/b177OuBP8Avv8Aff6/vXDr3WMn68f4f77/AF7+/dep+3rgx/335/4p7914dYyf9t/xv37r1aGlOsd/9v8A778/19+691xJ/r7917rGTz/T/ez/AK/+w9+xTr3XAn/fc/7f8/j37r3XAn/H/iv1/wBtb37j17j1jJ/r/sT/AL7+nv3XqdYywF7i9rcW/qeOOfp796enXqVFesDk88cfj/X5tYi1hzx/re9UByet5oR/q/1V6xE/761v6H6fT3vj1rrGT/t/+K/8i9+4dep5dcD/ALG5/wB99P8AG/v3l170PXEn37r2OuBP+PPB/wB4/wB4Hv3rjr3XE/77/W4t79nr3z64E/8AG/fuvdcfz9f+I/3v37r3XAn/ABt/vvpbke/de/wdcSfz/wAR79w691xP++/r/vre/de64n/e7e/f4Ovfb1wuP+Nf7G/v3XuuPv3Xuve/de697917r//V3vUqP8bf7yP+Kj27TpXTqdHUfS/0/rf/AIn3rqpXpwSbj+o/3r36nTZHUgH8g+9dV67966910Rfj3vr3USVbg/1Hvw62D03Sr9f9v7t1bpulX6/7cf8AE+9de6a5l+v+2/4p7317pomFj/sf99/vPuvVOHTZKbD/AGJPv3n17puka1/9597+3r3UNpP8f9gPfutdYzNb6/72ffs+vXuvef8AF/r79nr3XjJf/H/Y39+691GkYWIP5/B/p/vPv3VhnpP1tPbU6C686l/K/wCIH+p93B/b1uvp0mpza/5H9P8AeLj3bj1evTNUqGB/P/EH3YHqwNOkxWRkE3HH+H54P+8n3YEdOKek7Ura/H/E/wBPdwenAR0w1A+v9R/xH/IvexnqwOadM04HP+9fn+nF/wDX92/wdW+XTJOOCDyOeP8AXH4+v9Pfq56359MFXBe5FitjY8/W30NufeutfLpL1cIsePoPz+P96+nvXXqE9JmqiIBP0+trkk/W34uOfz7rgnquDjpmcEE/7b/bfT8j3ogfn00R1lgrXh/bl9cXNj+Uv9P9h7bKg58+qEV6ctSuupWDKbfTn/kVvdCPPporx6jSILG30/1vp/vfunnw6p8um+ZPrxxzz/xPv1PTj1Uj06apo/yB/wAUPup6rw6apo/qRz/h9P8Abe/ccHrdMivTbIt7kDn6n/H/ABH+w96OOtefz6jFiPz/AL63H+9e9f4OvdSYa4pZZNRQ8ArclP8AGw5I/wBv79w691O1K4DBg6sPSRzcD/AXPHv3XuocwvcD+hsf96/23v3Xum2Vbgj/AAH55/5H7317pmqIxdmHJ+lv8fx9bC9veiD6daPTDURj+n6bgf64/wAeb+96jnOOt/Zxr0zzAg3P+++n1/wPvfEUPHrda9N8lwT/AI/T36uD148eobkgm3/E+9jrXAYHUSRrkj+g/wCK/wC9e7VA62DUfFx6itJYn6m1+f8AW/2P+Hux+XWxX168JyPz/hz9B/h+Pfg1ePVgcZHUuKsKkXPvf59b41I6coqzjg8fn/Wv9T7sDwr1YN06QVpUg3/H9f8AePqB7tWuOnKg+ea9PMFde3Nz/gf9655HvdfPrfTzBXm4u3/Gvr+PdwR5dWB6eoK76c/7zybfm4PPvYPVgfMdPMFb9Bq5/wB8f9v7uDXPVw1enSGu5/V9bfn/AGF+OTa3u/HHV/PqUZVlBdSFk/r+G/wa3PH9ffsjzx1atOucdY0baGOlhbj/AG3+wN/e/mOnAeHT1S5G1rN9Px/j/t/6+/db4+XSjpMn9ObfQfX/AB496I4daI6U9JlPp6v95v8A8T+Pdada4fZ0paXKA2ufyPz71TjTr2Dw6f4K8G3q96x1Ujqd5w4+oP8Ah9Lf6x96x1WnUaQ8H8j+v9D/AI+91zjrfmOm2dQwP+t/vvr9fr791ojPSdrKZXDBlDKQQVIBVgw5DA8EEe9161w4dBFuPaKsJKigT63Z6b68fkwk/wDQp5/p/T24rnAPVw9cHoFsnjCpcFCpUkMCLEMCbgi3BuOfbnlnq4/n0hK+gIJ9Nvr7r69aIrw6R9ZRkFuCD+P98fejnpvh9nSWq4bA8fT68fTkf1/w90zWnWqVNPXpPzxkEj+nFufwf9cgEW96Ip9nVaD06ZZ4hzx/gP8AH6/Xj3QgjI6bNRX06aJk+tx/vfuhFcjj1Qj9nTVPHyT+eL29t5H2dU+3I6bZF/I+v596PXjjqBKv1I/P1H+w+o/x/wBb3Rh8uqFfzHUCQX+v1/r+fr/t/bfD7OqHBz1Db8g/4fX/AFvfqdap5EdQJktyPz9fpYc/j/D3oeh68PTqI3++/wCRD3oimR1WnWBuR/vr/wCx+nF/euvA0+zqM4tx+P8Afc/g297PqOvEDiOsBP14/wBb/H3rqvWMn37reOsZP9P9e/8Avv8AX9+69115Pwb3I/H4/wBf+nv3+Dr3DPWOQ6vobixNwbi6/wCxNv8AivvwNPt69UUPWLWyn0k/j/ev+K+/efWya9ZFlDcEgHg82uT+be/fl1rrkT/vvz/xX37r3XRcEWYXv/vuf6e/cOvdR5Yg3K/7b/X54/xv7917pvdSpP8AT/eR9PqPxx796de8usJ59+691HZRyRz/AIfj+vH/ABT37r3Uc/7z79175dY2P/IvfuvdcCf8ffvl5de+zrgT9fx/sP8Afce/f4OvdYyf98P+I49+691jJ+tv99/xr37r3XAn8f14P+9f71796Hrf29cD/vv99f37rXWM/wCv/wAjH/I/fuvHrgbfj/D/AG/+t79+XW+sbN+Pz/rjgf15v9Pevs49eA6wkhgL8XuDf8c/1vc2I/3j3skj7OtHDHrCx4sb8f19+pSuevVrT0p1jJ/2P+3/AD/h+ffuvdcSf9tx/sf+Iv799nXuuBPv3XuuB9+69x64G/8AvP8AsOP9f37r3y8uuJ/33Pv3XuuF+Oefp/xHv3Xvz643/wB9cc3/AONe/daHn1xP+P8Aj798+t9cD/vh/vPv3XuuN/8AH/fcf4+/Y611xP8AvH++P+F/fh1senXEm/8Ah7917rr37r3Xvfuvde9+691//9beejqgbWP+xB/3m3tTToxK9OEVSD+f9t/xT3UjqpXpyhqbW54/1/8Aej7qR6dNstenSOa9iDz/ALwfeq+vTRHr1MWQNx9D/vfvVOq065+/da6xOP8AeePeuvdQpE+v+3H++tz7tXrdem2ZPrx/j/xX34dWr01TJ/xr/ex/t/e+vdM9Qn191PVSOmacfX+h/wBvzf3vqvz6aZv99/vP/Ee9Z6302SNb/eSfex1rqI0lvzb3v5efXusflP8Avj7qeGOvdeFQR+eP6X+nvVfXh178+vGUMP8Aff8AFfdut8Oozv8AX/ff7x/T37rY6T1dTatTxD/gyf1/qV/x93B49eB49JWc6b/7Ygj8/wBD7tx6uD8+meo0spP+3H+vx72OrA+XSarIyNRH6f8Ab/n/AHj3YHHz6vq4dJypW1/9jz/j/wAT9fbgPTgPHpknH/E/63++Huw+XVw2D6dM0/0txfm39Pp+OPfgc9XB6Z5bi9vp9bfg3/2Hv3W6+vTDVRKwJX+vIN7i44H0uQbfX341x16pFR0mKqG1/wDbfT6f096Ir1UgeXDpPVENrj/Y/wBP9t/jz7qR59VIx00y3BN+f+J/43b3qg6qVB6xw1clM3puUvyh+n9eB+PdGXpph08xzxzpqjPP5X8g/WxH++v7bZa9UIznh1hcf1/P+9/191IIz1Qrx9eoMsfH45/23++v7102R8umuaO9yP8AYj8/64/rb3oj160RQY4dNM0X9Bz/AEH0/wASPpz796g8OvV4g9Nkij8fX/eD/S/utKdapTqG76TYj/kf14/B9+pjPDr3+HrlBVPCx0nUjfqjJ4JItcf0PH496456905CVJVup+v4/K/64+gP+8e/Dr3UWQWU3/1hb63+o/1rn349e8x02TqOfoSbnkf4/j6kXB/2/v3XgTTj59MVRF9Txz+f97/2Pv3XvQU6Zpo73BH+w/3jj3vr3TNKhH1+n4/331HHvfCvXum+Tm9/qCT/ALxz+b+9DHA9e+XTfJ9Seb/776X+vu1aE+nW6CmOorsOQeD/AKr/AGH+9297+zh1oHIHUV30k8fT/iv144920jyPV8+fXETW+h4/3j88X/p79Ujr3556zx1JB4On/XPHP9L/AE92rjHVgfUZ6cIaz+h5+n++/wBt7sD69WHEdOsNZ9Dcf7fg344/obj3YH9nVwc06d6et+nJ+o/P+H+xt9P9497rjq/z6eqeu/IPH++P1+v592GePXgT08wV4NrHkX45/H4+n++t7tU8COPV8V4/5unaGuvYX/3ix/2PH+Pu4PVgadO8FZ9Lt/sf6f7Hnj3sHPVwcdOInSVbOeR9HH6l/wCNe7V+fVgacOuhO8LWPI/DD6H/AHgWP+Hu1R05Xpzp8ja3N7f4kEf1/wAD791avSgpcmePV/Tn/XI/4k+9UHWxSvy6U1Llfp6vwP8Abe6kdVp0paXKA2s3+8/7xb3QinWvt6UNNkgber/ef9f3rrWD06JVpIBzc/1/rf8Ar9OPfuq8D1idvrb6f6/++v78evGp6b5rN/T+n+v73Xrx889MdVEDfj/ff71f3vqvQebg25TZFXdQIakXtKo4f+glXnUP8fqP8Rx7sGI48Otgnz4dAdnMLNSSvFPEUbkqRYq45syt9Cv+9e3R6jq4OOPQd5ChsWstib/jj/fc+/f4OtGpqaZ6RNfSFSxAI+o4t9fqeAfbZzjqtB+XSTq4LE8f14/pzcc/n34DyPWyKj59MM8X14/3w/P1+vupBHn1Snl0zTR/X+v+9/63/Ee6EU4cOm6UxWoPTTKn+3/3v3Rh5jqjDprmjHNuP6/8V/3j21Q9N8MVx02yra9v+Nf8Tx79g9e4/b03yr9bf69v9f3Uj5Z6qR5efUGQX/2H+3t7boBjy6b+R6hSDgj/AGPP++v70c4p1og8Dx6b3Gm/+x/1v99b3rNaHr3yPUZv98feiOqkU4dYWP4/Pv3Xvzx1GcW5H0/33+w9+611hb+vPv3Xvyz1iJ96691gZje45A44/wAR9ST/AMi/23vxIoRXPWsen+r/AFY6wmRh/rf055/px9PfgOrH0/1f6j11rDH+h/p/W3P9PfutdcT/ALbj37r3r15ZStifV/rc/n371691lEit9LD/AA54/wB69+6917UR9CeeP+KW/wB79+69/h64sFceqwb+vHv3XuoMkLKbgEj/AA+h/wAf8Pp796deoc+nUM/7z+b+/de6xOARz/t/+K+/efXuozAjj/E8j/W/4379SnXj1iLf77/ff09+znr1OuBP4+t+T/tr/wC9D34fz698+uBP4/33++59+xx691jJP++49+H29e64E8/n/ffn/b+/de/w9cCf99/sPfuvdYyf9t/vuPfv8PXqdY2IH5/H/I/p798+vE06xMbgfXnm9xwOSR9f9v8A0/x974fb16ua/wCr/V6ft6wsQTf+v4twOPx/iAfeqmlPPrx+3HHrGfz/AL7/AHj+nv3XusZt+Pp/vf8Asbe/V+XXvLj1xPH++/H9PfuvdcD/AL4/776e/de+fXEn/e/9sR/Q/wCv7117rGfe+vfPz64k/wDG/wDff4e/Z691xva3++H0/wBt79/g68euB/3j68/7b/ePe/Pr2cV64n3rr3XA8/8AG/8AHj6+/fZx6911f/Wvb/bfn/W9+/wdaPHrgf8AY/77n37z63117917r3v3Xuve/de697917r//192WjyZQhHN0/BvfT/xNva9lrnz6PnirUjj0pYKzVYhr3F7g/W/+9j22RTj0mKUxTp3hqfpz/r/8UI91I6bK9O0FVb6G/wBOL/70fz7oV6bK9O8U4cfW/wDvY90yOmiKdTElNv6j/fce98eqEenXNmv7r59Vp1iccX/p/vXvfXuoUqfn/Yj/AIke/de6a54+Db/X/wBh/wAaPvwPVgemWdPr/jf/AH3+397PXj0yVCfX+v8Avv6396z1XpkqF+v++/x97z17pnmH1/3359+/LHWuHTZKbf6/0/3w9+68PP06hvJa/wCSPyfej/LrfDrAZv8Afcf8U96619vXQqLfQj/b/wDGve69ex14zar8/wCPH/I+be91+XWv8HUZ5P8AW/33/FPfscet9MVdTCUM8fDi5K8AN/0kf9592B8utjpH1IZSfqCCQQfrf+n+t7tXq46Z5yGvwL25H4PHP+w92Bx8+rV6TlXF9Sv+2/p/j/iOfdg37Orqa9ME4+p4/wBb/YC9/dgenag9MVQL3/BHP+w/3v3vyJ6tq+XTLUC9/wDY/wCPP+sfx/j7uD+3pwGnTPPcE24v/vBP9fx/sffvn1s8R00VMayXItq/3gkf0/offjXrXScqoeSLW/p+SCPxzz9Tf3o9e6YKiL6m3+v9eQD9eR9fevXqvTRKun/H6/7Aj6A/4+9EV6ow8+sCTSQuGQkH8i5sRxcEX5+nttumyM/Pp4grI6ldJIWQfVb/AFP+0k/190I6bI8wOub/AO9f1/x/3n3QjPVaV6gzIP1fj/ff7f3rjjz6oVIx59NcyXuPyPr+Of8AC3096/wdUIqK9NFRHa5H0/p/vvp79TFOvA+XTVNH+f7Q/r/j+CP9j71TiOvEenTexKn/AGH+NvdT/PrXXASvGdSNpIH+wP8AW4vax/Pvdfl17/D1OjrEmGkkrIB+m5vf86b24/wHP+9+9fn17rFI1+LfQ/W3+9H68j37r3z6bpRyQRx/vHP+2/Hv3+Hr3r00VMXJtYfkGw/paxP+v791qvTLMgN+Pp9R+f8AX/x+nvf2nrfTPMhUn6D+lvoQL25/qPfuPXvMdNkoH15/P/Ffe+tj+XTbKPqf6/8AEfn3bNMcetkcCBnqG7ECx/Fhf/ffj3oEY63Wmeo5b3Y+ZHDqoY1p1x8luf8Aff7D/be9VP59WBFPn1kScgjnn/ev9b25X59XDDz4dTYqqxAv/sf94597r69Xrj5dOcNaQeT/AFsT/jx/sePdhinWwTjp1hrraSG5v9b2A/B+oIJ593B4AcergjI6doK8fgj/AAP+H9PwLW/17/6/vdeFetiufXp7p66/9rn/AF/9j+Prb3atOrVx8unqCu/q1+T/AK31/P8AT3avVgeB6d4azkaSfp/t7/7D3YH16vXpzSqVxY8gg8f4/j/Y/wCPvderA+nXRkaKzKdSfg/XT/TV/X/X92Hp1cHqZDXFedX9P99/T/eve+rA5+fT3S5OxF2+hH++/wBj79/Lrda9KSkyv09X1/oeAf8AY8+6sKdeOelNSZT9Pq/5Fxzzbj3Qjqp6UNPkgber/ef9v7r9vWiOnaKvDDk/7f8Ar/h/tvfs9Vx5dZHkVvUCLnk/j/jVvfq9ax5dQJWBuD/viP8AjXvwPXuHTPUoDf8Ax/r/AL7j3YHrXSRy2Lp62J4qiMOpuQbWdT+HRgLg/wC9+91oRTr1adAjuLbU9CXkVTLTFvTKBfSTxplUfp/1/of6/j24GBr1euD0FmQobauP68W49+OT8+vfb0iq+iILG3+H0H1HJ96446oMU+fSTqqcj8f77/e7+/ccHj1Y0P29ME8Vrgi3+w/xvccfT22R02Rw6Z5o73/B/wCJ/wCKn3UinVCPXh00TJYni39Rb22R1QjyPTZMgN/6f4fg3/H+v7pQ8fPpuhHTZKtif9jf8f737rx68aeXUCVbc/8AE/6/1t9fdSK9UIr9vUGQfU/ke6fI9U4YPUKRQQbjn/XsR/tvfutUrQV6b5AVJB/4r71178uo7cf8b+v+9e6kU4dVI/Z1iJ/r9PeutdYT/t/fuvdRJDpv9NNhyCL3N/p73/h62RUY6iuwI/Atx9Sf8P8AWFre9AccYr144JFa9YSf99z/AK/+9e/V691jJ9+61869deS3BuR/vPP+v+PfuveY9euywIuOeT7917zI64Frcg2I9+z+XXusgn/1X9fqLf763Pv3Xvl1z1Ai4Nx/xq/+8+/de64lz/rg/wBb/Q/717317rBLCr+pGAI/H+2/2x9669Xpva4NiCCP+Rf7b37r3WIm/wDvvx7917rA62+n+HH/ABPv3Xuo5P8AxPvxr59e64E82/33P/GveuvdcCf99/xT/b+99erXrgT7917rgb/7D8/8j49+HDr3DrGx/wB9f+nv32de6xM1uQB9Lgki1/6Xvb6e/U4+vXhmtD1hcn/Xvf8A1zywH9fr73+H59erXIOOsRYkD63+n1P5/wAefevt4deoPIdYz/vX++A/r79xp17HXAkf7x/rn/Y/6/v3p17riT/vv+N+/de64E/77/Yf8U9+69T9vXA/77n/AJF79wr17riT/vv+N+/de64E/wC+/wCK/n/inv2OvD5HriT/AL76/n/XPHv3p17rgT7917rif+J/33+x9+8uvdcSf9a9+eR/tufe+vHrjf8A33H/ABr3qn7Ovdcffuvde9+691737r3Xvfuvde9+691//9Dc5WYqQb8f74/6349mooehTTp5oskYiFY3S/8AsV/xX+n+t9PdGSvDpl4gwqOPSqp6wMFYMGU/Qg/j/b+2SpHSQpSop08wVQ/r/wAb/wCKe606bK9O8FVa3P8Avv8AEfn3Ur00y16eYakMBz/sfr/t/wDD22RTpkrTqcsn++H0PvVeqEdZSylT791XrAwuP959+611BlT68f1I/wCJHv3XumieP6/8R/rH6f429+8ut+XTHUxfXj/X/wCJ/wB496+fWj69MNRH9eP99+fdutdMc6Hn/ff4f4+9HrXTNOCL8ccfn37rw4/PpolNvevn1vqEz25v/X/ffTj3qtevdR/Lb+v+3/4r7316vXHz25B/2Nx/vPv329e/LrxnuALi/wCfp/t/e+tdRpHvf/effq9e6Za6BahSRZZQOG/Df4Nb8/4+7DH2dWB6RVWjRsysCrKSCD9Rb/jfu4z1sHpnlbUSDYMOL/g/7D3vqwIH2dMdXDe5X625H9f8R7tXpxWI6TdSCCeLfn/ivH+v7uM06vWvTFUfn/X+h+n9b8c+9ivHy6dB86dM1R+f9b/efd64r59XrinT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n8fX/b+/da/Lrr37r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691/9baoSpt+b82+v0P+Bv/AIezroaDqfDVkWIb6fTm1j+Lfke918j1f7en+mrg4AY+sDn8X/xH055596Ipw6bK0r6dOazgj63/AOK/0+g96+XW+snkB+p5/wB9+fdvy6tny64swItf/bXuP9sPexjreePURpdB5uP8P9j/AI/1978qdXpXgOskVY0bK6khlNwfz+Px/T3oiuOqsgOD0p6HKicBSQsi/Uf6of1Xn/bj8e2GSn2dIpItJ4Y6fIa36er/AH3+x9tlekrL8uninruf1f8AEe2iOHSdl6UdBlWiIBN0J5X/AIkX/P8AvftsrX7ek7oD0r6atSRQyMCp/wB7/It+D7bII6TstOnFZQRcW9+/w9NkVweuL2K396I6qR01VEVwf99/re9daPSdq4L3497690lK2ntfg88f8j96I6r0k6yC4bj6/wC++nvXXuknWQ2ubf15/qPfvTrXSYqksW/w/wB99Bx73jr1Ok/UqQfpf/D/AF+CT/T6+/HrXTJMf8f98B+Pxx78etevTdJJb/H6/wDIuLi/vWKdeoePl1FaU+9/l1qo41PWHz/42/wBtb/jY976158euYqA/BJv9Af9h+f8ffsnHW+o0jXv/T/G1v6/71738+tjGT0lsjRcNLCLjkvGB9P8Y/8AAfke9jrdeklPcE24HFj/AE/H+w/2Puw4dWB6hGcE6X+o41fgj8A/63u1cdWGaHz6bKqEG7J+fqOOf8V97rnq1c16YZuOP975/wCN+9+fTgPDptlP4/H++/x92rmvTlR02zGwvz/xI+v+297BqT1atKDpsmP5/wAObf4fn/Hj34cetgilOoEkv9lvzxfngH6n6f4e/eoBz14GtDj/AFf6v9jpoqFBuVHHPF729X9bAkc/6/vx9evfb0xT/X/Ym/8AX/Ae/YoevHIFB01yEq31Nv8AfX/wv7bp8umz5+nUZpPpyPdW88dUb5dcoq54SB9U/Kk/n+o/oePdRnqv59OX3CTLqjYEf0P1B/ofdaevDqlBmvUSQ8G/5v8A7z/T3U04DqhrSnTNOfUb/wCw+n4964deB6Z57WYgE/71b/iPeqdayR8+mqQ8254H/E/8a9+PXvM9QpWA5+h+nH1P9Pfut4rTqP5h/U/6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r79nr3WMn/ffj37r3Udz9P68kX/BFuOOOQbe61404de+3j1Gub3vz7saeXHrx695Ln8A8W/41/sffut465CT+v8At/8Aer8i3v3WupUdSQAr8g/Rif8AD88/T37r3WcurD62v/jb6f43t9ffuPXuoEvDGx+o/p+eb+/de6hSoGBIHq/H+Nhf8jn37ievdN72Nwf+Rf7b/H37rXyr1Ea6/wCH++45v9Pfut/LrET+P99/xT37r3p1iJH1/wBf/Y+/de6xsffuPXusZP8Avv8AC39B9PfuvdYyf99/vvx7917A68GHvfW6efXFntyL2/FvyBybW+n+x9+4f5evDPn1jMvHJIP0K34/qP6f1+n19+ApwPXhTiOPXJZtPIP14P5HH4tf3vJNT1uvyz1KjnB/Nvxa/I/1v63Hv3+Hr3y6mx1BAtf/AH3+PH4974/b17qZHUf0PHPB/wBc/wC29+PzHW6+vUlZgbfg/wBP+Ke/f4Ot1p9nWYPqBBPB455BFv8AY/X3vGCOvfPprqabktELj8oP95K8/wC8e9keY62fUdM7kDg/X8gix/4j341pXy60RkEDqOzW/Nh70M+XWxTrgJLCxI/4n/e7ce7cCaHq1R606yLKeCD/AL7/AI3799vW/LqQlSfyeeBfj6/4m9veqHy69/g6lLUf43Fv9Y/4f69/eutY4g0PWdZ7i4PH+vzf/ivvXDFOvfaP2dZxKrDS3+9/7b/eB739nW8kYPXBuPqePwf98ePfiaeXWqdYJGF/8f8AiD/tvp78tck8D17HAjqM5PPP/Ivr/tx73XHW6AVHUKdUkQ69JtexuAV+g4IH+t71n0NeqkH0OOk7U0rRtzchj6WPGoEfQmxAb/b+/EjBXNOveXy/1fnTpokSxP8AvIubAf0H+Hvx/n1r889N0iWJt9P9jYf7x9Pe646t1GcXF/z79wrjrXUY/wBPfuvdYmt9P9b63Nv98fdadVYdYTwf+J/2H1+nunr03TrgT7917rh9Pr9f6/77+nv3XusLr+QP9cf8T/jb34db6wH37rXXG/8Asf8Aff48e/de/wAHXE/8V/41/hb37rw4164n37r3y6439+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3XJWI/xH+++nv3XusoIP09+691yBI+nv3XusgcH68H37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Hhx6hsNP+t/vvr/X37r2esJPP0v/ALf+n/Ee/fn17/D1jJ/33++49+691ibkf0/of8R+Pfv8PXgadRW4/wBhx9P+Ke9dOcfPrGT/AK39f9t/vfv3y691iJ+vv3XusbH/AH3+tx7914dYz78evdYyf955/wB5P+9e/f4evdYifz/xXj37r3WMn37r3XQYj88e/de65ByPp9P6f1/1/wDH36uDXr3XRkBBIuACByLW5NyP8Lf6/vWCafLreeokt2NwAD+ePyBbgf63vfWuPnjqKx/H+3/5F9effut0r1EcWJv/AMjt/wAU9+611iJ/33++v791sdYyf99+PfuvfZ1jY/77/W9+611wJ/33++496p177Osbf77/AH3Pvfy69WnWO/8Axvj37I69QdYyffuvdcCR+Pr/ALxx799vXuuOor9P9t+P+Ne/de65agfyf629+6112HtweR/vvp79/h631kWUr9Dcf0N/6/7e/Pvda8R177epSTgj6k/T6/Uf63v3+DrfUlJh/W/+P5+n+8+99er68OswkJ/xFvpxwP8AYf097B9etinr1wmRZlubah9H+hH+BNjce9EZHXiAc9Mc8bxsQQfoQGW9ufyOL34HH+3/AK+/YpQ468CD1Ccm7XANjza3qsbf7fn8D34ECnp1bURimPXrAWv/ALbn63/p7vUeXVqg9cbkG4/5Gbf0/p70aHrxocHrIJR9D/vv99b3UqRw4dVoRw4dZFkt9Dx/T/b/AO2496rn0PWgfTrMkt/oeRf6WP8Ar/X8c+9/aOrVB4inWVZf9hx+P99/X3qnGh60QR1zLhgfVz/vvx72K9bqDk8esRJH1t/r/wBf6c/Uf09+69UGtOsbtf8Ar/xXi/8AX34deA49R2P9fp/rf7370fL16qfIjj1EkUMCCNVr/wBL/wC98H/X97NKV60c0px6bJoih/qv4P8Axr8e9cR8+vGhHz6hsPz9L/74cf09+B8uvD0pnrCR78cdaOOuveutdY5B9D/sPfuvdY/fuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvdf/QuOWT6c/7z/vP+8e3QafZ06DQ9So5ufr7vXq4I49OMU9rEfUH/fHj3cGuenFIPTzTVf0F/wDe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4p79jr3+DpqmW9z/ALf/AIr9f6e9dVIyD01S/Qj/AGHH+x+n+x9+HHPVCAa9QZD/AI/4/X23TPTLAU4dRvK8TBlNh/vDf4e6sK16aK8QepQlWVbqbH6Mv5B5P0/P+B9t+Wek5HqOo7m1/wDff482/wAfdSP29NMK46wNLa5+lhc2twP8P9f/AG3utK46aI49cfuf6E24/P5HFybf4e9cMdNkZI8+lLis+YNMNSxaL6I9yWiB/r/WMf7ce6+XTRB6WaVKuqsjBlIupU3BB+hBH1BH9PdT1QjPz65+UfQHi3F7/j8jjn3rj59ap+3qLMgYEgi/5H15P+x9++VOtEdM8yX1A8W/3n3qn7OvdM9REDe/9PrY/wCt/T6ce/evVfLphqYbE8cH/Y3/ANj798uvfaemSojP1H4H+te5+n+8+9db9a8OmqVf9e1/9sf949+696dNkqm9jp/pf6fj6f1sbf7f36vXuIB6bZBcEH6j8H/eP959++XXvn03S35P4P8ArX+lufofe+vEenTbJ9Df/kRHB+h968utefyPTdKL/X+nvfVT5049NM1wT/rcf48WHv359e44rnpiqyRdgSL2/wAPoP8AE/488e/ca18uvA0wRXB6gefRw3P0VWBvb8cni4A9+rXr32jrFIS3Nzf8f0P9LW974dbIHUYyEXvz+P8AH37rVOsTENa31H+8/nj/AB9+6959ZY6gH0SH/WY8j/Y+9de67dR+eVI/w5v/AIe/f4evdNsq6SbfS/8AxH+PHPvY691AkX6j8Hj+tvxyPfuvdNsilT/h/X/X96xnr3DqI4vyPfifTh14enUZjyR/sP8Aff77n37j16lOsZ/33+x9+691jbn6/wBLG3++Pv3l1YdRmFjb3rrZ64EX/wBf/jXvfWq9R2P++/33+APvXrjq1QB1HZjb8/UfTi31Ngbkixv/AL4e94px69QUx1gY/wC8/wC+/wB596691jP/ABX/AA/r/re/fZ17j1jJ+vv3XusZPvw68esZ9+691jP5PH+9/wC8+/de8+uBP+P++/r7917rgXb6Fjbn/bEW59+69w6xE/X370691wJ4/p9D/rX/AK+/efXs+nWMn/jX++/x9+691wP5P+v/ALD+vH5t796Dr3+HrGT791s9cCf99/vP+9e/da64E3/4n+n+P9eePfuFevfn1jPv3XuuH0/33++4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799nWuPnTrCzf4WF7G3Nx9Pr+Qfxf6W9+yR+X+b/AFHr1TXjn06wk/7b/kX1/H49++fW+sd+f99x/T+lz7917/B1xJ/2J/31/fuvdcCffuvdcPz9f9h/tvfq9e4+XXAn/fc/76/v3XuuJPv3XuuNyDce/V6969diQfQ2H+P+N/8AC44v7969ePHrkfrx7917rmstvr/vj/re/Z691mDBh/j9fr9ef6/n6+/efXuHDrmr2+v/ABv37r3XToH5+h/BH/E/19+691CkjIPIs3+9j37r3WD37r3XB1vyPqPfuvdYvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3X/9C0kn/H37r1M9Yif9v/AL7/AHj37r3WFn0/psW+lr/4f7ewH+x96Pr5derT7OuJkBH+3JF/x+m9/r9f6/192Pr5/wCr/V+XXjSpp/q/1f6qdYSfr/vv8LfT3rr3XHXa1v8Ab/n3sHqwPkesqyXH+J/xNv8AjY926tw8sdZlf3YdbrX7epCTf7A/1/4j3YU62p/Z1LjnK8E8H+n092r6dOfYOnOGotax/wBb/eOPdwacerV869PVNWWIF/6f63+9fT3cZGOrg4+fSjpa5kZHRyrqQysDyCPzf3fJ+zr1ehDx+USvh1XAnQASoOOfprUf6lr82+hPunDHXuH2dSHktyOLEn/kf0924dWr6dQ6gLIpIt9OR/j/AE59+8utn1r0lq2H68f1/wB4uPp+ePfhTPp16teHSUrI7auOBzwL8f48D6+9g549bqemKU8kf8V/3q5596JwK9XOQP8AUOuCT6/23Pqt6GP9oD8f1uLf7H3oilOtGop1gm/P+AP++H9Pr71wAPWw3p03SD6/7e34Nx/T3rhjq9a+fTe9wbj8f7Y/8b9349XB8qdYvIP6f6//ABqwuPe/kDnp0GmPLrvXf83/ANiL/wBP9sD79Wh9Org9cxJbi/8Avv8AY+7gg/b06GHn1nWW35/41+Pe+rjPUlagi3++Pv1R16uDUdS0lEg4Nmt/vX5t70etf4OsTEn68/77/be99X+XUSddQ/AP4J/wt71jPVSTjpmnGm4P1+v/ACL/AF/fvy60QcevTTUW5IvcG4+vH+PH/E+/cRTqpByaY6bJD9TwePqf6jn/AGPtsih6aYeXTdJwfrwT/vvx70Rj59UIwa8eo7H8g/T8g2tz9eOfx7of59MMKZp1kScP6G/V+DwA3+H+B9t9MsOsU3FyP99x79T14dN1FSOoLuR/Uf4/X/ePdeJwOmypBrWo64rOR/h/X/ffn3ojz6aZfPqfS5CWmlWWF9LD6i/DC/IYcgqbfn/e7e6HqlPl0IOMzEVaoAOiZQC8V7/UD1L+WW/+xHvXVD0+rOCPx/rf8Rx9PfuPXuupLOLj8fjm/P8AxPv2B1ojqBKv4/23+H+HvX+DrVK/b01VEVx9L/UH/fHi3v2OtV6YZ4SL8ek/T/D3rrfTFURWuQLW/wB9+R796dbB4dMtRH9eOD9bcf1PH9D78MHrWSfKnTHODzwCfoWtywAsf68j34ggg18uvClTnpmnS17fQ/4fT+n+8+/dep+3ppmU2P0v+b/6/wDvR9+69TPTNUJcHgfkWP4I/wCKe/dexxz0yTIVNv8AYjnj3vrR6apl4JA5vc/4WH1HNvev8HWqfhPUEn8D/Hj/AJF+fdutfPrB5CGv9LfS3B491r59W09ZhMJPSTZv9b6/8UPHuw6oVPHz6xsLcH3759ewR1ha4/231/3x+l/fjT8+vDFfTrEJChB/I+hv/vHvWfTqwo3A56krMkgPIDD6qRwR/h/tvfgfPrVD5jHUSRfqR/r/AOw/2Nx9Pfq9bPzHURhqB/3j/ffUj349awPs6hOLf8Tb/Y8/48+/dW8s8OoTi19RuP8AX5vf8HSDzb6/8UHvdahqDquQT1Da4P8Ah/sP+Ne69XBr9vWEn/ff7H/H37rf29YSeT7303w49Y2/x/P/ACO31/Hvxzjr35dRm4/3v/Ye/dXGR1jJ/wCKf8UP+IuPeut9Yyf8ffuvcesZP+w49+x17j1jJ/33/FffuvdcCeD/AMa/r/sffvPr3p1jP9f99/X37r3XAn68e/de/wAHXA/77/X/AON+/V691jJ/3309+691wJ5P4/3v37rVeuBP++/33Pv3W+uBP+P9fr/vre/de+dOsdzz/vvz+f6+/Hrxp1jb8c/6w/qf9ibE3/1vex59bGPLrESfUPp/T/WvYm5AFuP9796rXNePWqAKT/qqesDG/JP1+v8Aj+AbDgWHv2fPrQ+zrGf96/H+39+9T17yx1wJ/wBY/wC8+/euet9cD/xT37r3XG/++/4r791rrj/U8/43/wBj+B/UD377Ot14dYyf99/vv6e/de64/wCx/wCNe/de64H+v9f96/3v37r359cb/wC+/wB9+be/de68Htx9f+I+n0/1x7917rlcH8/77j/b+/f4evfbw65BtJ/4i/8Avjcj37/B17rOsobg8H/G3v3l17rMGI/1v6e/de65kLILH/jY9+691CliK8/7Y/g/4H+h9+691H9+691wZb8j6/737917rF7917r3v3Xuve/de697917r3v3Xuve/de697917r3v3Xuve/de697917r3v3Xuve/de697917r3v3Xuve/de697917r3v3Xuve/de697917r3v3Xuve/de697917r3v3Xuv/9G0Yn/fce/evr17PWJj+L2/3v8A2A/P19++fXuozkWIv/sLn+p5PBPN78+/A5r5/wCr/Vjr1a0Py6jk/n+lv94/43799nXvsHXvJfg8H6f77/Y+90691xJt71x69xr1w12/P+t+f9b3sHyPVgfXrMkotzwf+Kn8/wCt/t/dv8HVjj7D1nEl/wA8/wC9+9g5+XWq5HWZZPwfr/X/AHw93BHVwTUY6lxzkfn8c/8AFfdhjq/p05w1H054/wB6/wBf3dTTI6tjy6eaassQCfz/AL78+7g1yOr8ePSioci9PKksT2ZfqPwVPDK39Qw9249W8sjoQaavirIRLGwN+HXgGN/qVP8AQf0/w916qCfy680lrkWP9R/X/X4+vvdetmuKnpvqlV1LDm4P/INubH/b+/eZp1sYFaY6SNbFb8H8/Ufgn8fgDj37Hp1v0p6dJeoQqT9fr/rcf7G1vez59XBxw6aZr34uCLkW/Fvp/Sx96P8ALrxPD067ScSDS59Y/P5Nh/tv9f3WhwOt1pkdYZOf9f8ANx/h/wAa96+3rYb16bZTYn+h/wBf/fX92HDq4PkOobsQSQfwf9jx7rw6up4AnqP5CDcf7b24DXHT6ny65iX/AH3+P5/J9+oePWwc8esiy/43H5H5H++I92B9ergkfb1nEn5Bv/vfHu329OBvn1mScgXB/wCI/H9ffut46lLPr/4MPwfz/jx9effqU69wx1xZv6n3ViB1U9Ns1mW5sSAfp/yDY/1+vu1OtmgxXplmFiR/r/U/Ufg/049+8q9eBx8umyUWJ/p+P+R+9EVGOm2Hl03SAcg/6x909D023r1Afgn+v++/4p781AKg9UPl1EZj/X/ffj2yQBmnSdgMinXNKi50SEX4s39f6Br/AJ/x96PADplh1wl+pH9P+Nfn8+606oflw6hSMRe1uPqP8PwfdDQHPTZBrWmOsQmI4J+v9f8AeOPdeH2dNEU+zqZT1rwuro5V0PDA8g/gi97g/wC8j3s/Lh1Q0pw6EHFZ2OrCxyFY6gC9v7MvHJX/AGoW5HuvHqvSkjnBH454/wCKj3rqtOuTWf8Aw/1vyB/j+R/re/H5dbHz49QnAI5+v/Ej3odaPn001EQ544J/r+T9QQf9b3v/AA9a4UzjphqorA/S3+tc8/mwFz719vXqgGnTBUw3vbj8i1/wbf7171T9o6tXyr0xVEWoGwAP14H++4N/dvt60MefTLMgBNwOeD/vrX596638umadLE8f1t/iP6Hj6j37rX+HppnS/wCLn8X/ANb/AIj37r3TJPHe4Nr/AOP4PJsf8Ln3vr1OmeZLEhvzzY/T6/X/AGPv3Wvs6a5lIJIPH/EH/YXvf3r068RXPUB+D/hzb34/y62DX7esLN/j+Pr/ALb/AGPv3Xqig6yJN+G5H9Tx/vP197r1UgGpHXi3+9cf8a9+9OtUxTrEbHg/8a/x976occOsBLL9CbX4PPH+9e9U4HqwbrKk2rhjzxb+h/p9Pz78a0x1bUBx6xOPqQbf7x9f+K+9nNfXrXDh1Dk5/wAbf05/xva/AsPfvkBTrx4UPUGVb/j8f7b/ABv/AK3v3WgeNeoTixsRx/vvz+OPevLq3z6jP6f9b/ff04v71TqwIPAdYT+P+R/63v3y60QTmnDrCT7t1XrERq4/3vi9xyfpf3o/PrYPWAn/AG9/+K8f4+9dXr1iJ4/330/437959e/wdcCf9h/tvz/vXv3Xh5dYz7917/B1jJv/AMSOf9v+ffj5dePXAn/ff63v3XusZPH1/qbf8R/rG/v3XuuB9+691wJ/3n/ePfqdaP8ALrGT79n1631wP+8f6/8Ar/8AFPfvLr1OuBP/ACIj37r3l1wJ/P8AxNv9Yf7E+/de6wlv9ja3pBBJsf8AWJv7986ZPXuHln/V+XWJ25Nj/j9eb8cfQWAsPegMZ68OFeHWEn/Y/wDE/wDI/e+vHOTx64G9vr9f99bn37r3XA/77/ff7H37r3n1x9+699nXAnn/AFv+KH/iffuvceuB/wB9/wAj9+691xv+OPz/ALEf8R7317rgf9jx/vHvXr17rif999effuvDrj7917rgf9t/vvz9Pr791759dXN7j6/n+n+9+/evW+uYcG34P9Of94Pv3Wuu/fuvdZ0ltw3+sD7917qSD+Qf9iPfuvdZQwYWIH+sfof98ffuvdRJoCLsvI/I/I9+691F9+691xZQf9f/AH319+691h+nB9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691//StCJ/33+9e/Vp14Up8+sDNxc/n6XBItc82sBfgfX37zp59bFQc+vUYsfpf6m/1/1725PHPvf5Z61516wMT/hb/e/8fesde6xk/wC3/wB9/sPfhjr2fLrsSX4/P++/3r36levceuBP++49+p1rj1w1kcE/1t/vvx7sG6upp9nWdJb2B+tuP9f/AIr73T06tSg6zCT8E88W/wCKf7x78PUda/PrMsv4P+3P+v8A7H24D04pr1KinIsL/wCt/j/tvz7v5dWHqOnOKo+h/r/tr+7A9WU9PFPVkfU/n/evd616uD69KXHZRqaUOCSjcSJ9Qy/63+qH1B9762TjHS4SqjnjSSJtSMLg8cX+qn+hB96618jx6jPLpvcXUnn8ixtyAfobf0978utjjkf6v9X8+mqsQMCRyDyD/U/n/Y39+9et+Q6S1XF9eP8AiOP6Wv8Aj37rY4npOTjSefqDY/1/2/8AXn34/LrfpXprkYhiQbEMSLGxFibe6jrwz9tOsq1AlWxFpB+of6r8XHHvRrX5dexnqNKb8fQf154/2IPv2eI6cB6gv+R/vX5/x/1j78c0Pn1bAPUB2sSP9gfqB/trX93qKD16eB4Hy6x67fn/AGPvYNRjj1avz65iT/Yf4/7b36tR1cN68OsolP8AXn+o/pb3YH14dXBpQ+XWdZv9gf8AH6H/AIp73TpwNXy6yCXm4Okj/H6cn/eve/59br+zqQJhIPpza9v6gn8cHg+9edD140rTqNI1r2P+x+n1Fjb/AF/fhkivWh6nj1AmGoE/4f7e1z/T8e/ef59a4HppmBsfpcf197Hp15sdNkoF+P8AYf7f+vuh/l03TiOm+X6/n6/737r+Eg9Nnj03Ox5/w+n5491I4dNso49RGY8n6/1v/T+n4uOfdMHphhXPXaVQFo5T/wAFf8j+gY/0/wAfdTxxw6bIzjrqaxvz9Rxf6Ef7yPdadNNXgOoDt/T/AG3PH+P9fevt6oRTiOsfmIt/hx/W/wDjb+nutOm6UqCOpUFYVYFWKsDwQbEEcggg3H+HvR6bPS9xG4BPogqWAm/SknAWX+iniyuf95/1/r7z6pXyPStjqBb63B5P+8+9Z8/TrxBr8+sjMGAN/wAf8T/t/ej14Y4dRJRe9x/rjj/b+/H+fWgQTTpnqEHNxYf1Bv8Am51W/Bvx7958Otngc16YKiG1/wClz9ADYn/ok+9de6YqmL6t/rf73a/+t791vHDz6Y6mH6kDkWuPr/Tj/Wt7914eXTNNGCDcf6/9R9f+J9+/Lr3TJOhBIsOCf99c/g/8T79x69jpoqEP9PrwR/xX/W9+p17plqIyR9B9f9uLfj6297+zrVPXpolW1/8AY2P0/wBv711rP59NU62N/wDE8W+ht9L2/N/ex17h9nUJv945/wB99Pfgf29bbhjrETx79X5dUHy4deWW11axH9fyPfut1NeuWqw+oI/3j/Yf09+4dboDXrgWB+p/4n/Y/wCw97r5Uz1XSRSmesTAr/vrn6fn8e9Z62KN5Z66E1rK/wBDwD9P9cH825/3j36vzz1ulBWnXBxf6W5ufoPyf9b/AA/HvZoTk561/g6iMByDb/ffi/vVevEfs6iSKP8AYfj/AA/4j3v/AA9aHUJxb0nkf77/AHr3rrf2HqO3H/I/+R8+9Up1YZ889YG9+60R5jrET/r8X/2H0/r9fe+q9YX/AK/kf7z9P9h791tTmh4dYD/sbj/ev6e9enV+sZP++/3j+nHv3XuuBP8At/8Affjj371698qdYz79177OsZ+v++/p/vHvw/n175dcD7917rgT/r/77nn37z698q9Yyf8Aff8AGvfuvf4OuBPv3XuuBt/tuD/re/ZHXusZ9++zr3WJm4NvyD/sR9P94H/IvfqUOR17IPDrCSfr/sT+LE2JJt+dQ9+9PXrZrggUHWIn/ffTj37rXXD83+v4/wB9/tvfuvH+XXA+/Yx17rgT7917rib/AO+/1/68+/de/LrgSfzz/vX/ABPvXXs9cD/vv9497691xP8Axv8A4r/vfv2Pz696jrif8P8AH6X9+48evefXAn37r3XE/wDFf99/X37Hr17PXEk/6/P49+x17/B1wP8Avv8Afce/de669+691kV/wf8Ab/8AFffuvdZPfuvdc0dk+n0/ofp7917qUkiv9OD+R+f+N+/de6zK9vryP95/437917rBLAGu8f1/Kj8/4j+h/wAPfuvdQ/fuvddEAj/ej7917rCQR9ffuvdde/de697917r3v3Xuve/de697917r3v3Xuve/de697917r3v3Xuve/de697917r3v3Xuve/de697917r3v3Xuve/de697917r3v3Xuve/de697917r//Ts9c/69hybf0FjY8fke/eXl17OPn1GZrXsB9LC45te9+fzf37j8XXqk9YCfr/AIf4f8T79178usZP+2/4p7917j1iJ+v9f9hb36vDr3+HrET/AL7/AA9+HXvPriH/AAf9hz/xv3vj9vW+OfPrxYfUf8j969OtZz1w1kf77/Ye7An1x1YNTHWeOW40k3P4P0vb6j/X92Pr1viKjrKH/qef6/n/AG/9ffgfMde8xnrKsv4P+3vz7uG9Org/PqZFOVP1Fj/tvx/Xj3bpzjkcenKGo5+v+8/73/j7tX9nXgag9O9PVEW5/wB8f9v7cDevV68R0pcZl/tnCOdUUhAdQT6T9Nan8kf0/PvWcny69XBz0qjMrKCDdSAQRb1KfoePr9PfuvZp1HaUC6nlCeT/ALbm44t73/h63geeemeriuCR/rj/AHr37qx86dJerj+v5/qP9t791uvr0n5wQfp/t/yB/tvfseuOvDH2dNryMrDSSCOQfz/t/wCnvQ9fPr3lw6kpMJlvwGAGpRxyf7Q/qD7qevV8+o8gIP5I/wBa1vftXp1YY6b5f99/xr6+/AUr06GNOopYjg8/kkWNv6/Tj3utOrh+HXHXb/eP99/r+91Pn04D6dclm+gv/vre7fMdXBpjrMsl+D+f98f9t72CRX06tX065eW1vyP+NHi/+w9uAhvt6cDeR65+ax+pv/UfXkc396pinVga0Pl1lWYP/S//ABS/P+t78cCnVSOsMrWHB/1gDcf8a96HXh/PptksSfoePrxzf+v+Pv3n1snPTXKPqP6f8R78x+fTZ9em2T6H/bj/AAtz7rwPVH+fTU/1+n0/33/Ee9NivWj/ACPUNzwf9j9f+R+2mrXpORSo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b6H8+99b+3j0JtFkoqyJZYZNSngj+0p/KuvNiP6f8Rb3rrXTqJFYAX5/H++/px7917PWJvoQeb/j/W/2P9ffut4/PqBMgN+Lj88A8fX/AFve/wA+tcOmaeL6kf77/H82+nvXDrfHpjqIbEkDg/Uf15+v+H/Ee/de+zpkqIb3I+v+w/24+liB7917pjmi1f4G3+wI+n+w59+63jy6ZKiIMSD/AFP+9244Pv3+DrXz6ZZ4iDyB+fp+bH6j839+/wAPXjnpnniNyQeT/vPv3XummVfx/r2P9P8AY/4+/f4OtdNkwK344/wPP4tbg+99ewfPqDIzXawAJH/FPxf6m3vQ4fPquKjqKWIP9R/j/wAV/PHvY+3PViAeuOu/+B/3m/8AX/ePfvTqpBHWRZPwePxf/ffn349bBI49eJvf/ff74e/U69g9Y2J+n9b/AOv/AKwv78D1UrTrETYgg/7zY/U/jn37y60OPDrKJA4seG/3gn/iD739p60ag16wS8f7yP8AXA/2N/eiPXq6kEdRXtyfx/xHvwJwOtMvn1DkH1YD6W4/H9Cf9t72RTratwB6jN/vXuvWyP29YmP+t+P99/vHvY6r+XWB/wCo/wBj70erKfLrCf8AkX9Pfsfl1b5dcCR+P99x+PfuvD08uuBP/E/09+69nrGT9fr/AMi/p+ffuvUpXrgx/wBsP99/tvfuvdYWb/ElT/trWP0sObj+vvY+XxdeFOPWInSeR/S1ybgf7An888fn341NM/6vz/1f5fVDZr1iJ/x/3i3vXXusZ/3jjj/ffj34+vXuuB/41/X/AIj37rfl1xJ/3jn37rXXAm3v3Hr3+Hrhc/1+n4/I/wCNe/de64k/4+/de64H+n0/439ffq9e64k/7D/kf+9+/fZ17/D1xPv3XuuB/wCRe/f4evfPrif+N8fQ/wCx9769wp1w4/1/99/Xn3rr3Dro+/de697917r3v3Xuve/de697917r3v3Xuve/de697917r3v3XuuwSPp7917rKGB/1/6e/de65e/de6yh/wCvH+P+++nv3Xuufv3XusbJ+R/tv+Ke/de6x+/de6xsn5H+2/4p7917rH7917r3v3Xuve/de697917r3v3Xuve/de697917r3v3Xuve/de697917r3v3Xuve/de697917r3v3Xuve/de697917r/9eykn/ff7x7917rET/vj9P+K+/de/PrESP999Px7917rGT/AL63++/p7917rETb/ffj/kfvXXvTrCx/4n/ff0t731vrETe/+t/vf/E+/da6xsf9v/xW/v1OveXWJj/T/Yf7z79177esRN7/AO8f77kH37r3z6x6yP8AW/4r/T3v169Xr2q/PAP+3uPfvs4db+Y64NJb82/I4P4te4v6hz7urCmR17Vwpx68JBzY2JN7fgWPFjf6e/UpgjHVqgfZ1yElufx/T6j6fX8H378+t9Zllt/vubn/AIm/uwNeJ62DTqSk3+PH4t/j/X+vu4Pzz04COp8NUVtc/wC+5974g9b8+nSGsKMroxDA3Bva30/w97Bx1uvSupa5KuMN9HH+cQfUHmzC/wCDf36lOvcK+fXbufqDa3+vcf4/4c+99e6hzESLf+19CPyLfm3+Pv3W65z0wVKaSQeL83H9fx/X3s0Ir1s5r69MUw0t+fz/AL7/ABPuvWq8emuXi9v+Rf6w/Hv3l1sEjyx1wiqGia/JQkah/X/G34It79T16tXqYzhgCGuCLqR/jYWP+3t71w4dbB86dQJuAT/Xgfn6cccA+9Ek0FKU6vqIp6dQHYk2/P8AsOPz9D/j71w+zrZJ6jFzf/D/AIpx/wAR7uPLq6sRTrj5P6Xt/rkfkf7x7tq4V6cVgeveX+vP+++nHu3zHTgIPXLy/wCNv8P99xf3vURx6t17zN/X/ef99b36oPl1r8+ujP8A4m//ACP8/wCw977eFOt0Prjrozhh9Dq/I/B/xHvWetU9T1Blb6m9j9Byf9j70cCg49V+Q4dNszXNv6f48/4+6Z6o1KcemyVrsf8AXt/rnj8+6+XDplumuVrknj/b/wBP+N+/NwA61wHyHUCRrD/XP++Hun+Hpk5qPXqG7m/1/wB6/r/j/r+6FR1Q+nUZnNje30Nv+K+9dtePTYHp1iFQUJt9PowJtcc/42DD/b+9nJpXqxBwT1nMqupKtc/m/wBb3NwQSdPHutQTU4HTFF9cdQ2Yck/UfQj/AIof9j+feqUxXrxABwesPkv+bkfn+n+v/h78a9V6zRVJUi5+v0J4/p/vv99f3rrXqelDjcvNRyLJE/BsHQk6HW/0I/rzwfqPe69b6E/G5aCuiDxsAwsHRrakJ/Df6pT+D9D/ALx71/h61T546eBID+R/r/7GxB9769g9cHF7kcni4+v4tf8A23vXXuoMif8AGv8AfX9+6900VEY5IH+uP9ubj8e/db6ZKiG3+Nrm97/4/Tj37r3TFUQ/kf74/wBR9fr+ffuvVr0y1MVxe39b8cn/AFvpzx7917plniBvcf8AFf8AXBP59+690yzx2v8AW31/wI/1Q/oQffv8PXumWojHNvrex+tjx9b/AEBt7969e4jpomWxvb/b2vb9N/8Abe/Z9cdaI8j01TKQT+AbWt9PwCRf+nv3XuIoeoMgt/sf9f6/8i9+68PMHj1gJ+vPv3W/8HXHWR/ieeD/AI3vz9T73+fVdI49c1kvx/vJ9+6qQR1yLf77/ffX36h63UHj1wP++/r79XrxGKjh1HJI5uLfgDn6gf7H6+/cCetih49diXV6Xv8A4G4A/wCI/r7916lMjri11/4g/jn8/wC29+6sD1gcc/8AEf48/wCHvwPTTL5jh1EkT8gcfkf778W9762reR6it9f99/sB71jqxFc+fWI/m/8AvJ/3v3v/AAdV4dR29Jt/vrce606cBrnrET7917ri3++/2H+8j37rw6xn/bc/4+/de9OsbEj6XP8ArD8D63/17+/Y86de49YWYW4HAseBz9LDgi3F/fiDXrXd8P8Aq/1fLrCT9R/r/wC9/wCva/v3kM9WPGvXD/ff8a96611jPF/99/j73Xrx4564k3/5F7917rgbfT68n/eB79nr3Drgf964/wAOD7917riT/vv9b37r3XA/1+v9B+Pfq+nXuuJP+x9+HXuuB/33+xHv3XuuJ/33+9e/de643H+t/vv9v9T79nr3z64E/wDG/fuvenXXv3Xuuvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691lV78Hj/H/AH309+691z9+691yViPryP8AevfuvdZgQfp7917riy35+h/3v37r3WH6cH37r3XBlvyPr/T+vv3XusXv3Xuve/de697917r3v3Xuve/de697917r3v3Xuve/de697917r3v3Xuve/de697917r3v3Xuve/de697917r/0LJWb/Efj/XPv3XsdYyffuvY6xE/4/14/wBb349ep506xE+/de6xEm/1/wB59+691jJ/33+8+9ceHXvXrCT7317rET/vv99/re/Hr3r1iJ/x/wCRf7fj37rxrx6xMfr/AMj9+695dYi3++/2Pv1Mde6xMxH0/wCJ/wAefzyfx/j72DTjw62PTrEX4A/HNvSQfxxyT78MZz17GSKZ646v8fyP+K+7q3ketjOOsiSfg8f778fj6+/EU+zrfz6ya7f7H6/7b6H34eletg/s65rLb/kfHP0+nvdadb4ceHUpJbfn/H/kfu9Qerg1p1NiqCL/AOxH+w92636V6daSueCRZEbkfUH6MPyrAfUG/vxPn1viM9KmKqSeNZU5v+peLq30sbH6+/deGOsbyEEkDn8j8MP8PfuOOvedeoc6rIuofj8f0JNiD/t/e+B6sDk14dJ+pXg8E/n/AH3H597PmQOtUpTOemSX8j+oP+8f8a964derinTc7aSSTb6/8a/rf3WpIx1rV5k9ejqfGSpJKt9RxxyAGFxe4I/3v36pwR1fuqPt/wAnUh2DcqdQP0b/AI2fe61AqKdWBNOoMn54/wB8D+PqPfvn59W1fLqC5Nza3+9g+9ilKdbB9T1g1jn8Ef1/3n3qp/Lq/Dz661/42PP+w/w/Hv1T6dWVh5nrjrP+vb/D/fce7B+rhmHXvL/vv+R+91A6vrrxPXEy/Xkf7EH/AIqfe6j163X5dcDKPrf/AB4v+P8AD3qtPPrVT1iM4YH/AFX+P0/2H+HvVT5dVPHj1Ame17XJ968h5HqjEmnTZKwsT+ebcn8/7D+nvQyfl00TU9NcjfX+v+vY/wC+PvTGufLrzGgp69QJG5P9B/vvp7r00eojva9/8f63/P8AvfuhNTjqnlXqDJIbEcD+gBsT/hf8e/AU4cem8V446hNILn/G9/p/UDgWv+P9j79kdb7OKnrGs7IxZT+eR+Dzxe491JzkY6aJFepfmWUa1PP9pb8gj/D/AIn3r8+tGhHHrA5vyt7/AOtybj6e/EHqvDNOsRc3H9k/1/r/AK/096+fXvz6zRVJU8G1v8f9h/rH/X9+9Ovfbw6fqDJy08iyxSFXH+PDDi4YHgqf8ffutY6E3F5qGujFiEnUXeO/J4/Ut/1Jf6/kf737rZr0/pOGFvz9ODyD/T/H3vrVOvOb/Xm30IH1/wB69669xINcdQpVBPI4NvrY2P8AXn6e/cet/KvTRURWP0Bve4t/vv68+/cevdM1RDa5X6Hkjj/bgW+ot7917HTFURDkgWv+P9fn37r3TJUQg/j63/Fr/wCP+uPfut9MlTELm4+nP0PH9SPzbj37rXHhx6YaiPSeeT/h9P6ixtx9b+/deHHh/q+zpmqYz9QLkcf6/wDtNzc+9+fXqcOmiVRzxcX+n9Pr+LH3rzz17pskQqbH6H6Hnn/jdh78etHPUJgQeb2/H++/33Pv3+Hr35Z6wk/74/77j37HW+uBP+w/P++P49+p17rtZSPryP8AAf8AEe919eqlfTrJqBFweD9P6W9+6rXiOuDH/Wtb/ff737314mnljrA9rXFr/wBP6j/b+9UzjrYcefXQltwwuv8Aj9R/X/bX96+3q1AeBz15v94P0/x/w/w974derWvWBv8AfD/iR72OHTRHGnUWRLfT/ff8V96PVlbyPUVv6/77/ivvw6sRXz6wtzx9Pe+tA06jt/T/AF/8eePx7r+XV+uBPP8Asbf7488E+/de49cCf+J/31vfutZ4DrCx+lvoOCTxex+hP0/B/wBb37zr148CadYXa5/pb6D8j+lv6W/p/X3qlOt+ecj/AFf6vn1iJ/r9efr+b/4+99e64En6/wC++n/FD78Ps695064H/ffT/fD37r3XE+/de64X/wB9x+P9f37h1rrgTxbn37rfXEn/AG/v3Xh1wP1+v9f9f6e/de+fXE/7x/rj6D6/717917/D1xJ/4j37r3l1wJ/33F+f9f6fX371698q9dX/ANb/AG9v9vbi/v3yPXuuJJ/330/3v3rr3XH3vr3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3XJWI+vI/3r37r3WUEH6e/de65AkfT37r3WUMG/wBf+nv3XuuyoP8AxX37r3WEgj6+/de64MoPP5/3319+691h+nB9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3X//0bImP+2/3w/w9+68KdYmb6/7b/eB/X3unXusbH+n+8f63vXDrw8usRP++/p/tuffuvDFfXrCx/3349+69/g6xsf96/2//FffuvdYieffutcaenWJj/sfz/tuT78PTrfWIn/ff778XHv3XusLc/n+v+9e/V691iZrfX/fcX5P+sPfvyx148D69R3PBIP5P0va/FiP8be9VzTr1TWny6jlrf1t/vj/AIe9g563XJI668n4J/2/1H+FuePe+PDrZoeHXtf0/wB9x/xX3dWrjrYNPt65rIR9fp/X8D34jrZHmOsuu35/33+8e9D08uvA9cllI/41e1uPqPdhjjw63Uj/AEvUlJvyCf8AffW3u4NerA+vHqZHOfpf/jX+t/t/dvL5dX6dqOvankBBJRuGX8MPp/rXHv3Xj0pRMsqCRGDK3I/x/wCKH/D3qvWuo7S6ST9QRYg8GxH+t73k8et6fKvTfUqCCyi9+f8Ae+P9h73WnHh1tfMHh0wVAF724+v1/wATx/vPv1Dnrw6Zp+B+f9gbf1/1+ef9f3TAanketLUNQ8Omx2+lzc/W/wBTc2uP68EfT3ao6tXJr1lgqtB0OboTe4+qn8H68j+vuuPLrdDSoPUt2B5vxx/rW/H+HveQOtgk9QJfqbf7H3oGnE9XHCvn1CkP9Prz+Prbn6+98KHrYan2dRmm5t/xo/7f3vHn1tcjh1jMv+JH+x/5H73jB62DTgOujMf9f6fj6Dn3rGaHqwfriZv8P9f8f7b6+9/n1vVwp1iM3+H+t9P+Ne/fb17V6dYWmP44+v8Avh9PesV49aLH16iSTHksR9ef6ni30/p73k4Ax1WpPA06b5JLnn8f7wD/AMSfeicEA9ex5nqDK4F+LX4/4p/rg+6cTXy6aJJ6gu31/wB99frz9PejjqhPl1Blfmw/PA/H/FbfT3TyJJ603kB+fTfK5/pwQb/4c2PNvqQP8PexSpznpsn8IJ49QXkHP/Iv68n37Pp17gAOo5e54t/rcg2/2Nj7pU5qOmifUdeWcq2q9iPz/W/4I+hB9+x1r7OpiyrKupeD/aX88/Vv8Rf3rr1KdY3JA45+gtxaw+v9PoPfuteeD1i13+lwRfi/+9cfX37rX5dZoaix5JH+x+n14I5sffuvV88dPVHkHhdZI3ZHUghlNiD/AMUPv3XuhJw+ejrQIpSEqQBwOFlA+pQHgH+o9+wQOvcKdKhJ9X+x/H1H9Ofzx79175dcnNwRxfj/AFv97P59+69xp1CkHHP1/H55/wBh/re/dbpw6a54/rYf7b8f4D37r3+DpkqYwPVb882/3v8A4r7917plqIb3It/vH4/of6j37r3HpgqYw34PHPAJ44JawIFhxe/v3/Hv8/Wx50PTDOnJ+n9q/wDSzG44P4B/H4/3rxBGPLrXEfP/AFf6vs6ZJ0Ivcf7D+oFv9hce/de6aJ4r8j6/W/5a1/r/AI+/da4dNMq8Efg8f6x/p/r+/enW+muVCDz9fx/sPp/vfv3lTr3UNrg2P4/xHv2OvY6xE/8AE/72ffuvdYyf9bi3+39+6910HZTxx+bfUfn8f63vXXj/AD6yCVT9eP8AW/31/duqU66Y/wDG/wDW/wB5/Hvfz6qV+WesDg/Uf7H/AIr791oHyJ64rKy8XDD/AH3+Nh9PesenVvn59dmx5FiP99/sfe+vV4g8esLci/H+I/4j3rqp4/PqK62/Frj/AA/23vx+3qymmD1Fa/8AiCPeuHVyK56wuCeR/vVvfj69VU0xTqOT/wAa/pf/AIj37z6v1idrfn8cX/LCxH9P+Kc+/D1Ix17yr5dYmPN+OOL/AJ/P9CLC3++/pocACOtfI9YS39f9f/bn3vGacOt/b1wP+8+/deyPLrgT/vv6f8R79178uuBP++/3r6+/de643BH/ABP+x/1re/evW+uBP++/w/3w974da64E/wC+/wB9+feuvdcCef8AX5/Fzx+fp79Tr3XRP++/3309+68fTrgffuvdcSf98f8AH37r3XE8/wDG/wDih49+691xP++/1vfvz69Trj7917r3v3Xuve/de697917r3v3Xuve/de697917r3v3Xuve/de697917r3v3Xuve/de697917r3v3Xuve/de67BINx7917rKrA/6/8AT37r3XL37r3WRX/r/t/fuvdcyAfr7917rEykf639f+K+/de64FQf+K+/de6wkEfX37r3XXv3Xuve/de697917r3v3Xuve/de697917r3v3Xuve/de697917r3v3Xuve/de697917r//SseY8/wC+/wBh/Qe/cevdYif99/vHv3XsdY2P++/24+nvw691iJ/3309+r+zr3WJjz7917rEx/wCJ/wB9c+/f4OvdYmP++/5Hx798+vfLrGx/33/FePfvP59e/PrCW/339Pfs9e6xE/n+v4/33+Hv3Xvy6jO9mF72+tha4sD/ALxc/n6+9+XDPW/z6js173+pN/6/7AX/ANb34/LrXkB1hY/X/bfj/fX96/Pr329YixHP/EH37r3z661/X/eR/j/X3bj9vVjQjhnrvX/jx/T+h/offgacetg0weuYlI/PH0/r/tvr+fduPDj1thXI49ZA9+eP95/3j34HrQPy65CQj6H/AA/339fe60z5dWqPIdSEm54+v9P99/T3cHq2qvn1Njmvbn/Yf7D/AG3vfCvVunmiyHhbS1/Ex9S/6n6eoW5497+fXunpnDD63B5Dfg/6x5496r17h5dRmbTcH9JBv/gD9T+L/X36pJ+fVq4r02VKAAkWIPIsOP6/UcX497rQ18uqkjpPTjgD6jkEi35/3om3vVBlfT/V/qz1s1OemiW9zcfQfX/H/fW9688nrVak149Rix/3n37y63w4dSIai37b/o5Cn8of8f8Aaffsjz6sDTh1kk4Nv6/71ex/Hv2r5dWrUceoDjmx+n4/33+Hv1cfPr3oeoE11P8Agfzzz/r8fWw9+Wmfl1eop1FaS34/43/vPvw49bDeXl1hMzf1/wBgP9b/AHn3appw6vUH7euJmb/ff8aHvwI8x16gxQdYzOTxYcf4+9Y61SvHrC0xJ/p/rfgj/H3uoGfPr2kdRXk/2P8ArfX3ok+Z60WUefUSST+v+2/31uPdf8HTZYnqG735P+2+v19+x1U+g49RJH+v++/p/vfuhNT1rgKnqBI/+Iv9R+TfkAj1D8f4e9cSBQ9NMfUcemuaTUTybX/4k24/H1/2/uxpgefVhTiePURzx/xUf6/H+t78cA56ox9eo7Nb/H/ePbdeqE0x1jMn+xt+f+N29+x6dVqOFM9drKVIZGsQfr/T/Cx4PvXXupiTiT6gBgLtbgcfkD+lvfutDri4v6kIP+t9ffv8HXvt4dYS5JBP1HF/8P8AEe/depTrLHUFSBcjn+vHH9P8Le/cRXr3+Dp3pq0qVIYgggggm4I+hBvcEW/Hv3p1r8uhEw24FnCQVThZuAkhsBJ+AHHAD/7YH/X9763jpZR1AYC5tfgf1/2H+t7114dcmYMOf1fi3A/2Hv3XvXqJKt/qAPwfp+f8f6ge/de6a54+DccX/wAP9v8A7b37r3TJURab8XB+osTb/H/Wt79xp17Plx6YauL6Ecnkkj+0OPooPA4597qfPy/1f6v9VdmoLfb0n6mPVc/7x+PpY6R+L+9Y8uteZPTNNFe4I/4r/t/fj17z6ZpoiCRb/H/X+ouP6H36vXumeeH6kC/F7H8/6wF+f8Pfvz6900yoCCD9ObNb6f8AFPfuvdNUq/i1iOAf6/7f6j36mOvdRT/vPvxr17rCx/of999P9uPexw4dUOD1wLf1/wCKf71791sH1646rG4/H+2968ut/n5dcxJfj/eD/h9bH+nv3XqV8uuyQf8AD8fT/ffT3uvTZXzp1gI4Fvx/tzf8/wBPeyOtBvXrHrK3t/tre/dW49ctQP0+n54+h/4379wp1oY+3rG3P+Pv3Xj5U6iv9bf69v8AiTz/AF966sDivUdv8Rz/AMj96+XWyK9RJOD9Bz/Xi1+OLixHP497wTWuf9R62Mgipr1Hdhfn+n9Rzxe9rcc8/j3qn7P9R/Pq1ACDTz6wk8G/1vf/AIrz79wNOtdcCf8AW/xH+v8A7f371691wPH++/2H+v798+vdcD7917rhf8fX/X9+69jPXE/719f8T/xX37/B177euHv3XuuJ/wB9/vvofeuvdcTb/X/2P9f9t/X3vPXuHl1wP+9f8V9+691xJ/P++v8AX3rr3XAnj/ffn/Yf197/AMHXqdcf+K/8j9+696564+/de697917r3v3Xuve/de697917r3v3Xuve/de697917r3v3Xuve/de697917r3v3Xuve/de697917r3v3Xuve/de697917r3v3Xusiv+D/ALf/AIr7917rJ7917rkrEfXkf776e/de6y8H/Ee/de64Mn5H+29+691iIBFj7917rEylf9b+vv3XuuPv3Xuve/de697917r3v3Xuve/de697917r3v3Xuve/de697917r3v3Xuve/de6/9Oxtj/sP99z7917rEx/3n/ivvw61w6xk/77/inv3W+sLH/ff77/AA9+9OvcaenWJjb37r3WMn/in++/B+nv3XsdYSf+NH8e/de6xk/6/v3XuHWEm/8Avv8Aff09+691hdrWJ/1Q4uQT/sB9f9b371A49er69RWP9Lg/X6m5/INzb6k+/Eg+Qr17H+r/AFenWAm//Ij/AL3+PfuvU/bTrGx/4p7917P59Yif6/X/AFx/vVvfuvfn1iJ/Iv8A7AD6/T6+/A/t68MdcdZ5/wB6/H+292werVBGePXg9x9fp9f8P969+rQ9erQ0p1zWQg/7a/8AxX/be90r1YjUMcesgkBFx9f6f8V/x97z1oAg549chIR+fp/yL/be9gjy6txz1ISbn+h92Br1sN5HqbHMOPrz/tv9f/X92qa9Wx+XTzR1+m0Mjek/oc/2T/qW/wBoP+8W96+XXvMdOMjXB/1je1rf7D/iPewfMde4GvUEyWBV7Wb6cX/w+vAtz72SeI4deYZFOPTRUJYsP9j/AIn+nP59+JyOt18x0yTg3v8A7cW/pz/sOPeiK/aOt8em+RrAW5/339f68+/dbHWAyW+oJt9f6+9Z60SPPqVDUhgI2PH9kn/oUm5v/h7rXNDx69kfZ13IDz+T+D/xv3s+tetg0rTpum5/1/8AH3qvkDjrYzmvTdIx/wBsef8AevdhT8urBuNOoxP+++v+w97J8uvfn1iLW+tuP99/T/D3ok9eDfPrC0g/r/vZ9+z5dbB6wNKOfqf+J/29vevLrVT646jvIfxx/vP/ABT3sde+3qOz/n6/1/4n3UmnHj1Wvp1GeS3P+8/6/wDvHupJJoOvUAFScdQpHvf+v/E/j6i3JH1964A0Oem2bNfLpvll4I4JIAv/AIW+pv8An/iR78FoATw60BqNTWnTexv/ALz/ALx/xHuw8/XrZP8ALqPI34/33+x/1vdGNTTptjTqKzWv/sPp/vXJ/PutD1QCo6xF/wDff8V/PvdOvaf29cS3+3/w/wBj9P8AW964da/ProSkH62I+jD8H8X97+fXupaTauOA304FgwH+H05/I96+fXvLh107Afj/AFyOf6WuPxf3759a8usRY/Vefybfm1v95Hv3W69c4qjSb3+h/wAP95+v+39+9OvdOtPWEWu39L/778ce/fl17pfYbcRslNVv6RYRTk3I/AWQkcj/AB/H5/r79Xr3z8+lxFUhwBe9/wDD/bf0/r7917rMXuLX+h4/P9RYH+nv3Xuo8guv+P8ArX/r+B9ffq08utjppqIwOQNQYfn/AA+ot9OAeffvXyPWs/6v9X+fpiqIbXt/ibfi4/I/2/v3XuHEdMFTCeSB/sLH6W+v+Kn34V8+vfLpkmh/oPzz/h/j/vv+R+690zVEV73BFv8Ae/8AWvax9+69nplmitxa3+H+35X+o9+6900TRfUiwABJH9f629+6900TICLfQ/2Tf/ePz7917pskWxI5DX/2B/1v+I97+fXs06inj6/7ze//ACP3rrXEdYWNr8/j/YAf8V978q9VIoaU6xhgfzf/AA/33PvXW6lceXXV/wDff763vx62M/Z1yD3sp/x/P15/r/X8e/V49e4D5ddEn8H8f77j3vPWioIr1hdiORzx+f6/T/X9++0deAx1i8luf9v79Xy69p9OsgkVgebccgi39L/m3v3WqH06xudRP+2/w/2/+x964Hj1unqc9Rn/AKn+h/Nv+R+99arTHUR7EEAj6mwADf7E8WFv9Y291BpXP+r/AFfPqwFakZP+odQmuL8nnm/0v/jYXBN7+7YAGOt+Xz6xE/717117riTfj/ffX/G34/2Pv3XvTrgT/vv999OPfuvdcCePr+P99/T8+/dep1xJ/wCN/wCtf349exXHXD349e64H/ff7G/v3+Drfz643/3n6WFz798z1o9cP+R8+/deP8uuJ9+6911/X/Y/8i9++fXsDrgef999bcX/AK/n37rf+Hrif99f37rXXXv3Xuve/de697917r3v3Xuve/de697917r3v3Xuve/de697917r3v3Xuve/de697917r3v3Xuve/de697917r3v3Xuve/de697917r3v3XuuQYj/W/p7917rKCD9PfuvdcgSPp7917rKGB/1/6e/de66Zb8j6/737917rER+CPfuvdYmW3I+n+9e/de64e/de697917r3v3Xuve/de697917r3v3Xuve/de697917r3v3Xuve/de6//1LFyeD/xHP8At/fuvHrGTx9f99/jx7917iesTH/iffuvY9esTH8+/de6xMbf6/8Axr6+/cevf4esTH/kX+w9+696nz6xE/77/H349eNesRP1/wB9/sP6e/de49YmYC5P0HJ96r17Pp1GkcEEG978CxH0v9bn/H+nv2MU4dePlmv+r/V69RiR/vv+I97+fXusTHj/AHm/9b/n37r3+HrET/yP349e/wAHWMn349e/PrCxP+v/AL179jr3CvWIn/ief99/X37P59e/Prjqt/tvduI6sDXrvX/vv6f6w9+rTrwOnrsOQbj/AHv8f7x/xr3biMnPV8MOsok1f69hzf8A3v8Ax964dayPPrkJLfn6f8b/AN7Huw9R17/D1Ijmt/rfn/ff4+7V62CRw4dS1m/x4/PP9T/T3vq4YEdPVNWhlWKQ3YC0bG/qH+pYg/X+l/6e/ZNfTz60Dk16ySt9bf7xwPrzxf8Aw97FOtmp+3qE0gb0txxYH/iD+OffvPrXDHTXUpbV9fz9P6+/efHrYPlXpnmBA/wH0/2Fvr/U2969et8CD1BZiP6f73z/ALY/j3qtOvEgY6wFv6H/AI3/ALC/vxzTGetCoOOpUNSzgRuwJB9LH6t9fSSfz71QEdWqOuEpJ/Frf7A+9UAxXrddPTdMOCR/vvx7twwetDDdQXYji9v+I90PaPn1Ymn2dRJG5t9R/T/ff09+UniePXhQDHHrAXN/9b/ivveoemOvV9OsLPa/I/33+839+1D069nrA0g/231J4/5F70WPl16nqcdRnlP9P8f6f1+vPPv1PU561qA4ceozv+Sf9t/tv8Le9E+nTZPEk9QZpvwP6i5+v0+oNh9eP9t79QYNetLUtU46bne/+va1+ePdvOvl1bhgdYHNh/vv9696JoK9aJ6iO1ufz+PdOPTJyeoxP+N/z731frAzXPH+8f0/rb+tvejkdUOTx6x6iPpx/h/yP3r8+tV668l+G4P+vx+P9t731vHXYcr+ePrb6fTm4/x9661w+3qWkwewNg1r/wBNR/1vwffvLr3zr1xe63IPB/33++49+6986dYma/I4b+gtY/T36vp17rmk5BAP4/x+lv8Ae/8Aex7117pyp6u1ueTb3vj17PS3wufMGmGoYtB9Fblmi+tvpyyf4fj8f09+690IENUsiBg6sjAMrBgR9L3VgSPp791759Zy9x9QfyD9L2sTe1v+Ke/D7PLr1KjB/wBX+qvUOVtRYWIBPIP1v/X/AFwffs+fWuJqemyZPqLc/U/X/bjge/dbpw6ZJ4bfT6f7Dj/W/qD7917pkqIrXIH+v/h/h/jf37r3THPDa55+t/pe1/z+OPfuvdM88V+Dcfm9vp/rcfpPv3+Hr1OFemSZPqCLc/4cH/D/AA9+690zzxWv/Q/W3Fv8Rf8AHv3XumqaO4t+fqDx9Db/AGN7+/Y/Pr2em2VLE2vcfUfS/wDxse/de6ityCP9v9ODf6/69/fv8HXvzx1Ea6/7D/ev6+/de661kWv/ALf/AH1/fuPEdap6HPXeoH/er+/U69UV68JLWB5AP+2+o/2Fj71+XW/TPXGQ8A8fjm3+H+PPvfXusBPv3XusZP5/31/98PfvlXr3XIPf6/X/AHj/AB/1vfuPXvy64OdQt6h9f0gE/wCFz9Pz/j78eBoc9ap/FTqHIbEi/wCb/wCBP155uP8AiPfh9v8Aq/1U6t86Z6jtY8f7b+v+x/2Hv3Ws49eozXB5/H+88/j/AAt73Tr3DrgT715der1wJub/AO+/33Hv3r1vh1xJNj/sPz/yL37Hn1r164H/AH3/ABT/AGHv3XuuBPv3XuuJ/wAf9t/vv629+631wP8Avv8Abf63v3WuuPv3XuuBPH/EW/4g249+8+vdcf8AeLf635/3n378utVr9nXH/ff73/vR9+8+t9de/de697917r3v3Xuve/de697917r3v3Xuve/de697917r3v3Xuve/de697917r3v3Xuve/de697917r3v3Xuve/de697917r3v3Xuve/de697917r3v3XuvXt7917rKr34PB/3j37r3XP37r3WVX/AK/7f37r3XZUH/X/AK+/de6xEEcH/jR/4r7917rCy25H0/I9+691w9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvdf/9WxQn/Y825+v++59+r16vWIn/YX9+691jY/77/b+/evWvLrCT/vv9vc+/f4et9YiffuvE9Y2P8Avv8AiPr/AF9+611hY/1/p/xT37rfz6xk/wC+/wB8PfuvfPqMx4BNySv04/1j+Db/AG3v2a4GD16nnj/VU9RiTb68fU/4n34nrXDrET/yIf74/X3rz6369YSbj/b/AOv+Pe/l17rGx+v++t7917rCx+v+w/r79nr3WIn/AH3+x/23v3y691iJ/wAB7969e8usRP8Axr+t/wDWt79Xr3r1x1f7cf717tWvVhnHXg3/ABX/AJH79WnWuHXev88X+vu46c4jPWUSA/U8/wCP+v7rmvVTUeXWRX/x+v0/1ve69br1kWa35twP6g/iwA4JPuwPDOOvfMcP8HWZJzxyQL3Xn/G9yBYE392NP9nreeB6e6aqE6aWP7q/qt/aB/t/nnj37/D1vj12/wDsfrwPzz+P8ffsHq1MfPqK5DBgfqPoT+RaxH9ffuPHj1UUrTppnXk/7V/T+o+ptz+feut+RHmOmiW4v/sbfj/Y+9+XW+NDXqCzH8f71/t/95Pv1aHHXic/LrH5CD9f9j/vvp7qc9e6mR1AlWzcyW+v+qA/JBvz/X3rz69X5CnWKX8/0N/+R+9E+Q49bGft6a5b3P8Avv8AX/r9Pfm4dbrq6b3bm97f1/r/AMRbj37y6bFfz6jSPbi5/wB5/wBgOPevn1avUYt/vv8AkX9PfiQOHXqnrCz/AJJH+3/p/r+/VJx1on556jvKAP6/617+90JOevVJ4DqFJMbE/wDEHgEcqefyfe6UNBx63Qfn8+oDNfgH+p/wJ5/339ffjStevVzx6wkgfU/7b8/j6cW9+JoOq1pX16iu9/bZyem2NcdRna5/23vY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DifLpV4nLy0jggloiQZIyfSR9Ljk6G/oR/vPv1OvU6Eyiq4quNZYnDX4P01IwH6WF7hv+Ne/deOenAAEH+v9R+Rb/Ye99aJp1EmQMD/UfX8f4X/2HvXW+meojAJH4I/P9Of9fkH349e6Y6iO1/6c344/w5/xHv3XumSoitcj6W5/1vwef6e/de6Y6iMWP+uQ3+H9LX/Hv3Xh0yzxg3vcW4Nj/rW/3r37r3TNOlgbj82YW/2x5+nv3Hr3TPOmn/ffi/8ATn+vv3XvLprlQE/644/p/vVuCffv8HXqHpua44NuOCP6e9Dr3USThj+L8297691iJP8Avv8AC/8AvHv35dep1jPv3XuuBPH+++n0+vPv3XvXriT/AL7+h+lvfuvZ6ws3+PH+H1+v4sTf/bfX37GevDjwr1wL24POr83J5uSOQPUObW+nvfn8x/q/1f8AFda4VIH+o/y661A/T6H88X/JA9662K9eDkf1P/FT/wAU9+x17h12bEf4c/jjj/D8+9fZ1s/Z1gcWuR9PwP6e99a6jS/S/wCRb/YDm1/9Y+/fLr3DrAb/AO+/1/fuvefDrgffuvdcSf8Aiv8AvuQR7917PXA/7f8Ax/3n/ff4e/de8uuPv3XuuJ9+691x/wBj/vuT/jz798+vfl1w/wAPfuvfb1x9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3XYJB9+691mBBFx7917rkCR9PfuvdZQwb/in+++vv3XuuDJbkfT+n9PfuvdR3Wxv+D/vHv3XuuHv3Xuve/de697917r3v3Xuve/de697917r3v3Xuv/Z";

        private System.IO.Stream GetBinaryDataStream(string base64String)
        {
            return new System.IO.MemoryStream(System.Convert.FromBase64String(base64String));
        }

        #endregion

    }
}
