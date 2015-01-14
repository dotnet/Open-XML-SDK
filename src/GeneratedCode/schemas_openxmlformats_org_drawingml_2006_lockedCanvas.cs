// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
// This source file is machine generated.  Please do not change the code manually.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;

namespace DocumentFormat.OpenXml.Drawing.LockedCanvas
{
/// <summary>
/// <para>Locked Canvas Container.</para>
/// <para> When the object is serialized out as xml, its qualified name is lc:lockedCanvas.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.NonVisualGroupShapeProperties &lt;a:nvGrpSpPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.VisualGroupShapeProperties &lt;a:grpSpPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.TextShape &lt;a:txSp></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Shape &lt;a:sp></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.ConnectionShape &lt;a:cxnSp></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Picture &lt;a:pic></description></item>
///<item><description>DocumentFormat.OpenXml.Office2010.Drawing.GvmlContentPart &lt;a14:contentPart></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.GraphicFrame &lt;a:graphicFrame></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.GroupShape &lt;a:grpSp></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.GvmlGroupShapeExtensionList &lt;a:extLst></description></item>
/// </list>
/// </remarks>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NonVisualGroupShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.VisualGroupShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.TextShape))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Shape))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ConnectionShape))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Picture))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Drawing.GvmlContentPart),(FileFormatVersions)6)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GraphicFrame))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GroupShape))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GvmlGroupShapeExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public partial class LockedCanvas : OpenXmlCompositeElement
{
    private const string tagName = "lockedCanvas";
    /// <summary>
    /// Gets the local name of the element.
    /// </summary>
    public override string LocalName
    {
        get { return tagName; }
    }
    
    private const byte tagNsId = 15;
    internal override byte NamespaceId
    {
        get { return tagNsId; }
    }
    
    internal const int ElementTypeIdConst = 10759;
    
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
    /// Initializes a new instance of the LockedCanvas class.
    /// </summary>
    public LockedCanvas():base(){}
    
            /// <summary>
    ///Initializes a new instance of the LockedCanvas class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LockedCanvas(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the LockedCanvas class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public LockedCanvas(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the LockedCanvas class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public LockedCanvas(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "nvGrpSpPr" == name)
    return new DocumentFormat.OpenXml.Drawing.NonVisualGroupShapeProperties();
    
if( 10 == namespaceId && "grpSpPr" == name)
    return new DocumentFormat.OpenXml.Drawing.VisualGroupShapeProperties();
    
if( 10 == namespaceId && "txSp" == name)
    return new DocumentFormat.OpenXml.Drawing.TextShape();
    
if( 10 == namespaceId && "sp" == name)
    return new DocumentFormat.OpenXml.Drawing.Shape();
    
if( 10 == namespaceId && "cxnSp" == name)
    return new DocumentFormat.OpenXml.Drawing.ConnectionShape();
    
if( 10 == namespaceId && "pic" == name)
    return new DocumentFormat.OpenXml.Drawing.Picture();
    
if( 48 == namespaceId && "contentPart" == name)
    return new DocumentFormat.OpenXml.Office2010.Drawing.GvmlContentPart();
    
if( 10 == namespaceId && "graphicFrame" == name)
    return new DocumentFormat.OpenXml.Drawing.GraphicFrame();
    
if( 10 == namespaceId && "grpSp" == name)
    return new DocumentFormat.OpenXml.Drawing.GroupShape();
    
if( 10 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.GvmlGroupShapeExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "nvGrpSpPr","grpSpPr","txSp","sp","cxnSp","pic","contentPart","graphicFrame","grpSp","extLst" };
    private static readonly byte[] eleNamespaceIds = { 10,10,10,10,10,10,48,10,10,10 };
    
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
    /// <para> Non-Visual Properties for a Group Shape.</para>
    /// <para> Represents the following element tag in the schema: a:nvGrpSpPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.NonVisualGroupShapeProperties NonVisualGroupShapeProperties
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.NonVisualGroupShapeProperties>(0);
        }
        set
        {
            SetElement(0, value);
        }
    }
    /// <summary>
    /// <para> Visual Group Shape Properties.</para>
    /// <para> Represents the following element tag in the schema: a:grpSpPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.VisualGroupShapeProperties VisualGroupShapeProperties
    {
        get 
        {
            return GetElement<DocumentFormat.OpenXml.Drawing.VisualGroupShapeProperties>(1);
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
        return CloneImp<LockedCanvas>(deep);
    }

   
}
}
 
 
