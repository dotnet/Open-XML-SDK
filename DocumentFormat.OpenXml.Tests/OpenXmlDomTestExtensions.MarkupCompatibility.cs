// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;

namespace DocumentFormat.OpenXml.Tests
{
    public static partial class OpenXmlDomTestExtensions
    {
        public static OpenXmlElement SetIgnorable(this OpenXmlElement element, string prefix)
        {
            if (element == null)
                throw new ArgumentNullException("element");

            var mc = element.MCAttributes;
            if (mc == null)
                mc = new MarkupCompatibilityAttributes();
            if (mc.Ignorable == null)
                mc.Ignorable = prefix;
            else
                mc.Ignorable = string.Join(" ", new string[] { mc.Ignorable, prefix });
            element.MCAttributes = mc;
            return element;
        }

        public static OpenXmlElement SetMustUnderstand(this OpenXmlElement element, string prefix)
        {
            if (element == null)
                throw new ArgumentNullException("element");

            var mc = element.MCAttributes;
            if (mc == null)
                mc = new MarkupCompatibilityAttributes();
            if (mc.MustUnderstand == null)
                mc.MustUnderstand = prefix;
            else
                mc.MustUnderstand = string.Join(" ", new string[] { mc.MustUnderstand, prefix });
            element.MCAttributes = mc;
            return element;
        }

        public static OpenXmlElement SetPreserveAttributes(this OpenXmlElement element, string qualified)
        {
            if (element == null)
                throw new ArgumentNullException("element");

            var mc = element.MCAttributes;
            if (mc == null)
                mc = new MarkupCompatibilityAttributes();
            if (mc.PreserveAttributes == null)
                mc.PreserveAttributes = qualified;
            else
                mc.PreserveAttributes = string.Join(" ", new string[] { mc.PreserveAttributes, qualified });
            element.MCAttributes = mc;
            return element;
        }

        public static OpenXmlElement SetPreserveElements(this OpenXmlElement element, string qualified)
        {
            if (element == null)
                throw new ArgumentNullException("element");

            var mc = element.MCAttributes;
            if (mc == null)
                mc = new MarkupCompatibilityAttributes();
            if (mc.PreserveElements == null)
                mc.PreserveElements = qualified;
            else
                mc.PreserveElements = string.Join(" ", new string[] { mc.PreserveElements, qualified });
            element.MCAttributes = mc;
            return element;
        }

        public static OpenXmlElement SetProcessContent(this OpenXmlElement element, string qualified)
        {
            if (element == null)
                throw new ArgumentNullException("element");

            var mc = element.MCAttributes;
            if (mc == null)
                mc = new MarkupCompatibilityAttributes();
            if (mc.ProcessContent == null)
                mc.ProcessContent = qualified;
            else
                mc.ProcessContent = string.Join(" ", new string[] { mc.ProcessContent, qualified });
            element.MCAttributes = mc;
            return element;
        }

        public static AlternateContentChoice SetRequires(this AlternateContentChoice choice, string prefix)
        {
            if (choice == null)
                throw new ArgumentNullException("element");

            if (choice.Requires == null)
                choice.Requires = prefix;
            else
                choice.Requires = string.Join(" ", new string[] { choice.Requires, prefix });
            return choice;
        }
    }
}
