using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml.Tests.WorkBookPr
{
    using Xunit;
    using DocumentFormat.OpenXml.Tests.TaskLibraries;
    using DocumentFormat.OpenXml.Tests.WorkBookPrClass;

    
    public class WorkBookPrTest : OpenXmlTestBase
    {
        TestEntities testEntities = null;

        private readonly string generatedDocumentFile = "TestWorkBookPrBase.xlsx";
        private readonly string editedDocumentFile = "EditWorkBookPr.xlsx";
        private readonly string deletedDocumentFile = "DeleteWorkBookPr.xlsx";
        private readonly string addedDocumentFile = "AddedWorkBookPr.xlsx";

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public WorkBookPrTest()
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

                this.testEntities = new TestEntities(createFilePath);
            }
            catch (Exception e)
            {
                this.Log.Fail(string.Format(e.Message + ". :File path={0}", createFilePath));
            }
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
            try
            {
                string originalFilepath = this.GetTestFilePath(this.generatedDocumentFile);
                string editFilePath = this.GetTestFilePath(this.editedDocumentFile);

                System.IO.File.Copy(originalFilepath, editFilePath, true);

                this.testEntities.EditElements(editFilePath, this.Log);
                this.testEntities.VerifyElements(editFilePath, this.Log);
            }
            catch (Exception e)
            {
                this.Log.Fail(e.Message);
            }
        }

        /// <summary>
        /// Element deleting test for workbookPr element
        /// </summary>
        [Fact]
        public void WorkBookPr03DeleteElement()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            try
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
            catch (Exception e)
            {
                this.Log.Fail(e.Message);
            }
        }

        #endregion
    }
}
