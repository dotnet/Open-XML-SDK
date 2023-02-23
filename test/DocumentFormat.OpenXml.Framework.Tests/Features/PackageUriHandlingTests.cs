// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Packaging.Builder;
using NSubstitute;
using System;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using Xunit;

namespace DocumentFormat.OpenXml.Framework.Tests.Features;

public class PackageUriHandlingTests
{
    [InlineData((int)PackageCapabilities.MalformedUri, false)]
    [InlineData((int)PackageCapabilities.Save, true)]
    [Theory]
    public void RequiredCapabilityCheck(int intCapabilities, bool shouldUpdate)
    {
        // Arrange
        var capabilities = (PackageCapabilities)intCapabilities;
        var features = new FeatureCollection();

        var disposable = Substitute.For<IDisposableFeature>();
        var feature = Substitute.For<IPackageFeature>();
        feature.Capabilities.Returns(capabilities);
        var filter = Substitute.For<IRelationshipFilterFeature>();

        features.Set(filter);
        features.Set(feature);
        features.Set(disposable);

        // Act
        var updatedFeatures = features.EnableUriHandling();

        // Assert
        var updatedFeature = features.GetRequired<IPackageFeature>();
        Assert.Same(features, updatedFeatures);

        if (shouldUpdate)
        {
            Assert.Equal(updatedFeature.Capabilities, capabilities | PackageCapabilities.MalformedUri);
            Assert.NotSame(feature, updatedFeature);
        }
        else
        {
            Assert.Same(feature, updatedFeature);
        }
    }

    [Fact]
    public void RegisterFeatureForDisposal()
    {
        // Arrange
        var features = new FeatureCollection();

        var disposable = Substitute.For<IDisposableFeature>();
        var feature = Substitute.For<IPackageFeature>();
        feature.Capabilities.Returns(PackageCapabilities.Save);
        var filter = Substitute.For<IRelationshipFilterFeature>();

        features.Set(filter);

        features.Set(disposable);
        features.Set(feature);

        // Act
        features.EnableUriHandling();
        var newFeature = features.GetRequired<IPackageFeature>();

        // Assert
        disposable.Received(1).Register((IDisposable)newFeature);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void ThrowsIfNotEnabled(bool isReadOnly)
    {
        // Arrange
        var features = new FeatureCollection();

        var disposable = Substitute.For<IDisposableFeature>();
        features.Set(disposable);

        var package = AddPackage(features, isReadOnly)
            .GetRequired<IPackageFeature>();
        var expected = package.Capabilities.HasFlagFast(PackageCapabilities.MalformedUri);

        // Act/Assert
        var part = package.Package.GetPart(Part1.Uri);

        if (expected)
        {
            Assert.Throws<UriFormatException>(() => part.Relationships);
        }
        else
        {
            Assert.NotNull(part.Relationships);
        }
    }

    [InlineData(true)]
    [InlineData(false)]
    [Theory]
    public void SinglePartMalformed(bool isReadOnly)
    {
        // Arrange
        var features = new FeatureCollection();

        var disposable = Substitute.For<IDisposableFeature>();
        features.Set(disposable);

        var package = AddPackage(features, isReadOnly)
            .EnableUriHandling()
            .GetRequired<IPackageFeature>();

        // Act
        var part = package.Package.GetPart(Part1.Uri);
        var relationships = part.Relationships;

        // Assert
        Assert.Collection(
            relationships,
            r =>
            {
                Assert.Equal(r.Id, Relationship1.Id);
                Assert.Equal(r.TargetMode, Relationship1.Mode);
                Assert.Equal(r.TargetUri.ToString(), Relationship1.Target);
                Assert.Equal("rewritten", r.TargetUri.Scheme);
            });
    }

    [InlineData(true)]
    [InlineData(false)]
    [Theory]
    public void SinglePartMalformedRoundtrips(bool isReadOnly)
    {
        // Arrange
        var stream = new MemoryStream();
        var features = new FeatureCollection();

        using (var disposable = new DisposableFeature())
        {
            features.Set<IDisposableFeature>(disposable);

            var package = AddPackage(features, stream, isReadOnly)
                .EnableUriHandling()
                .GetRequired<IPackageFeature>();

            // Act
            var part = package.Package.GetPart(Part1.Uri);
            _ = part.Relationships;
        }

        // Assert
        var contents = GetPartContents(stream, Part1.Uri);
        var expected = GetRelationshipContents(Relationship1);

        Assert.Equal(expected, contents);
    }

    private string GetPartContents(Stream stream, Uri uri)
    {
        stream.Position = 0;

        using var package = Package.Open(stream);
        var part = package.GetPart(PackUriHelper.GetRelationshipPartUri(uri));
        using var partStream = part.GetStream();
        using var reader = new StreamReader(partStream);
        return reader.ReadToEnd();
    }

    private static readonly PartInfo Part1 = new(new("/part1", UriKind.Relative), "type1/content");
    private static readonly PartInfo Part2 = new(new("/part2", UriKind.Relative), "type2/content");

    private static readonly RelationshipInfo Relationship1 = new("mailto:test@", TargetMode.External, "relationship1", "id1");

    private record PartInfo(Uri Uri, string ContentType);

    private record RelationshipInfo(string Target, TargetMode Mode, string Relationship, string Id)
    {
        public Uri TargetUri => new Uri(Target, UriKind.RelativeOrAbsolute);
    }

    private static IFeatureCollection AddPackage(IFeatureCollection features, bool isReadOnly)
    {
        var stream = new MemoryStream();
        return AddPackage(features, stream, isReadOnly);
    }

    private static IFeatureCollection AddPackage(IFeatureCollection features, Stream stream, bool isReadOnly)
    {
        CreateSimplePackage(stream);
        AddProblemRelationships(stream);

        var package = Substitute.ForPartsOf<OpenXmlPackage>();
        package.Features.Returns(features);

        package.WithStorage(stream, isReadOnly ? PackageOpenMode.Read : PackageOpenMode.ReadWrite);

        return features.EnableSavePackage();
    }

    private static void CreateSimplePackage(Stream stream)
    {
        var package = Package.Open(stream, FileMode.CreateNew);

        package.CreatePart(Part1.Uri, Part1.ContentType);
        package.CreatePart(Part2.Uri, Part2.ContentType);

        package.Close();

        stream.Position = 0;
    }

    private static void AddProblemRelationships(Stream stream)
    {
        using var package = Package.Open(stream, FileMode.Open);
        var part = package.CreatePart(PackUriHelper.GetRelationshipPartUri(Part1.Uri), "application/vnd.openxmlformats-package.relationships+xml");

        using (var partStream = part.GetStream(FileMode.Create, FileAccess.Write))
        {
            var bytes = Encoding.UTF8.GetBytes(GetRelationshipContents(Relationship1));
            partStream.Write(bytes, 0, bytes.Length);
        }

        stream.Position = 0;
    }

    private static string GetRelationshipContents(RelationshipInfo relationship)
    {
        return $"""
            <?xml version="1.0" encoding="utf-8"?>
            <Relationships xmlns="http://schemas.openxmlformats.org/package/2006/relationships">
              <Relationship Type="{relationship.Relationship}" TargetMode="{relationship.Mode}" Target="{relationship.Target}" Id="{relationship.Id}" />
            </Relationships>
            """;
    }

    private sealed class DisposableFeature : IDisposableFeature, IDisposable
    {
        private Action _dispose;

        void IDisposable.Dispose() => _dispose?.Invoke();

        void IDisposableFeature.Register(IDisposable disposable)
            => _dispose = disposable.Dispose + _dispose;
    }
}
