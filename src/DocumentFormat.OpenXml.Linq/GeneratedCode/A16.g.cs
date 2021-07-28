// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:a16="http://schemas.microsoft.com/office/drawing/2014/main" namespace.
    /// </summary>
    public static class A16
    {
        /// <summary>
        /// Defines the XML namespace associated with the a16 prefix.
        /// </summary>
        public static readonly XNamespace a16 = "http://schemas.microsoft.com/office/drawing/2014/main";

        /// <summary>
        /// Represents the a16:colId XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ColIdIdentifier.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName colId = a16 + "colId";

        /// <summary>
        /// Represents the a16:creationId XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.ext" />, <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CreationId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName creationId = a16 + "creationId";

        /// <summary>
        /// Represents the a16:cxnDERefs XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.end" />, <see cref="NoNamespace.st" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ConnectableReferences.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cxnDERefs = a16 + "cxnDERefs";

        /// <summary>
        /// Represents the a16:predDERef XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.ext" />, <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.pred" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: PredecessorDrawingElementReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName predDERef = a16 + "predDERef";

        /// <summary>
        /// Represents the a16:rowId XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: RowIdIdentifier.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName rowId = a16 + "rowId";
    }
}
