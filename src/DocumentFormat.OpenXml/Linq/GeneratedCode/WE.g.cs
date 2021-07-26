// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:we="http://schemas.microsoft.com/office/webextensions/webextension/2010/11" namespace.
    /// </summary>
    public static class WE
    {
        /// <summary>
        /// Defines the XML namespace associated with the we prefix.
        /// </summary>
        public static readonly XNamespace we = "http://schemas.microsoft.com/office/webextensions/webextension/2010/11";

        /// <summary>
        /// Represents the we:alternateReferences XML element.
        /// </summary>
        public static readonly XName alternateReferences = we + "alternateReferences";

        /// <summary>
        /// Represents the we:binding XML element.
        /// </summary>
        public static readonly XName binding = we + "binding";

        /// <summary>
        /// Represents the we:bindings XML element.
        /// </summary>
        public static readonly XName bindings = we + "bindings";

        /// <summary>
        /// Represents the we:extLst XML element.
        /// </summary>
        public static readonly XName extLst = we + "extLst";

        /// <summary>
        /// Represents the we:properties XML element.
        /// </summary>
        public static readonly XName properties = we + "properties";

        /// <summary>
        /// Represents the we:property XML element.
        /// </summary>
        public static readonly XName property = we + "property";

        /// <summary>
        /// Represents the we:reference XML element.
        /// </summary>
        public static readonly XName reference = we + "reference";

        /// <summary>
        /// Represents the we:snapshot XML element.
        /// </summary>
        public static readonly XName snapshot = we + "snapshot";

        /// <summary>
        /// Represents the we:webextension XML element.
        /// </summary>
        public static readonly XName webextension = we + "webextension";

        /// <summary>
        /// Represents the we:webextensionref XML element.
        /// </summary>
        public static readonly XName webextensionref = we + "webextensionref";
    }
}
