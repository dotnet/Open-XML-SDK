// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the <see cref="uint"/> value for attributes.
    /// </summary>
    [CLSCompliant(false)]
    [DebuggerDisplay("{InnerText}")]
    public class UInt32Value : OpenXmlComparableSimpleValue<uint>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UInt32Value"/> class.
        /// </summary>
        public UInt32Value()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UInt32Value"/> class using the supplied <see cref="uint"/> value.
        /// </summary>
        /// <param name="value">The <see cref="uint"/> value.</param>
        public UInt32Value(uint value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UInt32Value"/> class by deep copying the supplied <see cref="UInt32Value"/> class.
        /// </summary>
        /// <param name="source">The source <see cref="UInt32Value"/> class.</param>
        public UInt32Value(UInt32Value source)
            : base(source)
        {
        }

        private protected override string GetText(uint input) => XmlConvert.ToString(input);

        private protected override uint Parse(string input) => XmlConvert.ToUInt32(input);

        /// <summary>
        /// Implicitly converts the specified <see cref="UInt32Value"/> class to a <see cref="uint"/> value.
        /// </summary>
        /// <param name="value">The <see cref="UInt32Value"/> class to convert.</param>
        /// <returns>The converted <see cref="uint"/> value.</returns>
        /// <exception cref="InvalidOperationException">Thrown when <paramref name="value"/> is <c>null</c>.</exception>
        public static implicit operator uint(UInt32Value value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return ToUInt32(value);
        }

        /// <summary>
        /// Implicitly converts a specified <see cref="uint"/> value to a <see cref="UInt32Value"/> class.
        /// </summary>
        /// <param name="value">The specified value.</param>
        /// <returns>A new <see cref="UInt32Value"/> instance with the value.</returns>
        public static implicit operator UInt32Value(uint value) => FromUInt32(value);

        /// <summary>
        /// Returns a new <see cref="UInt32Value"/> object created from a <see cref="uint"/> value.
        /// </summary>
        /// <param name="value">A <see cref="uint"/> value to use to create a new <see cref="UInt32Value"/> object.</param>
        /// <returns>A <see cref="UInt32Value"/> class that corresponds to the value parameter.</returns>
        public static UInt32Value FromUInt32(uint value) => new UInt32Value(value);

        /// <summary>
        /// Returns the <see cref="uint"/> value representation of a <see cref="UInt32Value"/> object.
        /// </summary>
        /// <param name="value">
        /// A <see cref="UInt32Value"/> object used to retrieve a <see cref="uint"/> value representation.
        /// </param>
        /// <returns>A <see cref="uint"/> value that represents a <see cref="UInt32Value"/> object.</returns>
        public static uint ToUInt32(UInt32Value value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return value.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new UInt32Value(this);
    }
}
