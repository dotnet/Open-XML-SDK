// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Drawing.Diagrams
{
    /// <summary>
    /// <para>Color Transform Definitions.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:colorsDef.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ColorDefinitionTitle &lt;dgm:title></description></item>
    ///   <item><description>ColorTransformDescription &lt;dgm:desc></description></item>
    ///   <item><description>ColorTransformCategories &lt;dgm:catLst></description></item>
    ///   <item><description>ColorTransformStyleLabel &lt;dgm:styleLbl></description></item>
    ///   <item><description>ExtensionList &lt;dgm:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class ColorsDefinition : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorsDefinition class.
        /// </summary>
        public ColorsDefinition() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorsDefinition class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorsDefinition(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorsDefinition class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorsDefinition(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorsDefinition class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ColorsDefinition(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique ID</para>
        /// <para>Represents the following attribute in the schema: uniqueId</para>
        /// </summary>
        public StringValue UniqueId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Minimum Version</para>
        /// <para>Represents the following attribute in the schema: minVer</para>
        /// </summary>
        public StringValue MinVersion
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "colorsDef");
            builder.AddChild<ColorDefinitionTitle>();
            builder.AddChild<ColorTransformDescription>();
            builder.AddChild<ColorTransformCategories>();
            builder.AddChild<ColorTransformStyleLabel>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<ColorsDefinition>()
.AddAttribute(0, "uniqueId", a => a.UniqueId)
.AddAttribute(0, "minVer", a => a.MinVersion);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ColorDefinitionTitle), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformDescription), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategories), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
            builder.AddConstraint(new AttributeValueSetConstraint(1 /*:minVer*/, true, new string[] { "12.0" }));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorsDefinition>(deep);

        internal ColorsDefinition(DiagramColorsPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the DiagramColorsPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(DiagramColorsPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the DiagramColorsPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(DiagramColorsPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the DiagramColorsPart associated with this element.
        /// </summary>
        public DiagramColorsPart DiagramColorsPart
        {
            get => OpenXmlPart as DiagramColorsPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Color Transform Header.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:colorsDefHdr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ColorDefinitionTitle &lt;dgm:title></description></item>
    ///   <item><description>ColorTransformDescription &lt;dgm:desc></description></item>
    ///   <item><description>ColorTransformCategories &lt;dgm:catLst></description></item>
    ///   <item><description>ExtensionList &lt;dgm:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class ColorsDefinitionHeader : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorsDefinitionHeader class.
        /// </summary>
        public ColorsDefinitionHeader() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorsDefinitionHeader class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorsDefinitionHeader(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorsDefinitionHeader class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorsDefinitionHeader(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorsDefinitionHeader class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ColorsDefinitionHeader(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique ID</para>
        /// <para>Represents the following attribute in the schema: uniqueId</para>
        /// </summary>
        public StringValue UniqueId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Minimum Version</para>
        /// <para>Represents the following attribute in the schema: minVer</para>
        /// </summary>
        public StringValue MinVersion
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Resource ID</para>
        /// <para>Represents the following attribute in the schema: resId</para>
        /// </summary>
        public Int32Value ResourceId
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "colorsDefHdr");
            builder.AddChild<ColorDefinitionTitle>();
            builder.AddChild<ColorTransformDescription>();
            builder.AddChild<ColorTransformCategories>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<ColorsDefinitionHeader>()
.AddAttribute(0, "uniqueId", a => a.UniqueId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "minVer", a => a.MinVersion)
.AddAttribute(0, "resId", a => a.ResourceId);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ColorDefinitionTitle), 1, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformDescription), 1, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategories), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorsDefinitionHeader>(deep);
    }

    /// <summary>
    /// <para>Color Transform Header List.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:colorsDefHdrLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ColorsDefinitionHeader &lt;dgm:colorsDefHdr></description></item>
    /// </list>
    /// </remark>
    public partial class ColorsDefinitionHeaderList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorsDefinitionHeaderList class.
        /// </summary>
        public ColorsDefinitionHeaderList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorsDefinitionHeaderList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorsDefinitionHeaderList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorsDefinitionHeaderList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorsDefinitionHeaderList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorsDefinitionHeaderList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ColorsDefinitionHeaderList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "colorsDefHdrLst");
            builder.AddChild<ColorsDefinitionHeader>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinitionHeader), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorsDefinitionHeaderList>(deep);
    }

    /// <summary>
    /// <para>Data Model.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:dataModel.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PointList &lt;dgm:ptLst></description></item>
    ///   <item><description>ConnectionList &lt;dgm:cxnLst></description></item>
    ///   <item><description>Background &lt;dgm:bg></description></item>
    ///   <item><description>Whole &lt;dgm:whole></description></item>
    ///   <item><description>DataModelExtensionList &lt;dgm:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class DataModelRoot : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the DataModelRoot class.
        /// </summary>
        public DataModelRoot() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataModelRoot class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataModelRoot(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataModelRoot class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataModelRoot(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataModelRoot class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataModelRoot(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "dataModel");
            builder.AddChild<PointList>();
            builder.AddChild<ConnectionList>();
            builder.AddChild<Background>();
            builder.AddChild<Whole>();
            builder.AddChild<DataModelExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.PointList), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Background), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Whole), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.DataModelExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Point List.</para>
        /// <para>Represents the following element tag in the schema: dgm:ptLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public PointList PointList
        {
            get => GetElement<PointList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Connection List.</para>
        /// <para>Represents the following element tag in the schema: dgm:cxnLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public ConnectionList ConnectionList
        {
            get => GetElement<ConnectionList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Background Formatting.</para>
        /// <para>Represents the following element tag in the schema: dgm:bg.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public Background Background
        {
            get => GetElement<Background>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Whole E2O Formatting.</para>
        /// <para>Represents the following element tag in the schema: dgm:whole.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public Whole Whole
        {
            get => GetElement<Whole>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataModelExtensionList.</para>
        /// <para>Represents the following element tag in the schema: dgm:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DataModelExtensionList DataModelExtensionList
        {
            get => GetElement<DataModelExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataModelRoot>(deep);

        internal DataModelRoot(DiagramDataPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the DiagramDataPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(DiagramDataPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the DiagramDataPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(DiagramDataPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the DiagramDataPart associated with this element.
        /// </summary>
        public DiagramDataPart DiagramDataPart
        {
            get => OpenXmlPart as DiagramDataPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Layout Definition.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:layoutDef.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Title &lt;dgm:title></description></item>
    ///   <item><description>Description &lt;dgm:desc></description></item>
    ///   <item><description>CategoryList &lt;dgm:catLst></description></item>
    ///   <item><description>SampleData &lt;dgm:sampData></description></item>
    ///   <item><description>StyleData &lt;dgm:styleData></description></item>
    ///   <item><description>ColorData &lt;dgm:clrData></description></item>
    ///   <item><description>LayoutNode &lt;dgm:layoutNode></description></item>
    ///   <item><description>ExtensionList &lt;dgm:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class LayoutDefinition : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the LayoutDefinition class.
        /// </summary>
        public LayoutDefinition() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutDefinition class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LayoutDefinition(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutDefinition class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LayoutDefinition(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutDefinition class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LayoutDefinition(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: uniqueId</para>
        /// </summary>
        public StringValue UniqueId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Minimum Version</para>
        /// <para>Represents the following attribute in the schema: minVer</para>
        /// </summary>
        public StringValue MinVersion
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Default Style</para>
        /// <para>Represents the following attribute in the schema: defStyle</para>
        /// </summary>
        public StringValue DefaultStyle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "layoutDef");
            builder.AddChild<Title>();
            builder.AddChild<Description>();
            builder.AddChild<CategoryList>();
            builder.AddChild<SampleData>();
            builder.AddChild<StyleData>();
            builder.AddChild<ColorData>();
            builder.AddChild<LayoutNode>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<LayoutDefinition>()
.AddAttribute(0, "uniqueId", a => a.UniqueId)
.AddAttribute(0, "minVer", a => a.MinVersion)
.AddAttribute(0, "defStyle", a => a.DefaultStyle);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Title), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Description), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.CategoryList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.SampleData), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.StyleData), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ColorData), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LayoutDefinition>(deep);

        internal LayoutDefinition(DiagramLayoutDefinitionPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the DiagramLayoutDefinitionPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(DiagramLayoutDefinitionPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the DiagramLayoutDefinitionPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(DiagramLayoutDefinitionPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the DiagramLayoutDefinitionPart associated with this element.
        /// </summary>
        public DiagramLayoutDefinitionPart DiagramLayoutDefinitionPart
        {
            get => OpenXmlPart as DiagramLayoutDefinitionPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Layout Definition Header.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:layoutDefHdr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Title &lt;dgm:title></description></item>
    ///   <item><description>Description &lt;dgm:desc></description></item>
    ///   <item><description>CategoryList &lt;dgm:catLst></description></item>
    ///   <item><description>ExtensionList &lt;dgm:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class LayoutDefinitionHeader : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LayoutDefinitionHeader class.
        /// </summary>
        public LayoutDefinitionHeader() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutDefinitionHeader class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LayoutDefinitionHeader(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutDefinitionHeader class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LayoutDefinitionHeader(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutDefinitionHeader class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LayoutDefinitionHeader(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Identifier</para>
        /// <para>Represents the following attribute in the schema: uniqueId</para>
        /// </summary>
        public StringValue UniqueId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Minimum Version</para>
        /// <para>Represents the following attribute in the schema: minVer</para>
        /// </summary>
        public StringValue MinVersion
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Default Style</para>
        /// <para>Represents the following attribute in the schema: defStyle</para>
        /// </summary>
        public StringValue DefaultStyle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Resource Identifier</para>
        /// <para>Represents the following attribute in the schema: resId</para>
        /// </summary>
        public Int32Value ResourceId
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "layoutDefHdr");
            builder.AddChild<Title>();
            builder.AddChild<Description>();
            builder.AddChild<CategoryList>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<LayoutDefinitionHeader>()
.AddAttribute(0, "uniqueId", a => a.UniqueId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "minVer", a => a.MinVersion)
.AddAttribute(0, "defStyle", a => a.DefaultStyle)
.AddAttribute(0, "resId", a => a.ResourceId);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Title), 1, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Description), 1, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.CategoryList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LayoutDefinitionHeader>(deep);
    }

    /// <summary>
    /// <para>Diagram Layout Header List.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:layoutDefHdrLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>LayoutDefinitionHeader &lt;dgm:layoutDefHdr></description></item>
    /// </list>
    /// </remark>
    public partial class LayoutDefinitionHeaderList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LayoutDefinitionHeaderList class.
        /// </summary>
        public LayoutDefinitionHeaderList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutDefinitionHeaderList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LayoutDefinitionHeaderList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutDefinitionHeaderList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LayoutDefinitionHeaderList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutDefinitionHeaderList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LayoutDefinitionHeaderList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "layoutDefHdrLst");
            builder.AddChild<LayoutDefinitionHeader>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinitionHeader), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LayoutDefinitionHeaderList>(deep);
    }

    /// <summary>
    /// <para>Explicit Relationships to Diagram Parts.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:relIds.</para>
    /// </summary>
    public partial class RelationshipIds : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RelationshipIds class.
        /// </summary>
        public RelationshipIds() : base()
        {
        }

        /// <summary>
        /// <para>Explicit Relationship to Diagram Data Part</para>
        /// <para>Represents the following attribute in the schema: r:dm</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        public StringValue DataPart
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Explicit Relationship to Diagram Layout Definition Part</para>
        /// <para>Represents the following attribute in the schema: r:lo</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        public StringValue LayoutPart
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Explicit Relationship to Style Definition Part</para>
        /// <para>Represents the following attribute in the schema: r:qs</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        public StringValue StylePart
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Explicit Relationship to Diagram Colors Part</para>
        /// <para>Represents the following attribute in the schema: r:cs</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        public StringValue ColorPart
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "relIds");
            builder.AddElement<RelationshipIds>()
.AddAttribute(19, "dm", a => a.DataPart, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(19, "lo", a => a.LayoutPart, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(19, "qs", a => a.StylePart, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(19, "cs", a => a.ColorPart, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.AddConstraint(new RelationshipTypeConstraint(3 /*r:cs*/, "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramColors"));
            builder.AddConstraint(new RelationshipTypeConstraint(0 /*r:dm*/, "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramData"));
            builder.AddConstraint(new RelationshipTypeConstraint(1 /*r:lo*/, "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramLayout"));
            builder.AddConstraint(new RelationshipTypeConstraint(2 /*r:qs*/, "http://schemas.openxmlformats.org/officeDocument/2006/relationships/diagramQuickStyle"));
            builder.AddConstraint(new RelationshipExistConstraint(0 /*r:dm*/));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RelationshipIds>(deep);
    }

    /// <summary>
    /// <para>Style Definition.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:styleDef.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>StyleDefinitionTitle &lt;dgm:title></description></item>
    ///   <item><description>StyleLabelDescription &lt;dgm:desc></description></item>
    ///   <item><description>StyleDisplayCategories &lt;dgm:catLst></description></item>
    ///   <item><description>Scene3D &lt;dgm:scene3d></description></item>
    ///   <item><description>StyleLabel &lt;dgm:styleLbl></description></item>
    ///   <item><description>ExtensionList &lt;dgm:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class StyleDefinition : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the StyleDefinition class.
        /// </summary>
        public StyleDefinition() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleDefinition class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StyleDefinition(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleDefinition class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StyleDefinition(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleDefinition class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StyleDefinition(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Style ID</para>
        /// <para>Represents the following attribute in the schema: uniqueId</para>
        /// </summary>
        public StringValue UniqueId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Minimum Version</para>
        /// <para>Represents the following attribute in the schema: minVer</para>
        /// </summary>
        public StringValue MinVersion
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "styleDef");
            builder.AddChild<StyleDefinitionTitle>();
            builder.AddChild<StyleLabelDescription>();
            builder.AddChild<StyleDisplayCategories>();
            builder.AddChild<Scene3D>();
            builder.AddChild<StyleLabel>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<StyleDefinition>()
.AddAttribute(0, "uniqueId", a => a.UniqueId)
.AddAttribute(0, "minVer", a => a.MinVersion);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionTitle), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabelDescription), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategories), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Scene3D), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabel), 1, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StyleDefinition>(deep);

        internal StyleDefinition(DiagramStylePart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the DiagramStylePart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(DiagramStylePart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the DiagramStylePart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(DiagramStylePart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the DiagramStylePart associated with this element.
        /// </summary>
        public DiagramStylePart DiagramStylePart
        {
            get => OpenXmlPart as DiagramStylePart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Style Definition Header.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:styleDefHdr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>StyleDefinitionTitle &lt;dgm:title></description></item>
    ///   <item><description>StyleLabelDescription &lt;dgm:desc></description></item>
    ///   <item><description>StyleDisplayCategories &lt;dgm:catLst></description></item>
    ///   <item><description>ExtensionList &lt;dgm:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class StyleDefinitionHeader : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StyleDefinitionHeader class.
        /// </summary>
        public StyleDefinitionHeader() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleDefinitionHeader class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StyleDefinitionHeader(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleDefinitionHeader class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StyleDefinitionHeader(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleDefinitionHeader class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StyleDefinitionHeader(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Unique Style ID</para>
        /// <para>Represents the following attribute in the schema: uniqueId</para>
        /// </summary>
        public StringValue UniqueId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Minimum Version</para>
        /// <para>Represents the following attribute in the schema: minVer</para>
        /// </summary>
        public StringValue MinVersion
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Resource ID</para>
        /// <para>Represents the following attribute in the schema: resId</para>
        /// </summary>
        public Int32Value ResourceId
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "styleDefHdr");
            builder.AddChild<StyleDefinitionTitle>();
            builder.AddChild<StyleLabelDescription>();
            builder.AddChild<StyleDisplayCategories>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<StyleDefinitionHeader>()
.AddAttribute(0, "uniqueId", a => a.UniqueId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "minVer", a => a.MinVersion)
.AddAttribute(0, "resId", a => a.ResourceId);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionTitle), 1, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabelDescription), 1, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategories), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StyleDefinitionHeader>(deep);
    }

    /// <summary>
    /// <para>List of Style Definition Headers.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:styleDefHdrLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>StyleDefinitionHeader &lt;dgm:styleDefHdr></description></item>
    /// </list>
    /// </remark>
    public partial class StyleDefinitionHeaderList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StyleDefinitionHeaderList class.
        /// </summary>
        public StyleDefinitionHeaderList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleDefinitionHeaderList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StyleDefinitionHeaderList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleDefinitionHeaderList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StyleDefinitionHeaderList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleDefinitionHeaderList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StyleDefinitionHeaderList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "styleDefHdrLst");
            builder.AddChild<StyleDefinitionHeader>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionHeader), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StyleDefinitionHeaderList>(deep);
    }

    /// <summary>
    /// <para>Color Transform Category.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:cat.</para>
    /// </summary>
    public partial class ColorTransformCategory : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorTransformCategory class.
        /// </summary>
        public ColorTransformCategory() : base()
        {
        }

        /// <summary>
        /// <para>Category Type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        public StringValue Type
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Priority</para>
        /// <para>Represents the following attribute in the schema: pri</para>
        /// </summary>
        public UInt32Value Priority
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "cat");
            builder.AddElement<ColorTransformCategory>()
.AddAttribute(0, "type", a => a.Type, aBuilder =>
{
   aBuilder.AddValidator(RequiredValidator.Instance);
   aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
})
.AddAttribute(0, "pri", a => a.Priority, aBuilder =>
{
   aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorTransformCategory>(deep);
    }

    /// <summary>
    /// <para>Fill Color List.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:fillClrLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage &lt;a:scrgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelHex &lt;a:srgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HslColor &lt;a:hslClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SystemColor &lt;a:sysClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SchemeColor &lt;a:schemeClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PresetColor &lt;a:prstClr></description></item>
    /// </list>
    /// </remark>
    public partial class FillColorList : ColorsType
    {
        /// <summary>
        /// Initializes a new instance of the FillColorList class.
        /// </summary>
        public FillColorList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FillColorList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FillColorList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FillColorList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FillColorList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FillColorList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FillColorList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "fillClrLst");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FillColorList>(deep);
    }

    /// <summary>
    /// <para>Line Color List.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:linClrLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage &lt;a:scrgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelHex &lt;a:srgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HslColor &lt;a:hslClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SystemColor &lt;a:sysClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SchemeColor &lt;a:schemeClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PresetColor &lt;a:prstClr></description></item>
    /// </list>
    /// </remark>
    public partial class LineColorList : ColorsType
    {
        /// <summary>
        /// Initializes a new instance of the LineColorList class.
        /// </summary>
        public LineColorList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineColorList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LineColorList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineColorList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LineColorList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LineColorList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LineColorList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "linClrLst");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LineColorList>(deep);
    }

    /// <summary>
    /// <para>Effect Color List.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:effectClrLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage &lt;a:scrgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelHex &lt;a:srgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HslColor &lt;a:hslClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SystemColor &lt;a:sysClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SchemeColor &lt;a:schemeClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PresetColor &lt;a:prstClr></description></item>
    /// </list>
    /// </remark>
    public partial class EffectColorList : ColorsType
    {
        /// <summary>
        /// Initializes a new instance of the EffectColorList class.
        /// </summary>
        public EffectColorList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EffectColorList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EffectColorList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EffectColorList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EffectColorList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EffectColorList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public EffectColorList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "effectClrLst");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EffectColorList>(deep);
    }

    /// <summary>
    /// <para>Text Line Color List.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:txLinClrLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage &lt;a:scrgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelHex &lt;a:srgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HslColor &lt;a:hslClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SystemColor &lt;a:sysClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SchemeColor &lt;a:schemeClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PresetColor &lt;a:prstClr></description></item>
    /// </list>
    /// </remark>
    public partial class TextLineColorList : ColorsType
    {
        /// <summary>
        /// Initializes a new instance of the TextLineColorList class.
        /// </summary>
        public TextLineColorList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextLineColorList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextLineColorList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextLineColorList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextLineColorList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextLineColorList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextLineColorList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "txLinClrLst");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextLineColorList>(deep);
    }

    /// <summary>
    /// <para>Text Fill Color List.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:txFillClrLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage &lt;a:scrgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelHex &lt;a:srgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HslColor &lt;a:hslClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SystemColor &lt;a:sysClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SchemeColor &lt;a:schemeClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PresetColor &lt;a:prstClr></description></item>
    /// </list>
    /// </remark>
    public partial class TextFillColorList : ColorsType
    {
        /// <summary>
        /// Initializes a new instance of the TextFillColorList class.
        /// </summary>
        public TextFillColorList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextFillColorList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextFillColorList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextFillColorList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextFillColorList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextFillColorList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextFillColorList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "txFillClrLst");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextFillColorList>(deep);
    }

    /// <summary>
    /// <para>Text Effect Color List.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:txEffectClrLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage &lt;a:scrgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelHex &lt;a:srgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HslColor &lt;a:hslClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SystemColor &lt;a:sysClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SchemeColor &lt;a:schemeClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PresetColor &lt;a:prstClr></description></item>
    /// </list>
    /// </remark>
    public partial class TextEffectColorList : ColorsType
    {
        /// <summary>
        /// Initializes a new instance of the TextEffectColorList class.
        /// </summary>
        public TextEffectColorList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextEffectColorList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextEffectColorList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextEffectColorList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextEffectColorList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextEffectColorList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextEffectColorList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "txEffectClrLst");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextEffectColorList>(deep);
    }

    /// <summary>
    /// <para>Defines the ColorsType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage &lt;a:scrgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.RgbColorModelHex &lt;a:srgbClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.HslColor &lt;a:hslClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SystemColor &lt;a:sysClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SchemeColor &lt;a:schemeClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PresetColor &lt;a:prstClr></description></item>
    /// </list>
    /// </remark>
    public abstract partial class ColorsType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorsType class.
        /// </summary>
        protected ColorsType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorsType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected ColorsType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorsType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected ColorsType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorsType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected ColorsType(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Color Application Method Type</para>
        /// <para>Represents the following attribute in the schema: meth</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ColorApplicationMethodValues> Method
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ColorApplicationMethodValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hue Direction</para>
        /// <para>Represents the following attribute in the schema: hueDir</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.HueDirectionValues> HueDirection
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.HueDirectionValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HslColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SystemColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SchemeColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PresetColor>();
            builder.AddElement<ColorsType>()
.AddAttribute(0, "meth", a => a.Method, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "hueDir", a => a.HueDirection, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
        }
    }

    /// <summary>
    /// <para>Defines the ExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Extension &lt;a:ext></description></item>
    /// </list>
    /// </remark>
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
            builder.SetSchema(14, "extLst");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Extension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Extension), 0, 0)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtensionList>(deep);
    }

    /// <summary>
    /// <para>Title.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:title.</para>
    /// </summary>
    public partial class ColorDefinitionTitle : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorDefinitionTitle class.
        /// </summary>
        public ColorDefinitionTitle() : base()
        {
        }

        /// <summary>
        /// <para>Language</para>
        /// <para>Represents the following attribute in the schema: lang</para>
        /// </summary>
        public StringValue Language
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Description Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public StringValue Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "title");
            builder.AddElement<ColorDefinitionTitle>()
