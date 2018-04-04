// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Wordprocessing;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    /// <summary>
    ///This is a test class for SchemaValidatorTest and is intended
    ///to contain all SchemaValidatorTest Unit Tests
    ///</summary>
    public class SchemaValidatorTest
    {
        /// <summary>
        ///A test for Validating LeafElement.
        ///</summary>
        [Fact]
        public void LeafElementValidateTest()
        {
            string runOuterXml = "<w:r xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\">" +
            "<w:rPr><w:strike /><w:vanish><!-- comments is OK --></w:vanish><w:webHidden><w:invalidChild /></w:webHidden></w:rPr>" +
            "<w:t>Run Text.</w:t><w:t><!-- comments is ok -->Text 2</w:t><w:t>Text 3.<invalidElement /></w:t></w:r>";

            var target = new SchemaValidator(FileFormatVersions.Office2007);
            var openxmlElement = new Run(runOuterXml);
            var result = target.Validate(openxmlElement);

            Assert.Equal(2, result.Count);

            Assert.Same(openxmlElement.GetFirstChild<RunProperties>().WebHidden, result[0].Node);
            Assert.Equal("Sch_InvalidChildinLeafElement", result[0].Id);
            Assert.Equal("The element 'http://schemas.openxmlformats.org/wordprocessingml/2006/main:webHidden' is a leaf element and cannot contain children.", result[0].Description);

            Assert.Same(openxmlElement.LastChild, result[1].Node);
            Assert.Equal("Sch_InvalidChildinLeafElement", result[1].Id);
            Assert.Equal("The element 'http://schemas.openxmlformats.org/wordprocessingml/2006/main:t' is a leaf element and cannot contain children.", result[1].Description);
        }
    }
}
