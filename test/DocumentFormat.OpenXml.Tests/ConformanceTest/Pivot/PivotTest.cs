// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Tests.PivotClass;
using DocumentFormat.OpenXml.Tests.TaskLibraries;
using OxTest;
using System;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Tests.Pivot
{
    public class PivotTest : OpenXmlTestBase
    {
        private ConnectionTestEntities connectionTestEntities = null;

        //private readonly string generatedOldbConnectionDocumentFile = "TestPivotOldbConnectionBase.xlsx";
        private readonly string generatedOldbConnectionDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".xlsx");

        private readonly string editedOldbConnectionDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".xlsx");
        private readonly string deletedOldbConnectionDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".xlsx");
        private readonly string addedOldbConnectionDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".xlsx");

        /// <summary>
        /// Constructor
        /// </summary>
        public PivotTest(ITestOutputHelper output)
            : base(output)
        {
            string createFilePath = this.GetTestFilePath(this.generatedOldbConnectionDocumentFile);
            ConnectionGeneratedDocument connectionGeneratedDocument = new ConnectionGeneratedDocument();
            connectionGeneratedDocument.CreatePackage(createFilePath);

            this.Log.Pass("Create Word file. File path=[{0}]", createFilePath);

            this.connectionTestEntities = new ConnectionTestEntities(createFilePath);
        }

        /// <summary>
        /// Element editing test for workbookPr element
        /// </summary>
        [Fact]
        public void PivotConnection01EditElement()
        {
            string originalFilepath = this.GetTestFilePath(this.generatedOldbConnectionDocumentFile);
            string editFilePath = this.GetTestFilePath(this.editedOldbConnectionDocumentFile);

            System.IO.File.Copy(originalFilepath, editFilePath, true);

            this.connectionTestEntities.EditElement(editFilePath, this.Log);
            this.connectionTestEntities.VerifyElement(editFilePath, this.Log);
        }

        /// <summary>
        /// Element deleting test for workbookPr element
        /// </summary>
        [Fact]
        public void PivotConnection03DeleteAddElement()
        {
            string originalFilepath = this.GetTestFilePath(this.generatedOldbConnectionDocumentFile);
            string deleteFilePath = this.GetTestFilePath(this.deletedOldbConnectionDocumentFile);
            string addFilePath = this.GetTestFilePath(this.addedOldbConnectionDocumentFile);

            System.IO.File.Copy(originalFilepath, deleteFilePath, true);

            this.connectionTestEntities.DeleteElement(deleteFilePath, this.Log);
            this.connectionTestEntities.VerifyDeletedElement(deleteFilePath, this.Log);

            System.IO.File.Copy(deleteFilePath, addFilePath, true);

            this.connectionTestEntities.AddElement(addFilePath, this.Log);
            this.connectionTestEntities.VerifyAddedElement(addFilePath, this.Log);
        }
    }
}
