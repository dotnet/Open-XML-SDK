// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Framework.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFormat.OpenXml.Drawing.Pictures.SVG
{
    /// <summary>
    /// <para>Defines the SvgBlip Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is asvg:svgBlip.</para>
    /// </summary>
    public partial class SvgBlip : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SvgBlip class.
        /// </summary>
        public SvgBlip() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SvgBlip class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SvgBlip(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SvgBlip class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SvgBlip(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SvgBlip class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SvgBlip(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Embedded Picture Reference</para>
        /// <para>Represents the following attribute in the schema: r:embed</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        public StringValue Embed
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(87, "svgBlip");
            builder.AddElement<SvgBlip>()
.AddAttribute(19, "embed", a => a.Embed);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Blip>(deep);
    }
}
