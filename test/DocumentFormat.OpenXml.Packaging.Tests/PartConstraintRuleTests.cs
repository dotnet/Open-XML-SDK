// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Xunit;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Tests
{
    public class PartConstraintRuleTests
    {
        private readonly ITestOutputHelper _output;

        private static readonly HashSet<Type> _abstractOpenXmlParts = new HashSet<Type>
        {
            typeof(OpenXmlPart),
            typeof(ExtendedPart),
            typeof(StylesPart),
            typeof(CustomUIPart)
        };

        public PartConstraintRuleTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void AllExpectedParts()
        {
            var actual = typeof(OpenXmlPart)
                .Assembly
                .DefinedTypes
                .Where(typeof(OpenXmlPart).IsAssignableFrom)
                .Select(GetName)
                .OrderBy(v => v, StringComparer.Ordinal)
                .ToList();

            var expected = _cachedConstraintData.Value
                .Select(v => v.Key)
                .Concat(_abstractOpenXmlParts.Select(GetName))
                .OrderBy(v => v, StringComparer.Ordinal)
                .ToList();

            Assert.Equal(expected, actual, StringComparer.Ordinal);
        }

        [MemberData(nameof(GetOpenXmlParts))]
        [Theory]
        public void ValidatePart(OpenXmlPart part)
        {
            var data = GetConstraintData(part);

            Assert.Same(part.GetPartConstraint(), part.GetPartConstraint());
            Assert.Same(part.GetDataPartReferenceConstraint(), part.GetDataPartReferenceConstraint());

            Assert.Equal(data.IsContentTypeFixed, part.IsContentTypeFixed);
            Assert.Equal(data.RelationshipType, part.RelationshipType);
            Assert.Equal(data.TargetFileExtension, part.TargetFileExtension);
            Assert.Equal(data.TargetName, part.TargetName);
            Assert.Equal(data.TargetPath, part.TargetPath);

            if (part.IsContentTypeFixed)
            {
                Assert.Equal(data.ContentType, part.ContentType);
            }

            AssertDictionary(data.DataParts, part.GetDataPartReferenceConstraint());
            AssertDictionary(data.Parts, part.GetPartConstraint());
        }

        [MemberData(nameof(GetOpenXmlParts))]
        [Theory]
        public void ValidateValid(OpenXmlPart part)
        {
            var availability = part.GetType().GetCustomAttribute<OfficeAvailabilityAttribute>().OfficeVersion; 
            var versions = Enum.GetValues(typeof(FileFormatVersions))
                .Cast<FileFormatVersions>()
                .Where(v => v != FileFormatVersions.None);

            foreach (var version in versions)
            {
                Assert.Equal(version.AtLeast(availability), part.IsInVersion(version));
            }
        }

        [Fact]
        public void ExportData()
        {
            var result = GetParts()
                .Select(t => new ConstraintData
                {
                    Name = GetName(t.GetType()),
                    DataParts = t.GetDataPartReferenceConstraint(),
                    Parts = t.GetPartConstraint(),
                    ContentType = t.IsContentTypeFixed ? t.ContentType : null,
                    IsContentTypeFixed = t.IsContentTypeFixed,
                    RelationshipType = t.RelationshipType,
                    TargetFileExtension = t.TargetFileExtension,
                    TargetName = t.TargetName,
                    TargetPath = t.TargetPath
                })
                .OrderBy(d => d.Name, StringComparer.Ordinal);

            var data = JsonConvert.SerializeObject(result, Formatting.Indented);
            _output.WriteLine(data);
        }

        public static IEnumerable<object[]> GetOpenXmlParts() => GetParts().Select(p => new[] { p });

        private static IEnumerable<OpenXmlPart> GetParts()
        {
            return typeof(OpenXmlPart)
                .Assembly
                .GetTypes()
                .Where(typeof(OpenXmlPart).IsAssignableFrom)
                .Where(a => !_abstractOpenXmlParts.Contains(a))
                .Select(a => (OpenXmlPart)Activator.CreateInstance(a, true));
        }

        private static string GetName(Type type) => type.FullName;

        private static ConstraintData GetConstraintData(OpenXmlPart part) => _cachedConstraintData.Value[GetName(part.GetType())];

        private static Lazy<Dictionary<string, ConstraintData>> _cachedConstraintData = new Lazy<Dictionary<string, ConstraintData>>(() =>
        {
            var names = typeof(PartConstraintRuleTests).Assembly.GetManifestResourceNames();

            using (var stream = typeof(PartConstraintRuleTests).Assembly.GetManifestResourceStream("DocumentFormat.OpenXml.Packaging.Tests.data.PartConstraintData.json"))
            using (var reader = new StreamReader(stream))
            {
                return JsonConvert.DeserializeObject<ConstraintData[]>(reader.ReadToEnd())
                    .ToDictionary(t => t.Name, StringComparer.Ordinal);
            }
        });

        private struct ConstraintData
        {
            public string Name { get; set; }

            public string ContentType { get; set; }

            public bool IsContentTypeFixed { get; set; }

            public string RelationshipType { get; set; }

            public string TargetFileExtension { get; set; }

            public string TargetName { get; set; }

            public string TargetPath { get; set; }

            public IDictionary<string, PartConstraintRule> DataParts { get; set; }

            public IDictionary<string, PartConstraintRule> Parts { get; set; }
        }

        private void AssertDictionary(IDictionary<string, PartConstraintRule> expected, IDictionary<string, PartConstraintRule> actual)
        {
            Assert.Equal(expected.Count, actual.Count);

            foreach (var key in expected.Keys)
            {
                Assert.Equal(expected[key], actual[key]);
            }
        }
    }
}
