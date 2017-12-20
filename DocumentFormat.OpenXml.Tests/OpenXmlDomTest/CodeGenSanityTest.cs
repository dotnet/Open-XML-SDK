// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

using static DocumentFormat.OpenXml.Tests.TestAssets;

using Dr = DocumentFormat.OpenXml.Drawing;

namespace DocumentFormat.OpenXml.Tests
{
    public class CodeGenSanityTest : OpenXmlDomTestBase
    {
        public CodeGenSanityTest(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        public void ThemeAsPartRootClassTest()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm))
            using (var package = WordprocessingDocument.Open(stream, false))
            {
                var themePart = package.MainDocumentPart.ThemePart;
                var themeFromPart = themePart.Theme;
                var theme = BuildRootElementFromPart(themePart, RootElementConstructors.OuterXml);
                var xThemeFromFile = ConvertToXElement(themePart, themeFromPart);
                var xThemeInMemory = theme.ToXElement();

                Assert.True(xThemeInMemory.Compare(xThemeFromFile));
                Assert.True(themeFromPart.Name.HasValue);
                Assert.Equal("Office Theme", themeFromPart.Name.Value);

                var hClone = themeFromPart.CloneNode(false) as Dr.Theme;

                foreach (var ao in themeFromPart.GetAttributes())
                {
                    var ac = hClone.GetAttribute(ao.LocalName, ao.NamespaceUri);

                    Assert.Equal(ac.Value, ao.Value);
                }

                var dClone = themeFromPart.CloneNode(true) as Dr.Theme;

                Assert.True(xThemeFromFile.Compare(dClone.ToXElement()));
                Assert.Equal("theme", theme.LocalName);
                Assert.Same(themePart, themePart.Theme.ThemePart);
            }
        }

        [Fact]
        public void ThemeAsClassWithFixedOrderChildTest()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm))
            using (var package = WordprocessingDocument.Open(stream, false))
            {
                var themePart = package.MainDocumentPart.ThemePart;
                var theme = BuildRootElementFromPart(themePart, RootElementConstructors.DefaultConstructor);
                var xThemeFromFile = ConvertToXElement(themePart, theme);
                var xTheme = ConvertToXElement(themePart, theme);

                //doc.ExtraColorSchemeList;
                var ecsl = theme.ExtraColorSchemeList;
                Assert.NotNull(ecsl);
                var xecsl = xTheme.Element(ecsl.GetXName());
                Assert.True(xecsl.Compare(ecsl.ToXElement()));

                //doc.ObjectDefaults;
                var od = theme.ObjectDefaults;
                Assert.NotNull(od);
                var xod = xTheme.Element(od.GetXName());
                Assert.True(xod.Compare(od.ToXElement()));

                //doc.ThemeElements;
                var te = theme.ThemeElements;
                Assert.NotNull(te);
                var xte = xTheme.Element(te.GetXName());
                Assert.True(xte.Compare(te.ToXElement()));
            }
        }

        [Fact]
        public void ColorAsLeafElementTest()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm))
            using (var package = WordprocessingDocument.Open(stream, false))
            {
                var mainPart = package.MainDocumentPart;
                var doc = mainPart.Document;
                var colors = doc.Descendants<Color>();

                foreach (var color in colors)
                {
                    Assert.NotNull(color);
                    Assert.Empty(color.ChildElements);

                    var xColor = ConvertToXElement(mainPart, color);
                    var hClone = color.CloneNode(false).ToXElement();
                    var dClone = color.CloneNode(true).ToXElement();

                    Assert.True(xColor.Compare(hClone));
                    Assert.True(hClone.Compare(dClone));
                    Assert.Equal("color", color.LocalName);
                }
            }
        }

        [Fact]
        public void FieldCodeAsLeafTextElement()
        {
            using (var stream = GetStream(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm))
            using (var package = WordprocessingDocument.Open(stream, false))
            {
                var mainPart = package.MainDocumentPart;
                var doc = mainPart.Document;
                var xDoc = ConvertToXElement(mainPart, doc);
                var fields = doc.Descendants<FieldCode>();

                foreach (var field in fields)
                {
                    Assert.NotNull(field);

                    var xField = ConvertToXElement(mainPart, field);

                    Assert.Equal(field.Text, xField.Value);
                    Assert.Empty(field.ChildElements);

                    var hClone = field.CloneNode(false).ToXElement();
                    var dClone = field.CloneNode(true).ToXElement();

                    Assert.True(xField.Compare(hClone));
                    Assert.True(hClone.Compare(dClone));
                    Assert.Equal("instrText", field.LocalName);
                }
            }
        }

        [Theory]
        [InlineData(TestDataStorage.V2FxTestFiles.Presentation.AllSlidesConverterSc)]
        [InlineData(TestDataStorage.V2FxTestFiles.Presentation.AllSlidesConverterTc)]
        [InlineData(TestDataStorage.V2FxTestFiles.Presentation.AutoShapes_2D_Default_styles)]
        [InlineData(TestDataStorage.V2FxTestFiles.Presentation.AutoShapes_2D_Reflection)]
        [InlineData(TestDataStorage.V2FxTestFiles.Presentation.AutoShapes_2D_Shadow)]
        [InlineData(TestDataStorage.V2FxTestFiles.Presentation.AutoShapes_2D_Soft_Edges)]
        [InlineData(TestDataStorage.V2FxTestFiles.Presentation.AutoShapes_3D_Bevel_Circle_Shadow)]
        [InlineData(TestDataStorage.V2FxTestFiles.Presentation.AutoShapes_3D_Bevel_Circle_Soft_Edges)]
        [InlineData(TestDataStorage.V2FxTestFiles.Presentation.AutoShapes_3D_Bevel_Circle)]
        [InlineData(TestDataStorage.V2FxTestFiles.Presentation.AutoShapes_3D_Bevel_Riblet_Reflection)]
        [InlineData(TestDataStorage.V2FxTestFiles.Presentation.AutoShapes_3D_Rotation_Parallel)]
        [InlineData(TestDataStorage.V2FxTestFiles.Presentation.Block_hyperlink_crash)]
        [InlineData(TestDataStorage.V2FxTestFiles.Presentation.Chart_2D_Animation_Box_In_One_Object)]
        [InlineData(TestDataStorage.V2FxTestFiles.Presentation.Chart_2D_Animation_Box_In_By_Element)]
        [InlineData(TestDataStorage.V2FxTestFiles.Presentation.Chart_2D_Animation_Fly_In_One_Object)]
        [InlineData(TestDataStorage.V2FxTestFiles.Presentation.Chart_2D_Animation_Fly_In_By_Category)]
        [InlineData(TestDataStorage.V2FxTestFiles.Presentation.Chart_2D)]
        [InlineData(TestDataStorage.V2FxTestFiles.Presentation.Chart_3D_Animation_Box_In_One_Object)]
        [InlineData(TestDataStorage.V2FxTestFiles.Presentation.Chart_3D_Animation_Box_Out_One_Object)]
        [InlineData(TestDataStorage.V2FxTestFiles.Presentation.Chart_3D_Animation_Fly_In_One_Object)]
        public void Bug225919_MitigateNamespaceIssue(string testfile)
        {
            using (var stream = GetStream(testfile, true))
            using (var package = PresentationDocument.Open(stream, true))
            {
                var parts = package.DescendantParts().Where(p => p.IsReflectable())
                    .OrderBy(p => p.Uri.ToString())
                    .ToList();

                foreach (var part in parts)
                {
                    Assert.NotNull(part.RootElement);

                    part.RootElement.Save();
                }
            }
        }

        private enum RootElementConstructors { DefaultConstructor, IEnumerable, Params, OuterXml };

        private Dr.Theme BuildRootElementFromPart(ThemePart part, RootElementConstructors buildWay)
        {
            Dr.Theme root = null;
            switch (buildWay)
            {
                case RootElementConstructors.DefaultConstructor:
                    root = new Dr.Theme();
                    root.Load(part);
                    break;
                case RootElementConstructors.IEnumerable:
                    root = new Dr.Theme(part.Theme.Elements().AsEnumerable());
                    break;
                case RootElementConstructors.Params:
                    root = new Dr.Theme(part.Theme.Elements().ToArray());
                    break;
                case RootElementConstructors.OuterXml:
                    root = new Dr.Theme(part.Theme.OuterXml);
                    break;
            }
            return root;
        }
    }
}
