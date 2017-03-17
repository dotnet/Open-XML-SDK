// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using DocumentFormat.OpenXml.Internal.SchemaValidation;
using Xunit;
using DocumentFormat.OpenXml.Validation;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;
using Drawing = DocumentFormat.OpenXml.Drawing;

namespace DocumentFormat.OpenXml.Tests
{
    
    
    /// <summary>
    ///This is a test class for CompositeParticleValidatorTest and is intended
    ///to contain all CompositeParticleValidatorTest Unit Tests
    ///</summary>
    
    public class CompositeParticleValidatorTest
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

        internal virtual CompositeParticleValidator CreateCompositeParticleValidator()
        {
            // TODO: Instantiate an appropriate concrete class.
            CompositeParticleValidator target = null;
            return target;
        }

        /// <summary>
        ///A test for CompositeParticleValidator.Validate()
        ///</summary>
        [Fact]
        public void CompositeParticleValidateTest()
        {
            SdbSchemaDatas sdbSchemaDatas = SdbSchemaDatas.GetOffice2007SchemaDatas();

            // TODO: unit test for some types
            ValidatePpr(sdbSchemaDatas);
            ValidateBody(sdbSchemaDatas);
            ValidateBlip(sdbSchemaDatas);
        }


        private void ValidatePpr(SdbSchemaDatas sdbSchemaDatas)
        {
            ValidationContext validationContext = new ValidationContext();
            ValidationResult actual = new ValidationResult();
            validationContext.ValidationErrorEventHandler += actual.OnValidationError;
            OpenXmlElement errorChild;

            ParagraphProperties pPr = new ParagraphProperties();
            var particleConstraint = sdbSchemaDatas.GetSchemaTypeData(pPr).ParticleConstraint;
            var target = particleConstraint.ParticleValidator as ParticleValidator;
            validationContext.Element = pPr;
            var expected = pPr;

              //<xsd:complexType name="CT_PPr">
              //  <xsd:complexContent>
              //    <xsd:extension base="CT_PPrBase">
              //      <xsd:sequence>
              //        <xsd:element name="rPr" type="CT_ParaRPr" minOccurs="0">
              //        <xsd:element name="sectPr" type="CT_SectPr" minOccurs="0">
              //        <xsd:element name="pPrChange" type="CT_PPrChange" minOccurs="0">
              //      </xsd:sequence>
              //    </xsd:extension>
              //  </xsd:complexContent>
              //</xsd:complexType>

              //<xsd:complexType name="CT_PPrBase">
              //  <xsd:sequence>
              //    <xsd:element name="pStyle" type="CT_String" minOccurs="0">
              //    <xsd:element name="keepNext" type="CT_OnOff" minOccurs="0">
              //    <xsd:element name="keepLines" type="CT_OnOff" minOccurs="0">
              //    <xsd:element name="pageBreakBefore" type="CT_OnOff" minOccurs="0">
              //    <xsd:element name="framePr" type="CT_FramePr" minOccurs="0">
              //    <xsd:element name="widowControl" type="CT_OnOff" minOccurs="0">
              //    <xsd:element name="numPr" type="CT_NumPr" minOccurs="0">
              //    <xsd:element name="suppressLineNumbers" type="CT_OnOff" minOccurs="0">
              //    <xsd:element name="pBdr" type="CT_PBdr" minOccurs="0">
              //    <xsd:element name="shd" type="CT_Shd" minOccurs="0">
              //    <xsd:element name="tabs" type="CT_Tabs" minOccurs="0">
              //    <xsd:element name="suppressAutoHyphens" type="CT_OnOff" minOccurs="0">
              //    <xsd:element name="kinsoku" type="CT_OnOff" minOccurs="0">
              //    <xsd:element name="wordWrap" type="CT_OnOff" minOccurs="0">
              //    <xsd:element name="overflowPunct" type="CT_OnOff" minOccurs="0">
              //    <xsd:element name="topLinePunct" type="CT_OnOff" minOccurs="0">
              //    <xsd:element name="autoSpaceDE" type="CT_OnOff" minOccurs="0">
              //    <xsd:element name="autoSpaceDN" type="CT_OnOff" minOccurs="0">
              //    <xsd:element name="bidi" type="CT_OnOff" minOccurs="0">
              //    <xsd:element name="adjustRightInd" type="CT_OnOff" minOccurs="0">
              //    <xsd:element name="snapToGrid" type="CT_OnOff" minOccurs="0">
              //    <xsd:element name="spacing" type="CT_Spacing" minOccurs="0">
              //    <xsd:element name="ind" type="CT_Ind" minOccurs="0">
              //    <xsd:element name="contextualSpacing" type="CT_OnOff" minOccurs="0">
              //    <xsd:element name="mirrorIndents" type="CT_OnOff" minOccurs="0">
              //    <xsd:element name="suppressOverlap" type="CT_OnOff" minOccurs="0">
              //    <xsd:element name="jc" type="CT_Jc" minOccurs="0">
              //    <xsd:element name="textDirection" type="CT_TextDirection" minOccurs="0">
              //    <xsd:element name="textAlignment" type="CT_TextAlignment" minOccurs="0">
              //    <xsd:element name="textboxTightWrap" type="CT_TextboxTightWrap" minOccurs="0">
              //    <xsd:element name="outlineLvl" type="CT_DecimalNumber" minOccurs="0">
              //    <xsd:element name="divId" type="CT_DecimalNumber" minOccurs="0">
              //    <xsd:element name="cnfStyle" type="CT_Cnf" minOccurs="0" maxOccurs="1">
              //  </xsd:sequence>
              //</xsd:complexType>

            // ***** good case ******

            // empty is ok
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // 
            pPr.AppendChild(new KeepLines());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // 
            pPr.AppendChild(new Tabs());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // 
            pPr.AppendChild(new Kinsoku());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // 
            pPr.AppendChild(new OutlineLevel());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // 
            pPr.AppendChild(new ConditionalFormatStyle());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // 
            pPr.AppendChild(new ParagraphMarkRunProperties());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // 
            pPr.AppendChild(new SectionProperties());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // 
            pPr.AppendChild(new ParagraphPropertiesChange());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // ***** error case ******

            // SectionProperties dup error
            errorChild = pPr.AppendChild(new SectionProperties());
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.False(actual.Errors[0].Description.Contains(ValidationErrorStrings.Fmt_ListOfPossibleElements));
            pPr.RemoveChild(errorChild);

            actual.Clear();
            // SectionProperties order wrong
            errorChild = pPr.FirstChild;
            pPr.PrependChild(new SectionProperties());
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.False(actual.Errors[0].Description.Contains(ValidationErrorStrings.Fmt_ListOfPossibleElements));
            pPr.RemoveChild(pPr.FirstChild);

        }

