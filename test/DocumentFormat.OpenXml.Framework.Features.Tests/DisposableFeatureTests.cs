// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using NSubstitute;
using NSubstitute.Extensions;
using System;
using Xunit;

namespace DocumentFormat.OpenXml.Features.Tests
{
    public class DisposableFeatureTests
    {
        [Fact]
        public void ThrowsIfNotSet()
        {
            var features = Substitute.For<IFeatureCollection>();
            features.Get<IDisposableFeature>().Returns(default(IDisposableFeature));

            Assert.Throws<NotSupportedException>(() => features.SetDisposable(Substitute.For<IDisposable>()));
        }

        [Fact]
        public void PackageLevelDisposables()
        {
            // Arrange
            var features = new TestFeatureCollection();
            features.AddMock<IPackageEventsFeature>();
            features.AddMock<IPartEventsFeature>();

            var feature = Substitute.For<IDisposable>();

            features.AddDisposableFeature();
            features.SetDisposable(feature);

            var package = Substitute.ForPartsOf<OpenXmlPackage>();
            package.Configure().Features.Returns(features);

            // Act
            features.GetRequired<IPackageEventsFeature>().Change += Raise.Event<Action<FeatureEventArgs<OpenXmlPackage>>>(new FeatureEventArgs<OpenXmlPackage>(EventType.Closed, package));

            // Assert
            feature.Received(1).Dispose();
        }

        [Fact]
        public void PartLevelDisposables()
        {
            // Arrange
            var features = new TestFeatureCollection();
            features.AddMock<IPackageEventsFeature>();
            features.AddMock<IPartEventsFeature>();

            var feature = Substitute.For<IDisposable>();

            features.AddDisposableFeature();
            features.SetDisposable(feature);

            var part = Substitute.ForPartsOf<OpenXmlPart>();
            part.Configure().Features.Returns(features);

            // Act
            features.GetRequired<IPartEventsFeature>().Change += Raise.Event<Action<FeatureEventArgs<OpenXmlPart>>>(new FeatureEventArgs<OpenXmlPart>(EventType.Removed, part));

            // Assert
            feature.Received(1).Dispose();
        }

        [Fact]
        public void PartAdded()
        {
            // Arrange
            var features = new TestFeatureCollection();
            features.AddMock<IPackageEventsFeature>();
            features.AddMock<IPartEventsFeature>();

            var feature = Substitute.For<IDisposable>();

            features.AddDisposableFeature();
            features.SetDisposable(feature);

            var part = Substitute.ForPartsOf<OpenXmlPart>();
            part.Configure().Features.Returns(new TestFeatureCollection());

            // Act
            features.GetRequired<IPartEventsFeature>().Change += Raise.Event<Action<FeatureEventArgs<OpenXmlPart>>>(new FeatureEventArgs<OpenXmlPart>(EventType.Created, part));

            // Assert
            Assert.NotNull(part.Features.Get<IDisposableFeature>());
        }
    }
}
