// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Tests.Common.OutputHelperExtensions
{
    public static class ITestOutputHelperExtenstions
    {
        public static void WriteObjectToTempFile(this ITestOutputHelper output, object obj)
        {
            var tmp = Path.GetTempFileName();

            output.WriteLine($"Wrote to temp path {tmp}");

            File.WriteAllText(tmp, JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented, new StringEnumConverter()));
        }
    }
}
