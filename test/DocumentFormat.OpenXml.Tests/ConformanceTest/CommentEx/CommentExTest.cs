// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Tests.CommentExClass;
using DocumentFormat.OpenXml.Validation;
using System.IO;
using Xunit;

using static DocumentFormat.OpenXml.Tests.TestAssets;

namespace DocumentFormat.OpenXml.Tests.CommentEx
{
    public class CommentExTest
    {
        /// <summary>
        /// Office15TCM: xxxxx: OASys#283293: OOXML SDK : COMPS : Invalid format on CommentEx
        /// </summary>
        [Fact]
        public void CommentExInvalidFormat()
        {
            using (var stream = GetStream(TestDataStorage.O15Conformance.WD.CommentExTest.Invalid_Word15Comments))
            using (var doc = WordprocessingDocument.Open(stream, false))
            {
                var validator = new OpenXmlValidator(FileFormatVersions.Office2013);
                var validateResults = validator.Validate(doc);

                Assert.Empty(validateResults);
            }
        }

        /// <summary>
        /// Verifies the editing test correctly updates the elements
        /// </summary>
        [Fact]
        public void CommentEx02VerifyEdit()
        {
            using (var stream = new MemoryStream())
            {
                GeneratedDocument.Generate(stream);

                TestEntities.EditElements(stream);
                TestEntities.VerifyElements(stream);
            }
        }

        /// <summary>
        /// Verifies deleted Content Control
        /// </summary>
        [Fact]
        public void CommentEx04VerifyDelete()
        {
            using (var stream = new MemoryStream())
            {
                GeneratedDocument.Generate(stream);

                TestEntities.DeleteElements(stream);
                TestEntities.VerifyDeletedElements(stream);
            }
        }
    }
}
