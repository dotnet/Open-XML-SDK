// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml;
using Xunit;

using static DocumentFormat.OpenXml.Framework.Tests.TestUtility;

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

        [Fact]
        public void BuiltInOpenXmlElements()
        {
            var expected = Deserialize<LookupData[]>("ElementChildren.json");
            var actual = GetBuiltIn().ToArray();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DumpBuiltInOpenXmlElements()
        {
            // This should align with the text in ElementChildren.json
            var expected = Serialize(GetBuiltIn());

            Assert.NotNull(expected);
        }

        private static IEnumerable<LookupData> GetBuiltIn()
        {
            return typeof(OpenXmlElement).GetTypeInfo().Assembly.GetTypes()
                .Where(t => !t.GetTypeInfo().IsAbstract && typeof(OpenXmlElement).GetTypeInfo().IsAssignableFrom(t))
                .Concat(new[] { typeof(OpenXmlPartRootElement) })
                .OrderBy(type => type.FullName)
                .Select(type => new LookupData(type));
        }

        private static ElementLookup CreateLookup<T>() => CreateLookup(typeof(T));

        private static ElementLookup CreateLookup(Type t)
        {
            return ElementLookup.CreateLookup(t, type => () => (OpenXmlElement)Activator.CreateInstance(type));
        }

        private class LookupData : IEquatable<LookupData>
        {
            public LookupData()
            {
            }

            public LookupData(Type type)
            {
                Element = type.FullName;
                Children = CreateLookup(type).Elements.Select(t => new ChildData
                {
                    Name = t.Name,
                    Namespace = t.Namespace,
                });
            }

            public string Element { get; set; }

            public IEnumerable<ChildData> Children { get; set; }

            public override bool Equals(object obj) => Equals(obj as LookupData);

            public bool Equals(LookupData other)
            {
                if (other == null)
                {
                    return false;
                }

                return string.Equals(Element, other.Element, StringComparison.Ordinal)
                    && Children.SequenceEqual(other.Children);
            }

            public override int GetHashCode() => throw new NotImplementedException();

            public class ChildData : IEquatable<ChildData>
            {
                public string Name { get; set; }

                public string Namespace { get; set; }

                public bool Equals(ChildData other)
                {
                    return string.Equals(Name, other.Name, StringComparison.Ordinal)
                        && string.Equals(Namespace, other.Namespace, StringComparison.Ordinal);
                }

                public override int GetHashCode() => throw new NotImplementedException();

                public override bool Equals(object obj) => Equals(obj as ChildData);
            }
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
            public NotElement Element { get; set; }
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
