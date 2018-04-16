// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// language (xsd:language) based simple type constraint.
    /// </summary>
    /// <remarks>
    ///  language represents natural language identifiers as defined by [RFC 3066] .
    ///  The ·value space· of language is the set of all strings that are valid language identifiers as defined [RFC 3066] .
    ///  The ·lexical space· of language is the set of all strings that conform to the pattern [a-zA-Z]{1,8}(-[a-zA-Z0-9]{1,8})* .
    ///  The ·base type· of language is token.
    /// </remarks>
    [DataContract(Name = "lang")]
    internal class LanguageRestriction : TokenRestriction
    {
        private static Regex LanguageLexicalPattern = new Regex(@"\A[a-zA-Z]{1,8}(-[a-zA-Z0-9]{1,8})*\z", RegexOptions.Compiled | RegexOptions.CultureInvariant);

        /// <inheritdoc />
        public override XsdType XsdType => XsdType.Language;

        /// <inheritdoc />
        public override string ClrTypeName => ValidationResources.TypeName_language;

        /// <inheritdoc />
        public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
        {
            if (VerifyTOKEN(attributeValue.InnerText))
            {
                return LanguageLexicalPattern.IsMatch(attributeValue.InnerText);
            }

            return false;
        }
    }
}
