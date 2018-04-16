// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.Serialization;
using System.Xml;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// Token (xsd:token) based simple type constraint.
    /// </summary>
    /// <remarks>
    /// token represents tokenized strings.
    /// The ·value space· of token is the set of strings that do not contain the carriage return (#xD),
    /// line feed (#xA) nor tab (#x9) characters, that have no leading or trailing spaces (#x20) and
    /// that have no internal sequences of two or more spaces.
    /// The ·lexical space· of token is the set of strings that do not contain the carriage return (#xD),
    /// line feed (#xA) nor tab (#x9) characters, that have no leading or trailing spaces (#x20) and
    /// that have no internal sequences of two or more spaces. The ·base type· of token is normalizedString
    ///
    /// In Ecma376, most token are enumerations.
    /// </remarks>
    [DataContract(Name = "tkn")]
    internal class TokenRestriction : StringRestriction
    {
        private static char[] crt = { '\n', '\r', '\t' };

        /// <inheritdoc />
        public override XsdType XsdType => XsdType.Token;

        /// <inheritdoc />
        public override string ClrTypeName => ValidationResources.TypeName_token;

        /// <inheritdoc />
        public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
        {
            return VerifyTOKEN(attributeValue.InnerText);
        }

        /// <summary>
        /// An implementation of XmlConvert.VerifyTOKEN(string) as it is not available cross platform and throws if fails
        /// </summary>
        public static bool VerifyTOKEN(string token)
        {
            if (token == null || token.Length == 0)
            {
                return true;
            }

            if (token[0] == ' ' || token[token.Length - 1] == ' ' || token.IndexOfAny(crt) != -1 || token.IndexOf("  ", StringComparison.Ordinal) != -1)
            {
                return false;
            }

            return true;
        }
    }
}
