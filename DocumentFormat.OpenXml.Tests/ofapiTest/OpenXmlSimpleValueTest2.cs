// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using Vml = DocumentFormat.OpenXml.Vml;
using xvml = DocumentFormat.OpenXml.Vml.Spreadsheet;
using M = DocumentFormat.OpenXml.Math;
using System;

using Xunit;
namespace DocumentFormat.OpenXml.Tests
{
    /// <summary>
    ///This is a test class for BooleanValueTest and is intended
    ///to contain all BooleanValueTest Unit Tests
    ///</summary>
    
    public class OpenXmlSimpleValueTest2
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
        ///A test for BooleanValue Constructor
        ///</summary>
        [Fact]
        public void BooleanValueTest()
        {
            // xsd:boolean is enum in W3C XSD 1.1 Part 2: Datatypes  - 'true' | 'false' | '1' | '0'

            BooleanValue target = new BooleanValue();
            Assert.False(target.HasValue); // default has no value.

            target.InnerText = "1";
            Assert.True(target.HasValue);
            Assert.True(target.Value);
            Assert.True((bool)target);

            target.InnerText = "0";
            Assert.False(target.Value);
            Assert.True(target.HasValue);
            Assert.False((bool)target);

            target.InnerText = "true";
            Assert.True(target.Value);
            Assert.True(target.HasValue);

            target.InnerText = "false";
            Assert.True(target.HasValue);
            Assert.False(target.Value);

            target.Value = true;
            Assert.Equal("1", target.InnerText);

            target.Value = false;
            Assert.Equal("0", target.ToString());

            target = true;
            Assert.True(target.Value);
            Assert.Equal("1", target.InnerText);

            target = false;
            Assert.False(target.Value);
            Assert.Equal("0", target.ToString());
        }

        
        /// <summary>
        ///A test for EnumValue
        ///</summary>
        [Fact]
        public void EnumValueTest()
        {
            EnumValue<M.BooleanValues> onoffEnum = new EnumValue<M.BooleanValues>();
            Assert.False(onoffEnum.HasValue);
            Assert.Null(onoffEnum.InnerText);
            Assert.Null(onoffEnum.ToString());

            onoffEnum.InnerText = "error value";
            Assert.False(onoffEnum.HasValue);
            Assert.Equal("error value", onoffEnum.InnerText);
            Assert.Equal("error value", onoffEnum.ToString());

            onoffEnum.InnerText = string.Empty;
            Assert.False(onoffEnum.HasValue);
            Assert.Equal(string.Empty, onoffEnum.InnerText);
            Assert.Equal(string.Empty, onoffEnum.ToString());

            onoffEnum.InnerText = "on";
            Assert.True(onoffEnum.HasValue);
            Assert.Equal("on", onoffEnum.InnerText);
            Assert.Equal(M.BooleanValues.On, onoffEnum.Value);
            Assert.Equal(M.BooleanValues.On, (M.BooleanValues)onoffEnum);
            Assert.Equal("on", onoffEnum.ToString());

            var newEnum = new EnumValue<M.BooleanValues>(onoffEnum);
            Assert.True(newEnum.HasValue);

            newEnum.Value = M.BooleanValues.Off;
            Assert.True(newEnum.HasValue);
            Assert.Equal("off", newEnum.InnerText);
            Assert.Equal(M.BooleanValues.Off, newEnum.Value);
            Assert.Equal(M.BooleanValues.Off, (M.BooleanValues)newEnum);
            Assert.Equal("off", newEnum.ToString());

            // the onoffEnum should not be changed.
            Assert.True(onoffEnum.HasValue);
            Assert.Equal("on", onoffEnum.InnerText);
            Assert.Equal(M.BooleanValues.On, onoffEnum.Value);
            Assert.Equal(M.BooleanValues.On, (M.BooleanValues)onoffEnum);
            Assert.Equal("on", onoffEnum.ToString());

            // test sepcial case - the enum can be empty string ""
            var truefalseEmpty = new EnumValue<xvml.BooleanEntryWithBlankValues>(xvml.BooleanEntryWithBlankValues.Empty);
            Assert.True(truefalseEmpty.HasValue);
            Assert.Equal("", truefalseEmpty.InnerText);
            Assert.Equal(xvml.BooleanEntryWithBlankValues.Empty, truefalseEmpty.Value);
            Assert.Equal(xvml.BooleanEntryWithBlankValues.Empty, (xvml.BooleanEntryWithBlankValues)truefalseEmpty);
            Assert.Equal("", truefalseEmpty.ToString());

            truefalseEmpty = xvml.BooleanEntryWithBlankValues.T;
            Assert.True(truefalseEmpty.HasValue);
            Assert.Equal("t", truefalseEmpty.InnerText);
            Assert.Equal(xvml.BooleanEntryWithBlankValues.T, truefalseEmpty.Value);
            Assert.Equal(xvml.BooleanEntryWithBlankValues.T, (xvml.BooleanEntryWithBlankValues)truefalseEmpty);
            Assert.Equal("t", truefalseEmpty.ToString());

            truefalseEmpty.InnerText = string.Empty;
            Assert.True(truefalseEmpty.HasValue);
            Assert.Equal("", truefalseEmpty.InnerText);
            Assert.Equal(xvml.BooleanEntryWithBlankValues.Empty, truefalseEmpty.Value);
            Assert.Equal(xvml.BooleanEntryWithBlankValues.Empty, (xvml.BooleanEntryWithBlankValues)truefalseEmpty);
            Assert.Equal("", truefalseEmpty.ToString());

            // Clone constructor for EnumValue
            HeaderFooterValues validValue0 = HeaderFooterValues.Default;
            var objA = new EnumValue<HeaderFooterValues>(validValue0);
            var objB = new EnumValue<HeaderFooterValues>(objA);
            Assert.True(objA.HasValue);
            Assert.True(objB.HasValue);
            Assert.Equal("default", objA.InnerText);
            Assert.Equal("default", objB.InnerText);

            // Clone() for EnumValue.
            objA = new EnumValue<HeaderFooterValues>(validValue0);
            objB = (EnumValue<HeaderFooterValues>)(objA.Clone());
            Assert.True(objA.HasValue);
            Assert.True(objB.HasValue);
            Assert.Equal("default", objA.InnerText);
            Assert.Equal("default", objB.InnerText);
        }

         
        /// <summary>
        ///A test for StringValue
        ///</summary>
        [Fact]
        public void StringValueTest()
        {
            StringValue target = null;

            Assert.Null((string)target);

            target = new StringValue();
            Assert.False(target.HasValue);
            Assert.Null((string)target);
            Assert.Null(target.Value);
            Assert.Null(target.InnerText);

            target.InnerText = "";
            Assert.True(target.HasValue);
            Assert.Equal("", target.Value);
            Assert.Equal("", (string)target);
            Assert.Equal("", target.ToString());

            target = "test";
            Assert.True(target.HasValue);
            Assert.Equal("test", target.Value);
            Assert.Equal("test", target.InnerText);
            Assert.Equal("test", (string)target);
            Assert.Equal("test", target.ToString());

        }
    
                
        /// <summary>
        ///A test for DateTimeValue
        ///</summary>
        [Fact]
        public void DateTimeValueTest()
        {
            string utcTime = "2008-07-17T16:11:10.518Z";
            // System.Globalization.CultureInfo cultureInfo = System.Globalization.CultureInfo.GetCultureInfo("zh-CN");
            DateTime dateTime = System.Xml.XmlConvert.ToDateTime(utcTime, System.Xml.XmlDateTimeSerializationMode.Utc);
                                    
            DateTimeValue target = new DateTimeValue( dateTime );

            Assert.True(target.HasValue);
            Assert.Equal(utcTime, target.InnerText);

            target = new DateTimeValue();
            target.InnerText = utcTime;

            Assert.True(target.HasValue);
            Assert.Equal(dateTime, target.Value);


        }
    
