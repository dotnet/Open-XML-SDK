// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Validation.Semantic
{
    [Flags]
    internal enum SemanticValidationLevel
    {
        PackageOnly = 1,
        PartOnly = 2,
        ElementOnly = 4,

        Package = PackageOnly,
        Part = PackageOnly | PartOnly,
        Element = PackageOnly | PartOnly | ElementOnly,
    }
}
