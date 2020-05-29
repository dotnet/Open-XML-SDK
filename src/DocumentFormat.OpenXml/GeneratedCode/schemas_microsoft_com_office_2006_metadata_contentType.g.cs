// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Office.MetaAttributes;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office.ContentType
{
    /// <summary>
    /// <para>Defines the ContentTypeSchema Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ct:contentTypeSchema.</para>
    /// </summary>
    public partial class ContentTypeSchema : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ContentTypeSchema class.
        /// </summary>
        public ContentTypeSchema() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContentTypeSchema class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ContentTypeSchema(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContentTypeSchema class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ContentTypeSchema(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContentTypeSchema class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ContentTypeSchema(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>_</para>
        /// <para>Represents the following attribute in the schema: ct:_</para>
        /// </summary>
        /// <remark>
        /// xmlns:ct=http://schemas.microsoft.com/office/2006/metadata/contentType
        /// </remark>
        public StringValue UnderScore
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>_</para>
        /// <para>Represents the following attribute in the schema: ma:_</para>
        /// </summary>
        /// <remark>
        /// xmlns:ma=http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes
        /// </remark>
        public StringValue ReservedAttributeString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>contentTypeName</para>
        /// <para>Represents the following attribute in the schema: ma:contentTypeName</para>
        /// </summary>
        /// <remark>
        /// xmlns:ma=http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes
        /// </remark>
        public StringValue ContentTypeName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>contentTypeID</para>
        /// <para>Represents the following attribute in the schema: ma:contentTypeID</para>
        /// </summary>
        /// <remark>
        /// xmlns:ma=http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes
        /// </remark>
        public StringValue ContentTypeID
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>contentTypeVersion</para>
        /// <para>Represents the following attribute in the schema: ma:contentTypeVersion</para>
        /// </summary>
        /// <remark>
        /// xmlns:ma=http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes
        /// </remark>
        public Int32Value ContentTypeVersion
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>contentTypeDescription</para>
        /// <para>Represents the following attribute in the schema: ma:contentTypeDescription</para>
        /// </summary>
        /// <remark>
        /// xmlns:ma=http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes
        /// </remark>
        public StringValue ContentTypeDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>contentTypeScope</para>
        /// <para>Represents the following attribute in the schema: ma:contentTypeScope</para>
        /// </summary>
        /// <remark>
        /// xmlns:ma=http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes
        /// </remark>
        public StringValue ContentTypeScope
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>versionID</para>
        /// <para>Represents the following attribute in the schema: ma:versionID</para>
        /// </summary>
        /// <remark>
        /// xmlns:ma=http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes
        /// </remark>
        public StringValue VersionID
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(38, "contentTypeSchema");
            builder.AddElement<ContentTypeSchema>()
.AddAttribute(38, "_", a => a.UnderScore)
.AddAttribute(41, "_", a => a.ReservedAttributeString)
.AddAttribute(41, "contentTypeName", a => a.ContentTypeName)
.AddAttribute(41, "contentTypeID", a => a.ContentTypeID, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { Pattern = ("0x([0-9A-Fa-f][1-9A-Fa-f]|[1-9A-Fa-f][0-9A-Fa-f]|00[0-9A-Fa-f]{32})*"), MinLength = (2L), MaxLength = (1026L) });
})
.AddAttribute(41, "contentTypeVersion", a => a.ContentTypeVersion, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L) });
})
.AddAttribute(41, "contentTypeDescription", a => a.ContentTypeDescription)
.AddAttribute(41, "contentTypeScope", a => a.ContentTypeScope)
.AddAttribute(41, "versionID", a => a.VersionID);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(XsdAny.Any, 1, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContentTypeSchema>(deep);
    }
}