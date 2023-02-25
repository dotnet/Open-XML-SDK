// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:inkml="http://www.w3.org/2003/InkML" namespace.
    /// </summary>
    public static class INKML
    {
        /// <summary>
        /// Defines the XML namespace associated with the inkml prefix.
        /// </summary>
        public static readonly XNamespace inkml = "http://www.w3.org/2003/InkML";

        /// <summary>
        /// Represents the inkml:activeArea XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="inkSource" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.height" />, <see cref="NoNamespace.size" />, <see cref="NoNamespace.units" />, <see cref="NoNamespace.width" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ActiveArea.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName activeArea = inkml + "activeArea";

        /// <summary>
        /// Represents the inkml:annotation XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="brush" />, <see cref="brushProperty" />, <see cref="ink" />, <see cref="traceGroup" />, <see cref="traceView" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.encoding" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Annotation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName annotation = inkml + "annotation";

        /// <summary>
        /// Represents the inkml:annotationXML XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="brush" />, <see cref="brushProperty" />, <see cref="ink" />, <see cref="traceGroup" />, <see cref="traceView" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="EMMA.emma_" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.encoding" />, <see cref="NoNamespace.href" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: AnnotationXml.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName annotationXML = inkml + "annotationXML";

        /// <summary>
        /// Represents the inkml:bind XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mapping" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.column" />, <see cref="NoNamespace.source" />, <see cref="NoNamespace.target" />, <see cref="NoNamespace.variable" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Bind.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName bind = inkml + "bind";

        /// <summary>
        /// Represents the inkml:brush XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="context" />, <see cref="definitions" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="annotation" />, <see cref="annotationXML" />, <see cref="brushProperty" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.brushRef" />, <see cref="XML.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Brush.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName brush = inkml + "brush";

        /// <summary>
        /// Represents the inkml:brushProperty XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="brush" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="annotation" />, <see cref="annotationXML" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />, <see cref="NoNamespace.units" />, <see cref="NoNamespace.value" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: BrushProperty.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName brushProperty = inkml + "brushProperty";

        /// <summary>
        /// Represents the inkml:canvas XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="context" />, <see cref="definitions" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="traceFormat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.traceFormatRef" />, <see cref="XML.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Canvas.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName canvas = inkml + "canvas";

        /// <summary>
        /// Represents the inkml:canvasTransform XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="context" />, <see cref="definitions" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="mapping" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.invertible" />, <see cref="XML.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: CanvasTransform.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName canvasTransform = inkml + "canvasTransform";

        /// <summary>
        /// Represents the inkml:channel XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="intermittentChannels" />, <see cref="traceFormat" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="mapping" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.@default" />, <see cref="NoNamespace.max" />, <see cref="NoNamespace.min" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.orientation" />, <see cref="NoNamespace.respectTo" />, <see cref="NoNamespace.type" />, <see cref="NoNamespace.units" />, <see cref="XML.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Channel.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName channel = inkml + "channel";

        /// <summary>
        /// Represents the inkml:channelProperties XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="inkSource" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="channelProperty" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ChannelProperties.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName channelProperties = inkml + "channelProperties";

        /// <summary>
        /// Represents the inkml:channelProperty XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="channelProperties" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.channel" />, <see cref="NoNamespace.name" />, <see cref="NoNamespace.units" />, <see cref="NoNamespace.value" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ChannelProperty.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName channelProperty = inkml + "channelProperty";

        /// <summary>
        /// Represents the inkml:context XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="definitions" />, <see cref="ink" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="brush" />, <see cref="canvas" />, <see cref="canvasTransform" />, <see cref="inkSource" />, <see cref="timestamp" />, <see cref="traceFormat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.brushRef" />, <see cref="NoNamespace.canvasRef" />, <see cref="NoNamespace.canvasTransformRef" />, <see cref="NoNamespace.contextRef" />, <see cref="NoNamespace.inkSourceRef" />, <see cref="NoNamespace.timestampRef" />, <see cref="NoNamespace.traceFormatRef" />, <see cref="XML.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Context.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName context = inkml + "context";

        /// <summary>
        /// Represents the inkml:definitions XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="ink" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="brush" />, <see cref="canvas" />, <see cref="canvasTransform" />, <see cref="context" />, <see cref="inkSource" />, <see cref="mapping" />, <see cref="timestamp" />, <see cref="trace" />, <see cref="traceFormat" />, <see cref="traceGroup" />, <see cref="traceView" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Definitions.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName definitions = inkml + "definitions";

        /// <summary>
        /// Represents the inkml:ink XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="annotation" />, <see cref="annotationXML" />, <see cref="context" />, <see cref="definitions" />, <see cref="trace" />, <see cref="traceGroup" />, <see cref="traceView" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.documentID" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Ink.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName ink = inkml + "ink";

        /// <summary>
        /// Represents the inkml:inkSource XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="context" />, <see cref="definitions" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="activeArea" />, <see cref="channelProperties" />, <see cref="latency" />, <see cref="sampleRate" />, <see cref="srcProperty" />, <see cref="traceFormat" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.description" />, <see cref="NoNamespace.manufacturer" />, <see cref="NoNamespace.model" />, <see cref="NoNamespace.serialNo" />, <see cref="NoNamespace.specificationRef" />, <see cref="XML.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: InkSource.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName inkSource = inkml + "inkSource";

        /// <summary>
        /// Represents the inkml:intermittentChannels XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="traceFormat" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="channel" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: IntermittentChannels.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName intermittentChannels = inkml + "intermittentChannels";

        /// <summary>
        /// Represents the inkml:latency XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="inkSource" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.value" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Latency.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName latency = inkml + "latency";

        /// <summary>
        /// Represents the inkml:mapping XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="canvasTransform" />, <see cref="channel" />, <see cref="definitions" />, <see cref="mapping" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="bind" />, <see cref="mapping" />, <see cref="matrix" />, <see cref="table" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.mappingRef" />, <see cref="NoNamespace.type" />, <see cref="XML.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Mapping.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName mapping = inkml + "mapping";

        /// <summary>
        /// Represents the inkml:matrix XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mapping" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="XML.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Matrix.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName matrix = inkml + "matrix";

        /// <summary>
        /// Represents the inkml:sampleRate XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="inkSource" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.uniform" />, <see cref="NoNamespace.value" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SampleRate.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sampleRate = inkml + "sampleRate";

        /// <summary>
        /// Represents the inkml:srcProperty XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="inkSource" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.name" />, <see cref="NoNamespace.units" />, <see cref="NoNamespace.value" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SourceProperty.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName srcProperty = inkml + "srcProperty";

        /// <summary>
        /// Represents the inkml:table XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="mapping" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.apply" />, <see cref="NoNamespace.interpolation" />, <see cref="XML.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Table.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName table = inkml + "table";

        /// <summary>
        /// Represents the inkml:timestamp XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="context" />, <see cref="definitions" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.time" />, <see cref="NoNamespace.timeOffset" />, <see cref="NoNamespace.timestampRef" />, <see cref="NoNamespace.timeString" />, <see cref="XML.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Timestamp.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName timestamp = inkml + "timestamp";

        /// <summary>
        /// Represents the inkml:trace XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="definitions" />, <see cref="ink" />, <see cref="traceGroup" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.brushRef" />, <see cref="NoNamespace.contextRef" />, <see cref="NoNamespace.continuation" />, <see cref="NoNamespace.duration" />, <see cref="NoNamespace.priorRef" />, <see cref="NoNamespace.timeOffset" />, <see cref="NoNamespace.type" />, <see cref="XML.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Trace.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName trace = inkml + "trace";

        /// <summary>
        /// Represents the inkml:traceFormat XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="canvas" />, <see cref="context" />, <see cref="definitions" />, <see cref="inkSource" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="channel" />, <see cref="intermittentChannels" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="XML.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TraceFormat.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName traceFormat = inkml + "traceFormat";

        /// <summary>
        /// Represents the inkml:traceGroup XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="definitions" />, <see cref="ink" />, <see cref="traceGroup" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="annotation" />, <see cref="annotationXML" />, <see cref="trace" />, <see cref="traceGroup" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.brushRef" />, <see cref="NoNamespace.contextRef" />, <see cref="XML.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TraceGroup.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName traceGroup = inkml + "traceGroup";

        /// <summary>
        /// Represents the inkml:traceView XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="definitions" />, <see cref="ink" />, <see cref="traceView" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="annotation" />, <see cref="annotationXML" />, <see cref="traceView" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.contextRef" />, <see cref="NoNamespace.from" />, <see cref="NoNamespace.to" />, <see cref="NoNamespace.traceDataRef" />, <see cref="XML.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: TraceView.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName traceView = inkml + "traceView";
    }
}
