// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;

namespace DocumentFormat.OpenXml.Drawing.LegacyCompatibility
{
/// <summary>
/// <para>Legacy Drawing Object.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is comp:legacyDrawing.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(13, "legacyDrawing")]
[Id(ElementTypeIdConst)]
public partial class LegacyDrawing : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10681;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Shape ID.</para>
    /// <para>Represents the following attribute in the schema: spid </para>
    /// </summary>
    [SchemaAttr(0, "spid")]
    [Index(0)]
    public StringValue ShapeId { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the LegacyDrawing class.
    /// </summary>
    public LegacyDrawing():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LegacyDrawing>(deep);

}
}
 
 
