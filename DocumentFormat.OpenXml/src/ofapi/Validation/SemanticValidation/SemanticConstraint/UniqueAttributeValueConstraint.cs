// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DocumentFormat.OpenXml.Validation;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Internal.SemanticValidation
{
    /// <summary>
    /// 2.3 Element's attribute value should be unique within specified type of element.
    /// </summary>
    internal class UniqueAttributeValueConstraint : SemanticConstraint
    {
        private byte _attribute;
        private Stack<List<string>> _stateStack = new Stack<List<string>>();
        private List<string> _values = new List<string>();
        private SemanticConstraintRegistry _reg;
        private bool _caseSensitive;
        private bool _partLevel;

        public UniqueAttributeValueConstraint(byte attribute, bool caseSensitive, bool partLevel, SemanticConstraintRegistry reg)
            : base(SemanticValidationLevel.Part)
        {
            _attribute = attribute;
            _reg = reg;
            _caseSensitive = caseSensitive;
            _partLevel = partLevel;
        }

        public override ValidationErrorInfo Validate(ValidationContext context)
        {
            if (_values == null)
            {
                return null;
            }
            
            OpenXmlSimpleType attributeValue = context.Element.Attributes[_attribute];

            //if the attribute is omited, semantic validation will do nothing 
            if (attributeValue == null || string.IsNullOrEmpty(attributeValue.InnerText))
            {
                return null;
            }

            if (_values.Where(v => string.Compare(v, attributeValue.InnerText, !_caseSensitive, System.Globalization.CultureInfo.InvariantCulture) == 0).Count() == 0)
            {
                _values.Add(attributeValue.InnerText);
                return null;
            }

            return new ValidationErrorInfo()
            {
                Id = "Sem_UniqueAttributeValue",
                ErrorType = ValidationErrorType.Semantic,
                Node = context.Element,
                Description = string.Format(System.Globalization.CultureInfo.CurrentUICulture, ValidationResources.Sem_UniqueAttributeValue,
                                            GetAttributeQualifiedName(context.Element, _attribute), attributeValue.InnerText)
            };
        }

        public void AdjustState()
        {
            if (_stateStack.Count() != 0)
            {
                _values = _stateStack.Pop();
            }
            else
            {
                _values = null;
            }
        }

        public override void ClearState(ValidationContext context)
        {
            if (context == null) //initialize before validating
            {
                _stateStack.Clear();
                _values = _partLevel ? new List<string>() : null;
            }
            else //unique scope element reached
            {
                if (_values != null)
                {
                    _stateStack.Push(_values);
                }
                _reg.AddCallBackMethod(context.Element, this.AdjustState);
                _values = new List<string>();
            }
        }
    }
}
