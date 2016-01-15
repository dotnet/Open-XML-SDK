// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using DocumentFormat.OpenXml;
using Xunit;
using DocumentFormat.OpenXml.Packaging;
using System.IO;
using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentFormat.OpenXml.Tests
{
    
    
    /// <summary>
    ///This is a test class for OpenXmlPartWriterTest and is intended
    ///to contain all OpenXmlPartWriterTest Unit Tests
    ///</summary>
    
    public class OpenXmlWriterTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        /// <summary>
        ///A test for WriteString
        ///</summary>
        [Fact]
        public void WriteStringTest()
        {
            using (var memStream = new MemoryStream())
            using (OpenXmlPartWriter target = new OpenXmlPartWriter(memStream))
            {
                string text = "abc";
                target.WriteStartDocument();
                target.WriteStartElement(new Run());

                target.WriteStartElement(new Text());
                target.WriteString(text);
                target.WriteEndElement();

                var textElement = new Text();
                textElement.Space = new EnumValue<SpaceProcessingModeValues>();
                textElement.Space.Value = SpaceProcessingModeValues.Preserve;
                target.WriteStartElement(new Text(), textElement.GetAttributes());
                target.WriteString(text);
                target.WriteString(text);
                target.WriteEndElement();

                var run = new Run(new Text("111"), new Text("222"));
                using (var reader = OpenXmlReader.Create(run))
                {
                    reader.Read();
                    reader.Read();
                    target.WriteStartElement(reader);
                    target.WriteString(reader.GetText());
                    reader.Read();
                    target.WriteEndElement();

                    reader.Read();
                    target.WriteStartElement(reader, textElement.GetAttributes());
                    target.WriteString(reader.GetText());
                    target.WriteString(text);
                    reader.Read();
                    target.WriteEndElement();

                    reader.Close();
                }
                target.Close();
            }
        }

        /// <summary>
        ///A test for WriteString
        ///</summary>
        [Fact]
        public void WriteStringExceptionTest()
        {
            using (var memStream = new MemoryStream())
            using (OpenXmlPartWriter target = new OpenXmlPartWriter(memStream))
            {
                string text = "abc";
                target.WriteStartDocument();
                target.WriteStartElement(new Run());

                target.WriteStartElement(new RunProperties());
                Assert.Throws<System.InvalidOperationException>(() =>
                    {
                        target.WriteString(text); // exception
                    });
            }
        }

        /// <summary>
        ///A test for WriteString
        ///</summary>
        [Fact]
        public void WriteStringExceptionTest2()
        {
            using (var memStream = new MemoryStream())
            using (OpenXmlPartWriter target = new OpenXmlPartWriter(memStream))
            {
                string text = "abc";
                target.WriteStartDocument();
                target.WriteStartElement(new Run());

                var textElement = new Text();
                textElement.Space = SpaceProcessingModeValues.Preserve;
                target.WriteStartElement(new RunProperties(), textElement.GetAttributes());
                Assert.Throws<System.InvalidOperationException>(() =>
                    {
                        target.WriteString(text); // exception
                    });
            }
        }

        /// <summary>
        ///A test for WriteString
        ///</summary>
        [Fact]
        public void WriteStringExceptionTest3()
        {
            using (var memStream = new MemoryStream())
            using (OpenXmlPartWriter target = new OpenXmlPartWriter(memStream))
            {
                string text = "abc";
                target.WriteStartDocument();
                target.WriteStartElement(new Run());

                var textElement = new Text();
                textElement.Space = SpaceProcessingModeValues.Preserve;
                target.WriteStartElement(new Text());
                target.WriteString(text);
                target.WriteEndElement();
                Assert.Throws<System.InvalidOperationException>(() =>
                    {
                        target.WriteString(text); // exception
                    });
            }
        }

        /// <summary>
        ///A test for WriteString
        ///</summary>
        [Fact]
        public void WriteStringExceptionTest4()
        {
            using (var memStream = new MemoryStream())
            using (OpenXmlPartWriter target = new OpenXmlPartWriter(memStream))
            {
                string text = "abc";
                target.WriteStartDocument();
                target.WriteStartElement(new Run());

                var run = new Run(new Text("111"), new Text("222"));
                using (var reader = OpenXmlReader.Create(run))
                {
                    reader.Read();
                    reader.Read();
                    target.WriteStartElement(reader);
                    target.WriteString(reader.GetText());
                    reader.Read();
                    target.WriteEndElement();
                    Assert.Throws<System.InvalidOperationException>(() =>
                        {
                            target.WriteString(text);  // exception
                        });

                    reader.Close();
                }
            }
        }

        /// <summary>
        ///A test for WriteString
        ///</summary>
        [Fact]
        public void WriteStringExceptionTest5()
        {
            using (var memStream = new MemoryStream())
            using (OpenXmlPartWriter target = new OpenXmlPartWriter(memStream))
            {
                string text = "abc";
                target.WriteStartDocument();
                target.WriteStartElement(new Run());

                var run = new Run(new RunProperties(), new Text("222"));
                using (var reader = OpenXmlReader.Create(run))
                {
                    reader.Read();
                    reader.Read();
                    target.WriteStartElement(reader);
                    Assert.Throws<System.InvalidOperationException>(() =>
                        {
                            target.WriteString(text); // exception
                        });
                    reader.Read();
                    target.WriteEndElement();
                }
            }
        }

        /// <summary>
        ///A test for WriteString
        ///</summary>
        [Fact]
        public void WriteStringExceptionTest6()
        {
            using (var memStream = new MemoryStream())
            using (OpenXmlPartWriter target = new OpenXmlPartWriter(memStream))
            {
                string text = "abc";
                target.WriteStartDocument();
                target.WriteStartElement(new Run());

                var textElement = new Text();
                textElement.Space = SpaceProcessingModeValues.Preserve;
                target.WriteStartElement(new RunProperties(), textElement.GetAttributes());
                target.WriteEndElement();
                target.Close();
                Assert.Throws<System.InvalidOperationException>(() =>
                {
                    target.WriteString(text); // exception
                });
            }
        }

        /// <summary>
        ///A test for WriteString
        ///</summary>
        [Fact]
        public void WriteStringExceptionTest7()
        {
            using (var memStream = new MemoryStream())
            using (OpenXmlPartWriter target = new OpenXmlPartWriter(memStream))
            {
                string text = "abc";
                target.WriteStartDocument();

                Assert.Throws<System.InvalidOperationException>(() =>
                {
                    target.WriteString(text); // exception
                });
            }
        }
    }
}
