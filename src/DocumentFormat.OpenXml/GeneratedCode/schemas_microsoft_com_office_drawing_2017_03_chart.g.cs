// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2019.Drawing.Chart
{
    /// <summary>
    /// <para>Defines the DataDisplayOptions16 Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c16r3:dataDisplayOptions16.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>BooleanFalse &lt;c16r3:dispNaAsBlank></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(101, "dataDisplayOptions16")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class DataDisplayOptions16 : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DataDisplayOptions16 class.
        /// </summary>
        public DataDisplayOptions16() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataDisplayOptions16 class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataDisplayOptions16(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataDisplayOptions16 class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataDisplayOptions16(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataDisplayOptions16 class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataDisplayOptions16(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(101, "dataDisplayOptions16");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<BooleanFalse>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Chart.BooleanFalse), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>BooleanFalse.</para>
        /// <para>Represents the following element tag in the schema: c16r3:dispNaAsBlank.</para>
        /// </summary>
        /// <remark>
        /// xmlns:c16r3 = http://schemas.microsoft.com/office/drawing/2017/03/chart
        /// </remark>
        public BooleanFalse? BooleanFalse
        {
            get => GetElement<BooleanFalse>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataDisplayOptions16>(deep);
    }

    /// <summary>
    /// <para>Defines the BooleanFalse Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is c16r3:dispNaAsBlank.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(101, "dispNaAsBlank")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class BooleanFalse : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BooleanFalse class.
        /// </summary>
        public BooleanFalse() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: c16r3:val</para>
        /// </summary>
        /// <remark>
        /// xmlns:c16r3=http://schemas.microsoft.com/office/drawing/2017/03/chart
        /// </remark>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(101, "val")]
#pragma warning restore CS0618 // Type or member is obsolete

        public BooleanValue? Val
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(101, "dispNaAsBlank");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<BooleanFalse>()
.AddAttribute(101, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2019));
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BooleanFalse>(deep);
    }
}