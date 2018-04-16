// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// Base class for string (xsd:string) based simple type constraints.
    /// </summary>
    [DataContract(Name = "str")]
    internal class StringRestriction : SimpleTypeRestriction
    {
        /// <inheritdoc />
        public override XsdType XsdType => XsdType.String;

        /// <inheritdoc />
        public override string ClrTypeName => typeof(string).Name;

        /// <inheritdoc />
        public override bool IsPatternValid(OpenXmlSimpleType attributeValue)
        {
            if ((RestrictionField & RestrictionField.Pattern) == RestrictionField.Pattern)
            {
                string pattern = @"\A(" + Pattern + @")\z";
                return Regex.IsMatch(attributeValue.InnerText, pattern, RegexOptions.CultureInvariant);
            }

            return true;
        }

        /// <summary>
        /// Get the length of the attribute value according to the xsd type.
        /// </summary>
        /// <param name="attributeValue"></param>
        /// <returns></returns>
        /// <remarks>
        /// A value in a ·value space· is facet-valid with respect to ·length·, determined as follows:
        /// 1 if the {variety} is ·atomic· then
        ///   1.1 if {primitive type definition} is string or anyURI, then the length of the value, as measured in characters ·must· be equal to {value};
        ///   1.2 if {primitive type definition} is hexBinary or base64Binary, then the length of the value, as measured in octets of the binary data, ·must· be equal to {value};
        ///   1.3 if {primitive type definition} is QName or NOTATION, then any {value} is facet-valid.
        /// 2 if the {variety} is ·list·, then the length of the value, as measured in list items, ·must· be equal to {value}
        /// </remarks>
        internal virtual int GetValueLength(OpenXmlSimpleType attributeValue)
        {
            return attributeValue.InnerText.Length;
        }

        /// <inheritdoc />
        public override bool IsLengthValid(OpenXmlSimpleType attributeValue)
        {
            if ((RestrictionField & RestrictionField.Length) == RestrictionField.Length)
            {
                if (GetValueLength(attributeValue) != Length)
                {
                    return false;
                }
            }

            return true;
        }

        /// <inheritdoc />
        public override bool IsMinLengthValid(OpenXmlSimpleType attributeValue)
        {
            if ((RestrictionField & RestrictionField.MinLength) == RestrictionField.MinLength)
            {
                if (GetValueLength(attributeValue) < MinLength)
                {
                    return false;
                }
            }

            return true;
        }

        /// <inheritdoc />
        public override bool IsMaxLengthValid(OpenXmlSimpleType attributeValue)
        {
            if ((RestrictionField & RestrictionField.MaxLength) == RestrictionField.MaxLength)
            {
                if (GetValueLength(attributeValue) > MaxLength)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
