// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Tests.ChartTrackingRefBasedClass;
using DocumentFormat.OpenXml.Tests.TaskLibraries;
using OxTest;
using System;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Tests.ThreadingInfo
{
    public class ThreadingInfoTest : OpenXmlTestBase
    {
        private readonly string generateDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".pptx");
        private readonly string editDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".pptx");
        private readonly string deleteDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".pptx");
        private readonly string addDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".pptx");
        private readonly TestEntities testEntities;

        /// <summary>
        /// Constructor
        /// </summary>
        public ThreadingInfoTest(ITestOutputHelper output)
            : base(output)
        {
            string createFilePath = this.GetTestFilePath(this.generateDocumentFile);
            GeneratedDocument generatedDocument = new GeneratedDocument();
            generatedDocument.CreatePackage(createFilePath);

            this.Log.Pass("Create Power Point file. File path=[{0}]", createFilePath);

            this.testEntities = new TestEntities(createFilePath);
        }

        /// <summary>
        /// Element editing test for PresentationExtensionList element
        /// </summary>
        [Fact]
        public void ThreadingInfo01EditElement()
        {
            string originalFilepath = this.GetTestFilePath(this.generateDocumentFile);
            string editFilePath = this.GetTestFilePath(this.editDocumentFile);

            System.IO.File.Copy(originalFilepath, editFilePath, true);

            this.testEntities.EditElements(editFilePath, this.Log);
            this.testEntities.VerifyElements(editFilePath, this.Log);
        }

        /// <summary>
        /// Element deleting test for PresentationExtensionList element
        /// </summary>
        [Fact]
        public void ThreadingInfo03DeleteAddElement()
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
    }
}
