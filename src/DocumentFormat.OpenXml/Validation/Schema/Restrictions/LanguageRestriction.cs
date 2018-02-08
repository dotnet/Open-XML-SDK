// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Xml;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// language (xsd:language) based simple type constraint.
    /// </summary>
    /// <remarks>
    ///  language represents natural language identifiers as defined by by [RFC 3066] .
    ///  The ·value space· of language is the set of all strings that are valid language identifiers as defined [RFC 3066] .
    ///  The ·lexical space· of language is the set of all strings that conform to the pattern [a-zA-Z]{1,8}(-[a-zA-Z0-9]{1,8})* .
    ///  The ·base type· of language is token.
    /// </remarks>
    [DataContract]
    internal class LanguageRestriction : TokenRestriction
    {
        private static string LanguageLexicalPattern = @"\A[a-zA-Z]{1,8}(-[a-zA-Z0-9]{1,8})*\z";

        /// <inheritdoc />
        public override XsdType XsdType => XsdType.Language;

        /// <inheritdoc />
        public override string ClrTypeName => ValidationResources.TypeName_language;

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

            return Regex.IsMatch(attributeValue.InnerText, LanguageLexicalPattern, RegexOptions.CultureInvariant);
        }
    }
}
