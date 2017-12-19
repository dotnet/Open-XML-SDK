// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using OxTest;
using System;
using System.IO;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    public class GenCode01
    {
        [Fact]
        public void G001()
        {
            var fileInfo = new FileInfo(Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx"));
            GeneratedClass001 gc = new GeneratedClass001();
            gc.CreatePackage(fileInfo.FullName);
            if (TestUtil.DeleteTempFiles)
                fileInfo.Delete();
        }

        [Fact]
        public void G002()
        {
            var fileInfo = new FileInfo(Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".xlsx"));
            GeneratedClass002 gc = new GeneratedClass002();
            gc.CreatePackage(fileInfo.FullName);
            if (TestUtil.DeleteTempFiles)
                fileInfo.Delete();
        }

        [Fact]
        public void G003()
        {
            var fileInfo = new FileInfo(Path.Combine(TestUtil.TestResultsDirectory, Guid.NewGuid().ToString() + ".docx"));
            GeneratedClass003 gc = new GeneratedClass003();
            gc.CreatePackage(fileInfo.FullName);
            if (TestUtil.DeleteTempFiles)
                fileInfo.Delete();
        }
    }
}
