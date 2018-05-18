// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Xml;

// See https://github.com/dotnet/roslyn-analyzers/issues/1671
#pragma warning disable CA1036

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the double value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class DoubleValue : OpenXmlComparableSimpleValue<double>
    {
        /// <summary>
        /// Initializes a new instance of the DoubleValue class.
        /// </summary>
        public DoubleValue()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DoubleValue class using the supplied
        /// Double value.
        /// </summary>
        /// <param name="value">The Double value.</param>
        public DoubleValue(double value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DoubleValue by deep copying the
        /// supplied DoubleValue value.
        /// </summary>
        /// <param name="source">
        /// The source DoubleValue class.
        /// </param>
        public DoubleValue(DoubleValue source)
            : base(source)
        {
        }

        private protected override string GetText(double input) => XmlConvert.ToString(input);

        private protected override double Parse(string input) => XmlConvert.ToDouble(input);

        /// <summary>
        /// Implicitly converts the specified value to a Double value.
        /// </summary>
        /// <param name="xmlAttribute">
        /// The DoubleValue object to convert.
        /// </param>
        /// <returns>
        /// The converted Double value.
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown when xmlAttribute is null.</exception>
        public static implicit operator double(DoubleValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return ToDouble(xmlAttribute);
        }

        /// <summary>
        /// Initializes a new instance of the DoubleValue class by implicitly
        /// converting the supplied Double value.
        /// </summary>
        /// <param name="value">
        /// The Double value.
        /// </param>
        /// <returns>A new DoubleValue instance with the value.</returns>
        public static implicit operator DoubleValue(double value)
        {
            return FromDouble(value);
        }

        /// <summary>
        /// Returns a new DoubleValue object created from a Double value.
        /// </summary>
        /// <param name="value">A Double value to use to create a new DoubleValue object.</param>
        /// <returns>A DoubleValue object that corresponds to the value parameter.</returns>
        public static DoubleValue FromDouble(double value)
        {
            return new DoubleValue(value);
        }

        /// <summary>
        /// Returns the Double value representation of a DoubleValue object.
        /// </summary>
        /// <param name="xmlAttribute">
        /// A DoubleValue object used to retrieve a Double value representation.
        /// </param>
        /// <returns>A Double value that represents a DoubleValue object.</returns>
        public static double ToDouble(DoubleValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new DoubleValue(this);
    }
}
