// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:xml="http://www.w3.org/XML/1998/namespace" namespace.
    /// </summary>
    public static class XML
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
        /// <item><description>is contained in the following XML elements: <see cref="M.t" />, <see cref="W.delInstrText" />, <see cref="W.delText" />, <see cref="W.instrText" />, <see cref="W.t" />, <see cref="X.author" />, <see cref="X.calculatedColumnFormula" />, <see cref="X.evenFooter" />, <see cref="X.evenHeader" />, <see cref="X.f" />, <see cref="X.firstFooter" />, <see cref="X.firstHeader" />, <see cref="X.formula" />, <see cref="X.formula1" />, <see cref="X.formula2" />, <see cref="X.oddFooter" />, <see cref="X.oddHeader" />, <see cref="X.oldFormula" />, <see cref="X.stp" />, <see cref="X.t" />, <see cref="X.totalsRowFormula" />, <see cref="X.v" />, <see cref="X.val" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Author.Space, CalculatedColumnFormula.Space, CellFormula.Space, CellValue.Space, DdeLinkValue.Space, DeletedFieldCode.Space, DeletedText.Space, EvenFooter.Space, EvenHeader.Space, FieldCode.Space, FirstFooter.Space, FirstHeader.Space, Formula.Space, Formula1.Space, Formula2.Space, OddFooter.Space, OddHeader.Space, OldFormula.Space, Subtopic.Space, Text.Space, TotalsRowFormula.Space.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName space = xml + "space";
    }
}
