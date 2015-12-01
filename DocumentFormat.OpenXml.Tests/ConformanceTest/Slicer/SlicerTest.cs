using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml.Tests.Slicer
{
    using Xunit;
    using DocumentFormat.OpenXml.Tests.TaskLibraries;
    using DocumentFormat.OpenXml.Tests.TaskLibraries.DataStorage;
    using DocumentFormat.OpenXml.Tests.SlicerClass;

    /// <summary>
    /// Test for Slicer elements
    /// </summary>
    
    public class SlicerTest : OpenXmlTestBase
    {
        private readonly string generateDocumentFilePath = "TestSlicerBase.xlsx";
        private readonly string editeDocumentFilePath = "EditedSlicer.xlsx";

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public SlicerTest()
        {
            // Set the flag to notify MSTest of Ots Log failure
            this.OtsLogFailureToFailTest = true;
        }
        #endregion

        #region Initialize
        /// <summary>
        /// Creates a base Excel file for the tests
        /// </summary>
        /// <param name="createFilePath">Create Excel file path</param>
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
        /// Creates a base Excel file for the tests
        /// </summary>
        protected override void TestInitializeOnce()
        {
            string generatDocumentFilePath = this.GetTestFilePath(this.generateDocumentFilePath);

            Initialize(generatDocumentFilePath);
        }
        #endregion

        #region Test Methods
        /// <summary>
        /// Element editing test for "Slicer Cache"
        /// </summary>
        [Fact]
        public void Slicer01EditElement()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            try
            {
                string originalFilepath = this.GetTestFilePath(this.generateDocumentFilePath);
                string editFilePath = this.GetTestFilePath(this.editeDocumentFilePath);

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

        #endregion

    }
}
