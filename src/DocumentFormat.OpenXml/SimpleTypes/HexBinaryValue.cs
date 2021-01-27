// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

#if !FEATURE_SPAN
using System.Text;
#endif

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
        /// <param name="hexBinary">The <see cref="string"/> value.</param>
        public HexBinaryValue(string? hexBinary)
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

                static bool IsLetterBetween(char check, char lower, char upper)
                    => check >= lower && check <= upper;
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
        /// Attempts to retrieve the bytes associated with this <see cref="HexBinaryValue"/> if available.
        /// </summary>
        /// <param name="bytes">The bytes if successfully written.</param>
        /// <returns>Whether bytes where successfully written.</returns>
        public bool TryGetBytes([MaybeNullWhen(false)] out byte[] bytes)
        {
            if (InnerText is null || InnerText.Length % 2 != 0)
            {
                bytes = null;
                return false;
            }

            var length = InnerText.Length;

            if (length == 0)
            {
                bytes = Cached.Array<byte>();
                return true;
            }

            bytes = new byte[length / 2];

            return TryWriteBytes(bytes.AsSpan());
        }

        /// <summary>
        /// Attempts to write the bytes associated with this <see cref="HexBinaryValue"/> if available.
        /// </summary>
        /// <param name="bytes">A buffer to write to</param>
        /// <returns>Whether bytes where successfully written.</returns>
#if FEATURE_SPAN
        public
#else
        internal
#endif
            bool TryWriteBytes(Span<byte> bytes)
        {
            if (InnerText is null)
            {
                return false;
            }

            if (InnerText.Length % 2 != 0 && bytes.Length != InnerText.Length / 2)
            {
                return false;
            }

            for (int i = 0; i < InnerText.Length; i += 2)
            {
                if (byte.TryParse(InnerText.AsSpan().Slice(i, 2), NumberStyles.HexNumber, null, out var result))
                {
                    bytes[i / 2] = result;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Returns a new <see cref="HexBinaryValue"/> object that was created from <paramref name="bytes"/>.
        /// </summary>
        /// <param name="bytes">A byte array to use to create a new <see cref="HexBinaryValue"/> object.</param>
        /// <returns>A <see cref="HexBinaryValue"/> object that corresponds to the value parameter.</returns>
#if FEATURE_SPAN
        public
#else
        internal
#endif
        static HexBinaryValue Create(ReadOnlySpan<byte> bytes)
        {
            if (bytes.Length == 0)
            {
                return new HexBinaryValue(string.Empty);
            }

#if FEATURE_SPAN
            Span<char> chars = stackalloc char[bytes.Length * 2];

            for (int i = 0; i < bytes.Length; i++)
            {
                var b = bytes[i];
                chars[i * 2] = ToCharUpper(b >> 4);
                chars[i * 2 + 1] = ToCharUpper(b);
            }

            return new HexBinaryValue(new string(chars));
#else
            var sb = new StringBuilder(bytes.Length * 2);

            foreach (var b in bytes)
            {
                sb.Append(ToCharUpper(b >> 4));
                sb.Append(ToCharUpper(b));
            }

            return new HexBinaryValue(sb.ToString());
#endif

            static char ToCharUpper(int value)
            {
                value &= 0xF;
                value += '0';

                if (value > '9')
                {
                    value += 'A' - ('9' + 1);
                }

                return (char)value;
            }
        }

        /// <summary>
        /// Returns a new <see cref="HexBinaryValue"/> object that was created from <paramref name="bytes"/>.
        /// </summary>
        /// <param name="bytes">A byte array to use to create a new <see cref="HexBinaryValue"/> object.</param>
        /// <returns>A <see cref="HexBinaryValue"/> object that corresponds to the value parameter.</returns>
        public static HexBinaryValue Create(params byte[] bytes)
            => Create(bytes.AsSpan());

        /// <summary>
        /// Implicitly converts the specified value to a <see cref="string"/> value.
        /// </summary>
        /// <param name="value">The <see cref="HexBinaryValue"/> object to convert.</param>
        /// <returns>The converted HexBinary string. Returns null when <paramref name="value"/> is <c>null</c>.</returns>
        public static implicit operator string?(HexBinaryValue? value)
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
        public static implicit operator HexBinaryValue(string? value) => FromString(value);

        /// <summary>
        /// Returns a new <see cref="HexBinaryValue"/> object that was created from a <see cref="string"/> value.
        /// </summary>
        /// <param name="value">A <see cref="string"/> value to use to create a new <see cref="HexBinaryValue"/> object.</param>
        /// <returns>A <see cref="HexBinaryValue"/> object that corresponds to the value parameter.</returns>
        public static new HexBinaryValue FromString(string? value) => new HexBinaryValue(value);

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
