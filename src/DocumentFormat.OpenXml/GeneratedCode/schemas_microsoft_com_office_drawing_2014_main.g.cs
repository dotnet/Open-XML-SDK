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
public partial class CreationId : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13445;
    /// <inheritdoc/>
    public override string LocalName => "creationId";
    
    internal override byte NamespaceId => 79;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override bool IsInVersion(FileFormatVersions version) => version.AtLeast(FileFormatVersions.Office2016);
    

    	private static readonly string[] attributeTagNames = { "id" };
    private static readonly byte[] attributeNamespaceIds = { 0 };
    
    internal override string[] AttributeTagNames => attributeTagNames;
    
    internal override byte[] AttributeNamespaceIds => attributeNamespaceIds;
    

    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the CreationId class.
    /// </summary>
    public CreationId():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "id" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

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
public partial class PredecessorDrawingElementReference : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13446;
    /// <inheritdoc/>
    public override string LocalName => "predDERef";
    
    internal override byte NamespaceId => 79;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override bool IsInVersion(FileFormatVersions version) => version.AtLeast(FileFormatVersions.Office2016);
    

    	private static readonly string[] attributeTagNames = { "pred" };
    private static readonly byte[] attributeNamespaceIds = { 0 };
    
    internal override string[] AttributeTagNames => attributeTagNames;
    
    internal override byte[] AttributeNamespaceIds => attributeNamespaceIds;
    

    
        /// <summary>
    /// <para> pred.</para>
    /// <para>Represents the following attribute in the schema: pred </para>
    /// </summary>
    [SchemaAttr(0, "pred")]
    public StringValue Pred
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PredecessorDrawingElementReference class.
    /// </summary>
    public PredecessorDrawingElementReference():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "pred" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

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
public partial class ConnectableReferences : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13447;
    /// <inheritdoc/>
    public override string LocalName => "cxnDERefs";
    
    internal override byte NamespaceId => 79;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override bool IsInVersion(FileFormatVersions version) => version.AtLeast(FileFormatVersions.Office2016);
    

    	private static readonly string[] attributeTagNames = { "st","end" };
    private static readonly byte[] attributeNamespaceIds = { 0,0 };
    
    internal override string[] AttributeTagNames => attributeTagNames;
    
    internal override byte[] AttributeNamespaceIds => attributeNamespaceIds;
    

    
        /// <summary>
    /// <para> st.</para>
    /// <para>Represents the following attribute in the schema: st </para>
    /// </summary>
    [SchemaAttr(0, "st")]
    public StringValue St
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    
    /// <summary>
    /// <para> end.</para>
    /// <para>Represents the following attribute in the schema: end </para>
    /// </summary>
    [SchemaAttr(0, "end")]
    public StringValue End
    {
        get { return (StringValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ConnectableReferences class.
    /// </summary>
    public ConnectableReferences():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "st" == name)
    return new StringValue();
    
if( 0 == namespaceId && "end" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

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
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class RowIdIdentifier : OpenXmlIdentifierElement
{
    internal const int ElementTypeIdConst = 13448;
    /// <inheritdoc/>
    public override string LocalName => "rowId";
    
    internal override byte NamespaceId => 79;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override bool IsInVersion(FileFormatVersions version) => version.AtLeast(FileFormatVersions.Office2016);
    

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
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class ColIdIdentifier : OpenXmlIdentifierElement
{
    internal const int ElementTypeIdConst = 13449;
    /// <inheritdoc/>
    public override string LocalName => "colId";
    
    internal override byte NamespaceId => 79;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override bool IsInVersion(FileFormatVersions version) => version.AtLeast(FileFormatVersions.Office2016);
    

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
    	private static readonly string[] attributeTagNames = { "val" };
    private static readonly byte[] attributeNamespaceIds = { 0 };
    
    internal override string[] AttributeTagNames => attributeTagNames;
    
    internal override byte[] AttributeNamespaceIds => attributeNamespaceIds;
    
    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public UInt32Value Val
    {
        get { return (UInt32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "val" == name)
    return new UInt32Value();
    

    
    return base.AttributeFactory(namespaceId, name);
}

    
    /// <summary>
    /// Initializes a new instance of the OpenXmlIdentifierElement class.
    /// </summary>
    protected OpenXmlIdentifierElement(){}
    
    
    
}
}
 
 
