// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

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
