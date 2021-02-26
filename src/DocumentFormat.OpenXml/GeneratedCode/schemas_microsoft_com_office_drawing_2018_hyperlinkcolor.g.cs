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

namespace DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor
{
    /// <summary>
    /// <para>Defines the HyperlinkColor Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ahyp:hlinkClr.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(106, "hlinkClr")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class HyperlinkColor : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the HyperlinkColor class.
        /// </summary>
        public HyperlinkColor() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColorEnum>? Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2019.Drawing.HyperLinkColor.HyperlinkColorEnum>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(106, "hlinkClr");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<HyperlinkColor>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HyperlinkColor>(deep);
    }

    /// <summary>
    /// Defines the HyperlinkColorEnum enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2019)]
    public enum HyperlinkColorEnum
    {
        ///<summary>
        ///hlink.
        ///<para>When the item is serialized out as xml, its value is "hlink".</para>
        ///</summary>
        [EnumString("hlink")]
        HLink,
        ///<summary>
        ///tx.
        ///<para>When the item is serialized out as xml, its value is "tx".</para>
        ///</summary>
        [EnumString("tx")]
        Tx,
    }
}