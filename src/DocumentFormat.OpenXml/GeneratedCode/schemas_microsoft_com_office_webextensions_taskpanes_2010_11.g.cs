// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2013.WebExtension;

namespace DocumentFormat.OpenXml.Office2013.WebExtentionPane
{
/// <summary>
/// <para>Defines the Taskpanes Class. The root element of WebExTaskpanesPart.</para>
/// <para> When the object is serialized out as xml, its qualified name is wetp:taskpanes.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>WebExtensionTaskpane &lt;wetp:taskpane></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(WebExtensionTaskpane), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class Taskpanes : OpenXmlPartRootElement
{
    internal const int ElementTypeIdConst = 13352;
    /// <inheritdoc/>
    public override string LocalName => "taskpanes";
    
    internal override byte NamespaceId => 70;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    
    
    
    
	internal Taskpanes(WebExTaskpanesPart ownerPart) : base (ownerPart){}
    
    /// <summary>
    /// Loads the DOM from the WebExTaskpanesPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(WebExTaskpanesPart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the WebExTaskpanesPart associated with this element.
    /// </summary>
    public WebExTaskpanesPart WebExTaskpanesPart
    {
		get => OpenXmlPart as WebExTaskpanesPart;
		internal set => OpenXmlPart = value;
    }
    
        /// <summary>
    ///Initializes a new instance of the Taskpanes class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Taskpanes(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Taskpanes class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Taskpanes(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Taskpanes class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Taskpanes(string outerXml)
        : base(outerXml)
    {
    }

    
    
    /// <summary>
    /// Initializes a new instance of the Taskpanes class.
    /// </summary>
    public Taskpanes():base(){}
    
    /// <summary>
    /// Saves the DOM into the WebExTaskpanesPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(WebExTaskpanesPart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 70 == namespaceId && "taskpane" == name)
    return new WebExtensionTaskpane();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Taskpanes>(deep);

}
/// <summary>
/// <para>Defines the WebExtensionPartReference Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wetp:webextensionref.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class WebExtensionPartReference : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13353;
    /// <inheritdoc/>
    public override string LocalName => "webextensionref";
    
    internal override byte NamespaceId => 70;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

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
    /// Initializes a new instance of the WebExtensionPartReference class.
    /// </summary>
    public WebExtensionPartReference():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebExtensionPartReference>(deep);

}
/// <summary>
/// <para>Defines the OfficeArtExtensionList Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wetp:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Extension &lt;a:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Extension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class OfficeArtExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13354;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 70;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the OfficeArtExtensionList class.
    /// </summary>
    public OfficeArtExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the OfficeArtExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OfficeArtExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the OfficeArtExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OfficeArtExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the OfficeArtExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public OfficeArtExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "ext" == name)
    return new DocumentFormat.OpenXml.Drawing.Extension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<OfficeArtExtensionList>(deep);

}
/// <summary>
/// <para>Defines the WebExtensionTaskpane Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wetp:taskpane.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>WebExtensionPartReference &lt;wetp:webextensionref></description></item>
///<item><description>OfficeArtExtensionList &lt;wetp:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(WebExtensionPartReference), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(OfficeArtExtensionList), FileFormatVersions.Office2013)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class WebExtensionTaskpane : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13355;
    /// <inheritdoc/>
    public override string LocalName => "taskpane";
    
    internal override byte NamespaceId => 70;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "dockstate"),
		AttributeTag.Create<BooleanValue>(0, "visibility"),
		AttributeTag.Create<DoubleValue>(0, "width"),
		AttributeTag.Create<UInt32Value>(0, "row"),
		AttributeTag.Create<BooleanValue>(0, "locked")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> dockstate.</para>
    /// <para>Represents the following attribute in the schema: dockstate </para>
    /// </summary>
    [SchemaAttr(0, "dockstate")]
    public StringValue DockState
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> visibility.</para>
    /// <para>Represents the following attribute in the schema: visibility </para>
    /// </summary>
    [SchemaAttr(0, "visibility")]
    public BooleanValue Visibility
    {
        get { return (BooleanValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> width.</para>
    /// <para>Represents the following attribute in the schema: width </para>
    /// </summary>
    [SchemaAttr(0, "width")]
    public DoubleValue Width
    {
        get { return (DoubleValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> row.</para>
    /// <para>Represents the following attribute in the schema: row </para>
    /// </summary>
    [SchemaAttr(0, "row")]
    public UInt32Value Row
    {
        get { return (UInt32Value)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> locked.</para>
    /// <para>Represents the following attribute in the schema: locked </para>
    /// </summary>
    [SchemaAttr(0, "locked")]
    public BooleanValue Locked
    {
        get { return (BooleanValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the WebExtensionTaskpane class.
    /// </summary>
    public WebExtensionTaskpane():base(){}
    
        /// <summary>
    ///Initializes a new instance of the WebExtensionTaskpane class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WebExtensionTaskpane(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the WebExtensionTaskpane class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WebExtensionTaskpane(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the WebExtensionTaskpane class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public WebExtensionTaskpane(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 70 == namespaceId && "webextensionref" == name)
    return new WebExtensionPartReference();
    
if( 70 == namespaceId && "extLst" == name)
    return new OfficeArtExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "webextensionref","extLst" };
    private static readonly byte[] eleNamespaceIds = { 70,70 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> WebExtensionPartReference.</para>
    /// <para> Represents the following element tag in the schema: wetp:webextensionref </para>
    /// </summary>
    /// <remark>
    /// xmlns:wetp = http://schemas.microsoft.com/office/webextensions/taskpanes/2010/11
    /// </remark>
    public WebExtensionPartReference WebExtensionPartReference
    {
        get => GetElement<WebExtensionPartReference>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> OfficeArtExtensionList.</para>
    /// <para> Represents the following element tag in the schema: wetp:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:wetp = http://schemas.microsoft.com/office/webextensions/taskpanes/2010/11
    /// </remark>
    public OfficeArtExtensionList OfficeArtExtensionList
    {
        get => GetElement<OfficeArtExtensionList>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebExtensionTaskpane>(deep);

}
}
 
 
