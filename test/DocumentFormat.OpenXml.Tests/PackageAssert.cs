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
            Validate(first, second);
        }

        /// <summary>
        /// Asserts that two OpenXmlPackage instances do not have the same content.
        /// </summary>
        /// <param name="first">The first OpenXmlPackage</param>
        /// <param name="second">The second OpenXmlPackage</param>
        public static void NotEqual(OpenXmlPackage first, OpenXmlPackage second)
        {
            Assert.Throws<Xunit.Sdk.EqualException>(() => Validate(first, second));
        }

        private static void Validate(OpenXmlPackage first, OpenXmlPackage second)
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

            foreach (var (f, s) in combined)
            {
                Assert.Equal(f.GetType(), s.GetType());

                if (IsXml(f))
                {
                    Assert.Equal(f.GetXmlString(), s.GetXmlString());
                }
                else
                {
                    using (var firstStream = f.GetStream())
                    using (var secondStream = s.GetStream())
                    {
                        Assert.Equal(GetBytes(firstStream), GetBytes(secondStream));
                    }
                }
            }
        }
    }
}
