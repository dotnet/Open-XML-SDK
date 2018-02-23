// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Tests.TaskLibraries;
using DocumentFormat.OpenXml.Tests.ThemeClass;
using OxTest;
using System;
using System.IO;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Tests.Theme
{
    public class ThemeTest : OpenXmlTestBase
    {
        private readonly string generateDocumentFilePath = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".pptx");
        private readonly string editDocumentFilePath = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".pptx");
        private readonly string deleteDocumentFilePath = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".pptx");
        private readonly string addDocumentFilePath = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".pptx");

        /// <summary>
        /// Constructor
        /// </summary>
        public ThemeTest(ITestOutputHelper output)
            : base(output)
        {
            string createFilePath = this.GetTestFilePath(this.generateDocumentFilePath);
            GeneratedDocument generatedDocument = new GeneratedDocument();
            generatedDocument.CreatePackage(createFilePath);

            this.Log.Pass("Create Power Point file. File path=[{0}]", createFilePath);
        }

        /// <summary>
        /// Element editing test for workbookPr element
        /// </summary>
        [Fact]
        public void Theme01EditAttribute()
        {
            string originalFilepath = this.GetTestFilePath(this.generateDocumentFilePath);
            string editFilePath = this.GetTestFilePath(this.editDocumentFilePath);

            System.IO.File.Copy(originalFilepath, editFilePath, true);

            // Adding ThemeId
            using (PresentationDocument doc = PresentationDocument.Open(editFilePath, true))
            {
                doc.PresentationPart.SlideMasterParts.First().ThemePart.Theme.ThemeId =
                    new DocumentFormat.OpenXml.StringValue("TEST");
            }

            TestEntities testEntities = new TestEntities();
            testEntities.EditAttribute(editFilePath, this.Log);
            testEntities.VerifyAttribute(editFilePath, this.Log);
        }

        /// <summary>
        /// Element deleting test for workbookPr element
        /// </summary>
        [Fact]
        public void Theme03DeleteAttribute()
        {
            string originalFilepath = this.GetTestFilePath(this.generateDocumentFilePath);
            string deleteFilePath = this.GetTestFilePath(this.deleteDocumentFilePath);
            string addFilePath = this.GetTestFilePath(this.addDocumentFilePath);

            System.IO.File.Copy(originalFilepath, deleteFilePath, true);
            this.Log.Comment("File copy [{0}] to [{1}]", originalFilepath, deleteFilePath);

            TestEntities testEntities = new TestEntities();
            testEntities.DeletAttribute(deleteFilePath, this.Log);
            testEntities.VerifyDeletedAttribute(deleteFilePath, this.Log);

            System.IO.File.Copy(deleteFilePath, addFilePath, true);
            this.Log.Comment("File copy [{0}] to [{1}]", deleteFilePath, addFilePath);

            testEntities.AddAttribute(addFilePath, this.Log);
            testEntities.VerifyAddedAttribute(addFilePath, this.Log);

            this.Log.Pass("Deleted the thm15:id attribute is complete.");
        }
    }
}
