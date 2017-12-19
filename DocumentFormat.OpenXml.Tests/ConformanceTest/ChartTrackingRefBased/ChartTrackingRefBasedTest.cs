// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Tests.ChartTrackingRefBasedClass;
using DocumentFormat.OpenXml.Tests.TaskLibraries;
using OxTest;
using System;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Tests.ChartTrackingRefBased
{
    public class ChartTrackingRefBasedTest : OpenXmlTestBase
    {
        private readonly string generateDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".pptx");
        private readonly string editDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".pptx");
        private readonly string deleteDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".pptx");
        private readonly string addDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".pptx");

        private TestEntities testEntities = null;

        /// <summary>
        /// Constructor
        /// </summary>
        public ChartTrackingRefBasedTest(ITestOutputHelper output)
            : base(output)
        {
            string createFilePath = this.GetTestFilePath(this.generateDocumentFile);
            GeneratedDocument generatedDocument = new GeneratedDocument();
            generatedDocument.CreatePackage(createFilePath);

            this.testEntities = new TestEntities(createFilePath);
        }

        /// <summary>
        /// Element editing test of ChartTrackingRefBased
        /// </summary>
        [Fact]
        public void ChartTrackingRefBasedTest01()
        {
            string originalFilepath = this.GetTestFilePath(this.generateDocumentFile);
            string editFilePath = this.GetTestFilePath(this.editDocumentFile);

            System.IO.File.Copy(originalFilepath, editFilePath, true);

            this.testEntities.EditElements(editFilePath, this.Log);
            this.testEntities.VerifyElements(editFilePath, this.Log);
        }

        /// <summary>
        /// Element deleting test of ChartTrackingRefBased
        /// </summary>
        [Fact]
        public void ChartTrackingRefBasedTest03DeleteElement()
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
    }
}
