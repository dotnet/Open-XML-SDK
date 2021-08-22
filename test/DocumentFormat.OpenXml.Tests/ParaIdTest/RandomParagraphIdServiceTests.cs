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

#if NET452
        /*
         * NOTES:
         * When the product targets net35 or net40, the unit test projects target net452.
         * As net35 and net40 do not support the IReadOnlyCollection<T> interface, the
         * ParagraphIds and DuplicateParagraphIds properties are of type ICollection<T>.
         * However, the collections are read-only, which is established by the following
         * platform-specific unit tests.
         */

        [Fact]
        public void ParagraphIds_IsReadOnly()
        {
            Assert.True(Service.ParagraphIds.IsReadOnly);
            Assert.Throws<NotSupportedException>(() => Service.ParagraphIds.Add("12345678"));
            Assert.Throws<NotSupportedException>(() => Service.ParagraphIds.Clear());
            Assert.Throws<NotSupportedException>(() => Service.ParagraphIds.Remove("12345678"));
        }

        [Fact]
        public void DuplicateParagraphIds_IsReadOnly()
        {
            Assert.True(Service.ParagraphIds.IsReadOnly);
            Assert.Throws<NotSupportedException>(() => Service.DuplicateParagraphIds.Add("12345678"));
            Assert.Throws<NotSupportedException>(() => Service.DuplicateParagraphIds.Clear());
            Assert.Throws<NotSupportedException>(() => Service.DuplicateParagraphIds.Remove("12345678"));
        }
#endif
    }
}
