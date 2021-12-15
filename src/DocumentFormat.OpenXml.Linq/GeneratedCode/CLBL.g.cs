// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:clbl="http://schemas.microsoft.com/office/2020/mipLabelMetadata" namespace.
    /// </summary>
    public static class CLBL
    {
        /// <summary>
        /// Defines the XML namespace associated with the clbl prefix.
        /// </summary>
        public static readonly XNamespace clbl = "http://schemas.microsoft.com/office/2020/mipLabelMetadata";

        /// <summary>
        /// Represents the clbl:ext XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="extLst" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.uri" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ClassificationExtension.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ext = clbl + "ext";

        /// <summary>
        /// Represents the clbl:extLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="labelList" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ClassificationExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = clbl + "extLst";

        /// <summary>
        /// Represents the clbl:label XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="labelList" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.actionId" />, <see cref="NoNamespace.contentBits" />, <see cref="NoNamespace.enabled" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.method" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.removed" />, <see cref="NoNamespace.setDate" />, <see cref="NoNamespace.siteId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ClassificationLabel.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName label = clbl + "label";

        /// <summary>
        /// Represents the clbl:labelList XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="label" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ClassificationLabelList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName labelList = clbl + "labelList";
    }
}
