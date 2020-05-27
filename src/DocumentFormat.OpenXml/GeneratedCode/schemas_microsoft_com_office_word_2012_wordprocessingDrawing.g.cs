// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

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
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wp15:webVideoPr.</para>
    /// </summary>
    public partial class WebVideoProperty : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the WebVideoProperty class.
        /// </summary>
        public WebVideoProperty() : base()
        {
        }

        /// <summary>
        /// <para>embeddedHtml, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: embeddedHtml</para>
        /// </summary>
        public StringValue EmbeddedHtml
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>h, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: h</para>
        /// </summary>
        public UInt32Value Height
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>w, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w</para>
        /// </summary>
        public UInt32Value Width
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(75, "webVideoPr");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<WebVideoProperty>()
.AddAttribute(0, "embeddedHtml", a => a.EmbeddedHtml)
.AddAttribute(0, "h", a => a.Height)
.AddAttribute(0, "w", a => a.Width);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebVideoProperty>(deep);
    }
}