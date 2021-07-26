// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:w10="urn:schemas-microsoft-com:office:word" namespace.
    /// </summary>
    public static class W10
    {
        /// <summary>
        /// Defines the XML namespace associated with the w10 prefix.
        /// </summary>
        public static readonly XNamespace w10 = "urn:schemas-microsoft-com:office:word";

        /// <summary>
        /// Represents the w10:anchorlock XML element.
        /// </summary>
        public static readonly XName anchorlock = w10 + "anchorlock";

        /// <summary>
        /// Represents the w10:borderbottom XML element.
        /// </summary>
        public static readonly XName borderbottom = w10 + "borderbottom";

        /// <summary>
        /// Represents the w10:borderleft XML element.
        /// </summary>
        public static readonly XName borderleft = w10 + "borderleft";

        /// <summary>
        /// Represents the w10:borderright XML element.
        /// </summary>
        public static readonly XName borderright = w10 + "borderright";

        /// <summary>
        /// Represents the w10:bordertop XML element.
        /// </summary>
        public static readonly XName bordertop = w10 + "bordertop";

        /// <summary>
        /// Represents the w10:wrap XML element.
        /// </summary>
        public static readonly XName wrap = w10 + "wrap";
    }
}
