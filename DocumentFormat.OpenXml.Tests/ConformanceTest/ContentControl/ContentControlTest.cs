// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml.Tests.ContentControl
{
    using Xunit;
    using DocumentFormat.OpenXml.Tests.TaskLibraries;
    using DocumentFormat.OpenXml.Tests.TaskLibraries.DataStorage;
    using DocumentFormat.OpenXml.Tests.ContentControlClass;
    using System.IO;
    using OxTest;

    /// <summary>
    /// Tests for Content Controls
    /// </summary>
    public class ContentControlTest : OpenXmlTestBase
    {
        private readonly string generatedDocumentFilePath = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx");
        private readonly string editedDocumentFilePath = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx");
        private readonly string deletedDocumentFilePath = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx");

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public ContentControlTest()
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
        }
        #endregion

        #region Test Methods
        /// <summary>
        /// Creates a base Word file for the tests
        /// </summary>
        protected override void TestInitializeOnce()
        {
            string generatDocumentFilePath = this.GetTestFilePath(this.generatedDocumentFilePath);

            Initialize(generatDocumentFilePath);
        }

        /// <summary>
        /// Element editing test for "Content Control"
        /// </summary>
        [Fact]
        public void ContentControl01EditElement()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());

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
            this.MyTestInitialize(TestContext.GetCurrentMethod());

            string originalFilepath = this.GetTestFilePath(this.generatedDocumentFilePath);
            string deleteFilePath = this.GetTestFilePath(this.deletedDocumentFilePath);

            System.IO.File.Copy(originalFilepath, deleteFilePath, true);

            //Deleting all "sdt" elements
            DeleteElement.DeleteContentControlElements(deleteFilePath, this.Log);
            int sdtElementNum = VerifyDeletedElement.DeletedElementVerify(deleteFilePath, this.Log);
        }
        #endregion
    }
}
