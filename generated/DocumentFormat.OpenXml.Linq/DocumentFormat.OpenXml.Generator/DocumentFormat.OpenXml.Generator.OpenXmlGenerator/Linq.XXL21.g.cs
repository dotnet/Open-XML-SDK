// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;


namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:xxl21="http://schemas.microsoft.com/office/spreadsheetml/2021/extlinks2021" namespace.
    /// </summary>
    public static class XXL21
    {
        /// <summary>
        /// Defines the XML namespace associated with the xxl21 prefix.
        /// </summary>
        public static readonly XNamespace xxl21 = "http://schemas.microsoft.com/office/spreadsheetml/2021/extlinks2021";

        /// <summary>
        /// Represents the xxl21:absoluteUrl XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="alternateUrls" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AbsoluteUrlAlternateUrl.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName absoluteUrl = xxl21 + "absoluteUrl";

        /// <summary>
        /// Represents the xxl21:alternateUrls XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.externalBook" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="absoluteUrl" />, <see cref="relativeUrl" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.driveId" />, <see cref="NoNamespace.itemId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExternalBookAlternateUrls.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName alternateUrls = xxl21 + "alternateUrls";

        /// <summary>
        /// Represents the xxl21:relativeUrl XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="alternateUrls" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RelativeUrlAlternateUrl.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName relativeUrl = xxl21 + "relativeUrl";
    }
}
