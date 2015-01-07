// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml.Internal.SemanticValidation
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

    [Flags]
    internal enum ApplicationType
    {
        Word = 1,
        Excel = 2,
        PowerPoint = 4,
        All = Word | Excel | PowerPoint,
    }
}
