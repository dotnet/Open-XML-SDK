// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using BenchmarkDotNet.Attributes;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xunit;

namespace DocumentFormat.OpenXml.Benchmarks
{
    public class SchemaData
    {
        private List<OpenXmlElement> _types;

        [ParamsSource(nameof(AllVersions))]
        public FileFormatVersions Version { get; set; }

        public IEnumerable<FileFormatVersions> AllVersions => Enum.GetValues(typeof(FileFormatVersions)).Cast<FileFormatVersions>().Where(f => f != FileFormatVersions.None);

        private static readonly HashSet<Type> _excludedTypes = new HashSet<Type>
        {
            typeof(OpenXmlUnknownElement),
            typeof(OpenXmlMiscNode),
            typeof(AlternateContent),
            typeof(AlternateContentChoice),
            typeof(AlternateContentFallback),
        };

        [GlobalSetup]
        public void SetupSchemaData()
        {
            _types = typeof(OpenXmlElement)
                .GetTypeInfo()
                .Assembly
                .GetTypes()
                .Where(t => typeof(OpenXmlElement).IsAssignableFrom(t))
                .Where(type => !type.GetTypeInfo().IsAbstract && !_excludedTypes.Contains(type))
                .Select(type => Activator.CreateInstance(type, true))
                .Cast<OpenXmlElement>()
                .Where(o => o != null)
                .Where(o=>o.IsInVersion(Version))
                .ToList();
        }

        [Benchmark]
        public void LoadData()
        {
            var data = SdbSchemaData.GetSchemaData(Version);

            foreach (var type in _types)
            {
                var typeData = data.GetSchemaTypeData(type);

                Assert.NotNull(typeData);
            }
        }
    }
}
