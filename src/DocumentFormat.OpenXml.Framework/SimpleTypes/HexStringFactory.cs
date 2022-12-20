// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

#if !FEATURE_SPAN
using System.Text;
#endif

namespace DocumentFormat.OpenXml
{
    /// <summary>
    /// A factory of hex strings.
    /// </summary>
    internal static class HexStringFactory
    {
        /// <summary>
        /// Returns a new hex string that was created from <paramref name="bytes"/>.
        /// </summary>
        /// <param name="bytes">A byte array to use to create a new hex string.</param>
        /// <returns>A hex string that corresponds to the value parameter.</returns>
#if FEATURE_SPAN
        public
#else
        internal
#endif
        static string Create(ReadOnlySpan<byte> bytes)
        {
            if (bytes.Length == 0)
            {
                return string.Empty;
            }

#if FEATURE_SPAN
            Span<char> chars = stackalloc char[bytes.Length * 2];

            for (var i = 0; i < bytes.Length; i++)
            {
                byte b = bytes[i];
                chars[i * 2] = ToCharUpper(b >> 4);
                chars[(i * 2) + 1] = ToCharUpper(b);
            }

            return new string(chars);
#else
            var sb = new StringBuilder(bytes.Length * 2);

            foreach (var b in bytes)
            {
                sb.Append(ToCharUpper(b >> 4));
                sb.Append(ToCharUpper(b));
            }

            return sb.ToString();
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
        /// Returns a new hex string that was created from <paramref name="bytes"/>.
        /// </summary>
        /// <param name="bytes">A byte array to use to create a new hex string.</param>
        /// <returns>A hex string that corresponds to the value parameter.</returns>
        public static string Create(params byte[] bytes) => Create(bytes.AsSpan());
    }
}
