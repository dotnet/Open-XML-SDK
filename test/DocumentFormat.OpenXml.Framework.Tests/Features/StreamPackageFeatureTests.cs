// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Builder;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using NSubstitute;
using System;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using Xunit;

using static DocumentFormat.OpenXml.Tests.TestAssets;

namespace DocumentFormat.OpenXml.Features.Tests;

public class StreamPackageFeatureTests
{
    [Fact]
    public void NoNull()
    {
        Assert.Throws<ArgumentNullException>(() => new StreamPackageFeature(null!, PackageOpenMode.Read));
    }

    [Fact]
    public void StreamMustBeReadable()
    {
        // Arrange
        var stream = Substitute.ForPartsOf<Stream>();
        stream.CanRead.Returns(false);

        // Act
        Assert.Throws<OpenXmlPackageException>(() => new StreamPackageFeature(stream, PackageOpenMode.ReadWrite));
    }

    [InlineData((int)PackageOpenMode.Create)]
    [InlineData((int)PackageOpenMode.ReadWrite)]
    [Theory]
    public void StreamMustBeWriteable(int intMode)
    {
        // Arrange
        var mode = (PackageOpenMode)intMode;
        var stream = Substitute.ForPartsOf<Stream>();
        stream.CanRead.Returns(true);
        stream.CanWrite.Returns(false);

        Assert.Throws<OpenXmlPackageException>(() => new StreamPackageFeature(stream, mode));
    }

    [InlineData((int)PackageOpenMode.Create, FileAccess.ReadWrite, true)]
    [InlineData((int)PackageOpenMode.Read, FileAccess.Read, false)]
    [InlineData((int)PackageOpenMode.ReadWrite, FileAccess.ReadWrite, true)]
    [Theory]
    public void ValidateCapabilities(int intMode, FileAccess access, bool canSave)
    {
        // Arrange
        var mode = (PackageOpenMode)intMode;
        using var stream = CreateSimplePackage();
        using var package = new StreamPackageFeature(stream, mode);

        var asFeature = (IPackageFeature)package;
        var asPackage = asFeature.Package;

        var canSaveExpected
#if NETFRAMEWORK
            = canSave;
#else
            = false;
#endif

        var largeParts
#if NETFRAMEWORK
            = true;
#else
            = false;
#endif

        // Act/Assert
        Assert.Equal(canSave, package.Stream.CanWrite);
        Assert.Equal(access, asPackage.FileOpenAccess);
        Assert.Equal(canSaveExpected, asFeature.Capabilities.HasFlagFast(PackageCapabilities.Save));
        Assert.True(asFeature.Capabilities.HasFlagFast(PackageCapabilities.Cached));
        Assert.True(asFeature.Capabilities.HasFlagFast(PackageCapabilities.Reload));
        Assert.Equal(largeParts, asFeature.Capabilities.HasFlagFast(PackageCapabilities.LargePartStreams));
    }

    [Fact]
    public void GetRelationships()
    {
        // Arrange
        using var stream = CreateSimplePackage();
        using var feature = new StreamPackageFeature(stream, PackageOpenMode.Read);
        var package = (IPackage)feature;

        // Act
        var relationships = package.Relationships.ToList();

        Assert.Collection(
            relationships,
            r =>
            {
                Assert.Equal(Relationship1.Relationship, r.RelationshipType);
                Assert.Equal(Relationship1.Mode, r.TargetMode);
                Assert.Equal(Relationship1.TargetUri, r.TargetUri);
                Assert.Equal(Relationship1.Id, r.Id);
            },
            r =>
            {
                Assert.Equal(Relationship2.Relationship, r.RelationshipType);
                Assert.Equal(Relationship2.Mode, r.TargetMode);
                Assert.Equal(Relationship2.TargetUri, r.TargetUri);
                Assert.Equal(Relationship2.Id, r.Id);
            });
    }

