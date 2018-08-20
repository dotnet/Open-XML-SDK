// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.CustomXmlSchemaReferences
{
/// <summary>
/// <para>Embedded Custom XML Schema Supplementary Data.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is sl:schemaLibrary.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Schema &lt;sl:schema></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Schema))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SchemaLibrary : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12468;
    /// <inheritdoc/>
    public override string LocalName => "schemaLibrary";
    
    internal override byte NamespaceId => 25;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the SchemaLibrary class.
    /// </summary>
    public SchemaLibrary():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SchemaLibrary class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SchemaLibrary(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SchemaLibrary class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SchemaLibrary(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SchemaLibrary class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SchemaLibrary(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 25 == namespaceId && "schema" == name)
    return new Schema();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SchemaLibrary>(deep);

}
/// <summary>
/// <para>Custom XML Schema Reference.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is sl:schema.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Schema : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12469;
    /// <inheritdoc/>
    public override string LocalName => "schema";
    
    internal override byte NamespaceId => 25;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(25, "uri"),
		AttributeTag.Create<StringValue>(25, "manifestLocation"),
		AttributeTag.Create<StringValue>(25, "schemaLocation")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Custom XML Schema Namespace.</para>
    /// <para>Represents the following attribute in the schema: sl:uri </para>
    /// </summary>
///<remark> xmlns:sl=http://schemas.openxmlformats.org/schemaLibrary/2006/main
///</remark>
    [SchemaAttr(25, "uri")]
    public StringValue Uri
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Resource File Location.</para>
    /// <para>Represents the following attribute in the schema: sl:manifestLocation </para>
    /// </summary>
///<remark> xmlns:sl=http://schemas.openxmlformats.org/schemaLibrary/2006/main
///</remark>
    [SchemaAttr(25, "manifestLocation")]
    public StringValue ManifestLocation
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Custom XML Schema Location.</para>
    /// <para>Represents the following attribute in the schema: sl:schemaLocation </para>
    /// </summary>
///<remark> xmlns:sl=http://schemas.openxmlformats.org/schemaLibrary/2006/main
///</remark>
    [SchemaAttr(25, "schemaLocation")]
    public StringValue SchemaLocation
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Schema class.
    /// </summary>
    public Schema():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Schema>(deep);

}
}
 
 
