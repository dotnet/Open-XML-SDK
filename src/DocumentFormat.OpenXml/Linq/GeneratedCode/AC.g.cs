// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:ac="http://schemas.openxmlformats.org/officeDocument/2006/characteristics" namespace.
    /// </summary>
    public static class AC
    {
        /// <summary>
        /// Defines the XML namespace associated with the ac prefix.
        /// </summary>
        public static readonly XNamespace ac = "http://schemas.openxmlformats.org/officeDocument/2006/characteristics";

        /// <summary>
        /// Represents the ac:additionalCharacteristics XML element.
        /// </summary>
        public static readonly XName additionalCharacteristics = ac + "additionalCharacteristics";

        /// <summary>
        /// Represents the ac:characteristic XML element.
        /// </summary>
        public static readonly XName characteristic = ac + "characteristic";
    }
}
