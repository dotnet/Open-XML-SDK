// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using DocumentFormat.OpenXml.VariantTypes;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.CustomProperties
{
    /// <summary>
    /// <para>Custom File Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is op:Properties.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>CustomDocumentProperty &lt;op:property></description></item>
    /// </list>
    /// </remark>
    public partial class Properties : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the Properties class.
        /// </summary>
        public Properties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Properties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Properties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Properties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Properties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Properties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Properties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(4, "Properties");
            builder.AddChild<CustomDocumentProperty>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Properties>(deep);

        internal Properties(CustomFilePropertiesPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the CustomFilePropertiesPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(CustomFilePropertiesPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the CustomFilePropertiesPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(CustomFilePropertiesPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the CustomFilePropertiesPart associated with this element.
        /// </summary>
        public CustomFilePropertiesPart CustomFilePropertiesPart
        {
            get => OpenXmlPart as CustomFilePropertiesPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Custom File Property.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is op:property.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTVector &lt;vt:vector></description></item>
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTArray &lt;vt:array></description></item>
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTBlob &lt;vt:blob></description></item>
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTOBlob &lt;vt:oblob></description></item>
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTEmpty &lt;vt:empty></description></item>
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTNull &lt;vt:null></description></item>
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTByte &lt;vt:i1></description></item>
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTShort &lt;vt:i2></description></item>
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTInt32 &lt;vt:i4></description></item>
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTInt64 &lt;vt:i8></description></item>
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTInteger &lt;vt:int></description></item>
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTUnsignedByte &lt;vt:ui1></description></item>
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTUnsignedShort &lt;vt:ui2></description></item>
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTUnsignedInt32 &lt;vt:ui4></description></item>
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTUnsignedInt64 &lt;vt:ui8></description></item>
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTUnsignedInteger &lt;vt:uint></description></item>
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTFloat &lt;vt:r4></description></item>
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTDouble &lt;vt:r8></description></item>
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTDecimal &lt;vt:decimal></description></item>
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTLPSTR &lt;vt:lpstr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTLPWSTR &lt;vt:lpwstr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTBString &lt;vt:bstr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTDate &lt;vt:date></description></item>
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTFileTime &lt;vt:filetime></description></item>
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTBool &lt;vt:bool></description></item>
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTCurrency &lt;vt:cy></description></item>
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTError &lt;vt:error></description></item>
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTStreamData &lt;vt:stream></description></item>
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTOStreamData &lt;vt:ostream></description></item>
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTStorage &lt;vt:storage></description></item>
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTOStorage &lt;vt:ostorage></description></item>
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTVStreamData &lt;vt:vstream></description></item>
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTClassId &lt;vt:clsid></description></item>
    ///   <item><description>DocumentFormat.OpenXml.VariantTypes.VTClipboardData &lt;vt:cf></description></item>
    /// </list>
    /// </remark>
    public partial class CustomDocumentProperty : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CustomDocumentProperty class.
        /// </summary>
        public CustomDocumentProperty() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomDocumentProperty class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CustomDocumentProperty(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomDocumentProperty class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CustomDocumentProperty(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomDocumentProperty class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CustomDocumentProperty(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Format ID</para>
        /// <para>Represents the following attribute in the schema: fmtid</para>
        /// </summary>
        public StringValue FormatId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Property ID</para>
        /// <para>Represents the following attribute in the schema: pid</para>
        /// </summary>
        public Int32Value PropertyId
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Custom File Property Name</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        public StringValue Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Bookmark Link Target</para>
        /// <para>Represents the following attribute in the schema: linkTarget</para>
        /// </summary>
        public StringValue LinkTarget
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(4, "property");
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTVector>();
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTArray>();
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTBlob>();
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTOBlob>();
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTEmpty>();
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTNull>();
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTByte>();
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTShort>();
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTInt32>();
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTInt64>();
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTInteger>();
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTUnsignedByte>();
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTUnsignedShort>();
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTUnsignedInt32>();
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTUnsignedInt64>();
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTUnsignedInteger>();
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTFloat>();
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTDouble>();
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTDecimal>();
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTLPSTR>();
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTLPWSTR>();
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTBString>();
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTDate>();
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTFileTime>();
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTBool>();
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTCurrency>();
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTError>();
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTStreamData>();
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTOStreamData>();
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTStorage>();
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTOStorage>();
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTVStreamData>();
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTClassId>();
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTClipboardData>();
            builder.AddElement<CustomDocumentProperty>()
.AddAttribute(0, "fmtid", a => a.FormatId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { Pattern = ("\\s*\\{[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}\\}\\s*") });
})
.AddAttribute(0, "pid", a => a.PropertyId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "name", a => a.Name)
.AddAttribute(0, "linkTarget", a => a.LinkTarget);
            builder.Particle = new CompositeParticle(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTVector), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTArray), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTBlob), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTOBlob), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTEmpty), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTNull), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTByte), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTShort), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTInt32), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTInt64), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTInteger), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTUnsignedByte), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTUnsignedShort), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTUnsignedInt32), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTUnsignedInt64), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTUnsignedInteger), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTFloat), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTDouble), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTDecimal), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTLPSTR), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTLPWSTR), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTBString), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTDate), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTFileTime), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTBool), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTCurrency), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTError), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTStreamData), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTOStreamData), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTStorage), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTOStorage), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTVStreamData), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTClassId), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTClipboardData), 1, 1)
            };
            builder.AddConstraint(new AttributeValueRangeConstraint(1 /*:pid*/, true, 2, true, double.PositiveInfinity, true));
            builder.AddConstraint(new UniqueAttributeValueConstraint(2 /*:name*/, false, null));
        }

        /// <summary>
        /// <para>Vector.</para>
        /// <para>Represents the following element tag in the schema: vt:vector.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTVector VTVector
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTVector>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Array.</para>
        /// <para>Represents the following element tag in the schema: vt:array.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTArray VTArray
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTArray>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Binary Blob.</para>
        /// <para>Represents the following element tag in the schema: vt:blob.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTBlob VTBlob
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTBlob>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Binary Blob Object.</para>
        /// <para>Represents the following element tag in the schema: vt:oblob.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTOBlob VTOBlob
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTOBlob>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Empty.</para>
        /// <para>Represents the following element tag in the schema: vt:empty.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTEmpty VTEmpty
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTEmpty>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Null.</para>
        /// <para>Represents the following element tag in the schema: vt:null.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTNull VTNull
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTNull>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>1-Byte Signed Integer.</para>
        /// <para>Represents the following element tag in the schema: vt:i1.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTByte VTByte
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTByte>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>2-Byte Signed Integer.</para>
        /// <para>Represents the following element tag in the schema: vt:i2.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTShort VTShort
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTShort>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>4-Byte Signed Integer.</para>
        /// <para>Represents the following element tag in the schema: vt:i4.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTInt32 VTInt32
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTInt32>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>8-Byte Signed Integer.</para>
        /// <para>Represents the following element tag in the schema: vt:i8.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTInt64 VTInt64
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTInt64>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Integer.</para>
        /// <para>Represents the following element tag in the schema: vt:int.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTInteger VTInteger
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTInteger>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>1-Byte Unsigned Integer.</para>
        /// <para>Represents the following element tag in the schema: vt:ui1.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTUnsignedByte VTUnsignedByte
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTUnsignedByte>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>2-Byte Unsigned Integer.</para>
        /// <para>Represents the following element tag in the schema: vt:ui2.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTUnsignedShort VTUnsignedShort
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTUnsignedShort>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>4-Byte Unsigned Integer.</para>
        /// <para>Represents the following element tag in the schema: vt:ui4.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTUnsignedInt32 VTUnsignedInt32
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTUnsignedInt32>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>8-Byte Unsigned Integer.</para>
        /// <para>Represents the following element tag in the schema: vt:ui8.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTUnsignedInt64 VTUnsignedInt64
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTUnsignedInt64>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Unsigned Integer.</para>
        /// <para>Represents the following element tag in the schema: vt:uint.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTUnsignedInteger VTUnsignedInteger
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTUnsignedInteger>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>4-Byte Real Number.</para>
        /// <para>Represents the following element tag in the schema: vt:r4.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTFloat VTFloat
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTFloat>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>8-Byte Real Number.</para>
        /// <para>Represents the following element tag in the schema: vt:r8.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTDouble VTDouble
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTDouble>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Decimal.</para>
        /// <para>Represents the following element tag in the schema: vt:decimal.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTDecimal VTDecimal
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTDecimal>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>LPSTR.</para>
        /// <para>Represents the following element tag in the schema: vt:lpstr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTLPSTR VTLPSTR
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTLPSTR>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>LPWSTR.</para>
        /// <para>Represents the following element tag in the schema: vt:lpwstr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTLPWSTR VTLPWSTR
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTLPWSTR>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Basic String.</para>
        /// <para>Represents the following element tag in the schema: vt:bstr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTBString VTBString
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTBString>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Date and Time.</para>
        /// <para>Represents the following element tag in the schema: vt:date.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTDate VTDate
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTDate>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>File Time.</para>
        /// <para>Represents the following element tag in the schema: vt:filetime.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTFileTime VTFileTime
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTFileTime>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Boolean.</para>
        /// <para>Represents the following element tag in the schema: vt:bool.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTBool VTBool
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTBool>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Currency.</para>
        /// <para>Represents the following element tag in the schema: vt:cy.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTCurrency VTCurrency
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTCurrency>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Error Status Code.</para>
        /// <para>Represents the following element tag in the schema: vt:error.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTError VTError
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTError>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Binary Stream.</para>
        /// <para>Represents the following element tag in the schema: vt:stream.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTStreamData VTStreamData
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTStreamData>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Binary Stream Object.</para>
        /// <para>Represents the following element tag in the schema: vt:ostream.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTOStreamData VTOStreamData
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTOStreamData>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Binary Storage.</para>
        /// <para>Represents the following element tag in the schema: vt:storage.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTStorage VTStorage
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTStorage>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Binary Storage Object.</para>
        /// <para>Represents the following element tag in the schema: vt:ostorage.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTOStorage VTOStorage
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTOStorage>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Binary Versioned Stream.</para>
        /// <para>Represents the following element tag in the schema: vt:vstream.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTVStreamData VTVStreamData
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTVStreamData>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Class ID.</para>
        /// <para>Represents the following element tag in the schema: vt:clsid.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTClassId VTClassId
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTClassId>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Clipboard Data.</para>
        /// <para>Represents the following element tag in the schema: vt:cf.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTClipboardData VTClipboardData
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTClipboardData>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomDocumentProperty>(deep);
    }
}