        /// <summary>
        ///A test for DateTimeValue
        ///</summary>
        [Fact]
        public void DoubleValueTest()
        {
            DoubleValue target = new DoubleValue();
            target.InnerText = "NaN";

            Assert.True(target.HasValue);
            Assert.Equal(double.NaN, target.Value);
            Assert.Equal("NaN", target.InnerText);
            Assert.Equal("NaN", target.InnerText);

            target.InnerText = "INF";
            Assert.True(target.HasValue);
            Assert.Equal(double.PositiveInfinity, target.Value);
            Assert.Equal("INF", target.InnerText);
            Assert.Equal("INF", target.InnerText);

            target.InnerText = "-INF";
            Assert.True(target.HasValue);
            Assert.Equal(double.NegativeInfinity, target.Value);
            Assert.Equal("-INF", target.InnerText);
            Assert.Equal("-INF", target.InnerText);

            target.InnerText = "Infinity";
            Assert.True(target.HasValue);
            Assert.Equal(double.PositiveInfinity, target.Value);
            Assert.Equal("Infinity", target.InnerText);
            Assert.Equal("Infinity", target.InnerText);

            target.InnerText = "-Infinity";
            Assert.True(target.HasValue);
            Assert.Equal(double.NegativeInfinity, target.Value);
            Assert.Equal("-Infinity", target.InnerText);
            Assert.Equal("-Infinity", target.InnerText);
            
            target.InnerText = "765.43211234E11";
            Assert.True(target.HasValue);
            Assert.Equal((double)765.43211234E11, target.Value);

            target.InnerText = "7E7";
            Assert.True(target.HasValue);
            Assert.Equal((double)7E7, target.Value);
            Assert.Equal("7E7", target.InnerText);
            Assert.Equal("7E7", target.InnerText);

            target.InnerText = "1.0";
            Assert.True(target.HasValue);
            Assert.Equal((double)1.0, target.Value);
            Assert.Equal("1.0", target.InnerText);
            Assert.Equal("1.0", target.InnerText);

            target.Value = (double)1.0;
            Assert.True(target.HasValue);
            Assert.Equal(((double)1.0).ToString(), target.InnerText);

            target.Value = (double)7E7;
            Assert.True(target.HasValue);
            Assert.Equal(((double)7E7).ToString(), target.InnerText);

            target.Value = (double)765.43211234E11;
            Assert.True(target.HasValue);
            Assert.Equal(((double)765.43211234E11).ToString(), target.InnerText);

            target.Value = double.NaN;
            Assert.True(target.HasValue);
            Assert.Equal("NaN", target.InnerText);
            Assert.Equal("NaN", target.InnerText);

            target.Value = double.PositiveInfinity;
            Assert.True(target.HasValue);
            Assert.Equal("INF", target.InnerText);
            Assert.Equal("INF", target.InnerText);

            target.Value = double.NegativeInfinity;
            Assert.True(target.HasValue);
            Assert.Equal("-INF", target.InnerText);
            Assert.Equal("-INF", target.InnerText);

            target = new DoubleValue(Double.NaN);
            Assert.True(target.HasValue);
            Assert.Equal("NaN", target.InnerText);
            Assert.Equal("NaN", target.InnerText);

            target.InnerText = "0.0";
            Assert.Equal((double)0.0, target.Value);
            Assert.Equal("0.0", target.InnerText);

            target.InnerText = "-0.0";
            Assert.Equal((double)0.0, target.Value);
            Assert.Equal("-0.0", target.InnerText);
        }

