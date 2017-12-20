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
    [DataContract]
    internal class TokenRestriction : StringRestriction
    {
        /// <inheritdoc />
        public override XsdType XsdType => XsdType.Token;

        /// <inheritdoc />
        public override string ClrTypeName => ValidationResources.TypeName_token;

        /// <inheritdoc />
        public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
        {
            try
            {
                VerifyTOKEN(attributeValue.InnerText);
            }
            catch (XmlException)
            {
                return false;
            }

            return true;
        }

#if FEATURE_XML_VERIFYTOKEN
        protected static string VerifyTOKEN(string token)
        {
            return XmlConvert.VerifyTOKEN(token);
        }
#else
        private static char[] crt = new char[] { '\n', '\r', '\t' };

        protected static string VerifyTOKEN(string token)
        {
            if (token == null || token.Length == 0)
            {
                return token;
            }

            if (token[0] == ' ' || token[token.Length - 1] == ' ' || token.IndexOfAny(crt) != -1 || token.IndexOf("  ", StringComparison.Ordinal) != -1)
            {
                throw new System.Xml.XmlException($"Not a valid token: '{token}'");
            }

            return token;
        }
#endif
    }
}
