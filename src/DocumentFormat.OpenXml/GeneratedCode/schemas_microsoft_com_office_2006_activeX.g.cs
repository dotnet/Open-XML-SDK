// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.Office.ActiveX
{
/// <summary>
/// <para>Defines the ActiveXControlData Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ax:ocx.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ActiveXObjectProperty &lt;ax:ocxPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ActiveXObjectProperty))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(35, "ocx")]
[Id(ElementTypeIdConst)]
public partial class ActiveXControlData : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12688;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> classid.</para>
    /// <para>Represents the following attribute in the schema: ax:classid </para>
    /// </summary>
///<remark> xmlns:ax=http://schemas.microsoft.com/office/2006/activeX
///</remark>
    [SchemaAttr(35, "classid")]
    [Index(0)]
    public StringValue ActiveXControlClassId { get; set; }
	
    /// <summary>
    /// <para> license.</para>
    /// <para>Represents the following attribute in the schema: ax:license </para>
    /// </summary>
///<remark> xmlns:ax=http://schemas.microsoft.com/office/2006/activeX
///</remark>
    [SchemaAttr(35, "license")]
    [Index(1)]
    public StringValue License { get; set; }
	
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
    [Index(2)]
    public StringValue Id { get; set; }
	
    /// <summary>
    /// <para> persistence.</para>
    /// <para>Represents the following attribute in the schema: ax:persistence </para>
    /// </summary>
///<remark> xmlns:ax=http://schemas.microsoft.com/office/2006/activeX
///</remark>
    [SchemaAttr(35, "persistence")]
    [Index(3)]
    public EnumValue<DocumentFormat.OpenXml.Office.ActiveX.PersistenceValues> Persistence { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the ActiveXControlData class.
    /// </summary>
    public ActiveXControlData():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ActiveXControlData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ActiveXControlData(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ActiveXControlData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ActiveXControlData(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ActiveXControlData class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ActiveXControlData(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ActiveXControlData>(deep);

}
/// <summary>
/// <para>Defines the ActiveXObjectProperty Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ax:ocxPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SharedComFont &lt;ax:font></description></item>
///<item><description>SharedComPicture &lt;ax:picture></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SharedComFont))]
    [ChildElementInfo(typeof(SharedComPicture))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(35, "ocxPr")]
[Id(ElementTypeIdConst)]
public partial class ActiveXObjectProperty : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12689;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: ax:name </para>
    /// </summary>
///<remark> xmlns:ax=http://schemas.microsoft.com/office/2006/activeX
///</remark>
    [SchemaAttr(35, "name")]
    [Index(0)]
    public StringValue Name { get; set; }
	
    /// <summary>
    /// <para> value.</para>
    /// <para>Represents the following attribute in the schema: ax:value </para>
    /// </summary>
///<remark> xmlns:ax=http://schemas.microsoft.com/office/2006/activeX
///</remark>
    [SchemaAttr(35, "value")]
    [Index(1)]
    public StringValue Value { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the ActiveXObjectProperty class.
    /// </summary>
    public ActiveXObjectProperty():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ActiveXObjectProperty class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ActiveXObjectProperty(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ActiveXObjectProperty class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ActiveXObjectProperty(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ActiveXObjectProperty class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ActiveXObjectProperty(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    
        /// <summary>
    /// <para> SharedComFont.</para>
    /// <para> Represents the following element tag in the schema: ax:font </para>
    /// </summary>
    /// <remark>
    /// xmlns:ax = http://schemas.microsoft.com/office/2006/activeX
    /// </remark>
	[Index(0)]
    public SharedComFont SharedComFont
	{
        get => GetElement<SharedComFont>(0);
        set => SetElement(0, value);
	}
    
    /// <summary>
    /// <para> SharedComPicture.</para>
    /// <para> Represents the following element tag in the schema: ax:picture </para>
    /// </summary>
    /// <remark>
    /// xmlns:ax = http://schemas.microsoft.com/office/2006/activeX
    /// </remark>
	[Index(1)]
    public SharedComPicture SharedComPicture
	{
        get => GetElement<SharedComPicture>(1);
        set => SetElement(1, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ActiveXObjectProperty>(deep);

}
/// <summary>
/// <para>Defines the SharedComFont Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ax:font.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ActiveXObjectProperty &lt;ax:ocxPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ActiveXObjectProperty))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(35, "font")]
[Id(ElementTypeIdConst)]
public partial class SharedComFont : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12690;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> persistence.</para>
    /// <para>Represents the following attribute in the schema: ax:persistence </para>
    /// </summary>
///<remark> xmlns:ax=http://schemas.microsoft.com/office/2006/activeX
///</remark>
    [SchemaAttr(35, "persistence")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Office.ActiveX.PersistenceValues> Persistence { get; set; }
	
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
    [Index(1)]
    public StringValue Id { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the SharedComFont class.
    /// </summary>
    public SharedComFont():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SharedComFont class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SharedComFont(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SharedComFont class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SharedComFont(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SharedComFont class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SharedComFont(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SharedComFont>(deep);

}
/// <summary>
/// <para>Defines the SharedComPicture Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ax:picture.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(35, "picture")]
[Id(ElementTypeIdConst)]
public partial class SharedComPicture : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12691;
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
    /// Initializes a new instance of the SharedComPicture class.
    /// </summary>
    public SharedComPicture():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SharedComPicture>(deep);

}
/// <summary>
/// Defines the PersistenceValues enumeration. 
/// </summary> 
public enum PersistenceValues
{  
	///<summary>
///persistPropertyBag.
///<para>When the item is serialized out as xml, its value is "persistPropertyBag".</para>
///</summary>
[EnumString("persistPropertyBag")]
PersistPropertyBag,
///<summary>
///persistStream.
///<para>When the item is serialized out as xml, its value is "persistStream".</para>
///</summary>
[EnumString("persistStream")]
PersistStream,
///<summary>
///persistStreamInit.
///<para>When the item is serialized out as xml, its value is "persistStreamInit".</para>
///</summary>
[EnumString("persistStreamInit")]
PersistStreamInit,
///<summary>
///persistStorage.
///<para>When the item is serialized out as xml, its value is "persistStorage".</para>
///</summary>
[EnumString("persistStorage")]
PersistStorage,
 
}
}
 
 
