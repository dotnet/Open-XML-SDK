﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2013.Drawing
{
    /// <summary>
    /// <para>Defines the BackgroundProperties Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a15:backgroundPr.</para>
    /// </summary>
    [SchemaAttr(67, "backgroundPr")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class BackgroundProperties : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BackgroundProperties class.
        /// </summary>
        public BackgroundProperties() : base()
        {
        }

        /// <summary>
        /// <para>bwMode, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: bwMode</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "bwMode")]
        [Index(0)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> Mode { get; set; }

        /// <summary>
        /// <para>bwPure, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: bwPure</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "bwPure")]
        [Index(1)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> Pure { get; set; }

        /// <summary>
        /// <para>bwNormal, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: bwNormal</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "bwNormal")]
        [Index(2)]
        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> Normal { get; set; }

        /// <summary>
        /// <para>targetScreenSize, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: targetScreenSize</para>
        /// </summary>
        [StringValidator(IsToken = true)]
        [SchemaAttr(0, "targetScreenSize")]
        [Index(3)]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.TargetScreenSize> TargetScreenSize { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackgroundProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the NonVisualGroupProperties Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a15:nonVisualGroupProps.</para>
    /// </summary>
    [SchemaAttr(67, "nonVisualGroupProps")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class NonVisualGroupProperties : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualGroupProperties class.
        /// </summary>
        public NonVisualGroupProperties() : base()
        {
        }

        /// <summary>
        /// <para>isLegacyGroup, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: isLegacyGroup</para>
        /// </summary>
        [SchemaAttr(0, "isLegacyGroup")]
        [Index(0)]
        public BooleanValue IsLegacyGroup { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualGroupProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the ObjectProperties Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a15:objectPr.</para>
    /// </summary>
    [SchemaAttr(67, "objectPr")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class ObjectProperties : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ObjectProperties class.
        /// </summary>
        public ObjectProperties() : base()
        {
        }

        /// <summary>
        /// <para>objectId, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: objectId</para>
        /// </summary>
        [SchemaAttr(0, "objectId")]
        [Index(0)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>isActiveX, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: isActiveX</para>
        /// </summary>
        [SchemaAttr(0, "isActiveX")]
        [Index(1)]
        public BooleanValue IsActiveX { get; set; }

        /// <summary>
        /// <para>linkType, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: linkType</para>
        /// </summary>
        [SchemaAttr(0, "linkType")]
        [Index(2)]
        public StringValue LinkType { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ObjectProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the SignatureLine Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a15:signatureLine.</para>
    /// </summary>
    [SchemaAttr(67, "signatureLine")]
    [OfficeAvailability(FileFormatVersions.Office2013)]
    public partial class SignatureLine : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SignatureLine class.
        /// </summary>
        public SignatureLine() : base()
        {
        }

        /// <summary>
        /// <para>isSignatureLine, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: isSignatureLine</para>
        /// </summary>
        [SchemaAttr(0, "isSignatureLine")]
        [Index(0)]
        public BooleanValue IsSignatureLine { get; set; }

        /// <summary>
        /// <para>id, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [StringValidator(IsToken = true, Pattern = "\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}")]
        [SchemaAttr(0, "id")]
        [Index(1)]
        public StringValue Id { get; set; }

        /// <summary>
        /// <para>provId, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: provId</para>
        /// </summary>
        [StringValidator(IsToken = true, Pattern = "\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}")]
        [SchemaAttr(0, "provId")]
        [Index(2)]
        public StringValue ProviderId { get; set; }

        /// <summary>
        /// <para>signingInstructionsSet, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: signingInstructionsSet</para>
        /// </summary>
        [SchemaAttr(0, "signingInstructionsSet")]
        [Index(3)]
        public BooleanValue SigningInstructionsSet { get; set; }

        /// <summary>
        /// <para>allowComments, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: allowComments</para>
        /// </summary>
        [SchemaAttr(0, "allowComments")]
        [Index(4)]
        public BooleanValue AllowComments { get; set; }

        /// <summary>
        /// <para>showSignDate, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showSignDate</para>
        /// </summary>
        [SchemaAttr(0, "showSignDate")]
        [Index(5)]
        public BooleanValue ShowSignDate { get; set; }

        /// <summary>
        /// <para>suggestedSigner, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: suggestedSigner</para>
        /// </summary>
        [SchemaAttr(0, "suggestedSigner")]
        [Index(6)]
        public StringValue SuggestedSigner { get; set; }

        /// <summary>
        /// <para>suggestedSigner2, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: suggestedSigner2</para>
        /// </summary>
        [SchemaAttr(0, "suggestedSigner2")]
        [Index(7)]
        public StringValue SuggestedSigner2 { get; set; }

        /// <summary>
        /// <para>suggestedSignerEmail, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: suggestedSignerEmail</para>
        /// </summary>
        [SchemaAttr(0, "suggestedSignerEmail")]
        [Index(8)]
        public StringValue SuggestedSignerEmail { get; set; }

        /// <summary>
        /// <para>signingInstructions, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: signingInstructions</para>
        /// </summary>
        [SchemaAttr(0, "signingInstructions")]
        [Index(9)]
        public StringValue SigningInstructions { get; set; }

        /// <summary>
        /// <para>addlXml, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: addlXml</para>
        /// </summary>
        [SchemaAttr(0, "addlXml")]
        [Index(10)]
        public StringValue AdditionalXml { get; set; }

        /// <summary>
        /// <para>sigProvUrl, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sigProvUrl</para>
        /// </summary>
        [SchemaAttr(0, "sigProvUrl")]
        [Index(11)]
        public StringValue SignatureProviderUrl { get; set; }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SignatureLine>(deep);
    }

    /// <summary>
    /// Defines the TargetScreenSize enumeration.
    /// </summary>
    public enum TargetScreenSize
    {
        ///<summary>
        ///544x376.
        ///<para>When the item is serialized out as xml, its value is "544x376".</para>
        ///</summary>
        [EnumString("544x376")]
        Sz544x376,
        ///<summary>
        ///640x480.
        ///<para>When the item is serialized out as xml, its value is "640x480".</para>
        ///</summary>
        [EnumString("640x480")]
        Sz640x480,
        ///<summary>
        ///720x512.
        ///<para>When the item is serialized out as xml, its value is "720x512".</para>
        ///</summary>
        [EnumString("720x512")]
        Sz720x512,
        ///<summary>
        ///800x600.
        ///<para>When the item is serialized out as xml, its value is "800x600".</para>
        ///</summary>
        [EnumString("800x600")]
        Sz800x600,
        ///<summary>
        ///1024x768.
        ///<para>When the item is serialized out as xml, its value is "1024x768".</para>
        ///</summary>
        [EnumString("1024x768")]
        Sz1024x768,
        ///<summary>
        ///1152x882.
        ///<para>When the item is serialized out as xml, its value is "1152x882".</para>
        ///</summary>
        [EnumString("1152x882")]
        Sz1152x882,
        ///<summary>
        ///1152x900.
        ///<para>When the item is serialized out as xml, its value is "1152x900".</para>
        ///</summary>
        [EnumString("1152x900")]
        Sz1152x900,
        ///<summary>
        ///1280x1024.
        ///<para>When the item is serialized out as xml, its value is "1280x1024".</para>
        ///</summary>
        [EnumString("1280x1024")]
        Sz1280x1024,
        ///<summary>
        ///1600x1200.
        ///<para>When the item is serialized out as xml, its value is "1600x1200".</para>
        ///</summary>
        [EnumString("1600x1200")]
        Sz1600x1200,
        ///<summary>
        ///1800x1440.
        ///<para>When the item is serialized out as xml, its value is "1800x1440".</para>
        ///</summary>
        [EnumString("1800x1440")]
        Sz1800x1440,
        ///<summary>
        ///1920x1200.
        ///<para>When the item is serialized out as xml, its value is "1920x1200".</para>
        ///</summary>
        [EnumString("1920x1200")]
        Sz1920x1200,
    }
}