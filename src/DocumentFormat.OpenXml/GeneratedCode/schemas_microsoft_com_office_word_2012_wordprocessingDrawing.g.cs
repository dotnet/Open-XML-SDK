﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
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
    [SchemaAttr(75, "webVideoPr")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
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
        [SchemaAttr(0, "embeddedHtml")]
        [Index(0)]
        public StringValue EmbeddedHtml { get; set; }

        /// <summary>
        /// <para>h, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: h</para>
        /// </summary>
        [SchemaAttr(0, "h")]
        [Index(1)]
        public UInt32Value Height { get; set; }

        /// <summary>
        /// <para>w, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: w</para>
        /// </summary>
        [SchemaAttr(0, "w")]
        [Index(2)]
        public UInt32Value Width { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebVideoProperty>(deep);
    }
}