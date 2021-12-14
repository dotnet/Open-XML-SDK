// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Microsoft365.Word.OEmbed
{
    /// <summary>
    /// <para>Defines the OEmbed Class.</para>
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is woe:oembed.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("woe:oembed")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class OEmbed : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the OEmbed class.
        /// </summary>
        public OEmbed() : base()
        {
        }

        /// <summary>
        /// <para>oEmbedUrl, this property is only available in Microsoft365 and later.</para>
        /// <para>Represents the following attribute in the schema: oEmbedUrl</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("oEmbedUrl")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? OEmbedUrl
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>mediaType, this property is only available in Microsoft365 and later.</para>
        /// <para>Represents the following attribute in the schema: mediaType</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("mediaType")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? MediaType
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>picLocksAutoForOEmbed, this property is only available in Microsoft365 and later.</para>
        /// <para>Represents the following attribute in the schema: picLocksAutoForOEmbed</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("picLocksAutoForOEmbed")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? PicLocksAutoForOEmbed
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("woe:oembed");
            builder.Availability = FileFormatVersions.Microsoft365;
            builder.AddElement<OEmbed>()
.AddAttribute("oEmbedUrl", a => a.OEmbedUrl, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("mediaType", a => a.MediaType, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute("picLocksAutoForOEmbed", a => a.PicLocksAutoForOEmbed);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OEmbed>(deep);
    }
}