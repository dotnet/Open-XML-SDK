// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;

namespace DocumentFormat.OpenXml.Vml.Presentation
{
/// <summary>
/// <para>Ink Annotation Flag.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is pvml:iscomment.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(30, "iscomment")]
[Id(ElementTypeIdConst)]
public partial class InkAnnotationFlag : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12575;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the InkAnnotationFlag class.
    /// </summary>
    public InkAnnotationFlag():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<InkAnnotationFlag>(deep);

}
/// <summary>
/// <para>VML Diagram Text.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is pvml:textdata.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(30, "textdata")]
[Id(ElementTypeIdConst)]
public partial class TextData : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12576;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Text Reference.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [Index(0)]
    public StringValue Id { get; set; }
	

    /// <summary>
    /// Initializes a new instance of the TextData class.
    /// </summary>
    public TextData():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextData>(deep);

}
}
 
 
