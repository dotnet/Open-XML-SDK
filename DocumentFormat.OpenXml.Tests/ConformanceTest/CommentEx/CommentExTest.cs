// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Tests.CommentEx
{
    using DocumentFormat.OpenXml;
    using DocumentFormat.OpenXml.Validation;
    using DocumentFormat.OpenXml.Packaging;
    using DocumentFormat.OpenXml.Presentation;
    using DocumentFormat.OpenXml.Spreadsheet;
    using DocumentFormat.OpenXml.Wordprocessing;

    using Xunit;
    using DocumentFormat.OpenXml.Tests.TaskLibraries;
    using DocumentFormat.OpenXml.Tests.TaskLibraries.DataStorage;
    using DocumentFormat.OpenXml.Tests.CommentExClass;
    using OxTest;
    using Xunit.Abstractions;

    /// <summary>
    /// Test for CommentEx elements
    /// </summary>
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
            TestDataStorage dataStorage = new TestDataStorage();
            var entries = dataStorage.GetEntries(
                TestDataStorage.DataGroups.O15ConformanceWord).Where(i => i.FilePath.Contains("Invalid_Word15Comments.docx"));

            OpenXmlValidator validator = new OpenXmlValidator(FileFormatVersions.Office2013);

            this.ValidateDocuments(validator, entries);
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
