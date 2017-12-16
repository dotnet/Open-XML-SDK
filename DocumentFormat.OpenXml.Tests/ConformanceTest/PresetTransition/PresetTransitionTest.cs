// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Tests.PresetTransitionClass;
using Xunit;
using Xunit.Abstractions;

using P15 = DocumentFormat.OpenXml.Office2013.PowerPoint;

namespace DocumentFormat.OpenXml.Tests.PresetTransition
{
    /// <summary>
    /// Test for Footnote Column
    /// </summary>

    public class PresetTransitionTest :
        ConformanceTestBase<GeneratedDocument, PresentationDocument, P15.PresetTransition>
    {
        private const string OriginalPresetTransition = "pageCurlDouble";
        private const string ModifiedPresetTransition = "pageCurlSingle";

        public PresetTransitionTest(ITestOutputHelper output)
            : base(output)
        {
        }

        #region Test Methods
        /// <summary>
        /// Document Read/Write Test for PresetTransition
        /// </summary>
        [Fact]
        public void PresetTransitionReadWriteTest()
        {
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
