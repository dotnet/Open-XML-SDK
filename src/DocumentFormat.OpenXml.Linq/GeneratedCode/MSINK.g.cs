// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:msink="http://schemas.microsoft.com/ink/2010/main" namespace.
    /// </summary>
    public static class MSINK
    {
        /// <summary>
        /// Defines the XML namespace associated with the msink prefix.
        /// </summary>
        public static readonly XNamespace msink = "http://schemas.microsoft.com/ink/2010/main";

        /// <summary>
        /// Represents the msink:context XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="EMMA.interpretation" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="destinationLink" />, <see cref="property" />, <see cref="sourceLink" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.alignmentLevel" />, <see cref="NoNamespace.ascender" />, <see cref="NoNamespace.baseline" />, <see cref="NoNamespace.beginModifierType" />, <see cref="NoNamespace.centroid" />, <see cref="NoNamespace.contentType" />, <see cref="NoNamespace.customRecognizerId" />, <see cref="NoNamespace.descender" />, <see cref="NoNamespace.endModifierType" />, <see cref="NoNamespace.hotPoints" />, <see cref="NoNamespace.id" />, <see cref="NoNamespace.mathML" />, <see cref="NoNamespace.mathStruct" />, <see cref="NoNamespace.mathSymbol" />, <see cref="NoNamespace.midline" />, <see cref="NoNamespace.rotatedBoundingBox" />, <see cref="NoNamespace.rotationAngle_" />, <see cref="NoNamespace.semanticType" />, <see cref="NoNamespace.shapeGeometry" />, <see cref="NoNamespace.shapeName" />, <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ContextNode.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName context = msink + "context";

        /// <summary>
        /// Represents the msink:destinationLink XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="context" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.direction" />, <see cref="NoNamespace.@ref" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DestinationLink.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName destinationLink = msink + "destinationLink";

        /// <summary>
        /// Represents the msink:property XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="context" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.type" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: ContextNodeProperty.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName property = msink + "property";

        /// <summary>
        /// Represents the msink:sourceLink XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="context" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="NoNamespace.direction" />, <see cref="NoNamespace.@ref" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SourceLink.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName sourceLink = msink + "sourceLink";
    }
}
