// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the <see cref="long"/> value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class Int64Value : OpenXmlComparableSimpleValue<long>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Int64Value"/> class.
        /// </summary>
        public Int64Value()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Int64Value"/> class using the supplied <see cref="long"/> value.
        /// </summary>
        /// <param name="value">The <see cref="long"/> value.</param>
        public Int64Value(long value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Int64Value"/> by deep copying the supplied <see cref="Int64Value"/> class.
        /// </summary>
        /// <param name="source">The source <see cref="Int64Value"/> class.</param>
        public Int64Value(Int64Value source)
            : base(source)
        {
        }

        private protected override string GetText(long input) => XmlConvert.ToString(input);

        private protected override long Parse(string input) => XmlConvert.ToInt64(input);

        /// <summary>
        /// Implicitly converts the specified <see cref="Int64Value"/> to an <see cref="long"/> value.
        /// </summary>
        /// <param name="value">The <see cref="Int64Value"/> to convert.</param>
        /// <returns>The converted <see cref="long"/> value.</returns>
        /// <exception cref="InvalidOperationException">Thrown when <paramref name="value"/> is <c>null</c>.</exception>
        public static implicit operator long(Int64Value value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return ToInt64(value);
        }

        /// <summary>
        /// Implicitly converts an <see cref="long"/> value to an <see cref="Int64Value"/> value.
        /// </summary>
        /// <param name="value">The specified value.</param>
        /// <returns>A new <see cref="Int64Value"/> instance with the value.</returns>
        public static implicit operator Int64Value(long value) => FromInt64(value);

        /// <summary>
        /// Returns a new <see cref="Int64Value"/> object that was created from an <see cref="long"/> value.
        /// </summary>
        /// <param name="value">An <see cref="long"/> value to use to create a new <see cref="Int64Value"/> object.</param>
        /// <returns>An <see cref="Int64Value"/> that corresponds to the value parameter.</returns>
        public static Int64Value FromInt64(long value) => new Int64Value(value);

        /// <summary>
        /// Returns the <see cref="long"/> representation of an <see cref="Int64Value"/> object.
        /// </summary>
        /// <param name="value">
        /// An <see cref="Int64Value"/> object used to retrieve an <see cref="long"/> representation.
        /// </param>
        /// <returns>An <see cref="long"/> value that represents an <see cref="Int64Value"/> object.</returns>
        public static long ToInt64(Int64Value value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return value.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new Int64Value(this);
    }
}
