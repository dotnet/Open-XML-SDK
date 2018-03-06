// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Tests.SlicerClass;
using DocumentFormat.OpenXml.Tests.TaskLibraries;
using OxTest;
using System;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Tests.Slicer
{
    /// <summary>
    /// Test for Slicer elements
    /// </summary>
    public class SlicerTest : OpenXmlTestBase
    {
        private readonly string generateDocumentFilePath = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".xlsx");
        private readonly string editeDocumentFilePath = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".xlsx");

        /// <summary>
        /// Constructor
        /// </summary>
        public SlicerTest(ITestOutputHelper output)
            : base(output)
        {
            string createFilePath = GetTestFilePath(generateDocumentFilePath);
            GeneratedDocument generatedDocument = new GeneratedDocument();
            generatedDocument.CreatePackage(createFilePath);

            Log.Pass("Create Word file. File path=[{0}]", createFilePath);
        }

        /// <summary>
        /// Element editing test for "Slicer Cache"
        /// </summary>
        [Fact]
        public void Slicer01EditElement()
        {
            string originalFilepath = GetTestFilePath(generateDocumentFilePath);
            string editFilePath = GetTestFilePath(editeDocumentFilePath);

            System.IO.File.Copy(originalFilepath, editFilePath, true);

            TestEntities testEntities = new TestEntities();
            testEntities.EditElements(editFilePath, Log);
            testEntities.VerifyElements(editFilePath, Log);
        }
    }
}