    [Fact]
    public void RelationshipsCached()
    {
        // Arrange
        using var stream = CreateSimplePackage();
        using var feature = new StreamPackageFeature(stream, PackageOpenMode.Read);
        var package = (IPackage)feature;

        // Act
        var relationships1 = package.Relationships.ToList();
        var relationships2 = package.Relationships.ToList();

        // Assert
        Assert.Equal(2, relationships1.Count);
        Assert.Equal(2, relationships2.Count);
        Assert.Same(relationships1[0], relationships2[0]);
        Assert.Same(relationships1[1], relationships2[1]);
    }

    [Fact]
    public void RelationshipCached()
    {
        // Arrange
        using var stream = CreateSimplePackage();
        using var feature = new StreamPackageFeature(stream, PackageOpenMode.Read);
        var package = (IPackage)feature;

        // Act
        var relationship1 = package.Relationships[Relationship1.Id];
        var relationship2 = package.Relationships[Relationship1.Id];

        // Assert
        Assert.Same(relationship1, relationship2);
    }

    [Fact]
    public void RelationshipRemoved()
    {
        // Arrange
        using var stream = CreateSimplePackage();
        using var feature = new StreamPackageFeature(stream, PackageOpenMode.ReadWrite);
        var package = (IPackage)feature;

        // Act/Assert
        Assert.NotNull(package.Relationships[Relationship1.Id]); // This will cache the relationship
        package.Relationships.Remove(Relationship1.Id);
        Assert.Throws<InvalidOperationException>(() => package.Relationships[Relationship1.Id]);
    }

    [Fact]
    public void GetParts()
    {
        // Arrange
        using var stream = CreateSimplePackage();
        using var feature = new StreamPackageFeature(stream, PackageOpenMode.Read);
        var package = (IPackage)feature;

        // Act
        var result = package.GetParts();

        // Assert
        Assert.Collection(
            result,
            p =>
            {
                Assert.Equal(Part1.Uri, p.Uri);
                Assert.Equal(Part1.ContentType, p.ContentType);
            },
            p =>
            {
                Assert.Equal(Part2.Uri, p.Uri);
                Assert.Equal(Part2.ContentType, p.ContentType);
            },
            p =>
            {
                Assert.Equal(PartRels.Uri, p.Uri);
                Assert.Equal(PartRels.ContentType, p.ContentType);
            },
            p =>
            {
                Assert.Equal(Part1Rels.Uri, p.Uri);
                Assert.Equal(Part1Rels.ContentType, p.ContentType);
            });
    }

    [Fact]
    public void GetPartsCached()
    {
        // Arrange
        using var stream = CreateSimplePackage();
        using var feature = new StreamPackageFeature(stream, PackageOpenMode.Read);
        var package = (IPackage)feature;

        // Act
        var parts1 = package.GetParts().ToList();
        var parts2 = package.GetParts().ToList();

        // Act
        Assert.Same(parts1[0], parts2[0]);
        Assert.Same(parts1[1], parts2[1]);
    }

    [Fact]
    public void GetPart()
    {
        // Arrange
        using var stream = CreateSimplePackage();
        using var feature = new StreamPackageFeature(stream, PackageOpenMode.Read);
        var package = (IPackage)feature;

        // Act
        var result = package.GetPart(Part1.Uri);

        // Assert
        Assert.Equal(Part1.Uri, result.Uri);
        Assert.Equal(Part1.ContentType, result.ContentType);
    }

    [Fact]
    public void GetPartCached()
    {
        // Arrange
        using var stream = CreateSimplePackage();
        using var feature = new StreamPackageFeature(stream, PackageOpenMode.Read);
        var package = (IPackage)feature;

        // Act
        var result1 = package.GetPart(Part1.Uri);
        var result2 = package.GetPart(Part1.Uri);

        // Assert
        Assert.Same(result1, result2);
    }

    [Fact]
    public void PackagePartAfterReload()
    {
        // Arrange
        using var stream = CreateSimplePackage();
        using var streamFeature = new StreamPackageFeature(stream, PackageOpenMode.Read);
        var feature = (IPackageFeature)streamFeature;

        // Act
        var part1Before = feature.Package.GetPart(Part1.Uri);
        feature.Reload();
        var part1After = feature.Package.GetPart(Part1.Uri);

        // Assert
        Assert.Same(part1Before, part1After);
        Assert.Equal(part1After.Uri, part1Before.Uri);
        Assert.Equal(part1After.ContentType, part1Before.ContentType);
    }

