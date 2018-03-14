// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using LogUtil;
using OxTest;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Tests.TaskLibraries
{
    /// <summary>
    /// The OpenXmlDom test framework. It contains help methods for testing OpenXmlDom Classes
    /// </summary>
    public class OpenXmlTestBase
    {
        protected OpenXmlTestBase(ITestOutputHelper output)
        {
            Log = new VerifiableLog(output);
        }

        protected VerifiableLog Log { get; }

        public string GetTestFilePath(string filename)
        {
            string testFileFolder = Path.Combine(TestUtil.TestResultsDirectory, TestClassName + "_files");
            string testFilePath = Path.Combine(testFileFolder, filename);

            if (Directory.Exists(testFileFolder) == false)
            {
                Log.Comment("Create a test file folder : {0}", testFileFolder);
                Directory.CreateDirectory(testFileFolder);
            }

            Log.Comment("Test file path: {0}", testFilePath);

            return testFilePath;
        }

        // TODO: Remove this
        private string TestClassName { get; } = Guid.NewGuid().ToString();
    }
}
