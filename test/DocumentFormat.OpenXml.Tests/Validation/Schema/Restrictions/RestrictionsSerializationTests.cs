// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.IO;
using System.Text;
using Xunit;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    public class RestrictionsSerializationTests
    {
        [InlineData(FileFormatVersions.Office2007)]
        [InlineData(FileFormatVersions.Office2010)]
        [InlineData(FileFormatVersions.Office2013)]
        [Theory]
        public void FileFormatVersionIsSet(FileFormatVersions fileFormat)
        {
            var schemaData = SdbSchemaData.GetSchemaData(fileFormat);

            foreach (var type in schemaData.Restrictions.SimpleTypes)
            {
                Assert.Equal(fileFormat, type.FileFormat);
            }
        }

#if FEATURE_SCHEMA_GENERATOR
        [InlineData(FileFormatVersions.Office2007)]
        [InlineData(FileFormatVersions.Office2010)]
        [InlineData(FileFormatVersions.Office2013)]
        [Theory]
        public void RoundtripRestrictions(FileFormatVersions fileFormat)
        {
            byte[] Roundtrip()
            {
                var restrictions = SdbSchemaData.GetSchemaData(fileFormat).Restrictions;

                using (var ms = new MemoryStream())
                {
                    restrictions.Serialize(ms);
                    return ms.ToArray();
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

            var expected = GetNormalizedString(GetStream());
            var actual = GetNormalizedString(Roundtrip());

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Gets string from <paramref name="bytes"/> and normalize line endings as the embedded resource
        /// may be retrieved from source control with different endings and we want to compare just the
        /// contents themselves irrespective of line endings.
        /// </summary>
        private static string GetNormalizedString(byte[] bytes)
        {
            var sb = new StringBuilder();

            using (var ms = new MemoryStream(bytes))
            using (var reader = new StreamReader(ms, Encoding.UTF8))
            {
                while (!reader.EndOfStream)
                {
                    sb.AppendLine(reader.ReadLine());
                }
            }

            return sb.ToString();
        }
#endif
    }
}
