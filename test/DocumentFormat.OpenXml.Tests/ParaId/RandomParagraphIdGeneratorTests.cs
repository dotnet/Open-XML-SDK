// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Linq;
using Xunit;

namespace DocumentFormat.OpenXml.Wordprocessing
{
    public class RandomParagraphIdGeneratorTests
    {
        public RandomParagraphIdGeneratorTests()
        {
            Generator = new RandomParagraphIdGenerator();
        }

        private IParagraphIdGenerator Generator { get; }

        [Fact]
        public void Constructor_ParagraphIdCollection()
        {
            var paraId = Generator.CreateUniqueParagraphId();

            var newService = new RandomParagraphIdGenerator(Generator.RegisteredParagraphIds);

            Assert.Contains(paraId, newService.RegisteredParagraphIds);
        }

        [Fact]
        public void CreateUniqueParagraphId_AllGeneratedValuesAreValidAndUnique()
        {
            const int count = 10000;

            for (var i = 0; i < count; i++)
            {
                string paraId = Generator.CreateUniqueParagraphId();
                var hexBinaryValue = new HexBinaryValue(paraId);
                var value = Convert.ToUInt32(paraId, 16);

                // Assert that the HexBinaryValue is deemed valid. Note, however, that
                // the rules for w14:paraId (ParagraphId) values are stricter and the
                // convention seems to be all uppercase letters.
                Assert.True(hexBinaryValue.IsValid);

                // Assert that the value is both greater than 0x00000000 and less than
                // 0x80000000 as specified in MS-DOCX, section 2.6.2.3.
                Assert.True(value > 0x00000000);
                Assert.True(value < 0x80000000);

                // Assert that the value is all uppercase, as produced by Microsoft Word.
                Assert.Equal(paraId.ToUpperInvariant(), paraId);
            }

            Assert.Equal(count, Generator.RegisteredParagraphIds.Count());
        }

        [Fact]
        public void RegisterParagraphId_ExistingHexBinaryValue_IsNotAdded()
        {
            const string paraId = "12345678";
            Generator.RegisterParagraphId(new HexBinaryValue(paraId));

            var isAdded = Generator.RegisterParagraphId(new HexBinaryValue(paraId));

            Assert.False(isAdded);
            Assert.Single(Generator.RegisteredParagraphIds);
        }

        [Fact]
        public void RegisterParagraphId_ExistingHexString_IsNotAdded()
        {
            const string paraId = "12345678";
            Generator.RegisterParagraphId(paraId);

            var isAdded = Generator.RegisterParagraphId(paraId);

            Assert.False(isAdded);
        }

        [Fact]
        public void RegisterParagraphId_HexBinaryValueWithNullInnerText_IsNotAdded()
        {
            Assert.False(Generator.RegisterParagraphId(new HexBinaryValue()));
        }

        [Fact]
        public void RegisterParagraphId_NonExistentHexBinaryValue_IsAdded()
        {
            var isAdded = Generator.RegisterParagraphId(new HexBinaryValue("12345678"));

            Assert.True(isAdded);
            Assert.Single(Generator.RegisteredParagraphIds);
        }

        [Fact]
        public void RegisterParagraphId_NonExistentHexString_IsAdded()
        {
            var isAdded = Generator.RegisterParagraphId("12345678");

            Assert.True(isAdded);
            Assert.Single(Generator.RegisteredParagraphIds);
        }
    }
}
