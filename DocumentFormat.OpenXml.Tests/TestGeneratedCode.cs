// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation;
using Xunit;
using P = DocumentFormat.OpenXml.Presentation;
using S = DocumentFormat.OpenXml.Spreadsheet;
using W = DocumentFormat.OpenXml.Wordprocessing;
using A = DocumentFormat.OpenXml.Drawing;
using DW = DocumentFormat.OpenXml.Drawing.Wordprocessing;
using PIC = DocumentFormat.OpenXml.Drawing.Pictures;
using OpenXmlPowerTools;
using OxTest;

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
