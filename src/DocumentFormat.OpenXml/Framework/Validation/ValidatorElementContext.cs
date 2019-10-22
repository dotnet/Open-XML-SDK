// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;
using System;
using System.Xml;

namespace DocumentFormat.OpenXml.Framework
{
    internal readonly ref struct ValidatorElementContext
    {
        private readonly ValidationContext _validationContext;
        private readonly ElementProperty<OpenXmlSimpleType> _state;
        private readonly Action<ValidationErrorInfo> _addError;

        public ValidatorElementContext(OpenXmlSimpleType value, ValidationContext validationContext, ElementProperty<OpenXmlSimpleType> state, bool isAttribute, Action<ValidationErrorInfo> addError)
        {
            _validationContext = validationContext;
            _state = state;
            _addError = addError;

            Value = value;
            IsAttribute = isAttribute;
        }

        public MCContext McContext => _validationContext.McContext;

        public ValidatorElementContext With(Action<ValidationErrorInfo> addError)
        {
            return new ValidatorElementContext(Value, _validationContext, _state, IsAttribute, addError);
        }

        public bool IsAttribute { get; }

        public XmlQualifiedName QName => _state.GetQName();

        public XmlQualifiedName TypeQName => _state.TypeName;

        public OpenXmlSimpleType Value { get; }

        public FileFormatVersions Version => _validationContext.FileFormat;

        public void AddError(ValidationErrorInfo error) => _addError(error);

        public void AddError(string id, ValidationErrorType errorType, string description = null)
        {
            var error = new ValidationErrorInfo
            {
                Id = id,
                Description = description,
                Part = _validationContext.Part,
                ErrorType = errorType,
                Node = _validationContext.Element,
            };

            AddError(error);
        }
    }
}
