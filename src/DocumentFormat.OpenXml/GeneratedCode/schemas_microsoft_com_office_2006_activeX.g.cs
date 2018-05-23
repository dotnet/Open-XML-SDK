// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ActiveXControlData : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12688;
    /// <inheritdoc/>
    public override string LocalName => "ocx";
    
    internal override byte NamespaceId => 35;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(35, "classid"),
		AttributeTag.Create<StringValue>(35, "license"),
		AttributeTag.Create<StringValue>(19, "id"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office.ActiveX.PersistenceValues>>(35, "persistence")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> classid.</para>
    /// <para>Represents the following attribute in the schema: ax:classid </para>
    /// </summary>
///<remark> xmlns:ax=http://schemas.microsoft.com/office/2006/activeX
///</remark>
    [SchemaAttr(35, "classid")]
    public StringValue ActiveXControlClassId
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> license.</para>
    /// <para>Represents the following attribute in the schema: ax:license </para>
    /// </summary>
///<remark> xmlns:ax=http://schemas.microsoft.com/office/2006/activeX
///</remark>
    [SchemaAttr(35, "license")]
    public StringValue License
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
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
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> persistence.</para>
    /// <para>Represents the following attribute in the schema: ax:persistence </para>
    /// </summary>
///<remark> xmlns:ax=http://schemas.microsoft.com/office/2006/activeX
///</remark>
    [SchemaAttr(35, "persistence")]
    public EnumValue<DocumentFormat.OpenXml.Office.ActiveX.PersistenceValues> Persistence
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office.ActiveX.PersistenceValues>)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 35 == namespaceId && "ocxPr" == name)
    return new ActiveXObjectProperty();
    

    return null;
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ActiveXObjectProperty : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12689;
    /// <inheritdoc/>
    public override string LocalName => "ocxPr";
    
    internal override byte NamespaceId => 35;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(35, "name"),
		AttributeTag.Create<StringValue>(35, "value")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: ax:name </para>
    /// </summary>
///<remark> xmlns:ax=http://schemas.microsoft.com/office/2006/activeX
///</remark>
    [SchemaAttr(35, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> value.</para>
    /// <para>Represents the following attribute in the schema: ax:value </para>
    /// </summary>
///<remark> xmlns:ax=http://schemas.microsoft.com/office/2006/activeX
///</remark>
    [SchemaAttr(35, "value")]
    public StringValue Value
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 35 == namespaceId && "font" == name)
    return new SharedComFont();
    
if( 35 == namespaceId && "picture" == name)
    return new SharedComPicture();
    

    return null;
}

        private static readonly string[] eleTagNames = { "font","picture" };
    private static readonly byte[] eleNamespaceIds = { 35,35 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    
        /// <summary>
    /// <para> SharedComFont.</para>
    /// <para> Represents the following element tag in the schema: ax:font </para>
    /// </summary>
    /// <remark>
    /// xmlns:ax = http://schemas.microsoft.com/office/2006/activeX
    /// </remark>
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SharedComFont : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12690;
    /// <inheritdoc/>
    public override string LocalName => "font";
    
    internal override byte NamespaceId => 35;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office.ActiveX.PersistenceValues>>(35, "persistence"),
		AttributeTag.Create<StringValue>(19, "id")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> persistence.</para>
    /// <para>Represents the following attribute in the schema: ax:persistence </para>
    /// </summary>
///<remark> xmlns:ax=http://schemas.microsoft.com/office/2006/activeX
///</remark>
    [SchemaAttr(35, "persistence")]
    public EnumValue<DocumentFormat.OpenXml.Office.ActiveX.PersistenceValues> Persistence
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office.ActiveX.PersistenceValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
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
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 35 == namespaceId && "ocxPr" == name)
    return new ActiveXObjectProperty();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SharedComFont>(deep);

}
/// <summary>
/// <para>Defines the SharedComPicture Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ax:picture.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SharedComPicture : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12691;
    /// <inheritdoc/>
    public override string LocalName => "picture";
    
    internal override byte NamespaceId => 35;
    
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
    /// Initializes a new instance of the SharedComPicture class.
    /// </summary>
    public SharedComPicture():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SharedComPicture>(deep);

}
/// <summary>
/// Defines the PersistenceValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
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
 
 
