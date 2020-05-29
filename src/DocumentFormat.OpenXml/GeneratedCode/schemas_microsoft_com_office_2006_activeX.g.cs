// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office.ActiveX
{
    /// <summary>
    /// <para>Defines the ActiveXControlData Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ax:ocx.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ActiveXObjectProperty &lt;ax:ocxPr></description></item>
    /// </list>
    /// </remark>
    public partial class ActiveXControlData : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ActiveXControlData class.
        /// </summary>
        public ActiveXControlData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ActiveXControlData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ActiveXControlData(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ActiveXControlData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ActiveXControlData(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ActiveXControlData class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ActiveXControlData(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>classid</para>
        /// <para>Represents the following attribute in the schema: ax:classid</para>
        /// </summary>
        /// <remark>
        /// xmlns:ax=http://schemas.microsoft.com/office/2006/activeX
        /// </remark>
        public StringValue ActiveXControlClassId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>license</para>
        /// <para>Represents the following attribute in the schema: ax:license</para>
        /// </summary>
        /// <remark>
        /// xmlns:ax=http://schemas.microsoft.com/office/2006/activeX
        /// </remark>
        public StringValue License
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>persistence</para>
        /// <para>Represents the following attribute in the schema: ax:persistence</para>
        /// </summary>
        /// <remark>
        /// xmlns:ax=http://schemas.microsoft.com/office/2006/activeX
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Office.ActiveX.PersistenceValues> Persistence
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office.ActiveX.PersistenceValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(35, "ocx");
            builder.AddChild<ActiveXObjectProperty>();
            builder.AddElement<ActiveXControlData>()
.AddAttribute(35, "classid", a => a.ActiveXControlClassId, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(35, "license", a => a.License)
.AddAttribute(19, "id", a => a.Id)
.AddAttribute(35, "persistence", a => a.Persistence, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
});
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.ActiveX.ActiveXObjectProperty), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ActiveXControlData>(deep);
    }

    /// <summary>
    /// <para>Defines the ActiveXObjectProperty Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ax:ocxPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>SharedComFont &lt;ax:font></description></item>
    ///   <item><description>SharedComPicture &lt;ax:picture></description></item>
    /// </list>
    /// </remark>
    public partial class ActiveXObjectProperty : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ActiveXObjectProperty class.
        /// </summary>
        public ActiveXObjectProperty() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ActiveXObjectProperty class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ActiveXObjectProperty(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ActiveXObjectProperty class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ActiveXObjectProperty(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ActiveXObjectProperty class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ActiveXObjectProperty(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>name</para>
        /// <para>Represents the following attribute in the schema: ax:name</para>
        /// </summary>
        /// <remark>
        /// xmlns:ax=http://schemas.microsoft.com/office/2006/activeX
        /// </remark>
        public StringValue Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>value</para>
        /// <para>Represents the following attribute in the schema: ax:value</para>
        /// </summary>
        /// <remark>
        /// xmlns:ax=http://schemas.microsoft.com/office/2006/activeX
        /// </remark>
        public StringValue Value
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(35, "ocxPr");
            builder.AddChild<SharedComFont>();
            builder.AddChild<SharedComPicture>();
            builder.AddElement<ActiveXObjectProperty>()
.AddAttribute(35, "name", a => a.Name, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
})
.AddAttribute(35, "value", a => a.Value);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.ActiveX.SharedComFont), 0, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.ActiveX.SharedComPicture), 0, 1)
                }
            };
        }

        /// <summary>
        /// <para>SharedComFont.</para>
        /// <para>Represents the following element tag in the schema: ax:font.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ax = http://schemas.microsoft.com/office/2006/activeX
        /// </remark>
        public SharedComFont SharedComFont
        {
            get => GetElement<SharedComFont>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SharedComPicture.</para>
        /// <para>Represents the following element tag in the schema: ax:picture.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ax = http://schemas.microsoft.com/office/2006/activeX
        /// </remark>
        public SharedComPicture SharedComPicture
        {
            get => GetElement<SharedComPicture>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ActiveXObjectProperty>(deep);
    }

    /// <summary>
    /// <para>Defines the SharedComFont Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ax:font.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description>ActiveXObjectProperty &lt;ax:ocxPr></description></item>
    /// </list>
    /// </remark>
    public partial class SharedComFont : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SharedComFont class.
        /// </summary>
        public SharedComFont() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SharedComFont class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SharedComFont(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SharedComFont class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SharedComFont(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SharedComFont class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SharedComFont(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>persistence</para>
        /// <para>Represents the following attribute in the schema: ax:persistence</para>
        /// </summary>
        /// <remark>
        /// xmlns:ax=http://schemas.microsoft.com/office/2006/activeX
        /// </remark>
        public EnumValue<DocumentFormat.OpenXml.Office.ActiveX.PersistenceValues> Persistence
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office.ActiveX.PersistenceValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(35, "font");
            builder.AddChild<ActiveXObjectProperty>();
            builder.AddElement<SharedComFont>()
.AddAttribute(35, "persistence", a => a.Persistence)
.AddAttribute(19, "id", a => a.Id);
            builder.Particle = new CompositeParticle(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.ActiveX.ActiveXObjectProperty), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SharedComFont>(deep);
    }

    /// <summary>
    /// <para>Defines the SharedComPicture Class.</para>
    /// <para>This class is available in Office 2007 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ax:picture.</para>
    /// </summary>
    public partial class SharedComPicture : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SharedComPicture class.
        /// </summary>
        public SharedComPicture() : base()
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(35, "picture");
            builder.AddElement<SharedComPicture>()
.AddAttribute(19, "id", a => a.Id);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SharedComPicture>(deep);
    }

    /// <summary>
    /// Defines the PersistenceValues enumeration.
    /// </summary>
    public enum PersistenceValues
    {
        ///<summary>
        ///persistPropertyBag.
        ///<para>When the item is serialized out as xml, its value is "persistPropertyBag".</para>
        ///</summary>
        [EnumString("persistPropertyBag")]
        PersistPropertyBag,
        ///<summary>
        ///persistStream.
        ///<para>When the item is serialized out as xml, its value is "persistStream".</para>
        ///</summary>
        [EnumString("persistStream")]
        PersistStream,
        ///<summary>
        ///persistStreamInit.
        ///<para>When the item is serialized out as xml, its value is "persistStreamInit".</para>
        ///</summary>
        [EnumString("persistStreamInit")]
        PersistStreamInit,
        ///<summary>
        ///persistStorage.
        ///<para>When the item is serialized out as xml, its value is "persistStorage".</para>
        ///</summary>
        [EnumString("persistStorage")]
        PersistStorage,
    }
}