// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml.Tests.CommentExPeople
{
    using Xunit;
    using DocumentFormat.OpenXml.Tests.TaskLibraries;
    using DocumentFormat.OpenXml.Tests.CommentExPeopleClass;
    using System.IO;
    using OxTest;

    /// <summary>
    /// Test for Comment People part.
    /// </summary>
    public class CommentExPeopleTest : OpenXmlTestBase
    {
        private readonly string generateDocumentFilePath = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx");
        private readonly string editedDocumentFilePath = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx");

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public CommentExPeopleTest()
        {
        }
        #endregion

        #region Initialize
        /// <summary>
        /// Creates a base Word file for the tests.
        /// </summary>
        /// <param name="createFilePath">Create Word file path</param>
        private void Initialize(string createFilePath)
        {
            GeneratedDocument generatedDocument = new GeneratedDocument();
            generatedDocument.CreatePackage(createFilePath);

            this.Log.Pass("Create Word file. File path=[{0}].", createFilePath);
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

            string originalFilepath = this.GetTestFilePath(this.generateDocumentFilePath);

            TestEntities testEntities = new TestEntities();
            testEntities.ReadElements(originalFilepath, this.Log);
        }

        /// <summary>
        /// Element editing test for "Comment PeoplePart".
        /// </summary>
        [Fact]
        public void CommentExPeople02EditElement()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());

            string originalFilepath = this.GetTestFilePath(this.generateDocumentFilePath);
            string editFilePath = this.GetTestFilePath(this.editedDocumentFilePath);

            System.IO.File.Copy(originalFilepath, editFilePath, true);

            TestEntities testEntities = new TestEntities();
            testEntities.EditElements(editFilePath, this.Log);
            testEntities.VerifyElements(editFilePath, this.Log);
        }
        #endregion
    }
}
