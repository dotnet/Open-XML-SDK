// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentFormat.OpenXml.Office2016.Word.Symex
{
/// <summary>
/// <para>Defines the SymEx Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is w16se:symEx.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class SymEx : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13592;
    /// <inheritdoc/>
    public override string LocalName => "symEx";
    
    internal override byte NamespaceId => 86;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2016;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(86, "font"),
		AttributeTag.Create<HexBinaryValue>(86, "char")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> font.</para>
    /// <para>Represents the following attribute in the schema: w16se:font </para>
    /// </summary>
///<remark> xmlns:w16se=http://schemas.microsoft.com/office/word/2015/wordml/symex
///</remark>
    [SchemaAttr(86, "font")]
    public StringValue Font
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> char.</para>
    /// <para>Represents the following attribute in the schema: w16se:char </para>
    /// </summary>
///<remark> xmlns:w16se=http://schemas.microsoft.com/office/word/2015/wordml/symex
///</remark>
    [SchemaAttr(86, "char")]
    public HexBinaryValue Char
    {
        get { return (HexBinaryValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SymEx class.
    /// </summary>
    public SymEx():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SymEx>(deep);

}
}
 
 
