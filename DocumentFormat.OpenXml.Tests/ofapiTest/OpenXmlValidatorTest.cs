// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using DocumentFormat.OpenXml;
using Xunit;
using System.IO;
using System;
using System.Linq;
using System.Xml;
using System.Collections.Generic;
using DocumentFormat.OpenXml.Validation;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing;
#if WB
using DocumentFormat.OpenXml.WB.Tests;
#endif

namespace DocumentFormat.OpenXml.Tests
{
    public class OpenXmlValidatorTestFixture : IDisposable
    {
        public OpenXmlValidatorTestFixture()
        {
            OpenXmlValidatorTest.MyClassInitialize();
        }

        public void Dispose()
        {
            OpenXmlValidatorTest.MyClassCleanup();
        }
    }

    public class OpenXmlValidatorTest : IClassFixture<OpenXmlValidatorTestFixture>
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

        private static OpenXmlValidator O12Validator
        {
            get;
            set;
        }

        private static OpenXmlValidator O14Validator
        {
            get;
            set;
        }

        ///<summary>
        ///You can use the following additional attributes as you write your tests:
        ///Use ClassInitialize to run code before running the first test in the class
        ///</summary>
        public static void MyClassInitialize()
        {
            O12Validator = new OpenXmlValidator(FileFormatVersions.Office2007);
            O14Validator = new OpenXmlValidator(FileFormatVersions.Office2010);
        }
        
        ///<summary>
        ///Use ClassCleanup to run code after all tests in a class have run
        ///</summary>
        public static void MyClassCleanup()
        {
            O12Validator = null;
            O14Validator = null;
        }        

        #region property validation

        /// <summary>
        ///A test for Validate(element) - validating boolean attribute.
        ///</summary>
        [Fact]
        public void BooleanAttributeValidationTest()
        {
            // ***** good case ******
            //<xsd:complexType name="CT_Boolean">
            //  <xsd:attribute name="val" type="xsd:boolean" use="optional" default="true">
            //</xsd:complexType>

            var element = new DocumentFormat.OpenXml.Drawing.Charts.Overlay();


            // ***** good case ******
            element.Val = true;
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = false;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val.InnerText = "false";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val.InnerText = "true";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val.InnerText = "0";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val.InnerText = "1";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // ***** error case ******
            element.Val.InnerText = "";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The attribute value cannot be empty."));

            element.Val.InnerText = "FALSE";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'val' has invalid value 'FALSE'. The string 'FALSE' is not a valid 'Boolean' value.", actual.First().Description);

            element.Val.InnerText = "off";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'val' has invalid value 'off'. The string 'off' is not a valid 'Boolean' value.", actual.First().Description);

            element.Val.InnerText = "00";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'val' has invalid value '00'. The string '00' is not a valid 'Boolean' value.", actual.First().Description);


        }
        
       /// <summary>
        ///A test for Validate(element) - validating byte attribute.
        ///</summary>
        [Fact]
        public void SByteAttributeValidationTest()
        {
              //<xsd:simpleType name="ST_RotX">
              //  <xsd:restriction base="xsd:byte">
              //    <xsd:minInclusive value="-90" />
              //    <xsd:maxInclusive value="90" />
              //  </xsd:restriction>
              //</xsd:simpleType>

              //<xsd:complexType name="CT_RotX">
              //  <xsd:attribute name="val" type="ST_RotX" default="0">
              //</xsd:complexType>

            var element = new DocumentFormat.OpenXml.Drawing.Charts.RotateX();

            // ***** good case ******

            element.Val = 0;
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = -10;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = -90;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = 90;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // ***** error case ******
            element.Val.InnerText = "abc";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'val' has invalid value 'abc'. The string 'abc' is not a valid 'SByte' value.", actual.First().Description);

            // sbyte overflow
            element.Val.InnerText = "128";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'val' has invalid value '128'. The string '128' is not a valid 'SByte' value.", actual.First().Description);

            // sbyte overflow
            element.Val.InnerText = "-129";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'val' has invalid value '-129'. The string '-129' is not a valid 'SByte' value.", actual.First().Description);

            element.Val = -91;
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MinInclusive constraint failed. The value must be greater than or equal to -90."));

            element.Val = 91;
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MaxInclusive constraint failed. The value must be less than or equal to 90."));
        }

        /// <summary>
        ///A test for Validate(element) - validating unsignedByte attribute.
        ///</summary>
        [Fact]
        public void ByteAttributeValidationTest()
        {
              // <xsd:simpleType name="ST_HoleSize">
              //  <xsd:restriction base="xsd:unsignedByte">
              //    <xsd:minInclusive value="10" />
                //*** Office 2007 defines this simple type to have a minimum value of greater than or equal to 1.
              //    <xsd:maxInclusive value="90" />
              //  </xsd:restriction>
              //</xsd:simpleType>
              //<xsd:complexType name="CT_HoleSize">
              //  <xsd:attribute name="val" type="ST_HoleSize" default="10">
              //</xsd:complexType>
              
            var element = new DocumentFormat.OpenXml.Drawing.Charts.HoleSize();

            // ***** good case ******

            element.Val = 2;
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = 1;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = 90;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // ***** error case ******
            element.Val.InnerText = "abc";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'val' has invalid value 'abc'. The string 'abc' is not a valid 'Byte' value.", actual.First().Description);

            // byte overflow
            element.Val.InnerText = "256";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'val' has invalid value '256'. The string '256' is not a valid 'Byte' value.", actual.First().Description);

            // byte overflow
            element.Val.InnerText = "-1";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'val' has invalid value '-1'. The string '-1' is not a valid 'Byte' value.", actual.First().Description);

            element.Val = 0;
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MinInclusive constraint failed. The value must be greater than or equal to 1."));

            //element.Val = 9;
            //actual = O12Validator.Validate(element);
            //Assert.Equal(1, actual.Count());
            //Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            //Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            //Assert.True(actual.First().Description.EndsWith(" The MinInclusive constraint failed."));

            element.Val = 91;
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MaxInclusive constraint failed. The value must be less than or equal to 90."));
        }

        /// <summary>
        ///A test for Validate(element) - validating short value.
        ///</summary>
        [Fact]
        public void Int16ValueValidationTest()
        {
            // no such attribute in Ecma376
            // only one in element
            var element = new DocumentFormat.OpenXml.VariantTypes.VTShort();

            // ***** good case ******

            element.Text = "20";
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Text = "+20";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Text = "-20";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Text = Int16.MinValue.ToString();
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Text = Int16.MaxValue.ToString();
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // ***** error case ******
            element.Text = "abc";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_ElementValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The element 'http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:i2' has invalid value 'abc'. The string 'abc' is not a valid 'Int16' value.", actual.First().Description);

            // Int16 overflow
            element.Text = "65536";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_ElementValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The element 'http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:i2' has invalid value '65536'. The string '65536' is not a valid 'Int16' value.", actual.First().Description);

            // Int16 overflow
            element.Text = "-65536";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_ElementValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The element 'http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:i2' has invalid value '-65536'. The string '-65536' is not a valid 'Int16' value.", actual.First().Description);
        }

        /// <summary>
        ///A test for Validate(element) - validating unsignedShort attribute.
        ///</summary>
        [Fact]
        public void UInt16AttributeValidationTest()
        {
              //<xsd:simpleType name="ST_HPercent">
              //  <xsd:restriction base="xsd:unsignedShort">
              //    <xsd:minInclusive value="5" />
              //    <xsd:maxInclusive value="500" />
              //  </xsd:restriction>
              //</xsd:simpleType>
              //<xsd:complexType name="CT_HPercent">
              //  <xsd:attribute name="val" type="ST_HPercent" default="100">
              //</xsd:complexType>

            var element = new DocumentFormat.OpenXml.Drawing.Charts.HeightPercent();

            // ***** good case ******

            element.Val = 20;
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = 5;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = 500;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // ***** error case ******
            element.Val.InnerText = "abc";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'val' has invalid value 'abc'. The string 'abc' is not a valid 'UInt16' value.", actual.First().Description);

            // UInt16 overflow
            element.Val.InnerText = "65536";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'val' has invalid value '65536'. The string '65536' is not a valid 'UInt16' value.", actual.First().Description);

            // UInt16 overflow
            element.Val.InnerText = "-1";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'val' has invalid value '-1'. The string '-1' is not a valid 'UInt16' value.", actual.First().Description);

            element.Val = 0;
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MinInclusive constraint failed. The value must be greater than or equal to 5."));

            element.Val = 4;
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MinInclusive constraint failed. The value must be greater than or equal to 5."));

            element.Val = 501;
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MaxInclusive constraint failed. The value must be less than or equal to 500."));
        }

        /// <summary>
        ///A test for Validate(element) - validating Int32 attribute.
        ///</summary>
        [Fact]
        public void Int32AttributeValidationTest()
        {
              //<xsd:simpleType name="ST_Angle">
              //  <xsd:restriction base="xsd:int" />
              //</xsd:simpleType
              //<xsd:simpleType name="ST_PositiveFixedAngle">
              //  <xsd:restriction base="ST_Angle">
              //    <xsd:minInclusive value="0" />
              //    <xsd:maxExclusive value="21600000" />
              //  </xsd:restriction>
              //</xsd:simpleType>
              //<xsd:complexType name="CT_PositiveFixedAngle">
              //  <xsd:attribute name="val" type="ST_PositiveFixedAngle" use="required">
              //</xsd:complexType>

            var element = new Hue();
            
            // ***** good case ******

            element.Val = 0;
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = 100;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = 21600000 - 1;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val.InnerText = "0";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val.InnerText = "+0";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val.InnerText = "-0";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val.InnerText = "100";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val.InnerText = "+100";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // ***** error case ******
            element.Val = new Int32Value();
            element.Val.InnerText = "abc";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'val' has invalid value 'abc'. The string 'abc' is not a valid 'Int32' value.", actual.First().Description);

            element.Val = -1;
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MinInclusive constraint failed. The value must be greater than or equal to 0."));

            element.Val = 21600000;
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MaxExclusive constraint failed. The value must be less than 21600000."));

            element.Val = 21600000 * 2;
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MaxExclusive constraint failed. The value must be less than 21600000."));

              //<xsd:simpleType name="ST_FixedAngle">
              //  </xsd:annotation>
              //  <xsd:restriction base="ST_Angle">
              //    <xsd:minExclusive value="-5400000" />
              //    <xsd:maxExclusive value="5400000" />
              //  </xsd:restriction>
              //</xsd:simpleType>

              //<xsd:complexType name="CT_OuterShadowEffect">
              //  <xsd:sequence>
              //    <xsd:group ref="EG_ColorChoice" minOccurs="1" maxOccurs="1"></xsd:group>
              //  </xsd:sequence>
              //  <xsd:attribute name="blurRad" type="ST_PositiveCoordinate" use="optional" default="0">
              //  <xsd:attribute name="dist" type="ST_PositiveCoordinate" use="optional" default="0">
              //  <xsd:attribute name="dir" type="ST_PositiveFixedAngle" use="optional" default="0">
              //  <xsd:attribute name="sx" type="ST_Percentage" use="optional" default="100000">
              //  <xsd:attribute name="sy" type="ST_Percentage" use="optional" default="100000">
              //  <xsd:attribute name="kx" type="ST_FixedAngle" use="optional" default="0">
              //  <xsd:attribute name="ky" type="ST_FixedAngle" use="optional" default="0">
              //  <xsd:attribute name="algn" type="ST_RectAlignment" use="optional" default="b">
              //  <xsd:attribute name="rotWithShape" type="xsd:boolean" use="optional" default="true">
              //</xsd:complexType>

            var outerShadow = new OuterShadow( new PresetColor(){Val = PresetColorValues.AliceBlue} );
            // ***** good case ******

            outerShadow.HorizontalSkew = 0;
            actual = O12Validator.Validate(outerShadow);
            Assert.Equal(0, actual.Count());

            outerShadow.HorizontalSkew = -5400000 + 1;
            actual = O12Validator.Validate(outerShadow);
            Assert.Equal(0, actual.Count());

            outerShadow.HorizontalSkew = 5400000 - 1;
            actual = O12Validator.Validate(outerShadow);
            Assert.Equal(0, actual.Count());

            // ***** error case ******
            outerShadow.HorizontalSkew = new Int32Value();
            outerShadow.HorizontalSkew.InnerText = "abc";
            actual = O12Validator.Validate(outerShadow);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'kx' has invalid value 'abc'. The string 'abc' is not a valid 'Int32' value.", actual.First().Description);

            outerShadow.HorizontalSkew = -5400000;
            actual = O12Validator.Validate(outerShadow);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MinExclusive constraint failed. The value must be greater than -5400000."));

            outerShadow.HorizontalSkew = 5400000;
            actual = O12Validator.Validate(outerShadow);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MaxExclusive constraint failed. The value must be less than 5400000."));

            outerShadow.HorizontalSkew = 5400000 * 2;
            actual = O12Validator.Validate(outerShadow);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MaxExclusive constraint failed. The value must be less than 5400000."));

              //<xsd:simpleType name="ST_TextBulletStartAtNum">
              //  <xsd:restriction base="xsd:int">
              //    <xsd:minInclusive value="1" />
              //    <xsd:maxInclusive value="32767" />
              //  </xsd:restriction>
              //</xsd:simpleType>
              //<xsd:complexType name="CT_TextAutonumberBullet">
              //  <xsd:attribute name="type" type="ST_TextAutonumberScheme" use="required">
              //  <xsd:attribute name="startAt" type="ST_TextBulletStartAtNum" use="optional" default="1">
              //</xsd:complexType>

            var autoNum = new AutoNumberedBullet() { Type = TextAutoNumberSchemeValues.AlphaLowerCharacterParenBoth };
            // ***** good case ******

            // ***** good case ******

            autoNum.StartAt = 1;
            actual = O12Validator.Validate(autoNum);
            Assert.Equal(0, actual.Count());

            autoNum.StartAt = 100;
            actual = O12Validator.Validate(autoNum);
            Assert.Equal(0, actual.Count());

            autoNum.StartAt = 32767;
            actual = O12Validator.Validate(autoNum);
            Assert.Equal(0, actual.Count());

            // ***** error case ******
            autoNum.StartAt = new Int32Value();
            autoNum.StartAt.InnerText = "abc";
            actual = O12Validator.Validate(autoNum);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'startAt' has invalid value 'abc'. The string 'abc' is not a valid 'Int32' value.", actual.First().Description);

            autoNum.StartAt = -1;
            actual = O12Validator.Validate(autoNum);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MinInclusive constraint failed. The value must be greater than or equal to 1."));

            autoNum.StartAt = 0;
            actual = O12Validator.Validate(autoNum);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MinInclusive constraint failed. The value must be greater than or equal to 1."));

            autoNum.StartAt = 32767 + 1;
            actual = O12Validator.Validate(autoNum);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MaxInclusive constraint failed. The value must be less than or equal to 32767."));

            autoNum.StartAt = 32767 * 2;
            actual = O12Validator.Validate(autoNum);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MaxInclusive constraint failed. The value must be less than or equal to 32767."));
#if DEBUG
            Assert.Equal("startAt", actual.First().AttributeQualifiedName);
            Assert.Equal("Sch_MaxInclusiveConstraintFailed", actual.First().ValidationErrorCategory);
#endif
        }

