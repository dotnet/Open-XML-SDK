// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:msink="http://schemas.microsoft.com/ink/2010/main" namespace.
    /// </summary>
    public static class MSINK
    {
        /// <summary>
        /// Defines the XML namespace associated with the msink prefix.
        /// </summary>
        public static readonly XNamespace msink = "http://schemas.microsoft.com/ink/2010/main";

        /// <summary>
        /// Represents the msink:context XML element.
        /// </summary>
        public static readonly XName context = msink + "context";

        /// <summary>
        /// Represents the msink:destinationLink XML element.
        /// </summary>
        public static readonly XName destinationLink = msink + "destinationLink";

        /// <summary>
        /// Represents the msink:property XML element.
        /// </summary>
        public static readonly XName property = msink + "property";

        /// <summary>
        /// Represents the msink:sourceLink XML element.
        /// </summary>
        public static readonly XName sourceLink = msink + "sourceLink";
    }
}
