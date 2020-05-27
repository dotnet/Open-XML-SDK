﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework.Metadata;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Xunit;
using Xunit.Abstractions;

using static DocumentFormat.OpenXml.Framework.Tests.TestUtility;

namespace DocumentFormat.OpenXml.Framework.Tests
{
    public class ElementLookupTests
    {
        private readonly ITestOutputHelper _output;

        public ElementLookupTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void BuiltInOpenXmlElements()
        {
            var elements = GetBuiltIn();
#if DEBUG
            var tmp = Path.GetTempFileName();

            _output.WriteLine($"Wrote to temp path {tmp}");

            File.WriteAllText(tmp, JsonConvert.SerializeObject(elements, Newtonsoft.Json.Formatting.Indented, new StringEnumConverter()));
#endif
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
                .OrderBy(type => type.FullName, StringComparer.Ordinal)
                .Select(type => new LookupData(type));
        }

        private class LookupData : IEquatable<LookupData>
        {
            public LookupData()
            {
            }

            public LookupData(Type type)
            {
                Element = type.FullName;

                ElementLookup GetLookup()
                {
                    if (typeof(OpenXmlPartRootElement) == type)
                    {
                        return ElementLookup.Parts;
                    }
                    else if (type.GetConstructor(Cached.Array<Type>()) != null)
                    {
                        var instance = (OpenXmlElement)Activator.CreateInstance(type);
                        return instance.Metadata.Children;
                    }
                    else
                    {
                        return ElementLookup.Empty;
                    }
                }

                Children = GetLookup().Elements.Select(t => new ChildData
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

                if (!string.Equals(Element, other.Element, StringComparison.Ordinal) || !Children.SequenceEqual(other.Children))
                {
                    System.Diagnostics.Debugger.Break();
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
    }
}
