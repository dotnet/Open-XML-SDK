// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Tests.TimeLine
{
    using Xunit;
    using DocumentFormat.OpenXml.Tests.TaskLibraries;
    using DocumentFormat.OpenXml.Tests.TimelineClass;
    using OxTest;


    /// <summary>
    /// Tests for TimeLine elements
    /// </summary>

    public class TimeLineTest : OpenXmlTestBase
    {
        //private readonly string generateDocumentFile = "TestTimeLineBase.xlsx";
        //private readonly string editeDocumentFile = "EditedTimeLine.xlsx";
        //private readonly string deleteTimelineStyleDocumentFile = "DeletedTimelineStyleTimeLine.xlsx";
        //private readonly string addTimelineStyleDocumentFile = "AddedTimelineStyleTimeLine.xlsx";
        private readonly string generateDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".xlsx");
        private readonly string editeDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".xlsx");
        private readonly string deleteTimelineStyleDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".xlsx");
        private readonly string addTimelineStyleDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".xlsx");

        

        TestEntities testEntities = null;

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public TimeLineTest()
        {
        }
        #endregion

        #region Initialize
        /// <summary>
        /// Create is a Excel file, It's test base file.
        /// </summary>
        /// <param name="createFilePath">Create Excel file path</param>
        /// <returns>Excel file path</returns>
        private void Initialize(string createFilePath)
        {
            GeneratedDocument generatedDocument = new GeneratedDocument();
            generatedDocument.CreatePackage(createFilePath);

            this.Log.Pass("Create Excel file. File path=[{0}]", createFilePath);

            this.testEntities = new TestEntities(createFilePath);
        }
        #endregion

        #region Test Methods
        /// <summary>
        /// Creates a base Excel file for the tests
        /// </summary>
        protected override void TestInitializeOnce()
        {
            string generatDocumentFilePath = this.GetTestFilePath(this.generateDocumentFile);

            Initialize(generatDocumentFilePath);
        }

        /// <summary>
        /// Attribute editing test for TimeLine Control"
        /// </summary>
        [Fact]
        public void TimeLine01EditDeleteAddAttribute()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());

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

        #endregion
    }
}
