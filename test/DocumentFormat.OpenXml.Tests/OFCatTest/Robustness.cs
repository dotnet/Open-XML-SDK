// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation;
using Xunit;

using static DocumentFormat.OpenXml.Tests.TestAssets;

namespace DocumentFormat.OpenXml.Tests
{
    public class Robustness
    {
        [Theory]
        [InlineData(TestDataStorage.Robustness.File00a5835dd770438aaa36c7cdcd4e61d1)]
        [InlineData(TestDataStorage.Robustness.File00a5888d6d634643acbb35c6f317cd75)]
        [InlineData(TestDataStorage.Robustness.File00bd6e64896c4ad0980ce7abdd4b0a52)]
        [InlineData(TestDataStorage.Robustness.File00c6a24ea99f42c1a26ba086b273f3f4)]
        [InlineData(TestDataStorage.Robustness.File00cb49edf9964a3b9bad8676e765c4b2)]
        [InlineData(TestDataStorage.Robustness.File00d43c8b890a4b6ca1010fe55f2dd917)]
        [InlineData(TestDataStorage.Robustness.File00D4EE78301DA16F3BF92631CA9B68E6)]
        [InlineData(TestDataStorage.Robustness.File00d63cddee444e6a99afa7966ffbdda0)]
        [InlineData(TestDataStorage.Robustness.File00df219ff99a4e93b049a666df53894c)]
        public void OFCATFull(string entry)
        {
            using (var stream = GetStream(entry))
            using (var doc = SpreadsheetDocument.Open(stream, false))
            {
                var validator = new OpenXmlValidator(FileFormatVersions.Office2013);
                var validateResults = validator.Validate(doc);

                Assert.Empty(validateResults);
            }
        }
    }
}
