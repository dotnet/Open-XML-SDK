// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace DocumentFormat.OpenXml.Internal.SchemaValidation
{
    /// <summary>
    /// Constraint on xml attribute
    /// </summary>
    internal class AttributeConstraint
    {
        internal AttributeConstraint(XsdAttributeUse xsdAttributeUse, SimpleTypeRestriction simpleTypeConstraint)
        {
            Debug.Assert(simpleTypeConstraint != null);

            this.XsdAttributeUse = xsdAttributeUse;
            this.SimpleTypeConstraint = simpleTypeConstraint;
        }

        internal AttributeConstraint(XsdAttributeUse xsdAttributeUse, SimpleTypeRestriction simpleTypeConstraint, FileFormatVersions supportedVersion)
        {
            Debug.Assert(simpleTypeConstraint != null);

            this.XsdAttributeUse = xsdAttributeUse;
            this.SimpleTypeConstraint = simpleTypeConstraint;
            this.SupportedVersion = supportedVersion;
        }

        /// <summary>
        /// The "use" attribute on xsd:attribute [ use = (optional | prohibited | required): optional ]
        /// </summary>
        internal XsdAttributeUse XsdAttributeUse
        {
            get;
            private set;
        }


        // the name of the attribute will be gotten from the CodeGen info.
        // public string PropertyName { get; set; } // the Property name of the xsd:attribute.

        /// <summary>
        /// The simple type constraint for this attribute.
        /// </summary>
        internal SimpleTypeRestriction SimpleTypeConstraint
        {
            get;
            private set;
        }

        /// <summary>
        /// In which file format version this attribute is allowed.
        /// </summary>
        internal FileFormatVersions SupportedVersion
        {
            get;
            private set;
        }
    }

}
