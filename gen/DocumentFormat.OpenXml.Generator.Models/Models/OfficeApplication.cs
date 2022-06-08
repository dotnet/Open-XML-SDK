// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

namespace DocumentFormat.OpenXml.Generator.Models;

[Flags]
public enum OfficeApplication
{
    None = 0x0,
    Word = 0x1,
    Excel = 0x2,
    PowerPoint = 0x4,
    All = 0x7,
}