    [Fact]
    public void PackagePartReloadingWhenPacakgeIsCreated()
    {
        // Arrange
        using var stream = new MemoryStream();
        using var streamFeature = new StreamPackageFeature(stream, PackageOpenMode.Create);
        var feature = (IPackageFeature)streamFeature;

        // Act
        var part1Before = feature.Package.CreatePart(Part1.Uri, Part1.ContentType, CompressionOption.Normal);
        feature.Reload();
        var part1After = feature.Package.GetPart(Part1.Uri);

        // Assert
        Assert.Same(part1Before, part1After);
        Assert.Equal(part1After.Uri, part1Before.Uri);
        Assert.Equal(part1After.ContentType, part1Before.ContentType);
    }

    [Fact]
    public void PackageRelationshipAfterReload()
    {
        // Arrange
        using var stream = CreateSimplePackage();
        using var streamFeature = new StreamPackageFeature(stream, PackageOpenMode.Read);
        var feature = (IPackageFeature)streamFeature;

        // Act
        var relationshipsBefore = feature.Package.Relationships.ToList();
        feature.Reload();
        var relationshipsAfter = feature.Package.Relationships.ToList();

        // Assert
        Assert.Same(relationshipsBefore[0], relationshipsAfter[0]);
        Assert.Same(relationshipsBefore[1], relationshipsAfter[1]);

        Assert.Equal(Relationship1.Id, relationshipsAfter[0].Id);
        Assert.Equal(Relationship1.Mode, relationshipsAfter[0].TargetMode);
        Assert.Equal(Relationship1.Relationship, relationshipsAfter[0].RelationshipType);
        Assert.Equal(Relationship1.TargetUri, relationshipsAfter[0].TargetUri);
    }

    [Fact]
    public void PartRelationship()
    {
        // Arrange
        using var stream = CreateSimplePackage();
        using var streamFeature = new StreamPackageFeature(stream, PackageOpenMode.Read);
        var feature = (IPackageFeature)streamFeature;
        var part = feature.Package.GetPart(Part1.Uri);

        // Act
        var relationship = part.Relationships[Part1Relationship1.Id];

        // Assert
        Assert.Equal(Part1Relationship1.Id, relationship.Id);
        Assert.Equal(Part1Relationship1.Relationship, relationship.RelationshipType);
        Assert.Equal(Part1Relationship1.Mode, relationship.TargetMode);
        Assert.Equal(Part1Relationship1.TargetUri, relationship.TargetUri);
    }

    [Fact]
    public void PartRelationshipRemoved()
    {
        // Arrange
        using var stream = CreateSimplePackage();
        using var streamFeature = new StreamPackageFeature(stream, PackageOpenMode.ReadWrite);
        var feature = (IPackageFeature)streamFeature;
        var part = feature.Package.GetPart(Part1.Uri);

        // Act/Assert
        Assert.NotNull(part.Relationships[Part1Relationship1.Id]); // This will cache the relationship
        part.Relationships.Remove(Part1Relationship1.Id);
        Assert.Throws<InvalidOperationException>(() => part.Relationships[Part1Relationship1.Id]);
    }

    [Fact]
    public void PartGetRelationships()
    {
        // Arrange
        using var stream = CreateSimplePackage();
        using var streamFeature = new StreamPackageFeature(stream, PackageOpenMode.Read);
        var feature = (IPackageFeature)streamFeature;
        var part = feature.Package.GetPart(Part1.Uri);

        // Act
        var relationships = part.Relationships;

        // Assert
        Assert.Collection(
            relationships,
            r =>
            {
                Assert.Equal(Part1Relationship1.Id, r.Id);
                Assert.Equal(Part1Relationship1.Relationship, r.RelationshipType);
                Assert.Equal(Part1Relationship1.Mode, r.TargetMode);
                Assert.Equal(Part1Relationship1.TargetUri, r.TargetUri);
            });
    }

