// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(SchemaReferences))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DataStoreItem : OpenXmlPartRootElement
{
    internal const int ElementTypeIdConst = 10900;
    /// <inheritdoc/>
    public override string LocalName => "datastoreItem";
    
    internal override byte NamespaceId => 20;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(20, "itemID")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Custom XML Data ID.</para>
    /// <para>Represents the following attribute in the schema: ds:itemID </para>
    /// </summary>
///<remark> xmlns:ds=http://schemas.openxmlformats.org/officeDocument/2006/customXml
///</remark>
    [SchemaAttr(20, "itemID")]
    public StringValue ItemId
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    
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
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 20 == namespaceId && "schemaRefs" == name)
    return new SchemaReferences();
    

    return null;
}

        private static readonly string[] eleTagNames = { "schemaRefs" };
    private static readonly byte[] eleNamespaceIds = { 20 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Set of Associated XML Schemas.</para>
    /// <para> Represents the following element tag in the schema: ds:schemaRefs </para>
    /// </summary>
    /// <remark>
    /// xmlns:ds = http://schemas.openxmlformats.org/officeDocument/2006/customXml
    /// </remark>
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

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SchemaReference : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10901;
    /// <inheritdoc/>
    public override string LocalName => "schemaRef";
    
    internal override byte NamespaceId => 20;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(20, "uri")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Target Namespace of Associated XML Schema.</para>
    /// <para>Represents the following attribute in the schema: ds:uri </para>
    /// </summary>
///<remark> xmlns:ds=http://schemas.openxmlformats.org/officeDocument/2006/customXml
///</remark>
    [SchemaAttr(20, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SchemaReferences : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10902;
    /// <inheritdoc/>
    public override string LocalName => "schemaRefs";
    
    internal override byte NamespaceId => 20;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
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
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 20 == namespaceId && "schemaRef" == name)
    return new SchemaReference();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SchemaReferences>(deep);

}
}
 
 
