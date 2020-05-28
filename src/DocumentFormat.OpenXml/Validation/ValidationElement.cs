// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using System;

namespace DocumentFormat.OpenXml.Validation
{
    internal class ValidationElement
    {
        public OpenXmlPackage Package { get; internal set; }

        public OpenXmlPart Part { get; internal set; }

        public OpenXmlElement Element { get; internal set; }

        public OpenXmlSimpleType Value { get; internal set; }

        public AttributeMetadata Property { get; internal set; }

        public bool IsAttribute { get; internal set; }

        public Action<ValidationErrorInfo> AddError { get; internal set; }

        internal void Clear()
        {
            Package = null;
            Part = null;
            Element = null;
            Value = null;
            Property = null;
            IsAttribute = false;
            AddError = null;
        }

        internal void CopyFrom(ValidationElement current)
        {
            if (current is null)
            {
                return;
            }

            Package = current.Package;
            Part = current.Part;
            Element = current.Element;
            Value = current.Value;
            Property = current.Property;
            IsAttribute = current.IsAttribute;
            AddError = current.AddError;
        }
    }
}
