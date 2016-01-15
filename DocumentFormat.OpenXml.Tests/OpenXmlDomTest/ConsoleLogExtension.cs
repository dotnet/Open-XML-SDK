// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DocumentFormat.OpenXml.Tests
{
    static class ConsoleLogExtension
    {

        #region Log Extension

        static public void BeginGroup(this TextWriter writer, string message)
        {
            var prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Magenta;
            writer.WriteLine("Begin Group: {0}", message);
            Console.ForegroundColor = prevColor;
        }

        static public void EndGroup(this TextWriter writer, string message)
        {
            var prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Magenta;
            writer.WriteLine("End Group: {0}", message);
            Console.ForegroundColor = prevColor;
        }

        static public void Comment(this TextWriter writer, string message, params object[] arguments)
        {
            writer.WriteLine(message, arguments);
        }

        static public void Warning(this TextWriter writer, string message, params object[] arguments)
        {
            var prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            writer.WriteLine(message, arguments);
            Console.ForegroundColor = prevColor;
        }

        static public void Verify(this TextWriter writer, bool isTrue, string message, params object[] arguments)
        {
            writer.VerifyTrue(isTrue, message, arguments);
        }

        static public void VerifyTrue(this TextWriter writer, bool isTrue, string message, params object[] arguments)
        {
            if (isTrue)
                writer.Pass("PASS!", "");
            else
                writer.Fail(message, arguments);
        }

        static public void VerifyFalse(this TextWriter writer, bool isTrue, string message, params object[] arguments)
        {
            if (isTrue)
                writer.Fail(message, arguments);
            else
                writer.Pass("PASS!", " ");
        }

        static public void VerifyNull(this TextWriter writer, object obj, string message, params object[] arguments)
        {
            writer.VerifyTrue((obj == null), message, arguments);
        }

        static public void VerifyValue(this TextWriter writer, IComparable actualValue, IComparable expectedValue, string message, params object[] arguments)
        {
            writer.VerifyTrue(actualValue.CompareTo(expectedValue) == 0, message, arguments);
        }

        static public void Pass(this TextWriter writer, string message, params object[] arguments)
        {
            var prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            writer.WriteLine(message, arguments);
            Console.ForegroundColor = prevColor;
        }

        static public void Fail(this TextWriter writer, string message, params object[] arguments)
        {
            var prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            writer.WriteLine(message, arguments);
            Console.ForegroundColor = prevColor;

            // throw to notify failure...
            throw new Exception("TestMethod Failed.");
        }

        #endregion Log Extension

    }
}
