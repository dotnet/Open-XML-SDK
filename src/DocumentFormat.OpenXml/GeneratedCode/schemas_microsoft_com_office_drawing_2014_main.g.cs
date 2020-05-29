// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2016.Drawing
{
    /// <summary>
    /// <para>Defines the CreationId Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a16:creationId.</para>
    /// </summary>
    public partial class CreationId : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CreationId class.
        /// </summary>
        public CreationId() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(79, "creationId");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<CreationId>()
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CreationId>(deep);
    }

    /// <summary>
    /// <para>Defines the PredecessorDrawingElementReference Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a16:predDERef.</para>
    /// </summary>
    public partial class PredecessorDrawingElementReference : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PredecessorDrawingElementReference class.
        /// </summary>
        public PredecessorDrawingElementReference() : base()
        {
        }

        /// <summary>
        /// <para>pred, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: pred</para>
        /// </summary>
        public StringValue Pred
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(79, "predDERef");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<PredecessorDrawingElementReference>()
.AddAttribute(0, "pred", a => a.Pred, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PredecessorDrawingElementReference>(deep);
    }

    /// <summary>
    /// <para>Defines the ConnectableReferences Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a16:cxnDERefs.</para>
    /// </summary>
    public partial class ConnectableReferences : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ConnectableReferences class.
        /// </summary>
        public ConnectableReferences() : base()
        {
        }

        /// <summary>
        /// <para>st, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: st</para>
        /// </summary>
        public StringValue St
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>end, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: end</para>
        /// </summary>
        public StringValue End
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(79, "cxnDERefs");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<ConnectableReferences>()
.AddAttribute(0, "st", a => a.St, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "end", a => a.End, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConnectableReferences>(deep);
    }

    /// <summary>
    /// <para>Defines the RowIdIdentifier Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a16:rowId.</para>
    /// </summary>
    public partial class RowIdIdentifier : OpenXmlIdentifierElement
    {
        /// <summary>
        /// Initializes a new instance of the RowIdIdentifier class.
        /// </summary>
        public RowIdIdentifier() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(79, "rowId");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RowIdIdentifier>(deep);
    }

    /// <summary>
    /// <para>Defines the ColIdIdentifier Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a16:colId.</para>
    /// </summary>
    public partial class ColIdIdentifier : OpenXmlIdentifierElement
    {
        /// <summary>
        /// Initializes a new instance of the ColIdIdentifier class.
        /// </summary>
        public ColIdIdentifier() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(79, "colId");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColIdIdentifier>(deep);
    }

    /// <summary>
    /// <para>Defines the OpenXmlIdentifierElement Class.</para>
    /// <para>This class is available in Office 2016 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class OpenXmlIdentifierElement : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the OpenXmlIdentifierElement class.
        /// </summary>
        protected OpenXmlIdentifierElement() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office2016</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public UInt32Value Val
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<OpenXmlIdentifierElement>()
                           .AddAttribute(0, "val", a => a.Val, aBuilder =>
                           {
                               aBuilder.AddValidator(RequiredValidator.Instance);
                           });
        }
    }
}