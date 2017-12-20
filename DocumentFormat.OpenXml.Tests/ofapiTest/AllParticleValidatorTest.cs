// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.ExtendedProperties;
using DocumentFormat.OpenXml.Validation;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Vml.Office;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    public class AllParticleValidatorTest
    {
        /// <summary>
        ///A test for AllParticleValidator.Validate()
        ///</summary>
        [Fact]
        public void AllParticleValidateTest()
        {
            SdbSchemaDatas sdbSchemaDatas = SdbSchemaDatas.GetOffice2007SchemaDatas();

            TestSimpleAll(sdbSchemaDatas);
            TestSimpleAll2(sdbSchemaDatas);
        }

        private void TestSimpleAll(SdbSchemaDatas sdbSchemaDatas)
        {
            ValidationContext validationContext = new ValidationContext();
            ValidationResult actual = new ValidationResult();
            validationContext.ValidationErrorEventHandler += actual.OnValidationError;
            OpenXmlElement errorChild;

            Properties properties = new Properties();
            var particleConstraint = sdbSchemaDatas.GetSchemaTypeData(properties).ParticleConstraint;
            var target = particleConstraint.ParticleValidator as AllParticleValidator;
            validationContext.Element = properties;
            var expected = properties;

            //<xsd:complexType name="CT_Properties">
            //  <xsd:all>
            //    <xsd:element name="Template" minOccurs="0" maxOccurs="1" type="xsd:string">
            //    <xsd:element name="Manager" minOccurs="0" maxOccurs="1" type="xsd:string">
            //    <xsd:element name="Company" minOccurs="0" maxOccurs="1" type="xsd:string">
            //    <xsd:element name="Pages" minOccurs="0" maxOccurs="1" type="xsd:int">
            //    <xsd:element name="Words" minOccurs="0" maxOccurs="1" type="xsd:int">
            //    <xsd:element name="Characters" minOccurs="0" maxOccurs="1" type="xsd:int">
            //    <xsd:element name="PresentationFormat" minOccurs="0" maxOccurs="1" type="xsd:string">
            //    <xsd:element name="Lines" minOccurs="0" maxOccurs="1" type="xsd:int">
            //    <xsd:element name="Paragraphs" minOccurs="0" maxOccurs="1" type="xsd:int">
            //    <xsd:element name="Slides" minOccurs="0" maxOccurs="1" type="xsd:int">
            //    <xsd:element name="Notes" minOccurs="0" maxOccurs="1" type="xsd:int">
            //    <xsd:element name="TotalTime" minOccurs="0" maxOccurs="1" type="xsd:int">
            //    <xsd:element name="HiddenSlides" minOccurs="0" maxOccurs="1" type="xsd:int">
            //    <xsd:element name="MMClips" minOccurs="0" maxOccurs="1" type="xsd:int">
            //    <xsd:element name="ScaleCrop" minOccurs="0" maxOccurs="1" type="xsd:boolean">
            //    <xsd:element name="HeadingPairs" minOccurs="0" maxOccurs="1" type="CT_VectorVariant">
            //    <xsd:element name="TitlesOfParts" minOccurs="0" maxOccurs="1" type="CT_VectorLpstr">
            //    <xsd:element name="LinksUpToDate" minOccurs="0" maxOccurs="1" type="xsd:boolean">
            //    <xsd:element name="CharactersWithSpaces" minOccurs="0" maxOccurs="1" type="xsd:int">
            //    <xsd:element name="SharedDoc" minOccurs="0" maxOccurs="1" type="xsd:boolean">
            //    <xsd:element name="HyperlinkBase" minOccurs="0" maxOccurs="1" type="xsd:string">
            //    <xsd:element name="HLinks" minOccurs="0" maxOccurs="1" type="CT_VectorVariant">
            //    <xsd:element name="HyperlinksChanged" minOccurs="0" maxOccurs="1" type="xsd:boolean">
            //    <xsd:element name="DigSig" minOccurs="0" maxOccurs="1" type="CT_DigSigBlob">
            //    <xsd:element name="Application" minOccurs="0" maxOccurs="1" type="xsd:string">
            //    <xsd:element name="AppVersion" minOccurs="0" maxOccurs="1" type="xsd:string">
            //    <xsd:element name="DocSecurity" minOccurs="0" maxOccurs="1" type="xsd:int">
            //  </xsd:all>
            //</xsd:complexType>

            // ***** good case ******

            // empty is ok
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // any one is ok
            properties.AppendChild(new Company());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // any order is ok
            properties.AppendChild(new Template());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // any order is ok
            properties.AppendChild(new DocumentSecurity());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // any order is ok
            properties.AppendChild(new HyperlinkBase());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // ***** error case ******

            // first is invlaid
            errorChild = properties.PrependChild(new Properties());
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Single(actual.Errors);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.Contains(":Template", actual.Errors[0].Description);
            Assert.Contains(":DocSecurity", actual.Errors[0].Description);
            properties.RemoveChild(errorChild);

            actual.Clear();
            //invalid child in middle
            errorChild = properties.InsertBefore(new Properties(), properties.LastChild);
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Single(actual.Errors);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.DoesNotContain(":Template", actual.Errors[0].Description);
            Assert.Contains(":AppVersion", actual.Errors[0].Description);
            properties.RemoveChild(errorChild);

            actual.Clear();
            // dup
            errorChild = properties.FirstChild;
            properties.PrependChild(new Company());
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Single(actual.Errors);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_AllElement", actual.Errors[0].Id);
            Assert.DoesNotContain(ValidationErrorStrings.Fmt_ListOfPossibleElements, actual.Errors[0].Description);
            properties.RemoveChild(errorChild);
        }

        private void TestSimpleAll2(SdbSchemaDatas sdbSchemaDatas)
        {
            ValidationContext validationContext = new ValidationContext();
            ValidationResult actual = new ValidationResult();
            validationContext.ValidationErrorEventHandler += actual.OnValidationError;
            OpenXmlElement errorChild;

            ShapeLayout shapeLayout = new ShapeLayout();
            var particleConstraint = sdbSchemaDatas.GetSchemaTypeData(shapeLayout).ParticleConstraint;
            var target = particleConstraint.ParticleValidator as AllParticleValidator;
            validationContext.Element = shapeLayout;
            var expected = shapeLayout;

            //<xsd:complexType name="CT_ShapeLayout">
            //  <xsd:all>
            //    <xsd:element name="idmap" type="CT_IdMap" minOccurs="0">
            //    <xsd:element name="regrouptable" type="CT_RegroupTable" minOccurs="0">
            //    <xsd:element name="rules" type="CT_Rules" minOccurs="0">
            //  </xsd:all>
            //  <xsd:attributeGroup ref="v:AG_Ext" />
            //</xsd:complexType>

            // ***** good case ******

            // empty is ok
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // any one is ok
            shapeLayout.AppendChild(new RegroupTable());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // any order is ok
            shapeLayout.AppendChild(new ShapeIdMap());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // any order is ok
            shapeLayout.AppendChild(new Rules());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // ***** error case ******

            // first is invlaid
            errorChild = shapeLayout.PrependChild(new Paragraphs());
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Single(actual.Errors);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.Contains(":idmap", actual.Errors[0].Description);
            Assert.Contains(":rules", actual.Errors[0].Description);
            shapeLayout.RemoveChild(errorChild);

            actual.Clear();
            //invalid child in middle
            errorChild = shapeLayout.InsertBefore(new Paragraphs(), shapeLayout.LastChild);
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Single(actual.Errors);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.Contains(":rules", actual.Errors[0].Description);
            shapeLayout.RemoveChild(errorChild);

            actual.Clear();
            // dup
            errorChild = shapeLayout.FirstChild;
            shapeLayout.PrependChild(new RegroupTable());
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Single(actual.Errors);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_AllElement", actual.Errors[0].Id);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            shapeLayout.RemoveChild(errorChild);
        }
    }
}
