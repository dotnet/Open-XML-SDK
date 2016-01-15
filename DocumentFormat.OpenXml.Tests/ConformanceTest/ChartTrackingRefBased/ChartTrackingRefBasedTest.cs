// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml.Tests.ChartTrackingRefBased
{
    using Xunit;
    using DocumentFormat.OpenXml.Tests.TaskLibraries;
    using DocumentFormat.OpenXml.Tests.ChartTrackingRefBasedClass;
    using LogUtil;
    using System.IO;
    using OxTest;

    public class ChartTrackingRefBasedTest : OpenXmlTestBase
    {
        //private readonly string generateDocumentFile = "TestChartTrackingRefBasedBase.pptx";
        private readonly string generateDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".pptx");
        private readonly string editDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".pptx");
        private readonly string deleteDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".pptx");
        private readonly string addDocumentFile = Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".pptx");
        
        private TestEntities testEntities = null;

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public ChartTrackingRefBasedTest()
        {
        }
        #endregion

        #region Initialize
        /// <summary>
        /// Creates a base Power Point file for the tests
        /// </summary>
        /// <param name="createFilePath">Create Power Point file path</param>
        private void Initialize(string createFilePath)
        {
            GeneratedDocument generatedDocument = new GeneratedDocument();
            generatedDocument.CreatePackage(createFilePath);

            this.testEntities = new TestEntities(createFilePath);
        }
        #endregion

        #region Test Methods
        /// <summary>
        /// Creates a base Power Point file for the tests
        /// </summary>
        protected override void TestInitializeOnce()
        {
            string generatDocumentFilePath = this.GetTestFilePath(this.generateDocumentFile);

            Initialize(generatDocumentFilePath);
        }

        /// <summary>
        /// Element editing test of ChartTrackingRefBased
        /// </summary>
        [Fact]
        public void ChartTrackingRefBasedTest01()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
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
            this.MyTestInitialize(TestContext.GetCurrentMethod());

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

        #endregion
    }
}
