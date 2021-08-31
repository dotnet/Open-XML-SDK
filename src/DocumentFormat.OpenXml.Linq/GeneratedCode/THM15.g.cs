// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:thm15="http://schemas.microsoft.com/office/thememl/2012/main" namespace.
    /// </summary>
    public static class THM15
    {
        /// <summary>
        /// Defines the XML namespace associated with the thm15 prefix.
        /// </summary>
        public static readonly XNamespace thm15 = "http://schemas.microsoft.com/office/thememl/2012/main";

        /// <summary>
        /// Represents the thm15:extLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="themeFamily" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OfficeArtExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = thm15 + "extLst";

        /// <summary>
        /// Represents the thm15:id XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="A.theme" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Theme.ThemeId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName id = thm15 + "id";

        /// <summary>
        /// Represents the thm15:themeFamily XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.ext" />, <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.vid" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ThemeFamily.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName themeFamily = thm15 + "themeFamily";
    }
}
