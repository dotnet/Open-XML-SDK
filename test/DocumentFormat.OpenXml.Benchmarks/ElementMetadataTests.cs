// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using BenchmarkDotNet.Attributes;
using DocumentFormat.OpenXml.Framework.Metadata;

namespace DocumentFormat.OpenXml.Benchmarks
{
    public class ElementMetadataTests
    {
        private OpenXmlElement _element;
        private TypedElementMetadataFactoryFeature _provider;

        [GlobalSetup]
        public void Setup()
        {
            _element = new AlternateContent();
            _provider = new TypedElementMetadataFactoryFeature();
        }

        [Benchmark]
        public object CreateWithInstance()
        {
            object o = _provider.GetMetadata(_element);
            return o; // return the object to make the release build do not optimize it
        }

        [Benchmark]
        public object CreateWithGeneric()
        {
            object o = _provider.GetMetadata(new AlternateContent());
            return o; // return the object to make the release build do not optimize it
        }
    }
}
