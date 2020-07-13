// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

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