    [Fact]
    public void PartGetRelationshipsCached()
    {
        // Arrange
        using var stream = CreateSimplePackage();
        using var streamFeature = new StreamPackageFeature(stream, PackageOpenMode.Read);
        var feature = (IPackageFeature)streamFeature;
        var part = feature.Package.GetPart(Part1.Uri);

        // Act
        var relationshipFromEnumerable = part.Relationships.Single();
        var relationship = part.Relationships[Part1Relationship1.Id];

        // Assert
        Assert.Same(relationship, relationshipFromEnumerable);
    }

    [Fact]
    public void PartReload()
    {
        // Arrange
        using var stream = CreateSimplePackage();
        using var streamFeature = new StreamPackageFeature(stream, PackageOpenMode.Read);
        var feature = (IPackageFeature)streamFeature;
        var part = feature.Package.GetPart(Part1.Uri);

        // Act
        var relationshipBefore = part.Relationships[Part1Relationship1.Id];
        feature.Reload();
        var relationshipAfter = part.Relationships[Part1Relationship1.Id];

        // Assert
        Assert.Same(relationshipBefore, relationshipAfter);
    }

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void OpenInvalidStreamFailsGracefully(bool isOwned)
    {
        // Arrange
        var stream = new DisposingWatcherInvalidStream([1, 2, 3, 4]);

        // Act
        Assert.Throws<FileFormatException>(() => new StreamPackageFeature(stream, PackageOpenMode.Read, isOwned: isOwned));

        // Assert
        Assert.Equal(isOwned, stream.IsDisposed);
    }

    private sealed class DisposingWatcherInvalidStream : DelegatingStream
    {
        public DisposingWatcherInvalidStream(byte[] bytes)
            : base(new MemoryStream(bytes))
        {
        }

        public bool IsDisposed { get; private set; }

        protected override void Dispose(bool disposing)
        {
            IsDisposed = true;
            base.Dispose(disposing);
        }
    }

    [Fact]
    public void ThrowsForEncryptedOfficeFile()
    {
        using (Stream stream = GetStream(TestFiles.Encrypted_pptx, false))
        {
            // Act & Assert
            var ex = Assert.Throws<OpenXmlPackageException>(() => new StreamPackageFeature(stream, PackageOpenMode.Read, isOwned: true));
            Assert.Equal(ExceptionMessages.EncryptedPackageNotSupported, ex.Message);
        }
    }

    private static readonly PartInfo Part1 = new(new("/part1", UriKind.Relative), "type1/content");
    private static readonly PartInfo Part2 = new(new("/part2", UriKind.Relative), "type2/content");
    private static readonly PartInfo PartRels = new(new("/_rels/.rels", UriKind.Relative), "application/vnd.openxmlformats-package.relationships+xml");
    private static readonly PartInfo Part1Rels = new(new("/_rels/part1.rels", UriKind.Relative), "application/vnd.openxmlformats-package.relationships+xml");

    private static readonly RelationshipInfo Relationship1 = new(new("/relationship1", UriKind.Relative), TargetMode.Internal, "relationship1", "id1");
    private static readonly RelationshipInfo Relationship2 = new(new("/relationship2", UriKind.Relative), TargetMode.Internal, "relationship2", "id2");
    private static readonly RelationshipInfo Part1Relationship1 = new(new("/part1Relationship1", UriKind.Relative), TargetMode.Internal, "p1relationship2", "p1id2");

    private record PartInfo(Uri Uri, string ContentType);

    private record RelationshipInfo(Uri TargetUri, TargetMode Mode, string Relationship, string Id);

    private static Stream CreateSimplePackage()
    {
        var stream = new MemoryStream();
        var package = Package.Open(stream, FileMode.CreateNew);

        var part1 = package.CreatePart(Part1.Uri, Part1.ContentType);
        part1.CreateRelationship(Part1Relationship1.TargetUri, Part1Relationship1.Mode, Part1Relationship1.Relationship, Part1Relationship1.Id);

        package.CreatePart(Part2.Uri, Part2.ContentType);

        package.CreateRelationship(Relationship1.TargetUri, Relationship1.Mode, Relationship1.Relationship, Relationship1.Id);
        package.CreateRelationship(Relationship2.TargetUri, Relationship2.Mode, Relationship2.Relationship, Relationship2.Id);

        package.Close();

        stream.Position = 0;

        return stream;
    }
}
