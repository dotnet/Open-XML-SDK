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

namespace DocumentFormat.OpenXml.Drawing.LegacyCompatibility
{
    /// <summary>
    /// <para>Legacy Drawing Object.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is comp:legacyDrawing.</para>
    /// </summary>
    [SchemaAttr(13, "legacyDrawing")]
    [OfficeAvailability(FileFormatVersions.Office2007)]
    public partial class LegacyDrawing : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the LegacyDrawing class.
        /// </summary>
        public LegacyDrawing() : base()
        {
        }

        /// <summary>
        /// <para>Shape ID</para>
        /// <para>Represents the following attribute in the schema: spid</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "spid")]
        [Index(0)]
        public StringValue ShapeId { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LegacyDrawing>(deep);
    }
}