.AddAttribute(0, "lang", a => a.Language)
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
 aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorDefinitionTitle>(deep);
    }

    /// <summary>
    /// <para>Description.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:desc.</para>
    /// </summary>
    public partial class ColorTransformDescription : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorTransformDescription class.
        /// </summary>
        public ColorTransformDescription() : base()
        {
        }

        /// <summary>
        /// <para>Language</para>
        /// <para>Represents the following attribute in the schema: lang</para>
        /// </summary>
        public StringValue Language
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Description Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public StringValue Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "desc");
            builder.AddElement<ColorTransformDescription>()
.AddAttribute(0, "lang", a => a.Language)
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
  aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorTransformDescription>(deep);
    }

    /// <summary>
    /// <para>Color Transform Category List.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:catLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ColorTransformCategory &lt;dgm:cat></description></item>
    /// </list>
    /// </remark>
    public partial class ColorTransformCategories : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorTransformCategories class.
        /// </summary>
        public ColorTransformCategories() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorTransformCategories class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorTransformCategories(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorTransformCategories class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorTransformCategories(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorTransformCategories class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ColorTransformCategories(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "catLst");
            builder.AddChild<ColorTransformCategory>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 0, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategory), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorTransformCategories>(deep);
    }

    /// <summary>
    /// <para>Style Label.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:styleLbl.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>FillColorList &lt;dgm:fillClrLst></description></item>
    ///   <item><description>LineColorList &lt;dgm:linClrLst></description></item>
    ///   <item><description>EffectColorList &lt;dgm:effectClrLst></description></item>
    ///   <item><description>TextLineColorList &lt;dgm:txLinClrLst></description></item>
    ///   <item><description>TextFillColorList &lt;dgm:txFillClrLst></description></item>
    ///   <item><description>TextEffectColorList &lt;dgm:txEffectClrLst></description></item>
    ///   <item><description>ExtensionList &lt;dgm:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class ColorTransformStyleLabel : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorTransformStyleLabel class.
        /// </summary>
        public ColorTransformStyleLabel() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorTransformStyleLabel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorTransformStyleLabel(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorTransformStyleLabel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorTransformStyleLabel(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorTransformStyleLabel class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ColorTransformStyleLabel(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Name</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        public StringValue Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "styleLbl");
            builder.AddChild<FillColorList>();
            builder.AddChild<LineColorList>();
            builder.AddChild<EffectColorList>();
            builder.AddChild<TextLineColorList>();
            builder.AddChild<TextFillColorList>();
            builder.AddChild<TextEffectColorList>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<ColorTransformStyleLabel>()
.AddAttribute(0, "name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.FillColorList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.LineColorList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.EffectColorList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.TextLineColorList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.TextFillColorList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.TextEffectColorList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Fill Color List.</para>
        /// <para>Represents the following element tag in the schema: dgm:fillClrLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public FillColorList FillColorList
        {
            get => GetElement<FillColorList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Line Color List.</para>
        /// <para>Represents the following element tag in the schema: dgm:linClrLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public LineColorList LineColorList
        {
            get => GetElement<LineColorList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Effect Color List.</para>
        /// <para>Represents the following element tag in the schema: dgm:effectClrLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public EffectColorList EffectColorList
        {
            get => GetElement<EffectColorList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Text Line Color List.</para>
        /// <para>Represents the following element tag in the schema: dgm:txLinClrLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public TextLineColorList TextLineColorList
        {
            get => GetElement<TextLineColorList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Text Fill Color List.</para>
        /// <para>Represents the following element tag in the schema: dgm:txFillClrLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public TextFillColorList TextFillColorList
        {
            get => GetElement<TextFillColorList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Text Effect Color List.</para>
        /// <para>Represents the following element tag in the schema: dgm:txEffectClrLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public TextEffectColorList TextEffectColorList
        {
            get => GetElement<TextEffectColorList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: dgm:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorTransformStyleLabel>(deep);
    }

    /// <summary>
    /// <para>Point.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:pt.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PropertySet &lt;dgm:prSet></description></item>
    ///   <item><description>ShapeProperties &lt;dgm:spPr></description></item>
    ///   <item><description>TextBody &lt;dgm:t></description></item>
    ///   <item><description>PtExtensionList &lt;dgm:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class Point : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Point class.
        /// </summary>
        public Point() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Point class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Point(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Point class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Point(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Point class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Point(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Model Identifier</para>
        /// <para>Represents the following attribute in the schema: modelId</para>
        /// </summary>
        public StringValue ModelId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Point Type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.PointValues> Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.PointValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Connection Identifier</para>
        /// <para>Represents the following attribute in the schema: cxnId</para>
        /// </summary>
        public StringValue ConnectionId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "pt");
            builder.AddChild<PropertySet>();
            builder.AddChild<ShapeProperties>();
            builder.AddChild<TextBody>();
            builder.AddChild<PtExtensionList>();
            builder.AddElement<Point>()
.AddAttribute(0, "modelId", a => a.ModelId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddUnion(union =>
{
union.AddValidator<Int32Value>(NumberValidator.Instance);
union.AddValidator(new StringValidator() { Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
})
.AddAttribute(0, "type", a => a.Type, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "cxnId", a => a.ConnectionId, aBuilder =>
{
aBuilder.AddUnion(union =>
{
union.AddValidator<Int32Value>(NumberValidator.Instance);
union.AddValidator(new StringValidator() { Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ShapeProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.TextBody), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.PtExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Property Set.</para>
        /// <para>Represents the following element tag in the schema: dgm:prSet.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public PropertySet PropertySet
        {
            get => GetElement<PropertySet>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Shape Properties.</para>
        /// <para>Represents the following element tag in the schema: dgm:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public ShapeProperties ShapeProperties
        {
            get => GetElement<ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Text Body.</para>
        /// <para>Represents the following element tag in the schema: dgm:t.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public TextBody TextBody
        {
            get => GetElement<TextBody>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: dgm:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public PtExtensionList PtExtensionList
        {
            get => GetElement<PtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Point>(deep);
    }

    /// <summary>
    /// <para>Connection.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:cxn.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionList &lt;dgm:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class Connection : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Connection class.
        /// </summary>
        public Connection() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Connection class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Connection(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Connection class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Connection(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Connection class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Connection(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Model Identifier</para>
        /// <para>Represents the following attribute in the schema: modelId</para>
        /// </summary>
        public StringValue ModelId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Point Type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionValues> Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Source Identifier</para>
        /// <para>Represents the following attribute in the schema: srcId</para>
        /// </summary>
        public StringValue SourceId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Destination Identifier</para>
        /// <para>Represents the following attribute in the schema: destId</para>
        /// </summary>
        public StringValue DestinationId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Source Position</para>
        /// <para>Represents the following attribute in the schema: srcOrd</para>
        /// </summary>
        public UInt32Value SourcePosition
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Destination Position</para>
        /// <para>Represents the following attribute in the schema: destOrd</para>
        /// </summary>
        public UInt32Value DestinationPosition
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Parent Transition Identifier</para>
        /// <para>Represents the following attribute in the schema: parTransId</para>
        /// </summary>
        public StringValue ParentTransitionId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Sibling Transition Identifier</para>
        /// <para>Represents the following attribute in the schema: sibTransId</para>
        /// </summary>
        public StringValue SiblingTransitionId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Presentation Identifier</para>
        /// <para>Represents the following attribute in the schema: presId</para>
        /// </summary>
        public StringValue PresentationId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "cxn");
            builder.AddChild<ExtensionList>();
            builder.AddElement<Connection>()
.AddAttribute(0, "modelId", a => a.ModelId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddUnion(union =>
{
union.AddValidator<Int32Value>(NumberValidator.Instance);
union.AddValidator(new StringValidator() { Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
})
.AddAttribute(0, "type", a => a.Type, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "srcId", a => a.SourceId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddUnion(union =>
{
union.AddValidator<Int32Value>(NumberValidator.Instance);
union.AddValidator(new StringValidator() { Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
})
.AddAttribute(0, "destId", a => a.DestinationId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddUnion(union =>
{
union.AddValidator<Int32Value>(NumberValidator.Instance);
union.AddValidator(new StringValidator() { Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
})
.AddAttribute(0, "srcOrd", a => a.SourcePosition, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "destOrd", a => a.DestinationPosition, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(0, "parTransId", a => a.ParentTransitionId, aBuilder =>
{
aBuilder.AddUnion(union =>
{
union.AddValidator<Int32Value>(NumberValidator.Instance);
union.AddValidator(new StringValidator() { Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
})
.AddAttribute(0, "sibTransId", a => a.SiblingTransitionId, aBuilder =>
{
aBuilder.AddUnion(union =>
{
union.AddValidator<Int32Value>(NumberValidator.Instance);
union.AddValidator(new StringValidator() { Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
})
.AddAttribute(0, "presId", a => a.PresentationId);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
            builder.AddConstraint(new UniqueAttributeValueConstraint(0 /*:modelId*/, true, typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionList)));
            builder.AddConstraint(new UniqueAttributeValueConstraint(6 /*:parTransId*/, true, null));
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: dgm:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Connection>(deep);
    }

    /// <summary>
    /// <para>Constraint.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:constr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionList &lt;dgm:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class Constraint : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Constraint class.
        /// </summary>
        public Constraint() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Constraint class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Constraint(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Constraint class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Constraint(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Constraint class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Constraint(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Constraint Type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues> Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>For</para>
        /// <para>Represents the following attribute in the schema: for</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues> For
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>For Name</para>
        /// <para>Represents the following attribute in the schema: forName</para>
        /// </summary>
        public StringValue ForName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Data Point Type</para>
        /// <para>Represents the following attribute in the schema: ptType</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues> PointType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Reference Type</para>
        /// <para>Represents the following attribute in the schema: refType</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues> ReferenceType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Reference For</para>
        /// <para>Represents the following attribute in the schema: refFor</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues> ReferenceFor
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Reference For Name</para>
        /// <para>Represents the following attribute in the schema: refForName</para>
        /// </summary>
        public StringValue ReferenceForName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Reference Point Type</para>
        /// <para>Represents the following attribute in the schema: refPtType</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues> ReferencePointType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Operator</para>
        /// <para>Represents the following attribute in the schema: op</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.BoolOperatorValues> Operator
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.BoolOperatorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public DoubleValue Val
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Factor</para>
        /// <para>Represents the following attribute in the schema: fact</para>
        /// </summary>
        public DoubleValue Fact
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "constr");
            builder.AddChild<ExtensionList>();
            builder.AddElement<Constraint>()
.AddAttribute(0, "type", a => a.Type, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "for", a => a.For, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "forName", a => a.ForName)
.AddAttribute(0, "ptType", a => a.PointType, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "refType", a => a.ReferenceType, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "refFor", a => a.ReferenceFor, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "refForName", a => a.ReferenceForName)
.AddAttribute(0, "refPtType", a => a.ReferencePointType, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "op", a => a.Operator, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "val", a => a.Val)
.AddAttribute(0, "fact", a => a.Fact);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: dgm:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Constraint>(deep);
    }

    /// <summary>
    /// <para>Rule.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:rule.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionList &lt;dgm:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class Rule : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Rule class.
        /// </summary>
        public Rule() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Rule class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Rule(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Rule class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Rule(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Rule class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Rule(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Constraint Type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues> Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>For</para>
        /// <para>Represents the following attribute in the schema: for</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues> For
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConstraintRelationshipValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>For Name</para>
        /// <para>Represents the following attribute in the schema: forName</para>
        /// </summary>
        public StringValue ForName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Data Point Type</para>
        /// <para>Represents the following attribute in the schema: ptType</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues> PointType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public DoubleValue Val
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Factor</para>
        /// <para>Represents the following attribute in the schema: fact</para>
        /// </summary>
        public DoubleValue Fact
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Max Value</para>
        /// <para>Represents the following attribute in the schema: max</para>
        /// </summary>
        public DoubleValue Max
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "rule");
            builder.AddChild<ExtensionList>();
            builder.AddElement<Rule>()
.AddAttribute(0, "type", a => a.Type, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "for", a => a.For, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "forName", a => a.ForName)
.AddAttribute(0, "ptType", a => a.PointType, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "val", a => a.Val)
.AddAttribute(0, "fact", a => a.Fact)
.AddAttribute(0, "max", a => a.Max);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: dgm:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Rule>(deep);
    }

    /// <summary>
    /// <para>Shape Adjust.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:adj.</para>
    /// </summary>
    public partial class Adjust : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Adjust class.
        /// </summary>
        public Adjust() : base()
        {
        }

        /// <summary>
        /// <para>Adjust Handle Index</para>
        /// <para>Represents the following attribute in the schema: idx</para>
        /// </summary>
        public UInt32Value Index
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public DoubleValue Val
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "adj");
            builder.AddElement<Adjust>()
.AddAttribute(0, "idx", a => a.Index, aBuilder =>
{
   aBuilder.AddValidator(RequiredValidator.Instance);
   aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L) });
})
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
   aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Adjust>(deep);
    }

    /// <summary>
    /// <para>Shape Adjust List.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:adjLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Adjust &lt;dgm:adj></description></item>
    /// </list>
    /// </remark>
    public partial class AdjustList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AdjustList class.
        /// </summary>
        public AdjustList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AdjustList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AdjustList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AdjustList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AdjustList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AdjustList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AdjustList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "adjLst");
            builder.AddChild<Adjust>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Adjust), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AdjustList>(deep);
    }

    /// <summary>
    /// <para>Parameter.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:param.</para>
    /// </summary>
    public partial class Parameter : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Parameter class.
        /// </summary>
        public Parameter() : base()
        {
        }

        /// <summary>
        /// <para>Parameter Type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ParameterIdValues> Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ParameterIdValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public StringValue Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "param");
            builder.AddElement<Parameter>()
.AddAttribute(0, "type", a => a.Type, aBuilder =>
{
 aBuilder.AddValidator(RequiredValidator.Instance);
 aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
 aBuilder.AddUnion(union =>
 {
     union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.HorizontalAlignmentValues>>(EnumValidator.Instance);
     union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.VerticalAlignmentValues>>(EnumValidator.Instance);
     union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ChildDirectionValues>>(EnumValidator.Instance);
     union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ChildAlignmentValues>>(EnumValidator.Instance);
     union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.SecondaryChildAlignmentValues>>(EnumValidator.Instance);
     union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.LinearDirectionValues>>(EnumValidator.Instance);
     union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.SecondaryLinearDirectionValues>>(EnumValidator.Instance);
     union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.StartingElementValues>>(EnumValidator.Instance);
     union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.BendPointValues>>(EnumValidator.Instance);
     union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectorRoutingValues>>(EnumValidator.Instance);
     union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ArrowheadStyleValues>>(EnumValidator.Instance);
     union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectorDimensionValues>>(EnumValidator.Instance);
     union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.RotationPathValues>>(EnumValidator.Instance);
     union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.CenterShapeMappingValues>>(EnumValidator.Instance);
     union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.NodeHorizontalAlignmentValues>>(EnumValidator.Instance);
     union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.NodeVerticalAlignmentValues>>(EnumValidator.Instance);
     union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.FallbackDimensionValues>>(EnumValidator.Instance);
     union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.TextDirectionValues>>(EnumValidator.Instance);
     union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.PyramidAccentPositionValues>>(EnumValidator.Instance);
     union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.PyramidAccentTextMarginValues>>(EnumValidator.Instance);
     union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.TextBlockDirectionValues>>(EnumValidator.Instance);
     union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.TextAnchorHorizontalValues>>(EnumValidator.Instance);
     union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.TextAnchorVerticalValues>>(EnumValidator.Instance);
     union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.TextAlignmentValues>>(EnumValidator.Instance);
     union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AutoTextRotationValues>>(EnumValidator.Instance);
     union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.GrowDirectionValues>>(EnumValidator.Instance);
     union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.FlowDirectionValues>>(EnumValidator.Instance);
     union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ContinueDirectionValues>>(EnumValidator.Instance);
     union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.BreakpointValues>>(EnumValidator.Instance);
     union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.OffsetValues>>(EnumValidator.Instance);
     union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyAlignmentValues>>(EnumValidator.Instance);
     union.AddValidator<Int32Value>(NumberValidator.Instance);
     union.AddValidator<DoubleValue>(NumberValidator.Instance);
     union.AddValidator<BooleanValue>(NumberValidator.Instance);
     union.AddValidator(StringValidator.Instance);
     union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ConnectorPointValues>>(EnumValidator.Instance);
 });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Parameter>(deep);
    }

    /// <summary>
    /// <para>Algorithm.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:alg.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Parameter &lt;dgm:param></description></item>
    ///   <item><description>ExtensionList &lt;dgm:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class Algorithm : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Algorithm class.
        /// </summary>
        public Algorithm() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Algorithm class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Algorithm(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Algorithm class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Algorithm(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Algorithm class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Algorithm(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Algorithm Type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AlgorithmValues> Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AlgorithmValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Revision Number</para>
        /// <para>Represents the following attribute in the schema: rev</para>
        /// </summary>
        public UInt32Value Revision
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "alg");
            builder.AddChild<Parameter>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<Algorithm>()
.AddAttribute(0, "type", a => a.Type, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "rev", a => a.Revision);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Parameter), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Algorithm>(deep);
    }

    /// <summary>
    /// <para>Shape.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:shape.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>AdjustList &lt;dgm:adjLst></description></item>
    ///   <item><description>ExtensionList &lt;dgm:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class Shape : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Shape class.
        /// </summary>
        public Shape() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Shape(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Shape(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shape class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Shape(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Rotation</para>
        /// <para>Represents the following attribute in the schema: rot</para>
        /// </summary>
        public DoubleValue Rotation
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Shape Type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        public StringValue Type
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Relationship to Image Part</para>
        /// <para>Represents the following attribute in the schema: r:blip</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        public StringValue Blip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Z-Order Offset</para>
        /// <para>Represents the following attribute in the schema: zOrderOff</para>
        /// </summary>
        public Int32Value ZOrderOffset
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hide Geometry</para>
        /// <para>Represents the following attribute in the schema: hideGeom</para>
        /// </summary>
        public BooleanValue HideGeometry
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Prevent Text Editing</para>
        /// <para>Represents the following attribute in the schema: lkTxEntry</para>
        /// </summary>
        public BooleanValue LockedText
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Image Placeholder</para>
        /// <para>Represents the following attribute in the schema: blipPhldr</para>
        /// </summary>
        public BooleanValue BlipPlaceholder
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "shape");
            builder.AddChild<AdjustList>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<Shape>()
.AddAttribute(0, "rot", a => a.Rotation)
.AddAttribute(0, "type", a => a.Type, aBuilder =>
{
aBuilder.AddUnion(union =>
{
union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.ShapeTypeValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.OutputShapeValues>>(EnumValidator.Instance);
});
})
.AddAttribute(19, "blip", a => a.Blip)
.AddAttribute(0, "zOrderOff", a => a.ZOrderOffset)
.AddAttribute(0, "hideGeom", a => a.HideGeometry)
.AddAttribute(0, "lkTxEntry", a => a.LockedText)
.AddAttribute(0, "blipPhldr", a => a.BlipPlaceholder);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.AdjustList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
            builder.AddConstraint(new RelationshipTypeConstraint(2 /*r:blip*/, "http://schemas.openxmlformats.org/officeDocument/2006/relationships/image"));
            builder.AddConstraint(new RelationshipExistConstraint(2 /*r:blip*/));
        }

        /// <summary>
        /// <para>Shape Adjust List.</para>
        /// <para>Represents the following element tag in the schema: dgm:adjLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public AdjustList AdjustList
        {
            get => GetElement<AdjustList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: dgm:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Shape>(deep);
    }

    /// <summary>
    /// <para>Presentation Of.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:presOf.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ExtensionList &lt;dgm:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class PresentationOf : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PresentationOf class.
        /// </summary>
        public PresentationOf() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PresentationOf class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PresentationOf(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PresentationOf class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PresentationOf(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PresentationOf class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PresentationOf(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Axis</para>
        /// <para>Represents the following attribute in the schema: axis</para>
        /// </summary>
        public ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AxisValues>> Axis
        {
            get => GetAttribute<ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AxisValues>>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Data Point Type</para>
        /// <para>Represents the following attribute in the schema: ptType</para>
        /// </summary>
        public ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>> PointType
        {
            get => GetAttribute<ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hide Last Transition</para>
        /// <para>Represents the following attribute in the schema: hideLastTrans</para>
        /// </summary>
        public ListValue<BooleanValue> HideLastTrans
        {
            get => GetAttribute<ListValue<BooleanValue>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Start</para>
        /// <para>Represents the following attribute in the schema: st</para>
        /// </summary>
        public ListValue<Int32Value> Start
        {
            get => GetAttribute<ListValue<Int32Value>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Count</para>
        /// <para>Represents the following attribute in the schema: cnt</para>
        /// </summary>
        public ListValue<UInt32Value> Count
        {
            get => GetAttribute<ListValue<UInt32Value>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Step</para>
        /// <para>Represents the following attribute in the schema: step</para>
        /// </summary>
        public ListValue<Int32Value> Step
        {
            get => GetAttribute<ListValue<Int32Value>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "presOf");
            builder.AddChild<ExtensionList>();
            builder.AddElement<PresentationOf>()
.AddAttribute(0, "axis", a => a.Axis)
.AddAttribute(0, "ptType", a => a.PointType)
.AddAttribute(0, "hideLastTrans", a => a.HideLastTrans)
.AddAttribute(0, "st", a => a.Start)
.AddAttribute(0, "cnt", a => a.Count)
.AddAttribute(0, "step", a => a.Step);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: dgm:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PresentationOf>(deep);
    }

    /// <summary>
    /// <para>Constraint List.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:constrLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Constraint &lt;dgm:constr></description></item>
    /// </list>
    /// </remark>
    public partial class Constraints : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Constraints class.
        /// </summary>
        public Constraints() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Constraints class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Constraints(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Constraints class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Constraints(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Constraints class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Constraints(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "constrLst");
            builder.AddChild<Constraint>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Constraint), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Constraints>(deep);
    }

    /// <summary>
    /// <para>Rule List.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:ruleLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Rule &lt;dgm:rule></description></item>
    /// </list>
    /// </remark>
    public partial class RuleList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RuleList class.
        /// </summary>
        public RuleList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RuleList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RuleList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RuleList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RuleList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RuleList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RuleList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "ruleLst");
            builder.AddChild<Rule>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Rule), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RuleList>(deep);
    }

    /// <summary>
    /// <para>Variable List.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:varLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>OrganizationChart &lt;dgm:orgChart></description></item>
    ///   <item><description>MaxNumberOfChildren &lt;dgm:chMax></description></item>
    ///   <item><description>PreferredNumberOfChildren &lt;dgm:chPref></description></item>
    ///   <item><description>BulletEnabled &lt;dgm:bulletEnabled></description></item>
    ///   <item><description>Direction &lt;dgm:dir></description></item>
    ///   <item><description>HierarchyBranch &lt;dgm:hierBranch></description></item>
    ///   <item><description>AnimateOneByOne &lt;dgm:animOne></description></item>
    ///   <item><description>AnimationLevel &lt;dgm:animLvl></description></item>
    ///   <item><description>ResizeHandles &lt;dgm:resizeHandles></description></item>
    /// </list>
    /// </remark>
    public partial class VariableList : LayoutVariablePropertySetType
    {
        /// <summary>
        /// Initializes a new instance of the VariableList class.
        /// </summary>
        public VariableList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VariableList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public VariableList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the VariableList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public VariableList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the VariableList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public VariableList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "varLst");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.OrganizationChart), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.MaxNumberOfChildren), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.PreferredNumberOfChildren), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.BulletEnabled), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Direction), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranch), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOne), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevel), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandles), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VariableList>(deep);
    }

    /// <summary>
    /// <para>Presentation Layout Variables.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:presLayoutVars.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>OrganizationChart &lt;dgm:orgChart></description></item>
    ///   <item><description>MaxNumberOfChildren &lt;dgm:chMax></description></item>
    ///   <item><description>PreferredNumberOfChildren &lt;dgm:chPref></description></item>
    ///   <item><description>BulletEnabled &lt;dgm:bulletEnabled></description></item>
    ///   <item><description>Direction &lt;dgm:dir></description></item>
    ///   <item><description>HierarchyBranch &lt;dgm:hierBranch></description></item>
    ///   <item><description>AnimateOneByOne &lt;dgm:animOne></description></item>
    ///   <item><description>AnimationLevel &lt;dgm:animLvl></description></item>
    ///   <item><description>ResizeHandles &lt;dgm:resizeHandles></description></item>
    /// </list>
    /// </remark>
    public partial class PresentationLayoutVariables : LayoutVariablePropertySetType
    {
        /// <summary>
        /// Initializes a new instance of the PresentationLayoutVariables class.
        /// </summary>
        public PresentationLayoutVariables() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PresentationLayoutVariables class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PresentationLayoutVariables(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PresentationLayoutVariables class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PresentationLayoutVariables(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PresentationLayoutVariables class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PresentationLayoutVariables(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "presLayoutVars");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.OrganizationChart), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.MaxNumberOfChildren), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.PreferredNumberOfChildren), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.BulletEnabled), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Direction), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranch), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOne), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevel), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandles), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PresentationLayoutVariables>(deep);
    }

    /// <summary>
    /// <para>Defines the LayoutVariablePropertySetType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>OrganizationChart &lt;dgm:orgChart></description></item>
    ///   <item><description>MaxNumberOfChildren &lt;dgm:chMax></description></item>
    ///   <item><description>PreferredNumberOfChildren &lt;dgm:chPref></description></item>
    ///   <item><description>BulletEnabled &lt;dgm:bulletEnabled></description></item>
    ///   <item><description>Direction &lt;dgm:dir></description></item>
    ///   <item><description>HierarchyBranch &lt;dgm:hierBranch></description></item>
    ///   <item><description>AnimateOneByOne &lt;dgm:animOne></description></item>
    ///   <item><description>AnimationLevel &lt;dgm:animLvl></description></item>
    ///   <item><description>ResizeHandles &lt;dgm:resizeHandles></description></item>
    /// </list>
    /// </remark>
    public abstract partial class LayoutVariablePropertySetType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LayoutVariablePropertySetType class.
        /// </summary>
        protected LayoutVariablePropertySetType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutVariablePropertySetType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected LayoutVariablePropertySetType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutVariablePropertySetType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected LayoutVariablePropertySetType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutVariablePropertySetType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected LayoutVariablePropertySetType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<OrganizationChart>();
            builder.AddChild<MaxNumberOfChildren>();
            builder.AddChild<PreferredNumberOfChildren>();
            builder.AddChild<BulletEnabled>();
            builder.AddChild<Direction>();
            builder.AddChild<HierarchyBranch>();
            builder.AddChild<AnimateOneByOne>();
            builder.AddChild<AnimationLevel>();
            builder.AddChild<ResizeHandles>();
        }

        /// <summary>
        /// <para>Show Organization Chart User Interface.</para>
        /// <para>Represents the following element tag in the schema: dgm:orgChart.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public OrganizationChart OrganizationChart
        {
            get => GetElement<OrganizationChart>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Maximum Children.</para>
        /// <para>Represents the following element tag in the schema: dgm:chMax.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public MaxNumberOfChildren MaxNumberOfChildren
        {
            get => GetElement<MaxNumberOfChildren>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Preferred Number of Children.</para>
        /// <para>Represents the following element tag in the schema: dgm:chPref.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public PreferredNumberOfChildren PreferredNumberOfChildren
        {
            get => GetElement<PreferredNumberOfChildren>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Show Insert Bullet.</para>
        /// <para>Represents the following element tag in the schema: dgm:bulletEnabled.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public BulletEnabled BulletEnabled
        {
            get => GetElement<BulletEnabled>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Diagram Direction.</para>
        /// <para>Represents the following element tag in the schema: dgm:dir.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public Direction Direction
        {
            get => GetElement<Direction>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Organization Chart Branch Style.</para>
        /// <para>Represents the following element tag in the schema: dgm:hierBranch.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public HierarchyBranch HierarchyBranch
        {
            get => GetElement<HierarchyBranch>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>One by One Animation String.</para>
        /// <para>Represents the following element tag in the schema: dgm:animOne.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public AnimateOneByOne AnimateOneByOne
        {
            get => GetElement<AnimateOneByOne>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Level Animation.</para>
        /// <para>Represents the following element tag in the schema: dgm:animLvl.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public AnimationLevel AnimationLevel
        {
            get => GetElement<AnimationLevel>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Shape Resize Style.</para>
        /// <para>Represents the following element tag in the schema: dgm:resizeHandles.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public ResizeHandles ResizeHandles
        {
            get => GetElement<ResizeHandles>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>For Each.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:forEach.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Algorithm &lt;dgm:alg></description></item>
    ///   <item><description>Shape &lt;dgm:shape></description></item>
    ///   <item><description>PresentationOf &lt;dgm:presOf></description></item>
    ///   <item><description>Constraints &lt;dgm:constrLst></description></item>
    ///   <item><description>RuleList &lt;dgm:ruleLst></description></item>
    ///   <item><description>ForEach &lt;dgm:forEach></description></item>
    ///   <item><description>LayoutNode &lt;dgm:layoutNode></description></item>
    ///   <item><description>Choose &lt;dgm:choose></description></item>
    ///   <item><description>ExtensionList &lt;dgm:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class ForEach : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ForEach class.
        /// </summary>
        public ForEach() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ForEach class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ForEach(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ForEach class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ForEach(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ForEach class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ForEach(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Name</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        public StringValue Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Reference</para>
        /// <para>Represents the following attribute in the schema: ref</para>
        /// </summary>
        public StringValue Reference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Axis</para>
        /// <para>Represents the following attribute in the schema: axis</para>
        /// </summary>
        public ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AxisValues>> Axis
        {
            get => GetAttribute<ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AxisValues>>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Data Point Type</para>
        /// <para>Represents the following attribute in the schema: ptType</para>
        /// </summary>
        public ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>> PointType
        {
            get => GetAttribute<ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hide Last Transition</para>
        /// <para>Represents the following attribute in the schema: hideLastTrans</para>
        /// </summary>
        public ListValue<BooleanValue> HideLastTrans
        {
            get => GetAttribute<ListValue<BooleanValue>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Start</para>
        /// <para>Represents the following attribute in the schema: st</para>
        /// </summary>
        public ListValue<Int32Value> Start
        {
            get => GetAttribute<ListValue<Int32Value>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Count</para>
        /// <para>Represents the following attribute in the schema: cnt</para>
        /// </summary>
        public ListValue<UInt32Value> Count
        {
            get => GetAttribute<ListValue<UInt32Value>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Step</para>
        /// <para>Represents the following attribute in the schema: step</para>
        /// </summary>
        public ListValue<Int32Value> Step
        {
            get => GetAttribute<ListValue<Int32Value>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "forEach");
            builder.AddChild<Algorithm>();
            builder.AddChild<Shape>();
            builder.AddChild<PresentationOf>();
            builder.AddChild<Constraints>();
            builder.AddChild<RuleList>();
            builder.AddChild<ForEach>();
            builder.AddChild<LayoutNode>();
            builder.AddChild<Choose>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<ForEach>()
.AddAttribute(0, "name", a => a.Name)
.AddAttribute(0, "ref", a => a.Reference)
.AddAttribute(0, "axis", a => a.Axis)
.AddAttribute(0, "ptType", a => a.PointType)
.AddAttribute(0, "hideLastTrans", a => a.HideLastTrans)
.AddAttribute(0, "st", a => a.Start)
.AddAttribute(0, "cnt", a => a.Count)
.AddAttribute(0, "step", a => a.Step);
            builder.Particle = new CompositeParticle(ParticleType.Choice, 0, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Shape), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Constraints), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.RuleList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ForEach), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Choose), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
            builder.AddConstraint(new UniqueAttributeValueConstraint(0 /*:name*/, true, null));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ForEach>(deep);
    }

    /// <summary>
    /// <para>Layout Node.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:layoutNode.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Algorithm &lt;dgm:alg></description></item>
    ///   <item><description>Shape &lt;dgm:shape></description></item>
    ///   <item><description>PresentationOf &lt;dgm:presOf></description></item>
    ///   <item><description>Constraints &lt;dgm:constrLst></description></item>
    ///   <item><description>RuleList &lt;dgm:ruleLst></description></item>
    ///   <item><description>VariableList &lt;dgm:varLst></description></item>
    ///   <item><description>ForEach &lt;dgm:forEach></description></item>
    ///   <item><description>LayoutNode &lt;dgm:layoutNode></description></item>
    ///   <item><description>Choose &lt;dgm:choose></description></item>
    ///   <item><description>ExtensionList &lt;dgm:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class LayoutNode : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LayoutNode class.
        /// </summary>
        public LayoutNode() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutNode class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LayoutNode(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutNode class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LayoutNode(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutNode class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LayoutNode(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Name</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        public StringValue Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Style Label</para>
        /// <para>Represents the following attribute in the schema: styleLbl</para>
        /// </summary>
        public StringValue StyleLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Child Order</para>
        /// <para>Represents the following attribute in the schema: chOrder</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ChildOrderValues> ChildOrder
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ChildOrderValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Move With</para>
        /// <para>Represents the following attribute in the schema: moveWith</para>
        /// </summary>
        public StringValue MoveWith
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "layoutNode");
            builder.AddChild<Algorithm>();
            builder.AddChild<Shape>();
            builder.AddChild<PresentationOf>();
            builder.AddChild<Constraints>();
            builder.AddChild<RuleList>();
            builder.AddChild<VariableList>();
            builder.AddChild<ForEach>();
            builder.AddChild<LayoutNode>();
            builder.AddChild<Choose>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<LayoutNode>()
.AddAttribute(0, "name", a => a.Name)
.AddAttribute(0, "styleLbl", a => a.StyleLabel)
.AddAttribute(0, "chOrder", a => a.ChildOrder, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "moveWith", a => a.MoveWith);
            builder.Particle = new CompositeParticle(ParticleType.Choice, 0, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Shape), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Constraints), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.RuleList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.VariableList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ForEach), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Choose), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
            builder.AddConstraint(new UniqueAttributeValueConstraint(0 /*:name*/, true, null));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LayoutNode>(deep);
    }

    /// <summary>
    /// <para>Choose Element.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:choose.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DiagramChooseIf &lt;dgm:if></description></item>
    ///   <item><description>DiagramChooseElse &lt;dgm:else></description></item>
    /// </list>
    /// </remark>
    public partial class Choose : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Choose class.
        /// </summary>
        public Choose() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Choose class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Choose(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Choose class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Choose(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Choose class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Choose(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Name</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        public StringValue Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "choose");
            builder.AddChild<DiagramChooseIf>();
            builder.AddChild<DiagramChooseElse>();
            builder.AddElement<Choose>()
.AddAttribute(0, "name", a => a.Name);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf), 1, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse), 0, 1)
            };
            builder.AddConstraint(new UniqueAttributeValueConstraint(0 /*:name*/, true, null));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Choose>(deep);
    }

    /// <summary>
    /// <para>If.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:if.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Algorithm &lt;dgm:alg></description></item>
    ///   <item><description>Shape &lt;dgm:shape></description></item>
    ///   <item><description>PresentationOf &lt;dgm:presOf></description></item>
    ///   <item><description>Constraints &lt;dgm:constrLst></description></item>
    ///   <item><description>RuleList &lt;dgm:ruleLst></description></item>
    ///   <item><description>ForEach &lt;dgm:forEach></description></item>
    ///   <item><description>LayoutNode &lt;dgm:layoutNode></description></item>
    ///   <item><description>Choose &lt;dgm:choose></description></item>
    ///   <item><description>ExtensionList &lt;dgm:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class DiagramChooseIf : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DiagramChooseIf class.
        /// </summary>
        public DiagramChooseIf() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DiagramChooseIf class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DiagramChooseIf(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DiagramChooseIf class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DiagramChooseIf(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DiagramChooseIf class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DiagramChooseIf(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Name</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        public StringValue Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Axis</para>
        /// <para>Represents the following attribute in the schema: axis</para>
        /// </summary>
        public ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AxisValues>> Axis
        {
            get => GetAttribute<ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AxisValues>>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Data Point Type</para>
        /// <para>Represents the following attribute in the schema: ptType</para>
        /// </summary>
        public ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>> PointType
        {
            get => GetAttribute<ListValue<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hide Last Transition</para>
        /// <para>Represents the following attribute in the schema: hideLastTrans</para>
        /// </summary>
        public ListValue<BooleanValue> HideLastTrans
        {
            get => GetAttribute<ListValue<BooleanValue>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Start</para>
        /// <para>Represents the following attribute in the schema: st</para>
        /// </summary>
        public ListValue<Int32Value> Start
        {
            get => GetAttribute<ListValue<Int32Value>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Count</para>
        /// <para>Represents the following attribute in the schema: cnt</para>
        /// </summary>
        public ListValue<UInt32Value> Count
        {
            get => GetAttribute<ListValue<UInt32Value>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Step</para>
        /// <para>Represents the following attribute in the schema: step</para>
        /// </summary>
        public ListValue<Int32Value> Step
        {
            get => GetAttribute<ListValue<Int32Value>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Function</para>
        /// <para>Represents the following attribute in the schema: func</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.FunctionValues> Function
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.FunctionValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Argument</para>
        /// <para>Represents the following attribute in the schema: arg</para>
        /// </summary>
        public StringValue Argument
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Operator</para>
        /// <para>Represents the following attribute in the schema: op</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.FunctionOperatorValues> Operator
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.FunctionOperatorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public StringValue Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "if");
            builder.AddChild<Algorithm>();
            builder.AddChild<Shape>();
            builder.AddChild<PresentationOf>();
            builder.AddChild<Constraints>();
            builder.AddChild<RuleList>();
            builder.AddChild<ForEach>();
            builder.AddChild<LayoutNode>();
            builder.AddChild<Choose>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<DiagramChooseIf>()
.AddAttribute(0, "name", a => a.Name)
.AddAttribute(0, "axis", a => a.Axis)
.AddAttribute(0, "ptType", a => a.PointType)
.AddAttribute(0, "hideLastTrans", a => a.HideLastTrans)
.AddAttribute(0, "st", a => a.Start)
.AddAttribute(0, "cnt", a => a.Count)
.AddAttribute(0, "step", a => a.Step)
.AddAttribute(0, "func", a => a.Function, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "arg", a => a.Argument, aBuilder =>
{
aBuilder.AddUnion(union =>
{
union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.VariableValues>>(EnumValidator.Instance);
});
})
.AddAttribute(0, "op", a => a.Operator, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddUnion(union =>
{
union.AddValidator<Int32Value>(NumberValidator.Instance);
union.AddValidator<BooleanValue>(NumberValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues>>(EnumValidator.Instance);
union.AddValidator<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues>>(EnumValidator.Instance);
});
});
            builder.Particle = new CompositeParticle(ParticleType.Choice, 0, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Shape), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Constraints), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.RuleList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ForEach), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Choose), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
            builder.AddConstraint(new UniqueAttributeValueConstraint(0 /*:name*/, true, null));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DiagramChooseIf>(deep);
    }

    /// <summary>
    /// <para>Else.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:else.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Algorithm &lt;dgm:alg></description></item>
    ///   <item><description>Shape &lt;dgm:shape></description></item>
    ///   <item><description>PresentationOf &lt;dgm:presOf></description></item>
    ///   <item><description>Constraints &lt;dgm:constrLst></description></item>
    ///   <item><description>RuleList &lt;dgm:ruleLst></description></item>
    ///   <item><description>ForEach &lt;dgm:forEach></description></item>
    ///   <item><description>LayoutNode &lt;dgm:layoutNode></description></item>
    ///   <item><description>Choose &lt;dgm:choose></description></item>
    ///   <item><description>ExtensionList &lt;dgm:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class DiagramChooseElse : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DiagramChooseElse class.
        /// </summary>
        public DiagramChooseElse() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DiagramChooseElse class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DiagramChooseElse(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DiagramChooseElse class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DiagramChooseElse(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DiagramChooseElse class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DiagramChooseElse(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Name</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        public StringValue Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "else");
            builder.AddChild<Algorithm>();
            builder.AddChild<Shape>();
            builder.AddChild<PresentationOf>();
            builder.AddChild<Constraints>();
            builder.AddChild<RuleList>();
            builder.AddChild<ForEach>();
            builder.AddChild<LayoutNode>();
            builder.AddChild<Choose>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<DiagramChooseElse>()
.AddAttribute(0, "name", a => a.Name);
            builder.Particle = new CompositeParticle(ParticleType.Choice, 0, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Shape), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Constraints), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.RuleList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ForEach), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Choose), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
            builder.AddConstraint(new UniqueAttributeValueConstraint(0 /*:name*/, true, null));
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DiagramChooseElse>(deep);
    }

    /// <summary>
    /// <para>Data Model.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:dataModel.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PointList &lt;dgm:ptLst></description></item>
    ///   <item><description>ConnectionList &lt;dgm:cxnLst></description></item>
    ///   <item><description>Background &lt;dgm:bg></description></item>
    ///   <item><description>Whole &lt;dgm:whole></description></item>
    ///   <item><description>DataModelExtensionList &lt;dgm:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class DataModel : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DataModel class.
        /// </summary>
        public DataModel() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataModel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataModel(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataModel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataModel(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataModel class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataModel(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "dataModel");
            builder.AddChild<PointList>();
            builder.AddChild<ConnectionList>();
            builder.AddChild<Background>();
            builder.AddChild<Whole>();
            builder.AddChild<DataModelExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.PointList), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Background), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Whole), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.DataModelExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Point List.</para>
        /// <para>Represents the following element tag in the schema: dgm:ptLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public PointList PointList
        {
            get => GetElement<PointList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Connection List.</para>
        /// <para>Represents the following element tag in the schema: dgm:cxnLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public ConnectionList ConnectionList
        {
            get => GetElement<ConnectionList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Background Formatting.</para>
        /// <para>Represents the following element tag in the schema: dgm:bg.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public Background Background
        {
            get => GetElement<Background>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Whole E2O Formatting.</para>
        /// <para>Represents the following element tag in the schema: dgm:whole.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public Whole Whole
        {
            get => GetElement<Whole>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataModelExtensionList.</para>
        /// <para>Represents the following element tag in the schema: dgm:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DataModelExtensionList DataModelExtensionList
        {
            get => GetElement<DataModelExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataModel>(deep);
    }

    /// <summary>
    /// <para>Category.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:cat.</para>
    /// </summary>
    public partial class Category : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Category class.
        /// </summary>
        public Category() : base()
        {
        }

        /// <summary>
        /// <para>Category Type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        public StringValue Type
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Priority</para>
        /// <para>Represents the following attribute in the schema: pri</para>
        /// </summary>
        public UInt32Value Priority
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "cat");
            builder.AddElement<Category>()
.AddAttribute(0, "type", a => a.Type, aBuilder =>
{
   aBuilder.AddValidator(RequiredValidator.Instance);
   aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
})
.AddAttribute(0, "pri", a => a.Priority, aBuilder =>
{
   aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Category>(deep);
    }

    /// <summary>
    /// <para>Title.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:title.</para>
    /// </summary>
    public partial class Title : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Title class.
        /// </summary>
        public Title() : base()
        {
        }

        /// <summary>
        /// <para>Language</para>
        /// <para>Represents the following attribute in the schema: lang</para>
        /// </summary>
        public StringValue Language
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public StringValue Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "title");
            builder.AddElement<Title>()
.AddAttribute(0, "lang", a => a.Language)
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
 aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Title>(deep);
    }

    /// <summary>
    /// <para>Description.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:desc.</para>
    /// </summary>
    public partial class Description : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Description class.
        /// </summary>
        public Description() : base()
        {
        }

        /// <summary>
        /// <para>Language</para>
        /// <para>Represents the following attribute in the schema: lang</para>
        /// </summary>
        public StringValue Language
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public StringValue Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "desc");
            builder.AddElement<Description>()
.AddAttribute(0, "lang", a => a.Language)
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
  aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Description>(deep);
    }

    /// <summary>
    /// <para>Category List.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:catLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Category &lt;dgm:cat></description></item>
    /// </list>
    /// </remark>
    public partial class CategoryList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CategoryList class.
        /// </summary>
        public CategoryList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CategoryList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CategoryList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CategoryList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CategoryList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CategoryList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CategoryList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "catLst");
            builder.AddChild<Category>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Category), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CategoryList>(deep);
    }

    /// <summary>
    /// <para>Sample Data.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:sampData.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DataModel &lt;dgm:dataModel></description></item>
    /// </list>
    /// </remark>
    public partial class SampleData : SampleDataType
    {
        /// <summary>
        /// Initializes a new instance of the SampleData class.
        /// </summary>
        public SampleData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SampleData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SampleData(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SampleData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SampleData(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SampleData class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SampleData(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "sampData");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.DataModel), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SampleData>(deep);
    }

    /// <summary>
    /// <para>Style Data.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:styleData.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DataModel &lt;dgm:dataModel></description></item>
    /// </list>
    /// </remark>
    public partial class StyleData : SampleDataType
    {
        /// <summary>
        /// Initializes a new instance of the StyleData class.
        /// </summary>
        public StyleData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StyleData(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StyleData(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleData class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StyleData(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "styleData");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.DataModel), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StyleData>(deep);
    }

    /// <summary>
    /// <para>Color Transform Sample Data.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:clrData.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DataModel &lt;dgm:dataModel></description></item>
    /// </list>
    /// </remark>
    public partial class ColorData : SampleDataType
    {
        /// <summary>
        /// Initializes a new instance of the ColorData class.
        /// </summary>
        public ColorData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorData(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorData(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorData class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ColorData(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "clrData");
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.DataModel), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorData>(deep);
    }

    /// <summary>
    /// <para>Defines the SampleDataType Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DataModel &lt;dgm:dataModel></description></item>
    /// </list>
    /// </remark>
    public abstract partial class SampleDataType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SampleDataType class.
        /// </summary>
        protected SampleDataType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SampleDataType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected SampleDataType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SampleDataType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected SampleDataType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SampleDataType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected SampleDataType(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Use Default</para>
        /// <para>Represents the following attribute in the schema: useDef</para>
        /// </summary>
        public BooleanValue UseDefault
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<DataModel>();
            builder.AddElement<SampleDataType>()
.AddAttribute(0, "useDef", a => a.UseDefault);
        }

        /// <summary>
        /// <para>Data Model.</para>
        /// <para>Represents the following element tag in the schema: dgm:dataModel.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public DataModel DataModel
        {
            get => GetElement<DataModel>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>Shape Style.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:style.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.LineReference &lt;a:lnRef></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.FillReference &lt;a:fillRef></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectReference &lt;a:effectRef></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.FontReference &lt;a:fontRef></description></item>
    /// </list>
    /// </remark>
    public partial class Style : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Style class.
        /// </summary>
        public Style() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Style class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Style(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Style class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Style(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Style class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Style(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "style");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.LineReference>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.FillReference>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectReference>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.FontReference>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.LineReference), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.FillReference), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectReference), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.FontReference), 1, 1)
            };
        }

        /// <summary>
        /// <para>LineReference.</para>
        /// <para>Represents the following element tag in the schema: a:lnRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.LineReference LineReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.LineReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>FillReference.</para>
        /// <para>Represents the following element tag in the schema: a:fillRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.FillReference FillReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.FillReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EffectReference.</para>
        /// <para>Represents the following element tag in the schema: a:effectRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.EffectReference EffectReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.EffectReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Font Reference.</para>
        /// <para>Represents the following element tag in the schema: a:fontRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.FontReference FontReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.FontReference>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Style>(deep);
    }

    /// <summary>
    /// <para>Show Organization Chart User Interface.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:orgChart.</para>
    /// </summary>
    public partial class OrganizationChart : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the OrganizationChart class.
        /// </summary>
        public OrganizationChart() : base()
        {
        }

        /// <summary>
        /// <para>Show Organization Chart User Interface Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public BooleanValue Val
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "orgChart");
            builder.AddElement<OrganizationChart>()
.AddAttribute(0, "val", a => a.Val);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OrganizationChart>(deep);
    }

    /// <summary>
    /// <para>Maximum Children.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:chMax.</para>
    /// </summary>
    public partial class MaxNumberOfChildren : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the MaxNumberOfChildren class.
        /// </summary>
        public MaxNumberOfChildren() : base()
        {
        }

        /// <summary>
        /// <para>Maximum Children Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public Int32Value Val
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "chMax");
            builder.AddElement<MaxNumberOfChildren>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
 aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-1L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MaxNumberOfChildren>(deep);
    }

    /// <summary>
    /// <para>Preferred Number of Children.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:chPref.</para>
    /// </summary>
    public partial class PreferredNumberOfChildren : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PreferredNumberOfChildren class.
        /// </summary>
        public PreferredNumberOfChildren() : base()
        {
        }

        /// <summary>
        /// <para>Preferred Number of CHildren Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public Int32Value Val
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "chPref");
            builder.AddElement<PreferredNumberOfChildren>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-1L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PreferredNumberOfChildren>(deep);
    }

    /// <summary>
    /// <para>Show Insert Bullet.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:bulletEnabled.</para>
    /// </summary>
    public partial class BulletEnabled : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BulletEnabled class.
        /// </summary>
        public BulletEnabled() : base()
        {
        }

        /// <summary>
        /// <para>Show Insert Bullet Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public BooleanValue Val
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "bulletEnabled");
            builder.AddElement<BulletEnabled>()
.AddAttribute(0, "val", a => a.Val);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BulletEnabled>(deep);
    }

    /// <summary>
    /// <para>Diagram Direction.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:dir.</para>
    /// </summary>
    public partial class Direction : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Direction class.
        /// </summary>
        public Direction() : base()
        {
        }

        /// <summary>
        /// <para>Diagram Direction Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "dir");
            builder.AddElement<Direction>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
   aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Direction>(deep);
    }

    /// <summary>
    /// <para>Organization Chart Branch Style.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:hierBranch.</para>
    /// </summary>
    public partial class HierarchyBranch : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the HierarchyBranch class.
        /// </summary>
        public HierarchyBranch() : base()
        {
        }

        /// <summary>
        /// <para>Organization Chart Branch Style Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "hierBranch");
            builder.AddElement<HierarchyBranch>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HierarchyBranch>(deep);
    }

    /// <summary>
    /// <para>One by One Animation String.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:animOne.</para>
    /// </summary>
    public partial class AnimateOneByOne : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the AnimateOneByOne class.
        /// </summary>
        public AnimateOneByOne() : base()
        {
        }

        /// <summary>
        /// <para>One By One Animation Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "animOne");
            builder.AddElement<AnimateOneByOne>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AnimateOneByOne>(deep);
    }

    /// <summary>
    /// <para>Level Animation.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:animLvl.</para>
    /// </summary>
    public partial class AnimationLevel : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the AnimationLevel class.
        /// </summary>
        public AnimationLevel() : base()
        {
        }

        /// <summary>
        /// <para>Level Animation Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "animLvl");
            builder.AddElement<AnimationLevel>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AnimationLevel>(deep);
    }

    /// <summary>
    /// <para>Shape Resize Style.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:resizeHandles.</para>
    /// </summary>
    public partial class ResizeHandles : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ResizeHandles class.
        /// </summary>
        public ResizeHandles() : base()
        {
        }

        /// <summary>
        /// <para>Shape Resize Style Type</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues> Val
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "resizeHandles");
            builder.AddElement<ResizeHandles>()
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ResizeHandles>(deep);
    }

    /// <summary>
    /// <para>Category.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:cat.</para>
    /// </summary>
    public partial class StyleDisplayCategory : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the StyleDisplayCategory class.
        /// </summary>
        public StyleDisplayCategory() : base()
        {
        }

        /// <summary>
        /// <para>Category Type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        public StringValue Type
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Priority</para>
        /// <para>Represents the following attribute in the schema: pri</para>
        /// </summary>
        public UInt32Value Priority
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "cat");
            builder.AddElement<StyleDisplayCategory>()
.AddAttribute(0, "type", a => a.Type, aBuilder =>
{
   aBuilder.AddValidator(RequiredValidator.Instance);
   aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
})
.AddAttribute(0, "pri", a => a.Priority, aBuilder =>
{
   aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StyleDisplayCategory>(deep);
    }

    /// <summary>
    /// <para>3-D Scene.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:scene3d.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Camera &lt;a:camera></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.LightRig &lt;a:lightRig></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Backdrop &lt;a:backdrop></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class Scene3D : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Scene3D class.
        /// </summary>
        public Scene3D() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Scene3D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Scene3D(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Scene3D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Scene3D(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Scene3D class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Scene3D(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "scene3d");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Camera>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.LightRig>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Backdrop>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Camera), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.LightRig), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Backdrop), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Camera.</para>
        /// <para>Represents the following element tag in the schema: a:camera.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Camera Camera
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Camera>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Light Rig.</para>
        /// <para>Represents the following element tag in the schema: a:lightRig.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.LightRig LightRig
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.LightRig>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Backdrop Plane.</para>
        /// <para>Represents the following element tag in the schema: a:backdrop.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Backdrop Backdrop
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Backdrop>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ExtensionList ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Scene3D>(deep);
    }

    /// <summary>
    /// <para>3-D Shape Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:sp3d.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BevelTop &lt;a:bevelT></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BevelBottom &lt;a:bevelB></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ExtrusionColor &lt;a:extrusionClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ContourColor &lt;a:contourClr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class Shape3D : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Shape3D class.
        /// </summary>
        public Shape3D() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shape3D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Shape3D(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shape3D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Shape3D(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shape3D class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Shape3D(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Shape Depth</para>
        /// <para>Represents the following attribute in the schema: z</para>
        /// </summary>
        public Int64Value Z
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Extrusion Height</para>
        /// <para>Represents the following attribute in the schema: extrusionH</para>
        /// </summary>
        public Int64Value ExtrusionHeight
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Contour Width</para>
        /// <para>Represents the following attribute in the schema: contourW</para>
        /// </summary>
        public Int64Value ContourWidth
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Preset Material Type</para>
        /// <para>Represents the following attribute in the schema: prstMaterial</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues> PresetMaterial
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "sp3d");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BevelTop>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BevelBottom>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtrusionColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ContourColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.AddElement<Shape3D>()
.AddAttribute(0, "z", a => a.Z, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
})
.AddAttribute(0, "extrusionH", a => a.ExtrusionHeight, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
})
.AddAttribute(0, "contourW", a => a.ContourWidth, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
})
.AddAttribute(0, "prstMaterial", a => a.PresetMaterial, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BevelTop), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BevelBottom), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtrusionColor), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ContourColor), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Top Bevel.</para>
        /// <para>Represents the following element tag in the schema: a:bevelT.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.BevelTop BevelTop
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.BevelTop>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Bottom Bevel.</para>
        /// <para>Represents the following element tag in the schema: a:bevelB.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.BevelBottom BevelBottom
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.BevelBottom>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Extrusion Color.</para>
        /// <para>Represents the following element tag in the schema: a:extrusionClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ExtrusionColor ExtrusionColor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ExtrusionColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Contour Color.</para>
        /// <para>Represents the following element tag in the schema: a:contourClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ContourColor ContourColor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ContourColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ExtensionList ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Shape3D>(deep);
    }

    /// <summary>
    /// <para>Text Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:txPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Shape3DType &lt;a:sp3d></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.FlatText &lt;a:flatTx></description></item>
    /// </list>
    /// </remark>
    public partial class TextProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextProperties class.
        /// </summary>
        public TextProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "txPr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Shape3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.FlatText>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Shape3DType), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.FlatText), 1, 1)
                    }
                }
            };
        }

        /// <summary>
        /// <para>Apply 3D shape properties.</para>
        /// <para>Represents the following element tag in the schema: a:sp3d.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Shape3DType Shape3DType
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Shape3DType>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>No text in 3D scene.</para>
        /// <para>Represents the following element tag in the schema: a:flatTx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.FlatText FlatText
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.FlatText>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextProperties>(deep);
    }

    /// <summary>
    /// <para>Title.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:title.</para>
    /// </summary>
    public partial class StyleDefinitionTitle : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the StyleDefinitionTitle class.
        /// </summary>
        public StyleDefinitionTitle() : base()
        {
        }

        /// <summary>
        /// <para>Natural Language</para>
        /// <para>Represents the following attribute in the schema: lang</para>
        /// </summary>
        public StringValue Language
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Description Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public StringValue Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "title");
            builder.AddElement<StyleDefinitionTitle>()
