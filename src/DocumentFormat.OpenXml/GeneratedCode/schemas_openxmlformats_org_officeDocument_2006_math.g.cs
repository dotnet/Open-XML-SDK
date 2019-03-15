// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Framework;
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


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "scr")]
[Id(ElementTypeIdConst)]
public partial class Script : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10905;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Math.ScriptValues> Val { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "sty")]
[Id(ElementTypeIdConst)]
public partial class Style : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10906;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Math.StyleValues> Val { get; set; }
	

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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "r")]
[Id(ElementTypeIdConst)]
public partial class Run : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10907;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Run Properties.</para>
    /// <para> Represents the following element tag in the schema: m:rPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "acc")]
[Id(ElementTypeIdConst)]
public partial class Accent : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10908;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Accent Properties.</para>
    /// <para> Represents the following element tag in the schema: m:accPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "bar")]
[Id(ElementTypeIdConst)]
public partial class Bar : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10909;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Bar Properties.</para>
    /// <para> Represents the following element tag in the schema: m:barPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "box")]
[Id(ElementTypeIdConst)]
public partial class Box : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10910;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Box Properties.</para>
    /// <para> Represents the following element tag in the schema: m:boxPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "borderBox")]
[Id(ElementTypeIdConst)]
public partial class BorderBox : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10911;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Border Box Properties.</para>
    /// <para> Represents the following element tag in the schema: m:borderBoxPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "d")]
[Id(ElementTypeIdConst)]
public partial class Delimiter : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10912;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Delimiter Properties.</para>
    /// <para> Represents the following element tag in the schema: m:dPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "eqArr")]
[Id(ElementTypeIdConst)]
public partial class EquationArray : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10913;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Equation Array Properties.</para>
    /// <para> Represents the following element tag in the schema: m:eqArrPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "f")]
[Id(ElementTypeIdConst)]
public partial class Fraction : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10914;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Fraction Properties.</para>
    /// <para> Represents the following element tag in the schema: m:fPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "func")]
[Id(ElementTypeIdConst)]
public partial class MathFunction : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10915;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Function Properties.</para>
    /// <para> Represents the following element tag in the schema: m:funcPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "groupChr")]
[Id(ElementTypeIdConst)]
public partial class GroupChar : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10916;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Group-Character Properties.</para>
    /// <para> Represents the following element tag in the schema: m:groupChrPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "limLow")]
[Id(ElementTypeIdConst)]
public partial class LimitLower : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10917;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Lower Limit Properties.</para>
    /// <para> Represents the following element tag in the schema: m:limLowPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "limUpp")]
[Id(ElementTypeIdConst)]
public partial class LimitUpper : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10918;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Upper Limit Properties.</para>
    /// <para> Represents the following element tag in the schema: m:limUppPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "m")]
[Id(ElementTypeIdConst)]
public partial class Matrix : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10919;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Matrix Properties.</para>
    /// <para> Represents the following element tag in the schema: m:mPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "nary")]
[Id(ElementTypeIdConst)]
public partial class Nary : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10920;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> n-ary Properties.</para>
    /// <para> Represents the following element tag in the schema: m:naryPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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
	[Index(3)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "phant")]
[Id(ElementTypeIdConst)]
public partial class Phantom : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10921;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Phantom Properties.</para>
    /// <para> Represents the following element tag in the schema: m:phantPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "rad")]
[Id(ElementTypeIdConst)]
public partial class Radical : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10922;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Radical Properties.</para>
    /// <para> Represents the following element tag in the schema: m:radPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "sPre")]
[Id(ElementTypeIdConst)]
public partial class PreSubSuper : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10923;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Pre-Sub-Superscript Properties.</para>
    /// <para> Represents the following element tag in the schema: m:sPrePr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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
	[Index(3)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "sSub")]
[Id(ElementTypeIdConst)]
public partial class Subscript : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10924;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Subscript Properties.</para>
    /// <para> Represents the following element tag in the schema: m:sSubPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "sSubSup")]
