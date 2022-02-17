// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Generator.Editor;

public struct Delimiter
{
    private readonly IndentedTextWriter _writer;
    private readonly int _newLineCount;
    private readonly string _separator;

    public Delimiter(IndentedTextWriter writer, string separator, int newLineCount = 0)
    {
        _writer = writer;
        _newLineCount = newLineCount;
        _separator = separator;
        Count = 0;
    }

    public int Count { get; private set; }

    public void AddDelimiter()
    {
        if (Count > 0)
        {
            _writer.Write(_separator);
            if (_newLineCount > 0)
            {
                for (int i = 0; i < _newLineCount - 1; i++)
                {
                    _writer.WriteLineNoTabs();
                }

                _writer.WriteLine();
            }
            else
            {
                _writer.Write(" ");
            }
        }

        Count++;
    }
}
