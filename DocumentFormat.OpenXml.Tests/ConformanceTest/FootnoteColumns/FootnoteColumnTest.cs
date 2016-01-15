// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
namespace DocumentFormat.OpenXml.Tests.FootnoteColumns
{
    using DocumentFormat.OpenXml.Packaging;
    using Xunit;
    using DocumentFormat.OpenXml.Tests;
    using DocumentFormat.OpenXml.Tests.FootnoteColumnsClass;

    using W15 = DocumentFormat.OpenXml.Office2013.Word;

    /// <summary>
    /// Test for Footnote Column
    /// </summary>
    public class FootnoteColumnsTest :
        ConformanceTestBase<GeneratedDocument, WordprocessingDocument, W15.FootnoteColumns>
    {
        private const int OriginalValue = 4;
        private const int ModifiedValue = 99;

        #region Test Methods
        /// <summary>
        /// Document Read/Write Test for FootnoteColumns
        /// </summary>
        [Fact]
        public void FootnoteColumnsReadWriteTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
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
        #endregion
    }
}
