// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.IO;
using Xunit;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    public class RestrictionsSerializationTests
    {
        [InlineData(FileFormatVersions.Office2007)]
        [InlineData(FileFormatVersions.Office2010)]
        [InlineData(FileFormatVersions.Office2013)]
        [Theory]
        public void RoundtripRestrictions(FileFormatVersions fileFormat)
        {
            byte[] Roundtrip()
            {
                using (var stream = SdbSchemaData.GetStream(fileFormat, SdbSchemaData.SimpleTypes))
                {
                    var restrictions = SimpleTypeRestrictions.Deserialize(stream, fileFormat);

                    using (var ms = new MemoryStream())
                    {
                        restrictions.Serialize(ms);
                        return ms.ToArray();
                    }
                }
            }

            byte[] GetStream()
            {
                using (var stream = SdbSchemaData.GetStream(fileFormat, SdbSchemaData.SimpleTypes))
                using (var ms = new MemoryStream())
                {
                    stream.CopyTo(ms);
                    return ms.ToArray();
                }
            }

            var expected = GetStream();
            var actual = Roundtrip();

            Assert.Equal(expected.Length, actual.Length);
            Assert.Equal(expected, actual);
        }
    }
}
