// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;

namespace DocumentFormat.OpenXml
{
    internal static partial class RootElementFactory
    {
        internal static OpenXmlElement CreateElement(string namespaceUri, string name)
        {
            // Debug.Assert(namespaceUri != null);
            Debug.Assert(!string.IsNullOrEmpty(name));

            OpenXmlElement newElement = null;
            byte nsId;

            if ((namespaceUri != null) && NamespaceIdMap.TryGetNamespaceId(namespaceUri, out nsId))
            {
                newElement = CreateElement(nsId, name);
            }

            if (newElement == null)
            {
                // return unknown element instead of throw exception.
                newElement = new OpenXmlUnknownElement();
            }

            return newElement;
        }
    }
}
