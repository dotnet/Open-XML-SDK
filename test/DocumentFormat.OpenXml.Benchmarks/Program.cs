﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Diagnostics.Windows;
using BenchmarkDotNet.Exporters;
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
            var config = GetConfig(input);

            switcher.Run(new[] { "--filter", "*" }, config);
        }

        private static IConfig GetConfig(string[] args)
        {
            var config = new CustomConfig();

            if (args.Length > 0)
            {
                return config.WithArtifactsPath(args[0]);
            }
            else
            {
                return config;
            }
        }

        private class CustomConfig : ManualConfig
        {
            public CustomConfig()
            {
                // Diagnosers
                Add(MemoryDiagnoser.Default);

                // Columns
                Add(DefaultConfig.Instance.GetColumnProviders().ToArray());

                // Loggers
                Add(ConsoleLogger.Default);

                // Exporters
                Add(AsciiDocExporter.Default);
                Add(HtmlExporter.Default);

                Add(Job.InProcess);
            }
        }
    }
}
