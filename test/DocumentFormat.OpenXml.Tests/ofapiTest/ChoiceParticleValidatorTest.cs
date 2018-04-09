﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Validation;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Wordprocessing;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    /// <summary>
    ///This is a test class for ChoiceParticleValidatorTest and is intended
    ///to contain all ChoiceParticleValidatorTest Unit Tests
    ///</summary>
    public class ChoiceParticleValidatorTest
    {
        /// <summary>
        ///A test for ChoiceParticleValidator.Validate()
        ///</summary>
        [Fact]
        public void ChoiceParticleValidateTest()
        {
            SdbSchemaData sdbSchemaDatas = SdbSchemaData.GetSchemaData(FileFormatVersions.Office2007);

            TestSimpleChoice(sdbSchemaDatas);
            TestSimpleChoice2(sdbSchemaDatas);
            TestSimpleChoice3(sdbSchemaDatas);
            TestSimpleChoice4(sdbSchemaDatas);
        }

        private void TestSimpleChoice4(SdbSchemaData sdbSchemaDatas)
        {
            ValidationContext validationContext = new ValidationContext();
            OpenXmlElement errorChild;

            RevisionRowColumn rRowColumn = new RevisionRowColumn();
            var particleConstraint = sdbSchemaDatas.GetSchemaTypeData(rRowColumn).ParticleConstraint;
            var target = particleConstraint.ParticleValidator as ChoiceParticleValidator;
            validationContext.Element = rRowColumn;
            var expected = rRowColumn;

              //<xsd:complexType name="CT_RevisionRowColumn">
              //  <xsd:choice minOccurs="0" maxOccurs="unbounded">
              //    <xsd:element name="undo" type="CT_UndoInfo" minOccurs="0" maxOccurs="unbounded">
              //    <xsd:element name="rcc" type="CT_RevisionCellChange" minOccurs="0" maxOccurs="unbounded">
              //    <xsd:element name="rfmt" type="CT_RevisionFormatting" minOccurs="0" maxOccurs="unbounded">
              //  </xsd:choice>
              //</xsd:complexType>

            // ***** good case ******

            // empty is OK
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);

            rRowColumn.AppendChild(new RevisionCellChange());
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);

            // duplicate is ok
            rRowColumn.AppendChild(new RevisionCellChange());
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);

            // more is ok
            rRowColumn.AppendChild(new RevisionFormat());
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);

            // more is ok
            rRowColumn.AppendChild(new Undo());
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);

            // ***** error case ******

            //first is invalid
            errorChild = rRowColumn.PrependChild(new Paragraph());
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.Contains(":undo", validationContext.Errors[0].Description);
            Assert.Contains(":rfmt", validationContext.Errors[0].Description);

            validationContext.Clear();

            //invalid child in middle
            rRowColumn.RemoveChild(errorChild);
            errorChild = rRowColumn.InsertBefore(new Paragraph(), rRowColumn.LastChild);
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.Contains(":undo", validationContext.Errors[0].Description);
            Assert.Contains(":rfmt", validationContext.Errors[0].Description);

            validationContext.Clear();

            //invalid child in last
            rRowColumn.RemoveChild(errorChild);
            errorChild = rRowColumn.AppendChild(new Paragraph());
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.Contains(":undo", validationContext.Errors[0].Description);
            Assert.Contains(":rfmt", validationContext.Errors[0].Description);
        }

        private void TestSimpleChoice3(SdbSchemaData sdbSchemaDatas)
        {
            ValidationContext validationContext = new ValidationContext();
            OpenXmlElement errorChild;

            FormFieldData ffData = new FormFieldData();
            var particleConstraint = sdbSchemaDatas.GetSchemaTypeData(ffData).ParticleConstraint;
            var target = particleConstraint.ParticleValidator as ChoiceParticleValidator;
            validationContext.Element = ffData;
            var expected = ffData;

            //<xs:complexType name="CT_FFData">
            //  <xs:choice maxOccurs="unbounded">
            //    <xs:element name="name" type="CT_FFName">
            //    <xs:element name="enabled" type="CT_OnOff">
            //    <xs:element name="calcOnExit" type="CT_OnOff">
            //    <xs:element name="entryMacro" type="CT_MacroName" minOccurs="0" maxOccurs="1">
            //    <xs:element name="exitMacro" type="CT_MacroName" minOccurs="0" maxOccurs="1">
            //    <xs:element name="helpText" type="CT_FFHelpText" minOccurs="0" maxOccurs="1">
            //    <xs:element name="statusText" type="CT_FFStatusText" minOccurs="0" maxOccurs="1">
            //    <xs:choice>
            //      <xs:element name="checkBox" type="CT_FFCheckBox">
            //      <xs:element name="ddList" type="CT_FFDDList">
            //      <xs:element name="textInput" type="CT_FFTextInput">
            //    </xs:choice>
            //  </xs:choice>
            //</xs:complexType>

            // ***** good case ******

            // empty is ok, as there are child with minOccurs="0"
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);

            ffData.AppendChild(new FormFieldName());
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);

            // dup element
            ffData.AppendChild(new FormFieldName());
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);

            ffData.RemoveAllChildren();
            ffData.AppendChild(new StatusText());
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);

            // 2 element
            ffData.AppendChild(new HelpText());
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);

            // dup element
            ffData.AppendChild(new HelpText());
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);

            // more element
            ffData.AppendChild(new Enabled());
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);

            // more element
            ffData.AppendChild(new CheckBox());
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);

            // more element
            ffData.AppendChild(new TextInput());
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);

            // ***** error case ******
            ffData.RemoveAllChildren();
            ffData.AppendChild(new HelpText());
            ffData.AppendChild(new CheckBox());

            //first is invalid
            errorChild = ffData.PrependChild(new Paragraph());
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.Contains(":name", validationContext.Errors[0].Description);
            Assert.Contains(":textInput", validationContext.Errors[0].Description);

            validationContext.Clear();

            //invalid child in middle
            ffData.RemoveChild(errorChild);
            errorChild = ffData.InsertBefore(new Paragraph(), ffData.LastChild);
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.Contains(":name", validationContext.Errors[0].Description);
            Assert.Contains(":textInput", validationContext.Errors[0].Description);

            validationContext.Clear();

            //invalid child in last
            ffData.RemoveChild(errorChild);
            errorChild = ffData.AppendChild(new Paragraph());
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.Contains(":name", validationContext.Errors[0].Description);
            Assert.Contains(":textInput", validationContext.Errors[0].Description);
        }

        private void TestSimpleChoice2(SdbSchemaData sdbSchemaDatas)
        {
            ValidationContext validationContext = new ValidationContext();
            OpenXmlElement errorChild;

            BuildSubElement bldSub = new BuildSubElement();
            var particleConstraint = sdbSchemaDatas.GetSchemaTypeData(bldSub).ParticleConstraint;
            var target = particleConstraint.ParticleValidator as ChoiceParticleValidator;
            validationContext.Element = bldSub;
            var expected = bldSub;

              //<xsd:complexType name="CT_AnimationGraphicalObjectBuildProperties">
              //  <xsd:choice>
              //    <xsd:element name="bldDgm" type="CT_AnimationDgmBuildProperties">
              //    <xsd:element name="bldChart" type="CT_AnimationChartBuildProperties">
              //  </xsd:choice>
              //</xsd:complexType>

            // ***** good case ******
            bldSub.AppendChild(new Drawing.BuildChart());
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);

            bldSub.RemoveAllChildren();
            bldSub.AppendChild(new Drawing.BuildDiagram());
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);

            // ***** error case ******

            // empty
            bldSub.RemoveAllChildren();
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_IncompleteContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.Contains(":bldDgm", validationContext.Errors[0].Description);
            Assert.Contains(":bldChart", validationContext.Errors[0].Description);

            validationContext.Clear();

            // both element are exist
            bldSub.Append(new Drawing.BuildChart(), new Drawing.BuildDiagram());
            errorChild = bldSub.LastChild;
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.DoesNotContain(ValidationErrorStrings.Fmt_ListOfPossibleElements, validationContext.Errors[0].Description);

            validationContext.Clear();

            //first is invalid
            errorChild = bldSub.PrependChild(new Paragraph());
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.Contains(":bldDgm", validationContext.Errors[0].Description);
            Assert.Contains(":bldChart", validationContext.Errors[0].Description);
        }

        private void TestSimpleChoice(SdbSchemaData sdbSchemaDatas)
        {
            ValidationContext validationContext = new ValidationContext();
            OpenXmlElement errorChild;

            FieldChar fldChar = new FieldChar();
            var particleConstraint = sdbSchemaDatas.GetSchemaTypeData(fldChar).ParticleConstraint;
            var target = particleConstraint.ParticleValidator as ChoiceParticleValidator;
            validationContext.Element = fldChar;
            var expected = fldChar;

              //<xsd:complexType name="CT_FldChar">
              //  <xsd:choice>
              //    <xsd:element name="fldData" type="CT_Text" minOccurs="0" maxOccurs="1">
              //    <xsd:element name="ffData" type="CT_FFData" minOccurs="0" maxOccurs="1">
              //    <xsd:element name="numberingChange" type="CT_TrackChangeNumbering" minOccurs="0">
              //  </xsd:choice>
              //</xsd:complexType>

            // ***** good case ******
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);

            fldChar.AppendChild(new FieldData());
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);

            fldChar.RemoveAllChildren();
            fldChar.AppendChild(new FormFieldData());
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);

            fldChar.RemoveAllChildren();
            fldChar.AppendChild(new NumberingChange() );
            target.Validate(validationContext);
            Assert.True(validationContext.Valid);

            // ***** error case ******

            // 1st is invalid
            errorChild = fldChar.PrependChild(new Paragraph());
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.Contains(":fldData", validationContext.Errors[0].Description);
            Assert.Contains(":ffData", validationContext.Errors[0].Description);
            Assert.Contains(":numberingChange", validationContext.Errors[0].Description);

            validationContext.Clear();

            // second is invalid
            fldChar.RemoveChild(errorChild);
            errorChild = fldChar.AppendChild(new Paragraph());
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_InvalidElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.DoesNotContain(ValidationErrorStrings.Fmt_ListOfPossibleElements, validationContext.Errors[0].Description);

            validationContext.Clear();

            // dup first child
            fldChar.RemoveAllChildren();
            fldChar.Append(new FieldData(), new FieldData());
            errorChild = fldChar.LastChild;
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.DoesNotContain(ValidationErrorStrings.Fmt_ListOfPossibleElements, validationContext.Errors[0].Description);

            validationContext.Clear();

            // two different
            fldChar.RemoveAllChildren();
            fldChar.Append(new FieldData(), new FormFieldData());
            errorChild = fldChar.LastChild;
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.DoesNotContain(ValidationErrorStrings.Fmt_ListOfPossibleElements, validationContext.Errors[0].Description);

            validationContext.Clear();

            // two different
            fldChar.RemoveAllChildren();
            fldChar.Append(new FormFieldData(), new FieldData());
            errorChild = fldChar.LastChild;
            target.Validate(validationContext);
            Assert.False(validationContext.Valid);
            Assert.Single(validationContext.Errors);
            Assert.Same(expected, validationContext.Errors[0].Node);
            Assert.Same(errorChild, validationContext.Errors[0].RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, validationContext.Errors[0].ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", validationContext.Errors[0].Id);
            Assert.DoesNotContain(ValidationErrorStrings.Fmt_ListOfPossibleElements, validationContext.Errors[0].Description);
        }
    }
}
