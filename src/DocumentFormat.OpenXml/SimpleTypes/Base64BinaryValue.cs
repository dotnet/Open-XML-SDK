// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represents the xsd:base64Binary value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class Base64BinaryValue : StringValue
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Base64BinaryValue"/> class.
        /// </summary>
        public Base64BinaryValue()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Base64BinaryValue"/> class by deep copying
        /// the supplied <see cref="string"/> value.
        /// </summary>
        /// <param name="base64Binary">
        /// The <see cref="string"/> value.
        /// </param>
        public Base64BinaryValue(string? base64Binary)
        {
            TextValue = base64Binary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Base64BinaryValue"/> class by deep copying
        /// the supplied <see cref="Base64BinaryValue"/> class.
        /// </summary>
        /// <param name="source">
        /// The source <see cref="Base64BinaryValue"/> class.
        /// </param>
        public Base64BinaryValue(Base64BinaryValue source)
            : base(source?.InnerText)
        {
        }

        /// <summary>
        /// Gets or sets the Base64 binary string value.
        /// </summary>
        public override string? Value
        {
            get => TextValue;
            set => TextValue = value;
        }

        /// <remarks>
        /// The lexical forms of base64Binary values are limited to the 65 characters of the Base64 Alphabet defined in [RFC 2045], i.e., a-z, A-Z, 0-9, the plus sign (+), the forward slash (/) and the equal sign (=), together with the characters defined in [XML 1.0 (Second Edition)] as white space. No other characters are allowed.
        /// </remarks>
        internal override bool IsValid
        {
            get
            {
                if (InnerText is null)
                {
                    return false;
                }
                else if (InnerText.Length == 0)
                {
                    return true;
                }

                try
                {
                    Convert.FromBase64String(InnerText);
                    return true;
                }
                catch (FormatException)
                {
                    return false;
                }
            }
        }

        internal override int Length
        {
            get
            {
                if (InnerText is null)
                {
                    return 0;
                }

                // decoded the data
                var binaryData = Convert.FromBase64String(InnerText);
                return binaryData.Length;
            }
        }

        /// <summary>
        /// Implicitly converts the specified value to a <see cref="string"/> value.
        /// </summary>
        /// <param name="value">The <see cref="Base64BinaryValue"/> object to convert.</param>
        /// <returns>The base64Binary string. Returns null when <paramref name="value"/> is <c>null</c>.</returns>
        public static implicit operator string?(Base64BinaryValue value)
        {
            if (value is null)
            {
                return null;
            }

            return ToString(value);
        }

        /// <summary>
        /// Initializes a new instance of a <see cref="Base64BinaryValue"/> class using the
        /// supplied string.
        /// </summary>
        /// <param name="value">The specified base64Binary value.</param>
        /// <returns>A new <see cref="Base64BinaryValue"/> instance with the value.</returns>
        public static implicit operator Base64BinaryValue(string? value) => FromString(value);

        /// <summary>
        /// Returns a new <see cref="Base64BinaryValue"/> object that was created from a <see cref="string"/> value.
        /// </summary>
        /// <param name="value">A <see cref="string"/> value to use to create a new <see cref="Base64BinaryValue"/> object.</param>
        /// <returns>A <see cref="Base64BinaryValue"/> that corresponds to the value parameter.</returns>
        public new static Base64BinaryValue FromString(string? value) => new Base64BinaryValue(value);

        /// <summary>
        /// Returns the <see cref="string"/>  value representation of a <see cref="Base64BinaryValue"/> object.
        /// </summary>
        /// <param name="value">
        /// A <see cref="Base64BinaryValue"/> object used to retrieve a <see cref="string"/> value representation.
        /// </param>
        /// <returns>A <see cref="string"/> value that represents a <see cref="Base64BinaryValue"/> object.</returns>
        public static string? ToString(Base64BinaryValue value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return value.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new Base64BinaryValue(this);
    }
}
