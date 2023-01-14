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
    [InlineData(PackageCapabilities.Save, false)]
    [InlineData(PackageCapabilities.Reload, true)]
    [InlineData(PackageCapabilities.Save | PackageCapabilities.Reload, false)]
    [Theory]
    public void RequiredCapabilityCheck(PackageCapabilities capabilities, bool shouldUpdate)
    {
        // Arrange
        var featureCollection = new FeatureCollection();

        var feature = Substitute.For<IPackageFeature>();
        feature.Capabilities.Returns(capabilities);
        featureCollection.Set(feature);

        var package = Substitute.ForPartsOf<OpenXmlPackage>();
        package.Features.Returns(featureCollection);

        // Act
        var updatedPackage = package.EnableSavePackage();
        var updatedFeature = package.Features.GetRequired<IPackageFeature>();

        // Assert
        Assert.Same(package, updatedPackage);

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
        var featureCollection = new FeatureCollection();

        var feature = Substitute.For<IPackageFeature>();
        feature.Capabilities.Returns(PackageCapabilities.Reload);
        featureCollection.Set(feature);

        var package = Substitute.ForPartsOf<OpenXmlPackage>();
        package.Features.Returns(featureCollection);

        // Act
        package.EnableSavePackage();
        var updatedFeature = package.Features.GetRequired<IPackageFeature>();
        updatedFeature.Package.Save();

        // Assert
        feature.Received(1).Reload();
        Assert.Equal(PackageCapabilities.Reload | PackageCapabilities.Save, updatedFeature.Capabilities);
    }
}
