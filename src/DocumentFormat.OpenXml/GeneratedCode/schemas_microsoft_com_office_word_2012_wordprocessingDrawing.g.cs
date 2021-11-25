// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2013.Word.Drawing
{
    /// <summary>
    /// <para>Defines the WebVideoProperty Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wp15:webVideoPr.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr("wp15:webVideoPr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class WebVideoProperty : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the WebVideoProperty class.
        /// </summary>
        public WebVideoProperty() : base()
        {
        }

        /// <summary>
        /// <para>embeddedHtml, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: embeddedHtml</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("embeddedHtml")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? EmbeddedHtml
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>h, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: h</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("h")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Height
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>w, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: w</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr("w")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Width
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wp15:webVideoPr");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<WebVideoProperty>()
.AddAttribute("embeddedHtml", a => a.EmbeddedHtml)
.AddAttribute("h", a => a.Height)
.AddAttribute("w", a => a.Width);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebVideoProperty>(deep);
    }
}