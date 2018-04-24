// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Globalization;
using Xunit;
using Xunit.Abstractions;

namespace DocumentFormat.OpenXml.Tests
{
    //   DocumentFormat.OpenXml.OpenXmlSimpleValue<T>
    //       DocumentFormat.OpenXml.BooleanValue
    //       DocumentFormat.OpenXml.ByteValue
    //       DocumentFormat.OpenXml.DateTimeValue
    //       DocumentFormat.OpenXml.DecimalValue
    //       DocumentFormat.OpenXml.DoubleValue
    //       DocumentFormat.OpenXml.Int16Value
    //       DocumentFormat.OpenXml.Int32Value
    //       DocumentFormat.OpenXml.Int64Value
    //       DocumentFormat.OpenXml.IntegerValue
    //       DocumentFormat.OpenXml.SByteValue
    //       DocumentFormat.OpenXml.SingleValue
    //       DocumentFormat.OpenXml.UInt16Value
    //       DocumentFormat.OpenXml.UInt32Value
    //       DocumentFormat.OpenXml.UInt64Value
    public class OpenXmlSimpleValueTest : OpenXmlDomTestBase
    {
        public OpenXmlSimpleValueTest(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        public void BooleanValueTest()
        {
            bool defaultValue = default(bool);
            bool maxValue = true;
            bool minValue = false;
            bool validValue = true;
            string specialValue0 = "0";
            string specialValue1 = "1";
            string invalidValueOn = "On";
            string invalidValueOff = "off";
            string invalidValueTrue = "True";
            string invalidValueFalse = "False";
            string specialValuetrue = "true";
            string specialValuefalse = "false";
            string invalidValue2 = "Invalid 0.1 String!";
            string invalidValue3 = "Invalid 1.0 String!";
            string invalidValue = "Invalid String!";

            Log.Comment("Testing default value...");
            string expectedText = defaultValue.ToString();
            BooleanValue defaultObj = default(BooleanValue);
            Log.VerifyNull(defaultObj, "default(BooleanValue) returns reference other than NULL");

            Log.Comment("Constructing with Max value and testing...");
            simpleValueValidTest(new BooleanValue(maxValue), maxValue, maxValue == true ? "1" : "0");

            Log.Comment("Constructing with Max value and testing with Clone()...");
            simpleValueValidTest(new BooleanValue(maxValue).Clone() as BooleanValue, maxValue, maxValue == true ? "1" : "0");

            Log.Comment("Set Value with Min value and testing...");
            BooleanValue objA = new BooleanValue();
            objA.Value = minValue;
            simpleValueValidTest(objA, minValue, minValue == true ? "1" : "0");

            Log.Comment("Set InnerText with Min value and testing...");
            BooleanValue objB = new BooleanValue();
            objB.InnerText = minValue.ToString().ToLower(); // True -> true, False -> false
            simpleValueValidTest(objB, minValue, minValue.ToString().ToLower());

            Log.Comment("Implicit Int Operator with Min value and testing...");
            objB = minValue;
            simpleValueValidTest(objB, minValue, minValue == true ? "1" : "0");

            Log.Comment("Explicit bool conversion with value {0} and testing", validValue);
            objB = BooleanValue.FromBoolean(validValue);
            Log.VerifyTrue(BooleanValue.ToBoolean(objB) == validValue, "FromXX() value doesn't equal to ToXX() value!");

            Log.Comment("Constructing with another instance with valid value...");
            objA = new BooleanValue(validValue);
            simpleValueValidTest(new BooleanValue(objA), validValue, validValue == true ? "1" : "0");

            Log.Comment("Verifying equality...");
            objA = new BooleanValue(validValue);
            objB = new BooleanValue(validValue);
            Assert.True(objA.Equals(objB));

            objA = new BooleanValue(validValue);
            objB = objA;
            Log.VerifyTrue(object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Log.VerifyTrue(object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Log.Comment("Setting InnerText as special value and testing...");
            objA = new BooleanValue();
            objA.InnerText = specialValue0;
            simpleValueValidTest(objA, false, specialValue0);
            objA.InnerText = specialValue1;
            simpleValueValidTest(objA, true, specialValue1);
            objA.InnerText = specialValuefalse;
            simpleValueValidTest(objA, false, specialValuefalse);
            objA.InnerText = specialValuetrue;
            simpleValueValidTest(objA, true, specialValuetrue);

            Log.Comment("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new BooleanValue(a); });

            Log.Comment("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            bool val = defaultValue;
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidValueFalse);
            objA = new BooleanValue();
            objA.InnerText = invalidValueFalse;
            InvalidOperation(objA, invalidValueFalse, (a, b) => actionOfCompare(a, b));

            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidValueTrue);
            objA = new BooleanValue();
            objA.InnerText = invalidValueTrue;
            InvalidOperation(objA, invalidValueTrue, (a, b) => actionOfCompare(a, b));

            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidValueOff);
            objA = new BooleanValue();
            objA.InnerText = invalidValueOff;
            InvalidOperation(objA, invalidValueOff, (a, b) => actionOfCompare(a, b));

            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidValueOn);
            objA = new BooleanValue();
            objA.InnerText = invalidValueOn;
            InvalidOperation(objA, invalidValueOn, (a, b) => actionOfCompare(a, b));

            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidValue);
            objA = new BooleanValue();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => actionOfCompare(a, b));

            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidValue2);
            objA = new BooleanValue();
            objA.InnerText = invalidValue2;
            InvalidOperation(objA, invalidValue2, (a, b) => actionOfCompare(a, b));

            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidValue3);
            objA = new BooleanValue();
            objA.InnerText = invalidValue3;
            InvalidOperation(objA, invalidValue3, (a, b) => actionOfCompare(a, b));
        }

        [Fact]
        public void ByteValueTest()
        {
            byte defaultValue = default(byte);
            byte maxValue = byte.MaxValue;
            byte minValue = byte.MinValue;
            byte validValue = 50;
            string invalidValue = "Invalid String!";

            Log.Comment("Testing default value...");
            string expectedText = defaultValue.ToString();
            ByteValue defaultObj = default(ByteValue);
            Log.VerifyNull(defaultObj, "default(Int32Value) returns reference other than NULL");

            Log.Comment("Constructing with Max value and testing...");
            simpleValueValidTest(new ByteValue(maxValue), maxValue, maxValue.ToString());

            Log.Comment("Constructing with Max value and testing with Clone()...");
            simpleValueValidTest(new ByteValue(maxValue).Clone() as ByteValue, maxValue, maxValue.ToString());

            Log.Comment("Set Value with Min value and testing...");
            ByteValue objA = new ByteValue();
            objA.Value = minValue;
            simpleValueValidTest(objA, minValue, minValue.ToString());

            Log.Comment("Set InnerText with Min value and testing...");
            ByteValue objB = new ByteValue();
            objB.InnerText = minValue.ToString();
            simpleValueValidTest(objB, minValue, minValue.ToString());

            Log.Comment("Implicit Int Operator with Min value and testing...");
            objB = minValue;
            simpleValueValidTest(objB, minValue, minValue.ToString());

            Log.Comment("Explicit byte conversion with value {0} and testing", validValue);
            objB = ByteValue.FromByte(validValue);
            Log.VerifyTrue(ByteValue.ToByte(objB) == validValue, "FromByte() value doesn't equal to ToByte() value!");

            Log.Comment("Constructing with another instance with valid value...");
            objA = new ByteValue(validValue);
            simpleValueValidTest(new ByteValue(objA), validValue, validValue.ToString());

            Log.Comment("Verifying equality...");
            objA = new ByteValue(validValue);
            objB = new ByteValue(validValue);
            Assert.True(objA.Equals(objB));

            objA = new ByteValue(validValue);
            objB = objA;
            Log.VerifyTrue(object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Log.VerifyTrue(object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Log.Comment("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new ByteValue(a); });

            Log.Comment("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            byte val = default(byte);
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Log.Comment("ErrorHandling: Set InnerText with invalid value...");
            objA = new ByteValue();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => actionOfCompare(a, b));
        }

        [Fact]
        public void SByteValueTest()
        {
            sbyte defaultValue = default(sbyte);
            sbyte maxValue = sbyte.MaxValue;
            sbyte minValue = sbyte.MinValue;
            sbyte validValue = 50;
            string invalidValue = "Invalid String!";

            Log.Comment("Testing default value...");
            string expectedText = defaultValue.ToString();
            SByteValue defaultObj = default(SByteValue);
            Log.VerifyNull(defaultObj, "default(SByteValue) returns reference other than NULL");

            Log.Comment("Constructing with Max value and testing...");
            simpleValueValidTest(new SByteValue(maxValue), maxValue, maxValue.ToString());

            Log.Comment("Constructing with Max value and testing with Clone()...");
            simpleValueValidTest(new SByteValue(maxValue).Clone() as SByteValue, maxValue, maxValue.ToString());

            Log.Comment("Set Value with Min value and testing...");
            SByteValue objA = new SByteValue();
            objA.Value = minValue;
            simpleValueValidTest(objA, minValue, minValue.ToString());

            Log.Comment("Set InnerText with Min value and testing...");
            SByteValue objB = new SByteValue();
            objB.InnerText = minValue.ToString();
            simpleValueValidTest(objB, minValue, minValue.ToString());

            Log.Comment("Implicit Int Operator with Min value and testing...");
            objB = minValue;
            simpleValueValidTest(objB, minValue, minValue.ToString());

            Log.Comment("Explicit SByteValue conversion with value {0} and testing", validValue);
            objB = SByteValue.FromSByte(validValue);
            Log.VerifyTrue(SByteValue.ToSByte(objB) == validValue, "FromSByte() value doesn't equal to ToSByte() value!");

            Log.Comment("Constructing with another instance with valid value...");
            objA = new SByteValue(validValue);
            simpleValueValidTest(new SByteValue(objA), validValue, validValue.ToString());

            Log.Comment("Verifying equality...");
            objA = new SByteValue(validValue);
            objB = new SByteValue(validValue);
            Assert.True(objA.Equals(objB));

            objA = new SByteValue(validValue);
            objB = objA;
            Log.VerifyTrue(object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Log.VerifyTrue(object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Log.Comment("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new SByteValue(a); });

            Log.Comment("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            sbyte val = default(sbyte);
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Log.Comment("ErrorHandling: Set InnerText with invalid value...");
            objA = new SByteValue();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => actionOfCompare(a, b));
        }

        [Fact]
        public void UInt16ValueTest()
        {
            ushort defaultValue = default(ushort);
            ushort maxValue = ushort.MaxValue;
            ushort minValue = ushort.MinValue;
            ushort validValue = 123;
            string invalidValue = "Invalid String!";

            Log.Comment("Testing default value...");
            string expectedText = defaultValue.ToString();
            UInt16Value defaultObj = default(UInt16Value);
            Log.VerifyNull(defaultObj, "default(UInt16Value) returns reference other than NULL");

            Log.Comment("Constructing with Max value and testing...");
            simpleValueValidTest(new UInt16Value(maxValue), maxValue, maxValue.ToString());

            Log.Comment("Constructing with Max value and testing with Clone()...");
            simpleValueValidTest(new UInt16Value(maxValue).Clone() as UInt16Value, maxValue, maxValue.ToString());

            Log.Comment("Set Value with Min value and testing...");
            UInt16Value objA = new UInt16Value();
            objA.Value = minValue;
            simpleValueValidTest(objA, minValue, minValue.ToString());

            Log.Comment("Set InnerText with Min value and testing...");
            UInt16Value objB = new UInt16Value();
            objB.InnerText = minValue.ToString();
            simpleValueValidTest(objB, minValue, minValue.ToString());

            Log.Comment("Implicit Int Operator with Min value and testing...");
            objB = minValue;
            simpleValueValidTest(objB, minValue, minValue.ToString());

            Log.Comment("Explicit conversion with value {0} and testing", validValue);
            objB = UInt16Value.FromUInt16(validValue);
            Log.VerifyTrue(UInt16Value.ToUInt16(objB) == validValue, "FromUInt16() value doesn't equal to ToUInt16() value!");

            Log.Comment("Constructing with another instance with valid value...");
            objA = new UInt16Value(validValue);
            simpleValueValidTest(new UInt16Value(objA), validValue, validValue.ToString());

            Log.Comment("Verifying equality...");
            objA = new UInt16Value(validValue);
            objB = new UInt16Value(validValue);
            Assert.True(objA.Equals(objB));

            objA = new UInt16Value(validValue);
            objB = objA;
            Log.VerifyTrue(object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Log.VerifyTrue(object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Log.Comment("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new UInt16Value(a); });

            Log.Comment("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            ushort val = default(ushort);
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Log.Comment("ErrorHandling: Set InnerText with invalid value...");
            objA = new UInt16Value();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => actionOfCompare(a, b));
        }

        [Fact]
        public void UInt32ValueTest()
        {
            uint defaultValue = default(uint);
            uint maxValue = uint.MaxValue;
            uint minValue = uint.MinValue;
            uint validValue = 123456;
            string invalidValue = "Invalid String!";

            Log.Comment("Testing default value...");
            string expectedText = defaultValue.ToString();
            UInt32Value defaultObj = default(UInt32Value);
            Log.VerifyNull(defaultObj, "default(UInt32Value) returns reference other than NULL");

            Log.Comment("Constructing with Max value and testing...");
            simpleValueValidTest(new UInt32Value(maxValue), maxValue, maxValue.ToString());

            Log.Comment("Constructing with Max value and testing with Clone()...");
            simpleValueValidTest(new UInt32Value(maxValue).Clone() as UInt32Value, maxValue, maxValue.ToString());

            Log.Comment("Set Value with Min value and testing...");
            UInt32Value objA = new UInt32Value();
            objA.Value = minValue;
            simpleValueValidTest(objA, minValue, minValue.ToString());

            Log.Comment("Set InnerText with Min value and testing...");
            UInt32Value objB = new UInt32Value();
            objB.InnerText = minValue.ToString();
            simpleValueValidTest(objB, minValue, minValue.ToString());

            Log.Comment("Implicit Int Operator with Min value and testing...");
            objB = minValue;
            simpleValueValidTest(objB, minValue, minValue.ToString());

            Log.Comment("Explicit conversion with value {0} and testing", validValue);
            objB = UInt32Value.FromUInt32(validValue);
            Log.VerifyTrue(UInt32Value.ToUInt32(objB) == validValue, "FromUInt32() value doesn't equal to ToUInt32() value!");

            Log.Comment("Constructing with another instance with valid value...");
            objA = new UInt32Value(validValue);
            simpleValueValidTest(new UInt32Value(objA), validValue, validValue.ToString());

            Log.Comment("Verifying equality...");
            objA = new UInt32Value(validValue);
            objB = new UInt32Value(validValue);
            Assert.True(objA.Equals(objB));

            objA = new UInt32Value(validValue);
            objB = objA;
            Log.VerifyTrue(object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Log.VerifyTrue(object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Log.Comment("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new UInt32Value(a); });

            Log.Comment("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            uint val = default(uint);
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Log.Comment("ErrorHandling: Set InnerText with invalid value...");
            objA = new UInt32Value();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => actionOfCompare(a, b));
        }

        [Fact]
        public void Int32ValueTest()
        {
            int defaultValue = default(int);
            int maxValue = int.MaxValue;
            int minValue = int.MinValue;
            int validValue = 123456;
            string invalidValue = "Invalid String!";

            Log.Comment("Testing default value...");
            string expectedText = defaultValue.ToString();
            Int32Value defaultObj = default(Int32Value);
            Log.VerifyNull(defaultObj, "default(Int32Value) returns reference other than NULL");

            Log.Comment("Constructing with Max value and testing...");
            simpleValueValidTest(new Int32Value(maxValue), maxValue, maxValue.ToString());

            Log.Comment("Constructing with Max value and testing with Clone()...");
            simpleValueValidTest(new Int32Value(maxValue).Clone() as Int32Value, maxValue, maxValue.ToString());

            Log.Comment("Set Value with Min value and testing...");
            Int32Value objA = new Int32Value();
            objA.Value = minValue;
            simpleValueValidTest(objA, minValue, minValue.ToString());

            Log.Comment("Set InnerText with Min value and testing...");
            Int32Value objB = new Int32Value();
            objB.InnerText = minValue.ToString();
            simpleValueValidTest(objB, minValue, minValue.ToString());

            Log.Comment("Implicit Int Operator with Min value and testing...");
            objB = minValue;
            simpleValueValidTest(objB, minValue, minValue.ToString());

            Log.Comment("Explicit conversion with value {0} and testing", validValue);
            objB = Int32Value.FromInt32(validValue);
            Log.VerifyTrue(Int32Value.ToInt32(objB) == validValue, "FromInt32() value doesn't equal to ToInt32() value!");

            Log.Comment("Constructing with another instance with valid value...");
            objA = new Int32Value(validValue);
            simpleValueValidTest(new Int32Value(objA), validValue, validValue.ToString());

            Log.Comment("Verifying equality...");
            objA = new Int32Value(validValue);
            objB = new Int32Value(validValue);
            Assert.True(objA.Equals(objB));

            objA = new Int32Value(validValue);
            objB = objA;
            Log.VerifyTrue(object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Log.VerifyTrue(object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Log.Comment("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new Int32Value(a); });

            Log.Comment("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            int val = default(int);
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Log.Comment("ErrorHandling: Set InnerText with invalid value...");
            objA = new Int32Value();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => actionOfCompare(a, b));
        }

        [Fact]
        public void UInt64ValueTest()
        {
            ulong defaultValue = default(ulong);
            ulong maxValue = ulong.MaxValue;
            ulong minValue = ulong.MinValue;
            ulong validValue = 123456;
            string invalidValue = "Invalid String!";

            Log.Comment("Testing default value...");
            string expectedText = defaultValue.ToString();
            UInt64Value defaultObj = default(UInt64Value);
            Log.VerifyNull(defaultObj, "default(UInt64Value) returns reference other than NULL");

            Log.Comment("Constructing with Max value and testing...");
            simpleValueValidTest(new UInt64Value(maxValue), maxValue, maxValue.ToString());

            Log.Comment("Constructing with Max value and testing with Clone()...");
            simpleValueValidTest(new UInt64Value(maxValue).Clone() as UInt64Value, maxValue, maxValue.ToString());

            Log.Comment("Set Value with Min value and testing...");
            UInt64Value objA = new UInt64Value();
            objA.Value = minValue;
            simpleValueValidTest(objA, minValue, minValue.ToString());

            Log.Comment("Set InnerText with Min value and testing...");
            UInt64Value objB = new UInt64Value();
            objB.InnerText = minValue.ToString();
            simpleValueValidTest(objB, minValue, minValue.ToString());

            Log.Comment("Implicit Int Operator with Min value and testing...");
            objB = minValue;
            simpleValueValidTest(objB, minValue, minValue.ToString());

            Log.Comment("Explicit UInt64Value conversion with value {0} and testing", validValue);
            objB = UInt64Value.FromUInt64(validValue);
            Log.VerifyTrue(UInt64Value.ToUInt64(objB) == validValue, "FromUInt64() value doesn't equal to ToUInt64() value!");

            Log.Comment("Constructing with another instance with valid value...");
            objA = new UInt64Value(validValue);
            simpleValueValidTest(new UInt64Value(objA), validValue, validValue.ToString());

            Log.Comment("Verifying equality...");
            objA = new UInt64Value(validValue);
            objB = new UInt64Value(validValue);
            Assert.True(objA.Equals(objB));

            objA = new UInt64Value(validValue);
            objB = objA;
            Log.VerifyTrue(object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Log.VerifyTrue(object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Log.Comment("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new UInt64Value(a); });

            Log.Comment("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            ulong val = default(ulong);
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Log.Comment("ErrorHandling: Set InnerText with invalid value...");
            objA = new UInt64Value();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => actionOfCompare(a, b));
        }

        [Fact]
        public void Int64ValueTest()
        {
            long defaultValue = default(long);
            long maxValue = long.MaxValue;
            long minValue = long.MinValue;
            long[] testValues = new long[] { long.MaxValue, long.MinValue, int.MaxValue, int.MinValue, 0 };
            string invalidValue = "Invalid String!";

            Log.Comment("Testing default value...");
            string expectedText = defaultValue.ToString();
            Int64Value defaultObj = default(Int64Value);
            Log.VerifyNull(defaultObj, "default(Int64Value) returns reference other than NULL");

            Log.Comment("Constructing with Max value and testing...");
            simpleValueValidTest(new Int64Value(maxValue), maxValue, maxValue.ToString());

            Log.Comment("Constructing with Max value and testing with Clone()...");
            simpleValueValidTest(new Int64Value(maxValue).Clone() as Int64Value, maxValue, maxValue.ToString());

            Log.Comment("Set Value with Min value and testing...");
            Int64Value objA = new Int64Value();
            objA.Value = minValue;
            simpleValueValidTest(objA, minValue, minValue.ToString());

            Log.Comment("Set InnerText with Min value and testing...");
            Int64Value objB = new Int64Value();
            objB.InnerText = minValue.ToString();
            simpleValueValidTest(objB, minValue, minValue.ToString());

            Log.Comment("Implicit Int Operator with Min value and testing...");
            objB = minValue;
            simpleValueValidTest(objB, minValue, minValue.ToString());

            foreach (var testValue in testValues)
            {
                Log.Comment("Explicit conversion with value {0} and testing", testValue);
                objB = Int64Value.FromInt64(testValue);
                Log.VerifyTrue(Int64Value.ToInt64(objB) == testValue, "FromInt64() value doesn't equal to ToInt64() value!");

                Log.Comment("Constructing with another instance with valid value...");
                objA = new Int64Value(testValue);
                simpleValueValidTest(new Int64Value(objA), testValue, testValue.ToString());

                Log.Comment("Verifying equality...");
                objA = new Int64Value(testValue);
                objB = new Int64Value(testValue);
                Assert.True(objA.Equals(objB));

                objA = new Int64Value(testValue);
                objB = objA;
                Log.VerifyTrue(object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
                Log.VerifyTrue(object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");
            }

            Log.Comment("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new Int64Value(a); });

            Log.Comment("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            long val = default(long);
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Log.Comment("ErrorHandling: Set InnerText with invalid value...");
            objA = new Int64Value();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => actionOfCompare(a, b));
        }

        [Fact]
        public void IntegerValueTest()
        {
            long defaultValue = default(long);
            long maxValue = long.MaxValue;
            long minValue = long.MinValue;
            long[] testValues = new long[] { long.MaxValue, long.MinValue, int.MaxValue, int.MinValue, 0 };
            string invalidValue = "Invalid String!";

            Log.Comment("Testing default value...");
            string expectedText = defaultValue.ToString();
            IntegerValue defaultObj = default(IntegerValue);
            Log.VerifyNull(defaultObj, "default(Int64Value) returns reference other than NULL");

            Log.Comment("Constructing with Max value and testing...");
            simpleValueValidTest(new IntegerValue(maxValue), maxValue, maxValue.ToString());

            Log.Comment("Constructing with Max value and testing with Clone()...");
            simpleValueValidTest(new IntegerValue(maxValue).Clone() as IntegerValue, maxValue, maxValue.ToString());

            Log.Comment("Set Value with Min value and testing...");
            IntegerValue objA = new IntegerValue();
            objA.Value = minValue;
            simpleValueValidTest(objA, minValue, minValue.ToString());

            Log.Comment("Set InnerText with Min value and testing...");
            IntegerValue objB = new IntegerValue();
            objB.InnerText = minValue.ToString();
            simpleValueValidTest(objB, minValue, minValue.ToString());

            Log.Comment("Implicit Int Operator with Min value and testing...");
            objB = minValue;
            simpleValueValidTest(objB, minValue, minValue.ToString());

            foreach (var testValue in testValues)
            {
                Log.Comment("Explicit IntegerValue conversion with value {0} and testing", testValue);
                objB = IntegerValue.FromInt64(testValue);
                Log.VerifyTrue(IntegerValue.ToInt64(objB) == testValue, "FromInt64() value doesn't equal to ToInt64() value!");

                Log.Comment("Constructing with another instance with valid value...");
                objA = new IntegerValue(testValue);
                simpleValueValidTest(new IntegerValue(objA), testValue, testValue.ToString());

                Log.Comment("Verifying equality...");
                objA = new IntegerValue(testValue);
                objB = new IntegerValue(testValue);
                Assert.True(objA.Equals(objB));

                objA = new IntegerValue(testValue);
                objB = objA;
                Log.VerifyTrue(object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
                Log.VerifyTrue(object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");
            }

            Log.Comment("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new IntegerValue(a); });

            Log.Comment("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            long val = default(long);
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Log.Comment("ErrorHandling: Set InnerText with invalid value...");
            objA = new IntegerValue();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => actionOfCompare(a, b));
        }

        [Fact]
        public void DecimalValueTest()
        {
            decimal defaultValue = default(decimal);
            decimal maxValue = decimal.MaxValue;
            decimal minValue = decimal.MinValue;
            decimal specialValue1 = decimal.MinusOne;
            decimal specialValue2 = decimal.One;
            decimal specialValue3 = decimal.Zero;

            // Decimal validValue = (decimal)(new Random ().Next(0, 10) * (maxValue / 100 - minValue / 100) + minValue / 10);
            decimal validValue = 123.456M;
            string invalidValue = "Invalid String!";

            Log.Comment("Testing default value...");
            string expectedText = defaultValue.ToString(CultureInfo.InvariantCulture);
            DecimalValue defaultObj = default(DecimalValue);
            Log.VerifyNull(defaultObj, "default(DecimalValue) returns reference other than NULL");

            Log.Comment("Constructing with Max value and testing...");
            simpleValueValidTest(new DecimalValue(maxValue), maxValue, maxValue.ToString(CultureInfo.InvariantCulture));

            Log.Comment("Constructing with Max value and testing with Clone()...");
            simpleValueValidTest(new DecimalValue(maxValue).Clone() as DecimalValue, maxValue, maxValue.ToString(CultureInfo.InvariantCulture));

            Log.Comment("Set Value with Min value and testing...");
            DecimalValue objA = new DecimalValue();
            objA.Value = minValue;
            simpleValueValidTest(objA, minValue, minValue.ToString(CultureInfo.InvariantCulture));

            Log.Comment("Set InnerText with Min value and testing...");
            DecimalValue objB = new DecimalValue();
            objB.InnerText = minValue.ToString();
            simpleValueValidTest(objB, minValue, minValue.ToString(CultureInfo.InvariantCulture));

            Log.Comment("Implicit Int Operator with Min value and testing...");
            objB = minValue;
            simpleValueValidTest(objB, minValue, minValue.ToString(CultureInfo.InvariantCulture));

            Log.Comment("Explicit decimal conversion with value {0} and testing", validValue);
            objB = DecimalValue.FromDecimal(validValue);
            Log.VerifyTrue(DecimalValue.ToDecimal(objB) == validValue, "FromDecimal() value doesn't equal to ToDecimal() value!");

            Log.Comment("Constructing with another instance with valid value...");
            objA = new DecimalValue(validValue);
            simpleValueValidTest(new DecimalValue(objA), validValue, validValue.ToString(CultureInfo.InvariantCulture));

            Log.Comment("Constructing with special value {0} and testing...", specialValue1);
            simpleValueValidTest(new DecimalValue(specialValue1), specialValue1, specialValue1.ToString(CultureInfo.InvariantCulture));

            Log.Comment("Constructing with special value {0} and testing...", specialValue2);
            simpleValueValidTest(new DecimalValue(specialValue2), specialValue2, specialValue2.ToString(CultureInfo.InvariantCulture));

            Log.Comment("Constructing with special value {0} and testing...", specialValue3);
            simpleValueValidTest(new DecimalValue(specialValue3), specialValue3, specialValue3.ToString(CultureInfo.InvariantCulture));

            Log.Comment("Verifying equality...");
            objA = new DecimalValue(validValue);
            objB = new DecimalValue(validValue);
            Assert.True(objA.Equals(objB));

            objA = new DecimalValue(validValue);
            objB = objA;
            Log.VerifyTrue(object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Log.VerifyTrue(object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Log.Comment("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new DecimalValue(a); });

            Log.Comment("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            decimal val = default(decimal);
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Log.Comment("ErrorHandling: Set InnerText with invalid value...");
            objA = new DecimalValue();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => actionOfCompare(a, b));
        }

        [Fact]
        public void SingleValueTest()
        {
            float defaultValue = default(float);
            float maxValue = float.MaxValue;
            float minValue = float.MinValue;
            float validValue = 123.456F;
            float specialEpsilon = float.Epsilon;
            float specialPositiveInfinity = float.PositiveInfinity;
            float specialNegativeInfinity = float.NegativeInfinity;
            float specialNaN = float.NaN;
            const string PositiveInfinity = "INF";
            const string NegativeInfinity = "-INF";
            string specialStringINF = "INF";
            string specialStringNINF = "-INF";
            string specialStringInfinity = "Infinity";
            string specialStringNInfinity = "-Infinity";
            string invalidStringInfinity = "infinity";
            string invalidStringNInfinity = "-infinity";
            string invalidStringINF = "Inf";
            string invalidStringNINF = "-Inf";
            string invalidStringValue = "Invalid String!";

            Log.Comment("Testing default value...");
            string expectedText = defaultValue.ToString();
            SingleValue defaultObj = default(SingleValue);
            Log.VerifyNull(defaultObj, "default(SingleValue) returns reference other than NULL");

            Log.Comment("Constructing with Max value and testing...");
            simpleValueValidTest(new SingleValue(maxValue), maxValue, maxValue.ToString("R", CultureInfo.InvariantCulture));

            Log.Comment("Constructing with Max value and testing with Clone()...");
            simpleValueValidTest(new SingleValue(maxValue).Clone() as SingleValue, maxValue, maxValue.ToString("R", CultureInfo.InvariantCulture));

            Log.Comment("Set Value with Min value and testing...");
            SingleValue objA = new SingleValue();
            objA.Value = minValue;
            simpleValueValidTest(objA, minValue, minValue.ToString("R", CultureInfo.InvariantCulture));

            Log.Comment("Set InnerText with Min value and testing...");
            SingleValue objB = new SingleValue();
            objB.InnerText = minValue.ToString("R", CultureInfo.InvariantCulture);
            simpleValueValidTest(objB, minValue, minValue.ToString("R", CultureInfo.InvariantCulture));

            Log.Comment("Implicit Int Operator with Min value and testing...");
            objB = minValue;
            simpleValueValidTest(objB, minValue, minValue.ToString("R", CultureInfo.InvariantCulture));

            Log.Comment("Explicit SingleValue conversion with value {0} and testing", validValue);
            objB = SingleValue.FromSingle(validValue);
            Log.VerifyTrue(SingleValue.ToSingle(objB) == validValue, "SingleValue() value doesn't equal to ToSingle() value!");

            Log.Comment("Constructing with another instance with valid value...");
            objA = new SingleValue(validValue);
            simpleValueValidTest(new SingleValue(objA), validValue, validValue.ToString("R", CultureInfo.InvariantCulture));

            Log.Comment("Constructing with special value {0} and testing...", specialEpsilon);
            simpleValueValidTest(new SingleValue(specialEpsilon), specialEpsilon, specialEpsilon.ToString("R", CultureInfo.InvariantCulture));

            Log.Comment("Constructing with special value {0} and testing...", specialPositiveInfinity);
            simpleValueValidTest(new SingleValue(specialPositiveInfinity), specialPositiveInfinity, PositiveInfinity);

            Log.Comment("Constructing with special value {0} and testing...", specialNegativeInfinity);
            simpleValueValidTest(new SingleValue(specialNegativeInfinity), specialNegativeInfinity, NegativeInfinity);

            Log.Comment("Constructing with special value {0} and testing...", specialNaN);
            simpleValueValidTest(new SingleValue(specialNaN), specialNaN, specialNaN.ToString("R", CultureInfo.InvariantCulture));

            Log.Comment("Set InnerText with special value {0} and testing...", specialStringINF);
            objA = new SingleValue();
            objA.InnerText = specialStringINF;
            simpleValueValidTest(objA, float.PositiveInfinity, specialStringINF);

            Log.Comment("Set InnerText with special value {0} and testing...", specialStringNINF);
            objA = new SingleValue();
            objA.InnerText = specialStringNINF;
            simpleValueValidTest(objA, float.NegativeInfinity, specialStringNINF);

            Log.Comment("Set InnerText with special value {0} and testing...", specialStringInfinity);
            objA = new SingleValue();
            objA.InnerText = specialStringInfinity;
            simpleValueValidTest(objA, float.PositiveInfinity, specialStringInfinity);

            Log.Comment("Set InnerText with special value {0} and testing...", specialStringNInfinity);
            objA = new SingleValue();
            objA.InnerText = specialStringNInfinity;
            simpleValueValidTest(objA, float.NegativeInfinity, specialStringNInfinity);

            Log.Comment("Verifying equality...");
            objA = new SingleValue(validValue);
            objB = new SingleValue(validValue);
            Assert.True(objA.Equals(objB));

            objA = new SingleValue(validValue);
            objB = objA;
            Log.VerifyTrue(object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Log.VerifyTrue(object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Log.Comment("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new SingleValue(a); });

            Log.Comment("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            float val = default(float);
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidStringValue);
            objA = new SingleValue();
            objA.InnerText = invalidStringValue;
            InvalidOperation(objA, invalidStringValue, (a, b) => actionOfCompare(a, b));

            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidStringINF);
            objA = new SingleValue();
            objA.InnerText = invalidStringINF;
            InvalidOperation(objA, invalidStringINF, (a, b) => actionOfCompare(a, b));

            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidStringNINF);
            objA = new SingleValue();
            objA.InnerText = invalidStringNINF;
            InvalidOperation(objA, invalidStringNINF, (a, b) => actionOfCompare(a, b));

            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidStringInfinity);
            objA = new SingleValue();
            objA.InnerText = invalidStringInfinity;
            InvalidOperation(objA, invalidStringInfinity, (a, b) => actionOfCompare(a, b));

            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidStringNInfinity);
            objA = new SingleValue();
            objA.InnerText = invalidStringNInfinity;
            InvalidOperation(objA, invalidStringNInfinity, (a, b) => actionOfCompare(a, b));
        }

        [Fact]
        public void DoubleValueTest()
        {
            double defaultValue = default(double);
            double maxValue = double.MaxValue;
            double minValue = double.MinValue;
            double validValue = (double)123.456;
            double specialEpsilon = double.Epsilon;
            double specialPositiveInfinity = double.PositiveInfinity;
            double specialNegativeInfinity = double.NegativeInfinity;
            double specialNaN = double.NaN;
            const string negativeInfinity = "-INF";
            const string positiveInfinity = "INF";
            string specialStringINF = "INF";
            string specialStringNINF = "-INF";
            string specialStringInfinity = "Infinity";
            string specialStringNInfinity = "-Infinity";
            string invalidStringInfinity = "infinity";
            string invalidStringNInfinity = "-infinity";
            string invalidStringINF = "Inf";
            string invalidStringNINF = "-Inf";
            string invalidStringValue = "Invalid String!";

            Log.Comment("Testing default value...");
            string expectedText = defaultValue.ToString(CultureInfo.InvariantCulture);
            DoubleValue defaultObj = default(DoubleValue);
            Log.VerifyNull(defaultObj, "default(DoubleValue) returns reference other than NULL");

            Log.Comment("Constructing with Max value and testing...");
            simpleValueValidTest(new DoubleValue(maxValue), maxValue, maxValue.ToString("R", CultureInfo.InvariantCulture));

            Log.Comment("Constructing with Max value and testing with Clone()...");
            simpleValueValidTest(new DoubleValue(maxValue).Clone() as DoubleValue, maxValue, maxValue.ToString("R", CultureInfo.InvariantCulture));

            Log.Comment("Set Value with Min value and testing...");
            DoubleValue objA = new DoubleValue();
            objA.Value = minValue;
            simpleValueValidTest(objA, minValue, minValue.ToString("R", CultureInfo.InvariantCulture));

            Log.Comment("Set InnerText with Min value and testing...");
            DoubleValue objB = new DoubleValue();
            objB.InnerText = minValue.ToString("R", CultureInfo.InvariantCulture);
            simpleValueValidTest(objB, minValue, minValue.ToString("R", CultureInfo.InvariantCulture));

            Log.Comment("Implicit Int Operator with Min value and testing...");
            objB = minValue;
            simpleValueValidTest(objB, minValue, minValue.ToString("R", CultureInfo.InvariantCulture));

            Log.Comment("Explicit Double conversion with value {0} and testing", validValue);
            objB = DoubleValue.FromDouble(validValue);
            Log.VerifyTrue(DoubleValue.ToDouble(objB) == validValue, "FromDouble() value doesn't equal to ToDouble() value!");

            Log.Comment("Constructing with another instance with valid value...");
            objA = new DoubleValue(validValue);
            simpleValueValidTest(new DoubleValue(objA), validValue, validValue.ToString("R", CultureInfo.InvariantCulture));

            Log.Comment("Constructing with special value {0} and testing...", specialEpsilon);
            simpleValueValidTest(new DoubleValue(specialEpsilon), specialEpsilon, specialEpsilon.ToString("R", CultureInfo.InvariantCulture));

            Log.Comment("Constructing with special value {0} and testing...", specialPositiveInfinity);
            simpleValueValidTest(new DoubleValue(specialPositiveInfinity), specialPositiveInfinity, positiveInfinity);

            Log.Comment("Constructing with special value {0} and testing...", specialNegativeInfinity);
            simpleValueValidTest(new DoubleValue(specialNegativeInfinity), specialNegativeInfinity, negativeInfinity);

            Log.Comment("Constructing with special value {0} and testing...", specialNaN);
            simpleValueValidTest(new DoubleValue(specialNaN), specialNaN, specialNaN.ToString("R", CultureInfo.InvariantCulture));

            Log.Comment("Set InnerText with special value {0} and testing...", specialStringINF);
            objA = new DoubleValue();
            objA.InnerText = specialStringINF;
            simpleValueValidTest(objA, double.PositiveInfinity, specialStringINF);

            Log.Comment("Set InnerText with special value {0} and testing...", specialStringNINF);
            objA = new DoubleValue();
            objA.InnerText = specialStringNINF;
            simpleValueValidTest(objA, double.NegativeInfinity, specialStringNINF);

            Log.Comment("Set InnerText with special value {0} and testing...", specialStringInfinity);
            objA = new DoubleValue();
            objA.InnerText = specialStringInfinity;
            simpleValueValidTest(objA, double.PositiveInfinity, specialStringInfinity);

            Log.Comment("Set InnerText with special value {0} and testing...", specialStringNInfinity);
            objA = new DoubleValue();
            objA.InnerText = specialStringNInfinity;
            simpleValueValidTest(objA, double.NegativeInfinity, specialStringNInfinity);

            Log.Comment("Verifying equality...");
            objA = new DoubleValue(validValue);
            objB = new DoubleValue(validValue);
            Assert.True(objA.Equals(objB));

            objA = new DoubleValue(validValue);
            objB = objA;
            Log.VerifyTrue(object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Log.VerifyTrue(object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Log.Comment("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new DoubleValue(a); });

            Log.Comment("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            double val = default(double);
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidStringValue);
            objA = new DoubleValue();
            objA.InnerText = invalidStringValue;
            InvalidOperation(objA, invalidStringValue, (a, b) => actionOfCompare(a, b));

            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidStringINF);
            objA = new DoubleValue();
            objA.InnerText = invalidStringINF;
            InvalidOperation(objA, invalidStringINF, (a, b) => actionOfCompare(a, b));

            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidStringNINF);
            objA = new DoubleValue();
            objA.InnerText = invalidStringNINF;
            InvalidOperation(objA, invalidStringNINF, (a, b) => actionOfCompare(a, b));

            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidStringInfinity);
            objA = new DoubleValue();
            objA.InnerText = invalidStringInfinity;
            InvalidOperation(objA, invalidStringInfinity, (a, b) => actionOfCompare(a, b));

            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidStringNInfinity);
            objA = new DoubleValue();
            objA.InnerText = invalidStringNInfinity;
            InvalidOperation(objA, invalidStringNInfinity, (a, b) => actionOfCompare(a, b));
        }

        [Fact]
        public void DateTimeValueTest()
        {
            DateTime defaultValue = default(DateTime);
            DateTime maxValue = DateTime.MaxValue;
            DateTime minValue = DateTime.MinValue;

            //var ratio = (decimal)new Random ().Next(0, 100) / 100;
            var ratio = 0.5M;
            DateTime validValue = new DateTime((long)(ratio * maxValue.Ticks + (1 - ratio) * minValue.Ticks));
            string invalidValue = DateTime.Now.ToString();

            string datatimePattern = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'FFFFFFF";

            Log.Comment("Testing default value...");
            string expectedText = defaultValue.ToString();
            DateTimeValue defaultObj = default(DateTimeValue);
            Log.VerifyNull(defaultObj, "default(DateTimeValue) returns reference other than NULL");

            Log.Comment("Constructing with Max value and testing...");
            simpleValueValidTest(new DateTimeValue(maxValue), maxValue, maxValue.ToString(datatimePattern));

            Log.Comment("Constructing with Max value and testing with Clone()...");
            simpleValueValidTest(new DateTimeValue(maxValue).Clone() as DateTimeValue, maxValue, maxValue.ToString(datatimePattern));

            Log.Comment("Set Value with Min value and testing...");
            DateTimeValue objA = new DateTimeValue();
            objA.Value = minValue;
            simpleValueValidTest(objA, minValue, minValue.ToString(datatimePattern));

            Log.Comment("Set InnerText with Min value and testing...");
            DateTimeValue objB = new DateTimeValue();
            objB.InnerText = minValue.ToString(datatimePattern);
            simpleValueValidTest(objB, minValue, minValue.ToString(datatimePattern));

            Log.Comment("Implicit Int Operator with Min value and testing...");
            objB = minValue;
            simpleValueValidTest(objB, minValue, minValue.ToString(datatimePattern));

            Log.Comment("Explicit conversion with value {0} and testing", validValue);
            objB = DateTimeValue.FromDateTime(validValue);
            Log.VerifyTrue(DateTimeValue.ToDateTime(objB) == validValue, "FromDateTime() value doesn't equal to ToDateTime() value!");

            Log.Comment("Constructing with another instance with valid value...");
            objA = new DateTimeValue(validValue);
            simpleValueValidTest(new DateTimeValue(objA), validValue, validValue.ToString(datatimePattern));

            Log.Comment("Verifying equality...");
            objA = new DateTimeValue(validValue);
            objB = new DateTimeValue(validValue);
            Assert.True(objA.Equals(objB));

            objA = new DateTimeValue(validValue);
            objB = objA;
            Log.VerifyTrue(object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Log.VerifyTrue(object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Log.Comment("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new DateTimeValue(a); });

            Log.Comment("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            DateTime val = default(DateTime);
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Log.Comment("ErrorHandling: Set InnerText with invalid value...");
            objA = new DateTimeValue();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => actionOfCompare(a, b));
        }

        #region Common Functions

        private void InvalidOperation<T>(OpenXmlSimpleValue<T> a, OpenXmlSimpleValue<T> b,
            Action<OpenXmlSimpleValue<T>, OpenXmlSimpleValue<T>> action)
            where T : struct
        {
            try
            {
                action(a, b);
                Log.Fail("Action executed without any exception.");
            }
            catch (Exception e)
            {
                Log.Warning(e.ToString());
                Log.Pass("Expected {0} Caught!", e.GetType().Name);
            }
        }

        private void InvalidOperation<T1, T2>(
            OpenXmlSimpleValue<T1> a, T2 b,
            Action<OpenXmlSimpleValue<T1>, T2> action)
            where T1 : struct
        {
            try
            {
                action(a, b);
                Log.Fail("Action executed without any exception.");
            }
            catch (Exception e)
            {
                Log.Warning(e.ToString());
                Log.Pass("Expected {0} Caught!", e.GetType().Name);
            }
        }

        private void actionOfCompare<T>(OpenXmlSimpleValue<T> a, OpenXmlSimpleValue<T> b)
            where T : struct
        {
            Log.Comment(string.Format("ObjectA {0} value.", a.HasValue ? "HAS" : "has NO"));
            Log.Comment(string.Format("ObjectB {0} value.", b.HasValue ? "HAS" : "has NO"));
            Log.Verify(b.Equals(a.InnerText), "Instance constructed with invalid value does NOT keep the text.");
            Log.Verify(b.Equals(a.Value), "Instance constructed with invalid value CAN parse without error!");
        }

        private void actionOfCompare<T1, T2>(OpenXmlSimpleValue<T1> a, T2 b)
            where T1 : struct
        {
            Log.Comment(string.Format("ObjectA {0} value.", a.HasValue ? "HAS" : "has NO"));
            Log.Verify(b.Equals(a.InnerText), "Instance constructed with invalid value does NOT keep the text.");
            Log.Verify(b.Equals(a.Value), "Instance constructed with invalid value CAN parse without error!");
        }

        private void simpleValueValidTest<T>(OpenXmlSimpleValue<T> oxObj, T expectedValue, string expectedText)
            where T : struct
        {
            Log.Comment("Entering Generic Test Method...");

            string stringValue = oxObj.InnerText;
            Log.VerifyValue(stringValue, expectedText,
                "Property InnerText {0} does NOT equal to expected {1}.", stringValue, expectedText);

            stringValue = oxObj;
            Log.VerifyValue(stringValue, expectedText,
                "string operator result {0} does NOT equal to expected {1}.", stringValue, expectedText);

            stringValue = oxObj.ToString();
            Log.VerifyValue(stringValue, expectedText,
                "ToString() result {0} does NOT equal to expected {1}.", stringValue, expectedText);

            Log.Verify(oxObj.HasValue, "{0} with valid value has NO value.", oxObj.GetType().Name);
            Log.VerifyTrue(oxObj.Value.Equals(expectedValue),
                "Property Value {0} does NOT equal to expected {1}.", oxObj.Value, expectedValue);

            T val = oxObj;
            Log.VerifyTrue(val.Equals(expectedValue),
                "{0} operator result {1} does NOT equal to expected {2}.", typeof(T).Name, val, expectedValue);

            val = oxObj as OpenXmlSimpleValue<T>;
            Log.VerifyTrue(val.Equals(expectedValue),
                "{0} operator result {1} does NOT equal to expected {2}.", typeof(OpenXmlSimpleValue<T>).Name, val, expectedValue);

            Log.Comment("Leaving Generic Test Method...");
        }

        private void simpleValueValidTestNonGeneric(Int32Value oxObj, int expectedValue, string expectedText)
        {
            Log.Comment("Entering Non-Generic Test Method...");

            string stringValue = oxObj.InnerText;
            Log.VerifyValue(stringValue, expectedText,
                "string operator result {0} does NOT equal to expected {1}.", stringValue, expectedText);

            stringValue = oxObj.ToString();
            Log.VerifyValue(stringValue, expectedText,
                "ToString() result {0} does NOT equal to expected {1}.", stringValue, expectedText);

            stringValue = oxObj;
            Log.VerifyValue(stringValue, expectedText,
                "string operator result {0} does NOT equal to expected {1}.", stringValue, expectedText);

            Log.Verify(oxObj.HasValue, "Int32Value with valid value has NO value.");
            Log.VerifyValue(oxObj.Value, expectedValue,
                "Property Value {0} does NOT equal to expected value {1}.", oxObj.Value, expectedValue);

            int val = oxObj;
            Log.VerifyValue(val, expectedValue,
                "int operator result {0} does NOT equal to expected value {1}.", val, expectedValue);

            val = oxObj as OpenXmlSimpleValue<int>;
            Log.VerifyValue(val, expectedValue,
                "int operator result {0} does NOT equal to expected value {1}.", val, expectedValue);

            Log.Comment("Leaving Non-Generic Test Method...");
        }
        #endregion Common Functions
    }
}
