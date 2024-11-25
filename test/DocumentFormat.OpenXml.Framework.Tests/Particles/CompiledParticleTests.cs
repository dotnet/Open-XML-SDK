// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation.Schema;
using System.Linq;
using System.Xml;
using Xunit;

namespace DocumentFormat.OpenXml.Framework.Tests
{
    public class CompiledParticleTests
    {
        [Fact]
        public void InvalidElementTest()
        {
            var t1 = new T1();
            var t2 = new T2();
            var particle = new ElementParticle(t1.QName, 0, 1)
                .Compile();
            var data = new TestOpenXmlCompositeElement();

            Assert.False(particle.Set(data, t2));
            Assert.Null(particle.Get(data, t2.QName));
        }

        [Fact]
        public void AllElements()
        {
            var particle = new CompositeParticle.Builder(ParticleType.Sequence, 0, 1)
            {
                new ElementParticle(new T1().QName, 0, 1),
                new ElementParticle(new T2().QName, 0, 1),
            }.Compile();
            var data = new TestOpenXmlCompositeElement();
            var t1a = new T1();
            var t1b = new T1();
            var t2a = new T2();

            data.AppendChild(t1a);
            data.AppendChild(t2a);
            data.AppendChild(t1b);

            Assert.Collection(
                particle.GetCollection(t1a.QName, data),
                e => Assert.Same(t1a, e),
                e => Assert.Same(t1b, e));
        }

        [Fact]
        public void SequenceAdd()
        {
            var particle = new CompositeParticle.Builder(ParticleType.Sequence, 0, 1)
            {
                new ElementParticle(new T1().QName, 0, 1),
                new ElementParticle(new T2().QName, 0, 1),
                new ElementParticle(new T3().QName, 0, 1),
                new ElementParticle(new T4().QName, 0, 1),
                new ElementParticle(new T5().QName, 0, 1),
                new ElementParticle(new T6().QName, 0, 1),
            }.Compile();

            var data = new TestOpenXmlCompositeElement();
            var t1 = new T1();
            var t3 = new T3();
            var t5 = new T5();

            Assert.Empty(data);

            particle.GetCollection(t1.QName, data).Add(t1);
            Assert.Collection(
                data,
                e => Assert.Same(e, t1));

            particle.GetCollection(t3.QName, data).Add(t3);
            Assert.Collection(
                data,
                e => Assert.Same(e, t1),
                e => Assert.Same(e, t3));

            particle.GetCollection(t5.QName, data).Add(t5);
            Assert.Collection(
                data,
                e => Assert.Same(e, t1),
                e => Assert.Same(e, t3),
                e => Assert.Same(e, t5));
        }

        [Fact]
        public void ElementTest()
        {
            var t1 = new T1();
            var particle = new ElementParticle(t1.QName, 0, 1)
                .Compile();
            var data = new TestOpenXmlCompositeElement();

            Assert.True(particle.Set(data, t1));
            Assert.Equal(t1, particle.Get(data, t1.QName));
        }

        [Fact]
        public void TwoElementInSequenceTestBackwards()
        {
            var particle = new CompositeParticle.Builder(ParticleType.Sequence, 0, 1)
            {
                new ElementParticle(new T1().QName, 0, 1),
                new ElementParticle(new T2().QName, 0, 1),
            }.Compile();
            var data = new TestOpenXmlCompositeElement();

            var t1 = new T1();
            var t2 = new T2();

            Assert.True(particle.Set(data, t2));
            Assert.True(particle.Set(data, t1));

            Assert.Collection(
                data,
                e => Assert.Same(t1, e),
                e => Assert.Same(t2, e));
        }

        [Fact]
        public void TwoElementInSequenceTest()
        {
            var particle = new CompositeParticle.Builder(ParticleType.Sequence, 0, 1)
            {
                new ElementParticle(new T1().QName, 0, 1),
                new ElementParticle(new T2().QName, 0, 1),
            }.Compile();
            var data = new TestOpenXmlCompositeElement();

            var t1 = new T1();
            var t2 = new T2();

            Assert.True(particle.Set(data, t2));
            Assert.True(particle.Set(data, t1));

            Assert.Collection(
                data,
                e => Assert.Same(t1, e),
                e => Assert.Same(t2, e));
        }

        [Fact]
        public void TwoElementInAll()
        {
            var particle = new CompositeParticle.Builder(ParticleType.All, 0, 1)
            {
                new ElementParticle(new T1().QName, 0, 1),
                new ElementParticle(new T2().QName, 0, 1),
            }.Compile();
            var data = new TestOpenXmlCompositeElement();

            var t1 = new T1();
            var t2 = new T2();

            Assert.True(particle.Set(data, t1));
            Assert.True(particle.Set(data, t2));

            Assert.Collection(
                data,
                e => Assert.Same(t1, e),
                e => Assert.Same(t2, e));
        }

