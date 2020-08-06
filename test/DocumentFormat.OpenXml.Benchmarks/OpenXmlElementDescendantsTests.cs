// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using BenchmarkDotNet.Attributes;
using DocumentFormat.OpenXml.Drawing;
using System.Collections.Generic;
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
            return _element.Descendants().ToList();
        }

        private OpenXmlElement _element;
    }
}
