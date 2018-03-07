// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using Xunit;

#pragma warning disable IDE0028 // Simplify collection initialization

namespace DocumentFormat.OpenXml.Packaging.Tests
{
    public class PartConstraintCollectionTests
    {
        [Fact]
        public void InstanceIsSame()
        {
            Assert.Same(PartConstraintCollection.Instance, PartConstraintCollection.Instance);
        }

        [Fact]
        public void CachedInstanceFailsToAdd()
        {
            Assert.Throws<InvalidOperationException>(() => PartConstraintCollection.Instance.Add(string.Empty, ConstraintTest.Rule));
        }

        [Fact]
        public void IsCaseSensitive()
        {
            var collection = new PartConstraintCollection();

            collection.Add("a", ConstraintTest.Rule);
            Assert.Throws<ArgumentException>(() => collection.Add("a", ConstraintTest.Rule));
            collection.Add("A", ConstraintTest.Rule);
            Assert.Throws<ArgumentException>(() => collection.Add("A", ConstraintTest.Rule));
        }

#pragma warning disable xUnit2013 // Do not use equality check to check for collection size.
        [Fact]
        public void CountTests()
        {
            var collection = new PartConstraintCollection();
            Assert.Equal(0, collection.Count);

            collection.Add("a", ConstraintTest.Rule);
            Assert.Equal(1, collection.Count);

            Assert.Throws<ArgumentException>(() => collection.Add("a", ConstraintTest.Rule));
            Assert.Equal(1, collection.Count);

            collection.Add("A", ConstraintTest.Rule);
            Assert.Equal(2, collection.Count);

            Assert.Throws<ArgumentException>(() => collection.Add("A", ConstraintTest.Rule));
            Assert.Equal(2, collection.Count);
        }
#pragma warning restore xUnit2013 // Do not use equality check to check for collection size.

        [Fact]
        public void TryGet()
        {
            var collection = new PartConstraintCollection();

            collection.Add("a", ConstraintTest.Rule);

            Assert.True(collection.TryGetValue("a", out var rule));
            Assert.Equal(ConstraintTest.Rule, rule);
            Assert.False(collection.TryGetValue("b", out _));
        }

        [Fact]
        public void ContainsRelationshipTest()
        {
            var collection = new PartConstraintCollection();

            collection.Add("a", ConstraintTest.Rule);

            Assert.True(collection.ContainsRelationship("a"));
            Assert.False(collection.ContainsRelationship("b"));
        }

        private class ConstraintTest
        {
            public static PartConstraintRule Rule { get; } = PartConstraintRule.Create<ConstraintTest>(false, false);
        }
    }
}
