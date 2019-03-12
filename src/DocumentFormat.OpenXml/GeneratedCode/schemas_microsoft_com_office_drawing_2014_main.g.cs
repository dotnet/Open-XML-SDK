// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;

namespace DocumentFormat.OpenXml.Office2016.Drawing
{
/// <summary>
/// <para>Defines the CreationId Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a16:creationId.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(79, "creationId")]
public partial class CreationId : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13445;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    [Index(0)]
    public StringValue Id { get; set; }

    /// <summary>
    /// Initializes a new instance of the CreationId class.
    /// </summary>
    public CreationId():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CreationId>(deep);

}
/// <summary>
/// <para>Defines the PredecessorDrawingElementReference Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a16:predDERef.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(79, "predDERef")]
public partial class PredecessorDrawingElementReference : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13446;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> pred.</para>
    /// <para>Represents the following attribute in the schema: pred </para>
    /// </summary>
    [SchemaAttr(0, "pred")]
    [Index(0)]
    public StringValue Pred { get; set; }

    /// <summary>
    /// Initializes a new instance of the PredecessorDrawingElementReference class.
    /// </summary>
    public PredecessorDrawingElementReference():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PredecessorDrawingElementReference>(deep);

}
/// <summary>
/// <para>Defines the ConnectableReferences Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a16:cxnDERefs.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
[SchemaAttr(79, "cxnDERefs")]
public partial class ConnectableReferences : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13447;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> st.</para>
    /// <para>Represents the following attribute in the schema: st </para>
    /// </summary>
    [SchemaAttr(0, "st")]
    [Index(0)]
    public StringValue St { get; set; }
    /// <summary>
    /// <para> end.</para>
    /// <para>Represents the following attribute in the schema: end </para>
    /// </summary>
    [SchemaAttr(0, "end")]
    [Index(1)]
    public StringValue End { get; set; }

    /// <summary>
    /// Initializes a new instance of the ConnectableReferences class.
    /// </summary>
    public ConnectableReferences():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConnectableReferences>(deep);

}
/// <summary>
/// <para>Defines the RowIdIdentifier Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a16:rowId.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[SchemaAttr(79, "rowId")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RowIdIdentifier : OpenXmlIdentifierElement
{
    internal const int ElementTypeIdConst = 13448;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the RowIdIdentifier class.
    /// </summary>
    public RowIdIdentifier():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RowIdIdentifier>(deep);

}
/// <summary>
/// <para>Defines the ColIdIdentifier Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is a16:colId.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[SchemaAttr(79, "colId")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class ColIdIdentifier : OpenXmlIdentifierElement
{
    internal const int ElementTypeIdConst = 13449;
    internal override int ElementTypeId => ElementTypeIdConst;

    /// <summary>
    /// Initializes a new instance of the ColIdIdentifier class.
    /// </summary>
    public ColIdIdentifier():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColIdIdentifier>(deep);

}
/// <summary>
/// Defines the OpenXmlIdentifierElement class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class OpenXmlIdentifierElement : OpenXmlLeafElement
{
        
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    [Index(0)]
    public UInt32Value Val { get; set; }

    
    
    
    /// <summary>
    /// Initializes a new instance of the OpenXmlIdentifierElement class.
    /// </summary>
    protected OpenXmlIdentifierElement(){}
    
    
    
}
}
 
 
