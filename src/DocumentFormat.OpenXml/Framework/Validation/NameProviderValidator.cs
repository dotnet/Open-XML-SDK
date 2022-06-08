// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using DocumentFormat.OpenXml.Validation;
using System.Xml;

namespace DocumentFormat.OpenXml.Framework
{
    internal class NameProviderValidator : IValidator, INameProvider
    {
        private readonly IValidator _other;

        public NameProviderValidator(IValidator other, XmlQualifiedName qname)
        {
            _other = other;
            QName = qname;
        }

        public XmlQualifiedName QName { get; }

        public void Validate(ValidationContext context) => _other.Validate(context);
    }
}
