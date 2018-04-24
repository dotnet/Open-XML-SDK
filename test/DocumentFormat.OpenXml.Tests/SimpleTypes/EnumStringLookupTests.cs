// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using Xunit;

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public class EnumStringLookupTests
    {
        private enum EmptyEnum { }

        [Fact]
        public void EmptyEnumTest() => ArgumentOutOfRangeTest(default(EmptyEnum));

        private enum SingleItemWithName
        {
            [EnumString("name")]
            Item,
        }

        [Fact]
        public void SingleItemWithNameTest()
        {
            const string name = "name";

            Assert.True(EnumStringLookup<SingleItemWithName>.TryParse(name, out var item));
            Assert.Equal(SingleItemWithName.Item, item);

            Assert.Equal(name, EnumStringLookup<SingleItemWithName>.ToString(SingleItemWithName.Item));
            Assert.Equal(FileFormatVersions.Office2007.AndLater(), EnumStringLookup<SingleItemWithName>.GetVersion(SingleItemWithName.Item));
        }

        [Fact]
        public void TryParseNullNameSetsValueDefault()
        {
            Assert.False(EnumStringLookup<SingleItemWithName>.TryParse(null, out var value));
            Assert.Equal(default, value);
        }

        private enum SingleItemWithoutName
        {
            Item,
        }

        [Fact]
        public void SingleItemWithoutNameTest() => ArgumentOutOfRangeTest(SingleItemWithoutName.Item);

        public enum MultipleItemsWithNamesAndVersion
        {
            [EnumString("name1")]
            Item1 = 0,
            [EnumString("name2")]
            Item2 = 1,
            [EnumString("name3")]
            [OfficeAvailability(FileFormatVersions.Office2010)]
            Item3 = 3,
            [EnumString("name4")]
            Item4 = 2,
            [EnumString("NAME4")]
            Item5 = 4,
        }

        public static IEnumerable<object[]> GetMultipleItemsWithNamesAndVersionsTestData()
        {
            yield return new object[] { MultipleItemsWithNamesAndVersion.Item1, "name1", FileFormatVersions.Office2007.AndLater() };
            yield return new object[] { MultipleItemsWithNamesAndVersion.Item2, "name2", FileFormatVersions.Office2007.AndLater() };
            yield return new object[] { MultipleItemsWithNamesAndVersion.Item3, "name3", FileFormatVersions.Office2010 };
            yield return new object[] { MultipleItemsWithNamesAndVersion.Item4, "name4", FileFormatVersions.Office2007.AndLater() };
            yield return new object[] { MultipleItemsWithNamesAndVersion.Item5, "NAME4", FileFormatVersions.Office2007.AndLater() };
        }

        [MemberData(nameof(GetMultipleItemsWithNamesAndVersionsTestData))]
        [Theory]
        public void MultipleItemsWithNamesAndVersionsTests(MultipleItemsWithNamesAndVersion value, string name, FileFormatVersions version)
        {
            Assert.True(EnumStringLookup<MultipleItemsWithNamesAndVersion>.TryParse(name, out var result));
            Assert.Equal(value, result);
            Assert.Equal(name, EnumStringLookup<MultipleItemsWithNamesAndVersion>.ToString(value));
            Assert.Equal(version, EnumStringLookup<MultipleItemsWithNamesAndVersion>.GetVersion(value));
        }

        private enum ValueHigherThanItems
        {
            [EnumString("a")]
            Item1 = 0,
            [EnumString("b")]
            Item2 = 2,
        }

        [Fact]
        public void ValueHigherThanItemsTest() => ArgumentOutOfRangeTest(ValueHigherThanItems.Item1);

        private enum ValueLessThan0
        {
            [EnumString("a")]
            Item = -1,
        }

        [Fact]
        public void ValueLessThan0Test() => ArgumentOutOfRangeTest(ValueLessThan0.Item);

        private enum NonInt32 : byte
        {
            Item,
        }

        [Fact]
        public void NonInt32Test() => ArgumentOutOfRangeTest(NonInt32.Item);

        [Fact]
        public void NonEnumTest() => ArgumentOutOfRangeTest(1);

        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [Theory]
        public void IsDefinedTests(int entry)
        {
            var enumEntry = (SingleItemWithName)entry;

            Assert.Equal(Enum.IsDefined(typeof(SingleItemWithName), enumEntry), EnumStringLookup<SingleItemWithName>.IsDefined(enumEntry));
        }

        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [Theory]
        public void OutOfRange(int entry)
        {
            var enumEntry = (SingleItemWithName)entry;

            if (Enum.IsDefined(typeof(SingleItemWithName), enumEntry))
            {
                Assert.NotNull(EnumStringLookup<SingleItemWithName>.ToString(enumEntry));
            }
            else
            {
                Assert.Throws<ArgumentOutOfRangeException>("value", () => EnumStringLookup<SingleItemWithName>.ToString(enumEntry));
            }
        }

        private void ArgumentOutOfRangeTest<TEnum>(TEnum item)
            where TEnum : struct
        {
            Assert.Throws<ArgumentOutOfRangeException>(nameof(TEnum), () => EnumStringLookup<TEnum>.ToString(item));
            Assert.Throws<ArgumentOutOfRangeException>(nameof(TEnum), () => EnumStringLookup<TEnum>.TryParse("a", out _));
            Assert.Throws<ArgumentOutOfRangeException>(nameof(TEnum), () => EnumStringLookup<TEnum>.GetVersion(item));
        }
    }
}
