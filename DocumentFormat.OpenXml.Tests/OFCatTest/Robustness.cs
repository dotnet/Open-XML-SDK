// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

namespace DocumentFormat.OpenXml.Tests
{
    using DocumentFormat.OpenXml;
    using DocumentFormat.OpenXml.Tests.TaskLibraries;
    using DocumentFormat.OpenXml.Tests.TaskLibraries.DataStorage;
    using DocumentFormat.OpenXml.Validation;
    using Xunit;
    using Xunit.Abstractions;

    /// <summary>
    /// Test for CommentEx elements
    /// </summary>
    public class Robustness : OpenXmlTestBase
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Robustness(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        public void OFCATFull()
        {
            TestDataStorage dataStorage = new TestDataStorage();
            var entries = dataStorage.GetEntries(
                TestDataStorage.DataGroups.RobustnessOFCAT);

            OpenXmlValidator validator = new OpenXmlValidator(FileFormatVersions.Office2013);

            this.ValidateDocuments(validator, entries);
        }
    }
}
