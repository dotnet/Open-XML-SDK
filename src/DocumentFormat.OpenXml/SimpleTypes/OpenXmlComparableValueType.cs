// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents a comparable and equatable value for simple value types (Int32, UInt32, Byte, struct, etc).
    /// </summary>
    /// <typeparam name="T">The type of the value.</typeparam>
    public abstract class OpenXmlComparableValueType<T> : OpenXmlSimpleValue<T>,
        IComparable, IComparable<OpenXmlComparableValueType<T>>, IEquatable<OpenXmlComparableValueType<T>>
        where T : struct, IComparable, IComparable<T>, IEquatable<T>
    {
        /// <summary>
        /// Creates a new instance of <see cref="OpenXmlComparableValueType{T}"/>.
        /// </summary>
        private protected OpenXmlComparableValueType()
        {
        }

        /// <summary>
        /// Creates a new instance of <see cref="OpenXmlComparableValueType{T}"/>.
        /// </summary>
        /// <param name="value">The value in type T.</param>
        private protected OpenXmlComparableValueType(T value) : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenXmlComparableValueType{T}"/>
        /// class by deep copying the supplied <see cref="OpenXmlComparableValueType{T}"/>
        /// value.
        /// </summary>
        /// <param name="source">The source <see cref="OpenXmlComparableValueType{T}"/> instance.</param>
        private protected OpenXmlComparableValueType(OpenXmlComparableValueType<T> source) : base(source)
        {
        }

        /// <inheritdoc />
        public int CompareTo(object obj)
        {
            if (obj is OpenXmlComparableValueType<T> other)
            {
                return Value.CompareTo(other.Value);
            }

            throw new ArgumentException();
        }

        /// <inheritdoc />
        public int CompareTo(OpenXmlComparableValueType<T> other)
        {
            return other is null ? 1 : Value.CompareTo(other.Value);
        }

        /// <inheritdoc />
        public bool Equals(OpenXmlComparableValueType<T> other)
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

            if (obj is OpenXmlComparableValueType<T> openXmlComparableValueType)
            {
                return Equals(openXmlComparableValueType);
            }

            if (obj is T value)
            {
                return Value.Equals(value);
            }

            return false;
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator ==(OpenXmlComparableValueType<T> left, OpenXmlComparableValueType<T> right)
        {
            if (left is null)
            {
                return right is null;
            }

            return left.Equals(right);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator !=(OpenXmlComparableValueType<T> left, OpenXmlComparableValueType<T> right)
        {
            return !(left == right);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator <(OpenXmlComparableValueType<T> left, OpenXmlComparableValueType<T> right)
        {
            return left is null ? !(right is null) : left.CompareTo(right) < 0;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator <=(OpenXmlComparableValueType<T> left, OpenXmlComparableValueType<T> right)
        {
            return left is null || left.CompareTo(right) <= 0;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator >(OpenXmlComparableValueType<T> left, OpenXmlComparableValueType<T> right)
        {
            return !(left is null) && left.CompareTo(right) > 0;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator >=(OpenXmlComparableValueType<T> left, OpenXmlComparableValueType<T> right)
        {
            return left is null ? right is null : left.CompareTo(right) >= 0;
        }
    }
}