        [Fact]
        public void ElementInAllList()
        {
            var particle = new CompositeParticle.Builder(ParticleType.All, 0, 1)
            {
                new ElementParticle(new T1().QName, 0, 1),
                new ElementParticle(new T2().QName, 0, 1),
            }.Compile();
            var data = new TestOpenXmlCompositeElement();

            var t1a = new T1();
            var t1b = new T1();
            var t1c = new T1();
            var t2 = new T2();

            data.PrependChild(t1a);
            data.PrependChild(t1b);
            data.PrependChild(t2);
            data.PrependChild(t1c);

            Assert.Collection(
                particle.GetCollection(t1a.QName, data),
                e => Assert.Same(t1c, e),
                e => Assert.Same(t1b, e),
                e => Assert.Same(t1a, e));
        }

        [Fact]
        public void CollectionInAll()
        {
            var particle = new CompositeParticle.Builder(ParticleType.All, 0, 1)
            {
                new ElementParticle(new T1().QName, 0, 1),
                new ElementParticle(new T2().QName, 0, 10),
                new ElementParticle(new T3().QName, 0, 1),
            }.Compile();
            var data = new TestOpenXmlCompositeElement();

            var t1 = new T1();
            var t2a = new T2();
            var t2b = new T2();
            var t2c = new T2();

            Assert.True(particle.Set(data, t1));
            Assert.Collection(
                data,
                e => Assert.Same(t1, e));

            Assert.True(particle.Set(data, t2a));
            Assert.Collection(
                data,
                e => Assert.Same(t1, e),
                e => Assert.Same(t2a, e));

            Assert.True(particle.Set(data, t2b));
            Assert.Collection(
                data,
                e => Assert.Same(t1, e),
                e => Assert.Same(t2b, e));

            Assert.True(particle.GetCollection(t2a.QName, data).Add(t2c));
            Assert.Collection(
                data,
                e => Assert.Same(t1, e),
                e => Assert.Same(t2b, e),
                e => Assert.Same(t2c, e));

            Assert.True(particle.Set(data, t2a));
            Assert.Collection(
                data,
                e => Assert.Same(t1, e),
                e => Assert.Same(t2a, e));
        }

        [Fact]
        public void TwoElementInAllBackwards()
        {
            var particle = new CompositeParticle.Builder(ParticleType.All, 0, 1)
            {
                new ElementParticle(new T1().QName, 0, 1),
                new ElementParticle(new T2().QName, 0, 1),
            }.Compile();
            var data = new TestOpenXmlCompositeElement();

            var t1 = new T1();
            var t2 = new T2();

            Assert.True(particle.Set(data, t2));
            Assert.True(particle.Set(data, t1));

            Assert.Collection(
                data,
                e => Assert.Same(t2, e),
                e => Assert.Same(t1, e));
        }

        [Fact]
        public void TwoElementOneCollectionInSequenceTest()
        {
            var particle = new CompositeParticle.Builder(ParticleType.Sequence, 0, 1)
            {
                new ElementParticle(new T1().QName, 0, 1),
                new ElementParticle(new T2().QName, 1, 10),
                new ElementParticle(new T3().QName, 0, 1),
            }.Compile();
            var data = new TestOpenXmlCompositeElement();

            var t1 = new T1();
            var t2a = new T2();
            var t2b = new T2();
            var t3 = new T3();

            Assert.True(particle.Set(data, t3));
            Assert.True(particle.GetCollection(t2a.QName, data).Add(t2a));
            Assert.True(particle.Set(data, t1));
            Assert.True(particle.GetCollection(t2a.QName, data).Add(t2b));

            Assert.Collection(
                data,
                e => Assert.Same(t1, e),
                e => Assert.Same(t2a, e),
                e => Assert.Same(t2b, e),
                e => Assert.Same(t3, e));
        }

        [Fact]
        public void InvalidElementInSequenceTest()
        {
            var t1 = new T1();
            var t2 = new T2();
            var particle = new CompositeParticle.Builder(ParticleType.Sequence, 0, 1)
            {
                new ElementParticle(t1.QName, 0, 1),
            }.Compile();
            var data = new TestOpenXmlCompositeElement();

            Assert.False(particle.Set(data, t2));
            Assert.Null(particle.Get(data, t2.QName));
        }

        [Fact]
        public void ElementCollectionTest()
        {
            var particle = new CompositeParticle.Builder(ParticleType.Sequence, 0, 1)
            {
                new ElementParticle(new T1().QName, 0, 10),
            }.Compile();
            var data = new TestOpenXmlCompositeElement();
            var instance = new T1();

            Assert.True(particle.GetCollection(instance.QName, data).Add(instance));
            var single = Assert.Single(particle.GetCollection(instance.QName, data));
            Assert.Equal(instance, single);
        }

        [Fact]
        public void SingleChoice()
        {
            var particle = new CompositeParticle.Builder(ParticleType.Choice, 0, 1)
            {
                new ElementParticle(new T1().QName, 0, 1),
            }.Compile();
            var data = new TestOpenXmlCompositeElement();

            var t1 = new T1();

            Assert.True(particle.Set(data, t1));

            var single = Assert.Single(data);

            Assert.Same(t1, single);
        }

