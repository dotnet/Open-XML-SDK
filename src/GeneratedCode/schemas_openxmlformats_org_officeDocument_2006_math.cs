// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
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
/// <para> When the object is serialized out as xml, its qualified name is m:scr.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Script : OpenXmlLeafElement
{
    private const string tagName = "scr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10905;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "val" };
    private static byte[] attributeNamespaceIds = { 21 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public EnumValue<DocumentFormat.OpenXml.Math.ScriptValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Math.ScriptValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Script class.
    /// </summary>
    public Script():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "val" == name)
    return new EnumValue<DocumentFormat.OpenXml.Math.ScriptValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Script>(deep);
    }

   
}
/// <summary>
/// <para>style.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:sty.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Style : OpenXmlLeafElement
{
    private const string tagName = "sty";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10906;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "val" };
    private static byte[] attributeNamespaceIds = { 21 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public EnumValue<DocumentFormat.OpenXml.Math.StyleValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Math.StyleValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Style class.
    /// </summary>
    public Style():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "val" == name)
    return new EnumValue<DocumentFormat.OpenXml.Math.StyleValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Style>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Run Class.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Run : OpenXmlCompositeElement
{
    private const string tagName = "r";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10907;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Run Properties.</para>
    /// <para> Represents the following element tag in the schema: m:rPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public RunProperties MathRunProperties
    {
        get 
        {
            return GetElement<RunProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Run>(deep);
    }

   
}
/// <summary>
/// <para>Accent.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:acc.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>AccentProperties &lt;m:accPr></description></item>
///<item><description>Base &lt;m:e></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(AccentProperties))]
    [ChildElementInfo(typeof(Base))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Accent : OpenXmlCompositeElement
{
    private const string tagName = "acc";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10908;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Accent Properties.</para>
    /// <para> Represents the following element tag in the schema: m:accPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public AccentProperties AccentProperties
    {
        get 
        {
            return GetElement<AccentProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<Base>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Accent>(deep);
    }

   
}
/// <summary>
/// <para>Bar.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:bar.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BarProperties &lt;m:barPr></description></item>
///<item><description>Base &lt;m:e></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(BarProperties))]
    [ChildElementInfo(typeof(Base))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Bar : OpenXmlCompositeElement
{
    private const string tagName = "bar";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10909;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Bar Properties.</para>
    /// <para> Represents the following element tag in the schema: m:barPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public BarProperties BarProperties
    {
        get 
        {
            return GetElement<BarProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<Base>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Bar>(deep);
    }

   
}
/// <summary>
/// <para>Box Function.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:box.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BoxProperties &lt;m:boxPr></description></item>
///<item><description>Base &lt;m:e></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(BoxProperties))]
    [ChildElementInfo(typeof(Base))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Box : OpenXmlCompositeElement
{
    private const string tagName = "box";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10910;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Box Properties.</para>
    /// <para> Represents the following element tag in the schema: m:boxPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public BoxProperties BoxProperties
    {
        get 
        {
            return GetElement<BoxProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<Base>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Box>(deep);
    }

   
}
/// <summary>
/// <para>Border-Box Function.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:borderBox.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BorderBoxProperties &lt;m:borderBoxPr></description></item>
///<item><description>Base &lt;m:e></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(BorderBoxProperties))]
    [ChildElementInfo(typeof(Base))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class BorderBox : OpenXmlCompositeElement
{
    private const string tagName = "borderBox";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10911;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Border Box Properties.</para>
    /// <para> Represents the following element tag in the schema: m:borderBoxPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public BorderBoxProperties BorderBoxProperties
    {
        get 
        {
            return GetElement<BorderBoxProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<Base>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<BorderBox>(deep);
    }

   
}
/// <summary>
/// <para>Delimiter Function.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:d.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DelimiterProperties &lt;m:dPr></description></item>
///<item><description>Base &lt;m:e></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DelimiterProperties))]
    [ChildElementInfo(typeof(Base))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Delimiter : OpenXmlCompositeElement
{
    private const string tagName = "d";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10912;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Delimiter Properties.</para>
    /// <para> Represents the following element tag in the schema: m:dPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public DelimiterProperties DelimiterProperties
    {
        get 
        {
            return GetElement<DelimiterProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Delimiter>(deep);
    }

   
}
/// <summary>
/// <para>Equation-Array Function.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:eqArr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>EquationArrayProperties &lt;m:eqArrPr></description></item>
///<item><description>Base &lt;m:e></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(EquationArrayProperties))]
    [ChildElementInfo(typeof(Base))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class EquationArray : OpenXmlCompositeElement
{
    private const string tagName = "eqArr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10913;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Equation Array Properties.</para>
    /// <para> Represents the following element tag in the schema: m:eqArrPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public EquationArrayProperties EquationArrayProperties
    {
        get 
        {
            return GetElement<EquationArrayProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<EquationArray>(deep);
    }

   
}
/// <summary>
/// <para>Fraction Function.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(FractionProperties))]
    [ChildElementInfo(typeof(Numerator))]
    [ChildElementInfo(typeof(Denominator))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Fraction : OpenXmlCompositeElement
{
    private const string tagName = "f";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10914;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Fraction Properties.</para>
    /// <para> Represents the following element tag in the schema: m:fPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public FractionProperties FractionProperties
    {
        get 
        {
            return GetElement<FractionProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<Numerator>(1);
        }
        set
        {
            SetElement(1, value);
        }
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
        get 
        {
            return GetElement<Denominator>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Fraction>(deep);
    }

   
}
/// <summary>
/// <para>Function Apply Function.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(FunctionProperties))]
    [ChildElementInfo(typeof(FunctionName))]
    [ChildElementInfo(typeof(Base))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class MathFunction : OpenXmlCompositeElement
{
    private const string tagName = "func";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10915;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Function Properties.</para>
    /// <para> Represents the following element tag in the schema: m:funcPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public FunctionProperties FunctionProperties
    {
        get 
        {
            return GetElement<FunctionProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<FunctionName>(1);
        }
        set
        {
            SetElement(1, value);
        }
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
        get 
        {
            return GetElement<Base>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<MathFunction>(deep);
    }

   
}
/// <summary>
/// <para>Group-Character Function.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:groupChr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>GroupCharProperties &lt;m:groupChrPr></description></item>
///<item><description>Base &lt;m:e></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(GroupCharProperties))]
    [ChildElementInfo(typeof(Base))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class GroupChar : OpenXmlCompositeElement
{
    private const string tagName = "groupChr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10916;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Group-Character Properties.</para>
    /// <para> Represents the following element tag in the schema: m:groupChrPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public GroupCharProperties GroupCharProperties
    {
        get 
        {
            return GetElement<GroupCharProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<Base>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<GroupChar>(deep);
    }

   
}
/// <summary>
/// <para>Lower-Limit Function.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(LimitLowerProperties))]
    [ChildElementInfo(typeof(Base))]
    [ChildElementInfo(typeof(Limit))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class LimitLower : OpenXmlCompositeElement
{
    private const string tagName = "limLow";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10917;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Lower Limit Properties.</para>
    /// <para> Represents the following element tag in the schema: m:limLowPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public LimitLowerProperties LimitLowerProperties
    {
        get 
        {
            return GetElement<LimitLowerProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<Base>(1);
        }
        set
        {
            SetElement(1, value);
        }
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
        get 
        {
            return GetElement<Limit>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<LimitLower>(deep);
    }

   
}
/// <summary>
/// <para>Upper-Limit Function.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(LimitUpperProperties))]
    [ChildElementInfo(typeof(Base))]
    [ChildElementInfo(typeof(Limit))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class LimitUpper : OpenXmlCompositeElement
{
    private const string tagName = "limUpp";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10918;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Upper Limit Properties.</para>
    /// <para> Represents the following element tag in the schema: m:limUppPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public LimitUpperProperties LimitUpperProperties
    {
        get 
        {
            return GetElement<LimitUpperProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<Base>(1);
        }
        set
        {
            SetElement(1, value);
        }
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
        get 
        {
            return GetElement<Limit>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<LimitUpper>(deep);
    }

   
}
/// <summary>
/// <para>Matrix Function.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:m.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>MatrixProperties &lt;m:mPr></description></item>
///<item><description>MatrixRow &lt;m:mr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(MatrixProperties))]
    [ChildElementInfo(typeof(MatrixRow))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Matrix : OpenXmlCompositeElement
{
    private const string tagName = "m";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10919;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Matrix Properties.</para>
    /// <para> Represents the following element tag in the schema: m:mPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public MatrixProperties MatrixProperties
    {
        get 
        {
            return GetElement<MatrixProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Matrix>(deep);
    }

   
}
/// <summary>
/// <para>n-ary Operator Function.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(NaryProperties))]
    [ChildElementInfo(typeof(SubArgument))]
    [ChildElementInfo(typeof(SuperArgument))]
    [ChildElementInfo(typeof(Base))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Nary : OpenXmlCompositeElement
{
    private const string tagName = "nary";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10920;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> n-ary Properties.</para>
    /// <para> Represents the following element tag in the schema: m:naryPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public NaryProperties NaryProperties
    {
        get 
        {
            return GetElement<NaryProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<SubArgument>(1);
        }
        set
        {
            SetElement(1, value);
        }
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
        get 
        {
            return GetElement<SuperArgument>(2);
        }
        set
        {
            SetElement(2, value);
        }
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
        get 
        {
            return GetElement<Base>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Nary>(deep);
    }

   
}
/// <summary>
/// <para>Phantom Function.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:phant.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>PhantomProperties &lt;m:phantPr></description></item>
///<item><description>Base &lt;m:e></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(PhantomProperties))]
    [ChildElementInfo(typeof(Base))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Phantom : OpenXmlCompositeElement
{
    private const string tagName = "phant";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10921;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Phantom Properties.</para>
    /// <para> Represents the following element tag in the schema: m:phantPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public PhantomProperties PhantomProperties
    {
        get 
        {
            return GetElement<PhantomProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<Base>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Phantom>(deep);
    }

   
}
/// <summary>
/// <para>Radical Function.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(RadicalProperties))]
    [ChildElementInfo(typeof(Degree))]
    [ChildElementInfo(typeof(Base))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Radical : OpenXmlCompositeElement
{
    private const string tagName = "rad";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10922;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Radical Properties.</para>
    /// <para> Represents the following element tag in the schema: m:radPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public RadicalProperties RadicalProperties
    {
        get 
        {
            return GetElement<RadicalProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<Degree>(1);
        }
        set
        {
            SetElement(1, value);
        }
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
        get 
        {
            return GetElement<Base>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Radical>(deep);
    }

   
}
/// <summary>
/// <para>Pre-Sub-Superscript Function.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(PreSubSuperProperties))]
    [ChildElementInfo(typeof(SubArgument))]
    [ChildElementInfo(typeof(SuperArgument))]
    [ChildElementInfo(typeof(Base))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class PreSubSuper : OpenXmlCompositeElement
{
    private const string tagName = "sPre";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10923;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Pre-Sub-Superscript Properties.</para>
    /// <para> Represents the following element tag in the schema: m:sPrePr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public PreSubSuperProperties PreSubSuperProperties
    {
        get 
        {
            return GetElement<PreSubSuperProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<SubArgument>(1);
        }
        set
        {
            SetElement(1, value);
        }
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
        get 
        {
            return GetElement<SuperArgument>(2);
        }
        set
        {
            SetElement(2, value);
        }
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
        get 
        {
            return GetElement<Base>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<PreSubSuper>(deep);
    }

   
}
/// <summary>
/// <para>Subscript Function.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(SubscriptProperties))]
    [ChildElementInfo(typeof(Base))]
    [ChildElementInfo(typeof(SubArgument))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Subscript : OpenXmlCompositeElement
{
    private const string tagName = "sSub";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10924;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Subscript Properties.</para>
    /// <para> Represents the following element tag in the schema: m:sSubPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public SubscriptProperties SubscriptProperties
    {
        get 
        {
            return GetElement<SubscriptProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<Base>(1);
        }
        set
        {
            SetElement(1, value);
        }
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
        get 
        {
            return GetElement<SubArgument>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Subscript>(deep);
    }

   
}
/// <summary>
/// <para>Sub-Superscript Function.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(SubSuperscriptProperties))]
    [ChildElementInfo(typeof(Base))]
    [ChildElementInfo(typeof(SubArgument))]
    [ChildElementInfo(typeof(SuperArgument))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class SubSuperscript : OpenXmlCompositeElement
{
    private const string tagName = "sSubSup";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10925;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Sub-Superscript Properties.</para>
    /// <para> Represents the following element tag in the schema: m:sSubSupPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public SubSuperscriptProperties SubSuperscriptProperties
    {
        get 
        {
            return GetElement<SubSuperscriptProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<Base>(1);
        }
        set
        {
            SetElement(1, value);
        }
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
        get 
        {
            return GetElement<SubArgument>(2);
        }
        set
        {
            SetElement(2, value);
        }
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
        get 
        {
            return GetElement<SuperArgument>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<SubSuperscript>(deep);
    }

   
}
/// <summary>
/// <para>Superscript Function.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(SuperscriptProperties))]
    [ChildElementInfo(typeof(Base))]
    [ChildElementInfo(typeof(SuperArgument))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Superscript : OpenXmlCompositeElement
{
    private const string tagName = "sSup";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10926;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Superscript Properties.</para>
    /// <para> Represents the following element tag in the schema: m:sSupPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public SuperscriptProperties SuperscriptProperties
    {
        get 
        {
            return GetElement<SuperscriptProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<Base>(1);
        }
        set
        {
            SetElement(1, value);
        }
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
        get 
        {
            return GetElement<SuperArgument>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Superscript>(deep);
    }

   
}
/// <summary>
/// <para>Defines the Paragraph Class.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
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
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.InsertedRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.ContentPart),(FileFormatVersions)2)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.Run))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Paragraph : OpenXmlCompositeElement
{
    private const string tagName = "oMathPara";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10927;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Office Math Paragraph Properties.</para>
    /// <para> Represents the following element tag in the schema: m:oMathParaPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public ParagraphProperties ParagraphProperties
    {
        get 
        {
            return GetElement<ParagraphProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Paragraph>(deep);
    }

   
}
/// <summary>
/// <para>Defines the OfficeMath Class.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
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
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.InsertedRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.ContentPart),(FileFormatVersions)2)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(Paragraph))]
    [ChildElementInfo(typeof(OfficeMath))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class OfficeMath : OpenXmlCompositeElement
{
    private const string tagName = "oMath";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10928;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<OfficeMath>(deep);
    }

   
}
/// <summary>
/// <para>Math Properties.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
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
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class MathProperties : OpenXmlCompositeElement
{
    private const string tagName = "mathPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10929;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Math Font.</para>
    /// <para> Represents the following element tag in the schema: m:mathFont </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public MathFont MathFont
    {
        get 
        {
            return GetElement<MathFont>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<BreakBinary>(1);
        }
        set
        {
            SetElement(1, value);
        }
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
        get 
        {
            return GetElement<BreakBinarySubtraction>(2);
        }
        set
        {
            SetElement(2, value);
        }
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
        get 
        {
            return GetElement<SmallFraction>(3);
        }
        set
        {
            SetElement(3, value);
        }
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
        get 
        {
            return GetElement<DisplayDefaults>(4);
        }
        set
        {
            SetElement(4, value);
        }
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
        get 
        {
            return GetElement<LeftMargin>(5);
        }
        set
        {
            SetElement(5, value);
        }
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
        get 
        {
            return GetElement<RightMargin>(6);
        }
        set
        {
            SetElement(6, value);
        }
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
        get 
        {
            return GetElement<DefaultJustification>(7);
        }
        set
        {
            SetElement(7, value);
        }
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
        get 
        {
            return GetElement<PreSpacing>(8);
        }
        set
        {
            SetElement(8, value);
        }
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
        get 
        {
            return GetElement<PostSpacing>(9);
        }
        set
        {
            SetElement(9, value);
        }
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
        get 
        {
            return GetElement<InterSpacing>(10);
        }
        set
        {
            SetElement(10, value);
        }
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
        get 
        {
            return GetElement<IntraSpacing>(11);
        }
        set
        {
            SetElement(11, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<MathProperties>(deep);
    }

   
}
/// <summary>
/// <para>Literal.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:lit.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Literal : OnOffType
{
    private const string tagName = "lit";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10930;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the Literal class.
    /// </summary>
    public Literal():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Literal>(deep);
    }

}
/// <summary>
/// <para>Normal Text.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:nor.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class NormalText : OnOffType
{
    private const string tagName = "nor";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10931;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the NormalText class.
    /// </summary>
    public NormalText():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<NormalText>(deep);
    }

}
/// <summary>
/// <para>Align.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:aln.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Alignment : OnOffType
{
    private const string tagName = "aln";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10933;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the Alignment class.
    /// </summary>
    public Alignment():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Alignment>(deep);
    }

}
/// <summary>
/// <para>Operator Emulator.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:opEmu.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class OperatorEmulator : OnOffType
{
    private const string tagName = "opEmu";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10942;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the OperatorEmulator class.
    /// </summary>
    public OperatorEmulator():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<OperatorEmulator>(deep);
    }

}
/// <summary>
/// <para>No Break.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:noBreak.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class NoBreak : OnOffType
{
    private const string tagName = "noBreak";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10943;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the NoBreak class.
    /// </summary>
    public NoBreak():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<NoBreak>(deep);
    }

}
/// <summary>
/// <para>Differential.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:diff.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Differential : OnOffType
{
    private const string tagName = "diff";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10944;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the Differential class.
    /// </summary>
    public Differential():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Differential>(deep);
    }

}
/// <summary>
/// <para>Hide Top Edge.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:hideTop.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class HideTop : OnOffType
{
    private const string tagName = "hideTop";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10946;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the HideTop class.
    /// </summary>
    public HideTop():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<HideTop>(deep);
    }

}
/// <summary>
/// <para>Hide Bottom Edge.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:hideBot.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class HideBottom : OnOffType
{
    private const string tagName = "hideBot";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10947;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the HideBottom class.
    /// </summary>
    public HideBottom():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<HideBottom>(deep);
    }

}
/// <summary>
/// <para>Hide Left Edge.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:hideLeft.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class HideLeft : OnOffType
{
    private const string tagName = "hideLeft";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10948;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the HideLeft class.
    /// </summary>
    public HideLeft():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<HideLeft>(deep);
    }

}
/// <summary>
/// <para>Hide Right Edge.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:hideRight.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class HideRight : OnOffType
{
    private const string tagName = "hideRight";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10949;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the HideRight class.
    /// </summary>
    public HideRight():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<HideRight>(deep);
    }

}
/// <summary>
/// <para>Border Box Strikethrough Horizontal.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:strikeH.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class StrikeHorizontal : OnOffType
{
    private const string tagName = "strikeH";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10950;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the StrikeHorizontal class.
    /// </summary>
    public StrikeHorizontal():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<StrikeHorizontal>(deep);
    }

}
/// <summary>
/// <para>Border Box Strikethrough Vertical.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:strikeV.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class StrikeVertical : OnOffType
{
    private const string tagName = "strikeV";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10951;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the StrikeVertical class.
    /// </summary>
    public StrikeVertical():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<StrikeVertical>(deep);
    }

}
/// <summary>
/// <para>Border Box Strikethrough Bottom-Left to Top-Right.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:strikeBLTR.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class StrikeBottomLeftToTopRight : OnOffType
{
    private const string tagName = "strikeBLTR";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10952;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the StrikeBottomLeftToTopRight class.
    /// </summary>
    public StrikeBottomLeftToTopRight():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<StrikeBottomLeftToTopRight>(deep);
    }

}
/// <summary>
/// <para>Border Box Strikethrough Top-Left to Bottom-Right.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:strikeTLBR.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class StrikeTopLeftToBottomRight : OnOffType
{
    private const string tagName = "strikeTLBR";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10953;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the StrikeTopLeftToBottomRight class.
    /// </summary>
    public StrikeTopLeftToBottomRight():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<StrikeTopLeftToBottomRight>(deep);
    }

}
/// <summary>
/// <para>Delimiter Grow.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:grow.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class GrowOperators : OnOffType
{
    private const string tagName = "grow";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10958;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the GrowOperators class.
    /// </summary>
    public GrowOperators():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<GrowOperators>(deep);
    }

}
/// <summary>
/// <para>Maximum Distribution.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:maxDist.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class MaxDistribution : OnOffType
{
    private const string tagName = "maxDist";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10962;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the MaxDistribution class.
    /// </summary>
    public MaxDistribution():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<MaxDistribution>(deep);
    }

}
/// <summary>
/// <para>Object Distribution.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:objDist.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ObjectDistribution : OnOffType
{
    private const string tagName = "objDist";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10963;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the ObjectDistribution class.
    /// </summary>
    public ObjectDistribution():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ObjectDistribution>(deep);
    }

}
/// <summary>
/// <para>Hide Placeholders (Matrix).</para>
/// <para> When the object is serialized out as xml, its qualified name is m:plcHide.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class HidePlaceholder : OnOffType
{
    private const string tagName = "plcHide";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10982;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the HidePlaceholder class.
    /// </summary>
    public HidePlaceholder():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<HidePlaceholder>(deep);
    }

}
/// <summary>
/// <para>Hide Subscript (n-ary).</para>
/// <para> When the object is serialized out as xml, its qualified name is m:subHide.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class HideSubArgument : OnOffType
{
    private const string tagName = "subHide";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10990;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the HideSubArgument class.
    /// </summary>
    public HideSubArgument():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<HideSubArgument>(deep);
    }

}
/// <summary>
/// <para>Hide Superscript (n-ary).</para>
/// <para> When the object is serialized out as xml, its qualified name is m:supHide.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class HideSuperArgument : OnOffType
{
    private const string tagName = "supHide";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10991;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the HideSuperArgument class.
    /// </summary>
    public HideSuperArgument():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<HideSuperArgument>(deep);
    }

}
/// <summary>
/// <para>Phantom Show.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:show.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ShowPhantom : OnOffType
{
    private const string tagName = "show";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10995;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the ShowPhantom class.
    /// </summary>
    public ShowPhantom():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ShowPhantom>(deep);
    }

}
/// <summary>
/// <para>Phantom Zero Width.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:zeroWid.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ZeroWidth : OnOffType
{
    private const string tagName = "zeroWid";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10996;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the ZeroWidth class.
    /// </summary>
    public ZeroWidth():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ZeroWidth>(deep);
    }

}
/// <summary>
/// <para>Phantom Zero Ascent.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:zeroAsc.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ZeroAscent : OnOffType
{
    private const string tagName = "zeroAsc";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10997;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the ZeroAscent class.
    /// </summary>
    public ZeroAscent():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ZeroAscent>(deep);
    }

}
/// <summary>
/// <para>Phantom Zero Descent.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:zeroDesc.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ZeroDescent : OnOffType
{
    private const string tagName = "zeroDesc";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10998;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the ZeroDescent class.
    /// </summary>
    public ZeroDescent():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ZeroDescent>(deep);
    }

}
/// <summary>
/// <para>Transparent (Phantom).</para>
/// <para> When the object is serialized out as xml, its qualified name is m:transp.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Transparent : OnOffType
{
    private const string tagName = "transp";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10999;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the Transparent class.
    /// </summary>
    public Transparent():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Transparent>(deep);
    }

}
/// <summary>
/// <para>Hide Degree.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:degHide.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class HideDegree : OnOffType
{
    private const string tagName = "degHide";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11001;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the HideDegree class.
    /// </summary>
    public HideDegree():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<HideDegree>(deep);
    }

}
/// <summary>
/// <para>Align Scripts.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:alnScr.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class AlignScripts : OnOffType
{
    private const string tagName = "alnScr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11006;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the AlignScripts class.
    /// </summary>
    public AlignScripts():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<AlignScripts>(deep);
    }

}
/// <summary>
/// <para>Small Fraction.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:smallFrac.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class SmallFraction : OnOffType
{
    private const string tagName = "smallFrac";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11015;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the SmallFraction class.
    /// </summary>
    public SmallFraction():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<SmallFraction>(deep);
    }

}
/// <summary>
/// <para>Use Display Math Defaults.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:dispDef.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class DisplayDefaults : OnOffType
{
    private const string tagName = "dispDef";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11016;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the DisplayDefaults class.
    /// </summary>
    public DisplayDefaults():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<DisplayDefaults>(deep);
    }

}
/// <summary>
/// <para>Wrap Right.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:wrapRight.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class WrapRight : OnOffType
{
    private const string tagName = "wrapRight";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11025;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the WrapRight class.
    /// </summary>
    public WrapRight():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<WrapRight>(deep);
    }

}
/// <summary>
/// Defines the OnOffType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class OnOffType : OpenXmlLeafElement
{
    private static string[] attributeTagNames = { "val" };
    private static byte[] attributeNamespaceIds = { 21 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    
    
        /// <summary>
    /// <para> value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public EnumValue<DocumentFormat.OpenXml.Math.BooleanValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Math.BooleanValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "val" == name)
    return new EnumValue<DocumentFormat.OpenXml.Math.BooleanValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

    
    /// <summary>
    /// Initializes a new instance of the OnOffType class.
    /// </summary>
    protected OnOffType(){}
    
    
    
}
/// <summary>
/// <para>Break.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:brk.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Break : OpenXmlLeafElement
{
    private const string tagName = "brk";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10932;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "alnAt","val" };
    private static byte[] attributeNamespaceIds = { 21,21 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Index of Operator to Align To.</para>
    /// <para>Represents the following attribute in the schema: m:alnAt </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "alnAt")]
    public IntegerValue AlignAt
    {
        get { return (IntegerValue)Attributes[0]; }
        set { Attributes[0] = value; }
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
        get { return (IntegerValue)Attributes[1]; }
        set { Attributes[1] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Break class.
    /// </summary>
    public Break():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "alnAt" == name)
    return new IntegerValue();
    
if( 21 == namespaceId && "val" == name)
    return new IntegerValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Break>(deep);
    }

   
}
/// <summary>
/// <para>Run Properties.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Literal))]
    [ChildElementInfo(typeof(NormalText))]
    [ChildElementInfo(typeof(Script))]
    [ChildElementInfo(typeof(Style))]
    [ChildElementInfo(typeof(Break))]
    [ChildElementInfo(typeof(Alignment))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class RunProperties : OpenXmlCompositeElement
{
    private const string tagName = "rPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10934;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Literal.</para>
    /// <para> Represents the following element tag in the schema: m:lit </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public Literal Literal
    {
        get 
        {
            return GetElement<Literal>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RunProperties>(deep);
    }

   
}
/// <summary>
/// <para>Text.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:t.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Text : OpenXmlLeafTextElement
{
    private const string tagName = "t";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10935;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "space" };
    private static byte[] attributeNamespaceIds = { 1 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> space.</para>
    /// <para>Represents the following attribute in the schema: xml:space </para>
    /// </summary>
///<remark> xmlns:xml=http://www.w3.org/XML/1998/namespace
///</remark>
    [SchemaAttr(1, "space")]
    public EnumValue<DocumentFormat.OpenXml.SpaceProcessingModeValues> Space
    {
        get { return (EnumValue<DocumentFormat.OpenXml.SpaceProcessingModeValues>)Attributes[0]; }
        set { Attributes[0] = value; }
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
    
 
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 1 == namespaceId && "space" == name)
    return new EnumValue<DocumentFormat.OpenXml.SpaceProcessingModeValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Text>(deep);
    }

   
}
/// <summary>
/// <para>Accent Character.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:chr.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class AccentChar : CharType
{
    private const string tagName = "chr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10936;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the AccentChar class.
    /// </summary>
    public AccentChar():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<AccentChar>(deep);
    }

}
/// <summary>
/// <para>Delimiter Beginning Character.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:begChr.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class BeginChar : CharType
{
    private const string tagName = "begChr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10955;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the BeginChar class.
    /// </summary>
    public BeginChar():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<BeginChar>(deep);
    }

}
/// <summary>
/// <para>Delimiter Separator Character.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:sepChr.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class SeparatorChar : CharType
{
    private const string tagName = "sepChr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10956;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the SeparatorChar class.
    /// </summary>
    public SeparatorChar():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<SeparatorChar>(deep);
    }

}
/// <summary>
/// <para>Delimiter Ending Character.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:endChr.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class EndChar : CharType
{
    private const string tagName = "endChr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10957;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the EndChar class.
    /// </summary>
    public EndChar():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<EndChar>(deep);
    }

}
/// <summary>
/// Defines the CharType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class CharType : OpenXmlLeafElement
{
    private static string[] attributeTagNames = { "val" };
    private static byte[] attributeNamespaceIds = { 21 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    
    
        /// <summary>
    /// <para> value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public StringValue Val
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "val" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

    
    /// <summary>
    /// Initializes a new instance of the CharType class.
    /// </summary>
    protected CharType(){}
    
    
    
}
/// <summary>
/// <para>Control Properties.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.RunProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedMathControl))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromMathControl))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToMathControl))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ControlProperties : OpenXmlCompositeElement
{
    private const string tagName = "ctrlPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10937;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ControlProperties>(deep);
    }

   
}
/// <summary>
/// <para>Accent Properties.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:accPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>AccentChar &lt;m:chr></description></item>
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(AccentChar))]
    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class AccentProperties : OpenXmlCompositeElement
{
    private const string tagName = "accPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10938;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Accent Character.</para>
    /// <para> Represents the following element tag in the schema: m:chr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public AccentChar AccentChar
    {
        get 
        {
            return GetElement<AccentChar>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<ControlProperties>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<AccentProperties>(deep);
    }

   
}
/// <summary>
/// <para>Base.</para>
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
public partial class Base : OfficeMathArgumentType
{
    private const string tagName = "e";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10939;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

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

    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Base>(deep);
    }

}
/// <summary>
/// <para>Numerator.</para>
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
public partial class Numerator : OfficeMathArgumentType
{
    private const string tagName = "num";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10969;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

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

    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Numerator>(deep);
    }

}
/// <summary>
/// <para>Denominator.</para>
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
public partial class Denominator : OfficeMathArgumentType
{
    private const string tagName = "den";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10970;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

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

    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Denominator>(deep);
    }

}
/// <summary>
/// <para>Function Name.</para>
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
public partial class FunctionName : OfficeMathArgumentType
{
    private const string tagName = "fName";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10972;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

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

    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<FunctionName>(deep);
    }

}
/// <summary>
/// <para>Limit (Lower).</para>
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
public partial class Limit : OfficeMathArgumentType
{
    private const string tagName = "lim";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10976;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

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

    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Limit>(deep);
    }

}
/// <summary>
/// <para>Lower limit (n-ary) .</para>
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
public partial class SubArgument : OfficeMathArgumentType
{
    private const string tagName = "sub";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10993;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

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

    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<SubArgument>(deep);
    }

}
/// <summary>
/// <para>Upper limit (n-ary).</para>
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
public partial class SuperArgument : OfficeMathArgumentType
{
    private const string tagName = "sup";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10994;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

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

    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<SuperArgument>(deep);
    }

}
/// <summary>
/// <para>Degree.</para>
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
public partial class Degree : OfficeMathArgumentType
{
    private const string tagName = "deg";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11003;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

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

    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Degree>(deep);
    }

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
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeStart),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictInsertionRangeEnd),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeStart),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.CustomXmlConflictDeletionRangeEnd),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.InsertedRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.DeletedRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveFromRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.MoveToRun))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Wordprocessing.ContentPart),(FileFormatVersions)2)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictInsertion),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.RunConflictDeletion),(FileFormatVersions)6)]
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Argument Properties.</para>
    /// <para> Represents the following element tag in the schema: m:argPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public ArgumentProperties ArgumentProperties
    {
        get 
        {
            return GetElement<ArgumentProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
/// <para> When the object is serialized out as xml, its qualified name is m:pos.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Position : TopBottomType
{
    private const string tagName = "pos";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10940;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the Position class.
    /// </summary>
    public Position():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Position>(deep);
    }

}
/// <summary>
/// <para>Vertical Justification.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:vertJc.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class VerticalJustification : TopBottomType
{
    private const string tagName = "vertJc";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10973;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the VerticalJustification class.
    /// </summary>
    public VerticalJustification():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<VerticalJustification>(deep);
    }

}
/// <summary>
/// Defines the TopBottomType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class TopBottomType : OpenXmlLeafElement
{
    private static string[] attributeTagNames = { "val" };
    private static byte[] attributeNamespaceIds = { 21 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    
    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public EnumValue<DocumentFormat.OpenXml.Math.VerticalJustificationValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Math.VerticalJustificationValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "val" == name)
    return new EnumValue<DocumentFormat.OpenXml.Math.VerticalJustificationValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

    
    /// <summary>
    /// Initializes a new instance of the TopBottomType class.
    /// </summary>
    protected TopBottomType(){}
    
    
    
}
/// <summary>
/// <para>Bar Properties.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:barPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Position &lt;m:pos></description></item>
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Position))]
    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class BarProperties : OpenXmlCompositeElement
{
    private const string tagName = "barPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10941;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Position (Bar).</para>
    /// <para> Represents the following element tag in the schema: m:pos </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public Position Position
    {
        get 
        {
            return GetElement<Position>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<ControlProperties>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<BarProperties>(deep);
    }

   
}
/// <summary>
/// <para>Box Properties.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(OperatorEmulator))]
    [ChildElementInfo(typeof(NoBreak))]
    [ChildElementInfo(typeof(Differential))]
    [ChildElementInfo(typeof(Break))]
    [ChildElementInfo(typeof(Alignment))]
    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class BoxProperties : OpenXmlCompositeElement
{
    private const string tagName = "boxPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10945;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Operator Emulator.</para>
    /// <para> Represents the following element tag in the schema: m:opEmu </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public OperatorEmulator OperatorEmulator
    {
        get 
        {
            return GetElement<OperatorEmulator>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<NoBreak>(1);
        }
        set
        {
            SetElement(1, value);
        }
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
        get 
        {
            return GetElement<Differential>(2);
        }
        set
        {
            SetElement(2, value);
        }
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
        get 
        {
            return GetElement<Break>(3);
        }
        set
        {
            SetElement(3, value);
        }
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
        get 
        {
            return GetElement<Alignment>(4);
        }
        set
        {
            SetElement(4, value);
        }
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
        get 
        {
            return GetElement<ControlProperties>(5);
        }
        set
        {
            SetElement(5, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<BoxProperties>(deep);
    }

   
}
/// <summary>
/// <para>Border Box Properties.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(HideTop))]
    [ChildElementInfo(typeof(HideBottom))]
    [ChildElementInfo(typeof(HideLeft))]
    [ChildElementInfo(typeof(HideRight))]
    [ChildElementInfo(typeof(StrikeHorizontal))]
    [ChildElementInfo(typeof(StrikeVertical))]
    [ChildElementInfo(typeof(StrikeBottomLeftToTopRight))]
    [ChildElementInfo(typeof(StrikeTopLeftToBottomRight))]
    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class BorderBoxProperties : OpenXmlCompositeElement
{
    private const string tagName = "borderBoxPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10954;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Hide Top Edge.</para>
    /// <para> Represents the following element tag in the schema: m:hideTop </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public HideTop HideTop
    {
        get 
        {
            return GetElement<HideTop>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<HideBottom>(1);
        }
        set
        {
            SetElement(1, value);
        }
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
        get 
        {
            return GetElement<HideLeft>(2);
        }
        set
        {
            SetElement(2, value);
        }
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
        get 
        {
            return GetElement<HideRight>(3);
        }
        set
        {
            SetElement(3, value);
        }
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
        get 
        {
            return GetElement<StrikeHorizontal>(4);
        }
        set
        {
            SetElement(4, value);
        }
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
        get 
        {
            return GetElement<StrikeVertical>(5);
        }
        set
        {
            SetElement(5, value);
        }
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
        get 
        {
            return GetElement<StrikeBottomLeftToTopRight>(6);
        }
        set
        {
            SetElement(6, value);
        }
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
        get 
        {
            return GetElement<StrikeTopLeftToBottomRight>(7);
        }
        set
        {
            SetElement(7, value);
        }
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
        get 
        {
            return GetElement<ControlProperties>(8);
        }
        set
        {
            SetElement(8, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<BorderBoxProperties>(deep);
    }

   
}
/// <summary>
/// <para>Shape (Delimiters).</para>
/// <para> When the object is serialized out as xml, its qualified name is m:shp.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Shape : OpenXmlLeafElement
{
    private const string tagName = "shp";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10959;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "val" };
    private static byte[] attributeNamespaceIds = { 21 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public EnumValue<DocumentFormat.OpenXml.Math.ShapeDelimiterValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Math.ShapeDelimiterValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the Shape class.
    /// </summary>
    public Shape():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "val" == name)
    return new EnumValue<DocumentFormat.OpenXml.Math.ShapeDelimiterValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Shape>(deep);
    }

   
}
/// <summary>
/// <para>Delimiter Properties.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(BeginChar))]
    [ChildElementInfo(typeof(SeparatorChar))]
    [ChildElementInfo(typeof(EndChar))]
    [ChildElementInfo(typeof(GrowOperators))]
    [ChildElementInfo(typeof(Shape))]
    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class DelimiterProperties : OpenXmlCompositeElement
{
    private const string tagName = "dPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10960;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Delimiter Beginning Character.</para>
    /// <para> Represents the following element tag in the schema: m:begChr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public BeginChar BeginChar
    {
        get 
        {
            return GetElement<BeginChar>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<SeparatorChar>(1);
        }
        set
        {
            SetElement(1, value);
        }
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
        get 
        {
            return GetElement<EndChar>(2);
        }
        set
        {
            SetElement(2, value);
        }
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
        get 
        {
            return GetElement<GrowOperators>(3);
        }
        set
        {
            SetElement(3, value);
        }
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
        get 
        {
            return GetElement<Shape>(4);
        }
        set
        {
            SetElement(4, value);
        }
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
        get 
        {
            return GetElement<ControlProperties>(5);
        }
        set
        {
            SetElement(5, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<DelimiterProperties>(deep);
    }

   
}
/// <summary>
/// <para>Equation Array Base Justification.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:baseJc.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class BaseJustification : OpenXmlLeafElement
{
    private const string tagName = "baseJc";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10961;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "val" };
    private static byte[] attributeNamespaceIds = { 21 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public EnumValue<DocumentFormat.OpenXml.Math.VerticalAlignmentValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Math.VerticalAlignmentValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BaseJustification class.
    /// </summary>
    public BaseJustification():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "val" == name)
    return new EnumValue<DocumentFormat.OpenXml.Math.VerticalAlignmentValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<BaseJustification>(deep);
    }

   
}
/// <summary>
/// <para>Row Spacing Rule.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:rSpRule.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class RowSpacingRule : SpacingRuleType
{
    private const string tagName = "rSpRule";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10964;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the RowSpacingRule class.
    /// </summary>
    public RowSpacingRule():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RowSpacingRule>(deep);
    }

}
/// <summary>
/// <para>Matrix Column Gap Rule.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:cGpRule.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ColumnGapRule : SpacingRuleType
{
    private const string tagName = "cGpRule";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10983;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the ColumnGapRule class.
    /// </summary>
    public ColumnGapRule():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ColumnGapRule>(deep);
    }

}
/// <summary>
/// Defines the SpacingRuleType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class SpacingRuleType : OpenXmlLeafElement
{
    private static string[] attributeTagNames = { "val" };
    private static byte[] attributeNamespaceIds = { 21 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    
    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public IntegerValue Val
    {
        get { return (IntegerValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "val" == name)
    return new IntegerValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

    
    /// <summary>
    /// Initializes a new instance of the SpacingRuleType class.
    /// </summary>
    protected SpacingRuleType(){}
    
    
    
}
/// <summary>
/// <para>Row Spacing (Equation Array).</para>
/// <para> When the object is serialized out as xml, its qualified name is m:rSp.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class RowSpacing : UnsignedShortType
{
    private const string tagName = "rSp";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10965;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the RowSpacing class.
    /// </summary>
    public RowSpacing():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RowSpacing>(deep);
    }

}
/// <summary>
/// <para>Matrix Column Gap.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:cGp.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ColumnGap : UnsignedShortType
{
    private const string tagName = "cGp";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10985;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the ColumnGap class.
    /// </summary>
    public ColumnGap():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ColumnGap>(deep);
    }

}
/// <summary>
/// Defines the UnsignedShortType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class UnsignedShortType : OpenXmlLeafElement
{
    private static string[] attributeTagNames = { "val" };
    private static byte[] attributeNamespaceIds = { 21 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    
    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public UInt16Value Val
    {
        get { return (UInt16Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "val" == name)
    return new UInt16Value();
    

    
    return base.AttributeFactory(namespaceId, name);
}

    
    /// <summary>
    /// Initializes a new instance of the UnsignedShortType class.
    /// </summary>
    protected UnsignedShortType(){}
    
    
    
}
/// <summary>
/// <para>Equation Array Properties.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(BaseJustification))]
    [ChildElementInfo(typeof(MaxDistribution))]
    [ChildElementInfo(typeof(ObjectDistribution))]
    [ChildElementInfo(typeof(RowSpacingRule))]
    [ChildElementInfo(typeof(RowSpacing))]
    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class EquationArrayProperties : OpenXmlCompositeElement
{
    private const string tagName = "eqArrPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10966;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Equation Array Base Justification.</para>
    /// <para> Represents the following element tag in the schema: m:baseJc </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public BaseJustification BaseJustification
    {
        get 
        {
            return GetElement<BaseJustification>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<MaxDistribution>(1);
        }
        set
        {
            SetElement(1, value);
        }
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
        get 
        {
            return GetElement<ObjectDistribution>(2);
        }
        set
        {
            SetElement(2, value);
        }
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
        get 
        {
            return GetElement<RowSpacingRule>(3);
        }
        set
        {
            SetElement(3, value);
        }
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
        get 
        {
            return GetElement<RowSpacing>(4);
        }
        set
        {
            SetElement(4, value);
        }
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
        get 
        {
            return GetElement<ControlProperties>(5);
        }
        set
        {
            SetElement(5, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<EquationArrayProperties>(deep);
    }

   
}
/// <summary>
/// <para>Fraction type.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:type.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class FractionType : OpenXmlLeafElement
{
    private const string tagName = "type";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10967;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "val" };
    private static byte[] attributeNamespaceIds = { 21 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public EnumValue<DocumentFormat.OpenXml.Math.FractionTypeValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Math.FractionTypeValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the FractionType class.
    /// </summary>
    public FractionType():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "val" == name)
    return new EnumValue<DocumentFormat.OpenXml.Math.FractionTypeValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<FractionType>(deep);
    }

   
}
/// <summary>
/// <para>Fraction Properties.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:fPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>FractionType &lt;m:type></description></item>
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(FractionType))]
    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class FractionProperties : OpenXmlCompositeElement
{
    private const string tagName = "fPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10968;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Fraction type.</para>
    /// <para> Represents the following element tag in the schema: m:type </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public FractionType FractionType
    {
        get 
        {
            return GetElement<FractionType>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<ControlProperties>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<FractionProperties>(deep);
    }

   
}
/// <summary>
/// <para>Function Properties.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:funcPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class FunctionProperties : OpenXmlCompositeElement
{
    private const string tagName = "funcPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10971;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
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
        get 
        {
            return GetElement<ControlProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<FunctionProperties>(deep);
    }

   
}
/// <summary>
/// <para>Group-Character Properties.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(AccentChar))]
    [ChildElementInfo(typeof(Position))]
    [ChildElementInfo(typeof(VerticalJustification))]
    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class GroupCharProperties : OpenXmlCompositeElement
{
    private const string tagName = "groupChrPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10974;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Group Character (Grouping Character).</para>
    /// <para> Represents the following element tag in the schema: m:chr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public AccentChar AccentChar
    {
        get 
        {
            return GetElement<AccentChar>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<Position>(1);
        }
        set
        {
            SetElement(1, value);
        }
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
        get 
        {
            return GetElement<VerticalJustification>(2);
        }
        set
        {
            SetElement(2, value);
        }
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
        get 
        {
            return GetElement<ControlProperties>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<GroupCharProperties>(deep);
    }

   
}
/// <summary>
/// <para>Lower Limit Properties.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:limLowPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class LimitLowerProperties : OpenXmlCompositeElement
{
    private const string tagName = "limLowPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10975;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
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
        get 
        {
            return GetElement<ControlProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<LimitLowerProperties>(deep);
    }

   
}
/// <summary>
/// <para>Upper Limit Properties.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:limUppPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class LimitUpperProperties : OpenXmlCompositeElement
{
    private const string tagName = "limUppPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10977;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
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
        get 
        {
            return GetElement<ControlProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<LimitUpperProperties>(deep);
    }

   
}
/// <summary>
/// <para>Matrix Column Count.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:count.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class MatrixColumnCount : OpenXmlLeafElement
{
    private const string tagName = "count";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10978;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "val" };
    private static byte[] attributeNamespaceIds = { 21 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public IntegerValue Val
    {
        get { return (IntegerValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the MatrixColumnCount class.
    /// </summary>
    public MatrixColumnCount():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "val" == name)
    return new IntegerValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<MatrixColumnCount>(deep);
    }

   
}
/// <summary>
/// <para>Matrix Column Justification.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:mcJc.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class MatrixColumnJustification : OpenXmlLeafElement
{
    private const string tagName = "mcJc";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10979;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "val" };
    private static byte[] attributeNamespaceIds = { 21 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public EnumValue<DocumentFormat.OpenXml.Math.HorizontalAlignmentValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Math.HorizontalAlignmentValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the MatrixColumnJustification class.
    /// </summary>
    public MatrixColumnJustification():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "val" == name)
    return new EnumValue<DocumentFormat.OpenXml.Math.HorizontalAlignmentValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<MatrixColumnJustification>(deep);
    }

   
}
/// <summary>
/// <para>Matrix Column Properties.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:mcPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>MatrixColumnCount &lt;m:count></description></item>
///<item><description>MatrixColumnJustification &lt;m:mcJc></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(MatrixColumnCount))]
    [ChildElementInfo(typeof(MatrixColumnJustification))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class MatrixColumnProperties : OpenXmlCompositeElement
{
    private const string tagName = "mcPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10980;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Matrix Column Count.</para>
    /// <para> Represents the following element tag in the schema: m:count </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public MatrixColumnCount MatrixColumnCount
    {
        get 
        {
            return GetElement<MatrixColumnCount>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<MatrixColumnJustification>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<MatrixColumnProperties>(deep);
    }

   
}
/// <summary>
/// <para>Matrix Column.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:mc.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>MatrixColumnProperties &lt;m:mcPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(MatrixColumnProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class MatrixColumn : OpenXmlCompositeElement
{
    private const string tagName = "mc";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10981;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Matrix Column Properties.</para>
    /// <para> Represents the following element tag in the schema: m:mcPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public MatrixColumnProperties MatrixColumnProperties
    {
        get 
        {
            return GetElement<MatrixColumnProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<MatrixColumn>(deep);
    }

   
}
/// <summary>
/// <para>Matrix Column Spacing.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:cSp.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ColumnSpacing : TwipsMeasureType
{
    private const string tagName = "cSp";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10984;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the ColumnSpacing class.
    /// </summary>
    public ColumnSpacing():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ColumnSpacing>(deep);
    }

}
/// <summary>
/// <para>Left Margin.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:lMargin.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class LeftMargin : TwipsMeasureType
{
    private const string tagName = "lMargin";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11017;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the LeftMargin class.
    /// </summary>
    public LeftMargin():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<LeftMargin>(deep);
    }

}
/// <summary>
/// <para>Right Margin.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:rMargin.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class RightMargin : TwipsMeasureType
{
    private const string tagName = "rMargin";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11018;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the RightMargin class.
    /// </summary>
    public RightMargin():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RightMargin>(deep);
    }

}
/// <summary>
/// <para>Pre-Equation Spacing.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:preSp.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class PreSpacing : TwipsMeasureType
{
    private const string tagName = "preSp";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11020;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the PreSpacing class.
    /// </summary>
    public PreSpacing():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<PreSpacing>(deep);
    }

}
/// <summary>
/// <para>Post-Equation Spacing.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:postSp.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class PostSpacing : TwipsMeasureType
{
    private const string tagName = "postSp";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11021;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the PostSpacing class.
    /// </summary>
    public PostSpacing():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<PostSpacing>(deep);
    }

}
/// <summary>
/// <para>Inter-Equation Spacing.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:interSp.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class InterSpacing : TwipsMeasureType
{
    private const string tagName = "interSp";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11022;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the InterSpacing class.
    /// </summary>
    public InterSpacing():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<InterSpacing>(deep);
    }

}
/// <summary>
/// <para>Intra-Equation Spacing.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:intraSp.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class IntraSpacing : TwipsMeasureType
{
    private const string tagName = "intraSp";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11023;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the IntraSpacing class.
    /// </summary>
    public IntraSpacing():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<IntraSpacing>(deep);
    }

}
/// <summary>
/// <para>Wrap Indent.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:wrapIndent.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class WrapIndent : TwipsMeasureType
{
    private const string tagName = "wrapIndent";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11024;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the WrapIndent class.
    /// </summary>
    public WrapIndent():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<WrapIndent>(deep);
    }

}
/// <summary>
/// Defines the TwipsMeasureType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class TwipsMeasureType : OpenXmlLeafElement
{
    private static string[] attributeTagNames = { "val" };
    private static byte[] attributeNamespaceIds = { 21 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    
    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public UInt32Value Val
    {
        get { return (UInt32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "val" == name)
    return new UInt32Value();
    

    
    return base.AttributeFactory(namespaceId, name);
}

    
    /// <summary>
    /// Initializes a new instance of the TwipsMeasureType class.
    /// </summary>
    protected TwipsMeasureType(){}
    
    
    
}
/// <summary>
/// <para>Matrix Columns.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:mcs.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>MatrixColumn &lt;m:mc></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(MatrixColumn))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class MatrixColumns : OpenXmlCompositeElement
{
    private const string tagName = "mcs";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10986;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<MatrixColumns>(deep);
    }

   
}
/// <summary>
/// <para>Matrix Properties.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(BaseJustification))]
    [ChildElementInfo(typeof(HidePlaceholder))]
    [ChildElementInfo(typeof(RowSpacingRule))]
    [ChildElementInfo(typeof(ColumnGapRule))]
    [ChildElementInfo(typeof(RowSpacing))]
    [ChildElementInfo(typeof(ColumnSpacing))]
    [ChildElementInfo(typeof(ColumnGap))]
    [ChildElementInfo(typeof(MatrixColumns))]
    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class MatrixProperties : OpenXmlCompositeElement
{
    private const string tagName = "mPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10987;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Matrix Base Justification.</para>
    /// <para> Represents the following element tag in the schema: m:baseJc </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public BaseJustification BaseJustification
    {
        get 
        {
            return GetElement<BaseJustification>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<HidePlaceholder>(1);
        }
        set
        {
            SetElement(1, value);
        }
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
        get 
        {
            return GetElement<RowSpacingRule>(2);
        }
        set
        {
            SetElement(2, value);
        }
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
        get 
        {
            return GetElement<ColumnGapRule>(3);
        }
        set
        {
            SetElement(3, value);
        }
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
        get 
        {
            return GetElement<RowSpacing>(4);
        }
        set
        {
            SetElement(4, value);
        }
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
        get 
        {
            return GetElement<ColumnSpacing>(5);
        }
        set
        {
            SetElement(5, value);
        }
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
        get 
        {
            return GetElement<ColumnGap>(6);
        }
        set
        {
            SetElement(6, value);
        }
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
        get 
        {
            return GetElement<MatrixColumns>(7);
        }
        set
        {
            SetElement(7, value);
        }
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
        get 
        {
            return GetElement<ControlProperties>(8);
        }
        set
        {
            SetElement(8, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<MatrixProperties>(deep);
    }

   
}
/// <summary>
/// <para>Matrix Row.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:mr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Base &lt;m:e></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Base))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class MatrixRow : OpenXmlCompositeElement
{
    private const string tagName = "mr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10988;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<MatrixRow>(deep);
    }

   
}
/// <summary>
/// <para>n-ary Limit Location.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:limLoc.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class LimitLocation : LimitLocationType
{
    private const string tagName = "limLoc";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10989;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the LimitLocation class.
    /// </summary>
    public LimitLocation():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<LimitLocation>(deep);
    }

}
/// <summary>
/// <para>Integral Limit Locations.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:intLim.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class IntegralLimitLocation : LimitLocationType
{
    private const string tagName = "intLim";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11026;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the IntegralLimitLocation class.
    /// </summary>
    public IntegralLimitLocation():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<IntegralLimitLocation>(deep);
    }

}
/// <summary>
/// <para>n-ary Limit Location.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:naryLim.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class NaryLimitLocation : LimitLocationType
{
    private const string tagName = "naryLim";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11027;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the NaryLimitLocation class.
    /// </summary>
    public NaryLimitLocation():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<NaryLimitLocation>(deep);
    }

}
/// <summary>
/// Defines the LimitLocationType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class LimitLocationType : OpenXmlLeafElement
{
    private static string[] attributeTagNames = { "val" };
    private static byte[] attributeNamespaceIds = { 21 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    
    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public EnumValue<DocumentFormat.OpenXml.Math.LimitLocationValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Math.LimitLocationValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "val" == name)
    return new EnumValue<DocumentFormat.OpenXml.Math.LimitLocationValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

    
    /// <summary>
    /// Initializes a new instance of the LimitLocationType class.
    /// </summary>
    protected LimitLocationType(){}
    
    
    
}
/// <summary>
/// <para>n-ary Properties.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(AccentChar))]
    [ChildElementInfo(typeof(LimitLocation))]
    [ChildElementInfo(typeof(GrowOperators))]
    [ChildElementInfo(typeof(HideSubArgument))]
    [ChildElementInfo(typeof(HideSuperArgument))]
    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class NaryProperties : OpenXmlCompositeElement
{
    private const string tagName = "naryPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10992;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> n-ary Operator Character.</para>
    /// <para> Represents the following element tag in the schema: m:chr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public AccentChar AccentChar
    {
        get 
        {
            return GetElement<AccentChar>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<LimitLocation>(1);
        }
        set
        {
            SetElement(1, value);
        }
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
        get 
        {
            return GetElement<GrowOperators>(2);
        }
        set
        {
            SetElement(2, value);
        }
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
        get 
        {
            return GetElement<HideSubArgument>(3);
        }
        set
        {
            SetElement(3, value);
        }
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
        get 
        {
            return GetElement<HideSuperArgument>(4);
        }
        set
        {
            SetElement(4, value);
        }
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
        get 
        {
            return GetElement<ControlProperties>(5);
        }
        set
        {
            SetElement(5, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<NaryProperties>(deep);
    }

   
}
/// <summary>
/// <para>Phantom Properties.</para>
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
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ShowPhantom))]
    [ChildElementInfo(typeof(ZeroWidth))]
    [ChildElementInfo(typeof(ZeroAscent))]
    [ChildElementInfo(typeof(ZeroDescent))]
    [ChildElementInfo(typeof(Transparent))]
    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class PhantomProperties : OpenXmlCompositeElement
{
    private const string tagName = "phantPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11000;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Phantom Show.</para>
    /// <para> Represents the following element tag in the schema: m:show </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public ShowPhantom ShowPhantom
    {
        get 
        {
            return GetElement<ShowPhantom>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<ZeroWidth>(1);
        }
        set
        {
            SetElement(1, value);
        }
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
        get 
        {
            return GetElement<ZeroAscent>(2);
        }
        set
        {
            SetElement(2, value);
        }
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
        get 
        {
            return GetElement<ZeroDescent>(3);
        }
        set
        {
            SetElement(3, value);
        }
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
        get 
        {
            return GetElement<Transparent>(4);
        }
        set
        {
            SetElement(4, value);
        }
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
        get 
        {
            return GetElement<ControlProperties>(5);
        }
        set
        {
            SetElement(5, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<PhantomProperties>(deep);
    }

   
}
/// <summary>
/// <para>Radical Properties.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:radPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>HideDegree &lt;m:degHide></description></item>
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(HideDegree))]
    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class RadicalProperties : OpenXmlCompositeElement
{
    private const string tagName = "radPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11002;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Hide Degree.</para>
    /// <para> Represents the following element tag in the schema: m:degHide </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public HideDegree HideDegree
    {
        get 
        {
            return GetElement<HideDegree>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<ControlProperties>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<RadicalProperties>(deep);
    }

   
}
/// <summary>
/// <para>Pre-Sub-Superscript Properties.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:sPrePr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class PreSubSuperProperties : OpenXmlCompositeElement
{
    private const string tagName = "sPrePr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11004;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
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
        get 
        {
            return GetElement<ControlProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<PreSubSuperProperties>(deep);
    }

   
}
/// <summary>
/// <para>Subscript Properties.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:sSubPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class SubscriptProperties : OpenXmlCompositeElement
{
    private const string tagName = "sSubPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11005;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
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
        get 
        {
            return GetElement<ControlProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<SubscriptProperties>(deep);
    }

   
}
/// <summary>
/// <para>Sub-Superscript Properties.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:sSubSupPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>AlignScripts &lt;m:alnScr></description></item>
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(AlignScripts))]
    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class SubSuperscriptProperties : OpenXmlCompositeElement
{
    private const string tagName = "sSubSupPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11007;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Align Scripts.</para>
    /// <para> Represents the following element tag in the schema: m:alnScr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public AlignScripts AlignScripts
    {
        get 
        {
            return GetElement<AlignScripts>(0);
        }
        set
        {
            SetElement(0, value);
        }
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
        get 
        {
            return GetElement<ControlProperties>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<SubSuperscriptProperties>(deep);
    }

   
}
/// <summary>
/// <para>Superscript Properties.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:sSupPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ControlProperties &lt;m:ctrlPr></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ControlProperties))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class SuperscriptProperties : OpenXmlCompositeElement
{
    private const string tagName = "sSupPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11008;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
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
        get 
        {
            return GetElement<ControlProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<SuperscriptProperties>(deep);
    }

   
}
/// <summary>
/// <para>Argument Size.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:argSz.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ArgumentSize : OpenXmlLeafElement
{
    private const string tagName = "argSz";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11009;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "val" };
    private static byte[] attributeNamespaceIds = { 21 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public IntegerValue Val
    {
        get { return (IntegerValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ArgumentSize class.
    /// </summary>
    public ArgumentSize():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "val" == name)
    return new IntegerValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ArgumentSize>(deep);
    }

   
}
/// <summary>
/// <para>Argument Properties.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:argPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ArgumentSize &lt;m:argSz></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(ArgumentSize))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ArgumentProperties : OpenXmlCompositeElement
{
    private const string tagName = "argPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11010;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Argument Size.</para>
    /// <para> Represents the following element tag in the schema: m:argSz </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public ArgumentSize ArgumentSize
    {
        get 
        {
            return GetElement<ArgumentSize>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ArgumentProperties>(deep);
    }

   
}
/// <summary>
/// <para>Justification.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:jc.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class Justification : OfficeMathJustificationType
{
    private const string tagName = "jc";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11011;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the Justification class.
    /// </summary>
    public Justification():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<Justification>(deep);
    }

}
/// <summary>
/// <para>Default Justification.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:defJc.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class DefaultJustification : OfficeMathJustificationType
{
    private const string tagName = "defJc";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11019;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    /// <summary>
    /// Initializes a new instance of the DefaultJustification class.
    /// </summary>
    public DefaultJustification():base(){}
    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<DefaultJustification>(deep);
    }

}
/// <summary>
/// Defines the OfficeMathJustificationType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class OfficeMathJustificationType : OpenXmlLeafElement
{
    private static string[] attributeTagNames = { "val" };
    private static byte[] attributeNamespaceIds = { 21 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    
    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public EnumValue<DocumentFormat.OpenXml.Math.JustificationValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Math.JustificationValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "val" == name)
    return new EnumValue<DocumentFormat.OpenXml.Math.JustificationValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

    
    /// <summary>
    /// Initializes a new instance of the OfficeMathJustificationType class.
    /// </summary>
    protected OfficeMathJustificationType(){}
    
    
    
}
/// <summary>
/// <para>Math Font.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:mathFont.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class MathFont : OpenXmlLeafElement
{
    private const string tagName = "mathFont";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11012;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "val" };
    private static byte[] attributeNamespaceIds = { 21 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public StringValue Val
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the MathFont class.
    /// </summary>
    public MathFont():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "val" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<MathFont>(deep);
    }

   
}
/// <summary>
/// <para>Break on Binary Operators.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:brkBin.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class BreakBinary : OpenXmlLeafElement
{
    private const string tagName = "brkBin";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11013;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "val" };
    private static byte[] attributeNamespaceIds = { 21 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public EnumValue<DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BreakBinary class.
    /// </summary>
    public BreakBinary():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "val" == name)
    return new EnumValue<DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<BreakBinary>(deep);
    }

   
}
/// <summary>
/// <para>Break on Binary Subtraction.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:brkBinSub.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class BreakBinarySubtraction : OpenXmlLeafElement
{
    private const string tagName = "brkBinSub";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11014;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    private static string[] attributeTagNames = { "val" };
    private static byte[] attributeNamespaceIds = { 21 };
    
    internal override string[] AttributeTagNames {
        get{
            return attributeTagNames;
            }
    }
    
    internal override byte[] AttributeNamespaceIds {
        get{
            return attributeNamespaceIds;
            }
    }
    

    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    public EnumValue<DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues> Val
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BreakBinarySubtraction class.
    /// </summary>
    public BreakBinarySubtraction():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 21 == namespaceId && "val" == name)
    return new EnumValue<DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<BreakBinarySubtraction>(deep);
    }

   
}
/// <summary>
/// <para>Office Math Paragraph Properties.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:oMathParaPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>Justification &lt;m:jc></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(Justification))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class ParagraphProperties : OpenXmlCompositeElement
{
    private const string tagName = "oMathParaPr";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 21;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 11028;
    
    /// <summary>
    /// Gets the type ID of the element.
    /// </summary>
    internal override int ElementTypeId
    {
		get { return ElementTypeIdConst; }
    }
    
   
    /// <summary>
    /// Whether this element is available in a specific version of Office Application.
    /// </summary>
    /// <param name="version">The Office file format version.</param>
    /// <returns>Returns true if the element is defined in the specified version.</returns>
    internal override bool IsInVersion(FileFormatVersions version)
    {
		if((7 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
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
    
    internal override string[] ElementTagNames {
        get{
            return eleTagNames;
            }
    }
    
    internal override byte[] ElementNamespaceIds {
        get{
            return eleNamespaceIds;
            }
    }
    internal override OpenXmlCompositeType OpenXmlCompositeType
    {
        get {return OpenXmlCompositeType.OneSequence;}
    }
    
        /// <summary>
    /// <para> Justification.</para>
    /// <para> Represents the following element tag in the schema: m:jc </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
    public Justification Justification
    {
        get 
        {
            return GetElement<Justification>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<ParagraphProperties>(deep);
    }

   
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
 
 
