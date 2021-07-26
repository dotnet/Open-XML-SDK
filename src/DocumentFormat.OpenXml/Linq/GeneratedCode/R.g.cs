// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:r="http://schemas.openxmlformats.org/officeDocument/2006/relationships" namespace.
    /// </summary>
    public static class R
    {
        /// <summary>
        /// Defines the XML namespace associated with the r prefix.
        /// </summary>
        public static readonly XNamespace r = "http://schemas.openxmlformats.org/officeDocument/2006/relationships";

        /// <summary>
        /// Represents the r:blip XML attribute.
        /// </summary>
        public static readonly XName blip = r + "blip";

        /// <summary>
        /// Represents the r:cs XML attribute.
        /// </summary>
        public static readonly XName cs = r + "cs";

        /// <summary>
        /// Represents the r:dm XML attribute.
        /// </summary>
        public static readonly XName dm = r + "dm";

        /// <summary>
        /// Represents the r:embed XML attributes.
        /// </summary>
        public static readonly XName embed = r + "embed";

        /// <summary>
        /// Represents the r:href XML attribute.
        /// </summary>
        public static readonly XName href = r + "href";

        /// <summary>
        /// Represents the r:id XML attributes.
        /// </summary>
        public static readonly XName id = r + "id";

        /// <summary>
        /// Represents the r:link XML attributes.
        /// </summary>
        public static readonly XName link = r + "link";

        /// <summary>
        /// Represents the r:lo XML attribute.
        /// </summary>
        public static readonly XName lo = r + "lo";

        /// <summary>
        /// Represents the r:pict XML attribute.
        /// </summary>
        public static readonly XName pict = r + "pict";

        /// <summary>
        /// Represents the r:qs XML attribute.
        /// </summary>
        public static readonly XName qs = r + "qs";
    }
}
