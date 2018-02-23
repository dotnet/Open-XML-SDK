// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Linq;
using Xunit;

using static DocumentFormat.OpenXml.Tests.TestAssets;

namespace DocumentFormat.OpenXml.Tests
{
    public class OpenXmlRootElementTestClass
    {
        [InlineData(TestDataStorage.V2FxTestFiles.AsSources.Wordprocessing.complex1NOR)]
        [InlineData(TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SharedWorkbook)]
        [InlineData(TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SheetViewsFSB)]
        [InlineData(TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.SST)]
        [InlineData(TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.Styles)]
        [InlineData(TestDataStorage.V2FxTestFiles.AsSources.Spreadsheet.Table)]
        [InlineData(TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charsAnimationFlyInallatoncepptx)]
        [InlineData(TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charsAnimationFlyInbyletterpptx)]
        [InlineData(TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withExtrusion_200charspptx)]
        [InlineData(TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withShadow_100charsAnimationFlyInallatoncepptx)]
        [InlineData(TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withShadow_100charsAnimationFlyInbyletterpptx)]
        [InlineData(TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withShadow_100charspptx)]
        [InlineData(TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withShadow_200charsAnimationFlyInallatoncepptx)]
        [InlineData(TestDataStorage.V2FxTestFiles.AsSources.Presentation.Text_withShadow_200charspptx)]
        [Theory]
        public void PartRootElementFactoryTest(string path)
        {
            using (var file = OpenFile(path, false))
            using (var package = file.Open(false))
            {
                var parts = package.DescendantParts()
                    .Where(p => p.IsReflectable());

                foreach (var part in parts)
                {
                    var root = part.RootElement();

                    Assert.NotNull(root);
                    Assert.NotNull(part.GetType().Name);
                    Assert.NotNull(part.Uri);
                    Assert.NotNull(root.GetFullName());
                }
            }
        }
    }
}
