﻿// <auto-generated/>

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

namespace DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage
{
    /// <summary>
    /// <para>Defines the WebImagesSupportingRichData Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrdwi:webImagesSrd.</para>
    /// </summary>
    /// <remarks>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage.ExtensionList" /> <c>&lt;xlrdwi:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage.WebImageSupportingRichData" /> <c>&lt;xlrdwi:webImageSrd></c></description></item>
    /// </list>
    /// </remarks>
    public partial class WebImagesSupportingRichData : OpenXmlPartRootElement
    {
        #pragma warning disable CS0109
        internal static readonly new OpenXmlQualifiedName ElementQName = new("http://schemas.microsoft.com/office/spreadsheetml/2020/richdatawebimage", "webImagesSrd");
        internal static readonly new OpenXmlQualifiedName ElementTypeName = new("http://schemas.microsoft.com/office/spreadsheetml/2020/richdatawebimage", "CT_WebImagesSupportingRichData");
        internal static readonly new OpenXmlSchemaType ElementType = new(ElementQName, ElementTypeName);
        #pragma warning restore CS0109

        /// <summary>
        /// Initializes a new instance of the WebImagesSupportingRichData class.
        /// </summary>
        public WebImagesSupportingRichData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebImagesSupportingRichData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WebImagesSupportingRichData(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebImagesSupportingRichData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WebImagesSupportingRichData(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebImagesSupportingRichData class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public WebImagesSupportingRichData(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(ElementType);
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild(DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage.ExtensionList.ElementType, static () => new DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage.ExtensionList());
            builder.AddChild(DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage.WebImageSupportingRichData.ElementType, static () => new DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage.WebImageSupportingRichData());
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage.WebImageSupportingRichData.ElementType, 0, 0, version: FileFormatVersions.Office2021),
                new ElementParticle(DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage.ExtensionList.ElementType, 0, 1, version: FileFormatVersions.Office2021)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebImagesSupportingRichData>(deep);

        internal WebImagesSupportingRichData(RdRichValueWebImagePart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the RdRichValueWebImagePart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(RdRichValueWebImagePart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the RdRichValueWebImagePart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(RdRichValueWebImagePart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the RdRichValueWebImagePart associated with this element.
        /// </summary>
        public RdRichValueWebImagePart? RdRichValueWebImagePart
        {
            get => OpenXmlPart as RdRichValueWebImagePart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the WebImageSupportingRichData Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrdwi:webImageSrd.</para>
    /// </summary>
    /// <remarks>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage.AddressWebImageSupportingRichDataRelationship" /> <c>&lt;xlrdwi:address></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage.MoreImagesAddressWebImageSupportingRichDataRelationship" /> <c>&lt;xlrdwi:moreImagesAddress></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage.BlipWebImageSupportingRichDataRelationship" /> <c>&lt;xlrdwi:blip></c></description></item>
    /// </list>
    /// </remarks>
    public partial class WebImageSupportingRichData : OpenXmlCompositeElement
    {
        #pragma warning disable CS0109
        internal static readonly new OpenXmlQualifiedName ElementQName = new("http://schemas.microsoft.com/office/spreadsheetml/2020/richdatawebimage", "webImageSrd");
        internal static readonly new OpenXmlQualifiedName ElementTypeName = new("http://schemas.microsoft.com/office/spreadsheetml/2020/richdatawebimage", "CT_WebImageSupportingRichData");
        internal static readonly new OpenXmlSchemaType ElementType = new(ElementQName, ElementTypeName);
        #pragma warning restore CS0109

        /// <summary>
        /// Initializes a new instance of the WebImageSupportingRichData class.
        /// </summary>
        public WebImageSupportingRichData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebImageSupportingRichData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WebImageSupportingRichData(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebImageSupportingRichData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WebImageSupportingRichData(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebImageSupportingRichData class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public WebImageSupportingRichData(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(ElementType);
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild(DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage.AddressWebImageSupportingRichDataRelationship.ElementType, static () => new DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage.AddressWebImageSupportingRichDataRelationship());
            builder.AddChild(DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage.MoreImagesAddressWebImageSupportingRichDataRelationship.ElementType, static () => new DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage.MoreImagesAddressWebImageSupportingRichDataRelationship());
            builder.AddChild(DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage.BlipWebImageSupportingRichDataRelationship.ElementType, static () => new DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage.BlipWebImageSupportingRichDataRelationship());
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage.AddressWebImageSupportingRichDataRelationship.ElementType, 1, 1, version: FileFormatVersions.Office2021),
                new ElementParticle(DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage.MoreImagesAddressWebImageSupportingRichDataRelationship.ElementType, 0, 1, version: FileFormatVersions.Office2021),
                new ElementParticle(DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage.BlipWebImageSupportingRichDataRelationship.ElementType, 0, 1, version: FileFormatVersions.Office2021)
            };
        }

        /// <summary>
        /// <para>AddressWebImageSupportingRichDataRelationship.</para>
        /// <para>Represents the following element tag in the schema: xlrdwi:address.</para>
        /// </summary>
        /// <remarks>
        /// xmlns:xlrdwi = http://schemas.microsoft.com/office/spreadsheetml/2020/richdatawebimage
        /// </remarks>
        public DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage.AddressWebImageSupportingRichDataRelationship? AddressWebImageSupportingRichDataRelationship
        {
            get => GetElement(DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage.AddressWebImageSupportingRichDataRelationship.ElementType) as DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage.AddressWebImageSupportingRichDataRelationship;
            set => SetElement(value, DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage.AddressWebImageSupportingRichDataRelationship.ElementType);
        }

        /// <summary>
        /// <para>MoreImagesAddressWebImageSupportingRichDataRelationship.</para>
        /// <para>Represents the following element tag in the schema: xlrdwi:moreImagesAddress.</para>
        /// </summary>
        /// <remarks>
        /// xmlns:xlrdwi = http://schemas.microsoft.com/office/spreadsheetml/2020/richdatawebimage
        /// </remarks>
        public DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage.MoreImagesAddressWebImageSupportingRichDataRelationship? MoreImagesAddressWebImageSupportingRichDataRelationship
        {
            get => GetElement(DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage.MoreImagesAddressWebImageSupportingRichDataRelationship.ElementType) as DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage.MoreImagesAddressWebImageSupportingRichDataRelationship;
            set => SetElement(value, DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage.MoreImagesAddressWebImageSupportingRichDataRelationship.ElementType);
        }

        /// <summary>
        /// <para>BlipWebImageSupportingRichDataRelationship.</para>
        /// <para>Represents the following element tag in the schema: xlrdwi:blip.</para>
        /// </summary>
        /// <remarks>
        /// xmlns:xlrdwi = http://schemas.microsoft.com/office/spreadsheetml/2020/richdatawebimage
        /// </remarks>
        public DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage.BlipWebImageSupportingRichDataRelationship? BlipWebImageSupportingRichDataRelationship
        {
            get => GetElement(DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage.BlipWebImageSupportingRichDataRelationship.ElementType) as DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage.BlipWebImageSupportingRichDataRelationship;
            set => SetElement(value, DocumentFormat.OpenXml.Office2021.Excel.RichDataWebImage.BlipWebImageSupportingRichDataRelationship.ElementType);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebImageSupportingRichData>(deep);
    }

    /// <summary>
    /// <para>Defines the ExtensionList Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrdwi:extLst.</para>
    /// </summary>
    /// <remarks>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.Extension" /> <c>&lt;x:ext></c></description></item>
    /// </list>
    /// </remarks>
    public partial class ExtensionList : OpenXmlCompositeElement
    {
        #pragma warning disable CS0109
        internal static readonly new OpenXmlQualifiedName ElementQName = new("http://schemas.microsoft.com/office/spreadsheetml/2020/richdatawebimage", "extLst");
        internal static readonly new OpenXmlQualifiedName ElementTypeName = new("http://schemas.openxmlformats.org/spreadsheetml/2006/main", "CT_ExtensionList");
        internal static readonly new OpenXmlSchemaType ElementType = new(ElementQName, ElementTypeName);
        #pragma warning restore CS0109

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
            builder.SetSchema(ElementType);
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild(DocumentFormat.OpenXml.Spreadsheet.Extension.ElementType, static () => new DocumentFormat.OpenXml.Spreadsheet.Extension());
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(DocumentFormat.OpenXml.Spreadsheet.Extension.ElementType, 0, 0)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the AddressWebImageSupportingRichDataRelationship Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrdwi:address.</para>
    /// </summary>
    public partial class AddressWebImageSupportingRichDataRelationship : OpenXmlWebImageSupportingRichDataRelationshipElement
    {
        #pragma warning disable CS0109
        internal static readonly new OpenXmlQualifiedName ElementQName = new("http://schemas.microsoft.com/office/spreadsheetml/2020/richdatawebimage", "address");
        internal static readonly new OpenXmlQualifiedName ElementTypeName = new("http://schemas.microsoft.com/office/spreadsheetml/2020/richdatawebimage", "CT_WebImageSupportingRichDataRelationship");
        internal static readonly new OpenXmlSchemaType ElementType = new(ElementQName, ElementTypeName);
        #pragma warning restore CS0109

        /// <summary>
        /// Initializes a new instance of the AddressWebImageSupportingRichDataRelationship class.
        /// </summary>
        public AddressWebImageSupportingRichDataRelationship() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(ElementType);
            builder.Availability = FileFormatVersions.Office2021;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AddressWebImageSupportingRichDataRelationship>(deep);
    }

    /// <summary>
    /// <para>Defines the MoreImagesAddressWebImageSupportingRichDataRelationship Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrdwi:moreImagesAddress.</para>
    /// </summary>
    public partial class MoreImagesAddressWebImageSupportingRichDataRelationship : OpenXmlWebImageSupportingRichDataRelationshipElement
    {
        #pragma warning disable CS0109
        internal static readonly new OpenXmlQualifiedName ElementQName = new("http://schemas.microsoft.com/office/spreadsheetml/2020/richdatawebimage", "moreImagesAddress");
        internal static readonly new OpenXmlQualifiedName ElementTypeName = new("http://schemas.microsoft.com/office/spreadsheetml/2020/richdatawebimage", "CT_WebImageSupportingRichDataRelationship");
        internal static readonly new OpenXmlSchemaType ElementType = new(ElementQName, ElementTypeName);
        #pragma warning restore CS0109

        /// <summary>
        /// Initializes a new instance of the MoreImagesAddressWebImageSupportingRichDataRelationship class.
        /// </summary>
        public MoreImagesAddressWebImageSupportingRichDataRelationship() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(ElementType);
            builder.Availability = FileFormatVersions.Office2021;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MoreImagesAddressWebImageSupportingRichDataRelationship>(deep);
    }

    /// <summary>
    /// <para>Defines the BlipWebImageSupportingRichDataRelationship Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrdwi:blip.</para>
    /// </summary>
    public partial class BlipWebImageSupportingRichDataRelationship : OpenXmlWebImageSupportingRichDataRelationshipElement
    {
        #pragma warning disable CS0109
        internal static readonly new OpenXmlQualifiedName ElementQName = new("http://schemas.microsoft.com/office/spreadsheetml/2020/richdatawebimage", "blip");
        internal static readonly new OpenXmlQualifiedName ElementTypeName = new("http://schemas.microsoft.com/office/spreadsheetml/2020/richdatawebimage", "CT_WebImageSupportingRichDataRelationship");
        internal static readonly new OpenXmlSchemaType ElementType = new(ElementQName, ElementTypeName);
        #pragma warning restore CS0109

        /// <summary>
        /// Initializes a new instance of the BlipWebImageSupportingRichDataRelationship class.
        /// </summary>
        public BlipWebImageSupportingRichDataRelationship() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(ElementType);
            builder.Availability = FileFormatVersions.Office2021;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BlipWebImageSupportingRichDataRelationship>(deep);
    }

    /// <summary>
    /// <para>Defines the OpenXmlWebImageSupportingRichDataRelationshipElement Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class OpenXmlWebImageSupportingRichDataRelationshipElement : OpenXmlLeafElement
    {
        #pragma warning disable CS0109
        internal static readonly new OpenXmlQualifiedName ElementQName = new(string.Empty, string.Empty);
        internal static readonly new OpenXmlQualifiedName ElementTypeName = new("http://schemas.microsoft.com/office/spreadsheetml/2020/richdatawebimage", "CT_WebImageSupportingRichDataRelationship");
        internal static readonly new OpenXmlSchemaType ElementType = new(ElementQName, ElementTypeName);
        #pragma warning restore CS0109

        /// <summary>
        /// Initializes a new instance of the OpenXmlWebImageSupportingRichDataRelationshipElement class.
        /// </summary>
        protected OpenXmlWebImageSupportingRichDataRelationshipElement() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2021 and later.</para>
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
            builder.AddElement<OpenXmlWebImageSupportingRichDataRelationshipElement>()
                .AddAttribute("r:id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }
    }
}