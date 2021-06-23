// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Provides the qualified names of the elements and attributes of the namespace
    /// "http://schemas.openxmlformats.org/markup-compatibility/2006", which uses the
    /// namespace prefix "mc".
    /// </summary>
    public static class MC
    {
        public static readonly XNamespace mc = "http://schemas.openxmlformats.org/markup-compatibility/2006";

        public static readonly XName AlternateContent = mc + "AlternateContent";
        public static readonly XName Choice = mc + "Choice";
        public static readonly XName Fallback = mc + "Fallback";
        public static readonly XName Ignorable = mc + "Ignorable";
        public static readonly XName PreserveAttributes = mc + "PreserveAttributes";
    }
}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
