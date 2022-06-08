// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

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
