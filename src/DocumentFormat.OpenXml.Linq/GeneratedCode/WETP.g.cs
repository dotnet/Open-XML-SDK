// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:wetp="http://schemas.microsoft.com/office/webextensions/taskpanes/2010/11" namespace.
    /// </summary>
    public static class WETP
    {
        /// <summary>
        /// Defines the XML namespace associated with the wetp prefix.
        /// </summary>
        public static readonly XNamespace wetp = "http://schemas.microsoft.com/office/webextensions/taskpanes/2010/11";

        /// <summary>
        /// Represents the wetp:extLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="taskpane" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="A.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OfficeArtExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = wetp + "extLst";

        /// <summary>
        /// Represents the wetp:taskpane XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="taskpanes" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="webextensionref" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.dockstate" />, <see cref="NoNamespace.locked" />, <see cref="NoNamespace.row" />, <see cref="NoNamespace.visibility" />, <see cref="NoNamespace.width" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WebExtensionTaskpane.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName taskpane = wetp + "taskpane";

        /// <summary>
        /// Represents the wetp:taskpanes XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="taskpane" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Taskpanes.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName taskpanes = wetp + "taskpanes";

        /// <summary>
        /// Represents the wetp:webextensionref XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="taskpane" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="R.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: WebExtensionPartReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName webextensionref = wetp + "webextensionref";
    }
}
