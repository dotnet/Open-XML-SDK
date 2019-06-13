// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Xml;

namespace DocumentFormat.OpenXml.Validation.Schema.Restrictions
{
    /// <summary>
    /// QName (xsd:QName) based simple type constraint.
    /// </summary>
    /// <remarks>
    /// QName represents XML qualified names.
    /// The ·value space· of QName is the set of tuples {namespace name, local part}, where namespace name is an anyURI and local part is an NCName.
    /// The ·lexical space· of QName is the set of strings that ·match· the QName production of [Namespaces in XML].
    /// </remarks>
    internal class QnameRestriction
    {
        public static bool IsValidQName(string qname)
        {
            //Qualified Name
            //[6]  QName ::=  (Prefix ':')? LocalPart
            //[7]  Prefix ::=  NCName
            //[8]  LocalPart ::=  NCName
            if (string.IsNullOrEmpty(qname))
            {
                return false;
            }

            int colonIndex = qname.IndexOf(":", StringComparison.Ordinal);

            if (colonIndex == 0 || colonIndex == qname.Length - 1)
            {
                // ":" at begin or end is invalid.
                return false;
            }

            if (colonIndex > 0)
            {
                // prefix must be NCName
                try
                {
                    XmlConvert.VerifyNCName(qname.Substring(0, colonIndex));
                }
                catch (XmlException)
                {
                    return false;
                }

                // TODO: verify the prefix is defined in the context.
            }

            // local name must be NCName
            try
            {
                XmlConvert.VerifyNCName(qname.Substring(colonIndex + 1));
                return true;
            }
            catch (XmlException)
            {
                return false;
            }
        }
    }
}
