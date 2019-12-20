// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using System;

namespace DocumentFormat.OpenXml.Validation
{
    internal readonly struct ValidationElement
    {
        public ValidationElement(
            OpenXmlPackage package,
            OpenXmlPart part,
            OpenXmlElement element,
            OpenXmlSimpleType value,
            ElementProperty<OpenXmlSimpleType> property,
            bool isAttribute,
            Action<ValidationErrorInfo> addError)
        {
            Package = package;
            Part = part;
            Element = element;
            Value = value;
            Property = property;
            IsAttribute = isAttribute;
            AddError = addError;
        }

        public OpenXmlPackage Package { get; }

        public OpenXmlPart Part { get; }

        public OpenXmlElement Element { get; }

        public OpenXmlSimpleType Value { get; }

        public ElementProperty<OpenXmlSimpleType> Property { get; }

        public bool IsAttribute { get; }

        public Action<ValidationErrorInfo> AddError { get; }
    }
}
