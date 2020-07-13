// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;
using DocumentFormat.OpenXml.Validation.Schema.Restrictions;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml;

namespace DocumentFormat.OpenXml.Framework
{
    internal sealed class StringValidator : VersionedValidator, INameProvider
    {
        internal static IValidator Instance { get; } = new StringValidator();

        private static readonly XmlQualifiedName _anyUri = new XmlQualifiedName("anyUri", "http://www.w3.org/2001/XMLSchema");
        private static readonly XmlQualifiedName _token = new XmlQualifiedName("token", "http://www.w3.org/2001/XMLSchema");
        private static readonly XmlQualifiedName _id = new XmlQualifiedName("ID", "http://www.w3.org/2001/XMLSchema");
        private static readonly XmlQualifiedName _ncName = new XmlQualifiedName("NCName", "http://www.w3.org/2001/XMLSchema");
        private static readonly XmlQualifiedName _qname = new XmlQualifiedName("QName", "http://www.w3.org/2001/XMLSchema");

        public XmlQualifiedName QName
        {
            get
            {
                if (IsQName)
                {
                    return _qname;
                }
                else if (IsToken)
                {
                    return _token;
                }
                else if (IsId)
                {
                    return _id;
                }
                else if (IsNcName)
                {
                    return _ncName;
                }
                else if (IsUri)
                {
                    return _anyUri;
                }

                return null;
            }
        }

        private long? _minLength;
        private long? _maxLength;
        private long? _length;
        private Regex _regex;

        public Regex Regex
        {
            get
            {
                if (_regex == null && Pattern != null)
                {
                    var regex = new Regex($@"\A{Pattern}\z", RegexOptions.Compiled | RegexOptions.CultureInvariant);

                    Interlocked.Exchange(ref _regex, regex);
                }

                return _regex;
            }
        }

        public string Pattern { get; set; }

        public bool IsToken { get; set; }

        public bool IsQName { get; set; }

        public bool IsNcName { get; set; }

        public bool IsId { get; set; }

        public bool IsUri { get; set; }

        public long MinLength
        {
            get => _minLength.GetValueOrDefault();
            set => _minLength = value;
        }

        public long MaxLength
        {
            get => _maxLength.GetValueOrDefault();
            set => _maxLength = value;
        }

        public long Length
        {
            get => _length.GetValueOrDefault();
            set => _length = value;
        }

        protected override void ValidateVersion(ValidationContext context)
        {
            var current = context.Stack.Current;

            if (current.Value is StringValue str)
            {
                Validate(str, context, current, includeDetails: true);
            }
            else if (current.Value is IEnumerable<StringValue> list)
            {
                ValidationErrorInfo outside = null;

                using (context.Stack.Push(info => outside = info))
                {
                    foreach (var s in list)
                    {
                        Validate(s, context, current, includeDetails: false);

                        if (outside != null)
                        {
                            break;
                        }
                    }
                }

                if (outside != null)
                {
                    context.AddError(outside);
                }
            }
        }

        private void Validate(StringValue str, ValidationContext context, in ValidationElement current, bool includeDetails)
        {
            var id = current.IsAttribute ? "Sch_AttributeValueDataTypeDetailed" : "Sch_ElementValueDataTypeDetailed";
            var description = current.IsAttribute ? ValidationResources.Sch_AttributeValueDataTypeDetailed : ValidationResources.Sch_ElementValueDataTypeDetailed;

            if (!str.IsValid)
            {
                if (string.IsNullOrEmpty(str.InnerText))
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
                        description: SR.Format(description, current.Property.GetQName(), current.Value.InnerText, SR.Format(ValidationResources.Sch_StringIsNotValidValue, str.InnerText, current.Property.TypeName)),
                        errorType: ValidationErrorType.Schema);
                }

                return;
            }

