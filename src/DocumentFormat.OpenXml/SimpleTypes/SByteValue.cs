// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the <see cref="sbyte"/> value for attributes.
    /// </summary>
    [CLSCompliant(false)]
    [DebuggerDisplay("{InnerText}")]
    public class SByteValue : OpenXmlComparableSimpleValue<sbyte>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SByteValue"/> class.
        /// </summary>
        public SByteValue()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SByteValue"/> class using the supplied <see cref="sbyte"/> value.
        /// </summary>
        /// <param name="value">The <see cref="sbyte"/> value.</param>
        public SByteValue(sbyte value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SByteValue"/> by deep copying the supplied <see cref="SByteValue"/> class.
        /// </summary>
        /// <param name="source">The source <see cref="SByteValue"/> class.</param>
        public SByteValue(SByteValue source)
            : base(source)
        {
        }

        private protected override string GetText(sbyte input) => XmlConvert.ToString(input);

        private protected override sbyte Parse(string input) => XmlConvert.ToSByte(input);

        /// <summary>
        /// Implicitly converts the specified <see cref="SByteValue"/> to an <see cref="sbyte"/> value.
        /// </summary>
        /// <param name="value">The <see cref="SByteValue"/> to convert.</param>
        /// <returns>The converted <see cref="sbyte"/> value.</returns>
        /// <exception cref="InvalidOperationException">Thrown when <paramref name="value"/> is <c>null</c>.</exception>
        public static implicit operator sbyte(SByteValue value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return ToSByte(value);
        }

        /// <summary>
        /// Implicitly converts the specified <see cref="sbyte"/> value to an <see cref="SByteValue"/> instance.
        /// </summary>
        /// <param name="value">The specified <see cref="sbyte"/> value.</param>
        /// <returns>A new <see cref="SByteValue"/> instance with the value.</returns>
        public static implicit operator SByteValue(sbyte value) => FromSByte(value);

        /// <summary>
        /// Returns a new <see cref="SByteValue"/> object created from a Byte value.
        /// </summary>
        /// <param name="value">An <see cref="sbyte"/> value to use to create a new <see cref="SByteValue"/> object.</param>
        /// <returns>An <see cref="SByteValue"/> that corresponds to the value parameter.</returns>
        public static SByteValue FromSByte(sbyte value) => new SByteValue(value);

        /// <summary>
        /// Returns the <see cref="sbyte"/> representation of an <see cref="SByteValue"/> object.
        /// </summary>
        /// <param name="value">
        /// An <see cref="SByteValue"/> object to retrieve an <see cref="sbyte"/> representation.
        /// </param>
        /// <returns>An <see cref="sbyte"/> value that represents an <see cref="SByteValue"/> object.</returns>
        public static sbyte ToSByte(SByteValue value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return value.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new SByteValue(this);
    }
}
