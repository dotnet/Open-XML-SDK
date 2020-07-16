// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using BenchmarkDotNet.Attributes;
using DocumentFormat.OpenXml.Framework.Metadata;

namespace DocumentFormat.OpenXml.Benchmarks
{
    public class ElementMetadataTests
    {
        [GlobalSetup]
        public void Setup()
        {
            _element = new AlternateContent();
        }

        [Benchmark]
        public object CreateWithInstance()
        {
            object o = ElementMetadata.Create(_element);
            return o; // return the object to make the release build do not optimize it
        }

        [Benchmark]
        public object CreateWithGeneric()
        {
            object o = ElementMetadata.Create<AlternateContent>();
            return o; // return the object to make the release build do not optimize it
        }

        private OpenXmlElement _element;
    }
}
