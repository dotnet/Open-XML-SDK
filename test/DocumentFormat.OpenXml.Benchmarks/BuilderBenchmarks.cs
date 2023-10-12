// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using BenchmarkDotNet.Attributes;
using DocumentFormat.OpenXml.Builder;
using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml.Benchmarks
{
    public class BuilderBenchmarks
    {
        private TestBuilder _builder;

        [GlobalSetup]
        public void Setup()
        {
            _builder = (TestBuilder)CreateBuilder();
        }

        [Benchmark(Baseline = true)]
        public object CreateRaw()
        {
            return new MyPackage();
        }

        [Benchmark]
        public object CreateBuilder()
        {
            var builder = new TestBuilder();

            for (int i = 0; i < 2; i++)
            {
                builder
                    .Use((package, next) =>
                    {
                        package.Count++;
                        next(package);
                    });
            }

            // Create a single instance
            builder.BuildPipeline();

            return builder;
        }

        [Benchmark]
        public object NewBuilder()
        {
            var builder = (TestBuilder)_builder.Clone();

            return builder.OpenEmpty();
        }

        [Benchmark]
        public object NewBuilderWithPipeline()
        {
            var builder = (TestBuilder)_builder.Clone();

            builder.Use((package, next) =>
            {
                next(package);
            });

            return builder.OpenEmpty();
        }

        [Benchmark]
        public object SubsequentCall()
        {
            return _builder.OpenEmpty();
        }

        private class TestBuilder : OpenXmlPackageBuilder<MyPackage>
        {
            public TestBuilder(TestBuilder builder = null)
                : base(builder)
            {
            }

            public override MyPackage Create() => new();

            public override IPackageBuilder<MyPackage> Clone() => new TestBuilder(this);

            public OpenXmlPackage OpenEmpty()
            {
                var package = Create();
                Build()(package);
                return package;
            }
        }

        private sealed class MyPackage : OpenXmlPackage
        {
            public int Count { get; set; }
        }
    }
}
