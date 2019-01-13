// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;

namespace DocumentFormat.OpenXml.Office2013.ExcelAc
{
/// <summary>
/// <para>Defines the AbsolutePath Class.</para>
/// <para>This class is available in Office 2013 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x15ac:absPath.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2013)]
public partial class AbsolutePath : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13434;
    /// <inheritdoc/>
    public override string LocalName => "absPath";
    internal override byte NamespaceId => 74;
    internal override int ElementTypeId => ElementTypeIdConst;
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2013;

    
    
        /// <summary>
    /// <para> url.</para>
    /// <para>Represents the following attribute in the schema: url </para>
    /// </summary>
    [SchemaAttr(0, "url")]
	[SchemaIndex(0)]
    public StringValue Url { get; set; }

    /// <summary>
    /// Initializes a new instance of the AbsolutePath class.
    /// </summary>
    public AbsolutePath():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AbsolutePath>(deep);

}
}
 
 
