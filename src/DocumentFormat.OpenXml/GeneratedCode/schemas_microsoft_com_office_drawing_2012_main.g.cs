// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;

namespace DocumentFormat.OpenXml.Office2013.Drawing
{
/// <summary>
/// <para>Defines the BackgroundProperties Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a15:backgroundPr.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class BackgroundProperties : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13320;
    /// <inheritdoc/>
    public override string LocalName => "backgroundPr";
    
    internal override byte NamespaceId => 67;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>(0, "bwMode"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>(0, "bwPure"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>(0, "bwNormal"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.TargetScreenSize>>(0, "targetScreenSize")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> bwMode.</para>
    /// <para>Represents the following attribute in the schema: bwMode </para>
    /// </summary>
    [SchemaAttr(0, "bwMode")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> Mode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> bwPure.</para>
    /// <para>Represents the following attribute in the schema: bwPure </para>
    /// </summary>
    [SchemaAttr(0, "bwPure")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> Pure
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> bwNormal.</para>
    /// <para>Represents the following attribute in the schema: bwNormal </para>
    /// </summary>
    [SchemaAttr(0, "bwNormal")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> Normal
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> targetScreenSize.</para>
    /// <para>Represents the following attribute in the schema: targetScreenSize </para>
    /// </summary>
    [SchemaAttr(0, "targetScreenSize")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.TargetScreenSize> TargetScreenSize
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.TargetScreenSize>)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BackgroundProperties class.
    /// </summary>
    public BackgroundProperties():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackgroundProperties>(deep);

}
/// <summary>
/// <para>Defines the NonVisualGroupProperties Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a15:nonVisualGroupProps.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class NonVisualGroupProperties : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13321;
    /// <inheritdoc/>
    public override string LocalName => "nonVisualGroupProps";
    
    internal override byte NamespaceId => 67;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "isLegacyGroup")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> isLegacyGroup.</para>
    /// <para>Represents the following attribute in the schema: isLegacyGroup </para>
    /// </summary>
    [SchemaAttr(0, "isLegacyGroup")]
    public BooleanValue IsLegacyGroup
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the NonVisualGroupProperties class.
    /// </summary>
    public NonVisualGroupProperties():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualGroupProperties>(deep);

}
/// <summary>
/// <para>Defines the ObjectProperties Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a15:objectPr.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class ObjectProperties : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13322;
    /// <inheritdoc/>
    public override string LocalName => "objectPr";
    
    internal override byte NamespaceId => 67;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "objectId"),
		AttributeTag.Create<BooleanValue>(0, "isActiveX"),
		AttributeTag.Create<StringValue>(0, "linkType")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> objectId.</para>
    /// <para>Represents the following attribute in the schema: objectId </para>
    /// </summary>
    [SchemaAttr(0, "objectId")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> isActiveX.</para>
    /// <para>Represents the following attribute in the schema: isActiveX </para>
    /// </summary>
    [SchemaAttr(0, "isActiveX")]
    public BooleanValue IsActiveX
    {
        get { return (BooleanValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> linkType.</para>
    /// <para>Represents the following attribute in the schema: linkType </para>
    /// </summary>
    [SchemaAttr(0, "linkType")]
    public StringValue LinkType
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ObjectProperties class.
    /// </summary>
    public ObjectProperties():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ObjectProperties>(deep);

}
/// <summary>
/// <para>Defines the SignatureLine Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a15:signatureLine.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class SignatureLine : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13323;
    /// <inheritdoc/>
    public override string LocalName => "signatureLine";
    
    internal override byte NamespaceId => 67;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "isSignatureLine"),
		AttributeTag.Create<StringValue>(0, "id"),
		AttributeTag.Create<StringValue>(0, "provId"),
		AttributeTag.Create<BooleanValue>(0, "signingInstructionsSet"),
		AttributeTag.Create<BooleanValue>(0, "allowComments"),
		AttributeTag.Create<BooleanValue>(0, "showSignDate"),
		AttributeTag.Create<StringValue>(0, "suggestedSigner"),
		AttributeTag.Create<StringValue>(0, "suggestedSigner2"),
		AttributeTag.Create<StringValue>(0, "suggestedSignerEmail"),
		AttributeTag.Create<StringValue>(0, "signingInstructions"),
		AttributeTag.Create<StringValue>(0, "addlXml"),
		AttributeTag.Create<StringValue>(0, "sigProvUrl")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> isSignatureLine.</para>
    /// <para>Represents the following attribute in the schema: isSignatureLine </para>
    /// </summary>
    [SchemaAttr(0, "isSignatureLine")]
    public BooleanValue IsSignatureLine
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> provId.</para>
    /// <para>Represents the following attribute in the schema: provId </para>
    /// </summary>
    [SchemaAttr(0, "provId")]
    public StringValue ProviderId
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> signingInstructionsSet.</para>
    /// <para>Represents the following attribute in the schema: signingInstructionsSet </para>
    /// </summary>
    [SchemaAttr(0, "signingInstructionsSet")]
    public BooleanValue SigningInstructionsSet
    {
        get { return (BooleanValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> allowComments.</para>
    /// <para>Represents the following attribute in the schema: allowComments </para>
    /// </summary>
    [SchemaAttr(0, "allowComments")]
    public BooleanValue AllowComments
    {
        get { return (BooleanValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> showSignDate.</para>
    /// <para>Represents the following attribute in the schema: showSignDate </para>
    /// </summary>
    [SchemaAttr(0, "showSignDate")]
    public BooleanValue ShowSignDate
    {
        get { return (BooleanValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> suggestedSigner.</para>
    /// <para>Represents the following attribute in the schema: suggestedSigner </para>
    /// </summary>
    [SchemaAttr(0, "suggestedSigner")]
    public StringValue SuggestedSigner
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> suggestedSigner2.</para>
    /// <para>Represents the following attribute in the schema: suggestedSigner2 </para>
    /// </summary>
    [SchemaAttr(0, "suggestedSigner2")]
    public StringValue SuggestedSigner2
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> suggestedSignerEmail.</para>
    /// <para>Represents the following attribute in the schema: suggestedSignerEmail </para>
    /// </summary>
    [SchemaAttr(0, "suggestedSignerEmail")]
    public StringValue SuggestedSignerEmail
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> signingInstructions.</para>
    /// <para>Represents the following attribute in the schema: signingInstructions </para>
    /// </summary>
    [SchemaAttr(0, "signingInstructions")]
    public StringValue SigningInstructions
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> addlXml.</para>
    /// <para>Represents the following attribute in the schema: addlXml </para>
    /// </summary>
    [SchemaAttr(0, "addlXml")]
    public StringValue AdditionalXml
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> sigProvUrl.</para>
    /// <para>Represents the following attribute in the schema: sigProvUrl </para>
    /// </summary>
    [SchemaAttr(0, "sigProvUrl")]
    public StringValue SignatureProviderUrl
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SignatureLine class.
    /// </summary>
    public SignatureLine():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SignatureLine>(deep);

}
/// <summary>
/// Defines the TargetScreenSize enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
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
 
 
