// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Tests.CommentExClass;
using DocumentFormat.OpenXml.Validation;
using System.IO;
using Xunit;

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
            using (var stream = TestAssets.GetStream(TestAssets.TestDataStorage.O15Conformance.WD.CommentExTest.Invalid_Word15Comments))
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
