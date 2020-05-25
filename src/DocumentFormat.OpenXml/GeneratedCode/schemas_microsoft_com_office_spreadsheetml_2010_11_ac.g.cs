// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

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
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15ac:absPath.</para>
    /// </summary>
    [SchemaAttr(74, "absPath")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class AbsolutePath : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the AbsolutePath class.
        /// </summary>
        public AbsolutePath() : base()
        {
        }

        /// <summary>
        /// <para>url, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: url</para>
        /// </summary>
        public StringValue Url { get => GetAttribute<StringValue>(); set => SetAttribute(value); }
        internal override ElementMetadata RawAttributes { get; } = ElementMetadata.Create<AbsolutePath>();

        internal override void ConfigureMetadata(ElementMetadataBuilder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<AbsolutePath>()
                           .AddAttribute(0, "url", a => a.Url, aBuilder =>
                           {
                               aBuilder.AddValidator(new RequiredValidatorAttribute());
                           });
        }

        private static readonly ISemanticConstraint[] _semanticConstraint = new ISemanticConstraint[] {
            new AttributeValueLengthConstraint(0 /*:url*/, 1, 1000) { Application = ApplicationType.Excel, Version = FileFormatVersions.Office2013 }
        };

        internal override ISemanticConstraint[] SemanticConstraints => _semanticConstraint;

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AbsolutePath>(deep);
    }
}