[Id(ElementTypeIdConst)]
public partial class SubSuperscript : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10925;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Sub-Superscript Properties.</para>
    /// <para> Represents the following element tag in the schema: m:sSubSupPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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
	[Index(3)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "sSup")]
[Id(ElementTypeIdConst)]
public partial class Superscript : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10926;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Superscript Properties.</para>
    /// <para> Represents the following element tag in the schema: m:sSupPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "oMathPara")]
[Id(ElementTypeIdConst)]
public partial class Paragraph : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10927;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Office Math Paragraph Properties.</para>
    /// <para> Represents the following element tag in the schema: m:oMathParaPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "oMath")]
[Id(ElementTypeIdConst)]
public partial class OfficeMath : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10928;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "mathPr")]
[Id(ElementTypeIdConst)]
public partial class MathProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10929;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Math Font.</para>
    /// <para> Represents the following element tag in the schema: m:mathFont </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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
	[Index(3)]
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
	[Index(4)]
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
	[Index(5)]
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
	[Index(6)]
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
	[Index(7)]
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
	[Index(8)]
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
	[Index(9)]
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
	[Index(10)]
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
	[Index(11)]
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

[SchemaAttr(21, "lit")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Literal : OnOffType
{
    internal const int ElementTypeIdConst = 10930;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "nor")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class NormalText : OnOffType
{
    internal const int ElementTypeIdConst = 10931;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "aln")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Alignment : OnOffType
{
    internal const int ElementTypeIdConst = 10933;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "opEmu")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class OperatorEmulator : OnOffType
{
    internal const int ElementTypeIdConst = 10942;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "noBreak")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class NoBreak : OnOffType
{
    internal const int ElementTypeIdConst = 10943;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "diff")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Differential : OnOffType
{
    internal const int ElementTypeIdConst = 10944;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "hideTop")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class HideTop : OnOffType
{
    internal const int ElementTypeIdConst = 10946;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "hideBot")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class HideBottom : OnOffType
{
    internal const int ElementTypeIdConst = 10947;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "hideLeft")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class HideLeft : OnOffType
{
    internal const int ElementTypeIdConst = 10948;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "hideRight")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class HideRight : OnOffType
{
    internal const int ElementTypeIdConst = 10949;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "strikeH")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class StrikeHorizontal : OnOffType
{
    internal const int ElementTypeIdConst = 10950;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "strikeV")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class StrikeVertical : OnOffType
{
    internal const int ElementTypeIdConst = 10951;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "strikeBLTR")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class StrikeBottomLeftToTopRight : OnOffType
{
    internal const int ElementTypeIdConst = 10952;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "strikeTLBR")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class StrikeTopLeftToBottomRight : OnOffType
{
    internal const int ElementTypeIdConst = 10953;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "grow")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class GrowOperators : OnOffType
{
    internal const int ElementTypeIdConst = 10958;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "maxDist")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class MaxDistribution : OnOffType
{
    internal const int ElementTypeIdConst = 10962;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "objDist")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ObjectDistribution : OnOffType
{
    internal const int ElementTypeIdConst = 10963;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "plcHide")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class HidePlaceholder : OnOffType
{
    internal const int ElementTypeIdConst = 10982;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "subHide")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class HideSubArgument : OnOffType
{
    internal const int ElementTypeIdConst = 10990;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "supHide")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class HideSuperArgument : OnOffType
{
    internal const int ElementTypeIdConst = 10991;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "show")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ShowPhantom : OnOffType
{
    internal const int ElementTypeIdConst = 10995;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "zeroWid")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ZeroWidth : OnOffType
{
    internal const int ElementTypeIdConst = 10996;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "zeroAsc")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ZeroAscent : OnOffType
{
    internal const int ElementTypeIdConst = 10997;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "zeroDesc")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ZeroDescent : OnOffType
{
    internal const int ElementTypeIdConst = 10998;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "transp")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Transparent : OnOffType
{
    internal const int ElementTypeIdConst = 10999;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "degHide")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class HideDegree : OnOffType
{
    internal const int ElementTypeIdConst = 11001;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "alnScr")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class AlignScripts : OnOffType
{
    internal const int ElementTypeIdConst = 11006;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "smallFrac")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SmallFraction : OnOffType
{
    internal const int ElementTypeIdConst = 11015;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "dispDef")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DisplayDefaults : OnOffType
{
    internal const int ElementTypeIdConst = 11016;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "wrapRight")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class WrapRight : OnOffType
{
    internal const int ElementTypeIdConst = 11025;
    internal override int ElementTypeId => ElementTypeIdConst;

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


public abstract partial class OnOffType : OpenXmlLeafElement
{
        
        /// <summary>
    /// <para> value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Math.BooleanValues> Val { get; set; }
	

    
    
    
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


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "brk")]
[Id(ElementTypeIdConst)]
public partial class Break : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10932;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Index of Operator to Align To.</para>
    /// <para>Represents the following attribute in the schema: m:alnAt </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "alnAt")]
    [Index(0)]
    public IntegerValue AlignAt { get; set; }
	
    /// <summary>
    /// <para> Index of Operator to Align To.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    [Index(1)]
    public IntegerValue Val { get; set; }
	

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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "rPr")]
[Id(ElementTypeIdConst)]
public partial class RunProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10934;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Literal.</para>
    /// <para> Represents the following element tag in the schema: m:lit </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "t")]
