// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.CustomXmlDataProperties
{
    /// <summary>
    /// <para>Custom XML Data Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ds:datastoreItem.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SchemaReferences &lt;ds:schemaRefs></description></item>
    /// </list>
    /// </remark>
    public partial class DataStoreItem : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the DataStoreItem class.
        /// </summary>
        public DataStoreItem() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataStoreItem class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataStoreItem(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataStoreItem class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataStoreItem(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataStoreItem class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataStoreItem(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Custom XML Data ID</para>
        /// <para>Represents the following attribute in the schema: ds:itemID</para>
        /// </summary>
        /// <remark>
        /// xmlns:ds=http://schemas.openxmlformats.org/officeDocument/2006/customXml
        /// </remark>
        public StringValue ItemId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(20, "datastoreItem");
            builder.AddChild<SchemaReferences>();
            builder.AddElement<DataStoreItem>()
.AddAttribute(20, "itemID", a => a.ItemId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReferences), 0, 1)
            };
        }

        /// <summary>
        /// <para>Set of Associated XML Schemas.</para>
        /// <para>Represents the following element tag in the schema: ds:schemaRefs.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ds = http://schemas.openxmlformats.org/officeDocument/2006/customXml
        /// </remark>
        public SchemaReferences SchemaReferences
        {
            get => GetElement<SchemaReferences>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataStoreItem>(deep);

        internal DataStoreItem(CustomXmlPropertiesPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the CustomXmlPropertiesPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(CustomXmlPropertiesPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the CustomXmlPropertiesPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(CustomXmlPropertiesPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the CustomXmlPropertiesPart associated with this element.
        /// </summary>
        public CustomXmlPropertiesPart CustomXmlPropertiesPart
        {
            get => OpenXmlPart as CustomXmlPropertiesPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Associated XML Schema.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ds:schemaRef.</para>
    /// </summary>
    public partial class SchemaReference : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SchemaReference class.
        /// </summary>
        public SchemaReference() : base()
        {
        }

        /// <summary>
        /// <para>Target Namespace of Associated XML Schema</para>
        /// <para>Represents the following attribute in the schema: ds:uri</para>
        /// </summary>
        /// <remark>
        /// xmlns:ds=http://schemas.openxmlformats.org/officeDocument/2006/customXml
        /// </remark>
        public StringValue Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(20, "schemaRef");
            builder.AddElement<SchemaReference>()
.AddAttribute(20, "uri", a => a.Uri, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SchemaReference>(deep);
    }

    /// <summary>
    /// <para>Set of Associated XML Schemas.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ds:schemaRefs.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SchemaReference &lt;ds:schemaRef></description></item>
    /// </list>
    /// </remark>
    public partial class SchemaReferences : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SchemaReferences class.
        /// </summary>
        public SchemaReferences() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SchemaReferences class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SchemaReferences(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SchemaReferences class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SchemaReferences(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SchemaReferences class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SchemaReferences(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(20, "schemaRefs");
            builder.AddChild<SchemaReference>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReference), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SchemaReferences>(deep);
    }
}