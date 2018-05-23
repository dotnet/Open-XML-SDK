// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentFormat.OpenXml.Math
{
/// <summary>
/// <para>Script.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:scr.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Script : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10905;
    /// <inheritdoc/>
    public override string LocalName => "scr";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Math.ScriptValues>>(21, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public EnumValue<DocumentFormat.OpenXml.Math.ScriptValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Math.ScriptValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Script class.
    /// </summary>
    public Script():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Script>(deep);

}
/// <summary>
/// <para>style.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:sty.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Style : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10906;
    /// <inheritdoc/>
    public override string LocalName => "sty";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Math.StyleValues>>(21, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public EnumValue<DocumentFormat.OpenXml.Math.StyleValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Math.StyleValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Style class.
    /// </summary>
    public Style():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Style>(deep);

}
/// <summary>
/// <para>Defines the Run Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:r.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RunProperties &lt;m:rPr></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.RunProperties &lt;w:rPr></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.Break &lt;w:br></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.Text &lt;w:t></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.DeletedText &lt;w:delText></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.FieldCode &lt;w:instrText></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.DeletedFieldCode &lt;w:delInstrText></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.NoBreakHyphen &lt;w:noBreakHyphen></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.SoftHyphen &lt;w:softHyphen></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.DayShort &lt;w:dayShort></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MonthShort &lt;w:monthShort></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.YearShort &lt;w:yearShort></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.DayLong &lt;w:dayLong></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MonthLong &lt;w:monthLong></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.YearLong &lt;w:yearLong></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.AnnotationReferenceMark &lt;w:annotationRef></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.FootnoteReferenceMark &lt;w:footnoteRef></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.EndnoteReferenceMark &lt;w:endnoteRef></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.SeparatorMark &lt;w:separator></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.ContinuationSeparatorMark &lt;w:continuationSeparator></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.SymbolChar &lt;w:sym></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.PageNumber &lt;w:pgNum></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CarriageReturn &lt;w:cr></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.TabChar &lt;w:tab></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject &lt;w:object></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.Picture &lt;w:pict></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.FieldChar &lt;w:fldChar></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.Ruby &lt;w:ruby></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.FootnoteReference &lt;w:footnoteReference></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.EndnoteReference &lt;w:endnoteReference></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CommentReference &lt;w:commentReference></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.Drawing &lt;w:drawing></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.PositionalTab &lt;w:ptab></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.LastRenderedPageBreak &lt;w:lastRenderedPageBreak></description></item>
///<item><description>Text &lt;m:t></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(RunProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.RunProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.Break))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.Text))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.FieldCode))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedFieldCode))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.NoBreakHyphen))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.SoftHyphen))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.DayShort))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MonthShort))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.YearShort))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.DayLong))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MonthLong))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.YearLong))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.AnnotationReferenceMark))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.FootnoteReferenceMark))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.EndnoteReferenceMark))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.SeparatorMark))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.ContinuationSeparatorMark))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.SymbolChar))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.PageNumber))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CarriageReturn))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.TabChar))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.Picture))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.FieldChar))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.Ruby))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.FootnoteReference))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.EndnoteReference))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentReference))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.Drawing))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.PositionalTab))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.LastRenderedPageBreak))]
    [ChildElementInfo(typeof(Text))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Run : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10907;
    /// <inheritdoc/>
    public override string LocalName => "r";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Run class.
    /// </summary>
    public Run():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Run class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Run(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Run class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Run(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Run class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Run(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "rPr" == name)
    return new RunProperties();
    
if( 23 == namespaceId && "rPr" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.RunProperties();
    
if( 23 == namespaceId && "br" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.Break();
    
if( 23 == namespaceId && "t" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.Text();
    
if( 23 == namespaceId && "delText" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.DeletedText();
    
if( 23 == namespaceId && "instrText" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.FieldCode();
    
if( 23 == namespaceId && "delInstrText" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.DeletedFieldCode();
    
if( 23 == namespaceId && "noBreakHyphen" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.NoBreakHyphen();
    
if( 23 == namespaceId && "softHyphen" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.SoftHyphen();
    
if( 23 == namespaceId && "dayShort" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.DayShort();
    
if( 23 == namespaceId && "monthShort" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.MonthShort();
    
if( 23 == namespaceId && "yearShort" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.YearShort();
    
if( 23 == namespaceId && "dayLong" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.DayLong();
    
if( 23 == namespaceId && "monthLong" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.MonthLong();
    
if( 23 == namespaceId && "yearLong" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.YearLong();
    
if( 23 == namespaceId && "annotationRef" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.AnnotationReferenceMark();
    
if( 23 == namespaceId && "footnoteRef" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.FootnoteReferenceMark();
    
if( 23 == namespaceId && "endnoteRef" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.EndnoteReferenceMark();
    
if( 23 == namespaceId && "separator" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.SeparatorMark();
    
if( 23 == namespaceId && "continuationSeparator" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.ContinuationSeparatorMark();
    
if( 23 == namespaceId && "sym" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.SymbolChar();
    
if( 23 == namespaceId && "pgNum" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.PageNumber();
    
if( 23 == namespaceId && "cr" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CarriageReturn();
    
if( 23 == namespaceId && "tab" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.TabChar();
    
if( 23 == namespaceId && "object" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject();
    
if( 23 == namespaceId && "pict" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.Picture();
    
if( 23 == namespaceId && "fldChar" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.FieldChar();
    
if( 23 == namespaceId && "ruby" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.Ruby();
    
if( 23 == namespaceId && "footnoteReference" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.FootnoteReference();
    
if( 23 == namespaceId && "endnoteReference" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.EndnoteReference();
    
if( 23 == namespaceId && "commentReference" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CommentReference();
    
if( 23 == namespaceId && "drawing" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.Drawing();
    
if( 23 == namespaceId && "ptab" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.PositionalTab();
    
if( 23 == namespaceId && "lastRenderedPageBreak" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.LastRenderedPageBreak();
    
if( 21 == namespaceId && "t" == name)
    return new Text();
    

    return null;
}

        private static readonly string[] eleTagNames = { "rPr","rPr","br","t","delText","instrText","delInstrText","noBreakHyphen","softHyphen","dayShort","monthShort","yearShort","dayLong","monthLong","yearLong","annotationRef","footnoteRef","endnoteRef","separator","continuationSeparator","sym","pgNum","cr","tab","object","pict","fldChar","ruby","footnoteReference","endnoteReference","commentReference","drawing","ptab","lastRenderedPageBreak","t" };
    private static readonly byte[] eleNamespaceIds = { 21,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Run Properties.</para>
    /// <para> Represents the following element tag in the schema: m:rPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public RunProperties MathRunProperties
    {
        get => GetElement<RunProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Run Properties.</para>
    /// <para> Represents the following element tag in the schema: w:rPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:w = http://schemas.openxmlformats.org/wordprocessingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Wordprocessing.RunProperties RunProperties
    {
        get => GetElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Run>(deep);

}
/// <summary>
/// <para>Accent.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:acc.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>AccentProperties &lt;m:accPr></description></item>
///<item><description>Base &lt;m:e></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(AccentProperties))]
    [ChildElementInfo(typeof(Base))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Accent : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10908;
    /// <inheritdoc/>
    public override string LocalName => "acc";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Accent class.
    /// </summary>
    public Accent():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Accent class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Accent(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Accent class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Accent(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Accent class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Accent(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "accPr" == name)
    return new AccentProperties();
    
if( 21 == namespaceId && "e" == name)
    return new Base();
    

    return null;
}

        private static readonly string[] eleTagNames = { "accPr","e" };
    private static readonly byte[] eleNamespaceIds = { 21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Accent Properties.</para>
    /// <para> Represents the following element tag in the schema: m:accPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public AccentProperties AccentProperties
    {
        get => GetElement<AccentProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Base.</para>
    /// <para> Represents the following element tag in the schema: m:e </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public Base Base
    {
        get => GetElement<Base>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Accent>(deep);

}
/// <summary>
/// <para>Bar.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:bar.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BarProperties &lt;m:barPr></description></item>
///<item><description>Base &lt;m:e></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(BarProperties))]
    [ChildElementInfo(typeof(Base))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Bar : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10909;
    /// <inheritdoc/>
    public override string LocalName => "bar";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Bar class.
    /// </summary>
    public Bar():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Bar class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Bar(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Bar class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Bar(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Bar class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Bar(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "barPr" == name)
    return new BarProperties();
    
if( 21 == namespaceId && "e" == name)
    return new Base();
    

    return null;
}

        private static readonly string[] eleTagNames = { "barPr","e" };
    private static readonly byte[] eleNamespaceIds = { 21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Bar Properties.</para>
    /// <para> Represents the following element tag in the schema: m:barPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public BarProperties BarProperties
    {
        get => GetElement<BarProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Base.</para>
    /// <para> Represents the following element tag in the schema: m:e </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public Base Base
    {
        get => GetElement<Base>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Bar>(deep);

}
/// <summary>
/// <para>Box Function.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:box.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BoxProperties &lt;m:boxPr></description></item>
///<item><description>Base &lt;m:e></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(BoxProperties))]
    [ChildElementInfo(typeof(Base))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Box : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10910;
    /// <inheritdoc/>
    public override string LocalName => "box";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Box class.
    /// </summary>
    public Box():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Box class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Box(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Box class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Box(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Box class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Box(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "boxPr" == name)
    return new BoxProperties();
    
if( 21 == namespaceId && "e" == name)
    return new Base();
    

    return null;
}

        private static readonly string[] eleTagNames = { "boxPr","e" };
    private static readonly byte[] eleNamespaceIds = { 21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Box Properties.</para>
    /// <para> Represents the following element tag in the schema: m:boxPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public BoxProperties BoxProperties
    {
        get => GetElement<BoxProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Base.</para>
    /// <para> Represents the following element tag in the schema: m:e </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public Base Base
    {
        get => GetElement<Base>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Box>(deep);

}
/// <summary>
/// <para>Border-Box Function.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:borderBox.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BorderBoxProperties &lt;m:borderBoxPr></description></item>
///<item><description>Base &lt;m:e></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(BorderBoxProperties))]
    [ChildElementInfo(typeof(Base))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class BorderBox : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10911;
    /// <inheritdoc/>
    public override string LocalName => "borderBox";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the BorderBox class.
    /// </summary>
    public BorderBox():base(){}
    
        /// <summary>
    ///Initializes a new instance of the BorderBox class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BorderBox(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BorderBox class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BorderBox(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BorderBox class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BorderBox(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "borderBoxPr" == name)
    return new BorderBoxProperties();
    
if( 21 == namespaceId && "e" == name)
    return new Base();
    

    return null;
}

        private static readonly string[] eleTagNames = { "borderBoxPr","e" };
    private static readonly byte[] eleNamespaceIds = { 21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Border Box Properties.</para>
    /// <para> Represents the following element tag in the schema: m:borderBoxPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public BorderBoxProperties BorderBoxProperties
    {
        get => GetElement<BorderBoxProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Base.</para>
    /// <para> Represents the following element tag in the schema: m:e </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public Base Base
    {
        get => GetElement<Base>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BorderBox>(deep);

}
/// <summary>
/// <para>Delimiter Function.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:d.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DelimiterProperties &lt;m:dPr></description></item>
///<item><description>Base &lt;m:e></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DelimiterProperties))]
    [ChildElementInfo(typeof(Base))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Delimiter : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10912;
    /// <inheritdoc/>
    public override string LocalName => "d";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Delimiter class.
    /// </summary>
    public Delimiter():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Delimiter class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Delimiter(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Delimiter class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Delimiter(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Delimiter class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Delimiter(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "dPr" == name)
    return new DelimiterProperties();
    
if( 21 == namespaceId && "e" == name)
    return new Base();
    

    return null;
}

        private static readonly string[] eleTagNames = { "dPr","e" };
    private static readonly byte[] eleNamespaceIds = { 21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Delimiter Properties.</para>
    /// <para> Represents the following element tag in the schema: m:dPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public DelimiterProperties DelimiterProperties
    {
        get => GetElement<DelimiterProperties>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Delimiter>(deep);

}
/// <summary>
/// <para>Equation-Array Function.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:eqArr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>EquationArrayProperties &lt;m:eqArrPr></description></item>
///<item><description>Base &lt;m:e></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(EquationArrayProperties))]
    [ChildElementInfo(typeof(Base))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class EquationArray : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10913;
    /// <inheritdoc/>
    public override string LocalName => "eqArr";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the EquationArray class.
    /// </summary>
    public EquationArray():base(){}
    
        /// <summary>
    ///Initializes a new instance of the EquationArray class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public EquationArray(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the EquationArray class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public EquationArray(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the EquationArray class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public EquationArray(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "eqArrPr" == name)
    return new EquationArrayProperties();
    
if( 21 == namespaceId && "e" == name)
    return new Base();
    

    return null;
}

        private static readonly string[] eleTagNames = { "eqArrPr","e" };
    private static readonly byte[] eleNamespaceIds = { 21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Equation Array Properties.</para>
    /// <para> Represents the following element tag in the schema: m:eqArrPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public EquationArrayProperties EquationArrayProperties
    {
        get => GetElement<EquationArrayProperties>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<EquationArray>(deep);

}
/// <summary>
/// <para>Fraction Function.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:f.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>FractionProperties &lt;m:fPr></description></item>
///<item><description>Numerator &lt;m:num></description></item>
///<item><description>Denominator &lt;m:den></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(FractionProperties))]
    [ChildElementInfo(typeof(Numerator))]
    [ChildElementInfo(typeof(Denominator))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Fraction : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10914;
    /// <inheritdoc/>
    public override string LocalName => "f";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Fraction class.
    /// </summary>
    public Fraction():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Fraction class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Fraction(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Fraction class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Fraction(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Fraction class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Fraction(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "fPr" == name)
    return new FractionProperties();
    
if( 21 == namespaceId && "num" == name)
    return new Numerator();
    
if( 21 == namespaceId && "den" == name)
    return new Denominator();
    

    return null;
}

        private static readonly string[] eleTagNames = { "fPr","num","den" };
    private static readonly byte[] eleNamespaceIds = { 21,21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Fraction Properties.</para>
    /// <para> Represents the following element tag in the schema: m:fPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public FractionProperties FractionProperties
    {
        get => GetElement<FractionProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Numerator.</para>
    /// <para> Represents the following element tag in the schema: m:num </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public Numerator Numerator
    {
        get => GetElement<Numerator>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Denominator.</para>
    /// <para> Represents the following element tag in the schema: m:den </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public Denominator Denominator
    {
        get => GetElement<Denominator>(2);
        set => SetElement(2, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Fraction>(deep);

}
/// <summary>
/// <para>Function Apply Function.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:func.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>FunctionProperties &lt;m:funcPr></description></item>
///<item><description>FunctionName &lt;m:fName></description></item>
///<item><description>Base &lt;m:e></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(FunctionProperties))]
    [ChildElementInfo(typeof(FunctionName))]
    [ChildElementInfo(typeof(Base))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class MathFunction : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10915;
    /// <inheritdoc/>
    public override string LocalName => "func";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the MathFunction class.
    /// </summary>
    public MathFunction():base(){}
    
        /// <summary>
    ///Initializes a new instance of the MathFunction class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MathFunction(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the MathFunction class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MathFunction(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the MathFunction class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MathFunction(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "funcPr" == name)
    return new FunctionProperties();
    
if( 21 == namespaceId && "fName" == name)
    return new FunctionName();
    
if( 21 == namespaceId && "e" == name)
    return new Base();
    

    return null;
}

        private static readonly string[] eleTagNames = { "funcPr","fName","e" };
    private static readonly byte[] eleNamespaceIds = { 21,21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Function Properties.</para>
    /// <para> Represents the following element tag in the schema: m:funcPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public FunctionProperties FunctionProperties
    {
        get => GetElement<FunctionProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Function Name.</para>
    /// <para> Represents the following element tag in the schema: m:fName </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public FunctionName FunctionName
    {
        get => GetElement<FunctionName>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Base (Argument).</para>
    /// <para> Represents the following element tag in the schema: m:e </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public Base Base
    {
        get => GetElement<Base>(2);
        set => SetElement(2, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MathFunction>(deep);

}
/// <summary>
/// <para>Group-Character Function.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:groupChr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>GroupCharProperties &lt;m:groupChrPr></description></item>
///<item><description>Base &lt;m:e></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(GroupCharProperties))]
    [ChildElementInfo(typeof(Base))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class GroupChar : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10916;
    /// <inheritdoc/>
    public override string LocalName => "groupChr";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the GroupChar class.
    /// </summary>
    public GroupChar():base(){}
    
        /// <summary>
    ///Initializes a new instance of the GroupChar class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GroupChar(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the GroupChar class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GroupChar(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the GroupChar class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public GroupChar(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "groupChrPr" == name)
    return new GroupCharProperties();
    
if( 21 == namespaceId && "e" == name)
    return new Base();
    

    return null;
}

        private static readonly string[] eleTagNames = { "groupChrPr","e" };
    private static readonly byte[] eleNamespaceIds = { 21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Group-Character Properties.</para>
    /// <para> Represents the following element tag in the schema: m:groupChrPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public GroupCharProperties GroupCharProperties
    {
        get => GetElement<GroupCharProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Base.</para>
    /// <para> Represents the following element tag in the schema: m:e </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public Base Base
    {
        get => GetElement<Base>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupChar>(deep);

}
/// <summary>
/// <para>Lower-Limit Function.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:limLow.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LimitLowerProperties &lt;m:limLowPr></description></item>
///<item><description>Base &lt;m:e></description></item>
///<item><description>Limit &lt;m:lim></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(LimitLowerProperties))]
    [ChildElementInfo(typeof(Base))]
    [ChildElementInfo(typeof(Limit))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class LimitLower : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10917;
    /// <inheritdoc/>
    public override string LocalName => "limLow";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the LimitLower class.
    /// </summary>
    public LimitLower():base(){}
    
        /// <summary>
    ///Initializes a new instance of the LimitLower class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LimitLower(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LimitLower class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LimitLower(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LimitLower class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public LimitLower(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "limLowPr" == name)
    return new LimitLowerProperties();
    
if( 21 == namespaceId && "e" == name)
    return new Base();
    
if( 21 == namespaceId && "lim" == name)
    return new Limit();
    

    return null;
}

        private static readonly string[] eleTagNames = { "limLowPr","e","lim" };
    private static readonly byte[] eleNamespaceIds = { 21,21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Lower Limit Properties.</para>
    /// <para> Represents the following element tag in the schema: m:limLowPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public LimitLowerProperties LimitLowerProperties
    {
        get => GetElement<LimitLowerProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Base.</para>
    /// <para> Represents the following element tag in the schema: m:e </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public Base Base
    {
        get => GetElement<Base>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Limit (Lower).</para>
    /// <para> Represents the following element tag in the schema: m:lim </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public Limit Limit
    {
        get => GetElement<Limit>(2);
        set => SetElement(2, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LimitLower>(deep);

}
/// <summary>
/// <para>Upper-Limit Function.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:limUpp.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>LimitUpperProperties &lt;m:limUppPr></description></item>
///<item><description>Base &lt;m:e></description></item>
///<item><description>Limit &lt;m:lim></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(LimitUpperProperties))]
    [ChildElementInfo(typeof(Base))]
    [ChildElementInfo(typeof(Limit))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class LimitUpper : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10918;
    /// <inheritdoc/>
    public override string LocalName => "limUpp";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the LimitUpper class.
    /// </summary>
    public LimitUpper():base(){}
    
        /// <summary>
    ///Initializes a new instance of the LimitUpper class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LimitUpper(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LimitUpper class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LimitUpper(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LimitUpper class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public LimitUpper(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "limUppPr" == name)
    return new LimitUpperProperties();
    
if( 21 == namespaceId && "e" == name)
    return new Base();
    
if( 21 == namespaceId && "lim" == name)
    return new Limit();
    

    return null;
}

        private static readonly string[] eleTagNames = { "limUppPr","e","lim" };
    private static readonly byte[] eleNamespaceIds = { 21,21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Upper Limit Properties.</para>
    /// <para> Represents the following element tag in the schema: m:limUppPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public LimitUpperProperties LimitUpperProperties
    {
        get => GetElement<LimitUpperProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Base.</para>
    /// <para> Represents the following element tag in the schema: m:e </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public Base Base
    {
        get => GetElement<Base>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Limit (Upper).</para>
    /// <para> Represents the following element tag in the schema: m:lim </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public Limit Limit
    {
        get => GetElement<Limit>(2);
        set => SetElement(2, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LimitUpper>(deep);

}
/// <summary>
/// <para>Matrix Function.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:m.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>MatrixProperties &lt;m:mPr></description></item>
///<item><description>MatrixRow &lt;m:mr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(MatrixProperties))]
    [ChildElementInfo(typeof(MatrixRow))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Matrix : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10919;
    /// <inheritdoc/>
    public override string LocalName => "m";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Matrix class.
    /// </summary>
    public Matrix():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Matrix class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Matrix(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Matrix class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Matrix(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Matrix class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Matrix(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "mPr" == name)
    return new MatrixProperties();
    
if( 21 == namespaceId && "mr" == name)
    return new MatrixRow();
    

    return null;
}

        private static readonly string[] eleTagNames = { "mPr","mr" };
    private static readonly byte[] eleNamespaceIds = { 21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Matrix Properties.</para>
    /// <para> Represents the following element tag in the schema: m:mPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public MatrixProperties MatrixProperties
    {
        get => GetElement<MatrixProperties>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Matrix>(deep);

}
/// <summary>
/// <para>n-ary Operator Function.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:nary.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NaryProperties &lt;m:naryPr></description></item>
///<item><description>SubArgument &lt;m:sub></description></item>
///<item><description>SuperArgument &lt;m:sup></description></item>
///<item><description>Base &lt;m:e></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NaryProperties))]
    [ChildElementInfo(typeof(SubArgument))]
    [ChildElementInfo(typeof(SuperArgument))]
    [ChildElementInfo(typeof(Base))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Nary : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10920;
    /// <inheritdoc/>
    public override string LocalName => "nary";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Nary class.
    /// </summary>
    public Nary():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Nary class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Nary(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Nary class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Nary(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Nary class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Nary(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "naryPr" == name)
    return new NaryProperties();
    
if( 21 == namespaceId && "sub" == name)
    return new SubArgument();
    
if( 21 == namespaceId && "sup" == name)
    return new SuperArgument();
    
if( 21 == namespaceId && "e" == name)
    return new Base();
    

    return null;
}

        private static readonly string[] eleTagNames = { "naryPr","sub","sup","e" };
    private static readonly byte[] eleNamespaceIds = { 21,21,21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> n-ary Properties.</para>
    /// <para> Represents the following element tag in the schema: m:naryPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public NaryProperties NaryProperties
    {
        get => GetElement<NaryProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Lower limit (n-ary) .</para>
    /// <para> Represents the following element tag in the schema: m:sub </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public SubArgument SubArgument
    {
        get => GetElement<SubArgument>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Upper limit (n-ary).</para>
    /// <para> Represents the following element tag in the schema: m:sup </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public SuperArgument SuperArgument
    {
        get => GetElement<SuperArgument>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Base (Argument).</para>
    /// <para> Represents the following element tag in the schema: m:e </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public Base Base
    {
        get => GetElement<Base>(3);
        set => SetElement(3, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Nary>(deep);

}
/// <summary>
/// <para>Phantom Function.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:phant.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PhantomProperties &lt;m:phantPr></description></item>
///<item><description>Base &lt;m:e></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(PhantomProperties))]
    [ChildElementInfo(typeof(Base))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Phantom : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10921;
    /// <inheritdoc/>
    public override string LocalName => "phant";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Phantom class.
    /// </summary>
    public Phantom():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Phantom class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Phantom(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Phantom class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Phantom(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Phantom class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Phantom(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "phantPr" == name)
    return new PhantomProperties();
    
if( 21 == namespaceId && "e" == name)
    return new Base();
    

    return null;
}

        private static readonly string[] eleTagNames = { "phantPr","e" };
    private static readonly byte[] eleNamespaceIds = { 21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Phantom Properties.</para>
    /// <para> Represents the following element tag in the schema: m:phantPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public PhantomProperties PhantomProperties
    {
        get => GetElement<PhantomProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Base.</para>
    /// <para> Represents the following element tag in the schema: m:e </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public Base Base
    {
        get => GetElement<Base>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Phantom>(deep);

}
/// <summary>
/// <para>Radical Function.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:rad.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>RadicalProperties &lt;m:radPr></description></item>
///<item><description>Degree &lt;m:deg></description></item>
///<item><description>Base &lt;m:e></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(RadicalProperties))]
    [ChildElementInfo(typeof(Degree))]
    [ChildElementInfo(typeof(Base))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Radical : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10922;
    /// <inheritdoc/>
    public override string LocalName => "rad";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Radical class.
    /// </summary>
    public Radical():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Radical class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Radical(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Radical class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Radical(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Radical class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Radical(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "radPr" == name)
    return new RadicalProperties();
    
if( 21 == namespaceId && "deg" == name)
    return new Degree();
    
if( 21 == namespaceId && "e" == name)
    return new Base();
    

    return null;
}

        private static readonly string[] eleTagNames = { "radPr","deg","e" };
    private static readonly byte[] eleNamespaceIds = { 21,21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Radical Properties.</para>
    /// <para> Represents the following element tag in the schema: m:radPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public RadicalProperties RadicalProperties
    {
        get => GetElement<RadicalProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Degree.</para>
    /// <para> Represents the following element tag in the schema: m:deg </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public Degree Degree
    {
        get => GetElement<Degree>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Base.</para>
    /// <para> Represents the following element tag in the schema: m:e </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public Base Base
    {
        get => GetElement<Base>(2);
        set => SetElement(2, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Radical>(deep);

}
/// <summary>
/// <para>Pre-Sub-Superscript Function.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:sPre.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PreSubSuperProperties &lt;m:sPrePr></description></item>
///<item><description>SubArgument &lt;m:sub></description></item>
///<item><description>SuperArgument &lt;m:sup></description></item>
///<item><description>Base &lt;m:e></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(PreSubSuperProperties))]
    [ChildElementInfo(typeof(SubArgument))]
    [ChildElementInfo(typeof(SuperArgument))]
    [ChildElementInfo(typeof(Base))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class PreSubSuper : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10923;
    /// <inheritdoc/>
    public override string LocalName => "sPre";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the PreSubSuper class.
    /// </summary>
    public PreSubSuper():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PreSubSuper class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PreSubSuper(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PreSubSuper class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PreSubSuper(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PreSubSuper class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PreSubSuper(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "sPrePr" == name)
    return new PreSubSuperProperties();
    
if( 21 == namespaceId && "sub" == name)
    return new SubArgument();
    
if( 21 == namespaceId && "sup" == name)
    return new SuperArgument();
    
if( 21 == namespaceId && "e" == name)
    return new Base();
    

    return null;
}

        private static readonly string[] eleTagNames = { "sPrePr","sub","sup","e" };
    private static readonly byte[] eleNamespaceIds = { 21,21,21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Pre-Sub-Superscript Properties.</para>
    /// <para> Represents the following element tag in the schema: m:sPrePr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public PreSubSuperProperties PreSubSuperProperties
    {
        get => GetElement<PreSubSuperProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Subscript (Pre-Sub-Superscript).</para>
    /// <para> Represents the following element tag in the schema: m:sub </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public SubArgument SubArgument
    {
        get => GetElement<SubArgument>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Superscript(Pre-Sub-Superscript function).</para>
    /// <para> Represents the following element tag in the schema: m:sup </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public SuperArgument SuperArgument
    {
        get => GetElement<SuperArgument>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Base.</para>
    /// <para> Represents the following element tag in the schema: m:e </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public Base Base
    {
        get => GetElement<Base>(3);
        set => SetElement(3, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PreSubSuper>(deep);

}
/// <summary>
/// <para>Subscript Function.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:sSub.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SubscriptProperties &lt;m:sSubPr></description></item>
///<item><description>Base &lt;m:e></description></item>
///<item><description>SubArgument &lt;m:sub></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SubscriptProperties))]
    [ChildElementInfo(typeof(Base))]
    [ChildElementInfo(typeof(SubArgument))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Subscript : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10924;
    /// <inheritdoc/>
    public override string LocalName => "sSub";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Subscript class.
    /// </summary>
    public Subscript():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Subscript class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Subscript(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Subscript class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Subscript(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Subscript class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Subscript(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "sSubPr" == name)
    return new SubscriptProperties();
    
if( 21 == namespaceId && "e" == name)
    return new Base();
    
if( 21 == namespaceId && "sub" == name)
    return new SubArgument();
    

    return null;
}

        private static readonly string[] eleTagNames = { "sSubPr","e","sub" };
    private static readonly byte[] eleNamespaceIds = { 21,21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Subscript Properties.</para>
    /// <para> Represents the following element tag in the schema: m:sSubPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public SubscriptProperties SubscriptProperties
    {
        get => GetElement<SubscriptProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Base.</para>
    /// <para> Represents the following element tag in the schema: m:e </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public Base Base
    {
        get => GetElement<Base>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Subscript (Subscript function).</para>
    /// <para> Represents the following element tag in the schema: m:sub </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public SubArgument SubArgument
    {
        get => GetElement<SubArgument>(2);
        set => SetElement(2, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Subscript>(deep);

}
/// <summary>
/// <para>Sub-Superscript Function.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:sSubSup.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SubSuperscriptProperties &lt;m:sSubSupPr></description></item>
///<item><description>Base &lt;m:e></description></item>
///<item><description>SubArgument &lt;m:sub></description></item>
///<item><description>SuperArgument &lt;m:sup></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SubSuperscriptProperties))]
    [ChildElementInfo(typeof(Base))]
    [ChildElementInfo(typeof(SubArgument))]
    [ChildElementInfo(typeof(SuperArgument))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SubSuperscript : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10925;
    /// <inheritdoc/>
    public override string LocalName => "sSubSup";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the SubSuperscript class.
    /// </summary>
    public SubSuperscript():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SubSuperscript class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SubSuperscript(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SubSuperscript class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SubSuperscript(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SubSuperscript class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SubSuperscript(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "sSubSupPr" == name)
    return new SubSuperscriptProperties();
    
if( 21 == namespaceId && "e" == name)
    return new Base();
    
if( 21 == namespaceId && "sub" == name)
    return new SubArgument();
    
if( 21 == namespaceId && "sup" == name)
    return new SuperArgument();
    

    return null;
}

        private static readonly string[] eleTagNames = { "sSubSupPr","e","sub","sup" };
    private static readonly byte[] eleNamespaceIds = { 21,21,21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Sub-Superscript Properties.</para>
    /// <para> Represents the following element tag in the schema: m:sSubSupPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public SubSuperscriptProperties SubSuperscriptProperties
    {
        get => GetElement<SubSuperscriptProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Base.</para>
    /// <para> Represents the following element tag in the schema: m:e </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public Base Base
    {
        get => GetElement<Base>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Subscript (Sub-Superscript).</para>
    /// <para> Represents the following element tag in the schema: m:sub </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public SubArgument SubArgument
    {
        get => GetElement<SubArgument>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Superscript (Sub-Superscript function).</para>
    /// <para> Represents the following element tag in the schema: m:sup </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public SuperArgument SuperArgument
    {
        get => GetElement<SuperArgument>(3);
        set => SetElement(3, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SubSuperscript>(deep);

}
/// <summary>
/// <para>Superscript Function.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:sSup.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>SuperscriptProperties &lt;m:sSupPr></description></item>
///<item><description>Base &lt;m:e></description></item>
///<item><description>SuperArgument &lt;m:sup></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(SuperscriptProperties))]
    [ChildElementInfo(typeof(Base))]
    [ChildElementInfo(typeof(SuperArgument))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Superscript : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10926;
    /// <inheritdoc/>
    public override string LocalName => "sSup";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Superscript class.
    /// </summary>
    public Superscript():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Superscript class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Superscript(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Superscript class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Superscript(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Superscript class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Superscript(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "sSupPr" == name)
    return new SuperscriptProperties();
    
if( 21 == namespaceId && "e" == name)
    return new Base();
    
if( 21 == namespaceId && "sup" == name)
    return new SuperArgument();
    

    return null;
}

        private static readonly string[] eleTagNames = { "sSupPr","e","sup" };
    private static readonly byte[] eleNamespaceIds = { 21,21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Superscript Properties.</para>
    /// <para> Represents the following element tag in the schema: m:sSupPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public SuperscriptProperties SuperscriptProperties
    {
        get => GetElement<SuperscriptProperties>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Base.</para>
    /// <para> Represents the following element tag in the schema: m:e </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public Base Base
    {
        get => GetElement<Base>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Superscript (Superscript function).</para>
    /// <para> Represents the following element tag in the schema: m:sup </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public SuperArgument SuperArgument
    {
        get => GetElement<SuperArgument>(2);
        set => SetElement(2, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Superscript>(deep);

}
/// <summary>
/// <para>Defines the Paragraph Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:oMathPara.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ParagraphProperties &lt;m:oMathParaPr></description></item>
///<item><description>OfficeMath &lt;m:oMath></description></item>
///<item><description>Run &lt;m:r></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.ProofError &lt;w:proofErr></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.PermStart &lt;w:permStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.PermEnd &lt;w:permEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkStart &lt;w:bookmarkStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd &lt;w:bookmarkEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart &lt;w:commentRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd &lt;w:commentRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart &lt;w:moveFromRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd &lt;w:moveFromRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart &lt;w:moveToRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd &lt;w:moveToRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart &lt;w:customXmlInsRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd &lt;w:customXmlInsRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart &lt;w:customXmlDelRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd &lt;w:customXmlDelRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart &lt;w:customXmlMoveFromRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd &lt;w:customXmlMoveFromRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart &lt;w:customXmlMoveToRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd &lt;w:customXmlMoveToRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart &lt;w14:customXmlConflictInsRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd &lt;w14:customXmlConflictInsRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart &lt;w14:customXmlConflictDelRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd &lt;w14:customXmlConflictDelRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.InsertedRun &lt;w:ins></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.DeletedRun &lt;w:del></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRun &lt;w:moveFrom></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRun &lt;w:moveTo></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.ContentPart &lt;w:contentPart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion &lt;w14:conflictIns></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion &lt;w14:conflictDel></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.Run &lt;w:r></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ParagraphProperties))]
    [ChildElementInfo(typeof(OfficeMath))]
    [ChildElementInfo(typeof(Run))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.ProofError))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.PermStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.PermEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.InsertedRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.ContentPart), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.Run))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Paragraph : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10927;
    /// <inheritdoc/>
    public override string LocalName => "oMathPara";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Paragraph class.
    /// </summary>
    public Paragraph():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Paragraph class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Paragraph(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Paragraph class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Paragraph(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Paragraph class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Paragraph(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "oMathParaPr" == name)
    return new ParagraphProperties();
    
if( 21 == namespaceId && "oMath" == name)
    return new OfficeMath();
    
if( 21 == namespaceId && "r" == name)
    return new Run();
    
if( 23 == namespaceId && "proofErr" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.ProofError();
    
if( 23 == namespaceId && "permStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.PermStart();
    
if( 23 == namespaceId && "permEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.PermEnd();
    
if( 23 == namespaceId && "bookmarkStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.BookmarkStart();
    
if( 23 == namespaceId && "bookmarkEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd();
    
if( 23 == namespaceId && "commentRangeStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart();
    
if( 23 == namespaceId && "commentRangeEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd();
    
if( 23 == namespaceId && "moveFromRangeStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart();
    
if( 23 == namespaceId && "moveFromRangeEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd();
    
if( 23 == namespaceId && "moveToRangeStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart();
    
if( 23 == namespaceId && "moveToRangeEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd();
    
if( 23 == namespaceId && "customXmlInsRangeStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart();
    
if( 23 == namespaceId && "customXmlInsRangeEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd();
    
if( 23 == namespaceId && "customXmlDelRangeStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart();
    
if( 23 == namespaceId && "customXmlDelRangeEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd();
    
if( 23 == namespaceId && "customXmlMoveFromRangeStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart();
    
if( 23 == namespaceId && "customXmlMoveFromRangeEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd();
    
if( 23 == namespaceId && "customXmlMoveToRangeStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart();
    
if( 23 == namespaceId && "customXmlMoveToRangeEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd();
    
if( 52 == namespaceId && "customXmlConflictInsRangeStart" == name)
    return new DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart();
    
if( 52 == namespaceId && "customXmlConflictInsRangeEnd" == name)
    return new DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd();
    
if( 52 == namespaceId && "customXmlConflictDelRangeStart" == name)
    return new DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart();
    
if( 52 == namespaceId && "customXmlConflictDelRangeEnd" == name)
    return new DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd();
    
if( 23 == namespaceId && "ins" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.InsertedRun();
    
if( 23 == namespaceId && "del" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.DeletedRun();
    
if( 23 == namespaceId && "moveFrom" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.MoveFromRun();
    
if( 23 == namespaceId && "moveTo" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.MoveToRun();
    
if( 23 == namespaceId && "contentPart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.ContentPart();
    
if( 52 == namespaceId && "conflictIns" == name)
    return new DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion();
    
if( 52 == namespaceId && "conflictDel" == name)
    return new DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion();
    
if( 23 == namespaceId && "r" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.Run();
    

    return null;
}

        private static readonly string[] eleTagNames = { "oMathParaPr","oMath","r","proofErr","permStart","permEnd","bookmarkStart","bookmarkEnd","commentRangeStart","commentRangeEnd","moveFromRangeStart","moveFromRangeEnd","moveToRangeStart","moveToRangeEnd","customXmlInsRangeStart","customXmlInsRangeEnd","customXmlDelRangeStart","customXmlDelRangeEnd","customXmlMoveFromRangeStart","customXmlMoveFromRangeEnd","customXmlMoveToRangeStart","customXmlMoveToRangeEnd","customXmlConflictInsRangeStart","customXmlConflictInsRangeEnd","customXmlConflictDelRangeStart","customXmlConflictDelRangeEnd","ins","del","moveFrom","moveTo","contentPart","conflictIns","conflictDel","r" };
    private static readonly byte[] eleNamespaceIds = { 21,21,21,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,52,52,52,52,23,23,23,23,23,52,52,23 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Office Math Paragraph Properties.</para>
    /// <para> Represents the following element tag in the schema: m:oMathParaPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public ParagraphProperties ParagraphProperties
    {
        get => GetElement<ParagraphProperties>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Paragraph>(deep);

}
/// <summary>
/// <para>Defines the OfficeMath Class.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:oMath.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Accent &lt;m:acc></description></item>
///<item><description>Bar &lt;m:bar></description></item>
///<item><description>Box &lt;m:box></description></item>
///<item><description>BorderBox &lt;m:borderBox></description></item>
///<item><description>Delimiter &lt;m:d></description></item>
///<item><description>EquationArray &lt;m:eqArr></description></item>
///<item><description>Fraction &lt;m:f></description></item>
///<item><description>MathFunction &lt;m:func></description></item>
///<item><description>GroupChar &lt;m:groupChr></description></item>
///<item><description>LimitLower &lt;m:limLow></description></item>
///<item><description>LimitUpper &lt;m:limUpp></description></item>
///<item><description>Matrix &lt;m:m></description></item>
///<item><description>Nary &lt;m:nary></description></item>
///<item><description>Phantom &lt;m:phant></description></item>
///<item><description>Radical &lt;m:rad></description></item>
///<item><description>PreSubSuper &lt;m:sPre></description></item>
///<item><description>Subscript &lt;m:sSub></description></item>
///<item><description>SubSuperscript &lt;m:sSubSup></description></item>
///<item><description>Superscript &lt;m:sSup></description></item>
///<item><description>Run &lt;m:r></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun &lt;w:customXml></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.SimpleField &lt;w:fldSimple></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.Hyperlink &lt;w:hyperlink></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.SdtRun &lt;w:sdt></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.ProofError &lt;w:proofErr></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.PermStart &lt;w:permStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.PermEnd &lt;w:permEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkStart &lt;w:bookmarkStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd &lt;w:bookmarkEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart &lt;w:commentRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd &lt;w:commentRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart &lt;w:moveFromRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd &lt;w:moveFromRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart &lt;w:moveToRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd &lt;w:moveToRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart &lt;w:customXmlInsRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd &lt;w:customXmlInsRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart &lt;w:customXmlDelRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd &lt;w:customXmlDelRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart &lt;w:customXmlMoveFromRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd &lt;w:customXmlMoveFromRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart &lt;w:customXmlMoveToRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd &lt;w:customXmlMoveToRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart &lt;w14:customXmlConflictInsRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd &lt;w14:customXmlConflictInsRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart &lt;w14:customXmlConflictDelRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd &lt;w14:customXmlConflictDelRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.InsertedRun &lt;w:ins></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.DeletedRun &lt;w:del></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRun &lt;w:moveFrom></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRun &lt;w:moveTo></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.ContentPart &lt;w:contentPart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion &lt;w14:conflictIns></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion &lt;w14:conflictDel></description></item>
///<item><description>Paragraph &lt;m:oMathPara></description></item>
///<item><description>OfficeMath &lt;m:oMath></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Accent))]
    [ChildElementInfo(typeof(Bar))]
    [ChildElementInfo(typeof(Box))]
    [ChildElementInfo(typeof(BorderBox))]
    [ChildElementInfo(typeof(Delimiter))]
    [ChildElementInfo(typeof(EquationArray))]
    [ChildElementInfo(typeof(Fraction))]
    [ChildElementInfo(typeof(MathFunction))]
    [ChildElementInfo(typeof(GroupChar))]
    [ChildElementInfo(typeof(LimitLower))]
    [ChildElementInfo(typeof(LimitUpper))]
    [ChildElementInfo(typeof(Matrix))]
    [ChildElementInfo(typeof(Nary))]
    [ChildElementInfo(typeof(Phantom))]
    [ChildElementInfo(typeof(Radical))]
    [ChildElementInfo(typeof(PreSubSuper))]
    [ChildElementInfo(typeof(Subscript))]
    [ChildElementInfo(typeof(SubSuperscript))]
    [ChildElementInfo(typeof(Superscript))]
    [ChildElementInfo(typeof(Run))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.SimpleField))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.Hyperlink))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.SdtRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.ProofError))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.PermStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.PermEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.InsertedRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.ContentPart), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Paragraph))]
    [ChildElementInfo(typeof(OfficeMath))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class OfficeMath : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10928;
    /// <inheritdoc/>
    public override string LocalName => "oMath";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the OfficeMath class.
    /// </summary>
    public OfficeMath():base(){}
    
        /// <summary>
    ///Initializes a new instance of the OfficeMath class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OfficeMath(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the OfficeMath class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OfficeMath(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the OfficeMath class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public OfficeMath(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "acc" == name)
    return new Accent();
    
if( 21 == namespaceId && "bar" == name)
    return new Bar();
    
if( 21 == namespaceId && "box" == name)
    return new Box();
    
if( 21 == namespaceId && "borderBox" == name)
    return new BorderBox();
    
if( 21 == namespaceId && "d" == name)
    return new Delimiter();
    
if( 21 == namespaceId && "eqArr" == name)
    return new EquationArray();
    
if( 21 == namespaceId && "f" == name)
    return new Fraction();
    
if( 21 == namespaceId && "func" == name)
    return new MathFunction();
    
if( 21 == namespaceId && "groupChr" == name)
    return new GroupChar();
    
if( 21 == namespaceId && "limLow" == name)
    return new LimitLower();
    
if( 21 == namespaceId && "limUpp" == name)
    return new LimitUpper();
    
if( 21 == namespaceId && "m" == name)
    return new Matrix();
    
if( 21 == namespaceId && "nary" == name)
    return new Nary();
    
if( 21 == namespaceId && "phant" == name)
    return new Phantom();
    
if( 21 == namespaceId && "rad" == name)
    return new Radical();
    
if( 21 == namespaceId && "sPre" == name)
    return new PreSubSuper();
    
if( 21 == namespaceId && "sSub" == name)
    return new Subscript();
    
if( 21 == namespaceId && "sSubSup" == name)
    return new SubSuperscript();
    
if( 21 == namespaceId && "sSup" == name)
    return new Superscript();
    
if( 21 == namespaceId && "r" == name)
    return new Run();
    
if( 23 == namespaceId && "customXml" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun();
    
if( 23 == namespaceId && "fldSimple" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.SimpleField();
    
if( 23 == namespaceId && "hyperlink" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.Hyperlink();
    
if( 23 == namespaceId && "sdt" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.SdtRun();
    
if( 23 == namespaceId && "proofErr" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.ProofError();
    
if( 23 == namespaceId && "permStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.PermStart();
    
if( 23 == namespaceId && "permEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.PermEnd();
    
if( 23 == namespaceId && "bookmarkStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.BookmarkStart();
    
if( 23 == namespaceId && "bookmarkEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd();
    
if( 23 == namespaceId && "commentRangeStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart();
    
if( 23 == namespaceId && "commentRangeEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd();
    
if( 23 == namespaceId && "moveFromRangeStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart();
    
if( 23 == namespaceId && "moveFromRangeEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd();
    
if( 23 == namespaceId && "moveToRangeStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart();
    
if( 23 == namespaceId && "moveToRangeEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd();
    
if( 23 == namespaceId && "customXmlInsRangeStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart();
    
if( 23 == namespaceId && "customXmlInsRangeEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd();
    
if( 23 == namespaceId && "customXmlDelRangeStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart();
    
if( 23 == namespaceId && "customXmlDelRangeEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd();
    
if( 23 == namespaceId && "customXmlMoveFromRangeStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart();
    
if( 23 == namespaceId && "customXmlMoveFromRangeEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd();
    
if( 23 == namespaceId && "customXmlMoveToRangeStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart();
    
if( 23 == namespaceId && "customXmlMoveToRangeEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd();
    
if( 52 == namespaceId && "customXmlConflictInsRangeStart" == name)
    return new DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart();
    
if( 52 == namespaceId && "customXmlConflictInsRangeEnd" == name)
    return new DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd();
    
if( 52 == namespaceId && "customXmlConflictDelRangeStart" == name)
    return new DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart();
    
if( 52 == namespaceId && "customXmlConflictDelRangeEnd" == name)
    return new DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd();
    
if( 23 == namespaceId && "ins" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.InsertedRun();
    
if( 23 == namespaceId && "del" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.DeletedRun();
    
if( 23 == namespaceId && "moveFrom" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.MoveFromRun();
    
if( 23 == namespaceId && "moveTo" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.MoveToRun();
    
if( 23 == namespaceId && "contentPart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.ContentPart();
    
if( 52 == namespaceId && "conflictIns" == name)
    return new DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion();
    
if( 52 == namespaceId && "conflictDel" == name)
    return new DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion();
    
if( 21 == namespaceId && "oMathPara" == name)
    return new Paragraph();
    
if( 21 == namespaceId && "oMath" == name)
    return new OfficeMath();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<OfficeMath>(deep);

}
/// <summary>
/// <para>Math Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:mathPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>MathFont &lt;m:mathFont></description></item>
///<item><description>BreakBinary &lt;m:brkBin></description></item>
///<item><description>BreakBinarySubtraction &lt;m:brkBinSub></description></item>
///<item><description>SmallFraction &lt;m:smallFrac></description></item>
///<item><description>DisplayDefaults &lt;m:dispDef></description></item>
///<item><description>LeftMargin &lt;m:lMargin></description></item>
///<item><description>RightMargin &lt;m:rMargin></description></item>
///<item><description>DefaultJustification &lt;m:defJc></description></item>
///<item><description>PreSpacing &lt;m:preSp></description></item>
///<item><description>PostSpacing &lt;m:postSp></description></item>
///<item><description>InterSpacing &lt;m:interSp></description></item>
///<item><description>IntraSpacing &lt;m:intraSp></description></item>
///<item><description>WrapIndent &lt;m:wrapIndent></description></item>
///<item><description>WrapRight &lt;m:wrapRight></description></item>
///<item><description>IntegralLimitLocation &lt;m:intLim></description></item>
///<item><description>NaryLimitLocation &lt;m:naryLim></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(MathFont))]
    [ChildElementInfo(typeof(BreakBinary))]
    [ChildElementInfo(typeof(BreakBinarySubtraction))]
    [ChildElementInfo(typeof(SmallFraction))]
    [ChildElementInfo(typeof(DisplayDefaults))]
    [ChildElementInfo(typeof(LeftMargin))]
    [ChildElementInfo(typeof(RightMargin))]
    [ChildElementInfo(typeof(DefaultJustification))]
    [ChildElementInfo(typeof(PreSpacing))]
    [ChildElementInfo(typeof(PostSpacing))]
    [ChildElementInfo(typeof(InterSpacing))]
    [ChildElementInfo(typeof(IntraSpacing))]
    [ChildElementInfo(typeof(WrapIndent))]
    [ChildElementInfo(typeof(WrapRight))]
    [ChildElementInfo(typeof(IntegralLimitLocation))]
    [ChildElementInfo(typeof(NaryLimitLocation))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class MathProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10929;
    /// <inheritdoc/>
    public override string LocalName => "mathPr";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the MathProperties class.
    /// </summary>
    public MathProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the MathProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MathProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the MathProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MathProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the MathProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MathProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "mathFont" == name)
    return new MathFont();
    
if( 21 == namespaceId && "brkBin" == name)
    return new BreakBinary();
    
if( 21 == namespaceId && "brkBinSub" == name)
    return new BreakBinarySubtraction();
    
if( 21 == namespaceId && "smallFrac" == name)
    return new SmallFraction();
    
if( 21 == namespaceId && "dispDef" == name)
    return new DisplayDefaults();
    
if( 21 == namespaceId && "lMargin" == name)
    return new LeftMargin();
    
if( 21 == namespaceId && "rMargin" == name)
    return new RightMargin();
    
if( 21 == namespaceId && "defJc" == name)
    return new DefaultJustification();
    
if( 21 == namespaceId && "preSp" == name)
    return new PreSpacing();
    
if( 21 == namespaceId && "postSp" == name)
    return new PostSpacing();
    
if( 21 == namespaceId && "interSp" == name)
    return new InterSpacing();
    
if( 21 == namespaceId && "intraSp" == name)
    return new IntraSpacing();
    
if( 21 == namespaceId && "wrapIndent" == name)
    return new WrapIndent();
    
if( 21 == namespaceId && "wrapRight" == name)
    return new WrapRight();
    
if( 21 == namespaceId && "intLim" == name)
    return new IntegralLimitLocation();
    
if( 21 == namespaceId && "naryLim" == name)
    return new NaryLimitLocation();
    

    return null;
}

        private static readonly string[] eleTagNames = { "mathFont","brkBin","brkBinSub","smallFrac","dispDef","lMargin","rMargin","defJc","preSp","postSp","interSp","intraSp","wrapIndent","wrapRight","intLim","naryLim" };
    private static readonly byte[] eleNamespaceIds = { 21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Math Font.</para>
    /// <para> Represents the following element tag in the schema: m:mathFont </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public MathFont MathFont
    {
        get => GetElement<MathFont>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Break on Binary Operators.</para>
    /// <para> Represents the following element tag in the schema: m:brkBin </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public BreakBinary BreakBinary
    {
        get => GetElement<BreakBinary>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Break on Binary Subtraction.</para>
    /// <para> Represents the following element tag in the schema: m:brkBinSub </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public BreakBinarySubtraction BreakBinarySubtraction
    {
        get => GetElement<BreakBinarySubtraction>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Small Fraction.</para>
    /// <para> Represents the following element tag in the schema: m:smallFrac </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public SmallFraction SmallFraction
    {
        get => GetElement<SmallFraction>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> Use Display Math Defaults.</para>
    /// <para> Represents the following element tag in the schema: m:dispDef </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public DisplayDefaults DisplayDefaults
    {
        get => GetElement<DisplayDefaults>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> Left Margin.</para>
    /// <para> Represents the following element tag in the schema: m:lMargin </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public LeftMargin LeftMargin
    {
        get => GetElement<LeftMargin>(5);
        set => SetElement(5, value);
    }
    /// <summary>
    /// <para> Right Margin.</para>
    /// <para> Represents the following element tag in the schema: m:rMargin </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public RightMargin RightMargin
    {
        get => GetElement<RightMargin>(6);
        set => SetElement(6, value);
    }
    /// <summary>
    /// <para> Default Justification.</para>
    /// <para> Represents the following element tag in the schema: m:defJc </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public DefaultJustification DefaultJustification
    {
        get => GetElement<DefaultJustification>(7);
        set => SetElement(7, value);
    }
    /// <summary>
    /// <para> Pre-Equation Spacing.</para>
    /// <para> Represents the following element tag in the schema: m:preSp </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public PreSpacing PreSpacing
    {
        get => GetElement<PreSpacing>(8);
        set => SetElement(8, value);
    }
    /// <summary>
    /// <para> Post-Equation Spacing.</para>
    /// <para> Represents the following element tag in the schema: m:postSp </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public PostSpacing PostSpacing
    {
        get => GetElement<PostSpacing>(9);
        set => SetElement(9, value);
    }
    /// <summary>
    /// <para> Inter-Equation Spacing.</para>
    /// <para> Represents the following element tag in the schema: m:interSp </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public InterSpacing InterSpacing
    {
        get => GetElement<InterSpacing>(10);
        set => SetElement(10, value);
    }
    /// <summary>
    /// <para> Intra-Equation Spacing.</para>
    /// <para> Represents the following element tag in the schema: m:intraSp </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public IntraSpacing IntraSpacing
    {
        get => GetElement<IntraSpacing>(11);
        set => SetElement(11, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MathProperties>(deep);

}
/// <summary>
/// <para>Literal.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:lit.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Literal : OnOffType
{
    internal const int ElementTypeIdConst = 10930;
    /// <inheritdoc/>
    public override string LocalName => "lit";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Literal class.
    /// </summary>
    public Literal():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Literal>(deep);

}
/// <summary>
/// <para>Normal Text.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:nor.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class NormalText : OnOffType
{
    internal const int ElementTypeIdConst = 10931;
    /// <inheritdoc/>
    public override string LocalName => "nor";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the NormalText class.
    /// </summary>
    public NormalText():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NormalText>(deep);

}
/// <summary>
/// <para>Align.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:aln.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Alignment : OnOffType
{
    internal const int ElementTypeIdConst = 10933;
    /// <inheritdoc/>
    public override string LocalName => "aln";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Alignment class.
    /// </summary>
    public Alignment():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Alignment>(deep);

}
/// <summary>
/// <para>Operator Emulator.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:opEmu.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class OperatorEmulator : OnOffType
{
    internal const int ElementTypeIdConst = 10942;
    /// <inheritdoc/>
    public override string LocalName => "opEmu";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the OperatorEmulator class.
    /// </summary>
    public OperatorEmulator():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<OperatorEmulator>(deep);

}
/// <summary>
/// <para>No Break.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:noBreak.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class NoBreak : OnOffType
{
    internal const int ElementTypeIdConst = 10943;
    /// <inheritdoc/>
    public override string LocalName => "noBreak";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the NoBreak class.
    /// </summary>
    public NoBreak():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NoBreak>(deep);

}
/// <summary>
/// <para>Differential.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:diff.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Differential : OnOffType
{
    internal const int ElementTypeIdConst = 10944;
    /// <inheritdoc/>
    public override string LocalName => "diff";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Differential class.
    /// </summary>
    public Differential():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Differential>(deep);

}
/// <summary>
/// <para>Hide Top Edge.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:hideTop.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class HideTop : OnOffType
{
    internal const int ElementTypeIdConst = 10946;
    /// <inheritdoc/>
    public override string LocalName => "hideTop";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the HideTop class.
    /// </summary>
    public HideTop():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<HideTop>(deep);

}
/// <summary>
/// <para>Hide Bottom Edge.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:hideBot.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class HideBottom : OnOffType
{
    internal const int ElementTypeIdConst = 10947;
    /// <inheritdoc/>
    public override string LocalName => "hideBot";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the HideBottom class.
    /// </summary>
    public HideBottom():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<HideBottom>(deep);

}
/// <summary>
/// <para>Hide Left Edge.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:hideLeft.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class HideLeft : OnOffType
{
    internal const int ElementTypeIdConst = 10948;
    /// <inheritdoc/>
    public override string LocalName => "hideLeft";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the HideLeft class.
    /// </summary>
    public HideLeft():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<HideLeft>(deep);

}
/// <summary>
/// <para>Hide Right Edge.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:hideRight.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class HideRight : OnOffType
{
    internal const int ElementTypeIdConst = 10949;
    /// <inheritdoc/>
    public override string LocalName => "hideRight";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the HideRight class.
    /// </summary>
    public HideRight():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<HideRight>(deep);

}
/// <summary>
/// <para>Border Box Strikethrough Horizontal.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:strikeH.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class StrikeHorizontal : OnOffType
{
    internal const int ElementTypeIdConst = 10950;
    /// <inheritdoc/>
    public override string LocalName => "strikeH";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the StrikeHorizontal class.
    /// </summary>
    public StrikeHorizontal():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<StrikeHorizontal>(deep);

}
/// <summary>
/// <para>Border Box Strikethrough Vertical.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:strikeV.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class StrikeVertical : OnOffType
{
    internal const int ElementTypeIdConst = 10951;
    /// <inheritdoc/>
    public override string LocalName => "strikeV";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the StrikeVertical class.
    /// </summary>
    public StrikeVertical():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<StrikeVertical>(deep);

}
/// <summary>
/// <para>Border Box Strikethrough Bottom-Left to Top-Right.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:strikeBLTR.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class StrikeBottomLeftToTopRight : OnOffType
{
    internal const int ElementTypeIdConst = 10952;
    /// <inheritdoc/>
    public override string LocalName => "strikeBLTR";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the StrikeBottomLeftToTopRight class.
    /// </summary>
    public StrikeBottomLeftToTopRight():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<StrikeBottomLeftToTopRight>(deep);

}
/// <summary>
/// <para>Border Box Strikethrough Top-Left to Bottom-Right.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:strikeTLBR.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class StrikeTopLeftToBottomRight : OnOffType
{
    internal const int ElementTypeIdConst = 10953;
    /// <inheritdoc/>
    public override string LocalName => "strikeTLBR";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the StrikeTopLeftToBottomRight class.
    /// </summary>
    public StrikeTopLeftToBottomRight():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<StrikeTopLeftToBottomRight>(deep);

}
/// <summary>
/// <para>Delimiter Grow.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:grow.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class GrowOperators : OnOffType
{
    internal const int ElementTypeIdConst = 10958;
    /// <inheritdoc/>
    public override string LocalName => "grow";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the GrowOperators class.
    /// </summary>
    public GrowOperators():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<GrowOperators>(deep);

}
/// <summary>
/// <para>Maximum Distribution.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:maxDist.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class MaxDistribution : OnOffType
{
    internal const int ElementTypeIdConst = 10962;
    /// <inheritdoc/>
    public override string LocalName => "maxDist";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the MaxDistribution class.
    /// </summary>
    public MaxDistribution():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MaxDistribution>(deep);

}
/// <summary>
/// <para>Object Distribution.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:objDist.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ObjectDistribution : OnOffType
{
    internal const int ElementTypeIdConst = 10963;
    /// <inheritdoc/>
    public override string LocalName => "objDist";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the ObjectDistribution class.
    /// </summary>
    public ObjectDistribution():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ObjectDistribution>(deep);

}
/// <summary>
/// <para>Hide Placeholders (Matrix).</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:plcHide.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class HidePlaceholder : OnOffType
{
    internal const int ElementTypeIdConst = 10982;
    /// <inheritdoc/>
    public override string LocalName => "plcHide";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the HidePlaceholder class.
    /// </summary>
    public HidePlaceholder():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<HidePlaceholder>(deep);

}
/// <summary>
/// <para>Hide Subscript (n-ary).</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:subHide.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class HideSubArgument : OnOffType
{
    internal const int ElementTypeIdConst = 10990;
    /// <inheritdoc/>
    public override string LocalName => "subHide";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the HideSubArgument class.
    /// </summary>
    public HideSubArgument():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<HideSubArgument>(deep);

}
/// <summary>
/// <para>Hide Superscript (n-ary).</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:supHide.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class HideSuperArgument : OnOffType
{
    internal const int ElementTypeIdConst = 10991;
    /// <inheritdoc/>
    public override string LocalName => "supHide";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the HideSuperArgument class.
    /// </summary>
    public HideSuperArgument():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<HideSuperArgument>(deep);

}
/// <summary>
/// <para>Phantom Show.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:show.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ShowPhantom : OnOffType
{
    internal const int ElementTypeIdConst = 10995;
    /// <inheritdoc/>
    public override string LocalName => "show";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the ShowPhantom class.
    /// </summary>
    public ShowPhantom():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowPhantom>(deep);

}
/// <summary>
/// <para>Phantom Zero Width.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:zeroWid.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ZeroWidth : OnOffType
{
    internal const int ElementTypeIdConst = 10996;
    /// <inheritdoc/>
    public override string LocalName => "zeroWid";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the ZeroWidth class.
    /// </summary>
    public ZeroWidth():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ZeroWidth>(deep);

}
/// <summary>
/// <para>Phantom Zero Ascent.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:zeroAsc.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ZeroAscent : OnOffType
{
    internal const int ElementTypeIdConst = 10997;
    /// <inheritdoc/>
    public override string LocalName => "zeroAsc";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the ZeroAscent class.
    /// </summary>
    public ZeroAscent():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ZeroAscent>(deep);

}
/// <summary>
/// <para>Phantom Zero Descent.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:zeroDesc.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ZeroDescent : OnOffType
{
    internal const int ElementTypeIdConst = 10998;
    /// <inheritdoc/>
    public override string LocalName => "zeroDesc";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the ZeroDescent class.
    /// </summary>
    public ZeroDescent():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ZeroDescent>(deep);

}
/// <summary>
/// <para>Transparent (Phantom).</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:transp.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Transparent : OnOffType
{
    internal const int ElementTypeIdConst = 10999;
    /// <inheritdoc/>
    public override string LocalName => "transp";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Transparent class.
    /// </summary>
    public Transparent():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Transparent>(deep);

}
/// <summary>
/// <para>Hide Degree.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:degHide.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class HideDegree : OnOffType
{
    internal const int ElementTypeIdConst = 11001;
    /// <inheritdoc/>
    public override string LocalName => "degHide";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the HideDegree class.
    /// </summary>
    public HideDegree():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<HideDegree>(deep);

}
/// <summary>
/// <para>Align Scripts.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:alnScr.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class AlignScripts : OnOffType
{
    internal const int ElementTypeIdConst = 11006;
    /// <inheritdoc/>
    public override string LocalName => "alnScr";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the AlignScripts class.
    /// </summary>
    public AlignScripts():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AlignScripts>(deep);

}
/// <summary>
/// <para>Small Fraction.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:smallFrac.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SmallFraction : OnOffType
{
    internal const int ElementTypeIdConst = 11015;
    /// <inheritdoc/>
    public override string LocalName => "smallFrac";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the SmallFraction class.
    /// </summary>
    public SmallFraction():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SmallFraction>(deep);

}
/// <summary>
/// <para>Use Display Math Defaults.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:dispDef.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DisplayDefaults : OnOffType
{
    internal const int ElementTypeIdConst = 11016;
    /// <inheritdoc/>
    public override string LocalName => "dispDef";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the DisplayDefaults class.
    /// </summary>
    public DisplayDefaults():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DisplayDefaults>(deep);

}
/// <summary>
/// <para>Wrap Right.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:wrapRight.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class WrapRight : OnOffType
{
    internal const int ElementTypeIdConst = 11025;
    /// <inheritdoc/>
    public override string LocalName => "wrapRight";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the WrapRight class.
    /// </summary>
    public WrapRight():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WrapRight>(deep);

}
/// <summary>
/// Defines the OnOffType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class OnOffType : OpenXmlLeafElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Math.BooleanValues>>(21, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public EnumValue<DocumentFormat.OpenXml.Math.BooleanValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Math.BooleanValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the OnOffType class.
    /// </summary>
    protected OnOffType(){}
    
    
    
}
/// <summary>
/// <para>Break.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:brk.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Break : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10932;
    /// <inheritdoc/>
    public override string LocalName => "brk";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<IntegerValue>(21, "alnAt"),
		AttributeTag.Create<IntegerValue>(21, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Index of Operator to Align To.</para>
    /// <para>Represents the following attribute in the schema: m:alnAt </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "alnAt")]
    public IntegerValue AlignAt
    {
        get { return (IntegerValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    
    /// <summary>
    /// <para> Index of Operator to Align To.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public IntegerValue Val
    {
        get { return (IntegerValue)Attributes[1].Value; }
        set { Attributes[1].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Break class.
    /// </summary>
    public Break():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Break>(deep);

}
/// <summary>
/// <para>Run Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:rPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Literal &lt;m:lit></description></item>
///<item><description>NormalText &lt;m:nor></description></item>
///<item><description>Script &lt;m:scr></description></item>
///<item><description>Style &lt;m:sty></description></item>
///<item><description>Break &lt;m:brk></description></item>
///<item><description>Alignment &lt;m:aln></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Literal))]
    [ChildElementInfo(typeof(NormalText))]
    [ChildElementInfo(typeof(Script))]
    [ChildElementInfo(typeof(Style))]
    [ChildElementInfo(typeof(Break))]
    [ChildElementInfo(typeof(Alignment))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class RunProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10934;
    /// <inheritdoc/>
    public override string LocalName => "rPr";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the RunProperties class.
    /// </summary>
    public RunProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the RunProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RunProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the RunProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RunProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the RunProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public RunProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "lit" == name)
    return new Literal();
    
if( 21 == namespaceId && "nor" == name)
    return new NormalText();
    
if( 21 == namespaceId && "scr" == name)
    return new Script();
    
if( 21 == namespaceId && "sty" == name)
    return new Style();
    
if( 21 == namespaceId && "brk" == name)
    return new Break();
    
if( 21 == namespaceId && "aln" == name)
    return new Alignment();
    

    return null;
}

        private static readonly string[] eleTagNames = { "lit","nor","scr","sty","brk","aln" };
    private static readonly byte[] eleNamespaceIds = { 21,21,21,21,21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Literal.</para>
    /// <para> Represents the following element tag in the schema: m:lit </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public Literal Literal
    {
        get => GetElement<Literal>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RunProperties>(deep);

}
/// <summary>
/// <para>Text.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:t.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Text : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 10935;
    /// <inheritdoc/>
    public override string LocalName => "t";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.SpaceProcessingModeValues>>(1, "space")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> space.</para>
    /// <para>Represents the following attribute in the schema: xml:space </para>
    /// </summary>
///<remark> xmlns:xml=http://www.w3.org/XML/1998/namespace
///</remark>
    [SchemaAttr(1, "space")]
    public EnumValue<DocumentFormat.OpenXml.SpaceProcessingModeValues> Space
    {
        get { return (EnumValue<DocumentFormat.OpenXml.SpaceProcessingModeValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Text class.
    /// </summary>
    public Text():base(){}
    
      
        /// <summary>
    /// Initializes a new instance of the Text class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public Text(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new StringValue(){ InnerText = text };
    }
    
 
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Text>(deep);

}
/// <summary>
/// <para>Accent Character.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:chr.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class AccentChar : CharType
{
    internal const int ElementTypeIdConst = 10936;
    /// <inheritdoc/>
    public override string LocalName => "chr";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the AccentChar class.
    /// </summary>
    public AccentChar():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AccentChar>(deep);

}
/// <summary>
/// <para>Delimiter Beginning Character.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:begChr.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class BeginChar : CharType
{
    internal const int ElementTypeIdConst = 10955;
    /// <inheritdoc/>
    public override string LocalName => "begChr";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the BeginChar class.
    /// </summary>
    public BeginChar():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BeginChar>(deep);

}
/// <summary>
/// <para>Delimiter Separator Character.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:sepChr.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SeparatorChar : CharType
{
    internal const int ElementTypeIdConst = 10956;
    /// <inheritdoc/>
    public override string LocalName => "sepChr";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the SeparatorChar class.
    /// </summary>
    public SeparatorChar():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SeparatorChar>(deep);

}
/// <summary>
/// <para>Delimiter Ending Character.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:endChr.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class EndChar : CharType
{
    internal const int ElementTypeIdConst = 10957;
    /// <inheritdoc/>
    public override string LocalName => "endChr";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the EndChar class.
    /// </summary>
    public EndChar():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<EndChar>(deep);

}
/// <summary>
/// Defines the CharType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class CharType : OpenXmlLeafElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(21, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public StringValue Val
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the CharType class.
    /// </summary>
    protected CharType(){}
    
    
    
}
/// <summary>
/// <para>Control Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:ctrlPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Wordprocessing.RunProperties &lt;w:rPr></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl &lt;w:ins></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.DeletedMathControl &lt;w:del></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromMathControl &lt;w:moveFrom></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToMathControl &lt;w:moveTo></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.RunProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedMathControl))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromMathControl))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToMathControl))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ControlProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10937;
    /// <inheritdoc/>
    public override string LocalName => "ctrlPr";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ControlProperties class.
    /// </summary>
    public ControlProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ControlProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ControlProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ControlProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ControlProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ControlProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ControlProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 23 == namespaceId && "rPr" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.RunProperties();
    
if( 23 == namespaceId && "ins" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl();
    
if( 23 == namespaceId && "del" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.DeletedMathControl();
    
if( 23 == namespaceId && "moveFrom" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.MoveFromMathControl();
    
if( 23 == namespaceId && "moveTo" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.MoveToMathControl();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ControlProperties>(deep);

}
/// <summary>
/// <para>Accent Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:accPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>AccentChar &lt;m:chr></description></item>
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(AccentChar))]
    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class AccentProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10938;
    /// <inheritdoc/>
    public override string LocalName => "accPr";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the AccentProperties class.
    /// </summary>
    public AccentProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the AccentProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AccentProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the AccentProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public AccentProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the AccentProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public AccentProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "chr" == name)
    return new AccentChar();
    
if( 21 == namespaceId && "ctrlPr" == name)
    return new ControlProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "chr","ctrlPr" };
    private static readonly byte[] eleNamespaceIds = { 21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Accent Character.</para>
    /// <para> Represents the following element tag in the schema: m:chr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public AccentChar AccentChar
    {
        get => GetElement<AccentChar>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Control Properties.</para>
    /// <para> Represents the following element tag in the schema: m:ctrlPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public ControlProperties ControlProperties
    {
        get => GetElement<ControlProperties>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<AccentProperties>(deep);

}
/// <summary>
/// <para>Base.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:e.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ArgumentProperties &lt;m:argPr></description></item>
///<item><description>Accent &lt;m:acc></description></item>
///<item><description>Bar &lt;m:bar></description></item>
///<item><description>Box &lt;m:box></description></item>
///<item><description>BorderBox &lt;m:borderBox></description></item>
///<item><description>Delimiter &lt;m:d></description></item>
///<item><description>EquationArray &lt;m:eqArr></description></item>
///<item><description>Fraction &lt;m:f></description></item>
///<item><description>MathFunction &lt;m:func></description></item>
///<item><description>GroupChar &lt;m:groupChr></description></item>
///<item><description>LimitLower &lt;m:limLow></description></item>
///<item><description>LimitUpper &lt;m:limUpp></description></item>
///<item><description>Matrix &lt;m:m></description></item>
///<item><description>Nary &lt;m:nary></description></item>
///<item><description>Phantom &lt;m:phant></description></item>
///<item><description>Radical &lt;m:rad></description></item>
///<item><description>PreSubSuper &lt;m:sPre></description></item>
///<item><description>Subscript &lt;m:sSub></description></item>
///<item><description>SubSuperscript &lt;m:sSubSup></description></item>
///<item><description>Superscript &lt;m:sSup></description></item>
///<item><description>Run &lt;m:r></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun &lt;w:customXml></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.SimpleField &lt;w:fldSimple></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.Hyperlink &lt;w:hyperlink></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.SdtRun &lt;w:sdt></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.ProofError &lt;w:proofErr></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.PermStart &lt;w:permStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.PermEnd &lt;w:permEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkStart &lt;w:bookmarkStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd &lt;w:bookmarkEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart &lt;w:commentRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd &lt;w:commentRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart &lt;w:moveFromRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd &lt;w:moveFromRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart &lt;w:moveToRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd &lt;w:moveToRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart &lt;w:customXmlInsRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd &lt;w:customXmlInsRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart &lt;w:customXmlDelRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd &lt;w:customXmlDelRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart &lt;w:customXmlMoveFromRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd &lt;w:customXmlMoveFromRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart &lt;w:customXmlMoveToRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd &lt;w:customXmlMoveToRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart &lt;w14:customXmlConflictInsRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd &lt;w14:customXmlConflictInsRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart &lt;w14:customXmlConflictDelRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd &lt;w14:customXmlConflictDelRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.InsertedRun &lt;w:ins></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.DeletedRun &lt;w:del></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRun &lt;w:moveFrom></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRun &lt;w:moveTo></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.ContentPart &lt;w:contentPart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion &lt;w14:conflictIns></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion &lt;w14:conflictDel></description></item>
///<item><description>Paragraph &lt;m:oMathPara></description></item>
///<item><description>OfficeMath &lt;m:oMath></description></item>
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Base : OfficeMathArgumentType
{
    internal const int ElementTypeIdConst = 10939;
    /// <inheritdoc/>
    public override string LocalName => "e";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Base class.
    /// </summary>
    public Base():base(){}
        /// <summary>
    ///Initializes a new instance of the Base class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Base(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Base class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Base(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Base class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Base(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Base>(deep);

}
/// <summary>
/// <para>Numerator.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:num.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ArgumentProperties &lt;m:argPr></description></item>
///<item><description>Accent &lt;m:acc></description></item>
///<item><description>Bar &lt;m:bar></description></item>
///<item><description>Box &lt;m:box></description></item>
///<item><description>BorderBox &lt;m:borderBox></description></item>
///<item><description>Delimiter &lt;m:d></description></item>
///<item><description>EquationArray &lt;m:eqArr></description></item>
///<item><description>Fraction &lt;m:f></description></item>
///<item><description>MathFunction &lt;m:func></description></item>
///<item><description>GroupChar &lt;m:groupChr></description></item>
///<item><description>LimitLower &lt;m:limLow></description></item>
///<item><description>LimitUpper &lt;m:limUpp></description></item>
///<item><description>Matrix &lt;m:m></description></item>
///<item><description>Nary &lt;m:nary></description></item>
///<item><description>Phantom &lt;m:phant></description></item>
///<item><description>Radical &lt;m:rad></description></item>
///<item><description>PreSubSuper &lt;m:sPre></description></item>
///<item><description>Subscript &lt;m:sSub></description></item>
///<item><description>SubSuperscript &lt;m:sSubSup></description></item>
///<item><description>Superscript &lt;m:sSup></description></item>
///<item><description>Run &lt;m:r></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun &lt;w:customXml></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.SimpleField &lt;w:fldSimple></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.Hyperlink &lt;w:hyperlink></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.SdtRun &lt;w:sdt></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.ProofError &lt;w:proofErr></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.PermStart &lt;w:permStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.PermEnd &lt;w:permEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkStart &lt;w:bookmarkStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd &lt;w:bookmarkEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart &lt;w:commentRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd &lt;w:commentRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart &lt;w:moveFromRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd &lt;w:moveFromRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart &lt;w:moveToRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd &lt;w:moveToRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart &lt;w:customXmlInsRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd &lt;w:customXmlInsRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart &lt;w:customXmlDelRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd &lt;w:customXmlDelRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart &lt;w:customXmlMoveFromRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd &lt;w:customXmlMoveFromRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart &lt;w:customXmlMoveToRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd &lt;w:customXmlMoveToRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart &lt;w14:customXmlConflictInsRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd &lt;w14:customXmlConflictInsRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart &lt;w14:customXmlConflictDelRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd &lt;w14:customXmlConflictDelRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.InsertedRun &lt;w:ins></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.DeletedRun &lt;w:del></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRun &lt;w:moveFrom></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRun &lt;w:moveTo></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.ContentPart &lt;w:contentPart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion &lt;w14:conflictIns></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion &lt;w14:conflictDel></description></item>
///<item><description>Paragraph &lt;m:oMathPara></description></item>
///<item><description>OfficeMath &lt;m:oMath></description></item>
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Numerator : OfficeMathArgumentType
{
    internal const int ElementTypeIdConst = 10969;
    /// <inheritdoc/>
    public override string LocalName => "num";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Numerator class.
    /// </summary>
    public Numerator():base(){}
        /// <summary>
    ///Initializes a new instance of the Numerator class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Numerator(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Numerator class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Numerator(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Numerator class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Numerator(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Numerator>(deep);

}
/// <summary>
/// <para>Denominator.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:den.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ArgumentProperties &lt;m:argPr></description></item>
///<item><description>Accent &lt;m:acc></description></item>
///<item><description>Bar &lt;m:bar></description></item>
///<item><description>Box &lt;m:box></description></item>
///<item><description>BorderBox &lt;m:borderBox></description></item>
///<item><description>Delimiter &lt;m:d></description></item>
///<item><description>EquationArray &lt;m:eqArr></description></item>
///<item><description>Fraction &lt;m:f></description></item>
///<item><description>MathFunction &lt;m:func></description></item>
///<item><description>GroupChar &lt;m:groupChr></description></item>
///<item><description>LimitLower &lt;m:limLow></description></item>
///<item><description>LimitUpper &lt;m:limUpp></description></item>
///<item><description>Matrix &lt;m:m></description></item>
///<item><description>Nary &lt;m:nary></description></item>
///<item><description>Phantom &lt;m:phant></description></item>
///<item><description>Radical &lt;m:rad></description></item>
///<item><description>PreSubSuper &lt;m:sPre></description></item>
///<item><description>Subscript &lt;m:sSub></description></item>
///<item><description>SubSuperscript &lt;m:sSubSup></description></item>
///<item><description>Superscript &lt;m:sSup></description></item>
///<item><description>Run &lt;m:r></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun &lt;w:customXml></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.SimpleField &lt;w:fldSimple></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.Hyperlink &lt;w:hyperlink></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.SdtRun &lt;w:sdt></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.ProofError &lt;w:proofErr></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.PermStart &lt;w:permStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.PermEnd &lt;w:permEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkStart &lt;w:bookmarkStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd &lt;w:bookmarkEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart &lt;w:commentRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd &lt;w:commentRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart &lt;w:moveFromRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd &lt;w:moveFromRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart &lt;w:moveToRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd &lt;w:moveToRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart &lt;w:customXmlInsRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd &lt;w:customXmlInsRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart &lt;w:customXmlDelRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd &lt;w:customXmlDelRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart &lt;w:customXmlMoveFromRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd &lt;w:customXmlMoveFromRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart &lt;w:customXmlMoveToRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd &lt;w:customXmlMoveToRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart &lt;w14:customXmlConflictInsRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd &lt;w14:customXmlConflictInsRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart &lt;w14:customXmlConflictDelRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd &lt;w14:customXmlConflictDelRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.InsertedRun &lt;w:ins></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.DeletedRun &lt;w:del></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRun &lt;w:moveFrom></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRun &lt;w:moveTo></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.ContentPart &lt;w:contentPart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion &lt;w14:conflictIns></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion &lt;w14:conflictDel></description></item>
///<item><description>Paragraph &lt;m:oMathPara></description></item>
///<item><description>OfficeMath &lt;m:oMath></description></item>
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Denominator : OfficeMathArgumentType
{
    internal const int ElementTypeIdConst = 10970;
    /// <inheritdoc/>
    public override string LocalName => "den";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Denominator class.
    /// </summary>
    public Denominator():base(){}
        /// <summary>
    ///Initializes a new instance of the Denominator class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Denominator(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Denominator class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Denominator(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Denominator class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Denominator(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Denominator>(deep);

}
/// <summary>
/// <para>Function Name.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:fName.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ArgumentProperties &lt;m:argPr></description></item>
///<item><description>Accent &lt;m:acc></description></item>
///<item><description>Bar &lt;m:bar></description></item>
///<item><description>Box &lt;m:box></description></item>
///<item><description>BorderBox &lt;m:borderBox></description></item>
///<item><description>Delimiter &lt;m:d></description></item>
///<item><description>EquationArray &lt;m:eqArr></description></item>
///<item><description>Fraction &lt;m:f></description></item>
///<item><description>MathFunction &lt;m:func></description></item>
///<item><description>GroupChar &lt;m:groupChr></description></item>
///<item><description>LimitLower &lt;m:limLow></description></item>
///<item><description>LimitUpper &lt;m:limUpp></description></item>
///<item><description>Matrix &lt;m:m></description></item>
///<item><description>Nary &lt;m:nary></description></item>
///<item><description>Phantom &lt;m:phant></description></item>
///<item><description>Radical &lt;m:rad></description></item>
///<item><description>PreSubSuper &lt;m:sPre></description></item>
///<item><description>Subscript &lt;m:sSub></description></item>
///<item><description>SubSuperscript &lt;m:sSubSup></description></item>
///<item><description>Superscript &lt;m:sSup></description></item>
///<item><description>Run &lt;m:r></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun &lt;w:customXml></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.SimpleField &lt;w:fldSimple></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.Hyperlink &lt;w:hyperlink></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.SdtRun &lt;w:sdt></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.ProofError &lt;w:proofErr></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.PermStart &lt;w:permStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.PermEnd &lt;w:permEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkStart &lt;w:bookmarkStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd &lt;w:bookmarkEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart &lt;w:commentRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd &lt;w:commentRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart &lt;w:moveFromRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd &lt;w:moveFromRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart &lt;w:moveToRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd &lt;w:moveToRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart &lt;w:customXmlInsRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd &lt;w:customXmlInsRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart &lt;w:customXmlDelRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd &lt;w:customXmlDelRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart &lt;w:customXmlMoveFromRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd &lt;w:customXmlMoveFromRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart &lt;w:customXmlMoveToRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd &lt;w:customXmlMoveToRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart &lt;w14:customXmlConflictInsRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd &lt;w14:customXmlConflictInsRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart &lt;w14:customXmlConflictDelRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd &lt;w14:customXmlConflictDelRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.InsertedRun &lt;w:ins></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.DeletedRun &lt;w:del></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRun &lt;w:moveFrom></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRun &lt;w:moveTo></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.ContentPart &lt;w:contentPart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion &lt;w14:conflictIns></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion &lt;w14:conflictDel></description></item>
///<item><description>Paragraph &lt;m:oMathPara></description></item>
///<item><description>OfficeMath &lt;m:oMath></description></item>
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class FunctionName : OfficeMathArgumentType
{
    internal const int ElementTypeIdConst = 10972;
    /// <inheritdoc/>
    public override string LocalName => "fName";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the FunctionName class.
    /// </summary>
    public FunctionName():base(){}
        /// <summary>
    ///Initializes a new instance of the FunctionName class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FunctionName(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the FunctionName class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FunctionName(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the FunctionName class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public FunctionName(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FunctionName>(deep);

}
/// <summary>
/// <para>Limit (Lower).</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:lim.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ArgumentProperties &lt;m:argPr></description></item>
///<item><description>Accent &lt;m:acc></description></item>
///<item><description>Bar &lt;m:bar></description></item>
///<item><description>Box &lt;m:box></description></item>
///<item><description>BorderBox &lt;m:borderBox></description></item>
///<item><description>Delimiter &lt;m:d></description></item>
///<item><description>EquationArray &lt;m:eqArr></description></item>
///<item><description>Fraction &lt;m:f></description></item>
///<item><description>MathFunction &lt;m:func></description></item>
///<item><description>GroupChar &lt;m:groupChr></description></item>
///<item><description>LimitLower &lt;m:limLow></description></item>
///<item><description>LimitUpper &lt;m:limUpp></description></item>
///<item><description>Matrix &lt;m:m></description></item>
///<item><description>Nary &lt;m:nary></description></item>
///<item><description>Phantom &lt;m:phant></description></item>
///<item><description>Radical &lt;m:rad></description></item>
///<item><description>PreSubSuper &lt;m:sPre></description></item>
///<item><description>Subscript &lt;m:sSub></description></item>
///<item><description>SubSuperscript &lt;m:sSubSup></description></item>
///<item><description>Superscript &lt;m:sSup></description></item>
///<item><description>Run &lt;m:r></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun &lt;w:customXml></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.SimpleField &lt;w:fldSimple></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.Hyperlink &lt;w:hyperlink></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.SdtRun &lt;w:sdt></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.ProofError &lt;w:proofErr></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.PermStart &lt;w:permStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.PermEnd &lt;w:permEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkStart &lt;w:bookmarkStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd &lt;w:bookmarkEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart &lt;w:commentRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd &lt;w:commentRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart &lt;w:moveFromRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd &lt;w:moveFromRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart &lt;w:moveToRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd &lt;w:moveToRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart &lt;w:customXmlInsRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd &lt;w:customXmlInsRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart &lt;w:customXmlDelRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd &lt;w:customXmlDelRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart &lt;w:customXmlMoveFromRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd &lt;w:customXmlMoveFromRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart &lt;w:customXmlMoveToRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd &lt;w:customXmlMoveToRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart &lt;w14:customXmlConflictInsRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd &lt;w14:customXmlConflictInsRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart &lt;w14:customXmlConflictDelRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd &lt;w14:customXmlConflictDelRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.InsertedRun &lt;w:ins></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.DeletedRun &lt;w:del></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRun &lt;w:moveFrom></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRun &lt;w:moveTo></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.ContentPart &lt;w:contentPart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion &lt;w14:conflictIns></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion &lt;w14:conflictDel></description></item>
///<item><description>Paragraph &lt;m:oMathPara></description></item>
///<item><description>OfficeMath &lt;m:oMath></description></item>
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Limit : OfficeMathArgumentType
{
    internal const int ElementTypeIdConst = 10976;
    /// <inheritdoc/>
    public override string LocalName => "lim";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Limit class.
    /// </summary>
    public Limit():base(){}
        /// <summary>
    ///Initializes a new instance of the Limit class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Limit(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Limit class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Limit(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Limit class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Limit(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Limit>(deep);

}
/// <summary>
/// <para>Lower limit (n-ary) .</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:sub.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ArgumentProperties &lt;m:argPr></description></item>
///<item><description>Accent &lt;m:acc></description></item>
///<item><description>Bar &lt;m:bar></description></item>
///<item><description>Box &lt;m:box></description></item>
///<item><description>BorderBox &lt;m:borderBox></description></item>
///<item><description>Delimiter &lt;m:d></description></item>
///<item><description>EquationArray &lt;m:eqArr></description></item>
///<item><description>Fraction &lt;m:f></description></item>
///<item><description>MathFunction &lt;m:func></description></item>
///<item><description>GroupChar &lt;m:groupChr></description></item>
///<item><description>LimitLower &lt;m:limLow></description></item>
///<item><description>LimitUpper &lt;m:limUpp></description></item>
///<item><description>Matrix &lt;m:m></description></item>
///<item><description>Nary &lt;m:nary></description></item>
///<item><description>Phantom &lt;m:phant></description></item>
///<item><description>Radical &lt;m:rad></description></item>
///<item><description>PreSubSuper &lt;m:sPre></description></item>
///<item><description>Subscript &lt;m:sSub></description></item>
///<item><description>SubSuperscript &lt;m:sSubSup></description></item>
///<item><description>Superscript &lt;m:sSup></description></item>
///<item><description>Run &lt;m:r></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun &lt;w:customXml></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.SimpleField &lt;w:fldSimple></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.Hyperlink &lt;w:hyperlink></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.SdtRun &lt;w:sdt></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.ProofError &lt;w:proofErr></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.PermStart &lt;w:permStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.PermEnd &lt;w:permEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkStart &lt;w:bookmarkStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd &lt;w:bookmarkEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart &lt;w:commentRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd &lt;w:commentRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart &lt;w:moveFromRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd &lt;w:moveFromRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart &lt;w:moveToRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd &lt;w:moveToRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart &lt;w:customXmlInsRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd &lt;w:customXmlInsRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart &lt;w:customXmlDelRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd &lt;w:customXmlDelRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart &lt;w:customXmlMoveFromRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd &lt;w:customXmlMoveFromRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart &lt;w:customXmlMoveToRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd &lt;w:customXmlMoveToRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart &lt;w14:customXmlConflictInsRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd &lt;w14:customXmlConflictInsRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart &lt;w14:customXmlConflictDelRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd &lt;w14:customXmlConflictDelRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.InsertedRun &lt;w:ins></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.DeletedRun &lt;w:del></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRun &lt;w:moveFrom></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRun &lt;w:moveTo></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.ContentPart &lt;w:contentPart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion &lt;w14:conflictIns></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion &lt;w14:conflictDel></description></item>
///<item><description>Paragraph &lt;m:oMathPara></description></item>
///<item><description>OfficeMath &lt;m:oMath></description></item>
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SubArgument : OfficeMathArgumentType
{
    internal const int ElementTypeIdConst = 10993;
    /// <inheritdoc/>
    public override string LocalName => "sub";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the SubArgument class.
    /// </summary>
    public SubArgument():base(){}
        /// <summary>
    ///Initializes a new instance of the SubArgument class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SubArgument(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SubArgument class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SubArgument(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SubArgument class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SubArgument(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SubArgument>(deep);

}
/// <summary>
/// <para>Upper limit (n-ary).</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:sup.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ArgumentProperties &lt;m:argPr></description></item>
///<item><description>Accent &lt;m:acc></description></item>
///<item><description>Bar &lt;m:bar></description></item>
///<item><description>Box &lt;m:box></description></item>
///<item><description>BorderBox &lt;m:borderBox></description></item>
///<item><description>Delimiter &lt;m:d></description></item>
///<item><description>EquationArray &lt;m:eqArr></description></item>
///<item><description>Fraction &lt;m:f></description></item>
///<item><description>MathFunction &lt;m:func></description></item>
///<item><description>GroupChar &lt;m:groupChr></description></item>
///<item><description>LimitLower &lt;m:limLow></description></item>
///<item><description>LimitUpper &lt;m:limUpp></description></item>
///<item><description>Matrix &lt;m:m></description></item>
///<item><description>Nary &lt;m:nary></description></item>
///<item><description>Phantom &lt;m:phant></description></item>
///<item><description>Radical &lt;m:rad></description></item>
///<item><description>PreSubSuper &lt;m:sPre></description></item>
///<item><description>Subscript &lt;m:sSub></description></item>
///<item><description>SubSuperscript &lt;m:sSubSup></description></item>
///<item><description>Superscript &lt;m:sSup></description></item>
///<item><description>Run &lt;m:r></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun &lt;w:customXml></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.SimpleField &lt;w:fldSimple></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.Hyperlink &lt;w:hyperlink></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.SdtRun &lt;w:sdt></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.ProofError &lt;w:proofErr></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.PermStart &lt;w:permStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.PermEnd &lt;w:permEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkStart &lt;w:bookmarkStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd &lt;w:bookmarkEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart &lt;w:commentRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd &lt;w:commentRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart &lt;w:moveFromRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd &lt;w:moveFromRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart &lt;w:moveToRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd &lt;w:moveToRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart &lt;w:customXmlInsRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd &lt;w:customXmlInsRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart &lt;w:customXmlDelRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd &lt;w:customXmlDelRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart &lt;w:customXmlMoveFromRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd &lt;w:customXmlMoveFromRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart &lt;w:customXmlMoveToRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd &lt;w:customXmlMoveToRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart &lt;w14:customXmlConflictInsRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd &lt;w14:customXmlConflictInsRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart &lt;w14:customXmlConflictDelRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd &lt;w14:customXmlConflictDelRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.InsertedRun &lt;w:ins></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.DeletedRun &lt;w:del></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRun &lt;w:moveFrom></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRun &lt;w:moveTo></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.ContentPart &lt;w:contentPart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion &lt;w14:conflictIns></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion &lt;w14:conflictDel></description></item>
///<item><description>Paragraph &lt;m:oMathPara></description></item>
///<item><description>OfficeMath &lt;m:oMath></description></item>
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SuperArgument : OfficeMathArgumentType
{
    internal const int ElementTypeIdConst = 10994;
    /// <inheritdoc/>
    public override string LocalName => "sup";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the SuperArgument class.
    /// </summary>
    public SuperArgument():base(){}
        /// <summary>
    ///Initializes a new instance of the SuperArgument class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SuperArgument(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SuperArgument class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SuperArgument(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SuperArgument class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SuperArgument(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SuperArgument>(deep);

}
/// <summary>
/// <para>Degree.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:deg.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ArgumentProperties &lt;m:argPr></description></item>
///<item><description>Accent &lt;m:acc></description></item>
///<item><description>Bar &lt;m:bar></description></item>
///<item><description>Box &lt;m:box></description></item>
///<item><description>BorderBox &lt;m:borderBox></description></item>
///<item><description>Delimiter &lt;m:d></description></item>
///<item><description>EquationArray &lt;m:eqArr></description></item>
///<item><description>Fraction &lt;m:f></description></item>
///<item><description>MathFunction &lt;m:func></description></item>
///<item><description>GroupChar &lt;m:groupChr></description></item>
///<item><description>LimitLower &lt;m:limLow></description></item>
///<item><description>LimitUpper &lt;m:limUpp></description></item>
///<item><description>Matrix &lt;m:m></description></item>
///<item><description>Nary &lt;m:nary></description></item>
///<item><description>Phantom &lt;m:phant></description></item>
///<item><description>Radical &lt;m:rad></description></item>
///<item><description>PreSubSuper &lt;m:sPre></description></item>
///<item><description>Subscript &lt;m:sSub></description></item>
///<item><description>SubSuperscript &lt;m:sSubSup></description></item>
///<item><description>Superscript &lt;m:sSup></description></item>
///<item><description>Run &lt;m:r></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun &lt;w:customXml></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.SimpleField &lt;w:fldSimple></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.Hyperlink &lt;w:hyperlink></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.SdtRun &lt;w:sdt></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.ProofError &lt;w:proofErr></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.PermStart &lt;w:permStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.PermEnd &lt;w:permEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkStart &lt;w:bookmarkStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd &lt;w:bookmarkEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart &lt;w:commentRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd &lt;w:commentRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart &lt;w:moveFromRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd &lt;w:moveFromRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart &lt;w:moveToRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd &lt;w:moveToRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart &lt;w:customXmlInsRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd &lt;w:customXmlInsRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart &lt;w:customXmlDelRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd &lt;w:customXmlDelRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart &lt;w:customXmlMoveFromRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd &lt;w:customXmlMoveFromRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart &lt;w:customXmlMoveToRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd &lt;w:customXmlMoveToRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart &lt;w14:customXmlConflictInsRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd &lt;w14:customXmlConflictInsRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart &lt;w14:customXmlConflictDelRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd &lt;w14:customXmlConflictDelRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.InsertedRun &lt;w:ins></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.DeletedRun &lt;w:del></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRun &lt;w:moveFrom></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRun &lt;w:moveTo></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.ContentPart &lt;w:contentPart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion &lt;w14:conflictIns></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion &lt;w14:conflictDel></description></item>
///<item><description>Paragraph &lt;m:oMathPara></description></item>
///<item><description>OfficeMath &lt;m:oMath></description></item>
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Degree : OfficeMathArgumentType
{
    internal const int ElementTypeIdConst = 11003;
    /// <inheritdoc/>
    public override string LocalName => "deg";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Degree class.
    /// </summary>
    public Degree():base(){}
        /// <summary>
    ///Initializes a new instance of the Degree class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Degree(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Degree class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Degree(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Degree class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Degree(string outerXml)
        : base(outerXml)
    {
    }

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Degree>(deep);

}
/// <summary>
/// Defines the OfficeMathArgumentType class.
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ArgumentProperties &lt;m:argPr></description></item>
///<item><description>Accent &lt;m:acc></description></item>
///<item><description>Bar &lt;m:bar></description></item>
///<item><description>Box &lt;m:box></description></item>
///<item><description>BorderBox &lt;m:borderBox></description></item>
///<item><description>Delimiter &lt;m:d></description></item>
///<item><description>EquationArray &lt;m:eqArr></description></item>
///<item><description>Fraction &lt;m:f></description></item>
///<item><description>MathFunction &lt;m:func></description></item>
///<item><description>GroupChar &lt;m:groupChr></description></item>
///<item><description>LimitLower &lt;m:limLow></description></item>
///<item><description>LimitUpper &lt;m:limUpp></description></item>
///<item><description>Matrix &lt;m:m></description></item>
///<item><description>Nary &lt;m:nary></description></item>
///<item><description>Phantom &lt;m:phant></description></item>
///<item><description>Radical &lt;m:rad></description></item>
///<item><description>PreSubSuper &lt;m:sPre></description></item>
///<item><description>Subscript &lt;m:sSub></description></item>
///<item><description>SubSuperscript &lt;m:sSubSup></description></item>
///<item><description>Superscript &lt;m:sSup></description></item>
///<item><description>Run &lt;m:r></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun &lt;w:customXml></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.SimpleField &lt;w:fldSimple></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.Hyperlink &lt;w:hyperlink></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.SdtRun &lt;w:sdt></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.ProofError &lt;w:proofErr></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.PermStart &lt;w:permStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.PermEnd &lt;w:permEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkStart &lt;w:bookmarkStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd &lt;w:bookmarkEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart &lt;w:commentRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd &lt;w:commentRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart &lt;w:moveFromRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd &lt;w:moveFromRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart &lt;w:moveToRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd &lt;w:moveToRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart &lt;w:customXmlInsRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd &lt;w:customXmlInsRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart &lt;w:customXmlDelRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd &lt;w:customXmlDelRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart &lt;w:customXmlMoveFromRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd &lt;w:customXmlMoveFromRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart &lt;w:customXmlMoveToRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd &lt;w:customXmlMoveToRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart &lt;w14:customXmlConflictInsRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd &lt;w14:customXmlConflictInsRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart &lt;w14:customXmlConflictDelRangeStart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd &lt;w14:customXmlConflictDelRangeEnd></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.InsertedRun &lt;w:ins></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.DeletedRun &lt;w:del></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveFromRun &lt;w:moveFrom></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.MoveToRun &lt;w:moveTo></description></item>
///<item><description>DocumentFormat.OpenXml.Wordprocessing.ContentPart &lt;w:contentPart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion &lt;w14:conflictIns></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion &lt;w14:conflictDel></description></item>
///<item><description>Paragraph &lt;m:oMathPara></description></item>
///<item><description>OfficeMath &lt;m:oMath></description></item>
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ArgumentProperties))]
    [ChildElementInfo(typeof(Accent))]
    [ChildElementInfo(typeof(Bar))]
    [ChildElementInfo(typeof(Box))]
    [ChildElementInfo(typeof(BorderBox))]
    [ChildElementInfo(typeof(Delimiter))]
    [ChildElementInfo(typeof(EquationArray))]
    [ChildElementInfo(typeof(Fraction))]
    [ChildElementInfo(typeof(MathFunction))]
    [ChildElementInfo(typeof(GroupChar))]
    [ChildElementInfo(typeof(LimitLower))]
    [ChildElementInfo(typeof(LimitUpper))]
    [ChildElementInfo(typeof(Matrix))]
    [ChildElementInfo(typeof(Nary))]
    [ChildElementInfo(typeof(Phantom))]
    [ChildElementInfo(typeof(Radical))]
    [ChildElementInfo(typeof(PreSubSuper))]
    [ChildElementInfo(typeof(Subscript))]
    [ChildElementInfo(typeof(SubSuperscript))]
    [ChildElementInfo(typeof(Superscript))]
    [ChildElementInfo(typeof(Run))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.SimpleField))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.Hyperlink))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.SdtRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.ProofError))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.PermStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.PermEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.InsertedRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.ContentPart), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(Paragraph))]
    [ChildElementInfo(typeof(OfficeMath))]
    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class OfficeMathArgumentType : OpenXmlCompositeElement
{
        
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "argPr" == name)
    return new ArgumentProperties();
    
if( 21 == namespaceId && "acc" == name)
    return new Accent();
    
if( 21 == namespaceId && "bar" == name)
    return new Bar();
    
if( 21 == namespaceId && "box" == name)
    return new Box();
    
if( 21 == namespaceId && "borderBox" == name)
    return new BorderBox();
    
if( 21 == namespaceId && "d" == name)
    return new Delimiter();
    
if( 21 == namespaceId && "eqArr" == name)
    return new EquationArray();
    
if( 21 == namespaceId && "f" == name)
    return new Fraction();
    
if( 21 == namespaceId && "func" == name)
    return new MathFunction();
    
if( 21 == namespaceId && "groupChr" == name)
    return new GroupChar();
    
if( 21 == namespaceId && "limLow" == name)
    return new LimitLower();
    
if( 21 == namespaceId && "limUpp" == name)
    return new LimitUpper();
    
if( 21 == namespaceId && "m" == name)
    return new Matrix();
    
if( 21 == namespaceId && "nary" == name)
    return new Nary();
    
if( 21 == namespaceId && "phant" == name)
    return new Phantom();
    
if( 21 == namespaceId && "rad" == name)
    return new Radical();
    
if( 21 == namespaceId && "sPre" == name)
    return new PreSubSuper();
    
if( 21 == namespaceId && "sSub" == name)
    return new Subscript();
    
if( 21 == namespaceId && "sSubSup" == name)
    return new SubSuperscript();
    
if( 21 == namespaceId && "sSup" == name)
    return new Superscript();
    
if( 21 == namespaceId && "r" == name)
    return new Run();
    
if( 23 == namespaceId && "customXml" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CustomXmlRun();
    
if( 23 == namespaceId && "fldSimple" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.SimpleField();
    
if( 23 == namespaceId && "hyperlink" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.Hyperlink();
    
if( 23 == namespaceId && "sdt" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.SdtRun();
    
if( 23 == namespaceId && "proofErr" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.ProofError();
    
if( 23 == namespaceId && "permStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.PermStart();
    
if( 23 == namespaceId && "permEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.PermEnd();
    
if( 23 == namespaceId && "bookmarkStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.BookmarkStart();
    
if( 23 == namespaceId && "bookmarkEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.BookmarkEnd();
    
if( 23 == namespaceId && "commentRangeStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CommentRangeStart();
    
if( 23 == namespaceId && "commentRangeEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CommentRangeEnd();
    
if( 23 == namespaceId && "moveFromRangeStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeStart();
    
if( 23 == namespaceId && "moveFromRangeEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.MoveFromRangeEnd();
    
if( 23 == namespaceId && "moveToRangeStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.MoveToRangeStart();
    
if( 23 == namespaceId && "moveToRangeEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.MoveToRangeEnd();
    
if( 23 == namespaceId && "customXmlInsRangeStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeStart();
    
if( 23 == namespaceId && "customXmlInsRangeEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CustomXmlInsRangeEnd();
    
if( 23 == namespaceId && "customXmlDelRangeStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeStart();
    
if( 23 == namespaceId && "customXmlDelRangeEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CustomXmlDelRangeEnd();
    
if( 23 == namespaceId && "customXmlMoveFromRangeStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeStart();
    
if( 23 == namespaceId && "customXmlMoveFromRangeEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveFromRangeEnd();
    
if( 23 == namespaceId && "customXmlMoveToRangeStart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeStart();
    
if( 23 == namespaceId && "customXmlMoveToRangeEnd" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.CustomXmlMoveToRangeEnd();
    
if( 52 == namespaceId && "customXmlConflictInsRangeStart" == name)
    return new DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart();
    
if( 52 == namespaceId && "customXmlConflictInsRangeEnd" == name)
    return new DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd();
    
if( 52 == namespaceId && "customXmlConflictDelRangeStart" == name)
    return new DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart();
    
if( 52 == namespaceId && "customXmlConflictDelRangeEnd" == name)
    return new DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd();
    
if( 23 == namespaceId && "ins" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.InsertedRun();
    
if( 23 == namespaceId && "del" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.DeletedRun();
    
if( 23 == namespaceId && "moveFrom" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.MoveFromRun();
    
if( 23 == namespaceId && "moveTo" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.MoveToRun();
    
if( 23 == namespaceId && "contentPart" == name)
    return new DocumentFormat.OpenXml.Wordprocessing.ContentPart();
    
if( 52 == namespaceId && "conflictIns" == name)
    return new DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion();
    
if( 52 == namespaceId && "conflictDel" == name)
    return new DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion();
    
if( 21 == namespaceId && "oMathPara" == name)
    return new Paragraph();
    
if( 21 == namespaceId && "oMath" == name)
    return new OfficeMath();
    
if( 21 == namespaceId && "ctrlPr" == name)
    return new ControlProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "argPr","acc","bar","box","borderBox","d","eqArr","f","func","groupChr","limLow","limUpp","m","nary","phant","rad","sPre","sSub","sSubSup","sSup","r","customXml","fldSimple","hyperlink","sdt","proofErr","permStart","permEnd","bookmarkStart","bookmarkEnd","commentRangeStart","commentRangeEnd","moveFromRangeStart","moveFromRangeEnd","moveToRangeStart","moveToRangeEnd","customXmlInsRangeStart","customXmlInsRangeEnd","customXmlDelRangeStart","customXmlDelRangeEnd","customXmlMoveFromRangeStart","customXmlMoveFromRangeEnd","customXmlMoveToRangeStart","customXmlMoveToRangeEnd","customXmlConflictInsRangeStart","customXmlConflictInsRangeEnd","customXmlConflictDelRangeStart","customXmlConflictDelRangeEnd","ins","del","moveFrom","moveTo","contentPart","conflictIns","conflictDel","oMathPara","oMath","ctrlPr" };
    private static readonly byte[] eleNamespaceIds = { 21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,21,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,23,52,52,52,52,23,23,23,23,23,52,52,21,21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Argument Properties.</para>
    /// <para> Represents the following element tag in the schema: m:argPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public ArgumentProperties ArgumentProperties
    {
        get => GetElement<ArgumentProperties>(0);
        set => SetElement(0, value);
    }


    
    /// <summary>
    /// Initializes a new instance of the OfficeMathArgumentType class.
    /// </summary>
    protected OfficeMathArgumentType(){}
    
        /// <summary>
    ///Initializes a new instance of the OfficeMathArgumentType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected OfficeMathArgumentType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the OfficeMathArgumentType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    protected OfficeMathArgumentType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the OfficeMathArgumentType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    protected OfficeMathArgumentType(string outerXml)
        : base(outerXml)
    {
    }

    
}
/// <summary>
/// <para>Position (Bar).</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:pos.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Position : TopBottomType
{
    internal const int ElementTypeIdConst = 10940;
    /// <inheritdoc/>
    public override string LocalName => "pos";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Position class.
    /// </summary>
    public Position():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Position>(deep);

}
/// <summary>
/// <para>Vertical Justification.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:vertJc.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class VerticalJustification : TopBottomType
{
    internal const int ElementTypeIdConst = 10973;
    /// <inheritdoc/>
    public override string LocalName => "vertJc";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the VerticalJustification class.
    /// </summary>
    public VerticalJustification():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<VerticalJustification>(deep);

}
/// <summary>
/// Defines the TopBottomType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class TopBottomType : OpenXmlLeafElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Math.VerticalJustificationValues>>(21, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public EnumValue<DocumentFormat.OpenXml.Math.VerticalJustificationValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Math.VerticalJustificationValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the TopBottomType class.
    /// </summary>
    protected TopBottomType(){}
    
    
    
}
/// <summary>
/// <para>Bar Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:barPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Position &lt;m:pos></description></item>
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Position))]
    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class BarProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10941;
    /// <inheritdoc/>
    public override string LocalName => "barPr";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the BarProperties class.
    /// </summary>
    public BarProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the BarProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BarProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BarProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BarProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BarProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BarProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "pos" == name)
    return new Position();
    
if( 21 == namespaceId && "ctrlPr" == name)
    return new ControlProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "pos","ctrlPr" };
    private static readonly byte[] eleNamespaceIds = { 21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Position (Bar).</para>
    /// <para> Represents the following element tag in the schema: m:pos </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public Position Position
    {
        get => GetElement<Position>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> ControlProperties.</para>
    /// <para> Represents the following element tag in the schema: m:ctrlPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public ControlProperties ControlProperties
    {
        get => GetElement<ControlProperties>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BarProperties>(deep);

}
/// <summary>
/// <para>Box Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:boxPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>OperatorEmulator &lt;m:opEmu></description></item>
///<item><description>NoBreak &lt;m:noBreak></description></item>
///<item><description>Differential &lt;m:diff></description></item>
///<item><description>Break &lt;m:brk></description></item>
///<item><description>Alignment &lt;m:aln></description></item>
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(OperatorEmulator))]
    [ChildElementInfo(typeof(NoBreak))]
    [ChildElementInfo(typeof(Differential))]
    [ChildElementInfo(typeof(Break))]
    [ChildElementInfo(typeof(Alignment))]
    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class BoxProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10945;
    /// <inheritdoc/>
    public override string LocalName => "boxPr";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the BoxProperties class.
    /// </summary>
    public BoxProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the BoxProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BoxProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BoxProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BoxProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BoxProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BoxProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "opEmu" == name)
    return new OperatorEmulator();
    
if( 21 == namespaceId && "noBreak" == name)
    return new NoBreak();
    
if( 21 == namespaceId && "diff" == name)
    return new Differential();
    
if( 21 == namespaceId && "brk" == name)
    return new Break();
    
if( 21 == namespaceId && "aln" == name)
    return new Alignment();
    
if( 21 == namespaceId && "ctrlPr" == name)
    return new ControlProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "opEmu","noBreak","diff","brk","aln","ctrlPr" };
    private static readonly byte[] eleNamespaceIds = { 21,21,21,21,21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Operator Emulator.</para>
    /// <para> Represents the following element tag in the schema: m:opEmu </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public OperatorEmulator OperatorEmulator
    {
        get => GetElement<OperatorEmulator>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> No Break.</para>
    /// <para> Represents the following element tag in the schema: m:noBreak </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public NoBreak NoBreak
    {
        get => GetElement<NoBreak>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Differential.</para>
    /// <para> Represents the following element tag in the schema: m:diff </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public Differential Differential
    {
        get => GetElement<Differential>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Break.</para>
    /// <para> Represents the following element tag in the schema: m:brk </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public Break Break
    {
        get => GetElement<Break>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> Alignment.</para>
    /// <para> Represents the following element tag in the schema: m:aln </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public Alignment Alignment
    {
        get => GetElement<Alignment>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> ControlProperties.</para>
    /// <para> Represents the following element tag in the schema: m:ctrlPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public ControlProperties ControlProperties
    {
        get => GetElement<ControlProperties>(5);
        set => SetElement(5, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BoxProperties>(deep);

}
/// <summary>
/// <para>Border Box Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:borderBoxPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>HideTop &lt;m:hideTop></description></item>
///<item><description>HideBottom &lt;m:hideBot></description></item>
///<item><description>HideLeft &lt;m:hideLeft></description></item>
///<item><description>HideRight &lt;m:hideRight></description></item>
///<item><description>StrikeHorizontal &lt;m:strikeH></description></item>
///<item><description>StrikeVertical &lt;m:strikeV></description></item>
///<item><description>StrikeBottomLeftToTopRight &lt;m:strikeBLTR></description></item>
///<item><description>StrikeTopLeftToBottomRight &lt;m:strikeTLBR></description></item>
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(HideTop))]
    [ChildElementInfo(typeof(HideBottom))]
    [ChildElementInfo(typeof(HideLeft))]
    [ChildElementInfo(typeof(HideRight))]
    [ChildElementInfo(typeof(StrikeHorizontal))]
    [ChildElementInfo(typeof(StrikeVertical))]
    [ChildElementInfo(typeof(StrikeBottomLeftToTopRight))]
    [ChildElementInfo(typeof(StrikeTopLeftToBottomRight))]
    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class BorderBoxProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10954;
    /// <inheritdoc/>
    public override string LocalName => "borderBoxPr";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the BorderBoxProperties class.
    /// </summary>
    public BorderBoxProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the BorderBoxProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BorderBoxProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BorderBoxProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BorderBoxProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BorderBoxProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BorderBoxProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "hideTop" == name)
    return new HideTop();
    
if( 21 == namespaceId && "hideBot" == name)
    return new HideBottom();
    
if( 21 == namespaceId && "hideLeft" == name)
    return new HideLeft();
    
if( 21 == namespaceId && "hideRight" == name)
    return new HideRight();
    
if( 21 == namespaceId && "strikeH" == name)
    return new StrikeHorizontal();
    
if( 21 == namespaceId && "strikeV" == name)
    return new StrikeVertical();
    
if( 21 == namespaceId && "strikeBLTR" == name)
    return new StrikeBottomLeftToTopRight();
    
if( 21 == namespaceId && "strikeTLBR" == name)
    return new StrikeTopLeftToBottomRight();
    
if( 21 == namespaceId && "ctrlPr" == name)
    return new ControlProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "hideTop","hideBot","hideLeft","hideRight","strikeH","strikeV","strikeBLTR","strikeTLBR","ctrlPr" };
    private static readonly byte[] eleNamespaceIds = { 21,21,21,21,21,21,21,21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Hide Top Edge.</para>
    /// <para> Represents the following element tag in the schema: m:hideTop </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public HideTop HideTop
    {
        get => GetElement<HideTop>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Hide Bottom Edge.</para>
    /// <para> Represents the following element tag in the schema: m:hideBot </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public HideBottom HideBottom
    {
        get => GetElement<HideBottom>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Hide Left Edge.</para>
    /// <para> Represents the following element tag in the schema: m:hideLeft </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public HideLeft HideLeft
    {
        get => GetElement<HideLeft>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Hide Right Edge.</para>
    /// <para> Represents the following element tag in the schema: m:hideRight </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public HideRight HideRight
    {
        get => GetElement<HideRight>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> Border Box Strikethrough Horizontal.</para>
    /// <para> Represents the following element tag in the schema: m:strikeH </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public StrikeHorizontal StrikeHorizontal
    {
        get => GetElement<StrikeHorizontal>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> Border Box Strikethrough Vertical.</para>
    /// <para> Represents the following element tag in the schema: m:strikeV </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public StrikeVertical StrikeVertical
    {
        get => GetElement<StrikeVertical>(5);
        set => SetElement(5, value);
    }
    /// <summary>
    /// <para> Border Box Strikethrough Bottom-Left to Top-Right.</para>
    /// <para> Represents the following element tag in the schema: m:strikeBLTR </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public StrikeBottomLeftToTopRight StrikeBottomLeftToTopRight
    {
        get => GetElement<StrikeBottomLeftToTopRight>(6);
        set => SetElement(6, value);
    }
    /// <summary>
    /// <para> Border Box Strikethrough Top-Left to Bottom-Right.</para>
    /// <para> Represents the following element tag in the schema: m:strikeTLBR </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public StrikeTopLeftToBottomRight StrikeTopLeftToBottomRight
    {
        get => GetElement<StrikeTopLeftToBottomRight>(7);
        set => SetElement(7, value);
    }
    /// <summary>
    /// <para> ControlProperties.</para>
    /// <para> Represents the following element tag in the schema: m:ctrlPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public ControlProperties ControlProperties
    {
        get => GetElement<ControlProperties>(8);
        set => SetElement(8, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BorderBoxProperties>(deep);

}
/// <summary>
/// <para>Shape (Delimiters).</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:shp.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Shape : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10959;
    /// <inheritdoc/>
    public override string LocalName => "shp";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Math.ShapeDelimiterValues>>(21, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public EnumValue<DocumentFormat.OpenXml.Math.ShapeDelimiterValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Math.ShapeDelimiterValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Shape class.
    /// </summary>
    public Shape():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Shape>(deep);

}
/// <summary>
/// <para>Delimiter Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:dPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BeginChar &lt;m:begChr></description></item>
///<item><description>SeparatorChar &lt;m:sepChr></description></item>
///<item><description>EndChar &lt;m:endChr></description></item>
///<item><description>GrowOperators &lt;m:grow></description></item>
///<item><description>Shape &lt;m:shp></description></item>
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(BeginChar))]
    [ChildElementInfo(typeof(SeparatorChar))]
    [ChildElementInfo(typeof(EndChar))]
    [ChildElementInfo(typeof(GrowOperators))]
    [ChildElementInfo(typeof(Shape))]
    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DelimiterProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10960;
    /// <inheritdoc/>
    public override string LocalName => "dPr";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the DelimiterProperties class.
    /// </summary>
    public DelimiterProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the DelimiterProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DelimiterProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DelimiterProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DelimiterProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DelimiterProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DelimiterProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "begChr" == name)
    return new BeginChar();
    
if( 21 == namespaceId && "sepChr" == name)
    return new SeparatorChar();
    
if( 21 == namespaceId && "endChr" == name)
    return new EndChar();
    
if( 21 == namespaceId && "grow" == name)
    return new GrowOperators();
    
if( 21 == namespaceId && "shp" == name)
    return new Shape();
    
if( 21 == namespaceId && "ctrlPr" == name)
    return new ControlProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "begChr","sepChr","endChr","grow","shp","ctrlPr" };
    private static readonly byte[] eleNamespaceIds = { 21,21,21,21,21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Delimiter Beginning Character.</para>
    /// <para> Represents the following element tag in the schema: m:begChr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public BeginChar BeginChar
    {
        get => GetElement<BeginChar>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Delimiter Separator Character.</para>
    /// <para> Represents the following element tag in the schema: m:sepChr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public SeparatorChar SeparatorChar
    {
        get => GetElement<SeparatorChar>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Delimiter Ending Character.</para>
    /// <para> Represents the following element tag in the schema: m:endChr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public EndChar EndChar
    {
        get => GetElement<EndChar>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Delimiter Grow.</para>
    /// <para> Represents the following element tag in the schema: m:grow </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public GrowOperators GrowOperators
    {
        get => GetElement<GrowOperators>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> Shape (Delimiters).</para>
    /// <para> Represents the following element tag in the schema: m:shp </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public Shape Shape
    {
        get => GetElement<Shape>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> ControlProperties.</para>
    /// <para> Represents the following element tag in the schema: m:ctrlPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public ControlProperties ControlProperties
    {
        get => GetElement<ControlProperties>(5);
        set => SetElement(5, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DelimiterProperties>(deep);

}
/// <summary>
/// <para>Equation Array Base Justification.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:baseJc.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class BaseJustification : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10961;
    /// <inheritdoc/>
    public override string LocalName => "baseJc";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Math.VerticalAlignmentValues>>(21, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public EnumValue<DocumentFormat.OpenXml.Math.VerticalAlignmentValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Math.VerticalAlignmentValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BaseJustification class.
    /// </summary>
    public BaseJustification():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BaseJustification>(deep);

}
/// <summary>
/// <para>Row Spacing Rule.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:rSpRule.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class RowSpacingRule : SpacingRuleType
{
    internal const int ElementTypeIdConst = 10964;
    /// <inheritdoc/>
    public override string LocalName => "rSpRule";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the RowSpacingRule class.
    /// </summary>
    public RowSpacingRule():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RowSpacingRule>(deep);

}
/// <summary>
/// <para>Matrix Column Gap Rule.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:cGpRule.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ColumnGapRule : SpacingRuleType
{
    internal const int ElementTypeIdConst = 10983;
    /// <inheritdoc/>
    public override string LocalName => "cGpRule";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the ColumnGapRule class.
    /// </summary>
    public ColumnGapRule():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColumnGapRule>(deep);

}
/// <summary>
/// Defines the SpacingRuleType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class SpacingRuleType : OpenXmlLeafElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<IntegerValue>(21, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public IntegerValue Val
    {
        get { return (IntegerValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the SpacingRuleType class.
    /// </summary>
    protected SpacingRuleType(){}
    
    
    
}
/// <summary>
/// <para>Row Spacing (Equation Array).</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:rSp.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class RowSpacing : UnsignedShortType
{
    internal const int ElementTypeIdConst = 10965;
    /// <inheritdoc/>
    public override string LocalName => "rSp";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the RowSpacing class.
    /// </summary>
    public RowSpacing():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RowSpacing>(deep);

}
/// <summary>
/// <para>Matrix Column Gap.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:cGp.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ColumnGap : UnsignedShortType
{
    internal const int ElementTypeIdConst = 10985;
    /// <inheritdoc/>
    public override string LocalName => "cGp";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the ColumnGap class.
    /// </summary>
    public ColumnGap():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColumnGap>(deep);

}
/// <summary>
/// Defines the UnsignedShortType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class UnsignedShortType : OpenXmlLeafElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt16Value>(21, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public UInt16Value Val
    {
        get { return (UInt16Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the UnsignedShortType class.
    /// </summary>
    protected UnsignedShortType(){}
    
    
    
}
/// <summary>
/// <para>Equation Array Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:eqArrPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BaseJustification &lt;m:baseJc></description></item>
///<item><description>MaxDistribution &lt;m:maxDist></description></item>
///<item><description>ObjectDistribution &lt;m:objDist></description></item>
///<item><description>RowSpacingRule &lt;m:rSpRule></description></item>
///<item><description>RowSpacing &lt;m:rSp></description></item>
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(BaseJustification))]
    [ChildElementInfo(typeof(MaxDistribution))]
    [ChildElementInfo(typeof(ObjectDistribution))]
    [ChildElementInfo(typeof(RowSpacingRule))]
    [ChildElementInfo(typeof(RowSpacing))]
    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class EquationArrayProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10966;
    /// <inheritdoc/>
    public override string LocalName => "eqArrPr";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the EquationArrayProperties class.
    /// </summary>
    public EquationArrayProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the EquationArrayProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public EquationArrayProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the EquationArrayProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public EquationArrayProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the EquationArrayProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public EquationArrayProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "baseJc" == name)
    return new BaseJustification();
    
if( 21 == namespaceId && "maxDist" == name)
    return new MaxDistribution();
    
if( 21 == namespaceId && "objDist" == name)
    return new ObjectDistribution();
    
if( 21 == namespaceId && "rSpRule" == name)
    return new RowSpacingRule();
    
if( 21 == namespaceId && "rSp" == name)
    return new RowSpacing();
    
if( 21 == namespaceId && "ctrlPr" == name)
    return new ControlProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "baseJc","maxDist","objDist","rSpRule","rSp","ctrlPr" };
    private static readonly byte[] eleNamespaceIds = { 21,21,21,21,21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Equation Array Base Justification.</para>
    /// <para> Represents the following element tag in the schema: m:baseJc </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public BaseJustification BaseJustification
    {
        get => GetElement<BaseJustification>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Maximum Distribution.</para>
    /// <para> Represents the following element tag in the schema: m:maxDist </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public MaxDistribution MaxDistribution
    {
        get => GetElement<MaxDistribution>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Object Distribution.</para>
    /// <para> Represents the following element tag in the schema: m:objDist </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public ObjectDistribution ObjectDistribution
    {
        get => GetElement<ObjectDistribution>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Row Spacing Rule.</para>
    /// <para> Represents the following element tag in the schema: m:rSpRule </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public RowSpacingRule RowSpacingRule
    {
        get => GetElement<RowSpacingRule>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> Row Spacing (Equation Array).</para>
    /// <para> Represents the following element tag in the schema: m:rSp </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public RowSpacing RowSpacing
    {
        get => GetElement<RowSpacing>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> ControlProperties.</para>
    /// <para> Represents the following element tag in the schema: m:ctrlPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public ControlProperties ControlProperties
    {
        get => GetElement<ControlProperties>(5);
        set => SetElement(5, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<EquationArrayProperties>(deep);

}
/// <summary>
/// <para>Fraction type.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:type.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class FractionType : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10967;
    /// <inheritdoc/>
    public override string LocalName => "type";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Math.FractionTypeValues>>(21, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public EnumValue<DocumentFormat.OpenXml.Math.FractionTypeValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Math.FractionTypeValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the FractionType class.
    /// </summary>
    public FractionType():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FractionType>(deep);

}
/// <summary>
/// <para>Fraction Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:fPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>FractionType &lt;m:type></description></item>
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(FractionType))]
    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class FractionProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10968;
    /// <inheritdoc/>
    public override string LocalName => "fPr";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the FractionProperties class.
    /// </summary>
    public FractionProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the FractionProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FractionProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the FractionProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FractionProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the FractionProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public FractionProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "type" == name)
    return new FractionType();
    
if( 21 == namespaceId && "ctrlPr" == name)
    return new ControlProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "type","ctrlPr" };
    private static readonly byte[] eleNamespaceIds = { 21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Fraction type.</para>
    /// <para> Represents the following element tag in the schema: m:type </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public FractionType FractionType
    {
        get => GetElement<FractionType>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> ControlProperties.</para>
    /// <para> Represents the following element tag in the schema: m:ctrlPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public ControlProperties ControlProperties
    {
        get => GetElement<ControlProperties>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FractionProperties>(deep);

}
/// <summary>
/// <para>Function Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:funcPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class FunctionProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10971;
    /// <inheritdoc/>
    public override string LocalName => "funcPr";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the FunctionProperties class.
    /// </summary>
    public FunctionProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the FunctionProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FunctionProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the FunctionProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public FunctionProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the FunctionProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public FunctionProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "ctrlPr" == name)
    return new ControlProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "ctrlPr" };
    private static readonly byte[] eleNamespaceIds = { 21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ControlProperties.</para>
    /// <para> Represents the following element tag in the schema: m:ctrlPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public ControlProperties ControlProperties
    {
        get => GetElement<ControlProperties>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<FunctionProperties>(deep);

}
/// <summary>
/// <para>Group-Character Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:groupChrPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>AccentChar &lt;m:chr></description></item>
///<item><description>Position &lt;m:pos></description></item>
///<item><description>VerticalJustification &lt;m:vertJc></description></item>
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(AccentChar))]
    [ChildElementInfo(typeof(Position))]
    [ChildElementInfo(typeof(VerticalJustification))]
    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class GroupCharProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10974;
    /// <inheritdoc/>
    public override string LocalName => "groupChrPr";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the GroupCharProperties class.
    /// </summary>
    public GroupCharProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the GroupCharProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GroupCharProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the GroupCharProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GroupCharProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the GroupCharProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public GroupCharProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "chr" == name)
    return new AccentChar();
    
if( 21 == namespaceId && "pos" == name)
    return new Position();
    
if( 21 == namespaceId && "vertJc" == name)
    return new VerticalJustification();
    
if( 21 == namespaceId && "ctrlPr" == name)
    return new ControlProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "chr","pos","vertJc","ctrlPr" };
    private static readonly byte[] eleNamespaceIds = { 21,21,21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Group Character (Grouping Character).</para>
    /// <para> Represents the following element tag in the schema: m:chr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public AccentChar AccentChar
    {
        get => GetElement<AccentChar>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Position (Group Character).</para>
    /// <para> Represents the following element tag in the schema: m:pos </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public Position Position
    {
        get => GetElement<Position>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Vertical Justification.</para>
    /// <para> Represents the following element tag in the schema: m:vertJc </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public VerticalJustification VerticalJustification
    {
        get => GetElement<VerticalJustification>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> ControlProperties.</para>
    /// <para> Represents the following element tag in the schema: m:ctrlPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public ControlProperties ControlProperties
    {
        get => GetElement<ControlProperties>(3);
        set => SetElement(3, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupCharProperties>(deep);

}
/// <summary>
/// <para>Lower Limit Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:limLowPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class LimitLowerProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10975;
    /// <inheritdoc/>
    public override string LocalName => "limLowPr";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the LimitLowerProperties class.
    /// </summary>
    public LimitLowerProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the LimitLowerProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LimitLowerProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LimitLowerProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LimitLowerProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LimitLowerProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public LimitLowerProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "ctrlPr" == name)
    return new ControlProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "ctrlPr" };
    private static readonly byte[] eleNamespaceIds = { 21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ControlProperties.</para>
    /// <para> Represents the following element tag in the schema: m:ctrlPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public ControlProperties ControlProperties
    {
        get => GetElement<ControlProperties>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LimitLowerProperties>(deep);

}
/// <summary>
/// <para>Upper Limit Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:limUppPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class LimitUpperProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10977;
    /// <inheritdoc/>
    public override string LocalName => "limUppPr";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the LimitUpperProperties class.
    /// </summary>
    public LimitUpperProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the LimitUpperProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LimitUpperProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LimitUpperProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LimitUpperProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LimitUpperProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public LimitUpperProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "ctrlPr" == name)
    return new ControlProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "ctrlPr" };
    private static readonly byte[] eleNamespaceIds = { 21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ControlProperties.</para>
    /// <para> Represents the following element tag in the schema: m:ctrlPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public ControlProperties ControlProperties
    {
        get => GetElement<ControlProperties>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LimitUpperProperties>(deep);

}
/// <summary>
/// <para>Matrix Column Count.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:count.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class MatrixColumnCount : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10978;
    /// <inheritdoc/>
    public override string LocalName => "count";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<IntegerValue>(21, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public IntegerValue Val
    {
        get { return (IntegerValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the MatrixColumnCount class.
    /// </summary>
    public MatrixColumnCount():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MatrixColumnCount>(deep);

}
/// <summary>
/// <para>Matrix Column Justification.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:mcJc.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class MatrixColumnJustification : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10979;
    /// <inheritdoc/>
    public override string LocalName => "mcJc";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Math.HorizontalAlignmentValues>>(21, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public EnumValue<DocumentFormat.OpenXml.Math.HorizontalAlignmentValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Math.HorizontalAlignmentValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the MatrixColumnJustification class.
    /// </summary>
    public MatrixColumnJustification():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MatrixColumnJustification>(deep);

}
/// <summary>
/// <para>Matrix Column Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:mcPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>MatrixColumnCount &lt;m:count></description></item>
///<item><description>MatrixColumnJustification &lt;m:mcJc></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(MatrixColumnCount))]
    [ChildElementInfo(typeof(MatrixColumnJustification))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class MatrixColumnProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10980;
    /// <inheritdoc/>
    public override string LocalName => "mcPr";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the MatrixColumnProperties class.
    /// </summary>
    public MatrixColumnProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the MatrixColumnProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MatrixColumnProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the MatrixColumnProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MatrixColumnProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the MatrixColumnProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MatrixColumnProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "count" == name)
    return new MatrixColumnCount();
    
if( 21 == namespaceId && "mcJc" == name)
    return new MatrixColumnJustification();
    

    return null;
}

        private static readonly string[] eleTagNames = { "count","mcJc" };
    private static readonly byte[] eleNamespaceIds = { 21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Matrix Column Count.</para>
    /// <para> Represents the following element tag in the schema: m:count </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public MatrixColumnCount MatrixColumnCount
    {
        get => GetElement<MatrixColumnCount>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Matrix Column Justification.</para>
    /// <para> Represents the following element tag in the schema: m:mcJc </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public MatrixColumnJustification MatrixColumnJustification
    {
        get => GetElement<MatrixColumnJustification>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MatrixColumnProperties>(deep);

}
/// <summary>
/// <para>Matrix Column.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:mc.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>MatrixColumnProperties &lt;m:mcPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(MatrixColumnProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class MatrixColumn : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10981;
    /// <inheritdoc/>
    public override string LocalName => "mc";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the MatrixColumn class.
    /// </summary>
    public MatrixColumn():base(){}
    
        /// <summary>
    ///Initializes a new instance of the MatrixColumn class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MatrixColumn(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the MatrixColumn class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MatrixColumn(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the MatrixColumn class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MatrixColumn(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "mcPr" == name)
    return new MatrixColumnProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "mcPr" };
    private static readonly byte[] eleNamespaceIds = { 21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Matrix Column Properties.</para>
    /// <para> Represents the following element tag in the schema: m:mcPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public MatrixColumnProperties MatrixColumnProperties
    {
        get => GetElement<MatrixColumnProperties>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MatrixColumn>(deep);

}
/// <summary>
/// <para>Matrix Column Spacing.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:cSp.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ColumnSpacing : TwipsMeasureType
{
    internal const int ElementTypeIdConst = 10984;
    /// <inheritdoc/>
    public override string LocalName => "cSp";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the ColumnSpacing class.
    /// </summary>
    public ColumnSpacing():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColumnSpacing>(deep);

}
/// <summary>
/// <para>Left Margin.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:lMargin.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class LeftMargin : TwipsMeasureType
{
    internal const int ElementTypeIdConst = 11017;
    /// <inheritdoc/>
    public override string LocalName => "lMargin";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the LeftMargin class.
    /// </summary>
    public LeftMargin():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LeftMargin>(deep);

}
/// <summary>
/// <para>Right Margin.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:rMargin.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class RightMargin : TwipsMeasureType
{
    internal const int ElementTypeIdConst = 11018;
    /// <inheritdoc/>
    public override string LocalName => "rMargin";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the RightMargin class.
    /// </summary>
    public RightMargin():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RightMargin>(deep);

}
/// <summary>
/// <para>Pre-Equation Spacing.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:preSp.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class PreSpacing : TwipsMeasureType
{
    internal const int ElementTypeIdConst = 11020;
    /// <inheritdoc/>
    public override string LocalName => "preSp";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the PreSpacing class.
    /// </summary>
    public PreSpacing():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PreSpacing>(deep);

}
/// <summary>
/// <para>Post-Equation Spacing.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:postSp.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class PostSpacing : TwipsMeasureType
{
    internal const int ElementTypeIdConst = 11021;
    /// <inheritdoc/>
    public override string LocalName => "postSp";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the PostSpacing class.
    /// </summary>
    public PostSpacing():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PostSpacing>(deep);

}
/// <summary>
/// <para>Inter-Equation Spacing.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:interSp.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class InterSpacing : TwipsMeasureType
{
    internal const int ElementTypeIdConst = 11022;
    /// <inheritdoc/>
    public override string LocalName => "interSp";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the InterSpacing class.
    /// </summary>
    public InterSpacing():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<InterSpacing>(deep);

}
/// <summary>
/// <para>Intra-Equation Spacing.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:intraSp.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class IntraSpacing : TwipsMeasureType
{
    internal const int ElementTypeIdConst = 11023;
    /// <inheritdoc/>
    public override string LocalName => "intraSp";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the IntraSpacing class.
    /// </summary>
    public IntraSpacing():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<IntraSpacing>(deep);

}
/// <summary>
/// <para>Wrap Indent.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:wrapIndent.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class WrapIndent : TwipsMeasureType
{
    internal const int ElementTypeIdConst = 11024;
    /// <inheritdoc/>
    public override string LocalName => "wrapIndent";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the WrapIndent class.
    /// </summary>
    public WrapIndent():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<WrapIndent>(deep);

}
/// <summary>
/// Defines the TwipsMeasureType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class TwipsMeasureType : OpenXmlLeafElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<UInt32Value>(21, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public UInt32Value Val
    {
        get { return (UInt32Value)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the TwipsMeasureType class.
    /// </summary>
    protected TwipsMeasureType(){}
    
    
    
}
/// <summary>
/// <para>Matrix Columns.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:mcs.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>MatrixColumn &lt;m:mc></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(MatrixColumn))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class MatrixColumns : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10986;
    /// <inheritdoc/>
    public override string LocalName => "mcs";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the MatrixColumns class.
    /// </summary>
    public MatrixColumns():base(){}
    
        /// <summary>
    ///Initializes a new instance of the MatrixColumns class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MatrixColumns(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the MatrixColumns class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MatrixColumns(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the MatrixColumns class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MatrixColumns(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "mc" == name)
    return new MatrixColumn();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MatrixColumns>(deep);

}
/// <summary>
/// <para>Matrix Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:mPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BaseJustification &lt;m:baseJc></description></item>
///<item><description>HidePlaceholder &lt;m:plcHide></description></item>
///<item><description>RowSpacingRule &lt;m:rSpRule></description></item>
///<item><description>ColumnGapRule &lt;m:cGpRule></description></item>
///<item><description>RowSpacing &lt;m:rSp></description></item>
///<item><description>ColumnSpacing &lt;m:cSp></description></item>
///<item><description>ColumnGap &lt;m:cGp></description></item>
///<item><description>MatrixColumns &lt;m:mcs></description></item>
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(BaseJustification))]
    [ChildElementInfo(typeof(HidePlaceholder))]
    [ChildElementInfo(typeof(RowSpacingRule))]
    [ChildElementInfo(typeof(ColumnGapRule))]
    [ChildElementInfo(typeof(RowSpacing))]
    [ChildElementInfo(typeof(ColumnSpacing))]
    [ChildElementInfo(typeof(ColumnGap))]
    [ChildElementInfo(typeof(MatrixColumns))]
    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class MatrixProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10987;
    /// <inheritdoc/>
    public override string LocalName => "mPr";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the MatrixProperties class.
    /// </summary>
    public MatrixProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the MatrixProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MatrixProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the MatrixProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MatrixProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the MatrixProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MatrixProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "baseJc" == name)
    return new BaseJustification();
    
if( 21 == namespaceId && "plcHide" == name)
    return new HidePlaceholder();
    
if( 21 == namespaceId && "rSpRule" == name)
    return new RowSpacingRule();
    
if( 21 == namespaceId && "cGpRule" == name)
    return new ColumnGapRule();
    
if( 21 == namespaceId && "rSp" == name)
    return new RowSpacing();
    
if( 21 == namespaceId && "cSp" == name)
    return new ColumnSpacing();
    
if( 21 == namespaceId && "cGp" == name)
    return new ColumnGap();
    
if( 21 == namespaceId && "mcs" == name)
    return new MatrixColumns();
    
if( 21 == namespaceId && "ctrlPr" == name)
    return new ControlProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "baseJc","plcHide","rSpRule","cGpRule","rSp","cSp","cGp","mcs","ctrlPr" };
    private static readonly byte[] eleNamespaceIds = { 21,21,21,21,21,21,21,21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Matrix Base Justification.</para>
    /// <para> Represents the following element tag in the schema: m:baseJc </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public BaseJustification BaseJustification
    {
        get => GetElement<BaseJustification>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Hide Placeholders (Matrix).</para>
    /// <para> Represents the following element tag in the schema: m:plcHide </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public HidePlaceholder HidePlaceholder
    {
        get => GetElement<HidePlaceholder>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Row Spacing Rule.</para>
    /// <para> Represents the following element tag in the schema: m:rSpRule </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public RowSpacingRule RowSpacingRule
    {
        get => GetElement<RowSpacingRule>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Matrix Column Gap Rule.</para>
    /// <para> Represents the following element tag in the schema: m:cGpRule </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public ColumnGapRule ColumnGapRule
    {
        get => GetElement<ColumnGapRule>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> Row Spacing (Matrix).</para>
    /// <para> Represents the following element tag in the schema: m:rSp </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public RowSpacing RowSpacing
    {
        get => GetElement<RowSpacing>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> Matrix Column Spacing.</para>
    /// <para> Represents the following element tag in the schema: m:cSp </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public ColumnSpacing ColumnSpacing
    {
        get => GetElement<ColumnSpacing>(5);
        set => SetElement(5, value);
    }
    /// <summary>
    /// <para> Matrix Column Gap.</para>
    /// <para> Represents the following element tag in the schema: m:cGp </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public ColumnGap ColumnGap
    {
        get => GetElement<ColumnGap>(6);
        set => SetElement(6, value);
    }
    /// <summary>
    /// <para> Matrix Columns.</para>
    /// <para> Represents the following element tag in the schema: m:mcs </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public MatrixColumns MatrixColumns
    {
        get => GetElement<MatrixColumns>(7);
        set => SetElement(7, value);
    }
    /// <summary>
    /// <para> ControlProperties.</para>
    /// <para> Represents the following element tag in the schema: m:ctrlPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public ControlProperties ControlProperties
    {
        get => GetElement<ControlProperties>(8);
        set => SetElement(8, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MatrixProperties>(deep);

}
/// <summary>
/// <para>Matrix Row.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:mr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Base &lt;m:e></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Base))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class MatrixRow : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10988;
    /// <inheritdoc/>
    public override string LocalName => "mr";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the MatrixRow class.
    /// </summary>
    public MatrixRow():base(){}
    
        /// <summary>
    ///Initializes a new instance of the MatrixRow class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MatrixRow(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the MatrixRow class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MatrixRow(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the MatrixRow class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MatrixRow(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "e" == name)
    return new Base();
    

    return null;
}

    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MatrixRow>(deep);

}
/// <summary>
/// <para>n-ary Limit Location.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:limLoc.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class LimitLocation : LimitLocationType
{
    internal const int ElementTypeIdConst = 10989;
    /// <inheritdoc/>
    public override string LocalName => "limLoc";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the LimitLocation class.
    /// </summary>
    public LimitLocation():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LimitLocation>(deep);

}
/// <summary>
/// <para>Integral Limit Locations.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:intLim.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class IntegralLimitLocation : LimitLocationType
{
    internal const int ElementTypeIdConst = 11026;
    /// <inheritdoc/>
    public override string LocalName => "intLim";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the IntegralLimitLocation class.
    /// </summary>
    public IntegralLimitLocation():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<IntegralLimitLocation>(deep);

}
/// <summary>
/// <para>n-ary Limit Location.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:naryLim.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class NaryLimitLocation : LimitLocationType
{
    internal const int ElementTypeIdConst = 11027;
    /// <inheritdoc/>
    public override string LocalName => "naryLim";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the NaryLimitLocation class.
    /// </summary>
    public NaryLimitLocation():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NaryLimitLocation>(deep);

}
/// <summary>
/// Defines the LimitLocationType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class LimitLocationType : OpenXmlLeafElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Math.LimitLocationValues>>(21, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public EnumValue<DocumentFormat.OpenXml.Math.LimitLocationValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Math.LimitLocationValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the LimitLocationType class.
    /// </summary>
    protected LimitLocationType(){}
    
    
    
}
/// <summary>
/// <para>n-ary Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:naryPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>AccentChar &lt;m:chr></description></item>
///<item><description>LimitLocation &lt;m:limLoc></description></item>
///<item><description>GrowOperators &lt;m:grow></description></item>
///<item><description>HideSubArgument &lt;m:subHide></description></item>
///<item><description>HideSuperArgument &lt;m:supHide></description></item>
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(AccentChar))]
    [ChildElementInfo(typeof(LimitLocation))]
    [ChildElementInfo(typeof(GrowOperators))]
    [ChildElementInfo(typeof(HideSubArgument))]
    [ChildElementInfo(typeof(HideSuperArgument))]
    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class NaryProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10992;
    /// <inheritdoc/>
    public override string LocalName => "naryPr";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the NaryProperties class.
    /// </summary>
    public NaryProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the NaryProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NaryProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NaryProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NaryProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NaryProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NaryProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "chr" == name)
    return new AccentChar();
    
if( 21 == namespaceId && "limLoc" == name)
    return new LimitLocation();
    
if( 21 == namespaceId && "grow" == name)
    return new GrowOperators();
    
if( 21 == namespaceId && "subHide" == name)
    return new HideSubArgument();
    
if( 21 == namespaceId && "supHide" == name)
    return new HideSuperArgument();
    
if( 21 == namespaceId && "ctrlPr" == name)
    return new ControlProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "chr","limLoc","grow","subHide","supHide","ctrlPr" };
    private static readonly byte[] eleNamespaceIds = { 21,21,21,21,21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> n-ary Operator Character.</para>
    /// <para> Represents the following element tag in the schema: m:chr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public AccentChar AccentChar
    {
        get => GetElement<AccentChar>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> n-ary Limit Location.</para>
    /// <para> Represents the following element tag in the schema: m:limLoc </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public LimitLocation LimitLocation
    {
        get => GetElement<LimitLocation>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> n-ary Grow.</para>
    /// <para> Represents the following element tag in the schema: m:grow </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public GrowOperators GrowOperators
    {
        get => GetElement<GrowOperators>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Hide Subscript (n-ary).</para>
    /// <para> Represents the following element tag in the schema: m:subHide </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public HideSubArgument HideSubArgument
    {
        get => GetElement<HideSubArgument>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> Hide Superscript (n-ary).</para>
    /// <para> Represents the following element tag in the schema: m:supHide </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public HideSuperArgument HideSuperArgument
    {
        get => GetElement<HideSuperArgument>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> ControlProperties.</para>
    /// <para> Represents the following element tag in the schema: m:ctrlPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public ControlProperties ControlProperties
    {
        get => GetElement<ControlProperties>(5);
        set => SetElement(5, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NaryProperties>(deep);

}
/// <summary>
/// <para>Phantom Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:phantPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ShowPhantom &lt;m:show></description></item>
///<item><description>ZeroWidth &lt;m:zeroWid></description></item>
///<item><description>ZeroAscent &lt;m:zeroAsc></description></item>
///<item><description>ZeroDescent &lt;m:zeroDesc></description></item>
///<item><description>Transparent &lt;m:transp></description></item>
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ShowPhantom))]
    [ChildElementInfo(typeof(ZeroWidth))]
    [ChildElementInfo(typeof(ZeroAscent))]
    [ChildElementInfo(typeof(ZeroDescent))]
    [ChildElementInfo(typeof(Transparent))]
    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class PhantomProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 11000;
    /// <inheritdoc/>
    public override string LocalName => "phantPr";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the PhantomProperties class.
    /// </summary>
    public PhantomProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PhantomProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PhantomProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PhantomProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PhantomProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PhantomProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PhantomProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "show" == name)
    return new ShowPhantom();
    
if( 21 == namespaceId && "zeroWid" == name)
    return new ZeroWidth();
    
if( 21 == namespaceId && "zeroAsc" == name)
    return new ZeroAscent();
    
if( 21 == namespaceId && "zeroDesc" == name)
    return new ZeroDescent();
    
if( 21 == namespaceId && "transp" == name)
    return new Transparent();
    
if( 21 == namespaceId && "ctrlPr" == name)
    return new ControlProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "show","zeroWid","zeroAsc","zeroDesc","transp","ctrlPr" };
    private static readonly byte[] eleNamespaceIds = { 21,21,21,21,21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Phantom Show.</para>
    /// <para> Represents the following element tag in the schema: m:show </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public ShowPhantom ShowPhantom
    {
        get => GetElement<ShowPhantom>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Phantom Zero Width.</para>
    /// <para> Represents the following element tag in the schema: m:zeroWid </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public ZeroWidth ZeroWidth
    {
        get => GetElement<ZeroWidth>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> Phantom Zero Ascent.</para>
    /// <para> Represents the following element tag in the schema: m:zeroAsc </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public ZeroAscent ZeroAscent
    {
        get => GetElement<ZeroAscent>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Phantom Zero Descent.</para>
    /// <para> Represents the following element tag in the schema: m:zeroDesc </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public ZeroDescent ZeroDescent
    {
        get => GetElement<ZeroDescent>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> Transparent (Phantom).</para>
    /// <para> Represents the following element tag in the schema: m:transp </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public Transparent Transparent
    {
        get => GetElement<Transparent>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> ControlProperties.</para>
    /// <para> Represents the following element tag in the schema: m:ctrlPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public ControlProperties ControlProperties
    {
        get => GetElement<ControlProperties>(5);
        set => SetElement(5, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PhantomProperties>(deep);

}
/// <summary>
/// <para>Radical Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:radPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>HideDegree &lt;m:degHide></description></item>
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(HideDegree))]
    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class RadicalProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 11002;
    /// <inheritdoc/>
    public override string LocalName => "radPr";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the RadicalProperties class.
    /// </summary>
    public RadicalProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the RadicalProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RadicalProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the RadicalProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public RadicalProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the RadicalProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public RadicalProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "degHide" == name)
    return new HideDegree();
    
if( 21 == namespaceId && "ctrlPr" == name)
    return new ControlProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "degHide","ctrlPr" };
    private static readonly byte[] eleNamespaceIds = { 21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Hide Degree.</para>
    /// <para> Represents the following element tag in the schema: m:degHide </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public HideDegree HideDegree
    {
        get => GetElement<HideDegree>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> ControlProperties.</para>
    /// <para> Represents the following element tag in the schema: m:ctrlPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public ControlProperties ControlProperties
    {
        get => GetElement<ControlProperties>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<RadicalProperties>(deep);

}
/// <summary>
/// <para>Pre-Sub-Superscript Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:sPrePr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class PreSubSuperProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 11004;
    /// <inheritdoc/>
    public override string LocalName => "sPrePr";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the PreSubSuperProperties class.
    /// </summary>
    public PreSubSuperProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PreSubSuperProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PreSubSuperProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PreSubSuperProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PreSubSuperProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PreSubSuperProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PreSubSuperProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "ctrlPr" == name)
    return new ControlProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "ctrlPr" };
    private static readonly byte[] eleNamespaceIds = { 21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ControlProperties.</para>
    /// <para> Represents the following element tag in the schema: m:ctrlPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public ControlProperties ControlProperties
    {
        get => GetElement<ControlProperties>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PreSubSuperProperties>(deep);

}
/// <summary>
/// <para>Subscript Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:sSubPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SubscriptProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 11005;
    /// <inheritdoc/>
    public override string LocalName => "sSubPr";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the SubscriptProperties class.
    /// </summary>
    public SubscriptProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SubscriptProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SubscriptProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SubscriptProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SubscriptProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SubscriptProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SubscriptProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "ctrlPr" == name)
    return new ControlProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "ctrlPr" };
    private static readonly byte[] eleNamespaceIds = { 21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ControlProperties.</para>
    /// <para> Represents the following element tag in the schema: m:ctrlPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public ControlProperties ControlProperties
    {
        get => GetElement<ControlProperties>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SubscriptProperties>(deep);

}
/// <summary>
/// <para>Sub-Superscript Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:sSubSupPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>AlignScripts &lt;m:alnScr></description></item>
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(AlignScripts))]
    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SubSuperscriptProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 11007;
    /// <inheritdoc/>
    public override string LocalName => "sSubSupPr";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the SubSuperscriptProperties class.
    /// </summary>
    public SubSuperscriptProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SubSuperscriptProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SubSuperscriptProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SubSuperscriptProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SubSuperscriptProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SubSuperscriptProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SubSuperscriptProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "alnScr" == name)
    return new AlignScripts();
    
if( 21 == namespaceId && "ctrlPr" == name)
    return new ControlProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "alnScr","ctrlPr" };
    private static readonly byte[] eleNamespaceIds = { 21,21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Align Scripts.</para>
    /// <para> Represents the following element tag in the schema: m:alnScr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public AlignScripts AlignScripts
    {
        get => GetElement<AlignScripts>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> ControlProperties.</para>
    /// <para> Represents the following element tag in the schema: m:ctrlPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public ControlProperties ControlProperties
    {
        get => GetElement<ControlProperties>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SubSuperscriptProperties>(deep);

}
/// <summary>
/// <para>Superscript Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:sSupPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SuperscriptProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 11008;
    /// <inheritdoc/>
    public override string LocalName => "sSupPr";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the SuperscriptProperties class.
    /// </summary>
    public SuperscriptProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the SuperscriptProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SuperscriptProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the SuperscriptProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public SuperscriptProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the SuperscriptProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public SuperscriptProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "ctrlPr" == name)
    return new ControlProperties();
    

    return null;
}

        private static readonly string[] eleTagNames = { "ctrlPr" };
    private static readonly byte[] eleNamespaceIds = { 21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ControlProperties.</para>
    /// <para> Represents the following element tag in the schema: m:ctrlPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public ControlProperties ControlProperties
    {
        get => GetElement<ControlProperties>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<SuperscriptProperties>(deep);

}
/// <summary>
/// <para>Argument Size.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:argSz.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ArgumentSize : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 11009;
    /// <inheritdoc/>
    public override string LocalName => "argSz";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<IntegerValue>(21, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public IntegerValue Val
    {
        get { return (IntegerValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ArgumentSize class.
    /// </summary>
    public ArgumentSize():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArgumentSize>(deep);

}
/// <summary>
/// <para>Argument Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:argPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ArgumentSize &lt;m:argSz></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ArgumentSize))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ArgumentProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 11010;
    /// <inheritdoc/>
    public override string LocalName => "argPr";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ArgumentProperties class.
    /// </summary>
    public ArgumentProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ArgumentProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ArgumentProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ArgumentProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ArgumentProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ArgumentProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ArgumentProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "argSz" == name)
    return new ArgumentSize();
    

    return null;
}

        private static readonly string[] eleTagNames = { "argSz" };
    private static readonly byte[] eleNamespaceIds = { 21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Argument Size.</para>
    /// <para> Represents the following element tag in the schema: m:argSz </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public ArgumentSize ArgumentSize
    {
        get => GetElement<ArgumentSize>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArgumentProperties>(deep);

}
/// <summary>
/// <para>Justification.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:jc.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Justification : OfficeMathJustificationType
{
    internal const int ElementTypeIdConst = 11011;
    /// <inheritdoc/>
    public override string LocalName => "jc";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the Justification class.
    /// </summary>
    public Justification():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Justification>(deep);

}
/// <summary>
/// <para>Default Justification.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:defJc.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DefaultJustification : OfficeMathJustificationType
{
    internal const int ElementTypeIdConst = 11019;
    /// <inheritdoc/>
    public override string LocalName => "defJc";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    /// <summary>
    /// Initializes a new instance of the DefaultJustification class.
    /// </summary>
    public DefaultJustification():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DefaultJustification>(deep);

}
/// <summary>
/// Defines the OfficeMathJustificationType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class OfficeMathJustificationType : OpenXmlLeafElement
{
        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Math.JustificationValues>>(21, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);
    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public EnumValue<DocumentFormat.OpenXml.Math.JustificationValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Math.JustificationValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the OfficeMathJustificationType class.
    /// </summary>
    protected OfficeMathJustificationType(){}
    
    
    
}
/// <summary>
/// <para>Math Font.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:mathFont.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class MathFont : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 11012;
    /// <inheritdoc/>
    public override string LocalName => "mathFont";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<StringValue>(21, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public StringValue Val
    {
        get { return (StringValue)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the MathFont class.
    /// </summary>
    public MathFont():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MathFont>(deep);

}
/// <summary>
/// <para>Break on Binary Operators.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:brkBin.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class BreakBinary : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 11013;
    /// <inheritdoc/>
    public override string LocalName => "brkBin";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues>>(21, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public EnumValue<DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BreakBinary class.
    /// </summary>
    public BreakBinary():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BreakBinary>(deep);

}
/// <summary>
/// <para>Break on Binary Subtraction.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:brkBinSub.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class BreakBinarySubtraction : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 11014;
    /// <inheritdoc/>
    public override string LocalName => "brkBinSub";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

        private static readonly ReadOnlyArray<AttributeTag> s_attributeTags = new []
	{
		AttributeTag.Create<EnumValue<DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues>>(21, "val")
	};
    internal override AttributeTagCollection RawAttributes { get; } = new AttributeTagCollection(s_attributeTags);

    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public EnumValue<DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues>)Attributes[0].Value; }
        set { Attributes[0].Value = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BreakBinarySubtraction class.
    /// </summary>
    public BreakBinarySubtraction():base(){}
    
      
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BreakBinarySubtraction>(deep);

}
/// <summary>
/// <para>Office Math Paragraph Properties.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:oMathParaPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Justification &lt;m:jc></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(Justification))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ParagraphProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 11028;
    /// <inheritdoc/>
    public override string LocalName => "oMathParaPr";
    
    internal override byte NamespaceId => 21;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ParagraphProperties class.
    /// </summary>
    public ParagraphProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ParagraphProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ParagraphProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ParagraphProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ParagraphProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ParagraphProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ParagraphProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "jc" == name)
    return new Justification();
    

    return null;
}

        private static readonly string[] eleTagNames = { "jc" };
    private static readonly byte[] eleNamespaceIds = { 21 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Justification.</para>
    /// <para> Represents the following element tag in the schema: m:jc </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public Justification Justification
    {
        get => GetElement<Justification>(0);
        set => SetElement(0, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ParagraphProperties>(deep);

}
/// <summary>
/// Defines the HorizontalAlignmentValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum HorizontalAlignmentValues
{  
	///<summary>
///Left Justification.
///<para>When the item is serialized out as xml, its value is "left".</para>
///</summary>
[EnumString("left")]
Left,
///<summary>
///Center.
///<para>When the item is serialized out as xml, its value is "center".</para>
///</summary>
[EnumString("center")]
Center,
///<summary>
///Right.
///<para>When the item is serialized out as xml, its value is "right".</para>
///</summary>
[EnumString("right")]
Right,
 
}
/// <summary>
/// Defines the ShapeDelimiterValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ShapeDelimiterValues
{  
	///<summary>
///Centered (Delimiters).
///<para>When the item is serialized out as xml, its value is "centered".</para>
///</summary>
[EnumString("centered")]
Centered,
///<summary>
///Match.
///<para>When the item is serialized out as xml, its value is "match".</para>
///</summary>
[EnumString("match")]
Match,
 
}
/// <summary>
/// Defines the FractionTypeValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum FractionTypeValues
{  
	///<summary>
///Bar Fraction.
///<para>When the item is serialized out as xml, its value is "bar".</para>
///</summary>
[EnumString("bar")]
Bar,
///<summary>
///Skewed.
///<para>When the item is serialized out as xml, its value is "skw".</para>
///</summary>
[EnumString("skw")]
Skewed,
///<summary>
///Linear Fraction.
///<para>When the item is serialized out as xml, its value is "lin".</para>
///</summary>
[EnumString("lin")]
Linear,
///<summary>
///No-Bar Fraction (Stack).
///<para>When the item is serialized out as xml, its value is "noBar".</para>
///</summary>
[EnumString("noBar")]
NoBar,
 
}
/// <summary>
/// Defines the LimitLocationValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum LimitLocationValues
{  
	///<summary>
///Under-Over location.
///<para>When the item is serialized out as xml, its value is "undOvr".</para>
///</summary>
[EnumString("undOvr")]
UnderOver,
///<summary>
///Subscript-Superscript location.
///<para>When the item is serialized out as xml, its value is "subSup".</para>
///</summary>
[EnumString("subSup")]
SubscriptSuperscript,
 
}
/// <summary>
/// Defines the VerticalJustificationValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum VerticalJustificationValues
{  
	///<summary>
///Top.
///<para>When the item is serialized out as xml, its value is "top".</para>
///</summary>
[EnumString("top")]
Top,
///<summary>
///Bottom Alignment.
///<para>When the item is serialized out as xml, its value is "bot".</para>
///</summary>
[EnumString("bot")]
Bottom,
 
}
/// <summary>
/// Defines the ScriptValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum ScriptValues
{  
	///<summary>
///Roman.
///<para>When the item is serialized out as xml, its value is "roman".</para>
///</summary>
[EnumString("roman")]
Roman,
///<summary>
///Script.
///<para>When the item is serialized out as xml, its value is "script".</para>
///</summary>
[EnumString("script")]
Script,
///<summary>
///Fraktur.
///<para>When the item is serialized out as xml, its value is "fraktur".</para>
///</summary>
[EnumString("fraktur")]
Fraktur,
///<summary>
///double-struck.
///<para>When the item is serialized out as xml, its value is "double-struck".</para>
///</summary>
[EnumString("double-struck")]
DoubleStruck,
///<summary>
///Sans-Serif.
///<para>When the item is serialized out as xml, its value is "sans-serif".</para>
///</summary>
[EnumString("sans-serif")]
SansSerif,
///<summary>
///Monospace.
///<para>When the item is serialized out as xml, its value is "monospace".</para>
///</summary>
[EnumString("monospace")]
Monospace,
 
}
/// <summary>
/// Defines the StyleValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum StyleValues
{  
	///<summary>
///Plain.
///<para>When the item is serialized out as xml, its value is "p".</para>
///</summary>
[EnumString("p")]
Plain,
///<summary>
///Bold.
///<para>When the item is serialized out as xml, its value is "b".</para>
///</summary>
[EnumString("b")]
Bold,
///<summary>
///Italic.
///<para>When the item is serialized out as xml, its value is "i".</para>
///</summary>
[EnumString("i")]
Italic,
///<summary>
///Bold-Italic.
///<para>When the item is serialized out as xml, its value is "bi".</para>
///</summary>
[EnumString("bi")]
BoldItalic,
 
}
/// <summary>
/// Defines the JustificationValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum JustificationValues
{  
	///<summary>
///Left Justification.
///<para>When the item is serialized out as xml, its value is "left".</para>
///</summary>
[EnumString("left")]
Left,
///<summary>
///Right.
///<para>When the item is serialized out as xml, its value is "right".</para>
///</summary>
[EnumString("right")]
Right,
///<summary>
///Center (Equation).
///<para>When the item is serialized out as xml, its value is "center".</para>
///</summary>
[EnumString("center")]
Center,
///<summary>
///Centered as Group (Equations).
///<para>When the item is serialized out as xml, its value is "centerGroup".</para>
///</summary>
[EnumString("centerGroup")]
CenterGroup,
 
}
/// <summary>
/// Defines the BreakBinaryOperatorValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum BreakBinaryOperatorValues
{  
	///<summary>
///Before.
///<para>When the item is serialized out as xml, its value is "before".</para>
///</summary>
[EnumString("before")]
Before,
///<summary>
///After.
///<para>When the item is serialized out as xml, its value is "after".</para>
///</summary>
[EnumString("after")]
After,
///<summary>
///Repeat.
///<para>When the item is serialized out as xml, its value is "repeat".</para>
///</summary>
[EnumString("repeat")]
Repeat,
 
}
/// <summary>
/// Defines the BreakBinarySubtractionValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum BreakBinarySubtractionValues
{  
	///<summary>
///Minus Minus.
///<para>When the item is serialized out as xml, its value is "--".</para>
///</summary>
[EnumString("--")]
MinusMinus,
///<summary>
///Minus Plus.
///<para>When the item is serialized out as xml, its value is "-+".</para>
///</summary>
[EnumString("-+")]
MinusPlus,
///<summary>
///Plus Minus.
///<para>When the item is serialized out as xml, its value is "+-".</para>
///</summary>
[EnumString("+-")]
PlusMinus,
 
}
/// <summary>
/// Defines the VerticalAlignmentValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum VerticalAlignmentValues
{  
	///<summary>
///Top.
///<para>When the item is serialized out as xml, its value is "top".</para>
///</summary>
[EnumString("top")]
Top,
///<summary>
///Center (Function).
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
///Bottom Alignment.
///<para>When the item is serialized out as xml, its value is "bot".</para>
///</summary>
[EnumString("bot")]
Bot,
 
}
/// <summary>
/// Defines the BooleanValues enumeration. 
/// </summary> 
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public enum BooleanValues
{  
	///<summary>
///true.
///<para>When the item is serialized out as xml, its value is "true".</para>
///</summary>
[EnumString("true")]
True,
///<summary>
///false.
///<para>When the item is serialized out as xml, its value is "false".</para>
///</summary>
[EnumString("false")]
False,
///<summary>
///On.
///<para>When the item is serialized out as xml, its value is "on".</para>
///</summary>
[EnumString("on")]
On,
///<summary>
///Off.
///<para>When the item is serialized out as xml, its value is "off".</para>
///</summary>
[EnumString("off")]
Off,
///<summary>
///0.
///<para>When the item is serialized out as xml, its value is "0".</para>
///</summary>
[EnumString("0")]
Zero,
///<summary>
///1.
///<para>When the item is serialized out as xml, its value is "1".</para>
///</summary>
[EnumString("1")]
One,
 
}
}
 
 
