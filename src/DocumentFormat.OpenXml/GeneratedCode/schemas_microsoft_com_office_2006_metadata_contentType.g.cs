// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Office.MetaAttributes;

namespace DocumentFormat.OpenXml.Office.ContentType
{
/// <summary>
/// <para>Defines the ContentTypeSchema Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is ct:contentTypeSchema.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
/// </list>
/// </remarks>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ContentTypeSchema : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12705;
    /// <inheritdoc/>
    public override string LocalName => "contentTypeSchema";
    
    internal override byte NamespaceId => 38;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(38, "_"),
		AttributeTag.Create<StringValue>(41, "_"),
		AttributeTag.Create<StringValue>(41, "contentTypeName"),
		AttributeTag.Create<StringValue>(41, "contentTypeID"),
		AttributeTag.Create<Int32Value>(41, "contentTypeVersion"),
		AttributeTag.Create<StringValue>(41, "contentTypeDescription"),
		AttributeTag.Create<StringValue>(41, "contentTypeScope"),
		AttributeTag.Create<StringValue>(41, "versionID")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> _.</para>
    /// <para>Represents the following attribute in the schema: ct:_ </para>
    /// </summary>
///<remark> xmlns:ct=http://schemas.microsoft.com/office/2006/metadata/contentType
///</remark>
    [SchemaAttr(38, "_")]
    public StringValue UnderScore
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> _.</para>
    /// <para>Represents the following attribute in the schema: ma:_ </para>
    /// </summary>
///<remark> xmlns:ma=http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes
///</remark>
    [SchemaAttr(41, "_")]
    public StringValue ReservedAttributeString
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> contentTypeName.</para>
    /// <para>Represents the following attribute in the schema: ma:contentTypeName </para>
    /// </summary>
///<remark> xmlns:ma=http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes
///</remark>
    [SchemaAttr(41, "contentTypeName")]
    public StringValue ContentTypeName
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> contentTypeID.</para>
    /// <para>Represents the following attribute in the schema: ma:contentTypeID </para>
    /// </summary>
///<remark> xmlns:ma=http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes
///</remark>
    [SchemaAttr(41, "contentTypeID")]
    public StringValue ContentTypeID
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> contentTypeVersion.</para>
    /// <para>Represents the following attribute in the schema: ma:contentTypeVersion </para>
    /// </summary>
///<remark> xmlns:ma=http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes
///</remark>
    [SchemaAttr(41, "contentTypeVersion")]
    public Int32Value ContentTypeVersion
    {
        get { return (Int32Value)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> contentTypeDescription.</para>
    /// <para>Represents the following attribute in the schema: ma:contentTypeDescription </para>
    /// </summary>
///<remark> xmlns:ma=http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes
///</remark>
    [SchemaAttr(41, "contentTypeDescription")]
    public StringValue ContentTypeDescription
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> contentTypeScope.</para>
    /// <para>Represents the following attribute in the schema: ma:contentTypeScope </para>
    /// </summary>
///<remark> xmlns:ma=http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes
///</remark>
    [SchemaAttr(41, "contentTypeScope")]
    public StringValue ContentTypeScope
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> versionID.</para>
    /// <para>Represents the following attribute in the schema: ma:versionID </para>
    /// </summary>
///<remark> xmlns:ma=http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes
///</remark>
    [SchemaAttr(41, "versionID")]
    public StringValue VersionID
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ContentTypeSchema class.
    /// </summary>
    public ContentTypeSchema():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ContentTypeSchema class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ContentTypeSchema(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ContentTypeSchema class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ContentTypeSchema(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ContentTypeSchema class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ContentTypeSchema(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    
    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContentTypeSchema>(deep);

}
}
 
 
