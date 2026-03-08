// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    // OpenXmlSimpleType
    //   DocumentFormat.OpenXml.EnumValue<T>
    //   DocumentFormat.OpenXml.ListValue<T>
    //   DocumentFormat.OpenXml.StringValue
    //   DocumentFormat.OpenXml.Base64BinaryValue
    //   DocumentFormat.OpenXml.HexBinaryValue
    //   DocumentFormat.OpenXml.OpenXmlSimpleValue<T>
    public class OpenXmlSimpleTypeTest : OpenXmlDomTestBase
    {
        public OpenXmlSimpleTypeTest(ITestOutputHelper output)
            : base(output)
        {
        }

        #region EnumValue

        [Fact]
        public void EnumValueTest()
        {
            DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault tablecellmar = new DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault();
            tablecellmar.AppendChild(new DocumentFormat.OpenXml.Wordprocessing.LeftMargin());
            var leftmar = tablecellmar.TableCellLeftMargin;

            HeaderFooterValues defaultValue = default(HeaderFooterValues);
            HeaderFooterValues validValue = HeaderFooterValues.Even;
            HeaderFooterValues validValue1 = HeaderFooterValues.Default;
            HeaderFooterValues validValue2 = HeaderFooterValues.First;
            HeaderFooterValues validValue0i = default;

            string validString0 = "even";
            string validString1 = "default";
            string validString2 = "first";

            string invalidNum0 = "0";
            string invalidNum1 = "1";
            string invalidNum2 = "2";
            string invalidNum3 = "3";
            string invalidNum10 = "10";
            string invalidString0 = validString0.ToUpper();
            string invalidString1 = validString1 + "," + validString0;
            string invalidString2 = "undefined";
            HeaderFooterValues invalidValue3i = new HeaderFooterValues("invalid");

            Output.WriteLine("Testing default value...");
            string expectedText = defaultValue.ToString();
            EnumValue<HeaderFooterValues> defaultObj = default(EnumValue<HeaderFooterValues>);
            Assert.Null(defaultObj);

            Output.WriteLine("Constructing with value {0} and testing...", validValue);
            SimpleValueValidTest(new EnumValue<HeaderFooterValues>(validValue), validValue, validString0);

            Output.WriteLine("Constructing with value {0} and testing...", validValue0i);
            SimpleValueValidTest(new EnumValue<HeaderFooterValues>(validValue0i), validValue0i, validString0);

            Output.WriteLine("Constructing with value {0} and testing with Clone()...", validValue1);
            var clone = new EnumValue<HeaderFooterValues>(validValue1).Clone();
            SimpleValueValidTest(clone as EnumValue<HeaderFooterValues>, validValue1, validString1);  // O14: 253869

            Output.WriteLine("Set Value with value {0} and testing...", validValue2);
            EnumValue<HeaderFooterValues> objA = new EnumValue<HeaderFooterValues>();
            objA.Value = validValue2;
            SimpleValueValidTest(objA, validValue2, validString2);

            Output.WriteLine("Set InnerText with value {0} and testing...", validString0);
            EnumValue<HeaderFooterValues> objB = new EnumValue<HeaderFooterValues>();
            objB.InnerText = validString0;
            SimpleValueValidTest(objB, validValue, validString0);

            Output.WriteLine("Set InnerText with value {0} and testing...", validString1);
            objB = new EnumValue<HeaderFooterValues>();
            objB.InnerText = validString1;
            SimpleValueValidTest(objB, validValue1, validString1);

            Output.WriteLine("Set InnerText with value {0} and testing...", validString2);
            objB = new EnumValue<HeaderFooterValues>();
            objB.InnerText = validString2.ToString();
            SimpleValueValidTest(objB, validValue2, validString2.ToString());

            Output.WriteLine("Implicit T Operator with value {0} and testing...", validValue);
            objB = validValue;
            SimpleValueValidTest(objB, validValue, validString0);

            Output.WriteLine("Constructing with another instance with valid value {0}...", validValue);
            objA = new EnumValue<HeaderFooterValues>(validValue);
            SimpleValueValidTest(new EnumValue<HeaderFooterValues>(objA), validValue, validString0); // O14: 253871

            Output.WriteLine("Verifying equality...");
            objA = new EnumValue<HeaderFooterValues>(validValue);
            objB = new EnumValue<HeaderFooterValues>(validValue);
            Assert.True(objA.Equals(objB));

            objA = new EnumValue<HeaderFooterValues>(validValue);
            objB = objA;
            Assert.True(object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Assert.True(object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Output.WriteLine("ErrorHandling: Constructing with invalid value {0} and testing...", invalidValue3i);
            try
            {
                objA = new EnumValue<HeaderFooterValues>(invalidValue3i);
                InvalidOperation(objA, invalidValue3i, (a, expectedValue) => ActionOfCompare(a, expectedValue));  // O14: 253876
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Output.WriteLine("Expected exception caught when constructing an EunumValue with invalid value.");
            }

            Output.WriteLine("ErrorHandling: Assigning Value with invalid value {0} and testing...", invalidValue3i);
            try
            {
                objA = new EnumValue<HeaderFooterValues>();
                objA.Value = invalidValue3i;
                InvalidOperation(objA, invalidValue3i, (a, expectedValue) => ActionOfCompare(a, expectedValue));  // O14: 253876
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Output.WriteLine("Expected exception caught when assigning Value with invalid value.");
            }

            Output.WriteLine("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, expectedValue) => { expectedValue = new EnumValue<HeaderFooterValues>(a); });

            Output.WriteLine("ErrorHandling: Implicit string operator on null reference...");
            objA = null;
            HeaderFooterValues val = default(HeaderFooterValues);
            InvalidOperation(objA, val, (a, expectedValue) => { expectedValue = a; });

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidNum0);
            objA = new EnumValue<HeaderFooterValues>();
            objA.InnerText = invalidNum0;
            InvalidOperation(objA, invalidNum0, (a, expectedValue) => ActionOfCompare(a, expectedValue));

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidNum1);
            objA = new EnumValue<HeaderFooterValues>();
            objA.InnerText = invalidNum1;
            InvalidOperation(objA, invalidNum1, (a, expectedValue) => ActionOfCompare(a, expectedValue));

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidNum2);
            objA = new EnumValue<HeaderFooterValues>();
            objA.InnerText = invalidNum2;
            InvalidOperation(objA, invalidNum2, (a, expectedValue) => ActionOfCompare(a, expectedValue));

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidNum3);
            objA = new EnumValue<HeaderFooterValues>();
            objA.InnerText = invalidNum3;
            InvalidOperation(objA, invalidNum3, (a, expectedValue) => ActionOfCompare(a, expectedValue));

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidNum10);
            objA = new EnumValue<HeaderFooterValues>();
            objA.InnerText = invalidNum10;
            InvalidOperation(objA, invalidNum10, (a, expectedValue) => ActionOfCompare(a, expectedValue));

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidString0);
            objA = new EnumValue<HeaderFooterValues>();
            objA.InnerText = invalidString0;
            InvalidOperation(objA, invalidString0, (a, expectedValue) => ActionOfCompare(a, expectedValue));

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidString1);
            objA = new EnumValue<HeaderFooterValues>();
            objA.InnerText = invalidString1;
            InvalidOperation(objA, invalidString1, (a, expectedValue) => ActionOfCompare(a, expectedValue));

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidString2);
            objA = new EnumValue<HeaderFooterValues>();
            objA.InnerText = invalidString2;
            InvalidOperation(objA, invalidString2, (a, expectedValue) => ActionOfCompare(a, expectedValue));
        }

        private void InvalidOperation<T1, T2>(EnumValue<T1> a, T2 expectedValue, Action<EnumValue<T1>, T2> action)
            where T1 : struct, IEnumValue, IEnumValueFactory<T1>
        {
            try
            {
                action(a, expectedValue);
                Assert.Fail("Action executed without any exception.");
            }
            catch (Exception e)
            {
                Output.WriteLine($"Warning: {e.ToString()}");
                Output.WriteLine("Expected {0} Caught!", e.GetType().Name);
            }
        }

        private void ActionOfCompare<T1, T2>(EnumValue<T1> a, T2 expectedValue)
            where T1 : struct, IEnumValue, IEnumValueFactory<T1>
        {
            Output.WriteLine(string.Format("ObjectA {0} value.", a.HasValue ? "HAS" : "has NO"));
            Assert.True(expectedValue.Equals(a.InnerText), "Instance constructed with invalid value does NOT keep the text.");
            Assert.True(expectedValue.Equals(a.Value), "Instance constructed with invalid value CAN parse without error!");
        }

        private void SimpleValueValidTest<T>(EnumValue<T> oxObj, T expectedValue, string expectedText)
            where T : struct, IEnumValue, IEnumValueFactory<T>
        {
            Output.WriteLine("Entering Non-Generic Test Method...");

            string stringValue = oxObj.InnerText;
            Assert.NotNull(stringValue);
            Assert.Equal(expectedText, stringValue);

            stringValue = oxObj;
            Assert.Equal(expectedText, stringValue);

            stringValue = oxObj.ToString();
            Assert.Equal(expectedText, stringValue);

            Assert.True(oxObj.HasValue, string.Format("{0} with valid value has NO value.", oxObj.GetType().Name));
            Assert.True(oxObj.Value.Equals(expectedValue), string.Format("Property Value {0} does NOT equal to expected {1}.", oxObj.Value, expectedValue));

            T val = oxObj;
            Assert.True(val.Equals(expectedValue), string.Format("{0} operator result {1} does NOT equal to expected {2}.", typeof(T).Name, val, expectedValue));

            Output.WriteLine("Leaving Non-Generic Test Method...");
        }

        #endregion EnumValue

        #region ListValue
        [Fact]
        public void ListValueTest()
        {
            // String, Int32, UInt32, Boolean used as T in OpenXml SDK
            string defaultValue = default(string);
            string validString = "Normal String Content";
            IEnumerable<StringValue> validValue = validString.Split().Select(s => new StringValue(s));
            string specialString = validString + " " + string.Empty + " " + validString;
            List<StringValue> specialValue = new List<StringValue>((validValue.Count() * 2) + 1);
            specialValue.AddRange(validValue);
            specialValue.Add(new StringValue(string.Empty));
            specialValue.AddRange(validValue);

            Output.WriteLine("Testing default value...");
            string expectedText = defaultValue;
            ListValue<StringValue> defaultObj = default(ListValue<StringValue>);
            Assert.Null(defaultObj);

            Output.WriteLine("Constructing with value {0} and testing...", validString);
            SimpleValueValidTest1(new ListValue<StringValue>(validValue), validValue, validString);

            Output.WriteLine("Constructing with value {0} and testing with Clone()...", validString);
            SimpleValueValidTest1(new ListValue<StringValue>(validValue).Clone() as ListValue<StringValue>, validValue, validString);

            Output.WriteLine("Since property Items is read only, no need to set Items.");

            Output.WriteLine("Set InnerText with value {0} and testing...", validValue);
            ListValue<StringValue> objB = new ListValue<StringValue>();
            objB.InnerText = validString;
            SimpleValueValidTest1(objB, validValue, validString);

            Output.WriteLine("Constructing with another instance with valid value {0}...", validString);
            ListValue<StringValue> objA = new ListValue<StringValue>(validValue);
            SimpleValueValidTest1(new ListValue<StringValue>(objA), validValue, validString);

            Output.WriteLine("Constructing with special value {0} and testing...", specialString);
            SimpleValueValidTest1(new ListValue<StringValue>(specialValue), specialValue, specialString);

            Output.WriteLine("Verifying reference type behavior...");
            objA = new ListValue<StringValue>(validValue);
            objB = new ListValue<StringValue>(validValue);
            Assert.False(object.Equals(objA, objB), "Two instances with same value but constructed separated are Equal.");
            objA = new ListValue<StringValue>(validValue);
            objB = objA;
            Assert.True(object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Assert.True(object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Output.WriteLine("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new ListValue<StringValue>(a); });
        }

        private void InvalidOperation<T1, T2>(ListValue<T1> a, T2 b, Action<ListValue<T1>, T2> action)
            where T1 : OpenXmlSimpleType, new()
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

        private void InvalidOperation<T1, T2, T3>(ListValue<T1> a, T2 b, T3 c, Action<ListValue<T1>, T2, T3> action)
            where T1 : OpenXmlSimpleType, new()
        {
            try
            {
                action(a, b, c);
                Assert.Fail("Action executed without any exception.");
            }
            catch (Exception e)
            {
                Output.WriteLine($"Warning: {e.ToString()}");
                Output.WriteLine("Expected {0} Caught!", e.GetType().Name);
            }
        }

        private void ActionOfCompare1<T1>(ListValue<T1> a, IEnumerable<T1> expectedValue, string expectedText)
            where T1 : OpenXmlSimpleType, new()
        {
            Output.WriteLine(string.Format("ObjectA {0} value.", a.HasValue ? "HAS" : "has NO"));
            Assert.True(expectedText.Equals(a.InnerText), "Instance constructed with invalid value does NOT keep the text.");
            Assert.True(IsSequenceEqual(a.Items, expectedValue), "Instance constructed with invalid value CAN parse without error!");
        }

        private void SimpleValueValidTest1<T>(ListValue<T> oxObj, IEnumerable<T> expectedValue, string expectedText)
            where T : OpenXmlSimpleType, new()
        {
            Output.WriteLine("Entering Non-Generic Test Method...");

            string stringValue = oxObj.InnerText;
            Assert.Equal(expectedText, stringValue);

            stringValue = oxObj;
            Assert.Equal(expectedText, stringValue);

            stringValue = oxObj.ToString();
            Assert.Equal(expectedText, stringValue);

            Assert.True(oxObj.HasValue, string.Format("{0} with valid value has NO value.", oxObj.GetType().Name));
            Assert.True(IsSequenceEqual(oxObj.Items, expectedValue), string.Format("Property Items {0} does NOT equal to expected {1}.", oxObj.Items, expectedValue));

            Output.WriteLine("Leaving Non-Generic Test Method...");
        }

        private bool IsSequenceEqual<T1>(ICollection<T1> items, IEnumerable<T1> listB)
            where T1 : OpenXmlSimpleType, new()
        {
            if (items is null)
            {
                throw new ArgumentNullException(nameof(items));
            }

            if (listB is null)
            {
                throw new ArgumentNullException(nameof(listB));
            }

            return items.Select(i => i.ToString()).SequenceEqual(listB.Select(t => t.ToString()));
        }

        #endregion ListValue

        #region StringValue
        [Fact]
        public void StringValueTest()
        {
            string defaultValue = default(string);
            string validValue = "Normal String Content";
            string specialString = @"</pPr>";
            string specialString2 = @"</w:pPr>";
            string specialString3 = string.Empty;

            Output.WriteLine("Testing default value...");
            string expectedText = defaultValue;
            StringValue defaultObj = default(StringValue);
            Assert.Null(defaultObj);

            Output.WriteLine("Constructing with value {0} and testing...", validValue);
            SimpleValueValidTest1(new StringValue(validValue), validValue, validValue.ToString());

            Output.WriteLine("Constructing with value {0} and testing with Clone()...", validValue);
            SimpleValueValidTest1(new StringValue(validValue).Clone() as StringValue, validValue, validValue.ToString());

            Output.WriteLine("Set Value with value {0} and testing...", validValue);
            StringValue objA = new StringValue();
            objA.Value = validValue;
            SimpleValueValidTest1(objA, validValue, validValue.ToString());

            Output.WriteLine("Set InnerText with value {0} and testing...", validValue);
            StringValue objB = new StringValue();
            objB.InnerText = validValue.ToString();
            SimpleValueValidTest1(objB, validValue, validValue.ToString());

            Output.WriteLine("Constructing with value {0} and testing...", specialString2);
            SimpleValueValidTest1(new StringValue(specialString2), specialString2, specialString2.ToString());

            Output.WriteLine("Set InnerText with value {0} and testing...", specialString);
            objB = new StringValue();
            objB.InnerText = specialString.ToString();
            SimpleValueValidTest1(objB, specialString, specialString.ToString());

            Output.WriteLine("Set InnerText with value {0} and testing...", specialString3);
            objB = new StringValue();
            objB.InnerText = specialString3.ToString();
            SimpleValueValidTest1(objB, specialString3, specialString3.ToString());

            Output.WriteLine("Implicit String Operator with value {0} and testing...", validValue);
            objB = validValue;
            SimpleValueValidTest1(objB, validValue, validValue.ToString());

            Output.WriteLine("Constructing with another instance with valid value {0}...", validValue);
            objA = new StringValue(validValue);
            SimpleValueValidTest1(new StringValue(objA), validValue, validValue.ToString());

            Output.WriteLine("Verifying equality...");
            objA = new StringValue(validValue);
            objB = new StringValue(validValue);
            Assert.True(objA.Equals(objB));

            objA = new StringValue(validValue);
            objB = objA;
            Assert.True(object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Assert.True(object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Output.WriteLine("ErrorHandling: Implicit string operator on null reference...");
            objA = null;
            string val = string.Empty;
            val = objA;
            if (val is null)
            {
                Output.WriteLine("implicit string operator on null reference returned null, as expected.");
            }
            else
            {
                Assert.Fail("Implicit string operator on null reference return NON-null.");
            }
        }

        private void InvalidOperation<T>(
            StringValue a, T expectedValue,
            Action<StringValue, T> action)
        {
            try
            {
                action(a, expectedValue);
                Assert.Fail("Action executed without any exception.");
            }
            catch (Exception e)
            {
                Output.WriteLine($"Warning: {e.ToString()}");
                Output.WriteLine("Expected {0} Caught!", e.GetType().Name);
            }
        }

        private void ActionOfCompare1<T>(StringValue a, T expectedValue)
        {
            Output.WriteLine(string.Format("ObjectA {0} value.", a.HasValue ? "HAS" : "has NO"));
            Assert.True(expectedValue.Equals(a.InnerText), "Instance constructed with invalid value does NOT keep the text.");
            Assert.True(expectedValue.Equals(a.Value), "Instance constructed with invalid value CAN parse without error!");
        }

        private void SimpleValueValidTest1(StringValue oxObj, string expectedValue, string expectedText)
        {
            Output.WriteLine("Entering Non-Generic Test Method...");

            string stringValue = oxObj.InnerText;
            Assert.Equal(expectedText, stringValue);

            stringValue = oxObj;
            Assert.Equal(expectedText, stringValue);

            stringValue = oxObj.ToString();
            Assert.Equal(expectedText, stringValue);

            Assert.True(oxObj.HasValue, string.Format("{0} with valid value has NO value.", oxObj.GetType().Name));
            Assert.True(oxObj.Value.Equals(expectedValue), string.Format("Property Value {0} does NOT equal to expected {1}.", oxObj.Value, expectedValue));

            string val = oxObj as OpenXmlSimpleType;
            Assert.True(val.Equals(expectedValue), string.Format("{0} operator result {1} does NOT equal to expected {2}.", typeof(OpenXmlSimpleType).Name, val, expectedValue));

            Output.WriteLine("Leaving Non-Generic Test Method...");
        }
        #endregion StringValue

        #region Base64BinaryValue
        [Fact]
        public void Base64BinaryValueTest()
        {
            string defaultValue = default(string);
            string validValue = "Normal String Content";
            string specialString = @"</pPr>";
            string specialString2 = @"</w:pPr>";
            string specialString3 = string.Empty;

            Output.WriteLine("Testing default value...");
            string expectedText = defaultValue;
            Base64BinaryValue defaultObj = default(Base64BinaryValue);
            Assert.Null(defaultObj);

            Output.WriteLine("Constructing with value {0} and testing...", validValue);
            SimpleValueValidTest1(new Base64BinaryValue(validValue), validValue, validValue.ToString());

            Output.WriteLine("Constructing with value {0} and testing with Clone()...", validValue);
            SimpleValueValidTest1(new Base64BinaryValue(validValue).Clone() as Base64BinaryValue, validValue, validValue.ToString());

            Output.WriteLine("Set Value with value {0} and testing...", validValue);
            Base64BinaryValue objA = new Base64BinaryValue();
            objA.Value = validValue;
            SimpleValueValidTest1(objA, validValue, validValue.ToString());

            Output.WriteLine("Set InnerText with value {0} and testing...", validValue);
            Base64BinaryValue objB = new Base64BinaryValue();
            objB.InnerText = validValue.ToString();
            SimpleValueValidTest1(objB, validValue, validValue.ToString());

            Output.WriteLine("Constructing with value {0} and testing...", specialString2);
            SimpleValueValidTest1(new Base64BinaryValue(specialString2), specialString2, specialString2.ToString());

            Output.WriteLine("Set InnerText with value {0} and testing...", specialString);
            objB = new Base64BinaryValue();
            objB.InnerText = specialString.ToString();
            SimpleValueValidTest1(objB, specialString, specialString.ToString());

            Output.WriteLine("Set InnerText with value {0} and testing...", specialString3);
            objB = new Base64BinaryValue();
            objB.InnerText = specialString3.ToString();
            SimpleValueValidTest1(objB, specialString3, specialString3.ToString());

            Output.WriteLine("Implicit String Operator with value {0} and testing...", validValue);
            objB = validValue;
            SimpleValueValidTest1(objB, validValue, validValue.ToString());

            Output.WriteLine("Explicit string conversion with value {0} and testing", validValue);
            objB = Base64BinaryValue.FromString(validValue);
            Assert.True(Base64BinaryValue.ToString(objB) == validValue, "FromXX() value doesn't equal to ToXX() value!");

            Output.WriteLine("Constructing with another instance with valid value {0}...", validValue);
            objA = new Base64BinaryValue(validValue);
            SimpleValueValidTest1(new Base64BinaryValue(objA), validValue, validValue.ToString());

            Output.WriteLine("Verifying equality...");
            objA = new Base64BinaryValue(validValue);
            objB = new Base64BinaryValue(validValue);
            Assert.True(objA.Equals(objB));

            objA = new Base64BinaryValue(validValue);
            objB = objA;
            Assert.True(object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Assert.True(object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Output.WriteLine("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, expectedValue) => { expectedValue = new Base64BinaryValue(a); });
        }

        private void InvalidOperation<T>(
            Base64BinaryValue a, T expectedValue,
            Action<Base64BinaryValue, T> action)
        {
            try
            {
                action(a, expectedValue);
                Assert.Fail("Action executed without any exception.");
            }
            catch (Exception e)
            {
                Output.WriteLine($"Warning: {e.ToString()}");
                Output.WriteLine("Expected {0} Caught!", e.GetType().Name);
            }
        }

        private void ActionOfCompare1<T>(Base64BinaryValue a, T expectedValue)
        {
            Output.WriteLine(string.Format("ObjectA {0} value.", a.HasValue ? "HAS" : "has NO"));
            Assert.True(expectedValue.Equals(a.InnerText), "Instance constructed with invalid value does NOT keep the text.");
            Assert.True(expectedValue.Equals(a.Value), "Instance constructed with invalid value CAN parse without error!");
        }

        private void SimpleValueValidTest1(Base64BinaryValue oxObj, string expectedValue, string expectedText)
        {
            Output.WriteLine("Entering Non-Generic Test Method...");

            string stringValue = oxObj.InnerText;
            Assert.Equal(expectedText, stringValue);

            stringValue = oxObj;
            Assert.Equal(expectedText, stringValue);

            stringValue = oxObj.ToString();
            Assert.Equal(expectedText, stringValue);

            Assert.True(oxObj.HasValue, string.Format("{0} with valid value has NO value.", oxObj.GetType().Name));
            Assert.True(oxObj.Value.Equals(expectedValue), string.Format("Property Value {0} does NOT equal to expected {1}.", oxObj.Value, expectedValue));

            string val = oxObj as OpenXmlSimpleType;
            Assert.True(val.Equals(expectedValue), string.Format("{0} operator result {1} does NOT equal to expected {2}.", typeof(OpenXmlSimpleType).Name, val, expectedValue));

            Output.WriteLine("Leaving Non-Generic Test Method...");
        }
        #endregion Base64BinaryValue

        #region HexBinaryValue
        [Fact]
        public void HexBinaryValueTest()
        {
            string defaultValue = default(string);
            string validValue = "Normal String Content";
            string specialString = @"</pPr>";
            string specialString2 = @"</w:pPr>";
            string specialString3 = string.Empty;

            Output.WriteLine("Testing default value...");
            string expectedText = defaultValue;
            HexBinaryValue defaultObj = default(HexBinaryValue);
            Assert.Null(defaultObj);

            Output.WriteLine("Constructing with value {0} and testing...", validValue);
            SimpleValueValidTest(new HexBinaryValue(validValue), validValue, validValue.ToString());

            Output.WriteLine("Constructing with value {0} and testing with Clone()...", validValue);
            SimpleValueValidTest(new HexBinaryValue(validValue).Clone() as HexBinaryValue, validValue, validValue.ToString());

            Output.WriteLine("Set Value with value {0} and testing...", validValue);
            HexBinaryValue objA = new HexBinaryValue();
            objA.Value = validValue;
            SimpleValueValidTest(objA, validValue, validValue.ToString());

            Output.WriteLine("Set InnerText with value {0} and testing...", validValue);
            HexBinaryValue objB = new HexBinaryValue();
            objB.InnerText = validValue.ToString();
            SimpleValueValidTest(objB, validValue, validValue.ToString());

            Output.WriteLine("Constructing with value {0} and testing...", specialString2);
            SimpleValueValidTest(new HexBinaryValue(specialString2), specialString2, specialString2.ToString());

            Output.WriteLine("Set InnerText with value {0} and testing...", specialString);
            objB = new HexBinaryValue();
            objB.InnerText = specialString.ToString();
            SimpleValueValidTest(objB, specialString, specialString.ToString());

            Output.WriteLine("Set InnerText with value {0} and testing...", specialString3);
            objB = new HexBinaryValue();
            objB.InnerText = specialString3.ToString();
            SimpleValueValidTest(objB, specialString3, specialString3.ToString());

            Output.WriteLine("Implicit String Operator with value {0} and testing...", validValue);
            objB = validValue;
            SimpleValueValidTest(objB, validValue, validValue.ToString());

            Output.WriteLine("Explicit string conversion with value {0} and testing", validValue);
            objB = HexBinaryValue.FromString(validValue);
            Assert.True(HexBinaryValue.ToString(objB) == validValue, "FromXX() value doesn't equal to ToXX() value!");

            Output.WriteLine("Constructing with another instance with valid value {0}...", validValue);
            objA = new HexBinaryValue(validValue);
            SimpleValueValidTest(new HexBinaryValue(objA), validValue, validValue.ToString());

            Output.WriteLine("Verifying equality...");
            objA = new HexBinaryValue(validValue);
            objB = new HexBinaryValue(validValue);
            Assert.True(objA.Equals(objB));

            objA = new HexBinaryValue(validValue);
            objB = objA;
            Assert.True(object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Assert.True(object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Output.WriteLine("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, expectedValue) => { expectedValue = new HexBinaryValue(a); });
        }

        private void InvalidOperation<T>(
            HexBinaryValue a, T expectedValue,
            Action<HexBinaryValue, T> action)
        {
            try
            {
                action(a, expectedValue);
                Assert.Fail("Action executed without any exception.");
            }
            catch (Exception e)
            {
                Output.WriteLine($"Warning: {e.ToString()}");
                Output.WriteLine("Expected {0} Caught!", e.GetType().Name);
            }
        }

        private void SimpleValueValidTest(HexBinaryValue oxObj, string expectedValue, string expectedText)
        {
            Output.WriteLine("Entering Non-Generic Test Method...");

            string stringValue = oxObj.InnerText;
            Assert.Equal(expectedText, stringValue);

            stringValue = oxObj;
            Assert.Equal(expectedText, stringValue);

            stringValue = oxObj.ToString();
            Assert.Equal(expectedText, stringValue);

            Assert.True(oxObj.HasValue, string.Format("{0} with valid value has NO value.", oxObj.GetType().Name));
            Assert.True(oxObj.Value.Equals(expectedValue), string.Format("Property Value {0} does NOT equal to expected {1}.", oxObj.Value, expectedValue));

            string val = oxObj as OpenXmlSimpleType;
            Assert.True(val.Equals(expectedValue), string.Format("{0} operator result {1} does NOT equal to expected {2}.", typeof(OpenXmlSimpleType).Name, val, expectedValue));

            Output.WriteLine("Leaving Non-Generic Test Method...");
        }
        #endregion HexBinaryValue

        #region OnOffValue
        [Fact]
        public void OnOffValueTest()
        {
            bool maxValue = true;
            bool minValue = false;
            bool validValue = true;
            string validValueTrue = "true";
            string validValueFalse = "false";
            string validValueOn = "on";
            string validValueOff = "off";
            string validValue0 = "0";
            string validValue1 = "1";
            string invalidValueTrue = "True";
            string invalidValueFalse = "False";
            string invalidValue2 = "Invalid 0.1 String!";
            string invalidValue3 = "Invalid 1.0 String!";
            string invalidValue = "Invalid String!";

            Output.WriteLine("Constructing with Max value and testing...");
            SimpleTypeValueValidTest(new OnOffValue(maxValue), maxValue, maxValue == true ? validValueTrue : validValueFalse);

            Output.WriteLine("Constructing with Max value and testing with Clone()....");
            SimpleTypeValueValidTest(new OnOffValue(maxValue).Clone() as OnOffValue, maxValue, maxValue == true ? validValueTrue : validValueFalse);

            Output.WriteLine("Set Value with Min value and testing....");
            OnOffValue objA = new OnOffValue();
            objA.Value = minValue;
            SimpleTypeValueValidTest(objA, minValue, minValue == true ? validValueTrue : validValueFalse);

            Output.WriteLine("Set InnerText with Min value and testing...");
            OnOffValue objB = new OnOffValue();
            objB.InnerText = minValue.ToString().ToLower(); // True -> true, False -> false
            SimpleTypeValueValidTest(objB, minValue, minValue.ToString().ToLower());

            Output.WriteLine("Implicit Int Operator with Min value and testing...");
            objB = minValue;
            SimpleTypeValueValidTest(objB, minValue, minValue == true ? validValueTrue : validValueFalse);

            Output.WriteLine("Explicit OnOffValue conversion with value {0} and testing", validValue);
            objB = OnOffValue.FromBoolean(validValue);
            Assert.True(OnOffValue.ToBoolean(objB) == validValue, "FromBoolean() value doesn't equal to ToBoolean() value!");

            Output.WriteLine("Constructing with another instance with valid value...");
            objA = new OnOffValue(validValue);
            SimpleTypeValueValidTest(new OnOffValue(objA), validValue, validValue == true ? validValueTrue : validValueFalse);

            Output.WriteLine("Verifying equality...");
            objA = new OnOffValue(validValue);
            objB = new OnOffValue(validValue);
            Assert.True(objA.Equals(objB));

            objA = new OnOffValue(validValue);
            objB = objA;
            Assert.True(object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Assert.True(object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Output.WriteLine("Setting InnerText as special value and testing...");
            objA = new OnOffValue();
            objA.InnerText = validValue0;
            SimpleTypeValueValidTest(objA, false, validValue0);
            objA.InnerText = validValue1;
            SimpleTypeValueValidTest(objA, true, validValue1);
            objA.InnerText = validValueFalse;
            SimpleTypeValueValidTest(objA, false, validValueFalse);
            objA.InnerText = validValueTrue;
            SimpleTypeValueValidTest(objA, true, validValueTrue);
            objA.InnerText = validValueOn;
            SimpleTypeValueValidTest(objA, true, validValueOn);
            objA.InnerText = validValueOff;
            SimpleTypeValueValidTest(objA, false, validValueOff);

            Output.WriteLine("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new OnOffValue(a); });

            Output.WriteLine("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            OnOffValue val = validValue;
            val = objA;
            if (val is null)
            {
                Output.WriteLine("implicit string operator on null reference returned null, as expected.");
            }
            else
            {
                Assert.Fail("Implicit string operator on null reference return NON-null.");
            }

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidValueFalse);
            objA = new OnOffValue();
            objA.InnerText = invalidValueFalse;
            InvalidOperation(objA, invalidValueFalse, (a, b) => ActionOfCompare1(a, b));

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidValueTrue);
            objA = new OnOffValue();
            objA.InnerText = invalidValueTrue;
            InvalidOperation(objA, invalidValueTrue, (a, b) => ActionOfCompare1(a, b));

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidValue);
            objA = new OnOffValue();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => ActionOfCompare1(a, b));

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidValue2);
            objA = new OnOffValue();
            objA.InnerText = invalidValue2;
            InvalidOperation(objA, invalidValue2, (a, b) => ActionOfCompare1(a, b));

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidValue3);
            objA = new OnOffValue();
            objA.InnerText = invalidValue3;
            InvalidOperation(objA, invalidValue3, (a, b) => ActionOfCompare1(a, b));
        }

        [Fact]
        public void TrueFalseBlankValueTest()
        {
            bool maxValue = true;
            bool minValue = false;
            bool validValue = true;
            string validValueTrue = "true";
            string validValueFalse = "false";
            string validValuet = "t";
            string validValuef = "f";
            string validValueBlank = string.Empty;
            string invalidValueTrue = "True";
            string invalidValueFalse = "False";
            string invalidValue2 = "Invalid 0.1 String!";
            string invalidValue3 = "Invalid 1.0 String!";
            string invalidValue = "Invalid String!";

            Output.WriteLine("Constructing with Max value and testing...");
            SimpleTypeValueValidTest(new TrueFalseBlankValue(maxValue), maxValue, maxValue == true ? validValueTrue : validValueFalse);

            Output.WriteLine("Constructing with Max value and testing with Clone()....");
            SimpleTypeValueValidTest(new TrueFalseBlankValue(maxValue).Clone() as TrueFalseBlankValue, maxValue, maxValue == true ? validValueTrue : validValueFalse);

            Output.WriteLine("Set Value with Min value and testing....");
            TrueFalseBlankValue objA = new TrueFalseBlankValue();
            objA.Value = minValue;
            SimpleTypeValueValidTest(objA, minValue, minValue == true ? validValueTrue : validValueFalse);

            Output.WriteLine("Set InnerText with Min value and testing...");
            TrueFalseBlankValue objB = new TrueFalseBlankValue();
            objB.InnerText = minValue.ToString().ToLower(); // True -> true, False -> false
            SimpleTypeValueValidTest(objB, minValue, minValue.ToString().ToLower());

            Output.WriteLine("Implicit Int Operator with Min value and testing...");
            objB = minValue;
            SimpleTypeValueValidTest(objB, minValue, minValue == true ? validValueTrue : validValueFalse);

            Output.WriteLine("Explicit TrueFalseBlankValue conversion with value {0} and testing", validValue);
            objB = TrueFalseBlankValue.FromBoolean(validValue);
            Assert.True(TrueFalseBlankValue.ToBoolean(objB) == validValue, "FromBoolean() value doesn't equal to ToBoolean() value!");

            Output.WriteLine("Constructing with another instance with valid value...");
            objA = new TrueFalseBlankValue(validValue);
            SimpleTypeValueValidTest(new TrueFalseBlankValue(objA), validValue, validValue == true ? validValueTrue : validValueFalse);

            Output.WriteLine("Verifying equality...");
            objA = new TrueFalseBlankValue(validValue);
            objB = new TrueFalseBlankValue(validValue);
            Assert.True(objA.Equals(objB));

            objA = new TrueFalseBlankValue(validValue);
            objB = objA;
            Assert.True(object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Assert.True(object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Output.WriteLine("Setting InnerText as special value and testing...");
            objA = new TrueFalseBlankValue();
            objA.InnerText = validValuef;
            SimpleTypeValueValidTest(objA, false, validValuef);
            objA.InnerText = validValuet;
            SimpleTypeValueValidTest(objA, true, validValuet);
            objA.InnerText = validValueFalse;
            SimpleTypeValueValidTest(objA, false, validValueFalse);
            objA.InnerText = validValueTrue;
            SimpleTypeValueValidTest(objA, true, validValueTrue);
            objA.InnerText = validValueBlank;
            SimpleTypeValueValidTest(objA, false, validValueBlank);

            Output.WriteLine("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new TrueFalseBlankValue(a); });

            Output.WriteLine("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            TrueFalseBlankValue val = validValue;
            val = objA;
            if (val is null)
            {
                Output.WriteLine("implicit string operator on null reference returned null, as expected.");
            }
            else
            {
                Assert.Fail("Implicit string operator on null reference return NON-null.");
            }

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidValueFalse);
            objA = new TrueFalseBlankValue();
            objA.InnerText = invalidValueFalse;
            InvalidOperation(objA, invalidValueFalse, (a, b) => ActionOfCompare1(a, b));

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidValueTrue);
            objA = new TrueFalseBlankValue();
            objA.InnerText = invalidValueTrue;
            InvalidOperation(objA, invalidValueTrue, (a, b) => ActionOfCompare1(a, b));

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidValue);
            objA = new TrueFalseBlankValue();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => ActionOfCompare1(a, b));

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidValue2);
            objA = new TrueFalseBlankValue();
            objA.InnerText = invalidValue2;
            InvalidOperation(objA, invalidValue2, (a, b) => ActionOfCompare1(a, b));

            Output.WriteLine("ErrorHandling: Set InnerText with invalid value {0}...", invalidValue3);
            objA = new TrueFalseBlankValue();
            objA.InnerText = invalidValue3;
            InvalidOperation(objA, invalidValue3, (a, b) => ActionOfCompare1(a, b));
        }

        private void SimpleTypeValueValidTest(OpenXmlSimpleType oxObj, bool expectedValue, string expectedText)
        {
            Output.WriteLine("Entering Non-Generic Test Method...");

            bool val = expectedValue;

            if (oxObj.GetType() == typeof(OnOffValue))
            {
                val = (oxObj as OnOffValue).Value;
            }
            else if (oxObj.GetType() == typeof(TrueFalseBlankValue))
            {
                val = (oxObj as TrueFalseBlankValue).Value;
            }
            else
            {
                throw new ArgumentException("input is not an OnOffValue or a TrueFalseBlankValue!!!", nameof(oxObj));
            }

            string stringValue = oxObj.InnerText;
            Assert.Equal(expectedText, stringValue);

            stringValue = oxObj;
            Assert.Equal(expectedText, stringValue);

            stringValue = oxObj.ToString();
            Assert.Equal(expectedText, stringValue);

            Assert.True(oxObj.HasValue, string.Format("{0} with valid value has NO value.", oxObj.GetType().Name));
            Assert.True(val.Equals(expectedValue), string.Format("Property Value {0} does NOT equal to expected {1}.", val, expectedValue));

            Assert.True(val.Equals(expectedValue), string.Format("{0} operator result {1} does NOT equal to expected {2}.", typeof(OpenXmlSimpleType).Name, val, expectedValue));

            Output.WriteLine("Leaving Non-Generic Test Method...");
        }

        private void SimpleTypeValueValidTest(TrueFalseBlankValue oxObj, bool expectedValue, string expectedText)
        {
            Output.WriteLine("Entering Non-Generic Test Method...");

            string stringValue = oxObj.InnerText;
            Assert.Equal(expectedText, stringValue);

            stringValue = oxObj;
            Assert.Equal(expectedText, stringValue);

            stringValue = oxObj.ToString();
            Assert.Equal(expectedText, stringValue);

            Assert.True(oxObj.HasValue, string.Format("{0} with valid value has NO value.", oxObj.GetType().Name));
            Assert.True(oxObj.Value.Equals(expectedValue), string.Format("Property Value {0} does NOT equal to expected {1}.", oxObj.Value, expectedValue));

            bool val = oxObj.Value;
            Assert.True(val.Equals(expectedValue), string.Format("{0} operator result {1} does NOT equal to expected {2}.", typeof(OpenXmlSimpleType).Name, val, expectedValue));

            Output.WriteLine("Leaving Non-Generic Test Method...");
        }

        private void InvalidOperation<T>(
            OnOffValue a, T expectedValue,
            Action<OnOffValue, T> action)
        {
            try
            {
                action(a, expectedValue);
                Assert.Fail("Action executed without any exception.");
            }
            catch (Exception e)
            {
                Output.WriteLine($"Warning: {e.ToString()}");
                Output.WriteLine("Expected {0} Caught!", e.GetType().Name);
            }
        }

        private void InvalidOperation<T>(
          TrueFalseBlankValue a, T expectedValue,
          Action<TrueFalseBlankValue, T> action)
        {
            try
            {
                action(a, expectedValue);
                Assert.Fail("Action executed without any exception.");
            }
            catch (Exception e)
            {
                Output.WriteLine($"Warning: {e.ToString()}");
                Output.WriteLine("Expected {0} Caught!", e.GetType().Name);
            }
        }

        private void ActionOfCompare1<T>(OnOffValue a, T expectedValue)
        {
            Output.WriteLine(string.Format("ObjectA {0} value.", a.HasValue ? "HAS" : "has NO"));
            Assert.True(expectedValue.ToString().Equals(a.InnerText), "Instance constructed with invalid value does NOT keep the text.");
            Assert.True(expectedValue.Equals(a.Value), "Instance constructed with invalid value CAN parse without error!");
        }

        private void ActionOfCompare1<T>(TrueFalseBlankValue a, T expectedValue)
        {
            Output.WriteLine(string.Format("ObjectA {0} value.", a.HasValue ? "HAS" : "has NO"));
            Assert.True(expectedValue.ToString().Equals(a.InnerText), "Instance constructed with invalid value does NOT keep the text.");
            Assert.True(expectedValue.Equals(a.Value), "Instance constructed with invalid value CAN parse without error!");
        }

        #endregion

    }
}
