// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    [Flags]
    internal enum ApplicationType
    {
        Word = 1,
        Excel = 2,
        PowerPoint = 4,
        All = Word | Excel | PowerPoint,
    }
}
