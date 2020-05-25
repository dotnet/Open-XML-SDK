// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2016.Presentation
{
    /// <summary>
    /// <para>Defines the DesignElement Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p16:designElem.</para>
    /// </summary>
    [SchemaAttr(78, "designElem")]
    [OfficeAvailability(FileFormatVersions.Office2016)]
    public partial class DesignElement : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DesignElement class.
        /// </summary>
        public DesignElement() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public BooleanValue Val { get => GetAttribute<BooleanValue>(); set => SetAttribute(value); }
        internal override ElementMetadata RawAttributes { get; } = ElementMetadata.Create<DesignElement>();

        internal override void ConfigureMetadata(ElementMetadataBuilder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<DesignElement>()
                           .AddAttribute(0, "val", a => a.Val);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DesignElement>(deep);
    }
}