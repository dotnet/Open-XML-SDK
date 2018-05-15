// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using Xunit;
using Xunit.Abstractions;

namespace LogUtil
{
    public class VerifiableLog
    {
        private readonly ITestOutputHelper _output;

        public VerifiableLog(ITestOutputHelper output)
        {
            _output = output;
        }

        /// <summary>
        /// Produce a comment in "script" category
        /// </summary>
        /// <param name="message">Message containing zero or more format specifications</param>
        /// <param name="arguments">List of objects to be formatted</param>
        public void Comment(string message, params object[] arguments)
        {
            _output.WriteLine(string.Format(message, arguments));
        }

        /// <summary>
        /// Logs explicit Fail in "script" category
        /// </summary>
        /// <param name="message">Message containing zero or more format specifications</param>
        /// <param name="arguments">List of objects to be formatted</param>
        public void Fail(string message, params object[] arguments)
        {
            var formatted = string.Format(message, arguments);

            _output.WriteLine($"Error: {formatted}");

            // TODO: Remove Fail method and replace directly with Assert
            Assert.True(false, formatted);
        }

        public void Fail(string message)
        {
            _output.WriteLine(message);

            // TODO: Remove Fail method and replace directly with Assert
            Assert.True(false, message);
        }

        /// <summary>
        /// Logs explicit Pass in "script" category
        /// </summary>
        /// <param name="message">Message containing zero or more format specifications</param>
        /// <param name="arguments">List of objects to be formatted</param>
        public void Pass(string message, params object[] arguments)
        {
            LogPass(string.Format(message, arguments));
        }

        public void Pass(string message)
        {
            LogPass(message);
        }

        /// <summary>
        /// Implementation of logging a pass.
        /// </summary>
        /// <param name="message"></param>
        private void LogPass(string message)
        {
            _output.WriteLine(message);
        }

        /// <summary>
        /// Log pass or fail based on the boolean value of a test in "script" category. Message to associate with the Verify if the test fails
        /// Typically this method should not be used. Use the VerifyValue methods instead
        /// </summary>
        /// <param name="pass">true - pass, false - fail</param>
        /// <param name="message">Message containing zero or more format specifications</param>
        /// <param name="arguments">List of objects to be formatted</param>
        public void Verify(bool pass, string message, params object[] arguments)
        {
            VerifyTrue(pass, message, arguments);
        }

        public void Verify(bool pass, string message)
        {
            VerifyTrue(pass, message);
        }

        /// <summary>
        /// Tests whether the input parameter is false. Passing an expression that evaluates to false is considered a success,
        /// but passing an expression that evaluates to true is considered a failure. Message to associate with the Verify if
        /// the test fails
        /// </summary>
        /// <param name="pass">Expression to evaluate.  Determines whether the test passes</param>
        /// <param name="message">Message containing zero or more format specifications</param>
        /// <param name="arguments">List of objects to be formatted</param>
        public void VerifyFalse(bool pass, string message, params object[] arguments)
        {
            if (pass)
                Fail(message, arguments);
            else
                Pass(message, arguments);
        }

        public void VerifyFalse(bool pass, string message)
        {
            if (pass)
                Fail(message);
            else
                Pass(message);
        }

        public void VerifyNull(object test, string message)
        {
            VerifyValue(test, null, message);
        }

        /// <summary>
        /// Tests whether the input parameter is true
        /// </summary>
        /// <param name="pass">Expression to evaluate.  Determines whether the test passes</param>
        /// <param name="message">Message to associate with the Verify if the test fails</param>
        /// <param name="arguments">List of objects to be formatted</param>
        public void VerifyTrue(bool pass, string message, params object[] arguments)
        {
            if (pass)
                Pass(message, arguments);
            else
                Fail(message, arguments);
        }

        public void VerifyTrue(bool pass, string message)
        {
            if (pass)
                Pass(message);
            else
                Fail(message);
        }

        /// <summary>
        /// VerifyValue Method Tests that two input parameters have equal values. If the two input objects have equal values, the test is considered a success.
        /// If the two input objects differ, the test is considered to fail
        /// </summary>
        /// <param name="actualValue">The actual value returned by the test subject</param>
        /// <param name="expectedValue">The value that the test subject is supposed to return</param>
        /// <param name="message">Message to associate with the Verify if the test fails</param>
        /// <param name="arguments">List of objects to be formatted</param>
        public void VerifyValue(IComparable actualValue, IComparable expectedValue, string message, params object[] arguments)
        {
            var messageModified = string.Format("{0} [Actual: {1}, Expected: {2}]", message, actualValue, expectedValue);
            VerifyTrue(object.Equals(actualValue, expectedValue), messageModified, arguments);
        }

        public void VerifyValue(IComparable actualValue, IComparable expectedValue, string message)
        {
            var messageModified = string.Format("{0} [Actual: {1}, Expected: {2}]", message, actualValue, expectedValue);
            VerifyTrue(object.Equals(actualValue, expectedValue), messageModified);
        }

        public void VerifyValue(object actualValue, object expectedValue, string message)
        {
            var messageModified = string.Format("{0} [Actual: {1}, Expected: {2}]", message, actualValue, expectedValue);
            VerifyTrue(object.Equals(actualValue, expectedValue), messageModified);
        }

        /// <summary>
        /// Produce a warning in "script" category
        /// </summary>
        /// <param name="message">Warning message to display</param>
        /// <param name="arguments">List of objects to be formatted</param>
        public void Warning(string message, params object[] arguments)
        {
            var m = string.Format(message, arguments);

            _output.WriteLine($"Warning: {m}");
        }
    }
}
