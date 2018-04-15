// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Runtime.Serialization;
using System.Xml;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    //****************************************
    // the xml:space is NcName
    // No other explicit use of xsd:NCName in Ecma376
    //****************************************

    /// <summary>
    /// NCName (xsd:NCName) based simple type constraint.
    /// </summary>
    /// <remarks>
    ///  NCName represents XML "non-colonized" Names.
    ///  The ·value space· of NCName is the set of all strings which ·match· the NCName production of [Namespaces in XML].
    ///  The ·lexical space· of NCName is the set of all strings which ·match· the NCName production of [Namespaces in XML].
    ///  The ·base type· of NCName is Name.
    ///
    ///  Also Use NcName for IDREF.
    ///  IDREF represents the IDREF attribute type from [XML 1.0 (Second Edition)].
    ///  The ·value space· of IDREF is the set of all strings that ·match· the NCName production in [Namespaces in XML].
    ///  The ·lexical space· of IDREF is the set of strings that ·match· the NCName production in [Namespaces in XML].
    ///  The ·base type· of IDREF is NCName.
    /// </remarks>
    [DataContract(Name = "mcn")]
    internal class NcNameRestriction : StringRestriction
    {
        /// <inheritdoc />
        public override XsdType XsdType => XsdType.NCName;

        /// <inheritdoc />
        public override string ClrTypeName => ValidationResources.TypeName_NCName;

        /// <inheritdoc />
        public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
        {
            if (string.IsNullOrEmpty(attributeValue.InnerText))
            {
                return false;
            }

            try
            {
                XmlConvert.VerifyNCName(attributeValue.InnerText);
            }
            catch (XmlException)
            {
                return false;
            }

            return true;
        }
    }
}
