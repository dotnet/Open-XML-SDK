using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml.Tests.ChartTrackingRefBased
{
    using Xunit;
    using DocumentFormat.OpenXml.Tests.TaskLibraries;
    using DocumentFormat.OpenXml.Tests.ChartTrackingRefBasedClass;

    public class ChartTrackingRefBasedTest : OpenXmlTestBase
    {
        private readonly string generateDocumentFile = "TestChartTrackingRefBasedBase.pptx";
        private readonly string editDocumentFile = "EditedChartTrackingRefBased.pptx";
        private readonly string deleteDocumentFile = "DeletedChartTrackingRefBased.pptx";
        private readonly string addDocumentFile = "AddedChartTrackingRefBased.pptx";

        private TestEntities testEntities = null;

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public ChartTrackingRefBasedTest()
        {
            // Set the flag to notify MSTest of Ots Log failure
            this.OtsLogFailureToFailTest = true;
        }
        #endregion

        #region Initialize
        /// <summary>
        /// Creates a base Power Point file for the tests
        /// </summary>
        /// <param name="createFilePath">Create Power Point file path</param>
        private void Initialize(string createFilePath)
        {
            try
            {
                GeneratedDocument generatedDocument = new GeneratedDocument();
                generatedDocument.CreatePackage(createFilePath);

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
        /// Creates a base Power Point file for the tests
        /// </summary>
        protected override void TestInitializeOnce()
        {
            string generatDocumentFilePath = this.GetTestFilePath(this.generateDocumentFile);

            Initialize(generatDocumentFilePath);
        }

        /// <summary>
        /// Element editing test of ChartTrackingRefBased
        /// </summary>
        [Fact]
        public void ChartTrackingRefBasedTest01()
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
        /// Element deleting test of ChartTrackingRefBased
        /// </summary>
        [Fact]
        public void ChartTrackingRefBasedTest03DeleteElement()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            try
            {
                string originalFilepath = this.GetTestFilePath(this.generateDocumentFile);
                string deleteFilePath = this.GetTestFilePath(this.deleteDocumentFile);
                string addFilePath = this.GetTestFilePath(this.addDocumentFile);

                System.IO.File.Copy(originalFilepath, deleteFilePath, true);
                this.Log.Comment("File copy [{0}] to [{1}]", originalFilepath, deleteFilePath);

                this.testEntities.DeleteElements(deleteFilePath, this.Log);
                this.testEntities.VerifyDeleteElements(deleteFilePath, this.Log);

                System.IO.File.Copy(deleteFilePath, addFilePath, true);
                this.Log.Comment("File copy [{0}] to [{1}]", originalFilepath, deleteFilePath);

                this.testEntities.AddElements(addFilePath, this.Log);
                this.testEntities.VerifyAddElements(addFilePath, this.Log);

                this.Log.Pass("Element deletion is complete.");
            }
            catch (Exception e)
            {
                this.Log.Fail(e.Message);
            }
        }

        #endregion
    }
}
