// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
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
/// <para>This class is available in Office 2007 or above.</para>
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

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NonVisualGroupShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.VisualGroupShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.TextShape))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Shape))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ConnectionShape))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Picture))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Office2010.Drawing.GvmlContentPart), FileFormatVersions.Office2010)]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GraphicFrame))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GroupShape))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GvmlGroupShapeExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2007)]
public partial class LockedCanvas : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10759;
    /// <inheritdoc/>
    public override string LocalName => "lockedCanvas";
    
    internal override byte NamespaceId => 15;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override FileFormatVersions InitialVersion => FileFormatVersions.Office2007;
    

    
    
    
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
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Non-Visual Properties for a Group Shape.</para>
    /// <para> Represents the following element tag in the schema: a:nvGrpSpPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.NonVisualGroupShapeProperties NonVisualGroupShapeProperties
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.NonVisualGroupShapeProperties>(0);
        set => SetElement(0, value);
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
        get => GetElement<DocumentFormat.OpenXml.Drawing.VisualGroupShapeProperties>(1);
        set => SetElement(1, value);
    }


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LockedCanvas>(deep);

}
}
 
 
