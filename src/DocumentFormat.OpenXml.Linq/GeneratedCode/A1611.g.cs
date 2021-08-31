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
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.ext" />, <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PictureAttributionSourceURL.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName picAttrSrcUrl = a1611 + "picAttrSrcUrl";
    }
}
