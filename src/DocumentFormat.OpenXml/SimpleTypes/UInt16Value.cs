// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the <see cref="ushort"/> value for attributes.
    /// </summary>
    [CLSCompliant(false)]
    [DebuggerDisplay("{InnerText}")]
    public class UInt16Value : OpenXmlComparableSimpleValue<ushort>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UInt16Value"/> class.
        /// </summary>
        public UInt16Value()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UInt16Value"/> class using the supplied <see cref="ushort"/> value.
        /// </summary>
        /// <param name="value">The <see cref="ushort"/> value.</param>
        public UInt16Value(ushort value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UInt16Value"/> class by deep copying the supplied <see cref="UInt16Value"/> class.
        /// </summary>
        /// <param name="source">The source <see cref="UInt16Value"/> class.</param>
        public UInt16Value(UInt16Value source)
            : base(source)
        {
        }

        private protected override string GetText(ushort input) => XmlConvert.ToString(input);

        private protected override ushort Parse(string input) => XmlConvert.ToUInt16(input);

        /// <summary>
        /// Implicitly converts the specified <see cref="UInt16Value"/> object to a <see cref="ushort"/> value.
        /// </summary>
        /// <param name="value">The <see cref="UInt16Value"/> to convert.</param>
        /// <returns>The converted <see cref="ushort"/> value.</returns>
        /// <exception cref="InvalidOperationException">Thrown when <paramref name="value"/> is <c>null</c>.</exception>
        public static implicit operator ushort(UInt16Value value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return ToUInt16(value);
        }

        /// <summary>
        /// Implicitly converts a <see cref="ushort"/> value to a <see cref="UInt16Value"/> class.
        /// </summary>
        /// <param name="value">The specified value.</param>
        /// <returns>A new <see cref="UInt16Value"/> instance with the value.</returns>
        public static implicit operator UInt16Value(ushort value) => FromUInt16(value);

        /// <summary>
        /// Returns a new <see cref="UInt16Value"/> object created from a <see cref="ushort"/> value.
        /// </summary>
        /// <param name="value">A <see cref="ushort"/> value to use to create a new <see cref="UInt16Value"/> object.</param>
        /// <returns>A <see cref="UInt16Value"/> that corresponds to the value parameter.</returns>
        public static UInt16Value FromUInt16(ushort value) => new UInt16Value(value);

        /// <summary>
        /// Returns the <see cref="ushort"/> representation of a <see cref="UInt16Value"/> object.
        /// </summary>
        /// <param name="value">
        /// A <see cref="UInt16Value"/> object to retrieve a <see cref="ushort"/> representation.
        /// </param>
        /// <returns>A <see cref="ushort"/> value that represents a <see cref="UInt16Value"/> object.</returns>
        public static ushort ToUInt16(UInt16Value value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return value.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new UInt16Value(this);
    }
}
