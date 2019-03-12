// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.IO;
using System.Text;
using Xunit;

namespace DocumentFormat.OpenXml.Packaging.Tests
{
    public class OpenXmlPartReaderTests
    {
        [Fact]
        public void ThrowsNull()
        {
            Assert.Throws<ArgumentNullException>(() => new OpenXmlPartReader((OpenXmlPart)null));
            Assert.Throws<ArgumentNullException>(() => new OpenXmlPartReader((OpenXmlPart)null, true));
            Assert.Throws<ArgumentNullException>(() => new OpenXmlPartReader((Stream)null, true));
            Assert.Throws<ArgumentNullException>(() => new OpenXmlPartReader((Stream)null));
        }

        [InlineData("<?xml version='1.0' encoding='UTF-8' standalone='yes'?><root/>", "UTF-8", true)]
        [InlineData("<?xml version='1.0' encoding='UTF-32' standalone='yes'?><root/>", "UTF-32", true)]
        [InlineData("<?xml version='1.0' standalone='yes'?><root/>", null, true)]
        [InlineData("<?xml version='1.0' standalone='no'?><root/>", null, false)]
        [InlineData("<?xml version='1.0'?><root/>", null, null)]
        [InlineData("<?xml version='1.0'?>", null, null)]
        [InlineData("<root/>", null, null)]
        [Theory]
        public void ExtractsInfoFromStream(string xml, string encoding, bool? standalone)
        {
            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(xml)))
            {
                using (var partReader = new OpenXmlPartReader(stream))
                {
                    Assert.Equal(encoding, partReader.Encoding);
                    Assert.Equal(standalone, partReader.StandaloneXml);
                }

                // Ensure the part reader did not dispose the stream when it is disposed
                Assert.True(stream.CanRead);
            }
        }
    }
}
