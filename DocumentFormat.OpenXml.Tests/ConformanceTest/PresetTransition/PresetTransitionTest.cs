// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
namespace DocumentFormat.OpenXml.Tests.PresetTransition
{
    using DocumentFormat.OpenXml;
    using DocumentFormat.OpenXml.Packaging;
    using Xunit;
    using DocumentFormat.OpenXml.Tests;
    using DocumentFormat.OpenXml.Tests.PresetTransitionClass;
    using P15 = DocumentFormat.OpenXml.Office2013.PowerPoint;

    /// <summary>
    /// Test for Footnote Column
    /// </summary>
    
    public class PresetTransitionTest :
        ConformanceTestBase<GeneratedDocument, PresentationDocument, P15.PresetTransition>
    {
        private const string OriginalPresetTransition = "pageCurlDouble";
        private const string ModifiedPresetTransition = "pageCurlSingle";

        #region Test Methods
        /// <summary>
        /// Document Read/Write Test for PresetTransition
        /// </summary>
        [Fact]
        public void PresetTransitionReadWriteTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            this.SimpleReadWriteTest(
                (e) =>
                {
                    this.Log.VerifyValue(
                        e.Preset.Value, OriginalPresetTransition,
                        "Verified 'Preset' attribute of <P15:prstTrans>");
                    this.Log.VerifyValue(e.InvX.Value, true,
                        "Verified 'InvX' attribute of <P15:prstTrans>");
                    this.Log.VerifyNull(e.InvY, "Verified 'InvY' attribute of <P15:prstTrans>");
                },
                (e) =>
                {
                    e.Preset.Value = ModifiedPresetTransition;
                    e.InvX = new BooleanValue(false);
                    e.InvY = new BooleanValue(true);
                },
                (e) =>
                {
                    this.Log.VerifyValue(
                        e.Preset.Value, ModifiedPresetTransition,
                        "Verified the updated attribute");
                    this.Log.VerifyValue(e.InvX.Value, false,
                        "Verified 'InvX' attribute of <P15:prstTrans>");
                    this.Log.VerifyValue(e.InvY.Value, true,
                        "Verified 'InvY' attribute of <P15:prstTrans>");
                });
        }
        #endregion
    }
}