        /// <summary>
        ///A test for DateTimeValue
        ///</summary>
        [Fact]
        public void SingleValueTest()
        {
            SingleValue target = new SingleValue();
            target.InnerText = "NaN";

            Assert.True(target.HasValue);
            Assert.Equal(float.NaN, target.Value);

            target.InnerText = "INF";
            Assert.True(target.HasValue);
            Assert.Equal(float.PositiveInfinity, target.Value);

            target.InnerText = "-INF";
            Assert.True(target.HasValue);
            Assert.Equal(float.NegativeInfinity, target.Value);

            target.InnerText = "765.43211234E11";
            Assert.True(target.HasValue);
            Assert.Equal((float)765.43211234E11, target.Value);

            target.InnerText = "7E7";
            Assert.True(target.HasValue);
            Assert.Equal((float)7E7, target.Value);

            target.InnerText = "1.0";
            Assert.True(target.HasValue);
            Assert.Equal((float)1.0, target.Value);

            target.Value = (float)1.0;
            Assert.True(target.HasValue);
            Assert.Equal(((float)1.0).ToString(), target.InnerText);

            target.Value = (float)7E7;
            Assert.True(target.HasValue);
            Assert.Equal(((float)7E7).ToString(), target.InnerText);

            target.Value = (float)765.43211234E11;
            Assert.True(target.HasValue);
            Assert.Equal(((float)765.43211234E11).ToString(), target.InnerText);

            target.Value = float.NaN;
            Assert.True(target.HasValue);
            Assert.Equal("NaN", target.InnerText);

            target.Value = float.PositiveInfinity;
            Assert.True(target.HasValue);
            Assert.Equal("INF", target.InnerText);

            target.Value = float.NegativeInfinity;
            Assert.True(target.HasValue);
            Assert.Equal("-INF", target.InnerText);
        }

