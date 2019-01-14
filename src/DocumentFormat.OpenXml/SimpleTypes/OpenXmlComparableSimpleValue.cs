// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents a comparable and equatable value.
    /// </summary>
    /// <typeparam name="T">The type of the value.</typeparam>
    public abstract class OpenXmlComparableSimpleValue<T> : OpenXmlSimpleValue<T>,
        IComparable, IComparable<T>, IEquatable<T>,
        IComparable<OpenXmlComparableSimpleValue<T>>, IEquatable<OpenXmlComparableSimpleValue<T>>
        where T : struct, IComparable, IComparable<T>, IEquatable<T>
    {
        /// <summary>
        /// Creates a new instance of <see cref="OpenXmlComparableSimpleValue{T}"/>.
        /// </summary>
        private protected OpenXmlComparableSimpleValue()
        {
        }

        /// <summary>
        /// Creates a new instance of <see cref="OpenXmlComparableSimpleValue{T}"/>.
        /// </summary>
        /// <param name="value">The value in type T.</param>
        private protected OpenXmlComparableSimpleValue(T value) : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenXmlComparableSimpleValue{T}"/>
        /// class by deep copying the supplied <see cref="OpenXmlComparableSimpleValue{T}"/>
        /// value.
        /// </summary>
        /// <param name="source">The source <see cref="OpenXmlComparableSimpleValue{T}"/> instance.</param>
        private protected OpenXmlComparableSimpleValue(OpenXmlComparableSimpleValue<T> source) : base(source)
        {
        }

        /// <inheritdoc />
        public int CompareTo(object obj)
        {
            if(obj is null || !HasValue)
            {
                return 1;
            }

            switch (obj)
            {
                case OpenXmlComparableSimpleValue<T> other:
                    return CompareTo(other.Value);

                case T t:
                    return CompareTo(t);

                default:
                    return Value.CompareTo(obj);
            }
        }

        /// <inheritdoc />
        public int CompareTo(T other)
        {
            if (!HasValue)
            {
                return 1;
            }

            return Value.CompareTo(other);
        }

        /// <inheritdoc />
        public int CompareTo(OpenXmlComparableSimpleValue<T> other)
        {
            return other is null ? 1 : Value.CompareTo(other.Value);
        }

        /// <inheritdoc />
        public bool Equals(T other)
        {
            if (!HasValue)
            {
                return false;
            }

            return other.Equals(Value);
        }

        /// <inheritdoc />
        public bool Equals(OpenXmlComparableSimpleValue<T> other)
        {
            return !(other is null) && Value.Equals(other.Value);
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (obj is null)
            {
                return false;
            }
            else if (ReferenceEquals(this, obj))
            {
                return true;
            }
            else if (obj is T t)
            {
                return Equals(t);
            }
            else if (obj is OpenXmlComparableSimpleValue<T> simpleValue)
            {
                return Equals(simpleValue);
            }
            else
            {
                return false;
            }
        }

        /// <inheritdoc />
        public override int GetHashCode() => Value.GetHashCode();

        /// <summary>
        /// Determines whether the specified operands are equal.
        /// </summary>
        /// <param name="left">The left operand, or null.</param>
        /// <param name="right">The right operand, or null.</param>
        /// <returns>True if the operands are equal; otherwise, false.</returns>
        public static bool operator ==(OpenXmlComparableSimpleValue<T> left, OpenXmlComparableSimpleValue<T> right)
        {
            if (left is null)
            {
                return right is null;
            }

            return left.Equals(right);
        }

        /// <summary>
        /// Determines whether the specified operands are not equal.
        /// </summary>
        /// <param name="left">The left operand, or null.</param>
        /// <param name="right">The right operand, or null.</param>
        /// <returns>True if the operands are not equal; otherwise, false.</returns>
        public static bool operator !=(OpenXmlComparableSimpleValue<T> left, OpenXmlComparableSimpleValue<T> right)
        {
            return !(left == right);
        }

        /// <summary>
        /// Determines whether the left operand is less than the right operand.
        /// </summary>
        /// <param name="left">The left operand, or null.</param>
        /// <param name="right">The right operand, or null.</param>
        /// <returns>True if the left operand is less than the right operand; otherwise, false.</returns>
        public static bool operator <(OpenXmlComparableSimpleValue<T> left, OpenXmlComparableSimpleValue<T> right)
        {
            return left is null ? !(right is null) : left.CompareTo(right) < 0;
        }

        /// <summary>
        /// Determines whether the left operand is less than or equal to the right operand.
        /// </summary>
        /// <param name="left">The left operand, or null.</param>
        /// <param name="right">The right operand, or null.</param>
        /// <returns>True if the left operand is less than or equal to the right operand; otherwise, false.</returns>
        public static bool operator <=(OpenXmlComparableSimpleValue<T> left, OpenXmlComparableSimpleValue<T> right)
        {
            return left is null || left.CompareTo(right) <= 0;
        }

        /// <summary>
        /// Determines whether the left operand is greater than the right operand.
        /// </summary>
        /// <param name="left">The left operand, or null.</param>
        /// <param name="right">The right operand, or null.</param>
        /// <returns>True if the left operand is greater than the right operand; otherwise, false.</returns>
        public static bool operator >(OpenXmlComparableSimpleValue<T> left, OpenXmlComparableSimpleValue<T> right)
        {
            return !(left is null) && left.CompareTo(right) > 0;
        }

        /// <summary>
        /// Determines whether the left operand is greater than or equal to the right operand.
        /// </summary>
        /// <param name="left">The left operand, or null.</param>
        /// <param name="right">The right operand, or null.</param>
        /// <returns>True if the left operand is greater than or equal to the right operand; otherwise, false.</returns>
        public static bool operator >=(OpenXmlComparableSimpleValue<T> left, OpenXmlComparableSimpleValue<T> right)
        {
            return left is null ? right is null : left.CompareTo(right) >= 0;
        }
    }
}