        [Fact]
        public void DoubleChoice()
        {
            var particle = new CompositeParticle.Builder(ParticleType.Choice, 0, 1)
            {
                new ElementParticle(new T1().QName, 0, 1),
                new ElementParticle(new T2().QName, 0, 1),
            }.Compile();
            var data = new TestOpenXmlCompositeElement();

            var t1 = new T1();
            var t2 = new T2();

            Assert.True(particle.Set(data, t1));
            Assert.True(particle.Set(data, t2));

            var single = Assert.Single(data);

            Assert.Same(t2, single);
        }

        [Fact]
        public void SequenceInChoice()
        {
            var particle = new CompositeParticle.Builder(ParticleType.Choice, 0, 1)
            {
                new ElementParticle(new T1().QName, 0, 1),
                new CompositeParticle.Builder(ParticleType.Sequence, 0, 1)
                {
                    new ElementParticle(new T2().QName, 0, 1),
                    new ElementParticle(new T3().QName, 0, 1),
                },
                new ElementParticle(new T4().QName, 0, 1),
            }.Compile();
            var data = new TestOpenXmlCompositeElement();

            var t1 = new T1();
            var t2 = new T2();
            var t3 = new T3();
            var t4 = new T4();

            Assert.True(particle.Set(data, t1));
            Assert.Collection(
                data,
                e => Assert.Same(t1, e));

            Assert.True(particle.Set(data, t2));
            Assert.Collection(
                data,
                e => Assert.Same(t2, e));

            Assert.True(particle.Set(data, t3));
            Assert.Collection(
                data,
                e => Assert.Same(t2, e),
                e => Assert.Same(t3, e));

            Assert.True(particle.Set(data, t4));
            Assert.Collection(
                data,
                e => Assert.Same(t4, e));

            Assert.True(particle.Set(data, t3));
            Assert.Equal(new object[] { t3 }, data.ToArray());
            Assert.Collection(
                data,
                e => Assert.Same(t3, e));

            Assert.True(particle.Set(data, t2));
            Assert.Collection(
                data,
                e => Assert.Same(t2, e),
                e => Assert.Same(t3, e));
        }

        [Fact]
        public void TwoSequencesInChoice()
        {
            var particle = new CompositeParticle.Builder(ParticleType.Choice, 0, 1)
            {
                new ElementParticle(new T1().QName, 0, 1),
                new CompositeParticle.Builder(ParticleType.Sequence, 0, 1)
                {
                    new ElementParticle(new T2().QName, 0, 1),
                    new ElementParticle(new T3().QName, 0, 1),
                },
                new ElementParticle(new T4().QName, 0, 1),
                new CompositeParticle.Builder(ParticleType.Sequence, 0, 1)
                {
                    new ElementParticle(new T5().QName, 0, 1),
                    new ElementParticle(new T6().QName, 0, 1),
                },
            }.Compile();
            var data = new TestOpenXmlCompositeElement();

            var t1 = new T1();
            var t2 = new T2();
            var t3 = new T3();
            var t4 = new T4();
            var t5 = new T5();
            var t6 = new T6();

            Assert.True(particle.Set(data, t1));
            Assert.Collection(
                data,
                e => Assert.Same(t1, e));

            Assert.True(particle.Set(data, t2));
            Assert.Collection(
                data,
                e => Assert.Same(t2, e));

            Assert.True(particle.Set(data, t3));
            Assert.Collection(
                data,
                e => Assert.Same(t2, e),
                e => Assert.Same(t3, e));

            Assert.True(particle.Set(data, t4));
            Assert.Collection(
                data,
                e => Assert.Same(t4, e));

            Assert.True(particle.Set(data, t5));
            Assert.Collection(
                data,
                e => Assert.Same(t5, e));

            Assert.True(particle.Set(data, t6));
            Assert.Collection(
                data,
                e => Assert.Same(t5, e),
                e => Assert.Same(t6, e));

            Assert.True(particle.Set(data, t3));
            Assert.Collection(
                data,
                e => Assert.Same(t3, e));

            Assert.True(particle.Set(data, t2));
            Assert.Collection(
                data,
                e => Assert.Same(t2, e),
                e => Assert.Same(t3, e));
        }

        private class T1() : TestOpenXmlElement("name1", "ns1")
        {
        }

        private class T2() : TestOpenXmlElement("name2", "ns2")
        {
        }

        private class T3() : TestOpenXmlElement("name3", "ns3")
        {
        }

        private class T4() : TestOpenXmlElement("name4", "ns4")
        {
        }

        private class T5() : TestOpenXmlElement("name5", "ns5")
        {
        }

        private class T6() : TestOpenXmlElement("name6", "ns6")
        {
        }

        private abstract class TestOpenXmlElement(string name, string ns) : OpenXmlElement
        {
            public override string LocalName => name;

            public override string NamespaceUri => ns;

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