        private void ValidateBody(SdbSchemaDatas sdbSchemaDatas)
        {
            ValidationContext validationContext = new ValidationContext();
            ValidationResult actual = new ValidationResult();
            validationContext.ValidationErrorEventHandler += actual.OnValidationError;
            OpenXmlElement errorChild;

            Body body = new Body();
            var particleConstraint = sdbSchemaDatas.GetSchemaTypeData(body).ParticleConstraint;
            var target = particleConstraint.ParticleValidator as ParticleValidator;
            validationContext.Element = body;
            var expected = body;

              //<xsd:complexType name="CT_Body">
              //  <xsd:sequence>
              //    <xsd:group ref="EG_BlockLevelElts" minOccurs="0" maxOccurs="unbounded" />
              //    <xsd:element name="sectPr" minOccurs="0" maxOccurs="1" type="CT_SectPr">
              //  </xsd:sequence>
              //</xsd:complexType>

              //<xs:group name="EG_BlockLevelEltsBase">
              //  <xs:choice>
              //    <xs:element name="altChunk" type="CT_AltChunk" minOccurs="0" maxOccurs="unbounded"></xs:element>
              //  </xs:choice>
              //</xs:group>

              //<xs:group name="EG_BlockLevelElts">
              //  <xs:choice>
              //    <xs:group ref="EG_BlockLevelEltsBase" minOccurs="0" maxOccurs="unbounded" />
              //    <xs:group ref="EG_BlockLevelChunkElts" minOccurs="0" maxOccurs="unbounded" />
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

              //<xs:group name="EG_RunLevelElts">
              //  <xs:choice>
              //    <xs:group ref="EG_RunLevelEltsBase" minOccurs="0" maxOccurs="unbounded" />
              //    <xs:group ref="EG_RangeMarkupElements" minOccurs="0" maxOccurs="unbounded"></xs:group>
              //    <xs:element name="ins" type="CT_RunTrackChange" minOccurs="0">
              //    <xs:element name="del" type="CT_RunTrackChange" minOccurs="0">
              //    <xs:element name="moveFrom" type="CT_RunTrackChange">
              //    <xs:element name="moveTo" type="CT_RunTrackChange">
              //    <xs:element name="contentPart" type="CT_ContentPart" minOccurs="0" maxOccurs="unbounded" ofapi:available="o14" />
              //    <xs:group ref="w14:EG_RunLevelConflicts" minOccurs="0" />
              //  </xs:choice>
              //</xs:group>

              //<xs:group name="EG_RunLevelEltsBase">
              //  <xs:choice>
              //    <xs:element name="proofErr" minOccurs="0" type="CT_ProofErr"></xs:element>
              //    <xs:element name="permStart" minOccurs="0" type="CT_PermStart"></xs:element>
              //    <xs:element name="permEnd" minOccurs="0" type="CT_Perm"></xs:element>
              //  </xs:choice>
              //</xs:group>

              //<xs:group name="EG_RangeMarkupElements">
              //  <xs:choice>
              //    <xs:group ref="EG_RangeMarkupElementsNoRev" minOccurs="0" maxOccurs="unbounded" />
              //    <xs:group ref="EG_RangeMarkupElementsRev" minOccurs="0" maxOccurs="unbounded" />
              //    <xs:element ref="w14:customXmlConflictInsRangeStart" minOccurs="0" />
              //    <xs:element ref="w14:customXmlConflictInsRangeEnd" minOccurs="0" />
              //    <xs:element ref="w14:customXmlConflictDelRangeStart" minOccurs="0" />
              //    <xs:element ref="w14:customXmlConflictDelRangeEnd" minOccurs="0" />
              //  </xs:choice>
              //</xs:group>

              //<xsd:group name="EG_MathContent">
              //  <xsd:choice>
              //    <xsd:element ref="m:oMathPara"></xsd:element>
              //    <xsd:element ref="m:oMath"></xsd:element>
              //  </xsd:choice>
              //</xsd:group>

            // ################ the above schema has been changed by EcmaD ##############

            // ***** good case ******

            // empty is ok
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // 
            body.AppendChild(new SectionProperties());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            body.PrependChild(new AltChunk());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // multiple AltChunk is ok
            body.PrependChild(new AltChunk());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            body.InsertAfter(new Paragraph(), body.FirstChild);
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            body.PrependChild(new MoveFromRangeStart());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            body.PrependChild(new MoveFromRun());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            body.PrependChild(new MoveFromRun());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            body.PrependChild(new MoveFromRangeStart());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            body.InsertAfter(new Paragraph(), body.FirstChild);
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // ***** error case ******
            // sectProperties can not be the first
            errorChild = body.FirstChild;
            body.PrependChild(new SectionProperties());
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.False(actual.Errors[0].Description.Contains(ValidationErrorStrings.Fmt_ListOfPossibleElements));
            body.RemoveChild(body.FirstChild);

            actual.Clear();
            // can only have one sectProperties at last
            errorChild = body.AppendChild(new SectionProperties());
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.False(actual.Errors[0].Description.Contains(ValidationErrorStrings.Fmt_ListOfPossibleElements));
            body.RemoveChild(errorChild);

            actual.Clear();
            // paragrap can be after sectProperties at last
            errorChild = body.AppendChild(new Paragraph());
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.False(actual.Errors[0].Description.Contains(ValidationErrorStrings.Fmt_ListOfPossibleElements));
            body.RemoveChild(errorChild);

            actual.Clear();
            // first is invalid
            errorChild = body.PrependChild(new Run());
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.True(actual.Errors[0].Description.Contains(":altChunk"));
            body.RemoveChild(errorChild);

            actual.Clear();
            // invalid child in middle
            errorChild = body.InsertBefore(new Run(), body.LastChild);
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.False(actual.Errors[0].Description.Contains(ValidationErrorStrings.Fmt_ListOfPossibleElements));
            body.RemoveChild(errorChild);
        }

