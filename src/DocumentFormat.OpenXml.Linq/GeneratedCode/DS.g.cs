// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Linq
{
    /// <summary>
    /// Declares XNamespace and XName fields for the xmlns:ds="http://schemas.openxmlformats.org/officeDocument/2006/customXml" namespace.
    /// </summary>
    public static class DS
    {
        /// <summary>
        /// Defines the XML namespace associated with the ds prefix.
        /// </summary>
        public static readonly XNamespace ds = "http://schemas.openxmlformats.org/officeDocument/2006/customXml";

        /// <summary>
        /// Represents the ds:datastoreItem XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following child XML elements: <see cref="schemaRefs" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="itemID" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: DataStoreItem.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName datastoreItem = ds + "datastoreItem";

        /// <summary>
        /// Represents the ds:itemID XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="datastoreItem" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: DataStoreItem.ItemId.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName itemID = ds + "itemID";

        /// <summary>
        /// Represents the ds:schemaRef XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="schemaRefs" />.</description></item>
        /// <item><description>has the following XML attributes: <see cref="uri" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SchemaReference.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName schemaRef = ds + "schemaRef";

        /// <summary>
        /// Represents the ds:schemaRefs XML element.
        /// </summary>
        /// <remarks>
        /// <para>As an XML element, it:</para>
        /// <list type="bullet">
        /// <item><description>has the following parent XML elements: <see cref="datastoreItem" />.</description></item>
        /// <item><description>has the following child XML elements: <see cref="schemaRef" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed classes: SchemaReferences.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName schemaRefs = ds + "schemaRefs";

        /// <summary>
        /// Represents the ds:uri XML attribute.
        /// </summary>
        /// <remarks>
        /// <para>As an XML attribute, it:</para>
        /// <list type="bullet">
        /// <item><description>is contained in the following XML elements: <see cref="schemaRef" />.</description></item>
        /// <item><description>corresponds to the following strongly-typed properties: SchemaReference.Uri.</description></item>
        /// </list>
        /// </remarks>
        public static readonly XName uri = ds + "uri";
    }
}
