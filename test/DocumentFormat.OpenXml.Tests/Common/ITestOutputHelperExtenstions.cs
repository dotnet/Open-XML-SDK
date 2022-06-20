// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Tests.Common.OutputHelperExtensions
{
    public static class ITestOutputHelperExtenstions
    {
        public static void WriteObjectToTempFile(this ITestOutputHelper output, string name, object obj)
        {
            var tmp = Path.GetTempFileName();

            output.WriteLine($"Wrote {name} to temp path {tmp}");

            File.WriteAllText(tmp, JsonConvert.SerializeObject(obj, Formatting.Indented, new StringEnumConverter()));
        }
    }
}
