// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable disable

using DocumentFormat;
using DocumentFormat.OpenXml.Generator.Models;

namespace DocumentFormat.OpenXml.Generator.Schematron
{
    internal static class ParseContext
    {
        public static ReadOnlySpan<char> ParsePart(string part)
            => ParsePart(part.AsSpan());

        public static ReadOnlySpan<char> ParsePart(ReadOnlySpan<char> part)
        {
            const string Part = "Part:";

            part = TrimQuotes(part);

            if (part.StartsWith(Part.AsSpan(), StringComparison.Ordinal))
            {
                part = part.Slice(Part.Length);
            }

            return part;
        }

        public static (ElementReference Element, ElementReference Parent) ParseElement(string element)
            => ParseElement(element.AsSpan());

        public static (ElementReference Element, ElementReference Parent) ParseElement(ReadOnlySpan<char> element)
        {
            if (element.IsEmpty)
            {
                return default;
            }

            element = TrimQuotes(element);

            var elements = element.ToString().Split('/');

            if (elements.Length == 1)
            {
                return (new(elements[0]), default);
            }

            if (elements.Length == 2)
            {
                return (new(elements[1]), new(elements[0]));
            }

            throw new ArgumentException();
        }

        public static ElementReference[] ParseContextElement(QName qname, string[] attributes)
        {
            var element = qname.ToString().AsSpan();

            if (element.IsEmpty)
            {
                return null;
            }

            var elements = TrimQuotes(element).ToString().Split('/');

            if (elements.Length == 1)
            {
                return new ElementReference[] { new(elements[0]) };
            }
            else if (elements.Length == 2)
            {
                return new ElementReference[] { new(elements[1]) };
            }
            else if (elements.Length == 3)
            {
                return new ElementReference[] { new(elements[2]) };
            }
            else
            {
                throw new ArgumentException(); // should not arrive here
            }
        }

        private static (string Ns, string Tag) ExtractNamespace(ReadOnlySpan<char> attribute)
        {
            attribute = TrimQuotes(attribute);

            var index = attribute.IndexOf(':');

            if (index < 0)
            {
                return (string.Empty, attribute.ToString());
            }
            else
            {
                return (attribute.Slice(0, index).ToString(), attribute.Slice(index + 1).ToString());
            }
        }

        public static AttributeReference ParseAttribute(string attribute)
            => ParseAttribute(attribute.AsSpan());

        public static AttributeReference ParseAttribute(ReadOnlySpan<char> attribute)
        {
            if (attribute.IsEmpty)
            {
                return default;
            }

            var (ns, tag) = ExtractNamespace(attribute);

            if (ns == "o")
            {
                ns = "ovml";
            }

            return new AttributeReference($"{ns}:{tag}");
        }

        public static ReadOnlySpan<char> TrimQuotes(string text)
            => TrimQuotes(text.AsSpan());

        public static ReadOnlySpan<char> TrimQuotes(ReadOnlySpan<char> text)
        {
            if (text.IsEmpty)
            {
                return text;
            }

            return text.Trim(" '\"".AsSpan());
        }
    }
}
