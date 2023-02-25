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
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="lattice" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="info" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="confidence" />, <see cref="cost" />, <see cref="duration" />, <see cref="end" />, <see cref="lang" />, <see cref="medium" />, <see cref="mode" />, <see cref="offset_to_start" />, <see cref="source" />, <see cref="start" />, <see cref="NoNamespace.from" />, <see cref="NoNamespace.to" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Arc.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName arc = emma + "arc";

        /// <summary>
        /// Represents the emma:confidence XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="arc" />, <see cref="group" />, <see cref="interpretation" />, <see cref="node" />, <see cref="one_of" />, <see cref="sequence" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.Confidence, Group.Confidence, Interpretation.Confidence, Node.Confidence, OneOf.Confidence, Sequence.Confidence.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName confidence = emma + "confidence";

        /// <summary>
        /// Represents the emma:cost XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="arc" />, <see cref="group" />, <see cref="interpretation" />, <see cref="node" />, <see cref="one_of" />, <see cref="sequence" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.Cost, Group.Cost, Interpretation.Cost, Node.Cost, OneOf.Cost, Sequence.Cost.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName cost = emma + "cost";

        /// <summary>
        /// Represents the emma:derivation XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="emma_" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="group" />, <see cref="interpretation" />, <see cref="one_of" />, <see cref="sequence" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Derivation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName derivation = emma + "derivation";

        /// <summary>
        /// Represents the emma:derived-from XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="group" />, <see cref="interpretation" />, <see cref="one_of" />, <see cref="sequence" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.composite" />, <see cref="NoNamespace.resource" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DerivedFrom.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName derived_from = emma + "derived-from";

        /// <summary>
        /// Represents the emma:dialog-turn XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="group" />, <see cref="interpretation" />, <see cref="one_of" />, <see cref="sequence" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Group.DialogTurn, Interpretation.DialogTurn, OneOf.DialogTurn, Sequence.DialogTurn.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName dialog_turn = emma + "dialog-turn";

        /// <summary>
        /// Represents the emma:duration XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="arc" />, <see cref="group" />, <see cref="interpretation" />, <see cref="one_of" />, <see cref="sequence" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.Duration, Group.Duration, Interpretation.Duration, OneOf.Duration, Sequence.Duration.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName duration = emma + "duration";

        /// <summary>
        /// Represents the emma:emma XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="INKML.annotationXML" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="derivation" />, <see cref="endpoint_info" />, <see cref="grammar" />, <see cref="group" />, <see cref="info" />, <see cref="interpretation" />, <see cref="model" />, <see cref="one_of" />, <see cref="sequence" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.version" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Emma.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName emma_ = emma + "emma";

        /// <summary>
        /// Represents the emma:end XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="arc" />, <see cref="group" />, <see cref="interpretation" />, <see cref="one_of" />, <see cref="sequence" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.End, Group.End, Interpretation.End, OneOf.End, Sequence.End.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName end = emma + "end";

        /// <summary>
        /// Represents the emma:endpoint XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="endpoint_info" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="endpoint_address" />, <see cref="endpoint_pair_ref" />, <see cref="endpoint_role" />, <see cref="media_type" />, <see cref="medium" />, <see cref="message_id" />, <see cref="mode" />, <see cref="port_num" />, <see cref="port_type" />, <see cref="service_name" />, <see cref="NoNamespace.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EndPoint.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName endpoint = emma + "endpoint";

        /// <summary>
        /// Represents the emma:endpoint-address XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="endpoint" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: EndPoint.EndPointAddress.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName endpoint_address = emma + "endpoint-address";

        /// <summary>
        /// Represents the emma:endpoint-info XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="emma_" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="endpoint" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: EndPointInfo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName endpoint_info = emma + "endpoint-info";

        /// <summary>
        /// Represents the emma:endpoint-info-ref XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="group" />, <see cref="interpretation" />, <see cref="one_of" />, <see cref="sequence" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Group.EndpointInfoRef, Interpretation.EndpointInfoRef, OneOf.EndpointInfoRef, Sequence.EndpointInfoRef.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName endpoint_info_ref = emma + "endpoint-info-ref";

        /// <summary>
        /// Represents the emma:endpoint-pair-ref XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="endpoint" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: EndPoint.EndpointPairRef.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName endpoint_pair_ref = emma + "endpoint-pair-ref";

        /// <summary>
        /// Represents the emma:endpoint-role XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="endpoint" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: EndPoint.EndpointRole.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName endpoint_role = emma + "endpoint-role";

        /// <summary>
        /// Represents the emma:function XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="group" />, <see cref="interpretation" />, <see cref="one_of" />, <see cref="sequence" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Group.Function, Interpretation.Function, OneOf.Function, Sequence.Function.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName function = emma + "function";

        /// <summary>
        /// Represents the emma:grammar XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="emma_" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />, <see cref="NoNamespace.@ref" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Grammar.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName grammar = emma + "grammar";

        /// <summary>
        /// Represents the emma:grammar-ref XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="group" />, <see cref="interpretation" />, <see cref="one_of" />, <see cref="sequence" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Group.GrammarRef, Interpretation.GrammarRef, OneOf.GrammarRef, Sequence.GrammarRef.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName grammar_ref = emma + "grammar-ref";

        /// <summary>
        /// Represents the emma:group XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="derivation" />, <see cref="emma_" />, <see cref="group" />, <see cref="one_of" />, <see cref="sequence" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="derived_from" />, <see cref="group" />, <see cref="group_info" />, <see cref="info" />, <see cref="interpretation" />, <see cref="one_of" />, <see cref="sequence" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="confidence" />, <see cref="cost" />, <see cref="dialog_turn" />, <see cref="duration" />, <see cref="end" />, <see cref="endpoint_info_ref" />, <see cref="function" />, <see cref="grammar_ref" />, <see cref="lang" />, <see cref="media_type" />, <see cref="medium" />, <see cref="mode" />, <see cref="model_ref" />, <see cref="offset_to_start" />, <see cref="process" />, <see cref="signal" />, <see cref="signal_size" />, <see cref="source" />, <see cref="start" />, <see cref="time_ref_anchor_point" />, <see cref="time_ref_uri" />, <see cref="tokens" />, <see cref="verbal" />, <see cref="NoNamespace.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Group.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName group = emma + "group";

        /// <summary>
        /// Represents the emma:group-info XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="group" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.@ref" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: GroupInfo.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName group_info = emma + "group-info";

        /// <summary>
        /// Represents the emma:info XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="arc" />, <see cref="emma_" />, <see cref="group" />, <see cref="interpretation" />, <see cref="node" />, <see cref="one_of" />, <see cref="sequence" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Info.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName info = emma + "info";

        /// <summary>
        /// Represents the emma:interpretation XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="derivation" />, <see cref="emma_" />, <see cref="group" />, <see cref="one_of" />, <see cref="sequence" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="derived_from" />, <see cref="info" />, <see cref="lattice" />, <see cref="literal" />, <see cref="MSINK.context" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="confidence" />, <see cref="cost" />, <see cref="dialog_turn" />, <see cref="duration" />, <see cref="end" />, <see cref="endpoint_info_ref" />, <see cref="function" />, <see cref="grammar_ref" />, <see cref="lang" />, <see cref="media_type" />, <see cref="medium" />, <see cref="mode" />, <see cref="model_ref" />, <see cref="no_input" />, <see cref="offset_to_start" />, <see cref="process" />, <see cref="signal" />, <see cref="signal_size" />, <see cref="source" />, <see cref="start" />, <see cref="time_ref_anchor_point" />, <see cref="time_ref_uri" />, <see cref="tokens" />, <see cref="uninterpreted" />, <see cref="verbal" />, <see cref="NoNamespace.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Interpretation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName interpretation = emma + "interpretation";

        /// <summary>
        /// Represents the emma:lang XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="arc" />, <see cref="group" />, <see cref="interpretation" />, <see cref="one_of" />, <see cref="sequence" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.Language, Group.Language, Interpretation.Language, OneOf.Language, Sequence.Language.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lang = emma + "lang";

        /// <summary>
        /// Represents the emma:lattice XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="interpretation" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="arc" />, <see cref="node" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="time_ref_anchor_point" />, <see cref="time_ref_uri" />, <see cref="NoNamespace.final" />, <see cref="NoNamespace.initial" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Lattice.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName lattice = emma + "lattice";

        /// <summary>
        /// Represents the emma:literal XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="interpretation" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Literal.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName literal = emma + "literal";

        /// <summary>
        /// Represents the emma:media-type XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="endpoint" />, <see cref="group" />, <see cref="interpretation" />, <see cref="one_of" />, <see cref="sequence" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: EndPoint.MediaType, Group.MediaType, Interpretation.MediaType, OneOf.MediaType, Sequence.MediaType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName media_type = emma + "media-type";

        /// <summary>
        /// Represents the emma:medium XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="arc" />, <see cref="endpoint" />, <see cref="group" />, <see cref="interpretation" />, <see cref="one_of" />, <see cref="sequence" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.Medium, EndPoint.Medium, Group.Medium, Interpretation.Medium, OneOf.Medium, Sequence.Medium.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName medium = emma + "medium";

        /// <summary>
        /// Represents the emma:message-id XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="endpoint" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: EndPoint.MessageId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName message_id = emma + "message-id";

        /// <summary>
        /// Represents the emma:mode XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="arc" />, <see cref="endpoint" />, <see cref="group" />, <see cref="interpretation" />, <see cref="one_of" />, <see cref="sequence" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.Mode, EndPoint.Mode, Group.Mode, Interpretation.Mode, OneOf.Mode, Sequence.Mode.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName mode = emma + "mode";

        /// <summary>
        /// Represents the emma:model XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="emma_" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.id" />, <see cref="NoNamespace.@ref" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Model.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName model = emma + "model";

        /// <summary>
        /// Represents the emma:model-ref XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="group" />, <see cref="interpretation" />, <see cref="one_of" />, <see cref="sequence" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Group.ModelRef, Interpretation.ModelRef, OneOf.ModelRef, Sequence.ModelRef.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName model_ref = emma + "model-ref";

        /// <summary>
        /// Represents the emma:no-input XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="interpretation" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Interpretation.NoInput.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName no_input = emma + "no-input";

        /// <summary>
        /// Represents the emma:node XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="lattice" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="info" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="confidence" />, <see cref="cost" />, <see cref="NoNamespace.node_number" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Node.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName node = emma + "node";

        /// <summary>
        /// Represents the emma:offset-to-start XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="arc" />, <see cref="group" />, <see cref="interpretation" />, <see cref="one_of" />, <see cref="sequence" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.OffsetToStart, Group.OffsetToStart, Interpretation.OffsetToStart, OneOf.OffsetToStart, Sequence.OffsetToStart.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName offset_to_start = emma + "offset-to-start";

        /// <summary>
        /// Represents the emma:one-of XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="derivation" />, <see cref="emma_" />, <see cref="group" />, <see cref="one_of" />, <see cref="sequence" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="derived_from" />, <see cref="group" />, <see cref="info" />, <see cref="interpretation" />, <see cref="one_of" />, <see cref="sequence" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.disjunction_type" />, <see cref="confidence" />, <see cref="cost" />, <see cref="dialog_turn" />, <see cref="duration" />, <see cref="end" />, <see cref="endpoint_info_ref" />, <see cref="function" />, <see cref="grammar_ref" />, <see cref="lang" />, <see cref="media_type" />, <see cref="medium" />, <see cref="mode" />, <see cref="model_ref" />, <see cref="offset_to_start" />, <see cref="process" />, <see cref="signal" />, <see cref="signal_size" />, <see cref="source" />, <see cref="start" />, <see cref="time_ref_anchor_point" />, <see cref="time_ref_uri" />, <see cref="tokens" />, <see cref="verbal" />, <see cref="NoNamespace.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: OneOf.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName one_of = emma + "one-of";

        /// <summary>
        /// Represents the emma:port-num XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="endpoint" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: EndPoint.PortNumber.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName port_num = emma + "port-num";

        /// <summary>
        /// Represents the emma:port-type XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="endpoint" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: EndPoint.PortType.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName port_type = emma + "port-type";

        /// <summary>
        /// Represents the emma:process XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="group" />, <see cref="interpretation" />, <see cref="one_of" />, <see cref="sequence" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Group.Process, Interpretation.Process, OneOf.Process, Sequence.Process.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName process = emma + "process";

        /// <summary>
        /// Represents the emma:sequence XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="derivation" />, <see cref="emma_" />, <see cref="group" />, <see cref="one_of" />, <see cref="sequence" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="derived_from" />, <see cref="group" />, <see cref="info" />, <see cref="interpretation" />, <see cref="one_of" />, <see cref="sequence" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="confidence" />, <see cref="cost" />, <see cref="dialog_turn" />, <see cref="duration" />, <see cref="end" />, <see cref="endpoint_info_ref" />, <see cref="function" />, <see cref="grammar_ref" />, <see cref="lang" />, <see cref="media_type" />, <see cref="medium" />, <see cref="mode" />, <see cref="model_ref" />, <see cref="offset_to_start" />, <see cref="process" />, <see cref="signal" />, <see cref="signal_size" />, <see cref="source" />, <see cref="start" />, <see cref="time_ref_anchor_point" />, <see cref="time_ref_uri" />, <see cref="tokens" />, <see cref="verbal" />, <see cref="NoNamespace.id" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Sequence.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sequence = emma + "sequence";

        /// <summary>
        /// Represents the emma:service-name XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="endpoint" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: EndPoint.ServiceName.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName service_name = emma + "service-name";

        /// <summary>
        /// Represents the emma:signal XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="group" />, <see cref="interpretation" />, <see cref="one_of" />, <see cref="sequence" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Group.Signal, Interpretation.Signal, OneOf.Signal, Sequence.Signal.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName signal = emma + "signal";

        /// <summary>
        /// Represents the emma:signal-size XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="group" />, <see cref="interpretation" />, <see cref="one_of" />, <see cref="sequence" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Group.SignalSize, Interpretation.SignalSize, OneOf.SignalSize, Sequence.SignalSize.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName signal_size = emma + "signal-size";

        /// <summary>
        /// Represents the emma:source XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="arc" />, <see cref="group" />, <see cref="interpretation" />, <see cref="one_of" />, <see cref="sequence" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.Source, Group.Source, Interpretation.Source, OneOf.Source, Sequence.Source.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName source = emma + "source";

        /// <summary>
        /// Represents the emma:start XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="arc" />, <see cref="group" />, <see cref="interpretation" />, <see cref="one_of" />, <see cref="sequence" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Arc.Start, Group.Start, Interpretation.Start, OneOf.Start, Sequence.Start.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName start = emma + "start";

        /// <summary>
        /// Represents the emma:time-ref-anchor-point XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="group" />, <see cref="interpretation" />, <see cref="lattice" />, <see cref="one_of" />, <see cref="sequence" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Group.TimeReferenceAnchorPoint, Interpretation.TimeReferenceAnchorPoint, Lattice.TimeReferenceAnchorPoint, OneOf.TimeReferenceAnchorPoint, Sequence.TimeReferenceAnchorPoint.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName time_ref_anchor_point = emma + "time-ref-anchor-point";

        /// <summary>
        /// Represents the emma:time-ref-uri XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="group" />, <see cref="interpretation" />, <see cref="lattice" />, <see cref="one_of" />, <see cref="sequence" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Group.TimeReference, Interpretation.TimeReference, Lattice.TimeReference, OneOf.TimeReference, Sequence.TimeReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName time_ref_uri = emma + "time-ref-uri";

        /// <summary>
        /// Represents the emma:tokens XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="group" />, <see cref="interpretation" />, <see cref="one_of" />, <see cref="sequence" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Group.Tokens, Interpretation.Tokens, OneOf.Tokens, Sequence.Tokens.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName tokens = emma + "tokens";

        /// <summary>
        /// Represents the emma:uninterpreted XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="interpretation" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Interpretation.Uninterpreted.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName uninterpreted = emma + "uninterpreted";

        /// <summary>
        /// Represents the emma:verbal XML attributes.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="group" />, <see cref="interpretation" />, <see cref="one_of" />, <see cref="sequence" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Group.Verbal, Interpretation.Verbal, OneOf.Verbal, Sequence.Verbal.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName verbal = emma + "verbal";
    }
}
