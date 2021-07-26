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
        public static readonly XName activeArea = inkml + "activeArea";

        /// <summary>
        /// Represents the inkml:annotation XML element.
        /// </summary>
        public static readonly XName annotation = inkml + "annotation";

        /// <summary>
        /// Represents the inkml:annotationXML XML element.
        /// </summary>
        public static readonly XName annotationXML = inkml + "annotationXML";

        /// <summary>
        /// Represents the inkml:bind XML element.
        /// </summary>
        public static readonly XName bind = inkml + "bind";

        /// <summary>
        /// Represents the inkml:brush XML element.
        /// </summary>
        public static readonly XName brush = inkml + "brush";

        /// <summary>
        /// Represents the inkml:brushProperty XML element.
        /// </summary>
        public static readonly XName brushProperty = inkml + "brushProperty";

        /// <summary>
        /// Represents the inkml:canvas XML element.
        /// </summary>
        public static readonly XName canvas = inkml + "canvas";

        /// <summary>
        /// Represents the inkml:canvasTransform XML element.
        /// </summary>
        public static readonly XName canvasTransform = inkml + "canvasTransform";

        /// <summary>
        /// Represents the inkml:channel XML element.
        /// </summary>
        public static readonly XName channel = inkml + "channel";

        /// <summary>
        /// Represents the inkml:channelProperties XML element.
        /// </summary>
        public static readonly XName channelProperties = inkml + "channelProperties";

        /// <summary>
        /// Represents the inkml:channelProperty XML element.
        /// </summary>
        public static readonly XName channelProperty = inkml + "channelProperty";

        /// <summary>
        /// Represents the inkml:context XML element.
        /// </summary>
        public static readonly XName context = inkml + "context";

        /// <summary>
        /// Represents the inkml:definitions XML element.
        /// </summary>
        public static readonly XName definitions = inkml + "definitions";

        /// <summary>
        /// Represents the inkml:ink XML element.
        /// </summary>
        public static readonly XName ink = inkml + "ink";

        /// <summary>
        /// Represents the inkml:inkSource XML element.
        /// </summary>
        public static readonly XName inkSource = inkml + "inkSource";

        /// <summary>
        /// Represents the inkml:intermittentChannels XML element.
        /// </summary>
        public static readonly XName intermittentChannels = inkml + "intermittentChannels";

        /// <summary>
        /// Represents the inkml:latency XML element.
        /// </summary>
        public static readonly XName latency = inkml + "latency";

        /// <summary>
        /// Represents the inkml:mapping XML element.
        /// </summary>
        public static readonly XName mapping = inkml + "mapping";

        /// <summary>
        /// Represents the inkml:matrix XML element.
        /// </summary>
        public static readonly XName matrix = inkml + "matrix";

        /// <summary>
        /// Represents the inkml:sampleRate XML element.
        /// </summary>
        public static readonly XName sampleRate = inkml + "sampleRate";

        /// <summary>
        /// Represents the inkml:srcProperty XML element.
        /// </summary>
        public static readonly XName srcProperty = inkml + "srcProperty";

        /// <summary>
        /// Represents the inkml:table XML element.
        /// </summary>
        public static readonly XName table = inkml + "table";

        /// <summary>
        /// Represents the inkml:timestamp XML element.
        /// </summary>
        public static readonly XName timestamp = inkml + "timestamp";

        /// <summary>
        /// Represents the inkml:trace XML element.
        /// </summary>
        public static readonly XName trace = inkml + "trace";

        /// <summary>
        /// Represents the inkml:traceFormat XML element.
        /// </summary>
        public static readonly XName traceFormat = inkml + "traceFormat";

        /// <summary>
        /// Represents the inkml:traceGroup XML element.
        /// </summary>
        public static readonly XName traceGroup = inkml + "traceGroup";

        /// <summary>
        /// Represents the inkml:traceView XML element.
        /// </summary>
        public static readonly XName traceView = inkml + "traceView";
    }
}
