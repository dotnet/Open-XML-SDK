// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Newtonsoft.Json;
using System.IO;
using System.Reflection;

namespace DocumentFormat.OpenXml.Framework.Tests
{
    internal static class TestUtility
    {
        public static T Deserialize<T>(string name)
        {
            using (var stream = typeof(TestUtility).GetTypeInfo().Assembly.GetManifestResourceStream($"DocumentFormat.OpenXml.Framework.Tests.{name}"))
            using (var reader = new StreamReader(stream))
            {
                var txt = reader.ReadToEnd();

                return JsonConvert.DeserializeObject<T>(txt);
            }
        }

        public static string Serialize<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented);
        }
    }
}
