// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;

namespace DocumentFormat.OpenXml.Office2013.WebExtension
{
/// <summary>
/// <para>Defines the WebExtension Class. The root element of WebExtensionPart.</para>
/// <para> When the object is serialized out as xml, its qualified name is we:webextension.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>WebExtensionStoreReference &lt;we:reference></description></item>
///<item><description>WebExtensionReferenceList &lt;we:alternateReferences></description></item>
///<item><description>WebExtensionPropertyBag &lt;we:properties></description></item>
///<item><description>WebExtensionBindingList &lt;we:bindings></description></item>
///<item><description>Snapshot &lt;we:snapshot></description></item>
///<item><description>OfficeArtExtensionList &lt;we:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(WebExtensionStoreReference), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(WebExtensionReferenceList), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(WebExtensionPropertyBag), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(WebExtensionBindingList), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(Snapshot), FileFormatVersions.Office2013)]
    [ChildElementInfo(typeof(OfficeArtExtensionList), FileFormatVersions.Office2013)]

[SchemaAttr(66, "webextension")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class WebExtension : OpenXmlPartRootElement
{
    internal const int ElementTypeIdConst = 13310;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
	
    /// <summary>
    /// <para> frozen.</para>
    /// <para>Represents the following attribute in the schema: frozen </para>
    /// </summary>
    [SchemaAttr(0, "frozen")]
    [Index(1)]
    public BooleanValue Frozen { get; set; }
	

    
	internal WebExtension(WebExtensionPart ownerPart) : base (ownerPart){}
    
    /// <summary>
    /// Loads the DOM from the WebExtensionPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(WebExtensionPart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the WebExtensionPart associated with this element.
    /// </summary>
    public WebExtensionPart WebExtensionPart
    {
		get => OpenXmlPart as WebExtensionPart;
		internal set => OpenXmlPart = value;
    }
    
        /// <summary>
    ///Initializes a new instance of the WebExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WebExtension(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the WebExtension class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WebExtension(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the WebExtension class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public WebExtension(string outerXml)
        : base(outerXml)
    {
    }
    

    
    
    /// <summary>
    /// Initializes a new instance of the WebExtension class.
    /// </summary>
    public WebExtension():base(){}
    
    /// <summary>
    /// Saves the DOM into the WebExtensionPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(WebExtensionPart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> WebExtensionStoreReference.</para>
    /// <para> Represents the following element tag in the schema: we:reference </para>
    /// </summary>
    /// <remark>
    /// xmlns:we = http://schemas.microsoft.com/office/webextensions/webextension/2010/11
    /// </remark>
	[Index(0)]
    public WebExtensionStoreReference WebExtensionStoreReference
	{
        get => GetElement<WebExtensionStoreReference>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> WebExtensionReferenceList.</para>
    /// <para> Represents the following element tag in the schema: we:alternateReferences </para>
    /// </summary>
    /// <remark>
    /// xmlns:we = http://schemas.microsoft.com/office/webextensions/webextension/2010/11
    /// </remark>
	[Index(1)]
    public WebExtensionReferenceList WebExtensionReferenceList
	{
        get => GetElement<WebExtensionReferenceList>(1);
        set => SetElement(1, value);
	}
    
    /// <summary>
    /// <para> WebExtensionPropertyBag.</para>
    /// <para> Represents the following element tag in the schema: we:properties </para>
    /// </summary>
    /// <remark>
    /// xmlns:we = http://schemas.microsoft.com/office/webextensions/webextension/2010/11
    /// </remark>
	[Index(2)]
    public WebExtensionPropertyBag WebExtensionPropertyBag
	{
        get => GetElement<WebExtensionPropertyBag>(2);
        set => SetElement(2, value);
	}
    
    /// <summary>
    /// <para> WebExtensionBindingList.</para>
    /// <para> Represents the following element tag in the schema: we:bindings </para>
    /// </summary>
    /// <remark>
    /// xmlns:we = http://schemas.microsoft.com/office/webextensions/webextension/2010/11
    /// </remark>
	[Index(3)]
    public WebExtensionBindingList WebExtensionBindingList
	{
        get => GetElement<WebExtensionBindingList>(3);
        set => SetElement(3, value);
	}
    
    /// <summary>
    /// <para> Snapshot.</para>
    /// <para> Represents the following element tag in the schema: we:snapshot </para>
    /// </summary>
    /// <remark>
    /// xmlns:we = http://schemas.microsoft.com/office/webextensions/webextension/2010/11
    /// </remark>
	[Index(4)]
    public Snapshot Snapshot
	{
        get => GetElement<Snapshot>(4);
        set => SetElement(4, value);
	}
    
    /// <summary>
    /// <para> OfficeArtExtensionList.</para>
    /// <para> Represents the following element tag in the schema: we:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:we = http://schemas.microsoft.com/office/webextensions/webextension/2010/11
    /// </remark>
	[Index(5)]
    public OfficeArtExtensionList OfficeArtExtensionList
	{
        get => GetElement<OfficeArtExtensionList>(5);
        set => SetElement(5, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebExtension>(deep);

}
/// <summary>
/// <para>Defines the WebExtensionReference Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is we:webextensionref.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(66, "webextensionref")]
[Id(ElementTypeIdConst)]
public partial class WebExtensionReference : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13311;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the WebExtensionReference class.
    /// </summary>
    public WebExtensionReference():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebExtensionReference>(deep);

}
/// <summary>
/// <para>Defines the WebExtensionProperty Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is we:property.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(66, "property")]
[Id(ElementTypeIdConst)]
public partial class WebExtensionProperty : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13312;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    [Index(0)]
    public StringValue Name { get; set; }
	
    /// <summary>
    /// <para> value.</para>
    /// <para>Represents the following attribute in the schema: value </para>
    /// </summary>
    [SchemaAttr(0, "value")]
    [Index(1)]
    public StringValue Value { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the WebExtensionProperty class.
    /// </summary>
    public WebExtensionProperty():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebExtensionProperty>(deep);

}
/// <summary>
/// <para>Defines the OfficeArtExtensionList Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is we:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Extension &lt;a:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Extension))]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(66, "extLst")]
[Id(ElementTypeIdConst)]
public partial class OfficeArtExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13313;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<OfficeArtExtensionList>(deep);

}
/// <summary>
/// <para>Defines the WebExtensionBinding Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is we:binding.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>OfficeArtExtensionList &lt;we:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(OfficeArtExtensionList), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(66, "binding")]
[Id(ElementTypeIdConst)]
public partial class WebExtensionBinding : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13314;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
	
    /// <summary>
    /// <para> type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    [Index(1)]
    public StringValue Type { get; set; }
	
    /// <summary>
    /// <para> appref.</para>
    /// <para>Represents the following attribute in the schema: appref </para>
    /// </summary>
    [SchemaAttr(0, "appref")]
    [Index(2)]
    public StringValue AppReference { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the WebExtensionBinding class.
    /// </summary>
    public WebExtensionBinding():base(){}
    
        /// <summary>
    ///Initializes a new instance of the WebExtensionBinding class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WebExtensionBinding(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the WebExtensionBinding class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WebExtensionBinding(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the WebExtensionBinding class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public WebExtensionBinding(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> OfficeArtExtensionList.</para>
    /// <para> Represents the following element tag in the schema: we:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:we = http://schemas.microsoft.com/office/webextensions/webextension/2010/11
    /// </remark>
	[Index(0)]
    public OfficeArtExtensionList OfficeArtExtensionList
	{
        get => GetElement<OfficeArtExtensionList>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebExtensionBinding>(deep);

}
/// <summary>
/// <para>Defines the WebExtensionStoreReference Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is we:reference.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>OfficeArtExtensionList &lt;we:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(OfficeArtExtensionList), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(66, "reference")]
[Id(ElementTypeIdConst)]
public partial class WebExtensionStoreReference : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13315;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
	
    /// <summary>
    /// <para> version.</para>
    /// <para>Represents the following attribute in the schema: version </para>
    /// </summary>
    [SchemaAttr(0, "version")]
    [Index(1)]
    public StringValue Version { get; set; }
	
    /// <summary>
    /// <para> store.</para>
    /// <para>Represents the following attribute in the schema: store </para>
    /// </summary>
    [SchemaAttr(0, "store")]
    [Index(2)]
    public StringValue Store { get; set; }
	
    /// <summary>
    /// <para> storeType.</para>
    /// <para>Represents the following attribute in the schema: storeType </para>
    /// </summary>
    [SchemaAttr(0, "storeType")]
    [Index(3)]
    public StringValue StoreType { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the WebExtensionStoreReference class.
    /// </summary>
    public WebExtensionStoreReference():base(){}
    
        /// <summary>
    ///Initializes a new instance of the WebExtensionStoreReference class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WebExtensionStoreReference(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the WebExtensionStoreReference class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WebExtensionStoreReference(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the WebExtensionStoreReference class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public WebExtensionStoreReference(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> OfficeArtExtensionList.</para>
    /// <para> Represents the following element tag in the schema: we:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:we = http://schemas.microsoft.com/office/webextensions/webextension/2010/11
    /// </remark>
	[Index(0)]
    public OfficeArtExtensionList OfficeArtExtensionList
	{
        get => GetElement<OfficeArtExtensionList>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebExtensionStoreReference>(deep);

}
/// <summary>
/// <para>Defines the WebExtensionReferenceList Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is we:alternateReferences.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>WebExtensionStoreReference &lt;we:reference></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(WebExtensionStoreReference), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(66, "alternateReferences")]
[Id(ElementTypeIdConst)]
public partial class WebExtensionReferenceList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13316;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the WebExtensionReferenceList class.
    /// </summary>
    public WebExtensionReferenceList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the WebExtensionReferenceList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WebExtensionReferenceList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the WebExtensionReferenceList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WebExtensionReferenceList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the WebExtensionReferenceList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public WebExtensionReferenceList(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebExtensionReferenceList>(deep);

}
/// <summary>
/// <para>Defines the WebExtensionPropertyBag Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is we:properties.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>WebExtensionProperty &lt;we:property></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(WebExtensionProperty), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(66, "properties")]
[Id(ElementTypeIdConst)]
public partial class WebExtensionPropertyBag : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13317;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the WebExtensionPropertyBag class.
    /// </summary>
    public WebExtensionPropertyBag():base(){}
    
        /// <summary>
    ///Initializes a new instance of the WebExtensionPropertyBag class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WebExtensionPropertyBag(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the WebExtensionPropertyBag class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WebExtensionPropertyBag(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the WebExtensionPropertyBag class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public WebExtensionPropertyBag(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebExtensionPropertyBag>(deep);

}
/// <summary>
/// <para>Defines the WebExtensionBindingList Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is we:bindings.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>WebExtensionBinding &lt;we:binding></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(WebExtensionBinding), FileFormatVersions.Office2013)]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(66, "bindings")]
[Id(ElementTypeIdConst)]
public partial class WebExtensionBindingList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13318;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the WebExtensionBindingList class.
    /// </summary>
    public WebExtensionBindingList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the WebExtensionBindingList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WebExtensionBindingList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the WebExtensionBindingList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WebExtensionBindingList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the WebExtensionBindingList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public WebExtensionBindingList(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebExtensionBindingList>(deep);

}
/// <summary>
/// <para>Defines the Snapshot Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is we:snapshot.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.AlphaBiLevel &lt;a:alphaBiLevel></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.AlphaCeiling &lt;a:alphaCeiling></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.AlphaFloor &lt;a:alphaFloor></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.AlphaInverse &lt;a:alphaInv></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.AlphaModulationEffect &lt;a:alphaMod></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.AlphaModulationFixed &lt;a:alphaModFix></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.AlphaReplace &lt;a:alphaRepl></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.BiLevel &lt;a:biLevel></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Blur &lt;a:blur></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.ColorChange &lt;a:clrChange></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.ColorReplacement &lt;a:clrRepl></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Duotone &lt;a:duotone></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.FillOverlay &lt;a:fillOverlay></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Grayscale &lt;a:grayscl></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Hsl &lt;a:hsl></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.LuminanceEffect &lt;a:lum></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.TintEffect &lt;a:tint></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.BlipExtensionList &lt;a:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.AlphaBiLevel))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.AlphaCeiling))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.AlphaFloor))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.AlphaInverse))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.AlphaModulationEffect))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.AlphaModulationFixed))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.AlphaReplace))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BiLevel))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Blur))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ColorChange))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ColorReplacement))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Duotone))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.FillOverlay))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Grayscale))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Hsl))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.LuminanceEffect))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.TintEffect))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BlipExtensionList))]

[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(66, "snapshot")]
[Id(ElementTypeIdConst)]
public partial class Snapshot : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13319;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Embedded Picture Reference.</para>
    /// <para>Represents the following attribute in the schema: r:embed </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "embed")]
    [Index(0)]
    public StringValue Embed { get; set; }
	
    /// <summary>
    /// <para> Linked Picture Reference.</para>
    /// <para>Represents the following attribute in the schema: r:link </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "link")]
    [Index(1)]
    public StringValue Link { get; set; }
	
    /// <summary>
    /// <para> cstate.</para>
    /// <para>Represents the following attribute in the schema: cstate </para>
    /// </summary>
    [SchemaAttr(0, "cstate")]
    [Index(2)]
    public EnumValue<DocumentFormat.OpenXml.Drawing.BlipCompressionValues> CompressionState { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the Snapshot class.
    /// </summary>
    public Snapshot():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Snapshot class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Snapshot(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Snapshot class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Snapshot(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Snapshot class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Snapshot(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Snapshot>(deep);

}
}
 
 
