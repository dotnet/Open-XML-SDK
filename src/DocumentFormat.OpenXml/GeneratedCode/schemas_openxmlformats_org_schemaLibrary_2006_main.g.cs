// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.CustomXmlSchemaReferences
{
    /// <summary>
    /// <para>Embedded Custom XML Schema Supplementary Data.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is sl:schemaLibrary.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Schema &lt;sl:schema></description></item>
    /// </list>
    /// </remark>
    [ChildElementInfo(typeof(Schema))]
    [SchemaAttr(25, "schemaLibrary")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class SchemaLibrary : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SchemaLibrary class.
        /// </summary>
        public SchemaLibrary() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SchemaLibrary class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SchemaLibrary(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SchemaLibrary class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SchemaLibrary(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SchemaLibrary class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SchemaLibrary(string outerXml) : base(outerXml)
        {
        }

        private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.CustomXmlSchemaReferences.Schema), 0, 0)
        }.Compile();

        internal override CompiledParticle CompiledParticle => _constraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SchemaLibrary>(deep);
    }

    /// <summary>
    /// <para>Custom XML Schema Reference.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is sl:schema.</para>
    /// </summary>
    [SchemaAttr(25, "schema")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class Schema : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Schema class.
        /// </summary>
        public Schema() : base()
        {
        }

        /// <summary>
        /// <para>Custom XML Schema Namespace</para>
        /// <para>Represents the following attribute in the schema: sl:uri</para>
        /// </summary>
        /// <remark>
        /// xmlns:sl=http://schemas.openxmlformats.org/schemaLibrary/2006/main
        /// </remark>
        [SchemaAttr(25, "uri")]
        [Index(0)]
        public StringValue Uri { get; set; }

        /// <summary>
        /// <para>Resource File Location</para>
        /// <para>Represents the following attribute in the schema: sl:manifestLocation</para>
        /// </summary>
        /// <remark>
        /// xmlns:sl=http://schemas.openxmlformats.org/schemaLibrary/2006/main
        /// </remark>
        [SchemaAttr(25, "manifestLocation")]
        [Index(1)]
        public StringValue ManifestLocation { get; set; }

        /// <summary>
        /// <para>Custom XML Schema Location</para>
        /// <para>Represents the following attribute in the schema: sl:schemaLocation</para>
        /// </summary>
        /// <remark>
        /// xmlns:sl=http://schemas.openxmlformats.org/schemaLibrary/2006/main
        /// </remark>
        [SchemaAttr(25, "schemaLocation")]
        [Index(2)]
        public StringValue SchemaLocation { get; set; }

        private static readonly SemanticConstraint[] _semanticConstraint = new SemanticConstraint[] {
            new AttributeValueLengthConstraint(1 /*sl:manifestLocation*/, 0, 2083) { Application = ApplicationType.Word },
            new AttributeValueLengthConstraint(2 /*sl:schemaLocation*/, 0, 2083) { Application = ApplicationType.Word },
            new AttributeValueLengthConstraint(0 /*sl:uri*/, 0, 255) { Application = ApplicationType.Word }
        };

        internal override SemanticConstraint[] SemanticConstraints => _semanticConstraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Schema>(deep);
    }
}