// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Tests.CommentExPeopleClass;
using DocumentFormat.OpenXml.Tests.TaskLibraries;
using OxTest;
using System;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Tests.CommentExPeople
{
    /// <summary>
    /// Test for Comment People part.
    /// </summary>
    public class CommentExPeopleTest : OpenXmlTestBase
    {
        private readonly string generateDocumentFilePath = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx");
        private readonly string editedDocumentFilePath = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx");

        /// <summary>
        /// Constructor
        /// </summary>
        public CommentExPeopleTest(ITestOutputHelper output)
            : base(output)
        {
            string createFilePath = GetTestFilePath(generateDocumentFilePath);
            GeneratedDocument generatedDocument = new GeneratedDocument();
            generatedDocument.CreatePackage(createFilePath);

            Log.Pass("Create Word file. File path=[{0}].", createFilePath);
        }

        /// <summary>
        /// Element reading test for "Comment PeoplePart".
        /// </summary>
        [Fact]
        public void CommentExPeople01ReadElement()
        {
            string originalFilepath = GetTestFilePath(generateDocumentFilePath);

            TestEntities testEntities = new TestEntities();
            testEntities.ReadElements(originalFilepath, Log);
        }

        /// <summary>
        /// Element editing test for "Comment PeoplePart".
        /// </summary>
        [Fact]
        public void CommentExPeople02EditElement()
        {
            string originalFilepath = GetTestFilePath(generateDocumentFilePath);
            string editFilePath = GetTestFilePath(editedDocumentFilePath);

            System.IO.File.Copy(originalFilepath, editFilePath, true);

            TestEntities testEntities = new TestEntities();
            testEntities.EditElements(editFilePath, Log);
            testEntities.VerifyElements(editFilePath, Log);
        }
    }
}
