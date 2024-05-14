// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:xlmsforms="http://schemas.microsoft.com/office/spreadsheetml/2023/msForms" namespace.
    /// </summary>
    public static class XLMSFORMS
    {
        /// <summary>
        /// Defines the XML namespace associated with the xlmsforms prefix.
        /// </summary>
        public static readonly XNamespace xlmsforms = "http://schemas.microsoft.com/office/spreadsheetml/2023/msForms";

        /// <summary>
        /// Represents the xlmsforms:extLst XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="msForm" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ExtensionList.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName extLst = xlmsforms + "extLst";

        /// <summary>
        /// Represents the xlmsforms:msForm XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="X.ext" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="extLst" />, <see cref="syncedQuestionId" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />, <see cref="NoNamespace.isFormConnected" />, <see cref="NoNamespace.latestEventMarker" />, <see cref="NoNamespace.maxResponseId" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: MsForm.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName msForm = xlmsforms + "msForm";

        /// <summary>
        /// Represents the xlmsforms:syncedQuestionId XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="msForm" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SyncedQuestionId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName syncedQuestionId = xlmsforms + "syncedQuestionId";
    }
}
