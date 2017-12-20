// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// Hex binary (xsd:hexBinary) based simple type constraint.
    /// </summary>
    /// <remarks>
    /// hexBinary has a lexical representation where each binary octet is encoded as a character tuple,
    /// consisting of two hexadecimal digits ([0-9a-fA-F]) representing the octet code.
    /// For example, "0FB7" is a hex encoding for the 16-bit integer 4023 (whose binary representation is 111110110111).
    /// </remarks>
    [DataContract]
    internal class HexBinaryRestriction : StringRestriction
    {
        /// <inheritdoc />
        public override XsdType XsdType => XsdType.HexBinary;

        /// <inheritdoc />
        public override string ClrTypeName => ValidationResources.TypeName_hexBinary;

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

            string pattern = @"\A([0-9a-fA-F][0-9a-fA-F])+\z";

            return Regex.IsMatch(attributeValue.InnerText, pattern, RegexOptions.CultureInvariant);
        }

        /// <inheritdoc />
        internal override int GetValueLength(OpenXmlSimpleType attributeValue)
        {
            // so, the data length is the number of octets
            // then the data lenght is string lenght / 2
            var stringLength = attributeValue.InnerText.Length;
            //Debug.Assert(stringLength % 2 == 0);
            return (stringLength + 1) / 2;
        }
    }
}
