// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Tests.FootnoteColumnsClass;
using Xunit;
using Xunit.Abstractions;

using W15 = DocumentFormat.OpenXml.Office2013.Word;

namespace DocumentFormat.OpenXml.Tests.FootnoteColumns
{
    /// <summary>
    /// Test for Footnote Column
    /// </summary>
    public class FootnoteColumnsTest :
        ConformanceTestBase<GeneratedDocument, WordprocessingDocument, W15.FootnoteColumns>
    {
        private const int OriginalValue = 4;
        private const int ModifiedValue = 99;

        public FootnoteColumnsTest(ITestOutputHelper output)
            : base(output)
        {
        }

        /// <summary>
        /// Document Read/Write Test for FootnoteColumns
        /// </summary>
        [Fact]
        public void FootnoteColumnsReadWriteTest()
        {
            this.SimpleReadWriteTest(
                (e) =>
                {
                    this.Log.VerifyValue(
                        e.Val.Value, OriginalValue,
                        "Verified 'Val' attribute of <W15:footnoteColumns>");
                },
                (e) =>
                {
                    e.Val.Value = ModifiedValue;
                },
                (e) =>
                {
                    this.Log.VerifyValue(
                        e.Val.Value, ModifiedValue,
                        "Verified the updated attribute");
                });
        }
    }
}
