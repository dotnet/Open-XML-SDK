// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Globalization;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    // DocumentFormat.OpenXml.OpenXmlSimpleValue<T>
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

            Output.WriteLine("Testing default value...");
            string expectedText = defaultValue.ToString();
            BooleanValue defaultObj = default(BooleanValue);
            Assert.Null(defaultObj);

            Output.WriteLine("Constructing with Max value and testing...");
            SimpleValueValidTest(new BooleanValue(maxValue), maxValue, maxValue == true ? "1" : "0");

            Output.WriteLine("Constructing with Max value and testing with Clone()...");
            SimpleValueValidTest(new BooleanValue(maxValue).Clone() as BooleanValue, maxValue, maxValue == true ? "1" : "0");

            Output.WriteLine("Set Value with Min value and testing...");
            BooleanValue objA = new BooleanValue();
            objA.Value = minValue;
            SimpleValueValidTest(objA, minValue, minValue == true ? "1" : "0");

            Output.WriteLine("Set InnerText with Min value and testing...");
            BooleanValue objB = new BooleanValue();
            objB.InnerText = minValue.ToString().ToLower(); // True -> true, False -> false
            SimpleValueValidTest(objB, minValue, minValue.ToString().ToLower());

            Output.WriteLine("Implicit Int Operator with Min value and testing...");
            objB = minValue;
            SimpleValueValidTest(objB, minValue, minValue == true ? "1" : "0");

            Output.WriteLine("Explicit bool conversion with value {0} and testing", validValue);
            objB = BooleanValue.FromBoolean(validValue);
            Assert.True(BooleanValue.ToBoolean(objB) == validValue, "FromXX() value doesn't equal to ToXX() value!");

            Output.WriteLine("Constructing with another instance with valid value...");
            objA = new BooleanValue(validValue);
            SimpleValueValidTest(new BooleanValue(objA), validValue, validValue == true ? "1" : "0");

            Output.WriteLine("Verifying equality...");
            objA = new BooleanValue(validValue);
            objB = new BooleanValue(validValue);
            Assert.True(objA.Equals(objB));

            objA = new BooleanValue(validValue);
            objB = objA;
            Assert.True(object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Assert.True(object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Output.WriteLine("Setting InnerText as special value and testing...");
            objA = new BooleanValue();
            objA.InnerText = specialValue0;
            SimpleValueValidTest(objA, false, specialValue0);
            objA.InnerText = specialValue1;
            SimpleValueValidTest(objA, true, specialValue1);
            objA.InnerText = specialValuefalse;
            SimpleValueValidTest(objA, false, specialValuefalse);
            objA.InnerText = specialValuetrue;
            SimpleValueValidTest(objA, true, specialValuetrue);

            Output.WriteLine("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new BooleanValue(a); });

            Output.WriteLine("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            bool val = defaultValue;
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidValueFalse);
            objA = new BooleanValue();
            objA.InnerText = invalidValueFalse;
            InvalidOperation(objA, invalidValueFalse, (a, b) => ActionOfCompare(a, b));

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidValueTrue);
            objA = new BooleanValue();
            objA.InnerText = invalidValueTrue;
            InvalidOperation(objA, invalidValueTrue, (a, b) => ActionOfCompare(a, b));

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidValueOff);
            objA = new BooleanValue();
            objA.InnerText = invalidValueOff;
            InvalidOperation(objA, invalidValueOff, (a, b) => ActionOfCompare(a, b));

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidValueOn);
            objA = new BooleanValue();
            objA.InnerText = invalidValueOn;
            InvalidOperation(objA, invalidValueOn, (a, b) => ActionOfCompare(a, b));

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidValue);
            objA = new BooleanValue();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => ActionOfCompare(a, b));

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidValue2);
            objA = new BooleanValue();
            objA.InnerText = invalidValue2;
            InvalidOperation(objA, invalidValue2, (a, b) => ActionOfCompare(a, b));

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidValue3);
            objA = new BooleanValue();
            objA.InnerText = invalidValue3;
            InvalidOperation(objA, invalidValue3, (a, b) => ActionOfCompare(a, b));
        }

        [Fact]
        public void ByteValueTest()
        {
            byte defaultValue = default(byte);
            byte maxValue = byte.MaxValue;
            byte minValue = byte.MinValue;
            byte validValue = 50;
            string invalidValue = "Invalid String!";

            Output.WriteLine("Testing default value...");
            string expectedText = defaultValue.ToString();
            ByteValue defaultObj = default(ByteValue);
            Assert.Null(defaultObj);

            Output.WriteLine("Constructing with Max value and testing...");
            SimpleValueValidTest(new ByteValue(maxValue), maxValue, maxValue.ToString());

            Output.WriteLine("Constructing with Max value and testing with Clone()...");
            SimpleValueValidTest(new ByteValue(maxValue).Clone() as ByteValue, maxValue, maxValue.ToString());

            Output.WriteLine("Set Value with Min value and testing...");
            ByteValue objA = new ByteValue();
            objA.Value = minValue;
            SimpleValueValidTest(objA, minValue, minValue.ToString());

            Output.WriteLine("Set InnerText with Min value and testing...");
            ByteValue objB = new ByteValue();
            objB.InnerText = minValue.ToString();
            SimpleValueValidTest(objB, minValue, minValue.ToString());

            Output.WriteLine("Implicit Int Operator with Min value and testing...");
            objB = minValue;
            SimpleValueValidTest(objB, minValue, minValue.ToString());

            Output.WriteLine("Explicit byte conversion with value {0} and testing", validValue);
            objB = ByteValue.FromByte(validValue);
            Assert.True(ByteValue.ToByte(objB) == validValue, "FromByte() value doesn't equal to ToByte() value!");

            Output.WriteLine("Constructing with another instance with valid value...");
            objA = new ByteValue(validValue);
            SimpleValueValidTest(new ByteValue(objA), validValue, validValue.ToString());

            Output.WriteLine("Verifying equality...");
            objA = new ByteValue(validValue);
            objB = new ByteValue(validValue);
            Assert.True(objA.Equals(objB));

            objA = new ByteValue(validValue);
            objB = objA;
            Assert.True(object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Assert.True(object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Output.WriteLine("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new ByteValue(a); });

            Output.WriteLine("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            byte val = default(byte);
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value...");
            objA = new ByteValue();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => ActionOfCompare(a, b));
        }

        [Fact]
        public void SByteValueTest()
        {
            sbyte defaultValue = default(sbyte);
            sbyte maxValue = sbyte.MaxValue;
            sbyte minValue = sbyte.MinValue;
            sbyte validValue = 50;
            string invalidValue = "Invalid String!";

            Output.WriteLine("Testing default value...");
            string expectedText = defaultValue.ToString();
            SByteValue defaultObj = default(SByteValue);
            Assert.Null(defaultObj);

            Output.WriteLine("Constructing with Max value and testing...");
            SimpleValueValidTest(new SByteValue(maxValue), maxValue, maxValue.ToString());

            Output.WriteLine("Constructing with Max value and testing with Clone()...");
            SimpleValueValidTest(new SByteValue(maxValue).Clone() as SByteValue, maxValue, maxValue.ToString());

            Output.WriteLine("Set Value with Min value and testing...");
            SByteValue objA = new SByteValue();
            objA.Value = minValue;
            SimpleValueValidTest(objA, minValue, minValue.ToString());

            Output.WriteLine("Set InnerText with Min value and testing...");
            SByteValue objB = new SByteValue();
            objB.InnerText = minValue.ToString();
            SimpleValueValidTest(objB, minValue, minValue.ToString());

            Output.WriteLine("Implicit Int Operator with Min value and testing...");
            objB = minValue;
            SimpleValueValidTest(objB, minValue, minValue.ToString());

            Output.WriteLine("Explicit SByteValue conversion with value {0} and testing", validValue);
            objB = SByteValue.FromSByte(validValue);
            Assert.True(SByteValue.ToSByte(objB) == validValue, "FromSByte() value doesn't equal to ToSByte() value!");

            Output.WriteLine("Constructing with another instance with valid value...");
            objA = new SByteValue(validValue);
            SimpleValueValidTest(new SByteValue(objA), validValue, validValue.ToString());

            Output.WriteLine("Verifying equality...");
            objA = new SByteValue(validValue);
            objB = new SByteValue(validValue);
            Assert.True(objA.Equals(objB));

            objA = new SByteValue(validValue);
            objB = objA;
            Assert.True(object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Assert.True(object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Output.WriteLine("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new SByteValue(a); });

            Output.WriteLine("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            sbyte val = default(sbyte);
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value...");
            objA = new SByteValue();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => ActionOfCompare(a, b));
        }

        [Fact]
        public void UInt16ValueTest()
        {
            ushort defaultValue = default(ushort);
            ushort maxValue = ushort.MaxValue;
            ushort minValue = ushort.MinValue;
            ushort validValue = 123;
            string invalidValue = "Invalid String!";

            Output.WriteLine("Testing default value...");
            string expectedText = defaultValue.ToString();
            UInt16Value defaultObj = default(UInt16Value);
            Assert.Null(defaultObj);

            Output.WriteLine("Constructing with Max value and testing...");
            SimpleValueValidTest(new UInt16Value(maxValue), maxValue, maxValue.ToString());

            Output.WriteLine("Constructing with Max value and testing with Clone()...");
            SimpleValueValidTest(new UInt16Value(maxValue).Clone() as UInt16Value, maxValue, maxValue.ToString());

            Output.WriteLine("Set Value with Min value and testing...");
            UInt16Value objA = new UInt16Value();
            objA.Value = minValue;
            SimpleValueValidTest(objA, minValue, minValue.ToString());

            Output.WriteLine("Set InnerText with Min value and testing...");
            UInt16Value objB = new UInt16Value();
            objB.InnerText = minValue.ToString();
            SimpleValueValidTest(objB, minValue, minValue.ToString());

            Output.WriteLine("Implicit Int Operator with Min value and testing...");
            objB = minValue;
            SimpleValueValidTest(objB, minValue, minValue.ToString());

            Output.WriteLine("Explicit conversion with value {0} and testing", validValue);
            objB = UInt16Value.FromUInt16(validValue);
            Assert.True(UInt16Value.ToUInt16(objB) == validValue, "FromUInt16() value doesn't equal to ToUInt16() value!");

            Output.WriteLine("Constructing with another instance with valid value...");
            objA = new UInt16Value(validValue);
            SimpleValueValidTest(new UInt16Value(objA), validValue, validValue.ToString());

            Output.WriteLine("Verifying equality...");
            objA = new UInt16Value(validValue);
            objB = new UInt16Value(validValue);
            Assert.True(objA.Equals(objB));

            objA = new UInt16Value(validValue);
            objB = objA;
            Assert.True(object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Assert.True(object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Output.WriteLine("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new UInt16Value(a); });

            Output.WriteLine("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            ushort val = default(ushort);
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value...");
            objA = new UInt16Value();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => ActionOfCompare(a, b));
        }

        [Fact]
        public void UInt32ValueTest()
        {
            uint defaultValue = default(uint);
            uint maxValue = uint.MaxValue;
            uint minValue = uint.MinValue;
            uint validValue = 123456;
            string invalidValue = "Invalid String!";

            Output.WriteLine("Testing default value...");
            string expectedText = defaultValue.ToString();
            UInt32Value defaultObj = default(UInt32Value);
            Assert.Null(defaultObj);

            Output.WriteLine("Constructing with Max value and testing...");
            SimpleValueValidTest(new UInt32Value(maxValue), maxValue, maxValue.ToString());

            Output.WriteLine("Constructing with Max value and testing with Clone()...");
            SimpleValueValidTest(new UInt32Value(maxValue).Clone() as UInt32Value, maxValue, maxValue.ToString());

            Output.WriteLine("Set Value with Min value and testing...");
            UInt32Value objA = new UInt32Value();
            objA.Value = minValue;
            SimpleValueValidTest(objA, minValue, minValue.ToString());

            Output.WriteLine("Set InnerText with Min value and testing...");
            UInt32Value objB = new UInt32Value();
            objB.InnerText = minValue.ToString();
            SimpleValueValidTest(objB, minValue, minValue.ToString());

            Output.WriteLine("Implicit Int Operator with Min value and testing...");
            objB = minValue;
            SimpleValueValidTest(objB, minValue, minValue.ToString());

            Output.WriteLine("Explicit conversion with value {0} and testing", validValue);
            objB = UInt32Value.FromUInt32(validValue);
            Assert.True(UInt32Value.ToUInt32(objB) == validValue, "FromUInt32() value doesn't equal to ToUInt32() value!");

            Output.WriteLine("Constructing with another instance with valid value...");
            objA = new UInt32Value(validValue);
            SimpleValueValidTest(new UInt32Value(objA), validValue, validValue.ToString());

            Output.WriteLine("Verifying equality...");
            objA = new UInt32Value(validValue);
            objB = new UInt32Value(validValue);
            Assert.True(objA.Equals(objB));

            objA = new UInt32Value(validValue);
            objB = objA;
            Assert.True(object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Assert.True(object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Output.WriteLine("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new UInt32Value(a); });

            Output.WriteLine("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            uint val = default(uint);
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value...");
            objA = new UInt32Value();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => ActionOfCompare(a, b));
        }

        [Fact]
        public void Int32ValueTest()
        {
            int defaultValue = default(int);
            int maxValue = int.MaxValue;
            int minValue = int.MinValue;
            int validValue = 123456;
            string invalidValue = "Invalid String!";

            Output.WriteLine("Testing default value...");
            string expectedText = defaultValue.ToString();
            Int32Value defaultObj = default(Int32Value);
            Assert.Null(defaultObj);

            Output.WriteLine("Constructing with Max value and testing...");
            SimpleValueValidTest(new Int32Value(maxValue), maxValue, maxValue.ToString());

            Output.WriteLine("Constructing with Max value and testing with Clone()...");
            SimpleValueValidTest(new Int32Value(maxValue).Clone() as Int32Value, maxValue, maxValue.ToString());

            Output.WriteLine("Set Value with Min value and testing...");
            Int32Value objA = new Int32Value();
            objA.Value = minValue;
            SimpleValueValidTest(objA, minValue, minValue.ToString());

            Output.WriteLine("Set InnerText with Min value and testing...");
            Int32Value objB = new Int32Value();
            objB.InnerText = minValue.ToString();
            SimpleValueValidTest(objB, minValue, minValue.ToString());

            Output.WriteLine("Implicit Int Operator with Min value and testing...");
            objB = minValue;
            SimpleValueValidTest(objB, minValue, minValue.ToString());

            Output.WriteLine("Explicit conversion with value {0} and testing", validValue);
            objB = Int32Value.FromInt32(validValue);
            Assert.True(Int32Value.ToInt32(objB) == validValue, "FromInt32() value doesn't equal to ToInt32() value!");

            Output.WriteLine("Constructing with another instance with valid value...");
            objA = new Int32Value(validValue);
            SimpleValueValidTest(new Int32Value(objA), validValue, validValue.ToString());

            Output.WriteLine("Verifying equality...");
            objA = new Int32Value(validValue);
            objB = new Int32Value(validValue);
            Assert.True(objA.Equals(objB));

            objA = new Int32Value(validValue);
            objB = objA;
            Assert.True(object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Assert.True(object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Output.WriteLine("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new Int32Value(a); });

            Output.WriteLine("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            int val = default(int);
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value...");
            objA = new Int32Value();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => ActionOfCompare(a, b));
        }

        [Fact]
        public void UInt64ValueTest()
        {
            ulong defaultValue = default(ulong);
            ulong maxValue = ulong.MaxValue;
            ulong minValue = ulong.MinValue;
            ulong validValue = 123456;
            string invalidValue = "Invalid String!";

            Output.WriteLine("Testing default value...");
            string expectedText = defaultValue.ToString();
            UInt64Value defaultObj = default(UInt64Value);
            Assert.Null(defaultObj);

            Output.WriteLine("Constructing with Max value and testing...");
            SimpleValueValidTest(new UInt64Value(maxValue), maxValue, maxValue.ToString());

            Output.WriteLine("Constructing with Max value and testing with Clone()...");
            SimpleValueValidTest(new UInt64Value(maxValue).Clone() as UInt64Value, maxValue, maxValue.ToString());

            Output.WriteLine("Set Value with Min value and testing...");
            UInt64Value objA = new UInt64Value();
            objA.Value = minValue;
            SimpleValueValidTest(objA, minValue, minValue.ToString());

            Output.WriteLine("Set InnerText with Min value and testing...");
            UInt64Value objB = new UInt64Value();
            objB.InnerText = minValue.ToString();
            SimpleValueValidTest(objB, minValue, minValue.ToString());

            Output.WriteLine("Implicit Int Operator with Min value and testing...");
            objB = minValue;
            SimpleValueValidTest(objB, minValue, minValue.ToString());

            Output.WriteLine("Explicit UInt64Value conversion with value {0} and testing", validValue);
            objB = UInt64Value.FromUInt64(validValue);
            Assert.True(UInt64Value.ToUInt64(objB) == validValue, "FromUInt64() value doesn't equal to ToUInt64() value!");

            Output.WriteLine("Constructing with another instance with valid value...");
            objA = new UInt64Value(validValue);
            SimpleValueValidTest(new UInt64Value(objA), validValue, validValue.ToString());

            Output.WriteLine("Verifying equality...");
            objA = new UInt64Value(validValue);
            objB = new UInt64Value(validValue);
            Assert.True(objA.Equals(objB));

            objA = new UInt64Value(validValue);
            objB = objA;
            Assert.True(object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Assert.True(object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Output.WriteLine("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new UInt64Value(a); });

            Output.WriteLine("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            ulong val = default(ulong);
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value...");
            objA = new UInt64Value();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => ActionOfCompare(a, b));
        }

        [Fact]
        public void Int64ValueTest()
        {
            long defaultValue = default(long);
            long maxValue = long.MaxValue;
            long minValue = long.MinValue;
            long[] testValues = new long[] { long.MaxValue, long.MinValue, int.MaxValue, int.MinValue, 0 };
            string invalidValue = "Invalid String!";

            Output.WriteLine("Testing default value...");
            string expectedText = defaultValue.ToString();
            Int64Value defaultObj = default(Int64Value);
            Assert.Null(defaultObj);

            Output.WriteLine("Constructing with Max value and testing...");
            SimpleValueValidTest(new Int64Value(maxValue), maxValue, maxValue.ToString());

            Output.WriteLine("Constructing with Max value and testing with Clone()...");
            SimpleValueValidTest(new Int64Value(maxValue).Clone() as Int64Value, maxValue, maxValue.ToString());

            Output.WriteLine("Set Value with Min value and testing...");
            Int64Value objA = new Int64Value();
            objA.Value = minValue;
            SimpleValueValidTest(objA, minValue, minValue.ToString());

            Output.WriteLine("Set InnerText with Min value and testing...");
            Int64Value objB = new Int64Value();
            objB.InnerText = minValue.ToString();
            SimpleValueValidTest(objB, minValue, minValue.ToString());

            Output.WriteLine("Implicit Int Operator with Min value and testing...");
            objB = minValue;
            SimpleValueValidTest(objB, minValue, minValue.ToString());

            foreach (var testValue in testValues)
            {
                Output.WriteLine("Explicit conversion with value {0} and testing", testValue);
                objB = Int64Value.FromInt64(testValue);
                Assert.True(Int64Value.ToInt64(objB) == testValue, "FromInt64() value doesn't equal to ToInt64() value!");

                Output.WriteLine("Constructing with another instance with valid value...");
                objA = new Int64Value(testValue);
                SimpleValueValidTest(new Int64Value(objA), testValue, testValue.ToString());

                Output.WriteLine("Verifying equality...");
                objA = new Int64Value(testValue);
                objB = new Int64Value(testValue);
                Assert.True(objA.Equals(objB));

                objA = new Int64Value(testValue);
                objB = objA;
                Assert.True(object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
                Assert.True(object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");
            }

            Output.WriteLine("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new Int64Value(a); });

            Output.WriteLine("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            long val = default(long);
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value...");
            objA = new Int64Value();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => ActionOfCompare(a, b));
        }

        [Fact]
        public void IntegerValueTest()
        {
            long defaultValue = default(long);
            long maxValue = long.MaxValue;
            long minValue = long.MinValue;
            long[] testValues = new long[] { long.MaxValue, long.MinValue, int.MaxValue, int.MinValue, 0 };
            string invalidValue = "Invalid String!";

            Output.WriteLine("Testing default value...");
            string expectedText = defaultValue.ToString();
            IntegerValue defaultObj = default(IntegerValue);
            Assert.Null(defaultObj);

            Output.WriteLine("Constructing with Max value and testing...");
            SimpleValueValidTest(new IntegerValue(maxValue), maxValue, maxValue.ToString());

            Output.WriteLine("Constructing with Max value and testing with Clone()...");
            SimpleValueValidTest(new IntegerValue(maxValue).Clone() as IntegerValue, maxValue, maxValue.ToString());

            Output.WriteLine("Set Value with Min value and testing...");
            IntegerValue objA = new IntegerValue();
            objA.Value = minValue;
            SimpleValueValidTest(objA, minValue, minValue.ToString());

            Output.WriteLine("Set InnerText with Min value and testing...");
            IntegerValue objB = new IntegerValue();
            objB.InnerText = minValue.ToString();
            SimpleValueValidTest(objB, minValue, minValue.ToString());

            Output.WriteLine("Implicit Int Operator with Min value and testing...");
            objB = minValue;
            SimpleValueValidTest(objB, minValue, minValue.ToString());

            foreach (var testValue in testValues)
            {
                Output.WriteLine("Explicit IntegerValue conversion with value {0} and testing", testValue);
                objB = IntegerValue.FromInt64(testValue);
                Assert.True(IntegerValue.ToInt64(objB) == testValue, "FromInt64() value doesn't equal to ToInt64() value!");

                Output.WriteLine("Constructing with another instance with valid value...");
                objA = new IntegerValue(testValue);
                SimpleValueValidTest(new IntegerValue(objA), testValue, testValue.ToString());

                Output.WriteLine("Verifying equality...");
                objA = new IntegerValue(testValue);
                objB = new IntegerValue(testValue);
                Assert.True(objA.Equals(objB));

                objA = new IntegerValue(testValue);
                objB = objA;
                Assert.True(object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
                Assert.True(object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");
            }

            Output.WriteLine("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new IntegerValue(a); });

            Output.WriteLine("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            long val = default(long);
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value...");
            objA = new IntegerValue();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => ActionOfCompare(a, b));
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

            Output.WriteLine("Testing default value...");
            string expectedText = defaultValue.ToString(CultureInfo.InvariantCulture);
            DecimalValue defaultObj = default(DecimalValue);
            Assert.Null(defaultObj);

            Output.WriteLine("Constructing with Max value and testing...");
            SimpleValueValidTest(new DecimalValue(maxValue), maxValue, maxValue.ToString(CultureInfo.InvariantCulture));

            Output.WriteLine("Constructing with Max value and testing with Clone()...");
            SimpleValueValidTest(new DecimalValue(maxValue).Clone() as DecimalValue, maxValue, maxValue.ToString(CultureInfo.InvariantCulture));

            Output.WriteLine("Set Value with Min value and testing...");
            DecimalValue objA = new DecimalValue();
            objA.Value = minValue;
            SimpleValueValidTest(objA, minValue, minValue.ToString(CultureInfo.InvariantCulture));

            Output.WriteLine("Set InnerText with Min value and testing...");
            DecimalValue objB = new DecimalValue();
            objB.InnerText = minValue.ToString();
            SimpleValueValidTest(objB, minValue, minValue.ToString(CultureInfo.InvariantCulture));

            Output.WriteLine("Implicit Int Operator with Min value and testing...");
            objB = minValue;
            SimpleValueValidTest(objB, minValue, minValue.ToString(CultureInfo.InvariantCulture));

            Output.WriteLine("Explicit decimal conversion with value {0} and testing", validValue);
            objB = DecimalValue.FromDecimal(validValue);
            Assert.True(DecimalValue.ToDecimal(objB) == validValue, "FromDecimal() value doesn't equal to ToDecimal() value!");

            Output.WriteLine("Constructing with another instance with valid value...");
            objA = new DecimalValue(validValue);
            SimpleValueValidTest(new DecimalValue(objA), validValue, validValue.ToString(CultureInfo.InvariantCulture));

            Output.WriteLine("Constructing with special value {0} and testing...", specialValue1);
            SimpleValueValidTest(new DecimalValue(specialValue1), specialValue1, specialValue1.ToString(CultureInfo.InvariantCulture));

            Output.WriteLine("Constructing with special value {0} and testing...", specialValue2);
            SimpleValueValidTest(new DecimalValue(specialValue2), specialValue2, specialValue2.ToString(CultureInfo.InvariantCulture));

            Output.WriteLine("Constructing with special value {0} and testing...", specialValue3);
            SimpleValueValidTest(new DecimalValue(specialValue3), specialValue3, specialValue3.ToString(CultureInfo.InvariantCulture));

            Output.WriteLine("Verifying equality...");
            objA = new DecimalValue(validValue);
            objB = new DecimalValue(validValue);
            Assert.True(objA.Equals(objB));

            objA = new DecimalValue(validValue);
            objB = objA;
            Assert.True(object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Assert.True(object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Output.WriteLine("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new DecimalValue(a); });

            Output.WriteLine("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            decimal val = default(decimal);
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value...");
            objA = new DecimalValue();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => ActionOfCompare(a, b));
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

            Output.WriteLine("Testing default value...");
            string expectedText = defaultValue.ToString();
            SingleValue defaultObj = default(SingleValue);
            Assert.Null(defaultObj);

            Output.WriteLine("Constructing with Max value and testing...");
            SimpleValueValidTest(new SingleValue(maxValue), maxValue, maxValue.ToString("R", CultureInfo.InvariantCulture));

            Output.WriteLine("Constructing with Max value and testing with Clone()...");
            SimpleValueValidTest(new SingleValue(maxValue).Clone() as SingleValue, maxValue, maxValue.ToString("R", CultureInfo.InvariantCulture));

            Output.WriteLine("Set Value with Min value and testing...");
            SingleValue objA = new SingleValue();
            objA.Value = minValue;
            SimpleValueValidTest(objA, minValue, minValue.ToString("R", CultureInfo.InvariantCulture));

            Output.WriteLine("Set InnerText with Min value and testing...");
            SingleValue objB = new SingleValue();
            objB.InnerText = minValue.ToString("R", CultureInfo.InvariantCulture);
            SimpleValueValidTest(objB, minValue, minValue.ToString("R", CultureInfo.InvariantCulture));

            Output.WriteLine("Implicit Int Operator with Min value and testing...");
            objB = minValue;
            SimpleValueValidTest(objB, minValue, minValue.ToString("R", CultureInfo.InvariantCulture));

            Output.WriteLine("Explicit SingleValue conversion with value {0} and testing", validValue);
            objB = SingleValue.FromSingle(validValue);
            Assert.True(SingleValue.ToSingle(objB) == validValue, "SingleValue() value doesn't equal to ToSingle() value!");

            Output.WriteLine("Constructing with another instance with valid value...");
            objA = new SingleValue(validValue);
            SimpleValueValidTest(new SingleValue(objA), validValue, validValue.ToString("R", CultureInfo.InvariantCulture));

            Output.WriteLine("Constructing with special value {0} and testing...", specialEpsilon);
            SimpleValueValidTest(new SingleValue(specialEpsilon), specialEpsilon, specialEpsilon.ToString("R", CultureInfo.InvariantCulture));

            Output.WriteLine("Constructing with special value {0} and testing...", specialPositiveInfinity);
            SimpleValueValidTest(new SingleValue(specialPositiveInfinity), specialPositiveInfinity, PositiveInfinity);

            Output.WriteLine("Constructing with special value {0} and testing...", specialNegativeInfinity);
            SimpleValueValidTest(new SingleValue(specialNegativeInfinity), specialNegativeInfinity, NegativeInfinity);

            Output.WriteLine("Constructing with special value {0} and testing...", specialNaN);
            SimpleValueValidTest(new SingleValue(specialNaN), specialNaN, specialNaN.ToString("R", CultureInfo.InvariantCulture));

            Output.WriteLine("Set InnerText with special value {0} and testing...", specialStringINF);
            objA = new SingleValue();
            objA.InnerText = specialStringINF;
            SimpleValueValidTest(objA, float.PositiveInfinity, specialStringINF);

            Output.WriteLine("Set InnerText with special value {0} and testing...", specialStringNINF);
            objA = new SingleValue();
            objA.InnerText = specialStringNINF;
            SimpleValueValidTest(objA, float.NegativeInfinity, specialStringNINF);

            Output.WriteLine("Set InnerText with special value {0} and testing...", specialStringInfinity);
            objA = new SingleValue();
            objA.InnerText = specialStringInfinity;
            SimpleValueValidTest(objA, float.PositiveInfinity, specialStringInfinity);

            Output.WriteLine("Set InnerText with special value {0} and testing...", specialStringNInfinity);
            objA = new SingleValue();
            objA.InnerText = specialStringNInfinity;
            SimpleValueValidTest(objA, float.NegativeInfinity, specialStringNInfinity);

            Output.WriteLine("Verifying equality...");
            objA = new SingleValue(validValue);
            objB = new SingleValue(validValue);
            Assert.True(objA.Equals(objB));

            objA = new SingleValue(validValue);
            objB = objA;
            Assert.True(object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Assert.True(object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Output.WriteLine("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new SingleValue(a); });

            Output.WriteLine("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            float val = default(float);
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidStringValue);
            objA = new SingleValue();
            objA.InnerText = invalidStringValue;
            InvalidOperation(objA, invalidStringValue, (a, b) => ActionOfCompare(a, b));

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidStringINF);
            objA = new SingleValue();
            objA.InnerText = invalidStringINF;
            InvalidOperation(objA, invalidStringINF, (a, b) => ActionOfCompare(a, b));

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidStringNINF);
            objA = new SingleValue();
            objA.InnerText = invalidStringNINF;
            InvalidOperation(objA, invalidStringNINF, (a, b) => ActionOfCompare(a, b));

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidStringInfinity);
            objA = new SingleValue();
            objA.InnerText = invalidStringInfinity;
            InvalidOperation(objA, invalidStringInfinity, (a, b) => ActionOfCompare(a, b));

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidStringNInfinity);
            objA = new SingleValue();
            objA.InnerText = invalidStringNInfinity;
            InvalidOperation(objA, invalidStringNInfinity, (a, b) => ActionOfCompare(a, b));
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

            Output.WriteLine("Testing default value...");
            string expectedText = defaultValue.ToString(CultureInfo.InvariantCulture);
            DoubleValue defaultObj = default(DoubleValue);
            Assert.Null(defaultObj);

            Output.WriteLine("Constructing with Max value and testing...");
            SimpleValueValidTest(new DoubleValue(maxValue), maxValue, maxValue.ToString("R", CultureInfo.InvariantCulture));

            Output.WriteLine("Constructing with Max value and testing with Clone()...");
            SimpleValueValidTest(new DoubleValue(maxValue).Clone() as DoubleValue, maxValue, maxValue.ToString("R", CultureInfo.InvariantCulture));

            Output.WriteLine("Set Value with Min value and testing...");
            DoubleValue objA = new DoubleValue();
            objA.Value = minValue;
            SimpleValueValidTest(objA, minValue, minValue.ToString("R", CultureInfo.InvariantCulture));

            Output.WriteLine("Set InnerText with Min value and testing...");
            DoubleValue objB = new DoubleValue();
            objB.InnerText = minValue.ToString("R", CultureInfo.InvariantCulture);
            SimpleValueValidTest(objB, minValue, minValue.ToString("R", CultureInfo.InvariantCulture));

            Output.WriteLine("Implicit Int Operator with Min value and testing...");
            objB = minValue;
            SimpleValueValidTest(objB, minValue, minValue.ToString("R", CultureInfo.InvariantCulture));

            Output.WriteLine("Explicit Double conversion with value {0} and testing", validValue);
            objB = DoubleValue.FromDouble(validValue);
            Assert.True(DoubleValue.ToDouble(objB) == validValue, "FromDouble() value doesn't equal to ToDouble() value!");

            Output.WriteLine("Constructing with another instance with valid value...");
            objA = new DoubleValue(validValue);
            SimpleValueValidTest(new DoubleValue(objA), validValue, validValue.ToString("R", CultureInfo.InvariantCulture));

            Output.WriteLine("Constructing with special value {0} and testing...", specialEpsilon);
            SimpleValueValidTest(new DoubleValue(specialEpsilon), specialEpsilon, specialEpsilon.ToString("R", CultureInfo.InvariantCulture));

            Output.WriteLine("Constructing with special value {0} and testing...", specialPositiveInfinity);
            SimpleValueValidTest(new DoubleValue(specialPositiveInfinity), specialPositiveInfinity, positiveInfinity);

            Output.WriteLine("Constructing with special value {0} and testing...", specialNegativeInfinity);
            SimpleValueValidTest(new DoubleValue(specialNegativeInfinity), specialNegativeInfinity, negativeInfinity);

            Output.WriteLine("Constructing with special value {0} and testing...", specialNaN);
            SimpleValueValidTest(new DoubleValue(specialNaN), specialNaN, specialNaN.ToString("R", CultureInfo.InvariantCulture));

            Output.WriteLine("Set InnerText with special value {0} and testing...", specialStringINF);
            objA = new DoubleValue();
            objA.InnerText = specialStringINF;
            SimpleValueValidTest(objA, double.PositiveInfinity, specialStringINF);

            Output.WriteLine("Set InnerText with special value {0} and testing...", specialStringNINF);
            objA = new DoubleValue();
            objA.InnerText = specialStringNINF;
            SimpleValueValidTest(objA, double.NegativeInfinity, specialStringNINF);

            Output.WriteLine("Set InnerText with special value {0} and testing...", specialStringInfinity);
            objA = new DoubleValue();
            objA.InnerText = specialStringInfinity;
            SimpleValueValidTest(objA, double.PositiveInfinity, specialStringInfinity);

            Output.WriteLine("Set InnerText with special value {0} and testing...", specialStringNInfinity);
            objA = new DoubleValue();
            objA.InnerText = specialStringNInfinity;
            SimpleValueValidTest(objA, double.NegativeInfinity, specialStringNInfinity);

            Output.WriteLine("Verifying equality...");
            objA = new DoubleValue(validValue);
            objB = new DoubleValue(validValue);
            Assert.True(objA.Equals(objB));

            objA = new DoubleValue(validValue);
            objB = objA;
            Assert.True(object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Assert.True(object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Output.WriteLine("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new DoubleValue(a); });

            Output.WriteLine("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            double val = default(double);
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidStringValue);
            objA = new DoubleValue();
            objA.InnerText = invalidStringValue;
            InvalidOperation(objA, invalidStringValue, (a, b) => ActionOfCompare(a, b));

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidStringINF);
            objA = new DoubleValue();
            objA.InnerText = invalidStringINF;
            InvalidOperation(objA, invalidStringINF, (a, b) => ActionOfCompare(a, b));

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidStringNINF);
            objA = new DoubleValue();
            objA.InnerText = invalidStringNINF;
            InvalidOperation(objA, invalidStringNINF, (a, b) => ActionOfCompare(a, b));

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidStringInfinity);
            objA = new DoubleValue();
            objA.InnerText = invalidStringInfinity;
            InvalidOperation(objA, invalidStringInfinity, (a, b) => ActionOfCompare(a, b));

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidStringNInfinity);
            objA = new DoubleValue();
            objA.InnerText = invalidStringNInfinity;
            InvalidOperation(objA, invalidStringNInfinity, (a, b) => ActionOfCompare(a, b));
        }

        [Fact]
        public void DateTimeValueTest()
        {
            DateTime defaultValue = default(DateTime);
            DateTime maxValue = DateTime.MaxValue;
            DateTime minValue = DateTime.MinValue;

            // var ratio = (decimal)new Random ().Next(0, 100) / 100;
            var ratio = 0.5M;
            DateTime validValue = new DateTime((long)((ratio * maxValue.Ticks) + ((1 - ratio) * minValue.Ticks)));
            string invalidValue = DateTime.Now.ToString();

            string datatimePattern = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'FFFFFFF";

            Output.WriteLine("Testing default value...");
            string expectedText = defaultValue.ToString();
            DateTimeValue defaultObj = default(DateTimeValue);
            Assert.Null(defaultObj);

            Output.WriteLine("Constructing with Max value and testing...");
            SimpleValueValidTest(new DateTimeValue(maxValue), maxValue, maxValue.ToString(datatimePattern));

            Output.WriteLine("Constructing with Max value and testing with Clone()...");
            SimpleValueValidTest(new DateTimeValue(maxValue).Clone() as DateTimeValue, maxValue, maxValue.ToString(datatimePattern));

            Output.WriteLine("Set Value with Min value and testing...");
            DateTimeValue objA = new DateTimeValue();
            objA.Value = minValue;
            SimpleValueValidTest(objA, minValue, minValue.ToString(datatimePattern));

            Output.WriteLine("Set InnerText with Min value and testing...");
            DateTimeValue objB = new DateTimeValue();
            objB.InnerText = minValue.ToString(datatimePattern);
            SimpleValueValidTest(objB, minValue, minValue.ToString(datatimePattern));

            Output.WriteLine("Implicit Int Operator with Min value and testing...");
            objB = minValue;
            SimpleValueValidTest(objB, minValue, minValue.ToString(datatimePattern));

            Output.WriteLine("Explicit conversion with value {0} and testing", validValue);
            objB = DateTimeValue.FromDateTime(validValue);
            Assert.True(DateTimeValue.ToDateTime(objB) == validValue, "FromDateTime() value doesn't equal to ToDateTime() value!");

            Output.WriteLine("Constructing with another instance with valid value...");
            objA = new DateTimeValue(validValue);
            SimpleValueValidTest(new DateTimeValue(objA), validValue, validValue.ToString(datatimePattern));

            Output.WriteLine("Verifying equality...");
            objA = new DateTimeValue(validValue);
            objB = new DateTimeValue(validValue);
            Assert.True(objA.Equals(objB));

            objA = new DateTimeValue(validValue);
            objB = objA;
            Assert.True(object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Assert.True(object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Output.WriteLine("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new DateTimeValue(a); });

            Output.WriteLine("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            DateTime val = default(DateTime);
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value...");
            objA = new DateTimeValue();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => ActionOfCompare(a, b));
        }

        #region Common Functions

        private void InvalidOperation<T>(OpenXmlSimpleValue<T> a, OpenXmlSimpleValue<T> b,
            Action<OpenXmlSimpleValue<T>, OpenXmlSimpleValue<T>> action)
            where T : struct
        {
            try
            {
                action(a, b);
                Assert.Fail("Action executed without any exception.");
            }
            catch (Exception e)
            {
                Output.WriteLine($"Warning: {e.ToString()}");
                Output.WriteLine("Expected {0} Caught!", e.GetType().Name);
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
                Assert.Fail("Action executed without any exception.");
            }
            catch (Exception e)
            {
                Output.WriteLine($"Warning: {e.ToString()}");
                Output.WriteLine("Expected {0} Caught!", e.GetType().Name);
            }
        }

        private void ActionOfCompare<T>(OpenXmlSimpleValue<T> a, OpenXmlSimpleValue<T> b)
            where T : struct
        {
            Output.WriteLine(string.Format("ObjectA {0} value.", a.HasValue ? "HAS" : "has NO"));
            Output.WriteLine(string.Format("ObjectB {0} value.", b.HasValue ? "HAS" : "has NO"));
            Assert.True(b.Equals(a.InnerText), "Instance constructed with invalid value does NOT keep the text.");
            Assert.True(b.Equals(a.Value), "Instance constructed with invalid value CAN parse without error!");
        }

        private void ActionOfCompare<T1, T2>(OpenXmlSimpleValue<T1> a, T2 b)
            where T1 : struct
        {
            Output.WriteLine(string.Format("ObjectA {0} value.", a.HasValue ? "HAS" : "has NO"));
            Assert.True(b.Equals(a.InnerText), "Instance constructed with invalid value does NOT keep the text.");
            Assert.True(b.Equals(a.Value), "Instance constructed with invalid value CAN parse without error!");
        }

        private void SimpleValueValidTest<T>(OpenXmlSimpleValue<T> oxObj, T expectedValue, string expectedText)
            where T : struct
        {
            Output.WriteLine("Entering Generic Test Method...");

            string stringValue = oxObj.InnerText;
            Assert.Equal(expectedText, stringValue);

            stringValue = oxObj;
            Assert.Equal(expectedText, stringValue);

            stringValue = oxObj.ToString();
            Assert.Equal(expectedText, stringValue);

            Assert.True(oxObj.HasValue, string.Format("{0} with valid value has NO value.", oxObj.GetType().Name));
            Assert.True(oxObj.Value.Equals(expectedValue), string.Format("Property Value {0} does NOT equal to expected {1}.", oxObj.Value, expectedValue));

            T val = oxObj;
            Assert.True(val.Equals(expectedValue), string.Format("{0} operator result {1} does NOT equal to expected {2}.", typeof(T).Name, val, expectedValue));

            val = oxObj;
            Assert.True(val.Equals(expectedValue), string.Format("{0} operator result {1} does NOT equal to expected {2}.", typeof(OpenXmlSimpleValue<T>).Name, val, expectedValue));

            Output.WriteLine("Leaving Generic Test Method...");
        }

        private void SimpleValueValidTestNonGeneric(Int32Value oxObj, int expectedValue, string expectedText)
        {
            Output.WriteLine("Entering Non-Generic Test Method...");

            string stringValue = oxObj.InnerText;
            Assert.Equal(expectedText, stringValue);

            stringValue = oxObj.ToString();
            Assert.Equal(expectedText, stringValue);

            stringValue = oxObj;
            Assert.Equal(expectedText, stringValue);

            Assert.True(oxObj.HasValue, "Int32Value with valid value has NO value.");
            Assert.Equal(expectedValue, oxObj.Value);

            int val = oxObj;
            Assert.Equal(expectedValue, val);

            val = oxObj as OpenXmlSimpleValue<int>;
            Assert.Equal(expectedValue, val);

            Output.WriteLine("Leaving Non-Generic Test Method...");
        }
        #endregion Common Functions
    }
}
