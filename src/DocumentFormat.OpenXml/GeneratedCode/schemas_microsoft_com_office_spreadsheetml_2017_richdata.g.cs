// Copyright (c) Microsoft. All rights reserved.
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

namespace DocumentFormat.OpenXml.Office2019.Excel.RichData
{
    /// <summary>
    /// <para>Defines the RichValueBlock Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd:rvb.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(98, "rvb")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RichValueBlock : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RichValueBlock class.
        /// </summary>
        public RichValueBlock() : base()
        {
        }

        /// <summary>
        /// <para>i, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: i</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "i")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? I
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(98, "rvb");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<RichValueBlock>()
.AddAttribute(0, "i", a => a.I, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichValueBlock>(deep);
    }

    /// <summary>
    /// <para>Defines the RichValueData Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd:rvData.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RichValue &lt;xlrd:rv></description></item>
    ///   <item><description>ExtensionList &lt;xlrd:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(98, "rvData")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RichValueData : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RichValueData class.
        /// </summary>
        public RichValueData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichValueData(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichValueData(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueData class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RichValueData(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>count, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: count</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "count")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Count
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(98, "rvData");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<RichValue>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<RichValueData>()
.AddAttribute(0, "count", a => a.Count, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData.RichValue), 0, 0, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData.ExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichValueData>(deep);
    }

    /// <summary>
    /// <para>Defines the RichValueStructures Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd:rvStructures.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RichValueStructure &lt;xlrd:s></description></item>
    ///   <item><description>ExtensionList &lt;xlrd:extLst></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(98, "rvStructures")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RichValueStructures : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RichValueStructures class.
        /// </summary>
        public RichValueStructures() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueStructures class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichValueStructures(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueStructures class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichValueStructures(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueStructures class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RichValueStructures(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>count, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: count</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "count")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? Count
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(98, "rvStructures");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<RichValueStructure>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<RichValueStructures>()
.AddAttribute(0, "count", a => a.Count, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData.RichValueStructure), 0, 0, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData.ExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichValueStructures>(deep);
    }

    /// <summary>
    /// <para>Defines the RichValue Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd:rv.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>RichValueFallback &lt;xlrd:fb></description></item>
    ///   <item><description>Value &lt;xlrd:v></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(98, "rv")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RichValue : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RichValue class.
        /// </summary>
        public RichValue() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValue class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichValue(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValue class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichValue(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValue class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RichValue(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>s, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: s</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "s")]
#pragma warning restore CS0618 // Type or member is obsolete

        public UInt32Value? S
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(98, "rv");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<RichValueFallback>();
            builder.AddChild<Value>();
            builder.AddElement<RichValue>()
.AddAttribute(0, "s", a => a.S, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData.RichValueFallback), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData.Value), 1, 0, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>RichValueFallback.</para>
        /// <para>Represents the following element tag in the schema: xlrd:fb.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata
        /// </remark>
        public RichValueFallback? RichValueFallback
        {
            get => GetElement<RichValueFallback>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichValue>(deep);
    }

    /// <summary>
    /// <para>Defines the ExtensionList Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Spreadsheet.Extension &lt;x:ext></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(98, "extLst")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class ExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ExtensionList class.
        /// </summary>
        public ExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(98, "extLst");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Extension>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Extension), 0, 0)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the RichValueFallback Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd:fb.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(98, "fb")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RichValueFallback : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the RichValueFallback class.
        /// </summary>
        public RichValueFallback() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueFallback class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public RichValueFallback(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <summary>
        /// <para>t, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: t</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "t")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Office2019.Excel.RichData.RichValueFallbackType>? T
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2019.Excel.RichData.RichValueFallbackType>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(98, "fb");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<RichValueFallback>()
.AddAttribute(0, "t", a => a.T);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichValueFallback>(deep);
    }

