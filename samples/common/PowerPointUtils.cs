// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;

using D = DocumentFormat.OpenXml.Drawing;
using P = DocumentFormat.OpenXml.Presentation;

namespace Common
{
    public class PowerPointUtils
    {
        /// <summary>
        /// Creates a new presentation document.
        /// </summary>
        /// <param name="filepath">
        /// The absolute file path of where to save the presentation document.
        /// </param>
        /// <returns>
        /// The created presentation document.
        /// </returns>
        public static PresentationDocument CreatePresentation(string filepath)
        {
            // Create a presentation at a specified file path. The presentation document type is pptx by default.
            PresentationDocument presentationDoc = PresentationDocument.Create(filepath, PresentationDocumentType.Presentation);
            PresentationPart presentationPart = presentationDoc.AddPresentationPart();
            presentationPart.Presentation = new Presentation();

            CreatePresentationParts(presentationPart);

            return presentationDoc;
        }

        private static void CreatePresentationParts(PresentationPart presentationPart)
        {
            SlideMasterIdList slideMasterIdList1 = new SlideMasterIdList(new SlideMasterId() { Id = (UInt32Value)2147483648U, RelationshipId = "rId1" });
            SlideIdList slideIdList1 = new SlideIdList(new SlideId() { Id = (UInt32Value)256U, RelationshipId = "rId2" });
            SlideSize slideSize1 = new SlideSize() { Cx = 9144000, Cy = 6858000, Type = SlideSizeValues.Screen4x3 };
            NotesSize notesSize1 = new NotesSize() { Cx = 6858000, Cy = 9144000 };
            DefaultTextStyle defaultTextStyle1 = new DefaultTextStyle();

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
            slidePart1.Slide = new Slide(
                    new CommonSlideData(
                        new ShapeTree(
                            new P.NonVisualGroupShapeProperties(
                                new P.NonVisualDrawingProperties() { Id = (UInt32Value)1U, Name = string.Empty },
                                new P.NonVisualGroupShapeDrawingProperties(),
                                new ApplicationNonVisualDrawingProperties()),
                            new GroupShapeProperties(new TransformGroup()),
                            new P.Shape(
                                new P.NonVisualShapeProperties(
                                    new P.NonVisualDrawingProperties() { Id = (UInt32Value)2U, Name = "Title 1" },
                                    new P.NonVisualShapeDrawingProperties(new ShapeLocks() { NoGrouping = true }),
                                    new ApplicationNonVisualDrawingProperties(new PlaceholderShape())),
                                new P.ShapeProperties(),
                                new P.TextBody(
                                    new BodyProperties(),
                                    new ListStyle(),
                                    new Paragraph(new EndParagraphRunProperties() { Language = "en-US" }))))),
                    new ColorMapOverride(new MasterColorMapping()));
            return slidePart1;
        }

        private static SlideLayoutPart CreateSlideLayoutPart(SlidePart slidePart1)
        {
            SlideLayoutPart slideLayoutPart1 = slidePart1.AddNewPart<SlideLayoutPart>("rId1");
            SlideLayout slideLayout = new SlideLayout(
            new CommonSlideData(new ShapeTree(
              new P.NonVisualGroupShapeProperties(
              new P.NonVisualDrawingProperties() { Id = (UInt32Value)1U, Name = string.Empty },
              new P.NonVisualGroupShapeDrawingProperties(),
              new ApplicationNonVisualDrawingProperties()),
              new GroupShapeProperties(new TransformGroup()),
              new P.Shape(
              new P.NonVisualShapeProperties(
                new P.NonVisualDrawingProperties() { Id = (UInt32Value)2U, Name = string.Empty },
                new P.NonVisualShapeDrawingProperties(new ShapeLocks() { NoGrouping = true }),
                new ApplicationNonVisualDrawingProperties(new PlaceholderShape())),
              new P.ShapeProperties(),
              new P.TextBody(
                new BodyProperties(),
                new ListStyle(),
                new Paragraph(new EndParagraphRunProperties()))))),
            new ColorMapOverride(new MasterColorMapping()));
            slideLayoutPart1.SlideLayout = slideLayout;
            return slideLayoutPart1;
        }

