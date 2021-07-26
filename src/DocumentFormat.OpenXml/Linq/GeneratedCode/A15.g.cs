// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:a15="http://schemas.microsoft.com/office/drawing/2012/main" namespace.
    /// </summary>
    public static class A15
    {
        /// <summary>
        /// Defines the XML namespace associated with the a15 prefix.
        /// </summary>
        public static readonly XNamespace a15 = "http://schemas.microsoft.com/office/drawing/2012/main";

        /// <summary>
        /// Represents the a15:backgroundPr XML element.
        /// </summary>
        public static readonly XName backgroundPr = a15 + "backgroundPr";

        /// <summary>
        /// Represents the a15:nonVisualGroupProps XML element.
        /// </summary>
        public static readonly XName nonVisualGroupProps = a15 + "nonVisualGroupProps";

        /// <summary>
        /// Represents the a15:objectPr XML element.
        /// </summary>
        public static readonly XName objectPr = a15 + "objectPr";

        /// <summary>
        /// Represents the a15:signatureLine XML element.
        /// </summary>
        public static readonly XName signatureLine = a15 + "signatureLine";
    }
}
