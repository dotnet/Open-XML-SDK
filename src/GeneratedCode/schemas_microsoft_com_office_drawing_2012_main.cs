// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
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
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is a15:backgroundPr.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class BackgroundProperties : OpenXmlLeafElement
{
    private const string tagName = "backgroundPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 67;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13320;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "bwMode","bwPure","bwNormal","targetScreenSize" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> bwMode.</para>
    /// <para>Represents the following attribute in the schema: bwMode </para>
    /// </summary>
    [SchemaAttr(0, "bwMode")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> Mode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> bwPure.</para>
    /// <para>Represents the following attribute in the schema: bwPure </para>
    /// </summary>
    [SchemaAttr(0, "bwPure")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> Pure
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> bwNormal.</para>
    /// <para>Represents the following attribute in the schema: bwNormal </para>
    /// </summary>
    [SchemaAttr(0, "bwNormal")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> Normal
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> targetScreenSize.</para>
    /// <para>Represents the following attribute in the schema: targetScreenSize </para>
    /// </summary>
    [SchemaAttr(0, "targetScreenSize")]
    public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.TargetScreenSize> TargetScreenSize
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.TargetScreenSize>)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BackgroundProperties class.
    /// </summary>
    public BackgroundProperties():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "bwMode" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>();
    
if( 0 == namespaceId && "bwPure" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>();
    
if( 0 == namespaceId && "bwNormal" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>();
    
if( 0 == namespaceId && "targetScreenSize" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.TargetScreenSize>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<BackgroundProperties>(deep);
    }

   
}
/// <summary>
/// <para>Defines the NonVisualGroupProperties Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is a15:nonVisualGroupProps.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class NonVisualGroupProperties : OpenXmlLeafElement
{
    private const string tagName = "nonVisualGroupProps";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 67;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13321;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "isLegacyGroup" };
    private static byte[] attributeNamespaceIds = { 0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> isLegacyGroup.</para>
    /// <para>Represents the following attribute in the schema: isLegacyGroup </para>
    /// </summary>
    [SchemaAttr(0, "isLegacyGroup")]
    public BooleanValue IsLegacyGroup
    {
        get { return (BooleanValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the NonVisualGroupProperties class.
    /// </summary>
    public NonVisualGroupProperties():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "isLegacyGroup" == name)
    return new BooleanValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<NonVisualGroupProperties>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ObjectProperties Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is a15:objectPr.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class ObjectProperties : OpenXmlLeafElement
{
    private const string tagName = "objectPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 67;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13322;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "objectId","isActiveX","linkType" };
    private static byte[] attributeNamespaceIds = { 0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> objectId.</para>
    /// <para>Represents the following attribute in the schema: objectId </para>
    /// </summary>
    [SchemaAttr(0, "objectId")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> isActiveX.</para>
    /// <para>Represents the following attribute in the schema: isActiveX </para>
    /// </summary>
    [SchemaAttr(0, "isActiveX")]
    public BooleanValue IsActiveX
    {
        get { return (BooleanValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> linkType.</para>
    /// <para>Represents the following attribute in the schema: linkType </para>
    /// </summary>
    [SchemaAttr(0, "linkType")]
    public StringValue LinkType
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ObjectProperties class.
    /// </summary>
    public ObjectProperties():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "objectId" == name)
    return new StringValue();
    
if( 0 == namespaceId && "isActiveX" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "linkType" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ObjectProperties>(deep);
    }

   
}
/// <summary>
/// <para>Defines the SignatureLine Class.</para>
///<para>This class is only available in Office2013.</para>
/// <para> When the object is serialized out as xml, its qualified name is a15:signatureLine.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class SignatureLine : OpenXmlLeafElement
{
    private const string tagName = "signatureLine";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 67;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13323;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((4 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "isSignatureLine","id","provId","signingInstructionsSet","allowComments","showSignDate","suggestedSigner","suggestedSigner2","suggestedSignerEmail","signingInstructions","addlXml","sigProvUrl" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> isSignatureLine.</para>
    /// <para>Represents the following attribute in the schema: isSignatureLine </para>
    /// </summary>
    [SchemaAttr(0, "isSignatureLine")]
    public BooleanValue IsSignatureLine
    {
        get { return (BooleanValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> provId.</para>
    /// <para>Represents the following attribute in the schema: provId </para>
    /// </summary>
    [SchemaAttr(0, "provId")]
    public StringValue ProviderId
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> signingInstructionsSet.</para>
    /// <para>Represents the following attribute in the schema: signingInstructionsSet </para>
    /// </summary>
    [SchemaAttr(0, "signingInstructionsSet")]
    public BooleanValue SigningInstructionsSet
    {
        get { return (BooleanValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> allowComments.</para>
    /// <para>Represents the following attribute in the schema: allowComments </para>
    /// </summary>
    [SchemaAttr(0, "allowComments")]
    public BooleanValue AllowComments
    {
        get { return (BooleanValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> showSignDate.</para>
    /// <para>Represents the following attribute in the schema: showSignDate </para>
    /// </summary>
    [SchemaAttr(0, "showSignDate")]
    public BooleanValue ShowSignDate
    {
        get { return (BooleanValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> suggestedSigner.</para>
    /// <para>Represents the following attribute in the schema: suggestedSigner </para>
    /// </summary>
    [SchemaAttr(0, "suggestedSigner")]
    public StringValue SuggestedSigner
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> suggestedSigner2.</para>
    /// <para>Represents the following attribute in the schema: suggestedSigner2 </para>
    /// </summary>
    [SchemaAttr(0, "suggestedSigner2")]
    public StringValue SuggestedSigner2
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> suggestedSignerEmail.</para>
    /// <para>Represents the following attribute in the schema: suggestedSignerEmail </para>
    /// </summary>
    [SchemaAttr(0, "suggestedSignerEmail")]
    public StringValue SuggestedSignerEmail
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> signingInstructions.</para>
    /// <para>Represents the following attribute in the schema: signingInstructions </para>
    /// </summary>
    [SchemaAttr(0, "signingInstructions")]
    public StringValue SigningInstructions
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> addlXml.</para>
    /// <para>Represents the following attribute in the schema: addlXml </para>
    /// </summary>
    [SchemaAttr(0, "addlXml")]
    public StringValue AdditionalXml
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> sigProvUrl.</para>
    /// <para>Represents the following attribute in the schema: sigProvUrl </para>
    /// </summary>
    [SchemaAttr(0, "sigProvUrl")]
    public StringValue SignatureProviderUrl
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SignatureLine class.
    /// </summary>
    public SignatureLine():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "isSignatureLine" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "provId" == name)
    return new StringValue();
    
if( 0 == namespaceId && "signingInstructionsSet" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "allowComments" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "showSignDate" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "suggestedSigner" == name)
    return new StringValue();
    
if( 0 == namespaceId && "suggestedSigner2" == name)
    return new StringValue();
    
if( 0 == namespaceId && "suggestedSignerEmail" == name)
    return new StringValue();
    
if( 0 == namespaceId && "signingInstructions" == name)
    return new StringValue();
    
if( 0 == namespaceId && "addlXml" == name)
    return new StringValue();
    
if( 0 == namespaceId && "sigProvUrl" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<SignatureLine>(deep);
    }

   
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
 
 
