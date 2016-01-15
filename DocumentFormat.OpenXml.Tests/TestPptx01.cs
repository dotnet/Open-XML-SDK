// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation;
using Xunit;
using P = DocumentFormat.OpenXml.Presentation;
using D = DocumentFormat.OpenXml.Drawing;
using A = DocumentFormat.OpenXml.Drawing;
using PIC = DocumentFormat.OpenXml.Drawing.Pictures;
using OxTest;

namespace DocumentFormat.OpenXml.Tests
{
    public class PptxTests01
    {
        public static string s_TestFileLocation = null;

        public static string TestFileLocation {
            get {
                if (s_TestFileLocation != null)
                    return s_TestFileLocation;
                // find the directory, wherever it may be, to get to the TestFiles directory
                var dir = new DirectoryInfo(Environment.CurrentDirectory);
                while (true)
                {
                    if (dir.Name == "DocumentFormat.OpenXml.Tests" || dir.Name == "DocumentFormat.OpenXml.WB.Tests")
                        break;
                    dir = dir.Parent;
                }
                dir = dir.Parent; // go up one more, to the parent of the above dirs
                var testDataStorageDirInfo = new DirectoryInfo(Path.Combine(dir.FullName, "TestFiles/"));
                s_TestFileLocation = testDataStorageDirInfo.FullName;
                return s_TestFileLocation;
            }
        }


