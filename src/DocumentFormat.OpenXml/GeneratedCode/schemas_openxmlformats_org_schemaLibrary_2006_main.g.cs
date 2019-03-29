// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Framework;
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(25, "schemaLibrary")]
[Id(ElementTypeIdConst)]
public partial class SchemaLibrary : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12468;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SchemaLibrary>(deep);

}
/// <summary>
/// <para>Custom XML Schema Reference.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is sl:schema.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(25, "schema")]
[Id(ElementTypeIdConst)]
public partial class Schema : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12469;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Custom XML Schema Namespace.</para>
    /// <para>Represents the following attribute in the schema: sl:uri </para>
    /// </summary>
///<remark> xmlns:sl=http://schemas.openxmlformats.org/schemaLibrary/2006/main
///</remark>
    [SchemaAttr(25, "uri")]
    [Index(0)]
    public StringValue Uri { get; set; }
	
    /// <summary>
    /// <para> Resource File Location.</para>
    /// <para>Represents the following attribute in the schema: sl:manifestLocation </para>
    /// </summary>
///<remark> xmlns:sl=http://schemas.openxmlformats.org/schemaLibrary/2006/main
///</remark>
    [SchemaAttr(25, "manifestLocation")]
    [Index(1)]
    public StringValue ManifestLocation { get; set; }
	
    /// <summary>
    /// <para> Custom XML Schema Location.</para>
    /// <para>Represents the following attribute in the schema: sl:schemaLocation </para>
    /// </summary>
///<remark> xmlns:sl=http://schemas.openxmlformats.org/schemaLibrary/2006/main
///</remark>
    [SchemaAttr(25, "schemaLocation")]
    [Index(2)]
    public StringValue SchemaLocation { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the Schema class.
    /// </summary>
    public Schema():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Schema>(deep);

}
}
 
 
