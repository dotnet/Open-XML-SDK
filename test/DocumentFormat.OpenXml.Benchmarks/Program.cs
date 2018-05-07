// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using System;
using System.Linq;
using System.Reflection;

namespace DocumentFormat.OpenXml.Benchmarks
{
    public static class Program
    {
        public static void Main(string[] input)
        {
            var types = GetBenchmarks();
            var switcher = new BenchmarkSwitcher(types);
            var (config, args) = GetArtifactsPath(input);

            if (args.Length == 0)
            {
                args = types.Select(t => t.Name).ToArray();
            }

            switcher.Run(args, config);
        }

        private static (IConfig, string[]) GetArtifactsPath(string[] args)
        {
            const string OutputFlag = "-output:";

            if (args.Length > 0 && args[0] is string initial && initial.StartsWith(OutputFlag, StringComparison.Ordinal))
            {
                var path = initial.Substring(OutputFlag.Length);
                var config = new CustomConfig().WithArtifactsPath(path);

                return (config, args.Skip(1).ToArray());
            }
            else
            {
                return (new CustomConfig(), args);
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

                // Frameworks to run against
#if NET46
                Add(Job.Default.With(Runtime.Clr).WithId("net46"));
                Add(Job.Default.With(Runtime.Mono).WithId("mono"));
#else
                Add(Job.Default.With(Runtime.Core));
#endif
            }
        }

        internal static Type[] GetBenchmarks()
        {
            var assembly = typeof(BenchmarkAttribute).GetTypeInfo().Assembly;
            var extensions = assembly.GetType("BenchmarkDotNet.Extensions.ReflectionExtensions");
            var method = extensions.GetMethod("GetRunnableBenchmarks", BindingFlags.NonPublic | BindingFlags.Static);

            return (Type[])method.Invoke(null, new object[] { typeof(Program).GetTypeInfo().Assembly });
        }
    }
}
