// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;

namespace DocumentFormat.OpenXml.Office2010.ExcelAc
{
/// <summary>
/// <para>Defines the List Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x12ac:list.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2013)]
[SchemaAttr(72, "list")]
[Id(ElementTypeIdConst)]
public partial class List : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 13429;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
    /// <summary>
    /// Initializes a new instance of the List class.
    /// </summary>
    public List():base(){}
    
      
        /// <summary>
    /// Initializes a new instance of the List class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public List(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<List>(deep);

}
}
 
 
