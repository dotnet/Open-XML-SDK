// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using Xunit;

namespace DocumentFormat.OpenXml.Framework.Tests
{
    public class OpenXmlSchemaTypeTests
    {
        private const string W = "http://schemas.openxmlformats.org/wordprocessingml/2006/main";

        private static OpenXmlSchemaType Create(string ns, string name, string type)
            => new(new OpenXmlQualifiedName(ns, name), new OpenXmlQualifiedName(ns, type));

        [Fact]
        public void EqualWhenNameAndTypeAreEqual()
        {
            // Separate string instances: equality must not depend on reference equality.
            var a = Create(W, "pPr", "CT_PPr");
            var b = Create(new string(W.ToCharArray()), new string("pPr".ToCharArray()), new string("CT_PPr".ToCharArray()));

            Assert.True(a.Equals(b));
            Assert.True(a == b);
            Assert.False(a != b);
            Assert.True(a.Equals((object)b));
            Assert.Equal(a.GetHashCode(), b.GetHashCode());
        }

        [Theory]
        [InlineData(W, "r", "CT_PPr")]
        [InlineData(W, "pPr", "CT_R")]
        [InlineData("http://schemas.openxmlformats.org/drawingml/2006/main", "pPr", "CT_PPr")]
        public void NotEqualWhenAnyPartDiffers(string ns, string name, string type)
        {
            var a = Create(W, "pPr", "CT_PPr");
            var b = Create(ns, name, type);

            Assert.False(a.Equals(b));
            Assert.False(a == b);
            Assert.True(a != b);
        }

#if NET
        [Fact]
        public void EqualsDoesNotAllocate()
        {
            var a = Create(W, "pPr", "CT_PPr");
            var b = Create(W, "pPr", "CT_PPr");
            var c = Create(W, "r", "CT_R");

            // Warm up (JIT) before measuring.
            _ = a == b;
            _ = a == c;

            var before = GC.GetAllocatedBytesForCurrentThread();
            var equal = 0;

            for (var i = 0; i < 1000; i++)
            {
                if (a == b)
                {
                    equal++;
                }

                if (a == c)
                {
                    equal++;
                }
            }

            var allocated = GC.GetAllocatedBytesForCurrentThread() - before;

            Assert.Equal(1000, equal);
            Assert.Equal(0, allocated);
        }
#endif
    }
}
