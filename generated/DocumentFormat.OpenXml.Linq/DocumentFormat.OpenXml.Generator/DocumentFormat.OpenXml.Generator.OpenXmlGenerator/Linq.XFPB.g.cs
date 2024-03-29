// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:xfpb="http://schemas.microsoft.com/office/spreadsheetml/2022/featurepropertybag" namespace.
    /// </summary>
    public static class XFPB
    {
        /// <summary>
        /// Defines the XML namespace associated with the xfpb prefix.
        /// </summary>
        public static readonly XNamespace xfpb = "http://schemas.microsoft.com/office/spreadsheetml/2022/featurepropertybag";

        /// <summary>
        /// Represents the xfpb:DXFComplement XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.i" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DXFComplement.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName DXFComplement = xfpb + "DXFComplement";
    }
}
