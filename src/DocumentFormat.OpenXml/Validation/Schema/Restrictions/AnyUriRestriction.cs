// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// AnyURI (xsd:anyURI) based simple type constraint.
    /// </summary>
    /// <remarks>
    /// anyURI represents a Uniform Resource Identifier Reference (URI).
    /// An anyURI value can be absolute or relative, and may have an optional fragment identifier (i.e., it may be a URI Reference).
    /// This type should be used to specify the intention that the value fulfills the role of a URI as defined by [RFC 2396], as amended by [RFC 2732].
    /// </remarks>
    [DataContract(Name = "a")]
    internal class AnyUriRestriction : StringRestriction
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static char[] WhitespaceChars = new char[] { ' ', '\t', '\n', '\r' };

        /// <inheritdoc />
        public override XsdType XsdType => XsdType.AnyURI;

        /// <inheritdoc />
        public override string ClrTypeName => typeof(Uri).Name;

        /// <inheritdoc />
        public override bool ValidateValueType(OpenXmlSimpleType attributeValue)
        {
            Uri result = null;
            Debug.Assert(attributeValue != null);
            string uriString = attributeValue.InnerText;

            // code copied from XmlConvert.TryToUri()
            if ((uriString != null) && (uriString.Length > 0))
            {
                uriString = uriString.Trim(WhitespaceChars);
                if ((uriString.Length == 0) || (uriString.IndexOf("##", StringComparison.Ordinal) != -1))
                {
                    return false;
                }
            }

            if (!Uri.TryCreate(uriString, UriHelper.RelativeOrAbsolute, out result))
            {
                return false;
            }

            return true;
        }
    }
}
