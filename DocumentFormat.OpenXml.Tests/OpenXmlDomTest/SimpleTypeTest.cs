// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Reflection;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Xunit;

namespace DocumentFormat.OpenXml.Tests
{
    //OpenXmlSimpleType
    //   DocumentFormat.OpenXml.EnumValue<T>
    //   DocumentFormat.OpenXml.ListValue<T>
    //   DocumentFormat.OpenXml.StringValue
    //   DocumentFormat.OpenXml.Base64BinaryValue
    //   DocumentFormat.OpenXml.HexBinaryValue
    //   DocumentFormat.OpenXml.OpenXmlSimpleValue<T>

    
    public class OpenXmlSimpleTypeTest : OpenXmlDomTestBase
    {
        #region EnumValue

        [Fact]
        public void EnumValueTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());

            DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault tablecellmar = new DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault();
            tablecellmar.AppendChild(new DocumentFormat.OpenXml.Wordprocessing.LeftMargin());
            var leftmar = tablecellmar.TableCellLeftMargin;

            //public enum HeaderFooterValues
            //{
            //    [EnumString("even")]
            //    Even=0,
            //    [EnumString("default")]
            //    Default=1,
            //    [EnumString("first")]
            //    First=2,
            //}
            //EnumValue<HeaderFooterValues>
            HeaderFooterValues defaultValue = default(HeaderFooterValues);
            HeaderFooterValues validValue = HeaderFooterValues.Even;
            HeaderFooterValues validValue1 = HeaderFooterValues.Default;
            HeaderFooterValues validValue2 = HeaderFooterValues.First;
            HeaderFooterValues validValue0i = (HeaderFooterValues)0;

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
            HeaderFooterValues invalidValue3i = (HeaderFooterValues)3;

            Log.Comment("Testing default value...");
            string expectedText = defaultValue.ToString();
            EnumValue<HeaderFooterValues> defaultObj = default(EnumValue<HeaderFooterValues>);
            Log.VerifyNull(defaultObj, "default(Int32Value) returns reference other than NULL");

            Log.Comment("Constructing with value {0} and testing...", validValue);
            simpleValueValidTest(new EnumValue<HeaderFooterValues>(validValue), validValue, validString0);

            Log.Comment("Constructing with value {0} and testing...", validValue0i);
            simpleValueValidTest(new EnumValue<HeaderFooterValues>(validValue0i), validValue0i, validString0);

            Log.Comment("Constructing with value {0} and testing with Clone()...", validValue1);
            var clone = (new EnumValue<HeaderFooterValues>(validValue1)).Clone();
            simpleValueValidTest(clone as EnumValue<HeaderFooterValues>, validValue1, validString1);  // O14: 253869

            Log.Comment("Set Value with value {0} and testing...", validValue2);
            EnumValue<HeaderFooterValues> objA = new EnumValue<HeaderFooterValues>();
            objA.Value = validValue2;
            simpleValueValidTest(objA, validValue2, validString2);

            Log.Comment("Set InnerText with value {0} and testing...", validString0);
            EnumValue<HeaderFooterValues> objB = new EnumValue<HeaderFooterValues>();
            objB.InnerText = validString0;
            simpleValueValidTest(objB, validValue, validString0);

            Log.Comment("Set InnerText with value {0} and testing...", validString1);
            objB = new EnumValue<HeaderFooterValues>();
            objB.InnerText = validString1;
            simpleValueValidTest(objB, validValue1, validString1);

            Log.Comment("Set InnerText with value {0} and testing...", validString2);
            objB = new EnumValue<HeaderFooterValues>();
            objB.InnerText = validString2.ToString();
            simpleValueValidTest(objB, validValue2, validString2.ToString());

            Log.Comment("Implicit T Operator with value {0} and testing...", validValue);
            objB = validValue;
            simpleValueValidTest(objB, validValue, validString0);

            Log.Comment("Constructing with another instance with valid value {0}...", validValue);
            objA = new EnumValue<HeaderFooterValues>(validValue);
            simpleValueValidTest(new EnumValue<HeaderFooterValues>(objA), validValue, validString0); // O14: 253871

