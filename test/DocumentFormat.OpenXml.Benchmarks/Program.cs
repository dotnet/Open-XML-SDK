﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Exporters.Json;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using System.Linq;

namespace DocumentFormat.OpenXml.Benchmarks
{
    public static class Program
    {
        public static void Main(string[] input)
        {
            if (input is null)
            {
                throw new System.ArgumentNullException(nameof(input));
            }

            var switcher = new BenchmarkSwitcher(typeof(Program).Assembly);
            var config = new CustomConfig();

            var args = input.Length == 0 ? new[] { "--filter", "*" } : input;

            switcher.Run(args, config);
        }

        private class CustomConfig : ManualConfig
        {
            public CustomConfig()
            {
                // Diagnosers
                AddDiagnoser(MemoryDiagnoser.Default);

                // Columns
                AddColumnProvider(DefaultConfig.Instance.GetColumnProviders().ToArray());

                // Loggers
                AddLogger(ConsoleLogger.Default);

                // Exporters
                AddExporter(JsonExporter.FullCompressed);
                AddExporter(MarkdownExporter.GitHub);
            }
        }
    }
}
