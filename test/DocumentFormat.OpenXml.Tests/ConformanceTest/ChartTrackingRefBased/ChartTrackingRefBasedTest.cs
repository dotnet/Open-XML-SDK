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
            string createFilePath = GetTestFilePath(generateDocumentFile);
            GeneratedDocument generatedDocument = new GeneratedDocument();
            generatedDocument.CreatePackage(createFilePath);

            testEntities = new TestEntities(createFilePath);
        }

        /// <summary>
        /// Element editing test of ChartTrackingRefBased
        /// </summary>
        [Fact]
        public void ChartTrackingRefBasedTest01()
        {
            string originalFilepath = GetTestFilePath(generateDocumentFile);
            string editFilePath = GetTestFilePath(editDocumentFile);

            System.IO.File.Copy(originalFilepath, editFilePath, true);

            testEntities.EditElements(editFilePath, Log);
            testEntities.VerifyElements(editFilePath, Log);
        }

        /// <summary>
        /// Element deleting test of ChartTrackingRefBased
        /// </summary>
        [Fact]
        public void ChartTrackingRefBasedTest03DeleteElement()
        {
            string originalFilepath = GetTestFilePath(generateDocumentFile);
            string deleteFilePath = GetTestFilePath(deleteDocumentFile);
            string addFilePath = GetTestFilePath(addDocumentFile);

            System.IO.File.Copy(originalFilepath, deleteFilePath, true);
            Log.Comment("File copy [{0}] to [{1}]", originalFilepath, deleteFilePath);

            testEntities.DeleteElements(deleteFilePath, Log);
            testEntities.VerifyDeleteElements(deleteFilePath, Log);

            System.IO.File.Copy(deleteFilePath, addFilePath, true);
            Log.Comment("File copy [{0}] to [{1}]", originalFilepath, deleteFilePath);

            testEntities.AddElements(addFilePath, Log);
            testEntities.VerifyAddElements(addFilePath, Log);

            Log.Pass("Element deletion is complete.");
        }
    }
}
