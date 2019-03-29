// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Framework;
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

[OfficeAvailability(FileFormatVersions.Office2007)]
[SchemaAttr(15, "lockedCanvas")]
[Id(ElementTypeIdConst)]
public partial class LockedCanvas : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 10759;
    internal override int ElementTypeId => ElementTypeIdConst;

    
    
    
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
    
  
     
    
    
        internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Non-Visual Properties for a Group Shape.</para>
    /// <para> Represents the following element tag in the schema: a:nvGrpSpPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
	[Index(0)]
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
	[Index(1)]
    public DocumentFormat.OpenXml.Drawing.VisualGroupShapeProperties VisualGroupShapeProperties
	{
        get => GetElement<DocumentFormat.OpenXml.Drawing.VisualGroupShapeProperties>(1);
        set => SetElement(1, value);
	}
    


    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LockedCanvas>(deep);

}
}
 
 