        /// <summary>
        /// A test for TrueFalseValue
        /// </summary>
        [Fact]
        public void TrueFalseValueTest()
        {
            TrueFalseValue target = new TrueFalseValue();

            Assert.False(target.HasValue);

            target.InnerText = "true";
            Assert.True(target.HasValue);
            Assert.Equal(true, target.Value);
            Assert.True(true == target);

            target.InnerText = "false";
            Assert.True(target.HasValue);
            Assert.Equal(false, target.Value);
            Assert.True(false == target);

            target.InnerText = "t";
            Assert.True(target.HasValue);
            Assert.Equal(true, target.Value);
            Assert.True(true == target);

            target.InnerText = "f";
            Assert.True(target.HasValue);
            Assert.Equal(false, target.Value);
            Assert.True(false == target);

            target.InnerText = "invalid";
            Assert.False(target.HasValue);
            try
            {
                bool v = target.Value;
                Assert.True(false); // Assert.Fail("FormatException is not thrown.");
            }
            catch (FormatException)
            {
            }

            target.Value = true;
            Assert.Equal("true", target.InnerText);

            target.Value = false;
            Assert.Equal("false", target.InnerText);

            target = true;
            Assert.Equal("true", target.InnerText);

            target = false;
            Assert.Equal("false", target.InnerText);

            TrueFalseValue target2 = new TrueFalseValue(true);
            Assert.True(target2.HasValue);
            Assert.Equal(true, target2.Value);

            TrueFalseValue target3 = new TrueFalseValue(false);
            Assert.True(target3.HasValue);
            Assert.Equal(false, target3.Value);

            TrueFalseValue target4 = new TrueFalseValue(target2);
            Assert.True(target4.HasValue);
            Assert.Equal(true, target4.Value);

            TrueFalseValue target5 = new TrueFalseValue(target3);
            Assert.Equal(false, target5.Value);

            TrueFalseValue target6 = target5.Clone() as TrueFalseValue;
            Assert.True(false == target6);
        }

