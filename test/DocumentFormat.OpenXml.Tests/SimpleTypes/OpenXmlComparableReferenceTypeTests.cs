// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using Xunit;

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public abstract class OpenXmlComparableReferenceTypeTests<T> where T : class, IComparable, IComparable<T>, IEquatable<T>
    {
        protected OpenXmlComparableReferenceType<T> SmallValue1 { get; set; }

        protected OpenXmlComparableReferenceType<T> SmallValue2 { get; set; }

        protected OpenXmlComparableReferenceType<T> NullValue1 { get; set; }

        protected OpenXmlComparableReferenceType<T> NullValue2 { get; set; }

        protected OpenXmlComparableReferenceType<T> LargeValue { get; set; }

        [Fact]
        public void TestValuesAreConsistent()
        {
            Assert.NotNull(SmallValue1?.Value);
            Assert.NotNull(SmallValue2?.Value);
            Assert.Equal(SmallValue1.Value, SmallValue2.Value);

            Assert.NotNull(NullValue1);
            Assert.NotNull(NullValue2);

            Assert.Null(NullValue1.Value);
            Assert.Null(NullValue2.Value);

            Assert.NotNull(LargeValue?.Value);

            Assert.True(SmallValue1.Value.CompareTo(LargeValue.Value) < 0);
        }

        [Fact]
        public void Equals_DifferentValues_EqualsIsFalse()
        {
            Assert.False(SmallValue1.Equals(LargeValue));
            Assert.False(SmallValue1.Equals(NullValue1));
            Assert.False(NullValue1.Equals(SmallValue1));
        }

        [Fact]
        public void Equals_EqualValues_EqualsIsTrue()
        {
            Assert.True(SmallValue1.Equals(SmallValue1));
            Assert.True(SmallValue1.Equals(SmallValue2));
            Assert.True(NullValue1.Equals(NullValue2));
        }

        [Fact]
        public void Equals_NullValue_EqualsIsFalse()
        {
            Assert.False(SmallValue1.Equals(null));
            Assert.False(NullValue1.Equals(null));
        }

        [Fact]
        public void GetHashCode_DifferentValues_HashCodesAreNotEqual()
        {
            Assert.NotEqual(SmallValue1.GetHashCode(), LargeValue.GetHashCode());
            Assert.NotEqual(SmallValue1.GetHashCode(), NullValue1.GetHashCode());
        }

        [Fact]
        public void GetHashCode_EqualValues_HashCodesAreEqual()
        {
            Assert.Equal(SmallValue1.GetHashCode(), SmallValue2.GetHashCode());
            Assert.Equal(NullValue1.GetHashCode(), NullValue2.GetHashCode());
        }

        [Fact]
        public void Operators_ValidValues_CorrectComparisons()
        {
            Assert.True(SmallValue1 == SmallValue2);
            Assert.True(NullValue1 == NullValue2);

            Assert.True(SmallValue1 != LargeValue);
            Assert.True(SmallValue1 != NullValue1);

            Assert.True(SmallValue1 <= SmallValue2);
            Assert.True(SmallValue1 <= LargeValue);

            Assert.True(SmallValue1 < LargeValue);

            Assert.True(SmallValue2 >= SmallValue1);
            Assert.True(LargeValue >= SmallValue1);

            Assert.True(LargeValue > SmallValue1);
        }
    }
}
