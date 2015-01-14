// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.Office2010.CustomUI
{
/// <summary>
/// <para>Defines the ControlCloneRegular Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:control.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ControlCloneRegular : OpenXmlLeafElement
{
    private const string tagName = "control";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13099;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "idQ","tag","idMso","image","imageMso","getImage","screentip","getScreentip","supertip","getSupertip","enabled","getEnabled","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
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
    public StringValue QualifiedId
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    /// Initializes a new instance of the ControlCloneRegular class.
    /// </summary>
    public ControlCloneRegular():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
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
        return CloneImp<ControlCloneRegular>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ButtonRegular Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:button.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ButtonRegular : OpenXmlLeafElement
{
    private const string tagName = "button";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13100;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "onAction","enabled","getEnabled","description","getDescription","image","imageMso","getImage","id","idQ","tag","idMso","screentip","getScreentip","supertip","getSupertip","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
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
    public StringValue QualifiedId
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    /// Initializes a new instance of the ButtonRegular class.
    /// </summary>
    public ButtonRegular():base(){}
    
      
     
    
    
    
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
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
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
        return CloneImp<ButtonRegular>(deep);
    }

   
}
/// <summary>
/// <para>Defines the CheckBox Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:checkBox.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
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
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13101;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "getPressed","onAction","enabled","getEnabled","description","getDescription","id","idQ","tag","idMso","screentip","getScreentip","supertip","getSupertip","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip" };
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
    public StringValue QualifiedId
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
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
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
/// <para>Defines the GalleryRegular Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:gallery.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Item &lt;mso14:item></description></item>
///<item><description>ButtonRegular &lt;mso14:button></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Item),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(ButtonRegular),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class GalleryRegular : OpenXmlCompositeElement
{
    private const string tagName = "gallery";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13102;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "description","getDescription","invalidateContentOnDrop","columns","rows","itemWidth","itemHeight","getItemWidth","getItemHeight","showItemLabel","showInRibbon","onAction","enabled","getEnabled","image","imageMso","getImage","showItemImage","getItemCount","getItemLabel","getItemScreentip","getItemSupertip","getItemImage","getItemID","sizeString","getSelectedItemID","getSelectedItemIndex","id","idQ","tag","idMso","screentip","getScreentip","supertip","getSupertip","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> showInRibbon.</para>
    /// <para>Represents the following attribute in the schema: showInRibbon </para>
    /// </summary>
    [SchemaAttr(0, "showInRibbon")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryShowInRibbonValues> ShowInRibbon
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryShowInRibbonValues>)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> showItemImage.</para>
    /// <para>Represents the following attribute in the schema: showItemImage </para>
    /// </summary>
    [SchemaAttr(0, "showItemImage")]
    public BooleanValue ShowItemImage
    {
        get { return (BooleanValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> getItemCount.</para>
    /// <para>Represents the following attribute in the schema: getItemCount </para>
    /// </summary>
    [SchemaAttr(0, "getItemCount")]
    public StringValue GetItemCount
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> getItemLabel.</para>
    /// <para>Represents the following attribute in the schema: getItemLabel </para>
    /// </summary>
    [SchemaAttr(0, "getItemLabel")]
    public StringValue GetItemLabel
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> getItemScreentip.</para>
    /// <para>Represents the following attribute in the schema: getItemScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getItemScreentip")]
    public StringValue GetItemScreentip
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> getItemSupertip.</para>
    /// <para>Represents the following attribute in the schema: getItemSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getItemSupertip")]
    public StringValue GetItemSupertip
    {
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> getItemImage.</para>
    /// <para>Represents the following attribute in the schema: getItemImage </para>
    /// </summary>
    [SchemaAttr(0, "getItemImage")]
    public StringValue GetItemImage
    {
        get { return (StringValue)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    
    /// <summary>
    /// <para> getItemID.</para>
    /// <para>Represents the following attribute in the schema: getItemID </para>
    /// </summary>
    [SchemaAttr(0, "getItemID")]
    public StringValue GetItemID
    {
        get { return (StringValue)Attributes[23]; }
        set { Attributes[23] = value; }
    }
    
    /// <summary>
    /// <para> sizeString.</para>
    /// <para>Represents the following attribute in the schema: sizeString </para>
    /// </summary>
    [SchemaAttr(0, "sizeString")]
    public StringValue SizeString
    {
        get { return (StringValue)Attributes[24]; }
        set { Attributes[24] = value; }
    }
    
    /// <summary>
    /// <para> getSelectedItemID.</para>
    /// <para>Represents the following attribute in the schema: getSelectedItemID </para>
    /// </summary>
    [SchemaAttr(0, "getSelectedItemID")]
    public StringValue GetSelectedItemID
    {
        get { return (StringValue)Attributes[25]; }
        set { Attributes[25] = value; }
    }
    
    /// <summary>
    /// <para> getSelectedItemIndex.</para>
    /// <para>Represents the following attribute in the schema: getSelectedItemIndex </para>
    /// </summary>
    [SchemaAttr(0, "getSelectedItemIndex")]
    public StringValue GetSelectedItemIndex
    {
        get { return (StringValue)Attributes[26]; }
        set { Attributes[26] = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[27]; }
        set { Attributes[27] = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue QualifiedId
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
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[31]; }
        set { Attributes[31] = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[32]; }
        set { Attributes[32] = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[33]; }
        set { Attributes[33] = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[34]; }
        set { Attributes[34] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[35]; }
        set { Attributes[35] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[36]; }
        set { Attributes[36] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[37]; }
        set { Attributes[37] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[38]; }
        set { Attributes[38] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[39]; }
        set { Attributes[39] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
    {
        get { return (StringValue)Attributes[40]; }
        set { Attributes[40] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[41]; }
        set { Attributes[41] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[42]; }
        set { Attributes[42] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[43]; }
        set { Attributes[43] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[44]; }
        set { Attributes[44] = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[45]; }
        set { Attributes[45] = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[46]; }
        set { Attributes[46] = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[47]; }
        set { Attributes[47] = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[48]; }
        set { Attributes[48] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the GalleryRegular class.
    /// </summary>
    public GalleryRegular():base(){}
    
            /// <summary>
    ///Initializes a new instance of the GalleryRegular class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GalleryRegular(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the GalleryRegular class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GalleryRegular(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the GalleryRegular class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public GalleryRegular(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "item" == name)
    return new Item();
    
if( 57 == namespaceId && "button" == name)
    return new ButtonRegular();
    

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
    
if( 0 == namespaceId && "showInRibbon" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryShowInRibbonValues>();
    
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
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
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
        return CloneImp<GalleryRegular>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ToggleButtonRegular Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:toggleButton.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ToggleButtonRegular : OpenXmlLeafElement
{
    private const string tagName = "toggleButton";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13103;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "getPressed","onAction","enabled","getEnabled","description","getDescription","image","imageMso","getImage","id","idQ","tag","idMso","screentip","getScreentip","supertip","getSupertip","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    /// Initializes a new instance of the ToggleButtonRegular class.
    /// </summary>
    public ToggleButtonRegular():base(){}
    
      
     
    
    
    
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
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
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
        return CloneImp<ToggleButtonRegular>(deep);
    }

   
}
/// <summary>
/// <para>Defines the MenuSeparator Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:menuSeparator.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
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
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13104;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","tag","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","title","getTitle" };
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
    public StringValue QualifiedId
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
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> getTitle.</para>
    /// <para>Represents the following attribute in the schema: getTitle </para>
    /// </summary>
    [SchemaAttr(0, "getTitle")]
    public StringValue GetTitle
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
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
/// <para>Defines the SplitButtonRegular Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:splitButton.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>VisibleButton &lt;mso14:button></description></item>
///<item><description>VisibleToggleButton &lt;mso14:toggleButton></description></item>
///<item><description>MenuRegular &lt;mso14:menu></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(VisibleButton),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(VisibleToggleButton),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(MenuRegular),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SplitButtonRegular : OpenXmlCompositeElement
{
    private const string tagName = "splitButton";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13105;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "enabled","getEnabled","id","idQ","tag","idMso","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel" };
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
    public StringValue QualifiedId
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    /// Initializes a new instance of the SplitButtonRegular class.
    /// </summary>
    public SplitButtonRegular():base(){}
    
            /// <summary>
    ///Initializes a new instance of the SplitButtonRegular class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SplitButtonRegular(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SplitButtonRegular class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SplitButtonRegular(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SplitButtonRegular class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SplitButtonRegular(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "button" == name)
    return new VisibleButton();
    
if( 57 == namespaceId && "toggleButton" == name)
    return new VisibleToggleButton();
    
if( 57 == namespaceId && "menu" == name)
    return new MenuRegular();
    

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
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
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
        return CloneImp<SplitButtonRegular>(deep);
    }

   
}
/// <summary>
/// <para>Defines the MenuRegular Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:menu.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlCloneRegular &lt;mso14:control></description></item>
///<item><description>ButtonRegular &lt;mso14:button></description></item>
///<item><description>CheckBox &lt;mso14:checkBox></description></item>
///<item><description>GalleryRegular &lt;mso14:gallery></description></item>
///<item><description>ToggleButtonRegular &lt;mso14:toggleButton></description></item>
///<item><description>MenuSeparator &lt;mso14:menuSeparator></description></item>
///<item><description>SplitButtonRegular &lt;mso14:splitButton></description></item>
///<item><description>MenuRegular &lt;mso14:menu></description></item>
///<item><description>DynamicMenuRegular &lt;mso14:dynamicMenu></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ControlCloneRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(ButtonRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(CheckBox),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(GalleryRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(ToggleButtonRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(MenuSeparator),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(SplitButtonRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(MenuRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DynamicMenuRegular),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class MenuRegular : OpenXmlCompositeElement
{
    private const string tagName = "menu";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13106;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "itemSize","description","getDescription","id","idQ","tag","idMso","image","imageMso","getImage","screentip","getScreentip","supertip","getSupertip","enabled","getEnabled","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
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
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues> ItemSize
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>)Attributes[0]; }
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    /// Initializes a new instance of the MenuRegular class.
    /// </summary>
    public MenuRegular():base(){}
    
            /// <summary>
    ///Initializes a new instance of the MenuRegular class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MenuRegular(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the MenuRegular class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MenuRegular(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the MenuRegular class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MenuRegular(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "control" == name)
    return new ControlCloneRegular();
    
if( 57 == namespaceId && "button" == name)
    return new ButtonRegular();
    
if( 57 == namespaceId && "checkBox" == name)
    return new CheckBox();
    
if( 57 == namespaceId && "gallery" == name)
    return new GalleryRegular();
    
if( 57 == namespaceId && "toggleButton" == name)
    return new ToggleButtonRegular();
    
if( 57 == namespaceId && "menuSeparator" == name)
    return new MenuSeparator();
    
if( 57 == namespaceId && "splitButton" == name)
    return new SplitButtonRegular();
    
if( 57 == namespaceId && "menu" == name)
    return new MenuRegular();
    
if( 57 == namespaceId && "dynamicMenu" == name)
    return new DynamicMenuRegular();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "itemSize" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>();
    
if( 0 == namespaceId && "description" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getDescription" == name)
    return new StringValue();
    
if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
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
        return CloneImp<MenuRegular>(deep);
    }

   
}
/// <summary>
/// <para>Defines the DynamicMenuRegular Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:dynamicMenu.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class DynamicMenuRegular : OpenXmlLeafElement
{
    private const string tagName = "dynamicMenu";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13107;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "description","getDescription","id","idQ","tag","idMso","getContent","invalidateContentOnDrop","image","imageMso","getImage","screentip","getScreentip","supertip","getSupertip","enabled","getEnabled","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
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
    public StringValue QualifiedId
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    /// Initializes a new instance of the DynamicMenuRegular class.
    /// </summary>
    public DynamicMenuRegular():base(){}
    
      
     
    
    
    
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
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
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
        return CloneImp<DynamicMenuRegular>(deep);
    }

   
}
/// <summary>
/// <para>Defines the SplitButtonWithTitle Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:splitButton.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>VisibleButton &lt;mso14:button></description></item>
///<item><description>VisibleToggleButton &lt;mso14:toggleButton></description></item>
///<item><description>MenuWithTitle &lt;mso14:menu></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(VisibleButton),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(VisibleToggleButton),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(MenuWithTitle),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
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
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13108;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "enabled","getEnabled","id","idQ","tag","idMso","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel" };
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
    public StringValue QualifiedId
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    if( 57 == namespaceId && "button" == name)
    return new VisibleButton();
    
if( 57 == namespaceId && "toggleButton" == name)
    return new VisibleToggleButton();
    
if( 57 == namespaceId && "menu" == name)
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
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
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
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:menu.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlCloneRegular &lt;mso14:control></description></item>
///<item><description>ButtonRegular &lt;mso14:button></description></item>
///<item><description>CheckBox &lt;mso14:checkBox></description></item>
///<item><description>GalleryRegular &lt;mso14:gallery></description></item>
///<item><description>ToggleButtonRegular &lt;mso14:toggleButton></description></item>
///<item><description>MenuSeparator &lt;mso14:menuSeparator></description></item>
///<item><description>SplitButtonWithTitle &lt;mso14:splitButton></description></item>
///<item><description>MenuWithTitle &lt;mso14:menu></description></item>
///<item><description>DynamicMenuRegular &lt;mso14:dynamicMenu></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ControlCloneRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(ButtonRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(CheckBox),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(GalleryRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(ToggleButtonRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(MenuSeparator),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(SplitButtonWithTitle),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(MenuWithTitle),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DynamicMenuRegular),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
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
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13109;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","tag","idMso","itemSize","title","getTitle","image","imageMso","getImage","screentip","getScreentip","supertip","getSupertip","enabled","getEnabled","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
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
    public StringValue QualifiedId
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
    /// <para> itemSize.</para>
    /// <para>Represents the following attribute in the schema: itemSize </para>
    /// </summary>
    [SchemaAttr(0, "itemSize")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues> ItemSize
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>)Attributes[4]; }
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    if( 57 == namespaceId && "control" == name)
    return new ControlCloneRegular();
    
if( 57 == namespaceId && "button" == name)
    return new ButtonRegular();
    
if( 57 == namespaceId && "checkBox" == name)
    return new CheckBox();
    
if( 57 == namespaceId && "gallery" == name)
    return new GalleryRegular();
    
if( 57 == namespaceId && "toggleButton" == name)
    return new ToggleButtonRegular();
    
if( 57 == namespaceId && "menuSeparator" == name)
    return new MenuSeparator();
    
if( 57 == namespaceId && "splitButton" == name)
    return new SplitButtonWithTitle();
    
if( 57 == namespaceId && "menu" == name)
    return new MenuWithTitle();
    
if( 57 == namespaceId && "dynamicMenu" == name)
    return new DynamicMenuRegular();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "itemSize" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>();
    
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
/// <para>Defines the MenuSeparatorNoTitle Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:menuSeparator.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class MenuSeparatorNoTitle : OpenXmlLeafElement
{
    private const string tagName = "menuSeparator";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13110;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","tag","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0 };
    
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
    public StringValue QualifiedId
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
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the MenuSeparatorNoTitle class.
    /// </summary>
    public MenuSeparatorNoTitle():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
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
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<MenuSeparatorNoTitle>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ControlClone Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:control.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
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
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13111;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "size","getSize","enabled","getEnabled","description","getDescription","image","imageMso","getImage","idQ","tag","idMso","screentip","getScreentip","supertip","getSupertip","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
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
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues> Size
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>)Attributes[0]; }
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
    public StringValue QualifiedId
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>();
    
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
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
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
/// <para>Defines the LabelControl Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:labelControl.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class LabelControl : OpenXmlLeafElement
{
    private const string tagName = "labelControl";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13112;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","tag","idMso","screentip","getScreentip","supertip","getSupertip","enabled","getEnabled","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","showLabel","getShowLabel" };
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    /// Initializes a new instance of the LabelControl class.
    /// </summary>
    public LabelControl():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
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
        return CloneImp<LabelControl>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Button Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:button.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
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
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13113;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "size","getSize","onAction","enabled","getEnabled","description","getDescription","image","imageMso","getImage","id","idQ","tag","idMso","screentip","getScreentip","supertip","getSupertip","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
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
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues> Size
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>)Attributes[0]; }
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>();
    
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
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
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
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:toggleButton.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
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
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13114;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "size","getSize","getPressed","onAction","enabled","getEnabled","description","getDescription","image","imageMso","getImage","id","idQ","tag","idMso","screentip","getScreentip","supertip","getSupertip","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
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
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues> Size
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>)Attributes[0]; }
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
    public StringValue QualifiedId
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
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[23]; }
        set { Attributes[23] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>();
    
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
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
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
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:editBox.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
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
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13115;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "enabled","getEnabled","image","imageMso","getImage","maxLength","getText","onChange","sizeString","id","idQ","tag","idMso","screentip","getScreentip","supertip","getSupertip","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
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
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:comboBox.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Item &lt;mso14:item></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Item),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
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
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13116;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "showItemImage","getItemCount","getItemLabel","getItemScreentip","getItemSupertip","getItemImage","getItemID","sizeString","invalidateContentOnDrop","enabled","getEnabled","image","imageMso","getImage","maxLength","getText","onChange","id","idQ","tag","idMso","screentip","getScreentip","supertip","getSupertip","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
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
    public StringValue QualifiedId
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[29]; }
        set { Attributes[29] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    if( 57 == namespaceId && "item" == name)
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
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
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
/// <para>Defines the DropDownRegular Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:dropDown.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Item &lt;mso14:item></description></item>
///<item><description>ButtonRegular &lt;mso14:button></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Item),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(ButtonRegular),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class DropDownRegular : OpenXmlCompositeElement
{
    private const string tagName = "dropDown";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13117;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "onAction","enabled","getEnabled","image","imageMso","getImage","showItemImage","getItemCount","getItemLabel","getItemScreentip","getItemSupertip","getItemImage","getItemID","sizeString","getSelectedItemID","getSelectedItemIndex","showItemLabel","id","idQ","tag","idMso","screentip","getScreentip","supertip","getSupertip","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
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
    public StringValue QualifiedId
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[29]; }
        set { Attributes[29] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    /// Initializes a new instance of the DropDownRegular class.
    /// </summary>
    public DropDownRegular():base(){}
    
            /// <summary>
    ///Initializes a new instance of the DropDownRegular class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DropDownRegular(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DropDownRegular class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DropDownRegular(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DropDownRegular class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DropDownRegular(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "item" == name)
    return new Item();
    
if( 57 == namespaceId && "button" == name)
    return new ButtonRegular();
    

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
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
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
        return CloneImp<DropDownRegular>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Gallery Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:gallery.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Item &lt;mso14:item></description></item>
///<item><description>ButtonRegular &lt;mso14:button></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Item),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(ButtonRegular),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
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
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13118;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "size","getSize","description","getDescription","invalidateContentOnDrop","columns","rows","itemWidth","itemHeight","getItemWidth","getItemHeight","showItemLabel","showInRibbon","onAction","enabled","getEnabled","image","imageMso","getImage","showItemImage","getItemCount","getItemLabel","getItemScreentip","getItemSupertip","getItemImage","getItemID","sizeString","getSelectedItemID","getSelectedItemIndex","id","idQ","tag","idMso","screentip","getScreentip","supertip","getSupertip","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues> Size
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>)Attributes[0]; }
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
    /// <para> showInRibbon.</para>
    /// <para>Represents the following attribute in the schema: showInRibbon </para>
    /// </summary>
    [SchemaAttr(0, "showInRibbon")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryShowInRibbonValues> ShowInRibbon
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryShowInRibbonValues>)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
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
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> showItemImage.</para>
    /// <para>Represents the following attribute in the schema: showItemImage </para>
    /// </summary>
    [SchemaAttr(0, "showItemImage")]
    public BooleanValue ShowItemImage
    {
        get { return (BooleanValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> getItemCount.</para>
    /// <para>Represents the following attribute in the schema: getItemCount </para>
    /// </summary>
    [SchemaAttr(0, "getItemCount")]
    public StringValue GetItemCount
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> getItemLabel.</para>
    /// <para>Represents the following attribute in the schema: getItemLabel </para>
    /// </summary>
    [SchemaAttr(0, "getItemLabel")]
    public StringValue GetItemLabel
    {
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> getItemScreentip.</para>
    /// <para>Represents the following attribute in the schema: getItemScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getItemScreentip")]
    public StringValue GetItemScreentip
    {
        get { return (StringValue)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    
    /// <summary>
    /// <para> getItemSupertip.</para>
    /// <para>Represents the following attribute in the schema: getItemSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getItemSupertip")]
    public StringValue GetItemSupertip
    {
        get { return (StringValue)Attributes[23]; }
        set { Attributes[23] = value; }
    }
    
    /// <summary>
    /// <para> getItemImage.</para>
    /// <para>Represents the following attribute in the schema: getItemImage </para>
    /// </summary>
    [SchemaAttr(0, "getItemImage")]
    public StringValue GetItemImage
    {
        get { return (StringValue)Attributes[24]; }
        set { Attributes[24] = value; }
    }
    
    /// <summary>
    /// <para> getItemID.</para>
    /// <para>Represents the following attribute in the schema: getItemID </para>
    /// </summary>
    [SchemaAttr(0, "getItemID")]
    public StringValue GetItemID
    {
        get { return (StringValue)Attributes[25]; }
        set { Attributes[25] = value; }
    }
    
    /// <summary>
    /// <para> sizeString.</para>
    /// <para>Represents the following attribute in the schema: sizeString </para>
    /// </summary>
    [SchemaAttr(0, "sizeString")]
    public StringValue SizeString
    {
        get { return (StringValue)Attributes[26]; }
        set { Attributes[26] = value; }
    }
    
    /// <summary>
    /// <para> getSelectedItemID.</para>
    /// <para>Represents the following attribute in the schema: getSelectedItemID </para>
    /// </summary>
    [SchemaAttr(0, "getSelectedItemID")]
    public StringValue GetSelectedItemID
    {
        get { return (StringValue)Attributes[27]; }
        set { Attributes[27] = value; }
    }
    
    /// <summary>
    /// <para> getSelectedItemIndex.</para>
    /// <para>Represents the following attribute in the schema: getSelectedItemIndex </para>
    /// </summary>
    [SchemaAttr(0, "getSelectedItemIndex")]
    public StringValue GetSelectedItemIndex
    {
        get { return (StringValue)Attributes[28]; }
        set { Attributes[28] = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[29]; }
        set { Attributes[29] = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue QualifiedId
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
    /// <para> idMso.</para>
    /// <para>Represents the following attribute in the schema: idMso </para>
    /// </summary>
    [SchemaAttr(0, "idMso")]
    public StringValue IdMso
    {
        get { return (StringValue)Attributes[32]; }
        set { Attributes[32] = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[33]; }
        set { Attributes[33] = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[34]; }
        set { Attributes[34] = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[35]; }
        set { Attributes[35] = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[36]; }
        set { Attributes[36] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[37]; }
        set { Attributes[37] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[38]; }
        set { Attributes[38] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[39]; }
        set { Attributes[39] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[40]; }
        set { Attributes[40] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[41]; }
        set { Attributes[41] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
    {
        get { return (StringValue)Attributes[42]; }
        set { Attributes[42] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[43]; }
        set { Attributes[43] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[44]; }
        set { Attributes[44] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[45]; }
        set { Attributes[45] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[46]; }
        set { Attributes[46] = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[47]; }
        set { Attributes[47] = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[48]; }
        set { Attributes[48] = value; }
    }
    
    /// <summary>
    /// <para> showImage.</para>
    /// <para>Represents the following attribute in the schema: showImage </para>
    /// </summary>
    [SchemaAttr(0, "showImage")]
    public BooleanValue ShowImage
    {
        get { return (BooleanValue)Attributes[49]; }
        set { Attributes[49] = value; }
    }
    
    /// <summary>
    /// <para> getShowImage.</para>
    /// <para>Represents the following attribute in the schema: getShowImage </para>
    /// </summary>
    [SchemaAttr(0, "getShowImage")]
    public StringValue GetShowImage
    {
        get { return (StringValue)Attributes[50]; }
        set { Attributes[50] = value; }
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
    if( 57 == namespaceId && "item" == name)
    return new Item();
    
if( 57 == namespaceId && "button" == name)
    return new ButtonRegular();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "size" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>();
    
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
    
if( 0 == namespaceId && "showInRibbon" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryShowInRibbonValues>();
    
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
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
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
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:menu.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlCloneRegular &lt;mso14:control></description></item>
///<item><description>ButtonRegular &lt;mso14:button></description></item>
///<item><description>CheckBox &lt;mso14:checkBox></description></item>
///<item><description>GalleryRegular &lt;mso14:gallery></description></item>
///<item><description>ToggleButtonRegular &lt;mso14:toggleButton></description></item>
///<item><description>MenuSeparator &lt;mso14:menuSeparator></description></item>
///<item><description>SplitButtonRegular &lt;mso14:splitButton></description></item>
///<item><description>MenuRegular &lt;mso14:menu></description></item>
///<item><description>DynamicMenuRegular &lt;mso14:dynamicMenu></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ControlCloneRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(ButtonRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(CheckBox),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(GalleryRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(ToggleButtonRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(MenuSeparator),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(SplitButtonRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(MenuRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DynamicMenuRegular),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
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
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13119;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "size","getSize","itemSize","description","getDescription","id","idQ","tag","idMso","image","imageMso","getImage","screentip","getScreentip","supertip","getSupertip","enabled","getEnabled","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
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
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues> Size
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>)Attributes[0]; }
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
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues> ItemSize
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>)Attributes[2]; }
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    if( 57 == namespaceId && "control" == name)
    return new ControlCloneRegular();
    
if( 57 == namespaceId && "button" == name)
    return new ButtonRegular();
    
if( 57 == namespaceId && "checkBox" == name)
    return new CheckBox();
    
if( 57 == namespaceId && "gallery" == name)
    return new GalleryRegular();
    
if( 57 == namespaceId && "toggleButton" == name)
    return new ToggleButtonRegular();
    
if( 57 == namespaceId && "menuSeparator" == name)
    return new MenuSeparator();
    
if( 57 == namespaceId && "splitButton" == name)
    return new SplitButtonRegular();
    
if( 57 == namespaceId && "menu" == name)
    return new MenuRegular();
    
if( 57 == namespaceId && "dynamicMenu" == name)
    return new DynamicMenuRegular();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "size" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>();
    
if( 0 == namespaceId && "getSize" == name)
    return new StringValue();
    
if( 0 == namespaceId && "itemSize" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>();
    
if( 0 == namespaceId && "description" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getDescription" == name)
    return new StringValue();
    
if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
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
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:dynamicMenu.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
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
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13120;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "size","getSize","description","getDescription","id","idQ","tag","idMso","getContent","invalidateContentOnDrop","image","imageMso","getImage","screentip","getScreentip","supertip","getSupertip","enabled","getEnabled","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
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
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues> Size
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>)Attributes[0]; }
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[23]; }
        set { Attributes[23] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>();
    
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
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
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
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:splitButton.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>VisibleButton &lt;mso14:button></description></item>
///<item><description>VisibleToggleButton &lt;mso14:toggleButton></description></item>
///<item><description>MenuRegular &lt;mso14:menu></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(VisibleButton),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(VisibleToggleButton),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(MenuRegular),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
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
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13121;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "size","getSize","enabled","getEnabled","id","idQ","tag","idMso","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip","showLabel","getShowLabel" };
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
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues> Size
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>)Attributes[0]; }
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    if( 57 == namespaceId && "button" == name)
    return new VisibleButton();
    
if( 57 == namespaceId && "toggleButton" == name)
    return new VisibleToggleButton();
    
if( 57 == namespaceId && "menu" == name)
    return new MenuRegular();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "size" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>();
    
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
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
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
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:box.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlClone &lt;mso14:control></description></item>
///<item><description>LabelControl &lt;mso14:labelControl></description></item>
///<item><description>Button &lt;mso14:button></description></item>
///<item><description>ToggleButton &lt;mso14:toggleButton></description></item>
///<item><description>CheckBox &lt;mso14:checkBox></description></item>
///<item><description>EditBox &lt;mso14:editBox></description></item>
///<item><description>ComboBox &lt;mso14:comboBox></description></item>
///<item><description>DropDownRegular &lt;mso14:dropDown></description></item>
///<item><description>Gallery &lt;mso14:gallery></description></item>
///<item><description>Menu &lt;mso14:menu></description></item>
///<item><description>DynamicMenu &lt;mso14:dynamicMenu></description></item>
///<item><description>SplitButton &lt;mso14:splitButton></description></item>
///<item><description>Box &lt;mso14:box></description></item>
///<item><description>ButtonGroup &lt;mso14:buttonGroup></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ControlClone),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(LabelControl),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(Button),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(ToggleButton),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(CheckBox),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(EditBox),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(ComboBox),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DropDownRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(Gallery),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(Menu),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DynamicMenu),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(SplitButton),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(Box),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(ButtonGroup),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
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
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13122;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","tag","visible","getVisible","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","boxStyle" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0 };
    
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
    public StringValue QualifiedId
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
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> boxStyle.</para>
    /// <para>Represents the following attribute in the schema: boxStyle </para>
    /// </summary>
    [SchemaAttr(0, "boxStyle")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.BoxStyleValues> BoxStyle
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.BoxStyleValues>)Attributes[9]; }
        set { Attributes[9] = value; }
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
    if( 57 == namespaceId && "control" == name)
    return new ControlClone();
    
if( 57 == namespaceId && "labelControl" == name)
    return new LabelControl();
    
if( 57 == namespaceId && "button" == name)
    return new Button();
    
if( 57 == namespaceId && "toggleButton" == name)
    return new ToggleButton();
    
if( 57 == namespaceId && "checkBox" == name)
    return new CheckBox();
    
if( 57 == namespaceId && "editBox" == name)
    return new EditBox();
    
if( 57 == namespaceId && "comboBox" == name)
    return new ComboBox();
    
if( 57 == namespaceId && "dropDown" == name)
    return new DropDownRegular();
    
if( 57 == namespaceId && "gallery" == name)
    return new Gallery();
    
if( 57 == namespaceId && "menu" == name)
    return new Menu();
    
if( 57 == namespaceId && "dynamicMenu" == name)
    return new DynamicMenu();
    
if( 57 == namespaceId && "splitButton" == name)
    return new SplitButton();
    
if( 57 == namespaceId && "box" == name)
    return new Box();
    
if( 57 == namespaceId && "buttonGroup" == name)
    return new ButtonGroup();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
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
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.BoxStyleValues>();
    

    
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
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:buttonGroup.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlCloneRegular &lt;mso14:control></description></item>
///<item><description>ButtonRegular &lt;mso14:button></description></item>
///<item><description>ToggleButtonRegular &lt;mso14:toggleButton></description></item>
///<item><description>GalleryRegular &lt;mso14:gallery></description></item>
///<item><description>MenuRegular &lt;mso14:menu></description></item>
///<item><description>DynamicMenuRegular &lt;mso14:dynamicMenu></description></item>
///<item><description>SplitButtonRegular &lt;mso14:splitButton></description></item>
///<item><description>Separator &lt;mso14:separator></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ControlCloneRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(ButtonRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(ToggleButtonRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(GalleryRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(MenuRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DynamicMenuRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(SplitButtonRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(Separator),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
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
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13123;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","tag","visible","getVisible","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ" };
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
    public StringValue QualifiedId
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
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
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
    if( 57 == namespaceId && "control" == name)
    return new ControlCloneRegular();
    
if( 57 == namespaceId && "button" == name)
    return new ButtonRegular();
    
if( 57 == namespaceId && "toggleButton" == name)
    return new ToggleButtonRegular();
    
if( 57 == namespaceId && "gallery" == name)
    return new GalleryRegular();
    
if( 57 == namespaceId && "menu" == name)
    return new MenuRegular();
    
if( 57 == namespaceId && "dynamicMenu" == name)
    return new DynamicMenuRegular();
    
if( 57 == namespaceId && "splitButton" == name)
    return new SplitButtonRegular();
    
if( 57 == namespaceId && "separator" == name)
    return new Separator();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
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
/// <para>Defines the BackstageMenuButton Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:button.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackstageMenuButton : OpenXmlLeafElement
{
    private const string tagName = "button";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13124;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "description","getDescription","id","idQ","tag","onAction","isDefinitive","enabled","getEnabled","label","getLabel","visible","getVisible","keytip","getKeytip","image","imageMso","getImage" };
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
    public StringValue QualifiedId
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> isDefinitive.</para>
    /// <para>Represents the following attribute in the schema: isDefinitive </para>
    /// </summary>
    [SchemaAttr(0, "isDefinitive")]
    public BooleanValue IsDefinitive
    {
        get { return (BooleanValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
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
    /// Initializes a new instance of the BackstageMenuButton class.
    /// </summary>
    public BackstageMenuButton():base(){}
    
      
     
    
    
    
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
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "onAction" == name)
    return new StringValue();
    
if( 0 == namespaceId && "isDefinitive" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "image" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imageMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getImage" == name)
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
        return CloneImp<BackstageMenuButton>(deep);
    }

   
}
/// <summary>
/// <para>Defines the BackstageMenuCheckBox Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:checkBox.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackstageMenuCheckBox : OpenXmlLeafElement
{
    private const string tagName = "checkBox";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13125;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "description","getDescription","id","idQ","tag","onAction","getPressed","enabled","getEnabled","label","getLabel","visible","getVisible","keytip","getKeytip" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    public StringValue QualifiedId
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> getPressed.</para>
    /// <para>Represents the following attribute in the schema: getPressed </para>
    /// </summary>
    [SchemaAttr(0, "getPressed")]
    public StringValue GetPressed
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BackstageMenuCheckBox class.
    /// </summary>
    public BackstageMenuCheckBox():base(){}
    
      
     
    
    
    
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
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "onAction" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getPressed" == name)
    return new StringValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
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
        return CloneImp<BackstageMenuCheckBox>(deep);
    }

   
}
/// <summary>
/// <para>Defines the BackstageSubMenu Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:menu.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BackstageMenuGroup &lt;mso14:menuGroup></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(BackstageMenuGroup),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackstageSubMenu : OpenXmlCompositeElement
{
    private const string tagName = "menu";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13126;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "description","getDescription","id","idQ","tag","enabled","getEnabled","label","getLabel","visible","getVisible","image","imageMso","getImage","keytip","getKeytip" };
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
    public StringValue QualifiedId
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
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
    /// Initializes a new instance of the BackstageSubMenu class.
    /// </summary>
    public BackstageSubMenu():base(){}
    
            /// <summary>
    ///Initializes a new instance of the BackstageSubMenu class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackstageSubMenu(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BackstageSubMenu class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackstageSubMenu(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BackstageSubMenu class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BackstageSubMenu(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "menuGroup" == name)
    return new BackstageMenuGroup();
    

    return null;
}

    
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
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "image" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imageMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getImage" == name)
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
        return CloneImp<BackstageSubMenu>(deep);
    }

   
}
/// <summary>
/// <para>Defines the BackstageMenuToggleButton Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:toggleButton.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackstageMenuToggleButton : OpenXmlLeafElement
{
    private const string tagName = "toggleButton";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13127;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "image","imageMso","getImage","description","getDescription","id","idQ","tag","onAction","getPressed","enabled","getEnabled","label","getLabel","visible","getVisible","keytip","getKeytip" };
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
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
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
    public StringValue QualifiedId
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
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> getPressed.</para>
    /// <para>Represents the following attribute in the schema: getPressed </para>
    /// </summary>
    [SchemaAttr(0, "getPressed")]
    public StringValue GetPressed
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
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BackstageMenuToggleButton class.
    /// </summary>
    public BackstageMenuToggleButton():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "image" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imageMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getImage" == name)
    return new StringValue();
    
if( 0 == namespaceId && "description" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getDescription" == name)
    return new StringValue();
    
if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "onAction" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getPressed" == name)
    return new StringValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
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
        return CloneImp<BackstageMenuToggleButton>(deep);
    }

   
}
/// <summary>
/// <para>Defines the BackstageGroupButton Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:button.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackstageGroupButton : OpenXmlLeafElement
{
    private const string tagName = "button";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13128;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "expand","style","screentip","getScreentip","supertip","getSupertip","id","idQ","tag","onAction","isDefinitive","enabled","getEnabled","label","getLabel","visible","getVisible","keytip","getKeytip","image","imageMso","getImage" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    /// <para> expand.</para>
    /// <para>Represents the following attribute in the schema: expand </para>
    /// </summary>
    [SchemaAttr(0, "expand")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> style.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.Style2Values> Style
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.Style2Values>)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
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
    public StringValue QualifiedId
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
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> isDefinitive.</para>
    /// <para>Represents the following attribute in the schema: isDefinitive </para>
    /// </summary>
    [SchemaAttr(0, "isDefinitive")]
    public BooleanValue IsDefinitive
    {
        get { return (BooleanValue)Attributes[10]; }
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
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BackstageGroupButton class.
    /// </summary>
    public BackstageGroupButton():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "expand" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>();
    
if( 0 == namespaceId && "style" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.Style2Values>();
    
if( 0 == namespaceId && "screentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getScreentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "supertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSupertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "onAction" == name)
    return new StringValue();
    
if( 0 == namespaceId && "isDefinitive" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "image" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imageMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getImage" == name)
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
        return CloneImp<BackstageGroupButton>(deep);
    }

   
}
/// <summary>
/// <para>Defines the BackstageCheckBox Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:checkBox.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackstageCheckBox : OpenXmlLeafElement
{
    private const string tagName = "checkBox";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13129;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "expand","description","getDescription","screentip","getScreentip","supertip","getSupertip","id","idQ","tag","onAction","getPressed","enabled","getEnabled","label","getLabel","visible","getVisible","keytip","getKeytip" };
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
    /// <para> expand.</para>
    /// <para>Represents the following attribute in the schema: expand </para>
    /// </summary>
    [SchemaAttr(0, "expand")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>)Attributes[0]; }
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
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
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
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue QualifiedId
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
    /// <para> getPressed.</para>
    /// <para>Represents the following attribute in the schema: getPressed </para>
    /// </summary>
    [SchemaAttr(0, "getPressed")]
    public StringValue GetPressed
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
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
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BackstageCheckBox class.
    /// </summary>
    public BackstageCheckBox():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "expand" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>();
    
if( 0 == namespaceId && "description" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getDescription" == name)
    return new StringValue();
    
if( 0 == namespaceId && "screentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getScreentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "supertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSupertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "onAction" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getPressed" == name)
    return new StringValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
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
        return CloneImp<BackstageCheckBox>(deep);
    }

   
}
/// <summary>
/// <para>Defines the BackstageEditBox Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:editBox.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackstageEditBox : OpenXmlLeafElement
{
    private const string tagName = "editBox";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13130;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","tag","alignLabel","expand","enabled","getEnabled","label","getLabel","visible","getVisible","keytip","getKeytip","getText","onChange","maxLength","sizeString" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    public StringValue QualifiedId
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
    /// <para> alignLabel.</para>
    /// <para>Represents the following attribute in the schema: alignLabel </para>
    /// </summary>
    [SchemaAttr(0, "alignLabel")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> AlignLabel
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> expand.</para>
    /// <para>Represents the following attribute in the schema: expand </para>
    /// </summary>
    [SchemaAttr(0, "expand")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> getText.</para>
    /// <para>Represents the following attribute in the schema: getText </para>
    /// </summary>
    [SchemaAttr(0, "getText")]
    public StringValue GetText
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> onChange.</para>
    /// <para>Represents the following attribute in the schema: onChange </para>
    /// </summary>
    [SchemaAttr(0, "onChange")]
    public StringValue OnChange
    {
        get { return (StringValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> maxLength.</para>
    /// <para>Represents the following attribute in the schema: maxLength </para>
    /// </summary>
    [SchemaAttr(0, "maxLength")]
    public IntegerValue MaxLength
    {
        get { return (IntegerValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> sizeString.</para>
    /// <para>Represents the following attribute in the schema: sizeString </para>
    /// </summary>
    [SchemaAttr(0, "sizeString")]
    public StringValue SizeString
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BackstageEditBox class.
    /// </summary>
    public BackstageEditBox():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "alignLabel" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>();
    
if( 0 == namespaceId && "expand" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getText" == name)
    return new StringValue();
    
if( 0 == namespaceId && "onChange" == name)
    return new StringValue();
    
if( 0 == namespaceId && "maxLength" == name)
    return new IntegerValue();
    
if( 0 == namespaceId && "sizeString" == name)
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
        return CloneImp<BackstageEditBox>(deep);
    }

   
}
/// <summary>
/// <para>Defines the BackstageDropDown Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:dropDown.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ItemBackstageItem &lt;mso14:item></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ItemBackstageItem),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackstageDropDown : OpenXmlCompositeElement
{
    private const string tagName = "dropDown";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13131;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","tag","alignLabel","expand","enabled","getEnabled","label","getLabel","visible","getVisible","onAction","screentip","getScreentip","supertip","getSupertip","keytip","getKeytip","getSelectedItemIndex","sizeString","getItemCount","getItemLabel","getItemID" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    public StringValue QualifiedId
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
    /// <para> alignLabel.</para>
    /// <para>Represents the following attribute in the schema: alignLabel </para>
    /// </summary>
    [SchemaAttr(0, "alignLabel")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> AlignLabel
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> expand.</para>
    /// <para>Represents the following attribute in the schema: expand </para>
    /// </summary>
    [SchemaAttr(0, "expand")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
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
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> getSelectedItemIndex.</para>
    /// <para>Represents the following attribute in the schema: getSelectedItemIndex </para>
    /// </summary>
    [SchemaAttr(0, "getSelectedItemIndex")]
    public StringValue GetSelectedItemIndex
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> sizeString.</para>
    /// <para>Represents the following attribute in the schema: sizeString </para>
    /// </summary>
    [SchemaAttr(0, "sizeString")]
    public StringValue SizeString
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> getItemCount.</para>
    /// <para>Represents the following attribute in the schema: getItemCount </para>
    /// </summary>
    [SchemaAttr(0, "getItemCount")]
    public StringValue GetItemCount
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> getItemLabel.</para>
    /// <para>Represents the following attribute in the schema: getItemLabel </para>
    /// </summary>
    [SchemaAttr(0, "getItemLabel")]
    public StringValue GetItemLabel
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
    /// Initializes a new instance of the BackstageDropDown class.
    /// </summary>
    public BackstageDropDown():base(){}
    
            /// <summary>
    ///Initializes a new instance of the BackstageDropDown class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackstageDropDown(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BackstageDropDown class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackstageDropDown(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BackstageDropDown class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BackstageDropDown(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "item" == name)
    return new ItemBackstageItem();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "alignLabel" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>();
    
if( 0 == namespaceId && "expand" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "onAction" == name)
    return new StringValue();
    
if( 0 == namespaceId && "screentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getScreentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "supertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSupertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSelectedItemIndex" == name)
    return new StringValue();
    
if( 0 == namespaceId && "sizeString" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getItemCount" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getItemLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getItemID" == name)
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
        return CloneImp<BackstageDropDown>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RadioGroup Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:radioGroup.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RadioButtonBackstageItem &lt;mso14:radioButton></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(RadioButtonBackstageItem),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class RadioGroup : OpenXmlCompositeElement
{
    private const string tagName = "radioGroup";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13132;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","tag","alignLabel","expand","enabled","getEnabled","label","getLabel","visible","getVisible","onAction","keytip","getKeytip","getSelectedItemIndex","getItemCount","getItemLabel","getItemID" };
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
    public StringValue QualifiedId
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
    /// <para> alignLabel.</para>
    /// <para>Represents the following attribute in the schema: alignLabel </para>
    /// </summary>
    [SchemaAttr(0, "alignLabel")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> AlignLabel
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> expand.</para>
    /// <para>Represents the following attribute in the schema: expand </para>
    /// </summary>
    [SchemaAttr(0, "expand")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
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
    /// <para> getSelectedItemIndex.</para>
    /// <para>Represents the following attribute in the schema: getSelectedItemIndex </para>
    /// </summary>
    [SchemaAttr(0, "getSelectedItemIndex")]
    public StringValue GetSelectedItemIndex
    {
        get { return (StringValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> getItemCount.</para>
    /// <para>Represents the following attribute in the schema: getItemCount </para>
    /// </summary>
    [SchemaAttr(0, "getItemCount")]
    public StringValue GetItemCount
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> getItemLabel.</para>
    /// <para>Represents the following attribute in the schema: getItemLabel </para>
    /// </summary>
    [SchemaAttr(0, "getItemLabel")]
    public StringValue GetItemLabel
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> getItemID.</para>
    /// <para>Represents the following attribute in the schema: getItemID </para>
    /// </summary>
    [SchemaAttr(0, "getItemID")]
    public StringValue GetItemID
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RadioGroup class.
    /// </summary>
    public RadioGroup():base(){}
    
            /// <summary>
    ///Initializes a new instance of the RadioGroup class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RadioGroup(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the RadioGroup class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RadioGroup(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the RadioGroup class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public RadioGroup(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "radioButton" == name)
    return new RadioButtonBackstageItem();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "alignLabel" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>();
    
if( 0 == namespaceId && "expand" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "onAction" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSelectedItemIndex" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getItemCount" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getItemLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getItemID" == name)
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
        return CloneImp<RadioGroup>(deep);
    }

   
}
/// <summary>
/// <para>Defines the BackstageComboBox Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:comboBox.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ItemBackstageItem &lt;mso14:item></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ItemBackstageItem),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackstageComboBox : OpenXmlCompositeElement
{
    private const string tagName = "comboBox";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13133;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","tag","alignLabel","expand","enabled","getEnabled","label","getLabel","visible","getVisible","keytip","getKeytip","getText","onChange","sizeString","getItemCount","getItemLabel","getItemID" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    public StringValue QualifiedId
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
    /// <para> alignLabel.</para>
    /// <para>Represents the following attribute in the schema: alignLabel </para>
    /// </summary>
    [SchemaAttr(0, "alignLabel")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> AlignLabel
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> expand.</para>
    /// <para>Represents the following attribute in the schema: expand </para>
    /// </summary>
    [SchemaAttr(0, "expand")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> getText.</para>
    /// <para>Represents the following attribute in the schema: getText </para>
    /// </summary>
    [SchemaAttr(0, "getText")]
    public StringValue GetText
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> onChange.</para>
    /// <para>Represents the following attribute in the schema: onChange </para>
    /// </summary>
    [SchemaAttr(0, "onChange")]
    public StringValue OnChange
    {
        get { return (StringValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> sizeString.</para>
    /// <para>Represents the following attribute in the schema: sizeString </para>
    /// </summary>
    [SchemaAttr(0, "sizeString")]
    public StringValue SizeString
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> getItemCount.</para>
    /// <para>Represents the following attribute in the schema: getItemCount </para>
    /// </summary>
    [SchemaAttr(0, "getItemCount")]
    public StringValue GetItemCount
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> getItemLabel.</para>
    /// <para>Represents the following attribute in the schema: getItemLabel </para>
    /// </summary>
    [SchemaAttr(0, "getItemLabel")]
    public StringValue GetItemLabel
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> getItemID.</para>
    /// <para>Represents the following attribute in the schema: getItemID </para>
    /// </summary>
    [SchemaAttr(0, "getItemID")]
    public StringValue GetItemID
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BackstageComboBox class.
    /// </summary>
    public BackstageComboBox():base(){}
    
            /// <summary>
    ///Initializes a new instance of the BackstageComboBox class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackstageComboBox(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BackstageComboBox class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackstageComboBox(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BackstageComboBox class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BackstageComboBox(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "item" == name)
    return new ItemBackstageItem();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "alignLabel" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>();
    
if( 0 == namespaceId && "expand" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getText" == name)
    return new StringValue();
    
if( 0 == namespaceId && "onChange" == name)
    return new StringValue();
    
if( 0 == namespaceId && "sizeString" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getItemCount" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getItemLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getItemID" == name)
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
        return CloneImp<BackstageComboBox>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Hyperlink Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:hyperlink.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Hyperlink : OpenXmlLeafElement
{
    private const string tagName = "hyperlink";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13134;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","tag","alignLabel","expand","enabled","getEnabled","visible","getVisible","keytip","getKeytip","label","getLabel","onAction","image","imageMso","getImage","screentip","getScreentip","supertip","getSupertip","target","getTarget" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    public StringValue QualifiedId
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
    /// <para> alignLabel.</para>
    /// <para>Represents the following attribute in the schema: alignLabel </para>
    /// </summary>
    [SchemaAttr(0, "alignLabel")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> AlignLabel
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> expand.</para>
    /// <para>Represents the following attribute in the schema: expand </para>
    /// </summary>
    [SchemaAttr(0, "expand")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> target.</para>
    /// <para>Represents the following attribute in the schema: target </para>
    /// </summary>
    [SchemaAttr(0, "target")]
    public StringValue Target
    {
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> getTarget.</para>
    /// <para>Represents the following attribute in the schema: getTarget </para>
    /// </summary>
    [SchemaAttr(0, "getTarget")]
    public StringValue GetTarget
    {
        get { return (StringValue)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Hyperlink class.
    /// </summary>
    public Hyperlink():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "alignLabel" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>();
    
if( 0 == namespaceId && "expand" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "onAction" == name)
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
    
if( 0 == namespaceId && "target" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getTarget" == name)
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
        return CloneImp<Hyperlink>(deep);
    }

   
}
/// <summary>
/// <para>Defines the BackstageLabelControl Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:labelControl.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackstageLabelControl : OpenXmlLeafElement
{
    private const string tagName = "labelControl";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13135;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","tag","alignLabel","expand","enabled","getEnabled","label","getLabel","visible","getVisible","noWrap" };
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
    public StringValue QualifiedId
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
    /// <para> alignLabel.</para>
    /// <para>Represents the following attribute in the schema: alignLabel </para>
    /// </summary>
    [SchemaAttr(0, "alignLabel")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> AlignLabel
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> expand.</para>
    /// <para>Represents the following attribute in the schema: expand </para>
    /// </summary>
    [SchemaAttr(0, "expand")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> noWrap.</para>
    /// <para>Represents the following attribute in the schema: noWrap </para>
    /// </summary>
    [SchemaAttr(0, "noWrap")]
    public BooleanValue NoWrap
    {
        get { return (BooleanValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BackstageLabelControl class.
    /// </summary>
    public BackstageLabelControl():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "alignLabel" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>();
    
if( 0 == namespaceId && "expand" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "noWrap" == name)
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
        return CloneImp<BackstageLabelControl>(deep);
    }

   
}
/// <summary>
/// <para>Defines the GroupBox Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:groupBox.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BackstageGroupButton &lt;mso14:button></description></item>
///<item><description>BackstageCheckBox &lt;mso14:checkBox></description></item>
///<item><description>BackstageEditBox &lt;mso14:editBox></description></item>
///<item><description>BackstageDropDown &lt;mso14:dropDown></description></item>
///<item><description>RadioGroup &lt;mso14:radioGroup></description></item>
///<item><description>BackstageComboBox &lt;mso14:comboBox></description></item>
///<item><description>Hyperlink &lt;mso14:hyperlink></description></item>
///<item><description>BackstageLabelControl &lt;mso14:labelControl></description></item>
///<item><description>GroupBox &lt;mso14:groupBox></description></item>
///<item><description>LayoutContainer &lt;mso14:layoutContainer></description></item>
///<item><description>ImageControl &lt;mso14:imageControl></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(BackstageGroupButton),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(BackstageCheckBox),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(BackstageEditBox),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(BackstageDropDown),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(RadioGroup),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(BackstageComboBox),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(Hyperlink),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(BackstageLabelControl),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(GroupBox),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(LayoutContainer),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(ImageControl),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class GroupBox : OpenXmlCompositeElement
{
    private const string tagName = "groupBox";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13136;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","tag","expand","label","getLabel" };
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
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue QualifiedId
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
    /// <para> expand.</para>
    /// <para>Represents the following attribute in the schema: expand </para>
    /// </summary>
    [SchemaAttr(0, "expand")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>)Attributes[3]; }
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
    /// Initializes a new instance of the GroupBox class.
    /// </summary>
    public GroupBox():base(){}
    
            /// <summary>
    ///Initializes a new instance of the GroupBox class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GroupBox(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the GroupBox class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GroupBox(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the GroupBox class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public GroupBox(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "button" == name)
    return new BackstageGroupButton();
    
if( 57 == namespaceId && "checkBox" == name)
    return new BackstageCheckBox();
    
if( 57 == namespaceId && "editBox" == name)
    return new BackstageEditBox();
    
if( 57 == namespaceId && "dropDown" == name)
    return new BackstageDropDown();
    
if( 57 == namespaceId && "radioGroup" == name)
    return new RadioGroup();
    
if( 57 == namespaceId && "comboBox" == name)
    return new BackstageComboBox();
    
if( 57 == namespaceId && "hyperlink" == name)
    return new Hyperlink();
    
if( 57 == namespaceId && "labelControl" == name)
    return new BackstageLabelControl();
    
if( 57 == namespaceId && "groupBox" == name)
    return new GroupBox();
    
if( 57 == namespaceId && "layoutContainer" == name)
    return new LayoutContainer();
    
if( 57 == namespaceId && "imageControl" == name)
    return new ImageControl();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "expand" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
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
        return CloneImp<GroupBox>(deep);
    }

   
}
/// <summary>
/// <para>Defines the LayoutContainer Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:layoutContainer.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BackstageGroupButton &lt;mso14:button></description></item>
///<item><description>BackstageCheckBox &lt;mso14:checkBox></description></item>
///<item><description>BackstageEditBox &lt;mso14:editBox></description></item>
///<item><description>BackstageDropDown &lt;mso14:dropDown></description></item>
///<item><description>RadioGroup &lt;mso14:radioGroup></description></item>
///<item><description>BackstageComboBox &lt;mso14:comboBox></description></item>
///<item><description>Hyperlink &lt;mso14:hyperlink></description></item>
///<item><description>BackstageLabelControl &lt;mso14:labelControl></description></item>
///<item><description>GroupBox &lt;mso14:groupBox></description></item>
///<item><description>LayoutContainer &lt;mso14:layoutContainer></description></item>
///<item><description>ImageControl &lt;mso14:imageControl></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(BackstageGroupButton),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(BackstageCheckBox),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(BackstageEditBox),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(BackstageDropDown),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(RadioGroup),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(BackstageComboBox),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(Hyperlink),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(BackstageLabelControl),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(GroupBox),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(LayoutContainer),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(ImageControl),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class LayoutContainer : OpenXmlCompositeElement
{
    private const string tagName = "layoutContainer";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13137;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","tag","align","expand","layoutChildren" };
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
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue QualifiedId
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
    /// <para> align.</para>
    /// <para>Represents the following attribute in the schema: align </para>
    /// </summary>
    [SchemaAttr(0, "align")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Align
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> expand.</para>
    /// <para>Represents the following attribute in the schema: expand </para>
    /// </summary>
    [SchemaAttr(0, "expand")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues> Expand
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> layoutChildren.</para>
    /// <para>Represents the following attribute in the schema: layoutChildren </para>
    /// </summary>
    [SchemaAttr(0, "layoutChildren")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.LayoutChildrenValues> LayoutChildren
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.LayoutChildrenValues>)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the LayoutContainer class.
    /// </summary>
    public LayoutContainer():base(){}
    
            /// <summary>
    ///Initializes a new instance of the LayoutContainer class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LayoutContainer(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LayoutContainer class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LayoutContainer(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LayoutContainer class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public LayoutContainer(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "button" == name)
    return new BackstageGroupButton();
    
if( 57 == namespaceId && "checkBox" == name)
    return new BackstageCheckBox();
    
if( 57 == namespaceId && "editBox" == name)
    return new BackstageEditBox();
    
if( 57 == namespaceId && "dropDown" == name)
    return new BackstageDropDown();
    
if( 57 == namespaceId && "radioGroup" == name)
    return new RadioGroup();
    
if( 57 == namespaceId && "comboBox" == name)
    return new BackstageComboBox();
    
if( 57 == namespaceId && "hyperlink" == name)
    return new Hyperlink();
    
if( 57 == namespaceId && "labelControl" == name)
    return new BackstageLabelControl();
    
if( 57 == namespaceId && "groupBox" == name)
    return new GroupBox();
    
if( 57 == namespaceId && "layoutContainer" == name)
    return new LayoutContainer();
    
if( 57 == namespaceId && "imageControl" == name)
    return new ImageControl();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "align" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>();
    
if( 0 == namespaceId && "expand" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>();
    
if( 0 == namespaceId && "layoutChildren" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.LayoutChildrenValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<LayoutContainer>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ImageControl Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:imageControl.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ImageControl : OpenXmlLeafElement
{
    private const string tagName = "imageControl";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13138;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","tag","enabled","getEnabled","visible","getVisible","image","imageMso","getImage","altText","getAltText" };
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
    public StringValue QualifiedId
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
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
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
    /// <para> altText.</para>
    /// <para>Represents the following attribute in the schema: altText </para>
    /// </summary>
    [SchemaAttr(0, "altText")]
    public StringValue AltText
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> getAltText.</para>
    /// <para>Represents the following attribute in the schema: getAltText </para>
    /// </summary>
    [SchemaAttr(0, "getAltText")]
    public StringValue GetAltText
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ImageControl class.
    /// </summary>
    public ImageControl():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "image" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imageMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getImage" == name)
    return new StringValue();
    
if( 0 == namespaceId && "altText" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getAltText" == name)
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
        return CloneImp<ImageControl>(deep);
    }

   
}
/// <summary>
/// <para>Defines the BackstageGroup Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:group.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PrimaryItem &lt;mso14:primaryItem></description></item>
///<item><description>TopItemsGroupControls &lt;mso14:topItems></description></item>
///<item><description>BottomItemsGroupControls &lt;mso14:bottomItems></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(PrimaryItem),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(TopItemsGroupControls),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(BottomItemsGroupControls),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackstageGroup : OpenXmlCompositeElement
{
    private const string tagName = "group";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13139;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","tag","idMso","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","label","getLabel","visible","getVisible","style","getStyle","helperText","getHelperText","showLabel","getShowLabel" };
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
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
    /// <para> style.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.StyleValues> Style
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.StyleValues>)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> getStyle.</para>
    /// <para>Represents the following attribute in the schema: getStyle </para>
    /// </summary>
    [SchemaAttr(0, "getStyle")]
    public StringValue GetStyle
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> helperText.</para>
    /// <para>Represents the following attribute in the schema: helperText </para>
    /// </summary>
    [SchemaAttr(0, "helperText")]
    public StringValue HelperText
    {
        get { return (StringValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> getHelperText.</para>
    /// <para>Represents the following attribute in the schema: getHelperText </para>
    /// </summary>
    [SchemaAttr(0, "getHelperText")]
    public StringValue GetHelperText
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
    /// Initializes a new instance of the BackstageGroup class.
    /// </summary>
    public BackstageGroup():base(){}
    
            /// <summary>
    ///Initializes a new instance of the BackstageGroup class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackstageGroup(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BackstageGroup class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackstageGroup(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BackstageGroup class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BackstageGroup(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "primaryItem" == name)
    return new PrimaryItem();
    
if( 57 == namespaceId && "topItems" == name)
    return new TopItemsGroupControls();
    
if( 57 == namespaceId && "bottomItems" == name)
    return new BottomItemsGroupControls();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "style" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.StyleValues>();
    
if( 0 == namespaceId && "getStyle" == name)
    return new StringValue();
    
if( 0 == namespaceId && "helperText" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getHelperText" == name)
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
        return CloneImp<BackstageGroup>(deep);
    }

   
}
/// <summary>
/// <para>Defines the TaskGroup Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:taskGroup.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TaskGroupCategory &lt;mso14:category></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(TaskGroupCategory),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class TaskGroup : OpenXmlCompositeElement
{
    private const string tagName = "taskGroup";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13140;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","tag","idMso","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","label","getLabel","visible","getVisible","helperText","getHelperText","showLabel","getShowLabel","allowedTaskSizes" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
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
    /// <para> helperText.</para>
    /// <para>Represents the following attribute in the schema: helperText </para>
    /// </summary>
    [SchemaAttr(0, "helperText")]
    public StringValue HelperText
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> getHelperText.</para>
    /// <para>Represents the following attribute in the schema: getHelperText </para>
    /// </summary>
    [SchemaAttr(0, "getHelperText")]
    public StringValue GetHelperText
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
    /// <para> allowedTaskSizes.</para>
    /// <para>Represents the following attribute in the schema: allowedTaskSizes </para>
    /// </summary>
    [SchemaAttr(0, "allowedTaskSizes")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.TaskSizesValues> AllowedTaskSizes
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.TaskSizesValues>)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the TaskGroup class.
    /// </summary>
    public TaskGroup():base(){}
    
            /// <summary>
    ///Initializes a new instance of the TaskGroup class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TaskGroup(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TaskGroup class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TaskGroup(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TaskGroup class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TaskGroup(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "category" == name)
    return new TaskGroupCategory();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "helperText" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getHelperText" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showLabel" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "allowedTaskSizes" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.TaskSizesValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<TaskGroup>(deep);
    }

   
}
/// <summary>
/// <para>Defines the MenuRoot Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:menu.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlCloneRegular &lt;mso14:control></description></item>
///<item><description>ButtonRegular &lt;mso14:button></description></item>
///<item><description>CheckBox &lt;mso14:checkBox></description></item>
///<item><description>GalleryRegular &lt;mso14:gallery></description></item>
///<item><description>ToggleButtonRegular &lt;mso14:toggleButton></description></item>
///<item><description>MenuSeparator &lt;mso14:menuSeparator></description></item>
///<item><description>SplitButtonRegular &lt;mso14:splitButton></description></item>
///<item><description>MenuRegular &lt;mso14:menu></description></item>
///<item><description>DynamicMenuRegular &lt;mso14:dynamicMenu></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ControlCloneRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(ButtonRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(CheckBox),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(GalleryRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(ToggleButtonRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(MenuSeparator),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(SplitButtonRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(MenuRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DynamicMenuRegular),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
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
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13141;
    
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
		if((6 & (int)version) > 0)
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
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues> ItemSize
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>)Attributes[2]; }
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
    if( 57 == namespaceId && "control" == name)
    return new ControlCloneRegular();
    
if( 57 == namespaceId && "button" == name)
    return new ButtonRegular();
    
if( 57 == namespaceId && "checkBox" == name)
    return new CheckBox();
    
if( 57 == namespaceId && "gallery" == name)
    return new GalleryRegular();
    
if( 57 == namespaceId && "toggleButton" == name)
    return new ToggleButtonRegular();
    
if( 57 == namespaceId && "menuSeparator" == name)
    return new MenuSeparator();
    
if( 57 == namespaceId && "splitButton" == name)
    return new SplitButtonRegular();
    
if( 57 == namespaceId && "menu" == name)
    return new MenuRegular();
    
if( 57 == namespaceId && "dynamicMenu" == name)
    return new DynamicMenuRegular();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "title" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getTitle" == name)
    return new StringValue();
    
if( 0 == namespaceId && "itemSize" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>();
    

    
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
/// <para>Defines the CustomUI Class. The root element of RibbonAndBackstageCustomizationsPart.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:customUI.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Commands &lt;mso14:commands></description></item>
///<item><description>Ribbon &lt;mso14:ribbon></description></item>
///<item><description>Backstage &lt;mso14:backstage></description></item>
///<item><description>ContextMenus &lt;mso14:contextMenus></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Commands),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(Ribbon),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(Backstage),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(ContextMenus),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
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
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13142;
    
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
		if((6 & (int)version) > 0)
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
    /// CustomUI constructor.
    /// </summary>
    /// <param name="ownerPart">The owner part of the CustomUI.</param>
    internal CustomUI(RibbonAndBackstageCustomizationsPart ownerPart) : base (ownerPart )
    {
    }
    
    /// <summary>
    /// Loads the DOM from the RibbonAndBackstageCustomizationsPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(RibbonAndBackstageCustomizationsPart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the RibbonAndBackstageCustomizationsPart associated with this element.
    /// </summary>
    public RibbonAndBackstageCustomizationsPart RibbonAndBackstageCustomizationsPart
    {
		get
		{
			return OpenXmlPart as RibbonAndBackstageCustomizationsPart;
		}
		internal set
		{
			OpenXmlPart = value;
		}
    }
    
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

    
    
    /// <summary>
    /// Initializes a new instance of the CustomUI class.
    /// </summary>
    public CustomUI() : base ()
    {
    }
    
    /// <summary>
    /// Saves the DOM into the RibbonAndBackstageCustomizationsPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(RibbonAndBackstageCustomizationsPart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "commands" == name)
    return new Commands();
    
if( 57 == namespaceId && "ribbon" == name)
    return new Ribbon();
    
if( 57 == namespaceId && "backstage" == name)
    return new Backstage();
    
if( 57 == namespaceId && "contextMenus" == name)
    return new ContextMenus();
    

    return null;
}

        private static readonly string[] eleTagNames = { "commands","ribbon","backstage","contextMenus" };
    private static readonly byte[] eleNamespaceIds = { 57,57,57,57 };
    
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
    /// <para> Commands.</para>
    /// <para> Represents the following element tag in the schema: mso14:commands </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
    /// </remark>
    public Commands Commands
    {
        get 
        {
            return GetElement<Commands>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> Ribbon.</para>
    /// <para> Represents the following element tag in the schema: mso14:ribbon </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
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
    /// <summary>
    /// <para> Backstage.</para>
    /// <para> Represents the following element tag in the schema: mso14:backstage </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
    /// </remark>
    public Backstage Backstage
    {
        get 
        {
            return GetElement<Backstage>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> ContextMenus.</para>
    /// <para> Represents the following element tag in the schema: mso14:contextMenus </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
    /// </remark>
    public ContextMenus ContextMenus
    {
        get 
        {
            return GetElement<ContextMenus>(3);
        }
        set
        {
            SetElement(3, value);
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
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:item.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
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
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13143;
    
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
		if((6 & (int)version) > 0)
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
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:button.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
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
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13144;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "onAction","enabled","getEnabled","description","getDescription","image","imageMso","getImage","id","idQ","tag","idMso","screentip","getScreentip","supertip","getSupertip","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
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
    public StringValue QualifiedId
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> tag.</para>
    /// <para>Represents the following attribute in the schema: tag </para>
    /// </summary>
    [SchemaAttr(0, "tag")]
    public StringValue Tag
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
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
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:toggleButton.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
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
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13145;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "getPressed","onAction","enabled","getEnabled","description","getDescription","image","imageMso","getImage","id","idQ","tag","idMso","screentip","getScreentip","supertip","getSupertip","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","keytip","getKeytip","showLabel","getShowLabel","showImage","getShowImage" };
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
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
/// <para>Defines the Separator Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:separator.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Separator : OpenXmlLeafElement
{
    private const string tagName = "separator";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13146;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","tag","visible","getVisible","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ" };
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
    public StringValue QualifiedId
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
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Separator class.
    /// </summary>
    public Separator():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
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
        return CloneImp<Separator>(deep);
    }

   
}
/// <summary>
/// <para>Defines the DialogBoxLauncher Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:dialogBoxLauncher.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ButtonRegular &lt;mso14:button></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ButtonRegular),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
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
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13147;
    
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
		if((6 & (int)version) > 0)
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
    if( 57 == namespaceId && "button" == name)
    return new ButtonRegular();
    

    return null;
}

        private static readonly string[] eleTagNames = { "button" };
    private static readonly byte[] eleNamespaceIds = { 57 };
    
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
    /// <para> ButtonRegular.</para>
    /// <para> Represents the following element tag in the schema: mso14:button </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
    /// </remark>
    public ButtonRegular ButtonRegular
    {
        get 
        {
            return GetElement<ButtonRegular>(0);
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
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:group.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlClone &lt;mso14:control></description></item>
///<item><description>LabelControl &lt;mso14:labelControl></description></item>
///<item><description>Button &lt;mso14:button></description></item>
///<item><description>ToggleButton &lt;mso14:toggleButton></description></item>
///<item><description>CheckBox &lt;mso14:checkBox></description></item>
///<item><description>EditBox &lt;mso14:editBox></description></item>
///<item><description>ComboBox &lt;mso14:comboBox></description></item>
///<item><description>DropDownRegular &lt;mso14:dropDown></description></item>
///<item><description>Gallery &lt;mso14:gallery></description></item>
///<item><description>Menu &lt;mso14:menu></description></item>
///<item><description>DynamicMenu &lt;mso14:dynamicMenu></description></item>
///<item><description>SplitButton &lt;mso14:splitButton></description></item>
///<item><description>Box &lt;mso14:box></description></item>
///<item><description>ButtonGroup &lt;mso14:buttonGroup></description></item>
///<item><description>Separator &lt;mso14:separator></description></item>
///<item><description>DialogBoxLauncher &lt;mso14:dialogBoxLauncher></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ControlClone),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(LabelControl),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(Button),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(ToggleButton),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(CheckBox),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(EditBox),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(ComboBox),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DropDownRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(Gallery),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(Menu),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DynamicMenu),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(SplitButton),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(Box),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(ButtonGroup),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(Separator),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DialogBoxLauncher),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
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
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13148;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","tag","idMso","label","getLabel","image","imageMso","getImage","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","screentip","getScreentip","supertip","getSupertip","visible","getVisible","keytip","getKeytip","autoScale","centerVertically" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    /// <para> autoScale.</para>
    /// <para>Represents the following attribute in the schema: autoScale </para>
    /// </summary>
    [SchemaAttr(0, "autoScale")]
    public BooleanValue AutoScale
    {
        get { return (BooleanValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> centerVertically.</para>
    /// <para>Represents the following attribute in the schema: centerVertically </para>
    /// </summary>
    [SchemaAttr(0, "centerVertically")]
    public BooleanValue CenterVertically
    {
        get { return (BooleanValue)Attributes[22]; }
        set { Attributes[22] = value; }
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
    if( 57 == namespaceId && "control" == name)
    return new ControlClone();
    
if( 57 == namespaceId && "labelControl" == name)
    return new LabelControl();
    
if( 57 == namespaceId && "button" == name)
    return new Button();
    
if( 57 == namespaceId && "toggleButton" == name)
    return new ToggleButton();
    
if( 57 == namespaceId && "checkBox" == name)
    return new CheckBox();
    
if( 57 == namespaceId && "editBox" == name)
    return new EditBox();
    
if( 57 == namespaceId && "comboBox" == name)
    return new ComboBox();
    
if( 57 == namespaceId && "dropDown" == name)
    return new DropDownRegular();
    
if( 57 == namespaceId && "gallery" == name)
    return new Gallery();
    
if( 57 == namespaceId && "menu" == name)
    return new Menu();
    
if( 57 == namespaceId && "dynamicMenu" == name)
    return new DynamicMenu();
    
if( 57 == namespaceId && "splitButton" == name)
    return new SplitButton();
    
if( 57 == namespaceId && "box" == name)
    return new Box();
    
if( 57 == namespaceId && "buttonGroup" == name)
    return new ButtonGroup();
    
if( 57 == namespaceId && "separator" == name)
    return new Separator();
    
if( 57 == namespaceId && "dialogBoxLauncher" == name)
    return new DialogBoxLauncher();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
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
    
if( 0 == namespaceId && "autoScale" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "centerVertically" == name)
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
        return CloneImp<Group>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ControlCloneQat Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:control.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ControlCloneQat : OpenXmlLeafElement
{
    private const string tagName = "control";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13149;
    
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
		if((6 & (int)version) > 0)
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
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues> Size
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>)Attributes[5]; }
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    /// Initializes a new instance of the ControlCloneQat class.
    /// </summary>
    public ControlCloneQat():base(){}
    
      
     
    
    
    
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
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>();
    
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
        return CloneImp<ControlCloneQat>(deep);
    }

   
}
/// <summary>
/// <para>Defines the SharedControlsQatItems Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:sharedControls.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlCloneQat &lt;mso14:control></description></item>
///<item><description>ButtonRegular &lt;mso14:button></description></item>
///<item><description>Separator &lt;mso14:separator></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SharedControlsQatItems : QatItemsType
{
    private const string tagName = "sharedControls";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13150;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the SharedControlsQatItems class.
    /// </summary>
    public SharedControlsQatItems():base(){}
            /// <summary>
    ///Initializes a new instance of the SharedControlsQatItems class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SharedControlsQatItems(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SharedControlsQatItems class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SharedControlsQatItems(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SharedControlsQatItems class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SharedControlsQatItems(string outerXml)
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
        return CloneImp<SharedControlsQatItems>(deep);
    }

}
/// <summary>
/// <para>Defines the DocumentControlsQatItems Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:documentControls.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlCloneQat &lt;mso14:control></description></item>
///<item><description>ButtonRegular &lt;mso14:button></description></item>
///<item><description>Separator &lt;mso14:separator></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class DocumentControlsQatItems : QatItemsType
{
    private const string tagName = "documentControls";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13151;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the DocumentControlsQatItems class.
    /// </summary>
    public DocumentControlsQatItems():base(){}
            /// <summary>
    ///Initializes a new instance of the DocumentControlsQatItems class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DocumentControlsQatItems(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DocumentControlsQatItems class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DocumentControlsQatItems(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DocumentControlsQatItems class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DocumentControlsQatItems(string outerXml)
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
        return CloneImp<DocumentControlsQatItems>(deep);
    }

}
/// <summary>
/// Defines the QatItemsType class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlCloneQat &lt;mso14:control></description></item>
///<item><description>ButtonRegular &lt;mso14:button></description></item>
///<item><description>Separator &lt;mso14:separator></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ControlCloneQat),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(ButtonRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(Separator),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class QatItemsType : OpenXmlCompositeElement
{
        
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "control" == name)
    return new ControlCloneQat();
    
if( 57 == namespaceId && "button" == name)
    return new ButtonRegular();
    
if( 57 == namespaceId && "separator" == name)
    return new Separator();
    

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
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:tab.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Group &lt;mso14:group></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Group),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
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
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13152;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","tag","idMso","label","getLabel","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","keytip","getKeytip" };
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    if( 57 == namespaceId && "group" == name)
    return new Group();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
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
/// <para>Defines the TabSet Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:tabSet.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Tab &lt;mso14:tab></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Tab),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class TabSet : OpenXmlCompositeElement
{
    private const string tagName = "tabSet";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13153;
    
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
		if((6 & (int)version) > 0)
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
    /// Initializes a new instance of the TabSet class.
    /// </summary>
    public TabSet():base(){}
    
            /// <summary>
    ///Initializes a new instance of the TabSet class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TabSet(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TabSet class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TabSet(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TabSet class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TabSet(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "tab" == name)
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
        return CloneImp<TabSet>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Command Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:command.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Command : OpenXmlLeafElement
{
    private const string tagName = "command";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13154;
    
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
		if((6 & (int)version) > 0)
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
    /// Initializes a new instance of the Command class.
    /// </summary>
    public Command():base(){}
    
      
     
    
    
    
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
        return CloneImp<Command>(deep);
    }

   
}
/// <summary>
/// <para>Defines the QuickAccessToolbar Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:qat.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SharedControlsQatItems &lt;mso14:sharedControls></description></item>
///<item><description>DocumentControlsQatItems &lt;mso14:documentControls></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(SharedControlsQatItems),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DocumentControlsQatItems),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
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
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13155;
    
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
		if((6 & (int)version) > 0)
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
    if( 57 == namespaceId && "sharedControls" == name)
    return new SharedControlsQatItems();
    
if( 57 == namespaceId && "documentControls" == name)
    return new DocumentControlsQatItems();
    

    return null;
}

        private static readonly string[] eleTagNames = { "sharedControls","documentControls" };
    private static readonly byte[] eleNamespaceIds = { 57,57 };
    
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
    /// <para> SharedControlsQatItems.</para>
    /// <para> Represents the following element tag in the schema: mso14:sharedControls </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
    /// </remark>
    public SharedControlsQatItems SharedControlsQatItems
    {
        get 
        {
            return GetElement<SharedControlsQatItems>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> DocumentControlsQatItems.</para>
    /// <para> Represents the following element tag in the schema: mso14:documentControls </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
    /// </remark>
    public DocumentControlsQatItems DocumentControlsQatItems
    {
        get 
        {
            return GetElement<DocumentControlsQatItems>(1);
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
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:tabs.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Tab &lt;mso14:tab></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Tab),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
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
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13156;
    
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
		if((6 & (int)version) > 0)
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
    if( 57 == namespaceId && "tab" == name)
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
/// <para>Defines the ContextualTabs Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:contextualTabs.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TabSet &lt;mso14:tabSet></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(TabSet),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ContextualTabs : OpenXmlCompositeElement
{
    private const string tagName = "contextualTabs";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13157;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ContextualTabs class.
    /// </summary>
    public ContextualTabs():base(){}
    
            /// <summary>
    ///Initializes a new instance of the ContextualTabs class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ContextualTabs(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ContextualTabs class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ContextualTabs(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ContextualTabs class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ContextualTabs(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "tabSet" == name)
    return new TabSet();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ContextualTabs>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ContextMenu Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:contextMenu.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlCloneRegular &lt;mso14:control></description></item>
///<item><description>ButtonRegular &lt;mso14:button></description></item>
///<item><description>CheckBox &lt;mso14:checkBox></description></item>
///<item><description>GalleryRegular &lt;mso14:gallery></description></item>
///<item><description>ToggleButtonRegular &lt;mso14:toggleButton></description></item>
///<item><description>SplitButtonRegular &lt;mso14:splitButton></description></item>
///<item><description>MenuRegular &lt;mso14:menu></description></item>
///<item><description>DynamicMenuRegular &lt;mso14:dynamicMenu></description></item>
///<item><description>MenuSeparatorNoTitle &lt;mso14:menuSeparator></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ControlCloneRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(ButtonRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(CheckBox),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(GalleryRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(ToggleButtonRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(SplitButtonRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(MenuRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DynamicMenuRegular),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(MenuSeparatorNoTitle),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ContextMenu : OpenXmlCompositeElement
{
    private const string tagName = "contextMenu";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13158;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "idMso" };
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
    /// Initializes a new instance of the ContextMenu class.
    /// </summary>
    public ContextMenu():base(){}
    
            /// <summary>
    ///Initializes a new instance of the ContextMenu class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ContextMenu(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ContextMenu class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ContextMenu(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ContextMenu class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ContextMenu(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "control" == name)
    return new ControlCloneRegular();
    
if( 57 == namespaceId && "button" == name)
    return new ButtonRegular();
    
if( 57 == namespaceId && "checkBox" == name)
    return new CheckBox();
    
if( 57 == namespaceId && "gallery" == name)
    return new GalleryRegular();
    
if( 57 == namespaceId && "toggleButton" == name)
    return new ToggleButtonRegular();
    
if( 57 == namespaceId && "splitButton" == name)
    return new SplitButtonRegular();
    
if( 57 == namespaceId && "menu" == name)
    return new MenuRegular();
    
if( 57 == namespaceId && "dynamicMenu" == name)
    return new DynamicMenuRegular();
    
if( 57 == namespaceId && "menuSeparator" == name)
    return new MenuSeparatorNoTitle();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
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
        return CloneImp<ContextMenu>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ItemBackstageItem Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:item.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ItemBackstageItem : BackstageItemType
{
    private const string tagName = "item";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13159;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the ItemBackstageItem class.
    /// </summary>
    public ItemBackstageItem():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ItemBackstageItem>(deep);
    }

}
/// <summary>
/// <para>Defines the RadioButtonBackstageItem Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:radioButton.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class RadioButtonBackstageItem : BackstageItemType
{
    private const string tagName = "radioButton";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13160;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the RadioButtonBackstageItem class.
    /// </summary>
    public RadioButtonBackstageItem():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RadioButtonBackstageItem>(deep);
    }

}
/// <summary>
/// Defines the BackstageItemType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class BackstageItemType : OpenXmlLeafElement
{
    private static string[] attributeTagNames = { "id","label","getLabel" };
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
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    

    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

    
    /// <summary>
    /// Initializes a new instance of the BackstageItemType class.
    /// </summary>
    protected BackstageItemType(){}
    
    
    
}
/// <summary>
/// <para>Defines the BackstageRegularButton Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:button.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackstageRegularButton : OpenXmlLeafElement
{
    private const string tagName = "button";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13161;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "screentip","getScreentip","supertip","getSupertip","id","idQ","tag","onAction","isDefinitive","enabled","getEnabled","label","getLabel","visible","getVisible","keytip","getKeytip","image","imageMso","getImage" };
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
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
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
    public StringValue QualifiedId
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
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> isDefinitive.</para>
    /// <para>Represents the following attribute in the schema: isDefinitive </para>
    /// </summary>
    [SchemaAttr(0, "isDefinitive")]
    public BooleanValue IsDefinitive
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
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BackstageRegularButton class.
    /// </summary>
    public BackstageRegularButton():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "screentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getScreentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "supertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSupertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "onAction" == name)
    return new StringValue();
    
if( 0 == namespaceId && "isDefinitive" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "image" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imageMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getImage" == name)
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
        return CloneImp<BackstageRegularButton>(deep);
    }

   
}
/// <summary>
/// <para>Defines the BackstagePrimaryMenu Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:menu.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BackstageMenuGroup &lt;mso14:menuGroup></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(BackstageMenuGroup),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackstagePrimaryMenu : OpenXmlCompositeElement
{
    private const string tagName = "menu";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13162;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "screentip","getScreentip","supertip","getSupertip","id","idQ","tag","enabled","getEnabled","label","getLabel","visible","getVisible","image","imageMso","getImage","keytip","getKeytip" };
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
    /// <para> screentip.</para>
    /// <para>Represents the following attribute in the schema: screentip </para>
    /// </summary>
    [SchemaAttr(0, "screentip")]
    public StringValue Screentip
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> getScreentip.</para>
    /// <para>Represents the following attribute in the schema: getScreentip </para>
    /// </summary>
    [SchemaAttr(0, "getScreentip")]
    public StringValue GetScreentip
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> supertip.</para>
    /// <para>Represents the following attribute in the schema: supertip </para>
    /// </summary>
    [SchemaAttr(0, "supertip")]
    public StringValue Supertip
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> getSupertip.</para>
    /// <para>Represents the following attribute in the schema: getSupertip </para>
    /// </summary>
    [SchemaAttr(0, "getSupertip")]
    public StringValue GetSupertip
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
    public StringValue QualifiedId
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
    /// <para> enabled.</para>
    /// <para>Represents the following attribute in the schema: enabled </para>
    /// </summary>
    [SchemaAttr(0, "enabled")]
    public BooleanValue Enabled
    {
        get { return (BooleanValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> getEnabled.</para>
    /// <para>Represents the following attribute in the schema: getEnabled </para>
    /// </summary>
    [SchemaAttr(0, "getEnabled")]
    public StringValue GetEnabled
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
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
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BackstagePrimaryMenu class.
    /// </summary>
    public BackstagePrimaryMenu():base(){}
    
            /// <summary>
    ///Initializes a new instance of the BackstagePrimaryMenu class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackstagePrimaryMenu(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BackstagePrimaryMenu class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackstagePrimaryMenu(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BackstagePrimaryMenu class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BackstagePrimaryMenu(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "menuGroup" == name)
    return new BackstageMenuGroup();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "screentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getScreentip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "supertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getSupertip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "image" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imageMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getImage" == name)
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
        return CloneImp<BackstagePrimaryMenu>(deep);
    }

   
}
/// <summary>
/// <para>Defines the BackstageMenuGroup Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:menuGroup.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BackstageMenuButton &lt;mso14:button></description></item>
///<item><description>BackstageMenuCheckBox &lt;mso14:checkBox></description></item>
///<item><description>BackstageSubMenu &lt;mso14:menu></description></item>
///<item><description>BackstageMenuToggleButton &lt;mso14:toggleButton></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(BackstageMenuButton),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(BackstageMenuCheckBox),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(BackstageSubMenu),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(BackstageMenuToggleButton),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackstageMenuGroup : OpenXmlCompositeElement
{
    private const string tagName = "menuGroup";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13163;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","tag","label","getLabel","itemSize" };
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
    /// <para> idQ.</para>
    /// <para>Represents the following attribute in the schema: idQ </para>
    /// </summary>
    [SchemaAttr(0, "idQ")]
    public StringValue QualifiedId
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
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    
    /// <summary>
    /// <para> itemSize.</para>
    /// <para>Represents the following attribute in the schema: itemSize </para>
    /// </summary>
    [SchemaAttr(0, "itemSize")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues> ItemSize
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>)Attributes[5]; }
        set { Attributes[5] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BackstageMenuGroup class.
    /// </summary>
    public BackstageMenuGroup():base(){}
    
            /// <summary>
    ///Initializes a new instance of the BackstageMenuGroup class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackstageMenuGroup(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BackstageMenuGroup class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackstageMenuGroup(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BackstageMenuGroup class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BackstageMenuGroup(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "button" == name)
    return new BackstageMenuButton();
    
if( 57 == namespaceId && "checkBox" == name)
    return new BackstageMenuCheckBox();
    
if( 57 == namespaceId && "menu" == name)
    return new BackstageSubMenu();
    
if( 57 == namespaceId && "toggleButton" == name)
    return new BackstageMenuToggleButton();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "itemSize" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<BackstageMenuGroup>(deep);
    }

   
}
/// <summary>
/// <para>Defines the PrimaryItem Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:primaryItem.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BackstageRegularButton &lt;mso14:button></description></item>
///<item><description>BackstagePrimaryMenu &lt;mso14:menu></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(BackstageRegularButton),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(BackstagePrimaryMenu),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class PrimaryItem : OpenXmlCompositeElement
{
    private const string tagName = "primaryItem";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13164;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the PrimaryItem class.
    /// </summary>
    public PrimaryItem():base(){}
    
            /// <summary>
    ///Initializes a new instance of the PrimaryItem class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PrimaryItem(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PrimaryItem class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PrimaryItem(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PrimaryItem class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PrimaryItem(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "button" == name)
    return new BackstageRegularButton();
    
if( 57 == namespaceId && "menu" == name)
    return new BackstagePrimaryMenu();
    

    return null;
}

        private static readonly string[] eleTagNames = { "button","menu" };
    private static readonly byte[] eleNamespaceIds = { 57,57 };
    
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
        get {return OpenXmlCompositeType.OneChoice;}
    }
    
        /// <summary>
    /// <para> BackstageRegularButton.</para>
    /// <para> Represents the following element tag in the schema: mso14:button </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
    /// </remark>
    public BackstageRegularButton BackstageRegularButton
    {
        get 
        {
            return GetElement<BackstageRegularButton>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> BackstagePrimaryMenu.</para>
    /// <para> Represents the following element tag in the schema: mso14:menu </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
    /// </remark>
    public BackstagePrimaryMenu BackstagePrimaryMenu
    {
        get 
        {
            return GetElement<BackstagePrimaryMenu>(1);
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
        return CloneImp<PrimaryItem>(deep);
    }

   
}
/// <summary>
/// <para>Defines the TopItemsGroupControls Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:topItems.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BackstageGroupButton &lt;mso14:button></description></item>
///<item><description>BackstageCheckBox &lt;mso14:checkBox></description></item>
///<item><description>BackstageEditBox &lt;mso14:editBox></description></item>
///<item><description>BackstageDropDown &lt;mso14:dropDown></description></item>
///<item><description>RadioGroup &lt;mso14:radioGroup></description></item>
///<item><description>BackstageComboBox &lt;mso14:comboBox></description></item>
///<item><description>Hyperlink &lt;mso14:hyperlink></description></item>
///<item><description>BackstageLabelControl &lt;mso14:labelControl></description></item>
///<item><description>GroupBox &lt;mso14:groupBox></description></item>
///<item><description>LayoutContainer &lt;mso14:layoutContainer></description></item>
///<item><description>ImageControl &lt;mso14:imageControl></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class TopItemsGroupControls : GroupControlsType
{
    private const string tagName = "topItems";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13165;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the TopItemsGroupControls class.
    /// </summary>
    public TopItemsGroupControls():base(){}
            /// <summary>
    ///Initializes a new instance of the TopItemsGroupControls class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TopItemsGroupControls(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TopItemsGroupControls class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TopItemsGroupControls(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TopItemsGroupControls class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TopItemsGroupControls(string outerXml)
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
        return CloneImp<TopItemsGroupControls>(deep);
    }

}
/// <summary>
/// <para>Defines the BottomItemsGroupControls Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:bottomItems.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BackstageGroupButton &lt;mso14:button></description></item>
///<item><description>BackstageCheckBox &lt;mso14:checkBox></description></item>
///<item><description>BackstageEditBox &lt;mso14:editBox></description></item>
///<item><description>BackstageDropDown &lt;mso14:dropDown></description></item>
///<item><description>RadioGroup &lt;mso14:radioGroup></description></item>
///<item><description>BackstageComboBox &lt;mso14:comboBox></description></item>
///<item><description>Hyperlink &lt;mso14:hyperlink></description></item>
///<item><description>BackstageLabelControl &lt;mso14:labelControl></description></item>
///<item><description>GroupBox &lt;mso14:groupBox></description></item>
///<item><description>LayoutContainer &lt;mso14:layoutContainer></description></item>
///<item><description>ImageControl &lt;mso14:imageControl></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BottomItemsGroupControls : GroupControlsType
{
    private const string tagName = "bottomItems";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13166;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the BottomItemsGroupControls class.
    /// </summary>
    public BottomItemsGroupControls():base(){}
            /// <summary>
    ///Initializes a new instance of the BottomItemsGroupControls class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BottomItemsGroupControls(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BottomItemsGroupControls class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BottomItemsGroupControls(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BottomItemsGroupControls class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BottomItemsGroupControls(string outerXml)
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
        return CloneImp<BottomItemsGroupControls>(deep);
    }

}
/// <summary>
/// Defines the GroupControlsType class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BackstageGroupButton &lt;mso14:button></description></item>
///<item><description>BackstageCheckBox &lt;mso14:checkBox></description></item>
///<item><description>BackstageEditBox &lt;mso14:editBox></description></item>
///<item><description>BackstageDropDown &lt;mso14:dropDown></description></item>
///<item><description>RadioGroup &lt;mso14:radioGroup></description></item>
///<item><description>BackstageComboBox &lt;mso14:comboBox></description></item>
///<item><description>Hyperlink &lt;mso14:hyperlink></description></item>
///<item><description>BackstageLabelControl &lt;mso14:labelControl></description></item>
///<item><description>GroupBox &lt;mso14:groupBox></description></item>
///<item><description>LayoutContainer &lt;mso14:layoutContainer></description></item>
///<item><description>ImageControl &lt;mso14:imageControl></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(BackstageGroupButton),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(BackstageCheckBox),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(BackstageEditBox),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(BackstageDropDown),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(RadioGroup),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(BackstageComboBox),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(Hyperlink),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(BackstageLabelControl),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(GroupBox),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(LayoutContainer),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(ImageControl),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class GroupControlsType : OpenXmlCompositeElement
{
        
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "button" == name)
    return new BackstageGroupButton();
    
if( 57 == namespaceId && "checkBox" == name)
    return new BackstageCheckBox();
    
if( 57 == namespaceId && "editBox" == name)
    return new BackstageEditBox();
    
if( 57 == namespaceId && "dropDown" == name)
    return new BackstageDropDown();
    
if( 57 == namespaceId && "radioGroup" == name)
    return new RadioGroup();
    
if( 57 == namespaceId && "comboBox" == name)
    return new BackstageComboBox();
    
if( 57 == namespaceId && "hyperlink" == name)
    return new Hyperlink();
    
if( 57 == namespaceId && "labelControl" == name)
    return new BackstageLabelControl();
    
if( 57 == namespaceId && "groupBox" == name)
    return new GroupBox();
    
if( 57 == namespaceId && "layoutContainer" == name)
    return new LayoutContainer();
    
if( 57 == namespaceId && "imageControl" == name)
    return new ImageControl();
    

    return null;
}

    
    
    
    /// <summary>
    /// Initializes a new instance of the GroupControlsType class.
    /// </summary>
    protected GroupControlsType(){}
    
            /// <summary>
    ///Initializes a new instance of the GroupControlsType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected GroupControlsType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the GroupControlsType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected GroupControlsType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the GroupControlsType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected GroupControlsType(string outerXml)
        : base(outerXml)
    {
    }

    
}
/// <summary>
/// <para>Defines the TaskGroupCategory Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:category.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TaskGroupTask &lt;mso14:task></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(TaskGroupTask),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class TaskGroupCategory : OpenXmlCompositeElement
{
    private const string tagName = "category";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13167;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","tag","idMso","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","label","getLabel" };
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
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
    /// Initializes a new instance of the TaskGroupCategory class.
    /// </summary>
    public TaskGroupCategory():base(){}
    
            /// <summary>
    ///Initializes a new instance of the TaskGroupCategory class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TaskGroupCategory(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TaskGroupCategory class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TaskGroupCategory(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TaskGroupCategory class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TaskGroupCategory(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "task" == name)
    return new TaskGroupTask();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
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
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
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
        return CloneImp<TaskGroupCategory>(deep);
    }

   
}
/// <summary>
/// <para>Defines the TaskGroupTask Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:task.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class TaskGroupTask : OpenXmlLeafElement
{
    private const string tagName = "task";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13168;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","tag","idMso","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","onAction","isDefinitive","image","imageMso","getImage","enabled","getEnabled","label","getLabel","visible","getVisible","description","getDescription","keytip","getKeytip" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> isDefinitive.</para>
    /// <para>Represents the following attribute in the schema: isDefinitive </para>
    /// </summary>
    [SchemaAttr(0, "isDefinitive")]
    public BooleanValue IsDefinitive
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
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
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
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the TaskGroupTask class.
    /// </summary>
    public TaskGroupTask():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "onAction" == name)
    return new StringValue();
    
if( 0 == namespaceId && "isDefinitive" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "image" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imageMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getImage" == name)
    return new StringValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "description" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getDescription" == name)
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
        return CloneImp<TaskGroupTask>(deep);
    }

   
}
/// <summary>
/// <para>Defines the TaskFormGroupCategory Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:category.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TaskFormGroupTask &lt;mso14:task></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(TaskFormGroupTask),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class TaskFormGroupCategory : OpenXmlCompositeElement
{
    private const string tagName = "category";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13169;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","tag","idMso","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","visible","getVisible","label","getLabel" };
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
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
    /// Initializes a new instance of the TaskFormGroupCategory class.
    /// </summary>
    public TaskFormGroupCategory():base(){}
    
            /// <summary>
    ///Initializes a new instance of the TaskFormGroupCategory class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TaskFormGroupCategory(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TaskFormGroupCategory class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TaskFormGroupCategory(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TaskFormGroupCategory class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TaskFormGroupCategory(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "task" == name)
    return new TaskFormGroupTask();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
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
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
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
        return CloneImp<TaskFormGroupCategory>(deep);
    }

   
}
/// <summary>
/// <para>Defines the TaskFormGroupTask Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:task.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BackstageGroup &lt;mso14:group></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(BackstageGroup),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class TaskFormGroupTask : OpenXmlCompositeElement
{
    private const string tagName = "task";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13170;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","tag","idMso","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","image","imageMso","getImage","enabled","getEnabled","label","getLabel","visible","getVisible","description","getDescription","keytip","getKeytip" };
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    /// <para> label.</para>
    /// <para>Represents the following attribute in the schema: label </para>
    /// </summary>
    [SchemaAttr(0, "label")]
    public StringValue Label
    {
        get { return (StringValue)Attributes[13]; }
        set { Attributes[13] = value; }
    }
    
    /// <summary>
    /// <para> getLabel.</para>
    /// <para>Represents the following attribute in the schema: getLabel </para>
    /// </summary>
    [SchemaAttr(0, "getLabel")]
    public StringValue GetLabel
    {
        get { return (StringValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> description.</para>
    /// <para>Represents the following attribute in the schema: description </para>
    /// </summary>
    [SchemaAttr(0, "description")]
    public StringValue Description
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> getDescription.</para>
    /// <para>Represents the following attribute in the schema: getDescription </para>
    /// </summary>
    [SchemaAttr(0, "getDescription")]
    public StringValue GetDescription
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
    /// Initializes a new instance of the TaskFormGroupTask class.
    /// </summary>
    public TaskFormGroupTask():base(){}
    
            /// <summary>
    ///Initializes a new instance of the TaskFormGroupTask class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TaskFormGroupTask(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TaskFormGroupTask class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TaskFormGroupTask(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TaskFormGroupTask class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TaskFormGroupTask(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "group" == name)
    return new BackstageGroup();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "image" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imageMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getImage" == name)
    return new StringValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "description" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getDescription" == name)
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
        return CloneImp<TaskFormGroupTask>(deep);
    }

   
}
/// <summary>
/// <para>Defines the TaskFormGroup Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:taskFormGroup.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TaskFormGroupCategory &lt;mso14:category></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(TaskFormGroupCategory),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class TaskFormGroup : OpenXmlCompositeElement
{
    private const string tagName = "taskFormGroup";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13171;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","tag","idMso","label","getLabel","visible","getVisible","helperText","getHelperText","showLabel","getShowLabel","allowedTaskSizes" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    public StringValue QualifiedId
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
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[7]; }
        set { Attributes[7] = value; }
    }
    
    /// <summary>
    /// <para> helperText.</para>
    /// <para>Represents the following attribute in the schema: helperText </para>
    /// </summary>
    [SchemaAttr(0, "helperText")]
    public StringValue HelperText
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> getHelperText.</para>
    /// <para>Represents the following attribute in the schema: getHelperText </para>
    /// </summary>
    [SchemaAttr(0, "getHelperText")]
    public StringValue GetHelperText
    {
        get { return (StringValue)Attributes[9]; }
        set { Attributes[9] = value; }
    }
    
    /// <summary>
    /// <para> showLabel.</para>
    /// <para>Represents the following attribute in the schema: showLabel </para>
    /// </summary>
    [SchemaAttr(0, "showLabel")]
    public BooleanValue ShowLabel
    {
        get { return (BooleanValue)Attributes[10]; }
        set { Attributes[10] = value; }
    }
    
    /// <summary>
    /// <para> getShowLabel.</para>
    /// <para>Represents the following attribute in the schema: getShowLabel </para>
    /// </summary>
    [SchemaAttr(0, "getShowLabel")]
    public StringValue GetShowLabel
    {
        get { return (StringValue)Attributes[11]; }
        set { Attributes[11] = value; }
    }
    
    /// <summary>
    /// <para> allowedTaskSizes.</para>
    /// <para>Represents the following attribute in the schema: allowedTaskSizes </para>
    /// </summary>
    [SchemaAttr(0, "allowedTaskSizes")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.TaskSizesValues> AllowedTaskSizes
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.TaskSizesValues>)Attributes[12]; }
        set { Attributes[12] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the TaskFormGroup class.
    /// </summary>
    public TaskFormGroup():base(){}
    
            /// <summary>
    ///Initializes a new instance of the TaskFormGroup class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TaskFormGroup(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TaskFormGroup class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TaskFormGroup(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TaskFormGroup class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TaskFormGroup(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "category" == name)
    return new TaskFormGroupCategory();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "helperText" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getHelperText" == name)
    return new StringValue();
    
if( 0 == namespaceId && "showLabel" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getShowLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "allowedTaskSizes" == name)
    return new EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.TaskSizesValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<TaskFormGroup>(deep);
    }

   
}
/// <summary>
/// <para>Defines the BackstageGroups Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:firstColumn.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TaskFormGroup &lt;mso14:taskFormGroup></description></item>
///<item><description>BackstageGroup &lt;mso14:group></description></item>
///<item><description>TaskGroup &lt;mso14:taskGroup></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(TaskFormGroup),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(BackstageGroup),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(TaskGroup),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackstageGroups : OpenXmlCompositeElement
{
    private const string tagName = "firstColumn";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13172;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the BackstageGroups class.
    /// </summary>
    public BackstageGroups():base(){}
    
            /// <summary>
    ///Initializes a new instance of the BackstageGroups class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackstageGroups(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BackstageGroups class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackstageGroups(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BackstageGroups class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BackstageGroups(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "taskFormGroup" == name)
    return new TaskFormGroup();
    
if( 57 == namespaceId && "group" == name)
    return new BackstageGroup();
    
if( 57 == namespaceId && "taskGroup" == name)
    return new TaskGroup();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<BackstageGroups>(deep);
    }

   
}
/// <summary>
/// <para>Defines the SimpleGroups Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:secondColumn.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BackstageGroup &lt;mso14:group></description></item>
///<item><description>TaskGroup &lt;mso14:taskGroup></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(BackstageGroup),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(TaskGroup),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SimpleGroups : OpenXmlCompositeElement
{
    private const string tagName = "secondColumn";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13173;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the SimpleGroups class.
    /// </summary>
    public SimpleGroups():base(){}
    
            /// <summary>
    ///Initializes a new instance of the SimpleGroups class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SimpleGroups(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SimpleGroups class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SimpleGroups(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SimpleGroups class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SimpleGroups(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "group" == name)
    return new BackstageGroup();
    
if( 57 == namespaceId && "taskGroup" == name)
    return new TaskGroup();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<SimpleGroups>(deep);
    }

   
}
/// <summary>
/// <para>Defines the BackstageTab Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:tab.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BackstageGroups &lt;mso14:firstColumn></description></item>
///<item><description>SimpleGroups &lt;mso14:secondColumn></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(BackstageGroups),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(SimpleGroups),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackstageTab : OpenXmlCompositeElement
{
    private const string tagName = "tab";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13174;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "id","idQ","tag","idMso","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","enabled","getEnabled","label","getLabel","visible","getVisible","keytip","getKeytip","title","getTitle","columnWidthPercent","firstColumnMinWidth","firstColumnMaxWidth","secondColumnMinWidth","secondColumnMaxWidth" };
    private static byte[] attributeNamespaceIds = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };
    
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
    public StringValue QualifiedId
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
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[6]; }
        set { Attributes[6] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    /// <para> title.</para>
    /// <para>Represents the following attribute in the schema: title </para>
    /// </summary>
    [SchemaAttr(0, "title")]
    public StringValue Title
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> getTitle.</para>
    /// <para>Represents the following attribute in the schema: getTitle </para>
    /// </summary>
    [SchemaAttr(0, "getTitle")]
    public StringValue GetTitle
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> columnWidthPercent.</para>
    /// <para>Represents the following attribute in the schema: columnWidthPercent </para>
    /// </summary>
    [SchemaAttr(0, "columnWidthPercent")]
    public IntegerValue ColumnWidthPercent
    {
        get { return (IntegerValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> firstColumnMinWidth.</para>
    /// <para>Represents the following attribute in the schema: firstColumnMinWidth </para>
    /// </summary>
    [SchemaAttr(0, "firstColumnMinWidth")]
    public IntegerValue FirstColumnMinWidth
    {
        get { return (IntegerValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> firstColumnMaxWidth.</para>
    /// <para>Represents the following attribute in the schema: firstColumnMaxWidth </para>
    /// </summary>
    [SchemaAttr(0, "firstColumnMaxWidth")]
    public IntegerValue FirstColumnMaxWidth
    {
        get { return (IntegerValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    
    /// <summary>
    /// <para> secondColumnMinWidth.</para>
    /// <para>Represents the following attribute in the schema: secondColumnMinWidth </para>
    /// </summary>
    [SchemaAttr(0, "secondColumnMinWidth")]
    public IntegerValue SecondColumnMinWidth
    {
        get { return (IntegerValue)Attributes[21]; }
        set { Attributes[21] = value; }
    }
    
    /// <summary>
    /// <para> secondColumnMaxWidth.</para>
    /// <para>Represents the following attribute in the schema: secondColumnMaxWidth </para>
    /// </summary>
    [SchemaAttr(0, "secondColumnMaxWidth")]
    public IntegerValue SecondColumnMaxWidth
    {
        get { return (IntegerValue)Attributes[22]; }
        set { Attributes[22] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BackstageTab class.
    /// </summary>
    public BackstageTab():base(){}
    
            /// <summary>
    ///Initializes a new instance of the BackstageTab class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackstageTab(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BackstageTab class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackstageTab(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BackstageTab class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BackstageTab(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "firstColumn" == name)
    return new BackstageGroups();
    
if( 57 == namespaceId && "secondColumn" == name)
    return new SimpleGroups();
    

    return null;
}

        private static readonly string[] eleTagNames = { "firstColumn","secondColumn" };
    private static readonly byte[] eleNamespaceIds = { 57,57 };
    
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
    /// <para> BackstageGroups.</para>
    /// <para> Represents the following element tag in the schema: mso14:firstColumn </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
    /// </remark>
    public BackstageGroups BackstageGroups
    {
        get 
        {
            return GetElement<BackstageGroups>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> SimpleGroups.</para>
    /// <para> Represents the following element tag in the schema: mso14:secondColumn </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
    /// </remark>
    public SimpleGroups SimpleGroups
    {
        get 
        {
            return GetElement<SimpleGroups>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "title" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getTitle" == name)
    return new StringValue();
    
if( 0 == namespaceId && "columnWidthPercent" == name)
    return new IntegerValue();
    
if( 0 == namespaceId && "firstColumnMinWidth" == name)
    return new IntegerValue();
    
if( 0 == namespaceId && "firstColumnMaxWidth" == name)
    return new IntegerValue();
    
if( 0 == namespaceId && "secondColumnMinWidth" == name)
    return new IntegerValue();
    
if( 0 == namespaceId && "secondColumnMaxWidth" == name)
    return new IntegerValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<BackstageTab>(deep);
    }

   
}
/// <summary>
/// <para>Defines the BackstageFastCommandButton Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:button.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackstageFastCommandButton : OpenXmlLeafElement
{
    private const string tagName = "button";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13175;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "idMso","insertAfterMso","insertBeforeMso","insertAfterQ","insertBeforeQ","id","idQ","tag","onAction","isDefinitive","enabled","getEnabled","label","getLabel","visible","getVisible","keytip","getKeytip","image","imageMso","getImage" };
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
    /// <para> insertAfterMso.</para>
    /// <para>Represents the following attribute in the schema: insertAfterMso </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterMso")]
    public StringValue InsertAfterMso
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeMso.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeMso </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeMso")]
    public StringValue InsertBeforeMso
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> insertAfterQ.</para>
    /// <para>Represents the following attribute in the schema: insertAfterQ </para>
    /// </summary>
    [SchemaAttr(0, "insertAfterQ")]
    public StringValue InsertAfterQulifiedId
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> insertBeforeQ.</para>
    /// <para>Represents the following attribute in the schema: insertBeforeQ </para>
    /// </summary>
    [SchemaAttr(0, "insertBeforeQ")]
    public StringValue InsertBeforeQulifiedId
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
    public StringValue QualifiedId
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
    /// <para> onAction.</para>
    /// <para>Represents the following attribute in the schema: onAction </para>
    /// </summary>
    [SchemaAttr(0, "onAction")]
    public StringValue OnAction
    {
        get { return (StringValue)Attributes[8]; }
        set { Attributes[8] = value; }
    }
    
    /// <summary>
    /// <para> isDefinitive.</para>
    /// <para>Represents the following attribute in the schema: isDefinitive </para>
    /// </summary>
    [SchemaAttr(0, "isDefinitive")]
    public BooleanValue IsDefinitive
    {
        get { return (BooleanValue)Attributes[9]; }
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
    /// <para> visible.</para>
    /// <para>Represents the following attribute in the schema: visible </para>
    /// </summary>
    [SchemaAttr(0, "visible")]
    public BooleanValue Visible
    {
        get { return (BooleanValue)Attributes[14]; }
        set { Attributes[14] = value; }
    }
    
    /// <summary>
    /// <para> getVisible.</para>
    /// <para>Represents the following attribute in the schema: getVisible </para>
    /// </summary>
    [SchemaAttr(0, "getVisible")]
    public StringValue GetVisible
    {
        get { return (StringValue)Attributes[15]; }
        set { Attributes[15] = value; }
    }
    
    /// <summary>
    /// <para> keytip.</para>
    /// <para>Represents the following attribute in the schema: keytip </para>
    /// </summary>
    [SchemaAttr(0, "keytip")]
    public StringValue Keytip
    {
        get { return (StringValue)Attributes[16]; }
        set { Attributes[16] = value; }
    }
    
    /// <summary>
    /// <para> getKeytip.</para>
    /// <para>Represents the following attribute in the schema: getKeytip </para>
    /// </summary>
    [SchemaAttr(0, "getKeytip")]
    public StringValue GetKeytip
    {
        get { return (StringValue)Attributes[17]; }
        set { Attributes[17] = value; }
    }
    
    /// <summary>
    /// <para> image.</para>
    /// <para>Represents the following attribute in the schema: image </para>
    /// </summary>
    [SchemaAttr(0, "image")]
    public StringValue Image
    {
        get { return (StringValue)Attributes[18]; }
        set { Attributes[18] = value; }
    }
    
    /// <summary>
    /// <para> imageMso.</para>
    /// <para>Represents the following attribute in the schema: imageMso </para>
    /// </summary>
    [SchemaAttr(0, "imageMso")]
    public StringValue ImageMso
    {
        get { return (StringValue)Attributes[19]; }
        set { Attributes[19] = value; }
    }
    
    /// <summary>
    /// <para> getImage.</para>
    /// <para>Represents the following attribute in the schema: getImage </para>
    /// </summary>
    [SchemaAttr(0, "getImage")]
    public StringValue GetImage
    {
        get { return (StringValue)Attributes[20]; }
        set { Attributes[20] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BackstageFastCommandButton class.
    /// </summary>
    public BackstageFastCommandButton():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "idMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertAfterQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "insertBeforeQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "id" == name)
    return new StringValue();
    
if( 0 == namespaceId && "idQ" == name)
    return new StringValue();
    
if( 0 == namespaceId && "tag" == name)
    return new StringValue();
    
if( 0 == namespaceId && "onAction" == name)
    return new StringValue();
    
if( 0 == namespaceId && "isDefinitive" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "enabled" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getEnabled" == name)
    return new StringValue();
    
if( 0 == namespaceId && "label" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getLabel" == name)
    return new StringValue();
    
if( 0 == namespaceId && "visible" == name)
    return new BooleanValue();
    
if( 0 == namespaceId && "getVisible" == name)
    return new StringValue();
    
if( 0 == namespaceId && "keytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getKeytip" == name)
    return new StringValue();
    
if( 0 == namespaceId && "image" == name)
    return new StringValue();
    
if( 0 == namespaceId && "imageMso" == name)
    return new StringValue();
    
if( 0 == namespaceId && "getImage" == name)
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
        return CloneImp<BackstageFastCommandButton>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Commands Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:commands.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Command &lt;mso14:command></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Command),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Commands : OpenXmlCompositeElement
{
    private const string tagName = "commands";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13176;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Commands class.
    /// </summary>
    public Commands():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Commands class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Commands(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Commands class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Commands(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Commands class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Commands(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "command" == name)
    return new Command();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Commands>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Ribbon Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:ribbon.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>QuickAccessToolbar &lt;mso14:qat></description></item>
///<item><description>Tabs &lt;mso14:tabs></description></item>
///<item><description>ContextualTabs &lt;mso14:contextualTabs></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(QuickAccessToolbar),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(Tabs),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(ContextualTabs),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
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
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13177;
    
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
		if((6 & (int)version) > 0)
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
    if( 57 == namespaceId && "qat" == name)
    return new QuickAccessToolbar();
    
if( 57 == namespaceId && "tabs" == name)
    return new Tabs();
    
if( 57 == namespaceId && "contextualTabs" == name)
    return new ContextualTabs();
    

    return null;
}

        private static readonly string[] eleTagNames = { "qat","tabs","contextualTabs" };
    private static readonly byte[] eleNamespaceIds = { 57,57,57 };
    
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
    /// <para> QuickAccessToolbar.</para>
    /// <para> Represents the following element tag in the schema: mso14:qat </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
    /// </remark>
    public QuickAccessToolbar QuickAccessToolbar
    {
        get 
        {
            return GetElement<QuickAccessToolbar>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> Tabs.</para>
    /// <para> Represents the following element tag in the schema: mso14:tabs </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
    /// </remark>
    public Tabs Tabs
    {
        get 
        {
            return GetElement<Tabs>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> ContextualTabs.</para>
    /// <para> Represents the following element tag in the schema: mso14:contextualTabs </para>
    /// </summary>
    /// <remark>
    /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
    /// </remark>
    public ContextualTabs ContextualTabs
    {
        get 
        {
            return GetElement<ContextualTabs>(2);
        }
        set
        {
            SetElement(2, value);
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
/// <para>Defines the Backstage Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:backstage.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BackstageTab &lt;mso14:tab></description></item>
///<item><description>BackstageFastCommandButton &lt;mso14:button></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(BackstageTab),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(BackstageFastCommandButton),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Backstage : OpenXmlCompositeElement
{
    private const string tagName = "backstage";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13178;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "onShow","onHide" };
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
    /// <para> onShow.</para>
    /// <para>Represents the following attribute in the schema: onShow </para>
    /// </summary>
    [SchemaAttr(0, "onShow")]
    public StringValue OnShow
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> onHide.</para>
    /// <para>Represents the following attribute in the schema: onHide </para>
    /// </summary>
    [SchemaAttr(0, "onHide")]
    public StringValue OnHide
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Backstage class.
    /// </summary>
    public Backstage():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Backstage class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Backstage(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Backstage class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Backstage(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Backstage class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Backstage(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "tab" == name)
    return new BackstageTab();
    
if( 57 == namespaceId && "button" == name)
    return new BackstageFastCommandButton();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "onShow" == name)
    return new StringValue();
    
if( 0 == namespaceId && "onHide" == name)
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
        return CloneImp<Backstage>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ContextMenus Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is mso14:contextMenus.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ContextMenu &lt;mso14:contextMenu></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ContextMenu),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ContextMenus : OpenXmlCompositeElement
{
    private const string tagName = "contextMenus";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 57;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13179;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ContextMenus class.
    /// </summary>
    public ContextMenus():base(){}
    
            /// <summary>
    ///Initializes a new instance of the ContextMenus class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ContextMenus(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ContextMenus class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ContextMenus(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ContextMenus class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ContextMenus(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 57 == namespaceId && "contextMenu" == name)
    return new ContextMenu();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ContextMenus>(deep);
    }

   
}
/// <summary>
/// Defines the GalleryShowInRibbonValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum GalleryShowInRibbonValues
{  
	///<summary>
///false.
///<para>When the item is serialized out as xml, its value is "false".</para>
///</summary>
[EnumString("false")]
False,
///<summary>
///0.
///<para>When the item is serialized out as xml, its value is "0".</para>
///</summary>
[EnumString("0")]
Zero,
 
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
/// <summary>
/// Defines the TaskSizesValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum TaskSizesValues
{  
	///<summary>
///largeMediumSmall.
///<para>When the item is serialized out as xml, its value is "largeMediumSmall".</para>
///</summary>
[EnumString("largeMediumSmall")]
LargeMediumSmall,
///<summary>
///largeMedium.
///<para>When the item is serialized out as xml, its value is "largeMedium".</para>
///</summary>
[EnumString("largeMedium")]
LargeMedium,
///<summary>
///large.
///<para>When the item is serialized out as xml, its value is "large".</para>
///</summary>
[EnumString("large")]
Large,
///<summary>
///mediumSmall.
///<para>When the item is serialized out as xml, its value is "mediumSmall".</para>
///</summary>
[EnumString("mediumSmall")]
MediumSmall,
///<summary>
///medium.
///<para>When the item is serialized out as xml, its value is "medium".</para>
///</summary>
[EnumString("medium")]
Medium,
///<summary>
///small.
///<para>When the item is serialized out as xml, its value is "small".</para>
///</summary>
[EnumString("small")]
Small,
 
}
/// <summary>
/// Defines the ExpandValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ExpandValues
{  
	///<summary>
///topLeft.
///<para>When the item is serialized out as xml, its value is "topLeft".</para>
///</summary>
[EnumString("topLeft")]
TopLeft,
///<summary>
///top.
///<para>When the item is serialized out as xml, its value is "top".</para>
///</summary>
[EnumString("top")]
Top,
///<summary>
///topRight.
///<para>When the item is serialized out as xml, its value is "topRight".</para>
///</summary>
[EnumString("topRight")]
TopRight,
///<summary>
///left.
///<para>When the item is serialized out as xml, its value is "left".</para>
///</summary>
[EnumString("left")]
Left,
///<summary>
///center.
///<para>When the item is serialized out as xml, its value is "center".</para>
///</summary>
[EnumString("center")]
Center,
///<summary>
///right.
///<para>When the item is serialized out as xml, its value is "right".</para>
///</summary>
[EnumString("right")]
Right,
///<summary>
///bottomLeft.
///<para>When the item is serialized out as xml, its value is "bottomLeft".</para>
///</summary>
[EnumString("bottomLeft")]
BottomLeft,
///<summary>
///bottom.
///<para>When the item is serialized out as xml, its value is "bottom".</para>
///</summary>
[EnumString("bottom")]
Bottom,
///<summary>
///bottomRight.
///<para>When the item is serialized out as xml, its value is "bottomRight".</para>
///</summary>
[EnumString("bottomRight")]
BottomRight,
 
}
/// <summary>
/// Defines the StyleValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StyleValues
{  
	///<summary>
///normal.
///<para>When the item is serialized out as xml, its value is "normal".</para>
///</summary>
[EnumString("normal")]
Normal,
///<summary>
///warning.
///<para>When the item is serialized out as xml, its value is "warning".</para>
///</summary>
[EnumString("warning")]
Warning,
///<summary>
///error.
///<para>When the item is serialized out as xml, its value is "error".</para>
///</summary>
[EnumString("error")]
Error,
 
}
/// <summary>
/// Defines the Style2Values enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum Style2Values
{  
	///<summary>
///normal.
///<para>When the item is serialized out as xml, its value is "normal".</para>
///</summary>
[EnumString("normal")]
Normal,
///<summary>
///borderless.
///<para>When the item is serialized out as xml, its value is "borderless".</para>
///</summary>
[EnumString("borderless")]
Borderless,
///<summary>
///large.
///<para>When the item is serialized out as xml, its value is "large".</para>
///</summary>
[EnumString("large")]
Large,
 
}
/// <summary>
/// Defines the LayoutChildrenValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum LayoutChildrenValues
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
 
 
