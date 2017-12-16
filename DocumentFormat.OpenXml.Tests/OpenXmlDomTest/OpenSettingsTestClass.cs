// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using Xunit;
using Xunit.Abstractions;

using static DocumentFormat.OpenXml.Tests.TestAssets;

namespace DocumentFormat.OpenXml.Tests
{
    public class OpenSettingsTestClass : OpenXmlDomTestBase
    {
        public OpenSettingsTestClass(ITestOutputHelper output)
            : base(output)
        {
        }

        [Theory]
        [InlineData(MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly, int.MinValue)]
        [InlineData(MarkupCompatibilityProcessMode.ProcessAllParts, int.MinValue)]
        [InlineData(MarkupCompatibilityProcessMode.ProcessAllParts, -1)]
        [InlineData(MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly, -1)]
        [InlineData(MarkupCompatibilityProcessMode.ProcessAllParts, 0)]
        [InlineData(MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly, 0)]
        [InlineData(MarkupCompatibilityProcessMode.ProcessAllParts, 3)]
        [InlineData(MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly, 3)]
        [InlineData(MarkupCompatibilityProcessMode.ProcessAllParts, 5)]
        [InlineData(MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly, 5)]
        [InlineData(MarkupCompatibilityProcessMode.ProcessAllParts, 6)]
        [InlineData(MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly, 6)]
        [InlineData(MarkupCompatibilityProcessMode.ProcessAllParts, 7)]
        [InlineData(MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly, 7)]
        [InlineData(MarkupCompatibilityProcessMode.ProcessAllParts, int.MaxValue)]
        [InlineData(MarkupCompatibilityProcessMode.ProcessLoadedPartsOnly, int.MaxValue)]
        public void OpenWithInvalidFileFormatTest(MarkupCompatibilityProcessMode mode, int format)
        {
            using (var file = OpenFile(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, false))
            {
                var invalidSettings = new OpenSettings()
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(mode, (FileFormatVersions)format)
                };

                Assert.Throws<ArgumentException>(() =>
                {
                    using (var package = file.Open(false, invalidSettings))
                    {
                    }
                });
            }
        }

        [Theory]
        [InlineData(MarkupCompatibilityProcessMode.NoProcess, int.MinValue)]
        [InlineData(MarkupCompatibilityProcessMode.NoProcess, -1)]
        [InlineData(MarkupCompatibilityProcessMode.NoProcess, 0)]
        [InlineData(MarkupCompatibilityProcessMode.NoProcess, 3)]
        [InlineData(MarkupCompatibilityProcessMode.NoProcess, 5)]
        [InlineData(MarkupCompatibilityProcessMode.NoProcess, 6)]
        [InlineData(MarkupCompatibilityProcessMode.NoProcess, 7)]
        [InlineData(MarkupCompatibilityProcessMode.NoProcess, int.MaxValue)]
        public void OpenWithFileFormatVersionsDefaultValue(MarkupCompatibilityProcessMode mode, int format)
        {
            using (var file = OpenFile(TestDataStorage.V2FxTestFiles.Bvt.complex2005_12rtm, false))
            {
                var invalidSettings = new OpenSettings()
                {
                    MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(mode, (FileFormatVersions)format)
                };

                using (var package = file.Open(false, invalidSettings))
                {
                    Assert.NotNull(package);
                }
            }
        }
    }
}
