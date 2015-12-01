using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml.Tests.GuideTest
{
    using Xunit;
    using DocumentFormat.OpenXml.Tests.TaskLibraries;
    using DocumentFormat.OpenXml.Tests.GuideClass;

    
    public class GuideTest : OpenXmlTestBase
    {
        private readonly string generateDocumentFile = "TestGuideBase.pptx";
        private readonly string editDocumentFile = "EditedGuide.pptx";
        private readonly string deleteDocumentFile = "DeletedGuide.pptx";
        private readonly string addDocumentFile = "AddedGuide.pptx";
        TestEntities testEntities = null;

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public GuideTest()
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
        public void Guide01EditElement()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            try
            {
                string originalFilepath = this.GetTestFilePath(this.generateDocumentFile);
                string editFilePath = this.GetTestFilePath(this.editDocumentFile);

                System.IO.File.Copy(originalFilepath, editFilePath, true);

                this.testEntities.EditElement(editFilePath, this.Log);
                this.testEntities.VerifyElement(editFilePath, this.Log);
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
        public void Guide03DeleteAddElement()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            try
            {
                string originalFilepath = this.GetTestFilePath(this.generateDocumentFile);
                string deleteFilePath = this.GetTestFilePath(this.deleteDocumentFile);
                string addFilePath = this.GetTestFilePath(this.addDocumentFile);

                System.IO.File.Copy(originalFilepath, deleteFilePath, true);

                this.testEntities.DeleteElement(deleteFilePath, this.Log);
                this.testEntities.VerifyDeletedElement(deleteFilePath, this.Log);

                System.IO.File.Copy(deleteFilePath, addFilePath, true);

                this.testEntities.AddElement(addFilePath, this.Log);
                this.testEntities.VerifyAddedElemenet(addFilePath, this.Log);
            }
            catch (Exception e)
            {
                this.Log.Fail(e.Message);
            }
        }

        #endregion
    }
}
