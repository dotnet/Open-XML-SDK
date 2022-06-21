// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Tests.Common.OutputHelperExtensions;
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
            var fromFramework = new[] { typeof(ExtendedPart), typeof(OpenXmlPart) };
            var actual = typeof(TypedFeatures)
                .GetTypeInfo()
                .Assembly
                .DefinedTypes
                .Concat(fromFramework)
                .Distinct()
                .Where(t => typeof(OpenXmlPart).GetTypeInfo().IsAssignableFrom(t))
                .Select(t => t.FullName)
                .OrderBy(v => v, StringComparer.Ordinal)
                .ToList();

            var expected = _cachedConstraintData.Value
                .Select(v => v.Key)
                .Concat(_abstractOpenXmlParts.Select(t => t.FullName))
                .OrderBy(v => v, StringComparer.Ordinal)
                .ToList();

            var missing = expected.Except(actual);
            var added = actual.Except(expected);

            Assert.Empty(missing);
            Assert.Empty(added);
        }

        [MemberData(nameof(GetOpenXmlParts))]
        [Theory]
        public void ValidatePart(OpenXmlPart part)
        {
            var data = GetConstraintData(part);

            Assert.Same(part.GetPartMetadata().PartConstraints, part.GetPartMetadata().PartConstraints);
            Assert.Same(part.GetPartMetadata().DataPartReferenceConstraints, part.GetPartMetadata().DataPartReferenceConstraints);

            if (!part.GetPartMetadata().PartConstraints.Any())
            {
                Assert.Same(PartConstraintCollection.Instance, part.GetPartMetadata().PartConstraints);
            }

            if (!part.GetPartMetadata().DataPartReferenceConstraints.Any())
            {
                Assert.Same(PartConstraintCollection.Instance, part.GetPartMetadata().DataPartReferenceConstraints);
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

#if DEBUG
            _output.WriteObjectToTempFile("data part reference constraints", part.GetPartMetadata().DataPartReferenceConstraints);
#endif

            AssertDictionary(data.DataParts, part.GetPartMetadata().DataPartReferenceConstraints);

#if DEBUG
            _output.WriteObjectToTempFile("data parts", data.Parts);
            _output.WriteObjectToTempFile("part constraints", part.GetPartMetadata().PartConstraints);
#endif

            AssertDictionary(data.Parts, part.GetPartMetadata().PartConstraints);
        }

        [MemberData(nameof(GetOpenXmlParts))]
        [Theory]
        public void ValidateValid(OpenXmlPart part)
        {
            var availability = part.GetType().GetTypeInfo().GetCustomAttribute<OfficeAvailabilityAttribute>()?.OfficeVersion ?? FileFormatVersions.Office2007;
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
                    Name = t.GetType().FullName,
                    ContentType = t.IsContentTypeFixed ? t.ContentType : null,
                    IsContentTypeFixed = t.IsContentTypeFixed,
                    RelationshipType = t.RelationshipType,
                    TargetFileExtension = t.TargetFileExtension,
                    TargetName = t.TargetName,
                    TargetPath = t.TargetPath,
                    DataParts = t.GetPartMetadata().DataPartReferenceConstraints,
                    Parts = t.GetPartMetadata().PartConstraints,
                })
                .OrderBy(d => d.Name, StringComparer.Ordinal);

            _output.WriteObjectToTempFile("typed parts", result);
        }

        public static IEnumerable<object[]> GetOpenXmlParts() => GetParts().Select(p => new[] { p });

        private static IEnumerable<OpenXmlPart> GetParts()
        {
            var metadata = new TypedFeatures().GetRequired<IPartMetadataFeature>();
            var parts = typeof(TypedFeatures)
                .GetTypeInfo()
                .Assembly
                .GetTypes()
                .Where(typeof(OpenXmlPart).IsAssignableFrom)
                .Where(a => !_abstractOpenXmlParts.Contains(a))
                .Select(a => (OpenXmlPart)Activator.CreateInstance(a, true));

            foreach (var part in parts)
            {
                part.Features.Set(metadata);
                yield return part;
            }
        }

        private static ConstraintData GetConstraintData(OpenXmlPart part) => _cachedConstraintData.Value[part.GetType().FullName];

        private static Lazy<Dictionary<string, ConstraintData>> _cachedConstraintData = new Lazy<Dictionary<string, ConstraintData>>(() =>
        {
            var names = typeof(PartConstraintRuleTests).GetTypeInfo().Assembly.GetManifestResourceNames();

            using (var stream = typeof(PartConstraintRuleTests).GetTypeInfo().Assembly.GetManifestResourceStream("DocumentFormat.OpenXml.Packaging.Tests.data.PartConstraintData.json"))
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
#pragma warning disable CS0618 // Type or member is obsolete
                    PartClassName = rule.PartClassName,
#pragma warning restore CS0618 // Type or member is obsolete
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
                    hash = (hash * HashMultiplier) + StringComparer.Ordinal.GetHashCode(PartClassName);
                    hash = (hash * HashMultiplier) + StringComparer.Ordinal.GetHashCode(PartContentType);
                    hash = (hash * HashMultiplier) + MinOccursIsNonZero.GetHashCode();
                    hash = (hash * HashMultiplier) + MaxOccursGreatThanOne.GetHashCode();
                    hash = (hash * HashMultiplier) + FileFormat.GetHashCode();
                    return hash;
                }
            }
        }
    }
}