[Id(ElementTypeIdConst)]
public partial class Text : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 10935;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> space.</para>
    /// <para>Represents the following attribute in the schema: xml:space </para>
    /// </summary>
///<remark> xmlns:xml=http://www.w3.org/XML/1998/namespace
///</remark>
    [SchemaAttr(1, "space")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.SpaceProcessingModeValues> Space { get; set; }
	

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

[SchemaAttr(21, "chr")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class AccentChar : CharType
{
    internal const int ElementTypeIdConst = 10936;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "begChr")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class BeginChar : CharType
{
    internal const int ElementTypeIdConst = 10955;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "sepChr")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SeparatorChar : CharType
{
    internal const int ElementTypeIdConst = 10956;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "endChr")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class EndChar : CharType
{
    internal const int ElementTypeIdConst = 10957;
    internal override int ElementTypeId => ElementTypeIdConst;

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


public abstract partial class CharType : OpenXmlLeafElement
{
        
        /// <summary>
    /// <para> value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    [Index(0)]
    public StringValue Val { get; set; }
	

    
    
    
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "ctrlPr")]
[Id(ElementTypeIdConst)]
public partial class ControlProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10937;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "accPr")]
[Id(ElementTypeIdConst)]
public partial class AccentProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10938;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Accent Character.</para>
    /// <para> Represents the following element tag in the schema: m:chr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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

