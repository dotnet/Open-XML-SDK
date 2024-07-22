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

namespace DocumentFormat.OpenXml.Office.SpreadSheetML.Y2023.ExternalCodeService
{
    /// <summary>
    /// <para>Defines the ExternalCodeService Class.</para>
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlecs:externalCodeService.</para>
    /// </summary>
    public partial class ExternalCodeService : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ExternalCodeService class.
        /// </summary>
        public ExternalCodeService() : base()
        {
        }

        /// <summary>
        /// <para>autoShow, this property is only available in Microsoft365 and later.</para>
        /// <para>Represents the following attribute in the schema: autoShow</para>
        /// </summary>
        public UInt32Value? AutoShow
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>timeout, this property is only available in Microsoft365 and later.</para>
        /// <para>Represents the following attribute in the schema: timeout</para>
        /// </summary>
        public UInt32Value? Timeout
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlecs:externalCodeService");
            builder.Availability = FileFormatVersions.Microsoft365;
            builder.AddElement<ExternalCodeService>()
                .AddAttribute("autoShow", a => a.AutoShow)
                .AddAttribute("timeout", a => a.Timeout);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExternalCodeService>(deep);
    }
}