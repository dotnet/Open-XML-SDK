// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Packaging;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Tests
{
    using DocumentFormat.OpenXml;
    using DocumentFormat.OpenXml.Validation;
    using DocumentFormat.OpenXml.Packaging;
    using DocumentFormat.OpenXml.Presentation;
    using DocumentFormat.OpenXml.Spreadsheet;
    using DocumentFormat.OpenXml.Wordprocessing;

    using Xunit;
    using DocumentFormat.OpenXml.Tests.TaskLibraries;
    using DocumentFormat.OpenXml.Tests.TaskLibraries.DataStorage;

    /// <summary>
    /// Test for CommentEx elements
    /// </summary>
    public class Robustness : OpenXmlTestBase
    {
        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public Robustness()
        {
        }
        #endregion

        #region Test Methods
        [Fact]
        public void OFCATFull()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod()); 
            TestDataStorage dataStorage = new TestDataStorage();
            var entries = dataStorage.GetEntries(
                TestDataStorage.DataGroups.RobustnessOFCAT);

            OpenXmlValidator validator = new OpenXmlValidator(FileFormatVersions.Office2013);

            this.ValidateDocuments(validator, entries);
        }
        #endregion
    }
}