[SchemaAttr(21, "e")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Base : OfficeMathArgumentType
{
    internal const int ElementTypeIdConst = 10939;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "num")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Numerator : OfficeMathArgumentType
{
    internal const int ElementTypeIdConst = 10969;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "den")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Denominator : OfficeMathArgumentType
{
    internal const int ElementTypeIdConst = 10970;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "fName")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class FunctionName : OfficeMathArgumentType
{
    internal const int ElementTypeIdConst = 10972;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "lim")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Limit : OfficeMathArgumentType
{
    internal const int ElementTypeIdConst = 10976;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "sub")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SubArgument : OfficeMathArgumentType
{
    internal const int ElementTypeIdConst = 10993;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "sup")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class SuperArgument : OfficeMathArgumentType
{
    internal const int ElementTypeIdConst = 10994;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "deg")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Degree : OfficeMathArgumentType
{
    internal const int ElementTypeIdConst = 11003;
    internal override int ElementTypeId => ElementTypeIdConst;

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

public abstract partial class OfficeMathArgumentType : OpenXmlCompositeElement
{
        
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Argument Properties.</para>
    /// <para> Represents the following element tag in the schema: m:argPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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

[SchemaAttr(21, "pos")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Position : TopBottomType
{
    internal const int ElementTypeIdConst = 10940;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "vertJc")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class VerticalJustification : TopBottomType
{
    internal const int ElementTypeIdConst = 10973;
    internal override int ElementTypeId => ElementTypeIdConst;

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


public abstract partial class TopBottomType : OpenXmlLeafElement
{
        
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Math.VerticalJustificationValues> Val { get; set; }
	

    
    
    
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "barPr")]
[Id(ElementTypeIdConst)]
public partial class BarProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10941;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Position (Bar).</para>
    /// <para> Represents the following element tag in the schema: m:pos </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "boxPr")]
[Id(ElementTypeIdConst)]
public partial class BoxProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10945;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Operator Emulator.</para>
    /// <para> Represents the following element tag in the schema: m:opEmu </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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
	[Index(3)]
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
	[Index(4)]
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
	[Index(5)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "borderBoxPr")]
[Id(ElementTypeIdConst)]
public partial class BorderBoxProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10954;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Hide Top Edge.</para>
    /// <para> Represents the following element tag in the schema: m:hideTop </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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
	[Index(3)]
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
	[Index(4)]
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
	[Index(5)]
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
	[Index(6)]
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
	[Index(7)]
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
	[Index(8)]
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


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "shp")]
[Id(ElementTypeIdConst)]
public partial class Shape : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10959;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Math.ShapeDelimiterValues> Val { get; set; }
	

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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "dPr")]
[Id(ElementTypeIdConst)]
public partial class DelimiterProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10960;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Delimiter Beginning Character.</para>
    /// <para> Represents the following element tag in the schema: m:begChr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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
	[Index(3)]
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
	[Index(4)]
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
	[Index(5)]
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


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "baseJc")]
[Id(ElementTypeIdConst)]
public partial class BaseJustification : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10961;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Math.VerticalAlignmentValues> Val { get; set; }
	

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

[SchemaAttr(21, "rSpRule")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class RowSpacingRule : SpacingRuleType
{
    internal const int ElementTypeIdConst = 10964;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "cGpRule")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ColumnGapRule : SpacingRuleType
{
    internal const int ElementTypeIdConst = 10983;
    internal override int ElementTypeId => ElementTypeIdConst;

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


public abstract partial class SpacingRuleType : OpenXmlLeafElement
{
        
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    [Index(0)]
    public IntegerValue Val { get; set; }
	

    
    
    
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

[SchemaAttr(21, "rSp")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class RowSpacing : UnsignedShortType
{
    internal const int ElementTypeIdConst = 10965;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "cGp")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ColumnGap : UnsignedShortType
{
    internal const int ElementTypeIdConst = 10985;
    internal override int ElementTypeId => ElementTypeIdConst;

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


public abstract partial class UnsignedShortType : OpenXmlLeafElement
{
        
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    [Index(0)]
    public UInt16Value Val { get; set; }
	

    
    
    
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "eqArrPr")]
[Id(ElementTypeIdConst)]
public partial class EquationArrayProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10966;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Equation Array Base Justification.</para>
    /// <para> Represents the following element tag in the schema: m:baseJc </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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
	[Index(3)]
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
	[Index(4)]
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
	[Index(5)]
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


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "type")]
[Id(ElementTypeIdConst)]
public partial class FractionType : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10967;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Math.FractionTypeValues> Val { get; set; }
	

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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "fPr")]
[Id(ElementTypeIdConst)]
public partial class FractionProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10968;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Fraction type.</para>
    /// <para> Represents the following element tag in the schema: m:type </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "funcPr")]
[Id(ElementTypeIdConst)]
public partial class FunctionProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10971;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ControlProperties.</para>
    /// <para> Represents the following element tag in the schema: m:ctrlPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "groupChrPr")]
