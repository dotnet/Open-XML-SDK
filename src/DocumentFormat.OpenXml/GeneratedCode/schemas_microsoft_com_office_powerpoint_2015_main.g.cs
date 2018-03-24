// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Presentation;

namespace DocumentFormat.OpenXml.Office2016.Presentation
{
/// <summary>
/// <para>Defines the DesignElement Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is p16:designElem.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class DesignElement : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13444;
    /// <inheritdoc/>
    public override string LocalName => "designElem";
    
    internal override byte NamespaceId => 78;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override bool IsInVersion(FileFormatVersions version) => version.AtLeast(FileFormatVersions.Office2016);
    

    	private static readonly string[] attributeTagNames = { "val" };
    private static readonly byte[] attributeNamespaceIds = { 0 };
    
    internal override string[] AttributeTagNames => attributeTagNames;
    
    internal override byte[] AttributeNamespaceIds => attributeNamespaceIds;
    

    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public BooleanValue Val
    {
        get { return (BooleanValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DesignElement class.
    /// </summary>
    public DesignElement():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "val" == name)
    return new BooleanValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DesignElement>(deep);

}
}
 
 
