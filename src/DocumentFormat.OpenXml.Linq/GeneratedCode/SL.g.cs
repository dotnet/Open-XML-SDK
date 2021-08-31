// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:sl="http://schemas.openxmlformats.org/schemaLibrary/2006/main" namespace.
    /// </summary>
    public static class SL
    {
        /// <summary>
        /// Defines the XML namespace associated with the sl prefix.
        /// </summary>
        public static readonly XNamespace sl = "http://schemas.openxmlformats.org/schemaLibrary/2006/main";

        /// <summary>
        /// Represents the sl:manifestLocation XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="schema" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Schema.ManifestLocation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName manifestLocation = sl + "manifestLocation";

        /// <summary>
        /// Represents the sl:schema XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="schemaLibrary" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="manifestLocation" />, <see cref="schemaLocation" />, <see cref="uri" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: Schema.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName schema = sl + "schema";

        /// <summary>
        /// Represents the sl:schemaLibrary XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="A.graphicData" />, <see cref="W.settings" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="schema" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SchemaLibrary.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName schemaLibrary = sl + "schemaLibrary";

        /// <summary>
        /// Represents the sl:schemaLocation XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="schema" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Schema.SchemaLocation.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName schemaLocation = sl + "schemaLocation";

        /// <summary>
        /// Represents the sl:uri XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="schema" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: Schema.Uri.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName uri = sl + "uri";
    }
}
