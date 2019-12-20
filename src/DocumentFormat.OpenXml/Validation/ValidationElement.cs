// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System;

namespace DocumentFormat.OpenXml.Validation
{
    internal readonly struct ValidationElement
    {
        public ValidationElement(
            OpenXmlSimpleType value,
            ElementProperty<OpenXmlSimpleType> property,
            bool isAttribute,
            Action<ValidationErrorInfo> addError)
        {
            Value = value;
            Property = property;
            IsAttribute = isAttribute;
            AddError = addError;
        }

        public OpenXmlSimpleType Value { get; }

        public ElementProperty<OpenXmlSimpleType> Property { get; }

        public bool IsAttribute { get; }

        public Action<ValidationErrorInfo> AddError { get; }
    }
}
