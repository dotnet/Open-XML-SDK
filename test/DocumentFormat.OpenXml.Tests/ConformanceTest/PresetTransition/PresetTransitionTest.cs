// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Tests.PresetTransitionClass;
using Xunit;

using P15 = DocumentFormat.OpenXml.Office2013.PowerPoint;

namespace DocumentFormat.OpenXml.Tests.PresetTransition
{
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
            SimpleReadWriteTest(
                (e) =>
                {
                    Assert.Equal(OriginalPresetTransition, e.Preset.Value);
                    Assert.Equal(true, e.InvX.Value);
                    Assert.Null(e.InvY);
                },
                (e) =>
                {
                    e.Preset.Value = ModifiedPresetTransition;
                    e.InvX = new BooleanValue(false);
                    e.InvY = new BooleanValue(true);
                },
                (e) =>
                {
                    Assert.Equal(ModifiedPresetTransition, e.Preset.Value);
                    Assert.Equal(false, e.InvX.Value);
                    Assert.Equal(true, e.InvY.Value);
                });
        }
        #endregion
    }
}
