// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using DocumentFormat.OpenXml.Internal.SchemaValidation;
using Xunit;
using DocumentFormat.OpenXml.Validation;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.Tests
{
    
    
    /// <summary>
    ///This is a test class for GroupParticleValidatorTest and is intended
    ///to contain all GroupParticleValidatorTest Unit Tests
    ///</summary>
    
    public class GroupParticleValidatorTest
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
        ///A test for GroupParticleValidator.TryMatch()
        ///</summary>
        [Fact]
        public void GroupParticleValidateTest()
        {
            SdbSchemaDatas sdbSchemaDatas = SdbSchemaDatas.GetOffice2007SchemaDatas();

            TestSimpleGroup(sdbSchemaDatas);
            TestSimpleGroup2(sdbSchemaDatas);
        }

        private void TestSimpleGroup(SdbSchemaDatas sdbSchemaDatas)
        {
            ValidationContext validationContext = new ValidationContext();
            ValidationResult actual = new ValidationResult();
            validationContext.ValidationErrorEventHandler += actual.OnValidationError;
            OpenXmlElement errorChild;

            Header header = new Header();
            var expected = header;
            var particleConstraint = sdbSchemaDatas.GetSchemaTypeData(header).ParticleConstraint;

            // the complex type contains a <xsd:group .../> as child
            var target = particleConstraint.ParticleValidator as GroupParticleValidator;
            validationContext.Element = header;

              //<xsd:complexType name="CT_HdrFtr">
              //  <xsd:group ref="EG_BlockLevelElts" minOccurs="1" maxOccurs="unbounded" />
              //</xsd:complexType>

              //<xs:group name="EG_BlockLevelElts">
              //  <xs:choice>
              //    <xs:group ref="EG_BlockLevelEltsBase" minOccurs="0" maxOccurs="unbounded" />
              //    <xs:group ref="EG_BlockLevelChunkElts" minOccurs="0" maxOccurs="unbounded" />
              //  </xs:choice>
              //</xs:group>

              //<xs:group name="EG_BlockLevelEltsBase">
              //  <xs:choice>
              //    <xs:element name="altChunk" type="CT_AltChunk" minOccurs="0" maxOccurs="unbounded"></xs:element>
              //  </xs:choice>
              //</xs:group>

              //<xsd:group name="EG_BlockLevelChunkElts">
              //  <xsd:choice>
              //    <xsd:group ref="EG_ContentBlockContent" minOccurs="0" maxOccurs="unbounded" />
              //  </xsd:choice>
              //</xsd:group>

              //<xs:group name="EG_ContentBlockContent">
              //  <xs:choice>
              //    <xs:group ref="EG_ContentBlockContentBase" minOccurs="0" maxOccurs="unbounded" />
              //    <xs:group ref="EG_RunLevelElts" minOccurs="0" maxOccurs="unbounded" />
              //  </xs:choice>
              //</xs:group>

              //<xs:group name="EG_ContentBlockContentBase">
              //  <xs:choice>
              //    <xs:element name="customXml" type="CT_CustomXmlBlock"></xs:element>
              //    <xs:element name="sdt" type="CT_SdtBlock"></xs:element>
              //    <xs:element name="p" type="CT_P" minOccurs="0" maxOccurs="unbounded"></xs:element>
              //    <xs:element name="tbl" type="CT_Tbl" minOccurs="0" maxOccurs="unbounded"></xs:element>
              //  </xs:choice>
              //</xs:group>


            // ***** good case ******
            // empty is ok
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // Paragraph is ok
            header.Append(new Paragraph());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // Table is ok
            header.Append(new Table());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // more Paragraph is ok
            header.Append(new Paragraph());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // Sdt is ok
            header.Append(new SdtBlock());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // altChunk is ok
            header.Append(new AltChunk());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // altChunk is ok
            header.Append(new AltChunk());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // more Paragraph is ok
            header.Append(new Paragraph());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // ***** error case ******
            //first is invalid
            errorChild = header.PrependChild(new Run());
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.True(actual.Errors[0].Description.Contains(":altChunk"));
            Assert.True(actual.Errors[0].Description.Contains(":tbl"));
            header.RemoveChild(errorChild);

            actual.Clear();
            //last is invalid
            errorChild = header.AppendChild(new Run());
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.True(actual.Errors[0].Description.Contains(":altChunk"));
            Assert.True(actual.Errors[0].Description.Contains(":tbl"));
            header.RemoveChild(errorChild);
        }

        private void TestSimpleGroup2(SdbSchemaDatas sdbSchemaDatas)
        {
            ValidationContext validationContext = new ValidationContext();
            ValidationResult actual = new ValidationResult();
            validationContext.ValidationErrorEventHandler += actual.OnValidationError;
            OpenXmlElement errorChild;

            SectionProperties sectPr = new SectionProperties();
            var expected = sectPr;
            var particleConstraint = sdbSchemaDatas.GetSchemaTypeData(sectPr).ParticleConstraint;
            var target = particleConstraint.ParticleValidator as SequenceParticleValidator;
            validationContext.Element = sectPr;
                          
              //<xsd:complexType name="CT_SectPr">
              //  <xsd:sequence>
              //    <xsd:group ref="EG_HdrFtrReferences" minOccurs="0" maxOccurs="6"></xsd:group>
              //    <xsd:group ref="EG_SectPrContents" minOccurs="0"></xsd:group>
              //    <xsd:element name="sectPrChange" type="CT_SectPrChange" minOccurs="0">
              //  </xsd:sequence>
              //  <xsd:attributeGroup ref="AG_SectPrAttributes"></xsd:attributeGroup>
              //</xsd:complexType>

              //<xsd:group name="EG_HdrFtrReferences">
              //  <xsd:choice>
              //    <xsd:element name="headerReference" type="CT_HdrFtrRef" minOccurs="0">
              //    <xsd:element name="footerReference" type="CT_HdrFtrRef" minOccurs="0">
              //  </xsd:choice>
              //</xsd:group>

              //<xsd:group name="EG_SectPrContents">
              //  <xsd:sequence>
              //    <xsd:element name="footnotePr" type="CT_FtnProps" minOccurs="0">
              //    <xsd:element name="endnotePr" type="CT_EdnProps" minOccurs="0">
              //    <xsd:element name="type" type="CT_SectType" minOccurs="0">
              //    <xsd:element name="pgSz" type="CT_PageSz" minOccurs="0">
              //    <xsd:element name="pgMar" type="CT_PageMar" minOccurs="0">
              //    <xsd:element name="paperSrc" type="CT_PaperSource" minOccurs="0">
              //    <xsd:element name="pgBorders" type="CT_PageBorders" minOccurs="0">
              //    <xsd:element name="lnNumType" type="CT_LineNumber" minOccurs="0">
              //    <xsd:element name="pgNumType" type="CT_PageNumber" minOccurs="0">
              //    <xsd:element name="cols" type="CT_Columns" minOccurs="0">
              //    <xsd:element name="formProt" type="CT_OnOff" minOccurs="0">
              //    <xsd:element name="vAlign" type="CT_VerticalJc" minOccurs="0">
              //    <xsd:element name="noEndnote" type="CT_OnOff" minOccurs="0">
              //    <xsd:element name="titlePg" type="CT_OnOff" minOccurs="0">
              //    <xsd:element name="textDirection" type="CT_TextDirection" minOccurs="0">
              //    <xsd:element name="bidi" type="CT_OnOff" minOccurs="0">
              //    <xsd:element name="rtlGutter" type="CT_OnOff" minOccurs="0">
              //    <xsd:element name="docGrid" type="CT_DocGrid" minOccurs="0">
              //    <xsd:element name="printerSettings" type="CT_Rel" minOccurs="0">
              //  </xsd:sequence>
              //</xsd:group>

            // ***** good case ******
            // empty is ok
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // headerReference is ok
            sectPr.Append(new HeaderReference());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // headerReference and footerReference
            sectPr.Append(new FooterReference());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // footerReference
            sectPr.RemoveChild(sectPr.FirstChild);
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // 3 group <= 6, ok
            sectPr.Append(new HeaderReference(), new HeaderReference());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // 5 group <= 6, ok
            sectPr.Append(new HeaderReference(), new HeaderReference());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // 6 group <= 6, ok
            sectPr.Append(new HeaderReference());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // no EG_SectPrContents is ok
            sectPr.RemoveAllChildren();
            sectPr.Append(new HeaderReference(), new FooterReference(), new SectionPropertiesChange());
            Assert.True(actual.Valid);

            // test EG_SectPrContents
            sectPr.RemoveAllChildren();
            sectPr.Append(new HeaderReference(), new FooterReference(), new SectionType());
            Assert.True(actual.Valid);

            // 
            sectPr.AppendChild(new PaperSource());
            Assert.True(actual.Valid);

            sectPr.AppendChild(new TitlePage());
            Assert.True(actual.Valid);

            sectPr.AppendChild(new PrinterSettingsReference());
            Assert.True(actual.Valid);

            sectPr.AppendChild(new SectionPropertiesChange());
            Assert.True(actual.Valid);

            sectPr.RemoveAllChildren();
            sectPr.Append(new SectionPropertiesChange());
            Assert.True(actual.Valid);

            // ***** error case ******

            // 7 group > 6, error
            sectPr.RemoveAllChildren();
            sectPr.Append(new HeaderReference(), new HeaderReference(), new FooterReference(), new FooterReference(), new HeaderReference(), new HeaderReference());
            errorChild = sectPr.AppendChild(new HeaderReference());
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.False(actual.Errors[0].Description.Contains(ValidationErrorStrings.Fmt_ListOfPossibleElements));
            sectPr.RemoveChild(errorChild);

            actual.Clear();
            //first is invalid
            errorChild = sectPr.PrependChild(new Paragraph());
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.True(actual.Errors[0].Description.Contains(":headerReference"));
            Assert.True(actual.Errors[0].Description.Contains(":footerReference"));
            Assert.False(actual.Errors[0].Description.Contains(":footnotePr"));
            Assert.False(actual.Errors[0].Description.Contains(":sectPrChange"));
            sectPr.RemoveChild(errorChild);

            actual.Clear();
            //invalid child in middle
            errorChild = sectPr.InsertBefore(new Paragraph(), sectPr.LastChild);
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.False(actual.Errors[0].Description.Contains(ValidationErrorStrings.Fmt_ListOfPossibleElements));
            sectPr.RemoveChild(errorChild);

            actual.Clear();
            // order wrong
            errorChild = sectPr.FirstChild;
            sectPr.PrependChild(new SectionType());
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.False(actual.Errors[0].Description.Contains(ValidationErrorStrings.Fmt_ListOfPossibleElements));

            actual.Clear();
            // dup error
            sectPr.RemoveAllChildren();
            sectPr.Append(new HeaderReference(), new PaperSource());
            errorChild = sectPr.AppendChild( new PaperSource());
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.False(actual.Errors[0].Description.Contains(ValidationErrorStrings.Fmt_ListOfPossibleElements));
            sectPr.RemoveChild(errorChild);

            actual.Clear();
            // out of order error
            errorChild = sectPr.AppendChild(new SectionType());
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.False(actual.Errors[0].Description.Contains(ValidationErrorStrings.Fmt_ListOfPossibleElements));
            sectPr.RemoveChild(errorChild);

            actual.Clear();
            // out of order error
            sectPr.AppendChild(new SectionPropertiesChange());
            errorChild = sectPr.AppendChild(new SectionType());
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.False(actual.Errors[0].Description.Contains(ValidationErrorStrings.Fmt_ListOfPossibleElements));
        }

    }
}
