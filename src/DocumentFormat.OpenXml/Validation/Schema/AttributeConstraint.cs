// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation.Schema.Restrictions;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Validation.Schema
{
    /// <summary>
    /// Constraint on xml attribute
    /// </summary>
    internal class AttributeConstraint
    {
        public AttributeConstraint(XsdAttributeUse xsdAttributeUse, SimpleTypeRestriction simpleTypeConstraint)
        {
            Debug.Assert(simpleTypeConstraint != null);

            XsdAttributeUse = xsdAttributeUse;
            SimpleTypeConstraint = simpleTypeConstraint;
        }

        public AttributeConstraint(XsdAttributeUse xsdAttributeUse, SimpleTypeRestriction simpleTypeConstraint, FileFormatVersions supportedVersion)
        {
            Debug.Assert(simpleTypeConstraint != null);

            XsdAttributeUse = xsdAttributeUse;
            SimpleTypeConstraint = simpleTypeConstraint;
            SupportedVersion = supportedVersion;
        }

        /// <summary>
        /// Gets the "use" attribute on xsd:attribute [ use = (optional | prohibited | required): optional ]
        /// </summary>
        public XsdAttributeUse XsdAttributeUse { get; }

        /// <summary>
        /// Gets the simple type constraint for this attribute.
        /// </summary>
        public SimpleTypeRestriction SimpleTypeConstraint { get; }

        /// <summary>
        /// Gets in which file format version this attribute is allowed.
        /// </summary>
        public FileFormatVersions SupportedVersion { get; }
    }
}
