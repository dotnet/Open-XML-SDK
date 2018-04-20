using System;
using Xunit;

namespace DocumentFormat.OpenXml.Tests.SimpleTypes
{
    public abstract class OpenXmlComparableValueTypeTests<T> where T : struct, IComparable, IComparable<T>, IEquatable<T>, IConvertible
    {
        protected OpenXmlComparableValueType<T> SmallValue1 { get; set; }

        protected OpenXmlComparableValueType<T> SmallValue2 { get; set; }

        protected OpenXmlComparableValueType<T> LargeValue { get; set; }

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
