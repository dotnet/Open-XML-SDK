// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Tests.TaskLibraries;
using DocumentFormat.OpenXml.Tests.WorkBookPrClass;
using OxTest;
using System;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Tests.WorkBookPr
{
    public class WorkBookPrTest : OpenXmlTestBase
    {
        private readonly string generatedDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".xlsx");
        private readonly string editedDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".xlsx");
        private readonly string deletedDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".xlsx");
        private readonly string addedDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".xlsx");
        private readonly TestEntities testEntities = null;

        /// <summary>
        /// Constructor
        /// </summary>
        public WorkBookPrTest(ITestOutputHelper output)
            : base(output)
        {
            string createFilePath = this.GetTestFilePath(this.generatedDocumentFile);
            GeneratedDocument generatedDocument = new GeneratedDocument();
            generatedDocument.CreatePackage(createFilePath);

            this.Log.Pass("Create Word file. File path=[{0}]", createFilePath);

            this.testEntities = new TestEntities(createFilePath);
        }

        /// <summary>
        /// Element editing test for workbookPr element
        /// </summary>
        [Fact]
        public void WorkBookPr01EditElement()
        {
            string originalFilepath = this.GetTestFilePath(this.generatedDocumentFile);
            string editFilePath = this.GetTestFilePath(this.editedDocumentFile);

            System.IO.File.Copy(originalFilepath, editFilePath, true);

            this.testEntities.EditElements(editFilePath, this.Log);
            this.testEntities.VerifyElements(editFilePath, this.Log);
        }

        /// <summary>
        /// Element deleting test for workbookPr element
        /// </summary>
        [Fact]
        public void WorkBookPr03DeleteElement()
        {
            string originalFilepath = this.GetTestFilePath(this.generatedDocumentFile);
            string deleteFilePath = this.GetTestFilePath(this.deletedDocumentFile);
            string addFilePath = this.GetTestFilePath(this.addedDocumentFile);

            System.IO.File.Copy(originalFilepath, deleteFilePath, true);

            this.testEntities.DeleteElements(deleteFilePath, this.Log);
            this.testEntities.VerifyDeleteElements(deleteFilePath, this.Log);

            System.IO.File.Copy(deleteFilePath, addFilePath, true);

            this.testEntities.AddElement(addFilePath, this.Log);
            this.testEntities.VerifyAddElements(addFilePath, this.Log);
        }
    }
}
