// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the byte value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class ByteValue : OpenXmlComparableSimpleValue<byte>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ByteValue"/> class.
        /// </summary>
        public ByteValue()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ByteValue"/> class using the supplied
        /// <see cref="byte"/> value.
        /// </summary>
        /// <param name="value">The <see cref="byte"/> value.</param>
        public ByteValue(byte value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ByteValue"/> class by deep copying
        /// the supplied <see cref="ByteValue"/> class.
        /// </summary>
        /// <param name="source">
        /// The source <see cref="ByteValue"/> class.
        /// </param>
        public ByteValue(ByteValue source)
            : base(source)
        {
        }

        private protected override string GetText(byte input) => XmlConvert.ToString(input);

        private protected override byte Parse(string input) => XmlConvert.ToByte(input);

        /// <summary>
        /// Implicitly converts the specified value to a <see cref="byte"/> value.
        /// </summary>
        /// <param name="value">
        /// The <see cref="ByteValue"/> to convert.
        /// </param>
        /// <returns>
        /// The converted <see cref="byte"/> value.
        /// </returns>
        /// <exception cref="InvalidOperationException">Thrown when <paramref name="value"/> is null.</exception>
        public static implicit operator byte(ByteValue value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return ToByte(value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ByteValue"/> class by implicitly converting
        /// the supplied <see cref="byte"/> value.
        /// </summary>
        /// <param name="value">
        /// The <see cref="byte"/> value.
        /// </param>
        /// <returns>A new <see cref="ByteValue"/> instance with the value.</returns>
        public static implicit operator ByteValue(byte value) => FromByte(value);

        /// <summary>
        /// Returns a new <see cref="ByteValue"/> object created from a <see cref="byte"/> value.
        /// </summary>
        /// <param name="value">A <see cref="byte"/> value to create a new <see cref="ByteValue"/> object from.</param>
        /// <returns>A <see cref="ByteValue"/> that corresponds to the value parameter.</returns>
        public static ByteValue FromByte(byte value) => new ByteValue(value);

        /// <summary>
        /// Returns the <see cref="byte"/> value representation of a <see cref="ByteValue"/> object.
        /// </summary>
        /// <param name="value">
        /// A <see cref="ByteValue"/> object to retrieve a <see cref="byte"/> value representation.
        /// </param>
        /// <returns>A <see cref="byte"/> value that represents a <see cref="ByteValue"/> object.</returns>
        public static byte ToByte(ByteValue value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return value.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new ByteValue(this);
    }
}
