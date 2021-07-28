// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:pvml="urn:schemas-microsoft-com:office:powerpoint" namespace.
    /// </summary>
    public static class PVML
    {
        /// <summary>
        /// Defines the XML namespace associated with the pvml prefix.
        /// </summary>
        public static readonly XNamespace pvml = "urn:schemas-microsoft-com:office:powerpoint";

        /// <summary>
        /// Represents the pvml:iscomment XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="V.shape" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: InkAnnotationFlag.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName iscomment = pvml + "iscomment";

        /// <summary>
        /// Represents the pvml:textdata XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="V.arc" />, <see cref="V.curve" />, <see cref="V.image" />, <see cref="V.line" />, <see cref="V.oval" />, <see cref="V.polyline" />, <see cref="V.rect" />, <see cref="V.roundrect" />, <see cref="V.shape" />, <see cref="V.shapetype" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TextData.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName textdata = pvml + "textdata";
    }
}
