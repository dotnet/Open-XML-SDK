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
        IComparable, IComparable<OpenXmlComparableSimpleValue<T>>, IEquatable<OpenXmlComparableSimpleValue<T>>
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
            switch (obj)
            {
                case null:
                    return 1;

                case OpenXmlComparableSimpleValue<T> other:
                    return Value.CompareTo(other.Value);
            }

            throw new ArgumentException(SR.Format(ExceptionMessages.IncompatibleArgumentType, obj.GetType().FullName));
        }

        /// <inheritdoc />
        public int CompareTo(OpenXmlComparableSimpleValue<T> other)
        {
            return other is null ? 1 : Value.CompareTo(other.Value);
        }

        /// <inheritdoc />
        public bool Equals(OpenXmlComparableSimpleValue<T> other)
        {
            return !(other is null) && Value.Equals(other.Value);
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            switch (obj)
            {
                case null:
                    return false;

                case OpenXmlComparableSimpleValue<T> openXmlComparableValueType:
                    return Equals(openXmlComparableValueType);

                case T value:
                    return Value.Equals(value);

                default:
                    return false;
            }
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

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
