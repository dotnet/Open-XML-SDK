// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the decimal value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class DecimalValue : OpenXmlComparableSimpleValue<decimal>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DecimalValue"/> class.
        /// </summary>
        public DecimalValue()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecimalValue"/> class using the supplied
        /// <see cref="decimal"/> value.
        /// </summary>
        /// <param name="value">The <see cref="decimal"/> value.</param>
        public DecimalValue(decimal value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecimalValue"/> class by deep copying
        /// the supplied <see cref="DecimalValue"/> class.
        /// </summary>
        /// <param name="source">
        /// The source <see cref="DecimalValue"/> class.
        /// </param>
        public DecimalValue(DecimalValue source)
            : base(source)
        {
        }

        private protected override string GetText(decimal input) => XmlConvert.ToString(input);

        private protected override decimal Parse(string input) => XmlConvert.ToDecimal(input);

        /// <summary>
        /// Implicitly converts the specified value to a <see cref="decimal"/> value.
        /// </summary>
        /// <param name="value">
        /// The <see cref="DecimalValue"/> to convert.
        /// </param>
        /// <returns>
        /// The converted <see cref="decimal"/> value.
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown when <paramref name="value"/> is null.</exception>
        public static implicit operator decimal(DecimalValue value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return ToDecimal(value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecimalValue"/> class by implicitly
        /// converting the supplied <see cref="decimal"/> value.
        /// </summary>
        /// <param name="value">
        /// The <see cref="decimal"/> value.
        /// </param>
        /// <returns>A new <see cref="DecimalValue"/> instance with the value.</returns>
        public static implicit operator DecimalValue(decimal value) => FromDecimal(value);

        /// <summary>
        /// Returns a new <see cref="DecimalValue"/> object that was created from a <see cref="decimal"/> value.
        /// </summary>
        /// <param name="value">A <see cref="decimal"/> value to use to create a new <see cref="DecimalValue"/> object.</param>
        /// <returns>A <see cref="DecimalValue"/> object that corresponds to the value parameter.</returns>
        public static DecimalValue FromDecimal(decimal value) => new DecimalValue(value);

        /// <summary>
        /// Returns the <see cref="decimal"/> representation of a <see cref="DecimalValue"/> object.
        /// </summary>
        /// <param name="value">
        /// A <see cref="DecimalValue"/> object to use to retrieve a <see cref="decimal"/> representation.
        /// </param>
        /// <returns>A <see cref="decimal"/> value that represents a <see cref="DecimalValue"/> object.</returns>
        public static decimal ToDecimal(DecimalValue value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return value.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new DecimalValue(this);
    }
}
