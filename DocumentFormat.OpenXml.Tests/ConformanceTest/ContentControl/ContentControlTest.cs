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

    /// <summary>
    /// Tests for Content Controls
    /// </summary>
    public class ContentControlTest : OpenXmlTestBase
    {
        private readonly string generatedDocumentFilePath = "TestContentControlBaseFile.docx";
        private readonly string editedDocumentFilePath = "EditContentControlFile.docx";
        private readonly string deletedDocumentFilePath = "DeleteContentControlFile.docx";

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public ContentControlTest()
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
            try
            {
                string originalFilepath = this.GetTestFilePath(this.generatedDocumentFilePath);
                string editFilePath = this.GetTestFilePath(this.editedDocumentFilePath);

                System.IO.File.Copy(originalFilepath, editFilePath, true);

                EditElement.EditContentControlElements(editFilePath, this.Log);
                VerifyElement.VerifyContentControlElement(editFilePath, this.Log);
            }
            catch (Exception e)
            {
                this.Log.Fail(e.Message);
            }
        }

        /// <summary>
        /// Deleting all sdt elements
        /// </summary>
        [Fact]
        public void ContentControl03DeleteElement()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            try
            {
                string originalFilepath = this.GetTestFilePath(this.generatedDocumentFilePath);
                string deleteFilePath = this.GetTestFilePath(this.deletedDocumentFilePath);

                System.IO.File.Copy(originalFilepath, deleteFilePath, true);

                //Deleting all "sdt" elements
                DeleteElement.DeleteContentControlElements(deleteFilePath, this.Log);
                int sdtElementNum = VerifyDeletedElement.DeletedElementVerify(deleteFilePath, this.Log);
            }
            catch (Exception e)
            {
                this.Log.Fail(e.Message);
            }
        }
        #endregion
    }
}
