// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;

// See https://github.com/dotnet/roslyn-analyzers/issues/1671
#pragma warning disable CA1036

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represent the xsd:hexBinary value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class HexBinaryValue : OpenXmlComparableSimpleReference<string>
    {
        /// <summary>
        /// Initializes a new instance of the HexBinaryValue class.
        /// </summary>
        public HexBinaryValue()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HexBinaryValue class using the supplied string.
        /// </summary>
        /// <param name="hexBinary">The string value.</param>
        public HexBinaryValue(string hexBinary)
        {
            TextValue = hexBinary;
        }

        /// <summary>
        /// Initializes a new instance of the HexBinaryValue class by deep copying the supplied HexBinaryValue class.
        /// </summary>
        /// <param name="source">The source HexBinaryValue class.</param>
        public HexBinaryValue(HexBinaryValue source)
            : base(source)
        {
        }

        /// <summary>
        /// Gets or sets the hex binary value
        /// </summary>
        public override string Value
        {
            get => TextValue;
            set => TextValue = value;
        }

        /// <summary>
        /// Implicitly converts the specified value to a String value.
        /// </summary>
        /// <param name="xmlAttribute">The HexBinaryValue object to convert.</param>
        /// <returns>The converted HexBinary string. Returns null when xmlAttribute is null.</returns>
        public static implicit operator string(HexBinaryValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                return null;
            }

            return ToString(xmlAttribute);
        }

        /// <summary>
        /// Implicitly converts the specified String value to a HexBinaryValue object.
        /// </summary>
        /// <param name="value">The specified hexBinary value.</param>
        /// <returns>A new HexBinaryValue instance with the value.</returns>
        public static implicit operator HexBinaryValue(string value)
        {
            return FromString(value);
        }

        /// <summary>
        /// Returns a new HexBinaryValue object that was created from a String value.
        /// </summary>
        /// <param name="value">A String value to use to create a new HexBinaryValue object.</param>
        /// <returns>A HexBinaryValue object that corresponds to the value parameter.</returns>
        public static HexBinaryValue FromString(string value)
        {
            return new HexBinaryValue(value);
        }

        /// <summary>
        /// Returns the String value representation of a HexBinaryValue object.
        /// </summary>
        /// <param name="xmlAttribute">
        /// A HexBinaryValue object used to retrieve a String value representation.
        /// </param>
        /// <returns>A String value that represents a HexBinaryValue object.</returns>
        public static string ToString(HexBinaryValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new HexBinaryValue(this);
    }
}
