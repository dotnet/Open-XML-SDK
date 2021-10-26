// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation.Schema;
using System.Linq;
using Xunit;

namespace DocumentFormat.OpenXml.Framework.Tests
{
    public class CompiledParticleTests
    {
        [Fact]
        public void InvalidElementTest()
        {
            var particle = new ElementParticle(typeof(T1), 0, 1)
                .Compile();
            var data = new TestOpenXmlCompositeElement();

            Assert.False(particle.Set(data, new T2()));
            Assert.Null(particle.Get<T2>(data));
        }

        [Fact]
        public void AllElements()
        {
            var particle = new CompositeParticle.Builder(ParticleType.Sequence, 0, 1)
            {
                new ElementParticle(typeof(T1), 0, 1),
                new ElementParticle(typeof(T2), 0, 1),
            }.Compile();
            var data = new TestOpenXmlCompositeElement();
            var t1a = new T1();
            var t1b = new T1();
            var t2a = new T2();

            data.AppendChild(t1a);
            data.AppendChild(t2a);
            data.AppendChild(t1b);

            Assert.Collection(
                particle.GetCollection<T1>(data),
                e => Assert.Same(t1a, e),
                e => Assert.Same(t1b, e));
        }

        [Fact]
        public void SequenceAdd()
        {
            var particle = new CompositeParticle.Builder(ParticleType.Sequence, 0, 1)
            {
                new ElementParticle(typeof(T1), 0, 1),
                new ElementParticle(typeof(T2), 0, 1),
                new ElementParticle(typeof(T3), 0, 1),
                new ElementParticle(typeof(T4), 0, 1),
                new ElementParticle(typeof(T5), 0, 1),
                new ElementParticle(typeof(T6), 0, 1),
            }.Compile();

            var data = new TestOpenXmlCompositeElement();
            var t1 = new T1();
            var t3 = new T3();
            var t5 = new T5();

            Assert.Empty(data);

            particle.GetCollection<T1>(data).Add(t1);
            Assert.Collection(
                data,
                e => Assert.Same(e, t1));

            particle.GetCollection<T3>(data).Add(t3);
            Assert.Collection(
                data,
                e => Assert.Same(e, t1),
                e => Assert.Same(e, t3));

            particle.GetCollection<T5>(data).Add(t5);
            Assert.Collection(
                data,
                e => Assert.Same(e, t1),
                e => Assert.Same(e, t3),
                e => Assert.Same(e, t5));
        }

        [Fact]
        public void ElementTest()
        {
            var particle = new ElementParticle(typeof(T1), 0, 1)
                .Compile();
            var data = new TestOpenXmlCompositeElement();
            var instance = new T1();

            Assert.True(particle.Set(data, instance));
            Assert.Equal(instance, particle.Get<T1>(data));
        }

        [Fact]
        public void TwoElementInSequenceTestBackwards()
        {
            var particle = new CompositeParticle.Builder(ParticleType.Sequence, 0, 1)
            {
                new ElementParticle(typeof(T1), 0, 1),
                new ElementParticle(typeof(T2), 0, 1),
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
                new ElementParticle(typeof(T1), 0, 1),
                new ElementParticle(typeof(T2), 0, 1),
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
                new ElementParticle(typeof(T1), 0, 1),
                new ElementParticle(typeof(T2), 0, 1),
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
                new ElementParticle(typeof(T1), 0, 1),
                new ElementParticle(typeof(T2), 0, 1),
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
                particle.GetCollection<T1>(data),
                e => Assert.Same(t1c, e),
                e => Assert.Same(t1b, e),
                e => Assert.Same(t1a, e));
        }

        [Fact]
        public void CollectionInAll()
        {
            var particle = new CompositeParticle.Builder(ParticleType.All, 0, 1)
            {
                new ElementParticle(typeof(T1), 0, 1),
                new ElementParticle(typeof(T2), 0, 10),
                new ElementParticle(typeof(T3), 0, 1),
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

            Assert.True(particle.GetCollection<T2>(data).Add(t2c));
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
                new ElementParticle(typeof(T1), 0, 1),
                new ElementParticle(typeof(T2), 0, 1),
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
                new ElementParticle(typeof(T1), 0, 1),
                new ElementParticle(typeof(T2), 1, 10),
                new ElementParticle(typeof(T3), 0, 1),
            }.Compile();
            var data = new TestOpenXmlCompositeElement();

            var t1 = new T1();
            var t2a = new T2();
            var t2b = new T2();
            var t3 = new T3();

            Assert.True(particle.Set(data, t3));
            Assert.True(particle.GetCollection<T2>(data).Add(t2a));
            Assert.True(particle.Set(data, t1));
            Assert.True(particle.GetCollection<T2>(data).Add(t2b));

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
            var particle = new CompositeParticle.Builder(ParticleType.Sequence, 0, 1)
            {
                new ElementParticle(typeof(T1), 0, 1),
            }.Compile();
            var data = new TestOpenXmlCompositeElement();

            Assert.False(particle.Set(data, new T2()));
            Assert.Null(particle.Get<T2>(data));
        }

        [Fact]
        public void ElementCollectionTest()
        {
            var particle = new CompositeParticle.Builder(ParticleType.Sequence, 0, 1)
            {
                new ElementParticle(typeof(T1), 0, 10),
            }.Compile();
            var data = new TestOpenXmlCompositeElement();
            var instance = new T1();

            Assert.True(particle.GetCollection<T1>(data).Add(instance));
            var single = Assert.Single(particle.GetCollection<T1>(data));
            Assert.Equal(instance, single);
        }

        [Fact]
        public void SingleChoice()
        {
            var particle = new CompositeParticle.Builder(ParticleType.Choice, 0, 1)
            {
                new ElementParticle(typeof(T1), 0, 1),
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
                new ElementParticle(typeof(T1), 0, 1),
                new ElementParticle(typeof(T2), 0, 1),
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
                new ElementParticle(typeof(T1), 0, 1),
                new CompositeParticle.Builder(ParticleType.Sequence, 0, 1)
                {
                    new ElementParticle(typeof(T2), 0, 1),
                    new ElementParticle(typeof(T3), 0, 1),
                },
                new ElementParticle(typeof(T4), 0, 1),
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
                new ElementParticle(typeof(T1), 0, 1),
                new CompositeParticle.Builder(ParticleType.Sequence, 0, 1)
                {
                    new ElementParticle(typeof(T2), 0, 1),
                    new ElementParticle(typeof(T3), 0, 1),
                },
                new ElementParticle(typeof(T4), 0, 1),
                new CompositeParticle.Builder(ParticleType.Sequence, 0, 1)
                {
                    new ElementParticle(typeof(T5), 0, 1),
                    new ElementParticle(typeof(T6), 0, 1),
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

        private class T1 : TestOpenXmlElement
        {
        }

        private class T2 : TestOpenXmlElement
        {
        }

        private class T3 : TestOpenXmlElement
        {
        }

        private class T4 : TestOpenXmlElement
        {
        }

        private class T5 : TestOpenXmlElement
        {
        }

        private class T6 : TestOpenXmlElement
        {
        }
    }
}
