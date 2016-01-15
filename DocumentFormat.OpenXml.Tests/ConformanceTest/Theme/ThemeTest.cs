// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml.Tests.Theme
{
    using DocumentFormat.OpenXml.Packaging;
    using Xunit;
    using DocumentFormat.OpenXml.Tests.TaskLibraries;
    using DocumentFormat.OpenXml.Tests.ThemeClass;
    using System.IO;
    using OxTest;


    public class ThemeTest : OpenXmlTestBase
    {
        //private readonly string generateDocumentFilePath = "TestThemeBase.pptx";
        //private readonly string editDocumentFilePath = "EditedTheme.pptx";
        //private readonly string deleteDocumentFilePath = "DeletedTheme.pptx";
        //private readonly string addDocumentFilePath = "AddedTheme.pptx";
        private readonly string generateDocumentFilePath = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".pptx");
        private readonly string editDocumentFilePath = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".pptx");
        private readonly string deleteDocumentFilePath = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".pptx");
        private readonly string addDocumentFilePath = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".pptx");

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public ThemeTest()
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

            this.Log.Pass("Create Power Point file. File path=[{0}]", createFilePath);
        }
        #endregion

        #region Test Methods
        /// <summary>
        /// Creates a base Excel file for the tests
        /// </summary>
        protected override void TestInitializeOnce()
        {
            string generatDocumentFilePath = this.GetTestFilePath(this.generateDocumentFilePath);

            Initialize(generatDocumentFilePath);
        }

        /// <summary>
        /// Element editing test for workbookPr element
        /// </summary>
        [Fact]
        public void Theme01EditAttribute()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());

            string originalFilepath = this.GetTestFilePath(this.generateDocumentFilePath);
            string editFilePath = this.GetTestFilePath(this.editDocumentFilePath);

            System.IO.File.Copy(originalFilepath, editFilePath, true);

            // Adding ThemeId
            using (PresentationDocument doc = PresentationDocument.Open(editFilePath, true))
            {
                doc.PresentationPart.SlideMasterParts.First().ThemePart.Theme.ThemeId =
                    new DocumentFormat.OpenXml.StringValue("TEST");
            }

            TestEntities testEntities = new TestEntities();
            testEntities.EditAttribute(editFilePath, this.Log);
            testEntities.VerifyAttribute(editFilePath, this.Log);
        }

        /// <summary>
        /// Element deleting test for workbookPr element
        /// </summary>
        [Fact]
        public void Theme03DeleteAttribute()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());

            string originalFilepath = this.GetTestFilePath(this.generateDocumentFilePath);
            string deleteFilePath = this.GetTestFilePath(this.deleteDocumentFilePath);
            string addFilePath = this.GetTestFilePath(this.addDocumentFilePath);

            System.IO.File.Copy(originalFilepath, deleteFilePath, true);
            this.Log.Comment("File copy [{0}] to [{1}]", originalFilepath, deleteFilePath);

            TestEntities testEntities = new TestEntities();
            testEntities.DeletAttribute(deleteFilePath, this.Log);
            testEntities.VerifyDeletedAttribute(deleteFilePath, this.Log);

            System.IO.File.Copy(deleteFilePath, addFilePath, true);
            this.Log.Comment("File copy [{0}] to [{1}]", deleteFilePath, addFilePath);

            testEntities.AddAttribute(addFilePath, this.Log);
            testEntities.VerifyAddedAttribute(addFilePath, this.Log);

            this.Log.Pass("Deleted the thm15:id attribute is complete.");
        }

        #endregion
    }
}