        private static SlideMasterPart CreateSlideMasterPart(SlideLayoutPart slideLayoutPart1)
        {
            SlideMasterPart slideMasterPart1 = slideLayoutPart1.AddNewPart<SlideMasterPart>("rId1");
            SlideMaster slideMaster = new SlideMaster(
            new CommonSlideData(new ShapeTree(
              new P.NonVisualGroupShapeProperties(
              new P.NonVisualDrawingProperties() { Id = (UInt32Value)1U, Name = string.Empty },
              new P.NonVisualGroupShapeDrawingProperties(),
              new ApplicationNonVisualDrawingProperties()),
              new GroupShapeProperties(new TransformGroup()),
              new P.Shape(
              new P.NonVisualShapeProperties(
                new P.NonVisualDrawingProperties() { Id = (UInt32Value)2U, Name = "Title Placeholder 1" },
                new P.NonVisualShapeDrawingProperties(new ShapeLocks() { NoGrouping = true }),
                new ApplicationNonVisualDrawingProperties(new PlaceholderShape() { Type = PlaceholderValues.Title })),
              new P.ShapeProperties(),
              new P.TextBody(
                new BodyProperties(),
                new ListStyle(),
                new Paragraph())))),
            new P.ColorMap() { Background1 = D.ColorSchemeIndexValues.Light1, Text1 = D.ColorSchemeIndexValues.Dark1, Background2 = D.ColorSchemeIndexValues.Light2, Text2 = D.ColorSchemeIndexValues.Dark2, Accent1 = D.ColorSchemeIndexValues.Accent1, Accent2 = D.ColorSchemeIndexValues.Accent2, Accent3 = D.ColorSchemeIndexValues.Accent3, Accent4 = D.ColorSchemeIndexValues.Accent4, Accent5 = D.ColorSchemeIndexValues.Accent5, Accent6 = D.ColorSchemeIndexValues.Accent6, Hyperlink = D.ColorSchemeIndexValues.Hyperlink, FollowedHyperlink = D.ColorSchemeIndexValues.FollowedHyperlink },
            new SlideLayoutIdList(new SlideLayoutId() { Id = (UInt32Value)2147483649U, RelationshipId = "rId1" }),
            new TextStyles(new TitleStyle(), new BodyStyle(), new OtherStyle()));
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
              new D.FollowedHyperlinkColor(new D.RgbColorModelHex() { Val = "800080" }))
            { Name = "Office" },
            new D.FontScheme(
              new D.MajorFont(
              new D.LatinFont() { Typeface = "Calibri" },
              new D.EastAsianFont() { Typeface = string.Empty },
              new D.ComplexScriptFont() { Typeface = string.Empty }),
              new D.MinorFont(
              new D.LatinFont() { Typeface = "Calibri" },
              new D.EastAsianFont() { Typeface = string.Empty },
              new D.ComplexScriptFont() { Typeface = string.Empty }))
              { Name = "Office" },
            new D.FormatScheme(
              new D.FillStyleList(
              new D.SolidFill(new D.SchemeColor() { Val = D.SchemeColorValues.PhColor }),
              new D.GradientFill(
                new D.GradientStopList(
                new D.GradientStop(new D.SchemeColor(
                    new Tint() { Val = 50000 },
                    new D.SaturationModulation() { Val = 300000 })
                { Val = D.SchemeColorValues.PhColor })
                { Position = 0 },
                new D.GradientStop(new D.SchemeColor(
                    new Tint() { Val = 37000 },
                    new D.SaturationModulation() { Val = 300000 })
                { Val = D.SchemeColorValues.PhColor })
                { Position = 35000 },
                new D.GradientStop(new D.SchemeColor(
                    new Tint() { Val = 15000 },
                    new D.SaturationModulation() { Val = 350000 })
                { Val = D.SchemeColorValues.PhColor })
                { Position = 100000 }),
                new D.LinearGradientFill() { Angle = 16200000, Scaled = true }),
              new D.NoFill(),
              new D.PatternFill(),
              new D.GroupFill()),
              new D.LineStyleList(
              new D.Outline(
                new D.SolidFill(
                new D.SchemeColor(
                  new D.Shade() { Val = 95000 },
                  new D.SaturationModulation() { Val = 105000 })
                { Val = D.SchemeColorValues.PhColor }),
                new D.PresetDash() { Val = D.PresetLineDashValues.Solid })
              {
                  Width = 9525,
                  CapType = D.LineCapValues.Flat,
                  CompoundLineType = D.CompoundLineValues.Single,
                  Alignment = D.PenAlignmentValues.Center,
              },
              new D.Outline(
                new D.SolidFill(
                new D.SchemeColor(
                  new D.Shade() { Val = 95000 },
                  new D.SaturationModulation() { Val = 105000 })
                { Val = D.SchemeColorValues.PhColor }),
                new D.PresetDash() { Val = D.PresetLineDashValues.Solid })
              {
                  Width = 9525,
                  CapType = D.LineCapValues.Flat,
                  CompoundLineType = D.CompoundLineValues.Single,
                  Alignment = D.PenAlignmentValues.Center,
              },
              new D.Outline(
                new D.SolidFill(
                new D.SchemeColor(
                  new D.Shade() { Val = 95000 },
                  new D.SaturationModulation() { Val = 105000 })
                { Val = D.SchemeColorValues.PhColor }),
                new D.PresetDash() { Val = D.PresetLineDashValues.Solid })
              {
                  Width = 9525,
                  CapType = D.LineCapValues.Flat,
                  CompoundLineType = D.CompoundLineValues.Single,
                  Alignment = D.PenAlignmentValues.Center,
              }),
              new D.EffectStyleList(
              new D.EffectStyle(
                new D.EffectList(
                new D.OuterShadow(
                  new D.RgbColorModelHex(
                  new D.Alpha() { Val = 38000 })
                  { Val = "000000" })
                { BlurRadius = 40000L, Distance = 20000L, Direction = 5400000, RotateWithShape = false })),
              new D.EffectStyle(
                new D.EffectList(
                new D.OuterShadow(
                  new D.RgbColorModelHex(
                  new D.Alpha() { Val = 38000 })
                  { Val = "000000" })
                { BlurRadius = 40000L, Distance = 20000L, Direction = 5400000, RotateWithShape = false })),
              new D.EffectStyle(
                new D.EffectList(
                new D.OuterShadow(
                  new D.RgbColorModelHex(
                  new D.Alpha() { Val = 38000 })
                  { Val = "000000" })
                { BlurRadius = 40000L, Distance = 20000L, Direction = 5400000, RotateWithShape = false }))),
              new D.BackgroundFillStyleList(
              new D.SolidFill(new D.SchemeColor() { Val = D.SchemeColorValues.PhColor }),
              new D.GradientFill(
                new D.GradientStopList(
                new D.GradientStop(
                  new D.SchemeColor(
                    new D.Tint() { Val = 50000 },
                    new D.SaturationModulation() { Val = 300000 })
                  { Val = D.SchemeColorValues.PhColor })
                { Position = 0 },
                new D.GradientStop(
                  new D.SchemeColor(
                    new D.Tint() { Val = 50000 },
                    new D.SaturationModulation() { Val = 300000 })
                  { Val = D.SchemeColorValues.PhColor })
                { Position = 0 },
                new D.GradientStop(
                  new D.SchemeColor(
                    new D.Tint() { Val = 50000 },
                    new D.SaturationModulation() { Val = 300000 })
                  { Val = D.SchemeColorValues.PhColor })
                { Position = 0 }),
                new D.LinearGradientFill() { Angle = 16200000, Scaled = true }),
              new D.GradientFill(
                new D.GradientStopList(
                new D.GradientStop(
                    new D.SchemeColor(
                        new D.Tint() { Val = 50000 },
                        new D.SaturationModulation() { Val = 300000 })
                  { Val = D.SchemeColorValues.PhColor })
                { Position = 0 },
                new D.GradientStop(
                  new D.SchemeColor(
                    new D.Tint() { Val = 50000 },
                    new D.SaturationModulation() { Val = 300000 })
                  { Val = D.SchemeColorValues.PhColor })
                { Position = 0 }),
                new D.LinearGradientFill() { Angle = 16200000, Scaled = true })))
              { Name = "Office" });

            theme1.Append(themeElements1);
            theme1.Append(new D.ObjectDefaults());
            theme1.Append(new D.ExtraColorSchemeList());

            themePart1.Theme = theme1;
            return themePart1;
        }
    }
}
