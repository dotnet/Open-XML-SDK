// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// Base64 binary (xsd:base64Binary) based simple type constraint.
    /// </summary>
    /// <remarks>
    /// The lexical forms of base64Binary values are limited to the 65 characters of the Base64 Alphabet defined in [RFC 2045], i.e., a-z, A-Z, 0-9, the plus sign (+), the forward slash (/) and the equal sign (=), together with the characters defined in [XML 1.0 (Second Edition)] as white space. No other characters are allowed.
    /// </remarks>
    [DataContract(Name = "b64")]
    internal class Base64BinaryRestriction : StringRestriction
    {
        /// <inheritdoc />
        public override XsdType XsdType => XsdType.Base64Binary;

        /// <inheritdoc />
        public override string ClrTypeName => ValidationResources.TypeName_base64Binary;

        /// <inheritdoc />
        public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
        {
            if (attributeValue.InnerText == null)
            {
                return false;
            }
            else if (attributeValue.InnerText.Length == 0)
            {
                return true;
            }

            try
            {
                Convert.FromBase64String(attributeValue.InnerText);
            }
            catch (FormatException)
            {
                return false;
            }

            return true;
        }

        /// <inheritdoc />
        internal override int GetValueLength(OpenXmlSimpleType attributeValue)
        {
            // decoded the data
            var binaryData = Convert.FromBase64String(attributeValue.InnerText);
            return binaryData.Length;
        }
    }
}
