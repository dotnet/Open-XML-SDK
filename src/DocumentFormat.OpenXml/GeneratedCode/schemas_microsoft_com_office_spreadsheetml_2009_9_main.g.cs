// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Office.Excel;

namespace DocumentFormat.OpenXml.Office2010.Excel
{
/// <summary>
/// <para>Defines the ConditionalFormattings Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:conditionalFormattings.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ConditionalFormatting &lt;x14:conditionalFormatting></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ConditionalFormatting), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ConditionalFormattings : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12962;
    /// <inheritdoc/>
    public override string LocalName => "conditionalFormattings";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ConditionalFormattings class.
    /// </summary>
    public ConditionalFormattings():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ConditionalFormattings class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ConditionalFormattings(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ConditionalFormattings class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ConditionalFormattings(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ConditionalFormattings class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ConditionalFormattings(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "conditionalFormatting" == name)
    return new ConditionalFormatting();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConditionalFormattings>(deep);

}
/// <summary>
/// <para>Defines the DataValidations Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:dataValidations.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DataValidation &lt;x14:dataValidation></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DataValidation), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class DataValidations : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12963;
    /// <inheritdoc/>
    public override string LocalName => "dataValidations";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "disablePrompts"),
		AttributeTag.Create<UInt32Value>(0, "xWindow"),
		AttributeTag.Create<UInt32Value>(0, "yWindow"),
		AttributeTag.Create<UInt32Value>(0, "count")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> disablePrompts.</para>
    /// <para>Represents the following attribute in the schema: disablePrompts </para>
    /// </summary>
    [SchemaAttr(0, "disablePrompts")]
    public BooleanValue DisablePrompts
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> xWindow.</para>
    /// <para>Represents the following attribute in the schema: xWindow </para>
    /// </summary>
    [SchemaAttr(0, "xWindow")]
    public UInt32Value XWindow
    {
        get { return (UInt32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> yWindow.</para>
    /// <para>Represents the following attribute in the schema: yWindow </para>
    /// </summary>
    [SchemaAttr(0, "yWindow")]
    public UInt32Value YWindow
    {
        get { return (UInt32Value)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> count.</para>
    /// <para>Represents the following attribute in the schema: count </para>
    /// </summary>
    [SchemaAttr(0, "count")]
    public UInt32Value Count
    {
        get { return (UInt32Value)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DataValidations class.
    /// </summary>
    public DataValidations():base(){}
    
        /// <summary>
    ///Initializes a new instance of the DataValidations class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataValidations(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataValidations class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataValidations(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataValidations class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataValidations(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "dataValidation" == name)
    return new DataValidation();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataValidations>(deep);

}
/// <summary>
/// <para>Defines the SparklineGroups Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:sparklineGroups.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SparklineGroup &lt;x14:sparklineGroup></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SparklineGroup), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SparklineGroups : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12964;
    /// <inheritdoc/>
    public override string LocalName => "sparklineGroups";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the SparklineGroups class.
    /// </summary>
    public SparklineGroups():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SparklineGroups class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SparklineGroups(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SparklineGroups class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SparklineGroups(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SparklineGroups class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SparklineGroups(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "sparklineGroup" == name)
    return new SparklineGroup();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SparklineGroups>(deep);

}
/// <summary>
/// <para>Defines the SlicerList Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:slicerList.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SlicerRef &lt;x14:slicer></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SlicerRef), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SlicerList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12965;
    /// <inheritdoc/>
    public override string LocalName => "slicerList";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the SlicerList class.
    /// </summary>
    public SlicerList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SlicerList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SlicerList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SlicerList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SlicerList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SlicerList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SlicerList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "slicer" == name)
    return new SlicerRef();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerList>(deep);

}
/// <summary>
/// <para>Defines the ProtectedRanges Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:protectedRanges.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ProtectedRange &lt;x14:protectedRange></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ProtectedRange), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ProtectedRanges : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12966;
    /// <inheritdoc/>
    public override string LocalName => "protectedRanges";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ProtectedRanges class.
    /// </summary>
    public ProtectedRanges():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ProtectedRanges class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ProtectedRanges(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ProtectedRanges class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ProtectedRanges(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ProtectedRanges class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ProtectedRanges(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "protectedRange" == name)
    return new ProtectedRange();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ProtectedRanges>(deep);

}
/// <summary>
/// <para>Defines the IgnoredErrors Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:ignoredErrors.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>IgnoredError &lt;x14:ignoredError></description></item>
///<item><description>ExtensionList &lt;x14:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(IgnoredError), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class IgnoredErrors : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12967;
    /// <inheritdoc/>
    public override string LocalName => "ignoredErrors";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the IgnoredErrors class.
    /// </summary>
    public IgnoredErrors():base(){}
    
        /// <summary>
    ///Initializes a new instance of the IgnoredErrors class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public IgnoredErrors(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the IgnoredErrors class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public IgnoredErrors(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the IgnoredErrors class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public IgnoredErrors(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "ignoredError" == name)
    return new IgnoredError();
    
if( 53 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<IgnoredErrors>(deep);

}
/// <summary>
/// <para>Defines the DefinedNames Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:definedNames.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DefinedName &lt;x14:definedName></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DefinedName), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class DefinedNames : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12968;
    /// <inheritdoc/>
    public override string LocalName => "definedNames";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the DefinedNames class.
    /// </summary>
    public DefinedNames():base(){}
    
        /// <summary>
    ///Initializes a new instance of the DefinedNames class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DefinedNames(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DefinedNames class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DefinedNames(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DefinedNames class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DefinedNames(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "definedName" == name)
    return new DefinedName();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DefinedNames>(deep);

}
/// <summary>
/// <para>Defines the PivotCaches Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:pivotCaches.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Spreadsheet.PivotCache &lt;x:pivotCache></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.PivotCache))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class PivotCaches : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12969;
    /// <inheritdoc/>
    public override string LocalName => "pivotCaches";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the PivotCaches class.
    /// </summary>
    public PivotCaches():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PivotCaches class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotCaches(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotCaches class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotCaches(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotCaches class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PivotCaches(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 22 == namespaceId && "pivotCache" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.PivotCache();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotCaches>(deep);

}
/// <summary>
/// <para>Defines the SlicerCaches Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:slicerCaches.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SlicerCache &lt;x14:slicerCache></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SlicerCache), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SlicerCaches : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12970;
    /// <inheritdoc/>
    public override string LocalName => "slicerCaches";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the SlicerCaches class.
    /// </summary>
    public SlicerCaches():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SlicerCaches class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SlicerCaches(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SlicerCaches class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SlicerCaches(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SlicerCaches class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SlicerCaches(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "slicerCache" == name)
    return new SlicerCache();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerCaches>(deep);

}
/// <summary>
/// <para>Defines the WorkbookProperties Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:workbookPr.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class WorkbookProperties : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12971;
    /// <inheritdoc/>
    public override string LocalName => "workbookPr";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "defaultImageDpi"),
		AttributeTag.Create<BooleanValue>(0, "discardImageEditData"),
		AttributeTag.Create<UInt32Value>(0, "accuracyVersion")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> defaultImageDpi.</para>
    /// <para>Represents the following attribute in the schema: defaultImageDpi </para>
    /// </summary>
    [SchemaAttr(0, "defaultImageDpi")]
    public UInt32Value DefaultImageDpi
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> discardImageEditData.</para>
    /// <para>Represents the following attribute in the schema: discardImageEditData </para>
    /// </summary>
    [SchemaAttr(0, "discardImageEditData")]
    public BooleanValue DiscardImageEditData
    {
        get { return (BooleanValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> accuracyVersion.</para>
    /// <para>Represents the following attribute in the schema: accuracyVersion </para>
    /// </summary>
    [SchemaAttr(0, "accuracyVersion")]
    public UInt32Value AccuracyVersion
    {
        get { return (UInt32Value)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the WorkbookProperties class.
    /// </summary>
    public WorkbookProperties():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WorkbookProperties>(deep);

}
/// <summary>
/// <para>Defines the CalculatedMember Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:calculatedMember.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TupleSet &lt;x14:tupleSet></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(TupleSet), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class CalculatedMember : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12972;
    /// <inheritdoc/>
    public override string LocalName => "calculatedMember";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "displayFolder"),
		AttributeTag.Create<BooleanValue>(0, "flattenHierarchies"),
		AttributeTag.Create<BooleanValue>(0, "dynamicSet"),
		AttributeTag.Create<BooleanValue>(0, "hierarchizeDistinct"),
		AttributeTag.Create<StringValue>(0, "mdxLong")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> displayFolder.</para>
    /// <para>Represents the following attribute in the schema: displayFolder </para>
    /// </summary>
    [SchemaAttr(0, "displayFolder")]
    public StringValue DisplayFolder
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> flattenHierarchies.</para>
    /// <para>Represents the following attribute in the schema: flattenHierarchies </para>
    /// </summary>
    [SchemaAttr(0, "flattenHierarchies")]
    public BooleanValue FlattenHierarchies
    {
        get { return (BooleanValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> dynamicSet.</para>
    /// <para>Represents the following attribute in the schema: dynamicSet </para>
    /// </summary>
    [SchemaAttr(0, "dynamicSet")]
    public BooleanValue DynamicSet
    {
        get { return (BooleanValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> hierarchizeDistinct.</para>
    /// <para>Represents the following attribute in the schema: hierarchizeDistinct </para>
    /// </summary>
    [SchemaAttr(0, "hierarchizeDistinct")]
    public BooleanValue HierarchizeDistinct
    {
        get { return (BooleanValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> mdxLong.</para>
    /// <para>Represents the following attribute in the schema: mdxLong </para>
    /// </summary>
    [SchemaAttr(0, "mdxLong")]
    public StringValue MdxLong
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the CalculatedMember class.
    /// </summary>
    public CalculatedMember():base(){}
    
        /// <summary>
    ///Initializes a new instance of the CalculatedMember class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CalculatedMember(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the CalculatedMember class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CalculatedMember(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the CalculatedMember class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public CalculatedMember(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "tupleSet" == name)
    return new TupleSet();
    

    return null;
}

        private static readonly string[] eleTagNames = { "tupleSet" };
    private static readonly byte[] eleNamespaceIds = { 53 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> TupleSet.</para>
    /// <para> Represents the following element tag in the schema: x14:tupleSet </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public TupleSet TupleSet
    {
        get => GetElement<TupleSet>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CalculatedMember>(deep);

}
/// <summary>
/// <para>Defines the CacheHierarchy Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:cacheHierarchy.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SetLevels &lt;x14:setLevels></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SetLevels), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class CacheHierarchy : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12973;
    /// <inheritdoc/>
    public override string LocalName => "cacheHierarchy";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "flattenHierarchies"),
		AttributeTag.Create<BooleanValue>(0, "measuresSet"),
		AttributeTag.Create<BooleanValue>(0, "hierarchizeDistinct"),
		AttributeTag.Create<BooleanValue>(0, "ignore")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> flattenHierarchies.</para>
    /// <para>Represents the following attribute in the schema: flattenHierarchies </para>
    /// </summary>
    [SchemaAttr(0, "flattenHierarchies")]
    public BooleanValue FlattenHierarchies
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> measuresSet.</para>
    /// <para>Represents the following attribute in the schema: measuresSet </para>
    /// </summary>
    [SchemaAttr(0, "measuresSet")]
    public BooleanValue MeasuresSet
    {
        get { return (BooleanValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> hierarchizeDistinct.</para>
    /// <para>Represents the following attribute in the schema: hierarchizeDistinct </para>
    /// </summary>
    [SchemaAttr(0, "hierarchizeDistinct")]
    public BooleanValue HierarchizeDistinct
    {
        get { return (BooleanValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> ignore.</para>
    /// <para>Represents the following attribute in the schema: ignore </para>
    /// </summary>
    [SchemaAttr(0, "ignore")]
    public BooleanValue Ignore
    {
        get { return (BooleanValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the CacheHierarchy class.
    /// </summary>
    public CacheHierarchy():base(){}
    
        /// <summary>
    ///Initializes a new instance of the CacheHierarchy class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CacheHierarchy(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the CacheHierarchy class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CacheHierarchy(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the CacheHierarchy class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public CacheHierarchy(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "setLevels" == name)
    return new SetLevels();
    

    return null;
}

        private static readonly string[] eleTagNames = { "setLevels" };
    private static readonly byte[] eleNamespaceIds = { 53 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> SetLevels.</para>
    /// <para> Represents the following element tag in the schema: x14:setLevels </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public SetLevels SetLevels
    {
        get => GetElement<SetLevels>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CacheHierarchy>(deep);

}
/// <summary>
/// <para>Defines the DataField Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:dataField.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class DataField : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12974;
    /// <inheritdoc/>
    public override string LocalName => "dataField";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.PivotShowAsValues>>(0, "pivotShowAs"),
		AttributeTag.Create<UInt32Value>(0, "sourceField"),
		AttributeTag.Create<StringValue>(0, "uniqueName")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> pivotShowAs.</para>
    /// <para>Represents the following attribute in the schema: pivotShowAs </para>
    /// </summary>
    [SchemaAttr(0, "pivotShowAs")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.PivotShowAsValues> PivotShowAs
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.PivotShowAsValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> sourceField.</para>
    /// <para>Represents the following attribute in the schema: sourceField </para>
    /// </summary>
    [SchemaAttr(0, "sourceField")]
    public UInt32Value SourceField
    {
        get { return (UInt32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> uniqueName.</para>
    /// <para>Represents the following attribute in the schema: uniqueName </para>
    /// </summary>
    [SchemaAttr(0, "uniqueName")]
    public StringValue UniqueName
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DataField class.
    /// </summary>
    public DataField():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataField>(deep);

}
/// <summary>
/// <para>Defines the PivotField Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:pivotField.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class PivotField : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12975;
    /// <inheritdoc/>
    public override string LocalName => "pivotField";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "fillDownLabels"),
		AttributeTag.Create<BooleanValue>(0, "ignore")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> fillDownLabels.</para>
    /// <para>Represents the following attribute in the schema: fillDownLabels </para>
    /// </summary>
    [SchemaAttr(0, "fillDownLabels")]
    public BooleanValue FillDownLabels
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> ignore.</para>
    /// <para>Represents the following attribute in the schema: ignore </para>
    /// </summary>
    [SchemaAttr(0, "ignore")]
    public BooleanValue Ignore
    {
        get { return (BooleanValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PivotField class.
    /// </summary>
    public PivotField():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotField>(deep);

}
/// <summary>
/// <para>Defines the PivotTableDefinition Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:pivotTableDefinition.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PivotEdits &lt;x14:pivotEdits></description></item>
///<item><description>PivotChanges &lt;x14:pivotChanges></description></item>
///<item><description>ConditionalFormats &lt;x14:conditionalFormats></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(PivotEdits), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(PivotChanges), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ConditionalFormats), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class PivotTableDefinition : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12976;
    /// <inheritdoc/>
    public override string LocalName => "pivotTableDefinition";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "fillDownLabelsDefault"),
		AttributeTag.Create<BooleanValue>(0, "visualTotalsForSets"),
		AttributeTag.Create<BooleanValue>(0, "calculatedMembersInFilters"),
		AttributeTag.Create<StringValue>(0, "altText"),
		AttributeTag.Create<StringValue>(0, "altTextSummary"),
		AttributeTag.Create<BooleanValue>(0, "enableEdit"),
		AttributeTag.Create<BooleanValue>(0, "autoApply"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.AllocationMethodValues>>(0, "allocationMethod"),
		AttributeTag.Create<StringValue>(0, "weightExpression"),
		AttributeTag.Create<BooleanValue>(0, "hideValuesRow")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> fillDownLabelsDefault.</para>
    /// <para>Represents the following attribute in the schema: fillDownLabelsDefault </para>
    /// </summary>
    [SchemaAttr(0, "fillDownLabelsDefault")]
    public BooleanValue FillDownLabelsDefault
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> visualTotalsForSets.</para>
    /// <para>Represents the following attribute in the schema: visualTotalsForSets </para>
    /// </summary>
    [SchemaAttr(0, "visualTotalsForSets")]
    public BooleanValue VisualTotalsForSets
    {
        get { return (BooleanValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> calculatedMembersInFilters.</para>
    /// <para>Represents the following attribute in the schema: calculatedMembersInFilters </para>
    /// </summary>
    [SchemaAttr(0, "calculatedMembersInFilters")]
    public BooleanValue CalculatedMembersInFilters
    {
        get { return (BooleanValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> altText.</para>
    /// <para>Represents the following attribute in the schema: altText </para>
    /// </summary>
    [SchemaAttr(0, "altText")]
    public StringValue AltText
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> altTextSummary.</para>
    /// <para>Represents the following attribute in the schema: altTextSummary </para>
    /// </summary>
    [SchemaAttr(0, "altTextSummary")]
    public StringValue AltTextSummary
    {
        get { return (StringValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> enableEdit.</para>
    /// <para>Represents the following attribute in the schema: enableEdit </para>
    /// </summary>
    [SchemaAttr(0, "enableEdit")]
    public BooleanValue EnableEdit
    {
        get { return (BooleanValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> autoApply.</para>
    /// <para>Represents the following attribute in the schema: autoApply </para>
    /// </summary>
    [SchemaAttr(0, "autoApply")]
    public BooleanValue AutoApply
    {
        get { return (BooleanValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> allocationMethod.</para>
    /// <para>Represents the following attribute in the schema: allocationMethod </para>
    /// </summary>
    [SchemaAttr(0, "allocationMethod")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.AllocationMethodValues> AllocationMethod
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.AllocationMethodValues>)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> weightExpression.</para>
    /// <para>Represents the following attribute in the schema: weightExpression </para>
    /// </summary>
    [SchemaAttr(0, "weightExpression")]
    public StringValue WeightExpression
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> hideValuesRow.</para>
    /// <para>Represents the following attribute in the schema: hideValuesRow </para>
    /// </summary>
    [SchemaAttr(0, "hideValuesRow")]
    public BooleanValue HideValuesRow
    {
        get { return (BooleanValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PivotTableDefinition class.
    /// </summary>
    public PivotTableDefinition():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PivotTableDefinition class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotTableDefinition(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotTableDefinition class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotTableDefinition(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotTableDefinition class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PivotTableDefinition(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "pivotEdits" == name)
    return new PivotEdits();
    
if( 53 == namespaceId && "pivotChanges" == name)
    return new PivotChanges();
    
if( 53 == namespaceId && "conditionalFormats" == name)
    return new ConditionalFormats();
    

    return null;
}

        private static readonly string[] eleTagNames = { "pivotEdits","pivotChanges","conditionalFormats" };
    private static readonly byte[] eleNamespaceIds = { 53,53,53 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> PivotEdits.</para>
    /// <para> Represents the following element tag in the schema: x14:pivotEdits </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public PivotEdits PivotEdits
    {
        get => GetElement<PivotEdits>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> PivotChanges.</para>
    /// <para> Represents the following element tag in the schema: x14:pivotChanges </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public PivotChanges PivotChanges
    {
        get => GetElement<PivotChanges>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> ConditionalFormats.</para>
    /// <para> Represents the following element tag in the schema: x14:conditionalFormats </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public ConditionalFormats ConditionalFormats
    {
        get => GetElement<ConditionalFormats>(2);
        set => SetElement(2, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotTableDefinition>(deep);

}
/// <summary>
/// <para>Defines the PivotCacheDefinition Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:pivotCacheDefinition.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class PivotCacheDefinition : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12977;
    /// <inheritdoc/>
    public override string LocalName => "pivotCacheDefinition";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "slicerData"),
		AttributeTag.Create<UInt32Value>(0, "pivotCacheId"),
		AttributeTag.Create<BooleanValue>(0, "supportSubqueryNonVisual"),
		AttributeTag.Create<BooleanValue>(0, "supportSubqueryCalcMem"),
		AttributeTag.Create<BooleanValue>(0, "supportAddCalcMems")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> slicerData.</para>
    /// <para>Represents the following attribute in the schema: slicerData </para>
    /// </summary>
    [SchemaAttr(0, "slicerData")]
    public BooleanValue SlicerData
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> pivotCacheId.</para>
    /// <para>Represents the following attribute in the schema: pivotCacheId </para>
    /// </summary>
    [SchemaAttr(0, "pivotCacheId")]
    public UInt32Value PivotCacheId
    {
        get { return (UInt32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> supportSubqueryNonVisual.</para>
    /// <para>Represents the following attribute in the schema: supportSubqueryNonVisual </para>
    /// </summary>
    [SchemaAttr(0, "supportSubqueryNonVisual")]
    public BooleanValue SupportSubqueryNonVisual
    {
        get { return (BooleanValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> supportSubqueryCalcMem.</para>
    /// <para>Represents the following attribute in the schema: supportSubqueryCalcMem </para>
    /// </summary>
    [SchemaAttr(0, "supportSubqueryCalcMem")]
    public BooleanValue SupportSubqueryCalcMem
    {
        get { return (BooleanValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> supportAddCalcMems.</para>
    /// <para>Represents the following attribute in the schema: supportAddCalcMems </para>
    /// </summary>
    [SchemaAttr(0, "supportAddCalcMems")]
    public BooleanValue SupportAddCalcMems
    {
        get { return (BooleanValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PivotCacheDefinition class.
    /// </summary>
    public PivotCacheDefinition():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotCacheDefinition>(deep);

}
/// <summary>
/// <para>Defines the Connection Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:connection.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>CalculatedMembers &lt;x14:calculatedMembers></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(CalculatedMembers), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Connection : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12978;
    /// <inheritdoc/>
    public override string LocalName => "connection";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "culture"),
		AttributeTag.Create<StringValue>(0, "embeddedDataId")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> culture.</para>
    /// <para>Represents the following attribute in the schema: culture </para>
    /// </summary>
    [SchemaAttr(0, "culture")]
    public StringValue Culture
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> embeddedDataId.</para>
    /// <para>Represents the following attribute in the schema: embeddedDataId </para>
    /// </summary>
    [SchemaAttr(0, "embeddedDataId")]
    public StringValue EmbeddedDataId
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Connection class.
    /// </summary>
    public Connection():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Connection class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Connection(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Connection class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Connection(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Connection class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Connection(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "calculatedMembers" == name)
    return new CalculatedMembers();
    

    return null;
}

        private static readonly string[] eleTagNames = { "calculatedMembers" };
    private static readonly byte[] eleNamespaceIds = { 53 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> CalculatedMembers.</para>
    /// <para> Represents the following element tag in the schema: x14:calculatedMembers </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public CalculatedMembers CalculatedMembers
    {
        get => GetElement<CalculatedMembers>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Connection>(deep);

}
/// <summary>
/// <para>Defines the Table Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:table.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Table : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12979;
    /// <inheritdoc/>
    public override string LocalName => "table";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "altText"),
		AttributeTag.Create<StringValue>(0, "altTextSummary")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> altText.</para>
    /// <para>Represents the following attribute in the schema: altText </para>
    /// </summary>
    [SchemaAttr(0, "altText")]
    public StringValue AltText
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> altTextSummary.</para>
    /// <para>Represents the following attribute in the schema: altTextSummary </para>
    /// </summary>
    [SchemaAttr(0, "altTextSummary")]
    public StringValue AltTextSummary
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Table class.
    /// </summary>
    public Table():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Table>(deep);

}
/// <summary>
/// <para>Defines the SlicerStyles Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:slicerStyles.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SlicerStyle &lt;x14:slicerStyle></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SlicerStyle), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SlicerStyles : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12980;
    /// <inheritdoc/>
    public override string LocalName => "slicerStyles";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "defaultSlicerStyle")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> defaultSlicerStyle.</para>
    /// <para>Represents the following attribute in the schema: defaultSlicerStyle </para>
    /// </summary>
    [SchemaAttr(0, "defaultSlicerStyle")]
    public StringValue DefaultSlicerStyle
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SlicerStyles class.
    /// </summary>
    public SlicerStyles():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SlicerStyles class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SlicerStyles(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SlicerStyles class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SlicerStyles(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SlicerStyles class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SlicerStyles(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "slicerStyle" == name)
    return new SlicerStyle();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerStyles>(deep);

}
/// <summary>
/// <para>Defines the DifferentialFormats Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:dxfs.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Spreadsheet.DifferentialFormat &lt;x:dxf></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.DifferentialFormat))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class DifferentialFormats : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12981;
    /// <inheritdoc/>
    public override string LocalName => "dxfs";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "count")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Format Count.</para>
    /// <para>Represents the following attribute in the schema: count </para>
    /// </summary>
    [SchemaAttr(0, "count")]
    public UInt32Value Count
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DifferentialFormats class.
    /// </summary>
    public DifferentialFormats():base(){}
    
        /// <summary>
    ///Initializes a new instance of the DifferentialFormats class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DifferentialFormats(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DifferentialFormats class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DifferentialFormats(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DifferentialFormats class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DifferentialFormats(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 22 == namespaceId && "dxf" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.DifferentialFormat();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DifferentialFormats>(deep);

}
/// <summary>
/// <para>Defines the OleItem Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:oleItem.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DdeValues &lt;x14:values></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DdeValues), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class OleItem : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12982;
    /// <inheritdoc/>
    public override string LocalName => "oleItem";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "name"),
		AttributeTag.Create<BooleanValue>(0, "icon"),
		AttributeTag.Create<BooleanValue>(0, "advise"),
		AttributeTag.Create<BooleanValue>(0, "preferPic")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> icon.</para>
    /// <para>Represents the following attribute in the schema: icon </para>
    /// </summary>
    [SchemaAttr(0, "icon")]
    public BooleanValue Icon
    {
        get { return (BooleanValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> advise.</para>
    /// <para>Represents the following attribute in the schema: advise </para>
    /// </summary>
    [SchemaAttr(0, "advise")]
    public BooleanValue Advise
    {
        get { return (BooleanValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> preferPic.</para>
    /// <para>Represents the following attribute in the schema: preferPic </para>
    /// </summary>
    [SchemaAttr(0, "preferPic")]
    public BooleanValue PreferPicture
    {
        get { return (BooleanValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the OleItem class.
    /// </summary>
    public OleItem():base(){}
    
        /// <summary>
    ///Initializes a new instance of the OleItem class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OleItem(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the OleItem class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OleItem(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the OleItem class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public OleItem(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "values" == name)
    return new DdeValues();
    

    return null;
}

        private static readonly string[] eleTagNames = { "values" };
    private static readonly byte[] eleNamespaceIds = { 53 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> DdeValues.</para>
    /// <para> Represents the following element tag in the schema: x14:values </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public DdeValues DdeValues
    {
        get => GetElement<DdeValues>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<OleItem>(deep);

}
/// <summary>
/// <para>Defines the PivotHierarchy Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:pivotHierarchy.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class PivotHierarchy : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12983;
    /// <inheritdoc/>
    public override string LocalName => "pivotHierarchy";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "ignore")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> ignore.</para>
    /// <para>Represents the following attribute in the schema: ignore </para>
    /// </summary>
    [SchemaAttr(0, "ignore")]
    public BooleanValue Ignore
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PivotHierarchy class.
    /// </summary>
    public PivotHierarchy():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotHierarchy>(deep);

}
/// <summary>
/// <para>Defines the CacheField Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:cacheField.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class CacheField : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12984;
    /// <inheritdoc/>
    public override string LocalName => "cacheField";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "ignore")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> ignore.</para>
    /// <para>Represents the following attribute in the schema: ignore </para>
    /// </summary>
    [SchemaAttr(0, "ignore")]
    public BooleanValue Ignore
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the CacheField class.
    /// </summary>
    public CacheField():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CacheField>(deep);

}
/// <summary>
/// <para>Defines the Id Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:id.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Id : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 12985;
    /// <inheritdoc/>
    public override string LocalName => "id";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Id class.
    /// </summary>
    public Id():base(){}
    
      
        /// <summary>
    /// Initializes a new instance of the Id class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Id(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Id>(deep);

}
/// <summary>
/// <para>Defines the IconFilter Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:iconFilter.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class IconFilter : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12986;
    /// <inheritdoc/>
    public override string LocalName => "iconFilter";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.IconSetTypeValues>>(0, "iconSet"),
		AttributeTag.Create<UInt32Value>(0, "iconId")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> iconSet.</para>
    /// <para>Represents the following attribute in the schema: iconSet </para>
    /// </summary>
    [SchemaAttr(0, "iconSet")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.IconSetTypeValues> IconSet
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.IconSetTypeValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> iconId.</para>
    /// <para>Represents the following attribute in the schema: iconId </para>
    /// </summary>
    [SchemaAttr(0, "iconId")]
    public UInt32Value IconId
    {
        get { return (UInt32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the IconFilter class.
    /// </summary>
    public IconFilter():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<IconFilter>(deep);

}
/// <summary>
/// <para>Defines the Filter Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:filter.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Filter : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12987;
    /// <inheritdoc/>
    public override string LocalName => "filter";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public StringValue Val
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Filter class.
    /// </summary>
    public Filter():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Filter>(deep);

}
/// <summary>
/// <para>Defines the CustomFilters Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:customFilters.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>CustomFilter &lt;x14:customFilter></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(CustomFilter), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class CustomFilters : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12988;
    /// <inheritdoc/>
    public override string LocalName => "customFilters";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "and")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> and.</para>
    /// <para>Represents the following attribute in the schema: and </para>
    /// </summary>
    [SchemaAttr(0, "and")]
    public BooleanValue And
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the CustomFilters class.
    /// </summary>
    public CustomFilters():base(){}
    
        /// <summary>
    ///Initializes a new instance of the CustomFilters class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CustomFilters(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the CustomFilters class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CustomFilters(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the CustomFilters class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public CustomFilters(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "customFilter" == name)
    return new CustomFilter();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomFilters>(deep);

}
/// <summary>
/// <para>Defines the SortCondition Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:sortCondition.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SortCondition : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12989;
    /// <inheritdoc/>
    public override string LocalName => "sortCondition";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "descending"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Spreadsheet.SortByValues>>(0, "sortBy"),
		AttributeTag.Create<StringValue>(0, "ref"),
		AttributeTag.Create<StringValue>(0, "customList"),
		AttributeTag.Create<UInt32Value>(0, "dxfId"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.IconSetTypeValues>>(0, "iconSet"),
		AttributeTag.Create<UInt32Value>(0, "iconId")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> descending.</para>
    /// <para>Represents the following attribute in the schema: descending </para>
    /// </summary>
    [SchemaAttr(0, "descending")]
    public BooleanValue Descending
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> sortBy.</para>
    /// <para>Represents the following attribute in the schema: sortBy </para>
    /// </summary>
    [SchemaAttr(0, "sortBy")]
    public EnumValue<DocumentFormat.OpenXml.Spreadsheet.SortByValues> SortBy
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Spreadsheet.SortByValues>)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> ref.</para>
    /// <para>Represents the following attribute in the schema: ref </para>
    /// </summary>
    [SchemaAttr(0, "ref")]
    public StringValue Reference
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> customList.</para>
    /// <para>Represents the following attribute in the schema: customList </para>
    /// </summary>
    [SchemaAttr(0, "customList")]
    public StringValue CustomList
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> dxfId.</para>
    /// <para>Represents the following attribute in the schema: dxfId </para>
    /// </summary>
    [SchemaAttr(0, "dxfId")]
    public UInt32Value FormatId
    {
        get { return (UInt32Value)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> iconSet.</para>
    /// <para>Represents the following attribute in the schema: iconSet </para>
    /// </summary>
    [SchemaAttr(0, "iconSet")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.IconSetTypeValues> IconSet
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.IconSetTypeValues>)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> iconId.</para>
    /// <para>Represents the following attribute in the schema: iconId </para>
    /// </summary>
    [SchemaAttr(0, "iconId")]
    public UInt32Value IconId
    {
        get { return (UInt32Value)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SortCondition class.
    /// </summary>
    public SortCondition():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SortCondition>(deep);

}
/// <summary>
/// <para>Defines the SourceConnection Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:sourceConnection.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SourceConnection : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 12990;
    /// <inheritdoc/>
    public override string LocalName => "sourceConnection";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "name")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SourceConnection class.
    /// </summary>
    public SourceConnection():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SourceConnection>(deep);

}
/// <summary>
/// <para>Defines the DatastoreItem Class. The root element of CustomDataPropertiesPart.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:datastoreItem.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExtensionList &lt;x14:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class DatastoreItem : OpenXmlPartRootElement
{
    internal const int ElementTypeIdConst = 12991;
    /// <inheritdoc/>
    public override string LocalName => "datastoreItem";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "id")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    
	internal DatastoreItem(CustomDataPropertiesPart ownerPart) : base (ownerPart){}
    
    /// <summary>
    /// Loads the DOM from the CustomDataPropertiesPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(CustomDataPropertiesPart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the CustomDataPropertiesPart associated with this element.
    /// </summary>
    public CustomDataPropertiesPart CustomDataPropertiesPart
    {
		get => OpenXmlPart as CustomDataPropertiesPart;
		internal set => OpenXmlPart = value;
    }
    
        /// <summary>
    ///Initializes a new instance of the DatastoreItem class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DatastoreItem(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DatastoreItem class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DatastoreItem(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DatastoreItem class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DatastoreItem(string outerXml)
        : base(outerXml)
    {
    }

    
    
    /// <summary>
    /// Initializes a new instance of the DatastoreItem class.
    /// </summary>
    public DatastoreItem():base(){}
    
    /// <summary>
    /// Saves the DOM into the CustomDataPropertiesPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(CustomDataPropertiesPart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "extLst" };
    private static readonly byte[] eleNamespaceIds = { 53 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: x14:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public ExtensionList ExtensionList
    {
        get => GetElement<ExtensionList>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DatastoreItem>(deep);

}
/// <summary>
/// <para>Defines the FormControlProperties Class. The root element of ControlPropertiesPart.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:formControlPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ListItems &lt;x14:itemLst></description></item>
///<item><description>ExtensionList &lt;x14:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ListItems), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class FormControlProperties : OpenXmlPartRootElement
{
    internal const int ElementTypeIdConst = 12992;
    /// <inheritdoc/>
    public override string LocalName => "formControlPr";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.ObjectTypeValues>>(0, "objectType"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.CheckedValues>>(0, "checked"),
		AttributeTag.Create<BooleanValue>(0, "colored"),
		AttributeTag.Create<UInt32Value>(0, "dropLines"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.DropStyleValues>>(0, "dropStyle"),
		AttributeTag.Create<UInt32Value>(0, "dx"),
		AttributeTag.Create<BooleanValue>(0, "firstButton"),
		AttributeTag.Create<StringValue>(0, "fmlaGroup"),
		AttributeTag.Create<StringValue>(0, "fmlaLink"),
		AttributeTag.Create<StringValue>(0, "fmlaRange"),
		AttributeTag.Create<StringValue>(0, "fmlaTxbx"),
		AttributeTag.Create<BooleanValue>(0, "horiz"),
		AttributeTag.Create<UInt32Value>(0, "inc"),
		AttributeTag.Create<BooleanValue>(0, "justLastX"),
		AttributeTag.Create<BooleanValue>(0, "lockText"),
		AttributeTag.Create<UInt32Value>(0, "max"),
		AttributeTag.Create<UInt32Value>(0, "min"),
		AttributeTag.Create<StringValue>(0, "multiSel"),
		AttributeTag.Create<BooleanValue>(0, "noThreeD"),
		AttributeTag.Create<BooleanValue>(0, "noThreeD2"),
		AttributeTag.Create<UInt32Value>(0, "page"),
		AttributeTag.Create<UInt32Value>(0, "sel"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SelectionTypeValues>>(0, "seltype"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.TextHorizontalAlignmentValues>>(0, "textHAlign"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.TextVerticalAlignmentValues>>(0, "textVAlign"),
		AttributeTag.Create<UInt32Value>(0, "val"),
		AttributeTag.Create<UInt32Value>(0, "widthMin"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.EditValidationValues>>(0, "editVal"),
		AttributeTag.Create<BooleanValue>(0, "multiLine"),
		AttributeTag.Create<BooleanValue>(0, "verticalBar"),
		AttributeTag.Create<BooleanValue>(0, "passwordEdit")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> objectType.</para>
    /// <para>Represents the following attribute in the schema: objectType </para>
    /// </summary>
    [SchemaAttr(0, "objectType")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.ObjectTypeValues> ObjectType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.ObjectTypeValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> checked.</para>
    /// <para>Represents the following attribute in the schema: checked </para>
    /// </summary>
    [SchemaAttr(0, "checked")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.CheckedValues> Checked
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.CheckedValues>)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> colored.</para>
    /// <para>Represents the following attribute in the schema: colored </para>
    /// </summary>
    [SchemaAttr(0, "colored")]
    public BooleanValue Colored
    {
        get { return (BooleanValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> dropLines.</para>
    /// <para>Represents the following attribute in the schema: dropLines </para>
    /// </summary>
    [SchemaAttr(0, "dropLines")]
    public UInt32Value DropLines
    {
        get { return (UInt32Value)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> dropStyle.</para>
    /// <para>Represents the following attribute in the schema: dropStyle </para>
    /// </summary>
    [SchemaAttr(0, "dropStyle")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.DropStyleValues> DropStyle
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.DropStyleValues>)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> dx.</para>
    /// <para>Represents the following attribute in the schema: dx </para>
    /// </summary>
    [SchemaAttr(0, "dx")]
    public UInt32Value ScrollBarWidth
    {
        get { return (UInt32Value)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> firstButton.</para>
    /// <para>Represents the following attribute in the schema: firstButton </para>
    /// </summary>
    [SchemaAttr(0, "firstButton")]
    public BooleanValue FirstButton
    {
        get { return (BooleanValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> fmlaGroup.</para>
    /// <para>Represents the following attribute in the schema: fmlaGroup </para>
    /// </summary>
    [SchemaAttr(0, "fmlaGroup")]
    public StringValue FmlaGroup
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> fmlaLink.</para>
    /// <para>Represents the following attribute in the schema: fmlaLink </para>
    /// </summary>
    [SchemaAttr(0, "fmlaLink")]
    public StringValue FmlaLink
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> fmlaRange.</para>
    /// <para>Represents the following attribute in the schema: fmlaRange </para>
    /// </summary>
    [SchemaAttr(0, "fmlaRange")]
    public StringValue FmlaRange
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> fmlaTxbx.</para>
    /// <para>Represents the following attribute in the schema: fmlaTxbx </para>
    /// </summary>
    [SchemaAttr(0, "fmlaTxbx")]
    public StringValue FmlaTextbox
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> horiz.</para>
    /// <para>Represents the following attribute in the schema: horiz </para>
    /// </summary>
    [SchemaAttr(0, "horiz")]
    public BooleanValue Horizontal
    {
        get { return (BooleanValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> inc.</para>
    /// <para>Represents the following attribute in the schema: inc </para>
    /// </summary>
    [SchemaAttr(0, "inc")]
    public UInt32Value Incremental
    {
        get { return (UInt32Value)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> justLastX.</para>
    /// <para>Represents the following attribute in the schema: justLastX </para>
    /// </summary>
    [SchemaAttr(0, "justLastX")]
    public BooleanValue JustLastX
    {
        get { return (BooleanValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> lockText.</para>
    /// <para>Represents the following attribute in the schema: lockText </para>
    /// </summary>
    [SchemaAttr(0, "lockText")]
    public BooleanValue LockText
    {
        get { return (BooleanValue)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> max.</para>
    /// <para>Represents the following attribute in the schema: max </para>
    /// </summary>
    [SchemaAttr(0, "max")]
    public UInt32Value Max
    {
        get { return (UInt32Value)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> min.</para>
    /// <para>Represents the following attribute in the schema: min </para>
    /// </summary>
    [SchemaAttr(0, "min")]
    public UInt32Value Min
    {
        get { return (UInt32Value)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    
    /// <summary>
    /// <para> multiSel.</para>
    /// <para>Represents the following attribute in the schema: multiSel </para>
    /// </summary>
    [SchemaAttr(0, "multiSel")]
    public StringValue MultipleSelection
    {
        get { return (StringValue)Attributes[17].Value; }
        set { Attributes[17].Value = value; }
    }
    
    /// <summary>
    /// <para> noThreeD.</para>
    /// <para>Represents the following attribute in the schema: noThreeD </para>
    /// </summary>
    [SchemaAttr(0, "noThreeD")]
    public BooleanValue NoThreeD
    {
        get { return (BooleanValue)Attributes[18].Value; }
        set { Attributes[18].Value = value; }
    }
    
    /// <summary>
    /// <para> noThreeD2.</para>
    /// <para>Represents the following attribute in the schema: noThreeD2 </para>
    /// </summary>
    [SchemaAttr(0, "noThreeD2")]
    public BooleanValue NoThreeD2
    {
        get { return (BooleanValue)Attributes[19].Value; }
        set { Attributes[19].Value = value; }
    }
    
    /// <summary>
    /// <para> page.</para>
    /// <para>Represents the following attribute in the schema: page </para>
    /// </summary>
    [SchemaAttr(0, "page")]
    public UInt32Value Page
    {
        get { return (UInt32Value)Attributes[20].Value; }
        set { Attributes[20].Value = value; }
    }
    
    /// <summary>
    /// <para> sel.</para>
    /// <para>Represents the following attribute in the schema: sel </para>
    /// </summary>
    [SchemaAttr(0, "sel")]
    public UInt32Value Selected
    {
        get { return (UInt32Value)Attributes[21].Value; }
        set { Attributes[21].Value = value; }
    }
    
    /// <summary>
    /// <para> seltype.</para>
    /// <para>Represents the following attribute in the schema: seltype </para>
    /// </summary>
    [SchemaAttr(0, "seltype")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SelectionTypeValues> SelectionType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SelectionTypeValues>)Attributes[22].Value; }
        set { Attributes[22].Value = value; }
    }
    
    /// <summary>
    /// <para> textHAlign.</para>
    /// <para>Represents the following attribute in the schema: textHAlign </para>
    /// </summary>
    [SchemaAttr(0, "textHAlign")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.TextHorizontalAlignmentValues> TextHorizontalAlign
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.TextHorizontalAlignmentValues>)Attributes[23].Value; }
        set { Attributes[23].Value = value; }
    }
    
    /// <summary>
    /// <para> textVAlign.</para>
    /// <para>Represents the following attribute in the schema: textVAlign </para>
    /// </summary>
    [SchemaAttr(0, "textVAlign")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.TextVerticalAlignmentValues> TextVerticalAlign
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.TextVerticalAlignmentValues>)Attributes[24].Value; }
        set { Attributes[24].Value = value; }
    }
    
    /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public UInt32Value Val
    {
        get { return (UInt32Value)Attributes[25].Value; }
        set { Attributes[25].Value = value; }
    }
    
    /// <summary>
    /// <para> widthMin.</para>
    /// <para>Represents the following attribute in the schema: widthMin </para>
    /// </summary>
    [SchemaAttr(0, "widthMin")]
    public UInt32Value MinimumWidth
    {
        get { return (UInt32Value)Attributes[26].Value; }
        set { Attributes[26].Value = value; }
    }
    
    /// <summary>
    /// <para> editVal.</para>
    /// <para>Represents the following attribute in the schema: editVal </para>
    /// </summary>
    [SchemaAttr(0, "editVal")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.EditValidationValues> EditVal
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.EditValidationValues>)Attributes[27].Value; }
        set { Attributes[27].Value = value; }
    }
    
    /// <summary>
    /// <para> multiLine.</para>
    /// <para>Represents the following attribute in the schema: multiLine </para>
    /// </summary>
    [SchemaAttr(0, "multiLine")]
    public BooleanValue MultipleLines
    {
        get { return (BooleanValue)Attributes[28].Value; }
        set { Attributes[28].Value = value; }
    }
    
    /// <summary>
    /// <para> verticalBar.</para>
    /// <para>Represents the following attribute in the schema: verticalBar </para>
    /// </summary>
    [SchemaAttr(0, "verticalBar")]
    public BooleanValue VerticalBar
    {
        get { return (BooleanValue)Attributes[29].Value; }
        set { Attributes[29].Value = value; }
    }
    
    /// <summary>
    /// <para> passwordEdit.</para>
    /// <para>Represents the following attribute in the schema: passwordEdit </para>
    /// </summary>
    [SchemaAttr(0, "passwordEdit")]
    public BooleanValue PasswordEdit
    {
        get { return (BooleanValue)Attributes[30].Value; }
        set { Attributes[30].Value = value; }
    }
    

    
	internal FormControlProperties(ControlPropertiesPart ownerPart) : base (ownerPart){}
    
    /// <summary>
    /// Loads the DOM from the ControlPropertiesPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(ControlPropertiesPart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the ControlPropertiesPart associated with this element.
    /// </summary>
    public ControlPropertiesPart ControlPropertiesPart
    {
		get => OpenXmlPart as ControlPropertiesPart;
		internal set => OpenXmlPart = value;
    }
    
        /// <summary>
    ///Initializes a new instance of the FormControlProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FormControlProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the FormControlProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FormControlProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the FormControlProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public FormControlProperties(string outerXml)
        : base(outerXml)
    {
    }

    
    
    /// <summary>
    /// Initializes a new instance of the FormControlProperties class.
    /// </summary>
    public FormControlProperties():base(){}
    
    /// <summary>
    /// Saves the DOM into the ControlPropertiesPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(ControlPropertiesPart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "itemLst" == name)
    return new ListItems();
    
if( 53 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "itemLst","extLst" };
    private static readonly byte[] eleNamespaceIds = { 53,53 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ListItems.</para>
    /// <para> Represents the following element tag in the schema: x14:itemLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public ListItems ListItems
    {
        get => GetElement<ListItems>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: x14:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public ExtensionList ExtensionList
    {
        get => GetElement<ExtensionList>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FormControlProperties>(deep);

}
/// <summary>
/// <para>Defines the Slicers Class. The root element of SlicersPart.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:slicers.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Slicer &lt;x14:slicer></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Slicer), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Slicers : OpenXmlPartRootElement
{
    internal const int ElementTypeIdConst = 12993;
    /// <inheritdoc/>
    public override string LocalName => "slicers";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    
	internal Slicers(SlicersPart ownerPart) : base (ownerPart){}
    
    /// <summary>
    /// Loads the DOM from the SlicersPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(SlicersPart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the SlicersPart associated with this element.
    /// </summary>
    public SlicersPart SlicersPart
    {
		get => OpenXmlPart as SlicersPart;
		internal set => OpenXmlPart = value;
    }
    
        /// <summary>
    ///Initializes a new instance of the Slicers class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Slicers(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Slicers class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Slicers(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Slicers class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Slicers(string outerXml)
        : base(outerXml)
    {
    }

    
    
    /// <summary>
    /// Initializes a new instance of the Slicers class.
    /// </summary>
    public Slicers():base(){}
    
    /// <summary>
    /// Saves the DOM into the SlicersPart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(SlicersPart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "slicer" == name)
    return new Slicer();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Slicers>(deep);

}
/// <summary>
/// <para>Defines the SlicerCacheDefinition Class. The root element of SlicerCachePart.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:slicerCacheDefinition.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SlicerCachePivotTables &lt;x14:pivotTables></description></item>
///<item><description>SlicerCacheData &lt;x14:data></description></item>
///<item><description>SlicerCacheDefinitionExtensionList &lt;x14:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(SlicerCachePivotTables), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SlicerCacheData), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(SlicerCacheDefinitionExtensionList), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SlicerCacheDefinition : OpenXmlPartRootElement
{
    internal const int ElementTypeIdConst = 12994;
    /// <inheritdoc/>
    public override string LocalName => "slicerCacheDefinition";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "name"),
		AttributeTag.Create<StringValue>(0, "sourceName")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> sourceName.</para>
    /// <para>Represents the following attribute in the schema: sourceName </para>
    /// </summary>
    [SchemaAttr(0, "sourceName")]
    public StringValue SourceName
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    
	internal SlicerCacheDefinition(SlicerCachePart ownerPart) : base (ownerPart){}
    
    /// <summary>
    /// Loads the DOM from the SlicerCachePart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to be loaded.</param>
    public void Load(SlicerCachePart openXmlPart)
    {
        LoadFromPart(openXmlPart);
    }
    /// <summary>
    /// Gets the SlicerCachePart associated with this element.
    /// </summary>
    public SlicerCachePart SlicerCachePart
    {
		get => OpenXmlPart as SlicerCachePart;
		internal set => OpenXmlPart = value;
    }
    
        /// <summary>
    ///Initializes a new instance of the SlicerCacheDefinition class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SlicerCacheDefinition(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SlicerCacheDefinition class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SlicerCacheDefinition(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SlicerCacheDefinition class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SlicerCacheDefinition(string outerXml)
        : base(outerXml)
    {
    }

    
    
    /// <summary>
    /// Initializes a new instance of the SlicerCacheDefinition class.
    /// </summary>
    public SlicerCacheDefinition():base(){}
    
    /// <summary>
    /// Saves the DOM into the SlicerCachePart.
    /// </summary>
    /// <param name="openXmlPart">Specifies the part to save to.</param>
    public void Save(SlicerCachePart openXmlPart)
    {
        base.SaveToPart(openXmlPart);
    }
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "pivotTables" == name)
    return new SlicerCachePivotTables();
    
if( 53 == namespaceId && "data" == name)
    return new SlicerCacheData();
    
if( 53 == namespaceId && "extLst" == name)
    return new SlicerCacheDefinitionExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "pivotTables","data","extLst" };
    private static readonly byte[] eleNamespaceIds = { 53,53,53 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> SlicerCachePivotTables.</para>
    /// <para> Represents the following element tag in the schema: x14:pivotTables </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public SlicerCachePivotTables SlicerCachePivotTables
    {
        get => GetElement<SlicerCachePivotTables>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> SlicerCacheData.</para>
    /// <para> Represents the following element tag in the schema: x14:data </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public SlicerCacheData SlicerCacheData
    {
        get => GetElement<SlicerCacheData>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> SlicerCacheDefinitionExtensionList.</para>
    /// <para> Represents the following element tag in the schema: x14:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public SlicerCacheDefinitionExtensionList SlicerCacheDefinitionExtensionList
    {
        get => GetElement<SlicerCacheDefinitionExtensionList>(2);
        set => SetElement(2, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerCacheDefinition>(deep);

}
/// <summary>
/// <para>Defines the ConditionalFormatting Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:conditionalFormatting.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ConditionalFormattingRule &lt;x14:cfRule></description></item>
///<item><description>DocumentFormat.OpenXml.Office.Excel.ReferenceSequence &lt;xne:sqref></description></item>
///<item><description>ExtensionList &lt;x14:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ConditionalFormattingRule), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office.Excel.ReferenceSequence))]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ConditionalFormatting : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12995;
    /// <inheritdoc/>
    public override string LocalName => "conditionalFormatting";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "pivot")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> pivot.</para>
    /// <para>Represents the following attribute in the schema: pivot </para>
    /// </summary>
    [SchemaAttr(0, "pivot")]
    public BooleanValue Pivot
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ConditionalFormatting class.
    /// </summary>
    public ConditionalFormatting():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ConditionalFormatting class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ConditionalFormatting(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ConditionalFormatting class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ConditionalFormatting(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ConditionalFormatting class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ConditionalFormatting(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "cfRule" == name)
    return new ConditionalFormattingRule();
    
if( 32 == namespaceId && "sqref" == name)
    return new DocumentFormat.OpenXml.Office.Excel.ReferenceSequence();
    
if( 53 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConditionalFormatting>(deep);

}
/// <summary>
/// <para>Defines the ConditionalFormattingRule Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:cfRule.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office.Excel.Formula &lt;xne:f></description></item>
///<item><description>ColorScale &lt;x14:colorScale></description></item>
///<item><description>DataBar &lt;x14:dataBar></description></item>
///<item><description>IconSet &lt;x14:iconSet></description></item>
///<item><description>DifferentialType &lt;x14:dxf></description></item>
///<item><description>ExtensionList &lt;x14:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office.Excel.Formula))]
    [ChildElementInfo(typeof(ColorScale), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DataBar), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(IconSet), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DifferentialType), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ConditionalFormattingRule : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12996;
    /// <inheritdoc/>
    public override string LocalName => "cfRule";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Spreadsheet.ConditionalFormatValues>>(0, "type"),
		AttributeTag.Create<Int32Value>(0, "priority"),
		AttributeTag.Create<BooleanValue>(0, "stopIfTrue"),
		AttributeTag.Create<BooleanValue>(0, "aboveAverage"),
		AttributeTag.Create<BooleanValue>(0, "percent"),
		AttributeTag.Create<BooleanValue>(0, "bottom"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Spreadsheet.ConditionalFormattingOperatorValues>>(0, "operator"),
		AttributeTag.Create<StringValue>(0, "text"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Spreadsheet.TimePeriodValues>>(0, "timePeriod"),
		AttributeTag.Create<UInt32Value>(0, "rank"),
		AttributeTag.Create<Int32Value>(0, "stdDev"),
		AttributeTag.Create<BooleanValue>(0, "equalAverage"),
		AttributeTag.Create<BooleanValue>(0, "activePresent"),
		AttributeTag.Create<StringValue>(0, "id")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public EnumValue<DocumentFormat.OpenXml.Spreadsheet.ConditionalFormatValues> Type
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Spreadsheet.ConditionalFormatValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> priority.</para>
    /// <para>Represents the following attribute in the schema: priority </para>
    /// </summary>
    [SchemaAttr(0, "priority")]
    public Int32Value Priority
    {
        get { return (Int32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> stopIfTrue.</para>
    /// <para>Represents the following attribute in the schema: stopIfTrue </para>
    /// </summary>
    [SchemaAttr(0, "stopIfTrue")]
    public BooleanValue StopIfTrue
    {
        get { return (BooleanValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> aboveAverage.</para>
    /// <para>Represents the following attribute in the schema: aboveAverage </para>
    /// </summary>
    [SchemaAttr(0, "aboveAverage")]
    public BooleanValue AboveAverage
    {
        get { return (BooleanValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> percent.</para>
    /// <para>Represents the following attribute in the schema: percent </para>
    /// </summary>
    [SchemaAttr(0, "percent")]
    public BooleanValue Percent
    {
        get { return (BooleanValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> bottom.</para>
    /// <para>Represents the following attribute in the schema: bottom </para>
    /// </summary>
    [SchemaAttr(0, "bottom")]
    public BooleanValue Bottom
    {
        get { return (BooleanValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> operator.</para>
    /// <para>Represents the following attribute in the schema: operator </para>
    /// </summary>
    [SchemaAttr(0, "operator")]
    public EnumValue<DocumentFormat.OpenXml.Spreadsheet.ConditionalFormattingOperatorValues> Operator
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Spreadsheet.ConditionalFormattingOperatorValues>)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> text.</para>
    /// <para>Represents the following attribute in the schema: text </para>
    /// </summary>
    [SchemaAttr(0, "text")]
    public StringValue Text
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> timePeriod.</para>
    /// <para>Represents the following attribute in the schema: timePeriod </para>
    /// </summary>
    [SchemaAttr(0, "timePeriod")]
    public EnumValue<DocumentFormat.OpenXml.Spreadsheet.TimePeriodValues> TimePeriod
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Spreadsheet.TimePeriodValues>)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> rank.</para>
    /// <para>Represents the following attribute in the schema: rank </para>
    /// </summary>
    [SchemaAttr(0, "rank")]
    public UInt32Value Rank
    {
        get { return (UInt32Value)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> stdDev.</para>
    /// <para>Represents the following attribute in the schema: stdDev </para>
    /// </summary>
    [SchemaAttr(0, "stdDev")]
    public Int32Value StandardDeviation
    {
        get { return (Int32Value)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> equalAverage.</para>
    /// <para>Represents the following attribute in the schema: equalAverage </para>
    /// </summary>
    [SchemaAttr(0, "equalAverage")]
    public BooleanValue EqualAverage
    {
        get { return (BooleanValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> activePresent.</para>
    /// <para>Represents the following attribute in the schema: activePresent </para>
    /// </summary>
    [SchemaAttr(0, "activePresent")]
    public BooleanValue ActivePresent
    {
        get { return (BooleanValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ConditionalFormattingRule class.
    /// </summary>
    public ConditionalFormattingRule():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ConditionalFormattingRule class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ConditionalFormattingRule(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ConditionalFormattingRule class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ConditionalFormattingRule(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ConditionalFormattingRule class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ConditionalFormattingRule(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 32 == namespaceId && "f" == name)
    return new DocumentFormat.OpenXml.Office.Excel.Formula();
    
if( 53 == namespaceId && "colorScale" == name)
    return new ColorScale();
    
if( 53 == namespaceId && "dataBar" == name)
    return new DataBar();
    
if( 53 == namespaceId && "iconSet" == name)
    return new IconSet();
    
if( 53 == namespaceId && "dxf" == name)
    return new DifferentialType();
    
if( 53 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConditionalFormattingRule>(deep);

}
/// <summary>
/// <para>Defines the ExtensionList Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Spreadsheet.Extension &lt;x:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Extension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12997;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ExtensionList class.
    /// </summary>
    public ExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 22 == namespaceId && "ext" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.Extension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtensionList>(deep);

}
/// <summary>
/// <para>Defines the DataValidation Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:dataValidation.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DataValidationForumla1 &lt;x14:formula1></description></item>
///<item><description>DataValidationForumla2 &lt;x14:formula2></description></item>
///<item><description>DocumentFormat.OpenXml.Office.Excel.ReferenceSequence &lt;xne:sqref></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DataValidationForumla1), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DataValidationForumla2), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office.Excel.ReferenceSequence))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class DataValidation : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 12998;
    /// <inheritdoc/>
    public override string LocalName => "dataValidation";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationValues>>(0, "type"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationErrorStyleValues>>(0, "errorStyle"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationImeModeValues>>(0, "imeMode"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationOperatorValues>>(0, "operator"),
		AttributeTag.Create<BooleanValue>(0, "allowBlank"),
		AttributeTag.Create<BooleanValue>(0, "showDropDown"),
		AttributeTag.Create<BooleanValue>(0, "showInputMessage"),
		AttributeTag.Create<BooleanValue>(0, "showErrorMessage"),
		AttributeTag.Create<StringValue>(0, "errorTitle"),
		AttributeTag.Create<StringValue>(0, "error"),
		AttributeTag.Create<StringValue>(0, "promptTitle"),
		AttributeTag.Create<StringValue>(0, "prompt")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationValues> Type
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> errorStyle.</para>
    /// <para>Represents the following attribute in the schema: errorStyle </para>
    /// </summary>
    [SchemaAttr(0, "errorStyle")]
    public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationErrorStyleValues> ErrorStyle
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationErrorStyleValues>)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> imeMode.</para>
    /// <para>Represents the following attribute in the schema: imeMode </para>
    /// </summary>
    [SchemaAttr(0, "imeMode")]
    public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationImeModeValues> ImeMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationImeModeValues>)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> operator.</para>
    /// <para>Represents the following attribute in the schema: operator </para>
    /// </summary>
    [SchemaAttr(0, "operator")]
    public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationOperatorValues> Operator
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationOperatorValues>)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> allowBlank.</para>
    /// <para>Represents the following attribute in the schema: allowBlank </para>
    /// </summary>
    [SchemaAttr(0, "allowBlank")]
    public BooleanValue AllowBlank
    {
        get { return (BooleanValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> showDropDown.</para>
    /// <para>Represents the following attribute in the schema: showDropDown </para>
    /// </summary>
    [SchemaAttr(0, "showDropDown")]
    public BooleanValue ShowDropDown
    {
        get { return (BooleanValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> showInputMessage.</para>
    /// <para>Represents the following attribute in the schema: showInputMessage </para>
    /// </summary>
    [SchemaAttr(0, "showInputMessage")]
    public BooleanValue ShowInputMessage
    {
        get { return (BooleanValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> showErrorMessage.</para>
    /// <para>Represents the following attribute in the schema: showErrorMessage </para>
    /// </summary>
    [SchemaAttr(0, "showErrorMessage")]
    public BooleanValue ShowErrorMessage
    {
        get { return (BooleanValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> errorTitle.</para>
    /// <para>Represents the following attribute in the schema: errorTitle </para>
    /// </summary>
    [SchemaAttr(0, "errorTitle")]
    public StringValue ErrorTitle
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> error.</para>
    /// <para>Represents the following attribute in the schema: error </para>
    /// </summary>
    [SchemaAttr(0, "error")]
    public StringValue Error
    {
        get { return (StringValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> promptTitle.</para>
    /// <para>Represents the following attribute in the schema: promptTitle </para>
    /// </summary>
    [SchemaAttr(0, "promptTitle")]
    public StringValue PromptTitle
    {
        get { return (StringValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> prompt.</para>
    /// <para>Represents the following attribute in the schema: prompt </para>
    /// </summary>
    [SchemaAttr(0, "prompt")]
    public StringValue Prompt
    {
        get { return (StringValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DataValidation class.
    /// </summary>
    public DataValidation():base(){}
    
        /// <summary>
    ///Initializes a new instance of the DataValidation class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataValidation(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataValidation class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataValidation(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataValidation class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataValidation(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "formula1" == name)
    return new DataValidationForumla1();
    
if( 53 == namespaceId && "formula2" == name)
    return new DataValidationForumla2();
    
if( 32 == namespaceId && "sqref" == name)
    return new DocumentFormat.OpenXml.Office.Excel.ReferenceSequence();
    

    return null;
}

        private static readonly string[] eleTagNames = { "formula1","formula2","sqref" };
    private static readonly byte[] eleNamespaceIds = { 53,53,32 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> DataValidationForumla1.</para>
    /// <para> Represents the following element tag in the schema: x14:formula1 </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public DataValidationForumla1 DataValidationForumla1
    {
        get => GetElement<DataValidationForumla1>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> DataValidationForumla2.</para>
    /// <para> Represents the following element tag in the schema: x14:formula2 </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public DataValidationForumla2 DataValidationForumla2
    {
        get => GetElement<DataValidationForumla2>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> ReferenceSequence.</para>
    /// <para> Represents the following element tag in the schema: xne:sqref </para>
    /// </summary>
    /// <remark>
    /// xmlns:xne = http://schemas.microsoft.com/office/excel/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Office.Excel.ReferenceSequence ReferenceSequence
    {
        get => GetElement<DocumentFormat.OpenXml.Office.Excel.ReferenceSequence>(2);
        set => SetElement(2, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataValidation>(deep);

}
/// <summary>
/// <para>Defines the DataValidationForumla1 Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:formula1.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office.Excel.Formula &lt;xne:f></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class DataValidationForumla1 : DataValidationFormulaType
{
    internal const int ElementTypeIdConst = 12999;
    /// <inheritdoc/>
    public override string LocalName => "formula1";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the DataValidationForumla1 class.
    /// </summary>
    public DataValidationForumla1():base(){}
        /// <summary>
    ///Initializes a new instance of the DataValidationForumla1 class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataValidationForumla1(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataValidationForumla1 class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataValidationForumla1(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataValidationForumla1 class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataValidationForumla1(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataValidationForumla1>(deep);

}
/// <summary>
/// <para>Defines the DataValidationForumla2 Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:formula2.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office.Excel.Formula &lt;xne:f></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class DataValidationForumla2 : DataValidationFormulaType
{
    internal const int ElementTypeIdConst = 13000;
    /// <inheritdoc/>
    public override string LocalName => "formula2";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the DataValidationForumla2 class.
    /// </summary>
    public DataValidationForumla2():base(){}
        /// <summary>
    ///Initializes a new instance of the DataValidationForumla2 class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataValidationForumla2(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataValidationForumla2 class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataValidationForumla2(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataValidationForumla2 class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataValidationForumla2(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataValidationForumla2>(deep);

}
/// <summary>
/// Defines the DataValidationFormulaType class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office.Excel.Formula &lt;xne:f></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office.Excel.Formula))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class DataValidationFormulaType : OpenXmlCompositeElement
{
        
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 32 == namespaceId && "f" == name)
    return new DocumentFormat.OpenXml.Office.Excel.Formula();
    

    return null;
}

        private static readonly string[] eleTagNames = { "f" };
    private static readonly byte[] eleNamespaceIds = { 32 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Formula.</para>
    /// <para> Represents the following element tag in the schema: xne:f </para>
    /// </summary>
    /// <remark>
    /// xmlns:xne = http://schemas.microsoft.com/office/excel/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Office.Excel.Formula Formula
    {
        get => GetElement<DocumentFormat.OpenXml.Office.Excel.Formula>(0);
        set => SetElement(0, value);
    }


    
    /// <summary>
    /// Initializes a new instance of the DataValidationFormulaType class.
    /// </summary>
    protected DataValidationFormulaType(){}
    
        /// <summary>
    ///Initializes a new instance of the DataValidationFormulaType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected DataValidationFormulaType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataValidationFormulaType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected DataValidationFormulaType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataValidationFormulaType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected DataValidationFormulaType(string outerXml)
        : base(outerXml)
    {
    }

    
}
/// <summary>
/// <para>Defines the SparklineGroup Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:sparklineGroup.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SeriesColor &lt;x14:colorSeries></description></item>
///<item><description>NegativeColor &lt;x14:colorNegative></description></item>
///<item><description>AxisColor &lt;x14:colorAxis></description></item>
///<item><description>MarkersColor &lt;x14:colorMarkers></description></item>
///<item><description>FirstMarkerColor &lt;x14:colorFirst></description></item>
///<item><description>LastMarkerColor &lt;x14:colorLast></description></item>
///<item><description>HighMarkerColor &lt;x14:colorHigh></description></item>
///<item><description>LowMarkerColor &lt;x14:colorLow></description></item>
///<item><description>DocumentFormat.OpenXml.Office.Excel.Formula &lt;xne:f></description></item>
///<item><description>Sparklines &lt;x14:sparklines></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SeriesColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(NegativeColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(AxisColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(MarkersColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(FirstMarkerColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(LastMarkerColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(HighMarkerColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(LowMarkerColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office.Excel.Formula))]
    [ChildElementInfo(typeof(Sparklines), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SparklineGroup : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13001;
    /// <inheritdoc/>
    public override string LocalName => "sparklineGroup";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<DoubleValue>(0, "manualMax"),
		AttributeTag.Create<DoubleValue>(0, "manualMin"),
		AttributeTag.Create<DoubleValue>(0, "lineWeight"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineTypeValues>>(0, "type"),
		AttributeTag.Create<BooleanValue>(0, "dateAxis"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.DisplayBlanksAsValues>>(0, "displayEmptyCellsAs"),
		AttributeTag.Create<BooleanValue>(0, "markers"),
		AttributeTag.Create<BooleanValue>(0, "high"),
		AttributeTag.Create<BooleanValue>(0, "low"),
		AttributeTag.Create<BooleanValue>(0, "first"),
		AttributeTag.Create<BooleanValue>(0, "last"),
		AttributeTag.Create<BooleanValue>(0, "negative"),
		AttributeTag.Create<BooleanValue>(0, "displayXAxis"),
		AttributeTag.Create<BooleanValue>(0, "displayHidden"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineAxisMinMaxValues>>(0, "minAxisType"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineAxisMinMaxValues>>(0, "maxAxisType"),
		AttributeTag.Create<BooleanValue>(0, "rightToLeft")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> manualMax.</para>
    /// <para>Represents the following attribute in the schema: manualMax </para>
    /// </summary>
    [SchemaAttr(0, "manualMax")]
    public DoubleValue ManualMax
    {
        get { return (DoubleValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> manualMin.</para>
    /// <para>Represents the following attribute in the schema: manualMin </para>
    /// </summary>
    [SchemaAttr(0, "manualMin")]
    public DoubleValue ManualMin
    {
        get { return (DoubleValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> lineWeight.</para>
    /// <para>Represents the following attribute in the schema: lineWeight </para>
    /// </summary>
    [SchemaAttr(0, "lineWeight")]
    public DoubleValue LineWeight
    {
        get { return (DoubleValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineTypeValues> Type
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineTypeValues>)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> dateAxis.</para>
    /// <para>Represents the following attribute in the schema: dateAxis </para>
    /// </summary>
    [SchemaAttr(0, "dateAxis")]
    public BooleanValue DateAxis
    {
        get { return (BooleanValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> displayEmptyCellsAs.</para>
    /// <para>Represents the following attribute in the schema: displayEmptyCellsAs </para>
    /// </summary>
    [SchemaAttr(0, "displayEmptyCellsAs")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.DisplayBlanksAsValues> DisplayEmptyCellsAs
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.DisplayBlanksAsValues>)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> markers.</para>
    /// <para>Represents the following attribute in the schema: markers </para>
    /// </summary>
    [SchemaAttr(0, "markers")]
    public BooleanValue Markers
    {
        get { return (BooleanValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> high.</para>
    /// <para>Represents the following attribute in the schema: high </para>
    /// </summary>
    [SchemaAttr(0, "high")]
    public BooleanValue High
    {
        get { return (BooleanValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> low.</para>
    /// <para>Represents the following attribute in the schema: low </para>
    /// </summary>
    [SchemaAttr(0, "low")]
    public BooleanValue Low
    {
        get { return (BooleanValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> first.</para>
    /// <para>Represents the following attribute in the schema: first </para>
    /// </summary>
    [SchemaAttr(0, "first")]
    public BooleanValue First
    {
        get { return (BooleanValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> last.</para>
    /// <para>Represents the following attribute in the schema: last </para>
    /// </summary>
    [SchemaAttr(0, "last")]
    public BooleanValue Last
    {
        get { return (BooleanValue)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> negative.</para>
    /// <para>Represents the following attribute in the schema: negative </para>
    /// </summary>
    [SchemaAttr(0, "negative")]
    public BooleanValue Negative
    {
        get { return (BooleanValue)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    
    /// <summary>
    /// <para> displayXAxis.</para>
    /// <para>Represents the following attribute in the schema: displayXAxis </para>
    /// </summary>
    [SchemaAttr(0, "displayXAxis")]
    public BooleanValue DisplayXAxis
    {
        get { return (BooleanValue)Attributes[12].Value; }
        set { Attributes[12].Value = value; }
    }
    
    /// <summary>
    /// <para> displayHidden.</para>
    /// <para>Represents the following attribute in the schema: displayHidden </para>
    /// </summary>
    [SchemaAttr(0, "displayHidden")]
    public BooleanValue DisplayHidden
    {
        get { return (BooleanValue)Attributes[13].Value; }
        set { Attributes[13].Value = value; }
    }
    
    /// <summary>
    /// <para> minAxisType.</para>
    /// <para>Represents the following attribute in the schema: minAxisType </para>
    /// </summary>
    [SchemaAttr(0, "minAxisType")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineAxisMinMaxValues> MinAxisType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineAxisMinMaxValues>)Attributes[14].Value; }
        set { Attributes[14].Value = value; }
    }
    
    /// <summary>
    /// <para> maxAxisType.</para>
    /// <para>Represents the following attribute in the schema: maxAxisType </para>
    /// </summary>
    [SchemaAttr(0, "maxAxisType")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineAxisMinMaxValues> MaxAxisType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineAxisMinMaxValues>)Attributes[15].Value; }
        set { Attributes[15].Value = value; }
    }
    
    /// <summary>
    /// <para> rightToLeft.</para>
    /// <para>Represents the following attribute in the schema: rightToLeft </para>
    /// </summary>
    [SchemaAttr(0, "rightToLeft")]
    public BooleanValue RightToLeft
    {
        get { return (BooleanValue)Attributes[16].Value; }
        set { Attributes[16].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SparklineGroup class.
    /// </summary>
    public SparklineGroup():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SparklineGroup class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SparklineGroup(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SparklineGroup class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SparklineGroup(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SparklineGroup class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SparklineGroup(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "colorSeries" == name)
    return new SeriesColor();
    
if( 53 == namespaceId && "colorNegative" == name)
    return new NegativeColor();
    
if( 53 == namespaceId && "colorAxis" == name)
    return new AxisColor();
    
if( 53 == namespaceId && "colorMarkers" == name)
    return new MarkersColor();
    
if( 53 == namespaceId && "colorFirst" == name)
    return new FirstMarkerColor();
    
if( 53 == namespaceId && "colorLast" == name)
    return new LastMarkerColor();
    
if( 53 == namespaceId && "colorHigh" == name)
    return new HighMarkerColor();
    
if( 53 == namespaceId && "colorLow" == name)
    return new LowMarkerColor();
    
if( 32 == namespaceId && "f" == name)
    return new DocumentFormat.OpenXml.Office.Excel.Formula();
    
if( 53 == namespaceId && "sparklines" == name)
    return new Sparklines();
    

    return null;
}

        private static readonly string[] eleTagNames = { "colorSeries","colorNegative","colorAxis","colorMarkers","colorFirst","colorLast","colorHigh","colorLow","f","sparklines" };
    private static readonly byte[] eleNamespaceIds = { 53,53,53,53,53,53,53,53,32,53 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> SeriesColor.</para>
    /// <para> Represents the following element tag in the schema: x14:colorSeries </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public SeriesColor SeriesColor
    {
        get => GetElement<SeriesColor>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> NegativeColor.</para>
    /// <para> Represents the following element tag in the schema: x14:colorNegative </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public NegativeColor NegativeColor
    {
        get => GetElement<NegativeColor>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> AxisColor.</para>
    /// <para> Represents the following element tag in the schema: x14:colorAxis </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public AxisColor AxisColor
    {
        get => GetElement<AxisColor>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> MarkersColor.</para>
    /// <para> Represents the following element tag in the schema: x14:colorMarkers </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public MarkersColor MarkersColor
    {
        get => GetElement<MarkersColor>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> FirstMarkerColor.</para>
    /// <para> Represents the following element tag in the schema: x14:colorFirst </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public FirstMarkerColor FirstMarkerColor
    {
        get => GetElement<FirstMarkerColor>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> LastMarkerColor.</para>
    /// <para> Represents the following element tag in the schema: x14:colorLast </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public LastMarkerColor LastMarkerColor
    {
        get => GetElement<LastMarkerColor>(5);
        set => SetElement(5, value);
    }
    /// <summary>
    /// <para> HighMarkerColor.</para>
    /// <para> Represents the following element tag in the schema: x14:colorHigh </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public HighMarkerColor HighMarkerColor
    {
        get => GetElement<HighMarkerColor>(6);
        set => SetElement(6, value);
    }
    /// <summary>
    /// <para> LowMarkerColor.</para>
    /// <para> Represents the following element tag in the schema: x14:colorLow </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public LowMarkerColor LowMarkerColor
    {
        get => GetElement<LowMarkerColor>(7);
        set => SetElement(7, value);
    }
    /// <summary>
    /// <para> Formula.</para>
    /// <para> Represents the following element tag in the schema: xne:f </para>
    /// </summary>
    /// <remark>
    /// xmlns:xne = http://schemas.microsoft.com/office/excel/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Office.Excel.Formula Formula
    {
        get => GetElement<DocumentFormat.OpenXml.Office.Excel.Formula>(8);
        set => SetElement(8, value);
    }
    /// <summary>
    /// <para> Sparklines.</para>
    /// <para> Represents the following element tag in the schema: x14:sparklines </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public Sparklines Sparklines
    {
        get => GetElement<Sparklines>(9);
        set => SetElement(9, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SparklineGroup>(deep);

}
/// <summary>
/// <para>Defines the SeriesColor Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:colorSeries.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SeriesColor : ColorType
{
    internal const int ElementTypeIdConst = 13002;
    /// <inheritdoc/>
    public override string LocalName => "colorSeries";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the SeriesColor class.
    /// </summary>
    public SeriesColor():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SeriesColor>(deep);

}
/// <summary>
/// <para>Defines the NegativeColor Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:colorNegative.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class NegativeColor : ColorType
{
    internal const int ElementTypeIdConst = 13003;
    /// <inheritdoc/>
    public override string LocalName => "colorNegative";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the NegativeColor class.
    /// </summary>
    public NegativeColor():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NegativeColor>(deep);

}
/// <summary>
/// <para>Defines the AxisColor Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:colorAxis.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class AxisColor : ColorType
{
    internal const int ElementTypeIdConst = 13004;
    /// <inheritdoc/>
    public override string LocalName => "colorAxis";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the AxisColor class.
    /// </summary>
    public AxisColor():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AxisColor>(deep);

}
/// <summary>
/// <para>Defines the MarkersColor Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:colorMarkers.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class MarkersColor : ColorType
{
    internal const int ElementTypeIdConst = 13005;
    /// <inheritdoc/>
    public override string LocalName => "colorMarkers";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the MarkersColor class.
    /// </summary>
    public MarkersColor():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MarkersColor>(deep);

}
/// <summary>
/// <para>Defines the FirstMarkerColor Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:colorFirst.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class FirstMarkerColor : ColorType
{
    internal const int ElementTypeIdConst = 13006;
    /// <inheritdoc/>
    public override string LocalName => "colorFirst";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the FirstMarkerColor class.
    /// </summary>
    public FirstMarkerColor():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FirstMarkerColor>(deep);

}
/// <summary>
/// <para>Defines the LastMarkerColor Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:colorLast.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class LastMarkerColor : ColorType
{
    internal const int ElementTypeIdConst = 13007;
    /// <inheritdoc/>
    public override string LocalName => "colorLast";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the LastMarkerColor class.
    /// </summary>
    public LastMarkerColor():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LastMarkerColor>(deep);

}
/// <summary>
/// <para>Defines the HighMarkerColor Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:colorHigh.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class HighMarkerColor : ColorType
{
    internal const int ElementTypeIdConst = 13008;
    /// <inheritdoc/>
    public override string LocalName => "colorHigh";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the HighMarkerColor class.
    /// </summary>
    public HighMarkerColor():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<HighMarkerColor>(deep);

}
/// <summary>
/// <para>Defines the LowMarkerColor Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:colorLow.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class LowMarkerColor : ColorType
{
    internal const int ElementTypeIdConst = 13009;
    /// <inheritdoc/>
    public override string LocalName => "colorLow";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the LowMarkerColor class.
    /// </summary>
    public LowMarkerColor():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LowMarkerColor>(deep);

}
/// <summary>
/// <para>Defines the Color Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:color.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Color : ColorType
{
    internal const int ElementTypeIdConst = 13031;
    /// <inheritdoc/>
    public override string LocalName => "color";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the Color class.
    /// </summary>
    public Color():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Color>(deep);

}
/// <summary>
/// <para>Defines the FillColor Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:fillColor.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class FillColor : ColorType
{
    internal const int ElementTypeIdConst = 13032;
    /// <inheritdoc/>
    public override string LocalName => "fillColor";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the FillColor class.
    /// </summary>
    public FillColor():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FillColor>(deep);

}
/// <summary>
/// <para>Defines the BorderColor Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:borderColor.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BorderColor : ColorType
{
    internal const int ElementTypeIdConst = 13033;
    /// <inheritdoc/>
    public override string LocalName => "borderColor";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the BorderColor class.
    /// </summary>
    public BorderColor():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BorderColor>(deep);

}
/// <summary>
/// <para>Defines the NegativeFillColor Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:negativeFillColor.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class NegativeFillColor : ColorType
{
    internal const int ElementTypeIdConst = 13034;
    /// <inheritdoc/>
    public override string LocalName => "negativeFillColor";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the NegativeFillColor class.
    /// </summary>
    public NegativeFillColor():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NegativeFillColor>(deep);

}
/// <summary>
/// <para>Defines the NegativeBorderColor Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:negativeBorderColor.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class NegativeBorderColor : ColorType
{
    internal const int ElementTypeIdConst = 13035;
    /// <inheritdoc/>
    public override string LocalName => "negativeBorderColor";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the NegativeBorderColor class.
    /// </summary>
    public NegativeBorderColor():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NegativeBorderColor>(deep);

}
/// <summary>
/// <para>Defines the BarAxisColor Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:axisColor.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BarAxisColor : ColorType
{
    internal const int ElementTypeIdConst = 13036;
    /// <inheritdoc/>
    public override string LocalName => "axisColor";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    /// <summary>
    /// Initializes a new instance of the BarAxisColor class.
    /// </summary>
    public BarAxisColor():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BarAxisColor>(deep);

}
/// <summary>
/// Defines the ColorType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class ColorType : OpenXmlLeafElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "auto"),
		AttributeTag.Create<UInt32Value>(0, "indexed"),
		AttributeTag.Create<HexBinaryValue>(0, "rgb"),
		AttributeTag.Create<UInt32Value>(0, "theme"),
		AttributeTag.Create<DoubleValue>(0, "tint")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> Automatic.</para>
    /// <para>Represents the following attribute in the schema: auto </para>
    /// </summary>
    [SchemaAttr(0, "auto")]
    public BooleanValue Auto
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Index.</para>
    /// <para>Represents the following attribute in the schema: indexed </para>
    /// </summary>
    [SchemaAttr(0, "indexed")]
    public UInt32Value Indexed
    {
        get { return (UInt32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Alpha Red Green Blue Color Value.</para>
    /// <para>Represents the following attribute in the schema: rgb </para>
    /// </summary>
    [SchemaAttr(0, "rgb")]
    public HexBinaryValue Rgb
    {
        get { return (HexBinaryValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Theme Color.</para>
    /// <para>Represents the following attribute in the schema: theme </para>
    /// </summary>
    [SchemaAttr(0, "theme")]
    public UInt32Value Theme
    {
        get { return (UInt32Value)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> Tint.</para>
    /// <para>Represents the following attribute in the schema: tint </para>
    /// </summary>
    [SchemaAttr(0, "tint")]
    public DoubleValue Tint
    {
        get { return (DoubleValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ColorType class.
    /// </summary>
    protected ColorType(){}
    
    
    
}
/// <summary>
/// <para>Defines the Sparklines Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:sparklines.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Sparkline &lt;x14:sparkline></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Sparkline), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Sparklines : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13010;
    /// <inheritdoc/>
    public override string LocalName => "sparklines";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Sparklines class.
    /// </summary>
    public Sparklines():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Sparklines class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Sparklines(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Sparklines class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Sparklines(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Sparklines class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Sparklines(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "sparkline" == name)
    return new Sparkline();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Sparklines>(deep);

}
/// <summary>
/// <para>Defines the Sparkline Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:sparkline.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office.Excel.Formula &lt;xne:f></description></item>
///<item><description>DocumentFormat.OpenXml.Office.Excel.ReferenceSequence &lt;xne:sqref></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office.Excel.Formula))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office.Excel.ReferenceSequence))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Sparkline : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13011;
    /// <inheritdoc/>
    public override string LocalName => "sparkline";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Sparkline class.
    /// </summary>
    public Sparkline():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Sparkline class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Sparkline(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Sparkline class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Sparkline(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Sparkline class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Sparkline(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 32 == namespaceId && "f" == name)
    return new DocumentFormat.OpenXml.Office.Excel.Formula();
    
if( 32 == namespaceId && "sqref" == name)
    return new DocumentFormat.OpenXml.Office.Excel.ReferenceSequence();
    

    return null;
}

        private static readonly string[] eleTagNames = { "f","sqref" };
    private static readonly byte[] eleNamespaceIds = { 32,32 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Formula.</para>
    /// <para> Represents the following element tag in the schema: xne:f </para>
    /// </summary>
    /// <remark>
    /// xmlns:xne = http://schemas.microsoft.com/office/excel/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Office.Excel.Formula Formula
    {
        get => GetElement<DocumentFormat.OpenXml.Office.Excel.Formula>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> ReferenceSequence.</para>
    /// <para> Represents the following element tag in the schema: xne:sqref </para>
    /// </summary>
    /// <remark>
    /// xmlns:xne = http://schemas.microsoft.com/office/excel/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Office.Excel.ReferenceSequence ReferenceSequence
    {
        get => GetElement<DocumentFormat.OpenXml.Office.Excel.ReferenceSequence>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Sparkline>(deep);

}
/// <summary>
/// <para>Defines the SlicerRef Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:slicer.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SlicerRef : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13012;
    /// <inheritdoc/>
    public override string LocalName => "slicer";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(19, "id")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SlicerRef class.
    /// </summary>
    public SlicerRef():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerRef>(deep);

}
/// <summary>
/// <para>Defines the SlicerCache Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:slicerCache.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SlicerCache : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13013;
    /// <inheritdoc/>
    public override string LocalName => "slicerCache";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(19, "id")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: r:id </para>
    /// </summary>
///<remark> xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
///</remark>
    [SchemaAttr(19, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SlicerCache class.
    /// </summary>
    public SlicerCache():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerCache>(deep);

}
/// <summary>
/// <para>Defines the DefinedName Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:definedName.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ArgumentDescriptions &lt;x14:argumentDescriptions></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ArgumentDescriptions), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class DefinedName : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13014;
    /// <inheritdoc/>
    public override string LocalName => "definedName";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "name")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DefinedName class.
    /// </summary>
    public DefinedName():base(){}
    
        /// <summary>
    ///Initializes a new instance of the DefinedName class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DefinedName(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DefinedName class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DefinedName(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DefinedName class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DefinedName(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "argumentDescriptions" == name)
    return new ArgumentDescriptions();
    

    return null;
}

        private static readonly string[] eleTagNames = { "argumentDescriptions" };
    private static readonly byte[] eleNamespaceIds = { 53 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ArgumentDescriptions.</para>
    /// <para> Represents the following element tag in the schema: x14:argumentDescriptions </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public ArgumentDescriptions ArgumentDescriptions
    {
        get => GetElement<ArgumentDescriptions>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DefinedName>(deep);

}
/// <summary>
/// <para>Defines the ArgumentDescriptions Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:argumentDescriptions.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ArgumentDescription &lt;x14:argumentDescription></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ArgumentDescription), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ArgumentDescriptions : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13015;
    /// <inheritdoc/>
    public override string LocalName => "argumentDescriptions";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "count")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> count.</para>
    /// <para>Represents the following attribute in the schema: count </para>
    /// </summary>
    [SchemaAttr(0, "count")]
    public UInt32Value Count
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ArgumentDescriptions class.
    /// </summary>
    public ArgumentDescriptions():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ArgumentDescriptions class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ArgumentDescriptions(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ArgumentDescriptions class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ArgumentDescriptions(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ArgumentDescriptions class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ArgumentDescriptions(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "argumentDescription" == name)
    return new ArgumentDescription();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArgumentDescriptions>(deep);

}
/// <summary>
/// <para>Defines the ArgumentDescription Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:argumentDescription.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ArgumentDescription : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 13016;
    /// <inheritdoc/>
    public override string LocalName => "argumentDescription";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "index")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> index.</para>
    /// <para>Represents the following attribute in the schema: index </para>
    /// </summary>
    [SchemaAttr(0, "index")]
    public UInt32Value Index
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ArgumentDescription class.
    /// </summary>
    public ArgumentDescription():base(){}
    
      
        /// <summary>
    /// Initializes a new instance of the ArgumentDescription class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public ArgumentDescription(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArgumentDescription>(deep);

}
/// <summary>
/// <para>Defines the TupleSet Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:tupleSet.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TupleSetHeaders &lt;x14:headers></description></item>
///<item><description>TupleSetRows &lt;x14:rows></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(TupleSetHeaders), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(TupleSetRows), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class TupleSet : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13017;
    /// <inheritdoc/>
    public override string LocalName => "tupleSet";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "rowCount"),
		AttributeTag.Create<UInt32Value>(0, "columnCount")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> rowCount.</para>
    /// <para>Represents the following attribute in the schema: rowCount </para>
    /// </summary>
    [SchemaAttr(0, "rowCount")]
    public UInt32Value RowCount
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> columnCount.</para>
    /// <para>Represents the following attribute in the schema: columnCount </para>
    /// </summary>
    [SchemaAttr(0, "columnCount")]
    public UInt32Value ColumnCount
    {
        get { return (UInt32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the TupleSet class.
    /// </summary>
    public TupleSet():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TupleSet class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TupleSet(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TupleSet class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TupleSet(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TupleSet class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TupleSet(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "headers" == name)
    return new TupleSetHeaders();
    
if( 53 == namespaceId && "rows" == name)
    return new TupleSetRows();
    

    return null;
}

        private static readonly string[] eleTagNames = { "headers","rows" };
    private static readonly byte[] eleNamespaceIds = { 53,53 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> TupleSetHeaders.</para>
    /// <para> Represents the following element tag in the schema: x14:headers </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public TupleSetHeaders TupleSetHeaders
    {
        get => GetElement<TupleSetHeaders>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> TupleSetRows.</para>
    /// <para> Represents the following element tag in the schema: x14:rows </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public TupleSetRows TupleSetRows
    {
        get => GetElement<TupleSetRows>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TupleSet>(deep);

}
/// <summary>
/// <para>Defines the TupleSetHeaders Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:headers.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TupleSetHeader &lt;x14:header></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(TupleSetHeader), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class TupleSetHeaders : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13018;
    /// <inheritdoc/>
    public override string LocalName => "headers";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the TupleSetHeaders class.
    /// </summary>
    public TupleSetHeaders():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TupleSetHeaders class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TupleSetHeaders(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TupleSetHeaders class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TupleSetHeaders(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TupleSetHeaders class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TupleSetHeaders(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "header" == name)
    return new TupleSetHeader();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TupleSetHeaders>(deep);

}
/// <summary>
/// <para>Defines the TupleSetRows Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:rows.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TupleSetRow &lt;x14:row></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(TupleSetRow), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class TupleSetRows : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13019;
    /// <inheritdoc/>
    public override string LocalName => "rows";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the TupleSetRows class.
    /// </summary>
    public TupleSetRows():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TupleSetRows class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TupleSetRows(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TupleSetRows class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TupleSetRows(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TupleSetRows class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TupleSetRows(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "row" == name)
    return new TupleSetRow();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TupleSetRows>(deep);

}
/// <summary>
/// <para>Defines the TupleSetHeader Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:header.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class TupleSetHeader : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13020;
    /// <inheritdoc/>
    public override string LocalName => "header";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uniqueName"),
		AttributeTag.Create<StringValue>(0, "hierarchyName")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> uniqueName.</para>
    /// <para>Represents the following attribute in the schema: uniqueName </para>
    /// </summary>
    [SchemaAttr(0, "uniqueName")]
    public StringValue UniqueName
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> hierarchyName.</para>
    /// <para>Represents the following attribute in the schema: hierarchyName </para>
    /// </summary>
    [SchemaAttr(0, "hierarchyName")]
    public StringValue HierarchyName
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the TupleSetHeader class.
    /// </summary>
    public TupleSetHeader():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TupleSetHeader>(deep);

}
/// <summary>
/// <para>Defines the TupleSetRow Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:row.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TupleSetRowItem &lt;x14:rowItem></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(TupleSetRowItem), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class TupleSetRow : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13021;
    /// <inheritdoc/>
    public override string LocalName => "row";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the TupleSetRow class.
    /// </summary>
    public TupleSetRow():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TupleSetRow class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TupleSetRow(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TupleSetRow class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TupleSetRow(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TupleSetRow class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TupleSetRow(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "rowItem" == name)
    return new TupleSetRowItem();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TupleSetRow>(deep);

}
/// <summary>
/// <para>Defines the TupleSetRowItem Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:rowItem.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class TupleSetRowItem : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13022;
    /// <inheritdoc/>
    public override string LocalName => "rowItem";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "u"),
		AttributeTag.Create<StringValue>(0, "d")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> u.</para>
    /// <para>Represents the following attribute in the schema: u </para>
    /// </summary>
    [SchemaAttr(0, "u")]
    public StringValue UniqueName
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> d.</para>
    /// <para>Represents the following attribute in the schema: d </para>
    /// </summary>
    [SchemaAttr(0, "d")]
    public StringValue DisplayName
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the TupleSetRowItem class.
    /// </summary>
    public TupleSetRowItem():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TupleSetRowItem>(deep);

}
/// <summary>
/// <para>Defines the SetLevel Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:setLevel.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SetLevel : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13023;
    /// <inheritdoc/>
    public override string LocalName => "setLevel";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "hierarchy")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> hierarchy.</para>
    /// <para>Represents the following attribute in the schema: hierarchy </para>
    /// </summary>
    [SchemaAttr(0, "hierarchy")]
    public Int32Value Hierarchy
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SetLevel class.
    /// </summary>
    public SetLevel():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SetLevel>(deep);

}
/// <summary>
/// <para>Defines the SetLevels Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:setLevels.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SetLevel &lt;x14:setLevel></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SetLevel), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SetLevels : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13024;
    /// <inheritdoc/>
    public override string LocalName => "setLevels";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "count")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> count.</para>
    /// <para>Represents the following attribute in the schema: count </para>
    /// </summary>
    [SchemaAttr(0, "count")]
    public UInt32Value Count
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SetLevels class.
    /// </summary>
    public SetLevels():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SetLevels class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SetLevels(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SetLevels class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SetLevels(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SetLevels class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SetLevels(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "setLevel" == name)
    return new SetLevel();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SetLevels>(deep);

}
/// <summary>
/// <para>Defines the ColorScale Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:colorScale.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ConditionalFormattingValueObject &lt;x14:cfvo></description></item>
///<item><description>Color &lt;x14:color></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ConditionalFormattingValueObject), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Color), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ColorScale : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13025;
    /// <inheritdoc/>
    public override string LocalName => "colorScale";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ColorScale class.
    /// </summary>
    public ColorScale():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ColorScale class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ColorScale(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ColorScale class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ColorScale(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ColorScale class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ColorScale(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "cfvo" == name)
    return new ConditionalFormattingValueObject();
    
if( 53 == namespaceId && "color" == name)
    return new Color();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorScale>(deep);

}
/// <summary>
/// <para>Defines the DataBar Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:dataBar.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ConditionalFormattingValueObject &lt;x14:cfvo></description></item>
///<item><description>FillColor &lt;x14:fillColor></description></item>
///<item><description>BorderColor &lt;x14:borderColor></description></item>
///<item><description>NegativeFillColor &lt;x14:negativeFillColor></description></item>
///<item><description>NegativeBorderColor &lt;x14:negativeBorderColor></description></item>
///<item><description>BarAxisColor &lt;x14:axisColor></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ConditionalFormattingValueObject), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(FillColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BorderColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(NegativeFillColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(NegativeBorderColor), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(BarAxisColor), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class DataBar : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13026;
    /// <inheritdoc/>
    public override string LocalName => "dataBar";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "minLength"),
		AttributeTag.Create<UInt32Value>(0, "maxLength"),
		AttributeTag.Create<BooleanValue>(0, "showValue"),
		AttributeTag.Create<BooleanValue>(0, "border"),
		AttributeTag.Create<BooleanValue>(0, "gradient"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.DataBarDirectionValues>>(0, "direction"),
		AttributeTag.Create<BooleanValue>(0, "negativeBarColorSameAsPositive"),
		AttributeTag.Create<BooleanValue>(0, "negativeBarBorderColorSameAsPositive"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.DataBarAxisPositionValues>>(0, "axisPosition")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> minLength.</para>
    /// <para>Represents the following attribute in the schema: minLength </para>
    /// </summary>
    [SchemaAttr(0, "minLength")]
    public UInt32Value MinLength
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> maxLength.</para>
    /// <para>Represents the following attribute in the schema: maxLength </para>
    /// </summary>
    [SchemaAttr(0, "maxLength")]
    public UInt32Value MaxLength
    {
        get { return (UInt32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> showValue.</para>
    /// <para>Represents the following attribute in the schema: showValue </para>
    /// </summary>
    [SchemaAttr(0, "showValue")]
    public BooleanValue ShowValue
    {
        get { return (BooleanValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> border.</para>
    /// <para>Represents the following attribute in the schema: border </para>
    /// </summary>
    [SchemaAttr(0, "border")]
    public BooleanValue Border
    {
        get { return (BooleanValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> gradient.</para>
    /// <para>Represents the following attribute in the schema: gradient </para>
    /// </summary>
    [SchemaAttr(0, "gradient")]
    public BooleanValue Gradient
    {
        get { return (BooleanValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> direction.</para>
    /// <para>Represents the following attribute in the schema: direction </para>
    /// </summary>
    [SchemaAttr(0, "direction")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.DataBarDirectionValues> Direction
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.DataBarDirectionValues>)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> negativeBarColorSameAsPositive.</para>
    /// <para>Represents the following attribute in the schema: negativeBarColorSameAsPositive </para>
    /// </summary>
    [SchemaAttr(0, "negativeBarColorSameAsPositive")]
    public BooleanValue NegativeBarColorSameAsPositive
    {
        get { return (BooleanValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> negativeBarBorderColorSameAsPositive.</para>
    /// <para>Represents the following attribute in the schema: negativeBarBorderColorSameAsPositive </para>
    /// </summary>
    [SchemaAttr(0, "negativeBarBorderColorSameAsPositive")]
    public BooleanValue NegativeBarBorderColorSameAsPositive
    {
        get { return (BooleanValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> axisPosition.</para>
    /// <para>Represents the following attribute in the schema: axisPosition </para>
    /// </summary>
    [SchemaAttr(0, "axisPosition")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.DataBarAxisPositionValues> AxisPosition
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.DataBarAxisPositionValues>)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DataBar class.
    /// </summary>
    public DataBar():base(){}
    
        /// <summary>
    ///Initializes a new instance of the DataBar class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataBar(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DataBar class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DataBar(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DataBar class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DataBar(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "cfvo" == name)
    return new ConditionalFormattingValueObject();
    
if( 53 == namespaceId && "fillColor" == name)
    return new FillColor();
    
if( 53 == namespaceId && "borderColor" == name)
    return new BorderColor();
    
if( 53 == namespaceId && "negativeFillColor" == name)
    return new NegativeFillColor();
    
if( 53 == namespaceId && "negativeBorderColor" == name)
    return new NegativeBorderColor();
    
if( 53 == namespaceId && "axisColor" == name)
    return new BarAxisColor();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataBar>(deep);

}
/// <summary>
/// <para>Defines the IconSet Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:iconSet.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ConditionalFormattingValueObject &lt;x14:cfvo></description></item>
///<item><description>ConditionalFormattingIcon &lt;x14:cfIcon></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ConditionalFormattingValueObject), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ConditionalFormattingIcon), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class IconSet : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13027;
    /// <inheritdoc/>
    public override string LocalName => "iconSet";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.IconSetTypeValues>>(0, "iconSet"),
		AttributeTag.Create<BooleanValue>(0, "showValue"),
		AttributeTag.Create<BooleanValue>(0, "percent"),
		AttributeTag.Create<BooleanValue>(0, "reverse"),
		AttributeTag.Create<BooleanValue>(0, "custom")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> iconSet.</para>
    /// <para>Represents the following attribute in the schema: iconSet </para>
    /// </summary>
    [SchemaAttr(0, "iconSet")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.IconSetTypeValues> IconSetTypes
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.IconSetTypeValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> showValue.</para>
    /// <para>Represents the following attribute in the schema: showValue </para>
    /// </summary>
    [SchemaAttr(0, "showValue")]
    public BooleanValue ShowValue
    {
        get { return (BooleanValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> percent.</para>
    /// <para>Represents the following attribute in the schema: percent </para>
    /// </summary>
    [SchemaAttr(0, "percent")]
    public BooleanValue Percent
    {
        get { return (BooleanValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> reverse.</para>
    /// <para>Represents the following attribute in the schema: reverse </para>
    /// </summary>
    [SchemaAttr(0, "reverse")]
    public BooleanValue Reverse
    {
        get { return (BooleanValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> custom.</para>
    /// <para>Represents the following attribute in the schema: custom </para>
    /// </summary>
    [SchemaAttr(0, "custom")]
    public BooleanValue Custom
    {
        get { return (BooleanValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the IconSet class.
    /// </summary>
    public IconSet():base(){}
    
        /// <summary>
    ///Initializes a new instance of the IconSet class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public IconSet(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the IconSet class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public IconSet(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the IconSet class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public IconSet(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "cfvo" == name)
    return new ConditionalFormattingValueObject();
    
if( 53 == namespaceId && "cfIcon" == name)
    return new ConditionalFormattingIcon();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<IconSet>(deep);

}
/// <summary>
/// <para>Defines the DifferentialType Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:dxf.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Spreadsheet.Font &lt;x:font></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.NumberingFormat &lt;x:numFmt></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.Fill &lt;x:fill></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.Alignment &lt;x:alignment></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.Border &lt;x:border></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.Protection &lt;x:protection></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.ExtensionList &lt;x:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Font))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.NumberingFormat))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Fill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Alignment))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Border))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Protection))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class DifferentialType : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13028;
    /// <inheritdoc/>
    public override string LocalName => "dxf";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the DifferentialType class.
    /// </summary>
    public DifferentialType():base(){}
    
        /// <summary>
    ///Initializes a new instance of the DifferentialType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DifferentialType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DifferentialType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DifferentialType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DifferentialType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DifferentialType(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 22 == namespaceId && "font" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.Font();
    
if( 22 == namespaceId && "numFmt" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.NumberingFormat();
    
if( 22 == namespaceId && "fill" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.Fill();
    
if( 22 == namespaceId && "alignment" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.Alignment();
    
if( 22 == namespaceId && "border" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.Border();
    
if( 22 == namespaceId && "protection" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.Protection();
    
if( 22 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "font","numFmt","fill","alignment","border","protection","extLst" };
    private static readonly byte[] eleNamespaceIds = { 22,22,22,22,22,22,22 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Font Properties.</para>
    /// <para> Represents the following element tag in the schema: x:font </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Spreadsheet.Font Font
    {
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Font>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Number Format.</para>
    /// <para> Represents the following element tag in the schema: x:numFmt </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Spreadsheet.NumberingFormat NumberingFormat
    {
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.NumberingFormat>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Fill.</para>
    /// <para> Represents the following element tag in the schema: x:fill </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Spreadsheet.Fill Fill
    {
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Fill>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Alignment.</para>
    /// <para> Represents the following element tag in the schema: x:alignment </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Spreadsheet.Alignment Alignment
    {
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Alignment>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> Border Properties.</para>
    /// <para> Represents the following element tag in the schema: x:border </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Spreadsheet.Border Border
    {
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Border>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> Protection Properties.</para>
    /// <para> Represents the following element tag in the schema: x:protection </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Spreadsheet.Protection Protection
    {
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Protection>(5);
        set => SetElement(5, value);
    }
    /// <summary>
    /// <para> Future Feature Data Storage Area.</para>
    /// <para> Represents the following element tag in the schema: x:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Spreadsheet.ExtensionList ExtensionList
    {
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.ExtensionList>(6);
        set => SetElement(6, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DifferentialType>(deep);

}
/// <summary>
/// <para>Defines the ConditionalFormattingValueObject Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:cfvo.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office.Excel.Formula &lt;xne:f></description></item>
///<item><description>ExtensionList &lt;x14:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office.Excel.Formula))]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ConditionalFormattingValueObject : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13029;
    /// <inheritdoc/>
    public override string LocalName => "cfvo";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.ConditionalFormattingValueObjectTypeValues>>(0, "type"),
		AttributeTag.Create<BooleanValue>(0, "gte")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.ConditionalFormattingValueObjectTypeValues> Type
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.ConditionalFormattingValueObjectTypeValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> gte.</para>
    /// <para>Represents the following attribute in the schema: gte </para>
    /// </summary>
    [SchemaAttr(0, "gte")]
    public BooleanValue GreaterThanOrEqual
    {
        get { return (BooleanValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ConditionalFormattingValueObject class.
    /// </summary>
    public ConditionalFormattingValueObject():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ConditionalFormattingValueObject class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ConditionalFormattingValueObject(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ConditionalFormattingValueObject class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ConditionalFormattingValueObject(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ConditionalFormattingValueObject class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ConditionalFormattingValueObject(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 32 == namespaceId && "f" == name)
    return new DocumentFormat.OpenXml.Office.Excel.Formula();
    
if( 53 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "f","extLst" };
    private static readonly byte[] eleNamespaceIds = { 32,53 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Formula.</para>
    /// <para> Represents the following element tag in the schema: xne:f </para>
    /// </summary>
    /// <remark>
    /// xmlns:xne = http://schemas.microsoft.com/office/excel/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Office.Excel.Formula Formula
    {
        get => GetElement<DocumentFormat.OpenXml.Office.Excel.Formula>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: x14:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public ExtensionList ExtensionList
    {
        get => GetElement<ExtensionList>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConditionalFormattingValueObject>(deep);

}
/// <summary>
/// <para>Defines the ConditionalFormattingIcon Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:cfIcon.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ConditionalFormattingIcon : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13030;
    /// <inheritdoc/>
    public override string LocalName => "cfIcon";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.IconSetTypeValues>>(0, "iconSet"),
		AttributeTag.Create<UInt32Value>(0, "iconId")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> iconSet.</para>
    /// <para>Represents the following attribute in the schema: iconSet </para>
    /// </summary>
    [SchemaAttr(0, "iconSet")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.IconSetTypeValues> IconSet
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.IconSetTypeValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> iconId.</para>
    /// <para>Represents the following attribute in the schema: iconId </para>
    /// </summary>
    [SchemaAttr(0, "iconId")]
    public UInt32Value IconId
    {
        get { return (UInt32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ConditionalFormattingIcon class.
    /// </summary>
    public ConditionalFormattingIcon():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConditionalFormattingIcon>(deep);

}
/// <summary>
/// <para>Defines the PivotEdits Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:pivotEdits.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PivotEdit &lt;x14:pivotEdit></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(PivotEdit), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class PivotEdits : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13037;
    /// <inheritdoc/>
    public override string LocalName => "pivotEdits";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the PivotEdits class.
    /// </summary>
    public PivotEdits():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PivotEdits class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotEdits(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotEdits class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotEdits(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotEdits class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PivotEdits(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "pivotEdit" == name)
    return new PivotEdit();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotEdits>(deep);

}
/// <summary>
/// <para>Defines the PivotChanges Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:pivotChanges.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PivotChange &lt;x14:pivotChange></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(PivotChange), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class PivotChanges : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13038;
    /// <inheritdoc/>
    public override string LocalName => "pivotChanges";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the PivotChanges class.
    /// </summary>
    public PivotChanges():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PivotChanges class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotChanges(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotChanges class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotChanges(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotChanges class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PivotChanges(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "pivotChange" == name)
    return new PivotChange();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotChanges>(deep);

}
/// <summary>
/// <para>Defines the ConditionalFormats Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:conditionalFormats.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ConditionalFormat &lt;x14:conditionalFormat></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ConditionalFormat), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ConditionalFormats : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13039;
    /// <inheritdoc/>
    public override string LocalName => "conditionalFormats";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "count")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> count.</para>
    /// <para>Represents the following attribute in the schema: count </para>
    /// </summary>
    [SchemaAttr(0, "count")]
    public UInt32Value Count
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ConditionalFormats class.
    /// </summary>
    public ConditionalFormats():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ConditionalFormats class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ConditionalFormats(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ConditionalFormats class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ConditionalFormats(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ConditionalFormats class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ConditionalFormats(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "conditionalFormat" == name)
    return new ConditionalFormat();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConditionalFormats>(deep);

}
/// <summary>
/// <para>Defines the CalculatedMembers Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:calculatedMembers.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Spreadsheet.CalculatedMember &lt;x:calculatedMember></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.CalculatedMember))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class CalculatedMembers : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13040;
    /// <inheritdoc/>
    public override string LocalName => "calculatedMembers";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "count")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Calculated Members Count.</para>
    /// <para>Represents the following attribute in the schema: count </para>
    /// </summary>
    [SchemaAttr(0, "count")]
    public UInt32Value Count
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the CalculatedMembers class.
    /// </summary>
    public CalculatedMembers():base(){}
    
        /// <summary>
    ///Initializes a new instance of the CalculatedMembers class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CalculatedMembers(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the CalculatedMembers class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CalculatedMembers(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the CalculatedMembers class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public CalculatedMembers(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 22 == namespaceId && "calculatedMember" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.CalculatedMember();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CalculatedMembers>(deep);

}
/// <summary>
/// <para>Defines the PivotEdit Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:pivotEdit.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PivotUserEdit &lt;x14:userEdit></description></item>
///<item><description>TupleItems &lt;x14:tupleItems></description></item>
///<item><description>PivotArea &lt;x14:pivotArea></description></item>
///<item><description>ExtensionList &lt;x14:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(PivotUserEdit), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(TupleItems), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(PivotArea), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class PivotEdit : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13041;
    /// <inheritdoc/>
    public override string LocalName => "pivotEdit";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the PivotEdit class.
    /// </summary>
    public PivotEdit():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PivotEdit class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotEdit(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotEdit class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotEdit(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotEdit class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PivotEdit(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "userEdit" == name)
    return new PivotUserEdit();
    
if( 53 == namespaceId && "tupleItems" == name)
    return new TupleItems();
    
if( 53 == namespaceId && "pivotArea" == name)
    return new PivotArea();
    
if( 53 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "userEdit","tupleItems","pivotArea","extLst" };
    private static readonly byte[] eleNamespaceIds = { 53,53,53,53 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> PivotUserEdit.</para>
    /// <para> Represents the following element tag in the schema: x14:userEdit </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public PivotUserEdit PivotUserEdit
    {
        get => GetElement<PivotUserEdit>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> TupleItems.</para>
    /// <para> Represents the following element tag in the schema: x14:tupleItems </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public TupleItems TupleItems
    {
        get => GetElement<TupleItems>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> PivotArea.</para>
    /// <para> Represents the following element tag in the schema: x14:pivotArea </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public PivotArea PivotArea
    {
        get => GetElement<PivotArea>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: x14:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public ExtensionList ExtensionList
    {
        get => GetElement<ExtensionList>(3);
        set => SetElement(3, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotEdit>(deep);

}
/// <summary>
/// <para>Defines the PivotUserEdit Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:userEdit.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office.Excel.Formula &lt;xne:f></description></item>
///<item><description>PivotEditValue &lt;x14:editValue></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office.Excel.Formula))]
    [ChildElementInfo(typeof(PivotEditValue), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class PivotUserEdit : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13042;
    /// <inheritdoc/>
    public override string LocalName => "userEdit";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the PivotUserEdit class.
    /// </summary>
    public PivotUserEdit():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PivotUserEdit class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotUserEdit(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotUserEdit class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotUserEdit(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotUserEdit class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PivotUserEdit(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 32 == namespaceId && "f" == name)
    return new DocumentFormat.OpenXml.Office.Excel.Formula();
    
if( 53 == namespaceId && "editValue" == name)
    return new PivotEditValue();
    

    return null;
}

        private static readonly string[] eleTagNames = { "f","editValue" };
    private static readonly byte[] eleNamespaceIds = { 32,53 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    
        /// <summary>
    /// <para> Formula.</para>
    /// <para> Represents the following element tag in the schema: xne:f </para>
    /// </summary>
    /// <remark>
    /// xmlns:xne = http://schemas.microsoft.com/office/excel/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Office.Excel.Formula Formula
    {
        get => GetElement<DocumentFormat.OpenXml.Office.Excel.Formula>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> PivotEditValue.</para>
    /// <para> Represents the following element tag in the schema: x14:editValue </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public PivotEditValue PivotEditValue
    {
        get => GetElement<PivotEditValue>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotUserEdit>(deep);

}
/// <summary>
/// <para>Defines the TupleItems Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:tupleItems.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Xstring &lt;x14:tupleItem></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Xstring), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class TupleItems : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13043;
    /// <inheritdoc/>
    public override string LocalName => "tupleItems";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the TupleItems class.
    /// </summary>
    public TupleItems():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TupleItems class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TupleItems(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TupleItems class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TupleItems(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TupleItems class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TupleItems(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "tupleItem" == name)
    return new Xstring();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TupleItems>(deep);

}
/// <summary>
/// <para>Defines the PivotArea Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:pivotArea.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Spreadsheet.PivotAreaReferences &lt;x:references></description></item>
///<item><description>DocumentFormat.OpenXml.Spreadsheet.ExtensionList &lt;x:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.PivotAreaReferences))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class PivotArea : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13044;
    /// <inheritdoc/>
    public override string LocalName => "pivotArea";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<Int32Value>(0, "field"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Spreadsheet.PivotAreaValues>>(0, "type"),
		AttributeTag.Create<BooleanValue>(0, "dataOnly"),
		AttributeTag.Create<BooleanValue>(0, "labelOnly"),
		AttributeTag.Create<BooleanValue>(0, "grandRow"),
		AttributeTag.Create<BooleanValue>(0, "grandCol"),
		AttributeTag.Create<BooleanValue>(0, "cacheIndex"),
		AttributeTag.Create<BooleanValue>(0, "outline"),
		AttributeTag.Create<StringValue>(0, "offset"),
		AttributeTag.Create<BooleanValue>(0, "collapsedLevelsAreSubtotals"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Spreadsheet.PivotTableAxisValues>>(0, "axis"),
		AttributeTag.Create<UInt32Value>(0, "fieldPosition")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Field Index.</para>
    /// <para>Represents the following attribute in the schema: field </para>
    /// </summary>
    [SchemaAttr(0, "field")]
    public Int32Value Field
    {
        get { return (Int32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Rule Type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public EnumValue<DocumentFormat.OpenXml.Spreadsheet.PivotAreaValues> Type
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Spreadsheet.PivotAreaValues>)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> Data Only.</para>
    /// <para>Represents the following attribute in the schema: dataOnly </para>
    /// </summary>
    [SchemaAttr(0, "dataOnly")]
    public BooleanValue DataOnly
    {
        get { return (BooleanValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> Labels Only.</para>
    /// <para>Represents the following attribute in the schema: labelOnly </para>
    /// </summary>
    [SchemaAttr(0, "labelOnly")]
    public BooleanValue LabelOnly
    {
        get { return (BooleanValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> Include Row Grand Total.</para>
    /// <para>Represents the following attribute in the schema: grandRow </para>
    /// </summary>
    [SchemaAttr(0, "grandRow")]
    public BooleanValue GrandRow
    {
        get { return (BooleanValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> Include Column Grand Total.</para>
    /// <para>Represents the following attribute in the schema: grandCol </para>
    /// </summary>
    [SchemaAttr(0, "grandCol")]
    public BooleanValue GrandColumn
    {
        get { return (BooleanValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> Cache Index.</para>
    /// <para>Represents the following attribute in the schema: cacheIndex </para>
    /// </summary>
    [SchemaAttr(0, "cacheIndex")]
    public BooleanValue CacheIndex
    {
        get { return (BooleanValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> Outline.</para>
    /// <para>Represents the following attribute in the schema: outline </para>
    /// </summary>
    [SchemaAttr(0, "outline")]
    public BooleanValue Outline
    {
        get { return (BooleanValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> Offset Reference.</para>
    /// <para>Represents the following attribute in the schema: offset </para>
    /// </summary>
    [SchemaAttr(0, "offset")]
    public StringValue Offset
    {
        get { return (StringValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> Collapsed Levels Are Subtotals.</para>
    /// <para>Represents the following attribute in the schema: collapsedLevelsAreSubtotals </para>
    /// </summary>
    [SchemaAttr(0, "collapsedLevelsAreSubtotals")]
    public BooleanValue CollapsedLevelsAreSubtotals
    {
        get { return (BooleanValue)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    
    /// <summary>
    /// <para> Axis.</para>
    /// <para>Represents the following attribute in the schema: axis </para>
    /// </summary>
    [SchemaAttr(0, "axis")]
    public EnumValue<DocumentFormat.OpenXml.Spreadsheet.PivotTableAxisValues> Axis
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Spreadsheet.PivotTableAxisValues>)Attributes[10].Value; }
        set { Attributes[10].Value = value; }
    }
    
    /// <summary>
    /// <para> Field Position.</para>
    /// <para>Represents the following attribute in the schema: fieldPosition </para>
    /// </summary>
    [SchemaAttr(0, "fieldPosition")]
    public UInt32Value FieldPosition
    {
        get { return (UInt32Value)Attributes[11].Value; }
        set { Attributes[11].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PivotArea class.
    /// </summary>
    public PivotArea():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PivotArea class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotArea(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotArea class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotArea(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotArea class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PivotArea(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 22 == namespaceId && "references" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.PivotAreaReferences();
    
if( 22 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "references","extLst" };
    private static readonly byte[] eleNamespaceIds = { 22,22 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> References.</para>
    /// <para> Represents the following element tag in the schema: x:references </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Spreadsheet.PivotAreaReferences PivotAreaReferences
    {
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.PivotAreaReferences>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Future Feature Data Storage Area.</para>
    /// <para> Represents the following element tag in the schema: x:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Spreadsheet.ExtensionList ExtensionList
    {
        get => GetElement<DocumentFormat.OpenXml.Spreadsheet.ExtensionList>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotArea>(deep);

}
/// <summary>
/// <para>Defines the PivotChange Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:pivotChange.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PivotEditValue &lt;x14:editValue></description></item>
///<item><description>TupleItems &lt;x14:tupleItems></description></item>
///<item><description>ExtensionList &lt;x14:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(PivotEditValue), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(TupleItems), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class PivotChange : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13045;
    /// <inheritdoc/>
    public override string LocalName => "pivotChange";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.AllocationMethodValues>>(0, "allocationMethod"),
		AttributeTag.Create<StringValue>(0, "weightExpression")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> allocationMethod.</para>
    /// <para>Represents the following attribute in the schema: allocationMethod </para>
    /// </summary>
    [SchemaAttr(0, "allocationMethod")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.AllocationMethodValues> AllocationMethod
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.AllocationMethodValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> weightExpression.</para>
    /// <para>Represents the following attribute in the schema: weightExpression </para>
    /// </summary>
    [SchemaAttr(0, "weightExpression")]
    public StringValue WeightExpression
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PivotChange class.
    /// </summary>
    public PivotChange():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PivotChange class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotChange(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotChange class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotChange(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotChange class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PivotChange(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "editValue" == name)
    return new PivotEditValue();
    
if( 53 == namespaceId && "tupleItems" == name)
    return new TupleItems();
    
if( 53 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "editValue","tupleItems","extLst" };
    private static readonly byte[] eleNamespaceIds = { 53,53,53 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> PivotEditValue.</para>
    /// <para> Represents the following element tag in the schema: x14:editValue </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public PivotEditValue PivotEditValue
    {
        get => GetElement<PivotEditValue>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> TupleItems.</para>
    /// <para> Represents the following element tag in the schema: x14:tupleItems </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public TupleItems TupleItems
    {
        get => GetElement<TupleItems>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: x14:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public ExtensionList ExtensionList
    {
        get => GetElement<ExtensionList>(2);
        set => SetElement(2, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotChange>(deep);

}
/// <summary>
/// <para>Defines the PivotEditValue Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:editValue.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class PivotEditValue : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 13046;
    /// <inheritdoc/>
    public override string LocalName => "editValue";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.PivotEditValueTypeValues>>(0, "valueType")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> valueType.</para>
    /// <para>Represents the following attribute in the schema: valueType </para>
    /// </summary>
    [SchemaAttr(0, "valueType")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.PivotEditValueTypeValues> ValueType
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.PivotEditValueTypeValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PivotEditValue class.
    /// </summary>
    public PivotEditValue():base(){}
    
      
        /// <summary>
    /// Initializes a new instance of the PivotEditValue class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public PivotEditValue(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotEditValue>(deep);

}
/// <summary>
/// <para>Defines the Xstring Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:tupleItem.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Xstring : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 13047;
    /// <inheritdoc/>
    public override string LocalName => "tupleItem";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Xstring class.
    /// </summary>
    public Xstring():base(){}
    
      
        /// <summary>
    /// Initializes a new instance of the Xstring class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Xstring(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Xstring>(deep);

}
/// <summary>
/// <para>Defines the SlicerStyleElements Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:slicerStyleElements.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SlicerStyleElement &lt;x14:slicerStyleElement></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SlicerStyleElement), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SlicerStyleElements : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13048;
    /// <inheritdoc/>
    public override string LocalName => "slicerStyleElements";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the SlicerStyleElements class.
    /// </summary>
    public SlicerStyleElements():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SlicerStyleElements class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SlicerStyleElements(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SlicerStyleElements class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SlicerStyleElements(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SlicerStyleElements class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SlicerStyleElements(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "slicerStyleElement" == name)
    return new SlicerStyleElement();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerStyleElements>(deep);

}
/// <summary>
/// <para>Defines the DdeValues Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:values.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Spreadsheet.Value &lt;x:value></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.Value))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class DdeValues : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13049;
    /// <inheritdoc/>
    public override string LocalName => "values";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "rows"),
		AttributeTag.Create<UInt32Value>(0, "cols")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Rows.</para>
    /// <para>Represents the following attribute in the schema: rows </para>
    /// </summary>
    [SchemaAttr(0, "rows")]
    public UInt32Value Rows
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Columns.</para>
    /// <para>Represents the following attribute in the schema: cols </para>
    /// </summary>
    [SchemaAttr(0, "cols")]
    public UInt32Value Columns
    {
        get { return (UInt32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the DdeValues class.
    /// </summary>
    public DdeValues():base(){}
    
        /// <summary>
    ///Initializes a new instance of the DdeValues class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DdeValues(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DdeValues class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DdeValues(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DdeValues class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DdeValues(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 22 == namespaceId && "value" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.Value();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DdeValues>(deep);

}
/// <summary>
/// <para>Defines the ConditionalFormat Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:conditionalFormat.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PivotAreas &lt;x14:pivotAreas></description></item>
///<item><description>ExtensionList &lt;x14:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(PivotAreas), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ConditionalFormat : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13050;
    /// <inheritdoc/>
    public override string LocalName => "conditionalFormat";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Spreadsheet.ScopeValues>>(0, "scope"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Spreadsheet.RuleValues>>(0, "type"),
		AttributeTag.Create<UInt32Value>(0, "priority"),
		AttributeTag.Create<StringValue>(0, "id")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> scope.</para>
    /// <para>Represents the following attribute in the schema: scope </para>
    /// </summary>
    [SchemaAttr(0, "scope")]
    public EnumValue<DocumentFormat.OpenXml.Spreadsheet.ScopeValues> Scope
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Spreadsheet.ScopeValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public EnumValue<DocumentFormat.OpenXml.Spreadsheet.RuleValues> Type
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Spreadsheet.RuleValues>)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> priority.</para>
    /// <para>Represents the following attribute in the schema: priority </para>
    /// </summary>
    [SchemaAttr(0, "priority")]
    public UInt32Value Priority
    {
        get { return (UInt32Value)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> id.</para>
    /// <para>Represents the following attribute in the schema: id </para>
    /// </summary>
    [SchemaAttr(0, "id")]
    public StringValue Id
    {
        get { return (StringValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ConditionalFormat class.
    /// </summary>
    public ConditionalFormat():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ConditionalFormat class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ConditionalFormat(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ConditionalFormat class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ConditionalFormat(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ConditionalFormat class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ConditionalFormat(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "pivotAreas" == name)
    return new PivotAreas();
    
if( 53 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "pivotAreas","extLst" };
    private static readonly byte[] eleNamespaceIds = { 53,53 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> PivotAreas.</para>
    /// <para> Represents the following element tag in the schema: x14:pivotAreas </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public PivotAreas PivotAreas
    {
        get => GetElement<PivotAreas>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: x14:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public ExtensionList ExtensionList
    {
        get => GetElement<ExtensionList>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConditionalFormat>(deep);

}
/// <summary>
/// <para>Defines the PivotAreas Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:pivotAreas.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Spreadsheet.PivotArea &lt;x:pivotArea></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.PivotArea))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class PivotAreas : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13051;
    /// <inheritdoc/>
    public override string LocalName => "pivotAreas";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "count")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Pivot Area Count.</para>
    /// <para>Represents the following attribute in the schema: count </para>
    /// </summary>
    [SchemaAttr(0, "count")]
    public UInt32Value Count
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the PivotAreas class.
    /// </summary>
    public PivotAreas():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PivotAreas class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotAreas(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotAreas class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotAreas(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotAreas class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PivotAreas(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 22 == namespaceId && "pivotArea" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.PivotArea();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotAreas>(deep);

}
/// <summary>
/// <para>Defines the SlicerStyle Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:slicerStyle.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SlicerStyleElements &lt;x14:slicerStyleElements></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SlicerStyleElements), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SlicerStyle : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13052;
    /// <inheritdoc/>
    public override string LocalName => "slicerStyle";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "name")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SlicerStyle class.
    /// </summary>
    public SlicerStyle():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SlicerStyle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SlicerStyle(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SlicerStyle class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SlicerStyle(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SlicerStyle class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SlicerStyle(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "slicerStyleElements" == name)
    return new SlicerStyleElements();
    

    return null;
}

        private static readonly string[] eleTagNames = { "slicerStyleElements" };
    private static readonly byte[] eleNamespaceIds = { 53 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> SlicerStyleElements.</para>
    /// <para> Represents the following element tag in the schema: x14:slicerStyleElements </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public SlicerStyleElements SlicerStyleElements
    {
        get => GetElement<SlicerStyleElements>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerStyle>(deep);

}
/// <summary>
/// <para>Defines the SlicerStyleElement Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:slicerStyleElement.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SlicerStyleElement : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13053;
    /// <inheritdoc/>
    public override string LocalName => "slicerStyleElement";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SlicerStyleTypeValues>>(0, "type"),
		AttributeTag.Create<UInt32Value>(0, "dxfId")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> type.</para>
    /// <para>Represents the following attribute in the schema: type </para>
    /// </summary>
    [SchemaAttr(0, "type")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SlicerStyleTypeValues> Type
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SlicerStyleTypeValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> dxfId.</para>
    /// <para>Represents the following attribute in the schema: dxfId </para>
    /// </summary>
    [SchemaAttr(0, "dxfId")]
    public UInt32Value FormatId
    {
        get { return (UInt32Value)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SlicerStyleElement class.
    /// </summary>
    public SlicerStyleElement():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerStyleElement>(deep);

}
/// <summary>
/// <para>Defines the IgnoredError Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:ignoredError.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office.Excel.ReferenceSequence &lt;xne:sqref></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office.Excel.ReferenceSequence))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class IgnoredError : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13054;
    /// <inheritdoc/>
    public override string LocalName => "ignoredError";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<BooleanValue>(0, "evalError"),
		AttributeTag.Create<BooleanValue>(0, "twoDigitTextYear"),
		AttributeTag.Create<BooleanValue>(0, "numberStoredAsText"),
		AttributeTag.Create<BooleanValue>(0, "formula"),
		AttributeTag.Create<BooleanValue>(0, "formulaRange"),
		AttributeTag.Create<BooleanValue>(0, "unlockedFormula"),
		AttributeTag.Create<BooleanValue>(0, "emptyCellReference"),
		AttributeTag.Create<BooleanValue>(0, "listDataValidation"),
		AttributeTag.Create<BooleanValue>(0, "calculatedColumn")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> evalError.</para>
    /// <para>Represents the following attribute in the schema: evalError </para>
    /// </summary>
    [SchemaAttr(0, "evalError")]
    public BooleanValue EvalError
    {
        get { return (BooleanValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> twoDigitTextYear.</para>
    /// <para>Represents the following attribute in the schema: twoDigitTextYear </para>
    /// </summary>
    [SchemaAttr(0, "twoDigitTextYear")]
    public BooleanValue TwoDigitTextYear
    {
        get { return (BooleanValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> numberStoredAsText.</para>
    /// <para>Represents the following attribute in the schema: numberStoredAsText </para>
    /// </summary>
    [SchemaAttr(0, "numberStoredAsText")]
    public BooleanValue NumberStoredAsText
    {
        get { return (BooleanValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> formula.</para>
    /// <para>Represents the following attribute in the schema: formula </para>
    /// </summary>
    [SchemaAttr(0, "formula")]
    public BooleanValue Formula
    {
        get { return (BooleanValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> formulaRange.</para>
    /// <para>Represents the following attribute in the schema: formulaRange </para>
    /// </summary>
    [SchemaAttr(0, "formulaRange")]
    public BooleanValue FormulaRange
    {
        get { return (BooleanValue)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> unlockedFormula.</para>
    /// <para>Represents the following attribute in the schema: unlockedFormula </para>
    /// </summary>
    [SchemaAttr(0, "unlockedFormula")]
    public BooleanValue UnlockedFormula
    {
        get { return (BooleanValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> emptyCellReference.</para>
    /// <para>Represents the following attribute in the schema: emptyCellReference </para>
    /// </summary>
    [SchemaAttr(0, "emptyCellReference")]
    public BooleanValue EmptyCellReference
    {
        get { return (BooleanValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> listDataValidation.</para>
    /// <para>Represents the following attribute in the schema: listDataValidation </para>
    /// </summary>
    [SchemaAttr(0, "listDataValidation")]
    public BooleanValue ListDataValidation
    {
        get { return (BooleanValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> calculatedColumn.</para>
    /// <para>Represents the following attribute in the schema: calculatedColumn </para>
    /// </summary>
    [SchemaAttr(0, "calculatedColumn")]
    public BooleanValue CalculatedColumn
    {
        get { return (BooleanValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the IgnoredError class.
    /// </summary>
    public IgnoredError():base(){}
    
        /// <summary>
    ///Initializes a new instance of the IgnoredError class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public IgnoredError(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the IgnoredError class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public IgnoredError(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the IgnoredError class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public IgnoredError(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 32 == namespaceId && "sqref" == name)
    return new DocumentFormat.OpenXml.Office.Excel.ReferenceSequence();
    

    return null;
}

        private static readonly string[] eleTagNames = { "sqref" };
    private static readonly byte[] eleNamespaceIds = { 32 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ReferenceSequence.</para>
    /// <para> Represents the following element tag in the schema: xne:sqref </para>
    /// </summary>
    /// <remark>
    /// xmlns:xne = http://schemas.microsoft.com/office/excel/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Office.Excel.ReferenceSequence ReferenceSequence
    {
        get => GetElement<DocumentFormat.OpenXml.Office.Excel.ReferenceSequence>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<IgnoredError>(deep);

}
/// <summary>
/// <para>Defines the ProtectedRange Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:protectedRange.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office.Excel.ReferenceSequence &lt;xne:sqref></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office.Excel.ReferenceSequence))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ProtectedRange : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13055;
    /// <inheritdoc/>
    public override string LocalName => "protectedRange";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<HexBinaryValue>(0, "password"),
		AttributeTag.Create<StringValue>(0, "algorithmName"),
		AttributeTag.Create<Base64BinaryValue>(0, "hashValue"),
		AttributeTag.Create<Base64BinaryValue>(0, "saltValue"),
		AttributeTag.Create<UInt32Value>(0, "spinCount"),
		AttributeTag.Create<StringValue>(0, "name"),
		AttributeTag.Create<StringValue>(0, "securityDescriptor")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> password.</para>
    /// <para>Represents the following attribute in the schema: password </para>
    /// </summary>
    [SchemaAttr(0, "password")]
    public HexBinaryValue Password
    {
        get { return (HexBinaryValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> algorithmName.</para>
    /// <para>Represents the following attribute in the schema: algorithmName </para>
    /// </summary>
    [SchemaAttr(0, "algorithmName")]
    public StringValue AlgorithmName
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> hashValue.</para>
    /// <para>Represents the following attribute in the schema: hashValue </para>
    /// </summary>
    [SchemaAttr(0, "hashValue")]
    public Base64BinaryValue HashValue
    {
        get { return (Base64BinaryValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> saltValue.</para>
    /// <para>Represents the following attribute in the schema: saltValue </para>
    /// </summary>
    [SchemaAttr(0, "saltValue")]
    public Base64BinaryValue SaltValue
    {
        get { return (Base64BinaryValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> spinCount.</para>
    /// <para>Represents the following attribute in the schema: spinCount </para>
    /// </summary>
    [SchemaAttr(0, "spinCount")]
    public UInt32Value SpinCount
    {
        get { return (UInt32Value)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> securityDescriptor.</para>
    /// <para>Represents the following attribute in the schema: securityDescriptor </para>
    /// </summary>
    [SchemaAttr(0, "securityDescriptor")]
    public StringValue SecurityDescriptor
    {
        get { return (StringValue)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ProtectedRange class.
    /// </summary>
    public ProtectedRange():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ProtectedRange class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ProtectedRange(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ProtectedRange class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ProtectedRange(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ProtectedRange class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ProtectedRange(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 32 == namespaceId && "sqref" == name)
    return new DocumentFormat.OpenXml.Office.Excel.ReferenceSequence();
    

    return null;
}

        private static readonly string[] eleTagNames = { "sqref" };
    private static readonly byte[] eleNamespaceIds = { 32 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ReferenceSequence.</para>
    /// <para> Represents the following element tag in the schema: xne:sqref </para>
    /// </summary>
    /// <remark>
    /// xmlns:xne = http://schemas.microsoft.com/office/excel/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Office.Excel.ReferenceSequence ReferenceSequence
    {
        get => GetElement<DocumentFormat.OpenXml.Office.Excel.ReferenceSequence>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ProtectedRange>(deep);

}
/// <summary>
/// <para>Defines the CustomFilter Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:customFilter.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class CustomFilter : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13056;
    /// <inheritdoc/>
    public override string LocalName => "customFilter";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Spreadsheet.FilterOperatorValues>>(0, "operator"),
		AttributeTag.Create<StringValue>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> operator.</para>
    /// <para>Represents the following attribute in the schema: operator </para>
    /// </summary>
    [SchemaAttr(0, "operator")]
    public EnumValue<DocumentFormat.OpenXml.Spreadsheet.FilterOperatorValues> Operator
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Spreadsheet.FilterOperatorValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public StringValue Val
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the CustomFilter class.
    /// </summary>
    public CustomFilter():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomFilter>(deep);

}
/// <summary>
/// <para>Defines the ListItem Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:item.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ListItem : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13057;
    /// <inheritdoc/>
    public override string LocalName => "item";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public StringValue Val
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ListItem class.
    /// </summary>
    public ListItem():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ListItem>(deep);

}
/// <summary>
/// <para>Defines the ListItems Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:itemLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ListItem &lt;x14:item></description></item>
///<item><description>ExtensionList &lt;x14:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ListItem), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class ListItems : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13058;
    /// <inheritdoc/>
    public override string LocalName => "itemLst";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ListItems class.
    /// </summary>
    public ListItems():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ListItems class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ListItems(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ListItems class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ListItems(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ListItems class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ListItems(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "item" == name)
    return new ListItem();
    
if( 53 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ListItems>(deep);

}
/// <summary>
/// <para>Defines the Slicer Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:slicer.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ExtensionList &lt;x14:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class Slicer : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13059;
    /// <inheritdoc/>
    public override string LocalName => "slicer";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "name"),
		AttributeTag.Create<StringValue>(0, "cache"),
		AttributeTag.Create<StringValue>(0, "caption"),
		AttributeTag.Create<UInt32Value>(0, "startItem"),
		AttributeTag.Create<UInt32Value>(0, "columnCount"),
		AttributeTag.Create<BooleanValue>(0, "showCaption"),
		AttributeTag.Create<UInt32Value>(0, "level"),
		AttributeTag.Create<StringValue>(0, "style"),
		AttributeTag.Create<BooleanValue>(0, "lockedPosition"),
		AttributeTag.Create<UInt32Value>(0, "rowHeight")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> cache.</para>
    /// <para>Represents the following attribute in the schema: cache </para>
    /// </summary>
    [SchemaAttr(0, "cache")]
    public StringValue Cache
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> caption.</para>
    /// <para>Represents the following attribute in the schema: caption </para>
    /// </summary>
    [SchemaAttr(0, "caption")]
    public StringValue Caption
    {
        get { return (StringValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> startItem.</para>
    /// <para>Represents the following attribute in the schema: startItem </para>
    /// </summary>
    [SchemaAttr(0, "startItem")]
    public UInt32Value StartItem
    {
        get { return (UInt32Value)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> columnCount.</para>
    /// <para>Represents the following attribute in the schema: columnCount </para>
    /// </summary>
    [SchemaAttr(0, "columnCount")]
    public UInt32Value ColumnCount
    {
        get { return (UInt32Value)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    
    /// <summary>
    /// <para> showCaption.</para>
    /// <para>Represents the following attribute in the schema: showCaption </para>
    /// </summary>
    [SchemaAttr(0, "showCaption")]
    public BooleanValue ShowCaption
    {
        get { return (BooleanValue)Attributes[5].Value; }
        set { Attributes[5].Value = value; }
    }
    
    /// <summary>
    /// <para> level.</para>
    /// <para>Represents the following attribute in the schema: level </para>
    /// </summary>
    [SchemaAttr(0, "level")]
    public UInt32Value Level
    {
        get { return (UInt32Value)Attributes[6].Value; }
        set { Attributes[6].Value = value; }
    }
    
    /// <summary>
    /// <para> style.</para>
    /// <para>Represents the following attribute in the schema: style </para>
    /// </summary>
    [SchemaAttr(0, "style")]
    public StringValue Style
    {
        get { return (StringValue)Attributes[7].Value; }
        set { Attributes[7].Value = value; }
    }
    
    /// <summary>
    /// <para> lockedPosition.</para>
    /// <para>Represents the following attribute in the schema: lockedPosition </para>
    /// </summary>
    [SchemaAttr(0, "lockedPosition")]
    public BooleanValue LockedPosition
    {
        get { return (BooleanValue)Attributes[8].Value; }
        set { Attributes[8].Value = value; }
    }
    
    /// <summary>
    /// <para> rowHeight.</para>
    /// <para>Represents the following attribute in the schema: rowHeight </para>
    /// </summary>
    [SchemaAttr(0, "rowHeight")]
    public UInt32Value RowHeight
    {
        get { return (UInt32Value)Attributes[9].Value; }
        set { Attributes[9].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Slicer class.
    /// </summary>
    public Slicer():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Slicer class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Slicer(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Slicer class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Slicer(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Slicer class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Slicer(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "extLst" };
    private static readonly byte[] eleNamespaceIds = { 53 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: x14:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public ExtensionList ExtensionList
    {
        get => GetElement<ExtensionList>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Slicer>(deep);

}
/// <summary>
/// <para>Defines the OlapSlicerCache Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:olap.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>OlapSlicerCacheLevelsData &lt;x14:levels></description></item>
///<item><description>OlapSlicerCacheSelections &lt;x14:selections></description></item>
///<item><description>ExtensionList &lt;x14:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(OlapSlicerCacheLevelsData), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(OlapSlicerCacheSelections), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class OlapSlicerCache : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13060;
    /// <inheritdoc/>
    public override string LocalName => "olap";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "pivotCacheId")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> pivotCacheId.</para>
    /// <para>Represents the following attribute in the schema: pivotCacheId </para>
    /// </summary>
    [SchemaAttr(0, "pivotCacheId")]
    public UInt32Value PivotCacheId
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the OlapSlicerCache class.
    /// </summary>
    public OlapSlicerCache():base(){}
    
        /// <summary>
    ///Initializes a new instance of the OlapSlicerCache class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OlapSlicerCache(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the OlapSlicerCache class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OlapSlicerCache(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the OlapSlicerCache class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public OlapSlicerCache(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "levels" == name)
    return new OlapSlicerCacheLevelsData();
    
if( 53 == namespaceId && "selections" == name)
    return new OlapSlicerCacheSelections();
    
if( 53 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "levels","selections","extLst" };
    private static readonly byte[] eleNamespaceIds = { 53,53,53 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> OlapSlicerCacheLevelsData.</para>
    /// <para> Represents the following element tag in the schema: x14:levels </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public OlapSlicerCacheLevelsData OlapSlicerCacheLevelsData
    {
        get => GetElement<OlapSlicerCacheLevelsData>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> OlapSlicerCacheSelections.</para>
    /// <para> Represents the following element tag in the schema: x14:selections </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public OlapSlicerCacheSelections OlapSlicerCacheSelections
    {
        get => GetElement<OlapSlicerCacheSelections>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: x14:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public ExtensionList ExtensionList
    {
        get => GetElement<ExtensionList>(2);
        set => SetElement(2, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<OlapSlicerCache>(deep);

}
/// <summary>
/// <para>Defines the TabularSlicerCache Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:tabular.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TabularSlicerCacheItems &lt;x14:items></description></item>
///<item><description>ExtensionList &lt;x14:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(TabularSlicerCacheItems), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(ExtensionList), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class TabularSlicerCache : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13061;
    /// <inheritdoc/>
    public override string LocalName => "tabular";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "pivotCacheId"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.TabularSlicerCacheSortOrderValues>>(0, "sortOrder"),
		AttributeTag.Create<BooleanValue>(0, "customListSort"),
		AttributeTag.Create<BooleanValue>(0, "showMissing"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SlicerCacheCrossFilterValues>>(0, "crossFilter")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> pivotCacheId.</para>
    /// <para>Represents the following attribute in the schema: pivotCacheId </para>
    /// </summary>
    [SchemaAttr(0, "pivotCacheId")]
    public UInt32Value PivotCacheId
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> sortOrder.</para>
    /// <para>Represents the following attribute in the schema: sortOrder </para>
    /// </summary>
    [SchemaAttr(0, "sortOrder")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.TabularSlicerCacheSortOrderValues> SortOrder
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.TabularSlicerCacheSortOrderValues>)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> customListSort.</para>
    /// <para>Represents the following attribute in the schema: customListSort </para>
    /// </summary>
    [SchemaAttr(0, "customListSort")]
    public BooleanValue CustomListSort
    {
        get { return (BooleanValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> showMissing.</para>
    /// <para>Represents the following attribute in the schema: showMissing </para>
    /// </summary>
    [SchemaAttr(0, "showMissing")]
    public BooleanValue ShowMissing
    {
        get { return (BooleanValue)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> crossFilter.</para>
    /// <para>Represents the following attribute in the schema: crossFilter </para>
    /// </summary>
    [SchemaAttr(0, "crossFilter")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SlicerCacheCrossFilterValues> CrossFilter
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SlicerCacheCrossFilterValues>)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the TabularSlicerCache class.
    /// </summary>
    public TabularSlicerCache():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TabularSlicerCache class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TabularSlicerCache(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TabularSlicerCache class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TabularSlicerCache(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TabularSlicerCache class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TabularSlicerCache(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "items" == name)
    return new TabularSlicerCacheItems();
    
if( 53 == namespaceId && "extLst" == name)
    return new ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "items","extLst" };
    private static readonly byte[] eleNamespaceIds = { 53,53 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> TabularSlicerCacheItems.</para>
    /// <para> Represents the following element tag in the schema: x14:items </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public TabularSlicerCacheItems TabularSlicerCacheItems
    {
        get => GetElement<TabularSlicerCacheItems>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> ExtensionList.</para>
    /// <para> Represents the following element tag in the schema: x14:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public ExtensionList ExtensionList
    {
        get => GetElement<ExtensionList>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TabularSlicerCache>(deep);

}
/// <summary>
/// <para>Defines the SlicerCachePivotTable Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:pivotTable.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SlicerCachePivotTable : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13062;
    /// <inheritdoc/>
    public override string LocalName => "pivotTable";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "tabId"),
		AttributeTag.Create<StringValue>(0, "name")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> tabId.</para>
    /// <para>Represents the following attribute in the schema: tabId </para>
    /// </summary>
    [SchemaAttr(0, "tabId")]
    public UInt32Value TabId
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> name.</para>
    /// <para>Represents the following attribute in the schema: name </para>
    /// </summary>
    [SchemaAttr(0, "name")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the SlicerCachePivotTable class.
    /// </summary>
    public SlicerCachePivotTable():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerCachePivotTable>(deep);

}
/// <summary>
/// <para>Defines the OlapSlicerCacheItemParent Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:p.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class OlapSlicerCacheItemParent : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13063;
    /// <inheritdoc/>
    public override string LocalName => "p";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "n")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> n.</para>
    /// <para>Represents the following attribute in the schema: n </para>
    /// </summary>
    [SchemaAttr(0, "n")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the OlapSlicerCacheItemParent class.
    /// </summary>
    public OlapSlicerCacheItemParent():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<OlapSlicerCacheItemParent>(deep);

}
/// <summary>
/// <para>Defines the OlapSlicerCacheItem Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:i.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>OlapSlicerCacheItemParent &lt;x14:p></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(OlapSlicerCacheItemParent), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class OlapSlicerCacheItem : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13064;
    /// <inheritdoc/>
    public override string LocalName => "i";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "n"),
		AttributeTag.Create<StringValue>(0, "c"),
		AttributeTag.Create<BooleanValue>(0, "nd")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> n.</para>
    /// <para>Represents the following attribute in the schema: n </para>
    /// </summary>
    [SchemaAttr(0, "n")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> c.</para>
    /// <para>Represents the following attribute in the schema: c </para>
    /// </summary>
    [SchemaAttr(0, "c")]
    public StringValue DisplayName
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> nd.</para>
    /// <para>Represents the following attribute in the schema: nd </para>
    /// </summary>
    [SchemaAttr(0, "nd")]
    public BooleanValue NonDisplay
    {
        get { return (BooleanValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the OlapSlicerCacheItem class.
    /// </summary>
    public OlapSlicerCacheItem():base(){}
    
        /// <summary>
    ///Initializes a new instance of the OlapSlicerCacheItem class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OlapSlicerCacheItem(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the OlapSlicerCacheItem class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OlapSlicerCacheItem(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the OlapSlicerCacheItem class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public OlapSlicerCacheItem(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "p" == name)
    return new OlapSlicerCacheItemParent();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<OlapSlicerCacheItem>(deep);

}
/// <summary>
/// <para>Defines the OlapSlicerCacheRange Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:range.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>OlapSlicerCacheItem &lt;x14:i></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(OlapSlicerCacheItem), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class OlapSlicerCacheRange : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13065;
    /// <inheritdoc/>
    public override string LocalName => "range";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "startItem")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> startItem.</para>
    /// <para>Represents the following attribute in the schema: startItem </para>
    /// </summary>
    [SchemaAttr(0, "startItem")]
    public UInt32Value StartItem
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the OlapSlicerCacheRange class.
    /// </summary>
    public OlapSlicerCacheRange():base(){}
    
        /// <summary>
    ///Initializes a new instance of the OlapSlicerCacheRange class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OlapSlicerCacheRange(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the OlapSlicerCacheRange class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OlapSlicerCacheRange(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the OlapSlicerCacheRange class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public OlapSlicerCacheRange(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "i" == name)
    return new OlapSlicerCacheItem();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<OlapSlicerCacheRange>(deep);

}
/// <summary>
/// <para>Defines the OlapSlicerCacheRanges Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:ranges.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>OlapSlicerCacheRange &lt;x14:range></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(OlapSlicerCacheRange), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class OlapSlicerCacheRanges : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13066;
    /// <inheritdoc/>
    public override string LocalName => "ranges";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the OlapSlicerCacheRanges class.
    /// </summary>
    public OlapSlicerCacheRanges():base(){}
    
        /// <summary>
    ///Initializes a new instance of the OlapSlicerCacheRanges class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OlapSlicerCacheRanges(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the OlapSlicerCacheRanges class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OlapSlicerCacheRanges(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the OlapSlicerCacheRanges class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public OlapSlicerCacheRanges(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "range" == name)
    return new OlapSlicerCacheRange();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<OlapSlicerCacheRanges>(deep);

}
/// <summary>
/// <para>Defines the OlapSlicerCacheLevelData Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:level.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>OlapSlicerCacheRanges &lt;x14:ranges></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(OlapSlicerCacheRanges), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class OlapSlicerCacheLevelData : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13067;
    /// <inheritdoc/>
    public override string LocalName => "level";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "uniqueName"),
		AttributeTag.Create<StringValue>(0, "sourceCaption"),
		AttributeTag.Create<UInt32Value>(0, "count"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.OlapSlicerCacheSortOrderValues>>(0, "sortOrder"),
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SlicerCacheCrossFilterValues>>(0, "crossFilter")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> uniqueName.</para>
    /// <para>Represents the following attribute in the schema: uniqueName </para>
    /// </summary>
    [SchemaAttr(0, "uniqueName")]
    public StringValue UniqueName
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> sourceCaption.</para>
    /// <para>Represents the following attribute in the schema: sourceCaption </para>
    /// </summary>
    [SchemaAttr(0, "sourceCaption")]
    public StringValue SourceCaption
    {
        get { return (StringValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> count.</para>
    /// <para>Represents the following attribute in the schema: count </para>
    /// </summary>
    [SchemaAttr(0, "count")]
    public UInt32Value Count
    {
        get { return (UInt32Value)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    
    /// <summary>
    /// <para> sortOrder.</para>
    /// <para>Represents the following attribute in the schema: sortOrder </para>
    /// </summary>
    [SchemaAttr(0, "sortOrder")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.OlapSlicerCacheSortOrderValues> SortOrder
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.OlapSlicerCacheSortOrderValues>)Attributes[3].Value; }
        set { Attributes[3].Value = value; }
    }
    
    /// <summary>
    /// <para> crossFilter.</para>
    /// <para>Represents the following attribute in the schema: crossFilter </para>
    /// </summary>
    [SchemaAttr(0, "crossFilter")]
    public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SlicerCacheCrossFilterValues> CrossFilter
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SlicerCacheCrossFilterValues>)Attributes[4].Value; }
        set { Attributes[4].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the OlapSlicerCacheLevelData class.
    /// </summary>
    public OlapSlicerCacheLevelData():base(){}
    
        /// <summary>
    ///Initializes a new instance of the OlapSlicerCacheLevelData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OlapSlicerCacheLevelData(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the OlapSlicerCacheLevelData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OlapSlicerCacheLevelData(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the OlapSlicerCacheLevelData class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public OlapSlicerCacheLevelData(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "ranges" == name)
    return new OlapSlicerCacheRanges();
    

    return null;
}

        private static readonly string[] eleTagNames = { "ranges" };
    private static readonly byte[] eleNamespaceIds = { 53 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> OlapSlicerCacheRanges.</para>
    /// <para> Represents the following element tag in the schema: x14:ranges </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public OlapSlicerCacheRanges OlapSlicerCacheRanges
    {
        get => GetElement<OlapSlicerCacheRanges>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<OlapSlicerCacheLevelData>(deep);

}
/// <summary>
/// <para>Defines the OlapSlicerCacheLevelsData Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:levels.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>OlapSlicerCacheLevelData &lt;x14:level></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(OlapSlicerCacheLevelData), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class OlapSlicerCacheLevelsData : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13068;
    /// <inheritdoc/>
    public override string LocalName => "levels";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "count")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> count.</para>
    /// <para>Represents the following attribute in the schema: count </para>
    /// </summary>
    [SchemaAttr(0, "count")]
    public UInt32Value Count
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the OlapSlicerCacheLevelsData class.
    /// </summary>
    public OlapSlicerCacheLevelsData():base(){}
    
        /// <summary>
    ///Initializes a new instance of the OlapSlicerCacheLevelsData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OlapSlicerCacheLevelsData(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the OlapSlicerCacheLevelsData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OlapSlicerCacheLevelsData(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the OlapSlicerCacheLevelsData class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public OlapSlicerCacheLevelsData(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "level" == name)
    return new OlapSlicerCacheLevelData();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<OlapSlicerCacheLevelsData>(deep);

}
/// <summary>
/// <para>Defines the OlapSlicerCacheSelections Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:selections.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>OlapSlicerCacheSelection &lt;x14:selection></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(OlapSlicerCacheSelection), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class OlapSlicerCacheSelections : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13069;
    /// <inheritdoc/>
    public override string LocalName => "selections";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "count")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> count.</para>
    /// <para>Represents the following attribute in the schema: count </para>
    /// </summary>
    [SchemaAttr(0, "count")]
    public UInt32Value Count
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the OlapSlicerCacheSelections class.
    /// </summary>
    public OlapSlicerCacheSelections():base(){}
    
        /// <summary>
    ///Initializes a new instance of the OlapSlicerCacheSelections class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OlapSlicerCacheSelections(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the OlapSlicerCacheSelections class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OlapSlicerCacheSelections(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the OlapSlicerCacheSelections class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public OlapSlicerCacheSelections(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "selection" == name)
    return new OlapSlicerCacheSelection();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<OlapSlicerCacheSelections>(deep);

}
/// <summary>
/// <para>Defines the OlapSlicerCacheSelection Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:selection.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>OlapSlicerCacheItemParent &lt;x14:p></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(OlapSlicerCacheItemParent), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class OlapSlicerCacheSelection : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13070;
    /// <inheritdoc/>
    public override string LocalName => "selection";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(0, "n")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> n.</para>
    /// <para>Represents the following attribute in the schema: n </para>
    /// </summary>
    [SchemaAttr(0, "n")]
    public StringValue Name
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the OlapSlicerCacheSelection class.
    /// </summary>
    public OlapSlicerCacheSelection():base(){}
    
        /// <summary>
    ///Initializes a new instance of the OlapSlicerCacheSelection class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OlapSlicerCacheSelection(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the OlapSlicerCacheSelection class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OlapSlicerCacheSelection(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the OlapSlicerCacheSelection class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public OlapSlicerCacheSelection(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "p" == name)
    return new OlapSlicerCacheItemParent();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<OlapSlicerCacheSelection>(deep);

}
/// <summary>
/// <para>Defines the TabularSlicerCacheItems Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:items.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>TabularSlicerCacheItem &lt;x14:i></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(TabularSlicerCacheItem), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class TabularSlicerCacheItems : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13071;
    /// <inheritdoc/>
    public override string LocalName => "items";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "count")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> count.</para>
    /// <para>Represents the following attribute in the schema: count </para>
    /// </summary>
    [SchemaAttr(0, "count")]
    public UInt32Value Count
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the TabularSlicerCacheItems class.
    /// </summary>
    public TabularSlicerCacheItems():base(){}
    
        /// <summary>
    ///Initializes a new instance of the TabularSlicerCacheItems class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TabularSlicerCacheItems(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the TabularSlicerCacheItems class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public TabularSlicerCacheItems(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the TabularSlicerCacheItems class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public TabularSlicerCacheItems(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "i" == name)
    return new TabularSlicerCacheItem();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TabularSlicerCacheItems>(deep);

}
/// <summary>
/// <para>Defines the TabularSlicerCacheItem Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:i.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class TabularSlicerCacheItem : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13072;
    /// <inheritdoc/>
    public override string LocalName => "i";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(0, "x"),
		AttributeTag.Create<BooleanValue>(0, "s"),
		AttributeTag.Create<BooleanValue>(0, "nd")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> x.</para>
    /// <para>Represents the following attribute in the schema: x </para>
    /// </summary>
    [SchemaAttr(0, "x")]
    public UInt32Value Atom
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> s.</para>
    /// <para>Represents the following attribute in the schema: s </para>
    /// </summary>
    [SchemaAttr(0, "s")]
    public BooleanValue IsSelected
    {
        get { return (BooleanValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    
    /// <summary>
    /// <para> nd.</para>
    /// <para>Represents the following attribute in the schema: nd </para>
    /// </summary>
    [SchemaAttr(0, "nd")]
    public BooleanValue NonDisplay
    {
        get { return (BooleanValue)Attributes[2].Value; }
        set { Attributes[2].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the TabularSlicerCacheItem class.
    /// </summary>
    public TabularSlicerCacheItem():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<TabularSlicerCacheItem>(deep);

}
/// <summary>
/// <para>Defines the SlicerCachePivotTables Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:pivotTables.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SlicerCachePivotTable &lt;x14:pivotTable></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SlicerCachePivotTable), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SlicerCachePivotTables : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13073;
    /// <inheritdoc/>
    public override string LocalName => "pivotTables";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the SlicerCachePivotTables class.
    /// </summary>
    public SlicerCachePivotTables():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SlicerCachePivotTables class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SlicerCachePivotTables(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SlicerCachePivotTables class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SlicerCachePivotTables(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SlicerCachePivotTables class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SlicerCachePivotTables(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "pivotTable" == name)
    return new SlicerCachePivotTable();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerCachePivotTables>(deep);

}
/// <summary>
/// <para>Defines the SlicerCacheData Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:data.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>OlapSlicerCache &lt;x14:olap></description></item>
///<item><description>TabularSlicerCache &lt;x14:tabular></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(OlapSlicerCache), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(TabularSlicerCache), FileFormatVersions.Office2010)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SlicerCacheData : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13074;
    /// <inheritdoc/>
    public override string LocalName => "data";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the SlicerCacheData class.
    /// </summary>
    public SlicerCacheData():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SlicerCacheData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SlicerCacheData(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SlicerCacheData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SlicerCacheData(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SlicerCacheData class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SlicerCacheData(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 53 == namespaceId && "olap" == name)
    return new OlapSlicerCache();
    
if( 53 == namespaceId && "tabular" == name)
    return new TabularSlicerCache();
    

    return null;
}

        private static readonly string[] eleTagNames = { "olap","tabular" };
    private static readonly byte[] eleNamespaceIds = { 53,53 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneChoice;
    
        /// <summary>
    /// <para> OlapSlicerCache.</para>
    /// <para> Represents the following element tag in the schema: x14:olap </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public OlapSlicerCache OlapSlicerCache
    {
        get => GetElement<OlapSlicerCache>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> TabularSlicerCache.</para>
    /// <para> Represents the following element tag in the schema: x14:tabular </para>
    /// </summary>
    /// <remark>
    /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
    /// </remark>
    public TabularSlicerCache TabularSlicerCache
    {
        get => GetElement<TabularSlicerCache>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerCacheData>(deep);

}
/// <summary>
/// <para>Defines the SlicerCacheDefinitionExtensionList Class.</para>
/// <para>This class is available in Office 2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is x14:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Spreadsheet.SlicerCacheDefinitionExtension &lt;x:ext></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Spreadsheet.SlicerCacheDefinitionExtension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class SlicerCacheDefinitionExtensionList : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13075;
    /// <inheritdoc/>
    public override string LocalName => "extLst";
    
    internal override byte NamespaceId => 53;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2010;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the SlicerCacheDefinitionExtensionList class.
    /// </summary>
    public SlicerCacheDefinitionExtensionList():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SlicerCacheDefinitionExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SlicerCacheDefinitionExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SlicerCacheDefinitionExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SlicerCacheDefinitionExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SlicerCacheDefinitionExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SlicerCacheDefinitionExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 22 == namespaceId && "ext" == name)
    return new DocumentFormat.OpenXml.Spreadsheet.SlicerCacheDefinitionExtension();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerCacheDefinitionExtensionList>(deep);

}
/// <summary>
/// Defines the DisplayBlanksAsValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum DisplayBlanksAsValues
{  
	///<summary>
///span.
///<para>When the item is serialized out as xml, its value is "span".</para>
///</summary>
[EnumString("span")]
Span,
///<summary>
///gap.
///<para>When the item is serialized out as xml, its value is "gap".</para>
///</summary>
[EnumString("gap")]
Gap,
///<summary>
///zero.
///<para>When the item is serialized out as xml, its value is "zero".</para>
///</summary>
[EnumString("zero")]
Zero,
 
}
/// <summary>
/// Defines the SparklineAxisMinMaxValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum SparklineAxisMinMaxValues
{  
	///<summary>
///individual.
///<para>When the item is serialized out as xml, its value is "individual".</para>
///</summary>
[EnumString("individual")]
Individual,
///<summary>
///group.
///<para>When the item is serialized out as xml, its value is "group".</para>
///</summary>
[EnumString("group")]
Group,
///<summary>
///custom.
///<para>When the item is serialized out as xml, its value is "custom".</para>
///</summary>
[EnumString("custom")]
Custom,
 
}
/// <summary>
/// Defines the SparklineTypeValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum SparklineTypeValues
{  
	///<summary>
///line.
///<para>When the item is serialized out as xml, its value is "line".</para>
///</summary>
[EnumString("line")]
Line,
///<summary>
///column.
///<para>When the item is serialized out as xml, its value is "column".</para>
///</summary>
[EnumString("column")]
Column,
///<summary>
///stacked.
///<para>When the item is serialized out as xml, its value is "stacked".</para>
///</summary>
[EnumString("stacked")]
Stacked,
 
}
/// <summary>
/// Defines the PivotShowAsValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum PivotShowAsValues
{  
	///<summary>
///percentOfParent.
///<para>When the item is serialized out as xml, its value is "percentOfParent".</para>
///</summary>
[EnumString("percentOfParent")]
PercentOfParent,
///<summary>
///percentOfParentRow.
///<para>When the item is serialized out as xml, its value is "percentOfParentRow".</para>
///</summary>
[EnumString("percentOfParentRow")]
PercentOfParentRow,
///<summary>
///percentOfParentCol.
///<para>When the item is serialized out as xml, its value is "percentOfParentCol".</para>
///</summary>
[EnumString("percentOfParentCol")]
PercentOfParentColumn,
///<summary>
///percentOfRunningTotal.
///<para>When the item is serialized out as xml, its value is "percentOfRunningTotal".</para>
///</summary>
[EnumString("percentOfRunningTotal")]
PercentOfRunningTotal,
///<summary>
///rankAscending.
///<para>When the item is serialized out as xml, its value is "rankAscending".</para>
///</summary>
[EnumString("rankAscending")]
RankAscending,
///<summary>
///rankDescending.
///<para>When the item is serialized out as xml, its value is "rankDescending".</para>
///</summary>
[EnumString("rankDescending")]
RankDescending,
 
}
/// <summary>
/// Defines the DataBarDirectionValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum DataBarDirectionValues
{  
	///<summary>
///context.
///<para>When the item is serialized out as xml, its value is "context".</para>
///</summary>
[EnumString("context")]
Context,
///<summary>
///leftToRight.
///<para>When the item is serialized out as xml, its value is "leftToRight".</para>
///</summary>
[EnumString("leftToRight")]
LeftToRight,
///<summary>
///rightToLeft.
///<para>When the item is serialized out as xml, its value is "rightToLeft".</para>
///</summary>
[EnumString("rightToLeft")]
RightToLeft,
 
}
/// <summary>
/// Defines the DataBarAxisPositionValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum DataBarAxisPositionValues
{  
	///<summary>
///automatic.
///<para>When the item is serialized out as xml, its value is "automatic".</para>
///</summary>
[EnumString("automatic")]
Automatic,
///<summary>
///middle.
///<para>When the item is serialized out as xml, its value is "middle".</para>
///</summary>
[EnumString("middle")]
Middle,
///<summary>
///none.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
 
}
/// <summary>
/// Defines the ConditionalFormattingValueObjectTypeValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ConditionalFormattingValueObjectTypeValues
{  
	///<summary>
///num.
///<para>When the item is serialized out as xml, its value is "num".</para>
///</summary>
[EnumString("num")]
Numeric,
///<summary>
///percent.
///<para>When the item is serialized out as xml, its value is "percent".</para>
///</summary>
[EnumString("percent")]
Percent,
///<summary>
///max.
///<para>When the item is serialized out as xml, its value is "max".</para>
///</summary>
[EnumString("max")]
Max,
///<summary>
///min.
///<para>When the item is serialized out as xml, its value is "min".</para>
///</summary>
[EnumString("min")]
Min,
///<summary>
///formula.
///<para>When the item is serialized out as xml, its value is "formula".</para>
///</summary>
[EnumString("formula")]
Formula,
///<summary>
///percentile.
///<para>When the item is serialized out as xml, its value is "percentile".</para>
///</summary>
[EnumString("percentile")]
Percentile,
///<summary>
///autoMin.
///<para>When the item is serialized out as xml, its value is "autoMin".</para>
///</summary>
[EnumString("autoMin")]
AutoMin,
///<summary>
///autoMax.
///<para>When the item is serialized out as xml, its value is "autoMax".</para>
///</summary>
[EnumString("autoMax")]
AutoMax,
 
}
/// <summary>
/// Defines the IconSetTypeValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum IconSetTypeValues
{  
	///<summary>
///3Arrows.
///<para>When the item is serialized out as xml, its value is "3Arrows".</para>
///</summary>
[EnumString("3Arrows")]
ThreeArrows,
///<summary>
///3ArrowsGray.
///<para>When the item is serialized out as xml, its value is "3ArrowsGray".</para>
///</summary>
[EnumString("3ArrowsGray")]
ThreeArrowsGray,
///<summary>
///3Flags.
///<para>When the item is serialized out as xml, its value is "3Flags".</para>
///</summary>
[EnumString("3Flags")]
ThreeFlags,
///<summary>
///3TrafficLights1.
///<para>When the item is serialized out as xml, its value is "3TrafficLights1".</para>
///</summary>
[EnumString("3TrafficLights1")]
ThreeTrafficLights1,
///<summary>
///3TrafficLights2.
///<para>When the item is serialized out as xml, its value is "3TrafficLights2".</para>
///</summary>
[EnumString("3TrafficLights2")]
ThreeTrafficLights2,
///<summary>
///3Signs.
///<para>When the item is serialized out as xml, its value is "3Signs".</para>
///</summary>
[EnumString("3Signs")]
ThreeSigns,
///<summary>
///3Symbols.
///<para>When the item is serialized out as xml, its value is "3Symbols".</para>
///</summary>
[EnumString("3Symbols")]
ThreeSymbols,
///<summary>
///3Symbols2.
///<para>When the item is serialized out as xml, its value is "3Symbols2".</para>
///</summary>
[EnumString("3Symbols2")]
ThreeSymbols2,
///<summary>
///4Arrows.
///<para>When the item is serialized out as xml, its value is "4Arrows".</para>
///</summary>
[EnumString("4Arrows")]
FourArrows,
///<summary>
///4ArrowsGray.
///<para>When the item is serialized out as xml, its value is "4ArrowsGray".</para>
///</summary>
[EnumString("4ArrowsGray")]
FourArrowsGray,
///<summary>
///4RedToBlack.
///<para>When the item is serialized out as xml, its value is "4RedToBlack".</para>
///</summary>
[EnumString("4RedToBlack")]
FourRedToBlack,
///<summary>
///4Rating.
///<para>When the item is serialized out as xml, its value is "4Rating".</para>
///</summary>
[EnumString("4Rating")]
FourRating,
///<summary>
///4TrafficLights.
///<para>When the item is serialized out as xml, its value is "4TrafficLights".</para>
///</summary>
[EnumString("4TrafficLights")]
FourTrafficLights,
///<summary>
///5Arrows.
///<para>When the item is serialized out as xml, its value is "5Arrows".</para>
///</summary>
[EnumString("5Arrows")]
FiveArrows,
///<summary>
///5ArrowsGray.
///<para>When the item is serialized out as xml, its value is "5ArrowsGray".</para>
///</summary>
[EnumString("5ArrowsGray")]
FiveArrowsGray,
///<summary>
///5Rating.
///<para>When the item is serialized out as xml, its value is "5Rating".</para>
///</summary>
[EnumString("5Rating")]
FiveRating,
///<summary>
///5Quarters.
///<para>When the item is serialized out as xml, its value is "5Quarters".</para>
///</summary>
[EnumString("5Quarters")]
FiveQuarters,
///<summary>
///3Stars.
///<para>When the item is serialized out as xml, its value is "3Stars".</para>
///</summary>
[EnumString("3Stars")]
ThreeStars,
///<summary>
///3Triangles.
///<para>When the item is serialized out as xml, its value is "3Triangles".</para>
///</summary>
[EnumString("3Triangles")]
ThreeTriangles,
///<summary>
///5Boxes.
///<para>When the item is serialized out as xml, its value is "5Boxes".</para>
///</summary>
[EnumString("5Boxes")]
FiveBoxes,
///<summary>
///NoIcons.
///<para>When the item is serialized out as xml, its value is "NoIcons".</para>
///</summary>
[EnumString("NoIcons")]
NoIcons,
 
}
/// <summary>
/// Defines the PivotEditValueTypeValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum PivotEditValueTypeValues
{  
	///<summary>
///number.
///<para>When the item is serialized out as xml, its value is "number".</para>
///</summary>
[EnumString("number")]
Number,
///<summary>
///dateTime.
///<para>When the item is serialized out as xml, its value is "dateTime".</para>
///</summary>
[EnumString("dateTime")]
DateTime,
///<summary>
///string.
///<para>When the item is serialized out as xml, its value is "string".</para>
///</summary>
[EnumString("string")]
String,
///<summary>
///boolean.
///<para>When the item is serialized out as xml, its value is "boolean".</para>
///</summary>
[EnumString("boolean")]
Boolean,
///<summary>
///error.
///<para>When the item is serialized out as xml, its value is "error".</para>
///</summary>
[EnumString("error")]
Error,
 
}
/// <summary>
/// Defines the AllocationMethodValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum AllocationMethodValues
{  
	///<summary>
///equalAllocation.
///<para>When the item is serialized out as xml, its value is "equalAllocation".</para>
///</summary>
[EnumString("equalAllocation")]
EqualAllocation,
///<summary>
///equalIncrement.
///<para>When the item is serialized out as xml, its value is "equalIncrement".</para>
///</summary>
[EnumString("equalIncrement")]
EqualIncrement,
///<summary>
///weightedAllocation.
///<para>When the item is serialized out as xml, its value is "weightedAllocation".</para>
///</summary>
[EnumString("weightedAllocation")]
WeightedAllocation,
///<summary>
///weightedIncrement.
///<para>When the item is serialized out as xml, its value is "weightedIncrement".</para>
///</summary>
[EnumString("weightedIncrement")]
WeightedIncrement,
 
}
/// <summary>
/// Defines the SlicerStyleTypeValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum SlicerStyleTypeValues
{  
	///<summary>
///unselectedItemWithData.
///<para>When the item is serialized out as xml, its value is "unselectedItemWithData".</para>
///</summary>
[EnumString("unselectedItemWithData")]
UnselectedItemWithData,
///<summary>
///selectedItemWithData.
///<para>When the item is serialized out as xml, its value is "selectedItemWithData".</para>
///</summary>
[EnumString("selectedItemWithData")]
SelectedItemWithData,
///<summary>
///unselectedItemWithNoData.
///<para>When the item is serialized out as xml, its value is "unselectedItemWithNoData".</para>
///</summary>
[EnumString("unselectedItemWithNoData")]
UnselectedItemWithNoData,
///<summary>
///selectedItemWithNoData.
///<para>When the item is serialized out as xml, its value is "selectedItemWithNoData".</para>
///</summary>
[EnumString("selectedItemWithNoData")]
SelectedItemWithNoData,
///<summary>
///hoveredUnselectedItemWithData.
///<para>When the item is serialized out as xml, its value is "hoveredUnselectedItemWithData".</para>
///</summary>
[EnumString("hoveredUnselectedItemWithData")]
HoveredUnselectedItemWithData,
///<summary>
///hoveredSelectedItemWithData.
///<para>When the item is serialized out as xml, its value is "hoveredSelectedItemWithData".</para>
///</summary>
[EnumString("hoveredSelectedItemWithData")]
HoveredSelectedItemWithData,
///<summary>
///hoveredUnselectedItemWithNoData.
///<para>When the item is serialized out as xml, its value is "hoveredUnselectedItemWithNoData".</para>
///</summary>
[EnumString("hoveredUnselectedItemWithNoData")]
HoveredUnselectedItemWithNoData,
///<summary>
///hoveredSelectedItemWithNoData.
///<para>When the item is serialized out as xml, its value is "hoveredSelectedItemWithNoData".</para>
///</summary>
[EnumString("hoveredSelectedItemWithNoData")]
HoveredSelectedItemWithNoData,
 
}
/// <summary>
/// Defines the CheckedValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum CheckedValues
{  
	///<summary>
///Unchecked.
///<para>When the item is serialized out as xml, its value is "Unchecked".</para>
///</summary>
[EnumString("Unchecked")]
Unchecked,
///<summary>
///Checked.
///<para>When the item is serialized out as xml, its value is "Checked".</para>
///</summary>
[EnumString("Checked")]
Checked,
///<summary>
///Mixed.
///<para>When the item is serialized out as xml, its value is "Mixed".</para>
///</summary>
[EnumString("Mixed")]
Mixed,
 
}
/// <summary>
/// Defines the DropStyleValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum DropStyleValues
{  
	///<summary>
///combo.
///<para>When the item is serialized out as xml, its value is "combo".</para>
///</summary>
[EnumString("combo")]
Combo,
///<summary>
///comboedit.
///<para>When the item is serialized out as xml, its value is "comboedit".</para>
///</summary>
[EnumString("comboedit")]
ComboEdit,
///<summary>
///simple.
///<para>When the item is serialized out as xml, its value is "simple".</para>
///</summary>
[EnumString("simple")]
Simple,
 
}
/// <summary>
/// Defines the SelectionTypeValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum SelectionTypeValues
{  
	///<summary>
///single.
///<para>When the item is serialized out as xml, its value is "single".</para>
///</summary>
[EnumString("single")]
Single,
///<summary>
///multi.
///<para>When the item is serialized out as xml, its value is "multi".</para>
///</summary>
[EnumString("multi")]
Multiple,
///<summary>
///extended.
///<para>When the item is serialized out as xml, its value is "extended".</para>
///</summary>
[EnumString("extended")]
Extended,
 
}
/// <summary>
/// Defines the TextHorizontalAlignmentValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum TextHorizontalAlignmentValues
{  
	///<summary>
///left.
///<para>When the item is serialized out as xml, its value is "left".</para>
///</summary>
[EnumString("left")]
Left,
///<summary>
///center.
///<para>When the item is serialized out as xml, its value is "center".</para>
///</summary>
[EnumString("center")]
Center,
///<summary>
///right.
///<para>When the item is serialized out as xml, its value is "right".</para>
///</summary>
[EnumString("right")]
Right,
///<summary>
///justify.
///<para>When the item is serialized out as xml, its value is "justify".</para>
///</summary>
[EnumString("justify")]
Justify,
///<summary>
///distributed.
///<para>When the item is serialized out as xml, its value is "distributed".</para>
///</summary>
[EnumString("distributed")]
Distributed,
 
}
/// <summary>
/// Defines the TextVerticalAlignmentValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum TextVerticalAlignmentValues
{  
	///<summary>
///top.
///<para>When the item is serialized out as xml, its value is "top".</para>
///</summary>
[EnumString("top")]
Top,
///<summary>
///center.
///<para>When the item is serialized out as xml, its value is "center".</para>
///</summary>
[EnumString("center")]
Center,
///<summary>
///bottom.
///<para>When the item is serialized out as xml, its value is "bottom".</para>
///</summary>
[EnumString("bottom")]
Bottom,
///<summary>
///justify.
///<para>When the item is serialized out as xml, its value is "justify".</para>
///</summary>
[EnumString("justify")]
Justify,
///<summary>
///distributed.
///<para>When the item is serialized out as xml, its value is "distributed".</para>
///</summary>
[EnumString("distributed")]
Distributed,
 
}
/// <summary>
/// Defines the EditValidationValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum EditValidationValues
{  
	///<summary>
///text.
///<para>When the item is serialized out as xml, its value is "text".</para>
///</summary>
[EnumString("text")]
Text,
///<summary>
///integer.
///<para>When the item is serialized out as xml, its value is "integer".</para>
///</summary>
[EnumString("integer")]
Integer,
///<summary>
///number.
///<para>When the item is serialized out as xml, its value is "number".</para>
///</summary>
[EnumString("number")]
Number,
///<summary>
///reference.
///<para>When the item is serialized out as xml, its value is "reference".</para>
///</summary>
[EnumString("reference")]
Reference,
///<summary>
///formula.
///<para>When the item is serialized out as xml, its value is "formula".</para>
///</summary>
[EnumString("formula")]
Formula,
 
}
/// <summary>
/// Defines the OlapSlicerCacheSortOrderValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum OlapSlicerCacheSortOrderValues
{  
	///<summary>
///natural.
///<para>When the item is serialized out as xml, its value is "natural".</para>
///</summary>
[EnumString("natural")]
Natural,
///<summary>
///ascending.
///<para>When the item is serialized out as xml, its value is "ascending".</para>
///</summary>
[EnumString("ascending")]
Ascending,
///<summary>
///descending.
///<para>When the item is serialized out as xml, its value is "descending".</para>
///</summary>
[EnumString("descending")]
Descending,
 
}
/// <summary>
/// Defines the TabularSlicerCacheSortOrderValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum TabularSlicerCacheSortOrderValues
{  
	///<summary>
///ascending.
///<para>When the item is serialized out as xml, its value is "ascending".</para>
///</summary>
[EnumString("ascending")]
Ascending,
///<summary>
///descending.
///<para>When the item is serialized out as xml, its value is "descending".</para>
///</summary>
[EnumString("descending")]
Descending,
 
}
/// <summary>
/// Defines the SlicerCacheCrossFilterValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum SlicerCacheCrossFilterValues
{  
	///<summary>
///none.
///<para>When the item is serialized out as xml, its value is "none".</para>
///</summary>
[EnumString("none")]
None,
///<summary>
///showItemsWithDataAtTop.
///<para>When the item is serialized out as xml, its value is "showItemsWithDataAtTop".</para>
///</summary>
[EnumString("showItemsWithDataAtTop")]
ShowItemsWithDataAtTop,
///<summary>
///showItemsWithNoData.
///<para>When the item is serialized out as xml, its value is "showItemsWithNoData".</para>
///</summary>
[EnumString("showItemsWithNoData")]
ShowItemsWithNoData,
 
}
/// <summary>
/// Defines the ObjectTypeValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ObjectTypeValues
{  
	///<summary>
///Button.
///<para>When the item is serialized out as xml, its value is "Button".</para>
///</summary>
[EnumString("Button")]
Button,
///<summary>
///CheckBox.
///<para>When the item is serialized out as xml, its value is "CheckBox".</para>
///</summary>
[EnumString("CheckBox")]
CheckBox,
///<summary>
///Drop.
///<para>When the item is serialized out as xml, its value is "Drop".</para>
///</summary>
[EnumString("Drop")]
Drop,
///<summary>
///GBox.
///<para>When the item is serialized out as xml, its value is "GBox".</para>
///</summary>
[EnumString("GBox")]
GroupBox,
///<summary>
///Label.
///<para>When the item is serialized out as xml, its value is "Label".</para>
///</summary>
[EnumString("Label")]
Label,
///<summary>
///List.
///<para>When the item is serialized out as xml, its value is "List".</para>
///</summary>
[EnumString("List")]
List,
///<summary>
///Radio.
///<para>When the item is serialized out as xml, its value is "Radio".</para>
///</summary>
[EnumString("Radio")]
Radio,
///<summary>
///Scroll.
///<para>When the item is serialized out as xml, its value is "Scroll".</para>
///</summary>
[EnumString("Scroll")]
Scroll,
///<summary>
///Spin.
///<para>When the item is serialized out as xml, its value is "Spin".</para>
///</summary>
[EnumString("Spin")]
Spin,
///<summary>
///EditBox.
///<para>When the item is serialized out as xml, its value is "EditBox".</para>
///</summary>
[EnumString("EditBox")]
EditBox,
///<summary>
///Dialog.
///<para>When the item is serialized out as xml, its value is "Dialog".</para>
///</summary>
[EnumString("Dialog")]
Dialog,
 
}
}
 
 
