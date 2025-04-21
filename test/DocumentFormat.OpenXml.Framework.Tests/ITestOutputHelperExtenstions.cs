// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Tests;
using System;
using System.IO;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    internal static class ITestOutputHelperExtenstions
    {
        public static void WriteObjectToTempFile<T>(this ITestOutputHelper output, string name, T obj)
        {
            var tmp = Path.GetTempFileName();

            output.WriteLine($"Wrote {name} to temp path {tmp}");

            File.WriteAllText(tmp, TestUtility.Serialize(obj));
        }
    }
}