.AddAttribute(0, "lang", a => a.Language)
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
 aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StyleDefinitionTitle>(deep);
    }

    /// <summary>
    /// <para>Style Label Description.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:desc.</para>
    /// </summary>
    public partial class StyleLabelDescription : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the StyleLabelDescription class.
        /// </summary>
        public StyleLabelDescription() : base()
        {
        }

        /// <summary>
        /// <para>Natural Language</para>
        /// <para>Represents the following attribute in the schema: lang</para>
        /// </summary>
        public StringValue Language
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Description Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        public StringValue Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "desc");
            builder.AddElement<StyleLabelDescription>()
.AddAttribute(0, "lang", a => a.Language)
.AddAttribute(0, "val", a => a.Val, aBuilder =>
{
  aBuilder.AddValidator(RequiredValidator.Instance);
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StyleLabelDescription>(deep);
    }

    /// <summary>
    /// <para>Category List.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:catLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>StyleDisplayCategory &lt;dgm:cat></description></item>
    /// </list>
    /// </remark>
    public partial class StyleDisplayCategories : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StyleDisplayCategories class.
        /// </summary>
        public StyleDisplayCategories() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleDisplayCategories class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StyleDisplayCategories(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleDisplayCategories class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StyleDisplayCategories(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleDisplayCategories class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StyleDisplayCategories(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "catLst");
            builder.AddChild<StyleDisplayCategory>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 0, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategory), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StyleDisplayCategories>(deep);
    }

    /// <summary>
    /// <para>Style Label.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:styleLbl.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Scene3D &lt;dgm:scene3d></description></item>
    ///   <item><description>Shape3D &lt;dgm:sp3d></description></item>
    ///   <item><description>TextProperties &lt;dgm:txPr></description></item>
    ///   <item><description>Style &lt;dgm:style></description></item>
    ///   <item><description>ExtensionList &lt;dgm:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class StyleLabel : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StyleLabel class.
        /// </summary>
        public StyleLabel() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleLabel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StyleLabel(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleLabel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StyleLabel(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StyleLabel class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StyleLabel(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Style Name</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        public StringValue Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "styleLbl");
            builder.AddChild<Scene3D>();
            builder.AddChild<Shape3D>();
            builder.AddChild<TextProperties>();
            builder.AddChild<Style>();
            builder.AddChild<ExtensionList>();
            builder.AddElement<StyleLabel>()
.AddAttribute(0, "name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Scene3D), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.TextProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Style), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>3-D Scene.</para>
        /// <para>Represents the following element tag in the schema: dgm:scene3d.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public Scene3D Scene3D
        {
            get => GetElement<Scene3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>3-D Shape Properties.</para>
        /// <para>Represents the following element tag in the schema: dgm:sp3d.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public Shape3D Shape3D
        {
            get => GetElement<Shape3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Text Properties.</para>
        /// <para>Represents the following element tag in the schema: dgm:txPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public TextProperties TextProperties
        {
            get => GetElement<TextProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Shape Style.</para>
        /// <para>Represents the following element tag in the schema: dgm:style.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public Style Style
        {
            get => GetElement<Style>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: dgm:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public ExtensionList ExtensionList
        {
            get => GetElement<ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StyleLabel>(deep);
    }

    /// <summary>
    /// <para>Point List.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:ptLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Point &lt;dgm:pt></description></item>
    /// </list>
    /// </remark>
    public partial class PointList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PointList class.
        /// </summary>
        public PointList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PointList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PointList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PointList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PointList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PointList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PointList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "ptLst");
            builder.AddChild<Point>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Point), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PointList>(deep);
    }

    /// <summary>
    /// <para>Connection List.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:cxnLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>Connection &lt;dgm:cxn></description></item>
    /// </list>
    /// </remark>
    public partial class ConnectionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ConnectionList class.
        /// </summary>
        public ConnectionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ConnectionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ConnectionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ConnectionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "cxnLst");
            builder.AddChild<Connection>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Connection), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConnectionList>(deep);
    }

    /// <summary>
    /// <para>Background Formatting.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:bg.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.NoFill &lt;a:noFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SolidFill &lt;a:solidFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.GradientFill &lt;a:gradFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BlipFill &lt;a:blipFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PatternFill &lt;a:pattFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.GroupFill &lt;a:grpFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectList &lt;a:effectLst></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectDag &lt;a:effectDag></description></item>
    /// </list>
    /// </remark>
    public partial class Background : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Background class.
        /// </summary>
        public Background() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Background class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Background(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Background class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Background(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Background class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Background(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "bg");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NoFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GroupFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NoFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SolidFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GradientFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BlipFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PatternFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GroupFill), 1, 1)
                    }
                },
                new CompositeParticle(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectList), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectDag), 1, 1)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Background>(deep);
    }

    /// <summary>
    /// <para>Whole E2O Formatting.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:whole.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Outline &lt;a:ln></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectList &lt;a:effectLst></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectDag &lt;a:effectDag></description></item>
    /// </list>
    /// </remark>
    public partial class Whole : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Whole class.
        /// </summary>
        public Whole() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Whole class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Whole(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Whole class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Whole(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Whole class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Whole(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "whole");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Outline>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Outline), 0, 1),
                new CompositeParticle(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectList), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectDag), 1, 1)
                    }
                }
            };
        }

        /// <summary>
        /// <para>Outline.</para>
        /// <para>Represents the following element tag in the schema: a:ln.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Outline Outline
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Outline>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Whole>(deep);
    }

    /// <summary>
    /// <para>Defines the DataModelExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.DataModelExtension &lt;a:ext></description></item>
    /// </list>
    /// </remark>
    public partial class DataModelExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DataModelExtensionList class.
        /// </summary>
        public DataModelExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataModelExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataModelExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataModelExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataModelExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataModelExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataModelExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "extLst");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.DataModelExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.DataModelExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataModelExtensionList>(deep);
    }

    /// <summary>
    /// <para>Property Set.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:prSet.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>PresentationLayoutVariables &lt;dgm:presLayoutVars></description></item>
    ///   <item><description>Style &lt;dgm:style></description></item>
    /// </list>
    /// </remark>
    public partial class PropertySet : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PropertySet class.
        /// </summary>
        public PropertySet() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PropertySet class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PropertySet(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PropertySet class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PropertySet(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PropertySet class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PropertySet(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Presentation Element Identifier</para>
        /// <para>Represents the following attribute in the schema: presAssocID</para>
        /// </summary>
        public StringValue PresentationElementId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Presentation Name</para>
        /// <para>Represents the following attribute in the schema: presName</para>
        /// </summary>
        public StringValue PresentationName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Presentation Style Label</para>
        /// <para>Represents the following attribute in the schema: presStyleLbl</para>
        /// </summary>
        public StringValue PresentationStyleLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Presentation Style Index</para>
        /// <para>Represents the following attribute in the schema: presStyleIdx</para>
        /// </summary>
        public Int32Value PresentationStyleIndex
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Presentation Style Count</para>
        /// <para>Represents the following attribute in the schema: presStyleCnt</para>
        /// </summary>
        public Int32Value PresentationStyleCount
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Current Diagram Type</para>
        /// <para>Represents the following attribute in the schema: loTypeId</para>
        /// </summary>
        public StringValue LayoutTypeId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Current Diagram Category</para>
        /// <para>Represents the following attribute in the schema: loCatId</para>
        /// </summary>
        public StringValue LayoutCategoryId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Current Style Type</para>
        /// <para>Represents the following attribute in the schema: qsTypeId</para>
        /// </summary>
        public StringValue QuickStyleTypeId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Current Style Category</para>
        /// <para>Represents the following attribute in the schema: qsCatId</para>
        /// </summary>
        public StringValue QuickStyleCategoryId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Color Transform Type Identifier</para>
        /// <para>Represents the following attribute in the schema: csTypeId</para>
        /// </summary>
        public StringValue ColorType
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Color Transform Category</para>
        /// <para>Represents the following attribute in the schema: csCatId</para>
        /// </summary>
        public StringValue ColorCategoryId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Coherent 3D Behavior</para>
        /// <para>Represents the following attribute in the schema: coherent3DOff</para>
        /// </summary>
        public BooleanValue Coherent3D
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Placeholder Text</para>
        /// <para>Represents the following attribute in the schema: phldrT</para>
        /// </summary>
        public StringValue PlaceholderText
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Placeholder</para>
        /// <para>Represents the following attribute in the schema: phldr</para>
        /// </summary>
        public BooleanValue Placeholder
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Custom Rotation</para>
        /// <para>Represents the following attribute in the schema: custAng</para>
        /// </summary>
        public Int32Value Rotation
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Custom Vertical Flip</para>
        /// <para>Represents the following attribute in the schema: custFlipVert</para>
        /// </summary>
        public BooleanValue VerticalFlip
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Custom Horizontal Flip</para>
        /// <para>Represents the following attribute in the schema: custFlipHor</para>
        /// </summary>
        public BooleanValue HorizontalFlip
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fixed Width Override</para>
        /// <para>Represents the following attribute in the schema: custSzX</para>
        /// </summary>
        public Int32Value FixedWidthOverride
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fixed Height Override</para>
        /// <para>Represents the following attribute in the schema: custSzY</para>
        /// </summary>
        public Int32Value FixedHeightOverride
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Width Scale</para>
        /// <para>Represents the following attribute in the schema: custScaleX</para>
        /// </summary>
        public Int32Value WidthScale
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Height Scale</para>
        /// <para>Represents the following attribute in the schema: custScaleY</para>
        /// </summary>
        public Int32Value HightScale
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Changed</para>
        /// <para>Represents the following attribute in the schema: custT</para>
        /// </summary>
        public BooleanValue TextChanged
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Custom Factor Width</para>
        /// <para>Represents the following attribute in the schema: custLinFactX</para>
        /// </summary>
        public Int32Value FactorWidth
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Custom Factor Height</para>
        /// <para>Represents the following attribute in the schema: custLinFactY</para>
        /// </summary>
        public Int32Value FactorHeight
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Neighbor Offset Width</para>
        /// <para>Represents the following attribute in the schema: custLinFactNeighborX</para>
        /// </summary>
        public Int32Value NeighborOffsetWidth
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Neighbor Offset Height</para>
        /// <para>Represents the following attribute in the schema: custLinFactNeighborY</para>
        /// </summary>
        public Int32Value NeighborOffsetHeight
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Radius Scale</para>
        /// <para>Represents the following attribute in the schema: custRadScaleRad</para>
        /// </summary>
        public Int32Value RadiusScale
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Include Angle Scale</para>
        /// <para>Represents the following attribute in the schema: custRadScaleInc</para>
        /// </summary>
        public Int32Value IncludeAngleScale
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "prSet");
            builder.AddChild<PresentationLayoutVariables>();
            builder.AddChild<Style>();
            builder.AddElement<PropertySet>()
.AddAttribute(0, "presAssocID", a => a.PresentationElementId, aBuilder =>
{
aBuilder.AddUnion(union =>
{
union.AddValidator<Int32Value>(NumberValidator.Instance);
union.AddValidator(new StringValidator() { Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
});
})
.AddAttribute(0, "presName", a => a.PresentationName)
.AddAttribute(0, "presStyleLbl", a => a.PresentationStyleLabel)
.AddAttribute(0, "presStyleIdx", a => a.PresentationStyleIndex)
.AddAttribute(0, "presStyleCnt", a => a.PresentationStyleCount)
.AddAttribute(0, "loTypeId", a => a.LayoutTypeId)
.AddAttribute(0, "loCatId", a => a.LayoutCategoryId)
.AddAttribute(0, "qsTypeId", a => a.QuickStyleTypeId)
.AddAttribute(0, "qsCatId", a => a.QuickStyleCategoryId)
.AddAttribute(0, "csTypeId", a => a.ColorType)
.AddAttribute(0, "csCatId", a => a.ColorCategoryId)
.AddAttribute(0, "coherent3DOff", a => a.Coherent3D)
.AddAttribute(0, "phldrT", a => a.PlaceholderText)
.AddAttribute(0, "phldr", a => a.Placeholder)
.AddAttribute(0, "custAng", a => a.Rotation)
.AddAttribute(0, "custFlipVert", a => a.VerticalFlip)
.AddAttribute(0, "custFlipHor", a => a.HorizontalFlip)
.AddAttribute(0, "custSzX", a => a.FixedWidthOverride)
.AddAttribute(0, "custSzY", a => a.FixedHeightOverride)
.AddAttribute(0, "custScaleX", a => a.WidthScale)
.AddAttribute(0, "custScaleY", a => a.HightScale)
.AddAttribute(0, "custT", a => a.TextChanged)
.AddAttribute(0, "custLinFactX", a => a.FactorWidth)
.AddAttribute(0, "custLinFactY", a => a.FactorHeight)
.AddAttribute(0, "custLinFactNeighborX", a => a.NeighborOffsetWidth)
.AddAttribute(0, "custLinFactNeighborY", a => a.NeighborOffsetHeight)
.AddAttribute(0, "custRadScaleRad", a => a.RadiusScale)
.AddAttribute(0, "custRadScaleInc", a => a.IncludeAngleScale);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationLayoutVariables), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Diagrams.Style), 0, 1)
            };
        }

        /// <summary>
        /// <para>Presentation Layout Variables.</para>
        /// <para>Represents the following element tag in the schema: dgm:presLayoutVars.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public PresentationLayoutVariables PresentationLayoutVariables
        {
            get => GetElement<PresentationLayoutVariables>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Shape Style.</para>
        /// <para>Represents the following element tag in the schema: dgm:style.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm = http://schemas.openxmlformats.org/drawingml/2006/diagram
        /// </remark>
        public Style Style
        {
            get => GetElement<Style>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PropertySet>(deep);
    }

    /// <summary>
    /// <para>Shape Properties.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:spPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Transform2D &lt;a:xfrm></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.CustomGeometry &lt;a:custGeom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PresetGeometry &lt;a:prstGeom></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.NoFill &lt;a:noFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.SolidFill &lt;a:solidFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.GradientFill &lt;a:gradFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BlipFill &lt;a:blipFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PatternFill &lt;a:pattFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.GroupFill &lt;a:grpFill></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Outline &lt;a:ln></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectList &lt;a:effectLst></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.EffectDag &lt;a:effectDag></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Scene3DType &lt;a:scene3d></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Shape3DType &lt;a:sp3d></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList &lt;a:extLst></description></item>
    /// </list>
    /// </remark>
    public partial class ShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ShapeProperties class.
        /// </summary>
        public ShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ShapeProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Black and White Mode</para>
        /// <para>Represents the following attribute in the schema: bwMode</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "spPr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Transform2D>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.CustomGeometry>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PresetGeometry>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NoFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GroupFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Outline>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Scene3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Shape3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList>();
            builder.AddElement<ShapeProperties>()
.AddAttribute(0, "bwMode", a => a.BlackWhiteMode, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Transform2D), 0, 1),
                new CompositeParticle(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.CustomGeometry), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetGeometry), 1, 1)
                    }
                },
                new CompositeParticle(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NoFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SolidFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GradientFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BlipFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PatternFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GroupFill), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Outline), 0, 1),
                new CompositeParticle(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectList), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectDag), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Shape3DType), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>2D Transform for Individual Objects.</para>
        /// <para>Represents the following element tag in the schema: a:xfrm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Transform2D Transform2D
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Transform2D>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Text Body.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:t.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.BodyProperties &lt;a:bodyPr></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.ListStyle &lt;a:lstStyle></description></item>
    ///   <item><description>DocumentFormat.OpenXml.Drawing.Paragraph &lt;a:p></description></item>
    /// </list>
    /// </remark>
    public partial class TextBody : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextBody class.
        /// </summary>
        public TextBody() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBody class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBody(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBody class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBody(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBody class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextBody(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "t");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BodyProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ListStyle>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Paragraph>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BodyProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ListStyle), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Paragraph), 1, 0)
            };
        }

        /// <summary>
        /// <para>Body Properties.</para>
        /// <para>Represents the following element tag in the schema: a:bodyPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.BodyProperties BodyProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.BodyProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Text List Styles.</para>
        /// <para>Represents the following element tag in the schema: a:lstStyle.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ListStyle ListStyle
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ListStyle>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextBody>(deep);
    }

    /// <summary>
    /// <para>Defines the PtExtensionList Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>DocumentFormat.OpenXml.Drawing.PtExtension &lt;a:ext></description></item>
    /// </list>
    /// </remark>
    public partial class PtExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PtExtensionList class.
        /// </summary>
        public PtExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PtExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PtExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PtExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PtExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PtExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PtExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(14, "extLst");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PtExtension>();
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PtExtension), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PtExtensionList>(deep);
    }

    /// <summary>
    /// Color Application Method Type
    /// </summary>
    public enum ColorApplicationMethodValues
    {
        ///<summary>
        ///Span.
        ///<para>When the item is serialized out as xml, its value is "span".</para>
        ///</summary>
        [EnumString("span")]
        Span,
        ///<summary>
        ///Cycle.
        ///<para>When the item is serialized out as xml, its value is "cycle".</para>
        ///</summary>
        [EnumString("cycle")]
        Cycle,
        ///<summary>
        ///Repeat.
        ///<para>When the item is serialized out as xml, its value is "repeat".</para>
        ///</summary>
        [EnumString("repeat")]
        Repeat,
    }

    /// <summary>
    /// Hue Direction
    /// </summary>
    public enum HueDirectionValues
    {
        ///<summary>
        ///Clockwise Hue Direction.
        ///<para>When the item is serialized out as xml, its value is "cw".</para>
        ///</summary>
        [EnumString("cw")]
        Clockwise,
        ///<summary>
        ///Counterclockwise Hue Direction.
        ///<para>When the item is serialized out as xml, its value is "ccw".</para>
        ///</summary>
        [EnumString("ccw")]
        Counterclockwise,
    }

    /// <summary>
    /// Point Type
    /// </summary>
    public enum PointValues
    {
        ///<summary>
        ///Node.
        ///<para>When the item is serialized out as xml, its value is "node".</para>
        ///</summary>
        [EnumString("node")]
        Node,
        ///<summary>
        ///Assistant Element.
        ///<para>When the item is serialized out as xml, its value is "asst".</para>
        ///</summary>
        [EnumString("asst")]
        Assistant,
        ///<summary>
        ///Document.
        ///<para>When the item is serialized out as xml, its value is "doc".</para>
        ///</summary>
        [EnumString("doc")]
        Document,
        ///<summary>
        ///Presentation.
        ///<para>When the item is serialized out as xml, its value is "pres".</para>
        ///</summary>
        [EnumString("pres")]
        Presentation,
        ///<summary>
        ///Parent Transition.
        ///<para>When the item is serialized out as xml, its value is "parTrans".</para>
        ///</summary>
        [EnumString("parTrans")]
        ParentTransition,
        ///<summary>
        ///Sibling Transition.
        ///<para>When the item is serialized out as xml, its value is "sibTrans".</para>
        ///</summary>
        [EnumString("sibTrans")]
        SiblingTransition,
    }

    /// <summary>
    /// Connection Type
    /// </summary>
    public enum ConnectionValues
    {
        ///<summary>
        ///Parent Of.
        ///<para>When the item is serialized out as xml, its value is "parOf".</para>
        ///</summary>
        [EnumString("parOf")]
        ParentOf,
        ///<summary>
        ///Presentation Of.
        ///<para>When the item is serialized out as xml, its value is "presOf".</para>
        ///</summary>
        [EnumString("presOf")]
        PresentationOf,
        ///<summary>
        ///Presentation Parent Of.
        ///<para>When the item is serialized out as xml, its value is "presParOf".</para>
        ///</summary>
        [EnumString("presParOf")]
        PresentationParentOf,
        ///<summary>
        ///Unknown Relationship.
        ///<para>When the item is serialized out as xml, its value is "unknownRelationship".</para>
        ///</summary>
        [EnumString("unknownRelationship")]
        UnknownRelationship,
    }

    /// <summary>
    /// Diagram Direction Definition
    /// </summary>
    public enum DirectionValues
    {
        ///<summary>
        ///Normal Direction.
        ///<para>When the item is serialized out as xml, its value is "norm".</para>
        ///</summary>
        [EnumString("norm")]
        Normal,
        ///<summary>
        ///Reversed Direction.
        ///<para>When the item is serialized out as xml, its value is "rev".</para>
        ///</summary>
        [EnumString("rev")]
        Reversed,
    }

    /// <summary>
    /// Hierarchy Branch Style Definition
    /// </summary>
    public enum HierarchyBranchStyleValues
    {
        ///<summary>
        ///Left.
        ///<para>When the item is serialized out as xml, its value is "l".</para>
        ///</summary>
        [EnumString("l")]
        Left,
        ///<summary>
        ///Right.
        ///<para>When the item is serialized out as xml, its value is "r".</para>
        ///</summary>
        [EnumString("r")]
        Right,
        ///<summary>
        ///Hanging.
        ///<para>When the item is serialized out as xml, its value is "hang".</para>
        ///</summary>
        [EnumString("hang")]
        Hanging,
        ///<summary>
        ///Standard.
        ///<para>When the item is serialized out as xml, its value is "std".</para>
        ///</summary>
        [EnumString("std")]
        Standard,
        ///<summary>
        ///Initial.
        ///<para>When the item is serialized out as xml, its value is "init".</para>
        ///</summary>
        [EnumString("init")]
        Initial,
    }

    /// <summary>
    /// One by One Animation Value Definition
    /// </summary>
    public enum AnimateOneByOneValues
    {
        ///<summary>
        ///Disable One-by-One.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
        ///<summary>
        ///One By One.
        ///<para>When the item is serialized out as xml, its value is "one".</para>
        ///</summary>
        [EnumString("one")]
        One,
        ///<summary>
        ///By Branch One By One.
        ///<para>When the item is serialized out as xml, its value is "branch".</para>
        ///</summary>
        [EnumString("branch")]
        Branch,
    }

    /// <summary>
    /// Animation Level String Definition
    /// </summary>
    public enum AnimationLevelStringValues
    {
        ///<summary>
        ///Disable Level At Once.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
        ///<summary>
        ///By Level Animation.
        ///<para>When the item is serialized out as xml, its value is "lvl".</para>
        ///</summary>
        [EnumString("lvl")]
        Level,
        ///<summary>
        ///From Center Animation.
        ///<para>When the item is serialized out as xml, its value is "ctr".</para>
        ///</summary>
        [EnumString("ctr")]
        Center,
    }

    /// <summary>
    /// Resize Handle
    /// </summary>
    public enum ResizeHandlesStringValues
    {
        ///<summary>
        ///Exact.
        ///<para>When the item is serialized out as xml, its value is "exact".</para>
        ///</summary>
        [EnumString("exact")]
        Exact,
        ///<summary>
        ///Relative.
        ///<para>When the item is serialized out as xml, its value is "rel".</para>
        ///</summary>
        [EnumString("rel")]
        Relative,
    }

    /// <summary>
    /// Algorithm Types
    /// </summary>
    public enum AlgorithmValues
    {
        ///<summary>
        ///Composite.
        ///<para>When the item is serialized out as xml, its value is "composite".</para>
        ///</summary>
        [EnumString("composite")]
        Composite,
        ///<summary>
        ///Connector Algorithm.
        ///<para>When the item is serialized out as xml, its value is "conn".</para>
        ///</summary>
        [EnumString("conn")]
        Connector,
        ///<summary>
        ///Cycle Algorithm.
        ///<para>When the item is serialized out as xml, its value is "cycle".</para>
        ///</summary>
        [EnumString("cycle")]
        Cycle,
        ///<summary>
        ///Hierarchy Child Algorithm.
        ///<para>When the item is serialized out as xml, its value is "hierChild".</para>
        ///</summary>
        [EnumString("hierChild")]
        HierarchyChild,
        ///<summary>
        ///Hierarchy Root Algorithm.
        ///<para>When the item is serialized out as xml, its value is "hierRoot".</para>
        ///</summary>
        [EnumString("hierRoot")]
        HierarchyRoot,
        ///<summary>
        ///Pyramid Algorithm.
        ///<para>When the item is serialized out as xml, its value is "pyra".</para>
        ///</summary>
        [EnumString("pyra")]
        Pyramid,
        ///<summary>
        ///Linear Algorithm.
        ///<para>When the item is serialized out as xml, its value is "lin".</para>
        ///</summary>
        [EnumString("lin")]
        Linear,
        ///<summary>
        ///Space Algorithm.
        ///<para>When the item is serialized out as xml, its value is "sp".</para>
        ///</summary>
        [EnumString("sp")]
        Space,
        ///<summary>
        ///Text Algorithm.
        ///<para>When the item is serialized out as xml, its value is "tx".</para>
        ///</summary>
        [EnumString("tx")]
        Text,
        ///<summary>
        ///Snake Algorithm.
        ///<para>When the item is serialized out as xml, its value is "snake".</para>
        ///</summary>
        [EnumString("snake")]
        Snake,
    }

    /// <summary>
    /// Axis Type
    /// </summary>
    public enum AxisValues
    {
        ///<summary>
        ///Self.
        ///<para>When the item is serialized out as xml, its value is "self".</para>
        ///</summary>
        [EnumString("self")]
        Self,
        ///<summary>
        ///Child.
        ///<para>When the item is serialized out as xml, its value is "ch".</para>
        ///</summary>
        [EnumString("ch")]
        Child,
        ///<summary>
        ///Descendant.
        ///<para>When the item is serialized out as xml, its value is "des".</para>
        ///</summary>
        [EnumString("des")]
        Descendant,
        ///<summary>
        ///Descendant or Self.
        ///<para>When the item is serialized out as xml, its value is "desOrSelf".</para>
        ///</summary>
        [EnumString("desOrSelf")]
        DescendantOrSelf,
        ///<summary>
        ///Parent.
        ///<para>When the item is serialized out as xml, its value is "par".</para>
        ///</summary>
        [EnumString("par")]
        Parent,
        ///<summary>
        ///Ancestor.
        ///<para>When the item is serialized out as xml, its value is "ancst".</para>
        ///</summary>
        [EnumString("ancst")]
        Ancestor,
        ///<summary>
        ///Ancestor or Self.
        ///<para>When the item is serialized out as xml, its value is "ancstOrSelf".</para>
        ///</summary>
        [EnumString("ancstOrSelf")]
        AncestorOrSelf,
        ///<summary>
        ///Follow Sibling.
        ///<para>When the item is serialized out as xml, its value is "followSib".</para>
        ///</summary>
        [EnumString("followSib")]
        FollowSibling,
        ///<summary>
        ///Preceding Sibling.
        ///<para>When the item is serialized out as xml, its value is "precedSib".</para>
        ///</summary>
        [EnumString("precedSib")]
        PrecedingSibling,
        ///<summary>
        ///Follow.
        ///<para>When the item is serialized out as xml, its value is "follow".</para>
        ///</summary>
        [EnumString("follow")]
        Follow,
        ///<summary>
        ///Preceding.
        ///<para>When the item is serialized out as xml, its value is "preced".</para>
        ///</summary>
        [EnumString("preced")]
        Preceding,
        ///<summary>
        ///Root.
        ///<para>When the item is serialized out as xml, its value is "root".</para>
        ///</summary>
        [EnumString("root")]
        Root,
        ///<summary>
        ///None.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
    }

    /// <summary>
    /// Boolean Constraint
    /// </summary>
    public enum BoolOperatorValues
    {
        ///<summary>
        ///None.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
        ///<summary>
        ///Equal.
        ///<para>When the item is serialized out as xml, its value is "equ".</para>
        ///</summary>
        [EnumString("equ")]
        Equal,
        ///<summary>
        ///Greater Than or Equal to.
        ///<para>When the item is serialized out as xml, its value is "gte".</para>
        ///</summary>
        [EnumString("gte")]
        GreaterThanOrEqualTo,
        ///<summary>
        ///Less Than or Equal to.
        ///<para>When the item is serialized out as xml, its value is "lte".</para>
        ///</summary>
        [EnumString("lte")]
        LessThanOrEqualTo,
    }

    /// <summary>
    /// Child Order
    /// </summary>
    public enum ChildOrderValues
    {
        ///<summary>
        ///Bottom.
        ///<para>When the item is serialized out as xml, its value is "b".</para>
        ///</summary>
        [EnumString("b")]
        Bottom,
        ///<summary>
        ///Top.
        ///<para>When the item is serialized out as xml, its value is "t".</para>
        ///</summary>
        [EnumString("t")]
        Top,
    }

    /// <summary>
    /// Constraint Type
    /// </summary>
    public enum ConstraintValues
    {
        ///<summary>
        ///Unknown.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
        ///<summary>
        ///Alignment Offset.
        ///<para>When the item is serialized out as xml, its value is "alignOff".</para>
        ///</summary>
        [EnumString("alignOff")]
        AlignmentOffset,
        ///<summary>
        ///Beginning Margin.
        ///<para>When the item is serialized out as xml, its value is "begMarg".</para>
        ///</summary>
        [EnumString("begMarg")]
        BeginningMargin,
        ///<summary>
        ///Bending Distance.
        ///<para>When the item is serialized out as xml, its value is "bendDist".</para>
        ///</summary>
        [EnumString("bendDist")]
        BendingDistance,
        ///<summary>
        ///Beginning Padding.
        ///<para>When the item is serialized out as xml, its value is "begPad".</para>
        ///</summary>
        [EnumString("begPad")]
        BeginningPadding,
        ///<summary>
        ///Bottom.
        ///<para>When the item is serialized out as xml, its value is "b".</para>
        ///</summary>
        [EnumString("b")]
        Bottom,
        ///<summary>
        ///Bottom Margin.
        ///<para>When the item is serialized out as xml, its value is "bMarg".</para>
        ///</summary>
        [EnumString("bMarg")]
        BottomMargin,
        ///<summary>
        ///Bottom Offset.
        ///<para>When the item is serialized out as xml, its value is "bOff".</para>
        ///</summary>
        [EnumString("bOff")]
        BottomOffset,
        ///<summary>
        ///Center Height.
        ///<para>When the item is serialized out as xml, its value is "ctrX".</para>
        ///</summary>
        [EnumString("ctrX")]
        CenterHeight,
        ///<summary>
        ///Center X Offset.
        ///<para>When the item is serialized out as xml, its value is "ctrXOff".</para>
        ///</summary>
        [EnumString("ctrXOff")]
        CenterXOffset,
        ///<summary>
        ///Center Width.
        ///<para>When the item is serialized out as xml, its value is "ctrY".</para>
        ///</summary>
        [EnumString("ctrY")]
        CenterWidth,
        ///<summary>
        ///Center Y Offset.
        ///<para>When the item is serialized out as xml, its value is "ctrYOff".</para>
        ///</summary>
        [EnumString("ctrYOff")]
        CenterYOffset,
        ///<summary>
        ///Connection Distance.
        ///<para>When the item is serialized out as xml, its value is "connDist".</para>
        ///</summary>
        [EnumString("connDist")]
        ConnectionDistance,
        ///<summary>
        ///Diameter.
        ///<para>When the item is serialized out as xml, its value is "diam".</para>
        ///</summary>
        [EnumString("diam")]
        Diameter,
        ///<summary>
        ///End Margin.
        ///<para>When the item is serialized out as xml, its value is "endMarg".</para>
        ///</summary>
        [EnumString("endMarg")]
        EndMargin,
        ///<summary>
        ///End Padding.
        ///<para>When the item is serialized out as xml, its value is "endPad".</para>
        ///</summary>
        [EnumString("endPad")]
        EndPadding,
        ///<summary>
        ///Height.
        ///<para>When the item is serialized out as xml, its value is "h".</para>
        ///</summary>
        [EnumString("h")]
        Height,
        ///<summary>
        ///Arrowhead Height.
        ///<para>When the item is serialized out as xml, its value is "hArH".</para>
        ///</summary>
        [EnumString("hArH")]
        ArrowheadHeight,
        ///<summary>
        ///Height Offset.
        ///<para>When the item is serialized out as xml, its value is "hOff".</para>
        ///</summary>
        [EnumString("hOff")]
        HeightOffset,
        ///<summary>
        ///Left.
        ///<para>When the item is serialized out as xml, its value is "l".</para>
        ///</summary>
        [EnumString("l")]
        Left,
        ///<summary>
        ///Left Margin.
        ///<para>When the item is serialized out as xml, its value is "lMarg".</para>
        ///</summary>
        [EnumString("lMarg")]
        LeftMargin,
        ///<summary>
        ///Left Offset.
        ///<para>When the item is serialized out as xml, its value is "lOff".</para>
        ///</summary>
        [EnumString("lOff")]
        LeftOffset,
        ///<summary>
        ///Right.
        ///<para>When the item is serialized out as xml, its value is "r".</para>
        ///</summary>
        [EnumString("r")]
        Right,
        ///<summary>
        ///Right Margin.
        ///<para>When the item is serialized out as xml, its value is "rMarg".</para>
        ///</summary>
        [EnumString("rMarg")]
        RightMargin,
        ///<summary>
        ///Right Offset.
        ///<para>When the item is serialized out as xml, its value is "rOff".</para>
        ///</summary>
        [EnumString("rOff")]
        RightOffset,
        ///<summary>
        ///Primary Font Size.
        ///<para>When the item is serialized out as xml, its value is "primFontSz".</para>
        ///</summary>
        [EnumString("primFontSz")]
        PrimaryFontSize,
        ///<summary>
        ///Pyramid Accent Ratio.
        ///<para>When the item is serialized out as xml, its value is "pyraAcctRatio".</para>
        ///</summary>
        [EnumString("pyraAcctRatio")]
        PyramidAccentRatio,
        ///<summary>
        ///Secondary Font Size.
        ///<para>When the item is serialized out as xml, its value is "secFontSz".</para>
        ///</summary>
        [EnumString("secFontSz")]
        SecondaryFontSize,
        ///<summary>
        ///Sibling Spacing.
        ///<para>When the item is serialized out as xml, its value is "sibSp".</para>
        ///</summary>
        [EnumString("sibSp")]
        SiblingSpacing,
        ///<summary>
        ///Secondary Sibling Spacing.
        ///<para>When the item is serialized out as xml, its value is "secSibSp".</para>
        ///</summary>
        [EnumString("secSibSp")]
        SecondarySiblingSpacing,
        ///<summary>
        ///Spacing.
        ///<para>When the item is serialized out as xml, its value is "sp".</para>
        ///</summary>
        [EnumString("sp")]
        Spacing,
        ///<summary>
        ///Stem Thickness.
        ///<para>When the item is serialized out as xml, its value is "stemThick".</para>
        ///</summary>
        [EnumString("stemThick")]
        StemThickness,
        ///<summary>
        ///Top.
        ///<para>When the item is serialized out as xml, its value is "t".</para>
        ///</summary>
        [EnumString("t")]
        Top,
        ///<summary>
        ///Top Margin.
        ///<para>When the item is serialized out as xml, its value is "tMarg".</para>
        ///</summary>
        [EnumString("tMarg")]
        TopMargin,
        ///<summary>
        ///Top Offset.
        ///<para>When the item is serialized out as xml, its value is "tOff".</para>
        ///</summary>
        [EnumString("tOff")]
        TopOffset,
        ///<summary>
        ///User Defined A.
        ///<para>When the item is serialized out as xml, its value is "userA".</para>
        ///</summary>
        [EnumString("userA")]
        UserDefinedA,
        ///<summary>
        ///User Defined B.
        ///<para>When the item is serialized out as xml, its value is "userB".</para>
        ///</summary>
        [EnumString("userB")]
        UserDefinedB,
        ///<summary>
        ///User Defined C.
        ///<para>When the item is serialized out as xml, its value is "userC".</para>
        ///</summary>
        [EnumString("userC")]
        UserDefinedC,
        ///<summary>
        ///User Defined D.
        ///<para>When the item is serialized out as xml, its value is "userD".</para>
        ///</summary>
        [EnumString("userD")]
        UserDefinedD,
        ///<summary>
        ///User Defined E.
        ///<para>When the item is serialized out as xml, its value is "userE".</para>
        ///</summary>
        [EnumString("userE")]
        UserDefinedE,
        ///<summary>
        ///User Defined F.
        ///<para>When the item is serialized out as xml, its value is "userF".</para>
        ///</summary>
        [EnumString("userF")]
        UserDefinedF,
        ///<summary>
        ///User Defined G.
        ///<para>When the item is serialized out as xml, its value is "userG".</para>
        ///</summary>
        [EnumString("userG")]
        UserDefinedG,
        ///<summary>
        ///User Defined H.
        ///<para>When the item is serialized out as xml, its value is "userH".</para>
        ///</summary>
        [EnumString("userH")]
        UserDefinedH,
        ///<summary>
        ///User Defined I.
        ///<para>When the item is serialized out as xml, its value is "userI".</para>
        ///</summary>
        [EnumString("userI")]
        UserDefinedI,
        ///<summary>
        ///User Defined J.
        ///<para>When the item is serialized out as xml, its value is "userJ".</para>
        ///</summary>
        [EnumString("userJ")]
        UserDefinedJ,
        ///<summary>
        ///User Defined K.
        ///<para>When the item is serialized out as xml, its value is "userK".</para>
        ///</summary>
        [EnumString("userK")]
        UserDefinedK,
        ///<summary>
        ///User Defined L.
        ///<para>When the item is serialized out as xml, its value is "userL".</para>
        ///</summary>
        [EnumString("userL")]
        UserDefinedL,
        ///<summary>
        ///User Defined M.
        ///<para>When the item is serialized out as xml, its value is "userM".</para>
        ///</summary>
        [EnumString("userM")]
        UserDefinedM,
        ///<summary>
        ///User Defined N.
        ///<para>When the item is serialized out as xml, its value is "userN".</para>
        ///</summary>
        [EnumString("userN")]
        UserDefinedN,
        ///<summary>
        ///User Defined O.
        ///<para>When the item is serialized out as xml, its value is "userO".</para>
        ///</summary>
        [EnumString("userO")]
        UserDefinedO,
        ///<summary>
        ///User Defined P.
        ///<para>When the item is serialized out as xml, its value is "userP".</para>
        ///</summary>
        [EnumString("userP")]
        UserDefinedP,
        ///<summary>
        ///User Defined Q.
        ///<para>When the item is serialized out as xml, its value is "userQ".</para>
        ///</summary>
        [EnumString("userQ")]
        UserDefinedQ,
        ///<summary>
        ///User Defined R.
        ///<para>When the item is serialized out as xml, its value is "userR".</para>
        ///</summary>
        [EnumString("userR")]
        UserDefinedR,
        ///<summary>
        ///User Defined S.
        ///<para>When the item is serialized out as xml, its value is "userS".</para>
        ///</summary>
        [EnumString("userS")]
        UserDefinedS,
        ///<summary>
        ///User Defined T.
        ///<para>When the item is serialized out as xml, its value is "userT".</para>
        ///</summary>
        [EnumString("userT")]
        UserDefinedT,
        ///<summary>
        ///User Defined U.
        ///<para>When the item is serialized out as xml, its value is "userU".</para>
        ///</summary>
        [EnumString("userU")]
        UserDefinedU,
        ///<summary>
        ///User Defined V.
        ///<para>When the item is serialized out as xml, its value is "userV".</para>
        ///</summary>
        [EnumString("userV")]
        UserDefinedV,
        ///<summary>
        ///User Defined W.
        ///<para>When the item is serialized out as xml, its value is "userW".</para>
        ///</summary>
        [EnumString("userW")]
        UserDefinedW,
        ///<summary>
        ///User Defined X.
        ///<para>When the item is serialized out as xml, its value is "userX".</para>
        ///</summary>
        [EnumString("userX")]
        UserDefinedX,
        ///<summary>
        ///User Defined Y.
        ///<para>When the item is serialized out as xml, its value is "userY".</para>
        ///</summary>
        [EnumString("userY")]
        UserDefinedY,
        ///<summary>
        ///User Defined Z.
        ///<para>When the item is serialized out as xml, its value is "userZ".</para>
        ///</summary>
        [EnumString("userZ")]
        UserDefinedZ,
        ///<summary>
        ///Width.
        ///<para>When the item is serialized out as xml, its value is "w".</para>
        ///</summary>
        [EnumString("w")]
        Width,
        ///<summary>
        ///Arrowhead Width.
        ///<para>When the item is serialized out as xml, its value is "wArH".</para>
        ///</summary>
        [EnumString("wArH")]
        ArrowheadWidth,
        ///<summary>
        ///Width Offset.
        ///<para>When the item is serialized out as xml, its value is "wOff".</para>
        ///</summary>
        [EnumString("wOff")]
        WidthOffset,
    }

    /// <summary>
    /// Constraint Relationship
    /// </summary>
    public enum ConstraintRelationshipValues
    {
        ///<summary>
        ///Self.
        ///<para>When the item is serialized out as xml, its value is "self".</para>
        ///</summary>
        [EnumString("self")]
        Self,
        ///<summary>
        ///Child.
        ///<para>When the item is serialized out as xml, its value is "ch".</para>
        ///</summary>
        [EnumString("ch")]
        Child,
        ///<summary>
        ///Descendant.
        ///<para>When the item is serialized out as xml, its value is "des".</para>
        ///</summary>
        [EnumString("des")]
        Descendant,
    }

    /// <summary>
    /// Element Type
    /// </summary>
    public enum ElementValues
    {
        ///<summary>
        ///All.
        ///<para>When the item is serialized out as xml, its value is "all".</para>
        ///</summary>
        [EnumString("all")]
        All,
        ///<summary>
        ///Document.
        ///<para>When the item is serialized out as xml, its value is "doc".</para>
        ///</summary>
        [EnumString("doc")]
        Document,
        ///<summary>
        ///Node.
        ///<para>When the item is serialized out as xml, its value is "node".</para>
        ///</summary>
        [EnumString("node")]
        Node,
        ///<summary>
        ///Normal.
        ///<para>When the item is serialized out as xml, its value is "norm".</para>
        ///</summary>
        [EnumString("norm")]
        Normal,
        ///<summary>
        ///Non Normal.
        ///<para>When the item is serialized out as xml, its value is "nonNorm".</para>
        ///</summary>
        [EnumString("nonNorm")]
        NonNormal,
        ///<summary>
        ///Assistant.
        ///<para>When the item is serialized out as xml, its value is "asst".</para>
        ///</summary>
        [EnumString("asst")]
        Assistant,
        ///<summary>
        ///Non Assistant.
        ///<para>When the item is serialized out as xml, its value is "nonAsst".</para>
        ///</summary>
        [EnumString("nonAsst")]
        NonAssistant,
        ///<summary>
        ///Parent Transition.
        ///<para>When the item is serialized out as xml, its value is "parTrans".</para>
        ///</summary>
        [EnumString("parTrans")]
        ParentTransition,
        ///<summary>
        ///Presentation.
        ///<para>When the item is serialized out as xml, its value is "pres".</para>
        ///</summary>
        [EnumString("pres")]
        Presentation,
        ///<summary>
        ///Sibling Transition.
        ///<para>When the item is serialized out as xml, its value is "sibTrans".</para>
        ///</summary>
        [EnumString("sibTrans")]
        SiblingTransition,
    }

    /// <summary>
    /// Parameter Identifier
    /// </summary>
    public enum ParameterIdValues
    {
        ///<summary>
        ///Horizontal Alignment.
        ///<para>When the item is serialized out as xml, its value is "horzAlign".</para>
        ///</summary>
        [EnumString("horzAlign")]
        HorizontalAlignment,
        ///<summary>
        ///Vertical Alignment.
        ///<para>When the item is serialized out as xml, its value is "vertAlign".</para>
        ///</summary>
        [EnumString("vertAlign")]
        VerticalAlignment,
        ///<summary>
        ///Child Direction.
        ///<para>When the item is serialized out as xml, its value is "chDir".</para>
        ///</summary>
        [EnumString("chDir")]
        ChildDirection,
        ///<summary>
        ///Child Alignment.
        ///<para>When the item is serialized out as xml, its value is "chAlign".</para>
        ///</summary>
        [EnumString("chAlign")]
        ChildAlignment,
        ///<summary>
        ///Secondary Child Alignment.
        ///<para>When the item is serialized out as xml, its value is "secChAlign".</para>
        ///</summary>
        [EnumString("secChAlign")]
        SecondaryChildAlignment,
        ///<summary>
        ///Linear Direction.
        ///<para>When the item is serialized out as xml, its value is "linDir".</para>
        ///</summary>
        [EnumString("linDir")]
        LinearDirection,
        ///<summary>
        ///Secondary Linear Direction.
        ///<para>When the item is serialized out as xml, its value is "secLinDir".</para>
        ///</summary>
        [EnumString("secLinDir")]
        SecondaryLinearDirection,
        ///<summary>
        ///Start Element.
        ///<para>When the item is serialized out as xml, its value is "stElem".</para>
        ///</summary>
        [EnumString("stElem")]
        StartElement,
        ///<summary>
        ///Bend Point.
        ///<para>When the item is serialized out as xml, its value is "bendPt".</para>
        ///</summary>
        [EnumString("bendPt")]
        BendPoint,
        ///<summary>
        ///Connection Route.
        ///<para>When the item is serialized out as xml, its value is "connRout".</para>
        ///</summary>
        [EnumString("connRout")]
        ConnectionRoute,
        ///<summary>
        ///Beginning Arrowhead Style.
        ///<para>When the item is serialized out as xml, its value is "begSty".</para>
        ///</summary>
        [EnumString("begSty")]
        BeginningArrowheadStyle,
        ///<summary>
        ///End Style.
        ///<para>When the item is serialized out as xml, its value is "endSty".</para>
        ///</summary>
        [EnumString("endSty")]
        EndStyle,
        ///<summary>
        ///Connector Dimension.
        ///<para>When the item is serialized out as xml, its value is "dim".</para>
        ///</summary>
        [EnumString("dim")]
        ConnectorDimension,
        ///<summary>
        ///Rotation Path.
        ///<para>When the item is serialized out as xml, its value is "rotPath".</para>
        ///</summary>
        [EnumString("rotPath")]
        RotationPath,
        ///<summary>
        ///Center Shape Mapping.
        ///<para>When the item is serialized out as xml, its value is "ctrShpMap".</para>
        ///</summary>
        [EnumString("ctrShpMap")]
        CenterShapeMapping,
        ///<summary>
        ///Node Horizontal Alignment.
        ///<para>When the item is serialized out as xml, its value is "nodeHorzAlign".</para>
        ///</summary>
        [EnumString("nodeHorzAlign")]
        NodeHorizontalAlignment,
        ///<summary>
        ///Node Vertical Alignment.
        ///<para>When the item is serialized out as xml, its value is "nodeVertAlign".</para>
        ///</summary>
        [EnumString("nodeVertAlign")]
        NodeVerticalAlignment,
        ///<summary>
        ///Fallback Scale.
        ///<para>When the item is serialized out as xml, its value is "fallback".</para>
        ///</summary>
        [EnumString("fallback")]
        FallbackScale,
        ///<summary>
        ///Text Direction.
        ///<para>When the item is serialized out as xml, its value is "txDir".</para>
        ///</summary>
        [EnumString("txDir")]
        TextDirection,
        ///<summary>
        ///Pyramid Accent Position.
        ///<para>When the item is serialized out as xml, its value is "pyraAcctPos".</para>
        ///</summary>
        [EnumString("pyraAcctPos")]
        PyramidAccentPosition,
        ///<summary>
        ///Pyramid Accent Text Margin.
        ///<para>When the item is serialized out as xml, its value is "pyraAcctTxMar".</para>
        ///</summary>
        [EnumString("pyraAcctTxMar")]
        PyramidAccentTextMargin,
        ///<summary>
        ///Text Block Direction.
        ///<para>When the item is serialized out as xml, its value is "txBlDir".</para>
        ///</summary>
        [EnumString("txBlDir")]
        TextBlockDirection,
        ///<summary>
        ///Text Anchor Horizontal.
        ///<para>When the item is serialized out as xml, its value is "txAnchorHorz".</para>
        ///</summary>
        [EnumString("txAnchorHorz")]
        TextAnchorHorizontal,
        ///<summary>
        ///Text Anchor Vertical.
        ///<para>When the item is serialized out as xml, its value is "txAnchorVert".</para>
        ///</summary>
        [EnumString("txAnchorVert")]
        TextAnchorVertical,
        ///<summary>
        ///Text Anchor Horizontal With Children.
        ///<para>When the item is serialized out as xml, its value is "txAnchorHorzCh".</para>
        ///</summary>
        [EnumString("txAnchorHorzCh")]
        TextAnchorHorizontalWithChildren,
        ///<summary>
        ///Text Anchor Vertical With Children.
        ///<para>When the item is serialized out as xml, its value is "txAnchorVertCh".</para>
        ///</summary>
        [EnumString("txAnchorVertCh")]
        TextAnchorVerticalWithChildren,
        ///<summary>
        ///Parent Text Left-to-Right Alignment.
        ///<para>When the item is serialized out as xml, its value is "parTxLTRAlign".</para>
        ///</summary>
        [EnumString("parTxLTRAlign")]
        ParentTextLeftToRightAlignment,
        ///<summary>
        ///Parent Text Right-to-Left Alignment.
        ///<para>When the item is serialized out as xml, its value is "parTxRTLAlign".</para>
        ///</summary>
        [EnumString("parTxRTLAlign")]
        ParentTextRightToLeftAlignment,
        ///<summary>
        ///Shape Text Left-to-Right Alignment.
        ///<para>When the item is serialized out as xml, its value is "shpTxLTRAlignCh".</para>
        ///</summary>
        [EnumString("shpTxLTRAlignCh")]
        ShapeTextLeftToRightAlignment,
        ///<summary>
        ///Shape Text Right-to-Left Alignment.
        ///<para>When the item is serialized out as xml, its value is "shpTxRTLAlignCh".</para>
        ///</summary>
        [EnumString("shpTxRTLAlignCh")]
        ShapeTextRightToLeftAlignment,
        ///<summary>
        ///Auto Text Rotation.
        ///<para>When the item is serialized out as xml, its value is "autoTxRot".</para>
        ///</summary>
        [EnumString("autoTxRot")]
        AutoTextRotation,
        ///<summary>
        ///Grow Direction.
        ///<para>When the item is serialized out as xml, its value is "grDir".</para>
        ///</summary>
        [EnumString("grDir")]
        GrowDirection,
        ///<summary>
        ///Flow Direction.
        ///<para>When the item is serialized out as xml, its value is "flowDir".</para>
        ///</summary>
        [EnumString("flowDir")]
        FlowDirection,
        ///<summary>
        ///Continue Direction.
        ///<para>When the item is serialized out as xml, its value is "contDir".</para>
        ///</summary>
        [EnumString("contDir")]
        ContinueDirection,
        ///<summary>
        ///Breakpoint.
        ///<para>When the item is serialized out as xml, its value is "bkpt".</para>
        ///</summary>
        [EnumString("bkpt")]
        Breakpoint,
        ///<summary>
        ///Offset.
        ///<para>When the item is serialized out as xml, its value is "off".</para>
        ///</summary>
        [EnumString("off")]
        Offset,
        ///<summary>
        ///Hierarchy Alignment.
        ///<para>When the item is serialized out as xml, its value is "hierAlign".</para>
        ///</summary>
        [EnumString("hierAlign")]
        HierarchyAlignment,
        ///<summary>
        ///Breakpoint Fixed Value.
        ///<para>When the item is serialized out as xml, its value is "bkPtFixedVal".</para>
        ///</summary>
        [EnumString("bkPtFixedVal")]
        BreakpointFixedValue,
        ///<summary>
        ///Start Bullets At Level.
        ///<para>When the item is serialized out as xml, its value is "stBulletLvl".</para>
        ///</summary>
        [EnumString("stBulletLvl")]
        StartBulletsAtLevel,
        ///<summary>
        ///Start Angle.
        ///<para>When the item is serialized out as xml, its value is "stAng".</para>
        ///</summary>
        [EnumString("stAng")]
        StartAngle,
        ///<summary>
        ///Span Angle.
        ///<para>When the item is serialized out as xml, its value is "spanAng".</para>
        ///</summary>
        [EnumString("spanAng")]
        SpanAngle,
        ///<summary>
        ///Aspect Ratio.
        ///<para>When the item is serialized out as xml, its value is "ar".</para>
        ///</summary>
        [EnumString("ar")]
        AspectRatio,
        ///<summary>
        ///Line Spacing Parent.
        ///<para>When the item is serialized out as xml, its value is "lnSpPar".</para>
        ///</summary>
        [EnumString("lnSpPar")]
        LineSpacingParent,
        ///<summary>
        ///Line Spacing After Parent Paragraph.
        ///<para>When the item is serialized out as xml, its value is "lnSpAfParP".</para>
        ///</summary>
        [EnumString("lnSpAfParP")]
        LineSpacingAfterParentParagraph,
        ///<summary>
        ///Line Spacing Children.
        ///<para>When the item is serialized out as xml, its value is "lnSpCh".</para>
        ///</summary>
        [EnumString("lnSpCh")]
        LineSpacingChildren,
        ///<summary>
        ///Line Spacing After Children Paragraph.
        ///<para>When the item is serialized out as xml, its value is "lnSpAfChP".</para>
        ///</summary>
        [EnumString("lnSpAfChP")]
        LineSpacingAfterChildrenParagraph,
        ///<summary>
        ///Route Shortest Distance.
        ///<para>When the item is serialized out as xml, its value is "rtShortDist".</para>
        ///</summary>
        [EnumString("rtShortDist")]
        RouteShortestDistance,
        ///<summary>
        ///Text Alignment.
        ///<para>When the item is serialized out as xml, its value is "alignTx".</para>
        ///</summary>
        [EnumString("alignTx")]
        TextAlignment,
        ///<summary>
        ///Pyramid Level Node.
        ///<para>When the item is serialized out as xml, its value is "pyraLvlNode".</para>
        ///</summary>
        [EnumString("pyraLvlNode")]
        PyramidLevelNode,
        ///<summary>
        ///Pyramid Accent Background Node.
        ///<para>When the item is serialized out as xml, its value is "pyraAcctBkgdNode".</para>
        ///</summary>
        [EnumString("pyraAcctBkgdNode")]
        PyramidAccentBackgroundNode,
        ///<summary>
        ///Pyramid Accent Text Node.
        ///<para>When the item is serialized out as xml, its value is "pyraAcctTxNode".</para>
        ///</summary>
        [EnumString("pyraAcctTxNode")]
        PyramidAccentTextNode,
        ///<summary>
        ///Source Node.
        ///<para>When the item is serialized out as xml, its value is "srcNode".</para>
        ///</summary>
        [EnumString("srcNode")]
        SourceNode,
        ///<summary>
        ///Destination Node.
        ///<para>When the item is serialized out as xml, its value is "dstNode".</para>
        ///</summary>
        [EnumString("dstNode")]
        DestinationNode,
        ///<summary>
        ///Beginning Points.
        ///<para>When the item is serialized out as xml, its value is "begPts".</para>
        ///</summary>
        [EnumString("begPts")]
        BeginningPoints,
        ///<summary>
        ///End Points.
        ///<para>When the item is serialized out as xml, its value is "endPts".</para>
        ///</summary>
        [EnumString("endPts")]
        EndPoints,
    }

    /// <summary>
    /// Function Type
    /// </summary>
    public enum FunctionValues
    {
        ///<summary>
        ///Count.
        ///<para>When the item is serialized out as xml, its value is "cnt".</para>
        ///</summary>
        [EnumString("cnt")]
        Count,
        ///<summary>
        ///Position.
        ///<para>When the item is serialized out as xml, its value is "pos".</para>
        ///</summary>
        [EnumString("pos")]
        Position,
        ///<summary>
        ///Reverse Position.
        ///<para>When the item is serialized out as xml, its value is "revPos".</para>
        ///</summary>
        [EnumString("revPos")]
        ReversePosition,
        ///<summary>
        ///Position Even.
        ///<para>When the item is serialized out as xml, its value is "posEven".</para>
        ///</summary>
        [EnumString("posEven")]
        PositionEven,
        ///<summary>
        ///Position Odd.
        ///<para>When the item is serialized out as xml, its value is "posOdd".</para>
        ///</summary>
        [EnumString("posOdd")]
        PositionOdd,
        ///<summary>
        ///Variable.
        ///<para>When the item is serialized out as xml, its value is "var".</para>
        ///</summary>
        [EnumString("var")]
        Variable,
        ///<summary>
        ///Depth.
        ///<para>When the item is serialized out as xml, its value is "depth".</para>
        ///</summary>
        [EnumString("depth")]
        Depth,
        ///<summary>
        ///Max Depth.
        ///<para>When the item is serialized out as xml, its value is "maxDepth".</para>
        ///</summary>
        [EnumString("maxDepth")]
        MaxDepth,
    }

    /// <summary>
    /// Function Operator
    /// </summary>
    public enum FunctionOperatorValues
    {
        ///<summary>
        ///Equal.
        ///<para>When the item is serialized out as xml, its value is "equ".</para>
        ///</summary>
        [EnumString("equ")]
        Equal,
        ///<summary>
        ///Not Equal To.
        ///<para>When the item is serialized out as xml, its value is "neq".</para>
        ///</summary>
        [EnumString("neq")]
        NotEqualTo,
        ///<summary>
        ///Greater Than.
        ///<para>When the item is serialized out as xml, its value is "gt".</para>
        ///</summary>
        [EnumString("gt")]
        GreaterThan,
        ///<summary>
        ///Less Than.
        ///<para>When the item is serialized out as xml, its value is "lt".</para>
        ///</summary>
        [EnumString("lt")]
        LessThan,
        ///<summary>
        ///Greater Than or Equal to.
        ///<para>When the item is serialized out as xml, its value is "gte".</para>
        ///</summary>
        [EnumString("gte")]
        GreaterThanOrEqualTo,
        ///<summary>
        ///Less Than or Equal to.
        ///<para>When the item is serialized out as xml, its value is "lte".</para>
        ///</summary>
        [EnumString("lte")]
        LessThanOrEqualTo,
    }

    /// <summary>
    /// Horizontal Alignment
    /// </summary>
    public enum HorizontalAlignmentValues
    {
        ///<summary>
        ///Left.
        ///<para>When the item is serialized out as xml, its value is "l".</para>
        ///</summary>
        [EnumString("l")]
        Left,
        ///<summary>
        ///Center.
        ///<para>When the item is serialized out as xml, its value is "ctr".</para>
        ///</summary>
        [EnumString("ctr")]
        Center,
        ///<summary>
        ///Right.
        ///<para>When the item is serialized out as xml, its value is "r".</para>
        ///</summary>
        [EnumString("r")]
        Right,
        ///<summary>
        ///None.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
    }

    /// <summary>
    /// Child Direction
    /// </summary>
    public enum ChildDirectionValues
    {
        ///<summary>
        ///Horizontal.
        ///<para>When the item is serialized out as xml, its value is "horz".</para>
        ///</summary>
        [EnumString("horz")]
        Horizontal,
        ///<summary>
        ///Vertical.
        ///<para>When the item is serialized out as xml, its value is "vert".</para>
        ///</summary>
        [EnumString("vert")]
        Vertical,
    }

    /// <summary>
    /// Child Alignment
    /// </summary>
    public enum ChildAlignmentValues
    {
        ///<summary>
        ///Top.
        ///<para>When the item is serialized out as xml, its value is "t".</para>
        ///</summary>
        [EnumString("t")]
        Top,
        ///<summary>
        ///Bottom.
        ///<para>When the item is serialized out as xml, its value is "b".</para>
        ///</summary>
        [EnumString("b")]
        Bottom,
        ///<summary>
        ///Left.
        ///<para>When the item is serialized out as xml, its value is "l".</para>
        ///</summary>
        [EnumString("l")]
        Left,
        ///<summary>
        ///Right.
        ///<para>When the item is serialized out as xml, its value is "r".</para>
        ///</summary>
        [EnumString("r")]
        Right,
    }

    /// <summary>
    /// Secondary Child Alignment
    /// </summary>
    public enum SecondaryChildAlignmentValues
    {
        ///<summary>
        ///None.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
        ///<summary>
        ///Top.
        ///<para>When the item is serialized out as xml, its value is "t".</para>
        ///</summary>
        [EnumString("t")]
        Top,
        ///<summary>
        ///Bottom.
        ///<para>When the item is serialized out as xml, its value is "b".</para>
        ///</summary>
        [EnumString("b")]
        Bottom,
        ///<summary>
        ///Left.
        ///<para>When the item is serialized out as xml, its value is "l".</para>
        ///</summary>
        [EnumString("l")]
        Left,
        ///<summary>
        ///Right.
        ///<para>When the item is serialized out as xml, its value is "r".</para>
        ///</summary>
        [EnumString("r")]
        Right,
    }

    /// <summary>
    /// Linear Direction
    /// </summary>
    public enum LinearDirectionValues
    {
        ///<summary>
        ///From Left.
        ///<para>When the item is serialized out as xml, its value is "fromL".</para>
        ///</summary>
        [EnumString("fromL")]
        FromLeft,
        ///<summary>
        ///From Right.
        ///<para>When the item is serialized out as xml, its value is "fromR".</para>
        ///</summary>
        [EnumString("fromR")]
        FromRight,
        ///<summary>
        ///From Top.
        ///<para>When the item is serialized out as xml, its value is "fromT".</para>
        ///</summary>
        [EnumString("fromT")]
        FromTop,
        ///<summary>
        ///From Bottom.
        ///<para>When the item is serialized out as xml, its value is "fromB".</para>
        ///</summary>
        [EnumString("fromB")]
        FromBottom,
    }

    /// <summary>
    /// Secondary Linear Direction
    /// </summary>
    public enum SecondaryLinearDirectionValues
    {
        ///<summary>
        ///None.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
        ///<summary>
        ///From Left.
        ///<para>When the item is serialized out as xml, its value is "fromL".</para>
        ///</summary>
        [EnumString("fromL")]
        FromLeft,
        ///<summary>
        ///From Right.
        ///<para>When the item is serialized out as xml, its value is "fromR".</para>
        ///</summary>
        [EnumString("fromR")]
        FromRight,
        ///<summary>
        ///From Top.
        ///<para>When the item is serialized out as xml, its value is "fromT".</para>
        ///</summary>
        [EnumString("fromT")]
        FromTop,
        ///<summary>
        ///From Bottom.
        ///<para>When the item is serialized out as xml, its value is "fromB".</para>
        ///</summary>
        [EnumString("fromB")]
        FromBottom,
    }

    /// <summary>
    /// Starting Element
    /// </summary>
    public enum StartingElementValues
    {
        ///<summary>
        ///Node.
        ///<para>When the item is serialized out as xml, its value is "node".</para>
        ///</summary>
        [EnumString("node")]
        Node,
        ///<summary>
        ///Transition.
        ///<para>When the item is serialized out as xml, its value is "trans".</para>
        ///</summary>
        [EnumString("trans")]
        Transition,
    }

    /// <summary>
    /// Rotation Path
    /// </summary>
    public enum RotationPathValues
    {
        ///<summary>
        ///None.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
        ///<summary>
        ///Along Path.
        ///<para>When the item is serialized out as xml, its value is "alongPath".</para>
        ///</summary>
        [EnumString("alongPath")]
        AlongPath,
    }

    /// <summary>
    /// Center Shape Mapping
    /// </summary>
    public enum CenterShapeMappingValues
    {
        ///<summary>
        ///None.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
        ///<summary>
        ///First Node.
        ///<para>When the item is serialized out as xml, its value is "fNode".</para>
        ///</summary>
        [EnumString("fNode")]
        FirstNode,
    }

    /// <summary>
    /// Bend Point
    /// </summary>
    public enum BendPointValues
    {
        ///<summary>
        ///Beginning.
        ///<para>When the item is serialized out as xml, its value is "beg".</para>
        ///</summary>
        [EnumString("beg")]
        Beginning,
        ///<summary>
        ///Default.
        ///<para>When the item is serialized out as xml, its value is "def".</para>
        ///</summary>
        [EnumString("def")]
        Default,
        ///<summary>
        ///End.
        ///<para>When the item is serialized out as xml, its value is "end".</para>
        ///</summary>
        [EnumString("end")]
        End,
    }

    /// <summary>
    /// Connector Routing
    /// </summary>
    public enum ConnectorRoutingValues
    {
        ///<summary>
        ///Straight.
        ///<para>When the item is serialized out as xml, its value is "stra".</para>
        ///</summary>
        [EnumString("stra")]
        Straight,
        ///<summary>
        ///Bending.
        ///<para>When the item is serialized out as xml, its value is "bend".</para>
        ///</summary>
        [EnumString("bend")]
        Bending,
        ///<summary>
        ///Curve.
        ///<para>When the item is serialized out as xml, its value is "curve".</para>
        ///</summary>
        [EnumString("curve")]
        Curve,
        ///<summary>
        ///Long Curve.
        ///<para>When the item is serialized out as xml, its value is "longCurve".</para>
        ///</summary>
        [EnumString("longCurve")]
        LongCurve,
    }

    /// <summary>
    /// Arrowhead Styles
    /// </summary>
    public enum ArrowheadStyleValues
    {
        ///<summary>
        ///Auto.
        ///<para>When the item is serialized out as xml, its value is "auto".</para>
        ///</summary>
        [EnumString("auto")]
        Auto,
        ///<summary>
        ///Arrowhead Present.
        ///<para>When the item is serialized out as xml, its value is "arr".</para>
        ///</summary>
        [EnumString("arr")]
        Arrow,
        ///<summary>
        ///No Arrowhead.
        ///<para>When the item is serialized out as xml, its value is "noArr".</para>
        ///</summary>
        [EnumString("noArr")]
        NoArrow,
    }

    /// <summary>
    /// Connector Dimension
    /// </summary>
    public enum ConnectorDimensionValues
    {
        ///<summary>
        ///1 Dimension.
        ///<para>When the item is serialized out as xml, its value is "1D".</para>
        ///</summary>
        [EnumString("1D")]
        OneDimension,
        ///<summary>
        ///2 Dimensions.
        ///<para>When the item is serialized out as xml, its value is "2D".</para>
        ///</summary>
        [EnumString("2D")]
        TwoDimension,
        ///<summary>
        ///Custom.
        ///<para>When the item is serialized out as xml, its value is "cust".</para>
        ///</summary>
        [EnumString("cust")]
        Custom,
    }

    /// <summary>
    /// Connector Point
    /// </summary>
    public enum ConnectorPointValues
    {
        ///<summary>
        ///Auto.
        ///<para>When the item is serialized out as xml, its value is "auto".</para>
        ///</summary>
        [EnumString("auto")]
        Auto,
        ///<summary>
        ///Bottom Center.
        ///<para>When the item is serialized out as xml, its value is "bCtr".</para>
        ///</summary>
        [EnumString("bCtr")]
        BottomCenter,
        ///<summary>
        ///Center.
        ///<para>When the item is serialized out as xml, its value is "ctr".</para>
        ///</summary>
        [EnumString("ctr")]
        Center,
        ///<summary>
        ///Middle Left.
        ///<para>When the item is serialized out as xml, its value is "midL".</para>
        ///</summary>
        [EnumString("midL")]
        MiddleLeft,
        ///<summary>
        ///Middle Right.
        ///<para>When the item is serialized out as xml, its value is "midR".</para>
        ///</summary>
        [EnumString("midR")]
        MiddleRight,
        ///<summary>
        ///Top Center.
        ///<para>When the item is serialized out as xml, its value is "tCtr".</para>
        ///</summary>
        [EnumString("tCtr")]
        TopCenter,
        ///<summary>
        ///Bottom Left.
        ///<para>When the item is serialized out as xml, its value is "bL".</para>
        ///</summary>
        [EnumString("bL")]
        BottomLeft,
        ///<summary>
        ///Bottom Right.
        ///<para>When the item is serialized out as xml, its value is "bR".</para>
        ///</summary>
        [EnumString("bR")]
        BottomRight,
        ///<summary>
        ///Top Left.
        ///<para>When the item is serialized out as xml, its value is "tL".</para>
        ///</summary>
        [EnumString("tL")]
        TopLeft,
        ///<summary>
        ///Top Right.
        ///<para>When the item is serialized out as xml, its value is "tR".</para>
        ///</summary>
        [EnumString("tR")]
        TopRight,
        ///<summary>
        ///Radial.
        ///<para>When the item is serialized out as xml, its value is "radial".</para>
        ///</summary>
        [EnumString("radial")]
        Radial,
    }

    /// <summary>
    /// Node Horizontal Alignment
    /// </summary>
    public enum NodeHorizontalAlignmentValues
    {
        ///<summary>
        ///Left.
        ///<para>When the item is serialized out as xml, its value is "l".</para>
        ///</summary>
        [EnumString("l")]
        Left,
        ///<summary>
        ///Center.
        ///<para>When the item is serialized out as xml, its value is "ctr".</para>
        ///</summary>
        [EnumString("ctr")]
        Center,
        ///<summary>
        ///Right.
        ///<para>When the item is serialized out as xml, its value is "r".</para>
        ///</summary>
        [EnumString("r")]
        Right,
    }

    /// <summary>
    /// Node Vertical Alignment
    /// </summary>
    public enum NodeVerticalAlignmentValues
    {
        ///<summary>
        ///Top.
        ///<para>When the item is serialized out as xml, its value is "t".</para>
        ///</summary>
        [EnumString("t")]
        Top,
        ///<summary>
        ///Middle.
        ///<para>When the item is serialized out as xml, its value is "mid".</para>
        ///</summary>
        [EnumString("mid")]
        Middle,
        ///<summary>
        ///Bottom.
        ///<para>When the item is serialized out as xml, its value is "b".</para>
        ///</summary>
        [EnumString("b")]
        Bottom,
    }

    /// <summary>
    /// Fallback Dimension
    /// </summary>
    public enum FallbackDimensionValues
    {
        ///<summary>
        ///1 Dimension.
        ///<para>When the item is serialized out as xml, its value is "1D".</para>
        ///</summary>
        [EnumString("1D")]
        OneDimension,
        ///<summary>
        ///2 Dimensions.
        ///<para>When the item is serialized out as xml, its value is "2D".</para>
        ///</summary>
        [EnumString("2D")]
        TwoDimension,
    }

    /// <summary>
    /// Text Direction
    /// </summary>
    public enum TextDirectionValues
    {
        ///<summary>
        ///From Top.
        ///<para>When the item is serialized out as xml, its value is "fromT".</para>
        ///</summary>
        [EnumString("fromT")]
        FromTop,
        ///<summary>
        ///From Bottom.
        ///<para>When the item is serialized out as xml, its value is "fromB".</para>
        ///</summary>
        [EnumString("fromB")]
        FromBottom,
    }

    /// <summary>
    /// Pyramid Accent Position
    /// </summary>
    public enum PyramidAccentPositionValues
    {
        ///<summary>
        ///Before.
        ///<para>When the item is serialized out as xml, its value is "bef".</para>
        ///</summary>
        [EnumString("bef")]
        Before,
        ///<summary>
        ///Pyramid Accent After.
        ///<para>When the item is serialized out as xml, its value is "aft".</para>
        ///</summary>
        [EnumString("aft")]
        After,
    }

    /// <summary>
    /// Pyramid Accent Text Margin
    /// </summary>
    public enum PyramidAccentTextMarginValues
    {
        ///<summary>
        ///Step.
        ///<para>When the item is serialized out as xml, its value is "step".</para>
        ///</summary>
        [EnumString("step")]
        Step,
        ///<summary>
        ///Stack.
        ///<para>When the item is serialized out as xml, its value is "stack".</para>
        ///</summary>
        [EnumString("stack")]
        Stack,
    }

    /// <summary>
    /// Text Block Direction
    /// </summary>
    public enum TextBlockDirectionValues
    {
        ///<summary>
        ///Horizontal.
        ///<para>When the item is serialized out as xml, its value is "horz".</para>
        ///</summary>
        [EnumString("horz")]
        Horizontal,
        ///<summary>
        ///Vertical Direction.
        ///<para>When the item is serialized out as xml, its value is "vert".</para>
        ///</summary>
        [EnumString("vert")]
        Vertical,
    }

    /// <summary>
    /// Text Anchor Horizontal
    /// </summary>
    public enum TextAnchorHorizontalValues
    {
        ///<summary>
        ///None.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
        ///<summary>
        ///Center.
        ///<para>When the item is serialized out as xml, its value is "ctr".</para>
        ///</summary>
        [EnumString("ctr")]
        Center,
    }

    /// <summary>
    /// Text Anchor Vertical
    /// </summary>
    public enum TextAnchorVerticalValues
    {
        ///<summary>
        ///Top.
        ///<para>When the item is serialized out as xml, its value is "t".</para>
        ///</summary>
        [EnumString("t")]
        Top,
        ///<summary>
        ///Middle.
        ///<para>When the item is serialized out as xml, its value is "mid".</para>
        ///</summary>
        [EnumString("mid")]
        Middle,
        ///<summary>
        ///Bottom.
        ///<para>When the item is serialized out as xml, its value is "b".</para>
        ///</summary>
        [EnumString("b")]
        Bottom,
    }

    /// <summary>
    /// Text Alignment
    /// </summary>
    public enum TextAlignmentValues
    {
        ///<summary>
        ///Left.
        ///<para>When the item is serialized out as xml, its value is "l".</para>
        ///</summary>
        [EnumString("l")]
        Left,
        ///<summary>
        ///Center.
        ///<para>When the item is serialized out as xml, its value is "ctr".</para>
        ///</summary>
        [EnumString("ctr")]
        Center,
        ///<summary>
        ///Right.
        ///<para>When the item is serialized out as xml, its value is "r".</para>
        ///</summary>
        [EnumString("r")]
        Right,
    }

    /// <summary>
    /// Auto Text Rotation
    /// </summary>
    public enum AutoTextRotationValues
    {
        ///<summary>
        ///None.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
        ///<summary>
        ///Upright.
        ///<para>When the item is serialized out as xml, its value is "upr".</para>
        ///</summary>
        [EnumString("upr")]
        Upright,
        ///<summary>
        ///Gravity.
        ///<para>When the item is serialized out as xml, its value is "grav".</para>
        ///</summary>
        [EnumString("grav")]
        Gravity,
    }

    /// <summary>
    /// Grow Direction
    /// </summary>
    public enum GrowDirectionValues
    {
        ///<summary>
        ///Top Left.
        ///<para>When the item is serialized out as xml, its value is "tL".</para>
        ///</summary>
        [EnumString("tL")]
        TopLeft,
        ///<summary>
        ///Top Right.
        ///<para>When the item is serialized out as xml, its value is "tR".</para>
        ///</summary>
        [EnumString("tR")]
        TopRight,
        ///<summary>
        ///Bottom Left.
        ///<para>When the item is serialized out as xml, its value is "bL".</para>
        ///</summary>
        [EnumString("bL")]
        BottomLeft,
        ///<summary>
        ///Bottom Right.
        ///<para>When the item is serialized out as xml, its value is "bR".</para>
        ///</summary>
        [EnumString("bR")]
        BottomRight,
    }

    /// <summary>
    /// Flow Direction
    /// </summary>
    public enum FlowDirectionValues
    {
        ///<summary>
        ///Row.
        ///<para>When the item is serialized out as xml, its value is "row".</para>
        ///</summary>
        [EnumString("row")]
        Row,
        ///<summary>
        ///Column.
        ///<para>When the item is serialized out as xml, its value is "col".</para>
        ///</summary>
        [EnumString("col")]
        Column,
    }

    /// <summary>
    /// Continue Direction
    /// </summary>
    public enum ContinueDirectionValues
    {
        ///<summary>
        ///Reverse Direction.
        ///<para>When the item is serialized out as xml, its value is "revDir".</para>
        ///</summary>
        [EnumString("revDir")]
        ReverseDirection,
        ///<summary>
        ///Same Direction.
        ///<para>When the item is serialized out as xml, its value is "sameDir".</para>
        ///</summary>
        [EnumString("sameDir")]
        SameDirection,
    }

    /// <summary>
    /// Breakpoint
    /// </summary>
    public enum BreakpointValues
    {
        ///<summary>
        ///End of Canvas.
        ///<para>When the item is serialized out as xml, its value is "endCnv".</para>
        ///</summary>
        [EnumString("endCnv")]
        EndCanvas,
        ///<summary>
        ///Balanced.
        ///<para>When the item is serialized out as xml, its value is "bal".</para>
        ///</summary>
        [EnumString("bal")]
        Balanced,
        ///<summary>
        ///Fixed.
        ///<para>When the item is serialized out as xml, its value is "fixed".</para>
        ///</summary>
        [EnumString("fixed")]
        Fixed,
    }

    /// <summary>
    /// Offset
    /// </summary>
    public enum OffsetValues
    {
        ///<summary>
        ///Center.
        ///<para>When the item is serialized out as xml, its value is "ctr".</para>
        ///</summary>
        [EnumString("ctr")]
        Center,
        ///<summary>
        ///Offset.
        ///<para>When the item is serialized out as xml, its value is "off".</para>
        ///</summary>
        [EnumString("off")]
        Offset,
    }

    /// <summary>
    /// Hierarchy Alignment
    /// </summary>
    public enum HierarchyAlignmentValues
    {
        ///<summary>
        ///Top Left.
        ///<para>When the item is serialized out as xml, its value is "tL".</para>
        ///</summary>
        [EnumString("tL")]
        TopLeft,
        ///<summary>
        ///Top Right.
        ///<para>When the item is serialized out as xml, its value is "tR".</para>
        ///</summary>
        [EnumString("tR")]
        TopRight,
        ///<summary>
        ///Top Center Children.
        ///<para>When the item is serialized out as xml, its value is "tCtrCh".</para>
        ///</summary>
        [EnumString("tCtrCh")]
        TopCenterChildren,
        ///<summary>
        ///Top Center Descendants.
        ///<para>When the item is serialized out as xml, its value is "tCtrDes".</para>
        ///</summary>
        [EnumString("tCtrDes")]
        TopCenterDescendants,
        ///<summary>
        ///Bottom Left.
        ///<para>When the item is serialized out as xml, its value is "bL".</para>
        ///</summary>
        [EnumString("bL")]
        BottomLeft,
        ///<summary>
        ///Bottom Right.
        ///<para>When the item is serialized out as xml, its value is "bR".</para>
        ///</summary>
        [EnumString("bR")]
        BottomRight,
        ///<summary>
        ///Bottom Center Child.
        ///<para>When the item is serialized out as xml, its value is "bCtrCh".</para>
        ///</summary>
        [EnumString("bCtrCh")]
        BottomCenterChild,
        ///<summary>
        ///Bottom Center Descendant.
        ///<para>When the item is serialized out as xml, its value is "bCtrDes".</para>
        ///</summary>
        [EnumString("bCtrDes")]
        BottomCenterDescendant,
        ///<summary>
        ///Left Top.
        ///<para>When the item is serialized out as xml, its value is "lT".</para>
        ///</summary>
        [EnumString("lT")]
        LeftTop,
        ///<summary>
        ///Left Bottom.
        ///<para>When the item is serialized out as xml, its value is "lB".</para>
        ///</summary>
        [EnumString("lB")]
        LeftBottom,
        ///<summary>
        ///Left Center Child.
        ///<para>When the item is serialized out as xml, its value is "lCtrCh".</para>
        ///</summary>
        [EnumString("lCtrCh")]
        LeftCenterChild,
        ///<summary>
        ///Left Center Descendant.
        ///<para>When the item is serialized out as xml, its value is "lCtrDes".</para>
        ///</summary>
        [EnumString("lCtrDes")]
        LeftCenterDescendant,
        ///<summary>
        ///Right Top.
        ///<para>When the item is serialized out as xml, its value is "rT".</para>
        ///</summary>
        [EnumString("rT")]
        RightTop,
        ///<summary>
        ///Right Bottom.
        ///<para>When the item is serialized out as xml, its value is "rB".</para>
        ///</summary>
        [EnumString("rB")]
        RightBottom,
        ///<summary>
        ///Right Center Children.
        ///<para>When the item is serialized out as xml, its value is "rCtrCh".</para>
        ///</summary>
        [EnumString("rCtrCh")]
        RightCenterChildren,
        ///<summary>
        ///Right Center Descendants.
        ///<para>When the item is serialized out as xml, its value is "rCtrDes".</para>
        ///</summary>
        [EnumString("rCtrDes")]
        RightCenterDescendants,
    }

    /// <summary>
    /// Variable Type
    /// </summary>
    public enum VariableValues
    {
        ///<summary>
        ///Unknown.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
        ///<summary>
        ///Organizational Chart Algorithm.
        ///<para>When the item is serialized out as xml, its value is "orgChart".</para>
        ///</summary>
        [EnumString("orgChart")]
        OrganizationalChart,
        ///<summary>
        ///Child Max.
        ///<para>When the item is serialized out as xml, its value is "chMax".</para>
        ///</summary>
        [EnumString("chMax")]
        ChildMax,
        ///<summary>
        ///Child Preference.
        ///<para>When the item is serialized out as xml, its value is "chPref".</para>
        ///</summary>
        [EnumString("chPref")]
        ChildPreference,
        ///<summary>
        ///Bullets Enabled.
        ///<para>When the item is serialized out as xml, its value is "bulEnabled".</para>
        ///</summary>
        [EnumString("bulEnabled")]
        BulletsEnabled,
        ///<summary>
        ///Direction.
        ///<para>When the item is serialized out as xml, its value is "dir".</para>
        ///</summary>
        [EnumString("dir")]
        Direction,
        ///<summary>
        ///Hierarchy Branch.
        ///<para>When the item is serialized out as xml, its value is "hierBranch".</para>
        ///</summary>
        [EnumString("hierBranch")]
        HierarchyBranch,
        ///<summary>
        ///Animate One.
        ///<para>When the item is serialized out as xml, its value is "animOne".</para>
        ///</summary>
        [EnumString("animOne")]
        AnimateOne,
        ///<summary>
        ///Animation Level.
        ///<para>When the item is serialized out as xml, its value is "animLvl".</para>
        ///</summary>
        [EnumString("animLvl")]
        AnimationLevel,
        ///<summary>
        ///Resize Handles.
        ///<para>When the item is serialized out as xml, its value is "resizeHandles".</para>
        ///</summary>
        [EnumString("resizeHandles")]
        ResizeHandles,
    }

    /// <summary>
    /// Output Shape Type
    /// </summary>
    public enum OutputShapeValues
    {
        ///<summary>
        ///None.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
        ///<summary>
        ///Connection.
        ///<para>When the item is serialized out as xml, its value is "conn".</para>
        ///</summary>
        [EnumString("conn")]
        Connection,
    }

    /// <summary>
    /// Vertical Alignment
    /// </summary>
    public enum VerticalAlignmentValues
    {
        ///<summary>
        ///Top.
        ///<para>When the item is serialized out as xml, its value is "t".</para>
        ///</summary>
        [EnumString("t")]
        Top,
        ///<summary>
        ///Middle.
        ///<para>When the item is serialized out as xml, its value is "mid".</para>
        ///</summary>
        [EnumString("mid")]
        Middle,
        ///<summary>
        ///Bottom.
        ///<para>When the item is serialized out as xml, its value is "b".</para>
        ///</summary>
        [EnumString("b")]
        Bottom,
        ///<summary>
        ///None.
        ///<para>When the item is serialized out as xml, its value is "none".</para>
        ///</summary>
        [EnumString("none")]
        None,
        ///<summary>
        ///top.
        ///<para>When the item is serialized out as xml, its value is "top".</para>
        ///<para>This item is only available in Office2010.</para>
        ///</summary>
        [EnumString("top")]
        [OfficeAvailability(FileFormatVersions.Office2010)]
        Top2010,
        ///<summary>
        ///center.
        ///<para>When the item is serialized out as xml, its value is "center".</para>
        ///<para>This item is only available in Office2010.</para>
        ///</summary>
        [EnumString("center")]
        [OfficeAvailability(FileFormatVersions.Office2010)]
        Middle2010,
        ///<summary>
        ///bottom.
        ///<para>When the item is serialized out as xml, its value is "bottom".</para>
        ///<para>This item is only available in Office2010.</para>
        ///</summary>
        [EnumString("bottom")]
        [OfficeAvailability(FileFormatVersions.Office2010)]
        Bottom2010,
    }
}