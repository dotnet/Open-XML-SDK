// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml.Tests.WorkBookPr
{
    using Xunit;
    using DocumentFormat.OpenXml.Tests.TaskLibraries;
    using DocumentFormat.OpenXml.Tests.WorkBookPrClass;
    using System.IO;
    using OxTest;


    public class WorkBookPrTest : OpenXmlTestBase
    {
        TestEntities testEntities = null;

        //private readonly string generatedDocumentFile = "TestWorkBookPrBase.xlsx";
        //private readonly string editedDocumentFile = "EditWorkBookPr.xlsx";
        //private readonly string deletedDocumentFile = "DeleteWorkBookPr.xlsx";
        //private readonly string addedDocumentFile = "AddedWorkBookPr.xlsx";
        private readonly string generatedDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".xlsx");
        private readonly string editedDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".xlsx");
        private readonly string deletedDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".xlsx");
        private readonly string addedDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".xlsx");
        
        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public WorkBookPrTest()
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
            GeneratedDocument generatedDocument = new GeneratedDocument();
            generatedDocument.CreatePackage(createFilePath);

            this.Log.Pass("Create Word file. File path=[{0}]", createFilePath);

            this.testEntities = new TestEntities(createFilePath);
        }
        #endregion

        #region Test Methods
        /// <summary>
        /// Creates a base Excel file for the tests
        /// </summary>
        protected override void TestInitializeOnce()
        {
            string generatDocumentFilePath = this.GetTestFilePath(this.generatedDocumentFile);

            Initialize(generatDocumentFilePath);
        }

        /// <summary>
        /// Element editing test for workbookPr element
        /// </summary>
        [Fact]
        public void WorkBookPr01EditElement()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());

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
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            
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

        #endregion
    }
}
