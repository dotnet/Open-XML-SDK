using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml.Tests.CommentExPeople
{
    using Xunit;
    using DocumentFormat.OpenXml.Tests.TaskLibraries;
    using DocumentFormat.OpenXml.Tests.CommentExPeopleClass;

    /// <summary>
    /// Test for Comment People part.
    /// </summary>
    public class CommentExPeopleTest : OpenXmlTestBase
    {
        private readonly string generateDocumentFilePath = "TestCommentPeopleBase.docx";
        private readonly string editeDocumentFilePath = "EditedCommentPeople.docx";

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public CommentExPeopleTest()
        {
            // Set the flag to notify MSTest of Ots Log failure.
            this.OtsLogFailureToFailTest = true;
        }
        #endregion

        #region Initialize
        /// <summary>
        /// Creates a base Word file for the tests.
        /// </summary>
        /// <param name="createFilePath">Create Word file path</param>
        private void Initialize(string createFilePath)
        {
            try
            {
                GeneratedDocument generatedDocument = new GeneratedDocument();
                generatedDocument.CreatePackage(createFilePath);

                this.Log.Pass("Create Word file. File path=[{0}].", createFilePath);
            }
            catch (Exception e)
            {
                this.Log.Fail(string.Format(e.Message + ". :File path={0}.", createFilePath));
            }
        }

        /// <summary>
        /// Creates a base Word file for the tests.
        /// </summary>
        protected override void TestInitializeOnce()
        {
            string generatDocumentFilePath = this.GetTestFilePath(this.generateDocumentFilePath);

            Initialize(generatDocumentFilePath);
        }
        #endregion

        #region Test Methods
        /// <summary>
        /// Element reading test for "Comment PeoplePart".
        /// </summary>
        [Fact]
        public void CommentExPeople01ReadElement()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            try
            {
                string originalFilepath = this.GetTestFilePath(this.generateDocumentFilePath);

                TestEntities testEntities = new TestEntities();
                testEntities.ReadElements(originalFilepath, this.Log);
            }
            catch (Exception e)
            {
                this.Log.Fail(e.Message);
            }
        }

        /// <summary>
        /// Element editing test for "Comment PeoplePart".
        /// </summary>
        [Fact]
        public void CommentExPeople02EditElement()
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
