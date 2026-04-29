// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Drawing;
using Xunit;

namespace DocumentFormat.OpenXml.Tests.SimpleTypes;

public class BiLevelThresholdTests
{
    // Regression for https://github.com/dotnet/Open-XML-SDK/issues/2007
    // Office emits a:biLevel/@thresh using the ECMA-376 percentage string form ("50%")
    // instead of the 1000ths-of-a-percent integer form ("50000"). Loading such files
    // previously threw FormatException via Int32Value.Parse.
    [Theory]
    [InlineData("50%", 50000)]
    [InlineData("50000", 50000)]
    public void ParsesThreshold(string thresh, int expected)
    {
        var xml =
            $"<a:cont xmlns:a=\"http://schemas.openxmlformats.org/drawingml/2006/main\"><a:biLevel thresh=\"{thresh}\" /></a:cont>";
        var container = new EffectContainer(xml);

        var biLevel = Assert.IsType<BiLevel>(container.FirstChild);
        Assert.NotNull(biLevel.Threshold);
        Assert.Equal(expected, biLevel.Threshold!.Value);
    }
}
