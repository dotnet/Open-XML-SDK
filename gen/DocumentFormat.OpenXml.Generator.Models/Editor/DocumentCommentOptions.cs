// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

namespace DocumentFormat.OpenXml.Generator.Editor;

internal class DocumentCommentOptions
{
    private Parameters? _parameters;

    public Paragraphs? Summary { get; set; }

    public Paragraphs? Remarks { get; set; }

    public Parameters Parameters
    {
        get
        {
            if (_parameters is null)
            {
                _parameters = new Parameters();
            }

            return _parameters;
        }

        set => _parameters = value;
    }

    public string? Return { get; set; }

    public bool TrailingNewLine { get; set; } = true;

    public bool TrailingNewLineTabs { get; set; } = true;
}
