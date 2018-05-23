// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
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
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class TemplateCommandGroup : OpenXmlPartRootElement
{
    internal const int ElementTypeIdConst = 12608;
    /// <inheritdoc/>
    public override string LocalName => "tcg";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    
	internal TemplateCommandGroup(CustomizationPart ownerPart) : base (ownerPart){}
    
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
		get => OpenXmlPart as CustomizationPart;
		internal set => OpenXmlPart = value;
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
    public TemplateCommandGroup():base(){}
    
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

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TemplateCommandGroup>(deep);

}
/// <summary>
/// <para>Defines the Mcds Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:mcds.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Mcd &lt;wne:mcd></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Mcd))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Mcds : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12609;
    /// <inheritdoc/>
    public override string LocalName => "mcds";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
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

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Mcds>(deep);

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
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class VbaSuppData : OpenXmlPartRootElement
{
    internal const int ElementTypeIdConst = 12610;
    /// <inheritdoc/>
    public override string LocalName => "vbaSuppData";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    
	internal VbaSuppData(VbaDataPart ownerPart) : base (ownerPart){}
    
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
		get => OpenXmlPart as VbaDataPart;
		internal set => OpenXmlPart = value;
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
    public VbaSuppData():base(){}
    
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
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> DocEvents.</para>
    /// <para> Represents the following element tag in the schema: wne:docEvents </para>
    /// </summary>
    /// <remark>
    /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
    /// </remark>
    public DocEvents DocEvents
    {
        get => GetElement<DocEvents>(0);
        set => SetElement(0, value);
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
        get => GetElement<Mcds>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VbaSuppData>(deep);

}
/// <summary>
/// <para>Defines the MailMergeRecipients Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:recipients.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SingleDataSourceRecord &lt;wne:recipientData></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SingleDataSourceRecord))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class MailMergeRecipients : OpenXmlPartRootElement
{
    internal const int ElementTypeIdConst = 12611;
    /// <inheritdoc/>
    public override string LocalName => "recipients";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
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

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MailMergeRecipients>(deep);

}
/// <summary>
/// <para>Defines the FixedCommandKeyboardCustomization Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:fci.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class FixedCommandKeyboardCustomization : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12612;
    /// <inheritdoc/>
    public override string LocalName => "fci";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(33, "fciName"),
		AttributeTag.Create<HexBinaryValue>(33, "fciIndex"),
		AttributeTag.Create<HexBinaryValue>(33, "swArg")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> fciName.</para>
    /// <para>Represents the following attribute in the schema: wne:fciName </para>
    /// </summary>
///<remark> xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
///</remark>
    [SchemaAttr(33, "fciName")]
    public StringValue CommandName
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
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
        get { return (HexBinaryValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
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
        get { return (HexBinaryValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the FixedCommandKeyboardCustomization class.
    /// </summary>
    public FixedCommandKeyboardCustomization():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FixedCommandKeyboardCustomization>(deep);

}
/// <summary>
/// <para>Defines the MacroKeyboardCustomization Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:macro.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class MacroKeyboardCustomization : MacroWllType
{
    internal const int ElementTypeIdConst = 12613;
    /// <inheritdoc/>
    public override string LocalName => "macro";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the MacroKeyboardCustomization class.
    /// </summary>
    public MacroKeyboardCustomization():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MacroKeyboardCustomization>(deep);

}
/// <summary>
/// <para>Defines the WllMacroKeyboardCustomization Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:wll.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class WllMacroKeyboardCustomization : MacroWllType
{
    internal const int ElementTypeIdConst = 12615;
    /// <inheritdoc/>
    public override string LocalName => "wll";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the WllMacroKeyboardCustomization class.
    /// </summary>
    public WllMacroKeyboardCustomization():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WllMacroKeyboardCustomization>(deep);

}
/// <summary>
/// Defines the MacroWllType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class MacroWllType : OpenXmlLeafElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(33, "macroName")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> macroName.</para>
    /// <para>Represents the following attribute in the schema: wne:macroName </para>
    /// </summary>
///<remark> xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
///</remark>
    [SchemaAttr(33, "macroName")]
    public StringValue MacroName
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the MacroWllType class.
    /// </summary>
    protected MacroWllType(){}
    
    
    
}
/// <summary>
/// <para>Defines the AllocatedCommandKeyboardCustomization Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:acd.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class AllocatedCommandKeyboardCustomization : AcceleratorKeymapType
{
    internal const int ElementTypeIdConst = 12614;
    /// <inheritdoc/>
    public override string LocalName => "acd";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the AllocatedCommandKeyboardCustomization class.
    /// </summary>
    public AllocatedCommandKeyboardCustomization():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AllocatedCommandKeyboardCustomization>(deep);

}
/// <summary>
/// <para>Defines the AllocatedCommandManifestEntry Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:acdEntry.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class AllocatedCommandManifestEntry : AcceleratorKeymapType
{
    internal const int ElementTypeIdConst = 12634;
    /// <inheritdoc/>
    public override string LocalName => "acdEntry";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the AllocatedCommandManifestEntry class.
    /// </summary>
    public AllocatedCommandManifestEntry():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AllocatedCommandManifestEntry>(deep);

}
/// <summary>
/// Defines the AcceleratorKeymapType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class AcceleratorKeymapType : OpenXmlLeafElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(33, "acdName")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> acdName.</para>
    /// <para>Represents the following attribute in the schema: wne:acdName </para>
    /// </summary>
///<remark> xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
///</remark>
    [SchemaAttr(33, "acdName")]
    public StringValue AcceleratorName
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the AcceleratorKeymapType class.
    /// </summary>
    protected AcceleratorKeymapType(){}
    
    
    
}
/// <summary>
/// <para>Defines the CharacterInsertion Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:wch.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class CharacterInsertion : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12616;
    /// <inheritdoc/>
    public override string LocalName => "wch";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<HexBinaryValue>(33, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: wne:val </para>
    /// </summary>
///<remark> xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
///</remark>
    [SchemaAttr(33, "val")]
    public HexBinaryValue Val
    {
        get { return (HexBinaryValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the CharacterInsertion class.
    /// </summary>
    public CharacterInsertion():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CharacterInsertion>(deep);

}
/// <summary>
/// <para>Defines the KeyMapEntry Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
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

    [ChildElementInfo(typeof(FixedCommandKeyboardCustomization))]
    [ChildElementInfo(typeof(MacroKeyboardCustomization))]
    [ChildElementInfo(typeof(AllocatedCommandKeyboardCustomization))]
    [ChildElementInfo(typeof(WllMacroKeyboardCustomization))]
    [ChildElementInfo(typeof(CharacterInsertion))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class KeyMapEntry : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12617;
    /// <inheritdoc/>
    public override string LocalName => "keymap";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<HexBinaryValue>(33, "chmPrimary"),
		AttributeTag.Create<HexBinaryValue>(33, "chmSecondary"),
		AttributeTag.Create<HexBinaryValue>(33, "kcmPrimary"),
		AttributeTag.Create<HexBinaryValue>(33, "kcmSecondary"),
		AttributeTag.Create<OnOffValue>(33, "mask")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> chmPrimary.</para>
    /// <para>Represents the following attribute in the schema: wne:chmPrimary </para>
    /// </summary>
///<remark> xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
///</remark>
    [SchemaAttr(33, "chmPrimary")]
    public HexBinaryValue CharacterMapPrimary
    {
        get { return (HexBinaryValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
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
        get { return (HexBinaryValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
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
        get { return (HexBinaryValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
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
        get { return (HexBinaryValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
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
        get { return (OnOffValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
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
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    
        /// <summary>
    /// <para> FixedCommandKeyboardCustomization.</para>
    /// <para> Represents the following element tag in the schema: wne:fci </para>
    /// </summary>
    /// <remark>
    /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
    /// </remark>
    public FixedCommandKeyboardCustomization FixedCommandKeyboardCustomization
    {
        get => GetElement<FixedCommandKeyboardCustomization>(0);
        set => SetElement(0, value);
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
        get => GetElement<MacroKeyboardCustomization>(1);
        set => SetElement(1, value);
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
        get => GetElement<AllocatedCommandKeyboardCustomization>(2);
        set => SetElement(2, value);
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
        get => GetElement<WllMacroKeyboardCustomization>(3);
        set => SetElement(3, value);
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
        get => GetElement<CharacterInsertion>(4);
        set => SetElement(4, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<KeyMapEntry>(deep);

}
/// <summary>
/// <para>Defines the AllocatedCommand Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:acd.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class AllocatedCommand : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12618;
    /// <inheritdoc/>
    public override string LocalName => "acd";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(33, "argValue"),
		AttributeTag.Create<StringValue>(33, "fciBasedOn"),
		AttributeTag.Create<HexBinaryValue>(33, "fciIndexBasedOn"),
		AttributeTag.Create<StringValue>(33, "acdName")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> argValue.</para>
    /// <para>Represents the following attribute in the schema: wne:argValue </para>
    /// </summary>
///<remark> xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
///</remark>
    [SchemaAttr(33, "argValue")]
    public StringValue ArgumentValue
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
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
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
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
        get { return (HexBinaryValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
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
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the AllocatedCommand class.
    /// </summary>
    public AllocatedCommand():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AllocatedCommand>(deep);

}
/// <summary>
/// <para>Defines the Mcd Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:mcd.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Mcd : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12619;
    /// <inheritdoc/>
    public override string LocalName => "mcd";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(33, "macroName"),
		AttributeTag.Create<StringValue>(33, "name"),
		AttributeTag.Create<StringValue>(33, "menuHelp"),
		AttributeTag.Create<HexBinaryValue>(33, "bEncrypt"),
		AttributeTag.Create<HexBinaryValue>(33, "cmg")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> macroName.</para>
    /// <para>Represents the following attribute in the schema: wne:macroName </para>
    /// </summary>
///<remark> xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
///</remark>
    [SchemaAttr(33, "macroName")]
    public StringValue MacroName
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
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
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
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
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
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
        get { return (HexBinaryValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
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
        get { return (HexBinaryValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Mcd class.
    /// </summary>
    public Mcd():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Mcd>(deep);

}
/// <summary>
/// <para>Defines the EventDocNewXsdString Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:eventDocNew.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class EventDocNewXsdString : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12620;
    /// <inheritdoc/>
    public override string LocalName => "eventDocNew";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

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
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocNewXsdString>(deep);

}
/// <summary>
/// <para>Defines the EventDocOpenXsdString Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:eventDocOpen.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class EventDocOpenXsdString : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12621;
    /// <inheritdoc/>
    public override string LocalName => "eventDocOpen";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

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
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocOpenXsdString>(deep);

}
/// <summary>
/// <para>Defines the EventDocCloseXsdString Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:eventDocClose.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class EventDocCloseXsdString : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12622;
    /// <inheritdoc/>
    public override string LocalName => "eventDocClose";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

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
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocCloseXsdString>(deep);

}
/// <summary>
/// <para>Defines the EventDocSyncXsdString Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:eventDocSync.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class EventDocSyncXsdString : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12623;
    /// <inheritdoc/>
    public override string LocalName => "eventDocSync";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

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
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocSyncXsdString>(deep);

}
/// <summary>
/// <para>Defines the EventDocXmlAfterInsertXsdString Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:eventDocXmlAfterInsert.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class EventDocXmlAfterInsertXsdString : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12624;
    /// <inheritdoc/>
    public override string LocalName => "eventDocXmlAfterInsert";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

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
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocXmlAfterInsertXsdString>(deep);

}
/// <summary>
/// <para>Defines the EventDocXmlBeforeDeleteXsdString Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:eventDocXmlBeforeDelete.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class EventDocXmlBeforeDeleteXsdString : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12625;
    /// <inheritdoc/>
    public override string LocalName => "eventDocXmlBeforeDelete";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

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
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocXmlBeforeDeleteXsdString>(deep);

}
/// <summary>
/// <para>Defines the EventDocContentControlAfterInsertXsdString Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:eventDocContentControlAfterInsert.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class EventDocContentControlAfterInsertXsdString : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12626;
    /// <inheritdoc/>
    public override string LocalName => "eventDocContentControlAfterInsert";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

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
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocContentControlAfterInsertXsdString>(deep);

}
/// <summary>
/// <para>Defines the EventDocContentControlBeforeDeleteXsdString Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:eventDocContentControlBeforeDelete.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class EventDocContentControlBeforeDeleteXsdString : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12627;
    /// <inheritdoc/>
    public override string LocalName => "eventDocContentControlBeforeDelete";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

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
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocContentControlBeforeDeleteXsdString>(deep);

}
/// <summary>
/// <para>Defines the EventDocContentControlOnExistXsdString Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:eventDocContentControlOnExit.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class EventDocContentControlOnExistXsdString : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12628;
    /// <inheritdoc/>
    public override string LocalName => "eventDocContentControlOnExit";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

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
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocContentControlOnExistXsdString>(deep);

}
/// <summary>
/// <para>Defines the EventDocContentControlOnEnterXsdString Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:eventDocContentControlOnEnter.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class EventDocContentControlOnEnterXsdString : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12629;
    /// <inheritdoc/>
    public override string LocalName => "eventDocContentControlOnEnter";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

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
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocContentControlOnEnterXsdString>(deep);

}
/// <summary>
/// <para>Defines the EventDocStoreUpdateXsdString Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:eventDocStoreUpdate.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class EventDocStoreUpdateXsdString : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12630;
    /// <inheritdoc/>
    public override string LocalName => "eventDocStoreUpdate";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

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
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocStoreUpdateXsdString>(deep);

}
/// <summary>
/// <para>Defines the EventDocContentControlUpdateXsdString Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:eventDocContentControlContentUpdate.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class EventDocContentControlUpdateXsdString : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12631;
    /// <inheritdoc/>
    public override string LocalName => "eventDocContentControlContentUpdate";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

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
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocContentControlUpdateXsdString>(deep);

}
/// <summary>
/// <para>Defines the EventDocBuildingBlockAfterInsertXsdString Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:eventDocBuildingBlockAfterInsert.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class EventDocBuildingBlockAfterInsertXsdString : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12632;
    /// <inheritdoc/>
    public override string LocalName => "eventDocBuildingBlockAfterInsert";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

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
    

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<EventDocBuildingBlockAfterInsertXsdString>(deep);

}
/// <summary>
/// <para>Defines the DocEvents Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DocEvents : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12633;
    /// <inheritdoc/>
    public override string LocalName => "docEvents";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
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
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> EventDocNewXsdString.</para>
    /// <para> Represents the following element tag in the schema: wne:eventDocNew </para>
    /// </summary>
    /// <remark>
    /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
    /// </remark>
    public EventDocNewXsdString EventDocNewXsdString
    {
        get => GetElement<EventDocNewXsdString>(0);
        set => SetElement(0, value);
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
        get => GetElement<EventDocOpenXsdString>(1);
        set => SetElement(1, value);
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
        get => GetElement<EventDocCloseXsdString>(2);
        set => SetElement(2, value);
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
        get => GetElement<EventDocSyncXsdString>(3);
        set => SetElement(3, value);
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
        get => GetElement<EventDocXmlAfterInsertXsdString>(4);
        set => SetElement(4, value);
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
        get => GetElement<EventDocXmlBeforeDeleteXsdString>(5);
        set => SetElement(5, value);
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
        get => GetElement<EventDocContentControlAfterInsertXsdString>(6);
        set => SetElement(6, value);
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
        get => GetElement<EventDocContentControlBeforeDeleteXsdString>(7);
        set => SetElement(7, value);
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
        get => GetElement<EventDocContentControlOnExistXsdString>(8);
        set => SetElement(8, value);
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
        get => GetElement<EventDocContentControlOnEnterXsdString>(9);
        set => SetElement(9, value);
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
        get => GetElement<EventDocStoreUpdateXsdString>(10);
        set => SetElement(10, value);
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
        get => GetElement<EventDocContentControlUpdateXsdString>(11);
        set => SetElement(11, value);
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
        get => GetElement<EventDocBuildingBlockAfterInsertXsdString>(12);
        set => SetElement(12, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DocEvents>(deep);

}
/// <summary>
/// <para>Defines the AllocatedCommandManifest Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:acdManifest.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>AllocatedCommandManifestEntry &lt;wne:acdEntry></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(AllocatedCommandManifestEntry))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class AllocatedCommandManifest : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12635;
    /// <inheritdoc/>
    public override string LocalName => "acdManifest";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
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

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AllocatedCommandManifest>(deep);

}
/// <summary>
/// <para>Defines the ToolbarData Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:toolbarData.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ToolbarData : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12636;
    /// <inheritdoc/>
    public override string LocalName => "toolbarData";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(19, "id")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ToolbarData class.
    /// </summary>
    public ToolbarData():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ToolbarData>(deep);

}
/// <summary>
/// <para>Defines the KeyMapCustomizations Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
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
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class KeyMapCustomizations : KeymapsType
{
    internal const int ElementTypeIdConst = 12637;
    /// <inheritdoc/>
    public override string LocalName => "keymaps";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

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

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<KeyMapCustomizations>(deep);

}
/// <summary>
/// <para>Defines the MismatchedKeyMapCustomization Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
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
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class MismatchedKeyMapCustomization : KeymapsType
{
    internal const int ElementTypeIdConst = 12638;
    /// <inheritdoc/>
    public override string LocalName => "keymapsBad";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

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

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MismatchedKeyMapCustomization>(deep);

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
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:toolbars.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>AllocatedCommandManifest &lt;wne:acdManifest></description></item>
///<item><description>ToolbarData &lt;wne:toolbarData></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(AllocatedCommandManifest))]
    [ChildElementInfo(typeof(ToolbarData))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Toolbars : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12639;
    /// <inheritdoc/>
    public override string LocalName => "toolbars";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
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

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Toolbars>(deep);

}
/// <summary>
/// <para>Defines the AllocatedCommands Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:acds.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>AllocatedCommand &lt;wne:acd></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(AllocatedCommand))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class AllocatedCommands : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12640;
    /// <inheritdoc/>
    public override string LocalName => "acds";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
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

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AllocatedCommands>(deep);

}
/// <summary>
/// <para>Defines the RecordIncluded Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:active.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class RecordIncluded : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12641;
    /// <inheritdoc/>
    public override string LocalName => "active";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<OnOffValue>(33, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: wne:val </para>
    /// </summary>
///<remark> xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
///</remark>
    [SchemaAttr(33, "val")]
    public OnOffValue Val
    {
        get { return (OnOffValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RecordIncluded class.
    /// </summary>
    public RecordIncluded():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RecordIncluded>(deep);

}
/// <summary>
/// <para>Defines the RecordHashCode Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:hash.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class RecordHashCode : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12642;
    /// <inheritdoc/>
    public override string LocalName => "hash";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<IntegerValue>(33, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: wne:val </para>
    /// </summary>
///<remark> xmlns:wne=http://schemas.microsoft.com/office/word/2006/wordml
///</remark>
    [SchemaAttr(33, "val")]
    public IntegerValue Val
    {
        get { return (IntegerValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the RecordHashCode class.
    /// </summary>
    public RecordHashCode():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RecordHashCode>(deep);

}
/// <summary>
/// <para>Defines the SingleDataSourceRecord Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wne:recipientData.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RecordIncluded &lt;wne:active></description></item>
///<item><description>RecordHashCode &lt;wne:hash></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(RecordIncluded))]
    [ChildElementInfo(typeof(RecordHashCode))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SingleDataSourceRecord : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12643;
    /// <inheritdoc/>
    public override string LocalName => "recipientData";
    
    internal override byte NamespaceId => 33;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
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
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> RecordIncluded.</para>
    /// <para> Represents the following element tag in the schema: wne:active </para>
    /// </summary>
    /// <remark>
    /// xmlns:wne = http://schemas.microsoft.com/office/word/2006/wordml
    /// </remark>
    public RecordIncluded RecordIncluded
    {
        get => GetElement<RecordIncluded>(0);
        set => SetElement(0, value);
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
        get => GetElement<RecordHashCode>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SingleDataSourceRecord>(deep);

}
}
 
 
