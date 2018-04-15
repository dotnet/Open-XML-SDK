// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Validation;
using System.Runtime.Serialization;
using System.Xml;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// ID (xsd:ID) based simple type constraint.
    /// </summary>
    /// <remarks>
    /// ID represents the ID attribute type from [XML 1.0 (Second Edition)].
    /// The ·value space· of ID is the set of all strings that ·match· the NCName production in [Namespaces in XML].
    /// The ·lexical space· of ID is the set of all strings that ·match· the NCName production in [Namespaces in XML].
    /// The ·base type· of ID is NCName.
    /// </remarks>
    [DataContract(Name = "id")]
    internal class IdStringRestriction : StringRestriction
    {
        /// <inheritdoc />
        public override XsdType XsdType => XsdType.ID;

        /// <inheritdoc />
        public override string ClrTypeName => ValidationResources.TypeName_ID;

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
