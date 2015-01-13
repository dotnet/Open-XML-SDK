// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Diagnostics;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml
{
    internal static partial class RootElementFactory
    {
        internal static OpenXmlElement CreateElement(string namespaceUri, string name)
        {
            // Debug.Assert(namespaceUri != null);
            Debug.Assert(!String.IsNullOrEmpty(name));

            //
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