        /// <summary>
        /// A test for TrueFalseBlankValue
        /// </summary>
        [Fact]
        public void TrueFalseBlankValueTest()
        {
            TrueFalseBlankValue target = new TrueFalseBlankValue();

            Assert.False(target.HasValue);

            target.InnerText = "true";
            Assert.True(target.HasValue);
            Assert.Equal(true, target.Value);
            Assert.True(true == target);

            target.InnerText = "false";
            Assert.True(target.HasValue);
            Assert.Equal(false, target.Value);
            Assert.True(false == target);

            target.InnerText = "t";
            Assert.True(target.HasValue);
            Assert.Equal(true, target.Value);
            Assert.True(true == target);

            target.InnerText = "f";
            Assert.True(target.HasValue);
            Assert.Equal(false, target.Value);
            Assert.True(false == target);

            target.InnerText = string.Empty;
            Assert.True(target.HasValue);
            Assert.Equal(false, target.Value);
            Assert.True(false == target);

            target.InnerText = "invalid";
            Assert.False(target.HasValue);
            try
            {
                bool v = target.Value;
                Assert.True(false); // Assert.Fail("FormatException is not thrown.");
            }
            catch (FormatException)
            {
            }

            target.Value = true;
            Assert.Equal("true", target.InnerText);

            target.Value = false;
            Assert.Equal("false", target.InnerText);

            target = true;
            Assert.Equal("true", target.InnerText);

            target = false;
            Assert.Equal("false", target.InnerText);

            TrueFalseBlankValue target2 = new TrueFalseBlankValue(true);
            Assert.True(target2.HasValue);
            Assert.Equal(true, target2.Value);

            TrueFalseBlankValue target3 = new TrueFalseBlankValue(false);
            Assert.True(target3.HasValue);
            Assert.Equal(false, target3.Value);

            TrueFalseBlankValue target4 = new TrueFalseBlankValue(target2);
            Assert.True(target4.HasValue);
            Assert.Equal(true, target4.Value);

            TrueFalseBlankValue target5 = new TrueFalseBlankValue(target3);
            Assert.Equal(false, target5.Value);

        }

        /// <summary>
        /// A test for OnOffValue
        /// </summary>
        [Fact]
        public void OnOffValueTest()
        {
            OnOffValue target = new OnOffValue();

            Assert.False(target.HasValue);

            target.InnerText = "true";
            Assert.True(target.HasValue);
            Assert.Equal(true, target.Value);
            Assert.True(true == target);

            target.InnerText = "false";
            Assert.True(target.HasValue);
            Assert.Equal(false, target.Value);
            Assert.True(false == target);

            target.InnerText = "on";
            Assert.True(target.HasValue);
            Assert.Equal(true, target.Value);
            Assert.True(true == target);

            target.InnerText = "off";
            Assert.True(target.HasValue);
            Assert.Equal(false, target.Value);
            Assert.True(false == target);

            target.InnerText = "1";
            Assert.True(target.HasValue);
            Assert.Equal(true, target.Value);
            Assert.True(true == target);

            target.InnerText = "0";
            Assert.True(target.HasValue);
            Assert.Equal(false, target.Value);
            Assert.True(false == target);

            target.InnerText = "invalid";
            Assert.False(target.HasValue);
            try
            {
                bool v = target.Value;
                Assert.True(false); // Assert.Fail("FormatException is not thrown.");
            }
            catch (FormatException)
            {
            }

            target.Value = true;
            Assert.Equal("true", target.InnerText);

            target.Value = false;
            Assert.Equal("false", target.InnerText);

            target = true;
            Assert.Equal("true", target.InnerText);

            target = false;
            Assert.Equal("false", target.InnerText);

            OnOffValue target2 = new OnOffValue(true);
            Assert.True(target2.HasValue);
            Assert.Equal(true, target2.Value);

            OnOffValue target3 = new OnOffValue(false);
            Assert.True(target3.HasValue);
            Assert.Equal(false, target3.Value);

            OnOffValue target4 = new OnOffValue(target2);
            Assert.True(target4.HasValue);
            Assert.Equal(true, target4.Value);

            OnOffValue target5 = new OnOffValue(target3);
            Assert.Equal(false, target5.Value);

        }

