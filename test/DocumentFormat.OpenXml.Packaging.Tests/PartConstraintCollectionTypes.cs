// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
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
            Assert.Throws<InvalidOperationException>(() => PartConstraintCollection.Instance.Add(ConstraintTest1.Rule));
        }

        [Fact]
        public void IsCaseSensitive()
        {
            var collection = new PartConstraintCollection();

            collection.Add(ConstraintTest1.Rule);
            Assert.Throws<ArgumentException>(() => collection.Add(ConstraintTest1.Rule));
            collection.Add(ConstraintTest2.Rule);
            Assert.Throws<ArgumentException>(() => collection.Add(ConstraintTest2.Rule));
        }

#pragma warning disable xUnit2013 // Do not use equality check to check for collection size.
        [Fact]
        public void CountTests()
        {
            var collection = new PartConstraintCollection();
            Assert.Equal(0, collection.Count);

            collection.Add(ConstraintTest1.Rule);
            Assert.Equal(1, collection.Count);

            Assert.Throws<ArgumentException>(() => collection.Add(ConstraintTest1.Rule));
            Assert.Equal(1, collection.Count);

            collection.Add(ConstraintTest2.Rule);
            Assert.Equal(2, collection.Count);

            Assert.Throws<ArgumentException>(() => collection.Add(ConstraintTest2.Rule));
            Assert.Equal(2, collection.Count);
        }
#pragma warning restore xUnit2013 // Do not use equality check to check for collection size.

        [Fact]
        public void TryGet()
        {
            var collection = new PartConstraintCollection();

            collection.Add(ConstraintTest1.Rule);

            Assert.True(collection.TryGetValue(ConstraintTest1.Relationship, out var rule));
            Assert.Equal(ConstraintTest1.Rule, rule);
            Assert.False(collection.TryGetValue("b", out _));
        }

        [Fact]
        public void ContainsRelationshipTest()
        {
            var collection = new PartConstraintCollection();

            collection.Add(ConstraintTest1.Rule);

            Assert.True(collection.ContainsRelationship(ConstraintTest1.Relationship));
            Assert.False(collection.ContainsRelationship("b"));
        }

        [RelationshipType(Relationship)]
        private class ConstraintTest1
        {
            public const string Relationship = "relationship";

            public static PartConstraintRule Rule { get; } = new PartConstraintRule(ElementTypeInfo.Create(typeof(ConstraintTest1)), false, false);
        }

        [RelationshipType(Relationship)]
        private class ConstraintTest2
        {
            public const string Relationship = "relationship2";

            public static PartConstraintRule Rule { get; } = new PartConstraintRule(ElementTypeInfo.Create(typeof(ConstraintTest2)), false, false);
        }
    }
}
