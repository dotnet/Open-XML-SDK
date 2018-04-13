// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Runtime.Serialization;

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
    [DataContract(Name = "h")]
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

            var length = attributeValue.InnerText.Length;

            if (length % 2 == 1)
            {
                return false;
            }

            for (var i = 0; i < length; i++)
            {
                var current = attributeValue.InnerText[i];
                var isDigit = IsLetterBetween(current, '0', '9');
                var isLower = IsLetterBetween(current, 'a', 'f');
                var isUpper = IsLetterBetween(current, 'A', 'F');

                if (!isDigit && !isLower && !isUpper)
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsLetterBetween(char check, char lower, char upper)
        {
            return check >= lower && check <= upper;
        }

        /// <inheritdoc />
        internal override int GetValueLength(OpenXmlSimpleType attributeValue)
        {
            // so, the data length is the number of octets
            // then the data length is string length / 2
            var stringLength = attributeValue.InnerText.Length;

            //Debug.Assert(stringLength % 2 == 0);
            return (stringLength + 1) / 2;
        }
    }
}
