// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:a1611="http://schemas.microsoft.com/office/drawing/2016/11/main" namespace.
    /// </summary>
    public static class A1611
    {
        /// <summary>
        /// Defines the XML namespace associated with the a1611 prefix.
        /// </summary>
        public static readonly XNamespace a1611 = "http://schemas.microsoft.com/office/drawing/2016/11/main";

        /// <summary>
        /// Represents the a1611:picAttrSrcUrl XML element.
        /// </summary>
        public static readonly XName picAttrSrcUrl = a1611 + "picAttrSrcUrl";
    }
}