        /// <summary>
        ///A test for Validate(element) - validating Int32 value.
        ///</summary>
        [Fact]
        public void Int32ValueValidationTest()
        {
            //<xsd:simpleType name="ST_ColID">
            //    <xsd:restriction base="xsd:int">
            //      <xsd:minInclusive value="0" />
            //    </xsd:restriction>
            //  </xsd:simpleType>
            //  <xsd:simpleType name="ST_RowID">
            //    <xsd:restriction base="xsd:int">
            //      <xsd:minInclusive value="0" />
            //    </xsd:restriction>
            //  </xsd:simpleType>

            //  <xsd:complexType name="CT_Marker">
            //    <xsd:sequence>
            //      <xsd:element name="col" type="ST_ColID">
            //      <xsd:element name="colOff" type="a:ST_Coordinate">
            //      <xsd:element name="row" type="ST_RowID">
            //      <xsd:element name="rowOff" type="a:ST_Coordinate">
            //    </xsd:sequence>
            //  </xsd:complexType>
      
            var element = new DocumentFormat.OpenXml.Drawing.Spreadsheet.ColumnId();

            // ***** good case ******

            element.Text = "0";
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Text = "-00";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Text = "20";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Text = "+0020";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Text = Int32.MaxValue.ToString();
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // ***** error case ******
            element.Text = "abc";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_ElementValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The element 'http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing:col' has invalid value 'abc'. The string 'abc' is not a valid 'Int32' value.", actual.First().Description);

            // Int32 overflow
            element.Text = "2147483648";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_ElementValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The element 'http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing:col' has invalid value '2147483648'. The string '2147483648' is not a valid 'Int32' value.", actual.First().Description);

            element.Text = "-1";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_ElementValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MinInclusive constraint failed. The value must be greater than or equal to 0."));
        }

        /// <summary>
        ///A test for Validate(element) - validating UInt32 attribute.
        ///</summary>
        [Fact]
        public void UInt32AttributeValidationTest()
        {
              //<xsd:simpleType name="ST_BubbleScale">
              //  <xsd:restriction base="xsd:unsignedInt">
              //    <xsd:minInclusive value="0" />
              //    <xsd:maxInclusive value="300" />
              //  </xsd:restriction>
              //</xsd:simpleType>
              //<xsd:complexType name="CT_BubbleScale">
              //  <xsd:attribute name="val" type="ST_BubbleScale" default="100">
              //</xsd:complexType>

            var element = new DocumentFormat.OpenXml.Drawing.Charts.BubbleScale();

            // ***** good case ******

            element.Val = 0;
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = 100;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = 300;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // ***** error case ******

            element.Val = new UInt32Value();
            element.Val.InnerText = "abc";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'val' has invalid value 'abc'. The string 'abc' is not a valid 'UInt32' value.", actual.First().Description);

            element.Val = 300 + 1;
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MaxInclusive constraint failed. The value must be less than or equal to 300."));

            element.Val = 300 * 2;
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MaxInclusive constraint failed. The value must be less than or equal to 300."));
        }

        /// <summary>
        ///A test for Validate(element) - validating int attribute.
        ///</summary>
        [Fact]
        public void Int32AttributeValidationTest2()
        {
                  //<xsd:simpleType name="ST_Coordinate32">
                  //  <xsd:restriction base="xsd:int" />
                  //</xsd:simpleType>

                  //<xsd:simpleType name="ST_PositiveCoordinate32">
                  //  <xsd:restriction base="ST_Coordinate32">
                  //    <xsd:minInclusive value="0" />
                  //  </xsd:restriction>
                  //</xsd:simpleType>

                  //<xsd:simpleType name="ST_SlideSizeCoordinate">
                  //  <xsd:restriction base="a:ST_PositiveCoordinate32">
                  //    <xsd:minInclusive value="914400" />
                  //    <xsd:maxInclusive value="51206400" />
                  //  </xsd:restriction>
                  //</xsd:simpleType>
            
                  //<xsd:complexType name="CT_SlideSize">
                  //  <xsd:attribute name="cx" type="ST_SlideSizeCoordinate" use="required">
                  //  <xsd:attribute name="cy" type="ST_SlideSizeCoordinate" use="required">
                  //  <xsd:attribute name="type" type="ST_SlideSizeType" use="optional" default="custom">
                  //</xsd:complexType>

            var element = new DocumentFormat.OpenXml.Presentation.SlideSize();
            element.Cy = 914400;

            // ***** good case ******

            element.Cx = 914400 + 914400;
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Cx = 914400;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Cx.InnerText = "914400";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Cx.InnerText = "+914400";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Cx = 51206400;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // ***** error case ******
            element.Cx.InnerText = "abc";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'cx' has invalid value 'abc'. The string 'abc' is not a valid 'Int32' value.", actual.First().Description);

            // Int64 overflow
            element.Cx.InnerText = "9223372036854775808";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'cx' has invalid value '9223372036854775808'. The string '9223372036854775808' is not a valid 'Int32' value.", actual.First().Description);

            // INt64 overflow
            element.Cx.InnerText = "-9223372036854775808";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'cx' has invalid value '-9223372036854775808'. The string '-9223372036854775808' is not a valid 'Int32' value.", actual.First().Description);

            element.Cx = -1;
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MinInclusive constraint failed. The value must be greater than or equal to 914400."));

            element.Cx = 914400 - 1;
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MinInclusive constraint failed. The value must be greater than or equal to 914400."));

            element.Cx = 51206400 + 1;
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MaxInclusive constraint failed. The value must be less than or equal to 51206400."));

        }

        /// <summary>
        ///A test for Validate(element) - validating long attribute.
        ///</summary>
        [Fact]
        public void Int64AttributeValidationTest()
        {
             // <xs:simpleType name="ST_Coordinate">
             //   <xs:restriction base="xsd:long">
             //     <xs:minInclusive value="-27273042329600" />
             //     <xs:maxInclusive value="27273042316900" />
             //   </xs:restriction>
             // </xs:simpleType>

             // <xs:simpleType name="ST_PositiveCoordinate">
             //   <xs:annotation>
             //     <xs:documentation>Positive Coordinate</xs:documentation>
             //   </xs:annotation>
             //   <xs:restriction base="xsd:long">
             //     <xs:minInclusive value="0" />
             //     <xs:maxInclusive value="2147483647" />
             //   </xs:restriction>
             // </xs:simpleType>

             //<xs:complexType name="CT_Point2D">
             //   <xs:attribute name="x" type="ST_Coordinate" use="required">
             //   <xs:attribute name="y" type="ST_Coordinate" use="required">
             // </xs:complexType>

             // <xs:complexType name="CT_PositiveSize2D">
             //   <xs:attribute name="cx" type="ST_PositiveCoordinate" use="required">
             //   <xs:attribute name="cy" type="ST_PositiveCoordinate" use="required">
             // </xs:complexType>

            var element = new DocumentFormat.OpenXml.Drawing.ChildExtents();
            element.Cy = 914400;

            // ***** good case ******

            element.Cx = 914400 + 914400;
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Cx = 914400;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Cx.InnerText = "914400";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Cx.InnerText = "+914400";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Cx = 51206400;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // ***** error case ******
            element.Cx.InnerText = "abc";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'cx' has invalid value 'abc'. The string 'abc' is not a valid 'Int64' value.", actual.First().Description);

            // Int64 overflow
            element.Cx.InnerText = "9223372036854775808";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'cx' has invalid value '9223372036854775808'. The string '9223372036854775808' is not a valid 'Int64' value.", actual.First().Description);

            // INt64 overflow
            element.Cx.InnerText = "-9223372036854775809";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'cx' has invalid value '-9223372036854775809'. The string '-9223372036854775809' is not a valid 'Int64' value.", actual.First().Description);

            element.Cx = -2147483647L;
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MinInclusive constraint failed. The value must be greater than or equal to 0."));

            element.Cx = 0 - 1;
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MinInclusive constraint failed. The value must be greater than or equal to 0."));

            element.Cx = 2147483647L + 1;
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MaxInclusive constraint failed. The value must be less than or equal to 2147483647."));
        }

        /// <summary>
        ///A test for Validate(element) - validating unsignedLong value.
        ///</summary>
        [Fact]
        public void UInt64ValueValidationTest()
        {
            // only one in element
            var element = new DocumentFormat.OpenXml.VariantTypes.VTUnsignedInt64();

            // ***** good case ******

            element.Text = "20";
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Text = UInt64.MinValue.ToString();
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Text = UInt32.MaxValue.ToString();
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Text = UInt64.MaxValue.ToString();
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // ***** error case ******
            element.Text = "abc";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_ElementValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The element 'http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:ui8' has invalid value 'abc'. The string 'abc' is not a valid 'UInt64' value.", actual.First().Description);

            // UInt64 overflow
            element.Text = "18446744073709551616";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_ElementValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The element 'http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:ui8' has invalid value '18446744073709551616'. The string '18446744073709551616' is not a valid 'UInt64' value.", actual.First().Description);

            // UInt64 overflow
            element.Text = "-1";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_ElementValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The element 'http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:ui8' has invalid value '-1'. The string '-1' is not a valid 'UInt64' value.", actual.First().Description);

            // unsigned int64 can not have "+" 
            element.Text = "+20";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_ElementValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The element 'http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes:ui8' has invalid value '+20'. The string '+20' is not a valid 'UInt64' value.", actual.First().Description);
        }

        /// <summary>
        ///A test for Validate(element) - validating float attribute.
        ///</summary>
        [Fact]
        public void FloatAttributeValidationTest()
        {
              //<xsd:complexType name="CT_TLAnimVariantFloatVal">
              //  <xsd:attribute name="val" type="xsd:float" use="required">
              //</xsd:complexType>

            var element = new DocumentFormat.OpenXml.Presentation.FloatVariantValue();

            // ***** good case ******

            element.Val = float.MinValue;
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = (float)10000.001;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = (float)10.23e4;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = float.MaxValue;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = float.Epsilon;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = float.NegativeInfinity;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = float.PositiveInfinity;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // NaN (not a number)
            element.Val = float.NaN;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // ***** error case ******
            element.Val.InnerText = "abc";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'val' has invalid value 'abc'. The string 'abc' is not a valid 'Single' value.", actual.First().Description);

            // float overflow
            element.Val.InnerText = "-3.402823e39";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'val' has invalid value '-3.402823e39'. The string '-3.402823e39' is not a valid 'Single' value.", actual.First().Description);

            // float overflow
            element.Val.InnerText = "3.402823e39";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'val' has invalid value '3.402823e39'. The string '3.402823e39' is not a valid 'Single' value.", actual.First().Description);
        }

