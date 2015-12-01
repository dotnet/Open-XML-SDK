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

    /// <summary>
    /// Test for CommentEx elements
    /// </summary>
    public class CommentExTest : OpenXmlTestBase
    {
        private readonly string generatedDocumentFilePath = "TestCommentExBase.docx";
        private readonly string editedDocumentFilePath = "EditedCommentEx.docx";
        private readonly string deleteDocumentFilePath = "DeletedCommentEx.docx";

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public CommentExTest()
        {
            // Set the flag to notify MSTest of Ots Log failure
            this.OtsLogFailureToFailTest = true;
        }
        #endregion

        #region Initialize
        /// <summary>
        /// Creates a base Word file for the tests
        /// </summary>
        /// <param name="createFilePath">Create Word file path</param>
        private void Initialize(string createFilePath)
        {
            try
            {
                GeneratedDocument generatedDocument = new GeneratedDocument();
                generatedDocument.CreatePackage(createFilePath);

                this.Log.Pass("Create Word file. File path=[{0}]", createFilePath);
            }
            catch (Exception e)
            {
                this.Log.Fail(string.Format(e.Message + ". :File path={0}", createFilePath));
            }
        }

        /// <summary>
        /// Creates a base Word file for the tests
        /// </summary>
        protected override void TestInitializeOnce()
        {
            string generatDocumentFilePath = this.GetTestFilePath(this.generatedDocumentFilePath);

            Initialize(generatDocumentFilePath);
        }
        #endregion

        #region Test Methods
        /// <summary>
        /// Office15TCM: xxxxx: OASys#283289: OOXML SDK : ACC : O15 Conformance CommentEx
        /// </summary>
        [Fact]
        public void CommentExAcceptance()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            TestDataStorage dataStorage = new TestDataStorage();
            var entries = dataStorage.GetEntries(TestDataStorage.DataGroups.O15ConformanceWord).Where(i => i.FilePath.Contains("Sample-15-12-01"));

            OpenXmlValidator validator = new OpenXmlValidator(FileFormatVersions.Office2013);

            this.ValidateDocuments(validator, entries);
        }

        /// <summary>
        /// Office15TCM: xxxxx: OASys#283293: OOXML SDK : COMPS : Invalid format on CommentEx 
        /// </summary>
        [Fact]
        public void CommentExInvalidFormat()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
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
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            try
            {
                string originalFilepath = this.GetTestFilePath(this.generatedDocumentFilePath);
                string editFilePath = this.GetTestFilePath(this.editedDocumentFilePath);

                System.IO.File.Copy(originalFilepath, editFilePath, true);

                TestEntities testEntities = new TestEntities();
                testEntities.EditElements(editFilePath, this.Log);
                testEntities.VerifyElements(editFilePath, this.Log);
            }
            catch (Exception e)
            {
                this.Log.Fail(e.Message);
            }
        }

        /// <summary>
        /// Verifies deleted Content Control
        /// </summary>
        [Fact]
        public void CommentEx04VerifyDelete()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            try
            {
                string originalFilepath = this.GetTestFilePath(this.generatedDocumentFilePath);
                string deleteFilePath = this.GetTestFilePath(this.deleteDocumentFilePath);

                System.IO.File.Copy(originalFilepath, deleteFilePath, true);

                TestEntities testEntities = new TestEntities();
                testEntities.DeleteElements(deleteFilePath, this.Log);
                testEntities.VerifyDeletedElements(deleteFilePath, this.Log);
            }
            catch (Exception e)
            {
                this.Log.Fail(e.Message);
            }
        }
        #endregion
    }
}
