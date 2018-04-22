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
    /// Represents the byte value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class ByteValue : OpenXmlComparableSimpleValue<byte>
    {
        /// <summary>
        /// Initializes a new instance of the ByteValue class.
        /// </summary>
        public ByteValue()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ByteValue class using the supplied
        /// Byte value.
        /// </summary>
        /// <param name="value">The Byte value.</param>
        public ByteValue(byte value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ByteValue class by deep copying
        /// the supplied ByteValue class.
        /// </summary>
        /// <param name="source">
        /// The source ByteValue class.
        /// </param>
        public ByteValue(ByteValue source)
            : base(source)
        {
        }

        private protected override string GetText(byte input) => XmlConvert.ToString(input);

        private protected override byte Parse(string input) => XmlConvert.ToByte(TextValue);

        /// <summary>
        /// Implicitly converts the specified value to a Byte value.
        /// </summary>
        /// <param name="xmlAttribute">
        /// The ByteValue to convert.
        /// </param>
        /// <returns>
        /// The converted Byte value.
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown when xmlAttribute is null.</exception>
        public static implicit operator byte(ByteValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return ToByte(xmlAttribute);
        }

        /// <summary>
        /// Initializes a new instance of the ByteValue class by implicitly converting
        /// the supplied Byte value.
        /// </summary>
        /// <param name="value">
        /// The Byte value.
        /// </param>
        /// <returns>A new ByteValue instance with the value.</returns>
        public static implicit operator ByteValue(byte value)
        {
            return FromByte(value);
        }

        /// <summary>
        /// Returns a new ByteValue object created from a Byte value.
        /// </summary>
        /// <param name="value">A Byte value to create a new ByteValue object from.</param>
        /// <returns>A ByteValue that corresponds to the value parameter.</returns>
        public static ByteValue FromByte(byte value)
        {
            return new ByteValue(value);
        }

        /// <summary>
        /// Returns the Byte value representation of a ByteValue object.
        /// </summary>
        /// <param name="xmlAttribute">
        /// A ByteValue object to retrieve a Byte value representation.
        /// </param>
        /// <returns>A Byte value that represents a ByteValue object.</returns>
        public static byte ToByte(ByteValue xmlAttribute)
        {
            if (xmlAttribute == null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return xmlAttribute.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new ByteValue(this);
    }
}
