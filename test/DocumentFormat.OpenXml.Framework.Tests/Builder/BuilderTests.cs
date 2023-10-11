// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Builder;
using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework.Tests.Builder;
using DocumentFormat.OpenXml.Packaging;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace DocumentFormat.OpenXml.Framework.Tests.Builder;

public class BuilderTests
{
    [Fact]
    public void NoConfigureCalls()
    {
        // Arrange
        var builder = new Builder();

        // Act
        var result = builder.Open();

        // Arrange
        Assert.NotNull(result);
    }

    [Fact]
    public void SingleConfigureCall()
    {
        // Arrange
        var builder = new Builder();

        // Act
        var result = builder
            .Use(package => Add(package, 1))
            .Open();

        // Arrange
        Assert.Equal(GetList(result), new[] { 1 });
    }

    [Fact]
    public void TwoConfigureCalls()
    {
        // Arrange
        var builder = new Builder();

        // Act
        var result = builder
            .Use(package => Add(package, 1))
            .Use(package => Add(package, 2))
            .Open();

        // Arrange
        Assert.Equal(GetList(result), new[] { 1, 2 });
    }

    [Fact]
    public void CallBeforeAndAfter()
    {
        // Arrange
        var builder = new Builder();

        // Act
        var result = builder
            .Use((package, next) =>
            {
                Add(package, 1);
                next(package);
                Add(package, 4);
            })
            .Use((package, next) =>
            {
                Add(package, 2);
                next(package);
                Add(package, 3);
            })
            .Open();

        // Arrange
        Assert.Equal(GetList(result), new[] { 1, 2, 3, 4 });
    }

    [Fact]
    public void Branching()
    {
        // Arrange
        var builder1 = new Builder();

        // Act
        builder1
            .Use((package, next) =>
            {
                Add(package, 1);
                next(package);
                Add(package, 2);
            })
            .Use((package, next) =>
            {
                Add(package, 3);
                next(package);
                Add(package, 4);
            });

        var builder2 = builder1.New()
            .Use((package, next) =>
            {
                Add(package, 5);
                next(package);
                Add(package, 6);
            });

        // Arrange
        Assert.Equal(GetList(builder2.Open()), new[] { 1, 3, 5, 6, 4, 2 });
        Assert.Equal(GetList(builder1.Open()), new[] { 1, 3, 4, 2 });
        Assert.Equal(GetList(builder2.Open()), new[] { 1, 3, 5, 6, 4, 2 });
    }

    [Fact]
    public void Cloning()
    {
        // Arrange
        var builder = new Builder()
            .Use((package, next) =>
            {
                Add(package, 1);
                next(package);
                Add(package, 2);
            })
            .Use((package, next) =>
            {
                Add(package, 3);
                next(package);
                Add(package, 4);
            });

        // Act
        var package = builder.Open(new MemoryStream(), PackageOpenMode.Create);
        var cloned = package.Clone();

        // Arrange
        Assert.Equal(GetList(package), new[] { 1, 3, 4, 2 });
        Assert.Equal(GetList(cloned), new[] { 1, 3, 4, 2 });
    }

    [Fact]
    public void BranchingWithChangesToOriginal()
    {
        // Arrange
        var builder1 = new Builder();

        // Act
        builder1
            .Use((package, next) =>
            {
                Add(package, 1);
                next(package);
                Add(package, 2);
            })
            .Use((package, next) =>
            {
                Add(package, 3);
                next(package);
                Add(package, 4);
            });

        var builder2 = builder1.New()
            .Use((package, next) =>
            {
                Add(package, 5);
                next(package);
                Add(package, 6);
            });

        builder1
            .Use((package, next) =>
            {
                Add(package, 7);
                next(package);
                Add(package, 8);
            });

        // Arrange
        Assert.Equal(GetList(builder2.Open()), new[] { 1, 3, 5, 6, 4, 2 });
        Assert.Equal(GetList(builder1.Open()), new[] { 1, 3, 7, 8, 4, 2 });
        Assert.Equal(GetList(builder2.Open()), new[] { 1, 3, 5, 6, 4, 2 });
    }

    [Fact]
    public void TwoWayBranching()
    {
        // Arrange
        var builder1 = new Builder();

        // Act
        builder1
            .Use((package, next) =>
            {
                Add(package, 1);
                next(package);
                Add(package, 2);
            })
            .Use((package, next) =>
            {
                Add(package, 3);
                next(package);
                Add(package, 4);
            });

        var builder2 = builder1.New()
            .Use((package, next) =>
            {
                Add(package, 5);
                next(package);
                Add(package, 6);
            });

        var builder3 = builder1.New()
            .Use((package, next) =>
            {
                Add(package, 7);
                next(package);
                Add(package, 8);
            });

        // Arrange
        Assert.Equal(GetList(builder1.Open()), new[] { 1, 3, 4, 2 });
        Assert.Equal(GetList(builder2.Open()), new[] { 1, 3, 5, 6, 4, 2 });
        Assert.Equal(GetList(builder3.Open()), new[] { 1, 3, 7, 8, 4, 2 });
    }

    private static IEnumerable<int> GetList(OpenXmlPackage package)
        => package.Features.Get<List<int>>() ?? Enumerable.Empty<int>();

    private static void Add(OpenXmlPackage package, int value)
    {
        if (package.Features.Get<List<int>>() is { } existing)
        {
            existing.Add(value);
        }
        else
        {
            package.Features.Set(new List<int> { value });
        }
    }

    private sealed class Builder : OpenXmlPackageBuilder<TestPackage>
    {
        public Builder(Builder other = null)
            : base(other)
        {
        }

        internal override OpenXmlPackageBuilder<TestPackage> New() => new Builder(this);

        internal override TestPackage Create() => new();
    }

    private sealed class TestPackage : OpenXmlPackage
    {
    }
}