        private void ValidateBlip(SdbSchemaDatas sdbSchemaDatas)
        {
            ValidationContext validationContext = new ValidationContext();
            ValidationResult actual = new ValidationResult();
            validationContext.ValidationErrorEventHandler += actual.OnValidationError;
            OpenXmlElement errorChild;

            Drawing.Blip blip = new Drawing.Blip();
            var particleConstraint = sdbSchemaDatas.GetSchemaTypeData(blip).ParticleConstraint;
            var target = particleConstraint.ParticleValidator as ParticleValidator;
            validationContext.Element = blip;
            var expected = blip;

            //<xsd:complexType name="CT_Blip">
            //  <xsd:sequence>
            //    <xsd:choice minOccurs="0" maxOccurs="unbounded">
            //      <xsd:element name="alphaBiLevel" type="CT_AlphaBiLevelEffect" minOccurs="1" maxOccurs="1">
            //      <xsd:element name="alphaCeiling" type="CT_AlphaCeilingEffect" minOccurs="1" maxOccurs="1" />
            //      <xsd:element name="alphaFloor" type="CT_AlphaFloorEffect" minOccurs="1" maxOccurs="1" />
            //      <xsd:element name="alphaInv" type="CT_AlphaInverseEffect" minOccurs="1" maxOccurs="1" />
            //      <xsd:element name="alphaMod" type="CT_AlphaModulateEffect" minOccurs="1" maxOccurs="1" />
            //      <xsd:element name="alphaModFix" type="CT_AlphaModulateFixedEffect" minOccurs="1" maxOccurs="1">
            //      <xsd:element name="alphaRepl" type="CT_AlphaReplaceEffect" minOccurs="1" maxOccurs="1" />
            //      <xsd:element name="biLevel" type="CT_BiLevelEffect" minOccurs="1" maxOccurs="1">
            //      <xsd:element name="blur" type="CT_BlurEffect" minOccurs="1" maxOccurs="1" />
            //      <xsd:element name="clrChange" type="CT_ColorChangeEffect" minOccurs="1" maxOccurs="1" />
            //      <xsd:element name="clrRepl" type="CT_ColorReplaceEffect" minOccurs="1" maxOccurs="1">
            //      <xsd:element name="duotone" type="CT_DuotoneEffect" minOccurs="1" maxOccurs="1" />
            //      <xsd:element name="fillOverlay" type="CT_FillOverlayEffect" minOccurs="1" maxOccurs="1" />
            //      <xsd:element name="grayscl" type="CT_GrayscaleEffect" minOccurs="1" maxOccurs="1" />
            //      <xsd:element name="hsl" type="CT_HSLEffect" minOccurs="1" maxOccurs="1" />
            //      <xsd:element name="lum" type="CT_LuminanceEffect" minOccurs="1" maxOccurs="1">
            //      <xsd:element name="tint" type="CT_TintEffect" minOccurs="1" maxOccurs="1">
            //    </xsd:choice>
            //    <xsd:element name="extLst" type="CT_OfficeArtExtensionList" minOccurs="0" maxOccurs="1"></xsd:element>
            //  </xsd:sequence>
            //  <xsd:attributeGroup ref="AG_Blob"></xsd:attributeGroup>
            //  <xsd:attribute name="cstate" type="ST_BlipCompression" use="optional" default="none">
            //</xsd:complexType>
            // ***** good case ******

            // empty is ok
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // 
            blip.AppendChild(new Drawing.LuminanceEffect());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            blip.AppendChild(new Drawing.LuminanceEffect());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            blip.AppendChild(new Drawing.AlphaBiLevel());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            blip.AppendChild(new Drawing.Blur());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            blip.AppendChild(new Drawing.BiLevel());
            target.Validate(validationContext);
            Assert.True(actual.Valid);
            
            blip.AppendChild(new Drawing.BlipExtensionList());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // ***** error case ******
            // ExtensionList can not be the first
            errorChild = blip.FirstChild;
            blip.PrependChild(new Drawing.BlipExtensionList());
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.False(actual.Errors[0].Description.Contains(ValidationErrorStrings.Fmt_ListOfPossibleElements));
            blip.RemoveChild(blip.FirstChild);

            actual.Clear();
            // can only have one ExtensionList at last
            errorChild = blip.AppendChild(new Drawing.BlipExtensionList());
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.False(actual.Errors[0].Description.Contains(ValidationErrorStrings.Fmt_ListOfPossibleElements));
            blip.RemoveChild(errorChild);
        }
    }
}
