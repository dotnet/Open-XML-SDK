// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using DocumentFormat.OpenXml.Internal.SchemaValidation;
using Xunit;
using DocumentFormat.OpenXml.Validation;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace DocumentFormat.OpenXml.Tests
{
    /// <summary>
    ///This is a test class for SequenceParticleValidatorTest and is intended
    ///to contain all SequenceParticleValidatorTest Unit Tests
    ///</summary>
    
    public class SequenceParticleValidatorTest
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
        ///A test for SequenceParticleValidator.Validate
        ///</summary>
        [Fact]
        public void SequenceParticleValidateTest()
        {
            SdbSchemaDatas sdbSchemaDatas = SdbSchemaDatas.GetOffice2007SchemaDatas();

            TestSimpleSequence(sdbSchemaDatas);
            TestSimpleSequence2(sdbSchemaDatas);
            TestSimpleSequence3(sdbSchemaDatas);
            TestSimpleSequence4(sdbSchemaDatas);
        }

        private void TestSimpleSequence4(SdbSchemaDatas sdbSchemaDatas)
        {
            ValidationContext validationContext = new ValidationContext();
            ValidationResult actual = new ValidationResult();
            validationContext.ValidationErrorEventHandler += actual.OnValidationError;
            OpenXmlElement errorChild;
            ColorTransformCategories categories = new ColorTransformCategories();
            var expected = categories;
            var particleConstraint = sdbSchemaDatas.GetSchemaTypeData(categories).ParticleConstraint;
            var target = particleConstraint.ParticleValidator as SequenceParticleValidator;
            validationContext.Element = categories;

              //<xsd:complexType name="CT_CTCategories">
              //  <xsd:sequence minOccurs="0" maxOccurs="unbounded">
              //    <xsd:element name="cat" type="CT_CTCategory" minOccurs="0" maxOccurs="unbounded">
              //  </xsd:sequence>
              //</xsd:complexType>

            // ***** good case ******

            // empty is ok
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            categories.AppendChild(new ColorTransformCategory());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            categories.AppendChild(new ColorTransformCategory());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            categories.AppendChild(new ColorTransformCategory());
            target.Validate(validationContext);
            Assert.True(actual.Valid);


            // ***** error case ******

            // 1st child is invalid
            errorChild = categories.PrependChild(new Paragraph());
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.True(actual.Errors[0].Description.Contains(":cat"));

            actual.Clear();
            // last child is invalid
            categories.RemoveChild(errorChild);
            errorChild = categories.AppendChild(new Paragraph());
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.True(actual.Errors[0].Description.Contains(":cat"));

            actual.Clear();
            // 2nd child is invalid
            categories.RemoveChild(errorChild);
            errorChild = categories.InsertAfter(new Paragraph(), categories.FirstChild);
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.True(actual.Errors[0].Description.Contains(":cat"));

            actual.Clear();
            // 3rd child is invalid
            categories.RemoveChild(errorChild);
            errorChild = categories.InsertBefore(new Paragraph(), categories.LastChild);
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.True(actual.Errors[0].Description.Contains(":cat"));

            actual.Clear();
            // only one invalid child
            categories.RemoveAllChildren();
            errorChild = categories.AppendChild(new Paragraph());
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.True(actual.Errors[0].Description.Contains(":cat"));
        }

        private void TestSimpleSequence3(SdbSchemaDatas sdbSchemaDatas)
        {
            ValidationContext validationContext = new ValidationContext();
            ValidationResult actual = new ValidationResult();
            validationContext.ValidationErrorEventHandler += actual.OnValidationError;
            Divs divs = new Divs();
            OpenXmlElement errorChild;

            var particleConstraint = sdbSchemaDatas.GetSchemaTypeData(divs).ParticleConstraint;
            var target = particleConstraint.ParticleValidator as SequenceParticleValidator;
            validationContext.Element = divs;
            var expected = divs;
       
              //<xsd:complexType name="CT_Divs">
              //  <xsd:sequence minOccurs="1" maxOccurs="unbounded">
              //    <xsd:element name="div" type="CT_Div">
              //  </xsd:sequence>
              //</xsd:complexType

            // ***** good case ******
            divs.AppendChild(new Div());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            divs.AppendChild(new Div());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            divs.AppendChild(new Div());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // ***** error case ******

            // 1st child is invalid
            errorChild = divs.PrependChild(new Paragraph());
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.True(actual.Errors[0].Description.Contains(":div"));

            actual.Clear();
            // last child is invalid
            divs.RemoveChild(errorChild);
            errorChild = divs.AppendChild(new Paragraph());
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.True(actual.Errors[0].Description.Contains(":div"));

            actual.Clear();
            // 2nd child is invalid
            divs.RemoveChild(errorChild);
            errorChild = divs.InsertAfter(new Paragraph(), divs.FirstChild);
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.True(actual.Errors[0].Description.Contains(":div"));

            actual.Clear();
            // 3rd child is invalid
            divs.RemoveChild(errorChild);
            errorChild = divs.InsertBefore(new Paragraph(), divs.LastChild);
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.True(actual.Errors[0].Description.Contains(":div"));

            actual.Clear();
            // empty,
            divs.RemoveAllChildren();
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_IncompleteContentExpectingComplex", actual.Errors[0].Id);
            Assert.True(actual.Errors[0].Description.Contains(":div"));

            actual.Clear();
            // only one invalid child
            errorChild = divs.AppendChild(new Paragraph());
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.True(actual.Errors[0].Description.Contains(":div"));
        }

        private void TestSimpleSequence2(SdbSchemaDatas sdbSchemaDatas)
        {
            ValidationContext validationContext = new ValidationContext();
            ValidationResult actual = new ValidationResult();
            validationContext.ValidationErrorEventHandler += actual.OnValidationError;
            Ruby ruby = new Ruby();
            OpenXmlElement errorChild;

            var particleConstraint = sdbSchemaDatas.GetSchemaTypeData(ruby).ParticleConstraint;
            var target = particleConstraint.ParticleValidator as SequenceParticleValidator;
            validationContext.Element = ruby;
            var expected = ruby;
            //<xsd:complexType name="CT_Ruby">
            //  <xsd:sequence>
            //    <xsd:element name="rubyPr" type="CT_RubyPr">
            //    <xsd:element name="rt" type="CT_RubyContent">
            //    <xsd:element name="rubyBase" type="CT_RubyContent">
            //  </xsd:sequence>
            //</xsd:complexType>}

            // ***** good case ******
            ruby.Append(new RubyProperties(), new RubyContent(), new RubyBase());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // ***** error case ******

            // No RubyBase child, incomplete error
            ruby.RemoveChild(ruby.LastChild);
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_IncompleteContentExpectingComplex", actual.Errors[0].Id);
            Assert.True(actual.Errors[0].Description.Contains(":rubyBase"));

            actual.Clear();
            // No RubyContent child, incomplete error
            ruby.RemoveChild(ruby.LastChild);
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_IncompleteContentExpectingComplex", actual.Errors[0].Id);
            Assert.True(actual.Errors[0].Description.Contains(":rt"));

            actual.Clear();
            // Empty, incomplete error
            ruby.RemoveChild(ruby.LastChild);
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_IncompleteContentExpectingComplex", actual.Errors[0].Id);
            Assert.True(actual.Errors[0].Description.Contains(":rubyPr"));

            actual.Clear();
            // No RubyContent child, incomplete error
            ruby.Append(new RubyProperties(), new RubyBase());
            errorChild = ruby.LastChild;
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.True(actual.Errors[0].Description.Contains(":rt"));

            actual.Clear();
            // No RubyProperties child, incomplete error
            ruby.RemoveAllChildren();
            ruby.Append(new RubyContent(), new RubyBase());
            errorChild = ruby.FirstChild;
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.True(actual.Errors[0].Description.Contains(":rubyPr"));

            actual.Clear();
            // first should be RubyProperties()
            ruby.PrependChild(new RubyContent());
            errorChild = ruby.FirstChild;
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.True(actual.Errors[0].Description.Contains(":rubyPr"));

            actual.Clear();
            // 2nd and 3rd are same element, error
            errorChild = ruby.FirstChild.NextSibling();
            ruby.PrependChild(new RubyProperties());
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.True(actual.Errors[0].Description.Contains(":rt"));
        }

        private void TestSimpleSequence(SdbSchemaDatas sdbSchemaDatas)
        {
            ValidationContext validationContext = new ValidationContext();
            ValidationResult actual = new ValidationResult();
            validationContext.ValidationErrorEventHandler += actual.OnValidationError;

            //<xsd:complexType name="CT_FFDDList">
            //  <xsd:sequence>
            //    <xsd:element name="result" type="CT_DecimalNumber" minOccurs="0">
            //    <xsd:element name="default" type="CT_DecimalNumber" minOccurs="0">
            //    <xsd:element name="listEntry" type="CT_String" minOccurs="0" maxOccurs="unbounded">
            //  </xsd:sequence>
            //</xsd:complexType>
            DropDownListFormField ddList = new DropDownListFormField();
            var particleConstraint = sdbSchemaDatas.GetSchemaTypeData(ddList).ParticleConstraint;
            var target = particleConstraint.ParticleValidator as SequenceParticleValidator;

            validationContext.Element = ddList;

            // ***** good case ******
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            ddList.AppendChild(new DropDownListSelection());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            ddList.AppendChild(new DefaultDropDownListItemIndex());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            ddList.AppendChild(new ListEntryFormField());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            ddList.AppendChild(new ListEntryFormField());
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // ***** error case ******
            ddList = new DropDownListFormField();
            validationContext.Element = ddList;
            var expected = ddList;

            // invalid child
            OpenXmlElement errorChild = ddList.AppendChild(new Paragraph());
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.True(actual.Errors[0].Description.Contains(":result"));

            actual.Clear();
            // 2nd child is invalid
            ddList.PrependChild(new DropDownListSelection());
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.False(actual.Errors[0].Description.Contains(ValidationErrorStrings.Fmt_ListOfPossibleElements));

            actual.Clear();
            // the sequence of the first 2 children are wrong
            errorChild = ddList.FirstChild;
            ddList.PrependChild(new DefaultDropDownListItemIndex());
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.False(actual.Errors[0].Description.Contains(ValidationErrorStrings.Fmt_ListOfPossibleElements));

            actual.Clear();
            // 1st and 2nd are same type, maxOccurs error
            errorChild = ddList.FirstChild;
            ddList.PrependChild(new DefaultDropDownListItemIndex());
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.False(actual.Errors[0].Description.Contains(ValidationErrorStrings.Fmt_ListOfPossibleElements));

            actual.Clear();
            // the 2nd and 3rd are same type, maxOccurs error
            ddList.PrependChild(new DropDownListSelection());
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.False(actual.Errors[0].Description.Contains(ValidationErrorStrings.Fmt_ListOfPossibleElements));

            actual.Clear();
            // expectedNode are now the 4th, the first 3 are OK.
            ddList.InsertAfter(new ListEntryFormField(), errorChild);
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
