// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using Xunit;

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public abstract class OpenXmlComparableSimpleValueTests<T> where T : struct, IComparable, IComparable<T>, IEquatable<T>, IConvertible
    {
        protected OpenXmlComparableSimpleValue<T> SmallValue1 { get; set; }

        protected OpenXmlComparableSimpleValue<T> SmallValue2 { get; set; }

        protected OpenXmlComparableSimpleValue<T> LargeValue { get; set; }

        [Fact]
        public void TestValuesAreConsistent()
        {
            Assert.NotNull(SmallValue1?.Value);
            Assert.NotNull(SmallValue2?.Value);
            Assert.Equal(SmallValue1.Value, SmallValue2.Value);

            Assert.NotNull(LargeValue?.Value);

            Assert.True(SmallValue1.Value.CompareTo(LargeValue.Value) < 0);
        }

        [Fact]
        public void CompareTo_InstanceFollowsArgumentInSortOrder_PositiveValueReturned()
        {
            Assert.True(LargeValue.CompareTo(SmallValue1) > 0);
            Assert.True(LargeValue.CompareTo((object) SmallValue1) > 0);
        }

        [Fact]
        public void CompareTo_SameSortOrder_ZeroReturned()
        {
            Assert.Equal(0, LargeValue.CompareTo(LargeValue));
            Assert.Equal(0, LargeValue.CompareTo((object) LargeValue));
        }

        [Fact]
        public void CompareTo_InstancePrecedesArgumentInSortOrder_NegativeValueReturned()
        {
            Assert.True(SmallValue1.CompareTo(LargeValue) < 0);
            Assert.True(SmallValue1.CompareTo((object) LargeValue) < 0);
        }

        [Fact]
        public void CompareTo_ArgumentIsNull_PositiveValueReturned()
        {
            Assert.True(SmallValue1.CompareTo(null) > 0);
            Assert.True(SmallValue1.CompareTo((object) null) > 0);
        }

        [Fact]
        public void CompareTo_ArgumentIncompatible_ExceptionThrown()
        {
            Assert.Throws<ArgumentException>(() => SmallValue1.CompareTo("Some string"));
            Assert.Throws<ArgumentException>(() => SmallValue1.CompareTo(1));
        }

        [Fact]
        public void Equals_DifferentValues_EqualsIsFalse()
        {
            Assert.False(SmallValue1.Equals(LargeValue));
        }

        [Fact]
        public void Equals_EqualValues_EqualsIsTrue()
        {
            Assert.True(SmallValue1.Equals(SmallValue1));
            Assert.True(SmallValue1.Equals(SmallValue2));
        }

        [Fact]
        public void Equals_NullValue_EqualsIsFalse()
        {
            Assert.False(SmallValue1.Equals(null));
            Assert.False(LargeValue.Equals(null));
        }

        [Fact]
        public void GetHashCode_DifferentValues_HashCodesAreNotEqual()
        {
            Assert.NotEqual(SmallValue1.GetHashCode(), LargeValue.GetHashCode());
        }

        [Fact]
        public void GetHashCode_EqualValues_HashCodesAreEqual()
        {
            Assert.Equal(SmallValue1.GetHashCode(), SmallValue2.GetHashCode());
        }

        [Fact]
        public void Operators_ValidValues_CorrectComparisons()
        {
            Assert.True(SmallValue1 == SmallValue2);

            Assert.True(SmallValue1 != LargeValue);

            Assert.True(SmallValue1 <= SmallValue2);
            Assert.True(SmallValue1 <= LargeValue);

            Assert.True(SmallValue1 < LargeValue);

            Assert.True(SmallValue2 >= SmallValue1);
            Assert.True(LargeValue >= SmallValue1);

            Assert.True(LargeValue > SmallValue1);
        }
    }
}
