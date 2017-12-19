// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Tests.ContentControlClass;
using DocumentFormat.OpenXml.Tests.TaskLibraries;
using OxTest;
using System;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Tests.ContentControl
{
    /// <summary>
    /// Tests for Content Controls
    /// </summary>
    public class ContentControlTest : OpenXmlTestBase
    {
        private readonly string generatedDocumentFilePath = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx");
        private readonly string editedDocumentFilePath = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx");
        private readonly string deletedDocumentFilePath = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx");

        /// <summary>
        /// Constructor
        /// </summary>
        public ContentControlTest(ITestOutputHelper output)
            : base(output)
        {
            string createFilePath = this.GetTestFilePath(this.generatedDocumentFilePath);
            GeneratedDocument generatedDocument = new GeneratedDocument();
            generatedDocument.CreatePackage(createFilePath);

            this.Log.Pass("Create Word file. File path=[{0}]", createFilePath);
        }

        /// <summary>
        /// Element editing test for "Content Control"
        /// </summary>
        [Fact]
        public void ContentControl01EditElement()
        {
            string originalFilepath = this.GetTestFilePath(this.generatedDocumentFilePath);
            string editFilePath = this.GetTestFilePath(this.editedDocumentFilePath);

            System.IO.File.Copy(originalFilepath, editFilePath, true);

            EditElement.EditContentControlElements(editFilePath, this.Log);
            VerifyElement.VerifyContentControlElement(editFilePath, this.Log);
        }

        /// <summary>
        /// Deleting all sdt elements
        /// </summary>
        [Fact]
        public void ContentControl03DeleteElement()
        {
            string originalFilepath = this.GetTestFilePath(this.generatedDocumentFilePath);
            string deleteFilePath = this.GetTestFilePath(this.deletedDocumentFilePath);

            System.IO.File.Copy(originalFilepath, deleteFilePath, true);

            //Deleting all "sdt" elements
            DeleteElement.DeleteContentControlElements(deleteFilePath, this.Log);
            int sdtElementNum = VerifyDeletedElement.DeletedElementVerify(deleteFilePath, this.Log);
        }
    }
}
