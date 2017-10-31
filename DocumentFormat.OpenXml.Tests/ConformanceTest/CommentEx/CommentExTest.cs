// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Tests.CommentExClass;
using DocumentFormat.OpenXml.Tests.TaskLibraries;
using DocumentFormat.OpenXml.Validation;
using OxTest;
using System;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Tests.CommentEx
{
    public class CommentExTest : OpenXmlTestBase
    {
        private readonly string generatedDocumentFilePath = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx");
        private readonly string editedDocumentFilePath = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx");
        private readonly string deleteDocumentFilePath = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx");

        /// <summary>
        /// Constructor
        /// </summary>
        public CommentExTest(ITestOutputHelper output)
            : base(output)
        {
            string createFilePath = this.GetTestFilePath(this.generatedDocumentFilePath);
            GeneratedDocument generatedDocument = new GeneratedDocument();
            generatedDocument.CreatePackage(createFilePath);

            this.Log.Pass("Create Word file. File path=[{0}]", createFilePath);
        }

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
            string originalFilepath = this.GetTestFilePath(this.generatedDocumentFilePath);
            string editFilePath = this.GetTestFilePath(this.editedDocumentFilePath);

            System.IO.File.Copy(originalFilepath, editFilePath, true);

            TestEntities testEntities = new TestEntities();
            testEntities.EditElements(editFilePath, this.Log);
            testEntities.VerifyElements(editFilePath, this.Log);
        }

        /// <summary>
        /// Verifies deleted Content Control
        /// </summary>
        [Fact]
        public void CommentEx04VerifyDelete()
        {
            string originalFilepath = this.GetTestFilePath(this.generatedDocumentFilePath);
            string deleteFilePath = this.GetTestFilePath(this.deleteDocumentFilePath);

            System.IO.File.Copy(originalFilepath, deleteFilePath, true);

            TestEntities testEntities = new TestEntities();
            testEntities.DeleteElements(deleteFilePath, this.Log);
            testEntities.VerifyDeletedElements(deleteFilePath, this.Log);
        }
    }
}
