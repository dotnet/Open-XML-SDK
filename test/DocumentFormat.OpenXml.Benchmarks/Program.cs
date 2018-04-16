// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using BenchmarkDotNet.Running;

namespace DocumentFormat.OpenXml.Benchmarks
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<Tests>();
        }
    }
}
