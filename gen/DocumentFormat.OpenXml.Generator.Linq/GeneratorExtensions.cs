// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace DocumentFormat.OpenXml.Generator.Linq
{
    internal static class GeneratorExtensions
    {
        public static string ToTitleCase(this string str) => CultureInfo.InvariantCulture.TextInfo.ToTitleCase(str);
    }
}
