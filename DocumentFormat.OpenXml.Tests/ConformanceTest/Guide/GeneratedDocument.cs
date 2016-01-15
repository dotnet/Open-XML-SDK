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

namespace DocumentFormat.OpenXml.Tests.GuideClass
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

            NotesMasterPart notesMasterPart1 = presentationPart1.AddNewPart<NotesMasterPart>("rId3");
            GenerateNotesMasterPart1Content(notesMasterPart1);

            ThemePart themePart1 = notesMasterPart1.AddNewPart<ThemePart>("rId1");
            GenerateThemePart1Content(themePart1);

            TableStylesPart tableStylesPart1 = presentationPart1.AddNewPart<TableStylesPart>("rId7");
            GenerateTableStylesPart1Content(tableStylesPart1);

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

            ThemePart themePart2 = slideMasterPart1.AddNewPart<ThemePart>("rId12");
            GenerateThemePart2Content(themePart2);

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

            presentationPart1.AddPart(themePart2, "rId6");

            ViewPropertiesPart viewPropertiesPart1 = presentationPart1.AddNewPart<ViewPropertiesPart>("rId5");
            GenerateViewPropertiesPart1Content(viewPropertiesPart1);

            PresentationPropertiesPart presentationPropertiesPart1 = presentationPart1.AddNewPart<PresentationPropertiesPart>("rId4");
            GeneratePresentationPropertiesPart1Content(presentationPropertiesPart1);

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
            SlideMasterId slideMasterId1 = new SlideMasterId(){ Id = (UInt32Value)2147483648U, RelationshipId = "rId1" };

            slideMasterIdList1.Append(slideMasterId1);

            NotesMasterIdList notesMasterIdList1 = new NotesMasterIdList();
            NotesMasterId notesMasterId1 = new NotesMasterId(){ Id = "rId3" };

            notesMasterIdList1.Append(notesMasterId1);

            SlideIdList slideIdList1 = new SlideIdList();
            SlideId slideId1 = new SlideId(){ Id = (UInt32Value)256U, RelationshipId = "rId2" };

            slideIdList1.Append(slideId1);
            SlideSize slideSize1 = new SlideSize(){ Cx = 9144000, Cy = 6858000, Type = SlideSizeValues.Screen4x3 };
            NotesSize notesSize1 = new NotesSize(){ Cx = 9144000L, Cy = 6858000L };

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

            P15.ExtendedGuide extendedGuide1 = new P15.ExtendedGuide(){ Id = (UInt32Value)1U, Orientation = DirectionValues.Horizontal, Position = 2160 };

            P15.ColorType colorType1 = new P15.ColorType();
            A.RgbColorModelHex rgbColorModelHex1 = new A.RgbColorModelHex(){ Val = "A4A3A4" };

            colorType1.Append(rgbColorModelHex1);

            extendedGuide1.Append(colorType1);

            P15.ExtendedGuide extendedGuide2 = new P15.ExtendedGuide(){ Id = (UInt32Value)2U, Position = 2880 };

            P15.ColorType colorType2 = new P15.ColorType();
            A.RgbColorModelHex rgbColorModelHex2 = new A.RgbColorModelHex(){ Val = "A4A3A4" };

            colorType2.Append(rgbColorModelHex2);

            extendedGuide2.Append(colorType2);

            slideGuideList1.Append(extendedGuide1);
            slideGuideList1.Append(extendedGuide2);

            presentationExtension1.Append(slideGuideList1);

            PresentationExtension presentationExtension2 = new PresentationExtension(){ Uri = "{2D200454-40CA-4A62-9FC3-DE9A4176ACB9}" };

            P15.NotesGuideList notesGuideList1 = new P15.NotesGuideList();
            notesGuideList1.AddNamespaceDeclaration("p15", "http://schemas.microsoft.com/office/powerpoint/2012/main");

            P15.ExtendedGuide extendedGuide3 = new P15.ExtendedGuide(){ Id = (UInt32Value)1U, Orientation = DirectionValues.Horizontal, Position = 2160 };

            P15.ColorType colorType3 = new P15.ColorType();
            A.RgbColorModelHex rgbColorModelHex3 = new A.RgbColorModelHex(){ Val = "A4A3A4" };

            colorType3.Append(rgbColorModelHex3);

            extendedGuide3.Append(colorType3);

            P15.ExtendedGuide extendedGuide4 = new P15.ExtendedGuide(){ Id = (UInt32Value)2U, Position = 2880 };

            P15.ColorType colorType4 = new P15.ColorType();
            A.RgbColorModelHex rgbColorModelHex4 = new A.RgbColorModelHex(){ Val = "A4A3A4" };

            colorType4.Append(rgbColorModelHex4);

            extendedGuide4.Append(colorType4);

            notesGuideList1.Append(extendedGuide3);
            notesGuideList1.Append(extendedGuide4);

            presentationExtension2.Append(notesGuideList1);

            presentationExtensionList1.Append(presentationExtension1);
            presentationExtensionList1.Append(presentationExtension2);

            presentation1.Append(slideMasterIdList1);
            presentation1.Append(notesMasterIdList1);
            presentation1.Append(slideIdList1);
            presentation1.Append(slideSize1);
            presentation1.Append(notesSize1);
            presentation1.Append(defaultTextStyle1);
            presentation1.Append(presentationExtensionList1);

            presentationPart1.Presentation = presentation1;
        }

        // Generates content of notesMasterPart1.
        private void GenerateNotesMasterPart1Content(NotesMasterPart notesMasterPart1)
        {
            NotesMaster notesMaster1 = new NotesMaster();
            notesMaster1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            notesMaster1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            notesMaster1.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData1 = new CommonSlideData();

            Background background1 = new Background();

            BackgroundStyleReference backgroundStyleReference1 = new BackgroundStyleReference(){ Index = (UInt32Value)1002U };
            A.SchemeColor schemeColor10 = new A.SchemeColor(){ Val = A.SchemeColorValues.Background2 };

            backgroundStyleReference1.Append(schemeColor10);

            background1.Append(backgroundStyleReference1);

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
            NonVisualDrawingProperties nonVisualDrawingProperties2 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Header Placeholder 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties1 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks1 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties1.Append(shapeLocks1);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties2 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape1 = new PlaceholderShape(){ Type = PlaceholderValues.Header, Size = PlaceholderSizeValues.Quarter };

            applicationNonVisualDrawingProperties2.Append(placeholderShape1);

            nonVisualShapeProperties1.Append(nonVisualDrawingProperties2);
            nonVisualShapeProperties1.Append(nonVisualShapeDrawingProperties1);
            nonVisualShapeProperties1.Append(applicationNonVisualDrawingProperties2);

            ShapeProperties shapeProperties1 = new ShapeProperties();

            A.Transform2D transform2D1 = new A.Transform2D();
            A.Offset offset2 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents2 = new A.Extents(){ Cx = 3962400L, Cy = 342900L };

            transform2D1.Append(offset2);
            transform2D1.Append(extents2);

            A.PresetGeometry presetGeometry1 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList1 = new A.AdjustValueList();

            presetGeometry1.Append(adjustValueList1);

            shapeProperties1.Append(transform2D1);
            shapeProperties1.Append(presetGeometry1);

            TextBody textBody1 = new TextBody();
            A.BodyProperties bodyProperties1 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal, LeftInset = 91440, TopInset = 45720, RightInset = 91440, BottomInset = 45720, RightToLeftColumns = false };

            A.ListStyle listStyle1 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties2 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Left };
            A.DefaultRunProperties defaultRunProperties11 = new A.DefaultRunProperties(){ FontSize = 1200 };

            level1ParagraphProperties2.Append(defaultRunProperties11);

            listStyle1.Append(level1ParagraphProperties2);

            A.Paragraph paragraph1 = new A.Paragraph();

            A.Run run1 = new A.Run();

            A.RunProperties runProperties1 = new A.RunProperties(){ Language = "en-US", Dirty = false };
            runProperties1.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text1 = new A.Text();
            text1.Text = "Adding Header to Notes ";

            run1.Append(runProperties1);
            run1.Append(text1);

            A.Run run2 = new A.Run();

            A.RunProperties runProperties2 = new A.RunProperties(){ Language = "en-US", Dirty = false, SpellingError = true };
            runProperties2.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text2 = new A.Text();
            text2.Text = "MAster";

            run2.Append(runProperties2);
            run2.Append(text2);
            A.EndParagraphRunProperties endParagraphRunProperties1 = new A.EndParagraphRunProperties(){ Language = "en-US", Dirty = false };

            paragraph1.Append(run1);
            paragraph1.Append(run2);
            paragraph1.Append(endParagraphRunProperties1);

            textBody1.Append(bodyProperties1);
            textBody1.Append(listStyle1);
            textBody1.Append(paragraph1);

            shape1.Append(nonVisualShapeProperties1);
            shape1.Append(shapeProperties1);
            shape1.Append(textBody1);

            Shape shape2 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties2 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties3 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Date Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties2 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks2 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties2.Append(shapeLocks2);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties3 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape2 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties3.Append(placeholderShape2);

            nonVisualShapeProperties2.Append(nonVisualDrawingProperties3);
            nonVisualShapeProperties2.Append(nonVisualShapeDrawingProperties2);
            nonVisualShapeProperties2.Append(applicationNonVisualDrawingProperties3);

            ShapeProperties shapeProperties2 = new ShapeProperties();

            A.Transform2D transform2D2 = new A.Transform2D();
            A.Offset offset3 = new A.Offset(){ X = 5179484L, Y = 0L };
            A.Extents extents3 = new A.Extents(){ Cx = 3962400L, Cy = 342900L };

            transform2D2.Append(offset3);
            transform2D2.Append(extents3);

            A.PresetGeometry presetGeometry2 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList2 = new A.AdjustValueList();

            presetGeometry2.Append(adjustValueList2);

            shapeProperties2.Append(transform2D2);
            shapeProperties2.Append(presetGeometry2);

            TextBody textBody2 = new TextBody();
            A.BodyProperties bodyProperties2 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal, LeftInset = 91440, TopInset = 45720, RightInset = 91440, BottomInset = 45720, RightToLeftColumns = false };

            A.ListStyle listStyle2 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties3 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Right };
            A.DefaultRunProperties defaultRunProperties12 = new A.DefaultRunProperties(){ FontSize = 1200 };

            level1ParagraphProperties3.Append(defaultRunProperties12);

            listStyle2.Append(level1ParagraphProperties3);

            A.Paragraph paragraph2 = new A.Paragraph();

            A.Field field1 = new A.Field(){ Id = "{CA3F9B49-9B0F-4F41-BDD8-B26D6525A1C4}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties3 = new A.RunProperties(){ Language = "en-US" };
            runProperties3.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text3 = new A.Text();
            text3.Text = "10/3/2012";

            field1.Append(runProperties3);
            field1.Append(text3);
            A.EndParagraphRunProperties endParagraphRunProperties2 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph2.Append(field1);
            paragraph2.Append(endParagraphRunProperties2);

            textBody2.Append(bodyProperties2);
            textBody2.Append(listStyle2);
            textBody2.Append(paragraph2);

            shape2.Append(nonVisualShapeProperties2);
            shape2.Append(shapeProperties2);
            shape2.Append(textBody2);

            Shape shape3 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties3 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties4 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Slide Image Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties3 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks3 = new A.ShapeLocks(){ NoGrouping = true, NoRotation = true, NoChangeAspect = true };

            nonVisualShapeDrawingProperties3.Append(shapeLocks3);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties4 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape3 = new PlaceholderShape(){ Type = PlaceholderValues.SlideImage, Index = (UInt32Value)2U };

            applicationNonVisualDrawingProperties4.Append(placeholderShape3);

            nonVisualShapeProperties3.Append(nonVisualDrawingProperties4);
            nonVisualShapeProperties3.Append(nonVisualShapeDrawingProperties3);
            nonVisualShapeProperties3.Append(applicationNonVisualDrawingProperties4);

            ShapeProperties shapeProperties3 = new ShapeProperties();

            A.Transform2D transform2D3 = new A.Transform2D();
            A.Offset offset4 = new A.Offset(){ X = 2857500L, Y = 514350L };
            A.Extents extents4 = new A.Extents(){ Cx = 3429000L, Cy = 2571750L };

            transform2D3.Append(offset4);
            transform2D3.Append(extents4);

            A.PresetGeometry presetGeometry3 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList3 = new A.AdjustValueList();

            presetGeometry3.Append(adjustValueList3);
            A.NoFill noFill1 = new A.NoFill();

            A.Outline outline1 = new A.Outline(){ Width = 12700 };

            A.SolidFill solidFill10 = new A.SolidFill();
            A.PresetColor presetColor1 = new A.PresetColor(){ Val = A.PresetColorValues.Black };

            solidFill10.Append(presetColor1);

            outline1.Append(solidFill10);

            shapeProperties3.Append(transform2D3);
            shapeProperties3.Append(presetGeometry3);
            shapeProperties3.Append(noFill1);
            shapeProperties3.Append(outline1);

            TextBody textBody3 = new TextBody();
            A.BodyProperties bodyProperties3 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal, LeftInset = 91440, TopInset = 45720, RightInset = 91440, BottomInset = 45720, RightToLeftColumns = false, Anchor = A.TextAnchoringTypeValues.Center };
            A.ListStyle listStyle3 = new A.ListStyle();

            A.Paragraph paragraph3 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties3 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph3.Append(endParagraphRunProperties3);

            textBody3.Append(bodyProperties3);
            textBody3.Append(listStyle3);
            textBody3.Append(paragraph3);

            shape3.Append(nonVisualShapeProperties3);
            shape3.Append(shapeProperties3);
            shape3.Append(textBody3);

            Shape shape4 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties4 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties5 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Notes Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties4 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks4 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties4.Append(shapeLocks4);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties5 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape4 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)3U };

            applicationNonVisualDrawingProperties5.Append(placeholderShape4);

            nonVisualShapeProperties4.Append(nonVisualDrawingProperties5);
            nonVisualShapeProperties4.Append(nonVisualShapeDrawingProperties4);
            nonVisualShapeProperties4.Append(applicationNonVisualDrawingProperties5);

            ShapeProperties shapeProperties4 = new ShapeProperties();

            A.Transform2D transform2D4 = new A.Transform2D();
            A.Offset offset5 = new A.Offset(){ X = 914400L, Y = 3257550L };
            A.Extents extents5 = new A.Extents(){ Cx = 7315200L, Cy = 3086100L };

            transform2D4.Append(offset5);
            transform2D4.Append(extents5);

            A.PresetGeometry presetGeometry4 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList4 = new A.AdjustValueList();

            presetGeometry4.Append(adjustValueList4);

            shapeProperties4.Append(transform2D4);
            shapeProperties4.Append(presetGeometry4);

            TextBody textBody4 = new TextBody();

            A.BodyProperties bodyProperties4 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal, LeftInset = 91440, TopInset = 45720, RightInset = 91440, BottomInset = 45720, RightToLeftColumns = false };
            A.NormalAutoFit normalAutoFit1 = new A.NormalAutoFit();

            bodyProperties4.Append(normalAutoFit1);
            A.ListStyle listStyle4 = new A.ListStyle();

            A.Paragraph paragraph4 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties1 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run3 = new A.Run();

            A.RunProperties runProperties4 = new A.RunProperties(){ Language = "en-US", Dirty = false };
            runProperties4.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text4 = new A.Text();
            text4.Text = "Testing text on Notes Master";

            run3.Append(runProperties4);
            run3.Append(text4);

            paragraph4.Append(paragraphProperties1);
            paragraph4.Append(run3);

            A.Paragraph paragraph5 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties2 = new A.ParagraphProperties(){ Level = 1 };

            A.Run run4 = new A.Run();

            A.RunProperties runProperties5 = new A.RunProperties(){ Language = "en-US", Dirty = false };
            runProperties5.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text5 = new A.Text();
            text5.Text = "Second level";

            run4.Append(runProperties5);
            run4.Append(text5);

            paragraph5.Append(paragraphProperties2);
            paragraph5.Append(run4);

            A.Paragraph paragraph6 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties3 = new A.ParagraphProperties(){ Level = 2 };

            A.Run run5 = new A.Run();

            A.RunProperties runProperties6 = new A.RunProperties(){ Language = "en-US", Dirty = false };
            runProperties6.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text6 = new A.Text();
            text6.Text = "Third level";

            run5.Append(runProperties6);
            run5.Append(text6);

            paragraph6.Append(paragraphProperties3);
            paragraph6.Append(run5);

            A.Paragraph paragraph7 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties4 = new A.ParagraphProperties(){ Level = 3 };

            A.Run run6 = new A.Run();

            A.RunProperties runProperties7 = new A.RunProperties(){ Language = "en-US", Dirty = false };
            runProperties7.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text7 = new A.Text();
            text7.Text = "Fourth level";

            run6.Append(runProperties7);
            run6.Append(text7);

            paragraph7.Append(paragraphProperties4);
            paragraph7.Append(run6);

            A.Paragraph paragraph8 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties5 = new A.ParagraphProperties(){ Level = 4 };

            A.Run run7 = new A.Run();

            A.RunProperties runProperties8 = new A.RunProperties(){ Language = "en-US", Dirty = false };
            runProperties8.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text8 = new A.Text();
            text8.Text = "Fifth level";

            run7.Append(runProperties8);
            run7.Append(text8);
            A.EndParagraphRunProperties endParagraphRunProperties4 = new A.EndParagraphRunProperties(){ Language = "en-US", Dirty = false };

            paragraph8.Append(paragraphProperties5);
            paragraph8.Append(run7);
            paragraph8.Append(endParagraphRunProperties4);

            textBody4.Append(bodyProperties4);
            textBody4.Append(listStyle4);
            textBody4.Append(paragraph4);
            textBody4.Append(paragraph5);
            textBody4.Append(paragraph6);
            textBody4.Append(paragraph7);
            textBody4.Append(paragraph8);

            shape4.Append(nonVisualShapeProperties4);
            shape4.Append(shapeProperties4);
            shape4.Append(textBody4);

            Shape shape5 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties5 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties6 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Footer Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties5 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks5 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties5.Append(shapeLocks5);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties6 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape5 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)4U };

            applicationNonVisualDrawingProperties6.Append(placeholderShape5);

            nonVisualShapeProperties5.Append(nonVisualDrawingProperties6);
            nonVisualShapeProperties5.Append(nonVisualShapeDrawingProperties5);
            nonVisualShapeProperties5.Append(applicationNonVisualDrawingProperties6);

            ShapeProperties shapeProperties5 = new ShapeProperties();

            A.Transform2D transform2D5 = new A.Transform2D();
            A.Offset offset6 = new A.Offset(){ X = 0L, Y = 6513910L };
            A.Extents extents6 = new A.Extents(){ Cx = 3962400L, Cy = 342900L };

            transform2D5.Append(offset6);
            transform2D5.Append(extents6);

            A.PresetGeometry presetGeometry5 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList5 = new A.AdjustValueList();

            presetGeometry5.Append(adjustValueList5);

            shapeProperties5.Append(transform2D5);
            shapeProperties5.Append(presetGeometry5);

            TextBody textBody5 = new TextBody();
            A.BodyProperties bodyProperties5 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal, LeftInset = 91440, TopInset = 45720, RightInset = 91440, BottomInset = 45720, RightToLeftColumns = false, Anchor = A.TextAnchoringTypeValues.Bottom };

            A.ListStyle listStyle5 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties4 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Left };
            A.DefaultRunProperties defaultRunProperties13 = new A.DefaultRunProperties(){ FontSize = 1200 };

            level1ParagraphProperties4.Append(defaultRunProperties13);

            listStyle5.Append(level1ParagraphProperties4);

            A.Paragraph paragraph9 = new A.Paragraph();

            A.Run run8 = new A.Run();

            A.RunProperties runProperties9 = new A.RunProperties(){ Language = "en-US", Dirty = false };
            runProperties9.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text9 = new A.Text();
            text9.Text = "Adding Footer to Notes Master";

            run8.Append(runProperties9);
            run8.Append(text9);
            A.EndParagraphRunProperties endParagraphRunProperties5 = new A.EndParagraphRunProperties(){ Language = "en-US", Dirty = false };

            paragraph9.Append(run8);
            paragraph9.Append(endParagraphRunProperties5);

            textBody5.Append(bodyProperties5);
            textBody5.Append(listStyle5);
            textBody5.Append(paragraph9);

            shape5.Append(nonVisualShapeProperties5);
            shape5.Append(shapeProperties5);
            shape5.Append(textBody5);

            shapeTree1.Append(nonVisualGroupShapeProperties1);
            shapeTree1.Append(groupShapeProperties1);
            shapeTree1.Append(shape1);
            shapeTree1.Append(shape2);
            shapeTree1.Append(shape3);
            shapeTree1.Append(shape4);
            shapeTree1.Append(shape5);

            CommonSlideDataExtensionList commonSlideDataExtensionList1 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension1 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId1 = new P14.CreationId(){ Val = (UInt32Value)3631591638U };
            creationId1.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension1.Append(creationId1);

            commonSlideDataExtensionList1.Append(commonSlideDataExtension1);

            commonSlideData1.Append(background1);
            commonSlideData1.Append(shapeTree1);
            commonSlideData1.Append(commonSlideDataExtensionList1);
            ColorMap colorMap1 = new ColorMap(){ Background1 = A.ColorSchemeIndexValues.Dark1, Text1 = A.ColorSchemeIndexValues.Light1, Background2 = A.ColorSchemeIndexValues.Dark2, Text2 = A.ColorSchemeIndexValues.Light2, Accent1 = A.ColorSchemeIndexValues.Accent1, Accent2 = A.ColorSchemeIndexValues.Accent2, Accent3 = A.ColorSchemeIndexValues.Accent3, Accent4 = A.ColorSchemeIndexValues.Accent4, Accent5 = A.ColorSchemeIndexValues.Accent5, Accent6 = A.ColorSchemeIndexValues.Accent6, Hyperlink = A.ColorSchemeIndexValues.Hyperlink, FollowedHyperlink = A.ColorSchemeIndexValues.FollowedHyperlink };

            NotesStyle notesStyle1 = new NotesStyle();

            A.Level1ParagraphProperties level1ParagraphProperties5 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties14 = new A.DefaultRunProperties(){ FontSize = 1200, Kerning = 1200, Baseline = 0 };

            A.SolidFill solidFill11 = new A.SolidFill();
            A.SchemeColor schemeColor11 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill11.Append(schemeColor11);
            A.LatinFont latinFont10 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont10 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont10 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties14.Append(solidFill11);
            defaultRunProperties14.Append(latinFont10);
            defaultRunProperties14.Append(eastAsianFont10);
            defaultRunProperties14.Append(complexScriptFont10);

            level1ParagraphProperties5.Append(defaultRunProperties14);

            A.Level2ParagraphProperties level2ParagraphProperties2 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties15 = new A.DefaultRunProperties(){ FontSize = 1200, Kerning = 1200 };

            A.SolidFill solidFill12 = new A.SolidFill();
            A.SchemeColor schemeColor12 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill12.Append(schemeColor12);
            A.LatinFont latinFont11 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont11 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont11 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties15.Append(solidFill12);
            defaultRunProperties15.Append(latinFont11);
            defaultRunProperties15.Append(eastAsianFont11);
            defaultRunProperties15.Append(complexScriptFont11);

            level2ParagraphProperties2.Append(defaultRunProperties15);

            A.Level3ParagraphProperties level3ParagraphProperties2 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties16 = new A.DefaultRunProperties(){ FontSize = 1200, Kerning = 1200 };

            A.SolidFill solidFill13 = new A.SolidFill();
            A.SchemeColor schemeColor13 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill13.Append(schemeColor13);
            A.LatinFont latinFont12 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont12 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont12 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties16.Append(solidFill13);
            defaultRunProperties16.Append(latinFont12);
            defaultRunProperties16.Append(eastAsianFont12);
            defaultRunProperties16.Append(complexScriptFont12);

            level3ParagraphProperties2.Append(defaultRunProperties16);

            A.Level4ParagraphProperties level4ParagraphProperties2 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties17 = new A.DefaultRunProperties(){ FontSize = 1200, Kerning = 1200 };

            A.SolidFill solidFill14 = new A.SolidFill();
            A.SchemeColor schemeColor14 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill14.Append(schemeColor14);
            A.LatinFont latinFont13 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont13 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont13 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties17.Append(solidFill14);
            defaultRunProperties17.Append(latinFont13);
            defaultRunProperties17.Append(eastAsianFont13);
            defaultRunProperties17.Append(complexScriptFont13);

            level4ParagraphProperties2.Append(defaultRunProperties17);

            A.Level5ParagraphProperties level5ParagraphProperties2 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties18 = new A.DefaultRunProperties(){ FontSize = 1200, Kerning = 1200 };

            A.SolidFill solidFill15 = new A.SolidFill();
            A.SchemeColor schemeColor15 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill15.Append(schemeColor15);
            A.LatinFont latinFont14 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont14 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont14 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties18.Append(solidFill15);
            defaultRunProperties18.Append(latinFont14);
            defaultRunProperties18.Append(eastAsianFont14);
            defaultRunProperties18.Append(complexScriptFont14);

            level5ParagraphProperties2.Append(defaultRunProperties18);

            A.Level6ParagraphProperties level6ParagraphProperties2 = new A.Level6ParagraphProperties(){ LeftMargin = 2286000, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties19 = new A.DefaultRunProperties(){ FontSize = 1200, Kerning = 1200 };

            A.SolidFill solidFill16 = new A.SolidFill();
            A.SchemeColor schemeColor16 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill16.Append(schemeColor16);
            A.LatinFont latinFont15 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont15 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont15 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties19.Append(solidFill16);
            defaultRunProperties19.Append(latinFont15);
            defaultRunProperties19.Append(eastAsianFont15);
            defaultRunProperties19.Append(complexScriptFont15);

            level6ParagraphProperties2.Append(defaultRunProperties19);

            A.Level7ParagraphProperties level7ParagraphProperties2 = new A.Level7ParagraphProperties(){ LeftMargin = 2743200, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties20 = new A.DefaultRunProperties(){ FontSize = 1200, Kerning = 1200 };

            A.SolidFill solidFill17 = new A.SolidFill();
            A.SchemeColor schemeColor17 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill17.Append(schemeColor17);
            A.LatinFont latinFont16 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont16 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont16 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties20.Append(solidFill17);
            defaultRunProperties20.Append(latinFont16);
            defaultRunProperties20.Append(eastAsianFont16);
            defaultRunProperties20.Append(complexScriptFont16);

            level7ParagraphProperties2.Append(defaultRunProperties20);

            A.Level8ParagraphProperties level8ParagraphProperties2 = new A.Level8ParagraphProperties(){ LeftMargin = 3200400, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties21 = new A.DefaultRunProperties(){ FontSize = 1200, Kerning = 1200 };

            A.SolidFill solidFill18 = new A.SolidFill();
            A.SchemeColor schemeColor18 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill18.Append(schemeColor18);
            A.LatinFont latinFont17 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont17 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont17 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties21.Append(solidFill18);
            defaultRunProperties21.Append(latinFont17);
            defaultRunProperties21.Append(eastAsianFont17);
            defaultRunProperties21.Append(complexScriptFont17);

            level8ParagraphProperties2.Append(defaultRunProperties21);

            A.Level9ParagraphProperties level9ParagraphProperties2 = new A.Level9ParagraphProperties(){ LeftMargin = 3657600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties22 = new A.DefaultRunProperties(){ FontSize = 1200, Kerning = 1200 };

            A.SolidFill solidFill19 = new A.SolidFill();
            A.SchemeColor schemeColor19 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill19.Append(schemeColor19);
            A.LatinFont latinFont18 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont18 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont18 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties22.Append(solidFill19);
            defaultRunProperties22.Append(latinFont18);
            defaultRunProperties22.Append(eastAsianFont18);
            defaultRunProperties22.Append(complexScriptFont18);

            level9ParagraphProperties2.Append(defaultRunProperties22);

            notesStyle1.Append(level1ParagraphProperties5);
            notesStyle1.Append(level2ParagraphProperties2);
            notesStyle1.Append(level3ParagraphProperties2);
            notesStyle1.Append(level4ParagraphProperties2);
            notesStyle1.Append(level5ParagraphProperties2);
            notesStyle1.Append(level6ParagraphProperties2);
            notesStyle1.Append(level7ParagraphProperties2);
            notesStyle1.Append(level8ParagraphProperties2);
            notesStyle1.Append(level9ParagraphProperties2);

            notesMaster1.Append(commonSlideData1);
            notesMaster1.Append(colorMap1);
            notesMaster1.Append(notesStyle1);

            notesMasterPart1.NotesMaster = notesMaster1;
        }

        // Generates content of themePart1.
        private void GenerateThemePart1Content(ThemePart themePart1)
        {
            A.Theme theme1 = new A.Theme(){ Name = "Office Theme" };
            theme1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            A.ThemeElements themeElements1 = new A.ThemeElements();

            A.ColorScheme colorScheme1 = new A.ColorScheme(){ Name = "Oriel" };

            A.Dark1Color dark1Color1 = new A.Dark1Color();
            A.SystemColor systemColor1 = new A.SystemColor(){ Val = A.SystemColorValues.WindowText, LastColor = "000000" };

            dark1Color1.Append(systemColor1);

            A.Light1Color light1Color1 = new A.Light1Color();
            A.SystemColor systemColor2 = new A.SystemColor(){ Val = A.SystemColorValues.Window, LastColor = "FFFFFF" };

            light1Color1.Append(systemColor2);

            A.Dark2Color dark2Color1 = new A.Dark2Color();
            A.RgbColorModelHex rgbColorModelHex5 = new A.RgbColorModelHex(){ Val = "575F6D" };

            dark2Color1.Append(rgbColorModelHex5);

            A.Light2Color light2Color1 = new A.Light2Color();
            A.RgbColorModelHex rgbColorModelHex6 = new A.RgbColorModelHex(){ Val = "FFF39D" };

            light2Color1.Append(rgbColorModelHex6);

            A.Accent1Color accent1Color1 = new A.Accent1Color();
            A.RgbColorModelHex rgbColorModelHex7 = new A.RgbColorModelHex(){ Val = "FE8637" };

            accent1Color1.Append(rgbColorModelHex7);

            A.Accent2Color accent2Color1 = new A.Accent2Color();
            A.RgbColorModelHex rgbColorModelHex8 = new A.RgbColorModelHex(){ Val = "7598D9" };

            accent2Color1.Append(rgbColorModelHex8);

            A.Accent3Color accent3Color1 = new A.Accent3Color();
            A.RgbColorModelHex rgbColorModelHex9 = new A.RgbColorModelHex(){ Val = "B32C16" };

            accent3Color1.Append(rgbColorModelHex9);

            A.Accent4Color accent4Color1 = new A.Accent4Color();
            A.RgbColorModelHex rgbColorModelHex10 = new A.RgbColorModelHex(){ Val = "F5CD2D" };

            accent4Color1.Append(rgbColorModelHex10);

            A.Accent5Color accent5Color1 = new A.Accent5Color();
            A.RgbColorModelHex rgbColorModelHex11 = new A.RgbColorModelHex(){ Val = "AEBAD5" };

            accent5Color1.Append(rgbColorModelHex11);

            A.Accent6Color accent6Color1 = new A.Accent6Color();
            A.RgbColorModelHex rgbColorModelHex12 = new A.RgbColorModelHex(){ Val = "777C84" };

            accent6Color1.Append(rgbColorModelHex12);

            A.Hyperlink hyperlink1 = new A.Hyperlink();
            A.RgbColorModelHex rgbColorModelHex13 = new A.RgbColorModelHex(){ Val = "D2611C" };

            hyperlink1.Append(rgbColorModelHex13);

            A.FollowedHyperlinkColor followedHyperlinkColor1 = new A.FollowedHyperlinkColor();
            A.RgbColorModelHex rgbColorModelHex14 = new A.RgbColorModelHex(){ Val = "3B435B" };

            followedHyperlinkColor1.Append(rgbColorModelHex14);

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

            A.FontScheme fontScheme1 = new A.FontScheme(){ Name = "Verve" };

            A.MajorFont majorFont1 = new A.MajorFont();
            A.LatinFont latinFont19 = new A.LatinFont(){ Typeface = "Century Gothic" };
            A.EastAsianFont eastAsianFont19 = new A.EastAsianFont(){ Typeface = "" };
            A.ComplexScriptFont complexScriptFont19 = new A.ComplexScriptFont(){ Typeface = "" };
            A.SupplementalFont supplementalFont1 = new A.SupplementalFont(){ Script = "Jpan", Typeface = "HGｺﾞｼｯｸM" };
            A.SupplementalFont supplementalFont2 = new A.SupplementalFont(){ Script = "Hang", Typeface = "HY중고딕" };
            A.SupplementalFont supplementalFont3 = new A.SupplementalFont(){ Script = "Hans", Typeface = "幼圆" };
            A.SupplementalFont supplementalFont4 = new A.SupplementalFont(){ Script = "Hant", Typeface = "微軟正黑體" };
            A.SupplementalFont supplementalFont5 = new A.SupplementalFont(){ Script = "Arab", Typeface = "Tahoma" };
            A.SupplementalFont supplementalFont6 = new A.SupplementalFont(){ Script = "Hebr", Typeface = "Gisha" };
            A.SupplementalFont supplementalFont7 = new A.SupplementalFont(){ Script = "Thai", Typeface = "DilleniaUPC" };
            A.SupplementalFont supplementalFont8 = new A.SupplementalFont(){ Script = "Ethi", Typeface = "Nyala" };
            A.SupplementalFont supplementalFont9 = new A.SupplementalFont(){ Script = "Beng", Typeface = "Vrinda" };
            A.SupplementalFont supplementalFont10 = new A.SupplementalFont(){ Script = "Gujr", Typeface = "Shruti" };
            A.SupplementalFont supplementalFont11 = new A.SupplementalFont(){ Script = "Khmr", Typeface = "DaunPenh" };
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
            A.SupplementalFont supplementalFont28 = new A.SupplementalFont(){ Script = "Viet", Typeface = "Tahoma" };
            A.SupplementalFont supplementalFont29 = new A.SupplementalFont(){ Script = "Uigh", Typeface = "Microsoft Uighur" };

            majorFont1.Append(latinFont19);
            majorFont1.Append(eastAsianFont19);
            majorFont1.Append(complexScriptFont19);
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

            A.MinorFont minorFont1 = new A.MinorFont();
            A.LatinFont latinFont20 = new A.LatinFont(){ Typeface = "Century Gothic" };
            A.EastAsianFont eastAsianFont20 = new A.EastAsianFont(){ Typeface = "" };
            A.ComplexScriptFont complexScriptFont20 = new A.ComplexScriptFont(){ Typeface = "" };
            A.SupplementalFont supplementalFont30 = new A.SupplementalFont(){ Script = "Jpan", Typeface = "ＭＳ ゴシック" };
            A.SupplementalFont supplementalFont31 = new A.SupplementalFont(){ Script = "Hang", Typeface = "HY중고딕" };
            A.SupplementalFont supplementalFont32 = new A.SupplementalFont(){ Script = "Hans", Typeface = "幼圆" };
            A.SupplementalFont supplementalFont33 = new A.SupplementalFont(){ Script = "Hant", Typeface = "微軟正黑體" };
            A.SupplementalFont supplementalFont34 = new A.SupplementalFont(){ Script = "Arab", Typeface = "Tahoma" };
            A.SupplementalFont supplementalFont35 = new A.SupplementalFont(){ Script = "Hebr", Typeface = "Gisha" };
            A.SupplementalFont supplementalFont36 = new A.SupplementalFont(){ Script = "Thai", Typeface = "DilleniaUPC" };
            A.SupplementalFont supplementalFont37 = new A.SupplementalFont(){ Script = "Ethi", Typeface = "Nyala" };
            A.SupplementalFont supplementalFont38 = new A.SupplementalFont(){ Script = "Beng", Typeface = "Vrinda" };
            A.SupplementalFont supplementalFont39 = new A.SupplementalFont(){ Script = "Gujr", Typeface = "Shruti" };
            A.SupplementalFont supplementalFont40 = new A.SupplementalFont(){ Script = "Khmr", Typeface = "DaunPenh" };
            A.SupplementalFont supplementalFont41 = new A.SupplementalFont(){ Script = "Knda", Typeface = "Tunga" };
            A.SupplementalFont supplementalFont42 = new A.SupplementalFont(){ Script = "Guru", Typeface = "Raavi" };
            A.SupplementalFont supplementalFont43 = new A.SupplementalFont(){ Script = "Cans", Typeface = "Euphemia" };
            A.SupplementalFont supplementalFont44 = new A.SupplementalFont(){ Script = "Cher", Typeface = "Plantagenet Cherokee" };
            A.SupplementalFont supplementalFont45 = new A.SupplementalFont(){ Script = "Yiii", Typeface = "Microsoft Yi Baiti" };
            A.SupplementalFont supplementalFont46 = new A.SupplementalFont(){ Script = "Tibt", Typeface = "Microsoft Himalaya" };
            A.SupplementalFont supplementalFont47 = new A.SupplementalFont(){ Script = "Thaa", Typeface = "MV Boli" };
            A.SupplementalFont supplementalFont48 = new A.SupplementalFont(){ Script = "Deva", Typeface = "Mangal" };
            A.SupplementalFont supplementalFont49 = new A.SupplementalFont(){ Script = "Telu", Typeface = "Gautami" };
            A.SupplementalFont supplementalFont50 = new A.SupplementalFont(){ Script = "Taml", Typeface = "Latha" };
            A.SupplementalFont supplementalFont51 = new A.SupplementalFont(){ Script = "Syrc", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont52 = new A.SupplementalFont(){ Script = "Orya", Typeface = "Kalinga" };
            A.SupplementalFont supplementalFont53 = new A.SupplementalFont(){ Script = "Mlym", Typeface = "Kartika" };
            A.SupplementalFont supplementalFont54 = new A.SupplementalFont(){ Script = "Laoo", Typeface = "DokChampa" };
            A.SupplementalFont supplementalFont55 = new A.SupplementalFont(){ Script = "Sinh", Typeface = "Iskoola Pota" };
            A.SupplementalFont supplementalFont56 = new A.SupplementalFont(){ Script = "Mong", Typeface = "Mongolian Baiti" };
            A.SupplementalFont supplementalFont57 = new A.SupplementalFont(){ Script = "Viet", Typeface = "Verdana" };
            A.SupplementalFont supplementalFont58 = new A.SupplementalFont(){ Script = "Uigh", Typeface = "Microsoft Uighur" };

            minorFont1.Append(latinFont20);
            minorFont1.Append(eastAsianFont20);
            minorFont1.Append(complexScriptFont20);
            minorFont1.Append(supplementalFont30);
            minorFont1.Append(supplementalFont31);
            minorFont1.Append(supplementalFont32);
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

            fontScheme1.Append(majorFont1);
            fontScheme1.Append(minorFont1);

            A.FormatScheme formatScheme1 = new A.FormatScheme(){ Name = "Office" };

            A.FillStyleList fillStyleList1 = new A.FillStyleList();

            A.SolidFill solidFill20 = new A.SolidFill();
            A.SchemeColor schemeColor20 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill20.Append(schemeColor20);

            A.GradientFill gradientFill1 = new A.GradientFill(){ RotateWithShape = true };

            A.GradientStopList gradientStopList1 = new A.GradientStopList();

            A.GradientStop gradientStop1 = new A.GradientStop(){ Position = 0 };

            A.SchemeColor schemeColor21 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint1 = new A.Tint(){ Val = 50000 };
            A.SaturationModulation saturationModulation1 = new A.SaturationModulation(){ Val = 300000 };

            schemeColor21.Append(tint1);
            schemeColor21.Append(saturationModulation1);

            gradientStop1.Append(schemeColor21);

            A.GradientStop gradientStop2 = new A.GradientStop(){ Position = 35000 };

            A.SchemeColor schemeColor22 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint2 = new A.Tint(){ Val = 37000 };
            A.SaturationModulation saturationModulation2 = new A.SaturationModulation(){ Val = 300000 };

            schemeColor22.Append(tint2);
            schemeColor22.Append(saturationModulation2);

            gradientStop2.Append(schemeColor22);

            A.GradientStop gradientStop3 = new A.GradientStop(){ Position = 100000 };

            A.SchemeColor schemeColor23 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint3 = new A.Tint(){ Val = 15000 };
            A.SaturationModulation saturationModulation3 = new A.SaturationModulation(){ Val = 350000 };

            schemeColor23.Append(tint3);
            schemeColor23.Append(saturationModulation3);

            gradientStop3.Append(schemeColor23);

            gradientStopList1.Append(gradientStop1);
            gradientStopList1.Append(gradientStop2);
            gradientStopList1.Append(gradientStop3);
            A.LinearGradientFill linearGradientFill1 = new A.LinearGradientFill(){ Angle = 16200000, Scaled = true };

            gradientFill1.Append(gradientStopList1);
            gradientFill1.Append(linearGradientFill1);

            A.GradientFill gradientFill2 = new A.GradientFill(){ RotateWithShape = true };

            A.GradientStopList gradientStopList2 = new A.GradientStopList();

            A.GradientStop gradientStop4 = new A.GradientStop(){ Position = 0 };

            A.SchemeColor schemeColor24 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Shade shade1 = new A.Shade(){ Val = 51000 };
            A.SaturationModulation saturationModulation4 = new A.SaturationModulation(){ Val = 130000 };

            schemeColor24.Append(shade1);
            schemeColor24.Append(saturationModulation4);

            gradientStop4.Append(schemeColor24);

            A.GradientStop gradientStop5 = new A.GradientStop(){ Position = 80000 };

            A.SchemeColor schemeColor25 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Shade shade2 = new A.Shade(){ Val = 93000 };
            A.SaturationModulation saturationModulation5 = new A.SaturationModulation(){ Val = 130000 };

            schemeColor25.Append(shade2);
            schemeColor25.Append(saturationModulation5);

            gradientStop5.Append(schemeColor25);

            A.GradientStop gradientStop6 = new A.GradientStop(){ Position = 100000 };

            A.SchemeColor schemeColor26 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Shade shade3 = new A.Shade(){ Val = 94000 };
            A.SaturationModulation saturationModulation6 = new A.SaturationModulation(){ Val = 135000 };

            schemeColor26.Append(shade3);
            schemeColor26.Append(saturationModulation6);

            gradientStop6.Append(schemeColor26);

            gradientStopList2.Append(gradientStop4);
            gradientStopList2.Append(gradientStop5);
            gradientStopList2.Append(gradientStop6);
            A.LinearGradientFill linearGradientFill2 = new A.LinearGradientFill(){ Angle = 16200000, Scaled = false };

            gradientFill2.Append(gradientStopList2);
            gradientFill2.Append(linearGradientFill2);

            fillStyleList1.Append(solidFill20);
            fillStyleList1.Append(gradientFill1);
            fillStyleList1.Append(gradientFill2);

            A.LineStyleList lineStyleList1 = new A.LineStyleList();

            A.Outline outline2 = new A.Outline(){ Width = 9525, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill21 = new A.SolidFill();

            A.SchemeColor schemeColor27 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Shade shade4 = new A.Shade(){ Val = 95000 };
            A.SaturationModulation saturationModulation7 = new A.SaturationModulation(){ Val = 105000 };

            schemeColor27.Append(shade4);
            schemeColor27.Append(saturationModulation7);

            solidFill21.Append(schemeColor27);
            A.PresetDash presetDash1 = new A.PresetDash(){ Val = A.PresetLineDashValues.Solid };

            outline2.Append(solidFill21);
            outline2.Append(presetDash1);

            A.Outline outline3 = new A.Outline(){ Width = 25400, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill22 = new A.SolidFill();
            A.SchemeColor schemeColor28 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill22.Append(schemeColor28);
            A.PresetDash presetDash2 = new A.PresetDash(){ Val = A.PresetLineDashValues.Solid };

            outline3.Append(solidFill22);
            outline3.Append(presetDash2);

            A.Outline outline4 = new A.Outline(){ Width = 38100, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill23 = new A.SolidFill();
            A.SchemeColor schemeColor29 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill23.Append(schemeColor29);
            A.PresetDash presetDash3 = new A.PresetDash(){ Val = A.PresetLineDashValues.Solid };

            outline4.Append(solidFill23);
            outline4.Append(presetDash3);

            lineStyleList1.Append(outline2);
            lineStyleList1.Append(outline3);
            lineStyleList1.Append(outline4);

            A.EffectStyleList effectStyleList1 = new A.EffectStyleList();

            A.EffectStyle effectStyle1 = new A.EffectStyle();

            A.EffectList effectList1 = new A.EffectList();

            A.OuterShadow outerShadow1 = new A.OuterShadow(){ BlurRadius = 40000L, Distance = 20000L, Direction = 5400000, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex15 = new A.RgbColorModelHex(){ Val = "000000" };
            A.Alpha alpha1 = new A.Alpha(){ Val = 38000 };

            rgbColorModelHex15.Append(alpha1);

            outerShadow1.Append(rgbColorModelHex15);

            effectList1.Append(outerShadow1);

            effectStyle1.Append(effectList1);

            A.EffectStyle effectStyle2 = new A.EffectStyle();

            A.EffectList effectList2 = new A.EffectList();

            A.OuterShadow outerShadow2 = new A.OuterShadow(){ BlurRadius = 40000L, Distance = 23000L, Direction = 5400000, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex16 = new A.RgbColorModelHex(){ Val = "000000" };
            A.Alpha alpha2 = new A.Alpha(){ Val = 35000 };

            rgbColorModelHex16.Append(alpha2);

            outerShadow2.Append(rgbColorModelHex16);

            effectList2.Append(outerShadow2);

            effectStyle2.Append(effectList2);

            A.EffectStyle effectStyle3 = new A.EffectStyle();

            A.EffectList effectList3 = new A.EffectList();

            A.OuterShadow outerShadow3 = new A.OuterShadow(){ BlurRadius = 40000L, Distance = 23000L, Direction = 5400000, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex17 = new A.RgbColorModelHex(){ Val = "000000" };
            A.Alpha alpha3 = new A.Alpha(){ Val = 35000 };

            rgbColorModelHex17.Append(alpha3);

            outerShadow3.Append(rgbColorModelHex17);

            effectList3.Append(outerShadow3);

            A.Scene3DType scene3DType1 = new A.Scene3DType();

            A.Camera camera1 = new A.Camera(){ Preset = A.PresetCameraValues.OrthographicFront };
            A.Rotation rotation1 = new A.Rotation(){ Latitude = 0, Longitude = 0, Revolution = 0 };

            camera1.Append(rotation1);

            A.LightRig lightRig1 = new A.LightRig(){ Rig = A.LightRigValues.ThreePoints, Direction = A.LightRigDirectionValues.Top };
            A.Rotation rotation2 = new A.Rotation(){ Latitude = 0, Longitude = 0, Revolution = 1200000 };

            lightRig1.Append(rotation2);

            scene3DType1.Append(camera1);
            scene3DType1.Append(lightRig1);

            A.Shape3DType shape3DType1 = new A.Shape3DType();
            A.BevelTop bevelTop1 = new A.BevelTop(){ Width = 63500L, Height = 25400L };

            shape3DType1.Append(bevelTop1);

            effectStyle3.Append(effectList3);
            effectStyle3.Append(scene3DType1);
            effectStyle3.Append(shape3DType1);

            effectStyleList1.Append(effectStyle1);
            effectStyleList1.Append(effectStyle2);
            effectStyleList1.Append(effectStyle3);

            A.BackgroundFillStyleList backgroundFillStyleList1 = new A.BackgroundFillStyleList();

            A.SolidFill solidFill24 = new A.SolidFill();
            A.SchemeColor schemeColor30 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill24.Append(schemeColor30);

            A.GradientFill gradientFill3 = new A.GradientFill(){ RotateWithShape = true };

            A.GradientStopList gradientStopList3 = new A.GradientStopList();

            A.GradientStop gradientStop7 = new A.GradientStop(){ Position = 0 };

            A.SchemeColor schemeColor31 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint4 = new A.Tint(){ Val = 40000 };
            A.SaturationModulation saturationModulation8 = new A.SaturationModulation(){ Val = 350000 };

            schemeColor31.Append(tint4);
            schemeColor31.Append(saturationModulation8);

            gradientStop7.Append(schemeColor31);

            A.GradientStop gradientStop8 = new A.GradientStop(){ Position = 40000 };

            A.SchemeColor schemeColor32 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint5 = new A.Tint(){ Val = 45000 };
            A.Shade shade5 = new A.Shade(){ Val = 99000 };
            A.SaturationModulation saturationModulation9 = new A.SaturationModulation(){ Val = 350000 };

            schemeColor32.Append(tint5);
            schemeColor32.Append(shade5);
            schemeColor32.Append(saturationModulation9);

            gradientStop8.Append(schemeColor32);

            A.GradientStop gradientStop9 = new A.GradientStop(){ Position = 100000 };

            A.SchemeColor schemeColor33 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Shade shade6 = new A.Shade(){ Val = 20000 };
            A.SaturationModulation saturationModulation10 = new A.SaturationModulation(){ Val = 255000 };

            schemeColor33.Append(shade6);
            schemeColor33.Append(saturationModulation10);

            gradientStop9.Append(schemeColor33);

            gradientStopList3.Append(gradientStop7);
            gradientStopList3.Append(gradientStop8);
            gradientStopList3.Append(gradientStop9);

            A.PathGradientFill pathGradientFill1 = new A.PathGradientFill(){ Path = A.PathShadeValues.Circle };
            A.FillToRectangle fillToRectangle1 = new A.FillToRectangle(){ Left = 50000, Top = -80000, Right = 50000, Bottom = 180000 };

            pathGradientFill1.Append(fillToRectangle1);

            gradientFill3.Append(gradientStopList3);
            gradientFill3.Append(pathGradientFill1);

            A.GradientFill gradientFill4 = new A.GradientFill(){ RotateWithShape = true };

            A.GradientStopList gradientStopList4 = new A.GradientStopList();

            A.GradientStop gradientStop10 = new A.GradientStop(){ Position = 0 };

            A.SchemeColor schemeColor34 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint6 = new A.Tint(){ Val = 80000 };
            A.SaturationModulation saturationModulation11 = new A.SaturationModulation(){ Val = 300000 };

            schemeColor34.Append(tint6);
            schemeColor34.Append(saturationModulation11);

            gradientStop10.Append(schemeColor34);

            A.GradientStop gradientStop11 = new A.GradientStop(){ Position = 100000 };

            A.SchemeColor schemeColor35 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Shade shade7 = new A.Shade(){ Val = 30000 };
            A.SaturationModulation saturationModulation12 = new A.SaturationModulation(){ Val = 200000 };

            schemeColor35.Append(shade7);
            schemeColor35.Append(saturationModulation12);

            gradientStop11.Append(schemeColor35);

            gradientStopList4.Append(gradientStop10);
            gradientStopList4.Append(gradientStop11);

            A.PathGradientFill pathGradientFill2 = new A.PathGradientFill(){ Path = A.PathShadeValues.Circle };
            A.FillToRectangle fillToRectangle2 = new A.FillToRectangle(){ Left = 50000, Top = 50000, Right = 50000, Bottom = 50000 };

            pathGradientFill2.Append(fillToRectangle2);

            gradientFill4.Append(gradientStopList4);
            gradientFill4.Append(pathGradientFill2);

            backgroundFillStyleList1.Append(solidFill24);
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

            theme1.Append(themeElements1);
            theme1.Append(objectDefaults1);
            theme1.Append(extraColorSchemeList1);

            themePart1.Theme = theme1;
        }

        // Generates content of tableStylesPart1.
        private void GenerateTableStylesPart1Content(TableStylesPart tableStylesPart1)
        {
            A.TableStyleList tableStyleList1 = new A.TableStyleList(){ Default = "{5C22544A-7EE6-4342-B048-85BDC9FD1C3A}" };
            tableStyleList1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            tableStylesPart1.TableStyleList = tableStyleList1;
        }

        // Generates content of slidePart1.
        private void GenerateSlidePart1Content(SlidePart slidePart1)
        {
            Slide slide1 = new Slide();
            slide1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slide1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slide1.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData2 = new CommonSlideData();

            ShapeTree shapeTree2 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties2 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties7 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties2 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties7 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties2.Append(nonVisualDrawingProperties7);
            nonVisualGroupShapeProperties2.Append(nonVisualGroupShapeDrawingProperties2);
            nonVisualGroupShapeProperties2.Append(applicationNonVisualDrawingProperties7);

            GroupShapeProperties groupShapeProperties2 = new GroupShapeProperties();

            A.TransformGroup transformGroup2 = new A.TransformGroup();
            A.Offset offset7 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents7 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset2 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents2 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup2.Append(offset7);
            transformGroup2.Append(extents7);
            transformGroup2.Append(childOffset2);
            transformGroup2.Append(childExtents2);

            groupShapeProperties2.Append(transformGroup2);

            Shape shape6 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties6 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties8 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "TextBox 3" };
            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties6 = new NonVisualShapeDrawingProperties(){ TextBox = true };
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties8 = new ApplicationNonVisualDrawingProperties();

            nonVisualShapeProperties6.Append(nonVisualDrawingProperties8);
            nonVisualShapeProperties6.Append(nonVisualShapeDrawingProperties6);
            nonVisualShapeProperties6.Append(applicationNonVisualDrawingProperties8);

            ShapeProperties shapeProperties6 = new ShapeProperties();

            A.Transform2D transform2D6 = new A.Transform2D();
            A.Offset offset8 = new A.Offset(){ X = 1905000L, Y = 1295400L };
            A.Extents extents8 = new A.Extents(){ Cx = 6172200L, Cy = 2862322L };

            transform2D6.Append(offset8);
            transform2D6.Append(extents8);

            A.PresetGeometry presetGeometry6 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList6 = new A.AdjustValueList();

            presetGeometry6.Append(adjustValueList6);
            A.NoFill noFill2 = new A.NoFill();

            shapeProperties6.Append(transform2D6);
            shapeProperties6.Append(presetGeometry6);
            shapeProperties6.Append(noFill2);

            TextBody textBody6 = new TextBody();

            A.BodyProperties bodyProperties6 = new A.BodyProperties(){ Wrap = A.TextWrappingValues.Square, RightToLeftColumns = false };
            A.ShapeAutoFit shapeAutoFit1 = new A.ShapeAutoFit();

            bodyProperties6.Append(shapeAutoFit1);
            A.ListStyle listStyle6 = new A.ListStyle();

            A.Paragraph paragraph10 = new A.Paragraph();

            A.Run run9 = new A.Run();

            A.RunProperties runProperties10 = new A.RunProperties(){ Language = "en-US", Dirty = false };
            runProperties10.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text10 = new A.Text();
            text10.Text = "Changes made to the Notes Master:";

            run9.Append(runProperties10);
            run9.Append(text10);

            paragraph10.Append(run9);

            A.Paragraph paragraph11 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties6 = new A.EndParagraphRunProperties(){ Language = "en-US", Dirty = false };

            paragraph11.Append(endParagraphRunProperties6);

            A.Paragraph paragraph12 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties6 = new A.ParagraphProperties(){ LeftMargin = 342900, Indent = -342900 };
            A.AutoNumberedBullet autoNumberedBullet1 = new A.AutoNumberedBullet(){ Type = A.TextAutoNumberSchemeValues.ArabicParenR };

            paragraphProperties6.Append(autoNumberedBullet1);

            A.Run run10 = new A.Run();

            A.RunProperties runProperties11 = new A.RunProperties(){ Language = "en-US", Dirty = false };
            runProperties11.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text11 = new A.Text();
            text11.Text = "Added text to Header";

            run10.Append(runProperties11);
            run10.Append(text11);

            paragraph12.Append(paragraphProperties6);
            paragraph12.Append(run10);

            A.Paragraph paragraph13 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties7 = new A.ParagraphProperties(){ LeftMargin = 342900, Indent = -342900 };
            A.AutoNumberedBullet autoNumberedBullet2 = new A.AutoNumberedBullet(){ Type = A.TextAutoNumberSchemeValues.ArabicParenR };

            paragraphProperties7.Append(autoNumberedBullet2);

            A.Run run11 = new A.Run();

            A.RunProperties runProperties12 = new A.RunProperties(){ Language = "en-US", Dirty = false };
            runProperties12.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text12 = new A.Text();
            text12.Text = "Added text to Footer";

            run11.Append(runProperties12);
            run11.Append(text12);

            paragraph13.Append(paragraphProperties7);
            paragraph13.Append(run11);

            A.Paragraph paragraph14 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties8 = new A.ParagraphProperties(){ LeftMargin = 342900, Indent = -342900 };
            A.AutoNumberedBullet autoNumberedBullet3 = new A.AutoNumberedBullet(){ Type = A.TextAutoNumberSchemeValues.ArabicParenR };

            paragraphProperties8.Append(autoNumberedBullet3);

            A.Run run12 = new A.Run();

            A.RunProperties runProperties13 = new A.RunProperties(){ Language = "en-US", Dirty = false };
            runProperties13.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text13 = new A.Text();
            text13.Text = "Changed Font scheme to Verve";

            run12.Append(runProperties13);
            run12.Append(text13);

            paragraph14.Append(paragraphProperties8);
            paragraph14.Append(run12);

            A.Paragraph paragraph15 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties9 = new A.ParagraphProperties(){ LeftMargin = 342900, Indent = -342900 };
            A.AutoNumberedBullet autoNumberedBullet4 = new A.AutoNumberedBullet(){ Type = A.TextAutoNumberSchemeValues.ArabicParenR };

            paragraphProperties9.Append(autoNumberedBullet4);

            A.Run run13 = new A.Run();

            A.RunProperties runProperties14 = new A.RunProperties(){ Language = "en-US", Dirty = false };
            runProperties14.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text14 = new A.Text();
            text14.Text = "Added Background Style";

            run13.Append(runProperties14);
            run13.Append(text14);

            paragraph15.Append(paragraphProperties9);
            paragraph15.Append(run13);

            A.Paragraph paragraph16 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties10 = new A.ParagraphProperties(){ LeftMargin = 342900, Indent = -342900 };
            A.AutoNumberedBullet autoNumberedBullet5 = new A.AutoNumberedBullet(){ Type = A.TextAutoNumberSchemeValues.ArabicParenR };

            paragraphProperties10.Append(autoNumberedBullet5);

            A.Run run14 = new A.Run();

            A.RunProperties runProperties15 = new A.RunProperties(){ Language = "en-US", Dirty = false };
            runProperties15.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text15 = new A.Text();
            text15.Text = "Changed Notes page orientation to Landscape";

            run14.Append(runProperties15);
            run14.Append(text15);

            paragraph16.Append(paragraphProperties10);
            paragraph16.Append(run14);

            A.Paragraph paragraph17 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties11 = new A.ParagraphProperties(){ LeftMargin = 342900, Indent = -342900 };
            A.AutoNumberedBullet autoNumberedBullet6 = new A.AutoNumberedBullet(){ Type = A.TextAutoNumberSchemeValues.ArabicParenR };

            paragraphProperties11.Append(autoNumberedBullet6);

            A.Run run15 = new A.Run();

            A.RunProperties runProperties16 = new A.RunProperties(){ Language = "en-US", Dirty = false };
            runProperties16.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text16 = new A.Text();
            text16.Text = "Changed Color scheme to Oriel";

            run15.Append(runProperties16);
            run15.Append(text16);

            paragraph17.Append(paragraphProperties11);
            paragraph17.Append(run15);

            A.Paragraph paragraph18 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties12 = new A.ParagraphProperties(){ LeftMargin = 342900, Indent = -342900 };
            A.AutoNumberedBullet autoNumberedBullet7 = new A.AutoNumberedBullet(){ Type = A.TextAutoNumberSchemeValues.ArabicParenR };

            paragraphProperties12.Append(autoNumberedBullet7);

            A.Run run16 = new A.Run();

            A.RunProperties runProperties17 = new A.RunProperties(){ Language = "en-US", Dirty = false };
            runProperties17.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text17 = new A.Text();
            text17.Text = "Removed Page Number";

            run16.Append(runProperties17);
            run16.Append(text17);

            paragraph18.Append(paragraphProperties12);
            paragraph18.Append(run16);

            A.Paragraph paragraph19 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties13 = new A.ParagraphProperties(){ LeftMargin = 342900, Indent = -342900 };
            A.AutoNumberedBullet autoNumberedBullet8 = new A.AutoNumberedBullet(){ Type = A.TextAutoNumberSchemeValues.ArabicParenR };

            paragraphProperties13.Append(autoNumberedBullet8);
            A.EndParagraphRunProperties endParagraphRunProperties7 = new A.EndParagraphRunProperties(){ Language = "en-US", Dirty = false };

            paragraph19.Append(paragraphProperties13);
            paragraph19.Append(endParagraphRunProperties7);

            textBody6.Append(bodyProperties6);
            textBody6.Append(listStyle6);
            textBody6.Append(paragraph10);
            textBody6.Append(paragraph11);
            textBody6.Append(paragraph12);
            textBody6.Append(paragraph13);
            textBody6.Append(paragraph14);
            textBody6.Append(paragraph15);
            textBody6.Append(paragraph16);
            textBody6.Append(paragraph17);
            textBody6.Append(paragraph18);
            textBody6.Append(paragraph19);

            shape6.Append(nonVisualShapeProperties6);
            shape6.Append(shapeProperties6);
            shape6.Append(textBody6);

            shapeTree2.Append(nonVisualGroupShapeProperties2);
            shapeTree2.Append(groupShapeProperties2);
            shapeTree2.Append(shape6);

            commonSlideData2.Append(shapeTree2);

            ColorMapOverride colorMapOverride1 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping1 = new A.MasterColorMapping();

            colorMapOverride1.Append(masterColorMapping1);

            slide1.Append(commonSlideData2);
            slide1.Append(colorMapOverride1);

            slidePart1.Slide = slide1;
        }

        // Generates content of slideLayoutPart1.
        private void GenerateSlideLayoutPart1Content(SlideLayoutPart slideLayoutPart1)
        {
            SlideLayout slideLayout1 = new SlideLayout(){ Type = SlideLayoutValues.Title, Preserve = true };
            slideLayout1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout1.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData3 = new CommonSlideData(){ Name = "Title Slide" };

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
            A.Offset offset9 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents9 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset3 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents3 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup3.Append(offset9);
            transformGroup3.Append(extents9);
            transformGroup3.Append(childOffset3);
            transformGroup3.Append(childExtents3);

            groupShapeProperties3.Append(transformGroup3);

            Shape shape7 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties7 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties10 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties7 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks6 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties7.Append(shapeLocks6);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties10 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape6 = new PlaceholderShape(){ Type = PlaceholderValues.CenteredTitle };

            applicationNonVisualDrawingProperties10.Append(placeholderShape6);

            nonVisualShapeProperties7.Append(nonVisualDrawingProperties10);
            nonVisualShapeProperties7.Append(nonVisualShapeDrawingProperties7);
            nonVisualShapeProperties7.Append(applicationNonVisualDrawingProperties10);

            ShapeProperties shapeProperties7 = new ShapeProperties();

            A.Transform2D transform2D7 = new A.Transform2D();
            A.Offset offset10 = new A.Offset(){ X = 685800L, Y = 2130426L };
            A.Extents extents10 = new A.Extents(){ Cx = 7772400L, Cy = 1470025L };

            transform2D7.Append(offset10);
            transform2D7.Append(extents10);

            shapeProperties7.Append(transform2D7);

            TextBody textBody7 = new TextBody();
            A.BodyProperties bodyProperties7 = new A.BodyProperties();
            A.ListStyle listStyle7 = new A.ListStyle();

            A.Paragraph paragraph20 = new A.Paragraph();

            A.Run run17 = new A.Run();

            A.RunProperties runProperties18 = new A.RunProperties(){ Language = "en-US" };
            runProperties18.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text18 = new A.Text();
            text18.Text = "Click to edit Master title style";

            run17.Append(runProperties18);
            run17.Append(text18);
            A.EndParagraphRunProperties endParagraphRunProperties8 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph20.Append(run17);
            paragraph20.Append(endParagraphRunProperties8);

            textBody7.Append(bodyProperties7);
            textBody7.Append(listStyle7);
            textBody7.Append(paragraph20);

            shape7.Append(nonVisualShapeProperties7);
            shape7.Append(shapeProperties7);
            shape7.Append(textBody7);

            Shape shape8 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties8 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties11 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Subtitle 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties8 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks7 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties8.Append(shapeLocks7);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties11 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape7 = new PlaceholderShape(){ Type = PlaceholderValues.SubTitle, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties11.Append(placeholderShape7);

            nonVisualShapeProperties8.Append(nonVisualDrawingProperties11);
            nonVisualShapeProperties8.Append(nonVisualShapeDrawingProperties8);
            nonVisualShapeProperties8.Append(applicationNonVisualDrawingProperties11);

            ShapeProperties shapeProperties8 = new ShapeProperties();

            A.Transform2D transform2D8 = new A.Transform2D();
            A.Offset offset11 = new A.Offset(){ X = 1371600L, Y = 3886200L };
            A.Extents extents11 = new A.Extents(){ Cx = 6400800L, Cy = 1752600L };

            transform2D8.Append(offset11);
            transform2D8.Append(extents11);

            shapeProperties8.Append(transform2D8);

            TextBody textBody8 = new TextBody();
            A.BodyProperties bodyProperties8 = new A.BodyProperties();

            A.ListStyle listStyle8 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties6 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet1 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties23 = new A.DefaultRunProperties();

            A.SolidFill solidFill25 = new A.SolidFill();

            A.SchemeColor schemeColor36 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint7 = new A.Tint(){ Val = 75000 };

            schemeColor36.Append(tint7);

            solidFill25.Append(schemeColor36);

            defaultRunProperties23.Append(solidFill25);

            level1ParagraphProperties6.Append(noBullet1);
            level1ParagraphProperties6.Append(defaultRunProperties23);

            A.Level2ParagraphProperties level2ParagraphProperties3 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet2 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties24 = new A.DefaultRunProperties();

            A.SolidFill solidFill26 = new A.SolidFill();

            A.SchemeColor schemeColor37 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint8 = new A.Tint(){ Val = 75000 };

            schemeColor37.Append(tint8);

            solidFill26.Append(schemeColor37);

            defaultRunProperties24.Append(solidFill26);

            level2ParagraphProperties3.Append(noBullet2);
            level2ParagraphProperties3.Append(defaultRunProperties24);

            A.Level3ParagraphProperties level3ParagraphProperties3 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet3 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties25 = new A.DefaultRunProperties();

            A.SolidFill solidFill27 = new A.SolidFill();

            A.SchemeColor schemeColor38 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint9 = new A.Tint(){ Val = 75000 };

            schemeColor38.Append(tint9);

            solidFill27.Append(schemeColor38);

            defaultRunProperties25.Append(solidFill27);

            level3ParagraphProperties3.Append(noBullet3);
            level3ParagraphProperties3.Append(defaultRunProperties25);

            A.Level4ParagraphProperties level4ParagraphProperties3 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet4 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties26 = new A.DefaultRunProperties();

            A.SolidFill solidFill28 = new A.SolidFill();

            A.SchemeColor schemeColor39 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint10 = new A.Tint(){ Val = 75000 };

            schemeColor39.Append(tint10);

            solidFill28.Append(schemeColor39);

            defaultRunProperties26.Append(solidFill28);

            level4ParagraphProperties3.Append(noBullet4);
            level4ParagraphProperties3.Append(defaultRunProperties26);

            A.Level5ParagraphProperties level5ParagraphProperties3 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet5 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties27 = new A.DefaultRunProperties();

            A.SolidFill solidFill29 = new A.SolidFill();

            A.SchemeColor schemeColor40 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint11 = new A.Tint(){ Val = 75000 };

            schemeColor40.Append(tint11);

            solidFill29.Append(schemeColor40);

            defaultRunProperties27.Append(solidFill29);

            level5ParagraphProperties3.Append(noBullet5);
            level5ParagraphProperties3.Append(defaultRunProperties27);

            A.Level6ParagraphProperties level6ParagraphProperties3 = new A.Level6ParagraphProperties(){ LeftMargin = 2286000, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet6 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties28 = new A.DefaultRunProperties();

            A.SolidFill solidFill30 = new A.SolidFill();

            A.SchemeColor schemeColor41 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint12 = new A.Tint(){ Val = 75000 };

            schemeColor41.Append(tint12);

            solidFill30.Append(schemeColor41);

            defaultRunProperties28.Append(solidFill30);

            level6ParagraphProperties3.Append(noBullet6);
            level6ParagraphProperties3.Append(defaultRunProperties28);

            A.Level7ParagraphProperties level7ParagraphProperties3 = new A.Level7ParagraphProperties(){ LeftMargin = 2743200, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet7 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties29 = new A.DefaultRunProperties();

            A.SolidFill solidFill31 = new A.SolidFill();

            A.SchemeColor schemeColor42 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint13 = new A.Tint(){ Val = 75000 };

            schemeColor42.Append(tint13);

            solidFill31.Append(schemeColor42);

            defaultRunProperties29.Append(solidFill31);

            level7ParagraphProperties3.Append(noBullet7);
            level7ParagraphProperties3.Append(defaultRunProperties29);

            A.Level8ParagraphProperties level8ParagraphProperties3 = new A.Level8ParagraphProperties(){ LeftMargin = 3200400, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet8 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties30 = new A.DefaultRunProperties();

            A.SolidFill solidFill32 = new A.SolidFill();

            A.SchemeColor schemeColor43 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint14 = new A.Tint(){ Val = 75000 };

            schemeColor43.Append(tint14);

            solidFill32.Append(schemeColor43);

            defaultRunProperties30.Append(solidFill32);

            level8ParagraphProperties3.Append(noBullet8);
            level8ParagraphProperties3.Append(defaultRunProperties30);

            A.Level9ParagraphProperties level9ParagraphProperties3 = new A.Level9ParagraphProperties(){ LeftMargin = 3657600, Indent = 0, Alignment = A.TextAlignmentTypeValues.Center };
            A.NoBullet noBullet9 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties31 = new A.DefaultRunProperties();

            A.SolidFill solidFill33 = new A.SolidFill();

            A.SchemeColor schemeColor44 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint15 = new A.Tint(){ Val = 75000 };

            schemeColor44.Append(tint15);

            solidFill33.Append(schemeColor44);

            defaultRunProperties31.Append(solidFill33);

            level9ParagraphProperties3.Append(noBullet9);
            level9ParagraphProperties3.Append(defaultRunProperties31);

            listStyle8.Append(level1ParagraphProperties6);
            listStyle8.Append(level2ParagraphProperties3);
            listStyle8.Append(level3ParagraphProperties3);
            listStyle8.Append(level4ParagraphProperties3);
            listStyle8.Append(level5ParagraphProperties3);
            listStyle8.Append(level6ParagraphProperties3);
            listStyle8.Append(level7ParagraphProperties3);
            listStyle8.Append(level8ParagraphProperties3);
            listStyle8.Append(level9ParagraphProperties3);

            A.Paragraph paragraph21 = new A.Paragraph();

            A.Run run18 = new A.Run();

            A.RunProperties runProperties19 = new A.RunProperties(){ Language = "en-US" };
            runProperties19.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text19 = new A.Text();
            text19.Text = "Click to edit Master subtitle style";

            run18.Append(runProperties19);
            run18.Append(text19);
            A.EndParagraphRunProperties endParagraphRunProperties9 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph21.Append(run18);
            paragraph21.Append(endParagraphRunProperties9);

            textBody8.Append(bodyProperties8);
            textBody8.Append(listStyle8);
            textBody8.Append(paragraph21);

            shape8.Append(nonVisualShapeProperties8);
            shape8.Append(shapeProperties8);
            shape8.Append(textBody8);

            Shape shape9 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties9 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties12 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Date Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties9 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks8 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties9.Append(shapeLocks8);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties12 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape8 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties12.Append(placeholderShape8);

            nonVisualShapeProperties9.Append(nonVisualDrawingProperties12);
            nonVisualShapeProperties9.Append(nonVisualShapeDrawingProperties9);
            nonVisualShapeProperties9.Append(applicationNonVisualDrawingProperties12);
            ShapeProperties shapeProperties9 = new ShapeProperties();

            TextBody textBody9 = new TextBody();
            A.BodyProperties bodyProperties9 = new A.BodyProperties();
            A.ListStyle listStyle9 = new A.ListStyle();

            A.Paragraph paragraph22 = new A.Paragraph();

            A.Field field2 = new A.Field(){ Id = "{1A15D4F1-1D33-4170-8C9F-182CDE6BA6D1}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties20 = new A.RunProperties(){ Language = "en-US" };
            runProperties20.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text20 = new A.Text();
            text20.Text = "10/3/2012";

            field2.Append(runProperties20);
            field2.Append(text20);
            A.EndParagraphRunProperties endParagraphRunProperties10 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph22.Append(field2);
            paragraph22.Append(endParagraphRunProperties10);

            textBody9.Append(bodyProperties9);
            textBody9.Append(listStyle9);
            textBody9.Append(paragraph22);

            shape9.Append(nonVisualShapeProperties9);
            shape9.Append(shapeProperties9);
            shape9.Append(textBody9);

            Shape shape10 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties10 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties13 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Footer Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties10 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks9 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties10.Append(shapeLocks9);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties13 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape9 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties13.Append(placeholderShape9);

            nonVisualShapeProperties10.Append(nonVisualDrawingProperties13);
            nonVisualShapeProperties10.Append(nonVisualShapeDrawingProperties10);
            nonVisualShapeProperties10.Append(applicationNonVisualDrawingProperties13);
            ShapeProperties shapeProperties10 = new ShapeProperties();

            TextBody textBody10 = new TextBody();
            A.BodyProperties bodyProperties10 = new A.BodyProperties();
            A.ListStyle listStyle10 = new A.ListStyle();

            A.Paragraph paragraph23 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties11 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph23.Append(endParagraphRunProperties11);

            textBody10.Append(bodyProperties10);
            textBody10.Append(listStyle10);
            textBody10.Append(paragraph23);

            shape10.Append(nonVisualShapeProperties10);
            shape10.Append(shapeProperties10);
            shape10.Append(textBody10);

            Shape shape11 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties11 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties14 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Slide Number Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties11 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks10 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties11.Append(shapeLocks10);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties14 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape10 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties14.Append(placeholderShape10);

            nonVisualShapeProperties11.Append(nonVisualDrawingProperties14);
            nonVisualShapeProperties11.Append(nonVisualShapeDrawingProperties11);
            nonVisualShapeProperties11.Append(applicationNonVisualDrawingProperties14);
            ShapeProperties shapeProperties11 = new ShapeProperties();

            TextBody textBody11 = new TextBody();
            A.BodyProperties bodyProperties11 = new A.BodyProperties();
            A.ListStyle listStyle11 = new A.ListStyle();

            A.Paragraph paragraph24 = new A.Paragraph();

            A.Field field3 = new A.Field(){ Id = "{9E0C3BFA-D4DA-4895-A0F6-B80859694A8D}", Type = "slidenum" };

            A.RunProperties runProperties21 = new A.RunProperties(){ Language = "en-US" };
            runProperties21.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text21 = new A.Text();
            text21.Text = "‹#›";

            field3.Append(runProperties21);
            field3.Append(text21);
            A.EndParagraphRunProperties endParagraphRunProperties12 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph24.Append(field3);
            paragraph24.Append(endParagraphRunProperties12);

            textBody11.Append(bodyProperties11);
            textBody11.Append(listStyle11);
            textBody11.Append(paragraph24);

            shape11.Append(nonVisualShapeProperties11);
            shape11.Append(shapeProperties11);
            shape11.Append(textBody11);

            shapeTree3.Append(nonVisualGroupShapeProperties3);
            shapeTree3.Append(groupShapeProperties3);
            shapeTree3.Append(shape7);
            shapeTree3.Append(shape8);
            shapeTree3.Append(shape9);
            shapeTree3.Append(shape10);
            shapeTree3.Append(shape11);

            commonSlideData3.Append(shapeTree3);

            ColorMapOverride colorMapOverride2 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping2 = new A.MasterColorMapping();

            colorMapOverride2.Append(masterColorMapping2);

            slideLayout1.Append(commonSlideData3);
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

            CommonSlideData commonSlideData4 = new CommonSlideData();

            Background background2 = new Background();

            BackgroundStyleReference backgroundStyleReference2 = new BackgroundStyleReference(){ Index = (UInt32Value)1001U };
            A.SchemeColor schemeColor45 = new A.SchemeColor(){ Val = A.SchemeColorValues.Background1 };

            backgroundStyleReference2.Append(schemeColor45);

            background2.Append(backgroundStyleReference2);

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

            Shape shape12 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties12 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties16 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title Placeholder 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties12 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks11 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties12.Append(shapeLocks11);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties16 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape11 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties16.Append(placeholderShape11);

            nonVisualShapeProperties12.Append(nonVisualDrawingProperties16);
            nonVisualShapeProperties12.Append(nonVisualShapeDrawingProperties12);
            nonVisualShapeProperties12.Append(applicationNonVisualDrawingProperties16);

            ShapeProperties shapeProperties12 = new ShapeProperties();

            A.Transform2D transform2D9 = new A.Transform2D();
            A.Offset offset13 = new A.Offset(){ X = 457200L, Y = 274638L };
            A.Extents extents13 = new A.Extents(){ Cx = 8229600L, Cy = 1143000L };

            transform2D9.Append(offset13);
            transform2D9.Append(extents13);

            A.PresetGeometry presetGeometry7 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList7 = new A.AdjustValueList();

            presetGeometry7.Append(adjustValueList7);

            shapeProperties12.Append(transform2D9);
            shapeProperties12.Append(presetGeometry7);

            TextBody textBody12 = new TextBody();

            A.BodyProperties bodyProperties12 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal, LeftInset = 91440, TopInset = 45720, RightInset = 91440, BottomInset = 45720, RightToLeftColumns = false, Anchor = A.TextAnchoringTypeValues.Center };
            A.NormalAutoFit normalAutoFit2 = new A.NormalAutoFit();

            bodyProperties12.Append(normalAutoFit2);
            A.ListStyle listStyle12 = new A.ListStyle();

            A.Paragraph paragraph25 = new A.Paragraph();

            A.Run run19 = new A.Run();

            A.RunProperties runProperties22 = new A.RunProperties(){ Language = "en-US" };
            runProperties22.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text22 = new A.Text();
            text22.Text = "Click to edit Master title style";

            run19.Append(runProperties22);
            run19.Append(text22);
            A.EndParagraphRunProperties endParagraphRunProperties13 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph25.Append(run19);
            paragraph25.Append(endParagraphRunProperties13);

            textBody12.Append(bodyProperties12);
            textBody12.Append(listStyle12);
            textBody12.Append(paragraph25);

            shape12.Append(nonVisualShapeProperties12);
            shape12.Append(shapeProperties12);
            shape12.Append(textBody12);

            Shape shape13 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties13 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties17 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Text Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties13 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks12 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties13.Append(shapeLocks12);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties17 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape12 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties17.Append(placeholderShape12);

            nonVisualShapeProperties13.Append(nonVisualDrawingProperties17);
            nonVisualShapeProperties13.Append(nonVisualShapeDrawingProperties13);
            nonVisualShapeProperties13.Append(applicationNonVisualDrawingProperties17);

            ShapeProperties shapeProperties13 = new ShapeProperties();

            A.Transform2D transform2D10 = new A.Transform2D();
            A.Offset offset14 = new A.Offset(){ X = 457200L, Y = 1600201L };
            A.Extents extents14 = new A.Extents(){ Cx = 8229600L, Cy = 4525963L };

            transform2D10.Append(offset14);
            transform2D10.Append(extents14);

            A.PresetGeometry presetGeometry8 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList8 = new A.AdjustValueList();

            presetGeometry8.Append(adjustValueList8);

            shapeProperties13.Append(transform2D10);
            shapeProperties13.Append(presetGeometry8);

            TextBody textBody13 = new TextBody();

            A.BodyProperties bodyProperties13 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal, LeftInset = 91440, TopInset = 45720, RightInset = 91440, BottomInset = 45720, RightToLeftColumns = false };
            A.NormalAutoFit normalAutoFit3 = new A.NormalAutoFit();

            bodyProperties13.Append(normalAutoFit3);
            A.ListStyle listStyle13 = new A.ListStyle();

            A.Paragraph paragraph26 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties14 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run20 = new A.Run();

            A.RunProperties runProperties23 = new A.RunProperties(){ Language = "en-US" };
            runProperties23.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text23 = new A.Text();
            text23.Text = "Click to edit Master text styles";

            run20.Append(runProperties23);
            run20.Append(text23);

            paragraph26.Append(paragraphProperties14);
            paragraph26.Append(run20);

            A.Paragraph paragraph27 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties15 = new A.ParagraphProperties(){ Level = 1 };

            A.Run run21 = new A.Run();

            A.RunProperties runProperties24 = new A.RunProperties(){ Language = "en-US" };
            runProperties24.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text24 = new A.Text();
            text24.Text = "Second level";

            run21.Append(runProperties24);
            run21.Append(text24);

            paragraph27.Append(paragraphProperties15);
            paragraph27.Append(run21);

            A.Paragraph paragraph28 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties16 = new A.ParagraphProperties(){ Level = 2 };

            A.Run run22 = new A.Run();

            A.RunProperties runProperties25 = new A.RunProperties(){ Language = "en-US" };
            runProperties25.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text25 = new A.Text();
            text25.Text = "Third level";

            run22.Append(runProperties25);
            run22.Append(text25);

            paragraph28.Append(paragraphProperties16);
            paragraph28.Append(run22);

            A.Paragraph paragraph29 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties17 = new A.ParagraphProperties(){ Level = 3 };

            A.Run run23 = new A.Run();

            A.RunProperties runProperties26 = new A.RunProperties(){ Language = "en-US" };
            runProperties26.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text26 = new A.Text();
            text26.Text = "Fourth level";

            run23.Append(runProperties26);
            run23.Append(text26);

            paragraph29.Append(paragraphProperties17);
            paragraph29.Append(run23);

            A.Paragraph paragraph30 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties18 = new A.ParagraphProperties(){ Level = 4 };

            A.Run run24 = new A.Run();

            A.RunProperties runProperties27 = new A.RunProperties(){ Language = "en-US" };
            runProperties27.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text27 = new A.Text();
            text27.Text = "Fifth level";

            run24.Append(runProperties27);
            run24.Append(text27);
            A.EndParagraphRunProperties endParagraphRunProperties14 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph30.Append(paragraphProperties18);
            paragraph30.Append(run24);
            paragraph30.Append(endParagraphRunProperties14);

            textBody13.Append(bodyProperties13);
            textBody13.Append(listStyle13);
            textBody13.Append(paragraph26);
            textBody13.Append(paragraph27);
            textBody13.Append(paragraph28);
            textBody13.Append(paragraph29);
            textBody13.Append(paragraph30);

            shape13.Append(nonVisualShapeProperties13);
            shape13.Append(shapeProperties13);
            shape13.Append(textBody13);

            Shape shape14 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties14 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties18 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Date Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties14 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks13 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties14.Append(shapeLocks13);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties18 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape13 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)2U };

            applicationNonVisualDrawingProperties18.Append(placeholderShape13);

            nonVisualShapeProperties14.Append(nonVisualDrawingProperties18);
            nonVisualShapeProperties14.Append(nonVisualShapeDrawingProperties14);
            nonVisualShapeProperties14.Append(applicationNonVisualDrawingProperties18);

            ShapeProperties shapeProperties14 = new ShapeProperties();

            A.Transform2D transform2D11 = new A.Transform2D();
            A.Offset offset15 = new A.Offset(){ X = 457200L, Y = 6356351L };
            A.Extents extents15 = new A.Extents(){ Cx = 2133600L, Cy = 365125L };

            transform2D11.Append(offset15);
            transform2D11.Append(extents15);

            A.PresetGeometry presetGeometry9 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList9 = new A.AdjustValueList();

            presetGeometry9.Append(adjustValueList9);

            shapeProperties14.Append(transform2D11);
            shapeProperties14.Append(presetGeometry9);

            TextBody textBody14 = new TextBody();
            A.BodyProperties bodyProperties14 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal, LeftInset = 91440, TopInset = 45720, RightInset = 91440, BottomInset = 45720, RightToLeftColumns = false, Anchor = A.TextAnchoringTypeValues.Center };

            A.ListStyle listStyle14 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties7 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Left };

            A.DefaultRunProperties defaultRunProperties32 = new A.DefaultRunProperties(){ FontSize = 1200 };

            A.SolidFill solidFill34 = new A.SolidFill();

            A.SchemeColor schemeColor46 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint16 = new A.Tint(){ Val = 75000 };

            schemeColor46.Append(tint16);

            solidFill34.Append(schemeColor46);

            defaultRunProperties32.Append(solidFill34);

            level1ParagraphProperties7.Append(defaultRunProperties32);

            listStyle14.Append(level1ParagraphProperties7);

            A.Paragraph paragraph31 = new A.Paragraph();

            A.Field field4 = new A.Field(){ Id = "{1A15D4F1-1D33-4170-8C9F-182CDE6BA6D1}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties28 = new A.RunProperties(){ Language = "en-US" };
            runProperties28.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text28 = new A.Text();
            text28.Text = "10/3/2012";

            field4.Append(runProperties28);
            field4.Append(text28);
            A.EndParagraphRunProperties endParagraphRunProperties15 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph31.Append(field4);
            paragraph31.Append(endParagraphRunProperties15);

            textBody14.Append(bodyProperties14);
            textBody14.Append(listStyle14);
            textBody14.Append(paragraph31);

            shape14.Append(nonVisualShapeProperties14);
            shape14.Append(shapeProperties14);
            shape14.Append(textBody14);

            Shape shape15 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties15 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties19 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Footer Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties15 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks14 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties15.Append(shapeLocks14);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties19 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape14 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)3U };

            applicationNonVisualDrawingProperties19.Append(placeholderShape14);

            nonVisualShapeProperties15.Append(nonVisualDrawingProperties19);
            nonVisualShapeProperties15.Append(nonVisualShapeDrawingProperties15);
            nonVisualShapeProperties15.Append(applicationNonVisualDrawingProperties19);

            ShapeProperties shapeProperties15 = new ShapeProperties();

            A.Transform2D transform2D12 = new A.Transform2D();
            A.Offset offset16 = new A.Offset(){ X = 3124200L, Y = 6356351L };
            A.Extents extents16 = new A.Extents(){ Cx = 2895600L, Cy = 365125L };

            transform2D12.Append(offset16);
            transform2D12.Append(extents16);

            A.PresetGeometry presetGeometry10 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList10 = new A.AdjustValueList();

            presetGeometry10.Append(adjustValueList10);

            shapeProperties15.Append(transform2D12);
            shapeProperties15.Append(presetGeometry10);

            TextBody textBody15 = new TextBody();
            A.BodyProperties bodyProperties15 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal, LeftInset = 91440, TopInset = 45720, RightInset = 91440, BottomInset = 45720, RightToLeftColumns = false, Anchor = A.TextAnchoringTypeValues.Center };

            A.ListStyle listStyle15 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties8 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Center };

            A.DefaultRunProperties defaultRunProperties33 = new A.DefaultRunProperties(){ FontSize = 1200 };

            A.SolidFill solidFill35 = new A.SolidFill();

            A.SchemeColor schemeColor47 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint17 = new A.Tint(){ Val = 75000 };

            schemeColor47.Append(tint17);

            solidFill35.Append(schemeColor47);

            defaultRunProperties33.Append(solidFill35);

            level1ParagraphProperties8.Append(defaultRunProperties33);

            listStyle15.Append(level1ParagraphProperties8);

            A.Paragraph paragraph32 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties16 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph32.Append(endParagraphRunProperties16);

            textBody15.Append(bodyProperties15);
            textBody15.Append(listStyle15);
            textBody15.Append(paragraph32);

            shape15.Append(nonVisualShapeProperties15);
            shape15.Append(shapeProperties15);
            shape15.Append(textBody15);

            Shape shape16 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties16 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties20 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Slide Number Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties16 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks15 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties16.Append(shapeLocks15);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties20 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape15 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)4U };

            applicationNonVisualDrawingProperties20.Append(placeholderShape15);

            nonVisualShapeProperties16.Append(nonVisualDrawingProperties20);
            nonVisualShapeProperties16.Append(nonVisualShapeDrawingProperties16);
            nonVisualShapeProperties16.Append(applicationNonVisualDrawingProperties20);

            ShapeProperties shapeProperties16 = new ShapeProperties();

            A.Transform2D transform2D13 = new A.Transform2D();
            A.Offset offset17 = new A.Offset(){ X = 6553200L, Y = 6356351L };
            A.Extents extents17 = new A.Extents(){ Cx = 2133600L, Cy = 365125L };

            transform2D13.Append(offset17);
            transform2D13.Append(extents17);

            A.PresetGeometry presetGeometry11 = new A.PresetGeometry(){ Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList11 = new A.AdjustValueList();

            presetGeometry11.Append(adjustValueList11);

            shapeProperties16.Append(transform2D13);
            shapeProperties16.Append(presetGeometry11);

            TextBody textBody16 = new TextBody();
            A.BodyProperties bodyProperties16 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.Horizontal, LeftInset = 91440, TopInset = 45720, RightInset = 91440, BottomInset = 45720, RightToLeftColumns = false, Anchor = A.TextAnchoringTypeValues.Center };

            A.ListStyle listStyle16 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties9 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Right };

            A.DefaultRunProperties defaultRunProperties34 = new A.DefaultRunProperties(){ FontSize = 1200 };

            A.SolidFill solidFill36 = new A.SolidFill();

            A.SchemeColor schemeColor48 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint18 = new A.Tint(){ Val = 75000 };

            schemeColor48.Append(tint18);

            solidFill36.Append(schemeColor48);

            defaultRunProperties34.Append(solidFill36);

            level1ParagraphProperties9.Append(defaultRunProperties34);

            listStyle16.Append(level1ParagraphProperties9);

            A.Paragraph paragraph33 = new A.Paragraph();

            A.Field field5 = new A.Field(){ Id = "{9E0C3BFA-D4DA-4895-A0F6-B80859694A8D}", Type = "slidenum" };

            A.RunProperties runProperties29 = new A.RunProperties(){ Language = "en-US" };
            runProperties29.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text29 = new A.Text();
            text29.Text = "‹#›";

            field5.Append(runProperties29);
            field5.Append(text29);
            A.EndParagraphRunProperties endParagraphRunProperties17 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph33.Append(field5);
            paragraph33.Append(endParagraphRunProperties17);

            textBody16.Append(bodyProperties16);
            textBody16.Append(listStyle16);
            textBody16.Append(paragraph33);

            shape16.Append(nonVisualShapeProperties16);
            shape16.Append(shapeProperties16);
            shape16.Append(textBody16);

            shapeTree4.Append(nonVisualGroupShapeProperties4);
            shapeTree4.Append(groupShapeProperties4);
            shapeTree4.Append(shape12);
            shapeTree4.Append(shape13);
            shapeTree4.Append(shape14);
            shapeTree4.Append(shape15);
            shapeTree4.Append(shape16);

            CommonSlideDataExtensionList commonSlideDataExtensionList2 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension2 = new CommonSlideDataExtension(){ Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId2 = new P14.CreationId(){ Val = (UInt32Value)2970118228U };
            creationId2.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension2.Append(creationId2);

            commonSlideDataExtensionList2.Append(commonSlideDataExtension2);

            commonSlideData4.Append(background2);
            commonSlideData4.Append(shapeTree4);
            commonSlideData4.Append(commonSlideDataExtensionList2);
            ColorMap colorMap2 = new ColorMap(){ Background1 = A.ColorSchemeIndexValues.Light1, Text1 = A.ColorSchemeIndexValues.Dark1, Background2 = A.ColorSchemeIndexValues.Light2, Text2 = A.ColorSchemeIndexValues.Dark2, Accent1 = A.ColorSchemeIndexValues.Accent1, Accent2 = A.ColorSchemeIndexValues.Accent2, Accent3 = A.ColorSchemeIndexValues.Accent3, Accent4 = A.ColorSchemeIndexValues.Accent4, Accent5 = A.ColorSchemeIndexValues.Accent5, Accent6 = A.ColorSchemeIndexValues.Accent6, Hyperlink = A.ColorSchemeIndexValues.Hyperlink, FollowedHyperlink = A.ColorSchemeIndexValues.FollowedHyperlink };

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

            TitleStyle titleStyle1 = new TitleStyle();

            A.Level1ParagraphProperties level1ParagraphProperties10 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Center, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.SpaceBefore spaceBefore1 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent1 = new A.SpacingPercent(){ Val = 0 };

            spaceBefore1.Append(spacingPercent1);
            A.NoBullet noBullet10 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties35 = new A.DefaultRunProperties(){ FontSize = 4400, Kerning = 1200 };

            A.SolidFill solidFill37 = new A.SolidFill();
            A.SchemeColor schemeColor49 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill37.Append(schemeColor49);
            A.LatinFont latinFont21 = new A.LatinFont(){ Typeface = "+mj-lt" };
            A.EastAsianFont eastAsianFont21 = new A.EastAsianFont(){ Typeface = "+mj-ea" };
            A.ComplexScriptFont complexScriptFont21 = new A.ComplexScriptFont(){ Typeface = "+mj-cs" };

            defaultRunProperties35.Append(solidFill37);
            defaultRunProperties35.Append(latinFont21);
            defaultRunProperties35.Append(eastAsianFont21);
            defaultRunProperties35.Append(complexScriptFont21);

            level1ParagraphProperties10.Append(spaceBefore1);
            level1ParagraphProperties10.Append(noBullet10);
            level1ParagraphProperties10.Append(defaultRunProperties35);

            titleStyle1.Append(level1ParagraphProperties10);

            BodyStyle bodyStyle1 = new BodyStyle();

            A.Level1ParagraphProperties level1ParagraphProperties11 = new A.Level1ParagraphProperties(){ LeftMargin = 342900, Indent = -342900, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.SpaceBefore spaceBefore2 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent2 = new A.SpacingPercent(){ Val = 20000 };

            spaceBefore2.Append(spacingPercent2);
            A.BulletFont bulletFont1 = new A.BulletFont(){ Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            A.CharacterBullet characterBullet1 = new A.CharacterBullet(){ Char = "•" };

            A.DefaultRunProperties defaultRunProperties36 = new A.DefaultRunProperties(){ FontSize = 3200, Kerning = 1200 };

            A.SolidFill solidFill38 = new A.SolidFill();
            A.SchemeColor schemeColor50 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill38.Append(schemeColor50);
            A.LatinFont latinFont22 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont22 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont22 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties36.Append(solidFill38);
            defaultRunProperties36.Append(latinFont22);
            defaultRunProperties36.Append(eastAsianFont22);
            defaultRunProperties36.Append(complexScriptFont22);

            level1ParagraphProperties11.Append(spaceBefore2);
            level1ParagraphProperties11.Append(bulletFont1);
            level1ParagraphProperties11.Append(characterBullet1);
            level1ParagraphProperties11.Append(defaultRunProperties36);

            A.Level2ParagraphProperties level2ParagraphProperties4 = new A.Level2ParagraphProperties(){ LeftMargin = 742950, Indent = -285750, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.SpaceBefore spaceBefore3 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent3 = new A.SpacingPercent(){ Val = 20000 };

            spaceBefore3.Append(spacingPercent3);
            A.BulletFont bulletFont2 = new A.BulletFont(){ Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            A.CharacterBullet characterBullet2 = new A.CharacterBullet(){ Char = "–" };

            A.DefaultRunProperties defaultRunProperties37 = new A.DefaultRunProperties(){ FontSize = 2800, Kerning = 1200 };

            A.SolidFill solidFill39 = new A.SolidFill();
            A.SchemeColor schemeColor51 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill39.Append(schemeColor51);
            A.LatinFont latinFont23 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont23 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont23 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties37.Append(solidFill39);
            defaultRunProperties37.Append(latinFont23);
            defaultRunProperties37.Append(eastAsianFont23);
            defaultRunProperties37.Append(complexScriptFont23);

            level2ParagraphProperties4.Append(spaceBefore3);
            level2ParagraphProperties4.Append(bulletFont2);
            level2ParagraphProperties4.Append(characterBullet2);
            level2ParagraphProperties4.Append(defaultRunProperties37);

            A.Level3ParagraphProperties level3ParagraphProperties4 = new A.Level3ParagraphProperties(){ LeftMargin = 1143000, Indent = -228600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.SpaceBefore spaceBefore4 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent4 = new A.SpacingPercent(){ Val = 20000 };

            spaceBefore4.Append(spacingPercent4);
            A.BulletFont bulletFont3 = new A.BulletFont(){ Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            A.CharacterBullet characterBullet3 = new A.CharacterBullet(){ Char = "•" };

            A.DefaultRunProperties defaultRunProperties38 = new A.DefaultRunProperties(){ FontSize = 2400, Kerning = 1200 };

            A.SolidFill solidFill40 = new A.SolidFill();
            A.SchemeColor schemeColor52 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill40.Append(schemeColor52);
            A.LatinFont latinFont24 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont24 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont24 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties38.Append(solidFill40);
            defaultRunProperties38.Append(latinFont24);
            defaultRunProperties38.Append(eastAsianFont24);
            defaultRunProperties38.Append(complexScriptFont24);

            level3ParagraphProperties4.Append(spaceBefore4);
            level3ParagraphProperties4.Append(bulletFont3);
            level3ParagraphProperties4.Append(characterBullet3);
            level3ParagraphProperties4.Append(defaultRunProperties38);

            A.Level4ParagraphProperties level4ParagraphProperties4 = new A.Level4ParagraphProperties(){ LeftMargin = 1600200, Indent = -228600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.SpaceBefore spaceBefore5 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent5 = new A.SpacingPercent(){ Val = 20000 };

            spaceBefore5.Append(spacingPercent5);
            A.BulletFont bulletFont4 = new A.BulletFont(){ Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            A.CharacterBullet characterBullet4 = new A.CharacterBullet(){ Char = "–" };

            A.DefaultRunProperties defaultRunProperties39 = new A.DefaultRunProperties(){ FontSize = 2000, Kerning = 1200 };

            A.SolidFill solidFill41 = new A.SolidFill();
            A.SchemeColor schemeColor53 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill41.Append(schemeColor53);
            A.LatinFont latinFont25 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont25 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont25 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties39.Append(solidFill41);
            defaultRunProperties39.Append(latinFont25);
            defaultRunProperties39.Append(eastAsianFont25);
            defaultRunProperties39.Append(complexScriptFont25);

            level4ParagraphProperties4.Append(spaceBefore5);
            level4ParagraphProperties4.Append(bulletFont4);
            level4ParagraphProperties4.Append(characterBullet4);
            level4ParagraphProperties4.Append(defaultRunProperties39);

            A.Level5ParagraphProperties level5ParagraphProperties4 = new A.Level5ParagraphProperties(){ LeftMargin = 2057400, Indent = -228600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.SpaceBefore spaceBefore6 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent6 = new A.SpacingPercent(){ Val = 20000 };

            spaceBefore6.Append(spacingPercent6);
            A.BulletFont bulletFont5 = new A.BulletFont(){ Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            A.CharacterBullet characterBullet5 = new A.CharacterBullet(){ Char = "»" };

            A.DefaultRunProperties defaultRunProperties40 = new A.DefaultRunProperties(){ FontSize = 2000, Kerning = 1200 };

            A.SolidFill solidFill42 = new A.SolidFill();
            A.SchemeColor schemeColor54 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill42.Append(schemeColor54);
            A.LatinFont latinFont26 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont26 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont26 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties40.Append(solidFill42);
            defaultRunProperties40.Append(latinFont26);
            defaultRunProperties40.Append(eastAsianFont26);
            defaultRunProperties40.Append(complexScriptFont26);

            level5ParagraphProperties4.Append(spaceBefore6);
            level5ParagraphProperties4.Append(bulletFont5);
            level5ParagraphProperties4.Append(characterBullet5);
            level5ParagraphProperties4.Append(defaultRunProperties40);

            A.Level6ParagraphProperties level6ParagraphProperties4 = new A.Level6ParagraphProperties(){ LeftMargin = 2514600, Indent = -228600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.SpaceBefore spaceBefore7 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent7 = new A.SpacingPercent(){ Val = 20000 };

            spaceBefore7.Append(spacingPercent7);
            A.BulletFont bulletFont6 = new A.BulletFont(){ Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            A.CharacterBullet characterBullet6 = new A.CharacterBullet(){ Char = "•" };

            A.DefaultRunProperties defaultRunProperties41 = new A.DefaultRunProperties(){ FontSize = 2000, Kerning = 1200 };

            A.SolidFill solidFill43 = new A.SolidFill();
            A.SchemeColor schemeColor55 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill43.Append(schemeColor55);
            A.LatinFont latinFont27 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont27 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont27 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties41.Append(solidFill43);
            defaultRunProperties41.Append(latinFont27);
            defaultRunProperties41.Append(eastAsianFont27);
            defaultRunProperties41.Append(complexScriptFont27);

            level6ParagraphProperties4.Append(spaceBefore7);
            level6ParagraphProperties4.Append(bulletFont6);
            level6ParagraphProperties4.Append(characterBullet6);
            level6ParagraphProperties4.Append(defaultRunProperties41);

            A.Level7ParagraphProperties level7ParagraphProperties4 = new A.Level7ParagraphProperties(){ LeftMargin = 2971800, Indent = -228600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.SpaceBefore spaceBefore8 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent8 = new A.SpacingPercent(){ Val = 20000 };

            spaceBefore8.Append(spacingPercent8);
            A.BulletFont bulletFont7 = new A.BulletFont(){ Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            A.CharacterBullet characterBullet7 = new A.CharacterBullet(){ Char = "•" };

            A.DefaultRunProperties defaultRunProperties42 = new A.DefaultRunProperties(){ FontSize = 2000, Kerning = 1200 };

            A.SolidFill solidFill44 = new A.SolidFill();
            A.SchemeColor schemeColor56 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill44.Append(schemeColor56);
            A.LatinFont latinFont28 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont28 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont28 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties42.Append(solidFill44);
            defaultRunProperties42.Append(latinFont28);
            defaultRunProperties42.Append(eastAsianFont28);
            defaultRunProperties42.Append(complexScriptFont28);

            level7ParagraphProperties4.Append(spaceBefore8);
            level7ParagraphProperties4.Append(bulletFont7);
            level7ParagraphProperties4.Append(characterBullet7);
            level7ParagraphProperties4.Append(defaultRunProperties42);

            A.Level8ParagraphProperties level8ParagraphProperties4 = new A.Level8ParagraphProperties(){ LeftMargin = 3429000, Indent = -228600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.SpaceBefore spaceBefore9 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent9 = new A.SpacingPercent(){ Val = 20000 };

            spaceBefore9.Append(spacingPercent9);
            A.BulletFont bulletFont8 = new A.BulletFont(){ Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            A.CharacterBullet characterBullet8 = new A.CharacterBullet(){ Char = "•" };

            A.DefaultRunProperties defaultRunProperties43 = new A.DefaultRunProperties(){ FontSize = 2000, Kerning = 1200 };

            A.SolidFill solidFill45 = new A.SolidFill();
            A.SchemeColor schemeColor57 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill45.Append(schemeColor57);
            A.LatinFont latinFont29 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont29 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont29 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties43.Append(solidFill45);
            defaultRunProperties43.Append(latinFont29);
            defaultRunProperties43.Append(eastAsianFont29);
            defaultRunProperties43.Append(complexScriptFont29);

            level8ParagraphProperties4.Append(spaceBefore9);
            level8ParagraphProperties4.Append(bulletFont8);
            level8ParagraphProperties4.Append(characterBullet8);
            level8ParagraphProperties4.Append(defaultRunProperties43);

            A.Level9ParagraphProperties level9ParagraphProperties4 = new A.Level9ParagraphProperties(){ LeftMargin = 3886200, Indent = -228600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.SpaceBefore spaceBefore10 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent10 = new A.SpacingPercent(){ Val = 20000 };

            spaceBefore10.Append(spacingPercent10);
            A.BulletFont bulletFont9 = new A.BulletFont(){ Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            A.CharacterBullet characterBullet9 = new A.CharacterBullet(){ Char = "•" };

            A.DefaultRunProperties defaultRunProperties44 = new A.DefaultRunProperties(){ FontSize = 2000, Kerning = 1200 };

            A.SolidFill solidFill46 = new A.SolidFill();
            A.SchemeColor schemeColor58 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill46.Append(schemeColor58);
            A.LatinFont latinFont30 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont30 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont30 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties44.Append(solidFill46);
            defaultRunProperties44.Append(latinFont30);
            defaultRunProperties44.Append(eastAsianFont30);
            defaultRunProperties44.Append(complexScriptFont30);

            level9ParagraphProperties4.Append(spaceBefore10);
            level9ParagraphProperties4.Append(bulletFont9);
            level9ParagraphProperties4.Append(characterBullet9);
            level9ParagraphProperties4.Append(defaultRunProperties44);

            bodyStyle1.Append(level1ParagraphProperties11);
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
            A.DefaultRunProperties defaultRunProperties45 = new A.DefaultRunProperties(){ Language = "en-US" };

            defaultParagraphProperties2.Append(defaultRunProperties45);

            A.Level1ParagraphProperties level1ParagraphProperties12 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties46 = new A.DefaultRunProperties(){ FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill47 = new A.SolidFill();
            A.SchemeColor schemeColor59 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill47.Append(schemeColor59);
            A.LatinFont latinFont31 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont31 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont31 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties46.Append(solidFill47);
            defaultRunProperties46.Append(latinFont31);
            defaultRunProperties46.Append(eastAsianFont31);
            defaultRunProperties46.Append(complexScriptFont31);

            level1ParagraphProperties12.Append(defaultRunProperties46);

            A.Level2ParagraphProperties level2ParagraphProperties5 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties47 = new A.DefaultRunProperties(){ FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill48 = new A.SolidFill();
            A.SchemeColor schemeColor60 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill48.Append(schemeColor60);
            A.LatinFont latinFont32 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont32 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont32 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties47.Append(solidFill48);
            defaultRunProperties47.Append(latinFont32);
            defaultRunProperties47.Append(eastAsianFont32);
            defaultRunProperties47.Append(complexScriptFont32);

            level2ParagraphProperties5.Append(defaultRunProperties47);

            A.Level3ParagraphProperties level3ParagraphProperties5 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties48 = new A.DefaultRunProperties(){ FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill49 = new A.SolidFill();
            A.SchemeColor schemeColor61 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill49.Append(schemeColor61);
            A.LatinFont latinFont33 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont33 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont33 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties48.Append(solidFill49);
            defaultRunProperties48.Append(latinFont33);
            defaultRunProperties48.Append(eastAsianFont33);
            defaultRunProperties48.Append(complexScriptFont33);

            level3ParagraphProperties5.Append(defaultRunProperties48);

            A.Level4ParagraphProperties level4ParagraphProperties5 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties49 = new A.DefaultRunProperties(){ FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill50 = new A.SolidFill();
            A.SchemeColor schemeColor62 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill50.Append(schemeColor62);
            A.LatinFont latinFont34 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont34 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont34 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties49.Append(solidFill50);
            defaultRunProperties49.Append(latinFont34);
            defaultRunProperties49.Append(eastAsianFont34);
            defaultRunProperties49.Append(complexScriptFont34);

            level4ParagraphProperties5.Append(defaultRunProperties49);

            A.Level5ParagraphProperties level5ParagraphProperties5 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties50 = new A.DefaultRunProperties(){ FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill51 = new A.SolidFill();
            A.SchemeColor schemeColor63 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill51.Append(schemeColor63);
            A.LatinFont latinFont35 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont35 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont35 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties50.Append(solidFill51);
            defaultRunProperties50.Append(latinFont35);
            defaultRunProperties50.Append(eastAsianFont35);
            defaultRunProperties50.Append(complexScriptFont35);

            level5ParagraphProperties5.Append(defaultRunProperties50);

            A.Level6ParagraphProperties level6ParagraphProperties5 = new A.Level6ParagraphProperties(){ LeftMargin = 2286000, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties51 = new A.DefaultRunProperties(){ FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill52 = new A.SolidFill();
            A.SchemeColor schemeColor64 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill52.Append(schemeColor64);
            A.LatinFont latinFont36 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont36 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont36 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties51.Append(solidFill52);
            defaultRunProperties51.Append(latinFont36);
            defaultRunProperties51.Append(eastAsianFont36);
            defaultRunProperties51.Append(complexScriptFont36);

            level6ParagraphProperties5.Append(defaultRunProperties51);

            A.Level7ParagraphProperties level7ParagraphProperties5 = new A.Level7ParagraphProperties(){ LeftMargin = 2743200, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties52 = new A.DefaultRunProperties(){ FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill53 = new A.SolidFill();
            A.SchemeColor schemeColor65 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill53.Append(schemeColor65);
            A.LatinFont latinFont37 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont37 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont37 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties52.Append(solidFill53);
            defaultRunProperties52.Append(latinFont37);
            defaultRunProperties52.Append(eastAsianFont37);
            defaultRunProperties52.Append(complexScriptFont37);

            level7ParagraphProperties5.Append(defaultRunProperties52);

            A.Level8ParagraphProperties level8ParagraphProperties5 = new A.Level8ParagraphProperties(){ LeftMargin = 3200400, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties53 = new A.DefaultRunProperties(){ FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill54 = new A.SolidFill();
            A.SchemeColor schemeColor66 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill54.Append(schemeColor66);
            A.LatinFont latinFont38 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont38 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont38 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties53.Append(solidFill54);
            defaultRunProperties53.Append(latinFont38);
            defaultRunProperties53.Append(eastAsianFont38);
            defaultRunProperties53.Append(complexScriptFont38);

            level8ParagraphProperties5.Append(defaultRunProperties53);

            A.Level9ParagraphProperties level9ParagraphProperties5 = new A.Level9ParagraphProperties(){ LeftMargin = 3657600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties54 = new A.DefaultRunProperties(){ FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill55 = new A.SolidFill();
            A.SchemeColor schemeColor67 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };

            solidFill55.Append(schemeColor67);
            A.LatinFont latinFont39 = new A.LatinFont(){ Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont39 = new A.EastAsianFont(){ Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont39 = new A.ComplexScriptFont(){ Typeface = "+mn-cs" };

            defaultRunProperties54.Append(solidFill55);
            defaultRunProperties54.Append(latinFont39);
            defaultRunProperties54.Append(eastAsianFont39);
            defaultRunProperties54.Append(complexScriptFont39);

            level9ParagraphProperties5.Append(defaultRunProperties54);

            otherStyle1.Append(defaultParagraphProperties2);
            otherStyle1.Append(level1ParagraphProperties12);
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

            slideMaster1.Append(commonSlideData4);
            slideMaster1.Append(colorMap2);
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

            CommonSlideData commonSlideData5 = new CommonSlideData(){ Name = "Content with Caption" };

            ShapeTree shapeTree5 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties5 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties21 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties5 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties21 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties5.Append(nonVisualDrawingProperties21);
            nonVisualGroupShapeProperties5.Append(nonVisualGroupShapeDrawingProperties5);
            nonVisualGroupShapeProperties5.Append(applicationNonVisualDrawingProperties21);

            GroupShapeProperties groupShapeProperties5 = new GroupShapeProperties();

            A.TransformGroup transformGroup5 = new A.TransformGroup();
            A.Offset offset18 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents18 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset5 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents5 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup5.Append(offset18);
            transformGroup5.Append(extents18);
            transformGroup5.Append(childOffset5);
            transformGroup5.Append(childExtents5);

            groupShapeProperties5.Append(transformGroup5);

            Shape shape17 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties17 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties22 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties17 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks16 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties17.Append(shapeLocks16);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties22 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape16 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties22.Append(placeholderShape16);

            nonVisualShapeProperties17.Append(nonVisualDrawingProperties22);
            nonVisualShapeProperties17.Append(nonVisualShapeDrawingProperties17);
            nonVisualShapeProperties17.Append(applicationNonVisualDrawingProperties22);

            ShapeProperties shapeProperties17 = new ShapeProperties();

            A.Transform2D transform2D14 = new A.Transform2D();
            A.Offset offset19 = new A.Offset(){ X = 457201L, Y = 273050L };
            A.Extents extents19 = new A.Extents(){ Cx = 3008313L, Cy = 1162050L };

            transform2D14.Append(offset19);
            transform2D14.Append(extents19);

            shapeProperties17.Append(transform2D14);

            TextBody textBody17 = new TextBody();
            A.BodyProperties bodyProperties17 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Bottom };

            A.ListStyle listStyle17 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties13 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Left };
            A.DefaultRunProperties defaultRunProperties55 = new A.DefaultRunProperties(){ FontSize = 2000, Bold = true };

            level1ParagraphProperties13.Append(defaultRunProperties55);

            listStyle17.Append(level1ParagraphProperties13);

            A.Paragraph paragraph34 = new A.Paragraph();

            A.Run run25 = new A.Run();

            A.RunProperties runProperties30 = new A.RunProperties(){ Language = "en-US" };
            runProperties30.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text30 = new A.Text();
            text30.Text = "Click to edit Master title style";

            run25.Append(runProperties30);
            run25.Append(text30);
            A.EndParagraphRunProperties endParagraphRunProperties18 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph34.Append(run25);
            paragraph34.Append(endParagraphRunProperties18);

            textBody17.Append(bodyProperties17);
            textBody17.Append(listStyle17);
            textBody17.Append(paragraph34);

            shape17.Append(nonVisualShapeProperties17);
            shape17.Append(shapeProperties17);
            shape17.Append(textBody17);

            Shape shape18 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties18 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties23 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Content Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties18 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks17 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties18.Append(shapeLocks17);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties23 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape17 = new PlaceholderShape(){ Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties23.Append(placeholderShape17);

            nonVisualShapeProperties18.Append(nonVisualDrawingProperties23);
            nonVisualShapeProperties18.Append(nonVisualShapeDrawingProperties18);
            nonVisualShapeProperties18.Append(applicationNonVisualDrawingProperties23);

            ShapeProperties shapeProperties18 = new ShapeProperties();

            A.Transform2D transform2D15 = new A.Transform2D();
            A.Offset offset20 = new A.Offset(){ X = 3575050L, Y = 273051L };
            A.Extents extents20 = new A.Extents(){ Cx = 5111751L, Cy = 5853113L };

            transform2D15.Append(offset20);
            transform2D15.Append(extents20);

            shapeProperties18.Append(transform2D15);

            TextBody textBody18 = new TextBody();
            A.BodyProperties bodyProperties18 = new A.BodyProperties();

            A.ListStyle listStyle18 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties14 = new A.Level1ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties56 = new A.DefaultRunProperties(){ FontSize = 3200 };

            level1ParagraphProperties14.Append(defaultRunProperties56);

            A.Level2ParagraphProperties level2ParagraphProperties6 = new A.Level2ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties57 = new A.DefaultRunProperties(){ FontSize = 2800 };

            level2ParagraphProperties6.Append(defaultRunProperties57);

            A.Level3ParagraphProperties level3ParagraphProperties6 = new A.Level3ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties58 = new A.DefaultRunProperties(){ FontSize = 2400 };

            level3ParagraphProperties6.Append(defaultRunProperties58);

            A.Level4ParagraphProperties level4ParagraphProperties6 = new A.Level4ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties59 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level4ParagraphProperties6.Append(defaultRunProperties59);

            A.Level5ParagraphProperties level5ParagraphProperties6 = new A.Level5ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties60 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level5ParagraphProperties6.Append(defaultRunProperties60);

            A.Level6ParagraphProperties level6ParagraphProperties6 = new A.Level6ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties61 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level6ParagraphProperties6.Append(defaultRunProperties61);

            A.Level7ParagraphProperties level7ParagraphProperties6 = new A.Level7ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties62 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level7ParagraphProperties6.Append(defaultRunProperties62);

            A.Level8ParagraphProperties level8ParagraphProperties6 = new A.Level8ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties63 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level8ParagraphProperties6.Append(defaultRunProperties63);

            A.Level9ParagraphProperties level9ParagraphProperties6 = new A.Level9ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties64 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level9ParagraphProperties6.Append(defaultRunProperties64);

            listStyle18.Append(level1ParagraphProperties14);
            listStyle18.Append(level2ParagraphProperties6);
            listStyle18.Append(level3ParagraphProperties6);
            listStyle18.Append(level4ParagraphProperties6);
            listStyle18.Append(level5ParagraphProperties6);
            listStyle18.Append(level6ParagraphProperties6);
            listStyle18.Append(level7ParagraphProperties6);
            listStyle18.Append(level8ParagraphProperties6);
            listStyle18.Append(level9ParagraphProperties6);

            A.Paragraph paragraph35 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties19 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run26 = new A.Run();

            A.RunProperties runProperties31 = new A.RunProperties(){ Language = "en-US" };
            runProperties31.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text31 = new A.Text();
            text31.Text = "Click to edit Master text styles";

            run26.Append(runProperties31);
            run26.Append(text31);

            paragraph35.Append(paragraphProperties19);
            paragraph35.Append(run26);

            A.Paragraph paragraph36 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties20 = new A.ParagraphProperties(){ Level = 1 };

            A.Run run27 = new A.Run();

            A.RunProperties runProperties32 = new A.RunProperties(){ Language = "en-US" };
            runProperties32.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text32 = new A.Text();
            text32.Text = "Second level";

            run27.Append(runProperties32);
            run27.Append(text32);

            paragraph36.Append(paragraphProperties20);
            paragraph36.Append(run27);

            A.Paragraph paragraph37 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties21 = new A.ParagraphProperties(){ Level = 2 };

            A.Run run28 = new A.Run();

            A.RunProperties runProperties33 = new A.RunProperties(){ Language = "en-US" };
            runProperties33.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text33 = new A.Text();
            text33.Text = "Third level";

            run28.Append(runProperties33);
            run28.Append(text33);

            paragraph37.Append(paragraphProperties21);
            paragraph37.Append(run28);

            A.Paragraph paragraph38 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties22 = new A.ParagraphProperties(){ Level = 3 };

            A.Run run29 = new A.Run();

            A.RunProperties runProperties34 = new A.RunProperties(){ Language = "en-US" };
            runProperties34.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text34 = new A.Text();
            text34.Text = "Fourth level";

            run29.Append(runProperties34);
            run29.Append(text34);

            paragraph38.Append(paragraphProperties22);
            paragraph38.Append(run29);

            A.Paragraph paragraph39 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties23 = new A.ParagraphProperties(){ Level = 4 };

            A.Run run30 = new A.Run();

            A.RunProperties runProperties35 = new A.RunProperties(){ Language = "en-US" };
            runProperties35.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text35 = new A.Text();
            text35.Text = "Fifth level";

            run30.Append(runProperties35);
            run30.Append(text35);
            A.EndParagraphRunProperties endParagraphRunProperties19 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph39.Append(paragraphProperties23);
            paragraph39.Append(run30);
            paragraph39.Append(endParagraphRunProperties19);

            textBody18.Append(bodyProperties18);
            textBody18.Append(listStyle18);
            textBody18.Append(paragraph35);
            textBody18.Append(paragraph36);
            textBody18.Append(paragraph37);
            textBody18.Append(paragraph38);
            textBody18.Append(paragraph39);

            shape18.Append(nonVisualShapeProperties18);
            shape18.Append(shapeProperties18);
            shape18.Append(textBody18);

            Shape shape19 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties19 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties24 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Text Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties19 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks18 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties19.Append(shapeLocks18);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties24 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape18 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)2U };

            applicationNonVisualDrawingProperties24.Append(placeholderShape18);

            nonVisualShapeProperties19.Append(nonVisualDrawingProperties24);
            nonVisualShapeProperties19.Append(nonVisualShapeDrawingProperties19);
            nonVisualShapeProperties19.Append(applicationNonVisualDrawingProperties24);

            ShapeProperties shapeProperties19 = new ShapeProperties();

            A.Transform2D transform2D16 = new A.Transform2D();
            A.Offset offset21 = new A.Offset(){ X = 457201L, Y = 1435101L };
            A.Extents extents21 = new A.Extents(){ Cx = 3008313L, Cy = 4691063L };

            transform2D16.Append(offset21);
            transform2D16.Append(extents21);

            shapeProperties19.Append(transform2D16);

            TextBody textBody19 = new TextBody();
            A.BodyProperties bodyProperties19 = new A.BodyProperties();

            A.ListStyle listStyle19 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties15 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0 };
            A.NoBullet noBullet11 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties65 = new A.DefaultRunProperties(){ FontSize = 1400 };

            level1ParagraphProperties15.Append(noBullet11);
            level1ParagraphProperties15.Append(defaultRunProperties65);

            A.Level2ParagraphProperties level2ParagraphProperties7 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Indent = 0 };
            A.NoBullet noBullet12 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties66 = new A.DefaultRunProperties(){ FontSize = 1200 };

            level2ParagraphProperties7.Append(noBullet12);
            level2ParagraphProperties7.Append(defaultRunProperties66);

            A.Level3ParagraphProperties level3ParagraphProperties7 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Indent = 0 };
            A.NoBullet noBullet13 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties67 = new A.DefaultRunProperties(){ FontSize = 1000 };

            level3ParagraphProperties7.Append(noBullet13);
            level3ParagraphProperties7.Append(defaultRunProperties67);

            A.Level4ParagraphProperties level4ParagraphProperties7 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Indent = 0 };
            A.NoBullet noBullet14 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties68 = new A.DefaultRunProperties(){ FontSize = 900 };

            level4ParagraphProperties7.Append(noBullet14);
            level4ParagraphProperties7.Append(defaultRunProperties68);

            A.Level5ParagraphProperties level5ParagraphProperties7 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Indent = 0 };
            A.NoBullet noBullet15 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties69 = new A.DefaultRunProperties(){ FontSize = 900 };

            level5ParagraphProperties7.Append(noBullet15);
            level5ParagraphProperties7.Append(defaultRunProperties69);

            A.Level6ParagraphProperties level6ParagraphProperties7 = new A.Level6ParagraphProperties(){ LeftMargin = 2286000, Indent = 0 };
            A.NoBullet noBullet16 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties70 = new A.DefaultRunProperties(){ FontSize = 900 };

            level6ParagraphProperties7.Append(noBullet16);
            level6ParagraphProperties7.Append(defaultRunProperties70);

            A.Level7ParagraphProperties level7ParagraphProperties7 = new A.Level7ParagraphProperties(){ LeftMargin = 2743200, Indent = 0 };
            A.NoBullet noBullet17 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties71 = new A.DefaultRunProperties(){ FontSize = 900 };

            level7ParagraphProperties7.Append(noBullet17);
            level7ParagraphProperties7.Append(defaultRunProperties71);

            A.Level8ParagraphProperties level8ParagraphProperties7 = new A.Level8ParagraphProperties(){ LeftMargin = 3200400, Indent = 0 };
            A.NoBullet noBullet18 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties72 = new A.DefaultRunProperties(){ FontSize = 900 };

            level8ParagraphProperties7.Append(noBullet18);
            level8ParagraphProperties7.Append(defaultRunProperties72);

            A.Level9ParagraphProperties level9ParagraphProperties7 = new A.Level9ParagraphProperties(){ LeftMargin = 3657600, Indent = 0 };
            A.NoBullet noBullet19 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties73 = new A.DefaultRunProperties(){ FontSize = 900 };

            level9ParagraphProperties7.Append(noBullet19);
            level9ParagraphProperties7.Append(defaultRunProperties73);

            listStyle19.Append(level1ParagraphProperties15);
            listStyle19.Append(level2ParagraphProperties7);
            listStyle19.Append(level3ParagraphProperties7);
            listStyle19.Append(level4ParagraphProperties7);
            listStyle19.Append(level5ParagraphProperties7);
            listStyle19.Append(level6ParagraphProperties7);
            listStyle19.Append(level7ParagraphProperties7);
            listStyle19.Append(level8ParagraphProperties7);
            listStyle19.Append(level9ParagraphProperties7);

            A.Paragraph paragraph40 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties24 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run31 = new A.Run();

            A.RunProperties runProperties36 = new A.RunProperties(){ Language = "en-US" };
            runProperties36.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text36 = new A.Text();
            text36.Text = "Click to edit Master text styles";

            run31.Append(runProperties36);
            run31.Append(text36);

            paragraph40.Append(paragraphProperties24);
            paragraph40.Append(run31);

            textBody19.Append(bodyProperties19);
            textBody19.Append(listStyle19);
            textBody19.Append(paragraph40);

            shape19.Append(nonVisualShapeProperties19);
            shape19.Append(shapeProperties19);
            shape19.Append(textBody19);

            Shape shape20 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties20 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties25 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Date Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties20 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks19 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties20.Append(shapeLocks19);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties25 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape19 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties25.Append(placeholderShape19);

            nonVisualShapeProperties20.Append(nonVisualDrawingProperties25);
            nonVisualShapeProperties20.Append(nonVisualShapeDrawingProperties20);
            nonVisualShapeProperties20.Append(applicationNonVisualDrawingProperties25);
            ShapeProperties shapeProperties20 = new ShapeProperties();

            TextBody textBody20 = new TextBody();
            A.BodyProperties bodyProperties20 = new A.BodyProperties();
            A.ListStyle listStyle20 = new A.ListStyle();

            A.Paragraph paragraph41 = new A.Paragraph();

            A.Field field6 = new A.Field(){ Id = "{1A15D4F1-1D33-4170-8C9F-182CDE6BA6D1}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties37 = new A.RunProperties(){ Language = "en-US" };
            runProperties37.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text37 = new A.Text();
            text37.Text = "10/3/2012";

            field6.Append(runProperties37);
            field6.Append(text37);
            A.EndParagraphRunProperties endParagraphRunProperties20 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph41.Append(field6);
            paragraph41.Append(endParagraphRunProperties20);

            textBody20.Append(bodyProperties20);
            textBody20.Append(listStyle20);
            textBody20.Append(paragraph41);

            shape20.Append(nonVisualShapeProperties20);
            shape20.Append(shapeProperties20);
            shape20.Append(textBody20);

            Shape shape21 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties21 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties26 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Footer Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties21 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks20 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties21.Append(shapeLocks20);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties26 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape20 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties26.Append(placeholderShape20);

            nonVisualShapeProperties21.Append(nonVisualDrawingProperties26);
            nonVisualShapeProperties21.Append(nonVisualShapeDrawingProperties21);
            nonVisualShapeProperties21.Append(applicationNonVisualDrawingProperties26);
            ShapeProperties shapeProperties21 = new ShapeProperties();

            TextBody textBody21 = new TextBody();
            A.BodyProperties bodyProperties21 = new A.BodyProperties();
            A.ListStyle listStyle21 = new A.ListStyle();

            A.Paragraph paragraph42 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties21 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph42.Append(endParagraphRunProperties21);

            textBody21.Append(bodyProperties21);
            textBody21.Append(listStyle21);
            textBody21.Append(paragraph42);

            shape21.Append(nonVisualShapeProperties21);
            shape21.Append(shapeProperties21);
            shape21.Append(textBody21);

            Shape shape22 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties22 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties27 = new NonVisualDrawingProperties(){ Id = (UInt32Value)7U, Name = "Slide Number Placeholder 6" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties22 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks21 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties22.Append(shapeLocks21);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties27 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape21 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties27.Append(placeholderShape21);

            nonVisualShapeProperties22.Append(nonVisualDrawingProperties27);
            nonVisualShapeProperties22.Append(nonVisualShapeDrawingProperties22);
            nonVisualShapeProperties22.Append(applicationNonVisualDrawingProperties27);
            ShapeProperties shapeProperties22 = new ShapeProperties();

            TextBody textBody22 = new TextBody();
            A.BodyProperties bodyProperties22 = new A.BodyProperties();
            A.ListStyle listStyle22 = new A.ListStyle();

            A.Paragraph paragraph43 = new A.Paragraph();

            A.Field field7 = new A.Field(){ Id = "{9E0C3BFA-D4DA-4895-A0F6-B80859694A8D}", Type = "slidenum" };

            A.RunProperties runProperties38 = new A.RunProperties(){ Language = "en-US" };
            runProperties38.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text38 = new A.Text();
            text38.Text = "‹#›";

            field7.Append(runProperties38);
            field7.Append(text38);
            A.EndParagraphRunProperties endParagraphRunProperties22 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph43.Append(field7);
            paragraph43.Append(endParagraphRunProperties22);

            textBody22.Append(bodyProperties22);
            textBody22.Append(listStyle22);
            textBody22.Append(paragraph43);

            shape22.Append(nonVisualShapeProperties22);
            shape22.Append(shapeProperties22);
            shape22.Append(textBody22);

            shapeTree5.Append(nonVisualGroupShapeProperties5);
            shapeTree5.Append(groupShapeProperties5);
            shapeTree5.Append(shape17);
            shapeTree5.Append(shape18);
            shapeTree5.Append(shape19);
            shapeTree5.Append(shape20);
            shapeTree5.Append(shape21);
            shapeTree5.Append(shape22);

            commonSlideData5.Append(shapeTree5);

            ColorMapOverride colorMapOverride3 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping3 = new A.MasterColorMapping();

            colorMapOverride3.Append(masterColorMapping3);

            slideLayout2.Append(commonSlideData5);
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

            CommonSlideData commonSlideData6 = new CommonSlideData(){ Name = "Section Header" };

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
            A.Offset offset22 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents22 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset6 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents6 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup6.Append(offset22);
            transformGroup6.Append(extents22);
            transformGroup6.Append(childOffset6);
            transformGroup6.Append(childExtents6);

            groupShapeProperties6.Append(transformGroup6);

            Shape shape23 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties23 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties29 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties23 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks22 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties23.Append(shapeLocks22);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties29 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape22 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties29.Append(placeholderShape22);

            nonVisualShapeProperties23.Append(nonVisualDrawingProperties29);
            nonVisualShapeProperties23.Append(nonVisualShapeDrawingProperties23);
            nonVisualShapeProperties23.Append(applicationNonVisualDrawingProperties29);

            ShapeProperties shapeProperties23 = new ShapeProperties();

            A.Transform2D transform2D17 = new A.Transform2D();
            A.Offset offset23 = new A.Offset(){ X = 722313L, Y = 4406900L };
            A.Extents extents23 = new A.Extents(){ Cx = 7772400L, Cy = 1362075L };

            transform2D17.Append(offset23);
            transform2D17.Append(extents23);

            shapeProperties23.Append(transform2D17);

            TextBody textBody23 = new TextBody();
            A.BodyProperties bodyProperties23 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Top };

            A.ListStyle listStyle23 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties16 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Left };
            A.DefaultRunProperties defaultRunProperties74 = new A.DefaultRunProperties(){ FontSize = 4000, Bold = true, Capital = A.TextCapsValues.All };

            level1ParagraphProperties16.Append(defaultRunProperties74);

            listStyle23.Append(level1ParagraphProperties16);

            A.Paragraph paragraph44 = new A.Paragraph();

            A.Run run32 = new A.Run();

            A.RunProperties runProperties39 = new A.RunProperties(){ Language = "en-US" };
            runProperties39.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text39 = new A.Text();
            text39.Text = "Click to edit Master title style";

            run32.Append(runProperties39);
            run32.Append(text39);
            A.EndParagraphRunProperties endParagraphRunProperties23 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph44.Append(run32);
            paragraph44.Append(endParagraphRunProperties23);

            textBody23.Append(bodyProperties23);
            textBody23.Append(listStyle23);
            textBody23.Append(paragraph44);

            shape23.Append(nonVisualShapeProperties23);
            shape23.Append(shapeProperties23);
            shape23.Append(textBody23);

            Shape shape24 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties24 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties30 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Text Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties24 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks23 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties24.Append(shapeLocks23);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties30 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape23 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties30.Append(placeholderShape23);

            nonVisualShapeProperties24.Append(nonVisualDrawingProperties30);
            nonVisualShapeProperties24.Append(nonVisualShapeDrawingProperties24);
            nonVisualShapeProperties24.Append(applicationNonVisualDrawingProperties30);

            ShapeProperties shapeProperties24 = new ShapeProperties();

            A.Transform2D transform2D18 = new A.Transform2D();
            A.Offset offset24 = new A.Offset(){ X = 722313L, Y = 2906714L };
            A.Extents extents24 = new A.Extents(){ Cx = 7772400L, Cy = 1500187L };

            transform2D18.Append(offset24);
            transform2D18.Append(extents24);

            shapeProperties24.Append(transform2D18);

            TextBody textBody24 = new TextBody();
            A.BodyProperties bodyProperties24 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Bottom };

            A.ListStyle listStyle24 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties17 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0 };
            A.NoBullet noBullet20 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties75 = new A.DefaultRunProperties(){ FontSize = 2000 };

            A.SolidFill solidFill56 = new A.SolidFill();

            A.SchemeColor schemeColor68 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint19 = new A.Tint(){ Val = 75000 };

            schemeColor68.Append(tint19);

            solidFill56.Append(schemeColor68);

            defaultRunProperties75.Append(solidFill56);

            level1ParagraphProperties17.Append(noBullet20);
            level1ParagraphProperties17.Append(defaultRunProperties75);

            A.Level2ParagraphProperties level2ParagraphProperties8 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Indent = 0 };
            A.NoBullet noBullet21 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties76 = new A.DefaultRunProperties(){ FontSize = 1800 };

            A.SolidFill solidFill57 = new A.SolidFill();

            A.SchemeColor schemeColor69 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint20 = new A.Tint(){ Val = 75000 };

            schemeColor69.Append(tint20);

            solidFill57.Append(schemeColor69);

            defaultRunProperties76.Append(solidFill57);

            level2ParagraphProperties8.Append(noBullet21);
            level2ParagraphProperties8.Append(defaultRunProperties76);

            A.Level3ParagraphProperties level3ParagraphProperties8 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Indent = 0 };
            A.NoBullet noBullet22 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties77 = new A.DefaultRunProperties(){ FontSize = 1600 };

            A.SolidFill solidFill58 = new A.SolidFill();

            A.SchemeColor schemeColor70 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint21 = new A.Tint(){ Val = 75000 };

            schemeColor70.Append(tint21);

            solidFill58.Append(schemeColor70);

            defaultRunProperties77.Append(solidFill58);

            level3ParagraphProperties8.Append(noBullet22);
            level3ParagraphProperties8.Append(defaultRunProperties77);

            A.Level4ParagraphProperties level4ParagraphProperties8 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Indent = 0 };
            A.NoBullet noBullet23 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties78 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill59 = new A.SolidFill();

            A.SchemeColor schemeColor71 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint22 = new A.Tint(){ Val = 75000 };

            schemeColor71.Append(tint22);

            solidFill59.Append(schemeColor71);

            defaultRunProperties78.Append(solidFill59);

            level4ParagraphProperties8.Append(noBullet23);
            level4ParagraphProperties8.Append(defaultRunProperties78);

            A.Level5ParagraphProperties level5ParagraphProperties8 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Indent = 0 };
            A.NoBullet noBullet24 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties79 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill60 = new A.SolidFill();

            A.SchemeColor schemeColor72 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint23 = new A.Tint(){ Val = 75000 };

            schemeColor72.Append(tint23);

            solidFill60.Append(schemeColor72);

            defaultRunProperties79.Append(solidFill60);

            level5ParagraphProperties8.Append(noBullet24);
            level5ParagraphProperties8.Append(defaultRunProperties79);

            A.Level6ParagraphProperties level6ParagraphProperties8 = new A.Level6ParagraphProperties(){ LeftMargin = 2286000, Indent = 0 };
            A.NoBullet noBullet25 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties80 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill61 = new A.SolidFill();

            A.SchemeColor schemeColor73 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint24 = new A.Tint(){ Val = 75000 };

            schemeColor73.Append(tint24);

            solidFill61.Append(schemeColor73);

            defaultRunProperties80.Append(solidFill61);

            level6ParagraphProperties8.Append(noBullet25);
            level6ParagraphProperties8.Append(defaultRunProperties80);

            A.Level7ParagraphProperties level7ParagraphProperties8 = new A.Level7ParagraphProperties(){ LeftMargin = 2743200, Indent = 0 };
            A.NoBullet noBullet26 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties81 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill62 = new A.SolidFill();

            A.SchemeColor schemeColor74 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint25 = new A.Tint(){ Val = 75000 };

            schemeColor74.Append(tint25);

            solidFill62.Append(schemeColor74);

            defaultRunProperties81.Append(solidFill62);

            level7ParagraphProperties8.Append(noBullet26);
            level7ParagraphProperties8.Append(defaultRunProperties81);

            A.Level8ParagraphProperties level8ParagraphProperties8 = new A.Level8ParagraphProperties(){ LeftMargin = 3200400, Indent = 0 };
            A.NoBullet noBullet27 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties82 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill63 = new A.SolidFill();

            A.SchemeColor schemeColor75 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint26 = new A.Tint(){ Val = 75000 };

            schemeColor75.Append(tint26);

            solidFill63.Append(schemeColor75);

            defaultRunProperties82.Append(solidFill63);

            level8ParagraphProperties8.Append(noBullet27);
            level8ParagraphProperties8.Append(defaultRunProperties82);

            A.Level9ParagraphProperties level9ParagraphProperties8 = new A.Level9ParagraphProperties(){ LeftMargin = 3657600, Indent = 0 };
            A.NoBullet noBullet28 = new A.NoBullet();

            A.DefaultRunProperties defaultRunProperties83 = new A.DefaultRunProperties(){ FontSize = 1400 };

            A.SolidFill solidFill64 = new A.SolidFill();

            A.SchemeColor schemeColor76 = new A.SchemeColor(){ Val = A.SchemeColorValues.Text1 };
            A.Tint tint27 = new A.Tint(){ Val = 75000 };

            schemeColor76.Append(tint27);

            solidFill64.Append(schemeColor76);

            defaultRunProperties83.Append(solidFill64);

            level9ParagraphProperties8.Append(noBullet28);
            level9ParagraphProperties8.Append(defaultRunProperties83);

            listStyle24.Append(level1ParagraphProperties17);
            listStyle24.Append(level2ParagraphProperties8);
            listStyle24.Append(level3ParagraphProperties8);
            listStyle24.Append(level4ParagraphProperties8);
            listStyle24.Append(level5ParagraphProperties8);
            listStyle24.Append(level6ParagraphProperties8);
            listStyle24.Append(level7ParagraphProperties8);
            listStyle24.Append(level8ParagraphProperties8);
            listStyle24.Append(level9ParagraphProperties8);

            A.Paragraph paragraph45 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties25 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run33 = new A.Run();

            A.RunProperties runProperties40 = new A.RunProperties(){ Language = "en-US" };
            runProperties40.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text40 = new A.Text();
            text40.Text = "Click to edit Master text styles";

            run33.Append(runProperties40);
            run33.Append(text40);

            paragraph45.Append(paragraphProperties25);
            paragraph45.Append(run33);

            textBody24.Append(bodyProperties24);
            textBody24.Append(listStyle24);
            textBody24.Append(paragraph45);

            shape24.Append(nonVisualShapeProperties24);
            shape24.Append(shapeProperties24);
            shape24.Append(textBody24);

            Shape shape25 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties25 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties31 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Date Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties25 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks24 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties25.Append(shapeLocks24);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties31 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape24 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties31.Append(placeholderShape24);

            nonVisualShapeProperties25.Append(nonVisualDrawingProperties31);
            nonVisualShapeProperties25.Append(nonVisualShapeDrawingProperties25);
            nonVisualShapeProperties25.Append(applicationNonVisualDrawingProperties31);
            ShapeProperties shapeProperties25 = new ShapeProperties();

            TextBody textBody25 = new TextBody();
            A.BodyProperties bodyProperties25 = new A.BodyProperties();
            A.ListStyle listStyle25 = new A.ListStyle();

            A.Paragraph paragraph46 = new A.Paragraph();

            A.Field field8 = new A.Field(){ Id = "{1A15D4F1-1D33-4170-8C9F-182CDE6BA6D1}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties41 = new A.RunProperties(){ Language = "en-US" };
            runProperties41.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text41 = new A.Text();
            text41.Text = "10/3/2012";

            field8.Append(runProperties41);
            field8.Append(text41);
            A.EndParagraphRunProperties endParagraphRunProperties24 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph46.Append(field8);
            paragraph46.Append(endParagraphRunProperties24);

            textBody25.Append(bodyProperties25);
            textBody25.Append(listStyle25);
            textBody25.Append(paragraph46);

            shape25.Append(nonVisualShapeProperties25);
            shape25.Append(shapeProperties25);
            shape25.Append(textBody25);

            Shape shape26 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties26 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties32 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Footer Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties26 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks25 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties26.Append(shapeLocks25);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties32 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape25 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties32.Append(placeholderShape25);

            nonVisualShapeProperties26.Append(nonVisualDrawingProperties32);
            nonVisualShapeProperties26.Append(nonVisualShapeDrawingProperties26);
            nonVisualShapeProperties26.Append(applicationNonVisualDrawingProperties32);
            ShapeProperties shapeProperties26 = new ShapeProperties();

            TextBody textBody26 = new TextBody();
            A.BodyProperties bodyProperties26 = new A.BodyProperties();
            A.ListStyle listStyle26 = new A.ListStyle();

            A.Paragraph paragraph47 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties25 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph47.Append(endParagraphRunProperties25);

            textBody26.Append(bodyProperties26);
            textBody26.Append(listStyle26);
            textBody26.Append(paragraph47);

            shape26.Append(nonVisualShapeProperties26);
            shape26.Append(shapeProperties26);
            shape26.Append(textBody26);

            Shape shape27 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties27 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties33 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Slide Number Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties27 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks26 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties27.Append(shapeLocks26);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties33 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape26 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties33.Append(placeholderShape26);

            nonVisualShapeProperties27.Append(nonVisualDrawingProperties33);
            nonVisualShapeProperties27.Append(nonVisualShapeDrawingProperties27);
            nonVisualShapeProperties27.Append(applicationNonVisualDrawingProperties33);
            ShapeProperties shapeProperties27 = new ShapeProperties();

            TextBody textBody27 = new TextBody();
            A.BodyProperties bodyProperties27 = new A.BodyProperties();
            A.ListStyle listStyle27 = new A.ListStyle();

            A.Paragraph paragraph48 = new A.Paragraph();

            A.Field field9 = new A.Field(){ Id = "{9E0C3BFA-D4DA-4895-A0F6-B80859694A8D}", Type = "slidenum" };

            A.RunProperties runProperties42 = new A.RunProperties(){ Language = "en-US" };
            runProperties42.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text42 = new A.Text();
            text42.Text = "‹#›";

            field9.Append(runProperties42);
            field9.Append(text42);
            A.EndParagraphRunProperties endParagraphRunProperties26 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph48.Append(field9);
            paragraph48.Append(endParagraphRunProperties26);

            textBody27.Append(bodyProperties27);
            textBody27.Append(listStyle27);
            textBody27.Append(paragraph48);

            shape27.Append(nonVisualShapeProperties27);
            shape27.Append(shapeProperties27);
            shape27.Append(textBody27);

            shapeTree6.Append(nonVisualGroupShapeProperties6);
            shapeTree6.Append(groupShapeProperties6);
            shapeTree6.Append(shape23);
            shapeTree6.Append(shape24);
            shapeTree6.Append(shape25);
            shapeTree6.Append(shape26);
            shapeTree6.Append(shape27);

            commonSlideData6.Append(shapeTree6);

            ColorMapOverride colorMapOverride4 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping4 = new A.MasterColorMapping();

            colorMapOverride4.Append(masterColorMapping4);

            slideLayout3.Append(commonSlideData6);
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

            CommonSlideData commonSlideData7 = new CommonSlideData(){ Name = "Blank" };

            ShapeTree shapeTree7 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties7 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties34 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties7 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties34 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties7.Append(nonVisualDrawingProperties34);
            nonVisualGroupShapeProperties7.Append(nonVisualGroupShapeDrawingProperties7);
            nonVisualGroupShapeProperties7.Append(applicationNonVisualDrawingProperties34);

            GroupShapeProperties groupShapeProperties7 = new GroupShapeProperties();

            A.TransformGroup transformGroup7 = new A.TransformGroup();
            A.Offset offset25 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents25 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset7 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents7 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup7.Append(offset25);
            transformGroup7.Append(extents25);
            transformGroup7.Append(childOffset7);
            transformGroup7.Append(childExtents7);

            groupShapeProperties7.Append(transformGroup7);

            Shape shape28 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties28 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties35 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Date Placeholder 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties28 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks27 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties28.Append(shapeLocks27);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties35 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape27 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties35.Append(placeholderShape27);

            nonVisualShapeProperties28.Append(nonVisualDrawingProperties35);
            nonVisualShapeProperties28.Append(nonVisualShapeDrawingProperties28);
            nonVisualShapeProperties28.Append(applicationNonVisualDrawingProperties35);
            ShapeProperties shapeProperties28 = new ShapeProperties();

            TextBody textBody28 = new TextBody();
            A.BodyProperties bodyProperties28 = new A.BodyProperties();
            A.ListStyle listStyle28 = new A.ListStyle();

            A.Paragraph paragraph49 = new A.Paragraph();

            A.Field field10 = new A.Field(){ Id = "{1A15D4F1-1D33-4170-8C9F-182CDE6BA6D1}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties43 = new A.RunProperties(){ Language = "en-US" };
            runProperties43.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text43 = new A.Text();
            text43.Text = "10/3/2012";

            field10.Append(runProperties43);
            field10.Append(text43);
            A.EndParagraphRunProperties endParagraphRunProperties27 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph49.Append(field10);
            paragraph49.Append(endParagraphRunProperties27);

            textBody28.Append(bodyProperties28);
            textBody28.Append(listStyle28);
            textBody28.Append(paragraph49);

            shape28.Append(nonVisualShapeProperties28);
            shape28.Append(shapeProperties28);
            shape28.Append(textBody28);

            Shape shape29 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties29 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties36 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Footer Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties29 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks28 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties29.Append(shapeLocks28);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties36 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape28 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties36.Append(placeholderShape28);

            nonVisualShapeProperties29.Append(nonVisualDrawingProperties36);
            nonVisualShapeProperties29.Append(nonVisualShapeDrawingProperties29);
            nonVisualShapeProperties29.Append(applicationNonVisualDrawingProperties36);
            ShapeProperties shapeProperties29 = new ShapeProperties();

            TextBody textBody29 = new TextBody();
            A.BodyProperties bodyProperties29 = new A.BodyProperties();
            A.ListStyle listStyle29 = new A.ListStyle();

            A.Paragraph paragraph50 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties28 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph50.Append(endParagraphRunProperties28);

            textBody29.Append(bodyProperties29);
            textBody29.Append(listStyle29);
            textBody29.Append(paragraph50);

            shape29.Append(nonVisualShapeProperties29);
            shape29.Append(shapeProperties29);
            shape29.Append(textBody29);

            Shape shape30 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties30 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties37 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Slide Number Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties30 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks29 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties30.Append(shapeLocks29);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties37 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape29 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties37.Append(placeholderShape29);

            nonVisualShapeProperties30.Append(nonVisualDrawingProperties37);
            nonVisualShapeProperties30.Append(nonVisualShapeDrawingProperties30);
            nonVisualShapeProperties30.Append(applicationNonVisualDrawingProperties37);
            ShapeProperties shapeProperties30 = new ShapeProperties();

            TextBody textBody30 = new TextBody();
            A.BodyProperties bodyProperties30 = new A.BodyProperties();
            A.ListStyle listStyle30 = new A.ListStyle();

            A.Paragraph paragraph51 = new A.Paragraph();

            A.Field field11 = new A.Field(){ Id = "{9E0C3BFA-D4DA-4895-A0F6-B80859694A8D}", Type = "slidenum" };

            A.RunProperties runProperties44 = new A.RunProperties(){ Language = "en-US" };
            runProperties44.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text44 = new A.Text();
            text44.Text = "‹#›";

            field11.Append(runProperties44);
            field11.Append(text44);
            A.EndParagraphRunProperties endParagraphRunProperties29 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph51.Append(field11);
            paragraph51.Append(endParagraphRunProperties29);

            textBody30.Append(bodyProperties30);
            textBody30.Append(listStyle30);
            textBody30.Append(paragraph51);

            shape30.Append(nonVisualShapeProperties30);
            shape30.Append(shapeProperties30);
            shape30.Append(textBody30);

            shapeTree7.Append(nonVisualGroupShapeProperties7);
            shapeTree7.Append(groupShapeProperties7);
            shapeTree7.Append(shape28);
            shapeTree7.Append(shape29);
            shapeTree7.Append(shape30);

            commonSlideData7.Append(shapeTree7);

            ColorMapOverride colorMapOverride5 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping5 = new A.MasterColorMapping();

            colorMapOverride5.Append(masterColorMapping5);

            slideLayout4.Append(commonSlideData7);
            slideLayout4.Append(colorMapOverride5);

            slideLayoutPart4.SlideLayout = slideLayout4;
        }

        // Generates content of themePart2.
        private void GenerateThemePart2Content(ThemePart themePart2)
        {
            A.Theme theme2 = new A.Theme(){ Name = "Office Theme" };
            theme2.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            A.ThemeElements themeElements2 = new A.ThemeElements();

            A.ColorScheme colorScheme2 = new A.ColorScheme(){ Name = "Office" };

            A.Dark1Color dark1Color2 = new A.Dark1Color();
            A.SystemColor systemColor3 = new A.SystemColor(){ Val = A.SystemColorValues.WindowText, LastColor = "000000" };

            dark1Color2.Append(systemColor3);

            A.Light1Color light1Color2 = new A.Light1Color();
            A.SystemColor systemColor4 = new A.SystemColor(){ Val = A.SystemColorValues.Window, LastColor = "FFFFFF" };

            light1Color2.Append(systemColor4);

            A.Dark2Color dark2Color2 = new A.Dark2Color();
            A.RgbColorModelHex rgbColorModelHex18 = new A.RgbColorModelHex(){ Val = "1F497D" };

            dark2Color2.Append(rgbColorModelHex18);

            A.Light2Color light2Color2 = new A.Light2Color();
            A.RgbColorModelHex rgbColorModelHex19 = new A.RgbColorModelHex(){ Val = "EEECE1" };

            light2Color2.Append(rgbColorModelHex19);

            A.Accent1Color accent1Color2 = new A.Accent1Color();
            A.RgbColorModelHex rgbColorModelHex20 = new A.RgbColorModelHex(){ Val = "4F81BD" };

            accent1Color2.Append(rgbColorModelHex20);

            A.Accent2Color accent2Color2 = new A.Accent2Color();
            A.RgbColorModelHex rgbColorModelHex21 = new A.RgbColorModelHex(){ Val = "C0504D" };

            accent2Color2.Append(rgbColorModelHex21);

            A.Accent3Color accent3Color2 = new A.Accent3Color();
            A.RgbColorModelHex rgbColorModelHex22 = new A.RgbColorModelHex(){ Val = "9BBB59" };

            accent3Color2.Append(rgbColorModelHex22);

            A.Accent4Color accent4Color2 = new A.Accent4Color();
            A.RgbColorModelHex rgbColorModelHex23 = new A.RgbColorModelHex(){ Val = "8064A2" };

            accent4Color2.Append(rgbColorModelHex23);

            A.Accent5Color accent5Color2 = new A.Accent5Color();
            A.RgbColorModelHex rgbColorModelHex24 = new A.RgbColorModelHex(){ Val = "4BACC6" };

            accent5Color2.Append(rgbColorModelHex24);

            A.Accent6Color accent6Color2 = new A.Accent6Color();
            A.RgbColorModelHex rgbColorModelHex25 = new A.RgbColorModelHex(){ Val = "F79646" };

            accent6Color2.Append(rgbColorModelHex25);

            A.Hyperlink hyperlink2 = new A.Hyperlink();
            A.RgbColorModelHex rgbColorModelHex26 = new A.RgbColorModelHex(){ Val = "0000FF" };

            hyperlink2.Append(rgbColorModelHex26);

            A.FollowedHyperlinkColor followedHyperlinkColor2 = new A.FollowedHyperlinkColor();
            A.RgbColorModelHex rgbColorModelHex27 = new A.RgbColorModelHex(){ Val = "800080" };

            followedHyperlinkColor2.Append(rgbColorModelHex27);

            colorScheme2.Append(dark1Color2);
            colorScheme2.Append(light1Color2);
            colorScheme2.Append(dark2Color2);
            colorScheme2.Append(light2Color2);
            colorScheme2.Append(accent1Color2);
            colorScheme2.Append(accent2Color2);
            colorScheme2.Append(accent3Color2);
            colorScheme2.Append(accent4Color2);
            colorScheme2.Append(accent5Color2);
            colorScheme2.Append(accent6Color2);
            colorScheme2.Append(hyperlink2);
            colorScheme2.Append(followedHyperlinkColor2);

            A.FontScheme fontScheme2 = new A.FontScheme(){ Name = "Office" };

            A.MajorFont majorFont2 = new A.MajorFont();
            A.LatinFont latinFont40 = new A.LatinFont(){ Typeface = "Calibri" };
            A.EastAsianFont eastAsianFont40 = new A.EastAsianFont(){ Typeface = "" };
            A.ComplexScriptFont complexScriptFont40 = new A.ComplexScriptFont(){ Typeface = "" };
            A.SupplementalFont supplementalFont59 = new A.SupplementalFont(){ Script = "Jpan", Typeface = "ＭＳ Ｐゴシック" };
            A.SupplementalFont supplementalFont60 = new A.SupplementalFont(){ Script = "Hang", Typeface = "맑은 고딕" };
            A.SupplementalFont supplementalFont61 = new A.SupplementalFont(){ Script = "Hans", Typeface = "宋体" };
            A.SupplementalFont supplementalFont62 = new A.SupplementalFont(){ Script = "Hant", Typeface = "新細明體" };
            A.SupplementalFont supplementalFont63 = new A.SupplementalFont(){ Script = "Arab", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont64 = new A.SupplementalFont(){ Script = "Hebr", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont65 = new A.SupplementalFont(){ Script = "Thai", Typeface = "Angsana New" };
            A.SupplementalFont supplementalFont66 = new A.SupplementalFont(){ Script = "Ethi", Typeface = "Nyala" };
            A.SupplementalFont supplementalFont67 = new A.SupplementalFont(){ Script = "Beng", Typeface = "Vrinda" };
            A.SupplementalFont supplementalFont68 = new A.SupplementalFont(){ Script = "Gujr", Typeface = "Shruti" };
            A.SupplementalFont supplementalFont69 = new A.SupplementalFont(){ Script = "Khmr", Typeface = "MoolBoran" };
            A.SupplementalFont supplementalFont70 = new A.SupplementalFont(){ Script = "Knda", Typeface = "Tunga" };
            A.SupplementalFont supplementalFont71 = new A.SupplementalFont(){ Script = "Guru", Typeface = "Raavi" };
            A.SupplementalFont supplementalFont72 = new A.SupplementalFont(){ Script = "Cans", Typeface = "Euphemia" };
            A.SupplementalFont supplementalFont73 = new A.SupplementalFont(){ Script = "Cher", Typeface = "Plantagenet Cherokee" };
            A.SupplementalFont supplementalFont74 = new A.SupplementalFont(){ Script = "Yiii", Typeface = "Microsoft Yi Baiti" };
            A.SupplementalFont supplementalFont75 = new A.SupplementalFont(){ Script = "Tibt", Typeface = "Microsoft Himalaya" };
            A.SupplementalFont supplementalFont76 = new A.SupplementalFont(){ Script = "Thaa", Typeface = "MV Boli" };
            A.SupplementalFont supplementalFont77 = new A.SupplementalFont(){ Script = "Deva", Typeface = "Mangal" };
            A.SupplementalFont supplementalFont78 = new A.SupplementalFont(){ Script = "Telu", Typeface = "Gautami" };
            A.SupplementalFont supplementalFont79 = new A.SupplementalFont(){ Script = "Taml", Typeface = "Latha" };
            A.SupplementalFont supplementalFont80 = new A.SupplementalFont(){ Script = "Syrc", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont81 = new A.SupplementalFont(){ Script = "Orya", Typeface = "Kalinga" };
            A.SupplementalFont supplementalFont82 = new A.SupplementalFont(){ Script = "Mlym", Typeface = "Kartika" };
            A.SupplementalFont supplementalFont83 = new A.SupplementalFont(){ Script = "Laoo", Typeface = "DokChampa" };
            A.SupplementalFont supplementalFont84 = new A.SupplementalFont(){ Script = "Sinh", Typeface = "Iskoola Pota" };
            A.SupplementalFont supplementalFont85 = new A.SupplementalFont(){ Script = "Mong", Typeface = "Mongolian Baiti" };
            A.SupplementalFont supplementalFont86 = new A.SupplementalFont(){ Script = "Viet", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont87 = new A.SupplementalFont(){ Script = "Uigh", Typeface = "Microsoft Uighur" };

            majorFont2.Append(latinFont40);
            majorFont2.Append(eastAsianFont40);
            majorFont2.Append(complexScriptFont40);
            majorFont2.Append(supplementalFont59);
            majorFont2.Append(supplementalFont60);
            majorFont2.Append(supplementalFont61);
            majorFont2.Append(supplementalFont62);
            majorFont2.Append(supplementalFont63);
            majorFont2.Append(supplementalFont64);
            majorFont2.Append(supplementalFont65);
            majorFont2.Append(supplementalFont66);
            majorFont2.Append(supplementalFont67);
            majorFont2.Append(supplementalFont68);
            majorFont2.Append(supplementalFont69);
            majorFont2.Append(supplementalFont70);
            majorFont2.Append(supplementalFont71);
            majorFont2.Append(supplementalFont72);
            majorFont2.Append(supplementalFont73);
            majorFont2.Append(supplementalFont74);
            majorFont2.Append(supplementalFont75);
            majorFont2.Append(supplementalFont76);
            majorFont2.Append(supplementalFont77);
            majorFont2.Append(supplementalFont78);
            majorFont2.Append(supplementalFont79);
            majorFont2.Append(supplementalFont80);
            majorFont2.Append(supplementalFont81);
            majorFont2.Append(supplementalFont82);
            majorFont2.Append(supplementalFont83);
            majorFont2.Append(supplementalFont84);
            majorFont2.Append(supplementalFont85);
            majorFont2.Append(supplementalFont86);
            majorFont2.Append(supplementalFont87);

            A.MinorFont minorFont2 = new A.MinorFont();
            A.LatinFont latinFont41 = new A.LatinFont(){ Typeface = "Calibri" };
            A.EastAsianFont eastAsianFont41 = new A.EastAsianFont(){ Typeface = "" };
            A.ComplexScriptFont complexScriptFont41 = new A.ComplexScriptFont(){ Typeface = "" };
            A.SupplementalFont supplementalFont88 = new A.SupplementalFont(){ Script = "Jpan", Typeface = "ＭＳ Ｐゴシック" };
            A.SupplementalFont supplementalFont89 = new A.SupplementalFont(){ Script = "Hang", Typeface = "맑은 고딕" };
            A.SupplementalFont supplementalFont90 = new A.SupplementalFont(){ Script = "Hans", Typeface = "宋体" };
            A.SupplementalFont supplementalFont91 = new A.SupplementalFont(){ Script = "Hant", Typeface = "新細明體" };
            A.SupplementalFont supplementalFont92 = new A.SupplementalFont(){ Script = "Arab", Typeface = "Arial" };
            A.SupplementalFont supplementalFont93 = new A.SupplementalFont(){ Script = "Hebr", Typeface = "Arial" };
            A.SupplementalFont supplementalFont94 = new A.SupplementalFont(){ Script = "Thai", Typeface = "Cordia New" };
            A.SupplementalFont supplementalFont95 = new A.SupplementalFont(){ Script = "Ethi", Typeface = "Nyala" };
            A.SupplementalFont supplementalFont96 = new A.SupplementalFont(){ Script = "Beng", Typeface = "Vrinda" };
            A.SupplementalFont supplementalFont97 = new A.SupplementalFont(){ Script = "Gujr", Typeface = "Shruti" };
            A.SupplementalFont supplementalFont98 = new A.SupplementalFont(){ Script = "Khmr", Typeface = "DaunPenh" };
            A.SupplementalFont supplementalFont99 = new A.SupplementalFont(){ Script = "Knda", Typeface = "Tunga" };
            A.SupplementalFont supplementalFont100 = new A.SupplementalFont(){ Script = "Guru", Typeface = "Raavi" };
            A.SupplementalFont supplementalFont101 = new A.SupplementalFont(){ Script = "Cans", Typeface = "Euphemia" };
            A.SupplementalFont supplementalFont102 = new A.SupplementalFont(){ Script = "Cher", Typeface = "Plantagenet Cherokee" };
            A.SupplementalFont supplementalFont103 = new A.SupplementalFont(){ Script = "Yiii", Typeface = "Microsoft Yi Baiti" };
            A.SupplementalFont supplementalFont104 = new A.SupplementalFont(){ Script = "Tibt", Typeface = "Microsoft Himalaya" };
            A.SupplementalFont supplementalFont105 = new A.SupplementalFont(){ Script = "Thaa", Typeface = "MV Boli" };
            A.SupplementalFont supplementalFont106 = new A.SupplementalFont(){ Script = "Deva", Typeface = "Mangal" };
            A.SupplementalFont supplementalFont107 = new A.SupplementalFont(){ Script = "Telu", Typeface = "Gautami" };
            A.SupplementalFont supplementalFont108 = new A.SupplementalFont(){ Script = "Taml", Typeface = "Latha" };
            A.SupplementalFont supplementalFont109 = new A.SupplementalFont(){ Script = "Syrc", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont110 = new A.SupplementalFont(){ Script = "Orya", Typeface = "Kalinga" };
            A.SupplementalFont supplementalFont111 = new A.SupplementalFont(){ Script = "Mlym", Typeface = "Kartika" };
            A.SupplementalFont supplementalFont112 = new A.SupplementalFont(){ Script = "Laoo", Typeface = "DokChampa" };
            A.SupplementalFont supplementalFont113 = new A.SupplementalFont(){ Script = "Sinh", Typeface = "Iskoola Pota" };
            A.SupplementalFont supplementalFont114 = new A.SupplementalFont(){ Script = "Mong", Typeface = "Mongolian Baiti" };
            A.SupplementalFont supplementalFont115 = new A.SupplementalFont(){ Script = "Viet", Typeface = "Arial" };
            A.SupplementalFont supplementalFont116 = new A.SupplementalFont(){ Script = "Uigh", Typeface = "Microsoft Uighur" };

            minorFont2.Append(latinFont41);
            minorFont2.Append(eastAsianFont41);
            minorFont2.Append(complexScriptFont41);
            minorFont2.Append(supplementalFont88);
            minorFont2.Append(supplementalFont89);
            minorFont2.Append(supplementalFont90);
            minorFont2.Append(supplementalFont91);
            minorFont2.Append(supplementalFont92);
            minorFont2.Append(supplementalFont93);
            minorFont2.Append(supplementalFont94);
            minorFont2.Append(supplementalFont95);
            minorFont2.Append(supplementalFont96);
            minorFont2.Append(supplementalFont97);
            minorFont2.Append(supplementalFont98);
            minorFont2.Append(supplementalFont99);
            minorFont2.Append(supplementalFont100);
            minorFont2.Append(supplementalFont101);
            minorFont2.Append(supplementalFont102);
            minorFont2.Append(supplementalFont103);
            minorFont2.Append(supplementalFont104);
            minorFont2.Append(supplementalFont105);
            minorFont2.Append(supplementalFont106);
            minorFont2.Append(supplementalFont107);
            minorFont2.Append(supplementalFont108);
            minorFont2.Append(supplementalFont109);
            minorFont2.Append(supplementalFont110);
            minorFont2.Append(supplementalFont111);
            minorFont2.Append(supplementalFont112);
            minorFont2.Append(supplementalFont113);
            minorFont2.Append(supplementalFont114);
            minorFont2.Append(supplementalFont115);
            minorFont2.Append(supplementalFont116);

            fontScheme2.Append(majorFont2);
            fontScheme2.Append(minorFont2);

            A.FormatScheme formatScheme2 = new A.FormatScheme(){ Name = "Office" };

            A.FillStyleList fillStyleList2 = new A.FillStyleList();

            A.SolidFill solidFill65 = new A.SolidFill();
            A.SchemeColor schemeColor77 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill65.Append(schemeColor77);

            A.GradientFill gradientFill5 = new A.GradientFill(){ RotateWithShape = true };

            A.GradientStopList gradientStopList5 = new A.GradientStopList();

            A.GradientStop gradientStop12 = new A.GradientStop(){ Position = 0 };

            A.SchemeColor schemeColor78 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint28 = new A.Tint(){ Val = 50000 };
            A.SaturationModulation saturationModulation13 = new A.SaturationModulation(){ Val = 300000 };

            schemeColor78.Append(tint28);
            schemeColor78.Append(saturationModulation13);

            gradientStop12.Append(schemeColor78);

            A.GradientStop gradientStop13 = new A.GradientStop(){ Position = 35000 };

            A.SchemeColor schemeColor79 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint29 = new A.Tint(){ Val = 37000 };
            A.SaturationModulation saturationModulation14 = new A.SaturationModulation(){ Val = 300000 };

            schemeColor79.Append(tint29);
            schemeColor79.Append(saturationModulation14);

            gradientStop13.Append(schemeColor79);

            A.GradientStop gradientStop14 = new A.GradientStop(){ Position = 100000 };

            A.SchemeColor schemeColor80 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint30 = new A.Tint(){ Val = 15000 };
            A.SaturationModulation saturationModulation15 = new A.SaturationModulation(){ Val = 350000 };

            schemeColor80.Append(tint30);
            schemeColor80.Append(saturationModulation15);

            gradientStop14.Append(schemeColor80);

            gradientStopList5.Append(gradientStop12);
            gradientStopList5.Append(gradientStop13);
            gradientStopList5.Append(gradientStop14);
            A.LinearGradientFill linearGradientFill3 = new A.LinearGradientFill(){ Angle = 16200000, Scaled = true };

            gradientFill5.Append(gradientStopList5);
            gradientFill5.Append(linearGradientFill3);

            A.GradientFill gradientFill6 = new A.GradientFill(){ RotateWithShape = true };

            A.GradientStopList gradientStopList6 = new A.GradientStopList();

            A.GradientStop gradientStop15 = new A.GradientStop(){ Position = 0 };

            A.SchemeColor schemeColor81 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Shade shade8 = new A.Shade(){ Val = 51000 };
            A.SaturationModulation saturationModulation16 = new A.SaturationModulation(){ Val = 130000 };

            schemeColor81.Append(shade8);
            schemeColor81.Append(saturationModulation16);

            gradientStop15.Append(schemeColor81);

            A.GradientStop gradientStop16 = new A.GradientStop(){ Position = 80000 };

            A.SchemeColor schemeColor82 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Shade shade9 = new A.Shade(){ Val = 93000 };
            A.SaturationModulation saturationModulation17 = new A.SaturationModulation(){ Val = 130000 };

            schemeColor82.Append(shade9);
            schemeColor82.Append(saturationModulation17);

            gradientStop16.Append(schemeColor82);

            A.GradientStop gradientStop17 = new A.GradientStop(){ Position = 100000 };

            A.SchemeColor schemeColor83 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Shade shade10 = new A.Shade(){ Val = 94000 };
            A.SaturationModulation saturationModulation18 = new A.SaturationModulation(){ Val = 135000 };

            schemeColor83.Append(shade10);
            schemeColor83.Append(saturationModulation18);

            gradientStop17.Append(schemeColor83);

            gradientStopList6.Append(gradientStop15);
            gradientStopList6.Append(gradientStop16);
            gradientStopList6.Append(gradientStop17);
            A.LinearGradientFill linearGradientFill4 = new A.LinearGradientFill(){ Angle = 16200000, Scaled = false };

            gradientFill6.Append(gradientStopList6);
            gradientFill6.Append(linearGradientFill4);

            fillStyleList2.Append(solidFill65);
            fillStyleList2.Append(gradientFill5);
            fillStyleList2.Append(gradientFill6);

            A.LineStyleList lineStyleList2 = new A.LineStyleList();

            A.Outline outline5 = new A.Outline(){ Width = 9525, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill66 = new A.SolidFill();

            A.SchemeColor schemeColor84 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Shade shade11 = new A.Shade(){ Val = 95000 };
            A.SaturationModulation saturationModulation19 = new A.SaturationModulation(){ Val = 105000 };

            schemeColor84.Append(shade11);
            schemeColor84.Append(saturationModulation19);

            solidFill66.Append(schemeColor84);
            A.PresetDash presetDash4 = new A.PresetDash(){ Val = A.PresetLineDashValues.Solid };

            outline5.Append(solidFill66);
            outline5.Append(presetDash4);

            A.Outline outline6 = new A.Outline(){ Width = 25400, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill67 = new A.SolidFill();
            A.SchemeColor schemeColor85 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill67.Append(schemeColor85);
            A.PresetDash presetDash5 = new A.PresetDash(){ Val = A.PresetLineDashValues.Solid };

            outline6.Append(solidFill67);
            outline6.Append(presetDash5);

            A.Outline outline7 = new A.Outline(){ Width = 38100, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill68 = new A.SolidFill();
            A.SchemeColor schemeColor86 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill68.Append(schemeColor86);
            A.PresetDash presetDash6 = new A.PresetDash(){ Val = A.PresetLineDashValues.Solid };

            outline7.Append(solidFill68);
            outline7.Append(presetDash6);

            lineStyleList2.Append(outline5);
            lineStyleList2.Append(outline6);
            lineStyleList2.Append(outline7);

            A.EffectStyleList effectStyleList2 = new A.EffectStyleList();

            A.EffectStyle effectStyle4 = new A.EffectStyle();

            A.EffectList effectList4 = new A.EffectList();

            A.OuterShadow outerShadow4 = new A.OuterShadow(){ BlurRadius = 40000L, Distance = 20000L, Direction = 5400000, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex28 = new A.RgbColorModelHex(){ Val = "000000" };
            A.Alpha alpha4 = new A.Alpha(){ Val = 38000 };

            rgbColorModelHex28.Append(alpha4);

            outerShadow4.Append(rgbColorModelHex28);

            effectList4.Append(outerShadow4);

            effectStyle4.Append(effectList4);

            A.EffectStyle effectStyle5 = new A.EffectStyle();

            A.EffectList effectList5 = new A.EffectList();

            A.OuterShadow outerShadow5 = new A.OuterShadow(){ BlurRadius = 40000L, Distance = 23000L, Direction = 5400000, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex29 = new A.RgbColorModelHex(){ Val = "000000" };
            A.Alpha alpha5 = new A.Alpha(){ Val = 35000 };

            rgbColorModelHex29.Append(alpha5);

            outerShadow5.Append(rgbColorModelHex29);

            effectList5.Append(outerShadow5);

            effectStyle5.Append(effectList5);

            A.EffectStyle effectStyle6 = new A.EffectStyle();

            A.EffectList effectList6 = new A.EffectList();

            A.OuterShadow outerShadow6 = new A.OuterShadow(){ BlurRadius = 40000L, Distance = 23000L, Direction = 5400000, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex30 = new A.RgbColorModelHex(){ Val = "000000" };
            A.Alpha alpha6 = new A.Alpha(){ Val = 35000 };

            rgbColorModelHex30.Append(alpha6);

            outerShadow6.Append(rgbColorModelHex30);

            effectList6.Append(outerShadow6);

            A.Scene3DType scene3DType2 = new A.Scene3DType();

            A.Camera camera2 = new A.Camera(){ Preset = A.PresetCameraValues.OrthographicFront };
            A.Rotation rotation3 = new A.Rotation(){ Latitude = 0, Longitude = 0, Revolution = 0 };

            camera2.Append(rotation3);

            A.LightRig lightRig2 = new A.LightRig(){ Rig = A.LightRigValues.ThreePoints, Direction = A.LightRigDirectionValues.Top };
            A.Rotation rotation4 = new A.Rotation(){ Latitude = 0, Longitude = 0, Revolution = 1200000 };

            lightRig2.Append(rotation4);

            scene3DType2.Append(camera2);
            scene3DType2.Append(lightRig2);

            A.Shape3DType shape3DType2 = new A.Shape3DType();
            A.BevelTop bevelTop2 = new A.BevelTop(){ Width = 63500L, Height = 25400L };

            shape3DType2.Append(bevelTop2);

            effectStyle6.Append(effectList6);
            effectStyle6.Append(scene3DType2);
            effectStyle6.Append(shape3DType2);

            effectStyleList2.Append(effectStyle4);
            effectStyleList2.Append(effectStyle5);
            effectStyleList2.Append(effectStyle6);

            A.BackgroundFillStyleList backgroundFillStyleList2 = new A.BackgroundFillStyleList();

            A.SolidFill solidFill69 = new A.SolidFill();
            A.SchemeColor schemeColor87 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };

            solidFill69.Append(schemeColor87);

            A.GradientFill gradientFill7 = new A.GradientFill(){ RotateWithShape = true };

            A.GradientStopList gradientStopList7 = new A.GradientStopList();

            A.GradientStop gradientStop18 = new A.GradientStop(){ Position = 0 };

            A.SchemeColor schemeColor88 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint31 = new A.Tint(){ Val = 40000 };
            A.SaturationModulation saturationModulation20 = new A.SaturationModulation(){ Val = 350000 };

            schemeColor88.Append(tint31);
            schemeColor88.Append(saturationModulation20);

            gradientStop18.Append(schemeColor88);

            A.GradientStop gradientStop19 = new A.GradientStop(){ Position = 40000 };

            A.SchemeColor schemeColor89 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint32 = new A.Tint(){ Val = 45000 };
            A.Shade shade12 = new A.Shade(){ Val = 99000 };
            A.SaturationModulation saturationModulation21 = new A.SaturationModulation(){ Val = 350000 };

            schemeColor89.Append(tint32);
            schemeColor89.Append(shade12);
            schemeColor89.Append(saturationModulation21);

            gradientStop19.Append(schemeColor89);

            A.GradientStop gradientStop20 = new A.GradientStop(){ Position = 100000 };

            A.SchemeColor schemeColor90 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Shade shade13 = new A.Shade(){ Val = 20000 };
            A.SaturationModulation saturationModulation22 = new A.SaturationModulation(){ Val = 255000 };

            schemeColor90.Append(shade13);
            schemeColor90.Append(saturationModulation22);

            gradientStop20.Append(schemeColor90);

            gradientStopList7.Append(gradientStop18);
            gradientStopList7.Append(gradientStop19);
            gradientStopList7.Append(gradientStop20);

            A.PathGradientFill pathGradientFill3 = new A.PathGradientFill(){ Path = A.PathShadeValues.Circle };
            A.FillToRectangle fillToRectangle3 = new A.FillToRectangle(){ Left = 50000, Top = -80000, Right = 50000, Bottom = 180000 };

            pathGradientFill3.Append(fillToRectangle3);

            gradientFill7.Append(gradientStopList7);
            gradientFill7.Append(pathGradientFill3);

            A.GradientFill gradientFill8 = new A.GradientFill(){ RotateWithShape = true };

            A.GradientStopList gradientStopList8 = new A.GradientStopList();

            A.GradientStop gradientStop21 = new A.GradientStop(){ Position = 0 };

            A.SchemeColor schemeColor91 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Tint tint33 = new A.Tint(){ Val = 80000 };
            A.SaturationModulation saturationModulation23 = new A.SaturationModulation(){ Val = 300000 };

            schemeColor91.Append(tint33);
            schemeColor91.Append(saturationModulation23);

            gradientStop21.Append(schemeColor91);

            A.GradientStop gradientStop22 = new A.GradientStop(){ Position = 100000 };

            A.SchemeColor schemeColor92 = new A.SchemeColor(){ Val = A.SchemeColorValues.PhColor };
            A.Shade shade14 = new A.Shade(){ Val = 30000 };
            A.SaturationModulation saturationModulation24 = new A.SaturationModulation(){ Val = 200000 };

            schemeColor92.Append(shade14);
            schemeColor92.Append(saturationModulation24);

            gradientStop22.Append(schemeColor92);

            gradientStopList8.Append(gradientStop21);
            gradientStopList8.Append(gradientStop22);

            A.PathGradientFill pathGradientFill4 = new A.PathGradientFill(){ Path = A.PathShadeValues.Circle };
            A.FillToRectangle fillToRectangle4 = new A.FillToRectangle(){ Left = 50000, Top = 50000, Right = 50000, Bottom = 50000 };

            pathGradientFill4.Append(fillToRectangle4);

            gradientFill8.Append(gradientStopList8);
            gradientFill8.Append(pathGradientFill4);

            backgroundFillStyleList2.Append(solidFill69);
            backgroundFillStyleList2.Append(gradientFill7);
            backgroundFillStyleList2.Append(gradientFill8);

            formatScheme2.Append(fillStyleList2);
            formatScheme2.Append(lineStyleList2);
            formatScheme2.Append(effectStyleList2);
            formatScheme2.Append(backgroundFillStyleList2);

            themeElements2.Append(colorScheme2);
            themeElements2.Append(fontScheme2);
            themeElements2.Append(formatScheme2);
            A.ObjectDefaults objectDefaults2 = new A.ObjectDefaults();
            A.ExtraColorSchemeList extraColorSchemeList2 = new A.ExtraColorSchemeList();

            theme2.Append(themeElements2);
            theme2.Append(objectDefaults2);
            theme2.Append(extraColorSchemeList2);

            themePart2.Theme = theme2;
        }

        // Generates content of slideLayoutPart5.
        private void GenerateSlideLayoutPart5Content(SlideLayoutPart slideLayoutPart5)
        {
            SlideLayout slideLayout5 = new SlideLayout(){ Type = SlideLayoutValues.Object, Preserve = true };
            slideLayout5.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout5.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout5.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData8 = new CommonSlideData(){ Name = "Title and Content" };

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
            A.Offset offset26 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents26 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset8 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents8 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup8.Append(offset26);
            transformGroup8.Append(extents26);
            transformGroup8.Append(childOffset8);
            transformGroup8.Append(childExtents8);

            groupShapeProperties8.Append(transformGroup8);

            Shape shape31 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties31 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties39 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties31 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks30 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties31.Append(shapeLocks30);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties39 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape30 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties39.Append(placeholderShape30);

            nonVisualShapeProperties31.Append(nonVisualDrawingProperties39);
            nonVisualShapeProperties31.Append(nonVisualShapeDrawingProperties31);
            nonVisualShapeProperties31.Append(applicationNonVisualDrawingProperties39);
            ShapeProperties shapeProperties31 = new ShapeProperties();

            TextBody textBody31 = new TextBody();
            A.BodyProperties bodyProperties31 = new A.BodyProperties();
            A.ListStyle listStyle31 = new A.ListStyle();

            A.Paragraph paragraph52 = new A.Paragraph();

            A.Run run34 = new A.Run();

            A.RunProperties runProperties45 = new A.RunProperties(){ Language = "en-US" };
            runProperties45.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text45 = new A.Text();
            text45.Text = "Click to edit Master title style";

            run34.Append(runProperties45);
            run34.Append(text45);
            A.EndParagraphRunProperties endParagraphRunProperties30 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph52.Append(run34);
            paragraph52.Append(endParagraphRunProperties30);

            textBody31.Append(bodyProperties31);
            textBody31.Append(listStyle31);
            textBody31.Append(paragraph52);

            shape31.Append(nonVisualShapeProperties31);
            shape31.Append(shapeProperties31);
            shape31.Append(textBody31);

            Shape shape32 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties32 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties40 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Content Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties32 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks31 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties32.Append(shapeLocks31);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties40 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape31 = new PlaceholderShape(){ Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties40.Append(placeholderShape31);

            nonVisualShapeProperties32.Append(nonVisualDrawingProperties40);
            nonVisualShapeProperties32.Append(nonVisualShapeDrawingProperties32);
            nonVisualShapeProperties32.Append(applicationNonVisualDrawingProperties40);
            ShapeProperties shapeProperties32 = new ShapeProperties();

            TextBody textBody32 = new TextBody();
            A.BodyProperties bodyProperties32 = new A.BodyProperties();
            A.ListStyle listStyle32 = new A.ListStyle();

            A.Paragraph paragraph53 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties26 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run35 = new A.Run();

            A.RunProperties runProperties46 = new A.RunProperties(){ Language = "en-US" };
            runProperties46.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text46 = new A.Text();
            text46.Text = "Click to edit Master text styles";

            run35.Append(runProperties46);
            run35.Append(text46);

            paragraph53.Append(paragraphProperties26);
            paragraph53.Append(run35);

            A.Paragraph paragraph54 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties27 = new A.ParagraphProperties(){ Level = 1 };

            A.Run run36 = new A.Run();

            A.RunProperties runProperties47 = new A.RunProperties(){ Language = "en-US" };
            runProperties47.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text47 = new A.Text();
            text47.Text = "Second level";

            run36.Append(runProperties47);
            run36.Append(text47);

            paragraph54.Append(paragraphProperties27);
            paragraph54.Append(run36);

            A.Paragraph paragraph55 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties28 = new A.ParagraphProperties(){ Level = 2 };

            A.Run run37 = new A.Run();

            A.RunProperties runProperties48 = new A.RunProperties(){ Language = "en-US" };
            runProperties48.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text48 = new A.Text();
            text48.Text = "Third level";

            run37.Append(runProperties48);
            run37.Append(text48);

            paragraph55.Append(paragraphProperties28);
            paragraph55.Append(run37);

            A.Paragraph paragraph56 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties29 = new A.ParagraphProperties(){ Level = 3 };

            A.Run run38 = new A.Run();

            A.RunProperties runProperties49 = new A.RunProperties(){ Language = "en-US" };
            runProperties49.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text49 = new A.Text();
            text49.Text = "Fourth level";

            run38.Append(runProperties49);
            run38.Append(text49);

            paragraph56.Append(paragraphProperties29);
            paragraph56.Append(run38);

            A.Paragraph paragraph57 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties30 = new A.ParagraphProperties(){ Level = 4 };

            A.Run run39 = new A.Run();

            A.RunProperties runProperties50 = new A.RunProperties(){ Language = "en-US" };
            runProperties50.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text50 = new A.Text();
            text50.Text = "Fifth level";

            run39.Append(runProperties50);
            run39.Append(text50);
            A.EndParagraphRunProperties endParagraphRunProperties31 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph57.Append(paragraphProperties30);
            paragraph57.Append(run39);
            paragraph57.Append(endParagraphRunProperties31);

            textBody32.Append(bodyProperties32);
            textBody32.Append(listStyle32);
            textBody32.Append(paragraph53);
            textBody32.Append(paragraph54);
            textBody32.Append(paragraph55);
            textBody32.Append(paragraph56);
            textBody32.Append(paragraph57);

            shape32.Append(nonVisualShapeProperties32);
            shape32.Append(shapeProperties32);
            shape32.Append(textBody32);

            Shape shape33 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties33 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties41 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Date Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties33 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks32 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties33.Append(shapeLocks32);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties41 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape32 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties41.Append(placeholderShape32);

            nonVisualShapeProperties33.Append(nonVisualDrawingProperties41);
            nonVisualShapeProperties33.Append(nonVisualShapeDrawingProperties33);
            nonVisualShapeProperties33.Append(applicationNonVisualDrawingProperties41);
            ShapeProperties shapeProperties33 = new ShapeProperties();

            TextBody textBody33 = new TextBody();
            A.BodyProperties bodyProperties33 = new A.BodyProperties();
            A.ListStyle listStyle33 = new A.ListStyle();

            A.Paragraph paragraph58 = new A.Paragraph();

            A.Field field12 = new A.Field(){ Id = "{1A15D4F1-1D33-4170-8C9F-182CDE6BA6D1}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties51 = new A.RunProperties(){ Language = "en-US" };
            runProperties51.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text51 = new A.Text();
            text51.Text = "10/3/2012";

            field12.Append(runProperties51);
            field12.Append(text51);
            A.EndParagraphRunProperties endParagraphRunProperties32 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph58.Append(field12);
            paragraph58.Append(endParagraphRunProperties32);

            textBody33.Append(bodyProperties33);
            textBody33.Append(listStyle33);
            textBody33.Append(paragraph58);

            shape33.Append(nonVisualShapeProperties33);
            shape33.Append(shapeProperties33);
            shape33.Append(textBody33);

            Shape shape34 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties34 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties42 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Footer Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties34 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks33 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties34.Append(shapeLocks33);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties42 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape33 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties42.Append(placeholderShape33);

            nonVisualShapeProperties34.Append(nonVisualDrawingProperties42);
            nonVisualShapeProperties34.Append(nonVisualShapeDrawingProperties34);
            nonVisualShapeProperties34.Append(applicationNonVisualDrawingProperties42);
            ShapeProperties shapeProperties34 = new ShapeProperties();

            TextBody textBody34 = new TextBody();
            A.BodyProperties bodyProperties34 = new A.BodyProperties();
            A.ListStyle listStyle34 = new A.ListStyle();

            A.Paragraph paragraph59 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties33 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph59.Append(endParagraphRunProperties33);

            textBody34.Append(bodyProperties34);
            textBody34.Append(listStyle34);
            textBody34.Append(paragraph59);

            shape34.Append(nonVisualShapeProperties34);
            shape34.Append(shapeProperties34);
            shape34.Append(textBody34);

            Shape shape35 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties35 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties43 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Slide Number Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties35 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks34 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties35.Append(shapeLocks34);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties43 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape34 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties43.Append(placeholderShape34);

            nonVisualShapeProperties35.Append(nonVisualDrawingProperties43);
            nonVisualShapeProperties35.Append(nonVisualShapeDrawingProperties35);
            nonVisualShapeProperties35.Append(applicationNonVisualDrawingProperties43);
            ShapeProperties shapeProperties35 = new ShapeProperties();

            TextBody textBody35 = new TextBody();
            A.BodyProperties bodyProperties35 = new A.BodyProperties();
            A.ListStyle listStyle35 = new A.ListStyle();

            A.Paragraph paragraph60 = new A.Paragraph();

            A.Field field13 = new A.Field(){ Id = "{9E0C3BFA-D4DA-4895-A0F6-B80859694A8D}", Type = "slidenum" };

            A.RunProperties runProperties52 = new A.RunProperties(){ Language = "en-US" };
            runProperties52.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text52 = new A.Text();
            text52.Text = "‹#›";

            field13.Append(runProperties52);
            field13.Append(text52);
            A.EndParagraphRunProperties endParagraphRunProperties34 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph60.Append(field13);
            paragraph60.Append(endParagraphRunProperties34);

            textBody35.Append(bodyProperties35);
            textBody35.Append(listStyle35);
            textBody35.Append(paragraph60);

            shape35.Append(nonVisualShapeProperties35);
            shape35.Append(shapeProperties35);
            shape35.Append(textBody35);

            shapeTree8.Append(nonVisualGroupShapeProperties8);
            shapeTree8.Append(groupShapeProperties8);
            shapeTree8.Append(shape31);
            shapeTree8.Append(shape32);
            shapeTree8.Append(shape33);
            shapeTree8.Append(shape34);
            shapeTree8.Append(shape35);

            commonSlideData8.Append(shapeTree8);

            ColorMapOverride colorMapOverride6 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping6 = new A.MasterColorMapping();

            colorMapOverride6.Append(masterColorMapping6);

            slideLayout5.Append(commonSlideData8);
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

            CommonSlideData commonSlideData9 = new CommonSlideData(){ Name = "Title Only" };

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
            A.Offset offset27 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents27 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset9 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents9 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup9.Append(offset27);
            transformGroup9.Append(extents27);
            transformGroup9.Append(childOffset9);
            transformGroup9.Append(childExtents9);

            groupShapeProperties9.Append(transformGroup9);

            Shape shape36 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties36 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties45 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties36 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks35 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties36.Append(shapeLocks35);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties45 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape35 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties45.Append(placeholderShape35);

            nonVisualShapeProperties36.Append(nonVisualDrawingProperties45);
            nonVisualShapeProperties36.Append(nonVisualShapeDrawingProperties36);
            nonVisualShapeProperties36.Append(applicationNonVisualDrawingProperties45);
            ShapeProperties shapeProperties36 = new ShapeProperties();

            TextBody textBody36 = new TextBody();
            A.BodyProperties bodyProperties36 = new A.BodyProperties();
            A.ListStyle listStyle36 = new A.ListStyle();

            A.Paragraph paragraph61 = new A.Paragraph();

            A.Run run40 = new A.Run();

            A.RunProperties runProperties53 = new A.RunProperties(){ Language = "en-US" };
            runProperties53.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text53 = new A.Text();
            text53.Text = "Click to edit Master title style";

            run40.Append(runProperties53);
            run40.Append(text53);
            A.EndParagraphRunProperties endParagraphRunProperties35 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph61.Append(run40);
            paragraph61.Append(endParagraphRunProperties35);

            textBody36.Append(bodyProperties36);
            textBody36.Append(listStyle36);
            textBody36.Append(paragraph61);

            shape36.Append(nonVisualShapeProperties36);
            shape36.Append(shapeProperties36);
            shape36.Append(textBody36);

            Shape shape37 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties37 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties46 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Date Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties37 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks36 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties37.Append(shapeLocks36);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties46 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape36 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties46.Append(placeholderShape36);

            nonVisualShapeProperties37.Append(nonVisualDrawingProperties46);
            nonVisualShapeProperties37.Append(nonVisualShapeDrawingProperties37);
            nonVisualShapeProperties37.Append(applicationNonVisualDrawingProperties46);
            ShapeProperties shapeProperties37 = new ShapeProperties();

            TextBody textBody37 = new TextBody();
            A.BodyProperties bodyProperties37 = new A.BodyProperties();
            A.ListStyle listStyle37 = new A.ListStyle();

            A.Paragraph paragraph62 = new A.Paragraph();

            A.Field field14 = new A.Field(){ Id = "{1A15D4F1-1D33-4170-8C9F-182CDE6BA6D1}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties54 = new A.RunProperties(){ Language = "en-US" };
            runProperties54.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text54 = new A.Text();
            text54.Text = "10/3/2012";

            field14.Append(runProperties54);
            field14.Append(text54);
            A.EndParagraphRunProperties endParagraphRunProperties36 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph62.Append(field14);
            paragraph62.Append(endParagraphRunProperties36);

            textBody37.Append(bodyProperties37);
            textBody37.Append(listStyle37);
            textBody37.Append(paragraph62);

            shape37.Append(nonVisualShapeProperties37);
            shape37.Append(shapeProperties37);
            shape37.Append(textBody37);

            Shape shape38 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties38 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties47 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Footer Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties38 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks37 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties38.Append(shapeLocks37);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties47 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape37 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties47.Append(placeholderShape37);

            nonVisualShapeProperties38.Append(nonVisualDrawingProperties47);
            nonVisualShapeProperties38.Append(nonVisualShapeDrawingProperties38);
            nonVisualShapeProperties38.Append(applicationNonVisualDrawingProperties47);
            ShapeProperties shapeProperties38 = new ShapeProperties();

            TextBody textBody38 = new TextBody();
            A.BodyProperties bodyProperties38 = new A.BodyProperties();
            A.ListStyle listStyle38 = new A.ListStyle();

            A.Paragraph paragraph63 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties37 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph63.Append(endParagraphRunProperties37);

            textBody38.Append(bodyProperties38);
            textBody38.Append(listStyle38);
            textBody38.Append(paragraph63);

            shape38.Append(nonVisualShapeProperties38);
            shape38.Append(shapeProperties38);
            shape38.Append(textBody38);

            Shape shape39 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties39 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties48 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Slide Number Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties39 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks38 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties39.Append(shapeLocks38);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties48 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape38 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties48.Append(placeholderShape38);

            nonVisualShapeProperties39.Append(nonVisualDrawingProperties48);
            nonVisualShapeProperties39.Append(nonVisualShapeDrawingProperties39);
            nonVisualShapeProperties39.Append(applicationNonVisualDrawingProperties48);
            ShapeProperties shapeProperties39 = new ShapeProperties();

            TextBody textBody39 = new TextBody();
            A.BodyProperties bodyProperties39 = new A.BodyProperties();
            A.ListStyle listStyle39 = new A.ListStyle();

            A.Paragraph paragraph64 = new A.Paragraph();

            A.Field field15 = new A.Field(){ Id = "{9E0C3BFA-D4DA-4895-A0F6-B80859694A8D}", Type = "slidenum" };

            A.RunProperties runProperties55 = new A.RunProperties(){ Language = "en-US" };
            runProperties55.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text55 = new A.Text();
            text55.Text = "‹#›";

            field15.Append(runProperties55);
            field15.Append(text55);
            A.EndParagraphRunProperties endParagraphRunProperties38 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph64.Append(field15);
            paragraph64.Append(endParagraphRunProperties38);

            textBody39.Append(bodyProperties39);
            textBody39.Append(listStyle39);
            textBody39.Append(paragraph64);

            shape39.Append(nonVisualShapeProperties39);
            shape39.Append(shapeProperties39);
            shape39.Append(textBody39);

            shapeTree9.Append(nonVisualGroupShapeProperties9);
            shapeTree9.Append(groupShapeProperties9);
            shapeTree9.Append(shape36);
            shapeTree9.Append(shape37);
            shapeTree9.Append(shape38);
            shapeTree9.Append(shape39);

            commonSlideData9.Append(shapeTree9);

            ColorMapOverride colorMapOverride7 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping7 = new A.MasterColorMapping();

            colorMapOverride7.Append(masterColorMapping7);

            slideLayout6.Append(commonSlideData9);
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

            CommonSlideData commonSlideData10 = new CommonSlideData(){ Name = "Vertical Title and Text" };

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
            A.Offset offset28 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents28 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset10 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents10 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup10.Append(offset28);
            transformGroup10.Append(extents28);
            transformGroup10.Append(childOffset10);
            transformGroup10.Append(childExtents10);

            groupShapeProperties10.Append(transformGroup10);

            Shape shape40 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties40 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties50 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Vertical Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties40 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks39 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties40.Append(shapeLocks39);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties50 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape39 = new PlaceholderShape(){ Type = PlaceholderValues.Title, Orientation = DirectionValues.Vertical };

            applicationNonVisualDrawingProperties50.Append(placeholderShape39);

            nonVisualShapeProperties40.Append(nonVisualDrawingProperties50);
            nonVisualShapeProperties40.Append(nonVisualShapeDrawingProperties40);
            nonVisualShapeProperties40.Append(applicationNonVisualDrawingProperties50);

            ShapeProperties shapeProperties40 = new ShapeProperties();

            A.Transform2D transform2D19 = new A.Transform2D();
            A.Offset offset29 = new A.Offset(){ X = 4972049L, Y = 366713L };
            A.Extents extents29 = new A.Extents(){ Cx = 1543051L, Cy = 7800975L };

            transform2D19.Append(offset29);
            transform2D19.Append(extents29);

            shapeProperties40.Append(transform2D19);

            TextBody textBody40 = new TextBody();
            A.BodyProperties bodyProperties40 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.EastAsianVetical };
            A.ListStyle listStyle40 = new A.ListStyle();

            A.Paragraph paragraph65 = new A.Paragraph();

            A.Run run41 = new A.Run();

            A.RunProperties runProperties56 = new A.RunProperties(){ Language = "en-US" };
            runProperties56.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text56 = new A.Text();
            text56.Text = "Click to edit Master title style";

            run41.Append(runProperties56);
            run41.Append(text56);
            A.EndParagraphRunProperties endParagraphRunProperties39 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph65.Append(run41);
            paragraph65.Append(endParagraphRunProperties39);

            textBody40.Append(bodyProperties40);
            textBody40.Append(listStyle40);
            textBody40.Append(paragraph65);

            shape40.Append(nonVisualShapeProperties40);
            shape40.Append(shapeProperties40);
            shape40.Append(textBody40);

            Shape shape41 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties41 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties51 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Vertical Text Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties41 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks40 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties41.Append(shapeLocks40);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties51 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape40 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Orientation = DirectionValues.Vertical, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties51.Append(placeholderShape40);

            nonVisualShapeProperties41.Append(nonVisualDrawingProperties51);
            nonVisualShapeProperties41.Append(nonVisualShapeDrawingProperties41);
            nonVisualShapeProperties41.Append(applicationNonVisualDrawingProperties51);

            ShapeProperties shapeProperties41 = new ShapeProperties();

            A.Transform2D transform2D20 = new A.Transform2D();
            A.Offset offset30 = new A.Offset(){ X = 342901L, Y = 366713L };
            A.Extents extents30 = new A.Extents(){ Cx = 4476751L, Cy = 7800975L };

            transform2D20.Append(offset30);
            transform2D20.Append(extents30);

            shapeProperties41.Append(transform2D20);

            TextBody textBody41 = new TextBody();
            A.BodyProperties bodyProperties41 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.EastAsianVetical };
            A.ListStyle listStyle41 = new A.ListStyle();

            A.Paragraph paragraph66 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties31 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run42 = new A.Run();

            A.RunProperties runProperties57 = new A.RunProperties(){ Language = "en-US" };
            runProperties57.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text57 = new A.Text();
            text57.Text = "Click to edit Master text styles";

            run42.Append(runProperties57);
            run42.Append(text57);

            paragraph66.Append(paragraphProperties31);
            paragraph66.Append(run42);

            A.Paragraph paragraph67 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties32 = new A.ParagraphProperties(){ Level = 1 };

            A.Run run43 = new A.Run();

            A.RunProperties runProperties58 = new A.RunProperties(){ Language = "en-US" };
            runProperties58.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text58 = new A.Text();
            text58.Text = "Second level";

            run43.Append(runProperties58);
            run43.Append(text58);

            paragraph67.Append(paragraphProperties32);
            paragraph67.Append(run43);

            A.Paragraph paragraph68 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties33 = new A.ParagraphProperties(){ Level = 2 };

            A.Run run44 = new A.Run();

            A.RunProperties runProperties59 = new A.RunProperties(){ Language = "en-US" };
            runProperties59.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text59 = new A.Text();
            text59.Text = "Third level";

            run44.Append(runProperties59);
            run44.Append(text59);

            paragraph68.Append(paragraphProperties33);
            paragraph68.Append(run44);

            A.Paragraph paragraph69 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties34 = new A.ParagraphProperties(){ Level = 3 };

            A.Run run45 = new A.Run();

            A.RunProperties runProperties60 = new A.RunProperties(){ Language = "en-US" };
            runProperties60.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text60 = new A.Text();
            text60.Text = "Fourth level";

            run45.Append(runProperties60);
            run45.Append(text60);

            paragraph69.Append(paragraphProperties34);
            paragraph69.Append(run45);

            A.Paragraph paragraph70 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties35 = new A.ParagraphProperties(){ Level = 4 };

            A.Run run46 = new A.Run();

            A.RunProperties runProperties61 = new A.RunProperties(){ Language = "en-US" };
            runProperties61.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text61 = new A.Text();
            text61.Text = "Fifth level";

            run46.Append(runProperties61);
            run46.Append(text61);
            A.EndParagraphRunProperties endParagraphRunProperties40 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph70.Append(paragraphProperties35);
            paragraph70.Append(run46);
            paragraph70.Append(endParagraphRunProperties40);

            textBody41.Append(bodyProperties41);
            textBody41.Append(listStyle41);
            textBody41.Append(paragraph66);
            textBody41.Append(paragraph67);
            textBody41.Append(paragraph68);
            textBody41.Append(paragraph69);
            textBody41.Append(paragraph70);

            shape41.Append(nonVisualShapeProperties41);
            shape41.Append(shapeProperties41);
            shape41.Append(textBody41);

            Shape shape42 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties42 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties52 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Date Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties42 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks41 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties42.Append(shapeLocks41);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties52 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape41 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties52.Append(placeholderShape41);

            nonVisualShapeProperties42.Append(nonVisualDrawingProperties52);
            nonVisualShapeProperties42.Append(nonVisualShapeDrawingProperties42);
            nonVisualShapeProperties42.Append(applicationNonVisualDrawingProperties52);
            ShapeProperties shapeProperties42 = new ShapeProperties();

            TextBody textBody42 = new TextBody();
            A.BodyProperties bodyProperties42 = new A.BodyProperties();
            A.ListStyle listStyle42 = new A.ListStyle();

            A.Paragraph paragraph71 = new A.Paragraph();

            A.Field field16 = new A.Field(){ Id = "{1A15D4F1-1D33-4170-8C9F-182CDE6BA6D1}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties62 = new A.RunProperties(){ Language = "en-US" };
            runProperties62.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text62 = new A.Text();
            text62.Text = "10/3/2012";

            field16.Append(runProperties62);
            field16.Append(text62);
            A.EndParagraphRunProperties endParagraphRunProperties41 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph71.Append(field16);
            paragraph71.Append(endParagraphRunProperties41);

            textBody42.Append(bodyProperties42);
            textBody42.Append(listStyle42);
            textBody42.Append(paragraph71);

            shape42.Append(nonVisualShapeProperties42);
            shape42.Append(shapeProperties42);
            shape42.Append(textBody42);

            Shape shape43 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties43 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties53 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Footer Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties43 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks42 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties43.Append(shapeLocks42);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties53 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape42 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties53.Append(placeholderShape42);

            nonVisualShapeProperties43.Append(nonVisualDrawingProperties53);
            nonVisualShapeProperties43.Append(nonVisualShapeDrawingProperties43);
            nonVisualShapeProperties43.Append(applicationNonVisualDrawingProperties53);
            ShapeProperties shapeProperties43 = new ShapeProperties();

            TextBody textBody43 = new TextBody();
            A.BodyProperties bodyProperties43 = new A.BodyProperties();
            A.ListStyle listStyle43 = new A.ListStyle();

            A.Paragraph paragraph72 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties42 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph72.Append(endParagraphRunProperties42);

            textBody43.Append(bodyProperties43);
            textBody43.Append(listStyle43);
            textBody43.Append(paragraph72);

            shape43.Append(nonVisualShapeProperties43);
            shape43.Append(shapeProperties43);
            shape43.Append(textBody43);

            Shape shape44 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties44 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties54 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Slide Number Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties44 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks43 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties44.Append(shapeLocks43);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties54 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape43 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties54.Append(placeholderShape43);

            nonVisualShapeProperties44.Append(nonVisualDrawingProperties54);
            nonVisualShapeProperties44.Append(nonVisualShapeDrawingProperties44);
            nonVisualShapeProperties44.Append(applicationNonVisualDrawingProperties54);
            ShapeProperties shapeProperties44 = new ShapeProperties();

            TextBody textBody44 = new TextBody();
            A.BodyProperties bodyProperties44 = new A.BodyProperties();
            A.ListStyle listStyle44 = new A.ListStyle();

            A.Paragraph paragraph73 = new A.Paragraph();

            A.Field field17 = new A.Field(){ Id = "{9E0C3BFA-D4DA-4895-A0F6-B80859694A8D}", Type = "slidenum" };

            A.RunProperties runProperties63 = new A.RunProperties(){ Language = "en-US" };
            runProperties63.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text63 = new A.Text();
            text63.Text = "‹#›";

            field17.Append(runProperties63);
            field17.Append(text63);
            A.EndParagraphRunProperties endParagraphRunProperties43 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph73.Append(field17);
            paragraph73.Append(endParagraphRunProperties43);

            textBody44.Append(bodyProperties44);
            textBody44.Append(listStyle44);
            textBody44.Append(paragraph73);

            shape44.Append(nonVisualShapeProperties44);
            shape44.Append(shapeProperties44);
            shape44.Append(textBody44);

            shapeTree10.Append(nonVisualGroupShapeProperties10);
            shapeTree10.Append(groupShapeProperties10);
            shapeTree10.Append(shape40);
            shapeTree10.Append(shape41);
            shapeTree10.Append(shape42);
            shapeTree10.Append(shape43);
            shapeTree10.Append(shape44);

            commonSlideData10.Append(shapeTree10);

            ColorMapOverride colorMapOverride8 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping8 = new A.MasterColorMapping();

            colorMapOverride8.Append(masterColorMapping8);

            slideLayout7.Append(commonSlideData10);
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

            CommonSlideData commonSlideData11 = new CommonSlideData(){ Name = "Comparison" };

            ShapeTree shapeTree11 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties11 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties55 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties11 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties55 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties11.Append(nonVisualDrawingProperties55);
            nonVisualGroupShapeProperties11.Append(nonVisualGroupShapeDrawingProperties11);
            nonVisualGroupShapeProperties11.Append(applicationNonVisualDrawingProperties55);

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

            Shape shape45 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties45 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties56 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties45 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks44 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties45.Append(shapeLocks44);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties56 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape44 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties56.Append(placeholderShape44);

            nonVisualShapeProperties45.Append(nonVisualDrawingProperties56);
            nonVisualShapeProperties45.Append(nonVisualShapeDrawingProperties45);
            nonVisualShapeProperties45.Append(applicationNonVisualDrawingProperties56);

            ShapeProperties shapeProperties45 = new ShapeProperties();

            A.Transform2D transform2D21 = new A.Transform2D();
            A.Offset offset32 = new A.Offset(){ X = 457200L, Y = 274638L };
            A.Extents extents32 = new A.Extents(){ Cx = 8229600L, Cy = 1143000L };

            transform2D21.Append(offset32);
            transform2D21.Append(extents32);

            shapeProperties45.Append(transform2D21);

            TextBody textBody45 = new TextBody();
            A.BodyProperties bodyProperties45 = new A.BodyProperties();

            A.ListStyle listStyle45 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties18 = new A.Level1ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties84 = new A.DefaultRunProperties();

            level1ParagraphProperties18.Append(defaultRunProperties84);

            listStyle45.Append(level1ParagraphProperties18);

            A.Paragraph paragraph74 = new A.Paragraph();

            A.Run run47 = new A.Run();

            A.RunProperties runProperties64 = new A.RunProperties(){ Language = "en-US" };
            runProperties64.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text64 = new A.Text();
            text64.Text = "Click to edit Master title style";

            run47.Append(runProperties64);
            run47.Append(text64);
            A.EndParagraphRunProperties endParagraphRunProperties44 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph74.Append(run47);
            paragraph74.Append(endParagraphRunProperties44);

            textBody45.Append(bodyProperties45);
            textBody45.Append(listStyle45);
            textBody45.Append(paragraph74);

            shape45.Append(nonVisualShapeProperties45);
            shape45.Append(shapeProperties45);
            shape45.Append(textBody45);

            Shape shape46 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties46 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties57 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Text Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties46 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks45 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties46.Append(shapeLocks45);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties57 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape45 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties57.Append(placeholderShape45);

            nonVisualShapeProperties46.Append(nonVisualDrawingProperties57);
            nonVisualShapeProperties46.Append(nonVisualShapeDrawingProperties46);
            nonVisualShapeProperties46.Append(applicationNonVisualDrawingProperties57);

            ShapeProperties shapeProperties46 = new ShapeProperties();

            A.Transform2D transform2D22 = new A.Transform2D();
            A.Offset offset33 = new A.Offset(){ X = 457201L, Y = 1535113L };
            A.Extents extents33 = new A.Extents(){ Cx = 4040188L, Cy = 639762L };

            transform2D22.Append(offset33);
            transform2D22.Append(extents33);

            shapeProperties46.Append(transform2D22);

            TextBody textBody46 = new TextBody();
            A.BodyProperties bodyProperties46 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Bottom };

            A.ListStyle listStyle46 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties19 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0 };
            A.NoBullet noBullet29 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties85 = new A.DefaultRunProperties(){ FontSize = 2400, Bold = true };

            level1ParagraphProperties19.Append(noBullet29);
            level1ParagraphProperties19.Append(defaultRunProperties85);

            A.Level2ParagraphProperties level2ParagraphProperties9 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Indent = 0 };
            A.NoBullet noBullet30 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties86 = new A.DefaultRunProperties(){ FontSize = 2000, Bold = true };

            level2ParagraphProperties9.Append(noBullet30);
            level2ParagraphProperties9.Append(defaultRunProperties86);

            A.Level3ParagraphProperties level3ParagraphProperties9 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Indent = 0 };
            A.NoBullet noBullet31 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties87 = new A.DefaultRunProperties(){ FontSize = 1800, Bold = true };

            level3ParagraphProperties9.Append(noBullet31);
            level3ParagraphProperties9.Append(defaultRunProperties87);

            A.Level4ParagraphProperties level4ParagraphProperties9 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Indent = 0 };
            A.NoBullet noBullet32 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties88 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level4ParagraphProperties9.Append(noBullet32);
            level4ParagraphProperties9.Append(defaultRunProperties88);

            A.Level5ParagraphProperties level5ParagraphProperties9 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Indent = 0 };
            A.NoBullet noBullet33 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties89 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level5ParagraphProperties9.Append(noBullet33);
            level5ParagraphProperties9.Append(defaultRunProperties89);

            A.Level6ParagraphProperties level6ParagraphProperties9 = new A.Level6ParagraphProperties(){ LeftMargin = 2286000, Indent = 0 };
            A.NoBullet noBullet34 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties90 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level6ParagraphProperties9.Append(noBullet34);
            level6ParagraphProperties9.Append(defaultRunProperties90);

            A.Level7ParagraphProperties level7ParagraphProperties9 = new A.Level7ParagraphProperties(){ LeftMargin = 2743200, Indent = 0 };
            A.NoBullet noBullet35 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties91 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level7ParagraphProperties9.Append(noBullet35);
            level7ParagraphProperties9.Append(defaultRunProperties91);

            A.Level8ParagraphProperties level8ParagraphProperties9 = new A.Level8ParagraphProperties(){ LeftMargin = 3200400, Indent = 0 };
            A.NoBullet noBullet36 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties92 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level8ParagraphProperties9.Append(noBullet36);
            level8ParagraphProperties9.Append(defaultRunProperties92);

            A.Level9ParagraphProperties level9ParagraphProperties9 = new A.Level9ParagraphProperties(){ LeftMargin = 3657600, Indent = 0 };
            A.NoBullet noBullet37 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties93 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level9ParagraphProperties9.Append(noBullet37);
            level9ParagraphProperties9.Append(defaultRunProperties93);

            listStyle46.Append(level1ParagraphProperties19);
            listStyle46.Append(level2ParagraphProperties9);
            listStyle46.Append(level3ParagraphProperties9);
            listStyle46.Append(level4ParagraphProperties9);
            listStyle46.Append(level5ParagraphProperties9);
            listStyle46.Append(level6ParagraphProperties9);
            listStyle46.Append(level7ParagraphProperties9);
            listStyle46.Append(level8ParagraphProperties9);
            listStyle46.Append(level9ParagraphProperties9);

            A.Paragraph paragraph75 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties36 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run48 = new A.Run();

            A.RunProperties runProperties65 = new A.RunProperties(){ Language = "en-US" };
            runProperties65.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text65 = new A.Text();
            text65.Text = "Click to edit Master text styles";

            run48.Append(runProperties65);
            run48.Append(text65);

            paragraph75.Append(paragraphProperties36);
            paragraph75.Append(run48);

            textBody46.Append(bodyProperties46);
            textBody46.Append(listStyle46);
            textBody46.Append(paragraph75);

            shape46.Append(nonVisualShapeProperties46);
            shape46.Append(shapeProperties46);
            shape46.Append(textBody46);

            Shape shape47 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties47 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties58 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Content Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties47 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks46 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties47.Append(shapeLocks46);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties58 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape46 = new PlaceholderShape(){ Size = PlaceholderSizeValues.Half, Index = (UInt32Value)2U };

            applicationNonVisualDrawingProperties58.Append(placeholderShape46);

            nonVisualShapeProperties47.Append(nonVisualDrawingProperties58);
            nonVisualShapeProperties47.Append(nonVisualShapeDrawingProperties47);
            nonVisualShapeProperties47.Append(applicationNonVisualDrawingProperties58);

            ShapeProperties shapeProperties47 = new ShapeProperties();

            A.Transform2D transform2D23 = new A.Transform2D();
            A.Offset offset34 = new A.Offset(){ X = 457201L, Y = 2174875L };
            A.Extents extents34 = new A.Extents(){ Cx = 4040188L, Cy = 3951288L };

            transform2D23.Append(offset34);
            transform2D23.Append(extents34);

            shapeProperties47.Append(transform2D23);

            TextBody textBody47 = new TextBody();
            A.BodyProperties bodyProperties47 = new A.BodyProperties();

            A.ListStyle listStyle47 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties20 = new A.Level1ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties94 = new A.DefaultRunProperties(){ FontSize = 2400 };

            level1ParagraphProperties20.Append(defaultRunProperties94);

            A.Level2ParagraphProperties level2ParagraphProperties10 = new A.Level2ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties95 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level2ParagraphProperties10.Append(defaultRunProperties95);

            A.Level3ParagraphProperties level3ParagraphProperties10 = new A.Level3ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties96 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level3ParagraphProperties10.Append(defaultRunProperties96);

            A.Level4ParagraphProperties level4ParagraphProperties10 = new A.Level4ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties97 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level4ParagraphProperties10.Append(defaultRunProperties97);

            A.Level5ParagraphProperties level5ParagraphProperties10 = new A.Level5ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties98 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level5ParagraphProperties10.Append(defaultRunProperties98);

            A.Level6ParagraphProperties level6ParagraphProperties10 = new A.Level6ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties99 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level6ParagraphProperties10.Append(defaultRunProperties99);

            A.Level7ParagraphProperties level7ParagraphProperties10 = new A.Level7ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties100 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level7ParagraphProperties10.Append(defaultRunProperties100);

            A.Level8ParagraphProperties level8ParagraphProperties10 = new A.Level8ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties101 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level8ParagraphProperties10.Append(defaultRunProperties101);

            A.Level9ParagraphProperties level9ParagraphProperties10 = new A.Level9ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties102 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level9ParagraphProperties10.Append(defaultRunProperties102);

            listStyle47.Append(level1ParagraphProperties20);
            listStyle47.Append(level2ParagraphProperties10);
            listStyle47.Append(level3ParagraphProperties10);
            listStyle47.Append(level4ParagraphProperties10);
            listStyle47.Append(level5ParagraphProperties10);
            listStyle47.Append(level6ParagraphProperties10);
            listStyle47.Append(level7ParagraphProperties10);
            listStyle47.Append(level8ParagraphProperties10);
            listStyle47.Append(level9ParagraphProperties10);

            A.Paragraph paragraph76 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties37 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run49 = new A.Run();

            A.RunProperties runProperties66 = new A.RunProperties(){ Language = "en-US" };
            runProperties66.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text66 = new A.Text();
            text66.Text = "Click to edit Master text styles";

            run49.Append(runProperties66);
            run49.Append(text66);

            paragraph76.Append(paragraphProperties37);
            paragraph76.Append(run49);

            A.Paragraph paragraph77 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties38 = new A.ParagraphProperties(){ Level = 1 };

            A.Run run50 = new A.Run();

            A.RunProperties runProperties67 = new A.RunProperties(){ Language = "en-US" };
            runProperties67.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text67 = new A.Text();
            text67.Text = "Second level";

            run50.Append(runProperties67);
            run50.Append(text67);

            paragraph77.Append(paragraphProperties38);
            paragraph77.Append(run50);

            A.Paragraph paragraph78 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties39 = new A.ParagraphProperties(){ Level = 2 };

            A.Run run51 = new A.Run();

            A.RunProperties runProperties68 = new A.RunProperties(){ Language = "en-US" };
            runProperties68.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text68 = new A.Text();
            text68.Text = "Third level";

            run51.Append(runProperties68);
            run51.Append(text68);

            paragraph78.Append(paragraphProperties39);
            paragraph78.Append(run51);

            A.Paragraph paragraph79 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties40 = new A.ParagraphProperties(){ Level = 3 };

            A.Run run52 = new A.Run();

            A.RunProperties runProperties69 = new A.RunProperties(){ Language = "en-US" };
            runProperties69.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text69 = new A.Text();
            text69.Text = "Fourth level";

            run52.Append(runProperties69);
            run52.Append(text69);

            paragraph79.Append(paragraphProperties40);
            paragraph79.Append(run52);

            A.Paragraph paragraph80 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties41 = new A.ParagraphProperties(){ Level = 4 };

            A.Run run53 = new A.Run();

            A.RunProperties runProperties70 = new A.RunProperties(){ Language = "en-US" };
            runProperties70.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text70 = new A.Text();
            text70.Text = "Fifth level";

            run53.Append(runProperties70);
            run53.Append(text70);
            A.EndParagraphRunProperties endParagraphRunProperties45 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph80.Append(paragraphProperties41);
            paragraph80.Append(run53);
            paragraph80.Append(endParagraphRunProperties45);

            textBody47.Append(bodyProperties47);
            textBody47.Append(listStyle47);
            textBody47.Append(paragraph76);
            textBody47.Append(paragraph77);
            textBody47.Append(paragraph78);
            textBody47.Append(paragraph79);
            textBody47.Append(paragraph80);

            shape47.Append(nonVisualShapeProperties47);
            shape47.Append(shapeProperties47);
            shape47.Append(textBody47);

            Shape shape48 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties48 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties59 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Text Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties48 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks47 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties48.Append(shapeLocks47);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties59 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape47 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)3U };

            applicationNonVisualDrawingProperties59.Append(placeholderShape47);

            nonVisualShapeProperties48.Append(nonVisualDrawingProperties59);
            nonVisualShapeProperties48.Append(nonVisualShapeDrawingProperties48);
            nonVisualShapeProperties48.Append(applicationNonVisualDrawingProperties59);

            ShapeProperties shapeProperties48 = new ShapeProperties();

            A.Transform2D transform2D24 = new A.Transform2D();
            A.Offset offset35 = new A.Offset(){ X = 4645026L, Y = 1535113L };
            A.Extents extents35 = new A.Extents(){ Cx = 4041775L, Cy = 639762L };

            transform2D24.Append(offset35);
            transform2D24.Append(extents35);

            shapeProperties48.Append(transform2D24);

            TextBody textBody48 = new TextBody();
            A.BodyProperties bodyProperties48 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Bottom };

            A.ListStyle listStyle48 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties21 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0 };
            A.NoBullet noBullet38 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties103 = new A.DefaultRunProperties(){ FontSize = 2400, Bold = true };

            level1ParagraphProperties21.Append(noBullet38);
            level1ParagraphProperties21.Append(defaultRunProperties103);

            A.Level2ParagraphProperties level2ParagraphProperties11 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Indent = 0 };
            A.NoBullet noBullet39 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties104 = new A.DefaultRunProperties(){ FontSize = 2000, Bold = true };

            level2ParagraphProperties11.Append(noBullet39);
            level2ParagraphProperties11.Append(defaultRunProperties104);

            A.Level3ParagraphProperties level3ParagraphProperties11 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Indent = 0 };
            A.NoBullet noBullet40 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties105 = new A.DefaultRunProperties(){ FontSize = 1800, Bold = true };

            level3ParagraphProperties11.Append(noBullet40);
            level3ParagraphProperties11.Append(defaultRunProperties105);

            A.Level4ParagraphProperties level4ParagraphProperties11 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Indent = 0 };
            A.NoBullet noBullet41 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties106 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level4ParagraphProperties11.Append(noBullet41);
            level4ParagraphProperties11.Append(defaultRunProperties106);

            A.Level5ParagraphProperties level5ParagraphProperties11 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Indent = 0 };
            A.NoBullet noBullet42 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties107 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level5ParagraphProperties11.Append(noBullet42);
            level5ParagraphProperties11.Append(defaultRunProperties107);

            A.Level6ParagraphProperties level6ParagraphProperties11 = new A.Level6ParagraphProperties(){ LeftMargin = 2286000, Indent = 0 };
            A.NoBullet noBullet43 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties108 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level6ParagraphProperties11.Append(noBullet43);
            level6ParagraphProperties11.Append(defaultRunProperties108);

            A.Level7ParagraphProperties level7ParagraphProperties11 = new A.Level7ParagraphProperties(){ LeftMargin = 2743200, Indent = 0 };
            A.NoBullet noBullet44 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties109 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level7ParagraphProperties11.Append(noBullet44);
            level7ParagraphProperties11.Append(defaultRunProperties109);

            A.Level8ParagraphProperties level8ParagraphProperties11 = new A.Level8ParagraphProperties(){ LeftMargin = 3200400, Indent = 0 };
            A.NoBullet noBullet45 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties110 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level8ParagraphProperties11.Append(noBullet45);
            level8ParagraphProperties11.Append(defaultRunProperties110);

            A.Level9ParagraphProperties level9ParagraphProperties11 = new A.Level9ParagraphProperties(){ LeftMargin = 3657600, Indent = 0 };
            A.NoBullet noBullet46 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties111 = new A.DefaultRunProperties(){ FontSize = 1600, Bold = true };

            level9ParagraphProperties11.Append(noBullet46);
            level9ParagraphProperties11.Append(defaultRunProperties111);

            listStyle48.Append(level1ParagraphProperties21);
            listStyle48.Append(level2ParagraphProperties11);
            listStyle48.Append(level3ParagraphProperties11);
            listStyle48.Append(level4ParagraphProperties11);
            listStyle48.Append(level5ParagraphProperties11);
            listStyle48.Append(level6ParagraphProperties11);
            listStyle48.Append(level7ParagraphProperties11);
            listStyle48.Append(level8ParagraphProperties11);
            listStyle48.Append(level9ParagraphProperties11);

            A.Paragraph paragraph81 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties42 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run54 = new A.Run();

            A.RunProperties runProperties71 = new A.RunProperties(){ Language = "en-US" };
            runProperties71.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text71 = new A.Text();
            text71.Text = "Click to edit Master text styles";

            run54.Append(runProperties71);
            run54.Append(text71);

            paragraph81.Append(paragraphProperties42);
            paragraph81.Append(run54);

            textBody48.Append(bodyProperties48);
            textBody48.Append(listStyle48);
            textBody48.Append(paragraph81);

            shape48.Append(nonVisualShapeProperties48);
            shape48.Append(shapeProperties48);
            shape48.Append(textBody48);

            Shape shape49 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties49 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties60 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Content Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties49 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks48 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties49.Append(shapeLocks48);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties60 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape48 = new PlaceholderShape(){ Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)4U };

            applicationNonVisualDrawingProperties60.Append(placeholderShape48);

            nonVisualShapeProperties49.Append(nonVisualDrawingProperties60);
            nonVisualShapeProperties49.Append(nonVisualShapeDrawingProperties49);
            nonVisualShapeProperties49.Append(applicationNonVisualDrawingProperties60);

            ShapeProperties shapeProperties49 = new ShapeProperties();

            A.Transform2D transform2D25 = new A.Transform2D();
            A.Offset offset36 = new A.Offset(){ X = 4645026L, Y = 2174875L };
            A.Extents extents36 = new A.Extents(){ Cx = 4041775L, Cy = 3951288L };

            transform2D25.Append(offset36);
            transform2D25.Append(extents36);

            shapeProperties49.Append(transform2D25);

            TextBody textBody49 = new TextBody();
            A.BodyProperties bodyProperties49 = new A.BodyProperties();

            A.ListStyle listStyle49 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties22 = new A.Level1ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties112 = new A.DefaultRunProperties(){ FontSize = 2400 };

            level1ParagraphProperties22.Append(defaultRunProperties112);

            A.Level2ParagraphProperties level2ParagraphProperties12 = new A.Level2ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties113 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level2ParagraphProperties12.Append(defaultRunProperties113);

            A.Level3ParagraphProperties level3ParagraphProperties12 = new A.Level3ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties114 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level3ParagraphProperties12.Append(defaultRunProperties114);

            A.Level4ParagraphProperties level4ParagraphProperties12 = new A.Level4ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties115 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level4ParagraphProperties12.Append(defaultRunProperties115);

            A.Level5ParagraphProperties level5ParagraphProperties12 = new A.Level5ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties116 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level5ParagraphProperties12.Append(defaultRunProperties116);

            A.Level6ParagraphProperties level6ParagraphProperties12 = new A.Level6ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties117 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level6ParagraphProperties12.Append(defaultRunProperties117);

            A.Level7ParagraphProperties level7ParagraphProperties12 = new A.Level7ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties118 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level7ParagraphProperties12.Append(defaultRunProperties118);

            A.Level8ParagraphProperties level8ParagraphProperties12 = new A.Level8ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties119 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level8ParagraphProperties12.Append(defaultRunProperties119);

            A.Level9ParagraphProperties level9ParagraphProperties12 = new A.Level9ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties120 = new A.DefaultRunProperties(){ FontSize = 1600 };

            level9ParagraphProperties12.Append(defaultRunProperties120);

            listStyle49.Append(level1ParagraphProperties22);
            listStyle49.Append(level2ParagraphProperties12);
            listStyle49.Append(level3ParagraphProperties12);
            listStyle49.Append(level4ParagraphProperties12);
            listStyle49.Append(level5ParagraphProperties12);
            listStyle49.Append(level6ParagraphProperties12);
            listStyle49.Append(level7ParagraphProperties12);
            listStyle49.Append(level8ParagraphProperties12);
            listStyle49.Append(level9ParagraphProperties12);

            A.Paragraph paragraph82 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties43 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run55 = new A.Run();

            A.RunProperties runProperties72 = new A.RunProperties(){ Language = "en-US" };
            runProperties72.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text72 = new A.Text();
            text72.Text = "Click to edit Master text styles";

            run55.Append(runProperties72);
            run55.Append(text72);

            paragraph82.Append(paragraphProperties43);
            paragraph82.Append(run55);

            A.Paragraph paragraph83 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties44 = new A.ParagraphProperties(){ Level = 1 };

            A.Run run56 = new A.Run();

            A.RunProperties runProperties73 = new A.RunProperties(){ Language = "en-US" };
            runProperties73.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text73 = new A.Text();
            text73.Text = "Second level";

            run56.Append(runProperties73);
            run56.Append(text73);

            paragraph83.Append(paragraphProperties44);
            paragraph83.Append(run56);

            A.Paragraph paragraph84 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties45 = new A.ParagraphProperties(){ Level = 2 };

            A.Run run57 = new A.Run();

            A.RunProperties runProperties74 = new A.RunProperties(){ Language = "en-US" };
            runProperties74.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text74 = new A.Text();
            text74.Text = "Third level";

            run57.Append(runProperties74);
            run57.Append(text74);

            paragraph84.Append(paragraphProperties45);
            paragraph84.Append(run57);

            A.Paragraph paragraph85 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties46 = new A.ParagraphProperties(){ Level = 3 };

            A.Run run58 = new A.Run();

            A.RunProperties runProperties75 = new A.RunProperties(){ Language = "en-US" };
            runProperties75.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text75 = new A.Text();
            text75.Text = "Fourth level";

            run58.Append(runProperties75);
            run58.Append(text75);

            paragraph85.Append(paragraphProperties46);
            paragraph85.Append(run58);

            A.Paragraph paragraph86 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties47 = new A.ParagraphProperties(){ Level = 4 };

            A.Run run59 = new A.Run();

            A.RunProperties runProperties76 = new A.RunProperties(){ Language = "en-US" };
            runProperties76.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text76 = new A.Text();
            text76.Text = "Fifth level";

            run59.Append(runProperties76);
            run59.Append(text76);
            A.EndParagraphRunProperties endParagraphRunProperties46 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph86.Append(paragraphProperties47);
            paragraph86.Append(run59);
            paragraph86.Append(endParagraphRunProperties46);

            textBody49.Append(bodyProperties49);
            textBody49.Append(listStyle49);
            textBody49.Append(paragraph82);
            textBody49.Append(paragraph83);
            textBody49.Append(paragraph84);
            textBody49.Append(paragraph85);
            textBody49.Append(paragraph86);

            shape49.Append(nonVisualShapeProperties49);
            shape49.Append(shapeProperties49);
            shape49.Append(textBody49);

            Shape shape50 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties50 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties61 = new NonVisualDrawingProperties(){ Id = (UInt32Value)7U, Name = "Date Placeholder 6" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties50 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks49 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties50.Append(shapeLocks49);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties61 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape49 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties61.Append(placeholderShape49);

            nonVisualShapeProperties50.Append(nonVisualDrawingProperties61);
            nonVisualShapeProperties50.Append(nonVisualShapeDrawingProperties50);
            nonVisualShapeProperties50.Append(applicationNonVisualDrawingProperties61);
            ShapeProperties shapeProperties50 = new ShapeProperties();

            TextBody textBody50 = new TextBody();
            A.BodyProperties bodyProperties50 = new A.BodyProperties();
            A.ListStyle listStyle50 = new A.ListStyle();

            A.Paragraph paragraph87 = new A.Paragraph();

            A.Field field18 = new A.Field(){ Id = "{1A15D4F1-1D33-4170-8C9F-182CDE6BA6D1}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties77 = new A.RunProperties(){ Language = "en-US" };
            runProperties77.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text77 = new A.Text();
            text77.Text = "10/3/2012";

            field18.Append(runProperties77);
            field18.Append(text77);
            A.EndParagraphRunProperties endParagraphRunProperties47 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph87.Append(field18);
            paragraph87.Append(endParagraphRunProperties47);

            textBody50.Append(bodyProperties50);
            textBody50.Append(listStyle50);
            textBody50.Append(paragraph87);

            shape50.Append(nonVisualShapeProperties50);
            shape50.Append(shapeProperties50);
            shape50.Append(textBody50);

            Shape shape51 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties51 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties62 = new NonVisualDrawingProperties(){ Id = (UInt32Value)8U, Name = "Footer Placeholder 7" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties51 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks50 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties51.Append(shapeLocks50);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties62 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape50 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties62.Append(placeholderShape50);

            nonVisualShapeProperties51.Append(nonVisualDrawingProperties62);
            nonVisualShapeProperties51.Append(nonVisualShapeDrawingProperties51);
            nonVisualShapeProperties51.Append(applicationNonVisualDrawingProperties62);
            ShapeProperties shapeProperties51 = new ShapeProperties();

            TextBody textBody51 = new TextBody();
            A.BodyProperties bodyProperties51 = new A.BodyProperties();
            A.ListStyle listStyle51 = new A.ListStyle();

            A.Paragraph paragraph88 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties48 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph88.Append(endParagraphRunProperties48);

            textBody51.Append(bodyProperties51);
            textBody51.Append(listStyle51);
            textBody51.Append(paragraph88);

            shape51.Append(nonVisualShapeProperties51);
            shape51.Append(shapeProperties51);
            shape51.Append(textBody51);

            Shape shape52 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties52 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties63 = new NonVisualDrawingProperties(){ Id = (UInt32Value)9U, Name = "Slide Number Placeholder 8" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties52 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks51 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties52.Append(shapeLocks51);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties63 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape51 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties63.Append(placeholderShape51);

            nonVisualShapeProperties52.Append(nonVisualDrawingProperties63);
            nonVisualShapeProperties52.Append(nonVisualShapeDrawingProperties52);
            nonVisualShapeProperties52.Append(applicationNonVisualDrawingProperties63);
            ShapeProperties shapeProperties52 = new ShapeProperties();

            TextBody textBody52 = new TextBody();
            A.BodyProperties bodyProperties52 = new A.BodyProperties();
            A.ListStyle listStyle52 = new A.ListStyle();

            A.Paragraph paragraph89 = new A.Paragraph();

            A.Field field19 = new A.Field(){ Id = "{9E0C3BFA-D4DA-4895-A0F6-B80859694A8D}", Type = "slidenum" };

            A.RunProperties runProperties78 = new A.RunProperties(){ Language = "en-US" };
            runProperties78.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text78 = new A.Text();
            text78.Text = "‹#›";

            field19.Append(runProperties78);
            field19.Append(text78);
            A.EndParagraphRunProperties endParagraphRunProperties49 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph89.Append(field19);
            paragraph89.Append(endParagraphRunProperties49);

            textBody52.Append(bodyProperties52);
            textBody52.Append(listStyle52);
            textBody52.Append(paragraph89);

            shape52.Append(nonVisualShapeProperties52);
            shape52.Append(shapeProperties52);
            shape52.Append(textBody52);

            shapeTree11.Append(nonVisualGroupShapeProperties11);
            shapeTree11.Append(groupShapeProperties11);
            shapeTree11.Append(shape45);
            shapeTree11.Append(shape46);
            shapeTree11.Append(shape47);
            shapeTree11.Append(shape48);
            shapeTree11.Append(shape49);
            shapeTree11.Append(shape50);
            shapeTree11.Append(shape51);
            shapeTree11.Append(shape52);

            commonSlideData11.Append(shapeTree11);

            ColorMapOverride colorMapOverride9 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping9 = new A.MasterColorMapping();

            colorMapOverride9.Append(masterColorMapping9);

            slideLayout8.Append(commonSlideData11);
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

            CommonSlideData commonSlideData12 = new CommonSlideData(){ Name = "Title and Vertical Text" };

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
            A.Offset offset37 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents37 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset12 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents12 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup12.Append(offset37);
            transformGroup12.Append(extents37);
            transformGroup12.Append(childOffset12);
            transformGroup12.Append(childExtents12);

            groupShapeProperties12.Append(transformGroup12);

            Shape shape53 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties53 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties65 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties53 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks52 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties53.Append(shapeLocks52);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties65 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape52 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties65.Append(placeholderShape52);

            nonVisualShapeProperties53.Append(nonVisualDrawingProperties65);
            nonVisualShapeProperties53.Append(nonVisualShapeDrawingProperties53);
            nonVisualShapeProperties53.Append(applicationNonVisualDrawingProperties65);
            ShapeProperties shapeProperties53 = new ShapeProperties();

            TextBody textBody53 = new TextBody();
            A.BodyProperties bodyProperties53 = new A.BodyProperties();
            A.ListStyle listStyle53 = new A.ListStyle();

            A.Paragraph paragraph90 = new A.Paragraph();

            A.Run run60 = new A.Run();

            A.RunProperties runProperties79 = new A.RunProperties(){ Language = "en-US" };
            runProperties79.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text79 = new A.Text();
            text79.Text = "Click to edit Master title style";

            run60.Append(runProperties79);
            run60.Append(text79);
            A.EndParagraphRunProperties endParagraphRunProperties50 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph90.Append(run60);
            paragraph90.Append(endParagraphRunProperties50);

            textBody53.Append(bodyProperties53);
            textBody53.Append(listStyle53);
            textBody53.Append(paragraph90);

            shape53.Append(nonVisualShapeProperties53);
            shape53.Append(shapeProperties53);
            shape53.Append(textBody53);

            Shape shape54 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties54 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties66 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Vertical Text Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties54 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks53 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties54.Append(shapeLocks53);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties66 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape53 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Orientation = DirectionValues.Vertical, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties66.Append(placeholderShape53);

            nonVisualShapeProperties54.Append(nonVisualDrawingProperties66);
            nonVisualShapeProperties54.Append(nonVisualShapeDrawingProperties54);
            nonVisualShapeProperties54.Append(applicationNonVisualDrawingProperties66);
            ShapeProperties shapeProperties54 = new ShapeProperties();

            TextBody textBody54 = new TextBody();
            A.BodyProperties bodyProperties54 = new A.BodyProperties(){ Vertical = A.TextVerticalValues.EastAsianVetical };
            A.ListStyle listStyle54 = new A.ListStyle();

            A.Paragraph paragraph91 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties48 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run61 = new A.Run();

            A.RunProperties runProperties80 = new A.RunProperties(){ Language = "en-US" };
            runProperties80.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text80 = new A.Text();
            text80.Text = "Click to edit Master text styles";

            run61.Append(runProperties80);
            run61.Append(text80);

            paragraph91.Append(paragraphProperties48);
            paragraph91.Append(run61);

            A.Paragraph paragraph92 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties49 = new A.ParagraphProperties(){ Level = 1 };

            A.Run run62 = new A.Run();

            A.RunProperties runProperties81 = new A.RunProperties(){ Language = "en-US" };
            runProperties81.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text81 = new A.Text();
            text81.Text = "Second level";

            run62.Append(runProperties81);
            run62.Append(text81);

            paragraph92.Append(paragraphProperties49);
            paragraph92.Append(run62);

            A.Paragraph paragraph93 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties50 = new A.ParagraphProperties(){ Level = 2 };

            A.Run run63 = new A.Run();

            A.RunProperties runProperties82 = new A.RunProperties(){ Language = "en-US" };
            runProperties82.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text82 = new A.Text();
            text82.Text = "Third level";

            run63.Append(runProperties82);
            run63.Append(text82);

            paragraph93.Append(paragraphProperties50);
            paragraph93.Append(run63);

            A.Paragraph paragraph94 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties51 = new A.ParagraphProperties(){ Level = 3 };

            A.Run run64 = new A.Run();

            A.RunProperties runProperties83 = new A.RunProperties(){ Language = "en-US" };
            runProperties83.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text83 = new A.Text();
            text83.Text = "Fourth level";

            run64.Append(runProperties83);
            run64.Append(text83);

            paragraph94.Append(paragraphProperties51);
            paragraph94.Append(run64);

            A.Paragraph paragraph95 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties52 = new A.ParagraphProperties(){ Level = 4 };

            A.Run run65 = new A.Run();

            A.RunProperties runProperties84 = new A.RunProperties(){ Language = "en-US" };
            runProperties84.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text84 = new A.Text();
            text84.Text = "Fifth level";

            run65.Append(runProperties84);
            run65.Append(text84);
            A.EndParagraphRunProperties endParagraphRunProperties51 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph95.Append(paragraphProperties52);
            paragraph95.Append(run65);
            paragraph95.Append(endParagraphRunProperties51);

            textBody54.Append(bodyProperties54);
            textBody54.Append(listStyle54);
            textBody54.Append(paragraph91);
            textBody54.Append(paragraph92);
            textBody54.Append(paragraph93);
            textBody54.Append(paragraph94);
            textBody54.Append(paragraph95);

            shape54.Append(nonVisualShapeProperties54);
            shape54.Append(shapeProperties54);
            shape54.Append(textBody54);

            Shape shape55 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties55 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties67 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Date Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties55 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks54 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties55.Append(shapeLocks54);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties67 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape54 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties67.Append(placeholderShape54);

            nonVisualShapeProperties55.Append(nonVisualDrawingProperties67);
            nonVisualShapeProperties55.Append(nonVisualShapeDrawingProperties55);
            nonVisualShapeProperties55.Append(applicationNonVisualDrawingProperties67);
            ShapeProperties shapeProperties55 = new ShapeProperties();

            TextBody textBody55 = new TextBody();
            A.BodyProperties bodyProperties55 = new A.BodyProperties();
            A.ListStyle listStyle55 = new A.ListStyle();

            A.Paragraph paragraph96 = new A.Paragraph();

            A.Field field20 = new A.Field(){ Id = "{1A15D4F1-1D33-4170-8C9F-182CDE6BA6D1}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties85 = new A.RunProperties(){ Language = "en-US" };
            runProperties85.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text85 = new A.Text();
            text85.Text = "10/3/2012";

            field20.Append(runProperties85);
            field20.Append(text85);
            A.EndParagraphRunProperties endParagraphRunProperties52 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph96.Append(field20);
            paragraph96.Append(endParagraphRunProperties52);

            textBody55.Append(bodyProperties55);
            textBody55.Append(listStyle55);
            textBody55.Append(paragraph96);

            shape55.Append(nonVisualShapeProperties55);
            shape55.Append(shapeProperties55);
            shape55.Append(textBody55);

            Shape shape56 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties56 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties68 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Footer Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties56 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks55 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties56.Append(shapeLocks55);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties68 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape55 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties68.Append(placeholderShape55);

            nonVisualShapeProperties56.Append(nonVisualDrawingProperties68);
            nonVisualShapeProperties56.Append(nonVisualShapeDrawingProperties56);
            nonVisualShapeProperties56.Append(applicationNonVisualDrawingProperties68);
            ShapeProperties shapeProperties56 = new ShapeProperties();

            TextBody textBody56 = new TextBody();
            A.BodyProperties bodyProperties56 = new A.BodyProperties();
            A.ListStyle listStyle56 = new A.ListStyle();

            A.Paragraph paragraph97 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties53 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph97.Append(endParagraphRunProperties53);

            textBody56.Append(bodyProperties56);
            textBody56.Append(listStyle56);
            textBody56.Append(paragraph97);

            shape56.Append(nonVisualShapeProperties56);
            shape56.Append(shapeProperties56);
            shape56.Append(textBody56);

            Shape shape57 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties57 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties69 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Slide Number Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties57 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks56 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties57.Append(shapeLocks56);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties69 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape56 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties69.Append(placeholderShape56);

            nonVisualShapeProperties57.Append(nonVisualDrawingProperties69);
            nonVisualShapeProperties57.Append(nonVisualShapeDrawingProperties57);
            nonVisualShapeProperties57.Append(applicationNonVisualDrawingProperties69);
            ShapeProperties shapeProperties57 = new ShapeProperties();

            TextBody textBody57 = new TextBody();
            A.BodyProperties bodyProperties57 = new A.BodyProperties();
            A.ListStyle listStyle57 = new A.ListStyle();

            A.Paragraph paragraph98 = new A.Paragraph();

            A.Field field21 = new A.Field(){ Id = "{9E0C3BFA-D4DA-4895-A0F6-B80859694A8D}", Type = "slidenum" };

            A.RunProperties runProperties86 = new A.RunProperties(){ Language = "en-US" };
            runProperties86.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text86 = new A.Text();
            text86.Text = "‹#›";

            field21.Append(runProperties86);
            field21.Append(text86);
            A.EndParagraphRunProperties endParagraphRunProperties54 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph98.Append(field21);
            paragraph98.Append(endParagraphRunProperties54);

            textBody57.Append(bodyProperties57);
            textBody57.Append(listStyle57);
            textBody57.Append(paragraph98);

            shape57.Append(nonVisualShapeProperties57);
            shape57.Append(shapeProperties57);
            shape57.Append(textBody57);

            shapeTree12.Append(nonVisualGroupShapeProperties12);
            shapeTree12.Append(groupShapeProperties12);
            shapeTree12.Append(shape53);
            shapeTree12.Append(shape54);
            shapeTree12.Append(shape55);
            shapeTree12.Append(shape56);
            shapeTree12.Append(shape57);

            commonSlideData12.Append(shapeTree12);

            ColorMapOverride colorMapOverride10 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping10 = new A.MasterColorMapping();

            colorMapOverride10.Append(masterColorMapping10);

            slideLayout9.Append(commonSlideData12);
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

            CommonSlideData commonSlideData13 = new CommonSlideData(){ Name = "Two Content" };

            ShapeTree shapeTree13 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties13 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties70 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties13 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties70 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties13.Append(nonVisualDrawingProperties70);
            nonVisualGroupShapeProperties13.Append(nonVisualGroupShapeDrawingProperties13);
            nonVisualGroupShapeProperties13.Append(applicationNonVisualDrawingProperties70);

            GroupShapeProperties groupShapeProperties13 = new GroupShapeProperties();

            A.TransformGroup transformGroup13 = new A.TransformGroup();
            A.Offset offset38 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents38 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset13 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents13 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup13.Append(offset38);
            transformGroup13.Append(extents38);
            transformGroup13.Append(childOffset13);
            transformGroup13.Append(childExtents13);

            groupShapeProperties13.Append(transformGroup13);

            Shape shape58 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties58 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties71 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties58 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks57 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties58.Append(shapeLocks57);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties71 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape57 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties71.Append(placeholderShape57);

            nonVisualShapeProperties58.Append(nonVisualDrawingProperties71);
            nonVisualShapeProperties58.Append(nonVisualShapeDrawingProperties58);
            nonVisualShapeProperties58.Append(applicationNonVisualDrawingProperties71);
            ShapeProperties shapeProperties58 = new ShapeProperties();

            TextBody textBody58 = new TextBody();
            A.BodyProperties bodyProperties58 = new A.BodyProperties();
            A.ListStyle listStyle58 = new A.ListStyle();

            A.Paragraph paragraph99 = new A.Paragraph();

            A.Run run66 = new A.Run();

            A.RunProperties runProperties87 = new A.RunProperties(){ Language = "en-US" };
            runProperties87.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text87 = new A.Text();
            text87.Text = "Click to edit Master title style";

            run66.Append(runProperties87);
            run66.Append(text87);
            A.EndParagraphRunProperties endParagraphRunProperties55 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph99.Append(run66);
            paragraph99.Append(endParagraphRunProperties55);

            textBody58.Append(bodyProperties58);
            textBody58.Append(listStyle58);
            textBody58.Append(paragraph99);

            shape58.Append(nonVisualShapeProperties58);
            shape58.Append(shapeProperties58);
            shape58.Append(textBody58);

            Shape shape59 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties59 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties72 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Content Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties59 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks58 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties59.Append(shapeLocks58);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties72 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape58 = new PlaceholderShape(){ Size = PlaceholderSizeValues.Half, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties72.Append(placeholderShape58);

            nonVisualShapeProperties59.Append(nonVisualDrawingProperties72);
            nonVisualShapeProperties59.Append(nonVisualShapeDrawingProperties59);
            nonVisualShapeProperties59.Append(applicationNonVisualDrawingProperties72);

            ShapeProperties shapeProperties59 = new ShapeProperties();

            A.Transform2D transform2D26 = new A.Transform2D();
            A.Offset offset39 = new A.Offset(){ X = 342901L, Y = 2133601L };
            A.Extents extents39 = new A.Extents(){ Cx = 3009900L, Cy = 6034088L };

            transform2D26.Append(offset39);
            transform2D26.Append(extents39);

            shapeProperties59.Append(transform2D26);

            TextBody textBody59 = new TextBody();
            A.BodyProperties bodyProperties59 = new A.BodyProperties();

            A.ListStyle listStyle59 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties23 = new A.Level1ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties121 = new A.DefaultRunProperties(){ FontSize = 2800 };

            level1ParagraphProperties23.Append(defaultRunProperties121);

            A.Level2ParagraphProperties level2ParagraphProperties13 = new A.Level2ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties122 = new A.DefaultRunProperties(){ FontSize = 2400 };

            level2ParagraphProperties13.Append(defaultRunProperties122);

            A.Level3ParagraphProperties level3ParagraphProperties13 = new A.Level3ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties123 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level3ParagraphProperties13.Append(defaultRunProperties123);

            A.Level4ParagraphProperties level4ParagraphProperties13 = new A.Level4ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties124 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level4ParagraphProperties13.Append(defaultRunProperties124);

            A.Level5ParagraphProperties level5ParagraphProperties13 = new A.Level5ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties125 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level5ParagraphProperties13.Append(defaultRunProperties125);

            A.Level6ParagraphProperties level6ParagraphProperties13 = new A.Level6ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties126 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level6ParagraphProperties13.Append(defaultRunProperties126);

            A.Level7ParagraphProperties level7ParagraphProperties13 = new A.Level7ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties127 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level7ParagraphProperties13.Append(defaultRunProperties127);

            A.Level8ParagraphProperties level8ParagraphProperties13 = new A.Level8ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties128 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level8ParagraphProperties13.Append(defaultRunProperties128);

            A.Level9ParagraphProperties level9ParagraphProperties13 = new A.Level9ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties129 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level9ParagraphProperties13.Append(defaultRunProperties129);

            listStyle59.Append(level1ParagraphProperties23);
            listStyle59.Append(level2ParagraphProperties13);
            listStyle59.Append(level3ParagraphProperties13);
            listStyle59.Append(level4ParagraphProperties13);
            listStyle59.Append(level5ParagraphProperties13);
            listStyle59.Append(level6ParagraphProperties13);
            listStyle59.Append(level7ParagraphProperties13);
            listStyle59.Append(level8ParagraphProperties13);
            listStyle59.Append(level9ParagraphProperties13);

            A.Paragraph paragraph100 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties53 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run67 = new A.Run();

            A.RunProperties runProperties88 = new A.RunProperties(){ Language = "en-US" };
            runProperties88.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text88 = new A.Text();
            text88.Text = "Click to edit Master text styles";

            run67.Append(runProperties88);
            run67.Append(text88);

            paragraph100.Append(paragraphProperties53);
            paragraph100.Append(run67);

            A.Paragraph paragraph101 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties54 = new A.ParagraphProperties(){ Level = 1 };

            A.Run run68 = new A.Run();

            A.RunProperties runProperties89 = new A.RunProperties(){ Language = "en-US" };
            runProperties89.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text89 = new A.Text();
            text89.Text = "Second level";

            run68.Append(runProperties89);
            run68.Append(text89);

            paragraph101.Append(paragraphProperties54);
            paragraph101.Append(run68);

            A.Paragraph paragraph102 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties55 = new A.ParagraphProperties(){ Level = 2 };

            A.Run run69 = new A.Run();

            A.RunProperties runProperties90 = new A.RunProperties(){ Language = "en-US" };
            runProperties90.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text90 = new A.Text();
            text90.Text = "Third level";

            run69.Append(runProperties90);
            run69.Append(text90);

            paragraph102.Append(paragraphProperties55);
            paragraph102.Append(run69);

            A.Paragraph paragraph103 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties56 = new A.ParagraphProperties(){ Level = 3 };

            A.Run run70 = new A.Run();

            A.RunProperties runProperties91 = new A.RunProperties(){ Language = "en-US" };
            runProperties91.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text91 = new A.Text();
            text91.Text = "Fourth level";

            run70.Append(runProperties91);
            run70.Append(text91);

            paragraph103.Append(paragraphProperties56);
            paragraph103.Append(run70);

            A.Paragraph paragraph104 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties57 = new A.ParagraphProperties(){ Level = 4 };

            A.Run run71 = new A.Run();

            A.RunProperties runProperties92 = new A.RunProperties(){ Language = "en-US" };
            runProperties92.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text92 = new A.Text();
            text92.Text = "Fifth level";

            run71.Append(runProperties92);
            run71.Append(text92);
            A.EndParagraphRunProperties endParagraphRunProperties56 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph104.Append(paragraphProperties57);
            paragraph104.Append(run71);
            paragraph104.Append(endParagraphRunProperties56);

            textBody59.Append(bodyProperties59);
            textBody59.Append(listStyle59);
            textBody59.Append(paragraph100);
            textBody59.Append(paragraph101);
            textBody59.Append(paragraph102);
            textBody59.Append(paragraph103);
            textBody59.Append(paragraph104);

            shape59.Append(nonVisualShapeProperties59);
            shape59.Append(shapeProperties59);
            shape59.Append(textBody59);

            Shape shape60 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties60 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties73 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Content Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties60 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks59 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties60.Append(shapeLocks59);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties73 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape59 = new PlaceholderShape(){ Size = PlaceholderSizeValues.Half, Index = (UInt32Value)2U };

            applicationNonVisualDrawingProperties73.Append(placeholderShape59);

            nonVisualShapeProperties60.Append(nonVisualDrawingProperties73);
            nonVisualShapeProperties60.Append(nonVisualShapeDrawingProperties60);
            nonVisualShapeProperties60.Append(applicationNonVisualDrawingProperties73);

            ShapeProperties shapeProperties60 = new ShapeProperties();

            A.Transform2D transform2D27 = new A.Transform2D();
            A.Offset offset40 = new A.Offset(){ X = 3505201L, Y = 2133601L };
            A.Extents extents40 = new A.Extents(){ Cx = 3009900L, Cy = 6034088L };

            transform2D27.Append(offset40);
            transform2D27.Append(extents40);

            shapeProperties60.Append(transform2D27);

            TextBody textBody60 = new TextBody();
            A.BodyProperties bodyProperties60 = new A.BodyProperties();

            A.ListStyle listStyle60 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties24 = new A.Level1ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties130 = new A.DefaultRunProperties(){ FontSize = 2800 };

            level1ParagraphProperties24.Append(defaultRunProperties130);

            A.Level2ParagraphProperties level2ParagraphProperties14 = new A.Level2ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties131 = new A.DefaultRunProperties(){ FontSize = 2400 };

            level2ParagraphProperties14.Append(defaultRunProperties131);

            A.Level3ParagraphProperties level3ParagraphProperties14 = new A.Level3ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties132 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level3ParagraphProperties14.Append(defaultRunProperties132);

            A.Level4ParagraphProperties level4ParagraphProperties14 = new A.Level4ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties133 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level4ParagraphProperties14.Append(defaultRunProperties133);

            A.Level5ParagraphProperties level5ParagraphProperties14 = new A.Level5ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties134 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level5ParagraphProperties14.Append(defaultRunProperties134);

            A.Level6ParagraphProperties level6ParagraphProperties14 = new A.Level6ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties135 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level6ParagraphProperties14.Append(defaultRunProperties135);

            A.Level7ParagraphProperties level7ParagraphProperties14 = new A.Level7ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties136 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level7ParagraphProperties14.Append(defaultRunProperties136);

            A.Level8ParagraphProperties level8ParagraphProperties14 = new A.Level8ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties137 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level8ParagraphProperties14.Append(defaultRunProperties137);

            A.Level9ParagraphProperties level9ParagraphProperties14 = new A.Level9ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties138 = new A.DefaultRunProperties(){ FontSize = 1800 };

            level9ParagraphProperties14.Append(defaultRunProperties138);

            listStyle60.Append(level1ParagraphProperties24);
            listStyle60.Append(level2ParagraphProperties14);
            listStyle60.Append(level3ParagraphProperties14);
            listStyle60.Append(level4ParagraphProperties14);
            listStyle60.Append(level5ParagraphProperties14);
            listStyle60.Append(level6ParagraphProperties14);
            listStyle60.Append(level7ParagraphProperties14);
            listStyle60.Append(level8ParagraphProperties14);
            listStyle60.Append(level9ParagraphProperties14);

            A.Paragraph paragraph105 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties58 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run72 = new A.Run();

            A.RunProperties runProperties93 = new A.RunProperties(){ Language = "en-US" };
            runProperties93.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text93 = new A.Text();
            text93.Text = "Click to edit Master text styles";

            run72.Append(runProperties93);
            run72.Append(text93);

            paragraph105.Append(paragraphProperties58);
            paragraph105.Append(run72);

            A.Paragraph paragraph106 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties59 = new A.ParagraphProperties(){ Level = 1 };

            A.Run run73 = new A.Run();

            A.RunProperties runProperties94 = new A.RunProperties(){ Language = "en-US" };
            runProperties94.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text94 = new A.Text();
            text94.Text = "Second level";

            run73.Append(runProperties94);
            run73.Append(text94);

            paragraph106.Append(paragraphProperties59);
            paragraph106.Append(run73);

            A.Paragraph paragraph107 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties60 = new A.ParagraphProperties(){ Level = 2 };

            A.Run run74 = new A.Run();

            A.RunProperties runProperties95 = new A.RunProperties(){ Language = "en-US" };
            runProperties95.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text95 = new A.Text();
            text95.Text = "Third level";

            run74.Append(runProperties95);
            run74.Append(text95);

            paragraph107.Append(paragraphProperties60);
            paragraph107.Append(run74);

            A.Paragraph paragraph108 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties61 = new A.ParagraphProperties(){ Level = 3 };

            A.Run run75 = new A.Run();

            A.RunProperties runProperties96 = new A.RunProperties(){ Language = "en-US" };
            runProperties96.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text96 = new A.Text();
            text96.Text = "Fourth level";

            run75.Append(runProperties96);
            run75.Append(text96);

            paragraph108.Append(paragraphProperties61);
            paragraph108.Append(run75);

            A.Paragraph paragraph109 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties62 = new A.ParagraphProperties(){ Level = 4 };

            A.Run run76 = new A.Run();

            A.RunProperties runProperties97 = new A.RunProperties(){ Language = "en-US" };
            runProperties97.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text97 = new A.Text();
            text97.Text = "Fifth level";

            run76.Append(runProperties97);
            run76.Append(text97);
            A.EndParagraphRunProperties endParagraphRunProperties57 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph109.Append(paragraphProperties62);
            paragraph109.Append(run76);
            paragraph109.Append(endParagraphRunProperties57);

            textBody60.Append(bodyProperties60);
            textBody60.Append(listStyle60);
            textBody60.Append(paragraph105);
            textBody60.Append(paragraph106);
            textBody60.Append(paragraph107);
            textBody60.Append(paragraph108);
            textBody60.Append(paragraph109);

            shape60.Append(nonVisualShapeProperties60);
            shape60.Append(shapeProperties60);
            shape60.Append(textBody60);

            Shape shape61 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties61 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties74 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Date Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties61 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks60 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties61.Append(shapeLocks60);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties74 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape60 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties74.Append(placeholderShape60);

            nonVisualShapeProperties61.Append(nonVisualDrawingProperties74);
            nonVisualShapeProperties61.Append(nonVisualShapeDrawingProperties61);
            nonVisualShapeProperties61.Append(applicationNonVisualDrawingProperties74);
            ShapeProperties shapeProperties61 = new ShapeProperties();

            TextBody textBody61 = new TextBody();
            A.BodyProperties bodyProperties61 = new A.BodyProperties();
            A.ListStyle listStyle61 = new A.ListStyle();

            A.Paragraph paragraph110 = new A.Paragraph();

            A.Field field22 = new A.Field(){ Id = "{1A15D4F1-1D33-4170-8C9F-182CDE6BA6D1}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties98 = new A.RunProperties(){ Language = "en-US" };
            runProperties98.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text98 = new A.Text();
            text98.Text = "10/3/2012";

            field22.Append(runProperties98);
            field22.Append(text98);
            A.EndParagraphRunProperties endParagraphRunProperties58 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph110.Append(field22);
            paragraph110.Append(endParagraphRunProperties58);

            textBody61.Append(bodyProperties61);
            textBody61.Append(listStyle61);
            textBody61.Append(paragraph110);

            shape61.Append(nonVisualShapeProperties61);
            shape61.Append(shapeProperties61);
            shape61.Append(textBody61);

            Shape shape62 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties62 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties75 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Footer Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties62 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks61 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties62.Append(shapeLocks61);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties75 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape61 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties75.Append(placeholderShape61);

            nonVisualShapeProperties62.Append(nonVisualDrawingProperties75);
            nonVisualShapeProperties62.Append(nonVisualShapeDrawingProperties62);
            nonVisualShapeProperties62.Append(applicationNonVisualDrawingProperties75);
            ShapeProperties shapeProperties62 = new ShapeProperties();

            TextBody textBody62 = new TextBody();
            A.BodyProperties bodyProperties62 = new A.BodyProperties();
            A.ListStyle listStyle62 = new A.ListStyle();

            A.Paragraph paragraph111 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties59 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph111.Append(endParagraphRunProperties59);

            textBody62.Append(bodyProperties62);
            textBody62.Append(listStyle62);
            textBody62.Append(paragraph111);

            shape62.Append(nonVisualShapeProperties62);
            shape62.Append(shapeProperties62);
            shape62.Append(textBody62);

            Shape shape63 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties63 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties76 = new NonVisualDrawingProperties(){ Id = (UInt32Value)7U, Name = "Slide Number Placeholder 6" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties63 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks62 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties63.Append(shapeLocks62);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties76 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape62 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties76.Append(placeholderShape62);

            nonVisualShapeProperties63.Append(nonVisualDrawingProperties76);
            nonVisualShapeProperties63.Append(nonVisualShapeDrawingProperties63);
            nonVisualShapeProperties63.Append(applicationNonVisualDrawingProperties76);
            ShapeProperties shapeProperties63 = new ShapeProperties();

            TextBody textBody63 = new TextBody();
            A.BodyProperties bodyProperties63 = new A.BodyProperties();
            A.ListStyle listStyle63 = new A.ListStyle();

            A.Paragraph paragraph112 = new A.Paragraph();

            A.Field field23 = new A.Field(){ Id = "{9E0C3BFA-D4DA-4895-A0F6-B80859694A8D}", Type = "slidenum" };

            A.RunProperties runProperties99 = new A.RunProperties(){ Language = "en-US" };
            runProperties99.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text99 = new A.Text();
            text99.Text = "‹#›";

            field23.Append(runProperties99);
            field23.Append(text99);
            A.EndParagraphRunProperties endParagraphRunProperties60 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph112.Append(field23);
            paragraph112.Append(endParagraphRunProperties60);

            textBody63.Append(bodyProperties63);
            textBody63.Append(listStyle63);
            textBody63.Append(paragraph112);

            shape63.Append(nonVisualShapeProperties63);
            shape63.Append(shapeProperties63);
            shape63.Append(textBody63);

            shapeTree13.Append(nonVisualGroupShapeProperties13);
            shapeTree13.Append(groupShapeProperties13);
            shapeTree13.Append(shape58);
            shapeTree13.Append(shape59);
            shapeTree13.Append(shape60);
            shapeTree13.Append(shape61);
            shapeTree13.Append(shape62);
            shapeTree13.Append(shape63);

            commonSlideData13.Append(shapeTree13);

            ColorMapOverride colorMapOverride11 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping11 = new A.MasterColorMapping();

            colorMapOverride11.Append(masterColorMapping11);

            slideLayout10.Append(commonSlideData13);
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

            CommonSlideData commonSlideData14 = new CommonSlideData(){ Name = "Picture with Caption" };

            ShapeTree shapeTree14 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties14 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties77 = new NonVisualDrawingProperties(){ Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties14 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties77 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties14.Append(nonVisualDrawingProperties77);
            nonVisualGroupShapeProperties14.Append(nonVisualGroupShapeDrawingProperties14);
            nonVisualGroupShapeProperties14.Append(applicationNonVisualDrawingProperties77);

            GroupShapeProperties groupShapeProperties14 = new GroupShapeProperties();

            A.TransformGroup transformGroup14 = new A.TransformGroup();
            A.Offset offset41 = new A.Offset(){ X = 0L, Y = 0L };
            A.Extents extents41 = new A.Extents(){ Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset14 = new A.ChildOffset(){ X = 0L, Y = 0L };
            A.ChildExtents childExtents14 = new A.ChildExtents(){ Cx = 0L, Cy = 0L };

            transformGroup14.Append(offset41);
            transformGroup14.Append(extents41);
            transformGroup14.Append(childOffset14);
            transformGroup14.Append(childExtents14);

            groupShapeProperties14.Append(transformGroup14);

            Shape shape64 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties64 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties78 = new NonVisualDrawingProperties(){ Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties64 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks63 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties64.Append(shapeLocks63);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties78 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape63 = new PlaceholderShape(){ Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties78.Append(placeholderShape63);

            nonVisualShapeProperties64.Append(nonVisualDrawingProperties78);
            nonVisualShapeProperties64.Append(nonVisualShapeDrawingProperties64);
            nonVisualShapeProperties64.Append(applicationNonVisualDrawingProperties78);

            ShapeProperties shapeProperties64 = new ShapeProperties();

            A.Transform2D transform2D28 = new A.Transform2D();
            A.Offset offset42 = new A.Offset(){ X = 1792288L, Y = 4800601L };
            A.Extents extents42 = new A.Extents(){ Cx = 5486400L, Cy = 566738L };

            transform2D28.Append(offset42);
            transform2D28.Append(extents42);

            shapeProperties64.Append(transform2D28);

            TextBody textBody64 = new TextBody();
            A.BodyProperties bodyProperties64 = new A.BodyProperties(){ Anchor = A.TextAnchoringTypeValues.Bottom };

            A.ListStyle listStyle64 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties25 = new A.Level1ParagraphProperties(){ Alignment = A.TextAlignmentTypeValues.Left };
            A.DefaultRunProperties defaultRunProperties139 = new A.DefaultRunProperties(){ FontSize = 2000, Bold = true };

            level1ParagraphProperties25.Append(defaultRunProperties139);

            listStyle64.Append(level1ParagraphProperties25);

            A.Paragraph paragraph113 = new A.Paragraph();

            A.Run run77 = new A.Run();

            A.RunProperties runProperties100 = new A.RunProperties(){ Language = "en-US" };
            runProperties100.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text100 = new A.Text();
            text100.Text = "Click to edit Master title style";

            run77.Append(runProperties100);
            run77.Append(text100);
            A.EndParagraphRunProperties endParagraphRunProperties61 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph113.Append(run77);
            paragraph113.Append(endParagraphRunProperties61);

            textBody64.Append(bodyProperties64);
            textBody64.Append(listStyle64);
            textBody64.Append(paragraph113);

            shape64.Append(nonVisualShapeProperties64);
            shape64.Append(shapeProperties64);
            shape64.Append(textBody64);

            Shape shape65 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties65 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties79 = new NonVisualDrawingProperties(){ Id = (UInt32Value)3U, Name = "Picture Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties65 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks64 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties65.Append(shapeLocks64);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties79 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape64 = new PlaceholderShape(){ Type = PlaceholderValues.Picture, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties79.Append(placeholderShape64);

            nonVisualShapeProperties65.Append(nonVisualDrawingProperties79);
            nonVisualShapeProperties65.Append(nonVisualShapeDrawingProperties65);
            nonVisualShapeProperties65.Append(applicationNonVisualDrawingProperties79);

            ShapeProperties shapeProperties65 = new ShapeProperties();

            A.Transform2D transform2D29 = new A.Transform2D();
            A.Offset offset43 = new A.Offset(){ X = 1792288L, Y = 612775L };
            A.Extents extents43 = new A.Extents(){ Cx = 5486400L, Cy = 4114800L };

            transform2D29.Append(offset43);
            transform2D29.Append(extents43);

            shapeProperties65.Append(transform2D29);

            TextBody textBody65 = new TextBody();
            A.BodyProperties bodyProperties65 = new A.BodyProperties();

            A.ListStyle listStyle65 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties26 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0 };
            A.NoBullet noBullet47 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties140 = new A.DefaultRunProperties(){ FontSize = 3200 };

            level1ParagraphProperties26.Append(noBullet47);
            level1ParagraphProperties26.Append(defaultRunProperties140);

            A.Level2ParagraphProperties level2ParagraphProperties15 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Indent = 0 };
            A.NoBullet noBullet48 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties141 = new A.DefaultRunProperties(){ FontSize = 2800 };

            level2ParagraphProperties15.Append(noBullet48);
            level2ParagraphProperties15.Append(defaultRunProperties141);

            A.Level3ParagraphProperties level3ParagraphProperties15 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Indent = 0 };
            A.NoBullet noBullet49 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties142 = new A.DefaultRunProperties(){ FontSize = 2400 };

            level3ParagraphProperties15.Append(noBullet49);
            level3ParagraphProperties15.Append(defaultRunProperties142);

            A.Level4ParagraphProperties level4ParagraphProperties15 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Indent = 0 };
            A.NoBullet noBullet50 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties143 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level4ParagraphProperties15.Append(noBullet50);
            level4ParagraphProperties15.Append(defaultRunProperties143);

            A.Level5ParagraphProperties level5ParagraphProperties15 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Indent = 0 };
            A.NoBullet noBullet51 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties144 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level5ParagraphProperties15.Append(noBullet51);
            level5ParagraphProperties15.Append(defaultRunProperties144);

            A.Level6ParagraphProperties level6ParagraphProperties15 = new A.Level6ParagraphProperties(){ LeftMargin = 2286000, Indent = 0 };
            A.NoBullet noBullet52 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties145 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level6ParagraphProperties15.Append(noBullet52);
            level6ParagraphProperties15.Append(defaultRunProperties145);

            A.Level7ParagraphProperties level7ParagraphProperties15 = new A.Level7ParagraphProperties(){ LeftMargin = 2743200, Indent = 0 };
            A.NoBullet noBullet53 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties146 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level7ParagraphProperties15.Append(noBullet53);
            level7ParagraphProperties15.Append(defaultRunProperties146);

            A.Level8ParagraphProperties level8ParagraphProperties15 = new A.Level8ParagraphProperties(){ LeftMargin = 3200400, Indent = 0 };
            A.NoBullet noBullet54 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties147 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level8ParagraphProperties15.Append(noBullet54);
            level8ParagraphProperties15.Append(defaultRunProperties147);

            A.Level9ParagraphProperties level9ParagraphProperties15 = new A.Level9ParagraphProperties(){ LeftMargin = 3657600, Indent = 0 };
            A.NoBullet noBullet55 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties148 = new A.DefaultRunProperties(){ FontSize = 2000 };

            level9ParagraphProperties15.Append(noBullet55);
            level9ParagraphProperties15.Append(defaultRunProperties148);

            listStyle65.Append(level1ParagraphProperties26);
            listStyle65.Append(level2ParagraphProperties15);
            listStyle65.Append(level3ParagraphProperties15);
            listStyle65.Append(level4ParagraphProperties15);
            listStyle65.Append(level5ParagraphProperties15);
            listStyle65.Append(level6ParagraphProperties15);
            listStyle65.Append(level7ParagraphProperties15);
            listStyle65.Append(level8ParagraphProperties15);
            listStyle65.Append(level9ParagraphProperties15);

            A.Paragraph paragraph114 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties62 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph114.Append(endParagraphRunProperties62);

            textBody65.Append(bodyProperties65);
            textBody65.Append(listStyle65);
            textBody65.Append(paragraph114);

            shape65.Append(nonVisualShapeProperties65);
            shape65.Append(shapeProperties65);
            shape65.Append(textBody65);

            Shape shape66 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties66 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties80 = new NonVisualDrawingProperties(){ Id = (UInt32Value)4U, Name = "Text Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties66 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks65 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties66.Append(shapeLocks65);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties80 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape65 = new PlaceholderShape(){ Type = PlaceholderValues.Body, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)2U };

            applicationNonVisualDrawingProperties80.Append(placeholderShape65);

            nonVisualShapeProperties66.Append(nonVisualDrawingProperties80);
            nonVisualShapeProperties66.Append(nonVisualShapeDrawingProperties66);
            nonVisualShapeProperties66.Append(applicationNonVisualDrawingProperties80);

            ShapeProperties shapeProperties66 = new ShapeProperties();

            A.Transform2D transform2D30 = new A.Transform2D();
            A.Offset offset44 = new A.Offset(){ X = 1792288L, Y = 5367339L };
            A.Extents extents44 = new A.Extents(){ Cx = 5486400L, Cy = 804862L };

            transform2D30.Append(offset44);
            transform2D30.Append(extents44);

            shapeProperties66.Append(transform2D30);

            TextBody textBody66 = new TextBody();
            A.BodyProperties bodyProperties66 = new A.BodyProperties();

            A.ListStyle listStyle66 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties27 = new A.Level1ParagraphProperties(){ LeftMargin = 0, Indent = 0 };
            A.NoBullet noBullet56 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties149 = new A.DefaultRunProperties(){ FontSize = 1400 };

            level1ParagraphProperties27.Append(noBullet56);
            level1ParagraphProperties27.Append(defaultRunProperties149);

            A.Level2ParagraphProperties level2ParagraphProperties16 = new A.Level2ParagraphProperties(){ LeftMargin = 457200, Indent = 0 };
            A.NoBullet noBullet57 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties150 = new A.DefaultRunProperties(){ FontSize = 1200 };

            level2ParagraphProperties16.Append(noBullet57);
            level2ParagraphProperties16.Append(defaultRunProperties150);

            A.Level3ParagraphProperties level3ParagraphProperties16 = new A.Level3ParagraphProperties(){ LeftMargin = 914400, Indent = 0 };
            A.NoBullet noBullet58 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties151 = new A.DefaultRunProperties(){ FontSize = 1000 };

            level3ParagraphProperties16.Append(noBullet58);
            level3ParagraphProperties16.Append(defaultRunProperties151);

            A.Level4ParagraphProperties level4ParagraphProperties16 = new A.Level4ParagraphProperties(){ LeftMargin = 1371600, Indent = 0 };
            A.NoBullet noBullet59 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties152 = new A.DefaultRunProperties(){ FontSize = 900 };

            level4ParagraphProperties16.Append(noBullet59);
            level4ParagraphProperties16.Append(defaultRunProperties152);

            A.Level5ParagraphProperties level5ParagraphProperties16 = new A.Level5ParagraphProperties(){ LeftMargin = 1828800, Indent = 0 };
            A.NoBullet noBullet60 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties153 = new A.DefaultRunProperties(){ FontSize = 900 };

            level5ParagraphProperties16.Append(noBullet60);
            level5ParagraphProperties16.Append(defaultRunProperties153);

            A.Level6ParagraphProperties level6ParagraphProperties16 = new A.Level6ParagraphProperties(){ LeftMargin = 2286000, Indent = 0 };
            A.NoBullet noBullet61 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties154 = new A.DefaultRunProperties(){ FontSize = 900 };

            level6ParagraphProperties16.Append(noBullet61);
            level6ParagraphProperties16.Append(defaultRunProperties154);

            A.Level7ParagraphProperties level7ParagraphProperties16 = new A.Level7ParagraphProperties(){ LeftMargin = 2743200, Indent = 0 };
            A.NoBullet noBullet62 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties155 = new A.DefaultRunProperties(){ FontSize = 900 };

            level7ParagraphProperties16.Append(noBullet62);
            level7ParagraphProperties16.Append(defaultRunProperties155);

            A.Level8ParagraphProperties level8ParagraphProperties16 = new A.Level8ParagraphProperties(){ LeftMargin = 3200400, Indent = 0 };
            A.NoBullet noBullet63 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties156 = new A.DefaultRunProperties(){ FontSize = 900 };

            level8ParagraphProperties16.Append(noBullet63);
            level8ParagraphProperties16.Append(defaultRunProperties156);

            A.Level9ParagraphProperties level9ParagraphProperties16 = new A.Level9ParagraphProperties(){ LeftMargin = 3657600, Indent = 0 };
            A.NoBullet noBullet64 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties157 = new A.DefaultRunProperties(){ FontSize = 900 };

            level9ParagraphProperties16.Append(noBullet64);
            level9ParagraphProperties16.Append(defaultRunProperties157);

            listStyle66.Append(level1ParagraphProperties27);
            listStyle66.Append(level2ParagraphProperties16);
            listStyle66.Append(level3ParagraphProperties16);
            listStyle66.Append(level4ParagraphProperties16);
            listStyle66.Append(level5ParagraphProperties16);
            listStyle66.Append(level6ParagraphProperties16);
            listStyle66.Append(level7ParagraphProperties16);
            listStyle66.Append(level8ParagraphProperties16);
            listStyle66.Append(level9ParagraphProperties16);

            A.Paragraph paragraph115 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties63 = new A.ParagraphProperties(){ Level = 0 };

            A.Run run78 = new A.Run();

            A.RunProperties runProperties101 = new A.RunProperties(){ Language = "en-US" };
            runProperties101.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text101 = new A.Text();
            text101.Text = "Click to edit Master text styles";

            run78.Append(runProperties101);
            run78.Append(text101);

            paragraph115.Append(paragraphProperties63);
            paragraph115.Append(run78);

            textBody66.Append(bodyProperties66);
            textBody66.Append(listStyle66);
            textBody66.Append(paragraph115);

            shape66.Append(nonVisualShapeProperties66);
            shape66.Append(shapeProperties66);
            shape66.Append(textBody66);

            Shape shape67 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties67 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties81 = new NonVisualDrawingProperties(){ Id = (UInt32Value)5U, Name = "Date Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties67 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks66 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties67.Append(shapeLocks66);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties81 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape66 = new PlaceholderShape(){ Type = PlaceholderValues.DateAndTime, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)10U };

            applicationNonVisualDrawingProperties81.Append(placeholderShape66);

            nonVisualShapeProperties67.Append(nonVisualDrawingProperties81);
            nonVisualShapeProperties67.Append(nonVisualShapeDrawingProperties67);
            nonVisualShapeProperties67.Append(applicationNonVisualDrawingProperties81);
            ShapeProperties shapeProperties67 = new ShapeProperties();

            TextBody textBody67 = new TextBody();
            A.BodyProperties bodyProperties67 = new A.BodyProperties();
            A.ListStyle listStyle67 = new A.ListStyle();

            A.Paragraph paragraph116 = new A.Paragraph();

            A.Field field24 = new A.Field(){ Id = "{1A15D4F1-1D33-4170-8C9F-182CDE6BA6D1}", Type = "datetimeFigureOut" };

            A.RunProperties runProperties102 = new A.RunProperties(){ Language = "en-US" };
            runProperties102.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text102 = new A.Text();
            text102.Text = "10/3/2012";

            field24.Append(runProperties102);
            field24.Append(text102);
            A.EndParagraphRunProperties endParagraphRunProperties63 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph116.Append(field24);
            paragraph116.Append(endParagraphRunProperties63);

            textBody67.Append(bodyProperties67);
            textBody67.Append(listStyle67);
            textBody67.Append(paragraph116);

            shape67.Append(nonVisualShapeProperties67);
            shape67.Append(shapeProperties67);
            shape67.Append(textBody67);

            Shape shape68 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties68 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties82 = new NonVisualDrawingProperties(){ Id = (UInt32Value)6U, Name = "Footer Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties68 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks67 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties68.Append(shapeLocks67);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties82 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape67 = new PlaceholderShape(){ Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)11U };

            applicationNonVisualDrawingProperties82.Append(placeholderShape67);

            nonVisualShapeProperties68.Append(nonVisualDrawingProperties82);
            nonVisualShapeProperties68.Append(nonVisualShapeDrawingProperties68);
            nonVisualShapeProperties68.Append(applicationNonVisualDrawingProperties82);
            ShapeProperties shapeProperties68 = new ShapeProperties();

            TextBody textBody68 = new TextBody();
            A.BodyProperties bodyProperties68 = new A.BodyProperties();
            A.ListStyle listStyle68 = new A.ListStyle();

            A.Paragraph paragraph117 = new A.Paragraph();
            A.EndParagraphRunProperties endParagraphRunProperties64 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph117.Append(endParagraphRunProperties64);

            textBody68.Append(bodyProperties68);
            textBody68.Append(listStyle68);
            textBody68.Append(paragraph117);

            shape68.Append(nonVisualShapeProperties68);
            shape68.Append(shapeProperties68);
            shape68.Append(textBody68);

            Shape shape69 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties69 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties83 = new NonVisualDrawingProperties(){ Id = (UInt32Value)7U, Name = "Slide Number Placeholder 6" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties69 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks68 = new A.ShapeLocks(){ NoGrouping = true };

            nonVisualShapeDrawingProperties69.Append(shapeLocks68);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties83 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape68 = new PlaceholderShape(){ Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)12U };

            applicationNonVisualDrawingProperties83.Append(placeholderShape68);

            nonVisualShapeProperties69.Append(nonVisualDrawingProperties83);
            nonVisualShapeProperties69.Append(nonVisualShapeDrawingProperties69);
            nonVisualShapeProperties69.Append(applicationNonVisualDrawingProperties83);
            ShapeProperties shapeProperties69 = new ShapeProperties();

            TextBody textBody69 = new TextBody();
            A.BodyProperties bodyProperties69 = new A.BodyProperties();
            A.ListStyle listStyle69 = new A.ListStyle();

            A.Paragraph paragraph118 = new A.Paragraph();

            A.Field field25 = new A.Field(){ Id = "{9E0C3BFA-D4DA-4895-A0F6-B80859694A8D}", Type = "slidenum" };

            A.RunProperties runProperties103 = new A.RunProperties(){ Language = "en-US" };
            runProperties103.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.Text text103 = new A.Text();
            text103.Text = "‹#›";

            field25.Append(runProperties103);
            field25.Append(text103);
            A.EndParagraphRunProperties endParagraphRunProperties65 = new A.EndParagraphRunProperties(){ Language = "en-US" };

            paragraph118.Append(field25);
            paragraph118.Append(endParagraphRunProperties65);

            textBody69.Append(bodyProperties69);
            textBody69.Append(listStyle69);
            textBody69.Append(paragraph118);

            shape69.Append(nonVisualShapeProperties69);
            shape69.Append(shapeProperties69);
            shape69.Append(textBody69);

            shapeTree14.Append(nonVisualGroupShapeProperties14);
            shapeTree14.Append(groupShapeProperties14);
            shapeTree14.Append(shape64);
            shapeTree14.Append(shape65);
            shapeTree14.Append(shape66);
            shapeTree14.Append(shape67);
            shapeTree14.Append(shape68);
            shapeTree14.Append(shape69);

            commonSlideData14.Append(shapeTree14);

            ColorMapOverride colorMapOverride12 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping12 = new A.MasterColorMapping();

            colorMapOverride12.Append(masterColorMapping12);

            slideLayout11.Append(commonSlideData14);
            slideLayout11.Append(colorMapOverride12);

            slideLayoutPart11.SlideLayout = slideLayout11;
        }

        // Generates content of viewPropertiesPart1.
        private void GenerateViewPropertiesPart1Content(ViewPropertiesPart viewPropertiesPart1)
        {
            ViewProperties viewProperties1 = new ViewProperties();
            viewProperties1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            viewProperties1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            viewProperties1.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            NormalViewProperties normalViewProperties1 = new NormalViewProperties();
            RestoredLeft restoredLeft1 = new RestoredLeft(){ Size = 15620 };
            RestoredTop restoredTop1 = new RestoredTop(){ Size = 94660 };

            normalViewProperties1.Append(restoredLeft1);
            normalViewProperties1.Append(restoredTop1);

            SlideViewProperties slideViewProperties1 = new SlideViewProperties();

            CommonSlideViewProperties commonSlideViewProperties1 = new CommonSlideViewProperties();

            CommonViewProperties commonViewProperties1 = new CommonViewProperties(){ VariableScale = true };

            ScaleFactor scaleFactor1 = new ScaleFactor();
            A.ScaleX scaleX1 = new A.ScaleX(){ Numerator = 77, Denominator = 100 };
            A.ScaleY scaleY1 = new A.ScaleY(){ Numerator = 77, Denominator = 100 };

            scaleFactor1.Append(scaleX1);
            scaleFactor1.Append(scaleY1);
            Origin origin1 = new Origin(){ X = 1122L, Y = 72L };

            commonViewProperties1.Append(scaleFactor1);
            commonViewProperties1.Append(origin1);

            GuideList guideList1 = new GuideList();
            Guide guide1 = new Guide(){ Orientation = DirectionValues.Horizontal, Position = 2160 };
            Guide guide2 = new Guide(){ Position = 2880 };

            guideList1.Append(guide1);
            guideList1.Append(guide2);

            commonSlideViewProperties1.Append(commonViewProperties1);
            commonSlideViewProperties1.Append(guideList1);

            slideViewProperties1.Append(commonSlideViewProperties1);

            NotesTextViewProperties notesTextViewProperties1 = new NotesTextViewProperties();

            CommonViewProperties commonViewProperties2 = new CommonViewProperties();

            ScaleFactor scaleFactor2 = new ScaleFactor();
            A.ScaleX scaleX2 = new A.ScaleX(){ Numerator = 100, Denominator = 100 };
            A.ScaleY scaleY2 = new A.ScaleY(){ Numerator = 100, Denominator = 100 };

            scaleFactor2.Append(scaleX2);
            scaleFactor2.Append(scaleY2);
            Origin origin2 = new Origin(){ X = 0L, Y = 0L };

            commonViewProperties2.Append(scaleFactor2);
            commonViewProperties2.Append(origin2);

            notesTextViewProperties1.Append(commonViewProperties2);

            NotesViewProperties notesViewProperties1 = new NotesViewProperties();

            CommonSlideViewProperties commonSlideViewProperties2 = new CommonSlideViewProperties();

            CommonViewProperties commonViewProperties3 = new CommonViewProperties(){ VariableScale = true };

            ScaleFactor scaleFactor3 = new ScaleFactor();
            A.ScaleX scaleX3 = new A.ScaleX(){ Numerator = 111, Denominator = 100 };
            A.ScaleY scaleY3 = new A.ScaleY(){ Numerator = 111, Denominator = 100 };

            scaleFactor3.Append(scaleX3);
            scaleFactor3.Append(scaleY3);
            Origin origin3 = new Origin(){ X = -582L, Y = -78L };

            commonViewProperties3.Append(scaleFactor3);
            commonViewProperties3.Append(origin3);

            GuideList guideList2 = new GuideList();
            Guide guide3 = new Guide(){ Orientation = DirectionValues.Horizontal, Position = 2160 };
            Guide guide4 = new Guide(){ Position = 2880 };

            guideList2.Append(guide3);
            guideList2.Append(guide4);

            commonSlideViewProperties2.Append(commonViewProperties3);
            commonSlideViewProperties2.Append(guideList2);

            notesViewProperties1.Append(commonSlideViewProperties2);
            GridSpacing gridSpacing1 = new GridSpacing(){ Cx = 76200L, Cy = 76200L };

            viewProperties1.Append(normalViewProperties1);
            viewProperties1.Append(slideViewProperties1);
            viewProperties1.Append(notesTextViewProperties1);
            viewProperties1.Append(notesViewProperties1);
            viewProperties1.Append(gridSpacing1);

            viewPropertiesPart1.ViewProperties = viewProperties1;
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

            P15.ChartTrackingReferenceBased chartTrackingReferenceBased1 = new P15.ChartTrackingReferenceBased(){ Val = false };
            chartTrackingReferenceBased1.AddNamespaceDeclaration("p15", "http://schemas.microsoft.com/office/powerpoint/2012/main");

            presentationPropertiesExtension3.Append(chartTrackingReferenceBased1);

            presentationPropertiesExtensionList1.Append(presentationPropertiesExtension1);
            presentationPropertiesExtensionList1.Append(presentationPropertiesExtension2);
            presentationPropertiesExtensionList1.Append(presentationPropertiesExtension3);

            presentationProperties1.Append(presentationPropertiesExtensionList1);

            presentationPropertiesPart1.PresentationProperties = presentationProperties1;
        }

        // Generates content of extendedFilePropertiesPart1.
        private void GenerateExtendedFilePropertiesPart1Content(ExtendedFilePropertiesPart extendedFilePropertiesPart1)
        {
            Ap.Properties properties1 = new Ap.Properties();
            properties1.AddNamespaceDeclaration("vt", "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes");
            Ap.TotalTime totalTime1 = new Ap.TotalTime();
            totalTime1.Text = "10";
            Ap.Words words1 = new Ap.Words();
            words1.Text = "37";
            Ap.Application application1 = new Ap.Application();
            application1.Text = "Microsoft Office PowerPoint";
            Ap.PresentationFormat presentationFormat1 = new Ap.PresentationFormat();
            presentationFormat1.Text = "On-screen Show (4:3)";
            Ap.Paragraphs paragraphs1 = new Ap.Paragraphs();
            paragraphs1.Text = "9";
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
            vTLPSTR6.Text = "Century Gothic";
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
            Ap.Company company1 = new Ap.Company();
            company1.Text = "Microsoft";
            Ap.LinksUpToDate linksUpToDate1 = new Ap.LinksUpToDate();
            linksUpToDate1.Text = "false";
            Ap.SharedDocument sharedDocument1 = new Ap.SharedDocument();
            sharedDocument1.Text = "false";
            Ap.HyperlinksChanged hyperlinksChanged1 = new Ap.HyperlinksChanged();
            hyperlinksChanged1.Text = "false";
            Ap.ApplicationVersion applicationVersion1 = new Ap.ApplicationVersion();
            applicationVersion1.Text = "15.0000";

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
            properties1.Append(company1);
            properties1.Append(linksUpToDate1);
            properties1.Append(sharedDocument1);
            properties1.Append(hyperlinksChanged1);
            properties1.Append(applicationVersion1);

            extendedFilePropertiesPart1.Properties = properties1;
        }

        private void SetPackageProperties(OpenXmlPackage document)
        {
            document.PackageProperties.Creator = "aanchals";
            document.PackageProperties.Title = "Slide 1";
            document.PackageProperties.Revision = "2";
            document.PackageProperties.Created = System.Xml.XmlConvert.ToDateTime("2008-01-03T22:28:03Z", System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
            document.PackageProperties.Modified = System.Xml.XmlConvert.ToDateTime("2012-10-03T08:41:17Z", System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
            document.PackageProperties.LastModifiedBy = "Dan Ito";
        }

        #region Binary Data
        private string thumbnailPart1Data = "/9j/4AAQSkZJRgABAQEAYABgAAD/2wBDAAEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQH/2wBDAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQH/wAARCADAAQADASIAAhEBAxEB/8QAHwAAAQUBAQEBAQEAAAAAAAAAAAECAwQFBgcICQoL/8QAtRAAAgEDAwIEAwUFBAQAAAF9AQIDAAQRBRIhMUEGE1FhByJxFDKBkaEII0KxwRVS0fAkM2JyggkKFhcYGRolJicoKSo0NTY3ODk6Q0RFRkdISUpTVFVWV1hZWmNkZWZnaGlqc3R1dnd4eXqDhIWGh4iJipKTlJWWl5iZmqKjpKWmp6ipqrKztLW2t7i5usLDxMXGx8jJytLT1NXW19jZ2uHi4+Tl5ufo6erx8vP09fb3+Pn6/8QAHwEAAwEBAQEBAQEBAQAAAAAAAAECAwQFBgcICQoL/8QAtREAAgECBAQDBAcFBAQAAQJ3AAECAxEEBSExBhJBUQdhcRMiMoEIFEKRobHBCSMzUvAVYnLRChYkNOEl8RcYGRomJygpKjU2Nzg5OkNERUZHSElKU1RVVldYWVpjZGVmZ2hpanN0dXZ3eHl6goOEhYaHiImKkpOUlZaXmJmaoqOkpaanqKmqsrO0tba3uLm6wsPExcbHyMnK0tPU1dbX2Nna4uPk5ebn6Onq8vP09fb3+Pn6/9oADAMBAAIRAxEAPwD+/iiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKK/FLWf+CTfxEPhH4123wy/ai8N/s3fFL4m6V8Q/Dmi/Fn9l74PfF74CahdW/j7RPEWnzfFb9oLw78Pf2v9I0/9pH9qy11rUfDfi+f9pDW7vwXrp13wjHH4e8M+FtI8U+MNM1rKrOpCNaUKMq3s8HjK9OEJwjUr4ujCLwmBpqrKFKMsZUk4PEVqtKhhowlOo5NxhLWEKcox5qqpzeLwFG0oTcI4bEYqFLG4yc4KcrZfhpTxboQpzq4r2fsKKVSUWftbRX4vfEv9gb9tZ/H/AMCL74Y/tjeMNY8Kx+IZ9U/aN8SeMvjz+1L4F8TWOo6N4N1rw74M8bfBn4Z+EvH3i74UeJHF3deG28Y/BP4ixaP8FPE8XhzVfEuqaNqPxM8Xjxz4Y+jf2Bv2OP2hf2S9N1jT/jz+278RP20Lm7+F/wAGPh7pGv8AxG0n4g6Prmn6n8MY/HH/AAk3jPUIvEnx2+KnhjUNd+Ik/i3Tv7W1fTPDHh7xldWvhXR4fHXjT4kXNtpl9pHTGNOTx37z3cNi6WGw03CaWYU5YNV8RiqEJKNalQw+IlDCJ4qlReJc/a0Of2WJp0OXnqJYe9GXNWw1WvVjz02sNUhmccHTw9ScZShOeIwarZnT9m5Sp0aUaOKp4etiMMqv6KUV+S/xC/4JvfGvWfDfiCw+Fv8AwUC/aP8Ahn4t8XfEr4S+PfEPjHWPiF+0h8TUtbD4deM/CXjnxF4U8DeE9f8A2ptP8N/D7R/iPqWn+PtE8RaP4dtI/BMvgf4hx+B9V8Ea/wCG/h/4CsdFl+Af/BPT9oz4P/tQeHPj34i/b9+JHjjwBaan+0BrHjz9n2DQPifB4H+KusfGDTvAWk+D/Eni/U/iV+0h8Y7yLxH8LrLwHaNpEejWGn+CdIN7PoPwb8D/AAN+HzXngbUMsO3VVB1ovCyq0cwlWU2qv1bEYTC4Wtg6U3R5/aUs0xNTF4TD16KnLDywtOtjqGHpYm9HTEN03V9hF4hRqYFUrNUpVaWJxFWli5uNR8tOpltGNHE1qTnKOIhUnTwlavWpKFT9Y6K/ND4R/sFfEr4cX/xI0fXf2rfH/jL4WeNvgJ4v+CeieDrnXf2kZ/EnhS88S+IdW1Gw8d2/ivx7+1j8SvDkXiDQNH1a8trbWPB3w68B+PpdZ1K/SH4h2Pwy0L4W/Cf4ZeeaB/wTV+M/gzx3+zz4r8Bft8fHLwT4d+GPxk8OfF340/DOy1T4xeL/AAP+0EuleHPG/hnW/A11a/Fb9or4iah4H8IeKbPxJ4evtb02S/8AGtvrXijwrL8SfF1v4s+LuvS/ETT3S9+cVV/dQlVwVNz/AIjpxxGb1cFiq9SMbfuMvyqFPOqqpuriK8ayy/C4eri4Tsq8pU4KVGDxE+bHuVO8aTUMPk9PHYLllNuEquYZrKpkkYScKeFqU/7Qr11gpqa/XKivzw+P37Dfiz4qeNviT8R/hz+0Frvwh8WfETRJ9IuRa6R45n0q1ltfAOm+BfDeoLqPw1+MnwY+Jeg6lpNrJ42jvfEXws+Jfwt8caho3jZ7HTvGGga/4S8HeLNG+PfF3/BKL9rvULy2uPh//wAFVvjl8OrKbwB8WPDfifw9DYfH/X9D8Y+OPizH8N5r34m6hcTftl6Z4t8N614U1Hwf4kfwPafDzxZ4Lk8Kaf4ogXQtU0/xHJ8TPFPxcVFupX9nVToUXQr1FiG1USr0/rbpYedKHvxWJVDDqFaHtI05Y6iq0YRo4qVGqloQpyp3qyljsLQqU0uSVPBVo0PrOPTm1Cf1OpVrKWFUlVr0sNOpRk6lSlQn+6NFfDH7Sv7FcX7RWu3usT/Ed/CcOv8Awil+Cni3Th4TbxFH4i8DXN7r/ie90ya4uvFOnyxQ6j47Hw81rUEuBfveeHvCGv8AhKeZl8cz6xoPxRo//BLD9rAeKdL8Q+Mv+Cnnxi8YWnhvxd8YvG3hHSFtv2lNCh8Ma18T/i0/jvw3bqlr+27daV4x0D4P+C7q8+Hnw88PfE7RPHemWkC2H2+G6+HzeI/hV4nzc6inSj7CbjKOYSrVFOnam8LVpfU4U4uanVlmeHqylRclShhsTh8Rh8XKlQ+rY3ElnyYiTceaFPASw9NOTdepicBOti6c5cijQWW5hD6jWneqsRRq0cdhFWvXwuH/AG+or4D/AGMP2Ovix+zJ4Q+Hel/F39rv4tftZ+PfCfgPS/Afin4kfE/XPi1ay+M7bQrAxaRrH/CBXvxy8W/DvT/Er6jfa5e+IvGet+G/F/xC8WWtxoVhrnjS5k8L2F/L9+V1V4U6datTo1liKVOrUhTxEYTpwr04TlGFaEKqjVhGrBRmoVYQqR5uWcU0zKjOpUpU51KMqE50qM50ZypzqUqk6NOdajOVKU6TlRryqUVOlUqQqxpxrRcfaezgUUUVkahRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFfnp+xj4M8E6Vr/jPWfhr8bf2Zvip4Th8UfH+SaH9mbSNJ8MaNY6r8Rf2ifF3jvUfDPjPw3ofxH+KGmP4n+Fvi8ePdB1nxXF4g0m58UePfFPxIn1LwN4L1O0vLO+Kfv4mFB+7CWHxmInW+JU1haSlTi6Ub1WsTiKlDCqqo+xozrRlWqQ5qcKhV/d4WWIiueccbgcM6T9yKpYuVaNTEOq7pyoyp0oww0IzrV3Wc0oUMPia1L9C6K/JX9sr9i/xH8ffiX8TPFek/t2XPwRvdV+EvhHw34x+Fs+lzWngvRvgB4d17U/EMniXxJc/Cz4xfAH47Nqup+NU8eSt4t1n40xfBC/0CNvAPi74MeMfD9t8Q7Xx74pF/wAEwv2pbzx9418T+Gv+CqHxC0+zvP8AhoPS/H3w00PSfj8/hPXPGHxp0X4VTeE9a+ImoW/7b/8AwtfQ/FPw+8IeE9IawT4YfEr4PXHhzRPFqx/s4J+zN4SntNDuclUm6KqOnabw2eV+T2kXCNTLlH+zKE6q0Szit7TByrwhOlleLpqGMfsJfWYudo1pU43nGFTKIylblnyY+V8fP2UmpJ5Vh5UcZyScXmGGqp4NyqqNKf7q0V8J+L/2a5fHH7Lv7N3wj8JftEX/AIP1n4X2Pwek8EfGfwbq/jewh8a33gr4e3Hhq21ewsfDPxi0LU/E1n4j0e5vfFejeHvFPj/4h+Eb2/tdKufHei/FPw7aatpGueEfBH9gH42fCvwV+z74W+NX7f3xU/aD8RfCHxF8IL6Lxj45v/jH4R1X4la98OpNSfXpPEUHh/8AaZjuPEmq/EHw5ealp+p6b4q1Hxn4fnPhvwpq3ijwx42H/C2rb4u9XJD63XoOpy4elnGGwNPFSpyvXy2rSqzr5rHDq9SnPC1oUqFTLarhiKv1qhUoTqRVdUMZzqRoRqKi5V3kGLzSdD2kIqlmWHq1YUconVk1F0sVSpSrRzeClg6PssTTrxpyox9r+sdFfnv4D/ZG+IXhf9p1Pjh4e/ak8Rar8LI/H/xt8UeIfgrd6v8AH3xDa3uqfEy0hgm8P/aNT/an1T4NadaeEfE8H22DTLn9nm/j8OWWi6JpXwztPhVrmqfFzxR8Wfkjwz+xL47+Ldl8O/Ff7Mn/AAVv8b6/4V+Ffx+1/UvHkvgLT/hl4l8IeLLXwZ8N9c+E0/7LHiXUf2cPFnwbkg8FfC/xBqT6omkeN9Z8a/FnRdThaPxP40vvHemeE/HXhPklOqsPhZwouriquEw+KxWEhUgnhHUxuDwmJh7abjCvDCUsZHFvEQUaNanTdCD+uVsJh8RtaKxGOpyly4fD43G4TCYlr/flh6GMrYaXsfjwtbFzwcsO8LWftcLVqc9W+HoYqvQ/b+ivwKi/4JPftgap4R+HGmWf/BXr4zv46+GngP4SfDLUvjXpfh74v6j8RfFEnww+Lfgz4gfES08QJrn7YPiPwHbw/E2HwNb+F/F8kXgsfE3Wjf32n/F74mfF7wFYaF8NtG/bD4UeAJfhj4E0bwfc+KvFPjfULKTVdQ1jxX4x8R+KvFGta5rmv6vfa/rd6Lzxj4j8VarpmkvqmpXa6B4UtNYbw54M0NdP8KeErDSPDGj6TpNl1ONNQnJVeaUcbj8PCChJKrg8PVprAZlCT0VHM6FR1oUJqGKws6VSliKKTpVauMZ1HNQlRlC1DCTqNzg1SxNSGIWPwEkm5/WctxNKnRnJQ+r4iFZ1KVdVKVSgei0UUVmahRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAV8O/sreDfhKniTxj45+Gv7V5/anln8Q/F7+2PEF54x+EXjnxFo3iHxr8UDN4y8L614k+EGieF9LutD+Guq/D7TfhT8P/DWu6DJ4g+Gui+DNT8DXniHVINPtdL8P/cVfDX7LPwG+HPwq8a/EbUPCn7S3i/9ojxNP4r+KeqeNbz4h+MvAHjP4gaD4v8AiJ430u48WaF4hv8AwBovhOw0/wAP+C3+HXh7wB8P/Bt54T0+88AaX4b1nQpdT1Mz/ZdJnD6ZpSm1yKGU53bEwfPWozq08Jh1S+r3fNhsbCtUweIxCinhJVqEvaRVR06piLvATXxf8KWVNwbcIO1Wu/aKr7lq1J6wo+3h7em68PZYm3sX86/tafsafsRftVftEXvgT4q/tOax4e/aY8a+CPCmpW/wUtPjF8HPEWuXnwS8H67DqGkRaJ+yp8avCXxR+H8vheH4g6Tqviy1+MkHwfuPivoXj2aTUPCvxb0C68I+Cbfwj5vqP/BB39lbUvGV747m+LX7Q0WuX2iftEaDcWFrb/sxQeBtSs/2mLnwTc/EGXxh8LV/Zl/4Vf8AFK+lbwBoH9p3vxd8HePp/ipcfbtU/aCb4x61df2lH9bfH39kr4F/Grx549f4w/G3X5vBF14c0b4o+NP2cNbb9nW7+GGheJvDujXfhHwh+05dL4x+D+t/GHw/4p8IWvhiD/hEtdl+KFt8LtD8T+BrHxXp/g+Pxlol3rZ+LvGX/BEn4A6z8CPjN8Jfg38Z7/Tfitr/AI5+Luv2Pxc+MXwv+An7Qlv8KNf+P/ifU/il8WvA1z8ILTwR8MvB9z8OfG8Pjyy1LWPhJfSaP4c8Q2Wn/DjUfFtl4n0rSI7PWeWSlTwk+TDKo6eXcW+xpwrqnGbzJ4PLq+Djz2hg457SWKp5pi4V60cPLDzxlRPMM4xmBwm0406mLpqVVRTr8JqvOrTlJ0XgsTjcesVU5U6mIhkirYHH4HDSw8Z4r628PTlUoZdg8Tif0G+Kn7HnwO8cfs6/B39nvx7rGoWHgj4L3Pwl0r4eeKrqH4aW/ijT/EPgvR4fhr4JvtNudb8C3ng/QfGus22rtouj6x4L8KeGvEOheIdZtdQ+F1x4O8T2nh2+0z4/+CX/AATb/YW/Zeuf2a/2Y7T42ap4m+IXwxsfh/45+A3w/wDjh4r/AGevGvxb1rR/2c9RWeHxd4Z8Ka98LLbXL+30iHWLrRPFfjbwXoGnap4e0zUfDVto2v8AhS6+HXweuvAHm2gf8EvP2EP2adW8MftPeNP2ntT8H6Rrn7Q37O/x50/VvHXjH9nfT/2ebz4reDvAPgv4UfCnw58HLb4tfD7xhP8AC/w/4t07w74f0fwcPhn8SbH4xzaFef8ACtfDPxan8AatfeFdS/RD9pz9kf4QftAWnjLUviZ428e+D18afCpPgVfzaX4y0lfADeH/ABD4ui1GFPEXwc+I2jeM/wBnv4ta1q2uX1r4f07T/jv8K/iroH9m6lqXhTSvDkOn+NfGFh4l9KtOVHE4nHYebxOJnnP9qYuUYKjPEZvgOG6dTAVr1L0lXw+bZpiMv9nXhGMMvvmSw1KeNowj59KnGvhqeFxNBYeMcnjlGHp1Knt/ZZJmHEUqWYYSTpv2ns6mV4OWZTlRqTVXHN5YsRWVCvUnwvhv/gn38BfA37VekftP+Hdf1fQPiEfFHxk8dxeDbHwp+z3p2j69rnxe0nT9N+IWoz+JLb4K2/xzuEmuha61rT6b8WrQ+Kb9PCNh8SpfGPhr4dfCXQPA3kXxa/4JSfs1+PY/AWmeIPix8ZNEi0jwZ8S/hP4dtPFWt/Bn4z3WvxfFb+2Ne8TaPa3v7U/wf+OerweHpoEv5p/2f/B17of7N/ibwroGi+F/HfwP8XeBPAvhbQPD/rPwe/4Jqfs2/BH4k/Dv4v8AhHT9QvPiV8PbCayXxpr3hj4PXniPxXcXPg7X/AdzrniTW7L4V6bqtn4lm8K6ronh8+IfBV54P1WLwp4C8FeAbe5h+HVnrXhHXfEPh9/wRi/ZW8D6L4r8O6xrvjb4o6T4vu/7X1FfiP4A/ZQudWt/EkHjX4qfEXSPEtt4p8H/ALM/g7xbcah4Y8d/FnV/HPhLTtX17VPDPhj4g6LpHxN0XQLL4lap468X+MsHQoqWAwaa+p4XC1cs9tCM4fV8txOGxFLF0aEfdr4hVIVJ0aSrujJ1J4SvKVGWHU8Lvz1XTzTGcjeOxeKlj/Y1JqX13MaFaeJwWJrz9+jRh9Zw+Dq4iEbvlr4qioVYyqvEYuk/8EPv2O9M+J/gP4nXGsfFXWG8EeEviH4Lv/h9en4NWPws+J+jfFiL4aL8Sf8Ahcfgnw58GdCsviXd+NZfhhpL+IZvEU9wmpWWozeG7iF/CPhf4a+HvAn7AXF1p+k2iy3VxZ6bYwm2tlkuJYLO0iaeaKzs7dXkaOGMzXEsFrbRAgyTSRQRKXdFP4u+G/8AglJ/wTk/Z7+HPiH4kfEP4gTeJfBXw5+MPxk/aAf43ftK+OPg14ntvgj4z8X+PvGHif4h3uhfE7xb4FsdO+Gem+GPifqVv4huLgalp+qaZ8Q/hv4K8ReJdZv/ABh4ZudSvPdvhD/wT5/ZR+Gf7IPxZ/Zt0j4k+KfiT8D/AI6/Grxx8atd8WfFfxX8MPiy0PxA+L3xP0rx+LTRJvFXgbU/hnq2iW/xDXSZ/DXhvxb4O8W22tardsPE6eLdU1vULjULo1KlXD4SlVtS+q5VTqVMPS5alHAYvE4zDYhZbGUI0+elUrY3iPExxzpUoVa2XJQpSlmVSWAmpThQr4mpTg6kcRnFWMMTUk41cdSeCqqvmSjUlO2KdPL8jw9XBOq6jhWlUqVvZ5dSljP0j1XXtD0IWja3rOlaMt/NdW9i2q6jZ6eL24sdK1HXr2C0N3NCLmaz0PR9W1m6ih3vb6Vpeo6jMqWdlczRXrW6tr22t72yuILuzu4Irq0u7WWO4trq2uI1lguLeeJnimgmidJIpY3aOSNldGZWBPwz8Pv+Cfnwm+HXwW8b/A7SvGPxEuvDfjv4x678Z9Q10WPwf8KeJ9O1fxTcaenivw/psnw3+Engfw5PpvjHQINa8L+N/Fmu+G9b+Lvjmx8Z+NPEHjL4ma74/wBem8ZReMfBH/gj9+y18CNM1K08N+IfjD4o1i++KnxE+KNn40+IfiLwV4s8b+HofjH8QtU8f/Gb4Z+GvEU/w8trnR/hZ8X01i98H/Ejw1bob/xR4aFpqN5rn/Ce6fY+NreKF5VKca69lSqYaFSVSH72WHxMqeXN4epT9z2kFVxeYQrYilN+xp5R7WjSxs8zo0cLdZyjSlKjFVKtOvVp+ynLkVekquKjTxFKpaSpx9lQwtX2dWPtKjzGVOUcO8ulLHfqpRXyR+xn+xp8Nv2Hfhp4y+Fnwu8WfFHxhoPjj41/Fn476rqPxa8VWPi7xBa+L/jJ4nm8XeK9O0zUNP0Lw9BbeG4NYuLifTLOayudTaW5vNR1rV9a1nUNQ1O6+t6cbunh5S0qzwuEq4imtY4fF1cNSqYzCwqae3p4TFSrYanieWmsVClHEKjRVX2UK156yt7kMTiqdCfWthaeJq08JiZQ/wCXM8Vho0sRUw/NU+rTqyw/ta3s/azKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAK+Cf2Qvhb+yz4V8R+OvEX7L3xw034r+G/+Ej+J39v6TY/HfU/2hLvwv8AELxn4z0k/FGy1Pxv4g8fePfEVlbWHib4c2Wk6Z4E1C8t4fAOu23jixtVjGrSaTo33tX5/fsbfCX4DeA9e8fD4KftMaX8fIfC3i34t6N4m0TS9b+Bt2/wx8d+N/H2n6z8SvBd54c/Z98L/D3wB4Hg0LxJ4Ps7ePwXH8O9A8RWHjK4+I/i3x1q3izx/wCPvFOtOsN7uaUqyXs5RyjO6TxUPerUqeIhhISw7pXcp4XHVPY4bES5FChUlhq8q0JU6dKusTrgJJpTX9p5VJQm+WHPGpXtVp1HyKOJpRdT2cVXpzrYeeLoRpYmFSpQl4j+1p+xp+xF+1V+0Re+BPir+05rHh79pjxr4I8Kalb/AAUtPjF8HPEWuXnwS8H67DqGkRaJ+yp8avCXxR+H8vheH4g6Tqviy1+MkHwfuPivoXj2aTUPCvxb0C68I+Cbfwj5vqP/AAQd/ZW1Lxle+O5vi1+0NFrl9on7RGg3Fha2/wCzFB4G1Kz/AGmLnwTc/EGXxh8LV/Zl/wCFX/FK+lbwBoH9p3vxd8HePp/ipcfbtU/aCb4x61df2lH9FfHj4DfspfHL9obVvg38Wf2oLO98VfEDw1pHxUP7DGreJP2XtQi1DxH4b0xvBPhL9p/QvAfi74V67+0SvifwcmiabB4U17T/AB43wt0HxZ4Q0nxNYeD4vGulTa0/zT48/wCCGvwUu/gF8Uvhd8Kfitr2gfE7x34r+MHjLwv8ZPjb8I/gZ8fLHwBffHzxz4j8dfF3wtafCWHwJ8L/AAZrPws8aah4nnXW/hc82meFNfk8O+CJPF1r4ntPDkmnapyuM4YNunhVVtgOLYYaFOsoQq1MxeFy2vgKbkvZ4X+3KdPG080xVKvXWHnhauMqxeYZvjcDhN6kKcsZSjOqoXq8JTrSrU5OVKGExeYYyONmor2mJo5K5YTGYChLDxli5YiphaU6lHLMJiMT9q/tCfsS/DD4u/slfDz9k/XPjZ8bfgn4G+H8fwf8J+G/iZ8H/Hfg74W/FO4TwXa6d4C8P+GZPEY8E3XhOO2+JVjd/wDCEeKvDeh+D9KsPFWn+JL7wrpGm6dZarHp1fJPg/8A4JIfsa/Cu61f4f3nx1+Jep6n4yPxp1u98O+M9a/ZptfG5i/ab+Nmk/EbxbdeBde0f4E+G/iX8L9I1X4i6ZD4f0/T/g94g8C6B4sEllpnjmx8ceIPDXgvUPDVv4ff8Eaf2X/gz8QdK+Mc/wAV/ifB4gb9oX4F/Hq50PWG+DF38JLX4rfDLwT4L+DngPw58L/CvxI+FvjrXvhD4e1WHw94f8PaEPh7490z4x22lXv/AAq7RPi03gXVr7wnqX1d+0n8IP2WfiZ8Z/hZovxX+Mtp8Ofjx4+0TVfDvwa8J6d8T/BPgr4k/EHQvAtp4k8SeN9L8A+FtdtrrxH4603TYPEtp4s8b2GkWGs2WkXHhPwP4nubfSrrw7a6hJ24pc+KnXpyeNrY/HY3D5hyJ4etisDnOT5HLP5UJNtKrz4SpS9lKmufD5LQxsKWEnjFOjyYdSng4U61J4aGXYXA1sDTqSWKp4d5XneOqYSNdJ8q+rYGvVzJzdWVH61j5YGpiK1OjUqz+P8Awd/wRz+FOoaj+1dD8X/if4M+KV38afHeqa54U1fwz+zF+zV4P8c/CDRtc8E6b4TsdH8aw6/4M+KHwx+NHirTvCEniDw9pviDx58ItO0C8+GPxI8b/CLUfAOo/BnVdF8C6F7VpH/BKH4F2sMNv4m+Jnxp+IcOgWvhSD4Zf8JlH8CftPwYvPCst3dDXvhbqPhb4F+F9U0TxNrl1rnjY6t4h1a917VrTSviH4z8JeGLrw74Jv8AT/DWl/Oyf8EKP2NdfsfhjL4d+LPxp0XUfg34zl12x8T/AAni/Za+GlzrHjTw34N+J3wkNp4x0r4T/s1+FPBU2neEfDnxE1rwvo/w103wxofgDwJDoi6D4b8G6BpviT4n6V47+pfid/wTp+EfiT4Ofsn/AAr1X4peKPBnww/Yn8I2Gn+GtYHgv9nG41nU9P8ABngbRPB2j63r2oeM/gvrfw7+H407w7od9L4i1T4VfD/4cX15Y6nqvhuz1fw/8OtY8X+DfFGOKvKhmT5Y4mpSnkWW4CMpuEMxyrLaFGWHzKpiJx9pgMTltajSUJunWzDHRj9bq4t1pzpy0w0ZOtly5J0XCWbZjWhGTq1MBneLxGMjXy+FCL9niqeLeMxsZe/DC4OWJr4aGEjCcz0TRf2D/h34Z/YlX9hfwt4+8d+FfAMGhapomnfELwv4O/Zw8O+PtAbVvHV78QZNX8J+EtH+Adn+zp4O1XS9dv5f+EWPhT4DaNpvgsQabqfhDTdD8SaRpWu2fkGq/wDBM79nzwxp3xH1K9+JHjrwj4H8XaT4w8V/FfWJNR+H/hrX77xlMPC1/F8bPEvxVtfCGkaxeeNvCWl6V8UXvPiD48uPE/iq5tfjD4vGo+K4NC8NeA9J8K/Dvhj/AIN4/ghZwS+BtZ/aL+JmtfAjQfAv7K3hX4Pw+G/Bnw18FftL+EY/2YPGuk/EXR7bxd+1HoOju3xM+H/jDxRomi6o3w4b4VeFtA8CXWkWGtfDW48L+JrjXPEGtfpJ8WP+CcPwH+Nnx58W/Hz4i6h4m1/V/GPgrw54Nv8AwXeeHPgne+E7b/hD/MuPCHiGDWtS+D9/8V9Q1Pwbr32bxr4F0TxF8Tdc8A/D/wCIVtN8QPAvgvw54w1zxRrOu6YijRxNTG1sQlVq5viM6yvNFXpRkquRf7VHCYmvS5pUp1M0VWpWWWU0lluKq4es8aq1H6xhlgpQpLL6CTpYHKqWS5pl0sNUU3DNXRw/1nD4dys7ZTBRo0sfXlKni3SrujhvZSpyxPsP7JH7N/wz/Yg/Zc+DX7Mvw68W+Lte+GPwT8Jaf4J8I+Kfin4l0jXPFuoaTLqc8uljXNf03SPDOh3M7XOqx6bpUGk6HpGm29mNO0rS9Pgt4baGvoG/8UeGtK1TS9E1PxDoem61rl1HZaLpF/q1hZ6prF5NZ6tqMVppdhcXEd3qF1Lp+ga7fxwWkU0r2ei6tdKhg028eH8gPh3/AMETf2IfBvwy1XwyNf8AiH8UNH1Xxz8U/inpnjv4vah8HPi9rHhy7+LnijxB488bad4f1Dxp8JNZ8MP4E1HxdquleKtW8Ma1omt6B4r1vwL4M1bx9B4tvNM1CfVfKvhH/wAEsf8Agm58QfhTfa18Gv2mB8WPCPx28ZfHnT9I+L/hfXP2Kfi3p/jDxB8VviD40+KPj/4b+ENSH7P3ij4ZeI/B/hvxI/xGe7+BUXh3Wvhprulr4isfi74B8exaBbPo1VcRiMXiPrFbmrV8RgauY5lPnVSpRzWu6U6WXuVoe1jjcVUxdCGZOFKl7XDpvDcte9HHDUVhsuq0oUYUHhJU8Hl1ON44SeFoYWdSWJlL3pUYYWjQbqYK8qkaPNWjiZwoTU/3wqta3tnfLM9ld214lvdXNlO9rPFcLBeWcrQXdpM0LuI7q1nR4bmByssEqtHKiupA+Vf2Wf2Vvgn+zVZeKZfhBfT63feKbXwx4Y+IHim8/wCEGk1nxb4h+FcniTw9aat4wvvA/hXwtaaj400nT9STwNqD3Vqi6N4d8HeFPCOm6bouneGoLKvPfC//AATu+CPgz9qGx/at8Map4h0XxpaeLPi542n8M6b4M+AFj4d1TxD8atJtdN8b3uoeLLP4JQfG7Oo3Vsutal9i+Ltk/i+/tfC9h8RX8aeGvhr8KdA8CPlj9ZjS508M8LWqPFqMrfWYU6M6FCnRaVSdLEylWhCvL2fJGFOrVpwVRwhpKdT6tOcaT+twx8KH1WU4pfVFUxdHEVqlVNxpV6EqeFnPD2qStPEUE5VKcZP7n0zVNN1vTrLV9G1Gx1fSdStorzTtT0y7t7/Tr+0nQSQXVle2skttdW0yEPFPBLJFIhDIxBBoj1TTZtSvNGh1Gxl1jT7LT9Sv9Kju7d9SsdO1afUrbSr+8sVkN1bWWp3Ojaxb6fdTRJBez6VqUVtJJJY3SxfmR4l/4JP/AAP+IPxB+E3xA+LHxT+Nfxb/AOFO/DT4rfBjw/4L8dWP7PL+BfEPwh+LnjHwx4r1z4Z/ELSPDX7P3hu+8eeDtJsvB2geCtH0nxHq16t74Tt71vF8nirxVrOs+KNQ8W8V/wDBCr9l3xZ4j1DxHdfFL4z2kmoE+bpX/CB/sVeIdIuRH8INd+ClkniWLxv+yB4rvfiTHp/gvxLrOmwxfFe+8eR3Xhy6T4VaqmofA22tfhZDhCVR0JTnS5K31OdeFBTjL/aljq9KGBqVdIwlPL44bGvEQVahHEVq+B5nHD08ZitpKPtOSMrwWJdKVWScVKgsu+sfWqUVzTknmMZZeqNRUanspUcdLljKrh6H7XUV+OOrf8EWfgPqXxL8Z/EaH4y/GzTJPiN8XrD43eMNJ07Qv2crFLPxnoPwr8LfBzw9F8Mb3T/gHZH4N2lt4M8MpBq3ij4c2uifF7U5bq40+y+Kei+FtU8VeGvFH37+yB+y94D/AGK/2Z/g5+yt8MNe8d+J/h/8EPCMPgvwnrnxM1vT/EXji+0e3vb29t/7e1fSNF8OaTcS2xvXtLOHStA0fTbDTbez0+w0+1tLWGJdoqLjXcpcsof2cqEUnL27r4J1sycn7vsYZfjeTA0G1OeYR9pinTwkIU6dbFynzUEqb5Zxxsq8pSivYSpYuNLAwjFczrPGYXnxdV3pxwbVPD3xE5znS+kaKKKk0CiiigAooooAKKKKACiiigAooooAKKKKACvy0/4J7/Dj9nfwBrXj/Q/gb8R/jr4htvC3iH4oWM3gr49fAfxR8AvEHhfVfFnifwhq/jqDw5pHiD4Gfs+23jLwjbX2ieEr+z8XWfg7xLr3iHxF4p8V/Ebx78UviP4t+KV74hm/UuvM/Dfwl8GeEvFEnirQbS6sro2njKCDT/tJm021vfiN45n+I3xC1qHz45NRk1Xxl4qawvNWe71G5sreDRdKs9FsdKt4rlLtUL08wo4p2VOGBzbCucP94pVMbhFTpSp8/PRnQquEsJi6bpwr+xxP1jD4qk8NPDY0r/vMFOhFvn+vZbiVCV1TlDDVqntWuRwqKvCNXnpP2saLprEQrUsRz06Mvze/aW8JfsW/EX49fED4dftF/tJ+LfCmiXtl8P8AxX4h+BfxQ8JfCvwx+zHd/F3UE8KfDP4W/E/wh8Zfiz+z5K2vftDeH7zxL8LbLwt8PfB/7ROrJ4S8Vah8LvFz/CPTvFuvaBr+r/BXjX9hH/gmLqvwC/aF+F3wf/4KIfs/aT8TrP4k/EG41r4yfGbxD+xv+0FY/ATxr+1N8ZfGEfjX4ZeKPhLbWHwx8GWHgr4sfErU9Z8Ex/BfX5fD2i+N/GHg3wroGvab4vvfCN5oWo/sL+0J/wAE3/2Iv2qtd1XxT8e/2fPCnj7xTr2peANT1zxS+p+LfDXibWpPhZrGkeIPh3p+r+IfB/iHw/rGpeHvCOs6NDqOjeFr29n8NW9xqfignSXXxn4uXW+q8Y/sPfs0+OtA/wCEa1vwX4nstNE9hMJ/B/xh+NPw81xVsPD/AIb8JfY08UeAPiF4Z8TJpWp+FPCejeF/EejLq40nxX4cGq6H4mstW0vxF4itdV56eGpVacaONpxVPEPPsBmDw0pqdTJ81qZVUtCTdOpUxWMpYH6jmNKrVUKdDB5bLC4p4SnLK6etStVVSVSg05UKWSYrL3XjGUIZrk9TM61CFfD8sqX1PDYnHTxWGqwbnUqYzMY4vB1Z1frM/wAsPCv/AAT6/wCCa37PPxIs/iz4l/bS0bw94rtviH8P/wBtbU/DPi34p/swQ/C3TB+zX8IPhj4Vn8V/Dbwd8UvBPjTxH8HPg74Y8Bt8Pb/VvGXgDx3pfxA8HeAvFei+Dv8Ahdln8L/Ff/CPaz9Y/th6L+zd8cdC+GWv+M/2ofjR8M/hV+1X8MrfwI9h8M/hN8Lfid8G/jF8PNXs28U+CPEfxyufjF+yn+0J4e+HvgDwzd+PkurXVvH2rfDH4P8Ai++8Z2Hw++Mdl8QtI17TvBVz6t4u/wCCYH7D3jfxl4S+IuufBzU4PiB4B8MfEjwd4E8c+GfjB8cfBHjDwVoHxX8Uf8Jj4ut/CXiXwV8SvD+s+HL6315YZfBGt6Pe2eufC3TbWx0D4Yaj4P8AD9hZaXB73rv7LPwB8UaB8KfDfib4b6X4isfgX4cu/DHwcv8AXdR17V/E/wANLa+8Hw+AJtc8GeNNQ1a48YaF49TwdE+hWnxNsddi+I1haX2rPY+Kra51rV573bFTxGKwU1UVKpjJrDt0akpRwLlLD4nI8bBzhTVT2b4awPDlDA2oJYXGUsb+7l9XwmKq8+FpUsLiJRpRdPBpVqcaibqYycYV6Gb4SvNVG4wr/wCsGKzrGYmXt6tWVKeCccVKo60YflH8Jf2f/wDgk/4C+K3g74q2v7b3wb+KGoaf4F+B+u+H/DHjz4u/sT+INC13Rrvx9YWvwC+JUuq6B8N9B+Iet6RrXxcvtEu/gnZJ45k+E2j/ABduYtc+C/hDw/8AEDxJrd/rnq/xY/ZJ/Yu+Jf7b3xA+J3jf48+LLD46ajF8LvD3iL4c6p4O/Z51Dwt4et2+EHxQ8F+AovDXiX4ifs2+JfG/hnUNf8PeO/G2oaP4w8O/Fe18Uab4mutX8H+EfEvh7R/GvjzwH4zn0f8A4Id/sG6dHq/hHVdD+LXjL4Ay6T8ErLwV+y34x+L3ivV/gn8JtY+Aep2+seDfGXw4uIpbP4w2nizWdQtbV/iFe+KPi14q0/4g2djpWk+KdL1DRtE0PT9N+7Pil+yN8APjLqmp69488GapP4m1W31S2l8XeFviF8Svhz4zsF1jSPCuiXc/h7xl8OfGHhTxR4Vv47LwR4Um03U/DOraTqOi6todnr+jXVhrol1GTTENVsN7sFOpHNM6xdDDV1CNBUJYn6xlFfFRpQqU/r+Kr0aP9qUoRxOGw+D9lSw1WvCMsvpFD2tHEVZKSh7bBZRCtiabqTqSxftI4rN40o1JRn9Xo1qlZ4Ku6mHxOIxcqs8TBU7V8T+MGsfsXf8ABEvwl8Tvjb4j1v8Aas+FKWCfAjwz4N+IX7N83xv/AGcdW+DXwZ+DfgvxVrPjfwV4xtPgPaeEruD4ceF/hfrfx98P+LPDnizV7JPBPwzt7nwP4ytv7BjvdV13Xvsr9l/9nj/gnv8ABP8Aaw8UfGf4B/tK+GtS+Ivj/wCFPw8/ZC0n4DaH8cPhFf8Aww8K+HPAml65+0D4B8BfDP4ReD9P0y90DxFpnwy8R3fi/wAP+F7K6urHTPhCx8SeHfDWnaLqWta7qv1nL+w7+zRJ4Hi+HsHgrxPpfh628P6V4asbvQfjB8aPDnjHS9P0O48UXmjXmj/EbQfiFp3xD0bxJpd/4z8SajYeMdL8UWfi611O/i1KHW0vtO0u4ss79nj9gL9kj9lLxv49+JHwD+EieBPHPxQl0648f+JH8cfEnxZqHii50vw74f8ACtndaj/wm/jHxJD9qGjeGNHS6ubeGCfUNRTUNc1CS513W9b1LUKpuMK0lzTdGhTx2KwtWKUKtXN82xOY0s2q4ig5VIUqGNyvPM5hKf1jGV44rFVo2eHxkvquU6SdJQhRpJSeGwU6c5ylCnlOUUcHPI/ZyVOLqYjC5hlOUVquH9nQp/VsNRoLF1KuCpV8R5d8Gv8AgmR+z98C/F3j3xN4H1TxTa6d8QPgt4l+A9/4MtfCXwA8J6DpXgfxP4p1LxTcrpmufDj4IeCPiRe3GnXGq30Okab4p8eeJPCdpqGpeJvHknhm4+Kvj/4j+PvGHmnxk/4JB/Az9or4U/EX4d/Hv4zftCfFPxj8UPC2veC/E37QmqP+z74S+OcHhnxLoLeFtc0Tw7q3wy/Z88C/D/wxpGs+G7Lwlo3iPRdD+HVlovjK2+H3gufxtp3iTUNP1C81X9YaK550aVSnUpVKcZ06uHxOEnGa5/8AZ8ZiMTicVTi5XcPrFXGYlVZQcZzpVPq7k8PCFKPXGpUi5SjOUZTlzTlF2lNujg8O1JrWUZU8vwfPBtwnUoRrSi6znUl5H8C/gz4a/Z/+GHhr4UeEdW8U67oPhaCeCz1bxrqsOueKL43E8lzNcaxrEFhpo1K8klkd5ryW1FzcOWluZJp3eVvXKKK6q9eria1SvXnKrWqzc6lSespzk7ylJ9W3uc9GjSw9NUqNONOmpVJqEVZKVWpKrUfrKpOUn5yYUUUVkahRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFFFFABRRRQB/9myAAWimAAFo4gABaRqAAWlfAAFpZIABaWoAAWluAAFpc4ABaakAAWmvAAFptQABabqAAWm+gAFpxIABacqAAWnQgAFp1IABadqAAWngAAFp5YABaesAAWnwgAFp9gABah0AAWojAAFqaIABarWAAWr8gAFrJIABa18AAWuiAAFr5QABbCAAAWxdAAFslgABbMQAAW0DAAFtRgABbUYAAW1GAAFtRgABbUYAAW1GAAFtRgABbUYAAW1GAAFtRgABbUYAAW1GAAFtRgABbVAAAW1nAAFteYABbX2AAW19gAFtiIABbaCAAW3MgAFt0IABbdSAAW3agAFt4IABbeUAAW4PAAFuZAABbsmAAW8jAAFvVwABb7mAAW+/gAFwK4ABcLyAAXE7AAFxqoABcfgAAXJCAAFymwABcyoAAXNpAAFz1gABdDEAAXR/AAF03wABdTIAAXU2AAF1m4ABdaeAAXXBAAF16AABdf+AAXYaAAF2K4ABdj4AAXZIgAF2UoABdl+AAXZrgAF2eIABdoUAAXbYAAF3BwABd0WAAXeLAAF3ywABeBIAAXg9gAF4lgABeMOAAXkbAAF5YIABeaGAAXnpgAF6GoABejEAAXpRgAF6VgABengAAXp8gAF6noABeqMAAXqngAF6q4ABeuSAAXsSgAF8KAABfMCAAX0VAAF9W4ABfZSAAX3fAAF+LIABfogAAX79AAF/AQABfwaAAX9OAAF/jYABgBmAAYAfgAGAUYABgJEAAYDlgAGBGQABgWcAAYGtgAGCCQABgnwAAYKAAAGChYABgs0AAYMNAAGDlYABg6AAAYPSgAGEKQABhH2AAYSxAAGE/oABhU0AAYWvAAGGJIABhiiAAYZzAAGGeQABhr0AAYdLAAGHUQABh4IAAYejAAGHugABiAuAAYgdAAGILgABiC4AAYhxAAGIcQABiHUAAYh5AAGItIABiMSAAYjPAAGI3wABiO+AAYkIAAGJQ4ABiY2AAYnuAAGKMAABin6AAYrOAAGK/oABi1OAAYufAAGLtYABi8uAAYvrgAGMCgABjAoAAYxIAAGMjwABjLUAAYzbgAGNEYABjVYAAY2GgAGNuoABjeKAAY4cAAGOWYABjl4AAY5ygAGOiIABjqmAAY7fgAGPKIABj1AAAY9lAAGPewABj5EAAY+mAAGP2gABkAiAAZA+gAGQagABkKcAAZDeAAGRFAABkUCAAZFnAAGRigABkbqAAZHtgAGSFwABkj6AAZJ7gAGSvgABkvqAAZMRgAGTPYABk2IAAZONgAGTuQABk/eAAZQgAAGUSAABlIyAAZTFgAGU7QABlSQAAZVEAAGVZAABlYSAAZWkgAGVxIABleSAAZYDAAGWIQABliqAAZY0AAGWPYABlkaAAZZPgAGWVQABllqAAZZlgAGWcIABlnsAAZaGAAGWkQABlpuAAZamgAGWsYABlrwAAZbHAAGW0gABltyAAZblgAGW7oABlvmAAZcEgAGXD4ABlxqAAZclgAGXMIABlzuAAZdAAAGXRIABl0kAAZdNgAGXUgABl1aAAZdbAAGXX4ABl2QAAZdogAGXbQABl3GAAZd2AAGXeoABl38AAZeDgAGXiAABl4yAAZeRAAGXlYABl5oAAZeegAGXowABl6eAAZesAAGXsIABl7UAAZe5gAGXvgABl8KAAZfHAAGXy4ABl9AAAZfUgAGX2QABl92AAZfiAAGX5oABl+sAAZfvgAGX9AABl/iAAZf9AAGYAYABmAYAAZgKgAGYDwABmBOAAZgYAAGYHIABmCEAAZglgAGYKgABmC6AAZgzAAGYN4ABmDwAAZhAgAGYRQABmEmAAZhOAAGYUoABmFkAAZhdgAGYYgABmGaAAZhrAAGYb4ABmHQAAZh4gAGYfQABmIGAAZiGAAGYioABmI8AAZiVgAGYmgABmJ6AAZijAAGYp4ABmLAAAZi4gAGYvwABmMWAAZjKAAGYzoABmNMAAZjXgAGY3AABmOCAAZjlAAGY6YABmO4AAZjygAGY9wABmPuAAZkAAAGZBIABmQkAAZkNgAGZEgABmRaAAZkbAAGZH4ABmSQAAZkogAGZLQABmTGAAZk2AAGZOoABmT8AAZlDgAGZSAABmUyAAZlRAAGZVYABmVoAAZlegAGZYwABmWeAAZlsAAGZcIABmXUAAZl5gAGZfgABmYKAAZmHAAGZi4ABmZAAAZmUgAGZmQABmZ2AAZmiAAGZpoABmasAAZmvgAGZtAABmbiAAZm9AAGZwYABmcYAAZnKgAGZzwABmdOAAZnYAAGZ3IABmeMAAZnpgAGZ8AABmfaAAZn9AAGaA4ABmgoAAZoQgAGaGQABmiGAAZoqAAGaMoABmjcAAZo7gAGaQAABmkSAAZpJAAGaTYABmlIAAZpWgAGaWwABml+AAZpkAAGaaIABmm0AAZpxgAGadgABmnqAAZp/AAGag4ABmogAAZqMgAGakQABmpWAAZqaAAGanoABmqMAAZqngAGarAABmrCAAZq1AAGauYABmr4AAZrCgAGaxwABmsuAAZrQAAGa1IABmtkAAZrdgAGa4gABmuaAAZrrAAGa74ABmvQAAZr4gAGa/wABmwWAAZsMAAGbEoABmxcAAZsbgAGbIAABmySAAZspAAGbLYABmzIAAZs2gAGbOwABmz+AAZtEAAGbTIABm1WAAZtegAGbaYABm2+AAZvQgAGb1gABm9wAAZvhgAGcKgABnJQAAZzfgAGdKgABnYSAAZ3xAAGeQoABnp0AAZ79gAGfQYABn6oAAaAHAAGgbgABoMmAAaE/gAGhyAABojWAAaKrgAGjJwABo4WAAaQJAAGkgYABpPqAAaVTAAGloAABpgaAAaaBAAGm4IABp0eAAae0gAGoBIABqHoAAajjgAGpTgAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA==";

        private System.IO.Stream GetBinaryDataStream(string base64String)
        {
            return new System.IO.MemoryStream(System.Convert.FromBase64String(base64String));
        }

        #endregion

    }
}
