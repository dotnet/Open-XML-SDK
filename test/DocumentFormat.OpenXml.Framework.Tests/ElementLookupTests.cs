// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Xml;
using Xunit;

namespace DocumentFormat.OpenXml.Framework.Tests
{
    public class ElementLookupTests
    {
        private const byte Namespace1 = 1;
        private const byte Namespace2 = 2;
        private const byte Namespace3 = 3;

        private const string Name1 = "Name1";
        private const string Name2 = "Name1";
        private const string Name3 = "Name1";

        [Fact]
        public void NoProperties()
        {
            var lookup = CreateLookup<NoPropertiesTest>();

            Assert.Equal(0, lookup.Count);
            Assert.Null(lookup.Create(Namespace1, Name1));
            Assert.Null(lookup.Create(Namespace2, Name2));
            Assert.Null(lookup.Create(Namespace3, Name3));
        }

        [Fact]
        public void SingleProperty()
        {
            var lookup = CreateLookup<OnePropertyTest>();

            Assert.Equal(1, lookup.Count);
            Assert.IsType<Element1>(lookup.Create(Namespace1, Name1));
            Assert.Null(lookup.Create(Namespace2, Name2));
            Assert.Null(lookup.Create(Namespace3, Name3));
        }

        [Fact]
        public void MultipleProperties()
        {
            var lookup = CreateLookup<MultiplePropertyTest>();

            Assert.Equal(3, lookup.Count);
            Assert.IsType<Element1>(lookup.Create(Namespace1, Name1));
            Assert.IsType<Element2>(lookup.Create(Namespace2, Name2));
            Assert.IsType<Element3>(lookup.Create(Namespace3, Name3));
        }

        [Fact]
        public void OpenXmlElementTypeGetsAll()
        {
            var lookup = CreateLookup(typeof(OpenXmlPartRootElement));

            Assert.Equal(84, lookup.Count);
        }

        [Fact]
        public void ElementDoesNotContainSchemaInfo()
        {
            Assert.Throws<InvalidOperationException>(() => CreateLookup<NoDataPropertyTest>());
        }

        [Fact]
        public void ElementMustDeriveFromOpenXmlElement()
        {
            Assert.Throws<InvalidOperationException>(() => CreateLookup<NotElement>());
        }

        [Fact]
        public void DerivedElements()
        {
            var lookup = CreateLookup<OnDerived>();

            Assert.Equal(3, lookup.Count);
            Assert.IsType<Element1>(lookup.Create(Namespace1, Name1));
            Assert.IsType<Element2>(lookup.Create(Namespace2, Name2));
            Assert.IsType<Element3>(lookup.Create(Namespace3, Name3));
        }

        private static ElementLookup CreateLookup<T>() => CreateLookup(typeof(T));

        private static ElementLookup CreateLookup(Type t)
        {
            return ElementLookup.CreateLookup(t, type => () => (OpenXmlElement)Activator.CreateInstance(type));
        }

#pragma warning disable CA1812
        private class NoPropertiesTest
        {
        }

        [ChildElementInfo(typeof(Element1))]
        private class OnePropertyTest
        {
            public Element1 Element { get; set; }
        }

        [ChildElementInfo(typeof(ElementNoData))]
        private class NoDataPropertyTest
        {
            public ElementNoData Element { get; set; }
        }

        [ChildElementInfo(typeof(Element1))]
        [ChildElementInfo(typeof(Element2))]
        [ChildElementInfo(typeof(Element3))]
        private class MultiplePropertyTest
        {
            public Element1 Element1 { get; set; }

            public Element2 Element2 { get; set; }

            public Element3 Element3 { get; set; }
        }

        [ChildElementInfo(typeof(NotElement))]
        [SchemaAttr(Namespace1, Name1)]
        private class NotElement
        {
        }

        private class OnDerived : MultiplePropertyTest
        {
        }

        [SchemaAttr(Namespace1, Name1)]
        private class Element1 : DerivedOpenXmlElement
        {
        }

        [SchemaAttr(Namespace2, Name2)]
        private class Element2 : DerivedOpenXmlElement
        {
        }

        [SchemaAttr(Namespace3, Name3)]
        private class Element3 : DerivedOpenXmlElement
        {
        }

        private class ElementNoData : DerivedOpenXmlElement
        {
        }

        private class DerivedOpenXmlElement : OpenXmlElement
        {
            public override bool HasChildren => throw new NotImplementedException();

            public override void RemoveAllChildren() => throw new NotImplementedException();

            internal override void WriteContentTo(XmlWriter w) => throw new NotImplementedException();

            private protected override void Populate(XmlReader xmlReader, OpenXmlLoadMode loadMode) => throw new NotImplementedException();
        }
#pragma warning restore CA1812
    }
}
