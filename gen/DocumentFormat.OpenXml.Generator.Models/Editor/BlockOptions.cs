// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DocumentFormat.OpenXml.Generator.Editor;

public record BlockOptions
{
    public bool IncludeSemiColon { get; init; }

    public string? FinalText { get; init; }

    public bool AddNewLineBeforeClosing { get; internal set; }

    public bool IncludeTrailingNewline { get; init; } = true;
}
