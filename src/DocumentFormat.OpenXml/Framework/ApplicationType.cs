// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System;

namespace DocumentFormat.OpenXml
{
    [Flags]
    internal enum ApplicationType
    {
        None = 0,
        Word = 1,
        Excel = 2,
        PowerPoint = 4,
        All = Word | Excel | PowerPoint,
    }
}
