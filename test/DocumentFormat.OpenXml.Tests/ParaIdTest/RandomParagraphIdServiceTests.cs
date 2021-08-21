// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Linq;
using Xunit;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    public class RandomParagraphIdServiceTests
    {
        public RandomParagraphIdServiceTests()
        {
            Service = new RandomParagraphIdService();
        }

        private IParagraphIdService Service { get; }

        [Fact]
        public void Constructor_ParagraphIdCollection()
        {
            string paraId = Service.CreateUniqueParagraphId();

            var newService = new RandomParagraphIdService(Service.ParagraphIds);

            Assert.Contains(paraId, newService.ParagraphIds);
        }

        [Fact]
        public void CreateUniqueParagraphId_AllGeneratedValuesAreValidAndUnique()
        {
            const int count = 10000;

            for (var i = 0; i < count; i++)
            {
                string paraId = Service.CreateUniqueParagraphId();

                Assert.Equal(paraId.ToUpperInvariant(), paraId);
                Assert.True(string.CompareOrdinal(paraId, "00000000") > 0);
                Assert.True(string.CompareOrdinal(paraId, "80000000") < 0);
            }

            Assert.Equal(count, Service.ParagraphIds.Count);
            Assert.Empty(Service.DuplicateParagraphIds);
        }

        [Fact]
        public void RegisterParagraphId_ExistingHexBinaryValue_IsNotAdded()
        {
            const string paraId = "12345678";
            Service.RegisterParagraphId(new HexBinaryValue(paraId));

            bool isAdded = Service.RegisterParagraphId(new HexBinaryValue(paraId));

            Assert.False(isAdded);
            Assert.Single(Service.ParagraphIds);
            Assert.Equal(paraId, Service.DuplicateParagraphIds.Single());
        }

        [Fact]
        public void RegisterParagraphId_ExistingHexString_IsNotAdded()
        {
            const string paraId = "12345678";
            Service.RegisterParagraphId(paraId);

            bool isAdded = Service.RegisterParagraphId(paraId);

            Assert.False(isAdded);
            Assert.Equal(paraId, Service.DuplicateParagraphIds.Single());
        }

        [Fact]
        public void RegisterParagraphId_HexBinaryValueWithNullInnerText_IsNotAdded()
        {
            Assert.False(Service.RegisterParagraphId(new HexBinaryValue()));
        }

        [Fact]
        public void RegisterParagraphId_NonExistentHexBinaryValue_IsAdded()
        {
            bool isAdded = Service.RegisterParagraphId(new HexBinaryValue("12345678"));

            Assert.True(isAdded);
            Assert.Single(Service.ParagraphIds);
            Assert.Empty(Service.DuplicateParagraphIds);
        }

        [Fact]
        public void RegisterParagraphId_NonExistentHexString_IsAdded()
        {
            bool isAdded = Service.RegisterParagraphId("12345678");

            Assert.True(isAdded);
            Assert.Single(Service.ParagraphIds);
            Assert.Empty(Service.DuplicateParagraphIds);
        }
    }
}
