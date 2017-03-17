// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml.Tests.Pivot
{
    using Xunit;
    using DocumentFormat.OpenXml.Tests.TaskLibraries;
    using DocumentFormat.OpenXml.Tests.PivotClass;
    using System.IO;
    using OxTest;


    public class PivotTest : OpenXmlTestBase
    {
        ConnectionTestEntities connectionTestEntities = null;

        //private readonly string generatedOldbConnectionDocumentFile = "TestPivotOldbConnectionBase.xlsx";
        private readonly string generatedOldbConnectionDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".xlsx");

        private readonly string editedOldbConnectionDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".xlsx");
        private readonly string deletedOldbConnectionDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".xlsx");
        private readonly string addedOldbConnectionDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".xlsx");

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public PivotTest()
        {
        }
        #endregion

        #region Initialize
        /// <summary>
        /// Creates a base Word file for the tests
        /// </summary>
        /// <param name="createFilePath">Create Word file path</param>
        private void Initialize(string createFilePath)
        {
            ConnectionGeneratedDocument connectionGeneratedDocument = new ConnectionGeneratedDocument();
            connectionGeneratedDocument.CreatePackage(createFilePath);

            this.Log.Pass("Create Word file. File path=[{0}]", createFilePath);

            this.connectionTestEntities = new ConnectionTestEntities(createFilePath);
        }
        #endregion

        #region Test Methods
        /// <summary>
        /// Creates a base Excel file for the tests
        /// </summary>
        protected override void TestInitializeOnce()
        {
            string generatDocumentFilePath = this.GetTestFilePath(this.generatedOldbConnectionDocumentFile);

            Initialize(generatDocumentFilePath);
        }

        /// <summary>
        /// Element editing test for workbookPr element
        /// </summary>
        [Fact]
        public void PivotConnection01EditElement()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());

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
            this.MyTestInitialize(TestContext.GetCurrentMethod());

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
        #endregion
    }
}
