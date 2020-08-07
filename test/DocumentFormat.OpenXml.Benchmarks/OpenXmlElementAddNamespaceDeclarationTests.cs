// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using BenchmarkDotNet.Attributes;
using DocumentFormat.OpenXml.Drawing.ChartDrawing;

namespace DocumentFormat.OpenXml.Benchmarks
{
    public class OpenXmlElementAddNamespaceDeclarationTests
    {
        [IterationSetup]
        public void Setup()
        {
            _element = new TextBody();
        }

        [Benchmark]
        public void AddNamespaceDeclaration()
        {
            _element.AddNamespaceDeclaration("test", "test");
        }

        private OpenXmlElement _element;
    }
}
