// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// Boolean (xsd:boolean) based simple type constraint.
    /// </summary>
    [DataContract]
    internal class BooleanValueRestriction : SimpleTypeRestriction
    {
        // BooleanValueRestriction is the only SimpleTypeRestriction that can have
        // multiple values of XsdType, so we only need to serialize this instance
        [DataMember(Name = nameof(XsdType))]
        private XsdType _xsdType = XsdType.Boolean;

        /// <inheritdoc />
        public override XsdType XsdType => _xsdType;

        public void SetXsdType(XsdType value)
        {
            Debug.Assert(value == XsdType.Boolean || value == XsdType.SpecialBoolean);
            this._xsdType = value;
        }

        /// <inheritdoc />
        public override string ClrTypeName => typeof(Boolean).Name;

#if DEBUG
        public override void Verify()
        {
            Debug.Assert(this.XsdType == XsdType.Boolean || this.XsdType == XsdType.SpecialBoolean);
            Debug.Assert(this.IsEnum == false);
            Debug.Assert(this.IsList == false);
            Debug.Assert(this.Pattern == null);
        }
#endif
    }
}
