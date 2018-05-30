// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents a comparable and equatable reference.
    /// </summary>
    /// <typeparam name="T">The type of the value.</typeparam>
    public abstract class OpenXmlComparableSimpleReference<T> : OpenXmlSimpleType,
        IComparable, IComparable<OpenXmlComparableSimpleReference<T>>, IEquatable<OpenXmlComparableSimpleReference<T>>
        where T : class, IComparable, IComparable<T>, IEquatable<T>
    {
        /// <summary>
        /// Creates a new instance of <see cref="OpenXmlComparableSimpleReference{T}"/>.
        /// </summary>
        private protected OpenXmlComparableSimpleReference()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenXmlComparableSimpleReference{T}"/>
        /// class by deep copying the supplied <see cref="OpenXmlComparableSimpleReference{T}"/>
        /// value.
        /// </summary>
        /// <param name="source">The source <see cref="OpenXmlComparableSimpleReference{T}"/> instance.</param>
        private protected OpenXmlComparableSimpleReference(OpenXmlComparableSimpleReference<T> source) : base(source)
        {
        }

        /// <summary>
        /// Gets or sets the value of this instance.
        /// </summary>
        public abstract T Value { get; set; }

        /// <inheritdoc />
        public int CompareTo(object obj)
        {
            switch (obj)
            {
                case null:
                    return 1;

                case OpenXmlComparableSimpleReference<T> other:
                    return CompareTo(other);
            }

            throw new ArgumentException(SR.Format(ExceptionMessages.IncompatibleArgumentType, obj.GetType().FullName));
        }

        /// <inheritdoc />
        public int CompareTo(OpenXmlComparableSimpleReference<T> other)
        {
            if (other is null)
            {
                return 1;
            }

            if (Value == null)
            {
                return other.Value == null ? 0 : -1;
            }

            return Value.CompareTo(other.Value);
        }

        /// <inheritdoc />
        public bool Equals(OpenXmlComparableSimpleReference<T> other)
        {
            return !(other is null) && Equals(Value, other.Value);
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            switch (obj)
            {
                case null:
                    return false;

                case OpenXmlComparableSimpleReference<T> other:
                    return Equals(other);

                case T otherValue:
                    return otherValue.Equals(Value);

                default:
                    return false;
            }
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return Value?.GetHashCode() ?? 0;
        }

        /// <summary>
        /// Determines whether the specified operands are equal.
        /// </summary>
        /// <param name="left">The left operand, or null.</param>
        /// <param name="right">The right operand, or null.</param>
        /// <returns>True if the operands are equal; otherwise, false.</returns>
        public static bool operator ==(OpenXmlComparableSimpleReference<T> left, OpenXmlComparableSimpleReference<T> right)
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
        public static bool operator !=(OpenXmlComparableSimpleReference<T> left, OpenXmlComparableSimpleReference<T> right)
        {
            return !(left == right);
        }

        /// <summary>
        /// Determines whether the left operand is less than the right operand.
        /// </summary>
        /// <param name="left">The left operand, or null.</param>
        /// <param name="right">The right operand, or null.</param>
        /// <returns>True if the left operand is less than the right operand; otherwise, false.</returns>
        public static bool operator <(OpenXmlComparableSimpleReference<T> left, OpenXmlComparableSimpleReference<T> right)
        {
            return left is null ? !(right is null) : left.CompareTo(right) < 0;
        }

        /// <summary>
        /// Determines whether the left operand is less than or equal to the right operand.
        /// </summary>
        /// <param name="left">The left operand, or null.</param>
        /// <param name="right">The right operand, or null.</param>
        /// <returns>True if the left operand is less than or equal to the right operand; otherwise, false.</returns>
        public static bool operator <=(OpenXmlComparableSimpleReference<T> left, OpenXmlComparableSimpleReference<T> right)
        {
            return left is null || left.CompareTo(right) <= 0;
        }

        /// <summary>
        /// Determines whether the left operand is greater than the right operand.
        /// </summary>
        /// <param name="left">The left operand, or null.</param>
        /// <param name="right">The right operand, or null.</param>
        /// <returns>True if the left operand is greater than the right operand; otherwise, false.</returns>
        public static bool operator >(OpenXmlComparableSimpleReference<T> left, OpenXmlComparableSimpleReference<T> right)
        {
            return !(left is null) && left.CompareTo(right) > 0;
        }

        /// <summary>
        /// Determines whether the left operand is greater than or equal to the right operand.
        /// </summary>
        /// <param name="left">The left operand, or null.</param>
        /// <param name="right">The right operand, or null.</param>
        /// <returns>True if the left operand is greater than or equal to the right operand; otherwise, false.</returns>
        public static bool operator >=(OpenXmlComparableSimpleReference<T> left, OpenXmlComparableSimpleReference<T> right)
        {
            return left is null ? right is null : left.CompareTo(right) >= 0;
        }
    }
}
