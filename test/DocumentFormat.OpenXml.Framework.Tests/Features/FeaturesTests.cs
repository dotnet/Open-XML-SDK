// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using Xunit;

namespace DocumentFormat.OpenXml.Features.Tests
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
        public void DefaultIsReadOnly()
        {
            Assert.True(FeatureCollection.Default.IsReadOnly);
        }

        private class Feature
        {
        }
    }
}
