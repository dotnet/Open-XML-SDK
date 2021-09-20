﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2021.Excel.Pivot
{
    /// <summary>
    /// <para>Defines the Xsdboolean Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xxpim:implicitMeasureSupport.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(135, "implicitMeasureSupport")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Xsdboolean : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Xsdboolean class.
        /// </summary>
        public Xsdboolean() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Xsdboolean class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Xsdboolean(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new BooleanValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<BooleanValue>(NumberValidator.Instance);
            builder.SetSchema(135, "implicitMeasureSupport");
            builder.Availability = FileFormatVersions.Office2021;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Xsdboolean>(deep);
    }

    /// <summary>
    /// <para>Defines the Ignorable Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xxpim:ignorableAfterVersion.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(135, "ignorableAfterVersion")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Ignorable : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Ignorable class.
        /// </summary>
        public Ignorable() : base()
        {
        }

        /// <summary>
        /// <para>version, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: version</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "version")]
#pragma warning restore CS0618 // Type or member is obsolete

        public ByteValue? Version
        {
            get => GetAttribute<ByteValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(135, "ignorableAfterVersion");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddElement<Ignorable>()
.AddAttribute(0, "version", a => a.Version, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Ignorable>(deep);
    }

    /// <summary>
    /// <para>Defines the DataFieldFutureData Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xxpim:dataFieldFutureData.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(135, "dataFieldFutureData")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DataFieldFutureData : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DataFieldFutureData class.
        /// </summary>
        public DataFieldFutureData() : base()
        {
        }

        /// <summary>
        /// <para>version, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: version</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "version")]
#pragma warning restore CS0618 // Type or member is obsolete

        public ByteValue? Version
        {
            get => GetAttribute<ByteValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sourceField, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: sourceField</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "sourceField")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? SourceField
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(135, "dataFieldFutureData");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddElement<DataFieldFutureData>()
.AddAttribute(0, "version", a => a.Version, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "sourceField", a => a.SourceField, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataFieldFutureData>(deep);
    }
}