            if (IsId && !IsValidNcName(current.Value))
            {
                if (string.IsNullOrEmpty(current.Value.InnerText))
                {
                    InvalidEmpty(context, current, id, description);
                    return;
                }
                else
                {
                    context.CreateError(
                        id: id,
                        description: SR.Format(description, current.Property.GetQName(), current.Value.InnerText, SR.Format(ValidationResources.Sch_StringIsNotValidValue, current.Value.InnerText, _id)),
                        errorType: ValidationErrorType.Schema);
                }
            }
            else if (IsNcName)
            {
                if (!IsValidNcName(current.Value))
                {
                    if (string.IsNullOrEmpty(str.InnerText))
                    {
                        InvalidEmpty(context, current, id, description);
                        return;
                    }
                    else
                    {
                        context.CreateError(
                            id: id,
                            description: SR.Format(description, current.Property.GetQName(), current.Value, SR.Format(ValidationResources.Sch_StringIsNotValidValue, current.Value, _ncName)),
                            errorType: ValidationErrorType.Schema);
                    }
                }
                else if (current.Value.InnerText.Length > 255)
                {
                    context.CreateError(
                        id: id,
                        description: SR.Format(ValidationResources.Sch_MaxLengthConstraintFailed, "NCName", 255),
                        errorType: ValidationErrorType.Schema);
                }
            }
            else if (IsQName && !QnameRestriction.IsValidQName(str.InnerText))
            {
                if (string.IsNullOrEmpty(str.InnerText))
                {
                    InvalidEmpty(context, current, id, description);
                    return;
                }
                else
                {
                    context.CreateError(
                        id: id,
                        description: SR.Format(description, current.Property.GetQName(), current.Value, SR.Format(ValidationResources.Sch_StringIsNotValidValue, current.Value, _qname)),
                        errorType: ValidationErrorType.Schema);
                }
            }
            else if (IsToken && !TokenRestriction.VerifyTOKEN(str.InnerText))
            {
                context.CreateError(
                    id: id,
                    description: SR.Format(description, current.Property.GetQName(), current.Value, SR.Format(ValidationResources.Sch_StringIsNotValidValue, current.Value, _token)),
                    errorType: ValidationErrorType.Schema);
            }
            else if (IsUri && !AnyUriRestriction.Validate(str.Value))
            {
                if (string.IsNullOrEmpty(str.InnerText))
                {
                    InvalidEmpty(context, current, id, description);
                    return;
                }
                else
                {
                    context.CreateError(
                        id: id,
                        description: SR.Format(description, current.Property.GetQName(), str.InnerText, SR.Format(ValidationResources.Sch_StringIsNotValidValue, str.InnerText, "Uri")),
                        errorType: ValidationErrorType.Schema);
                }
            }
            else if (Regex is Regex regex && !regex.IsMatch(str.Value))
            {
                context.CreateError(
                    id: id,
                    description: SR.Format(description, current.Property.GetQName(), current.Value.InnerText, includeDetails ? SR.Format(ValidationResources.Sch_PatternConstraintFailed, Pattern) : string.Empty),
                    errorType: ValidationErrorType.Schema);
            }

            if (_length.HasValue && str.Length != Length)
            {
                if (str.Length == 0)
                {
                    context.CreateError(
                        id: id,
                        description: current.IsAttribute ? ValidationResources.Sch_EmptyAttributeValue : ValidationResources.Sch_EmptyElementValue,
                        errorType: ValidationErrorType.Schema);
                }
                else
                {
                    context.CreateError(
                        id: id,
                        description: SR.Format(description, current.Property.GetQName(), current.Value, SR.Format(ValidationResources.Sch_LengthConstraintFailed, current.Property.TypeName.Name, Length)),
                        errorType: ValidationErrorType.Schema);
                }
            }
            else if (_maxLength.HasValue && str.Length > MaxLength)
            {
                context.CreateError(
                    id: id,
                    description: SR.Format(description, current.Property.GetQName(), current.Value, SR.Format(ValidationResources.Sch_MaxLengthConstraintFailed, current.Property.TypeName.Name, MaxLength)),
                    errorType: ValidationErrorType.Schema);
            }
            else if (_minLength.HasValue && str.Length < MinLength)
            {
                if (str.Length == 0)
                {
                    context.CreateError(
                        id: id,
                        description: SR.Format(description, current.Property.GetQName().Name, str.InnerText, ValidationResources.Sch_EmptyAttributeValue),
                        errorType: ValidationErrorType.Schema);
                }
                else
                {
                    context.CreateError(
                        id: id,
                        description: SR.Format(description, current.Property.GetQName(), current.Value, SR.Format(ValidationResources.Sch_MinLengthConstraintFailed, current.Property.TypeName.Name, MinLength)),
                        errorType: ValidationErrorType.Schema);
                }
            }
        }

        private static void InvalidEmpty(ValidationContext context, in ValidationElement current, string id, string description)
        {
            context.CreateError(
                id: id,
                description: SR.Format(description, current.Property.GetQName(), current.Value.InnerText, ValidationResources.Sch_EmptyAttributeValue),
                errorType: ValidationErrorType.Schema);
        }

        private static bool IsValidNcName(OpenXmlSimpleType attributeValue)
        {
            if (string.IsNullOrEmpty(attributeValue.InnerText))
            {
                return false;
            }

            try
            {
                XmlConvert.VerifyNCName(attributeValue.InnerText);
                return true;
            }
            catch (XmlException)
            {
                return false;
            }
        }
    }
}
