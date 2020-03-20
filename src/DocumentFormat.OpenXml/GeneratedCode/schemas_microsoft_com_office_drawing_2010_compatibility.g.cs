// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2010.Drawing.LegacyCompatibility
{
    /// <summary>
    /// <para>Defines the CompatibilityShape Class.</para>
    /// <para>This class is available in Office 2010 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is com14:compatSp.</para>
    /// </summary>
    [SchemaAttr(63, "compatSp")]
    [OfficeAvailability(FileFormatVersions.Office2010)]
    public partial class CompatibilityShape : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CompatibilityShape class.
        /// </summary>
        public CompatibilityShape() : base()
        {
        }

        /// <summary>
        /// <para>spid, this property is only available in Office2010, Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: spid</para>
        /// </summary>
        [RequiredValidator()]
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "spid")]
        [Index(0)]
        public StringValue ShapeId { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CompatibilityShape>(deep);
    }
}