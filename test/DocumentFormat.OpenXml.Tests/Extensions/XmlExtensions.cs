// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Tests
{
    public static class XmlExtensions
    {
        private static readonly HashSet<string> True = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "1", "TRUE", "ON", "T" };
        private static readonly HashSet<string> False = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "0", "FALSE", "OFF", "F" };

        public static bool Compare(this XElement left, XElement right)
        {
            //Verify NameSpace
            if (left.Name.Namespace != right.Name.Namespace || left.Name.LocalName != right.Name.LocalName)
                return false;

            //Verify Values
            if (left.Value != right.Value)
                return false;

            //verify attributes
            if (right.Attributes().Count(x => x.IsNamespaceDeclaration == false) != left.Attributes().Count(x => x.IsNamespaceDeclaration == false))
                return false;

            foreach (XAttribute attr in left.Attributes().Where(x => x.IsNamespaceDeclaration == false))
            {
                if (right.Attribute(attr.Name) == null || !SpecialAttrValueCompare(attr, right.Attribute(attr.Name)))
                    return false;
            }

            //verify Child Elements
            if (left.HasElements != right.HasElements)
                return false;

            if (left.HasElements)
            {
                if (left.Elements().Count() != right.Elements().Count())
                    return false;

                for (int i = 0; i < left.Elements().Count(); i++)
                {
                    if (!left.Elements().ElementAt(i).Compare(right.Elements().ElementAt(i)))
                        return false;
                }
            }
            return true;
        }

        private static Boolean SpecialAttrValueCompare(XAttribute source, XAttribute target)
        {
            if (True.Contains(source.Value) && True.Contains(target.Value))
            {
                return true;
            }
            else if (False.Contains(source.Value) && False.Contains(target.Value))
            {
                return true;
            }
            else if (Double.TryParse(source.Value, out var src))
            {
                var tgt = Double.Parse(target.Value);

                if (Double.IsNaN(src) && Double.IsNaN(tgt))
                {
                    return true;
                }
                else if (src != tgt)
                {
                    return false;
                }
            }
            else if (source.Name.LocalName == "ole")
            {
                if (string.IsNullOrEmpty(source.Value) && !False.Contains(target.Value) && !string.IsNullOrEmpty(target.Value))
                {
                    return false;
                }
            }
            else if (source.Value + "Z" == target.Value)
            {
                return true;
            }
            else
            {
                return source.Value.Equals(target.Value, StringComparison.OrdinalIgnoreCase);
            }

            return true;
        }
    }
}
