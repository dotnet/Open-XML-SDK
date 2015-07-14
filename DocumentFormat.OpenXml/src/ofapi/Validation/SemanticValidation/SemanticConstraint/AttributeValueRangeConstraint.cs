// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DocumentFormat.OpenXml.Validation;
using System.Diagnostics;
using System.Xml;

namespace DocumentFormat.OpenXml.Internal.SemanticValidation
{
    /// <summary>
    /// 1.3 Attribute value is a number, it must (or must not) in range of min to max.
    /// If valid/invalid values are not numbers or not contiguous, AttributeValueSetConstraint should be used.
    /// </summary>
    internal class AttributeValueRangeConstraint : SemanticConstraint
    {
        public byte _attribute;
        public bool _isValidRange; //"true" means attribute value must in range. And the meaning of "false" is opposite.
        public double _minValue;
        public double _maxValue;
        private bool _minInclusive;
        private bool _maxInclusive;

        public AttributeValueRangeConstraint(byte attribute, bool isValid, double minValue, bool minInclusive, double maxValue, bool maxInclusive)
            : base(SemanticValidationLevel.Element)
        {
            Debug.Assert(minValue <= maxValue);

            _attribute = attribute;
            _isValidRange = isValid;
            _minValue = minValue;
            _maxValue = maxValue;
            _minInclusive = minInclusive;
            _maxInclusive = maxInclusive;
        }

        public override ValidationErrorInfo Validate(ValidationContext context)
        {
            OpenXmlSimpleType attributeValue = context.Element.Attributes[_attribute];

            if (attributeValue == null || !attributeValue.HasValue || string.IsNullOrEmpty(attributeValue.InnerText))
            {
                return null;
            }

            double value;

            //If value cannot be converted into double, that means attribute type is not correct.
            //That's job of schema validation, semantic validation will do nothing to avoid throw duplicated error.
            if (!GetAttrNumVal(attributeValue, out value))
            {
                return null;
            }

            string minValueString;
            string maxValueString;

            if (attributeValue is HexBinaryValue)
            {
                minValueString = string.Format(System.Globalization.CultureInfo.CurrentUICulture, "{0:X}", (long)_minValue);
                maxValueString = string.Format(System.Globalization.CultureInfo.CurrentUICulture, "{0:X}", (long)_maxValue);
            }
            else
            {
                minValueString = _minValue.ToString(System.Globalization.CultureInfo.CurrentUICulture);
                maxValueString = _maxValue.ToString(System.Globalization.CultureInfo.CurrentUICulture);
            }

            string subMsg = null;

            if (_minInclusive)
            {
                if (!(this._minValue <= value))
                {
                    subMsg = string.Format(System.Globalization.CultureInfo.CurrentUICulture, ValidationResources.Sch_MinInclusiveConstraintFailed, minValueString);
                }
            }
            else
            {
                if (!(this._minValue < value))
                {
                    subMsg = string.Format(System.Globalization.CultureInfo.CurrentUICulture, ValidationResources.Sch_MinExclusiveConstraintFailed, minValueString);
                }
            }

            if (_maxInclusive)
            {
                if (!(value <= this._maxValue))
                {
                    subMsg = string.Format(System.Globalization.CultureInfo.CurrentUICulture, ValidationResources.Sch_MaxInclusiveConstraintFailed, maxValueString);
                }
            }
            else
            {
                if (!(value < this._maxValue))
                {
                    subMsg = string.Format(System.Globalization.CultureInfo.CurrentUICulture, ValidationResources.Sch_MaxExclusiveConstraintFailed, maxValueString);
                }
            }

            if (subMsg == null)
            {
                return null;
            }
            else
            {
                return new ValidationErrorInfo()
                {
                    Id = "Sem_AttributeValueDataTypeDetailed",
                    ErrorType = ValidationErrorType.Schema,
                    Node = context.Element,
                    Description = string.Format(System.Globalization.CultureInfo.CurrentUICulture, ValidationResources.Sem_AttributeValueDataTypeDetailed,
                                                GetAttributeQualifiedName(context.Element, _attribute), attributeValue, subMsg)
                };
            }
        }
    }
}
