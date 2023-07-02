// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using BenchmarkDotNet.Attributes;

using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Equality;
using DocumentFormat.OpenXml.Spreadsheet;

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Benchmarks
{
    public class EqualityBenchmark
    {
        private const string FontXml = "<x:font xmlns:x=\"http://schemas.openxmlformats.org/spreadsheetml/2006/main\"><x:sz val=\"11\" /><x:name val=\"Calibri\" /><x:family val=\"2\" /><x:scheme val=\"minor\" /></x:font>";

        private OpenXmlElement _largeElement;
        private OpenXmlElement _largeElement2;

        private OpenXmlElement _smallElementUnParsed;
        private OpenXmlElement _smallElement2UnParsed;

        private OpenXmlElement _smallElementParsed;
        private OpenXmlElement _smallElement2Parsed;

        private IEqualityComparer<OpenXmlElement> _defaultEqualityComparer = OpenXmlElementEqualityComparer.Default;
        private IEqualityComparer<OpenXmlElement> _fast = OpenXmlElementEqualityComparer.GetEqualityComparer(OpenXmlElementEqualityOptions.Default | OpenXmlElementEqualityOptions.CompareNamespaceInsteadOfPrefix);

        [GlobalSetup]
        public void Setup()
        {
            var rand = new Random(1234567);

            var textBody = new TextBody();
            var textBody2 = new TextBody();
            for (int i = 0; i < 200; i++)
            {
                var paragraph = new Paragraph();
                var paragraph2 = new Paragraph();
                for (int j = 0; j < 100; j++)
                {
                    string txt = new string('a', rand.Next(0, 10));
                    paragraph.AppendChild(new Drawing.Run() { Text = new Drawing.Text(txt) });
                    paragraph2.AppendChild(new Drawing.Run() { Text = new Drawing.Text(txt) });

                    paragraph.AppendChild(new Drawing.Field() { Id = new StringValue(txt) });
                    paragraph2.AppendChild(new Drawing.Field() { Id = new StringValue(txt) });
                }

                textBody.AppendChild(paragraph);
                textBody2.AppendChild(paragraph2);
            }

            _largeElement = textBody;
            _largeElement2 = textBody2;

            _smallElementUnParsed = new Font(FontXml);
            _smallElement2UnParsed = new Font(FontXml);

            _smallElementParsed = new Font(FontXml);
            _smallElementParsed.MakeSureParsed();

            _smallElement2Parsed = new Font(FontXml);
            _smallElement2Parsed.MakeSureParsed();
        }

        [Benchmark]
        public bool OuterXmlLargeElement()
        {
            return _largeElement.OuterXml.Equals(_largeElement2.OuterXml);
        }

        [Benchmark]
        public bool EqualsLargeElement()
        {
            return _defaultEqualityComparer.Equals(_largeElement, _largeElement2);
        }

        [Benchmark]
        public bool EqualsLargeElementSkipPrefix()
        {
            return _fast.Equals(_largeElement, _largeElement2);
        }

        [Benchmark]
        public bool UnparsedOuterXml()
        {
            return _smallElementUnParsed.OuterXml.Equals(_smallElement2UnParsed.OuterXml);
        }

        [Benchmark]
        public bool UnparsedEquals()
        {
            return _defaultEqualityComparer.Equals(_smallElementUnParsed, _smallElement2UnParsed);
        }

        [Benchmark]
        public bool SmallOuterXml()
        {
            return _smallElementParsed.OuterXml.Equals(_smallElement2Parsed.OuterXml);
        }

        [Benchmark]
        public bool SmallEquals()
        {
            return _defaultEqualityComparer.Equals(_smallElementParsed, _smallElement2Parsed);
        }

        [Benchmark]
        public bool SmallEqualsSkipPrefix()
        {
            return _fast.Equals(_smallElementParsed, _smallElement2Parsed);
        }
    }
}
