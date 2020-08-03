// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using BenchmarkDotNet.Attributes;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Tests;
using DocumentFormat.OpenXml.Validation;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DocumentFormat.OpenXml.Benchmarks
{
    public class OpenXmlElementDescendantsTests
    {
        [GlobalSetup]
        public void Setup()
        {
            var textBody = new TextBody();
            for (int i = 0; i < 1000; i++)
            {
                var paragraph = new Paragraph();
                for (int j = 0; j < 1000; j++)
                {
                    paragraph.AppendChild(new Run());
                }

                textBody.AppendChild(paragraph);
            }

            _element = textBody;
        }

        [Benchmark]
        public List<OpenXmlElement> Descendants()
        {
            var list = _element.Descendants().ToList();
            return list;
        }

        [Benchmark]
        public List<OpenXmlElement> OldDescendants()
        {
            var list = _element.OldDescendants().ToList();
            return list;
        }

        private OpenXmlElement _element;
    }
}
