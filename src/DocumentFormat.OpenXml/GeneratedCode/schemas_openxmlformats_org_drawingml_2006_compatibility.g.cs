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
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is comp:legacyDrawing.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class LegacyDrawing : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10681;
    /// <inheritdoc/>
    public override string LocalName => "legacyDrawing";
    
    internal override byte NamespaceId => 13;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "spid")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Shape ID.</para>
    /// <para>Represents the following attribute in the schema: spid </para>
    /// </summary>
    [SchemaAttr(0, "spid")]
    public StringValue ShapeId
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the LegacyDrawing class.
    /// </summary>
    public LegacyDrawing():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LegacyDrawing>(deep);

}
}
 
 
