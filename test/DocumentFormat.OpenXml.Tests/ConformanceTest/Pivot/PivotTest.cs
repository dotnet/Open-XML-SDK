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
            string createFilePath = GetTestFilePath(generatedOldbConnectionDocumentFile);
            ConnectionGeneratedDocument connectionGeneratedDocument = new ConnectionGeneratedDocument();
            connectionGeneratedDocument.CreatePackage(createFilePath);

            Log.Pass("Create Word file. File path=[{0}]", createFilePath);

            connectionTestEntities = new ConnectionTestEntities(createFilePath);
        }

        /// <summary>
        /// Element editing test for workbookPr element
        /// </summary>
        [Fact]
        public void PivotConnection01EditElement()
        {
            string originalFilepath = GetTestFilePath(generatedOldbConnectionDocumentFile);
            string editFilePath = GetTestFilePath(editedOldbConnectionDocumentFile);

            System.IO.File.Copy(originalFilepath, editFilePath, true);

            connectionTestEntities.EditElement(editFilePath, Log);
            connectionTestEntities.VerifyElement(editFilePath, Log);
        }

        /// <summary>
        /// Element deleting test for workbookPr element
        /// </summary>
        [Fact]
        public void PivotConnection03DeleteAddElement()
        {
            string originalFilepath = GetTestFilePath(generatedOldbConnectionDocumentFile);
            string deleteFilePath = GetTestFilePath(deletedOldbConnectionDocumentFile);
            string addFilePath = GetTestFilePath(addedOldbConnectionDocumentFile);

            System.IO.File.Copy(originalFilepath, deleteFilePath, true);

            connectionTestEntities.DeleteElement(deleteFilePath, Log);
            connectionTestEntities.VerifyDeletedElement(deleteFilePath, Log);

            System.IO.File.Copy(deleteFilePath, addFilePath, true);

            connectionTestEntities.AddElement(addFilePath, Log);
            connectionTestEntities.VerifyAddedElement(addFilePath, Log);
        }
    }
}
