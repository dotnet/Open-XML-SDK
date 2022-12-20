// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the double value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class DoubleValue : OpenXmlComparableSimpleValue<double>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleValue"/> class.
        /// </summary>
        public DoubleValue()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleValue"/> class using the supplied
        /// <see cref="double"/> value.
        /// </summary>
        /// <param name="value">The <see cref="double"/> value.</param>
        public DoubleValue(double value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleValue"/> by deep copying the
        /// supplied <see cref="DoubleValue"/> value.
        /// </summary>
        /// <param name="source">
        /// The source <see cref="DoubleValue"/> class.
        /// </param>
        public DoubleValue(DoubleValue source)
            : base(source)
        {
        }

        private protected override string GetText(double input) => XmlConvert.ToString(input);

        private protected override double Parse(string input) => XmlConvert.ToDouble(input);

        /// <summary>
        /// Implicitly converts the specified value to a <see cref="double"/> value.
        /// </summary>
        /// <param name="value">
        /// The <see cref="DoubleValue"/> object to convert.
        /// </param>
        /// <returns>
        /// The converted <see cref="double"/> value.
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown when <paramref name="value"/> is <c>null</c>.</exception>
        public static implicit operator double(DoubleValue value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return ToDouble(value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleValue"/> class by implicitly
        /// converting the supplied <see cref="double"/> value.
        /// </summary>
        /// <param name="value">
        /// The <see cref="double"/> value.
        /// </param>
        /// <returns>A new <see cref="DoubleValue"/> instance with the value.</returns>
        public static implicit operator DoubleValue(double value)
        {
            return FromDouble(value);
        }

        /// <summary>
        /// Returns a new <see cref="DoubleValue"/> object created from a <see cref="double"/> value.
        /// </summary>
        /// <param name="value">A <see cref="double"/> value to use to create a new <see cref="DoubleValue"/> object.</param>
        /// <returns>A <see cref="DoubleValue"/> object that corresponds to the value parameter.</returns>
        public static DoubleValue FromDouble(double value)
        {
            return new DoubleValue(value);
        }

        /// <summary>
        /// Returns the <see cref="double"/> value representation of a <see cref="DoubleValue"/> object.
        /// </summary>
        /// <param name="value">
        /// A <see cref="DoubleValue"/> object used to retrieve a <see cref="double"/> value representation.
        /// </param>
        /// <returns>A <see cref="double"/> value that represents a <see cref="DoubleValue"/> object.</returns>
        public static double ToDouble(DoubleValue value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return value.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new DoubleValue(this);
    }
}
