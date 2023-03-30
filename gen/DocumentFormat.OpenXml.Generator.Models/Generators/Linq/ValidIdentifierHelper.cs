// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator;

internal class ValidIdentifierHelper
{
    private static readonly HashSet<string> Keywords = new HashSet<string>()
    {
        "as",
        "do",
        "if",
        "in",
        "is",
        "for",
        "int",
        "new",
        "out",
        "ref",
        "try",
        "base",
        "bool",
        "byte",
        "case",
        "char",
        "else",
        "enum",
        "goto",
        "lock",
        "long",
        "null",
        "this",
        "true",
        "uint",
        "void",
        "break",
        "catch",
        "class",
        "const",
        "event",
        "false",
        "fixed",
        "float",
        "sbyte",
        "short",
        "throw",
        "ulong",
        "using",
        "where",
        "while",
        "yield",
        "double",
        "extern",
        "object",
        "params",
        "public",
        "return",
        "sealed",
        "sizeof",
        "static",
        "string",
        "struct",
        "switch",
        "typeof",
        "unsafe",
        "ushort",
        "checked",
        "decimal",
        "default",
        "finally",
        "foreach",
        "partial",
        "private",
        "virtual",
        "abstract",
        "continue",
        "delegate",
        "explicit",
        "implicit",
        "internal",
        "operator",
        "override",
        "readonly",
        "volatile",
        "__arglist",
        "__makeref",
        "__reftype",
        "interface",
        "namespace",
        "protected",
        "unchecked",
        "__refvalue",
        "stackalloc",
    };

    public static bool IsValidIdentifier(string value)
    {
        // identifiers must be 1 char or longer
        if (string.IsNullOrEmpty(value))
        {
            return false;
        }

        if (value.Length > 512)
        {
            return false;
        }

        if (value[0] != '@')
        {
            if (IsKeyword(value))
            {
                return false;
            }
        }
        else
        {
            value = value.Substring(1);
        }

        return true;
    }

    internal static bool IsKeyword(string value)
    {
        return Keywords.Contains(value);
    }
}