            Log.Comment("Verifying reference type behavior...");
            objA = new EnumValue<HeaderFooterValues>(validValue);
            objB = new EnumValue<HeaderFooterValues>(validValue);
            Log.VerifyFalse(Object.Equals(objA, objB), "Two instances with same value but constructed seperated are Equal.");
            objA = new EnumValue<HeaderFooterValues>(validValue);
            objB = objA;
            Log.VerifyTrue(Object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Log.VerifyTrue(Object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Log.Comment("ErrorHandling: Constructing with invalid value {0} and testing...", invalidValue3i);
            try
            {
                objA = new EnumValue<HeaderFooterValues>(invalidValue3i);
                InvalidOperation(objA, invalidValue3i, (a, expectedValue) => actionOfCompare(a, expectedValue));  // O14: 253876
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Log.Pass("Expected exception caught when constructing an EunumValue with invalid value.");
            }

            Log.Comment("ErrorHandling: Assigning Value with invalid value {0} and testing...", invalidValue3i);
            try
            {
                objA = new EnumValue<HeaderFooterValues>();
                objA.Value = invalidValue3i;
                InvalidOperation(objA, invalidValue3i, (a, expectedValue) => actionOfCompare(a, expectedValue));  // O14: 253876
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Log.Pass("Expected exception caught when assigning Value with invalid value.");
            }

            Log.Comment("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, expectedValue) => { expectedValue = new EnumValue<HeaderFooterValues>(a); });

            Log.Comment("ErrorHandling: Implicit string operator on null reference...");
            objA = null;
            HeaderFooterValues val = default(HeaderFooterValues);
            InvalidOperation(objA, val, (a, expectedValue) => { expectedValue = a; });

            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidNum0);
            objA = new EnumValue<HeaderFooterValues>();
            objA.InnerText = invalidNum0;
            InvalidOperation(objA, invalidNum0, (a, expectedValue) => actionOfCompare(a, expectedValue));

            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidNum1);
            objA = new EnumValue<HeaderFooterValues>();
            objA.InnerText = invalidNum1;
            InvalidOperation(objA, invalidNum1, (a, expectedValue) => actionOfCompare(a, expectedValue));

            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidNum2);
            objA = new EnumValue<HeaderFooterValues>();
            objA.InnerText = invalidNum2;
            InvalidOperation(objA, invalidNum2, (a, expectedValue) => actionOfCompare(a, expectedValue));

            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidNum3);
            objA = new EnumValue<HeaderFooterValues>();
            objA.InnerText = invalidNum3;
            InvalidOperation(objA, invalidNum3, (a, expectedValue) => actionOfCompare(a, expectedValue));

            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidNum10);
            objA = new EnumValue<HeaderFooterValues>();
            objA.InnerText = invalidNum10;
            InvalidOperation(objA, invalidNum10, (a, expectedValue) => actionOfCompare(a, expectedValue));

            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidString0);
            objA = new EnumValue<HeaderFooterValues>();
            objA.InnerText = invalidString0;
            InvalidOperation(objA, invalidString0, (a, expectedValue) => actionOfCompare(a, expectedValue));

            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidString1);
            objA = new EnumValue<HeaderFooterValues>();
            objA.InnerText = invalidString1;
            InvalidOperation(objA, invalidString1, (a, expectedValue) => actionOfCompare(a, expectedValue));

            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidString2);
            objA = new EnumValue<HeaderFooterValues>();
            objA.InnerText = invalidString2;
            InvalidOperation(objA, invalidString2, (a, expectedValue) => actionOfCompare(a, expectedValue));
        }


        private void InvalidOperation<T1, T2>(EnumValue<T1> a, T2 expectedValue, Action<EnumValue<T1>, T2> action)
            where T1 : struct
        {
            try
            {
                action(a, expectedValue);
                Log.Fail("Action executed without any exception.");
            }
            catch (Exception e)
            {
                Log.Warning(e.ToString());
                Log.Pass("Expected {0} Caught!", e.GetType().Name);
            }
        }

        private void actionOfCompare<T1, T2>(EnumValue<T1> a, T2 expectedValue)
            where T1 : struct
        {
            Log.Comment(string.Format("ObjectA {0} value.", a.HasValue ? "HAS" : "has NO"));
            Log.Verify(expectedValue.Equals(a.InnerText), "Instance constructed with invalid value does NOT keep the text.");
            Log.Verify(expectedValue.Equals(a.Value), "Instance constructed with invalid value CAN parse without error!");
        }

        private void simpleValueValidTest<T>(EnumValue<T> oxObj, T expectedValue, string expectedText)
            where T : struct
        {
            Log.Comment("Entering Non-Generic Test Method...");

            string stringValue = oxObj.InnerText;
            Log.VerifyNotNull(stringValue, "Null returned by .InnerText!");
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

            Log.Comment("Leaving Non-Generic Test Method...");
        }

        #endregion EnumValue

        #region ListValue
        [Fact]
        public void ListValueTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            //String, Int32, UInt32, Boolean used as T in OpenXml SDK
            String defaultValue = default(String);
            String validString = "Normal String Content";
            IEnumerable<StringValue> validValue = validString.Split().Select(s => new StringValue(s));
            String specialString = validString + " " + string.Empty + " " + validString;
            List<StringValue> specialValue = new List<StringValue>(validValue.Count() * 2 + 1);
            specialValue.AddRange(validValue);
            specialValue.Add(new StringValue(string.Empty));
            specialValue.AddRange(validValue);

            Log.Comment("Testing default value...");
            string expectedText = defaultValue;
            ListValue<StringValue> defaultObj = default(ListValue<StringValue>);
            Log.VerifyNull(defaultObj, "default(ListValue<StringValue>) returns reference other than NULL");

            Log.Comment("Constructing with value {0} and testing...", validString);
            simpleValueValidTest(new ListValue<StringValue>(validValue), validValue, validString);

            Log.Comment("Constructing with value {0} and testing with Clone()...", validString);
            simpleValueValidTest(new ListValue<StringValue>(validValue).Clone() as ListValue<StringValue>, validValue, validString);

            Log.Comment("Since property Items is read only, no need to set Items.");

            Log.Comment("Set InnerText with value {0} and testing...", validValue);
            ListValue<StringValue> objB = new ListValue<StringValue>();
            objB.InnerText = validString;
            simpleValueValidTest(objB, validValue, validString);

            Log.Comment("Constructing with another instance with valid value {0}...", validString);
            ListValue<StringValue> objA = new ListValue<StringValue>(validValue);
            simpleValueValidTest(new ListValue<StringValue>(objA), validValue, validString);

            Log.Comment("Constructing with special value {0} and testing...", specialString);
            simpleValueValidTest(new ListValue<StringValue>(specialValue), specialValue, specialString);

            Log.Comment("Verifying reference type behavior...");
            objA = new ListValue<StringValue>(validValue);
            objB = new ListValue<StringValue>(validValue);
            Log.VerifyFalse(Object.Equals(objA, objB), "Two instances with same value but constructed seperated are Equal.");
            objA = new ListValue<StringValue>(validValue);
            objB = objA;
            Log.VerifyTrue(Object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Log.VerifyTrue(Object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Log.Comment("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new ListValue<StringValue>(a); });
        }

        private void InvalidOperation<T1,T2>(ListValue<T1> a, T2 b, Action<ListValue<T1>, T2> action)
            where T1 : OpenXmlSimpleType,new()
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

        private void InvalidOperation<T1,T2, T3>(ListValue<T1> a, T2 b, T3 c, Action<ListValue<T1>, T2, T3> action)
            where T1 : OpenXmlSimpleType,new()
        {
            try
            {
                action(a, b, c);
                Log.Fail("Action executed without any exception.");
            }
            catch (Exception e)
            {
                Log.Warning(e.ToString());
                Log.Pass("Expected {0} Caught!", e.GetType().Name);
            }
        }

        private void actionOfCompare<T1>(ListValue<T1> a, IEnumerable<T1> expectedValue, string expectedText)
            where T1 : OpenXmlSimpleType, new()
        {
            Log.Comment(string.Format("ObjectA {0} value.", a.HasValue ? "HAS" : "has NO"));
            Log.Verify(expectedText.Equals(a.InnerText), "Instance constructed with invalid value does NOT keep the text.");
            Log.VerifyTrue(isSequenceEqual(a.Items, expectedValue), "Instance constructed with invalid value CAN parse without error!");
        }

        private void simpleValueValidTest<T>(ListValue<T> oxObj, IEnumerable<T> expectedValue, string expectedText)
            where T : OpenXmlSimpleType, new()
        {
            Log.Comment("Entering Non-Generic Test Method...");

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
            Log.VerifyTrue(isSequenceEqual(oxObj.Items, expectedValue),
                "Property Items {0} does NOT equal to expected {1}.", oxObj.Items, expectedValue);

            Log.Comment("Leaving Non-Generic Test Method...");
        }

        private bool isSequenceEqual<T1>(ICollection<T1> items, IEnumerable<T1> listB)
            where T1 : OpenXmlSimpleType, new()
        {
            if (items == null)
                throw new ArgumentNullException("items");
            if (listB == null)
                throw new ArgumentNullException("listB");
            return items.Select(i => i.ToString()).SequenceEqual(listB.Select(t => t.ToString()));
        }

        #endregion ListValue

        #region StringValue
        [Fact]
        public void StringValueTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            String defaultValue = default(String);
            String validValue = "Normal String Content";
            String specialString = @"</pPr>";
            String specialString2 = @"</w:pPr>";
            String specialString3 = string.Empty;

            Log.Comment("Testing default value...");
            string expectedText = defaultValue;
            StringValue defaultObj = default(StringValue);
            Log.VerifyNull(defaultObj, "default(Int32Value) returns reference other than NULL");

            Log.Comment("Constructing with value {0} and testing...", validValue);
            simpleValueValidTest(new StringValue(validValue), validValue, validValue.ToString());

            Log.Comment("Constructing with value {0} and testing with Clone()...", validValue);
            simpleValueValidTest(new StringValue(validValue).Clone() as StringValue, validValue, validValue.ToString());

            Log.Comment("Set Value with value {0} and testing...", validValue);
            StringValue objA = new StringValue();
            objA.Value = validValue;
            simpleValueValidTest(objA, validValue, validValue.ToString());

            Log.Comment("Set InnerText with value {0} and testing...", validValue);
            StringValue objB = new StringValue();
            objB.InnerText = validValue.ToString();
            simpleValueValidTest(objB, validValue, validValue.ToString());

            Log.Comment("Constructing with value {0} and testing...", specialString2);
            simpleValueValidTest(new StringValue(specialString2), specialString2, specialString2.ToString());

            Log.Comment("Set InnerText with value {0} and testing...", specialString);
            objB = new StringValue();
            objB.InnerText = specialString.ToString();
            simpleValueValidTest(objB, specialString, specialString.ToString());

            Log.Comment("Set InnerText with value {0} and testing...", specialString3);
            objB = new StringValue();
            objB.InnerText = specialString3.ToString();
            simpleValueValidTest(objB, specialString3, specialString3.ToString());

            Log.Comment("Implicit String Operator with value {0} and testing...", validValue);
            objB = validValue;
            simpleValueValidTest(objB, validValue, validValue.ToString());

            Log.Comment("Constructing with another instance with valid value {0}...", validValue);
            objA = new StringValue(validValue);
            simpleValueValidTest(new StringValue(objA), validValue, validValue.ToString());

            Log.Comment("Verifying reference type behavior...");
            objA = new StringValue(validValue);
            objB = new StringValue(validValue);
            Log.VerifyFalse(Object.Equals(objA, objB), "Two instances with same value but constructed seperated are Equal.");
            objA = new StringValue(validValue);
            objB = objA;
            Log.VerifyTrue(Object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Log.VerifyTrue(Object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Log.Comment("ErrorHandling: Implicit string operator on null reference...");
            objA = null;
            String val = string.Empty;
            val = objA;
            if (val == null)
                Log.Pass("implicit string operator on null reference returned null, as expected.");
            else
                Log.Fail("Implicit string operator on null reference return NON-null.");
        }


        private void InvalidOperation<T>(
            StringValue a, T expectedValue,
            Action<StringValue, T> action)
        {
            try
            {
                action(a, expectedValue);
                Log.Fail("Action executed without any exception.");
            }
            catch (Exception e)
            {
                Log.Warning(e.ToString());
                Log.Pass("Expected {0} Caught!", e.GetType().Name);
            }
        }

        private void actionOfCompare<T>(StringValue a, T expectedValue)
        {
            Log.Comment(string.Format("ObjectA {0} value.", a.HasValue ? "HAS" : "has NO"));
            Log.Verify(expectedValue.Equals(a.InnerText), "Instance constructed with invalid value does NOT keep the text.");
            Log.Verify(expectedValue.Equals(a.Value), "Instance constructed with invalid value CAN parse without error!");
        }

        private void simpleValueValidTest(StringValue oxObj, string expectedValue, string expectedText)
        {
            Log.Comment("Entering Non-Generic Test Method...");

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

            string val = oxObj as OpenXmlSimpleType;
            Log.VerifyTrue(val.Equals(expectedValue),
                "{0} operator result {1} does NOT equal to expected {2}.", typeof(OpenXmlSimpleType).Name, val, expectedValue);

            Log.Comment("Leaving Non-Generic Test Method...");
        }
        #endregion StringValue

        #region Base64BinaryValue
        [Fact]
        public void Base64BinaryValueTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            String defaultValue = default(String);
            String validValue = "Normal String Content";
            String specialString = @"</pPr>";
            String specialString2 = @"</w:pPr>";
            String specialString3 = string.Empty;

            Log.Comment("Testing default value...");
            string expectedText = defaultValue;
            Base64BinaryValue defaultObj = default(Base64BinaryValue);
            Log.VerifyNull(defaultObj, "default(Int32Value) returns reference other than NULL");

            Log.Comment("Constructing with value {0} and testing...", validValue);
            simpleValueValidTest(new Base64BinaryValue(validValue), validValue, validValue.ToString());

            Log.Comment("Constructing with value {0} and testing with Clone()...", validValue);
            simpleValueValidTest(new Base64BinaryValue(validValue).Clone() as Base64BinaryValue, validValue, validValue.ToString());

            Log.Comment("Set Value with value {0} and testing...", validValue);
            Base64BinaryValue objA = new Base64BinaryValue();
            objA.Value = validValue;
            simpleValueValidTest(objA, validValue, validValue.ToString());

            Log.Comment("Set InnerText with value {0} and testing...", validValue);
            Base64BinaryValue objB = new Base64BinaryValue();
            objB.InnerText = validValue.ToString();
            simpleValueValidTest(objB, validValue, validValue.ToString());

            Log.Comment("Constructing with value {0} and testing...", specialString2);
            simpleValueValidTest(new Base64BinaryValue(specialString2), specialString2, specialString2.ToString());

            Log.Comment("Set InnerText with value {0} and testing...", specialString);
            objB = new Base64BinaryValue();
            objB.InnerText = specialString.ToString();
            simpleValueValidTest(objB, specialString, specialString.ToString());

            Log.Comment("Set InnerText with value {0} and testing...", specialString3);
            objB = new Base64BinaryValue();
            objB.InnerText = specialString3.ToString();
            simpleValueValidTest(objB, specialString3, specialString3.ToString());

            Log.Comment("Implicit String Operator with value {0} and testing...", validValue);
            objB = validValue;
            simpleValueValidTest(objB, validValue, validValue.ToString());

            Log.Comment("Explicit string conversion with value {0} and testing", validValue);
            objB=Base64BinaryValue.FromString(validValue);
            Log.VerifyTrue(Base64BinaryValue.ToString(objB) == validValue, "FromXX() value doesn't equal to ToXX() value!");

            Log.Comment("Constructing with another instance with valid value {0}...", validValue);
            objA = new Base64BinaryValue(validValue);
            simpleValueValidTest(new Base64BinaryValue(objA), validValue, validValue.ToString());

            Log.Comment("Verifying reference type behavior...");
            objA = new Base64BinaryValue(validValue);
            objB = new Base64BinaryValue(validValue);
            Log.VerifyFalse(Object.Equals(objA, objB), "Two instances with same value but constructed seperated are Equal.");
            objA = new Base64BinaryValue(validValue);
            objB = objA;
            Log.VerifyTrue(Object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Log.VerifyTrue(Object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Log.Comment("ErrorHandling: Constructing with another instance of null...");
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
                Log.Fail("Action executed without any exception.");
            }
            catch (Exception e)
            {
                Log.Warning(e.ToString());
                Log.Pass("Expected {0} Caught!", e.GetType().Name);
            }
        }

        private void actionOfCompare<T>(Base64BinaryValue a, T expectedValue)
        {
            Log.Comment(string.Format("ObjectA {0} value.", a.HasValue ? "HAS" : "has NO"));
            Log.Verify(expectedValue.Equals(a.InnerText), "Instance constructed with invalid value does NOT keep the text.");
            Log.Verify(expectedValue.Equals(a.Value), "Instance constructed with invalid value CAN parse without error!");
        }

        private void simpleValueValidTest(Base64BinaryValue oxObj, string expectedValue, string expectedText)
        {
            Log.Comment("Entering Non-Generic Test Method...");

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

            string val = oxObj as OpenXmlSimpleType;
            Log.VerifyTrue(val.Equals(expectedValue),
                "{0} operator result {1} does NOT equal to expected {2}.", typeof(OpenXmlSimpleType).Name, val, expectedValue);

            Log.Comment("Leaving Non-Generic Test Method...");
        }
        #endregion Base64BinaryValue

        #region HexBinaryValue
        [Fact]
        public void HexBinaryValueTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            String defaultValue = default(String);
            String validValue = "Normal String Content";
            String specialString = @"</pPr>";
            String specialString2 = @"</w:pPr>";
            String specialString3 = string.Empty;

            Log.Comment("Testing default value...");
            string expectedText = defaultValue;
            HexBinaryValue defaultObj = default(HexBinaryValue);
            Log.VerifyNull(defaultObj, "default(Int32Value) returns reference other than NULL");

            Log.Comment("Constructing with value {0} and testing...", validValue);
            simpleValueValidTest(new HexBinaryValue(validValue), validValue, validValue.ToString());

            Log.Comment("Constructing with value {0} and testing with Clone()...", validValue);
            simpleValueValidTest(new HexBinaryValue(validValue).Clone() as HexBinaryValue, validValue, validValue.ToString());

            Log.Comment("Set Value with value {0} and testing...", validValue);
            HexBinaryValue objA = new HexBinaryValue();
            objA.Value = validValue;
            simpleValueValidTest(objA, validValue, validValue.ToString());

            Log.Comment("Set InnerText with value {0} and testing...", validValue);
            HexBinaryValue objB = new HexBinaryValue();
            objB.InnerText = validValue.ToString();
            simpleValueValidTest(objB, validValue, validValue.ToString());

            Log.Comment("Constructing with value {0} and testing...", specialString2);
            simpleValueValidTest(new HexBinaryValue(specialString2), specialString2, specialString2.ToString());

            Log.Comment("Set InnerText with value {0} and testing...", specialString);
            objB = new HexBinaryValue();
            objB.InnerText = specialString.ToString();
            simpleValueValidTest(objB, specialString, specialString.ToString());

            Log.Comment("Set InnerText with value {0} and testing...", specialString3);
            objB = new HexBinaryValue();
            objB.InnerText = specialString3.ToString();
            simpleValueValidTest(objB, specialString3, specialString3.ToString());

            Log.Comment("Implicit String Operator with value {0} and testing...", validValue);
            objB = validValue;
            simpleValueValidTest(objB, validValue, validValue.ToString());

            Log.Comment("Explicit string conversion with value {0} and testing", validValue);
            objB = HexBinaryValue.FromString(validValue);
            Log.VerifyTrue(HexBinaryValue.ToString(objB) == validValue, "FromXX() value doesn't equal to ToXX() value!");

            Log.Comment("Constructing with another instance with valid value {0}...", validValue);
            objA = new HexBinaryValue(validValue);
            simpleValueValidTest(new HexBinaryValue(objA), validValue, validValue.ToString());

            Log.Comment("Verifying reference type behavior...");
            objA = new HexBinaryValue(validValue);
            objB = new HexBinaryValue(validValue);
            Log.VerifyFalse(Object.Equals(objA, objB), "Two instances with same value but constructed seperated are Equal.");
            objA = new HexBinaryValue(validValue);
            objB = objA;
            Log.VerifyTrue(Object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Log.VerifyTrue(Object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Log.Comment("ErrorHandling: Constructing with another instance of null...");
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
                Log.Fail("Action executed without any exception.");
            }
            catch (Exception e)
            {
                Log.Warning(e.ToString());
                Log.Pass("Expected {0} Caught!", e.GetType().Name);
            }
        }

        private void actionOfCompare<T>(HexBinaryValue a, T expectedValue)
        {
            Log.Comment(string.Format("ObjectA {0} value.", a.HasValue ? "HAS" : "has NO"));
            Log.Verify(expectedValue.Equals(a.InnerText), "Instance constructed with invalid value does NOT keep the text.");
            Log.Verify(expectedValue.Equals(a.Value), "Instance constructed with invalid value CAN parse without error!");
        }

        private void simpleValueValidTest(HexBinaryValue oxObj, string expectedValue, string expectedText)
        {
            Log.Comment("Entering Non-Generic Test Method...");

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

            string val = oxObj as OpenXmlSimpleType;
            Log.VerifyTrue(val.Equals(expectedValue),
                "{0} operator result {1} does NOT equal to expected {2}.", typeof(OpenXmlSimpleType).Name, val, expectedValue);

            Log.Comment("Leaving Non-Generic Test Method...");
        }
        #endregion HexBinaryValue
        
        #region OnOffValue
        [Fact]
        public void OnOffValueTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
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

            Log.Comment("Constructing with Max value and testing...");
            simpleTypeValueValidTest(new OnOffValue(maxValue), maxValue, maxValue == true ? validValueTrue : validValueFalse);

            Log.Comment("Constructing with Max value and testing with Clone()....");
            simpleTypeValueValidTest(new OnOffValue(maxValue).Clone() as OnOffValue, maxValue, maxValue == true ? validValueTrue : validValueFalse);

            Log.Comment("Set Value with Min value and testing....");
            OnOffValue objA = new OnOffValue();
            objA.Value = minValue;
            simpleTypeValueValidTest(objA, minValue, minValue == true ? validValueTrue : validValueFalse);

            Log.Comment("Set InnerText with Min value and testing...");
            OnOffValue objB = new OnOffValue();
            objB.InnerText = minValue.ToString().ToLower(); // True -> true, False -> false
            simpleTypeValueValidTest(objB, minValue, minValue.ToString().ToLower());

            Log.Comment("Implicit Int Operator with Min value and testing...");
            objB = minValue;
            simpleTypeValueValidTest(objB, minValue, minValue == true ? validValueTrue : validValueFalse);

            Log.Comment("Explicit OnOffValue conversion with value {0} and testing", validValue);
            objB = OnOffValue.FromBoolean(validValue);
            Log.VerifyTrue(OnOffValue.ToBoolean(objB) == validValue, "FromBoolean() value doesn't equal to ToBoolean() value!");

            Log.Comment("Constructing with another instance with valid value...");
            objA = new OnOffValue(validValue);
            simpleTypeValueValidTest(new OnOffValue(objA), validValue, validValue == true ? validValueTrue : validValueFalse);

            Log.Comment("Verifying reference type behavior...");
            objA = new OnOffValue(validValue);
            objB = new OnOffValue(validValue);
            Log.VerifyFalse(Object.Equals(objA, objB), "Two instances with same value but constructed seperated are Equal.");
            objA = new OnOffValue(validValue);
            objB = objA;
            Log.VerifyTrue(Object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Log.VerifyTrue(Object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Log.Comment("Setting InnerText as special value and testing...");
            objA = new OnOffValue();
            objA.InnerText = validValue0;
            simpleTypeValueValidTest(objA, false, validValue0);
            objA.InnerText = validValue1;
            simpleTypeValueValidTest(objA, true, validValue1);
            objA.InnerText = validValueFalse;
            simpleTypeValueValidTest(objA, false, validValueFalse);
            objA.InnerText = validValueTrue;
            simpleTypeValueValidTest(objA, true, validValueTrue);
            objA.InnerText = validValueOn;
            simpleTypeValueValidTest(objA, true, validValueOn);
            objA.InnerText = validValueOff;
            simpleTypeValueValidTest(objA, false, validValueOff);

            Log.Comment("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new OnOffValue(a); });

            Log.Comment("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            OnOffValue val = validValue;
            val = objA;
            if (val == null)
                Log.Pass("implicit string operator on null reference returned null, as expected.");
            else
                Log.Fail("Implicit string operator on null reference return NON-null.");


            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidValueFalse);
            objA = new OnOffValue();
            objA.InnerText = invalidValueFalse;
            InvalidOperation(objA, invalidValueFalse, (a, b) => actionOfCompare(a, b));

            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidValueTrue);
            objA = new OnOffValue();
            objA.InnerText = invalidValueTrue;
            InvalidOperation(objA, invalidValueTrue, (a, b) => actionOfCompare(a, b));
            
            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidValue);
            objA = new OnOffValue();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => actionOfCompare(a, b));

            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidValue2);
            objA = new OnOffValue();
            objA.InnerText = invalidValue2;
            InvalidOperation(objA, invalidValue2, (a, b) => actionOfCompare(a, b));

            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidValue3);
            objA = new OnOffValue();
            objA.InnerText = invalidValue3;
            InvalidOperation(objA, invalidValue3, (a, b) => actionOfCompare(a, b));
        }

        [Fact]
        public void TrueFalseBlankValueTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            bool maxValue = true;
            bool minValue = false;
            bool validValue = true;
            string validValueTrue = "true";
            string validValueFalse = "false";
            string validValuet = "t";
            string validValuef = "f";
            string validValueBlank = "";
            string invalidValueTrue = "True";
            string invalidValueFalse = "False";
            string invalidValue2 = "Invalid 0.1 String!";
            string invalidValue3 = "Invalid 1.0 String!";
            string invalidValue = "Invalid String!";

            Log.Comment("Constructing with Max value and testing...");
            simpleTypeValueValidTest(new TrueFalseBlankValue(maxValue), maxValue, maxValue == true ? validValueTrue : validValueFalse);

            Log.Comment("Constructing with Max value and testing with Clone()....");
            simpleTypeValueValidTest(new TrueFalseBlankValue(maxValue).Clone() as TrueFalseBlankValue, maxValue, maxValue == true ? validValueTrue : validValueFalse);

            Log.Comment("Set Value with Min value and testing....");
            TrueFalseBlankValue objA = new TrueFalseBlankValue();
            objA.Value = minValue;
            simpleTypeValueValidTest(objA, minValue, minValue == true ? validValueTrue : validValueFalse);

            Log.Comment("Set InnerText with Min value and testing...");
            TrueFalseBlankValue objB = new TrueFalseBlankValue();
            objB.InnerText = minValue.ToString().ToLower(); // True -> true, False -> false
            simpleTypeValueValidTest(objB, minValue, minValue.ToString().ToLower());

            Log.Comment("Implicit Int Operator with Min value and testing...");
            objB = minValue;
            simpleTypeValueValidTest(objB, minValue, minValue == true ? validValueTrue : validValueFalse);

            Log.Comment("Explicit TrueFalseBlankValue conversion with value {0} and testing", validValue);
            objB = TrueFalseBlankValue.FromBoolean(validValue);
            Log.VerifyTrue(TrueFalseBlankValue.ToBoolean(objB) == validValue, "FromBoolean() value doesn't equal to ToBoolean() value!");

            Log.Comment("Constructing with another instance with valid value...");
            objA = new TrueFalseBlankValue(validValue);
            simpleTypeValueValidTest(new TrueFalseBlankValue(objA), validValue, validValue == true ? validValueTrue : validValueFalse);

            Log.Comment("Verifying reference type behavior...");
            objA = new TrueFalseBlankValue(validValue);
            objB = new TrueFalseBlankValue(validValue);
            Log.VerifyFalse(Object.Equals(objA, objB), "Two instances with same value but constructed seperated are Equal.");
            objA = new TrueFalseBlankValue(validValue);
            objB = objA;
            Log.VerifyTrue(Object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Log.VerifyTrue(Object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Log.Comment("Setting InnerText as special value and testing...");
            objA = new TrueFalseBlankValue();
            objA.InnerText = validValuef;
            simpleTypeValueValidTest(objA, false, validValuef);
            objA.InnerText = validValuet;
            simpleTypeValueValidTest(objA, true, validValuet);
            objA.InnerText = validValueFalse;
            simpleTypeValueValidTest(objA, false, validValueFalse);
            objA.InnerText = validValueTrue;
            simpleTypeValueValidTest(objA, true, validValueTrue);
            objA.InnerText = validValueBlank;
            simpleTypeValueValidTest(objA, false, validValueBlank);
            

            Log.Comment("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new TrueFalseBlankValue(a); });

            Log.Comment("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            TrueFalseBlankValue val = validValue;
            val = objA;
            if (val == null)
                Log.Pass("implicit string operator on null reference returned null, as expected.");
            else
                Log.Fail("Implicit string operator on null reference return NON-null.");


            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidValueFalse);
            objA = new TrueFalseBlankValue();
            objA.InnerText = invalidValueFalse;
            InvalidOperation(objA, invalidValueFalse, (a, b) => actionOfCompare(a, b));

            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidValueTrue);
            objA = new TrueFalseBlankValue();
            objA.InnerText = invalidValueTrue;
            InvalidOperation(objA, invalidValueTrue, (a, b) => actionOfCompare(a, b));

            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidValue);
            objA = new TrueFalseBlankValue();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => actionOfCompare(a, b));

            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidValue2);
            objA = new TrueFalseBlankValue();
            objA.InnerText = invalidValue2;
            InvalidOperation(objA, invalidValue2, (a, b) => actionOfCompare(a, b));

            Log.Comment("ErrorHandling: Set InnerText with invalid value {0}...", invalidValue3);
            objA = new TrueFalseBlankValue();
            objA.InnerText = invalidValue3;
            InvalidOperation(objA, invalidValue3, (a, b) => actionOfCompare(a, b));
        }

        private void simpleTypeValueValidTest(OpenXmlSimpleType oxObj, bool expectedValue, string expectedText)
        {
            Log.Comment("Entering Non-Generic Test Method...");
            
            bool val=expectedValue;

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
                throw new ArgumentException("input is not an OnOffValue or a TrueFalseBlankValue!!!", "oxObj");
            }

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
            Log.VerifyTrue(val.Equals(expectedValue),
                "Property Value {0} does NOT equal to expected {1}.", val, expectedValue);

            
            Log.VerifyTrue(val.Equals(expectedValue),
                "{0} operator result {1} does NOT equal to expected {2}.", typeof(OpenXmlSimpleType).Name, val, expectedValue);

            Log.Comment("Leaving Non-Generic Test Method...");
        }

        private void simpleTypeValueValidTest(TrueFalseBlankValue oxObj, bool expectedValue, string expectedText)
        {
            Log.Comment("Entering Non-Generic Test Method...");

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

            bool val = oxObj.Value;
            Log.VerifyTrue(val.Equals(expectedValue),
                "{0} operator result {1} does NOT equal to expected {2}.", typeof(OpenXmlSimpleType).Name, val, expectedValue);

            Log.Comment("Leaving Non-Generic Test Method...");
        }
        private void InvalidOperation<T>(
            OnOffValue a, T expectedValue,
            Action<OnOffValue, T> action)
        {
            try
            {
                action(a, expectedValue);
                Log.Fail("Action executed without any exception.");
            }
            catch (Exception e)
            {
                Log.Warning(e.ToString());
                Log.Pass("Expected {0} Caught!", e.GetType().Name);
            }
        }

        private void InvalidOperation<T>(
          TrueFalseBlankValue a, T expectedValue,
          Action<TrueFalseBlankValue, T> action)
        {
            try
            {
                action(a, expectedValue);
                Log.Fail("Action executed without any exception.");
            }
            catch (Exception e)
            {
                Log.Warning(e.ToString());
                Log.Pass("Expected {0} Caught!", e.GetType().Name);
            }
        }

        private void actionOfCompare<T>(OnOffValue a, T expectedValue)
        {
            Log.Comment(string.Format("ObjectA {0} value.", a.HasValue ? "HAS" : "has NO"));
            Log.Verify(expectedValue.ToString().Equals(a.InnerText), "Instance constructed with invalid value does NOT keep the text.");
            Log.Verify(expectedValue.Equals(a.Value), "Instance constructed with invalid value CAN parse without error!");
        }

        private void actionOfCompare<T>(TrueFalseBlankValue a, T expectedValue)
        {
            Log.Comment(string.Format("ObjectA {0} value.", a.HasValue ? "HAS" : "has NO"));
            Log.Verify(expectedValue.ToString().Equals(a.InnerText), "Instance constructed with invalid value does NOT keep the text.");
            Log.Verify(expectedValue.Equals(a.Value), "Instance constructed with invalid value CAN parse without error!");
        }
        
        #endregion

    }

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
        [Fact]
        public void BooleanValueTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            Boolean defaultValue = default(Boolean);
            Boolean maxValue = true;
            Boolean minValue = false;
            Boolean validValue = true;
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

            Log.Comment("Verifying reference type behavior...");
            objA = new BooleanValue(validValue);
            objB = new BooleanValue(validValue);
            Log.VerifyFalse(Object.Equals(objA, objB), "Two instances with same value but constructed seperated are Equal.");
            objA = new BooleanValue(validValue);
            objB = objA;
            Log.VerifyTrue(Object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Log.VerifyTrue(Object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

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
            Boolean val = defaultValue;
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
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            Byte defaultValue = default(Byte);
            Byte maxValue = Byte.MaxValue;
            Byte minValue = Byte.MinValue;
            Byte validValue = (Byte)50;
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

            Log.Comment("Verifying reference type behavior...");
            objA = new ByteValue(validValue);
            objB = new ByteValue(validValue);
            Log.VerifyFalse(Object.Equals(objA, objB), "Two instances with same value but constructed seperated are Equal.");
            objA = new ByteValue(validValue);
            objB = objA;
            Log.VerifyTrue(Object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Log.VerifyTrue(Object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Log.Comment("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new ByteValue(a); });

            Log.Comment("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            Byte val = default(Byte);
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Log.Comment("ErrorHandling: Set InnerText with invalid value...");
            objA = new ByteValue();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => actionOfCompare(a, b));
        }

        [Fact]
        public void SByteValueTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            SByte defaultValue = default(SByte);
            SByte maxValue = SByte.MaxValue;
            SByte minValue = SByte.MinValue;
            SByte validValue = (SByte)50;
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

            Log.Comment("Verifying reference type behavior...");
            objA = new SByteValue(validValue);
            objB = new SByteValue(validValue);
            Log.VerifyFalse(Object.Equals(objA, objB), "Two instances with same value but constructed seperated are Equal.");
            objA = new SByteValue(validValue);
            objB = objA;
            Log.VerifyTrue(Object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Log.VerifyTrue(Object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Log.Comment("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new SByteValue(a); });

            Log.Comment("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            SByte val = default(SByte);
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Log.Comment("ErrorHandling: Set InnerText with invalid value...");
            objA = new SByteValue();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => actionOfCompare(a, b));
        }

        [Fact]
        public void UInt16ValueTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            UInt16 defaultValue = default(UInt16);
            UInt16 maxValue = UInt16.MaxValue;
            UInt16 minValue = UInt16.MinValue;
            UInt16 validValue = (UInt16)123;
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

            Log.Comment("Verifying reference type behavior...");
            objA = new UInt16Value(validValue);
            objB = new UInt16Value(validValue);
            Log.VerifyFalse(Object.Equals(objA, objB), "Two instances with same value but constructed seperated are Equal.");
            objA = new UInt16Value(validValue);
            objB = objA;
            Log.VerifyTrue(Object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Log.VerifyTrue(Object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Log.Comment("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new UInt16Value(a); });

            Log.Comment("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            UInt16 val = default(UInt16);
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Log.Comment("ErrorHandling: Set InnerText with invalid value...");
            objA = new UInt16Value();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => actionOfCompare(a, b));
        }

        [Fact]
        public void UInt32ValueTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            UInt32 defaultValue = default(UInt32);
            UInt32 maxValue = UInt32.MaxValue;
            UInt32 minValue = UInt32.MinValue;
            UInt32 validValue = (UInt32)123456;
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

            Log.Comment("Verifying reference type behavior...");
            objA = new UInt32Value(validValue);
            objB = new UInt32Value(validValue);
            Log.VerifyFalse(Object.Equals(objA, objB), "Two instances with same value but constructed seperated are Equal.");
            objA = new UInt32Value(validValue);
            objB = objA;
            Log.VerifyTrue(Object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Log.VerifyTrue(Object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Log.Comment("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new UInt32Value(a); });

            Log.Comment("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            UInt32 val = default(UInt32);
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Log.Comment("ErrorHandling: Set InnerText with invalid value...");
            objA = new UInt32Value();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => actionOfCompare(a, b));
        }

        [Fact]
        public void Int32ValueTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            Int32 defaultValue = default(Int32);
            Int32 maxValue = Int32.MaxValue;
            Int32 minValue = Int32.MinValue;
            Int32 validValue = (Int32)123456;
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

            Log.Comment("Verifying reference type behavior...");
            objA = new Int32Value(validValue);
            objB = new Int32Value(validValue);
            Log.VerifyFalse(Object.Equals(objA, objB), "Two instances with same value but constructed seperated are Equal.");
            objA = new Int32Value(validValue);
            objB = objA;
            Log.VerifyTrue(Object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Log.VerifyTrue(Object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Log.Comment("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new Int32Value(a); });

            Log.Comment("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            Int32 val = default(Int32);
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Log.Comment("ErrorHandling: Set InnerText with invalid value...");
            objA = new Int32Value();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => actionOfCompare(a, b));
        }

        [Fact]
        public void UInt64ValueTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            UInt64 defaultValue = default(UInt64);
            UInt64 maxValue = UInt64.MaxValue;
            UInt64 minValue = UInt64.MinValue;
            UInt64 validValue = (UInt64)123456;
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

            Log.Comment("Verifying reference type behavior...");
            objA = new UInt64Value(validValue);
            objB = new UInt64Value(validValue);
            Log.VerifyFalse(Object.Equals(objA, objB), "Two instances with same value but constructed seperated are Equal.");
            objA = new UInt64Value(validValue);
            objB = objA;
            Log.VerifyTrue(Object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Log.VerifyTrue(Object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Log.Comment("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new UInt64Value(a); });

            Log.Comment("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            UInt64 val = default(UInt64);
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Log.Comment("ErrorHandling: Set InnerText with invalid value...");
            objA = new UInt64Value();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => actionOfCompare(a, b));
        }

        [Fact]
        public void Int64ValueTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            Int64 defaultValue = default(Int64);
            Int64 maxValue = Int64.MaxValue;
            Int64 minValue = Int64.MinValue;
            Int64[] testValues = new Int64[] { Int64.MaxValue, Int64.MinValue, Int32.MaxValue, Int32.MinValue, 0 };
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

                Log.Comment("Verifying reference type behavior...");
                objA = new Int64Value(testValue);
                objB = new Int64Value(testValue);
                Log.VerifyFalse(Object.Equals(objA, objB), "Two instances with same value but constructed seperated are Equal.");
                objA = new Int64Value(testValue);
                objB = objA;
                Log.VerifyTrue(Object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
                Log.VerifyTrue(Object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");
            }

            Log.Comment("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new Int64Value(a); });

            Log.Comment("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            Int64 val = default(Int64);
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Log.Comment("ErrorHandling: Set InnerText with invalid value...");
            objA = new Int64Value();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => actionOfCompare(a, b));
        }

        [Fact]
        public void IntegerValueTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            Int64 defaultValue = default(Int64);
            Int64 maxValue = Int64.MaxValue;
            Int64 minValue = Int64.MinValue;
            Int64[] testValues = new Int64[] { Int64.MaxValue, Int64.MinValue, Int32.MaxValue, Int32.MinValue, 0 };
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

                Log.Comment("Verifying reference type behavior...");
                objA = new IntegerValue(testValue);
                objB = new IntegerValue(testValue);
                Log.VerifyFalse(Object.Equals(objA, objB), "Two instances with same value but constructed seperated are Equal.");
                objA = new IntegerValue(testValue);
                objB = objA;
                Log.VerifyTrue(Object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
                Log.VerifyTrue(Object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");
            }

            Log.Comment("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new IntegerValue(a); });

            Log.Comment("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            Int64 val = default(Int64);
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Log.Comment("ErrorHandling: Set InnerText with invalid value...");
            objA = new IntegerValue();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => actionOfCompare(a, b));
        }

        [Fact]
        public void DecimalValueTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            Decimal defaultValue = default(Decimal);
            Decimal maxValue = Decimal.MaxValue;
            Decimal minValue = Decimal.MinValue;
            Decimal specialValue1 = Decimal.MinusOne;
            Decimal specialValue2 = Decimal.One;
            Decimal specialValue3 = Decimal.Zero;
            // Decimal validValue = (decimal)(new Random ().Next(0, 10) * (maxValue / 100 - minValue / 100) + minValue / 10);
            Decimal validValue = (decimal)123.456;
            string invalidValue = "Invalid String!";

            Log.Comment("Testing default value...");
            string expectedText = defaultValue.ToString();
            DecimalValue defaultObj = default(DecimalValue);
            Log.VerifyNull(defaultObj, "default(DecimalValue) returns reference other than NULL");

            Log.Comment("Constructing with Max value and testing...");
            simpleValueValidTest(new DecimalValue(maxValue), maxValue, maxValue.ToString());

            Log.Comment("Constructing with Max value and testing with Clone()...");
            simpleValueValidTest(new DecimalValue(maxValue).Clone() as DecimalValue, maxValue, maxValue.ToString());

            Log.Comment("Set Value with Min value and testing...");
            DecimalValue objA = new DecimalValue();
            objA.Value = minValue;
            simpleValueValidTest(objA, minValue, minValue.ToString());

            Log.Comment("Set InnerText with Min value and testing...");
            DecimalValue objB = new DecimalValue();
            objB.InnerText = minValue.ToString();
            simpleValueValidTest(objB, minValue, minValue.ToString());

            Log.Comment("Implicit Int Operator with Min value and testing...");
            objB = minValue;
            simpleValueValidTest(objB, minValue, minValue.ToString());

            Log.Comment("Explicit decimal conversion with value {0} and testing", validValue);
            objB = DecimalValue.FromDecimal(validValue);
            Log.VerifyTrue(DecimalValue.ToDecimal(objB) == validValue, "FromDecimal() value doesn't equal to ToDecimal() value!");

            Log.Comment("Constructing with another instance with valid value...");
            objA = new DecimalValue(validValue);
            simpleValueValidTest(new DecimalValue(objA), validValue, validValue.ToString());

            Log.Comment("Constructing with special value {0} and testing...", specialValue1);
            simpleValueValidTest(new DecimalValue(specialValue1), specialValue1, specialValue1.ToString());

            Log.Comment("Constructing with special value {0} and testing...", specialValue2);
            simpleValueValidTest(new DecimalValue(specialValue2), specialValue2, specialValue2.ToString());

            Log.Comment("Constructing with special value {0} and testing...", specialValue3);
            simpleValueValidTest(new DecimalValue(specialValue3), specialValue3, specialValue3.ToString());

            Log.Comment("Verifying reference type behavior...");
            objA = new DecimalValue(validValue);
            objB = new DecimalValue(validValue);
            Log.VerifyFalse(Object.Equals(objA, objB), "Two instances with same value but constructed seperated are Equal.");
            objA = new DecimalValue(validValue);
            objB = objA;
            Log.VerifyTrue(Object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Log.VerifyTrue(Object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Log.Comment("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new DecimalValue(a); });

            Log.Comment("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            Decimal val = default(Decimal);
            InvalidOperation(objA, val, (a, b) => { b = a; });

            Log.Comment("ErrorHandling: Set InnerText with invalid value...");
            objA = new DecimalValue();
            objA.InnerText = invalidValue;
            InvalidOperation(objA, invalidValue, (a, b) => actionOfCompare(a, b));
        }

        [Fact]
        public void SingleValueTest()
        {
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            Single defaultValue = default(Single);
            Single maxValue = Single.MaxValue;
            Single minValue = Single.MinValue;
            Single validValue = (Single)123.456;
            Single specialEpsilon = Single.Epsilon;
            Single specialPositiveInfinity = Single.PositiveInfinity;
            Single specialNegativeInfinity = Single.NegativeInfinity;
            Single specialNaN = Single.NaN;
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
            simpleValueValidTest(new SingleValue(maxValue), maxValue, maxValue.ToString("R"));

            Log.Comment("Constructing with Max value and testing with Clone()...");
            simpleValueValidTest(new SingleValue(maxValue).Clone() as SingleValue, maxValue, maxValue.ToString("R"));

            Log.Comment("Set Value with Min value and testing...");
            SingleValue objA = new SingleValue();
            objA.Value = minValue;
            simpleValueValidTest(objA, minValue, minValue.ToString("R"));

            Log.Comment("Set InnerText with Min value and testing...");
            SingleValue objB = new SingleValue();
            objB.InnerText = minValue.ToString("R");
            simpleValueValidTest(objB, minValue, minValue.ToString("R"));

            Log.Comment("Implicit Int Operator with Min value and testing...");
            objB = minValue;
            simpleValueValidTest(objB, minValue, minValue.ToString("R"));

            Log.Comment("Explicit SingleValue conversion with value {0} and testing", validValue);
            objB = SingleValue.FromSingle(validValue);
            Log.VerifyTrue(SingleValue.ToSingle(objB) == validValue, "SingleValue() value doesn't equal to ToSingle() value!");

            Log.Comment("Constructing with another instance with valid value...");
            objA = new SingleValue(validValue);
            simpleValueValidTest(new SingleValue(objA), validValue, validValue.ToString("R"));

            Log.Comment("Constructing with special value {0} and testing...", specialEpsilon);
            simpleValueValidTest(new SingleValue(specialEpsilon), specialEpsilon, specialEpsilon.ToString("R"));

            Log.Comment("Constructing with special value {0} and testing...", specialPositiveInfinity);
            simpleValueValidTest(new SingleValue(specialPositiveInfinity), specialPositiveInfinity, PositiveInfinity);

            Log.Comment("Constructing with special value {0} and testing...", specialNegativeInfinity);
            simpleValueValidTest(new SingleValue(specialNegativeInfinity), specialNegativeInfinity, NegativeInfinity);

            Log.Comment("Constructing with special value {0} and testing...", specialNaN);
            simpleValueValidTest(new SingleValue(specialNaN), specialNaN, specialNaN.ToString("R"));

            Log.Comment("Set InnerText with special value {0} and testing...", specialStringINF);
            objA = new SingleValue();
            objA.InnerText = specialStringINF;
            simpleValueValidTest(objA, Single.PositiveInfinity, specialStringINF);

            Log.Comment("Set InnerText with special value {0} and testing...", specialStringNINF);
            objA = new SingleValue();
            objA.InnerText = specialStringNINF;
            simpleValueValidTest(objA, Single.NegativeInfinity, specialStringNINF);

            Log.Comment("Set InnerText with special value {0} and testing...", specialStringInfinity);
            objA = new SingleValue();
            objA.InnerText = specialStringInfinity;
            simpleValueValidTest(objA, Single.PositiveInfinity, specialStringInfinity);

            Log.Comment("Set InnerText with special value {0} and testing...", specialStringNInfinity);
            objA = new SingleValue();
            objA.InnerText = specialStringNInfinity;
            simpleValueValidTest(objA, Single.NegativeInfinity, specialStringNInfinity);

            Log.Comment("Verifying reference type behavior...");
            objA = new SingleValue(validValue);
            objB = new SingleValue(validValue);
            Log.VerifyFalse(Object.Equals(objA, objB), "Two instances with same value but constructed seperated are Equal.");
            objA = new SingleValue(validValue);
            objB = objA;
            Log.VerifyTrue(Object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Log.VerifyTrue(Object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Log.Comment("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new SingleValue(a); });

            Log.Comment("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            Single val = default(Single);
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
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            Double defaultValue = default(Double);
            Double maxValue = Double.MaxValue;
            Double minValue = Double.MinValue;
            Double validValue = (double)123.456;
            Double specialEpsilon = Double.Epsilon;
            Double specialPositiveInfinity = Double.PositiveInfinity;
            Double specialNegativeInfinity = Double.NegativeInfinity;
            Double specialNaN = Double.NaN;
            const string NegativeInfinity = "-INF";
            const string PositiveInfinity = "INF";
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
            DoubleValue defaultObj = default(DoubleValue);
            Log.VerifyNull(defaultObj, "default(DoubleValue) returns reference other than NULL");

            Log.Comment("Constructing with Max value and testing...");
            simpleValueValidTest(new DoubleValue(maxValue), maxValue, maxValue.ToString("R"));

            Log.Comment("Constructing with Max value and testing with Clone()...");
            simpleValueValidTest(new DoubleValue(maxValue).Clone() as DoubleValue, maxValue, maxValue.ToString("R"));

            Log.Comment("Set Value with Min value and testing...");
            DoubleValue objA = new DoubleValue();
            objA.Value = minValue;
            simpleValueValidTest(objA, minValue, minValue.ToString("R"));

            Log.Comment("Set InnerText with Min value and testing...");
            DoubleValue objB = new DoubleValue();
            objB.InnerText = minValue.ToString("R");
            simpleValueValidTest(objB, minValue, minValue.ToString("R"));

            Log.Comment("Implicit Int Operator with Min value and testing...");
            objB = minValue;
            simpleValueValidTest(objB, minValue, minValue.ToString("R"));

            Log.Comment("Explicit Double conversion with value {0} and testing", validValue);
            objB = DoubleValue.FromDouble(validValue);
            Log.VerifyTrue(DoubleValue.ToDouble(objB) == validValue, "FromDouble() value doesn't equal to ToDouble() value!");

            Log.Comment("Constructing with another instance with valid value...");
            objA = new DoubleValue(validValue);
            simpleValueValidTest(new DoubleValue(objA), validValue, validValue.ToString("R"));

            Log.Comment("Constructing with special value {0} and testing...", specialEpsilon);
            simpleValueValidTest(new DoubleValue(specialEpsilon), specialEpsilon, specialEpsilon.ToString("R"));

            Log.Comment("Constructing with special value {0} and testing...", specialPositiveInfinity);
            simpleValueValidTest(new DoubleValue(specialPositiveInfinity), specialPositiveInfinity, PositiveInfinity);

            Log.Comment("Constructing with special value {0} and testing...", specialNegativeInfinity);
            simpleValueValidTest(new DoubleValue(specialNegativeInfinity), specialNegativeInfinity, NegativeInfinity);

            Log.Comment("Constructing with special value {0} and testing...", specialNaN);
            simpleValueValidTest(new DoubleValue(specialNaN), specialNaN, specialNaN.ToString("R"));

            Log.Comment("Set InnerText with special value {0} and testing...", specialStringINF);
            objA = new DoubleValue();
            objA.InnerText = specialStringINF;
            simpleValueValidTest(objA, Double.PositiveInfinity, specialStringINF);

            Log.Comment("Set InnerText with special value {0} and testing...", specialStringNINF);
            objA = new DoubleValue();
            objA.InnerText = specialStringNINF;
            simpleValueValidTest(objA, Double.NegativeInfinity, specialStringNINF);

            Log.Comment("Set InnerText with special value {0} and testing...", specialStringInfinity);
            objA = new DoubleValue();
            objA.InnerText = specialStringInfinity;
            simpleValueValidTest(objA, Double.PositiveInfinity, specialStringInfinity);

            Log.Comment("Set InnerText with special value {0} and testing...", specialStringNInfinity);
            objA = new DoubleValue();
            objA.InnerText = specialStringNInfinity;
            simpleValueValidTest(objA, Double.NegativeInfinity, specialStringNInfinity);

            Log.Comment("Verifying reference type behavior...");
            objA = new DoubleValue(validValue);
            objB = new DoubleValue(validValue);
            Log.VerifyFalse(Object.Equals(objA, objB), "Two instances with same value but constructed seperated are Equal.");
            objA = new DoubleValue(validValue);
            objB = objA;
            Log.VerifyTrue(Object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Log.VerifyTrue(Object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

            Log.Comment("ErrorHandling: Constructing with another instance of null...");
            objA = null;
            objB = null;
            InvalidOperation(objA, objB, (a, b) => { b = new DoubleValue(a); });

            Log.Comment("ErrorHandling: Implicit Int operator on null reference...");
            objA = null;
            Double val = default(Double);
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
            this.MyTestInitialize(TestContext.GetCurrentMethod());
            DateTime defaultValue = default(DateTime);
            DateTime maxValue = DateTime.MaxValue;
            DateTime minValue = DateTime.MinValue;
            //var ratio = (decimal)new Random ().Next(0, 100) / 100;
            var ratio = (decimal)0.5;
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

            Log.Comment("Verifying reference type behavior...");
            objA = new DateTimeValue(validValue);
            objB = new DateTimeValue(validValue);
            Log.VerifyFalse(Object.Equals(objA, objB), "Two instances with same value but constructed seperated are Equal.");
            objA = new DateTimeValue(validValue);
            objB = objA;
            Log.VerifyTrue(Object.ReferenceEquals(objA, objB), "Assigned instance is NOT reference equal to original one.");
            Log.VerifyTrue(Object.Equals(objA, objB), "Assigned instance is NOT equal to original one.");

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

        private void simpleValueValidTestNonGeneric(Int32Value oxObj, Int32 expectedValue, string expectedText)
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

            Int32 val = oxObj;
            Log.VerifyValue(val, expectedValue,
                "int operator result {0} does NOT equal to expected value {1}.", val, expectedValue);

            val = oxObj as OpenXmlSimpleValue<Int32>;
            Log.VerifyValue(val, expectedValue,
                "int operator result {0} does NOT equal to expected value {1}.", val, expectedValue);

            Log.Comment("Leaving Non-Generic Test Method...");
        }
        #endregion Common Functions
    }
}