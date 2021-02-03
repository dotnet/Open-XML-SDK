// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml
{
    internal static class SpanExtensions
    {
        public static Span<byte> AsSpan(this byte[] bytes)
            => new Span<byte>(bytes);

        public static string AsSpan(this string str)
            => str;

        public static string Slice(this string str, int start, int length)
            => str.Substring(start, length);
    }
}
