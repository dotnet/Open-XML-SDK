// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.IO;

namespace DocumentFormat.OpenXml.Tests.TimeLine
{
    using DocumentFormat.OpenXml.Tests.TaskLibraries;
    using DocumentFormat.OpenXml.Tests.TimelineClass;
    using OxTest;
    using Xunit;
    using Xunit.Abstractions;

    /// <summary>
    /// Tests for TimeLine elements
    /// </summary>
    public class TimeLineTest : OpenXmlTestBase
    {
        private readonly string generateDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".xlsx");
        private readonly string editeDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".xlsx");
        private readonly string deleteTimelineStyleDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".xlsx");
        private readonly string addTimelineStyleDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".xlsx");
        private readonly TestEntities testEntities = null;

        /// <summary>
        /// Constructor
        /// </summary>
        public TimeLineTest(ITestOutputHelper output)
            : base(output)
        {
            string createFilePath = this.GetTestFilePath(this.generateDocumentFile);
            GeneratedDocument generatedDocument = new GeneratedDocument();
            generatedDocument.CreatePackage(createFilePath);

            this.Log.Pass("Create Excel file. File path=[{0}]", createFilePath);

            this.testEntities = new TestEntities(createFilePath);
        }

        /// <summary>
        /// Attribute editing test for TimeLine Control"
        /// </summary>
        [Fact]
        public void TimeLine01EditDeleteAddAttribute()
        {
            string originalFilepath = this.GetTestFilePath(this.generateDocumentFile);
            string editFilePath = this.GetTestFilePath(this.editeDocumentFile);
            string deleteTimelineStyleFilePath = this.GetTestFilePath(this.deleteTimelineStyleDocumentFile);
            string addTimelineStyleFilePath = this.GetTestFilePath(addTimelineStyleDocumentFile);

            System.IO.File.Copy(originalFilepath, editFilePath, true);

            this.testEntities.EditAttributes(editFilePath, this.Log);
            this.testEntities.VerifyEditedAttribute(editFilePath, this.Log);

            System.IO.File.Copy(editFilePath, deleteTimelineStyleFilePath, true);

            this.testEntities.DeleteTimelineStyle(deleteTimelineStyleFilePath, this.Log);
            this.testEntities.VerifyDeletedTimelineStyle(deleteTimelineStyleFilePath, this.Log);

            System.IO.File.Copy(deleteTimelineStyleFilePath, addTimelineStyleFilePath, true);

            this.testEntities.AddTimelineStyle(addTimelineStyleFilePath, this.Log);
            this.testEntities.VerifyAddedTimelineStyle(addTimelineStyleFilePath, this.Log);
        }
    }
}
