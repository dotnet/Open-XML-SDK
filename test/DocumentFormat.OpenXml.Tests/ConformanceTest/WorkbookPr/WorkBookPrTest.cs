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
            string createFilePath = GetTestFilePath(generatedDocumentFile);
            GeneratedDocument generatedDocument = new GeneratedDocument();
            generatedDocument.CreatePackage(createFilePath);

            Log.Pass("Create Word file. File path=[{0}]", createFilePath);

            testEntities = new TestEntities(createFilePath);
        }

        /// <summary>
        /// Element editing test for workbookPr element
        /// </summary>
        [Fact]
        public void WorkBookPr01EditElement()
        {
            string originalFilepath = GetTestFilePath(generatedDocumentFile);
            string editFilePath = GetTestFilePath(editedDocumentFile);

            System.IO.File.Copy(originalFilepath, editFilePath, true);

            testEntities.EditElements(editFilePath, Log);
            testEntities.VerifyElements(editFilePath, Log);
        }

        /// <summary>
        /// Element deleting test for workbookPr element
        /// </summary>
        [Fact]
        public void WorkBookPr03DeleteElement()
        {
            string originalFilepath = GetTestFilePath(generatedDocumentFile);
            string deleteFilePath = GetTestFilePath(deletedDocumentFile);
            string addFilePath = GetTestFilePath(addedDocumentFile);

            System.IO.File.Copy(originalFilepath, deleteFilePath, true);

            testEntities.DeleteElements(deleteFilePath, Log);
            testEntities.VerifyDeleteElements(deleteFilePath, Log);

            System.IO.File.Copy(deleteFilePath, addFilePath, true);

            testEntities.AddElement(addFilePath, Log);
            testEntities.VerifyAddElements(addFilePath, Log);
        }
    }
}
