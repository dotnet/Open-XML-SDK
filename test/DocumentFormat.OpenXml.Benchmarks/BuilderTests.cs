// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using BenchmarkDotNet.Attributes;
using DocumentFormat.OpenXml.Builder;
using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Packaging;

namespace DocumentFormat.OpenXml.Benchmarks
{
    public class BuilderTests
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
                    .Configure((package, next) =>
                    {
                        package.Count++;
                        next(package);
                    });
            }

            // Create a single instance
            builder.Build();

            return builder;
        }

        [Benchmark]
        public object NewBuilder()
        {
            var builder = (TestBuilder)_builder.New();

            return builder.Open();
        }

        [Benchmark]
        public object NewBuilderWithPipeline()
        {
            var builder = (TestBuilder)_builder.New();

            builder.Configure((package, next) =>
            {
                next(package);
            });

            return builder.Open();
        }

        [Benchmark]
        public object SubsequentCall()
        {
            return _builder.Open();
        }

        private class TestBuilder : OpenXmlPackageBuilder<MyPackage>, IPackageInitializer
        {
            public TestBuilder(TestBuilder builder = null)
                : base(builder)
            {
            }

            internal override MyPackage Create() => new();

            internal override OpenXmlPackageBuilder<MyPackage> New() => new TestBuilder(this);

            void IPackageInitializer.Register(OpenXmlPackage package)
            {
            }

            public OpenXmlPackage Open() => Open(this);
        }

        private sealed class MyPackage : OpenXmlPackage
        {
            public int Count { get; set; }
        }
    }
}