        /// <summary>
        ///A test for Validate(element) - validating double attribute.
        ///</summary>
        [Fact]
        public void DoubleAttributeValidationTest()
        {
              //<xsd:simpleType name="ST_AxisUnit">
              //  <xsd:restriction base="xsd:double">
              //    <xsd:minExclusive value="0" />
              //  </xsd:restriction>
              //</xsd:simpleType>

              //<xsd:complexType name="CT_AxisUnit">
              //  <xsd:attribute name="val" type="ST_AxisUnit" use="required">
              //</xsd:complexType>

            var element = new DocumentFormat.OpenXml.Drawing.Charts.MajorUnit();

            // ***** good case ******
            element.Val = (double)10000.001;
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = (double)10.23e4;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = double.MaxValue;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = double.Epsilon;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = double.PositiveInfinity;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // ***** error case ******
            element.Val.InnerText = "abc";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'val' has invalid value 'abc'. The string 'abc' is not a valid 'Double' value.", actual.First().Description);

            // double overflow
            element.Val.InnerText = "-1.79769313486232e309";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'val' has invalid value '-1.79769313486232e309'. The string '-1.79769313486232e309' is not a valid 'Double' value.", actual.First().Description);

            // double overflow
            element.Val.InnerText = "1.79769313486232e309";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'val' has invalid value '1.79769313486232e309'. The string '1.79769313486232e309' is not a valid 'Double' value.", actual.First().Description);

            element.Val = (double)0;
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MinExclusive constraint failed. The value must be greater than 0."));

            element.Val = 0 - double.Epsilon;
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MinExclusive constraint failed. The value must be greater than 0."));

            element.Val = double.NegativeInfinity;
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MinExclusive constraint failed. The value must be greater than 0."));

            // NaN (not a number)
            element.Val = double.NaN;
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MinExclusive constraint failed. The value must be greater than 0."));

              //<xsd:simpleType name="ST_LogBase">
              //  <xsd:restriction base="xsd:double">
              //    <xsd:minInclusive value="2" />
              //    <xsd:maxInclusive value="1000" />
              //  </xsd:restriction>
              //</xsd:simpleType>
              //<xsd:complexType name="CT_LogBase">
              //  <xsd:attribute name="val" type="ST_LogBase" use="required">
              //</xsd:complexType>

            var logBase = new DocumentFormat.OpenXml.Drawing.Charts.LogBase();

            // ***** good case ******

            logBase.Val = (double)2.0;
            actual = O12Validator.Validate(logBase);
            Assert.Equal(0, actual.Count());

            logBase.Val = (double)200;
            actual = O12Validator.Validate(logBase);
            Assert.Equal(0, actual.Count());

            logBase.Val = (double)1000.0;
            actual = O12Validator.Validate(logBase);
            Assert.Equal(0, actual.Count());

            // ***** error case ******
            logBase.Val.InnerText = "abc";
            actual = O12Validator.Validate(logBase);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'val' has invalid value 'abc'. The string 'abc' is not a valid 'Double' value.", actual.First().Description);

            logBase.Val = -1;
            actual = O12Validator.Validate(logBase);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MinInclusive constraint failed. The value must be greater than or equal to 2."));

            // ******************** double.Epsilon is too small so ((double)2.0) - double.Epsilon == 2.0

            logBase.Val = (double)2.0 - 0.1;
            actual = O12Validator.Validate(logBase);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MinInclusive constraint failed. The value must be greater than or equal to 2."));

            logBase.Val = (double)1000.0 + 0.1;
            actual = O12Validator.Validate(logBase);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MaxInclusive constraint failed. The value must be less than or equal to 1000."));
        }

        /// <summary>
        ///A test for Validate(element) - validating decimal attribute.
        ///</summary>
        [Fact]
        public void DecimalAttributeValidationTest()
        {
            //<xsd:complexType name="CT_Arc">
            //  <xsd:sequence>
            //    <xsd:group ref="EG_ShapeElements" minOccurs="0" maxOccurs="unbounded" />
            //  </xsd:sequence>
            //  <xsd:attributeGroup ref="AG_AllCoreAttributes" />
            //  <xsd:attributeGroup ref="AG_AllShapeAttributes" />
            //  <xsd:attribute name="startAngle" type="xsd:decimal" use="optional">
            //  <xsd:attribute name="endAngle" type="xsd:decimal" use="optional">
            //</xsd:complexType>

            var element = new DocumentFormat.OpenXml.Vml.Arc();


            // ***** good case ******

            element.StartAngle = decimal.MaxValue;
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.StartAngle = (decimal)100000.002;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.StartAngle.InnerText = "+100000.002";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.StartAngle.InnerText = "-100000.002";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.StartAngle = decimal.MinusOne;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.StartAngle = decimal.MinValue;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.StartAngle = decimal.One;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.StartAngle = decimal.Zero;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // ***** error case ******
            element.StartAngle.InnerText = "abc";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'startangle' has invalid value 'abc'. The string 'abc' is not a valid 'Decimal' value.", actual.First().Description);

            // decimal overflow
            element.StartAngle.InnerText = "-79228162514264337593543950336";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'startangle' has invalid value '-79228162514264337593543950336'. The string '-79228162514264337593543950336' is not a valid 'Decimal' value.", actual.First().Description);

            // decimal overflow
            element.StartAngle.InnerText = "79228162514264337593543950336";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'startangle' has invalid value '79228162514264337593543950336'. The string '79228162514264337593543950336' is not a valid 'Decimal' value.", actual.First().Description);
        }

        /// <summary>
        ///A test for Validate(element) - validating integer attribute.
        ///</summary>
        [Fact]
        public void IntegerAttributeValidationTest()
        {
              //<xsd:simpleType name="ST_Integer2">
              //  <xsd:restriction base="xsd:integer">
              //    <xsd:minInclusive value="-2" />
              //    <xsd:maxInclusive value="2" />
              //  </xsd:restriction>
              //</xsd:simpleType>
              //<xsd:complexType name="CT_Integer2">
              //  <xsd:attribute name="val" type="ST_Integer2" use="required">
              //</xsd:complexType>

            var element = new DocumentFormat.OpenXml.Math.ArgumentSize();


            // ***** good case ******

            element.Val = -2;
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = 2;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = 0;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // ***** error case ******
            element.Val.InnerText = "abc";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'http://schemas.openxmlformats.org/officeDocument/2006/math:val' has invalid value 'abc'. The string 'abc' is not a valid 'http://www.w3.org/2001/XMLSchema:integer' value.", actual.First().Description);

            element.Val = -3;
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MinInclusive constraint failed. The value must be greater than or equal to -2."));

            element.Val = 3;
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The MaxInclusive constraint failed. The value must be less than or equal to 2."));
        }

        /// <summary>
        ///A test for Validate(element) - validating nonNegativeInteger attribute.
        ///</summary>
        [Fact]
        public void NonNegativeIntegerValueValidationTest()
        {
            // <xsd:element name="ScriptLanguage" type="xsd:nonNegativeInteger">
            var element = new DocumentFormat.OpenXml.Vml.Spreadsheet.ScriptLanguage();

            // ***** good case ******

            element.Text = "20";
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Text = "+20";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Text = "0";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Text = "-0";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Text = UInt32.MaxValue.ToString();
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // ***** error case ******
            element.Text = "abc";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_ElementValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The element 'urn:schemas-microsoft-com:office:excel:ScriptLanguage' has invalid value 'abc'. The string 'abc' is not a valid 'http://www.w3.org/2001/XMLSchema:nonNegativeInteger' value.", actual.First().Description);

            // negative integer is error.
            element.Text = "-1";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_ElementValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The element 'urn:schemas-microsoft-com:office:excel:ScriptLanguage' has invalid value '-1'. The string '-1' is not a valid 'http://www.w3.org/2001/XMLSchema:nonNegativeInteger' value.", actual.First().Description);
        }

        /// <summary>
        ///A test for Validate(element) - validating positiveInteger attribute.
        ///</summary>
        [Fact]
        public void PositiveIntegerAttributeValidationTest()
        {
            // In vml-wordprocessingDrawing
              //<xsd:complexType name="CT_Border">
              //  <xsd:attribute name="type" type="ST_BorderType" use="optional">
              //  <xsd:attribute name="width" type="xsd:positiveInteger" use="optional">
              //  <xsd:attribute name="shadow" type="ST_BorderShadow" use="optional">
              //</xsd:complexType>

            var element = new DocumentFormat.OpenXml.Vml.Wordprocessing.TopBorder();


            // ***** good case ******

            element.Width = 1;
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Width = 2;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Width = 1000;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // ***** error case ******
            element.Width.InnerText = "abc";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'width' has invalid value 'abc'. The string 'abc' is not a valid 'http://www.w3.org/2001/XMLSchema:positiveInteger' value.", actual.First().Description);

            element.Width = 0;
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'width' has invalid value '0'. The string '0' is not a valid 'http://www.w3.org/2001/XMLSchema:positiveInteger' value.", actual.First().Description);

            element.Width = -3;
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'width' has invalid value '-3'. The string '-3' is not a valid 'http://www.w3.org/2001/XMLSchema:positiveInteger' value.", actual.First().Description);
        }

        /// <summary>
        ///A test for Validate(element) - validating dateTime attribute.
        ///</summary>
        [Fact]
        public void DateTimeAttributeValidationTest()
        {
              //<xsd:simpleType name="ST_DateTime">
              //  <xsd:annotation>
              //    <xsd:documentation>Standard Date and Time Storage Format</xsd:documentation>
              //  </xsd:annotation>
              //  <xsd:restriction base="xsd:dateTime" />
              //</xsd:simpleType>

            var element = new DocumentFormat.OpenXml.Wordprocessing.SdtContentDate();


            // ***** good case ******

            element.FullDate = DateTime.MinValue;
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.FullDate = DateTime.MaxValue;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.FullDate = DateTime.Now;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.FullDate = DateTime.Today;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.FullDate = DateTime.UtcNow;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());


