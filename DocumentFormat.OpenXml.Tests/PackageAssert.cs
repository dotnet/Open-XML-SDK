// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using System;
using System.IO;
using System.Linq;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    public static class PackageAssert
    {
        /// <summary>
        /// Asserts that two OpenXmlPackage instances have the same content.
        /// </summary>
        /// <param name="first">The first OpenXmlPackage</param>
        /// <param name="second">The second OpenXmlPackage</param>
        public static void Equal(OpenXmlPackage first, OpenXmlPackage second)
        {
            bool IsXml(OpenXmlPart part) => part.ContentType.EndsWith("xml", StringComparison.OrdinalIgnoreCase);

            byte[] GetBytes(Stream stream)
            {
                using (var ms = new MemoryStream())
                {
                    stream.CopyTo(ms);

                    return ms.ToArray();
                }
            }

            Assert.Equal(first.GetAllParts().Count(), second.GetAllParts().Count());

            var combined = first.GetAllParts().Zip(second.GetAllParts(), (f, s) => (f, s));

            foreach (var item in combined)
            {
                Assert.Equal(item.f.GetType(), item.s.GetType());

                if (IsXml(item.f))
                {
                    Assert.Equal(item.f.GetXmlString(), item.s.GetXmlString());
                }
                else
                {
                    using (var firstStream = item.f.GetStream())
                    using (var secondStream = item.s.GetStream())
                    {
                        Assert.Equal(GetBytes(firstStream), GetBytes(secondStream));
                    }
                }
            }
        }
    }
}
