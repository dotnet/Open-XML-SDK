// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.Office.Word
{
/// <summary>
/// <para>Defines the TemplateCommandGroup Class. The root element of CustomizationPart.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:tcg.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>KeyMapCustomizations &lt;wne:keymaps></description></item>
///<item><description>MismatchedKeyMapCustomization &lt;wne:keymapsBad></description></item>
///<item><description>Toolbars &lt;wne:toolbars></description></item>
///<item><description>AllocatedCommands &lt;wne:acds></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(KeyMapCustomizations))]
    [ChildElementInfo(typeof(MismatchedKeyMapCustomization))]
    [ChildElementInfo(typeof(Toolbars))]
    [ChildElementInfo(typeof(AllocatedCommands))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class TemplateCommandGroup : OpenXmlPartRootElement
{
    private const string tagName = "tcg";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12608;
    
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
    /// TemplateCommandGroup constructor.
    /// </summary>
    /// <param name="ownerPart">The owner part of the TemplateCommandGroup.</param>
    internal TemplateCommandGroup(CustomizationPart ownerPart) : base (ownerPart )
    {
    }
    
    /// <summary>
    /// Loads the DOM from the CustomizationPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(CustomizationPart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the CustomizationPart associated with this element.
    /// </summary>
    public CustomizationPart CustomizationPart
    {
		get
		{
			return OpenXmlPart as CustomizationPart;
		}
		internal set
		{
			OpenXmlPart = value;
		}
    }
    
            /// <summary>
    ///Initializes a new instance of the TemplateCommandGroup class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TemplateCommandGroup(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TemplateCommandGroup class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TemplateCommandGroup(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TemplateCommandGroup class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TemplateCommandGroup(string outerXml)
        : base(outerXml)
    {
    }

    
    
    /// <summary>
    /// Initializes a new instance of the TemplateCommandGroup class.
    /// </summary>
    public TemplateCommandGroup() : base ()
    {
    }
    
    /// <summary>
    /// Saves the DOM into the CustomizationPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(CustomizationPart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 33 == namespaceId && "keymaps" == name)
    return new KeyMapCustomizations();
    
if( 33 == namespaceId && "keymapsBad" == name)
    return new MismatchedKeyMapCustomization();
    
if( 33 == namespaceId && "toolbars" == name)
    return new Toolbars();
    
if( 33 == namespaceId && "acds" == name)
    return new AllocatedCommands();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<TemplateCommandGroup>(deep);
    }

}
/// <summary>
/// <para>Defines the Mcds Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:mcds.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Mcd &lt;wne:mcd></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Mcd))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Mcds : OpenXmlCompositeElement
{
    private const string tagName = "mcds";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12609;
    
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
    /// Initializes a new instance of the Mcds class.
    /// </summary>
    public Mcds():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Mcds class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Mcds(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Mcds class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Mcds(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Mcds class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Mcds(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 33 == namespaceId && "mcd" == name)
    return new Mcd();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Mcds>(deep);
    }

   
}
/// <summary>
/// <para>Defines the VbaSuppData Class. The root element of VbaDataPart.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:vbaSuppData.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocEvents &lt;wne:docEvents></description></item>
///<item><description>Mcds &lt;wne:mcds></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocEvents))]
    [ChildElementInfo(typeof(Mcds))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VbaSuppData : OpenXmlPartRootElement
{
    private const string tagName = "vbaSuppData";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12610;
    
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
    /// VbaSuppData constructor.
    /// </summary>
    /// <param name="ownerPart">The owner part of the VbaSuppData.</param>
    internal VbaSuppData(VbaDataPart ownerPart) : base (ownerPart )
    {
    }
    
    /// <summary>
    /// Loads the DOM from the VbaDataPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(VbaDataPart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the VbaDataPart associated with this element.
    /// </summary>
    public VbaDataPart VbaDataPart
    {
		get
		{
			return OpenXmlPart as VbaDataPart;
		}
		internal set
		{
			OpenXmlPart = value;
		}
    }
    
            /// <summary>
    ///Initializes a new instance of the VbaSuppData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public VbaSuppData(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the VbaSuppData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public VbaSuppData(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the VbaSuppData class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public VbaSuppData(string outerXml)
        : base(outerXml)
    {
    }

    
    
    /// <summary>
    /// Initializes a new instance of the VbaSuppData class.
    /// </summary>
    public VbaSuppData() : base ()
    {
    }
    
    /// <summary>
    /// Saves the DOM into the VbaDataPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(VbaDataPart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 33 == namespaceId && "docEvents" == name)
    return new DocEvents();
    
if( 33 == namespaceId && "mcds" == name)
    return new Mcds();
    

    return null;
}

        private static readonly string[] eleTagNames = { "docEvents","mcds" };
    private static readonly byte[] eleNamespaceIds = { 33,33 };
    
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
    /// <para> DocEvents.</para>
    /// <para> Represents the following element tag in the schema: wne:docEvents </para>
    /// </summary>
    /// <remark>
    /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
    /// </remark>
    public DocEvents DocEvents
    {
        get 
        {
            return GetElement<DocEvents>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> Mcds.</para>
    /// <para> Represents the following element tag in the schema: wne:mcds </para>
    /// </summary>
    /// <remark>
    /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
    /// </remark>
    public Mcds Mcds
    {
        get 
        {
            return GetElement<Mcds>(1);
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
        return CloneImp<VbaSuppData>(deep);
    }

}
/// <summary>
/// <para>Defines the MailMergeRecipients Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:recipients.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SingleDataSourceRecord &lt;wne:recipientData></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(SingleDataSourceRecord))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class MailMergeRecipients : OpenXmlPartRootElement
{
    private const string tagName = "recipients";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12611;
    
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
    /// Initializes a new instance of the MailMergeRecipients class.
    /// </summary>
    public MailMergeRecipients():base(){}
    
            /// <summary>
    ///Initializes a new instance of the MailMergeRecipients class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MailMergeRecipients(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the MailMergeRecipients class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MailMergeRecipients(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the MailMergeRecipients class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MailMergeRecipients(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 33 == namespaceId && "recipientData" == name)
    return new SingleDataSourceRecord();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<MailMergeRecipients>(deep);
    }

   
}
/// <summary>
/// <para>Defines the FixedCommandKeyboardCustomization Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:fci.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class FixedCommandKeyboardCustomization : OpenXmlLeafElement
{
    private const string tagName = "fci";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12612;
    
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
    

    private static string[] attributeTagNames = { "fciName","fciIndex","swArg" };
    private static byte[] attributeNamespaceIds = { 33,33,33 };
    
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
    /// <para> fciName.</para>
    /// <para>Represents the following attribute in the schema: wne:fciName </para>
    /// </summary>
///<remark> xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
///</remark>
    [SchemaAttr(33, "fciName")]
    public StringValue CommandName
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> fciIndex.</para>
    /// <para>Represents the following attribute in the schema: wne:fciIndex </para>
    /// </summary>
///<remark> xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
///</remark>
    [SchemaAttr(33, "fciIndex")]
    public HexBinaryValue CommandIndex
    {
        get { return (HexBinaryValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> swArg.</para>
    /// <para>Represents the following attribute in the schema: wne:swArg </para>
    /// </summary>
///<remark> xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
///</remark>
    [SchemaAttr(33, "swArg")]
    public HexBinaryValue Argument
    {
        get { return (HexBinaryValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the FixedCommandKeyboardCustomization class.
    /// </summary>
    public FixedCommandKeyboardCustomization():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 33 == namespaceId && "fciName" == name)
    return new StringValue();
    
if( 33 == namespaceId && "fciIndex" == name)
    return new HexBinaryValue();
    
if( 33 == namespaceId && "swArg" == name)
    return new HexBinaryValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<FixedCommandKeyboardCustomization>(deep);
    }

   
}
/// <summary>
/// <para>Defines the MacroKeyboardCustomization Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:macro.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class MacroKeyboardCustomization : MacroWllType
{
    private const string tagName = "macro";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12613;
    
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
    /// Initializes a new instance of the MacroKeyboardCustomization class.
    /// </summary>
    public MacroKeyboardCustomization():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<MacroKeyboardCustomization>(deep);
    }

}
/// <summary>
/// <para>Defines the WllMacroKeyboardCustomization Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:wll.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class WllMacroKeyboardCustomization : MacroWllType
{
    private const string tagName = "wll";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12615;
    
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
    /// Initializes a new instance of the WllMacroKeyboardCustomization class.
    /// </summary>
    public WllMacroKeyboardCustomization():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<WllMacroKeyboardCustomization>(deep);
    }

}
/// <summary>
/// Defines the MacroWllType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class MacroWllType : OpenXmlLeafElement
{
    private static string[] attributeTagNames = { "macroName" };
    private static byte[] attributeNamespaceIds = { 33 };
    
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
    /// <para> macroName.</para>
    /// <para>Represents the following attribute in the schema: wne:macroName </para>
    /// </summary>
///<remark> xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
///</remark>
    [SchemaAttr(33, "macroName")]
    public StringValue MacroName
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 33 == namespaceId && "macroName" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

    
    /// <summary>
    /// Initializes a new instance of the MacroWllType class.
    /// </summary>
    protected MacroWllType(){}
    
    
    
}
/// <summary>
/// <para>Defines the AllocatedCommandKeyboardCustomization Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:acd.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class AllocatedCommandKeyboardCustomization : AcceleratorKeymapType
{
    private const string tagName = "acd";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12614;
    
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
    /// Initializes a new instance of the AllocatedCommandKeyboardCustomization class.
    /// </summary>
    public AllocatedCommandKeyboardCustomization():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<AllocatedCommandKeyboardCustomization>(deep);
    }

}
/// <summary>
/// <para>Defines the AllocatedCommandManifestEntry Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:acdEntry.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class AllocatedCommandManifestEntry : AcceleratorKeymapType
{
    private const string tagName = "acdEntry";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12634;
    
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
    /// Initializes a new instance of the AllocatedCommandManifestEntry class.
    /// </summary>
    public AllocatedCommandManifestEntry():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<AllocatedCommandManifestEntry>(deep);
    }

}
/// <summary>
/// Defines the AcceleratorKeymapType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class AcceleratorKeymapType : OpenXmlLeafElement
{
    private static string[] attributeTagNames = { "acdName" };
    private static byte[] attributeNamespaceIds = { 33 };
    
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
    /// <para> acdName.</para>
    /// <para>Represents the following attribute in the schema: wne:acdName </para>
    /// </summary>
///<remark> xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
///</remark>
    [SchemaAttr(33, "acdName")]
    public StringValue AcceleratorName
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 33 == namespaceId && "acdName" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

    
    /// <summary>
    /// Initializes a new instance of the AcceleratorKeymapType class.
    /// </summary>
    protected AcceleratorKeymapType(){}
    
    
    
}
/// <summary>
/// <para>Defines the CharacterInsertion Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:wch.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class CharacterInsertion : OpenXmlLeafElement
{
    private const string tagName = "wch";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12616;
    
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
    

    private static string[] attributeTagNames = { "val" };
    private static byte[] attributeNamespaceIds = { 33 };
    
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
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: wne:val </para>
    /// </summary>
///<remark> xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
///</remark>
    [SchemaAttr(33, "val")]
    public HexBinaryValue Val
    {
        get { return (HexBinaryValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the CharacterInsertion class.
    /// </summary>
    public CharacterInsertion():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 33 == namespaceId && "val" == name)
    return new HexBinaryValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<CharacterInsertion>(deep);
    }

   
}
/// <summary>
/// <para>Defines the KeyMapEntry Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:keymap.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>FixedCommandKeyboardCustomization &lt;wne:fci></description></item>
///<item><description>MacroKeyboardCustomization &lt;wne:macro></description></item>
///<item><description>AllocatedCommandKeyboardCustomization &lt;wne:acd></description></item>
///<item><description>WllMacroKeyboardCustomization &lt;wne:wll></description></item>
///<item><description>CharacterInsertion &lt;wne:wch></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(FixedCommandKeyboardCustomization))]
    [ChildElementInfo(typeof(MacroKeyboardCustomization))]
    [ChildElementInfo(typeof(AllocatedCommandKeyboardCustomization))]
    [ChildElementInfo(typeof(WllMacroKeyboardCustomization))]
    [ChildElementInfo(typeof(CharacterInsertion))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class KeyMapEntry : OpenXmlCompositeElement
{
    private const string tagName = "keymap";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12617;
    
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
    

    private static string[] attributeTagNames = { "chmPrimary","chmSecondary","kcmPrimary","kcmSecondary","mask" };
    private static byte[] attributeNamespaceIds = { 33,33,33,33,33 };
    
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
    /// <para> chmPrimary.</para>
    /// <para>Represents the following attribute in the schema: wne:chmPrimary </para>
    /// </summary>
///<remark> xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
///</remark>
    [SchemaAttr(33, "chmPrimary")]
    public HexBinaryValue CharacterMapPrimary
    {
        get { return (HexBinaryValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> chmSecondary.</para>
    /// <para>Represents the following attribute in the schema: wne:chmSecondary </para>
    /// </summary>
///<remark> xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
///</remark>
    [SchemaAttr(33, "chmSecondary")]
    public HexBinaryValue CharacterMapSecondary
    {
        get { return (HexBinaryValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> kcmPrimary.</para>
    /// <para>Represents the following attribute in the schema: wne:kcmPrimary </para>
    /// </summary>
///<remark> xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
///</remark>
    [SchemaAttr(33, "kcmPrimary")]
    public HexBinaryValue KeyCodePrimary
    {
        get { return (HexBinaryValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> kcmSecondary.</para>
    /// <para>Represents the following attribute in the schema: wne:kcmSecondary </para>
    /// </summary>
///<remark> xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
///</remark>
    [SchemaAttr(33, "kcmSecondary")]
    public HexBinaryValue KeyCodeSecondary
    {
        get { return (HexBinaryValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> mask.</para>
    /// <para>Represents the following attribute in the schema: wne:mask </para>
    /// </summary>
///<remark> xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
///</remark>
    [SchemaAttr(33, "mask")]
    public OnOffValue Mask
    {
        get { return (OnOffValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the KeyMapEntry class.
    /// </summary>
    public KeyMapEntry():base(){}
    
            /// <summary>
    ///Initializes a new instance of the KeyMapEntry class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public KeyMapEntry(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the KeyMapEntry class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public KeyMapEntry(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the KeyMapEntry class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public KeyMapEntry(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 33 == namespaceId && "fci" == name)
    return new FixedCommandKeyboardCustomization();
    
if( 33 == namespaceId && "macro" == name)
    return new MacroKeyboardCustomization();
    
if( 33 == namespaceId && "acd" == name)
    return new AllocatedCommandKeyboardCustomization();
    
if( 33 == namespaceId && "wll" == name)
    return new WllMacroKeyboardCustomization();
    
if( 33 == namespaceId && "wch" == name)
    return new CharacterInsertion();
    

    return null;
}

        private static readonly string[] eleTagNames = { "fci","macro","acd","wll","wch" };
    private static readonly byte[] eleNamespaceIds = { 33,33,33,33,33 };
    
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
    /// <para> FixedCommandKeyboardCustomization.</para>
    /// <para> Represents the following element tag in the schema: wne:fci </para>
    /// </summary>
    /// <remark>
    /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
    /// </remark>
    public FixedCommandKeyboardCustomization FixedCommandKeyboardCustomization
    {
        get 
        {
            return GetElement<FixedCommandKeyboardCustomization>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> MacroKeyboardCustomization.</para>
    /// <para> Represents the following element tag in the schema: wne:macro </para>
    /// </summary>
    /// <remark>
    /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
    /// </remark>
    public MacroKeyboardCustomization MacroKeyboardCustomization
    {
        get 
        {
            return GetElement<MacroKeyboardCustomization>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> AllocatedCommandKeyboardCustomization.</para>
    /// <para> Represents the following element tag in the schema: wne:acd </para>
    /// </summary>
    /// <remark>
    /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
    /// </remark>
    public AllocatedCommandKeyboardCustomization AllocatedCommandKeyboardCustomization
    {
        get 
        {
            return GetElement<AllocatedCommandKeyboardCustomization>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> WllMacroKeyboardCustomization.</para>
    /// <para> Represents the following element tag in the schema: wne:wll </para>
    /// </summary>
    /// <remark>
    /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
    /// </remark>
    public WllMacroKeyboardCustomization WllMacroKeyboardCustomization
    {
        get 
        {
            return GetElement<WllMacroKeyboardCustomization>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }
    /// <summary>
    /// <para> CharacterInsertion.</para>
    /// <para> Represents the following element tag in the schema: wne:wch </para>
    /// </summary>
    /// <remark>
    /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
    /// </remark>
    public CharacterInsertion CharacterInsertion
    {
        get 
        {
            return GetElement<CharacterInsertion>(4);
        }
        set
        {
            SetElement(4, value);
        }
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 33 == namespaceId && "chmPrimary" == name)
    return new HexBinaryValue();
    
if( 33 == namespaceId && "chmSecondary" == name)
    return new HexBinaryValue();
    
if( 33 == namespaceId && "kcmPrimary" == name)
    return new HexBinaryValue();
    
if( 33 == namespaceId && "kcmSecondary" == name)
    return new HexBinaryValue();
    
if( 33 == namespaceId && "mask" == name)
    return new OnOffValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<KeyMapEntry>(deep);
    }

   
}
/// <summary>
/// <para>Defines the AllocatedCommand Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:acd.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class AllocatedCommand : OpenXmlLeafElement
{
    private const string tagName = "acd";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12618;
    
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
    

    private static string[] attributeTagNames = { "argValue","fciBasedOn","fciIndexBasedOn","acdName" };
    private static byte[] attributeNamespaceIds = { 33,33,33,33 };
    
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
    /// <para> argValue.</para>
    /// <para>Represents the following attribute in the schema: wne:argValue </para>
    /// </summary>
///<remark> xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
///</remark>
    [SchemaAttr(33, "argValue")]
    public StringValue ArgumentValue
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> fciBasedOn.</para>
    /// <para>Represents the following attribute in the schema: wne:fciBasedOn </para>
    /// </summary>
///<remark> xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
///</remark>
    [SchemaAttr(33, "fciBasedOn")]
    public StringValue CommandBasedOn
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> fciIndexBasedOn.</para>
    /// <para>Represents the following attribute in the schema: wne:fciIndexBasedOn </para>
    /// </summary>
///<remark> xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
///</remark>
    [SchemaAttr(33, "fciIndexBasedOn")]
    public HexBinaryValue CommandIndexBasedOn
    {
        get { return (HexBinaryValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> acdName.</para>
    /// <para>Represents the following attribute in the schema: wne:acdName </para>
    /// </summary>
///<remark> xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
///</remark>
    [SchemaAttr(33, "acdName")]
    public StringValue AcceleratorName
    {
        get { return (StringValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the AllocatedCommand class.
    /// </summary>
    public AllocatedCommand():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 33 == namespaceId && "argValue" == name)
    return new StringValue();
    
if( 33 == namespaceId && "fciBasedOn" == name)
    return new StringValue();
    
if( 33 == namespaceId && "fciIndexBasedOn" == name)
    return new HexBinaryValue();
    
if( 33 == namespaceId && "acdName" == name)
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
        return CloneImp<AllocatedCommand>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Mcd Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:mcd.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Mcd : OpenXmlLeafElement
{
    private const string tagName = "mcd";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12619;
    
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
    

    private static string[] attributeTagNames = { "macroName","name","menuHelp","bEncrypt","cmg" };
    private static byte[] attributeNamespaceIds = { 33,33,33,33,33 };
    
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
    /// <para> macroName.</para>
    /// <para>Represents the following attribute in the schema: wne:macroName </para>
    /// </summary>
///<remark> xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
///</remark>
    [SchemaAttr(33, "macroName")]
    public StringValue MacroName
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: wne:name </para>
    /// </summary>
///<remark> xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
///</remark>
    [SchemaAttr(33, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    
    /// <summary>
    /// <para> menuHelp.</para>
    /// <para>Represents the following attribute in the schema: wne:menuHelp </para>
    /// </summary>
///<remark> xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
///</remark>
    [SchemaAttr(33, "menuHelp")]
    public StringValue MenuHelp
    {
        get { return (StringValue)Attributes[2]; }
        set { Attributes[2] = value; }
    }
    
    /// <summary>
    /// <para> bEncrypt.</para>
    /// <para>Represents the following attribute in the schema: wne:bEncrypt </para>
    /// </summary>
///<remark> xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
///</remark>
    [SchemaAttr(33, "bEncrypt")]
    public HexBinaryValue BEncrypt
    {
        get { return (HexBinaryValue)Attributes[3]; }
        set { Attributes[3] = value; }
    }
    
    /// <summary>
    /// <para> cmg.</para>
    /// <para>Represents the following attribute in the schema: wne:cmg </para>
    /// </summary>
///<remark> xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
///</remark>
    [SchemaAttr(33, "cmg")]
    public HexBinaryValue Cmg
    {
        get { return (HexBinaryValue)Attributes[4]; }
        set { Attributes[4] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Mcd class.
    /// </summary>
    public Mcd():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 33 == namespaceId && "macroName" == name)
    return new StringValue();
    
if( 33 == namespaceId && "name" == name)
    return new StringValue();
    
if( 33 == namespaceId && "menuHelp" == name)
    return new StringValue();
    
if( 33 == namespaceId && "bEncrypt" == name)
    return new HexBinaryValue();
    
if( 33 == namespaceId && "cmg" == name)
    return new HexBinaryValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Mcd>(deep);
    }

   
}
/// <summary>
/// <para>Defines the EventDocNewXsdString Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:eventDocNew.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class EventDocNewXsdString : OpenXmlLeafTextElement
{
    private const string tagName = "eventDocNew";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12620;
    
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
    /// Initializes a new instance of the EventDocNewXsdString class.
    /// </summary>
    public EventDocNewXsdString():base(){}
    
           /// <summary>
    /// Initializes a new instance of the EventDocNewXsdString class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public EventDocNewXsdString(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new StringValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<EventDocNewXsdString>(deep);
    }

}
/// <summary>
/// <para>Defines the EventDocOpenXsdString Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:eventDocOpen.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class EventDocOpenXsdString : OpenXmlLeafTextElement
{
    private const string tagName = "eventDocOpen";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12621;
    
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
    /// Initializes a new instance of the EventDocOpenXsdString class.
    /// </summary>
    public EventDocOpenXsdString():base(){}
    
           /// <summary>
    /// Initializes a new instance of the EventDocOpenXsdString class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public EventDocOpenXsdString(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new StringValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<EventDocOpenXsdString>(deep);
    }

}
/// <summary>
/// <para>Defines the EventDocCloseXsdString Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:eventDocClose.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class EventDocCloseXsdString : OpenXmlLeafTextElement
{
    private const string tagName = "eventDocClose";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12622;
    
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
    /// Initializes a new instance of the EventDocCloseXsdString class.
    /// </summary>
    public EventDocCloseXsdString():base(){}
    
           /// <summary>
    /// Initializes a new instance of the EventDocCloseXsdString class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public EventDocCloseXsdString(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new StringValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<EventDocCloseXsdString>(deep);
    }

}
/// <summary>
/// <para>Defines the EventDocSyncXsdString Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:eventDocSync.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class EventDocSyncXsdString : OpenXmlLeafTextElement
{
    private const string tagName = "eventDocSync";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12623;
    
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
    /// Initializes a new instance of the EventDocSyncXsdString class.
    /// </summary>
    public EventDocSyncXsdString():base(){}
    
           /// <summary>
    /// Initializes a new instance of the EventDocSyncXsdString class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public EventDocSyncXsdString(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new StringValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<EventDocSyncXsdString>(deep);
    }

}
/// <summary>
/// <para>Defines the EventDocXmlAfterInsertXsdString Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:eventDocXmlAfterInsert.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class EventDocXmlAfterInsertXsdString : OpenXmlLeafTextElement
{
    private const string tagName = "eventDocXmlAfterInsert";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12624;
    
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
    /// Initializes a new instance of the EventDocXmlAfterInsertXsdString class.
    /// </summary>
    public EventDocXmlAfterInsertXsdString():base(){}
    
           /// <summary>
    /// Initializes a new instance of the EventDocXmlAfterInsertXsdString class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public EventDocXmlAfterInsertXsdString(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new StringValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<EventDocXmlAfterInsertXsdString>(deep);
    }

}
/// <summary>
/// <para>Defines the EventDocXmlBeforeDeleteXsdString Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:eventDocXmlBeforeDelete.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class EventDocXmlBeforeDeleteXsdString : OpenXmlLeafTextElement
{
    private const string tagName = "eventDocXmlBeforeDelete";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12625;
    
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
    /// Initializes a new instance of the EventDocXmlBeforeDeleteXsdString class.
    /// </summary>
    public EventDocXmlBeforeDeleteXsdString():base(){}
    
           /// <summary>
    /// Initializes a new instance of the EventDocXmlBeforeDeleteXsdString class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public EventDocXmlBeforeDeleteXsdString(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new StringValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<EventDocXmlBeforeDeleteXsdString>(deep);
    }

}
/// <summary>
/// <para>Defines the EventDocContentControlAfterInsertXsdString Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:eventDocContentControlAfterInsert.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class EventDocContentControlAfterInsertXsdString : OpenXmlLeafTextElement
{
    private const string tagName = "eventDocContentControlAfterInsert";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12626;
    
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
    /// Initializes a new instance of the EventDocContentControlAfterInsertXsdString class.
    /// </summary>
    public EventDocContentControlAfterInsertXsdString():base(){}
    
           /// <summary>
    /// Initializes a new instance of the EventDocContentControlAfterInsertXsdString class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public EventDocContentControlAfterInsertXsdString(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new StringValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<EventDocContentControlAfterInsertXsdString>(deep);
    }

}
/// <summary>
/// <para>Defines the EventDocContentControlBeforeDeleteXsdString Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:eventDocContentControlBeforeDelete.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class EventDocContentControlBeforeDeleteXsdString : OpenXmlLeafTextElement
{
    private const string tagName = "eventDocContentControlBeforeDelete";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12627;
    
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
    /// Initializes a new instance of the EventDocContentControlBeforeDeleteXsdString class.
    /// </summary>
    public EventDocContentControlBeforeDeleteXsdString():base(){}
    
           /// <summary>
    /// Initializes a new instance of the EventDocContentControlBeforeDeleteXsdString class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public EventDocContentControlBeforeDeleteXsdString(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new StringValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<EventDocContentControlBeforeDeleteXsdString>(deep);
    }

}
/// <summary>
/// <para>Defines the EventDocContentControlOnExistXsdString Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:eventDocContentControlOnExit.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class EventDocContentControlOnExistXsdString : OpenXmlLeafTextElement
{
    private const string tagName = "eventDocContentControlOnExit";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12628;
    
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
    /// Initializes a new instance of the EventDocContentControlOnExistXsdString class.
    /// </summary>
    public EventDocContentControlOnExistXsdString():base(){}
    
           /// <summary>
    /// Initializes a new instance of the EventDocContentControlOnExistXsdString class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public EventDocContentControlOnExistXsdString(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new StringValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<EventDocContentControlOnExistXsdString>(deep);
    }

}
/// <summary>
/// <para>Defines the EventDocContentControlOnEnterXsdString Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:eventDocContentControlOnEnter.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class EventDocContentControlOnEnterXsdString : OpenXmlLeafTextElement
{
    private const string tagName = "eventDocContentControlOnEnter";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12629;
    
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
    /// Initializes a new instance of the EventDocContentControlOnEnterXsdString class.
    /// </summary>
    public EventDocContentControlOnEnterXsdString():base(){}
    
           /// <summary>
    /// Initializes a new instance of the EventDocContentControlOnEnterXsdString class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public EventDocContentControlOnEnterXsdString(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new StringValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<EventDocContentControlOnEnterXsdString>(deep);
    }

}
/// <summary>
/// <para>Defines the EventDocStoreUpdateXsdString Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:eventDocStoreUpdate.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class EventDocStoreUpdateXsdString : OpenXmlLeafTextElement
{
    private const string tagName = "eventDocStoreUpdate";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12630;
    
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
    /// Initializes a new instance of the EventDocStoreUpdateXsdString class.
    /// </summary>
    public EventDocStoreUpdateXsdString():base(){}
    
           /// <summary>
    /// Initializes a new instance of the EventDocStoreUpdateXsdString class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public EventDocStoreUpdateXsdString(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new StringValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<EventDocStoreUpdateXsdString>(deep);
    }

}
/// <summary>
/// <para>Defines the EventDocContentControlUpdateXsdString Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:eventDocContentControlContentUpdate.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class EventDocContentControlUpdateXsdString : OpenXmlLeafTextElement
{
    private const string tagName = "eventDocContentControlContentUpdate";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12631;
    
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
    /// Initializes a new instance of the EventDocContentControlUpdateXsdString class.
    /// </summary>
    public EventDocContentControlUpdateXsdString():base(){}
    
           /// <summary>
    /// Initializes a new instance of the EventDocContentControlUpdateXsdString class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public EventDocContentControlUpdateXsdString(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new StringValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<EventDocContentControlUpdateXsdString>(deep);
    }

}
/// <summary>
/// <para>Defines the EventDocBuildingBlockAfterInsertXsdString Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:eventDocBuildingBlockAfterInsert.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class EventDocBuildingBlockAfterInsertXsdString : OpenXmlLeafTextElement
{
    private const string tagName = "eventDocBuildingBlockAfterInsert";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12632;
    
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
    /// Initializes a new instance of the EventDocBuildingBlockAfterInsertXsdString class.
    /// </summary>
    public EventDocBuildingBlockAfterInsertXsdString():base(){}
    
           /// <summary>
    /// Initializes a new instance of the EventDocBuildingBlockAfterInsertXsdString class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public EventDocBuildingBlockAfterInsertXsdString(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new StringValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<EventDocBuildingBlockAfterInsertXsdString>(deep);
    }

}
/// <summary>
/// <para>Defines the DocEvents Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:docEvents.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>EventDocNewXsdString &lt;wne:eventDocNew></description></item>
///<item><description>EventDocOpenXsdString &lt;wne:eventDocOpen></description></item>
///<item><description>EventDocCloseXsdString &lt;wne:eventDocClose></description></item>
///<item><description>EventDocSyncXsdString &lt;wne:eventDocSync></description></item>
///<item><description>EventDocXmlAfterInsertXsdString &lt;wne:eventDocXmlAfterInsert></description></item>
///<item><description>EventDocXmlBeforeDeleteXsdString &lt;wne:eventDocXmlBeforeDelete></description></item>
///<item><description>EventDocContentControlAfterInsertXsdString &lt;wne:eventDocContentControlAfterInsert></description></item>
///<item><description>EventDocContentControlBeforeDeleteXsdString &lt;wne:eventDocContentControlBeforeDelete></description></item>
///<item><description>EventDocContentControlOnExistXsdString &lt;wne:eventDocContentControlOnExit></description></item>
///<item><description>EventDocContentControlOnEnterXsdString &lt;wne:eventDocContentControlOnEnter></description></item>
///<item><description>EventDocStoreUpdateXsdString &lt;wne:eventDocStoreUpdate></description></item>
///<item><description>EventDocContentControlUpdateXsdString &lt;wne:eventDocContentControlContentUpdate></description></item>
///<item><description>EventDocBuildingBlockAfterInsertXsdString &lt;wne:eventDocBuildingBlockAfterInsert></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(EventDocNewXsdString))]
    [ChildElementInfo(typeof(EventDocOpenXsdString))]
    [ChildElementInfo(typeof(EventDocCloseXsdString))]
    [ChildElementInfo(typeof(EventDocSyncXsdString))]
    [ChildElementInfo(typeof(EventDocXmlAfterInsertXsdString))]
    [ChildElementInfo(typeof(EventDocXmlBeforeDeleteXsdString))]
    [ChildElementInfo(typeof(EventDocContentControlAfterInsertXsdString))]
    [ChildElementInfo(typeof(EventDocContentControlBeforeDeleteXsdString))]
    [ChildElementInfo(typeof(EventDocContentControlOnExistXsdString))]
    [ChildElementInfo(typeof(EventDocContentControlOnEnterXsdString))]
    [ChildElementInfo(typeof(EventDocStoreUpdateXsdString))]
    [ChildElementInfo(typeof(EventDocContentControlUpdateXsdString))]
    [ChildElementInfo(typeof(EventDocBuildingBlockAfterInsertXsdString))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class DocEvents : OpenXmlCompositeElement
{
    private const string tagName = "docEvents";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12633;
    
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
    /// Initializes a new instance of the DocEvents class.
    /// </summary>
    public DocEvents():base(){}
    
            /// <summary>
    ///Initializes a new instance of the DocEvents class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DocEvents(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DocEvents class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DocEvents(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DocEvents class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DocEvents(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 33 == namespaceId && "eventDocNew" == name)
    return new EventDocNewXsdString();
    
if( 33 == namespaceId && "eventDocOpen" == name)
    return new EventDocOpenXsdString();
    
if( 33 == namespaceId && "eventDocClose" == name)
    return new EventDocCloseXsdString();
    
if( 33 == namespaceId && "eventDocSync" == name)
    return new EventDocSyncXsdString();
    
if( 33 == namespaceId && "eventDocXmlAfterInsert" == name)
    return new EventDocXmlAfterInsertXsdString();
    
if( 33 == namespaceId && "eventDocXmlBeforeDelete" == name)
    return new EventDocXmlBeforeDeleteXsdString();
    
if( 33 == namespaceId && "eventDocContentControlAfterInsert" == name)
    return new EventDocContentControlAfterInsertXsdString();
    
if( 33 == namespaceId && "eventDocContentControlBeforeDelete" == name)
    return new EventDocContentControlBeforeDeleteXsdString();
    
if( 33 == namespaceId && "eventDocContentControlOnExit" == name)
    return new EventDocContentControlOnExistXsdString();
    
if( 33 == namespaceId && "eventDocContentControlOnEnter" == name)
    return new EventDocContentControlOnEnterXsdString();
    
if( 33 == namespaceId && "eventDocStoreUpdate" == name)
    return new EventDocStoreUpdateXsdString();
    
if( 33 == namespaceId && "eventDocContentControlContentUpdate" == name)
    return new EventDocContentControlUpdateXsdString();
    
if( 33 == namespaceId && "eventDocBuildingBlockAfterInsert" == name)
    return new EventDocBuildingBlockAfterInsertXsdString();
    

    return null;
}

        private static readonly string[] eleTagNames = { "eventDocNew","eventDocOpen","eventDocClose","eventDocSync","eventDocXmlAfterInsert","eventDocXmlBeforeDelete","eventDocContentControlAfterInsert","eventDocContentControlBeforeDelete","eventDocContentControlOnExit","eventDocContentControlOnEnter","eventDocStoreUpdate","eventDocContentControlContentUpdate","eventDocBuildingBlockAfterInsert" };
    private static readonly byte[] eleNamespaceIds = { 33,33,33,33,33,33,33,33,33,33,33,33,33 };
    
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
    /// <para> EventDocNewXsdString.</para>
    /// <para> Represents the following element tag in the schema: wne:eventDocNew </para>
    /// </summary>
    /// <remark>
    /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
    /// </remark>
    public EventDocNewXsdString EventDocNewXsdString
    {
        get 
        {
            return GetElement<EventDocNewXsdString>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> EventDocOpenXsdString.</para>
    /// <para> Represents the following element tag in the schema: wne:eventDocOpen </para>
    /// </summary>
    /// <remark>
    /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
    /// </remark>
    public EventDocOpenXsdString EventDocOpenXsdString
    {
        get 
        {
            return GetElement<EventDocOpenXsdString>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> EventDocCloseXsdString.</para>
    /// <para> Represents the following element tag in the schema: wne:eventDocClose </para>
    /// </summary>
    /// <remark>
    /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
    /// </remark>
    public EventDocCloseXsdString EventDocCloseXsdString
    {
        get 
        {
            return GetElement<EventDocCloseXsdString>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> EventDocSyncXsdString.</para>
    /// <para> Represents the following element tag in the schema: wne:eventDocSync </para>
    /// </summary>
    /// <remark>
    /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
    /// </remark>
    public EventDocSyncXsdString EventDocSyncXsdString
    {
        get 
        {
            return GetElement<EventDocSyncXsdString>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }
    /// <summary>
    /// <para> EventDocXmlAfterInsertXsdString.</para>
    /// <para> Represents the following element tag in the schema: wne:eventDocXmlAfterInsert </para>
    /// </summary>
    /// <remark>
    /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
    /// </remark>
    public EventDocXmlAfterInsertXsdString EventDocXmlAfterInsertXsdString
    {
        get 
        {
            return GetElement<EventDocXmlAfterInsertXsdString>(4);
        }
        set
        {
            SetElement(4, value);
        }
    }
    /// <summary>
    /// <para> EventDocXmlBeforeDeleteXsdString.</para>
    /// <para> Represents the following element tag in the schema: wne:eventDocXmlBeforeDelete </para>
    /// </summary>
    /// <remark>
    /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
    /// </remark>
    public EventDocXmlBeforeDeleteXsdString EventDocXmlBeforeDeleteXsdString
    {
        get 
        {
            return GetElement<EventDocXmlBeforeDeleteXsdString>(5);
        }
        set
        {
            SetElement(5, value);
        }
    }
    /// <summary>
    /// <para> EventDocContentControlAfterInsertXsdString.</para>
    /// <para> Represents the following element tag in the schema: wne:eventDocContentControlAfterInsert </para>
    /// </summary>
    /// <remark>
    /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
    /// </remark>
    public EventDocContentControlAfterInsertXsdString EventDocContentControlAfterInsertXsdString
    {
        get 
        {
            return GetElement<EventDocContentControlAfterInsertXsdString>(6);
        }
        set
        {
            SetElement(6, value);
        }
    }
    /// <summary>
    /// <para> EventDocContentControlBeforeDeleteXsdString.</para>
    /// <para> Represents the following element tag in the schema: wne:eventDocContentControlBeforeDelete </para>
    /// </summary>
    /// <remark>
    /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
    /// </remark>
    public EventDocContentControlBeforeDeleteXsdString EventDocContentControlBeforeDeleteXsdString
    {
        get 
        {
            return GetElement<EventDocContentControlBeforeDeleteXsdString>(7);
        }
        set
        {
            SetElement(7, value);
        }
    }
    /// <summary>
    /// <para> EventDocContentControlOnExistXsdString.</para>
    /// <para> Represents the following element tag in the schema: wne:eventDocContentControlOnExit </para>
    /// </summary>
    /// <remark>
    /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
    /// </remark>
    public EventDocContentControlOnExistXsdString EventDocContentControlOnExistXsdString
    {
        get 
        {
            return GetElement<EventDocContentControlOnExistXsdString>(8);
        }
        set
        {
            SetElement(8, value);
        }
    }
    /// <summary>
    /// <para> EventDocContentControlOnEnterXsdString.</para>
    /// <para> Represents the following element tag in the schema: wne:eventDocContentControlOnEnter </para>
    /// </summary>
    /// <remark>
    /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
    /// </remark>
    public EventDocContentControlOnEnterXsdString EventDocContentControlOnEnterXsdString
    {
        get 
        {
            return GetElement<EventDocContentControlOnEnterXsdString>(9);
        }
        set
        {
            SetElement(9, value);
        }
    }
    /// <summary>
    /// <para> EventDocStoreUpdateXsdString.</para>
    /// <para> Represents the following element tag in the schema: wne:eventDocStoreUpdate </para>
    /// </summary>
    /// <remark>
    /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
    /// </remark>
    public EventDocStoreUpdateXsdString EventDocStoreUpdateXsdString
    {
        get 
        {
            return GetElement<EventDocStoreUpdateXsdString>(10);
        }
        set
        {
            SetElement(10, value);
        }
    }
    /// <summary>
    /// <para> EventDocContentControlUpdateXsdString.</para>
    /// <para> Represents the following element tag in the schema: wne:eventDocContentControlContentUpdate </para>
    /// </summary>
    /// <remark>
    /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
    /// </remark>
    public EventDocContentControlUpdateXsdString EventDocContentControlUpdateXsdString
    {
        get 
        {
            return GetElement<EventDocContentControlUpdateXsdString>(11);
        }
        set
        {
            SetElement(11, value);
        }
    }
    /// <summary>
    /// <para> EventDocBuildingBlockAfterInsertXsdString.</para>
    /// <para> Represents the following element tag in the schema: wne:eventDocBuildingBlockAfterInsert </para>
    /// </summary>
    /// <remark>
    /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
    /// </remark>
    public EventDocBuildingBlockAfterInsertXsdString EventDocBuildingBlockAfterInsertXsdString
    {
        get 
        {
            return GetElement<EventDocBuildingBlockAfterInsertXsdString>(12);
        }
        set
        {
            SetElement(12, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<DocEvents>(deep);
    }

   
}
/// <summary>
/// <para>Defines the AllocatedCommandManifest Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:acdManifest.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>AllocatedCommandManifestEntry &lt;wne:acdEntry></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(AllocatedCommandManifestEntry))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class AllocatedCommandManifest : OpenXmlCompositeElement
{
    private const string tagName = "acdManifest";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12635;
    
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
    /// Initializes a new instance of the AllocatedCommandManifest class.
    /// </summary>
    public AllocatedCommandManifest():base(){}
    
            /// <summary>
    ///Initializes a new instance of the AllocatedCommandManifest class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AllocatedCommandManifest(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the AllocatedCommandManifest class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AllocatedCommandManifest(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the AllocatedCommandManifest class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public AllocatedCommandManifest(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 33 == namespaceId && "acdEntry" == name)
    return new AllocatedCommandManifestEntry();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<AllocatedCommandManifest>(deep);
    }

   
}
/// <summary>
/// <para>Defines the ToolbarData Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:toolbarData.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ToolbarData : OpenXmlLeafElement
{
    private const string tagName = "toolbarData";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12636;
    
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
    

    private static string[] attributeTagNames = { "id" };
    private static byte[] attributeNamespaceIds = { 19 };
    
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
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ToolbarData class.
    /// </summary>
    public ToolbarData():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 19 == namespaceId && "id" == name)
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
        return CloneImp<ToolbarData>(deep);
    }

   
}
/// <summary>
/// <para>Defines the KeyMapCustomizations Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:keymaps.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>KeyMapEntry &lt;wne:keymap></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class KeyMapCustomizations : KeymapsType
{
    private const string tagName = "keymaps";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12637;
    
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
    /// Initializes a new instance of the KeyMapCustomizations class.
    /// </summary>
    public KeyMapCustomizations():base(){}
            /// <summary>
    ///Initializes a new instance of the KeyMapCustomizations class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public KeyMapCustomizations(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the KeyMapCustomizations class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public KeyMapCustomizations(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the KeyMapCustomizations class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public KeyMapCustomizations(string outerXml)
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
        return CloneImp<KeyMapCustomizations>(deep);
    }

}
/// <summary>
/// <para>Defines the MismatchedKeyMapCustomization Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:keymapsBad.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>KeyMapEntry &lt;wne:keymap></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class MismatchedKeyMapCustomization : KeymapsType
{
    private const string tagName = "keymapsBad";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12638;
    
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
    /// Initializes a new instance of the MismatchedKeyMapCustomization class.
    /// </summary>
    public MismatchedKeyMapCustomization():base(){}
            /// <summary>
    ///Initializes a new instance of the MismatchedKeyMapCustomization class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MismatchedKeyMapCustomization(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the MismatchedKeyMapCustomization class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MismatchedKeyMapCustomization(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the MismatchedKeyMapCustomization class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MismatchedKeyMapCustomization(string outerXml)
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
        return CloneImp<MismatchedKeyMapCustomization>(deep);
    }

}
/// <summary>
/// Defines the KeymapsType class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>KeyMapEntry &lt;wne:keymap></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(KeyMapEntry))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class KeymapsType : OpenXmlCompositeElement
{
        
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 33 == namespaceId && "keymap" == name)
    return new KeyMapEntry();
    

    return null;
}

    
    
    
    /// <summary>
    /// Initializes a new instance of the KeymapsType class.
    /// </summary>
    protected KeymapsType(){}
    
            /// <summary>
    ///Initializes a new instance of the KeymapsType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected KeymapsType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the KeymapsType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected KeymapsType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the KeymapsType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected KeymapsType(string outerXml)
        : base(outerXml)
    {
    }

    
}
/// <summary>
/// <para>Defines the Toolbars Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:toolbars.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>AllocatedCommandManifest &lt;wne:acdManifest></description></item>
///<item><description>ToolbarData &lt;wne:toolbarData></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(AllocatedCommandManifest))]
    [ChildElementInfo(typeof(ToolbarData))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Toolbars : OpenXmlCompositeElement
{
    private const string tagName = "toolbars";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12639;
    
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
    /// Initializes a new instance of the Toolbars class.
    /// </summary>
    public Toolbars():base(){}
    
            /// <summary>
    ///Initializes a new instance of the Toolbars class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Toolbars(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Toolbars class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Toolbars(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Toolbars class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Toolbars(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 33 == namespaceId && "acdManifest" == name)
    return new AllocatedCommandManifest();
    
if( 33 == namespaceId && "toolbarData" == name)
    return new ToolbarData();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Toolbars>(deep);
    }

   
}
/// <summary>
/// <para>Defines the AllocatedCommands Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:acds.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>AllocatedCommand &lt;wne:acd></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(AllocatedCommand))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class AllocatedCommands : OpenXmlCompositeElement
{
    private const string tagName = "acds";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12640;
    
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
    /// Initializes a new instance of the AllocatedCommands class.
    /// </summary>
    public AllocatedCommands():base(){}
    
            /// <summary>
    ///Initializes a new instance of the AllocatedCommands class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AllocatedCommands(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the AllocatedCommands class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AllocatedCommands(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the AllocatedCommands class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public AllocatedCommands(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 33 == namespaceId && "acd" == name)
    return new AllocatedCommand();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<AllocatedCommands>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RecordIncluded Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:active.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class RecordIncluded : OpenXmlLeafElement
{
    private const string tagName = "active";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12641;
    
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
    

    private static string[] attributeTagNames = { "val" };
    private static byte[] attributeNamespaceIds = { 33 };
    
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
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: wne:val </para>
    /// </summary>
///<remark> xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
///</remark>
    [SchemaAttr(33, "val")]
    public OnOffValue Val
    {
        get { return (OnOffValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RecordIncluded class.
    /// </summary>
    public RecordIncluded():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 33 == namespaceId && "val" == name)
    return new OnOffValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RecordIncluded>(deep);
    }

   
}
/// <summary>
/// <para>Defines the RecordHashCode Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:hash.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class RecordHashCode : OpenXmlLeafElement
{
    private const string tagName = "hash";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12642;
    
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
    

    private static string[] attributeTagNames = { "val" };
    private static byte[] attributeNamespaceIds = { 33 };
    
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
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: wne:val </para>
    /// </summary>
///<remark> xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
///</remark>
    [SchemaAttr(33, "val")]
    public IntegerValue Val
    {
        get { return (IntegerValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RecordHashCode class.
    /// </summary>
    public RecordHashCode():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 33 == namespaceId && "val" == name)
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
        return CloneImp<RecordHashCode>(deep);
    }

   
}
/// <summary>
/// <para>Defines the SingleDataSourceRecord Class.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:recipientData.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RecordIncluded &lt;wne:active></description></item>
///<item><description>RecordHashCode &lt;wne:hash></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(RecordIncluded))]
    [ChildElementInfo(typeof(RecordHashCode))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class SingleDataSourceRecord : OpenXmlCompositeElement
{
    private const string tagName = "recipientData";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 33;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12643;
    
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
    /// Initializes a new instance of the SingleDataSourceRecord class.
    /// </summary>
    public SingleDataSourceRecord():base(){}
    
            /// <summary>
    ///Initializes a new instance of the SingleDataSourceRecord class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SingleDataSourceRecord(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SingleDataSourceRecord class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SingleDataSourceRecord(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SingleDataSourceRecord class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SingleDataSourceRecord(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 33 == namespaceId && "active" == name)
    return new RecordIncluded();
    
if( 33 == namespaceId && "hash" == name)
    return new RecordHashCode();
    

    return null;
}

        private static readonly string[] eleTagNames = { "active","hash" };
    private static readonly byte[] eleNamespaceIds = { 33,33 };
    
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
    /// <para> RecordIncluded.</para>
    /// <para> Represents the following element tag in the schema: wne:active </para>
    /// </summary>
    /// <remark>
    /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
    /// </remark>
    public RecordIncluded RecordIncluded
    {
        get 
        {
            return GetElement<RecordIncluded>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> RecordHashCode.</para>
    /// <para> Represents the following element tag in the schema: wne:hash </para>
    /// </summary>
    /// <remark>
    /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
    /// </remark>
    public RecordHashCode RecordHashCode
    {
        get 
        {
            return GetElement<RecordHashCode>(1);
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
        return CloneImp<SingleDataSourceRecord>(deep);
    }

   
}
}
 
 
