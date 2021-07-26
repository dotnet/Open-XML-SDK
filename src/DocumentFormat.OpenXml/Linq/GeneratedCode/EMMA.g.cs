// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:emma="http://www.w3.org/2003/04/emma" namespace.
    /// </summary>
    public static class EMMA
    {
        /// <summary>
        /// Defines the XML namespace associated with the emma prefix.
        /// </summary>
        public static readonly XNamespace emma = "http://www.w3.org/2003/04/emma";

        /// <summary>
        /// Represents the emma:arc XML element.
        /// </summary>
        public static readonly XName arc = emma + "arc";

        /// <summary>
        /// Represents the emma:confidence XML attributes.
        /// </summary>
        public static readonly XName confidence = emma + "confidence";

        /// <summary>
        /// Represents the emma:cost XML attributes.
        /// </summary>
        public static readonly XName cost = emma + "cost";

        /// <summary>
        /// Represents the emma:derivation XML element.
        /// </summary>
        public static readonly XName derivation = emma + "derivation";

        /// <summary>
        /// Represents the emma:derived-from XML element.
        /// </summary>
        public static readonly XName derived_from = emma + "derived-from";

        /// <summary>
        /// Represents the emma:dialog-turn XML attributes.
        /// </summary>
        public static readonly XName dialog_turn = emma + "dialog-turn";

        /// <summary>
        /// Represents the emma:duration XML attributes.
        /// </summary>
        public static readonly XName duration = emma + "duration";

        /// <summary>
        /// Represents the emma:emma XML element.
        /// </summary>
        public static readonly XName emma_ = emma + "emma";

        /// <summary>
        /// Represents the emma:end XML attributes.
        /// </summary>
        public static readonly XName end = emma + "end";

        /// <summary>
        /// Represents the emma:endpoint XML element.
        /// </summary>
        public static readonly XName endpoint = emma + "endpoint";

        /// <summary>
        /// Represents the emma:endpoint-address XML attribute.
        /// </summary>
        public static readonly XName endpoint_address = emma + "endpoint-address";

        /// <summary>
        /// Represents the emma:endpoint-info XML element.
        /// </summary>
        public static readonly XName endpoint_info = emma + "endpoint-info";

        /// <summary>
        /// Represents the emma:endpoint-info-ref XML attributes.
        /// </summary>
        public static readonly XName endpoint_info_ref = emma + "endpoint-info-ref";

        /// <summary>
        /// Represents the emma:endpoint-pair-ref XML attribute.
        /// </summary>
        public static readonly XName endpoint_pair_ref = emma + "endpoint-pair-ref";

        /// <summary>
        /// Represents the emma:endpoint-role XML attribute.
        /// </summary>
        public static readonly XName endpoint_role = emma + "endpoint-role";

        /// <summary>
        /// Represents the emma:function XML attributes.
        /// </summary>
        public static readonly XName function = emma + "function";

        /// <summary>
        /// Represents the emma:grammar XML element.
        /// </summary>
        public static readonly XName grammar = emma + "grammar";

        /// <summary>
        /// Represents the emma:grammar-ref XML attributes.
        /// </summary>
        public static readonly XName grammar_ref = emma + "grammar-ref";

        /// <summary>
        /// Represents the emma:group XML element.
        /// </summary>
        public static readonly XName group = emma + "group";

        /// <summary>
        /// Represents the emma:group-info XML element.
        /// </summary>
        public static readonly XName group_info = emma + "group-info";

        /// <summary>
        /// Represents the emma:info XML element.
        /// </summary>
        public static readonly XName info = emma + "info";

        /// <summary>
        /// Represents the emma:interpretation XML element.
        /// </summary>
        public static readonly XName interpretation = emma + "interpretation";

        /// <summary>
        /// Represents the emma:lang XML attributes.
        /// </summary>
        public static readonly XName lang = emma + "lang";

        /// <summary>
        /// Represents the emma:lattice XML element.
        /// </summary>
        public static readonly XName lattice = emma + "lattice";

        /// <summary>
        /// Represents the emma:literal XML element.
        /// </summary>
        public static readonly XName literal = emma + "literal";

        /// <summary>
        /// Represents the emma:media-type XML attributes.
        /// </summary>
        public static readonly XName media_type = emma + "media-type";

        /// <summary>
        /// Represents the emma:medium XML attributes.
        /// </summary>
        public static readonly XName medium = emma + "medium";

        /// <summary>
        /// Represents the emma:message-id XML attribute.
        /// </summary>
        public static readonly XName message_id = emma + "message-id";

        /// <summary>
        /// Represents the emma:mode XML attributes.
        /// </summary>
        public static readonly XName mode = emma + "mode";

        /// <summary>
        /// Represents the emma:model XML element.
        /// </summary>
        public static readonly XName model = emma + "model";

        /// <summary>
        /// Represents the emma:model-ref XML attributes.
        /// </summary>
        public static readonly XName model_ref = emma + "model-ref";

        /// <summary>
        /// Represents the emma:no-input XML attribute.
        /// </summary>
        public static readonly XName no_input = emma + "no-input";

        /// <summary>
        /// Represents the emma:node XML element.
        /// </summary>
        public static readonly XName node = emma + "node";

        /// <summary>
        /// Represents the emma:offset-to-start XML attributes.
        /// </summary>
        public static readonly XName offset_to_start = emma + "offset-to-start";

        /// <summary>
        /// Represents the emma:one-of XML element.
        /// </summary>
        public static readonly XName one_of = emma + "one-of";

        /// <summary>
        /// Represents the emma:port-num XML attribute.
        /// </summary>
        public static readonly XName port_num = emma + "port-num";

        /// <summary>
        /// Represents the emma:port-type XML attribute.
        /// </summary>
        public static readonly XName port_type = emma + "port-type";

        /// <summary>
        /// Represents the emma:process XML attributes.
        /// </summary>
        public static readonly XName process = emma + "process";

        /// <summary>
        /// Represents the emma:sequence XML element.
        /// </summary>
        public static readonly XName sequence = emma + "sequence";

        /// <summary>
        /// Represents the emma:service-name XML attribute.
        /// </summary>
        public static readonly XName service_name = emma + "service-name";

        /// <summary>
        /// Represents the emma:signal XML attributes.
        /// </summary>
        public static readonly XName signal = emma + "signal";

        /// <summary>
        /// Represents the emma:signal-size XML attributes.
        /// </summary>
        public static readonly XName signal_size = emma + "signal-size";

        /// <summary>
        /// Represents the emma:source XML attributes.
        /// </summary>
        public static readonly XName source = emma + "source";

        /// <summary>
        /// Represents the emma:start XML attributes.
        /// </summary>
        public static readonly XName start = emma + "start";

        /// <summary>
        /// Represents the emma:time-ref-anchor-point XML attributes.
        /// </summary>
        public static readonly XName time_ref_anchor_point = emma + "time-ref-anchor-point";

        /// <summary>
        /// Represents the emma:time-ref-uri XML attributes.
        /// </summary>
        public static readonly XName time_ref_uri = emma + "time-ref-uri";

        /// <summary>
        /// Represents the emma:tokens XML attributes.
        /// </summary>
        public static readonly XName tokens = emma + "tokens";

        /// <summary>
        /// Represents the emma:uninterpreted XML attribute.
        /// </summary>
        public static readonly XName uninterpreted = emma + "uninterpreted";

        /// <summary>
        /// Represents the emma:verbal XML attributes.
        /// </summary>
        public static readonly XName verbal = emma + "verbal";
    }
}
