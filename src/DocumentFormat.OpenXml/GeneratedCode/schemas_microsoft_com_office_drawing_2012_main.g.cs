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

namespace DocumentFormat.OpenXml.Office2013.Drawing
{
    /// <summary>
    /// <para>Defines the BackgroundProperties Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a15:backgroundPr.</para>
    /// </summary>
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
        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> Mode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>bwPure, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: bwPure</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> Pure
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>bwNormal, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: bwNormal</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> Normal
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>targetScreenSize, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: targetScreenSize</para>
        /// </summary>
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.TargetScreenSize> TargetScreenSize
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.TargetScreenSize>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(67, "backgroundPr");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<BackgroundProperties>()
.AddAttribute(0, "bwMode", a => a.Mode, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "bwPure", a => a.Pure, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "bwNormal", a => a.Normal, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
})
.AddAttribute(0, "targetScreenSize", a => a.TargetScreenSize, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackgroundProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the NonVisualGroupProperties Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a15:nonVisualGroupProps.</para>
    /// </summary>
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
        public BooleanValue IsLegacyGroup
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(67, "nonVisualGroupProps");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<NonVisualGroupProperties>()
.AddAttribute(0, "isLegacyGroup", a => a.IsLegacyGroup);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualGroupProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the ObjectProperties Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a15:objectPr.</para>
    /// </summary>
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
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>isActiveX, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: isActiveX</para>
        /// </summary>
        public BooleanValue IsActiveX
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>linkType, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: linkType</para>
        /// </summary>
        public StringValue LinkType
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(67, "objectPr");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<ObjectProperties>()
.AddAttribute(0, "objectId", a => a.Id)
.AddAttribute(0, "isActiveX", a => a.IsActiveX)
.AddAttribute(0, "linkType", a => a.LinkType);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ObjectProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the SignatureLine Class.</para>
    /// <para>This class is available in Office 2013 or above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a15:signatureLine.</para>
    /// </summary>
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
        public BooleanValue IsSignatureLine
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>provId, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: provId</para>
        /// </summary>
        public StringValue ProviderId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>signingInstructionsSet, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: signingInstructionsSet</para>
        /// </summary>
        public BooleanValue SigningInstructionsSet
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>allowComments, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: allowComments</para>
        /// </summary>
        public BooleanValue AllowComments
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showSignDate, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: showSignDate</para>
        /// </summary>
        public BooleanValue ShowSignDate
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>suggestedSigner, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: suggestedSigner</para>
        /// </summary>
        public StringValue SuggestedSigner
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>suggestedSigner2, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: suggestedSigner2</para>
        /// </summary>
        public StringValue SuggestedSigner2
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>suggestedSignerEmail, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: suggestedSignerEmail</para>
        /// </summary>
        public StringValue SuggestedSignerEmail
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>signingInstructions, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: signingInstructions</para>
        /// </summary>
        public StringValue SigningInstructions
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>addlXml, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: addlXml</para>
        /// </summary>
        public StringValue AdditionalXml
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sigProvUrl, this property is only available in Office2013, Office2016</para>
        /// <para>Represents the following attribute in the schema: sigProvUrl</para>
        /// </summary>
        public StringValue SignatureProviderUrl
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(67, "signatureLine");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<SignatureLine>()
.AddAttribute(0, "isSignatureLine", a => a.IsSignatureLine)
.AddAttribute(0, "id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "provId", a => a.ProviderId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
})
.AddAttribute(0, "signingInstructionsSet", a => a.SigningInstructionsSet)
.AddAttribute(0, "allowComments", a => a.AllowComments)
.AddAttribute(0, "showSignDate", a => a.ShowSignDate)
.AddAttribute(0, "suggestedSigner", a => a.SuggestedSigner)
.AddAttribute(0, "suggestedSigner2", a => a.SuggestedSigner2)
.AddAttribute(0, "suggestedSignerEmail", a => a.SuggestedSignerEmail)
.AddAttribute(0, "signingInstructions", a => a.SigningInstructions)
.AddAttribute(0, "addlXml", a => a.AdditionalXml)
.AddAttribute(0, "sigProvUrl", a => a.SignatureProviderUrl);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SignatureLine>(deep);
    }

    /// <summary>
    /// Defines the TargetScreenSize enumeration.
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2013)]
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