[Id(ElementTypeIdConst)]
public partial class GroupCharProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10974;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Group Character (Grouping Character).</para>
    /// <para> Represents the following element tag in the schema: m:chr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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
	[Index(3)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "limLowPr")]
[Id(ElementTypeIdConst)]
public partial class LimitLowerProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10975;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ControlProperties.</para>
    /// <para> Represents the following element tag in the schema: m:ctrlPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "limUppPr")]
[Id(ElementTypeIdConst)]
public partial class LimitUpperProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10977;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ControlProperties.</para>
    /// <para> Represents the following element tag in the schema: m:ctrlPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "count")]
[Id(ElementTypeIdConst)]
public partial class MatrixColumnCount : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10978;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    [Index(0)]
    public IntegerValue Val { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "mcJc")]
[Id(ElementTypeIdConst)]
public partial class MatrixColumnJustification : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 10979;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Math.HorizontalAlignmentValues> Val { get; set; }
	

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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "mcPr")]
[Id(ElementTypeIdConst)]
public partial class MatrixColumnProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10980;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Matrix Column Count.</para>
    /// <para> Represents the following element tag in the schema: m:count </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "mc")]
[Id(ElementTypeIdConst)]
public partial class MatrixColumn : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10981;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Matrix Column Properties.</para>
    /// <para> Represents the following element tag in the schema: m:mcPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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

[SchemaAttr(21, "cSp")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class ColumnSpacing : TwipsMeasureType
{
    internal const int ElementTypeIdConst = 10984;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "lMargin")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class LeftMargin : TwipsMeasureType
{
    internal const int ElementTypeIdConst = 11017;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "rMargin")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class RightMargin : TwipsMeasureType
{
    internal const int ElementTypeIdConst = 11018;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "preSp")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class PreSpacing : TwipsMeasureType
{
    internal const int ElementTypeIdConst = 11020;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "postSp")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class PostSpacing : TwipsMeasureType
{
    internal const int ElementTypeIdConst = 11021;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "interSp")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class InterSpacing : TwipsMeasureType
{
    internal const int ElementTypeIdConst = 11022;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "intraSp")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class IntraSpacing : TwipsMeasureType
{
    internal const int ElementTypeIdConst = 11023;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "wrapIndent")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class WrapIndent : TwipsMeasureType
{
    internal const int ElementTypeIdConst = 11024;
    internal override int ElementTypeId => ElementTypeIdConst;

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


public abstract partial class TwipsMeasureType : OpenXmlLeafElement
{
        
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    [Index(0)]
    public UInt32Value Val { get; set; }
	

    
    
    
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "mcs")]
[Id(ElementTypeIdConst)]
public partial class MatrixColumns : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10986;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "mPr")]
[Id(ElementTypeIdConst)]
public partial class MatrixProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10987;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Matrix Base Justification.</para>
    /// <para> Represents the following element tag in the schema: m:baseJc </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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
	[Index(3)]
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
	[Index(4)]
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
	[Index(5)]
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
	[Index(6)]
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
	[Index(7)]
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
	[Index(8)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "mr")]
[Id(ElementTypeIdConst)]
public partial class MatrixRow : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10988;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MatrixRow>(deep);

}
/// <summary>
/// <para>n-ary Limit Location.</para>
/// <para>This class is available in Office 2007 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is m:limLoc.</para>
/// </summary>

[SchemaAttr(21, "limLoc")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class LimitLocation : LimitLocationType
{
    internal const int ElementTypeIdConst = 10989;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "intLim")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class IntegralLimitLocation : LimitLocationType
{
    internal const int ElementTypeIdConst = 11026;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "naryLim")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class NaryLimitLocation : LimitLocationType
{
    internal const int ElementTypeIdConst = 11027;
    internal override int ElementTypeId => ElementTypeIdConst;

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


public abstract partial class LimitLocationType : OpenXmlLeafElement
{
        
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Math.LimitLocationValues> Val { get; set; }
	

    
    
    
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "naryPr")]
[Id(ElementTypeIdConst)]
public partial class NaryProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10992;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> n-ary Operator Character.</para>
    /// <para> Represents the following element tag in the schema: m:chr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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
	[Index(3)]
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
	[Index(4)]
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
	[Index(5)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "phantPr")]