        /// <summary>
        /// A test to check if CodeGen applys TrueFalseValue, TrueFalseBlankValue, and OnOffValue correctly.
        /// </summary>
        [Fact]
        public void OnOffValueApplicationTest()
        {
            Bold b = new Bold();
            b.Val = true;
            Assert.True(b.Val);
            b.Val.InnerText = "off";
            Assert.False(b.Val);

            DocumentFormat.OpenXml.Vml.Office.ShapeDefaults sd =
                new DocumentFormat.OpenXml.Vml.Office.ShapeDefaults();
            sd.BeFilled = true;
            Assert.True(sd.BeFilled);
            sd.BeFilled.InnerText = "f";
            Assert.False(sd.BeFilled);

            DocumentFormat.OpenXml.Vml.ShapeHandle h = new DocumentFormat.OpenXml.Vml.ShapeHandle();
            h.Switch = true;
            Assert.True(h.Switch);
            h.Switch.InnerText = string.Empty;
            Assert.False(h.Switch);

            DocumentFormat.OpenXml.Vml.Office.Proxy p = new DocumentFormat.OpenXml.Vml.Office.Proxy();
            p.Start = true;
            Assert.True(p.Start);
            p.Start.InnerText = "false";
            Assert.False(p.Start);
            //DocumentFormat.OpenXml.Vml.Spreadsheet.Locked locked = new DocumentFormat.OpenXml.Vml.Spreadsheet.Locked("t");
            //Assert.Equal(typeof(EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>), locked.InnerTextToValue(locked.InnerText));
        }

