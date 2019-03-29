// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.CustomXmlDataProperties
{
/// <summary>
/// <para>Custom XML Data Properties. The root element of CustomXmlPropertiesPart.</para>
/// <para> When the object is serialized out as xml, its qualified name is ds:datastoreItem.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SchemaReferences &lt;ds:schemaRefs></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SchemaReferences))]

[SchemaAttr(20, "datastoreItem")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DataStoreItem : OpenXmlPartRootElement
{
    internal const int ElementTypeIdConst = 10900;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Custom XML Data ID.</para>
    /// <para>Represents the following attribute in the schema: ds:itemID </para>
    /// </summary>
///<remark> xmlns:ds=http://schemas.openxmlformats.org/officeDocument/2006/customXml
///</remark>
    [SchemaAttr(20, "itemID")]
    [Index(0)]
    public StringValue ItemId { get; set; }
	

    
	internal DataStoreItem(CustomXmlPropertiesPart ownerPart) : base (ownerPart){}
    
    /// <summary>
    /// Loads the DOM from the CustomXmlPropertiesPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(CustomXmlPropertiesPart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the CustomXmlPropertiesPart associated with this element.
    /// </summary>
    public CustomXmlPropertiesPart CustomXmlPropertiesPart
    {
		get => OpenXmlPart as CustomXmlPropertiesPart;
		internal set => OpenXmlPart = value;
    }
    
        /// <summary>
    ///Initializes a new instance of the DataStoreItem class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataStoreItem(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataStoreItem class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataStoreItem(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataStoreItem class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataStoreItem(string outerXml)
        : base(outerXml)
    {
    }
    

    
    
    /// <summary>
    /// Initializes a new instance of the DataStoreItem class.
    /// </summary>
    public DataStoreItem():base(){}
    
    /// <summary>
    /// Saves the DOM into the CustomXmlPropertiesPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(CustomXmlPropertiesPart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Set of Associated XML Schemas.</para>
    /// <para> Represents the following element tag in the schema: ds:schemaRefs </para>
    /// </summary>
    /// <remark>
    /// xmlns:ds = http://schemas.openxmlformats.org/officeDocument/2006/customXml
    /// </remark>
	[Index(0)]
    public SchemaReferences SchemaReferences
	{
        get => GetElement<SchemaReferences>(0);
        set => SetElement(0, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataStoreItem>(deep);

}
/// <summary>
/// <para>Associated XML Schema.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ds:schemaRef.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(20, "schemaRef")]
[Id(ElementTypeIdConst)]
public partial class SchemaReference : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10901;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Target Namespace of Associated XML Schema.</para>
    /// <para>Represents the following attribute in the schema: ds:uri </para>
    /// </summary>
///<remark> xmlns:ds=http://schemas.openxmlformats.org/officeDocument/2006/customXml
///</remark>
    [SchemaAttr(20, "uri")]
    [Index(0)]
    public StringValue Uri { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the SchemaReference class.
    /// </summary>
    public SchemaReference():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SchemaReference>(deep);

}
/// <summary>
/// <para>Set of Associated XML Schemas.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ds:schemaRefs.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SchemaReference &lt;ds:schemaRef></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SchemaReference))]

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(20, "schemaRefs")]
[Id(ElementTypeIdConst)]
public partial class SchemaReferences : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10902;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the SchemaReferences class.
    /// </summary>
    public SchemaReferences():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SchemaReferences class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SchemaReferences(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SchemaReferences class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SchemaReferences(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SchemaReferences class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SchemaReferences(string outerXml)
        : base(outerXml)
    {
    }
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SchemaReferences>(deep);

}
}
 
 