            element.FullDate.InnerText = XmlConvert.ToString(DateTime.Now, XmlDateTimeSerializationMode.Local);
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.FullDate.InnerText = XmlConvert.ToString(DateTime.Today, XmlDateTimeSerializationMode.RoundtripKind);
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.FullDate.InnerText = XmlConvert.ToString(DateTime.UtcNow, XmlDateTimeSerializationMode.Utc);
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());
            
            // ***** error case ******
            element.FullDate.InnerText = "abc";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'http://schemas.openxmlformats.org/wordprocessingml/2006/main:fullDate' has invalid value 'abc'. The string 'abc' is not a valid 'DateTime' value.", actual.First().Description);

            element.FullDate.InnerText = "123";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'http://schemas.openxmlformats.org/wordprocessingml/2006/main:fullDate' has invalid value '123'. The string '123' is not a valid 'DateTime' value.", actual.First().Description);
        }

        /// <summary>
        ///A test for Validate(element) - validating enum attribute.
        ///</summary>
        [Fact]
        public void EnumAttributeValidationTest()
        {
             //<xsd:simpleType name="ST_FontFamily">
             //   <xsd:restriction base="xsd:string">
             //     <xsd:enumeration value="decorative">
             //     <xsd:enumeration value="modern">
             //     <xsd:enumeration value="roman">
             //     <xsd:enumeration value="script">
             //     <xsd:enumeration value="swiss">
             //     <xsd:enumeration value="auto">
             //   </xsd:restriction>
             // </xsd:simpleType>
             // <xsd:complexType name="CT_FontFamily">
             //   <xsd:attribute name="val" type="ST_FontFamily" use="required">
             // </xsd:complexType>

            FontFamily element = new FontFamily();
            
            // ***** good case ******
            element.Val = FontFamilyValues.Auto;
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = FontFamilyValues.Decorative;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = FontFamilyValues.Modern;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = FontFamilyValues.Roman;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = FontFamilyValues.Script;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = FontFamilyValues.Swiss;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // ***** error case ******
            element.Val.InnerText = "";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("/w:family[1]", actual.First().Path.XPath);
            Assert.True(actual.First().Description.EndsWith(" The Enumeration constraint failed."));

            element.Val.InnerText = "Noo";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("/w:family[1]", actual.First().Path.XPath);
            Assert.True(actual.First().Description.EndsWith(" The Enumeration constraint failed."));

            // Invalid character case.
            element.Val.InnerText = "Auto";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("/w:family[1]", actual.First().Path.XPath);
            Assert.True(actual.First().Description.EndsWith(" The Enumeration constraint failed."));

        }

        /// <summary>
        ///A test for Validate(element) - validating enum value.
        ///</summary>
        [Fact]
        public void EnumValueValidationTest()
        {
              //<xsd:simpleType name="ST_SourceType">
              //  <xsd:restriction base="ST_String255">
              //    <xsd:enumeration value="ArticleInAPeriodical">
              //    <xsd:enumeration value="Book">
              //    <xsd:enumeration value="BookSection">
              //    <xsd:enumeration value="JournalArticle">
              //    <xsd:enumeration value="ConferenceProceedings">
              //    <xsd:enumeration value="Report">
              //    <xsd:enumeration value="SoundRecording">
              //    <xsd:enumeration value="Performance">
              //    <xsd:enumeration value="Art">
              //    <xsd:enumeration value="DocumentFromInternetSite">
              //    <xsd:enumeration value="InternetSite">
              //    <xsd:enumeration value="Film">
              //    <xsd:enumeration value="Interview">
              //    <xsd:enumeration value="Patent">
              //    <xsd:enumeration value="ElectronicSource">
              //    <xsd:enumeration value="Case">
              //    <xsd:enumeration value="Misc">
              //  </xsd:restriction>
              //</xsd:simpleType>

            var element = new DocumentFormat.OpenXml.Bibliography.SourceType();

            // ***** good case ******

            element.Text = "ArticleInAPeriodical";
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Text = "Art";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Text = "Interview";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Text = "Misc";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // ***** error case ******
            element.Text = "";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_ElementValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The Enumeration constraint failed."));

            element.Text = "abc";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_ElementValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The Enumeration constraint failed."));
        }

        /// <summary>
        ///A test for Validate(element) - validating string attribute.
        ///</summary>
        [Fact]
        public void StringAttributeValidationTest()
        {
              //<xsd:simpleType name="ST_Cnf">
              //  <xsd:restriction base="xsd:string">
              //    <xsd:length value="12" />
              //    <xsd:pattern value="[01]*" />
              //  </xsd:restriction>
              //</xsd:simpleType>
              //<xsd:complexType name="CT_Cnf">
              //  <xsd:attribute name="val" type="ST_Cnf" use="required">
              //</xsd:complexType>

            var element = new ConditionalFormatStyle();

            // string length

            // ***** good case ******

            element.Val = "010101010101";
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // ***** error case ******
            element.Val = null;
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_MissRequiredAttribute", actual.First().Id);

            element.Val = "";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The attribute value cannot be empty."));

            element.Val.InnerText = "0101";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The actual length according to datatype 'string' is not equal to the specified length. The expected length is 12."));

            element.Val = "0101010101010";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The actual length according to datatype 'string' is not equal to the specified length. The expected length is 12."));

            // pattern invalid
            element.Val = "010101010102";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The Pattern constraint failed. The expected pattern is [01]*."));

            // pattern invalid
            element.Val = "invalid";
            actual = O12Validator.Validate(element);
            Assert.Equal(2, actual.Count()); // both pattern and lenght are incorrect.
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The actual length according to datatype 'string' is not equal to the specified length. The expected length is 12."));

            Assert.Equal(ValidationErrorType.Schema, actual.Last().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.Last().Id);
            Assert.True(actual.Last().Description.EndsWith(" The Pattern constraint failed. The expected pattern is [01]*."));

            // minLength. maxLength
              //<xsd:simpleType name="ST_String255">
              //  <xsd:restriction base="xsd:string">
              //    <xsd:minLength value="0" />
              //    <xsd:maxLength value="255" />
              //  </xsd:restriction>
              //</xsd:simpleType>

             //<xsd:complexType name="CT_Sources">
             //   <xsd:sequence>
             //     <xsd:element name="Source" type="CT_SourceType" minOccurs="0" maxOccurs="unbounded">
             //   </xsd:sequence>
             //   <xsd:attribute name="SelectedStyle" type="ST_String255">
             //   <xsd:attribute name="StyleName" type="ST_String255">
             //   <xsd:attribute name="URI" type="ST_String255">
             // </xsd:complexType>

            // ***** good case ******
            var sources = new Sources();
            sources.StyleName = "";
            actual = O12Validator.Validate(sources);
            Assert.Equal(0, actual.Count());

            sources.StyleName = "Style1";
            actual = O12Validator.Validate(sources);
            Assert.Equal(0, actual.Count());

            sources.StyleName = "1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890" +
                                "1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890" + 
                                "1234567890123456789012345678901234567890123456789012345";
            actual = O12Validator.Validate(sources);
            Assert.Equal(0, actual.Count());
            
            // ***** error case ******

            sources.StyleName = "1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890" +
                                "1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890" +
                                "12345678901234567890123456789012345678901234567890123456";
            actual = O12Validator.Validate(sources);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The actual length according to datatype 'string' is greater than the MaxLength value. The length must be smaller than or equal to 255."));

        }
           
        /// <summary>
        ///A test for Validate(element) - validating string pattern on attribute.
        ///</summary>
        [Fact]
        public void StringPatternAttributeValidationTest()
        {
              //<xsd:simpleType name="ST_Cy">
              //  <xsd:annotation>
              //    <xsd:documentation>Currency Simple Type</xsd:documentation>
              //  </xsd:annotation>
              //  <xsd:restriction base="xsd:string">
              //    <xsd:pattern value="\s*[0-9]*\.[0-9]{4}\s*" />
              //  </xsd:restriction>
              //</xsd:simpleType>


            var element = new DocumentFormat.OpenXml.VariantTypes.VTCurrency();

            // ***** good case ******
            element.Text = ".1234";
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Text = ".1234 ";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Text = " .1234";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Text = "456.1234";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Text = "    0.1234    ";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // ***** error case ******

            // pattern invalid
            element.Text = "";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_ElementValueDataTypeDetailed", actual.First().Id);

            element.Text = "12";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_ElementValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The Pattern constraint failed. The expected pattern is \\s*[0-9]*\\.[0-9]{4}\\s*."));

            element.Text = "12.345";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_ElementValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The Pattern constraint failed. The expected pattern is \\s*[0-9]*\\.[0-9]{4}\\s*."));

            element.Text = "12.34567";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_ElementValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The Pattern constraint failed. The expected pattern is \\s*[0-9]*\\.[0-9]{4}\\s*."));

            element.Text = "12. 345";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_ElementValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The Pattern constraint failed. The expected pattern is \\s*[0-9]*\\.[0-9]{4}\\s*."));

            element.Text = "1 2.345";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_ElementValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The Pattern constraint failed. The expected pattern is \\s*[0-9]*\\.[0-9]{4}\\s*."));

            element.Text = "ABCD";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_ElementValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The Pattern constraint failed. The expected pattern is \\s*[0-9]*\\.[0-9]{4}\\s*."));
        }
        
                
        /// <summary>
        ///A test for Validate(element) - validating NCName attribute.
        ///</summary>
        [Fact]
        public void NcnameAttributeValidationTest()
        {
            // in EcmaD wml.xsd
             
              //<xsd:complexType name="CT_CustomXmlRun">
              //  <xsd:sequence>
              //    <xsd:element name="customXmlPr" type="CT_CustomXmlPr" minOccurs="0" maxOccurs="1"></xsd:element>
              //    <xsd:group ref="EG_PContent" minOccurs="0" maxOccurs="unbounded" />
              //  </xsd:sequence>
              //  <xsd:attribute name="uri" type="ST_CustomXmlURI"></xsd:attribute>
              //  <xsd:attribute name="element" type="ST_NcName255" use="required"></xsd:attribute>
              //</xsd:complexType>

            // ***** good case ******
            var element = new CustomXmlRun();
            element.Element = "a";
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Element = "_b";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Element = "_b-a";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // ***** error case ******
            element.Element = "a:b";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'http://schemas.openxmlformats.org/wordprocessingml/2006/main:element' has invalid value 'a:b'. The string 'a:b' is not a valid 'http://www.w3.org/2001/XMLSchema:NCName' value.", actual.First().Description);

            var strBuilder = new System.Text.StringBuilder(256);
            for (int i = 0; i < 256; i++)
            {
                strBuilder.Append('A');
            }

            element.Element = strBuilder.ToString();
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The actual length according to datatype 'NCName' is greater than the MaxLength value. The length must be smaller than or equal to 255."));
        }

        /// <summary>
        ///A test for Validate(element) - validating token attribute.
        ///</summary>
        [Fact]
        public void TokenAttributeValidationTest()
        {
              //<xsd:simpleType name="ST_Guid">
              //  <xsd:restriction base="xsd:token">
              //    <xsd:pattern value="\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\}" />
              //  </xsd:restriction>
              //</xsd:simpleType>
              //<xsd:complexType name="CT_Guid">
              //  <xsd:attribute name="val" type="ST_Guid">
              //</xsd:complexType>

            // ***** good case ******
            var element = new DocPartId();
            element.Val = "{6A9B8B6F-5BD2-4BC8-9F70-7020E1357FB2}";
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // ***** error case ******
            element.Val = "";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The Pattern constraint failed. The expected pattern is \\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}."));

            // should have no internal sequences of two or more spaces
            element.Val = "{6A9B8B6F-    -4BC8-9F70-7020E1357FB2}";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'http://schemas.openxmlformats.org/wordprocessingml/2006/main:val' has invalid value '{6A9B8B6F-    -4BC8-9F70-7020E1357FB2}'. The string '{6A9B8B6F-    -4BC8-9F70-7020E1357FB2}' is not a valid 'http://www.w3.org/2001/XMLSchema:token' value.", actual.First().Description);

            // should have no leading or trailing spaces (#x20) 
            element.Val = " 6A9B8B6F-5BD2-4BC8-9F70-7020E1357FB2}";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'http://schemas.openxmlformats.org/wordprocessingml/2006/main:val' has invalid value ' 6A9B8B6F-5BD2-4BC8-9F70-7020E1357FB2}'. The string ' 6A9B8B6F-5BD2-4BC8-9F70-7020E1357FB2}' is not a valid 'http://www.w3.org/2001/XMLSchema:token' value.", actual.First().Description);

            // should not contain the carriage return (#xD), line feed (#xA) nor tab (#x9) characters
            element.Val = "{6A9B8B6F-5BD\x9-4BC8-9F70-7020E1357FB2}";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'http://schemas.openxmlformats.org/wordprocessingml/2006/main:val' has invalid value '{6A9B8B6F-5BD\x9-4BC8-9F70-7020E1357FB2}'. The string '{6A9B8B6F-5BD\x9-4BC8-9F70-7020E1357FB2}' is not a valid 'http://www.w3.org/2001/XMLSchema:token' value.", actual.First().Description);

            // pattern invalid
            element.Val.InnerText = "1234";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The Pattern constraint failed. The expected pattern is \\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}."));

            element.Val = "{*A9B8B6F-5BD2-4BC8-9F70-7020E1357FB2}";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The Pattern constraint failed. The expected pattern is \\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}."));
        }

        /// <summary>
        ///A test for Validate(element) - validating hexBinary attribute.
        ///</summary>
        [Fact]
        public void HexBinaryAttributeValidationTest()
        {
              //<xsd:simpleType name="ST_Panose">
              //  <xsd:restriction base="xsd:hexBinary">
              //    <xsd:length value="10" />
              //  </xsd:restriction>
              //</xsd:simpleType>
              //<xsd:complexType name="CT_Panose">
              //  <xsd:attribute name="val" type="ST_Panose" use="required">
              //</xsd:complexType>

      
            // ***** good case ******
            var element = new Panose1Number();
            element.Val = "1234567890ABCDEFabcd";
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = "ABCDEFabcdef12345678";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // ***** error case ******
            element.Val = "";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The attribute value cannot be empty."));

            element.Val.InnerText = "1234";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The actual length according to datatype 'hexBinary' is not equal to the specified length. The expected length is 10."));

            // hexBinary must contain an even number of characters. See bug #648390
            element.Val = "ABCDEFabcdef123456789";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'http://schemas.openxmlformats.org/wordprocessingml/2006/main:val' has invalid value 'ABCDEFabcdef123456789'. The string 'ABCDEFabcdef123456789' is not a valid 'http://www.w3.org/2001/XMLSchema:hexBinary' value.", actual.First().Description);

            // too long
            element.Val = "ABCDEFabcdef1234567890";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The actual length according to datatype 'hexBinary' is not equal to the specified length. The expected length is 10."));

            // invalid 'X'
            element.Val.InnerText = "ABCDEFabcdef1234567X";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'http://schemas.openxmlformats.org/wordprocessingml/2006/main:val' has invalid value 'ABCDEFabcdef1234567X'. The string 'ABCDEFabcdef1234567X' is not a valid 'http://www.w3.org/2001/XMLSchema:hexBinary' value.", actual.First().Description);

            // invalid 'X'
            element.Val.InnerText = "ABCDEFabcdefX1234567";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'http://schemas.openxmlformats.org/wordprocessingml/2006/main:val' has invalid value 'ABCDEFabcdefX1234567'. The string 'ABCDEFabcdefX1234567' is not a valid 'http://www.w3.org/2001/XMLSchema:hexBinary' value.", actual.First().Description);

        }

        /// <summary>
        ///A test for Validate(element) - validating base64Binary attribute.
        ///</summary>
        [Fact]
        public void Base64BinaryAttributeValidationTest()
        {
            // ***** good case ******
            var element = new DocumentProtection();
            element.Hash = "";
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Hash = "fUmpYmCMpTxTA4pfvlhKSAgB848=";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());


            element.Hash = "R3k/CLjN768ujxMXkKZOuw==";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());
            
            //// ***** error case ******
            element.Hash = "0";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'http://schemas.openxmlformats.org/wordprocessingml/2006/main:hash' has invalid value '0'. The string '0' is not a valid 'http://www.w3.org/2001/XMLSchema:base64Binary' value.", actual.First().Description);

            element.Hash = "R3k/CLjN768ujxMXkKZOuw==$";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'http://schemas.openxmlformats.org/wordprocessingml/2006/main:hash' has invalid value 'R3k/CLjN768ujxMXkKZOuw==$'. The string 'R3k/CLjN768ujxMXkKZOuw==$' is not a valid 'http://www.w3.org/2001/XMLSchema:base64Binary' value.", actual.First().Description);

            element.Hash = "*R3k/fUmpYmCMpTxTA4pfvlhKSAgB848=";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'http://schemas.openxmlformats.org/wordprocessingml/2006/main:hash' has invalid value '*R3k/fUmpYmCMpTxTA4pfvlhKSAgB848='. The string '*R3k/fUmpYmCMpTxTA4pfvlhKSAgB848=' is not a valid 'http://www.w3.org/2001/XMLSchema:base64Binary' value.", actual.First().Description);

        }

        /// <summary>
        ///A test for Validate(element) - validating base64Binary value.
        ///</summary>
        [Fact]
        public void Base64BinaryAttributeValidationTest2()
        {
            // ***** good case ******
            var element = new UniqueTag();
            element.Val = "";
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = "fUmpYmCMpTxTA4pfvlhKSAgB848=";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());


            element.Val = "R3k/CLjN768ujxMXkKZOuw==";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            //// ***** error case ******
            element.Val = "0";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'http://schemas.openxmlformats.org/wordprocessingml/2006/main:val' has invalid value '0'. The string '0' is not a valid 'http://www.w3.org/2001/XMLSchema:base64Binary' value.", actual.First().Description);

            element.Val = "R3k/CLjN768ujxMXkKZOuw==$";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'http://schemas.openxmlformats.org/wordprocessingml/2006/main:val' has invalid value 'R3k/CLjN768ujxMXkKZOuw==$'. The string 'R3k/CLjN768ujxMXkKZOuw==$' is not a valid 'http://www.w3.org/2001/XMLSchema:base64Binary' value.", actual.First().Description);

            element.Val = "*R3k/fUmpYmCMpTxTA4pfvlhKSAgB848=";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'http://schemas.openxmlformats.org/wordprocessingml/2006/main:val' has invalid value '*R3k/fUmpYmCMpTxTA4pfvlhKSAgB848='. The string '*R3k/fUmpYmCMpTxTA4pfvlhKSAgB848=' is not a valid 'http://www.w3.org/2001/XMLSchema:base64Binary' value.", actual.First().Description);

        }

        /// <summary>
        ///A test for Validate(element) - validating anyURI attribute.
        ///</summary>
        [Fact]
        public void AnyUriAttributeValidationTest()
        {
              //<xsd:complexType name="CT_Category">
              //  <xsd:attribute name="type" type="xsd:anyURI" use="required">
              //  <xsd:attribute name="pri" type="xsd:unsignedInt" use="required">
              //</xsd:complexType>
            
            // ***** good case ******

            var element = new DocumentFormat.OpenXml.Drawing.Diagrams.Category();
            element.Priority = 1;

            element.Type = "";
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Type = "http://temp";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Type = "http://microsoft.com";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Type = "http://a/b/c/d;p?q";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Type = "http://a/b/c/g;x?y#s";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Type = "<>";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Type = "http://a/../../g";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Type = "urn:schemas-microsoft-com:office:office";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // ***** error case ******
            element.Type = "http://temp##s";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'type' has invalid value 'http://temp##s'. The string 'http://temp##s' is not a valid 'Uri' value.", actual.First().Description);

            element.Type = "http:///temp";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'type' has invalid value 'http:///temp'. The string 'http:///temp' is not a valid 'Uri' value.", actual.First().Description);
        }

        /// <summary>
        ///A test for Validate(element) - validating ID attribute.
        ///</summary>
        [Fact]
        public void IdStringAttributeValidationTest()
        {
            // In customUI.xsd

              //<xsd:simpleType name="ST_UniqueID">
              //  <xsd:restriction base="xsd:ID">
              //    <xsd:minLength value="1" />
              //    <xsd:maxLength value="1024" />
              //  </xsd:restriction>
              //</xsd:simpleType>

              //<xsd:complexType name="CT_Item">
              //  <xsd:attribute name="id" type="ST_UniqueID" use="optional"></xsd:attribute>
              //  <xsd:attribute name="label" type="ST_String" use="optional"></xsd:attribute>
              //  <xsd:attribute name="image" type="ST_Uri" use="optional"></xsd:attribute>
              //  <xsd:attribute name="imageMso" type="ST_ID" use="optional"></xsd:attribute>
              //  <xsd:attribute name="screentip" type="ST_String" use="optional"></xsd:attribute>
              //  <xsd:attribute name="supertip" type="ST_String" use="optional"></xsd:attribute>
              //</xsd:complexType>

            // ***** good case ******

            var element = new DocumentFormat.OpenXml.Office.CustomUI.Item();

            element.Id = "A";
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Id = "\x4E00";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());
            
            element.Id = "A1";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Id = "_";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Id = "ABCD";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Id = "ABCD_1234-XY.00";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // ***** error case ******
            element.Id = "";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'id' has invalid value ''. The attribute value cannot be empty.", actual.First().Description);

            element.Id = "1A";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'id' has invalid value '1A'. The string '1A' is not a valid 'http://www.w3.org/2001/XMLSchema:ID' value.", actual.First().Description);

            element.Id = ".B";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'id' has invalid value '.B'. The string '.B' is not a valid 'http://www.w3.org/2001/XMLSchema:ID' value.", actual.First().Description);

            element.Id = "http:///temp";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'id' has invalid value 'http:///temp'. The string 'http:///temp' is not a valid 'http://www.w3.org/2001/XMLSchema:ID' value.", actual.First().Description);
        }

        /// <summary>
        ///A test for Validate(element) - validating QName attribute.
        ///</summary>
        [Fact]
        public void QNameAttributeValidationTest()
        {
            // In customUI.xsd

              //<xsd:simpleType name="ST_QID">
              //  <xsd:restriction base="xsd:QName">
              //    <xsd:minLength value="1" />
              //    <xsd:maxLength value="1024" />
              //  </xsd:restriction>
              //</xsd:simpleType>

              //<xsd:complexType name="CT_ControlCloneQat">
              //  <xsd:complexContent>
              //    <xsd:extension base="CT_ControlBase">
              //      <xsd:attribute name="id" type="ST_ID" use="optional"></xsd:attribute>
              //      <xsd:attribute name="idQ" type="ST_QID" use="optional"></xsd:attribute>
              //      <xsd:attributeGroup ref="AG_IDMso" />
              //      <xsd:attributeGroup ref="AG_Description" />
              //      <xsd:attributeGroup ref="AG_SizeAttributes" />
              //    </xsd:extension>
              //  </xsd:complexContent>
              //</xsd:complexType>

            // ***** good case ******

            var element = new DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbarControlClone();
            element.AddNamespaceDeclaration("A", "http://test");

            element.IdQ = "A";
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.IdQ = "A:b";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.IdQ = "A1";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.IdQ = "_";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.IdQ = "ABCD";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.IdQ = "ABCD_1234-XY.00";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // ***** error case ******
            element.IdQ = "";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The attribute value cannot be empty."));

            element.IdQ = ":";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'idQ' has invalid value ':'. The string ':' is not a valid 'http://www.w3.org/2001/XMLSchema:QName' value.", actual.First().Description);

            element.IdQ = ":A";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'idQ' has invalid value ':A'. The string ':A' is not a valid 'http://www.w3.org/2001/XMLSchema:QName' value.", actual.First().Description);

            element.IdQ = "A:";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'idQ' has invalid value 'A:'. The string 'A:' is not a valid 'http://www.w3.org/2001/XMLSchema:QName' value.", actual.First().Description);

            element.IdQ = "1A";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'idQ' has invalid value '1A'. The string '1A' is not a valid 'http://www.w3.org/2001/XMLSchema:QName' value.", actual.First().Description);

            element.IdQ = ".B";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'idQ' has invalid value '.B'. The string '.B' is not a valid 'http://www.w3.org/2001/XMLSchema:QName' value.", actual.First().Description);

            element.IdQ = "http:///temp";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'idQ' has invalid value 'http:///temp'. The string 'http:///temp' is not a valid 'http://www.w3.org/2001/XMLSchema:QName' value.", actual.First().Description);
        }

        /// <summary>
        ///A test for Validate(element) - validating list attribute.
        ///</summary>
        [Fact]
        public void ListAttributeValidationTest()
        {
            // ST_AxisType is enum
            
              //<xsd:simpleType name="ST_AxisTypes">
              //  <xsd:annotation>
              //    <xsd:documentation>Axis Type List</xsd:documentation>
              //  </xsd:annotation>
              //  <xsd:list itemType="ST_AxisType" />
              //</xsd:simpleType>

            var element = new DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf();

              //<xsd:simpleType name="ST_CellSpan">
              //  <xsd:restriction base="xsd:string" />
              //</xsd:simpleType>

              //<xsd:simpleType name="ST_CellSpans">
              //  <xsd:list itemType="ST_CellSpan" />
              //</xsd:simpleType>

            var row = new DocumentFormat.OpenXml.Spreadsheet.Row();

            // ***** good case ******
            row.Spans = new ListValue<StringValue>();
            row.Spans.InnerText = "a";
            var actual = O12Validator.Validate(row);
            Assert.Equal(0, actual.Count());

            row.Spans.InnerText = "a a";
            actual = O12Validator.Validate(row);
            Assert.Equal(0, actual.Count());

            row.Spans.InnerText = "abc";
            actual = O12Validator.Validate(row);
            Assert.Equal(0, actual.Count());

            row.Spans.InnerText = "abc 123";
            actual = O12Validator.Validate(row);
            Assert.Equal(0, actual.Count());

            row.Spans.InnerText = "abc a  123";
            actual = O12Validator.Validate(row);
            Assert.Equal(0, actual.Count());

            // ***** error case ******
            row.Spans.InnerText = "";
            actual = O12Validator.Validate(row);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The attribute value cannot be empty."));

            row.Spans.InnerText = " ";
            actual = O12Validator.Validate(row);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'spans' has invalid value ' '.", actual.First().Description);

              //<xsd:simpleType name="ST_Ints">
              //  <xsd:list itemType="xsd:int" />
              //</xsd:simpleType>
            // ***** good case ******
            element.Start = new ListValue<Int32Value>();
            element.Start.InnerText = "1";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Start.InnerText = "1 -2";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Start.InnerText = "123";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Start.InnerText = "+123 456";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Start.InnerText = "123 -4  56";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // ***** error case ******
            element.Start.InnerText = "";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith(" The attribute value cannot be empty."));

            element.Start.InnerText = "a";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'st' has invalid value 'a'.", actual.First().Description);

            element.Start.InnerText = "a 1";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'st' has invalid value 'a 1'.", actual.First().Description);

            element.Start.InnerText = "1 a";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'st' has invalid value '1 a'.", actual.First().Description);

            element.Start.InnerText = "1 23 4a";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("The attribute 'st' has invalid value '1 23 4a'.", actual.First().Description);

   
        }
       
        /// <summary>
        ///A test for Validate(element) - validating union attribute.
        ///</summary>
        [Fact]
        public void UnionAttributeValidationTest()
        {
            //<xsd:simpleType name="ST_HexColorAuto">
            //    <xsd:restriction base="xsd:string">
            //      <xsd:enumeration value="auto">
            //      </xsd:enumeration>
            //    </xsd:restriction>
            //  </xsd:simpleType>
            //  <xsd:simpleType name="ST_HexColorRGB">
            //    <xsd:restriction base="xsd:hexBinary">
            //      <xsd:length value="3" fixed="true" />
            //    </xsd:restriction>
            //  </xsd:simpleType>
            //  <xsd:simpleType name="ST_HexColor">
            //    <xsd:union memberTypes="ST_HexColorAuto ST_HexColorRGB" />
            //  </xsd:simpleType>
            //  <xsd:complexType name="CT_Color">
            //    <xsd:attribute name="val" type="ST_HexColor" use="required">
            //    <xsd:attribute name="themeColor" type="ST_ThemeColor" use="optional">
            //    <xsd:attribute name="themeTint" type="ST_UcharHexNumber" use="optional">
            //    <xsd:attribute name="themeShade" type="ST_UcharHexNumber" use="optional">
            //  </xsd:complexType>

            var element = new DocumentFormat.OpenXml.Wordprocessing.Color();
            element.Val = new StringValue();

            // ***** good case ******
            element.Val.InnerText = "auto";
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val.InnerText = "123456";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val.InnerText = "FF12AB";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // ***** error case ******
            element.Val.InnerText = "";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeUnionFailedEx", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith("is not valid according to any of the memberTypes of the union."));

            element.Val.InnerText = "auto1";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeUnionFailedEx", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith("is not valid according to any of the memberTypes of the union."));

            element.Val.InnerText = "1234567";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeUnionFailedEx", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith("is not valid according to any of the memberTypes of the union."));

            element.Val.InnerText = "1234";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeUnionFailedEx", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith("is not valid according to any of the memberTypes of the union."));
        }

        /// <summary>
        ///A test for Validate(element) - validating union attribute.
        ///</summary>
        [Fact]
        public void UnionAttributeValidationTest2()
        {
              //<xsd:simpleType name="ST_NonZeroDecimalNumber">
              //  <xsd:union memberTypes="ST_UnsignedDecimalNumberMin1 ST_SignedDecimalNumberMax-1" />
              //</xsd:simpleType>
              //<xsd:complexType name="CT_NonZeroDecimalNumber">
              //  <xsd:attribute name="val" type="ST_NonZeroDecimalNumber" use="required"></xsd:attribute>
              //</xsd:complexType>
              //<xsd:simpleType name="ST_UnsignedDecimalNumberMin1">
              //  <xsd:restriction base="xsd:int">
              //    <xsd:minInclusive value="1" />
              //  </xsd:restriction>
              //</xsd:simpleType>
              //<xsd:simpleType name="ST_SignedDecimalNumberMax-1">
              //  <xsd:restriction base="xsd:int">
              //    <xsd:maxInclusive value="-1" />
              //  </xsd:restriction>
              //</xsd:simpleType>

            var element = new DocumentFormat.OpenXml.Wordprocessing.DivId();
            element.Val = new StringValue();

            // ***** good case ******
            element.Val.InnerText = "1";
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val.InnerText = Int32.MaxValue.ToString();
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val.InnerText = Int32.MinValue.ToString();
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val.InnerText = "-1";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // ***** error case ******
            element.Val.InnerText = "";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeUnionFailedEx", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith("is not valid according to any of the memberTypes of the union."));

            element.Val.InnerText = "0";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeUnionFailedEx", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith("is not valid according to any of the memberTypes of the union."));

            element.Val.InnerText = "-0";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeUnionFailedEx", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith("is not valid according to any of the memberTypes of the union."));

            element.Val.InnerText = "ABC";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeUnionFailedEx", actual.First().Id);
            Assert.True(actual.First().Description.EndsWith("is not valid according to any of the memberTypes of the union."));
        }

        
        /// <summary>
        ///A test for Validate(element) - validating ST_OnOff attribute.
        ///</summary>
        [Fact]
        public void OnOffValueValidationTest2()
        {
            Bold element = new Bold();

            // ***** good case ******
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = true;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = false;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val.InnerText = "true";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val.InnerText = "false";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val.InnerText = "on";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val.InnerText = "off";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val.InnerText = "1";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val.InnerText = "0";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // ***** error case ******
            element.Val.InnerText = "";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("/w:b[1]", actual.First().Path.XPath);
            Assert.True(actual.First().Description.EndsWith(" The attribute value cannot be empty."));

            element.Val.InnerText = "Noo";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("/w:b[1]", actual.First().Path.XPath);
            Assert.True(actual.First().Description.EndsWith(" The Enumeration constraint failed."));
            Assert.Equal("The attribute 'http://schemas.openxmlformats.org/wordprocessingml/2006/main:val' has invalid value 'Noo'. The Enumeration constraint failed.", actual.First().Description);

            element.Val.InnerText = "On";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("/w:b[1]", actual.First().Path.XPath);
            Assert.True(actual.First().Description.EndsWith(" The Enumeration constraint failed."));
            Assert.Equal("The attribute 'http://schemas.openxmlformats.org/wordprocessingml/2006/main:val' has invalid value 'On'. The Enumeration constraint failed.", actual.First().Description);

            element.Val.InnerText = "False";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("/w:b[1]", actual.First().Path.XPath);
            Assert.True(actual.First().Description.EndsWith(" The Enumeration constraint failed."));
            Assert.Equal("The attribute 'http://schemas.openxmlformats.org/wordprocessingml/2006/main:val' has invalid value 'False'. The Enumeration constraint failed.", actual.First().Description);
        }

                
        /// <summary>
        ///A test for Validate(element) - validating ST_TrueFalseBlank attribute.
        ///This type is mapped to TrueFalseBlankValue.
        ///</summary>
        [Fact]
        public void TrueFalseBlankValueValidationTest2()
        {
              //<xsd:simpleType name="ST_TrueFalseBlank">
              //  <xsd:annotation>
              //    <xsd:documentation>Boolean Value with Blank [False] State</xsd:documentation>
              //  </xsd:annotation>
              //  <xsd:restriction base="xsd:string">
              //    <xsd:enumeration value="t">
              //    <xsd:enumeration value="f">
              //    <xsd:enumeration value="true">
              //    <xsd:enumeration value="false">
              //    <xsd:enumeration value="">
              //      <xsd:annotation>
              //        <xsd:documentation>Blank – Logical False</xsd:documentation>
              //      </xsd:annotation>
              //    </xsd:enumeration>
              //  </xsd:restriction>
              //</xsd:simpleType>

            var element = new DocumentFormat.OpenXml.Vml.ShapeHandle();

            // ***** good case ******
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.InvertX = true;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.InvertX = false;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.InvertX.InnerText = "true";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.InvertX.InnerText = "false";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.InvertX.InnerText = "t";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.InvertX.InnerText = "f";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.InvertX.InnerText = "";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // ***** error case ******
            element.InvertX.InnerText = "Noo";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("/v:h[1]", actual.First().Path.XPath);
            Assert.True(actual.First().Description.EndsWith(" The Enumeration constraint failed."));
            Assert.Equal("The attribute 'invx' has invalid value 'Noo'. The Enumeration constraint failed.", actual.First().Description);

            element.InvertX.InnerText = "True";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("/v:h[1]", actual.First().Path.XPath);
            Assert.True(actual.First().Description.EndsWith(" The Enumeration constraint failed."));
            Assert.Equal("The attribute 'invx' has invalid value 'True'. The Enumeration constraint failed.", actual.First().Description);

            element.InvertX.InnerText = "F";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("/v:h[1]", actual.First().Path.XPath);
            Assert.True(actual.First().Description.EndsWith(" The Enumeration constraint failed."));
            Assert.Equal("The attribute 'invx' has invalid value 'F'. The Enumeration constraint failed.", actual.First().Description);
        }

        #endregion

        #region unit test with test file data

        /// <summary>
        ///A test for Validate(Stream) - validating Spreadsheet package.
        ///</summary>
        [Fact]
        public void SpreadsheetDocumentValidatingTest()
        {

            using (Stream stream = new MemoryStream(TestFileStreams.basicspreadsheet, false))
            {
                // use stream
                IEnumerable<ValidationErrorInfo> actual;
                using (SpreadsheetDocument sdoc = SpreadsheetDocument.Open(stream, false))
                {
                    actual = O12Validator.Validate(sdoc);
                    Assert.Equal(0, actual.Count());

                    // Office2010
                    actual = O14Validator.Validate(sdoc);
                    Assert.Equal(0, actual.Count());
                }
            }
        }

        /// <summary>
        ///A test for Validate(OpenXmlPackage) - validating Wordprocessing package.
        ///</summary>
        [Fact]
        public void WordprocessingDocumentValidatingTest()
        {
            using (Stream stream = new MemoryStream(TestFileStreams.complex0docx, false))
            {
                // use OpenXmlPackage
                using (WordprocessingDocument wordTestDocument = WordprocessingDocument.Open(stream, false))
                {
                    IEnumerable<ValidationErrorInfo> actual;
                    actual = O12Validator.Validate(wordTestDocument);
                    Assert.Equal(1, actual.Count()); // The value 'actual' should contain one validation error for 'doNotEmbedSmartTags' in the test document.

                    // Office2010
                    actual = O14Validator.Validate(wordTestDocument);
                    Assert.Equal(1, actual.Count()); // The value 'actual' should contain one validation error for 'doNotEmbedSmartTags' in the test document.
                }
            }
        }

        /// <summary>
        ///A test for Validate(OpenXmlPackage) - validating 2010 Wordprocessing package.
        ///</summary>
        [Fact]
        public void Wordprocessing2010DocumentValidatingTest()
        {
            using (Stream stream = new MemoryStream(TestFileStreams.complex2010docx, false))
            {
                // use OpenXmlPackage
                using (WordprocessingDocument wordTestDocument = WordprocessingDocument.Open(stream, false))
                {
                    IEnumerable<ValidationErrorInfo> actual;
                    actual = O12Validator.Validate(wordTestDocument);
                    // There are Office2010 elements and attributes in the doucment, so there are should validation errors.
                    Assert.Equal(34, actual.Count()); // The value 'actual' should contain 34 validtion error including 'doNotEmbedSmartTags' in the test document.

                    // Office2010
                    actual = O14Validator.Validate(wordTestDocument);
                    Assert.Equal(1, actual.Count()); // The value 'actual' should contain one validtion error for 'doNotEmbedSmartTags' in the test document.
                }
            }
        }

        /// <summary>
        ///A test for Validate(Stream) - validating Presentation package.
        ///</summary>
        [Fact]
        public void PresentationDocumentValidatingTest()
        {

            using (Stream stream = new MemoryStream(TestFileStreams.o09_Performance_typical_pptx, false))
            {
                using (PresentationDocument pDoc = PresentationDocument.Open(stream, false))
                {
                    // use stream
                    IEnumerable<ValidationErrorInfo> actual;
                    actual = O12Validator.Validate(pDoc);
                    Assert.Equal(109, actual.Count()); // The value 'actual' should contain 109 validtion errors for 'smtClean' in the test document.

                    // Office2010
                    actual = O14Validator.Validate(pDoc);
                    Assert.Equal(109, actual.Count()); // The value 'actual' should contain 109 validtion errors for 'smtClean' in the test document.
                }
            }
        }

        /// <summary>
        ///A test for Validate(OpenXmlPart) - validating Workbook part.
        ///</summary>
        [Fact]
        public void SpreadsheetPartValidatingTest()
        {

            using (Stream stream = new MemoryStream(TestFileStreams.basicspreadsheet, false))
            {
                using (SpreadsheetDocument testDocument = SpreadsheetDocument.Open(stream, false))
                {
                    IEnumerable<ValidationErrorInfo> actual;
                    // validate the workbook part only.
                    actual = O12Validator.Validate(testDocument.WorkbookPart);
                    Assert.Equal(0, actual.Count());

                    // Office2010
                    actual = O14Validator.Validate(testDocument.WorkbookPart);
                    Assert.Equal(0, actual.Count());
                }
            }
        }

        /// <summary>
        ///A test for Validate(OpenXmlPart) - validating MainDocument part.
        ///</summary>
        [Fact]
        public void WordprocessingPartValidatingTest()
        {
            using (Stream stream = new MemoryStream(TestFileStreams.complex0docx, false))
            {
                using (WordprocessingDocument testDocument = WordprocessingDocument.Open(stream, false))
                {
                    IEnumerable<ValidationErrorInfo> actual;
                    // validate the main document part only
                    actual = O12Validator.Validate(testDocument.MainDocumentPart);
                    Assert.Equal(0, actual.Count());

                    // Office2010
                    actual = O14Validator.Validate(testDocument.MainDocumentPart);
                    Assert.Equal(0, actual.Count());
                }
            }
        }

        /// <summary>
        ///A test for Validate(OpenXmlPart) - validating StyleDefinitionsPart and StylesWithEffectsPart.
        ///</summary>
        [Fact]
        public void Wordprocessing2010PartValidatingTest()
        {
            using (Stream stream = new MemoryStream(TestFileStreams.complex2010docx, false))
            {
                using (WordprocessingDocument testDocument = WordprocessingDocument.Open(stream, false))
                {
                    IEnumerable<ValidationErrorInfo> actual;

                    // validate the StyleDefinitionsPart
                    actual = O12Validator.Validate(testDocument.MainDocumentPart.StyleDefinitionsPart);
                    Assert.Equal(0, actual.Count());

                    // Office2010
                    actual = O14Validator.Validate(testDocument.MainDocumentPart.StyleDefinitionsPart);
                    Assert.Equal(0, actual.Count());

                    // can not validate the StylesWithEffectsPart against Office2007
                    //actual = O12Validator.Validate(testDocument.MainDocumentPart.StylesWithEffectsPart);
                    //Assert.Equal(0, actual.Count());

                    // Office2010
                    actual = O14Validator.Validate(testDocument.MainDocumentPart.StylesWithEffectsPart);
                    Assert.Equal(0, actual.Count());
                }
            }
        }
        /// <summary>
        ///A test for Validate(OpenXmlPart) - validating Slide part.
        ///</summary>
        [Fact]
        public void SlidePartValidatingTest()
        {
            using (Stream stream = new MemoryStream(TestFileStreams.o09_Performance_typical_pptx, false))
            {
                using (PresentationDocument testDocument = PresentationDocument.Open(stream, false))
                {
                    IEnumerable<ValidationErrorInfo> actual;
                    // validate one Slide part only
                    actual = O12Validator.Validate(testDocument.PresentationPart.SlideParts.First());
                    Assert.Equal(0, actual.Count());

                    // Office2010
                    actual = O14Validator.Validate(testDocument.PresentationPart.SlideParts.First());
                    Assert.Equal(0, actual.Count());
                }
            }
        }

        /// <summary>
        ///A test for Validate(element) - Workbook element.
        ///</summary>
        [Fact]
        public void SpreadsheetElementValidatingTest()
        {

            using (Stream stream = new MemoryStream(TestFileStreams.basicspreadsheet, false))
            {
                using (SpreadsheetDocument testDocument = SpreadsheetDocument.Open(stream, false))
                {
                    IEnumerable<ValidationErrorInfo> actual;
                    // validate the workbook part only.
                    actual = O12Validator.Validate(testDocument.WorkbookPart.Workbook);
                    Assert.Equal(0, actual.Count());

                    // Office2010
                    actual = O14Validator.Validate(testDocument.WorkbookPart.Workbook);
                    Assert.Equal(0, actual.Count());
                }
            }
        }

        /// <summary>
        ///A test for Validate(element) - Document element.
        ///</summary>
        [Fact]
        public void WordprocessingElementValidatingTest()
        {
            using (Stream stream = new MemoryStream(TestFileStreams.complex0docx, false))
            {
                using (WordprocessingDocument testDocument = WordprocessingDocument.Open(stream, false))
                {
                    IEnumerable<ValidationErrorInfo> actual;
                    // validate the main document part only
                    actual = O12Validator.Validate(testDocument.MainDocumentPart.Document);
                    Assert.Equal(0, actual.Count());

                    // Office2010
                    actual = O14Validator.Validate(testDocument.MainDocumentPart.Document);
                    Assert.Equal(0, actual.Count());
                }
            }
        }

        /// <summary>
        ///A test for Validate(element) - Slide element.
        ///</summary>
        [Fact]
        public void SlideElementValidatingTest()
        {
            using (Stream stream = new MemoryStream(TestFileStreams.o09_Performance_typical_pptx, false))
            {
                using (PresentationDocument testDocument = PresentationDocument.Open(stream, false))
                {
                    IEnumerable<ValidationErrorInfo> actual;
                    // validate the Slide element
                    actual = O12Validator.Validate(testDocument.PresentationPart.SlideParts.First().Slide);
                    Assert.Equal(0, actual.Count());

                    // Office2010
                    actual = O14Validator.Validate(testDocument.PresentationPart.SlideParts.First().Slide);
                    Assert.Equal(0, actual.Count());
                }
            }
        }


        /// <summary>
        ///A test for Validate(part) and Validate(element).
        ///</summary>
        [Fact]
        public void PartValidatingTest()
        {
            using (Stream stream = new MemoryStream())
            {
                using (var testDocument = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
                {
                    var mainDocPart = testDocument.AddMainDocumentPart();
                    var paragraph = new DocumentFormat.OpenXml.Wordprocessing.Paragraph(new Body());
                    var document = new Document(new Body(paragraph));

                    IEnumerable<ValidationErrorInfo> actual;
                    // validate the element
                    actual = O12Validator.Validate(paragraph);
                    Assert.Equal(1, actual.Count());
                    var error = actual.First();
                    Assert.Null(error.Part);
                    Assert.Same(paragraph, error.Node);

                    mainDocPart.Document = document;
                    actual = O12Validator.Validate(paragraph);
                    Assert.Equal(1, actual.Count());
                    error = actual.First();
                    Assert.Same(mainDocPart, error.Part); // should return the part.
                    Assert.Same(paragraph, error.Node);
                }
            }
        }

                
        /// <summary>
        ///A test for Validate package structure.
        ///</summary>
        [Fact]
        public void PackageStuctureValidatingTest()
        {
            OpenXmlValidator validator = new OpenXmlValidator();
            byte[] buffer = new byte[1024 * 1024];
            using (var stream = new MemoryStream())
            {
                using (WordprocessingDocument wordDoc = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
                {
                    var mainPart = wordDoc.AddMainDocumentPart();
                    mainPart.Document = new Document();
                    mainPart.Document.Save();

                    var commentsPart = mainPart.AddNewPart<WordprocessingCommentsPart>();
                    commentsPart.Comments = new DocumentFormat.OpenXml.Wordprocessing.Comments();
                    commentsPart.Comments.Save();

                    var commentsPart2 = mainPart.AddExtendedPart(WordprocessingCommentsPart.RelationshipTypeConstant, WordprocessingCommentsPart.ContentTypeConstant, "xml");
                    commentsPart.Comments.SaveToPart(commentsPart2);

                    mainPart.CreateRelationship(mainPart.Uri, System.IO.Packaging.TargetMode.Internal, mainPart.RelationshipType);

                    wordDoc.Close();
                }
                stream.Flush();

                using (WordprocessingDocument loadedDoc = WordprocessingDocument.Open(stream, false))
                {
                    var errors = validator.Validate(loadedDoc);
                    Assert.Equal(2, errors.Count());
                    Assert.Same(loadedDoc.MainDocumentPart, errors.First().Part);
                    Assert.Same(loadedDoc.MainDocumentPart, errors.First().RelatedPart);
                    Assert.Equal("Pkg_PartIsNotAllowed", errors.First().Id);
                    Assert.Equal("/word/document.xml", errors.First().Path.PartUri.ToString());
                    Assert.Equal("The package/part 'MainDocumentPart{/word/document.xml}' cannot have a relationship that targets part 'MainDocumentPart{/word/document.xml}'.", errors.First().Description);
                    Assert.Same(loadedDoc.MainDocumentPart, errors.ElementAt(1).Part);
                    Assert.Equal("Pkg_OnlyOnePartAllowed", errors.ElementAt(1).Id);
                    Assert.Equal("/word/document.xml", errors.ElementAt(1).Path.PartUri.ToString());
                    Assert.Equal("The package/part 'MainDocumentPart{/word/document.xml}' can only have one instance of relationship that targets part 'WordprocessingCommentsPart'.", errors.ElementAt(1).Description);
                }
            }

            using (var stream = new MemoryStream())
            {
                using (var pptdoc = PresentationDocument.Create(stream, PresentationDocumentType.Presentation))
                {
                    var presettationPart = pptdoc.AddPresentationPart();
                    presettationPart.Presentation = new DocumentFormat.OpenXml.Presentation.Presentation();
                    presettationPart.Presentation.Save();

                    // must have a SlideMasterPart.
                    var errors = validator.Validate(pptdoc);
                    Assert.Equal(2, errors.Count());
                    Assert.Same(presettationPart, errors.First().Part);
                    Assert.Same(null, errors.First().RelatedPart);
                    Assert.Equal("Pkg_RequiredPartDoNotExist", errors.First().Id);
                    Assert.Equal("/ppt/presentation.xml", errors.First().Path.PartUri.ToString());
                    Assert.Equal("A required part 'SlideMasterPart' is missing.", errors.First().Description);
                }
            }
        }

                
        /// <summary>
        ///A test for invalid xml in part.
        ///</summary>
        [Fact]
        public void InvalidXmlInPartValidatingTest()
        {
            using (var stream = new MemoryStream())
            {
                using (WordprocessingDocument wordDoc = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
                {
                    var mainPart = wordDoc.AddMainDocumentPart();
                    mainPart.Document = new Document();
                    mainPart.Document.Save();

                    var commentsPart = mainPart.AddNewPart<WordprocessingCommentsPart>();
                    var comments = new DocumentFormat.OpenXml.Wordprocessing.Comments();

                    using (var sw = new StreamWriter(commentsPart.GetStream()))
                    {
                        sw.WriteLine("<w:comments xmlns:w=\"{0}\" ><w:comment></w:comment></w:comments>", comments.NamespaceUri);
                    }

                    OpenXmlValidator validator = new OpenXmlValidator();
                    var errors = validator.Validate(commentsPart);
                    Assert.Equal(2, errors.Count());

                    commentsPart.SetPartRootElementToNull();

                    using (var sw = new StreamWriter(commentsPart.GetStream()))
                    {
                        sw.WriteLine("<w:comments xmlns:w=\"{0}\" ><w:commentX><invalid></w:comment></w:comments>", comments.NamespaceUri);
                    }

                    errors = validator.Validate(commentsPart);
                    Assert.Equal(1, errors.Count());
                    Assert.Same(commentsPart, errors.First().Part);
                    Assert.Equal("ExceptionError", errors.First().Id);
                    Assert.Equal("/word/comments.xml", errors.First().Path.PartUri.ToString());

                }
            }
        }

        /// <summary>
        ///A test for OpenXmlValidator.MaxNumberOfErrors
        ///</summary>
        [Fact]
        public void MaxErrorsTest()
        {
            using (Stream stream = new MemoryStream(TestFileStreams._5Errors, false))
            {
                using (WordprocessingDocument testDocument = WordprocessingDocument.Open(stream, false))
                {
                    IEnumerable<ValidationErrorInfo> actual;
                    // validate the main document part only
                    actual = O12Validator.Validate(testDocument);
                    Assert.Equal(5, actual.Count());
                    actual = O12Validator.Validate(testDocument.MainDocumentPart);
                    Assert.Equal(2, actual.Count());
                    actual = O12Validator.Validate(testDocument.MainDocumentPart.Document);
                    Assert.Equal(2, actual.Count());
                    
                    int savedMaxErrors = O12Validator.MaxNumberOfErrors;

                    O12Validator.MaxNumberOfErrors = 4;
                    actual = O12Validator.Validate(testDocument);
                    Assert.Equal(4, actual.Count());
                    actual = O12Validator.Validate(testDocument.MainDocumentPart);
                    Assert.Equal(2, actual.Count());
                    actual = O12Validator.Validate(testDocument.MainDocumentPart.Document);
                    Assert.Equal(2, actual.Count());
                    
                    O12Validator.MaxNumberOfErrors = 3;
                    actual = O12Validator.Validate(testDocument);
                    Assert.Equal(3, actual.Count());
                    actual = O12Validator.Validate(testDocument.MainDocumentPart);
                    Assert.Equal(2, actual.Count());
                    actual = O12Validator.Validate(testDocument.MainDocumentPart.Document);
                    Assert.Equal(2, actual.Count());
                    
                    O12Validator.MaxNumberOfErrors = 1;
                    actual = O12Validator.Validate(testDocument);
                    Assert.Equal(1, actual.Count());
                    actual = O12Validator.Validate(testDocument.MainDocumentPart);
                    Assert.Equal(1, actual.Count());
                    actual = O12Validator.Validate(testDocument.MainDocumentPart.Document);
                    Assert.Equal(1, actual.Count());

                    O12Validator.MaxNumberOfErrors = savedMaxErrors;
                }
            }
        }

        #endregion

        #region new test regarding O14 support

        /// <summary>
        /// A test for the newly added element.
        /// </summary>
        [Fact]
        public void DspInDiagramTest()
        {
            DocumentFormat.OpenXml.Office.Drawing.Drawing element = new DocumentFormat.OpenXml.Office.Drawing.Drawing();
            element.ShapeTree = new DocumentFormat.OpenXml.Office.Drawing.ShapeTree(
                                                new DocumentFormat.OpenXml.Office.Drawing.GroupShapeNonVisualProperties(
                                                        new DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties() { Id = 0, Name = string.Empty },
                                                        new DocumentFormat.OpenXml.Office.Drawing.NonVisualGroupDrawingShapeProperties()
                                                        ),
                                                new DocumentFormat.OpenXml.Office.Drawing.GroupShapeProperties()
                                                );


            // ***** good case ******
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());
        }


        ///<summary>
        ///ExpectedExceptionOnValidate1Test.
        ///</summary>
        [Fact]
        public void ExpectedExceptionOnValidate1Test()
        {
            Assert.Throws<System.InvalidOperationException>(() =>
            {
                using (var stream = new MemoryStream())
                {
                    using (WordprocessingDocument wordDoc = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document))
                    {
                        wordDoc.AddMainDocumentPart();
                        wordDoc.MainDocumentPart.AddNewPart<StylesWithEffectsPart>();

                        var actual = O12Validator.Validate(wordDoc.MainDocumentPart.StylesWithEffectsPart);
                    }
                }
            });
        }

        ///<summary>
        ///ExpectedExceptionOnValidate2Test.
        ///</summary>
        [Fact]
        public void ExpectedExceptionOnValidate2Test()
        {
            Assert.Throws<System.InvalidOperationException>(() =>
            {
                var o14Element = new DocumentFormat.OpenXml.Wordprocessing.StartBorder();
                var actual = O12Validator.Validate(o14Element);
            });
        }

                
        /// <summary>
        /// A test for the O14 schema constraint data.
        /// </summary>
        [Fact]
        public void O14SchemaConstraintDataTest()
        {
            /************************           
              <xs:complexType name="CT_TblBorders">
                <xs:sequence>
                  <xs:element name="top" type="CT_Border" minOccurs="0">
                  <xs:element name="left" type="CT_Border" minOccurs="0">
                  <xs:element name="start" type="CT_Border" minOccurs="0" ofapi:available="o14" />
                  <xs:element name="bottom" type="CT_Border" minOccurs="0">
                  <xs:element name="right" type="CT_Border" minOccurs="0">
                  <xs:element name="end" type="CT_Border" minOccurs="0" ofapi:available="o14" />
                  <xs:element name="insideH" type="CT_Border" minOccurs="0">
                  <xs:element name="insideV" type="CT_Border" minOccurs="0">
                </xs:sequence>
              </xs:complexType>
               *********************/

            var borders = new DocumentFormat.OpenXml.Wordprocessing.TableBorders();
            borders.TopBorder = new DocumentFormat.OpenXml.Wordprocessing.TopBorder() { Val = BorderValues.Apples };

            var actual = O12Validator.Validate(borders);
            Assert.Equal(0, actual.Count());

            // add an O14 child
            borders.StartBorder = new StartBorder() { Val = BorderValues.ArchedScallops };
            actual = O12Validator.Validate(borders);
            // should report error in O12
            Assert.Equal(1, actual.Count());
            Assert.Same(borders, actual.First().Node);
            Assert.Same(borders.StartBorder, actual.First().RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", actual.First().Id);
            Assert.False(actual.First().Description.Contains(ValidationErrorStrings.Fmt_ListOfPossibleElements));

            // should not report error in O14
            actual = O14Validator.Validate(borders);
            Assert.Equal(0, actual.Count());

            borders.RightBorder = new DocumentFormat.OpenXml.Wordprocessing.RightBorder() { Val = BorderValues.BabyPacifier };
            
            actual = O12Validator.Validate(borders);
            // should report error in O12
            Assert.Equal(1, actual.Count());
            Assert.Same(borders, actual.First().Node);
            Assert.Same(borders.StartBorder, actual.First().RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", actual.First().Id);
            Assert.False(actual.First().Description.Contains(ValidationErrorStrings.Fmt_ListOfPossibleElements));

            // should not report error in O14
            actual = O14Validator.Validate(borders);
            Assert.Equal(0, actual.Count());

            borders.EndBorder = new EndBorder() { Val = BorderValues.Cabins };

            actual = O12Validator.Validate(borders);
            // should report error in O12
            Assert.Equal(1, actual.Count());
            Assert.Same(borders, actual.First().Node);
            Assert.Same(borders.StartBorder, actual.First().RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", actual.First().Id);
            Assert.False(actual.First().Description.Contains(ValidationErrorStrings.Fmt_ListOfPossibleElements));
            
            // should not report error in O14
            actual = O14Validator.Validate(borders);
            Assert.Equal(0, actual.Count());

            // remove a required attribute from the O14 element.
            borders.EndBorder.Val = null;
            // should report attribute error in O14
            actual = O14Validator.Validate(borders);
            Assert.Equal(1, actual.Count());
            Assert.Same(borders.EndBorder, actual.First().Node);
            Assert.Null(actual.First().RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_MissRequiredAttribute", actual.First().Id);
        }

        /// <summary>
        /// Test merged Enum validation.
        /// </summary>
        [Fact]
        public void EnumValidationO14SupportTest()
        {
            var element = new DocumentFormat.OpenXml.Wordprocessing.LeftBorder();

            // ***** good case ******

            // the following values are valid in both Office2007 and Office2010.
            element.Val = BorderValues.Apples;
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            actual = O14Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = BorderValues.BabyPacifier;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            actual = O14Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = BorderValues.Cabins;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            actual = O14Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = BorderValues.DashDotStroked;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            actual = O14Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = BorderValues.Earth1;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            actual = O14Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Val = BorderValues.Fans;
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            actual = O14Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // ***** error case ******

            // following are invalid for both Office2007 and Office2010
            element.Val.InnerText = "";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("/w:left[1]", actual.First().Path.XPath);
            Assert.True(actual.First().Description.EndsWith(" The Enumeration constraint failed."));

            actual = O14Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("/w:left[1]", actual.First().Path.XPath);
            Assert.True(actual.First().Description.EndsWith(" The Enumeration constraint failed."));

            // 
            element.Val.InnerText = "Noo";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("/w:left[1]", actual.First().Path.XPath);
            Assert.True(actual.First().Description.EndsWith(" The Enumeration constraint failed."));

            actual = O14Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("/w:left[1]", actual.First().Path.XPath);
            Assert.True(actual.First().Description.EndsWith(" The Enumeration constraint failed."));
            
            // Invalid character case.
            element.Val.InnerText = "Dashed"; // the correct value is "dashed"
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("/w:left[1]", actual.First().Path.XPath);
            Assert.True(actual.First().Description.EndsWith(" The Enumeration constraint failed."));

            actual = O14Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("/w:left[1]", actual.First().Path.XPath);
            Assert.True(actual.First().Description.EndsWith(" The Enumeration constraint failed."));

            //// assign a value which is valid in Office2010, but not in Office2007
            element.Val = BorderValues.TriangleCircle1;

            // should report error in O12 validator.
            // In M5, the enum is also available in O12
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());
            //Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            //Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            //Assert.Equal("/w:left[1]", actual.First().Path.XPath);
            //Assert.True(actual.First().Description.EndsWith(" The Enumeration constraint failed."));

            // should not report error in O14 validator.
            actual = O14Validator.Validate(element);
            Assert.Equal(0, actual.Count());

        }

        /// <summary>
        /// Test new Office2010 new added attributes validation.
        /// </summary>
        [Fact]
        public void AttributeValidationO14SupportTest()
        {
            var element = new Indentation();

            // ***** good case ******

            // the following attributes are valid in both Office2007 and Office2010.
            element.Left = "10";
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            actual = O14Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            element.Right = "20";
            actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            actual = O14Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // ***** error case ******

            // following are invalid for both Office2007 and Office2010
            element.SetAttribute(new OpenXmlAttribute("foo", "bar", "http://foo", "egg"));
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_UndeclaredAttribute", actual.First().Id);
            Assert.Equal("/w:ind[1]", actual.First().Path.XPath);

            actual = O14Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_UndeclaredAttribute", actual.First().Id);
            Assert.Equal("/w:ind[1]", actual.First().Path.XPath);
            element.RemoveAttribute("bar", "http://foo");
            
            // The w:start only valid in Office2010.
            element.Start = "10";
            // should report error in Office2007 validator.
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_UndeclaredAttribute", actual.First().Id);
            Assert.Equal("/w:ind[1]", actual.First().Path.XPath);
            Assert.Equal("The 'http://schemas.openxmlformats.org/wordprocessingml/2006/main:start' attribute is not declared.", actual.First().Description);

            // should NOT report error in Office2010 validator.
            actual = O14Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            // The w:start only valid in Office2010.
            // Also set the value to error.
            element.Start.InnerText = "Foo";
            // should report Sch_UndeclaredAttribute error in Office2007 validator.
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_UndeclaredAttribute", actual.First().Id);
            Assert.Equal("/w:ind[1]", actual.First().Path.XPath);
            Assert.Equal("The 'http://schemas.openxmlformats.org/wordprocessingml/2006/main:start' attribute is not declared.", actual.First().Description);

            // should report Sch_AttributeUnionFailedEx error in Office2010 validator.
            actual = O14Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeUnionFailedEx", actual.First().Id);
            Assert.Equal("/w:ind[1]", actual.First().Path.XPath);
        }
  
        /// <summary>
        /// Test changed value type for attribute in O14.
        /// </summary>
        [Fact]
        public void ChangedAttributeValueTypeValidationO14SupportTest()
        {
              //<xs:simpleType name="ST_DecimalNumberOrPercent">
              //  <xs:union memberTypes="ST_Percentage ST_DecimalNumber" />
              //</xs:simpleType>
              //<xs:simpleType name="ST_Percentage">
              //  <xs:annotation>
              //    <xs:documentation>Percentage</xs:documentation>
              //  </xs:annotation>
              //  <xs:restriction base="xsd:int" />
              //</xs:simpleType>
            
            var element = new Zoom();

            // ***** good case ******

            // the following attributes are valid in both Office2007 and Office2010.
            element.Percent = "10";
            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            actual = O14Validator.Validate(element);
            Assert.Equal(0, actual.Count());


            // ***** error case ******

            // following are invalid for both Office2007 and Office2010
            element.Percent = "foo";
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("/w:zoom[1]", actual.First().Path.XPath);

            actual = O14Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeUnionFailedEx", actual.First().Id);
            Assert.Equal("/w:zoom[1]", actual.First().Path.XPath);

            // A valid value for Office2010 but is invalid for Office2007.
            element.Percent = "10%";
            // should report error in Office2007 validator.
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_AttributeValueDataTypeDetailed", actual.First().Id);
            Assert.Equal("/w:zoom[1]", actual.First().Path.XPath);

            // should NOT report error in Office2010 validator.
            actual = O14Validator.Validate(element);
            Assert.Equal(0, actual.Count());

        }



        /// <summary>
        /// Test new Office2010 new added attributes / elements validation.
        /// </summary>
        [Fact]
        public void SchemaValidationO14SupportTest2()
        {
            var element = new TableLook();
            var tblPr = new DocumentFormat.OpenXml.Wordprocessing.TableProperties(element);

            // ***** good case ******

            // the following attributes are valid in both Office2007 and Office2010.
            element.Val = "FF00";
            var actual = O12Validator.Validate(tblPr);
            Assert.Equal(0, actual.Count());

            actual = O14Validator.Validate(tblPr);
            Assert.Equal(0, actual.Count());


            //// ***** error case ******

            //// following are invalid for both Office2007 and Office2010
            element.SetAttribute(new OpenXmlAttribute("foo", "bar", "http://foo", "egg"));
            actual = O12Validator.Validate(tblPr);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_UndeclaredAttribute", actual.First().Id);
            Assert.Equal("/w:tblPr[1]/w:tblLook[1]", actual.First().Path.XPath);

            actual = O14Validator.Validate(tblPr);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_UndeclaredAttribute", actual.First().Id);
            Assert.Equal("/w:tblPr[1]/w:tblLook[1]", actual.First().Path.XPath);
            element.RemoveAttribute("bar", "http://foo");

            // The w:firstRow only valid in Office2010.
            element.FirstRow = true;
            // should report error in Office2007 validator.
            actual = O12Validator.Validate(tblPr);
            Assert.Equal(1, actual.Count());
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_UndeclaredAttribute", actual.First().Id);
            Assert.Equal("/w:tblPr[1]/w:tblLook[1]", actual.First().Path.XPath);
            Assert.Equal("The 'http://schemas.openxmlformats.org/wordprocessingml/2006/main:firstRow' attribute is not declared.", actual.First().Description);

            // should NOT report error in Office2010 validator.
            actual = O14Validator.Validate(element);
            Assert.Equal(0, actual.Count());


            // ***** good case ******

            var compat = new Compatibility();

            compat.AdjustLineHeightInTable = new AdjustLineHeightInTable();
            actual = O12Validator.Validate(compat);
            Assert.Equal(0, actual.Count());

            actual = O14Validator.Validate(compat);
            Assert.Equal(0, actual.Count());

            //// ***** error case ******

            // The CompatibilitySetting only valid in Office2010.
            
            var o14element = compat.AppendChild(new CompatibilitySetting() { Name = CompatSettingNameValues.CompatibilityMode, Uri = "foo", Val = "12" });
            actual = O12Validator.Validate(compat);
            // should report error in O12
            // In M5, it is also avalilabe in O12, so disable this block
            Assert.Equal(0, actual.Count());
            //Assert.Same(compat, actual.First().Node);
            //Assert.Same(o14element, actual.First().RelatedNode);
            //Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            //Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", actual.First().Id);

            // should not report error in O14
            actual = O14Validator.Validate(compat);
            Assert.Equal(0, actual.Count());

            // append 
            var errorElement = compat.AppendChild(new CachedColumnBalance());

            actual = O12Validator.Validate(compat);
            // should report error in O12
            Assert.Equal(1, actual.Count());
            Assert.Same(compat, actual.First().Node);
            Assert.Same(errorElement, actual.First().RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", actual.First().Id);
            Assert.False(actual.First().Description.Contains(ValidationErrorStrings.Fmt_ListOfPossibleElements));

            // should report error in O14 because the last element is our of order.
            actual = O14Validator.Validate(compat);
            Assert.Equal(1, actual.Count());
            Assert.Same(compat, actual.First().Node);
            Assert.Same(errorElement, actual.First().RelatedNode);
            Assert.Equal(ValidationErrorType.Schema, actual.First().ErrorType);
            Assert.Equal("Sch_UnexpectedElementContentExpectingComplex", actual.First().Id);
            Assert.False(actual.First().Description.Contains(ValidationErrorStrings.Fmt_ListOfPossibleElements));
        }

        /// <summary>
        /// Test schema validation on elements with MC attributes.
        /// </summary>
        [Fact]
        public void SchemaValidationOnMcAttributeTest()
        {
            string xml = "<w:document xmlns:mc=\"http://schemas.openxmlformats.org/markup-compatibility/2006\" mc:Ignorable=\"w14\" " +
                        "xmlns:w14=\"http://schemas.microsoft.com/office/word/2007/5/30/wordml\" " +
                        "xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"><w:body><w:p w14:paraId=\"017B6C57\" w14:editId=\"32F17AD3\" w:rsidR=\"00A35C47\"  /></w:body></w:document>";

            var element = new Document(xml);

            var actual = O12Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            actual = O14Validator.Validate(element);
            Assert.Equal(0, actual.Count());
        }

        /// <summary>
        /// A test for the namespace .
        /// </summary>
        [Fact]
        public void NamespaceTest()
        {
            // the "w14" is a beta namespace in this xml fragment.
            string xml = "<w:document xmlns:w14=\"http://schemas.microsoft.com/office/word/2007/5/30/wordml\" " +
                "xmlns:mc=\"http://schemas.openxmlformats.org/markup-compatibility/2006\" " +
            "xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" mc:Ignorable=\"w14\"><w:body><w:p w:rsidR=\"00A35C47\" w14:paraId=\"017B6C57\" w14:editId=\"32F17AD3\" /></w:body></w:document>";

            var element = new Document(xml);
            var p = element.Body.FirstChild as DocumentFormat.OpenXml.Wordprocessing.Paragraph;
            Assert.Null(p.ParagraphId); // the w14:paraId in the xml has different namespace than expected.
            Assert.Equal(xml, element.OuterXml);

            // set a O14 paraId 
            p.ParagraphId = "0000FFFF";
            Assert.NotNull(p.ParagraphId);

            var actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());

            actual = O14Validator.Validate(element);
            Assert.Equal(0, actual.Count());

            string outerxml = element.OuterXml;
            Document newElement = new Document(outerxml);
            p = element.Body.FirstChild as DocumentFormat.OpenXml.Wordprocessing.Paragraph;
            Assert.Null(p.TextId);
            Assert.NotNull(p.ParagraphId);
            
            actual = O12Validator.Validate(element);
            Assert.Equal(1, actual.Count());

            actual = O14Validator.Validate(element);
            Assert.Equal(0, actual.Count());

        }

        #endregion

        /// <summary>
        ///A test for Validate(OpenXmlPackage) - validating a document opened with a different version.
        ///</summary>
        [Fact]
        public void VersionMismatchValidatingTest()
        {
            using (Stream stream = new MemoryStream(TestFileStreams.complex0docx, false))
            {
                // use OpenXmlPackage
                using (WordprocessingDocument wordTestDocument = WordprocessingDocument.Open(stream, false, new OpenSettings() { MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2010)}))

                {
                    IEnumerable<ValidationErrorInfo> actual;
                    // Office2010
                    actual = O14Validator.Validate(wordTestDocument);
                    Assert.Equal(1, actual.Count()); // The value 'actual' should contain one validtion error for 'doNotEmbedSmartTags' in the test document.

                    // the following line should throw exception.
                    Assert.Throws<System.InvalidOperationException>(() =>
                    {
                        actual = O12Validator.Validate(wordTestDocument);
                    });
                }
            }
        }

        /// <summary>
        ///A test for Validate(OpenXmlPackage) - validating a document opened with a different version.
        ///</summary>
        [Fact]
        public void VersionMismatchPartValidatingTest()
        {
            using (Stream stream = new MemoryStream(TestFileStreams.complex0docx, false))
            {
                // use OpenXmlPackage
                using (WordprocessingDocument wordTestDocument = WordprocessingDocument.Open(stream, false, new OpenSettings() { MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2007) }))
                {
                    IEnumerable<ValidationErrorInfo> actual;
                    actual = O12Validator.Validate(wordTestDocument.MainDocumentPart);
                    Assert.Equal(0, actual.Count());

                    // the following line should throw exception.
                    // Office2010
                    Assert.Throws<System.InvalidOperationException>(() =>
                    {
                        actual = O14Validator.Validate(wordTestDocument.MainDocumentPart);
                    });
                }
            }
        }
    }
}

