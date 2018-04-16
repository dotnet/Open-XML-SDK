// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
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
            typeof(CustomUIPart),
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

            Assert.Same(part.PartConstraints, part.PartConstraints);
            Assert.Same(part.DataPartReferenceConstraints, part.DataPartReferenceConstraints);

            if (!part.PartConstraints.Any())
            {
                Assert.Same(PartConstraintCollection.Instance, part.PartConstraints);
            }

            if (!part.DataPartReferenceConstraints.Any())
            {
                Assert.Same(PartConstraintCollection.Instance, part.DataPartReferenceConstraints);
            }

            Assert.Equal(data.IsContentTypeFixed, part.IsContentTypeFixed);
            Assert.Equal(data.RelationshipType, part.RelationshipType);
            Assert.Equal(data.TargetFileExtension, part.TargetFileExtension);
            Assert.Equal(data.TargetName, part.TargetName);
            Assert.Equal(data.TargetPath, part.TargetPath);

            if (part.IsContentTypeFixed)
            {
                Assert.Equal(data.ContentType, part.ContentType);
            }

            AssertDictionary(data.DataParts, part.DataPartReferenceConstraints);
            AssertDictionary(data.Parts, part.PartConstraints);
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
                .Select(t => new
                {
                    Name = GetName(t.GetType()),
                    ContentType = t.IsContentTypeFixed ? t.ContentType : null,
                    IsContentTypeFixed = t.IsContentTypeFixed,
                    RelationshipType = t.RelationshipType,
                    TargetFileExtension = t.TargetFileExtension,
                    TargetName = t.TargetName,
                    TargetPath = t.TargetPath,
                    DataParts = t.DataPartReferenceConstraints,
                    Parts = t.PartConstraints,
                })
                .OrderBy(d => d.Name, StringComparer.Ordinal);

            var data = JsonConvert.SerializeObject(result, Formatting.Indented, new StringEnumConverter());
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
                return JsonConvert.DeserializeObject<ConstraintData[]>(reader.ReadToEnd(), new StringEnumConverter())
                    .ToDictionary(t => t.Name, StringComparer.Ordinal);
            }
        });

        private void AssertDictionary(IDictionary<string, PartConstraintRule2> expected, IReadOnlyDictionary<string, PartConstraintRule> actual)
        {
            Assert.Equal(expected.Count, actual.Count);

            foreach (var key in expected.Keys)
            {
                Assert.Equal(expected[key], actual[key]);
            }
        }

#pragma warning disable CA1812
        private class ConstraintData
        {
            public string Name { get; set; }

            public string ContentType { get; set; }

            public bool IsContentTypeFixed { get; set; }

            public string RelationshipType { get; set; }

            public string TargetFileExtension { get; set; }

            public string TargetName { get; set; }

            public string TargetPath { get; set; }

            public IDictionary<string, PartConstraintRule2> DataParts { get; set; }

            public IDictionary<string, PartConstraintRule2> Parts { get; set; }
        }
#pragma warning restore CA1712

        private class PartConstraintRule2
        {
            public string PartClassName { get; set; }

            public string PartContentType { get; set; }

            public bool MinOccursIsNonZero { get; set; }

            public bool MaxOccursGreatThanOne { get; set; }

            public FileFormatVersions FileFormat { get; set; }

            public static implicit operator PartConstraintRule2(PartConstraintRule rule)
            {
                return new PartConstraintRule2
                {
                    FileFormat = rule.FileFormat,
                    MaxOccursGreatThanOne = rule.MaxOccursGreatThanOne,
                    MinOccursIsNonZero = rule.MinOccursIsNonZero,
                    PartClassName = rule.PartClassName,
                    PartContentType = rule.PartContentType,
                };
            }

            public override bool Equals(object obj)
            {
                if (obj is PartConstraintRule2 other)
                {
                    return string.Equals(PartClassName, other.PartClassName, StringComparison.Ordinal)
                        && string.Equals(PartContentType, other.PartContentType, StringComparison.Ordinal)
                        && MinOccursIsNonZero == other.MinOccursIsNonZero
                        && MaxOccursGreatThanOne == other.MaxOccursGreatThanOne
                        && FileFormat == other.FileFormat;
                }

                return false;
            }

            public override int GetHashCode()
            {
                const int HashMultiplier = 31;

                unchecked
                {
                    int hash = 17;
                    hash = hash * HashMultiplier + StringComparer.Ordinal.GetHashCode(PartClassName);
                    hash = hash * HashMultiplier + StringComparer.Ordinal.GetHashCode(PartContentType);
                    hash = hash * HashMultiplier + MinOccursIsNonZero.GetHashCode();
                    hash = hash * HashMultiplier + MaxOccursGreatThanOne.GetHashCode();
                    hash = hash * HashMultiplier + FileFormat.GetHashCode();
                    return hash;
                }
            }
        }
    }
}
