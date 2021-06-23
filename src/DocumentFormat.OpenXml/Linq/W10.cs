// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Provides the qualified names of the elements and attributes of the namespace
    /// "urn:schemas-microsoft-com:office:word", which uses the namespace prefix "w10".
    /// </summary>
    public static class W10
    {
        public static readonly XNamespace w10 = "urn:schemas-microsoft-com:office:word";

        public static readonly XName anchorlock = w10 + "anchorlock";
        public static readonly XName borderbottom = w10 + "borderbottom";
        public static readonly XName borderleft = w10 + "borderleft";
        public static readonly XName borderright = w10 + "borderright";
        public static readonly XName bordertop = w10 + "bordertop";
        public static readonly XName wrap = w10 + "wrap";
    }
}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
