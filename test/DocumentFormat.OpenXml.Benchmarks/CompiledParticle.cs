// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using BenchmarkDotNet.Attributes;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Validation.Schema;
using System.Xml;

#pragma warning disable CA1812

namespace DocumentFormat.OpenXml.Benchmarks
{
    public class CompiledParticle
    {
        private Framework.CompiledParticle _particle;

        [GlobalSetup]
        public void Setup()
        {
            _particle = new CompositeParticle.Builder(ParticleType.Sequence, 0, 1)
            {
                new ElementParticle(typeof(T1), 0, 1),
                new ElementParticle(typeof(T2), 0, 10),
                new ElementParticle(typeof(T3), 0, 1),
            }.Compile();
        }

        [Benchmark]
        public OpenXmlCompositeElement SetItem()
        {
            var t3 = new T3();

            var data = new TestOpenXmlCompositeElement();

            _particle.Set(data, t3);

            return data;
        }

        [Benchmark]
        public OpenXmlCompositeElement AddToCollection()
        {
            var t2 = new T2();

            var data = new TestOpenXmlCompositeElement();

            _particle.GetCollection<T2>(data).Add(t2);

            return data;
        }

        private class T1 : TestOpenXmlCompositeElement
        {
        }

        private class T2 : TestOpenXmlCompositeElement
        {
        }

        private class T3 : TestOpenXmlCompositeElement
        {
        }

        private class TestOpenXmlCompositeElement : OpenXmlCompositeElement
        {
            public override bool HasChildren => false;

            public override void RemoveAllChildren()
            {
                throw new System.NotImplementedException();
            }

            internal override void WriteContentTo(XmlWriter w)
            {
                throw new System.NotImplementedException();
            }

            private protected override void Populate(XmlReader xmlReader, OpenXmlLoadMode loadMode)
            {
                throw new System.NotImplementedException();
            }
        }
    }
}