[Id(ElementTypeIdConst)]
public partial class PhantomProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 11000;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Phantom Show.</para>
    /// <para> Represents the following element tag in the schema: m:show </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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
	[Index(2)]
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
	[Index(3)]
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
	[Index(4)]
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
	[Index(5)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "radPr")]
[Id(ElementTypeIdConst)]
public partial class RadicalProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 11002;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Hide Degree.</para>
    /// <para> Represents the following element tag in the schema: m:degHide </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "sPrePr")]
[Id(ElementTypeIdConst)]
public partial class PreSubSuperProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 11004;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ControlProperties.</para>
    /// <para> Represents the following element tag in the schema: m:ctrlPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "sSubPr")]
[Id(ElementTypeIdConst)]
public partial class SubscriptProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 11005;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ControlProperties.</para>
    /// <para> Represents the following element tag in the schema: m:ctrlPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "sSubSupPr")]
[Id(ElementTypeIdConst)]
public partial class SubSuperscriptProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 11007;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Align Scripts.</para>
    /// <para> Represents the following element tag in the schema: m:alnScr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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
	[Index(1)]
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "sSupPr")]
[Id(ElementTypeIdConst)]
public partial class SuperscriptProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 11008;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> ControlProperties.</para>
    /// <para> Represents the following element tag in the schema: m:ctrlPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "argSz")]
[Id(ElementTypeIdConst)]
public partial class ArgumentSize : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 11009;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    [Index(0)]
    public IntegerValue Val { get; set; }
	

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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "argPr")]
[Id(ElementTypeIdConst)]
public partial class ArgumentProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 11010;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Argument Size.</para>
    /// <para> Represents the following element tag in the schema: m:argSz </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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

[SchemaAttr(21, "jc")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class Justification : OfficeMathJustificationType
{
    internal const int ElementTypeIdConst = 11011;
    internal override int ElementTypeId => ElementTypeIdConst;

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

[SchemaAttr(21, "defJc")]
[Id(ElementTypeIdConst)]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class DefaultJustification : OfficeMathJustificationType
{
    internal const int ElementTypeIdConst = 11019;
    internal override int ElementTypeId => ElementTypeIdConst;

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


public abstract partial class OfficeMathJustificationType : OpenXmlLeafElement
{
        
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Math.JustificationValues> Val { get; set; }
	

    
    
    
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


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "mathFont")]
[Id(ElementTypeIdConst)]
public partial class MathFont : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 11012;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    [Index(0)]
    public StringValue Val { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "brkBin")]
[Id(ElementTypeIdConst)]
public partial class BreakBinary : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 11013;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues> Val { get; set; }
	

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


[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "brkBinSub")]
[Id(ElementTypeIdConst)]
public partial class BreakBinarySubtraction : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 11014;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
        /// <summary>
    /// <para> Value.</para>
    /// <para>Represents the following attribute in the schema: m:val </para>
    /// </summary>
///<remark> xmlns:m=http://schemas.openxmlformats.org/officeDocument/2006/math
///</remark>
    [SchemaAttr(21, "val")]
    [Index(0)]
    public EnumValue<DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues> Val { get; set; }
	

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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(21, "oMathParaPr")]
[Id(ElementTypeIdConst)]
public partial class ParagraphProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 11028;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Justification.</para>
    /// <para> Represents the following element tag in the schema: m:jc </para>
    /// </summary>
    /// <remark>
    /// xmlns:m = http://schemas.openxmlformats.org/officeDocument/2006/math
    /// </remark>
	[Index(0)]
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
 
 
