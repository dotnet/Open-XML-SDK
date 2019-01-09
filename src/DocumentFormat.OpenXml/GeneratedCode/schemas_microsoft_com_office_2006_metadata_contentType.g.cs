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

    
        /// <summary>
    /// <para> _.</para>
    /// <para>Represents the following attribute in the schema: ct:_ </para>
    /// </summary>
///<remark> xmlns:ct=http://schemas.microsoft.com/office/2006/metadata/contentType
///</remark>
    [SchemaAttr(38, "_")]
	[SchemaIndex(0)]
    public StringValue UnderScore { get; set;}
    /// <summary>
    /// <para> _.</para>
    /// <para>Represents the following attribute in the schema: ma:_ </para>
    /// </summary>
///<remark> xmlns:ma=http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes
///</remark>
    [SchemaAttr(41, "_")]
	[SchemaIndex(1)]
    public StringValue ReservedAttributeString { get; set;}
    /// <summary>
    /// <para> contentTypeName.</para>
    /// <para>Represents the following attribute in the schema: ma:contentTypeName </para>
    /// </summary>
///<remark> xmlns:ma=http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes
///</remark>
    [SchemaAttr(41, "contentTypeName")]
	[SchemaIndex(2)]
    public StringValue ContentTypeName { get; set;}
    /// <summary>
    /// <para> contentTypeID.</para>
    /// <para>Represents the following attribute in the schema: ma:contentTypeID </para>
    /// </summary>
///<remark> xmlns:ma=http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes
///</remark>
    [SchemaAttr(41, "contentTypeID")]
	[SchemaIndex(3)]
    public StringValue ContentTypeID { get; set;}
    /// <summary>
    /// <para> contentTypeVersion.</para>
    /// <para>Represents the following attribute in the schema: ma:contentTypeVersion </para>
    /// </summary>
///<remark> xmlns:ma=http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes
///</remark>
    [SchemaAttr(41, "contentTypeVersion")]
	[SchemaIndex(4)]
    public Int32Value ContentTypeVersion { get; set;}
    /// <summary>
    /// <para> contentTypeDescription.</para>
    /// <para>Represents the following attribute in the schema: ma:contentTypeDescription </para>
    /// </summary>
///<remark> xmlns:ma=http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes
///</remark>
    [SchemaAttr(41, "contentTypeDescription")]
	[SchemaIndex(5)]
    public StringValue ContentTypeDescription { get; set;}
    /// <summary>
    /// <para> contentTypeScope.</para>
    /// <para>Represents the following attribute in the schema: ma:contentTypeScope </para>
    /// </summary>
///<remark> xmlns:ma=http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes
///</remark>
    [SchemaAttr(41, "contentTypeScope")]
	[SchemaIndex(6)]
    public StringValue ContentTypeScope { get; set;}
    /// <summary>
    /// <para> versionID.</para>
    /// <para>Represents the following attribute in the schema: ma:versionID </para>
    /// </summary>
///<remark> xmlns:ma=http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes
///</remark>
    [SchemaAttr(41, "versionID")]
	[SchemaIndex(7)]
    public StringValue VersionID { get; set;}

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
