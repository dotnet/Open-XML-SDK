// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;
using System;
using System.Xml;

namespace DocumentFormat.OpenXml.Framework
{
    internal sealed class NumberValidator : VersionedValidator, IValidator, INameProvider
    {
        public static IValidator Instance { get; } = new NumberValidator();

        private static readonly XmlQualifiedName _positiveQname = new XmlQualifiedName("positiveInteger", "http://www.w3.org/2001/XMLSchema");
        private static readonly XmlQualifiedName _nonNegativeQname = new XmlQualifiedName("nonNegativeInteger", "http://www.w3.org/2001/XMLSchema");

        private long? _minInclusive;
        private long? _maxInclusive;
        private long? _minExclusive;
        private long? _maxExclusive;

        public long MinInclusive
        {
            get => _minInclusive.GetValueOrDefault();
            set => _minInclusive = value;
        }

        public long MaxInclusive
        {
            get => _maxInclusive.GetValueOrDefault();
            set => _maxInclusive = value;
        }

        public long MinExclusive
        {
            get => _minExclusive.GetValueOrDefault();
            set => _minExclusive = value;
        }

        public long MaxExclusive
        {
            get => _maxExclusive.GetValueOrDefault();
            set => _maxExclusive = value;
        }

        public bool IsNonNegative { get; set; }

        public bool IsPositive { get; set; }

        public XmlQualifiedName QName
        {
            get
            {
                if (IsPositive)
                {
                    return _positiveQname;
                }
                else if (IsNonNegative)
                {
                    return _nonNegativeQname;
                }
                else
                {
                    return null;
                }
            }
        }

        protected override void ValidateVersion(ValidationContext context)
        {
            var current = context.Stack.Current;
            var stValue = current.Value;

            if (stValue is null)
            {
                return;
            }

            var id = current.IsAttribute ? "Sch_AttributeValueDataTypeDetailed" : "Sch_ElementValueDataTypeDetailed";
            var description = current.IsAttribute ? ValidationResources.Sch_AttributeValueDataTypeDetailed : ValidationResources.Sch_ElementValueDataTypeDetailed;

            if (!stValue.IsValid)
            {
                if (string.IsNullOrEmpty(stValue.InnerText))
                {
                    context.CreateError(
                        id: id,
                        description: SR.Format(description, current.Property.GetQName(), current.Value.InnerText, current.IsAttribute ? ValidationResources.Sch_EmptyAttributeValue : ValidationResources.Sch_EmptyElementValue),
                        errorType: ValidationErrorType.Schema);
                }
                else
                {
                    context.CreateError(
                        id: id,
                        description: SR.Format(description, current.Property.GetQName(), current.Value.InnerText, SR.Format(ValidationResources.Sch_StringIsNotValidValue, stValue.InnerText, current.Property.TypeName)),
                        errorType: ValidationErrorType.Schema);
                }

                return;
            }

            if (TryGetValue(stValue, out var value))
            {
                if (IsNonNegative && (value < 0 || !IsValidNumber(value)))
                {
                    context.CreateError(
                        id: id,
                        description: SR.Format(description, current.Property.GetQName(), current.Value, SR.Format(ValidationResources.Sch_StringIsNotValidValue, current.Value, _nonNegativeQname)),
                        errorType: ValidationErrorType.Schema);
                }

                if (IsPositive && (value <= 0 || !IsValidNumber(value)))
                {
                    context.CreateError(
                        id: id,
                        description: SR.Format(description, current.Property.GetQName(), current.Value, SR.Format(ValidationResources.Sch_StringIsNotValidValue, current.Value, _positiveQname)),
                        errorType: ValidationErrorType.Schema);
                }

                if (_maxExclusive.HasValue && (value >= _maxExclusive.Value || !IsValidNumber(value)))
                {
                    context.CreateError(
                        id: id,
                        description: SR.Format(ValidationResources.Sch_MaxExclusiveConstraintFailed, MaxExclusive),
                        errorType: ValidationErrorType.Schema);
                }

                if (_minExclusive.HasValue && (value <= _minExclusive.Value || !IsValidNumber(value)))
                {
                    context.CreateError(
                        id: id,
                        description: SR.Format(ValidationResources.Sch_MinExclusiveConstraintFailed, MinExclusive),
                        errorType: ValidationErrorType.Schema);
                }

                if (_minInclusive.HasValue && (value < _minInclusive.Value || !IsValidNumber(value)))
                {
                    context.CreateError(
                        id: id,
                        description: SR.Format(ValidationResources.Sch_MinInclusiveConstraintFailed, MinInclusive),
                        errorType: ValidationErrorType.Schema);
                }

                if (_maxInclusive.HasValue && (value > _maxInclusive.Value || !IsValidNumber(value)))
                {
                    context.CreateError(
                        id: id,
                        description: SR.Format(ValidationResources.Sch_MaxInclusiveConstraintFailed, MaxInclusive),
                        errorType: ValidationErrorType.Schema);
                }
            }
        }

        private static bool TryGetValue(OpenXmlSimpleType simpleType, out double value)
        {
            value = 0;

            if (simpleType == null || !simpleType.HasValue)
            {
                return false;
            }

            if (simpleType is OpenXmlSimpleValue<byte> b)
            {
                value = b.Value;
            }
            else if (simpleType is OpenXmlSimpleValue<sbyte> sb)
            {
                value = sb.Value;
            }
            else if (simpleType is OpenXmlSimpleValue<long> l)
            {
                value = l.Value;
            }
            else if (simpleType is OpenXmlSimpleValue<ulong> ul)
            {
                value = ul.Value;
            }
            else if (simpleType is OpenXmlSimpleValue<int> i)
            {
                value = i.Value;
            }
            else if (simpleType is OpenXmlSimpleValue<uint> ui)
            {
                value = ui.Value;
            }
            else if (simpleType is OpenXmlSimpleValue<double> d)
            {
                value = d.Value;
            }
            else if (simpleType is OpenXmlSimpleValue<float> f)
            {
                value = f.Value;
            }
            else if (simpleType is OpenXmlSimpleValue<ushort> us)
            {
                value = us.Value;
            }
            else if (simpleType is OpenXmlSimpleValue<short> s)
            {
                value = s.Value;
            }
            else
            {
                return false;
            }

            return true;
        }

        private static bool IsValidNumber(double value) => !double.IsNaN(value);
    }
}
