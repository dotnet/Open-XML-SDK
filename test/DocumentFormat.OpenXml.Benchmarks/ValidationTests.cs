﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using BenchmarkDotNet.Attributes;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Tests;
using DocumentFormat.OpenXml.Validation;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO;

namespace DocumentFormat.OpenXml.Benchmarks
{
    public class ValidationTests
    {
        private byte[] _file;

        [GlobalSetup]
        public void SetupFile()
        {
            using (var stream = TestAssets.GetStream(TestAssets.TestFiles.complex0docx))
            using (var ms = new MemoryStream())
            {
                stream.CopyTo(ms);
                _file = ms.ToArray();
            }
        }

        [Benchmark]
        public void Validation()
        {
            using (var stream = new MemoryStream(_file))
            using (var doc = WordprocessingDocument.Open(stream, false))
            {
                var validator = new OpenXmlValidator();
                validator.Validate(doc);
            }
        }
    }
}
