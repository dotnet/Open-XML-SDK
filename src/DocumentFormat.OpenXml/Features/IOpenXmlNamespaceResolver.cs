// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework;
using System.Xml;

namespace DocumentFormat.OpenXml.Features
{
    internal interface IOpenXmlNamespaceResolver : IXmlNamespaceResolver
    {
        FileFormatVersions GetVersion(OpenXmlNamespace ns);

        /// <summary>
        /// Attempts to get the Transitional equivalent namespace.
        /// </summary>
        /// <param name="ns">Namespace to compare.</param>
        /// <param name="transitionalNamespace">An equivalent namespace in Transitional.</param>
        /// <returns>Returns true when a Transitional equivalent namespace is found, returns false when it is not found.</returns>
        bool TryGetTransitionalNamespace(OpenXmlNamespace ns, out OpenXmlNamespace transitionalNamespace);

        /// <summary>
        /// Attempts to get the Transitional equivalent relationship.
        /// </summary>
        /// <param name="ns">Namespace to compare.</param>
        /// <param name="transitionalRelationship">An equivalent relationship in Transitional.</param>
        /// <returns>Returns true when a Transitional equivalent relationship is found, returns false when it is not.</returns>
        bool TryGetTransitionalRelationship(OpenXmlNamespace ns, out OpenXmlNamespace transitionalRelationship);

        /// <summary>
        /// Try to get the expected namespace if the passed namespace is an obsolete.
        /// </summary>
        /// <param name="ns">Namespace to compare.</param>
        /// <param name="extNamespaceUri">The expected namespace when the passed namespace is an obsolete.</param>
        /// <returns>True when the passed namespace is an obsolete and the expected namespace found</returns>
        bool TryGetExtendedNamespace(OpenXmlNamespace ns, out OpenXmlNamespace extNamespaceUri);
    }
}
