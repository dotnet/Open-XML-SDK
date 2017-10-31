// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    public class Robustness
    {
        [Theory]
        [InlineData(TestAssets.TestDataStorage.Robustness.File00a5835dd770438aaa36c7cdcd4e61d1)]
        [InlineData(TestAssets.TestDataStorage.Robustness.File00a5888d6d634643acbb35c6f317cd75)]
        [InlineData(TestAssets.TestDataStorage.Robustness.File00bd6e64896c4ad0980ce7abdd4b0a52)]
        [InlineData(TestAssets.TestDataStorage.Robustness.File00c6a24ea99f42c1a26ba086b273f3f4)]
        [InlineData(TestAssets.TestDataStorage.Robustness.File00cb49edf9964a3b9bad8676e765c4b2)]
        [InlineData(TestAssets.TestDataStorage.Robustness.File00d43c8b890a4b6ca1010fe55f2dd917)]
        [InlineData(TestAssets.TestDataStorage.Robustness.File00D4EE78301DA16F3BF92631CA9B68E6)]
        [InlineData(TestAssets.TestDataStorage.Robustness.File00d63cddee444e6a99afa7966ffbdda0)]
        [InlineData(TestAssets.TestDataStorage.Robustness.File00df219ff99a4e93b049a666df53894c)]
        public void OFCATFull(string entry)
        {
            using (var stream = TestAssets.GetStream(entry))
            using (var doc = SpreadsheetDocument.Open(stream, false))
            {
                var validator = new OpenXmlValidator(FileFormatVersions.Office2013);
                var validateResults = validator.Validate(doc);

                Assert.Empty(validateResults);
            }
        }
    }
}
