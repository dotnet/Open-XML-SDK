using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml.Tests.ThreadingInfo
{
    using Xunit;
    using DocumentFormat.OpenXml.Tests.TaskLibraries;
    using DocumentFormat.OpenXml.Tests.ChartTrackingRefBasedClass;

    
    public class ThreadingInfoTest : OpenXmlTestBase
    {
        private readonly string generateDocumentFile = "TestThreadingInfoBase.pptx";
        private readonly string editDocumentFile = "EditedThreadingInfo.pptx";
        private readonly string deleteDocumentFile = "DeletedThreadingInfo.pptx";
        private readonly string addDocumentFile = "AddedThreadingInfo.pptx";

        TestEntities testEntities = null;

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public ThreadingInfoTest()
        {
            // Set the flag to notify MSTest of Ots Log failure
            this.OtsLogFailureToFailTest = true;
        }
        #endregion

        #region Initialize
        /// <summary>
        /// Creates a base Word file for the tests
        /// </summary>
        /// <param name="createFilePath">Create Power Point file path</param>
        private void Initialize(string createFilePath)
        {
            try
            {
                GeneratedDocument generatedDocument = new GeneratedDocument();
                generatedDocument.CreatePackage(createFilePath);

                this.Log.Pass("Create Power Point file. File path=[{0}]", createFilePath);

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
            string generatDocumentFilePath = this.GetTestFilePath(this.generateDocumentFile);

            Initialize(generatDocumentFilePath);
        }

        /// <summary>
        /// Element editing test for PresentationExtensionList element
        /// </summary>
        [Fact]
        public void ThreadingInfo01EditElement()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            try
            {
                string originalFilepath = this.GetTestFilePath(this.generateDocumentFile);
                string editFilePath = this.GetTestFilePath(this.editDocumentFile);

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
        /// Element deleting test for PresentationExtensionList element
        /// </summary>
        [Fact]
        public void ThreadingInfo03DeleteAddElement()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            try
            {
                string originalFilepath = this.GetTestFilePath(this.generateDocumentFile);
                string deleteFilePath = this.GetTestFilePath(this.deleteDocumentFile);
                string addFilePath = this.GetTestFilePath(this.addDocumentFile);

                System.IO.File.Copy(originalFilepath, deleteFilePath, true);

                this.testEntities.DeleteElements(deleteFilePath, this.Log);
                this.testEntities.VerifyDeleteElements(deleteFilePath, this.Log);

                System.IO.File.Copy(deleteFilePath, addFilePath, true);

                this.testEntities.AddElements(addFilePath, this.Log);
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
