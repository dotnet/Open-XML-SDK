﻿// <auto-generated/>

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

namespace DocumentFormat.OpenXml.Office2016.Word.Symex
{
    /// <summary>
    /// <para>Defines the SymEx Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is w16se:symEx.</para>
    /// </summary>
    public partial class SymEx : OpenXmlLeafElement
    {
        #pragma warning disable CS0109
        internal static readonly new OpenXmlQualifiedName ElementQName = new("http://schemas.microsoft.com/office/word/2015/wordml/symex", "symEx");
        internal static readonly new OpenXmlQualifiedName ElementTypeName = new("http://schemas.microsoft.com/office/word/2015/wordml/symex", "CT_SymEx");
        internal static readonly new OpenXmlSchemaType ElementType = new(ElementQName, ElementTypeName);
        #pragma warning restore CS0109

        /// <summary>
        /// Initializes a new instance of the SymEx class.
        /// </summary>
        public SymEx() : base()
        {
        }

        /// <summary>
        /// <para>font, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: w16se:font</para>
        /// </summary>
        /// <remarks>
        /// xmlns:w16se=http://schemas.microsoft.com/office/word/2015/wordml/symex
        /// </remarks>
        public StringValue? Font
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>char, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: w16se:char</para>
        /// </summary>
        /// <remarks>
        /// xmlns:w16se=http://schemas.microsoft.com/office/word/2015/wordml/symex
        /// </remarks>
        public HexBinaryValue? Char
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(ElementType);
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<SymEx>()
                .AddAttribute("w16se:font", a => a.Font, aBuilder =>
                {
                    aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2016));
                })
                .AddAttribute("w16se:char", a => a.Char, aBuilder =>
                {
                    aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2016));
                    aBuilder.AddValidator(new StringValidator() { Length = (4L) });
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SymEx>(deep);
    }
}