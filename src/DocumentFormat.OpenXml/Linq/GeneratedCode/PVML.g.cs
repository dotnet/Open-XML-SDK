// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:pvml="urn:schemas-microsoft-com:office:powerpoint" namespace.
    /// </summary>
    public static class PVML
    {
        /// <summary>
        /// Defines the XML namespace associated with the pvml prefix.
        /// </summary>
        public static readonly XNamespace pvml = "urn:schemas-microsoft-com:office:powerpoint";

        /// <summary>
        /// Represents the pvml:iscomment XML element.
        /// </summary>
        public static readonly XName iscomment = pvml + "iscomment";

        /// <summary>
        /// Represents the pvml:textdata XML element.
        /// </summary>
        public static readonly XName textdata = pvml + "textdata";
    }
}