        /// <summary>
        /// A test for implicit(explicit) operators of those OpenXmlSimpleType classes.
        /// </summary>
        [Fact]
        public void OpenXmlSimpleTypeConverterTest()
        {
            // 1. Base64BinaryValue
            Base64BinaryValue base64 = new Base64BinaryValue();
            base64 = "AA3322";
            Assert.True("AA3322" == base64);
            Assert.Equal("AA3322", base64.Value);
            base64 = Base64BinaryValue.FromString("1234");
            Assert.Equal("1234", base64.ToString());
            Assert.Equal("1234", Base64BinaryValue.ToString(base64));

            // 2. BooleanValue
            BooleanValue booleanValue = new BooleanValue();
            booleanValue = true;
            Assert.True(booleanValue);
            Assert.True(booleanValue.Value);
            booleanValue = BooleanValue.FromBoolean(false);
            Assert.False(booleanValue);
            Assert.Equal(false, BooleanValue.ToBoolean(booleanValue));

            // 3. ByteValue
            ByteValue byteValue = new ByteValue();
            Byte bt = 1;
            byteValue = bt;
            Assert.True(bt == byteValue);
            Assert.Equal(bt, byteValue.Value);
            bt = 2;
            byteValue = ByteValue.FromByte(bt);
            Assert.Equal(bt, ByteValue.ToByte(byteValue));

            // 4. DateTimeValue
            DateTimeValue dtValue = new DateTimeValue();
            DateTime dt = DateTime.Now;
            dtValue = dt;
            Assert.True(dt == dtValue);
            dt = DateTime.Now.AddDays(1);
            dtValue = DateTimeValue.FromDateTime(dt);
            Assert.Equal(dt, dtValue.Value);
            Assert.Equal(dt, DateTimeValue.ToDateTime(dt));

            // 5. DecimalValue
            DecimalValue decimalValue = new DecimalValue();
            decimal dcm = 10;
            decimalValue = dcm;
            Assert.True(dcm == decimalValue);
            decimalValue = DecimalValue.FromDecimal(20);
            Assert.Equal(20, decimalValue.Value);
            Assert.Equal(20, DecimalValue.ToDecimal(decimalValue));

            // 6. DoubleValue
            DoubleValue doubleValue = new DoubleValue();
            double dbl = 1.1;
            doubleValue = dbl;
            Assert.True(dbl == doubleValue);
            doubleValue = DoubleValue.FromDouble(2.2);
            Assert.Equal(2.2, doubleValue.Value);
            Assert.Equal(2.2, DoubleValue.ToDouble(doubleValue));

            // 7. HexBinaryValue
            HexBinaryValue hexBinaryValue = new HexBinaryValue();
            string hex = "0X99CCFF";
            hexBinaryValue = hex;
            Assert.True(hex == hexBinaryValue);
            hex = "111111";
            hexBinaryValue = HexBinaryValue.FromString(hex);
            Assert.Equal(hex, hexBinaryValue.Value);
            Assert.Equal(hex, HexBinaryValue.ToString(hexBinaryValue));

            // 8. Int16
            Int16Value int16Value = new Int16Value();
            Int16 int16 = 16;
            int16Value = int16;
            Assert.True(int16 == int16Value);
            int16 = 17;
            int16Value = Int16Value.FromInt16(int16);
            Assert.Equal(int16, int16Value.Value);
            Assert.Equal(int16, Int16Value.ToInt16(int16Value));

            // 9. Int32
            Int32Value int32Value = new Int32Value();
            Int32 int32 = 32;
            int32Value = int32;
            Assert.True(int32 == int32Value);
            int32 = 33;
            int32Value = Int32Value.FromInt32(int32);
            Assert.Equal(int32, int32Value.Value);
            Assert.Equal(int32, Int32Value.ToInt32(int32Value));

            // 10. Int64
            Int64Value int64Value = new Int64Value();
            Int64 int64 = 64;
            int64Value = int64;
            Assert.True(int64 == int64Value);
            int64 = 17;
            int64Value = Int64Value.FromInt64(int64);
            Assert.Equal(int64, int64Value.Value);
            Assert.Equal(int64, Int64Value.ToInt64(int64Value));

            // 11. IntegerValue
            IntegerValue integerValue = new IntegerValue();
            int integer = 64;
            integerValue = integer;
            Assert.True(integer == integerValue);
            integer = 17;
            integerValue = IntegerValue.FromInt64(integer);
            Assert.Equal(integer, integerValue.Value);
            Assert.Equal(integer, IntegerValue.ToInt64(integerValue));

            // 12. OnOffValue
            OnOffValue onOffValue = new OnOffValue();
            onOffValue = true;
            Assert.True(onOffValue);
            onOffValue = OnOffValue.FromBoolean(false);
            Assert.Equal(false, onOffValue.Value);
            Assert.Equal(false, OnOffValue.ToBoolean(onOffValue));

            // 13. SByteValue
            SByteValue sbyteValue = new SByteValue();
            SByte sbt = SByte.MaxValue;
            sbyteValue = sbt;
            Assert.True(sbt == sbyteValue);
            sbt = SByte.MinValue;
            sbyteValue = SByteValue.FromSByte(sbt);
            Assert.Equal(sbt, sbyteValue.Value);
            Assert.Equal(sbt, SByteValue.ToSByte(sbt));

            // 14. SingleValue
            SingleValue singleValue = new SingleValue();
            Single single = Single.MaxValue;
            singleValue = single;
            Assert.True(single == singleValue);
            single = Single.NaN;
            singleValue = SingleValue.FromSingle(single);
            Assert.Equal(single, singleValue.Value);
            Assert.Equal(single, SingleValue.ToSingle(singleValue));

            // 15. StringValue
            StringValue stringValue = new StringValue();
            String str = "Ethan";
            stringValue = str;
            Assert.True(str == stringValue);
            str = "Yin";
            stringValue = StringValue.FromString(str);
            Assert.Equal(str, stringValue.Value);
            Assert.Equal(str, stringValue.ToString());
            Assert.Equal(str, StringValue.ToString(stringValue));

            // 16. TrueFalseBlankValue
            TrueFalseBlankValue tfbValue = new TrueFalseBlankValue();
            tfbValue = true;
            Assert.True(tfbValue);
            tfbValue = TrueFalseBlankValue.FromBoolean(false);
            Assert.Equal(false, tfbValue.Value);
            Assert.Equal(false, TrueFalseBlankValue.ToBoolean(tfbValue));

            // 17. TrueFalseValue
            TrueFalseValue tfValue = new TrueFalseValue();
            tfValue = true;
            Assert.True(tfValue);
            tfValue = TrueFalseValue.FromBoolean(false);
            Assert.Equal(false, tfValue.Value);
            Assert.Equal(false, TrueFalseValue.ToBoolean(tfValue));

            // 18. UInt16Value
            UInt16Value uint16Value = new UInt16Value();
            UInt16 uint16 = UInt16.MaxValue;
            uint16Value = uint16;
            Assert.True(uint16 == uint16Value);
            uint16 = UInt16.MinValue;
            uint16Value = UInt16Value.FromUInt16(uint16);
            Assert.Equal(uint16, uint16Value.Value);
            Assert.Equal(uint16, UInt16Value.ToUInt16(uint16Value));

            // 19. UInt32Value
            UInt32Value uint32Value = new UInt32Value();
            UInt32 uint32 = UInt32.MaxValue;
            uint32Value = uint32;
            Assert.True(uint32 == uint32Value);
            uint32 = UInt32.MinValue;
            uint32Value = UInt32Value.FromUInt32(uint32);
            Assert.Equal(uint32, uint32Value.Value);
            Assert.Equal(uint32, UInt32Value.ToUInt32(uint32Value));

            // 20. UInt64Value
            UInt64Value uint64Value = new UInt64Value();
            UInt64 uint64 = UInt64.MaxValue;
            uint64Value = uint64;
            Assert.True(uint64 == uint64Value);
            uint64 = UInt64.MinValue;
            uint64Value = UInt64Value.FromUInt64(uint64);
            Assert.Equal(uint64, uint64Value.Value);
            Assert.Equal(uint64, UInt64Value.ToUInt64(uint64Value));
        }
    
    
        /// <summary>
        /// A test for signed numbers (ex. "+23") for int, uint, etc.
        /// </summary>
        [Fact]
        public void Bug520719()
        {
            // the following test should pass without Assert() in debug version.
            
            var int8 = new SByteValue();
            int8.InnerText = "+10";
            Assert.Equal(10, int8.Value);
            Assert.Equal("+10", int8.InnerText);

            var int16 = new Int16Value();
            int16.InnerText = "+10";
            Assert.Equal(10, int16.Value);
            Assert.Equal("+10", int16.InnerText);

            var int32 = new Int32Value();
            int32.InnerText = "+10";
            Assert.Equal(10, int32.Value);
            Assert.Equal("+10", int32.InnerText);

            var int64 = new Int64Value();
            int64.InnerText = "+10";
            Assert.Equal(10, int64.Value);
            Assert.Equal("+10", int64.InnerText);

            var integer = new IntegerValue();
            integer.InnerText = "+10";
            Assert.Equal(10, integer.Value);
            Assert.Equal("+10", integer.InnerText);

            var dec = new DecimalValue();
            dec.InnerText = "+10";
            Assert.Equal(10, dec.Value);
            Assert.Equal("+10", dec.InnerText);

            var single = new SingleValue();
            single.InnerText = "+10";
            Assert.Equal(10, single.Value);
            Assert.Equal("+10", single.InnerText);

            var dble = new DoubleValue();
            dble.InnerText = "+10";
            Assert.Equal(10, dble.Value);
            Assert.Equal("+10", dble.InnerText);
        }
    }
}
