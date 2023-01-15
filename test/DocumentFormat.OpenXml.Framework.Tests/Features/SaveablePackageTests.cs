// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Packaging.Builder;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DocumentFormat.OpenXml.Framework.Tests.Features;

public class SaveablePackageTests
{
    [InlineData((int)PackageCapabilities.Save, false)]
    [InlineData((int)PackageCapabilities.Reload, true)]
    [InlineData((int)PackageCapabilities.Save | (int)PackageCapabilities.Reload, false)]
    [Theory]
    public void RequiredCapabilityCheck(int intCapabilities, bool shouldUpdate)
    {
        // Arrange
        var capabilities = (PackageCapabilities)intCapabilities;
        var features = new FeatureCollection();

        var feature = Substitute.For<IPackageFeature>();
        feature.Capabilities.Returns(capabilities);
        features.Set(feature);

        // Act
        var updatedFeatures = features.EnableSavePackage();
        var updatedFeature = features.GetRequired<IPackageFeature>();

        // Assert
        Assert.Same(features, updatedFeatures);

        if (shouldUpdate)
        {
            Assert.Equal(updatedFeature.Capabilities, capabilities | PackageCapabilities.Save);
            Assert.NotSame(feature, updatedFeature);
        }
        else
        {
            Assert.Same(feature, updatedFeature);
        }
    }

    [Fact]
    public void SaveCallsReload()
    {
        // Arrange
        var features = new FeatureCollection();

        var feature = Substitute.For<IPackageFeature>();
        feature.Capabilities.Returns(PackageCapabilities.Reload);
        features.Set(feature);

        // Act
        features.EnableSavePackage();
        var updatedFeature = features.GetRequired<IPackageFeature>();
        updatedFeature.Package.Save();

        // Assert
        feature.Received(1).Reload();
        Assert.Equal(PackageCapabilities.Reload | PackageCapabilities.Save, updatedFeature.Capabilities);
    }
}
