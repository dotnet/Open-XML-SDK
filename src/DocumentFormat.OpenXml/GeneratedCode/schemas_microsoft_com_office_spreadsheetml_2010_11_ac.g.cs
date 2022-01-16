﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2013.ExcelAc
{
    /// <summary>
    /// <para>Defines the AbsolutePath Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15ac:absPath.</para>
    /// </summary>
    [SchemaAttr("x15ac:absPath")]
    public partial class AbsolutePath : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the AbsolutePath class.
        /// </summary>
        public AbsolutePath() : base()
        {
        }

        /// <summary>
        /// <para>url, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: url</para>
        /// </summary>
        [SchemaAttr("url")]
        public StringValue? Url
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15ac:absPath");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<AbsolutePath>()
.AddAttribute("url", a => a.Url, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.AddConstraint(new AttributeValueLengthConstraint("x15ac:url", 1, 1000) { Application = ApplicationType.Excel, Version = FileFormatVersions.Office2013 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AbsolutePath>(deep);
    }
}