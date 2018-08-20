// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Semantic
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
            var attribute = context.Element.Attributes[_attribute];

            if (!attribute.HasValue || !attribute.Value.HasValue || string.IsNullOrEmpty(attribute.Value.InnerText))
            {
                return null;
            }

            //If value cannot be converted into double, that means attribute type is not correct.
            //That's job of schema validation, semantic validation will do nothing to avoid throw duplicated error.
            if (!GetAttrNumVal(attribute.Value, out double value))
            {
                return null;
            }

            string minValueString;
            string maxValueString;

            if (attribute.Value is HexBinaryValue)
            {
                minValueString = SR.Format("{0:X}", (long)_minValue);
                maxValueString = SR.Format("{0:X}", (long)_maxValue);
            }
            else
            {
                minValueString = _minValue.ToString(System.Globalization.CultureInfo.CurrentUICulture);
                maxValueString = _maxValue.ToString(System.Globalization.CultureInfo.CurrentUICulture);
            }

            string subMsg = null;

            if (_minInclusive)
            {
                if (!(_minValue <= value))
                {
                    subMsg = SR.Format(ValidationResources.Sch_MinInclusiveConstraintFailed, minValueString);
                }
            }
            else
            {
                if (!(_minValue < value))
                {
                    subMsg = SR.Format(ValidationResources.Sch_MinExclusiveConstraintFailed, minValueString);
                }
            }

            if (_maxInclusive)
            {
                if (!(value <= _maxValue))
                {
                    subMsg = SR.Format(ValidationResources.Sch_MaxInclusiveConstraintFailed, maxValueString);
                }
            }
            else
            {
                if (!(value < _maxValue))
                {
                    subMsg = SR.Format(ValidationResources.Sch_MaxExclusiveConstraintFailed, maxValueString);
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
                    Description = SR.Format(
                        ValidationResources.Sem_AttributeValueDataTypeDetailed,
                        GetAttributeQualifiedName(context.Element, _attribute),
                        attribute.Value,
                        subMsg),
                };
            }
        }
    }
}
