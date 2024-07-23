// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:xml="http://www.w3.org/XML/1998/namespace" namespace.
    /// </summary>
    public static partial class XML
    {
        /// <summary>
        /// Defines the XML namespace associated with the xml prefix.
        /// </summary>
        public static readonly XNamespace xml = "http://www.w3.org/XML/1998/namespace";

        /// <summary>
        /// Represents the xml:id XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="INKML.brush" />, <see cref="INKML.canvas" />, <see cref="INKML.canvasTransform" />, <see cref="INKML.channel" />, <see cref="INKML.context" />, <see cref="INKML.inkSource" />, <see cref="INKML.mapping" />, <see cref="INKML.matrix" />, <see cref="INKML.table" />, <see cref="INKML.timestamp" />, <see cref="INKML.trace" />, <see cref="INKML.traceFormat" />, <see cref="INKML.traceGroup" />, <see cref="INKML.traceView" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Brush.Id, Canvas.Id, CanvasTransform.Id, Channel.Id, Context.Id, InkSource.Id, Mapping.Id, Matrix.Id, Table.Id, Timestamp.Id, Trace.Id, TraceFormat.Id, TraceGroup.Id, TraceView.Id.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName id = xml + "id";

        /// <summary>
        /// Represents the xml:space XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="M.t" />, <see cref="X.f" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: CellFormula.Space, Text.Space.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName space = xml + "space";
    }
}
