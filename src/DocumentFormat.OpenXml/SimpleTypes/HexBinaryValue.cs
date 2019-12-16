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
        public static new HexBinaryValue FromString(string value)
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
