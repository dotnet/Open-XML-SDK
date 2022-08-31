// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using System;
using System.Collections.Generic;
using System.Xml;

namespace DocumentFormat.OpenXml.Features
{
    internal class NoDataNamespaceResolver : IOpenXmlNamespaceResolver
    {
        public IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) => new Dictionary<string, string>();

        public FileFormatVersions GetVersion(OpenXmlNamespace ns) => FileFormatVersions.Office2007;

        public string? LookupNamespace(string prefix) => null;

        public string? LookupPrefix(string namespaceName) => null;

        public bool TryGetExtendedNamespace(OpenXmlNamespace ns, out OpenXmlNamespace extNamespaceUri)
        {
            extNamespaceUri = default;
            return false;
        }

        public bool TryGetTransitionalNamespace(OpenXmlNamespace ns, out OpenXmlNamespace transitionalNamespace)
        {
            transitionalNamespace = default;
            return false;
        }

        public bool TryGetTransitionalRelationship(OpenXmlNamespace ns, out OpenXmlNamespace transitionalRelationship)
        {
            transitionalRelationship = default;
            return false;
        }
    }
}
