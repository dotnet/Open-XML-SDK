// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.CodeDom.Compiler;

namespace DocumentFormat.OpenXml.Generator.Editor;

public readonly struct Indentation : IDisposable
{
    private static readonly BlockOptions _defaultOptions = new();

    private readonly IndentedTextWriter _writer;
    private readonly BlockOptions _options;

    public Indentation(IndentedTextWriter writer, BlockOptions? options = null)
    {
        _writer = writer;
        _writer.Indent++;
        _options = options ?? _defaultOptions;
    }

    public void Dispose()
    {
        _writer.Indent--;

        if (_options.AddNewLineBeforeClosing)
        {
            _writer.WriteLine();
        }

        if (_options.FinalText is not null)
        {
            _writer.Write(_options.FinalText);

            if (_options.IncludeSemiColon)
            {
                _writer.Write(";");
            }
        }

        if (_options.IncludeTrailingNewline)
        {
            _writer.WriteLine();
        }
    }
}
