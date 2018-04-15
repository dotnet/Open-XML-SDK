// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics;
using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// Boolean (xsd:boolean) based simple type constraint.
    /// </summary>
    [DataContract(Name = "bl")]
    internal class BooleanValueRestriction : SimpleTypeRestriction
    {
        // BooleanValueRestriction is the only SimpleTypeRestriction that can have
        // multiple values of XsdType, so we only need to serialize this instance
        [DataMember(Name = "x")]
        private XsdType _xsdType = XsdType.Boolean;

        /// <inheritdoc />
        public override XsdType XsdType => _xsdType;

        public void SetXsdType(XsdType value)
        {
            Debug.Assert(value == XsdType.Boolean || value == XsdType.SpecialBoolean);
            _xsdType = value;
        }

        /// <inheritdoc />
        public override string ClrTypeName => typeof(bool).Name;

#if DEBUG
        public override void Verify()
        {
            Debug.Assert(XsdType == XsdType.Boolean || XsdType == XsdType.SpecialBoolean);
            Debug.Assert(IsEnum == false);
            Debug.Assert(IsList == false);
            Debug.Assert(Pattern == null);
        }
#endif
    }
}
