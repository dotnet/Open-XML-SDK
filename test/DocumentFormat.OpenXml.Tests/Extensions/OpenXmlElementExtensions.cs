// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Tests
{
    public static class OpenXmlElementExtensions
    {
        /// <summary> Set event handler on pass-in element's OpenXmlElementContext.</summary>
        /// <param name="e">current element</param>
        /// <param name="handler">event handler to be hooked on</param>
        /// <returns>current element with event handlers hooked</returns>
        public static OpenXmlElement SetEventHandler(this OpenXmlElement e, Func<OpenXmlElement, OpenXmlElement> attachHandlerTo)
        {
            if (e is null)
            {
                return e;
            }

            return attachHandlerTo(e);
        }

        /// <summary>
        /// Get PartRootElement of current element
        /// </summary>
        /// <param name="element">current element</param>
        /// <returns>Part root element of current element, null if root element is not of OpenXmlPartRootElement.</returns>
        public static OpenXmlPartRootElement PartRootElement(this OpenXmlElement element)
        {
            if (element is null)
            {
                throw new ArgumentNullException(nameof(element));
            }

            if (element is OpenXmlPartRootElement)
            {
                return element as OpenXmlPartRootElement;
            }

            return element.Ancestors<OpenXmlPartRootElement>().FirstOrDefault();
        }

        /// <summary>
        /// Get index of specified element in the ChildElement of parent element.
        /// </summary>
        /// <param name="element">element in question</param>
        /// <returns>index of pass-in element, 0 for root/orphan element</returns>
        public static int Index(this OpenXmlElement element)
        {
            if (element is null)
            {
                throw new ArgumentNullException(nameof(element));
            }

            // root/orphan element itself
            if (element.Parent is null)
            {
                return 0;
            }

            return element.Parent.ChildElements.TakeWhile(c => element != c).Count();
        }

        /// <summary>
        /// Get path to specified element.
        /// </summary>
        /// <param name="element">element in question</param>
        /// <returns>path to specified element</returns>
        public static string Path(this OpenXmlElement element)
        {
            if (element is null)
            {
                throw new ArgumentNullException(nameof(element));
            }

            var path = string.Format(@"/{0}@{1}", element.LocalName, element.Index());

            return element.Ancestors().Aggregate(path, (s, a) => string.Format(@"/{0}@{1}", a.LocalName, a.Index()) + s);
        }

        /// <summary>
        /// Get name of element in <w:p> fashion.
        /// </summary>
        /// <param name="element">element in question</param>
        /// <returns>name of element in <w:p> format</returns>
        public static string GetFullName(this OpenXmlElement element)
        {
            if (element is null)
            {
                throw new ArgumentNullException(nameof(element));
            }

            if (string.IsNullOrEmpty(element.Prefix))
            {
                return element.LocalName;
            }

            return string.Format("{0}:{1}", element.Prefix, element.LocalName);
        }

        /// <summary>
        /// Retrieve built-in OpenXmlAttributes of the type of pass-in OpenXmlElement
        /// </summary>
        /// <param name="e">OpenXmlElement or derived classes that has properties with SchemaAttrAttribute</param>
        /// <returns>IEnumerable<OpenXmlAttribute> for fixed attributes of type of pass-in OpenXmlElement</returns>
        public static IEnumerable<OpenXmlAttribute> GetFixedAttributes(this OpenXmlElement e)
        {
            if (e is null)
            {
                yield break;
            }

            foreach (var attribute in e.ParsedState.Attributes)
            {
                var qname = attribute.Property.QName;
                var prefix = e.Features.GetNamespaceResolver().LookupPrefix(qname.Namespace.Uri) ?? string.Empty;

                yield return new OpenXmlAttribute(qname, prefix, attribute.Value?.InnerText);
            }
        }

        /// <summary>
        /// Get XName of pass-in OpenXmlElement.
        /// </summary>
        /// <param name="element">element in question</param>
        /// <returns>XName of pass-in OpenXmlElement</returns>
        public static XName GetXName(this OpenXmlElement element)
        {
            if (element is null)
            {
                throw new ArgumentNullException(nameof(element));
            }

            XNamespace xns = element.NamespaceUri;
            return xns + element.LocalName;
        }

        /// <summary>
        /// Convert an OpenXmlElement to an XElement using its OuterXml
        /// </summary>
        /// <param name="element">OpenXml element to be converted</param>
        /// <returns>XElement for specified OpenXmlElement</returns>
        public static XElement ToXElement(this OpenXmlElement element)
        {
            if (element is null)
            {
                throw new ArgumentNullException(nameof(element));
            }

            return XElement.Parse(element.OuterXml);
        }

        public static OpenXmlElement SetIgnorable(this OpenXmlElement element, string prefix)
        {
            if (element is null)
            {
                throw new ArgumentNullException(nameof(element));
            }

            var mc = element.MCAttributes;
            if (mc is null)
            {
                mc = new MarkupCompatibilityAttributes();
            }

            if (mc.Ignorable is null)
            {
                mc.Ignorable = prefix;
            }
            else
            {
                mc.Ignorable = string.Join(" ", new string[] { mc.Ignorable, prefix });
            }

            element.MCAttributes = mc;
            return element;
        }

        public static OpenXmlElement SetMustUnderstand(this OpenXmlElement element, string prefix)
        {
            if (element is null)
            {
                throw new ArgumentNullException(nameof(element));
            }

            var mc = element.MCAttributes;
            if (mc is null)
            {
                mc = new MarkupCompatibilityAttributes();
            }

            if (mc.MustUnderstand is null)
            {
                mc.MustUnderstand = prefix;
            }
            else
            {
                mc.MustUnderstand = string.Join(" ", new string[] { mc.MustUnderstand, prefix });
            }

            element.MCAttributes = mc;
            return element;
        }

        public static OpenXmlElement SetPreserveAttributes(this OpenXmlElement element, string qualified)
        {
            if (element is null)
            {
                throw new ArgumentNullException(nameof(element));
            }

            var mc = element.MCAttributes;
            if (mc is null)
            {
                mc = new MarkupCompatibilityAttributes();
            }

            if (mc.PreserveAttributes is null)
            {
                mc.PreserveAttributes = qualified;
            }
            else
            {
                mc.PreserveAttributes = string.Join(" ", new string[] { mc.PreserveAttributes, qualified });
            }

            element.MCAttributes = mc;
            return element;
        }

        public static OpenXmlElement SetPreserveElements(this OpenXmlElement element, string qualified)
        {
            if (element is null)
            {
                throw new ArgumentNullException(nameof(element));
            }

            var mc = element.MCAttributes;
            if (mc is null)
            {
                mc = new MarkupCompatibilityAttributes();
            }

            if (mc.PreserveElements is null)
            {
                mc.PreserveElements = qualified;
            }
            else
            {
                mc.PreserveElements = string.Join(" ", new string[] { mc.PreserveElements, qualified });
            }

            element.MCAttributes = mc;
            return element;
        }

        public static OpenXmlElement SetProcessContent(this OpenXmlElement element, string qualified)
        {
            if (element is null)
            {
                throw new ArgumentNullException(nameof(element));
            }

            var mc = element.MCAttributes;
            if (mc is null)
            {
                mc = new MarkupCompatibilityAttributes();
            }

            if (mc.ProcessContent is null)
            {
                mc.ProcessContent = qualified;
            }
            else
            {
                mc.ProcessContent = string.Join(" ", new string[] { mc.ProcessContent, qualified });
            }

            element.MCAttributes = mc;
            return element;
        }

        public static AlternateContentChoice SetRequires(this AlternateContentChoice choice, string prefix)
        {
            if (choice is null)
            {
                throw new ArgumentNullException(nameof(choice));
            }

            if (choice.Requires is null)
            {
                choice.Requires = prefix;
            }
            else
            {
                choice.Requires = string.Join(" ", new string[] { choice.Requires, prefix });
            }

            return choice;
        }
    }
}
