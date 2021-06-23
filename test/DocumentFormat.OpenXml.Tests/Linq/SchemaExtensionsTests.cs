// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Linq;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xunit;

namespace DocumentFormat.OpenXml.Tests.Linq
{
    public class SchemaExtensionsTests
    {
        [Fact]
        public void HasSchemaInfo_ConcreteSubclassesOfOpenXmlPartRootElement_True()
        {
            List<Type> types = Assembly
                .GetAssembly(typeof(Document))!
                .GetExportedTypes()
                .Where(type => type.IsAssignableTo(typeof(OpenXmlPartRootElement)) && !type.IsAbstract)
                .ToList();

            Assert.All(types, type => Assert.True(type.HasSchemaInfo()));
        }

        [Fact]
        public void HasSchemaInfo_OpenXmlPartRootElement_False()
        {
            Assert.False(typeof(OpenXmlPartRootElement).HasSchemaInfo());
        }
    }
}
