// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:w16cid="http://schemas.microsoft.com/office/word/2016/wordml/cid" namespace.
    /// </summary>
    public static class W16CID
    {
        /// <summary>
        /// Defines the XML namespace associated with the w16cid prefix.
        /// </summary>
        public static readonly XNamespace w16cid = "http://schemas.microsoft.com/office/word/2016/wordml/cid";

        /// <summary>
        /// Represents the w16cid:commentId XML element.
        /// </summary>
        public static readonly XName commentId = w16cid + "commentId";

        /// <summary>
        /// Represents the w16cid:commentsIds XML element.
        /// </summary>
        public static readonly XName commentsIds = w16cid + "commentsIds";

        /// <summary>
        /// Represents the w16cid:durableId XML attribute.
        /// </summary>
        public static readonly XName durableId = w16cid + "durableId";

        /// <summary>
        /// Represents the w16cid:paraId XML attribute.
        /// </summary>
        public static readonly XName paraId = w16cid + "paraId";
    }
}
