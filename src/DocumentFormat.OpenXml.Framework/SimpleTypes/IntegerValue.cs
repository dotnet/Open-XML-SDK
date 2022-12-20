// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the xsd:integer value for attributes.
    /// </summary>
    /// <remarks>
    /// Integer is derived from decimal by fixing the value of fractionDigits to be 0 and disallowing the trailing decimal point.
    /// The value space of integer is the infinite set {...,-2,-1,0,1,2,...}. The base type of integer is decimal.
    /// </remarks>
    [DebuggerDisplay("{InnerText}")]
    public class IntegerValue : OpenXmlComparableSimpleValue<long>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegerValue"/> class.
        /// </summary>
        public IntegerValue()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegerValue"/> class using the supplied <see cref="long"/> value.
        /// </summary>
        /// <param name="value">The <see cref="long"/> value.</param>
        public IntegerValue(long value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegerValue"/> class by deep copying the supplied <see cref="IntegerValue"/> class.
        /// </summary>
        /// <param name="source">The source <see cref="IntegerValue"/> class.</param>
        public IntegerValue(IntegerValue source)
            : base(source)
        {
        }

        private protected override string GetText(long input) => XmlConvert.ToString(input);

        private protected override long Parse(string input) => XmlConvert.ToInt64(input);

        /// <summary>
        /// Implicitly converts the specified <see cref="IntegerValue"/> to an <see cref="long"/> value.
        /// </summary>
        /// <param name="value">The <see cref="IntegerValue"/> to convert.</param>
        /// <returns>
        /// The converted <see cref="long"/> value.
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown when <paramref name="value"/> is <c>null</c>.</exception>
        public static implicit operator long(IntegerValue value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return ToInt64(value);
        }

        /// <summary>
        /// Implicitly converts the specified <see cref="long"/> value to an <see cref="IntegerValue"/> class.
        /// </summary>
        /// <param name="value">The specified value.</param>
        /// <returns>A new <see cref="IntegerValue"/> instance with the value.</returns>
        public static implicit operator IntegerValue(long value)
        {
            return FromInt64(value);
        }

        /// <summary>
        /// Returns a new <see cref="IntegerValue"/> object created from an <see cref="long"/> value.
        /// </summary>
        /// <param name="value">An <see cref="long"/> value to use to create a new <see cref="IntegerValue"/> object.</param>
        /// <returns>An <see cref="IntegerValue"/> that corresponds to the value parameter.</returns>
        public static IntegerValue FromInt64(long value)
        {
            return new IntegerValue(value);
        }

        /// <summary>
        /// Returns the <see cref="long"/> representation of an <see cref="IntegerValue"/> object.
        /// </summary>
        /// <param name="value">
        /// An <see cref="IntegerValue"/> object used to retrieve an <see cref="long"/> representation.
        /// </param>
        /// <returns>An <see cref="long"/> value that represents an <see cref="IntegerValue"/> object.</returns>
        public static long ToInt64(IntegerValue value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return value.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new IntegerValue(this);
    }
}
