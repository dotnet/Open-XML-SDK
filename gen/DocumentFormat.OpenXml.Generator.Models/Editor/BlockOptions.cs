// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

namespace DocumentFormat.OpenXml.Generator.Editor;

public record BlockOptions
{
    public bool IncludeSemiColon { get; init; }

    public string? FinalText { get; init; }

    public bool AddNewLineBeforeClosing { get; internal set; }

    public bool IncludeTrailingNewline { get; init; } = true;
}
