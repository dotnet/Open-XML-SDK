// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Packaging.Builder;
using NSubstitute;
using System.IO;
using Xunit;

namespace DocumentFormat.OpenXml.Framework.Tests.Features;

public class SaveablePackageTests
{
    [InlineData((int)PackageCapabilities.Save, FileAccess.Read, false)]
    [InlineData((int)PackageCapabilities.Save, FileAccess.ReadWrite, false)]
    [InlineData((int)PackageCapabilities.Reload, FileAccess.Read, false)]
    [InlineData((int)PackageCapabilities.Reload, FileAccess.ReadWrite, true)]
    [InlineData((int)PackageCapabilities.Save | (int)PackageCapabilities.Reload, FileAccess.Read, false)]
    [InlineData((int)PackageCapabilities.Save | (int)PackageCapabilities.Reload, FileAccess.ReadWrite, false)]
    [Theory]
    public void RequiredCapabilityCheck(int intCapabilities, FileAccess access, bool shouldUpdate)
    {
        // Arrange
        var capabilities = (PackageCapabilities)intCapabilities;
        var features = new FeatureCollection();

        var package = Substitute.For<IPackage>();
        package.FileOpenAccess.Returns(access);

        var feature = Substitute.For<IPackageFeature>();
        feature.Capabilities.Returns(capabilities);
        feature.Package.Returns(package);

        features.Set(feature);

        // Act
        var updatedFeatures = features.EnableSavePackage();

        // Assert
        var updatedFeature = features.GetRequired<IPackageFeature>();
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
