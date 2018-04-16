// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using BenchmarkDotNet.Attributes;

namespace DocumentFormat.OpenXml.Benchmarks
{
    [MemoryDiagnoser]
    public partial class Tests
    {
        [GlobalSetup]
        public void GlobalSetup()
        {
            SetupFile();
            SetupSchemaData();
        }
    }
}
