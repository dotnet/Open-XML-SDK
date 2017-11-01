// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Tests
{
    public static partial class OpenXmlDomTestExtensions
    {
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
            List<String> True = new List<string>() { "1", "TRUE", "ON", "T" };
            List<String> False = new List<string>() { "0", "FALSE", "OFF", "F" };

            Double src = 0;

            if (True.Contains(source.Value.ToUpper()) && True.Contains(target.Value.ToUpper()))
                return true;
            else if (False.Contains(source.Value.ToUpper()) && False.Contains(target.Value.ToUpper()))
                return true;
            else if (Double.TryParse(source.Value, out src))
            {
                Double tgt = Double.Parse(target.Value);
                if (Double.IsNaN(src) && Double.IsNaN(tgt))
                    return true;
                else if (src != tgt)
                    return false;
            }
            else if (source.Name.LocalName == "ole")
            {
                if (source.Value == "" && !(False.Contains(target.Value.ToUpper())) && !(target.Value == ""))
                    return false;
            }
            else if (source.Value + "Z" == target.Value)
                return true;
            else
            {
                return source.Value.Equals(target.Value, StringComparison.OrdinalIgnoreCase);
            }
            return true;
        }
    }
}
