// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NSubstitute;
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
                .Where(t => t != typeof(TypedOpenXmlPart))
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
            var expectedConstraints = GetConstraintData(part);
            var constraints = part.Features.GetRequired<IPartConstraintFeature>();

            var targets = part.Features.GetRequired<ITargetFeature>();

            Assert.Equal(expectedConstraints.IsContentTypeFixed, part.IsContentTypeFixed);
            Assert.Equal(expectedConstraints.RelationshipType, part.RelationshipType);
            Assert.Equal(expectedConstraints.TargetFileExtension, targets.Extension);
            Assert.Equal(expectedConstraints.TargetName, targets.Name);
            Assert.Equal(expectedConstraints.TargetPath, targets.Path);

            if (part.IsContentTypeFixed)
            {
                Assert.Equal(expectedConstraints.ContentType, part.ContentType);
            }

#if DEBUG
            _output.WriteObjectToTempFile("part constraints", constraints.Rules);
#endif

            Assert.Equal(
                expectedConstraints.Parts.OrderBy(p => p.RelationshipType),
                constraints.Rules.OrderBy(p => p.RelationshipType).Select(p => new PartConstraintRule2(p)));
        }

        [Fact]
        public void ExportData()
        {
            var result = GetParts()
                .Select(t =>
                {
                    var targets = t.Features.GetRequired<ITargetFeature>();

                    return new
                    {
                        Name = t.GetType().FullName,
                        ContentType = t.IsContentTypeFixed ? t.ContentType : null,
                        IsContentTypeFixed = t.IsContentTypeFixed,
                        RelationshipType = t.RelationshipType,
                        TargetFileExtension = targets.Extension,
                        TargetName = targets.Name,
                        TargetPath = targets.Path,
                        Parts = t.Features.GetRequired<IPartConstraintFeature>().Rules,
                    };
                })
                .OrderBy(d => d.Name, StringComparer.Ordinal);

            _output.WriteObjectToTempFile("typed parts", result);
        }

        public static IEnumerable<object[]> GetOpenXmlParts() => GetParts().Select(p => new[] { p });

        private static IEnumerable<OpenXmlPart> GetParts()
        {
            var appType = Substitute.For<IApplicationTypeFeature>();
            appType.Type.Returns(ApplicationType.None);

            var parts = typeof(TypedFeatures)
                .GetTypeInfo()
                .Assembly
                .GetTypes()
                .Where(t => !t.IsAbstract)
                .Where(typeof(OpenXmlPart).IsAssignableFrom)
                .Where(a => !_abstractOpenXmlParts.Contains(a))
                .Select(a => (OpenXmlPart)Activator.CreateInstance(a, true));

            foreach (var part in parts)
            {
                part.Features.Set(appType);

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

            public PartConstraintRule2[] Parts { get; set; }
        }
#pragma warning restore CA1712

        private class PartConstraintRule2
        {
            public string RelationshipType { get; set; }

            public string PartClassName { get; set; }

            public string PartContentType { get; set; }

            public bool MinOccursIsNonZero { get; set; }

            public bool MaxOccursGreatThanOne { get; set; }

            public FileFormatVersions FileFormat { get; set; }

            public PartConstraintRule2()
            {
            }

            public PartConstraintRule2(PartConstraintRule rule)
            {
                FileFormat = rule.FileFormat;
                MaxOccursGreatThanOne = rule.MaxOccursGreatThanOne;
                MinOccursIsNonZero = rule.MinOccursIsNonZero;
#pragma warning disable CS0618 // Type or member is obsolete
                PartClassName = rule.PartClassName;
#pragma warning restore CS0618 // Type or member is obsolete
                PartContentType = rule.PartContentType;
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
