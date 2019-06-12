// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;

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
    internal class AnyUriRestriction
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly char[] _whitespaceChars = new char[] { ' ', '\t', '\n', '\r' };

        public static bool Validate(string uriString)
        {
            // code copied from XmlConvert.TryToUri()
            if ((uriString != null) && (uriString.Length > 0))
            {
                uriString = uriString.Trim(_whitespaceChars);

                if ((uriString.Length == 0) || (uriString.IndexOf("##", StringComparison.Ordinal) != -1))
                {
                    return false;
                }
            }

            return Uri.TryCreate(uriString, UriHelper.RelativeOrAbsolute, out _);
        }
    }
}