    /// <summary>
    /// <para>Defines the Value Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd:v.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(98, "v")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Value : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Value class.
        /// </summary>
        public Value() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Value class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Value(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(98, "v");
            builder.Availability = FileFormatVersions.Office2019;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Value>(deep);
    }

    /// <summary>
    /// <para>Defines the RichValueStructure Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd:s.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Key &lt;xlrd:k></description></item>
    /// </list>
    /// </remark>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(98, "s")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class RichValueStructure : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RichValueStructure class.
        /// </summary>
        public RichValueStructure() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueStructure class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichValueStructure(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueStructure class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichValueStructure(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueStructure class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RichValueStructure(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>t, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: t</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "t")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? T
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(98, "s");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<Key>();
            builder.AddElement<RichValueStructure>()
.AddAttribute(0, "t", a => a.T, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData.Key), 1, 0, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichValueStructure>(deep);
    }

    /// <summary>
    /// <para>Defines the Key Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd:k.</para>
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    [SchemaAttr(98, "k")]
#pragma warning restore CS0618 // Type or member is obsolete
    public partial class Key : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Key class.
        /// </summary>
        public Key() : base()
        {
        }

        /// <summary>
        /// <para>n, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: n</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "n")]
#pragma warning restore CS0618 // Type or member is obsolete

        public StringValue? N
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>t, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: t</para>
        /// </summary>

#pragma warning disable CS0618 // Type or member is obsolete

        [SchemaAttr(0, "t")]
#pragma warning restore CS0618 // Type or member is obsolete

        public EnumValue<DocumentFormat.OpenXml.Office2019.Excel.RichData.RichValueValueType>? T
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2019.Excel.RichData.RichValueValueType>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(98, "k");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<Key>()
.AddAttribute(0, "n", a => a.N, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "t", a => a.T);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Key>(deep);
    }

    /// <summary>
    /// Defines the RichValueFallbackType enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2019)]
    public enum RichValueFallbackType
    {
        ///<summary>
        ///b.
        ///<para>When the item is serialized out as xml, its value is "b".</para>
        ///</summary>
        [EnumString("b")]
        B,
        ///<summary>
        ///n.
        ///<para>When the item is serialized out as xml, its value is "n".</para>
        ///</summary>
        [EnumString("n")]
        N,
        ///<summary>
        ///e.
        ///<para>When the item is serialized out as xml, its value is "e".</para>
        ///</summary>
        [EnumString("e")]
        E,
        ///<summary>
        ///s.
        ///<para>When the item is serialized out as xml, its value is "s".</para>
        ///</summary>
        [EnumString("s")]
        S,
    }

    /// <summary>
    /// Defines the RichValueValueType enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2019)]
    public enum RichValueValueType
    {
        ///<summary>
        ///d.
        ///<para>When the item is serialized out as xml, its value is "d".</para>
        ///</summary>
        [EnumString("d")]
        D,
        ///<summary>
        ///i.
        ///<para>When the item is serialized out as xml, its value is "i".</para>
        ///</summary>
        [EnumString("i")]
        I,
        ///<summary>
        ///b.
        ///<para>When the item is serialized out as xml, its value is "b".</para>
        ///</summary>
        [EnumString("b")]
        B,
        ///<summary>
        ///e.
        ///<para>When the item is serialized out as xml, its value is "e".</para>
        ///</summary>
        [EnumString("e")]
        E,
        ///<summary>
        ///s.
        ///<para>When the item is serialized out as xml, its value is "s".</para>
        ///</summary>
        [EnumString("s")]
        S,
        ///<summary>
        ///r.
        ///<para>When the item is serialized out as xml, its value is "r".</para>
        ///</summary>
        [EnumString("r")]
        R,
        ///<summary>
        ///a.
        ///<para>When the item is serialized out as xml, its value is "a".</para>
        ///</summary>
        [EnumString("a")]
        A,
        ///<summary>
        ///spb.
        ///<para>When the item is serialized out as xml, its value is "spb".</para>
        ///</summary>
        [EnumString("spb")]
        Spb,
    }
}