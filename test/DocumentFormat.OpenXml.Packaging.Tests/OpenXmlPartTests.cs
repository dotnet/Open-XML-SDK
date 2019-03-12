// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xunit;

namespace DocumentFormat.OpenXml.Packaging.Tests
{
    public class OpenXmlPartTests
    {
        [MemberData(nameof(GetTypes))]
        [Theory]
        public void AllPartsHaveRelationshipType(Type partType)
        {
            var attribute = partType.GetCustomAttribute<RelationshipTypeAttribute>();

            Assert.NotNull(attribute);
            Assert.False(string.IsNullOrEmpty(attribute.RelationshipType));
        }

        public static IEnumerable<object[]> GetTypes()
        {
            return typeof(OpenXmlPart).Assembly.GetTypes()
                .Where(t => !t.IsAbstract)
                .Where(t => t != typeof(ExtendedPart))
                .Where(t => typeof(OpenXmlPart).IsAssignableFrom(t))
                .Select(t => new object[] { t });
        }
    }
}
