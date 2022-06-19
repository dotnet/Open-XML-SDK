// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Validation;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Wordprocessing;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    /// <summary>
    /// This is a test class for SequenceParticleValidatorTest and is intended
    /// to contain all SequenceParticleValidatorTest Unit Tests
    /// </summary>
    public class SequenceParticleValidatorTest
    {
        private const FileFormatVersions Version = FileFormatVersions.Office2007;

        [Fact]
        public void TestSimpleSequence4()
        {
            ValidationContext validationContext = new ValidationContext(new OpenXmlNamespaceResolver());
            OpenXmlElement errorChild;
            ColorTransformCategories categories = new ColorTransformCategories();
            var expected = categories;
            var particleConstraint = categories.Metadata.Particle.Particle.Build(Version);
            var target = particleConstraint.ParticleValidator as SequenceParticleValidator;
            validationContext.Stack.Push(element: categories);

            // <xsd:complexType name="CT_CTCategories">
            //  <xsd:sequence minOccurs="0" maxOccurs="unbounded">
            //    <xsd:element name="cat" type="CT_CTCategory" minOccurs="0" maxOccurs="unbounded">
            //  </xsd:sequence>
            // </xsd:complexType>

            // ***** good case ******

            // empty is OK
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);

            categories.AppendChild(new ColorTransformCategory());
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);

            categories.AppendChild(new ColorTransformCategory());
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);

            categories.AppendChild(new ColorTransformCategory());
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);

            // ***** error case ******

            // 1st child is invalid
            errorChild = categories.PrependChild(new Paragraph());
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.Contains(":cat", validationContext.Errors[0].Description);

            validationContext.Clear();

            // last child is invalid
            categories.RemoveChild(errorChild);
            errorChild = categories.AppendChild(new Paragraph());
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.Contains(":cat", validationContext.Errors[0].Description);

            validationContext.Clear();

            // 2nd child is invalid
            categories.RemoveChild(errorChild);
            errorChild = categories.InsertAfter(new Paragraph(), categories.FirstChild);
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.Contains(":cat", validationContext.Errors[0].Description);

            validationContext.Clear();

            // 3rd child is invalid
            categories.RemoveChild(errorChild);
            errorChild = categories.InsertBefore(new Paragraph(), categories.LastChild);
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.Contains(":cat", validationContext.Errors[0].Description);

            validationContext.Clear();

            // only one invalid child
            categories.RemoveAllChildren();
            errorChild = categories.AppendChild(new Paragraph());
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.Contains(":cat", validationContext.Errors[0].Description);
        }

        [Fact]
        public void TestSimpleSequence3()
        {
            ValidationContext validationContext = new ValidationContext(new OpenXmlNamespaceResolver());
            Divs divs = new Divs();
            OpenXmlElement errorChild;

            var particleConstraint = divs.Metadata.Particle.Particle.Build(Version);
            var target = particleConstraint.ParticleValidator as SequenceParticleValidator;
            validationContext.Stack.Push(element: divs);
            var expected = divs;

            // <xsd:complexType name="CT_Divs">
            //  <xsd:sequence minOccurs="1" maxOccurs="unbounded">
            //    <xsd:element name="div" type="CT_Div">
            //  </xsd:sequence>
            // </xsd:complexType

            // ***** good case ******
            divs.AppendChild(new Div());
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);

            divs.AppendChild(new Div());
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);

            divs.AppendChild(new Div());
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);

            // ***** error case ******

            // 1st child is invalid
            errorChild = divs.PrependChild(new Paragraph());
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.Contains(":div", validationContext.Errors[0].Description);

            validationContext.Clear();

            // last child is invalid
            divs.RemoveChild(errorChild);
            errorChild = divs.AppendChild(new Paragraph());
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.Contains(":div", validationContext.Errors[0].Description);

            validationContext.Clear();

            // 2nd child is invalid
            divs.RemoveChild(errorChild);
            errorChild = divs.InsertAfter(new Paragraph(), divs.FirstChild);
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.Contains(":div", validationContext.Errors[0].Description);

            validationContext.Clear();

            // 3rd child is invalid
            divs.RemoveChild(errorChild);
            errorChild = divs.InsertBefore(new Paragraph(), divs.LastChild);
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.Contains(":div", validationContext.Errors[0].Description);

            validationContext.Clear();

            // empty,
            divs.RemoveAllChildren();
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_IncompleteContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.Contains(":div", validationContext.Errors[0].Description);

            validationContext.Clear();

            // only one invalid child
            errorChild = divs.AppendChild(new Paragraph());
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.Contains(":div", validationContext.Errors[0].Description);
        }

        [Fact]
        public void TestSimpleSequence2()
        {
            ValidationContext validationContext = new ValidationContext(new OpenXmlNamespaceResolver());
            Ruby ruby = new Ruby();
            OpenXmlElement errorChild;

            var particleConstraint = ruby.Metadata.Particle.Particle.Build(Version);
            var target = particleConstraint.ParticleValidator as SequenceParticleValidator;
            validationContext.Stack.Push(element: ruby);
            var expected = ruby;

            // <xsd:complexType name="CT_Ruby">
            //  <xsd:sequence>
            //    <xsd:element name="rubyPr" type="CT_RubyPr">
            //    <xsd:element name="rt" type="CT_RubyContent">
            //    <xsd:element name="rubyBase" type="CT_RubyContent">
            //  </xsd:sequence>
            // </xsd:complexType>}

            // ***** good case ******
            ruby.Append(new RubyProperties(), new RubyContent(), new RubyBase());
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);

            // ***** error case ******

            // No RubyBase child, incomplete error
            ruby.RemoveChild(ruby.LastChild);
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_IncompleteContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.Contains(":rubyBase", validationContext.Errors[0].Description);

            validationContext.Clear();

            // No RubyContent child, incomplete error
            ruby.RemoveChild(ruby.LastChild);
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_IncompleteContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.Contains(":rt", validationContext.Errors[0].Description);

            validationContext.Clear();

            // Empty, incomplete error
            ruby.RemoveChild(ruby.LastChild);
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_IncompleteContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.Contains(":rubyPr", validationContext.Errors[0].Description);

            validationContext.Clear();

            // No RubyContent child, incomplete error
            ruby.Append(new RubyProperties(), new RubyBase());
            errorChild = ruby.LastChild;
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.Contains(":rt", validationContext.Errors[0].Description);

            validationContext.Clear();

            // No RubyProperties child, incomplete error
            ruby.RemoveAllChildren();
            ruby.Append(new RubyContent(), new RubyBase());
            errorChild = ruby.FirstChild;
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.Contains(":rubyPr", validationContext.Errors[0].Description);

            validationContext.Clear();

            // first should be RubyProperties()
            ruby.PrependChild(new RubyContent());
            errorChild = ruby.FirstChild;
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.Contains(":rubyPr", validationContext.Errors[0].Description);

            validationContext.Clear();

            // 2nd and 3rd are same element, error
            errorChild = ruby.FirstChild.NextSibling();
            ruby.PrependChild(new RubyProperties());
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.Contains(":rt", validationContext.Errors[0].Description);
        }

        [Fact]
        public void TestSimpleSequence()
        {
            ValidationContext validationContext = new ValidationContext(new OpenXmlNamespaceResolver());

            // <xsd:complexType name="CT_FFDDList">
            //  <xsd:sequence>
            //    <xsd:element name="result" type="CT_DecimalNumber" minOccurs="0">
            //    <xsd:element name="default" type="CT_DecimalNumber" minOccurs="0">
            //    <xsd:element name="listEntry" type="CT_String" minOccurs="0" maxOccurs="unbounded">
            //  </xsd:sequence>
            // </xsd:complexType>
            DropDownListFormField ddList = new DropDownListFormField();
            var particleConstraint = ddList.Metadata.Particle.Particle.Build(Version);
            var target = particleConstraint.ParticleValidator as SequenceParticleValidator;

            validationContext.Stack.Push(element: ddList);

            // ***** good case ******
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);

            ddList.AppendChild(new DropDownListSelection());
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);

            ddList.AppendChild(new DefaultDropDownListItemIndex());
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);

            ddList.AppendChild(new ListEntryFormField());
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);

            ddList.AppendChild(new ListEntryFormField());
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);

            // ***** error case ******
            ddList = new DropDownListFormField();
            validationContext.Stack.Push(element: ddList);
            var expected = ddList;

            // invalid child
            OpenXmlElement errorChild = ddList.AppendChild(new Paragraph());
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.Contains(":result", validationContext.Errors[0].Description);

            validationContext.Clear();

            // 2nd child is invalid
            ddList.PrependChild(new DropDownListSelection());
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.DoesNotContain(ValidationErrorStrings.FmtListOfPossibleElements, validationContext.Errors[0].Description);

            validationContext.Clear();

            // the sequence of the first 2 children are wrong
            errorChild = ddList.FirstChild;
            ddList.PrependChild(new DefaultDropDownListItemIndex());
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.DoesNotContain(ValidationErrorStrings.FmtListOfPossibleElements, validationContext.Errors[0].Description);

            validationContext.Clear();

            // 1st and 2nd are same type, maxOccurs error
            errorChild = ddList.FirstChild;
            ddList.PrependChild(new DefaultDropDownListItemIndex());
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.DoesNotContain(ValidationErrorStrings.FmtListOfPossibleElements, validationContext.Errors[0].Description);

            validationContext.Clear();

            // the 2nd and 3rd are same type, maxOccurs error
            ddList.PrependChild(new DropDownListSelection());
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.DoesNotContain(ValidationErrorStrings.FmtListOfPossibleElements, validationContext.Errors[0].Description);

            validationContext.Clear();

            // expectedNode are now the 4th, the first 3 are OK.
            ddList.InsertAfter(new ListEntryFormField(), errorChild);
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.DoesNotContain(ValidationErrorStrings.FmtListOfPossibleElements, validationContext.Errors[0].Description);
        }
    }
}
