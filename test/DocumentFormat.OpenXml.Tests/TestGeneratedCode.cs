// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.IO;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    public class GenCode01
    {
        [Fact]
        public void G001()
        {
            using (var stream = new MemoryStream())
            {
                var gc = new GeneratedClass001();
                gc.CreatePackage(stream);
            }
        }

        [Fact]
        public void G002()
        {
            using (var stream = new MemoryStream())
            {
                var gc = new GeneratedClass002();
                gc.CreatePackage(stream);
            }
        }

        [Fact]
        public void G003()
        {
            using (var stream = new MemoryStream())
            {
                var gc = new GeneratedClass003();
                gc.CreatePackage(stream);
            }
        }
    }
}
