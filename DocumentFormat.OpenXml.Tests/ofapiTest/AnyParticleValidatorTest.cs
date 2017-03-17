// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using DocumentFormat.OpenXml.Internal.SchemaValidation;
using DocumentFormat.OpenXml.Validation;
using DocumentFormat.OpenXml.Vml;
using DocumentFormat.OpenXml.Vml.Office;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    
    
    /// <summary>
    ///This is a test class for AnyParticleValidatorTest and is intended
    ///to contain all AnyParticleValidatorTest Unit Tests
    ///</summary>
    public class AnyParticleValidatorTest
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
        ///A test for AnyParticleValidator.TryMatch()
        ///</summary>
        [Fact]
        public void AnyParticleValidateTest()
        {
            SdbSchemaDatas sdbSchemaDatas = SdbSchemaDatas.GetOffice2007SchemaDatas();

            TestSimpleAny(sdbSchemaDatas);
            // TestSimpleAny2(sdbSchemaDatas);
        }

        private void TestSimpleAny(SdbSchemaDatas sdbSchemaDatas)
        {
            ValidationContext validationContext = new ValidationContext();
            ValidationResult actual = new ValidationResult();
            validationContext.ValidationErrorEventHandler += actual.OnValidationError;
            OpenXmlElement errorChild;

            TextBox textBox = new TextBox();
            var particleConstraint = sdbSchemaDatas.GetSchemaTypeData(textBox).ParticleConstraint;
            var target = particleConstraint.ParticleValidator as ChoiceParticleValidator;
            validationContext.Element = textBox;
            var expected = textBox;
              //<xsd:complexType name="CT_Textbox">
              //  <xsd:choice>
              //    <xsd:element ref="w:txbxContent" minOccurs="0" />
              //    <xsd:any namespace="##local" processContents="skip" />
              //  </xsd:choice>
              //</xsd:complexType>

            // ***** good case ******

            // empty is ok
            target.Validate(validationContext);
            Assert.True(actual.Valid);

            // any element without namespace is ok
            errorChild = textBox.AppendChild(new OpenXmlUnknownElement("test"));
            Assert.True(string.IsNullOrEmpty(errorChild.NamespaceUri));
            target.Validate(validationContext);
            Assert.True(actual.Valid);
            textBox.RemoveChild(errorChild);

            // ***** error case ******

            // any element with namespace is invlaid
            errorChild = textBox.AppendChild(new TextBox());
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.True(actual.Errors[0].Description.Contains(":txbxContent"));
            Assert.True(actual.Errors[0].Description.Contains("##local"));
            textBox.RemoveChild(errorChild);

            actual.Clear();
            // any element with namespace is invalid
            errorChild = textBox.AppendChild(new OpenXmlUnknownElement("", "test", "http://test"));
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.True(actual.Errors[0].Description.Contains(":txbxContent"));
            Assert.True(actual.Errors[0].Description.Contains("##local"));
            textBox.RemoveChild(errorChild);

            actual.Clear();
            // any element with namespace is invlaid
            errorChild = textBox.AppendChild(new OpenXmlUnknownElement("t", "test", "http://test"));
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.True(actual.Errors[0].Description.Contains(":txbxContent"));
            Assert.True(actual.Errors[0].Description.Contains("##local"));
            textBox.RemoveChild(errorChild);

            actual.Clear();
            // only one element without namespace is allowed
            textBox.AppendChild(new OpenXmlUnknownElement("test"));
            errorChild = textBox.AppendChild(new OpenXmlUnknownElement("errorElement"));
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.False(actual.Errors[0].Description.Contains(ValidationErrorStrings.Fmt_ListOfPossibleElements));
            textBox.RemoveAllChildren();

            actual.Clear();
            // only one element without namespace is allowed
            textBox.AppendChild(new OpenXmlUnknownElement("test"));
            errorChild = textBox.AppendChild(new OpenXmlUnknownElement("test"));
            target.Validate(validationContext);
            Assert.False(actual.Valid);
            Assert.Equal(1, actual.Errors.Count);
            Assert.Same(expected, actual.Errors[0].Node);
            Assert.Same(errorChild, actual.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", actual.Errors[0].Id);
            Assert.False(actual.Errors[0].Description.Contains(ValidationErrorStrings.Fmt_ListOfPossibleElements));
            textBox.RemoveAllChildren();
        }
    }
}
