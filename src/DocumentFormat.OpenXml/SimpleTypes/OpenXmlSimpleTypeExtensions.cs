// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Xml;

namespace DocumentFormat.OpenXml.Framework
{
    internal static class OpenXmlSimpleTypeExtensions
    {
        private static readonly Dictionary<Type, XmlQualifiedName> _simpleTypeMapping = new Dictionary<Type, XmlQualifiedName>
        {
            { typeof(Base64BinaryValue), new XmlQualifiedName("base64Binary", "http://www.w3.org/2001/XMLSchema") },
            { typeof(BooleanValue), new XmlQualifiedName("Boolean") },
            { typeof(ByteValue), new XmlQualifiedName("Byte") },
            { typeof(DateTimeValue), new XmlQualifiedName("DateTime") },
            { typeof(DecimalValue), new XmlQualifiedName("Decimal") },
            { typeof(DoubleValue), new XmlQualifiedName("Double") },
            { typeof(HexBinaryValue), new XmlQualifiedName("hexBinary", "http://www.w3.org/2001/XMLSchema") },
            { typeof(Int16Value), new XmlQualifiedName("Int16") },
            { typeof(Int32Value), new XmlQualifiedName("Int32") },
            { typeof(Int64Value), new XmlQualifiedName("Int64") },
            { typeof(IntegerValue), new XmlQualifiedName("integer", "http://www.w3.org/2001/XMLSchema") },
            { typeof(OnOffValue), new XmlQualifiedName("OnOff") },
            { typeof(SByteValue), new XmlQualifiedName("SByte") },
            { typeof(SingleValue), new XmlQualifiedName("Single") },
            { typeof(StringValue), new XmlQualifiedName("string") },
            { typeof(TrueFalseBlankValue), new XmlQualifiedName("TrueFalseBlank") },
            { typeof(TrueFalseValue), new XmlQualifiedName("TrueFalse") },
            { typeof(UInt16Value), new XmlQualifiedName("UInt16") },
            { typeof(UInt32Value), new XmlQualifiedName("UInt32") },
            { typeof(UInt64Value), new XmlQualifiedName("UInt64") },
        };

        public static XmlQualifiedName GetSimpleTypeQualifiedName(this Type type)
        {
            if (type != null && _simpleTypeMapping.TryGetValue(type, out var value))
            {
                return value;
            }

            return null;
        }

        public static XmlQualifiedName GetSimpleTypeQualifiedName(this ReadOnlyArray<IValidator> validators, Type type = null)
        {
            foreach (var validator in validators)
            {
                if (validator is INameProvider nameProvider && nameProvider?.QName is XmlQualifiedName qname)
                {
                    return qname;
                }
            }

            return type.GetSimpleTypeQualifiedName();
        }
    }
}
