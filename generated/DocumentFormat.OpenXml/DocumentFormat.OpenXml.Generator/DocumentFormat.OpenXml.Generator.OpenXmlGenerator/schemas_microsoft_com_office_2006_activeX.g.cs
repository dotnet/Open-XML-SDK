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

namespace DocumentFormat.OpenXml.Office.ActiveX
{
    /// <summary>
    /// <para>Defines the ActiveXControlData Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ax:ocx.</para>
    /// </summary>
    /// <remarks>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.ActiveX.ActiveXObjectProperty" /> <c>&lt;ax:ocxPr></c></description></item>
    /// </list>
    /// </remarks>
    public partial class ActiveXControlData : OpenXmlCompositeElement
    {
        #pragma warning disable CS0109
        internal static readonly new OpenXmlQualifiedName ElementQName = new("http://schemas.microsoft.com/office/2006/activeX", "ocx");
        internal static readonly new OpenXmlQualifiedName ElementTypeName = new("http://schemas.microsoft.com/office/2006/activeX", "CT_Ocx");
        internal static readonly new OpenXmlSchemaType ElementType = new(ElementQName, ElementTypeName);
        #pragma warning restore CS0109

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
        /// <remarks>
        /// xmlns:ax=http://schemas.microsoft.com/office/2006/activeX
        /// </remarks>
        public StringValue? ActiveXControlClassId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>license</para>
        /// <para>Represents the following attribute in the schema: ax:license</para>
        /// </summary>
        /// <remarks>
        /// xmlns:ax=http://schemas.microsoft.com/office/2006/activeX
        /// </remarks>
        public StringValue? License
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remarks>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remarks>
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>persistence</para>
        /// <para>Represents the following attribute in the schema: ax:persistence</para>
        /// </summary>
        /// <remarks>
        /// xmlns:ax=http://schemas.microsoft.com/office/2006/activeX
        /// </remarks>
        public EnumValue<DocumentFormat.OpenXml.Office.ActiveX.PersistenceValues>? Persistence
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office.ActiveX.PersistenceValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(ElementType);
            builder.AddChild(DocumentFormat.OpenXml.Office.ActiveX.ActiveXObjectProperty.ElementType, static () => new DocumentFormat.OpenXml.Office.ActiveX.ActiveXObjectProperty());
            builder.AddElement<ActiveXControlData>()
                .AddAttribute("ax:classid", a => a.ActiveXControlClassId, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("ax:license", a => a.License)
                .AddAttribute("r:id", a => a.Id)
                .AddAttribute("ax:persistence", a => a.Persistence, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(DocumentFormat.OpenXml.Office.ActiveX.ActiveXObjectProperty.ElementType, 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ActiveXControlData>(deep);
    }

    /// <summary>
    /// <para>Defines the ActiveXObjectProperty Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ax:ocxPr.</para>
    /// </summary>
    /// <remarks>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.ActiveX.SharedComFont" /> <c>&lt;ax:font></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.ActiveX.SharedComPicture" /> <c>&lt;ax:picture></c></description></item>
    /// </list>
    /// </remarks>
    public partial class ActiveXObjectProperty : OpenXmlCompositeElement
    {
        #pragma warning disable CS0109
        internal static readonly new OpenXmlQualifiedName ElementQName = new("http://schemas.microsoft.com/office/2006/activeX", "ocxPr");
        internal static readonly new OpenXmlQualifiedName ElementTypeName = new("http://schemas.microsoft.com/office/2006/activeX", "CT_OcxPr");
        internal static readonly new OpenXmlSchemaType ElementType = new(ElementQName, ElementTypeName);
        #pragma warning restore CS0109

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
        /// <remarks>
        /// xmlns:ax=http://schemas.microsoft.com/office/2006/activeX
        /// </remarks>
        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>value</para>
        /// <para>Represents the following attribute in the schema: ax:value</para>
        /// </summary>
        /// <remarks>
        /// xmlns:ax=http://schemas.microsoft.com/office/2006/activeX
        /// </remarks>
        public StringValue? Value
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(ElementType);
            builder.AddChild(DocumentFormat.OpenXml.Office.ActiveX.SharedComFont.ElementType, static () => new DocumentFormat.OpenXml.Office.ActiveX.SharedComFont());
            builder.AddChild(DocumentFormat.OpenXml.Office.ActiveX.SharedComPicture.ElementType, static () => new DocumentFormat.OpenXml.Office.ActiveX.SharedComPicture());
            builder.AddElement<ActiveXObjectProperty>()
                .AddAttribute("ax:name", a => a.Name, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("ax:value", a => a.Value);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(DocumentFormat.OpenXml.Office.ActiveX.SharedComFont.ElementType, 0, 1),
                    new ElementParticle(DocumentFormat.OpenXml.Office.ActiveX.SharedComPicture.ElementType, 0, 1)
                }
            };
        }

        /// <summary>
        /// <para>SharedComFont.</para>
        /// <para>Represents the following element tag in the schema: ax:font.</para>
        /// </summary>
        /// <remarks>
        /// xmlns:ax = http://schemas.microsoft.com/office/2006/activeX
        /// </remarks>
        public DocumentFormat.OpenXml.Office.ActiveX.SharedComFont? SharedComFont
        {
            get => GetElement(DocumentFormat.OpenXml.Office.ActiveX.SharedComFont.ElementType) as DocumentFormat.OpenXml.Office.ActiveX.SharedComFont;
            set => SetElement(value, DocumentFormat.OpenXml.Office.ActiveX.SharedComFont.ElementType);
        }

        /// <summary>
        /// <para>SharedComPicture.</para>
        /// <para>Represents the following element tag in the schema: ax:picture.</para>
        /// </summary>
        /// <remarks>
        /// xmlns:ax = http://schemas.microsoft.com/office/2006/activeX
        /// </remarks>
        public DocumentFormat.OpenXml.Office.ActiveX.SharedComPicture? SharedComPicture
        {
            get => GetElement(DocumentFormat.OpenXml.Office.ActiveX.SharedComPicture.ElementType) as DocumentFormat.OpenXml.Office.ActiveX.SharedComPicture;
            set => SetElement(value, DocumentFormat.OpenXml.Office.ActiveX.SharedComPicture.ElementType);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ActiveXObjectProperty>(deep);
    }

    /// <summary>
    /// <para>Defines the SharedComFont Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ax:font.</para>
    /// </summary>
    /// <remarks>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.ActiveX.ActiveXObjectProperty" /> <c>&lt;ax:ocxPr></c></description></item>
    /// </list>
    /// </remarks>
    public partial class SharedComFont : OpenXmlCompositeElement
    {
        #pragma warning disable CS0109
        internal static readonly new OpenXmlQualifiedName ElementQName = new("http://schemas.microsoft.com/office/2006/activeX", "font");
        internal static readonly new OpenXmlQualifiedName ElementTypeName = new("http://schemas.microsoft.com/office/2006/activeX", "CT_Font");
        internal static readonly new OpenXmlSchemaType ElementType = new(ElementQName, ElementTypeName);
        #pragma warning restore CS0109

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
        /// <remarks>
        /// xmlns:ax=http://schemas.microsoft.com/office/2006/activeX
        /// </remarks>
        public EnumValue<DocumentFormat.OpenXml.Office.ActiveX.PersistenceValues>? Persistence
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office.ActiveX.PersistenceValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remarks>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remarks>
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(ElementType);
            builder.AddChild(DocumentFormat.OpenXml.Office.ActiveX.ActiveXObjectProperty.ElementType, static () => new DocumentFormat.OpenXml.Office.ActiveX.ActiveXObjectProperty());
            builder.AddElement<SharedComFont>()
                .AddAttribute("ax:persistence", a => a.Persistence)
                .AddAttribute("r:id", a => a.Id);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(DocumentFormat.OpenXml.Office.ActiveX.ActiveXObjectProperty.ElementType, 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SharedComFont>(deep);
    }

    /// <summary>
    /// <para>Defines the SharedComPicture Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ax:picture.</para>
    /// </summary>
    public partial class SharedComPicture : OpenXmlLeafElement
    {
        #pragma warning disable CS0109
        internal static readonly new OpenXmlQualifiedName ElementQName = new("http://schemas.microsoft.com/office/2006/activeX", "picture");
        internal static readonly new OpenXmlQualifiedName ElementTypeName = new("http://schemas.microsoft.com/office/2006/activeX", "CT_Picture");
        internal static readonly new OpenXmlSchemaType ElementType = new(ElementQName, ElementTypeName);
        #pragma warning restore CS0109

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
        /// <remarks>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remarks>
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(ElementType);
            builder.AddElement<SharedComPicture>()
                .AddAttribute("r:id", a => a.Id);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SharedComPicture>(deep);
    }

    /// <summary>
    /// Defines the PersistenceValues enumeration.
    /// </summary>
    public readonly record struct PersistenceValues : IEnumValue, IEnumValueFactory<PersistenceValues>
    {
        private readonly string? _value;
        /// <summary>
        /// Creates a new PersistenceValues enum instance
        /// </summary>
        public PersistenceValues(string value) => _value = value;
        PersistenceValues IEnumValueFactory<PersistenceValues>.Create(string name) => new(name);
        bool IEnumValue.IsValid => InternalValue switch
        {
            "persistPropertyBag" => true,
            "persistStream" => true,
            "persistStreamInit" => true,
            "persistStorage" => true,
            _ => false
        };
        string IEnumValue.Value => InternalValue;
        private string InternalValue => _value ?? "persistPropertyBag";
        FileFormatVersions IEnumValue.Version => FileFormatVersions.Office2007;
        /// <summary>
        /// persistPropertyBag.
        /// <para>When the item is serialized out as xml, its value is "persistPropertyBag".</para>
        /// </summary>
        public static PersistenceValues PersistPropertyBag => new("persistPropertyBag");
        /// <summary>
        /// persistStream.
        /// <para>When the item is serialized out as xml, its value is "persistStream".</para>
        /// </summary>
        public static PersistenceValues PersistStream => new("persistStream");
        /// <summary>
        /// persistStreamInit.
        /// <para>When the item is serialized out as xml, its value is "persistStreamInit".</para>
        /// </summary>
        public static PersistenceValues PersistStreamInit => new("persistStreamInit");
        /// <summary>
        /// persistStorage.
        /// <para>When the item is serialized out as xml, its value is "persistStorage".</para>
        /// </summary>
        public static PersistenceValues PersistStorage => new("persistStorage");
    
    }
}