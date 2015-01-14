// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.Office.CustomUI
{
/// <summary>
/// <para>Defines the UnsizedControlClone Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:control.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class UnsizedControlClone : OpenXmlLeafElement
{
    private const string tagName = "control";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12644;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "idQ","idMso","tag","image","imageMso","getImage","screentip","getScreentip","supertip","getSupertip","enabled","getEnabled","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[23]; }
        set { Attributes[23] = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[24]; }
        set { Attributes[24] = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[25]; }
        set { Attributes[25] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the UnsizedControlClone class.
    /// </summary>
    public UnsizedControlClone():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "image" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imageMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getImage" == name)
    return new StringValue();
    
if( 0 == namespaceId && "screentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getScreentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "supertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSupertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showLabel" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showImage" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowImage" == name)
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
        return CloneImp<UnsizedControlClone>(deep);
    }

   
}
/// <summary>
/// <para>Defines the UnsizedButton Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:button.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class UnsizedButton : OpenXmlLeafElement
{
    private const string tagName = "button";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12645;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "onAction","enabled","getEnabled","description","getDescription","image","imageMso","getImage","id","idQ","idMso","tag","screentip","getScreentip","supertip","getSupertip","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[23]; }
        set { Attributes[23] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[24]; }
        set { Attributes[24] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[25]; }
        set { Attributes[25] = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[26]; }
        set { Attributes[26] = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[27]; }
        set { Attributes[27] = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[28]; }
        set { Attributes[28] = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[29]; }
        set { Attributes[29] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the UnsizedButton class.
    /// </summary>
    public UnsizedButton():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "onAction" == name)
    return new StringValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "description" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getDescription" == name)
    return new StringValue();
    
if( 0 == namespaceId && "image" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imageMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getImage" == name)
    return new StringValue();
    
if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "screentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getScreentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "supertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSupertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showLabel" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showImage" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowImage" == name)
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
        return CloneImp<UnsizedButton>(deep);
    }

   
}
/// <summary>
/// <para>Defines the CheckBox Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:checkBox.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class CheckBox : OpenXmlLeafElement
{
    private const string tagName = "checkBox";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12646;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "getPressed","onAction","enabled","getEnabled","description","getDescription","id","idQ","idMso","tag","screentip","getScreentip","supertip","getSupertip","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> getPressed.</para>
    /// <para>Represents the following attribute in the schema: getPressed </para>
    /// </summary>
    [SchemaAttr(0, "getPressed")]
    public StringValue GetPressed
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[23]; }
        set { Attributes[23] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the CheckBox class.
    /// </summary>
    public CheckBox():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "getPressed" == name)
    return new StringValue();
    
if( 0 == namespaceId && "onAction" == name)
    return new StringValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "description" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getDescription" == name)
    return new StringValue();
    
if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "screentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getScreentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "supertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSupertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
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
        return CloneImp<CheckBox>(deep);
    }

   
}
/// <summary>
/// <para>Defines the UnsizedGallery Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:gallery.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Item &lt;mso:item></description></item>
///<item><description>UnsizedButton &lt;mso:button></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Item))]
    [ChildElementInfo(typeof(UnsizedButton))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class UnsizedGallery : OpenXmlCompositeElement
{
    private const string tagName = "gallery";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12647;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "description","getDescription","invalidateContentOnDrop","columns","rows","itemWidth","itemHeight","getItemWidth","getItemHeight","showItemLabel","onAction","enabled","getEnabled","image","imageMso","getImage","showItemImage","getItemCount","getItemLabel","getItemScreentip","getItemSupertip","getItemImage","getItemID","sizeString","getSelectedItemID","getSelectedItemIndex","id","idQ","idMso","tag","screentip","getScreentip","supertip","getSupertip","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> invalidateContentOnDrop.</para>
    /// <para>Represents the following attribute in the schema: invalidateContentOnDrop </para>
    /// </summary>
    [SchemaAttr(0, "invalidateContentOnDrop")]
    public BooleanValue InvalidateContentOnDrop
    {
        get { return (BooleanValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> columns.</para>
    /// <para>Represents the following attribute in the schema: columns </para>
    /// </summary>
    [SchemaAttr(0, "columns")]
    public IntegerValue Columns
    {
        get { return (IntegerValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> rows.</para>
    /// <para>Represents the following attribute in the schema: rows </para>
    /// </summary>
    [SchemaAttr(0, "rows")]
    public IntegerValue Rows
    {
        get { return (IntegerValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> itemWidth.</para>
    /// <para>Represents the following attribute in the schema: itemWidth </para>
    /// </summary>
    [SchemaAttr(0, "itemWidth")]
    public IntegerValue ItemWidth
    {
        get { return (IntegerValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> itemHeight.</para>
    /// <para>Represents the following attribute in the schema: itemHeight </para>
    /// </summary>
    [SchemaAttr(0, "itemHeight")]
    public IntegerValue ItemHeight
    {
        get { return (IntegerValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> getItemWidth.</para>
    /// <para>Represents the following attribute in the schema: getItemWidth </para>
    /// </summary>
    [SchemaAttr(0, "getItemWidth")]
    public StringValue GetItemWidth
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> getItemHeight.</para>
    /// <para>Represents the following attribute in the schema: getItemHeight </para>
    /// </summary>
    [SchemaAttr(0, "getItemHeight")]
    public StringValue GetItemHeight
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> showItemLabel.</para>
    /// <para>Represents the following attribute in the schema: showItemLabel </para>
    /// </summary>
    [SchemaAttr(0, "showItemLabel")]
    public BooleanValue ShowItemLabel
    {
        get { return (BooleanValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> showItemImage.</para>
    /// <para>Represents the following attribute in the schema: showItemImage </para>
    /// </summary>
    [SchemaAttr(0, "showItemImage")]
    public BooleanValue ShowItemImage
    {
        get { return (BooleanValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> getItemCount.</para>
    /// <para>Represents the following attribute in the schema: getItemCount </para>
    /// </summary>
    [SchemaAttr(0, "getItemCount")]
    public StringValue GetItemCount
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> getItemLabel.</para>
    /// <para>Represents the following attribute in the schema: getItemLabel </para>
    /// </summary>
    [SchemaAttr(0, "getItemLabel")]
    public StringValue GetItemLabel
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> getItemScreentip.</para>
    /// <para>Represents the following attribute in the schema: getItemScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getItemScreentip")]
    public StringValue GetItemScreentip
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> getItemSupertip.</para>
    /// <para>Represents the following attribute in the schema: getItemSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getItemSupertip")]
    public StringValue GetItemSupertip
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> getItemImage.</para>
    /// <para>Represents the following attribute in the schema: getItemImage </para>
    /// </summary>
    [SchemaAttr(0, "getItemImage")]
    public StringValue GetItemImage
    {
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> getItemID.</para>
    /// <para>Represents the following attribute in the schema: getItemID </para>
    /// </summary>
    [SchemaAttr(0, "getItemID")]
    public StringValue GetItemID
    {
        get { return (StringValue)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    
    /// <summary>
    /// <para> sizeString.</para>
    /// <para>Represents the following attribute in the schema: sizeString </para>
    /// </summary>
    [SchemaAttr(0, "sizeString")]
    public StringValue SizeString
    {
        get { return (StringValue)Attributes[23]; }
        set { Attributes[23] = value; }
    }
    
    /// <summary>
    /// <para> getSelectedItemID.</para>
    /// <para>Represents the following attribute in the schema: getSelectedItemID </para>
    /// </summary>
    [SchemaAttr(0, "getSelectedItemID")]
    public StringValue GetSelectedItemID
    {
        get { return (StringValue)Attributes[24]; }
        set { Attributes[24] = value; }
    }
    
    /// <summary>
    /// <para> getSelectedItemIndex.</para>
    /// <para>Represents the following attribute in the schema: getSelectedItemIndex </para>
    /// </summary>
    [SchemaAttr(0, "getSelectedItemIndex")]
    public StringValue GetSelectedItemIndex
    {
        get { return (StringValue)Attributes[25]; }
        set { Attributes[25] = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[26]; }
        set { Attributes[26] = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[27]; }
        set { Attributes[27] = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[28]; }
        set { Attributes[28] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[29]; }
        set { Attributes[29] = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[30]; }
        set { Attributes[30] = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[31]; }
        set { Attributes[31] = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[32]; }
        set { Attributes[32] = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[33]; }
        set { Attributes[33] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[34]; }
        set { Attributes[34] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[35]; }
        set { Attributes[35] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[36]; }
        set { Attributes[36] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[37]; }
        set { Attributes[37] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[38]; }
        set { Attributes[38] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[39]; }
        set { Attributes[39] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[40]; }
        set { Attributes[40] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[41]; }
        set { Attributes[41] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[42]; }
        set { Attributes[42] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[43]; }
        set { Attributes[43] = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[44]; }
        set { Attributes[44] = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[45]; }
        set { Attributes[45] = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[46]; }
        set { Attributes[46] = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[47]; }
        set { Attributes[47] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the UnsizedGallery class.
    /// </summary>
    public UnsizedGallery():base(){}
    
            /// <summary>
    ///Initializes a new instance of the UnsizedGallery class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public UnsizedGallery(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the UnsizedGallery class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public UnsizedGallery(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the UnsizedGallery class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public UnsizedGallery(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "item" == name)
    return new Item();
    
if( 34 == namespaceId && "button" == name)
    return new UnsizedButton();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "description" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getDescription" == name)
    return new StringValue();
    
if( 0 == namespaceId && "invalidateContentOnDrop" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "columns" == name)
    return new IntegerValue();
    
if( 0 == namespaceId && "rows" == name)
    return new IntegerValue();
    
if( 0 == namespaceId && "itemWidth" == name)
    return new IntegerValue();
    
if( 0 == namespaceId && "itemHeight" == name)
    return new IntegerValue();
    
if( 0 == namespaceId && "getItemWidth" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getItemHeight" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showItemLabel" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "onAction" == name)
    return new StringValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "image" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imageMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getImage" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showItemImage" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getItemCount" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getItemLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getItemScreentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getItemSupertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getItemImage" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getItemID" == name)
    return new StringValue();
    
if( 0 == namespaceId && "sizeString" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSelectedItemID" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSelectedItemIndex" == name)
    return new StringValue();
    
if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "screentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getScreentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "supertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSupertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showLabel" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showImage" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowImage" == name)
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
        return CloneImp<UnsizedGallery>(deep);
    }

   
}
/// <summary>
/// <para>Defines the UnsizedToggleButton Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:toggleButton.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class UnsizedToggleButton : OpenXmlLeafElement
{
    private const string tagName = "toggleButton";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12648;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "getPressed","onAction","enabled","getEnabled","description","getDescription","image","imageMso","getImage","id","idQ","idMso","tag","screentip","getScreentip","supertip","getSupertip","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> getPressed.</para>
    /// <para>Represents the following attribute in the schema: getPressed </para>
    /// </summary>
    [SchemaAttr(0, "getPressed")]
    public StringValue GetPressed
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[23]; }
        set { Attributes[23] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[24]; }
        set { Attributes[24] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[25]; }
        set { Attributes[25] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[26]; }
        set { Attributes[26] = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[27]; }
        set { Attributes[27] = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[28]; }
        set { Attributes[28] = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[29]; }
        set { Attributes[29] = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[30]; }
        set { Attributes[30] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the UnsizedToggleButton class.
    /// </summary>
    public UnsizedToggleButton():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "getPressed" == name)
    return new StringValue();
    
if( 0 == namespaceId && "onAction" == name)
    return new StringValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "description" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getDescription" == name)
    return new StringValue();
    
if( 0 == namespaceId && "image" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imageMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getImage" == name)
    return new StringValue();
    
if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "screentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getScreentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "supertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSupertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showLabel" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showImage" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowImage" == name)
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
        return CloneImp<UnsizedToggleButton>(deep);
    }

   
}
/// <summary>
/// <para>Defines the MenuSeparator Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:menuSeparator.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class MenuSeparator : OpenXmlLeafElement
{
    private const string tagName = "menuSeparator";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12649;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","title","getTitle" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0 };
    
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
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> getTitle.</para>
    /// <para>Represents the following attribute in the schema: getTitle </para>
    /// </summary>
    [SchemaAttr(0, "getTitle")]
    public StringValue GetTitle
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the MenuSeparator class.
    /// </summary>
    public MenuSeparator():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "title" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getTitle" == name)
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
        return CloneImp<MenuSeparator>(deep);
    }

   
}
/// <summary>
/// <para>Defines the UnsizedSplitButton Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:splitButton.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>VisibleButton &lt;mso:button></description></item>
///<item><description>VisibleToggleButton &lt;mso:toggleButton></description></item>
///<item><description>UnsizedMenu &lt;mso:menu></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(VisibleButton))]
    [ChildElementInfo(typeof(VisibleToggleButton))]
    [ChildElementInfo(typeof(UnsizedMenu))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class UnsizedSplitButton : OpenXmlCompositeElement
{
    private const string tagName = "splitButton";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12650;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "enabled","getEnabled","id","idQ","idMso","tag","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the UnsizedSplitButton class.
    /// </summary>
    public UnsizedSplitButton():base(){}
    
            /// <summary>
    ///Initializes a new instance of the UnsizedSplitButton class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public UnsizedSplitButton(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the UnsizedSplitButton class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public UnsizedSplitButton(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the UnsizedSplitButton class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public UnsizedSplitButton(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "button" == name)
    return new VisibleButton();
    
if( 34 == namespaceId && "toggleButton" == name)
    return new VisibleToggleButton();
    
if( 34 == namespaceId && "menu" == name)
    return new UnsizedMenu();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showLabel" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowLabel" == name)
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
        return CloneImp<UnsizedSplitButton>(deep);
    }

   
}
/// <summary>
/// <para>Defines the UnsizedMenu Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:menu.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>UnsizedControlClone &lt;mso:control></description></item>
///<item><description>UnsizedButton &lt;mso:button></description></item>
///<item><description>CheckBox &lt;mso:checkBox></description></item>
///<item><description>UnsizedGallery &lt;mso:gallery></description></item>
///<item><description>UnsizedToggleButton &lt;mso:toggleButton></description></item>
///<item><description>MenuSeparator &lt;mso:menuSeparator></description></item>
///<item><description>UnsizedSplitButton &lt;mso:splitButton></description></item>
///<item><description>UnsizedMenu &lt;mso:menu></description></item>
///<item><description>UnsizedDynamicMenu &lt;mso:dynamicMenu></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(UnsizedControlClone))]
    [ChildElementInfo(typeof(UnsizedButton))]
    [ChildElementInfo(typeof(CheckBox))]
    [ChildElementInfo(typeof(UnsizedGallery))]
    [ChildElementInfo(typeof(UnsizedToggleButton))]
    [ChildElementInfo(typeof(MenuSeparator))]
    [ChildElementInfo(typeof(UnsizedSplitButton))]
    [ChildElementInfo(typeof(UnsizedMenu))]
    [ChildElementInfo(typeof(UnsizedDynamicMenu))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class UnsizedMenu : OpenXmlCompositeElement
{
    private const string tagName = "menu";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12651;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "itemSize","description","getDescription","id","idQ","idMso","tag","image","imageMso","getImage","screentip","getScreentip","supertip","getSupertip","enabled","getEnabled","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> itemSize.</para>
    /// <para>Represents the following attribute in the schema: itemSize </para>
    /// </summary>
    [SchemaAttr(0, "itemSize")]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues> ItemSize
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[23]; }
        set { Attributes[23] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[24]; }
        set { Attributes[24] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[25]; }
        set { Attributes[25] = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[26]; }
        set { Attributes[26] = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[27]; }
        set { Attributes[27] = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[28]; }
        set { Attributes[28] = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[29]; }
        set { Attributes[29] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the UnsizedMenu class.
    /// </summary>
    public UnsizedMenu():base(){}
    
            /// <summary>
    ///Initializes a new instance of the UnsizedMenu class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public UnsizedMenu(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the UnsizedMenu class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public UnsizedMenu(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the UnsizedMenu class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public UnsizedMenu(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "control" == name)
    return new UnsizedControlClone();
    
if( 34 == namespaceId && "button" == name)
    return new UnsizedButton();
    
if( 34 == namespaceId && "checkBox" == name)
    return new CheckBox();
    
if( 34 == namespaceId && "gallery" == name)
    return new UnsizedGallery();
    
if( 34 == namespaceId && "toggleButton" == name)
    return new UnsizedToggleButton();
    
if( 34 == namespaceId && "menuSeparator" == name)
    return new MenuSeparator();
    
if( 34 == namespaceId && "splitButton" == name)
    return new UnsizedSplitButton();
    
if( 34 == namespaceId && "menu" == name)
    return new UnsizedMenu();
    
if( 34 == namespaceId && "dynamicMenu" == name)
    return new UnsizedDynamicMenu();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "itemSize" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues>();
    
if( 0 == namespaceId && "description" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getDescription" == name)
    return new StringValue();
    
if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "image" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imageMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getImage" == name)
    return new StringValue();
    
if( 0 == namespaceId && "screentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getScreentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "supertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSupertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showLabel" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showImage" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowImage" == name)
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
        return CloneImp<UnsizedMenu>(deep);
    }

   
}
/// <summary>
/// <para>Defines the UnsizedDynamicMenu Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:dynamicMenu.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class UnsizedDynamicMenu : OpenXmlLeafElement
{
    private const string tagName = "dynamicMenu";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12652;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "description","getDescription","id","idQ","idMso","tag","getContent","invalidateContentOnDrop","image","imageMso","getImage","screentip","getScreentip","supertip","getSupertip","enabled","getEnabled","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> getContent.</para>
    /// <para>Represents the following attribute in the schema: getContent </para>
    /// </summary>
    [SchemaAttr(0, "getContent")]
    public StringValue GetContent
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> invalidateContentOnDrop.</para>
    /// <para>Represents the following attribute in the schema: invalidateContentOnDrop </para>
    /// </summary>
    [SchemaAttr(0, "invalidateContentOnDrop")]
    public BooleanValue InvalidateContentOnDrop
    {
        get { return (BooleanValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[23]; }
        set { Attributes[23] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[24]; }
        set { Attributes[24] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[25]; }
        set { Attributes[25] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[26]; }
        set { Attributes[26] = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[27]; }
        set { Attributes[27] = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[28]; }
        set { Attributes[28] = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[29]; }
        set { Attributes[29] = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[30]; }
        set { Attributes[30] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the UnsizedDynamicMenu class.
    /// </summary>
    public UnsizedDynamicMenu():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "description" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getDescription" == name)
    return new StringValue();
    
if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getContent" == name)
    return new StringValue();
    
if( 0 == namespaceId && "invalidateContentOnDrop" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "image" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imageMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getImage" == name)
    return new StringValue();
    
if( 0 == namespaceId && "screentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getScreentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "supertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSupertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showLabel" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showImage" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowImage" == name)
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
        return CloneImp<UnsizedDynamicMenu>(deep);
    }

   
}
/// <summary>
/// <para>Defines the SplitButtonWithTitle Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:splitButton.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>VisibleButton &lt;mso:button></description></item>
///<item><description>VisibleToggleButton &lt;mso:toggleButton></description></item>
///<item><description>MenuWithTitle &lt;mso:menu></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(VisibleButton))]
    [ChildElementInfo(typeof(VisibleToggleButton))]
    [ChildElementInfo(typeof(MenuWithTitle))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class SplitButtonWithTitle : OpenXmlCompositeElement
{
    private const string tagName = "splitButton";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12653;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "enabled","getEnabled","id","idQ","idMso","tag","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SplitButtonWithTitle class.
    /// </summary>
    public SplitButtonWithTitle():base(){}
    
            /// <summary>
    ///Initializes a new instance of the SplitButtonWithTitle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SplitButtonWithTitle(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SplitButtonWithTitle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SplitButtonWithTitle(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SplitButtonWithTitle class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SplitButtonWithTitle(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "button" == name)
    return new VisibleButton();
    
if( 34 == namespaceId && "toggleButton" == name)
    return new VisibleToggleButton();
    
if( 34 == namespaceId && "menu" == name)
    return new MenuWithTitle();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showLabel" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowLabel" == name)
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
        return CloneImp<SplitButtonWithTitle>(deep);
    }

   
}
/// <summary>
/// <para>Defines the MenuWithTitle Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:menu.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>UnsizedControlClone &lt;mso:control></description></item>
///<item><description>UnsizedButton &lt;mso:button></description></item>
///<item><description>CheckBox &lt;mso:checkBox></description></item>
///<item><description>UnsizedGallery &lt;mso:gallery></description></item>
///<item><description>UnsizedToggleButton &lt;mso:toggleButton></description></item>
///<item><description>MenuSeparator &lt;mso:menuSeparator></description></item>
///<item><description>SplitButtonWithTitle &lt;mso:splitButton></description></item>
///<item><description>MenuWithTitle &lt;mso:menu></description></item>
///<item><description>UnsizedDynamicMenu &lt;mso:dynamicMenu></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(UnsizedControlClone))]
    [ChildElementInfo(typeof(UnsizedButton))]
    [ChildElementInfo(typeof(CheckBox))]
    [ChildElementInfo(typeof(UnsizedGallery))]
    [ChildElementInfo(typeof(UnsizedToggleButton))]
    [ChildElementInfo(typeof(MenuSeparator))]
    [ChildElementInfo(typeof(SplitButtonWithTitle))]
    [ChildElementInfo(typeof(MenuWithTitle))]
    [ChildElementInfo(typeof(UnsizedDynamicMenu))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class MenuWithTitle : OpenXmlCompositeElement
{
    private const string tagName = "menu";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12654;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","idMso","tag","itemSize","title","getTitle","image","imageMso","getImage","screentip","getScreentip","supertip","getSupertip","enabled","getEnabled","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> itemSize.</para>
    /// <para>Represents the following attribute in the schema: itemSize </para>
    /// </summary>
    [SchemaAttr(0, "itemSize")]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues> ItemSize
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues>)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> getTitle.</para>
    /// <para>Represents the following attribute in the schema: getTitle </para>
    /// </summary>
    [SchemaAttr(0, "getTitle")]
    public StringValue GetTitle
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[23]; }
        set { Attributes[23] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[24]; }
        set { Attributes[24] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[25]; }
        set { Attributes[25] = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[26]; }
        set { Attributes[26] = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[27]; }
        set { Attributes[27] = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[28]; }
        set { Attributes[28] = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[29]; }
        set { Attributes[29] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the MenuWithTitle class.
    /// </summary>
    public MenuWithTitle():base(){}
    
            /// <summary>
    ///Initializes a new instance of the MenuWithTitle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MenuWithTitle(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the MenuWithTitle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MenuWithTitle(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the MenuWithTitle class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MenuWithTitle(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "control" == name)
    return new UnsizedControlClone();
    
if( 34 == namespaceId && "button" == name)
    return new UnsizedButton();
    
if( 34 == namespaceId && "checkBox" == name)
    return new CheckBox();
    
if( 34 == namespaceId && "gallery" == name)
    return new UnsizedGallery();
    
if( 34 == namespaceId && "toggleButton" == name)
    return new UnsizedToggleButton();
    
if( 34 == namespaceId && "menuSeparator" == name)
    return new MenuSeparator();
    
if( 34 == namespaceId && "splitButton" == name)
    return new SplitButtonWithTitle();
    
if( 34 == namespaceId && "menu" == name)
    return new MenuWithTitle();
    
if( 34 == namespaceId && "dynamicMenu" == name)
    return new UnsizedDynamicMenu();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "itemSize" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues>();
    
if( 0 == namespaceId && "title" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getTitle" == name)
    return new StringValue();
    
if( 0 == namespaceId && "image" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imageMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getImage" == name)
    return new StringValue();
    
if( 0 == namespaceId && "screentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getScreentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "supertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSupertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showLabel" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showImage" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowImage" == name)
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
        return CloneImp<MenuWithTitle>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ControlClone Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:control.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ControlClone : OpenXmlLeafElement
{
    private const string tagName = "control";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12655;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "size","getSize","enabled","getEnabled","description","getDescription","image","imageMso","getImage","idQ","idMso","tag","screentip","getScreentip","supertip","getSupertip","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size")]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues> Size
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> getSize.</para>
    /// <para>Represents the following attribute in the schema: getSize </para>
    /// </summary>
    [SchemaAttr(0, "getSize")]
    public StringValue GetSize
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[23]; }
        set { Attributes[23] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[24]; }
        set { Attributes[24] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[25]; }
        set { Attributes[25] = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[26]; }
        set { Attributes[26] = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[27]; }
        set { Attributes[27] = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[28]; }
        set { Attributes[28] = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[29]; }
        set { Attributes[29] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ControlClone class.
    /// </summary>
    public ControlClone():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "size" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>();
    
if( 0 == namespaceId && "getSize" == name)
    return new StringValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "description" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getDescription" == name)
    return new StringValue();
    
if( 0 == namespaceId && "image" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imageMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getImage" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "screentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getScreentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "supertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSupertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showLabel" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showImage" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowImage" == name)
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
        return CloneImp<ControlClone>(deep);
    }

   
}
/// <summary>
/// <para>Defines the TextLabel Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:labelControl.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class TextLabel : OpenXmlLeafElement
{
    private const string tagName = "labelControl";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12656;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","idMso","tag","screentip","getScreentip","supertip","getSupertip","enabled","getEnabled","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","showLabel","getShowLabel" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the TextLabel class.
    /// </summary>
    public TextLabel():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "screentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getScreentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "supertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSupertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showLabel" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowLabel" == name)
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
        return CloneImp<TextLabel>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Button Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:button.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Button : OpenXmlLeafElement
{
    private const string tagName = "button";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12657;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "size","getSize","onAction","enabled","getEnabled","description","getDescription","image","imageMso","getImage","id","idQ","idMso","tag","screentip","getScreentip","supertip","getSupertip","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size")]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues> Size
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> getSize.</para>
    /// <para>Represents the following attribute in the schema: getSize </para>
    /// </summary>
    [SchemaAttr(0, "getSize")]
    public StringValue GetSize
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[23]; }
        set { Attributes[23] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[24]; }
        set { Attributes[24] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[25]; }
        set { Attributes[25] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[26]; }
        set { Attributes[26] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[27]; }
        set { Attributes[27] = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[28]; }
        set { Attributes[28] = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[29]; }
        set { Attributes[29] = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[30]; }
        set { Attributes[30] = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[31]; }
        set { Attributes[31] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Button class.
    /// </summary>
    public Button():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "size" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>();
    
if( 0 == namespaceId && "getSize" == name)
    return new StringValue();
    
if( 0 == namespaceId && "onAction" == name)
    return new StringValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "description" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getDescription" == name)
    return new StringValue();
    
if( 0 == namespaceId && "image" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imageMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getImage" == name)
    return new StringValue();
    
if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "screentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getScreentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "supertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSupertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showLabel" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showImage" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowImage" == name)
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
        return CloneImp<Button>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ToggleButton Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:toggleButton.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ToggleButton : OpenXmlLeafElement
{
    private const string tagName = "toggleButton";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12658;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "size","getSize","getPressed","onAction","enabled","getEnabled","description","getDescription","image","imageMso","getImage","id","idQ","idMso","tag","screentip","getScreentip","supertip","getSupertip","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size")]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues> Size
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> getSize.</para>
    /// <para>Represents the following attribute in the schema: getSize </para>
    /// </summary>
    [SchemaAttr(0, "getSize")]
    public StringValue GetSize
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> getPressed.</para>
    /// <para>Represents the following attribute in the schema: getPressed </para>
    /// </summary>
    [SchemaAttr(0, "getPressed")]
    public StringValue GetPressed
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[23]; }
        set { Attributes[23] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[24]; }
        set { Attributes[24] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[25]; }
        set { Attributes[25] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[26]; }
        set { Attributes[26] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[27]; }
        set { Attributes[27] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[28]; }
        set { Attributes[28] = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[29]; }
        set { Attributes[29] = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[30]; }
        set { Attributes[30] = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[31]; }
        set { Attributes[31] = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[32]; }
        set { Attributes[32] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ToggleButton class.
    /// </summary>
    public ToggleButton():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "size" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>();
    
if( 0 == namespaceId && "getSize" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getPressed" == name)
    return new StringValue();
    
if( 0 == namespaceId && "onAction" == name)
    return new StringValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "description" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getDescription" == name)
    return new StringValue();
    
if( 0 == namespaceId && "image" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imageMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getImage" == name)
    return new StringValue();
    
if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "screentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getScreentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "supertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSupertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showLabel" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showImage" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowImage" == name)
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
        return CloneImp<ToggleButton>(deep);
    }

   
}
/// <summary>
/// <para>Defines the EditBox Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:editBox.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class EditBox : OpenXmlLeafElement
{
    private const string tagName = "editBox";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12659;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "enabled","getEnabled","image","imageMso","getImage","maxLength","getText","onChange","sizeString","id","idQ","idMso","tag","screentip","getScreentip","supertip","getSupertip","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> maxLength.</para>
    /// <para>Represents the following attribute in the schema: maxLength </para>
    /// </summary>
    [SchemaAttr(0, "maxLength")]
    public IntegerValue MaxLength
    {
        get { return (IntegerValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> getText.</para>
    /// <para>Represents the following attribute in the schema: getText </para>
    /// </summary>
    [SchemaAttr(0, "getText")]
    public StringValue GetText
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> onChange.</para>
    /// <para>Represents the following attribute in the schema: onChange </para>
    /// </summary>
    [SchemaAttr(0, "onChange")]
    public StringValue OnChange
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> sizeString.</para>
    /// <para>Represents the following attribute in the schema: sizeString </para>
    /// </summary>
    [SchemaAttr(0, "sizeString")]
    public StringValue SizeString
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[23]; }
        set { Attributes[23] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[24]; }
        set { Attributes[24] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[25]; }
        set { Attributes[25] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[26]; }
        set { Attributes[26] = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[27]; }
        set { Attributes[27] = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[28]; }
        set { Attributes[28] = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[29]; }
        set { Attributes[29] = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[30]; }
        set { Attributes[30] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the EditBox class.
    /// </summary>
    public EditBox():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "image" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imageMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getImage" == name)
    return new StringValue();
    
if( 0 == namespaceId && "maxLength" == name)
    return new IntegerValue();
    
if( 0 == namespaceId && "getText" == name)
    return new StringValue();
    
if( 0 == namespaceId && "onChange" == name)
    return new StringValue();
    
if( 0 == namespaceId && "sizeString" == name)
    return new StringValue();
    
if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "screentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getScreentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "supertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSupertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showLabel" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showImage" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowImage" == name)
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
        return CloneImp<EditBox>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ComboBox Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:comboBox.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Item &lt;mso:item></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Item))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ComboBox : OpenXmlCompositeElement
{
    private const string tagName = "comboBox";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12660;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "showItemImage","getItemCount","getItemLabel","getItemScreentip","getItemSupertip","getItemImage","getItemID","sizeString","invalidateContentOnDrop","enabled","getEnabled","image","imageMso","getImage","maxLength","getText","onChange","id","idQ","idMso","tag","screentip","getScreentip","supertip","getSupertip","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> showItemImage.</para>
    /// <para>Represents the following attribute in the schema: showItemImage </para>
    /// </summary>
    [SchemaAttr(0, "showItemImage")]
    public BooleanValue ShowItemImage
    {
        get { return (BooleanValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> getItemCount.</para>
    /// <para>Represents the following attribute in the schema: getItemCount </para>
    /// </summary>
    [SchemaAttr(0, "getItemCount")]
    public StringValue GetItemCount
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> getItemLabel.</para>
    /// <para>Represents the following attribute in the schema: getItemLabel </para>
    /// </summary>
    [SchemaAttr(0, "getItemLabel")]
    public StringValue GetItemLabel
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> getItemScreentip.</para>
    /// <para>Represents the following attribute in the schema: getItemScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getItemScreentip")]
    public StringValue GetItemScreentip
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> getItemSupertip.</para>
    /// <para>Represents the following attribute in the schema: getItemSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getItemSupertip")]
    public StringValue GetItemSupertip
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> getItemImage.</para>
    /// <para>Represents the following attribute in the schema: getItemImage </para>
    /// </summary>
    [SchemaAttr(0, "getItemImage")]
    public StringValue GetItemImage
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> getItemID.</para>
    /// <para>Represents the following attribute in the schema: getItemID </para>
    /// </summary>
    [SchemaAttr(0, "getItemID")]
    public StringValue GetItemID
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> sizeString.</para>
    /// <para>Represents the following attribute in the schema: sizeString </para>
    /// </summary>
    [SchemaAttr(0, "sizeString")]
    public StringValue SizeString
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> invalidateContentOnDrop.</para>
    /// <para>Represents the following attribute in the schema: invalidateContentOnDrop </para>
    /// </summary>
    [SchemaAttr(0, "invalidateContentOnDrop")]
    public BooleanValue InvalidateContentOnDrop
    {
        get { return (BooleanValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> maxLength.</para>
    /// <para>Represents the following attribute in the schema: maxLength </para>
    /// </summary>
    [SchemaAttr(0, "maxLength")]
    public IntegerValue MaxLength
    {
        get { return (IntegerValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> getText.</para>
    /// <para>Represents the following attribute in the schema: getText </para>
    /// </summary>
    [SchemaAttr(0, "getText")]
    public StringValue GetText
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> onChange.</para>
    /// <para>Represents the following attribute in the schema: onChange </para>
    /// </summary>
    [SchemaAttr(0, "onChange")]
    public StringValue OnChange
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[23]; }
        set { Attributes[23] = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[24]; }
        set { Attributes[24] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[25]; }
        set { Attributes[25] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[26]; }
        set { Attributes[26] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[27]; }
        set { Attributes[27] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[28]; }
        set { Attributes[28] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[29]; }
        set { Attributes[29] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[30]; }
        set { Attributes[30] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[31]; }
        set { Attributes[31] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[32]; }
        set { Attributes[32] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[33]; }
        set { Attributes[33] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[34]; }
        set { Attributes[34] = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[35]; }
        set { Attributes[35] = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[36]; }
        set { Attributes[36] = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[37]; }
        set { Attributes[37] = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[38]; }
        set { Attributes[38] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ComboBox class.
    /// </summary>
    public ComboBox():base(){}
    
            /// <summary>
    ///Initializes a new instance of the ComboBox class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ComboBox(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ComboBox class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ComboBox(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ComboBox class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ComboBox(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "item" == name)
    return new Item();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "showItemImage" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getItemCount" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getItemLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getItemScreentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getItemSupertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getItemImage" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getItemID" == name)
    return new StringValue();
    
if( 0 == namespaceId && "sizeString" == name)
    return new StringValue();
    
if( 0 == namespaceId && "invalidateContentOnDrop" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "image" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imageMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getImage" == name)
    return new StringValue();
    
if( 0 == namespaceId && "maxLength" == name)
    return new IntegerValue();
    
if( 0 == namespaceId && "getText" == name)
    return new StringValue();
    
if( 0 == namespaceId && "onChange" == name)
    return new StringValue();
    
if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "screentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getScreentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "supertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSupertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showLabel" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showImage" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowImage" == name)
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
        return CloneImp<ComboBox>(deep);
    }

   
}
/// <summary>
/// <para>Defines the DropDown Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:dropDown.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Item &lt;mso:item></description></item>
///<item><description>UnsizedButton &lt;mso:button></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Item))]
    [ChildElementInfo(typeof(UnsizedButton))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class DropDown : OpenXmlCompositeElement
{
    private const string tagName = "dropDown";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12661;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "onAction","enabled","getEnabled","image","imageMso","getImage","showItemImage","getItemCount","getItemLabel","getItemScreentip","getItemSupertip","getItemImage","getItemID","sizeString","getSelectedItemID","getSelectedItemIndex","showItemLabel","id","idQ","idMso","tag","screentip","getScreentip","supertip","getSupertip","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> showItemImage.</para>
    /// <para>Represents the following attribute in the schema: showItemImage </para>
    /// </summary>
    [SchemaAttr(0, "showItemImage")]
    public BooleanValue ShowItemImage
    {
        get { return (BooleanValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> getItemCount.</para>
    /// <para>Represents the following attribute in the schema: getItemCount </para>
    /// </summary>
    [SchemaAttr(0, "getItemCount")]
    public StringValue GetItemCount
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> getItemLabel.</para>
    /// <para>Represents the following attribute in the schema: getItemLabel </para>
    /// </summary>
    [SchemaAttr(0, "getItemLabel")]
    public StringValue GetItemLabel
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> getItemScreentip.</para>
    /// <para>Represents the following attribute in the schema: getItemScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getItemScreentip")]
    public StringValue GetItemScreentip
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> getItemSupertip.</para>
    /// <para>Represents the following attribute in the schema: getItemSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getItemSupertip")]
    public StringValue GetItemSupertip
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> getItemImage.</para>
    /// <para>Represents the following attribute in the schema: getItemImage </para>
    /// </summary>
    [SchemaAttr(0, "getItemImage")]
    public StringValue GetItemImage
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> getItemID.</para>
    /// <para>Represents the following attribute in the schema: getItemID </para>
    /// </summary>
    [SchemaAttr(0, "getItemID")]
    public StringValue GetItemID
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> sizeString.</para>
    /// <para>Represents the following attribute in the schema: sizeString </para>
    /// </summary>
    [SchemaAttr(0, "sizeString")]
    public StringValue SizeString
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> getSelectedItemID.</para>
    /// <para>Represents the following attribute in the schema: getSelectedItemID </para>
    /// </summary>
    [SchemaAttr(0, "getSelectedItemID")]
    public StringValue GetSelectedItemID
    {
        get { return (StringValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> getSelectedItemIndex.</para>
    /// <para>Represents the following attribute in the schema: getSelectedItemIndex </para>
    /// </summary>
    [SchemaAttr(0, "getSelectedItemIndex")]
    public StringValue GetSelectedItemIndex
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> showItemLabel.</para>
    /// <para>Represents the following attribute in the schema: showItemLabel </para>
    /// </summary>
    [SchemaAttr(0, "showItemLabel")]
    public BooleanValue ShowItemLabel
    {
        get { return (BooleanValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[23]; }
        set { Attributes[23] = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[24]; }
        set { Attributes[24] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[25]; }
        set { Attributes[25] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[26]; }
        set { Attributes[26] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[27]; }
        set { Attributes[27] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[28]; }
        set { Attributes[28] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[29]; }
        set { Attributes[29] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[30]; }
        set { Attributes[30] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[31]; }
        set { Attributes[31] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[32]; }
        set { Attributes[32] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[33]; }
        set { Attributes[33] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[34]; }
        set { Attributes[34] = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[35]; }
        set { Attributes[35] = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[36]; }
        set { Attributes[36] = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[37]; }
        set { Attributes[37] = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[38]; }
        set { Attributes[38] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DropDown class.
    /// </summary>
    public DropDown():base(){}
    
            /// <summary>
    ///Initializes a new instance of the DropDown class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DropDown(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DropDown class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DropDown(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DropDown class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DropDown(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "item" == name)
    return new Item();
    
if( 34 == namespaceId && "button" == name)
    return new UnsizedButton();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "onAction" == name)
    return new StringValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "image" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imageMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getImage" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showItemImage" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getItemCount" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getItemLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getItemScreentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getItemSupertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getItemImage" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getItemID" == name)
    return new StringValue();
    
if( 0 == namespaceId && "sizeString" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSelectedItemID" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSelectedItemIndex" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showItemLabel" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "screentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getScreentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "supertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSupertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showLabel" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showImage" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowImage" == name)
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
        return CloneImp<DropDown>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Gallery Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:gallery.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Item &lt;mso:item></description></item>
///<item><description>UnsizedButton &lt;mso:button></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Item))]
    [ChildElementInfo(typeof(UnsizedButton))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Gallery : OpenXmlCompositeElement
{
    private const string tagName = "gallery";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12662;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "size","getSize","description","getDescription","invalidateContentOnDrop","columns","rows","itemWidth","itemHeight","getItemWidth","getItemHeight","showItemLabel","onAction","enabled","getEnabled","image","imageMso","getImage","showItemImage","getItemCount","getItemLabel","getItemScreentip","getItemSupertip","getItemImage","getItemID","sizeString","getSelectedItemID","getSelectedItemIndex","id","idQ","idMso","tag","screentip","getScreentip","supertip","getSupertip","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size")]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues> Size
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> getSize.</para>
    /// <para>Represents the following attribute in the schema: getSize </para>
    /// </summary>
    [SchemaAttr(0, "getSize")]
    public StringValue GetSize
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> invalidateContentOnDrop.</para>
    /// <para>Represents the following attribute in the schema: invalidateContentOnDrop </para>
    /// </summary>
    [SchemaAttr(0, "invalidateContentOnDrop")]
    public BooleanValue InvalidateContentOnDrop
    {
        get { return (BooleanValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> columns.</para>
    /// <para>Represents the following attribute in the schema: columns </para>
    /// </summary>
    [SchemaAttr(0, "columns")]
    public IntegerValue Columns
    {
        get { return (IntegerValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> rows.</para>
    /// <para>Represents the following attribute in the schema: rows </para>
    /// </summary>
    [SchemaAttr(0, "rows")]
    public IntegerValue Rows
    {
        get { return (IntegerValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> itemWidth.</para>
    /// <para>Represents the following attribute in the schema: itemWidth </para>
    /// </summary>
    [SchemaAttr(0, "itemWidth")]
    public IntegerValue ItemWidth
    {
        get { return (IntegerValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> itemHeight.</para>
    /// <para>Represents the following attribute in the schema: itemHeight </para>
    /// </summary>
    [SchemaAttr(0, "itemHeight")]
    public IntegerValue ItemHeight
    {
        get { return (IntegerValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> getItemWidth.</para>
    /// <para>Represents the following attribute in the schema: getItemWidth </para>
    /// </summary>
    [SchemaAttr(0, "getItemWidth")]
    public StringValue GetItemWidth
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> getItemHeight.</para>
    /// <para>Represents the following attribute in the schema: getItemHeight </para>
    /// </summary>
    [SchemaAttr(0, "getItemHeight")]
    public StringValue GetItemHeight
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> showItemLabel.</para>
    /// <para>Represents the following attribute in the schema: showItemLabel </para>
    /// </summary>
    [SchemaAttr(0, "showItemLabel")]
    public BooleanValue ShowItemLabel
    {
        get { return (BooleanValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> showItemImage.</para>
    /// <para>Represents the following attribute in the schema: showItemImage </para>
    /// </summary>
    [SchemaAttr(0, "showItemImage")]
    public BooleanValue ShowItemImage
    {
        get { return (BooleanValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> getItemCount.</para>
    /// <para>Represents the following attribute in the schema: getItemCount </para>
    /// </summary>
    [SchemaAttr(0, "getItemCount")]
    public StringValue GetItemCount
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> getItemLabel.</para>
    /// <para>Represents the following attribute in the schema: getItemLabel </para>
    /// </summary>
    [SchemaAttr(0, "getItemLabel")]
    public StringValue GetItemLabel
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> getItemScreentip.</para>
    /// <para>Represents the following attribute in the schema: getItemScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getItemScreentip")]
    public StringValue GetItemScreentip
    {
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> getItemSupertip.</para>
    /// <para>Represents the following attribute in the schema: getItemSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getItemSupertip")]
    public StringValue GetItemSupertip
    {
        get { return (StringValue)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    
    /// <summary>
    /// <para> getItemImage.</para>
    /// <para>Represents the following attribute in the schema: getItemImage </para>
    /// </summary>
    [SchemaAttr(0, "getItemImage")]
    public StringValue GetItemImage
    {
        get { return (StringValue)Attributes[23]; }
        set { Attributes[23] = value; }
    }
    
    /// <summary>
    /// <para> getItemID.</para>
    /// <para>Represents the following attribute in the schema: getItemID </para>
    /// </summary>
    [SchemaAttr(0, "getItemID")]
    public StringValue GetItemID
    {
        get { return (StringValue)Attributes[24]; }
        set { Attributes[24] = value; }
    }
    
    /// <summary>
    /// <para> sizeString.</para>
    /// <para>Represents the following attribute in the schema: sizeString </para>
    /// </summary>
    [SchemaAttr(0, "sizeString")]
    public StringValue SizeString
    {
        get { return (StringValue)Attributes[25]; }
        set { Attributes[25] = value; }
    }
    
    /// <summary>
    /// <para> getSelectedItemID.</para>
    /// <para>Represents the following attribute in the schema: getSelectedItemID </para>
    /// </summary>
    [SchemaAttr(0, "getSelectedItemID")]
    public StringValue GetSelectedItemID
    {
        get { return (StringValue)Attributes[26]; }
        set { Attributes[26] = value; }
    }
    
    /// <summary>
    /// <para> getSelectedItemIndex.</para>
    /// <para>Represents the following attribute in the schema: getSelectedItemIndex </para>
    /// </summary>
    [SchemaAttr(0, "getSelectedItemIndex")]
    public StringValue GetSelectedItemIndex
    {
        get { return (StringValue)Attributes[27]; }
        set { Attributes[27] = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[28]; }
        set { Attributes[28] = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[29]; }
        set { Attributes[29] = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[30]; }
        set { Attributes[30] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[31]; }
        set { Attributes[31] = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[32]; }
        set { Attributes[32] = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[33]; }
        set { Attributes[33] = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[34]; }
        set { Attributes[34] = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[35]; }
        set { Attributes[35] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[36]; }
        set { Attributes[36] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[37]; }
        set { Attributes[37] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[38]; }
        set { Attributes[38] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[39]; }
        set { Attributes[39] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[40]; }
        set { Attributes[40] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[41]; }
        set { Attributes[41] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[42]; }
        set { Attributes[42] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[43]; }
        set { Attributes[43] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[44]; }
        set { Attributes[44] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[45]; }
        set { Attributes[45] = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[46]; }
        set { Attributes[46] = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[47]; }
        set { Attributes[47] = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[48]; }
        set { Attributes[48] = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[49]; }
        set { Attributes[49] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Gallery class.
    /// </summary>
    public Gallery():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Gallery class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Gallery(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Gallery class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Gallery(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Gallery class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Gallery(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "item" == name)
    return new Item();
    
if( 34 == namespaceId && "button" == name)
    return new UnsizedButton();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "size" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>();
    
if( 0 == namespaceId && "getSize" == name)
    return new StringValue();
    
if( 0 == namespaceId && "description" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getDescription" == name)
    return new StringValue();
    
if( 0 == namespaceId && "invalidateContentOnDrop" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "columns" == name)
    return new IntegerValue();
    
if( 0 == namespaceId && "rows" == name)
    return new IntegerValue();
    
if( 0 == namespaceId && "itemWidth" == name)
    return new IntegerValue();
    
if( 0 == namespaceId && "itemHeight" == name)
    return new IntegerValue();
    
if( 0 == namespaceId && "getItemWidth" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getItemHeight" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showItemLabel" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "onAction" == name)
    return new StringValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "image" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imageMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getImage" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showItemImage" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getItemCount" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getItemLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getItemScreentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getItemSupertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getItemImage" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getItemID" == name)
    return new StringValue();
    
if( 0 == namespaceId && "sizeString" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSelectedItemID" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSelectedItemIndex" == name)
    return new StringValue();
    
if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "screentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getScreentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "supertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSupertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showLabel" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showImage" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowImage" == name)
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
        return CloneImp<Gallery>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Menu Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:menu.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>UnsizedControlClone &lt;mso:control></description></item>
///<item><description>UnsizedButton &lt;mso:button></description></item>
///<item><description>CheckBox &lt;mso:checkBox></description></item>
///<item><description>UnsizedGallery &lt;mso:gallery></description></item>
///<item><description>UnsizedToggleButton &lt;mso:toggleButton></description></item>
///<item><description>MenuSeparator &lt;mso:menuSeparator></description></item>
///<item><description>UnsizedSplitButton &lt;mso:splitButton></description></item>
///<item><description>UnsizedMenu &lt;mso:menu></description></item>
///<item><description>UnsizedDynamicMenu &lt;mso:dynamicMenu></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(UnsizedControlClone))]
    [ChildElementInfo(typeof(UnsizedButton))]
    [ChildElementInfo(typeof(CheckBox))]
    [ChildElementInfo(typeof(UnsizedGallery))]
    [ChildElementInfo(typeof(UnsizedToggleButton))]
    [ChildElementInfo(typeof(MenuSeparator))]
    [ChildElementInfo(typeof(UnsizedSplitButton))]
    [ChildElementInfo(typeof(UnsizedMenu))]
    [ChildElementInfo(typeof(UnsizedDynamicMenu))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Menu : OpenXmlCompositeElement
{
    private const string tagName = "menu";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12663;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "size","getSize","itemSize","description","getDescription","id","idQ","idMso","tag","image","imageMso","getImage","screentip","getScreentip","supertip","getSupertip","enabled","getEnabled","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size")]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues> Size
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> getSize.</para>
    /// <para>Represents the following attribute in the schema: getSize </para>
    /// </summary>
    [SchemaAttr(0, "getSize")]
    public StringValue GetSize
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> itemSize.</para>
    /// <para>Represents the following attribute in the schema: itemSize </para>
    /// </summary>
    [SchemaAttr(0, "itemSize")]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues> ItemSize
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues>)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[23]; }
        set { Attributes[23] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[24]; }
        set { Attributes[24] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[25]; }
        set { Attributes[25] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[26]; }
        set { Attributes[26] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[27]; }
        set { Attributes[27] = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[28]; }
        set { Attributes[28] = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[29]; }
        set { Attributes[29] = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[30]; }
        set { Attributes[30] = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[31]; }
        set { Attributes[31] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Menu class.
    /// </summary>
    public Menu():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Menu class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Menu(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Menu class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Menu(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Menu class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Menu(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "control" == name)
    return new UnsizedControlClone();
    
if( 34 == namespaceId && "button" == name)
    return new UnsizedButton();
    
if( 34 == namespaceId && "checkBox" == name)
    return new CheckBox();
    
if( 34 == namespaceId && "gallery" == name)
    return new UnsizedGallery();
    
if( 34 == namespaceId && "toggleButton" == name)
    return new UnsizedToggleButton();
    
if( 34 == namespaceId && "menuSeparator" == name)
    return new MenuSeparator();
    
if( 34 == namespaceId && "splitButton" == name)
    return new UnsizedSplitButton();
    
if( 34 == namespaceId && "menu" == name)
    return new UnsizedMenu();
    
if( 34 == namespaceId && "dynamicMenu" == name)
    return new UnsizedDynamicMenu();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "size" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>();
    
if( 0 == namespaceId && "getSize" == name)
    return new StringValue();
    
if( 0 == namespaceId && "itemSize" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues>();
    
if( 0 == namespaceId && "description" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getDescription" == name)
    return new StringValue();
    
if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "image" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imageMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getImage" == name)
    return new StringValue();
    
if( 0 == namespaceId && "screentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getScreentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "supertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSupertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showLabel" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showImage" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowImage" == name)
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
        return CloneImp<Menu>(deep);
    }

   
}
/// <summary>
/// <para>Defines the DynamicMenu Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:dynamicMenu.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class DynamicMenu : OpenXmlLeafElement
{
    private const string tagName = "dynamicMenu";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12664;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "size","getSize","description","getDescription","id","idQ","idMso","tag","getContent","invalidateContentOnDrop","image","imageMso","getImage","screentip","getScreentip","supertip","getSupertip","enabled","getEnabled","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size")]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues> Size
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> getSize.</para>
    /// <para>Represents the following attribute in the schema: getSize </para>
    /// </summary>
    [SchemaAttr(0, "getSize")]
    public StringValue GetSize
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> getContent.</para>
    /// <para>Represents the following attribute in the schema: getContent </para>
    /// </summary>
    [SchemaAttr(0, "getContent")]
    public StringValue GetContent
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> invalidateContentOnDrop.</para>
    /// <para>Represents the following attribute in the schema: invalidateContentOnDrop </para>
    /// </summary>
    [SchemaAttr(0, "invalidateContentOnDrop")]
    public BooleanValue InvalidateContentOnDrop
    {
        get { return (BooleanValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[23]; }
        set { Attributes[23] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[24]; }
        set { Attributes[24] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[25]; }
        set { Attributes[25] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[26]; }
        set { Attributes[26] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[27]; }
        set { Attributes[27] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[28]; }
        set { Attributes[28] = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[29]; }
        set { Attributes[29] = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[30]; }
        set { Attributes[30] = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[31]; }
        set { Attributes[31] = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[32]; }
        set { Attributes[32] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DynamicMenu class.
    /// </summary>
    public DynamicMenu():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "size" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>();
    
if( 0 == namespaceId && "getSize" == name)
    return new StringValue();
    
if( 0 == namespaceId && "description" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getDescription" == name)
    return new StringValue();
    
if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getContent" == name)
    return new StringValue();
    
if( 0 == namespaceId && "invalidateContentOnDrop" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "image" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imageMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getImage" == name)
    return new StringValue();
    
if( 0 == namespaceId && "screentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getScreentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "supertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSupertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showLabel" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showImage" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowImage" == name)
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
        return CloneImp<DynamicMenu>(deep);
    }

   
}
/// <summary>
/// <para>Defines the SplitButton Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:splitButton.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>VisibleButton &lt;mso:button></description></item>
///<item><description>VisibleToggleButton &lt;mso:toggleButton></description></item>
///<item><description>UnsizedMenu &lt;mso:menu></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(VisibleButton))]
    [ChildElementInfo(typeof(VisibleToggleButton))]
    [ChildElementInfo(typeof(UnsizedMenu))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class SplitButton : OpenXmlCompositeElement
{
    private const string tagName = "splitButton";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12665;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "size","getSize","enabled","getEnabled","id","idQ","idMso","tag","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size")]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues> Size
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> getSize.</para>
    /// <para>Represents the following attribute in the schema: getSize </para>
    /// </summary>
    [SchemaAttr(0, "getSize")]
    public StringValue GetSize
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SplitButton class.
    /// </summary>
    public SplitButton():base(){}
    
            /// <summary>
    ///Initializes a new instance of the SplitButton class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SplitButton(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SplitButton class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SplitButton(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SplitButton class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SplitButton(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "button" == name)
    return new VisibleButton();
    
if( 34 == namespaceId && "toggleButton" == name)
    return new VisibleToggleButton();
    
if( 34 == namespaceId && "menu" == name)
    return new UnsizedMenu();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "size" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>();
    
if( 0 == namespaceId && "getSize" == name)
    return new StringValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showLabel" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowLabel" == name)
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
        return CloneImp<SplitButton>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Box Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:box.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlClone &lt;mso:control></description></item>
///<item><description>TextLabel &lt;mso:labelControl></description></item>
///<item><description>Button &lt;mso:button></description></item>
///<item><description>ToggleButton &lt;mso:toggleButton></description></item>
///<item><description>CheckBox &lt;mso:checkBox></description></item>
///<item><description>EditBox &lt;mso:editBox></description></item>
///<item><description>ComboBox &lt;mso:comboBox></description></item>
///<item><description>DropDown &lt;mso:dropDown></description></item>
///<item><description>Gallery &lt;mso:gallery></description></item>
///<item><description>Menu &lt;mso:menu></description></item>
///<item><description>DynamicMenu &lt;mso:dynamicMenu></description></item>
///<item><description>SplitButton &lt;mso:splitButton></description></item>
///<item><description>Box &lt;mso:box></description></item>
///<item><description>ButtonGroup &lt;mso:buttonGroup></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ControlClone))]
    [ChildElementInfo(typeof(TextLabel))]
    [ChildElementInfo(typeof(Button))]
    [ChildElementInfo(typeof(ToggleButton))]
    [ChildElementInfo(typeof(CheckBox))]
    [ChildElementInfo(typeof(EditBox))]
    [ChildElementInfo(typeof(ComboBox))]
    [ChildElementInfo(typeof(DropDown))]
    [ChildElementInfo(typeof(Gallery))]
    [ChildElementInfo(typeof(Menu))]
    [ChildElementInfo(typeof(DynamicMenu))]
    [ChildElementInfo(typeof(SplitButton))]
    [ChildElementInfo(typeof(Box))]
    [ChildElementInfo(typeof(ButtonGroup))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Box : OpenXmlCompositeElement
{
    private const string tagName = "box";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12666;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","visible","getVisible","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","boxStyle" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> boxStyle.</para>
    /// <para>Represents the following attribute in the schema: boxStyle </para>
    /// </summary>
    [SchemaAttr(0, "boxStyle")]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.BoxStyleValues> BoxStyle
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office.CustomUI.BoxStyleValues>)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Box class.
    /// </summary>
    public Box():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Box class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Box(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Box class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Box(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Box class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Box(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "control" == name)
    return new ControlClone();
    
if( 34 == namespaceId && "labelControl" == name)
    return new TextLabel();
    
if( 34 == namespaceId && "button" == name)
    return new Button();
    
if( 34 == namespaceId && "toggleButton" == name)
    return new ToggleButton();
    
if( 34 == namespaceId && "checkBox" == name)
    return new CheckBox();
    
if( 34 == namespaceId && "editBox" == name)
    return new EditBox();
    
if( 34 == namespaceId && "comboBox" == name)
    return new ComboBox();
    
if( 34 == namespaceId && "dropDown" == name)
    return new DropDown();
    
if( 34 == namespaceId && "gallery" == name)
    return new Gallery();
    
if( 34 == namespaceId && "menu" == name)
    return new Menu();
    
if( 34 == namespaceId && "dynamicMenu" == name)
    return new DynamicMenu();
    
if( 34 == namespaceId && "splitButton" == name)
    return new SplitButton();
    
if( 34 == namespaceId && "box" == name)
    return new Box();
    
if( 34 == namespaceId && "buttonGroup" == name)
    return new ButtonGroup();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "boxStyle" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office.CustomUI.BoxStyleValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Box>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ButtonGroup Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:buttonGroup.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>UnsizedControlClone &lt;mso:control></description></item>
///<item><description>UnsizedButton &lt;mso:button></description></item>
///<item><description>UnsizedToggleButton &lt;mso:toggleButton></description></item>
///<item><description>UnsizedGallery &lt;mso:gallery></description></item>
///<item><description>UnsizedMenu &lt;mso:menu></description></item>
///<item><description>UnsizedDynamicMenu &lt;mso:dynamicMenu></description></item>
///<item><description>UnsizedSplitButton &lt;mso:splitButton></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(UnsizedControlClone))]
    [ChildElementInfo(typeof(UnsizedButton))]
    [ChildElementInfo(typeof(UnsizedToggleButton))]
    [ChildElementInfo(typeof(UnsizedGallery))]
    [ChildElementInfo(typeof(UnsizedMenu))]
    [ChildElementInfo(typeof(UnsizedDynamicMenu))]
    [ChildElementInfo(typeof(UnsizedSplitButton))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ButtonGroup : OpenXmlCompositeElement
{
    private const string tagName = "buttonGroup";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12667;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","visible","getVisible","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0 };
    
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
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ButtonGroup class.
    /// </summary>
    public ButtonGroup():base(){}
    
            /// <summary>
    ///Initializes a new instance of the ButtonGroup class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ButtonGroup(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ButtonGroup class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ButtonGroup(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ButtonGroup class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ButtonGroup(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "control" == name)
    return new UnsizedControlClone();
    
if( 34 == namespaceId && "button" == name)
    return new UnsizedButton();
    
if( 34 == namespaceId && "toggleButton" == name)
    return new UnsizedToggleButton();
    
if( 34 == namespaceId && "gallery" == name)
    return new UnsizedGallery();
    
if( 34 == namespaceId && "menu" == name)
    return new UnsizedMenu();
    
if( 34 == namespaceId && "dynamicMenu" == name)
    return new UnsizedDynamicMenu();
    
if( 34 == namespaceId && "splitButton" == name)
    return new UnsizedSplitButton();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
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
        return CloneImp<ButtonGroup>(deep);
    }

   
}
/// <summary>
/// <para>Defines the MenuRoot Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:menu.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>UnsizedControlClone &lt;mso:control></description></item>
///<item><description>UnsizedButton &lt;mso:button></description></item>
///<item><description>CheckBox &lt;mso:checkBox></description></item>
///<item><description>UnsizedGallery &lt;mso:gallery></description></item>
///<item><description>UnsizedToggleButton &lt;mso:toggleButton></description></item>
///<item><description>MenuSeparator &lt;mso:menuSeparator></description></item>
///<item><description>UnsizedSplitButton &lt;mso:splitButton></description></item>
///<item><description>UnsizedMenu &lt;mso:menu></description></item>
///<item><description>UnsizedDynamicMenu &lt;mso:dynamicMenu></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(UnsizedControlClone))]
    [ChildElementInfo(typeof(UnsizedButton))]
    [ChildElementInfo(typeof(CheckBox))]
    [ChildElementInfo(typeof(UnsizedGallery))]
    [ChildElementInfo(typeof(UnsizedToggleButton))]
    [ChildElementInfo(typeof(MenuSeparator))]
    [ChildElementInfo(typeof(UnsizedSplitButton))]
    [ChildElementInfo(typeof(UnsizedMenu))]
    [ChildElementInfo(typeof(UnsizedDynamicMenu))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class MenuRoot : OpenXmlCompositeElement
{
    private const string tagName = "menu";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12668;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "title","getTitle","itemSize" };
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
    /// <para> title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> getTitle.</para>
    /// <para>Represents the following attribute in the schema: getTitle </para>
    /// </summary>
    [SchemaAttr(0, "getTitle")]
    public StringValue GetTitle
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> itemSize.</para>
    /// <para>Represents the following attribute in the schema: itemSize </para>
    /// </summary>
    [SchemaAttr(0, "itemSize")]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues> ItemSize
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues>)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the MenuRoot class.
    /// </summary>
    public MenuRoot():base(){}
    
            /// <summary>
    ///Initializes a new instance of the MenuRoot class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MenuRoot(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the MenuRoot class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MenuRoot(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the MenuRoot class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MenuRoot(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "control" == name)
    return new UnsizedControlClone();
    
if( 34 == namespaceId && "button" == name)
    return new UnsizedButton();
    
if( 34 == namespaceId && "checkBox" == name)
    return new CheckBox();
    
if( 34 == namespaceId && "gallery" == name)
    return new UnsizedGallery();
    
if( 34 == namespaceId && "toggleButton" == name)
    return new UnsizedToggleButton();
    
if( 34 == namespaceId && "menuSeparator" == name)
    return new MenuSeparator();
    
if( 34 == namespaceId && "splitButton" == name)
    return new UnsizedSplitButton();
    
if( 34 == namespaceId && "menu" == name)
    return new UnsizedMenu();
    
if( 34 == namespaceId && "dynamicMenu" == name)
    return new UnsizedDynamicMenu();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "title" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getTitle" == name)
    return new StringValue();
    
if( 0 == namespaceId && "itemSize" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<MenuRoot>(deep);
    }

   
}
/// <summary>
/// <para>Defines the CustomUI Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:customUI.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RepurposedCommands &lt;mso:commands></description></item>
///<item><description>Ribbon &lt;mso:ribbon></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(RepurposedCommands))]
    [ChildElementInfo(typeof(Ribbon))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class CustomUI : OpenXmlPartRootElement
{
    private const string tagName = "customUI";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12669;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "onLoad","loadImage" };
    private static byte[] attributeNamespaceIds = { 0,0 };
    
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
    /// <para> onLoad.</para>
    /// <para>Represents the following attribute in the schema: onLoad </para>
    /// </summary>
    [SchemaAttr(0, "onLoad")]
    public StringValue OnLoad
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> loadImage.</para>
    /// <para>Represents the following attribute in the schema: loadImage </para>
    /// </summary>
    [SchemaAttr(0, "loadImage")]
    public StringValue LoadImage
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the CustomUI class.
    /// </summary>
    public CustomUI():base(){}
    
            /// <summary>
    ///Initializes a new instance of the CustomUI class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CustomUI(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the CustomUI class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CustomUI(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the CustomUI class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public CustomUI(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "commands" == name)
    return new RepurposedCommands();
    
if( 34 == namespaceId && "ribbon" == name)
    return new Ribbon();
    

    return null;
}

        private static readonly string[] eleTagNames = { "commands","ribbon" };
    private static readonly byte[] eleNamespaceIds = { 34,34 };
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> RepurposedCommands.</para>
    /// <para> Represents the following element tag in the schema: mso:commands </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
    /// </remark>
    public RepurposedCommands RepurposedCommands
    {
        get 
        {
            return GetElement<RepurposedCommands>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> Ribbon.</para>
    /// <para> Represents the following element tag in the schema: mso:ribbon </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
    /// </remark>
    public Ribbon Ribbon
    {
        get 
        {
            return GetElement<Ribbon>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "onLoad" == name)
    return new StringValue();
    
if( 0 == namespaceId && "loadImage" == name)
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
        return CloneImp<CustomUI>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Item Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:item.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Item : OpenXmlLeafElement
{
    private const string tagName = "item";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12670;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","label","image","imageMso","screentip","supertip" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0 };
    
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
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Item class.
    /// </summary>
    public Item():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "image" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imageMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "screentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "supertip" == name)
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
        return CloneImp<Item>(deep);
    }

   
}
/// <summary>
/// <para>Defines the VisibleButton Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:button.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VisibleButton : OpenXmlLeafElement
{
    private const string tagName = "button";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12671;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "onAction","enabled","getEnabled","description","getDescription","image","imageMso","getImage","id","idQ","idMso","tag","screentip","getScreentip","supertip","getSupertip","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[23]; }
        set { Attributes[23] = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[24]; }
        set { Attributes[24] = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[25]; }
        set { Attributes[25] = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[26]; }
        set { Attributes[26] = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[27]; }
        set { Attributes[27] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the VisibleButton class.
    /// </summary>
    public VisibleButton():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "onAction" == name)
    return new StringValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "description" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getDescription" == name)
    return new StringValue();
    
if( 0 == namespaceId && "image" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imageMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getImage" == name)
    return new StringValue();
    
if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "screentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getScreentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "supertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSupertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showLabel" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showImage" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowImage" == name)
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
        return CloneImp<VisibleButton>(deep);
    }

   
}
/// <summary>
/// <para>Defines the VisibleToggleButton Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:toggleButton.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VisibleToggleButton : OpenXmlLeafElement
{
    private const string tagName = "toggleButton";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12672;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "getPressed","onAction","enabled","getEnabled","description","getDescription","image","imageMso","getImage","id","idQ","idMso","tag","screentip","getScreentip","supertip","getSupertip","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> getPressed.</para>
    /// <para>Represents the following attribute in the schema: getPressed </para>
    /// </summary>
    [SchemaAttr(0, "getPressed")]
    public StringValue GetPressed
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[23]; }
        set { Attributes[23] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[24]; }
        set { Attributes[24] = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[25]; }
        set { Attributes[25] = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[26]; }
        set { Attributes[26] = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[27]; }
        set { Attributes[27] = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[28]; }
        set { Attributes[28] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the VisibleToggleButton class.
    /// </summary>
    public VisibleToggleButton():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "getPressed" == name)
    return new StringValue();
    
if( 0 == namespaceId && "onAction" == name)
    return new StringValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "description" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getDescription" == name)
    return new StringValue();
    
if( 0 == namespaceId && "image" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imageMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getImage" == name)
    return new StringValue();
    
if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "screentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getScreentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "supertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSupertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showLabel" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showImage" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowImage" == name)
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
        return CloneImp<VisibleToggleButton>(deep);
    }

   
}
/// <summary>
/// <para>Defines the VerticalSeparator Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:separator.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VerticalSeparator : OpenXmlLeafElement
{
    private const string tagName = "separator";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12673;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","visible","getVisible","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0 };
    
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
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the VerticalSeparator class.
    /// </summary>
    public VerticalSeparator():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
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
        return CloneImp<VerticalSeparator>(deep);
    }

   
}
/// <summary>
/// <para>Defines the DialogBoxLauncher Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:dialogBoxLauncher.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>UnsizedButton &lt;mso:button></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(UnsizedButton))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class DialogBoxLauncher : OpenXmlCompositeElement
{
    private const string tagName = "dialogBoxLauncher";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12674;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the DialogBoxLauncher class.
    /// </summary>
    public DialogBoxLauncher():base(){}
    
            /// <summary>
    ///Initializes a new instance of the DialogBoxLauncher class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DialogBoxLauncher(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DialogBoxLauncher class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DialogBoxLauncher(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DialogBoxLauncher class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DialogBoxLauncher(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "button" == name)
    return new UnsizedButton();
    

    return null;
}

        private static readonly string[] eleTagNames = { "button" };
    private static readonly byte[] eleNamespaceIds = { 34 };
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> UnsizedButton.</para>
    /// <para> Represents the following element tag in the schema: mso:button </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
    /// </remark>
    public UnsizedButton UnsizedButton
    {
        get 
        {
            return GetElement<UnsizedButton>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<DialogBoxLauncher>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Group Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:group.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlClone &lt;mso:control></description></item>
///<item><description>TextLabel &lt;mso:labelControl></description></item>
///<item><description>Button &lt;mso:button></description></item>
///<item><description>ToggleButton &lt;mso:toggleButton></description></item>
///<item><description>CheckBox &lt;mso:checkBox></description></item>
///<item><description>EditBox &lt;mso:editBox></description></item>
///<item><description>ComboBox &lt;mso:comboBox></description></item>
///<item><description>DropDown &lt;mso:dropDown></description></item>
///<item><description>Gallery &lt;mso:gallery></description></item>
///<item><description>Menu &lt;mso:menu></description></item>
///<item><description>DynamicMenu &lt;mso:dynamicMenu></description></item>
///<item><description>SplitButton &lt;mso:splitButton></description></item>
///<item><description>Box &lt;mso:box></description></item>
///<item><description>ButtonGroup &lt;mso:buttonGroup></description></item>
///<item><description>VerticalSeparator &lt;mso:separator></description></item>
///<item><description>DialogBoxLauncher &lt;mso:dialogBoxLauncher></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ControlClone))]
    [ChildElementInfo(typeof(TextLabel))]
    [ChildElementInfo(typeof(Button))]
    [ChildElementInfo(typeof(ToggleButton))]
    [ChildElementInfo(typeof(CheckBox))]
    [ChildElementInfo(typeof(EditBox))]
    [ChildElementInfo(typeof(ComboBox))]
    [ChildElementInfo(typeof(DropDown))]
    [ChildElementInfo(typeof(Gallery))]
    [ChildElementInfo(typeof(Menu))]
    [ChildElementInfo(typeof(DynamicMenu))]
    [ChildElementInfo(typeof(SplitButton))]
    [ChildElementInfo(typeof(Box))]
    [ChildElementInfo(typeof(ButtonGroup))]
    [ChildElementInfo(typeof(VerticalSeparator))]
    [ChildElementInfo(typeof(DialogBoxLauncher))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Group : OpenXmlCompositeElement
{
    private const string tagName = "group";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12675;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","idMso","tag","label","getLabel","image","imageMso","getImage","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","screentip","getScreentip","supertip","getSupertip","visible","getVisible","keytip","getKeytip" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Group class.
    /// </summary>
    public Group():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Group class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Group(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Group class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Group(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Group class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Group(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "control" == name)
    return new ControlClone();
    
if( 34 == namespaceId && "labelControl" == name)
    return new TextLabel();
    
if( 34 == namespaceId && "button" == name)
    return new Button();
    
if( 34 == namespaceId && "toggleButton" == name)
    return new ToggleButton();
    
if( 34 == namespaceId && "checkBox" == name)
    return new CheckBox();
    
if( 34 == namespaceId && "editBox" == name)
    return new EditBox();
    
if( 34 == namespaceId && "comboBox" == name)
    return new ComboBox();
    
if( 34 == namespaceId && "dropDown" == name)
    return new DropDown();
    
if( 34 == namespaceId && "gallery" == name)
    return new Gallery();
    
if( 34 == namespaceId && "menu" == name)
    return new Menu();
    
if( 34 == namespaceId && "dynamicMenu" == name)
    return new DynamicMenu();
    
if( 34 == namespaceId && "splitButton" == name)
    return new SplitButton();
    
if( 34 == namespaceId && "box" == name)
    return new Box();
    
if( 34 == namespaceId && "buttonGroup" == name)
    return new ButtonGroup();
    
if( 34 == namespaceId && "separator" == name)
    return new VerticalSeparator();
    
if( 34 == namespaceId && "dialogBoxLauncher" == name)
    return new DialogBoxLauncher();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "image" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imageMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getImage" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "screentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getScreentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "supertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSupertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
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
        return CloneImp<Group>(deep);
    }

   
}
/// <summary>
/// <para>Defines the QuickAccessToolbarControlClone Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:control.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class QuickAccessToolbarControlClone : OpenXmlLeafElement
{
    private const string tagName = "control";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12676;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","idMso","description","getDescription","size","getSize","image","imageMso","getImage","screentip","getScreentip","supertip","getSupertip","enabled","getEnabled","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> size.</para>
    /// <para>Represents the following attribute in the schema: size </para>
    /// </summary>
    [SchemaAttr(0, "size")]
    public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues> Size
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> getSize.</para>
    /// <para>Represents the following attribute in the schema: getSize </para>
    /// </summary>
    [SchemaAttr(0, "getSize")]
    public StringValue GetSize
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[23]; }
        set { Attributes[23] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[24]; }
        set { Attributes[24] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[25]; }
        set { Attributes[25] = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[26]; }
        set { Attributes[26] = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[27]; }
        set { Attributes[27] = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[28]; }
        set { Attributes[28] = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[29]; }
        set { Attributes[29] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the QuickAccessToolbarControlClone class.
    /// </summary>
    public QuickAccessToolbarControlClone():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "description" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getDescription" == name)
    return new StringValue();
    
if( 0 == namespaceId && "size" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>();
    
if( 0 == namespaceId && "getSize" == name)
    return new StringValue();
    
if( 0 == namespaceId && "image" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imageMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getImage" == name)
    return new StringValue();
    
if( 0 == namespaceId && "screentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getScreentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "supertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSupertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showLabel" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showImage" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowImage" == name)
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
        return CloneImp<QuickAccessToolbarControlClone>(deep);
    }

   
}
/// <summary>
/// <para>Defines the SharedQatControls Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:sharedControls.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>QuickAccessToolbarControlClone &lt;mso:control></description></item>
///<item><description>UnsizedButton &lt;mso:button></description></item>
///<item><description>VerticalSeparator &lt;mso:separator></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class SharedQatControls : QatItemsType
{
    private const string tagName = "sharedControls";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12677;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the SharedQatControls class.
    /// </summary>
    public SharedQatControls():base(){}
            /// <summary>
    ///Initializes a new instance of the SharedQatControls class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SharedQatControls(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SharedQatControls class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SharedQatControls(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SharedQatControls class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SharedQatControls(string outerXml)
        : base(outerXml)
    {
    }

    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<SharedQatControls>(deep);
    }

}
/// <summary>
/// <para>Defines the DocumentSpecificQuickAccessToolbarControls Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:documentControls.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>QuickAccessToolbarControlClone &lt;mso:control></description></item>
///<item><description>UnsizedButton &lt;mso:button></description></item>
///<item><description>VerticalSeparator &lt;mso:separator></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class DocumentSpecificQuickAccessToolbarControls : QatItemsType
{
    private const string tagName = "documentControls";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12678;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the DocumentSpecificQuickAccessToolbarControls class.
    /// </summary>
    public DocumentSpecificQuickAccessToolbarControls():base(){}
            /// <summary>
    ///Initializes a new instance of the DocumentSpecificQuickAccessToolbarControls class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DocumentSpecificQuickAccessToolbarControls(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DocumentSpecificQuickAccessToolbarControls class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DocumentSpecificQuickAccessToolbarControls(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DocumentSpecificQuickAccessToolbarControls class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DocumentSpecificQuickAccessToolbarControls(string outerXml)
        : base(outerXml)
    {
    }

    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<DocumentSpecificQuickAccessToolbarControls>(deep);
    }

}
/// <summary>
/// Defines the QatItemsType class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>QuickAccessToolbarControlClone &lt;mso:control></description></item>
///<item><description>UnsizedButton &lt;mso:button></description></item>
///<item><description>VerticalSeparator &lt;mso:separator></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(QuickAccessToolbarControlClone))]
    [ChildElementInfo(typeof(UnsizedButton))]
    [ChildElementInfo(typeof(VerticalSeparator))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class QatItemsType : OpenXmlCompositeElement
{
        
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "control" == name)
    return new QuickAccessToolbarControlClone();
    
if( 34 == namespaceId && "button" == name)
    return new UnsizedButton();
    
if( 34 == namespaceId && "separator" == name)
    return new VerticalSeparator();
    

    return null;
}

    
    
    
    /// <summary>
    /// Initializes a new instance of the QatItemsType class.
    /// </summary>
    protected QatItemsType(){}
    
            /// <summary>
    ///Initializes a new instance of the QatItemsType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected QatItemsType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the QatItemsType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected QatItemsType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the QatItemsType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected QatItemsType(string outerXml)
        : base(outerXml)
    {
    }

    
}
/// <summary>
/// <para>Defines the Tab Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:tab.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Group &lt;mso:group></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Group))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Tab : OpenXmlCompositeElement
{
    private const string tagName = "tab";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12679;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","idMso","tag","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue IdQ
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQ
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQ
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Tab class.
    /// </summary>
    public Tab():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Tab class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Tab(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Tab class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Tab(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Tab class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Tab(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "group" == name)
    return new Group();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
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
        return CloneImp<Tab>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ContextualTabSet Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:tabSet.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Tab &lt;mso:tab></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Tab))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ContextualTabSet : OpenXmlCompositeElement
{
    private const string tagName = "tabSet";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12680;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "idMso","visible","getVisible" };
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
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ContextualTabSet class.
    /// </summary>
    public ContextualTabSet():base(){}
    
            /// <summary>
    ///Initializes a new instance of the ContextualTabSet class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ContextualTabSet(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ContextualTabSet class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ContextualTabSet(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ContextualTabSet class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ContextualTabSet(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "tab" == name)
    return new Tab();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
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
        return CloneImp<ContextualTabSet>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RepurposedCommand Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:command.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class RepurposedCommand : OpenXmlLeafElement
{
    private const string tagName = "command";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12681;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "onAction","enabled","getEnabled","idMso" };
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
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RepurposedCommand class.
    /// </summary>
    public RepurposedCommand():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "onAction" == name)
    return new StringValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
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
        return CloneImp<RepurposedCommand>(deep);
    }

   
}
/// <summary>
/// <para>Defines the OfficeMenu Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:officeMenu.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>UnsizedControlClone &lt;mso:control></description></item>
///<item><description>UnsizedButton &lt;mso:button></description></item>
///<item><description>CheckBox &lt;mso:checkBox></description></item>
///<item><description>UnsizedGallery &lt;mso:gallery></description></item>
///<item><description>UnsizedToggleButton &lt;mso:toggleButton></description></item>
///<item><description>MenuSeparator &lt;mso:menuSeparator></description></item>
///<item><description>SplitButtonWithTitle &lt;mso:splitButton></description></item>
///<item><description>MenuWithTitle &lt;mso:menu></description></item>
///<item><description>UnsizedDynamicMenu &lt;mso:dynamicMenu></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(UnsizedControlClone))]
    [ChildElementInfo(typeof(UnsizedButton))]
    [ChildElementInfo(typeof(CheckBox))]
    [ChildElementInfo(typeof(UnsizedGallery))]
    [ChildElementInfo(typeof(UnsizedToggleButton))]
    [ChildElementInfo(typeof(MenuSeparator))]
    [ChildElementInfo(typeof(SplitButtonWithTitle))]
    [ChildElementInfo(typeof(MenuWithTitle))]
    [ChildElementInfo(typeof(UnsizedDynamicMenu))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class OfficeMenu : OpenXmlCompositeElement
{
    private const string tagName = "officeMenu";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12682;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the OfficeMenu class.
    /// </summary>
    public OfficeMenu():base(){}
    
            /// <summary>
    ///Initializes a new instance of the OfficeMenu class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OfficeMenu(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the OfficeMenu class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OfficeMenu(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the OfficeMenu class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public OfficeMenu(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "control" == name)
    return new UnsizedControlClone();
    
if( 34 == namespaceId && "button" == name)
    return new UnsizedButton();
    
if( 34 == namespaceId && "checkBox" == name)
    return new CheckBox();
    
if( 34 == namespaceId && "gallery" == name)
    return new UnsizedGallery();
    
if( 34 == namespaceId && "toggleButton" == name)
    return new UnsizedToggleButton();
    
if( 34 == namespaceId && "menuSeparator" == name)
    return new MenuSeparator();
    
if( 34 == namespaceId && "splitButton" == name)
    return new SplitButtonWithTitle();
    
if( 34 == namespaceId && "menu" == name)
    return new MenuWithTitle();
    
if( 34 == namespaceId && "dynamicMenu" == name)
    return new UnsizedDynamicMenu();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<OfficeMenu>(deep);
    }

   
}
/// <summary>
/// <para>Defines the QuickAccessToolbar Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:qat.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SharedQatControls &lt;mso:sharedControls></description></item>
///<item><description>DocumentSpecificQuickAccessToolbarControls &lt;mso:documentControls></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(SharedQatControls))]
    [ChildElementInfo(typeof(DocumentSpecificQuickAccessToolbarControls))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class QuickAccessToolbar : OpenXmlCompositeElement
{
    private const string tagName = "qat";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12683;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the QuickAccessToolbar class.
    /// </summary>
    public QuickAccessToolbar():base(){}
    
            /// <summary>
    ///Initializes a new instance of the QuickAccessToolbar class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public QuickAccessToolbar(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the QuickAccessToolbar class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public QuickAccessToolbar(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the QuickAccessToolbar class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public QuickAccessToolbar(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "sharedControls" == name)
    return new SharedQatControls();
    
if( 34 == namespaceId && "documentControls" == name)
    return new DocumentSpecificQuickAccessToolbarControls();
    

    return null;
}

        private static readonly string[] eleTagNames = { "sharedControls","documentControls" };
    private static readonly byte[] eleNamespaceIds = { 34,34 };
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> SharedQatControls.</para>
    /// <para> Represents the following element tag in the schema: mso:sharedControls </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
    /// </remark>
    public SharedQatControls SharedQatControls
    {
        get 
        {
            return GetElement<SharedQatControls>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> DocumentSpecificQuickAccessToolbarControls.</para>
    /// <para> Represents the following element tag in the schema: mso:documentControls </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
    /// </remark>
    public DocumentSpecificQuickAccessToolbarControls DocumentSpecificQuickAccessToolbarControls
    {
        get 
        {
            return GetElement<DocumentSpecificQuickAccessToolbarControls>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<QuickAccessToolbar>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Tabs Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:tabs.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Tab &lt;mso:tab></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Tab))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Tabs : OpenXmlCompositeElement
{
    private const string tagName = "tabs";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12684;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Tabs class.
    /// </summary>
    public Tabs():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Tabs class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Tabs(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Tabs class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Tabs(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Tabs class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Tabs(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "tab" == name)
    return new Tab();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Tabs>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ContextualTabSets Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:contextualTabs.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ContextualTabSet &lt;mso:tabSet></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ContextualTabSet))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ContextualTabSets : OpenXmlCompositeElement
{
    private const string tagName = "contextualTabs";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12685;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ContextualTabSets class.
    /// </summary>
    public ContextualTabSets():base(){}
    
            /// <summary>
    ///Initializes a new instance of the ContextualTabSets class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ContextualTabSets(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ContextualTabSets class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ContextualTabSets(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ContextualTabSets class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ContextualTabSets(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "tabSet" == name)
    return new ContextualTabSet();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ContextualTabSets>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RepurposedCommands Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:commands.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RepurposedCommand &lt;mso:command></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(RepurposedCommand))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class RepurposedCommands : OpenXmlCompositeElement
{
    private const string tagName = "commands";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12686;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the RepurposedCommands class.
    /// </summary>
    public RepurposedCommands():base(){}
    
            /// <summary>
    ///Initializes a new instance of the RepurposedCommands class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RepurposedCommands(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the RepurposedCommands class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RepurposedCommands(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the RepurposedCommands class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public RepurposedCommands(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "command" == name)
    return new RepurposedCommand();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RepurposedCommands>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Ribbon Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso:ribbon.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>OfficeMenu &lt;mso:officeMenu></description></item>
///<item><description>QuickAccessToolbar &lt;mso:qat></description></item>
///<item><description>Tabs &lt;mso:tabs></description></item>
///<item><description>ContextualTabSets &lt;mso:contextualTabs></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(OfficeMenu))]
    [ChildElementInfo(typeof(QuickAccessToolbar))]
    [ChildElementInfo(typeof(Tabs))]
    [ChildElementInfo(typeof(ContextualTabSets))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Ribbon : OpenXmlCompositeElement
{
    private const string tagName = "ribbon";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 34;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12687;
    
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
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "startFromScratch" };
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
    /// <para> startFromScratch.</para>
    /// <para>Represents the following attribute in the schema: startFromScratch </para>
    /// </summary>
    [SchemaAttr(0, "startFromScratch")]
    public BooleanValue StartFromScratch
    {
        get { return (BooleanValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Ribbon class.
    /// </summary>
    public Ribbon():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Ribbon class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Ribbon(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Ribbon class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Ribbon(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Ribbon class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Ribbon(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 34 == namespaceId && "officeMenu" == name)
    return new OfficeMenu();
    
if( 34 == namespaceId && "qat" == name)
    return new QuickAccessToolbar();
    
if( 34 == namespaceId && "tabs" == name)
    return new Tabs();
    
if( 34 == namespaceId && "contextualTabs" == name)
    return new ContextualTabSets();
    

    return null;
}

        private static readonly string[] eleTagNames = { "officeMenu","qat","tabs","contextualTabs" };
    private static readonly byte[] eleNamespaceIds = { 34,34,34,34 };
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneAll;}
    }
    
        /// <summary>
    /// <para> OfficeMenu.</para>
    /// <para> Represents the following element tag in the schema: mso:officeMenu </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
    /// </remark>
    public OfficeMenu OfficeMenu
    {
        get 
        {
            return GetElement<OfficeMenu>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> QuickAccessToolbar.</para>
    /// <para> Represents the following element tag in the schema: mso:qat </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
    /// </remark>
    public QuickAccessToolbar QuickAccessToolbar
    {
        get 
        {
            return GetElement<QuickAccessToolbar>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> Tabs.</para>
    /// <para> Represents the following element tag in the schema: mso:tabs </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
    /// </remark>
    public Tabs Tabs
    {
        get 
        {
            return GetElement<Tabs>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> ContextualTabSets.</para>
    /// <para> Represents the following element tag in the schema: mso:contextualTabs </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
    /// </remark>
    public ContextualTabSets ContextualTabSets
    {
        get 
        {
            return GetElement<ContextualTabSets>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "startFromScratch" == name)
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
        return CloneImp<Ribbon>(deep);
    }

   
}
/// <summary>
/// Defines the SizeValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum SizeValues
{  
	///<summary>
///normal.
///<para>When the item is serialized out as xml, its value is "normal".</para>
///</summary>
[EnumString("normal")]
Normal,
///<summary>
///large.
///<para>When the item is serialized out as xml, its value is "large".</para>
///</summary>
[EnumString("large")]
Large,
 
}
/// <summary>
/// Defines the ItemSizeValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ItemSizeValues
{  
	///<summary>
///normal.
///<para>When the item is serialized out as xml, its value is "normal".</para>
///</summary>
[EnumString("normal")]
Normal,
///<summary>
///large.
///<para>When the item is serialized out as xml, its value is "large".</para>
///</summary>
[EnumString("large")]
Large,
 
}
/// <summary>
/// Defines the BoxStyleValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum BoxStyleValues
{  
	///<summary>
///horizontal.
///<para>When the item is serialized out as xml, its value is "horizontal".</para>
///</summary>
[EnumString("horizontal")]
Horizontal,
///<summary>
///vertical.
///<para>When the item is serialized out as xml, its value is "vertical".</para>
///</summary>
[EnumString("vertical")]
Vertical,
 
}
}
 
 
