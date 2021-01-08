// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// Represent the xsd:hexBinary value for attributes.
    /// </summary>
    [DebuggerDisplay("{InnerText}")]
    public class HexBinaryValue : StringValue
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HexBinaryValue"/> class.
        /// </summary>
        public HexBinaryValue()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HexBinaryValue"/> class using the supplied string.
        /// </summary>
        /// <param name="hexBinary">The string value.</param>
        public HexBinaryValue(string hexBinary)
        {
            TextValue = hexBinary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HexBinaryValue"/> class by deep copying the supplied <see cref="HexBinaryValue"/> class.
        /// </summary>
        /// <param name="source">The source <see cref="HexBinaryValue"/> class.</param>
        public HexBinaryValue(HexBinaryValue source)
            : base((StringValue)source)
        {
        }

        /// <remarks>
        /// hexBinary has a lexical representation where each binary octet is encoded as a character tuple,
        /// consisting of two hexadecimal digits ([0-9a-fA-F]) representing the octet code.
        /// For example, "0FB7" is a hex encoding for the 16-bit integer 4023 (whose binary representation is 111110110111).
        /// </remarks>
        internal override bool IsValid
        {
            get
            {
                if (InnerText is null)
                {
                    return false;
                }

                var length = InnerText.Length;

                if (length % 2 == 1)
                {
                    return false;
                }

                for (var i = 0; i < length; i++)
                {
                    var current = InnerText[i];
                    var isDigit = IsLetterBetween(current, '0', '9');
                    var isLower = IsLetterBetween(current, 'a', 'f');
                    var isUpper = IsLetterBetween(current, 'A', 'F');

                    if (!isDigit && !isLower && !isUpper)
                    {
                        return false;
                    }
                }

                return true;

                bool IsLetterBetween(char check, char lower, char upper)
                {
                    return check >= lower && check <= upper;
                }
            }
        }

        internal override int Length => (InnerText?.Length ?? 0) / 2;

        /// <summary>
        /// Gets or sets the hex binary value
        /// </summary>
        public override string? Value
        {
            get => TextValue;
            set => TextValue = value;
        }

        /// <summary>
        /// Implicitly converts the specified value to a <see cref="string"/> value.
        /// </summary>
        /// <param name="value">The <see cref="HexBinaryValue"/> object to convert.</param>
        /// <returns>The converted HexBinary string. Returns null when <paramref name="value"/> is <c>null</c>.</returns>
        public static implicit operator string?(HexBinaryValue value)
        {
            if (value is null)
            {
                return null;
            }

            return ToString(value);
        }

        /// <summary>
        /// Implicitly converts the specified <see cref="string"/> value to a <see cref="HexBinaryValue"/> object.
        /// </summary>
        /// <param name="value">The specified hexBinary value.</param>
        /// <returns>A new <see cref="HexBinaryValue"/> instance with the value.</returns>
        public static implicit operator HexBinaryValue(string value) => FromString(value);

        /// <summary>
        /// Returns a new <see cref="HexBinaryValue"/> object that was created from a <see cref="string"/> value.
        /// </summary>
        /// <param name="value">A <see cref="string"/> value to use to create a new <see cref="HexBinaryValue"/> object.</param>
        /// <returns>A <see cref="HexBinaryValue"/> object that corresponds to the value parameter.</returns>
        public static new HexBinaryValue FromString(string value) => new HexBinaryValue(value);

        /// <summary>
        /// Returns the <see cref="string"/> value representation of a <see cref="HexBinaryValue"/> object.
        /// </summary>
        /// <param name="value">
        /// A <see cref="HexBinaryValue"/> object used to retrieve a <see cref="string"/> value representation.
        /// </param>
        /// <returns>A <see cref="string"/> value that represents a <see cref="HexBinaryValue"/> object.</returns>
        public static string? ToString(HexBinaryValue value)
        {
            if (value is null)
            {
                throw new InvalidOperationException(ExceptionMessages.ImplicitConversionExceptionOnNull);
            }

            return value.Value;
        }

        private protected override OpenXmlSimpleType CloneImpl() => new HexBinaryValue(this);
    }
}
