// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;

namespace DocumentFormat.OpenXml.Drawing.LegacyCompatibility
{
/// <summary>
/// <para>Legacy Drawing Object.</para>
/// <para> When the object is serialized out as xml, its qualified name is comp:legacyDrawing.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
public partial class LegacyDrawing : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10681;
    /// <inheritdoc/>
    public override string LocalName => "legacyDrawing";
    
    internal override byte NamespaceId => 13;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    	private static readonly string[] attributeTagNames = { "spid" };
    private static readonly byte[] attributeNamespaceIds = { 0 };
    
    internal override string[] AttributeTagNames => attributeTagNames;
    
    internal override byte[] AttributeNamespaceIds => attributeNamespaceIds;
    

    
        /// <summary>
    /// <para> Shape ID.</para>
    /// <para>Represents the following attribute in the schema: spid </para>
    /// </summary>
    [SchemaAttr(0, "spid")]
    public StringValue ShapeId
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the LegacyDrawing class.
    /// </summary>
    public LegacyDrawing():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "spid" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LegacyDrawing>(deep);

}
}
 
 