        [Fact]
        public void P007_PptxCreation_Package_Settings()
        {
            var fiSource = new FileInfo(Path.Combine(TestFileLocation, "Presentation.pptx"));
            var fiCopy = new FileInfo(Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".pptx"));
            File.Copy(fiSource.FullName, fiCopy.FullName);
            using (Package package = Package.Open(fiCopy.FullName, FileMode.Open, FileAccess.ReadWrite))
            {
                OpenSettings openSettings = new OpenSettings();
                openSettings.MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2013);
                using (PresentationDocument doc = PresentationDocument.Open(package, openSettings))
                {
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    Assert.Equal(94, errs.Count());
                }
            }
            if (TestUtil.DeleteTempFiles)
                fiCopy.Delete();
        }

        [Fact]
        public void P006_PresentationDocument_Open()
        {
            var fiSource = new FileInfo(Path.Combine(TestFileLocation, "Presentation.pptx"));
            var fiCopy = new FileInfo(Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".pptx"));
            File.Copy(fiSource.FullName, fiCopy.FullName);
            OpenSettings openSettings = new OpenSettings();
            openSettings.MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2013);
            using (PresentationDocument doc = PresentationDocument.Open(fiCopy.FullName, true, openSettings))
            {
                OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);
                Assert.Equal(94, errs.Count());
            }
            if (TestUtil.DeleteTempFiles)
                fiCopy.Delete();
        }

        [Fact]
        public void P005_PptxCreation_Package_Settings()
        {
            var fiSource = new FileInfo(Path.Combine(TestFileLocation, "Presentation.pptx"));
            var fiCopy = new FileInfo(Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".pptx"));
            File.Copy(fiSource.FullName, fiCopy.FullName);
            using (Package package = Package.Open(fiCopy.FullName, FileMode.Open, FileAccess.ReadWrite))
            {
                OpenSettings openSettings = new OpenSettings();
                openSettings.MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2013);
                using (PresentationDocument doc = PresentationDocument.Open(package, openSettings))
                {
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    Assert.Equal(94, errs.Count());
                }
            }
            if (TestUtil.DeleteTempFiles)
                fiCopy.Delete();
        }

        [Fact]
        public void P004_SpreadsheetDocument_Open()
        {
            var fiSource = new FileInfo(Path.Combine(TestFileLocation, "Presentation.pptx"));
            var fiCopy = new FileInfo(Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".pptx"));
            File.Copy(fiSource.FullName, fiCopy.FullName);
            OpenSettings openSettings = new OpenSettings();
            openSettings.MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2013);
            using (PresentationDocument doc = PresentationDocument.Open(fiCopy.FullName, true, openSettings))
            {
                OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);
                Assert.Equal(94, errs.Count());
            }
            if (TestUtil.DeleteTempFiles)
                fiCopy.Delete();
        }

        [Fact]
        public void P003_PptxCreation_Stream()
        {
            using (MemoryStream ms = new MemoryStream())
            using (PresentationDocument doc = PresentationDocument.Create(ms, PresentationDocumentType.Presentation))
            {
                CreatePresentation(doc);
                OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                var errs = v.Validate(doc);
                Assert.Equal(0, errs.Count());
            }
        }

        public static void CreatePresentation(PresentationDocument presentationDoc)
        {
            PresentationPart presentationPart = presentationDoc.AddPresentationPart();
            presentationPart.Presentation = new P.Presentation();
            CreatePresentationParts(presentationPart);
        }

        private static void CreatePresentationParts(PresentationPart presentationPart)
        {
            P.SlideMasterIdList slideMasterIdList1 = new P.SlideMasterIdList(new P.SlideMasterId() { Id = (UInt32Value)2147483648U, RelationshipId = "rId1" });
            P.SlideIdList slideIdList1 = new P.SlideIdList(new P.SlideId() { Id = (UInt32Value)256U, RelationshipId = "rId2" });
            P.SlideSize slideSize1 = new P.SlideSize() { Cx = 9144000, Cy = 6858000, Type = P.SlideSizeValues.Screen4x3 };
            P.NotesSize notesSize1 = new P.NotesSize() { Cx = 6858000, Cy = 9144000 };
            P.DefaultTextStyle defaultTextStyle1 = new P.DefaultTextStyle();

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
        }

        private static SlidePart CreateSlidePart(PresentationPart presentationPart)
        {
            SlidePart slidePart1 = presentationPart.AddNewPart<SlidePart>("rId2");
            slidePart1.Slide = new P.Slide(
                    new P.CommonSlideData(
                        new P.ShapeTree(
                            new P.NonVisualGroupShapeProperties(
                                new P.NonVisualDrawingProperties() { Id = (UInt32Value)1U, Name = "" },
                                new P.NonVisualGroupShapeDrawingProperties(),
                                new P.ApplicationNonVisualDrawingProperties()),
                            new P.GroupShapeProperties(new D.TransformGroup()),
                            new P.Shape(
                                new P.NonVisualShapeProperties(
                                    new P.NonVisualDrawingProperties() { Id = (UInt32Value)2U, Name = "Title 1" },
                                    new P.NonVisualShapeDrawingProperties(new D.ShapeLocks() { NoGrouping = true }),
                                    new P.ApplicationNonVisualDrawingProperties(new P.PlaceholderShape())),
                                new P.ShapeProperties(),
                                new P.TextBody(
                                    new D.BodyProperties(),
                                    new D.ListStyle(),
                                    new D.Paragraph(new D.EndParagraphRunProperties() { Language = "en-US" }))))),
                    new P.ColorMapOverride(new D.MasterColorMapping()));
            return slidePart1;
        }

        private static SlideLayoutPart CreateSlideLayoutPart(SlidePart slidePart1)
        {
            SlideLayoutPart slideLayoutPart1 = slidePart1.AddNewPart<SlideLayoutPart>("rId1");
            P.SlideLayout slideLayout = new P.SlideLayout(
            new P.CommonSlideData(new P.ShapeTree(
              new P.NonVisualGroupShapeProperties(
              new P.NonVisualDrawingProperties() { Id = (UInt32Value)1U, Name = "" },
              new P.NonVisualGroupShapeDrawingProperties(),
              new P.ApplicationNonVisualDrawingProperties()),
              new P.GroupShapeProperties(new D.TransformGroup()),
              new P.Shape(
              new P.NonVisualShapeProperties(
                new P.NonVisualDrawingProperties() { Id = (UInt32Value)2U, Name = "" },
                new P.NonVisualShapeDrawingProperties(new D.ShapeLocks() { NoGrouping = true }),
                new P.ApplicationNonVisualDrawingProperties(new P.PlaceholderShape())),
              new P.ShapeProperties(),
              new P.TextBody(
                new D.BodyProperties(),
                new D.ListStyle(),
                new D.Paragraph(new D.EndParagraphRunProperties()))))),
            new P.ColorMapOverride(new D.MasterColorMapping()));
            slideLayoutPart1.SlideLayout = slideLayout;
            return slideLayoutPart1;
        }

        private static SlideMasterPart CreateSlideMasterPart(SlideLayoutPart slideLayoutPart1)
        {
            SlideMasterPart slideMasterPart1 = slideLayoutPart1.AddNewPart<SlideMasterPart>("rId1");
            P.SlideMaster slideMaster = new P.SlideMaster(
            new P.CommonSlideData(new P.ShapeTree(
              new P.NonVisualGroupShapeProperties(
              new P.NonVisualDrawingProperties() { Id = (UInt32Value)1U, Name = "" },
              new P.NonVisualGroupShapeDrawingProperties(),
              new P.ApplicationNonVisualDrawingProperties()),
              new P.GroupShapeProperties(new D.TransformGroup()),
              new P.Shape(
              new P.NonVisualShapeProperties(
                new P.NonVisualDrawingProperties() { Id = (UInt32Value)2U, Name = "Title Placeholder 1" },
                new P.NonVisualShapeDrawingProperties(new D.ShapeLocks() { NoGrouping = true }),
                new P.ApplicationNonVisualDrawingProperties(new P.PlaceholderShape() { Type = P.PlaceholderValues.Title })),
              new P.ShapeProperties(),
              new P.TextBody(
                new D.BodyProperties(),
                new D.ListStyle(),
                new D.Paragraph())))),
            new P.ColorMap() { Background1 = D.ColorSchemeIndexValues.Light1, Text1 = D.ColorSchemeIndexValues.Dark1, Background2 = D.ColorSchemeIndexValues.Light2, Text2 = D.ColorSchemeIndexValues.Dark2, Accent1 = D.ColorSchemeIndexValues.Accent1, Accent2 = D.ColorSchemeIndexValues.Accent2, Accent3 = D.ColorSchemeIndexValues.Accent3, Accent4 = D.ColorSchemeIndexValues.Accent4, Accent5 = D.ColorSchemeIndexValues.Accent5, Accent6 = D.ColorSchemeIndexValues.Accent6, Hyperlink = D.ColorSchemeIndexValues.Hyperlink, FollowedHyperlink = D.ColorSchemeIndexValues.FollowedHyperlink },
            new P.SlideLayoutIdList(new P.SlideLayoutId() { Id = (UInt32Value)2147483649U, RelationshipId = "rId1" }),
            new P.TextStyles(new P.TitleStyle(), new P.BodyStyle(), new P.OtherStyle()));
            slideMasterPart1.SlideMaster = slideMaster;

            return slideMasterPart1;
        }

        private static ThemePart CreateTheme(SlideMasterPart slideMasterPart1)
        {
            ThemePart themePart1 = slideMasterPart1.AddNewPart<ThemePart>("rId5");
            D.Theme theme1 = new D.Theme() { Name = "Office Theme" };

            D.ThemeElements themeElements1 = new D.ThemeElements(
            new D.ColorScheme(
              new D.Dark1Color(new D.SystemColor() { Val = D.SystemColorValues.WindowText, LastColor = "000000" }),
              new D.Light1Color(new D.SystemColor() { Val = D.SystemColorValues.Window, LastColor = "FFFFFF" }),
              new D.Dark2Color(new D.RgbColorModelHex() { Val = "1F497D" }),
              new D.Light2Color(new D.RgbColorModelHex() { Val = "EEECE1" }),
              new D.Accent1Color(new D.RgbColorModelHex() { Val = "4F81BD" }),
              new D.Accent2Color(new D.RgbColorModelHex() { Val = "C0504D" }),
              new D.Accent3Color(new D.RgbColorModelHex() { Val = "9BBB59" }),
              new D.Accent4Color(new D.RgbColorModelHex() { Val = "8064A2" }),
              new D.Accent5Color(new D.RgbColorModelHex() { Val = "4BACC6" }),
              new D.Accent6Color(new D.RgbColorModelHex() { Val = "F79646" }),
              new D.Hyperlink(new D.RgbColorModelHex() { Val = "0000FF" }),
              new D.FollowedHyperlinkColor(new D.RgbColorModelHex() { Val = "800080" })) { Name = "Office" },
              new D.FontScheme(
              new D.MajorFont(
              new D.LatinFont() { Typeface = "Calibri" },
              new D.EastAsianFont() { Typeface = "" },
              new D.ComplexScriptFont() { Typeface = "" }),
              new D.MinorFont(
              new D.LatinFont() { Typeface = "Calibri" },
              new D.EastAsianFont() { Typeface = "" },
              new D.ComplexScriptFont() { Typeface = "" })) { Name = "Office" },
              new D.FormatScheme(
              new D.FillStyleList(
              new D.SolidFill(new D.SchemeColor() { Val = D.SchemeColorValues.PhColor }),
              new D.GradientFill(
                new D.GradientStopList(
                new D.GradientStop(new D.SchemeColor(new D.Tint() { Val = 50000 },
                  new D.SaturationModulation() { Val = 300000 }) { Val = D.SchemeColorValues.PhColor }) { Position = 0 },
                new D.GradientStop(new D.SchemeColor(new D.Tint() { Val = 37000 },
                 new D.SaturationModulation() { Val = 300000 }) { Val = D.SchemeColorValues.PhColor }) { Position = 35000 },
                new D.GradientStop(new D.SchemeColor(new D.Tint() { Val = 15000 },
                 new D.SaturationModulation() { Val = 350000 }) { Val = D.SchemeColorValues.PhColor }) { Position = 100000 }
                ),
                new D.LinearGradientFill() { Angle = 16200000, Scaled = true }),
              new D.NoFill(),
              new D.PatternFill(),
              new D.GroupFill()),
              new D.LineStyleList(
              new D.Outline(
                new D.SolidFill(
                new D.SchemeColor(
                  new D.Shade() { Val = 95000 },
                  new D.SaturationModulation() { Val = 105000 }) { Val = D.SchemeColorValues.PhColor }),
                new D.PresetDash() { Val = D.PresetLineDashValues.Solid })
              {
                  Width = 9525,
                  CapType = D.LineCapValues.Flat,
                  CompoundLineType = D.CompoundLineValues.Single,
                  Alignment = D.PenAlignmentValues.Center
              },
              new D.Outline(
                new D.SolidFill(
                new D.SchemeColor(
                  new D.Shade() { Val = 95000 },
                  new D.SaturationModulation() { Val = 105000 }) { Val = D.SchemeColorValues.PhColor }),
                new D.PresetDash() { Val = D.PresetLineDashValues.Solid })
              {
                  Width = 9525,
                  CapType = D.LineCapValues.Flat,
                  CompoundLineType = D.CompoundLineValues.Single,
                  Alignment = D.PenAlignmentValues.Center
              },
              new D.Outline(
                new D.SolidFill(
                new D.SchemeColor(
                  new D.Shade() { Val = 95000 },
                  new D.SaturationModulation() { Val = 105000 }) { Val = D.SchemeColorValues.PhColor }),
                new D.PresetDash() { Val = D.PresetLineDashValues.Solid })
              {
                  Width = 9525,
                  CapType = D.LineCapValues.Flat,
                  CompoundLineType = D.CompoundLineValues.Single,
                  Alignment = D.PenAlignmentValues.Center
              }),
              new D.EffectStyleList(
              new D.EffectStyle(
                new D.EffectList(
                new D.OuterShadow(
                  new D.RgbColorModelHex(
                  new D.Alpha() { Val = 38000 }) { Val = "000000" }) { BlurRadius = 40000L, Distance = 20000L, Direction = 5400000, RotateWithShape = false })),
              new D.EffectStyle(
                new D.EffectList(
                new D.OuterShadow(
                  new D.RgbColorModelHex(
                  new D.Alpha() { Val = 38000 }) { Val = "000000" }) { BlurRadius = 40000L, Distance = 20000L, Direction = 5400000, RotateWithShape = false })),
              new D.EffectStyle(
                new D.EffectList(
                new D.OuterShadow(
                  new D.RgbColorModelHex(
                  new D.Alpha() { Val = 38000 }) { Val = "000000" }) { BlurRadius = 40000L, Distance = 20000L, Direction = 5400000, RotateWithShape = false }))),
              new D.BackgroundFillStyleList(
              new D.SolidFill(new D.SchemeColor() { Val = D.SchemeColorValues.PhColor }),
              new D.GradientFill(
                new D.GradientStopList(
                new D.GradientStop(
                  new D.SchemeColor(new D.Tint() { Val = 50000 },
                    new D.SaturationModulation() { Val = 300000 }) { Val = D.SchemeColorValues.PhColor }) { Position = 0 },
                new D.GradientStop(
                  new D.SchemeColor(new D.Tint() { Val = 50000 },
                    new D.SaturationModulation() { Val = 300000 }) { Val = D.SchemeColorValues.PhColor }) { Position = 0 },
                new D.GradientStop(
                  new D.SchemeColor(new D.Tint() { Val = 50000 },
                    new D.SaturationModulation() { Val = 300000 }) { Val = D.SchemeColorValues.PhColor }) { Position = 0 }),
                new D.LinearGradientFill() { Angle = 16200000, Scaled = true }),
              new D.GradientFill(
                new D.GradientStopList(
                new D.GradientStop(
                  new D.SchemeColor(new D.Tint() { Val = 50000 },
                    new D.SaturationModulation() { Val = 300000 }) { Val = D.SchemeColorValues.PhColor }) { Position = 0 },
                new D.GradientStop(
                  new D.SchemeColor(new D.Tint() { Val = 50000 },
                    new D.SaturationModulation() { Val = 300000 }) { Val = D.SchemeColorValues.PhColor }) { Position = 0 }),
                new D.LinearGradientFill() { Angle = 16200000, Scaled = true }))) { Name = "Office" });

            theme1.Append(themeElements1);
            theme1.Append(new D.ObjectDefaults());
            theme1.Append(new D.ExtraColorSchemeList());

            themePart1.Theme = theme1;
            return themePart1;

        }

        [Fact]
        public void P002_Pptx_DeleteAdd_CoreExtendedProperties()
        {
            var docName = "Presentation.pptx";
            var ba = File.ReadAllBytes(TestFileLocation + docName);
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (PresentationDocument doc = PresentationDocument.Open(ms, true))
                {
                    var corePart = doc.CoreFilePropertiesPart;
                    var appPart = doc.ExtendedFilePropertiesPart;
                    var custFilePropsPart = doc.CustomFilePropertiesPart;
                    var thumbNailPart = doc.ThumbnailPart;
                    doc.DeletePart(corePart);
                    doc.DeletePart(appPart);
                    if (thumbNailPart != null)
                        doc.DeletePart(thumbNailPart);
                    doc.AddCoreFilePropertiesPart();
                    doc.AddExtendedFilePropertiesPart();
                    doc.AddCustomFilePropertiesPart();
                    doc.AddDigitalSignatureOriginPart();
                    doc.AddExtendedPart("relType", "contentType/xml", ".xml");
                    var tnPart = doc.AddThumbnailPart(ThumbnailPartType.Jpeg);
                    doc.DeletePart(tnPart);
                    tnPart = doc.AddThumbnailPart("image/jpg");
                    OpenXmlValidator v = new OpenXmlValidator(FileFormatVersions.Office2013);
                    var errs = v.Validate(doc);
                    Assert.Equal(94, errs.Count());
                }
            }
        }

        [Fact]
        public void P001_PptxValidation()
        {
            var docName = "Presentation.pptx";
            PptxValidationHelper(docName, 282);
        }

        private static void PptxValidationHelper(string docName, int expectedErrorCount)
        {
            var ba = File.ReadAllBytes(TestFileLocation + docName);
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(ba, 0, ba.Length);
                using (PresentationDocument doc = PresentationDocument.Open(ms, true))
                {
                    OpenXmlValidator validator = new OpenXmlValidator(FileFormatVersions.Office2007);
                    int cnt = validator.Validate(doc).Count();
                    validator = new OpenXmlValidator(FileFormatVersions.Office2010);
                    cnt += validator.Validate(doc).Count();
                    validator = new OpenXmlValidator(FileFormatVersions.Office2013);
                    cnt += validator.Validate(doc).Count();
                    Assert.Equal(expectedErrorCount, cnt);
                }
            }
        }
    }
}
