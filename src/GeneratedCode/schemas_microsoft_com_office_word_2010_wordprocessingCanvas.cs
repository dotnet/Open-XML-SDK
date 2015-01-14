// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Office2010.Word.DrawingGroup;
using DocumentFormat.OpenXml.Office2010.Word.DrawingShape;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2010.Word;
using DocumentFormat.OpenXml.Drawing.Pictures;

namespace DocumentFormat.OpenXml.Office2010.Word.DrawingCanvas
{
/// <summary>
/// <para>Defines the WordprocessingCanvas Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wpc:wpc.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BackgroundFormatting &lt;wpc:bg></description></item>
///<item><description>WholeFormatting &lt;wpc:whole></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.DrawingShape.WordprocessingShape &lt;wps:wsp></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Pictures.Picture &lt;pic:pic></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.ContentPart &lt;w14:contentPart></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.WordprocessingGroup &lt;wpg:wgp></description></item>
///<item><description>GraphicFrameType &lt;wpc:graphicFrame></description></item>
///<item><description>OfficeArtExtensionList &lt;wpc:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(BackgroundFormatting),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(WholeFormatting),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingShape.WordprocessingShape),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Pictures.Picture))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.ContentPart),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.WordprocessingGroup),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(GraphicFrameType),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(OfficeArtExtensionList),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class WordprocessingCanvas : OpenXmlCompositeElement
{
    private const string tagName = "wpc";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 59;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13182;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the WordprocessingCanvas class.
    /// </summary>
    public WordprocessingCanvas():base(){}
    
            /// <summary>
    ///Initializes a new instance of the WordprocessingCanvas class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WordprocessingCanvas(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the WordprocessingCanvas class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WordprocessingCanvas(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the WordprocessingCanvas class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public WordprocessingCanvas(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 59 == namespaceId && "bg" == name)
    return new BackgroundFormatting();
    
if( 59 == namespaceId && "whole" == name)
    return new WholeFormatting();
    
if( 61 == namespaceId && "wsp" == name)
    return new DocumentFormat.OpenXml.Office2010.Word.DrawingShape.WordprocessingShape();
    
if( 17 == namespaceId && "pic" == name)
    return new DocumentFormat.OpenXml.Drawing.Pictures.Picture();
    
if( 52 == namespaceId && "contentPart" == name)
    return new DocumentFormat.OpenXml.Office2010.Word.ContentPart();
    
if( 60 == namespaceId && "wgp" == name)
    return new DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.WordprocessingGroup();
    
if( 59 == namespaceId && "graphicFrame" == name)
    return new GraphicFrameType();
    
if( 59 == namespaceId && "extLst" == name)
    return new OfficeArtExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "bg","whole","wsp","pic","contentPart","wgp","graphicFrame","extLst" };
    private static readonly byte[] eleNamespaceIds = { 59,59,61,17,52,60,59,59 };
    
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
    /// <para> BackgroundFormatting.</para>
    /// <para> Represents the following element tag in the schema: wpc:bg </para>
    /// </summary>
    /// <remark>
    /// xmlns:wpc = http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas
    /// </remark>
    public BackgroundFormatting BackgroundFormatting
    {
        get 
        {
            return GetElement<BackgroundFormatting>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> WholeFormatting.</para>
    /// <para> Represents the following element tag in the schema: wpc:whole </para>
    /// </summary>
    /// <remark>
    /// xmlns:wpc = http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas
    /// </remark>
    public WholeFormatting WholeFormatting
    {
        get 
        {
            return GetElement<WholeFormatting>(1);
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
        return CloneImp<WordprocessingCanvas>(deep);
    }

   
}
/// <summary>
/// <para>Defines the BackgroundFormatting Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wpc:bg.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.NoFill &lt;a:noFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SolidFill &lt;a:solidFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.GradientFill &lt;a:gradFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.BlipFill &lt;a:blipFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.PatternFill &lt;a:pattFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.GroupFill &lt;a:grpFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.EffectList &lt;a:effectLst></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.EffectDag &lt;a:effectDag></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NoFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SolidFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GradientFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BlipFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PatternFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GroupFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectList))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectDag))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class BackgroundFormatting : OpenXmlCompositeElement
{
    private const string tagName = "bg";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 59;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13183;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the BackgroundFormatting class.
    /// </summary>
    public BackgroundFormatting():base(){}
    
            /// <summary>
    ///Initializes a new instance of the BackgroundFormatting class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackgroundFormatting(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the BackgroundFormatting class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public BackgroundFormatting(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the BackgroundFormatting class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public BackgroundFormatting(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "noFill" == name)
    return new DocumentFormat.OpenXml.Drawing.NoFill();
    
if( 10 == namespaceId && "solidFill" == name)
    return new DocumentFormat.OpenXml.Drawing.SolidFill();
    
if( 10 == namespaceId && "gradFill" == name)
    return new DocumentFormat.OpenXml.Drawing.GradientFill();
    
if( 10 == namespaceId && "blipFill" == name)
    return new DocumentFormat.OpenXml.Drawing.BlipFill();
    
if( 10 == namespaceId && "pattFill" == name)
    return new DocumentFormat.OpenXml.Drawing.PatternFill();
    
if( 10 == namespaceId && "grpFill" == name)
    return new DocumentFormat.OpenXml.Drawing.GroupFill();
    
if( 10 == namespaceId && "effectLst" == name)
    return new DocumentFormat.OpenXml.Drawing.EffectList();
    
if( 10 == namespaceId && "effectDag" == name)
    return new DocumentFormat.OpenXml.Drawing.EffectDag();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<BackgroundFormatting>(deep);
    }

   
}
/// <summary>
/// <para>Defines the WholeFormatting Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wpc:whole.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Outline &lt;a:ln></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.EffectList &lt;a:effectLst></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.EffectDag &lt;a:effectDag></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Outline))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectList))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectDag))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class WholeFormatting : OpenXmlCompositeElement
{
    private const string tagName = "whole";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 59;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13184;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the WholeFormatting class.
    /// </summary>
    public WholeFormatting():base(){}
    
            /// <summary>
    ///Initializes a new instance of the WholeFormatting class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WholeFormatting(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the WholeFormatting class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public WholeFormatting(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the WholeFormatting class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public WholeFormatting(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "ln" == name)
    return new DocumentFormat.OpenXml.Drawing.Outline();
    
if( 10 == namespaceId && "effectLst" == name)
    return new DocumentFormat.OpenXml.Drawing.EffectList();
    
if( 10 == namespaceId && "effectDag" == name)
    return new DocumentFormat.OpenXml.Drawing.EffectDag();
    

    return null;
}

        private static readonly string[] eleTagNames = { "ln","effectLst","effectDag" };
    private static readonly byte[] eleNamespaceIds = { 10,10,10 };
    
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
    /// <para> Outline.</para>
    /// <para> Represents the following element tag in the schema: a:ln </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Outline Outline
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Outline>(0);
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
        return CloneImp<WholeFormatting>(deep);
    }

   
}
/// <summary>
/// <para>Defines the GraphicFrameType Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wpc:graphicFrame.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualDrawingProperties &lt;wpg:cNvPr></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualGraphicFrameProperties &lt;wpg:cNvFrPr></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.Transform2D &lt;wpg:xfrm></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Graphic &lt;a:graphic></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.OfficeArtExtensionList &lt;wpg:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualDrawingProperties),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualGraphicFrameProperties),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.Transform2D),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Graphic))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.OfficeArtExtensionList),(FileFormatVersions)6)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class GraphicFrameType : OpenXmlCompositeElement
{
    private const string tagName = "graphicFrame";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 59;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13185;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the GraphicFrameType class.
    /// </summary>
    public GraphicFrameType():base(){}
    
            /// <summary>
    ///Initializes a new instance of the GraphicFrameType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GraphicFrameType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the GraphicFrameType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public GraphicFrameType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the GraphicFrameType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public GraphicFrameType(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 60 == namespaceId && "cNvPr" == name)
    return new DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualDrawingProperties();
    
if( 60 == namespaceId && "cNvFrPr" == name)
    return new DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualGraphicFrameProperties();
    
if( 60 == namespaceId && "xfrm" == name)
    return new DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.Transform2D();
    
if( 10 == namespaceId && "graphic" == name)
    return new DocumentFormat.OpenXml.Drawing.Graphic();
    
if( 60 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.OfficeArtExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "cNvPr","cNvFrPr","xfrm","graphic","extLst" };
    private static readonly byte[] eleNamespaceIds = { 60,60,60,10,60 };
    
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
    /// <para> NonVisualDrawingProperties.</para>
    /// <para> Represents the following element tag in the schema: wpg:cNvPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:wpg = http://schemas.microsoft.com/office/word/2010/wordprocessingGroup
    /// </remark>
    public DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualDrawingProperties NonVisualDrawingProperties
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualDrawingProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> NonVisualGraphicFrameProperties.</para>
    /// <para> Represents the following element tag in the schema: wpg:cNvFrPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:wpg = http://schemas.microsoft.com/office/word/2010/wordprocessingGroup
    /// </remark>
    public DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualGraphicFrameProperties NonVisualGraphicFrameProperties
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.NonVisualGraphicFrameProperties>(1);
        }
        set
        {
            SetElement(1, value);
        }
    }
    /// <summary>
    /// <para> Transform2D.</para>
    /// <para> Represents the following element tag in the schema: wpg:xfrm </para>
    /// </summary>
    /// <remark>
    /// xmlns:wpg = http://schemas.microsoft.com/office/word/2010/wordprocessingGroup
    /// </remark>
    public DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.Transform2D Transform2D
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.Transform2D>(2);
        }
        set
        {
            SetElement(2, value);
        }
    }
    /// <summary>
    /// <para> Graphic.</para>
    /// <para> Represents the following element tag in the schema: a:graphic </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Graphic Graphic
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.Graphic>(3);
        }
        set
        {
            SetElement(3, value);
        }
    }
    /// <summary>
    /// <para> OfficeArtExtensionList.</para>
    /// <para> Represents the following element tag in the schema: wpg:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:wpg = http://schemas.microsoft.com/office/word/2010/wordprocessingGroup
    /// </remark>
    public DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.OfficeArtExtensionList OfficeArtExtensionList
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Office2010.Word.DrawingGroup.OfficeArtExtensionList>(4);
        }
        set
        {
            SetElement(4, value);
        }
    }


    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<GraphicFrameType>(deep);
    }

   
}
/// <summary>
/// <para>Defines the OfficeArtExtensionList Class.</para>
///<para>This class is available in Office2010 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is wpc:extLst.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Extension &lt;a:ext></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Extension))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2010)]
public partial class OfficeArtExtensionList : OpenXmlCompositeElement
{
    private const string tagName = "extLst";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 59;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 13186;
    
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
		if((6 & (int)version) > 0)
		{
			return true;
		}
		return false;
    }
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the OfficeArtExtensionList class.
    /// </summary>
    public OfficeArtExtensionList():base(){}
    
            /// <summary>
    ///Initializes a new instance of the OfficeArtExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OfficeArtExtensionList(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the OfficeArtExtensionList class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public OfficeArtExtensionList(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the OfficeArtExtensionList class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public OfficeArtExtensionList(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "ext" == name)
    return new DocumentFormat.OpenXml.Drawing.Extension();
    

    return null;
}

    
    
        /// <summary>
    /// Creates a duplicate of this node.  
    /// </summary>
    /// <param name="deep">True to recursively clone the subtree under the specified node; false to clone only the node itself. </param>
    /// <returns>Returns the cloned node. </returns>
    public override OpenXmlElement CloneNode(bool deep)
    {
        return CloneImp<OfficeArtExtensionList>(deep);
    }

   
}
}
 
 
