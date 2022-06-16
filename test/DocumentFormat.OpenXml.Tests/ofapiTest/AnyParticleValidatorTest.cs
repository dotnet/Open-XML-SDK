// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Validation;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Vml;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    /// <summary>
    /// This is a test class for AnyParticleValidatorTest and is intended
    /// to contain all AnyParticleValidatorTest Unit Tests
    /// </summary>
    public class AnyParticleValidatorTest
    {
        [Fact]
        public void AnyParticleValidateTest()
        {
            ValidationContext validationContext = new ValidationContext(new OpenXmlNamespaceResolver());
            OpenXmlElement errorChild;

            TextBox textBox = new TextBox();
            var particleConstraint = textBox.Metadata.Particle.Particle.Build(FileFormatVersions.Office2007);
            var target = particleConstraint.ParticleValidator as ChoiceParticleValidator;
            validationContext.Stack.Push(element: textBox);
            var expected = textBox;

            // <xsd:complexType name="CT_Textbox">
            //  <xsd:choice>
            //    <xsd:element ref="w:txbxContent" minOccurs="0" />
            //    <xsd:any namespace="##local" processContents="skip" />
            //  </xsd:choice>
            // </xsd:complexType>

            // ***** good case ******

            // empty is OK
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);

            // any element without namespace is ok
            errorChild = textBox.AppendChild(new OpenXmlUnknownElement("test"));
            Assert.True(string.IsNullOrEmpty(errorChild.NamespaceUri));
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);
            textBox.RemoveChild(errorChild);

            // ***** error case ******

            // any element with namespace is invalid
            errorChild = textBox.AppendChild(new TextBox());
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.Contains(":txbxContent", validationContext.Errors[0].Description);
            Assert.Contains("##local", validationContext.Errors[0].Description);
            textBox.RemoveChild(errorChild);

            validationContext.Clear();

            // any element with namespace is invalid
            errorChild = textBox.AppendChild(new OpenXmlUnknownElement(string.Empty, "test", "http://test"));
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.Contains(":txbxContent", validationContext.Errors[0].Description);
            Assert.Contains("##local", validationContext.Errors[0].Description);
            textBox.RemoveChild(errorChild);

            validationContext.Clear();

            // any element with namespace is invalid
            errorChild = textBox.AppendChild(new OpenXmlUnknownElement("t", "test", "http://test"));
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.Contains(":txbxContent", validationContext.Errors[0].Description);
            Assert.Contains("##local", validationContext.Errors[0].Description);
            textBox.RemoveChild(errorChild);

            validationContext.Clear();

            // only one element without namespace is allowed
            textBox.AppendChild(new OpenXmlUnknownElement("test"));
            errorChild = textBox.AppendChild(new OpenXmlUnknownElement("errorElement"));
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.DoesNotContain(ValidationErrorStrings.FmtListOfPossibleElements, validationContext.Errors[0].Description);
            textBox.RemoveAllChildren();

            validationContext.Clear();

            // only one element without namespace is allowed
            textBox.AppendChild(new OpenXmlUnknownElement("test"));
            errorChild = textBox.AppendChild(new OpenXmlUnknownElement("test"));
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.DoesNotContain(ValidationErrorStrings.FmtListOfPossibleElements, validationContext.Errors[0].Description);
            textBox.RemoveAllChildren();
        }
    }
}
