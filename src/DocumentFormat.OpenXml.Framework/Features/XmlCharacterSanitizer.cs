// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Text;

namespace DocumentFormat.OpenXml.Features;

internal static class XmlCharacterSanitizer
{
    public static bool IsValidXmlChar(char c)
    {
        // XML 1.0 Char production:
        //   Char ::= #x9 | #xA | #xD | [#x20-#xD7FF] | [#xE000-#xFFFD] | [#x10000-#x10FFFF]
        // The supplementary range is handled separately via surrogate pairs.
        return c == '\t'
            || c == '\n'
            || c == '\r'
            || (c >= '\u0020' && c <= '\uD7FF')
            || (c >= '\uE000' && c <= '\uFFFD');
    }

    public static string? SanitizeIfNeeded(string? value)
    {
        if (value is null || value.Length == 0)
        {
            return value;
        }

        var firstBad = FindFirstInvalid(value);
        if (firstBad < 0)
        {
            return value;
        }

        var builder = new StringBuilder(value.Length - 1);
        if (firstBad > 0)
        {
            builder.Append(value, 0, firstBad);
        }

        for (var i = firstBad; i < value.Length; i++)
        {
            var c = value[i];

            if (char.IsHighSurrogate(c) && i + 1 < value.Length && char.IsLowSurrogate(value[i + 1]))
            {
                builder.Append(c);
                builder.Append(value[i + 1]);
                i++;
                continue;
            }

            if (char.IsSurrogate(c))
            {
                continue;
            }

            if (IsValidXmlChar(c))
            {
                builder.Append(c);
            }
        }

        return builder.ToString();
    }

    public static bool TrySanitizeSpan(char[] buffer, int index, int count, out char[] resultBuffer, out int resultCount)
    {
        for (var i = index; i < index + count; i++)
        {
            var c = buffer[i];

            if (char.IsHighSurrogate(c) && i + 1 < index + count && char.IsLowSurrogate(buffer[i + 1]))
            {
                i++;
                continue;
            }

            if (char.IsSurrogate(c) || !IsValidXmlChar(c))
            {
                return TrySanitizeSpanSlow(buffer, index, count, i, out resultBuffer, out resultCount);
            }
        }

        resultBuffer = buffer;
        resultCount = count;
        return false;
    }

    private static bool TrySanitizeSpanSlow(char[] buffer, int index, int count, int firstBad, out char[] resultBuffer, out int resultCount)
    {
        var output = new char[count];
        var written = 0;

        for (var i = index; i < firstBad; i++)
        {
            output[written++] = buffer[i];
        }

        for (var i = firstBad; i < index + count; i++)
        {
            var c = buffer[i];

            if (char.IsHighSurrogate(c) && i + 1 < index + count && char.IsLowSurrogate(buffer[i + 1]))
            {
                output[written++] = c;
                output[written++] = buffer[i + 1];
                i++;
                continue;
            }

            if (char.IsSurrogate(c))
            {
                continue;
            }

            if (IsValidXmlChar(c))
            {
                output[written++] = c;
            }
        }

        resultBuffer = output;
        resultCount = written;
        return true;
    }

    private static int FindFirstInvalid(string value)
    {
        for (var i = 0; i < value.Length; i++)
        {
            var c = value[i];

            if (char.IsHighSurrogate(c) && i + 1 < value.Length && char.IsLowSurrogate(value[i + 1]))
            {
                i++;
                continue;
            }

            if (char.IsSurrogate(c) || !IsValidXmlChar(c))
            {
                return i;
            }
        }

        return -1;
    }
}
