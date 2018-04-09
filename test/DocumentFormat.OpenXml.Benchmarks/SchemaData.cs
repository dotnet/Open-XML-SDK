// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using BenchmarkDotNet.Attributes;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace DocumentFormat.OpenXml.Benchmarks
{
    public partial class Tests
    {
        private List<OpenXmlElement> _types;
        private FileFormatVersions _version;

        private static readonly HashSet<Type> _excludedTypes = new HashSet<Type>
        {
            typeof(OpenXmlUnknownElement),
            typeof(OpenXmlMiscNode),
            typeof(AlternateContent),
            typeof(AlternateContentChoice),
            typeof(AlternateContentFallback),
        };

        public void SetupSchemaData()
        {
            _types = typeof(OpenXmlElement)
                .Assembly
                .GetTypes()
                .Where(typeof(OpenXmlElement).IsAssignableFrom)
                .Where(type => !type.IsAbstract && !_excludedTypes.Contains(type))
                .Select(type => Activator.CreateInstance(type, true))
                .Cast<OpenXmlElement>()
                .Where(o => o != null)
                .ToList();
            _version = (FileFormatVersions)Enum.GetValues(typeof(FileFormatVersions))
                .Cast<int>()
                .Max();
        }

        [Benchmark]
        public void LoadData()
        {
            var data = SdbSchemaData.GetSchemaData(_version);

            foreach (var type in _types)
            {
                var typeData = data.GetSchemaTypeData(type);

                Assert.NotNull(typeData);
            }
        }
    }
}
