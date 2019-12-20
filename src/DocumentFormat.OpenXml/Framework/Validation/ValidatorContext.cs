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
        private readonly ValidationContext _context;

        public ValidatorContext(ValidationContext context)
        {
            _context = context;
        }

        public MCContext McContext => _context.McContext;

        public IDisposable With(Action<ValidationErrorInfo> addError)
        {
            return _context.Push(addError);
        }

        public bool IsAttribute => _context.Current.IsAttribute;

        public XmlQualifiedName QName => _context.Current.Property.GetQName();

        public XmlQualifiedName TypeQName => _context.Current.Property.TypeName;

        public OpenXmlSimpleType Value => _context.Current.Value;

        public FileFormatVersions Version => _context.Settings.FileFormat;

        public void AddError(ValidationErrorInfo error) => _context.AddError(error);

        public void CreateError(string id, ValidationErrorType errorType, string description = null)
        {
            _context.CreateError(id, errorType, description);
        }
    }
}
