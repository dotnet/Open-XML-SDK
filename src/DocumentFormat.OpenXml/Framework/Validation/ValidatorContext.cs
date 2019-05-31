// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation;
using System;
using System.Xml;

namespace DocumentFormat.OpenXml.Framework
{
    internal readonly struct ValidatorContext
    {
        private readonly ElementProperty<OpenXmlSimpleType> _state;
        private readonly OpenXmlPart _part;
        private readonly OpenXmlElement _element;
        private readonly Action<ValidationErrorInfo> _addError;

        public ValidatorContext(OpenXmlSimpleType value, FileFormatVersions version, OpenXmlPart part, OpenXmlElement element, ElementProperty<OpenXmlSimpleType> state, bool isAttribute, MCContext mcCtx, Action<ValidationErrorInfo> addError)
        {
            Value = value;
            Version = version;
            IsAttribute = isAttribute;
            McContext = mcCtx;

            _state = state;
            _part = part;
            _element = element;
            _addError = addError;
        }

        public MCContext McContext { get; }

        public ValidatorContext With(Action<ValidationErrorInfo> addError)
        {
            return new ValidatorContext(Value, Version, _part, _element, _state, IsAttribute, McContext, addError);
        }

        public bool IsAttribute { get; }

        public XmlQualifiedName QName => _state.GetQName();

        public XmlQualifiedName TypeQName => _state.TypeName;

        public OpenXmlSimpleType Value { get; }

        public FileFormatVersions Version { get; }

        public void AddError(ValidationErrorInfo error) => _addError(error);

        public void CreateError(string id, ValidationErrorType errorType, string description = null)
        {
            var error = new ValidationErrorInfo
            {
                Id = id,
                Description = description,
                Part = _part,
                ErrorType = errorType,
                Node = _element,
            };

            AddError(error);
        }
    }
}
