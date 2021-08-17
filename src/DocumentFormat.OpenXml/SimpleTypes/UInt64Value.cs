// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the <see cref="ulong"/> value for attributes.
    /// </summary>
    [CLSCompliant(false)]
    [DebuggerDisplay("{InnerText}")]
    public class UInt64Value : OpenXmlComparableSimpleValue<ulong>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UInt64Value"/> class.
        /// </summary>
        public UInt64Value()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UInt64Value"/> class using the supplied <see cref="ulong"/> value.
        /// </summary>
        /// <param name="value">The <see cref="ulong"/> value.</param>
        public UInt64Value(ulong value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UInt64Value"/> class by deep copying the <see cref="UInt64Value"/> class.
        /// </summary>
        /// <param name="source">The source <see cref="UInt64Value"/> class.</param>
        public UInt64Value(UInt64Value source)
            : base(source)
        {
        }

        private protected override string GetText(ulong input) => XmlConvert.ToString(input);

        private protected override ulong Parse(string input) => XmlConvert.ToUInt64(input);

        /// <summary>
        /// Implicitly converts the specified <see cref="UInt64Value"/> object to a <see cref="ulong"/> value.
        /// </summary>
        /// <param name="value">The <see cref="UInt64Value"/> object to convert.</param>
        /// <returns>The converted <see cref="ulong"/> value.</returns>
        /// <exception cref="InvalidOperationException">Thrown when <paramref name="value"/> is <c>null</c>.</exception>
        public static implicit operator ulong(UInt64Value value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return ToUInt64(value);
        }

        /// <summary>
        /// Implicitly converts a specified <see cref="ulong"/> value to a <see cref="UInt64Value"/> class.
        /// </summary>
        /// <param name="value">The specified value.</param>
        /// <returns>A new <see cref="UInt64Value"/> instance with the value.</returns>
        public static implicit operator UInt64Value(ulong value) => FromUInt64(value);

        /// <summary>
        /// Returns a new <see cref="UInt64Value"/> object created from a <see cref="ulong"/> value.
        /// </summary>
        /// <param name="value">A <see cref="ulong"/> value to use to create a new <see cref="UInt64Value"/> object.</param>
        /// <returns>A <see cref="UInt64Value"/> that corresponds to the value parameter.</returns>
        public static UInt64Value FromUInt64(ulong value) => new UInt64Value(value);

        /// <summary>
        /// Returns the <see cref="ulong"/> value representation of a <see cref="UInt64Value"/> object.
        /// </summary>
        /// <param name="value">
        /// A <see cref="UInt64Value"/> object used to retrieve a <see cref="ulong"/> representation.
        /// </param>
        /// <returns>A <see cref="ulong"/> value that represents a <see cref="UInt64Value"/> object.</returns>
        public static ulong ToUInt64(UInt64Value value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return value.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new UInt64Value(this);
    }
}
