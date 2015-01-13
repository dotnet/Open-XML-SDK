// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.Vml.Spreadsheet
{
/// <summary>
/// <para>Attached Object Data.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:ClientData.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>MoveWithCells &lt;xvml:MoveWithCells></description></item>
///<item><description>ResizeWithCells &lt;xvml:SizeWithCells></description></item>
///<item><description>Anchor &lt;xvml:Anchor></description></item>
///<item><description>Locked &lt;xvml:Locked></description></item>
///<item><description>DefaultSize &lt;xvml:DefaultSize></description></item>
///<item><description>PrintObject &lt;xvml:PrintObject></description></item>
///<item><description>Disabled &lt;xvml:Disabled></description></item>
///<item><description>AutoFill &lt;xvml:AutoFill></description></item>
///<item><description>AutoLine &lt;xvml:AutoLine></description></item>
///<item><description>AutoSizePicture &lt;xvml:AutoPict></description></item>
///<item><description>FormulaMacro &lt;xvml:FmlaMacro></description></item>
///<item><description>HorizontalTextAlignment &lt;xvml:TextHAlign></description></item>
///<item><description>VerticalTextAlignment &lt;xvml:TextVAlign></description></item>
///<item><description>LockText &lt;xvml:LockText></description></item>
///<item><description>JustifyLastLine &lt;xvml:JustLastX></description></item>
///<item><description>SecretEdit &lt;xvml:SecretEdit></description></item>
///<item><description>DefaultButton &lt;xvml:Default></description></item>
///<item><description>HelpButton &lt;xvml:Help></description></item>
///<item><description>CancelButton &lt;xvml:Cancel></description></item>
///<item><description>DismissButton &lt;xvml:Dismiss></description></item>
///<item><description>AcceleratorPrimary &lt;xvml:Accel></description></item>
///<item><description>AcceleratorSecondary &lt;xvml:Accel2></description></item>
///<item><description>CommentRowTarget &lt;xvml:Row></description></item>
///<item><description>CommentColumnTarget &lt;xvml:Column></description></item>
///<item><description>Visible &lt;xvml:Visible></description></item>
///<item><description>RowHidden &lt;xvml:RowHidden></description></item>
///<item><description>ColumnHidden &lt;xvml:ColHidden></description></item>
///<item><description>InputValidationType &lt;xvml:VTEdit></description></item>
///<item><description>MultiLine &lt;xvml:MultiLine></description></item>
///<item><description>VerticalScrollBar &lt;xvml:VScroll></description></item>
///<item><description>ValidIds &lt;xvml:ValidIds></description></item>
///<item><description>FormulaRange &lt;xvml:FmlaRange></description></item>
///<item><description>MinDropDownWidth &lt;xvml:WidthMin></description></item>
///<item><description>SelectionEntry &lt;xvml:Sel></description></item>
///<item><description>Disable3DForListBoxAndDropDown &lt;xvml:NoThreeD2></description></item>
///<item><description>SelectionType &lt;xvml:SelType></description></item>
///<item><description>MultiSelections &lt;xvml:MultiSel></description></item>
///<item><description>ListBoxCallbackType &lt;xvml:LCT></description></item>
///<item><description>ListItem &lt;xvml:ListItem></description></item>
///<item><description>DropStyle &lt;xvml:DropStyle></description></item>
///<item><description>Colored &lt;xvml:Colored></description></item>
///<item><description>DropLines &lt;xvml:DropLines></description></item>
///<item><description>Checked &lt;xvml:Checked></description></item>
///<item><description>FormulaLink &lt;xvml:FmlaLink></description></item>
///<item><description>FormulaPicture &lt;xvml:FmlaPict></description></item>
///<item><description>Disable3D &lt;xvml:NoThreeD></description></item>
///<item><description>FirstButton &lt;xvml:FirstButton></description></item>
///<item><description>FormulaGroup &lt;xvml:FmlaGroup></description></item>
///<item><description>ScrollBarPosition &lt;xvml:Val></description></item>
///<item><description>ScrollBarMin &lt;xvml:Min></description></item>
///<item><description>ScrollBarMax &lt;xvml:Max></description></item>
///<item><description>ScrollBarIncrement &lt;xvml:Inc></description></item>
///<item><description>ScrollBarPageIncrement &lt;xvml:Page></description></item>
///<item><description>HorizontalScrollBar &lt;xvml:Horiz></description></item>
///<item><description>ScrollBarWidth &lt;xvml:Dx></description></item>
///<item><description>MapOcxControl &lt;xvml:MapOCX></description></item>
///<item><description>ClipboardFormat &lt;xvml:CF></description></item>
///<item><description>CameraObject &lt;xvml:Camera></description></item>
///<item><description>RecalculateAlways &lt;xvml:RecalcAlways></description></item>
///<item><description>AutoScaleFont &lt;xvml:AutoScale></description></item>
///<item><description>DdeObject &lt;xvml:DDE></description></item>
///<item><description>UIObject &lt;xvml:UIObj></description></item>
///<item><description>ScriptText &lt;xvml:ScriptText></description></item>
///<item><description>ScriptExtended &lt;xvml:ScriptExtended></description></item>
///<item><description>ScriptLanguage &lt;xvml:ScriptLanguage></description></item>
///<item><description>ScriptLocation &lt;xvml:ScriptLocation></description></item>
///<item><description>FormulaTextBox &lt;xvml:FmlaTxbx></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(MoveWithCells))]
    [ChildElementInfo(typeof(ResizeWithCells))]
    [ChildElementInfo(typeof(Anchor))]
    [ChildElementInfo(typeof(Locked))]
    [ChildElementInfo(typeof(DefaultSize))]
    [ChildElementInfo(typeof(PrintObject))]
    [ChildElementInfo(typeof(Disabled))]
    [ChildElementInfo(typeof(AutoFill))]
    [ChildElementInfo(typeof(AutoLine))]
    [ChildElementInfo(typeof(AutoSizePicture))]
    [ChildElementInfo(typeof(FormulaMacro))]
    [ChildElementInfo(typeof(HorizontalTextAlignment))]
    [ChildElementInfo(typeof(VerticalTextAlignment))]
    [ChildElementInfo(typeof(LockText))]
    [ChildElementInfo(typeof(JustifyLastLine))]
    [ChildElementInfo(typeof(SecretEdit))]
    [ChildElementInfo(typeof(DefaultButton))]
    [ChildElementInfo(typeof(HelpButton))]
    [ChildElementInfo(typeof(CancelButton))]
    [ChildElementInfo(typeof(DismissButton))]
    [ChildElementInfo(typeof(AcceleratorPrimary))]
    [ChildElementInfo(typeof(AcceleratorSecondary))]
    [ChildElementInfo(typeof(CommentRowTarget))]
    [ChildElementInfo(typeof(CommentColumnTarget))]
    [ChildElementInfo(typeof(Visible))]
    [ChildElementInfo(typeof(RowHidden))]
    [ChildElementInfo(typeof(ColumnHidden))]
    [ChildElementInfo(typeof(InputValidationType))]
    [ChildElementInfo(typeof(MultiLine))]
    [ChildElementInfo(typeof(VerticalScrollBar))]
    [ChildElementInfo(typeof(ValidIds))]
    [ChildElementInfo(typeof(FormulaRange))]
    [ChildElementInfo(typeof(MinDropDownWidth))]
    [ChildElementInfo(typeof(SelectionEntry))]
    [ChildElementInfo(typeof(Disable3DForListBoxAndDropDown))]
    [ChildElementInfo(typeof(SelectionType))]
    [ChildElementInfo(typeof(MultiSelections))]
    [ChildElementInfo(typeof(ListBoxCallbackType))]
    [ChildElementInfo(typeof(ListItem))]
    [ChildElementInfo(typeof(DropStyle))]
    [ChildElementInfo(typeof(Colored))]
    [ChildElementInfo(typeof(DropLines))]
    [ChildElementInfo(typeof(Checked))]
    [ChildElementInfo(typeof(FormulaLink))]
    [ChildElementInfo(typeof(FormulaPicture))]
    [ChildElementInfo(typeof(Disable3D))]
    [ChildElementInfo(typeof(FirstButton))]
    [ChildElementInfo(typeof(FormulaGroup))]
    [ChildElementInfo(typeof(ScrollBarPosition))]
    [ChildElementInfo(typeof(ScrollBarMin))]
    [ChildElementInfo(typeof(ScrollBarMax))]
    [ChildElementInfo(typeof(ScrollBarIncrement))]
    [ChildElementInfo(typeof(ScrollBarPageIncrement))]
    [ChildElementInfo(typeof(HorizontalScrollBar))]
    [ChildElementInfo(typeof(ScrollBarWidth))]
    [ChildElementInfo(typeof(MapOcxControl))]
    [ChildElementInfo(typeof(ClipboardFormat))]
    [ChildElementInfo(typeof(CameraObject))]
    [ChildElementInfo(typeof(RecalculateAlways))]
    [ChildElementInfo(typeof(AutoScaleFont))]
    [ChildElementInfo(typeof(DdeObject))]
    [ChildElementInfo(typeof(UIObject))]
    [ChildElementInfo(typeof(ScriptText))]
    [ChildElementInfo(typeof(ScriptExtended))]
    [ChildElementInfo(typeof(ScriptLanguage))]
    [ChildElementInfo(typeof(ScriptLocation))]
    [ChildElementInfo(typeof(FormulaTextBox))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ClientData : OpenXmlCompositeElement
{
    private const string tagName = "ClientData";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12507;
    
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
    

    private static string[] attributeTagNames = { "ObjectType" };
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
    /// <para> Object type.</para>
    /// <para>Represents the following attribute in the schema: ObjectType </para>
    /// </summary>
    [SchemaAttr(0, "ObjectType")]
    public EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.ObjectValues> ObjectType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.ObjectValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ClientData class.
    /// </summary>
    public ClientData():base(){}
    
            /// <summary>
    ///Initializes a new instance of the ClientData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ClientData(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ClientData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ClientData(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ClientData class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ClientData(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 29 == namespaceId && "MoveWithCells" == name)
    return new MoveWithCells();
    
if( 29 == namespaceId && "SizeWithCells" == name)
    return new ResizeWithCells();
    
if( 29 == namespaceId && "Anchor" == name)
    return new Anchor();
    
if( 29 == namespaceId && "Locked" == name)
    return new Locked();
    
if( 29 == namespaceId && "DefaultSize" == name)
    return new DefaultSize();
    
if( 29 == namespaceId && "PrintObject" == name)
    return new PrintObject();
    
if( 29 == namespaceId && "Disabled" == name)
    return new Disabled();
    
if( 29 == namespaceId && "AutoFill" == name)
    return new AutoFill();
    
if( 29 == namespaceId && "AutoLine" == name)
    return new AutoLine();
    
if( 29 == namespaceId && "AutoPict" == name)
    return new AutoSizePicture();
    
if( 29 == namespaceId && "FmlaMacro" == name)
    return new FormulaMacro();
    
if( 29 == namespaceId && "TextHAlign" == name)
    return new HorizontalTextAlignment();
    
if( 29 == namespaceId && "TextVAlign" == name)
    return new VerticalTextAlignment();
    
if( 29 == namespaceId && "LockText" == name)
    return new LockText();
    
if( 29 == namespaceId && "JustLastX" == name)
    return new JustifyLastLine();
    
if( 29 == namespaceId && "SecretEdit" == name)
    return new SecretEdit();
    
if( 29 == namespaceId && "Default" == name)
    return new DefaultButton();
    
if( 29 == namespaceId && "Help" == name)
    return new HelpButton();
    
if( 29 == namespaceId && "Cancel" == name)
    return new CancelButton();
    
if( 29 == namespaceId && "Dismiss" == name)
    return new DismissButton();
    
if( 29 == namespaceId && "Accel" == name)
    return new AcceleratorPrimary();
    
if( 29 == namespaceId && "Accel2" == name)
    return new AcceleratorSecondary();
    
if( 29 == namespaceId && "Row" == name)
    return new CommentRowTarget();
    
if( 29 == namespaceId && "Column" == name)
    return new CommentColumnTarget();
    
if( 29 == namespaceId && "Visible" == name)
    return new Visible();
    
if( 29 == namespaceId && "RowHidden" == name)
    return new RowHidden();
    
if( 29 == namespaceId && "ColHidden" == name)
    return new ColumnHidden();
    
if( 29 == namespaceId && "VTEdit" == name)
    return new InputValidationType();
    
if( 29 == namespaceId && "MultiLine" == name)
    return new MultiLine();
    
if( 29 == namespaceId && "VScroll" == name)
    return new VerticalScrollBar();
    
if( 29 == namespaceId && "ValidIds" == name)
    return new ValidIds();
    
if( 29 == namespaceId && "FmlaRange" == name)
    return new FormulaRange();
    
if( 29 == namespaceId && "WidthMin" == name)
    return new MinDropDownWidth();
    
if( 29 == namespaceId && "Sel" == name)
    return new SelectionEntry();
    
if( 29 == namespaceId && "NoThreeD2" == name)
    return new Disable3DForListBoxAndDropDown();
    
if( 29 == namespaceId && "SelType" == name)
    return new SelectionType();
    
if( 29 == namespaceId && "MultiSel" == name)
    return new MultiSelections();
    
if( 29 == namespaceId && "LCT" == name)
    return new ListBoxCallbackType();
    
if( 29 == namespaceId && "ListItem" == name)
    return new ListItem();
    
if( 29 == namespaceId && "DropStyle" == name)
    return new DropStyle();
    
if( 29 == namespaceId && "Colored" == name)
    return new Colored();
    
if( 29 == namespaceId && "DropLines" == name)
    return new DropLines();
    
if( 29 == namespaceId && "Checked" == name)
    return new Checked();
    
if( 29 == namespaceId && "FmlaLink" == name)
    return new FormulaLink();
    
if( 29 == namespaceId && "FmlaPict" == name)
    return new FormulaPicture();
    
if( 29 == namespaceId && "NoThreeD" == name)
    return new Disable3D();
    
if( 29 == namespaceId && "FirstButton" == name)
    return new FirstButton();
    
if( 29 == namespaceId && "FmlaGroup" == name)
    return new FormulaGroup();
    
if( 29 == namespaceId && "Val" == name)
    return new ScrollBarPosition();
    
if( 29 == namespaceId && "Min" == name)
    return new ScrollBarMin();
    
if( 29 == namespaceId && "Max" == name)
    return new ScrollBarMax();
    
if( 29 == namespaceId && "Inc" == name)
    return new ScrollBarIncrement();
    
if( 29 == namespaceId && "Page" == name)
    return new ScrollBarPageIncrement();
    
if( 29 == namespaceId && "Horiz" == name)
    return new HorizontalScrollBar();
    
if( 29 == namespaceId && "Dx" == name)
    return new ScrollBarWidth();
    
if( 29 == namespaceId && "MapOCX" == name)
    return new MapOcxControl();
    
if( 29 == namespaceId && "CF" == name)
    return new ClipboardFormat();
    
if( 29 == namespaceId && "Camera" == name)
    return new CameraObject();
    
if( 29 == namespaceId && "RecalcAlways" == name)
    return new RecalculateAlways();
    
if( 29 == namespaceId && "AutoScale" == name)
    return new AutoScaleFont();
    
if( 29 == namespaceId && "DDE" == name)
    return new DdeObject();
    
if( 29 == namespaceId && "UIObj" == name)
    return new UIObject();
    
if( 29 == namespaceId && "ScriptText" == name)
    return new ScriptText();
    
if( 29 == namespaceId && "ScriptExtended" == name)
    return new ScriptExtended();
    
if( 29 == namespaceId && "ScriptLanguage" == name)
    return new ScriptLanguage();
    
if( 29 == namespaceId && "ScriptLocation" == name)
    return new ScriptLocation();
    
if( 29 == namespaceId && "FmlaTxbx" == name)
    return new FormulaTextBox();
    

    return null;
}

    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "ObjectType" == name)
    return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.ObjectValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ClientData>(deep);
    }

   
}
/// <summary>
/// <para>Move with Cells.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:MoveWithCells.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class MoveWithCells : OpenXmlLeafTextElement
{
    private const string tagName = "MoveWithCells";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12508;
    
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
    /// Initializes a new instance of the MoveWithCells class.
    /// </summary>
    public MoveWithCells():base(){}
    
           /// <summary>
    /// Initializes a new instance of the MoveWithCells class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public MoveWithCells(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<MoveWithCells>(deep);
    }

}
/// <summary>
/// <para>Resize with Cells.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:SizeWithCells.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ResizeWithCells : OpenXmlLeafTextElement
{
    private const string tagName = "SizeWithCells";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12509;
    
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
    /// Initializes a new instance of the ResizeWithCells class.
    /// </summary>
    public ResizeWithCells():base(){}
    
           /// <summary>
    /// Initializes a new instance of the ResizeWithCells class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public ResizeWithCells(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ResizeWithCells>(deep);
    }

}
/// <summary>
/// <para>Lock Toggle.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:Locked.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Locked : OpenXmlLeafTextElement
{
    private const string tagName = "Locked";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12511;
    
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
    /// Initializes a new instance of the Locked class.
    /// </summary>
    public Locked():base(){}
    
           /// <summary>
    /// Initializes a new instance of the Locked class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Locked(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Locked>(deep);
    }

}
/// <summary>
/// <para>Default Size Toggle.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:DefaultSize.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class DefaultSize : OpenXmlLeafTextElement
{
    private const string tagName = "DefaultSize";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12512;
    
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
    /// Initializes a new instance of the DefaultSize class.
    /// </summary>
    public DefaultSize():base(){}
    
           /// <summary>
    /// Initializes a new instance of the DefaultSize class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public DefaultSize(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<DefaultSize>(deep);
    }

}
/// <summary>
/// <para>Print Toggle.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:PrintObject.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class PrintObject : OpenXmlLeafTextElement
{
    private const string tagName = "PrintObject";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12513;
    
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
    /// Initializes a new instance of the PrintObject class.
    /// </summary>
    public PrintObject():base(){}
    
           /// <summary>
    /// Initializes a new instance of the PrintObject class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public PrintObject(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<PrintObject>(deep);
    }

}
/// <summary>
/// <para>Macro Disable Toggle.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:Disabled.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Disabled : OpenXmlLeafTextElement
{
    private const string tagName = "Disabled";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12514;
    
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
    /// Initializes a new instance of the Disabled class.
    /// </summary>
    public Disabled():base(){}
    
           /// <summary>
    /// Initializes a new instance of the Disabled class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Disabled(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Disabled>(deep);
    }

}
/// <summary>
/// <para>AutoFill.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:AutoFill.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class AutoFill : OpenXmlLeafTextElement
{
    private const string tagName = "AutoFill";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12515;
    
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
    /// Initializes a new instance of the AutoFill class.
    /// </summary>
    public AutoFill():base(){}
    
           /// <summary>
    /// Initializes a new instance of the AutoFill class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public AutoFill(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<AutoFill>(deep);
    }

}
/// <summary>
/// <para>AutoLine.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:AutoLine.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class AutoLine : OpenXmlLeafTextElement
{
    private const string tagName = "AutoLine";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12516;
    
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
    /// Initializes a new instance of the AutoLine class.
    /// </summary>
    public AutoLine():base(){}
    
           /// <summary>
    /// Initializes a new instance of the AutoLine class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public AutoLine(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<AutoLine>(deep);
    }

}
/// <summary>
/// <para>Automatically Size.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:AutoPict.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class AutoSizePicture : OpenXmlLeafTextElement
{
    private const string tagName = "AutoPict";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12517;
    
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
    /// Initializes a new instance of the AutoSizePicture class.
    /// </summary>
    public AutoSizePicture():base(){}
    
           /// <summary>
    /// Initializes a new instance of the AutoSizePicture class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public AutoSizePicture(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<AutoSizePicture>(deep);
    }

}
/// <summary>
/// <para>Text Lock.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:LockText.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class LockText : OpenXmlLeafTextElement
{
    private const string tagName = "LockText";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12521;
    
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
    /// Initializes a new instance of the LockText class.
    /// </summary>
    public LockText():base(){}
    
           /// <summary>
    /// Initializes a new instance of the LockText class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public LockText(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<LockText>(deep);
    }

}
/// <summary>
/// <para>Far East Alignment Toggle.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:JustLastX.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class JustifyLastLine : OpenXmlLeafTextElement
{
    private const string tagName = "JustLastX";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12522;
    
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
    /// Initializes a new instance of the JustifyLastLine class.
    /// </summary>
    public JustifyLastLine():base(){}
    
           /// <summary>
    /// Initializes a new instance of the JustifyLastLine class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public JustifyLastLine(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<JustifyLastLine>(deep);
    }

}
/// <summary>
/// <para>Password Edit.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:SecretEdit.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class SecretEdit : OpenXmlLeafTextElement
{
    private const string tagName = "SecretEdit";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12523;
    
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
    /// Initializes a new instance of the SecretEdit class.
    /// </summary>
    public SecretEdit():base(){}
    
           /// <summary>
    /// Initializes a new instance of the SecretEdit class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public SecretEdit(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<SecretEdit>(deep);
    }

}
/// <summary>
/// <para>Default Button.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:Default.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class DefaultButton : OpenXmlLeafTextElement
{
    private const string tagName = "Default";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12524;
    
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
    /// Initializes a new instance of the DefaultButton class.
    /// </summary>
    public DefaultButton():base(){}
    
           /// <summary>
    /// Initializes a new instance of the DefaultButton class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public DefaultButton(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<DefaultButton>(deep);
    }

}
/// <summary>
/// <para>Help Button.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:Help.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class HelpButton : OpenXmlLeafTextElement
{
    private const string tagName = "Help";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12525;
    
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
    /// Initializes a new instance of the HelpButton class.
    /// </summary>
    public HelpButton():base(){}
    
           /// <summary>
    /// Initializes a new instance of the HelpButton class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public HelpButton(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<HelpButton>(deep);
    }

}
/// <summary>
/// <para>Cancel Button.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:Cancel.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class CancelButton : OpenXmlLeafTextElement
{
    private const string tagName = "Cancel";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12526;
    
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
    /// Initializes a new instance of the CancelButton class.
    /// </summary>
    public CancelButton():base(){}
    
           /// <summary>
    /// Initializes a new instance of the CancelButton class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public CancelButton(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<CancelButton>(deep);
    }

}
/// <summary>
/// <para>Dismiss Button.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:Dismiss.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class DismissButton : OpenXmlLeafTextElement
{
    private const string tagName = "Dismiss";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12527;
    
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
    /// Initializes a new instance of the DismissButton class.
    /// </summary>
    public DismissButton():base(){}
    
           /// <summary>
    /// Initializes a new instance of the DismissButton class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public DismissButton(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<DismissButton>(deep);
    }

}
/// <summary>
/// <para>Comment Visibility Toggle.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:Visible.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Visible : OpenXmlLeafTextElement
{
    private const string tagName = "Visible";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12532;
    
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
    /// Initializes a new instance of the Visible class.
    /// </summary>
    public Visible():base(){}
    
           /// <summary>
    /// Initializes a new instance of the Visible class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Visible(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Visible>(deep);
    }

}
/// <summary>
/// <para>Comment's Row is Hidden.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:RowHidden.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class RowHidden : OpenXmlLeafTextElement
{
    private const string tagName = "RowHidden";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12533;
    
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
    /// Initializes a new instance of the RowHidden class.
    /// </summary>
    public RowHidden():base(){}
    
           /// <summary>
    /// Initializes a new instance of the RowHidden class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public RowHidden(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RowHidden>(deep);
    }

}
/// <summary>
/// <para>Comment's Column is Hidden.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:ColHidden.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ColumnHidden : OpenXmlLeafTextElement
{
    private const string tagName = "ColHidden";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12534;
    
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
    /// Initializes a new instance of the ColumnHidden class.
    /// </summary>
    public ColumnHidden():base(){}
    
           /// <summary>
    /// Initializes a new instance of the ColumnHidden class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public ColumnHidden(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ColumnHidden>(deep);
    }

}
/// <summary>
/// <para>Multi-line.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:MultiLine.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class MultiLine : OpenXmlLeafTextElement
{
    private const string tagName = "MultiLine";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12536;
    
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
    /// Initializes a new instance of the MultiLine class.
    /// </summary>
    public MultiLine():base(){}
    
           /// <summary>
    /// Initializes a new instance of the MultiLine class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public MultiLine(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<MultiLine>(deep);
    }

}
/// <summary>
/// <para>Vertical Scroll.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:VScroll.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VerticalScrollBar : OpenXmlLeafTextElement
{
    private const string tagName = "VScroll";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12537;
    
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
    /// Initializes a new instance of the VerticalScrollBar class.
    /// </summary>
    public VerticalScrollBar():base(){}
    
           /// <summary>
    /// Initializes a new instance of the VerticalScrollBar class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VerticalScrollBar(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VerticalScrollBar>(deep);
    }

}
/// <summary>
/// <para>Valid ID.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:ValidIds.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ValidIds : OpenXmlLeafTextElement
{
    private const string tagName = "ValidIds";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12538;
    
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
    /// Initializes a new instance of the ValidIds class.
    /// </summary>
    public ValidIds():base(){}
    
           /// <summary>
    /// Initializes a new instance of the ValidIds class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public ValidIds(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ValidIds>(deep);
    }

}
/// <summary>
/// <para>Disable 3D.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:NoThreeD2.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Disable3DForListBoxAndDropDown : OpenXmlLeafTextElement
{
    private const string tagName = "NoThreeD2";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12542;
    
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
    /// Initializes a new instance of the Disable3DForListBoxAndDropDown class.
    /// </summary>
    public Disable3DForListBoxAndDropDown():base(){}
    
           /// <summary>
    /// Initializes a new instance of the Disable3DForListBoxAndDropDown class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Disable3DForListBoxAndDropDown(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Disable3DForListBoxAndDropDown>(deep);
    }

}
/// <summary>
/// <para>Dropdown Color Toggle.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:Colored.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Colored : OpenXmlLeafTextElement
{
    private const string tagName = "Colored";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12548;
    
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
    /// Initializes a new instance of the Colored class.
    /// </summary>
    public Colored():base(){}
    
           /// <summary>
    /// Initializes a new instance of the Colored class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Colored(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Colored>(deep);
    }

}
/// <summary>
/// <para>Disable 3D.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:NoThreeD.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Disable3D : OpenXmlLeafTextElement
{
    private const string tagName = "NoThreeD";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12553;
    
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
    /// Initializes a new instance of the Disable3D class.
    /// </summary>
    public Disable3D():base(){}
    
           /// <summary>
    /// Initializes a new instance of the Disable3D class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Disable3D(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Disable3D>(deep);
    }

}
/// <summary>
/// <para>First Radio Button.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:FirstButton.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class FirstButton : OpenXmlLeafTextElement
{
    private const string tagName = "FirstButton";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12554;
    
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
    /// Initializes a new instance of the FirstButton class.
    /// </summary>
    public FirstButton():base(){}
    
           /// <summary>
    /// Initializes a new instance of the FirstButton class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public FirstButton(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<FirstButton>(deep);
    }

}
/// <summary>
/// <para>Scroll Bar Orientation.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:Horiz.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class HorizontalScrollBar : OpenXmlLeafTextElement
{
    private const string tagName = "Horiz";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12561;
    
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
    /// Initializes a new instance of the HorizontalScrollBar class.
    /// </summary>
    public HorizontalScrollBar():base(){}
    
           /// <summary>
    /// Initializes a new instance of the HorizontalScrollBar class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public HorizontalScrollBar(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<HorizontalScrollBar>(deep);
    }

}
/// <summary>
/// <para>ActiveX Control.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:MapOCX.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class MapOcxControl : OpenXmlLeafTextElement
{
    private const string tagName = "MapOCX";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12563;
    
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
    /// Initializes a new instance of the MapOcxControl class.
    /// </summary>
    public MapOcxControl():base(){}
    
           /// <summary>
    /// Initializes a new instance of the MapOcxControl class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public MapOcxControl(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<MapOcxControl>(deep);
    }

}
/// <summary>
/// <para>Camera Tool.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:Camera.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class CameraObject : OpenXmlLeafTextElement
{
    private const string tagName = "Camera";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12565;
    
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
    /// Initializes a new instance of the CameraObject class.
    /// </summary>
    public CameraObject():base(){}
    
           /// <summary>
    /// Initializes a new instance of the CameraObject class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public CameraObject(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<CameraObject>(deep);
    }

}
/// <summary>
/// <para>Recalculation Toggle.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:RecalcAlways.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class RecalculateAlways : OpenXmlLeafTextElement
{
    private const string tagName = "RecalcAlways";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12566;
    
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
    /// Initializes a new instance of the RecalculateAlways class.
    /// </summary>
    public RecalculateAlways():base(){}
    
           /// <summary>
    /// Initializes a new instance of the RecalculateAlways class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public RecalculateAlways(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RecalculateAlways>(deep);
    }

}
/// <summary>
/// <para>Font AutoScale.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:AutoScale.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class AutoScaleFont : OpenXmlLeafTextElement
{
    private const string tagName = "AutoScale";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12567;
    
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
    /// Initializes a new instance of the AutoScaleFont class.
    /// </summary>
    public AutoScaleFont():base(){}
    
           /// <summary>
    /// Initializes a new instance of the AutoScaleFont class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public AutoScaleFont(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<AutoScaleFont>(deep);
    }

}
/// <summary>
/// <para>Dynamic Data Exchange.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:DDE.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class DdeObject : OpenXmlLeafTextElement
{
    private const string tagName = "DDE";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12568;
    
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
    /// Initializes a new instance of the DdeObject class.
    /// </summary>
    public DdeObject():base(){}
    
           /// <summary>
    /// Initializes a new instance of the DdeObject class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public DdeObject(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<DdeObject>(deep);
    }

}
/// <summary>
/// <para>UI Object Toggle.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:UIObj.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class UIObject : OpenXmlLeafTextElement
{
    private const string tagName = "UIObj";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12569;
    
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
    /// Initializes a new instance of the UIObject class.
    /// </summary>
    public UIObject():base(){}
    
           /// <summary>
    /// Initializes a new instance of the UIObject class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public UIObject(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.BooleanEntryWithBlankValues>(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<UIObject>(deep);
    }

}
/// <summary>
/// <para>Anchor.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:Anchor.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Anchor : OpenXmlLeafTextElement
{
    private const string tagName = "Anchor";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12510;
    
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
    /// Initializes a new instance of the Anchor class.
    /// </summary>
    public Anchor():base(){}
    
           /// <summary>
    /// Initializes a new instance of the Anchor class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Anchor(string text):base(text)
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
        return CloneImp<Anchor>(deep);
    }

}
/// <summary>
/// <para>Horizontal Text Alignment.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:TextHAlign.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class HorizontalTextAlignment : OpenXmlLeafTextElement
{
    private const string tagName = "TextHAlign";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12519;
    
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
    /// Initializes a new instance of the HorizontalTextAlignment class.
    /// </summary>
    public HorizontalTextAlignment():base(){}
    
           /// <summary>
    /// Initializes a new instance of the HorizontalTextAlignment class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public HorizontalTextAlignment(string text):base(text)
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
        return CloneImp<HorizontalTextAlignment>(deep);
    }

}
/// <summary>
/// <para>Vertical Text Alignment.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:TextVAlign.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VerticalTextAlignment : OpenXmlLeafTextElement
{
    private const string tagName = "TextVAlign";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12520;
    
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
    /// Initializes a new instance of the VerticalTextAlignment class.
    /// </summary>
    public VerticalTextAlignment():base(){}
    
           /// <summary>
    /// Initializes a new instance of the VerticalTextAlignment class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public VerticalTextAlignment(string text):base(text)
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
        return CloneImp<VerticalTextAlignment>(deep);
    }

}
/// <summary>
/// <para>List Items Source Range.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:FmlaRange.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class FormulaRange : OpenXmlLeafTextElement
{
    private const string tagName = "FmlaRange";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12539;
    
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
    /// Initializes a new instance of the FormulaRange class.
    /// </summary>
    public FormulaRange():base(){}
    
           /// <summary>
    /// Initializes a new instance of the FormulaRange class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public FormulaRange(string text):base(text)
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
        return CloneImp<FormulaRange>(deep);
    }

}
/// <summary>
/// <para>Selection Type.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:SelType.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class SelectionType : OpenXmlLeafTextElement
{
    private const string tagName = "SelType";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12543;
    
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
    /// Initializes a new instance of the SelectionType class.
    /// </summary>
    public SelectionType():base(){}
    
           /// <summary>
    /// Initializes a new instance of the SelectionType class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public SelectionType(string text):base(text)
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
        return CloneImp<SelectionType>(deep);
    }

}
/// <summary>
/// <para>Multiple Selections.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:MultiSel.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class MultiSelections : OpenXmlLeafTextElement
{
    private const string tagName = "MultiSel";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12544;
    
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
    /// Initializes a new instance of the MultiSelections class.
    /// </summary>
    public MultiSelections():base(){}
    
           /// <summary>
    /// Initializes a new instance of the MultiSelections class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public MultiSelections(string text):base(text)
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
        return CloneImp<MultiSelections>(deep);
    }

}
/// <summary>
/// <para>Callback Type.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:LCT.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ListBoxCallbackType : OpenXmlLeafTextElement
{
    private const string tagName = "LCT";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12545;
    
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
    /// Initializes a new instance of the ListBoxCallbackType class.
    /// </summary>
    public ListBoxCallbackType():base(){}
    
           /// <summary>
    /// Initializes a new instance of the ListBoxCallbackType class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public ListBoxCallbackType(string text):base(text)
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
        return CloneImp<ListBoxCallbackType>(deep);
    }

}
/// <summary>
/// <para>Non-linked List Item.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:ListItem.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ListItem : OpenXmlLeafTextElement
{
    private const string tagName = "ListItem";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12546;
    
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
    /// Initializes a new instance of the ListItem class.
    /// </summary>
    public ListItem():base(){}
    
           /// <summary>
    /// Initializes a new instance of the ListItem class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public ListItem(string text):base(text)
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
        return CloneImp<ListItem>(deep);
    }

}
/// <summary>
/// <para>Dropdown Style.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:DropStyle.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class DropStyle : OpenXmlLeafTextElement
{
    private const string tagName = "DropStyle";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12547;
    
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
    /// Initializes a new instance of the DropStyle class.
    /// </summary>
    public DropStyle():base(){}
    
           /// <summary>
    /// Initializes a new instance of the DropStyle class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public DropStyle(string text):base(text)
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
        return CloneImp<DropStyle>(deep);
    }

}
/// <summary>
/// <para>Linked Formula.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:FmlaLink.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class FormulaLink : OpenXmlLeafTextElement
{
    private const string tagName = "FmlaLink";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12551;
    
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
    /// Initializes a new instance of the FormulaLink class.
    /// </summary>
    public FormulaLink():base(){}
    
           /// <summary>
    /// Initializes a new instance of the FormulaLink class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public FormulaLink(string text):base(text)
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
        return CloneImp<FormulaLink>(deep);
    }

}
/// <summary>
/// <para>Camera Source Range.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:FmlaPict.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class FormulaPicture : OpenXmlLeafTextElement
{
    private const string tagName = "FmlaPict";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12552;
    
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
    /// Initializes a new instance of the FormulaPicture class.
    /// </summary>
    public FormulaPicture():base(){}
    
           /// <summary>
    /// Initializes a new instance of the FormulaPicture class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public FormulaPicture(string text):base(text)
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
        return CloneImp<FormulaPicture>(deep);
    }

}
/// <summary>
/// <para>Linked Formula - Group Box.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:FmlaGroup.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class FormulaGroup : OpenXmlLeafTextElement
{
    private const string tagName = "FmlaGroup";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12555;
    
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
    /// Initializes a new instance of the FormulaGroup class.
    /// </summary>
    public FormulaGroup():base(){}
    
           /// <summary>
    /// Initializes a new instance of the FormulaGroup class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public FormulaGroup(string text):base(text)
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
        return CloneImp<FormulaGroup>(deep);
    }

}
/// <summary>
/// <para>HTML Script Text.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:ScriptText.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ScriptText : OpenXmlLeafTextElement
{
    private const string tagName = "ScriptText";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12570;
    
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
    /// Initializes a new instance of the ScriptText class.
    /// </summary>
    public ScriptText():base(){}
    
           /// <summary>
    /// Initializes a new instance of the ScriptText class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public ScriptText(string text):base(text)
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
        return CloneImp<ScriptText>(deep);
    }

}
/// <summary>
/// <para>HTML Script Attributes.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:ScriptExtended.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ScriptExtended : OpenXmlLeafTextElement
{
    private const string tagName = "ScriptExtended";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12571;
    
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
    /// Initializes a new instance of the ScriptExtended class.
    /// </summary>
    public ScriptExtended():base(){}
    
           /// <summary>
    /// Initializes a new instance of the ScriptExtended class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public ScriptExtended(string text):base(text)
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
        return CloneImp<ScriptExtended>(deep);
    }

}
/// <summary>
/// <para>Text Formula.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:FmlaTxbx.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class FormulaTextBox : OpenXmlLeafTextElement
{
    private const string tagName = "FmlaTxbx";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12574;
    
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
    /// Initializes a new instance of the FormulaTextBox class.
    /// </summary>
    public FormulaTextBox():base(){}
    
           /// <summary>
    /// Initializes a new instance of the FormulaTextBox class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public FormulaTextBox(string text):base(text)
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
        return CloneImp<FormulaTextBox>(deep);
    }

}
/// <summary>
/// <para>Reference to Custom Function.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:FmlaMacro.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class FormulaMacro : OpenXmlLeafTextElement
{
    private const string tagName = "FmlaMacro";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12518;
    
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
    /// Initializes a new instance of the FormulaMacro class.
    /// </summary>
    public FormulaMacro():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the FormulaMacro class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public FormulaMacro(string text):base(text)
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
        return CloneImp<FormulaMacro>(deep);
    }

   
}
/// <summary>
/// <para>Primary Keyboard Accelerator.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:Accel.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class AcceleratorPrimary : OpenXmlLeafTextElement
{
    private const string tagName = "Accel";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12528;
    
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
    /// Initializes a new instance of the AcceleratorPrimary class.
    /// </summary>
    public AcceleratorPrimary():base(){}
    
           /// <summary>
    /// Initializes a new instance of the AcceleratorPrimary class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public AcceleratorPrimary(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new ByteValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<AcceleratorPrimary>(deep);
    }

}
/// <summary>
/// <para>Secondary Keyboard Accelerator.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:Accel2.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class AcceleratorSecondary : OpenXmlLeafTextElement
{
    private const string tagName = "Accel2";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12529;
    
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
    /// Initializes a new instance of the AcceleratorSecondary class.
    /// </summary>
    public AcceleratorSecondary():base(){}
    
           /// <summary>
    /// Initializes a new instance of the AcceleratorSecondary class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public AcceleratorSecondary(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new ByteValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<AcceleratorSecondary>(deep);
    }

}
/// <summary>
/// <para>Comment Row Target.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:Row.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class CommentRowTarget : OpenXmlLeafTextElement
{
    private const string tagName = "Row";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12530;
    
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
    /// Initializes a new instance of the CommentRowTarget class.
    /// </summary>
    public CommentRowTarget():base(){}
    
           /// <summary>
    /// Initializes a new instance of the CommentRowTarget class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public CommentRowTarget(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new IntegerValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<CommentRowTarget>(deep);
    }

}
/// <summary>
/// <para>Comment Column Target.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:Column.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class CommentColumnTarget : OpenXmlLeafTextElement
{
    private const string tagName = "Column";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12531;
    
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
    /// Initializes a new instance of the CommentColumnTarget class.
    /// </summary>
    public CommentColumnTarget():base(){}
    
           /// <summary>
    /// Initializes a new instance of the CommentColumnTarget class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public CommentColumnTarget(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new IntegerValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<CommentColumnTarget>(deep);
    }

}
/// <summary>
/// <para>Validation Type.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:VTEdit.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class InputValidationType : OpenXmlLeafTextElement
{
    private const string tagName = "VTEdit";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12535;
    
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
    /// Initializes a new instance of the InputValidationType class.
    /// </summary>
    public InputValidationType():base(){}
    
           /// <summary>
    /// Initializes a new instance of the InputValidationType class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public InputValidationType(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new IntegerValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<InputValidationType>(deep);
    }

}
/// <summary>
/// <para>Minimum Width.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:WidthMin.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class MinDropDownWidth : OpenXmlLeafTextElement
{
    private const string tagName = "WidthMin";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12540;
    
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
    /// Initializes a new instance of the MinDropDownWidth class.
    /// </summary>
    public MinDropDownWidth():base(){}
    
           /// <summary>
    /// Initializes a new instance of the MinDropDownWidth class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public MinDropDownWidth(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new IntegerValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<MinDropDownWidth>(deep);
    }

}
/// <summary>
/// <para>Selected Entry.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:Sel.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class SelectionEntry : OpenXmlLeafTextElement
{
    private const string tagName = "Sel";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12541;
    
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
    /// Initializes a new instance of the SelectionEntry class.
    /// </summary>
    public SelectionEntry():base(){}
    
           /// <summary>
    /// Initializes a new instance of the SelectionEntry class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public SelectionEntry(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new IntegerValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<SelectionEntry>(deep);
    }

}
/// <summary>
/// <para>Dropdown Maximum Lines.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:DropLines.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class DropLines : OpenXmlLeafTextElement
{
    private const string tagName = "DropLines";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12549;
    
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
    /// Initializes a new instance of the DropLines class.
    /// </summary>
    public DropLines():base(){}
    
           /// <summary>
    /// Initializes a new instance of the DropLines class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public DropLines(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new IntegerValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<DropLines>(deep);
    }

}
/// <summary>
/// <para>Checked.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:Checked.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Checked : OpenXmlLeafTextElement
{
    private const string tagName = "Checked";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12550;
    
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
    /// Initializes a new instance of the Checked class.
    /// </summary>
    public Checked():base(){}
    
           /// <summary>
    /// Initializes a new instance of the Checked class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Checked(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new IntegerValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Checked>(deep);
    }

}
/// <summary>
/// <para>Scroll bar position.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:Val.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ScrollBarPosition : OpenXmlLeafTextElement
{
    private const string tagName = "Val";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12556;
    
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
    /// Initializes a new instance of the ScrollBarPosition class.
    /// </summary>
    public ScrollBarPosition():base(){}
    
           /// <summary>
    /// Initializes a new instance of the ScrollBarPosition class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public ScrollBarPosition(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new IntegerValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ScrollBarPosition>(deep);
    }

}
/// <summary>
/// <para>Scroll Bar Minimum.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:Min.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ScrollBarMin : OpenXmlLeafTextElement
{
    private const string tagName = "Min";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12557;
    
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
    /// Initializes a new instance of the ScrollBarMin class.
    /// </summary>
    public ScrollBarMin():base(){}
    
           /// <summary>
    /// Initializes a new instance of the ScrollBarMin class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public ScrollBarMin(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new IntegerValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ScrollBarMin>(deep);
    }

}
/// <summary>
/// <para>Scroll Bar Maximum.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:Max.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ScrollBarMax : OpenXmlLeafTextElement
{
    private const string tagName = "Max";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12558;
    
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
    /// Initializes a new instance of the ScrollBarMax class.
    /// </summary>
    public ScrollBarMax():base(){}
    
           /// <summary>
    /// Initializes a new instance of the ScrollBarMax class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public ScrollBarMax(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new IntegerValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ScrollBarMax>(deep);
    }

}
/// <summary>
/// <para>Scroll Bar Increment.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:Inc.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ScrollBarIncrement : OpenXmlLeafTextElement
{
    private const string tagName = "Inc";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12559;
    
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
    /// Initializes a new instance of the ScrollBarIncrement class.
    /// </summary>
    public ScrollBarIncrement():base(){}
    
           /// <summary>
    /// Initializes a new instance of the ScrollBarIncrement class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public ScrollBarIncrement(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new IntegerValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ScrollBarIncrement>(deep);
    }

}
/// <summary>
/// <para>Scroll Bar Page Increment.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:Page.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ScrollBarPageIncrement : OpenXmlLeafTextElement
{
    private const string tagName = "Page";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12560;
    
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
    /// Initializes a new instance of the ScrollBarPageIncrement class.
    /// </summary>
    public ScrollBarPageIncrement():base(){}
    
           /// <summary>
    /// Initializes a new instance of the ScrollBarPageIncrement class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public ScrollBarPageIncrement(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new IntegerValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ScrollBarPageIncrement>(deep);
    }

}
/// <summary>
/// <para>Scroll Bar Width.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:Dx.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ScrollBarWidth : OpenXmlLeafTextElement
{
    private const string tagName = "Dx";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12562;
    
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
    /// Initializes a new instance of the ScrollBarWidth class.
    /// </summary>
    public ScrollBarWidth():base(){}
    
           /// <summary>
    /// Initializes a new instance of the ScrollBarWidth class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public ScrollBarWidth(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new IntegerValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ScrollBarWidth>(deep);
    }

}
/// <summary>
/// <para>Clipboard Format.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:CF.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ClipboardFormat : OpenXmlLeafTextElement
{
    private const string tagName = "CF";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12564;
    
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
    /// Initializes a new instance of the ClipboardFormat class.
    /// </summary>
    public ClipboardFormat():base(){}
    
      
           /// <summary>
    /// Initializes a new instance of the ClipboardFormat class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public ClipboardFormat(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new EnumValue<DocumentFormat.OpenXml.Vml.Spreadsheet.ClipboardFormatValues>(){ InnerText = text };
    }
    
 
    
    
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ClipboardFormat>(deep);
    }

   
}
/// <summary>
/// <para>HTML Script Language.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:ScriptLanguage.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ScriptLanguage : OpenXmlLeafTextElement
{
    private const string tagName = "ScriptLanguage";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12572;
    
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
    /// Initializes a new instance of the ScriptLanguage class.
    /// </summary>
    public ScriptLanguage():base(){}
    
           /// <summary>
    /// Initializes a new instance of the ScriptLanguage class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public ScriptLanguage(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new IntegerValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ScriptLanguage>(deep);
    }

}
/// <summary>
/// <para>HTML Script Location.</para>
/// <para> When the object is serialized out as xml, its qualified name is xvml:ScriptLocation.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ScriptLocation : OpenXmlLeafTextElement
{
    private const string tagName = "ScriptLocation";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 29;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 12573;
    
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
    /// Initializes a new instance of the ScriptLocation class.
    /// </summary>
    public ScriptLocation():base(){}
    
           /// <summary>
    /// Initializes a new instance of the ScriptLocation class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public ScriptLocation(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		
		return new IntegerValue(){ InnerText = text };
    }
    

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ScriptLocation>(deep);
    }

}
/// <summary>
/// Clipboard Format Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ClipboardFormatValues
{  
	///<summary>
///WMF.
///<para>When the item is serialized out as xml, its value is "PictOld".</para>
///</summary>
[EnumString("PictOld")]
PictureOld,
///<summary>
///EMF.
///<para>When the item is serialized out as xml, its value is "Pict".</para>
///</summary>
[EnumString("Pict")]
Picture,
///<summary>
///Bitmap.
///<para>When the item is serialized out as xml, its value is "Bitmap".</para>
///</summary>
[EnumString("Bitmap")]
Bitmap,
///<summary>
///Printer Picture.
///<para>When the item is serialized out as xml, its value is "PictPrint".</para>
///</summary>
[EnumString("PictPrint")]
PicturePrint,
///<summary>
///Screen Picture EMF.
///<para>When the item is serialized out as xml, its value is "PictScreen".</para>
///</summary>
[EnumString("PictScreen")]
PictureScreen,
 
}
/// <summary>
/// Object Type 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ObjectValues
{  
	///<summary>
///Pushbutton.
///<para>When the item is serialized out as xml, its value is "Button".</para>
///</summary>
[EnumString("Button")]
Button,
///<summary>
///Checkbox.
///<para>When the item is serialized out as xml, its value is "Checkbox".</para>
///</summary>
[EnumString("Checkbox")]
Checkbox,
///<summary>
///Dialog.
///<para>When the item is serialized out as xml, its value is "Dialog".</para>
///</summary>
[EnumString("Dialog")]
Dialog,
///<summary>
///Dropdown Box.
///<para>When the item is serialized out as xml, its value is "Drop".</para>
///</summary>
[EnumString("Drop")]
Drop,
///<summary>
///Editable Text Field.
///<para>When the item is serialized out as xml, its value is "Edit".</para>
///</summary>
[EnumString("Edit")]
Edit,
///<summary>
///Group Box.
///<para>When the item is serialized out as xml, its value is "GBox".</para>
///</summary>
[EnumString("GBox")]
GroupBox,
///<summary>
///Label.
///<para>When the item is serialized out as xml, its value is "Label".</para>
///</summary>
[EnumString("Label")]
Label,
///<summary>
///Auditing Line.
///<para>When the item is serialized out as xml, its value is "LineA".</para>
///</summary>
[EnumString("LineA")]
AuditingLine,
///<summary>
///List Box.
///<para>When the item is serialized out as xml, its value is "List".</para>
///</summary>
[EnumString("List")]
List,
///<summary>
///Movie.
///<para>When the item is serialized out as xml, its value is "Movie".</para>
///</summary>
[EnumString("Movie")]
Movie,
///<summary>
///Comment.
///<para>When the item is serialized out as xml, its value is "Note".</para>
///</summary>
[EnumString("Note")]
Note,
///<summary>
///Image.
///<para>When the item is serialized out as xml, its value is "Pict".</para>
///</summary>
[EnumString("Pict")]
Picture,
///<summary>
///Radio Button.
///<para>When the item is serialized out as xml, its value is "Radio".</para>
///</summary>
[EnumString("Radio")]
Radio,
///<summary>
///Auditing Rectangle.
///<para>When the item is serialized out as xml, its value is "RectA".</para>
///</summary>
[EnumString("RectA")]
AuditingRectangle,
///<summary>
///Scroll Bar.
///<para>When the item is serialized out as xml, its value is "Scroll".</para>
///</summary>
[EnumString("Scroll")]
Scroll,
///<summary>
///Spin Button.
///<para>When the item is serialized out as xml, its value is "Spin".</para>
///</summary>
[EnumString("Spin")]
Spin,
///<summary>
///Plain Shape.
///<para>When the item is serialized out as xml, its value is "Shape".</para>
///</summary>
[EnumString("Shape")]
Shape,
///<summary>
///Group.
///<para>When the item is serialized out as xml, its value is "Group".</para>
///</summary>
[EnumString("Group")]
Group,
///<summary>
///Plain Rectangle.
///<para>When the item is serialized out as xml, its value is "Rect".</para>
///</summary>
[EnumString("Rect")]
Rectangle,
 
}
/// <summary>
/// Boolean Value with Blank State 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum BooleanEntryWithBlankValues
{  
	///<summary>
///Logical True.
///<para>When the item is serialized out as xml, its value is "True".</para>
///</summary>
[EnumString("True")]
True,
///<summary>
///Logical True.
///<para>When the item is serialized out as xml, its value is "t".</para>
///</summary>
[EnumString("t")]
T,
///<summary>
///Logical False.
///<para>When the item is serialized out as xml, its value is "False".</para>
///</summary>
[EnumString("False")]
False,
///<summary>
///Logical False.
///<para>When the item is serialized out as xml, its value is "f".</para>
///</summary>
[EnumString("f")]
F,
///<summary>
///Blank - Default Value.
///<para>When the item is serialized out as xml, its value is "".</para>
///</summary>
[EnumString("")]
Empty,
 
}
}
 
 
