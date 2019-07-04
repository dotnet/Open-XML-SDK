// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentFormat.OpenXml.Office2016.Word.Symex
{
/// <summary>
/// <para>Defines the SymEx Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w16se:symEx.</para>
/// </summary>


[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(86, "symEx")]
public partial class SymEx : OpenXmlLeafElement
{
    
        /// <summary>
    /// <para> font, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: w16se:font </para>
    /// </summary>
///<remark> xmlns:w16se=http://schemas.microsoft.com/office/word/2015/wordml/symex
///</remark>
[OfficeAvailability(FileFormatVersions.Office2016)]
    [SchemaAttr(86, "font")]
    [Index(0)]
    public StringValue Font { get; set; }
    /// <summary>
    /// <para> char, this property is only available in Office2016.</para>
    /// <para>Represents the following attribute in the schema: w16se:char </para>
    /// </summary>
///<remark> xmlns:w16se=http://schemas.microsoft.com/office/word/2015/wordml/symex
///</remark>
[OfficeAvailability(FileFormatVersions.Office2016)]
[StringValidator(Length = 4)]
    [SchemaAttr(86, "char")]
    [Index(1)]
    public HexBinaryValue Char { get; set; }

    /// <summary>
    /// Initializes a new instance of the SymEx class.
    /// </summary>
    public SymEx():base(){}
    
    

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SymEx>(deep);

}
}
