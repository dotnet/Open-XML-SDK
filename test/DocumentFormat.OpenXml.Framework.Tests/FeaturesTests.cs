// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using NSubstitute;
using System;
using Xunit;

namespace DocumentFormat.OpenXml.Framework.Tests
{
    public class FeaturesTests
    {
        [Fact]
        public void SetAndGet()
        {
            var features = new FeatureCollection();

            Assert.Null(features.Get<Feature>());

            var feature1 = new Feature();

            features.Set(feature1);

            Assert.Same(feature1, features.Get<Feature>());

            features.Set(default(Feature));

            Assert.Null(features.Get<Feature>());
        }

        [Fact]
        public void ParentAvailableIfNotSet()
        {
            var features1 = new FeatureCollection();
            var feature1 = new Feature();

            features1.Set(feature1);

            var features2 = new FeatureCollection(features1);

            Assert.Same(feature1, features2.Get<Feature>());
        }

        [Fact]
        public void NestedDoesntAffectParent()
        {
            var features1 = new FeatureCollection();
            var features2 = new FeatureCollection(features1);
            var feature1 = new Feature();
            var feature2 = new Feature();

            features1.Set(feature1);
            features2.Set(feature2);

            Assert.Same(feature1, features1.Get<Feature>());
            Assert.Same(feature2, features2.Get<Feature>());
        }

        [Fact]
        public void ReadOnlyIsCached()
        {
            var features1 = new FeatureCollection();
            var features2 = features1.AsReadOnly();
            var features3 = features1.AsReadOnly();

            Assert.False(features1.IsReadOnly);
            Assert.NotSame(features1, features2);
            Assert.Same(features2, features3);
            Assert.True(features2.IsReadOnly);
        }

        [Fact]
        public void ReadOnlyConversion()
        {
            var features1 = new FeatureCollection();
            var feature1 = new Feature();
            features1.Set(feature1);

            var features2 = features1.AsReadOnly();
            Assert.Throws<NotSupportedException>(() => features2.Set(feature1));

            Assert.Same(feature1, features2.Get<Feature>());
        }

        [Fact]
        public void DefaultIsReadOnly()
        {
            Assert.True(FeatureCollection.Default.IsReadOnly);
        }

        private class Feature
        {
        }
    }
}
